Imports System.Collections.Generic

Partial Public Class MainForm

    Private Sub UpdateUI()

        ' Group zone
        GroupName.Enabled = CurrentGroup IsNot Nothing
        RenameButton.Enabled = CurrentGroup IsNot Nothing
        DeleteButton.Enabled = CurrentGroup IsNot Nothing
        If Not CurrentGroup Is Nothing Then GroupName.Text = CurrentGroup.IName

        ' Service zone
        AddButton.Enabled = CurrentGroup IsNot Nothing And CurrentServiceItem IsNot Nothing
        RemoveButton.Enabled = CurrentGroupItem IsNot Nothing Or CurrentGroup IsNot Nothing
        If CurrentGroup IsNot Nothing Then
            RemoveButton.Enabled = CurrentGroup.Parent IsNot Nothing
        End If

        ' Actions alignment
        If selectedTreeView Is GroupsTreeView Then
            StartGroup.ImageAlign = ContentAlignment.MiddleRight
            PauseGroup.ImageAlign = ContentAlignment.MiddleRight
            StopGroup.ImageAlign = ContentAlignment.MiddleRight

        ElseIf selectedTreeView Is ServicesTreeView Then
            StartGroup.ImageAlign = ContentAlignment.MiddleLeft
            PauseGroup.ImageAlign = ContentAlignment.MiddleLeft
            StopGroup.ImageAlign = ContentAlignment.MiddleLeft

        End If

        ' Actions zone
        If Selection Is Nothing Then
            StartGroup.Enabled = False
            StopGroup.Enabled = False
            PauseGroup.Enabled = False
        Else
            StartGroup.Enabled = Selection.CanBeStarted
            StopGroup.Enabled = Selection.CanBeStopped
            PauseGroup.Enabled = Selection.CanBePaused
        End If

        ' Toolstrip Menu
        If Selection Is Nothing Then
            TitleToolStripMenuItem.Text = "..."
            RenameToolStripMenuItem1.Enabled = False
            AddToolStripMenuItem.Enabled = False
            StartServiceToolStripMenuItem.Enabled = False
            StopServiceToolStripMenuItem.Enabled = False
            PauseServiceMenuItem.Enabled = False
            StartAutomaticallyToolStripMenuItem.Enabled = False
            StartingDisabledToolStripMenuItem.Enabled = False
            StartingManuallyToolStripMenuItem.Enabled = False
            ViewInformationToolStripMenuItem1.Enabled = False
        Else
            TitleToolStripMenuItem.Text = Selection.IName
            RenameToolStripMenuItem1.Enabled = TypeOf Selection Is GroupItem
            StartServiceToolStripMenuItem.Enabled = Selection.CanBeStarted
            StopServiceToolStripMenuItem.Enabled = Selection.CanBeStopped
            PauseServiceMenuItem.Enabled = Selection.CanBePaused
            StartAutomaticallyToolStripMenuItem.Enabled = True
            StartingDisabledToolStripMenuItem.Enabled = True
            StartingManuallyToolStripMenuItem.Enabled = True
            ViewInformationToolStripMenuItem1.Enabled = TypeOf Selection Is ServiceItem
        End If
        RemoveServiceFromGroupToolStripMenuItem.Enabled = RemoveButton.Enabled


        If GroupsTreeView.GetNodeCount(True) = 0 Then
            BigHelpLabel.Show()
            GroupsTreeView.Hide()
        Else
            BigHelpLabel.Hide()
            GroupsTreeView.Show()
        End If

        TextBox1.ForeColor = IIf(ServicesTreeView.Nodes.Count > 0, Color.Black, Color.BlueViolet)

    End Sub

    Private freezeUpdating As Boolean = False

    Private Sub UpdateServicesTreeView()
        If freezeUpdating = True Then Exit Sub
        Dim selected As ServiceItem = ServicesTreeView.SelectedNode

        Dim filter As String = TextBox1.Text.ToLower
        'Dim items As New ArrayList(roots)
        Dim showRunning As Boolean = StartedCheckBox.Checked
        Dim showPaused As Boolean = PausedCheckBox.Checked
        Dim showStopped As Boolean = StoppedCheckBox.Checked
        Dim showChanging As Boolean = WorkingCheckBox.Checked
        Dim showAuto As Boolean = AutomaticCheckBox.Checked
        Dim showManual As Boolean = ManualCheckBox.Checked
        Dim showDisabled As Boolean = DisabledCheckBox.Checked
        Dim showSystem As Boolean = SystemCheckbox.Checked
        Dim showUnknown As Boolean = UnknownCheckBox.Checked

        Dim newNodes As New List(Of ServiceItem)

        If Not ServiceManager Is Nothing Then
            For Each item As WIN32_Service In ServiceManager.Values
                If Not item.DisplayName.ToLower.IndexOf(filter) >= 0 Then Continue For

                Select Case item.State
                    Case WIN32_Service.States.Paused
                        If Not showPaused Then Continue For
                    Case WIN32_Service.States.Running
                        If Not showRunning Then Continue For
                    Case WIN32_Service.States.Stopped
                        If Not showStopped Then Continue For
                    Case WIN32_Service.States.ContinuePending, WIN32_Service.States.PausePending, _
                         WIN32_Service.States.StartPending, WIN32_Service.States.StopPending
                        If Not showChanging Then Continue For
                End Select

                Select Case item.StartMode
                    Case WIN32_Service.StartModes.Auto
                        If Not showAuto Then Continue For
                    Case WIN32_Service.StartModes.Disabled
                        If Not showDisabled Then Continue For
                    Case WIN32_Service.StartModes.Manual
                        If Not showManual Then Continue For
                    Case WIN32_Service.StartModes.System
                        If Not showSystem Then Continue For
                        'Case WIN32_Service.StartModes.Unknown
                        '    If Not showUnknown Then Continue For
                End Select

                If Visible = True Then newNodes.Add(New ServiceItem(item))
            Next

            Dim update As Boolean = False
            If newNodes.Count <> ServicesTreeView.Nodes.Count Then
                update = True
            Else
                For Each si As ServiceItem In newNodes
                    If Not ServicesTreeView.Nodes.Contains(si) Then
                        update = True
                        Exit For
                    End If
                Next
            End If

            If update = True Then
                ServicesTreeView.BeginUpdate()
                ServicesTreeView.Nodes.Clear()
                For Each si As ServiceItem In newNodes
                    ServicesTreeView.Nodes.Add(si)
                Next
                ServicesTreeView.EndUpdate()
            End If

            If Not selected Is Nothing Then
                ServicesTreeView.SelectedNode = selected
            End If

            UpdateUI()
        End If
    End Sub

End Class

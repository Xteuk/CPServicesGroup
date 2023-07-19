Partial Public Class MainForm

    Private Sub LoadConfiguration()
        GroupsTreeView.Nodes.Clear()
        GroupsTreeView.BeginUpdate()

        Try
            Dim cuad_with_version As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
            Dim cuad As String = New IO.DirectoryInfo(cuad_with_version).Parent.FullName

            Dim file As String = IO.Path.Combine(cuad, Me.tbHostName.Text + ".xml")
            If IO.File.Exists(file) = False Then Exit Sub

            Dim doc As New Xml.XmlDocument
            doc.Load(file)

            LoadSubRegistry(doc.DocumentElement, Nothing)

        Catch ex As Exception
        Finally
            GroupsTreeView.EndUpdate()
        End Try
    End Sub

    Private Sub LoadSubRegistry(ByVal key As Xml.XmlElement, ByVal parent As GroupItem)

        For Each subKey As Xml.XmlElement In key.SelectNodes("./Group")

            Dim group As New GroupItem
            group.Text = subKey.GetAttribute("name")
            'coll.Add(group)
            If parent IsNot Nothing Then
                parent.AddChild(group)
            Else
                GroupsTreeView.Nodes.Add(group)
            End If

            For Each value As Xml.XmlElement In subKey.SelectNodes("./Service")
                Dim service_name As String = value.GetAttribute("name")

                'Dim service As ServiceWithEvent
                Dim service As WIN32_Service
                service = TrouveService(service_name)
                If Not service Is Nothing Then
                    Dim si As New ServiceItem(service)
                    'si.Latest = infos.Contains("latest")
                    group.AddChild(si)
                End If
            Next

            LoadSubRegistry(subKey, group)
        Next

    End Sub

    Private Sub ToXml(ByVal si As IServiceNode, ByVal parent As Xml.XmlElement)
        Dim el As Xml.XmlElement

        If TypeOf si Is GroupItem Then

            el = parent.OwnerDocument.CreateElement("Group")
            el.SetAttribute("name", si.IName)
            For Each subsi As IServiceNode In CType(si, GroupItem).Nodes
                ToXml(subsi, el)
            Next

        ElseIf TypeOf si Is ServiceItem Then

            el = parent.OwnerDocument.CreateElement("Service")
            el.SetAttribute("name", si.IName)

        Else
            Return
        End If

        parent.AppendChild(el)

    End Sub

    Private Sub SaveConfiguration()
        Dim doc As New Xml.XmlDocument
        Dim root As Xml.XmlElement = doc.CreateElement("CPServicesGroup")
        doc.AppendChild(root)
        root.SetAttribute("version", My.Application.Info.Version.ToString())

        For Each sb As IServiceNode In GroupsTreeView.Nodes
            ToXml(sb, root)
        Next

        Dim cuad_with_version As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
        Dim cuad As String = New IO.DirectoryInfo(cuad_with_version).Parent.FullName

        Dim file As String = IO.Path.Combine(cuad, Me.tbHostName.Text + ".xml")
        doc.Save(file)
    End Sub

End Class

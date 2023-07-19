Partial Public Class MainForm

    ' Variable assignée par l'évènement "focus" sur les TreeView
    Private theSelectedTreeView As TreeView = Nothing

    Public Property SelectedTreeView As MTTreeView
        Get
            Return theSelectedTreeView
        End Get
        Set(ByVal value As MTTreeView)
            theSelectedTreeView = value
            UpdateUI()
        End Set
    End Property

    Public Property CurrentGroup As GroupItem
        Get
            If GroupsTreeView.SelectedNode Is Nothing Then Return Nothing
            If TypeOf GroupsTreeView.SelectedNode Is GroupItem Then Return GroupsTreeView.SelectedNode
            'If TypeOf GroupsTreeView.SelectedNode Is ServiceItem Then Return GroupsTreeView.SelectedNode.Parent
            Return Nothing
        End Get
        Set(ByVal value As GroupItem)

            If value Is Nothing Then
                GroupsTreeView.SelectedNode = Nothing
            ElseIf value.TreeView Is GroupsTreeView Then
                GroupsTreeView.SelectedNode = value
                value.EnsureVisible()
            End If

        End Set
    End Property

    Public Property CurrentGroupItem As ServiceItem
        Get
            If TypeOf GroupsTreeView.SelectedNode Is ServiceItem Then Return GroupsTreeView.SelectedNode
            Return Nothing
        End Get
        Set(ByVal value As ServiceItem)

            If value Is Nothing Then
                GroupsTreeView.SelectedNode = Nothing
            ElseIf value.TreeView Is GroupsTreeView Then
                GroupsTreeView.SelectedNode = value
                value.EnsureVisible()
            Else
                ' TODO: rechercher le service en question dans les groupes, et faire la "sélection"
            End If

        End Set
    End Property

    Public Property CurrentServiceItem As ServiceItem
        Get
            Return ServicesTreeView.SelectedNode
        End Get
        Set(ByVal value As ServiceItem)
            If value Is Nothing Then
                ServicesTreeView.SelectedNode = Nothing
            ElseIf value.TreeView.SelectedNode Is ServicesTreeView Then
                ServicesTreeView.SelectedNode = value
                value.EnsureVisible()
            End If
        End Set
    End Property

    Public Property Selection As IServiceNode
        Get
            If SelectedTreeView Is Nothing Then Return Nothing
            Return SelectedTreeView.SelectedNode
        End Get
        Set(ByVal value As IServiceNode)
            If value Is Nothing Then
                CurrentServiceItem = Nothing
                CurrentGroupItem = Nothing
            ElseIf CType(value, TreeNode).TreeView Is ServicesTreeView Then
                ServicesTreeView.Focus()
                CurrentServiceItem = value
            ElseIf CType(value, TreeNode).TreeView Is GroupsTreeView Then
                GroupsTreeView.Focus()
                If TypeOf value Is ServiceItem Then
                    CurrentGroupItem = value
                Else
                    CurrentGroup = value
                End If
            End If
        End Set
    End Property

    Public ReadOnly Property SelectedService As ServiceItem
        Get
            If TypeOf Selection Is ServiceItem Then Return Selection
            Return Nothing
        End Get
    End Property

End Class

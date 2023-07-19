Public Class MTTreeNode
    Inherits TreeNode

    Public ReadOnly Iterator Property NodeList As IEnumerable(Of TreeNode)
        Get
            For Each node As TreeNode In Nodes
                Yield node
            Next
        End Get
    End Property

    Public Overloads ReadOnly Property TreeView() As MTTreeView
        Get
            Return MyBase.TreeView
        End Get
    End Property

    Public Overloads Property ImageIndex() As Integer
        Get
            Return MyBase.ImageIndex
        End Get
        Set(ByVal value As Integer)
            If Not TreeView Is Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetImageIndex(Me, value, True)
                    Return
                End If
            End If
            MyBase.ImageIndex = value
        End Set
    End Property

    Public Overloads Property SelectedImageIndex() As Integer
        Get
            Return MyBase.SelectedImageIndex
        End Get
        Set(ByVal value As Integer)
            If Not TreeView Is Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetSelectedImageIndex(Me, value, True)
                    Return
                End If
            End If
            MyBase.SelectedImageIndex = value
        End Set
    End Property

    Public Overloads Property ImageKey() As String
        Get
            Return MyBase.ImageKey
        End Get
        Set(ByVal value As String)
            If Not TreeView Is Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetImageKey(Me, value, True)
                    Return
                End If
            End If
            MyBase.ImageKey = value
        End Set
    End Property

    Public Overloads Property SelectedImageKey() As String
        Get
            Return MyBase.SelectedImageKey
        End Get
        Set(ByVal value As String)
            If Not TreeView Is Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetSelectedImageKey(Me, value, True)
                    Return
                End If
            End If
            MyBase.SelectedImageKey = value
        End Set
    End Property

    Public Overloads Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            If Not TreeView Is Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetText(Me, value, True)
                    Return
                End If
            End If
            MyBase.Text = value
        End Set
    End Property

    Public Property Highlight As Boolean
        Get
            Return BackColor = SystemColors.Highlight
        End Get
        Set(ByVal value As Boolean)
            If TreeView IsNot Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetHighlight(Me, value, True)
                    Return
                End If
            End If
            MyBase.BackColor = IIf(value, SystemColors.Highlight, Color.Transparent)
            MyBase.ForeColor = IIf(value, SystemColors.HighlightText, Nothing)
        End Set
    End Property

    Public Overloads Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            If TreeView IsNot Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetBackColor(Me, value, True)
                    Return
                End If
            End If
            MyBase.BackColor = value
        End Set
    End Property

    Public Overloads Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            If TreeView IsNot Nothing Then
                If TreeView.InvokeRequired Then
                    TreeView.SetForeColor(Me, value, True)
                    Return
                End If
            End If
            MyBase.ForeColor = value
        End Set
    End Property

End Class

Imports System.Collections.Generic

Public Class MTTreeView
    Inherits TreeView

    Public Sub New()

    End Sub

    Public Sub SetImageIndex(ByVal item As TreeNode, ByVal index As Integer, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetItemIndexDelegate(AddressOf SetImageIndex), New Object() {item, index, False})
        Else
            item.ImageIndex = index
        End If
    End Sub

    Public Sub SetImageKey(ByVal item As TreeNode, ByVal key As String, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetItemTextDelegate(AddressOf SetImageKey), New Object() {item, key, False})
        Else
            If item.TreeView.ImageList.Images.ContainsKey(key) = False Then
                Console.Out.WriteLine("Image manquante : " & key)
            End If
            item.ImageKey = key
        End If
    End Sub

    Public Sub SetSelectedImageKey(ByVal item As TreeNode, ByVal key As String, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetItemTextDelegate(AddressOf SetSelectedImageKey), New Object() {item, key, False})
        Else
            item.SelectedImageKey = key
        End If
    End Sub

    Public Sub SetSelectedImageIndex(ByVal item As TreeNode, ByVal index As Integer, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetItemIndexDelegate(AddressOf SetSelectedImageIndex), New Object() {item, index, False})
        Else
            item.SelectedImageIndex = index
        End If
    End Sub

    Public Sub SetText(ByVal item As TreeNode, ByVal text As String, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetItemTextDelegate(AddressOf SetText), New Object() {item, text, False})
        Else
            item.Text = text
        End If
    End Sub

    Public Property SelectedNodes As TreeNode()
        Get
            Return selection.ToArray()
        End Get
        Set(ByVal value As TreeNode())
            selection.Clear()
            selection.AddRange(value)
        End Set
    End Property

    Protected Delegate Sub SetItemIndexDelegate(ByVal item As TreeNode, ByVal index As Integer, ByVal InvokeRequired As Boolean)
    Protected Delegate Sub SetItemTextDelegate(ByVal item As TreeNode, ByVal text As String, ByVal InvokeRequired As Boolean)
    Protected Delegate Sub SetColorDelegate(ByVal node As MTTreeNode, ByVal value As Color, ByVal InvokeRequired As Boolean)
    Protected Delegate Sub SetBooleanDelegate(ByVal node As MTTreeNode, ByVal value As Boolean, ByVal InvokeRequired As Boolean)
    Protected selection As New List(Of TreeNode)

    Private Sub MTTreeView_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles MyBase.MouseClick
        Dim node As MTTreeNode = Me.GetNodeAt(e.Location)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'MTTreeView
        '
        Me.ResumeLayout(False)

    End Sub

    Public Sub SetHighlight(ByVal node As MTTreeNode, ByVal value As Boolean, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetBooleanDelegate(AddressOf SetHighlight), New Object() {node, value, False})
        Else
            node.Highlight = value
        End If
    End Sub

    Public Sub SetBackColor(ByVal node As MTTreeNode, ByVal value As Color, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetColorDelegate(AddressOf SetBackColor), New Object() {node, value, False})
        Else
            node.BackColor = value
        End If
    End Sub

    Public Sub SetForeColor(ByVal node As MTTreeNode, ByVal value As Color, ByVal InvokeRequired As Boolean)
        If InvokeRequired Then
            Invoke(New SetColorDelegate(AddressOf SetForeColor), New Object() {node, value, False})
        Else
            node.ForeColor = value
        End If
    End Sub

End Class

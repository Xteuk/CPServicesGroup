Imports System.Linq

Public Class GroupItem
    Inherits MTTreeNode
    Implements IServiceNode

    Public Event StatusChanged(ByVal sender As IServiceNode) Implements IServiceNode.StatusChanged


    Public Sub New()
        ImageIndex = 5
        SelectedImageIndex = ImageIndex
    End Sub

    Public ReadOnly Property ContainsSystemService() As Boolean
        Get
            Dim v As IEnumerable(Of ServiceItem) =
                From service In AllServices
                Where service.Service.StartMode = WIN32_Service.StartModes.System

            Return v.FirstOrDefault() IsNot Nothing
        End Get
    End Property

    Public Sub StartAll() Implements IServiceNode.Start
        For Each item As IServiceNode In Nodes
            Dim ex As Exception
            Try
                If item.CanBeStarted Then item.Start()
            Catch ex
            Finally
            End Try
        Next
    End Sub

    Public Sub PauseAll() Implements IServiceNode.Pause
        For Each item As IServiceNode In Nodes
            Dim ex As Exception
            Try
                If item.CanBePaused Then item.Pause()
            Catch ex
            Finally
            End Try
        Next
    End Sub

    Public Sub StopAll() Implements IServiceNode.Stop
        For Each item As IServiceNode In Nodes
            Dim ex As Exception
            Try
                If item.CanBeStopped Then item.Stop()
            Catch ex
            Finally
            End Try
        Next
    End Sub

    Public Sub RefreshAll() _
        Implements IServiceNode.Refresh

        For Each item As IServiceNode In Nodes
            Dim ex As Exception
            Try
                item.Refresh()
            Catch ex
            Finally
            End Try
        Next
    End Sub

    Public Sub AddChild(ByVal service As IServiceNode)
        Nodes.Add(CType(service, TreeNode))
        AddHandler service.StatusChanged, AddressOf ServiceStatusChanged
        ServiceStatusChanged(service)
    End Sub

    Public Sub RemoveChild(ByVal service As IServiceNode)
        Nodes.Remove(CType(service, TreeNode))
        RemoveHandler service.StatusChanged, AddressOf ServiceStatusChanged
        ServiceStatusChanged(service)
    End Sub

    Private Sub ServiceStatusChanged(ByVal s As IServiceNode)
        ' Mise à jour des image suivant l'état des services...
        Dim imgKey As String = ""

        For Each service As ServiceItem In AllServices

            ' Case of Exception or Pending !
            If service.ImageKey = "Error" Then
                imgKey = "Error"
                Exit For
            End If
            If service.ImageKey.Contains("Pending") Then
                imgKey = "Pending"
                Exit For
            End If

            Dim supposed As String = ""
            If service.ImageKey.StartsWith("Paused") Then
                supposed = "Paused"
            ElseIf service.ImageKey.StartsWith("Running") Then
                supposed = "Running"
            ElseIf service.ImageKey.StartsWith("Stopped") Then
                supposed = "Stopped"
            ElseIf service.ImageKey.Contains("Pending") Then
                supposed = "Pending"
            End If

            If imgKey = "" Then
                imgKey = supposed
            ElseIf imgKey <> supposed Then
                imgKey = "Multiple"
            End If

        Next
        If imgKey = "" Then imgKey = "Multiple"
        If Not imgKey = ImageKey Then
            ImageKey = imgKey
            SelectedImageKey = ImageKey
            RaiseEvent StatusChanged(Me)
        End If
    End Sub

    Public ReadOnly Iterator Property AllServices As IEnumerable(Of ServiceItem)
        Get
            For Each node As TreeNode In Nodes
                If TypeOf node Is ServiceItem Then
                    Yield node
                ElseIf TypeOf node Is GroupItem Then
                    For Each si As ServiceItem In CType(node, GroupItem).AllServices
                        Yield si
                    Next
                End If
            Next

        End Get
    End Property

    Public ReadOnly Property Services As IEnumerable(Of ServiceItem)
        Get
            Return NodeList.
                Where(Function(x) TypeOf x Is ServiceItem).
                Cast(Of ServiceItem)()

        End Get
    End Property

    Public ReadOnly Property SubGroups As IEnumerable(Of GroupItem)
        Get
            Return NodeList.
                Where(Function(x) TypeOf x Is GroupItem).
                Cast(Of GroupItem)()

        End Get
    End Property

    Public Function ContainsService(ByVal service As ServiceItem) As Boolean

        Return AllServices.Where(Function(x) x.Name = service.Name).FirstOrDefault() IsNot Nothing

    End Function

    Public ReadOnly Property IName As String _
        Implements IServiceNode.IName

        Get
            Return Text
        End Get
    End Property

    Public Property GroupName As String
        Get
            Return IName
        End Get
        Set(ByVal value As String)
            Text = value
        End Set
    End Property

    Public Sub StartAuto() Implements IServiceNode.StartAuto
        For Each sb As IServiceNode In Nodes
            sb.StartAuto()
        Next
    End Sub

    Public Sub StartManual() Implements IServiceNode.StartManual
        For Each sb As IServiceNode In Nodes
            sb.StartManual()
        Next
    End Sub

    Public Sub StartDisabled() Implements IServiceNode.StartDisabled
        For Each sb As IServiceNode In Nodes
            sb.StartDisabled()
        Next
    End Sub

    Public ReadOnly Property CanBeStopped As Boolean Implements IServiceNode.CanBeStopped
        Get
            For Each sb As IServiceNode In Nodes
                If sb.CanBeStopped = True Then Return True
            Next
            Return False
        End Get
    End Property

    Public ReadOnly Property CanBeStarted As Boolean Implements IServiceNode.CanBeStarted
        Get
            For Each sb As IServiceNode In Nodes
                If sb.CanBeStarted = True Then Return True
            Next
            Return False
        End Get
    End Property

    Public ReadOnly Property CanBePaused As Boolean Implements IServiceNode.CanBePaused
        Get
            For Each sb As IServiceNode In Nodes
                If sb.CanBePaused = True Then Return True
            Next
            Return False
        End Get
    End Property

    Public Sub Rename(ByVal new_name As String)
        Text = new_name
    End Sub

End Class

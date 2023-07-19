Public Class ServiceItem
    Inherits MTTreeNode
    Implements IServiceNode

    Public Event StatusChanged(ByVal sender As IServiceNode) Implements IServiceNode.StatusChanged

    'Protected WithEvents theService As ServiceWithEvent
    Protected WithEvents theService As WIN32_Service
    Protected Delegate Sub InvokeInteger(ByVal i As Integer)

    Sub New(ByVal aService As WIN32_Service)
        'theService = New ServiceWithEvent(aService)
        theService = aService
        init()
    End Sub

    'Sub New(ByVal aService As ServiceWithEvent)
    '    theService = aService
    '    init()
    'End Sub

    Protected Sub init()
        Text = theService.DisplayName
        HandleService(theService)
    End Sub

    Public ReadOnly Property Service() _
    As WIN32_Service
        'As ServiceWithEvent
        Get
            Service = theService
        End Get
    End Property

    Public Sub Refresh() _
        Implements IServiceNode.Refresh

        theService.Refresh()
        Redraw()
    End Sub

    Protected Sub Redraw(Optional ByVal suffix As String = Nothing)
        Dim key As String = theService.State.ToString()
        Select Case theService.StartMode
            Case WIN32_Service.StartModes.Disabled,
                 WIN32_Service.StartModes.Auto,
                 WIN32_Service.StartModes.Manual,
                 WIN32_Service.StartModes.System,
                 WIN32_Service.StartModes.Unknown
                ImageKey = key & theService.StartMode.ToString()
            Case Else
                ImageKey = key
        End Select

        SelectedImageKey = ImageKey
        If suffix Is Nothing Then
            Text = theService.DisplayName
        Else
            Text = theService.DisplayName & " (" & suffix & ")"
        End If
    End Sub

    Protected Sub HandleService(ByVal sender As WIN32_Service) _
    Handles theService.PropertyChanged

        Redraw()
        RaiseEvent StatusChanged(Me)

    End Sub

    Protected Sub HandlePending(ByVal sender As WIN32_Service) _
    Handles theService.OperationPending

        Redraw()
        RaiseEvent StatusChanged(Me)

    End Sub

    Protected Sub HandleException(ByVal sender As WIN32_Service, ByVal ex As Exception) _
    Handles theService.ExceptionRaised

        theService.Refresh()
        Redraw(ex.Message)
        'Text = theService.DisplayName & " (" & ex.Message & ")"
        'RaiseEvent StatusChanged(Me)

    End Sub

    Public ReadOnly Property IName _
        As String _
        Implements IServiceNode.IName

        Get
            Return Service.Name
        End Get
    End Property

    Public Sub [Pause]() Implements IServiceNode.Pause
        Service.PauseService()
    End Sub

    Public Sub Start() Implements IServiceNode.Start
        If Service.State = WIN32_Service.States.Paused Then
            Service.ResumeService()
        Else
            Service.StartService()
        End If
    End Sub

    Public Sub [Stop]() Implements IServiceNode.Stop
        Service.StopService()
    End Sub

    Public Sub StartAuto() Implements IServiceNode.StartAuto
        Service.ChangeStartMode(WIN32_Service.StartModes.Auto)
    End Sub

    Public Sub StartManual() Implements IServiceNode.StartManual
        Service.ChangeStartMode(WIN32_Service.StartModes.Manual)
    End Sub

    Public Sub StartDisabled() Implements IServiceNode.StartDisabled
        Service.ChangeStartMode(WIN32_Service.StartModes.Disabled)
    End Sub

    Public ReadOnly Property CanBeStopped As Boolean Implements IServiceNode.CanBeStopped
        Get
            Return Service.AcceptStop
        End Get
    End Property

    Public ReadOnly Property CanBeStarted As Boolean Implements IServiceNode.CanBeStarted
        Get

            Select Case Service.State
                Case WIN32_Service.States.Running
                    Return False
                Case WIN32_Service.States.StopPending, _
                     WIN32_Service.States.StartPending, _
                     WIN32_Service.States.PausePending, _
                     WIN32_Service.States.ContinuePending
                    Return False
            End Select

            Select Case Service.StartMode
                Case WIN32_Service.StartModes.Disabled
                    Return False
            End Select

            Return True
        End Get
    End Property

    Public ReadOnly Property CanBePaused As Boolean Implements IServiceNode.CanBePaused
        Get
            Return Service.State <> WIN32_Service.States.Paused And Service.AcceptPause
        End Get
    End Property

End Class

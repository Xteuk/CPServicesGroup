Public Interface IServiceNode

    Sub Refresh()

    Sub [Start]()
    Sub [Pause]()
    Sub [Stop]()

    Sub StartAuto()
    Sub StartManual()
    Sub StartDisabled()

    ReadOnly Property CanBeStopped As Boolean
    ReadOnly Property CanBeStarted As Boolean
    ReadOnly Property CanBePaused As Boolean

    ReadOnly Property IName As String

    Event StatusChanged(ByVal sender As IServiceNode)

End Interface

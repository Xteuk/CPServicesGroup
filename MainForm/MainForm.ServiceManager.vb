Partial Public Class MainForm

    Private theServiceManager As WIN32_Services = Nothing
    'Private theProcessManager As WIN32_Processes = Nothing

    Private Property ServiceManager As WIN32_Services
        Get
            Return theServiceManager
        End Get
        Set(ByVal value As WIN32_Services)
            If theServiceManager IsNot Nothing Then
                theServiceManager.Dispose()
            End If
            theServiceManager = value
        End Set
    End Property

    'Private Property ProcessManager As WIN32_Processes
    '    Get
    '        Return theProcessManager
    '    End Get
    '    Set(ByVal value As WIN32_Processes)
    '        If theProcessManager IsNot Nothing Then
    '            theProcessManager.Dispose()
    '        End If
    '        theProcessManager = value
    '    End Set
    'End Property

    Private Sub LoadServices()

        ServiceManager = New WIN32_Services(tbHostName.Text)
        'ProcessManager = New WIN32_Processes(tbHostName.Text)

        ServicesTreeView.Nodes.Clear()
        GroupsTreeView.Nodes.Clear()
        'ProcessesTreeView.Nodes.Clear()

        For Each service As WIN32_Service In ServiceManager.Values
            AddService(service)
        Next

        'For Each proc As WIN32_Process In ProcessManager.Values
        '    AddProcess(proc)
        'Next

        LoadConfiguration()
        UpdateUI()
    End Sub

End Class

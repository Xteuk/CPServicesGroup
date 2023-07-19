Imports System.Collections.Generic
Imports System.Management

Public MustInherit Class WIN32_Manager(Of T As {New, WIN32_ManagedItem})
    Inherits Dictionary(Of String, T)
    Implements IDisposable

    Public MustOverride ReadOnly Property KeyName As String

    Private ReadOnly ManagedType As String = GetType(T).Name
    Private query As New WqlEventQuery("__InstanceModificationEvent", New TimeSpan(0, 0, 1), _
                                       "TargetInstance isa """ & ManagedType & """")
    Private WithEvents watcher As New ManagementEventWatcher(query)
    Private theHost As String = "localhost"

    Public Event ObjectPropertyChanged(ByVal sender As WIN32_Manager(Of T), ByVal obj As T)

    Public ReadOnly Property Host As String
        Get
            Return theHost
        End Get
    End Property

    Public Sub New(Optional ByVal host As String = "localhost")
        theHost = host

        Dim co As New ConnectionOptions()
        Dim ms As New System.Management.ManagementScope("\\" + theHost + "\root\cimv2", co)
        Dim oq As New System.Management.ObjectQuery("SELECT * FROM " & ManagedType)
        Dim query As New ManagementObjectSearcher(ms, oq)
        For Each mo As ManagementObject In query.Get()
            Dim s As T = New T
            s.ManagementObject = mo
            Add(s.ManagementObject(KeyName), s)
        Next

        watcher.Start()
    End Sub

    Public Overloads Sub Dispose() _
        Implements IDisposable.Dispose

        If Not watcher Is Nothing Then watcher.Stop()
        watcher = Nothing

    End Sub

    Private Sub EventArrived(ByVal sender As Object, ByVal e As System.Management.EventArrivedEventArgs) _
        Handles watcher.EventArrived

        Dim mo As ManagementBaseObject = e.NewEvent
        Dim bo As ManagementBaseObject = mo("TargetInstance")
        Dim name As String = bo(KeyName)
        If ContainsKey(name) Then
            Dim serv As T = Me(name)
            serv.Update(bo)
            RaiseEvent ObjectPropertyChanged(Me, serv)
        End If

    End Sub

    Private Shared Sub Essai(ByVal strComputer As String, ByVal strDomain As String, ByVal strUser As String, ByVal strPassword As String)
        'Dim strComputer As String = "FullComputerName"
        'Dim strDomain As String = "DOMAIN"
        'Dim strUser As String = InputBox("Enter user name")
        'strPassword = InputBox("Enter password")
        Dim objSWbemLocator As New WbemScripting.SWbemLocator
        'Dim objSWbemLocator As Object = CreateObject("WbemScripting.SWbemLocator")
        Dim objWMIService As WbemScripting.SWbemServices
        If strComputer = "localhost" Then
            objWMIService = objSWbemLocator.ConnectServer(strComputer, _
                "root\CIMV2")
        Else
            objWMIService = objSWbemLocator.ConnectServer(strComputer, _
                "root\CIMV2", _
                strUser, _
                strPassword, _
                "MS_409", _
                "ntlmdomain:" + strDomain)
        End If
        Dim colProcessList As WbemScripting.SWbemObjectSet = objWMIService.ExecQuery _
            ("SELECT * FROM Win32_Process WHERE Name = 'procexp.exe'")
        For Each objProcess As WbemScripting.SWbemObject In colProcessList
            Console.Out.WriteLine(objProcess.Name)
        Next
    End Sub

End Class

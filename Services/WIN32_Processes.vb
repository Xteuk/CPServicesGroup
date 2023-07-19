Imports System.Management
Imports System.Collections.Generic

Public Class WIN32_Processes
    Inherits WIN32_Manager(Of WIN32_Process)
    Implements IDisposable

    Public Sub New(Optional ByVal host As String = "localhost")
        MyBase.New(host)
    End Sub

    Public Overrides ReadOnly Property KeyName As String
        Get
            Return "ProcessId"
        End Get
    End Property

    'Private Shared Sub Essai(ByVal strComputer As String, ByVal strDomain As String, ByVal strUser As String, ByVal strPassword As String)
    '    'Dim strComputer As String = "FullComputerName"
    '    'Dim strDomain As String = "DOMAIN"
    '    'Dim strUser As String = InputBox("Enter user name")
    '    'strPassword = InputBox("Enter password")
    '    Dim objSWbemLocator As New WbemScripting.SWbemLocator
    '    'Dim objSWbemLocator As Object = CreateObject("WbemScripting.SWbemLocator")
    '    Dim objWMIService As WbemScripting.SWbemServices
    '    If strComputer = "localhost" Then
    '        objWMIService = objSWbemLocator.ConnectServer(strComputer, _
    '            "root\CIMV2")
    '    Else
    '        objWMIService = objSWbemLocator.ConnectServer(strComputer, _
    '            "root\CIMV2", _
    '            strUser, _
    '            strPassword, _
    '            "MS_409", _
    '            "ntlmdomain:" + strDomain)
    '    End If
    '    Dim colProcessList As WbemScripting.SWbemObjectSet = objWMIService.ExecQuery _
    '        ("SELECT * FROM Win32_Process WHERE Name = 'procexp.exe'")
    '    For Each objProcess As WbemScripting.SWbemObject In colProcessList
    '        Console.Out.WriteLine(objProcess.Name)
    '    Next
    'End Sub

End Class

Imports System.Management
Imports System.Collections.Generic

Public Class WIN32_Services
    Inherits WIN32_Manager(Of WIN32_Service)
    Implements IDisposable

    Public Sub New(Optional ByVal host As String = "localhost")
        MyBase.New(host)
    End Sub

    Public Overrides ReadOnly Property KeyName As String
        Get
            Return "Name"
        End Get
    End Property

End Class

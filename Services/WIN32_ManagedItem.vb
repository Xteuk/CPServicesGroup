Imports System.Management

Public MustInherit Class WIN32_ManagedItem

    Public Event PropertyChanged(ByVal sender As WIN32_ManagedItem)
    Public Event OperationPending(ByVal sender As WIN32_ManagedItem)
    Public Event ExceptionRaised(ByVal sender As WIN32_ManagedItem, ByVal ex As Exception)

    Private mclass As ManagementClass
    Public ReadOnly Property ManagementClass As ManagementClass
        Get
            If mclass Is Nothing Then
                mclass = New ManagementClass(ManagementObject.ClassPath)
            End If
            Return mclass
        End Get
    End Property

    Protected Friend ManagementObject As ManagementObject

    Public Sub New(ByVal mo As ManagementObject)
        ManagementObject = mo
    End Sub

    Public Sub Refresh()
        ManagementObject.Get()
        'ManagementObject = New ManagementObject(New ManagementPath("Win32_Service.Name='" & Name & "'"))
    End Sub

    Public Sub Update(ByVal mo As ManagementBaseObject)
        If mo Is ManagementObject Then
            ManagementObject = mo
        Else
            Refresh()
        End If

        RaiseEventPropertyChanged()
    End Sub

    Protected Sub RaiseEventPropertyChanged()
        RaiseEvent PropertyChanged(Me)
    End Sub

    Protected Sub RaiseEventOperationPending()
        RaiseEvent OperationPending(Me)
    End Sub

    Protected Sub RaiseEventExceptionRaised(ByVal ex As Exception)
        RaiseEvent ExceptionRaised(Me, ex)
    End Sub

    ''' <summary>
    ''' This attribute is used to represent a string value
    ''' for a value in an enum.
    ''' </summary>
    Public Class StringValue
        Inherits Attribute

        Public Shared Function [Get](ByVal o As Object) As String
            Dim attr As System.Attribute = System.Attribute.GetCustomAttribute(o.GetType(), GetType(StringValue))
            If attr Is Nothing Then Return ""
            Return CType(attr, StringValue).StringValue
        End Function

#Region "Properties"
        Private value As String = ""

        ''' <summary>
        ''' Holds the stringvalue for a value in an enum.
        ''' </summary>
        Public Property StringValue As String
            Get
                Return value
            End Get
            Protected Set(ByVal value As String)
                Me.value = value
            End Set
        End Property

#End Region

#Region "Constructor"

        ''' <summary>
        ''' Constructor used to init a StringValue Attribute
        ''' </summary>
        ''' <param name="value"></param>
        Public Sub New(ByVal value As String)
            StringValue = value
        End Sub

#End Region

    End Class

End Class

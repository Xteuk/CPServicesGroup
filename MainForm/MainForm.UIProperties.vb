Partial Public Class MainForm

    Public Property Host As String
        Get
            Return tbHostName.Text
        End Get
        Set(ByVal value As String)
            If value = Nothing Or value = "" Then value = "localhost"
            tbHostName.Text = value
        End Set
    End Property

End Class

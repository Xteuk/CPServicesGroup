Public Class ServiceDetailPanel

    'Public Sub New(ByVal images As ImageList, ByVal service As ServiceWithEvent)

    '    ImageList = images
    '    the_service = service

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    UpdateService()

    'End Sub

    Public Property Service As WIN32_Service
        Get
            Return the_service
        End Get
        Set(ByVal value As WIN32_Service)
            If Not the_service Is Nothing Then
                RemoveHandler the_service.PropertyChanged, AddressOf OnUpdateService
            End If

            the_service = value
            AddHandler the_service.PropertyChanged, AddressOf OnUpdateService
            UpdateService()
        End Set
    End Property

    Public ImageList As ImageList = Nothing
    Private the_service As WIN32_Service = Nothing
    Private Sub OnUpdateService(ByVal sender As WIN32_ManagedItem)
        UpdateService()
    End Sub

    Private Delegate Sub EmptyDelegate()
    Private Sub UpdateService()
        'Handles the_service.PropertyChanged
        If InvokeRequired Then
            Invoke(New EmptyDelegate(AddressOf UpdateService))
        Else
            tbRealName.Text = the_service.Name
            tbDisplayName.Text = the_service.DisplayName
            tbDescription.Text = the_service.Description
            tbStateText.Text = the_service.State.ToString()

            tbStartupText.Text = the_service.StartMode.ToString()

            cbCanPause.Checked = the_service.AcceptPause
            cbCanStop.Checked = the_service.AcceptStop
            cbInteract.Checked = the_service.DesktopInteract

            tbOnError.Text = the_service.ErrorControl.ToString()
            tbHost.Text = the_service.SystemName
            tbProcess.Text = the_service.PathName
            tbProcessId.Text = the_service.ProcessId

            If Not ImageList Is Nothing Then
                lbStateImage.Image = ImageList.Images(tbStateText.Text)
                lbStartupImage.Image = ImageList.Images(tbStartupText.Text)
            End If
        End If

    End Sub

End Class
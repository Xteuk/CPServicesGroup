Imports Microsoft.Win32
Imports System.Collections.Generic

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region "Variables"

    Private splash As New Splash
    Private GroupsTreeView_LatestOpenedB_DragDrop As TreeNode = Nothing ' utilisé pour l'ouverture automatique lorsqu'on survole un groupe au drag 'n drop

    Friend WithEvents Images32Width As System.Windows.Forms.ImageList
    Friend WithEvents AutomaticCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StartAutomaticallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartingManuallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartingDisabledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartupImages As System.Windows.Forms.ImageList
    Friend WithEvents SystemCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents DisabledCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ManualCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UnknownCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PauseGroup As System.Windows.Forms.Button
    Friend WithEvents PauseServiceMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbHostName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btSearchHost As System.Windows.Forms.Button
    Friend WithEvents RenameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewInformationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        splash.Show()
        Application.DoEvents()

        Try
            'This call is required by the Windows Form Designer.
            InitializeComponent()
        Catch ex As Exception
        End Try

        'Settings.tr(Me)

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents StatusImages As System.Windows.Forms.ImageList
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupName As System.Windows.Forms.TextBox
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents StartGroup As System.Windows.Forms.Button
    Friend WithEvents StopGroup As System.Windows.Forms.Button
    Friend WithEvents RenameButton As System.Windows.Forms.Button
    Friend WithEvents GroupsTreeView As MTTreeView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents BigHelpLabel As System.Windows.Forms.Label
    Friend WithEvents ServicesTreeView As MTTreeView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents WorkingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StoppedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PausedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StartedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServiceContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveServiceFromGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusImages = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.Images32Width = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BigHelpLabel = New System.Windows.Forms.Label()
        Me.GroupsTreeView = New CPServicesGroup.MTTreeView()
        Me.ServiceContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseServiceMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartAutomaticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartingManuallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartingDisabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewInformationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveServiceFromGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StartGroup = New System.Windows.Forms.Button()
        Me.PauseGroup = New System.Windows.Forms.Button()
        Me.StopGroup = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.GroupName = New System.Windows.Forms.TextBox()
        Me.RenameButton = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.StartupImages = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StartedCheckBox = New System.Windows.Forms.CheckBox()
        Me.UnknownCheckBox = New System.Windows.Forms.CheckBox()
        Me.PausedCheckBox = New System.Windows.Forms.CheckBox()
        Me.SystemCheckbox = New System.Windows.Forms.CheckBox()
        Me.StoppedCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisabledCheckBox = New System.Windows.Forms.CheckBox()
        Me.WorkingCheckBox = New System.Windows.Forms.CheckBox()
        Me.ManualCheckBox = New System.Windows.Forms.CheckBox()
        Me.AutomaticCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ServicesTreeView = New CPServicesGroup.MTTreeView()
        Me.btSearchHost = New System.Windows.Forms.Button()
        Me.tbHostName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.ServiceContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusImages
        '
        Me.StatusImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.StatusImages.ImageSize = New System.Drawing.Size(16, 16)
        Me.StatusImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.White
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Black
        Me.CloseButton.Location = New System.Drawing.Point(19, 509)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(115, 26)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.BackColor = System.Drawing.Color.White
        Me.AboutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.ForeColor = System.Drawing.Color.Black
        Me.AboutButton.Location = New System.Drawing.Point(115, 475)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(19, 27)
        Me.AboutButton.TabIndex = 3
        Me.AboutButton.Text = "?"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'Images32Width
        '
        Me.Images32Width.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.Images32Width.ImageSize = New System.Drawing.Size(32, 16)
        Me.Images32Width.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.BigHelpLabel)
        Me.Panel4.Controls.Add(Me.GroupsTreeView)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(540, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(536, 553)
        Me.Panel4.TabIndex = 9
        '
        'BigHelpLabel
        '
        Me.BigHelpLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BigHelpLabel.BackColor = System.Drawing.Color.White
        Me.BigHelpLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BigHelpLabel.Location = New System.Drawing.Point(167, 106)
        Me.BigHelpLabel.Name = "BigHelpLabel"
        Me.BigHelpLabel.Size = New System.Drawing.Size(114, 238)
        Me.BigHelpLabel.TabIndex = 9
        Me.BigHelpLabel.Text = resources.GetString("BigHelpLabel.Text")
        '
        'GroupsTreeView
        '
        Me.GroupsTreeView.AllowDrop = True
        Me.GroupsTreeView.ContextMenuStrip = Me.ServiceContextMenuStrip1
        Me.GroupsTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupsTreeView.FullRowSelect = True
        Me.GroupsTreeView.HideSelection = False
        Me.GroupsTreeView.ImageIndex = 0
        Me.GroupsTreeView.ImageList = Me.Images32Width
        Me.GroupsTreeView.LabelEdit = True
        Me.GroupsTreeView.Location = New System.Drawing.Point(159, 5)
        Me.GroupsTreeView.Name = "GroupsTreeView"
        Me.GroupsTreeView.SelectedImageIndex = 0
        Me.GroupsTreeView.SelectedNodes = New System.Windows.Forms.TreeNode(-1) {}
        Me.GroupsTreeView.Size = New System.Drawing.Size(372, 543)
        Me.GroupsTreeView.Sorted = True
        Me.GroupsTreeView.TabIndex = 8
        '
        'ServiceContextMenuStrip1
        '
        Me.ServiceContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ServiceContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripMenuItem, Me.ToolStripSeparator3, Me.RenameToolStripMenuItem1, Me.ToolStripSeparator8, Me.StartServiceToolStripMenuItem, Me.PauseServiceMenuItem, Me.StopServiceToolStripMenuItem, Me.ToolStripSeparator4, Me.StartAutomaticallyToolStripMenuItem, Me.StartingManuallyToolStripMenuItem, Me.StartingDisabledToolStripMenuItem, Me.ToolStripSeparator1, Me.ViewInformationToolStripMenuItem1, Me.ToolStripSeparator2, Me.RemoveServiceFromGroupToolStripMenuItem, Me.AddToolStripMenuItem})
        Me.ServiceContextMenuStrip1.Name = "ServiceContextMenuStrip1"
        Me.ServiceContextMenuStrip1.Size = New System.Drawing.Size(231, 320)
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TitleToolStripMenuItem.Enabled = False
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.TitleToolStripMenuItem.Text = "Nom de la sélection"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(227, 6)
        '
        'RenameToolStripMenuItem1
        '
        Me.RenameToolStripMenuItem1.Name = "RenameToolStripMenuItem1"
        Me.RenameToolStripMenuItem1.Size = New System.Drawing.Size(230, 26)
        Me.RenameToolStripMenuItem1.Text = "Rename"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(227, 6)
        '
        'StartServiceToolStripMenuItem
        '
        Me.StartServiceToolStripMenuItem.Image = CType(resources.GetObject("StartServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartServiceToolStripMenuItem.Name = "StartServiceToolStripMenuItem"
        Me.StartServiceToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StartServiceToolStripMenuItem.Text = "Start Service"
        '
        'PauseServiceMenuItem
        '
        Me.PauseServiceMenuItem.Image = Global.CPServicesGroup.My.Resources.Resources._pause
        Me.PauseServiceMenuItem.Name = "PauseServiceMenuItem"
        Me.PauseServiceMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.PauseServiceMenuItem.Text = "Pause Service"
        '
        'StopServiceToolStripMenuItem
        '
        Me.StopServiceToolStripMenuItem.Image = CType(resources.GetObject("StopServiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopServiceToolStripMenuItem.Name = "StopServiceToolStripMenuItem"
        Me.StopServiceToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StopServiceToolStripMenuItem.Text = "Stop Service"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(227, 6)
        '
        'StartAutomaticallyToolStripMenuItem
        '
        Me.StartAutomaticallyToolStripMenuItem.Image = Global.CPServicesGroup.My.Resources.Resources.automatic
        Me.StartAutomaticallyToolStripMenuItem.Name = "StartAutomaticallyToolStripMenuItem"
        Me.StartAutomaticallyToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StartAutomaticallyToolStripMenuItem.Text = "Starting Automatically"
        '
        'StartingManuallyToolStripMenuItem
        '
        Me.StartingManuallyToolStripMenuItem.Image = Global.CPServicesGroup.My.Resources.Resources.main
        Me.StartingManuallyToolStripMenuItem.Name = "StartingManuallyToolStripMenuItem"
        Me.StartingManuallyToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StartingManuallyToolStripMenuItem.Text = "Starting Manually"
        '
        'StartingDisabledToolStripMenuItem
        '
        Me.StartingDisabledToolStripMenuItem.Image = Global.CPServicesGroup.My.Resources.Resources.disabled
        Me.StartingDisabledToolStripMenuItem.Name = "StartingDisabledToolStripMenuItem"
        Me.StartingDisabledToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.StartingDisabledToolStripMenuItem.Text = "Starting Disabled"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'ViewInformationToolStripMenuItem1
        '
        Me.ViewInformationToolStripMenuItem1.Name = "ViewInformationToolStripMenuItem1"
        Me.ViewInformationToolStripMenuItem1.Size = New System.Drawing.Size(230, 26)
        Me.ViewInformationToolStripMenuItem1.Text = "View Information"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(227, 6)
        '
        'RemoveServiceFromGroupToolStripMenuItem
        '
        Me.RemoveServiceFromGroupToolStripMenuItem.Name = "RemoveServiceFromGroupToolStripMenuItem"
        Me.RemoveServiceFromGroupToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.RemoveServiceFromGroupToolStripMenuItem.Text = "Remove"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.AboutButton)
        Me.Panel2.Controls.Add(Me.CloseButton)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(154, 543)
        Me.Panel2.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StartGroup)
        Me.GroupBox3.Controls.Add(Me.PauseGroup)
        Me.GroupBox3.Controls.Add(Me.StopGroup)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(10, 323)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 130)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Actions"
        '
        'StartGroup
        '
        Me.StartGroup.BackColor = System.Drawing.Color.White
        Me.StartGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StartGroup.Image = CType(resources.GetObject("StartGroup.Image"), System.Drawing.Image)
        Me.StartGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StartGroup.Location = New System.Drawing.Point(10, 22)
        Me.StartGroup.Name = "StartGroup"
        Me.StartGroup.Size = New System.Drawing.Size(115, 28)
        Me.StartGroup.TabIndex = 0
        Me.StartGroup.Text = "Start"
        Me.StartGroup.UseVisualStyleBackColor = False
        '
        'PauseGroup
        '
        Me.PauseGroup.BackColor = System.Drawing.Color.White
        Me.PauseGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PauseGroup.Image = Global.CPServicesGroup.My.Resources.Resources._pause
        Me.PauseGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PauseGroup.Location = New System.Drawing.Point(10, 57)
        Me.PauseGroup.Name = "PauseGroup"
        Me.PauseGroup.Size = New System.Drawing.Size(115, 26)
        Me.PauseGroup.TabIndex = 0
        Me.PauseGroup.Text = "Pause"
        Me.PauseGroup.UseVisualStyleBackColor = False
        '
        'StopGroup
        '
        Me.StopGroup.BackColor = System.Drawing.Color.White
        Me.StopGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StopGroup.Image = CType(resources.GetObject("StopGroup.Image"), System.Drawing.Image)
        Me.StopGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StopGroup.Location = New System.Drawing.Point(10, 90)
        Me.StopGroup.Name = "StopGroup"
        Me.StopGroup.Size = New System.Drawing.Size(115, 27)
        Me.StopGroup.TabIndex = 0
        Me.StopGroup.Text = "Stop"
        Me.StopGroup.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemoveButton)
        Me.GroupBox2.Controls.Add(Me.AddButton)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(10, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 106)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Service"
        '
        'RemoveButton
        '
        Me.RemoveButton.BackColor = System.Drawing.Color.White
        Me.RemoveButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RemoveButton.Image = Global.CPServicesGroup.My.Resources.Resources._rewind
        Me.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveButton.Location = New System.Drawing.Point(10, 65)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(115, 26)
        Me.RemoveButton.TabIndex = 0
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.White
        Me.AddButton.ForeColor = System.Drawing.Color.Black
        Me.AddButton.Image = Global.CPServicesGroup.My.Resources.Resources._forward
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(10, 28)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(115, 26)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.GroupName)
        Me.GroupBox1.Controls.Add(Me.RenameButton)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 166)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Group"
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.White
        Me.NewButton.ForeColor = System.Drawing.Color.Black
        Me.NewButton.Image = Global.CPServicesGroup.My.Resources.Resources._forward
        Me.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton.Location = New System.Drawing.Point(10, 83)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(115, 27)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.White
        Me.DeleteButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteButton.Image = Global.CPServicesGroup.My.Resources.Resources._rewind
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.Location = New System.Drawing.Point(10, 120)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(115, 27)
        Me.DeleteButton.TabIndex = 0
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'GroupName
        '
        Me.GroupName.Location = New System.Drawing.Point(10, 28)
        Me.GroupName.Name = "GroupName"
        Me.GroupName.Size = New System.Drawing.Size(76, 22)
        Me.GroupName.TabIndex = 1
        '
        'RenameButton
        '
        Me.RenameButton.BackColor = System.Drawing.Color.White
        Me.RenameButton.Image = Global.CPServicesGroup.My.Resources.Resources._forward
        Me.RenameButton.Location = New System.Drawing.Point(96, 28)
        Me.RenameButton.Name = "RenameButton"
        Me.RenameButton.Size = New System.Drawing.Size(29, 26)
        Me.RenameButton.TabIndex = 0
        Me.RenameButton.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(540, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 553)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'StartupImages
        '
        Me.StartupImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.StartupImages.ImageSize = New System.Drawing.Size(16, 16)
        Me.StartupImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'StartedCheckBox
        '
        Me.StartedCheckBox.AutoSize = True
        Me.StartedCheckBox.Checked = True
        Me.StartedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StartedCheckBox.Image = CType(resources.GetObject("StartedCheckBox.Image"), System.Drawing.Image)
        Me.StartedCheckBox.Location = New System.Drawing.Point(4, 3)
        Me.StartedCheckBox.Name = "StartedCheckBox"
        Me.StartedCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.StartedCheckBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.StartedCheckBox, "Show started services.")
        Me.StartedCheckBox.UseVisualStyleBackColor = True
        '
        'UnknownCheckBox
        '
        Me.UnknownCheckBox.AutoSize = True
        Me.UnknownCheckBox.Checked = True
        Me.UnknownCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UnknownCheckBox.Image = Global.CPServicesGroup.My.Resources.Resources.unknown
        Me.UnknownCheckBox.Location = New System.Drawing.Point(4, 209)
        Me.UnknownCheckBox.Name = "UnknownCheckBox"
        Me.UnknownCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.UnknownCheckBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.UnknownCheckBox, "Show unknown services.")
        Me.UnknownCheckBox.UseVisualStyleBackColor = True
        '
        'PausedCheckBox
        '
        Me.PausedCheckBox.AutoSize = True
        Me.PausedCheckBox.Checked = True
        Me.PausedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PausedCheckBox.Image = CType(resources.GetObject("PausedCheckBox.Image"), System.Drawing.Image)
        Me.PausedCheckBox.Location = New System.Drawing.Point(4, 29)
        Me.PausedCheckBox.Name = "PausedCheckBox"
        Me.PausedCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.PausedCheckBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.PausedCheckBox, "Show paused services.")
        Me.PausedCheckBox.UseVisualStyleBackColor = True
        '
        'SystemCheckbox
        '
        Me.SystemCheckbox.AutoSize = True
        Me.SystemCheckbox.Checked = True
        Me.SystemCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SystemCheckbox.Image = Global.CPServicesGroup.My.Resources.Resources.system
        Me.SystemCheckbox.Location = New System.Drawing.Point(4, 183)
        Me.SystemCheckbox.Name = "SystemCheckbox"
        Me.SystemCheckbox.Size = New System.Drawing.Size(34, 17)
        Me.SystemCheckbox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.SystemCheckbox, "Show system services.")
        Me.SystemCheckbox.UseVisualStyleBackColor = True
        '
        'StoppedCheckBox
        '
        Me.StoppedCheckBox.AutoSize = True
        Me.StoppedCheckBox.Checked = True
        Me.StoppedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StoppedCheckBox.Image = CType(resources.GetObject("StoppedCheckBox.Image"), System.Drawing.Image)
        Me.StoppedCheckBox.Location = New System.Drawing.Point(4, 54)
        Me.StoppedCheckBox.Name = "StoppedCheckBox"
        Me.StoppedCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.StoppedCheckBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.StoppedCheckBox, "Show stopped services.")
        Me.StoppedCheckBox.UseVisualStyleBackColor = True
        '
        'DisabledCheckBox
        '
        Me.DisabledCheckBox.AutoSize = True
        Me.DisabledCheckBox.Checked = True
        Me.DisabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DisabledCheckBox.Image = Global.CPServicesGroup.My.Resources.Resources.disabled
        Me.DisabledCheckBox.Location = New System.Drawing.Point(4, 158)
        Me.DisabledCheckBox.Name = "DisabledCheckBox"
        Me.DisabledCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.DisabledCheckBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.DisabledCheckBox, "Show disabled services.")
        Me.DisabledCheckBox.UseVisualStyleBackColor = True
        '
        'WorkingCheckBox
        '
        Me.WorkingCheckBox.AutoSize = True
        Me.WorkingCheckBox.Checked = True
        Me.WorkingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WorkingCheckBox.Image = Global.CPServicesGroup.My.Resources.Resources.timer
        Me.WorkingCheckBox.Location = New System.Drawing.Point(4, 80)
        Me.WorkingCheckBox.Name = "WorkingCheckBox"
        Me.WorkingCheckBox.Size = New System.Drawing.Size(38, 20)
        Me.WorkingCheckBox.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.WorkingCheckBox, "Show changing services.")
        Me.WorkingCheckBox.UseVisualStyleBackColor = True
        '
        'ManualCheckBox
        '
        Me.ManualCheckBox.AutoSize = True
        Me.ManualCheckBox.Checked = True
        Me.ManualCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ManualCheckBox.Image = Global.CPServicesGroup.My.Resources.Resources.main
        Me.ManualCheckBox.Location = New System.Drawing.Point(4, 135)
        Me.ManualCheckBox.Name = "ManualCheckBox"
        Me.ManualCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.ManualCheckBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.ManualCheckBox, "Show manually starting services.")
        Me.ManualCheckBox.UseVisualStyleBackColor = True
        '
        'AutomaticCheckBox
        '
        Me.AutomaticCheckBox.AutoSize = True
        Me.AutomaticCheckBox.Checked = True
        Me.AutomaticCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutomaticCheckBox.Image = Global.CPServicesGroup.My.Resources.Resources.automatic
        Me.AutomaticCheckBox.Location = New System.Drawing.Point(4, 110)
        Me.AutomaticCheckBox.Name = "AutomaticCheckBox"
        Me.AutomaticCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.AutomaticCheckBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.AutomaticCheckBox, "Show automatically starting services.")
        Me.AutomaticCheckBox.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.ServicesTreeView)
        Me.Panel3.Controls.Add(Me.btSearchHost)
        Me.Panel3.Controls.Add(Me.tbHostName)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(540, 553)
        Me.Panel3.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.StartedCheckBox)
        Me.Panel1.Controls.Add(Me.UnknownCheckBox)
        Me.Panel1.Controls.Add(Me.PausedCheckBox)
        Me.Panel1.Controls.Add(Me.SystemCheckbox)
        Me.Panel1.Controls.Add(Me.StoppedCheckBox)
        Me.Panel1.Controls.Add(Me.DisabledCheckBox)
        Me.Panel1.Controls.Add(Me.WorkingCheckBox)
        Me.Panel1.Controls.Add(Me.ManualCheckBox)
        Me.Panel1.Controls.Add(Me.AutomaticCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(14, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(54, 474)
        Me.Panel1.TabIndex = 14
        '
        'ServicesTreeView
        '
        Me.ServicesTreeView.AllowDrop = True
        Me.ServicesTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServicesTreeView.ContextMenuStrip = Me.ServiceContextMenuStrip1
        Me.ServicesTreeView.FullRowSelect = True
        Me.ServicesTreeView.HideSelection = False
        Me.ServicesTreeView.ImageIndex = 0
        Me.ServicesTreeView.ImageList = Me.Images32Width
        Me.ServicesTreeView.Location = New System.Drawing.Point(68, 73)
        Me.ServicesTreeView.Name = "ServicesTreeView"
        Me.ServicesTreeView.SelectedImageIndex = 0
        Me.ServicesTreeView.SelectedNodes = New System.Windows.Forms.TreeNode(-1) {}
        Me.ServicesTreeView.Size = New System.Drawing.Size(468, 474)
        Me.ServicesTreeView.Sorted = True
        Me.ServicesTreeView.TabIndex = 3
        '
        'btSearchHost
        '
        Me.btSearchHost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSearchHost.BackColor = System.Drawing.Color.White
        Me.btSearchHost.Location = New System.Drawing.Point(444, 10)
        Me.btSearchHost.Name = "btSearchHost"
        Me.btSearchHost.Size = New System.Drawing.Size(90, 27)
        Me.btSearchHost.TabIndex = 15
        Me.btSearchHost.Text = "Search"
        Me.btSearchHost.UseVisualStyleBackColor = False
        '
        'tbHostName
        '
        Me.tbHostName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHostName.Location = New System.Drawing.Point(65, 13)
        Me.tbHostName.Name = "tbHostName"
        Me.tbHostName.Size = New System.Drawing.Size(372, 22)
        Me.tbHostName.TabIndex = 8
        Me.tbHostName.Text = "localhost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Host : "
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(65, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(471, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Filter :"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1076, 553)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "CP Services Manager"
        Me.Panel4.ResumeLayout(False)
        Me.ServiceContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Delegate Sub EmptySubPrivateDelegate()

#Region "Events: MainForm"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load

        ComputeImages()

        MyBase.Text = Application.ProductName & " " & Application.ProductVersion

        btSearchHost_Click(sender, e)

    End Sub

    Private Sub WhenClosing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) _
    Handles MyBase.Closing
        If Not splash Is Nothing Then splash.Hide()
    End Sub

    Private Sub WhenActivated(ByVal sender As Object, ByVal e As EventArgs) _
    Handles MyBase.Activated
        If Not splash Is Nothing Then splash.Hide()
    End Sub

#End Region

#Region "Évènements: ServicesTreeView"

    Private Sub ServicesTreeView_AfterSelect(ByVal o As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) _
    Handles ServicesTreeView.AfterSelect
        If TypeOf e.Node Is ServiceItem Then
            Dim service As ServiceItem
            service = e.Node
            service.Refresh()
            Selected(service)
            UpdateUI()
        End If

    End Sub

    Private Sub ServicesTreeView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ServicesTreeView.Enter
        SelectedTreeView = sender
        UpdateUI()
    End Sub

    Public Sub ServicesTreeView_ItemDrag(ByVal sender As Object, ByVal ev As ItemDragEventArgs) _
    Handles ServicesTreeView.ItemDrag
        Dim node As ServiceItem = ServicesTreeView.GetNodeAt(ServicesTreeView.PointToClient(MousePosition))
        If node Is Nothing Then Exit Sub
        ServicesTreeView.SelectedNode = node
        ServicesTreeView.DoDragDrop(node.Service, DragDropEffects.All)
    End Sub

    Public Sub ServicesTreeView_DragOver(ByVal sender As Object, ByVal ev As DragEventArgs) _
    Handles ServicesTreeView.DragOver
        ev.Effect = DragDropEffects.Copy
    End Sub

    Public Sub ServicesTreeView_MouseClick(ByVal sender As Object, ByVal ev As MouseEventArgs) _
    Handles ServicesTreeView.MouseClick
        If ev.Button = Windows.Forms.MouseButtons.Right Then
            Dim node As TreeNode = ServicesTreeView.GetNodeAt(ev.Location)
            If node Is Nothing Then Exit Sub

            ServicesTreeView.SelectedNode = node
            UpdateUI()

        End If
    End Sub

    Private Sub ServicesTreeView_DoubleClick_1(ByVal sender As System.Object, ByVal ev As System.EventArgs) _
    Handles ServicesTreeView.DoubleClick
        Dim node As TreeNode = ServicesTreeView.SelectedNode
        If node Is Nothing Then Exit Sub
        ViewInformation(CType(node, ServiceItem))
    End Sub

#End Region

#Region "GROUPES: GESTION & ÉVÈNEMENTS"
    Private Sub GroupsTreeView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles GroupsTreeView.Enter
        SelectedTreeView = sender
        UpdateUI()
    End Sub

    Private WithEvents previous As IServiceNode = Nothing

    Private Sub GroupsTreeView_AfterSelect(ByVal o As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) _
    Handles GroupsTreeView.AfterSelect
        GroupsTreeView_AfterSelect(TryCast(e.Node, IServiceNode))
    End Sub

    Protected Delegate Sub NodeDelegate(ByVal node As IServiceNode)
    Protected AfterSelectDelegate As New NodeDelegate(AddressOf GroupsTreeView_AfterSelect)

    Private Sub GroupsTreeView_AfterSelect(node As IServiceNode)

        If previous IsNot Nothing Then
            RemoveHandler previous.StatusChanged, AddressOf SelectedStatusChanged
        End If

        If TypeOf node Is ServiceItem Then
            Dim service As ServiceItem = node
            service.Refresh()
            Selected(service, , True)
            previous = service
        ElseIf TypeOf node Is GroupItem Then
            Dim group As GroupItem = node
            group.RefreshAll()
            previous = group
        End If

        If previous IsNot Nothing Then _
        AddHandler previous.StatusChanged, AddressOf SelectedStatusChanged

        UpdateUI()
    End Sub

    Private Sub SelectedStatusChanged(sender As IServiceNode)
        If GroupsTreeView.InvokeRequired Then
            GroupsTreeView.Invoke(AfterSelectDelegate, sender)
        End If
    End Sub

    Public Sub GroupsTreeView_MouseDown(ByVal sender As Object, ByVal ev As MouseEventArgs) _
    Handles GroupsTreeView.MouseDown
        Dim node As TreeNode = GroupsTreeView.GetNodeAt(ev.Location)
        SelectedTreeView = GroupsTreeView
        GroupsTreeView.SelectedNode = node
        ' L'évènement "AfterSelect" ne se déclenche pas lorsque le node = Nothing
        If node Is Nothing Then UpdateUI()
    End Sub

    'Public Sub GroupsTreeView_DefaultContext_Opening(ByVal e As Object, ByVal ev As System.ComponentModel.CancelEventArgs)
    '    Dim node As TreeNode = GroupsTreeView.GetNodeAt(GroupsTreeView.PointToClient(MousePosition))
    '    ev.Cancel = Not node Is Nothing
    'End Sub

    Public Sub GroupsTreeView_BeforeLabelEdit(ByVal e As Object, ByVal ev As NodeLabelEditEventArgs) _
    Handles GroupsTreeView.BeforeLabelEdit
        If Not TypeOf ev.Node Is GroupItem Then ev.CancelEdit = True
    End Sub

    Public Sub GroupsTreeView_AfterLabelEdit(ByVal e As Object, ByVal ev As NodeLabelEditEventArgs) _
    Handles GroupsTreeView.AfterLabelEdit
        If ev.Label Is Nothing Then
            ev.CancelEdit = True
        Else
            If ev.Label.Trim = "" Then
                ev.CancelEdit = True
            ElseIf CurrentGroup IsNot Nothing Then
                CurrentGroup.Rename(ev.Label)
                SaveConfiguration()
                UpdateUI()
            End If
        End If
    End Sub

    Public Sub GroupsTreeView_DragOver(ByVal sender As Object, ByVal ev As DragEventArgs) _
    Handles GroupsTreeView.DragOver
        GroupsTreeView.BeginUpdate()

        Dim node As TreeNode = GroupsTreeView.GetNodeAt(GroupsTreeView.PointToClient(MousePosition))
        Dim si As WIN32_Service = ev.Data.GetData(GetType(WIN32_Service).Name)
        If Not TypeOf node Is GroupItem _
        Or Not si Is Nothing _
        Then
            ev.Effect = DragDropEffects.None
            If Not GroupsTreeView_LatestOpenedB_DragDrop Is Nothing Then
                GroupsTreeView_LatestOpenedB_DragDrop.Collapse()
                GroupsTreeView_LatestOpenedB_DragDrop = Nothing
            End If

            GroupsTreeView.EndUpdate()
            Exit Sub
        End If


        If Not GroupsTreeView_LatestOpenedB_DragDrop Is Nothing Then GroupsTreeView_LatestOpenedB_DragDrop.Collapse()
        If Not node.IsExpanded Then
            node.Expand()
            GroupsTreeView_LatestOpenedB_DragDrop = node
        End If

        ev.Effect = DragDropEffects.Copy
        GroupsTreeView.SelectedNode = node

        GroupsTreeView.EndUpdate()
    End Sub

    Private Sub GroupsTreeView_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) _
    Handles GroupsTreeView.ItemDrag
        Dim node As MTTreeNode = GroupsTreeView.GetNodeAt(GroupsTreeView.PointToClient(MousePosition))
        If node Is Nothing Then Exit Sub
        If TypeOf node Is ServiceItem Then
            Dim si As ServiceItem = node
            GroupsTreeView.SelectedNode = si
            GroupsTreeView.DoDragDrop(si.Service, DragDropEffects.All)
        ElseIf TypeOf node Is GroupItem Then
            Dim gi As GroupItem = node
            GroupsTreeView.SelectedNode = gi
            GroupsTreeView.DoDragDrop(gi, DragDropEffects.All)
        End If
    End Sub

    Public Sub GroupsTreeView_Drop(ByVal sender As Object, ByVal ev As DragEventArgs) _
    Handles GroupsTreeView.DragDrop
        Dim node As GroupItem = TryCast(GroupsTreeView.GetNodeAt(GroupsTreeView.PointToClient(MousePosition)), GroupItem)
        If node Is Nothing Then Return

        Dim formats As String() = ev.Data.GetFormats(True)
        Dim si As WIN32_Service = ev.Data.GetData(GetType(WIN32_Service).FullName)
        If si Is Nothing Then
            si = ev.Data.GetData(GetType(WIN32_Service).Name)
        End If

        Dim gi As GroupItem = ev.Data.GetData(GetType(CPServicesGroup.GroupItem).FullName)
        If gi Is Nothing Then
            gi = ev.Data.GetData(GetType(CPServicesGroup.GroupItem).Name)
        End If

        If si IsNot Nothing Then
            node.AddChild(New ServiceItem(si))
            GroupsTreeView_LatestOpenedB_DragDrop = Nothing
            SaveConfiguration()
        ElseIf gi IsNot Nothing Then
            ' À remplir ici après la gestion des sous-groupes
        End If
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles RenameToolStripMenuItem1.Click
        Dim node As TreeNode = GroupsTreeView.SelectedNode
        If Not node Is Nothing Then node.BeginEdit()
    End Sub

#Region "Start/Pause/Stop"
    Private Sub PauseGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles PauseServiceMenuItem.Click, PauseGroup.Click
        If CheckServiceState(Selection) = False Then Exit Sub

        'currentNode = SelectedTreeView.SelectedNode
        Dim th As New Threading.Thread(AddressOf DoPauseGroup)
        th.Start(Selection)
    End Sub

    Private Sub StopGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles StopGroup.Click, StopServiceToolStripMenuItem.Click
        If CheckServiceState(Selection) = False Then Exit Sub

        'currentNode = SelectedTreeView.SelectedNode
        Dim th As New Threading.Thread(AddressOf DoStopGroup)
        th.Start(Selection)
    End Sub

    Private Sub StartGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles StartGroup.Click, StartServiceToolStripMenuItem.Click
        If CheckServiceState(Selection) = False Then Exit Sub

        'currentNode = SelectedTreeView.SelectedNode
        Dim th As New Threading.Thread(AddressOf DoStartGroup)
        th.Start(Selection)

    End Sub

    Private Sub DoStartGroup(ByVal service As IServiceNode)
        If service Is Nothing Then Exit Sub
        service.Start()
    End Sub

    Private Sub DoPauseGroup(ByVal service As IServiceNode)
        If service Is Nothing Then Exit Sub
        service.Pause()
    End Sub

    Private Sub DoStopGroup(ByVal service As IServiceNode)
        If service Is Nothing Then Exit Sub

        service.Stop()
    End Sub

#End Region

#End Region


    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles AboutButton.Click
        Dim ab As New About
        ab.ShowDialog(Me)
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles AddButton.Click
        Dim selected As GroupItem
        Dim item As ServiceItem
        selected = GroupsTreeView.SelectedNode
        'If TypeOf selected Is ServiceItem Then _
        '    selected = selected.Parent

        item = ServicesTreeView.SelectedNode
        selected.AddChild(New ServiceItem(item.Service))
        selected.Expand()
        SaveConfiguration()
        'selected.Refresh()

        UpdateUI()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles CloseButton.Click
        Me.Enabled = False
        Me.Update()

        If Not splash Is Nothing Then splash.Hide()
        'If Not ServiceWithEvent.Thread Is Nothing Then
        '    If ServiceWithEvent.Thread.IsAlive Then
        '        ServiceWithEvent.Thread.Join(2000)
        '    End If
        'End If

        Me.Hide()
        Me.Close()
        'System.Diagnostics.Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles StartedCheckBox.CheckedChanged, PausedCheckBox.CheckedChanged, StoppedCheckBox.CheckedChanged, WorkingCheckBox.CheckedChanged, DisabledCheckBox.CheckedChanged, AutomaticCheckBox.CheckedChanged, ManualCheckBox.CheckedChanged, SystemCheckbox.CheckedChanged, UnknownCheckBox.CheckedChanged
        UpdateServicesTreeView()
    End Sub

    Private latestClicked As CheckBox = Nothing
    Private latestClickTime As DateTime = Nothing
    Private Sub CheckBox_Doubleclick(ByVal sender As System.Object, ByVal e As MouseEventArgs) _
Handles StartedCheckBox.MouseClick, PausedCheckBox.MouseClick, StoppedCheckBox.MouseClick, WorkingCheckBox.MouseClick, DisabledCheckBox.MouseClick, AutomaticCheckBox.MouseClick, ManualCheckBox.MouseClick, SystemCheckbox.MouseClick, UnknownCheckBox.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim ok As Boolean = True
            If latestClicked Is Nothing Then
                ok = False
            ElseIf latestClicked.Equals(sender) = False Then
                ok = False
            ElseIf (DateTime.Now - latestClickTime).Milliseconds > 500 Then
                ok = False
            End If

            latestClicked = sender
            latestClickTime = DateTime.Now
            If ok = False Then Exit Sub

            freezeUpdating = True
            Dim list1 As CheckBox() = {StartedCheckBox, PausedCheckBox, StoppedCheckBox, WorkingCheckBox}
            Dim list2 As CheckBox() = {DisabledCheckBox, AutomaticCheckBox, ManualCheckBox, SystemCheckbox, UnknownCheckBox}
            Dim cb1 As Boolean = Array.IndexOf(list1, sender) = -1
            Dim cb2 As Boolean = Array.IndexOf(list2, sender) = -1
            For Each cb As CheckBox In list1
                cb.Checked = cb1
            Next
            For Each cb As CheckBox In list2
                cb.Checked = cb2
            Next
            sender.checked = True
            freezeUpdating = False

        End If
        UpdateServicesTreeView()

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles DeleteButton.Click
        GroupsTreeView.Nodes.Remove(GroupsTreeView.SelectedNode)
        SaveConfiguration()

        UpdateUI()
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles NewButton.Click
        Dim created As GroupItem
        created = New GroupItem
        created.Text = GroupName.Text
        If created.Text = "" Then
            created.Text = "New Group"
        End If

        If GroupsTreeView.SelectedNode Is Nothing Then

            GroupsTreeView.BeginUpdate()
            GroupsTreeView.Nodes.Add(created)
            GroupsTreeView.SelectedNode = created
            GroupsTreeView.EndUpdate()

        ElseIf TypeOf GroupsTreeView.SelectedNode Is GroupItem Then

            GroupsTreeView.BeginUpdate()
            CType(GroupsTreeView.SelectedNode, GroupItem).AddChild(created)
            'GroupsTreeView.SelectedNode.Nodes.Add(created)
            GroupsTreeView.SelectedNode = created
            GroupsTreeView.EndUpdate()

        End If

        SaveConfiguration()
        UpdateUI()
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles RemoveButton.Click, RemoveServiceFromGroupToolStripMenuItem.Click
        Dim selected As TreeNode = GroupsTreeView.SelectedNode
        Dim parent As GroupItem = selected.Parent
        If parent Is Nothing Then Return
        parent.RemoveChild(selected)
        SaveConfiguration()
        UpdateUI()
    End Sub

    Private Sub RenameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles RenameButton.Click
        If CurrentGroup Is Nothing Then Exit Sub
        CurrentGroup.Rename(GroupName.Text)
        SaveConfiguration()
        UpdateUI()
    End Sub

    Private Function CheckServiceState(ByVal node As IServiceNode) As Boolean
        If node Is Nothing Then Return False

        Dim check As Boolean = False
        If TypeOf node Is GroupItem Then

            Dim gi As GroupItem = node
            check = gi.ContainsSystemService

        ElseIf TypeOf node Is ServiceItem Then

            Dim si As ServiceItem = node
            check = si.Service.StartMode = WIN32_Service.StartModes.System

        End If

        If check = True Then
            If MessageBox.Show("Attention, il y a un service Système. Vous devez confirmer votre action.", _
                               "Attention", _
                               MessageBoxButtons.OKCancel, _
                               MessageBoxIcon.Warning, _
                               MessageBoxDefaultButton.Button1) _
                = Windows.Forms.DialogResult.Cancel Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles TextBox1.TextChanged
        UpdateServicesTreeView()
    End Sub

    Private Sub btSearchHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btSearchHost.Click
        Try
            If tbHostName.Text = "" Then
                tbHostName.Text = "localhost"
            End If
            LoadServices()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub AddProcess(ByVal proc As WIN32_Process, _
    '                       Optional ByVal parent As MTTreeNode = Nothing)
    '    Dim item As MTTreeNode
    '    Dim display As String
    '    Try
    '        display = proc.CommandLine & " (" & proc.Caption & ")"
    '    Catch ex As Exception
    '        Return
    '    End Try

    '    item = New MTTreeNode()
    '    item.Text = display
    '    If Not parent Is Nothing Then
    '        parent.Nodes.Add(item)
    '    Else
    '        ProcessesTreeView.Nodes.Add(item)
    '    End If

    'End Sub

    Private Sub AddService(ByVal service As WIN32_Service, _
                           Optional ByVal parent As ServiceItem = Nothing, _
                           Optional ByVal depth As Integer = 0)
        Dim item As ServiceItem

        Try
            Dim display As String = service.DisplayName
        Catch ex As Exception
            Return
        End Try

        item = New ServiceItem(service)
        'If depth = 0 Then
        '    roots.Add(item)
        'End If

        If parent IsNot Nothing Then
            parent.Nodes.Add(item)
        Else
            ServicesTreeView.Nodes.Add(item)
        End If

    End Sub

    Private Sub Selected(ByVal e As ServiceItem, Optional ByVal parent As TreeNode = Nothing, Optional ByVal seeme As Boolean = False)
        Dim nodes As TreeNodeCollection
        Dim node As ServiceItem
        ServicesTreeView.BeginUpdate()
        Try
            If parent Is Nothing Then
                nodes = ServicesTreeView.Nodes
            Else
                nodes = parent.Nodes
            End If

            Me.Text = "CP Services Group : " & e.Name

            If nodes Is Nothing Then Exit Sub
            For Each node In nodes
                ' Affichage des noeuds contenant le même service 
                ' en bleu clair...
                If Not node Is Nothing Then
                    If node.Text = e.Text Then
                        node.Highlight = True
                        If seeme = True Then node.EnsureVisible()
                    Else
                        node.Highlight = False
                    End If
                    Selected(e, node)
                End If
            Next
            ServicesTreeView.EndUpdate()
        Catch ex As Exception
        Finally
        End Try
    End Sub

    Public Function TrouveService(ByVal name As String, Optional ByVal parent As ServiceItem = Nothing) _
    As WIN32_Service
        'As ServiceWithEvent
        Dim nodes As TreeNodeCollection
        If parent Is Nothing Then
            nodes = ServicesTreeView.Nodes
        Else
            nodes = parent.Nodes
        End If
        For Each node As IServiceNode In nodes
            If TypeOf node Is ServiceItem And node.IName = name Then
                TrouveService = CType(node, ServiceItem).Service
                Exit Function
            Else
                TrouveService = TrouveService(name, node)
            End If
        Next
        TrouveService = Nothing
    End Function

    Private Sub StartAutomaticallyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles StartAutomaticallyToolStripMenuItem.Click
        Dim si As IServiceNode = selectedTreeView.SelectedNode
        If si Is Nothing Then Return

        si.StartAuto()

        UpdateUI()
    End Sub

    Private Sub StartingManuallyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles StartingManuallyToolStripMenuItem.Click
        Dim si As IServiceNode = selectedTreeView.SelectedNode
        If si Is Nothing Then Return

        si.StartManual()

        UpdateUI()
    End Sub

    Private Sub StartingDisabledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles StartingDisabledToolStripMenuItem.Click
        Dim si As IServiceNode = selectedTreeView.SelectedNode
        If si Is Nothing Then Return

        si.StartDisabled()

        UpdateUI()
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim gi As GroupItem
        Dim si As ServiceItem

        If TypeOf selectedTreeView.SelectedNode Is GroupItem Then
            gi = selectedTreeView.SelectedNode
            gi.RefreshAll()
        Else
            si = selectedTreeView.SelectedNode
            si.Refresh()
        End If

        UpdateUI()
    End Sub

    Private Sub ViewInformation(ByVal service As ServiceItem)
        If service Is Nothing Then Return

        Dim infos As New ServiceDetailPanel()
        infos.Dock = DockStyle.Fill
        infos.ImageList = StartupImages
        infos.Service = service.Service

        Dim form As New Form()
        form.ClientSize = infos.PreferredSize
        form.Controls.Add(infos)
        form.Text = service.Text
        form.Show()

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) _
        Handles MyBase.FormClosing

        ServiceManager = Nothing
        'ProcessManager = Nothing

    End Sub

#Region "Context Menu"

    Private Sub ViewInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ViewInformationToolStripMenuItem1.Click

        If TypeOf Selection Is ServiceItem Then ViewInformation(Selection)
    End Sub


#End Region

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceDetailPanel
    Inherits UserControl

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbRealName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDisplayName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbStateImage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbStartupImage = New System.Windows.Forms.Label()
        Me.cbCanPause = New System.Windows.Forms.CheckBox()
        Me.cbCanStop = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbInteract = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbStateText = New System.Windows.Forms.TextBox()
        Me.tbStartupText = New System.Windows.Forms.TextBox()
        Me.tbOnError = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbProcess = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbProcessId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbHost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Real Name : "
        '
        'tbRealName
        '
        Me.tbRealName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRealName.Location = New System.Drawing.Point(92, 38)
        Me.tbRealName.Name = "tbRealName"
        Me.tbRealName.Size = New System.Drawing.Size(601, 20)
        Me.tbRealName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Display Name : "
        '
        'tbDisplayName
        '
        Me.tbDisplayName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDisplayName.Location = New System.Drawing.Point(92, 64)
        Me.tbDisplayName.Name = "tbDisplayName"
        Me.tbDisplayName.Size = New System.Drawing.Size(601, 20)
        Me.tbDisplayName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description : "
        '
        'tbDescription
        '
        Me.tbDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDescription.Location = New System.Drawing.Point(92, 90)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbDescription.Size = New System.Drawing.Size(601, 105)
        Me.tbDescription.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "State : "
        '
        'lbStateImage
        '
        Me.lbStateImage.Image = Global.CPServicesGroup.My.Resources.Resources.unknown
        Me.lbStateImage.Location = New System.Drawing.Point(89, 204)
        Me.lbStateImage.Name = "lbStateImage"
        Me.lbStateImage.Size = New System.Drawing.Size(32, 20)
        Me.lbStateImage.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Startup : "
        '
        'lbStartupImage
        '
        Me.lbStartupImage.Image = Global.CPServicesGroup.My.Resources.Resources.unknown
        Me.lbStartupImage.Location = New System.Drawing.Point(89, 230)
        Me.lbStartupImage.Name = "lbStartupImage"
        Me.lbStartupImage.Size = New System.Drawing.Size(32, 20)
        Me.lbStartupImage.TabIndex = 5
        '
        'cbCanPause
        '
        Me.cbCanPause.AutoCheck = False
        Me.cbCanPause.AutoSize = True
        Me.cbCanPause.Location = New System.Drawing.Point(249, 206)
        Me.cbCanPause.Name = "cbCanPause"
        Me.cbCanPause.Size = New System.Drawing.Size(98, 17)
        Me.cbCanPause.TabIndex = 6
        Me.cbCanPause.Text = "Can be paused"
        Me.cbCanPause.UseVisualStyleBackColor = True
        '
        'cbCanStop
        '
        Me.cbCanStop.AutoCheck = False
        Me.cbCanStop.AutoSize = True
        Me.cbCanStop.Location = New System.Drawing.Point(353, 206)
        Me.cbCanStop.Name = "cbCanStop"
        Me.cbCanStop.Size = New System.Drawing.Size(101, 17)
        Me.cbCanStop.TabIndex = 6
        Me.cbCanStop.Text = "Can be stopped"
        Me.cbCanStop.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "More : "
        '
        'cbInteract
        '
        Me.cbInteract.AutoCheck = False
        Me.cbInteract.AutoSize = True
        Me.cbInteract.Location = New System.Drawing.Point(92, 256)
        Me.cbInteract.Name = "cbInteract"
        Me.cbInteract.Size = New System.Drawing.Size(125, 17)
        Me.cbInteract.TabIndex = 6
        Me.cbInteract.Text = "Interact with desktop"
        Me.cbInteract.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "On Errors : "
        '
        'tbStateText
        '
        Me.tbStateText.BackColor = System.Drawing.SystemColors.Window
        Me.tbStateText.Location = New System.Drawing.Point(127, 204)
        Me.tbStateText.Name = "tbStateText"
        Me.tbStateText.ReadOnly = True
        Me.tbStateText.Size = New System.Drawing.Size(100, 20)
        Me.tbStateText.TabIndex = 9
        '
        'tbStartupText
        '
        Me.tbStartupText.BackColor = System.Drawing.SystemColors.Window
        Me.tbStartupText.Location = New System.Drawing.Point(127, 230)
        Me.tbStartupText.Name = "tbStartupText"
        Me.tbStartupText.ReadOnly = True
        Me.tbStartupText.Size = New System.Drawing.Size(100, 20)
        Me.tbStartupText.TabIndex = 9
        '
        'tbOnError
        '
        Me.tbOnError.BackColor = System.Drawing.SystemColors.Window
        Me.tbOnError.Location = New System.Drawing.Point(312, 254)
        Me.tbOnError.Name = "tbOnError"
        Me.tbOnError.ReadOnly = True
        Me.tbOnError.Size = New System.Drawing.Size(142, 20)
        Me.tbOnError.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Process : "
        '
        'tbProcess
        '
        Me.tbProcess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbProcess.BackColor = System.Drawing.SystemColors.Window
        Me.tbProcess.Location = New System.Drawing.Point(92, 283)
        Me.tbProcess.Name = "tbProcess"
        Me.tbProcess.ReadOnly = True
        Me.tbProcess.Size = New System.Drawing.Size(601, 20)
        Me.tbProcess.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Process Id : "
        '
        'tbProcessId
        '
        Me.tbProcessId.BackColor = System.Drawing.SystemColors.Window
        Me.tbProcessId.Location = New System.Drawing.Point(92, 309)
        Me.tbProcessId.Name = "tbProcessId"
        Me.tbProcessId.ReadOnly = True
        Me.tbProcessId.Size = New System.Drawing.Size(142, 20)
        Me.tbProcessId.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Host : "
        '
        'tbHost
        '
        Me.tbHost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHost.BackColor = System.Drawing.SystemColors.Window
        Me.tbHost.Location = New System.Drawing.Point(92, 12)
        Me.tbHost.Name = "tbHost"
        Me.tbHost.ReadOnly = True
        Me.tbHost.Size = New System.Drawing.Size(601, 20)
        Me.tbHost.TabIndex = 9
        '
        'ServiceDetailPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbHost)
        Me.Controls.Add(Me.tbProcessId)
        Me.Controls.Add(Me.tbProcess)
        Me.Controls.Add(Me.tbOnError)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbStartupText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbStateText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCanStop)
        Me.Controls.Add(Me.cbInteract)
        Me.Controls.Add(Me.cbCanPause)
        Me.Controls.Add(Me.lbStartupImage)
        Me.Controls.Add(Me.lbStateImage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDisplayName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbRealName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ServiceDetailPanel"
        Me.Size = New System.Drawing.Size(705, 359)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbRealName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbDisplayName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbStateImage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbStartupImage As System.Windows.Forms.Label
    Friend WithEvents cbCanPause As System.Windows.Forms.CheckBox
    Friend WithEvents cbCanStop As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbInteract As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbStateText As System.Windows.Forms.TextBox
    Friend WithEvents tbStartupText As System.Windows.Forms.TextBox
    Friend WithEvents tbOnError As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbProcess As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbProcessId As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbHost As System.Windows.Forms.TextBox
End Class

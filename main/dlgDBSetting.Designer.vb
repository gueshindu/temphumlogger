<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDBSetting
    Inherits GueForm.CDialogSettingDB

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDBSetting))
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.lblTitle = New GueComponent.GueCaption
        Me.pnlTop.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Size = New System.Drawing.Size(501, 45)
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FloralWhite
        Me.pnlBody.Location = New System.Drawing.Point(0, 45)
        Me.pnlBody.Size = New System.Drawing.Size(501, 235)
        Me.pnlBody.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.Tan
        Me.pnlBottom.Location = New System.Drawing.Point(0, 280)
        Me.pnlBottom.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(75, 130)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 130)
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(75, 103)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 103)
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(75, 76)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 76)
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        Me.txtPort.Location = New System.Drawing.Point(75, 39)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 39)
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.Blue
        Me.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTest.ImageKey = "ok2.png"
        Me.btnTest.ImageList = Me.imgButton
        Me.btnTest.Location = New System.Drawing.Point(75, 176)
        Me.btnTest.Size = New System.Drawing.Size(88, 28)
        Me.btnTest.TabIndex = 16
        Me.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.msgErrorTip.SetToolTip(Me.btnTest, "Test Koneksi")
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(6, 207)
        Me.lblInfo.TabIndex = 17
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(450, 2)
        Me.btnSave.Text = "OK"
        Me.msgErrorTip.SetToolTip(Me.btnSave, "Simpan")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'imgButton
        '
        Me.imgButton.ImageStream = CType(resources.GetObject("imgButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgButton.Images.SetKeyName(0, "ok2.png")
        '
        'dlgFolder
        '
        Me.dlgFolder.Description = "Lokasi File SHP"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Pink
        Me.lblTitle.CenterGradien = 1
        Me.lblTitle.Color1 = System.Drawing.Color.SeaShell
        Me.lblTitle.Color2 = System.Drawing.Color.DarkOrange
        Me.lblTitle.ColorText = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.EffectMode = GueComponent.GueCaption.gueEffectMode.EffectNormal
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.GradientDirection = GueComponent.GueCaption.gueGradientDirection.GradientHorizontal
        Me.lblTitle.IconLocation = GueComponent.GueCaption.gueIconLocation.NoIcon
        Me.lblTitle.ImageCaption = CType(resources.GetObject("lblTitle.ImageCaption"), System.Drawing.Image)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(501, 45)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.TabStop = False
        Me.lblTitle.TextCaption = "Setting Koneksi"
        '
        'dlgDBSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(501, 333)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dlgDBSetting"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Protected WithEvents lblTitle As GueComponent.GueCaption

End Class

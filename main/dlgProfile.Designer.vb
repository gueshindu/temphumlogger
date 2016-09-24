<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgProfile
    Inherits GueForm.CDialogProfil

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgProfile))
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.dlgFile = New System.Windows.Forms.OpenFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.numDisplayRT = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.numLogingInterval = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIPAddress = New System.Windows.Forms.TextBox
        Me.pnlBody.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pageIdentitas.SuspendLayout()
        Me.tabProfil.SuspendLayout()
        Me.pageAplikasi.SuspendLayout()
        CType(Me.numMaxShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAbout.SuspendLayout()
        CType(Me.numDisplayRT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLogingInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Size = New System.Drawing.Size(578, 10)
        '
        'pnlBody
        '
        Me.pnlBody.Location = New System.Drawing.Point(0, 10)
        Me.pnlBody.Size = New System.Drawing.Size(578, 343)
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnlBottom.Size = New System.Drawing.Size(578, 53)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(526, 2)
        '
        'pageIdentitas
        '
        Me.pageIdentitas.Size = New System.Drawing.Size(578, 343)
        '
        'imgButton
        '
        Me.imgButton.ImageStream = CType(resources.GetObject("imgButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgButton.Images.SetKeyName(0, "Home - Alt Black.ico")
        '
        'tabProfil
        '
        Me.tabProfil.BackColor = System.Drawing.Color.AliceBlue
        Me.tabProfil.Size = New System.Drawing.Size(570, 317)
        Me.tabProfil.UseVisualStyleBackColor = False
        '
        'pageAplikasi
        '
        Me.pageAplikasi.BackColor = System.Drawing.Color.AliceBlue
        Me.pageAplikasi.Controls.Add(Me.txtIPAddress)
        Me.pageAplikasi.Controls.Add(Me.Label5)
        Me.pageAplikasi.Controls.Add(Me.Label2)
        Me.pageAplikasi.Controls.Add(Me.numLogingInterval)
        Me.pageAplikasi.Controls.Add(Me.Label3)
        Me.pageAplikasi.Controls.Add(Me.Label4)
        Me.pageAplikasi.Controls.Add(Me.numDisplayRT)
        Me.pageAplikasi.Controls.Add(Me.Label1)
        Me.pageAplikasi.Size = New System.Drawing.Size(570, 317)
        Me.pageAplikasi.Text = "Aplikasi"
        Me.pageAplikasi.UseVisualStyleBackColor = False
        Me.pageAplikasi.Controls.SetChildIndex(Me.l9, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.numMaxShow, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.l10, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.Label1, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.numDisplayRT, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.Label4, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.Label3, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.numLogingInterval, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.Label2, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.Label5, 0)
        Me.pageAplikasi.Controls.SetChildIndex(Me.txtIPAddress, 0)
        '
        'l10
        '
        Me.l10.TabIndex = 2
        '
        'numMaxShow
        '
        Me.numMaxShow.Location = New System.Drawing.Point(154, 3)
        Me.numMaxShow.TabIndex = 1
        '
        'l9
        '
        Me.l9.TabIndex = 0
        '
        'tabAbout
        '
        Me.tabAbout.Size = New System.Drawing.Size(570, 317)
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(0, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(100, 23)
        Me.Label90.TabIndex = 0
        '
        'Label100
        '
        Me.Label100.Location = New System.Drawing.Point(0, 0)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(100, 23)
        Me.Label100.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Display refresh rate:"
        '
        'numDisplayRT
        '
        Me.numDisplayRT.Location = New System.Drawing.Point(154, 108)
        Me.numDisplayRT.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.numDisplayRT.Name = "numDisplayRT"
        Me.numDisplayRT.Size = New System.Drawing.Size(46, 21)
        Me.numDisplayRT.TabIndex = 6
        Me.numDisplayRT.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "detik"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "menit"
        '
        'numLogingInterval
        '
        Me.numLogingInterval.Location = New System.Drawing.Point(154, 135)
        Me.numLogingInterval.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.numLogingInterval.Name = "numLogingInterval"
        Me.numLogingInterval.Size = New System.Drawing.Size(46, 21)
        Me.numLogingInterval.TabIndex = 9
        Me.numLogingInterval.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Logging interval:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Device IP:"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(154, 54)
        Me.txtIPAddress.MaxLength = 15
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(152, 21)
        Me.txtIPAddress.TabIndex = 4
        Me.txtIPAddress.Text = "10.12.2.100"
        '
        'dlgProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(578, 406)
        Me.Name = "dlgProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Profile Aplikasi"
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pageIdentitas.ResumeLayout(False)
        Me.tabProfil.ResumeLayout(False)
        Me.tabProfil.PerformLayout()
        Me.pageAplikasi.ResumeLayout(False)
        Me.pageAplikasi.PerformLayout()
        CType(Me.numMaxShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        CType(Me.numDisplayRT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLogingInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents dlgFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numDisplayRT As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numLogingInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

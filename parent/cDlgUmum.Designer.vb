<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cDlgUmum
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cDlgUmum))
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblTitle = New GueComponent.GueCaption
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FloralWhite
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 39)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(500, 209)
        Me.pnlMain.TabIndex = 1
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.Tan
        Me.pnlBottom.Controls.Add(Me.btnOK)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 248)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(500, 44)
        Me.pnlBottom.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(460, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(37, 37)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Pink
        Me.lblTitle.CenterGradien = 1
        Me.lblTitle.Color1 = System.Drawing.Color.SeaShell
        Me.lblTitle.Color2 = System.Drawing.Color.DarkOrange
        Me.lblTitle.ColorText = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.EffectMode = GueComponent.GueCaption.gueEffectMode.EffectNormal
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.GradientDirection = GueComponent.GueCaption.gueGradientDirection.GradientHorizontal
        Me.lblTitle.IconLocation = GueComponent.GueCaption.gueIconLocation.NoIcon
        Me.lblTitle.ImageCaption = CType(resources.GetObject("lblTitle.ImageCaption"), System.Drawing.Image)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 39)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.TabStop = False
        Me.lblTitle.TextCaption = "Data"
        '
        'cDlgUmum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 292)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cDlgUmum"
        Me.Text = "Data"
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents pnlMain As System.Windows.Forms.Panel
    Protected WithEvents pnlBottom As System.Windows.Forms.Panel
    Protected WithEvents btnOK As System.Windows.Forms.Button
    Protected WithEvents lblTitle As GueComponent.GueCaption
End Class

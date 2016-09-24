<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cDlgFilter
    Inherits GueForm.CDialogFilter

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cDlgFilter))
        Me.btnOk = New System.Windows.Forms.Button
        Me.lblTitle = New GueComponent.GueCaption
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Size = New System.Drawing.Size(513, 41)
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FloralWhite
        Me.pnlMain.Location = New System.Drawing.Point(0, 41)
        Me.pnlMain.Size = New System.Drawing.Size(513, 186)
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.Tan
        Me.pnlBottom.Controls.Add(Me.btnOk)
        Me.pnlBottom.Location = New System.Drawing.Point(0, 243)
        Me.pnlBottom.Size = New System.Drawing.Size(513, 43)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tan
        Me.Label1.Location = New System.Drawing.Point(0, 227)
        Me.Label1.Size = New System.Drawing.Size(513, 16)
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(473, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(37, 37)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
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
        Me.lblTitle.Size = New System.Drawing.Size(513, 39)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.TabStop = False
        Me.lblTitle.TextCaption = "Filter"
        '
        'cDlgFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(513, 286)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cDlgFilter"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents btnOk As System.Windows.Forms.Button
    Protected WithEvents lblTitle As GueComponent.GueCaption

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cShowQuery
    Inherits GueForm.CShowData

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cShowQuery))
        Me.pnlGrid.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.SeaShell
        Me.pnlBottom.Location = New System.Drawing.Point(0, 483)
        Me.pnlBottom.Size = New System.Drawing.Size(674, 10)
        '
        'pnlCmd
        '
        '
        'btnRefresh
        '
        '
        'btnCari
        '
        '
        'pnlGrid
        '
        Me.pnlGrid.Size = New System.Drawing.Size(674, 443)
        '
        'btnExit
        '
        '
        'imgIcon
        '
        Me.imgIcon.ImageStream = CType(resources.GetObject("imgIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIcon.Images.SetKeyName(0, "Find.png")
        Me.imgIcon.Images.SetKeyName(1, "refresh.png")
        Me.imgIcon.Images.SetKeyName(2, "print.png")
        Me.imgIcon.Images.SetKeyName(3, "home.png")
        '
        'btnCetak
        '
        '
        'cShowQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(674, 515)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cShowQuery"
        Me.Text = "Tampilkan data"
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class

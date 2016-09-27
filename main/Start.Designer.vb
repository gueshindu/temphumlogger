<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.mnMain = New System.Windows.Forms.MenuStrip
        Me.mnApplikasi = New System.Windows.Forms.ToolStripMenuItem
        Me.mnAppConnect = New System.Windows.Forms.ToolStripMenuItem
        Me.mnAppDisconnect = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnAppExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnSetting = New System.Windows.Forms.ToolStripMenuItem
        Me.mnSettingApp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnSettingDB = New System.Windows.Forms.ToolStripMenuItem
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.lblDate = New System.Windows.Forms.Label
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlHum = New System.Windows.Forms.Panel
        Me.lblHum = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlTemp = New System.Windows.Forms.Panel
        Me.lblTemp = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.progTimerDisplay = New System.Windows.Forms.ProgressBar
        Me.progTimerLog = New System.Windows.Forms.ProgressBar
        Me.mnMain.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlHum.SuspendLayout()
        Me.pnlTemp.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnMain
        '
        Me.mnMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnApplikasi, Me.mnSetting})
        Me.mnMain.Location = New System.Drawing.Point(0, 0)
        Me.mnMain.Name = "mnMain"
        Me.mnMain.Size = New System.Drawing.Size(641, 24)
        Me.mnMain.TabIndex = 0
        Me.mnMain.Text = "MenuStrip1"
        '
        'mnApplikasi
        '
        Me.mnApplikasi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAppConnect, Me.mnAppDisconnect, Me.ToolStripMenuItem1, Me.mnAppExit})
        Me.mnApplikasi.Name = "mnApplikasi"
        Me.mnApplikasi.Size = New System.Drawing.Size(60, 20)
        Me.mnApplikasi.Text = "Aplikasi"
        '
        'mnAppConnect
        '
        Me.mnAppConnect.Name = "mnAppConnect"
        Me.mnAppConnect.Size = New System.Drawing.Size(152, 22)
        Me.mnAppConnect.Text = "Connect"
        '
        'mnAppDisconnect
        '
        Me.mnAppDisconnect.Name = "mnAppDisconnect"
        Me.mnAppDisconnect.Size = New System.Drawing.Size(152, 22)
        Me.mnAppDisconnect.Text = "Disconnect"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnAppExit
        '
        Me.mnAppExit.Name = "mnAppExit"
        Me.mnAppExit.Size = New System.Drawing.Size(152, 22)
        Me.mnAppExit.Text = "Exit"
        '
        'mnSetting
        '
        Me.mnSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSettingApp, Me.mnSettingDB})
        Me.mnSetting.Name = "mnSetting"
        Me.mnSetting.Size = New System.Drawing.Size(56, 20)
        Me.mnSetting.Text = "Setting"
        '
        'mnSettingApp
        '
        Me.mnSettingApp.Name = "mnSettingApp"
        Me.mnSettingApp.Size = New System.Drawing.Size(122, 22)
        Me.mnSettingApp.Text = "Aplikasi"
        '
        'mnSettingDB
        '
        Me.mnSettingDB.Name = "mnSettingDB"
        Me.mnSettingDB.Size = New System.Drawing.Size(122, 22)
        Me.mnSettingDB.Text = "Database"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(481, 6)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(157, 29)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00:00:00"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.GreenYellow
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 13)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(97, 21)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Connected"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.PaleGreen
        Me.pnlTop.Controls.Add(Me.lblDate)
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.lblStatus)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 24)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(641, 43)
        Me.pnlTop.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(290, 6)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(172, 26)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "12-Sep-2016"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.progTimerLog)
        Me.pnlMain.Controls.Add(Me.progTimerDisplay)
        Me.pnlMain.Controls.Add(Me.pnlHum)
        Me.pnlMain.Controls.Add(Me.pnlTemp)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 67)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(641, 229)
        Me.pnlMain.TabIndex = 4
        '
        'pnlHum
        '
        Me.pnlHum.BackColor = System.Drawing.Color.MintCream
        Me.pnlHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHum.Controls.Add(Me.lblHum)
        Me.pnlHum.Controls.Add(Me.Label2)
        Me.pnlHum.Location = New System.Drawing.Point(372, 25)
        Me.pnlHum.Name = "pnlHum"
        Me.pnlHum.Size = New System.Drawing.Size(205, 161)
        Me.pnlHum.TabIndex = 6
        '
        'lblHum
        '
        Me.lblHum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHum.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHum.Location = New System.Drawing.Point(0, 21)
        Me.lblHum.Name = "lblHum"
        Me.lblHum.Size = New System.Drawing.Size(203, 138)
        Me.lblHum.TabIndex = 5
        Me.lblHum.Text = "00.00"
        Me.lblHum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PaleGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Humidity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlTemp
        '
        Me.pnlTemp.BackColor = System.Drawing.Color.MintCream
        Me.pnlTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTemp.Controls.Add(Me.lblTemp)
        Me.pnlTemp.Controls.Add(Me.Label1)
        Me.pnlTemp.Location = New System.Drawing.Point(49, 25)
        Me.pnlTemp.Name = "pnlTemp"
        Me.pnlTemp.Size = New System.Drawing.Size(205, 161)
        Me.pnlTemp.TabIndex = 5
        '
        'lblTemp
        '
        Me.lblTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTemp.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(0, 21)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(203, 138)
        Me.lblTemp.TabIndex = 4
        Me.lblTemp.Text = "00.00"
        Me.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Temperature"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.DarkGreen
        Me.pnlBottom.Controls.Add(Me.Label3)
        Me.pnlBottom.Controls.Add(Me.lblInfo)
        Me.pnlBottom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 296)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(641, 49)
        Me.pnlBottom.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(9, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Info:"
        '
        'lblInfo
        '
        Me.lblInfo.ForeColor = System.Drawing.Color.Snow
        Me.lblInfo.Location = New System.Drawing.Point(46, 6)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(583, 34)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "-"
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1000
        '
        'progTimerDisplay
        '
        Me.progTimerDisplay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progTimerDisplay.ForeColor = System.Drawing.Color.Lime
        Me.progTimerDisplay.Location = New System.Drawing.Point(0, 219)
        Me.progTimerDisplay.Name = "progTimerDisplay"
        Me.progTimerDisplay.Size = New System.Drawing.Size(641, 10)
        Me.progTimerDisplay.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progTimerDisplay.TabIndex = 7
        '
        'progTimerLog
        '
        Me.progTimerLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progTimerLog.ForeColor = System.Drawing.Color.IndianRed
        Me.progTimerLog.Location = New System.Drawing.Point(0, 209)
        Me.progTimerLog.Name = "progTimerLog"
        Me.progTimerLog.Size = New System.Drawing.Size(641, 10)
        Me.progTimerLog.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progTimerLog.TabIndex = 8
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(641, 345)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.mnMain)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnMain
        Me.MaximizeBox = False
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temp & Hum Logging"
        Me.mnMain.ResumeLayout(False)
        Me.mnMain.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHum.ResumeLayout(False)
        Me.pnlTemp.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlHum As System.Windows.Forms.Panel
    Friend WithEvents lblHum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlTemp As System.Windows.Forms.Panel
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mnSettingApp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSettingDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnApplikasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAppConnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAppDisconnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnAppExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents progTimerDisplay As System.Windows.Forms.ProgressBar
    Friend WithEvents progTimerLog As System.Windows.Forms.ProgressBar
End Class

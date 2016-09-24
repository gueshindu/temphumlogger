Imports GueForm

Public Class Start

    Dim objDal As dalData
    Dim intTimerDisplay, intCounterDisplay As Integer
    Dim intTimerLogging, intCounterLogging As Integer
    Dim strDevIP As String
    Dim client As Net.Sockets.TcpClient
    Dim clientStream As Net.Sockets.NetworkStream

    Const MAX_TRYING% = 5 'kali
    Const SLEEP_TIME% = 1 'detik
    Const TIME_OUT% = 5 'detik

    Dim bytWrite As [Byte]()
    Dim bytReading As Byte()

    Private Function PrepareCustomProfile(ByVal ObjDAL As DALCore.ADAppDict) As DataTable
        Dim result As DataTable = ObjDAL.CreateStandartProfile()
        result.Columns.Add("refreshrate", Type.GetType("System.Int32"))
        result.Columns.Add("loginginterval", Type.GetType("System.Int32"))
        result.Columns.Add("deviceip", Type.GetType("System.String"))
        Return result
    End Function

#Region " Initial "
    Public Sub Main()
        'Load setting
        Dim theSetting As MeSetting = New MeSetting(Application.StartupPath & "\" & STR_FILE_INI)
        '
        tmrMain.Enabled = False
        Dim dlgSetting As dlgDBSetting = New dlgDBSetting(theSetting)
        'If Not theSetting.CheckConnection Then
        '    MsgBox("Gagal")
        'End If
        While Not theSetting.CheckConnection()
            theSetting.ShowErrorMessage()
            If dlgSetting.ShowDialog() = Windows.Forms.DialogResult.OK Then
                theSetting = dlgSetting.getApplicationSetting
            Else
                MsgBox("Aplikasi ditutup!", MsgBoxStyle.Critical, "Database tidak tersedia")
                Application.Exit()
                End
            End If
        End While
        'Everything OK
        GMyEnvirontment = New DALCore.AppCore.cAppEnvirontment()
        GMyEnvirontment.AppSetting = theSetting
        '
        'Load DAL
        objDal = New dalData(GMyEnvirontment.AppSetting.GenerateConnection())
        '
        'Check Application dictionary
        'Jika belum ada maka dibuat
        Dim dalAD As DALCore.ADAppDict = New DALCore.ADAppDict(GMyEnvirontment.AppSetting.GenerateConnection())
        'cek app system info
        If Not dalAD.CreateOrCheckApplicationSystem(STR_APPID, STR_APPNAME, STR_APPVER, CDate(STR_APPDATE)) Then
            MsgBox("Kesalahan versi database! Applikasi akan ditutup" & vbCrLf & dalAD.CurErrorDescription, MsgBoxStyle.Exclamation, "Application Dictionary")
            Application.Exit()
        End If
        If Not dalAD.CreateApplicationDictionary() Then
            MsgBox("Application Dictionary tidak berhasil dibuat! Applikasi akan ditutup" & vbCrLf & dalAD.CurErrorDescription, MsgBoxStyle.Exclamation, "Application Dictionary")
            Application.Exit()
            End
        End If
        'Create Profile //custom prifile
        If Not dalAD.CreateApplicationProfile(PrepareCustomProfile(dalAD)) Then
            MsgBox("Profile applikasi tidak dapat dibuat! Applikasi akan ditutup" & vbCrLf & dalAD.ErrorDescription, MsgBoxStyle.Exclamation, "Menu")
            Application.Exit()
            End
        End If
        'Load profile
        Dim cAppProfile As DALCore.AppCore.cAppProfile = New DALCore.AppCore.cAppProfile(New DALCore.ADProfile(GMyEnvirontment.AppSetting.GenerateConnection))
        If Not cAppProfile.loadProfileFromDB() Then
            MsgBox("Profile applikasi tidak dapat dibaca! Applikasi akan ditutup" & vbCrLf & dalAD.ErrorDescription, MsgBoxStyle.Exclamation, "Menu")
            Application.Exit()
        End If
        '
        'Load Profile OK
        GMyEnvirontment.AppProfile = cAppProfile
        GMyEnvirontment.AppDictionary = dalAD
        'Login user
        Dim session As DALCore.AppCore.cAppUserSession = New DALCore.AppCore.cAppUserSession()
        session.UserID = 1
        session.LoginID = "Admin"
        session.UserState = DALCore.ADUser.UserState.UserLogon
        GMyEnvirontment.AppUserSession = session
        '
        GMyEnvirontment.AppSetting.Log.WriteLog("System", "0", "Application", "Start", DALCore.ADLog.enLogMode.LogOk, "")
        '        '
        'First
        Me.ApplyStatus(enStatus.StatusDisconnect)
        'Load setting
        LoadSetting()
        '
        'Try Connect
        ConnectNet()

        tmrMain.Enabled = True
    End Sub


#End Region

#Region " Form Formater "

    Private Sub LoadSetting()
        'Load setting
        intTimerDisplay = GMyEnvirontment.AppProfile.readProperty("refreshrate")
        intCounterDisplay = intTimerDisplay
        intTimerLogging = GMyEnvirontment.AppProfile.readProperty("loginginterval")
        strDevIP = GMyEnvirontment.AppProfile.readProperty("deviceip")

        'Timer logging dalam menit, maka di jadikan detik dulu
        intTimerLogging = intTimerLogging * 60
        intCounterLogging = intTimerLogging
    End Sub

    Enum enStatus
        StatusDisconnect = 0
        StatusConnecting = 1
        StatusConnected = 2
        StatusError = 255
    End Enum

    Private Sub ApplyStatus(ByVal status As enStatus)
        Select Case status
            Case enStatus.StatusConnected
                lblStatus.Text = "Connected"
                lblStatus.BackColor = Color.Lime
            Case enStatus.StatusConnecting
                lblStatus.Text = "Connecting..."
                lblStatus.BackColor = Color.GreenYellow
            Case enStatus.StatusDisconnect
                lblStatus.Text = "Not Connected"
                lblStatus.BackColor = Color.Gainsboro
            Case enStatus.StatusError
                lblStatus.Text = "Error!"
                lblStatus.BackColor = Color.Pink
        End Select

    End Sub

    Private Sub ShowDateTime()
        lblDate.Text = Now.ToString(modMain.STR_FMT_DATE_SHOW)
        lblTime.Text = Now.ToString(modMain.STR_FMT_TIME_SHOW)
    End Sub

#End Region

#Region " Scheduller "
   
    Private Function GetCurrentIP() As String
        Dim strHostName As String
        Dim strIPAddress As String = String.Empty
        strHostName = System.Net.Dns.GetHostName()
        Dim addrs As Net.IPAddress() = System.Net.Dns.GetHostEntry(strHostName).AddressList
        For i As Integer = 0 To addrs.Length - 1
            If addrs(i).AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                strIPAddress = addrs(i).ToString
                Exit For
            End If
        Next
        If strIPAddress = String.Empty Then
            strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        End If
        Return strIPAddress
    End Function

    Private Sub WriteData(ByVal strWrite As String)
        bytWrite = System.Text.Encoding.ASCII.GetBytes(strWrite)
        clientStream.Write(bytWrite, 0, bytWrite.Length)
    End Sub

    Private Sub DisplayData()
        If Not client.Connected Then
            lblInfo.Text = "Not connected to device"
            Return
        End If
        Try
            'Write command to remote. (command di set di modmain)
            WriteData(modMain.STR_COMMAND & vbCrLf & vbCrLf)
            '
            Dim sData As String
            ReDim bytReading(client.ReceiveBufferSize)
            clientStream.Read(bytReading, 0, client.ReceiveBufferSize)
            sData = Trim(System.Text.Encoding.ASCII.GetString(bytReading))

            lblInfo.Text = sData
            ParseData(sData)
        Catch ex As Exception
            lblInfo.Text = "Error: " & ex.Message
        End Try

        'End If
    End Sub

    Private Sub ParseData(ByVal RawData As String)
        If Not RawData.Contains("||") Then
            Return
        End If
        Dim str As String()
        str = RawData.Trim.Split("||")
        lblTemp.Text = str(0).Replace("Temperature : ", "")
        lblHum.Text = str(2).Replace("Humidity : ", "")

        If Not IsNumeric(lblTemp.Text) Then
            lblTemp.Text = "00.00"
        End If

        If Not IsNumeric(lblHum.Text) Then
            lblHum.Text = "00.00"
        End If

    End Sub

    Private Sub LogData()
        Dim htbl As Hashtable = New Hashtable(2)
        htbl.Add("@temp", CSng(lblTemp.Text))
        htbl.Add("@hum", CSng(lblHum.Text))
        htbl.Add("@source", GetCurrentIP())
        htbl.Add("@devip", strDevIP)
        If objDal.InsertItem(htbl) Then
            lblInfo.Text = "Success save log @" & Now.ToString(modMain.STR_FMT_DATETIME_SHOW)
        Else
            lblInfo.Text = "Failed save log: " & objDal.ErrorDescription
        End If
    End Sub

#End Region

    Private Sub ConnectNet()
        If client Is Nothing Then
            client = New Net.Sockets.TcpClient()
        End If        
       
        'Try connect
        Dim counter As Integer = MAX_TRYING
        Try
            While Not client.Connected And counter > 0
                client.Connect(strDevIP, 80)
                'Tunggu 5 detik
                System.Threading.Thread.Sleep(SLEEP_TIME * 1000)
                counter -= 1
                ApplyStatus(enStatus.StatusConnecting)
                lblInfo.Text = "Connecting...[" & MAX_TRYING + 1 - counter & "]"
            End While
        Catch ex As Exception
            lblInfo.Text = "Error: " & ex.Message
        End Try

        If client.Connected Then
            clientStream = client.GetStream()
            ApplyStatus(enStatus.StatusConnected)
            lblInfo.Text = ""
        Else
            ApplyStatus(enStatus.StatusDisconnect)
        End If


    End Sub

    Private Sub DisconnectNet()
        If client IsNot Nothing Then
            client.Close()
            If clientStream IsNot Nothing Then
                clientStream.Close()
            End If
        End If
    End Sub

    Private Sub Start_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If GMyEnvirontment Is Nothing Then
            Return
        End If
        If MsgBox("Menutup aplikasi ini membuat proses logging tidak berjalan. Yakin menutup aplikasi ini?", MsgBoxStyle.YesNo, "Konfirmasi Tutup") <> MsgBoxResult.Yes Then
            e.Cancel = True
            GMyEnvirontment.AppSetting.Log.WriteLog("System", "0", "Application", "Exit", DALCore.ADLog.enLogMode.LogOk, "Cancel exit")
        Else
            DisconnectNet()
            GMyEnvirontment.AppSetting.Log.WriteLog("System", "0", "Application", "Exit", DALCore.ADLog.enLogMode.LogOk, "")
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
      
    End Sub


    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        ShowDateTime()
        'Timer display (dalam detik)
        If intCounterDisplay = 0 Then
            intCounterDisplay = intTimerDisplay
            'Do refresh display
            ConnectNet()
            DisplayData()
        End If
        'Timer logging (dalam detik)
        If intCounterLogging = 0 Then
            intCounterLogging = intTimerLogging
            'Do save logging
            LogData()
        End If
        'Kurangi 1 setiap detik
        intCounterDisplay -= 1
        intCounterLogging -= 1
    End Sub


    Private Sub mnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnExit.Click
        Me.Close()
    End Sub


    Private Sub Start_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowDateTime()
        Main()
    End Sub

    Private Sub mnSettingApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSettingApp.Click
        Dim x As dlgProfile = New dlgProfile()
        If x.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            LoadSetting()
        End If
    End Sub

    Private Sub mnSettingDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSettingDB.Click
        Dim x As dlgDBSetting = New dlgDBSetting()
        If x.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            MsgBox("Restart aplikasi untuk menjalankan setting baru", MsgBoxStyle.Information, "Setting database")
        End If
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class

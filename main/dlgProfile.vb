Public Class dlgProfile
    Public Sub New()
        MyBase.New(GMyEnvirontment)
        InitializeComponent()
    End Sub
    Protected Overrides Sub PrepareExtendedProfile(ByRef htblCurrent As System.Collections.Hashtable)
        '
        htblCurrent.Add("@refreshrate", numDisplayRT.Value)
        htblCurrent.Add("@loginginterval", numLogingInterval.Value)
        htblCurrent.Add("@deviceip", txtIPAddress.Text)
    End Sub
    Protected Overrides Sub InitialExtendedData(ByVal Source As System.Collections.Hashtable)
        numDisplayRT.Value = Source("refreshrate")
        numLogingInterval.Value = Source("loginginterval")
        txtIPAddress.Text = Source("deviceip")
    End Sub

End Class

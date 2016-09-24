Public Class cDlgFilter

    Private Sub cDlgFilter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTitle.Text = Me.Text
    End Sub
   
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        AddHandler btnOk.Click, AddressOf MyBase.buttonOKClick

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class

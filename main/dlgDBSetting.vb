Public Class dlgDBSetting
    Public Sub New()
        MyBase.New(GMyEnvirontment)

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        lblTitle.Text = Me.Text
        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal AppSetting As DALCore.AppCore.cAppSetting)
        MyBase.New(AppSetting)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class

Public Class cDlgUmum

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        OKFunction()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Public Overridable Sub OKFunction()
    End Sub
End Class
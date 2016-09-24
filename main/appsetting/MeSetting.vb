Imports DALCore
Public Class MeSetting
    Inherits DALCore.AppCore.cAppSetting

    Public Sub New(ByVal fileIni As String)
        MyBase.New(fileIni)
    End Sub
    Public Overrides Function GenerateConnection() As DALCore.IBase
        Me.DBType = AppCore.cAppSetting.enDatabaseType.MySQL
        Dim result As IBase = New DBMySQL(xDBServerURL, xDBPort, xDBName, xDBUserName, xDBPassword)
        Return result
    End Function

    Public Overrides Function Decrypt(ByVal source As String) As String
        Return GueTools.CKripto.RijndaelDecrypt(source, INT_KEY & STR_KEY)
    End Function
    Public Overrides Function Encrypt(ByVal source As String) As String
        Return GueTools.CKripto.RijndaelEncrypt(source, INT_KEY & STR_KEY)
    End Function
End Class

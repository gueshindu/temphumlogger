Public Class dalData
    Inherits DALCore.DALBase

    Public Sub New(ByVal connection As DALCore.IBase)
        baseConnection = connection
        stringNamaTableUtama = "c_data"
    End Sub

    Public Overrides Sub setBuildID()
        stringBuildID = "" ' no id
    End Sub
    Public Overloads Overrides Function AddBuildID() As Boolean
        Return AddBuildID(stringBuildID, "dalData", "n", "1")
    End Function

    Public Overloads Overrides Function DeleteItem(ByVal ID As String, ByVal UserUpdate As Integer) As Boolean

    End Function

    Public Overrides Function InsertItem(ByVal Data As System.Collections.Hashtable) As Boolean
        Dim Result As Boolean = True
        stringSQL = "INSERT INTO c_data (data_temp, data_hum, data_source, data_devip)  " & _
                    "VALUES(@temp, @hum, @source, @devip)"
        Result = baseConnection.ExecuteQuery(stringSQL, Data)
        WriteErrorDescription("Data.InsertItem" & vbCrLf & baseConnection.ErrorDescription, Result)
        
        Return Result
    End Function

    Public Overrides Function UpdateItem(ByVal Data As System.Collections.Hashtable) As Boolean

    End Function
End Class

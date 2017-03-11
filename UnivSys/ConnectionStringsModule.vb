Module ConnectionStringsModule
    Public conn As New ADODB.Connection()
    Public rs As New ADODB.Recordset()
    Public sql As String
    Public mode As String
    Public cnStr As String = My.Settings.UniversitySetting
End Module

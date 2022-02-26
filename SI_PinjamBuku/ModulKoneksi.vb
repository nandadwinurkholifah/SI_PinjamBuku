Imports System.Data.OleDb
Module ModulKoneksi
    Public cnn As OleDbConnection
    Public cmmd As OleDbCommand
    Public dreader As OleDbDataAdapter
    Public sql As String



    Public strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\pinajambukufinal.mdb"


    Public Sub koneksi()
        cnn = New OleDbConnection(strConn)
        If cnn.State <> ConnectionState.Closed Then cnn.Close()
        cnn.Open()
    End Sub
End Module

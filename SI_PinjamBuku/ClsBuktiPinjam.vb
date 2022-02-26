Imports System.Data.OleDb
Public Class ClsBuktiPinjam
    Private FNoBkt As String
    Private FTglBkt As Date
    Private FNIS As String


    Public Property PNoBkt As String
        Get
            Return FNoBkt
        End Get
        Set(value As String)
            FNoBkt = value
        End Set
    End Property

    Public Property PTglBkt As Date
        Get
            Return FTglBkt
        End Get
        Set(value As Date)
            FTglBkt = value
        End Set
    End Property

    Public Property PNIS As String
        Get
            Return FNIS
        End Get
        Set(value As String)
            FNIS = value
        End Set
    End Property





    Public Function Autonumber() As String
        Dim cmmd As OleDbCommand
        Dim dreader As OleDbDataReader
        Dim strTmp As String
        Dim nilaiAuto As String
        Dim sql As String

        sql = "SELECT * FROM bukti_pinjam ORDER BY no_bkt DESC"
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader
        If dreader.HasRows = True Then
            dreader.Read()
            strTmp = Mid(dreader.Item("no_bkt"), 3, 5)
            nilaiAuto = Val(strTmp) + 1
            nilaiAuto = "BKT" & Mid("00", 1, 3 - nilaiAuto.Length) & nilaiAuto
        Else
            nilaiAuto = "BKT01"
        End If
        dreader.Close()
        Return nilaiAuto
    End Function

    Public Function Cari() As Boolean
    End Function

    Public Function Simpan() As Integer
        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "INSERT INTO bukti_pinjam (no_bkt,tgl_bkt,nis) VALUES (?,?,?)"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("no_bkt", FNoBkt)
        cmmd.Parameters.AddWithValue("tgl_bkt", FTglBkt)
        cmmd.Parameters.AddWithValue("nis", FNIS)
        Return cmmd.ExecuteNonQuery()
    End Function

    Public Function TampilData(Optional xNoBkt As String = "") As System.Collections.Generic.List(Of SI_PinjamBuku.ClsBuktiPinjam)
    End Function
End Class

Imports System.Data.OleDb
Public Class ClsSiswa
    Private FNIS As String
    Private FNmSis As String
    Private FJenKel As String
    Private FKelas As String
    Private FAlmtSis As String
    Private FTmptLhr As String
    Private FTglLhr As Date
    Private FTlpSis As String


    Public Property PNIS As String
        Get
            Return FNIS
        End Get
        Set(value As String)
            FNIS = value
        End Set
    End Property

    Public Property PNmSis As String
        Get
            Return FNmSis
        End Get
        Set(value As String)
            FNmSis = value
        End Set
    End Property

    Public Property PJenKel As String
        Get
            Return FJenKel
        End Get
        Set(value As String)
            FJenKel = value
        End Set
    End Property

    Public Property PKelas As String
        Get
            Return FKelas
        End Get
        Set(value As String)
            FKelas = value
        End Set
    End Property

    Public Property PAlmtSis As String
        Get
            Return FAlmtSis
        End Get
        Set(value As String)
            FAlmtSis = value
        End Set
    End Property

    Public Property PTglLhr As Date
        Get
            Return FTglLhr
        End Get
        Set(value As Date)
            FTglLhr = value
        End Set
    End Property


    Public Property PTmptLhr As String
        Get
            Return FTmptLhr
        End Get
        Set(value As String)
            FTmptLhr = value
        End Set
    End Property

    Public Property PTlpSis As String
        Get
            Return FTlpSis
        End Get
        Set(value As String)
            FTlpSis = value
        End Set
    End Property


    Public Function Autonumber() As String
        Dim cmmd As OleDbCommand
        Dim dreader As OleDbDataReader
        Dim strTmp As String
        Dim nilaiAuto As String
        Dim sql As String

        sql = "SELECT * FROM siswa ORDER BY nis DESC"
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader
        If dreader.HasRows = True Then
            dreader.Read()
            strTmp = Mid(dreader.Item("nis"), 3, 5)
            nilaiAuto = Val(strTmp) + 1
            nilaiAuto = "NI" & Mid("000", 1, 3 - nilaiAuto.Length) & nilaiAuto
        Else
            nilaiAuto = "NI001"
        End If
        dreader.Close()
        Return nilaiAuto
    End Function

    Public Function Cari() As Boolean
        Dim sql As String
        Dim cmmd As OleDbCommand
        Dim dreader As OleDbDataReader

        sql = "SELECT * FROM siswa WHERE nis=?"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("nis", FNIS)
        dreader = cmmd.ExecuteReader
        If dreader.HasRows Then
            dreader.Read()
            FNIS = dreader.Item("nis").ToString
            FNmSis = dreader.Item("nm_sis").ToString
            FJenKel = dreader.Item("jenkel").ToString
            FKelas = dreader.Item("kelas").ToString
            FAlmtSis = dreader.Item("almt").ToString
            FTglLhr = dreader.Item("tgl_lhr").ToString
            FTmptLhr = dreader.Item("tmp_lhr").ToString
            FTlpSis = dreader.Item("tlp_sis").ToString
            dreader.Close()
            Return True
        Else
            dreader.Close()
            Return False
        End If
    End Function

    Public Function Hapus() As Integer
        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "DELETE FROM siswa WHERE nis=?"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("nis", FNIS)
        Return cmmd.ExecuteNonQuery()
    End Function

    Public Function Simpan() As Integer

        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "INSERT INTO siswa (nis,nm_sis,jenkel,kelas,almt,tgl_lhr,tmp_lhr,tlp_sis) VALUES (?,?,?,?,?,?,?,?)"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("nis", FNIS)
        cmmd.Parameters.AddWithValue("nm_sis", FNmSis)
        cmmd.Parameters.AddWithValue("jenkel", FJenKel)
        cmmd.Parameters.AddWithValue("kelas", FKelas)
        cmmd.Parameters.AddWithValue("almt", FAlmtSis)
        cmmd.Parameters.AddWithValue("tgl_lhr", FTglLhr)
        cmmd.Parameters.AddWithValue("tmp_lhr", FTmptLhr)
        cmmd.Parameters.AddWithValue("tlp_sis", FTlpSis)
        Return cmmd.ExecuteNonQuery()
    End Function

    Public Function TampilData(Optional xnm_sis As String = "") As List(Of ClsSiswa)
        Dim sql As String
        Dim cmmd As OleDbCommand
        Dim dreader As OleDbDataReader
        Dim siswa As New List(Of ClsSiswa)

        sql = "SELECT * FROM siswa WHERE nm_sis LIKE '%" & xnm_sis & "%'"
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader
        If dreader.HasRows Then
            While dreader.Read
                Dim objTemp As New ClsSiswa
                objTemp.FNIS = dreader.Item("nis")
                objTemp.FNmSis = dreader.Item("nm_sis")
                objTemp.FJenKel = dreader.Item("jenkel")
                objTemp.FKelas = dreader.Item("kelas")
                objTemp.FAlmtSis = dreader.Item("almt")
                objTemp.FTglLhr = dreader.Item("tgl_lhr")
                objTemp.FTmptLhr = dreader.Item("tmp_lhr")
                objTemp.FTlpSis = dreader.Item("tlp_sis")
                siswa.Add(objTemp)
            End While
        End If
        dreader.Close()
        Return siswa
    End Function

    Public Function Ubah() As Integer
        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "UPDATE siswa SET nm_sis=?, jenkel=?, kelas=?, almt=?, tgl_lhr=?, tmp_lhr=?, tlp_sis=? WHERE nis=?"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("nm_sis", FNmSis)
        cmmd.Parameters.AddWithValue("jenkel", FJenKel)
        cmmd.Parameters.AddWithValue("kelas", FKelas)
        cmmd.Parameters.AddWithValue("almt", FAlmtSis)
        cmmd.Parameters.AddWithValue("tgl_lhr", FTglLhr)
        cmmd.Parameters.AddWithValue("tmp_lhr", FTmptLhr)
        cmmd.Parameters.AddWithValue("tlp_sis", FTlpSis)
        cmmd.Parameters.AddWithValue("nis", FNIS)
        Return cmmd.ExecuteNonQuery()
    End Function
End Class

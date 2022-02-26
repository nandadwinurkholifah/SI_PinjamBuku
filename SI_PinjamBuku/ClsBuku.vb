Imports System.Data.OleDb
Public Class ClsBuku
    Private FKdBuku As String
    Private FJudul As String
    Private FPenerbit As String
    Private FPengarang As String
    Private FThnTerbit As String
    Private FHargaPinjam As Double
    Private FStock As Double

    Public Property PKdBuku As String
        Get
            Return FKdBuku
        End Get
        Set(value As String)
            FKdBuku = value
        End Set
    End Property

    Public Property PJudul As String
        Get
            Return FJudul
        End Get
        Set(value As String)
            FJudul = value
        End Set
    End Property

    Public Property PPenerbit As String
        Get
            Return FPenerbit
        End Get
        Set(value As String)
            FPenerbit = value
        End Set
    End Property

    Public Property PPengarang As String
        Get
            Return FPengarang
        End Get
        Set(value As String)
            FPengarang = value
        End Set
    End Property

    Public Property PThnTerbit As String
        Get
            Return FThnTerbit
        End Get
        Set(value As String)
            FThnTerbit = value
        End Set
    End Property

    Public Property PHargaPinjam As Double
        Get
            Return FHargaPinjam
        End Get
        Set(value As Double)
            FHargaPinjam = value
        End Set
    End Property

    Public Property PStock As Double
        Get
            Return FStock
        End Get
        Set(value As Double)
            FStock = value
        End Set
    End Property

    Public Function Cari() As Boolean
        Dim sql As String
        Dim cmmd As OleDbCommand
        Dim dreader As OleDbDataReader

        sql = "SELECT * FROM buku WHERE kdbuku=?"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("kdbuku", FKdBuku)
        dreader = cmmd.ExecuteReader
        If dreader.HasRows Then
            dreader.Read()
            FKdBuku = dreader.Item("kdbuku").ToString
            FJudul = dreader.Item("judul").ToString
            FPenerbit = dreader.Item("penerbit").ToString
            FPengarang = dreader.Item("pengarang").ToString
            FThnTerbit = dreader.Item("thnterbit").ToString
            FHargaPinjam = dreader.Item("hargapinjam").ToString
            FStock = dreader.Item("stock").ToString
            dreader.Close()
            Return True
        Else
            dreader.Close()
            Return False
        End If
    End Function

    Public Function TampilData(Optional xJudul As String = "") As List(Of ClsBuku)
        Dim sql As String
        Dim cmmd As OleDbCommand
        Dim dreader As OleDbDataReader
        Dim tmpBaca As New List(Of ClsBuku)

        sql = "SELECT * FROM buku WHERE judul LIKE '%" & xJudul & "%'"
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader
        If dreader.HasRows Then
            While dreader.Read
                Dim objTemp As New ClsBuku
                objTemp.FKdBuku = dreader.Item("kdBuku")
                objTemp.FJudul = dreader.Item("judul")
                objTemp.FPenerbit = dreader.Item("penerbit")
                objTemp.FPengarang = dreader.Item("pengarang")
                objTemp.FThnTerbit = dreader.Item("thnterbit")
                objTemp.FHargaPinjam = dreader.Item("hargapinjam")
                objTemp.FStock = dreader.Item("stock")
                tmpBaca.Add(objTemp)
            End While
        End If
        dreader.Close()
        Return tmpBaca
    End Function

    Public Function Simpan() As Integer
        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "INSERT INTO buku (kdbuku,judul,penerbit,pengarang,thnterbit,hargapinjam,stock) VALUES (?,?,?,?,?,?,?)"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("kdbuku", FKdBuku)
        cmmd.Parameters.AddWithValue("judul", FJudul)
        cmmd.Parameters.AddWithValue("penerbit", FPenerbit)
        cmmd.Parameters.AddWithValue("pengarang", FPengarang)
        cmmd.Parameters.AddWithValue("thnterbit", FThnTerbit)
        cmmd.Parameters.AddWithValue("hargapinjam", FHargaPinjam)
        cmmd.Parameters.AddWithValue("stock", FStock)
        Return cmmd.ExecuteNonQuery()
    End Function

    Public Function Ubah() As Integer
        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "UPDATE buku SET judul=?, penerbit=?, pengarang=?, thnterbit=?, hargapinjam=?, stock=? WHERE kdbuku=?"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("judul", FJudul)
        cmmd.Parameters.AddWithValue("penerbit", FPenerbit)
        cmmd.Parameters.AddWithValue("pengarang", FPengarang)
        cmmd.Parameters.AddWithValue("thnterbit", FThnTerbit)
        cmmd.Parameters.AddWithValue("hargapinjam", FHargaPinjam)
        cmmd.Parameters.AddWithValue("stock", FStock)
        cmmd.Parameters.AddWithValue("kdbuku", FKdBuku)
        Return cmmd.ExecuteNonQuery()
    End Function

    Public Function Hapus() As Integer
        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "DELETE FROM buku WHERE kdbuku=?"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("kdbuku", FKdBuku)
        Return cmmd.ExecuteNonQuery()
    End Function

    Public Function Autonumber() As String
        Dim cmmd As OleDbCommand
        Dim dreader As OleDbDataReader
        Dim strTmp As String
        Dim nilaiAuto As String
        Dim sql As String

        sql = "SELECT * FROM buku ORDER BY kdbuku DESC"
        cmmd = New OleDbCommand(sql, cnn)
        dreader = cmmd.ExecuteReader
        If dreader.HasRows = True Then
            dreader.Read()
            strTmp = Mid(dreader.Item("kdbuku"), 3, 5)
            nilaiAuto = Val(strTmp) + 1
            nilaiAuto = "BK" & Mid("000", 1, 3 - nilaiAuto.Length) & nilaiAuto
        Else
            nilaiAuto = "BK001"
        End If
        dreader.Close()
        Return nilaiAuto
    End Function
End Class

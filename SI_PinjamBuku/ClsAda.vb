Imports System.Data.OleDb
Public Class ClsAda
    Private FNoBkt As String
    Private FKdBuku As String
    Private FHrgPjm As Double
    Private FJmlPjm As Double


    Public Property PNoBkt As String
        Get
            Return FNoBkt
        End Get
        Set(value As String)
            FNoBkt = value
        End Set
    End Property

    Public Property PKdBuku As String
        Get
            Return FKdBuku
        End Get
        Set(value As String)
            FKdBuku = value
        End Set
    End Property


    Public Property PHrgPjm As Double
        Get
            Return FHrgPjm
        End Get
        Set(value As Double)
            FHrgPjm = value
        End Set
    End Property

    Public Property PJmlPjm As Integer
        Get
            Return FJmlPjm
        End Get
        Set(value As Integer)
            FJmlPjm = value
        End Set
    End Property

    Public Function Cari() As Boolean
    End Function

    Public Function Simpan() As Integer
        Dim sql As String
        Dim cmmd As OleDbCommand

        sql = "INSERT INTO ada (no_bkt,kd_buku,harga_pinjam,jml_pinjam) VALUES (?,?,?,?)"
        cmmd = New OleDbCommand(sql, cnn)
        cmmd.CommandType = CommandType.Text
        cmmd.Parameters.AddWithValue("no_bkt", FNoBkt)
        cmmd.Parameters.AddWithValue("kd_buku", FKdBuku)
        cmmd.Parameters.AddWithValue("harga_pinjam", FHrgPjm)
        cmmd.Parameters.AddWithValue("jml_pinjam", FJmlPjm)
        Return cmmd.ExecuteNonQuery()
    End Function

    Public Function TampilData(Optional xNoBkt As String = "") As System.Collections.Generic.List(Of SI_PinjamBuku.ClsAda)
    End Function
End Class

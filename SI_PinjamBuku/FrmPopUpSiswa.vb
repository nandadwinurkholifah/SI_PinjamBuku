Public Class FrmPopUpSiswa
    Public Rnis As String
    Public Rnmsis As String
    Public Rjenkel As String
    Public Rkelas As String
    Public Ralmt As String
    Public Rdtlahir As String
    Public Rtmpt As String
    Public Rtlp As String
    Dim objSiswa As New ClsSiswa

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsSiswa)
        xList = objSiswa.TampilData(kriteria)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).PNIS)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PNmSis)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PJenKel)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PKelas)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PAlmtSis)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PTmptLhr)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PTglLhr)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PTlpSis)
        Next
    End Sub

    Sub pilihBarisView()
        Rnis = ListView1.FocusedItem.Text
        Rnmsis = ListView1.FocusedItem.SubItems(1).Text
        Rjenkel = ListView1.FocusedItem.SubItems(2).Text
        Rkelas = ListView1.FocusedItem.SubItems(3).Text
        Ralmt = ListView1.FocusedItem.SubItems(4).Text
        Rtmpt = ListView1.FocusedItem.SubItems(5).Text
        Rdtlahir = ListView1.FocusedItem.SubItems(6).Text
        Rtlp = ListView1.FocusedItem.SubItems(7).Text
        Me.Close()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_pilih_Click(sender As Object, e As EventArgs) Handles btn_pilih.Click
        pilihBarisView()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        isiListView(TextBox1.Text)
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        pilihBarisView()
    End Sub

    Private Sub FrmPopUpSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        isiListView()

    End Sub
End Class
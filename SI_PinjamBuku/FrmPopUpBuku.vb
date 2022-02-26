Public Class FrmPopUpBuku
    Public RKdBuku As String
    Public RJudul As String
    Public RPenerbit As String
    Public RPengarang As String
    Public RThnTerbit As String
    Public RHargaPinjam As String
    Public RStock As String
    Dim objBuku As New ClsBuku


    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsBuku)
        xList = objBuku.TampilData(kriteria)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).PKdBuku)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PJudul)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PPenerbit)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PPengarang)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PThnTerbit)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PHargaPinjam)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).PStock)
        Next
    End Sub

    Sub pilihBarisView()
        RKdBuku = ListView1.FocusedItem.Text
        RJudul = ListView1.FocusedItem.SubItems(1).Text
        RPenerbit = ListView1.FocusedItem.SubItems(2).Text
        RPengarang = ListView1.FocusedItem.SubItems(3).Text
        RThnTerbit = ListView1.FocusedItem.SubItems(4).Text
        RHargaPinjam = ListView1.FocusedItem.SubItems(5).Text
        RStock = ListView1.FocusedItem.SubItems(6).Text
        Me.Close()
    End Sub

    Private Sub FrmPopUpBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        isiListView()
    End Sub

    Private Sub txtKataKunci_TextChanged(sender As Object, e As EventArgs) Handles txtKataKunci.TextChanged
        isiListView(txtKataKunci.Text)
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        pilihBarisView()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        pilihBarisView()
    End Sub


End Class
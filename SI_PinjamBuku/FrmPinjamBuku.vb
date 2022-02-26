Public Class FrmPinjamBuku
    Dim objBktPjm As New ClsBuktiPinjam
    Dim objAda As New ClsAda

    Private Sub clearForm()
        txt_no.Text = objBktPjm.Autonumber
        dtpinjam.Value = Now
        lvpinjambuku.Items.Clear()
        txtgrandtotal.Clear()
    End Sub

    Private Sub clearsiswa()
        txt_nis.clear
        txt_nama.clear
    End Sub

    Private Sub clearbuku()
        txtbuku.Clear
        txtjudul.Clear
        txtpengarang.Clear
        txtharga.Clear
        txtharga2.Clear
        txtjmlpinjam.Clear
        txttotal.Clear
    End Sub

    Function grandtotal() As Double
        Dim gt As Double = 0
        For i As Integer = 0 To lvpinjambuku.Items.Count - 1
            gt = gt + CDbl(lvpinjambuku.Items(i).SubItems(4).Text)
        Next
        Return gt
    End Function

    Private Sub FrmPinjamBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txt_no.Text = objBktPjm.Autonumber()
    End Sub

    Private Sub btn_carisiswa_Click(sender As Object, e As EventArgs) Handles btn_carisiswa.Click
        Dim oPop As New FrmPopUpSiswa
        oPop.ShowDialog()
        If oPop.Rnis <> "" Then
            txt_nis.Text = oPop.Rnis
            txt_nama.Text = oPop.Rnmsis
            btn_caribuku.Focus()
        End If
    End Sub

    Private Sub btn_caribuku_Click(sender As Object, e As EventArgs) Handles btn_caribuku.Click
        Dim oPop As New FrmPopUpBuku
        oPop.ShowDialog()
        If oPop.RKdBuku <> "" Then
            txtbuku.Text = oPop.RKdBuku
            txtjudul.Text = oPop.RJudul
            txtpengarang.Text = oPop.RPengarang
            txtharga.Text = oPop.RHargaPinjam
            txtharga2.Text = txtharga.Text
            txtjmlpinjam.Focus()
        End If
    End Sub

    Private Sub txtjmlpinjam_TextChanged(sender As Object, e As EventArgs) Handles txtjmlpinjam.TextChanged
        txttotal.Text = Val(txtjmlpinjam.Text) * Val(txtharga2.Text)
    End Sub

    Private Sub txtjmlpinjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjmlpinjam.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_tambah.Focus()
        End If
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim n As Integer
        For n = 0 To lvpinjambuku.Items.Count - 1
            If lvpinjambuku.Items(n).Text = txtbuku.Text Then
                MsgBox("Data Buku ada pada List")
                Exit Sub
            End If
        Next
        lvpinjambuku.Items.Add(txtbuku.Text)
        lvpinjambuku.Items(n).SubItems.Add(txtjudul.Text)
        lvpinjambuku.Items(n).SubItems.Add(txtharga2.Text)
        lvpinjambuku.Items(n).SubItems.Add(txtjmlpinjam.Text)
        lvpinjambuku.Items(n).SubItems.Add(txttotal.Text)
        txtgrandtotal.Text = Format(CDbl(grandtotal()), "###,###,###")
        clearbuku()
        txtbuku.Focus()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        clearbuku()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_nis.Text = "" Or lvpinjambuku.Items.Count = 0 Then
            MsgBox("Data Belum lengkap", MsgBoxStyle.Information, "Informasi")
        Else
            Dim nilaikembali, nilaikembali2 As Integer
            objBktPjm.PNoBkt = txt_no.Text
            objBktPjm.PTglBkt = Format(dtpinjam.Value, "yyyy-MM-dd")
            objBktPjm.PNIS = txt_nis.Text
            nilaikembali = objBktPjm.Simpan

            'menyimpan ke table Ada menggunkan looping
            For x As Integer = 0 To lvpinjambuku.Items.Count - 1
                objAda.PNoBkt = txt_no.Text
                objAda.PKdBuku = lvpinjambuku.Items(x).SubItems(0).Text
                objAda.PHrgPjm = CDbl(lvpinjambuku.Items(x).SubItems(2).Text)
                objAda.PJmlPjm = CDbl(lvpinjambuku.Items(x).SubItems(3).Text)
                nilaikembali2 = objAda.Simpan
            Next
            If nilaikembali = 1 And nilaikembali2 = 1 Then
                MsgBox("Data Berhasil Dsisimpan", MsgBoxStyle.Information, "Informasi")
                ModulCetak.cetakBuktiPinjam(txt_no.Text)

            End If
            clearForm()
            clearbuku()
            clearsiswa()
            txt_no.Text = objBktPjm.Autonumber
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class
Public Class FrmMasterBuku
    Dim objBuku As New ClsBuku

    Private Sub FrmMasterBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtBuku.Text = objBuku.Autonumber()
    End Sub

    Private Sub bersih()
        txtJudul.Clear()
        txtPenerbit.Clear()
        txtPengarang.Clear()
        txtThnTerbit.Text() = ""
        txtHarga.Text = ""
        txtStok.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        objBuku.PKdBuku = txtBuku.Text
        objBuku.PJudul = txtJudul.Text
        objBuku.PPenerbit = txtPenerbit.Text
        objBuku.PPengarang = txtPengarang.Text
        objBuku.PThnTerbit = txtThnTerbit.Text
        objBuku.PHargaPinjam = txtHarga.Text
        objBuku.PStock = txtStok.Text

        If objBuku.Simpan = 1 Then
            MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
            bersih()
            txtBuku.Text = objBuku.Autonumber()
        Else
            MessageBox.Show("Data Gagal Disimpan", "Gagal")
        End If

        bersih()
        txtBuku.Text = objBuku.Autonumber()
        txtBuku.Enabled = True
        BtnCari.Enabled = True
        txtBuku.Focus()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        objBuku.PKdBuku = txtBuku.Text
        objBuku.PJudul = txtJudul.Text
        objBuku.PPenerbit = txtPenerbit.Text
        objBuku.PPengarang = txtPengarang.Text
        objBuku.PThnTerbit = txtThnTerbit.Text
        objBuku.PHargaPinjam = txtHarga.Text
        objBuku.PStock = txtStok.Text

        If objBuku.Ubah = 1 Then
            MessageBox.Show("Data Berhasil Diubah", "Berhasil")
            bersih()
            txtBuku.Text = objBuku.Autonumber()
        Else
            MessageBox.Show("Data Gagal Diubah", "Gagal")
        End If

        bersih()
        txtBuku.Text = objBuku.Autonumber()
        txtBuku.Enabled = True
        BtnCari.Enabled = True
        txtBuku.Focus()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        objBuku.PKdBuku = txtBuku.Text
        If objBuku.Hapus = 1 Then
            MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
            bersih()
            txtBuku.Text = objBuku.Autonumber()
        Else
            MessageBox.Show("Data Gagal Dihapus", "Gagal")
        End If

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        bersih()
        txtBuku.Text = objBuku.Autonumber()
        txtBuku.Enabled = True
        txtJudul.Focus()
        BtnSimpan.Enabled = True
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub


    Private Sub txtBuku_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtBuku.Enabled = False
            objBuku.PKdBuku = txtBuku.Text

            If objBuku.Cari = True Then
                txtBuku.Text = objBuku.PKdBuku
                txtJudul.Text = objBuku.PJudul
                txtPenerbit.Text = objBuku.PPenerbit
                txtPengarang.Text = objBuku.PPengarang
                txtThnTerbit.Text = objBuku.PThnTerbit
                txtHarga.Text = objBuku.PHargaPinjam
                txtStok.Text = objBuku.PStock
                BtnSimpan.Enabled = False
            Else
                BtnUbah.Enabled = False
                BtnHapus.Enabled = False

            End If
            BtnCari.Enabled = True
            txtJudul.Focus()
        End If
    End Sub

    
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(10)
            MessageBox.Show("Harus Masukkan Angka!")
        ElseIf Asc(e.KeyChar) = 13 Then
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim oPop As New FrmPopUpBuku
        oPop.ShowDialog()
        If oPop.RKdBuku <> "" Then
            txtBuku.Text = oPop.RKdBuku
            txtJudul.Text = oPop.RJudul
            txtPenerbit.Text = oPop.RPenerbit
            txtPengarang.Text = oPop.RPengarang
            txtThnTerbit.Text = oPop.RThnTerbit
            txtHarga.Text = oPop.RHargaPinjam
            txtStok.Text = oPop.RStock

            txtBuku.Enabled = False
            BtnSimpan.Enabled = False
            txtJudul.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModulCetak.cetakLapBukuAll()

    End Sub
End Class
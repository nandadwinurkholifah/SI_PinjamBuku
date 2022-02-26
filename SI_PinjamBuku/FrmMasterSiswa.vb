Public Class FrmMasterSiswa
    Dim objSiswa As New ClsSiswa

    Private Sub FrmMasterSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtnis.Text = objSiswa.Autonumber()
        cbjenkel.SelectedItem = "Laki - laki"
    End Sub


    Private Sub bersih()
        txtnmsis.Clear()
        txtkelas.Clear()
        txtalmt.Clear()
        txttmpt.Clear()
        txttlp.Clear()
        cbjenkel.Text = ""
        dtplahir.Value = Date.Now()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        objSiswa.PNIS = txtnis.Text
        objSiswa.PNmSis = txtnmsis.Text
        objSiswa.PJenKel = cbjenkel.SelectedItem
        objSiswa.PKelas = txtkelas.Text
        objSiswa.PAlmtSis = txtalmt.Text
        objSiswa.PTglLhr = dtplahir.Value.Date
        objSiswa.PTmptLhr = txttmpt.Text
        objSiswa.PTlpSis = txttlp.Text

        If objSiswa.Simpan = 1 Then
            MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
            bersih()
            txtnis.Text = objSiswa.Autonumber()
        Else
            MessageBox.Show("Data Gagal Disimpan", "Gagal")
        End If

        bersih()
        txtnis.Text = objSiswa.Autonumber()
        txtnis.Enabled = True
        btn_cari.Enabled = True
        txtnis.Focus()
    End Sub


    Private Sub txtnis_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtnis.Enabled = False
            objSiswa.PNIS = txtnis.Text

            If objSiswa.Cari = True Then
                txtnis.Text = objSiswa.PNIS
                txtnmsis.Text = objSiswa.PNmSis
                cbjenkel.SelectedItem = objSiswa.PJenKel
                txtkelas.Text = objSiswa.PKelas
                txtalmt.Text = objSiswa.PAlmtSis
                dtplahir.Value = objSiswa.PTglLhr
                txttmpt.Text = objSiswa.PTmptLhr
                txttlp.Text = objSiswa.PTlpSis
                btn_simpan.Enabled = False
            Else
                btn_ubah.Enabled = False
                btn_hapus.Enabled = False

            End If
            btn_cari.Enabled = True
            txtnmsis.Focus()

        End If
    End Sub


    ' Private Sub txttlp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttlp.KeyPress
    'If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
    '       e.KeyChar = Chr(10)
    '       MessageBox.Show("Harus Masukkan Angka!")
    'ElseIf Asc(e.KeyChar) = 13 Then
    'End If
    ' End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        objSiswa.PNIS = txtnis.Text
        objSiswa.PNmSis = txtnmsis.Text
        objSiswa.PJenKel = cbjenkel.SelectedItem
        objSiswa.PKelas = txtkelas.Text
        objSiswa.PAlmtSis = txtalmt.Text
        objSiswa.PTglLhr = dtplahir.Value
        objSiswa.PTmptLhr = txttmpt.Text
        objSiswa.PTlpSis = txttlp.Text

        If objSiswa.Ubah = 1 Then
            MessageBox.Show("Data Berhasil Diubah", "Berhasil")
            bersih()
            txtnis.Text = objSiswa.Autonumber()
        Else
            MessageBox.Show("Data Gagal Diubah", "Gagal")
        End If

        bersih()
        txtnis.Text = objSiswa.Autonumber()
        txtnis.Enabled = True
        btn_cari.Enabled = True
        txtnis.Focus()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        objSiswa.PNIS = txtnis.Text
        If objSiswa.Hapus = 1 Then
            MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
            bersih()
            txtnis.Text = objSiswa.Autonumber()
        Else
            MessageBox.Show("Data Gagal Dihapus", "Gagal")
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        bersih()
        txtnis.Text = objSiswa.Autonumber()
        txtnis.Enabled = True
        txtnmsis.Focus()
        btn_simpan.Enabled = True
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Dim oPop As New FrmPopUpSiswa
        oPop.ShowDialog()
        If oPop.Rnis <> "" Then
            txtnis.Text = oPop.Rnis
            txtnmsis.Text = oPop.Rnmsis
            cbjenkel.SelectedItem = oPop.Rjenkel
            txtkelas.Text = oPop.Rkelas
            txtalmt.Text = oPop.Ralmt
            dtplahir.Value = oPop.Rdtlahir
            txttmpt.Text = oPop.Rtmpt
            txttlp.Text = oPop.Rtlp

            txtnis.Enabled = False
            btn_simpan.Enabled = False
            txtnmsis.Focus()
        End If
    End Sub
End Class
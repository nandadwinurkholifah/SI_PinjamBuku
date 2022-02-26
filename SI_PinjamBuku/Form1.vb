Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            koneksi() 'memanggil prosedur koneksi yang ada pada ModulKoneksi'
            MessageBox.Show("Koneksi Sukses", "Informasi", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error", "Informasi", MessageBoxButtons.OK)
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK)
            Me.Dispose()


        End Try
    End Sub

    Private Sub MasterSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSiswaToolStripMenuItem.Click
        FrmMasterSiswa.Show()
    End Sub

    Private Sub MasterBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBukuToolStripMenuItem.Click
        FrmMasterBuku.Show()
    End Sub

    Private Sub TransaksiPinjamBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPinjamBukuToolStripMenuItem.Click
        FrmPinjamBuku.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If (MessageBox.Show("Apakah yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            End
        End If
    End Sub
End Class

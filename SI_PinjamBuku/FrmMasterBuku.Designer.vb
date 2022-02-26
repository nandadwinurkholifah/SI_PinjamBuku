<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.judul = New System.Windows.Forms.Label()
        Me.lbl_penerbit = New System.Windows.Forms.Label()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.txtThnTerbit = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.lbl_pengarang = New System.Windows.Forms.Label()
        Me.lbl_thpenerbit = New System.Windows.Forms.Label()
        Me.lbl_harga = New System.Windows.Forms.Label()
        Me.lbl_stok = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.txtBuku = New System.Windows.Forms.TextBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(244, 71)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(181, 20)
        Me.txtJudul.TabIndex = 0
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.Location = New System.Drawing.Point(68, 74)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(32, 13)
        Me.judul.TabIndex = 1
        Me.judul.Text = "Judul"
        '
        'lbl_penerbit
        '
        Me.lbl_penerbit.AutoSize = True
        Me.lbl_penerbit.Location = New System.Drawing.Point(68, 130)
        Me.lbl_penerbit.Name = "lbl_penerbit"
        Me.lbl_penerbit.Size = New System.Drawing.Size(46, 13)
        Me.lbl_penerbit.TabIndex = 2
        Me.lbl_penerbit.Text = "Penerbit"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(244, 123)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(181, 20)
        Me.txtPenerbit.TabIndex = 3
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(244, 176)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(181, 20)
        Me.txtPengarang.TabIndex = 4
        '
        'txtThnTerbit
        '
        Me.txtThnTerbit.Location = New System.Drawing.Point(244, 231)
        Me.txtThnTerbit.Name = "txtThnTerbit"
        Me.txtThnTerbit.Size = New System.Drawing.Size(181, 20)
        Me.txtThnTerbit.TabIndex = 5
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(244, 288)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(181, 20)
        Me.txtHarga.TabIndex = 6
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(244, 340)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(181, 20)
        Me.txtStok.TabIndex = 7
        '
        'lbl_pengarang
        '
        Me.lbl_pengarang.AutoSize = True
        Me.lbl_pengarang.Location = New System.Drawing.Point(68, 183)
        Me.lbl_pengarang.Name = "lbl_pengarang"
        Me.lbl_pengarang.Size = New System.Drawing.Size(59, 13)
        Me.lbl_pengarang.TabIndex = 8
        Me.lbl_pengarang.Text = "Pengarang"
        '
        'lbl_thpenerbit
        '
        Me.lbl_thpenerbit.AutoSize = True
        Me.lbl_thpenerbit.Location = New System.Drawing.Point(68, 234)
        Me.lbl_thpenerbit.Name = "lbl_thpenerbit"
        Me.lbl_thpenerbit.Size = New System.Drawing.Size(68, 13)
        Me.lbl_thpenerbit.TabIndex = 9
        Me.lbl_thpenerbit.Text = "Tahun Terbit"
        '
        'lbl_harga
        '
        Me.lbl_harga.AutoSize = True
        Me.lbl_harga.Location = New System.Drawing.Point(68, 288)
        Me.lbl_harga.Name = "lbl_harga"
        Me.lbl_harga.Size = New System.Drawing.Size(70, 13)
        Me.lbl_harga.TabIndex = 10
        Me.lbl_harga.Text = "Harga Pinjam"
        '
        'lbl_stok
        '
        Me.lbl_stok.AutoSize = True
        Me.lbl_stok.Location = New System.Drawing.Point(68, 340)
        Me.lbl_stok.Name = "lbl_stok"
        Me.lbl_stok.Size = New System.Drawing.Size(29, 13)
        Me.lbl_stok.TabIndex = 11
        Me.lbl_stok.Text = "Stok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode Buku"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(69, 415)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 14
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(177, 415)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 23)
        Me.BtnUbah.TabIndex = 15
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(118, 463)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 16
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(387, 415)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 17
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(225, 463)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 18
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'txtBuku
        '
        Me.txtBuku.Location = New System.Drawing.Point(244, 20)
        Me.txtBuku.Name = "txtBuku"
        Me.txtBuku.Size = New System.Drawing.Size(181, 20)
        Me.txtBuku.TabIndex = 20
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(285, 415)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 21
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmMasterBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 515)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtBuku)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_stok)
        Me.Controls.Add(Me.lbl_harga)
        Me.Controls.Add(Me.lbl_thpenerbit)
        Me.Controls.Add(Me.lbl_pengarang)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtThnTerbit)
        Me.Controls.Add(Me.txtPengarang)
        Me.Controls.Add(Me.txtPenerbit)
        Me.Controls.Add(Me.lbl_penerbit)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me.txtJudul)
        Me.Name = "FrmMasterBuku"
        Me.Text = "FrmMasterBuku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJudul As TextBox
    Friend WithEvents judul As Label
    Friend WithEvents lbl_penerbit As Label
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtThnTerbit As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents lbl_pengarang As Label
    Friend WithEvents lbl_thpenerbit As Label
    Friend WithEvents lbl_harga As Label
    Friend WithEvents lbl_stok As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents txtBuku As TextBox
    Friend WithEvents btncari As Button
    Friend WithEvents Button1 As Button
End Class

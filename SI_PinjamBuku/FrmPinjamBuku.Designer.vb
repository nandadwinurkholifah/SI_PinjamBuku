<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPinjamBuku
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_caribuku = New System.Windows.Forms.Button()
        Me.btn_carisiswa = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lvpinjambuku = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpinjam = New System.Windows.Forms.DateTimePicker()
        Me.txtgrandtotal = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_nis = New System.Windows.Forms.TextBox()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbuku = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtpengarang = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtharga2 = New System.Windows.Forms.TextBox()
        Me.txtjmlpinjam = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Pinjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIS"
        '
        'btn_caribuku
        '
        Me.btn_caribuku.Location = New System.Drawing.Point(261, 403)
        Me.btn_caribuku.Name = "btn_caribuku"
        Me.btn_caribuku.Size = New System.Drawing.Size(75, 23)
        Me.btn_caribuku.TabIndex = 2
        Me.btn_caribuku.Text = "Cari Buku"
        Me.btn_caribuku.UseVisualStyleBackColor = True
        '
        'btn_carisiswa
        '
        Me.btn_carisiswa.Location = New System.Drawing.Point(428, 403)
        Me.btn_carisiswa.Name = "btn_carisiswa"
        Me.btn_carisiswa.Size = New System.Drawing.Size(75, 23)
        Me.btn_carisiswa.TabIndex = 3
        Me.btn_carisiswa.Text = "Cari Siswa"
        Me.btn_carisiswa.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(615, 403)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 4
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(261, 457)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 5
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(428, 457)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 6
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(615, 457)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 8
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Grand Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tgl. Pinjam"
        '
        'lvpinjambuku
        '
        Me.lvpinjambuku.HideSelection = False
        Me.lvpinjambuku.Location = New System.Drawing.Point(166, 254)
        Me.lvpinjambuku.Name = "lvpinjambuku"
        Me.lvpinjambuku.Size = New System.Drawing.Size(200, 97)
        Me.lvpinjambuku.TabIndex = 12
        Me.lvpinjambuku.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "List Pinjam Buku"
        '
        'dtpinjam
        '
        Me.dtpinjam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinjam.Location = New System.Drawing.Point(166, 213)
        Me.dtpinjam.Name = "dtpinjam"
        Me.dtpinjam.Size = New System.Drawing.Size(200, 20)
        Me.dtpinjam.TabIndex = 14
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.Location = New System.Drawing.Point(166, 169)
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(200, 20)
        Me.txtgrandtotal.TabIndex = 15
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(166, 122)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(200, 20)
        Me.txt_nama.TabIndex = 16
        '
        'txt_nis
        '
        Me.txt_nis.Location = New System.Drawing.Point(166, 79)
        Me.txt_nis.Name = "txt_nis"
        Me.txt_nis.Size = New System.Drawing.Size(200, 20)
        Me.txt_nis.TabIndex = 17
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(166, 36)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_no.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(515, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kode Buku"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(517, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Judul"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(515, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Pengarang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(517, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Harga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(517, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Harga2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(515, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Jumlah Pinjam"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(515, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Total"
        '
        'txtbuku
        '
        Me.txtbuku.Location = New System.Drawing.Point(625, 35)
        Me.txtbuku.Name = "txtbuku"
        Me.txtbuku.Size = New System.Drawing.Size(200, 20)
        Me.txtbuku.TabIndex = 26
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(625, 75)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(200, 20)
        Me.txtjudul.TabIndex = 27
        '
        'txtpengarang
        '
        Me.txtpengarang.Location = New System.Drawing.Point(625, 118)
        Me.txtpengarang.Name = "txtpengarang"
        Me.txtpengarang.Size = New System.Drawing.Size(200, 20)
        Me.txtpengarang.TabIndex = 28
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(625, 161)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(200, 20)
        Me.txtharga.TabIndex = 29
        '
        'txtharga2
        '
        Me.txtharga2.Location = New System.Drawing.Point(625, 211)
        Me.txtharga2.Name = "txtharga2"
        Me.txtharga2.Size = New System.Drawing.Size(200, 20)
        Me.txtharga2.TabIndex = 30
        '
        'txtjmlpinjam
        '
        Me.txtjmlpinjam.Location = New System.Drawing.Point(625, 264)
        Me.txtjmlpinjam.Name = "txtjmlpinjam"
        Me.txtjmlpinjam.Size = New System.Drawing.Size(200, 20)
        Me.txtjmlpinjam.TabIndex = 31
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(625, 313)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(200, 20)
        Me.txttotal.TabIndex = 32
        '
        'FrmPinjamBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 516)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjmlpinjam)
        Me.Controls.Add(Me.txtharga2)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtpengarang)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.txtbuku)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.txt_nis)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.txtgrandtotal)
        Me.Controls.Add(Me.dtpinjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lvpinjambuku)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_carisiswa)
        Me.Controls.Add(Me.btn_caribuku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPinjamBuku"
        Me.Text = "FrmPinjamBuku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_caribuku As Button
    Friend WithEvents btn_carisiswa As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lvpinjambuku As ListView
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpinjam As DateTimePicker
    Friend WithEvents txtgrandtotal As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_nis As TextBox
    Friend WithEvents txt_no As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbuku As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtpengarang As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtharga2 As TextBox
    Friend WithEvents txtjmlpinjam As TextBox
    Friend WithEvents txttotal As TextBox
End Class

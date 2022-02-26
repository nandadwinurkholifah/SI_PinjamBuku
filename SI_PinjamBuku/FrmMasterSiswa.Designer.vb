<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterSiswa
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnis = New System.Windows.Forms.TextBox()
        Me.txtnmsis = New System.Windows.Forms.TextBox()
        Me.cbjenkel = New System.Windows.Forms.ComboBox()
        Me.txtkelas = New System.Windows.Forms.TextBox()
        Me.txtalmt = New System.Windows.Forms.TextBox()
        Me.txttmpt = New System.Windows.Forms.TextBox()
        Me.txttlp = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Siswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tempat Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(116, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Lahir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(116, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "No. Telepon"
        '
        'txtnis
        '
        Me.txtnis.Location = New System.Drawing.Point(257, 32)
        Me.txtnis.Name = "txtnis"
        Me.txtnis.Size = New System.Drawing.Size(201, 20)
        Me.txtnis.TabIndex = 8
        '
        'txtnmsis
        '
        Me.txtnmsis.Location = New System.Drawing.Point(257, 78)
        Me.txtnmsis.Name = "txtnmsis"
        Me.txtnmsis.Size = New System.Drawing.Size(201, 20)
        Me.txtnmsis.TabIndex = 9
        '
        'cbjenkel
        '
        Me.cbjenkel.FormattingEnabled = True
        Me.cbjenkel.Items.AddRange(New Object() {"Perempuan", "Laki - laki"})
        Me.cbjenkel.Location = New System.Drawing.Point(258, 127)
        Me.cbjenkel.Name = "cbjenkel"
        Me.cbjenkel.Size = New System.Drawing.Size(200, 21)
        Me.cbjenkel.TabIndex = 10
        '
        'txtkelas
        '
        Me.txtkelas.Location = New System.Drawing.Point(258, 179)
        Me.txtkelas.Name = "txtkelas"
        Me.txtkelas.Size = New System.Drawing.Size(200, 20)
        Me.txtkelas.TabIndex = 11
        '
        'txtalmt
        '
        Me.txtalmt.Location = New System.Drawing.Point(258, 231)
        Me.txtalmt.Name = "txtalmt"
        Me.txtalmt.Size = New System.Drawing.Size(200, 20)
        Me.txtalmt.TabIndex = 12
        '
        'txttmpt
        '
        Me.txttmpt.Location = New System.Drawing.Point(257, 327)
        Me.txttmpt.Name = "txttmpt"
        Me.txttmpt.Size = New System.Drawing.Size(201, 20)
        Me.txttmpt.TabIndex = 14
        '
        'txttlp
        '
        Me.txttlp.Location = New System.Drawing.Point(258, 378)
        Me.txttlp.Name = "txttlp"
        Me.txttlp.Size = New System.Drawing.Size(200, 20)
        Me.txttlp.TabIndex = 15
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(135, 435)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 16
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(247, 435)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 23)
        Me.btn_ubah.TabIndex = 17
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(361, 435)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 18
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(135, 483)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 19
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(247, 483)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 20
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(361, 483)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 21
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'dtplahir
        '
        Me.dtplahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtplahir.Location = New System.Drawing.Point(258, 278)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(200, 20)
        Me.dtplahir.TabIndex = 22
        '
        'FrmMasterSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 534)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txttlp)
        Me.Controls.Add(Me.txttmpt)
        Me.Controls.Add(Me.txtalmt)
        Me.Controls.Add(Me.txtkelas)
        Me.Controls.Add(Me.cbjenkel)
        Me.Controls.Add(Me.txtnmsis)
        Me.Controls.Add(Me.txtnis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMasterSiswa"
        Me.Text = "FrmMasterSiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnis As TextBox
    Friend WithEvents txtnmsis As TextBox
    Friend WithEvents cbjenkel As ComboBox
    Friend WithEvents txtkelas As TextBox
    Friend WithEvents txtalmt As TextBox
    Friend WithEvents txttmpt As TextBox
    Friend WithEvents txttlp As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_cari As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents dtplahir As DateTimePicker
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiPinjamBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterSiswaToolStripMenuItem, Me.MasterBukuToolStripMenuItem, Me.TransaksiPinjamBukuToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterSiswaToolStripMenuItem
        '
        Me.MasterSiswaToolStripMenuItem.Name = "MasterSiswaToolStripMenuItem"
        Me.MasterSiswaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.MasterSiswaToolStripMenuItem.Text = "Siswa"
        '
        'MasterBukuToolStripMenuItem
        '
        Me.MasterBukuToolStripMenuItem.Name = "MasterBukuToolStripMenuItem"
        Me.MasterBukuToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MasterBukuToolStripMenuItem.Text = "Buku"
        '
        'TransaksiPinjamBukuToolStripMenuItem
        '
        Me.TransaksiPinjamBukuToolStripMenuItem.Name = "TransaksiPinjamBukuToolStripMenuItem"
        Me.TransaksiPinjamBukuToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.TransaksiPinjamBukuToolStripMenuItem.Text = "Transaksi Pinjam Buku"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterSiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiPinjamBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
End Class

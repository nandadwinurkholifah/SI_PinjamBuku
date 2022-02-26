Module ModulCetak
    Sub cetakLapBukuAll()
        Dim xMyReport As New RptMasterBuku
        Dim xTampung As New frmRptTemp
        xTampung.CrystalReportViewer1.ReportSource = xMyReport
        xTampung.CrystalReportViewer1.Refresh()
        xTampung.CrystalReportViewer1.ShowGroupTreeButton = False
        xTampung.CrystalReportViewer1.Zoom(100)
        xTampung.WindowState = FormWindowState.Maximized
        xTampung.ShowDialog()
    End Sub

    Sub cetakBuktiPinjam(ByVal xData As String)
        Dim xMyReport As New RptCetakBukti
        Dim filter As String
        filter = "{bukti_pinjam.no_bkt}= '" & xData & "'"

        Dim xTampung As New frmRptTemp
        xTampung.CrystalReportViewer1.ReportSource = xMyReport
        xTampung.CrystalReportViewer1.SelectionFormula = filter
        xTampung.CrystalReportViewer1.Refresh()
        xTampung.CrystalReportViewer1.ShowGroupTreeButton = False
        xTampung.CrystalReportViewer1.Zoom(100)
        xTampung.WindowState = FormWindowState.Maximized
        xTampung.ShowDialog()


    End Sub
End Module

Imports Microsoft.Reporting.WinForms
Public Class REP_TCXP_ACU

    Private Sub REP_TCXP_ACU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth
        Me.ReportViewer1.Refresh()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub CREAR_REPORTE(ByVal DES_MES As String, ByVal DES_CTA As String, ByVal COD_CTA As String, ByVal A�O0 As String, ByVal COD_MES2 As String, ByVal COD_PER As String)
        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("RUC", RUC_EMPRESA))
        parametros.Add(New ReportParameter("EMPRESA", DESC_EMPRESA))
        parametros.Add(New ReportParameter("DES_MES", DES_MES))
        parametros.Add(New ReportParameter("DES_CUENTA", DES_CTA))
        parametros.Add(New ReportParameter("COD_CUENTA", COD_CTA))
        parametros.Add(New ReportParameter("A�O0", A�O0))
        Me.ReportViewer1.LocalReport.SetParameters(parametros)
        Me.REPORTE_TCXP_KARDEX_ACUMULADOTableAdapter.Connection = con
        Me.REPORTE_TCXP_KARDEX_ACUMULADOTableAdapter.Fill(Me.DT_REP_ANA_CXP.REPORTE_TCXP_KARDEX_ACUMULADO, A�O0, COD_MES2, COD_CTA, COD_PER)
    End Sub


End Class
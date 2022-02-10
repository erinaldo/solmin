Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Imports RANSA.TYPEDEF.Mercaderia
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmSugerenciaUbicacion
    Private Sub frmSugerenciaUbicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.DisplayGroupTree = False

    End Sub
    Public Sub ShowFormSugerenciaPiking(ByVal owner As IWin32Window, ByVal CDPEPL_NroPedido As Int64)
        Try
            CrystalReportViewer1.ReportSource = Nothing
            Dim obeSugerenciaMercaderiaGuia As New beSugerenciaMercaderiaGuia()
            Dim oblUbicacionSugeridaMercaderiaGuia As New blUbicacionSugeridaMercaderiaGuia()
            Dim dt As New DataTable
            Dim orptSugerenciaPiking As New rptSugerenciaPiking()
            dt = oblUbicacionSugeridaMercaderiaGuia.ListarSugerenciaPiking(CDPEPL_NroPedido)
            Dim numReg As Int32 = dt.Rows.Count
            orptSugerenciaPiking.SetDataSource(dt)
            orptSugerenciaPiking.Refresh()
            orptSugerenciaPiking.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            orptSugerenciaPiking.SetParameterValue("pPedido", " Nº PEDIDO:" & CDPEPL_NroPedido)
            CrystalReportViewer1.ReportSource = orptSugerenciaPiking
            Me.ShowDialog(owner)
        Catch ex As Exception
        End Try
    End Sub
    'Public Sub ShowFormSugerenciaUbicacion(ByVal owner As IWin32Window, ByVal CCLNT_Cliente As Int64, ByVal NGUIRN_NroGuia As Int64)

    '    Try

    '        Dim orptUbicacionGuiaIngresoS As New rptUbicacionGuiaIngresoS()
    '        Dim obeSugerenciaMercaderiaGuia As New beSugerenciaMercaderiaGuia()
    '        Dim oblUbicacionSugeridaMercaderiaGuia As New blUbicacionSugeridaMercaderiaGuia()
    '        Dim dt As New DataTable
    '        obeSugerenciaMercaderiaGuia.CCLNT2 = CCLNT_Cliente
    '        obeSugerenciaMercaderiaGuia.NGUIRN = NGUIRN_NroGuia
    '        dt = oblUbicacionSugeridaMercaderiaGuia.ListarSugerenciaMercaderia(obeSugerenciaMercaderiaGuia)
    '        CrystalReportViewer1.ReportSource = Nothing
    '        orptUbicacionGuiaIngresoS.SetDataSource(dt)
    '        orptUbicacionGuiaIngresoS.Refresh()
    '        orptUbicacionGuiaIngresoS.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
    '        orptUbicacionGuiaIngresoS.SetParameterValue("pnumGuia", "GUÍA Nº:" & NGUIRN_NroGuia.ToString.Trim)
    '        CrystalReportViewer1.ReportSource = orptUbicacionGuiaIngresoS
    '        Me.ShowDialog(owner)
    '    Catch ex As Exception
    '    End Try

    'End Sub
End Class

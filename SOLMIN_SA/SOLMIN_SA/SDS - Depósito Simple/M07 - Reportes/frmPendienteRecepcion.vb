Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmPendienteRecepcion
    Public CCLNT As Int64 = 0
    Public TCMPCL As String = ""
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim dt As New DataTable()
            Dim oPrintForm As New PrintForm()
            Dim orptPendienteRecepcion As New rptPendienteRecepcion()
            Dim oblOrdenCompra As New blOrdenCompra()
            Dim obeOrdenCompra As New beOrdenCompra()
            '' obeOrdenCompra.pCCLNT_CodigoCliente = Me.CCLNT
            obeOrdenCompra.pCCLNT_CodigoCliente = 11232
            obeOrdenCompra.pFORCML_INI_FechaOCInicial = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
            obeOrdenCompra.pFORCML_FIN_FechaOCFin = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
            dt = oblOrdenCompra.ListaPendienteRecepcionOrdenCompra(obeOrdenCompra).Tables(0)
            CType(orptPendienteRecepcion.ReportDefinition.ReportObjects("txtFechaIni"), TextObject).Text = obeOrdenCompra.pFORCML_INI_FechaOCInicial
            CType(orptPendienteRecepcion.ReportDefinition.ReportObjects("txtFechaFin"), TextObject).Text = obeOrdenCompra.pFORCML_FIN_FechaOCFin
            CType(orptPendienteRecepcion.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = objSeguridadBN.pUsuario          

            orptPendienteRecepcion.SetDataSource(dt)
            oPrintForm.ShowForm(orptPendienteRecepcion, Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmPendienteRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCliente.Text = Me.TCMPCL
            txtCliente.Enabled = False
        Catch ex As Exception

        End Try
       
    End Sub
End Class

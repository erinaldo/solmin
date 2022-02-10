Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmPendienteOC
    Public CCLNT As Int64 = 0
    Public TCMPCL As String = ""
    Public pUsuario As String = ""
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
           
            Dim dt As New DataTable()
            Dim oPrintForm As New PrintFormOC
            Dim orptPendienteRecepcion As New rptPendienteRecepcion()
            Dim oblOrdenCompra As New blOrdenCompra()
            Dim obeOrdenCompra As New beOrdenCompra()
            obeOrdenCompra.pCCLNT_CodigoCliente = Me.CCLNT
            obeOrdenCompra.pFORCML_INI_FechaOCInicial = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
            obeOrdenCompra.pFORCML_FIN_FechaOCFin = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
            dt = oblOrdenCompra.ListaPendienteRecepcionOrdenCompra(obeOrdenCompra).Tables(0)
            CType(orptPendienteRecepcion.ReportDefinition.ReportObjects("txtFechaIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(obeOrdenCompra.pFORCML_INI_FechaOCInicial)
            CType(orptPendienteRecepcion.ReportDefinition.ReportObjects("txtFechaFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(obeOrdenCompra.pFORCML_FIN_FechaOCFin)
            CType(orptPendienteRecepcion.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = pUsuario
            orptPendienteRecepcion.SetDataSource(dt)
            oPrintForm.ShowForm(orptPendienteRecepcion, Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmPendienteRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (Me.CCLNT = 0) Then
                MessageBox.Show("Seleccione Cliente", "Filtro Impresión", MessageBoxButtons.OK)
                Me.Close()
            End If
            txtCliente.Text = Me.TCMPCL
            txtCliente.Enabled = False
        Catch ex As Exception
        End Try
    End Sub
End Class

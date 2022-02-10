Imports Ransa.NEGO
Imports Ransa.Utilitario
Imports Ransa.TYPEDEF
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmPendienteDespacho

    Public CCLNT As Int64 = 0
    Public TCMPCL As String = ""
    Public pUsuario As String = ""

    Private Sub frmPendienteDespacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCliente.Text = Me.TCMPCL
            txtCliente.Enabled = False
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try

            Dim dt As New DataTable()
            Dim oPrintForm As New PrintForm()
            Dim orptPedidoPendienteEntrega As New rptPedidoPendienteEntrega()
            Dim obrDespacho As New brDespacho()
            Dim obeDespacho As New beDespacho()

            obeDespacho.PNCCLNT = Me.CCLNT
            obeDespacho.PNFECHA_IN = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
            obeDespacho.PNFECHA_FIN = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
            dt = obrDespacho.ListaPedidoPendienteEntrega_x_Cliente(obeDespacho).Tables(0)
            CType(orptPedidoPendienteEntrega.ReportDefinition.ReportObjects("txtFechaIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(obeDespacho.PNFECHA_IN)
            CType(orptPedidoPendienteEntrega.ReportDefinition.ReportObjects("txtFechaFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(obeDespacho.PNFECHA_IN)
            CType(orptPedidoPendienteEntrega.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = pUsuario
            orptPedidoPendienteEntrega.SetDataSource(dt)
            oPrintForm.ShowForm(orptPedidoPendienteEntrega, Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class

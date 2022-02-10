Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO

Public Class frmAsignarSPE
    ReadOnly liquidarOperacion As New LiquidarOperacion_BL

    Private _operacion As New Operacion_BE
    Public Property Operacion() As Operacion_BE
        Get
            Return _operacion
        End Get
        Set(ByVal value As Operacion_BE)
            _operacion = value
        End Set
    End Property

    Private Sub frmAsignarSPE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvListaSPE.DataSource = liquidarOperacion.ListarPedidoEfectivo(Operacion)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dgvListaSPE.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro para continuar con la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If dgvListaSPE.CurrentRow.Cells("NRFSAP").Value.ToString() = String.Empty Or dgvListaSPE.CurrentRow.Cells("NRFSAP").Value.ToString() = "0" Then
            MessageBox.Show("El SPE no tiene Ref SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
            
        Dim liquidacionGastos As New LiquidacionGastos
        liquidacionGastos.CCMPN = Operacion.PSCCMPN
        liquidacionGastos.NLQGST = Operacion.NLQGST_C
        liquidacionGastos.NOPRCN = Operacion.NOPRCN_C
        liquidacionGastos.NCRRRT = Operacion.NCRRRT_C
        liquidacionGastos.TPSLPE = dgvListaSPE.CurrentRow.Cells("TPSLPE").Value
        liquidacionGastos.NMSLPE = dgvListaSPE.CurrentRow.Cells("NMSLPE").Value
        liquidacionGastos.CULUSA = MainModule.USUARIO
        liquidarOperacion.ActualizarRutaOperacionSolicitudPedido(liquidacionGastos)
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
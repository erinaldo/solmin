Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class LiquidarOperacion_BL
    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-INICIO
    ReadOnly liquidarOperacionDa As New LiquidarOperacion_DA

    Public Function ListarPedidoEfectivo(ByVal operacion As Operacion_BE) As DataTable
        Return liquidarOperacionDa.ListarPedidoEfectivo(operacion)
    End Function

    Public Function RegistrarGastoOperacionOrigenPedido(ByVal detalleGasto As DetalleGasto_BE) As Integer
        Return liquidarOperacionDa.RegistrarGastoOperacionOrigenPedido(detalleGasto)
    End Function

    Public Sub ActualizarRutaOperacionSolicitudPedido(ByVal liquidacionGastos As LiquidacionGastos)
        liquidarOperacionDa.ActualizarRutaOperacionSolicitudPedido(liquidacionGastos)
    End Sub

    Public Function ListarConceptoGastosEquivalenteSAP(ByVal psccmpn As String) As DataSet
        Return liquidarOperacionDa.ListarConceptoGastosEquivalenteSAP(psccmpn)
    End Function
    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-FIN
End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES

Public Class LiquidarOperacion_DA
    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-INICIO
    Private ReadOnly sqlManager As New SqlManager


    Public Function ListarPedidoEfectivo(ByVal operacion As Operacion_BE) As DataTable
        Dim dataTable As New DataTable
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", operacion.PSCCMPN)
        parameter.Add("PSCDVN", operacion.PSCDVN)
        parameter.Add("PNNOPRCN", operacion.PNNOPRCN)

        sqlManager.DefaultSchema = Autenticacion_DAL.GetLibrary(operacion.PSCCMPN)

        dataTable = sqlManager.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PED_EFECTIVOS_X_OPERACION", parameter)

        Return dataTable
    End Function

    Public Function RegistrarGastoOperacionOrigenPedido(ByVal detalleGasto As DetalleGasto_BE) As Integer
        Try
            Dim parameter As New Parameter

            parameter.Add("PONNLQGST", detalleGasto.PONNLQGST)
            parameter.Add("PNNOPRCN", detalleGasto.PNNOPRCN)
            parameter.Add("PNNCRRRT", detalleGasto.PNNCRRRT)
            parameter.Add("PNCGSTOS", detalleGasto.PNCGSTOS)
            parameter.Add("PNCDMNDA", detalleGasto.PNCDMNDA)
            parameter.Add("PNIGSTOS", detalleGasto.PNIGSTOS)
            parameter.Add("PSTOBDCT", detalleGasto.PSTOBDCT)
            parameter.Add("PSCULUSA", detalleGasto.PSCULUSA)
            parameter.Add("PSNTRMNL", detalleGasto.PSNTRMNL)
            parameter.Add("XPNNFECINI", detalleGasto.PNNFECINI)
            parameter.Add("PNNFECFIN", detalleGasto.PNNFECFIN)

            sqlManager.DefaultSchema = Autenticacion_DAL.GetLibrary(detalleGasto.PSCCMPN)

            sqlManager.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_GASTO_OPERACION_ORIGEN_PED_SAP", parameter)

            Return 0

        Catch ex As Exception
            Return 1
        End Try

    End Function

    Public Sub ActualizarRutaOperacionSolicitudPedido(ByVal liquidacionGastos As LiquidacionGastos)
        Dim parameter As New Parameter

        parameter.Add("PNNLQGST", liquidacionGastos.NLQGST)
        parameter.Add("PNNOPRCN", liquidacionGastos.NOPRCN)
        parameter.Add("PNNCRRRT", liquidacionGastos.NCRRRT)
        parameter.Add("PSTPSLPE", liquidacionGastos.TPSLPE)
        parameter.Add("PNNMSLPE", liquidacionGastos.NMSLPE)
        parameter.Add("PSCULUSA", liquidacionGastos.CULUSA)

        sqlManager.DefaultSchema = Autenticacion_DAL.GetLibrary(liquidacionGastos.CCMPN)

        sqlManager.ExecuteNoQuery("SP_SOLMIN_ST_ACTUALIZAR_RUTAOP_SOLPED", parameter)
    End Sub

    Public Function ListarConceptoGastosEquivalenteSAP(ByVal psccmpn As String) As DataSet
        Dim dataSet As New DataSet
        Dim parameter As New Parameter

        sqlManager.DefaultSchema = Autenticacion_DAL.GetLibrary(psccmpn)

        dataSet = sqlManager.ExecuteDataSet("SP_SOLMIN_ST_LISTA_CONCEPTOS_GASTOS_EQUIV_SAP", parameter)

        Return dataSet
    End Function
    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-FIN
End Class


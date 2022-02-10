Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsResumenMensualAlmacenes

    Private objSql As New SqlManager

    ''' <summary>
    ''' Lista de inventario de distintas plantas
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fodtInventarioSATResumenMensualAll(ByVal obeFiltro As ResumenMensualAlmacenes) As DataTable
        Dim objParametros As Parameter = New Parameter
        'Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", obeFiltro.PSCCMPN)
            .Add("PSCDVSN", obeFiltro.PSCDVSN)
            .Add("PNCCLNT", obeFiltro.PSCCLNT)
            .Add("PNFECFIN", obeFiltro.PNFECFIN)
        End With
        Try
            Return objSql.ExecuteDataTable("SP_SOLMIN_SAT_INVENTARIO_RESUMEN_MENSUAL_BULTO_ALL", objParametros)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    ''' <summary>
    '''  Listado del Stock de Productos a una determinada fecha
    ''' </summary>
    ''' <param name="obeFiltros"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fodtInventarioDSResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNCCLNT", obeFiltros.PSCCLNT)
            lobjParams.Add("PSCTPDP6", obeFiltros.PSCTPDP6)
            lobjParams.Add("PNFECINV", obeFiltros.PNFECINV)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SDS_INVENTARIO_RESUMEN_MENSUAL_POR_FECHA", lobjParams)
            Return dt
        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function

    Public Function fodtMovimientosIngSalDSResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("IN_CCLNT", obeFiltros.PSCCLNT)
            lobjParams.Add("IN_FMOVI", obeFiltros.PNFECINV)
            lobjParams.Add("IN_FMOVF", obeFiltros.PNFECFIN)
            lobjParams.Add("IN_CTPOAT", obeFiltros.PSCTPOAT)
            lobjParams.Add("IN_STPODP", obeFiltros.PSSTPODP)

            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SDS_MOV_RESUMEN_MENSUAL_POR_FECHA", lobjParams)
            Return dt
        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function


    Public Function fodtMovimientosIngSATResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("IN_CCLNT", obeFiltros.PSCCLNT)
            lobjParams.Add("IN_CCMPN", obeFiltros.PSCCMPN)
            lobjParams.Add("IN_CDVSN", obeFiltros.PSCDVSN)
            lobjParams.Add("IN_FECINI", obeFiltros.PNFECINV)
            lobjParams.Add("IN_FECFIN", obeFiltros.PNFECFIN)

            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SAT_REPORTE_INGRESO_RESUMEN_MENSUAL_POR_ALMACEN", lobjParams)
            Return dt
        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function
    Public Function fodtMovimientosSalidaSATResumenMensual(ByVal obeFiltros As ResumenMensualAlmacenes) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("IN_CCLNT", obeFiltros.PSCCLNT)
            lobjParams.Add("IN_CCMPN", obeFiltros.PSCCMPN)
            lobjParams.Add("IN_CDVSN", obeFiltros.PSCDVSN)
            lobjParams.Add("IN_FECINI", obeFiltros.PNFECINV)
            lobjParams.Add("IN_FECFIN", obeFiltros.PNFECFIN)

            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SAT_REPORTE_DESPACHO_RESUMEN_MENSUAL_POR_ALMACEN", lobjParams)
            Return dt
        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function

End Class

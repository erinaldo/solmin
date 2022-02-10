Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsServicioAtendido
    Public Function Lista_Servicio_Atendido(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Dim oDt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", poServiciosAtendidos.CCLNT)
        lobjParams.Add("PSCCMPN", poServiciosAtendidos.CCMPN)
        lobjParams.Add("PSCDVSN", poServiciosAtendidos.CDVSN)
        lobjParams.Add("PNCMNDA1", poServiciosAtendidos.CMNDA1)
        lobjParams.Add("PNCPLNDV", poServiciosAtendidos.CPLNDV)
        lobjParams.Add("PNFECINI", poServiciosAtendidos.FECINI)
        lobjParams.Add("PNFECFIN", poServiciosAtendidos.FECFIN)
        oDt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIOS_ATENDIDOS", lobjParams)
        Return oDt
    End Function

    Public Function Lista_ParaFaturacion(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Dim oDt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", poServiciosAtendidos.CCLNT)
        lobjParams.Add("PSCCMPN", poServiciosAtendidos.CCMPN)
        lobjParams.Add("PSCDVSN", poServiciosAtendidos.CDVSN)
        'lobjParams.Add("PNCMNDA1", poServiciosAtendidos.CMNDA1)
        'lobjParams.Add("PNCPLNDV", poServiciosAtendidos.CPLNDV)
        oDt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_FACTURACION_RZSC20", lobjParams)
        Return oDt
    End Function

    Public Sub ActualizarServicio_Atendido(ByVal poServiciosAtendidos As Servicio_Atendido)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNCCLNT", poServiciosAtendidos.CCLNT)
            lobjParams.Add("PNNOPRCN", poServiciosAtendidos.NOPRCN)
            lobjParams.Add("PNNRTFSV", poServiciosAtendidos.NRTFSNV)
            lobjParams.Add("PNNSECFC", poServiciosAtendidos.NSECFC)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))

            lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_SERVICIO_ATENDIDO_RZSC20", lobjParams)
            'lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_SERVICIO_ATENDIDO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub AnularFactura(ByVal poServiciosAtendidos As Servicio_Atendido)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSNSECFC", poServiciosAtendidos.NSECFC)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_FACTURA_RZSC20", lobjParams)
            'lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_FACTURA", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function DetalleFactura(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Dim oDt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjSql.TimeOutCommand = 1000000
        lobjParams.Add("PSNSECFC", poServiciosAtendidos.NSECFC)
        lobjParams.Add("PSCTPALJ", poServiciosAtendidos.PSCTPALJ)
        oDt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DETALLE_FACTURA_SA_RZSC20_1", lobjParams)

        Return oDt
    End Function

    Public Function ObtenerCodigoConsistencia() As DataTable
        Dim lobjSql As New SqlManager
        Try
            Return lobjSql.ExecuteDataTable("SP_SOLCT_OBTENER_CODIGO_CONSISTENCIA", Nothing)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Lista_Datos_Consistencia(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Dim oDt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNSECFC", poServiciosAtendidos.NSECFC)
        oDt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_CONSISTENCIA", lobjParams)
        Return oDt
    End Function
    Public Function Cargar_Operaciones(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Dim oDt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNSECFC", poServiciosAtendidos.NSECFC)
        lobjParams.Add("PSCODVAR", poServiciosAtendidos.CODVAR)

        oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACIONES_FACTURAR_Q01", lobjParams)
        Return oDt
    End Function
    Public Function Cargar_Servicios(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Dim oDt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", poServiciosAtendidos.CCLNT)
        lobjParams.Add("PNNOPRCN", poServiciosAtendidos.NOPRCN)
        oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_FACTURAR_Q01", lobjParams)
        Return oDt
    End Function
    Public Function Cargar_Bultos(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Dim oDt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", poServiciosAtendidos.CCLNT)
        lobjParams.Add("PNNOPRCN", poServiciosAtendidos.NOPRCN)
        oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_BULTOS_FACTURAR_Q01", lobjParams)
        Return oDt
    End Function
End Class

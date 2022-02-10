Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data


Public Class daIncidencia

    Dim objSql As New SqlManager

    Public Function Registrar_Incidencia(ByVal objLista As List(Of String)) As Boolean
        Dim lbool_resultado As Boolean = False
        Try

            Dim objParameter As New Parameter 
            objParameter.Add("PARAM_CCMPN", objLista(0))
            objParameter.Add("PARAM_CDVSN", objLista(1))
            objParameter.Add("PARAM_CCLNT", objLista(2))
            objParameter.Add("PARAM_AÑOEMI", objLista(3))
            objParameter.Add("PARAM_MESEMI", objLista(4))
            objParameter.Add("PARAM_DDEMI", objLista(5))
            objParameter.Add("PARAM_CTPOIN", objLista(6))
            objParameter.Add("PARAM_HRAEMI", objLista(7))
            objParameter.Add("PARAM_CTPALM", objLista(8))
            objParameter.Add("PARAM_CALMC", objLista(9))
            objParameter.Add("PARAM_CZNALM", objLista(10))
            objParameter.Add("PARAM_CPRVCL", objLista(11))
            objParameter.Add("PARAM_CPLCLP", objLista(12))
            objParameter.Add("PARAM_TIRALC", objLista(13))
            objParameter.Add("PARAM_PRSCNT", objLista(14))
            objParameter.Add("PARAM_TOBACT", objLista(15))
            objParameter.Add("PARAM_TOBAC1", objLista(16))
            objParameter.Add("PARAM_SESTRG", objLista(17))
            objParameter.Add("PARAM_CUSCRT", objLista(18))
            objParameter.Add("PARAM_FCHCRT", objLista(19))
            objParameter.Add("PARAM_HRACRT", objLista(20))
            objParameter.Add("PARAM_NTRMCR", objLista(21))
            objParameter.Add("PARAM_CULUSA", objLista(22))
            objParameter.Add("PARAM_FULTAC", objLista(23))
            objParameter.Add("PARAM_HULTAC", objLista(24))
            objParameter.Add("PARAM_NTRMNL", objLista(25))
            objParameter.Add("PARAM_ICSTOS", objLista(26))

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRA_INCIDENCIA", objParameter)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function Modificar_Incidencia(ByVal objLista As List(Of String)) As Boolean
        Dim lbool_resultado As Boolean = False
        Try

            Dim objParameter As New Parameter
            objParameter.Add("PARAM_CCMPN", objLista(0))
            objParameter.Add("PARAM_CDVSN", objLista(1))
            objParameter.Add("PARAM_CCLNT", objLista(2))
            objParameter.Add("PARAM_AÑOEMI", objLista(3))
            objParameter.Add("PARAM_MESEMI", objLista(4))
            objParameter.Add("PARAM_DDEMI", objLista(5))
            objParameter.Add("PARAM_CTPOIN", objLista(6))
            objParameter.Add("PARAM_HRAEMI", objLista(7))
            objParameter.Add("PARAM_CTPALM", objLista(8))
            objParameter.Add("PARAM_CALMC", objLista(9))
            objParameter.Add("PARAM_CZNALM", objLista(10))
            objParameter.Add("PARAM_CPRVCL", objLista(11))
            objParameter.Add("PARAM_CPLCLP", objLista(12))
            objParameter.Add("PARAM_TIRALC", objLista(13))
            objParameter.Add("PARAM_PRSCNT", objLista(14))
            objParameter.Add("PARAM_TOBACT", objLista(15))
            objParameter.Add("PARAM_TOBAC1", objLista(16))
            objParameter.Add("PARAM_ICSTOS", objLista(26))
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_MODIFICAR_INCIDENCIA", objParameter)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function Eliminar_Incidencia(ByVal objLista As List(Of String)) As Boolean
        Dim lbool_resultado As Boolean = False
        Try

            Dim objParameter As New Parameter
            objParameter.Add("PARAM_CCMPN", objLista(0))
            objParameter.Add("PARAM_CDVSN", objLista(1))
            objParameter.Add("PARAM_CCLNT", objLista(2))
            objParameter.Add("PARAM_AÑOEMI", objLista(3))
            objParameter.Add("PARAM_MESEMI", objLista(4))
            objParameter.Add("PARAM_DDEMI", objLista(5))
            objParameter.Add("PARAM_CTPOIN", objLista(6))
            objParameter.Add("PARAM_HRAEMI", objLista(7)) 
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ELIMINAR_INCIDENCIA", objParameter)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function Reporte_Incidencias(ByVal objParametros As List(Of String), ByVal Tipo As Integer) As DataTable
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_CCLNT", objParametros(0))
            objParam.Add("PARAM_ANIO", objParametros(1))
            objParam.Add("PARAM_MES", objParametros(2))
            If Tipo = 1 Then 'detallado
                objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_SA_REPORTE_INCIDENCIAS_ALMACEN", objParam)
            Else
                objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_SA_REPORTE_INCIDENCIA2", objParam)
            End If
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
        Return objDatatable
    End Function

    Public Function Listado_Incidencias(ByVal objParametros As List(Of String)) As DataTable
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_CCLNT", objParametros(0))
            objParam.Add("PARAM_ANIO", objParametros(1))
            objParam.Add("PARAM_MES", objParametros(2))
            objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_INCIDENCIAS_ALL", objParam)
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
        Return objDatatable
    End Function

End Class

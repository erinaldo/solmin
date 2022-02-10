Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsOrdenesInternas

    Public Function ObtieneSociedad(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjOrdenesInternas.PSCCMPN)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SOCIEDAD", lobjParams)

        Return dt
    End Function

    Public Function Lista_Ordenes_Internas(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCSCDSP", pobjOrdenesInternas.CSCDSP)
        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)

        lobjParams.Add("INI_ORDEN", pobjOrdenesInternas.INI_ORDEN)
        lobjParams.Add("FIN_ORDEN", pobjOrdenesInternas.FIN_ORDEN)

        lobjParams.Add("PAGESIZE", pobjOrdenesInternas.PageSize)
        lobjParams.Add("PAGENUMBER", pobjOrdenesInternas.PageNumber)
        lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA", lobjParams)
        dt.Columns.Add("PageCount")

        If dt.Rows.Count > 0 Then
            dt.Rows(0).Item("PageCount") = lobjSql.ParameterCollection("PAGECOUNT")
        End If

        Return dt
    End Function

    Public Function Lista_Ordenes_Internas_RSAP22(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCSCDSP", pobjOrdenesInternas.CSCDSP)
        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)

        lobjParams.Add("INI_ORDEN", pobjOrdenesInternas.INI_ORDEN)
        lobjParams.Add("FIN_ORDEN", pobjOrdenesInternas.FIN_ORDEN)

        lobjParams.Add("INI_FECHA", pobjOrdenesInternas.INI_FECHA)
        lobjParams.Add("FIN_FECHA", pobjOrdenesInternas.FIN_FECHA)

        lobjParams.Add("PAGESIZE", pobjOrdenesInternas.PageSize)
        lobjParams.Add("PAGENUMBER", pobjOrdenesInternas.PageNumber)
        lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_RSAP22", lobjParams)
        dt.Columns.Add("PageCount")

        If dt.Rows.Count > 0 Then
            dt.Rows(0).Item("PageCount") = lobjSql.ParameterCollection("PAGECOUNT")
        End If

        Return dt
    End Function
    Public Function Lista_Ordenes_Internas_Detalle(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)
        lobjParams.Add("PSNORDIN", pobjOrdenesInternas.NORDIN)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_DETALLE", lobjParams)

        Return dt
    End Function

    Public Function Lista_Ordenes_Internas_Resumen(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCSCDSP", pobjOrdenesInternas.CSCDSP)
        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)
        lobjParams.Add("INI_ORDEN", pobjOrdenesInternas.INI_ORDEN)
        lobjParams.Add("FIN_ORDEN", pobjOrdenesInternas.FIN_ORDEN)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_RESUMEN", lobjParams)

        Return dt
    End Function

    Public Function Lista_Ordenes_Internas_Resumen_RSAP22(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCSCDSP", pobjOrdenesInternas.CSCDSP)
        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)
        lobjParams.Add("INI_ORDEN", pobjOrdenesInternas.INI_ORDEN)
        lobjParams.Add("FIN_ORDEN", pobjOrdenesInternas.FIN_ORDEN)
        lobjParams.Add("INI_FECHA", pobjOrdenesInternas.INI_FECHA)
        lobjParams.Add("FIN_FECHA", pobjOrdenesInternas.FIN_FECHA)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_RESUMEN_RSAP22", lobjParams)

        Return dt
    End Function

    Public Function Lista_Ordenes_Internas_Reporte(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCSCDSP", pobjOrdenesInternas.CSCDSP)
        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)
        lobjParams.Add("INI_ORDEN", pobjOrdenesInternas.INI_ORDEN)
        lobjParams.Add("FIN_ORDEN", pobjOrdenesInternas.FIN_ORDEN)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_REPORTE", lobjParams)

        Return dt
    End Function
    Public Function Lista_Ordenes_Internas_Reporte_V2(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCSCDSP", pobjOrdenesInternas.CSCDSP)
        lobjParams.Add("PSCCLORI", pobjOrdenesInternas.CCLORI)
        lobjParams.Add("INI_ORDEN", pobjOrdenesInternas.INI_ORDEN)
        lobjParams.Add("FIN_ORDEN", pobjOrdenesInternas.FIN_ORDEN)
        lobjParams.Add("INI_FECHA", pobjOrdenesInternas.INI_FECHA)
        lobjParams.Add("FIN_FECHA", pobjOrdenesInternas.FIN_FECHA)


        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_REPORTE_V2", lobjParams)
        Return dt
    End Function
    Public Sub Actualiza_SAP_OrdenInterna(ByVal pobjOrdenesInternas As OrdenesInternas)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PARAM_CSCDSP", pobjOrdenesInternas.CSCDSP)
            lobjParams.Add("PARAM_CCLORI", pobjOrdenesInternas.CCLORI)
            lobjParams.Add("PARAM_NRNINS", pobjOrdenesInternas.NRNINS)
            lobjParams.Add("PARAM_NULCTR", pobjOrdenesInternas.NULCTR)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_RSAP018", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualiza_SAP_OrdenInterna_RSAP22(ByVal pobjOrdenesInternas As OrdenesInternas)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PARAM_CCLORI", pobjOrdenesInternas.CCLORI)

            lobjParams.Add("PARAM_NORSAI", pobjOrdenesInternas.INI_ORDEN)
            lobjParams.Add("PARAM_NORSAF", pobjOrdenesInternas.FIN_ORDEN)

            lobjParams.Add("PARAM_FECINI", pobjOrdenesInternas.INI_FECHA)
            lobjParams.Add("PARAM_FECFIN", pobjOrdenesInternas.FIN_FECHA)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_BORRAR_OI_PENDIENTES_RSAP22", lobjParams)
            'lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP020C", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class

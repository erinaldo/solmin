Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Public Class clsOrdenInternaControl
    'Public Function ObtieneSociedad(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PSCCMPN", pobjOrdenesInternas.CCMPN)

    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SOCIEDAD", lobjParams)

    '    Return dt
    'End Function

    Public Function Lista_OI_Control(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjOIControl.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjOIControl.PSCDVSN)
            lobjParams.Add("PSCPLNDV", pobjOIControl.PNCPLNDV)
            lobjParams.Add("PSSESTOP", pobjOIControl.SESTOP)
            lobjParams.Add("PSNOPRCN", pobjOIControl.NOPRCN)
            lobjParams.Add("PSFDCPRF1", pobjOIControl.F_INICIO)
            lobjParams.Add("PSFDCPRF2", pobjOIControl.F_FINAL)

            lobjParams.Add("PAGESIZE", pobjOIControl.PageSize)
            lobjParams.Add("PAGENUMBER", pobjOIControl.PageNumber)
            lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_CONTROL", lobjParams)

            dt.Columns.Add("PageCount")

            If dt.Rows.Count > 0 Then
                pobjOIControl.PageCount = lobjSql.ParameterCollection("PAGECOUNT")
            Else
                pobjOIControl.PageCount = 0
            End If

            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Lista_OI_Control_Reporte(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjOIControl.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjOIControl.PSCDVSN)
            lobjParams.Add("PSCPLNDV", pobjOIControl.PNCPLNDV)
            lobjParams.Add("PSSESTOP", pobjOIControl.SESTOP)
            lobjParams.Add("PSNOPRCN", pobjOIControl.NOPRCN)
            lobjParams.Add("PSFDCPRF1", pobjOIControl.F_INICIO)
            lobjParams.Add("PSFDCPRF2", pobjOIControl.F_FINAL)

            'lobjParams.Add("PAGESIZE", pobjOIControl.PageSize)
            'lobjParams.Add("PAGENUMBER", pobjOIControl.PageNumber)
            'lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_CONTROL_EXP_EXCEL", lobjParams)

            dt.Columns.Add("PageCount")

            If dt.Rows.Count > 0 Then
                pobjOIControl.PageCount = lobjSql.ParameterCollection("PAGECOUNT")
            Else
                pobjOIControl.PageCount = 0
            End If

            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function Lista_OI_Control_Resumen(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjOIControl.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjOIControl.PSCDVSN)
        lobjParams.Add("PSCPLNDV", pobjOIControl.PNCPLNDV)
        lobjParams.Add("FE_INI", pobjOIControl.F_INICIO)
        lobjParams.Add("FE_FIN", pobjOIControl.F_FINAL)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_CONTROL_RESUMEN", lobjParams)

        Return dt
    End Function

    Public Function Lista_OI_Control_Cierre(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjOIControl.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjOIControl.PSCDVSN)
        lobjParams.Add("PSCPLNDV", pobjOIControl.PNCPLNDV)
        lobjParams.Add("FE_INI", pobjOIControl.F_INICIO)
        lobjParams.Add("FE_FIN", pobjOIControl.F_FINAL)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_CONTROL_CIERRE", lobjParams)

        Return dt
    End Function

    Public Function Lista_OI_Control_Detalles(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjOIControl.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjOIControl.PSCDVSN)
        lobjParams.Add("PSCPLNDV", pobjOIControl.PNCPLNDV)
        lobjParams.Add("FE_INI", pobjOIControl.F_INICIO)
        lobjParams.Add("FE_FIN", pobjOIControl.F_FINAL)
        lobjParams.Add("PSESTADO", pobjOIControl.ESTADO_DETALLE)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_CONTROL_DETALLES", lobjParams)
        Return dt
    End Function
    '---Todos menos los liberados---
    Public Function Lista_OI_Control_Detalles_2(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjOIControl.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjOIControl.PSCDVSN)
        lobjParams.Add("PSCPLNDV", pobjOIControl.PNCPLNDV)
        lobjParams.Add("FE_INI", pobjOIControl.F_INICIO)
        lobjParams.Add("FE_FIN", pobjOIControl.F_FINAL)
        lobjParams.Add("PSESTADO", pobjOIControl.ESTADO_DETALLE)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_CONTROL_DETALLES_2", lobjParams)
        Return dt
    End Function

    Public Sub Cierre_OI_CL_SAP119A(ByVal pobjOIControl As OrdenInternaControl)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PARAM_CCLORI", pobjOIControl.CCLORI)
            lobjParams.Add("PARAM_NORDIN", pobjOIControl.NORDIN)
            lobjParams.Add("PARAM_SACORI", pobjOIControl.SACORI)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP119A", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub Anulacion_OI_CL_SAP119B(ByVal pobjOIControl As OrdenInternaControl)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PARAM_CCLORI", pobjOIControl.CCLORI)
            lobjParams.Add("PARAM_NORDIN", pobjOIControl.NORDIN)
            lobjParams.Add("PARAM_SACORI", pobjOIControl.SACORI)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP119B", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#Region "CONTROL OI V2"
    Public Function Lista_OI_Control_V2(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjOIControl.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjOIControl.PSCDVSN)
            lobjParams.Add("PSCPLNDV", pobjOIControl.PNCPLNDV)
            lobjParams.Add("PSSESTOP", pobjOIControl.SESTOP)
            lobjParams.Add("PSNOPRCN", pobjOIControl.NOPRCN)
            lobjParams.Add("PSFDCPRF1", pobjOIControl.F_INICIO)
            lobjParams.Add("PSFDCPRF2", pobjOIControl.F_FINAL)
            'lobjParams.Add("PAGESIZE", pobjOIControl.PageSize)
            'lobjParams.Add("PAGENUMBER", pobjOIControl.PageNumber)
            'lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_ORDEN_INTERNA_CONTROL_V2", lobjParams)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.Utilitario

Public Class daRecepcionInterfaceSap


    Inherits daBase(Of beRecepcionInterfaceSap)
    Dim objSqlManager As New SqlManager



    Public Function ObtenerRegistroVentaCliente(ByVal obeRecepcionSap As beRecepcionInterfaceSap) As DataTable
        Dim objParam As New Parameter
        Dim oDt As New DataTable()
        Try
            With objParam
                .Add("PSCCLNT", obeRecepcionSap.CCMPN)
                .Add("PSCRTLTE", obeRecepcionSap.CCLNT)
            End With
            oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_REG_VENTA_CLIENTE", objParam)
        Catch ex As Exception
            oDt = Nothing
        End Try
        Return oDt
    End Function
 

    Public Function ObtenerDocInterfazSapRecepcion(ByRef objEntidad As beRecepcionInterfaceSap) As DataSet
        Dim oDs As New DataSet
        Try
            Dim objSql As New SqlManager()
            Dim objParam As New Parameter

            objParam.Add("IN_CCMPN", objEntidad.CCMPN)
            objParam.Add("IN_CRGVTA", objEntidad.CRGVTA)
            objParam.Add("IN_CCLNT", objEntidad.CCLNT)
            objParam.Add("IN_DCENSA", objEntidad.DCENSA)
            objParam.Add("IN_USUARI", objEntidad.USUARIO)
            objParam.Add("OU_ERROR", objEntidad.ERRORS, ParameterDirection.Output)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_OBTENER_DOC_INTERFAZ_SAP_RECEPCION", objParam)
            objEntidad.ERRORS = objSql.ParameterCollection("OU_ERROR")
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs

 
    End Function




#Region ""

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beRecepcionInterfaceSap)

    End Sub

#End Region


End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daPlanta
    Private objSql As New SqlManager
    Public Function Obtener_Planta_Cliente_Tercero(ByVal PNCPRVCL_CodigoClienteTercero As Int64) As DataTable
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCPRVCL", PNCPRVCL_CodigoClienteTercero)
            oDs = objSql.ExecuteDataSet("SP_SA_SOLMIN_LISTA_PLANTA_CLIENTE_TERCERO", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs.Tables(0)
    End Function
    Public Function Obtener_Planta_Cliente_Propio(ByVal CCLNT_CodigoCliente As Int64) As DataTable
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCPLNFC", CCLNT_CodigoCliente)
            oDs = objSql.ExecuteDataSet("SP_SA_SOLMIN_LISTA_PLANTA_CLIENTE_PROPIO", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs.Tables(0)
    End Function
End Class

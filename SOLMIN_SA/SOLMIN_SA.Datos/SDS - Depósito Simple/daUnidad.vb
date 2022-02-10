Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daUnidad
    Private objSql As New SqlManager
    Public Function Obtener_Unidad_Medida_x_Mercaderia_Relacionada(ByVal IN_CMRCLR_CodigoMercaderiaRelacionada As String) As DataTable
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_NORDSR", IN_CMRCLR_CodigoMercaderiaRelacionada)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_OBTENER_UNIDAD_DE_MEDIDA_X_MERCADERIA_RELACIONADA", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs.Tables(0)
    End Function
    Public Function Obtener_Obtener_UnidadMedida_x_Descripcion(ByVal TCMPUN_DescripcionUnidad As String) As DataTable
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_TCMPUN", TCMPUN_DescripcionUnidad)
            oDs = objSql.ExecuteDataSet("SP_SA_LISTAR_UNIDAD_MEDIDA_RZZM03", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs.Tables(0)
    End Function

End Class

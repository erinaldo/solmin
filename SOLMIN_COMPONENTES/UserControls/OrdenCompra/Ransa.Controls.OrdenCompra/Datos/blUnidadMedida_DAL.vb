Imports Ransa.TypeDef
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class blUnidadMedida_DAL
    Private objSql As New SqlManager
    Public Function Obtener_Obtener_UnidadMedida_x_Descripcion(ByVal TCMPUN_DescripcionUnidad As String) As DataTable
        Dim oDs As New DataSet
        Dim objParam As New Parameter

        objParam.Add("IN_TCMPUN", TCMPUN_DescripcionUnidad)
        oDs = objSql.ExecuteDataSet("SP_SA_LISTAR_UNIDAD_MEDIDA_RZZM03", objParam)
       
        Return oDs.Tables(0)
    End Function
End Class

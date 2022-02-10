Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class UnidadProductiva_DAL
    Private objSql As New SqlManager
    Public Function Listar_Unidad_Productiva() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UNIDADES_PRODUCTIVAS_FILTRO", objParam)
        Return dt

    End Function
End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario

Public Class clsLocalidad
    Public Function Listar_Localidades() As List(Of beLocalidad)
        Dim dt As DataTable
        Dim oListLocalidad As New List(Of beLocalidad)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeLocalidad As beLocalidad

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_LOCALIDADES", Nothing)

        For Each dr As DataRow In dt.Rows
            obeLocalidad = New beLocalidad
            obeLocalidad.CLCLD = dr("CLCLD")
            obeLocalidad.TCMLCL = dr("TCMLCL").ToString.Trim
            oListLocalidad.Add(obeLocalidad)
        Next
        Return oListLocalidad
    End Function
End Class

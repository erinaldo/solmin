Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades.mantenimientos

Public Class clsUM
    Public Function Lista_UM() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_UM", Nothing)
        Return dt
    End Function

    Public Function Listar_UnidadMedida() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeUM As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_UM", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CUNDMD = objDataRow("CUNDMD").ToString.Trim()
            objEntidad.TCMPUN = objDataRow("TCMPUN").ToString.Trim()
            lbeUM.Add(objEntidad)
        Next

        Return lbeUM
    End Function
End Class

Imports Db2Manager.RansaData.iSeries.DataObjects



Public Class CentroCosto_DAL
    Private objSql As New SqlManager

    Public Function Listar_Centro_Costo(ByVal objEntidad As CentroCosto) As List(Of CentroCosto)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of CentroCosto)
        Dim objParam As New Parameter

        Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CENTRO_COSTO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New CentroCosto
                objDatos.CCNTCS = objDataRow("CCNTCS").ToString.Trim
                objDatos.TCNTCS = objDataRow("TCNTCS").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function


    Public Function Listar_RegionVenta(ByVal objEntidad As CentroCosto) As List(Of CentroCosto)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of CentroCosto)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLST_LISTA_REGION_VENTA", objParam)
            Dim intPk As Integer = 0
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New CentroCosto
                objDatos.IDCORRELATIVO = intPk
                objDatos.CRGVTA = objDataRow("CRGVTA").ToString.Trim
                objDatos.TCRVTA = objDataRow("TCRVTA").ToString.Trim
                objGenericCollection.Add(objDatos)
                intPk = intPk + 1
            Next


        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function
End Class


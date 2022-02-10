Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES

Public Class CategoriaChofer_DAL
    Private objSql As New SqlManager

    Public Function Listar_Categoria_Chofer() As List(Of CategoriaChofer)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of CategoriaChofer)
        Dim objEntidad As CategoriaChofer

        Try
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CATEGORIA_CHOFER", Nothing)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad = New CategoriaChofer
                objEntidad.SCATEG = objDataRow("SCATEG").ToString.Trim
                objEntidad.TCATEG = objDataRow("TCATEG").ToString.Trim
                objGenericCollection.Add(objEntidad)
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return objGenericCollection
    End Function
End Class

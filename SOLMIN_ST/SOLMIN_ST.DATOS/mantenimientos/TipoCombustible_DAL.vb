Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos


Namespace mantenimientos
  Public Class TipoCombustible_DAL
    Private objSql As New SqlManager

    Public Function Listar_TipoCombustible() As List(Of TipoCombustible)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TipoCombustible)
      Dim objDatos As TipoCombustible

            'Try
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_COMBUSTIBLE", Nothing)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New TipoCombustible
                objDatos.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                objDatos.TDSCMB = objDataRow("TDSCMB").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next

            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_TipoCombustible2() As DataTable
            Dim objDataTable As New DataTable


            'Try
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_COMBUSTIBLE", Nothing)

            'Procesandolos como una Lista


            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

  End Class
End Namespace


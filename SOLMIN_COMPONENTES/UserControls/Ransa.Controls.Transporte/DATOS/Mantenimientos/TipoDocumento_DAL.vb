Imports Db2Manager.RansaData.iSeries.DataObjects


Namespace mantenimientos

  Public Class TipoDocumento_DAL
    Private objSql As New SqlManager

    Public Function Listar_Tipo_Documento(ByVal objEntidad As TipoDocumento) As List(Of TipoDocumento)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TipoDocumento)
      Dim objParam As New Parameter

      Try
        'Obteniendo resultados
        objParam.Add("PNOPCION", objEntidad.CTPODC)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DOCUMENTOS", objParam)

        'Procesandolos como una Lista
        For Each objDataRow As DataRow In objDataTable.Rows
          Dim objDatos As New TipoDocumento
          objDatos.CTPODC = objDataRow("CTPODC")
          objDatos.TCMTPD = objDataRow("TCMTPD").ToString.Trim
          objGenericCollection.Add(objDatos)
        Next

      Catch ex As Exception
        objGenericCollection = New List(Of TipoDocumento)
      End Try
      Return objGenericCollection
        End Function
        Public Function Listar_Tipo_Documentos_Para_Refacturar(ByVal objEntidad As TipoDocumento) As DataTable
            Dim dtTipoDocumento As New DataTable
            Try
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                dtTipoDocumento = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DOCUMENTO_REFACTURAR", Nothing)
            Catch ex As Exception
            End Try
            Return dtTipoDocumento
        End Function
  End Class
End Namespace


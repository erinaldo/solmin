Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Juan De Dios
'** Fecha de Creación: 09/09/2009 
'** Descripción: capa de acceso a datos .
'****************************************************************************************************
Namespace mantenimientos
  Public Class TipoRecord_DAL
    Private objSql As New SqlManager 

        Public Function Listar_Tipo_Record(ByVal objEntidad As TipoRecord) As List(Of TipoRecord)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TipoRecord)
            'Try

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_RECORD", Nothing)
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New TipoRecord

                objDatos.STPRCD = objDataRow("STPRCD")
                objDatos.TTPRCD = objDataRow("TTPRCD")
                objDatos.FCHCRT = objDataRow("FCHCRT")
                objDatos.HRACRT = objDataRow("HRACRT")

                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function
  End Class
End Namespace
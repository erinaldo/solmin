'*********************************************************************'
'** Autor: Juan De Dios Leon                                        **'
'** Fecha de Creación: 09/09/2009                                   **'
'** Descripción: CAPA DE ACCESO A DATOS.                            **'
'*********************************************************************'
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Namespace mantenimientos

  Public Class TipoPaseConductor_DAL
    Private objSql As New SqlManager

    Public Function Registrar_Tipo_Pase(ByVal objEntidad As TipoPaseConductor) As TipoPaseConductor
            'Try
            Dim objParam As New Parameter

            objParam.Add("PON_NCOPSE", objEntidad.NCOPSE, ParameterDirection.Output)
            objParam.Add("PSNOMPSE", objEntidad.NOMPSE)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_TIPO_PASE", objParam)
            objEntidad.NCOPSE = objSql.ParameterCollection("PON_NCOPSE")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    objEntidad.NCOPSE = 0
            'End Try
            Return objEntidad
    End Function

    Public Function Modificar_Tipo_Pase(ByVal objEntidad As TipoPaseConductor) As TipoPaseConductor
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNCOPSE", objEntidad.NCOPSE)
            objParam.Add("PSNOMPSE", objEntidad.NOMPSE)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TIPO_PASE", objParam)
            'Catch ex As Exception
            '    objEntidad.NCOPSE = 0
            'End Try
            Return objEntidad
    End Function

    Public Function Eliminar_Tipo_Pase(ByVal objEntidad As TipoPaseConductor) As TipoPaseConductor
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNCOPSE", objEntidad.NCOPSE)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TIPO_PASE", objParam)
            'Catch ex As Exception
            '    objEntidad.NCOPSE = 0
            'End Try
            Return objEntidad
    End Function

    Public Function Listar_Tipo_Pase(ByVal objEntidad As TipoPaseConductor) As List(Of TipoPaseConductor)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TipoPaseConductor)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSNOMPSE", objEntidad.NOMPSE)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_PASE", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TipoPaseConductor

                objDatos.NCOPSE = objDataRow("NCOPSE").ToString.Trim
                objDatos.NOMPSE = objDataRow("NOMPSE").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function
  End Class
End Namespace
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Namespace mantenimientos
    Public Class TipoCapacitacionConductor_DAL
        Private objSql As New SqlManager

        Public Function Registrar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor) As TipoCapacitacionConductor
            'Try
            Dim objParam As New Parameter
            objParam.Add("PONNCOCPT", 0, ParameterDirection.Output)
            objParam.Add("PSNOMCPT", objEntidad.NOMCPT)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_TIPO_CAPACITACION_CONDUCTOR", objParam)
            objEntidad.NCOCPT = objSql.ParameterCollection("PONNCOCPT")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    objEntidad.NCOCPT = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Modificar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor) As TipoCapacitacionConductor
            'Try
            Dim objParam As New Parameter
            objParam.Add("POSNCOCPT", objEntidad.NCOCPT, ParameterDirection.Output)
            objParam.Add("PSNOMCPT", objEntidad.NOMCPT)
            objParam.Add("PSTOBS", objEntidad.TOBS)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TIPO_CAPACITACION_CONDUCTOR", objParam)
            'Catch ex As Exception
            '    objEntidad.NCOCPT = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor)
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNCOCPT", objEntidad.NCOCPT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TIPO_CAPACITACION_CONDUCTOR", objParam)
            'Catch ex As Exception
            '    objEntidad.NCOCPT = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Listar_TipoCapacitacionConductor(ByVal objEntidad As TipoCapacitacionConductor) As List(Of TipoCapacitacionConductor)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TipoCapacitacionConductor)
            Dim objParam As New Parameter

            'Try
            'Obteniendo(resultados)
            objParam.Add("PSNOMCPT", objEntidad.NOMCPT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_CAPACITACION_CONDUCTOR", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New TipoCapacitacionConductor

                objDatos.NCOCPT = objDataRow("NCOCPT").ToString.Trim
                objDatos.NOMCPT = objDataRow("NOMCPT").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function
    End Class
End Namespace

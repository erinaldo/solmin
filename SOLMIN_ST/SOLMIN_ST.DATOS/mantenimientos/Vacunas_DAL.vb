Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 15/07/2009 
'** Descripción: capa de acceso a datos Vacunas.
'****************************************************************************************************
Namespace mantenimientos

    Public Class Vacunas_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Vacunas(ByVal objEntidad As Vacunas) As Vacunas
            Try
                Dim objParam As New Parameter

                objParam.Add("PON_NCOVAC", objEntidad.NCOVAC, ParameterDirection.Output)
                objParam.Add("PSNOMVAC", objEntidad.NOMVAC)
                objParam.Add("PSTOBS", objEntidad.TOBS)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_VACUNAS", objParam)

                objEntidad.NCOVAC = objSql.ParameterCollection("PON_NCOVAC")

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.NCOVAC = 0
            End Try

            Return objEntidad
        End Function

        Public Function Modificar_Vacunas(ByVal objEntidad As Vacunas) As Vacunas
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNCOVAC", objEntidad.NCOVAC)
                objParam.Add("PSNOMVAC", objEntidad.NOMVAC)
                objParam.Add("PSTOBS", objEntidad.TOBS)
                objParam.Add("PSCULUSA ", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_VACUNAS", objParam)

            Catch ex As Exception
                objEntidad.NCOVAC = 0
            End Try

            Return objEntidad
        End Function

        Public Function Listar_Vacunas(ByVal objEntidad As Vacunas) As List(Of Vacunas)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Vacunas)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSNOMVAC", objEntidad.NOMVAC)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VACUNAS", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New Vacunas

                objDatos.NCOVAC = objDataRow("NCOVAC").ToString.Trim
                objDatos.NOMVAC = objDataRow("NOMVAC").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Eliminar_Vacunas(ByVal objEntidad As Vacunas) As Vacunas
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNCOVAC", objEntidad.NCOVAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_VACUNAS", objParam)

            Catch ex As Exception
                objEntidad.NCOVAC = 0
            End Try

            Return objEntidad
        End Function

    End Class

End Namespace
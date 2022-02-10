Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 15/07/2009 
'** Descripción: capa de acceso a datos TipoLicenciaConducir.
'****************************************************************************************************
Namespace mantenimientos

    Public Class TipoLicenciaConducir_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir) As TipoLicenciaConducir
            Try
                Dim objParam As New Parameter

                objParam.Add("PON_NCLICO", objEntidad.NCLICO, ParameterDirection.Output)
                objParam.Add("PSCCATLI", objEntidad.CCATLI)
                objParam.Add("PSTCATLI", objEntidad.TCATLI)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_TIPO_LICENCIA_CONDUCIR", objParam)

                objEntidad.NCLICO = objSql.ParameterCollection("PON_NCLICO")

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.NCLICO = 0
            End Try

            Return objEntidad
        End Function

        Public Function Modificar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir) As TipoLicenciaConducir
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNCLICO", objEntidad.NCLICO)
                objParam.Add("PSCCATLI", objEntidad.CCATLI)
                objParam.Add("PSTCATLI", objEntidad.TCATLI)
                objParam.Add("PSCULUSA ", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TIPO_LICENCIA_CONDUCIR", objParam)

            Catch ex As Exception
                objEntidad.NCLICO = 0
            End Try

            Return objEntidad
        End Function

        Public Function Listar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir) As List(Of TipoLicenciaConducir)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TipoLicenciaConducir)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSCCATLI", objEntidad.CCATLI)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_LICENCIA_CONDUCIR", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New TipoLicenciaConducir

                objDatos.NCLICO = objDataRow("NCLICO").ToString.Trim
                objDatos.CCATLI = objDataRow("CCATLI").ToString.Trim
                objDatos.TCATLI = objDataRow("TCATLI").ToString.Trim
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

        Public Function Eliminar_Tipo_Licencia_Conducir(ByVal objEntidad As TipoLicenciaConducir)
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNCLICO", objEntidad.NCLICO)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TIPO_LICENCIA_CONDUCIR", objParam)

            Catch ex As Exception
                objEntidad.NCLICO = 0
            End Try

            Return objEntidad
        End Function

    End Class

End Namespace


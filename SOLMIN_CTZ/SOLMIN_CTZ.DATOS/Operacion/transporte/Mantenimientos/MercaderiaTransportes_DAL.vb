Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.ENTIDADES.Mantenimientos
Namespace mantenimientos
    Public Class MercaderiaTransportes_DAL
        Private objSql As New SqlManager
        Public Function Registrar_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As MercaderiaTransportes

            Try
                Dim objParam As New Parameter


                objParam.Add("PTCMRCD", objEntidad.TCMRCD)
                objParam.Add("PTAMRCD", objEntidad.TAMRCD)

                objParam.Add("PCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PHRACRT", objEntidad.HRACRT)
                objParam.Add("PNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PCGRMRC", objEntidad.CGRMRC)
                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_MERCADERIATRANSPORTES", objParam)
            Catch ex As Exception

            End Try
            Return objEntidad
        End Function

        Public Function Modificar_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As MercaderiaTransportes

            Try
                Dim objParam As New Parameter
                objParam.Add("PCMRCDR", objEntidad.CMRCDR)
                objParam.Add("PTCMRCD", objEntidad.TCMRCD)
                objParam.Add("PTAMRCD", objEntidad.TAMRCD)

                objParam.Add("PCULUSA", objEntidad.CULUSA)
                objParam.Add("PFULTAC", objEntidad.FULTAC)
                objParam.Add("PHULTAC", objEntidad.HULTAC)
                objParam.Add("PNTRMNL", objEntidad.NTRMNL)
                objParam.Add("PCGRMRC", objEntidad.CGRMRC)


                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_MERCADERIATRANSPORTES", objParam)

            Catch ex As Exception

            End Try
            Return objEntidad
        End Function

        Public Function Cambiar_Estado_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes)

            Try
                Dim objParam As New Parameter
                objParam.Add("PCMRCDR", objEntidad.CMRCDR)

                objParam.Add("PCULUSA", objEntidad.CULUSA)
                objParam.Add("PFULTAC", objEntidad.FULTAC)
                objParam.Add("PHULTAC", objEntidad.HULTAC)
                objParam.Add("PNTRMNL", objEntidad.NTRMNL)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_MERCADERIATRANSPORTES", objParam)

            Catch ex As Exception

            End Try

            Return objEntidad
        End Function

        Public Function Listar_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As List(Of MercaderiaTransportes)
            Dim objDataTable As New DataTable
            Dim objDatos As MercaderiaTransportes
            Dim objGenericCollection As New List(Of MercaderiaTransportes)
            Dim objParam As New Parameter
            Try



                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                'Obteniendo resultados
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_MERCADERIATRANSPORTES", objParam)

                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows

                    objDatos = New MercaderiaTransportes

                    objDatos.CMRCDR = objDataRow("CMRCDR")
                    objDatos.TCMRCD = objDataRow("TCMRCD")
                    objDatos.TAMRCD = objDataRow("TAMRCD")

                    objDatos.FULTAC = objDataRow("FULTAC")
                    objDatos.HULTAC = objDataRow("HULTAC")
                    objDatos.CULUSA = objDataRow("CULUSA")
                    objDatos.NTRMNL = objDataRow("NTRMNL")
                    objDatos.CUSCRT = objDataRow("CUSCRT")
                    objDatos.FCHCRT = objDataRow("FCHCRT")
                    objDatos.HRACRT = objDataRow("HRACRT")
                    objDatos.NTRMCR = objDataRow("NTRMCR")
                    objDatos.CGRMRC = objDataRow("CGRMRC")
                    objGenericCollection.Add(objDatos)

                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Buscar_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As List(Of MercaderiaTransportes)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of MercaderiaTransportes)
            Dim objParam As New Parameter
            Try
                objParam.Add("PCGRMRC", objEntidad.CGRMRC)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_MERCADERIATRANSPORTES", objParam)
                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows
                    Dim objDatos As New MercaderiaTransportes
                    objDatos.CMRCDR = objDataRow("CMRCDR").ToString().Trim()
                    objDatos.TCMRCD = objDataRow("TCMRCD").ToString().Trim()
                    objDatos.TAMRCD = objDataRow("TAMRCD").ToString().Trim()
                    objDatos.CGRMRC = objDataRow("CGRMRC").ToString().Trim()
                    objGenericCollection.Add(objDatos)
                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function
        '------------------
        Public Function Buscar_MercaderiaTransportesBuscar(ByVal strCompania As String) As Data.DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_MERCADERIATRANSPORTES", Nothing)
                'Procesandolos como una Lista             
            Catch ex As Exception
            End Try
            Return objDataTable
        End Function

        '------------------

    End Class
End Namespace



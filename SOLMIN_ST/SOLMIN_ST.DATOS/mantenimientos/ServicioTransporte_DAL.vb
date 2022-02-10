Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Namespace mantenimientos
    Public Class ServicioTransporte_DAL
        Private objSql As New SqlManager
        Public Function Registrar_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As ServicioTransporte

            Try
                Dim objParam As New Parameter
                objParam.Add("PCTPOSR", objEntidad.CTPOSR)
                objParam.Add("PTCMTPS", objEntidad.TCMTPS)
                objParam.Add("PTABTPS", objEntidad.TABTPS)

                objParam.Add("PCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PHRACRT", objEntidad.HRACRT)
                objParam.Add("PNTRMCR", objEntidad.NTRMCR)
                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_SERVICIOTRANSPORTE", objParam)
            Catch ex As Exception
               
            End Try
            Return objEntidad
        End Function

        Public Function Modificar_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As ServicioTransporte

            Try
                Dim objParam As New Parameter
                objParam.Add("PCTPOSR", objEntidad.CTPOSR)
                objParam.Add("PTCMTPS", objEntidad.TCMTPS)
                objParam.Add("PTABTPS", objEntidad.TABTPS)

                objParam.Add("PFULTAC", objEntidad.FULTAC)
                objParam.Add("PHULTAC", objEntidad.HULTAC)
                objParam.Add("PCULUSA", objEntidad.CULUSA)
                objParam.Add("PNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_SERVICIOTRANSPORTE", objParam)

            Catch ex As Exception
               
            End Try
            Return objEntidad
        End Function

        Public Function Cambiar_Estado_ServicioTransporte(ByVal objEntidad As ServicioTransporte)

            Try
                Dim objParam As New Parameter
                objParam.Add("PCTPOSR", objEntidad.CTPOSR)

                objParam.Add("PCULUSA", objEntidad.CULUSA)
                objParam.Add("PFULTAC", objEntidad.FULTAC)
                objParam.Add("PHULTAC", objEntidad.HULTAC)
                objParam.Add("PNTRMNL", objEntidad.NTRMNL)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_SERVICIOTRANSPORTE", objParam)

            Catch ex As Exception
               
            End Try

            Return objEntidad
        End Function

        Public Function Listar_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As List(Of ServicioTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ServicioTransporte)
            Dim objParam As New Parameter
            Try


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                'Obteniendo resultados
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIOTRANSPORTE", objParam)

                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows

                    Dim objDatos As New ServicioTransporte

                    objDatos.CTPOSR = objDataRow("CTPOSR")
                    objDatos.TCMTPS = objDataRow("TCMTPS")
                    objDatos.TABTPS = objDataRow("TABTPS")

                    objDatos.FULTAC = objDataRow("FULTAC")
                    objDatos.HULTAC = objDataRow("HULTAC")
                    objDatos.CULUSA = objDataRow("CULUSA")
                    objDatos.NTRMNL = objDataRow("NTRMNL")
                    objDatos.CUSCRT = objDataRow("CUSCRT")
                    objDatos.FCHCRT = objDataRow("FCHCRT")
                    objDatos.HRACRT = objDataRow("HRACRT")
                    objDatos.NTRMCR = objDataRow("NTRMCR")
                    objGenericCollection.Add(objDatos)

                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Buscar_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As List(Of ServicioTransporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ServicioTransporte)
            Dim objParam As New Parameter
            Try
                objParam.Add("PCTPOSR", objEntidad.CTPOSR)

                'Obteniendo resultados
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_SERVICIOTRANSPORTE", objParam)
                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows
                    Dim objDatos As New ServicioTransporte
                    objDatos.CTPOSR = objDataRow("CTPOSR").ToString().Trim()
                    objDatos.TCMTPS = objDataRow("TCMTPS").ToString().Trim()
                    objDatos.TABTPS = objDataRow("TABTPS").ToString().Trim()
                    objGenericCollection.Add(objDatos)
                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function
        '------------------
        Public Function Buscar_ServicioTransporteBuscar() As Data.DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_SERVICIOTRANSPORTE", Nothing)
                'Procesandolos como una Lista             
            Catch ex As Exception
            End Try
            Return objDataTable
        End Function
        '------------------

        Public Function Listar_ServicioTransporteLiquidacion(ByVal compania As String, ByVal division As String) As List(Of ServicioLiquidacion)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ServicioLiquidacion)
            Dim objParam As New Parameter
            Try


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)
                'Obteniendo resultados
                objParam.Add("CCMPN", compania)
                objParam.Add("CDVSN", division)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SERVICIO_TRANSPORTE_RZIK20_L01", objParam)

                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows

                    Dim objDatos As New ServicioLiquidacion

                    objDatos.CSRVNV = objDataRow("CSRVNV")
                    objDatos.TCMTRF = objDataRow("TCMTRF")
                    objDatos.TSRVIN = objDataRow("TSRVIN")

                    objGenericCollection.Add(objDatos)

                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function
    End Class
End Namespace


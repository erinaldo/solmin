Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Rafael gamboa
'** Descripción: capa de acceso a datos .
'****************************************************************************************************
Namespace mantenimientos

    Public Class DocsAdjuntos_SolTransporte_DAL

        Private objSql As New SqlManager

        Public Function Listar_Documentos_Adjuntos(ByVal ht As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRMNC", ht.Item("CTRMNC"))
                objParam.Add("PNNGUITR", ht.Item("NGUITR"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DOCLINKS_SOLICITUD_TRANSPORTE", objParam)
                Return objDataTable
            Catch ex As Exception
                Return New Data.DataTable
            End Try
        End Function

        Public Function Listar_Documentos_Adjuntos(ByVal objEntidad As ENTIDADES.Operaciones.Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRMNC", objEntidad.PSCTRMNC) 'ht.Item("CTRMNC"))
                objParam.Add("PNNGUITR", objEntidad.PSNGUIRM) 'ht.Item("NGUITR"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DOCLINKS_SOLICITUD_TRANSPORTE", objParam)
                Return objDataTable
            Catch ex As Exception
                Return New Data.DataTable
            End Try
        End Function

        Public Function DocumentoTransporteListar(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNGUITR", objEntidad.NGUITR)
                objParam.Add("PNCTRMNC", objEntidad.CTRSPT)
                objParam.Add("PSTIPODC", objEntidad.TIPODC)
                objParam.Add("PSCTIIMG", objEntidad.TIIMG)
                objParam.Add("PNNCRRDC", objEntidad.NCRRDC)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_DOCUMENTO_TRANSPORTE_LIST", objParam)
                Return objDataTable
            Catch ex As Exception
                Return New Data.DataTable
            End Try
        End Function

        Public Function DocumentoTransporteInsertar(ByVal objEntidad As DocsAdjuntos_SolTransporte) As Integer
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCTRMNC", objEntidad.CTRSPT)
                objParam.Add("PSNGUITR", objEntidad.NGUITR)
                objParam.Add("PSCTIIMG", objEntidad.TIIMG)
                objParam.Add("PSTOBSMD", objEntidad.TOBS)
                objParam.Add("PSTNMBAR", objEntidad.URLARC)
                objParam.Add("PSURLARC", objEntidad.CLINK)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PSSESTRG", objEntidad.SESTRG)
                objParam.Add("PNNCRRDC", objEntidad.NCRRDC, ParameterDirection.Output)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_DOCUMENTO_TRANSPORTE_INSERT", objParam)
                Return objParam.Item(objParam.Count).Value
            Catch ex As Exception
                Return 0
            End Try
        End Function
        Public Function DocumentoTransporteActualizar(ByVal objEntidad As DocsAdjuntos_SolTransporte) As Integer
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function Registrar_Documento_Adjunto(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DocsAdjuntos_SolTransporte
            Try
                Dim objParam As New Parameter

                objParam.Add("PSNCSOTR", objEntidad.NCSOTR)
                objParam.Add("PSNCRRSR", objEntidad.NCRRSR)
                objParam.Add("PSCTIIMG", objEntidad.CTIIMG)
                objParam.Add("PSCLINK", objEntidad.CLINK)
                objParam.Add("PSTOBS", objEntidad.TOBS)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_DOCLINKS_SOLICITUD_TRANSPORTE", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.NCSOTR = "0"
            End Try

            Return objEntidad
        End Function

        Public Function Modificar_Documento_Adjunto(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DocsAdjuntos_SolTransporte
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNCOIMG", objEntidad.CLINK)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_DOCLINKS_SOLICITUD_TRANSPORTE", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.NCSOTR = "0"
            End Try

            Return objEntidad
        End Function

        Public Function Eliminar_Documento_Adjunto(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DocsAdjuntos_SolTransporte
            Try
                Dim objParam As New Parameter
                objParam.Add("PSCLINK", objEntidad.CLINK)
                objParam.Add("PSURLARC", objEntidad.URLARC)
                objParam.Add("PSCTIIMG", objEntidad.TIIMG)
                objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
                objParam.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
                objParam.Add("PNHULTAC", Format(Now, "HHmmss"))

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_DOCLINKS_SOLICITUD_TRANSPORTE", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.NCSOTR = "0"
            End Try

            Return objEntidad
        End Function

    End Class

End Namespace
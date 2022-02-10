Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports System.Data
Imports Db2Manager.RansaData.iSeries.DataObjects
Namespace mantenimientos
    Public Class Personal_Contratista_DAL
        Private objSql As New SqlManager

        Public Function ListarTipoDocumento(ByVal strCompañia As String) As DataTable
            Dim oDt As New DataTable
            Dim olbePersonal_Contratista As New List(Of Personal_Contratista)
            Dim objParam As New Parameter
            Try
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompañia)
                Return objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_DOCUMENTO", objParam)
            Catch ex As Exception
                Return New DataTable
            End Try

        End Function

        Public Function ListarGradoAcademico(ByVal strCompañia As String) As DataTable
            Dim oDt As New DataTable
            Dim olbePersonal_Contratista As New List(Of Personal_Contratista)
            Dim objParam As New Parameter
            Try
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompañia)
                Return objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_GRADO_ACADEMICO", objParam)
            Catch ex As Exception
                Return New DataTable
            End Try

        End Function


        Public Function ListarPersonalFiltro(ByVal obe_Personal_Contratista As Personal_Contratista) As List(Of Personal_Contratista)
            Dim oDt As New DataTable
            Dim olbePersonal_Contratista As New List(Of Personal_Contratista)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", obe_Personal_Contratista.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Personal_Contratista.PNCPRVCL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Personal_Contratista.PSCCMPN)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PERSONAL_FILTRO", objParam)
                For Each objDataRow As DataRow In oDt.Rows
                    Dim objEntidad As New Personal_Contratista
                    objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
                    objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
                    objEntidad.PSTPDCPE = objDataRow("TPDCPE").ToString.Trim
                    objEntidad.PSTIPODOC = objDataRow("TIPODOC").ToString.Trim
                    objEntidad.PSNMDCPE = objDataRow("NMDCPE").ToString.Trim
                    objEntidad.PSNMBPER = objDataRow("NMBPER").ToString.Trim
                    objEntidad.PSAPEPER = objDataRow("APEPER").ToString.Trim
                    objEntidad.PSAPENOM = objDataRow("APENOM").ToString.Trim
                    olbePersonal_Contratista.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return olbePersonal_Contratista
        End Function


        Public Function Insertar_Personal_Contratista(ByVal obe_Personal_Contratista As Personal_Contratista) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("PNCCLNT", obe_Personal_Contratista.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Personal_Contratista.PNCPRVCL)
                objParam.Add("PSTPDCPE", obe_Personal_Contratista.PSTPDCPE)
                objParam.Add("PSNMDCPE", obe_Personal_Contratista.PSNMDCPE)

                objParam.Add("PSNMBPER", obe_Personal_Contratista.PSNMBPER)
                objParam.Add("PSAPEPER", obe_Personal_Contratista.PSAPEPER)
                objParam.Add("PNFNCMTO", obe_Personal_Contratista.PNFNCMTO)
                objParam.Add("PSTNCION", obe_Personal_Contratista.PSTNCION)

                objParam.Add("PSTDRCPE", obe_Personal_Contratista.PSTDRCPE)
                objParam.Add("PSGRDACA", obe_Personal_Contratista.PSGRDACA)
                objParam.Add("PSCCTPPE", obe_Personal_Contratista.PSCCTPPE)
                objParam.Add("PNFINGEM", obe_Personal_Contratista.PNFINGEM)
                objParam.Add("PSPDCNAT", obe_Personal_Contratista.PSPDCNAT)
                objParam.Add("PSNMCNAP", obe_Personal_Contratista.PSNMCNAP)
                objParam.Add("PNNDIART", obe_Personal_Contratista.PNNDIART)
                objParam.Add("PSSESTRG", obe_Personal_Contratista.PSSESTRG)
                objParam.Add("PSCUSCRT", obe_Personal_Contratista.PSCUSCRT)
                objParam.Add("PNFCHCRT", obe_Personal_Contratista.PNFCHCRT)
                objParam.Add("PNHRACRT", obe_Personal_Contratista.PNHRACRT)
                objParam.Add("PSNTRMCR", obe_Personal_Contratista.PSNTRMCR)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Personal_Contratista.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_PERSONAL_CONTRATISTA", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function Actualizar_Personal_Contratista(ByVal obe_Personal_Contratista As Personal_Contratista) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("PNCCLNT", obe_Personal_Contratista.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Personal_Contratista.PNCPRVCL)
                objParam.Add("PSTPDCPE", obe_Personal_Contratista.PSTPDCPE)
                objParam.Add("PSNMDCPE", obe_Personal_Contratista.PSNMDCPE)
                objParam.Add("PSNMBPER", obe_Personal_Contratista.PSNMBPER)
                objParam.Add("PSAPEPER", obe_Personal_Contratista.PSAPEPER)
                objParam.Add("PNFNCMTO", obe_Personal_Contratista.PNFNCMTO)
                objParam.Add("PSTNCION", obe_Personal_Contratista.PSTNCION)
                objParam.Add("PSTDRCPE", obe_Personal_Contratista.PSTDRCPE)
                objParam.Add("PSGRDACA", obe_Personal_Contratista.PSGRDACA)
                objParam.Add("PSCCTPPE", obe_Personal_Contratista.PSCCTPPE)
                objParam.Add("PNFINGEM", obe_Personal_Contratista.PNFINGEM)
                objParam.Add("PSPDCNAT", obe_Personal_Contratista.PSPDCNAT)
                objParam.Add("PSNMCNAP", obe_Personal_Contratista.PSNMCNAP)
                objParam.Add("PNNDIART", obe_Personal_Contratista.PNNDIART)
                objParam.Add("PSCULUSA", obe_Personal_Contratista.PSCULUSA)
                objParam.Add("PNFULTAC", obe_Personal_Contratista.PNFULTAC)
                objParam.Add("PNHULTAC", obe_Personal_Contratista.PNHULTAC)
                objParam.Add("PSNTRMNL", obe_Personal_Contratista.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Personal_Contratista.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PERSONAL_CONTRATISTA", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function Listar_Personal_Contratista(ByVal obe_Personal_Contratista As Personal_Contratista) As List(Of Personal_Contratista)
            Dim oDt As New DataTable
            Dim olbePersonal_Contratista As New List(Of Personal_Contratista)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", obe_Personal_Contratista.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Personal_Contratista.PNCPRVCL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Personal_Contratista.PSCCMPN)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PERSONAL_CONTRATISTA", objParam)

                For Each objDataRow As DataRow In oDt.Rows
                    Dim objEntidad As New Personal_Contratista
                    objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
                    objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
                    objEntidad.PSTPDCPE = objDataRow("TPDCPE").ToString.Trim
                    objEntidad.PSTIPODOC = objDataRow("TIPODOC").ToString.Trim
                    objEntidad.PSNMDCPE = objDataRow("NMDCPE").ToString.Trim
                    objEntidad.PSNMBPER = objDataRow("NMBPER").ToString.Trim
                    objEntidad.PSAPEPER = objDataRow("APEPER").ToString.Trim

                    objEntidad.PNFNCMTO = objDataRow("FNCMTO").ToString.Trim
                    objEntidad.PSFECHANAC = Validacion.CFecha_a_Numero10Digitos(objDataRow("FECHANAC").ToString.Trim)
                    objEntidad.PSTNCION = objDataRow("TNCION").ToString.Trim
                    objEntidad.PSTDRCPE = objDataRow("TDRCPE").ToString.Trim
                    objEntidad.PSGRDACA = objDataRow("GRDACA").ToString.Trim
                    objEntidad.PSGRDACA_DESC = objDataRow("GRDACA_DESC").ToString.Trim
                    objEntidad.PSCCTPPE = objDataRow("CCTPPE").ToString.Trim

                    objEntidad.PNFINGEM = objDataRow("FINGEM").ToString.Trim
                    objEntidad.PSFECHAIN = Validacion.CFecha_a_Numero10Digitos(objDataRow("FECHAIN").ToString.Trim)
                    objEntidad.PSPDCNAT = objDataRow("PDCNAT").ToString.Trim
                    objEntidad.PSNMCNAP = objDataRow("NMCNAP").ToString.Trim
                    objEntidad.PNNDIART = objDataRow("NDIART").ToString.Trim
                    objEntidad.PSSESTRG = objDataRow("SESTRG").ToString.Trim
                    olbePersonal_Contratista.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return olbePersonal_Contratista
        End Function

        Public Function Eliminar_Personal_Contratista(ByVal obe_Personal_Contratista As Personal_Contratista) As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", obe_Personal_Contratista.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Personal_Contratista.PNCPRVCL)
                objParam.Add("PSTPDCPE", obe_Personal_Contratista.PSTPDCPE)
                objParam.Add("PSNMDCPE", obe_Personal_Contratista.PSNMDCPE)
                objParam.Add("PSSESTRG", obe_Personal_Contratista.PSSESTRG)
                objParam.Add("PSCULUSA", obe_Personal_Contratista.PSCULUSA)
                objParam.Add("PNFULTAC", obe_Personal_Contratista.PNFULTAC)
                objParam.Add("PNHULTAC", obe_Personal_Contratista.PNHULTAC)
                objParam.Add("PSNTRMNL", obe_Personal_Contratista.PSNTRMNL)
                objParam.Add("VAR_MESSAGE", 0, ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Personal_Contratista.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_PERSONAL_CONTRATISTA", objParam)
                Return objSql.ParameterCollection.Item("VAR_MESSAGE")
            Catch ex As Exception
                Return -1
            End Try
        End Function

        Public Function RptListar_Contratista_Personal(ByVal obe_Personal_Contratista As Personal_Contratista) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", obe_Personal_Contratista.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Personal_Contratista.PNCPRVCL)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Personal_Contratista.PSCCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONTRATISTA_PERSONAL", objParam)
                Return objDataTable
            Catch ex As Exception
                Return New Data.DataTable
            End Try
        End Function

        Public Function Listar_Personal_Contratista_Cliente(ByVal obe_Personal_Contratista As Personal_Contratista) As List(Of Personal_Contratista)
            Dim oDt As New DataTable
            Dim olbePersonal_Contratista As New List(Of Personal_Contratista)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", obe_Personal_Contratista.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Personal_Contratista.PNCPRVCL)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Personal_Contratista.PSCCMPN)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PERSONAL_CONTRATISTA_CLIENTE", objParam)
                For Each objDataRow As DataRow In oDt.Rows
                    Dim objEntidad As New Personal_Contratista
                    objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
                    objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
                    objEntidad.PSTPDCPE = objDataRow("TPDCPE").ToString.Trim
                    objEntidad.PSTIPODOC = objDataRow("TIPODOC").ToString.Trim
                    objEntidad.PSNMDCPE = objDataRow("NMDCPE").ToString.Trim
                    objEntidad.PSNMBPER = objDataRow("NMBPER").ToString.Trim
                    objEntidad.PSAPEPER = objDataRow("APEPER").ToString.Trim
                    objEntidad.PSAPENOM = objDataRow("APENOM").ToString.Trim
                    olbePersonal_Contratista.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return olbePersonal_Contratista
        End Function

        Public Function Listar_Historial_Rutas_Pasajero(ByVal objEntidad As Personal_Contratista) As DataTable
            Dim objParam As New Parameter
            Try
                Dim oDt As New DataTable
                objParam.Add("PNCCLNT", objEntidad.PNCCLNT)
                objParam.Add("PNCPRVCL", objEntidad.PNCPRVCL)
                objParam.Add("PSTPDCPE", objEntidad.PSTPDCPE)
                objParam.Add("PSNMDCPE", objEntidad.PSNMDCPE)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_HISTORIAL_RUTAS", objParam)
                Return oDt
            Catch ex As Exception
                Return New DataTable
            End Try
        End Function
    End Class
End Namespace
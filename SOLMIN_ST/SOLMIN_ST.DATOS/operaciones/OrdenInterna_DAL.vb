Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones

    Public Class OrdenInterna_DAL

        Private objSql As New SqlManager

        'Public Function Generar_Orden_Interna(ByVal objParamList As List(Of String)) As Planeamiento

        '    Dim objResultado As New Planeamiento
        '    Try

        '        Dim objParam As New Parameter
        '        Dim lstr_ordeninterna As String
        '        Dim lstr_claseOrden As String
        '        Dim lstr_OI_retSAP As String

        '        'objParam.Add("PARAM_NORINS", 0, ParameterDirection.Output)
        '        'objParam.Add("PARAM_NOPRCN", objParamList(0))
        '        objParam.Add("PARAM_CCLORI", "", ParameterDirection.Output)
        '        objParam.Add("PARAM_NORINS", 0, ParameterDirection.Output)
        '        objParam.Add("PARAM_OI_SAP", 0, ParameterDirection.Output)
        '        objParam.Add("PARAM_NOPRCN", objParamList(0))
        '        objParam.Add("PARAM_CUSCRT", objParamList(1))
        '        objParam.Add("PARAM_FCHCRT", objParamList(2))
        '        objParam.Add("PARAM_HRACRT", objParamList(3))
        '        objParam.Add("PARAM_NTRMCR", objParamList(4))
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(8))
        '        'objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_ORDEN_INTERNA", objParam)

        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_ORDEN_INTERNA_SALM", objParam)
        '        lstr_ordeninterna = objSql.ParameterCollection("PARAM_NORINS")
        '        lstr_claseOrden = objSql.ParameterCollection("PARAM_CCLORI")
        '        lstr_OI_retSAP = objSql.ParameterCollection("PARAM_OI_SAP")

        '        'si ha obteniedo resultados
        '        If lstr_ordeninterna.Length > 0 Then
        '            If Int64.Parse(lstr_ordeninterna) <> 0 Then
        '                objResultado.NORINS = Int64.Parse(lstr_ordeninterna)
        '                objResultado.CCLORI = lstr_claseOrden
        '                objResultado.OI_SAP = Val(lstr_OI_retSAP)
        '            End If
        '        Else
        '            Throw New Exception("No hay resultado")
        '        End If

        '    Catch ex As Exception
        '        objResultado.NORINS = -1
        '    End Try

        '    Return objResultado

        'End Function

        Public Function Generar_Orden_Interna_SALM(ByVal oFiltro As ENTIDADES.Operaciones.OperacionTransporte, ByRef msgError As String) As ENTIDADES.beRespuestaOperacion

            Dim objResultado As New Planeamiento
            Dim oRespuesta As New ENTIDADES.beRespuestaOperacion
            'Dim msg As String = ""
            Try

                Dim objParam As New Parameter

                objParam.Add("PARAM_NOPRCN", oFiltro.NOPRCN)
                objParam.Add("PARAM_NCRRPL", oFiltro.NCRRPL)
                objParam.Add("PARAM_NSBCRP", oFiltro.NSBCRP)
                objParam.Add("PARAM_CUSCRT", oFiltro.CULUSA)
                objParam.Add("PARAM_NTRMCR", oFiltro.NTRMNL)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.CCMPN)
                Dim dt As New DataTable
                msgError = ""
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GENERAR_ORDEN_INTERNA_SALM_V2", objParam)
                For Each item As DataRow In dt.Rows
                    If item("STATUS") = "E" Then
                        msgError = msgError & item("OBSRESULT")
                    End If
                Next
                msgError = msgError.Trim

                If msgError.Length = 0 Then

                    If dt.Rows.Count > 0 Then
                        oRespuesta.CCLORI = dt.Rows(0)("CCLORI")
                        oRespuesta.NORINS = dt.Rows(0)("NORINS")
                        oRespuesta.OI_SAP = dt.Rows(0)("OI_SAP")
                    End If


                End If

            Catch ex As Exception
                msgError = ex.Message
            End Try

            Return oRespuesta

        End Function


        Public Function Actualizar_Planeamiento(ByVal objParametros As List(Of String)) As Boolean

            Dim objResultado As Boolean = False

            Try

                Dim objParam As New Parameter

                objParam.Add("PARAM_CCLORI", objParametros(0))
                objParam.Add("PARAM_NORINS", objParametros(1))
                objParam.Add("PARAM_NOPRCN", objParametros(2))
                objParam.Add("PARAM_NPLCTR", objParametros(3))
                objParam.Add("PARAM_NPLCAC", objParametros(4))
                objParam.Add("PARAM_CBRCNT", objParametros(5))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(6))
                'objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PLANEAMIENTO", objParam)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PLANEAMIENTO_SALM", objParam)

                objResultado = True
            Catch ex As Exception
                objResultado = False
            End Try

            Return objResultado

        End Function

    End Class

End Namespace
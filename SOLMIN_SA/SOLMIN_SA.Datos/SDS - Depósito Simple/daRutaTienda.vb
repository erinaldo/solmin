Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports Ransa.Utilitario

Public Class daRutaTienda
    Private objSql As New SqlManager


    Public Function Insertar(ByVal obe_beRutaTienda As beRutaTienda) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obe_beRutaTienda.PNCCLNT)
            objParam.Add("PNCPLNCL", obe_beRutaTienda.PNCPLNCL)
            objParam.Add("PNCPRVCL", obe_beRutaTienda.PNCPRVCL)
            objParam.Add("PNCPLCLP", obe_beRutaTienda.PNCPLCLP)
            objParam.Add("PSCRUTAT", obe_beRutaTienda.PSCRUTAT)
            objParam.Add("PNFULTAC", obe_beRutaTienda.PNFULTAC)
            objParam.Add("PNHULTAC", obe_beRutaTienda.PNHULTAC)
            objParam.Add("PSCULUSA", obe_beRutaTienda.PSCULUSA)
            objParam.Add("PSNTRMNL", obe_beRutaTienda.PSNTRMNL)
            objParam.Add("PSCUSCRT", obe_beRutaTienda.PSCUSCRT)
            objParam.Add("PNFCHCRT", obe_beRutaTienda.PNFCHCRT)
            objParam.Add("PNHRACRT", obe_beRutaTienda.PNHRACRT)
            objParam.Add("PSNTRMCR", obe_beRutaTienda.PSNTRMCR)
            objParam.Add("PNHRAINI", obe_beRutaTienda.PNHRAINI)
            objParam.Add("PNHRAFIN", obe_beRutaTienda.PNHRAFIN)
            objParam.Add("PSGPSLAT", obe_beRutaTienda.PSGPSLAT)
            objParam.Add("PSGPSLON", obe_beRutaTienda.PSGPSLON)
            objParam.Add("PNNCRRRT", obe_beRutaTienda.PNNCRRRT)
            objParam.Add("PSSESTRG", obe_beRutaTienda.PSSESTRG)
            objParam.Add("PNUPDATE_IDENT", obe_beRutaTienda.PNUPDATE_IDENT)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_RUTA_X_TIENDA_INS", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function Actualizar(ByVal obe_beRutaTienda As beRutaTienda) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obe_beRutaTienda.PNCCLNT)
            objParam.Add("PNCPLNCL", obe_beRutaTienda.PNCPLNCL)
            objParam.Add("PNCPRVCL", obe_beRutaTienda.PNCPRVCL)
            objParam.Add("PNCPLCLP", obe_beRutaTienda.PNCPLCLP)
            'objParam.Add("PSTCMPPL", obe_beRutaTienda.PSTCMPPL)
            'objParam.Add("PSTDRCPL", obe_beRutaTienda.PSTDRCPL)
            objParam.Add("PSCRUTAT", obe_beRutaTienda.PSCRUTAT)
            objParam.Add("PNFULTAC", obe_beRutaTienda.PNFULTAC)
            objParam.Add("PNHULTAC", obe_beRutaTienda.PNHULTAC)
            objParam.Add("PSCULUSA", obe_beRutaTienda.PSCULUSA)
            objParam.Add("PSNTRMNL", obe_beRutaTienda.PSNTRMNL)
            objParam.Add("PSCUSCRT", obe_beRutaTienda.PSCUSCRT)
            objParam.Add("PNFCHCRT", obe_beRutaTienda.PNFCHCRT)
            objParam.Add("PNHRACRT", obe_beRutaTienda.PNHRACRT)
            objParam.Add("PSNTRMCR", obe_beRutaTienda.PSNTRMCR)

            objParam.Add("PNHRAINI", obe_beRutaTienda.PNHRAINI)
            objParam.Add("PNHRAFIN", obe_beRutaTienda.PNHRAFIN)
            objParam.Add("PSGPSLAT", obe_beRutaTienda.PSGPSLAT)
            objParam.Add("PSGPSLON", obe_beRutaTienda.PSGPSLON)
            objParam.Add("PNNCRRRT", obe_beRutaTienda.PNNCRRRT)
            objParam.Add("PSSESTRG", obe_beRutaTienda.PSSESTRG)

            objParam.Add("PNUPDATE_IDENT", obe_beRutaTienda.PNUPDATE_IDENT)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_RUTA_X_TIENDA_UPD", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Listar(ByVal obe_beRutaTienda As beRutaTienda) As List(Of beRutaTienda)
        Dim oDt As New DataTable
        Dim olbebeRutaTienda As New List(Of beRutaTienda)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCRUTAT", obe_beRutaTienda.PSCRUTAT)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_RUTA_X_TIENDA_LIST", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                Dim objEntidad As New beRutaTienda
                objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
                objEntidad.PNCPLNCL = objDataRow("CPLNCL").ToString.Trim
                objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
                objEntidad.PNCPLCLP = objDataRow("CPLCLP").ToString.Trim
                objEntidad.PSCRUTAT = objDataRow("CRUTAT").ToString.Trim
                objEntidad.PNFULTAC = objDataRow("FULTAC").ToString.Trim
                objEntidad.PNHULTAC = objDataRow("HULTAC").ToString.Trim
                objEntidad.PSCULUSA = objDataRow("CULUSA").ToString.Trim
                objEntidad.PSNTRMNL = objDataRow("NTRMNL").ToString.Trim
                objEntidad.PSCUSCRT = objDataRow("CUSCRT").ToString.Trim
                objEntidad.PNFCHCRT = objDataRow("FCHCRT").ToString.Trim
                objEntidad.PNHRACRT = objDataRow("HRACRT").ToString.Trim
                objEntidad.PSNTRMCR = objDataRow("NTRMCR").ToString.Trim
                objEntidad.PNUPDATE_IDENT = objDataRow("UPDATE_IDENT").ToString.Trim
                objEntidad.PSTCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.PSV_TCMPPL = objDataRow("V_TCMPPL").ToString.Trim
                objEntidad.PSTPRVCL = objDataRow("TPRVCL").ToString.Trim
                objEntidad.PSV_TDRPCP = objDataRow("V_TDRPCP").ToString.Trim

                objEntidad.PNHRAINI_D = HelpClass.CNumero_a_Hora(objDataRow("HRAINI").ToString.Trim)
                objEntidad.PNHRAFIN_D = HelpClass.CNumero_a_Hora(objDataRow("HRAFIN").ToString.Trim)
                objEntidad.PSGPSLAT = objDataRow("GPSLAT").ToString.Trim
                objEntidad.PSGPSLON = objDataRow("GPSLON").ToString.Trim
                objEntidad.PNNCRRRT = objDataRow("NCRRRT").ToString.Trim
                objEntidad.PSSESTRG = objDataRow("SESTRG").ToString.Trim

                olbebeRutaTienda.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return olbebeRutaTienda
    End Function


    Public Function ListarRuteoxPuntoEntrega(ByVal obeRutaTienda As beRutaTienda) As List(Of beRutaTienda)

        Dim oDt As New DataTable
        Dim olbebeRutaTienda As New List(Of beRutaTienda)
        Dim objParametros As New Parameter
        Try
            objParametros.Add("PNCCLNT", obeRutaTienda.PNCCLNT)
            objParametros.Add("PNFECDES", obeRutaTienda.PNFECDES)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_PEDIDOS_PLANTA_DESPACHADOS_X_FECHA", objParametros)
            For Each objDataRow As DataRow In oDt.Rows
                Dim objEntidad As New beRutaTienda
                objEntidad.PNCDPEPL = objDataRow("CDPEPL").ToString
                objEntidad.PSDESCLIP = objDataRow("DESCLIP").ToString
                objEntidad.PNCCLNT = objDataRow("CCLNT").ToString
                objEntidad.PNCPLNCL = objDataRow("CPLNCL").ToString
                objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString
                objEntidad.PNCPLCLP = objDataRow("CPLCLP").ToString
                objEntidad.PSTCMPPL = objDataRow("TCMPPL").ToString
                objEntidad.PSDESCLIT = objDataRow("DESCLIT").ToString
                objEntidad.PSTCMPCP = objDataRow("TCMPCP").ToString
                objEntidad.PSTABRUT = objDataRow("TABRUT").ToString
                objEntidad.PSCRUTAT = objDataRow("CRUTAT").ToString
                objEntidad.PNNCRRRT_S = objDataRow("NCRRRT").ToString
                objEntidad.PNHRAINI_S = objDataRow("HRAINI").ToString
                objEntidad.PNHRAFIN_S = objDataRow("HRAFIN").ToString
                objEntidad.PSGPSLAT = objDataRow("GPSLAT").ToString
                objEntidad.PSGPSLON = objDataRow("GPSLON").ToString

                olbebeRutaTienda.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return olbebeRutaTienda
    End Function

    Public Function Eliminar(ByVal obeRutaTienda As beRutaTienda) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try

            objParam.Add("PNCCLNT", obeRutaTienda.PNCCLNT)
            objParam.Add("PNCPLNCL", obeRutaTienda.PNCPLNCL)
            objParam.Add("PNCPRVCL", obeRutaTienda.PNCPRVCL)
            objParam.Add("PNCPLCLP", obeRutaTienda.PNCPLCLP)
            objParam.Add("PSCULUSA", obeRutaTienda.PSCULUSA)
            objParam.Add("PSSESTRG", obeRutaTienda.PSSESTRG)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_RUTA_X_TIENDA_DELET", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


    'Public Function ListarRuteoxPuntoEntrega(ByVal obeRutaTienda As beRutaTienda) As beRutaTienda
    '    Dim objbeRutaTienda As beRutaTienda = Nothing
    '    Dim objSqlManager As SqlManager = New SqlManager
    '    Dim objParametros As Parameter = New Parameter
    '    objSqlManager.TransactionController(TransactionType.Automatic)
    '    objParametros.Add("PNCCLNT", obeRutaTienda.PNCCLNT)
    '    objParametros.Add("PNFECDES", obeRutaTienda.PNFECDES)
    '    Try
    '        Dim dt As New DataTable
    '        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_PEDIDOS_PLANTA_DESPACHADOS_X_FECHA", objParametros)
    '        If dt.Rows.Count > 0 Then
    '            objbeRutaTienda = New beRutaTienda
    '            objbeRutaTienda.PNCDPEPL = dt.Rows(0)("CDPEPL").ToString
    '            objbeRutaTienda.PSDESCLIP = dt.Rows(0)("DESCLIP").ToString
    '            objbeRutaTienda.PNCCLNT = dt.Rows(0)("CCLNT").ToString
    '            objbeRutaTienda.PNCPLNCL = dt.Rows(0)("CPLNCL").ToString
    '            objbeRutaTienda.PNCPRVCL = dt.Rows(0)("CPRVCL").ToString
    '            objbeRutaTienda.PNCPLCLP = dt.Rows(0)("CPLCLP").ToString
    '            objbeRutaTienda.PSTCMPPL = dt.Rows(0)("TCMPPL").ToString
    '            objbeRutaTienda.PSDESCLIT = dt.Rows(0)("DESCLIT").ToString
    '            objbeRutaTienda.PSTCMPCP = dt.Rows(0)("TCMPCP").ToString
    '            objbeRutaTienda.PSTABRUT = dt.Rows(0)("TABRUT").ToString
    '            objbeRutaTienda.PSCRUTAT = dt.Rows(0)("CRUTAT").ToString
    '            objbeRutaTienda.PNNCRRRT_S = dt.Rows(0)("NCRRRT").ToString
    '            objbeRutaTienda.PNHRAINI_S = dt.Rows(0)("HRAINI").ToString
    '            objbeRutaTienda.PNHRAFIN_S = dt.Rows(0)("HRAFIN").ToString
    '            objbeRutaTienda.PSGPSLAT = dt.Rows(0)("GPSLAT").ToString
    '            objbeRutaTienda.PSGPSLON = dt.Rows(0)("GPSLON").ToString
    '        End If
    '    Catch ex As Exception
    '        objbeRutaTienda = Nothing
    '    Finally
    '        objSqlManager = Nothing
    '        objParametros = Nothing
    '    End Try
    '    Return objbeRutaTienda
    'End Function


End Class
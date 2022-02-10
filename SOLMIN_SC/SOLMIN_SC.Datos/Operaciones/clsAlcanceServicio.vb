Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsAlcanceServicio
    Inherits Base_DAL(Of beAlcanceServicio)

    Private objSql As New SqlManager
    Public Function fintInsertarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PSTDALSR", obeAlcanceServicio.PSTDALSR)
            objParam.Add("PSTINDMD", obeAlcanceServicio.PSTINDMD)
            objParam.Add("PNQMDALS", obeAlcanceServicio.PNQMDALS)
            objParam.Add("PSCUNDSR", obeAlcanceServicio.PSCUNDSR)
            objParam.Add("PSTRFMED", obeAlcanceServicio.PSTRFMED)
            objParam.Add("PSTFRMMD", obeAlcanceServicio.PSTFRMMD)
            objParam.Add("PSSESTRG", obeAlcanceServicio.PSSESTRG)
            objParam.Add("PSUSUARIO", obeAlcanceServicio.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeAlcanceServicio.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_INSERTAR_ALCANCE_SERVICIO_X_CLIENTE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function fintActualizarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PNNCRRLT", obeAlcanceServicio.PNNCRRLT)
            objParam.Add("PSTDALSR", obeAlcanceServicio.PSTDALSR)
            objParam.Add("PSTINDMD", obeAlcanceServicio.PSTINDMD)
            objParam.Add("PNQMDALS", obeAlcanceServicio.PNQMDALS)
            objParam.Add("PSCUNDSR", obeAlcanceServicio.PSCUNDSR)
            objParam.Add("PSTRFMED", obeAlcanceServicio.PSTRFMED)
            objParam.Add("PSTFRMMD", obeAlcanceServicio.PSTFRMMD)
            objParam.Add("PSSESTRG", obeAlcanceServicio.PSSESTRG)
            objParam.Add("PSUSUARIO", obeAlcanceServicio.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeAlcanceServicio.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_ACTUALIZAR_ALCANCE_SERVICIO_X_CLIENTE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function flistListarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As List(Of beAlcanceServicio)
        Dim oDt As New DataTable
        Dim olbebeAlcanceServicio As New List(Of beAlcanceServicio)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_ALCANCE_SERVICIO_X_CLIENTE", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                Dim objEntidad As New beAlcanceServicio
                objEntidad.PSCCMPN = objDataRow("CCMPN").ToString.Trim
                objEntidad.PSCDVSN = objDataRow("CDVSN").ToString.Trim
                objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
                objEntidad.PSTCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.PNNCRRLT = objDataRow("NCRRLT").ToString.Trim
                objEntidad.PSTDALSR = objDataRow("TDALSR").ToString.Trim
                objEntidad.PSTINDMD = objDataRow("TINDMD").ToString.Trim
                objEntidad.PNQMDALS = objDataRow("QMDALS").ToString.Trim
                objEntidad.PSCUNDSR = objDataRow("CUNDSR").ToString.Trim
                objEntidad.PSTRFMED = objDataRow("TRFMED").ToString.Trim
                objEntidad.PSTFRMMD = objDataRow("TFRMMD").ToString.Trim
                objEntidad.PSTABRUN = objDataRow("TABRUN").ToString.Trim
                objEntidad.PSSESTRG = objDataRow("SESTRG").ToString.Trim
                objEntidad.PSCUSCRT = objDataRow("CUSCRT").ToString.Trim
                objEntidad.PNFCHCRT = objDataRow("FCHCRT").ToString.Trim
                objEntidad.PNHRACRT = objDataRow("HRACRT").ToString.Trim
                objEntidad.PSNTRMCR = objDataRow("NTRMCR").ToString.Trim
                objEntidad.PSCULUSA = objDataRow("CULUSA").ToString.Trim
                objEntidad.PNFULTAC = objDataRow("FULTAC").ToString.Trim
                objEntidad.PNHULTAC = objDataRow("HULTAC").ToString.Trim
                objEntidad.PSNTRMNL = objDataRow("NTRMNL").ToString.Trim
                olbebeAlcanceServicio.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return olbebeAlcanceServicio
    End Function



    Public Function flistListarAlcanceServicioXClientexAnio(ByVal obeAlcanceServicio As beAlcanceServicio) As List(Of beAlcanceServicio)
        Dim oDt As New DataTable
        Dim olbebeAlcanceServicio As New List(Of beAlcanceServicio)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PNNANASR", obeAlcanceServicio.PNNANASR)
            objParam.Add("PSMES", obeAlcanceServicio.PSMES)
            Return Listar("SP_SOLMIN_SC_LISTA_REGISTRO_ALCANCE_SERVICIO_X_CLIENTE", objParam)

        Catch ex As Exception
            Return New List(Of beAlcanceServicio)()
        End Try
    End Function
    Public Function fstrInsertarRegistroAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As String
        Try
            Dim objParam As New Parameter
            objParam.Add("PSALERTA", "", ParameterDirection.Output)
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PNNANASR", obeAlcanceServicio.PNNANASR)
            objParam.Add("PNNMSASR", obeAlcanceServicio.PNNMSASR)
            objParam.Add("PNNCRRLT", obeAlcanceServicio.PNNCRRLT)
            objParam.Add("PNQMDASC", obeAlcanceServicio.PNQMDASC)
            objParam.Add("PSTSRVC", obeAlcanceServicio.PSTSRVC)
            objParam.Add("PSUSUARIO", obeAlcanceServicio.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeAlcanceServicio.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_INSERTAR_REGISTRO_ALCANCE_SERVICIO_X_CLIENTE", objParam)
            Return objSql.ParameterCollection("PSALERTA")
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function fstrActualizarRegistroAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As String
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PNNANASR", obeAlcanceServicio.PNNANASR)
            objParam.Add("PNNMSASR", obeAlcanceServicio.PNNMSASR)
            objParam.Add("PNNCRRLT", obeAlcanceServicio.PNNCRRLT)
            objParam.Add("PNQMDASC", obeAlcanceServicio.PNQMDASC)
            objParam.Add("PSTSRVC", obeAlcanceServicio.PSTSRVC)
            objParam.Add("PSSESTRG", obeAlcanceServicio.PSSESTRG)
            objParam.Add("PSUSUARIO", obeAlcanceServicio.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeAlcanceServicio.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_ACTUALIZAR_REGISTRO_ALCANCE_SERVICIO_X_CLIENTE", objParam)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function fintValidarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As Integer
        Try
            Dim objParam As New Parameter
            Dim dt As DataTable
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PNNCRRLT", obeAlcanceServicio.PNNCRRLT)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_SC_VALIDAR_REGISTRO_ALCANCE_SERVICIO_X_CLIENTE", objParam)
            If dt.Rows.Count > 0 Then
                Return 1
            Else
                Return 0
            End If
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Public Function fListaAlcanceServicioXClientexAnio(ByVal obeAlcanceServicio As beAlcanceServicio) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PNNANASR", obeAlcanceServicio.PNNANASR)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SC_LISTA_ALCANCE_SERVICIO_X_CLIENTE_ANUAL", objParam)

            Return oDt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function fdtAlcanceServicioXClientexMes(ByVal obeAlcanceServicio As beAlcanceServicio) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("PSCCMPN", obeAlcanceServicio.PSCCMPN)
            objParam.Add("PSCDVSN", obeAlcanceServicio.PSCDVSN)
            objParam.Add("PNCCLNT", obeAlcanceServicio.PNCCLNT)
            objParam.Add("PNNANASR", obeAlcanceServicio.PNNANASR)
            objParam.Add("PNNMSASR", obeAlcanceServicio.PNNMSASR)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SC_LISTA_ALCANCE_SERVICIO_X_CLIENTE_X_MES", objParam)

            Return oDt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidad.beAlcanceServicio)

    End Sub
End Class
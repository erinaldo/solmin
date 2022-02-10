Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daMaestroRuta
    'Inherits daBase(Of beMaestroRuta)
    Private objSql As New SqlManager
    Public Function Insertar(ByVal obe_beMaestroRuta As beMaestroRuta) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCRUTAT", obe_beMaestroRuta.PSCRUTAT)
            objParam.Add("PSTABRUT", obe_beMaestroRuta.PSTABRUT)
            objParam.Add("PNFULTAC", obe_beMaestroRuta.PNFULTAC)
            objParam.Add("PNHULTAC", obe_beMaestroRuta.PNHULTAC)
            objParam.Add("PSCULUSA", obe_beMaestroRuta.PSCULUSA)
            objParam.Add("PSSESTRG", obe_beMaestroRuta.PSSESTRG)
            objParam.Add("PNUPDATE_IDENT", obe_beMaestroRuta.PNUPDATE_IDENT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_RUTA_INS", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Actualizar(ByVal obe_beMaestroRuta As beMaestroRuta) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCRUTAT", obe_beMaestroRuta.PSCRUTAT)
            objParam.Add("PSTABRUT", obe_beMaestroRuta.PSTABRUT)
            objParam.Add("PNFULTAC", obe_beMaestroRuta.PNFULTAC)
            objParam.Add("PNHULTAC", obe_beMaestroRuta.PNHULTAC)
            objParam.Add("PSCULUSA", obe_beMaestroRuta.PSCULUSA)
            objParam.Add("PSSESTRG", obe_beMaestroRuta.PSSESTRG)
            objParam.Add("PNUPDATE_IDENT", obe_beMaestroRuta.PNUPDATE_IDENT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_RUTA_UPD", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Listar() As List(Of beMaestroRuta)
        Dim oDt As New DataTable
        Dim olbebeMaestroRuta As New List(Of beMaestroRuta)
        Dim objParam As New Parameter
        Try
            ' objParam.Add("PSCRUTAT", obe_beMaestroRuta.PSCRUTAT)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_MAESTRO_RUTA_LIST", Nothing) ', objParam)
            For Each objDataRow As DataRow In oDt.Rows
                Dim objEntidad As New beMaestroRuta
                objEntidad.PSCRUTAT = objDataRow("CRUTAT").ToString.Trim
                objEntidad.PSTABRUT = objDataRow("TABRUT").ToString.Trim
                objEntidad.PNFULTAC = objDataRow("FULTAC").ToString.Trim
                objEntidad.PNHULTAC = objDataRow("HULTAC").ToString.Trim
                objEntidad.PSCULUSA = objDataRow("CULUSA").ToString.Trim
                objEntidad.PSSESTRG = objDataRow("SESTRG").ToString.Trim
                objEntidad.PNUPDATE_IDENT = objDataRow("UPDATE_IDENT").ToString.Trim
                olbebeMaestroRuta.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return olbebeMaestroRuta
    End Function

    Public Function ListarxCodigoRuta(ByVal CRUTAT As String) As beMaestroRuta
        Dim objbeMaestroRuta As beMaestroRuta = Nothing
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PSCRUTAT ", CRUTAT)
        Try
            Dim dt As New DataTable
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_MAESTRO_RUTA_LIST_X_CODIGO", objParametros)
            If dt.Rows.Count > 0 Then
                objbeMaestroRuta = New beMaestroRuta
                objbeMaestroRuta.PSCRUTAT = dt.Rows(0)("CRUTAT").ToString
                objbeMaestroRuta.PSTABRUT = dt.Rows(0)("TABRUT").ToString
                objbeMaestroRuta.PNFULTAC = dt.Rows(0)("FULTAC").ToString
                objbeMaestroRuta.PNHULTAC = dt.Rows(0)("HULTAC").ToString
                objbeMaestroRuta.PSCULUSA = dt.Rows(0)("CULUSA").ToString
                objbeMaestroRuta.PSSESTRG = dt.Rows(0)("SESTRG").ToString
                objbeMaestroRuta.PNUPDATE_IDENT = dt.Rows(0)("UPDATE_IDENT").ToString
            End If
        Catch ex As Exception
            objbeMaestroRuta = Nothing
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return objbeMaestroRuta
    End Function

    Public Function Eliminar(ByVal obeMaestroRuta As beMaestroRuta) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", obeMaestroRuta.PSCULUSA)
            objParam.Add("PSSESTRG", obeMaestroRuta.PSSESTRG)
            objParam.Add("PSCRUTAT", obeMaestroRuta.PSCRUTAT)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_RUTA_DELET", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Public Overrides Sub SetStoredprocedures()

    'End Sub

    'Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beMaestroRuta)

    'End Sub
End Class
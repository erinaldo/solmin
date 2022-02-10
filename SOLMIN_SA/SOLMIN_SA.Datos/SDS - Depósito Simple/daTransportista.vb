Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class daTransportista
    Inherits daBase(Of beTransportista)

    Private objSql As New SqlManager

#Region "Mantenimiento DS"

    Public Function InsertarTransportistaDS(ByVal obeTransportista As beTransportista) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCULUSA", obeTransportista.PSCULUSA)
            objParam.Add("PSNTRMNL", obeTransportista.PSNTRMNL)
            objParam.Add("PNCCLNT", obeTransportista.PNCCLNT)
            objParam.Add("PSTCMPTR", obeTransportista.PSTCMPTR)
            objParam.Add("PSTABRTR", obeTransportista.PSTABRTR)
            objParam.Add("PSTDRCTR", obeTransportista.PSTDRCTR)
            objParam.Add("PSNLBELT", obeTransportista.PSNLBELT)
            objParam.Add("PSNRGMRT", obeTransportista.PSNRGMRT)
            objParam.Add("PSNRGINT", obeTransportista.PSNRGINT)
            objParam.Add("PNNRUCT", obeTransportista.PNNRUCT)
            objParam.Add("PSNTLFTR", obeTransportista.PSNTLFTR)
            objParam.Add("PSNTLFT2", obeTransportista.PSNTLFT2)
            objParam.Add("PSNFAXTR", obeTransportista.PSNFAXTR)
            objParam.Add("PSTCNTTR", obeTransportista.PSTCNTTR)
            objParam.Add("PSTCNTT2", obeTransportista.PSTCNTT2)
            objParam.Add("PSTCRGTR", obeTransportista.PSTCRGTR)
            objParam.Add("PSTCRGT2", obeTransportista.PSTCRGT2)
            objParam.Add("PSSESTTR", obeTransportista.PSSESTTR)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_TRANSPORTISTA_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ActualizarTransportistaDS(ByVal obeTransportista As beTransportista) As Integer
        Try
            Dim objParam As New Parameter

            objParam.Add("PSCULUSA", obeTransportista.PSCULUSA)
            objParam.Add("PSNTRMNL", obeTransportista.PSNTRMNL)
            objParam.Add("PNCTRSP", obeTransportista.PNCTRSP)
            objParam.Add("PNCCLNT", obeTransportista.PNCCLNT)
            objParam.Add("PSTCMPTR", obeTransportista.PSTCMPTR)
            objParam.Add("PSTABRTR", obeTransportista.PSTABRTR)
            objParam.Add("PSTDRCTR", obeTransportista.PSTDRCTR)
            objParam.Add("PSNLBELT", obeTransportista.PSNLBELT)
            objParam.Add("PSNRGMRT", obeTransportista.PSNRGMRT)
            objParam.Add("PSNRGINT", obeTransportista.PSNRGINT)
            objParam.Add("PNNRUCT", obeTransportista.PNNRUCT)
            objParam.Add("PSNTLFTR", obeTransportista.PSNTLFTR)
            objParam.Add("PSNTLFT2", obeTransportista.PSNTLFT2)
            objParam.Add("PSNFAXTR", obeTransportista.PSNFAXTR)
            objParam.Add("PSTCNTTR", obeTransportista.PSTCNTTR)
            objParam.Add("PSTCNTT2", obeTransportista.PSTCNTT2)
            objParam.Add("PSTCRGTR", obeTransportista.PSTCRGTR)
            objParam.Add("PSTCRGT2", obeTransportista.PSTCRGT2)
            objParam.Add("PSSESTTR", obeTransportista.PSSESTTR)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_TRANSPORTISTA_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListarTransportistaDS(ByVal obeFiltroTransportista As beFiltroTransportista) As List(Of beTransportista)
        Dim oDt As New DataTable
        Dim olbebeTransportista As New List(Of beTransportista)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CTRSPSTR", obeFiltroTransportista.CTRSPSTR)
            objParam.Add("IN_NRUCTSTR", obeFiltroTransportista.NRUCTSTR)
            objParam.Add("IN_TCMPTRSTR", obeFiltroTransportista.TCMPTRSTR)
            objParam.Add("PAGESIZE", obeFiltroTransportista.PAGESIZE)
            objParam.Add("PAGENUMBER", obeFiltroTransportista.PAGENUMBER)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_SDS_TRANSPORTISTA_LIST", objParam)
        Catch ex As Exception
        End Try
        Return olbebeTransportista
    End Function

    Public Function EliminarTransportistaDS(ByVal obeTransportista As beTransportista) As Integer
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", obeTransportista.PSCULUSA)
            objParam.Add("PSNTRMNL", obeTransportista.PSNTRMNL)
            objParam.Add("PNCTRSP", obeTransportista.PNCTRSP)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_TRANSPORTISTA_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function flstListarTodosTransportistaDS() As List(Of beTransportista)
        Dim oDt As New DataTable
        Dim olbebeTransportista As New List(Of beTransportista)
        Dim objParam As New Parameter
        Try

            Return Listar("SP_SOLMIN_SA_SDS_LISTA_TRANSPORTISTA", objParam)
        Catch ex As Exception
        End Try
        Return olbebeTransportista
    End Function

#End Region

#Region "Mantenimiento AT"

    Public Function InsertarTransportistaAT(ByVal obeTransportista As beTransportista) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCTRSPT", obeTransportista.PNCTRSPT)
            objParam.Add("PNCCLNT", obeTransportista.PNCCLNT)
            objParam.Add("PSNRUCTR", obeTransportista.PSNRUCTR)
            objParam.Add("PSTCMTRT", obeTransportista.PSTCMTRT)
            objParam.Add("PSTABTRT", obeTransportista.PSTABTRT)
            objParam.Add("PSTRPRTR", obeTransportista.PSTRPRTR)
            objParam.Add("PSNLBELR", obeTransportista.PSNLBELR)
            objParam.Add("PSNEMMTC", obeTransportista.PSNEMMTC)
            objParam.Add("PNNRKNTR", obeTransportista.PNNRKNTR)
            objParam.Add("PNFULTAC", obeTransportista.PNFULTAC)
            objParam.Add("PNHULTAC", obeTransportista.PNHULTAC)
            objParam.Add("PSCULUSA", obeTransportista.PSCULUSA)
            objParam.Add("PSNTRMNL", obeTransportista.PSNTRMNL)
            objParam.Add("PSCUSCRT", obeTransportista.PSCUSCRT)
            objParam.Add("PNFCHCRT", obeTransportista.PNFCHCRT)
            objParam.Add("PNHRACRT", obeTransportista.PNHRACRT)
            objParam.Add("PSNTRMCR", obeTransportista.PSNTRMCR)
            objParam.Add("PSTDRCTR", obeTransportista.PSTDRCTR)
            objParam.Add("PSTLFTRP", obeTransportista.PSTLFTRP)
            objParam.Add("PNUPDATE_IDENT", obeTransportista.PNUPDATE_IDENT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_AT_TRANSPORTISTA_INSERTAR", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ActualizarTransportistaAT(ByVal obeTransportista As beTransportista) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCTRSPT", obeTransportista.PNCTRSPT)
            objParam.Add("PNCCLNT", obeTransportista.PNCCLNT)
            objParam.Add("PSNRUCTR", obeTransportista.PSNRUCTR)
            objParam.Add("PSTCMTRT", obeTransportista.PSTCMTRT)
            objParam.Add("PSTABTRT", obeTransportista.PSTABTRT)
            objParam.Add("PSTRPRTR", obeTransportista.PSTRPRTR)
            objParam.Add("PSNLBELR", obeTransportista.PSNLBELR)
            objParam.Add("PSNEMMTC", obeTransportista.PSNEMMTC)
            objParam.Add("PNNRKNTR", obeTransportista.PNNRKNTR)
            objParam.Add("PNFULTAC", obeTransportista.PNFULTAC)
            objParam.Add("PNHULTAC", obeTransportista.PNHULTAC)
            objParam.Add("PSCULUSA", obeTransportista.PSCULUSA)
            objParam.Add("PSNTRMNL", obeTransportista.PSNTRMNL)
            'objParam.Add("PSCUSCRT", obeTransportista.PSCUSCRT)
            'objParam.Add("PNFCHCRT", obeTransportista.PNFCHCRT)
            'objParam.Add("PNHRACRT", obeTransportista.PNHRACRT)
            objParam.Add("PSNTRMCR", obeTransportista.PSNTRMCR)
            objParam.Add("PSTDRCTR", obeTransportista.PSTDRCTR)
            objParam.Add("PSTLFTRP", obeTransportista.PSTLFTRP)
            objParam.Add("PNUPDATE_IDENT", obeTransportista.PNUPDATE_IDENT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_AT_TRANSPORTISTA_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListarTransportistaAT(ByVal obeTransportista As beTransportista) As List(Of beTransportista)
        Dim oDt As New DataTable
        Dim olbebeTransportista As New List(Of beTransportista)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSNRUCTR", obeTransportista.PSNRUCTR)
        objParam.Add("PSTCMTRT", obeTransportista.PSTCMTRT)

        objParam.Add("PSTRACTO", obeTransportista.PSTRACTO)
        objParam.Add("PSACOPLADO", obeTransportista.PSACOPLADO)
        objParam.Add("PSBREVETE", obeTransportista.PSBREVETE)
        
        objParam.Add("PAGESIZE", obeTransportista.PageSize)
        objParam.Add("PAGENUMBER", obeTransportista.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

        'Return Listar("SP_SOLMIN_SA_AT_TRANSPORTISTA_INSERTAR_LIST", objParam)
        Return Listar("P_SOLMIN_SA_AT_TRANSPORTISTA_LIST", objParam)
        'Catch ex As Exception
        '    Return olbebeTransportista
        'End Try

    End Function

    Public Function EliminarTransportistaAT(ByVal obeTransportista As beTransportista) As Integer
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", obeTransportista.PSCULUSA)
            objParam.Add("PSNTRMNL", obeTransportista.PSNTRMNL)
            objParam.Add("PNCTRSPT", obeTransportista.PNCTRSPT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_AT_TRANSPORTISTA_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


#End Region




    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beTransportista)

    End Sub
End Class
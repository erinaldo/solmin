Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daChofer
    Inherits daBase(Of beChofer)

#Region "AT"
    Public Function InsertarChoferAT(ByVal obe_beChofer As beChofer) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCTRSPT", obe_beChofer.PNCTRSPT)
            objParam.Add("PSCBRCNT", obe_beChofer.PSCBRCNT)
            objParam.Add("PSTNMBCH", obe_beChofer.PSTNMBCH)
            objParam.Add("PNNLELCH", obe_beChofer.PNNLELCH)
            objParam.Add("PSSESTUN", obe_beChofer.PSSESTUN)
            objParam.Add("PNNRKNCH", obe_beChofer.PNNRKNCH)
            objParam.Add("PNFULTAC", obe_beChofer.PNFULTAC)
            objParam.Add("PNHULTAC", obe_beChofer.PNHULTAC)
            objParam.Add("PSCULUSA", obe_beChofer.PSCULUSA)
            objParam.Add("PSNTRMNL", obe_beChofer.PSNTRMNL)
            objParam.Add("PSCUSCRT", obe_beChofer.PSCUSCRT)
            objParam.Add("PNFCHCRT", obe_beChofer.PNFCHCRT)
            objParam.Add("PNHRACRT", obe_beChofer.PNHRACRT)
            objParam.Add("PSNTRMCR", obe_beChofer.PSNTRMCR)
            objParam.Add("PSCSGRSC", obe_beChofer.PSCSGRSC)
            objParam.Add("PSTGRPSN", obe_beChofer.PSTGRPSN)
            objParam.Add("PSTDRCC", obe_beChofer.PSTDRCC)
            objParam.Add("PNNROTLF", obe_beChofer.PNNROTLF)
            objParam.Add("PNNRORPM", obe_beChofer.PNNRORPM)
            objParam.Add("PSCBRANT", obe_beChofer.PSCBRANT)
            objParam.Add("PSTAPPAC", obe_beChofer.PSTAPPAC)
            objParam.Add("PSTAPMAC", obe_beChofer.PSTAPMAC)
            objParam.Add("PSTNMCMC", obe_beChofer.PSTNMCMC)
            objParam.Add("PSTNCION", obe_beChofer.PSTNCION)
            objParam.Add("PSTLBTRT", obe_beChofer.PSTLBTRT)
            objParam.Add("PNUPDATE_IDENT", obe_beChofer.PNUPDATE_IDENT)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_CHOFER_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ActualizarChoferAT(ByVal obe_beChofer As beChofer) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCTRSPT", obe_beChofer.PNCTRSPT)
            objParam.Add("PSCBRCNT", obe_beChofer.PSCBRCNT)
            objParam.Add("PSTNMBCH", obe_beChofer.PSTNMBCH)
            objParam.Add("PNNLELCH", obe_beChofer.PNNLELCH)
            objParam.Add("PSSESTUN", obe_beChofer.PSSESTUN)
            objParam.Add("PNNRKNCH", obe_beChofer.PNNRKNCH)
            objParam.Add("PNFULTAC", obe_beChofer.PNFULTAC)
            objParam.Add("PNHULTAC", obe_beChofer.PNHULTAC)
            objParam.Add("PSCULUSA", obe_beChofer.PSCULUSA)
            objParam.Add("PSNTRMNL", obe_beChofer.PSNTRMNL)
            objParam.Add("PSCUSCRT", obe_beChofer.PSCUSCRT)
            objParam.Add("PNFCHCRT", obe_beChofer.PNFCHCRT)
            objParam.Add("PNHRACRT", obe_beChofer.PNHRACRT)
            objParam.Add("PSNTRMCR", obe_beChofer.PSNTRMCR)
            objParam.Add("PSCSGRSC", obe_beChofer.PSCSGRSC)
            objParam.Add("PSTGRPSN", obe_beChofer.PSTGRPSN)
            objParam.Add("PSTDRCC", obe_beChofer.PSTDRCC)
            objParam.Add("PNNROTLF", obe_beChofer.PNNROTLF)
            objParam.Add("PNNRORPM", obe_beChofer.PNNRORPM)
            objParam.Add("PSCBRANT", obe_beChofer.PSCBRANT)
            objParam.Add("PSTAPPAC", obe_beChofer.PSTAPPAC)
            objParam.Add("PSTAPMAC", obe_beChofer.PSTAPMAC)
            objParam.Add("PSTNMCMC", obe_beChofer.PSTNMCMC)
            objParam.Add("PSTNCION", obe_beChofer.PSTNCION)
            objParam.Add("PSTLBTRT", obe_beChofer.PSTLBTRT)
            objParam.Add("PNUPDATE_IDENT", obe_beChofer.PNUPDATE_IDENT)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_CHOFER_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Public Function ListarChoferAT(ByVal obe_beChofer As beChofer) As List(Of beChofer)
    '    Dim objSqlManager As SqlManager = New SqlManager
    '    Dim oDt As New DataTable
    '    Dim olbebeChofer As New List(Of beChofer)
    '    Dim objParam As New Parameter
    '    Try
    '        objParam.Add("PNCTRSPT", obe_beChofer.PNCTRSPT)
    '        objParam.Add("PSCBRCNT", obe_beChofer.PSCBRCNT)
    '        Listar("SP_SOLMIN_SA_CHOFER_LIST", objParam)
    '    Catch ex As Exception
    '        Return New List(Of beChofer)
    '    End Try
    'End Function

    'Public Function EliminarChoferAT(ByVal obe_beChofer As beChofer) As Integer
    '    Dim objParam As New Parameter
    '    Dim objSqlManager As SqlManager = New SqlManager
    '    Try
    '        objParam.Add("PNCTRSPT", obe_beChofer.PNCTRSPT)
    '        objParam.Add("PSCBRCNT", obe_beChofer.PSCBRCNT)
    '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_CHOFER_DELETE", objParam)
    '        Return 1
    '    Catch ex As Exception
    '        Return 0
    '    End Try
    'End Function
#End Region

#Region "DS"
    Public Function SeleccionarChoferDS(ByVal NBRVCH As String, ByVal CTRSP As String) As beChofer
        Dim objbeChofer As beChofer = Nothing
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_NBRVCH", NBRVCH)
        objParametros.Add("PARAM_CTRSP", CTRSP)
        Try
            Dim dt As New DataTable
            Return Listar("SP_SOLMIN_SA_SEL_CHOFER", objParametros).Item(0)
        Catch ex As Exception
            Return objbeChofer
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Public Function SP_SOLMIN_SA_INS_CHOFER(ByVal objBEChofer As beChofer) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intResultado As Integer = 1
       
        Try
            objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros.Add("PARAM_SESTRG", objBEChofer.PSSESTRG)
            objParametros.Add("PARAM_CTRSP", objBEChofer.PNCTRSP)
            objParametros.Add("PARAM_FULTAC", objBEChofer.PNFULTAC)
            objParametros.Add("PARAM_HULTAC", objBEChofer.PNHULTAC)
            objParametros.Add("PARAM_NBRVCH", objBEChofer.PSNBRVCH)
            objParametros.Add("PARAM_CULUSA", objBEChofer.PSCULUSA)
            objParametros.Add("PARAM_NLELCH", objBEChofer.PNNLELCH)
            objParametros.Add("PARAM_NTRMNL", objBEChofer.PSNTRMNL)
            objParametros.Add("PARAM_TNMBCH", objBEChofer.PSTNMBCH)
            objParametros.Add("PARAM_SESTCH", objBEChofer.PSSESTCH)
            objParametros.Add("PARAM_UPID", objBEChofer.PSUPID)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INS_CHOFER", objParametros)
            intResultado = 1
        Catch ex As Exception
            intResultado = -1
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return intResultado
    End Function

    Public Function SP_SOLMIN_SA_UPD_CHOFER(ByVal objBEChofer As beChofer) As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim boolResultado As Boolean = True
   
        Try
            objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros.Add("PARAM_SESTRG", objBEChofer.PSSESTRG)
            objParametros.Add("PARAM_CTRSP", objBEChofer.PNCTRSP)
            objParametros.Add("PARAM_FULTAC", objBEChofer.PNFULTAC)
            objParametros.Add("PARAM_HULTAC", objBEChofer.PNHULTAC)
            objParametros.Add("PARAM_NBRVCH", objBEChofer.PSNBRVCH)
            objParametros.Add("PARAM_CULUSA", objBEChofer.PSCULUSA)
            objParametros.Add("PARAM_NLELCH", objBEChofer.PNNLELCH)
            objParametros.Add("PARAM_NTRMNL", objBEChofer.PSNTRMNL)
            objParametros.Add("PARAM_TNMBCH", objBEChofer.PSTNMBCH)
            objParametros.Add("PARAM_SESTCH", objBEChofer.PSSESTCH)
            objParametros.Add("PARAM_UPID", objBEChofer.PSUPID)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_UPD_CHOFER", objParametros)
            boolResultado = True
        Catch ex As Exception
            boolResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return boolResultado
    End Function

    Public Function ListarChoferxTransportista(ByVal obeFiltroChofer As beChoferFiltro) As List(Of beChofer)
        Dim oDt As New DataTable
        Dim olbeChofer As New List(Of beChofer)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CTRSPSTR", obeFiltroChofer.CTRSPSTR)
            objParam.Add("PAGESIZE", obeFiltroChofer.PAGESIZE)
            objParam.Add("PAGENUMBER", obeFiltroChofer.PAGENUMBER)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_SDS_CHOFER_LIST_X_TRANSPORTISTA", objParam)
        Catch ex As Exception
        End Try
        Return olbeChofer
    End Function

    Public Function flstListarChoferesxTransportista(ByVal obeFiltroChofer As beChoferFiltro) As List(Of beChofer)
        Dim oDt As New DataTable
        Dim olbeChofer As New List(Of beChofer)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CTRSPSTR", obeFiltroChofer.CTRSPSTR)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_CHOFER_X_TRANSPORTISTA", objParam)
        Catch ex As Exception
        End Try
        Return olbeChofer
    End Function


    Public Function EliminarChofer(ByVal obeChofer As beChofer) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", obeChofer.PSCULUSA)
            objParam.Add("PSNTRMNL", obeChofer.PSNTRMNL)
            objParam.Add("PNCTRSP", obeChofer.PNCTRSP)
            objParam.Add("PSNBRVCH", obeChofer.PSNBRVCH)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CAMION_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region






#Region "Mantenimiento AT"


    Public Function ListarChoferxTransportista_AT(ByVal obeFiltroChofer As beChofer) As List(Of beChofer)
        Dim oDt As New DataTable
        Dim olbeChofer As New List(Of beChofer)
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_CTRSPT", obeFiltroChofer.PNCTRSPT)
        objParam.Add("IN_BREVETE", obeFiltroChofer.PSCBRCNT)
        objParam.Add("PAGESIZE", obeFiltroChofer.PageSize)
        objParam.Add("PAGENUMBER", obeFiltroChofer.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        'Return Listar("SP_SOLMIN_SA_AT_CHOFER_LIST_X_TRANSPORTISTA", objParam)
        Return Listar("SP_SOLMIN_SA_AT_CHOFER_LIST_X_TRANSPORTISTA_V2", objParam)
        'Catch ex As Exception
        '    Return olbeChofer
        'End Try
    End Function




    Public Function SP_SOLMIN_SA_SEL_CHOFER_AT(ByVal CBRCNT As String, ByVal CTRSPT As String) As beChofer
        Dim objbeChofer As beChofer = Nothing
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_CBRCNT", CBRCNT)
        objParametros.Add("PARAM_CTRSPT", CTRSPT)
        Try
            Dim dt As New DataTable
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SEL_CHOFER_AT", objParametros)
            If dt.Rows.Count > 0 Then
                objbeChofer = New beChofer
                objbeChofer.PNCTRSPT = dt.Rows(0)("CTRSPT").ToString
                objbeChofer.PSCBRCNT = dt.Rows(0)("CBRCNT").ToString
                objbeChofer.PSTNMBCH = dt.Rows(0)("TNMBCH").ToString
                objbeChofer.PNNLELCH = dt.Rows(0)("NLELCH").ToString
                objbeChofer.PSSESTUN = dt.Rows(0)("SESTUN").ToString
                objbeChofer.PNNRKNCH = dt.Rows(0)("NRKNCH").ToString
                objbeChofer.PNFULTAC = dt.Rows(0)("FULTAC").ToString
                objbeChofer.PNHULTAC = dt.Rows(0)("HULTAC").ToString
                objbeChofer.PSCULUSA = dt.Rows(0)("CULUSA").ToString
                objbeChofer.PSNTRMNL = dt.Rows(0)("NTRMNL").ToString
                objbeChofer.PSCUSCRT = dt.Rows(0)("CUSCRT").ToString
                objbeChofer.PNFCHCRT = dt.Rows(0)("FCHCRT").ToString
                objbeChofer.PNHRACRT = dt.Rows(0)("HRACRT").ToString
                objbeChofer.PSNTRMCR = dt.Rows(0)("NTRMCR").ToString
                objbeChofer.PSCSGRSC = dt.Rows(0)("CSGRSC").ToString
                objbeChofer.PSTGRPSN = dt.Rows(0)("TGRPSN").ToString
                objbeChofer.PSTDRCC = dt.Rows(0)("TDRCC").ToString
                objbeChofer.PNNROTLF = dt.Rows(0)("NROTLF").ToString
                objbeChofer.PNNRORPM = dt.Rows(0)("NRORPM").ToString
                objbeChofer.PSCBRANT = dt.Rows(0)("CBRANT").ToString
                objbeChofer.PSTAPPAC = dt.Rows(0)("TAPPAC").ToString
                objbeChofer.PSTAPMAC = dt.Rows(0)("TAPMAC").ToString
                objbeChofer.PSTNMCMC = dt.Rows(0)("TNMCMC").ToString
                objbeChofer.PSTNCION = dt.Rows(0)("TNCION").ToString
                objbeChofer.PSTLBTRT = dt.Rows(0)("TLBTRT").ToString
                objbeChofer.PNUPDATE_IDENT = dt.Rows(0)("UPDATE_IDENT").ToString
            End If
        Catch ex As Exception
            objbeChofer = Nothing
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return objbeChofer
    End Function



    Public Function SP_SOLMIN_SA_UPD_CHOFER_AT(ByVal objBEChofer As beChofer) As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim boolResultado As Boolean = True
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_SESTUN", objBEChofer.PSSESTUN)
        objParametros.Add("PARAM_CTRSPT", objBEChofer.PNCTRSPT)
        objParametros.Add("PARAM_FULTAC", objBEChofer.PNFULTAC)
        objParametros.Add("PARAM_HULTAC", objBEChofer.PNHULTAC)
        objParametros.Add("PARAM_CBRCNT", objBEChofer.PSCBRCNT)
        objParametros.Add("PARAM_CULUSA", objBEChofer.PSCULUSA)
        objParametros.Add("PARAM_NLELCH", objBEChofer.PNNLELCH)
        objParametros.Add("PARAM_NTRMNL", objBEChofer.PSNTRMNL)
        objParametros.Add("PARAM_TNMBCH", objBEChofer.PSTNMBCH)
        objParametros.Add("PARAM_TDRCC", objBEChofer.PSTDRCC)
        objParametros.Add("PARAM_TNCION", objBEChofer.PSTNCION)
        objParametros.Add("PARAM_UPID", objBEChofer.PSUPID)
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_UPD_CHOFER_AT", objParametros)
            boolResultado = True
        Catch ex As Exception
            boolResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return boolResultado
    End Function



    Public Function SP_SOLMIN_SA_INS_CHOFER_AT(ByVal objBEChofer As beChofer) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intResultado As Integer = 1
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_SESTUN", objBEChofer.PSSESTUN)
        objParametros.Add("PARAM_CTRSPT", objBEChofer.PNCTRSPT)
        objParametros.Add("PARAM_FULTAC", objBEChofer.PNFULTAC)
        objParametros.Add("PARAM_HULTAC", objBEChofer.PNHULTAC)
        objParametros.Add("PARAM_CBRCNT", objBEChofer.PSCBRCNT)
        objParametros.Add("PARAM_CULUSA", objBEChofer.PSCULUSA)
        objParametros.Add("PARAM_NLELCH", objBEChofer.PNNLELCH)
        objParametros.Add("PARAM_NTRMNL", objBEChofer.PSNTRMNL)
        objParametros.Add("PARAM_TNMBCH", objBEChofer.PSTNMBCH)
        objParametros.Add("PARAM_TDRCC", objBEChofer.PSTDRCC)
        objParametros.Add("PARAM_TNCION", objBEChofer.PSTNCION)
        objParametros.Add("PARAM_UPID", objBEChofer.PSUPID)

        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INS_CHOFER_AT", objParametros)
            intResultado = 1
        Catch ex As Exception
            intResultado = -1
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return intResultado
    End Function


    Public Function EliminarChoferAT(ByVal obeChofer As beChofer) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", obeChofer.PSCULUSA)
            objParam.Add("PSNTRMNL", obeChofer.PSNTRMNL)
            objParam.Add("PNCTRSPT", obeChofer.PNCTRSPT)
            objParam.Add("PSCBRCNT", obeChofer.PSCBRCNT)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CHOFER_DELETE_AT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function






    'Public Function SP_SOLMIN_SA_SEL_AT_CHOFER(ByVal NBRVCH As String, ByVal CTRSP As String) As beChofer
    '    Dim objbeChofer As beChofer = Nothing
    '    Dim objSqlManager As SqlManager = New SqlManager
    '    Dim objParametros As Parameter = New Parameter
    '    objSqlManager.TransactionController(TransactionType.Automatic)
    '    objParametros.Add("PARAM_NBRVCH", NBRVCH)
    '    objParametros.Add("PARAM_CTRSP", CTRSP)
    '    Try
    '        Dim dt As New DataTable
    '        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SEL_AT_CHOFER", objParametros)
    '        If dt.Rows.Count > 0 Then
    '            objbeChofer = New beChofer
    '            objbeChofer.PSSESTRG = dt.Rows(0)("SESTRG").ToString
    '            objbeChofer.PNCTRSP = dt.Rows(0)("CTRSP").ToString
    '            objbeChofer.PNFULTAC = dt.Rows(0)("FULTAC").ToString
    '            objbeChofer.PNHULTAC = dt.Rows(0)("HULTAC").ToString
    '            objbeChofer.PSNBRVCH = dt.Rows(0)("NBRVCH").ToString
    '            objbeChofer.PSCULUSA = dt.Rows(0)("CULUSA").ToString
    '            objbeChofer.PNNLELCH = dt.Rows(0)("NLELCH").ToString
    '            objbeChofer.PSNTRMNL = dt.Rows(0)("NTRMNL").ToString
    '            objbeChofer.PSTNMBCH = dt.Rows(0)("TNMBCH").ToString
    '            objbeChofer.PSSESTCH = dt.Rows(0)("SESTCH").ToString
    '            objbeChofer.PSUPID = dt.Rows(0)("UPDATE_IDENT").ToString
    '        End If
    '    Catch ex As Exception
    '        objbeChofer = Nothing
    '    Finally
    '        objSqlManager = Nothing
    '        objParametros = Nothing
    '    End Try
    '    Return objbeChofer
    'End Function




#End Region





    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beChofer)

    End Sub

End Class

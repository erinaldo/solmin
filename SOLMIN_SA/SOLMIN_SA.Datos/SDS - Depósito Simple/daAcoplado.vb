Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daAcoplado

    Inherits daBase(Of beAcoplado)

#Region "Mantenimiento AT"

    Public Function ListarAcopladoxTransportistaAT(ByVal obeAcopladoFiltro As beAcoplado) As List(Of beAcoplado)
        Dim olbeAcoplado As New List(Of beAcoplado)
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_CTRSPT", obeAcopladoFiltro.PNCTRSPT)
        objParam.Add("IN_NPLCAC", obeAcopladoFiltro.PSNPLCAC)

        objParam.Add("PAGESIZE", obeAcopladoFiltro.PageSize)
        objParam.Add("PAGENUMBER", obeAcopladoFiltro.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        'Return Listar("SP_SOLMIN_SA_AT_CAMION_LIST_X_TRANSPORTISTA", objParam)
        Return Listar("SP_SOLMIN_SA_AT_CAMION_LIST_X_TRANSPORTISTA_V2", objParam)


        'Catch ex As Exception
        'End Try
        Return olbeAcoplado
    End Function



    Public Function SP_SOLMIN_SA_SEL_ACOPLADO_AT(ByVal NPLCAC As String, ByVal CTRSPT As String) As beAcoplado
        Dim objbeAcoplado As beAcoplado = Nothing
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_NPLCAC", NPLCAC)
        objParametros.Add("PARAM_CTRSPT", CTRSPT)
        Try
            Dim dt As New DataTable
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SEL_ACOPLADO_AT", objParametros)
            If dt.Rows.Count > 0 Then
                objbeAcoplado = New beAcoplado

                objbeAcoplado.PNCTRSPT = dt.Rows(0)("CTRSPT").ToString
                objbeAcoplado.PSNPLCAC = dt.Rows(0)("NPLCAC").ToString
                objbeAcoplado.PSTCLRUN = dt.Rows(0)("TCLRUN").ToString
                objbeAcoplado.PNQPSTRA = dt.Rows(0)("QPSTRA").ToString
                objbeAcoplado.PNNEJSUN = dt.Rows(0)("NEJSUN").ToString
                objbeAcoplado.PNNCPCRU = dt.Rows(0)("NCPCRU").ToString
                objbeAcoplado.PSNSRCHU = dt.Rows(0)("NSRCHU").ToString
                objbeAcoplado.PNFFBRUN = dt.Rows(0)("FFBRUN").ToString
                objbeAcoplado.PNQLNGAC = dt.Rows(0)("QLNGAC").ToString
                objbeAcoplado.PNQANCAC = dt.Rows(0)("QANCAC").ToString
                objbeAcoplado.PNQALTAC = dt.Rows(0)("QALTAC").ToString
                objbeAcoplado.PNQVLTTR = dt.Rows(0)("QVLTTR").ToString
                objbeAcoplado.PSSESTUN = dt.Rows(0)("SESTUN").ToString
                objbeAcoplado.PSSTPOUN = dt.Rows(0)("STPOUN").ToString
                objbeAcoplado.PNFPRXDS = dt.Rows(0)("FPRXDS").ToString
                objbeAcoplado.PSTOBSIN = dt.Rows(0)("TOBSIN").ToString
                objbeAcoplado.PSSINPUN = dt.Rows(0)("SINPUN").ToString
                objbeAcoplado.PNFINPUN = dt.Rows(0)("FINPUN").ToString
                objbeAcoplado.PNCTPCRA = dt.Rows(0)("CTPCRA").ToString
                objbeAcoplado.PNFULTAC = dt.Rows(0)("FULTAC").ToString
                objbeAcoplado.PNHULTAC = dt.Rows(0)("HULTAC").ToString
                objbeAcoplado.PSCULUSA = dt.Rows(0)("CULUSA").ToString
                objbeAcoplado.PSNTRMNL = dt.Rows(0)("NTRMNL").ToString
                objbeAcoplado.PSCUSCRT = dt.Rows(0)("CUSCRT").ToString
                objbeAcoplado.PNFCHCRT = dt.Rows(0)("FCHCRT").ToString
                objbeAcoplado.PNHRACRT = dt.Rows(0)("HRACRT").ToString
                objbeAcoplado.PSNTRMCR = dt.Rows(0)("NTRMCR").ToString
                objbeAcoplado.PSNPLUNR = dt.Rows(0)("NPLUNR").ToString
                objbeAcoplado.PSNRGMT2 = dt.Rows(0)("NRGMT2").ToString
                objbeAcoplado.PSTCNFG2 = dt.Rows(0)("TCNFG2").ToString
                objbeAcoplado.PSTMRCVH = dt.Rows(0)("TMRCVH").ToString
                objbeAcoplado.PSNCRHB2 = dt.Rows(0)("NCRHB2").ToString
                objbeAcoplado.PNNORINS = dt.Rows(0)("NORINS").ToString
                objbeAcoplado.PNUPDATE_IDENT = dt.Rows(0)("UPDATE_IDENT").ToString
            End If
        Catch ex As Exception
            objbeAcoplado = Nothing
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return objbeAcoplado
    End Function



    Public Function SP_SOLMIN_SA_INS_ACOPLADO_AT(ByVal objBEAcoplado As beAcoplado) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intResultado As Integer = 1
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_CTRSPT", objBEAcoplado.PNCTRSPT)
        objParametros.Add("PARAM_NPLCAC", objBEAcoplado.PSNPLCAC)
        objParametros.Add("PARAM_FFBRUN", objBEAcoplado.PNFFBRUN)
        objParametros.Add("PARAM_NSRCHU", objBEAcoplado.PSNSRCHU)
        'objParametros.Add("PARAM_NSRMTU", objBECamion.PSNSRMTU)
        objParametros.Add("PARAM_NEJSUN", objBEAcoplado.PNNEJSUN)
        objParametros.Add("PARAM_TCLRUN", objBEAcoplado.PSTCLRUN)
        objParametros.Add("PARAM_NCPCRU", objBEAcoplado.PNNCPCRU)
        'objParametros.Add("PARAM_TMRCTR", objBECamion.PSTMRCTR)
        objParametros.Add("PARAM_NRGMT2", objBEAcoplado.PSNRGMT2)
        objParametros.Add("PARAM_TCNFG2", objBEAcoplado.PSTCNFG2)
        objParametros.Add("PARAM_FULTAC", objBEAcoplado.PNFULTAC)
        objParametros.Add("PARAM_HULTAC", objBEAcoplado.PNHULTAC)
        objParametros.Add("PARAM_CULUSA", objBEAcoplado.PSCULUSA)
        objParametros.Add("PARAM_NTRMNL", objBEAcoplado.PSNTRMNL)
        objParametros.Add("PARAM_SESTUN", objBEAcoplado.PSSESTUN)
        objParametros.Add("PARAM_UPID", objBEAcoplado.PNUPDATE_IDENT)

        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INS_ACOPLADO_AT", objParametros)
            intResultado = 1
        Catch ex As Exception
            intResultado = -1
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return intResultado
    End Function





    Public Function SP_SOLMIN_SA_UPD_ACOPLADO_AT(ByVal objBEAcoplado As beAcoplado) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intResultado As Integer = 1
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_CTRSPT", objBEAcoplado.PNCTRSPT)
        objParametros.Add("PARAM_NPLCAC", objBEAcoplado.PSNPLCAC)
        objParametros.Add("PARAM_FFBRUN", objBEAcoplado.PNFFBRUN)
        objParametros.Add("PARAM_NSRCHU", objBEAcoplado.PSNSRCHU)
        'objParametros.Add("PARAM_NSRMTU", objBECamion.PSNSRMTU)
        objParametros.Add("PARAM_NEJSUN", objBEAcoplado.PNNEJSUN)
        objParametros.Add("PARAM_TCLRUN", objBEAcoplado.PSTCLRUN)
        objParametros.Add("PARAM_NCPCRU", objBEAcoplado.PNNCPCRU)
        'objParametros.Add("PARAM_TMRCTR", objBECamion.PSTMRCTR)
        objParametros.Add("PARAM_NRGMT2", objBEAcoplado.PSNRGMT2)
        objParametros.Add("PARAM_TCNFG2", objBEAcoplado.PSTCNFG2)
        objParametros.Add("PARAM_FULTAC", objBEAcoplado.PNFULTAC)
        objParametros.Add("PARAM_HULTAC", objBEAcoplado.PNHULTAC)
        objParametros.Add("PARAM_CULUSA", objBEAcoplado.PSCULUSA)
        objParametros.Add("PARAM_NTRMNL", objBEAcoplado.PSNTRMNL)
        objParametros.Add("PARAM_SESTUN", objBEAcoplado.PSSESTUN)
        objParametros.Add("PARAM_UPID", objBEAcoplado.PNUPDATE_IDENT)

        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_UPD_ACOPLADO_AT", objParametros)
            intResultado = 1
        Catch ex As Exception
            intResultado = -1
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return intResultado
    End Function


    Public Function EliminarAcopladoAT(ByVal objBEAcoplado As beAcoplado) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", objBEAcoplado.PSCULUSA)
            objParam.Add("PSNTRMNL", objBEAcoplado.PSNTRMNL)
            objParam.Add("PNCTRSPT", objBEAcoplado.PNCTRSPT)
            objParam.Add("PSNPLCAC", objBEAcoplado.PSNPLCAC)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ACOPLADO_DELETE_AT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


#End Region




    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beAcoplado)

    End Sub
End Class
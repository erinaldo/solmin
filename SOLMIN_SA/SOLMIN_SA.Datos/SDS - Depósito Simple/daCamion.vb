

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daCamion
    Inherits daBase(Of beCamion)


    Public Function SP_SOLMIN_SA_SEL_CAMION(ByVal NPLCCM As String, ByVal CTRSP As String) As beCamion
        Dim objbecamion As beCamion = Nothing
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_NPLCCM", NPLCCM)
        objParametros.Add("PARAM_CTRSP", CTRSP)
        Try
            Dim dt As New DataTable
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SEL_CAMION", objParametros)
            If dt.Rows.Count > 0 Then
                objbecamion = New beCamion
                objbecamion.PNCTRSP = dt.Rows(0)("CTRSP").ToString
                objbecamion.PSNPLCCM = dt.Rows(0)("NPLCCM").ToString
                objbecamion.PNPTRCM = dt.Rows(0)("PTRCM").ToString
                objbecamion.PNNANOCM = dt.Rows(0)("NANOCM").ToString
                objbecamion.PSTMRCCM = dt.Rows(0)("TMRCCM").ToString
                objbecamion.PSNMTRCM = dt.Rows(0)("NMTRCM").ToString
                objbecamion.PSSESTCM = dt.Rows(0)("SESTCM").ToString
                objbecamion.PSNROPLA = dt.Rows(0)("NROPLA").ToString
                objbecamion.PSNBRVC1 = dt.Rows(0)("NBRVC1").ToString
                objbecamion.PSNPLCAC = dt.Rows(0)("NPLCAC").ToString
                objbecamion.PNNTRNLL = dt.Rows(0)("NTRNLL").ToString
                objbecamion.PNFASGTR = dt.Rows(0)("FASGTR").ToString
                objbecamion.PNHASGTR = dt.Rows(0)("HASGTR").ToString
                objbecamion.PSCULUSA = dt.Rows(0)("CULUSA").ToString
                objbecamion.PNHULTAC = dt.Rows(0)("HULTAC").ToString
                objbecamion.PNFULTAC = dt.Rows(0)("FULTAC").ToString
                objbecamion.PSNTRMNL = dt.Rows(0)("NTRMNL").ToString
                objbecamion.PNSESTRG = dt.Rows(0)("SESTRG").ToString
                objbecamion.PNUPID = dt.Rows(0)("UPDATE_IDENT").ToString
            End If
        Catch ex As Exception
            objbecamion = Nothing
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return objbecamion
    End Function



    Public Function SP_SOLMIN_SA_INS_CAMION(ByVal objBECamion As beCamion) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intResultado As Integer = 1
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_CTRSP", objBECamion.PNCTRSP)
        objParametros.Add("PARAM_NPLCCM", objBECamion.PSNPLCCM)
        objParametros.Add("PARAM_PTRCM", objBECamion.PNPTRCM)
        objParametros.Add("PARAM_NANOCM", objBECamion.PNNANOCM)
        objParametros.Add("PARAM_TMRCCM", objBECamion.PSTMRCCM)
        objParametros.Add("PARAM_NMTRCM", objBECamion.PSNMTRCM)
        objParametros.Add("PARAM_SESTCM", objBECamion.PSSESTCM)
        objParametros.Add("PARAM_NROPLA", objBECamion.PSNROPLA)
        objParametros.Add("PARAM_NBRVC1", objBECamion.PSNBRVC1)
        objParametros.Add("PARAM_NPLCAC", objBECamion.PSNPLCAC)
        objParametros.Add("PARAM_NRGMT1", objBECamion.PSNRGMT1)
        objParametros.Add("PARAM_NTRNLL", objBECamion.PNNTRNLL)
        objParametros.Add("PARAM_FASGTR", objBECamion.PNFASGTR)
        objParametros.Add("PARAM_HASGTR", objBECamion.PNHASGTR)
        objParametros.Add("PARAM_CULUSA", objBECamion.PSCULUSA)
        objParametros.Add("PARAM_HULTAC", objBECamion.PNHULTAC)
        objParametros.Add("PARAM_FULTAC", objBECamion.PNFULTAC)
        objParametros.Add("PARAM_NTRMNL", objBECamion.PSNTRMNL)
        objParametros.Add("PARAM_SESTRG", objBECamion.PNSESTRG)
        objParametros.Add("PARAM_UPID", objBECamion.PNUPID)

        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INS_CAMION", objParametros)
            intResultado = 1
        Catch ex As Exception
            intResultado = -1
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return intResultado
    End Function

    Public Function SP_SOLMIN_SA_UPD_CAMION(ByVal objBECamion As beCamion) As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim boolResultado As Boolean = True
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_CTRSP", objBECamion.PNCTRSP)
        objParametros.Add("PARAM_NPLCCM", objBECamion.PSNPLCCM)
        objParametros.Add("PARAM_PTRCM", objBECamion.PNPTRCM)
        objParametros.Add("PARAM_NANOCM", objBECamion.PNNANOCM)
        objParametros.Add("PARAM_TMRCCM", objBECamion.PSTMRCCM)
        objParametros.Add("PARAM_NMTRCM", objBECamion.PSNMTRCM)
        objParametros.Add("PARAM_SESTCM", objBECamion.PSSESTCM)
        objParametros.Add("PARAM_NROPLA", objBECamion.PSNROPLA)
        objParametros.Add("PARAM_NBRVC1", objBECamion.PSNBRVC1)
        objParametros.Add("PARAM_NPLCAC", objBECamion.PSNPLCAC)
        objParametros.Add("PARAM_NRGMT1", objBECamion.PSNRGMT1)
        objParametros.Add("PARAM_NTRNLL", objBECamion.PNNTRNLL)
        objParametros.Add("PARAM_FASGTR", objBECamion.PNFASGTR)
        objParametros.Add("PARAM_HASGTR", objBECamion.PNHASGTR)
        objParametros.Add("PARAM_CULUSA", objBECamion.PSCULUSA)
        objParametros.Add("PARAM_HULTAC", objBECamion.PNHULTAC)
        objParametros.Add("PARAM_FULTAC", objBECamion.PNFULTAC)
        objParametros.Add("PARAM_NTRMNL", objBECamion.PSNTRMNL)
        objParametros.Add("PARAM_SESTRG", objBECamion.PNSESTRG)
        objParametros.Add("PARAM_UPID", objBECamion.PNUPID)
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_UPD_CAMION", objParametros)
            boolResultado = True
        Catch ex As Exception
            boolResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return boolResultado
    End Function

    Public Function ListarCamionxTransportista(ByVal obeCamionFiltro As beCamionFiltro) As List(Of beCamion)
        Dim olbeCamion As New List(Of beCamion)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CTRSPSTR", obeCamionFiltro.CTRSPSTR)
            objParam.Add("PAGESIZE", obeCamionFiltro.PAGESIZE)
            objParam.Add("PAGENUMBER", obeCamionFiltro.PAGENUMBER)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_SDS_CAMION_LIST_X_TRANSPORTISTA", objParam)
        Catch ex As Exception
        End Try
        Return olbeCamion
    End Function
    ''' <summary>
    ''' Lista todos las unidades por transportista
    ''' </summary>
    ''' <param name="obeCamionFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function flisListarCamionxTransportista(ByVal obeCamionFiltro As beCamionFiltro) As List(Of beCamion)
        Dim olbeCamion As New List(Of beCamion)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CTRSPSTR", obeCamionFiltro.CTRSPSTR)
            Return Listar("SP_SOLMIN_SA_SDS_LIST_CAMION_X_TRANSPORTISTA", objParam)
        Catch ex As Exception
        End Try
        Return olbeCamion
    End Function

    Public Function EliminarCamion(ByVal obeCamion As beCamion) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", obeCamion.PSCULUSA)
            objParam.Add("PSNTRMNL", obeCamion.PSNTRMNL)
            objParam.Add("PNCTRSP", obeCamion.PNCTRSP)
            objParam.Add("PSNPLCCM", obeCamion.PSNPLCCM)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CAMION_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


#Region "Mantenimiento AT"

    Public Function ListarUnidadxTransportistaAT(ByVal obeCamionFiltro As beCamion) As List(Of beCamion)
        Dim olbeCamion As New List(Of beCamion)
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_CTRSPT", obeCamionFiltro.PNCTRSPT)
        objParam.Add("IN_NPLCUN", obeCamionFiltro.PSNPLCUN)


        objParam.Add("PAGESIZE", obeCamionFiltro.PageSize)
        objParam.Add("PAGENUMBER", obeCamionFiltro.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        'Return Listar("SP_SOLMIN_SA_AT_UNIDAD_LIST_X_TRANSPORTISTA", objParam)
        Return Listar("SP_SOLMIN_SA_AT_UNIDAD_LIST_X_TRANSPORTISTA_V2", objParam)
 
        'Catch ex As Exception
        'End Try
        Return olbeCamion
    End Function


    Public Function SP_SOLMIN_SA_SEL_CAMION_AT(ByVal NPLCUN As String, ByVal CTRSPT As String) As beCamion
        Dim objbecamion As beCamion = Nothing
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_NPLCUN", NPLCUN)
        objParametros.Add("PARAM_CTRSPT", CTRSPT)
        Try
            Dim dt As New DataTable
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SEL_CAMION_AT", objParametros)
            If dt.Rows.Count > 0 Then
                objbecamion = New beCamion
                objbecamion.PNCTRSPT = dt.Rows(0)("CTRSPT").ToString
                objbecamion.PSNPLCUN = dt.Rows(0)("NPLCUN").ToString
                objbecamion.PNNEJSUN = dt.Rows(0)("NEJSUN").ToString
                objbecamion.PSNSRCHU = dt.Rows(0)("NSRCHU").ToString
                objbecamion.PSNSRMTU = dt.Rows(0)("NSRMTU").ToString
                objbecamion.PNFFBRUN = dt.Rows(0)("FFBRUN").ToString
                objbecamion.PSTCLRUN = dt.Rows(0)("TCLRUN").ToString
                objbecamion.PSTCRRUN = dt.Rows(0)("TCRRUN").ToString
                objbecamion.PNNCPCRU = dt.Rows(0)("NCPCRU").ToString
                objbecamion.PNFINPUN = dt.Rows(0)("FINPUN").ToString
                objbecamion.PSSINPUN = dt.Rows(0)("SINPUN").ToString
                objbecamion.PSTOBSIN = dt.Rows(0)("TOBSIN").ToString
                objbecamion.PNFPRXDS = dt.Rows(0)("FPRXDS").ToString
                objbecamion.PSSTPOUN = dt.Rows(0)("STPOUN").ToString
                objbecamion.PSSESTUN = dt.Rows(0)("SESTUN").ToString
                objbecamion.PNQPSOTR = dt.Rows(0)("QPSOTR").ToString
                objbecamion.PNQVLTTR = dt.Rows(0)("QVLTTR").ToString
                objbecamion.PSSTMFRA = dt.Rows(0)("STMFRA").ToString
                objbecamion.PSTMRCTR = dt.Rows(0)("TMRCTR").ToString
                objbecamion.PSNPLCAC = dt.Rows(0)("NPLCAC").ToString
                objbecamion.PSCBRCNT = dt.Rows(0)("CBRCNT").ToString
                objbecamion.PNFULASG = dt.Rows(0)("FULASG").ToString
                objbecamion.PSSDCMPR = dt.Rows(0)("SDCMPR").ToString
                objbecamion.PSSUNVNR = dt.Rows(0)("SUNVNR").ToString
                objbecamion.PNFULTAC = dt.Rows(0)("FULTAC").ToString
                objbecamion.PNHULTAC = dt.Rows(0)("HULTAC").ToString
                objbecamion.PSCULUSA = dt.Rows(0)("CULUSA").ToString
                objbecamion.PSCUSCRT = dt.Rows(0)("CUSCRT").ToString
                objbecamion.PNFCHCRT = dt.Rows(0)("FCHCRT").ToString
                objbecamion.PNHRACRT = dt.Rows(0)("HRACRT").ToString
                objbecamion.PSNTRMCR = dt.Rows(0)("NTRMCR").ToString
                objbecamion.PNCIDMVL = dt.Rows(0)("CIDMVL").ToString
                objbecamion.PSSTPVHT = dt.Rows(0)("STPVHT").ToString
                objbecamion.PNQTCACT = dt.Rows(0)("QTCACT").ToString
                objbecamion.PNQTCANT = dt.Rows(0)("QTCANT").ToString
                objbecamion.PNNULGUN = dt.Rows(0)("NULGUN").ToString
                objbecamion.PSNRGMT1 = dt.Rows(0)("NRGMT1").ToString
                objbecamion.PSTCNFG1 = dt.Rows(0)("TCNFG1").ToString
                objbecamion.PNHRAINR = dt.Rows(0)("HRAINR").ToString
                objbecamion.PSSUSOVH = dt.Rows(0)("SUSOVH").ToString
                objbecamion.PSCTPUNV = dt.Rows(0)("CTPUNV").ToString
                objbecamion.PNCLVVEH = dt.Rows(0)("CLVVEH").ToString
                objbecamion.PSNCRHB1 = dt.Rows(0)("NCRHB1").ToString
                objbecamion.PNNORINS = dt.Rows(0)("NORINS").ToString
                objbecamion.PNUPDATE_IDENT = dt.Rows(0)("UPDATE_IDENT").ToString
            End If
        Catch ex As Exception
            objbecamion = Nothing
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return objbecamion
    End Function



    Public Function SP_SOLMIN_SA_UPD_CAMION_AT(ByVal objBECamion As beCamion) As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim boolResultado As Boolean = True
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_CTRSPT", objBECamion.PNCTRSPT)
        objParametros.Add("PARAM_NPLCUN", objBECamion.PSNPLCUN)
        objParametros.Add("PARAM_FFBRUN", objBECamion.PNFFBRUN)
        objParametros.Add("PARAM_NSRCHU", objBECamion.PSNSRCHU)
        objParametros.Add("PARAM_NSRMTU", objBECamion.PSNSRMTU)
        objParametros.Add("PARAM_NEJSUN", objBECamion.PNNEJSUN)
        objParametros.Add("PARAM_TCLRUN", objBECamion.PSTCLRUN)
        objParametros.Add("PARAM_NCPCRU", objBECamion.PNNCPCRU)
        objParametros.Add("PARAM_TMRCTR", objBECamion.PSTMRCTR)
        objParametros.Add("PARAM_NRGMT1", objBECamion.PSNRGMT1)
        objParametros.Add("PARAM_TCNFG1", objBECamion.PSTCNFG1)
        objParametros.Add("PARAM_FULTAC", objBECamion.PNFULTAC)
        objParametros.Add("PARAM_HULTAC", objBECamion.PNHULTAC)
        objParametros.Add("PARAM_CULUSA", objBECamion.PSCULUSA)
        objParametros.Add("PARAM_NTRMNL", objBECamion.PSNTRMNL)
        objParametros.Add("PARAM_SESTUN", objBECamion.PSSESTUN)
        objParametros.Add("PARAM_UPID", objBECamion.PNUPID)
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_UPD_CAMION_AT", objParametros)
            boolResultado = True
        Catch ex As Exception
            boolResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return boolResultado
    End Function



    Public Function SP_SOLMIN_SA_INS_CAMION_AT(ByVal objBECamion As beCamion) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intResultado As Integer = 1
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PARAM_CTRSPT", objBECamion.PNCTRSPT)
        objParametros.Add("PARAM_NPLCUN", objBECamion.PSNPLCUN)
        objParametros.Add("PARAM_FFBRUN", objBECamion.PNFFBRUN)
        objParametros.Add("PARAM_NSRCHU", objBECamion.PSNSRCHU)
        objParametros.Add("PARAM_NSRMTU", objBECamion.PSNSRMTU)
        objParametros.Add("PARAM_NEJSUN", objBECamion.PNNEJSUN)
        objParametros.Add("PARAM_TCLRUN", objBECamion.PSTCLRUN)
        objParametros.Add("PARAM_NCPCRU", objBECamion.PNNCPCRU)
        objParametros.Add("PARAM_TMRCTR", objBECamion.PSTMRCTR)
        objParametros.Add("PARAM_NRGMT1", objBECamion.PSNRGMT1)
        objParametros.Add("PARAM_TCNFG1", objBECamion.PSTCNFG1)
        objParametros.Add("PARAM_FULTAC", objBECamion.PNFULTAC)
        objParametros.Add("PARAM_HULTAC", objBECamion.PNHULTAC)
        objParametros.Add("PARAM_CULUSA", objBECamion.PSCULUSA)
        objParametros.Add("PARAM_NTRMNL", objBECamion.PSNTRMNL)
        objParametros.Add("PARAM_SESTUN", objBECamion.PSSESTUN)
        objParametros.Add("PARAM_UPID", objBECamion.PNUPID)

        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INS_CAMION_AT", objParametros)
            intResultado = 1
        Catch ex As Exception
            intResultado = -1
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return intResultado
    End Function


    Public Function EliminarCamion_AT(ByVal obeCamion As beCamion) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCULUSA", obeCamion.PSCULUSA)
            objParam.Add("PSNTRMNL", obeCamion.PSNTRMNL)
            objParam.Add("PNCTRSPT", obeCamion.PNCTRSPT)
            objParam.Add("PSNPLCUN", obeCamion.PSNPLCUN)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_CAMION_DELETE_AT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function



#End Region





    Public Overrides Sub SetStoredprocedures()

    End Sub
    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beCamion)

    End Sub

End Class

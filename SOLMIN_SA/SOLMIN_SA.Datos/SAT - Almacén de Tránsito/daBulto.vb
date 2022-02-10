Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF


Public Class daBulto
    Inherits daBase(Of beBulto)

    Private objSql As New SqlManager

    Public Function fintInsertarBulto(ByVal obeBulto As beBulto) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNFREFFW", Decimal.Parse(obeBulto.PNFREFFW))
            objParam.Add("PNFSLFFW", obeBulto.PNFSLFFW)
            objParam.Add("PSCBLTOR", obeBulto.PSCBLTOR)
            objParam.Add("PSCREEMB", obeBulto.PSCREEMB)
            objParam.Add("PSDESCWB", obeBulto.PSDESCWB)
            objParam.Add("PSTDSCIT", obeBulto.PSTDSCIT)
            objParam.Add("PNQREFFW", obeBulto.PNQREFFW)
            objParam.Add("PSTIPBTO", obeBulto.PSTIPBTO)
            objParam.Add("PNQPSOBL", obeBulto.PNQPSOBL)
            objParam.Add("PSTUNPSO", obeBulto.PSTUNPSO)
            objParam.Add("PNQVLBTO", obeBulto.PNQVLBTO)
            objParam.Add("PSTUNVOL", obeBulto.PSTUNVOL)
            objParam.Add("PNQAROCP", obeBulto.PNQAROCP)
            objParam.Add("PNQMTALT", obeBulto.PNQMTALT)
            objParam.Add("PNQMTANC", obeBulto.PNQMTANC)
            objParam.Add("PNQMTLRG", obeBulto.PNQMTLRG)
            objParam.Add("PSCTPALM", obeBulto.PSCTPALM)
            objParam.Add("PSCALMC", obeBulto.PSCALMC)
            objParam.Add("PSCZNALM", obeBulto.PSCZNALM)
            objParam.Add("PSTUBRFR", obeBulto.PSTUBRFR)
            objParam.Add("PNFINGAL", obeBulto.PNFINGAL)
            objParam.Add("PNFSLDAL", obeBulto.PNFSLDAL)
            objParam.Add("PNNROCTL", obeBulto.PNNROCTL)
            objParam.Add("PSSTRNSM", obeBulto.PSSTRNSM)
            objParam.Add("PNNORAGN", obeBulto.PNNORAGN)
            objParam.Add("PSSALTEM", obeBulto.PSSALTEM)
            objParam.Add("PSSMTRCP", obeBulto.PSSMTRCP)
            objParam.Add("PSSSNCRG", obeBulto.PSSSNCRG)
            objParam.Add("PSCRTLTE", obeBulto.PSCRTLTE)
            objParam.Add("PNNTCKPS", obeBulto.PNNTCKPS)
            objParam.Add("PSDCENSA", obeBulto.PSDCENSA)
            objParam.Add("PSSTPING", obeBulto.PSSTPING)
            objParam.Add("PNNOPREC", obeBulto.PNNOPREC)
            objParam.Add("PNNOPDES", obeBulto.PNNOPDES)
            objParam.Add("PNCMEDTS", obeBulto.PNCMEDTS)
            objParam.Add("PNCMEDTC", obeBulto.PNCMEDTC)
            objParam.Add("PSTCTCST", obeBulto.PSTCTCST)
            objParam.Add("PSTCTCSA", obeBulto.PSTCTCSA)
            objParam.Add("PSTCTCSF", obeBulto.PSTCTCSF)
            objParam.Add("PSTCTAFE", obeBulto.PSTCTAFE)
            objParam.Add("PSTLUGOR", obeBulto.PSTLUGOR)
            objParam.Add("PSTLUGEN", obeBulto.PSTLUGEN)
            objParam.Add("PSFLGCNL", obeBulto.PSFLGCNL)
            objParam.Add("PNFCNFCL", obeBulto.PNFCNFCL)
            objParam.Add("PNHCNFCL", obeBulto.PNHCNFCL)
            objParam.Add("PSSTPREC", obeBulto.PSSTPREC)
            objParam.Add("PSSTPDPC", obeBulto.PSSTPDPC)
            objParam.Add("PNFULFAC", obeBulto.PNFULFAC)
            objParam.Add("PSUSUARIO", obeBulto.PSCULUSA)
            objParam.Add("PNISPARCIAL", obeBulto.PNISPARCIAL)
            objParam.Add("PSSTPOCR", obeBulto.PSSTPOCR)
            objParam.Add("PSCPRCN1", obeBulto.PSCPRCN1)
            objParam.Add("PSNSRCN1", obeBulto.PSNSRCN1)
            objParam.Add("PSSESTRG", obeBulto.PSSESTRG)
            objParam.Add("PSNORCML", obeBulto.PSNORCML)
            objParam.Add("PSREFDO1", obeBulto.PSDSREFE)
            objParam.Add("PSCLSTRF", obeBulto.PSCLSTRF)
            objParam.Add("PSCCLRS", obeBulto.PSCCLRS)
            objParam.Add("PNFCHRMD", obeBulto.PNFCHRMD)
            'miguel 31.01.2014
            objParam.Add("PSTTPOMR", obeBulto.PSTTPOMR)
            'alberto 26.10.2018
            objParam.Add("PSTCTCAL", obeBulto.PSTCTCAL)

            'MPS
            objParam.Add("PSTPCARGA", obeBulto.PSTTPCRG)
            objParam.Add("PSNGRPRV", obeBulto.PSNGRPRV)
            objParam.Add("PSINCBLT", obeBulto.PSINCBLT)



            'OMVB REQ15072018 HORA DE ENTREGA
            objParam.Add("PNHORIDE", obeBulto.PNHORIDE)
            'OMVB REQ15072018 HORA DE ENTREGA


            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function fintActualizarBulto(ByVal obeBulto As beBulto) As Integer
        '   Try
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PNFREFFW", Decimal.Parse(obeBulto.PNFREFFW))
        objParam.Add("PNFSLFFW", obeBulto.PNFSLFFW)
        objParam.Add("PSCBLTOR", obeBulto.PSCBLTOR)
        objParam.Add("PSCREEMB", obeBulto.PSCREEMB)
        objParam.Add("PSDESCWB", obeBulto.PSDESCWB)
        objParam.Add("PSTDSCIT", obeBulto.PSTDSCIT)
        objParam.Add("PNQREFFW", obeBulto.PNQREFFW)
        objParam.Add("PSTIPBTO", obeBulto.PSTIPBTO)
        objParam.Add("PNQPSOBL", obeBulto.PNQPSOBL)
        objParam.Add("PSTUNPSO", obeBulto.PSTUNPSO)
        objParam.Add("PNQVLBTO", obeBulto.PNQVLBTO)
        objParam.Add("PSTUNVOL", obeBulto.PSTUNVOL)
        objParam.Add("PNQAROCP", obeBulto.PNQAROCP)
        objParam.Add("PNQMTALT", obeBulto.PNQMTALT)
        objParam.Add("PNQMTANC", obeBulto.PNQMTANC)
        objParam.Add("PNQMTLRG", obeBulto.PNQMTLRG)
        objParam.Add("PSCTPALM", obeBulto.PSCTPALM)
        objParam.Add("PSCALMC", obeBulto.PSCALMC)
        objParam.Add("PSCZNALM", obeBulto.PSCZNALM)
        objParam.Add("PSTUBRFR", obeBulto.PSTUBRFR)
        objParam.Add("PSSSTINV", obeBulto.PSSSTINV)
        objParam.Add("PNNGUIRM", obeBulto.PNNGUIRM)
        objParam.Add("PNNROCTL", obeBulto.PNNROCTL)
        objParam.Add("PSSTRNSM", obeBulto.PSSTRNSM)
        objParam.Add("PNNORAGN", obeBulto.PNNORAGN)
        objParam.Add("PSSALTEM", obeBulto.PSSALTEM)
        objParam.Add("PSSMTRCP", obeBulto.PSSMTRCP)
        objParam.Add("PSSSNCRG", obeBulto.PSSSNCRG)
        objParam.Add("PSCRTLTE", obeBulto.PSCRTLTE)
        objParam.Add("PNNTCKPS", obeBulto.PNNTCKPS)
        objParam.Add("PSDCENSA", obeBulto.PSDCENSA)
        objParam.Add("PSSTPING", obeBulto.PSSTPING)
        objParam.Add("PNNOPREC", obeBulto.PNNOPREC)
        objParam.Add("PNNOPDES", obeBulto.PNNOPDES)
        objParam.Add("PNCMEDTS", obeBulto.PNCMEDTS)
        objParam.Add("PSTCTCST", obeBulto.PSTCTCST)
        objParam.Add("PSTCTCSA", obeBulto.PSTCTCSA)
        objParam.Add("PSTCTCSF", obeBulto.PSTCTCSF)
        objParam.Add("PSTCTAFE", obeBulto.PSTCTAFE)

        objParam.Add("PSTLUGOR", obeBulto.PSTLUGOR)
        objParam.Add("PSTLUGEN", obeBulto.PSTLUGEN)


        objParam.Add("PSFLGCNL", obeBulto.PSFLGCNL)
        objParam.Add("PNFCNFCL", obeBulto.PNFCNFCL)
        objParam.Add("PNHCNFCL", obeBulto.PNHCNFCL)
        objParam.Add("PSSTPREC", obeBulto.PSSTPREC)
        objParam.Add("PSSTPDPC", obeBulto.PSSTPDPC)
        objParam.Add("PNFULFAC", obeBulto.PNFULFAC)
        objParam.Add("PSUSUARIO", obeBulto.PSCULUSA)
        objParam.Add("PSNORCML", obeBulto.PSNORCML)
        objParam.Add("PSNGRPRV", obeBulto.PSNGRPRV)
        objParam.Add("MEDIOENVIO", obeBulto.MEDIOENVIO)
        objParam.Add("PSSTPOCR", obeBulto.PSSTPOCR)
        objParam.Add("PSCPRCN1", obeBulto.PSCPRCN1)
        objParam.Add("PSNSRCN1", obeBulto.PSNSRCN1)
        objParam.Add("PSDSREFE", obeBulto.PSDSREFE)
        objParam.Add("PSCLSTRF", obeBulto.PSCLSTRF)
        objParam.Add("PSCCLRS", obeBulto.PSCCLRS)
        objParam.Add("PNFCHRMD", obeBulto.PNFCHRMD)

        'miguel 31.01.2014
        objParam.Add("PSTTPOMR", obeBulto.PSTTPOMR)
        '26102018 Alberto
        objParam.Add("PSTCTCAL", obeBulto.PSTCTCAL)
        'MPS
        objParam.Add("PSTPCARGA", obeBulto.PSTTPCRG)

        objParam.Add("PSINCBLT", obeBulto.PSINCBLT)

        'OMVB REQ15072019 HORA DE ENTREGA
        objParam.Add("PNHORIDE", obeBulto.PNHORIDE)
        'OMVB REQ15072019 HORA DE ENTREGA

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_BULTO_UPDATE", objParam)
        Return 1
        '  Catch ex As Exception
        '      Return 0
        ' End Try
    End Function

    Public Function fintConfirmarLlegada(ByVal obeBulto As beBulto) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)

            objParam.Add("PSFLGCNL", obeBulto.PSFLGCNL)
            objParam.Add("PNFCNFCL", obeBulto.PNFCNFCL)
            objParam.Add("PNHCNFCL", obeBulto.PNHCNFCL)
            objParam.Add("PSTOBSEN", obeBulto.PSTOBSEN)
            objParam.Add("PSCULUSA", obeBulto.PSCULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CONFIRMAR_LLEGADA", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function floObjtenerBulto(ByVal obeBulto As beBulto) As beBulto
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        olbebeBulto = Listar("SP_SOLMIN_SA_OBTENER_DATOS_BULTO", objParam)
        If olbebeBulto IsNot Nothing AndAlso olbebeBulto.Count > 0 Then
            Return olbebeBulto.Item(0)
        Else
            Return New beBulto
        End If
        'Return Listar("SP_SOLMIN_SA_OBTENER_DATOS_BULTO", objParam).Item(0)
        'Catch ex As Exception
        '    Return New beBulto
        'End Try
    End Function


    Public Function fbolProcesadoPorInterfaz(ByVal obeBulto As beBulto) As Integer
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREEMB", obeBulto.PSCREEMB)
            objParam.Add("PNEXISTE", 0, ParameterDirection.Output)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_BULTO_PROCESADO_POR_INTERFAZ", objParam)
            Return objSql.ParameterCollection("PNEXISTE")
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function fdtListaBultoIngresadosPoraExportarTxt(ByVal obeBulto As beBulto) As DataTable
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        'objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PSPLANTA", obeBulto.PSPLANTA)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)

        Return objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_BULTOS_INGRESADOS_PARA_EXPORTAR_TXT", objParam)

        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function

    Public Function fdtListaBultoDespachoParaExportarTxt(ByVal obeBulto As beBulto) As DataSet
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PSPLANTA", obeBulto.PSPLANTA)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PNNGUIRM", obeBulto.PNNGUIRM)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)

        Return objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_BULTOS_DESPACHO_PARA_EXPORTAR_TXT", objParam)

        'Catch ex As Exception
        '    Return New DataSet
        'End Try
    End Function

    Public Function ListarBultoPorPlanta(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        'objParam.Add("PNNGUIRM", obeBulto.PNNGUIRM)
        objParam.Add("PSNGUIRS", obeBulto.PSNGUIRS)

        'objParam.Add("PSNGUIRM", obeBulto.PSCREFFW)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNFECINI", obeBulto.PNFECINI)
        objParam.Add("PNFECFIN", obeBulto.PNFECFIN)
        objParam.Add("PNCODTRA", obeBulto.PNCODTRA)
        'objParam.Add("PNGUITRA", obeBulto.PNGUITRA)
        objParam.Add("PSNGUITS", obeBulto.PSNGUITS)
    
        'Return Listar("SP_SOLMIN_SA_SAT_LISTA_BULTO_POR_PLANTA", objParam)
        'Catch ex As Exception
        'End Try
        Dim objSqlManager As SqlManager = New SqlManager
        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_LISTA_BULTO_POR_PLANTA_V2", objParam)
        Dim beBulto As beBulto
        For Each item As DataRow In oDt.Rows
            beBulto = New beBulto
            
            beBulto.PSCCMPN = item("CCMPN")
            beBulto.PSCDVSN = item("CDVSN")
            beBulto.PNCPLNDV = item("CPLNDV")
            beBulto.PNCCLNT = item("CCLNT")
            beBulto.PSCREFFW = item("CREFFW")
            beBulto.PNFREFFW = ("" & item("FREFFW")).ToString.Trim
            beBulto.PNFSLFFW = item("FSLFFW")
            beBulto.PSCBLTOR = item("CBLTOR")
            beBulto.PSCREEMB = item("CREEMB")
            beBulto.PSDESCWB = item("DESCWB")
            beBulto.PSTDSCIT = item("TDSCIT")
            beBulto.PNQREFFW = item("QREFFW")
            beBulto.PSTIPBTO = item("TIPBTO")
            beBulto.PNQPSOBL = item("QPSOBL")
            beBulto.PSTUNPSO = item("TUNPSO")
            beBulto.PNQVLBTO = item("QVLBTO")
            beBulto.PSTUNVOL = item("TUNVOL")
            beBulto.PNQAROCP = item("QAROCP")
            beBulto.PNQMTALT = item("QMTALT")
            beBulto.PNQMTANC = item("QMTANC")
            beBulto.PNQMTLRG = item("QMTLRG")
            beBulto.PSCTPALM = item("CTPALM")
            beBulto.PSCALMC = item("CALMC")
            beBulto.PSCZNALM = item("CZNALM")
            beBulto.PSTUBRFR = item("TUBRFR")
            beBulto.PSSSTINV = item("SSTINV")
            beBulto.PNFINGAL = item("FINGAL")
            beBulto.PNFSLDAL = item("FSLDAL")
            beBulto.PNNROCTL = item("NROCTL")
            beBulto.PSSTRNSM = item("STRNSM")
            beBulto.PNNORAGN = item("NORAGN")
            beBulto.PSSALTEM = item("SALTEM")
            beBulto.PSSMTRCP = item("SMTRCP")
            beBulto.PSSSNCRG = item("SSNCRG")
            beBulto.PSCRTLTE = item("CRTLTE")
            beBulto.PNNTCKPS = item("NTCKPS")
            beBulto.PSDCENSA = item("DCENSA")
            beBulto.PSSTPING = item("STPING")
            beBulto.PNNOPREC = item("NOPREC")
            beBulto.PNNOPDES = item("NOPDES")
            beBulto.PNCMEDTS = item("CMEDTS")
            beBulto.PNCMEDTC = item("CMEDTC")
            beBulto.PSTCTCST = item("TCTCST")
            beBulto.PSTCTCSA = item("TCTCSA")
            beBulto.PSTCTCSF = item("TCTCSF")
            beBulto.PSFLGCNL = item("FLGCNL")
            beBulto.PNFCNFCL = item("FCNFCL")
            beBulto.PNHCNFCL = item("HCNFCL")
            beBulto.PSSTPREC = item("STPREC")
            beBulto.PSSTPDPC = item("STPDPC")
            'beBulto.PSFULFAC = item(FULFAC)
            beBulto.PNNSEQIN = item("NSEQIN")
            beBulto.PNNGUIRM = item("NGUIRM")
            beBulto.PSNGUIRS = item("NGUIRS")
            beBulto.PSNGRPRV = item("NGRPRV")
            beBulto.PSCTPALM_DES = item("CTPALM_DES")
            beBulto.PSCALMC_DES = item("CALMC_DES")
            beBulto.PSCZNALM_DES = item("CZNALM_DES")
            olbebeBulto.Add(beBulto)
        Next

        Return olbebeBulto
    End Function

    Public Function EliminarBulto(ByVal obeBultoPK As beBulto) As Integer
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeBultoPK.PSCCMPN)
            objParam.Add("PSCDVSN", obeBultoPK.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBultoPK.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBultoPK.PNCCLNT)
            objParam.Add("PSCREFFW", obeBultoPK.PSCREFFW)
            objParam.Add("PSCIDPAQ", obeBultoPK.PSCIDPAQ)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_BULTO_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListarDetalleBulto(ByVal obeBultoPK As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeBultoPK.PSCCMPN)
        objParam.Add("PSCDVSN", obeBultoPK.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBultoPK.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBultoPK.PNCCLNT)
        objParam.Add("PSCREFFW", obeBultoPK.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBultoPK.PNNSEQIN)
        Return Listar("SP_SOLMIN_SA_DETALLE_BULTO_LISTAR", objParam)
        'Catch ex As Exception
        'End Try
        Return olbebeBulto
    End Function

    'Dagnino 0/23/09/2015
    Public Function flListarDetalleBulto(ByVal obeBultoPK As beBulto) As DataTable
        Dim oDt As New DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeBultoPK.PSCCMPN)
        objParam.Add("PSCDVSN", obeBultoPK.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBultoPK.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBultoPK.PNCCLNT)
        objParam.Add("PSCREFFW", obeBultoPK.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBultoPK.PNNSEQIN)
        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_DETALLE_BULTO_LISTAR", objParam)
        oDt.TableName = obeBultoPK.PSCREFFW.ToString().Trim() + obeBultoPK.PSNRPDTS().ToString().Trim()
        Return oDt
        'Catch ex As Exception
        'End Try
        Return oDt
    End Function

    Public Function floInformacionItemBulto(ByVal obeBultoPK As beBulto) As beBulto
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeBultoPK.PSCCMPN)
        objParam.Add("PSCDVSN", obeBultoPK.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBultoPK.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBultoPK.PNCCLNT)
        objParam.Add("PSCREFFW", obeBultoPK.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBultoPK.PNNSEQIN)
        objParam.Add("PSCIDPAQ", obeBultoPK.PSCIDPAQ)
        Return Listar("SP_SOLMIN_SA_LISTA_INFORMACION_ITEM_BULTO", objParam).Item(0)
        'Catch ex As Exception
        '    Return New beBulto
        'End Try
    End Function



    ''' <summary>
    ''' Actualiza El campo  custodia
    ''' </summary>
    ''' <param name="obebulto ">Entidad Bulto</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    ''' 

    Public Function ActualizarCustodia(ByVal obebulto As beBulto) As Int32
        Dim objParametros As Parameter = Nothing
        objParametros = New Parameter
        ' Ingresamos los parametros del Procedure
        With obebulto
            objParametros.Add("IN_CCMPN", .PSCCMPN)
            objParametros.Add("IN_CDVSN", .PSCDVSN)
            objParametros.Add("IN_CPLNDV", .PNCPLNDV)
            objParametros.Add("IN_CCLNT", .PNCCLNT)
            objParametros.Add("IN_CREFFW", .PSCREFFW)
            objParametros.Add("IN_NSEQIN", .PNNSEQIN)
            objParametros.Add("IN_NORCML", .PSNORCML)
            objParametros.Add("IN_NRITOC", .PNNRITOC)
            objParametros.Add("IN_CIDPAQ", .PSCIDPAQ)
            objParametros.Add("IN_MARRET", .PSMARRET)
            objParametros.Add("IN_CULUSA", .PSCUSCRT)
            ' Registramos el Bulto asociado a la Paleta
            Try
                objSql.ExecuteNonQuery("SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_UPD_CUSTODIA", objParametros)
            Catch ex As Exception
                'sErrorMessage = "Error producido en la funcion : << Grabar >> de la clase << cItemWayBill >> " & vbNewLine & _
                '                "Tipo de Consulta : SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_UPD_CUSTODIA " & vbNewLine & _
                '                "Motivo del Error : " & ex.Message
                Return 0
            End Try
        End With
        Return 1
    End Function

    Public Function EliminarDetalleBulto(ByVal obeBultoPK As beBulto, ByRef strError As String) As Int32
        Dim objParametros As Parameter = Nothing
        objParametros = New Parameter
        ' Ingresamos los parametros del Procedure
        With obeBultoPK
            objParametros.Add("IN_CCMPN", .PSCCMPN)
            objParametros.Add("IN_CDVSN", .PSCDVSN)
            objParametros.Add("IN_CPLNDV", .PNCPLNDV)
            objParametros.Add("IN_CCLNT", .PNCCLNT)
            objParametros.Add("IN_CREFFW", .PSCREFFW)
            objParametros.Add("IN_CIDPAQ", .PSCIDPAQ)
            objParametros.Add("IN_NSEQIN", .PNNSEQIN)
            objParametros.Add("IN_USUARI", .PSCUSCRT)
            objParametros.Add("OU_MSGERR", 0, ParameterDirection.Output)
            ' Registramos el Bulto asociado a la Paleta
            Try
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_ITEM_DEL", objParametros)
                strError = objSql.ParameterCollection("OU_MSGERR")
            Catch ex As Exception
                Return 0
            End Try
        End With
        Return 1
    End Function

    Public Function listaPreDespacho(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        'If obeBulto.PNNROCTL = 0D Then
        '    Return Listar("SP_SOLMIN_SA_SAT_PRE_DESPACHO_LIST", objParam)
        'Else
        '    objParam.Add("PNNROCTL", obeBulto.PNNROCTL)
        '    Return Listar("SP_SOLMIN_SA_SAT_PRE_DESPACHO_LIST", objParam)
        'End If
        objParam.Add("PNNROCTL", obeBulto.PNNROCTL)
        Return Listar("SP_SOLMIN_SA_SAT_PRE_DESPACHO_LIST_V2", objParam)


        'Catch ex As Exception
        '    Return New List(Of beBulto)
        'End Try
    End Function


    Public Function listaBultosPorCodPreDespacho(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNNROCTL", obeBulto.PNNROCTL)
        Return Listar("SP_SOLMIN_SA_SAT_BULTOS_PRE_DESPACHO_LIST", objParam)
        'Catch ex As Exception
        '    Return New List(Of beBulto)
        'End Try


    End Function


    Public Function listaContenidoPorCodPreDespacho(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNNROCTL", obeBulto.PNNROCTL)


        Dim dt As New DataTable
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_BULTOS_PRE_DESPACHO_LIST_V2", objParam)
        Dim oBulto As beBulto
        Dim oList As New List(Of beBulto)
        For Each item As DataRow In dt.Rows
            oBulto = New beBulto
            oBulto.PSCREFFW = item("CREFFW")
            oBulto.PNNSEQIN = item("NSEQIN")
            oBulto.PSDESCWB = item("DESCWB")
            oBulto.PNFREFFW = item("FREFFW")

            oBulto.PNQREFFW = item("QREFFW")
            oBulto.PSTIPBTO = item("TIPBTO")

            oBulto.PNQPSOBL = item("QPSOBL")
            oBulto.PSTUNPSO = item("TUNPSO")
            oBulto.PSCCMPN = item("CCMPN")

            oBulto.PSCDVSN = item("CDVSN")
            oBulto.PNCPLNDV = item("CPLNDV")
            oBulto.PSCBLTOR = item("CBLTOR")
            'oBulto.PNNSEQIO = item("NSEQIO")
            oBulto.PNCCLNT = item("CCLNT")
            oBulto.PNNROPLT = item("NROPLT")
            oBulto.PSNRPLTS = item("NRPLTS")

            oBulto.PSFGLPRD = item("FGLPRD")

            oBulto.PSTLUGEN = item("TLUGEN")

           

            oList.Add(oBulto)
        Next

        Return oList
 


    End Function


    Public Function listaItemsDeBulto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        Return Listar("SP_SOLMIN_SA_SAT_ITEMS_BULTO_LIST", objParam)
        'Catch ex As Exception
        '    Return New List(Of beBulto)
        'End Try
    End Function

    Public Function listaRecepcionXFechaOperadorLogistico(ByVal obeBulto As beBulto, Optional ByRef NumPaginas As Int32 = 0) As DataTable

        Dim oDt As New DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        With objParametros
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_CCLNT", obeBulto.PNCCLNT)
            .Add("IN_CREFFW", obeBulto.PSCREFFW)
            .Add("IN_TIPMOV", obeBulto.PSTIPO)
            .Add("IN_FECINI", obeBulto.FECHA_INI)
            .Add("IN_FECFIN", obeBulto.FECHA_FIN)

            .Add("PAGESIZE", obeBulto.PageSize)
            .Add("PAGENUMBER", obeBulto.PageNumber)
            .Add("PAGECOUNT", NumPaginas, ParameterDirection.Output)
        End With

        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_CONSULTA_RECEPCION_X_FECHA_OPERADOR_LOGISTICO", objParametros)
        NumPaginas = objSqlManager.ParameterCollection("PAGECOUNT")
        Return oDt

    End Function


    Public Function listaExportarRecepcionXFechaOperadorlogistico(ByVal obeBulto As beBulto) As DataTable


        Dim oDt As New DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        With objParametros
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_CCLNT", obeBulto.PNCCLNT)
            .Add("IN_CREFFW", obeBulto.PSCREFFW)
            .Add("IN_TIPMOV", obeBulto.PSTIPO)
            .Add("IN_FECINI", obeBulto.FECHA_INI)
            .Add("IN_FECFIN", obeBulto.FECHA_FIN)

        End With

        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_LISTA_EXPORTAR_RECEPCION_X_FECHA_OPERADOR_LOGISTICO", objParametros)
        Return oDt

    End Function


    Public Function dtItemsDeBulto(ByVal obeBulto As beBulto) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_ITEMS_BULTO_LIST", objParam)
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function


    ''' <summary>
    ''' Listado de Sub Items en almacén
    ''' </summary>
    Public Function ListarBultoSubItemsOC(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", obeBulto.PNCCLNT)
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_CREFFW", obeBulto.PSCREFFW)
            .Add("IN_CIDPAQ", obeBulto.PSCIDPAQ)
            .Add("IN_NORCML", obeBulto.PSNORCML.Trim)
            .Add("IN_NRITOC", obeBulto.PNNRITOC)
        End With
        'Try
        Return Listar("SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_LIST", objParametros)
        'Catch ex As Exception
        '    Return New List(Of beBulto)
        'End Try
    End Function

    Public Function ExisteBultoParaPreDespacho(ByVal obeBulto As beBulto, ByRef strMensajeError As String) As Boolean
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PSCREFFW", obeBulto.PSCREFFW)
            .Add("PNEXISTE", 0, ParameterDirection.Output)
        End With
        Try
            objSql.ExecuteNonQuery("SP_SOLMIN_SAT_EXISTE_BULTO_PRE_DESPACHO", objParametros)
            Return objSql.ParameterCollection("PNEXISTE")
        Catch ex As Exception
            strMensajeError = ex.Message
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Elimina Bulto del predespacho
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <param name="strMensajeError"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarBultoPreDespachos(ByVal obeBulto As beBulto, ByRef strMensajeError As String) As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        strMensajeError = ""
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_NRCTRL", obeBulto.PNNRCTRL)
            .Add("IN_CCLNT", obeBulto.PNCCLNT)
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_CREFFW", obeBulto.PSCREFFW)
            .Add("IN_NSEQIN", obeBulto.PNNSEQIN)
            .Add("IN_USUARI", obeBulto.PSCUSCRT)
        End With


        'Try
        'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_DEL", objParametros)
        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_DEL_V2", objParametros)


        'Catch ex As Exception
        '    strMensajeError = "Error producido en la funcion : << fblnEliminar_BultoPreDespachos >> de la clase << clsPreDespacho >> " & vbNewLine & _
        '                      "Tipo de Consulta :  SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_DEL " & vbNewLine & _
        '                      "Motivo del Error : " & ex.Message
        '    blnResultado = False
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
        Return blnResultado
    End Function
    ''' <summary>
    ''' Lista de Movimiento de Item de OC
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarMovimientoItemOrdenCompra(ByVal obeBulto As beBulto) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        'Try
        With objParametros
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PSNORCML", obeBulto.PSNORCML)
        End With
        Dim dt As New DataTable
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTOS_OC_LM_V2", objParametros)
        For Each ITEM As DataRow In dt.Rows
            ITEM("FECDOC") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(ITEM("FECDOC"))
            ITEM("FCNFCL") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(ITEM("FCNFCL"))
            ITEM("HCNFCL") = RANSA.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(ITEM("HCNFCL"))

        Next

        Return dt
        '  Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTOS_OC_LM", objParametros)
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function
    Public Function ListarMovimientoItemOrdenCompra_v2(ByVal obeBulto As beBulto, Optional ByRef counter As Int32 = 0) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim tbResult As DataTable
        'Try
        With objParametros
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PSNORCML", obeBulto.PSNORCML)
            .Add("PAGESIZE", obeBulto.PageSize)
            .Add("PAGENUMBER", obeBulto.PageNumber)
            .Add("PAGECOUNT", counter, ParameterDirection.Output)
        End With
        tbResult = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTOS_OC_V2", objParametros)
        counter = objSqlManager.ParameterCollection("PAGECOUNT")
        Return tbResult
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function

    Public Function ListarMovimientoDetalle_X_ItemOrdenCompra(ByVal obeBulto As beBulto) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter

        'Try
        With objParametros
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PSNORCML", obeBulto.PSNORCML)
            .Add("IN_NRITOC", obeBulto.PNNRITOC)
        End With
        Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTOS_X_ITEM_OC", objParametros)
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function


    Public Function ListarGenerarEtiquetaBultoSAT(ByVal obeBulto As beBulto, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        strMensajeError = ""
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParam.Add("IN_CCLNT", obeBulto.PNCCLNT)
        objParam.Add("IN_CREFFW", obeBulto.PSCREFFW)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        Dim dtTemp As DataTable
        Try
            dtTemp = objSql.ExecuteDataTable("SP_SOLMIN_SA_AT_LISTA_GENERAR_ETIQUETA_BULTO", objParam)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnConsultaInformacion >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & "" & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            dtTemp = New DataTable
        Finally
            objSqlManager = Nothing
            objParam = Nothing
        End Try
        Return dtTemp
    End Function


    ''' <summary>
    ''' Envia Correo Cliente PlusPetrol
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EnviarCorreoPluspetrol(ByVal obeBulto As beBulto) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim strDivision As String = ""
        Dim strCliente As String = ""

        Try

            With objParametros
                .Add("PSCCMPN", obeBulto.PSCCMPN)
                .Add("PSCDVSN", obeBulto.PSCDVSN)
                If obeBulto.PNCPLNDV.ToString.Length < 3 Then

                    Select Case obeBulto.PNCPLNDV.ToString.Length
                        Case 1
                            strDivision = "00" & obeBulto.PNCPLNDV.ToString
                        Case 2
                            strDivision = "0" & obeBulto.PNCPLNDV.ToString
                    End Select
                Else
                    strDivision = obeBulto.PNCPLNDV.ToString
                End If

                If obeBulto.PNCCLNT.ToString.Length < 6 Then

                    Select Case obeBulto.PNCCLNT.ToString.Length
                        Case 1
                            strCliente = "00000" & obeBulto.PNCCLNT.ToString
                        Case 2
                            strCliente = "0000" & obeBulto.PNCCLNT.ToString
                        Case 3
                            strCliente = "000" & obeBulto.PNCCLNT.ToString
                        Case 4
                            strCliente = "00" & obeBulto.PNCCLNT.ToString
                        Case 5
                            strCliente = "0" & obeBulto.PNCCLNT.ToString
                    End Select
                Else
                    strCliente = obeBulto.PNCCLNT.ToString
                End If

                .Add("PNCPLNDV", strDivision)
                .Add("PNCCLNT", strCliente)
                .Add("PSCREFFW", obeBulto.PSCREFFW)


            End With
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_AS400_CL_RZMAIQ3", objParametros)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Copia Bultot de ¨Planta X a Planta Y
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CopyBultoDePlanta(ByVal obeBulto As beBulto) As Integer
        'Try
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNPLANDES", obeBulto.PNPLANDES)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PSCTPALM", obeBulto.PSCTPALM)
        objParam.Add("PSCALMC", obeBulto.PSCALMC)
        objParam.Add("PSCZNALM", obeBulto.PSCZNALM)
        objParam.Add("PSTUBRFR", obeBulto.PSTUBRFR)
        objParam.Add("PSFREFFW", obeBulto.PNFREFFW)
        objParam.Add("PSUSUARIO", obeBulto.PSUSUARIO)
        objParam.Add("PNEXISTE", 0, ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_COPY", objParam)
        Return objSql.ParameterCollection("PNEXISTE")
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function




    ''' <summary>
    ''' Busca el nr de guia de salida en otra planta del bulto Y si encuntra  genera guia de salida
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerGuiaSalidaPorCodPreDespacho(ByVal obeBulto As beBulto) As Decimal
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParametros.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParametros.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParametros.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParametros.Add("PNNROCTL", obeBulto.PNNROCTL)
        objParametros.Add("PSUSUARIO", obeBulto.PSUSUARIO)
        objParametros.Add("PNNRGUSA", 0, ParameterDirection.Output)
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_EXISTE_GUIA_SALIDA_X_PREDESPACHO", objParametros)
            Return objSqlManager.ParameterCollection("PNNRGUSA")
        Catch ex As Exception
            Return -1
        Finally
        End Try
    End Function

    ''' <summary>
    ''' Carga Obserciones Item OC
    ''' </summary>
    ''' <param name="filtro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function cargaObservacionesItemOC(ByVal filtro As Hashtable) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("PSCCMPN", filtro.Item("CCMPN"))
        objParametros.Add("PSCDVSN", filtro.Item("CDVSN"))
        objParametros.Add("PNCPLNDV", filtro.Item("CPLNDV"))
        objParametros.Add("PNCCLNT", filtro.Item("CCLNT"))
        objParametros.Add("PSCREFFW", filtro.Item("CREFFW"))
        objParametros.Add("PSNORCML", filtro.Item("NORCML"))
        objParametros.Add("PNNRITOC", filtro.Item("NRITOC"))
        Try
            Dim dt As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_DETALLE_BULTO_OC_OBSERVACIONES", objParametros)
            Return dt
        Catch ex As Exception
            Return Nothing
        Finally
        End Try
    End Function


    Public Function ActualizaObservacionesItemOC(ByVal filtro As Hashtable) As Integer
        Dim retorno As Int32 = 0
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PSCCMPN", filtro.Item("CCMPN"))
        objParametros.Add("PSCDVSN", filtro.Item("CDVSN"))
        objParametros.Add("PNCPLNDV", filtro.Item("CPLNDV"))
        objParametros.Add("PNCCLNT", filtro.Item("CCLNT"))
        objParametros.Add("PSCREFFW", filtro.Item("CREFFW"))
        objParametros.Add("PSNORCML", filtro.Item("NORCML"))
        objParametros.Add("PNNRITOC", filtro.Item("NRITOC"))
        objParametros.Add("PSTDAITM", filtro.Item("TDAITM"))
        objParametros.Add("PSCULUSA", filtro.Item("CULUSA"))
        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_DETALLE_BULTO_OC_OBSERVACIONES", objParametros)
        retorno = 1
        Return retorno
    End Function


    Public Function EliminaTodosObservacionesItemOC(ByVal filtro As Hashtable) As Integer
        Dim retorno As Int32 = 0
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("PSCCMPN", filtro.Item("CCMPN"))
        objParametros.Add("PSCDVSN", filtro.Item("CDVSN"))
        objParametros.Add("PNCPLNDV", filtro.Item("CPLNDV"))
        objParametros.Add("PNCCLNT", filtro.Item("CCLNT"))
        objParametros.Add("PSCREFFW", filtro.Item("CREFFW"))
        objParametros.Add("PSNORCML", filtro.Item("NORCML"))
        objParametros.Add("PNNRITOC", filtro.Item("NRITOC"))
        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ELIMINAR_DETALLE_BULTO_OC_OBSERVACIONES", objParametros)
        retorno = 1
        Return retorno
    End Function


    Public Function RealizarTrasladoBultoItemOC(ByVal obeBulto As beBulto) As Integer
        Dim retorno As Int32 = 0
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        objParametros.Add("IN_CCLNT ", obeBulto.PNCCLNT)
        objParametros.Add("IN_CREFFW", obeBulto.PSCREFFW)
        objParametros.Add("IN_NSEQIN", obeBulto.PNNSEQIN)
        objParametros.Add("IN_CCMPN", obeBulto.PSCCMPN)
        objParametros.Add("IN_CDVSN", obeBulto.PSCDVSN)
        objParametros.Add("IN_CPLNDV", obeBulto.PNCPLNDV)
        objParametros.Add("IN_QBLTSR", obeBulto.PNQBLTSR)
        objParametros.Add("IN_NORCML_ORIGEN", obeBulto.PSNORCML)
        objParametros.Add("IN_NRITOC_ORIGEN", obeBulto.PNNRITOC)
        objParametros.Add("IN_NORCML_DESTINO", obeBulto.PSNORCML_DESTINO)
        objParametros.Add("IN_NRITOC_DESTINO", obeBulto.PNNRITOC_DESTINO)
        objParametros.Add("IN_CIDPAQ", obeBulto.PSCIDPAQ)
        objParametros.Add("IN_USUARI", obeBulto.PSCULUSA)
        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_ITEM_BULTO_TRASLADO_OC", objParametros)
        retorno = 1
        Return retorno
    End Function


    Public Function RollbackInsertBulto(ByVal obeBulto As beBulto) As Decimal
        Dim objSqlManager As SqlManager = New SqlManager
        Dim strError As String = ""
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParametros.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParametros.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParametros.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParametros.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParametros.Add("PSUSUARI", obeBulto.PSUSUARIO)
        objParametros.Add("OU_MSGERR", 0, ParameterDirection.Output)
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_ROLLBACK_INSERT_BULTO", objParametros)
            strError = objSqlManager.ParameterCollection("OU_MSGERR")
            If strError.ToString.Length > 0 Then
                Return -1
            Else
                Return 0
            End If
        Catch ex As Exception
            Return -1
        Finally
        End Try
    End Function


    Public Function ActualizarBulto_Repaking_Origen(ByVal obeBulto As beBulto) As Integer
        'Try
        Dim objParam As New Parameter
        Dim retorno As Integer = 0
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PNQREFFW", obeBulto.PNQREFFW)
        objParam.Add("PNQPSOBL", obeBulto.PNQPSOBL)
        objParam.Add("PNQVLBTO", obeBulto.PNQVLBTO)
        objParam.Add("PNQAROCP", obeBulto.PNQAROCP)
        objParam.Add("PSCULUSA", obeBulto.PSUSUARIO)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_BULTO_UPDATE_REPAKING", objParam)
        Return 1
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function

    Public Function ListaImprimirEtiquetaBulto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        Dim oListaBulto As New List(Of beBulto)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        oListaBulto = Listar("SP_SOLMIN_SA_SAT_LISTA_IMPRIMIR_ETIQUETA_BULTO", objParam)
        Return oListaBulto
        'Catch ex As Exception
        '    Return New List(Of beBulto)
        'End Try
    End Function

    Public Function ListaTamanhoCliente_Bulto_Mineria() As Integer
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        Dim dt As DataTable = TraerDataTable("SP_SOLMIN_SA_SAT_LISTA_IMPRIMIR_TAMANHO_CLIENTE_BULTO", Nothing)
        Return Convert.ToInt32(dt.Rows(0)("VALOR"))
        'Catch ex As Exception
        '    Return Nothing
        'End Try
    End Function

    ''' <summary>
    ''' Lista de detalle de 
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaImprimirEtiquetaBultoDetalle(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
            Return Listar("SP_SOLMIN_SA_SAT_LISTA_IMPRIMIR_ETIQUETA_BULTO_DETALLE", objParam)
        Catch ex As Exception
            MsgBox("cae en consulta")
            Return New List(Of beBulto)
        End Try
    End Function

#Region "MANTENIMIENTO DETALLE BULTO"

    ''' <summary>
    ''' Guardar el deatlle del bulto
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InsertarDetalleBulto(ByVal obeBulto As beBulto) As String
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PSNORCML", obeBulto.PSNORCML)
        objParam.Add("PNNRITOC", obeBulto.PNNRITOC)
        objParam.Add("PSNFACPR", obeBulto.PSNFACPR)
        objParam.Add("PNFFACPR", obeBulto.PNFFACPR)
        objParam.Add("PSNGRPRV", obeBulto.PSNGRPRV)
        objParam.Add("PNQBLTSR", obeBulto.PNQBLTSR)
        objParam.Add("PNQPEPQT", obeBulto.PNQPEPQT)
        objParam.Add("PSTUNPSO", obeBulto.PSTUNPSO)
        objParam.Add("IN_QVOPQT", obeBulto.PNQVOPQT)
        objParam.Add("IN_TUNVOL", obeBulto.PSTUNVOL)
        objParam.Add("IN_TDAITM", obeBulto.PSTDAITM)
        objParam.Add("IN_USUARI", obeBulto.PSUSUARIO)
        If obeBulto.PSTIPO.Trim.ToUpper.Equals("DEVOLUCION") Then
            objParam.Add("IN_ESTADO", obeBulto.PSTIPO)
        End If
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("OU_CIDPAQ", "", ParameterDirection.Output)
        'CSR-HUNDRED-051016-MATERIALES-PELIGROSOS-INICIO
        objParam.Add("IN_CMATPE", obeBulto.PSDES_CND)
        objParam.Add("IN_FGIQBF", obeBulto.PSFGIQBF)
        objParam.Add("IN_CCLMAT", obeBulto.PSDES_CLASE)
        objParam.Add("IN_CPRFUN", obeBulto.IN_CPRFUN)
        objParam.Add("IN_CUNMAT", obeBulto.PSCUNMAT)
        objParam.Add("IN_FCHCAD", obeBulto.PSFCHCAD)
        'CSR-HUNDRED-051016-MATERIALES-PELIGROSOS-FIN
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_BULTO_INSET", objParam)
        Return objSql.ParameterCollection("OU_CIDPAQ").ToString
        'Catch ex As Exception
        '    Return ""
        'End Try
    End Function

    Public Function ActualizarDetalleBulto(ByVal obeBulto As beBulto) As String
        Dim objParam As New Parameter
        'Try

        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PSNORCML", obeBulto.PSNORCML)
        objParam.Add("PNNRITOC", obeBulto.PNNRITOC)
        objParam.Add("PSNFACPR", obeBulto.PSNFACPR)
        objParam.Add("PNFFACPR", obeBulto.PNFFACPR)
        objParam.Add("PSNGRPRV", obeBulto.PSNGRPRV)
        objParam.Add("PNQBLTSR", obeBulto.PNQBLTSR)
        objParam.Add("PNQPEPQT", obeBulto.PNQPEPQT)
        objParam.Add("PSTUNPSO", obeBulto.PSTUNPSO)
        objParam.Add("IN_QVOPQT", obeBulto.PNQVOPQT)
        objParam.Add("IN_TUNVOL", obeBulto.PSTUNVOL)
        objParam.Add("IN_TDAITM", obeBulto.PSTDAITM)
        objParam.Add("IN_USUARI", obeBulto.PSUSUARIO)
        If obeBulto.PSTIPO.Trim.ToUpper.Equals("DEVOLUCION") Then
            objParam.Add("IN_ESTADO", obeBulto.PSTIPO)
        End If
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("in_CIDPAQ", obeBulto.PSCIDPAQ)
        'CSR-HUNDRED-051016-MATERIALES-PELIGROSOS-INICIO
        objParam.Add("IN_CMATPE", obeBulto.PSDES_CND)
        objParam.Add("IN_FGIQBF", obeBulto.PSFGIQBF)
        objParam.Add("IN_CCLMAT", obeBulto.PSDES_CLASE)
        objParam.Add("IN_CPRFUN", obeBulto.IN_CPRFUN)
        objParam.Add("IN_CUNMAT", obeBulto.PSCUNMAT)
        objParam.Add("IN_FCHCAD", obeBulto.PSFCHCAD)
        'CSR-HUNDRED-051016-MATERIALES-PELIGROSOS-FIN

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_BULTO_UPDATE", objParam)
        Return obeBulto.PSCIDPAQ
        'Catch ex As Exception
        '    Return ""
        'End Try
    End Function


#End Region

#Region "CONSULTA Y REPORTE"

    ''' <summary>
    ''' Listado de Inventario Por Bulto
    ''' </summary>
    Public Function ListarCargaRecepcionada_CentroCosto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("FE_INI", obeBulto.FECHA_INI)
            .Add("FE_FIN", obeBulto.FECHA_FIN)
            '.Add("PSNORCML", obeBulto.PSNORCML)
            '.Add("PSTLUGEN", obeBulto.PSTLUGEN.Trim)

        End With
        Try
            Return Listar("SP_SOLMIN_SA_LISTA_CARGA_RECEPCIONADA_CENTRO_COSTO", objParametros)
        Catch ex As Exception
            Return New List(Of beBulto)
        End Try
    End Function

    ''' <summary>
    ''' Lista de bultos sin paginar para exportar excel 
    ''' </summary>
    Public Function ListarBultoALL(ByVal obeBulto As beBulto) As DataTable
        Dim objParametros As Parameter = New Parameter
        Dim dt As New DataTable
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", obeBulto.PNCCLNT)
            .Add("IN_CREFFW", obeBulto.PSCREFFW)
            .Add("IN_NROPLT", obeBulto.PNNROPLT)
            .Add("IN_FECINI", obeBulto.PNFECINI)
            .Add("IN_FECFIN", obeBulto.PNFECFIN)
            .Add("IN_TTINTC", obeBulto.PSTTINTC)
            .Add("IN_SSTINV", obeBulto.PSSSTINV)
            .Add("IN_TUBRFR", obeBulto.PSTUBRFR)
            .Add("IN_STRNSM", obeBulto.PSSTRNSM)
            .Add("IN_STPING", obeBulto.PSSTPING)
            .Add("IN_CRTLTE", obeBulto.PSCRTLTE)
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_FLGCNL", obeBulto.PSFLGCNL)
            .Add("IN_NGRPRV", obeBulto.PSNGRPRV)
            .Add("IN_NORCML", obeBulto.PSNORCML)
            .Add("IN_SSNCRG", obeBulto.PSSSNCRG)
        End With
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SAT_CONSULTA_DE_BULTO_ALL", objParametros)
        For Each item As DataRow In dt.Rows
            item("HORIDE") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HORIDE"))
        Next
        Return dt
        'Try
        '    Return
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function


    Public Function ListarBultoInventario(ByVal obeBulto As beBulto) As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", obeBulto.PSCODCLIE)
            .Add("IN_CREFFW", obeBulto.PSCREFFW)
            .Add("IN_NROPLT", obeBulto.PNNROPLT)
            .Add("IN_FECINI", obeBulto.PNFECINI)
            .Add("IN_FECFIN", obeBulto.PNFECFIN)
            .Add("IN_TUBRFR", obeBulto.PSTUBRFR)
            .Add("IN_STRNSM", obeBulto.PSSTRNSM)
            .Add("IN_CRTLTE", obeBulto.PSCRTLTE)
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_SSNCRG", obeBulto.PSSSNCRG)
        End With


        Try
            Return objSql.ExecuteDataTable("SP_SOLMIN_SAT_CONSULTA_DE_INVENTARIO_BULTO", objParametros)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function ListarBultoInventarioGP(ByVal obeBulto As beBulto) As DataTable
        Dim objParametros As Parameter = New Parameter
        Dim dt As New DataTable
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", obeBulto.PSCODCLIE)
            .Add("IN_CREFFW", obeBulto.PSCREFFW)
            .Add("IN_NROPLT", obeBulto.PNNROPLT)
            .Add("IN_FECINI", obeBulto.PNFECINI)
            .Add("IN_FECFIN", obeBulto.PNFECFIN)
            .Add("IN_TUBRFR", obeBulto.PSTUBRFR)
            .Add("IN_STRNSM", obeBulto.PSSTRNSM)
            .Add("IN_CRTLTE", obeBulto.PSCRTLTE)
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_SSNCRG", obeBulto.PSSSNCRG)
        End With
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SAT_CONSULTA_DE_INVENTARIO_BULTO_GP", objParametros)
        For Each item As DataRow In dt.Rows
            item("HORIDE") = RANSA.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HORIDE"))
        Next

        'Try
        Return dt
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function

    ''' <summary>
    ''' Lista de inventario de distintas plantas
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarBultoInventarioAll(ByVal obeBulto As beBulto) As DataTable
        Dim objParametros As Parameter = New Parameter
        'Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PSCPLNDV", obeBulto.PSPLANTA)
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSUSUARIO", obeBulto.PSUSUARIO)
            .Add("PSSENTIDO", obeBulto.PSSSNCRG)
            .Add("PNFECFIN", obeBulto.PNFECFIN)
        End With
        Try
            Return objSql.ExecuteDataTable("SP_SOLMIN_SAT_INVENTARIO_BULTO_ALL_V1", objParametros)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function ProcesarRecojo(ByRef obeBulto As beBulto) As Decimal
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure

        objParametros.Add("IN_CCMPN", obeBulto.PSCCMPN)
        objParametros.Add("IN_CDVSN", obeBulto.PSCDVSN)
        objParametros.Add("IN_CPLNDV", obeBulto.PNCPLNDV)
        objParametros.Add("IN_CCLNT", obeBulto.PNCCLNT)
        objParametros.Add("IN_CREFFW", obeBulto.PSCREFFW)
        objParametros.Add("IN_SMTRCP", obeBulto.PSSMTRCP)
        objParametros.Add("IN_TOBSGS", obeBulto.PSTOBSGS)
        objParametros.Add("IN_TOBDGS", obeBulto.PSTOBDGS)
        objParametros.Add("IN_CTRSPT", obeBulto.PNCTRSPT)
        objParametros.Add("IN_NPLCUN", obeBulto.PSNPLCUN)
        objParametros.Add("IN_NPLCAC", obeBulto.PSNPLCAC)
        objParametros.Add("IN_CBRCNT", obeBulto.PSCBRCNT)
        objParametros.Add("IN_STPOCM", obeBulto.PSSTPOCM)
        objParametros.Add("IN_NTCKPS", obeBulto.PNNTCKPS)
        objParametros.Add("IN_STPDSP", obeBulto.PSSTPDSP)
        objParametros.Add("IN_USUARI", obeBulto.PSUSUARIO)
        objParametros.Add("OU_NRGUSA", 0, ParameterDirection.Output)
        objParametros.Add("OU_MSGERR", 0, ParameterDirection.Output)
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_GUIA_SALIDA_RECOJO_INS", objParametros)
            obeBulto.PSERROR = objSqlManager.ParameterCollection("OU_MSGERR")
            Return objSqlManager.ParameterCollection("OU_NRGUSA")
        Catch ex As Exception
            Return -1
        Finally
        End Try
    End Function

#End Region

#Region "Interfaz Sap"

    Public Function fdtListaBultoParaTransferir(ByVal obeBulto As beBulto, ByRef strError As String) As DataTable
        Dim objParametros As Parameter = New Parameter
        Dim oDt As New DataTable
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSDCENSA", obeBulto.PSDCENSA)
            .Add("PSERROR", "", ParameterDirection.Output)
        End With

        'Try
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_LISTA_BULTOS_TRANSFERIR_SAP", objParametros)
        strError = objSql.ParameterCollection.Item("PSERROR")
        'Catch ex As Exception
        '    strError = "-1"
        'End Try
        Return oDt
    End Function

    Public Function fintRealizarTransferenciaBulto(ByRef obeBulto As beBulto) As Int32
        Dim objParametros As Parameter = New Parameter
        Dim oDt As New DataTable
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_DCENSA", obeBulto.PSDCENSA)
            .Add("IN_NUMDES", obeBulto.PSNUMDES)
            .Add("IN_CCLNT", obeBulto.PNCCLNT)
            .Add("IN_CCMPN", obeBulto.PSCCMPN)
            .Add("IN_CDVSN", obeBulto.PSCDVSN)
            .Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            .Add("IN_USUARI", obeBulto.PSUSUARIO)
            .Add("OUT_CREFFW", "", ParameterDirection.Output)
        End With

        'Try
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_INTERFAZ_BULTO_SAP", objParametros)
        obeBulto.PSCREFFW = objSql.ParameterCollection.Item("OUT_CREFFW")
        'Catch ex As Exception
        '    Return -1
        'End Try
        Return 1
    End Function

#End Region


#Region "DETALLE BULTO"

    Public Function fintInsertarBultoDetalleCarga(ByVal obeBulto As beBulto) As Integer
        '  Try
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PNQCTPQT", obeBulto.PNQCTPQT)
        objParam.Add("PNQMTLRG", obeBulto.PNQMTLRG)
        objParam.Add("PNQMTALT", obeBulto.PNQMTALT)
        objParam.Add("PNQMTANC", obeBulto.PNQMTANC)
        objParam.Add("PNQVOLMR", obeBulto.PNQVOLMR)
        objParam.Add("PNQPSOMR", obeBulto.PNQPSOMR)
        objParam.Add("PSUSUARIO", obeBulto.PSUSUARIO)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA__INSERTAR_DETALLE_CARGA_BULTO", objParam)
        Return 1
        ' Catch ex As Exception
        ' Return 0
        ' End Try
    End Function


    Public Function fintInsertarBultoDetalleCargaRepacking(ByVal obeBulto As beBulto) As Integer
        '  Try
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PNNCRRINOR", obeBulto.PNNCRRINOR)
        objParam.Add("PSCBLTOR", obeBulto.PSCBLTOR)      
        objParam.Add("PNQCTPQT", obeBulto.PNQCTPQT)
        objParam.Add("PNQMTLRG", obeBulto.PNQMTLRG)
        objParam.Add("PNQMTALT", obeBulto.PNQMTALT)
        objParam.Add("PNQMTANC", obeBulto.PNQMTANC)
        objParam.Add("PNQVOLMR", obeBulto.PNQVOLMR)
        objParam.Add("PNQPSOMR", obeBulto.PNQPSOMR)
        objParam.Add("PSUSUARIO", obeBulto.PSUSUARIO)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_INSERTAR_DETALLE_CARGA_BULTO_REPACKING", objParam)
        Return 1
        ' Catch ex As Exception
        ' Return 0
        ' End Try
    End Function


    Public Function fintActualizarBultoDetalleCarga(ByVal obeBulto As beBulto) As Integer
        '  Try
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        objParam.Add("PNNCRRIN", obeBulto.PNNCRRIN)
        objParam.Add("PNQCTPQT", obeBulto.PNQCTPQT)
        objParam.Add("PNQMTLRG", obeBulto.PNQMTLRG)
        objParam.Add("PNQMTALT", obeBulto.PNQMTALT)
        objParam.Add("PNQMTANC", obeBulto.PNQMTANC)
        objParam.Add("PNQPSOMR", obeBulto.PNQPSOMR)
        objParam.Add("PSUSUARIO", obeBulto.PSUSUARIO)
        objParam.Add("PSSESTRG", obeBulto.PSSESTRG)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA__ACTUALIZAR_DETALLE_CARGA_BULTO", objParam)
        Return 1
        ' Catch ex As Exception
        ' Return 0
        ' End Try
    End Function


    Public Function flistListarBultoDetalleCarga(ByVal obeBulto As beBulto) As List(Of beBulto)
        'Try
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
        objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
        objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
        Return Listar("SP_SOLMIN_SA__LISTAR_DETALLE_CARGA_BULTO", objParam)
        'Catch ex As Exception
        '    Return New List(Of beBulto)
        'End Try
    End Function

#End Region
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beBulto)

    End Sub


    ''Miguel 31.01.2014

    Public Function ObtenerCorreoPara(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try

            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PNTIPPROC", obeBulto.PNTIPPROC)



            Return Listar("SP_SOLMIN_SA_SAT_BULTO_EMAIL", objParam)
        Catch ex As Exception

        End Try
        Return olbebeBulto
    End Function

    Public Function ObtenerCorreoAsunto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try

            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)


            Return Listar("SP_SOLMIN_SA_SAT_BULTO_EMAIL_ASUNTO", objParam)
        Catch ex As Exception

        End Try
        Return olbebeBulto
    End Function


    Public Function ObtenerCorreosDocAdjunto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim oDt As New DataTable
        Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try

            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)

            Return Listar("SP_SOLMIN_SA_SAT_BULTO_EMAIL_DOCADJ", objParam)
        Catch ex As Exception

        End Try
        Return olbebeBulto
    End Function

    'Dagnino 11.9.2015
    Public Function ListaValidarClienteParaConfirmacion(ByVal codigoCliente As Integer) As DataTable
        Dim oDt As New DataTable
        'Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CODVAR", "CLREWS")
            objParam.Add("IN_CCLNT", codigoCliente)

            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", objParam)

        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function ListaInfoBulto(ByVal obeBulto As beBulto) As DataTable
        Dim oDt As New DataTable
        'Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)


            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_RECEPCION_ENVIAR_WS", objParam)

        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function ActualizarEstadoEnvio(ByVal obeBulto As beBulto) As Boolean
        Dim oDt As New DataTable
        'Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNNSEQIN", obeBulto.PNNSEQIN)
            objParam.Add("PSSTRNSM", obeBulto.PSSTRNSM)
            objParam.Add("PSDCENSA", obeBulto.PSDCENSA)
            objParam.Add("PSCULUSA", obeBulto.PSCULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_ESTADO_ENVIO_RECEPCION_WS", objParam)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Dagnino 11.9.2015
    Public Function ObtenerBultoPedidoTraslado(ByVal obeBulto As beBulto) As DataTable
        Dim oDt As DataTable
        'Dim olbebeBulto As New List(Of beBulto)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCMPN", obeBulto.PSCCMPN)
            objParam.Add("IN_CDVSN", obeBulto.PSCDVSN)
            objParam.Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("IN_CCLNT", obeBulto.PNCCLNT)
            objParam.Add("IN_NRPDTS", obeBulto.PSNRPDTS)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_BULTOS_POR_PEDIDO_TRASLADO", objParam)
            oDt.TableName = obeBulto.PSNRPDTS.ToString()
            Return oDt
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function ActualizarDetalleBultoPedidoTraslado(ByVal obeBulto As beBulto) As String
        Dim objParam As New Parameter
        Try

            objParam.Add("IN_CCMPN", obeBulto.PSCCMPN)
            objParam.Add("IN_CDVSN", obeBulto.PSCDVSN)
            objParam.Add("IN_CPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("IN_CCLNT", obeBulto.PNCCLNT)
            objParam.Add("IN_CREFFW", obeBulto.PSCREFFW)
            objParam.Add("IN_CIDPAQ", obeBulto.PSCIDPAQ)
            objParam.Add("IN_NSEQIN", obeBulto.PNNSEQIN)
            objParam.Add("IN_NORCML", obeBulto.PSNORCML)
            objParam.Add("IN_NRITOC", obeBulto.PNNRITOC)
            objParam.Add("IN_NRPDTS", obeBulto.PSNRPDTS)
            objParam.Add("IN_NROSEC", obeBulto.PSNROSEC)
            objParam.Add("IN_QBLTSR", obeBulto.PNQBLTSR)
            objParam.Add("IN_CLARSG", obeBulto.CLARSG)
            objParam.Add("IN_NROONU", obeBulto.NROONU)
            objParam.Add("IN_TPOEMB", obeBulto.TPOEMB)
            objParam.Add("IN_USUARI", obeBulto.PSUSUARIO)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_PEDIDO_TRASLADO_DETALLE_BULTO_UPDATE", objParam)
            Return obeBulto.PSCIDPAQ
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

 
    Public Function ListaRecepcionEnviarWS(ByVal obeBulto As beBulto) As DataTable


        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        Try
            objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParam.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParam.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParam.Add("PNSEQUIN", obeBulto.PNNSEQIN)

            Dim dt As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_RECEPCION_ENVIAR_WS", objParam)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Function ActualizarEstadoEnvioRecepcionWS(ByVal obeBulto As beBulto) As Boolean
        Dim retorno As Boolean
        Try
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros.Add("PSCCMPN", obeBulto.PSCCMPN)
            objParametros.Add("PSCDVSN", obeBulto.PSCDVSN)
            objParametros.Add("PNCPLNDV", obeBulto.PNCPLNDV)
            objParametros.Add("PNCCLNT", obeBulto.PNCCLNT)
            objParametros.Add("PSCREFFW", obeBulto.PSCREFFW)
            objParametros.Add("PNSEQUIN", obeBulto.PNNSEQIN)
            objParametros.Add("PSCULUSA", obeBulto.PSCULUSA)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_ESTADO_ENVIO_RECEPCION_WS ", objParametros)
            ' retornoestado de envió Web Service.
            retorno = True
        Catch ex As Exception

            retorno = False
        End Try
        Return retorno
    End Function

    Public Function VerificarClienteHabilitado(ByVal intCCLNT As Integer) As Boolean

        Dim obeParam As New beGeneral
        Dim odaGeneral As New daGeneral
        obeParam.PSCODVAR = "CLREWS"
        obeParam.PSCCMPRN = intCCLNT.ToString
        If odaGeneral.ListaTablaAyuda(obeParam).Count > 0 Then
            Return True

        Else
            Return False

        End If
    End Function


    Public Function ValidarBloqueoCredito(ByVal codigoCompania As String, ByVal codCliente As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", codigoCompania)
        lobjParams.Add("PNCCLNT", codCliente)

        Return lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LIMITE_CREDITO_LIBERADO", lobjParams)
    End Function


    Public Function ValidarLimiteCredito(ByVal codigoCompania As String, ByVal codCliente As String) As DataTable

        Dim dt As DataTable = New DataTable()

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Dim PARAM_FLGSF1 As String = ""
        Dim PARAM_FLGSF2 As String = ""
        Dim PARAM_FLGSF3 As String = ""
        Dim PARAM_FLGSF4 As String = ""
        Dim PARAM_CDDRSP As String = ""




        lobjParams.Add("PARAM_CCMPN", codigoCompania)
        lobjParams.Add("PARAM_CCLNT", codCliente.PadLeft(6, "0"), ParameterDirection.InputOutput)
        lobjParams.Add("PARAM_ ACCC", "2511")
        lobjParams.Add("PARAM_ ITTPGD", "0.00")
        lobjParams.Add("PARAM_FLGSF1", "", ParameterDirection.InputOutput)
        lobjParams.Add("PARAM_FLGSF2", "", ParameterDirection.InputOutput)
        lobjParams.Add("PARAM_FLGSF3", "", ParameterDirection.InputOutput)
        lobjParams.Add("PARAM_FLGSF4", "", ParameterDirection.InputOutput)
        lobjParams.Add("PARAM_FLGSF5", "", ParameterDirection.InputOutput)


        lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP111", lobjParams)


        dt.Columns.Add("PARAM_CDDRSP", Type.GetType("System.String"))
        dt.Columns.Add("PARAM_FLGSF1", Type.GetType("System.String"))
        dt.Columns.Add("PARAM_FLGSF2", Type.GetType("System.String"))
        dt.Columns.Add("PARAM_FLGSF3", Type.GetType("System.String"))
        dt.Columns.Add("PARAM_FLGSF4", Type.GetType("System.String"))
        dt.Columns.Add("PARAM_FLGSF5", Type.GetType("System.String"))






        dt.Rows.Add()
        dt.Rows(0)("PARAM_CDDRSP") = lobjParams.Item(2).Value
        dt.Rows(0)("PARAM_FLGSF1") = lobjParams.Item(5).Value
        dt.Rows(0)("PARAM_FLGSF2") = lobjParams.Item(6).Value
        dt.Rows(0)("PARAM_FLGSF3") = lobjParams.Item(7).Value
        dt.Rows(0)("PARAM_FLGSF4") = lobjParams.Item(8).Value
        dt.Rows(0)("PARAM_FLGSF5") = lobjParams.Item(9).Value

        Return dt
    End Function


End Class


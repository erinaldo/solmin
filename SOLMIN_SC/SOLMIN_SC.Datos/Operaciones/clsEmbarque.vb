Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsEmbarque
    Public Function Lista_Embarque(ByVal pdblCli As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Embarque_Aduana(ByVal oFiltroEmbarque As beSeguimientoCargaFiltro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oFiltroEmbarque.PSCCMPN)
        lobjParams.Add("PNCCLNT", oFiltroEmbarque.PNCCLNT)
        lobjParams.Add("PNFECINI", oFiltroEmbarque.PNFECINI)
        lobjParams.Add("PNFECFIN", oFiltroEmbarque.PNFECFIN)
        lobjParams.Add("PSNORCML", oFiltroEmbarque.PSNORCML)
        lobjParams.Add("PSCPRVCL", oFiltroEmbarque.PSCPRVCL)
        lobjParams.Add("PSPNNMOS", oFiltroEmbarque.PSPNNMOS)
        lobjParams.Add("PSDOCEMB", oFiltroEmbarque.PSDOCEMB)
        lobjParams.Add("PSNORSCI", oFiltroEmbarque.PSNORSCI)
        lobjParams.Add("PSSESTRG", oFiltroEmbarque.PSSESTRG)
        lobjParams.Add("PSTPSRVA", oFiltroEmbarque.PSTPSRVA)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_EMBARQUE_ADUANA_AJUSTE", lobjParams)
        Return dt
    End Function


    Public Function Lista_Detalle_OC_Embarque(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DETALLE_OC_EMBARQUE", lobjParams)
        Return dt
    End Function


    Public Function Lista_Detalle_OC_Embarque_Ajuste(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DETALLE_OC_EMBARQUE_AJUSTE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Costos_OC_X_Embarque(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_COSTOS_OC_X_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Detalle_OC_Embarque_ABB(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DETALLE_OC_EMBARQUE_ABB", lobjParams)
        Return dt
    End Function

    Public Function Lista_Detalle_OC_Embarque_ABB_Cambio_CheckPoint(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DETALLE_OC_EMBARQUE_ABB_X_CAMBIO_CHECKPOINT", lobjParams)
        Return dt
    End Function

    '


    Public Function Datos_Embarque_VB(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As beDatosEmbarque
        Dim obeDatosEmbarque_BE As New beDatosEmbarque
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_EMBARQUE_VB_LISTA", lobjParams)
        If dt.Rows.Count = 0 Then
            obeDatosEmbarque_BE = Nothing
        Else
            obeDatosEmbarque_BE.PNNORSCI = dt.Rows(0)("NORSCI")
            obeDatosEmbarque_BE.PSNOREMB = HelpClass.ToStringCvr(dt.Rows(0)("NOREMB"))
            obeDatosEmbarque_BE.PNCTRSPT = HelpClass.ToDecimalCvr(dt.Rows(0)("CTRSPT"))
            obeDatosEmbarque_BE.PNALM_LOCAL = HelpClass.ToDecimalCvr(dt.Rows(0)("ALMLOCAL"))
            obeDatosEmbarque_BE.PSCTRMAL = HelpClass.ToStringCvr(dt.Rows(0)("CTRMAL"))
            obeDatosEmbarque_BE.PNCAGNCR = HelpClass.ToDecimalCvr(dt.Rows(0)("CAGNCR"))
            obeDatosEmbarque_BE.PSSESTRG = HelpClass.ToStringCvr(dt.Rows(0)("SESTRG"))
            obeDatosEmbarque_BE.PNPNNMOS = HelpClass.ToDecimalCvr(dt.Rows(0)("PNNMOS"))
            obeDatosEmbarque_BE.PNCZNFCC = HelpClass.ToDecimalCvr(dt.Rows(0)("CZNFCC"))
            obeDatosEmbarque_BE.PSFORSCI = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FORSCI"))
            obeDatosEmbarque_BE.PSNORCML = HelpClass.ToStringCvr(dt.Rows(0)("NORCML"))
            obeDatosEmbarque_BE.PNCPRVCL = HelpClass.ToDecimalCvr(dt.Rows(0)("CPRVCL"))
            obeDatosEmbarque_BE.PSREFDO1 = HelpClass.ToStringCvr(dt.Rows(0)("REFDO1"))
            obeDatosEmbarque_BE.PSNREFCL = HelpClass.ToStringCvr(dt.Rows(0)("NREFCL"))
            obeDatosEmbarque_BE.PSNDOCEM = HelpClass.ToStringCvr(dt.Rows(0)("NDOCEM"))
            obeDatosEmbarque_BE.PSTOBERV = HelpClass.ToStringCvr(dt.Rows(0)("TOBERV"))
            obeDatosEmbarque_BE.PNCMEDTR = HelpClass.ToDecimalCvr(dt.Rows(0)("CMEDTR"))
            obeDatosEmbarque_BE.PNCCIANV = HelpClass.ToDecimalCvr(dt.Rows(0)("CCIANV"))
            obeDatosEmbarque_BE.PSTNMCTT = HelpClass.ToStringCvr(dt.Rows(0)("TNMCTT"))
            obeDatosEmbarque_BE.PSTBFTRB = HelpClass.ToStringCvr(dt.Rows(0)("TBFTRB"))
            obeDatosEmbarque_BE.PSTDRENT = HelpClass.ToStringCvr(dt.Rows(0)("TDRENT"))
            obeDatosEmbarque_BE.PSHORATN = HelpClass.ToStringCvr(dt.Rows(0)("HORATN"))
            obeDatosEmbarque_BE.PSTPRSCN = HelpClass.ToStringCvr(dt.Rows(0)("TPRSCN"))
            obeDatosEmbarque_BE.PSTRECOR = HelpClass.ToStringCvr(dt.Rows(0)("TRECOR"))
            obeDatosEmbarque_BE.PNCCIANV = HelpClass.ToDecimalCvr(dt.Rows(0)("CCIANV"))
            obeDatosEmbarque_BE.PSCVPRCN = HelpClass.ToStringCvr(dt.Rows(0)("CVPRCN"))
            obeDatosEmbarque_BE.PNCPAIS = HelpClass.ToDecimalCvr(dt.Rows(0)("CPAIS"))
            obeDatosEmbarque_BE.PNCPAIS_DESTINO = HelpClass.ToDecimalCvr(dt.Rows(0)("CPAIS1"))
            obeDatosEmbarque_BE.PSCPRTOE = HelpClass.ToStringCvr(dt.Rows(0)("CPRTOE"))
            obeDatosEmbarque_BE.PSCPRTOA = HelpClass.ToStringCvr(dt.Rows(0)("CPRTOA"))
            obeDatosEmbarque_BE.PSFAPREV = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FAPREV"))
            obeDatosEmbarque_BE.PSFAPRAR = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FAPRAR"))
            obeDatosEmbarque_BE.PSTCANAL = HelpClass.ToStringCvr(dt.Rows(0)("TCANAL"))
            obeDatosEmbarque_BE.PSTNRODU = HelpClass.ToStringCvr(dt.Rows(0)("TNRODU"))
            obeDatosEmbarque_BE.PNTRANSPORTE = HelpClass.ToDecimalCvr(dt.Rows(0)("TRANSPORTE"))
            obeDatosEmbarque_BE.PNNCODRG_DESPACHO = HelpClass.ToDecimalCvr(dt.Rows(0)("TIPODESPACHO"))
            obeDatosEmbarque_BE.PSTERCERO = HelpClass.ToStringCvr(dt.Rows(0)("TERCERO"))
            obeDatosEmbarque_BE.PSTPSRVA = HelpClass.ToStringCvr(dt.Rows(0)("TPSRVA"))
            obeDatosEmbarque_BE.PSTCMTSR = String.Format("{0} - {1}", HelpClass.ToStringCvr(dt.Rows(0)("TPSRVA")), HelpClass.ToStringCvr(dt.Rows(0)("TCMTSR")))
            obeDatosEmbarque_BE.PNNORSCO_REG = dt.Rows(0)("NORSCO_REG")
            obeDatosEmbarque_BE.PNTPORGE = dt.Rows(0)("TPORGE")
            obeDatosEmbarque_BE.PNTPOPRG = dt.Rows(0)("TPOPRG")
            obeDatosEmbarque_BE.PSTCMRGA = HelpClass.ToStringCvr(dt.Rows(0)("TCMRGA"))
            obeDatosEmbarque_BE.PSFTRORS_REG = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FTRORS_REG"))
            obeDatosEmbarque_BE.PSFCEMSN = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FCEMSN"))
            obeDatosEmbarque_BE.PNQPSOAR = HelpClass.ToDecimalCvr(dt.Rows(0)("QPSOAR"))
            obeDatosEmbarque_BE.PNQVOLMR = HelpClass.ToDecimalCvr(dt.Rows(0)("QVOLMR"))
            obeDatosEmbarque_BE.PNNDIALB = HelpClass.ToDecimalCvr(dt.Rows(0)("NDIALB"))
            obeDatosEmbarque_BE.PNNDIASE = HelpClass.ToDecimalCvr(dt.Rows(0)("NDIASE"))
            obeDatosEmbarque_BE.PNCAGNAD = dt.Rows(0)("CAGNAD")
            obeDatosEmbarque_BE.PSTRSPCL = HelpClass.ToStringCvr(dt.Rows(0)("TRSPCL"))
            obeDatosEmbarque_BE.PSTRSPRN = HelpClass.ToStringCvr(dt.Rows(0)("TRSPRN"))

            If (dt.Rows(0)("SESTRG") = "C") Then
                obeDatosEmbarque_BE.PSSESTRG_DESC = "CERRADA"
            Else
                obeDatosEmbarque_BE.PSSESTRG_DESC = "EN ATENCIÓN"
            End If
            obeDatosEmbarque_BE.PSFTRTSG = HelpClass.ToStringCvr(dt.Rows(0)("FTRTSG"))

        End If
        Return obeDatosEmbarque_BE
    End Function

    Public Function Datos_Forol(ByVal PNNORSCI As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_FOROL", lobjParams)
        Return dt
    End Function

    Public Function Mantenimiento_Datos_Embarque_VB(ByVal obeDatosEmbarque As beDatosEmbarque) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeDatosEmbarque.PNNORSCI)
        lobjParams.Add("PNFORSCI", obeDatosEmbarque.PNFORSCI)
        lobjParams.Add("PSNOREMB", obeDatosEmbarque.PSNOREMB)
        lobjParams.Add("PNCCIANV", obeDatosEmbarque.PNCCIANV)
        lobjParams.Add("PSCVPRCN", obeDatosEmbarque.PSCVPRCN)
        lobjParams.Add("PNCPAIS", obeDatosEmbarque.PNCPAIS)
        lobjParams.Add("PNCPAISDESTINO", obeDatosEmbarque.PNCPAIS_DESTINO)
        lobjParams.Add("PSCPRTOE", obeDatosEmbarque.PSCPRTOE)
        lobjParams.Add("PSCPRTOA", obeDatosEmbarque.PSCPRTOA)
        lobjParams.Add("PSCTRMAL", obeDatosEmbarque.PSCTRMAL)
        lobjParams.Add("PNCAGNCR", obeDatosEmbarque.PNCAGNCR)
        lobjParams.Add("PNCMEDTR", obeDatosEmbarque.PNCMEDTR)

        lobjParams.Add("PNQVOLMR", obeDatosEmbarque.PNQVOLMR)
        lobjParams.Add("PNNDIALB", obeDatosEmbarque.PNNDIALB)
        lobjParams.Add("PNNDIASE", obeDatosEmbarque.PNNDIASE)
        lobjParams.Add("PNQPSOAR", obeDatosEmbarque.PNQPSOAR)

        lobjParams.Add("PSTRSPCL", obeDatosEmbarque.PSTRSPCL)
        lobjParams.Add("PSTRSPRN", obeDatosEmbarque.PSTRSPRN)

        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)

        lobjParams.Add("PSFTRTSG", obeDatosEmbarque.PSFTRTSG)

        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_DATOS_EMBARQUE_VB", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function Mantenimiento_Datos_Forol_Completo(ByVal obeDatosEmbarque As beDatosEmbarque) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeDatosEmbarque.PNNORSCI)
        lobjParams.Add("PNPNNMOS", obeDatosEmbarque.PNPNNMOS)
        lobjParams.Add("PNCZNFCC", obeDatosEmbarque.PNCZNFCC)
        lobjParams.Add("PNFCEMSN", obeDatosEmbarque.PNFCEMSN)
        lobjParams.Add("PSREFDO1", obeDatosEmbarque.PSREFDO1)
        lobjParams.Add("PSTOBERV", obeDatosEmbarque.PSTOBERV)
        lobjParams.Add("PNNCODRG_TRANSPORTE", obeDatosEmbarque.PNTRANSPORTE)
        lobjParams.Add("PSTNMCTT", obeDatosEmbarque.PSTNMCTT)
        lobjParams.Add("PSTBFTRB", obeDatosEmbarque.PSTBFTRB)
        lobjParams.Add("PSTDRENT", obeDatosEmbarque.PSTDRENT)
        lobjParams.Add("PSHORATN", obeDatosEmbarque.PSHORATN)
        lobjParams.Add("PSTPRSCN", obeDatosEmbarque.PSTPRSCN)
        lobjParams.Add("PSTRECOR", obeDatosEmbarque.PSTRECOR)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNCTRSPT", obeDatosEmbarque.PNCTRSPT)
        lobjParams.Add("PNNCODRG_ALM_LOCAL", obeDatosEmbarque.PNALM_LOCAL)
        lobjParams.Add("PNTPORGE", obeDatosEmbarque.PNTPORGE)
        lobjParams.Add("PNTPOPRG", obeDatosEmbarque.PNTPOPRG)
        lobjParams.Add("PSTCANAL", obeDatosEmbarque.PSTCANAL)
        lobjParams.Add("PSTNRODU", obeDatosEmbarque.PSTNRODU)
        lobjParams.Add("PNDESPACHO", obeDatosEmbarque.PNNCODRG_DESPACHO) 'despacho
        lobjParams.Add("PNCPRVCL", obeDatosEmbarque.PNCPRVCL) 'proveedor
        lobjParams.Add("PSNREFCL", obeDatosEmbarque.PSNREFCL) 'REFERENCIA CLIENTE
        lobjParams.Add("PNFTRORS", obeDatosEmbarque.PNFTRORS_REG) '
        lobjParams.Add("PNNORSCO", obeDatosEmbarque.PNNORSCO_REG) '
        lobjParams.Add("PNCAGNAD", obeDatosEmbarque.PNCAGNAD) '
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_DATOS_FOROL_COMPLETO", lobjParams)
        retorno = 1
        Return retorno
    End Function


    Public Sub Actualiza_Agente_Carga(ByVal PNNORSCI As Double, ByVal PNCAGNCR As Decimal)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCAGNCR", PNCAGNCR)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_AGENTE_CARGA", lobjParams)
    End Sub


    Public Sub Actualiza_Regimen(ByVal pdblEmbarque As Double, ByVal pdblRegimen As Double)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNNCODRG", pdblRegimen)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_REGIMEN", lobjParams)
       
    End Sub

    Public Sub Actualiza_Despacho(ByVal pdblEmbarque As Double, ByVal pdblDespacho As Double)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNNCODRG", pdblDespacho)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_DESPACHO", lobjParams)
      
    End Sub


   

    Public Sub Actualiza_Canal(ByVal pdblEmbarque As Double, ByVal pdblOS As Double, ByVal pstrCanal As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNPNNMOS", pdblOS)
        lobjParams.Add("PSTCANAL", pstrCanal)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_CANAL", lobjParams)
      
    End Sub

    Public Sub Actualiza_DUA(ByVal pdblEmbarque As Double, ByVal pdblOS As Double, ByVal pstrDUA As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNPNNMOS", pdblOS)
        lobjParams.Add("PSTNRODU", pstrDUA)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_DUA", lobjParams)
    End Sub

    Public Sub Actualiza_Status_Embarque(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal obeCheckPoint As beCheckPoint)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNNORSCI", obeCheckPoint.PNNORSCI)
        lobjParams.Add("PNNESTDO", obeCheckPoint.PNNESTDO)
        lobjParams.Add("PNFESEST", obeCheckPoint.PNFESEST)
        lobjParams.Add("PNFRETES", obeCheckPoint.PNFRETES)
        lobjParams.Add("PSTOBS", obeCheckPoint.PSTOBS)
        lobjParams.Add("PSCEMB", obeCheckPoint.PSCEMB)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_STATUS_EMBARQUE", lobjParams)
    End Sub


    Public Sub Actualiza_Checkpoint_Embarque_General(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal obeCheckPoint As beCheckPoint)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNNORSCI", obeCheckPoint.PNNORSCI)
        lobjParams.Add("PNNESTDO", obeCheckPoint.PNNESTDO)
        lobjParams.Add("PNFESEST", obeCheckPoint.PNFESEST)
        lobjParams.Add("PNFRETES", obeCheckPoint.PNFRETES)
        lobjParams.Add("PSTOBS", obeCheckPoint.PSTOBS)
        lobjParams.Add("PSCEMB", obeCheckPoint.PSCEMB)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNHRAEST", obeCheckPoint.PNHRAEST)
        lobjParams.Add("PNHRAREA", obeCheckPoint.PNHRAREA)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_CHEKCPOINT_EMBARQUE_GENERAL", lobjParams)

    End Sub


    Public Sub Actualiza_Observaciones(ByVal obeObservacion As beObservacionCarga)
        Dim oSqlMan As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeObservacion.PNNORSCI)
        lobjParams.Add("PNNRITEM", obeObservacion.PNNRITEM)
        lobjParams.Add("PNTFCOBS", obeObservacion.PNTFCOBS)
        lobjParams.Add("PSTOBS", obeObservacion.PSTOBS)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_ACT_EMB_OBS", lobjParams)
    End Sub


    Public Sub Actualiza_Carga(ByVal obeCargaEmbarque As beDetalleCargaInternacional)
        Dim oSqlMan As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeCargaEmbarque.PNNORSCI)
        lobjParams.Add("PNNCODRG", obeCargaEmbarque.PNNCODRG)
        lobjParams.Add("PNQCANTI", obeCargaEmbarque.PNQCANTI)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECINI", obeCargaEmbarque.PNFECINI)
        lobjParams.Add("PNFECVEN", obeCargaEmbarque.PNFECVEN)

        oSqlMan.ExecuteNonQuery("SP_SOLSC_ACT_EMB_CARGA", lobjParams)
    End Sub

    Public Sub Actualiza_Proforma(ByVal pdblEmbarque As Double, ByVal pstrProforma As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSTEXTO", pstrProforma)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_PROFORMA", lobjParams)

    End Sub

    Public Sub Actualiza_Tipo_Transporte(ByVal PNNORSCI As Double, ByVal PSTEXTO As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSTEXTO", PSTEXTO)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_TIPO_TRANSPORTE", lobjParams)

    End Sub

    Public Sub Actualiza_Doc_Pendiente(ByVal PNNORSCI As Double, ByVal PSTEXTO As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSTEXTO", PSTEXTO)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMB_DOC_PENDIENTE", lobjParams)

    End Sub

    Public Sub Eliminar_Observaciones_X_Item(ByVal PNNORSCI As Decimal, ByVal PNNRITEM As Decimal)
        Dim oSqlMan As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNNRITEM", PNNRITEM)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_BORRAR_EMB_OBS_X_ITEM", lobjParams)
    End Sub

    Public Sub Elimina_Carga_Tipo(ByVal obeCargaEmbarque As beDetalleCargaInternacional)
        Dim oSqlMan As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeCargaEmbarque.PNNORSCI)
        lobjParams.Add("PNNCODRG", obeCargaEmbarque.PNNCODRG)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_BORRAR_EMB_CARGA_TIPO", lobjParams)
    End Sub

    Public Function Liquidacion_Embarque(ByVal PNNORDSR As Double, ByVal PNCZNFCC As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PNCZNFCC", PNCZNFCC)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LIQUIDACION_EMBARQUE", lobjParams)
        Return dt
    End Function


    Public Function Lista_Seguimiento_Aduanero_Resumido(ByVal oFiltroEmbarque As beSeguimientoCargaFiltro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oFiltroEmbarque.PSCCMPN)
        lobjParams.Add("PNCCLNT", oFiltroEmbarque.PNCCLNT)
        lobjParams.Add("PNFECINI", oFiltroEmbarque.PNFECINI)
        lobjParams.Add("PNFECFIN", oFiltroEmbarque.PNFECFIN)
        lobjParams.Add("PSNORCML", oFiltroEmbarque.PSNORCML)
        lobjParams.Add("PSCPRVCL", oFiltroEmbarque.PSCPRVCL)
        lobjParams.Add("PSPNNMOS", oFiltroEmbarque.PSPNNMOS)
        lobjParams.Add("PSDOCEMB", oFiltroEmbarque.PSDOCEMB)
        lobjParams.Add("PSNORSCI", oFiltroEmbarque.PSNORSCI)
        lobjParams.Add("PSNREFCL", oFiltroEmbarque.PSNREFCL)
        lobjParams.Add("PSSESTRG", oFiltroEmbarque.PSSESTRG)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_SEGUIMIENTO_ADUANERO_RESUMIDO", lobjParams)
        Return dt
    End Function

  
    Public Function Lista_Documento_Cliente(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal pstrEst As String) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PCSESTRG", pstrEst)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DOCUMENTO_X_CLIENTE_AJUSTE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_X_Cliente(ByVal PSCCMPN As String, ByVal pdblCli As Double, ByVal pstrEst As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PCSESTRG", pstrEst)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DATOS_X_CLIENTE", lobjParams)
        Return dt
    End Function

    Public Function Busca_Embarque_OS(ByVal PNPNNMOS As Double, ByVal PNCZNFCC As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNPNNMOS", PNPNNMOS)
        lobjParams.Add("PNCZNFCC", PNCZNFCC)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCA_EMBARQUE_OS", lobjParams)
        Return dt
    End Function

    Public Function Lista_Status_X_Cliente(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal pstrEst As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PCSESTRG", pstrEst)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_STATUS_X_CLIENTE_AJUSTE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Status_CI_X_Embarque(ByVal obeParamCheckPoint As beCheckPoint) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeParamCheckPoint.PNCCLNT)
        lobjParams.Add("PNNORSCI", obeParamCheckPoint.PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_STATUS_CI_X_EMBARQUE_AJUSTE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Carga_Embarque(ByVal PNNORSCI As Decimal) As List(Of beDetalleCargaInternacional)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeCarga As beDetalleCargaInternacional
        Dim oListCarga As New List(Of beDetalleCargaInternacional)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CARGA_EMBARQUE", lobjParams)
        For Each Item As DataRow In dt.Rows
            obeCarga = New beDetalleCargaInternacional
            obeCarga.PNNCODRG = Item("NCODRG")
            obeCarga.PNQCANTI = Item("QCANTI")
            obeCarga.PSFECINI = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
            obeCarga.PSFECVEN = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
            obeCarga.PNEXISTS = 1
            oListCarga.Add(obeCarga)
        Next
        Return oListCarga
    End Function



    Public Function Lista_Observacion_Embarque(ByVal PNNORSCI As Decimal) As List(Of beObservacionCarga)
        Dim obeObservacion As beObservacionCarga
        Dim oLisObservacion As New List(Of beObservacionCarga)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        Dim dt As DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_OBSERVACION_EMBARQUE", lobjParams)
        For Each Item As DataRow In dt.Rows
            obeObservacion = New beObservacionCarga
            obeObservacion.PNNRITEM = Item("NRITEM")
            obeObservacion.PSFECOBS = Item("FECOBS")
            obeObservacion.PSTOBS = Item("OBSERV").ToString.Trim
            obeObservacion.PNEXISTS = 1
            oLisObservacion.Add(obeObservacion)
        Next
        Return oLisObservacion
    End Function


    Public Function Lista_Observacion_X_Cliente(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal pstrEst As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PCSESTRG", pstrEst)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_OBSERVACION_X_CLIENTE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Observacion_CI_X_Embarque(ByVal PNCCLNT As Double, ByVal PNNORSCI As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_OBSERVACION_CI_X_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Unidades_X_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_UNIDADES_X_EMBARQUE", lobjParams)
        Return dt
    End Function



    Public Sub Cerrar_Embarque(ByVal PNNORSCI As Double)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_CERRAR_EMBARQUE", lobjParams)

    End Sub

    Public Sub Mantenimiento_ETD_Embarque(ByVal PNNORSCI As Double, ByVal PNFAPREV As Double)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNFAPREV", PNFAPREV)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_ETD_EMBARQUE", lobjParams)

    End Sub

    Public Sub Mantenimiento_ETA_Embarque(ByVal pdblEmbarque As Double, ByVal pdblETA As Double)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNFAPRAR", pdblETA)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_ETA_EMBARQUE", lobjParams)
     
    End Sub

    Public Function Importar_Partidas_Arancelarias(ByVal pdblOS As Double, ByVal pdblZona As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORDSR", pdblOS)
        lobjParams.Add("PNCZNFCC", pdblZona)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_IMPORTAR_PARTIDAS_ARANCELARIAS", lobjParams)
        Return dt
    End Function

    Public Function Importar_Partidas_Mercaderia(ByVal pdblCliente As Double, ByVal pstrMercaderia As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSCMRCLR", pstrMercaderia)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_IMPORTAR_PARTIDAS_ARANCELARIAS_ITEM", lobjParams)
        Return dt
    End Function


    Public Sub Actualiza_Embarque_Datos(ByVal PNCCLNT As Double, ByVal PNNRPEMB As Double, ByVal PNNORSCI As Double, ByVal PNQTPCM2 As Decimal, ByVal PSNFCTCM As String, ByVal PNNMITFC As Decimal, ByVal PNNSEQIN As Decimal)
        Dim lobjParams As New Parameter
        Dim oSqlMan As New SqlManager
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNQTPCM2", PNQTPCM2)
        lobjParams.Add("PSNFCTCM", PSNFCTCM)
        lobjParams.Add("PNNMITFC", PNNMITFC)
        lobjParams.Add("PNNSEQIN", PNNSEQIN)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_ACT_EMB_DATOS", lobjParams)
    End Sub

    Public Function Importar_Datos_Agencias(ByVal strlOS As String, ByVal strZona As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORDSR", strlOS)
        lobjParams.Add("PNCZNFCC", strZona)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_IMPORTAR_DATOS_AGENCIAS", lobjParams)
        Return dt
    End Function

    Public Function Lista_Documento_Costo_Seguimiento() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCVARBL", "DOCUMENTO")
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_VARIABLES", lobjParams)
        Return dt
    End Function

   

    Public Function Lista_Variable(ByVal CVARBL As String) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCVARBL", CVARBL)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_VARIABLES", lobjParams)
        Return dt
    End Function


    Public Function Lista_OC_X_Embarque_OS(ByVal dblCliente As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", dblCliente)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_OC_X_EMBARQUE_OS", lobjParams)
        Return dt
    End Function

    Public Function Enviar_Operacion_Facturacion(ByVal pstrCompania As String, ByVal pstrDivision As String, ByVal pdblEmbarque As Double, ByVal pdblCli As Double, ByVal pdblFecSrv As Double, _
    ByVal pdblTarifa As Double, ByVal pstrTipoTarifa As String, ByVal pstrUnidadMedida As String, ByVal pdblValor As Double, ByVal PNCCLNFC As Double, ByVal CPLNDV As Decimal, ByVal PNCCNTCS As String, ByVal CDIRSE As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PSCDVSN", pstrDivision)
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNFECSRV", pdblFecSrv)

        'MODIFICADO POR ABRAHAM ZORRILLA
        lobjParams.Add("PNNRTFSV", pdblTarifa)
        lobjParams.Add("PSSTPTRA", pstrTipoTarifa)
        lobjParams.Add("PSCUNDMD", pstrUnidadMedida)
        lobjParams.Add("PNVALCTE", pdblValor)
        '======================================

        lobjParams.Add("PNCCLNFC", PNCCLNFC)   ' Cliente Facturación agregado 17/09/2012

        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PNCPLNDV", CPLNDV)

        lobjParams.Add("PNCCNTCS", PNCCNTCS) 'ECM-ValidacionSectorCliente[RF001]-160516
        lobjParams.Add("CDIRSE", CDIRSE)

        'dt = lobjSql.ExecuteDataTable("SP_SOLCT_REGISTRAR_OPERACION_SIL", lobjParams)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_REGISTRAR_OPERACION_SIL_V2", lobjParams)
        Return dt
    End Function


    Public Function Lista_Partidas_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_PARTIDAS_EMBARQUE", lobjParams)
        Return dt
    End Function
    Public Function Lista_Maestro_Partidas_Arancelarias_Embarque() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_MAESTRO_PARTIDAS_ARANCELARIAS_EMBARQUE", Nothing)
        Return dt
    End Function

    Public Function Lista_Datos_Mensaje_Texto(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DATOS_MENSAJE_TEXTO", lobjParams)
        Return dt
    End Function

    Public Function Lista_Numero_X_Operador(ByVal pdblCliente As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_NUMEROS_X_OPERADOR", lobjParams)
        Return dt
    End Function

    Public Sub Actualiza_Partidas_DUAA1(ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblItemOC As Double, ByVal pstrFactura As String, ByVal pdblItemFact As Double, ByVal pdblOS As Double, ByVal pdblAduana As Double, ByVal pdblSerie As Double, ByVal pstrTPN As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSNMRODC", pstrOC)
        lobjParams.Add("PNNMITOC", pdblItemOC)
        lobjParams.Add("PSNMRFCT", pstrFactura)
        lobjParams.Add("PNNMITFC", pdblItemFact)
        lobjParams.Add("PNNORDSR", pdblOS)
        lobjParams.Add("PNPNCDIN", pdblAduana)
        lobjParams.Add("PNNSERIE", pdblSerie)
        lobjParams.Add("PSCODTPN", pstrTPN)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_PARTIDAS_DUAA1", lobjParams)
      
    End Sub

    Public Function Lista_Informacion_Inicial_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_INFORMACION_INICIAL_EMBARQUE", lobjParams)
        Return dt
    End Function


   

    Public Function CargarTarifaEmbarque(ByVal oParametros As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oParametros("PSCCMPN"))
        lobjParams.Add("PSCDVSN", oParametros("PSCDVSN"))
        lobjParams.Add("PNCCLNT", oParametros("PNCCLNT"))
        lobjParams.Add("PNNORSCI", oParametros("PNNORSCI"))
        lobjParams.Add("PNFECSRV", oParametros("PNFECSRV"))
        lobjParams.Add("PNCPLNDV", oParametros("PNCPLNDV"))
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TARIFA_X_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function CargarTarifaEmbarque_x_tarifa(ByVal oParametros As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oParametros("PSCCMPN"))
        lobjParams.Add("PSCDVSN", oParametros("PSCDVSN"))
        lobjParams.Add("PNCCLNT", oParametros("PNCCLNT"))
        lobjParams.Add("PNNORSCI", oParametros("PNNORSCI"))
        lobjParams.Add("PNFECSRV", oParametros("PNFECSRV"))
        lobjParams.Add("PNNRTFSV", oParametros("PNNRTFSV"))
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TARIFA_X_EMBARQUE_X_TARIFA_DESPACHO_NACIONAL", lobjParams)
        Return dt
    End Function


    Public Function CargarTarifaContrato(ByVal oParametros As Hashtable) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oParametros("PNCCLNT"))
        lobjParams.Add("PNFECSRV", oParametros("PNFECSRV"))
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TARIFA_X_CONTRATO", lobjParams)
        Return dt
    End Function


  Public Function CargarClienteFacturacion(ByVal tarifa As Double, ByVal CCMPN As String, ByVal CDVSN As String, ByVal CCLNT As Double, ByVal FECSRV As Double) As DataTable
    Dim dt As DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PNNRTFSV", tarifa)
    lobjParams.Add("PSCCMPN", CCMPN)
    lobjParams.Add("PSCDVSN", CDVSN)
    lobjParams.Add("PNCCLNT", CCLNT)
    lobjParams.Add("PNFECHA", FECSRV)
    dt = lobjSql.ExecuteDataTable("SP_SOLCT_CARGAR_CLIENTE_FACTURACION", lobjParams)
    Return dt
  End Function



    Public Sub Mantenimiento_Anular_Embarque(ByVal pdbNORSCI As Double, ByVal PSANULAR_PREEMBARQUE As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", pdbNORSCI)
        lobjParams.Add("PSANULAR_PREEMBARQUE", PSANULAR_PREEMBARQUE)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ANULAR_EMBARQUE", lobjParams)
    End Sub



    Public Function Importar_Oc_Embarcadas_Agencia_2(ByVal objeto As beDistribucionCostoxItemOC) As Integer
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", objeto.PNNORSCI)
        lobjParams.Add("PNCCLNT", objeto.PNCCLNT)
        lobjParams.Add("PSNORCML", objeto.PSNORCML)
        lobjParams.Add("PNNRITEM", objeto.PNNRITEM)
        lobjParams.Add("PSSBITOC", objeto.PSSBITOC)
        lobjParams.Add("PNNRPEMB", objeto.PNNRPEMB)
        lobjParams.Add("PNNSERIE", objeto.PNNSERIE)
        lobjParams.Add("PNVAL", objeto.PNVAL)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSCODVAR", objeto.PSCODVAR)
        lobjParams.Add("PNCMDA1", objeto.PNCMNDA1)
        lobjParams.Add("PSNMONOC", objeto.PSNMONOC)
        lobjParams.Add("PNNMITFC", objeto.PNNMITFC)
        lobjParams.Add("PSPARTID", objeto.PSPARTID)
        lobjParams.Add("PSNFCTCM", objeto.PSNFCTCM)
        lobjParams.Add("PNVALMRC", objeto.PNVALMRC)
        lobjSql.ExecuteNonQuery("SP_SOLSC_IMPORTAR_OC_EMBARCADAS_AGENCIA_2", lobjParams)
        retorno = 1
        Return retorno
    End Function


    Public Function Distribuir_Costos_Totales_x_Concepto(ByVal objeto As beDistribucionCostoxItemOC) As Integer
        Dim retorno As Int32 = 0
   
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", objeto.PNCCLNT)
        lobjParams.Add("PNNORSCI", objeto.PNNORSCI)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSCDOVAR", objeto.PSCODVAR)
        lobjSql.ExecuteNonQuery("SP_SOLSC_DISTRIBUCION_COSTOS_TOTALES_X_CONCEPTO", lobjParams)
        retorno = 1
    
        Return retorno
    End Function

    Public Function Lista_Almacen_Todos_Local() As DataTable
        Dim lobjSql As New SqlManager
        Dim dtAlmacen As New DataTable
        Dim lobjParams As New Parameter
        dtAlmacen = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TODOS_ALMACEN_LOCAL", lobjParams)
        Return dtAlmacen
    End Function

    Public Function Lista_Seguimiento_Carga_Internacional_Vista_Reducida(ByVal oFiltro As beSeguimientoCargaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtSegVistaReducida As New DataTable
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oFiltro.PSCCMPN)
        lobjParams.Add("PNCCLNT", oFiltro.PNCCLNT)
        lobjParams.Add("PNFECINI", oFiltro.PNFECINI)
        lobjParams.Add("PNFECFIN", oFiltro.PNFECFIN)
        lobjParams.Add("PSNORCML", oFiltro.PSNORCML)
        lobjParams.Add("PSCPRVCL", oFiltro.PSCPRVCL)
        lobjParams.Add("PSPNNMOS", oFiltro.PSPNNMOS)
        lobjParams.Add("PSDOCEMB", oFiltro.PSDOCEMB)
        lobjParams.Add("PSNORSCI", oFiltro.PSNORSCI)
        lobjParams.Add("PSSESTRG", oFiltro.PSSESTRG)
        lobjParams.Add("PSTPSRVA", oFiltro.PSTPSRVA)
        lobjParams.Add("PSCDVSN", oFiltro.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oFiltro.PNCPLNDV)

        odtSegVistaReducida = lobjSql.ExecuteDataTable("SP_SC_LISTA_SEGUIMIENTO_ADUANERO_VISTA_RESUMEN", lobjParams)

        odtSegVistaReducida.Columns.Add("CPRTOE")
        odtSegVistaReducida.Columns.Add("CPRTOA")

        For Each Item As DataRow In odtSegVistaReducida.Rows
            If Item("PNNMOS") = "0" Then
                Item("PNNMOS") = ""
            End If
            Item("CCMPN") = HelpClass.ToStringCvr(Item("CCMPN"))
            Item("CDVSN") = HelpClass.ToStringCvr(Item("CDVSN"))
            Item("NOREMB") = HelpClass.ToStringCvr(Item("NOREMB"))
            Item("TZNFCC") = HelpClass.ToStringCvr(Item("TZNFCC"))
            Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            Item("NREFCL") = HelpClass.ToStringCvr(Item("NREFCL"))
            Item("FAPREV") = HelpClass.FechaNum_a_Fecha(Item("FAPREV"))
            Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
            Item("CTRMAL") = HelpClass.ToStringCvr(Item("CTRMAL"))
            Item("CMEDTR") = HelpClass.ToStringCvr(Item("CMEDTR"))
            Item("TCMPVP") = HelpClass.ToStringCvr(Item("TCMPVP"))
            Item("TCMPPS") = HelpClass.ToStringCvr(Item("TCMPPS"))
            Item("TCMPR1") = HelpClass.ToStringCvr(Item("TCMPR1"))
            Item("TCMPPS_DESTINO") = HelpClass.ToStringCvr(Item("TCMPPS_DESTINO"))
            Item("TCMPR1_DESTINO") = HelpClass.ToStringCvr(Item("TCMPR1_DESTINO"))
            If Item("TCMPPS").ToString.Trim.Length > 0 Then
                If Item("TCMPR1").ToString.Length > 0 Then
                    Item("CPRTOE") = String.Format("{0} - {1}", Item("TCMPPS").ToString.Trim, Item("TCMPR1").ToString.Trim)
                Else
                    Item("CPRTOE") = Item("TCMPPS").ToString.Trim
                End If
            Else
                Item("CPRTOE") = ""
            End If
            If Item("TCMPPS_DESTINO").ToString.Trim.Length > 0 Then
                If Item("TCMPR1_DESTINO").ToString.Length > 0 Then
                    Item("CPRTOA") = String.Format("{0} - {1}", Item("TCMPPS_DESTINO").ToString.Trim, Item("TCMPR1_DESTINO").ToString.Trim)
                Else
                    Item("CPRTOA") = Item("TCMPPS_DESTINO").ToString.Trim
                End If
            Else
                Item("CPRTOA") = ""
            End If
            Item("TNRODU") = HelpClass.ToStringCvr(Item("TNRODU"))
            Item("TCANAL") = HelpClass.ToStringCvr(Item("TCANAL"))
            Item("TNMCIN") = HelpClass.ToStringCvr(Item("TNMCIN"))
            Item("TNMAGC") = HelpClass.ToStringCvr(Item("TNMAGC"))
            Item("TTRMAL") = HelpClass.ToStringCvr(Item("TTRMAL"))
            Item("SESTRG") = HelpClass.ToStringCvr(Item("SESTRG"))
            Item("SESTRG_ESTADO") = HelpClass.ToStringCvr(Item("SESTRG_ESTADO"))
            Item("REGIMEN") = HelpClass.ToStringCvr(Item("REGIMEN"))
            Item("DESPACHO") = HelpClass.ToStringCvr(Item("DESPACHO"))
            Item("TRANSPORTE") = HelpClass.ToStringCvr(Item("TRANSPORTE"))
            Item("USUENV") = Item("USUENV") & " " & HelpClass.FechaNum_a_Fecha(Item("FCHENV")) & " " & HelpClass.HoraNum_a_Hora_Default(Item("HRAENV"))
            Item("FTRTSG") = HelpClass.ToStringCvr(Item("FTRTSG"))
        Next
        Return odtSegVistaReducida
    End Function

    Public Function VERIFICA_EXISTENCIA_OS_EN_AGENCIA(ByVal PNPNNMOS As Decimal, ByVal PNCZNFCC As Decimal) As beAgencia
        Dim lobjSql As New SqlManager
        Dim obeAgencia As beAgencia
        Dim odtDatos As New DataTable
        Dim odt As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNPNNMOS", PNPNNMOS)
        lobjParams.Add("PNCZNFCC", PNCZNFCC)
        odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_VERIFICA_EXISTENCIA_OS_AGENCIA", lobjParams)
        If (odtDatos.Rows.Count > 0) Then
            obeAgencia = New beAgencia
            obeAgencia.PNPNNMOS = odtDatos.Rows(0)("PNNMOS")
            obeAgencia.PNCZNFCC = odtDatos.Rows(0)("CZNFCC")
            obeAgencia.PSTCANAL = odtDatos.Rows(0)("TCANAL").ToString.Trim
            obeAgencia.PSTNRODU = odtDatos.Rows(0)("TNRODU").ToString.Trim
        Else
            obeAgencia = Nothing
        End If
        Return obeAgencia
    End Function


    Public Function Reaperturar_Embarque(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_REAPERTURAR_EMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function Existe_Embarque_En_Operacion(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCTPALJ As String) As DataTable
        Dim odt As New DataTable
        Dim PNNOPRCN As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCTPALJ", PSCTPALJ)
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_VERIFICA_EXISTENCIA_EMBARQUE_EN_OPERACION", lobjParams)
        Return odt
    End Function

    Public Function Datos_CheckPoint_Carga_Internacional_x_Embarque(ByVal PNCCLNT As Decimal, ByVal PSLISTANORSCIS As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtCheckPoint As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSEMBARQUES", PSLISTANORSCIS)
        odtCheckPoint = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_CHECKPOINT_CARGA_INTERNACIONAL_X_EMBARQUE", lobjParams)
        Return odtCheckPoint
    End Function

    Public Function Datos_Ordenes_Compra_X_Embarques(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSLISTANORSCIS As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtCheckPoint As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSEMBARQUES", PSLISTANORSCIS)
        odtCheckPoint = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_ORDENES_COMPRA_X_EMBARQUES_AJUSTE", lobjParams)
        Return odtCheckPoint
    End Function
    '********************para actualizacion de partidas y facturas
    Public Function Listar_Embarques_Actualizacion_Partida(ByVal PNFECHA As Decimal, ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtEmbarques As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNFECHA", PNFECHA)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        odtEmbarques = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_EMBARQUES_ACTUALIZACION_DATOS_DE_DUAA1", lobjParams)
        Return odtEmbarques
    End Function
    Public Function Listar_Datos_Detalle_Dua(ByVal PNNORDSR As Decimal, ByVal PNCZNFCC As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odtDatosDUAA1 As New DataTable
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PNCZNFCC", PNCZNFCC)
        odtDatosDUAA1 = lobjSql.ExecuteDataSet("SP_SOLSC_DUAA1_DATOS_DETALLE_ASCINSA", lobjParams).Tables(0)
        Return odtDatosDUAA1
    End Function

      
    '**********************************
    Public Function Listar_Log_X_Carga_Internacional(ByVal PNCCLNT As Decimal, ByVal PNNRPEMB As Decimal, ByVal PNNESTDO As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtCheckPoint As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        odtCheckPoint = lobjSql.ExecuteDataTable("P_SOLSC_LISTA_INCIDENCIAS_X_CHECKPOINT_CARGA_INTERNACIONAL_LOG", lobjParams)
        Return odtCheckPoint
    End Function

    Public Function Listar_Log_X_Embarque_Aduana(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNESTDO As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtCheckPoint As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        odtCheckPoint = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_INCIDENCIAS_X_CHECKPOINT_SEGUIMIENTO_LOG", lobjParams)
        Return odtCheckPoint
    End Function

    Public Function Listar_Log_X_Carga_Internacional_Embarque_Aduana(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNESTDO As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtCheckPoint As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        odtCheckPoint = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_INCIDENCIAS_X_CHECKPOINT_CARGA_INTERNACIONAL_SEGUIMIENTO_LOG", lobjParams)
        Return odtCheckPoint
    End Function


  Public Function Listar_Regimen_X_Vencer(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECVEN As Decimal, ByVal PNPORVENCER As Decimal, ByVal PSTPSRVA As String) As DataTable
    Dim lobjSql As New SqlManager
    Dim odt As New DataTable
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCCMPN", PSCCMPN)
    lobjParams.Add("PNCCLNT", PNCCLNT)
    lobjParams.Add("PNFECINI", PNFECINI)
    lobjParams.Add("PNFECVEN", PNFECVEN)
    lobjParams.Add("PNPORVENCER", PNPORVENCER)
    lobjParams.Add("PSTPSRVA", PSTPSRVA)
    odt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_REGIMEN_X_VENCER_CLIENTE", lobjParams)
    For Each Item As DataRow In odt.Rows
      Item("REGIMEN") = HelpClass.ToStringCvr(Item("REGIMEN"))
      Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
      Item("FECINI") = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
      Item("FECVEN") = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
      If Item("PNNMOS") = "0" Then
        Item("PNNMOS") = ""
      Else
        Item("PNNMOS") = Item("PNNMOS")
      End If
    Next
    Return odt
  End Function

  Public Function Listar_TipoCarga_X_Vencer(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECVEN As Decimal, ByVal PNPORVENCER As Decimal, ByVal PSTPSRVA As String) As DataTable
    Dim lobjSql As New SqlManager
    Dim odt As New DataTable
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCCMPN", PSCCMPN)
    lobjParams.Add("PNCCLNT", PNCCLNT)
    lobjParams.Add("PNFECINI", PNFECINI)
    lobjParams.Add("PNFECVEN", PNFECVEN)
    lobjParams.Add("PNPORVENCER", PNPORVENCER)
    lobjParams.Add("PSTPSRVA", PSTPSRVA)
    odt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TIPOCARGA_X_VENCER_CLIENTE", lobjParams)
    For Each Item As DataRow In odt.Rows
      Item("TIPO_CARGA") = HelpClass.ToStringCvr(Item("TIPO_CARGA"))
      Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
      Item("FECINI") = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
      Item("FECVEN") = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
      If Item("PNNMOS") = "0" Then
        Item("PNNMOS") = ""
      Else
        Item("PNNMOS") = Item("PNNMOS")
      End If
    Next
    Return odt
  End Function

    Public Function Listar_CartaFianza_X_Vencer(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECVEN As Decimal, ByVal PNPORVENCER As Decimal, ByVal PSTPSRVA As String, ByVal PSESTADO As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim odt As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECVEN", PNFECVEN)
        lobjParams.Add("PNPORVENCER", PNPORVENCER)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PSESTADO", PSESTADO)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_CARTA_FIANZA_X_VENCER", lobjParams)
        For Each Item As DataRow In odt.Rows
            Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
            Item("FECEDC") = HelpClass.FechaNum_a_Fecha(Item("FECEDC"))
            Item("FECVEN") = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
            If Item("PNNMOS") = "0" Then
                Item("PNNMOS") = ""
            Else
                Item("PNNMOS") = Item("PNNMOS")
            End If
            Item("NDOCUM") = HelpClass.ToStringCvr(Item("NDOCUM"))
            Item("CBNCFN") = HelpClass.ToDecimalCvr(Item("CBNCFN"))
            Item("TCMBCF") = HelpClass.ToStringCvr(Item("TCMBCF"))
            Item("NMONOC") = HelpClass.ToStringCvr(Item("NMONOC"))
            Item("SESFNZ") = HelpClass.ToStringCvr(Item("SESFNZ"))
            Item("TOBFNZ") = HelpClass.ToStringCvr(Item("TOBFNZ"))
        Next
        Return odt
    End Function

    Public Function Listar_Datos_Importacion_SIL(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As beDatosEmbarque
        Dim lobjSql As New SqlManager
        Dim oDatosEmbarque_BE As New beDatosEmbarque
        Dim odt As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DATOS_IMPORTACION_SIL", lobjParams)
        If odt.Rows.Count > 0 Then
            oDatosEmbarque_BE.PNNORSCI = odt.Rows(0)("NORSCI")
            oDatosEmbarque_BE.PNPNNMOS = odt.Rows(0)("PNNMOS")
            oDatosEmbarque_BE.PNCZNFCC = odt.Rows(0)("CZNFCC")
            oDatosEmbarque_BE.PNTPORGE = HelpClass.ToDecimalCvr(odt.Rows(0)("TPORGE"))
            oDatosEmbarque_BE.PSTDSCRG_REG = HelpClass.ToStringCvr(odt.Rows(0)("TDSCRG_REGIMEN"))
            oDatosEmbarque_BE.PSTNRODU = HelpClass.ToStringCvr(odt.Rows(0)("TNRODU"))
            oDatosEmbarque_BE.PSTCANAL = HelpClass.ToStringCvr(odt.Rows(0)("TCANAL"))
            oDatosEmbarque_BE.PNNCODRG_DESPACHO = HelpClass.ToDecimalCvr(odt.Rows(0)("NCODRG_DESPACHO"))
            oDatosEmbarque_BE.PSTDSCRG_DESPACHO = HelpClass.ToStringCvr(odt.Rows(0)("TDSCRG_DESPACHO"))
        End If
        Return oDatosEmbarque_BE
    End Function


    Public Function Listar_Datos_Validacion_Embarque(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As beDatosEmbarque
        Dim lobjSql As New SqlManager
        Dim oDatosEmbarque_BE As New beDatosEmbarque
        Dim odt As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_EMBARQUE_VALIDACION", lobjParams)
        If odt.Rows.Count > 0 Then
            oDatosEmbarque_BE.PNNORSCI = odt.Rows(0)("NORSCI")
            oDatosEmbarque_BE.PNPNNMOS = odt.Rows(0)("PNNMOS")
            oDatosEmbarque_BE.PNCZNFCC = odt.Rows(0)("CZNFCC")
            oDatosEmbarque_BE.PNTPORGE = HelpClass.ToDecimalCvr(odt.Rows(0)("NCODRG_REGIMEN"))
            oDatosEmbarque_BE.PSTCANAL = HelpClass.ToStringCvr(odt.Rows(0)("TCANAL"))
            oDatosEmbarque_BE.PNNCODRG_DESPACHO = HelpClass.ToDecimalCvr(odt.Rows(0)("NCODRG_DESPACHO"))
            oDatosEmbarque_BE.PNCMEDTR = odt.Rows(0)("CMEDTR")
            oDatosEmbarque_BE.PNFAPRAR = odt.Rows(0)("ETA")
            oDatosEmbarque_BE.PNFAPREV = odt.Rows(0)("ETD")
            oDatosEmbarque_BE.PNCHK_ENTREGA_ALMACEN = odt.Rows(0)("CHK_ALMACEN")
            oDatosEmbarque_BE.PNCHK_LEVANTE = odt.Rows(0)("CHK_LEVANTE")
            oDatosEmbarque_BE.PNCHK_NUMERACION = odt.Rows(0)("CHK_NUMERACION")
            oDatosEmbarque_BE.PNCHK_PAGO_DERECHO = odt.Rows(0)("CHK_PAGO_DERECHO")
            oDatosEmbarque_BE.PSFTRTSG = odt.Rows(0)("FTRTSG")

        End If
        Return oDatosEmbarque_BE
    End Function

    Public Sub Eliminar_Item_Embarcado(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As Decimal, ByVal PNNRPEMB As Decimal)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        lobjParams.Add("PNNRITEM", PNNRITEM)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_ITEM_EMBARCADO", lobjParams)
    End Sub


    Public Function VerificarExistenciaOrdenServicio(ByVal PNPNNMOS As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PNPNNMOS", PNPNNMOS)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_VERIFICAR_ORDEN_SERVICIO", lobjParams)
        Return dt
    End Function


    Public Function Lista_Datos_Seguimiento_Extendido(ByVal oFiltroEmbarque As beSeguimientoCargaFiltro) As DataSet


        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dsExtendido As DataSet
        lobjParams.Add("PSCCMPN", oFiltroEmbarque.PSCCMPN)
        lobjParams.Add("PNCCLNT", oFiltroEmbarque.PNCCLNT)
        lobjParams.Add("PNFECINI", oFiltroEmbarque.PNFECINI)
        lobjParams.Add("PNFECFIN", oFiltroEmbarque.PNFECFIN)
        lobjParams.Add("PSNORCML", oFiltroEmbarque.PSNORCML)
        lobjParams.Add("PSCPRVCL", oFiltroEmbarque.PSCPRVCL)
        lobjParams.Add("PSPNNMOS", oFiltroEmbarque.PSPNNMOS)
        lobjParams.Add("PSDOCEMB", oFiltroEmbarque.PSDOCEMB)
        lobjParams.Add("PSNORSCI", oFiltroEmbarque.PSNORSCI)
        lobjParams.Add("PSSESTRG", oFiltroEmbarque.PSSESTRG)
        lobjParams.Add("PSTPSRVA", oFiltroEmbarque.PSTPSRVA)
        lobjParams.Add("PSCDVSN", oFiltroEmbarque.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oFiltroEmbarque.PNCPLNDV)

        dsExtendido = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_SEGUIMIENTO_ADUANERO_EXTENDIDO", lobjParams)
        dsExtendido.Tables(0).TableName = "DATOS_EMBARQUE"
        dsExtendido.Tables(1).TableName = "DOCUMENTO_EMBARQUE"
        dsExtendido.Tables(2).TableName = "DETALLE_EMBARQUE"
        dsExtendido.Tables(3).TableName = "CHECKPOINT_EMBARQUE"
        dsExtendido.Tables(4).TableName = "OBSERVACION_EMBARQUE"
        dsExtendido.Tables(5).TableName = "ITEM_EMBARQUE"
        dsExtendido.Tables(6).TableName = "COSTOS_EMBARQUE"
        dsExtendido.Tables(7).TableName = "OBSSERVACION_CI"
        dsExtendido.Tables(8).TableName = "CHECKPOINT_CI"
        dsExtendido.Tables(9).TableName = "RESUMEN_OC_EMBARQUE"

        Return dsExtendido
    End Function

    Public Function ListarOrdenesRegularizacion(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SC_LISTA_SEGUIMIENTO_ADUANERO_REGULARIZADO", lobjParams)
        For Each Item As DataRow In dt.Rows
            If Item("PNNMOS") = "0" Then
                Item("PNNMOS") = ""
            End If
            Item("FORSCI") = HelpClass.FechaNum_a_Fecha(Item("FORSCI"))
        Next
        Return dt

    End Function


    Public Function ListarMercaderiaSeguimiento(ByVal obeFiltro As beFiltroBusquedaItem) As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim ds As New DataSet

        lobjParams.Add("PSCCMPN", obeFiltro.PSCCMPN)
        lobjParams.Add("PSTPSRVA", obeFiltro.PSTPSRVA)
        lobjParams.Add("PNCCLNT", obeFiltro.PNCCLNT)
        lobjParams.Add("PNCPRVCL", obeFiltro.PNCPRVCL)
        lobjParams.Add("PNPNNMOS_INI", obeFiltro.PNPNNMOS_INI)
        lobjParams.Add("PNPNNMOS_FIN", obeFiltro.PNPNNMOS_FIN)

        lobjParams.Add("PNFORSCI_INI", obeFiltro.FORSCI_INI)  ' agregado 
        lobjParams.Add("PNFORSCI_FIN", obeFiltro.FORSCI_FIN)  ' agregado 

        lobjParams.Add("PNNORSCI", obeFiltro.PNNORSCI)
        lobjParams.Add("PSCANAL", obeFiltro.PSCANAL)
        lobjParams.Add("PSCPTDAR", obeFiltro.PSCPTDAR)
        lobjParams.Add("PSTDITES", obeFiltro.PSTDITES)
        lobjParams.Add("PSLISTREGIMEN", obeFiltro.PSLISTREGIMEN)
        lobjParams.Add("PSNORCML", obeFiltro.PSNORCML)
        lobjParams.Add("PNCPAIS", obeFiltro.PNCPAIS)

        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_MERCADERIAS_EMBARQUE_V1", lobjParams)

        Return ds

    End Function

    'INI-ECM-ValidacionSectorCliente[RF001]-160516
    Public Function CambiarCeBePorSector(ByVal input As InCeBePorSector) As OuCeBePorSector
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        Dim dataTable As New DataTable

        parameter.Add("IN_CCMPN", input.CCMPN)
        parameter.Add("IN_CCNTCS", input.CCNTCS)
        parameter.Add("IN_CDSCSP", input.CDSCSP)
        dataTable = sqlManager.ExecuteDataTable("SP_SOLMIN_SD_CAMBIAR_CENTRO_BENEFICIO_POR_SECTOR", parameter)

        Dim data = New OuCeBePorSector
        For Each row As DataRow In dataTable.Rows
            data.CCNTCS = row("CCNTCS")
            data.CCNBNS = row("CCNBNS")
            data.TCNTCS = row("TCNTCS")
        Next row

        Return Data
    End Function

    Public Function ListarLogTracking(pCCMPN As String, ByVal pNORSCI As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable

        lobjParams.Add("PSCCMPN", pCCMPN)
        lobjParams.Add("PNNORSCI", pNORSCI)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_LOG_TRACKING_EMBARQUE", lobjParams)

        Return dt

    End Function

    'FIN-ECM-ValidacionSectorCliente[RF001]-160516
End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Public Class clsEmbarqueConsultaDAL
    Public Function Lista_DatosEmbarqueConsulta(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As Hashtable
        Dim obeDatosEmbarque_BE As New beEmbarqueConsulta
        Dim oHas As New Hashtable
        Dim dtDatos As DataTable
        Dim dtTipoCarga As DataTable
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_DATOS_EMBARQUE_CONSULTA", lobjParams)
        dtDatos = ds.Tables(0).Copy
        If dtDatos.Rows.Count = 0 Then
            obeDatosEmbarque_BE = Nothing
        Else
            obeDatosEmbarque_BE.PNNORSCI = dtDatos.Rows(0)("NORSCI") 'NUM EMBARQUE
            obeDatosEmbarque_BE.PSFORSCI = HelpClass.FechaNum_a_Fecha(dtDatos.Rows(0)("FORSCI"))
            obeDatosEmbarque_BE.PSSESTRG = HelpClass.ToStringCvr(dtDatos.Rows(0)("SESTRG"))
            obeDatosEmbarque_BE.PSNOREMB = HelpClass.ToStringCvr(dtDatos.Rows(0)("NOREMB"))
            obeDatosEmbarque_BE.PSNDOCEM = HelpClass.ToStringCvr(dtDatos.Rows(0)("NDOCEM"))
            obeDatosEmbarque_BE.PNCAGNCR = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("CAGNCR"))
            obeDatosEmbarque_BE.PSTNMAGC = HelpClass.ToStringCvr(dtDatos.Rows(0)("TNMAGC"))
            obeDatosEmbarque_BE.PNCMEDTR = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("CMEDTR"))
            obeDatosEmbarque_BE.PSTNMMDT = HelpClass.ToStringCvr(dtDatos.Rows(0)("TNMMDT"))
            obeDatosEmbarque_BE.PNCCIANV = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("CCIANV"))
            obeDatosEmbarque_BE.PSTNMCIN = HelpClass.ToStringCvr(dtDatos.Rows(0)("TNMCIN"))
            obeDatosEmbarque_BE.PSCVPRCN = HelpClass.ToStringCvr(dtDatos.Rows(0)("CVPRCN"))
            obeDatosEmbarque_BE.PSTCMPVP = HelpClass.ToStringCvr(dtDatos.Rows(0)("TCMPVP"))
            obeDatosEmbarque_BE.PSCTRMAL = HelpClass.ToStringCvr(dtDatos.Rows(0)("CTRMAL"))
            obeDatosEmbarque_BE.PSTTRMAL = HelpClass.ToStringCvr(dtDatos.Rows(0)("TTRMAL"))
            obeDatosEmbarque_BE.PNCPAIS_ORIGEN = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("CPAIS_ORIGEN"))
            obeDatosEmbarque_BE.PSTCMPPS_ORIGEN = HelpClass.ToStringCvr(dtDatos.Rows(0)("TCMPPS_ORIGEN"))
            obeDatosEmbarque_BE.PSCPRTOE = HelpClass.ToStringCvr(dtDatos.Rows(0)("CPRTOE"))
            obeDatosEmbarque_BE.PSDES_CPRTOE = HelpClass.ToStringCvr(dtDatos.Rows(0)("DES_CPRTOE"))
            obeDatosEmbarque_BE.PSFAPREV = HelpClass.FechaNum_a_Fecha(dtDatos.Rows(0)("FAPREV"))
            obeDatosEmbarque_BE.PNCPAIS_DEST = HelpClass.ToStringCvr(dtDatos.Rows(0)("CPAIS_DEST"))
            obeDatosEmbarque_BE.PSTCMPPS_DEST = HelpClass.ToStringCvr(dtDatos.Rows(0)("TCMPPS_DEST"))
            obeDatosEmbarque_BE.PSCPRTOA = HelpClass.ToStringCvr(dtDatos.Rows(0)("CPRTOA"))
            obeDatosEmbarque_BE.PSDES_CPRTOA = HelpClass.ToStringCvr(dtDatos.Rows(0)("DES_CPRTOA"))
            obeDatosEmbarque_BE.PSFAPRAR = HelpClass.FechaNum_a_Fecha(dtDatos.Rows(0)("FAPRAR"))
            obeDatosEmbarque_BE.PNQPSOAR = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("QPSOAR"))
            obeDatosEmbarque_BE.PNQVOLMR = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("QVOLMR"))
            obeDatosEmbarque_BE.PNNDIALB = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("NDIALB"))
            obeDatosEmbarque_BE.PNNDIASE = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("NDIASE"))
            obeDatosEmbarque_BE.PSNDOCUM = HelpClass.ToStringCvr(dtDatos.Rows(0)("NDOCUM"))
            obeDatosEmbarque_BE.PNCBNCFN = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("CBNCFN"))
            obeDatosEmbarque_BE.PSTCMBCF = HelpClass.ToStringCvr(dtDatos.Rows(0)("TCMBCF"))
            obeDatosEmbarque_BE.PSFECEDC = HelpClass.FechaNum_a_Fecha(dtDatos.Rows(0)("FECEDC"))
            obeDatosEmbarque_BE.PSFECVEN = HelpClass.FechaNum_a_Fecha(dtDatos.Rows(0)("FECVEN"))
            obeDatosEmbarque_BE.PNCMNDA1 = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("CMNDA1"))
            obeDatosEmbarque_BE.PSTMNDA = HelpClass.ToStringCvr(dtDatos.Rows(0)("TMNDA"))
            obeDatosEmbarque_BE.PNITTDOC = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("ITTDOC"))
            obeDatosEmbarque_BE.PNREGIMEN = HelpClass.ToDecimalCvr(dtDatos.Rows(0)("REGIMEN"))

            If (dtDatos.Rows(0)("SESTRG") = "C") Then
                obeDatosEmbarque_BE.PSSESTRG_DESC = "CERRADA"
            Else
                obeDatosEmbarque_BE.PSSESTRG_DESC = "EN ATENCIÓN"
            End If
        End If

        dtTipoCarga = ds.Tables(1).Copy
        For Each Item As DataRow In dtTipoCarga.Rows
            Item("FECINI") = HelpClass.FechaNum_a_Fecha(Item("FECINI"))
            Item("FECVEN") = HelpClass.FechaNum_a_Fecha(Item("FECVEN"))
        Next
        oHas.Add("EMBARQUE", obeDatosEmbarque_BE)
        oHas.Add("TIPO_CARGA", dtTipoCarga)
        Return oHas
    End Function

  'Pestaña Apertura O/S
  Public Function Lista_AperturaOS_Consulta(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As Hashtable
    Dim obeApertura As New beEmbarqueConsulta
    Dim oHas As New Hashtable
    Dim dtApertura As DataTable
    Dim dtDocAdjuntos As DataTable
    Dim dtDocumentos As DataTable
    Dim ds As New DataSet
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PNCCLNT", PNCCLNT)
    lobjParams.Add("PNNORSCI", PNNORSCI)
    ds = lobjSql.ExecuteDataSet("SP_SOLSC_APERTURA_OS_CONSULTA", lobjParams)
    dtApertura = ds.Tables(0).Copy
    dtDocAdjuntos = ds.Tables(1).Copy
    dtDocumentos = ds.Tables(2).Copy
    If dtApertura.Rows.Count = 0 Then
      obeApertura = Nothing
    Else
      obeApertura.PNPNNMOS = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("PNNMOS"))
      obeApertura.PNCZNFCC = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("CZNFCC"))
      obeApertura.PSTZNFCC = HelpClass.ToStringCvr(dtApertura.Rows(0)("TZNFCC"))
      obeApertura.PSFCEMSN = HelpClass.FechaNum_a_Fecha(dtApertura.Rows(0)("FCEMSN"))
      obeApertura.PSNORCML = HelpClass.ToStringCvr(dtApertura.Rows(0)("NORCML"))
      obeApertura.PNCPRVCL = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("CPRVCL"))
      obeApertura.PSTPRVCL = HelpClass.ToStringCvr(dtApertura.Rows(0)("TPRVCL"))
      obeApertura.PSNREFCL = HelpClass.ToStringCvr(dtApertura.Rows(0)("NREFCL"))
      obeApertura.PSREFDO1 = HelpClass.ToStringCvr(dtApertura.Rows(0)("REFDO1"))
      obeApertura.PSTOBERV = HelpClass.ToStringCvr(dtApertura.Rows(0)("TOBERV"))
      obeApertura.PNNCODRG_REG = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("REGIMEN"))
      obeApertura.PSTDSCRG = HelpClass.ToStringCvr(dtApertura.Rows(0)("TDSCRG"))
            'obeApertura.PSFECINI_REG = HelpClass.FechaNum_a_Fecha(dtApertura.Rows(0)("FECINI_REG"))
      obeApertura.PSFECVEN_REG = HelpClass.FechaNum_a_Fecha(dtApertura.Rows(0)("FECVEN_REG"))
      obeApertura.PNNCODRG_DESPACHO = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("TIPODESPACHO"))
      obeApertura.PSDES_TIPODESPACHO = HelpClass.ToStringCvr(dtApertura.Rows(0)("DES_TIPODESPACHO"))
      obeApertura.PSTCANAL = HelpClass.ToStringCvr(dtApertura.Rows(0)("TCANAL"))
      obeApertura.PNTRANSPORTE = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("TRANSPORTE"))
      obeApertura.PSTERCERO = HelpClass.ToStringCvr(dtApertura.Rows(0)("TERCERO"))
      obeApertura.PSTNMCTT = HelpClass.ToStringCvr(dtApertura.Rows(0)("TNMCTT"))
      obeApertura.PSTBFTRB = HelpClass.ToStringCvr(dtApertura.Rows(0)("TBFTRB"))
      obeApertura.PSTNRODU = HelpClass.ToStringCvr(dtApertura.Rows(0)("TNRODU"))
      obeApertura.PNCTRSPT = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("CTRSPT"))
      obeApertura.PSTCMTRT = HelpClass.ToStringCvr(dtApertura.Rows(0)("TCMTRT"))
      obeApertura.PNALM_LOCAL = HelpClass.ToDecimalCvr(dtApertura.Rows(0)("ALMLOCAL"))
      obeApertura.PNDES_ALMLOCAL = HelpClass.ToStringCvr(dtApertura.Rows(0)("DES_ALMLOCAL"))
      obeApertura.PSTDRENT = HelpClass.ToStringCvr(dtApertura.Rows(0)("TDRENT"))
      obeApertura.PSHORATN = HelpClass.ToStringCvr(dtApertura.Rows(0)("HORATN"))
      obeApertura.PSTPRSCN = HelpClass.ToStringCvr(dtApertura.Rows(0)("TPRSCN"))
      obeApertura.PSTRECOR = HelpClass.ToStringCvr(dtApertura.Rows(0)("TRECOR"))

    End If
    oHas.Add("APERTURA", obeApertura)
    oHas.Add("DETDOC", dtDocAdjuntos)
    oHas.Add("DOCUMENTOS", dtDocumentos)
    Return oHas
  End Function

    Public Function Lista_DocAbjunto(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        dt = Nothing
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DOC_EMBARQUE_CONSULTA", lobjParams)
        For Each Item As DataRow In dt.Rows
            Item("TDOCIN") = HelpClass.ToStringCvr(Item("TDOCIN"))
            Item("NDOCIN") = HelpClass.ToDecimalCvr(Item("NDOCIN"))
            Item("NDOCLI") = HelpClass.ToStringCvr(Item("NDOCLI"))
            'Item("URLARC") = HelpClass.ToStringCvr(Item("URLARC"))
            'Item("TNMBAR") = HelpClass.ToStringCvr(Item("TNMBAR"))
            Item("FCDCOR") = HelpClass.FechaNum_a_Fecha(Item("FCDCOR"))
            Item("FCDCCP") = HelpClass.FechaNum_a_Fecha(Item("FCDCCP"))
        Next
        Return dt
    End Function


  Public Function Lista_Observacion_Embarque_Consulta(ByVal PNNORSCI As Decimal) As DataSet
    
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PNNORSCI", PNNORSCI)
    Dim ds As DataSet
    ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_OBSERVACION_EMBARQUE_CONSULTA", lobjParams)
    ds.Tables(0).TableName = "DT_OBS_CI"
    ds.Tables(1).TableName = "DT_OBS_EMBARQUE"

    For Each Item As DataRow In ds.Tables(0).Rows
      Item("TFCOBS") = HelpClass.FechaNum_a_Fecha(Item("TFCOBS"))
    Next
    For Each Item As DataRow In ds.Tables(1).Rows
      Item("TFCOBS") = HelpClass.FechaNum_a_Fecha(Item("TFCOBS"))
    Next
        Return ds
  End Function

    Public Function Lista_Servicios_X_Operacion_Consulta(ByVal oServicioSIL As beServicioFacturarConsulta) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oServicioSIL.PNCCLNT)
        lobjParams.Add("PNNORSCI", oServicioSIL.PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_SERVICIOS_SERVICIO_OPERACION_CONSULTA", lobjParams)
        Return dt
    End Function


  Public Function Lista_CheckPoint_X_Embarque_Consulta(ByVal obeParamCheckPoint As beCheckpointConsulta) As DataTable
    Dim dt As DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim oListCheckPoint As New List(Of beCheckpointConsulta)
    lobjParams.Add("PSCCMPN", obeParamCheckPoint.PSCCMPN)
    lobjParams.Add("PSCDVSN", obeParamCheckPoint.PSCDVSN)
    lobjParams.Add("PSCCLNT", obeParamCheckPoint.PNCCLNT)
    lobjParams.Add("PNNORSCI", obeParamCheckPoint.PNNORSCI)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_X_EMBARQUE_CONSULTA", lobjParams)
    For Each Item As DataRow In dt.Rows
      Item("FESEST") = HelpClass.FechaNum_a_Fecha(Item("FESEST"))
      Item("FRETES") = HelpClass.FechaNum_a_Fecha(Item("FRETES"))
    Next
    Return dt
  End Function

    Public Function Lista_Detalle_OC_Embarque_Ajuste_Consulta(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_DETALLE_OC_EMBARQUE_CONSULTA", lobjParams)
        ds.Tables(0).TableName = "DET_OC"
        ds.Tables(1).TableName = "COSTOS"
        Return ds
    End Function

    'Public Function Lista_Doc_Embarque_Consulta(ByVal PNCCLNT As Double, ByVal PNNORSCI As Double) As List(Of beDocCargaInternacionalConsulta)
    '  Dim dt As DataTable
    '  Dim oListDocCargaInternacuional As New List(Of beDocCargaInternacionalConsulta)
    '  Dim obeDocCargaInternacionalConsulta As beDocCargaInternacionalConsulta
    '  Dim lobjSql As New SqlManager
    '  Dim lobjParams As New Parameter
    '  lobjParams.Add("PNCCLNT", PNCCLNT)
    '  lobjParams.Add("PNNORSCI", PNNORSCI)
    '  dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DOC_EMBARQUE", lobjParams)
    '  For Each Item As DataRow In dt.Rows
    '    obeDocCargaInternacionalConsulta = New beDocCargaInternacionalConsulta
    '    obeDocCargaInternacionalConsulta.PNNDOCIN = Item("NDOCIN")
    '    obeDocCargaInternacionalConsulta.PNNRPARC = Item("NRPARC")
    '    obeDocCargaInternacionalConsulta.PSNDOCLI = Item("NDOCLI")
    '    obeDocCargaInternacionalConsulta.PSNORCML = Item("NORCML")
    '    obeDocCargaInternacionalConsulta.PNIVFOBD = Item("IVFOBD")
    '    obeDocCargaInternacionalConsulta.PSFCDCOR = Item("FCDCOR").ToString.Trim
    '    obeDocCargaInternacionalConsulta.PSFCDCCP = Item("FCDCCP").ToString.Trim
    '    obeDocCargaInternacionalConsulta.PSURLARC = Item("URLARC")
    '    obeDocCargaInternacionalConsulta.PSTNMBAR = Item("TNMBAR")
    '    obeDocCargaInternacionalConsulta.PNNORSCI = Item("NORSCI")
    '    obeDocCargaInternacionalConsulta.PNNCRRDC = Item("NCRRDC")
    '    obeDocCargaInternacionalConsulta.PNSECSUS = Item("SECSUS")
    '    obeDocCargaInternacionalConsulta.PNEXISTS = 1
    '    oListDocCargaInternacuional.Add(obeDocCargaInternacionalConsulta)
    '  Next
    '  Return oListDocCargaInternacuional
    'End Function

  'Tab Costos de seguimiento
  Public Function Lista_Costos_Seguimiento(ByVal PNNORSCI As Double) As DataSet
    Dim dtDocumentos As New DataTable
    Dim dtCostosDetalle As New DataTable
    Dim dtTipoCostos As New DataTable
    Dim ds As New DataSet
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PNNORSCI", PNNORSCI)
    ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_DOC_COSTO_EMBARQUE_CONSULTA", lobjParams)
    ds.Tables(0).TableName = "DETALLE_DOCUMENTO"
    ds.Tables(1).TableName = "DETALLE_COSTOS"
    ds.Tables(2).TableName = "TIPO_COSTOS"
    Return ds
  End Function

  'Crear tabpages
  Public Function Lista_Variable(ByVal CVARBL As String) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCVARBL", CVARBL)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_VARIABLES", lobjParams)
    Return dt
  End Function

  'Descripcion de los costos de embarque
  Public Function Lista_Concepto_Costo_Embarque(ByVal pstrDescripcion As String) As DataTable
    Dim dt As DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCVARBL", pstrDescripcion)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_VARIABLES", lobjParams)
    Return dt
    End Function



End Class


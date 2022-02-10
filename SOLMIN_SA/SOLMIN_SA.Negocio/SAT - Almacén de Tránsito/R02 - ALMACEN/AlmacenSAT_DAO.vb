Imports System.Xml

Namespace slnSOLMIN_SAT.Almacen
    '-----------------------'
    '-- Registro de Bulto --'
    '-----------------------'
    Public Class clsBultoSAT
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private decQREFFW As Decimal = 0
        Private strTIPBTO As String = ""
        Private decQPSOBL As Decimal = 0
        Private strTUNPSO As String = ""
        Private decQVLBTO As Decimal = 0
        Private strTUNVOL As String = ""
        Private strTUBRFR As String = ""
        Private decQAROCP As Decimal = 0
        Private strDESCWB As String = ""
        Private strSMTRCP As String = ""
        Private strSSNCRG As String = ""
        Private intNTCKPS As Int32 = 0
        Private strSTPING As String = ""
        Private strSTPIMP As String = "S"
#End Region
#Region "Propiedades"
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdecCantidadRecibida_QREFFW() As Decimal
            Get
                Return decQREFFW
            End Get
            Set(ByVal value As Decimal)
                decQREFFW = value
            End Set
        End Property

        Public Property pstrTipoBulto_TIPBTO() As String
            Get
                Return strTIPBTO
            End Get
            Set(ByVal value As String)
                strTIPBTO = value
            End Set
        End Property

        Public Property pdecPesoBulto_QPSOBL() As Decimal
            Get
                Return decQPSOBL
            End Get
            Set(ByVal value As Decimal)
                decQPSOBL = value
            End Set
        End Property

        Public Property pstrUnidadPeso_TUNPSO() As String
            Get
                Return strTUNPSO
            End Get
            Set(ByVal value As String)
                strTUNPSO = value
            End Set
        End Property

        Public Property pdecVolumenBulto_QVLBTO() As Decimal
            Get
                Return decQVLBTO
            End Get
            Set(ByVal value As Decimal)
                decQVLBTO = value
            End Set
        End Property

        Public Property pstrUnidadVolumen_TUNVOL() As String
            Get
                Return strTUNVOL
            End Get
            Set(ByVal value As String)
                strTUNVOL = value
            End Set
        End Property

        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property

        Public Property pdecCantidadAreaOcupada_QAROCP() As Decimal
            Get
                Return decQAROCP
            End Get
            Set(ByVal value As Decimal)
                decQAROCP = value
            End Set
        End Property

        Public Property pstrDescripcionWayBill_DESCWB() As String
            Get
                Return strDESCWB
            End Get
            Set(ByVal value As String)
                strDESCWB = value
            End Set
        End Property

        Public Property pstrMotivoRecepcion_SMTRCP() As String
            Get
                Return strSMTRCP
            End Get
            Set(ByVal value As String)
                strSMTRCP = value
            End Set
        End Property

        Public Property pstrSentidoCarga_SSNCRG() As String
            Get
                Return strSSNCRG
            End Get
            Set(ByVal value As String)
                strSSNCRG = value
            End Set
        End Property

        Public Property pintNroTicketBalanza_NTCKPS() As Int32
            Get
                Return intNTCKPS
            End Get
            Set(ByVal value As Int32)
                intNTCKPS = value
            End Set
        End Property

        Public Property pstrTipoMovimiento_STPING() As String
            Get
                Return strSTPING
            End Get
            Set(ByVal value As String)
                strSTPING = value
            End Set
        End Property

        Public Property pblnStatusImpEtiqBarra() As Boolean
            Get
                Dim blnResultado As Boolean = False
                If strSTPIMP = "S" Then blnResultado = True
            End Get
            Set(ByVal value As Boolean)
                Dim strTemp As String = "N"
                If value Then strTemp = "S"
                strSTPIMP = strTemp
            End Set
        End Property

        Public ReadOnly Property pstrStatusImpEtiqBarra() As String
            Get
                Return strSTPIMP
            End Get
        End Property
#End Region
    End Class

    Public Class clsBulto
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private datFREFFW As Date
        Private datFSLFFW As Date
        Private strCBLTOR As String = ""
        Private decQREFFW As Decimal = 0
        Private strTIPBTO As String = ""
        Private decQPSOBL As Decimal = 0
        Private strTUNPSO As String = ""
        Private decQVLBTO As Decimal = 0
        Private strTUNVOL As String = ""
        Private decQMTALT As Decimal = 0
        Private decQMTANC As Decimal = 0
        Private decQMTLRG As Decimal = 0

        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private dblCPLNDV As Double = 0

        Private strCTPALN As String = ""
        Private strCALMC As String = ""
        Private strCZNALM As String = ""

        Private strSSTINV As String = "0"
        Private datFINGAL As Date
        Private datFSLDAL As Date
        Private intNGUIRM As Int32 = 0
        Private intNROCTL As Int64 = 0
        Private strSTRNSM As String = ""
        Private strTDSCIT As String = ""
        Private strTUBRFR As String = ""
        Private strCREEMB As String = ""
        Private decQAROCP As Decimal = 0
        Private intNORAGN As Int32 = 0
        Private strDESCWB As String = ""
        Private strSALTEM As String = ""
        Private strSMTRCP As String = ""
        Private strSMTRCP_D As String = ""
        Private strSSNCRG As String = ""
        Private strSSNCRG_D As String = ""
        Private strCRTLTE As String = ""
        Private intNTCKPS As Int32 = 0
        Private intQPSTKI As Int32 = 0
        Private strDCENSA As String = ""
        Private strSTPING As String = ""
        Private strSTPING_D As String = ""
        Private decIPBULT As Decimal = 0D
        '-- Seguridad
        Private strCUSCRT As String = ""
        Private datFCHCRT As Date
        Private intHRACRT As Int32 = 0
        Private strCULUSA As String = ""
        Private datFULTAC As Date
        Private intHULTAC As Int32 = 0
        Private strSESTRG As String = ""
        Private strNORCML As String = ""
        Private intUPDATE_IDENT As Int32
#End Region
#Region "Propiedades"

        Public Property pCodigoTipoAlmacen_CTPALN() As String
            Get
                Return strCTPALN
            End Get
            Set(ByVal value As String)
                strCTPALN = value
            End Set
        End Property
        Public Property pCodigoAlmacen_CALMC() As String
            Get
                Return strCALMC
            End Get
            Set(ByVal value As String)
                strCALMC = value
            End Set
        End Property
        Public Property pCodigoZona_CZNALM() As String
            Get
                Return strCZNALM
            End Get
            Set(ByVal value As String)
                strCZNALM = value
            End Set
        End Property


        Private _pNombreSitiodeOrigen_TLUGOR As String
        ''' <summary>
        ''' Lugar de Origen  
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property pNombreSitiodeOrigen_TLUGOR() As String
            Get
                Return _pNombreSitiodeOrigen_TLUGOR
            End Get
            Set(ByVal value As String)
                _pNombreSitiodeOrigen_TLUGOR = value
            End Set
        End Property


        Private _NombreSitioDeDestino_TLUGEN As String
        ''' <summary>
        '''  Lugar de Entrega  
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property NombreSitioDeDestino_TLUGEN() As String
            Get
                Return _NombreSitioDeDestino_TLUGEN
            End Get
            Set(ByVal value As String)
                _NombreSitioDeDestino_TLUGEN = value
            End Set
        End Property

        Private strTCTCST As String
        Public Property pCuentaInputacionTerretre_TCTCST() As String
            Get
                Return strTCTCST
            End Get
            Set(ByVal value As String)
                strTCTCST = value
            End Set
        End Property


        Private strTCTCSA As String
        Public Property pCuentaInputacionAereo_TCTCSA() As String
            Get
                Return strTCTCSA
            End Get
            Set(ByVal value As String)
                strTCTCSA = value
            End Set
        End Property


        Private strTCTCSF As String
        Public Property pCuentaInputacionFluvialTCTCSF() As String
            Get
                Return strTCTCSF
            End Get
            Set(ByVal value As String)
                strTCTCSF = value
            End Set
        End Property



        Private strTCTAFE As String
        Public Property pCuentaInputacionAfeTCTAFE() As String
            Get
                Return strTCTAFE
            End Get
            Set(ByVal value As String)
                strTCTAFE = value
            End Set
        End Property


        Private _pCodigoMedioSugerido As Decimal
        Public Property pCodigoMedioSugerido() As Decimal
            Get
                Return _pCodigoMedioSugerido
            End Get
            Set(ByVal value As Decimal)
                _pCodigoMedioSugerido = value
            End Set
        End Property


        Private _CodigoMedioConfirmado_CMEDTC As Decimal
        Public Property CodigoMedioConfirmado_CMEDTC() As Decimal
            Get
                Return _CodigoMedioConfirmado_CMEDTC
            End Get
            Set(ByVal value As Decimal)
                _CodigoMedioConfirmado_CMEDTC = value
            End Set
        End Property

        Public Property pCodigoCompania_CCMPN() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property

        Public Property pCodigoDivision_CDVSN() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property

        Public Property pCodigoPlanta_CPLNDV() As Double
            Get
                Return dblCPLNDV
            End Get
            Set(ByVal value As Double)
                dblCPLNDV = value
            End Set
        End Property

        Private _pGuiaProveedorNGRPRV As String = ""
        Public Property pGuiaProveedorNGRPRV() As String
            Get
                Return _pGuiaProveedorNGRPRV
            End Get
            Set(ByVal value As String)
                _pGuiaProveedorNGRPRV = value
            End Set
        End Property

        Public Property pCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pCodigoRecepcion_CREFFW() As String
            Get
                pCodigoRecepcion_CREFFW = strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pFechaRecepcionAlmacen_FREFFW() As Date
            Get
                pFechaRecepcionAlmacen_FREFFW = datFREFFW
            End Get
            Set(ByVal value As Date)
                datFREFFW = value
            End Set
        End Property

        Public Property pFechaSalidaAlmacen_FSLFFW() As Date
            Get
                pFechaSalidaAlmacen_FSLFFW = datFSLFFW
            End Get
            Set(ByVal value As Date)
                datFSLFFW = value
            End Set
        End Property


        Private _pMedioEnvio As Decimal
        Public Property pMedioEnvio() As Decimal
            Get
                Return _pMedioEnvio
            End Get
            Set(ByVal value As Decimal)
                _pMedioEnvio = value
            End Set
        End Property

        Public Property pCodigoBultoOrigen_CBLTOR() As String
            Get
                pCodigoBultoOrigen_CBLTOR = strCBLTOR
            End Get
            Set(ByVal value As String)
                strCBLTOR = value
            End Set
        End Property

        Public Property pCantidadRecibida_QREFFW() As Decimal
            Get
                pCantidadRecibida_QREFFW = decQREFFW
            End Get
            Set(ByVal value As Decimal)
                decQREFFW = value
            End Set
        End Property

        Public Property pTipoBulto_TIPBTO() As String
            Get
                pTipoBulto_TIPBTO = strTIPBTO
            End Get
            Set(ByVal value As String)
                strTIPBTO = value
            End Set
        End Property

        Public Property pPesoBulto_QPSOBL() As Decimal
            Get
                pPesoBulto_QPSOBL = decQPSOBL
            End Get
            Set(ByVal value As Decimal)
                decQPSOBL = value
            End Set
        End Property

        Public Property pUnidadPeso_TUNPSO() As String
            Get
                pUnidadPeso_TUNPSO = strTUNPSO
            End Get
            Set(ByVal value As String)
                strTUNPSO = value
            End Set
        End Property

        Public Property pVolumenBulto_QVLBTO() As Decimal
            Get
                pVolumenBulto_QVLBTO = decQVLBTO
            End Get
            Set(ByVal value As Decimal)
                decQVLBTO = value
            End Set
        End Property

        Public Property pUnidadVolumen_TUNVOL() As String
            Get
                pUnidadVolumen_TUNVOL = strTUNVOL
            End Get
            Set(ByVal value As String)
                strTUNVOL = value
            End Set
        End Property

        Public Property pAltura_QMTALT() As Decimal
            Get
                pAltura_QMTALT = decQMTALT
            End Get
            Set(ByVal value As Decimal)
                decQMTALT = value
            End Set
        End Property

        Public Property pAncho_QMTANC() As Decimal
            Get
                pAncho_QMTANC = decQMTANC
            End Get
            Set(ByVal value As Decimal)
                decQMTANC = value
            End Set
        End Property

        Public Property pLargo_QMTLRG() As Decimal
            Get
                pLargo_QMTLRG = decQMTLRG
            End Get
            Set(ByVal value As Decimal)
                decQMTLRG = value
            End Set
        End Property

        Public Property pEstadoInventario_SSTINV() As String
            Get
                pEstadoInventario_SSTINV = strSSTINV
            End Get
            Set(ByVal value As String)
                strSSTINV = value
            End Set
        End Property

        Public Property pFechaIngresoAlmacen_FINGAL() As Date
            Get
                pFechaIngresoAlmacen_FINGAL = datFINGAL
            End Get
            Set(ByVal value As Date)
                datFINGAL = value
            End Set
        End Property

        Public Property pFechaSalidaAlmacen_FSLDAL() As Date
            Get
                pFechaSalidaAlmacen_FSLDAL = datFSLDAL
            End Get
            Set(ByVal value As Date)
                datFSLDAL = value
            End Set
        End Property

        Public Property pNroGuiaRemision_NGUIRM() As Int32
            Get
                pNroGuiaRemision_NGUIRM = intNGUIRM
            End Get
            Set(ByVal value As Int32)
                intNGUIRM = value
            End Set
        End Property

        Public Property pNroControl_NROCTL() As Int64
            Get
                pNroControl_NROCTL = intNROCTL
            End Get
            Set(ByVal value As Int64)
                intNROCTL = value
            End Set
        End Property

        Public Property pEstadoTransmision_STRNSM() As String
            Get
                pEstadoTransmision_STRNSM = strSTRNSM
            End Get
            Set(ByVal value As String)
                strSTRNSM = value
            End Set
        End Property

        Public Property pDescripcionItem_TDSCIT() As String
            Get
                pDescripcionItem_TDSCIT = strTDSCIT
            End Get
            Set(ByVal value As String)
                strTDSCIT = value
            End Set
        End Property

        Public Property pUbicacionReferencial_TUBRFR() As String
            Get
                pUbicacionReferencial_TUBRFR = strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property

        Public Property pCodigoBarraEmbarcador_CREEMB() As String
            Get
                pCodigoBarraEmbarcador_CREEMB = strCREEMB
            End Get
            Set(ByVal value As String)
                strCREEMB = value
            End Set
        End Property

        Public Property pCantidadAreaOcupada_QAROCP() As Decimal
            Get
                pCantidadAreaOcupada_QAROCP = decQAROCP
            End Get
            Set(ByVal value As Decimal)
                decQAROCP = value
            End Set
        End Property

        Public Property pNroOrdenServicioAgencia_NORAGN() As Int32
            Get
                pNroOrdenServicioAgencia_NORAGN = intNORAGN
            End Get
            Set(ByVal value As Int32)
                intNORAGN = value
            End Set
        End Property

        Public Property pDescripcionWayBill_DESCWB() As String
            Get
                pDescripcionWayBill_DESCWB = strDESCWB
            End Get
            Set(ByVal value As String)
                strDESCWB = value
            End Set
        End Property

        Public Property pFlagAlternativoEmbarcador_SALTEM() As String
            Get
                pFlagAlternativoEmbarcador_SALTEM = strSALTEM
            End Get
            Set(ByVal value As String)
                strSALTEM = value
            End Set
        End Property

        Public Property pMotivoRecepcion_SMTRCP() As String
            Get
                pMotivoRecepcion_SMTRCP = strSMTRCP
            End Get
            Set(ByVal value As String)
                strSMTRCP = value
            End Set
        End Property

        Public Property pDetalleMotivoRecepcion_SMTRCP_D() As String
            Get
                pDetalleMotivoRecepcion_SMTRCP_D = strSMTRCP_D
            End Get
            Set(ByVal value As String)
                strSMTRCP_D = value
            End Set
        End Property

        Public Property pSentidoCarga_SSNCRG() As String
            Get
                pSentidoCarga_SSNCRG = strSSNCRG
            End Get
            Set(ByVal value As String)
                strSSNCRG = value
            End Set
        End Property

        Public Property pDetalleSentidoCarga_SSNCRG_D() As String
            Get
                pDetalleSentidoCarga_SSNCRG_D = strSSNCRG_D
            End Get
            Set(ByVal value As String)
                strSSNCRG_D = value
            End Set
        End Property

        Public Property pCriterioLote_CRTLTE() As String
            Get
                pCriterioLote_CRTLTE = strCRTLTE
            End Get
            Set(ByVal value As String)
                strCRTLTE = value
            End Set
        End Property

        Public Property pNroTicketBalanza_NTCKPS() As Int32
            Get
                pNroTicketBalanza_NTCKPS = intNTCKPS
            End Get
            Set(ByVal value As Int32)
                intNTCKPS = value
            End Set
        End Property

        Public Property pPesoTicketBalanza_QPSTKI() As Int32
            Get
                pPesoTicketBalanza_QPSTKI = intQPSTKI
            End Get
            Set(ByVal value As Int32)
                intQPSTKI = value
            End Set
        End Property

        Public Property pDocumentoEntradaSalida_DCENSA() As String
            Get
                pDocumentoEntradaSalida_DCENSA = strDCENSA
            End Get
            Set(ByVal value As String)
                strDCENSA = value
            End Set
        End Property

        Public Property pTipoMovimiento_STPING() As String
            Get
                pTipoMovimiento_STPING = strSTPING
            End Get
            Set(ByVal value As String)
                strSTPING = value
            End Set
        End Property

        Public Property pDetalleTipoMovimiento_STPING_D() As String
            Get
                pDetalleTipoMovimiento_STPING_D = strSTPING_D
            End Get
            Set(ByVal value As String)
                strSTPING_D = value
            End Set
        End Property

        Public Property pImporteBulto_IPBULT() As Decimal
            Get
                pImporteBulto_IPBULT = decIPBULT
            End Get
            Set(ByVal value As Decimal)
                decIPBULT = value
            End Set
        End Property

        Public Property pFlagEstadoRegistro_SESTRG() As String
            Get
                pFlagEstadoRegistro_SESTRG = strSESTRG
            End Get
            Set(ByVal value As String)
                strSESTRG = value
            End Set
        End Property
        Public Property pOrdenDeCompra_NORCML() As String
            Get
                pOrdenDeCompra_NORCML = strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsItemBulto
#Region "Atributos"
        Private intCCLNT As Int32 = 0
        Private strCREFFW As String = ""
        Private strCIDPAQ As String = ""
        Private strNORCML As String = ""
        Private intNRITOC As Int32 = 0
        Private strNFACPR As String = ""
        Private strNRITFP As String = ""
        Private datFFACPR As Date
        Private intNGUIPR As Int32 = 0
        Private decQCNTDC As Decimal = 0.0
        Private decQBLTSR As Decimal = 0.0
        Private decQSLCNB As Decimal = 0.0
        Private strSSTBLT As String = "0"
        Private strSITMAT As String = ""
        Private decQBLRCO As Decimal = 0.0
        Private strTTIPPQ As String = ""
        Private decQPEPQT As Decimal = 0.0
        Private strTUNPSO As String = ""
        Private decQVOPQT As Decimal = 0.0
        Private strTUNVOL As String = ""
        Private decQMTALT As Decimal = 0.0
        Private decQMTANC As Decimal = 0.0
        Private decQMTLRG As Decimal = 0.0
        Private intNRWBLL As Int32 = 0
        Private strNFACMR As String = ""
        'Private intNGUIRM As Int32 = 0
        Private strSESTRG As String = ""
        Private strFLGQDM As String = ""
        Private strCREEMB As String = ""
        Private decLANCOS As Decimal = 0.0
        Private strNFCPRT As String = ""
        Private strNITPRT As String = ""
        Private datFFCPRT As Date
        Private strNGRPRV As String = ""
        Private strSTRNSM As String = ""
        Private intNRGUSA As Int64 = 0
        Private intNSEQCR As Int32 = 0
        '-- Adicionales 
        Private strTDAITM As String = ""
        '-- Seguridad
        Private strCUSCRT As String = ""
        Private datFCHCRT As Date
        Private intHRACRT As Int32 = 0
        Private strCULUSA As String = ""
        Private datFULTAC As Date
        Private intHULTAC As Int32 = 0
        Private intUPDATE_IDENT As Int32 = 0
#End Region
#Region "Propiedades"
        Public Property pCodigoCliente_CCLNT() As Int32
            Get
                pCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int32)
                intCCLNT = value
            End Set
        End Property

        Public Property pCodigoRecepcion_CREFFW() As String
            Get
                pCodigoRecepcion_CREFFW = strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pCodigoIdentificacionPaquete_CIDPAQ() As String
            Get
                pCodigoIdentificacionPaquete_CIDPAQ = strCIDPAQ
            End Get
            Set(ByVal value As String)
                strCIDPAQ = value
            End Set
        End Property

        Public Property pNroOrdenCompra_NORCML() As String
            Get
                pNroOrdenCompra_NORCML = strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = value
            End Set
        End Property

        Public Property pNroItemOrdenCompra_NRITOC() As Int32
            Get
                pNroItemOrdenCompra_NRITOC = intNRITOC
            End Get
            Set(ByVal value As Int32)
                intNRITOC = value
            End Set
        End Property

        Public Property pNroFacturaProveedor_NFACPR() As String
            Get
                pNroFacturaProveedor_NFACPR = strNFACPR
            End Get
            Set(ByVal value As String)
                strNFACPR = value
            End Set
        End Property

        Public Property pNroItemFacturaProveedor_NRITFP() As String
            Get
                pNroItemFacturaProveedor_NRITFP = strNRITFP
            End Get
            Set(ByVal value As String)
                strNRITFP = value
            End Set
        End Property

        Public Property pFechaFacturaProveedor_FFACPR() As Date
            Get
                pFechaFacturaProveedor_FFACPR = datFFACPR
            End Get
            Set(ByVal value As Date)
                datFFACPR = value
            End Set
        End Property

        Public Property pNroGuiaRemisionProveedor_NGUIPR() As Int32
            Get
                pNroGuiaRemisionProveedor_NGUIPR = intNGUIPR
            End Get
            Set(ByVal value As Int32)
                intNGUIPR = value
            End Set
        End Property

        Public Property pCantidadDeclarada_QCNTDC() As Decimal
            Get
                pCantidadDeclarada_QCNTDC = decQCNTDC
            End Get
            Set(ByVal value As Decimal)
                decQCNTDC = value
            End Set
        End Property

        Public Property pCantidadBultosRecibidos_QBLTSR() As Decimal
            Get
                pCantidadBultosRecibidos_QBLTSR = decQBLTSR
            End Get
            Set(ByVal value As Decimal)
                decQBLTSR = value
            End Set
        End Property

        Public Property pSaldoCantidadBultos_QSLCNB() As Decimal
            Get
                pSaldoCantidadBultos_QSLCNB = decQSLCNB
            End Get
            Set(ByVal value As Decimal)
                decQSLCNB = value
            End Set
        End Property

        Public Property pEstadoBulto_SSTBLT() As String
            Get
                pEstadoBulto_SSTBLT = strSSTBLT
            End Get
            Set(ByVal value As String)
                strSSTBLT = value
            End Set
        End Property

        Public Property pFlagItemAutorizado_SITMAT() As String
            Get
                pFlagItemAutorizado_SITMAT = strSITMAT
            End Get
            Set(ByVal value As String)
                strSITMAT = value
            End Set
        End Property

        Public Property pCantidadBultosRecibidosOriginal_QBLRCO() As Decimal
            Get
                pCantidadBultosRecibidosOriginal_QBLRCO = decQBLRCO
            End Get
            Set(ByVal value As Decimal)
                decQBLRCO = value
            End Set
        End Property

        Public Property pTipoPaquete_TTIPPQ() As String
            Get
                pTipoPaquete_TTIPPQ = strTTIPPQ
            End Get
            Set(ByVal value As String)
                strTTIPPQ = value
            End Set
        End Property

        Public Property pPesoPaquete_QPEPQT() As Decimal
            Get
                pPesoPaquete_QPEPQT = decQPEPQT
            End Get
            Set(ByVal value As Decimal)
                decQPEPQT = value
            End Set
        End Property

        Public Property pUnidadPeso_TUNPSO() As String
            Get
                pUnidadPeso_TUNPSO = strTUNPSO
            End Get
            Set(ByVal value As String)
                strTUNPSO = value
            End Set
        End Property

        Public Property pVolumenPaquete_QVOPQT() As Decimal
            Get
                pVolumenPaquete_QVOPQT = decQVOPQT
            End Get
            Set(ByVal value As Decimal)
                decQVOPQT = value
            End Set
        End Property

        Public Property pUnidadVolumen_TUNVOL() As String
            Get
                pUnidadVolumen_TUNVOL = strTUNVOL
            End Get
            Set(ByVal value As String)
                strTUNVOL = value
            End Set
        End Property

        Public Property pAltura_QMTALT() As Decimal
            Get
                pAltura_QMTALT = decQMTALT
            End Get
            Set(ByVal value As Decimal)
                decQMTALT = value
            End Set
        End Property

        Public Property pAncho_QMTANC() As Decimal
            Get
                pAncho_QMTANC = decQMTANC
            End Get
            Set(ByVal value As Decimal)
                decQMTANC = value
            End Set
        End Property

        Public Property pLargo_QMTLRG() As Decimal
            Get
                pLargo_QMTLRG = decQMTLRG
            End Get
            Set(ByVal value As Decimal)
                decQMTLRG = value
            End Set
        End Property

        Public Property pNroWayBill_NRWBLL() As Int32
            Get
                pNroWayBill_NRWBLL = intNRWBLL
            End Get
            Set(ByVal value As Int32)
                intNRWBLL = value
            End Set
        End Property

        Public Property pNroFacturaMR_NFACMR() As String
            Get
                pNroFacturaMR_NFACMR = strNFACMR
            End Get
            Set(ByVal value As String)
                strNFACMR = value
            End Set
        End Property

        Public Property pFlagEstadoRegistro_SESTRG() As String
            Get
                pFlagEstadoRegistro_SESTRG = strSESTRG
            End Get
            Set(ByVal value As String)
                strSESTRG = value
            End Set
        End Property

        Public Property pFlagDctoQuadrem_FLGQDM() As String
            Get
                pFlagDctoQuadrem_FLGQDM = strFLGQDM
            End Get
            Set(ByVal value As String)
                strFLGQDM = value
            End Set
        End Property

        Public Property pCodigoBarraEmbarcador_CREEMB() As String
            Get
                pCodigoBarraEmbarcador_CREEMB = strCREEMB
            End Get
            Set(ByVal value As String)
                strCREEMB = value
            End Set
        End Property

        Public Property pLandedCostValue_LANCOS() As Decimal
            Get
                pLandedCostValue_LANCOS = decLANCOS
            End Get
            Set(ByVal value As Decimal)
                decLANCOS = value
            End Set
        End Property

        Public Property pNroFacturaProveedor_NFCPRT() As String
            Get
                pNroFacturaProveedor_NFCPRT = strNFCPRT
            End Get
            Set(ByVal value As String)
                strNFCPRT = value
            End Set
        End Property

        Public Property pNroItemFacturaProveedor_NITPRT() As String
            Get
                pNroItemFacturaProveedor_NITPRT = strNITPRT
            End Get
            Set(ByVal value As String)
                strNITPRT = value
            End Set
        End Property

        Public Property pFechaFacturaProveedor_FFCPRT() As Date
            Get
                pFechaFacturaProveedor_FFCPRT = datFFCPRT
            End Get
            Set(ByVal value As Date)
                datFFCPRT = value
            End Set
        End Property

        Public Property pNroGuiaRemisionProveedor_NGRPRV() As String
            Get
                pNroGuiaRemisionProveedor_NGRPRV = strNGRPRV
            End Get
            Set(ByVal value As String)
                strNGRPRV = value
            End Set
        End Property

        Public Property pEstadoTransmision_STRNSM() As String
            Get
                pEstadoTransmision_STRNSM = strSTRNSM
            End Get
            Set(ByVal value As String)
                strSTRNSM = value
            End Set
        End Property

        Public Property pNroGuiaSalida_NRGUSA() As Int64
            Get
                pNroGuiaSalida_NRGUSA = intNRGUSA
            End Get
            Set(ByVal value As Int64)
                intNRGUSA = value
            End Set
        End Property

        Public Property pNroSecuencia_NSEQCR() As Int32
            Get
                pNroSecuencia_NSEQCR = intNSEQCR
            End Get
            Set(ByVal value As Int32)
                intNSEQCR = value
            End Set
        End Property

        Public Property pObservacionItemBulto_TDAITM() As String
            Get
                pObservacionItemBulto_TDAITM = strTDAITM
            End Get
            Set(ByVal value As String)
                strTDAITM = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsRegItemBulto
#Region "Atributos"
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private strNORCML As String = ""
        Private intNRITOC As Int32 = 0
        Private strNFACPR As String = ""
        Private dteFFACPR As Date
        Private strNGRPRV As String = ""
        Private decQBLTSR As Decimal = 0.0
        '-- Adicionales 
        Private strTDAITM As String = ""
#End Region
#Region "Propiedades"
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pstrNroOrdenCompra_NORCML() As String
            Get
                Return strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = value
            End Set
        End Property

        Public Property pintNroItemOrdenCompra_NRITOC() As Int32
            Get
                Return intNRITOC
            End Get
            Set(ByVal value As Int32)
                intNRITOC = value
            End Set
        End Property

        Public Property pstrNroFacturaProveedor_NFACPR() As String
            Get
                Return strNFACPR
            End Get
            Set(ByVal value As String)
                strNFACPR = value
            End Set
        End Property

        Public Property pdteFechaFacturaProveedor_FFACPR() As Date
            Get
                Return dteFFACPR
            End Get
            Set(ByVal value As Date)
                dteFFACPR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaFacturaProveedor_FFec_FFACPR() As String
            Get
                Dim strResultado As String = ""
                If dteFFACPR.Year > 1 Then strResultado = dteFFACPR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaFacturaProveedor_FNum_FFACPR() As String
            Get
                Dim strResultado As String = ""
                If dteFFACPR.Year > 1 Then strResultado = dteFFACPR.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaFacturaProveedor_FFACPR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFFACPR.Year > 1 Then Integer.TryParse(dteFFACPR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrNroGuiaRemisionProveedor_NGRPRV() As String
            Get
                Return strNGRPRV
            End Get
            Set(ByVal value As String)
                strNGRPRV = value
            End Set
        End Property

        Public Property pdecCantidadBultosRecibidos_QBLTSR() As Decimal
            Get
                Return decQBLTSR
            End Get
            Set(ByVal value As Decimal)
                decQBLTSR = value
            End Set
        End Property

        Public Property pstrObservacionItemBulto_TDAITM() As String
            Get
                Return strTDAITM
            End Get
            Set(ByVal value As String)
                strTDAITM = value
            End Set
        End Property
#End Region
    End Class

    '---------------'
    '-- Repacking --'
    '---------------'
    Public Class clsInfRepacking
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private dteFREFFW As Date
        Private strCBLTOR As String = ""
        Private decQREFFW As Decimal = 0
        Private strTIPBTO As String = ""
        Private decQPSOBL As Decimal = 0
        Private strTUNPSO As String = ""
        Private decQVLBTO As Decimal = 0
        Private strTUNVOL As String = ""
        Private decQAROCP As Decimal = 0
        Private strTUBRFR As String = ""
        Private strDESCWB As String = ""
#End Region
#Region "Propiedades"
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdteFechaRecepcionAlmacen_FREFFW() As Date
            Get
                Return dteFREFFW
            End Get
            Set(ByVal value As Date)
                dteFREFFW = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaRecepcionAlmacen_FFec_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW.Year > 1 Then strResultado = dteFREFFW.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaRecepcionAlmacen_FNum_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW.Year > 1 Then strResultado = dteFREFFW.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaRecepcionAlmacen_FREFFW() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFREFFW.Year > 1 Then Integer.TryParse(dteFREFFW.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrCodigoBultoOrigen_CBLTOR() As String
            Get
                Return strCBLTOR
            End Get
            Set(ByVal value As String)
                strCBLTOR = value
            End Set
        End Property

        Public Property pdecCantidadRecibida_QREFFW() As Decimal
            Get
                Return decQREFFW
            End Get
            Set(ByVal value As Decimal)
                decQREFFW = value
            End Set
        End Property

        Public Property pstrTipoBulto_TIPBTO() As String
            Get
                Return strTIPBTO
            End Get
            Set(ByVal value As String)
                strTIPBTO = value
            End Set
        End Property

        Public Property pdecPesoBulto_QPSOBL() As Decimal
            Get
                Return decQPSOBL
            End Get
            Set(ByVal value As Decimal)
                decQPSOBL = value
            End Set
        End Property

        Public Property pstrUnidadPeso_TUNPSO() As String
            Get
                Return strTUNPSO
            End Get
            Set(ByVal value As String)
                strTUNPSO = value
            End Set
        End Property

        Public Property pdecVolumenBulto_QVLBTO() As Decimal
            Get
                Return decQVLBTO
            End Get
            Set(ByVal value As Decimal)
                decQVLBTO = value
            End Set
        End Property

        Public Property pstrUnidadVolumen_TUNVOL() As String
            Get
                Return strTUNVOL
            End Get
            Set(ByVal value As String)
                strTUNVOL = value
            End Set
        End Property

        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property

        Public Property pdecCantidadAreaOcupada_QAROCP() As Decimal
            Get
                Return decQAROCP
            End Get
            Set(ByVal value As Decimal)
                decQAROCP = value
            End Set
        End Property

        Public Property pstrDescripcionWayBill_DESCWB() As String
            Get
                Return strDESCWB
            End Get
            Set(ByVal value As String)
                strDESCWB = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsBultoRepacking
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private dteFREFFW As Date
        Private strCBLTOR As String = ""
        Private decQREFFW As Decimal = 0
        Private strTIPBTO As String = ""
        Private decQPSOBL As Decimal = 0
        Private strTUNPSO As String = ""
        Private decQVLBTO As Decimal = 0
        Private strTUNVOL As String = ""
        Private decQAROCP As Decimal = 0
        Private strTUBRFR As String = ""
        Private strDESCWB As String = ""

        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private dblCPLNDV As Double = 0
        ' Items Repacking
        Private lstItemBultoRepacking As List(Of clsItemBultoRepacking)
        Private lstSubItemBultoRepacking As List(Of clsSubItemBultoRepacking)
#End Region
#Region "Propiedades"
        Sub New()
            lstItemBultoRepacking = New List(Of clsItemBultoRepacking)
            lstSubItemBultoRepacking = New List(Of clsSubItemBultoRepacking)
        End Sub

        Public Property pstrCodigoCompania_CCMPN() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property
        Public Property pstrCodigoDivision_CDVSN() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property
        Public Property pdblCodigoPlanta_CPLNDV() As Double
            Get
                Return dblCPLNDV
            End Get
            Set(ByVal value As Double)
                dblCPLNDV = value
            End Set
        End Property
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property
        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property


        Private _dblNSEQIN As Decimal
        Public Property pdblCorrelativo_NSEQIN() As Decimal
            Get
                Return _dblNSEQIN
            End Get
            Set(ByVal value As Decimal)
                _dblNSEQIN = value
            End Set
        End Property

        Public Property pdteFechaRecepcionAlmacen_FREFFW() As Date
            Get
                Return dteFREFFW
            End Get
            Set(ByVal value As Date)
                dteFREFFW = value
            End Set
        End Property
        Public ReadOnly Property pstrFechaRecepcionAlmacen_FFec_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW.Year > 1 Then strResultado = dteFREFFW.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pstrFechaRecepcionAlmacen_FNum_FREFFW() As String
            Get
                Dim strResultado As String = ""
                If dteFREFFW.Year > 1 Then strResultado = dteFREFFW.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaRecepcionAlmacen_FREFFW() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFREFFW.Year > 1 Then Integer.TryParse(dteFREFFW.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
        Public Property pstrCodigoBultoOrigen_CBLTOR() As String
            Get
                Return strCBLTOR
            End Get
            Set(ByVal value As String)
                strCBLTOR = value
            End Set
        End Property
        Public Property pdecCantidadRecibida_QREFFW() As Decimal
            Get
                Return decQREFFW
            End Get
            Set(ByVal value As Decimal)
                decQREFFW = value
            End Set
        End Property
        Public Property pstrTipoBulto_TIPBTO() As String
            Get
                Return strTIPBTO
            End Get
            Set(ByVal value As String)
                strTIPBTO = value
            End Set
        End Property
        Public Property pdecPesoBulto_QPSOBL() As Decimal
            Get
                Return decQPSOBL
            End Get
            Set(ByVal value As Decimal)
                decQPSOBL = value
            End Set
        End Property
        Public Property pstrUnidadPeso_TUNPSO() As String
            Get
                Return strTUNPSO
            End Get
            Set(ByVal value As String)
                strTUNPSO = value
            End Set
        End Property
        Public Property pdecVolumenBulto_QVLBTO() As Decimal
            Get
                Return decQVLBTO
            End Get
            Set(ByVal value As Decimal)
                decQVLBTO = value
            End Set
        End Property
        Public Property pstrUnidadVolumen_TUNVOL() As String
            Get
                Return strTUNVOL
            End Get
            Set(ByVal value As String)
                strTUNVOL = value
            End Set
        End Property
        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property
        Public Property pdecCantidadAreaOcupada_QAROCP() As Decimal
            Get
                Return decQAROCP
            End Get
            Set(ByVal value As Decimal)
                decQAROCP = value
            End Set
        End Property
        Public Property pstrDescripcionWayBill_DESCWB() As String
            Get
                Return strDESCWB
            End Get
            Set(ByVal value As String)
                strDESCWB = value
            End Set
        End Property
        Public ReadOnly Property plstItemBultoRepacking() As List(Of clsItemBultoRepacking)
            Get
                Return lstItemBultoRepacking
            End Get
        End Property
        Public ReadOnly Property plstSubItemBultoRepacking() As List(Of clsSubItemBultoRepacking)
            Get
                Return lstSubItemBultoRepacking
            End Get
        End Property
        Public Sub AddItemBultoRepacking(ByVal objItemBultoRepacking As clsItemBultoRepacking)
            lstItemBultoRepacking.Add(objItemBultoRepacking)
        End Sub
        Public Sub AddSubItemBultoRepacking(ByVal objSubItemBultoRepacking As clsSubItemBultoRepacking)
            lstSubItemBultoRepacking.Add(objSubItemBultoRepacking)
        End Sub

        Public Sub DeleteItemBultoRepacking(ByVal objItemBultoRepacking As clsItemBultoRepacking)
            lstItemBultoRepacking.Remove(objItemBultoRepacking)
        End Sub
        Public Sub DeleteSubItemBultoRepacking(ByVal objSubItemBultoRepacking As clsSubItemBultoRepacking)
            lstSubItemBultoRepacking.Remove(objSubItemBultoRepacking)
        End Sub
#End Region
    End Class

    Public Class clsItemBultoRepacking
#Region "Atributos"
        Private strCIDPAQ As String = ""
        Private strNORCML As String = ""
        Private intNRITOC As Int32 = 0
        Private decQBLTRP As Decimal = 0.0
        Private _strTDAITM As String = ""
#End Region
#Region "Propiedades"
        Public Property pstrCodigoIdentificacionPaquete_CIDPAQ() As String
            Get
                Return strCIDPAQ
            End Get
            Set(ByVal value As String)
                strCIDPAQ = value
            End Set
        End Property

        Public Property pstrNroOrdenCompra_NORCML() As String
            Get
                Return strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = value
            End Set
        End Property


        Private _pstrCodigoCompania_CCMPN As String
        Public Property pstrCodigoCompania_CCMPN() As String
            Get
                Return _pstrCodigoCompania_CCMPN
            End Get
            Set(ByVal value As String)
                _pstrCodigoCompania_CCMPN = value
            End Set
        End Property


        Private _PpstrCodigoDivision_CDVSN As String
        Public Property pstrCodigoDivision_CDVSN() As String
            Get
                Return _PpstrCodigoDivision_CDVSN
            End Get
            Set(ByVal value As String)
                _PpstrCodigoDivision_CDVSN = value
            End Set
        End Property

        Private _pdblCodigoPlanta_CPLNDV As Decimal
        Public Property pdblCodigoPlanta_CPLNDV() As Decimal
            Get
                Return _pdblCodigoPlanta_CPLNDV
            End Get
            Set(ByVal value As Decimal)
                _pdblCodigoPlanta_CPLNDV = value
            End Set
        End Property

        Private _dblNSEQIN As Decimal
        Public Property pdblCorrelativo_NSEQIN() As Decimal
            Get
                Return _dblNSEQIN
            End Get
            Set(ByVal value As Decimal)
                _dblNSEQIN = value
            End Set
        End Property


        Public Property pintNroItemOrdenCompra_NRITOC() As Int32
            Get
                Return intNRITOC
            End Get
            Set(ByVal value As Int32)
                intNRITOC = value
            End Set
        End Property

        Public Property pdecCantidadRepacking_QBLTRP() As Decimal
            Get
                Return decQBLTRP
            End Get
            Set(ByVal value As Decimal)
                decQBLTRP = value
            End Set
        End Property


        Public Property Observaciones_Item_Bulto_TDAITM() As String
            Get
                Return _strTDAITM
            End Get
            Set(ByVal value As String)
                _strTDAITM = value
            End Set
        End Property

#End Region
    End Class

    Public Class clsSubItemBultoRepacking
#Region "Atributos"
        Private strCIDPAQ As String = ""
        Private strNORCML As String = ""
        Private intNRITOC As String = ""


        Private strSBITOC As String = ""
        Private decQCNRCP As Decimal = 0.0
#End Region
#Region "Propiedades"

        Public Property pstrCodigoIdentificacionPaquete_CIDPAQ() As String
            Get
                Return strCIDPAQ
            End Get
            Set(ByVal value As String)
                strCIDPAQ = value
            End Set
        End Property

        Public Property pstrNroOrdenCompra_NORCML() As String
            Get
                Return strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = value
            End Set
        End Property

        Public Property pintNroItemOrdenCompra_NRITOC() As Int32
            Get
                Return intNRITOC
            End Get
            Set(ByVal value As Int32)
                intNRITOC = value
            End Set
        End Property

        Public Property pstrCodigoSubItem_SBITOC() As String
            Get
                Return strSBITOC
            End Get
            Set(ByVal value As String)
                strSBITOC = value
            End Set
        End Property

        Public Property pdecCantidadRepacking_QCNRCP() As Decimal
            Get
                Return decQCNRCP
            End Get
            Set(ByVal value As Decimal)
                decQCNRCP = value
            End Set
        End Property

        Private _pstrCodigoCompania_CCMPN As String
        Public Property pstrCodigoCompania_CCMPN() As String
            Get
                Return _pstrCodigoCompania_CCMPN
            End Get
            Set(ByVal value As String)
                _pstrCodigoCompania_CCMPN = value
            End Set
        End Property


        Private _PpstrCodigoDivision_CDVSN As String
        Public Property pstrCodigoDivision_CDVSN() As String
            Get
                Return _PpstrCodigoDivision_CDVSN
            End Get
            Set(ByVal value As String)
                _PpstrCodigoDivision_CDVSN = value
            End Set
        End Property

        Private _pdblCodigoPlanta_CPLNDV As Decimal
        Public Property pdblCodigoPlanta_CPLNDV() As Decimal
            Get
                Return _pdblCodigoPlanta_CPLNDV
            End Get
            Set(ByVal value As Decimal)
                _pdblCodigoPlanta_CPLNDV = value
            End Set
        End Property
#End Region
    End Class

    '--------------------------------'
    '-- Ingreso al Almacen por PDT --'
    '--------------------------------'
    Public Class clsWSBultos
#Region "Atributos"
        Private lstWSBultos As List(Of clsWSBulto)
#End Region
#Region "Propiedades"
        Sub New()
            lstWSBultos = New List(Of clsWSBulto)
        End Sub

        Public ReadOnly Property plstWSBultos() As List(Of clsWSBulto)
            Get
                Return lstWSBultos
            End Get
        End Property

        Public Sub AddBulto(ByVal objWSBulto As clsWSBulto)
            lstWSBultos.Add(objWSBulto)
        End Sub

        Public Sub DeleteBulto(ByVal objWSBulto As clsWSBulto)
            lstWSBultos.Remove(objWSBulto)
        End Sub
#End Region
    End Class

    Public Class clsWSBulto
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""
        Private datFREFFW As Date
        Private decQREFFW As Decimal = 0
        Private strTIPBTO As String = ""
        Private decQPSOBL As Decimal = 0
        Private strTUNPSO As String = ""
        Private decQVLBTO As Decimal = 0
        Private strTUNVOL As String = ""
        Private strTUBRFR As String = ""
        Private decQAROCP As Decimal = 0
        Private strDESCWB As String = ""
        Private strSMTRCP As String = ""
        Private strSSNCRG As String = ""
        Private intNTCKPS As Int32 = 0
        Private strSTPING As String = ""
        Private strNGRPRV As String = ""
        Private strNFACPR As String = ""
        Private intFFACPR As Int32 = 0
        Private strNORCML As String = ""
        Private lstListaItemOC As List(Of clsWSItemBulto)
#End Region
#Region "Propiedades"
        Sub New()
            lstListaItemOC = New List(Of clsWSItemBulto)
        End Sub

        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdteFechaRecepcionAlmacen_FREFFW() As Date
            Get
                Return datFREFFW
            End Get
            Set(ByVal value As Date)
                datFREFFW = value
            End Set
        End Property

        Public Property pdecCantidadRecibida_QREFFW() As Decimal
            Get
                Return decQREFFW
            End Get
            Set(ByVal value As Decimal)
                decQREFFW = value
            End Set
        End Property

        Public Property pstrTipoBulto_TIPBTO() As String
            Get
                Return strTIPBTO
            End Get
            Set(ByVal value As String)
                strTIPBTO = value
            End Set
        End Property

        Public Property pdecPesoBulto_QPSOBL() As Decimal
            Get
                Return decQPSOBL
            End Get
            Set(ByVal value As Decimal)
                decQPSOBL = value
            End Set
        End Property

        Public Property pstrUnidadPeso_TUNPSO() As String
            Get
                Return strTUNPSO
            End Get
            Set(ByVal value As String)
                strTUNPSO = value
            End Set
        End Property

        Public Property pdecVolumenBulto_QVLBTO() As Decimal
            Get
                Return decQVLBTO
            End Get
            Set(ByVal value As Decimal)
                decQVLBTO = value
            End Set
        End Property

        Public Property pstrUnidadVolumen_TUNVOL() As String
            Get
                Return strTUNVOL
            End Get
            Set(ByVal value As String)
                strTUNVOL = value
            End Set
        End Property

        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property

        Public Property pdecCantidadAreaOcupada_QAROCP() As Decimal
            Get
                Return decQAROCP
            End Get
            Set(ByVal value As Decimal)
                decQAROCP = value
            End Set
        End Property

        Public Property pstrDescripcionWayBill_DESCWB() As String
            Get
                Return strDESCWB
            End Get
            Set(ByVal value As String)
                strDESCWB = value
            End Set
        End Property

        Public Property pstrMotivoRecepcion_SMTRCP() As String
            Get
                Return strSMTRCP
            End Get
            Set(ByVal value As String)
                strSMTRCP = value
            End Set
        End Property

        Public Property pstrSentidoCarga_SSNCRG() As String
            Get
                Return strSSNCRG
            End Get
            Set(ByVal value As String)
                strSSNCRG = value
            End Set
        End Property

        Public Property pintNroTicketBalanza_NTCKPS() As Int32
            Get
                Return intNTCKPS
            End Get
            Set(ByVal value As Int32)
                intNTCKPS = value
            End Set
        End Property

        Public Property pstrTipoMovimiento_STPING() As String
            Get
                Return strSTPING
            End Get
            Set(ByVal value As String)
                strSTPING = value
            End Set
        End Property

        Public Property pstrNroGuiaRemisionProveedor_NGRPRV() As String
            Get
                Return strNGRPRV
            End Get
            Set(ByVal value As String)
                strNGRPRV = value
            End Set
        End Property

        Public Property pstrNroFacturaProveedor_NFACPR() As String
            Get
                Return strNFACPR
            End Get
            Set(ByVal value As String)
                strNFACPR = value
            End Set
        End Property

        Public Property pintFechaFacturaProveedor_FFACPR() As Int32
            Get
                Return intFFACPR
            End Get
            Set(ByVal value As Int32)
                intFFACPR = value
            End Set
        End Property

        Public Property pstrNroOrdenCompra_NORCML() As String
            Get
                Return strNORCML
            End Get
            Set(ByVal value As String)
                strNORCML = value
            End Set
        End Property

        Public ReadOnly Property plstWSItemsBulto() As List(Of clsWSItemBulto)
            Get
                Return lstListaItemOC
            End Get
        End Property

        Public Sub AddItemBulto(ByVal objWSItemBulto As clsWSItemBulto)
            lstListaItemOC.Add(objWSItemBulto)
        End Sub

        Public Sub DeleteItemBulto(ByVal objWSItemBulto As clsWSItemBulto)
            lstListaItemOC.Remove(objWSItemBulto)
        End Sub
#End Region
    End Class

    Public Class clsWSItemBulto
#Region "Atributos"
        Private intNRITOC As Int32 = 0
        Private decQCNREC As Decimal = 0.0
        Private strTDAITM As String = ""
#End Region
#Region "Propiedades"
        Public Property pintNroItemOrdenCompra_NRITOC() As Int32
            Get
                Return intNRITOC
            End Get
            Set(ByVal value As Int32)
                intNRITOC = value
            End Set
        End Property

        Public Property pdecCantidadRecibida_QCNREC() As Decimal
            Get
                Return decQCNREC
            End Get
            Set(ByVal value As Decimal)
                decQCNREC = value
            End Set
        End Property

        Public Property pstrObservacionItemBulto_TDAITM() As String
            Get
                Return strTDAITM
            End Get
            Set(ByVal value As String)
                strTDAITM = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsWSErrorBulto
#Region "Atributos"
        Private XMLError As XmlDocument
#End Region
#Region "Propiedades"
        Sub New()
            ' Documento XML detallando el Error de los registros
            XMLError = New XmlDocument()
            ' Write down the XML declaration
            Dim xmlDeclaration As XmlDeclaration = XMLError.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            ' Create the root element
            Dim rootNode As XmlElement = XMLError.CreateElement("ERRORES")
            XMLError.InsertBefore(xmlDeclaration, XMLError.DocumentElement)
            XMLError.AppendChild(rootNode)
        End Sub

        Public ReadOnly Property xmlErrorMsg() As XmlDocument
            Get
                Return XMLError
            End Get
        End Property

        Public Sub pAddError(ByVal strErrorCode As String, ByVal strMensajeError As String, ByVal strOrdenCompra As String, ByVal strBulto As String, _
                             ByVal strCliente As String, ByVal strItem As String)
            Dim parentNode As XmlElement = Nothing
            Dim itemNode As XmlElement = Nothing

            parentNode = XMLError.CreateElement("ERRORBULTOS")
            XMLError.DocumentElement.PrependChild(parentNode)

            ' Crea los nodos requeridos de la cabecera
            Dim ErrorCode_Node As XmlElement = XMLError.CreateElement("ERRCOD")
            Dim ErrorMsg_Node As XmlElement = XMLError.CreateElement("ERRMSG")
            Dim OrdenCompra_Node As XmlElement = XMLError.CreateElement("NORCML")
            Dim Bulto_Node As XmlElement = XMLError.CreateElement("CREFFW")
            Dim Cliente_Node As XmlElement = XMLError.CreateElement("CCLNT")
            Dim NroItem_Node As XmlElement = XMLError.CreateElement("NRITOC")


            ' Asigna los valores respectivos a los nodos de la cabecera
            Dim ErrorCode_Text As XmlText = XMLError.CreateTextNode(strErrorCode)
            Dim ErrorMsg_Text As XmlText = XMLError.CreateTextNode(strMensajeError)
            Dim OrdenCompra_Text As XmlText = XMLError.CreateTextNode(strOrdenCompra)
            Dim Bulto_Text As XmlText = XMLError.CreateTextNode(strBulto)
            Dim Cliente_Text As XmlText = XMLError.CreateTextNode(strCliente)
            Dim NroItem_Text As XmlText = XMLError.CreateTextNode(strItem)


            ' Añade los nodos al nodo padre son los valores
            parentNode.AppendChild(ErrorCode_Node)
            parentNode.AppendChild(ErrorMsg_Node)
            parentNode.AppendChild(OrdenCompra_Node)
            parentNode.AppendChild(Bulto_Node)
            parentNode.AppendChild(Cliente_Node)
            parentNode.AppendChild(NroItem_Node)

            ' Se guarda los valores en los respectivos nodos
            ErrorCode_Node.AppendChild(ErrorCode_Text)
            ErrorMsg_Node.AppendChild(ErrorMsg_Text)
            OrdenCompra_Node.AppendChild(OrdenCompra_Text)
            Bulto_Node.AppendChild(Bulto_Text)
            Cliente_Node.AppendChild(Cliente_Text)
            NroItem_Node.AppendChild(NroItem_Text)
        End Sub
#End Region
    End Class

    '-------------------------'
    '-- Paletizado para PDT --'
    '-------------------------'
    Public Class clsWSPaletas
#Region "Atributos"
        Private lstWSPaletas As List(Of clsWSPaleta) = New List(Of clsWSPaleta)
#End Region
#Region "Propiedades"
        Public ReadOnly Property plstWSPaletas() As List(Of clsWSPaleta)
            Get
                Return lstWSPaletas
            End Get
        End Property

        Public Sub AddPaleta(ByVal objWSPaleta As clsWSPaleta)
            lstWSPaletas.Add(objWSPaleta)
        End Sub

        Public Sub DeletePaleta(ByVal objWSPaleta As clsWSPaleta)
            lstWSPaletas.Remove(objWSPaleta)
        End Sub
#End Region
    End Class

    Public Class clsWSPaleta
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private strNROPLT As String = ""
        Private strCRTLTE As String = ""
        Private lstListaBultosPorPaleta As List(Of clsWSBultoPorPaleta) = New List(Of clsWSBultoPorPaleta)
#End Region
#Region "Propiedades"
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrNroPaleta_NROPLT() As String
            Get
                Return strNROPLT
            End Get
            Set(ByVal value As String)
                strNROPLT = value
            End Set
        End Property

        Public Property pstrCriterioLote_CRTLTE() As String
            Get
                Return strCRTLTE
            End Get
            Set(ByVal value As String)
                strCRTLTE = value
            End Set
        End Property

        Public ReadOnly Property plstWSBultosPorPaleta() As List(Of clsWSBultoPorPaleta)
            Get
                Return lstListaBultosPorPaleta
            End Get
        End Property

        Public Sub AgregarBulto(ByVal objWSBultoPorPaleta As clsWSBultoPorPaleta)
            lstListaBultosPorPaleta.Add(objWSBultoPorPaleta)
        End Sub

        Public Sub EliminarBulto(ByVal objWSBultoPorPaleta As clsWSBultoPorPaleta)
            lstListaBultosPorPaleta.Remove(objWSBultoPorPaleta)
        End Sub
#End Region
    End Class

    Public Class clsWSBultoPorPaleta
#Region "Atributos"
        Private strCREFFW As String = ""
        Private decQREFFW As Decimal = 0
        Private decQREPLT As Decimal = 0
#End Region
#Region "Propiedades"
        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdecCantidadRecibida_QREFFW() As Decimal
            Get
                Return decQREFFW
            End Get
            Set(ByVal value As Decimal)
                decQREFFW = value
            End Set
        End Property

        Public Property pdecCantidadPorPaleta_QREPLT() As Decimal
            Get
                Return decQREPLT
            End Get
            Set(ByVal value As Decimal)
                decQREPLT = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsWSErrorPaletizado
#Region "Atributos"
        Private XMLError As XmlDocument
#End Region
#Region "Propiedades"
        Sub New()
            ' Documento XML detallando el Error de los registros
            XMLError = New XmlDocument()
            ' Write down the XML declaration
            Dim xmlDeclaration As XmlDeclaration = XMLError.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            ' Create the root element
            Dim rootNode As XmlElement = XMLError.CreateElement("ERRORES")
            XMLError.InsertBefore(xmlDeclaration, XMLError.DocumentElement)
            XMLError.AppendChild(rootNode)
        End Sub

        Public ReadOnly Property xmlErrorMsg() As XmlDocument
            Get
                Return XMLError
            End Get
        End Property

        Public Sub pAddError(ByVal strErrorCode As String, ByVal strMensajeError As String, ByVal strCliente As String, ByVal strNroPaleta As String, _
                             ByVal strBulto As String)
            Dim parentNode As XmlElement = Nothing
            Dim itemNode As XmlElement = Nothing

            parentNode = XMLError.CreateElement("ERRORPALETA")
            XMLError.DocumentElement.PrependChild(parentNode)

            ' Crea los nodos requeridos de la cabecera
            Dim ErrorCode_Node As XmlElement = XMLError.CreateElement("ERRCOD")
            Dim ErrorMsg_Node As XmlElement = XMLError.CreateElement("ERRMSG")
            Dim Cliente_Node As XmlElement = XMLError.CreateElement("CCLNT")
            Dim NroPaleta_Node As XmlElement = XMLError.CreateElement("NROPLT")
            Dim Bulto_Node As XmlElement = XMLError.CreateElement("CREFFW")

            ' Asigna los valores respectivos a los nodos de la cabecera
            Dim ErrorCode_Text As XmlText = XMLError.CreateTextNode(strErrorCode)
            Dim ErrorMsg_Text As XmlText = XMLError.CreateTextNode(strMensajeError)
            Dim Cliente_Text As XmlText = XMLError.CreateTextNode(strCliente)
            Dim NroPaleta_Text As XmlText = XMLError.CreateTextNode(strNroPaleta)
            Dim Bulto_Text As XmlText = XMLError.CreateTextNode(strBulto)


            ' Añade los nodos al nodo padre son los valores
            parentNode.AppendChild(ErrorCode_Node)
            parentNode.AppendChild(ErrorMsg_Node)
            parentNode.AppendChild(Cliente_Node)
            parentNode.AppendChild(NroPaleta_Node)
            parentNode.AppendChild(Bulto_Node)

            ' Se guarda los valores en los respectivos nodos
            ErrorCode_Node.AppendChild(ErrorCode_Text)
            ErrorMsg_Node.AppendChild(ErrorMsg_Text)
            Cliente_Node.AppendChild(Cliente_Text)
            NroPaleta_Node.AppendChild(NroPaleta_Text)
            Bulto_Node.AppendChild(Bulto_Text)
        End Sub
#End Region
    End Class
End Namespace
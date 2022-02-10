Namespace slnSOLMIN_SDSW
    '------------------------------------'
    '-- Objeto : Movimiento de Almacen --'
    '------------------------------------'
    Public Class clsSDSWMovimientoMercaderia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strTCMPCL As String = ""
        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private intCTRSP As Int32 = 0
        Private strTCMPTR As String = ""
        Private intNRUCT As Int64 = 0
        Private strNPLCCM As String = ""
        Private strTMRCCM As String = ""
        Private intNANOCM As Int16 = 0
        Private strNBRVCH As String = ""
        Private strTNMBCH As String = ""
        Private intNLELCH As Int32 = 0
        Private strTOBSER As String = ""
        Private intCSRVC As Integer = 0
        'Agregado para Alamceneras
        Private intNORDEN As Int64 = 0

        Private intNPDUA As String = 0
        Private intNANDCL As Integer = 0
        Private strCRGMN As String = ""
        Private intCADNA As Integer = 0



        Private lstItemMovimientoMercaderia As List(Of clsSDSWItemMovimientoMercaderia)

#End Region
#Region " Propiedades "
        Sub New()
            lstItemMovimientoMercaderia = New List(Of clsSDSWItemMovimientoMercaderia)
        End Sub

        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrRazonSocialCliente_TCMPCL() As String
            Get
                Return strTCMPCL
            End Get
            Set(ByVal value As String)
                strTCMPCL = value
            End Set
        End Property

        Public Property pstrCompania_CCMPN() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property

        Public Property pstrDivision_CDVSN() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property

        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrRazonSocialEmpTransporte_TCMPTR() As String
            Get
                Return strTCMPTR
            End Get
            Set(ByVal value As String)
                strTCMPTR = value
            End Set
        End Property

        Public Property pintNroRUCEmpTransporte_NRUCT() As Int64
            Get
                Return intNRUCT
            End Get
            Set(ByVal value As Int64)
                intNRUCT = value
            End Set
        End Property

        Public Property pstrNroPlacaCamion_NPLCCM() As String
            Get
                Return strNPLCCM
            End Get
            Set(ByVal value As String)
                strNPLCCM = value
            End Set
        End Property

        Public Property pstrMarcaUnidad_TMRCCM() As String
            Get
                Return strTMRCCM
            End Get
            Set(ByVal value As String)
                strTMRCCM = value
            End Set
        End Property

        Public Property pintAnioUnidad_NANOCM() As Int16
            Get
                Return intNANOCM
            End Get
            Set(ByVal value As Int16)
                intNANOCM = value
            End Set
        End Property

        Public Property pstrNroBrevete_NBRVCH() As String
            Get
                Return strNBRVCH
            End Get
            Set(ByVal value As String)
                strNBRVCH = value
            End Set
        End Property

        Public Property pstrChofer_TNMBCH() As String
            Get
                Return strTNMBCH
            End Get
            Set(ByVal value As String)
                strTNMBCH = value
            End Set
        End Property

        Public Property pintNroDocIdentidadChofer_NLELCH() As Int32
            Get
                Return intNLELCH
            End Get
            Set(ByVal value As Int32)
                intNLELCH = value
            End Set
        End Property

        Public Property pstrObservaciones_TOBSER() As String
            Get
                Return strTOBSER
            End Get
            Set(ByVal value As String)
                strTOBSER = value
            End Set
        End Property

        Public Property pintServicio_CSRVC() As Integer
            Get
                Return intCSRVC
            End Get
            Set(ByVal value As Integer)
                intCSRVC = value
            End Set
        End Property

        'Agragado para Almaceneras 
        Public Property pintOrdenServicio_NORDEN() As Int64
            Get
                Return intNORDEN
            End Get
            Set(ByVal value As Int64)
                intNORDEN = value
            End Set
        End Property

        Public Property pintNPDUA() As Int64
            Get
                Return intNPDUA
            End Get
            Set(ByVal value As Int64)
                intNPDUA = value
            End Set
        End Property
        Public Property pintNANDCL() As Int64
            Get
                Return intNANDCL
            End Get
            Set(ByVal value As Int64)
                intNANDCL = value
            End Set
        End Property
        Public Property pstrCRGMN() As String
            Get
                Return strCRGMN
            End Get
            Set(ByVal value As String)
                strCRGMN = value
            End Set
        End Property

        Public Property pintCADNA() As Int64
            Get
                Return intCADNA
            End Get
            Set(ByVal value As Int64)
                intCADNA = value
            End Set
        End Property

        Public ReadOnly Property plstItemMovimientoMercaderia() As List(Of clsSDSWItemMovimientoMercaderia)
            Get
                Return lstItemMovimientoMercaderia
            End Get
        End Property
        'Agragado para Almaceneras

        Public Sub AddItemMovimientoMercaderia(ByVal objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia)
            lstItemMovimientoMercaderia.Add(objItemMovimientoMercaderia)
        End Sub
        Public Sub DeleteItemMovimientoMercaderia(ByVal objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia)
            lstItemMovimientoMercaderia.Remove(objItemMovimientoMercaderia)
        End Sub
        Public Sub DeleteIndexMercaderia(ByVal Index As Integer, ByVal objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia)
            lstItemMovimientoMercaderia.RemoveRange(Index, 1)
        End Sub
#End Region
    End Class

    Public Class clsSDSWItemMovimientoMercaderia
#Region " Atributos "
        Private strCMRCLR As String = ""
        Private strCMRCD As String = ""
        Private intNORDSR As Int64 = 0
        Private intNCNTR As Int64 = 0
        Private intNCRCTC As Int64 = 0
        Private intNAUTR As Int64 = 0
        Private strCUNCNT As String = ""
        Private strCUNPST As String = ""
        Private strCUNVLT As String = ""
        Private strNORCCL As String = ""
        Private strNGUICL As String = ""
        Private strNRUCLL As String = ""
        Private strSTPING As String = ""
        Private strCTPALM As String = ""
        Private strCALMC As String = ""
        Private strCZNALM As String = ""
        Private decQTRMC As Decimal = 0.0
        Private decQTRMP As Decimal = 0.0
        Private intQDSVGN As Integer = 0
        Private strCCNTD As String = ""
        Private strCTPOCN As String = ""
        Private strFUNDS2 As String = ""
        Private strCTPDPS As String = ""
        Private strTOBSRV As String = ""
        'Agregado para Almaceneras
        Private strTOBSRL As String = ""
        Private dteFRLZSR As Date
        Private dteFCNTSL As Date

        Private intNSRIE As Integer = 0
#End Region
#Region " Propiedades "
        Public Property pstrCodigoMercaderia_CMRCLR() As String
            Get
                Return strCMRCLR
            End Get
            Set(ByVal value As String)
                strCMRCLR = value
            End Set
        End Property

        Public Property pstrCodigoRANSA_CMRCD() As String
            Get
                Return strCMRCD
            End Get
            Set(ByVal value As String)
                strCMRCD = value
            End Set
        End Property

        Public Property pintOrdenServicio_NORDSR() As Int64
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Int64)
                intNORDSR = value
            End Set
        End Property

        Public Property pintNroContrato_NCNTR() As Int64
            Get
                Return intNCNTR
            End Get
            Set(ByVal value As Int64)
                intNCNTR = value
            End Set
        End Property

        Public Property pintNroCorrDetalleContrato_NCRCTC() As Int64
            Get
                Return intNCRCTC
            End Get
            Set(ByVal value As Int64)
                intNCRCTC = value
            End Set
        End Property

        Public Property pintNroAutorizacion_NAUTR() As Int64
            Get
                Return intNAUTR
            End Get
            Set(ByVal value As Int64)
                intNAUTR = value
            End Set
        End Property

        Public Property pstrUnidadCantidad_CUNCNT() As String
            Get
                Return strCUNCNT
            End Get
            Set(ByVal value As String)
                strCUNCNT = value
            End Set
        End Property

        Public Property pstrUnidadPeso_CUNPST() As String
            Get
                Return strCUNPST
            End Get
            Set(ByVal value As String)
                strCUNPST = value
            End Set
        End Property

        Public Property pstrUnidadValorTransaccion_CUNVLT() As String
            Get
                Return strCUNVLT
            End Get
            Set(ByVal value As String)
                strCUNVLT = value
            End Set
        End Property

        Public Property pstrNroOrdenCompraCliente_NORCCL() As String
            Get
                Return strNORCCL
            End Get
            Set(ByVal value As String)
                strNORCCL = value
            End Set
        End Property

        Public Property pstrNroGuiaCliente_NGUICL() As String
            Get
                Return strNGUICL
            End Get
            Set(ByVal value As String)
                strNGUICL = value
            End Set
        End Property

        Public Property pstrNroRUCCliente_NRUCLL() As String
            Get
                Return strNRUCLL
            End Get
            Set(ByVal value As String)
                strNRUCLL = value
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

        Public Property pstrTipoAlmacen_CTPALM() As String
            Get
                Return strCTPALM
            End Get
            Set(ByVal value As String)
                strCTPALM = value
            End Set
        End Property

        Public Property pstrAlmacen_CALMC() As String
            Get
                Return strCALMC
            End Get
            Set(ByVal value As String)
                strCALMC = value
            End Set
        End Property

        Public Property pstrZonaAlmacen_CZNALM() As String
            Get
                Return strCZNALM
            End Get
            Set(ByVal value As String)
                strCZNALM = value
            End Set
        End Property

        Public Property pdecCantidad_QTRMC() As Decimal
            Get
                Return decQTRMC
            End Get
            Set(ByVal value As Decimal)
                decQTRMC = value
            End Set
        End Property

        Public Property pdecPeso_QTRMP() As Decimal
            Get
                Return decQTRMP
            End Get
            Set(ByVal value As Decimal)
                decQTRMP = value
            End Set
        End Property

        Public Property pintNroDiasVigencia_QDSVGN() As Integer
            Get
                Return intQDSVGN
            End Get
            Set(ByVal value As Integer)
                intQDSVGN = value
            End Set
        End Property

        Public Property pstrContenedor_CCNTD() As String
            Get
                Return strCCNTD
            End Get
            Set(ByVal value As String)
                strCCNTD = value
            End Set
        End Property

        Public WriteOnly Property pblnDesglose_CTPOCN() As Boolean
            Set(ByVal value As Boolean)
                If value Then
                    strCTPOCN = "SI"
                Else
                    strCTPOCN = "NO"
                End If
            End Set
        End Property

        Public ReadOnly Property pstrDesglose_CTPOCN() As String
            Get
                Return strCTPOCN
            End Get
        End Property

        Public Property pstrSatusUnidadDespacho_FUNDS2() As String
            Get
                Return strFUNDS2
            End Get
            Set(ByVal value As String)
                strFUNDS2 = value
            End Set
        End Property

        Public Property pstrTipoDeposito_CTPDPS() As String
            Get
                Return strCTPDPS
            End Get
            Set(ByVal value As String)
                strCTPDPS = value
            End Set
        End Property

        Public Property pstrObservaciones_TOBSRV() As String
            Get
                Return strTOBSRV
            End Get
            Set(ByVal value As String)
                strTOBSRV = value
            End Set
        End Property
        'Agregado para Almaceneras
        Public Property pstrCaracteristicas_TOBSRL() As String
            Get
                Return strTOBSRL
            End Get
            Set(ByVal value As String)
                strTOBSRL = value
            End Set
        End Property
        'Agregado para Almaceneras
        Public Property pdteFechaIngreso_FRLZSR() As Date
            Get
                Return dteFRLZSR
            End Get
            Set(ByVal value As Date)
                dteFRLZSR = value
            End Set
        End Property
        'Agregado para Almaceneras
        Public Property pdteFechaSalida_FCNTSL() As Date
            Get
                Return dteFCNTSL
            End Get
            Set(ByVal value As Date)
                dteFCNTSL = value
            End Set
        End Property


        'Agregado para Almaceneras
        Public Property pintSerie_NSRIE() As Integer
            Get
                Return intNSRIE
            End Get
            Set(ByVal value As Integer)
                intNSRIE = value
            End Set
        End Property

#End Region
    End Class
    '------------------------------------'
    '-- Objeto : Movimiento de Ticket --'
    '------------------------------------'
    'Agregado para Almaceneras
    Public Class clsSDSWMovimientoTicket
#Region " Atributos "
        Private lstitemticket As List(Of clsSDSWItemTicket)
        Private strOBSER As String = ""
        Private strCTPALM As String = ""
        Private strCALMC As String = ""
        Private strCZNALM As String = ""
        Private strCTPOAT As String = ""
        Private intCCLNT As Int64 = 0
        Private intCSRVNV As Int64 = 0
        Private decNHRFAC As Decimal = 0.0
        Private intNORDSR As Int64 = 0
#End Region
#Region " Propiedades "
        Sub New()
            lstitemticket = New List(Of clsSDSWItemTicket)
        End Sub
        Public ReadOnly Property plstItemticket() As List(Of clsSDSWItemTicket)
            Get
                Return lstitemticket
            End Get
        End Property
        Public Sub AddItemTicket(ByVal objitemticket As clsSDSWItemTicket)
            lstitemticket.Add(objitemticket)
        End Sub
        Public Sub DeleteItemTicket(ByVal objitemticket As clsSDSWItemTicket)
            lstitemticket.Remove(objitemticket)
        End Sub
        Public Sub DeleteIndexTicket(ByVal Index As Integer, ByVal objitemticket As clsSDSWItemTicket)
            lstitemticket.RemoveRange(Index, 1)
        End Sub
        Public Property pstrObservacion_OBSER() As String
            Get
                Return strOBSER
            End Get
            Set(ByVal value As String)
                strOBSER = value
            End Set
        End Property
        Public Property pstrTipoAlmacen_CTPALM() As String
            Get
                Return strCTPALM
            End Get
            Set(ByVal value As String)
                strCTPALM = value
            End Set
        End Property
        Public Property pstrAlmacen_CALMC() As String
            Get
                Return strCALMC
            End Get
            Set(ByVal value As String)
                strCALMC = value
            End Set
        End Property
        Public Property pstrZonaAlmacen_CZNALM() As String
            Get
                Return strCZNALM
            End Get
            Set(ByVal value As String)
                strCZNALM = value
            End Set
        End Property
        Public Property pstrZonaAlmacen_CTPOAT() As String
            Get
                Return strCTPOAT
            End Get
            Set(ByVal value As String)
                strCTPOAT = value
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
        Public Property pintCodigoRubro_CSRVNV() As Int64
            Get
                Return intCSRVNV
            End Get
            Set(ByVal value As Int64)
                intCSRVNV = value
            End Set
        End Property
        Public Property pdecHoraFacturada_NHRFAC() As Decimal
            Get
                Return decNHRFAC
            End Get
            Set(ByVal value As Decimal)
                decNHRFAC = value
            End Set
        End Property
        Public Property pintOrdenServicio_NORDSR() As Int64
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Int64)
                intNORDSR = value
            End Set
        End Property
#End Region
    End Class

    'Agredado para Alamaceneras
    Public Class clsSDSWItemTicket
#Region " Atributos "
        Private intNORDSR As Int64 = 0
        Private intNSLCSR As Int64 = 0
        Private intNROTCK As Int64 = 0
        Private intNCRRLT As Int64 = 0
        Private strCSRVNV As String = ""
        Private dteFENVSL As Date
        Private dteFCHCTR As Date
        Private dteFATNSR As Date
        Private intHORAINI As String = ""
        Private intHORAFIN As String = ""
        Private intCTRSPT As Int64 = 0
        Private strOBSER As String = ""
        Private intNDCMFC As Int64 = 0
        Private decNHRCAL As Decimal = 0.0
        Private decNHRFAC As Decimal = 0.0
        Private strTCMTRF As String = ""
        Private strCALMCM As String = ""
#End Region
#Region " Propiedades "

        Public Property pintOrdenServicio_NORDSR() As Int64
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Int64)
                intNORDSR = value
            End Set
        End Property
        Public Property pintNumSolicitudServicio_NSLCSR() As Int64
            Get
                Return intNSLCSR
            End Get
            Set(ByVal value As Int64)
                intNSLCSR = value
            End Set
        End Property
        Public Property pintCodigoTransaportista_CTRSPST() As Int64
            Get
                Return intCTRSPT
            End Get
            Set(ByVal value As Int64)
                intCTRSPT = value
            End Set
        End Property
        Public Property pintNumControlTicket_NROTCK() As Int64
            Get
                Return intNROTCK
            End Get
            Set(ByVal value As Int64)
                intNROTCK = value
            End Set
        End Property
        Public Property pstrTipoServicio_CSRVNV() As String
            Get
                Return strCSRVNV
            End Get
            Set(ByVal value As String)
                strCSRVNV = value
            End Set
        End Property
        Public Property pintNumCorrelativo_NCRRLT() As Int64
            Get
                Return intNCRRLT
            End Get
            Set(ByVal value As Int64)
                intNCRRLT = value
            End Set
        End Property
        Public Property pintHoraInicio_HORAINI() As String
            Get
                Return intHORAINI
            End Get
            Set(ByVal value As String)
                intHORAINI = value
            End Set
        End Property
        Public Property pintHoraFin_HORAFIN() As String
            Get
                Return intHORAFIN
            End Get
            Set(ByVal value As String)
                intHORAFIN = value
            End Set
        End Property
        Public Property pintNumeroDocumento_NDCMFC() As Int64
            Get
                Return intNDCMFC
            End Get
            Set(ByVal value As Int64)
                intNDCMFC = value
            End Set
        End Property
        Public Property pstrObservacion_OBSER() As String
            Get
                Return strOBSER
            End Get
            Set(ByVal value As String)
                strOBSER = value
            End Set
        End Property
        Public Property pdteFechaEnvioSolicitud_FENVSL() As Date
            Get
                Return dteFENVSL
            End Get
            Set(ByVal value As Date)
                dteFENVSL = value
            End Set
        End Property
        Public Property pdteFechaIngreso_FCHCTR() As Date
            Get
                Return dteFCHCTR
            End Get
            Set(ByVal value As Date)
                dteFCHCTR = value
            End Set
        End Property
        Public Property pdteFechaAtencion_FATNSR() As Date
            Get
                Return dteFATNSR
            End Get
            Set(ByVal value As Date)
                dteFATNSR = value
            End Set
        End Property
        Public ReadOnly Property pstrFecha_FATNSR() As String
            Get
                Dim strResultado As String = ""
                If dteFATNSR.Year > 1 Then strResultado = dteFATNSR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFecha_FATNSR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFATNSR.Year > 1 Then Integer.TryParse(dteFATNSR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
        Public Property pdecHoraCalculada_NHRCAL() As Decimal
            Get
                Return decNHRCAL
            End Get
            Set(ByVal value As Decimal)
                decNHRCAL = value
            End Set
        End Property
        Public Property pdecHoraFacturada_NHRFAC() As Decimal
            Get
                Return decNHRFAC
            End Get
            Set(ByVal value As Decimal)
                decNHRFAC = value
            End Set
        End Property
        Public Property pstrRubroServicio_TCMTRF() As String
            Get
                Return strTCMTRF
            End Get
            Set(ByVal value As String)
                strTCMTRF = value
            End Set
        End Property
        Public Property pstrAlmacen_CALMCM() As String
            Get
                Return strCALMCM
            End Get
            Set(ByVal value As String)
                strCALMCM = value
            End Set
        End Property
#End Region
    End Class

    '---------------------'
    '-- Objeto : Camión --'
    '---------------------'
    Public Class clsSDSWCamion
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNPLCCM As String = ""
        Private decPTRCM As Decimal = 0.0
        Private intNANOCM As Int32 = 0
        Private strTMRCCM As String = ""
        Private strNMTRCM As String = ""
        Private strSESTCM As String = ""
        Private strNROPLA As String = ""
        Private strNBRVC1 As String = ""
        Private strNPLCAC As String = ""
        Private intNTRNLL As Int32 = 0
        Private decFASGTR As Date
        Private intHASGTR As Int32 = 0
        Private strNTRMNL As String = ""
#End Region
#Region " Propiedades "
        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrNroPlacaCamion_NPLCCM()
            Get
                Return strNPLCCM
            End Get
            Set(ByVal value)
                strNPLCCM = value
                If strNPLCCM.Length > 3 Then strNROPLA = strNPLCCM.Substring(2)
            End Set
        End Property

        Public Property pdecCantidadPesoTara_PTRCM() As Decimal
            Get
                Return decPTRCM
            End Get
            Set(ByVal value As Decimal)
                decPTRCM = value
            End Set
        End Property

        Public Property pintNroAnioCamion_NANOCM() As Int32
            Get
                Return intNANOCM
            End Get
            Set(ByVal value As Int32)
                intNANOCM = value
            End Set
        End Property

        Public Property pstrDescripcionMarcaCamion_TMRCCM() As String
            Get
                Return strTMRCCM
            End Get
            Set(ByVal value As String)
                strTMRCCM = value
            End Set
        End Property

        Public Property pstrNroMotorCamion_NMTRCM() As String
            Get
                Return strNMTRCM
            End Get
            Set(ByVal value As String)
                strNMTRCM = value
            End Set
        End Property

        Public Property pstrStatusEstadoCamion_SESTCM() As String
            Get
                Return strSESTCM
            End Get
            Set(ByVal value As String)
                strSESTCM = value
            End Set
        End Property

        Public ReadOnly Property pstrParteNumericaPlaca_NROPLA() As String
            Get
                Return strNROPLA
            End Get
        End Property

        Public Property pstrNroBreveteChofer_NBRVC1() As String
            Get
                Return strNBRVC1
            End Get
            Set(ByVal value As String)
                strNBRVC1 = value
            End Set
        End Property

        Public Property pstrNroPlacaAcoplado_NPLCAC() As String
            Get
                Return strNPLCAC
            End Get
            Set(ByVal value As String)
                strNPLCAC = value
            End Set
        End Property

        Public Property pintNroTurnoLlegada_NTRNLL() As Int32
            Get
                Return intNTRNLL
            End Get
            Set(ByVal value As Int32)
                intNTRNLL = value
            End Set
        End Property

        Public Property pdteFechaAsignacionTurno_FASGTR() As Date
            Get
                Return decFASGTR
            End Get
            Set(ByVal value As Date)
                decFASGTR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaAsignacionTurno_FASGTR() As String
            Get
                Dim strResultado As String = ""
                If decFASGTR.Year > 1 Then strResultado = decFASGTR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaAsignacionTurno_FASGTR() As Integer
            Get
                Dim intResultado As Integer = 0
                If decFASGTR.Year > 1 Then Integer.TryParse(decFASGTR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pintHoraAsignacionTurno_HASGTR() As Int32
            Get
                Return intHASGTR
            End Get
            Set(ByVal value As Int32)
                intHASGTR = value
            End Set
        End Property

        Public Property pstrNroTerminal_NTRMNL() As String
            Get
                Return strNTRMNL
            End Get
            Set(ByVal value As String)
                strNTRMNL = value
            End Set
        End Property
#End Region
    End Class

    '---------------------'
    '-- Objeto : Chofer --'
    '---------------------'
    Public Class clsSDSWChofer
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNBRVCH As String = ""
        Private strTNMBCH As String = ""
        Private intNLELCH As Int32 = 0
        Private strNTRMNL As String = ""
        Private strSESTCH As String = ""
#End Region
#Region " Propiedades "
        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrNroBrevete_NBRVCH() As String
            Get
                Return strNBRVCH
            End Get
            Set(ByVal value As String)
                strNBRVCH = value
            End Set
        End Property

        Public Property pstrChofer_TNMBCH() As String
            Get
                Return strTNMBCH
            End Get
            Set(ByVal value As String)
                strTNMBCH = value
            End Set
        End Property

        Public Property pintNroDocIdentidadChofer_NLELCH() As Int32
            Get
                Return intNLELCH
            End Get
            Set(ByVal value As Int32)
                intNLELCH = value
            End Set
        End Property

        Public Property pstrNroTerminal_NTRMNL() As String
            Get
                Return strNTRMNL
            End Get
            Set(ByVal value As String)
                strNTRMNL = value
            End Set
        End Property

        Public Property pStatusChofer_SESTCH() As String
            Get
                Return strSESTCH
            End Get
            Set(ByVal value As String)
                strSESTCH = value
            End Set
        End Property
#End Region
    End Class

    '--------------------------------'
    '-- Objeto : Orden de Servicio --'
    '--------------------------------'
    Public Class clsSDSWCrearOrdenServicio
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCMRCLR As String = ""
        Private intNCNTR As Int64 = 0
        Private strCTPDP3 As String = ""
        Private strCTPPR1 As String = ""
        Private decQMRCD As Decimal = 0.0#
        Private strCUNCND As String = ""
        Private decQPSMR As Decimal = 0.0#
        Private strCUNPS0 As String = ""
        Private decQVLMR As Decimal = 0.0#
        Private strCUNVLR As String = ""
        Private strFUNCTL As String = ""
        Private strFUNDS As String = ""
        'Agregado para Almaceneras
        Private strNORDSR As String = 0

#End Region
#Region " Propiedades "
        'Agregado para Almaceneras
        Public Property pintOrdenServicio() As Int64
            Get
                Return strNORDSR
            End Get
            Set(ByVal value As Int64)
                strNORDSR = value
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

        Public Property pstrCodigoMercaderia_CMRCLR() As String
            Get
                Return strCMRCLR
            End Get
            Set(ByVal value As String)
                strCMRCLR = value
            End Set
        End Property

        Public Property pintNroContrato_NCNTR() As Int64
            Get
                Return intNCNTR
            End Get
            Set(ByVal value As Int64)
                intNCNTR = value
            End Set
        End Property

        Public Property pstrTipoDeposito_CTPDP3() As String
            Get
                Return strCTPDP3
            End Get
            Set(ByVal value As String)
                strCTPDP3 = value
            End Set
        End Property

        Public Property pstrProducto_CTPPR1() As String
            Get
                Return strCTPPR1
            End Get
            Set(ByVal value As String)
                strCTPPR1 = value
            End Set
        End Property

        Public Property pdecCantidadDeclarada_QMRCD() As Decimal
            Get
                Return decQMRCD
            End Get
            Set(ByVal value As Decimal)
                decQMRCD = value
            End Set
        End Property

        Public Property pstrUnidadCantidad_CUNCND() As String
            Get
                Return strCUNCND
            End Get
            Set(ByVal value As String)
                strCUNCND = value
            End Set
        End Property

        Public Property pdecPesoDeclarado_QPSMR() As Decimal
            Get
                Return decQPSMR
            End Get
            Set(ByVal value As Decimal)
                decQPSMR = value
            End Set
        End Property

        Public Property pstrUnidadPeso_CUNPS0() As String
            Get
                Return strCUNPS0
            End Get
            Set(ByVal value As String)
                strCUNPS0 = value
            End Set
        End Property

        Public Property pdecValorDeclarado_QVLMR() As Decimal
            Get
                Return decQVLMR
            End Get
            Set(ByVal value As Decimal)
                decQVLMR = value
            End Set
        End Property

        Public Property pstrUnidadValor_CUNVLR() As String
            Get
                Return strCUNVLR
            End Get
            Set(ByVal value As String)
                strCUNVLR = value
            End Set
        End Property

        Public Property pstrControlLotes_FUNCTL() As String
            Get
                Return strFUNCTL
            End Get
            Set(ByVal value As String)
                strFUNCTL = value
            End Set
        End Property

        Public Property pstrUnidadDespacho_FUNDS() As String
            Get
                Return strFUNDS
            End Get
            Set(ByVal value As String)
                strFUNDS = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsSDSWInformacionOrdenServicio
#Region " Atributos "
        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private strTCMTRF As String = ""
        Private intCMNDA1 As Integer = 0
        Private strFUNDS2 As String = ""
        Private intNORDSR As Int64 = 0
        Private intNCNTR As Int64 = 0
        Private intNCRCTC As Integer = 0
        Private intNAUTR As Int64 = 0
        Private dteFEMORS As Date
        Private strCTPDP6 As String = ""
        Private strCUNCN5 As String = ""
        Private strCUNPS5 As String = ""
        Private strCUNVL5 As String = ""
        Private intCTIGVA As Integer = 0
        Private strCHLGRC As String = ""
        Private strSTPOAL As String = ""
        'Agregado para Almaceneras
        Private intCCLNT As Integer = 0
        Private decQMRCD As Decimal = 0.0#
        Private strCUNCND As String = ""
        Private decQPSMR As Decimal = 0.0#
        Private strCUNPS0 As String = ""
        Private strFUNCTL As String = ""
#End Region
#Region " Propiedades "
        Public Property pstrCompania_CCMPN() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property

        Public Property pstrDivision_CDVSN() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property

        Public Property pstrDetalleCompletoServicio_TCMTRF() As String
            Get
                Return strTCMTRF
            End Get
            Set(ByVal value As String)
                strTCMTRF = value
            End Set
        End Property

        Public Property pintOrdenServicio_NORDSR() As Int64
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Int64)
                intNORDSR = value
            End Set
        End Property

        Public Property pintNroContrato_NCNTR() As Int64
            Get
                Return intNCNTR
            End Get
            Set(ByVal value As Int64)
                intNCNTR = value
            End Set
        End Property

        Public Property pintNroCorrDetalleContrato_NCRCTC() As Integer
            Get
                Return intNCRCTC
            End Get
            Set(ByVal value As Integer)
                intNCRCTC = value
            End Set
        End Property

        Public Property pintNroAutorizacion_NAUTR() As Int64
            Get
                Return intNAUTR
            End Get
            Set(ByVal value As Int64)
                intNAUTR = value
            End Set
        End Property

        Public Property pintMoneda_CMNDA1() As Integer
            Get
                Return intCMNDA1
            End Get
            Set(ByVal value As Integer)
                intCMNDA1 = value
            End Set
        End Property

        Public Property pstrSatusUnidadDespacho_FUNDS2() As String
            Get
                Return strFUNDS2
            End Get
            Set(ByVal value As String)
                strFUNDS2 = value
            End Set
        End Property

        Public Property pdteFechaEmision_FEMORS() As Date
            Get
                Return dteFEMORS
            End Get
            Set(ByVal value As Date)
                dteFEMORS = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaEmision_FEMORS() As String
            Get
                Dim strResultado As String = ""
                If dteFEMORS.Year > 1 Then strResultado = dteFEMORS.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaEmision_FEMORS() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFEMORS.Year > 1 Then Integer.TryParse(dteFEMORS.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrTipoDeposito_CTPDP6() As String
            Get
                Return strCTPDP6
            End Get
            Set(ByVal value As String)
                strCTPDP6 = value
            End Set
        End Property

        Public Property pstrUnidadCantidad_CUNCN5() As String
            Get
                Return strCUNCN5
            End Get
            Set(ByVal value As String)
                strCUNCN5 = value
            End Set
        End Property

        Public Property pstrUnidadPeso_CUNPS5() As String
            Get
                Return strCUNPS5
            End Get
            Set(ByVal value As String)
                strCUNPS5 = value
            End Set
        End Property

        Public Property pstrUnidadValorTransaccion_CUNVL5() As String
            Get
                Return strCUNVL5
            End Get
            Set(ByVal value As String)
                strCUNVL5 = value
            End Set
        End Property

        Public Property pintTipoIGV_CTIGVA() As Integer
            Get
                Return intCTIGVA
            End Get
            Set(ByVal value As Integer)
                intCTIGVA = value
            End Set
        End Property

        Public Property pstrHoldingGrupoCompania_CHLGRC() As String
            Get
                Return strCHLGRC
            End Get
            Set(ByVal value As String)
                strCHLGRC = value
            End Set
        End Property

        Public Property pstrTipoAlmacen_STPOAL() As String
            Get
                Return strSTPOAL
            End Get
            Set(ByVal value As String)
                strSTPOAL = value
            End Set
        End Property
        'Agregado para Almaceneras
        Public Property pintCliente_CCLNT() As Integer
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Integer)
                intCCLNT = value
            End Set
        End Property
        Public Property pdecCantidadDeclarada_QMRCD() As Decimal
            Get
                Return decQMRCD
            End Get
            Set(ByVal value As Decimal)
                decQMRCD = value
            End Set
        End Property

        Public Property pstrUnidadCantidad_CUNCND() As String
            Get
                Return strCUNCND
            End Get
            Set(ByVal value As String)
                strCUNCND = value
            End Set
        End Property

        Public Property pdecPesoDeclarado_QPSMR() As Decimal
            Get
                Return decQPSMR
            End Get
            Set(ByVal value As Decimal)
                decQPSMR = value
            End Set
        End Property

        Public Property pstrUnidadPeso_CUNPS0() As String
            Get
                Return strCUNPS0
            End Get
            Set(ByVal value As String)
                strCUNPS0 = value
            End Set
        End Property

        Public Property pstrControlLotes_FUNCTL() As String
            Get
                Return strFUNCTL
            End Get
            Set(ByVal value As String)
                strFUNCTL = value
            End Set
        End Property
#End Region
    End Class
    'Agregado para Almaceneras
    '--------------------------------'
    '-- Objeto : Vehiculo --'
    '--------------------------------'
    Public Class clsSDSWInformacionVehiculo
#Region "Atributos"
        Private strMarca As String = ""
        Private strModelo As String = ""
        Private strVin As String = ""
        Private strEntrega As String = ""
        Private strInicio As String = ""
        Private strFinal As String = ""
        Private strEmpresa As String = ""
        Private strWarrant As String = ""
        Private dteEntrega As Date
        Private dteInicio As Date
        Private dteFinal As Date

        Private strCCLNT As String = ""

        Private lstItemMovimiento As List(Of clsSDSWInformacionVehiculo)
#End Region
#Region "Propiedades"
        Sub New()
            lstItemMovimiento = New List(Of clsSDSWInformacionVehiculo)
        End Sub
        Public ReadOnly Property plstItemMovimiento() As List(Of clsSDSWInformacionVehiculo)
            Get
                Return lstItemMovimiento
            End Get
        End Property

        Public Sub AddItemMovimiento(ByVal objItem As clsSDSWInformacionVehiculo)
            lstItemMovimiento.Add(objItem)
        End Sub

        Public Property pstrCCLNT() As String
            Get
                Return strCCLNT
            End Get
            Set(ByVal value As String)
                strCCLNT = value
            End Set
        End Property

        Public Property pstrMarca() As String
            Get
                Return strMarca
            End Get
            Set(ByVal value As String)
                strMarca = value
            End Set
        End Property
        Public Property pstrModelo() As String
            Get
                Return strModelo
            End Get
            Set(ByVal value As String)
                strModelo = value
            End Set
        End Property
        Public Property pstrVin() As String
            Get
                Return strVin
            End Get
            Set(ByVal value As String)
                strVin = value
            End Set
        End Property
        Public Property pstrInicio() As String
            Get
                Return strInicio
            End Get
            Set(ByVal value As String)
                strInicio = value
            End Set
        End Property
        Public Property pdteInicio() As Date
            Get
                Return dteInicio
            End Get
            Set(ByVal value As Date)
                dteInicio = value
            End Set
        End Property
        Public Property pstrFinal() As String
            Get
                Return dteFinal
            End Get
            Set(ByVal value As String)
                dteFinal = value
            End Set
        End Property
        Public Property pdteFinal() As Date
            Get
                Return dteFinal
            End Get
            Set(ByVal value As Date)
                dteFinal = value
            End Set
        End Property
        Public Property pstrEntrega() As String
            Get
                Return strEntrega
            End Get
            Set(ByVal value As String)
                strEntrega = value
            End Set
        End Property
        Public Property pdteEntrega() As Date
            Get
                Return dteEntrega
            End Get
            Set(ByVal value As Date)
                dteEntrega = value
            End Set
        End Property
        Public Property pstrEmpresa() As String
            Get
                Return strEmpresa
            End Get
            Set(ByVal value As String)
                strEmpresa = value
            End Set
        End Property
        Public Property pstrWarrant() As String
            Get
                Return strWarrant
            End Get
            Set(ByVal value As String)
                strWarrant = value
            End Set
        End Property
#End Region

    End Class



    'Agregado para Almaceneras
    Public Class clsSDSWInformacionAmcor
#Region "Atributos"
        Private strEntrega As String = ""
        Private strEntregaSalida As String = ""
        Private strLote As String = ""
        Private strMaterial As String = ""
        Private strDescripcion As String = ""
        Private strFecha As String = ""
        Private strCaja As String = ""
        Private strCantidad As String = ""
        Private strPeso As String = ""
        Private dteFecha As Date
        Private stRCTPALM As String = ""
        Private strCALMC As String = ""
        Private strCZNALM As String = ""
        Private strGUIA As String = ""
        Private strFlagTipo As String = ""
        Private strCETQWR As String = ""
        Private strNETQT As String = ""
        Private lstItemMovimiento As List(Of clsSDSWInformacionAmcor)
#End Region
#Region "Propiedades"

        Sub New()
            lstItemMovimiento = New List(Of clsSDSWInformacionAmcor)
        End Sub
        Public ReadOnly Property plstItemMovimiento() As List(Of clsSDSWInformacionAmcor)
            Get
                Return lstItemMovimiento
            End Get
        End Property

        Public Sub AddItemMovimiento(ByVal objItem As clsSDSWInformacionAmcor)
            lstItemMovimiento.Add(objItem)
        End Sub
        Public Property pstrEntrega() As String
            Get
                Return strEntrega
            End Get
            Set(ByVal value As String)
                strEntrega = value
            End Set
        End Property
        Public Property pstrCETQWR() As String
            Get
                Return strCETQWR
            End Get
            Set(ByVal value As String)
                strCETQWR = value
            End Set
        End Property
        Public Property pstrNETQT() As String
            Get
                Return strNETQT
            End Get
            Set(ByVal value As String)
                strNETQT = value
            End Set
        End Property
        Public Property pstrLote() As String
            Get
                Return strLote
            End Get
            Set(ByVal value As String)
                strLote = value
            End Set
        End Property
        Public Property pstrMaterial()
            Get
                Return strMaterial
            End Get
            Set(ByVal value)
                strMaterial = value
            End Set
        End Property
        Public Property pstrDescripcion() As String
            Get
                Return strDescripcion
            End Get
            Set(ByVal value As String)
                strDescripcion = value
            End Set
        End Property
        Public Property pstrFecha() As String
            Get
                Return strFecha
            End Get
            Set(ByVal value As String)
                strFecha = value
            End Set
        End Property
        Public Property pstrCantidad() As String
            Get
                Return strCantidad
            End Get
            Set(ByVal value As String)
                strCantidad = value
            End Set
        End Property
        Public Property pstrCaja() As String
            Get
                Return strCaja
            End Get
            Set(ByVal value As String)
                strCaja = value
            End Set
        End Property
        Public Property pstrPeso() As String
            Get
                Return strPeso
            End Get
            Set(ByVal value As String)
                strPeso = value
            End Set
        End Property
        Public Property pdteFecha() As Date
            Get
                Return dteFecha
            End Get
            Set(ByVal value As Date)
                dteFecha = value
            End Set
        End Property
        Public Property pstrCTPALM() As String
            Get
                Return STRCTPALM
            End Get
            Set(ByVal value As String)
                stRCTPALM = value
            End Set
        End Property
        Public Property pstrCALMC() As String
            Get
                Return strCALMC
            End Get
            Set(ByVal value As String)
                strCALMC = value
            End Set
        End Property
        Public Property PSTRCZNALM() As String
            Get
                Return strCZNALM
            End Get
            Set(ByVal value As String)
                strCZNALM = value
            End Set
        End Property
        Public Property pstrFlagTipo() As String
            Get
                Return strFlagTipo
            End Get
            Set(ByVal value As String)
                strFlagTipo = value
            End Set
        End Property

        Public Property pstrGUIA() As String
            Get
                Return strGUIA
            End Get
            Set(ByVal value As String)
                strGUIA = value
            End Set
        End Property
        Public Property pstrEntregaSalida() As String
            Get
                Return strEntregaSalida
            End Get
            Set(ByVal value As String)
                strEntregaSalida = value
            End Set
        End Property
#End Region

    End Class

End Namespace
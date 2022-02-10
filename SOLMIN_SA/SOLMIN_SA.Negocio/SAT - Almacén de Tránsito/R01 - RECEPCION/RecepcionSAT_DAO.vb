Imports System.Xml

Namespace slnSOLMIN_SAT.Recepcion
    Public Class clsOrdenCompra
#Region " Atributos "
        '-- Propiedades --
        Private intCCLNT As Int64 = 0
        Private strNORCML As String = ""
        Private intCPRVCL As Int32 = 0
        Private strCPRPCL As String = ""
        Private datFORCML As Date
        Private datFROCMP As Date
        Private strTDSCML As String = ""
        Private strTCTCST As String = ""
        Private strNSVP As String = ""
        Private strTTINTC As String = ""
        Private strTPAGME As String = ""
        Private strTLUGEM As String = ""
        Private strTDEFIN As String = ""
        Private decIVCOTO As Decimal = 0
        Private decIVTOCO As Decimal = 0
        Private decIVTOIM As Decimal = 0
        Private strCMNDA1 As String = ""
        Private strNMONOC As String = ""
        Private strSFACTU As String = ""
        Private datFFACTU As Date
        Private strSTRANS As String = ""
        Private strNREFCL As String = ""
        Private strREFDO1 As String = ""
        Private datFSOLIC As Date
        Private strTCMAEM As String = ""
        Private strTEMPFAC As String = ""
        Private strTNOMCOM As String = ""
        Private strCREGEMB As String = ""
        Private strTPAISEM As String = ""
        Private intCMEDTR As Int32 = 0
        Private intNTPDES As Int32 = 0
        Private intFLGMAI As Int32 = 0
        Private strSFLGES As String = ""
        '-- Adicionales 
        Private strTNOTAS As String = ""
        Private strCVPRCN As String = ""
        '-- Seguridad
        Private strCUSCRT As String = ""
        Private datFCHCRT As Date
        Private intHRACRT As Int32 = 0
        Private strCULUSA As String = ""
        Private datFULTAC As Date
        Private intHULTAC As Int32 = 0
        Private strSESTRG As String = ""
        Private intUPDATE_IDENT As Int32 = 0
        '-- End Propiedades --
#End Region
#Region " Propiedades "
        Public Property pCodigoCliente_CCLNT() As Int32
            Get
                pCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int32)
                intCCLNT = value
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

        Public Property pCodigoClienteTercero_CPRVCL() As Int32
            Get
                pCodigoClienteTercero_CPRVCL = intCPRVCL
            End Get
            Set(ByVal value As Int32)
                intCPRVCL = value
            End Set
        End Property

        Public Property pCodigoProveedorCliente_CPRPCL() As String
            Get
                pCodigoProveedorCliente_CPRPCL = strCPRPCL
            End Get
            Set(ByVal value As String)
                strCPRPCL = value
            End Set
        End Property

        Public Property pFechaOrdenCompra_FORCML() As Date
            Get
                pFechaOrdenCompra_FORCML = datFORCML
            End Get
            Set(ByVal value As Date)
                datFORCML = value
            End Set
        End Property

        Public Property pFechaRecepcionOrdenCompra_FROCMP() As Date
            Get
                pFechaRecepcionOrdenCompra_FROCMP = datFROCMP
            End Get
            Set(ByVal value As Date)
                datFROCMP = value
            End Set
        End Property

        Public Property pDescripcion_TDSCML() As String
            Get
                pDescripcion_TDSCML = strTDSCML
            End Get
            Set(ByVal value As String)
                strTDSCML = value
            End Set
        End Property

        Public Property pDescripcionCentroCosto_TCTCST() As String
            Get
                pDescripcionCentroCosto_TCTCST = strTCTCST
            End Get
            Set(ByVal value As String)
                strTCTCST = value
            End Set
        End Property

        Public Property pNumero_NSVP() As String
            Get
                pNumero_NSVP = strNSVP
            End Get
            Set(ByVal value As String)
                strNSVP = value
            End Set
        End Property

        Public Property pTerminoInternacioanlCarga_TTINTC() As String
            Get
                pTerminoInternacioanlCarga_TTINTC = strTTINTC
            End Get
            Set(ByVal value As String)
                strTTINTC = value
            End Set
        End Property

        Public Property pTerminoPago_TPAGME() As String
            Get
                pTerminoPago_TPAGME = strTPAGME
            End Get
            Set(ByVal value As String)
                strTPAGME = value
            End Set
        End Property

        Public Property pLugarEmbarque_TLUGEM() As String
            Get
                pLugarEmbarque_TLUGEM = strTLUGEM
            End Get
            Set(ByVal value As String)
                strTLUGEM = value
            End Set
        End Property

        Public Property pDestinoFinal_TDEFIN() As String
            Get
                pDestinoFinal_TDEFIN = strTDEFIN
            End Get
            Set(ByVal value As String)
                strTDEFIN = value
            End Set
        End Property

        Public Property pImporteCostoTotal_IVCOTO() As Decimal
            Get
                pImporteCostoTotal_IVCOTO = decIVCOTO
            End Get
            Set(ByVal value As Decimal)
                decIVCOTO = value
            End Set
        End Property

        Public Property pImporteTotalCompra_IVTOCO() As Decimal
            Get
                pImporteTotalCompra_IVTOCO = decIVTOCO
            End Get
            Set(ByVal value As Decimal)
                decIVTOCO = value
            End Set
        End Property

        Public Property pImporteTotalImpuesto_IVTOIM() As Decimal
            Get
                pImporteTotalImpuesto_IVTOIM = decIVTOIM
            End Get
            Set(ByVal value As Decimal)
                decIVTOIM = value
            End Set
        End Property

        Public Property pCodigoMoneda_CMNDA1() As String
            Get
                pCodigoMoneda_CMNDA1 = strCMNDA1
            End Get
            Set(ByVal value As String)
                strCMNDA1 = value
            End Set
        End Property

        Public Property pSimboloMoneda_NMONOC() As String
            Get
                pSimboloMoneda_NMONOC = strNMONOC
            End Get
            Set(ByVal value As String)
                strNMONOC = value
            End Set
        End Property

        Public Property pStatusFactura_SFACTU() As String
            Get
                pStatusFactura_SFACTU = strSFACTU
            End Get
            Set(ByVal value As String)
                strSFACTU = value
            End Set
        End Property

        Public Property pFechaFactura_FFACTU() As Date
            Get
                pFechaFactura_FFACTU = datFFACTU
            End Get
            Set(ByVal value As Date)
                datFFACTU = value
            End Set
        End Property

        Public Property pStatusTransferencia_STRANS() As String
            Get
                pStatusTransferencia_STRANS = strSTRANS
            End Get
            Set(ByVal value As String)
                strSTRANS = value
            End Set
        End Property

        Public Property pReferenciaCliente_NREFCL() As String
            Get
                pReferenciaCliente_NREFCL = strNREFCL
            End Get
            Set(ByVal value As String)
                strNREFCL = value
            End Set
        End Property

        Public Property pReferenciaDocumento_REFDO1() As String
            Get
                pReferenciaDocumento_REFDO1 = strREFDO1
            End Get
            Set(ByVal value As String)
                strREFDO1 = value
            End Set
        End Property

        Public Property pFechaSolicitud_FSOLIC() As Date
            Get
                pFechaSolicitud_FSOLIC = datFSOLIC
            End Get
            Set(ByVal value As Date)
                datFSOLIC = value
            End Set
        End Property

        Public Property pDescAreaEmpresa_TCMAEM() As String
            Get
                pDescAreaEmpresa_TCMAEM = strTCMAEM
            End Get
            Set(ByVal value As String)
                strTCMAEM = value
            End Set
        End Property

        Public Property pEmpresaFacturar_TEMPFAC() As String
            Get
                pEmpresaFacturar_TEMPFAC = strTEMPFAC
            End Get
            Set(ByVal value As String)
                strTEMPFAC = value
            End Set
        End Property

        Public Property pNombreComprador_TNOMCOM() As String
            Get
                pNombreComprador_TNOMCOM = strTNOMCOM
            End Get
            Set(ByVal value As String)
                strTNOMCOM = value
            End Set
        End Property

        Public Property pRegionEmbarque_CREGEMB() As String
            Get
                pRegionEmbarque_CREGEMB = strCREGEMB
            End Get
            Set(ByVal value As String)
                strCREGEMB = value
            End Set
        End Property

        Public Property pPaisEmbarque_TPAISEM() As String
            Get
                pPaisEmbarque_TPAISEM = strTPAISEM
            End Get
            Set(ByVal value As String)
                strTPAISEM = value
            End Set
        End Property

        Public Property pCodigoMedioTransporte_CMEDTR() As Int32
            Get
                pCodigoMedioTransporte_CMEDTR = intCMEDTR
            End Get
            Set(ByVal value As Int32)
                intCMEDTR = value
            End Set
        End Property

        Public Property pTipoDespacho_NTPDES() As Int32
            Get
                pTipoDespacho_NTPDES = intNTPDES
            End Get
            Set(ByVal value As Int32)
                intNTPDES = value
            End Set
        End Property

        Public Property pMarcaIdOrdenCompra_FLGMAI() As Int32
            Get
                pMarcaIdOrdenCompra_FLGMAI = intFLGMAI
            End Get
            Set(ByVal value As Int32)
                intFLGMAI = value
            End Set
        End Property

        Public Property pFlagEstado_SFLGES() As String
            Get
                pFlagEstado_SFLGES = strSFLGES
            End Get
            Set(ByVal value As String)
                strSFLGES = value
            End Set
        End Property

        Public Property pNotasOrdenCompra_TNOTAS() As String
            Get
                pNotasOrdenCompra_TNOTAS = strTNOTAS
            End Get
            Set(ByVal value As String)
                strTNOTAS = value
            End Set
        End Property

        Public Property pNave_CVPRCN() As String
            Get
                pNave_CVPRCN = strCVPRCN
            End Get
            Set(ByVal value As String)
                strCVPRCN = value
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
#End Region
    End Class

    Public Class clsItemOrdenCompra
#Region "Atributos"
        '-- Propiedades --
        Private intCCLNT As Int32 = 0
        Private strNORCML As String = ""
        Private intNRITOC As Int32 = 0
        Private strTCITCL As String = ""
        Private strTCITPR As String = ""
        Private strTDITES As String = ""
        Private strTDITIN As String = ""
        Private strCPTDAR As String = ""
        Private decQCNTIT As Decimal = 0
        Private decQCNPEM As Decimal = 0
        Private decQCNEMB As Decimal = 0
        Private decQSDOIT As Decimal = 0
        Private decQINEMP As Decimal = 0
        Private strTUNDIT As String = ""
        Private decIVUNIT As Decimal = 0
        Private decIVTOIT As Decimal = 0
        Private datFMPDME As Date
        Private datFMPIME As Date
        Private strTLUGEN As String = ""
        Private strTLUGOR As String = ""
        Private strFLGPEN As String = ""
        Private decQCNRCP As Decimal = 0
        Private decQCNDPC As Decimal = 0
        Private strSFLGES As String = ""
        Private decQSTKIT As Decimal = 0
        Private decQTOLMIN As Decimal = 0
        Private decQTOLMAX As Decimal = 0
        Private strSESEND As String = ""
        '-- Seguridad
        Private strCUSCRT As String = ""
        Private datFCHCRT As Date
        Private intHRACRT As Int32 = 0
        Private strCULUSA As String = ""
        Private datFULTAC As Date
        Private intHULTAC As Int32 = 0
        Private strSESTRG As String = ""
        Private intUPDATE_IDENT As Int32 = 0
        '-- End Propiedades --
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

        Public Property pNroItemOrdenCompraCliente_TCITCL() As String
            Get
                pNroItemOrdenCompraCliente_TCITCL = strTCITCL
            End Get
            Set(ByVal value As String)
                strTCITCL = value
            End Set
        End Property

        Public Property pNroItemOrdenCompraProveedor_TCITPR() As String
            Get
                pNroItemOrdenCompraProveedor_TCITPR = strTCITPR
            End Get
            Set(ByVal value As String)
                strTCITPR = value
            End Set
        End Property

        Public Property pDescripcionItemES_TDITES() As String
            Get
                pDescripcionItemES_TDITES = strTDITES
            End Get
            Set(ByVal value As String)
                strTDITES = value
            End Set
        End Property

        Public Property pDescripcionItemIN_TDITIN() As String
            Get
                pDescripcionItemIN_TDITIN = strTDITIN
            End Get
            Set(ByVal value As String)
                strTDITIN = value
            End Set
        End Property

        Public Property pPartidaArancelaria_CPTDAR() As String
            Get
                pPartidaArancelaria_CPTDAR = strCPTDAR
            End Get
            Set(ByVal value As String)
                strCPTDAR = value
            End Set
        End Property

        Public Property pCantidadItem_QCNTIT() As Decimal
            Get
                pCantidadItem_QCNTIT = decQCNTIT
            End Get
            Set(ByVal value As Decimal)
                decQCNTIT = value
            End Set
        End Property

        Public Property pCantidadPreEmbarque_QCNPEM() As Decimal
            Get
                pCantidadPreEmbarque_QCNPEM = decQCNPEM
            End Get
            Set(ByVal value As Decimal)
                decQCNPEM = value
            End Set
        End Property

        Public Property pCantidadEmbarque_QCNEMB() As Decimal
            Get
                pCantidadEmbarque_QCNEMB = decQCNEMB
            End Get
            Set(ByVal value As Decimal)
                decQCNEMB = value
            End Set
        End Property

        Public Property pIngresoEmbarcador_QSDOIT() As Decimal
            Get
                pIngresoEmbarcador_QSDOIT = decQSDOIT
            End Get
            Set(ByVal value As Decimal)
                decQSDOIT = value
            End Set
        End Property

        Public Property pDespachoEmbarcador_QINEMP() As Decimal
            Get
                pDespachoEmbarcador_QINEMP = decQINEMP
            End Get
            Set(ByVal value As Decimal)
                decQINEMP = value
            End Set
        End Property

        Public Property pUnidadMedida_TUNDIT() As String
            Get
                pUnidadMedida_TUNDIT = strTUNDIT
            End Get
            Set(ByVal value As String)
                strTUNDIT = value
            End Set
        End Property

        Public Property pImporteUnitario_IVUNIT() As Decimal
            Get
                pImporteUnitario_IVUNIT = decIVUNIT
            End Get
            Set(ByVal value As Decimal)
                decIVUNIT = value
            End Set
        End Property

        Public Property pImporteTotal_IVTOIT() As Decimal
            Get
                pImporteTotal_IVTOIT = decIVTOIT
            End Get
            Set(ByVal value As Decimal)
                decIVTOIT = value
            End Set
        End Property

        Public Property pFechaMaxProveedorDespacha_FMPDME() As Date
            Get
                pFechaMaxProveedorDespacha_FMPDME = datFMPDME
            End Get
            Set(ByVal value As Date)
                datFMPDME = value
            End Set
        End Property

        Public Property pFechaMaxIngresoAlmacenEmbarque_FMPIME() As Date
            Get
                pFechaMaxIngresoAlmacenEmbarque_FMPIME = datFMPIME
            End Get
            Set(ByVal value As Date)
                datFMPIME = value
            End Set
        End Property

        Public Property pLugarEntrega_TLUGEN() As String
            Get
                pLugarEntrega_TLUGEN = strTLUGEN
            End Get
            Set(ByVal value As String)
                strTLUGEN = value
            End Set
        End Property

        Public Property pLugarOrigen_TLUGOR() As String
            Get
                pLugarOrigen_TLUGOR = strTLUGOR
            End Get
            Set(ByVal value As String)
                strTLUGOR = value
            End Set
        End Property

        Public Property pFlagPlanEntrega_FLGPEN() As String
            Get
                pFlagPlanEntrega_FLGPEN = strFLGPEN
            End Get
            Set(ByVal value As String)
                strFLGPEN = value
            End Set
        End Property

        Public Property pCantidadItemRecepcion_QCNRCP() As Decimal
            Get
                pCantidadItemRecepcion_QCNRCP = decQCNRCP
            End Get
            Set(ByVal value As Decimal)
                decQCNRCP = value
            End Set
        End Property

        Public Property pCantidadItemDespacho_QCNDPC() As Decimal
            Get
                pCantidadItemDespacho_QCNDPC = decQCNDPC
            End Get
            Set(ByVal value As Decimal)
                decQCNDPC = value
            End Set
        End Property

        Public Property pFlagEstado_SFLGES() As String
            Get
                pFlagEstado_SFLGES = strSFLGES
            End Get
            Set(ByVal value As String)
                strSFLGES = value
            End Set
        End Property

        Public Property pCantidadStockATItem_QSTKIT() As Decimal
            Get
                pCantidadStockATItem_QSTKIT = decQSTKIT
            End Get
            Set(ByVal value As Decimal)
                decQSTKIT = value
            End Set
        End Property

        Public Property pCantidadToleranciaMinItem_QTOLMIN() As Decimal
            Get
                pCantidadToleranciaMinItem_QTOLMIN = decQTOLMIN
            End Get
            Set(ByVal value As Decimal)
                decQTOLMIN = value
            End Set
        End Property

        Public Property pCantidadToleranciaMaxItem_QTOLMAX() As Decimal
            Get
                pCantidadToleranciaMaxItem_QTOLMAX = decQTOLMAX
            End Get
            Set(ByVal value As Decimal)
                decQTOLMAX = value
            End Set
        End Property

        Public Property pFlagEstadoEntregaDetalle_SESEND() As String
            Get
                pFlagEstadoEntregaDetalle_SESEND = strSESEND
            End Get
            Set(ByVal value As String)
                strSESEND = value
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
#End Region
    End Class

    '----------------------------------------------------------------------------'
    '-- Orden de Compra - Interfase con otros Sistema a través de Web Services --'
    '----------------------------------------------------------------------------'
    Public Class boOrdenesComprasWSInt
#Region " Atributos "
        Private lstWSOCs As List(Of boOrdenCompraWSInt)
#End Region
#Region " Propiedades "
        Public ReadOnly Property Items() As List(Of boOrdenCompraWSInt)
            Get
                Return lstWSOCs
            End Get
        End Property
#End Region
#Region " Métodos "
        Sub New()
            lstWSOCs = New List(Of boOrdenCompraWSInt)
        End Sub

        Public Sub AddOC(ByVal oOC As boOrdenCompraWSInt)
            lstWSOCs.Add(oOC)
        End Sub

        Public Sub RemoveOC(ByVal oOC As boOrdenCompraWSInt)
            lstWSOCs.Remove(oOC)
        End Sub
#End Region
    End Class

    Public Class boOrdenCompraWSInt
#Region " Atributos "
        '-- OC --
        Private intCCLNT As Int64 = 0
        Private strNORCML As String = ""
        Private strTDSCML As String = ""
        Private intFORCML As Int32 = 0
        Private strTCTCST As String = ""
        Private strTTINTC As String = ""
        Private strTPAGME As String = ""
        Private strNMONOC As String = ""
        Private strTNMMDT As String = ""
        Private intNTPDES As Int32 = 0
        Private strTPAISEM As String = ""
        Private strTLUGEM As String = ""
        Private strTDEFIN As String = ""
        Private strTEMPFAC As String = ""
        Private strCREGEMB As String = ""
        Private strTNOMCOM As String = ""
        ' Proveedor
        Private intNRUCPR As Int64 = 0
        Private strTPRVCL As String = ""
        Private strTLFNO1 As String = ""
        Private strTNROFX As String = ""
        Private strTPRSCN As String = ""
        Private strTLFNO2 As String = ""
        Private strTEMAI3 As String = ""
        Private strTDRPRC As String = ""
        '-- End Propiedades --
        Private lstItems As List(Of boItemOrdenCompraWSInt)
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
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

        Public Property pstrDescripcion_TDSCML() As String
            Get
                Return strTDSCML
            End Get
            Set(ByVal value As String)
                strTDSCML = value
            End Set
        End Property

        Public Property pintFechaOrdenCompra_FORCML() As Int32
            Get
                Return intFORCML
            End Get
            Set(ByVal value As Int32)
                intFORCML = value
            End Set
        End Property

        Public ReadOnly Property pdteFechaOrdenCompra_FORCML() As Date
            Get
                Dim dteTemp As Date = New Date
                Dim strTemp As String = ""
                If intFORCML <> 0 Then
                    strTemp = intFORCML.ToString
                    strTemp = strTemp.Substring(4, 2) & "/" & strTemp.Substring(6, 2) & "/" & strTemp.Substring(0, 4)
                    Date.TryParse(strTemp, dteTemp)
                End If
                Return dteTemp
            End Get
        End Property

        Public Property pstrDescripcionCentroCosto_TCTCST() As String
            Get
                Return strTCTCST
            End Get
            Set(ByVal value As String)
                strTCTCST = value
            End Set
        End Property

        Public Property pstrTerminoInternacioanlCarga_TTINTC() As String
            Get
                Return strTTINTC
            End Get
            Set(ByVal value As String)
                strTTINTC = value
            End Set
        End Property

        Public Property pstrTerminoPago_TPAGME() As String
            Get
                Return strTPAGME
            End Get
            Set(ByVal value As String)
                strTPAGME = value
            End Set
        End Property

        Public Property pstrSimboloMoneda_NMONOC() As String
            Get
                Return strNMONOC
            End Get
            Set(ByVal value As String)
                strNMONOC = value
            End Set
        End Property

        Public Property pstrCodigoMedioTransporte_TNMMDT() As String
            Get
                Return strTNMMDT
            End Get
            Set(ByVal value As String)
                strTNMMDT = value
            End Set
        End Property

        Public Property pintTipoDespacho_NTPDES() As Int32
            Get
                Return intNTPDES
            End Get
            Set(ByVal value As Int32)
                intNTPDES = value
            End Set
        End Property

        Public Property pstrPaisEmbarque_TPAISEM() As String
            Get
                Return strTPAISEM
            End Get
            Set(ByVal value As String)
                strTPAISEM = value
            End Set
        End Property

        Public Property pstrLugarEmbarque_TLUGEM() As String
            Get
                Return strTLUGEM
            End Get
            Set(ByVal value As String)
                strTLUGEM = value
            End Set
        End Property

        Public Property pstrDestinoFinal_TDEFIN() As String
            Get
                Return strTDEFIN
            End Get
            Set(ByVal value As String)
                strTDEFIN = value
            End Set
        End Property

        Public Property pstrEmpresaFacturar_TEMPFAC() As String
            Get
                Return strTEMPFAC
            End Get
            Set(ByVal value As String)
                strTEMPFAC = value
            End Set
        End Property

        Public Property pstrRegionEmbarque_CREGEMB() As String
            Get
                Return strCREGEMB
            End Get
            Set(ByVal value As String)
                strCREGEMB = value
            End Set
        End Property

        Public Property pstrNombreComprador_TNOMCOM() As String
            Get
                Return strTNOMCOM
            End Get
            Set(ByVal value As String)
                strTNOMCOM = value
            End Set
        End Property

        Public Property pintNroRUCProveedor_NRUCPR() As Int64
            Get
                Return intNRUCPR
            End Get
            Set(ByVal value As Int64)
                intNRUCPR = value
            End Set
        End Property

        Public Property pstrDescripcionProveedor_TPRVCL() As String
            Get
                Return strTPRVCL
            End Get
            Set(ByVal value As String)
                strTPRVCL = value
            End Set
        End Property

        Public Property pstrTelefonoProveedor_TLFNO1() As String
            Get
                Return strTLFNO1
            End Get
            Set(ByVal value As String)
                strTLFNO1 = value
            End Set
        End Property

        Public Property pstrNroFAX_TNROFX() As String
            Get
                Return strTNROFX
            End Get
            Set(ByVal value As String)
                strTNROFX = value
            End Set
        End Property

        Public Property pstrContactoProveedor_TPRSCN() As String
            Get
                Return strTPRSCN
            End Get
            Set(ByVal value As String)
                strTPRSCN = value
            End Set
        End Property

        Public Property pstrTelefonoContacto_TLFNO2() As String
            Get
                Return strTLFNO2
            End Get
            Set(ByVal value As String)
                strTLFNO2 = value
            End Set
        End Property

        Public Property pstrEmailContacto_TEMAI3() As String
            Get
                Return strTEMAI3
            End Get
            Set(ByVal value As String)
                strTEMAI3 = value
            End Set
        End Property

        Public Property pstrDireccionProveedor_TDRPRC() As String
            Get
                Return strTDRPRC
            End Get
            Set(ByVal value As String)
                strTDRPRC = value
            End Set
        End Property

        Public ReadOnly Property Items() As List(Of boItemOrdenCompraWSInt)
            Get
                Return lstItems
            End Get
        End Property
#End Region
#Region " Métodos "
        Sub New()
            lstItems = New List(Of boItemOrdenCompraWSInt)
        End Sub

        Public Sub AddItem(ByVal oItem As boItemOrdenCompraWSInt)
            lstItems.Add(oItem)
        End Sub

        Public Sub RemoveItem(ByVal oItem As boItemOrdenCompraWSInt)
            lstItems.Remove(oItem)
        End Sub
#End Region
    End Class

    Public Class boItemOrdenCompraWSInt
#Region " Atributos "
        '-- Propiedades --
        Private intNRITOC As Int32 = 0
        Private strTCITCL As String = ""
        Private strTCITPR As String = ""
        Private decQCNTIT As Decimal = 0
        Private strTUNDIT As String = ""
        Private strTDITES As String = ""
        Private strTDITIN As String = ""
        Private decIVUNIT As Decimal = 0
        Private intFMPDME As Int64 = 0
        Private intFMPIME As Int64 = 0
        Private strCPTDAR As String = ""
        Private strTDEPTD As String = ""
        Private strTLUGEN As String = ""
        Private strTLUGOR As String = ""
        Private decQTOLMIN As Decimal = 0
        Private decQTOLMAX As Decimal = 0
#End Region
#Region " Propiedades "
        Public Property pintNroItemOrdenCompra_NRITOC() As Int32
            Get
                Return intNRITOC
            End Get
            Set(ByVal value As Int32)
                intNRITOC = value
            End Set
        End Property

        Public Property pstrNroItemOrdenCompraCliente_TCITCL() As String
            Get
                Return strTCITCL
            End Get
            Set(ByVal value As String)
                strTCITCL = value
            End Set
        End Property

        Public Property pstrNroItemOrdenCompraProveedor_TCITPR() As String
            Get
                Return strTCITPR
            End Get
            Set(ByVal value As String)
                strTCITPR = value
            End Set
        End Property

        Public Property pdecCantidadItem_QCNTIT() As Decimal
            Get
                Return decQCNTIT
            End Get
            Set(ByVal value As Decimal)
                decQCNTIT = value
            End Set
        End Property

        Public Property pstrUnidadMedida_TUNDIT() As String
            Get
                Return strTUNDIT
            End Get
            Set(ByVal value As String)
                strTUNDIT = value
            End Set
        End Property

        Public Property pstrDescripcionItemES_TDITES() As String
            Get
                Return strTDITES
            End Get
            Set(ByVal value As String)
                strTDITES = value
            End Set
        End Property

        Public Property pstrDescripcionItemIN_TDITIN() As String
            Get
                Return strTDITIN
            End Get
            Set(ByVal value As String)
                strTDITIN = value
            End Set
        End Property

        Public Property pdecImporteUnitario_IVUNIT() As Decimal
            Get
                Return decIVUNIT
            End Get
            Set(ByVal value As Decimal)
                decIVUNIT = value
            End Set
        End Property

        Public Property pintFechaMaxProveedorDespacha_FMPDME() As Int64
            Get
                Return intFMPDME
            End Get
            Set(ByVal value As Int64)
                intFMPDME = value
            End Set
        End Property

        Public ReadOnly Property pdteFechaMaxProveedorDespacha_FMPDME() As Date
            Get
                Dim dteTemp As Date = New Date
                Dim strTemp As String = ""
                If intFMPDME <> 0 Then
                    strTemp = intFMPDME.ToString
                    strTemp = strTemp.Substring(4, 2) & "/" & strTemp.Substring(6, 2) & "/" & strTemp.Substring(0, 4)
                    Date.TryParse(strTemp, dteTemp)
                End If
                Return dteTemp
            End Get
        End Property

        Public Property pintFechaMaxIngresoAlmacenEmbarque_FMPIME() As Int64
            Get
                Return intFMPIME
            End Get
            Set(ByVal value As Int64)
                intFMPIME = value
            End Set
        End Property

        Public ReadOnly Property pdteFechaMaxIngresoAlmacenEmbarque_FMPIME() As Date
            Get
                Dim dteTemp As Date = New Date
                Dim strTemp As String = ""
                If intFMPIME <> 0 Then
                    strTemp = intFMPIME.ToString
                    strTemp = strTemp.Substring(4, 2) & "/" & strTemp.Substring(6, 2) & "/" & strTemp.Substring(0, 4)
                    Date.TryParse(strTemp, dteTemp)
                End If
                Return dteTemp
            End Get
        End Property

        Public Property pstrPartidaArancelaria_CPTDAR() As String
            Get
                Return strCPTDAR
            End Get
            Set(ByVal value As String)
                strCPTDAR = value
            End Set
        End Property

        Public Property pstrDescripcionPartidaArancelaria_TDEPTD() As String
            Get
                Return strTDEPTD
            End Get
            Set(ByVal value As String)
                strTDEPTD = value
            End Set
        End Property

        Public Property pstrLugarEntrega_TLUGEN() As String
            Get
                Return strTLUGEN
            End Get
            Set(ByVal value As String)
                strTLUGEN = value
            End Set
        End Property

        Public Property pstrLugarOrigen_TLUGOR() As String
            Get
                Return strTLUGOR
            End Get
            Set(ByVal value As String)
                strTLUGOR = value
            End Set
        End Property

        Public Property pdecCantidadToleranciaMinItem_QTOLMIN() As Decimal
            Get
                Return decQTOLMIN
            End Get
            Set(ByVal value As Decimal)
                decQTOLMIN = value
            End Set
        End Property

        Public Property pdecCantidadToleranciaMaxItem_QTOLMAX() As Decimal
            Get
                Return decQTOLMAX
            End Get
            Set(ByVal value As Decimal)
                decQTOLMAX = value
            End Set
        End Property
#End Region
#Region " Métodos "
        
#End Region
    End Class

    '----------------------------------------------------------------------------------------------'
    '-- Error - Registro de Errores en la Gestión de Ordenes de Compras a través de Web Services --'
    '----------------------------------------------------------------------------------------------'
    Public Class clsWSErrorOrdenCompra
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

        Public Sub pAddError(ByVal strErrorCode As String, ByVal strMensajeError As String, ByVal strCliente As String, ByVal strOrdenCompra As String, _
                             ByVal strItem As String)
            Dim parentNode As XmlElement = Nothing
            Dim itemNode As XmlElement = Nothing

            parentNode = XMLError.CreateElement("ERRORORDENCOMPRA")
            XMLError.DocumentElement.PrependChild(parentNode)

            ' Crea los nodos requeridos de la cabecera
            Dim ErrorCode_Node As XmlElement = XMLError.CreateElement("ERRCOD")
            Dim ErrorMsg_Node As XmlElement = XMLError.CreateElement("ERRMSG")
            Dim Cliente_Node As XmlElement = XMLError.CreateElement("CCLNT")
            Dim OrdenCompra_Node As XmlElement = XMLError.CreateElement("NORCML")
            Dim NroItem_Node As XmlElement = XMLError.CreateElement("NRITOC")


            ' Asigna los valores respectivos a los nodos de la cabecera
            Dim ErrorCode_Text As XmlText = XMLError.CreateTextNode(strErrorCode)
            Dim ErrorMsg_Text As XmlText = XMLError.CreateTextNode(strMensajeError)
            Dim Cliente_Text As XmlText = XMLError.CreateTextNode(strCliente)
            Dim OrdenCompra_Text As XmlText = XMLError.CreateTextNode(strOrdenCompra)
            Dim NroItem_Text As XmlText = XMLError.CreateTextNode(strItem)


            ' Añade los nodos al nodo padre son los valores
            parentNode.AppendChild(ErrorCode_Node)
            parentNode.AppendChild(ErrorMsg_Node)
            parentNode.AppendChild(Cliente_Node)
            parentNode.AppendChild(OrdenCompra_Node)
            parentNode.AppendChild(NroItem_Node)

            ' Se guarda los valores en los respectivos nodos
            ErrorCode_Node.AppendChild(ErrorCode_Text)
            ErrorMsg_Node.AppendChild(ErrorMsg_Text)
            Cliente_Node.AppendChild(Cliente_Text)
            OrdenCompra_Node.AppendChild(OrdenCompra_Text)
            NroItem_Node.AppendChild(NroItem_Text)
        End Sub
#End Region
    End Class
End Namespace
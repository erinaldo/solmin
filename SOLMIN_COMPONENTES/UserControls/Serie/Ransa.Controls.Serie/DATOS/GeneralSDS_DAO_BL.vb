Imports RANSA.Utilitario
Imports RANSA.TYPEDEF

Namespace slnSOLMIN_SDSIMPLE
    '------------------------------------'
    '-- Objeto : Movimiento de Almacen --'
    '------------------------------------'
    Public Class clsMovimientoMercaderia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strTCMPCL As String = ""
        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private intCTRSP As Int32 = 0
        Private strTCMPTR As String = ""
        Private intNRUCT As Int64 = 0
        Private decNSLCRF As Decimal = 0
        Private strNPLCCM As String = ""
        Private strTMRCCM As String = ""
        Private intNANOCM As Int16 = 0
        Private strNBRVCH As String = ""
        Private strTNMBCH As String = ""
        Private intNLELCH As Int32 = 0
        Private strTOBSER As String = ""
        Private intCSRVC As Integer = 0
        Private lstItemMovimientoMercaderia As List(Of clsItemMovimientoMercaderia)
#End Region
#Region " Propiedades "
        Sub New()
            lstItemMovimientoMercaderia = New List(Of clsItemMovimientoMercaderia)
        End Sub


        Private _pintCodigoPedido_CDPEPL As Decimal
        Public Property pintCodigoPedido_CDPEPL() As Decimal
            Get
                Return _pintCodigoPedido_CDPEPL
            End Get
            Set(ByVal value As Decimal)
                _pintCodigoPedido_CDPEPL = value
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

        Private _pstrTipoAlmacenDesc_TALMC As String
        Public Property pstrTipoAlmacenDesc_TALMC() As String
            Get
                Return _pstrTipoAlmacenDesc_TALMC
            End Get
            Set(ByVal value As String)
                _pstrTipoAlmacenDesc_TALMC = value
            End Set
        End Property


        Private _pintCodCliente_Trasferencia_CCLNT As Int64
        Public Property pintCodCliente_Trasferencia_CCLNT() As Int64
            Get
                Return _pintCodCliente_Trasferencia_CCLNT
            End Get
            Set(ByVal value As Int64)
                _pintCodCliente_Trasferencia_CCLNT = value
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

        Private strTIPORG As String = ""
        Public Property pstrTipoOrigen_TIPORG() As String
            Get
                Return strTIPORG
            End Get
            Set(ByVal value As String)
                strTIPORG = value
            End Set
        End Property


        Private _strTIPORI As String = ""
        Public Property pstrTipoDocumentoOrigen_TIPORI() As String
            Get
                Return _strTIPORI
            End Get
            Set(ByVal value As String)
                _strTIPORI = value
            End Set
        End Property



        Private _strTOBSRV As String = ""
        Public Property pstrObservaciones_TOBSRV() As String
            Get
                Return _strTOBSRV
            End Get
            Set(ByVal value As String)
                _strTOBSRV = value
            End Set
        End Property


        Private _pstrCodigoProveedor_CPRVCL As String = "0"
        Public Property pstrCodigoProveedor_CPRVCL() As String
            Get
                Return _pstrCodigoProveedor_CPRVCL
            End Get
            Set(ByVal value As String)
                _pstrCodigoProveedor_CPRVCL = value
            End Set
        End Property



        Private _pbolEsDevolucion As Boolean = False
        Public Property pbolEsDevolucion() As Boolean
            Get
                Return _pbolEsDevolucion
            End Get
            Set(ByVal value As Boolean)
                _pbolEsDevolucion = value
            End Set
        End Property

        Private _pstrCodigoProveedor_cliente_CPRPCL As String
        Public Property pstrCodigoProveedor_cliente_CPRPCL() As String
            Get
                Return _pstrCodigoProveedor_cliente_CPRPCL
            End Get
            Set(ByVal value As String)
                _pstrCodigoProveedor_cliente_CPRPCL = value
            End Set
        End Property

        Private _strlSCNEMB As String = ""
        Public Property pstrControlEmbalaje_SCNEMB() As String
            Get
                Return _strlSCNEMB
            End Get
            Set(ByVal value As String)
                _strlSCNEMB = value
            End Set
        End Property


        Private _strEntregaAtiempo As String
        Public Property pstrEntregaAtiempo() As String
            Get
                Return _strEntregaAtiempo
            End Get
            Set(ByVal value As String)
                _strEntregaAtiempo = value
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
        ''' <summary>
        ''' Funciona para como campo para el embarque
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property pdecNumSolicitudDeReferencia_NSLCRF() As Decimal
            Get
                Return decNSLCRF
            End Get
            Set(ByVal value As Decimal)
                decNSLCRF = value
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


        Private _strFRLZSR As String
        Public Property pstrFechaRealizacion_FRLZSR() As String
            Get
                Return _strFRLZSR
            End Get
            Set(ByVal value As String)
                _strFRLZSR = value
            End Set
        End Property


        Private _pintCodCliente_CCLNT As Int64
        Public Property pintCodCliente_CCLNT() As Int64
            Get
                Return _pintCodCliente_CCLNT
            End Get
            Set(ByVal value As Int64)
                _pintCodCliente_CCLNT = value
            End Set
        End Property

        Private _intFRLZSR As Int64 = HelpClass.CDate_a_Numero8Digitos(Now.Date)
        Public Property pintFechaRealizacion_FRLZSR() As Int64
            Get
                Return _intFRLZSR
            End Get
            Set(ByVal value As Int64)
                _intFRLZSR = value
            End Set

        End Property



        Private _pintNrSolicitudServicio_NSLCSR As Integer
        Public Property pintNrSolicitudServicio_NSLCSR() As Integer
            Get
                Return _pintNrSolicitudServicio_NSLCSR
            End Get
            Set(ByVal value As Integer)
                _pintNrSolicitudServicio_NSLCSR = value
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

        Public ReadOnly Property plstItemMovimientoMercaderia() As List(Of clsItemMovimientoMercaderia)
            Get
                Return lstItemMovimientoMercaderia
            End Get
        End Property

        Public Sub AddItemMovimientoMercaderia(ByVal objItemMovimientoMercaderia As clsItemMovimientoMercaderia)
            lstItemMovimientoMercaderia.Add(objItemMovimientoMercaderia)
        End Sub

        Public Sub DeleteItemMovimientoMercaderia(ByVal objItemMovimientoMercaderia As clsItemMovimientoMercaderia)
            lstItemMovimientoMercaderia.Remove(objItemMovimientoMercaderia)
        End Sub
#End Region
    End Class

    Public Class clsItemMovimientoMercaderia
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
        Private strPSTALMC As String = ""
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
        Private intNRITOC As Int64 = 0
        Private _dblCDPEPL As Decimal = 0
        Private _dblCDREGP As Decimal = 0
        Private _strNOMPRO As String = ""
        Private _intCorrelativo As Integer = 0
#End Region
#Region " Propiedades "


        Public Property intCorrelativo() As Integer
            Get
                Return _intCorrelativo
            End Get
            Set(ByVal value As Integer)
                _intCorrelativo = value
            End Set
        End Property

        Private _PNQTRMC As Decimal = 0
        Public Property PNQTRMC() As Decimal
            Get
                Return _PNQTRMC
            End Get
            Set(ByVal value As Decimal)
                _PNQTRMC = value
            End Set
        End Property


        Private _PNQTRMP As Decimal = 0
        Public Property PNQTRMP() As Decimal
            Get
                Return _PNQTRMP
            End Get
            Set(ByVal value As Decimal)
                _PNQTRMP = value
            End Set
        End Property

        Private _PSTIPORI As String = ""
        Public Property PSTIPORI() As String
            Get
                Return _PSTIPORI
            End Get
            Set(ByVal value As String)
                _PSTIPORI = value
            End Set
        End Property



        Private _PSNLTECL As String
        Public Property PSNLTECL() As String
            Get
                Return _PSNLTECL
            End Get
            Set(ByVal value As String)
                _PSNLTECL = value
            End Set
        End Property


        Private _PSTIPORG As String = ""
        Public Property PSTIPORG() As String
            Get
                Return _PSTIPORG
            End Get
            Set(ByVal value As String)
                _PSTIPORG = value
            End Set
        End Property


        Public Property NrItemPedidoPLanta_CDREGP() As Decimal
            Get
                Return _dblCDREGP
            End Get
            Set(ByVal value As Decimal)
                _dblCDREGP = value
            End Set
        End Property

        Public Property CodPedidoPlanta_CDPEPL() As Decimal
            Get
                Return _dblCDPEPL
            End Get
            Set(ByVal value As Decimal)
                _dblCDPEPL = value
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


        Private _pintNrSolicitudServicio_NSLCSR As Integer
        Public Property pintNrSolicitudServicio_NSLCSR() As Integer
            Get
                Return _pintNrSolicitudServicio_NSLCSR
            End Get
            Set(ByVal value As Integer)
                _pintNrSolicitudServicio_NSLCSR = value
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


        Private _pstrCodigoProveedor_CPRVCL As String = "0"
        Public Property pstrCodigoProveedor_CPRVCL() As String
            Get
                Return _pstrCodigoProveedor_CPRVCL
            End Get
            Set(ByVal value As String)
                _pstrCodigoProveedor_CPRVCL = value
            End Set
        End Property

        Public Property pstrNombreProveedor_NOMPRO() As String
            Get
                Return _strNOMPRO
            End Get
            Set(ByVal value As String)
                _strNOMPRO = value
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

        Public Property pstrTipoAlmacenDesc_TALMC() As String
            Get
                Return strPSTALMC
            End Get
            Set(ByVal value As String)
                strPSTALMC = value
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


        Private strTCMZNA As String
        Public Property pstrZonaAlmacen_TCMZNA() As String
            Get
                Return strTCMZNA
            End Get
            Set(ByVal value As String)
                strTCMZNA = value
            End Set
        End Property


        Private _pstrAlmacen_TCMPAL As String
        Public Property pstrAlmacen_TCMPAL() As String
            Get
                Return _pstrAlmacen_TCMPAL
            End Get
            Set(ByVal value As String)
                _pstrAlmacen_TCMPAL = value
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





        Public Property pintNroItemOC_NRITOC() As Int64
            Get
                Return intNRITOC
            End Get
            Set(ByVal value As Int64)
                intNRITOC = value
            End Set
        End Property

        Private decNSLCRF As Decimal = 0
        ''' <summary>
        ''' Funciona para como campo para el embarque
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property pdecNumSolicitudDeReferencia_NSLCRF() As Decimal
            Get
                Return decNSLCRF
            End Get
            Set(ByVal value As Decimal)
                decNSLCRF = value
            End Set
        End Property


        Private _strTPOOCM As String
        Public Property pstrTipoOc_TPOOCM() As String
            Get
                Return _strTPOOCM
            End Get
            Set(ByVal value As String)
                _strTPOOCM = value
            End Set
        End Property

        Private _NrSolicitudSalida_NSLCSS As Decimal

        Public Property pintNroSolicitudSalida_NSLCSS() As Decimal
            Get
                Return _NrSolicitudSalida_NSLCSS
            End Get
            Set(ByVal value As Decimal)
                _NrSolicitudSalida_NSLCSS = value
            End Set
        End Property

        Private _pintCodigoPedido_CDPEPL As Decimal




        Private _oListaProyecto As List(Of beProyecto)
        Public Property oListaProyecto() As List(Of beProyecto)
            Get
                Return _oListaProyecto
            End Get
            Set(ByVal value As List(Of beProyecto))
                _oListaProyecto = value
            End Set
        End Property


        Private _pbolEsOutotec As Boolean
        Public Property pbolEsOutotec() As Boolean
            Get
                Return _pbolEsOutotec
            End Get
            Set(ByVal value As Boolean)
                _pbolEsOutotec = value
            End Set
        End Property


        Private _pstrNrRefPedido_NRFRPD As String
        Public Property pstrNrRefPedido_NRFRPD() As String
            Get
                Return _pstrNrRefPedido_NRFRPD
            End Get
            Set(ByVal value As String)
                _pstrNrRefPedido_NRFRPD = value
            End Set
        End Property

        Private _strTipoMovIntfz As String
        ''' <summary>
        ''' Tipo de movimiento de interfaz
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property pstrTipoMovIntfz() As String
            Get
                Return _strTipoMovIntfz
            End Get
            Set(ByVal value As String)
                _strTipoMovIntfz = value
            End Set
        End Property


        Private _strCodProvCliente_CPRPCL As String
        Public Property pstrCodProvCliente_CPRPCL() As String
            Get
                Return _strCodProvCliente_CPRPCL
            End Get
            Set(ByVal value As String)
                _strCodProvCliente_CPRPCL = value
            End Set
        End Property



#End Region
    End Class

    '--------------------------------'
    '-- Objeto : Orden de Servicio --'
    '--------------------------------'
    Public Class clsCrearOrdenServicio
#Region " Atributos "
        Private intNORDSR As Int64 = 0
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

    Public Class clsInformacionOrdenServicio
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
#End Region
    End Class
End Namespace


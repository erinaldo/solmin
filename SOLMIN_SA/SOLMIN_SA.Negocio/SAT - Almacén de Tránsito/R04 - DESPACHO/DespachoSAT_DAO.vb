Namespace slnSOLMIN_SAT.Despacho
    Public Class clsParamImprGuiaRemision
#Region " Atributos "
        Private intNLINGR As Integer = 0
        Private strMOGUIA As String = ""
        Private strDECONC As String = ""
        Private strMGUIFA As String = ""
        Private strMGFFIN As String = ""
        Private strMOBSER As String = ""
        Private strTOXBUL As String = ""
#End Region
#Region " Propiedades "



        Private strError As String
        Public Property strMensajeError() As String
            Get
                Return strError
            End Get
            Set(ByVal value As String)
                strError = value
            End Set
        End Property


        Private _strAplicacion As String
        Public Property strAplicacion() As String
            Get
                Return _strAplicacion
            End Get
            Set(ByVal value As String)
                _strAplicacion = value
            End Set
        End Property

        Private dblCCLNT As Decimal
        Public Property pdblCodigoCliente() As Decimal
            Get
                Return dblCCLNT
            End Get
            Set(ByVal value As Decimal)
                dblCCLNT = value
            End Set
        End Property

        Private strCCMPN As String
        Public Property pstrgCodigoCompania() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property

        Private strCDVSN As String
        Public Property pstrCodigoDivision() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property

        Private dblCPLNDV As Decimal
        Public Property pdblCodigoPlanta() As Decimal
            Get
                Return dblCPLNDV
            End Get
            Set(ByVal value As Decimal)
                dblCPLNDV = value
            End Set
        End Property

        Private dblNRGUSA As Decimal
        Public Property pdblGuiaSalida() As Decimal
            Get
                Return dblNRGUSA
            End Get
            Set(ByVal value As Decimal)
                dblNRGUSA = value
            End Set
        End Property

        Private dblNGUIRM As Decimal
        Public Property pdblGuiaRemision() As Decimal
            Get
                Return dblNGUIRM
            End Get
            Set(ByVal value As Decimal)
                dblNGUIRM = value
            End Set
        End Property

        Public Property pintNroLineasPorGuiaRemision() As Integer
            Get
                Return intNLINGR
            End Get
            Set(ByVal value As Integer)
                intNLINGR = value
            End Set
        End Property

        Public Property pstrModeloGuiaRemision() As String
            Get
                Return strMOGUIA
            End Get
            Set(ByVal value As String)
                strMOGUIA = value
            End Set
        End Property

        Public Property pstrConsolidarDetalle() As String
            Get
                Return strDECONC
            End Get
            Set(ByVal value As String)
                strDECONC = value
            End Set
        End Property

        Public Property pblnConsolidarDetalle() As Boolean
            Get
                If strDECONC = "S" Then
                    Return True
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    strDECONC = "S"
                Else
                    strDECONC = "N"
                End If
            End Set
        End Property

        Public Property pstrMostrarInformacionGuiaProveedor() As String
            Get
                Return strMGUIFA
            End Get
            Set(ByVal value As String)
                strMGUIFA = value
            End Set
        End Property

        Public Property pblnMostrarInformacionGuiaProveedor() As Boolean
            Get
                If strMGUIFA = "S" Then
                    Return True
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    strMGUIFA = "S"
                Else
                    strMGUIFA = "N"
                End If
            End Set
        End Property

        Public Property pstrMostrarInfGuiaProveedorAlFinal() As String
            Get
                Return strMGFFIN
            End Get
            Set(ByVal value As String)
                strMGFFIN = value
            End Set
        End Property

        Public Property pblnMostrarInfGuiaProveedorAlFinal() As Boolean
            Get
                If strMGFFIN = "S" Then
                    Return True
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    strMGFFIN = "S"
                Else
                    strMGFFIN = "N"
                End If
            End Set
        End Property

        Public Property pstrMostrarObservaciones() As String
            Get
                Return strMOBSER
            End Get
            Set(ByVal value As String)
                strMOBSER = value
            End Set
        End Property

        Public Property pblnMostrarObservaciones() As Boolean
            Get
                If strMOBSER = "S" Then
                    Return True
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    strMOBSER = "S"
                Else
                    strMOBSER = "N"
                End If
            End Set
        End Property

        Public Property pstrMostrarTotalPorBulto() As String
            Get
                Return strTOXBUL
            End Get
            Set(ByVal value As String)
                strTOXBUL = value
            End Set
        End Property

        Public Property pblnMostrarTotalPorBulto() As Boolean
            Get
                If strTOXBUL = "S" Then
                    Return True
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    strTOXBUL = "S"
                Else
                    strTOXBUL = "N"
                End If
            End Set
        End Property
#End Region
    End Class

    Public Class clsGuiaSalida
#Region " Atributos "
        Private strCCMPN As String
        Private strCDVSN As String
        Private strCPLNDV As Double = 0
        Private strSESTRG As String = ""
        Private intNRGUSA As Int64 = 0
        Private intCCLNT As Int32 = 0
        Private intNROCTL As Int32 = 0
        Private datFSLDAL As Date
        Private strSMTRCP As String = ""
        Private strSSNCRG As String = ""
        Private strTOBSGS As String = ""
        Private strTOBDGS As String = ""
        Private intCTRSPT As Int32 = 0
        Private strNPLCUN As String = ""
        Private strNPLCAC As String = ""
        Private strCBRCNT As String = ""
        Private strSTPOCM As String = ""
        Private intNTCKPS As Int32 = 0
        Private strSTPDSP As String = ""
#End Region
#Region " Propiedades "

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
                Return strCPLNDV
            End Get
            Set(ByVal value As Double)
                strCPLNDV = value
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

        Public Property pNroGuiaSalida_NRGUSA() As Int64
            Get
                pNroGuiaSalida_NRGUSA = intNRGUSA
            End Get
            Set(ByVal value As Int64)
                intNRGUSA = value
            End Set
        End Property

        Public Property pCodigoCliente_CCLNT() As Int32
            Get
                pCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int32)
                intCCLNT = value
            End Set
        End Property

        Public Property pNroControl_NROCTL() As Int32
            Get
                pNroControl_NROCTL = intNROCTL
            End Get
            Set(ByVal value As Int32)
                intNROCTL = value
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

        Public ReadOnly Property pFechaSalidaAlmacen_FSLDAL_Num() As Int32
            Get
                Dim intTemp As Int32 = 0
                If datFSLDAL.Year > 1 Then Int32.TryParse(datFSLDAL.ToString("yyyyMMdd"), intTemp)
                Return intTemp
            End Get
        End Property

        Public Property pMotivoRecepcion_SMTRCP() As String
            Get
                pMotivoRecepcion_SMTRCP = strSMTRCP
            End Get
            Set(ByVal value As String)
                strSMTRCP = value
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

        Public Property pObservacionGuiaSalidaLinea01() As String
            Get
                pObservacionGuiaSalidaLinea01 = strTOBSGS
            End Get
            Set(ByVal value As String)
                strTOBSGS = value
            End Set
        End Property

        Public Property pObservacionGuiaSalidaLinea02() As String
            Get
                pObservacionGuiaSalidaLinea02 = strTOBDGS
            End Get
            Set(ByVal value As String)
                strTOBDGS = value
            End Set
        End Property

        Public Property pCodigoTransportista_CTRSPT() As Int32
            Get
                pCodigoTransportista_CTRSPT = intCTRSPT
            End Get
            Set(ByVal value As Int32)
                intCTRSPT = value
            End Set
        End Property

        Public Property pNroPlacaUnidad_NPLCUN() As String
            Get
                pNroPlacaUnidad_NPLCUN = strNPLCUN
            End Get
            Set(ByVal value As String)
                strNPLCUN = value
            End Set
        End Property

        Public Property pNroPlacaAcoplado_NPLCAC() As String
            Get
                pNroPlacaAcoplado_NPLCAC = strNPLCAC
            End Get
            Set(ByVal value As String)
                strNPLCAC = value
            End Set
        End Property

        Public Property pCodigoBreveteTransportista_CBRCNT() As String
            Get
                pCodigoBreveteTransportista_CBRCNT = strCBRCNT
            End Get
            Set(ByVal value As String)
                strCBRCNT = value
            End Set
        End Property

        Public Property pTipoCampo_STPOCM() As String
            Get
                pTipoCampo_STPOCM = strSTPOCM
            End Get
            Set(ByVal value As String)
                strSTPOCM = value
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

        Public Property pTipoDespacho_STPDSP() As String
            Get
                pTipoDespacho_STPDSP = strSTPDSP
            End Get
            Set(ByVal value As String)
                strSTPDSP = value
            End Set
        End Property
#End Region
    End Class
End Namespace

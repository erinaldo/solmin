Imports System.Text.Encoding

Public Class beOrdenCompra
    Inherits beBase(Of beOrdenCompra)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    Public pCCLNT_CodigoCliente As Int64 = 0
    Public pNORCML_NroOrdenCompra As String = ""
    Public pCPRVCL_CodigoClienteTercero As Int32 = 0
    Public pFORCML_FechaOCDte As Date
    Public pFSOLIC_FechaSolicOCDte As Date
    Public pTDSCML_Descripcion As String = ""
    Public pNMONOC_MonedaDeOC As String = ""
    Public pTCMAEM_DescAreaEmpresa As String = ""
    Public pTTINTC_TerminoIntern As String = ""
    Public pNREFCL_ReferenciaCliente As String = ""
    Public pTPAGME_TerminoPago As String = ""
    Public pREFDO1_ReferenciaDocumento As String = ""
    Public pNTPDES_Prioridad As Integer = 0
    Public pCMNDA1_Moneda As Int32 = 0
    Public pTEMPFAC_EmpresaFacturar As String = ""
    Public pTNOMCOM_NombreComprador As String = ""
    Public pTCTCST_CentroCosto As String = ""
    Public pCREGEMB_RegEmbarque As String = ""
    Public pCMEDTR_MedioTransporte As Int32 = 0
    Public pTDEFIN_DestinoFinal As String = ""
    Public pIVCOTO_ImporteCostoTotal As Decimal = 0.0
    Public pIVTOCO_ImporteTotalCompra As Decimal = 0.0
    Public pIVTOIM_ImporteTotalImpuesto As Decimal = 0.0
    Public pTDAITM_Observaciones As String = ""
    Public pCPRVCL_CodigoProveedor As String = ""
    Public PCPRPCL_CodigoClienteProveedor As String = ""
    Public pNRUCPR_RucProveedor As String = ""
    Public pTPRVCL_DescripcionProveedor As String = ""
    Public pTLFN01_TelefonoProveedor As String = ""
    Public pTNROFX_FaxProveedor As String = ""
    Public pTPDRPRC_DireccionProveedor As String = ""
    Public pTPRSCN_ContactoProveedor As String = ""
    Public pTLFN02_TelefonoContacto As String = ""
    Public pTEAMI3_EmailContacto As String = ""
    Public pEXISTE_FechaOCDte As Boolean = False
    Public pFORCML_INI_FechaOCInicial As Int64 = 0
    Public pFORCML_FIN_FechaOCFin As Int64 = 0
    Public pTPRCL1_DescripcionProveedor As String = ""
    Public pTNOMCOM_Nombre_Del_Comprador As String = ""



    'ORDENES DE COMPRA

    Private _PNANIO As Decimal
    Public Property PNANIO() As Decimal
        Get
            Return _PNANIO
        End Get
        Set(ByVal value As Decimal)
            _PNANIO = value
        End Set
    End Property

    Private _PNCCLNT As Decimal
    Private _PSNORCML As String
    Private _NrOCCliente As Integer
    Private _PNCPRVCL As Decimal
    Private _PSCPRPCL As String
    Private _PNFORCML As Decimal
    Private _PNFROCMP As Decimal
    Private _PSTDSCML As String
    Private _PSTCTCST As String
    Private _PSNSVP As String
    Private _PSTTINTC As String
    Private _PSTPAGME As String
    Private _PSTLUGEM As String
    Private _PSTDEFIN As String
    Private _PNIVCOTO As Decimal
    Private _PNIVTOCO As Decimal
    Private _PNIVTOIM As Decimal
    Private _PNCMNDA1 As Decimal
    Private _PSNMONOC As String
    Private _PSSFACTU As String
    Private _PNFFACTU As Decimal
    Private _PSSTRANS As String
    Private _PSNREFCL As String
    Private _PSREFDO1 As String
    Private _PNFSOLIC As Decimal
    Private _PSTCMAEM As String
    Private _PSTEMPFAC As String
    Private _PSTNOMCOM As String
    Private _PSCREGEMB As String
    Private _PSTPAISEM As String
    Private _PNCMEDTR As Decimal
    Private _PNNTPDES As Decimal
    Private _PNFLGMAI As Decimal
    Private _PSSFLGES As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSCULUSA As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal
    Private _CodOC As String

    Public _FechaOCDte As Date
    Private _PSTDAITM As String

    Private _PSRUCPR As String
    Private _PSTPRVCL As String
    Private _PSTLFNO1 As String
    Private _PSTNROFX As String
    Private _PSTPDRPRC As String
    Private _PSTPRSCN As String
    Private _PSTLFN02 As String
    Private _PSTEAMI3 As String
    Private _PSEXISTE As String
    Private _PSFORCML_INI As String
    Private _PSFORCML_FIN As String
    Private _PSTPRCL1 As String
    Private _PSTNMMDT As String
    Private _Image As String
    Private _PSTCNDPG As String = ""
    Private _PNGUIRN As Decimal = 0
    Private _NroItem As Integer = 0
    Private _PSCZNALM As String = ""
    Private _PSCMRCLR As String = ""
    Private _PSTMRCD2 As String = ""
    Private _CODPROV As Decimal = 0
    Private _CODPROVOUT As String = ""
    Private _PSCUNCN5 As String = ""
    Private _PNQTRMC As Decimal = 0
    Private _PSCTPALM As String = ""
    Private _PSCALMC As String = ""
    Private _PSTALMC As String = ""
    Private _PSTCMPAL As String = ""
    Private _PSTLFNO2 As String = ""
    Private _PSTEMAI3 As String = ""

    ''GASTON
    Private _PSNCTAMA As String = ""
    Private _PSNELPEP As String = ""
    ''GASTON

    Public Property PSNCTAMA() As String
        Get
            Return (_PSNCTAMA)
        End Get
        Set(ByVal value As String)
            _PSNCTAMA = value
        End Set
    End Property
    Public Property PSNELPEP() As String
        Get
            Return (_PSNELPEP)
        End Get
        Set(ByVal value As String)
            _PSNELPEP = value
        End Set
    End Property


    'Alberto 26102018
    Private _PSTCTCAL As String

    Public Property PSTCTCAL() As String
        Get
            Return (_PSTCTCAL)
        End Get
        Set(ByVal value As String)
            _PSTCTCAL = value
        End Set
    End Property

    Public Property CodOC() As String
        Get
            Return (_CodOC)
        End Get
        Set(ByVal value As String)
            _CodOC = value
        End Set
    End Property

    Public Property PSTDAITM() As String
        Get
            Return (_PSTDAITM)
        End Get
        Set(ByVal value As String)
            _PSTDAITM = value
        End Set
    End Property

    Public Property FechaOCDte() As Date
        Get
            Return (_FechaOCDte)
        End Get
        Set(ByVal value As Date)
            _FechaOCDte = value
        End Set
    End Property


    Public Property Image() As String
        Get
            Return (_Image)
        End Get
        Set(ByVal value As String)
            _Image = value
        End Set
    End Property


    Public Property PSRUCPR() As String
        Get
            Return (_PSRUCPR)
        End Get
        Set(ByVal value As String)
            _PSRUCPR = value
        End Set
    End Property
    Public Property PSTPRVCL() As String
        Get
            Return (_PSTPRVCL)
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property
    Public Property PSTLFNO1() As String
        Get
            Return (_PSTLFNO1)
        End Get
        Set(ByVal value As String)
            _PSTLFNO1 = value
        End Set
    End Property
    Public Property PSTNROFX() As String
        Get
            Return (_PSTNROFX)
        End Get
        Set(ByVal value As String)
            _PSTNROFX = value
        End Set
    End Property
    Public Property PSTPDRPRC() As String
        Get
            Return (_PSTPDRPRC)
        End Get
        Set(ByVal value As String)
            _PSTPDRPRC = value
        End Set
    End Property
    Public Property PSTPRSCN() As String
        Get
            Return (_PSTPRSCN)
        End Get
        Set(ByVal value As String)
            _PSTPRSCN = value
        End Set
    End Property
    Public Property PSTLFN02() As String
        Get
            Return (_PSTLFN02)
        End Get
        Set(ByVal value As String)
            _PSTLFN02 = value
        End Set
    End Property
    Public Property PSTEAMI3() As String
        Get
            Return (_PSTEAMI3)
        End Get
        Set(ByVal value As String)
            _PSTEAMI3 = value
        End Set
    End Property
    Public Property PSEXISTE() As String
        Get
            Return (_PSEXISTE)
        End Get
        Set(ByVal value As String)
            _PSEXISTE = value
        End Set
    End Property
    Public Property PSFORCML_INI() As String
        Get
            Return (_PSFORCML_INI)
        End Get
        Set(ByVal value As String)
            _PSFORCML_INI = value
        End Set
    End Property
    Public Property PSFORCML_FIN() As String
        Get
            Return (_PSFORCML_FIN)
        End Get
        Set(ByVal value As String)
            _PSFORCML_FIN = value
        End Set
    End Property
    Public Property PSTPRCL1() As String
        Get
            Return (_PSTPRCL1)
        End Get
        Set(ByVal value As String)
            _PSTPRCL1 = value
        End Set
    End Property

    Public Property PNCPRVCL() As Decimal
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property
    Public Property PSCPRPCL() As String
        Get
            Return (_PSCPRPCL)
        End Get
        Set(ByVal value As String)
            _PSCPRPCL = value
        End Set
    End Property
    Public Property PNFORCML() As Decimal
        Get
            Return (_PNFORCML)
        End Get
        Set(ByVal value As Decimal)
            _PNFORCML = value
        End Set
    End Property
    Public Property PNFROCMP() As Decimal
        Get
            Return (_PNFROCMP)
        End Get
        Set(ByVal value As Decimal)
            _PNFROCMP = value
        End Set
    End Property
    Public Property PSTDSCML() As String
        Get
            Return (_PSTDSCML)
        End Get
        Set(ByVal value As String)
            _PSTDSCML = value
        End Set
    End Property

    Public Property PSNSVP() As String
        Get
            Return (_PSNSVP)
        End Get
        Set(ByVal value As String)
            _PSNSVP = value
        End Set
    End Property
    Public Property PSTTINTC() As String
        Get
            Return (_PSTTINTC)
        End Get
        Set(ByVal value As String)
            _PSTTINTC = value
        End Set
    End Property
    Public Property PSTPAGME() As String
        Get
            Return (_PSTPAGME)
        End Get
        Set(ByVal value As String)
            _PSTPAGME = value
        End Set
    End Property
    Public Property PSTLUGEM() As String
        Get
            Return (_PSTLUGEM)
        End Get
        Set(ByVal value As String)
            _PSTLUGEM = value
        End Set
    End Property
    Public Property PSTDEFIN() As String
        Get
            Return (_PSTDEFIN)
        End Get
        Set(ByVal value As String)
            _PSTDEFIN = value
        End Set
    End Property
    Public Property PNIVCOTO() As Decimal
        Get
            Return (_PNIVCOTO)
        End Get
        Set(ByVal value As Decimal)
            _PNIVCOTO = value
        End Set
    End Property
    Public Property PNIVTOCO() As Decimal
        Get
            Return (_PNIVTOCO)
        End Get
        Set(ByVal value As Decimal)
            _PNIVTOCO = value
        End Set
    End Property
    Public Property PNIVTOIM() As Decimal
        Get
            Return (_PNIVTOIM)
        End Get
        Set(ByVal value As Decimal)
            _PNIVTOIM = value
        End Set
    End Property
    Public Property PNCMNDA1() As Decimal
        Get
            Return (_PNCMNDA1)
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property
    Public Property PSNMONOC() As String
        Get
            Return (_PSNMONOC)
        End Get
        Set(ByVal value As String)
            _PSNMONOC = value
        End Set
    End Property
    Public Property PSSFACTU() As String
        Get
            Return (_PSSFACTU)
        End Get
        Set(ByVal value As String)
            _PSSFACTU = value
        End Set
    End Property
    Public Property PNFFACTU() As Decimal
        Get
            Return (_PNFFACTU)
        End Get
        Set(ByVal value As Decimal)
            _PNFFACTU = value
        End Set
    End Property
    Public Property PSSTRANS() As String
        Get
            Return (_PSSTRANS)
        End Get
        Set(ByVal value As String)
            _PSSTRANS = value
        End Set
    End Property
    Public Property PSNREFCL() As String
        Get
            Return (_PSNREFCL)
        End Get
        Set(ByVal value As String)
            If value.Trim.Length > 15 Then
                value = value.Substring(0, 14)
            End If
            _PSNREFCL = value
        End Set
    End Property
    Public Property PSREFDO1() As String
        Get
            Return (_PSREFDO1)
        End Get
        Set(ByVal value As String)
            _PSREFDO1 = value
        End Set
    End Property
    Public Property PNFSOLIC() As Decimal
        Get
            Return (_PNFSOLIC)
        End Get
        Set(ByVal value As Decimal)
            _PNFSOLIC = value
        End Set
    End Property
    Public Property PSTCMAEM() As String
        Get
            Return (_PSTCMAEM)
        End Get
        Set(ByVal value As String)
            _PSTCMAEM = value
        End Set
    End Property
    Public Property PSTEMPFAC() As String
        Get
            Return (_PSTEMPFAC)
        End Get
        Set(ByVal value As String)
            _PSTEMPFAC = value
        End Set
    End Property
    Public Property PSTNOMCOM() As String
        Get
            Return (_PSTNOMCOM)
        End Get
        Set(ByVal value As String)
            _PSTNOMCOM = value
        End Set
    End Property
    Public Property PSCREGEMB() As String
        Get
            Return (_PSCREGEMB)
        End Get
        Set(ByVal value As String)
            _PSCREGEMB = value
        End Set
    End Property
    Public Property PSTPAISEM() As String
        Get
            Return (_PSTPAISEM)
        End Get
        Set(ByVal value As String)
            _PSTPAISEM = value
        End Set
    End Property
    Public Property PNCMEDTR() As Decimal
        Get
            Return (_PNCMEDTR)
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTR = value
        End Set
    End Property
    Public Property PNNTPDES() As Decimal
        Get
            Return (_PNNTPDES)
        End Get
        Set(ByVal value As Decimal)
            _PNNTPDES = value
        End Set
    End Property
    Public Property PNFLGMAI() As Decimal
        Get
            Return (_PNFLGMAI)
        End Get
        Set(ByVal value As Decimal)
            _PNFLGMAI = value
        End Set
    End Property

    Public Property PSTCNDPG() As String
        Get
            Return (_PSTCNDPG)
        End Get
        Set(ByVal value As String)
            _PSTCNDPG = value
        End Set
    End Property




    'DETALLE ORDEN DE COMPRA

    Private _PNNRITOC As Decimal
    Private _NrItemCliente As Decimal

    Private _PSTCITCL As String
    Private _PSTCITPR As String
    Private _PSTDITES As String
    Private _PSTDITIN As String
    Private _PSCPTDAR As String
    Private _PSCODTPN As String
    Private _PSNRFRPD As String
    Private _PNQCNTIT As Decimal
    Private _PNQCNPEM As Decimal
    Private _PNQCNEMB As Decimal
    Private _PNQSDOIT As Decimal
    Private _PNQINEMP As Decimal
    Private _PSTUNDIT As String
    Private _PNIVUNIT As Decimal
    Private _PNIVTOIT As Decimal
    Private _PNFMPDME As Decimal
    Private _PNFMPIME As Decimal

    Private _PSTLUGEN As String
    Private _PSTLUGOR As String
    Private _PSFLGPEN As String
    Private _PNQCNRCP As Decimal
    Private _PNQCNDPC As Decimal

    Private _PNQSTKIT As Decimal
    Private _PNQTOLMIN As Decimal
    Private _PNQTOLMAX As Decimal
    Private _PNQCNVRS As Decimal
    Private _PSTUNDCN As String
    Private _PSTRFRN As String
    Private _PSTRFRNA As String
    Private _PSTRFRNB As String
    Private _PSTRFRN1 As String
    Private _PSTRFRN2 As String
    Private _PSTRFRN3 As String
    Private _PSSESEND As String



    Private _PNNORSCI As Decimal
    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property



    Private _PSFORSCI As String
    Public Property PSFORSCI() As String
        Get
            Return _PSFORSCI
        End Get
        Set(ByVal value As String)
            _PSFORSCI = value
        End Set
    End Property


    Private _PSNDOCEM As String
    Public Property PSNDOCEM() As String
        Get
            Return _PSNDOCEM
        End Get
        Set(ByVal value As String)
            _PSNDOCEM = value
        End Set
    End Property

    Private _PSLOTE As String
    Public Property PSLOTE() As String
        Get
            Return _PSLOTE
        End Get
        Set(ByVal value As String)
            _PSLOTE = value
        End Set
    End Property



#Region "Detalle Oc"
    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PSNORCML() As String
        Get
            Return (_PSNORCML)
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property NrOCCliente() As Integer
        Get
            Return (_NrOCCliente)
        End Get
        Set(ByVal value As Integer)
            _NrOCCliente = value
        End Set
    End Property


    Private _PNNSEQIN As Decimal
    Public Property PNNSEQIN() As Decimal
        Get
            Return _PNNSEQIN
        End Get
        Set(ByVal value As Decimal)
            _PNNSEQIN = value
        End Set
    End Property

    Public Property PNNRITOC() As Decimal
        Get
            Return (_PNNRITOC)
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property

    Public Property NrItemCliente() As Decimal
        Get
            Return (_NrItemCliente)
        End Get
        Set(ByVal value As Decimal)
            _NrItemCliente = value
        End Set
    End Property

    Public Property PSTCITCL() As String
        Get
            Return (_PSTCITCL)
        End Get
        Set(ByVal value As String)
            _PSTCITCL = value
        End Set
    End Property
    Public Property PSTCITPR() As String
        Get
            Return (_PSTCITPR)
        End Get
        Set(ByVal value As String)
            _PSTCITPR = value
        End Set
    End Property
    Public Property PSTDITES() As String
        Get
            Return (_PSTDITES)
        End Get
        Set(ByVal value As String)
            _PSTDITES = value
        End Set
    End Property
    Public Property PSTDITIN() As String
        Get
            Return (_PSTDITIN)
        End Get
        Set(ByVal value As String)
            _PSTDITIN = value
        End Set
    End Property
    Public Property PSCPTDAR() As String
        Get
            Return (_PSCPTDAR)
        End Get
        Set(ByVal value As String)
            _PSCPTDAR = value
        End Set
    End Property
    Public Property PSCODTPN() As String
        Get
            Return (_PSCODTPN)
        End Get
        Set(ByVal value As String)
            _PSCODTPN = value
        End Set
    End Property
    Public Property PSNRFRPD() As String
        Get
            Return (_PSNRFRPD)
        End Get
        Set(ByVal value As String)
            _PSNRFRPD = value
        End Set
    End Property
    Public Property PNQCNTIT() As Decimal
        Get
            Return (_PNQCNTIT)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNTIT = value
        End Set
    End Property
    Public Property PNQCNPEM() As Decimal
        Get
            Return (_PNQCNPEM)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNPEM = value
        End Set
    End Property
    Public Property PNQCNEMB() As Decimal
        Get
            Return (_PNQCNEMB)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNEMB = value
        End Set
    End Property
    Public Property PNQSDOIT() As Decimal
        Get
            Return (_PNQSDOIT)
        End Get
        Set(ByVal value As Decimal)
            _PNQSDOIT = value
        End Set
    End Property
    Public Property PNQINEMP() As Decimal
        Get
            Return (_PNQINEMP)
        End Get
        Set(ByVal value As Decimal)
            _PNQINEMP = value
        End Set
    End Property
    Public Property PSTUNDIT() As String
        Get
            Return (_PSTUNDIT)
        End Get
        Set(ByVal value As String)
            _PSTUNDIT = value
        End Set
    End Property
    Public Property PNIVUNIT() As Decimal
        Get
            Return (_PNIVUNIT)
        End Get
        Set(ByVal value As Decimal)
            _PNIVUNIT = value
        End Set
    End Property
    Public Property PNIVTOIT() As Decimal
        Get
            Return (_PNIVTOIT)
        End Get
        Set(ByVal value As Decimal)
            _PNIVTOIT = value
        End Set
    End Property
    Public Property PNFMPDME() As Decimal
        Get
            Return (_PNFMPDME)
        End Get
        Set(ByVal value As Decimal)
            _PNFMPDME = value
        End Set
    End Property
    Public Property PNFMPIME() As Decimal
        Get
            Return (_PNFMPIME)
        End Get
        Set(ByVal value As Decimal)
            _PNFMPIME = value
        End Set
    End Property
    Public Property PSTCTCST() As String
        Get
            Return (_PSTCTCST)
        End Get
        Set(ByVal value As String)
            _PSTCTCST = value
        End Set
    End Property
    Public Property PSTLUGEN() As String
        Get
            Return (_PSTLUGEN)
        End Get
        Set(ByVal value As String)
            _PSTLUGEN = value
        End Set
    End Property
    Public Property PSTLUGOR() As String
        Get
            Return (_PSTLUGOR)
        End Get
        Set(ByVal value As String)
            _PSTLUGOR = value
        End Set
    End Property
    Public Property PSFLGPEN() As String
        Get
            Return (_PSFLGPEN)
        End Get
        Set(ByVal value As String)
            _PSFLGPEN = value
        End Set
    End Property
    Public Property PNQCNRCP() As Decimal
        Get
            Return (_PNQCNRCP)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNRCP = value
        End Set
    End Property
    Public Property PNQCNDPC() As Decimal
        Get
            Return (_PNQCNDPC)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNDPC = value
        End Set
    End Property
    Public Property PSSFLGES() As String
        Get
            Return (_PSSFLGES)
        End Get
        Set(ByVal value As String)
            _PSSFLGES = value
        End Set
    End Property
    Public Property PNQSTKIT() As Decimal
        Get
            Return (_PNQSTKIT)
        End Get
        Set(ByVal value As Decimal)
            _PNQSTKIT = value
        End Set
    End Property
    Public Property PNQTOLMIN() As Decimal
        Get
            Return (_PNQTOLMIN)
        End Get
        Set(ByVal value As Decimal)
            _PNQTOLMIN = value
        End Set
    End Property
    Public Property PNQTOLMAX() As Decimal
        Get
            Return (_PNQTOLMAX)
        End Get
        Set(ByVal value As Decimal)
            _PNQTOLMAX = value
        End Set
    End Property
    Public Property PNQCNVRS() As Decimal
        Get
            Return (_PNQCNVRS)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNVRS = value
        End Set
    End Property
    Public Property PSTUNDCN() As String
        Get
            Return (_PSTUNDCN)
        End Get
        Set(ByVal value As String)
            _PSTUNDCN = value
        End Set
    End Property
    Public Property PSTRFRN() As String
        Get
            Return (_PSTRFRN)
        End Get
        Set(ByVal value As String)
            _PSTRFRN = value
        End Set
    End Property
    Public Property PSTRFRNA() As String
        Get
            Return (_PSTRFRNA)
        End Get
        Set(ByVal value As String)
            _PSTRFRNA = value
        End Set
    End Property
    Public Property PSTRFRNB() As String
        Get
            Return (_PSTRFRNB)
        End Get
        Set(ByVal value As String)
            _PSTRFRNB = value
        End Set
    End Property
    Public Property PSTRFRN1() As String
        Get
            Return (_PSTRFRN1)
        End Get
        Set(ByVal value As String)
            _PSTRFRN1 = value
        End Set
    End Property
    Public Property PSTRFRN2() As String
        Get
            Return (_PSTRFRN2)
        End Get
        Set(ByVal value As String)
            _PSTRFRN2 = value
        End Set
    End Property
    Public Property PSTRFRN3() As String
        Get
            Return (_PSTRFRN3)
        End Get
        Set(ByVal value As String)
            _PSTRFRN3 = value
        End Set
    End Property
    Public Property PSSESEND() As String
        Get
            Return (_PSSESEND)
        End Get
        Set(ByVal value As String)
            _PSSESEND = value
        End Set
    End Property
    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_PNFCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_PNHRACRT)
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property

    Private _PSNTRMCR As String = ""
    ''' <summary>
    ''' Terminal Usado para creacion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNTRMCR() As String
        Get
            Return _PSNTRMCR
        End Get
        Set(ByVal value As String)
            _PSNTRMCR = value
        End Set
    End Property


    Private _PSNTRMNL As String=""
    ''' <summary>
    ''' Terminal Usado al actulizar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property

    Public Property PNFULTAC() As Decimal
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property

#End Region
#Region "Observaciones de OC"


    Private _PNNCRRLT As Decimal
    Public Property PNNCRRLT() As Decimal
        Get
            Return _PNNCRRLT
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRLT = value
        End Set
    End Property

    Private _PSTNOTAS As String
    Public Property PSTNOTAS() As String
        Get
            Return _PSTNOTAS
        End Get
        Set(ByVal value As String)
            _PSTNOTAS = value
        End Set
    End Property

#End Region

    Private _PNCMEDTS As Decimal
    Public Property PNCMEDTS() As Decimal
        Get
            Return _PNCMEDTS
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTS = value
        End Set
    End Property

    Private _PSTCTCSA As String
    Public Property PSTCTCSA() As String
        Get
            Return _PSTCTCSA
        End Get
        Set(ByVal value As String)
            _PSTCTCSA = value
        End Set
    End Property


    Private _PSTCTCSF As String
    Public Property PSTCTCSF() As String
        Get
            Return _PSTCTCSF
        End Get
        Set(ByVal value As String)
            _PSTCTCSF = value
        End Set
    End Property


    Private _PSTPIMSA As String
    Public Property PSTPIMSA() As String
        Get
            Return _PSTPIMSA
        End Get
        Set(ByVal value As String)
            _PSTPIMSA = value
        End Set
    End Property



    Private _PSTPPOSA As String
    Public Property PSTPPOSA() As String
        Get
            Return _PSTPPOSA
        End Get
        Set(ByVal value As String)
            _PSTPPOSA = value
        End Set
    End Property


    Private _PSCCNCOS As String
    Public Property PSCCNCOS() As String
        Get
            Return _PSCCNCOS
        End Get
        Set(ByVal value As String)
            _PSCCNCOS = value
        End Set
    End Property


    Private _PSCCEBEN As String
    Public Property PSCCEBEN() As String
        Get
            Return _PSCCEBEN
        End Get
        Set(ByVal value As String)
            _PSCCEBEN = value
        End Set
    End Property


    Private _PSNGFSAP As String
    Public Property PSNGFSAP() As String
        Get
            Return _PSNGFSAP
        End Get
        Set(ByVal value As String)
            _PSNGFSAP = value
        End Set
    End Property


    Private _PSNORSAP As String
    Public Property PSNORSAP() As String
        Get
            Return _PSNORSAP
        End Get
        Set(ByVal value As String)
            _PSNORSAP = value
        End Set
    End Property

    Private _PSTCTAFE As String
    Public Property PSTCTAFE() As String
        Get
            Return _PSTCTAFE
        End Get
        Set(ByVal value As String)
            _PSTCTAFE = value
        End Set
    End Property


    Private _PNFRQALC As Decimal
    Public Property PNFRQALC() As Decimal

        Get
            Return _PNFRQALC
        End Get
        Set(ByVal value As Decimal)
            _PNFRQALC = value
        End Set
    End Property


    Private _PNCPLNDV As Decimal
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNQCNPEN As Decimal
    Public Property PNQCNPEN() As Decimal
        Get
            Return _PNQCNPEN
        End Get
        Set(ByVal value As Decimal)
            _PNQCNPEN = value
        End Set
    End Property


    Private _PNQCNREC As Decimal
    Public Property PNQCNREC() As Decimal
        Get
            Return _PNQCNREC
        End Get
        Set(ByVal value As Decimal)
            _PNQCNREC = value
        End Set
    End Property


    Private _PNQTOMAX As Decimal
    Public Property PNQTOMAX() As Decimal
        Get
            Return _PNQTOMAX
        End Get
        Set(ByVal value As Decimal)
            _PNQTOMAX = value
        End Set
    End Property


    Private _PSCREFFW As String
    Public Property PSCREFFW() As String
        Get
            Return _PSCREFFW
        End Get
        Set(ByVal value As String)
            _PSCREFFW = value
        End Set
    End Property


    Private _PNQBLTSR As Decimal
    Public Property PNQBLTSR() As Decimal
        Get
            Return _PNQBLTSR
        End Get
        Set(ByVal value As Decimal)
            _PNQBLTSR = value
        End Set
    End Property
    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property

    Private _CHK As Boolean
    Public Property CHK() As Boolean
        Get
            Return _CHK
        End Get
        Set(ByVal value As Boolean)
            _CHK = value
        End Set
    End Property

    Private _PNFECHAINI As Decimal
    Public Property PNFECHAINI() As Decimal
        Get
            Return _PNFECHAINI
        End Get
        Set(ByVal value As Decimal)
            _PNFECHAINI = value
        End Set
    End Property
    Private _PNFECHAFIN As Decimal
    Public Property PNFECHAFIN() As Decimal
        Get
            Return _PNFECHAFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECHAFIN = value
        End Set
    End Property
    Private _PSFINCVG As String
    Public Property PSFINCVG() As String
        Get
            Return _PSFINCVG
        End Get
        Set(ByVal value As String)
            _PSFINCVG = value
        End Set
    End Property
    Private _PSFFINVG As String
    Public Property PSFFINVG() As String
        Get
            Return _PSFFINVG
        End Get
        Set(ByVal value As String)
            _PSFFINVG = value
        End Set
    End Property
    Private _PNIPRCTJ As Decimal
    Public Property PNIPRCTJ() As Decimal
        Get
            Return _PNIPRCTJ
        End Get
        Set(ByVal value As Decimal)
            _PNIPRCTJ = value
        End Set
    End Property

    Private _PNDISTR As Decimal
    Public Property PNDISTR() As Decimal
        Get
            Return _PNDISTR
        End Get
        Set(ByVal value As Decimal)
            _PNDISTR = value
        End Set
    End Property
    Private _PNNCRRDT As Decimal
    Public Property PNNCRRDT() As Decimal
        Get
            Return _PNNCRRDT
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRDT = value
        End Set
    End Property

    Private _PNNCRRDTNUEVO As Decimal
    Public Property PNNCRRDTNUEVO() As Decimal
        Get
            Return _PNNCRRDTNUEVO
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRDTNUEVO = value
        End Set
    End Property


    Private _PSTUNPSO As String
    Public Property PSTUNPSO() As String
        Get
            Return _PSTUNPSO
        End Get
        Set(ByVal value As String)
            _PSTUNPSO = value
        End Set
    End Property

    Private _PNQVOPQT As Decimal
    Public Property PNQVOPQT() As Decimal
        Get
            Return _PNQVOPQT
        End Get
        Set(ByVal value As Decimal)
            _PNQVOPQT = value
        End Set
    End Property

    Private _PSTUNVOL As String
    Public Property PSTUNVOL() As String
        Get
            Return _PSTUNVOL
        End Get
        Set(ByVal value As String)
            _PSTUNVOL = value
        End Set
    End Property

    Private _PSCIDPAQ As String
    Public Property PSCIDPAQ() As String
        Get
            Return _PSCIDPAQ
        End Get
        Set(ByVal value As String)
            _PSCIDPAQ = value
        End Set
    End Property



    Private _PNFECVIG As Decimal
    ''' <summary>
    '''Fecha de Cuenta de imputacion 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaVigencia() As Date
        Get
            Return NumeroAFecha(_PNFECVIG)
        End Get
        Set(ByVal value As Date)
            _PNFECVIG = CtypeDate(value)
        End Set
    End Property

    Public Property PNFECVIG() As Decimal
        Get
            Return _PNFECVIG
        End Get
        Set(ByVal value As Decimal)
            _PNFECVIG = value
        End Set
    End Property

    Private _PSNFACPR As String
    Public Property PSNFACPR() As String
        Get
            Return _PSNFACPR
        End Get
        Set(ByVal value As String)
            _PSNFACPR = value
        End Set
    End Property


    Private _PNFFACPR As Decimal
    Public Property PNFFACPR() As Decimal
        Get
            Return _PNFFACPR
        End Get
        Set(ByVal value As Decimal)
            _PNFFACPR = value
        End Set
    End Property


    Private _PSNGRPRV As String
    Public Property PSNGRPRV() As String
        Get
            Return _PSNGRPRV
        End Get
        Set(ByVal value As String)
            _PSNGRPRV = value
        End Set
    End Property

    Private _PSPRIORIDAD As String

    Public Property PSPRIORIDAD() As String
        Get
            Return _PSPRIORIDAD
        End Get
        Set(ByVal value As String)
            _PSPRIORIDAD = value
        End Set
    End Property


    ''' <summary>
    ''' Fecha estimada de entrega al Cliente 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaEstimadaEntrega() As String
        Get
            Return NumeroAFecha(_PNFMPDME)
        End Get
        Set(ByVal value As String)
            _PNFMPDME = CtypeDate(value)
        End Set
    End Property

    ''' <summary>
    ''' Fecha Requerida planta del Cliente 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaReqPlanta() As String
        Get
            Return NumeroAFecha(_PNFMPIME)
        End Get
        Set(ByVal value As String)
            _PNFMPIME = CtypeDate(value)
        End Set
    End Property


    Public Property FechaSolicitud() As String
        Get
            Return NumeroAFecha(_PNFSOLIC)
        End Get
        Set(ByVal value As String)
            PNFSOLIC = CtypeDate(value)
        End Set
    End Property

    Public Property FechaOrdenDeCompra() As String
        Get
            Return NumeroAFecha(_PNFORCML)
        End Get
        Set(ByVal value As String)
            _PNFORCML = CtypeDate(value)
        End Set
    End Property


    Private _PNFORCMI As Decimal
    Public Property PNFORCMI() As Decimal
        Get
            Return _PNFORCMI
        End Get
        Set(ByVal value As Decimal)
            _PNFORCMI = value
        End Set
    End Property


    Private _PNFORCMF As Decimal
    Public Property PNFORCMF() As Decimal
        Get
            Return _PNFORCMF
        End Get
        Set(ByVal value As Decimal)
            _PNFORCMF = value
        End Set
    End Property

    Public Property FechaInicioOC() As String
        Get
            Return NumeroAFecha(_PNFORCMI)
        End Get
        Set(ByVal value As String)
            _PNFORCMI = CtypeDate(value)
        End Set
    End Property
    Public Property FechaFinOc() As String
        Get
            Return NumeroAFecha(_PNFORCMF)
        End Get
        Set(ByVal value As String)
            _PNFORCMF = CtypeDate(value)
        End Set
    End Property



    Private _PNFMPDMI As Decimal
    Public Property PNFMPDMI() As Decimal
        Get
            Return _PNFMPDMI
        End Get
        Set(ByVal value As Decimal)
            _PNFMPDMI = value
        End Set
    End Property


    Private _PNFMPDMF As Decimal
    Public Property PNFMPDMF() As Decimal
        Get
            Return _PNFMPDMF
        End Get
        Set(ByVal value As Decimal)
            _PNFMPDMF = value
        End Set
    End Property



    Public Property FechaInicioEntregaProveedor() As String
        Get
            Return NumeroAFecha(_PNFMPDMI)
        End Get
        Set(ByVal value As String)
            _PNFMPDMI = CtypeDate(value)
        End Set
    End Property
    Public Property FechaFinEntregaProveedor() As String
        Get
            Return NumeroAFecha(PNFMPDMF)
        End Get
        Set(ByVal value As String)
            PNFMPDMF = CtypeDate(value)
        End Set
    End Property


    Private _PSSTATOC As String
    Public Property PSSTATOC() As String
        Get
            Return _PSSTATOC
        End Get
        Set(ByVal value As String)
            _PSSTATOC = value
        End Set
    End Property



    Private _Compania As String
    Public Property Compania() As String
        Get
            Return _Compania
        End Get
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property


    Private _Division As String
    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property


    Private _Planta As String
    Public Property Planta() As String
        Get
            Return _Planta
        End Get
        Set(ByVal value As String)
            _Planta = value
        End Set
    End Property


    Private _Clientes As String
    Public Property Cliente() As String
        Get
            Return _Clientes
        End Get
        Set(ByVal value As String)
            _Clientes = value
        End Set
    End Property


    Private _Proveedor As String
    Public Property Proveedor() As String
        Get
            Return _Proveedor
        End Get
        Set(ByVal value As String)
            _Proveedor = value
        End Set
    End Property


    Private _PSTIPLIN As String
    Public Property PSTIPLIN() As String
        Get
            Return _PSTIPLIN
        End Get
        Set(ByVal value As String)
            _PSTIPLIN = value
        End Set
    End Property


    Private _PSTPOOCM As String
    Public Property PSTPOOCM() As String
        Get
            Return _PSTPOOCM
        End Get
        Set(ByVal value As String)
            _PSTPOOCM = value
        End Set
    End Property


    Private _PSNRUCPR As String = ""
    Public Property PSNRUCPR() As String
        Get
            Return _PSNRUCPR
        End Get
        Set(ByVal value As String)
            _PSNRUCPR = value
        End Set
    End Property


    Public Property PNGUIRN() As Decimal
        Get
            Return _PNGUIRN
        End Get
        Set(ByVal value As Decimal)
            _PNGUIRN = value
        End Set
    End Property

    '_NroItem

    Public Property NROITEM() As Integer
        Get
            Return _NroItem
        End Get
        Set(ByVal value As Integer)
            _NroItem = value
        End Set
    End Property


    Public Property PSCZNALM() As String
        Get
            Return _PSCZNALM
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property

    Public Property PSCMRCLR() As String
        Get
            Return _PSCMRCLR
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = value
        End Set
    End Property

    Public Property PSTMRCD2() As String
        Get
            Return _PSTMRCD2
        End Get
        Set(ByVal value As String)
            _PSTMRCD2 = value
        End Set
    End Property


    Private _PSTMRCD3 As String
    Public Property PSTMRCD3() As String
        Get
            Return _PSTMRCD3
        End Get
        Set(ByVal value As String)
            _PSTMRCD3 = value
        End Set
    End Property



    Public Property CODPROV() As Decimal
        Get
            Return _CODPROV
        End Get
        Set(ByVal value As Decimal)
            _CODPROV = value
        End Set
    End Property



    Public Property CODPROVOUT() As String
        Get
            Return _CODPROVOUT
        End Get
        Set(ByVal value As String)
            _CODPROVOUT = value
        End Set
    End Property

    Public Property PSCUNCN5() As String
        Get
            Return _PSCUNCN5
        End Get
        Set(ByVal value As String)
            _PSCUNCN5 = value
        End Set
    End Property

    Public Property PNQTRMC() As Decimal
        Get
            Return _PNQTRMC
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC = value
        End Set
    End Property

    Private _TCMZNA As String
    Public Property PSTCMZNA() As String
        Get
            Return _TCMZNA
        End Get
        Set(ByVal value As String)
            _TCMZNA = value
        End Set
    End Property


    Public Property PSCTPALM() As String
        Get
            Return _PSCTPALM
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property

    Public Property PSCALMC() As String
        Get
            Return _PSCALMC
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property

    Public Property PSTALMC() As String
        Get
            Return _PSTALMC
        End Get
        Set(ByVal value As String)
            _PSTALMC = value
        End Set
    End Property

    Public Property PSTCMPAL() As String
        Get
            Return _PSTCMPAL
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property
    Public Property PSTLFNO2() As String
        Get
            Return _PSTLFNO2
        End Get
        Set(ByVal value As String)
            If _PSTLFNO2 = Value Then
                Return
            End If
            _PSTLFNO2 = Value
        End Set
    End Property
    Public Property PSTEMAI3() As String
        Get
            Return _PSTEMAI3
        End Get
        Set(ByVal value As String)
            If _PSTEMAI3 = Value Then
                Return
            End If
            _PSTEMAI3 = Value
        End Set
    End Property

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Private _PSCMATPE As String
    Private _PSFGIQBF As String
    Private _PSCCLMAT As String
    Private _PSCPRFUN As String
    Private _PSCUNMAT As String
    Private _PSFCHCAD As String
    Private _PSMESG As String = ""
    'Private _PSCODLOTE As String = ""
    'Private _PSDESCLOTE As String = ""
    Public Property PSCMATPE() As String
        Get
            Return (_PSCMATPE)
        End Get
        Set(ByVal value As String)
            _PSCMATPE = value
        End Set
    End Property

    Public Property PSFGIQBF() As String
        Get
            Return _PSFGIQBF
        End Get
        Set(ByVal value As String)
            _PSFGIQBF = value
        End Set
    End Property

    Public Property PSCCLMAT() As String
        Get
            Return _PSCCLMAT
        End Get
        Set(ByVal value As String)
            _PSCCLMAT = value
        End Set
    End Property

    Public Property PSCPRFUN() As String
        Get
            Return _PSCPRFUN
        End Get
        Set(ByVal value As String)
            _PSCPRFUN = value
        End Set
    End Property

    Public Property PSCUNMAT() As String
        Get
            Return _PSCUNMAT
        End Get
        Set(ByVal value As String)
            _PSCUNMAT = value
        End Set
    End Property

    Public Property PSFCHCAD() As String
        Get
            Return _PSFCHCAD
        End Get
        Set(ByVal value As String)
            _PSFCHCAD = value
        End Set
    End Property

    Public Property PSMESG() As String
        Get
            Return _PSMESG
        End Get
        Set(ByVal value As String)
            _PSMESG = value
        End Set
    End Property

    'Public Property PSCODLOTE() As String
    '    Get
    '        Return _PSCODLOTE
    '    End Get
    '    Set(ByVal value As String)
    '        _PSCODLOTE = value
    '    End Set
    'End Property

    'Public Property PSDESCLOTE() As String
    '    Get
    '        Return _PSDESCLOTE
    '    End Get
    '    Set(ByVal value As String)
    '        _PSDESCLOTE = value
    '    End Set
    'End Property
 
  
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.
End Class



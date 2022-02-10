Public Class FacturaPreDoc_BE
#Region "Atributo"

    Private _NOPRCN As Double = 0
    Private _CTPOSR As String = ""
    Private _CTPSBS As String = ""
    Private _FINCOP As Double = 0
    Private _FINCOP_S As String = ""
    Private _FTRMOP As Double = 0
    Private _NPLNMT As Double = 0
    Private _SESTOP As String = ""
    Private _SFCTOP As String = ""
    Private _NDCPRF As Double = 0
    Private _FDCPRF As Double = 0
    Private _CTPDCF As Double = 0
    Private _NDCMFC As Double = 0
    Private _NORSRT As Double = 0 ' foreign key de tbl04
    Private _TRFSRC As String = ""
    Private _QMRCDR As Double = 0
    Private _PMRCDR As Double = 0
    Private _VMRCDR As Double = 0
    Private _CMRCDR As Double = 0
    Private _TRFMRC As String = ""
    Private _NINFOP As Double = 0
    Private _CCLNT As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _NVJES As Double = 0
    Private _CVPRCN As String = ""
    Private _SCNTR As String = ""
    Private _CCLNFC As Double = 0
    Private _CPLNCL As Double = 0
    Private _SORGMV As String = ""
    Private _NDCORM As Double = 0
    Private _TNMBRM As String = ""
    Private _TDRCRM As String = ""
    Private _TPDCIR As String = ""
    Private _NRUCRM As Double = 0
    Private _TNMBCN As String = ""
    Private _TDRCNS As String = ""
    Private _TPDCIC As String = ""
    Private _NRUCCN As Double = 0
    Private _SINDPS As String = ""
    Private _CCNCST As Double = 0
    Private _ITPCMT As Double = 0
    Private _NPRLQD As Double = 0
    Private _NPRCRG As Double = 0
    Private _QCNTRC As Double = 0
    Private _QPSORC As Double = 0
    Private _NBKNCN As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""

    Private _NGUITR As Double = 0
    Private _FGUITR As Double = 0
    Private _SESTGU As String = ""
    Private _NLQDCN As Double = 0
    Private _CLCLOR As String = ""
    Private _CLCLDS As String = ""
    Private _NGUIRF As Double = 0
    Private _FGUIRF As Double = 0
    Private _CTRSPT As Double = 0
    Private _NPLVHT As String = ""
    Private _CBRCNT As String = ""
    Private _FSLDCM As Double = 0
    Private _FLLGCM As Double = 0
    Private _TCMPCL As String = ""
    Private _COUNT As Double = 0
    Private _TCNTCS As String = ""
    Private _RUTA As String = ""
    Private _TCMPCF As String = ""
    Private _TPLNTA As String = ""
    Private _TCMTPS As String = ""
    Private _TCMSBS As String = ""
    Private _TCMRCD As String = ""
    Private _QKMREC As Double = 0
    Private _IMPOCOS As Double = 0
    Private _IMPOCOD As Double = 0
    Private _TCRVTA As String = ""
    Private _CRGVTA As String = ""

    Private _NKMRCR As Double = 0
    Private _QGLNCM As Double = 0
    Private _NRUCTR As String = ""
    Private _NPLCUN As String = ""
    Private _NCSOTR As Double = 0
    Private _CONDUCTOR As String = ""
    Private _NGUIRM As Double = 0
    Private _FEMVLH As Double = 0
    Private _PMRCMC As Double = 0
    Private _CTPOVJ As String = ""
    Private _NVLGRF As Double = 0

    REM ECM-HUNDRED-INICIO
    Private _CDSCSP As String = ""
    Private _TDSCSP As String = ""
    Private _CDSCSP_TDSCSP As String = ""
    REM ECM-HUNDRED-FIN


    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Private _PLANTA As String = ""
    Private _PLANTA_FACT As String = ""
    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN


    Private _CEBEO As String = ""
    Private _CECOD As String = ""
    Private _NROVLR As Decimal = 0
    Private _SEGVLR_DESC As String = ""
    Private _DOCVLR As String = ""
    Private _SEGVLR As String = ""
    Private _OP_FACTURABLE As String = ""
    Private _POR_VLR As String = ""
#End Region

#Region "Properties"

  

    Public Property TCNTCS() As String
        Get
            Return _TCNTCS
        End Get
        Set(ByVal Value As String)
            _TCNTCS = Value
        End Set
    End Property

   

    Public Property FINCOP() As Double
        Get
            Return _FINCOP
        End Get
        Set(ByVal Value As Double)
            _FINCOP = Value
        End Set
    End Property

    Public Property FINCOP_S() As String
        Get
            Return _FINCOP_S
        End Get
        Set(ByVal value As String)
            _FINCOP_S = value
        End Set
    End Property

    Public Property FTRMOP() As Double
        Get
            Return _FTRMOP
        End Get
        Set(ByVal Value As Double)
            _FTRMOP = Value
        End Set
    End Property

    Public Property NPLNMT() As Double
        Get
            Return _NPLNMT
        End Get
        Set(ByVal Value As Double)
            _NPLNMT = Value
        End Set
    End Property

    Public Property SESTOP() As String
        Get
            Return _SESTOP
        End Get
        Set(ByVal Value As String)
            _SESTOP = Value
        End Set
    End Property

    Public Property SFCTOP() As String
        Get
            Return _SFCTOP
        End Get
        Set(ByVal Value As String)
            _SFCTOP = Value
        End Set
    End Property

    Public Property CTPDCF() As Double
        Get
            Return _CTPDCF
        End Get
        Set(ByVal Value As Double)
            _CTPDCF = Value
        End Set
    End Property

    Public Property NDCMFC() As Double
        Get
            Return _NDCMFC
        End Get
        Set(ByVal Value As Double)
            _NDCMFC = Value
        End Set
    End Property

  

    Public Property TRFSRC() As String
        Get
            Return _TRFSRC
        End Get
        Set(ByVal Value As String)
            _TRFSRC = Value
        End Set
    End Property

  


    Public Property VMRCDR() As Double
        Get
            Return _VMRCDR
        End Get
        Set(ByVal Value As Double)
            _VMRCDR = Value
        End Set
    End Property

    Public Property TRFMRC() As String
        Get
            Return _TRFMRC
        End Get
        Set(ByVal Value As String)
            _TRFMRC = Value
        End Set
    End Property

    Public Property NINFOP() As Double
        Get
            Return _NINFOP
        End Get
        Set(ByVal Value As Double)
            _NINFOP = Value
        End Set
    End Property


    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal Value As Double)
            _CPLNDV = Value
        End Set
    End Property

    Public Property NVJES() As Double
        Get
            Return _NVJES
        End Get
        Set(ByVal Value As Double)
            _NVJES = Value
        End Set
    End Property

    Public Property CVPRCN() As String
        Get
            Return _CVPRCN
        End Get
        Set(ByVal Value As String)
            _CVPRCN = Value
        End Set
    End Property

    Public Property SCNTR() As String
        Get
            Return _SCNTR
        End Get
        Set(ByVal Value As String)
            _SCNTR = Value
        End Set
    End Property

    Public Property SORGMV() As String
        Get
            Return _SORGMV
        End Get
        Set(ByVal Value As String)
            _SORGMV = Value
        End Set
    End Property

    Public Property NDCORM() As Double
        Get
            Return _NDCORM
        End Get
        Set(ByVal Value As Double)
            _NDCORM = Value
        End Set
    End Property

    Public Property TNMBRM() As String
        Get
            Return _TNMBRM
        End Get
        Set(ByVal Value As String)
            _TNMBRM = Value
        End Set
    End Property

    Public Property TDRCRM() As String
        Get
            Return _TDRCRM
        End Get
        Set(ByVal Value As String)
            _TDRCRM = Value
        End Set
    End Property

    Public Property TPDCIR() As String
        Get
            Return _TPDCIR
        End Get
        Set(ByVal Value As String)
            _TPDCIR = Value
        End Set
    End Property

    Public Property NRUCRM() As Double
        Get
            Return _NRUCRM
        End Get
        Set(ByVal Value As Double)
            _NRUCRM = Value
        End Set
    End Property

    Public Property TNMBCN() As String
        Get
            Return _TNMBCN
        End Get
        Set(ByVal Value As String)
            _TNMBCN = Value
        End Set
    End Property

    Public Property TDRCNS() As String
        Get
            Return _TDRCNS
        End Get
        Set(ByVal Value As String)
            _TDRCNS = Value
        End Set
    End Property

    Public Property TPDCIC() As String
        Get
            Return _TPDCIC
        End Get
        Set(ByVal Value As String)
            _TPDCIC = Value
        End Set
    End Property

    Public Property NRUCCN() As Double
        Get
            Return _NRUCCN
        End Get
        Set(ByVal Value As Double)
            _NRUCCN = Value
        End Set
    End Property

    Public Property SINDPS() As String
        Get
            Return _SINDPS
        End Get
        Set(ByVal Value As String)
            _SINDPS = Value
        End Set
    End Property

    Public Property CCNCST() As Double
        Get
            Return _CCNCST
        End Get
        Set(ByVal Value As Double)
            _CCNCST = Value
        End Set
    End Property

    Public Property ITPCMT() As Double
        Get
            Return _ITPCMT
        End Get
        Set(ByVal Value As Double)
            _ITPCMT = Value
        End Set
    End Property

    Public Property NPRCRG() As Double
        Get
            Return _NPRCRG
        End Get
        Set(ByVal Value As Double)
            _NPRCRG = Value
        End Set
    End Property

    Public Property QCNTRC() As Double
        Get
            Return _QCNTRC
        End Get
        Set(ByVal Value As Double)
            _QCNTRC = Value
        End Set
    End Property

    Public Property QPSORC() As Double
        Get
            Return _QPSORC
        End Get
        Set(ByVal Value As Double)
            _QPSORC = Value
        End Set
    End Property

    Public Property NBKNCN() As String
        Get
            Return _NBKNCN
        End Get
        Set(ByVal Value As String)
            _NBKNCN = Value
        End Set
    End Property

    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal Value As String)
            _CUSCRT = Value
        End Set
    End Property

    Public Property FCHCRT() As Double
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As Double)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As Double
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As Double)
            _HRACRT = Value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal Value As String)
            _NTRMCR = Value
        End Set
    End Property

    Public Property SESTGU() As String
        Get
            Return _SESTGU
        End Get
        Set(ByVal Value As String)
            _SESTGU = Value
        End Set
    End Property

    Public Property NLQDCN() As Double
        Get
            Return _NLQDCN
        End Get
        Set(ByVal Value As Double)
            _NLQDCN = Value
        End Set
    End Property

    Public Property CLCLOR() As String
        Get
            Return _CLCLOR
        End Get
        Set(ByVal Value As String)
            _CLCLOR = Value
        End Set
    End Property

    Public Property CLCLDS() As String
        Get
            Return _CLCLDS
        End Get
        Set(ByVal Value As String)
            _CLCLDS = Value
        End Set
    End Property

    Public Property NGUIRF() As Double
        Get
            Return _NGUIRF
        End Get
        Set(ByVal Value As Double)
            _NGUIRF = Value
        End Set
    End Property

    Public Property FGUIRF() As Double
        Get
            Return _FGUIRF
        End Get
        Set(ByVal Value As Double)
            _FGUIRF = Value
        End Set
    End Property

    Public Property FSLDCM() As Double
        Get
            Return _FSLDCM
        End Get
        Set(ByVal Value As Double)
            _FSLDCM = Value
        End Set
    End Property

    Public Property FLLGCM() As Double
        Get
            Return _FLLGCM
        End Get
        Set(ByVal Value As Double)
            _FLLGCM = Value
        End Set
    End Property


    Public Property COUNT() As Double
        Get
            Return _COUNT
        End Get
        Set(ByVal Value As Double)
            _COUNT = Value
        End Set
    End Property

    Public Property TCMPCF() As String
        Get
            Return _TCMPCF
        End Get
        Set(ByVal Value As String)
            _TCMPCF = Value
        End Set
    End Property

    Public Property TPLNTA() As String
        Get
            Return _TPLNTA
        End Get
        Set(ByVal Value As String)
            _TPLNTA = Value
        End Set
    End Property


    Public Property QKMREC() As Double
        Get
            Return _QKMREC
        End Get
        Set(ByVal Value As Double)
            _QKMREC = Value
        End Set
    End Property



    Public Property NKMRCR() As Double
        Get
            Return _NKMRCR
        End Get
        Set(ByVal Value As Double)
            _NKMRCR = Value
        End Set
    End Property

    Public Property QGLNCM() As Double
        Get
            Return _QGLNCM
        End Get
        Set(ByVal Value As Double)
            _QGLNCM = Value
        End Set
    End Property

    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal Value As String)
            _NPLCUN = Value
        End Set
    End Property
    '_NCSOTR

    Public Property NCSOTR() As Double
        Get
            Return _NCSOTR
        End Get
        Set(ByVal Value As Double)
            _NCSOTR = Value
        End Set
    End Property

    Public Property CONDUCTOR() As String
        Get
            Return _CONDUCTOR
        End Get
        Set(ByVal Value As String)
            _CONDUCTOR = Value
        End Set
    End Property

    Public Property NGUIRM() As Double
        Get
            Return _NGUIRM
        End Get
        Set(ByVal Value As Double)
            _NGUIRM = Value
        End Set
    End Property

    Public Property FEMVLH() As Double
        Get
            Return _FEMVLH
        End Get
        Set(ByVal Value As Double)
            _FEMVLH = Value
        End Set
    End Property

    Public Property PMRCMC() As Double
        Get
            Return _PMRCMC
        End Get
        Set(ByVal Value As Double)
            _PMRCMC = Value
        End Set
    End Property

    Public Property CTPOVJ() As String
        Get
            Return _CTPOVJ
        End Get
        Set(ByVal Value As String)
            _CTPOVJ = Value
        End Set
    End Property

    Public Property NVLGRF() As Double
        Get
            Return _NVLGRF
        End Get
        Set(ByVal Value As Double)
            _NVLGRF = Value
        End Set
    End Property

    REM ECM-HUNDRED-INICIO
    Public Property CDSCSP() As String
        Get
            Return _CDSCSP
        End Get
        Set(ByVal Value As String)
            _CDSCSP = Value
        End Set
    End Property

    Public Property TDSCSP() As String
        Get
            Return _TDSCSP
        End Get
        Set(ByVal Value As String)
            _TDSCSP = Value
        End Set
    End Property

    Public Property CDSCSP_TDSCSP() As String
        Get
            Return _CDSCSP_TDSCSP
        End Get
        Set(ByVal Value As String)
            _CDSCSP_TDSCSP = Value
        End Set
    End Property
    REM ECM-HUNDRED-FIN

    ''<AHM_VINTERNA>
    Private _CECO_OPE As String = ""
    Public Property CECO_OPE() As String
        Get
            Return _CECO_OPE
        End Get
        Set(ByVal Value As String)
            _CECO_OPE = Value
        End Set
    End Property

    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Public Property PLANTA() As String
        Get
            Return _PLANTA
        End Get
        Set(ByVal Value As String)
            _PLANTA = Value
        End Set
    End Property

    Public Property PLANTA_FACT() As String
        Get
            Return _PLANTA_FACT
        End Get
        Set(ByVal Value As String)
            _PLANTA_FACT = Value
        End Set
    End Property


    Public Property CEBEO() As String
        Get
            Return _CEBEO
        End Get
        Set(ByVal Value As String)
            _CEBEO = Value
        End Set
    End Property
    Public Property CECOD() As String
        Get
            Return _CECOD
        End Get
        Set(ByVal Value As String)
            _CECOD = Value
        End Set
    End Property

    Public Property DOCVLR() As String
        Get
            Return _DOCVLR
        End Get
        Set(ByVal Value As String)
            _DOCVLR = Value
        End Set
    End Property



    Public Property SEGVLR() As String
        Get
            Return _SEGVLR
        End Get
        Set(ByVal Value As String)
            _SEGVLR = Value
        End Set
    End Property
    Public Property SEGVLR_DESC() As String
        Get
            Return _SEGVLR_DESC
        End Get
        Set(ByVal Value As String)
            _SEGVLR_DESC = Value
        End Set
    End Property
    Public Property NROVLR() As Decimal
        Get
            Return _NROVLR
        End Get
        Set(ByVal Value As Decimal)
            _NROVLR = Value
        End Set
    End Property

    Public Property OP_FACTURABLE() As String
        Get
            Return _OP_FACTURABLE
        End Get
        Set(ByVal Value As String)
            _OP_FACTURABLE = Value
        End Set
    End Property

    Public Property POR_VLR() As String
        Get
            Return _POR_VLR
        End Get
        Set(ByVal Value As String)
            _POR_VLR = Value
        End Set
    End Property

    '
    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
#End Region

#Region "Atributo"
          
            Private _FGUITR_S As String = ""
            Private _NMNFCR As Int64 = 0

            Private _TCMTRT As String = ""
            
            Private _TDSTRT As String = ""
            Private _QCNDTG As Double = 0
            Private _ISRVGU As Double = 0
            Private _CMNDGU As String = ""
            Private _TOTSER As Double = 0
            Private _PBRTOR As Double = 0
            Private _QBLORG As Double = 0
            Private _QKLMRC As Double = 0


            Private _NRUCFC As Int64 = 0
            Private _NLBTEL As Int64 = 0
           
            Private _TCMPFC As String = ""
            Private _TDRCFC As String = ""
            
            Private _SRPTRM As String = ""

            Private _CMNLQT As String = ""
            Private _TSGNMN_S As String = ""
            Private _TSGNMN_L As String = ""
            Private _CUNDSR As String = ""
            Private _ILQDTR As Double = 0
            Private _VLRFDT As Double = 0
            Private _TCMTRF As String = ""
            Private _IVNTA As Double = 0
            Private _CPRCN1 As String = ""
            Private _NSRCN1 As String = ""
            Private _TMNCNT As String = ""
            Private _CPRCN2 As String = ""
            Private _NSRCN2 As String = ""
            Private _TMNCN1 As String = ""
            Private _TDRCPL As String = ""

            Private _PIGVA As Double = 0
            Private _CTIGVA As Integer = 0
            Private _INDICE As String = ""

            Private _TC_COBRAR As Double = 0
            Private _TC_PAGAR As Double = 0

            Private _SFCTTR As String = ""
            Private _SLQDTR As String = ""

            Private _QCNDLG As Double = 0
            Private _CUNDTR As String = ""
            Private _CSTNDT As Double = 0
            Private _TCNFVH As String = ""
            Private _PESOL As Double = 0
            Private _PBRDST As Double = 0
           
            Private _TCMCRA As String = ""

            
            Private _FDCPRF_S As String = ""
           
            Private _ORGVTA As String = ""

            
            Private _FEC_INI As Integer = 0
            Private _FEC_FIN As Integer = 0

            Private _CMNDA_COBRAR As Integer = 0
    Private _CMNDA_PAGAR As Integer = 0
            Private _MONEDA_COBRAR As String = ""
            Private _MONEDA_PAGAR As String = ""


            Private _NRUCTR_LIQ As String = ""
            Private _TCMTRT_LIQ As String = ""

            Private _VLR_SOL As Decimal = 0
            Private _VLR_DOL As Decimal = 0
            Private _VLR_CANT As Decimal = 0
            Private _EN_VLR As String = ""
            Private _ACCION As String = ""

            Private _TPDCPE As String = ""
            Private _DCCLNT As String = ""
            Private _SBCLNT As String = ""
            Private _TIPODOC As String = ""


#End Region

#Region "Properties"

            Public Property CMNDA_PAGAR() As Integer
                Get
                    Return _CMNDA_PAGAR
                End Get
                Set(ByVal value As Integer)
                    _CMNDA_PAGAR = value
                End Set
            End Property

            Public Property CMNDA_COBRAR() As Integer
                Get
                    Return _CMNDA_COBRAR
                End Get
                Set(ByVal value As Integer)
                    _CMNDA_COBRAR = value
                End Set
            End Property

            Public Property MONEDA_PAGAR() As String
                Get
                    Return _MONEDA_PAGAR
                End Get
                Set(ByVal value As String)
                    _MONEDA_PAGAR = value
                End Set
            End Property


            Public Property MONEDA_COBRAR() As String
                Get
                    Return _MONEDA_COBRAR
                End Get
                Set(ByVal value As String)
                    _MONEDA_COBRAR = value
                End Set
            End Property


            Public Property SFCTTR() As String
                Get
                    Return _SFCTTR
                End Get
                Set(ByVal value As String)
                    _SFCTTR = value
                End Set
            End Property

            Public Property SLQDTR() As String
                Get
                    Return _SLQDTR
                End Get
                Set(ByVal value As String)
                    _SLQDTR = value
                End Set
            End Property


            Public Property TC_COBRAR() As Decimal
                Get
                    Return _TC_COBRAR
                End Get
                Set(ByVal value As Decimal)
                    _TC_COBRAR = value
                End Set
            End Property

            Public Property TC_PAGAR() As Decimal
                Get
                    Return _TC_PAGAR
                End Get
                Set(ByVal value As Decimal)
                    _TC_PAGAR = value
                End Set
            End Property

            Public Property FEC_INI() As Integer
                Get
                    Return _FEC_INI
                End Get
                Set(ByVal value As Integer)
                    _FEC_INI = value
                End Set
            End Property

            Public Property FEC_FIN() As Integer
                Get
                    Return _FEC_FIN
                End Get
                Set(ByVal value As Integer)
                    _FEC_FIN = value
                End Set
            End Property

            Public Property CRGVTA() As String
                Get
                    Return _CRGVTA
                End Get
                Set(ByVal value As String)
                    _CRGVTA = value
                End Set
            End Property

            Public Property TCRVTA() As String
                Get
                    Return _TCRVTA
                End Get
                Set(ByVal value As String)
                    _TCRVTA = value
                End Set
            End Property

            Public Property FULTAC() As String
                Get
                    Return _FULTAC
                End Get
                Set(ByVal value As String)
                    _FULTAC = value
                End Set
            End Property

            Public Property HULTAC() As String
                Get
                    Return _HULTAC
                End Get
                Set(ByVal value As String)
                    _HULTAC = value
                End Set
            End Property

            Public Property CULUSA() As String
                Get
                    Return _CULUSA
                End Get
                Set(ByVal value As String)
                    _CULUSA = value
                End Set
            End Property

            Public Property NTRMNL() As String
                Get
                    Return _NTRMNL
                End Get
                Set(ByVal value As String)
                    _NTRMNL = value
                End Set
            End Property

            Public Property NPRLQD() As Int64
                Get
                    Return _NPRLQD
                End Get
                Set(ByVal value As Int64)
                    _NPRLQD = value
                End Set
            End Property

            Public Property IMPOCOS() As Decimal
                Get
                    Return _IMPOCOS
                End Get
                Set(ByVal value As Decimal)
                    _IMPOCOS = value
                End Set
            End Property

            Public Property IMPOCOD() As Decimal
                Get
                    Return _IMPOCOD
                End Get
                Set(ByVal value As Decimal)
                    _IMPOCOD = value
                End Set
            End Property

            Public Property NDCPRF() As Int64
                Get
                    Return _NDCPRF
                End Get
                Set(ByVal value As Int64)
                    _NDCPRF = value
                End Set
            End Property

            Public Property FDCPRF() As Int64
                Get
                    Return _FDCPRF
                End Get
                Set(ByVal value As Int64)
                    _FDCPRF = value
                End Set
            End Property

            Public Property FDCPRF_S() As String
                Get
                    Return _FDCPRF_S
                End Get
                Set(ByVal value As String)
                    _FDCPRF_S = value
                End Set
            End Property

            Public Property ORGVTA() As String
                Get
                    Return _ORGVTA
                End Get
                Set(ByVal value As String)
                    _ORGVTA = value
                End Set
            End Property


            Public Property CCMPN() As String
                Get
                    Return _CCMPN
                End Get
                Set(ByVal value As String)
                    _CCMPN = value
                End Set
            End Property

            Public Property CDVSN() As String
                Get
                    Return _CDVSN
                End Get
                Set(ByVal value As String)
                    _CDVSN = value
                End Set
            End Property

            Public Property NOPRCN() As Int64
                Get
                    Return _NOPRCN
                End Get
                Set(ByVal Value As Int64)
                    _NOPRCN = Value
                End Set
            End Property

            Public Property NGUITR() As Int64
                Get
                    Return _NGUITR
                End Get
                Set(ByVal Value As Int64)
                    _NGUITR = Value
                End Set
            End Property

            Public Property FGUITR() As Int64
                Get
                    Return _FGUITR
                End Get
                Set(ByVal Value As Int64)
                    _FGUITR = Value
                End Set
            End Property

            Public Property FGUITR_S() As String
                Get
                    Return _FGUITR_S
                End Get
                Set(ByVal Value As String)
                    _FGUITR_S = Value
                End Set
            End Property

            Public Property NMNFCR() As Int64
                Get
                    Return _NMNFCR
                End Get
                Set(ByVal Value As Int64)
                    _NMNFCR = Value
                End Set
            End Property

            Public Property CTRSPT() As Int64
                Get
                    Return _CTRSPT
                End Get
                Set(ByVal Value As Int64)
                    _CTRSPT = Value
                End Set
            End Property

            Public Property TCMTRT() As String
                Get
                    Return _TCMTRT
                End Get
                Set(ByVal Value As String)
                    _TCMTRT = Value
                End Set
            End Property

            Public Property NPLVHT() As String
                Get
                    Return _NPLVHT
                End Get
                Set(ByVal Value As String)
                    _NPLVHT = Value
                End Set
            End Property

            Public Property CBRCNT() As String
                Get
                    Return _CBRCNT
                End Get
                Set(ByVal Value As String)
                    _CBRCNT = Value
                End Set
            End Property

            Public Property TDSTRT() As String
                Get
                    Return _TDSTRT
                End Get
                Set(ByVal Value As String)
                    _TDSTRT = Value
                End Set
            End Property

            Public Property QCNDTG() As Double
                Get
                    Return _QCNDTG
                End Get
                Set(ByVal Value As Double)
                    _QCNDTG = Value
                End Set
            End Property

            Public Property ISRVGU() As Double
                Get
                    Return _ISRVGU
                End Get
                Set(ByVal Value As Double)
                    _ISRVGU = Value
                End Set
            End Property

            Public Property CMNDGU() As String
                Get
                    Return _CMNDGU
                End Get
                Set(ByVal Value As String)
                    _CMNDGU = Value
                End Set
            End Property

            Public Property CMNLQT() As String
                Get
                    Return _CMNLQT
                End Get
                Set(ByVal Value As String)
                    _CMNLQT = Value
                End Set
            End Property

            Public Property TOTSER() As Double
                Get
                    Return _TOTSER
                End Get
                Set(ByVal Value As Double)
                    _TOTSER = Value
                End Set
            End Property

            Public Property PBRTOR() As Double
                Get
                    Return _PBRTOR
                End Get
                Set(ByVal Value As Double)
                    _PBRTOR = Value
                End Set
            End Property

            Public Property QBLORG() As Double
                Get
                    Return _QBLORG
                End Get
                Set(ByVal Value As Double)
                    _QBLORG = Value
                End Set
            End Property

            Public Property QKLMRC() As Double
                Get
                    Return _QKLMRC
                End Get
                Set(ByVal Value As Double)
                    _QKLMRC = Value
                End Set
            End Property

            Public Property NORSRT() As Int64
                Get
                    Return _NORSRT
                End Get
                Set(ByVal Value As Int64)
                    _NORSRT = Value
                End Set
            End Property

            Public Property CCLNT() As Int64
                Get
                    Return _CCLNT
                End Get
                Set(ByVal Value As Int64)
                    _CCLNT = Value
                End Set
            End Property

            Public Property TCMPCL() As String
                Get
                    Return _TCMPCL
                End Get
                Set(ByVal Value As String)
                    _TCMPCL = Value
                End Set
            End Property

            Public Property CCLNFC() As Int64
                Get
                    Return _CCLNFC
                End Get
                Set(ByVal Value As Int64)
                    _CCLNFC = Value
                End Set
            End Property

            Public Property TCMPFC() As String
                Get
                    Return _TCMPFC
                End Get
                Set(ByVal Value As String)
                    _TCMPFC = Value
                End Set
            End Property

            Public Property TDRCFC() As String
                Get
                    Return _TDRCFC
                End Get
                Set(ByVal Value As String)
                    _TDRCFC = Value
                End Set
            End Property

            Public Property CMRCDR() As String
                Get
                    Return _CMRCDR
                End Get
                Set(ByVal Value As String)
                    _CMRCDR = Value
                End Set
            End Property

            Public Property TCMRCD() As String
                Get
                    Return _TCMRCD
                End Get
                Set(ByVal Value As String)
                    _TCMRCD = Value
                End Set
            End Property

            Public Property CTPOSR() As String
                Get
                    Return _CTPOSR
                End Get
                Set(ByVal Value As String)
                    _CTPOSR = Value
                End Set
            End Property

            Public Property TCMTPS() As String
                Get
                    Return _TCMTPS
                End Get
                Set(ByVal Value As String)
                    _TCMTPS = Value
                End Set
            End Property

            Public Property CTPSBS() As String
                Get
                    Return _CTPSBS
                End Get
                Set(ByVal Value As String)
                    _CTPSBS = Value
                End Set
            End Property

            Public Property TCMSBS() As String
                Get
                    Return _TCMSBS
                End Get
                Set(ByVal Value As String)
                    _TCMSBS = Value
                End Set
            End Property

            Public Property SRPTRM() As String
                Get
                    Return _SRPTRM
                End Get
                Set(ByVal Value As String)
                    _SRPTRM = Value
                End Set
            End Property

            Public Property RUTA() As String
                Get
                    Return _RUTA
                End Get
                Set(ByVal Value As String)
                    _RUTA = Value
                End Set
            End Property

            Public Property TSGNMN_S() As String
                Get
                    Return _TSGNMN_S
                End Get
                Set(ByVal Value As String)
                    _TSGNMN_S = Value
                End Set
            End Property

            Public Property TSGNMN_L() As String
                Get
                    Return _TSGNMN_L
                End Get
                Set(ByVal Value As String)
                    _TSGNMN_L = Value
                End Set
            End Property

            Public Property CUNDSR() As String
                Get
                    Return _CUNDSR
                End Get
                Set(ByVal Value As String)
                    _CUNDSR = Value
                End Set
            End Property

            Public Property ILQDTR() As Double
                Get
                    Return _ILQDTR
                End Get
                Set(ByVal Value As Double)
                    _ILQDTR = Value
                End Set
            End Property

            Public Property VLRFDT() As Double
                Get
                    Return _VLRFDT
                End Get
                Set(ByVal Value As Double)
                    _VLRFDT = Value
                End Set
            End Property

            Public Property TCMTRF() As String
                Get
                    Return _TCMTRF
                End Get
                Set(ByVal Value As String)
                    _TCMTRF = Value
                End Set
            End Property

            Public Property NRUCFC() As Int64
                Get
                    Return _NRUCFC
                End Get
                Set(ByVal Value As Int64)
                    _NRUCFC = Value
                End Set
            End Property

            Public Property NLBTEL() As Int64
                Get
                    Return _NLBTEL
                End Get
                Set(ByVal Value As Int64)
                    _NLBTEL = Value
                End Set
            End Property

            Public Property IVNTA() As Double
                Get
                    Return _IVNTA
                End Get
                Set(ByVal Value As Double)
                    _IVNTA = Value
                End Set
            End Property

            Public Property CPRCN1() As String
                Get
                    Return _CPRCN1
                End Get
                Set(ByVal Value As String)
                    _CPRCN1 = Value
                End Set
            End Property

            Public Property NSRCN1() As String
                Get
                    Return _NSRCN1
                End Get
                Set(ByVal Value As String)
                    _NSRCN1 = Value
                End Set
            End Property

            Public Property TMNCNT() As String
                Get
                    Return _TMNCNT
                End Get
                Set(ByVal Value As String)
                    _TMNCNT = Value
                End Set
            End Property

            Public Property CPRCN2() As String
                Get
                    Return _CPRCN2
                End Get
                Set(ByVal Value As String)
                    _CPRCN2 = Value
                End Set
            End Property

            Public Property NSRCN2() As String
                Get
                    Return _NSRCN2
                End Get
                Set(ByVal Value As String)
                    _NSRCN2 = Value
                End Set
            End Property

            Public Property TMNCN1() As String
                Get
                    Return _TMNCN1
                End Get
                Set(ByVal Value As String)
                    _TMNCN1 = Value
                End Set
            End Property

            Public Property TDRCPL() As String
                Get
                    Return _TDRCPL
                End Get
                Set(ByVal Value As String)
                    _TDRCPL = Value
                End Set
            End Property

            Public Property CPLNCL() As Double
                Get
                    Return _CPLNCL
                End Get
                Set(ByVal Value As Double)
                    _CPLNCL = Value
                End Set
            End Property

            Public Property PIGVA() As Double
                Get
                    Return _PIGVA
                End Get
                Set(ByVal Value As Double)
                    _PIGVA = Value
                End Set
            End Property

            Public Property CTIGVA() As Integer
                Get
                    Return _CTIGVA
                End Get
                Set(ByVal Value As Integer)
                    _CTIGVA = Value
                End Set
            End Property

            Public Property INDICE() As String
                Get
                    Return _INDICE
                End Get
                Set(ByVal Value As String)
                    _INDICE = Value
                End Set
            End Property

            Public Property QCNDLG() As Double
                Get
                    Return _QCNDLG
                End Get
                Set(ByVal Value As Double)
                    _QCNDLG = Value
                End Set
            End Property

            Public Property CUNDTR() As String
                Get
                    Return _CUNDTR
                End Get
                Set(ByVal Value As String)
                    _CUNDTR = Value
                End Set
            End Property

            Public Property CSTNDT() As Double
                Get
                    Return _CSTNDT
                End Get
                Set(ByVal Value As Double)
                    _CSTNDT = Value
                End Set
            End Property

            Public Property TCNFVH() As String
                Get
                    Return _TCNFVH
                End Get
                Set(ByVal Value As String)
                    _TCNFVH = Value
                End Set
            End Property

            Public Property PESOL() As Double
                Get
                    Return _PESOL
                End Get
                Set(ByVal Value As Double)
                    _PESOL = Value
                End Set
            End Property

            Public Property PBRDST() As Double
                Get
                    Return _PBRDST
                End Get
                Set(ByVal Value As Double)
                    _PBRDST = Value
                End Set
            End Property

            Public Property PMRCDR() As Double
                Get
                    Return _PMRCDR
                End Get
                Set(ByVal Value As Double)
                    _PMRCDR = Value
                End Set
            End Property

            Public Property QMRCDR() As Double
                Get
                    Return _QMRCDR
                End Get
                Set(ByVal Value As Double)
                    _QMRCDR = Value
                End Set
            End Property

            Public Property TCMCRA() As String
                Get
                    Return _TCMCRA
                End Get
                Set(ByVal Value As String)
                    _TCMCRA = Value
                End Set
            End Property

            Public Property NRUCTR() As Double
                Get
                    Return _NRUCTR
                End Get
                Set(ByVal Value As Double)
                    _NRUCTR = Value
                End Set
            End Property


            Public Property NRUCTR_LIQ() As String
                Get
                    Return _NRUCTR_LIQ
                End Get
                Set(ByVal Value As String)
                    _NRUCTR_LIQ = Value
                End Set
            End Property
            Public Property TCMTRT_LIQ() As String
                Get
                    Return _TCMTRT_LIQ
                End Get
                Set(ByVal Value As String)
                    _TCMTRT_LIQ = Value
                End Set
            End Property

            Public Property VLR_SOL As Decimal
                Get
                    Return _VLR_SOL
                End Get
                Set(ByVal Value As Decimal)
                    _VLR_SOL = Value
                End Set
            End Property
            Public Property VLR_DOL As Decimal
                Get
                    Return _VLR_DOL
                End Get
                Set(ByVal Value As Decimal)
                    _VLR_DOL = Value
                End Set
            End Property
            Public Property VLR_CANT As Decimal
                Get
                    Return _VLR_CANT
                End Get
                Set(ByVal Value As Decimal)
                    _VLR_CANT = Value
                End Set
            End Property

            Public Property EN_VLR() As String
                Get
                    Return _EN_VLR
                End Get
                Set(ByVal Value As String)
                    _EN_VLR = Value
                End Set
            End Property

            Public Property ACCION() As String
                Get
                    Return _ACCION
                End Get
                Set(ByVal Value As String)
                    _ACCION = Value
                End Set
            End Property

            Public Property TPDCPE() As String
                Get
                    Return _TPDCPE
                End Get
                Set(ByVal Value As String)
                    _TPDCPE = Value
                End Set
            End Property
            Public Property DCCLNT() As String
                Get
                    Return _DCCLNT
                End Get
                Set(ByVal Value As String)
                    _DCCLNT = Value
                End Set
            End Property
            Public Property SBCLNT() As String
                Get
                    Return _SBCLNT
                End Get
                Set(ByVal Value As String)
                    _SBCLNT = Value
                End Set
            End Property

            Public Property TIPODOC() As String
                Get
                    Return _TIPODOC
                End Get
                Set(ByVal Value As String)
                    _TIPODOC = Value
                End Set
            End Property



#End Region
    Public PSCCMPN As String = ""
    Public PNNRCTRL As Decimal = 0 'NRLQD
    Public PSTIPOPL As String = ""

    Private _NPRLCF As Decimal
    Public Property NPRLCF() As Decimal
        Get
            Return _NPRLCF
        End Get
        Set(ByVal value As Decimal)
            _NPRLCF = value
        End Set
    End Property

    Private _NSECFC As Decimal
    Public Property NSECFC() As Decimal
        Get
            Return _NSECFC
        End Get
        Set(ByVal value As Decimal)
            _NSECFC = value
        End Set
    End Property

    Private _FECINI As Decimal
    Public Property FECINI() As Decimal
        Get
            Return _FECINI
        End Get
        Set(ByVal value As Decimal)
            _FECINI = value
        End Set
    End Property
    Private _FECFIN As Decimal
    Public Property FECFIN() As Decimal
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As Decimal)
            _FECFIN = value
        End Set
    End Property

    Private _FLGFAC As String
    Public Property FLGFAC() As String
        Get
            Return _FLGFAC
        End Get
        Set(ByVal value As String)
            _FLGFAC = value
        End Set
    End Property

    Private _TIPO_PLANTA As Decimal
    Public Property TIPO_PLANTA() As Decimal
        Get
            Return _TIPO_PLANTA
        End Get
        Set(ByVal value As Decimal)
            _TIPO_PLANTA = value
        End Set
    End Property
    Private _TLUGEN As String
    Public Property TLUGEN() As String
        Get
            Return _TLUGEN
        End Get
        Set(ByVal value As String)
            _TLUGEN = value
        End Set
    End Property

    'NPRLCF)
    '.NSECFC)
    'FECINI)
    'FECFIN)

    'FLGFAC)
    'icio.TIPO_PLANTA)
    'TLUGEN)
        End Class






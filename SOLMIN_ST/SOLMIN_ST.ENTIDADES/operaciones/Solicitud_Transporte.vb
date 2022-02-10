Namespace Operaciones

  Public Class Solicitud_Transporte

#Region "Atributo"

    Private _NCSOTR As String = ""
    Private _NCRRSR As Int32 = 0
    Private _NORSRT As String = ""
    Private _FECOST As String = ""
    Private _HRAOTR As String = ""
    Private _CCLNT As String = ""
    Private _CTPOSR As String = ""
    Private _CUNDVH As String = ""
    Private _CMRCDR As String = ""
    Private _TCMRCD As String = ""
    Private _QMRCDR As String = ""
    Private _CUNDMD As String = ""
    Private _CUNDMD_C As String = ""
    Private _QATNDR As String = ""
    Private _QSLCIT As String = ""
    Private _QATNAN As String = ""
    Private _FINCRG As String = ""
    Private _HINCIN As String = ""
    Private _FENTCL As String = ""
    Private _HRAENT As String = ""
    Private _CLCLOR_C As Int32 = 0
    Private _CLCLOR As String = ""
    Private _TDRCOR As String = ""
    Private _CLCLDS_C As Int32 = 0
    Private _CLCLDS As String = ""
    Private _TDRENT As String = ""
    Private _SESSLC As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As String = ""
    Private _HRACRT As String = ""
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As String = ""
    Private _HULTAC As String = ""
    Private _NTRMNL As String = ""
    Private _TCMPCL As String = ""
    Private _TOBS As String = ""
    Private _CLCLOR_CLCLDS As String = "" 'ruta
    Private _CANTOP As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _SFCRTV As String = ""
    Private _NMOPMM As Double = 0
    Private _NCRRRT As Double = 0
    Private _NMOPRP As Double = 0
    Private _CMEDTR As Double = 0
    Private _TNMMDT As String = ""
    Private _NPLCUN As String = ""
    Private _CBRCNT As String = ""
    Private _CBRCND As String = ""
    Private _NOPRCN As Double = 0
    Private _NPLNMT As Double = 0
    Private _NORINS As Double = 0
    Private _SEGUIMIENTO As String = ""
    Private _NCOREG As Int64 = 0
    Private _NGSGWP As String = ""
    Private _CCTCSC As String = ""
        Private _FE_INI As String = ""
        Private _HR_INI As String = ""
        Private _HR_FIN As String = ""
    Private _FE_FIN As String = ""
    Private _NDCMFC As Int64 = 0
    Private _NGUITR As Int64 = 0D
    Private _NGUIRM As Int64 = 0D
    Private _PSCTRMNC As String = ""
    Private _PSNGUIRM As String = ""
    Private _TRFRN As String = ""

    Private _NDCPRF As Int64 = 0D
    Private _NPRLQD As Int64 = 0D
    Private _CTRSPT As Int64 = 0D
        Private _CTPOVJ As String = ""
        Private _SPRSTR As String = ""

        Private _QANPRG As Double = 0
        Private _NPLNJT As Double = 0
        Private _NCRRPL As Double = 0

        Private _NCTZCN As String = ""

        Private _CUBORI As Decimal = 0
        Private _UBIGEO_O As String = ""
        Private _CUBDES As Decimal = 0
        Private _UBIGEO_D As String = ""

        Private _CLCLOR_D As String = ""
        Private _CLCLDS_D As String = ""
        Private _SESREQ As String = ""

        Private _STPRCS As String = ""
        Private _NPLRCS As String = ""
        Private _NRUCTR As String = ""
        Private _TCMTRT As String = ""

        'ECM-HUNDRED-INICIO
        Private _TDSCSP As String = ""
        Private _CCLNFC As String = ""
        Private _CDSCSP As String = ""
        Private _CDSCSP_CEBE As String = ""
        Private _TDSCSP_CEBE As String = ""
        Private _CDDRSP As String = ""
        'ECM-HUNDRED-FIN
        Private _CARERS As String = ""

        Private _NMRGIM As Decimal = 0
        Private _NMRGIM_IMG As String = ""


        Private _TPSOTR As String = ""
        Private _HATNSR As Decimal = 0

        Private _HATNSR_S As String = ""
        Private _FATNSR_S As String = ""

        Private _ANULAR As String = ""

        Private _TPSOTR_DESC As String = ""

#End Region

#Region "Properties"

        Private _UNIDADES As Decimal = 0
        Public Property UNIDADES() As Decimal
            Get
                Return _UNIDADES
            End Get
            Set(ByVal value As Decimal)
                _UNIDADES = value
            End Set
        End Property



        Public Property CUBDES() As Decimal
            Get
                Return _CUBDES
            End Get
            Set(ByVal Value As Decimal)
                _CUBDES = Value
            End Set
        End Property

        Public Property CUBORI() As Decimal
            Get
                Return _CUBORI
            End Get
            Set(ByVal Value As Decimal)
                _CUBORI = Value
            End Set
        End Property

        Public Property UBIGEO_D() As String
            Get
                Return _UBIGEO_D
            End Get
            Set(ByVal Value As String)
                _UBIGEO_D = Value
            End Set
        End Property


        Public Property UBIGEO_O() As String
            Get
                Return _UBIGEO_O
            End Get
            Set(ByVal Value As String)
                _UBIGEO_O = Value
            End Set
        End Property

        Public Property NCTZCN() As String
            Get
                Return _NCTZCN
            End Get
            Set(ByVal Value As String)
                _NCTZCN = Value
            End Set
        End Property

        Public Property NDCPRF() As Int64
            Get
                Return _NDCPRF
            End Get
            Set(ByVal Value As Int64)
                _NDCPRF = Value
            End Set
        End Property
        Public Property NPRLQD() As Int64
            Get
                Return _NPRLQD
            End Get
            Set(ByVal Value As Int64)
                _NPRLQD = Value
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

        Public Property PSCTRMNC() As String
            Get
                Return _PSCTRMNC
            End Get
            Set(ByVal Value As String)
                _PSCTRMNC = Value
            End Set
        End Property
        Public Property PSNGUIRM() As String
            Get
                Return _PSNGUIRM
            End Get
            Set(ByVal Value As String)
                _PSNGUIRM = Value
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
        Public Property NGUIRM() As Int64
            Get
                Return _NGUIRM
            End Get
            Set(ByVal Value As Int64)
                _NGUIRM = Value
            End Set
        End Property
        Public Property NDCMFC() As Int64
            Get
                Return _NDCMFC
            End Get
            Set(ByVal Value As Int64)
                _NDCMFC = Value
            End Set
        End Property

        Public Property FE_INI() As Double
            Get
                Return _FE_INI
            End Get
            Set(ByVal Value As Double)
                _FE_INI = Value
            End Set
        End Property

        Public Property FE_FIN() As Double
            Get
                Return _FE_FIN
            End Get
            Set(ByVal Value As Double)
                _FE_FIN = Value
            End Set
        End Property

        Public Property HR_FIN() As Double
            Get
                Return _HR_FIN
            End Get
            Set(ByVal Value As Double)
                _HR_FIN = Value
            End Set
        End Property

        Public Property HR_INI() As Double
            Get
                Return _HR_INI
            End Get
            Set(ByVal Value As Double)
                _HR_INI = Value
            End Set
        End Property

        Public Property NOPRCN() As Double
            Get
                Return _NOPRCN
            End Get
            Set(ByVal Value As Double)
                _NOPRCN = Value
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


        Public Property NORINS() As Double
            Get
                Return _NORINS
            End Get
            Set(ByVal Value As Double)
                _NORINS = Value
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

        Public Property CBRCNT() As String
            Get
                Return _CBRCNT
            End Get
            Set(ByVal Value As String)
                _CBRCNT = Value
            End Set
        End Property

        Public Property CBRCND() As String
            Get
                Return _CBRCND
            End Get
            Set(ByVal Value As String)
                _CBRCND = Value
            End Set
        End Property

        Public Property TNMMDT() As String
            Get
                Return _TNMMDT
            End Get
            Set(ByVal Value As String)
                _TNMMDT = Value
            End Set
        End Property

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal Value As String)
                _CCMPN = Value
            End Set
        End Property

        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal Value As String)
                _CDVSN = Value
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
        Private _CPLNDV_S As String
        Public Property CPLNDV_S() As String
            Get
                Return _CPLNDV_S
            End Get
            Set(ByVal Value As String)
                _CPLNDV_S = Value
            End Set
        End Property


        Public Property CANTOP() As Double
            Get
                Return _CANTOP
            End Get
            Set(ByVal value As Double)
                _CANTOP = value
            End Set
        End Property

        Public Property CLCLOR_CLCLDS() As String
            Get
                Return Me._CLCLOR_CLCLDS
            End Get
            Set(ByVal value As String)
                Me._CLCLOR_CLCLDS = value
            End Set
        End Property

        Public Property NORSRT() As String
            Get
                Return Me._NORSRT
            End Get
            Set(ByVal value As String)
                Me._NORSRT = value
            End Set
        End Property

        Public Property TOBS() As String
            Get
                Return _TOBS
            End Get
            Set(ByVal value As String)
                _TOBS = value
            End Set
        End Property

        Public Property NCSOTR() As String
            Get
                Return _NCSOTR
            End Get
            Set(ByVal Value As String)
                _NCSOTR = Value
            End Set
        End Property

        Public Property NCRRSR() As Int32
            Get
                Return _NCRRSR
            End Get
            Set(ByVal value As Int32)
                _NCRRSR = value
            End Set
        End Property

        Public Property FECOST() As String
            Get
                Return _FECOST
            End Get
            Set(ByVal Value As String)
                _FECOST = Value
            End Set
        End Property

        Public Property HRAOTR() As String
            Get
                Return _HRAOTR
            End Get
            Set(ByVal Value As String)
                _HRAOTR = Value
            End Set
        End Property

        Public Property CCLNT() As String
            Get
                Return _CCLNT
            End Get
            Set(ByVal Value As String)
                _CCLNT = Value
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

        Public Property CUNDVH() As String
            Get
                Return _CUNDVH
            End Get
            Set(ByVal Value As String)
                _CUNDVH = Value
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

        Public Property QMRCDR() As String
            Get
                Return _QMRCDR
            End Get
            Set(ByVal Value As String)
                _QMRCDR = Value
            End Set
        End Property

        Public Property CUNDMD_C() As String
            Get
                Return _CUNDMD_C
            End Get
            Set(ByVal Value As String)
                _CUNDMD_C = Value
            End Set
        End Property

        Public Property CUNDMD() As String
            Get
                Return _CUNDMD
            End Get
            Set(ByVal Value As String)
                _CUNDMD = Value
            End Set
        End Property

        Public Property QATNDR() As String
            Get
                Return _QATNDR
            End Get
            Set(ByVal Value As String)
                _QATNDR = Value
            End Set
        End Property

        Public Property QSLCIT() As String
            Get
                Return _QSLCIT
            End Get
            Set(ByVal Value As String)
                _QSLCIT = Value
            End Set
        End Property

        Public Property QATNAN() As String
            Get
                Return _QATNAN
            End Get
            Set(ByVal Value As String)
                _QATNAN = Value
            End Set
        End Property

        Public Property FINCRG() As String
            Get
                Return _FINCRG
            End Get
            Set(ByVal Value As String)
                _FINCRG = Value
            End Set
        End Property

        Public Property HINCIN() As String
            Get
                Return _HINCIN
            End Get
            Set(ByVal Value As String)
                _HINCIN = Value
            End Set
        End Property

        Public Property FENTCL() As String
            Get
                Return _FENTCL
            End Get
            Set(ByVal Value As String)
                _FENTCL = Value
            End Set
        End Property

        Public Property HRAENT() As String
            Get
                Return _HRAENT
            End Get
            Set(ByVal Value As String)
                _HRAENT = Value
            End Set
        End Property

        Public Property CLCLOR_C() As Int32
            Get
                Return _CLCLOR_C
            End Get
            Set(ByVal Value As Int32)
                _CLCLOR_C = Value
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

        Public Property TDRCOR() As String
            Get
                Return _TDRCOR
            End Get
            Set(ByVal Value As String)
                _TDRCOR = Value
            End Set
        End Property

        Public Property CLCLDS_C() As Int32
            Get
                Return _CLCLDS_C
            End Get
            Set(ByVal Value As Int32)
                _CLCLDS_C = Value
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

        Public Property TDRENT() As String
            Get
                Return _TDRENT
            End Get
            Set(ByVal Value As String)
                _TDRENT = Value
            End Set
        End Property

        Public Property SESSLC() As String
            Get
                Return _SESSLC
            End Get
            Set(ByVal Value As String)
                _SESSLC = Value
            End Set
        End Property

        Public Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal Value As String)
                _SESTRG = Value
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

        Public Property FCHCRT() As String
            Get
                Return _FCHCRT
            End Get
            Set(ByVal Value As String)
                _FCHCRT = Value
            End Set
        End Property

        Public Property HRACRT() As String
            Get
                Return _HRACRT
            End Get
            Set(ByVal Value As String)
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

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal Value As String)
                _CULUSA = Value
            End Set
        End Property

        Public Property FULTAC() As String
            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As String)
                _FULTAC = Value
            End Set
        End Property

        Public Property HULTAC() As String
            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As String)
                _HULTAC = Value
            End Set
        End Property

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal Value As String)
                _NTRMNL = Value
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

        Public Property SFCRTV() As String
            Get
                Return _SFCRTV
            End Get
            Set(ByVal value As String)
                _SFCRTV = value
            End Set
        End Property

        Public Property NMOPMM() As Double
            Get
                Return _NMOPMM
            End Get
            Set(ByVal value As Double)
                _NMOPMM = value
            End Set
        End Property

        Public Property NCRRRT() As Double
            Get
                Return _NCRRRT
            End Get
            Set(ByVal value As Double)
                _NCRRRT = value
            End Set
        End Property

        Public Property NMOPRP() As Double
            Get
                Return _NMOPRP
            End Get
            Set(ByVal value As Double)
                _NMOPRP = value
            End Set
        End Property

        Public Property CMEDTR() As Double
            Get
                Return _CMEDTR
            End Get
            Set(ByVal value As Double)
                _CMEDTR = value
            End Set
        End Property

        Public Property SEGUIMIENTO() As String
            Get
                Return _SEGUIMIENTO
            End Get
            Set(ByVal Value As String)
                _SEGUIMIENTO = Value
            End Set
        End Property

        Public Property NCOREG() As Int64
            Get
                Return _NCOREG
            End Get
            Set(ByVal value As Int64)
                _NCOREG = value
            End Set
        End Property

        Public Property NGSGWP() As String
            Get
                Return _NGSGWP
            End Get
            Set(ByVal value As String)
                _NGSGWP = value
            End Set
        End Property

        Public Property CCTCSC() As String
            Get
                Return _CCTCSC
            End Get
            Set(ByVal Value As String)
                _CCTCSC = Value
            End Set
        End Property

        Public Property TRFRN() As String
            Get
                Return _TRFRN
            End Get
            Set(ByVal Value As String)
                _TRFRN = Value
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

        Public Property SPRSTR() As String
            Get
                Return _SPRSTR
            End Get
            Set(ByVal Value As String)
                _SPRSTR = Value
            End Set
        End Property


        Public Property QANPRG() As Double
            Get
                Return _QANPRG
            End Get
            Set(ByVal value As Double)
                _QANPRG = value
            End Set
        End Property

        Public Property NPLNJT() As Double
            Get
                Return _NPLNJT
            End Get
            Set(ByVal value As Double)
                _NPLNJT = value
            End Set
        End Property
        Public Property NCRRPL() As Double
            Get
                Return _NCRRPL
            End Get
            Set(ByVal value As Double)
                _NCRRPL = value
            End Set
        End Property


        Public Property CLCLOR_D() As String
            Get
                Return _CLCLOR_D
            End Get
            Set(ByVal Value As String)
                _CLCLOR_D = Value
            End Set
        End Property

        Public Property CLCLDS_D() As String
            Get
                Return _CLCLDS_D
            End Get
            Set(ByVal Value As String)
                _CLCLDS_D = Value
            End Set
        End Property

        'CLCLOR

        Private _NDCORM As Decimal = 0D
        Public Property NDCORM() As Decimal
            Get
                Return _NDCORM
            End Get
            Set(ByVal value As Decimal)
                _NDCORM = value
            End Set
        End Property


        Private _NUMREQT As Decimal = 0D
        Public Property NUMREQT() As Decimal
            Get
                Return _NUMREQT
            End Get
            Set(ByVal value As Decimal)
                _NUMREQT = value
            End Set
        End Property

        Public Property SESREQ() As String
            Get
                Return _SESREQ
            End Get
            Set(ByVal value As String)
                If _SESREQ = Value Then
                    Return
                End If
                _SESREQ = Value
            End Set
        End Property

#End Region
        Private _SJTTR As String = ""
        Public Property SJTTR() As String
            Get
                Return _SJTTR
            End Get
            Set(ByVal value As String)
                If _SJTTR = Value Then
                    Return
                End If
                _SJTTR = Value
            End Set
        End Property

        Private _ESTADO_REQ As String = ""
        Public Property ESTADO_REQ() As String
            Get
                Return _ESTADO_REQ
            End Get
            Set(ByVal value As String)
                If _ESTADO_REQ = value Then
                    Return
                End If
                _ESTADO_REQ = value
            End Set
        End Property

        Public Property STPRCS() As String
            Get
                Return _STPRCS
            End Get
            Set(ByVal value As String)
                If _STPRCS = value Then
                    Return
                End If
                _STPRCS = value
            End Set
        End Property
        Public Property NPLRCS() As String
            Get
                Return _NPLRCS
            End Get
            Set(ByVal value As String)
                If _NPLRCS = value Then
                    Return
                End If
                _NPLRCS = value
            End Set
        End Property

        Public Property NRUCTR() As String
            Get
                Return _NRUCTR
            End Get
            Set(ByVal value As String)
                If _NRUCTR = value Then
                    Return
                End If
                _NRUCTR = value
            End Set
        End Property
        Public Property TCMTRT() As String
            Get
                Return _TCMTRT
            End Get
            Set(ByVal value As String)
                If _TCMTRT = value Then
                    Return
                End If
                _TCMTRT = value
            End Set
        End Property

        'JM 
#Region "Anulacion de Operación"


        Private _TPLNTA As String = ""
        Public Property TPLNTA() As String
            Get
                Return _TPLNTA
            End Get
            Set(ByVal value As String)
                If _TPLNTA = value Then
                    Return
                End If
                _TPLNTA = value
            End Set
        End Property


        Private _FINCOP As Decimal = 0
        Public Property FINCOP() As Decimal
            Get
                Return _FINCOP
            End Get
            Set(ByVal value As Decimal)
                If _FINCOP = value Then
                    Return
                End If
                _FINCOP = value
            End Set
        End Property
        Private _FINCOP_S As String = ""
        Public Property FINCOP_S() As String
            Get
                Return _FINCOP_S
            End Get
            Set(ByVal value As String)
                If _FINCOP_S = value Then
                    Return
                End If
                _FINCOP_S = value
            End Set
        End Property


        Private _FATNSR As Decimal = 0
        Public Property FATNSR() As Decimal
            Get
                Return _FATNSR
            End Get
            Set(ByVal value As Decimal)
                If _FATNSR = value Then
                    Return
                End If
                _FATNSR = value
            End Set
        End Property

        Public Property FATNSR_S() As String
            Get
                Return _FATNSR_S
            End Get
            Set(ByVal value As String)
                If _FATNSR_S = value Then
                    Return
                End If
                _FATNSR_S = value
            End Set
        End Property

        Private _CCLNT_S As String = ""
        Public Property CCLNT_S() As String
            Get
                Return _CCLNT_S
            End Get
            Set(ByVal value As String)
                If _CCLNT_S = value Then
                    Return
                End If
                _CCLNT_S = value
            End Set
        End Property

        Private _NPLCAC As String = ""
        Public Property NPLCAC() As String
            Get
                Return _NPLCAC
            End Get
            Set(ByVal value As String)
                If _NPLCAC = value Then
                    Return
                End If
                _NPLCAC = value
            End Set
        End Property

        Private _SESTOP As String = ""
        Public Property SESTOP() As String
            Get
                Return _SESTOP
            End Get
            Set(ByVal value As String)
                If _SESTOP = value Then
                    Return
                End If
                _SESTOP = value
            End Set
        End Property

        Private _UATAOP As String = ""
        Public Property UATAOP() As String
            Get
                Return _UATAOP
            End Get
            Set(ByVal value As String)
                If _UATAOP = value Then
                    Return
                End If
                _UATAOP = value
            End Set
        End Property


        Private _USLAOP As String = ""
        Public Property USLAOP() As String
            Get
                Return _USLAOP
            End Get
            Set(ByVal value As String)
                If _USLAOP = value Then
                    Return
                End If
                _USLAOP = value
            End Set
        End Property

        Private _MOTAOP As String = ""
        Public Property MOTAOP() As String
            Get
                Return _MOTAOP
            End Get
            Set(ByVal value As String)
                If _MOTAOP = value Then
                    Return
                End If
                _MOTAOP = value
            End Set
        End Property

        Private _OBSAOP As String = ""
        Public Property OBSAOP() As String
            Get
                Return _OBSAOP
            End Get
            Set(ByVal value As String)
                If _OBSAOP = value Then
                    Return
                End If
                _OBSAOP = value
            End Set
        End Property

        Private _TRFSRC As String = ""
        Public Property TRFSRC() As String
            Get
                Return _TRFSRC
            End Get
            Set(ByVal value As String)
                If _TRFSRC = value Then
                    Return
                End If
                _TRFSRC = value
            End Set
        End Property


        Private _NOPRCR As String = 0
        Public Property NOPRCR() As Decimal
            Get
                Return _NOPRCR
            End Get
            Set(ByVal value As Decimal)
                If _NOPRCR = value Then
                    Return
                End If
                _NOPRCR = value
            End Set
        End Property


        Private _RUTA As String = ""
        Public Property RUTA() As String
            Get
                Return _RUTA
            End Get
            Set(ByVal value As String)
                If _RUTA = value Then
                    Return
                End If
                _RUTA = value
            End Set
        End Property

        Private _PNOPAN_CGSTO As String = ""
        Public Property PNOPAN_CGSTO() As String
            Get
                Return _PNOPAN_CGSTO
            End Get
            Set(ByVal value As String)
                If _PNOPAN_CGSTO = value Then
                    Return
                End If
                _PNOPAN_CGSTO = value
            End Set
        End Property

        Private _FLGAPG As String = ""
        Public Property FLGAPG() As String
            Get
                Return _FLGAPG
            End Get
            Set(ByVal value As String)
                If _FLGAPG = value Then
                    Return
                End If
                _FLGAPG = value
            End Set
        End Property


#End Region


        REM ECM-HUNDRED-INICIO
        Public Property TDSCSP() As String
            Get
                Return _TDSCSP
            End Get
            Set(ByVal value As String)
                If _TDSCSP = value Then
                    Return
                End If
                _TDSCSP = value
            End Set
        End Property

        Public Property CCLNFC() As String
            Get
                Return _CCLNFC
            End Get
            Set(ByVal value As String)
                If _CCLNFC = value Then
                    Return
                End If
                _CCLNFC = value
            End Set
        End Property

       

        Public Property CDSCSP_CEBE() As String
            Get
                Return _CDSCSP_CEBE
            End Get
            Set(ByVal value As String)
                If _CDSCSP_CEBE = value Then
                    Return
                End If
                _CDSCSP_CEBE = value
            End Set
        End Property

        Public Property TDSCSP_CEBE() As String
            Get
                Return _TDSCSP_CEBE
            End Get
            Set(ByVal value As String)
                If _TDSCSP_CEBE = value Then
                    Return
                End If
                _TDSCSP_CEBE = value
            End Set
        End Property

        Public Property CDSCSP() As String
            Get
                Return _CDSCSP
            End Get
            Set(ByVal value As String)
                If _CDSCSP = value Then
                    Return
                End If
                _CDSCSP = value
            End Set
        End Property

        Public Property CDDRSP() As String
            Get
                Return _CDDRSP
            End Get
            Set(ByVal value As String)
                If _CDDRSP = value Then
                    Return
                End If
                _CDDRSP = value
            End Set
        End Property
        REM ECM-HUNDRED-FIN


        ' INCLUSION DE NUEVOS CAMPOS - DEF_SALMON FASE 2
        Private _CTTRAN As String
        Public Property CTTRAN() As String
            Get
                Return _CTTRAN
            End Get
            Set(ByVal value As String)
                _CTTRAN = value
            End Set
        End Property


        Private _CTIPCG As String
        Public Property CTIPCG() As String
            Get
                Return _CTIPCG
            End Get
            Set(ByVal value As String)
                _CTIPCG = value
            End Set
        End Property


        Private _CCLNFC_DESC As String
        Public Property CCLNFC_DESC() As String
            Get
                Return _CCLNFC_DESC
            End Get
            Set(ByVal value As String)
                _CCLNFC_DESC = value
            End Set
        End Property


        Private _COD_CEBEDP As String
        Public Property COD_CEBEDP() As String
            Get
                Return _COD_CEBEDP
            End Get
            Set(ByVal value As String)
                _COD_CEBEDP = value
            End Set
        End Property


        Private _CODSAP_CEBEDP As String
        Public Property CODSAP_CEBEDP() As String
            Get
                Return _CODSAP_CEBEDP
            End Get
            Set(ByVal value As String)
                _CODSAP_CEBEDP = value
            End Set
        End Property


        Private _DESC_CEBEDP As String
        Public Property DESC_CEBEDP() As String
            Get
                Return _DESC_CEBEDP
            End Get
            Set(ByVal value As String)
                _DESC_CEBEDP = value
            End Set
        End Property


        Private _COD_CECODP As String
        Public Property COD_CECODP() As String
            Get
                Return _COD_CECODP
            End Get
            Set(ByVal value As String)
                _COD_CECODP = value
            End Set
        End Property


        Private _CODSAP_CECODP As String
        Public Property CODSAP_CECODP() As String
            Get
                Return _CODSAP_CECODP
            End Get
            Set(ByVal value As String)
                _CODSAP_CECODP = value
            End Set
        End Property


        Private _DESC_CECODP As String
        Public Property DESC_CECODP() As String
            Get
                Return _DESC_CECODP
            End Get
            Set(ByVal value As String)
                _DESC_CECODP = value
            End Set
        End Property


        Private _COD_CEBEDT As String
        Public Property COD_CEBEDT() As String
            Get
                Return _COD_CEBEDT
            End Get
            Set(ByVal value As String)
                _COD_CEBEDT = value
            End Set
        End Property


        Private _CODSAP_CEBEDT As String
        Public Property CODSAP_CEBEDT() As String
            Get
                Return _CODSAP_CEBEDT
            End Get
            Set(ByVal value As String)
                _CODSAP_CEBEDT = value
            End Set
        End Property


        Private _DESC_CEBEDT As String
        Public Property DESC_CEBEDT() As String
            Get
                Return _DESC_CEBEDT
            End Get
            Set(ByVal value As String)
                _DESC_CEBEDT = value
            End Set
        End Property


        Private _COD_CECODT As String
        Public Property COD_CECODT() As String
            Get
                Return _COD_CECODT
            End Get
            Set(ByVal value As String)
                _COD_CECODT = value
            End Set
        End Property


        Private _CODSAP_CECODT As String
        Public Property CODSAP_CECODT() As String
            Get
                Return _CODSAP_CECODT
            End Get
            Set(ByVal value As String)
                _CODSAP_CECODT = value
            End Set
        End Property


        Private _DESC_CECODT As String
        Public Property DESC_CECODT() As String
            Get
                Return _DESC_CECODT
            End Get
            Set(ByVal value As String)
                _DESC_CECODT = value
            End Set
        End Property


        Private _CLIENTE_FACT As String
        Public Property CLIENTE_FACT() As String
            Get
                Return _CLIENTE_FACT
            End Get
            Set(ByVal value As String)
                _CLIENTE_FACT = value
            End Set
        End Property


        Private _DESC_NIVEL As String
        Public Property DESC_NIVEL() As String
            Get
                Return _DESC_NIVEL
            End Get
            Set(ByVal value As String)
                _DESC_NIVEL = value
            End Set
        End Property


        Private _DESC_CARGA As String
        Public Property DESC_CARGA() As String
            Get
                Return _DESC_CARGA
            End Get
            Set(ByVal value As String)
                _DESC_CARGA = value
            End Set
        End Property

        Private _CCLNT_COD As Decimal = 0
        Public Property CCLNT_COD() As Decimal
            Get
                Return _CCLNT_COD
            End Get
            Set(ByVal Value As Decimal)
                _CCLNT_COD = Value
            End Set
        End Property

        Private _FTRTSG As String = ""
        Public Property FTRTSG() As String
            Get
                Return _FTRTSG
            End Get
            Set(ByVal value As String)
                _FTRTSG = value
            End Set
        End Property

        Public Property CARERS() As String
            Get
                Return _CARERS
            End Get
            Set(ByVal value As String)
                _CARERS = value
            End Set
        End Property


        Public Property NMRGIM() As Decimal
            Get
                Return _NMRGIM
            End Get
            Set(ByVal Value As Decimal)
                _NMRGIM = Value
            End Set
        End Property
        Public Property NMRGIM_IMG() As String
            Get
                Return _NMRGIM_IMG
            End Get
            Set(ByVal Value As String)
                _NMRGIM_IMG = Value
            End Set
        End Property
 

        Public Property TPSOTR() As String
            Get
                Return _TPSOTR
            End Get
            Set(ByVal Value As String)
                _TPSOTR = Value
            End Set
        End Property

        Public Property HATNSR_S() As String
            Get
                Return _HATNSR_S
            End Get
            Set(ByVal Value As String)
                _HATNSR_S = Value
            End Set
        End Property

        Public Property HATNSR() As Decimal
            Get
                Return _HATNSR
            End Get
            Set(ByVal Value As Decimal)
                _HATNSR = Value
            End Set
        End Property

        Public Property ANULAR() As String
            Get
                Return _ANULAR
            End Get
            Set(ByVal Value As String)
                _ANULAR = Value
            End Set
        End Property

        Public Property TPSOTR_DESC() As String
            Get
                Return _TPSOTR_DESC
            End Get
            Set(ByVal Value As String)
                _TPSOTR_DESC = Value
            End Set
        End Property



  End Class
End Namespace

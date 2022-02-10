Namespace mantenimientos
    Public Class ClaseGeneral

#Region "Atributos"
        Private _TCMTRT As String = ""
        Private _NPLNJT As String = ""
        Private _NCRRPL As String = ""
        Private _FPLNJT As String = ""
        Private _HPLNJT As String = ""
        Private _TDSCPL As String = ""
        Private _TRSPAT As String = ""
        Private _QCNASI As String = ""
        Private _SESPLN As String = ""
        Private _NCSOTR As String = ""
        Private _NCRRSR As String = ""
        Private _NOPRCN As String = ""
        Private _NRUCTR As String = ""
        Private _NPLCUN As String = ""
        Private _NPLCAC As String = ""
        Private _CBRCNT As String = ""
        Private _CBRCN2 As String = ""
        Private _CBRCND As String = ""
        Private _CBRCND2 As String = ""
        Private _FECOST As String = ""
        Private _CCLNT As String = ""
        Private _CUNDVH As String = ""
        Private _QSLCIT As Integer = 0
        Private _QATNAN As Integer = 0
        Private _NOMCHOFER As String = ""
        Private _FASGTR As String = ""
        Private _HASGTR As String = ""
        Private _QATNDR As Integer = 0
        Private _FATALM As String = ""
        Private _HATALM As String = ""
        Private _FSLALM As String = ""
        Private _HSLALM As String = ""
        Private _NGUITR As String = ""
        Private _SEGUIMIENTO As String = ""
        Private _GPSLAT As String = ""
        Private _GPSLON As String = ""
        Private _FECGPS As String = ""
        Private _HORGPS As String = ""
        Private _RUTA As String = ""
        Private _CLCLOR As String = ""
        Private _CLCLDS As String = ""
        Private _TDRENT As String = ""
        Private _CUNDMD As String = ""
        Private _TDRCOR As String = ""
        Private _CMRCDR As String = ""
        Private _TCMPCL As String = "" ' NOMBRE CLIENTE
        Private _QMRCDR As Double = 0
        Private _CCMPN As String = ""
        Private _TCMPCM As String = ""
        Private _CDVSN As String = ""
        Private _TCMPDV As String = ""
        Private _CPLNDV As String = ""
        Private _TPLNTA As String = ""
        Private _IARAVC As Double = 0
        Private _NORSRT As Double = 0
        Private _COBRR As String = "0"
        Private _NCTAVC As String = 0
        Private _NCSLPE As String = 0
        Private _CRGVTA As String = ""
        Private _CMTCDS As String = ""
        Private _FCSLPE As String = ""
        Private _TNMBOB As String = ""
        Private _ORIGEN As String = ""
        Private _DESTIN As String = ""
        Private _IRTAVC As Double = 0
        Private _ISLPES As Double = 0
        Private _NMSLPE As String = ""
        Private _CCNTCS As String = ""
        Private _TCNTCS As String = ""
        Private _NMSOLC As String = "0"
        Private _IMPSOL As Double = "0"
        Private _IMPAVCSTR As String = ""
        Private _MOTIVO As String = ""
        Private _FINAVC As String = ""
        Private _FCHLQD As String = ""
        Private _TTPMDT As String = ""
        Private _ESTADO As String = ""
        Private _FECFIN As String = ""
        Private _USUARIO As String = ""
        Private _FECINI As String = ""
        Private _ISLPESP As Double = 0
        Private _FCJSPE As String = ""
        Private _FESLPE As String = ""
        Private _PERNR As String = ""
        Private _TCMPEM As String = ""
        Private _TCLRUN As String = ""
        Private _TMRCTR As String = ""
        Private _QPSOTR As Double = 0
        Private _QGLNCM As Double = 0
        Private _FFBRUN As Double = 0
        Private _NVLGRF As String = ""
        Private _TGRFO As String = ""
        Private _TDSCMB As String = ""
        Private _FCRCMB_S As String = ""
        Private _FCRCMB As Double = 0
        Private _NCSLP2 As Double = 0
        Private _NCTAV2 As Double = 0
        Private _STSVIS As String = ""
        Private _STSADI As String = ""
        Private _STSCHG As String = ""
        Private _STSELI As String = ""
        Private _STSOP1 As String = ""
        Private _STSOP2 As String = ""
        Private _STSOP3 As String = ""
        Private _NORINS As Double
        Private _IGSTVJ As Double
        Private _IFCTPG As Double
        Private _QDSTKM As Double
        Private _TCNFVH As String = ""
        Private _TDSCM1 As String = ""
        Private _QCRUTV As Double = 0
        Private _SINDRC As String = ""
        Private _TCMRCD As String = ""
        Private _CGSTOS As Double = 0
        Private _TGSTOS As String = ""
        Private _TAUTR As String = ""
        Private _NCTAV3 As Double = 0
        Private _NCTAV4 As Double = 0
        Private _EXISTE As Boolean = False
        Private _PSFECINI As String = ""
        Private _PSFECFIN As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As String = ""
        Private _HRACRT As String = 0
        Private _NTRMCR As String = ""
        Private _CULUSA As String = ""
        Private _FULTAC As String = ""
        Private _HULTAC As String = ""
        Private _NTRMNL As String = ""
        Private _SCATEG As Double
        Private _SESSLC As String = ""
        Private _NLQCMB As Double = 0
        Private _FLQDCN_S As String = ""
        Private _QGLNSA As Double = 0
        Private _QTGLIN As Double = 0
        Private _QGLNUT As Double = 0
        Private _NKMRCR As Double = 0
        Private _CTPCMB As String = ""
        Private _PMRCDR As Double = 0
        Private _NKMVRT As Double = 0
        Private _QGLVRT As Double = 0
        Private _RENREA As Double = 0
        Private _RENVRT As Double = 0
        Private _EVACBG As String = ""
        Private _EVACBP As String = ""
        Private _EVAREN As Double = 0
        Private _ALERTA As String = ""
        Private _TCATEG As String = ""
        Private _FGUIRM As String = ""
        Private _QKMREC As Double = 0
        Private _QGNXCN As Double = 0
        Private _CTRSPT As Double = 0
        Private _COMTOT As Double = 0
        Private _NCOREG As Int64 = 0
        Private _NGSGWP As String = ""
        Private _SESTOP As String = ""
        Private _NGUIRM As Int64 = 0
        Private _CCTCSC As String = ""
        Private _SESAVC As String = ""
        Private _CONDUCTOR2 As String = ""
        Private _CONDUCTOR As String = ""
        Private _NORINSS As String = "0"
        Private _NPLNMT As String = "0"
        Private _NORCMC As String = ""
        Private _NRITOC As String = ""
        Private _FSLDCM As String = ""
        Private _FLLGCM As String = ""
        Private _TOBS As String = ""
        Private _CCNCS1 As String = ""
        Private _CMEDTR As Int32 = 0
        Private _CTPOVJ As String = ""
        Private _UNIDADES As Int32 = 0
        Private _NUMREQT As Decimal = 0

#End Region

#Region "Properties"


        Public Property UNIDADES() As Int32
            Get
                Return _UNIDADES
            End Get
            Set(ByVal value As Int32)
                _UNIDADES = value
            End Set
        End Property

        Public Property CMEDTR() As Int32
            Get
                Return _CMEDTR
            End Get
            Set(ByVal value As Int32)
                _CMEDTR = value
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

        Public Property NORCMC() As String
            Get
                Return _NORCMC
            End Get
            Set(ByVal value As String)
                _NORCMC = value
            End Set
        End Property

        Public Property NRITOC() As String
            Get
                Return _NRITOC
            End Get
            Set(ByVal value As String)
                _NRITOC = value
            End Set
        End Property

        Public Property FSLDCM() As String
            Get
                Return _FSLDCM
            End Get
            Set(ByVal value As String)
                _FSLDCM = value
            End Set
        End Property

        Public Property FLLGCM() As String
            Get
                Return _FLLGCM
            End Get
            Set(ByVal value As String)
                _FLLGCM = value
            End Set
        End Property

        Public Property CCTCSC() As String
            Get
                Return _CCTCSC
            End Get
            Set(ByVal value As String)
                _CCTCSC = value
            End Set
        End Property

        Public Property FGUIRM() As String
            Get
                Return _FGUIRM
            End Get
            Set(ByVal value As String)
                _FGUIRM = value
            End Set
        End Property

        Public Property QKMREC() As Double
            Get
                Return _QKMREC
            End Get
            Set(ByVal value As Double)
                _QKMREC = value
            End Set
        End Property

        Public Property EVAREN() As Double
            Get
                Return _EVAREN
            End Get
            Set(ByVal value As Double)
                _EVAREN = value
            End Set
        End Property

        Public Property RENREA() As Double
            Get
                Return _RENREA
            End Get
            Set(ByVal value As Double)
                _RENREA = value
            End Set
        End Property

        Public Property RENVRT() As Double
            Get
                Return _RENVRT
            End Get
            Set(ByVal value As Double)
                _RENVRT = value
            End Set
        End Property

        Public Property EVACBG() As String
            Get
                Return _EVACBG
            End Get
            Set(ByVal value As String)
                _EVACBG = value
            End Set
        End Property

        Public Property ALERTA() As String
            Get
                Return _ALERTA
            End Get
            Set(ByVal value As String)
                _ALERTA = value
            End Set
        End Property

        Public Property EVACBP() As String
            Get
                Return _EVACBP
            End Get
            Set(ByVal value As String)
                _EVACBP = value
            End Set
        End Property

        Public Property TCATEG() As String
            Get
                Return _TCATEG
            End Get
            Set(ByVal value As String)
                _TCATEG = value
            End Set
        End Property

        Public Property SESSLC() As String
            Get
                Return _SESSLC
            End Get
            Set(ByVal value As String)
                _SESSLC = value
            End Set
        End Property

        Public Property SCATEG() As Double
            Get
                Return _SCATEG
            End Get
            Set(ByVal value As Double)
                _SCATEG = value
            End Set
        End Property

        Public Property PMRCDR() As Double
            Get
                Return _PMRCDR
            End Get
            Set(ByVal value As Double)
                _PMRCDR = value
            End Set
        End Property

        Public Property NKMVRT() As Double
            Get
                Return _NKMVRT
            End Get
            Set(ByVal value As Double)
                _NKMVRT = value
            End Set
        End Property

        Public Property QGLVRT() As Double
            Get
                Return _QGLVRT
            End Get
            Set(ByVal value As Double)
                _QGLVRT = value
            End Set
        End Property

        Public Property SESAVC() As String
            Get
                Return _SESAVC
            End Get
            Set(ByVal value As String)
                _SESAVC = value
            End Set
        End Property

        Public Property PSFECINI() As String
            Get
                Return _PSFECINI
            End Get
            Set(ByVal value As String)
                _PSFECINI = value
            End Set
        End Property

        Public Property PSFECFIN() As String
            Get
                Return _PSFECFIN
            End Get
            Set(ByVal value As String)
                _PSFECFIN = value
            End Set
        End Property

        Public Property EXISTE() As Boolean
            Get
                Return _EXISTE
            End Get
            Set(ByVal value As Boolean)
                _EXISTE = value
            End Set
        End Property

        Public Property CBRCND2() As String
            Get
                Return _CBRCND2
            End Get
            Set(ByVal value As String)
                _CBRCND2 = value
            End Set
        End Property

        Public Property NCTAV3() As Double
            Get
                Return _NCTAV3
            End Get
            Set(ByVal value As Double)
                _NCTAV3 = value
            End Set
        End Property

        Public Property NCTAV4() As Double
            Get
                Return _NCTAV4
            End Get
            Set(ByVal value As Double)
                _NCTAV4 = value
            End Set
        End Property

        Public Property CGSTOS() As Double
            Get
                Return _CGSTOS
            End Get
            Set(ByVal value As Double)
                _CGSTOS = value
            End Set
        End Property

        Public Property TGSTOS() As String
            Get
                Return _TGSTOS
            End Get
            Set(ByVal value As String)
                _TGSTOS = value
            End Set
        End Property

        Public Property TAUTR() As String
            Get
                Return _TAUTR
            End Get
            Set(ByVal value As String)
                _TAUTR = value
            End Set
        End Property

        Public Property TCMRCD() As String
            Get
                Return _TCMRCD
            End Get
            Set(ByVal value As String)
                _TCMRCD = value
            End Set
        End Property

        Public Property SINDRC() As String
            Get
                Return _SINDRC
            End Get
            Set(ByVal value As String)
                _SINDRC = value
            End Set
        End Property

        Public Property QDSTKM() As Double
            Get
                Return _QDSTKM
            End Get
            Set(ByVal value As Double)
                _QDSTKM = value
            End Set
        End Property

        Public Property IFCTPG() As Double
            Get
                Return _IFCTPG
            End Get
            Set(ByVal value As Double)
                _IFCTPG = value
            End Set
        End Property

        Public Property IGSTVJ() As Double
            Get
                Return _IGSTVJ
            End Get
            Set(ByVal value As Double)
                _IGSTVJ = value
            End Set
        End Property

        Public Property NORINS() As Double
            Get
                Return _NORINS
            End Get
            Set(ByVal value As Double)
                _NORINS = value
            End Set
        End Property

        Public Property STSVIS() As String
            Get
                Return _STSVIS
            End Get
            Set(ByVal value As String)
                _STSVIS = value
            End Set
        End Property

        Public Property STSADI() As String
            Get
                Return _STSADI
            End Get
            Set(ByVal value As String)
                _STSADI = value
            End Set
        End Property

        Public Property STSCHG() As String
            Get
                Return _STSCHG
            End Get
            Set(ByVal value As String)
                _STSCHG = value
            End Set
        End Property

        Public Property STSELI() As String
            Get
                Return _STSELI
            End Get
            Set(ByVal value As String)
                _STSELI = value
            End Set
        End Property

        Public Property NCTAV2() As Double
            Get
                Return _NCTAV2
            End Get
            Set(ByVal value As Double)
                _NCTAV2 = value
            End Set
        End Property

        Public Property NCSLP2() As Double
            Get
                Return _NCSLP2
            End Get
            Set(ByVal value As Double)
                _NCSLP2 = value
            End Set
        End Property

        Public Property CONDUCTOR2() As String
            Get
                Return _CONDUCTOR2
            End Get
            Set(ByVal value As String)
                _CONDUCTOR2 = value
            End Set
        End Property

        Public Property CONDUCTOR() As String
            Get
                Return _CONDUCTOR
            End Get
            Set(ByVal value As String)
                _CONDUCTOR = value
            End Set
        End Property

        Public Property CBRCN2() As String
            Get
                Return _CBRCN2
            End Get
            Set(ByVal value As String)
                _CBRCN2 = value
            End Set
        End Property

        Public Property NORINSS() As String
            Get
                Return _NORINSS
            End Get
            Set(ByVal value As String)
                _NORINSS = value
            End Set
        End Property

        Public Property NPLNMT() As String
            Get
                Return _NPLNMT
            End Get
            Set(ByVal value As String)
                _NPLNMT = value
            End Set
        End Property

        Public Property PERNR() As String
            Get
                Return _PERNR
            End Get
            Set(ByVal Value As String)
                _PERNR = Value
            End Set
        End Property

        Public Property TCMPEM() As String
            Get
                Return _TCMPEM
            End Get
            Set(ByVal Value As String)
                _TCMPEM = Value
            End Set
        End Property

        Public Property ISLPESP() As Double
            Get
                Return _ISLPESP
            End Get
            Set(ByVal value As Double)
                _ISLPESP = value
            End Set
        End Property

        Public Property FCJSPE() As String
            Get
                Return _FCJSPE
            End Get
            Set(ByVal value As String)
                _FCJSPE = value
            End Set
        End Property

        Public Property FESLPE() As String
            Get
                Return _FESLPE
            End Get
            Set(ByVal value As String)
                _FESLPE = value
            End Set
        End Property

        Public Property USUARIO() As String
            Get
                Return _USUARIO
            End Get
            Set(ByVal value As String)
                _USUARIO = value
            End Set
        End Property

        Public Property FECINI() As String
            Get
                Return _FECINI
            End Get
            Set(ByVal value As String)
                _FECINI = value
            End Set
        End Property

        Public Property FECFIN() As String
            Get
                Return _FECFIN
            End Get
            Set(ByVal value As String)
                _FECFIN = value
            End Set
        End Property

        Public Property ESTADO() As String
            Get
                Return _ESTADO
            End Get
            Set(ByVal value As String)
                _ESTADO = value
            End Set
        End Property

        Public Property TTPMDT() As String
            Get
                Return _TTPMDT
            End Get
            Set(ByVal value As String)
                _TTPMDT = value
            End Set
        End Property

        Public Property FCHLQD() As String
            Get
                Return _FCHLQD
            End Get
            Set(ByVal value As String)
                _FCHLQD = value
            End Set
        End Property

        Public Property FINAVC() As String
            Get
                Return _FINAVC
            End Get
            Set(ByVal value As String)
                _FINAVC = value
            End Set
        End Property

        Public Property STSOP1() As String
            Get
                Return _STSOP1
            End Get
            Set(ByVal value As String)
                _STSOP1 = value
            End Set
        End Property

        Public Property STSOP2() As String
            Get
                Return _STSOP2
            End Get
            Set(ByVal value As String)
                _STSOP2 = value
            End Set
        End Property

        Public Property STSOP3() As String
            Get
                Return _STSOP3
            End Get
            Set(ByVal value As String)
                _STSOP3 = value
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

        Public Property TCMTRT() As String
            Get
                Return _TCMTRT
            End Get
            Set(ByVal Value As String)
                _TCMTRT = Value
            End Set
        End Property

        Public Property NPLNJT() As String
            Get
                Return _NPLNJT
            End Get
            Set(ByVal Value As String)
                _NPLNJT = Value
            End Set
        End Property

        Public Property NCRRPL() As String
            Get
                Return _NCRRPL
            End Get
            Set(ByVal Value As String)
                _NCRRPL = Value
            End Set
        End Property

        Public Property FPLNJT() As String
            Get
                Return _FPLNJT
            End Get
            Set(ByVal Value As String)
                _FPLNJT = Value
            End Set
        End Property

        Public Property HPLNJT() As String
            Get
                Return _HPLNJT
            End Get
            Set(ByVal Value As String)
                _HPLNJT = Value
            End Set
        End Property

        Public Property TDSCPL() As String
            Get
                Return _TDSCPL
            End Get
            Set(ByVal Value As String)
                _TDSCPL = Value
            End Set
        End Property

        Public Property TRSPAT() As String
            Get
                Return _TRSPAT
            End Get
            Set(ByVal Value As String)
                _TRSPAT = Value
            End Set
        End Property

        Public Property QCNASI() As String
            Get
                Return _QCNASI
            End Get
            Set(ByVal Value As String)
                _QCNASI = Value
            End Set
        End Property

        Public Property SESPLN() As String
            Get
                Return _SESPLN
            End Get
            Set(ByVal Value As String)
                _SESPLN = Value
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

        Public Property NCSOTR() As String
            Get
                Return _NCSOTR
            End Get
            Set(ByVal Value As String)
                _NCSOTR = Value
            End Set
        End Property

        Public Property NCRRSR() As String
            Get
                Return _NCRRSR
            End Get
            Set(ByVal Value As String)
                _NCRRSR = Value
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

        Public Property NRUCTR() As String
            Get
                Return _NRUCTR
            End Get
            Set(ByVal Value As String)
                _NRUCTR = Value
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

        Public Property NPLCAC() As String
            Get
                Return _NPLCAC
            End Get
            Set(ByVal Value As String)
                _NPLCAC = Value
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

        Public Property CBRCNT() As String
            Get
                Return _CBRCNT
            End Get
            Set(ByVal Value As String)
                _CBRCNT = Value
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

        Public Property CUNDVH() As String
            Get
                Return _CUNDVH
            End Get
            Set(ByVal Value As String)
                _CUNDVH = Value
            End Set
        End Property

        Public Property QSLCIT() As Integer
            Get
                Return _QSLCIT
            End Get
            Set(ByVal Value As Integer)
                _QSLCIT = Value
            End Set
        End Property

        Public Property QATNAN() As Integer
            Get
                Return _QATNAN
            End Get
            Set(ByVal Value As Integer)
                _QATNAN = Value
            End Set
        End Property

        Public Property QATNDR() As Integer
            Get
                Return _QATNDR
            End Get
            Set(ByVal Value As Integer)
                _QATNDR = Value
            End Set
        End Property

        Public Property NOMCHOFER() As String
            Get
                Return _NOMCHOFER
            End Get
            Set(ByVal Value As String)
                _NOMCHOFER = Value
            End Set
        End Property

        Public Property NOPRCN() As String
            Get
                Return _NOPRCN
            End Get
            Set(ByVal Value As String)
                _NOPRCN = Value
            End Set
        End Property

        Public Property FASGTR() As String
            Get
                Return _FASGTR
            End Get
            Set(ByVal Value As String)
                _FASGTR = Value
            End Set
        End Property

        Public Property HASGTR() As String
            Get
                Return _HASGTR
            End Get
            Set(ByVal Value As String)
                _HASGTR = Value
            End Set
        End Property

        Public Property FATALM() As String
            Get
                Return _FATALM
            End Get
            Set(ByVal Value As String)
                _FATALM = Value
            End Set
        End Property

        Public Property HATALM() As String
            Get
                Return _HATALM
            End Get
            Set(ByVal Value As String)
                _HATALM = Value
            End Set
        End Property

        Public Property FSLALM() As String
            Get
                Return _FSLALM
            End Get
            Set(ByVal Value As String)
                _FSLALM = Value
            End Set
        End Property

        Public Property HSLALM() As String
            Get
                Return _HSLALM
            End Get
            Set(ByVal Value As String)
                _HSLALM = Value
            End Set
        End Property

        Public Property NGUITR() As String
            Get
                Return _NGUITR
            End Get
            Set(ByVal Value As String)
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

        Public Property GPSLAT() As String
            Get
                Return _GPSLAT
            End Get
            Set(ByVal Value As String)
                _GPSLAT = Value
            End Set
        End Property

        Public Property GPSLON() As String
            Get
                Return _GPSLON
            End Get
            Set(ByVal Value As String)
                _GPSLON = Value
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

        Public Property FECGPS() As String
            Get
                Return _FECGPS
            End Get
            Set(ByVal Value As String)
                _FECGPS = Value
            End Set
        End Property

        Public Property HORGPS() As String
            Get
                Return _HORGPS
            End Get
            Set(ByVal Value As String)
                _HORGPS = Value
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

        Public Property CLCLOR() As String
            Get
                Return _CLCLOR
            End Get
            Set(ByVal Value As String)
                _CLCLOR = Value
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

        Public Property CUNDMD() As String
            Get
                Return _CUNDMD
            End Get
            Set(ByVal Value As String)
                _CUNDMD = Value
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

        Public Property QMRCDR() As Double
            Get
                Return _QMRCDR
            End Get
            Set(ByVal value As Double)
                _QMRCDR = value
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

        Public Property TCMPCM() As String
            Get
                Return _TCMPCM
            End Get
            Set(ByVal Value As String)
                _TCMPCM = Value
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

        Public Property TCMPDV() As String
            Get
                Return _TCMPDV
            End Get
            Set(ByVal Value As String)
                _TCMPDV = Value
            End Set
        End Property

        Public Property CPLNDV() As String
            Get
                Return _CPLNDV
            End Get
            Set(ByVal Value As String)
                _CPLNDV = Value
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

        Public Property IARAVC() As Double
            Get
                Return _IARAVC
            End Get
            Set(ByVal value As Double)
                _IARAVC = value
            End Set
        End Property

        Public Property NORSRT() As Double
            Get
                Return _NORSRT
            End Get
            Set(ByVal value As Double)
                _NORSRT = value
            End Set
        End Property

        Public Property COBRR() As String
            Get
                Return _COBRR
            End Get
            Set(ByVal value As String)
                _COBRR = value
            End Set
        End Property

        Public Property NCTAVC() As String
            Get
                Return _NCTAVC
            End Get
            Set(ByVal Value As String)
                _NCTAVC = Value
            End Set
        End Property

        Public Property NCSLPE() As String
            Get
                Return _NCSLPE
            End Get
            Set(ByVal Value As String)
                _NCSLPE = Value
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

        Public Property CMTCDS() As String
            Get
                Return _CMTCDS
            End Get
            Set(ByVal value As String)
                _CMTCDS = value
            End Set
        End Property

        Public Property FCSLPE() As String
            Get
                Return _FCSLPE
            End Get
            Set(ByVal Value As String)
                _FCSLPE = Value
            End Set
        End Property

        Public Property TNMBOB() As String
            Get
                Return _TNMBOB
            End Get
            Set(ByVal Value As String)
                _TNMBOB = Value
            End Set
        End Property

        Public Property ORIGEN() As String
            Get
                Return _ORIGEN
            End Get
            Set(ByVal Value As String)
                _ORIGEN = Value
            End Set
        End Property

        Public Property DESTIN() As String
            Get
                Return _DESTIN
            End Get
            Set(ByVal Value As String)
                _DESTIN = Value
            End Set
        End Property

        Public Property IRTAVC() As Double
            Get
                Return _IRTAVC
            End Get
            Set(ByVal Value As Double)
                _IRTAVC = Value
            End Set
        End Property

        Public Property ISLPES() As Double
            Get
                Return _ISLPES
            End Get
            Set(ByVal Value As Double)
                _ISLPES = Value
            End Set
        End Property

        Public Property NMSLPE() As String
            Get
                Return _NMSLPE
            End Get
            Set(ByVal Value As String)
                _NMSLPE = Value
            End Set
        End Property

        Public Property CCNTCS() As String
            Get
                Return _CCNTCS
            End Get
            Set(ByVal Value As String)
                _CCNTCS = Value
            End Set
        End Property

        Public Property CCNCS1() As String
            Get
                Return _CCNCS1
            End Get
            Set(ByVal Value As String)
                _CCNCS1 = Value
            End Set
        End Property

        Public Property TCNTCS() As String
            Get
                Return _TCNTCS
            End Get
            Set(ByVal Value As String)
                _TCNTCS = Value
            End Set
        End Property

        Public Property NMSOLC() As String
            Get
                Return _NMSOLC
            End Get
            Set(ByVal Value As String)
                _NMSOLC = Value
            End Set
        End Property

        Public Property IMPSOL() As Double
            Get
                Return _IMPSOL
            End Get
            Set(ByVal Value As Double)
                _IMPSOL = Value
            End Set
        End Property

        Public Property IMPAVCSTR() As String
            Get
                Return _IMPAVCSTR
            End Get
            Set(ByVal Value As String)
                _IMPAVCSTR = Value
            End Set
        End Property

        Public Property MOTIVO() As String
            Get
                Return _MOTIVO
            End Get
            Set(ByVal value As String)
                _MOTIVO = value
            End Set
        End Property

        Public Property TCLRUN() As String
            Get
                Return _TCLRUN
            End Get
            Set(ByVal Value As String)
                _TCLRUN = Value
            End Set
        End Property

        Public Property TMRCTR() As String
            Get
                Return _TMRCTR
            End Get
            Set(ByVal Value As String)
                _TMRCTR = Value
            End Set
        End Property

        Public Property QPSOTR() As Double
            Get
                Return _QPSOTR
            End Get
            Set(ByVal Value As Double)
                _QPSOTR = Value
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

        Public Property QGNXCN() As Double
            Get
                Return _QGNXCN
            End Get
            Set(ByVal Value As Double)
                _QGNXCN = Value
            End Set
        End Property

        Public Property FFBRUN() As Double
            Get
                Return _FFBRUN
            End Get
            Set(ByVal Value As Double)
                _FFBRUN = Value
            End Set
        End Property

        Public Property NVLGRF() As String
            Get
                Return _NVLGRF
            End Get
            Set(ByVal Value As String)
                _NVLGRF = Value
            End Set
        End Property

        Public Property TGRFO() As String
            Get
                Return _TGRFO
            End Get
            Set(ByVal Value As String)
                _TGRFO = Value
            End Set
        End Property

        Public Property TDSCMB() As String
            Get
                Return _TDSCMB
            End Get
            Set(ByVal Value As String)
                _TDSCMB = Value
            End Set
        End Property

        Public Property FCRCMB_S() As String
            Get
                Return _FCRCMB_S
            End Get
            Set(ByVal Value As String)
                _FCRCMB_S = Value
            End Set
        End Property

        Public Property FCRCMB() As Double
            Get
                Return _FCRCMB
            End Get
            Set(ByVal Value As Double)
                _FCRCMB = Value
            End Set
        End Property

        Public Property TCNFVH() As String
            Get
                Return _TCNFVH
            End Get
            Set(ByVal value As String)
                _TCNFVH = value
            End Set
        End Property

        Public Property TDSCM1() As String
            Get
                Return _TDSCM1
            End Get
            Set(ByVal value As String)
                _TDSCM1 = value
            End Set
        End Property

        Public Property QCRUTV() As Double
            Get
                Return _QCRUTV
            End Get
            Set(ByVal value As Double)
                _QCRUTV = value
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

        Public Property NLQCMB() As Double
            Get
                Return _NLQCMB
            End Get
            Set(ByVal Value As Double)
                _NLQCMB = Value
            End Set
        End Property

        Public Property FLQDCN_S() As String
            Get
                Return _FLQDCN_S
            End Get
            Set(ByVal Value As String)
                _FLQDCN_S = Value
            End Set
        End Property

        Public Property CTPCMB() As String
            Get
                Return _CTPCMB
            End Get
            Set(ByVal Value As String)
                _CTPCMB = Value
            End Set
        End Property

        Public Property QGLNSA() As Double
            Get
                Return _QGLNSA
            End Get
            Set(ByVal Value As Double)
                _QGLNSA = Value
            End Set
        End Property

        Public Property QTGLIN() As Double
            Get
                Return _QTGLIN
            End Get
            Set(ByVal Value As Double)
                _QTGLIN = Value
            End Set
        End Property

        Public Property QGLNUT() As Double
            Get
                Return _QGLNUT
            End Get
            Set(ByVal Value As Double)
                _QGLNUT = Value
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

        Public Property CTRSPT() As Double
            Get
                Return _CTRSPT
            End Get
            Set(ByVal Value As Double)
                _CTRSPT = Value
            End Set
        End Property

        Public Property COMTOT() As Double
            Get
                Return _COMTOT
            End Get
            Set(ByVal Value As Double)
                _COMTOT = Value
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

        Public Property CTPOVJ() As String
            Get
                Return _CTPOVJ
            End Get
            Set(ByVal Value As String)
                _CTPOVJ = Value
            End Set
        End Property

        Public Property NUMREQT() As Decimal
            Get
                Return _NUMREQT
            End Get
            Set(ByVal value As Decimal)
                _NUMREQT = value
            End Set
        End Property

#End Region

    End Class
End Namespace


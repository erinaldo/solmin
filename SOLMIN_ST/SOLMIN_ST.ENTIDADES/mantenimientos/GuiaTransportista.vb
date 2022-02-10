
Namespace mantenimientos

    Public Class GuiaTransportista

#Region "Atributos"
        Private _CTRMNC As Double = 0
        Private _NGUIRM As Double = 0
        Private _FGUIRM As Double = 0
        Private _FGUIRM_S As String = ""
        Private _NPLNMT As Double = 0
        Private _CLCLOR As Double = 0
        Private _CLCLDS As Double = 0
        Private _TDIROR As String = ""
        Private _TDIRDS As String = ""
        Private _NOPRCN As Double = 0
        Private _TRFRGU As String = ""
        Private _QMRCMC As Double = 0
        Private _PMRCMC As Double = 0
        Private _CUNDMD As String = ""
        Private _QGLGSL As Double = 0
        Private _QGLDSL As Double = 0
        Private _NRHJCR As Double = 0
        Private _CTRSPT As Double = 0
        Private _NPLCTR As String = ""
        Private _NPLCAC As String = ""
        Private _CBRCNT As String = ""
        Private _CBRCND As String = ""
        Private _CBRCN2 As String = ""
        Private _CBRCND2 As String = ""
        Private _TNMBRM As String = ""
        Private _TDRCRM As String = ""
        Private _TPDCIR As String = ""
        Private _NRUCRM As Double = 0
        Private _TNMBCN As String = ""
        Private _TDRCNS As String = ""
        Private _TPDCIC As String = ""
        Private _NRUCCN As Double = 0
        Private _SACRGO As String = ""
        Private _CMNFLT As Double = 0
        Private _SESTRG As String = ""
        Private _FLGADC As String = ""
        Private _SIDAVL As String = ""
        Private _QKMREC As Double = 0
        Private _ICSTRM As Double = 0
        Private _QPSOBR As Double = 0
        Private _QVLMOR As Double = 0
        Private _SMRPLG As String = ""
        Private _SMRPRC As String = ""
        Private _IVLPRT As Double = 0
        Private _CMNVLP As Double = 0
        Private _CCMPN As String = ""
        Private _CDVSN As String = ""
        Private _CPLNDV As Double = 0
        Private _USRCRT As String = ""
        Private _FCHCRT As Double = 0
        Private _HRACRT As Double = 0
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _CULUSA As String = ""
        Private _NTRMNL As String = ""
        Private _CUBORI As Double = 0
        Private _CUBDES As Double = 0
        Private _FECETD As Double = 0
        Private _FECETA As Double = 0
        Private _FEMVLH As Double = 0
        Private _FCHFTR As Double = 0
        Private _NESTDO As Double = 0
        Private _NRSERI As Double = 0
        Private _NPRGUI As Double = 0
        Private _NRUCTR As String = ""
        Private _CCLNT As Double = 0
        Private _TCMPCL As String = ""

        Private _NRGUCL As Double = 0
        Private _FCGUCL As Double = 0
        Private _FCGUCL_S As String = ""
        Private _NGUIAD As Double = 0
        Private _NORCML As String = ""
        Private _RUTA As String = ""
        Private _TOBS As String = ""
        Private _NORSRT As String = ""
        Private _NRGUCL_S As String = ""
        Private _CUBORI_S As String = ""
        Private _CUBDES_S As String = ""

        Private _SRPTRM As String = ""
        Private _FSLDCM As Double = 0
        Private _FLLGCM As Double = 0
        Private _TCNFVH As String = ""
        Private _TCNFG1 As String = ""
        Private _TCNFG2 As String = ""
        Private _CCNCST As Double = 0
        Private _TDSCAR As String = ""

        Private _TCMTRT As String = ""
        Private _TCMLCO As String = ""
        Private _TCMLCD As String = ""
        Private _CMRCDR As Int32 = 0
        Private _TCMRCD As String = ""

        Private _SESGRP As String = ""
        Private _NMGUIR As Double = 0
        Private _CHECK As Boolean = True

        Private _NTRMCR As String = ""
        Private _FULTAC_S As String = ""
        Private _HULTAC_S As String = ""
        Private _FCHCRT_S As String = ""
        Private _HRACRT_S As String = ""
        Private _FEMVLH_S As String = ""
        Private _FCHFTR_S As String = ""
        Private _FECETD_S As String = ""
        Private _FECETA_S As String = ""
        Private _CPLNDV_S As String = ""
        Private _TNMMDT As String = ""
        Private _NCSOTR As String = ""
        Private _NCRRSR As Int32 = 0
        Private _SEGUIMIENTO As String = ""
        Private _GPSLAT As String = ""
        Private _GPSLON As String = ""
        Private _FECGPS As String = ""
        Private _HORGPS As String = ""
        Private _NCOREG As Int64 = 0
        Private _NGSGWP As String = ""
        Private _CMEDTR As Int16 = 0
        Private _NGUIRM_S As String = "0"
        Private _FLAG_PSOVOL As Int16 = 0
        Private _CPRVCL As Int32 = 0
        Private _NSEQIN As Int32 = 0
        Private _TCMZNA As String = ""
        Private _NRGUSA As Int64 = 0
        Private _NOREMB As String = ""
        Private _CTPOVJ As String = ""
        Private _CTPOV2 As String = ""
        Private _PSOVOL As Double = 0
        Private _NMRGIM As Decimal = 0
        Private _NMOPRP As Int64 = 0
        Private _NMVJCS As Int64 = 0
        Private _NMOPMM As Int64 = 0
        Private _FCHVJC As Int32 = 0
        Private _FCHVJC_S As String = ""
        Private _FLGSTS As String = ""
        Private _NDCORM As Int64 = 0
        Private _QSLCIT As Int32 = 0
        Private _ROPIMG As Byte() = Nothing
        Private _ITEMAN As Int64 = 0
        Private _SSINVJ As String = ""


        'JMC
        Private _FLGSTA As String = ""
        Private _FLGSTA_DESC As String = ""
        Private _USUARIO_ENVIO As String = ""
        Private _USUARIO_APROBADOR As String = ""
        Private _OBSRV_APROBACION As String = ""

        Private _PLANTA_FACT As String = ""    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        Private _CEBED As String = ""
        Private _CECOD As String = ""
        Private _CEBEO As String = ""
        Private _RECURSO_REASIG As String = ""

        'EPARTNER : ROP 2019-02-08
        Private _HRAINI As String = ""
        Private _HRAFIN As String = ""
        Private _CRGVTA As String = ""
        Private _CMNFLTDESC As String = ""
        Private _TPLNTA As String = ""
        Private _FTRTSG As String = ""


        Private _NMRGIM_DESC As String = ""
        Private _APROB_TARIFA As String = ""
 
        Private _APROBSUG As String = ""
        Private _MRGPOR As Decimal = 0
        Private _REFVIAJE As String = ""

        Private _NGUIRS As String = ""
        Private _DNGUIRS As String = ""

        Private _CTDGRT As String = ""
        Private _NGUITS As String = ""

        Private _GENERAR_GT As String = ""
        Private _CTDGRM As String = ""
        Private _CTPCRG As String = ""

        'Private _UBIGEO_ORIGEN As String = ""
        'Private _UBIGEO_DESTINO As String = ""
        Private _NGTSAD As String = ""

        Private _FLGAPA As String = ""
#End Region

#Region "Properties"




        Public Property FLGSTS() As String

            Get
                Return _FLGSTS
            End Get
            Set(ByVal value As String)
                _FLGSTS = value
            End Set
        End Property

        Public Property FCHVJC_S() As String

            Get
                Return _FCHVJC_S
            End Get
            Set(ByVal value As String)
                _FCHVJC_S = value
            End Set
        End Property

        Public Property FCHVJC() As Int32

            Get
                Return _FCHVJC
            End Get
            Set(ByVal value As Int32)
                _FCHVJC = value
            End Set
        End Property

        Public Property NMVJCS() As Int64

            Get
                Return _NMVJCS
            End Get
            Set(ByVal value As Int64)
                _NMVJCS = value
            End Set
        End Property

        Public Property NMOPMM() As Int64

            Get
                Return _NMOPMM
            End Get
            Set(ByVal value As Int64)
                _NMOPMM = value
            End Set
        End Property

        Public Property NMOPRP() As Int64

            Get
                Return _NMOPRP
            End Get
            Set(ByVal value As Int64)
                _NMOPRP = value
            End Set
        End Property

        Public Property NMRGIM() As Int32

            Get
                Return _NMRGIM
            End Get
            Set(ByVal value As Int32)
                _NMRGIM = value
            End Set
        End Property
        Public Property PSOVOL() As Double

            Get
                Return _PSOVOL
            End Get
            Set(ByVal value As Double)
                _PSOVOL = value
            End Set
        End Property

        Public Property CTPOV2() As String

            Get
                Return _CTPOV2
            End Get
            Set(ByVal value As String)
                _CTPOV2 = value
            End Set
        End Property

        Public Property CTPOVJ() As String

            Get
                Return _CTPOVJ
            End Get
            Set(ByVal value As String)
                _CTPOVJ = value
            End Set
        End Property

        Public Property NOREMB() As String

            Get
                Return _NOREMB
            End Get
            Set(ByVal value As String)
                _NOREMB = value
            End Set
        End Property

        Public Property NRGUSA() As Int64

            Get
                Return _NRGUSA
            End Get
            Set(ByVal value As Int64)
                _NRGUSA = value
            End Set
        End Property

        Public Property TCMZNA() As String

            Get
                Return _TCMZNA
            End Get
            Set(ByVal value As String)
                _TCMZNA = value
            End Set
        End Property

        Public Property NSEQIN() As Int32

            Get
                Return _NSEQIN
            End Get
            Set(ByVal value As Int32)
                _NSEQIN = value
            End Set
        End Property

        Public Property FLAG_PSOVOL() As String

            Get
                Return _FLAG_PSOVOL
            End Get
            Set(ByVal value As String)
                _FLAG_PSOVOL = value
            End Set
        End Property

        Public Property NGUIRM_S() As String

            Get
                Return _NGUIRM_S
            End Get
            Set(ByVal value As String)
                _NGUIRM_S = value
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

        Public Property CPRVCL() As Int32

            Get
                Return _CPRVCL
            End Get
            Set(ByVal value As Int32)
                _CPRVCL = value
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

        Public Property TNMMDT() As String

            Get
                Return _TNMMDT
            End Get
            Set(ByVal Value As String)
                _TNMMDT = Value
            End Set
        End Property

        Public Property CPLNDV_S() As String

            Get
                Return _CPLNDV_S
            End Get
            Set(ByVal Value As String)
                _CPLNDV_S = Value
            End Set
        End Property

        Private _FEMVLH_1 As String
        Public Property FEMVLH_1() As String
            Get
                Return _FEMVLH_1
            End Get
            Set(ByVal Value As String)
                _FEMVLH_1 = Value
            End Set
        End Property

        Private _FLGCNL As String
        Public Property FLGCNL() As String
            Get
                Return _FLGCNL
            End Get
            Set(ByVal Value As String)
                _FLGCNL = Value
            End Set
        End Property

        Public Property FEMVLH_S() As String

            Get
                Return _FEMVLH_S
            End Get
            Set(ByVal Value As String)
                _FEMVLH_S = Value
            End Set
        End Property

        Public Property FECETD_S() As String

            Get
                Return _FECETD_S
            End Get
            Set(ByVal Value As String)
                _FECETD_S = Value
            End Set
        End Property

        Public Property FECETA_S() As String

            Get
                Return _FECETA_S
            End Get
            Set(ByVal Value As String)
                _FECETA_S = Value
            End Set
        End Property

        Public Property FCHFTR_S() As String

            Get
                Return _FCHFTR_S
            End Get
            Set(ByVal Value As String)
                _FCHFTR_S = Value
            End Set
        End Property

        Public Property FCHCRT_S() As String

            Get
                Return _FCHCRT_S
            End Get
            Set(ByVal Value As String)
                _FCHCRT_S = Value
            End Set
        End Property

        Public Property HRACRT_S() As String

            Get
                Return _HRACRT_S
            End Get
            Set(ByVal Value As String)
                _HRACRT_S = Value
            End Set
        End Property

        Public Property FULTAC_S() As String

            Get
                Return _FULTAC_S
            End Get
            Set(ByVal Value As String)
                _FULTAC_S = Value
            End Set
        End Property

        Public Property HULTAC_S() As String

            Get
                Return _HULTAC_S
            End Get
            Set(ByVal Value As String)
                _HULTAC_S = Value
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

        Public Property FLLGCM() As Double

            Get
                Return _FLLGCM
            End Get
            Set(ByVal value As Double)
                _FLLGCM = value
            End Set
        End Property

        Public Property FSLDCM() As Double

            Get
                Return _FSLDCM
            End Get
            Set(ByVal value As Double)
                _FSLDCM = value
            End Set
        End Property

        Public Property SRPTRM() As String

            Get
                Return _SRPTRM
            End Get
            Set(ByVal value As String)
                _SRPTRM = value
            End Set
        End Property

        Public Property NRGUCL_S() As String

            Get
                Return _NRGUCL_S
            End Get
            Set(ByVal value As String)
                _NRGUCL_S = value
            End Set
        End Property

        Public Property CTRMNC() As Double

            Get
                Return _CTRMNC
            End Get
            Set(ByVal value As Double)
                _CTRMNC = value
            End Set
        End Property

        Public Property NGUIRM() As Double

            Get
                Return _NGUIRM
            End Get
            Set(ByVal value As Double)
                _NGUIRM = value
            End Set
        End Property

        Public Property FGUIRM() As Double

            Get
                Return _FGUIRM
            End Get
            Set(ByVal value As Double)
                _FGUIRM = value
            End Set
        End Property

        Public Property FGUIRM_S() As String

            Get
                Return _FGUIRM_S
            End Get
            Set(ByVal value As String)
                _FGUIRM_S = value
            End Set
        End Property

        Public Property NPLNMT() As Double

            Get
                Return _NPLNMT
            End Get
            Set(ByVal value As Double)
                _NPLNMT = value
            End Set
        End Property

        Public Property CLCLOR() As Double

            Get
                Return _CLCLOR
            End Get
            Set(ByVal value As Double)
                _CLCLOR = value
            End Set
        End Property

        Public Property CLCLDS() As Double

            Get
                Return _CLCLDS
            End Get
            Set(ByVal value As Double)
                _CLCLDS = value
            End Set
        End Property

        Public Property TDIROR() As String

            Get
                Return _TDIROR
            End Get
            Set(ByVal value As String)
                _TDIROR = value
            End Set
        End Property

        Public Property TDIRDS() As String

            Get
                Return _TDIRDS
            End Get
            Set(ByVal value As String)
                _TDIRDS = value
            End Set
        End Property

        Public Property NOPRCN() As Double

            Get
                Return _NOPRCN
            End Get
            Set(ByVal value As Double)
                _NOPRCN = value
            End Set
        End Property

        Public Property TRFRGU() As String

            Get
                Return _TRFRGU
            End Get
            Set(ByVal value As String)
                _TRFRGU = value
            End Set
        End Property

        Public Property QMRCMC() As Double

            Get
                Return _QMRCMC
            End Get
            Set(ByVal value As Double)
                _QMRCMC = value
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

        Public Property CUNDMD() As String

            Get
                Return _CUNDMD
            End Get
            Set(ByVal Value As String)
                _CUNDMD = Value
            End Set
        End Property

        Public Property QGLGSL() As Double

            Get
                Return _QGLGSL
            End Get
            Set(ByVal Value As Double)
                _QGLGSL = Value
            End Set
        End Property

        Public Property QGLDSL() As Double

            Get
                Return _QGLDSL
            End Get
            Set(ByVal Value As Double)
                _QGLDSL = Value
            End Set
        End Property

        Public Property NRHJCR() As Double

            Get
                Return _NRHJCR
            End Get
            Set(ByVal Value As Double)
                _NRHJCR = Value
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

        Public Property NPLCTR() As String

            Get
                Return _NPLCTR
            End Get
            Set(ByVal Value As String)
                _NPLCTR = Value
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

        Public Property CBRCN2() As String

            Get
                Return _CBRCN2
            End Get
            Set(ByVal Value As String)
                _CBRCN2 = Value
            End Set
        End Property

        Public Property CBRCND2() As String

            Get
                Return _CBRCND2
            End Get
            Set(ByVal Value As String)
                _CBRCND2 = Value
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

        Public Property SACRGO() As String

            Get
                Return _SACRGO
            End Get
            Set(ByVal Value As String)
                _SACRGO = Value
            End Set
        End Property

        Public Property CMNFLT() As Double

            Get
                Return _CMNFLT
            End Get
            Set(ByVal Value As Double)
                _CMNFLT = Value
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

        Public Property FLGADC() As String

            Get
                Return _FLGADC
            End Get
            Set(ByVal Value As String)
                _FLGADC = Value
            End Set
        End Property

        Public Property SIDAVL() As String

            Get
                Return _SIDAVL
            End Get
            Set(ByVal Value As String)
                _SIDAVL = Value
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

        Public Property ICSTRM() As Double

            Get
                Return _ICSTRM
            End Get
            Set(ByVal Value As Double)
                _ICSTRM = Value
            End Set
        End Property

        Public Property QPSOBR() As Double

            Get
                Return _QPSOBR
            End Get
            Set(ByVal Value As Double)
                _QPSOBR = Value
            End Set
        End Property

        Public Property QVLMOR() As Double

            Get
                Return _QVLMOR
            End Get
            Set(ByVal Value As Double)
                _QVLMOR = Value
            End Set
        End Property

        Public Property SMRPLG() As String

            Get
                Return _SMRPLG
            End Get
            Set(ByVal Value As String)
                _SMRPLG = Value
            End Set
        End Property

        Public Property SMRPRC() As String

            Get
                Return _SMRPRC
            End Get
            Set(ByVal Value As String)
                _SMRPRC = Value
            End Set
        End Property

        Public Property IVLPRT() As Double

            Get
                Return _IVLPRT
            End Get
            Set(ByVal Value As Double)
                _IVLPRT = Value
            End Set
        End Property

        Public Property CMNVLP() As Double

            Get
                Return _CMNVLP
            End Get
            Set(ByVal Value As Double)
                _CMNVLP = Value
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

        Public Property USRCRT() As String

            Get
                Return _USRCRT
            End Get
            Set(ByVal Value As String)
                _USRCRT = Value
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

        Public Property FULTAC() As Double

            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As Double)
                _FULTAC = Value
            End Set
        End Property

        Public Property HULTAC() As Double

            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As Double)
                _HULTAC = Value
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

        Public Property NTRMNL() As String

            Get
                Return _NTRMNL
            End Get
            Set(ByVal Value As String)
                _NTRMNL = Value
            End Set
        End Property

        Public Property CUBORI() As Double

            Get
                Return _CUBORI
            End Get
            Set(ByVal Value As Double)
                _CUBORI = Value
            End Set
        End Property

        Public Property CUBDES() As Double

            Get
                Return _CUBDES
            End Get
            Set(ByVal Value As Double)
                _CUBDES = Value
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

        Public Property FCHFTR() As Double

            Get
                Return _FCHFTR
            End Get
            Set(ByVal Value As Double)
                _FCHFTR = Value
            End Set
        End Property

        Public Property FECETD() As Double

            Get
                Return _FECETD
            End Get
            Set(ByVal Value As Double)
                _FECETD = Value
            End Set
        End Property

        Public Property FECETA() As Double

            Get
                Return _FECETA
            End Get
            Set(ByVal Value As Double)
                _FECETA = Value
            End Set
        End Property

        Public Property NESTDO() As Double

            Get
                Return _NESTDO
            End Get
            Set(ByVal Value As Double)
                _NESTDO = Value
            End Set
        End Property

        Public Property NRSERI() As Double

            Get
                Return _NRSERI
            End Get
            Set(ByVal Value As Double)
                _NRSERI = Value
            End Set
        End Property

        Public Property NPRGUI() As Double

            Get
                Return _NPRGUI
            End Get
            Set(ByVal Value As Double)
                _NPRGUI = Value
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

        Public Property CCLNT() As Double

            Get
                Return _CCLNT
            End Get
            Set(ByVal Value As Double)
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

        Public Property NRGUCL() As Double

            Get
                Return _NRGUCL
            End Get
            Set(ByVal Value As Double)
                _NRGUCL = Value
            End Set
        End Property

        Public Property FCGUCL() As Double

            Get
                Return _FCGUCL
            End Get
            Set(ByVal Value As Double)
                _FCGUCL = Value
            End Set
        End Property

        Public Property FCGUCL_S() As String

            Get
                Return _FCGUCL_S
            End Get
            Set(ByVal Value As String)
                _FCGUCL_S = Value
            End Set
        End Property

        Public Property NGUIAD() As Double

            Get
                Return _NGUIAD
            End Get
            Set(ByVal Value As Double)
                _NGUIAD = Value
            End Set
        End Property

        Public Property NORCML() As String

            Get
                Return _NORCML
            End Get
            Set(ByVal Value As String)
                _NORCML = Value
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

        Public Property TOBS() As String

            Get
                Return _TOBS
            End Get
            Set(ByVal value As String)
                _TOBS = value
            End Set
        End Property

        Public Property NORSRT() As String

            Get
                Return _NORSRT
            End Get
            Set(ByVal value As String)
                _NORSRT = value
            End Set
        End Property

        Public Property CUBORI_S() As String

            Get
                Return _CUBORI_S
            End Get
            Set(ByVal value As String)
                _CUBORI_S = value
            End Set
        End Property

        Public Property CUBDES_S() As String

            Get
                Return _CUBDES_S
            End Get
            Set(ByVal value As String)
                _CUBDES_S = value
            End Set
        End Property

        Public Property TCNFG1() As String

            Get
                Return _TCNFG1
            End Get
            Set(ByVal value As String)
                _TCNFG1 = value
            End Set
        End Property

        Public Property TCNFG2() As String

            Get
                Return _TCNFG2
            End Get
            Set(ByVal value As String)
                _TCNFG2 = value
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

        Public Property CCNCST() As String

            Get
                Return _CCNCST
            End Get
            Set(ByVal value As String)
                _CCNCST = value
            End Set
        End Property

        Public Property TDSCAR() As String

            Get
                Return _TDSCAR
            End Get
            Set(ByVal value As String)
                _TDSCAR = value
            End Set
        End Property

        Public Property TCMTRT() As String

            Get
                Return _TCMTRT
            End Get
            Set(ByVal value As String)
                _TCMTRT = value
            End Set
        End Property

        Public Property TCMLCO() As String

            Get
                Return _TCMLCO
            End Get
            Set(ByVal value As String)
                _TCMLCO = value
            End Set
        End Property

        Public Property TCMLCD() As String

            Get
                Return _TCMLCD
            End Get
            Set(ByVal value As String)
                _TCMLCD = value
            End Set
        End Property

        Public Property CMRCDR() As Int32

            Get
                Return _CMRCDR
            End Get
            Set(ByVal value As Int32)
                _CMRCDR = value
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

        Public Property SESGRP() As String

            Get
                Return _SESGRP
            End Get
            Set(ByVal value As String)
                _SESGRP = value
            End Set
        End Property

        Public Property NMGUIR() As Double

            Get
                Return _NMGUIR
            End Get
            Set(ByVal value As Double)
                _NMGUIR = value
            End Set
        End Property

        Public Property CHECK() As Boolean

            Get
                Return _CHECK
            End Get
            Set(ByVal value As Boolean)
                _CHECK = value
            End Set
        End Property

        Public Property QSLCIT() As Int32

            Get
                Return _QSLCIT
            End Get
            Set(ByVal value As Int32)
                _QSLCIT = value
            End Set
        End Property

        Public Property NDCORM() As Int64

            Get
                Return _NDCORM
            End Get
            Set(ByVal value As Int64)
                _NDCORM = value
            End Set
        End Property

        Public Property ROPIMG() As Byte()
            Get
                Return _ROPIMG
            End Get
            Set(ByVal value As Byte())
                _ROPIMG = value
            End Set
        End Property

        Public Property ITEMAN() As Int64
            Get
                Return _ITEMAN
            End Get
            Set(ByVal value As Int64)
                _ITEMAN = value
            End Set
        End Property

        Public Property SSINVJ() As String
            Get
                Return _SSINVJ
            End Get
            Set(ByVal value As String)
                _SSINVJ = value
            End Set
        End Property

        'JMC
        Public Property FLGSTA() As String
            Get
                Return _FLGSTA
            End Get
            Set(ByVal value As String)
                _FLGSTA = value
            End Set
        End Property

        Public Property FLGSTA_DESC() As String
            Get
                Return _FLGSTA_DESC
            End Get
            Set(ByVal value As String)
                _FLGSTA_DESC = value
            End Set
        End Property


        Public Property USUARIO_ENVIO() As String
            Get
                Return _USUARIO_ENVIO
            End Get
            Set(ByVal value As String)
                _USUARIO_ENVIO = value
            End Set
        End Property

        Public Property USUARIO_APROBADOR() As String
            Get
                Return _USUARIO_APROBADOR
            End Get
            Set(ByVal value As String)
                _USUARIO_APROBADOR = value
            End Set
        End Property

        Public Property OBSRV_APROBACION() As String
            Get
                Return _OBSRV_APROBACION
            End Get
            Set(ByVal value As String)
                _OBSRV_APROBACION = value
            End Set
        End Property

        Dim _COD_AR_RESP As Integer = 0
        Public Property COD_AR_RESP() As Integer
            Get
                Return _COD_AR_RESP
            End Get
            Set(ByVal value As Integer)
                _COD_AR_RESP = value
            End Set
        End Property

        Dim _ARE_RESP As String = ""
        Public Property ARE_RESP() As String
            Get
                Return _ARE_RESP
            End Get
            Set(ByVal value As String)
                _ARE_RESP = value
            End Set
        End Property

        '----------------
        Private _FSTENV As String
        Public Property FSTENV() As String
            Get
                Return _FSTENV
            End Get
            Set(ByVal value As String)
                _FSTENV = value
            End Set
        End Property


        Private _STATUS_ENVIO As String
        Public Property STATUS_ENVIO() As String
            Get
                Return _STATUS_ENVIO

            End Get
            Set(ByVal value As String)
                _STATUS_ENVIO = value

            End Set
        End Property


        Private _MSTENV As String
        Public Property MSTENV() As String
            Get
                Return _MSTENV

            End Get
            Set(ByVal value As String)
                _MSTENV = value

            End Set
        End Property


        Private _MSTEN2 As String
        Public Property MSTEN2() As String
            Get
                Return _MSTEN2
            End Get
            Set(ByVal value As String)
                _MSTEN2 = value
            End Set
        End Property









        Private _FLGGTI As String
        Public Property FLGGTI() As String
            Get

                Return _FLGGTI
            End Get
            Set(ByVal value As String)

                _FLGGTI = value
            End Set
        End Property


        Private _CECOTI As String
        Public Property CECOTI() As String
            Get

                Return _CECOTI
            End Get
            Set(ByVal value As String)

                _CECOTI = value
            End Set
        End Property
 
        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        Public Property PLANTA_FACT() As String
            Get
                Return _PLANTA_FACT
            End Get
            Set(ByVal value As String)
                _PLANTA_FACT = value
            End Set
        End Property
        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN


        Public Property CEBED() As String
            Get
                Return _CEBED
            End Get
            Set(ByVal value As String)
                _CEBED = value
            End Set
        End Property
        Public Property CECOD() As String
            Get
                Return _CECOD
            End Get
            Set(ByVal value As String)
                _CECOD = value
            End Set
        End Property
        Public Property CEBEO() As String
            Get
                Return _CEBEO
            End Get
            Set(ByVal value As String)
                _CEBEO = value
            End Set
        End Property

         Public Property RECURSO_REASIG() As String
            Get
                Return _RECURSO_REASIG
            End Get
            Set(ByVal value As String)
                _RECURSO_REASIG = value
            End Set
        End Property


        ' EPARTNER :  ROP 2019-02-08
        Public Property HRAINI() As String
            Get
                Return _HRAINI
            End Get
            Set(ByVal value As String)
                _HRAINI = value
            End Set
        End Property
        Public Property HRAFIN() As String
            Get
                Return _HRAFIN
            End Get
            Set(ByVal value As String)
                _HRAFIN = value
            End Set
        End Property


        Private _UBIGEO_O As String = ""
        Public Property UBIGEO_O() As String
            Get
                Return _UBIGEO_O
            End Get
            Set(ByVal value As String)
                _UBIGEO_O = value
            End Set
        End Property

        Private _UBIGEO_D As String = ""
        Public Property UBIGEO_D() As String
            Get
                Return _UBIGEO_D
            End Get
            Set(ByVal value As String)
                _UBIGEO_D = value
            End Set
        End Property

        'MONEDA_FLETE
        Private _MONEDA_FLETE As String = ""
        Public Property MONEDA_FLETE() As String
            Get
                Return _MONEDA_FLETE
            End Get
            Set(ByVal value As String)
                _MONEDA_FLETE = value
            End Set
        End Property


        'Private _UNI_MED As String = ""
        'Public Property UNI_MED() As String
        '    Get
        '        Return _UNI_MED
        '    End Get
        '    Set(ByVal value As String)
        '        _UNI_MED = value
        '    End Set
        'End Property

        Private _PLANTA As String = ""
        ' 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        Public Property PLANTA() As String
            Get
                Return _PLANTA
            End Get
            Set(ByVal value As String)
                _PLANTA = value
            End Set
        End Property
        ' 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        Public Property CRGVTA() As String
            Get
                Return _CRGVTA
            End Get
            Set(ByVal value As String)
                _CRGVTA = value
            End Set
        End Property


        Public Property CMNFLTDESC() As String
            Get
                Return _CMNFLTDESC
            End Get
            Set(ByVal value As String)
                _CMNFLTDESC = value
            End Set
        End Property

        '

        'Public Property CMNFLTDESC() As String
        '    Get
        '        Return _CMNFLTDESC
        '    End Get
        '    Set(ByVal value As String)
        '        _CMNFLTDESC = value
        '    End Set
        'End Property



        'Private _CPLNDV_DESC As String = ""
        'Public Property CPLNDV_DESC() As String
        '    Get
        '        Return _CPLNDV_DESC
        '    End Get
        '    Set(ByVal value As String)
        '        _CPLNDV_DESC = value
        '    End Set
        'End Property
        Private _CUNDMD_DESC As String = ""
        Public Property CUNDMD_DESC() As String
            Get
                Return _CUNDMD_DESC
            End Get
            Set(ByVal value As String)
                _CUNDMD_DESC = value
            End Set
        End Property

        Public Property TPLNTA() As String
            Get
                Return _TPLNTA
            End Get
            Set(ByVal value As String)
                _TPLNTA = value
            End Set
        End Property

        Public Property FTRTSG() As String
            Get
                Return _FTRTSG
            End Get
            Set(ByVal value As String)
                _FTRTSG = value
            End Set
        End Property

        Public Property NMRGIM_DESC() As String
            Get
                Return _NMRGIM_DESC
            End Get
            Set(ByVal value As String)
                _NMRGIM_DESC = value
            End Set
        End Property

        Public Property APROB_TARIFA() As String
            Get
                Return _APROB_TARIFA
            End Get
            Set(ByVal value As String)
                _APROB_TARIFA = value
            End Set
        End Property
        Public Property APROBSUG() As String
            Get
                Return _APROBSUG
            End Get
            Set(ByVal value As String)
                _APROBSUG = value
            End Set
        End Property

        Public Property MRGPOR() As Decimal
            Get
                Return _MRGPOR
            End Get
            Set(ByVal value As Decimal)
                _MRGPOR = value
            End Set
        End Property
        '
        Public Property REFVIAJE() As String
            Get
                Return _REFVIAJE
            End Get
            Set(ByVal value As String)
                _REFVIAJE = value
            End Set
        End Property

        Public Property NGUIRS() As String
            Get
                Return _NGUIRS
            End Get
            Set(ByVal value As String)
                _NGUIRS = value
            End Set
        End Property
        Public Property DNGUIRS() As String
            Get
                Return _DNGUIRS
            End Get
            Set(ByVal value As String)
                _DNGUIRS = value
            End Set
        End Property

        Public Property CTDGRT() As String
            Get
                Return _CTDGRT
            End Get
            Set(ByVal value As String)
                _CTDGRT = value
            End Set
        End Property
        Public Property NGUITS() As String
            Get
                Return _NGUITS
            End Get
            Set(ByVal value As String)
                _NGUITS = value
            End Set
        End Property

        Public Property GENERAR_GT() As String
            Get
                Return _GENERAR_GT
            End Get
            Set(ByVal value As String)
                _GENERAR_GT = value
            End Set
        End Property
        Public Property CTDGRM() As String
            Get
                Return _CTDGRM
            End Get
            Set(ByVal value As String)
                _CTDGRM = value
            End Set
        End Property

        Public Property CTPCRG() As String
            Get
                Return _CTPCRG
            End Get
            Set(ByVal value As String)
                _CTPCRG = value
            End Set
        End Property

        Public Property NGTSAD() As String
            Get
                Return _NGTSAD
            End Get
            Set(ByVal value As String)
                _NGTSAD = value
            End Set
        End Property

        Public Property FLGAPA() As String
            Get
                Return _FLGAPA
            End Get
            Set(ByVal value As String)
                _FLGAPA = value
            End Set
        End Property



        'Public Property UBIGEO_ORIGEN() As String
        '    Get
        '        Return _UBIGEO_ORIGEN
        '    End Get
        '    Set(ByVal value As String)
        '        _UBIGEO_ORIGEN = value
        '    End Set
        'End Property
        'Public Property UBIGEO_DESTINO() As String
        '    Get
        '        Return _UBIGEO_DESTINO
        '    End Get
        '    Set(ByVal value As String)
        '        _UBIGEO_DESTINO = value
        '    End Set
        'End Property


       

#End Region

    End Class

End Namespace
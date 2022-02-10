Public Class beMercaderia
    Inherits beBase(Of beMercaderia)
    Private _PNCCLNT As Decimal
    Private _PSCMRCLR As String
    Private _PSCFMCLR As String
    Private _PSCGRCLR As String
    Private _PSCMRCRR As String
    Private _PSCMRCD As String
    Private _PSTMRCD2 As String
    Private _PSTMRCD3 As String

    Private _PNCMNCT As Decimal
    Private _PNQIMCT As Decimal
    Private _PNQIMCTP As Decimal
    Private _PSMARCRE As String
    Private _PNQICOPS As Decimal
    Private _PNIMVTA As Decimal
    Private _PNIMVTAS As Decimal
    Private _PNIMVLM2 As Decimal
    Private _PNPDSCTO As Decimal
    Private _PSTMRCTR As String
    Private _PSUBICA1 As String
    Private _PSTOBSRV As String
    Private _PNQMRSRC As Decimal
    Private _PNQMRSRP As Decimal
    Private _PNQMRODC As Decimal
    Private _PNQMRODP As Decimal
    Private _PNQMRPRD As Decimal
    Private _PNQLRGMR As Decimal
    Private _PNQANCMR As Decimal
    Private _PNQALTMR As Decimal
    Private _PNQARMT2 As Decimal
    Private _PNQARMT3 As Decimal
    Private _PNQVOLEQ As Decimal
    Private _PNQPSODC As Decimal
    Private _PNQTMPCR As Decimal
    Private _PNQTMPDS As Decimal
    Private _PSCUNCNC As String
    Private _PSCUNCNI As String
    Private _PSFPUWEB As String
    Private _PNFVNCMR As Decimal
    Private _PNFINVRN As Decimal
    Private _PSCPRFMR As String
    Private _PSCINFMR As String
    Private _PSCROTMR As String
    Private _PSCAPIMR As String
    Private _PSDUN14 As String
    Private _PSEAN13 As String
    Private _PSCPTDAR As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSCULUSA As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal
    Private _PSTGRCLR As String
    Private _PSSITUAC As String
    Private _PNSALDO As Decimal
    Private _PSTFMCLR As String
    Private _PNQSLMP As Decimal
    Private _PSCUNCN5 As String
    Private _PSCUNPS5 As String
    Private _PNNORDSR As Decimal
    Private _PSCSRECL As String
    Private _PNFECHA_I As String
    Private _PNFECHA_F As String
    Private _PSTCMPCL As String
    Private _PNQCMMC As Decimal
    Private _PNQCMMP As Decimal
    Private _QCMMV As Decimal
    Private _PSDEPOSITO As String
    Private _PNSALDO_QSLMC As Decimal
    Private _PNQSERIESXMERCADERIA As Decimal
    Private _PNQUBICADOSXMERCADERIA As Decimal

    Private _PSCSECTR As String
    Private _PSCPSCN As String
    Private _PSCPSLL As String
    Private _PSCCLMN As String
    Private _PNQSLETQ As Decimal
    Private _PSNORCCL As String
    Private _PNTDSDES As String
    Private _PSTPLNTA As String

    Private _PNNCRRSL As Decimal
    Private _PNCANT_OS As Decimal = 0



    Private _PSCRTLTE As String
    Public Property PSCRTLTE() As String
        Get
            Return _PSCRTLTE
        End Get
        Set(ByVal value As String)
            _PSCRTLTE = value
        End Set
    End Property

 

    Private _PNFPRDMR As Decimal
    Public Property PNFPRDMR() As Decimal
        Get
            Return _PNFPRDMR
        End Get
        Set(ByVal value As Decimal)
            _PNFPRDMR = value
        End Set
    End Property


    Private _PNFVNLTE As Decimal
    Public Property PNFVNLTE() As Decimal
        Get
            Return _PNFVNLTE
        End Get
        Set(ByVal value As Decimal)
            _PNFVNLTE = value
        End Set
    End Property

    Public ReadOnly Property Fecha_Produccion() As String
        Get
            Return NumeroAFecha(_PNFPRDMR)
        End Get
    End Property

    Public ReadOnly Property Fecha_Vencimiento() As String
        Get
            Return NumeroAFecha(_PNFVNLTE)
        End Get
    End Property
    Public ReadOnly Property Fecha_Ingreso_Almacen() As String
        Get
            Return NumeroAFecha(_PSFINGAL)
        End Get
    End Property


   


#Region "LISTA DE PEDIDOS"

    Public Property PNNCRRSL() As Decimal
        Get
            Return _PNNCRRSL
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRSL = value
        End Set
    End Property


    Private _PNNCRRIN As Decimal
    Public Property PNNCRRIN() As Decimal
        Get
            Return _PNNCRRIN
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRIN = value
        End Set
    End Property


    Private _PSCUNCN6 As String
    Public Property PSCUNCN6() As String
        Get
            Return _PSCUNCN6
        End Get
        Set(ByVal value As String)
            _PSCUNCN6 = value
        End Set
    End Property

    Private _PNQSRVC As Decimal

    Public Property PNQSRVC() As Decimal
        Get
            Return _PNQSRVC
        End Get
        Set(ByVal value As Decimal)
            _PNQSRVC = value
        End Set
    End Property

    Private _PNCDPEPL As Decimal
    Public Property PNCDPEPL() As Decimal
        Get
            Return _PNCDPEPL
        End Get
        Set(ByVal value As Decimal)
            _PNCDPEPL = value
        End Set
    End Property

    Private _PNCDREGP As Decimal
    Public Property PNCDREGP() As Decimal
        Get
            Return _PNCDREGP
        End Get
        Set(ByVal value As Decimal)
            _PNCDREGP = value
        End Set
    End Property


    Private _PSFCHSPE As String
    Public Property PSFCHSPE() As String
        Get
            Return _PSFCHSPE
        End Get
        Set(ByVal value As String)
            _PSFCHSPE = value
        End Set
    End Property

    Private _PSPLANTA As String
    Public Property PSPLANTA() As String
        Get
            Return _PSPLANTA
        End Get
        Set(ByVal value As String)
            _PSPLANTA = value
        End Set
    End Property


    Private _PSCLIENTE As String
    Public Property PSCLIENTE() As String
        Get
            Return _PSCLIENTE
        End Get
        Set(ByVal value As String)
            _PSCLIENTE = value
        End Set
    End Property


    Private _PSTIPO As String
    Public Property PSTIPO() As String
        Get
            Return _PSTIPO
        End Get
        Set(ByVal value As String)
            _PSTIPO = value
        End Set
    End Property


    Private _PNQDSMC As Decimal
    Public Property PNQDSMC() As Decimal
        Get
            Return _PNQDSMC
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMC = value
        End Set
    End Property


    Private _PNPSRVC As Decimal
    Public Property PNPSRVC() As Decimal
        Get
            Return _PNPSRVC
        End Get
        Set(ByVal value As Decimal)
            _PNPSRVC = value
        End Set
    End Property


    Private _PNQDSMP As Decimal
    Public Property PNQDSMP() As Decimal
        Get
            Return _PNQDSMP
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMP = value
        End Set
    End Property

    Private _PSSATSLS As String
    Public Property PSSATSLS() As String
        Get
            Return _PSSATSLS
        End Get
        Set(ByVal value As String)
            _PSSATSLS = value
        End Set
    End Property
#End Region


    Public Property PSNORCCL() As String
        Get
            Return (_PSNORCCL)
        End Get
        Set(ByVal value As String)
            _PSNORCCL = value
        End Set
    End Property

    Public Property PNTDSDES() As String
        Get
            Return (_PNTDSDES)
        End Get
        Set(ByVal value As String)
            _PNTDSDES = value
        End Set
    End Property

    Public Property PSTPLNTA() As String
        Get
            Return (_PSTPLNTA)
        End Get
        Set(ByVal value As String)
            _PSTPLNTA = value
        End Set
    End Property


    Private _PSNGUICL As String
    Public Property PSNGUICL() As String
        Get
            Return _PSNGUICL
        End Get
        Set(ByVal value As String)
            _PSNGUICL = value
        End Set
    End Property


    Private _PSNRUCLL As String
    Public Property PSNRUCLL() As String
        Get
            Return _PSNRUCLL
        End Get
        Set(ByVal value As String)
            _PSNRUCLL = value
        End Set
    End Property


    Private _PSSTPING As String
    Public Property PSSTPING() As String
        Get
            Return _PSSTPING
        End Get
        Set(ByVal value As String)
            _PSSTPING = value
        End Set
    End Property


    Private _PNNSLCRF As Decimal
    Public Property PNNSLCRF() As Decimal
        Get
            Return _PNNSLCRF
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCRF = value
        End Set
    End Property


    Private _PSTIPORG As String
    Public Property PSTIPORG() As String
        Get
            Return _PSTIPORG
        End Get
        Set(ByVal value As String)
            _PSTIPORG = value
        End Set
    End Property


    Private _PSTIPORI As String
    Public Property PSTIPORI() As String
        Get
            Return _PSTIPORI
        End Get
        Set(ByVal value As String)
            _PSTIPORI = value
        End Set
    End Property


    Private _PSCPRVCL As String
    Public Property PSCPRVCL() As String
        Get
            Return _PSCPRVCL
        End Get
        Set(ByVal value As String)
            _PSCPRVCL = value
        End Set
    End Property


    Private _PSSCNEMB As String
    Public Property PSSCNEMB() As String
        Get
            Return _PSSCNEMB
        End Get
        Set(ByVal value As String)
            _PSSCNEMB = value
        End Set
    End Property


    Private _PNFRLZSR As Int64
    Public Property PNFRLZSR() As Int64
        Get
            Return _PNFRLZSR
        End Get
        Set(ByVal value As Int64)
            _PNFRLZSR = value
        End Set
    End Property

    Public Property PNQSLETQ() As Decimal
        Get
            Return (_PNQSLETQ)
        End Get
        Set(ByVal value As Decimal)
            _PNQSLETQ = value
        End Set
    End Property

    Public Property PSCSECTR() As String
        Get
            Return (_PSCSECTR)
        End Get
        Set(ByVal value As String)
            _PSCSECTR = value
        End Set
    End Property
    Public Property PSCPSCN() As String
        Get
            Return (_PSCPSCN)
        End Get
        Set(ByVal value As String)
            _PSCPSCN = value
        End Set
    End Property
    Public Property PSCPSLL() As String
        Get
            Return (_PSCPSLL)
        End Get
        Set(ByVal value As String)
            _PSCPSLL = value
        End Set
    End Property


    Public Property PNQUBICADOSXMERCADERIA() As Decimal
        Get
            Return _PNQUBICADOSXMERCADERIA
        End Get
        Set(ByVal value As Decimal)
            _PNQUBICADOSXMERCADERIA = value
        End Set
    End Property


    Public Property PNQSERIESXMERCADERIA() As Decimal
        Get
            Return _PNQSERIESXMERCADERIA
        End Get
        Set(ByVal value As Decimal)
            _PNQSERIESXMERCADERIA = value
        End Set
    End Property


    Public Property PNSALDO_QSLMC() As Decimal
        Get
            Return _PNSALDO_QSLMC
        End Get
        Set(ByVal value As Decimal)
            _PNSALDO_QSLMC = value
        End Set
    End Property


    Public Property PNQCMMC() As Decimal
        Get
            Return _PNQCMMC
        End Get
        Set(ByVal value As Decimal)
            _PNQCMMC = value
        End Set
    End Property




    Public Property PNQCMMP() As Decimal
        Get
            Return _PNQCMMP
        End Get
        Set(ByVal value As Decimal)
            _PNQCMMP = value
        End Set
    End Property




    Public Property PNQCMMV() As Decimal
        Get
            Return _QCMMV
        End Get
        Set(ByVal value As Decimal)
            _QCMMV = value
        End Set
    End Property
    Private _PSFINGAL As String
    Private _PSFSLDAL As String
    'Private _PNSSTINV As Int32


    'Public Property PNSSTINV() As Int32
    '    Get
    '        Return _PNSSTINV
    '    End Get
    '    Set(ByVal value As Int32)
    '        _PNSSTINV = value
    '    End Set
    'End Property

    Public Property PSFINGAL() As String
        Get
            Return _PSFINGAL
        End Get
        Set(ByVal value As String)
            _PSFINGAL = value
        End Set
    End Property

    Public Property PSFSLDAL() As String
        Get
            Return _PSFSLDAL
        End Get
        Set(ByVal value As String)
            _PSFSLDAL = value
        End Set
    End Property


    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Private _psCTPOAT As String
    Public Property psCTPOAT() As String
        Get
            Return _psCTPOAT
        End Get
        Set(ByVal value As String)
            _psCTPOAT = value
        End Set
    End Property


    Public Property FECHA_I() As String
        Get
            Return _PNFECHA_I
        End Get
        Set(ByVal value As String)
            _PNFECHA_I = value
        End Set
    End Property

    Public Property FECHA_F() As String
        Get
            Return _PNFECHA_F
        End Get
        Set(ByVal value As String)
            _PNFECHA_F = value
        End Set
    End Property

    Public Property PSCSRECL() As String
        Get
            Return _PSCSRECL
        End Get
        Set(ByVal value As String)
            _PSCSRECL = value
        End Set
    End Property


    Private _PSTDSMDL As String
    Public Property PSTDSMDL() As String
        Get
            Return _PSTDSMDL
        End Get
        Set(ByVal value As String)
            _PSTDSMDL = value
        End Set
    End Property



    Private _PNNCRPLL As Decimal
    Public Property PNNCRPLL() As Decimal
        Get
            Return _PNNCRPLL
        End Get
        Set(ByVal value As Decimal)
            _PNNCRPLL = value
        End Set
    End Property

    Public Property PNQSLMP() As Decimal
        Get
            Return _PNQSLMP
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMP = value
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



    Public Property PSCUNPS5() As String
        Get
            Return _PSCUNPS5
        End Get
        Set(ByVal value As String)
            _PSCUNPS5 = value
        End Set
    End Property


    Public Property PNNORDSR() As Decimal
        Get
            Return _PNNORDSR
        End Get
        Set(ByVal value As Decimal)
            _PNNORDSR = value
        End Set
    End Property

    Public Property PSSITUAC() As String
        Get
            Return _PSSITUAC
        End Get
        Set(ByVal value As String)
            _PSSITUAC = value
        End Set
    End Property

    Public Property PNSALDO() As Decimal
        Get
            Return _PNSALDO
        End Get
        Set(ByVal value As Decimal)
            _PNSALDO = value
        End Set
    End Property

    Public Property PSTGRCLR() As String
        Get
            Return _PSTGRCLR
        End Get
        Set(ByVal value As String)
            _PSTGRCLR = value
        End Set
    End Property

    Public Property PSTFMCLR() As String
        Get
            Return _PSTFMCLR
        End Get
        Set(ByVal value As String)
            _PSTFMCLR = value
        End Set
    End Property

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PSCMRCLR() As String
        Get
            Return (_PSCMRCLR)
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = value
        End Set
    End Property
    Public Property PSCFMCLR() As String
        Get
            Return (_PSCFMCLR)
        End Get
        Set(ByVal value As String)
            _PSCFMCLR = value
        End Set
    End Property
    Public Property PSCGRCLR() As String
        Get
            Return (_PSCGRCLR)
        End Get
        Set(ByVal value As String)
            _PSCGRCLR = value
        End Set
    End Property
    Public Property PSCMRCRR() As String
        Get
            Return (_PSCMRCRR)
        End Get
        Set(ByVal value As String)
            _PSCMRCRR = value
        End Set
    End Property
    Public Property PSCMRCD() As String
        Get
            Return (_PSCMRCD)
        End Get
        Set(ByVal value As String)
            _PSCMRCD = value
        End Set
    End Property
    Public Property PSTMRCD2() As String
        Get
            Return (_PSTMRCD2)
        End Get
        Set(ByVal value As String)
            _PSTMRCD2 = value
        End Set
    End Property
    Public Property PSTMRCD3() As String
        Get
            Return (_PSTMRCD3)
        End Get
        Set(ByVal value As String)
            _PSTMRCD3 = value
        End Set
    End Property

    Public Property PNCMNCT() As Decimal
        Get
            Return (_PNCMNCT)
        End Get
        Set(ByVal value As Decimal)
            _PNCMNCT = value
        End Set
    End Property
    Public Property PNQIMCT() As Decimal
        Get
            Return (_PNQIMCT)
        End Get
        Set(ByVal value As Decimal)
            _PNQIMCT = value
        End Set
    End Property
    Public Property PNQIMCTP() As Decimal
        Get
            Return (_PNQIMCTP)
        End Get
        Set(ByVal value As Decimal)
            _PNQIMCTP = value
        End Set
    End Property
    Public Property PSMARCRE() As String
        Get
            Return (_PSMARCRE)
        End Get
        Set(ByVal value As String)
            _PSMARCRE = value
        End Set
    End Property
    Public Property PNQICOPS() As Decimal
        Get
            Return (_PNQICOPS)
        End Get
        Set(ByVal value As Decimal)
            _PNQICOPS = value
        End Set
    End Property
    Public Property PNIMVTA() As Decimal
        Get
            Return (_PNIMVTA)
        End Get
        Set(ByVal value As Decimal)
            _PNIMVTA = value
        End Set
    End Property
    Public Property PNIMVTAS() As Decimal
        Get
            Return (_PNIMVTAS)
        End Get
        Set(ByVal value As Decimal)
            _PNIMVTAS = value
        End Set
    End Property
    Public Property PNIMVLM2() As Decimal
        Get
            Return (_PNIMVLM2)
        End Get
        Set(ByVal value As Decimal)
            _PNIMVLM2 = value
        End Set
    End Property
    Public Property PNPDSCTO() As Decimal
        Get
            Return (_PNPDSCTO)
        End Get
        Set(ByVal value As Decimal)
            _PNPDSCTO = value
        End Set
    End Property
    Public Property PSTMRCTR() As String
        Get
            Return (_PSTMRCTR)
        End Get
        Set(ByVal value As String)
            _PSTMRCTR = value
        End Set
    End Property
    Public Property PSUBICA1() As String
        Get
            Return (_PSUBICA1)
        End Get
        Set(ByVal value As String)
            _PSUBICA1 = value
        End Set
    End Property
    Public Property PSTOBSRV() As String
        Get
            Return (_PSTOBSRV)
        End Get
        Set(ByVal value As String)
            _PSTOBSRV = value
        End Set
    End Property
    Public Property PNQMRSRC() As Decimal
        Get
            Return (_PNQMRSRC)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRSRC = value
        End Set
    End Property
    Public Property PNQMRSRP() As Decimal
        Get
            Return (_PNQMRSRP)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRSRP = value
        End Set
    End Property
    Public Property PNQMRODC() As Decimal
        Get
            Return (_PNQMRODC)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRODC = value
        End Set
    End Property
    Public Property PNQMRODP() As Decimal
        Get
            Return (_PNQMRODP)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRODP = value
        End Set
    End Property
    Public Property PNQMRPRD() As Decimal
        Get
            Return (_PNQMRPRD)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRPRD = value
        End Set
    End Property
    Public Property PNQLRGMR() As Decimal
        Get
            Return (_PNQLRGMR)
        End Get
        Set(ByVal value As Decimal)
            _PNQLRGMR = value
        End Set
    End Property
    Public Property PNQANCMR() As Decimal
        Get
            Return (_PNQANCMR)
        End Get
        Set(ByVal value As Decimal)
            _PNQANCMR = value
        End Set
    End Property
    Public Property PNQALTMR() As Decimal
        Get
            Return (_PNQALTMR)
        End Get
        Set(ByVal value As Decimal)
            _PNQALTMR = value
        End Set
    End Property
    Public Property PNQARMT2() As Decimal
        Get
            Return (_PNQARMT2)
        End Get
        Set(ByVal value As Decimal)
            _PNQARMT2 = value
        End Set
    End Property
    Public Property PNQARMT3() As Decimal
        Get
            Return (_PNQARMT3)
        End Get
        Set(ByVal value As Decimal)
            _PNQARMT3 = value
        End Set
    End Property
    Public Property PNQVOLEQ() As Decimal
        Get
            Return (_PNQVOLEQ)
        End Get
        Set(ByVal value As Decimal)
            _PNQVOLEQ = value
        End Set
    End Property
    Public Property PNQPSODC() As Decimal
        Get
            Return (_PNQPSODC)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSODC = value
        End Set
    End Property
    Public Property PNQTMPCR() As Decimal
        Get
            Return (_PNQTMPCR)
        End Get
        Set(ByVal value As Decimal)
            _PNQTMPCR = value
        End Set
    End Property
    Public Property PNQTMPDS() As Decimal
        Get
            Return (_PNQTMPDS)
        End Get
        Set(ByVal value As Decimal)
            _PNQTMPDS = value
        End Set
    End Property
    Public Property PSCUNCNC() As String
        Get
            Return (_PSCUNCNC)
        End Get
        Set(ByVal value As String)
            _PSCUNCNC = value
        End Set
    End Property
    Public Property PSCUNCNI() As String
        Get
            Return (_PSCUNCNI)
        End Get
        Set(ByVal value As String)
            _PSCUNCNI = value
        End Set
    End Property
    Public Property PSFPUWEB() As String
        Get
            Return (_PSFPUWEB)
        End Get
        Set(ByVal value As String)
            _PSFPUWEB = value
        End Set
    End Property
    Public Property PNFVNCMR() As Decimal
        Get
            Return (_PNFVNCMR)
        End Get
        Set(ByVal value As Decimal)
            _PNFVNCMR = value
        End Set
    End Property
    Public Property PNFINVRN() As Decimal
        Get
            Return (_PNFINVRN)
        End Get
        Set(ByVal value As Decimal)
            _PNFINVRN = value
        End Set
    End Property
    Public Property PSCPRFMR() As String
        Get
            Return (_PSCPRFMR)
        End Get
        Set(ByVal value As String)
            _PSCPRFMR = value
        End Set
    End Property
    Public Property PSCINFMR() As String
        Get
            Return (_PSCINFMR)
        End Get
        Set(ByVal value As String)
            _PSCINFMR = value
        End Set
    End Property
    Public Property PSCROTMR() As String
        Get
            Return (_PSCROTMR)
        End Get
        Set(ByVal value As String)
            _PSCROTMR = value
        End Set
    End Property
    Public Property PSCAPIMR() As String
        Get
            Return (_PSCAPIMR)
        End Get
        Set(ByVal value As String)
            _PSCAPIMR = value
        End Set
    End Property
    Public Property PSDUN14() As String
        Get
            Return (_PSDUN14)
        End Get
        Set(ByVal value As String)
            _PSDUN14 = value
        End Set
    End Property
    Public Property PSEAN13() As String
        Get
            Return (_PSEAN13)
        End Get
        Set(ByVal value As String)
            _PSEAN13 = value
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
    Public Property PSDEPOSITO() As String
        Get
            Return _PSDEPOSITO
        End Get
        Set(ByVal value As String)
            _PSDEPOSITO = value
        End Set
    End Property


#Region "Kardex"


    Private _PSCTPALM As String
    Private _PSCALMC As String
    Private _PSCZNALM As String
    Private _PNQSLMC2 As Decimal
    Private _QSLMP2 As Decimal
    Private _PSDESTIPO As String
    Private _PSDESALM As String
    Private _PSDESZONA As String
    Private _PNQINMC1 As Decimal
    Private _PNQINMP1 As Decimal
    Private _PNQDSMC1 As Decimal
    Private _PNQDSMP1 As Decimal
    Private _PNQWRMC2 As Decimal
    Private _PNQWRMP2 As Decimal
    Private _PNQMRMC2 As Decimal
    Private _PNQMRMP2 As Decimal


    Private _PNNDTDTK As Decimal
    Public Property PNNDTDTK() As Decimal
        Get
            Return _PNNDTDTK
        End Get
        Set(ByVal value As Decimal)
            _PNNDTDTK = value
        End Set
    End Property

    Private _PNQTRMC1 As Decimal
    Public Property PNQTRMC1() As Decimal
        Get
            Return _PNQTRMC1
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC1 = value
        End Set
    End Property


    Private _PNQTRMP1 As Decimal
    Public Property PNQTRMP1() As Decimal
        Get
            Return _PNQTRMP1
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMP1 = value
        End Set
    End Property


    Public Property PNQMRMP2() As Decimal
        Get
            Return _PNQMRMP2
        End Get
        Set(ByVal value As Decimal)
            _PNQMRMP2 = value
        End Set

    End Property

    Public Property PNQMRMC2() As Decimal
        Get
            Return _PNQMRMC2
        End Get
        Set(ByVal value As Decimal)
            _PNQMRMC2 = value
        End Set

    End Property

    Public Property PNQWRMP2() As Decimal
        Get
            Return _PNQWRMP2
        End Get
        Set(ByVal value As Decimal)
            _PNQWRMP2 = value
        End Set

    End Property

    Public Property PNQWRMC2() As Decimal
        Get
            Return _PNQWRMC2
        End Get
        Set(ByVal value As Decimal)
            _PNQWRMC2 = value
        End Set

    End Property

    Public Property PNQDSMP1() As Decimal
        Get
            Return _PNQDSMP1
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMP1 = value
        End Set

    End Property
    Public Property PNQDSMC1() As Decimal
        Get
            Return _PNQDSMC1
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMC1 = value
        End Set
    End Property

    Public Property PNQINMP1() As Decimal
        Get
            Return _PNQINMP1
        End Get
        Set(ByVal value As Decimal)
            _PNQINMP1 = value
        End Set
    End Property

    Public Property PNQINMC1() As Decimal
        Get
            Return _PNQINMC1
        End Get
        Set(ByVal value As Decimal)
            _PNQINMC1 = value
        End Set
    End Property

    Public Property PSDESTIPO() As String
        Get
            Return _PSDESTIPO
        End Get
        Set(ByVal value As String)
            _PSDESTIPO = value
        End Set
    End Property



    Public Property PSDESALM() As String
        Get
            Return _PSDESALM
        End Get
        Set(ByVal value As String)
            _PSDESALM = value
        End Set
    End Property



    Public Property PSDESZONA() As String
        Get
            Return _PSDESZONA
        End Get
        Set(ByVal value As String)
            _PSDESZONA = value
        End Set
    End Property

    Public Property PNQSLMC2() As Decimal
        Get
            Return _PNQSLMC2
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMC2 = value
        End Set
    End Property


    Public Property PNQSLMP2() As Decimal
        Get
            Return _QSLMP2
        End Get
        Set(ByVal value As Decimal)
            _QSLMP2 = value
        End Set
    End Property

    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property


    Private _PSTALMC As String
    Public Property PSTALMC() As String
        Get
            Return _PSTALMC
        End Get
        Set(ByVal value As String)
            _PSTALMC = value
        End Set
    End Property

    Public Property PSCALMC() As String
        Get
            Return (_PSCALMC)
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set


    End Property


    Private _PSTCMPAL As String
    Public Property PSTCMPAL() As String
        Get
            Return _PSTCMPAL
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property

    Public Property PSCZNALM() As String
        Get
            Return (_PSCZNALM)
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property

    Private _PSTCMZNA As String
    Public Property PSTCMZNA() As String
        Get
            Return _PSTCMZNA
        End Get
        Set(ByVal value As String)
            _PSTCMZNA = value
        End Set
    End Property


   


    Private _PNQTRMC As Decimal
    Public Property PNQTRMC() As Decimal
        Get
            Return _PNQTRMC
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC = value
        End Set
    End Property


    Private _PNQTRMP As Decimal
    Public Property PNQTRMP() As Decimal
        Get
            Return _PNQTRMP
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMP = value
        End Set
    End Property



    Private _PNQDSVGN As Decimal
    Public Property PNQDSVGN() As Decimal
        Get
            Return _PNQDSVGN
        End Get
        Set(ByVal value As Decimal)
            _PNQDSVGN = value
        End Set
    End Property

    Private _PSCCNTD As String
    Public Property PSCCNTD() As String
        Get
            Return _PSCCNTD
        End Get
        Set(ByVal value As String)
            _PSCCNTD = value
        End Set
    End Property


    Private _PSCTPOCN As String
    Public Property PSCTPOCN() As String
        Get
            Return _PSCTPOCN
        End Get
        Set(ByVal value As String)
            _PSCTPOCN = value
        End Set
    End Property

    Private _PNNSLCSR As Decimal
    Public Property PNNSLCSR() As Decimal
        Get
            Return _PNNSLCSR
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCSR = value
        End Set
    End Property

    Private _PNCMNDA1 As Decimal
    Public Property PNCMNDA1() As Decimal
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property

    Private _PNCANTIDAD As Decimal
    Public Property PNCANTIDAD() As Decimal
        Get
            Return _PNCANTIDAD
        End Get
        Set(ByVal value As Decimal)
            _PNCANTIDAD = value
        End Set
    End Property


    Private _PNPESO As Decimal
    Public Property PNPESO() As Decimal
        Get
            Return _PNPESO
        End Get
        Set(ByVal value As Decimal)
            _PNPESO = value
        End Set
    End Property


    Private _PSFECHA As String
    Public Property PSFECHA() As String
        Get
            Return _PSFECHA
        End Get
        Set(ByVal value As String)
            _PSFECHA = value
        End Set
    End Property


    Private _PNNGUIRN As Decimal
    Public Property PNNGUIRN() As Decimal
        Get
            Return _PNNGUIRN
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRN = value
        End Set
    End Property



    Private _PSTABTRF As String
    Public Property PSTABTRF() As String
        Get
            Return _PSTABTRF
        End Get
        Set(ByVal value As String)
            _PSTABTRF = value
        End Set
    End Property

    Private _CUNPS6 As String

    Public Property PSCUNPS6() As String
        Get
            Return _CUNPS6
        End Get
        Set(ByVal value As String)
            _CUNPS6 = value
        End Set
    End Property

    Private _CUNCN6 As String


#End Region

    Private _PNNGUIRM As Decimal

    Public Property PNNGUIRM() As Decimal
        Get
            Return _PNNGUIRM
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRM = value
        End Set
    End Property


    Private _PSNRFRPD As String

    Public Property PSNRFRPD() As String
        Get
            Return _PSNRFRPD
        End Get
        Set(ByVal value As String)
            _PSNRFRPD = value
        End Set
    End Property


    Private _PNNCNTR As Decimal
    Public Property PNNCNTR() As Decimal
        Get
            Return _PNNCNTR
        End Get
        Set(ByVal value As Decimal)
            _PNNCNTR = value
        End Set
    End Property


    Private _PNNCRCTC As Decimal
    ''' <summary>
    ''' Num Correlativo Detalle de Contrato 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNNCRCTC() As Decimal
        Get
            Return _PNNCRCTC
        End Get
        Set(ByVal value As Decimal)
            _PNNCRCTC = value
        End Set
    End Property

    Private _PNNRITOC As Decimal
    Public Property PNNRITOC() As Decimal
        Get
            Return _PNNRITOC
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property



    Private _PNNAUTR As Decimal
    ''' <summary>
    ''' Num de Autorización 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNNAUTR() As Decimal
        Get
            Return _PNNAUTR
        End Get
        Set(ByVal value As Decimal)
            _PNNAUTR = value
        End Set
    End Property


    Private _PSCUNCNT As String
    Public Property PSCUNCNT() As String
        Get
            Return _PSCUNCNT
        End Get
        Set(ByVal value As String)
            _PSCUNCNT = value
        End Set
    End Property

    Private _pSCUNPST As String
    Public Property PSCUNPST() As String
        Get
            Return _pSCUNPST
        End Get
        Set(ByVal value As String)
            _pSCUNPST = value
        End Set
    End Property



    Private _pSCUNVLT As String
    Public Property pSCUNVLT() As String
        Get
            Return _pSCUNVLT
        End Get
        Set(ByVal value As String)
            _pSCUNVLT = value
        End Set
    End Property


    Private _PSFEMORS As String
    ''' <summary>
    ''' Fec Emisión de Orden Servicio 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSFEMORS() As String
        Get
            Return _PSFEMORS
        End Get
        Set(ByVal value As String)
            _PSFEMORS = value
        End Set
    End Property


    Private _PSCTPDP6 As String
    ''' <summary>
    ''' Cod Tipo Deposito
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCTPDP6() As String
        Get
            Return _PSCTPDP6
        End Get
        Set(ByVal value As String)
            _PSCTPDP6 = value
        End Set
    End Property


    Private _PNQALMC As Decimal
    ''' <summary>
    ''' CANTIDAD DE ALMACEN
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNQALMC() As Decimal
        Get
            Return _PNQALMC
        End Get
        Set(ByVal value As Decimal)
            _PNQALMC = value
        End Set
    End Property


    Private _PNQWRMC As Decimal
    Public Property PNQWRMC() As Decimal
        Get
            Return _PNQWRMC
        End Get
        Set(ByVal value As Decimal)
            _PNQWRMC = value
        End Set
    End Property


    Private _PNQSLMC As Decimal
    ''' <summary>
    ''' Can Saldo de Mercaderia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNQSLMC() As Decimal
        Get
            Return _PNQSLMC
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMC = value
        End Set
    End Property


    Private _PNPESOALM As Decimal
    Public Property PNPESOALM() As Decimal
        Get
            Return _PNPESOALM
        End Get
        Set(ByVal value As Decimal)
            _PNPESOALM = value
        End Set
    End Property


    Private _PNQWRMP As Decimal
    Public Property PNQWRMP() As Decimal
        Get
            Return _PNQWRMP
        End Get
        Set(ByVal value As Decimal)
            _PNQWRMP = value
        End Set
    End Property


    Private _PNQSLMV As Decimal
    Public Property PNQSLMV() As Decimal
        Get
            Return _PNQSLMV
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMV = value
        End Set
    End Property


    Private _PNQSERIES As Integer
    Public Property PNQSERIES() As Integer
        Get
            Return _PNQSERIES
        End Get
        Set(ByVal value As Integer)
            _PNQSERIES = value
        End Set
    End Property

    Private _PNQUBICACION As Decimal
    Public Property PNQUBICACION() As Decimal
        Get
            Return _PNQUBICACION
        End Get
        Set(ByVal value As Decimal)
            _PNQUBICACION = value
        End Set
    End Property

    Private _PSCUNVL5 As String
    Public Property PSCUNVL5() As String
        Get
            Return _PSCUNVL5
        End Get
        Set(ByVal value As String)
            _PSCUNVL5 = value
        End Set
    End Property


    Private _PSFUNDS2 As String
    Public Property PSFUNDS2() As String
        Get
            Return _PSFUNDS2
        End Get
        Set(ByVal value As String)
            _PSFUNDS2 = value
        End Set
    End Property


    Private _psCTPDPS As String
    Public Property PSCTPDPS() As String
        Get
            Return _psCTPDPS
        End Get
        Set(ByVal value As String)
            _psCTPDPS = value
        End Set
    End Property


    Private _PSFUNCTL As String
    ''' <summary>
    '''  Flg Unidad Control Lotes  
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSFUNCTL() As String
        Get
            Return _PSFUNCTL
        End Get
        Set(ByVal value As String)
            _PSFUNCTL = value
        End Set
    End Property

    Private _PNQMRCD1 As Decimal
    Public Property PNQMRCD1() As Decimal
        Get
            Return _PNQMRCD1
        End Get
        Set(ByVal value As Decimal)
            _PNQMRCD1 = value
        End Set
    End Property

    Private _PNQPSMR1 As Decimal
    Public Property PNQPSMR1() As Decimal
        Get
            Return _PNQPSMR1
        End Get
        Set(ByVal value As Decimal)
            _PNQPSMR1 = value
        End Set
    End Property


    Private _PNQVLMR1 As Decimal
    Public Property PNQVLMR1() As Decimal
        Get
            Return _PNQVLMR1
        End Get
        Set(ByVal value As Decimal)
            _PNQVLMR1 = value
        End Set
    End Property

 
    Private _PSCFMLA As String
    Public Property PSCFMLA() As String
        Get
            Return _PSCFMLA
        End Get
        Set(ByVal value As String)
            _PSCFMLA = value
        End Set
    End Property


    Private _PSCGRPO As String
    Public Property PSCGRPO() As String
        Get
            Return _PSCGRPO
        End Get
        Set(ByVal value As String)
            _PSCGRPO = value
        End Set
    End Property


    Private _PNCMRCA As Decimal
    Public Property PNCMRCA() As Decimal
        Get
            Return _PNCMRCA
        End Get
        Set(ByVal value As Decimal)
            _PNCMRCA = value
        End Set
    End Property


    Private _PSTCMPMR As String
    Public Property PSTCMPMR() As String
        Get
            Return _PSTCMPMR
        End Get
        Set(ByVal value As String)
            _PSTCMPMR = value
        End Set
    End Property


    Private _PSTCMPFM As String
    Public Property PSTCMPFM() As String
        Get
            Return _PSTCMPFM
        End Get
        Set(ByVal value As String)
            _PSTCMPFM = value
        End Set
    End Property


    Private _PSTCMPGR As String
    Public Property PSTCMPGR() As String
        Get
            Return _PSTCMPGR
        End Get
        Set(ByVal value As String)
            _PSTCMPGR = value
        End Set
    End Property


    Private _PSTCMMRC As String
    Public Property PSTCMMRC() As String
        Get
            Return _PSTCMMRC
        End Get
        Set(ByVal value As String)
            _PSTCMMRC = value
        End Set
    End Property


    Private _PNSALDIS As Decimal
    Public Property PNSALDIS() As Decimal
        Get
            Return _PNSALDIS
        End Get
        Set(ByVal value As Decimal)
            _PNSALDIS = value
        End Set
    End Property



    Private _PSCTPDP3 As String
    Public Property PSCTPDP3() As String
        Get
            Return _PSCTPDP3
        End Get
        Set(ByVal value As String)
            _PSCTPDP3 = value
        End Set
    End Property


    Private _PSTABDPS As String
    Public Property PSTABDPS() As String
        Get
            Return _PSTABDPS
        End Get
        Set(ByVal value As String)
            _PSTABDPS = value
        End Set
    End Property



    Private _PSCTPPR1 As String
    Public Property PSCTPPR1() As String
        Get
            Return _PSCTPPR1
        End Get
        Set(ByVal value As String)
            _PSCTPPR1 = value
        End Set
    End Property


    Private _PSCUNCN3 As String
    Public Property PSCUNCN3() As String
        Get
            Return _PSCUNCN3
        End Get
        Set(ByVal value As String)
            _PSCUNCN3 = value
        End Set
    End Property


    Private _PSCUNPS3 As String
    Public Property PSCUNPS3() As String
        Get
            Return _PSCUNPS3
        End Get
        Set(ByVal value As String)
            _PSCUNPS3 = value
        End Set
    End Property


    Private _PSCUNVL3 As String
    Public Property PSCUNVL3() As String
        Get
            Return _PSCUNVL3
        End Get
        Set(ByVal value As String)
            _PSCUNVL3 = value
        End Set
    End Property


    Private _PSTABRFM As String
    Public Property PSTABRFM() As String
        Get
            Return _PSTABRFM
        End Get
        Set(ByVal value As String)
            _PSTABRFM = value
        End Set
    End Property


    Private _PSSPLGFM As String
    Public Property PSSPLGFM() As String
        Get
            Return _PSSPLGFM
        End Get
        Set(ByVal value As String)
            _PSSPLGFM = value
        End Set
    End Property


    Private _PSTCMPGM As String
    Public Property PSTCMPGM() As String
        Get
            Return _PSTCMPGM
        End Get
        Set(ByVal value As String)
            _PSTCMPGM = value
        End Set
    End Property


    Private _PSTABRGR As String
    Public Property PSTABRGR() As String
        Get
            Return _PSTABRGR
        End Get
        Set(ByVal value As String)
            _PSTABRGR = value
        End Set
    End Property


    Private _PSTABRMR As String
    Public Property PSTABRMR() As String
        Get
            Return _PSTABRMR
        End Get
        Set(ByVal value As String)
            _PSTABRMR = value
        End Set
    End Property


    Private _PNQMRCD As Decimal
    Public Property PNQMRCD() As Decimal
        Get
            Return _PNQMRCD
        End Get
        Set(ByVal value As Decimal)
            _PNQMRCD = value
        End Set
    End Property


    Private _psCUNCND As String
    Public Property PSCUNCND() As String
        Get
            Return _psCUNCND
        End Get
        Set(ByVal value As String)
            _psCUNCND = value
        End Set
    End Property


    Private _PNQPSMR As Decimal
    Public Property PNQPSMR() As Decimal
        Get
            Return _PNQPSMR
        End Get
        Set(ByVal value As Decimal)
            _PNQPSMR = value
        End Set
    End Property


    Private _PSCUNPS0 As String
    Public Property PSCUNPS0() As String
        Get
            Return _PSCUNPS0
        End Get
        Set(ByVal value As String)
            _PSCUNPS0 = value
        End Set
    End Property


    Private _PNQVLMR As Decimal
    Public Property PNQVLMR() As Decimal
        Get
            Return _PNQVLMR
        End Get
        Set(ByVal value As Decimal)
            _PNQVLMR = value
        End Set
    End Property


    Private _PSCUNVLR As String
    Public Property PSCUNVLR() As String
        Get
            Return _PSCUNVLR
        End Get
        Set(ByVal value As String)
            _PSCUNVLR = value
        End Set
    End Property


    Private _PSFUNDS As String
    Public Property PSFUNDS() As String
        Get
            Return _PSFUNDS
        End Get
        Set(ByVal value As String)
            _PSFUNDS = value
        End Set
    End Property


  


    Private _PSTABMRC As String
    Public Property PSTABMRC() As String
        Get
            Return _PSTABMRC
        End Get
        Set(ByVal value As String)
            _PSTABMRC = value
        End Set
    End Property



    Private _PNNANOCM As Decimal
    Public Property PNNANOCM() As Decimal
        Get
            Return _PNNANOCM
        End Get
        Set(ByVal value As Decimal)
            _PNNANOCM = value
        End Set
    End Property


    Private _PNCTRSP As Decimal
    Public Property PNCTRSP() As Decimal
        Get
            Return _PNCTRSP
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSP = value
        End Set
    End Property


    Private _PNNLELCH As Decimal
    Public Property PNNLELCH() As Decimal
        Get
            Return _PNNLELCH
        End Get
        Set(ByVal value As Decimal)
            _PNNLELCH = value
        End Set
    End Property


    Private _PNNRUCT As Decimal
    Public Property PNNRUCT() As Decimal
        Get
            Return _PNNRUCT
        End Get
        Set(ByVal value As Decimal)
            _PNNRUCT = value
        End Set
    End Property


    Private _PNCSRVC As Decimal
    Public Property PNCSRVC() As Decimal
        Get
            Return _PNCSRVC
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVC = value
        End Set
    End Property


    Private _PSTNMBCH As String
    Public Property PSTNMBCH() As String
        Get
            Return _PSTNMBCH
        End Get
        Set(ByVal value As String)
            _PSTNMBCH = value
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


    Private _PSTMRCCM As String
    Public Property PSTMRCCM() As String
        Get
            Return _PSTMRCCM
        End Get
        Set(ByVal value As String)
            _PSTMRCCM = value
        End Set
    End Property


    Private _PSNBRVCH As String
    Public Property PSNBRVCH() As String
        Get
            Return _PSNBRVCH
        End Get
        Set(ByVal value As String)
            _PSNBRVCH = value
        End Set
    End Property


    Private _PSNPLCCM As String
    Public Property PSNPLCCM() As String
        Get
            Return _PSNPLCCM
        End Get
        Set(ByVal value As String)
            _PSNPLCCM = value
        End Set
    End Property

    Private _PSTOBSER As String
    Public Property PSTOBSER() As String
        Get
            Return _PSTOBSER
        End Get
        Set(ByVal value As String)
            _PSTOBSER = value
        End Set
    End Property


    Private _PSTCMPTR As String
    Public Property PSTCMPTR() As String
        Get
            Return _PSTCMPTR
        End Get
        Set(ByVal value As String)
            _PSTCMPTR = value
        End Set
    End Property


    Private _ISSERVICIO As Boolean
    Public Property NewProperty() As Boolean
        Get
            Return _ISSERVICIO
        End Get
        Set(ByVal value As Boolean)
            _ISSERVICIO = value
        End Set
    End Property



    Private _PSSTADEF As String
    Public Property PSSTADEF() As String
        Get
            Return _PSSTADEF
        End Get
        Set(ByVal value As String)
            _PSSTADEF = value
        End Set
    End Property


    Private _PSSTPODP As String
    Public Property PSSTPODP() As String
        Get
            Return _PSSTPODP
        End Get
        Set(ByVal value As String)
            _PSSTPODP = value
        End Set
    End Property


    Private _blnStatusDefinitivo As Boolean
    Public Property blnStatusDefinitivo() As Boolean
        Get
            Return _blnStatusDefinitivo
        End Get
        Set(ByVal value As Boolean)
            _blnStatusDefinitivo = value
        End Set
    End Property


    Private _GenerarServicio As Boolean
    Public Property GenerarServicio() As Boolean
        Get
            Return _GenerarServicio
        End Get
        Set(ByVal value As Boolean)
            _GenerarServicio = value
        End Set
    End Property


    Private _CORRELATIVO As Integer
    Public Property CORRELATIVO() As Integer
        Get
            Return _CORRELATIVO
        End Get
        Set(ByVal value As Integer)
            _CORRELATIVO = value
        End Set
    End Property

    Private _PNANIOEMI As Decimal = 0
    Public Property PNANIOEMI() As Decimal
        Get
            Return _PNANIOEMI
        End Get
        Set(ByVal value As Decimal)
            _PNANIOEMI = value
        End Set
    End Property

    Private _PNMESEMI As Decimal = 0
    Public Property PNMESEMI() As Decimal
        Get
            Return _PNMESEMI
        End Get
        Set(ByVal value As Decimal)
            _PNMESEMI = value
        End Set
    End Property
    Private _PNMAXDIAS As Decimal = 0
    Public Property PNMAXDIAS() As Decimal
        Get
            Return _PNMAXDIAS
        End Get
        Set(ByVal value As Decimal)
            _PNMAXDIAS = value
        End Set
    End Property

    Private _PSMES As String
    Public Property PSMES() As String
        Get
            Return _PSMES
        End Get
        Set(ByVal value As String)
            _PSMES = value
        End Set
    End Property

    Private _PSTCMPL As String
    Public Property PSTCMPL() As String
        Get
            Return _PSTCMPL
        End Get
        Set(ByVal value As String)
            _PSTCMPL = value
        End Set
    End Property

    Public Sub New()
        Try
            Me.InicializeProperty(Me)
        Catch ex As Exception

        End Try

    End Sub


    Private _PSUNIDAD As String
    Public Property PSUNIDAD() As String
        Get
            Return _PSUNIDAD
        End Get
        Set(ByVal value As String)
            _PSUNIDAD = value
        End Set
    End Property


    Private _PNQSTKIT As Decimal
    Public Property PNQSTKIT() As Decimal
        Get
            Return _PNQSTKIT
        End Get
        Set(ByVal value As Decimal)
            _PNQSTKIT = value
        End Set
    End Property


    Private _PNQCNTIT As Decimal
    Public Property PNQCNTIT() As Decimal
        Get
            Return _PNQCNTIT
        End Get
        Set(ByVal value As Decimal)
            _PNQCNTIT = value
        End Set
    End Property


    Private _PNQCNDPC As Decimal
    Public Property PNQCNDPC() As Decimal
        Get
            Return _PNQCNDPC
        End Get
        Set(ByVal value As Decimal)
            _PNQCNDPC = value
        End Set
    End Property

    Private _PSNORCML As String
    Public Property PSNORCML() As String
        Get
            Return _PSNORCML
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
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



    Private _PSTDITES As String
    Public Property PSTDITES() As String
        Get
            Return _PSTDITES
        End Get
        Set(ByVal value As String)
            _PSTDITES = value
        End Set
    End Property


    Private _PNPREVTR As Decimal
    Public Property PNPREVTR() As Decimal
        Get
            Return _PNPREVTR
        End Get
        Set(ByVal value As Decimal)
            _PNPREVTR = value
        End Set
    End Property


    Private _PNQREVTR As Decimal
    Public Property PNQREVTR() As Decimal
        Get
            Return _PNQREVTR
        End Get
        Set(ByVal value As Decimal)
            _PNQREVTR = value
        End Set
    End Property

    Private _PSCMRCLR2 As String
    Public Property PSCMRCLR2() As String
        Get
            Return _PSCMRCLR2
        End Get
        Set(ByVal value As String)
            _PSCMRCLR2 = value
        End Set
    End Property


    Private _PSCMRCLR_NEW As String
    Public Property PSCMRCLR_NEW() As String
        Get
            Return _PSCMRCLR_NEW
        End Get
        Set(ByVal value As String)
            _PSCMRCLR_NEW = value
        End Set
    End Property


    Private _PSCUNCN5_NEW As String
    Public Property PSCUNCN5_NEW() As String
        Get
            Return _PSCUNCN5_NEW
        End Get
        Set(ByVal value As String)
            _PSCUNCN5_NEW = value
        End Set
    End Property


    Private _PNFTRNS As Decimal
    Public Property PNFTRNS() As Decimal
        Get
            Return _PNFTRNS
        End Get
        Set(ByVal value As Decimal)
            _PNFTRNS = value
        End Set
    End Property


    'Private _PNFINGAL As Decimal
    'Public Property PNFINGAL() As Decimal
    '    Get
    '        Return _PNFINGAL
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNFINGAL = value
    '    End Set
    'End Property


    Private _PNHINGAL As Decimal
    Public Property PNHINGAL() As Decimal
        Get
            Return _PNHINGAL
        End Get
        Set(ByVal value As Decimal)
            _PNHINGAL = value
        End Set
    End Property


    'Private _PNFSLDAL As Decimal
    'Public Property PNFSLDAL() As Decimal
    '    Get
    '        Return _PNFSLDAL
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNFSLDAL = value
    '    End Set
    'End Property


    Private _PNHSLDAL As Decimal
    Public Property PNHSLDAL() As Decimal
        Get
            Return _PNHSLDAL
        End Get
        Set(ByVal value As Decimal)
            _PNHSLDAL = value
        End Set
    End Property



    Private _PSSSTINV As String
    Public Property PSSSTINV() As String
        Get
            Return _PSSSTINV
        End Get
        Set(ByVal value As String)
            _PSSSTINV = value
        End Set
    End Property


    Private _Ubicacion As Object
    Public Property Ubicacion() As Object
        Get
            Return _Ubicacion
        End Get
        Set(ByVal value As Object)
            _Ubicacion = value
        End Set
    End Property



    Private _Serie As Object
    Public Property Serie() As Object
        Get
            Return _Serie
        End Get
        Set(ByVal value As Object)
            _Serie = value
        End Set
    End Property


    Private _PNQMRCSL As Decimal
    Public Property PNQMRCSL() As Decimal
        Get
            Return _PNQMRCSL
        End Get
        Set(ByVal value As Decimal)
            _PNQMRCSL = value
        End Set
    End Property

    Public Property PNCANT_OS() As Decimal
        Get
            Return _PNCANT_OS
        End Get
        Set(ByVal value As Decimal)
            _PNCANT_OS = value
        End Set
    End Property


End Class

Public Class beGeneral
    Inherits beBase(Of beGeneral)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    Private _PNCMEDTR As Decimal
    Public Property PNCMEDTR() As Decimal
        Get
            Return _PNCMEDTR
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTR = value
        End Set
    End Property


    Private _PSTNMMDT As String
    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property



    Private _PNNTCKPS As Decimal
    Private _PSCBLZAI As String
    Private _PSCBLZAS As String
    Private _PSCUSRBL As String
    Private _PSCUSRBS As String
    Private _PNFBLNIN As Decimal
    Private _PNHBLNIN As Decimal
    Private _PNFBLNSL As Decimal
    Private _PNHBLNSL As Decimal
    Private _PSCTPPSI As String
    Private _PNQPSTKI As Decimal
    Private _PNQPSTKS As Decimal
    Private _PNQPSTGS As Decimal
    Private _PNCTRSP As Decimal
    Private _PSNPLCCM As String
    Private _PSNBRVCH As String
    Private _PNNORSR1 As Decimal
    Private _PNNSLCS1 As Decimal
    Private _PSCTPAL1 As String
    Private _PSCALMC1 As String
    Private _PSNGUIRM As String
    Private _PSCPRCN1 As String
    Private _PSNSRCN1 As String
    Private _PSCPRCN2 As String
    Private _PSNSRCN2 As String
    Private _PSSDBLPS As String
    Private _PSCTPOPB As String
    Private _PSSLLVGS As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSNTRMNL As String
    Private _PSSESTRG As String
    Private _PSTPPSI As String
    Private _PSTPPSS As String
    Private _PSNPLCAC As String
    Private _PSCNFVEH As String
    Private _PNPBRMAX As Decimal
    Private _PSIDAUT As String
    Private _PNCTPODC As Decimal
    Private _PSTCMTPD As String
    Private _PNCAGNAD As Decimal
    Private _PNUPDATE_IDENT As Decimal


    Private _PSTCMPPS As String
    ''' <summary>
    ''' Descripcion Pais
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTCMPPS() As String
        Get
            Return _PSTCMPPS
        End Get
        Set(ByVal value As String)
            _PSTCMPPS = value
        End Set
    End Property


    Private _PNCPAIS As Decimal
    ''' <summary>
    ''' Codigo de Pais
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCPAIS() As Decimal
        Get
            Return _PNCPAIS
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS = value
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


    Public Property PNNTCKPS() As Decimal
        Get
            Return (_PNNTCKPS)
        End Get
        Set(ByVal value As Decimal)
            _PNNTCKPS = value
        End Set
    End Property
    Public Property PSCBLZAI() As String
        Get
            Return (_PSCBLZAI)
        End Get
        Set(ByVal value As String)
            _PSCBLZAI = value
        End Set
    End Property
    Public Property PSCBLZAS() As String
        Get
            Return (_PSCBLZAS)
        End Get
        Set(ByVal value As String)
            _PSCBLZAS = value
        End Set
    End Property
    Public Property PSCUSRBL() As String
        Get
            Return (_PSCUSRBL)
        End Get
        Set(ByVal value As String)
            _PSCUSRBL = value
        End Set
    End Property
    Public Property PSCUSRBS() As String
        Get
            Return (_PSCUSRBS)
        End Get
        Set(ByVal value As String)
            _PSCUSRBS = value
        End Set
    End Property
    Public Property PNFBLNIN() As Decimal
        Get
            Return (_PNFBLNIN)
        End Get
        Set(ByVal value As Decimal)
            _PNFBLNIN = value
        End Set
    End Property
    Public Property PNHBLNIN() As Decimal
        Get
            Return (_PNHBLNIN)
        End Get
        Set(ByVal value As Decimal)
            _PNHBLNIN = value
        End Set
    End Property
    Public Property PNFBLNSL() As Decimal
        Get
            Return (_PNFBLNSL)
        End Get
        Set(ByVal value As Decimal)
            _PNFBLNSL = value
        End Set
    End Property
    Public Property PNHBLNSL() As Decimal
        Get
            Return (_PNHBLNSL)
        End Get
        Set(ByVal value As Decimal)
            _PNHBLNSL = value
        End Set
    End Property
    Public Property PSCTPPSI() As String
        Get
            Return (_PSCTPPSI)
        End Get
        Set(ByVal value As String)
            _PSCTPPSI = value
        End Set
    End Property
    Public Property PNQPSTKI() As Decimal
        Get
            Return (_PNQPSTKI)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSTKI = value
        End Set
    End Property
    Public Property PNQPSTKS() As Decimal
        Get
            Return (_PNQPSTKS)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSTKS = value
        End Set
    End Property
    Public Property PNQPSTGS() As Decimal
        Get
            Return (_PNQPSTGS)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSTGS = value
        End Set
    End Property
    Public Property PNCTRSP() As Decimal
        Get
            Return (_PNCTRSP)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSP = value
        End Set
    End Property
    Public Property PSNPLCCM() As String
        Get
            Return (_PSNPLCCM)
        End Get
        Set(ByVal value As String)
            _PSNPLCCM = value
        End Set
    End Property
    Public Property PSNBRVCH() As String
        Get
            Return (_PSNBRVCH)
        End Get
        Set(ByVal value As String)
            _PSNBRVCH = value
        End Set
    End Property
    Public Property PNNORSR1() As Decimal
        Get
            Return (_PNNORSR1)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSR1 = value
        End Set
    End Property
    Public Property PNNSLCS1() As Decimal
        Get
            Return (_PNNSLCS1)
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCS1 = value
        End Set
    End Property
    Public Property PSCTPAL1() As String
        Get
            Return (_PSCTPAL1)
        End Get
        Set(ByVal value As String)
            _PSCTPAL1 = value
        End Set
    End Property
    Public Property PSCALMC1() As String
        Get
            Return (_PSCALMC1)
        End Get
        Set(ByVal value As String)
            _PSCALMC1 = value
        End Set
    End Property
    Public Property PSNGUIRM() As String
        Get
            Return (_PSNGUIRM)
        End Get
        Set(ByVal value As String)
            _PSNGUIRM = value
        End Set
    End Property
    Public Property PSCPRCN1() As String
        Get
            Return (_PSCPRCN1)
        End Get
        Set(ByVal value As String)
            _PSCPRCN1 = value
        End Set
    End Property
    Public Property PSNSRCN1() As String
        Get
            Return (_PSNSRCN1)
        End Get
        Set(ByVal value As String)
            _PSNSRCN1 = value
        End Set
    End Property
    Public Property PSCPRCN2() As String
        Get
            Return (_PSCPRCN2)
        End Get
        Set(ByVal value As String)
            _PSCPRCN2 = value
        End Set
    End Property
    Public Property PSNSRCN2() As String
        Get
            Return (_PSNSRCN2)
        End Get
        Set(ByVal value As String)
            _PSNSRCN2 = value
        End Set
    End Property
    Public Property PSSDBLPS() As String
        Get
            Return (_PSSDBLPS)
        End Get
        Set(ByVal value As String)
            _PSSDBLPS = value
        End Set
    End Property
    Public Property PSCTPOPB() As String
        Get
            Return (_PSCTPOPB)
        End Get
        Set(ByVal value As String)
            _PSCTPOPB = value
        End Set
    End Property
    Public Property PSSLLVGS() As String
        Get
            Return (_PSSLLVGS)
        End Get
        Set(ByVal value As String)
            _PSSLLVGS = value
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
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PSNTRMNL() As String
        Get
            Return (_PSNTRMNL)
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
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
    Public Property PSTPPSI() As String
        Get
            Return (_PSTPPSI)
        End Get
        Set(ByVal value As String)
            _PSTPPSI = value
        End Set
    End Property
    Public Property PSTPPSS() As String
        Get
            Return (_PSTPPSS)
        End Get
        Set(ByVal value As String)
            _PSTPPSS = value
        End Set
    End Property
    Public Property PSNPLCAC() As String
        Get
            Return (_PSNPLCAC)
        End Get
        Set(ByVal value As String)
            _PSNPLCAC = value
        End Set
    End Property
    Public Property PSCNFVEH() As String
        Get
            Return (_PSCNFVEH)
        End Get
        Set(ByVal value As String)
            _PSCNFVEH = value
        End Set
    End Property
    Public Property PNPBRMAX() As Decimal
        Get
            Return (_PNPBRMAX)
        End Get
        Set(ByVal value As Decimal)
            _PNPBRMAX = value
        End Set
    End Property
    Public Property PSIDAUT() As String
        Get
            Return (_PSIDAUT)
        End Get
        Set(ByVal value As String)
            _PSIDAUT = value
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


    Private _PSNLTECL As String
    Public Property PSNLTECL() As String
        Get
            Return _PSNLTECL
        End Get
        Set(ByVal value As String)
            _PSNLTECL = value
        End Set
    End Property


    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _PNCSRVC As Integer
    Public Property PNCSRVC() As Integer
        Get
            Return _PNCSRVC
        End Get
        Set(ByVal value As Integer)
            _PNCSRVC = value
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


    Private _PSTTPING As String
    Public Property PSTTPING() As String
        Get
            Return _PSTTPING
        End Get
        Set(ByVal value As String)
            _PSTTPING = value
        End Set
    End Property

    Private _PSTLTECL As String
    Public Property PSTLTECL() As String
        Get
            Return _PSTLTECL
        End Get
        Set(ByVal value As String)
            _PSTLTECL = value
        End Set
    End Property

    Private _PSTOBSRL As String
    Public Property PSTOBSRL() As String
        Get
            Return _PSTOBSRL
        End Get
        Set(ByVal value As String)
            _PSTOBSRL = value
        End Set
    End Property

    Private _PSTLUGEN As String
    Public Property PSTLUGEN() As String
        Get
            Return _PSTLUGEN
        End Get
        Set(ByVal value As String)
            _PSTLUGEN = value
        End Set
    End Property



    Private _PSTPLNTA As String
    Public Property PSTPLNTA() As String
        Get
            Return _PSTPLNTA
        End Get
        Set(ByVal value As String)
            _PSTPLNTA = value
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


    Private _PSSTPOUN As String
    Public Property PSSTPOUN() As String
        Get
            Return _PSSTPOUN
        End Get
        Set(ByVal value As String)
            _PSSTPOUN = value
        End Set
    End Property


    Private _PSCUNDMD As String
    Public Property PSCUNDMD() As String
        Get
            Return _PSCUNDMD
        End Get
        Set(ByVal value As String)
            _PSCUNDMD = value
        End Set
    End Property


    Private _PSTCMPUN As String
    Public Property PSTCMPUN() As String
        Get
            Return _PSTCMPUN
        End Get
        Set(ByVal value As String)
            _PSTCMPUN = value
        End Set
    End Property


    Private _PSCODVAR As String
    Public Property PSCODVAR() As String
        Get
            Return _PSCODVAR
        End Get
        Set(ByVal value As String)
            _PSCODVAR = value
        End Set
    End Property


    Private _PSCCMPRN As String
    Public Property PSCCMPRN() As String
        Get
            Return _PSCCMPRN
        End Get
        Set(ByVal value As String)
            _PSCCMPRN = value
        End Set
    End Property

    Private _PSCCMPRN_TB As String
    Public Property PSCCMPRN_TB() As String
        Get
            Return _PSCCMPRN_TB
        End Get
        Set(ByVal value As String)
            _PSCCMPRN_TB = value
        End Set
    End Property

    Private _PSTDSDES As String
    Public Property PSTDSDES() As String
        Get
            Return _PSTDSDES
        End Get
        Set(ByVal value As String)
            _PSTDSDES = value
        End Set
    End Property

    Private _PSTDSDES_TB As String
    Public Property PSTDSDES_TB() As String
        Get
            Return _PSTDSDES_TB
        End Get
        Set(ByVal value As String)
            _PSTDSDES_TB = value
        End Set
    End Property

    Public Property PNCTPODC() As Decimal
        Get
            Return _PNCTPODC
        End Get
        Set(ByVal value As Decimal)
            _PNCTPODC = value
        End Set
    End Property

    Public Property PSTCMTPD() As String
        Get
            Return _PSTCMTPD
        End Get
        Set(ByVal value As String)
            _PSTCMTPD = value
        End Set
    End Property

    Public Property PNCAGNAD() As Decimal
        Get
            Return _PNCAGNAD
        End Get
        Set(ByVal value As Decimal)
            _PNCAGNAD = value
        End Set
    End Property

    Private _PSTCMAA As String
    Public Property PSTCMAA() As String
        Get
            Return (_PSTCMAA)
        End Get
        Set(ByVal value As String)
            _PSTCMAA = value
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


    Private _PSTMNDA As String
    Public Property PSTMNDA() As String
        Get
            Return _PSTMNDA
        End Get
        Set(ByVal value As String)
            _PSTMNDA = value
        End Set
    End Property


    Private _PSTSGNMN As String
    Public Property PSTSGNMN() As String
        Get
            Return _PSTSGNMN
        End Get
        Set(ByVal value As String)
            _PSTSGNMN = value
        End Set
    End Property


End Class

Public Class OrdenCompra_BE
    Inherits Base_BE(Of OrdenCompra_BE)

    Private _PNCCLNT As Decimal = 0

    Private _PSNORCML As String = ""
    Private _PNCPRVCL As Decimal
    Private _PSCPRPCL As String
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
    Private _PSNMONOC As String
    Private _PSSFACTU As String
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
    Private _PSNTPDES As String
    Private _PNFLGMAI As Decimal
    Private _PSSFLGES As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSCULUSA As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSSESTRG As String = ""
    Private _PNUPDATE_IDENT As Decimal = 0
    Private _PSFORCML As String = ""

    Private _PSTDSDES As String = ""
    Private _PSDESPROV As String = ""
    Private _PSCMNDA1 As String = ""
    Private _PSTDITES As String = ""
    Private _PSPROVEE As String = ""
    Private _PSTNMMDT As String = ""

    Private _PNNRITOC As Decimal = 0
    Private _PNNCRRLT As Decimal = 0
    Private _PSTCMPCL As String 'Descripcion Cliente

    Private _PNFMPDME As Decimal = 0 'fecha1
    Private _PNFMPIME As Decimal = 0 'fecha2

    Private _PNFECENT As Decimal = 0 'fecha3
    Private _PNFINGAL As Decimal = 0 'fecha4
    Private _PSTOBS As String = "" 'Obs
    Private _PNNRPEMB As Decimal = 0 'Nro Pre Embarque

    Public Property PNNRPEMB() As Decimal
        Get
            Return _PNNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _PNNRPEMB = value
        End Set
    End Property

    Public Property PNFECENT() As Decimal
        Get
            Return _PNFECENT
        End Get
        Set(ByVal value As Decimal)
            _PNFECENT = value
        End Set
    End Property

    Public Property PNFINGAL() As Decimal
        Get
            Return _PNFINGAL
        End Get
        Set(ByVal value As Decimal)
            _PNFINGAL = value
        End Set
    End Property

    Public Property PNFMPDME() As Decimal
        Get
            Return _PNFMPDME
        End Get
        Set(ByVal value As Decimal)
            _PNFMPDME = value
        End Set
    End Property
    Public Property PNFMPIME() As Decimal
        Get
            Return _PNFMPIME
        End Get
        Set(ByVal value As Decimal)
            _PNFMPIME = value
        End Set
    End Property
    Public Property PSTOBS() As String
        Get
            Return _PSTOBS
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property

    Public Property PNNRITOC() As Decimal
        Get
            Return _PNNRITOC
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property

    Public Property PNNCRRLT() As Decimal
        Get
            Return _PNNCRRLT
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRLT = value
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

    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property

    Public Property PSPROVEE() As String
        Get
            Return _PSPROVEE
        End Get
        Set(ByVal value As String)
            _PSPROVEE = value
        End Set
    End Property



    Public Property PSTDITES() As String
        Get
            Return _PSTDITES
        End Get
        Set(ByVal value As String)
            _PSTDITES = value
        End Set
    End Property

    Public Property PSCMNDA1() As String
        Get
            Return _PSCMNDA1
        End Get
        Set(ByVal value As String)
            _PSCMNDA1 = value
        End Set
    End Property

    Public Property PSDESPROV() As String
        Get
            Return _PSDESPROV
        End Get
        Set(ByVal value As String)
            _PSDESPROV = value
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
    Public Property PSNORCML() As String
        Get
            Return (_PSNORCML)
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
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

    Public Property PSFORCML() As String
        Get
            Return _PSFORCML
        End Get
        Set(ByVal value As String)
            _PSFORCML = value
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
    Public Property PSTCTCST() As String
        Get
            Return (_PSTCTCST)
        End Get
        Set(ByVal value As String)
            _PSTCTCST = value
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
    Public Property PSNTPDES() As String
        Get
            Return (_PSNTPDES)
        End Get
        Set(ByVal value As String)
            _PSNTPDES = value
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
    Public Property PSSFLGES() As String
        Get
            Return (_PSSFLGES)
        End Get
        Set(ByVal value As String)
            _PSSFLGES = value
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
    Public Property PSTDSDES() As String
        Get
            Return _PSTDSDES
        End Get
        Set(ByVal value As String)
            _PSTDSDES = value
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


    Private _PNCPLNDV As Decimal
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property
End Class
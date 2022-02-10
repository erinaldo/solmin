Public Class beSeguimientoCargaFiltro
    Private _PNCCLNT As Decimal = 0
    Private _PNFECINI As Decimal = 0
    Private _PNFECFIN As Decimal = 0
    Private _PSCPRVCL As String = ""
    Private _PSPNNMOS As String = ""
    Private _PSDOCEMB As String = ""
    Private _PSNORSCI As String = ""
    Private _PNNORSCI As String = ""
    Private _PSNREFCL As String = ""
    Private _PSSESTRG As String = ""
    Private _PSNORCML As String = ""
    Private _PSNORCML_VERTICAL As String = ""
    Private _PSOC As String = ""

    Private _PSCMEDTR As String = ""
    Private _PSCPAIS As String = ""
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PSTPSRVA As String = ""
    Private _PSEMBARQUES As String = ""
    Private _PNCPLNDV As Decimal = 0

    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property


    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PNFECINI() As Decimal
        Get
            Return _PNFECINI
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property


    Public Property PNFECFIN() As Decimal
        Get
            Return _PNFECFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
        End Set
    End Property

  
    Public Property PSCPRVCL() As String
        Get
            Return _PSCPRVCL
        End Get
        Set(ByVal value As String)
            _PSCPRVCL = value
        End Set
    End Property

    Public Property PSPNNMOS() As String
        Get
            Return _PSPNNMOS
        End Get
        Set(ByVal value As String)
            _PSPNNMOS = value
        End Set
    End Property

    Public Property PSDOCEMB() As String
        Get
            Return _PSDOCEMB
        End Get
        Set(ByVal value As String)
            _PSDOCEMB = value
        End Set
    End Property


    Public Property PSNORSCI() As String
        Get
            Return _PSNORSCI
        End Get
        Set(ByVal value As String)
            _PSNORSCI = value
        End Set
    End Property



    Public Property PSNREFCL() As String
        Get
            Return _PSNREFCL
        End Get
        Set(ByVal value As String)
            _PSNREFCL = value
        End Set
    End Property


    Public Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property

    Public Property PSNORCML() As String
        Get
            Return _PSNORCML
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property PSNORCML_VERTICAL() As String
        Get
            Return _PSNORCML_VERTICAL
        End Get
        Set(ByVal value As String)
            _PSNORCML_VERTICAL = value
        End Set
    End Property

    Public Property PSOC() As String
        Get
            Return _PSOC
        End Get
        Set(ByVal value As String)
            _PSOC = value
        End Set
    End Property


    Public Property PSCMEDTR() As String
        Get
            Return _PSCMEDTR
        End Get
        Set(ByVal value As String)
            _PSCMEDTR = value
        End Set
    End Property

    Public Property PSCPAIS() As String
        Get
            Return _PSCPAIS
        End Get
        Set(ByVal value As String)
            _PSCPAIS = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Public Property PSTPSRVA() As String
        Get
            Return _PSTPSRVA
        End Get
        Set(ByVal value As String)
            _PSTPSRVA = value
        End Set
    End Property

    Public Property PSEMBARQUES() As String
        Get
            Return _PSEMBARQUES
        End Get
        Set(ByVal value As String)
            _PSEMBARQUES = value
        End Set
    End Property


    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property


End Class

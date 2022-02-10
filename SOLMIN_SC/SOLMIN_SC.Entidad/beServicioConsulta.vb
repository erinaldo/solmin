Public Class beServicioConsulta

    Private _PSCDVSN As String = ""
    Private _PSCCMPN As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _PNCCLNFC As Decimal = 0
    Private _PSFLGFAC As String = ""
    Private _PNNORSCI As Decimal = 0
    Private _PSSCCLNT As String = ""
    Private _PNFECINI As Decimal = 0
    Private _PNFECFIN As Decimal = 0
    Private _PSSESTRG_SEG As String = ""
    Private _PSFLGFAC_SERV As String = ""
    Private _PSFLAG_SECUENCIA As String = ""
    Private _PNCPLNDV As Decimal = 0
    Private _PNFECSER As Decimal = 0
    Private _PNFOPRCN As Decimal = 0

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

    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Public Property PNCCLNFC() As Decimal
        Get
            Return _PNCCLNFC
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNFC = value
        End Set
    End Property

    Public Property PSFLGFAC() As String
        Get
            Return _PSFLGFAC
        End Get
        Set(ByVal value As String)
            _PSFLGFAC = value
        End Set
    End Property
    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property



    Public Property PSSCCLNT() As String
        Get
            Return _PSSCCLNT
        End Get
        Set(ByVal value As String)
            _PSSCCLNT = value
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



    Public Property PSSESTRG_SEG() As String
        Get
            Return _PSSESTRG_SEG
        End Get
        Set(ByVal value As String)
            _PSSESTRG_SEG = value
        End Set
    End Property



    Public Property PSFLGFAC_SERV() As String
        Get
            Return _PSFLGFAC_SERV
        End Get
        Set(ByVal value As String)
            _PSFLGFAC_SERV = value
        End Set
    End Property



    Public Property PNFECSER() As Decimal
        Get
            Return _PNFECSER
        End Get
        Set(ByVal value As Decimal)
            _PNFECSER = value
        End Set
    End Property


    Public Property PSFLAG_SECUENCIA() As String
        Get
            Return _PSFLAG_SECUENCIA
        End Get
        Set(ByVal value As String)
            _PSFLAG_SECUENCIA = value
        End Set
    End Property


    Public Property PNFOPRCN() As Decimal
        Get
            Return _PNFOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNFOPRCN = value
        End Set
    End Property



End Class

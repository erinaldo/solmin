Public Class beIndicador
    Inherits beBase(Of beIndicador)

    Private _PNCCLNT As Decimal = 0
    Private _PSTCMPL As String = ""
    Private _PNFECHA As Decimal = 0
    Private _PSCCMPN As String = ""
    Private _PSTCMPCM As String = ""
    Private _PSCDVSN As String = ""
    Private _PSTCMPDV As String = ""
    Private _PNANIOEMI As Decimal = 0
    Private _PNMESEMI As Decimal = 0
    Private _PNDDEMI As Decimal = 0
    Private _PNCTPOIN As Decimal = 0
    Private _PNQAINSM As Decimal = 0
    Private _PSSESTRG As String = ""
    Private _PSCUSCRT As String = ""
    Private _PNFCHCRT As Decimal = 0
    Private _PNHRACRT As Decimal = 0
    Private _PSNTRMCR As String = ""
    Private _PSCULUSA As String = ""
    Private _PSNTRMNL As String = ""
    Private _PNMAXDIAS As Decimal = 0
    Private _PSCUNDMD As String = ""
    Private _PSTTPOIN As String = ""
    Private _PSTINDCD As String = ""
    Private _PSSINDC As String = ""
    Private _PSABREVMES As String = ""
    Private _PSCABECERACOL As String = ""
    Private _PNFILA As Decimal = 0
    Private _PSFILTRO_CTPOIN As String = ""
    Private _PSTOBACT As String = ""

#Region "Propiedades"

    Public Property PSTOBACT() As String
        Get
            Return _PSTOBACT
        End Get
        Set(ByVal value As String)
            _PSTOBACT = value
        End Set
    End Property

    Public Property PSFILTRO_CTPOIN() As String
        Get
            Return _PSFILTRO_CTPOIN
        End Get
        Set(ByVal value As String)
            _PSFILTRO_CTPOIN = value
        End Set
    End Property

    Public Property PNFILA() As Decimal
        Get
            Return _PNFILA
        End Get
        Set(ByVal value As Decimal)
            _PNFILA = value
        End Set
    End Property

    Public Property PSABREVMES() As String
        Get
            Return _PSABREVMES
        End Get
        Set(ByVal value As String)
            _PSABREVMES = value
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

    Public Property PSTCMPL() As String
        Get
            Return _PSTCMPL
        End Get
        Set(ByVal value As String)
            _PSTCMPL = value
        End Set
    End Property

    Public Property PNFECHA() As Decimal
        Get
            Return _PNFECHA
        End Get
        Set(ByVal value As Decimal)
            _PNFECHA = value
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

    Public Property PSTCMPCM() As String
        Get
            Return _PSTCMPCM
        End Get
        Set(ByVal value As String)
            _PSTCMPCM = value
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

    Public Property PSTCMPDV() As String
        Get
            Return _PSTCMPDV
        End Get
        Set(ByVal value As String)
            _PSTCMPDV = value
        End Set
    End Property

    Public Property PNANIOEMI() As Decimal
        Get
            Return _PNANIOEMI
        End Get
        Set(ByVal value As Decimal)
            _PNANIOEMI = value
        End Set
    End Property

    Public Property PNMESEMI() As Decimal
        Get
            Return _PNMESEMI
        End Get
        Set(ByVal value As Decimal)
            _PNMESEMI = value
        End Set
    End Property

    Public Property PNDDEMI() As Decimal
        Get
            Return _PNDDEMI
        End Get
        Set(ByVal value As Decimal)
            _PNDDEMI = value
        End Set
    End Property

    Public Property PNCTPOIN() As Decimal
        Get
            Return _PNCTPOIN
        End Get
        Set(ByVal value As Decimal)
            _PNCTPOIN = value
        End Set
    End Property

    Public Property PNQAINSM() As Decimal
        Get
            Return _PNQAINSM
        End Get
        Set(ByVal value As Decimal)
            _PNQAINSM = value
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

    Public Property PSCUSCRT() As String
        Get
            Return _PSCUSCRT
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property



    Public Property PNFCHCRT() As Decimal
        Get
            Return _PNFCHCRT
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property

    Public Property PNHRACRT() As Decimal
        Get
            Return _PNHRACRT
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
        End Set
    End Property


    Public Property PSNTRMCR() As String
        Get
            Return _PSNTRMCR
        End Get
        Set(ByVal value As String)
            _PSNTRMCR = value
        End Set
    End Property

    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property

    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property



    Public Property PNMAXDIAS() As Decimal
        Get
            Return _PNMAXDIAS
        End Get
        Set(ByVal value As Decimal)
            _PNMAXDIAS = value
        End Set
    End Property


    Public Property PSCUNDMD() As String
        Get
            Return _PSCUNDMD
        End Get
        Set(ByVal value As String)
            _PSCUNDMD = value
        End Set
    End Property


    Public Property PSTTPOIN() As String
        Get
            Return _PSTTPOIN
        End Get
        Set(ByVal value As String)
            _PSTTPOIN = value
        End Set
    End Property

    Public Property PSSINDC() As String
        Get
            Return _PSSINDC
        End Get
        Set(ByVal value As String)
            _PSSINDC = value
        End Set
    End Property

    Public Property PSCABECERACOL() As String
        Get
            Return _PSCABECERACOL
        End Get
        Set(ByVal value As String)
            _PSCABECERACOL = value
        End Set
    End Property

    Public Property PSTINDCD() As String
        Get
            Return _PSTINDCD
        End Get
        Set(ByVal value As String)
            _PSTINDCD = value
        End Set
    End Property

#End Region

  

End Class

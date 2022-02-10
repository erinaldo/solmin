Public Class beAlcanceServicio
    Inherits Base_BE(Of beAlcanceServicio)

    Private _CCMPN As String
    Private _CDVSN As String
    Private _CCLNT As Decimal
    Private _NCRRLT As Decimal
    Private _TDALSR As String
    Private _TINDMD As String
    Private _QMDALS As Decimal
    Private _CUNDSR As String
    Private _TRFMED As String
    Private _TFRMMD As String
    Private _SESTRG As String
    Private _CUSCRT As String
    Private _FCHCRT As Decimal
    Private _HRACRT As Decimal
    Private _NTRMCR As String
    Private _CULUSA As String
    Private _FULTAC As Decimal
    Private _HULTAC As Decimal
    Private _NTRMNL As String
    Private _UPDATE_IDENT As Decimal

    Public Property PSCCMPN() As String
        Get
            Return (_CCMPN)
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property PSCDVSN() As String
        Get
            Return (_CDVSN)
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property
    Public Property PNCCLNT() As Decimal
        Get
            Return (_CCLNT)
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property
    Public Property PNNCRRLT() As Decimal
        Get
            Return (_NCRRLT)
        End Get
        Set(ByVal value As Decimal)
            _NCRRLT = value
        End Set
    End Property
    Public Property PSTDALSR() As String
        Get
            Return (_TDALSR)
        End Get
        Set(ByVal value As String)
            _TDALSR = value
        End Set
    End Property
    Public Property PSTINDMD() As String
        Get
            Return (_TINDMD)
        End Get
        Set(ByVal value As String)
            _TINDMD = value
        End Set
    End Property
    Public Property PNQMDALS() As Decimal
        Get
            Return (_QMDALS)
        End Get
        Set(ByVal value As Decimal)
            _QMDALS = value
        End Set
    End Property
    Public Property PSCUNDSR() As String
        Get
            Return (_CUNDSR)
        End Get
        Set(ByVal value As String)
            _CUNDSR = value
        End Set
    End Property
    Public Property PSTRFMED() As String
        Get
            Return (_TRFMED)
        End Get
        Set(ByVal value As String)
            _TRFMED = value
        End Set
    End Property
    Public Property PSTFRMMD() As String
        Get
            Return (_TFRMMD)
        End Get
        Set(ByVal value As String)
            _TFRMMD = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return (_SESTRG)
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property
    Public Property PSCUSCRT() As String
        Get
            Return (_CUSCRT)
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_FCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_HRACRT)
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property
    Public Property PSNTRMCR() As String
        Get
            Return (_NTRMCR)
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return (_CULUSA)
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property
    Public Property PNFULTAC() As Decimal
        Get
            Return (_FULTAC)
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_HULTAC)
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property
    Public Property PSNTRMNL() As String
        Get
            Return (_NTRMNL)
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property


    Private _TCMPCL As String
    Public Property PSTCMPCL() As String
        Get
            Return _TCMPCL
        End Get
        Set(ByVal value As String)
            _TCMPCL = value
        End Set
    End Property



    Private _PNNANASR As Decimal
    Public Property PNNANASR() As Decimal
        Get
            Return _PNNANASR
        End Get
        Set(ByVal value As Decimal)
            _PNNANASR = value
        End Set
    End Property


    Private _PNNMSASR As Decimal
    Public Property PNNMSASR() As Decimal
        Get
            Return _PNNMSASR
        End Get
        Set(ByVal value As Decimal)
            _PNNMSASR = value
        End Set
    End Property


    Private _PSTCMPDV As String
    Public Property PSTCMPDV() As String
        Get
            Return _PSTCMPDV
        End Get
        Set(ByVal value As String)
            _PSTCMPDV = value
        End Set
    End Property


    Private _PSTABRUN As String
    Public Property PSTABRUN() As String
        Get
            Return _PSTABRUN
        End Get
        Set(ByVal value As String)
            _PSTABRUN = value
        End Set
    End Property


    Private _PNQMDASC As Decimal
    Public Property PNQMDASC() As Decimal
        Get
            Return _PNQMDASC
        End Get
        Set(ByVal value As Decimal)
            _PNQMDASC = value
        End Set
    End Property

    Private _PSTSRVC As String
    Public Property PSTSRVC() As String
        Get
            Return _PSTSRVC
        End Get
        Set(ByVal value As String)
            _PSTSRVC = value
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

End Class
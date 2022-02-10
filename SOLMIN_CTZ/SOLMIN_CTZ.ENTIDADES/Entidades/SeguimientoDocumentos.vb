Public Class SeguimientoDocumentos
    Inherits Base(Of SeguimientoDocumentos)

    Private _CCMPN As String = String.Empty
    Private _CTPODC As String = String.Empty
    Private _NDCCTC As Decimal = 0
    Private _NCRRSG As Decimal = 0
    Private _CDSGDC As Decimal = 0
    Private _FDSGDC As Decimal = 0
    Private _HDSGDC As Decimal = 0
    Private _URSPDC As String = String.Empty
    Private _TOBSSG As String = String.Empty
    Private _FCNFCL As Decimal = 0
    Private _HCNFCL As Decimal = 0
    Private _SESTSG As String = String.Empty
    Private _SESTRG As String = String.Empty
    Private _CUSCRT As String = String.Empty
    Private _NTRMCR As String = String.Empty
    Private _NRSGDC As Decimal = 0

    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Property CTPODC() As String
        Get
            Return _CTPODC
        End Get
        Set(ByVal value As String)
            _CTPODC = value
        End Set
    End Property

    Property NDCCTC() As Decimal
        Get
            Return _NDCCTC
        End Get
        Set(ByVal value As Decimal)
            _NDCCTC = value
        End Set
    End Property

    Property NCRRSG() As Decimal
        Get
            Return _NCRRSG
        End Get
        Set(ByVal value As Decimal)
            _NCRRSG = value
        End Set
    End Property

    Property CDSGDC() As Decimal
        Get
            Return _CDSGDC
        End Get
        Set(ByVal value As Decimal)
            _CDSGDC = value
        End Set
    End Property

    Property FDSGDC() As Decimal
        Get
            Return _FDSGDC
        End Get
        Set(ByVal value As Decimal)
            _FDSGDC = value
        End Set
    End Property

    Property HDSGDC() As Decimal
        Get
            Return _HDSGDC
        End Get
        Set(ByVal value As Decimal)
            _HDSGDC = value
        End Set
    End Property

    Property URSPDC() As String
        Get
            Return _URSPDC
        End Get
        Set(ByVal value As String)
            _URSPDC = value
        End Set
    End Property

    Property TOBSSG() As String
        Get
            Return _TOBSSG
        End Get
        Set(ByVal value As String)
            _TOBSSG = value
        End Set
    End Property

    Property FCNFCL() As Decimal
        Get
            Return _FCNFCL
        End Get
        Set(ByVal value As Decimal)
            _FCNFCL = value
        End Set
    End Property

    Property HCNFCL() As Decimal
        Get
            Return _HCNFCL
        End Get
        Set(ByVal value As Decimal)
            _HCNFCL = value
        End Set
    End Property

    Property SESTSG() As String
        Get
            Return _SESTSG
        End Get
        Set(ByVal value As String)
            _SESTSG = value
        End Set
    End Property

    Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Property NRSGDC() As Decimal
        Get
            Return _NRSGDC
        End Get
        Set(ByVal value As Decimal)
            _NRSGDC = value
        End Set
    End Property
End Class

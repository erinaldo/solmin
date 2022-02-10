Public Class Rango
    Private _NRRNGO As Double = 0
    Private _CUNDMD As String = ""
    Private _DESRNG As String = ""
    Private _VALMAX As Double = 0
    Private _VALMIN As Double = 0
    Private _VALCTE As Double = 0
    Private _STPTRA As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""

    Property STPTRA() As String
        Get
            Return _STPTRA
        End Get
        Set(ByVal value As String)
            _STPTRA = value
        End Set
    End Property

    Property NRRNGO() As Double
        Get
            Return _NRRNGO
        End Get
        Set(ByVal value As Double)
            _NRRNGO = value
        End Set
    End Property

    Property DESRNG() As String
        Get
            Return _DESRNG
        End Get
        Set(ByVal value As String)
            _DESRNG = value
        End Set
    End Property

    Property CUNDMD() As String
        Get
            Return _CUNDMD
        End Get
        Set(ByVal value As String)
            _CUNDMD = value
        End Set
    End Property

    Property VALMAX() As Double
        Get
            Return _VALMAX
        End Get
        Set(ByVal value As Double)
            _VALMAX = value
        End Set
    End Property

    Property VALMIN() As Double
        Get
            Return _VALMIN
        End Get
        Set(ByVal value As Double)
            _VALMIN = value
        End Set
    End Property

    Property VALCTE() As Double
        Get
            Return _VALCTE
        End Get
        Set(ByVal value As Double)
            _VALCTE = value
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
End Class


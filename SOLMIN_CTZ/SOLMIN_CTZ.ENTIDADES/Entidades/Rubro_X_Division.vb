Public Class Rubro_X_Division
    Private _NRRUBR As Double = 0
    Private _NRRBDV As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""

    Property NRRUBR() As Double
        Get
            Return _NRRUBR
        End Get
        Set(ByVal value As Double)
            _NRRUBR = value
        End Set
    End Property

    Property NRRBDV() As Double
        Get
            Return _NRRBDV
        End Get
        Set(ByVal value As Double)
            _NRRBDV = value
        End Set
    End Property

    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
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

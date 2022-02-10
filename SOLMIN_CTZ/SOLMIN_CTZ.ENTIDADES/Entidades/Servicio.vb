Public Class Servicio
    Private _NRSERV As Double = 0
    Private _NOMSER As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""

    Property NRSERV() As Double
        Get
            Return _NRSERV
        End Get
        Set(ByVal value As Double)
            _NRSERV = value
        End Set
    End Property

    Property NOMSER() As String
        Get
            Return _NOMSER
        End Get
        Set(ByVal value As String)
            _NOMSER = value
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

Public Class OrdenServicioTransporte
    Private _CCMPN As String = ""
    Private _NCTZCN As Integer = 0
    Private _NCRRCT As Integer = 0
    Private _SESTOS As String = ""
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""

    Public NORSRT As Decimal = 0
    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Property NCTZCN() As Integer
        Get
            Return _NCTZCN
        End Get
        Set(ByVal value As Integer)
            _NCTZCN = value
        End Set
    End Property


    Property NCRRCT() As Integer
        Get
            Return _NCRRCT
        End Get
        Set(ByVal value As Integer)
            _NCRRCT = value
        End Set
    End Property

    Property SESTOS() As String
        Get
            Return _SESTOS
        End Get
        Set(ByVal value As String)
            _SESTOS = value
        End Set
    End Property

    Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property


    Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

End Class

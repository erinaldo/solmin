
Public Class ServicioTransporte

    Dim _CCMPN As String
    Dim _CTPOSR As String
    Dim _TCMTPS As String
    Dim _TABTPS As String
    Dim _FULTAC As String
    Dim _HULTAC As String
    Dim _CULUSA As String
    Dim _NTRMNL As String
    Dim _CUSCRT As String
    Dim _FCHCRT As String
    Dim _HRACRT As String
    Dim _NTRMCR As String
    Dim _UPDATE_IDENT As String

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal Value As String)
            _CCMPN = Value
        End Set
    End Property

    Public Property CTPOSR() As String
        Get
            Return _CTPOSR
        End Get
        Set(ByVal Value As String)
            _CTPOSR = Value
        End Set
    End Property

    Public Property TCMTPS() As String
        Get
            Return _TCMTPS
        End Get
        Set(ByVal Value As String)
            _TCMTPS = Value
        End Set
    End Property

    Public Property TABTPS() As String
        Get
            Return _TABTPS
        End Get
        Set(ByVal Value As String)
            _TABTPS = Value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal Value As String)
            _CULUSA = Value
        End Set
    End Property

    Public Property FULTAC() As String
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As String)
            _FULTAC = Value
        End Set
    End Property

    Public Property HULTAC() As String
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As String)
            _HULTAC = Value
        End Set
    End Property

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal Value As String)
            _NTRMNL = Value
        End Set
    End Property

    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal Value As String)
            _CUSCRT = Value
        End Set
    End Property

    Public Property FCHCRT() As String
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As String)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As String
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As String)
            _HRACRT = Value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal Value As String)
            _NTRMCR = Value
        End Set
    End Property

    Public Property UPDATE_IDENT() As String
        Get
            Return _UPDATE_IDENT
        End Get
        Set(ByVal Value As String)
            _UPDATE_IDENT = Value
        End Set
    End Property

End Class


Public Class DatosAdiionalGuiaRemision

    Private _CCLNT As Integer
    Private _NGUIRM As Integer
    Private _CLCRGA As String = ""
    Private _UPROGM As String = ""
    Private _EMAPRB As String = ""
    Private _USLCNT As String = ""
    Private _APRBDO As String = ""
    Private _GRENCI As String = ""
    Private _AREASL As String = ""

    Public Property CCLNT() As Integer
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Integer)
            _CCLNT = value
        End Set
    End Property

    Public Property NGUIRM() As Integer
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As Integer)
            _NGUIRM = value
        End Set
    End Property

    Public Property CLCRGA() As String
        Get
            Return _CLCRGA
        End Get
        Set(ByVal value As String)
            _CLCRGA = value
        End Set
    End Property

    Public Property UPROGM() As String
        Get
            Return _UPROGM
        End Get
        Set(ByVal value As String)
            _UPROGM = value
        End Set
    End Property

    Public Property EMAPRB() As String
        Get
            Return _EMAPRB
        End Get
        Set(ByVal value As String)
            _EMAPRB = value
        End Set
    End Property

    Public Property USLCNT() As String
        Get
            Return _USLCNT
        End Get
        Set(ByVal value As String)
            _USLCNT = value
        End Set
    End Property

    Public Property APRBDO() As String
        Get
            Return _APRBDO
        End Get
        Set(ByVal value As String)
            _APRBDO = value
        End Set
    End Property

    Public Property GRENCI() As String
        Get
            Return _GRENCI
        End Get
        Set(ByVal value As String)
            _GRENCI = value
        End Set
    End Property

    Public Property AREASL() As String
        Get
            Return _AREASL
        End Get
        Set(ByVal value As String)
            _AREASL = value
        End Set
    End Property
End Class

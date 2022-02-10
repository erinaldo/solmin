Public Class RegionVenta

    Private _CSCDSP As String = ""
    Public Property CSCDSP() As String 'RCS-HUNDRED
        Get
            Return _CSCDSP
        End Get
        Set(ByVal value As String) 'RCS-HUNDRED
            _CSCDSP = value
        End Set
    End Property

    Private _TCRVTA As String = ""
    Public Property TCRVTA() As String
        Get
            Return _TCRVTA
        End Get
        Set(ByVal value As String)
            _TCRVTA = value
        End Set
    End Property

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Private _CRGVTA As String = ""
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

End Class

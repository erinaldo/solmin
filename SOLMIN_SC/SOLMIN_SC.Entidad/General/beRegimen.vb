Public Class beRegimen

    Private _PSCCMPN As String = ""
    Private _PNTPORGE As Decimal = 0
    Private _PSTPSRVA As String = ""
    Private _PSTCMRGA As String = ""
    Private _PSTCMRGI As String = ""
    Private _PSVIGENCIA As String = ""

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PNTPORGE() As Decimal
        Get
            Return _PNTPORGE
        End Get
        Set(ByVal value As Decimal)
            _PNTPORGE = value
        End Set
    End Property
    Public Property PSTPSRVA() As String
        Get
            Return _PSTPSRVA
        End Get
        Set(ByVal value As String)
            _PSTPSRVA = value
        End Set
    End Property

    Public Property PSTCMRGA() As String
        Get
            Return _PSTCMRGA
        End Get
        Set(ByVal value As String)
            _PSTCMRGA = value
        End Set
    End Property


    Public Property PSTCMRGI() As String
        Get
            Return _PSTCMRGI
        End Get
        Set(ByVal value As String)
            _PSTCMRGI = value
        End Set
    End Property

    Public Property PSVIGENCIA() As String
        Get
            Return _PSVIGENCIA
        End Get
        Set(ByVal value As String)
            _PSVIGENCIA = value
        End Set
    End Property


End Class

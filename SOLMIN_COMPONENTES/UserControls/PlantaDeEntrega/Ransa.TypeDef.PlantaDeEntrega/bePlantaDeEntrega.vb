Public Class bePlantaDeEntrega
    Inherits beBase
    Private _PNCCLNT As Decimal
    Private _PNCPLNCL As Decimal
    Private _PSTCMPPL As String
    Private _PSTDRCPL As String
    Private _TIPOCLIENTE As Boolean

    Private _PNCUBGEO As Decimal = 0
    Private _PSUBIGEO As String = ""
    Public Property TIPOCLIENTE() As Boolean
        Get
            Return _TIPOCLIENTE
        End Get
        Set(ByVal value As Boolean)
            _TIPOCLIENTE = value
        End Set
    End Property


    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PNCPLNCL() As Decimal
        Get
            Return (_PNCPLNCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNCL = value
        End Set
    End Property
    Public Property PSTCMPPL() As String
        Get
            Return (_PSTCMPPL)
        End Get
        Set(ByVal value As String)
            _PSTCMPPL = value
        End Set
    End Property
    Public Property PSTDRCPL() As String
        Get
            Return (_PSTDRCPL)
        End Get
        Set(ByVal value As String)
            _PSTDRCPL = value
        End Set
    End Property

    Public Sub New()
        _PNCCLNT = 0
        _PNCPLNCL = 0
        _PSTCMPPL = ""
        _PSTDRCPL = ""
        _TIPOCLIENTE = True
        _PNCPRVCL = 0
        _PSTPRVCL = ""
        _PSTDRPRC = ""
    End Sub

    Private _PNCPRVCL As Decimal
    Public Property PNCPRVCL() As Decimal
        Get
            Return _PNCPRVCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property


    Private _PNCPLCLP As Decimal
    Public Property PNCPLCLP() As Decimal
        Get
            Return _PNCPLCLP
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP = value
        End Set
    End Property


    Private _PSTPRVCL As String
    Public Property PSTPRVCL() As String
        Get
            Return _PSTPRVCL
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property


    Private _PSTDRPRC As String
    Public Property PSTDRPRC() As String
        Get
            Return _PSTDRPRC
        End Get
        Set(ByVal value As String)
            _PSTDRPRC = value
        End Set
    End Property



    Private _PSSTPORL As String
    Public Property PSSTPORL() As String
        Get
            Return _PSSTPORL
        End Get
        Set(ByVal value As String)
            _PSSTPORL = value
        End Set
    End Property


    Private _PSCPRPCL As String
    Public Property PSCPRPCL() As String
        Get
            Return _PSCPRPCL
        End Get
        Set(ByVal value As String)
            _PSCPRPCL = value
        End Set
    End Property

    Private _PNCPSRVCL As Decimal
    Public Property PNCPSRVCL() As Decimal
        Get
            Return _PNCPSRVCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPSRVCL = value
        End Set
    End Property


    Private _PNNRUCPR As Decimal
    Public Property PNNRUCPR() As Decimal
        Get
            Return _PNNRUCPR
        End Get
        Set(ByVal value As Decimal)
            _PNNRUCPR = value
        End Set
    End Property


    Private _PSCPLNAF As String
    Public Property PSCPLNAF() As String
        Get
            Return _PSCPLNAF
        End Get
        Set(ByVal value As String)
            _PSCPLNAF = value
        End Set
    End Property


    Public Property PNCUBGEO() As Decimal
        Get
            Return _PNCUBGEO
        End Get
        Set(ByVal value As Decimal)
            _PNCUBGEO = value
        End Set
    End Property

    Public Property PSUBIGEO() As String
        Get
            Return _PSUBIGEO
        End Get
        Set(ByVal value As String)
            _PSUBIGEO = value
        End Set
    End Property
 

End Class
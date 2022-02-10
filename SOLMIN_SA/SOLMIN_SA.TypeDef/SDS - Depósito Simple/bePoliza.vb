Public Class bePoliza
    Inherits beBase(Of bePoliza)

    Private _PNNPLZA As Decimal = 0
    Private _PNFPRPLZ As Decimal = 0
    Private _PNCCNDPL As Decimal = 0
    Private _PNQBLTPL As Decimal = 0
    Private _PNQPBRPL As Decimal = 0
    Private _PNNPDDPR As Decimal = 0

    Private _PNNLERUC As Decimal = 0
    Private _PSTCMCPL As String = ""
    Private _PNIFOBPL As Decimal = 0
    Private _PNIFLTPL As Decimal = 0
    Private _PNISGRPL As Decimal = 0
    Private _PNICIFPL As Decimal = 0
    Private _PNICNCLQ As Decimal = 0
    Private _PNFCNCLQ As Decimal = 0
    Private _PNNLQDAD As Decimal = 0
    Private _PSNOFCAD As String = ""
    Private _PNQPNTPL As Decimal = 0
    Private _PNQUNFPL As Decimal = 0
    Private _PNQBLDSP As Decimal = 0
    Private _PNQPNDSP As Decimal = 0
    Private _PNQPBDSP As Decimal = 0


    Public Property PNNPLZA() As Decimal
        Get
            Return (_PNNPLZA)
        End Get
        Set(ByVal value As Decimal)
            _PNNPLZA = value
        End Set
    End Property

    Private _FechaPresentacion As String
    Public Property PNFPRPLZ() As Decimal
        Get
            Return CtypeDate(_FechaPresentacion)
        End Get
        Set(ByVal value As Decimal)
            _FechaPresentacion = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaPresentacion() As String
        Get
            Return _FechaPresentacion
        End Get
        Set(ByVal value As String)
            _FechaPresentacion = value
        End Set
    End Property

    Public Property PNCCNDPL() As Decimal
        Get
            Return (_PNCCNDPL)
        End Get
        Set(ByVal value As Decimal)
            _PNCCNDPL = value
        End Set
    End Property
    Public Property PNQBLTPL() As Decimal
        Get
            Return (_PNQBLTPL)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLTPL = value
        End Set
    End Property
    Public Property PNQPBRPL() As Decimal
        Get
            Return (_PNQPBRPL)
        End Get
        Set(ByVal value As Decimal)
            _PNQPBRPL = value
        End Set
    End Property

    Public Property PNNPDDPR() As Decimal
        Get
            Return (_PNNPDDPR)
        End Get
        Set(ByVal value As Decimal)
            _PNNPDDPR = value
        End Set
    End Property

    Public Property PNNLERUC() As Decimal
        Get
            Return (_PNNLERUC)
        End Get
        Set(ByVal value As Decimal)
            _PNNLERUC = value
        End Set
    End Property

    Public Property PSTCMCPL() As String
        Get
            Return (_PSTCMCPL)
        End Get
        Set(ByVal value As String)
            _PSTCMCPL = value
        End Set
    End Property

    Public Property PNIFOBPL() As Decimal
        Get
            Return (_PNIFOBPL)
        End Get
        Set(ByVal value As Decimal)
            _PNIFOBPL = value
        End Set
    End Property

    Public Property PNIFLTPL() As Decimal
        Get
            Return (_PNIFLTPL)
        End Get
        Set(ByVal value As Decimal)
            _PNIFLTPL = value
        End Set
    End Property

    Public Property PNISGRPL() As Decimal
        Get
            Return (_PNISGRPL)
        End Get
        Set(ByVal value As Decimal)
            _PNISGRPL = value
        End Set
    End Property

    Public Property PNICIFPL() As Decimal
        Get
            Return (_PNICIFPL)
        End Get
        Set(ByVal value As Decimal)
            _PNICIFPL = value
        End Set
    End Property

    Public Property PNICNCLQ() As Decimal
        Get
            Return (_PNICNCLQ)
        End Get
        Set(ByVal value As Decimal)
            _PNICNCLQ = value
        End Set
    End Property

    Private _FechaCancelacion As String
    Public Property PNFCNCLQ() As Decimal
        Get
            Return CtypeDate(_FechaCancelacion)
        End Get
        Set(ByVal value As Decimal)
            _FechaCancelacion = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaCancelacion() As String
        Get
            Return _FechaCancelacion
        End Get
        Set(ByVal value As String)
            _FechaCancelacion = value
        End Set
    End Property

    Public Property PNNLQDAD() As Decimal
        Get
            Return (_PNNLQDAD)
        End Get
        Set(ByVal value As Decimal)
            _PNNLQDAD = value
        End Set
    End Property

    Public Property PSNOFCAD() As String
        Get
            Return (_PSNOFCAD)
        End Get
        Set(ByVal value As String)
            _PSNOFCAD = value
        End Set
    End Property

    Public Property PNQPNTPL() As Decimal
        Get
            Return (_PNQPNTPL)
        End Get
        Set(ByVal value As Decimal)
            _PNQPNTPL = value
        End Set
    End Property

    Public Property PNQUNFPL() As Decimal
        Get
            Return (_PNQUNFPL)
        End Get
        Set(ByVal value As Decimal)
            _PNQUNFPL = value
        End Set
    End Property

    Public Property PNQBLDSP() As Decimal
        Get
            Return (_PNQBLDSP)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLDSP = value
        End Set
    End Property

    Public Property PNQPNDSP() As Decimal
        Get
            Return (_PNQPNDSP)
        End Get
        Set(ByVal value As Decimal)
            _PNQPNDSP = value
        End Set
    End Property

    Public Property PNQPBDSP() As Decimal
        Get
            Return (_PNQPBDSP)
        End Get
        Set(ByVal value As Decimal)
            _PNQPBDSP = value
        End Set
    End Property


End Class

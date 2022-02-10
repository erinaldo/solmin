Public Class DetalleGasto_BE
    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-INICIO
    Private _ccmpn As String = String.Empty
    Public Property PSCCMPN() As String
        Get
            Return _ccmpn
        End Get
        Set(ByVal value As String)
            _ccmpn = value
        End Set
    End Property

    Private _ponnlqgst As String = String.Empty
    Public Property PONNLQGST() As String
        Get
            Return _ponnlqgst
        End Get
        Set(ByVal value As String)
            _ponnlqgst = value
        End Set
    End Property

    Private _pnnoprcn As String = String.Empty
    Public Property PNNOPRCN() As String
        Get
            Return _pnnoprcn
        End Get
        Set(ByVal value As String)
            _pnnoprcn = value
        End Set
    End Property

    Private _pnncrrrt As String = String.Empty
    Public Property PNNCRRRT() As String
        Get
            Return _pnncrrrt
        End Get
        Set(ByVal value As String)
            _pnncrrrt = value
        End Set
    End Property

    Private _pncgstos As String = String.Empty
    Public Property PNCGSTOS() As String
        Get
            Return _pncgstos
        End Get
        Set(ByVal value As String)
            _pncgstos = value
        End Set
    End Property

    Private _pncdmnda As String = String.Empty
    Public Property PNCDMNDA() As String
        Get
            Return _pncdmnda
        End Get
        Set(ByVal value As String)
            _pncdmnda = value
        End Set
    End Property

    Private _pnigstos As String = String.Empty
    Public Property PNIGSTOS() As String
        Get
            Return _pnigstos
        End Get
        Set(ByVal value As String)
            _pnigstos = value
        End Set
    End Property

    Private _pstobdct As String = String.Empty
    Public Property PSTOBDCT() As String
        Get
            Return _pstobdct
        End Get
        Set(ByVal value As String)
            _pstobdct = value
        End Set
    End Property

    Private _psculusa As String = String.Empty
    Public Property PSCULUSA() As String
        Get
            Return _psculusa
        End Get
        Set(ByVal value As String)
            _psculusa = value
        End Set
    End Property

    Private _psntrmnl As String = String.Empty
    Public Property PSNTRMNL() As String
        Get
            Return _psntrmnl
        End Get
        Set(ByVal value As String)
            _psntrmnl = value
        End Set
    End Property

    Private _pnnfecini As Decimal = 0
    Public Property PNNFECINI() As Decimal
        Get
            Return _pnnfecini
        End Get
        Set(ByVal value As Decimal)
            _pnnfecini = value
        End Set
    End Property

    Private _pnnfecfin As Decimal = 0
    Public Property PNNFECFIN() As Decimal
        Get
            Return _pnnfecfin
        End Get
        Set(ByVal value As Decimal)
            _pnnfecfin = value
        End Set
    End Property
    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-FIN
End Class

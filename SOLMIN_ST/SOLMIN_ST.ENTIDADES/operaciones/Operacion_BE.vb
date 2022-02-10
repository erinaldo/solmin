Public Class Operacion_BE
    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-INICIO
    Private _psccmpn As String = String.Empty
    Public Property PSCCMPN() As String
        Get
            Return _psccmpn
        End Get
        Set(ByVal value As String)
            _psccmpn = value
        End Set
    End Property

    Private _pscdvn As String = String.Empty
    Public Property PSCDVN() As String
        Get
            Return _pscdvn
        End Get
        Set(ByVal value As String)
            _pscdvn = value
        End Set
    End Property

    Private _pnnoprcn As Decimal = 0
    Public Property PNNOPRCN() As Decimal
        Get
            Return _pnnoprcn
        End Get
        Set(ByVal value As Decimal)
            _pnnoprcn = value
        End Set
    End Property

    Private _nlqgst_c As String = String.Empty
    Public Property NLQGST_C() As String
        Get
            Return _nlqgst_c
        End Get
        Set(ByVal value As String)
            _nlqgst_c = value
        End Set
    End Property

    Private _noprcn_c As String = String.Empty
    Public Property NOPRCN_C() As String
        Get
            Return _noprcn_c
        End Get
        Set(ByVal value As String)
            _noprcn_c = value
        End Set
    End Property

    Private _ncrrrt_c As String = String.Empty
    Public Property NCRRRT_C() As String
        Get
            Return _ncrrrt_c
        End Get
        Set(ByVal value As String)
            _ncrrrt_c = value
        End Set
    End Property


    Private _nrfsap As String = String.Empty
    Public Property NRFSAP() As String
        Get
            Return _nrfsap
        End Get
        Set(ByVal value As String)
            _nrfsap = value
        End Set
    End Property

    Private _aejins As String = String.Empty
    Public Property AEJINS() As String
        Get
            Return _aejins
        End Get
        Set(ByVal value As String)
            _aejins = value
        End Set
    End Property

    'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-FIN
End Class

Public Class beCheckPointFormato
    Private _PNNESTDO As Decimal = 0
    Private _PNFRETES_INICIAL As Decimal = 0
    Private _PNFRETES_FINAL As Decimal = 0
    Private _PSTDESES As String = ""
    Private _PSTDESES_HTML As String = ""
    Private _PBNESTDO_MODIFICADO As Boolean = False
    Private _PNORDEN_ANALIZAR As Int32 = 0

    Public Property PNNESTDO() As Decimal
        Get
            Return (_PNNESTDO)
        End Get
        Set(ByVal value As Decimal)
            _PNNESTDO = value
        End Set
    End Property
    Public Property PNFRETES_INICIAL() As Decimal
        Get
            Return (_PNFRETES_INICIAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFRETES_INICIAL = value
        End Set
    End Property
    Public Property PNFRETES_FINAL() As Decimal
        Get
            Return (_PNFRETES_FINAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFRETES_FINAL = value
        End Set
    End Property
    Public Property PBNESTDO_MODIFICADO() As Boolean
        Get
            Return (_PBNESTDO_MODIFICADO)
        End Get
        Set(ByVal value As Boolean)
            _PBNESTDO_MODIFICADO = value
        End Set
    End Property

    Public Property PSTDESES() As String
        Get
            Return _PSTDESES
        End Get
        Set(ByVal value As String)
            _PSTDESES = value
        End Set
    End Property
    Public Property PSTDESES_HTML() As String
        Get
            Return _PSTDESES_HTML
        End Get
        Set(ByVal value As String)
            _PSTDESES_HTML = value
        End Set
    End Property
    Public Property PNORDEN_ANALIZAR() As Int32
        Get
            Return _PNORDEN_ANALIZAR
        End Get
        Set(ByVal value As Int32)
            _PNORDEN_ANALIZAR = value
        End Set
    End Property
End Class

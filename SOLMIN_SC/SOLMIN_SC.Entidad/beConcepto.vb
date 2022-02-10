Public Class beConcepto

    Private _PSCODIGO As String = ""
    Private _PSDESCRIPCION As String = ""
    Private _PSVALOR As String = ""
    Private _PNVALORACTUAL As Decimal = 0
    Private _PNVALORIMPORTAR As Decimal = 0

    Public Property PSCODIGO() As String
        Get
            Return _PSCODIGO
        End Get
        Set(ByVal value As String)
            _PSCODIGO = value
        End Set
    End Property



    Public Property PSDESCRIPCION() As String
        Get
            Return _PSDESCRIPCION
        End Get
        Set(ByVal value As String)
            _PSDESCRIPCION = value
        End Set
    End Property



    Public Property PSVALOR() As String
        Get
            Return _PSVALOR
        End Get
        Set(ByVal value As String)
            _PSVALOR = value
        End Set
    End Property


    Public Property PNVALORACTUAL() As Decimal
        Get
            Return _PNVALORACTUAL
        End Get
        Set(ByVal value As Decimal)
            _PNVALORACTUAL = value
        End Set
    End Property


    Public Property PNVALORIMPORTAR() As Decimal
        Get
            Return _PNVALORIMPORTAR
        End Get
        Set(ByVal value As Decimal)
            _PNVALORIMPORTAR = value
        End Set
    End Property

End Class

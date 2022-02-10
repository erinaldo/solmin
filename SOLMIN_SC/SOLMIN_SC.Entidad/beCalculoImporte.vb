Public Class beCalculoImporte
    Private _PNIMPORTE_TOTAL_DOL As Decimal = 0
    Private _PNIMPORTE_TOTAL_SOL As Decimal = 0
    Private _PNIGV As Decimal = 0
    Private _PNIMPORTE_BASE_DOL As Decimal = 0
    Private _PNIMPORTE_BASE_SOL As Decimal = 0
    Private _PNIMPORTE_IGV_DOL As Decimal = 0
    Private _PNIMPORTE_IGV_SOL As Decimal = 0
  
    Public Property PNIMPORTE_TOTAL_DOL() As Decimal
        Get
            Return _PNIMPORTE_TOTAL_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_TOTAL_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_TOTAL_SOL() As Decimal
        Get
            Return _PNIMPORTE_TOTAL_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_TOTAL_SOL = value
        End Set
    End Property


    Public Property PNIMPORTE_BASE_DOL() As Decimal
        Get
            Return _PNIMPORTE_BASE_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_BASE_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_BASE_SOL() As Decimal
        Get
            Return _PNIMPORTE_BASE_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_BASE_SOL = value
        End Set
    End Property

    Public Property PNIGV() As Decimal
        Get
            Return _PNIGV
        End Get
        Set(ByVal value As Decimal)
            _PNIGV = value
        End Set
    End Property


    Public Property PNIMPORTE_IGV_DOL() As Decimal
        Get
            Return _PNIMPORTE_IGV_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_IGV_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_IGV_SOL() As Decimal
        Get
            Return _PNIMPORTE_IGV_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_IGV_SOL = value
        End Set
    End Property

End Class

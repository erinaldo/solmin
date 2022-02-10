Public Class beCostosRatio

    Private _PNINLAD As Decimal = 0
    Private _PNGFOB As Decimal = 0
    Private _PNFLETE As Decimal = 0
    Private _PNDUTIES As Decimal = 0
    Private _PNCOSTOS_ADICIONAL As Decimal = 0
    Private _PNFLETE_X100 As Decimal = 0
    Private _PNDUTIES_X100 As Decimal = 0
    Private _PNCOSTOS_ADICIONAL_X100 As Decimal = 0
    Private _PNCOSTOS_TOTAL_COSTOS As Decimal = 0
    Private _PNINLAD_X100 As Decimal = 0
    Private _PNGFOB_X100 As Decimal = 0

    Public Property PNINLAD() As Decimal
        Get
            Return _PNINLAD
        End Get
        Set(ByVal value As Decimal)
            _PNINLAD = value
        End Set
    End Property

    Public Property PNGFOB() As Decimal
        Get
            Return _PNGFOB
        End Get
        Set(ByVal value As Decimal)
            _PNGFOB = value
        End Set
    End Property

    Public Property PNFLETE() As Decimal
        Get
            Return _PNFLETE
        End Get
        Set(ByVal value As Decimal)
            _PNFLETE = value
        End Set
    End Property

    Public Property PNDUTIES() As Decimal
        Get
            Return _PNDUTIES
        End Get
        Set(ByVal value As Decimal)
            _PNDUTIES = value
        End Set
    End Property

    Public Property PNCOSTOS_ADICIONAL() As Decimal
        Get
            Return _PNCOSTOS_ADICIONAL
        End Get
        Set(ByVal value As Decimal)
            _PNCOSTOS_ADICIONAL = value
        End Set
    End Property



    Public Property PNINLAD_X100() As Decimal
        Get
            Return _PNINLAD_X100
        End Get
        Set(ByVal value As Decimal)
            _PNINLAD_X100 = value
        End Set
    End Property

    Public Property PNGFOB_X100() As Decimal
        Get
            Return _PNGFOB_X100
        End Get
        Set(ByVal value As Decimal)
            _PNGFOB_X100 = value
        End Set
    End Property

    Public Property PNFLETE_X100() As Decimal
        Get
            Return _PNFLETE_X100
        End Get
        Set(ByVal value As Decimal)
            _PNFLETE_X100 = value
        End Set
    End Property
   
    Public Property PNDUTIES_X100() As Decimal
        Get
            Return _PNDUTIES_X100
        End Get
        Set(ByVal value As Decimal)
            _PNDUTIES_X100 = value
        End Set
    End Property

    Public Property PNCOSTOS_ADICIONAL_X100() As Decimal
        Get
            Return _PNCOSTOS_ADICIONAL_X100
        End Get
        Set(ByVal value As Decimal)
            _PNCOSTOS_ADICIONAL_X100 = value
        End Set
    End Property

    Public Property PNCOSTOS_TOTAL_COSTOS() As Decimal
        Get
            Return _PNCOSTOS_TOTAL_COSTOS
        End Get
        Set(ByVal value As Decimal)
            _PNCOSTOS_TOTAL_COSTOS = value
        End Set
    End Property

End Class

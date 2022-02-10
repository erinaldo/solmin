Public Class beCostosRatioTotales

    Private _PNTOT_ITTEXW As Decimal = 0
    Private _PNTOT_ITTFOB As Decimal = 0
    Private _PNTOT_ITTCIF As Decimal = 0
    Private _PNTOT_ITTINLAD As Decimal = 0
    Private _PNTOT_ITTGFOB As Decimal = 0
    Private _PNTOT_ITTFLETE As Decimal = 0
    Private _PNTOT_ITTDUTIES As Decimal = 0
    Private _PNTOT_ITTCOSTOS_ADICIONAL As Decimal = 0

    Public Property PNTOT_ITTCOSTOS_ADICIONAL() As Decimal
        Get
            Return _PNTOT_ITTCOSTOS_ADICIONAL
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTCOSTOS_ADICIONAL = value
        End Set
    End Property

    Public Property PNTOT_ITTDUTIES() As Decimal
        Get
            Return _PNTOT_ITTDUTIES
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTDUTIES = value
        End Set
    End Property

    Public Property PNTOT_ITTFLETE() As Decimal
        Get
            Return _PNTOT_ITTFLETE
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTFLETE = value
        End Set
    End Property

    Public Property PNTOT_ITTGFOB() As Decimal
        Get
            Return _PNTOT_ITTGFOB
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTGFOB = value
        End Set
    End Property

    Public Property PNTOT_ITTINLAD() As Decimal
        Get
            Return _PNTOT_ITTINLAD
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTINLAD = value
        End Set
    End Property


    Public Property PNTOT_ITTEXW() As Decimal
        Get
            Return _PNTOT_ITTEXW
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTEXW = value
        End Set
    End Property
    Public Property PNTOT_ITTFOB() As Decimal
        Get
            Return _PNTOT_ITTFOB
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTFOB = value
        End Set
    End Property
    Public Property PNTOT_ITTCIF() As Decimal
        Get
            Return _PNTOT_ITTCIF
        End Get
        Set(ByVal value As Decimal)
            _PNTOT_ITTCIF = value
        End Set
    End Property

End Class

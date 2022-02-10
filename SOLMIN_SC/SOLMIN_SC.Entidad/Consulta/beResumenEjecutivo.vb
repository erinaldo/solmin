Public Class beResumenEjecutivo

    Public Enum REPORTE
        ANUAL = 0
        MENSUAL = 1
        FECHA = 2
    End Enum

    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property




    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PSCPLNDV As String
    Public Property PSCPLNDV() As String
        Get
            Return _PSCPLNDV
        End Get
        Set(ByVal value As String)
            _PSCPLNDV = value
        End Set
    End Property

    Private _PNCCLNT As Integer
    Public Property PNCCLNT() As Integer
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Integer)
            _PNCCLNT = value
        End Set
    End Property

    Private _PNFECINI As Decimal
    Public Property PNFECINI() As Decimal
        Get
            Return _PNFECINI
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property

    Private _PNFECFIN As Decimal
    Public Property PNFECFIN() As Decimal
        Get
            Return _PNFECFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
        End Set
    End Property

    Private _PNFECINI_SC As Decimal
    Public Property PNFECINI_SC() As Decimal
        Get
            Return _PNFECINI_SC
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI_SC = value
        End Set
    End Property

    Private _PNFECFIN_SC As Decimal
    Public Property PNFECFIN_SC() As Decimal
        Get
            Return _PNFECFIN_SC
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN_SC = value
        End Set
    End Property

    Private _RazonSocial As String
    Public Property RazonSocial() As String
        Get
            Return _RazonSocial
        End Get
        Set(ByVal value As String)
            _RazonSocial = value
        End Set
    End Property

    Private _TipoReporte As REPORTE
    Public Property TipoReporte() As REPORTE
        Get
            Return _TipoReporte
        End Get
        Set(ByVal value As REPORTE)
            _TipoReporte = value
        End Set
    End Property

End Class

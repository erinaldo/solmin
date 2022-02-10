Public Class beConsultaEriMensual
    'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-INICIO
    Private _IN_CCMPN As String
    Private _IN_MES As String
    Private _IN_CPLNDV As Decimal
    Private _IN_CCLNT As Decimal
    Private _IN_ANIO As Decimal

    Public Property IN_CCMPN() As String
        Get
            Return (_IN_CCMPN)
        End Get
        Set(ByVal value As String)
            _IN_CCMPN = value
        End Set
    End Property

    Public Property IN_CPLNDV() As Decimal
        Get
            Return (_IN_CPLNDV)
        End Get
        Set(ByVal value As Decimal)
            _IN_CPLNDV = value
        End Set
    End Property

    Public Property IN_CCLNT() As Decimal
        Get
            Return (_IN_CCLNT)
        End Get
        Set(ByVal value As Decimal)
            _IN_CCLNT = value
        End Set
    End Property

    Public Property IN_ANIO() As Decimal
        Get
            Return (_IN_ANIO)
        End Get
        Set(ByVal value As Decimal)
            _IN_ANIO = value
        End Set
    End Property

    Public Property IN_MES() As String
        Get
            Return (_IN_MES)
        End Get
        Set(ByVal value As String)
            _IN_MES = value
        End Set
    End Property
    'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-FIN
End Class

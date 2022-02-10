Public Class CtaCte_Venta
    Inherits CuentaCorriente

    Private _NCRDCC As String = ""
    Private _CRBCTC As String = ""
    Private _IVLDCS As Double = 0
    Private _IVLDCD As Double = 0
    Private _CTPALD As String = ""
    Private _CALMDC As String = ""
    Private _TCMTRF As String = ""


    Property TCMTRF() As String
        Get
            Return _TCMTRF
        End Get
        Set(ByVal value As String)
            _TCMTRF = value
        End Set
    End Property

    Property NCRDCC() As String
        Get
            Return _NCRDCC
        End Get
        Set(ByVal value As String)
            _NCRDCC = value
        End Set
    End Property

    Property CRBCTC() As String
        Get
            Return _CRBCTC
        End Get
        Set(ByVal value As String)
            _CRBCTC = value
        End Set
    End Property

    Property CTPALD() As String
        Get
            Return _CTPALD
        End Get
        Set(ByVal value As String)
            _CTPALD = value
        End Set
    End Property

    Property CALMDC() As String
        Get
            Return _CALMDC
        End Get
        Set(ByVal value As String)
            _CALMDC = value
        End Set
    End Property

    Property IVLDCS() As Double
        Get
            Return _IVLDCS
        End Get
        Set(ByVal value As Double)
            _IVLDCS = value
        End Set
    End Property
    Property IVLDCD() As Double
        Get
            Return _IVLDCD
        End Get
        Set(ByVal value As Double)
            _IVLDCD = value
        End Set
    End Property

End Class

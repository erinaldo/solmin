Public Class Detalle_Contrato
    Private _NRCTSL As Double = 0
    Private _NRITEM As Double = 0
    Private _NRTFSV As Double = 0
    Private _FECINI As Double = 0
    Private _FECFIN As Double = 0
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""

    Property NRCTSL() As Double
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Double)
            _NRCTSL = value
        End Set
    End Property

    Property NRITEM() As Double
        Get
            Return _NRITEM
        End Get
        Set(ByVal value As Double)
            _NRITEM = value
        End Set
    End Property

    Property NRTFSV() As Double
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Double)
            _NRTFSV = value
        End Set
    End Property

    Property FECINI() As Double
        Get
            Return _FECINI
        End Get
        Set(ByVal value As Double)
            _FECINI = value
        End Set
    End Property

    Property FECFIN() As Double
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As Double)
            _FECFIN = value
        End Set
    End Property

    Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property
End Class

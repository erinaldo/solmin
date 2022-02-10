Public Class ServicioSILDet
    Private _NOPRCN As Double
    Private _NRITEM As Double
    Private _NRPEMB As Double
    Private _CCLNT As Double
    Private _NORCML As String
    Private _NRPARC As Double
    Private _NRITOC As Double
    Private _QRLCSC As Double

    Property NOPRCN() As Double
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Double)
            _NOPRCN = value
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

    Property NRPEMB() As Double
        Get
            Return _NRPEMB
        End Get
        Set(ByVal value As Double)
            _NRPEMB = value
        End Set
    End Property

    Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property

    Property NORCML() As String
        Get
            Return _NORCML
        End Get
        Set(ByVal value As String)
            _NORCML = value
        End Set
    End Property

    Property NRPARC() As Double
        Get
            Return _NRPARC
        End Get
        Set(ByVal value As Double)
            _NRPARC = value
        End Set
    End Property

    Property NRITOC() As Double
        Get
            Return _NRITOC
        End Get
        Set(ByVal value As Double)
            _NRITOC = value
        End Set
    End Property

    Property QRLCSC() As Double
        Get
            Return _QRLCSC
        End Get
        Set(ByVal value As Double)
            _QRLCSC = value
        End Set
    End Property

End Class

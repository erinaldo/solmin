Public Class Bitacora_Contrato
    Private _NRCTSL As Double = 0
    Private _NRITOC As Double = 0
    Private _TOBS As String = ""
    Private _TFCOBS As Double = 0
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0

    Property NRCTSL() As Double
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Double)
            _NRCTSL = value
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

    Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal value As String)
            _TOBS = value
        End Set
    End Property

    Property TFCOBS() As Double
        Get
            Return _TFCOBS
        End Get
        Set(ByVal value As Double)
            _TFCOBS = value
        End Set
    End Property
End Class

Namespace mantenimientos
    Public Class TipoCapacitacionConductor
        Private _NCOCPT As Double = 0
        Private _NOMCPT As String = ""
        Private _TOBS As String = ""
        Private _SESTRG As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As Double = 0
        Private _HRACRT As Double = 0
        Private _NTRMCR As String = ""
        Private _CULUSA As String = ""
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _NTRMNL As String = ""

        Private _CCMPN As String
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property

        Public Property NCOCPT() As Double
            Get
                Return _NCOCPT
            End Get
            Set(ByVal value As Double)
                _NCOCPT = value
            End Set
        End Property

        Public Property NOMCPT() As String
            Get
                Return _NOMCPT
            End Get
            Set(ByVal value As String)
                _NOMCPT = value
            End Set
        End Property

        Public Property TOBS() As String
            Get
                Return _TOBS
            End Get
            Set(ByVal value As String)
                _TOBS = value
            End Set
        End Property

        Public Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal value As String)
                _SESTRG = value
            End Set
        End Property

        Public Property CUSCRT() As String
            Get
                Return _CUSCRT
            End Get
            Set(ByVal Value As String)
                _CUSCRT = Value
            End Set
        End Property

        Public Property FCHCRT() As Double
            Get
                Return _FCHCRT
            End Get
            Set(ByVal Value As Double)
                _FCHCRT = Value
            End Set
        End Property

        Public Property HRACRT() As Double
            Get
                Return _HRACRT
            End Get
            Set(ByVal Value As Double)
                _HRACRT = Value
            End Set
        End Property

        Public Property NTRMCR() As String
            Get
                Return _NTRMCR
            End Get
            Set(ByVal Value As String)
                _NTRMCR = Value
            End Set
        End Property

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal Value As String)
                _CULUSA = Value
            End Set
        End Property

        Public Property FULTAC() As Double
            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As Double)
                _FULTAC = Value
            End Set
        End Property

        Public Property HULTAC() As Double
            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As Double)
                _HULTAC = Value
            End Set
        End Property

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal Value As String)
                _NTRMNL = Value
            End Set
        End Property

    End Class
End Namespace

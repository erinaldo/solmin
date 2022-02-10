Namespace mantenimientos

    Public Class CapacitacionConductor
        Inherits Chofer

        Private _CBRCNT As String = ""
        Private _NCOCPT As Double = -1
        Private _FECREG As String = ""
        Private _SESTRG As String = ""
        Private _NOMCPT As String = ""
        Private _FECINI As String = ""
        Private _FECFIN As String = ""

        Public Property NOMCPT() As String
            Get
                Return _NOMCPT
            End Get
            Set(ByVal value As String)
                _NOMCPT = value
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

        Public Property FECREG() As String
            Get
                Return _FECREG
            End Get
            Set(ByVal value As String)
                _FECREG = value
            End Set
        End Property

        Public Property FECINI() As String
            Get
                Return _FECINI
            End Get
            Set(ByVal Value As String)
                _FECINI = Value
            End Set
        End Property

        Public Property FECFIN() As String
            Get
                Return _FECFIN
            End Get
            Set(ByVal Value As String)
                _FECFIN = Value
            End Set
        End Property

    End Class

End Namespace

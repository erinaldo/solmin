Namespace mantenimientos

    '****************************************************************************************************
    '** Autor: Rafael Gamboa
    '** Descripción: entidades.
    '****************************************************************************************************

    Public Class RecordMedico
        Inherits Vacunas

        Private _NCORMD As Double = 0
        Private _CBRCNT As String = ""
        Private _FECREG As String = ""
        Private _TNMCMC As String = ""
        Private _TAPPAC As String = ""
        Private _TAPMAC As String = ""
        Private _FECINI As String = ""
        Private _FECFIN As String = ""
        Private _TOBS As String = ""
       
        Public Property NCORMD() As Double
            Get
                Return _NCORMD
            End Get
            Set(ByVal Value As Double)
                _NCORMD = Value
            End Set
        End Property

        Public Property CBRCNT() As String
            Get
                Return _CBRCNT
            End Get
            Set(ByVal Value As String)
                _CBRCNT = Value
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

        Public Property TNMCMC() As String
            Get
                Return _TNMCMC
            End Get
            Set(ByVal Value As String)
                _TNMCMC = Value
            End Set
        End Property

        Public Property TAPPAC() As String
            Get
                Return _TAPPAC
            End Get
            Set(ByVal Value As String)
                _TAPPAC = Value
            End Set
        End Property

        Public Property TAPMAC() As String
            Get
                Return _TAPMAC
            End Get
            Set(ByVal Value As String)
                _TAPMAC = Value
            End Set
        End Property

    End Class

End Namespace
Namespace mantenimientos

    Public Class TransportistaTracto
        Inherits Tracto

        Private _NRUCTR As String = ""
        Private _FECINI As String = "0"
        Private _FECFIN As String = "0"
        Private _SESTCM As String = ""
        Private _CTPCRA As String = ""
        Private _CBRCNT As String = ""
        Private _NPLACP As String = ""
        Private _CCLNT As String = ""
        Private _NOMCHOFER As String = ""
        Private _POS_RUC_ANTERIOR As String = ""
        Private _FLAG_SKIPCHECKS As String = ""

        Private _TCMTRT As String = ""
        Public Property TCMTRT() As String
            Get
                Return _TCMTRT
            End Get
            Set(ByVal value As String)
                _TCMTRT = value
            End Set
        End Property

        Private _TNMCMC As String = ""
        Public Property TNMCMC() As String
            Get
                Return _TNMCMC
            End Get
            Set(ByVal value As String)
                _TNMCMC = value
            End Set
        End Property

        Public Property CCLNT() As String
            Get
                Return _CCLNT
            End Get
            Set(ByVal Value As String)
                _CCLNT = Value
            End Set
        End Property

        Public Property NRUCTR() As String
            Get
                Return _NRUCTR
            End Get
            Set(ByVal Value As String)
                _NRUCTR = Value
            End Set
        End Property

        Public Property FECINI() As String
            Get
                Return _FECINI
            End Get
            Set(ByVal value As String)
                _FECINI = value
            End Set
        End Property

        Public Property FECFIN() As String
            Get
                Return _FECFIN
            End Get
            Set(ByVal value As String)
                _FECFIN = value
            End Set
        End Property

        Public Property SESTCM() As String
            Get
                Return _SESTCM
            End Get
            Set(ByVal value As String)
                _SESTCM = value
            End Set
        End Property

        Public Property CTPCRA() As String
            Get
                Return _CTPCRA
            End Get
            Set(ByVal value As String)
                _CTPCRA = value
            End Set
        End Property

        Public Property NPLACP() As String
            Get
                Return _NPLACP
            End Get
            Set(ByVal value As String)
                _NPLACP = value
            End Set
        End Property

        Public Property NOMCHOFER() As String
            Get
                Return _NOMCHOFER
            End Get
            Set(ByVal Value As String)
                _NOMCHOFER = Value
            End Set
        End Property

        Public Property POS_RUC_ANTERIOR() As String
            Get
                Return _POS_RUC_ANTERIOR
            End Get
            Set(ByVal value As String)
                _POS_RUC_ANTERIOR = value
            End Set
        End Property

        Public Property FLAG_SKIPCHECKS() As String
            Get
                Return _FLAG_SKIPCHECKS
            End Get
            Set(ByVal value As String)
                _FLAG_SKIPCHECKS = value
            End Set
        End Property

    End Class
End Namespace


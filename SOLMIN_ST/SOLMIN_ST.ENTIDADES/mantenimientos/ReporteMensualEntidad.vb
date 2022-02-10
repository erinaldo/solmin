Namespace mantenimientos

    Public Class ReporteMensualEntidad

        Private _USUARIO As String
        Private _PASSWORD As String
        Private _CCMPN As String
        Private _CDVSN As String
        Private _CPLNDV As Integer
        Private _CCLNT As String
        Private _FGUITR_INI As Integer
        Private _FGUITR_FIN As Integer
        Private _CTRSPT As String
        Private _NPLVHT As String


        Public Property USUARIO() As String
            Get
                Return _USUARIO
            End Get
            Set(ByVal Value As String)
                _USUARIO = Value
            End Set
        End Property

        Public Property PASSWORD() As String
            Get
                Return _PASSWORD
            End Get
            Set(ByVal Value As String)
                _PASSWORD = Value
            End Set
        End Property

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal Value As String)
                _CCMPN = Value
            End Set
        End Property

        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal Value As String)
                _CDVSN = Value
            End Set
        End Property

        Public Property CPLNDV() As Integer
            Get
                Return _CPLNDV
            End Get
            Set(ByVal Value As Integer)
                _CPLNDV = Value
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

        Public Property FGUITR_INI() As Integer
            Get
                Return _FGUITR_INI
            End Get
            Set(ByVal Value As Integer)
                _FGUITR_INI = Value
            End Set
        End Property

        Public Property FGUITR_FIN() As Integer
            Get
                Return _FGUITR_FIN
            End Get
            Set(ByVal Value As Integer)
                _FGUITR_FIN = Value
            End Set
        End Property

        Public Property CTRSPT() As String
            Get
                Return _CTRSPT
            End Get
            Set(ByVal Value As String)
                _CTRSPT = Value
            End Set
        End Property

        Public Property NPLVHT() As String
            Get
                Return _NPLVHT
            End Get
            Set(ByVal Value As String)
                _NPLVHT = Value
            End Set
        End Property

    End Class

End Namespace

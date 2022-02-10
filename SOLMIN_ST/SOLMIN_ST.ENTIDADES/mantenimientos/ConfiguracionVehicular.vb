Namespace mantenimientos
    Public Class ConfiguracionVehicular

#Region "Atributo"

        Private _SESTRG As String = ""
        Private _CCLNAS As String = ""
        Private _TCNFGV As String = ""
        Private _TCNFG1 As String = ""
        Private _TCNFG2 As String = ""
        Private _FULTAC As String = ""
        Private _HULTAC As Double = 0
        Private _CULUSA As Double = 0
        Private _NTRMNL As String = ""
        Private _IMAGEN As Byte()

        Private _CCMPN As String = ""


#End Region

#Region "Properties"
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property
        Public Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal Value As String)
                _SESTRG = Value
            End Set
        End Property

        Public Property CCLNAS() As String
            Get
                Return _CCLNAS
            End Get
            Set(ByVal Value As String)
                _CCLNAS = Value
            End Set
        End Property

        Public Property TCNFGV() As String
            Get
                Return _TCNFGV
            End Get
            Set(ByVal Value As String)
                _TCNFGV = Value
            End Set
        End Property

        Public Property TCNFG1() As String
            Get
                Return _TCNFG1
            End Get
            Set(ByVal Value As String)
                _TCNFG1 = Value
            End Set
        End Property

        Public Property TCNFG2() As String
            Get
                Return _TCNFG2
            End Get
            Set(ByVal Value As String)
                _TCNFG2 = Value
            End Set
        End Property

        Public Property FULTAC() As String
            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As String)
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

        Public Property CULUSA() As Double
            Get
                Return _CULUSA
            End Get
            Set(ByVal Value As Double)
                _CULUSA = Value
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

        Public Property IMAGEN() As Byte()
            Get
                Return _IMAGEN
            End Get
            Set(ByVal value As Byte())
                _IMAGEN = value
            End Set
        End Property


#End Region

    End Class

End Namespace

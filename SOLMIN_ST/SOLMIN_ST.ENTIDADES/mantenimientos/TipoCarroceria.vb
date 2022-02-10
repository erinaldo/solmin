Namespace mantenimientos

    Public Class TipoCarroceria

        Private _CTPCRA As String = ""
        Private _TCMCRA As String = ""
        Private _TARCRA As String = ""
        Private _FULTAC As String = ""
        Private _HULTAC As String = ""
        Private _CULUSA As String = ""
        Private _NTRMNL As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As String = ""
        Private _HRACRT As String = ""
        Private _NTRMCR As String = ""
        Private _CCMPN As String = ""
        Private _CDVSN As String
        Private _CPLNDV As Double
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property
        Public Property CTPCRA() As String
            Get
                Return _CTPCRA
            End Get
            Set(ByVal Value As String)
                _CTPCRA = Value
            End Set
        End Property

        Public Property TCMCRA() As String
            Get
                Return _TCMCRA
            End Get
            Set(ByVal Value As String)
                _TCMCRA = Value
            End Set
        End Property

        Public Property TARCRA() As String
            Get
                Return _TARCRA
            End Get
            Set(ByVal Value As String)
                _TARCRA = Value
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

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal Value As String)
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

        Public Property CDVSN() As String
            Get
                Return _CDVSN
            End Get
            Set(ByVal value As String)
                _CDVSN = value
            End Set
        End Property

        Public Property CPLNDV() As Double
            Get
                Return _CPLNDV
            End Get
            Set(ByVal value As Double)
                _CPLNDV = value
            End Set
        End Property

    End Class
End Namespace
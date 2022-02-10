Namespace mantenimientos

    Public Class LocalidadRuta
        Private _CCMPN As String
        Private _CLCLD As String = ""
        Private _TCMLCL As String = ""
        Private _TABLCL As String = ""
        Private _FULTAC As String = ""
        Private _HULTAC As String = ""
        Private _CULUSA As String = ""
        Private _NTRMNL As String = ""
        Private _SESTRG As String = ""

        Private _CUBGEL As Double = 0
        Private _UBIGEO As String = ""
        Private _CUBGEO As String = ""
        Private _DESCRIPCION As String = ""

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal Value As String)
                _CCMPN = Value
            End Set
        End Property

        Public Property CUBGEO() As String
            Get
                Return _CUBGEO
            End Get
            Set(ByVal value As String)
                _CUBGEO = value
            End Set
        End Property


        Public Property UBIGEO() As String
            Get
                Return _UBIGEO
            End Get
            Set(ByVal value As String)
                _UBIGEO = value
            End Set
        End Property


        Public Property CUBGEL() As Double
            Get
                Return _CUBGEL
            End Get
            Set(ByVal value As Double)
                _CUBGEL = value
            End Set
        End Property

        Private _flagDataManipulation As String = ""

        Public Property CLCLD() As String
            Get
                Return _CLCLD
            End Get
            Set(ByVal Value As String)
                _CLCLD = Value
            End Set
        End Property

        Public Property TCMLCL() As String
            Get
                Return _TCMLCL
            End Get
            Set(ByVal Value As String)
                _TCMLCL = Value
            End Set
        End Property

        Public Property TABLCL() As String
            Get
                Return _TABLCL
            End Get
            Set(ByVal Value As String)
                _TABLCL = Value
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

        Public Property HULTAC() As String
            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As String)
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

        Public Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal Value As String)
                _SESTRG = Value
            End Set
        End Property

        Public Property FlagDataManipulation() As String
            Get
                Return _flagDataManipulation
            End Get
            Set(ByVal Value As String)
                _flagDataManipulation = Value
            End Set
        End Property

        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal Value As String)
                _DESCRIPCION = Value
            End Set
        End Property

    End Class

End Namespace
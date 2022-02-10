Namespace mantenimientos

    Public Class TipodeTracto

        Dim _CTITRA As String
        Dim _TDETRA As String
        Dim _TABDES As String
        Dim _TCNFVH As String
        Dim _IMGTRA As String
        Dim _SESTRG As String
        Dim _CUSCRT As String
        Dim _FCHCRT As String
        Dim _HRACRT As String
        Dim _NTRMCR As String
        Dim _CULUSA As String
        Dim _FULTAC As String
        Dim _HULTAC As String
        Dim _NTRMNL As String
        Dim _IMAGEN As Byte()
        Dim _UPDATE_IDENT As String

        Private _CCMPN As String
        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property


        Public Property CTITRA() As String
            Get
                Return _CTITRA
            End Get
            Set(ByVal Value As String)
                _CTITRA = Value
            End Set
        End Property

        Public Property TDETRA() As String
            Get
                Return _TDETRA
            End Get
            Set(ByVal Value As String)
                _TDETRA = Value
            End Set
        End Property

        Public Property TABDES() As String
            Get
                Return _TABDES
            End Get
            Set(ByVal Value As String)
                _TABDES = Value
            End Set
        End Property

        Public Property TCNFVH() As String
            Get
                Return _TCNFVH
            End Get
            Set(ByVal Value As String)
                _TCNFVH = Value
            End Set
        End Property

        Public Property IMGTRA() As String
            Get
                Return _IMGTRA
            End Get
            Set(ByVal Value As String)
                _IMGTRA = Value
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

        Public Property CUSCRT() As String
            Get
                Return _CUSCRT
            End Get
            Set(ByVal Value As String)
                _CUSCRT = Value
            End Set
        End Property

        Public Property FCHCRT() As String
            Get
                Return _FCHCRT
            End Get
            Set(ByVal Value As String)
                _FCHCRT = Value
            End Set
        End Property

        Public Property HRACRT() As String
            Get
                Return _HRACRT
            End Get
            Set(ByVal Value As String)
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

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal Value As String)
                _NTRMNL = Value
            End Set
        End Property

        Public Property UPDATE_IDENT() As String
            Get
                Return _UPDATE_IDENT
            End Get
            Set(ByVal Value As String)
                _UPDATE_IDENT = Value
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

    End Class
End Namespace


Namespace mantenimientos

    Public Class ReporteListadoTarifas

        Private _USUARIO As String = ""
        Private _PASSWORD As String = ""
        Private _CCMPN As String = ""
        Private _CDVSN As String = ""
        'Private _CPLNDV As Integer = 0

        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        01/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        Private _CPLNDV As String = ""

        Private _FECHA_INICIO As Integer = 0
        Private _FECHA_FIN As Integer = 0
        Private _CCLNT As String = ""
        Private _SESTOS As String = ""
        Private _CTPUNV As String = ""

        Public Property CTPUNV() As String
            Get
                Return _CTPUNV
            End Get
            Set(ByVal Value As String)
                _CTPUNV = Value
            End Set
        End Property

        Public Property SESTOS() As String
            Get
                Return _SESTOS
            End Get
            Set(ByVal Value As String)
                _SESTOS = Value
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

        'Public Property CPLNDV() As Integer
        '    Get
        '        Return _CPLNDV
        '    End Get
        '    Set(ByVal Value As Integer)
        '        _CPLNDV = Value
        '    End Set
        'End Property

        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        01/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        Public Property CPLNDV() As String
            Get
                Return _CPLNDV
            End Get
            Set(ByVal Value As String)
                _CPLNDV = Value
            End Set
        End Property

        Public Property FECHA_INICIO() As Integer
            Get
                Return _FECHA_INICIO
            End Get
            Set(ByVal Value As Integer)
                _FECHA_INICIO = Value
            End Set
        End Property

        Public Property FECHA_FIN() As Integer
            Get
                Return _FECHA_FIN
            End Get
            Set(ByVal Value As Integer)
                _FECHA_FIN = Value
            End Set
        End Property

    End Class

End Namespace
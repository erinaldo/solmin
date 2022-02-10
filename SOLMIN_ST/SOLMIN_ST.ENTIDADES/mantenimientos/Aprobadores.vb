'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
Namespace mantenimientos
    Public Class Aprobadores

        Private _USRCCO As String = ""
        Private _NOMBRE As String = ""
        Public Property USRCCO() As String
            Get
                Return _USRCCO
            End Get
            Set(ByVal value As String)
                _USRCCO = value
            End Set
        End Property

        Public Property NOMBRE() As String
            Get
                Return _NOMBRE
            End Get
            Set(ByVal value As String)
                _NOMBRE = value
            End Set
        End Property

    End Class
End Namespace
'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
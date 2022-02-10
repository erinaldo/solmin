
Namespace mantenimientos
    Public Class beAutorizacion

        Private _COD_ACCION As String = ""
        Private _ACCION As String = ""

        Public Property COD_ACCION() As String
            Get
                Return _COD_ACCION
            End Get
            Set(ByVal value As String)
                _COD_ACCION = value
            End Set
        End Property

        Public Property ACCION() As String
            Get
                Return _ACCION
            End Get
            Set(ByVal value As String)
                _ACCION = value
            End Set
        End Property

    End Class
    Public Class beAutorizacionLiquidacion
        Public Visualizar As String = ""
        Public Adicionar As String = ""
        Public Modificar As String = ""
        Public Eliminar As String = ""
        Public ModifTarifaOS As String = ""
        Public RevertirOperacionEstimada As String = ""
        Public RevertirOperacionValorizada As String = ""
        'Public Property Visualizar() As String
        '    Get
        '        Return _Visualizar
        '    End Get
        '    Set(ByVal value As String)
        '        _Visualizar = value
        '    End Set
        'End Property
        'Public Property Adicionar() As String
        '    Get
        '        Return _Adicionar
        '    End Get
        '    Set(ByVal value As String)
        '        _Adicionar = value
        '    End Set
        'End Property
        'Public Property Modificar() As String
        '    Get
        '        Return _Modificar
        '    End Get
        '    Set(ByVal value As String)
        '        _Modificar = value
        '    End Set
        'End Property
        'Public Property Eliminar() As String
        '    Get
        '        Return _Eliminar
        '    End Get
        '    Set(ByVal value As String)
        '        _Eliminar = value
        '    End Set
        'End Property
        'Public Property ModifTarifaOS() As String
        '    Get
        '        Return _ModifTarifaOS
        '    End Get
        '    Set(ByVal value As String)
        '        _ModifTarifaOS = value
        '    End Set
        'End Property


        'Public Property RevertirOperacionEstimada() As String
        '    Get
        '        Return _RevertirOperacionEstimada
        '    End Get
        '    Set(ByVal value As String)
        '        _RevertirOperacionEstimada = value
        '    End Set
        'End Property

        'Public Property RevertirOperacionEstimada() As String
        '    Get
        '        Return _RevertirOperacionEstimada
        '    End Get
        '    Set(ByVal value As String)
        '        _RevertirOperacionEstimada = value
        '    End Set
        'End Property

        'RevertirOperacionValorizada

    End Class
End Namespace



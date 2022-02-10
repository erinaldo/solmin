Namespace mantenimientos
    Public Class ServicioLiquidacion

        Private _CSRVNV As String
        Public Property CSRVNV() As String
            Get
                Return _CSRVNV
            End Get
            Set(ByVal value As String)
                _CSRVNV = value
            End Set
        End Property


        Private _TCMTRF As String
        Public Property TCMTRF() As String
            Get
                Return _TCMTRF
            End Get
            Set(ByVal value As String)
                _TCMTRF = value
            End Set
        End Property


        Private _TSRVIN As String
        Public Property TSRVIN() As String
            Get
                Return _TSRVIN
            End Get
            Set(ByVal value As String)
                _TSRVIN = value
            End Set
        End Property

    End Class
End Namespace


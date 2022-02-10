Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class blPedidoDeposito
    Dim oDatos As New daPedidoDeposito

    Public Function ListarConsultaPedidoDeposito(ByVal obePedidoDeposito As bePedidoDeposito) As List(Of bePedidoDeposito)
        Return oDatos.ListarConsultaPedidoDeposito(obePedidoDeposito)
    End Function
End Class

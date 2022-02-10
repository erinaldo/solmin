Imports RANSA.DATA
Imports System.Data
Imports RANSA.TYPEDEF
 
Public Class brObservacionesPedido
 
    Private objDAo As New daObservacionesPedido

    Public Function Registro_Observaciones(ByVal objLista As List(Of String)) As Boolean
        Return objDAo.Registro_Observaciones(objLista)
    End Function

    Public Function Modificar_Observaciones(ByVal objLista As List(Of String)) As Boolean
        Return objDAo.Modificar_Observaciones(objLista)
    End Function

    Public Function Listado_Observaciones(ByVal obeFiltro As beObservacionPedido) As List(Of beObservacionPedido)
        Return objDAo.Listado_Observaciones(obeFiltro)
    End Function

    Public Function Listado_Observaciones_General(ByVal obeFiltro As beObservacionPedido) As List(Of beObservacionPedido)
        Return objDAo.Listado_Observaciones_General(obeFiltro)
    End Function

    Public Function fintEliminar_Observaciones_Pedido(ByVal obeFiltro As beObservacionPedido) As Integer
        Return objDAo.fintEliminar_Observaciones_Pedido(obeFiltro)
    End Function

    Public Function fintRegistrarObeservaciones(ByVal olbeFiltro As List(Of beObservacionPedido)) As Integer
        For Each obeObPedido As beObservacionPedido In olbeFiltro
            If objDAo.fintRegistrarObeservaciones(obeObPedido) <> 1 Then
                objDAo.fintEliminar_Observaciones_Pedido(obeObPedido)
                Return -1
            End If
        Next
        Return 1
    End Function
End Class

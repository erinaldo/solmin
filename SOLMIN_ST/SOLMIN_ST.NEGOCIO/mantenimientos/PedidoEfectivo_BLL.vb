Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class PedidoEfectivo_BLL
  Private objPedidoEfectivoDAL As New PedidoEfectivo_DAL

  Public Function Guardar_Pedido_Efectivo(ByVal objPedidoEfectivo As PedidoEfectivo) As PedidoEfectivo
    Return objPedidoEfectivoDAL.Guardar_Pedido_Efectivo(objPedidoEfectivo)
  End Function

  Public Function Generar_Codigo(ByVal pstrCompañia As String, ByVal pdblZona As Double) As Double
    Return objPedidoEfectivoDAL.Generar_Codigo(pstrCompañia, pdblZona)
  End Function

  Public Function Lista_Pedido_Efectivo(ByVal pdblNrPedido As Double)
    Return objPedidoEfectivoDAL.Lista_Pedido_Efectivo(pdblNrPedido)
  End Function

  Public Sub Actualizar_Supervisor(ByVal objPedidoEfectivo As PedidoEfectivo)
        'Try
        objPedidoEfectivoDAL.Actualizar_Supervisor(objPedidoEfectivo)
        'Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    End Try
  End Sub

  Public Function Auditoria(ByVal objPedidoEfectivo As PedidoEfectivo) As PedidoEfectivo
    Return objPedidoEfectivoDAL.Auditoria(objPedidoEfectivo)
  End Function

  Public Function Anular_Pedido_Efectivo(ByVal objEntidad As PedidoEfectivo) As Integer
    Return objPedidoEfectivoDAL.Anular_Pedido_Efectivo(objEntidad)
  End Function

  'Public Function Anular_Pedido_Efectivo_SAP(ByVal objEntidad As PedidoEfectivo) As Integer
  '  Return objPedidoEfectivoDAL.Anular_Pedido_Efectivo_SAP(objEntidad)
  'End Function

End Class

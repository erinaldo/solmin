Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones
    Public Class SolicitudPedidoEfectivo_BLL


        Dim objDataAccessLayer As New SolicitudPedidoEfectivo_DAL

        Public Function ListaSolicitud_Pedido_Efectivo(ByVal objPedidoEfectivo As PedidoEfectivo) As List(Of PedidoEfectivo)
            Try
                Return objDataAccessLayer.ListaSolicitud_Pedido_Efectivo(objPedidoEfectivo)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function Lista_Obrero() As List(Of ClaseGeneral)
            Try
                Return objDataAccessLayer.Lista_Obrero()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function Validar_Numero_Operacion(ByVal Operacion As Double) As Boolean
            Return objDataAccessLayer.Validar_Numero_Operacion(Operacion)
        End Function

        Public Function Lista_Obrero_x_Codigo(ByVal objetoParametro As Hashtable) As ClaseGeneral
            Try
                Return objDataAccessLayer.Lista_Obrero_x_Codigo(objetoParametro)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function
        Public Function Validar_Usuario_Autorizado(ByVal objetoParametro As Hashtable) As ClaseGeneral
            Return objDataAccessLayer.Validar_Usuario_Autorizado(objetoParametro)
        End Function

        Public Function Obtener_Placa_X_Operacion(ByVal objetoParametro As Hashtable) As List(Of SolicitudEfectivoSAP)
            Return objDataAccessLayer.Obtener_Placa_X_Operacion(objetoParametro)
        End Function
        Public Function Reporte_Lista_Pedido_Efectivo(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
            Return objDataAccessLayer.Reporte_Lista_Pedido_Efectivo(objetoParametro)
        End Function

    End Class
End Namespace

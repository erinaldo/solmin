
Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad

Public Class clsSegNotificacion

    Dim objDatos As New Datos.clsSegNotificacion


    Public Function ListarClienteProcesoNotificacion(ByVal obeSegNotificacion As beSegNotificacion) As DataTable
        Return objDatos.ListarClienteProcesoNotificacion(obeSegNotificacion)
    End Function

    Public Function RegistrarClienteProcesoNotificacion(ByVal obeSegNotificacion As beSegNotificacion) As String
        Return objDatos.RegistrarClienteProcesoNotificacion(obeSegNotificacion)
    End Function

    Public Sub EliminarClienteProcesoNotificacion(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.EliminarClienteProcesoNotificacion(obeSegNotificacion)
    End Sub

    Public Sub ActualizarFormatoProcesoNotificacionXCliente(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.ActualizarFormatoProcesoNotificacionXCliente(obeSegNotificacion)
    End Sub

    Public Function ListarCheckPointsNotificacion(ByVal obeSegNotificacion As beSegNotificacion) As DataTable
        Return objDatos.ListarCheckPointsNotificacion(obeSegNotificacion)
    End Function

    Public Function RegistarCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion) As String
        Return objDatos.RegistarCheckPointsNotificacionEmail(obeSegNotificacion)
    End Function

    Public Sub ModificarCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.ModificarCheckPointsNotificacionEmail(obeSegNotificacion)
    End Sub

    Public Sub EliminarCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.EliminarCheckPointsNotificacionEmail(obeSegNotificacion)
    End Sub


    Public Sub ActualizarOrdenCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.ActualizarOrdenCheckPointsNotificacionEmail(obeSegNotificacion)
    End Sub

    Public Function ListarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion) As DataTable
        Return objDatos.ListarEmailDestinatarioXTipo(obeSegNotificacion)
    End Function


    Public Sub RregistrarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.RregistrarEmailDestinatarioXTipo(obeSegNotificacion)
    End Sub

    Public Sub ActualizarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.ActualizarEmailDestinatarioXTipo(obeSegNotificacion)
    End Sub

    Public Sub EliminarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion)
        objDatos.EliminarEmailDestinatarioXTipo(obeSegNotificacion)
    End Sub

End Class

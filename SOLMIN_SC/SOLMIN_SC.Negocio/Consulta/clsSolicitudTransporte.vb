Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsSolicitudTransporte
    Public Function Obtener_Datos_Solicitud_Transporte(ByVal PNNCSOTR As Decimal) As beSolicitudTransporte
        Dim oblSolicitudTransp As New Datos.clsSolicitudTransporte
        Return oblSolicitudTransp.Obtener_Datos_Solicitud_Transporte(PNNCSOTR)
    End Function
    Public Function Obtener_Detalle_Solicitud_Asignada(ByVal PNNCSOTR As Decimal) As List(Of beDetalleSolTransporte)
        Dim oblSolicitudTransp As New Datos.clsSolicitudTransporte
        Return oblSolicitudTransp.Obtener_Detalle_Solicitud_Asignada(PNNCSOTR)
    End Function
    Public Function Obtener_Numero_Solicitud_Transporte(ByVal PNNORSCI As Decimal) As DataTable
        Dim oblSolicitudTransp As New Datos.clsSolicitudTransporte
        Return oblSolicitudTransp.Obtener_Numero_Solicitud_Transporte(PNNORSCI)
    End Function
    Public Function Obtener_Lista_Solicitud_Transporte(ByVal PNNORSCI As Decimal) As List(Of beSolicitudTransporte)
        Dim oblSolicitudTransp As New Datos.clsSolicitudTransporte
        Return oblSolicitudTransp.Obtener_Lista_Solicitud_Transporte(PNNORSCI)
    End Function
End Class

Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class SolicitudEfectivoSAP_BLL
    Private objDatos As New SolicitudEfectivoSAP_DAL

    Public Function Guardar_Solicitud_Efectivo_SAP(ByVal ojbEntidad As SolicitudEfectivoSAP) As SolicitudEfectivoSAP
        Return objDatos.Guardar_Solicitud_Efectivo_SAP(ojbEntidad)
    End Function


End Class

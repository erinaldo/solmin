Imports System.Data

Public Class TipoServicioTransporte_BLL

    Private objDatos As New TipoServicioTransporte_DAL

    Public Function Listar_Tipo_Servicio_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Tipo_Servicio_Combo(strCompania)
    End Function
    Public Function Obtener_TipoServicio(ByVal objEntidad As TipoServicioTransporte) As TipoServicioTransporte
        Return objDatos.Obtener_TipoServicio(objEntidad)
    End Function

End Class

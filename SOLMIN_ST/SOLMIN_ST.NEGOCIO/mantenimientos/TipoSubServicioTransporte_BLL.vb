Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS
Imports System.Data

Public Class TipoSubServicioTransporte_BLL
    Private objDatos As New TipoSubServicioTransporte_DAL

    Public Function Listar_Tipo_SubServicio(ByVal objEntidad As TipoServicioTransporte) As DataTable
        Return objDatos.Listar_Tipo_SubServicio(objEntidad)
    End Function

    Public Function Obtener_TipoSubServicio(ByVal objEntidad As TipoSubServicioTransporte) As TipoSubServicioTransporte
        Return objDatos.Obtener_TipoSubServicio(objEntidad)
    End Function
End Class

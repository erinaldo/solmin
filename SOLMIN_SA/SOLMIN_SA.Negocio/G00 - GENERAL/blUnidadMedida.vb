Imports RANSA.DATA
Public Class blUnidadMedida
    Public Function Obtener_Unidad_Medida_x_Mercaderia_Relacionada(ByVal IN_CMRCLR_CodigoMercaderiaRelacionada As String) As DataTable
        Return New daUnidad().Obtener_Unidad_Medida_x_Mercaderia_Relacionada(IN_CMRCLR_CodigoMercaderiaRelacionada)
    End Function
    Public Function Obtener_Obtener_UnidadMedida_x_Descripcion(ByVal TCMPUN_DescripcionUnidad As String) As DataTable
        Return New daUnidad().Obtener_Obtener_UnidadMedida_x_Descripcion(TCMPUN_DescripcionUnidad)
    End Function
End Class

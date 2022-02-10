

Public Class PlantaFacturacion_BLL

    Private objDatos As New PlantaFacturacion_DAL()

    Public Function Listar_Planta_Facturacion_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Planta_Facturacion_Combo(strCompania)
    End Function
    Public Function Listar_Planta_Zona_Facturacion(ByVal strCompania As String, ByVal strDivision As String) As DataTable
        Return objDatos.Listar_Planta_Zona_Facturacion(strCompania, strDivision)
    End Function

End Class

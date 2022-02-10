Imports SOLMIN_ST.DATOS

Public Class PlantaFacturacion_BLL

    Private objDatos As New PlantaFacturacion_DAL()

    Public Function Listar_Planta_Facturacion_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Planta_Facturacion_Combo(strCompania)
    End Function
    Public Function Listar_Planta_Zona_Facturacion(ByVal strCompania As String, ByVal strDivision As String) As DataTable
        Return objDatos.Listar_Planta_Zona_Facturacion(strCompania, strDivision)
    End Function

    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Public Function ListarAprobador(ByVal strCompania As String) As List(Of ENTIDADES.mantenimientos.Aprobadores)
        Return objDatos.ListarAprobador(strCompania)
    End Function
    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
End Class

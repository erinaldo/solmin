Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Imports System.Data

Public Class MigracionAgencias_BLL

    Dim objDAO As New MigracionAgencias_DAL

    Public Function Listar_Ordenes_Proceso_Migracion(ByVal anio As Integer) As DataTable
        Return objDAO.Listar_Ordenes_Proceso_Migracion(anio)
    End Function

    Public Function Obtener_Orden_Servicio(ByVal objParametros As List(Of String)) As DataTable
        Return objDAO.Obtener_Orden_Servicio(objParametros)
    End Function

    Public Function Obtener_Zona_Migracion(ByVal objParametros As List(Of String)) As String
        Return objDAO.Obtener_Zona_Migracion(objParametros).Rows(0).Item("DCAUX1").ToString()
    End Function

    Public Function Actualizar_Informacion_Agencias(ByVal objParametros As List(Of String)) As DataTable
        Return objDAO.Actualizar_Informacion_Agencias(objParametros)
    End Function

    Public Function Listar_CostoIntegracion(ByVal nCliente As Int32, ByVal sOrdenCompra As String) As DataTable
        Return objDAO.Listar_CostoIntegracion(nCliente, sOrdenCompra)
    End Function
End Class

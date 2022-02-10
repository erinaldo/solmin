Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones
  Public Class Repartos_BLL
    Dim objDataAccessLayer As New Repartos_DAL

    Public Function Listar_Operaciones_Reparto(ByVal objEntidad As List(Of String)) As List(Of Repartos)
      Return objDataAccessLayer.Listar_Operaciones_Reparto(objEntidad)
    End Function

    Public Function Registrar_Operacion_Reparto(ByVal objEntidad As Repartos) As Repartos
      Return objDataAccessLayer.Registrar_Operacion_Reparto(objEntidad)
    End Function

    Public Function Modificar_Operacion_Reparto(ByVal objEntidad As Repartos) As Repartos
      Return objDataAccessLayer.Modificar_Operacion_Reparto(objEntidad)
    End Function

    Public Function Eliminar_Operacion_Reparto(ByVal objEntidad As Repartos) As Repartos
      Return objDataAccessLayer.Eliminar_Operacion_Reparto(objEntidad)
    End Function

    Public Function Listar_Reporte_Operacion_Reparto(ByVal objEntidad As List(Of String)) As DataSet
      Return objDataAccessLayer.Listar_Reporte_Operacion_Reparto(objEntidad)
    End Function

    Public Function Modificar_Estado_Operacion_Reparto(ByVal objEntidad As Repartos) As Repartos
      Return objDataAccessLayer.Modificar_Estado_Operacion_Reparto(objEntidad)
    End Function

    'Public Function Listar_Consistencia_Operacion_Reparto(ByVal objEntidad As Hashtable) As DataTable
    '  Return objDataAccessLayer.Listar_Consistencia_Operacion_Reparto(objEntidad)
    'End Function

    'Public Function Imprimir_Consistencia_Operacion_Reparto(ByVal objEntidad As Hashtable) As DataSet
    '  Return objDataAccessLayer.Imprimir_Consistencia_Operacion_Reparto(objEntidad)
    'End Function

    Public Function Eliminar_Operacion_Reparto_Guia_Remision_Servicio(ByVal objEntidad As Repartos) As Repartos
      Return objDataAccessLayer.Eliminar_Operacion_Reparto_Guia_Remision_Servicio(objEntidad)
    End Function

    Public Function Exportar_Factura_Reparto(ByVal objEntidad As Hashtable) As DataTable
      Return objDataAccessLayer.Exportar_Factura_Reparto(objEntidad)
    End Function

  End Class
End Namespace

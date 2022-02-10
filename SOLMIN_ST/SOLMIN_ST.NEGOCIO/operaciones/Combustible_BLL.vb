Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones
  Public Class Combustible_BLL
        Private objDataAccessLayer As New Combustible_DAL

    Public Function Registrar_Asignacion_Combustible_Tracto(ByVal objEntidad As Combustible) As Combustible
      Return objDataAccessLayer.Registrar_Asignacion_Combustible_Tracto(objEntidad)
    End Function

    Public Function Modificar_Asignacion_Combustible_Tracto(ByVal objEntidad As Combustible) As Combustible
      Return objDataAccessLayer.Modificar_Asignacion_Combustible_Tracto(objEntidad)
    End Function

    Public Function Eliminar_Asignacion_Combustible_Tracto(ByVal objEntidad As Combustible) As Combustible
      Return objDataAccessLayer.Eliminar_Asignacion_Combustible_Tracto(objEntidad)
    End Function

    Public Function Actualizar_Asignacion_Combustible_Tracto(ByVal list_ObjEntidad As List(Of Combustible)) As Int32
      For Each obj_Entidad As Combustible In list_ObjEntidad
        objDataAccessLayer.Actualizar_Asignacion_Combustible_Tracto(obj_Entidad)
      Next
    End Function

    Public Function Listar_Asignacion_Combustible_x_Tractos(ByVal objParametro As Hashtable) As List(Of Combustible)
      Return objDataAccessLayer.Listar_Asignacion_Combustible_x_Tractos(objParametro)
    End Function

    Public Function Listar_Tractos_Asignacion_Combustible(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
      Return objDataAccessLayer.Listar_Tractos_Asignacion_Combustible(objParametro)
    End Function

    Public Function Listar_Tractos_Asignacion_Combustible_RPT(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
      Return objDataAccessLayer.Listar_Tractos_Asignacion_Combustible_RPT(objParametro)
        End Function

        Public Function Actualizar_Asignacion_Combustible_Tracto_AL(ByVal objEntidad As Combustible) As Int32
            objDataAccessLayer.Actualizar_Asignacion_Combustible_Tracto(objEntidad)
        End Function

        Public Function Listar_Vales_Asignados_x_Operacion(ByVal objParametro As Hashtable) As List(Of Combustible)
            Return objDataAccessLayer.Listar_Vales_Asignados_x_Operacion(objParametro)
        End Function

        Public Function Listar_Datos_Adicionales_Asignacion_Combustible(ByVal objEntidad As Combustible) As List(Of Combustible)
            Return objDataAccessLayer.Listar_Datos_Adicionales_Asignacion_Combustible(objEntidad)
        End Function

        Public Function Actualizar_Asignacion_Combustible_Tracto_EX(ByVal objEntidad As Combustible) As Int32
            objDataAccessLayer.Actualizar_Asignacion_Combustible_Tracto(objEntidad)
        End Function

        Public Function Validar_Existencia_Vale_Asignacion_Combustible(ByVal objParametro As Hashtable) As Int64
            Return objDataAccessLayer.Validar_Existencia_Vale_Asignacion_Combustible(objParametro)
        End Function
        Public Function Listar_Vales_Asignados_x_Liquidacion(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Vales_Asignados_x_Liquidacion(objParametro)
        End Function

        Public Function Listar_Operaciones_Asignados_x_Liquidacion(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_Asignados_x_Liquidacion(objParametro)
        End Function
        Public Sub Registrar_Distribucion_Cierre_Liquidacion(ByVal objParametro As LiquidacionCombustible)
            objDataAccessLayer.Registrar_Distribucion_Cierre_Liquidacion(objParametro)
        End Sub
    End Class

End Namespace
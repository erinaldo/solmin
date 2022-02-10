Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones
  Public Class LiquidacionCombustible_BLL
    Dim objDataAccessLayer As New LiquidacionCombustible_DAL



    Public Function Validar_Existencia_Operacion_Liquidacion(ByVal objParameter As Hashtable) As Int64
      Return objDataAccessLayer.Validar_Existencia_Operacion_Liquidacion(objParameter)
    End Function

    Public Function Listar_Liquidacion_Combustible_x_Tractos(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
      Return objDataAccessLayer.Listar_Liquidacion_Combustible_x_Tractos(objParametro)
    End Function

    Public Function Listar_Detalle_Liquidacion_Combustible_x_Tractos(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
      Return objDataAccessLayer.Listar_Detalle_Liquidacion_Combustible_x_Tractos(objParametro)
    End Function

    Public Function Listar_Detalle_Liquidacion_Vales_x_Tractos(ByVal objParametro As Hashtable) As List(Of Combustible)
      Return objDataAccessLayer.Listar_Detalle_Liquidacion_Vales_x_Tractos(objParametro)
    End Function

    Public Function Lista_Vales_Ruta_x_Tracto(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
      Return objDataAccessLayer.Lista_Vales_Ruta_x_Tracto(objParametro)
        End Function

        Public Function Listar_Liquidacion_Combustible_x_Operacion(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Return objDataAccessLayer.Listar_Liquidacion_Combustible_x_Operacion(objParametro)
        End Function

        Public Function Listar_Operacion_Liquidada(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Return objDataAccessLayer.Listar_Operacion_Liquidada(objParametro)
        End Function

        Public Function Actualizar_Liquidacion_Combustible(ByVal objEntidad As LiquidacionCombustible) As LiquidacionCombustible
            Return objDataAccessLayer.Actualizar_Liquidacion_Combustible(objEntidad)
        End Function


        '' NUEVA LIQUIDACION

        Public Sub registrar_inf_escaner_liquidacion(ByVal objParameter As Hashtable)
            objDataAccessLayer.registrar_inf_escaner_liquidacion(objParameter)
        End Sub

      

        'Public Function obtener_Nro_Liq_Corr() As DataTable
        '    Return objDataAccessLayer.obtener_Nro_Liq_Corr
        'End Function

        Public Function Registrar_Liquidacion_Combustible(ByVal objEntidad As LiquidacionCombustible) As LiquidacionCombustible
            Return objDataAccessLayer.Registrar_Liquidacion_Combustible(objEntidad)
        End Function

        Public Function Registrar_Detalle_Liquidacion_Combustible(ByVal list_ObjEntidad As List(Of LiquidacionCombustible)) As Int32
            For Each obj_Entidad As LiquidacionCombustible In list_ObjEntidad
                Return objDataAccessLayer.Registrar_Detalle_Liquidacion_Combustible(obj_Entidad).NLQCMB
            Next
        End Function

        Public Sub Registrar_Detalle_Liquidacion_Combustible2(ByVal ObjEntidad As LiquidacionCombustible)
            objDataAccessLayer.Registrar_Detalle_Liquidacion_Combustible2(ObjEntidad)
        End Sub

        Public Function cargar_vehiculo(ByVal objEntidad As Hashtable) As List(Of LiquidacionCombustible)
            Return objDataAccessLayer.cargar_vehiculo(objEntidad)
        End Function
        Public Function Listar_Imagenes_x_Liquidacion(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Return objDataAccessLayer.Listar_Imagenes_x_Liquidacion(objParametro)
        End Function
        Public Function Actualizar_Importe_Vale_Desde_Excel(ByVal objEntidad As LiquidacionCombustible) As String
            Return objDataAccessLayer.Actualizar_Importe_Vale_Desde_Excel(objEntidad)
        End Function

        Public Function registrar_liquidacion(ByVal objentidad As Hashtable) As LiquidacionCombustible
            Return objDataAccessLayer.Registrar_Liquidacion(objentidad)
        End Function

        Public Function Registrar_Liquidacion_Tracto(ByVal objentidad As Hashtable, ByRef pNLQCMB As Decimal) As String
            Return objDataAccessLayer.Registrar_Liquidacion_Tracto(objentidad, pNLQCMB)
        End Function

        Public Function Listar_Liquidacion_Combustible(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Return objDataAccessLayer.Listar_Liquidacion_Combustible(objParametro)
        End Function
        Public Function Listar_Liquidacion_Combustible_V2(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Liquidacion_Combustible_V2(objParametro)
        End Function

        Public Function Eliminar_Liquidacion_Combustible(ByVal objEntidad As Hashtable) As String
            Return objDataAccessLayer.Eliminar_Liquidacion_Combustible(objEntidad)
        End Function
        Public Function Cerrar_Liquidacion_Combustible(ByVal objParameter As Hashtable) As String
            Return objDataAccessLayer.Cerrar_Liquidacion_Combustible(objParameter)
        End Function
        Public Function Listar_Operacion_Pendientes_Liquidacion_Combustible(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operacion_Pendientes_Liquidacion_Combustible(objParametro)
        End Function

        Public Sub Eliminar_Detalle_Liquidacion_Combustible(ByVal ObjEntidad As LiquidacionCombustible)
            objDataAccessLayer.Eliminar_Detalle_Liquidacion_Combustible(ObjEntidad)
        End Sub
        Public Function Anular_Pre_Cierre_Liquidacion_Combustible(ByVal objEntidad As Hashtable) As String
            Return objDataAccessLayer.Anular_Pre_Cierre_Liquidacion_Combustible(objEntidad)
        End Function
        Public Function Listar_Reporte_Liquidacion(ByVal objParametro As Hashtable) As List(Of LiquidacionCombustible)
            Return objDataAccessLayer.Listar_Reporte_Liquidacion(objParametro)
        End Function
        Public Function Listar_Reporte_Operaciones_Asig_Liquidacion(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Reporte_Operaciones_Asig_Liquidacion(objParametro)
        End Function
        Public Function Listar_Reporte_Vales_Asig_Liquidacion(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Reporte_Vales_Asig_Liquidacion(objParametro)
        End Function
        Public Function Listar_Reporte_Consolidado_Asig_Liquidacion(ByVal objParametro As Hashtable) As DataSet
            Return objDataAccessLayer.Listar_Reporte_Consolidado_Asig_Liquidacion(objParametro)
        End Function
        Public Function Registrar_Vale_Masivo_Desde_Excel(ByVal objEntidad As LiquidacionCombustible) As String
            Return objDataAccessLayer.Registrar_Vale_Masivo_Desde_Excel(objEntidad)
        End Function
        Public Function Listar_Vales_Pendiente_Asignacion(pCCMPN As String, pCDVSN As String, pNPLCUN As String) As DataTable
            Return objDataAccessLayer.Listar_Vales_Pendiente_Asignacion(pCCMPN, pCDVSN, pNPLCUN)
        End Function


    End Class

End Namespace

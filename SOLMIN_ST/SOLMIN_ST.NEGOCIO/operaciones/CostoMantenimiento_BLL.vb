Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones

    Public Class CostoMantenimiento_BLL
        Dim objDataAccessLayer As New CostoMantenimiento_DAL
        Public Function Registrar_Costo_Mantenimiento(ByVal obj_ListaEntidad As List(Of CostoMantenimiento)) As CostoMantenimiento
            Dim obeCostMant As New CostoMantenimiento
            Try
                For Each obeCostoMantenimiento As CostoMantenimiento In obj_ListaEntidad
                    obeCostMant.NCOMNT = objDataAccessLayer.Registrar_Costo_Mantenimiento(obeCostoMantenimiento).NCOMNT
                    If obeCostMant.NCOMNT = 0 Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
                obeCostMant.NCOMNT = 0
            End Try
            Return obeCostMant
        End Function

        Public Function Validar_Existe_Mes_Anio(ByVal obj_Entidad As CostoMantenimiento) As Integer
            Return objDataAccessLayer.Validar_Existe_Mes_Anio(obj_Entidad)
        End Function

        Public Function Actualizar_Costo_Mantenimiento(ByVal obj_Entidad As CostoMantenimiento) As CostoMantenimiento
            Return objDataAccessLayer.Actualizar_Costo_Mantenimiento(obj_Entidad)
        End Function

        Public Function Buscar_Costo_Mantenimiento(ByVal obj_Entidad As CostoMantenimiento) As Boolean
            Return objDataAccessLayer.Buscar_Costo_Mantenimiento(obj_Entidad)
        End Function

        Public Function Actualizar_Costo_Mantenimiento_Operacion(ByVal obj_ListaEntidad As List(Of CostoMantenimiento)) As CostoMantenimiento
            Dim obeCostMant As New CostoMantenimiento
            Try
                For Each obeCostoMantenimiento As CostoMantenimiento In obj_ListaEntidad
                    obeCostMant.NLQMNT = objDataAccessLayer.Actualizar_Costo_Mantenimiento_Operacion(obeCostoMantenimiento).NLQMNT
                    If obeCostMant.NLQMNT = 0 Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
                obeCostMant.NLQMNT = 0
            End Try
            Return obeCostMant
        End Function

        Public Function Registrar_Costo_Mantenimiento_Operacion(ByVal obj_ListaEntidad As List(Of CostoMantenimiento)) As CostoMantenimiento
            Dim obeCostMant As New CostoMantenimiento
            Try
                For Each obeCostoMantenimiento As CostoMantenimiento In obj_ListaEntidad
                    obeCostMant.NLQMNT = objDataAccessLayer.Registrar_Costo_Mantenimiento_Operacion(obeCostoMantenimiento).NLQMNT
                    If obeCostMant.NLQMNT = 0 Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
                obeCostMant.NLQMNT = 0
            End Try
            Return obeCostMant
        End Function

        Public Function Listar_Importe_Soles_X_Mes_Anio(ByVal obj_Parametro As Hashtable) As List(Of CostoMantenimiento)
            Return objDataAccessLayer.Listar_Importe_Soles_X_Mes_Anio(obj_Parametro)
        End Function

        Public Function Listar_Vehiculo_CM_X_Mes_Anio(ByVal obj_Entidad As CostoMantenimiento) As List(Of CostoMantenimiento)
            Return objDataAccessLayer.Listar_Vehiculo_CM_X_Mes_Anio(obj_Entidad)
        End Function

        Public Function Listar_Cuadro_Costo_X_Mes_Anio(ByVal obj_Entidad As CostoMantenimiento) As DataTable 'List(Of CostoMantenimiento)
            Return objDataAccessLayer.Listar_Cuadro_Costo_X_Mes_Anio(obj_Entidad)
        End Function

        Public Function Validar_Existe_Costo_Mantenimiento_Operacion(ByVal objEntidad As CostoMantenimiento) As Integer
            Return objDataAccessLayer.Validar_Existe_Costo_Mantenimiento_Operacion(objEntidad)
        End Function

        Public Function Listar_Costo_Mantenimiento_X_Mes_Anio_Excel(ByVal obj_Parametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Costo_Mantenimiento_X_Mes_Anio_Excel(obj_Parametro)
        End Function

    End Class

End Namespace
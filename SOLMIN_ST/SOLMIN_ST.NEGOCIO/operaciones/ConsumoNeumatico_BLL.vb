Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Namespace Operaciones

    Public Class ConsumoNeumatico_BLL

        Dim objDataAccessLayer As New ConsumoNeumatico_DAL

        Public Function Registrar_Consumo_Neumatico(ByVal obj_ListaEntidad As List(Of ConsumoNeumatico)) As ConsumoNeumatico
            Dim obeConsNeum As New ConsumoNeumatico
            Try
                For Each obeConsumoNeumatico As ConsumoNeumatico In obj_ListaEntidad
                    obeConsNeum.NCONEU = objDataAccessLayer.Registrar_Consumo_Neumatico(obeConsumoNeumatico).NCONEU
                    If obeConsNeum.NCONEU = 0 Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
                obeConsNeum.NCONEU = 0
            End Try
            Return obeConsNeum
        End Function

        Public Function Validar_Existe_Mes_Anio(ByVal obj_Entidad As ConsumoNeumatico) As Integer
            Return objDataAccessLayer.Validar_Existe_Mes_Anio(obj_Entidad)
        End Function

        Public Function Eliminar_Consumo_Neumatico(ByVal obj_Entidad As ConsumoNeumatico) As ConsumoNeumatico
            Return objDataAccessLayer.Eliminar_Consumo_Neumatico(obj_Entidad)
        End Function

        Public Function Registrar_Consumo_Neumatico_Operacion(ByVal obj_ListaEntidad As List(Of ConsumoNeumatico)) As ConsumoNeumatico
            Dim obeConsNeum As New ConsumoNeumatico
            Try
                For Each obeConsumoNeumatico As ConsumoNeumatico In obj_ListaEntidad
                    obeConsNeum.NLQNEM = objDataAccessLayer.Registrar_Consumo_Neumatico_Operacion(obeConsumoNeumatico).NLQNEM
                    If obeConsNeum.NLQNEM = 0 Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
                obeConsNeum.NLQNEM = 0
            End Try
            Return obeConsNeum
        End Function

        Public Function Actualizar_Consumo_Neumatico_Operacion(ByVal obj_ListaEntidad As List(Of ConsumoNeumatico)) As ConsumoNeumatico
            Dim obeConsNeum As New ConsumoNeumatico
            Try
                For Each obeConsumoNeumatico As ConsumoNeumatico In obj_ListaEntidad
                    obeConsNeum.NLQNEM = objDataAccessLayer.Actualizar_Consumo_Neumatico_Operacion(obeConsumoNeumatico).NLQNEM
                    If obeConsNeum.NLQNEM = 0 Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
                obeConsNeum.NLQNEM = 0
            End Try
            Return obeConsNeum
        End Function

        Public Function Listar_Importe_Soles_X_Mes_Anio(ByVal obj_Parametro As Hashtable) As List(Of ConsumoNeumatico)
            Return objDataAccessLayer.Listar_Importe_Soles_X_Mes_Anio(obj_Parametro)
        End Function

        Public Function Listar_Vehiculo_X_Mes_Anio(ByVal obj_Entidad As ConsumoNeumatico) As List(Of ConsumoNeumatico)
            Return objDataAccessLayer.Listar_Vehiculo_X_Mes_Anio(obj_Entidad)
        End Function

        Public Function Listar_Cuadro_Costo_X_Mes_Anio(ByVal obj_Entidad As ConsumoNeumatico) As DataTable 'List(Of ConsumoNeumatico)
            Return objDataAccessLayer.Listar_Cuadro_Costo_X_Mes_Anio(obj_Entidad)
        End Function

        Public Function Validar_Existe_Consumo_Neumatico_Operacion(ByVal obj_Entidad As ConsumoNeumatico) As Integer
            Return objDataAccessLayer.Validar_Existe_Consumo_Neumatico_Operacion(obj_Entidad)
        End Function

        Public Function Listar_Consumo_Neumatico_X_Mes_Anio_Excel(ByVal obj_Parametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Consumo_Neumatico_X_Mes_Anio_Excel(obj_Parametro)
        End Function
    End Class

End Namespace


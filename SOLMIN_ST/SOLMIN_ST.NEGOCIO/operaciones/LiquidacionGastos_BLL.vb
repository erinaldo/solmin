Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones
  Public Class LiquidacionGastos_BLL
    Dim objDataAccessLayer As New LiquidacionGastos_DAL

        Public Function Registrar_Liquidacion_Gasto(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
            Return objDataAccessLayer.Registrar_Liquidacion_Gasto(objEntidad)
        End Function

        Public Function Eliminar_Liquidacion_Gasto(ByVal objEntidad As LiquidacionGastos) As Decimal
            Return objDataAccessLayer.Eliminar_Liquidacion_Gasto(objEntidad)
        End Function

        Public Function Listar_Seguimiento_AVC(ByVal objetoParametro As Hashtable) As DataTable
            Dim dt As DataTable = objDataAccessLayer.Listar_Seguimiento_AVC(objetoParametro)
            Dim blExiste As Boolean = False
            Dim TCMPCL As String = ""
            Dim NOPRCN As Decimal = 0
            For i As Integer = 0 To dt.Rows.Count - 1
                blExiste = False
                If i = 0 Then
                    TCMPCL = dt.Rows(i).Item("CLIENTE")
                    NOPRCN = dt.Rows(i).Item("OPERACION")
                End If
                If TCMPCL = dt.Rows(i).Item("CLIENTE") And _
                           NOPRCN = dt.Rows(i).Item("OPERACION") Then
                    blExiste = True
                End If
                TCMPCL = dt.Rows(i).Item("CLIENTE")
                NOPRCN = dt.Rows(i).Item("OPERACION")
                If blExiste And i > 0 Then
                    dt.Rows(i).Item("CLIENTE") = ""
                    dt.Rows(i).Item("OPERACION") = DBNull.Value
                    dt.Rows(i).Item("IMPORTE") = DBNull.Value
                    dt.Rows(i).Item("ORIGEN") = ""
                    dt.Rows(i).Item("DESTINO") = ""
                    dt.Rows(i).Item("USUARIO_CREADOR") = ""
                    dt.Rows(i).Item("USUARIO_LIQUIDADOR") = ""
                End If
            Next
            Return dt
        End Function

    Public Function Listar_Liquidacion_Gasto(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            'Try
            Return objDataAccessLayer.Listar_Liquidacion_Gasto(objetoParametro)
            'Catch ex As Exception
            '          Return New List(Of LiquidacionGastos)
            '      End Try
    End Function

        Public Function Eliminar_Operacion_x_Liquidacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            Return objDataAccessLayer.Eliminar_Operacion_x_Liquidacion(objEntidad)
        End Function

    Public Function Listar_Operacion_x_Liquidacion(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            'Try
            Return objDataAccessLayer.Listar_Operacion_x_Liquidacion(objetoParametro)
            'Catch ex As Exception
            '          Return New List(Of LiquidacionGastos)
            '      End Try
    End Function

        Public Function Registrar_Ruta_x_Operacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            Return objDataAccessLayer.Registrar_Ruta_x_Operacion(objEntidad)
        End Function

        Public Function Modificar_Ruta_x_Operacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            Return objDataAccessLayer.Modificar_Ruta_x_Operacion(objEntidad)
        End Function

    Public Function Registrar_Gasto_Ruta_Operacion(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
      Return objDataAccessLayer.Registrar_Gasto_Ruta_Operacion(objEntidad)
        End Function

        Public Function Registrar_FechaRecepcion_Gasto_Ruta_Operacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            Return objDataAccessLayer.Registrar_FechaRecepcion_Gasto_Ruta_Operacion(objEntidad)
        End Function

    Public Function Registrar_Gasto_Ruta_Operacion(ByVal list_ObjEntidad As List(Of LiquidacionGastos)) As Integer
      For Each obj_Entidad As LiquidacionGastos In list_ObjEntidad
        objDataAccessLayer.Registrar_Gasto_Ruta_Operacion(obj_Entidad)
      Next
    End Function

    Public Function Registrar_Gasto_Combustible(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
      Return objDataAccessLayer.Registrar_Gasto_Combustible(objEntidad)
    End Function

    Public Function Modificar_Gasto_Combustible(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
      Return objDataAccessLayer.Modificar_Gasto_Combustible(objEntidad)
    End Function

    Public Function Eliminar_Gasto_Ruta_Operacion(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
      Return objDataAccessLayer.Eliminar_Gasto_Ruta_Operacion(objEntidad)
    End Function

    Public Function Eliminar_Gasto_Combustible(ByVal objEntidad As LiquidacionGastos) As LiquidacionGastos
      Return objDataAccessLayer.Eliminar_Gasto_Combustible(objEntidad)
    End Function

    Public Function Listar_Gasto_Ruta_Operacion(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            'Try
            Return objDataAccessLayer.Listar_Gasto_Ruta_Operacion(objetoParametro)
            'Catch ex As Exception
            '          Return New List(Of LiquidacionGastos)
            '      End Try
    End Function

    Public Function Listar_Gasto_Combustible(ByVal objetoParametro As Hashtable) As List(Of LiquidacionGastos)
            'Try
            Return objDataAccessLayer.Listar_Gasto_Combustible(objetoParametro)
            'Catch ex As Exception
            '          Return New List(Of LiquidacionGastos)
            '      End Try
    End Function

    Public Function Listar_Gastos() As List(Of ClaseGeneral)
            'Try
            Return objDataAccessLayer.Listar_Gastos()
            'Catch ex As Exception
            '          Return New List(Of ClaseGeneral)
            '      End Try
    End Function

        Public Function Cerrar_Lquidacion(ByVal objEntidad As LiquidacionGastos) As Decimal
            Return objDataAccessLayer.Cerrar_Lquidacion(objEntidad)
        End Function

    Public Function Lista_AVC_x_Tracto(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
            'Try
            Return objDataAccessLayer.Lista_AVC_x_Tracto(objetoParametro)
            'Catch ex As Exception
            '          Return New List(Of ClaseGeneral)
            '      End Try
    End Function

    Public Function Listar_Detalle_Liquidacion_Gasto(ByVal objetoParametro As Hashtable) As DataSet
            'Try
            Return objDataAccessLayer.Listar_Detalle_Liquidacion_Gasto(objetoParametro)
            'Catch ex As Exception
            '          Return New DataSet
            '      End Try
    End Function

    Public Function Listar_Liquidacion_Gastos_RPT(ByVal objetoParametro As Hashtable) As DataSet
            'Try
            Return objDataAccessLayer.Listar_Liquidacion_Gastos_RPT(objetoParametro)
            'Catch ex As Exception
            '          Return New DataSet
            '      End Try
        End Function

        Public Function Listar_Liquidacion_Conductor_Gastos_RPT(ByVal objetoParametro As Hashtable) As DataSet
            'Try
            Return objDataAccessLayer.Listar_Liquidacion_Conductor_Gastos_RPT(objetoParametro)
            'Catch ex As Exception
            '    Return New DataSet
            'End Try
        End Function

    Public Function Listar_Liquidacion_General_RPT(ByVal objetoParametro As Hashtable) As DataSet
            'Try
            Return objDataAccessLayer.Listar_Liquidacion_General_RPT(objetoParametro)
            'Catch ex As Exception
            '          Return New DataSet
            '      End Try
        End Function

        Public Function Listar_Liquidacion_Gasto_Detalle(ByVal objetoParametro As Hashtable) As DataTable
            'Try
            Return objDataAccessLayer.Listar_Liquidacion_Gasto_Detalle(objetoParametro)
            'Catch ex As Exception
            '    Return New DataTable
            'End Try
        End Function

        Public Function Listar_Liquidacion_Gasto_Detalle_V2(ByVal objetoParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Liquidacion_Gasto_Detalle_V2(objetoParametro)
        End Function

        Public Sub Actualizar_Gasto_Ruta_Operacion_X_Gasto(ByVal objEntidad As LiquidacionGastos)
            objDataAccessLayer.Actualizar_Gasto_Ruta_Operacion_X_Gasto(objEntidad)
        End Sub

    End Class

End Namespace


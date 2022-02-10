Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

  Public Class Grifo_BLL
    Dim objDataAccessLayer As New Grifos_DAL

        Public Function Registrar_Grifo(ByVal objEntidad As Grifo, ByRef IdGrifo As Decimal) As String
            Return objDataAccessLayer.Registrar_Grifo(objEntidad, IdGrifo)
        End Function

        Public Function Modificar_Grifo(ByVal objEntidad As Grifo) As String
            Return objDataAccessLayer.Modificar_Grifo(objEntidad)
        End Function

        Public Sub Eliminar_Grifo(ByVal objEntidad As Grifo)
            objDataAccessLayer.Eliminar_Grifo(objEntidad)
        End Sub

        Public Function Listar_Grifos() As List(Of Grifo)
            Return objDataAccessLayer.Listar_Grifos()
        End Function

        Public Function Listar_Grifos_Todos(TGRFO As String) As List(Of Grifo)
            Return objDataAccessLayer.Listar_Grifos_Todos(TGRFO)
        End Function
      

        Public Sub Registrar_Tarifa_Grifo(ByVal objEntidad As Grifo)
            objDataAccessLayer.Registrar_Tarifa_Grifo(objEntidad)
        End Sub

    Public Function Listar_Tarifa_Grifo(ByVal objEntidad As Grifo) As List(Of Grifo)
      Return objDataAccessLayer.Listar_Tarifa_Grifo(objEntidad)
    End Function

        Public Sub Eliminar_Tarifa_Grifo(ByVal objEntidad As Grifo)
            objDataAccessLayer.Eliminar_Tarifa_Grifo(objEntidad)
        End Sub

    Public Function Listar_Tarifa_Actual(ByVal objParametro As Hashtable) As List(Of Grifo)
      Return objDataAccessLayer.Listar_Tarifa_Actual(objParametro)
        End Function

        Public Function Listar_Grifo_Proveedor() As List(Of Grifo)
            Return objDataAccessLayer.Listar_Grifo_Proveedor()
        End Function
        Public Function Listar_Grifo_Validacion_Carga() As DataTable
            Return objDataAccessLayer.Listar_Grifo_Validacion_Carga()
        End Function
        Public Function Listar_Grifo_Validacion_Edicion(CGRFO As Decimal) As Decimal
            Return objDataAccessLayer.Listar_Grifo_Validacion_Edicion(CGRFO)
        End Function
  End Class

End Namespace

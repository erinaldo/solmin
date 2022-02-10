Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES.Mantenimientos


Public Class Empleado_BLL

    Private objDatos As Empleado_DAL

    Public Sub New()
        objDatos = New Empleado_DAL
    End Sub


    Public Function Lista_Empleados(ByVal objEntidad As Hashtable) As List(Of Empleado)
        Try
            Return objDatos.Lista_Empleados(objEntidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Listar_TipoEmpleado(ByVal CCMP As String) As DataTable
        Try
            Return objDatos.Listar_TipoEmpleado(CCMP)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Modificar_Empleados(ByVal objEntidad As Empleado) As Empleado
        Return objDatos.Modificar_Empleado(objEntidad)
    End Function

    Public Function Registrar_Empleados(ByVal objEntidad As Empleado) As Empleado
        Return objDatos.Registrar_Empleado(objEntidad)
    End Function


    Public Function Cambiar_Estado_ServicioTransporte(ByVal objEntidad As Empleado) As Empleado
        Return objDatos.Cambiar_Estado_Empleado(objEntidad)
    End Function

End Class



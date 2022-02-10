 
Imports System.Collections.Generic
 
    Public Class Rol_BL
        Private objDataAccessLayer As New Rol_DAL
        Public Function Registra_Rol(ByVal objEntidad As RolBE) As Integer
            Return objDataAccessLayer.Registrar_Rol(objEntidad)
        End Function
        Public Function Lista_Rol() As List(Of RolBE)
            Try
                Return objDataAccessLayer.Listar_Rol()
            Catch
                Return New List(Of RolBE)
            End Try
        End Function
        Public Function Modifica_Rol(ByVal objEntidad As RolBE) As Integer
            Return objDataAccessLayer.Modificar_Rol(objEntidad)
        End Function
        Public Function Elimina_Rol(ByVal objEntidad As RolBE) As Integer
            Return objDataAccessLayer.Eliminar_Rol(objEntidad)
        End Function
    End Class 
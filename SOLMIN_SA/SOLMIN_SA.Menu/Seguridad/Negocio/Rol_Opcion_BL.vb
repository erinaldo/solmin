 
Imports System.Collections.Generic
 
    Public Class Rol_Opcion_BL
        Private objDataAccessLayer As New Rol_Opcion_DAL
        Public Function Registra_Rol_Opcion(ByVal ListRolOp As List(Of Rol_OpcionBE)) As Integer
            Try
                For Each RolOpcionBE As Rol_OpcionBE In ListRolOp
                    objDataAccessLayer.Registar_RolOpcion(RolOpcionBE)
                Next
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function
        Public Function Eliminar_Rol_Opcion(ByVal ListRolOpEliminar As List(Of Rol_OpcionBE)) As Integer
            Try
                For Each RolOpcionBE As Rol_OpcionBE In ListRolOpEliminar
                    objDataAccessLayer.Eliminar_RolOpcion(RolOpcionBE)
                Next
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function
        Public Function Lista_Rol_Opcion() As List(Of Rol_OpcionBE)
            Try
                Return objDataAccessLayer.Listar_RolOpcion()
            Catch ex As Exception
                Return New List(Of Rol_OpcionBE)
            End Try
        End Function
    End Class 
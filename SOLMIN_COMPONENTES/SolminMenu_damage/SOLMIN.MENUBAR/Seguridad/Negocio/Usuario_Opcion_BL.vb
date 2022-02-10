 
Imports System.Collections.Generic
 
    Public Class Usuario_Opcion_BL
        Private objDataAccessLayer As New Usuario_Opcion_DAL
        Public Function Registra_Usuario_Opcion(ByVal ListUsuaOp As List(Of Usuario_OpcionBE)) As Integer
            Try
                For Each UsuOpcionBE As Usuario_OpcionBE In ListUsuaOp
                    objDataAccessLayer.Registar_UsuarioOpcion(UsuOpcionBE)
                Next
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function
        Public Function Eliminar_Usuario_Opcion(ByVal ListUsuOpEliminar As List(Of Usuario_OpcionBE)) As Integer
            Try
                For Each UsuOpcionBE As Usuario_OpcionBE In ListUsuOpEliminar
                    objDataAccessLayer.Eliminar_UsuarioOpcion(UsuOpcionBE)
                Next
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function
        Public Function Lista_Usuario_Opcion() As List(Of Usuario_OpcionBE)
            Try
                Return objDataAccessLayer.Listar_UsuarioOpcion()
            Catch ex As Exception
                Return New List(Of Usuario_OpcionBE)
            End Try
        End Function
    End Class 
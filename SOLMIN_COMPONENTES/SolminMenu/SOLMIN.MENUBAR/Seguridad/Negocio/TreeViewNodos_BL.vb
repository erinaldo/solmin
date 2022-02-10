 
Imports System.Collections.Generic
 
    Public Class TreeViewNodos_BL
        Private objDataAccessLayer As New TreeViewNodos_DAL
        Public Function Lista_Opcion(ByVal Usuario As String) As List(Of TreeViewNodosBE)
            Try
                Return objDataAccessLayer.Conseguir_Opcion(Usuario)
            Catch ex As Exception
                Return New List(Of TreeViewNodosBE)
            End Try
        End Function
        Public Function Lista_Opcion() As List(Of TreeViewNodosBE)
            Try
                Return objDataAccessLayer.Listar_Opcion()
            Catch ex As Exception
                Return New List(Of TreeViewNodosBE)
            End Try
        End Function
        Public Function Lista_Menu(ByVal Usuario As String) As List(Of TreeViewNodosBE)
            Try
                Return objDataAccessLayer.Conseguir_Menu(Usuario)
            Catch ex As Exception
                Return New List(Of TreeViewNodosBE)
            End Try
        End Function
        Public Function Lista_Menu() As List(Of TreeViewNodosBE)
            Try
                Return objDataAccessLayer.Listar_Menu()
            Catch ex As Exception
                Return New List(Of TreeViewNodosBE)
            End Try
        End Function
        Public Function Lista_Aplicacion(ByVal Usuario As String) As List(Of TreeViewNodosBE)
            Try
                Return objDataAccessLayer.Conseguir_Aplicacion(Usuario)
            Catch ex As Exception
                Return New List(Of TreeViewNodosBE)
            End Try
        End Function
        Public Function Lista_Aplicacion() As List(Of TreeViewNodosBE)
            Try
                Return objDataAccessLayer.Listar_Aplicacion()
            Catch ex As Exception
                Return New List(Of TreeViewNodosBE)
            End Try
        End Function
        Public Function Lista_Usuario_Opcion(ByVal UsuarioOpcionBE As String) As List(Of Usuario_OpcionBE)
            Try
                Return objDataAccessLayer.Conseguir_Usuario_Opcion(UsuarioOpcionBE)
            Catch ex As Exception
                Return New List(Of Usuario_OpcionBE)
            End Try
        End Function
        Public Function Lista_Rol_Opcion(ByVal RolOpcionBE As String) As List(Of Rol_OpcionBE)
            Try
                Return objDataAccessLayer.Conseguir_Rol_Opcion(RolOpcionBE)
            Catch ex As Exception
                Return New List(Of Rol_OpcionBE)
            End Try
        End Function
    End Class 


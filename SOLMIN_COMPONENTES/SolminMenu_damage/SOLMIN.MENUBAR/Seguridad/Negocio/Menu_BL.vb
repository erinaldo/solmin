 
Imports System.Collections.Generic
 
    Public Class Menu_BL
        Private objDataAccessLayer As New Menu_DAL
        Public Function Registra_Menu(ByVal Menu As MenuBE) As Integer
            Return objDataAccessLayer.Registrar_Menu(Menu)
        End Function
        Public Function Modifica_Menu(ByVal Menu As MenuBE) As Integer
            Return objDataAccessLayer.Modificar_Menu(Menu)
        End Function
        Public Function Elimina_Menu(ByVal Menu As MenuBE) As Integer
            Return objDataAccessLayer.Eliminar_Menu(Menu)
        End Function
        Public Function Lista_Menu() As List(Of MenuBE)
            Try
                Return objDataAccessLayer.Listar_Menu()
            Catch ex As Exception
                Return New List(Of MenuBE)
            End Try
        End Function
        Public Function Lista_Menu(ByVal Usuario_BE As String) As List(Of MenuBE)
            Try
                Return objDataAccessLayer.Listar_Menu(Usuario_BE)
            Catch ex As Exception
                Return New List(Of MenuBE)
            End Try
        End Function
    End Class
 
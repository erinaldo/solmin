 
Imports System.Collections.Generic
 
    Public Class Usuario_BL
        Private objDataAccessLayer As New Usuario_DAL
        Public Function Lista_Usuario() As List(Of UsuarioBE)
            Try
                Return objDataAccessLayer.Listar_Usuario()
            Catch ex As Exception
                Return New List(Of UsuarioBE)
            End Try
        End Function
    End Class 
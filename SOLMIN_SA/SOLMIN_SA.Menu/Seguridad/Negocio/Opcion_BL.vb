 
Imports System.Collections.Generic
 
    Public Class Opcion_BL
        Private objDataAccessLayer As New Opcion_DAL
        Public Function Registra_Opcion(ByVal Opcion As OpcionBE) As Integer
            Return objDataAccessLayer.Registar_Opcion(Opcion)
        End Function
        Public Function Modifica_Opcion(ByVal Opcion As OpcionBE) As Integer
            Return objDataAccessLayer.Modificar_Opcion(Opcion)
        End Function
        Public Function Elimina_Opcion(ByVal Opcion As OpcionBE) As Integer
            Return objDataAccessLayer.Eliminar_Opcion(Opcion)
        End Function
        Public Function Lista_Opcion() As List(Of OpcionBE)
            Try
                Return objDataAccessLayer.Listar_Opcion()
            Catch ex As Exception
                Return New List(Of OpcionBE)
            End Try
  End Function
  Public Function Lista_Opcion(ByVal objtOpcion As OpcionBE) As List(Of OpcionBE)
    Try
      Return objDataAccessLayer.Listar_Opcion(objtOpcion)
    Catch ex As Exception
      Return New List(Of OpcionBE)
    End Try
  End Function
    End Class
 
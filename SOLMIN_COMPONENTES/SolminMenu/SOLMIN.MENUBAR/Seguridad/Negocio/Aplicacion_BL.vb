 
Imports System.Collections.Generic
 
    Public Class Aplicacion_BL
        Private objDataAccessLayer As New Aplicacion_DAL
  Public Function Registra_Aplicacion(ByVal obj_Entidad As AplicacionBE) As Integer
    Return objDataAccessLayer.Registrar_Aplicacion(obj_Entidad)
  End Function
        Public Function Modifica_Aplicacion(ByVal Aplicacion_BE As AplicacionBE) As Integer
            Return objDataAccessLayer.Modificar_Aplicacion(Aplicacion_BE)
        End Function
        Public Function Elimina_Aplicacion(ByVal Aplicacion_BE As AplicacionBE) As Integer
            Return objDataAccessLayer.Eliminar_Aplicacion(Aplicacion_BE)
        End Function
        Public Function Lista_Aplicacion() As List(Of AplicacionBE)
            Try
                Return objDataAccessLayer.Listar_Aplicacion()
            Catch ex As Exception
                Return New List(Of AplicacionBE)
            End Try
        End Function
        Public Function Lista_Aplicacion(ByVal Usuario_BE As String) As List(Of AplicacionBE)
            Try
                Return objDataAccessLayer.Listar_Aplicacion(Usuario_BE)
            Catch ex As Exception
                Return New List(Of AplicacionBE)
            End Try
        End Function
    End Class 
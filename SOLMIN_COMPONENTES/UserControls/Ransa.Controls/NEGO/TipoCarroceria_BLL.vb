Imports System.Collections.Generic

Public Class TipoCarroceria_BLL
    Dim objDataAccessLayer As New TipoCarroceria_DAL

    Public Function Listar_TipoCarroceria(ByVal strCompania As String) As List(Of TipoCarroceria)
        Try
            Return objDataAccessLayer.Listar_TipoCarroceria(strCompania)
        Catch
            Return New List(Of TipoCarroceria)
        End Try
    End Function

    Public Function Listar_TipoCarroceria_DeBitacoraVehiculo(ByVal objEntidad As TipoCarroceria) As List(Of TipoCarroceria)
        Try
            Return objDataAccessLayer.Listar_TipoCarroceria_DeBitacoraVehiculo(objEntidad)
        Catch ex As Exception
            Return New List(Of TipoCarroceria)
        End Try
    End Function
End Class

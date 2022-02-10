
Imports System.Collections.Generic

Public Class ServicioTransporte_BLL
    Dim objDataAccessLayer As New ServicioTransporte_DAL
    Public Function Registrar_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As ServicioTransporte
        Return objDataAccessLayer.Registrar_ServicioTransporte(objEntidad)
    End Function

    Public Function Modificar_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As ServicioTransporte
        Return objDataAccessLayer.Modificar_ServicioTransporte(objEntidad)
    End Function

    Public Function Cambiar_Estado_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As ServicioTransporte
        Return objDataAccessLayer.Cambiar_Estado_ServicioTransporte(objEntidad)
    End Function

    Public Function Listar_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As List(Of ServicioTransporte)
        Try
            Return objDataAccessLayer.Listar_ServicioTransporte(objEntidad)
        Catch
            Return New List(Of ServicioTransporte)
        End Try
    End Function

    Public Function Busca_ServicioTransporte(ByVal objEntidad As ServicioTransporte) As List(Of ServicioTransporte)
        Try
            Return objDataAccessLayer.Buscar_ServicioTransporte(objEntidad)
        Catch
            Return New List(Of ServicioTransporte)
        End Try
    End Function
    Public Function Busca_ServicioTransporteBuscar() As DataTable
        Try
            Return objDataAccessLayer.Buscar_ServicioTransporteBuscar()
        Catch
            Return New DataTable
        End Try
    End Function
End Class

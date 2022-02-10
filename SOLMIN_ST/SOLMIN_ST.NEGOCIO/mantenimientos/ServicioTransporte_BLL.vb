Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic
Namespace mantenimientos
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
        Public Function Busca_ServicioTransporteBuscar() As Data.DataTable
            Try
                Return objDataAccessLayer.Buscar_ServicioTransporteBuscar()
            Catch
                Return New Data.DataTable
            End Try
        End Function

        Public Function Listar_ServicioTransporteLiquidacion(ByVal compania As String, ByVal division As String) As List(Of ServicioLiquidacion)
            Try
                Return objDataAccessLayer.Listar_ServicioTransporteLiquidacion(compania, division)
            Catch ex As Exception
                Return New List(Of ServicioLiquidacion)
            End Try
        End Function
    End Class
End Namespace


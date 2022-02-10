Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic
Namespace mantenimientos
    Public Class MercaderiaTransportes_BLL
        Dim objDataAccessLayer As New MercaderiaTransportes_DAL
        Public Function Registrar_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As MercaderiaTransportes
            Return objDataAccessLayer.Registrar_MercaderiaTransportes(objEntidad)
        End Function

        Public Function Modificar_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As MercaderiaTransportes
            Return objDataAccessLayer.Modificar_MercaderiaTransportes(objEntidad)
        End Function

        Public Function Cambiar_Estado_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As MercaderiaTransportes
            Return objDataAccessLayer.Cambiar_Estado_MercaderiaTransportes(objEntidad)
        End Function

        Public Function Listar_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As List(Of MercaderiaTransportes)
            Try
                Return objDataAccessLayer.Listar_MercaderiaTransportes(objEntidad)
            Catch
                Return New List(Of MercaderiaTransportes)
            End Try
        End Function

        Public Function Busca_MercaderiaTransportes(ByVal objEntidad As MercaderiaTransportes) As List(Of MercaderiaTransportes)
            Try
                Return objDataAccessLayer.Buscar_MercaderiaTransportes(objEntidad)
            Catch
                Return New List(Of MercaderiaTransportes)
            End Try
        End Function
        Public Function Busca_MercaderiaTransportesBuscar(ByVal strCompania As String) As Data.DataTable
            Try
                Return objDataAccessLayer.Buscar_MercaderiaTransportesBuscar(strCompania)
            Catch
                Return New Data.DataTable
            End Try
        End Function

    End Class
End Namespace


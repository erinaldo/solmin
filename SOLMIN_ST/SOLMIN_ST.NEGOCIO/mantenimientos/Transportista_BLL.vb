Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic

Namespace mantenimientos
  Public Class Transportista_BLL
    Dim objDataAccessLayer As New Transportista_DAL

    Public Function Registrar_Transportista(ByVal objEntidad As Transportista) As Transportista
      Return objDataAccessLayer.Registrar_Transportista(objEntidad)
    End Function

    Public Function Modificar_Transportista(ByVal objEntidad As Transportista) As Transportista
      Return objDataAccessLayer.Modificar_Transportista(objEntidad)
    End Function

    Public Function Eliminar_Transportista(ByVal objEntidad As Transportista) As Transportista
      Return objDataAccessLayer.Eliminar_Transportista(objEntidad)
    End Function

    Public Function Listar_Transportista_DDL(ByVal objEntidad As Transportista) As List(Of Transportista)
      Return objDataAccessLayer.Listar_Transportista_DDL(objEntidad)
    End Function

        Public Function Listar_Transportista(ByVal objEntidad As Transportista) As List(Of Transportista)
            'Try
            Return objDataAccessLayer.Listar_Transportista(objEntidad)
            'Catch
            '          Return New List(Of Transportista)
            '      End Try
        End Function

        Public Function Listar_Transportista_Por_Tipo(ByVal objEntidad As Transportista, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As List(Of Transportista)

            Return objDataAccessLayer.Listar_Transportista_Por_Tipo(objEntidad, IN_NROPAG, PAGESIZE, TOTPAG)
           
        End Function

    Public Function Listar_TransportistaRPT(ByVal objEntidad As Transportista) As DataTable
      Return objDataAccessLayer.Listar_TransportistaRPT(objEntidad)
    End Function

    Public Function Listar_TransportistaCbo(Optional ByVal strCompania As String = "EZ") As List(Of Transportista)
            'Try
            Return objDataAccessLayer.Listar_TransportistaCbo(strCompania)
            'Catch
            '          Return New List(Of Transportista)
            '      End Try
    End Function

    'Public Function Busca_Trasportista(ByVal objEntidad As Transportista) As List(Of Transportista)
    '  Try
    '    Return objDataAccessLayer.Buscar_Transportista(objEntidad)
    '  Catch
    '    Return New List(Of Transportista)
    '  End Try
        'End Function
        Public Function VerificarMovimientoTransportista(ByVal PNCTRSPT As Decimal, ByVal PSCCMPN As String) As Int32
            Return objDataAccessLayer.VerificarMovimientoTransportista(PNCTRSPT, PSCCMPN)
        End Function

        Public Sub ActivarTransportista(ByVal objEntidad As Transportista)
            objDataAccessLayer.ActivarTransportista(objEntidad)
        End Sub

        Public Function Listar_Transportista_X_RUC(ByVal objEntidad As Transportista) As DataTable
            Return objDataAccessLayer.Listar_Transportista_X_RUC(objEntidad)
        End Function

        Public Function Listar_Proveedor(ByVal objEntidad As Transportista) As List(Of Transportista)
            Return objDataAccessLayer.Listar_Proveedor(objEntidad)
        End Function
        Public Function Actualizar_Flag_Recurso_Proveedor(ByVal objEntidad As Transportista) As Transportista
            Return objDataAccessLayer.Actualizar_Flag_Recurso_Proveedor(objEntidad)
        End Function

        Public Function Listar_Proveedor_Asignado(ByVal objEntidad As Transportista) As List(Of Transportista)
            Return objDataAccessLayer.Listar_Proveedor_Asignado(objEntidad)
        End Function

        Public Function Registrar_AS400_Transportista(ByVal objEntidad As Transportista) As String
            Return objDataAccessLayer.Registrar_AS400_Transportista(objEntidad)
        End Function

    End Class
End Namespace

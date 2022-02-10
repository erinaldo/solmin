'*********************************************************************'
'** Autor: Juan De Dios Leon                                        **'
'** Fecha de Creación: 09/09/2009                                   **'
'** Descripción: CAPA DE NEGOCIO                                    **'
'*********************************************************************'
Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Namespace mantenimientos
  Public Class TipoPaseConductor_BLL
    Private objDataAccessLayer As New TipoPaseConductor_DAL

    Public Function Registra_Tipo_Pases(ByVal objEntidad As TipoPaseConductor) As TipoPaseConductor
      Return objDataAccessLayer.Registrar_Tipo_Pase(objEntidad)
    End Function

    Public Function Modifica_Tipo_Pases(ByVal objEntidad As TipoPaseConductor) As TipoPaseConductor
      Return objDataAccessLayer.Modificar_Tipo_Pase(objEntidad)
    End Function

    Public Function Elimina_Tipo_Pases(ByVal objEntidad As TipoPaseConductor) As TipoPaseConductor
      Return objDataAccessLayer.Eliminar_Tipo_Pase(objEntidad)
    End Function

    Public Function Lista_Tipo_Pases(ByVal objEntidad As TipoPaseConductor) As List(Of TipoPaseConductor)
            'Try
            Return objDataAccessLayer.Listar_Tipo_Pase(objEntidad)
            'Catch
            '          Return New List(Of TipoPaseConductor)
            '      End Try
    End Function
  End Class

End Namespace


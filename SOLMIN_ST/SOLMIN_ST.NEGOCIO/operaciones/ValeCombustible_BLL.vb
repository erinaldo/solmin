Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones
  Public Class ValeCombustible_BLL
    Dim objDataAccessLayer As New ValeCombustible_DAL

    Public Function Registrar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As ValeCombustible
      Return objDataAccessLayer.Registrar_Vale_Combustible(objEntidad)
    End Function

    Public Function Modificar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As ValeCombustible
      Return objDataAccessLayer.Modificar_Vale_Combustible(objEntidad)
    End Function

    Public Function Listar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
      Return objDataAccessLayer.Listar_Vale_Combustible(objEntidad)
    End Function

    Public Function Eliminar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As ValeCombustible
      Return objDataAccessLayer.Eliminar_Vale_Combustible(objEntidad)
    End Function

    Public Function Listar_Vale_Combustible_1(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
      Return objDataAccessLayer.Listar_Vale_Combustible_1(objEntidad)
    End Function

    Public Function Listar_Vale_Combustible_RPT(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
      Return objDataAccessLayer.Listar_Vale_Combustible_RPT(objEntidad)
    End Function

    Public Function Obtener_Numerador_Vale_Combustible() As Double
      Return objDataAccessLayer.Obtener_Numerador_Vale_Combustible()
        End Function

        'Public Function Listar_Vale_Combustible_X_NumVale(ByVal objEntidad As ValeCombustible) As ValeCombustible
        '    Return objDataAccessLayer.Listar_Vale_Combustible_X_NumVale(objEntidad)
        'End Function
        'Public Function Listar_Vale_Combustible_X_Tracto(ByVal objEntidad As ValeCombustible) As DataTable
        '    Return objDataAccessLayer.Listar_Vale_Combustible_X_Tracto(objEntidad)
        'End Function
        'Public Function Listar_Vale_Combustibles(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
        '    Return objDataAccessLayer.Listar_Vale_Combustibles(objEntidad)
        'End Function
        Public Function Listar_Vale_Combustible_x_Tracto(ByVal objEntidad As ValeCombustible) As List(Of ValeCombustible)
            Return objDataAccessLayer.Listar_Vale_Combustible_x_Tracto(objEntidad)
        End Function
        Public Function Listar_Vale_Combustible_Pendientes_X_Tracto(ByVal objEntidad As ValeCombustible) As DataTable
            Return objDataAccessLayer.Listar_Vale_Combustible_Pendientes_X_Tracto(objEntidad)
        End Function

        'Public Function Registrar_Vale_Combustible(ByVal objEntidad As ValeCombustible) As ValeCombustible
        '    Return objDataAccessLayer.Registrar_Vale_Combustible(objEntidad)
        'End Function
        Public Function Registrar_Vale_CombustibleV2(ByVal objEntidad As ValeCombustible) As String
            Return objDataAccessLayer.Registrar_Vale_CombustibleV2(objEntidad)
        End Function

        Public Function Eliminar_Vale_Liquidacion_Combustible(ByVal objEntidad As ValeCombustible) As String
            Return objDataAccessLayer.Eliminar_Vale_Liquidacion_Combustible(objEntidad)
        End Function

        Public Function Listar_Item_Vale_Combustible(ByVal objEntidad As ValeCombustible) As DataTable
            Return objDataAccessLayer.Listar_Item_Vale_Combustible(objEntidad)
        End Function

    End Class
End Namespace


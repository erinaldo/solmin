Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos
  Public Class TipoCombustible_BLL
    Dim objDataAccessLayer As New TipoCombustible_DAL

    Public Function Listar_TipoCombustible() As List(Of TipoCombustible)
            'Try
            Return objDataAccessLayer.Listar_TipoCombustible()
            'Catch
            '          Return New List(Of TipoCombustible)
            '      End Try
        End Function

        Public Function Listar_TipoCombustible2() As DataTable
            'Try
            Return objDataAccessLayer.Listar_TipoCombustible2()
            'Catch
            '    Return New DataTable
            'End Try
        End Function


  End Class
End Namespace


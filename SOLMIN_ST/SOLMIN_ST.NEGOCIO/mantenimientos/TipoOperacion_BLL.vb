Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

    Public Class TipoOperacion_BLL

        Dim objDataAccessLayer As New TipoOperacion_DAL

        Public Function Listar_Tipos_Operacion() As DataTable
            Return objDataAccessLayer.Listar_Tipos_Operacion
        End Function


        Public Function InsertaSeguimientoOperacion(ByVal ht As Hashtable) As Integer
            Return objDataAccessLayer.InsertaSeguimientoOperacion(ht)
        End Function

    End Class

End Namespace
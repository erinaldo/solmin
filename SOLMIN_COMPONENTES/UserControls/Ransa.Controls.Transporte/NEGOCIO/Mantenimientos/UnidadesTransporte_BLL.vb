

Namespace mantenimientos

    Public Class UnidadesTransporte_BLL

        Dim objDataAccessLayer As New UnidadesTransporte_DAL

        Public Function Listar_Unidad_Transporte_DropDownList() As DataTable
            Return objDataAccessLayer.Listar_Unidad_Transporte_DropDownList()
        End Function
        Public Function Listar_Unidad_Transporte_Combo(ByVal strCompania As String) As DataTable
            Return objDataAccessLayer.Listar_Unidad_Transporte_Combo(strCompania)
        End Function

    End Class

End Namespace
Public Class UnidadMedida_BLL
    Private objDatos As New UnidadMedida_DAL
    Public Function Listar_Unidad_Medida_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Unidad_Medida_Combo(strCompania)
    End Function

End Class

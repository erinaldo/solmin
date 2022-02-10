Imports SOLMIN_ST.DATOS

Public Class CompaniaSeguro_BLL

    Private objDatos As New CompaniaSeguro_DAL

    Public Function Listar_Compania_Seguro_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Compania_Seguro_Combo(strCompania)
    End Function

End Class

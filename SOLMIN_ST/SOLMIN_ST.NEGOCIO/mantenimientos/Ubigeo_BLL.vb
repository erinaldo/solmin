Imports SOLMIN_ST.DATOS
Public Class Ubigeo_BLL
    Public Function Listar_Ubigeo() As DataTable
        Dim oUbigeo_DAL As New Ubigeo_DAL
        Return oUbigeo_DAL.Listar_Ubigeo()
    End Function
End Class

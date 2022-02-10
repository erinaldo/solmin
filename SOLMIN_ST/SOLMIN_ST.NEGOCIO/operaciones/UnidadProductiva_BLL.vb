Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Public Class UnidadProductiva_BLL
    Public Function Listar_Unidad_Productiva() As DataTable
        Dim dt As New DataTable
        Dim oDatos As New UnidadProductiva_DAL
        dt = oDatos.Listar_Unidad_Productiva()

        Return dt
    End Function
End Class

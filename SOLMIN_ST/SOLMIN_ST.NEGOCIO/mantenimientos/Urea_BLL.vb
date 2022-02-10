Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Public Class Urea_BLL
    Public Function Registrar_Urea(ByVal objEntidad As Urea) As String
        Dim oUrea_BLL As New Urea_DAL
        Return oUrea_BLL.Registrar_Urea(objEntidad)
    End Function
    Public Function Listar_Item_Urea(ByVal objEntidad As Urea) As DataTable
        Dim oUrea_BLL As New Urea_DAL
        Return oUrea_BLL.Listar_Item_Urea(objEntidad)
    End Function
    Public Function Listar_Urea_Asignado_x_Liquidacion(ByVal objEntidad As Urea) As DataTable
        Dim oUrea_BLL As New Urea_DAL
        Return oUrea_BLL.Listar_Urea_Asignado_x_Liquidacion(objEntidad)
    End Function

    Public Function Eliminar_Urea_Liquidacion_Asignado(ByVal objEntidad As Urea) As String
        Dim oUrea_BLL As New Urea_DAL
        Return oUrea_BLL.Eliminar_Urea_Liquidacion_Asignado(objEntidad)
    End Function

  
End Class

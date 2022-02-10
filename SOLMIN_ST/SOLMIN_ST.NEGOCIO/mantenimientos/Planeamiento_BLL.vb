Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports System.Data

Namespace mantenimientos

    Public Class Planeamiento_BLL

        Dim objDataAccessLayer As New Planeamiento_DAL

        Function Listado_Planeamiento(ByVal objEntidad As Planeamiento, ByVal Fecha_Inicio As String, ByVal Fecha_fin As String) As DataSet
            Return objDataAccessLayer.Listado_Planeamiento(objEntidad, Fecha_Inicio, Fecha_fin)
        End Function

        Function Listado_Planeamiento_Filtro(ByVal objEntidad As Planeamiento) As DataSet
            Return objDataAccessLayer.Listado_Planeamiento_Filtro(objEntidad)
        End Function

        Public Function Registrar_Planeamiento_Item(ByVal objEntidad As Planeamiento) As Integer
            Return objDataAccessLayer.Registrar_Planeamiento_Item(objEntidad)
        End Function
        Public Function Modificar_Planeamiento_Item(ByVal objEntidad As Planeamiento) As Integer
            Return objDataAccessLayer.Modificar_Planeamiento_Item(objEntidad)
        End Function
        Public Function Eliminar_Planeamiento_Item(ByVal objEntidad As Planeamiento) As Integer
            Return objDataAccessLayer.Eliminar_Planeamiento_Item(objEntidad)
        End Function

    End Class

End Namespace
Imports SOLMIN_ST.DATOS
Public Class AdjuntarImagen_BLL

    Public Sub Actualizar_Numero_Imagen_Liq_Combustible(ByVal objHash As Hashtable)
        Dim oAdjuntarImagen_DAL As New AdjuntarImagen_DAL
        oAdjuntarImagen_DAL.Actualizar_Numero_Imagen_Liq_Combustible(objHash)
    End Sub
    Public Function Eliminar_Correlativo_Imagen_Liq_Combustible(ByVal objHash As Hashtable) As Boolean
        Dim oAdjuntarImagen_DAL As New AdjuntarImagen_DAL
        Return oAdjuntarImagen_DAL.Eliminar_Correlativo_Imagen_Liq_Combustible(objHash)
    End Function


End Class

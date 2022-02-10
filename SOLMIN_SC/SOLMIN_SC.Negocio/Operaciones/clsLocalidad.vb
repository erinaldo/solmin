
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos


Public Class clsLocalidad

    Public Function Listar_Localidades() As List(Of beLocalidad)

        Dim odaLocalidad As New Datos.clsLocalidad
        Dim oListLocalidad As New List(Of beLocalidad)
        oListLocalidad = odaLocalidad.Listar_Localidades()
        Return oListLocalidad

    End Function

End Class

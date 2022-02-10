Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Public Class clsCalendario

    Public Function ActualizarCalendario(ByVal obeCalendario As beCalendario) As Int32
        Dim daClsCalendario As New SOLMIN_SC.Datos.clsCalendario
        Return daClsCalendario.ActualizarCalendario(obeCalendario)
    End Function
    Public Function ListarCalendarioMensual(ByVal obeCalendario As beCalendario) As DataTable
        Dim daClsCalendario As New SOLMIN_SC.Datos.clsCalendario
        Return daClsCalendario.ListarCalendarioMensual(obeCalendario)
    End Function

End Class

Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS
Public Class clsCalendario
    Public Function ActualizarCalendario(ByVal obeCalendario As beCalendario) As Int32
        Dim daClsCalendario As New SOLMIN_CTZ.DATOS.clsCalendario
        Return daClsCalendario.ActualizarCalendario(obeCalendario)
    End Function
    Public Function ListarCalendarioMensual(ByVal obeCalendario As beCalendario) As DataTable
        Dim daClsCalendario As New SOLMIN_CTZ.DATOS.clsCalendario
        Return daClsCalendario.ListarCalendarioMensual(obeCalendario)
    End Function
End Class

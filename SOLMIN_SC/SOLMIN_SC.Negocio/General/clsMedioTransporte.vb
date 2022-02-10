Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsMedioTransporte
    Public Function Lista_Medio_Transporte() As List(Of beMedioTransporte)
        Dim odalClsMedioTransporte As New Datos.clsMedioTransporte
        Return odalClsMedioTransporte.Lista_Medio_Transporte
    End Function
End Class

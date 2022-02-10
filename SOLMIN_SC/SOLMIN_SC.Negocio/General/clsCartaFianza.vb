Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsCartaFianza
    Private oCartaFianza As Datos.clsCartaFianza

    Sub New()
        oCartaFianza = New Datos.clsCartaFianza
    End Sub

    Public Function Listar_Datos_Carta_Fianza(ByVal pdblEmbarque As Double) As DataTable
        Return oCartaFianza.Listar_Datos_Carta_Fianza(pdblEmbarque)
    End Function

    Public Sub Mant_Carta_Fianza(ByVal obeCartaFianza As beCartaFianza)
        oCartaFianza.Mant_Carta_Fianza(obeCartaFianza)
    End Sub
End Class

Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS
Public Class clsAyudaGeneral
    Public Function ListaTablaAyudaGeneral(ByVal PSCODVAR As String, ByVal PSCCMPRN As String) As List(Of beAyudaGeneral)
        Dim daclsAyudaGeneral As New SOLMIN_CTZ.DATOS.clsAyudaGeneral
        Return daclsAyudaGeneral.ListaTablaAyudaGeneral(PSCODVAR, PSCCMPRN)
    End Function
End Class

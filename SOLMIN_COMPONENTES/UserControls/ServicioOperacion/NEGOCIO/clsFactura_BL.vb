Public Class clsFactura_BL
    Private oFacturaDato As New clsFactura_DAL
    Public Function Estimacion_Ingreso_Revertir(ByVal pobjFiltro As Filtro_BE) As DataTable
        Return oFacturaDato.Estimacion_Ingreso_Revertir(pobjFiltro)
    End Function
    Public Function Estimacion_Ingreso_RevertirMasivo(tipo As String, oServ As Servicio_BE) As DataTable
        Return oFacturaDato.Estimacion_Ingreso_RevertirMasivo(tipo, oServ)
    End Function
End Class

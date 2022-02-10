Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades


Public Class clsCtaCte_Venta
    Private oCtaCte_VentaDato As SOLMIN_CTZ.DATOS.clsCtaCta_Venta
    Private oDt As DataTable

    Sub New()
        oCtaCte_VentaDato = New SOLMIN_CTZ.DATOS.clsCtaCta_Venta
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function Lista_CtaCte_Venta(ByVal pobjCtaCte_Venta As CtaCte_Venta) As DataTable
        Return oCtaCte_VentaDato.Lista_CtaCte_Venta(pobjCtaCte_Venta)
    End Function
    

    Public Sub Buscar_CuentaCorriente(ByVal pobjCtaCte_Venta As CtaCte_Venta)
        oDt = oCtaCte_VentaDato.Lista_CtaCte_Venta(pobjCtaCte_Venta)
    End Sub

End Class
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades


Public Class clsCtaCte_Observacion
    Private oCtaCte_ObservacionDato As SOLMIN_CTZ.DATOS.clsCtaCte_Observacion
    Private oDt As DataTable

    Sub New()
        oCtaCte_ObservacionDato = New SOLMIN_CTZ.DATOS.clsCtaCte_Observacion
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function Lista_CtaCte_Observacion(ByVal pobjCtaCte_Observacion As CtaCte_Observacion) As DataTable
        Return oCtaCte_ObservacionDato.Lista_CtaCte_Observacion(pobjCtaCte_Observacion)
    End Function

    Public Sub Buscar_CuentaCorriente(ByVal pobjCtaCte_Observacion As CtaCte_Observacion)
        oDt = oCtaCte_ObservacionDato.Lista_CtaCte_Observacion(pobjCtaCte_Observacion)
    End Sub

End Class


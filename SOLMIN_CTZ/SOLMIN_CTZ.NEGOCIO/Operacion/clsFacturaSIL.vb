Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Public Class clsFacturaSIL
    Private oOIFacturaSIL As SOLMIN_CTZ.DATOS.clsFacturaSIl
    Private oDt As DataTable

    Sub New()
        oOIFacturaSIL = New SOLMIN_CTZ.DATOS.clsfacturaSIl
    End Sub

    ReadOnly Property Lista_Facturacion() As DataTable
        Get
            Return (Me.oDt)
        End Get
    End Property

    Public Function Lista_Facturacion_SIL(ByVal pobjFacturaSIL As FacturaSIL) As DataTable
        Return oOIFacturaSIL.Lista_Facturacion_SIL(pobjFacturaSIL)
    End Function
    Public Function Lista_Facturacion_SIL_Detalle(ByVal pobjFacturaSIL As FacturaSIL) As DataTable
        Return oOIFacturaSIL.Lista_Facturacion_SIL_Detalle(pobjFacturaSIL)
    End Function
End Class

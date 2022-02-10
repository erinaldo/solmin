Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades


Public Class clsSeguimientoDocumentos

    Private oSeguimientoDatos As SOLMIN_CTZ.DATOS.clsSeguimientoDocumentos

    Sub New()
        oSeguimientoDatos = New SOLMIN_CTZ.DATOS.clsSeguimientoDocumentos
    End Sub

    Public Function ListaSeguimientoDocumentos(ByVal PSCCMPN As String) As DataTable
        Dim oDt As DataTable = oSeguimientoDatos.ListaSeguimientoDocumentos(PSCCMPN)
        Return oDt
    End Function


    Public Function InsertaSeguimientoDocumentos(ByVal pobjSeguimiento As SeguimientoDocumentos) As Integer
        Return oSeguimientoDatos.InsertaSeguimientoDocumentos(pobjSeguimiento)
    End Function


    Public Function ListaSeguimientoPorDocumento(ByVal PNNDCCTC As Decimal) As DataTable
        Dim oDt As DataTable = oSeguimientoDatos.ListaSeguimientoPorDocumento(PNNDCCTC)
        Return oDt
    End Function


End Class

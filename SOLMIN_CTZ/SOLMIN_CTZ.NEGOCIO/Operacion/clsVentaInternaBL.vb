Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsVentaInternaBL 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Dim VentaInterna As New clsVentaInternaDA

    Public Sub Registrar_SAP(ByVal ccmpn As String, ByVal ctpodc As Double, ByVal ndcctc As Double, ByVal aprobador As String, ByVal culusa As String)
        VentaInterna.Registrar_SAP(ccmpn, ctpodc, ndcctc, aprobador, culusa)
    End Sub
End Class

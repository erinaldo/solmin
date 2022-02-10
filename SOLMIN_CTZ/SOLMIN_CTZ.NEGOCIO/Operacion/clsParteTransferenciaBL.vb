Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Imports System.Text

Public Class clsParteTransferenciaBL 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private ParteTransferencia As New clsParteTransferenciaDA

    Public Function ListarCabecera(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As DataTable
        Return ParteTransferencia.ListarCabecera(ccmpn, ctpodc, ndcctc)
    End Function

    Public Function ListarHitorial(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As DataTable
        Return ParteTransferencia.ListarHitorial(ccmpn, ctpodc, ndcctc)
    End Function

    Public Function ValidarAnulacionPT(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As String
        Dim mensaje As New StringBuilder
        For Each row As DataRow In ParteTransferencia.ValidarAnulacionPT(ccmpn, ctpodc, ndcctc).Rows
            If row("STATUS").ToString.Trim = "N" Then
                mensaje.AppendLine(row("OBSRESULT").ToString.Trim)
            End If
        Next row
        Return mensaje.ToString()
    End Function

    'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA (APROBADOR)
    Public Function AnularPT_SAP(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String, ByVal aprobador As String) As String
        Dim mensaje As New StringBuilder

        'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA (APROBADOR)
        For Each row As DataRow In ParteTransferencia.AnularPT_SAP(ccmpn, ctpodc, ndcctc, aprobador).Rows
            'If row("STATUS").ToString.Trim = "N" Then  'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA  
            mensaje.AppendLine(row("OBSRESULT").ToString.Trim)
            'End If
        Next row
        Return mensaje.ToString()
    End Function
End Class

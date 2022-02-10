Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsVentaInternaDA 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Public Sub Registrar_SAP(ByVal ccmpn As String, ByVal ctpodc As Double, ByVal ndcctc As Double, ByVal aprobador As String, ByVal culusa As String)
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN ", ccmpn)
        parameter.Add("PNCTPODC", ctpodc)
        parameter.Add("PNNDCCTC", ndcctc)
        parameter.Add("PSAPROBADOR", aprobador)
        parameter.Add("PSCULUSA", culusa)

        sqlManager.ExecuteNonQuery("SP_SOLMIN_CT_REGISTRAR_VENTA_INTERNA_SAP", parameter)

    End Sub

End Class

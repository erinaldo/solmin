Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsParteTransferenciaDA 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Public Function ListarCabecera(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As DataTable
        Dim output As DataTable
        'Try
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", ccmpn)
        parameter.Add("PNCTPODC", ctpodc)
        parameter.Add("PNNDCCTC", ndcctc)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_PARTE_TRANSFERENCIA_X_DOCUMENTO", parameter)
        'Catch ex As Exception
        '    output = Nothing
        'End Try

        Return output

    End Function

    Public Function ListarHitorial(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As DataTable
        Dim output As DataTable
        'Try
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", ccmpn)
        parameter.Add("PNCTPODC", ctpodc)
        parameter.Add("PNNDCCTC", ndcctc)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_PARTE_TRANSFERENCIA_X_DOCUMENTO_HISTORIAL", parameter)
        'Catch ex As Exception
        '    output = Nothing
        'End Try

        Return output

    End Function


    Public Function ValidarAnulacionPT(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As DataTable
        Dim output As DataTable
        'Try
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", ccmpn)
        parameter.Add("PNCTPODC", ctpodc)
        parameter.Add("PNNDCCTC", ndcctc)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_ANULACION_PT_DETALLE_SAP_X_DOCUMENTO", parameter)
        'Catch ex As Exception
        '    output = Nothing
        'End Try

        Return output
    End Function

    Public Function AnularPT_SAP(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String, ByVal aprobador As String) As DataTable
        Dim output As DataTable
        'Try
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", ccmpn)
        parameter.Add("PNCTPODC", ctpodc)
        parameter.Add("PNNDCCTC", ndcctc)
        parameter.Add("PSCULUSA", ConfigurationWizard.UserName)
        parameter.Add("PSAPROBADOR", aprobador)


        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_ANULAR_PARTE_TRANSFERENCIA_DETALLE_SAP_X_DOCUMENTO", parameter)
        'Catch ex As Exception
        '    output = Nothing
        'End Try

        Return output
    End Function
End Class

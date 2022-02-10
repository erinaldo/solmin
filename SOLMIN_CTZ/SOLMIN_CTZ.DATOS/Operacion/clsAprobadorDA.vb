Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsAprobadorDA 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Public Function ListarAprobador(ByVal codigoCompania As String) As DataTable
        Dim output As DataTable
        Try
            Dim sqlManager As New SqlManager
            Dim parameter As New Parameter

            parameter.Add("PSCCMPN", codigoCompania)

            output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_APROBADOR_PT", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output

    End Function

End Class

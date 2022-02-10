Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class FactorPagoAVC_DAL

    Private objSql As New SqlManager

    Public Function ListarFactorPagoAVC_Cliente(ByVal objEntidad As FactorPagoAVC) As List(Of FactorPagoAVC)
        Dim objParam As New Parameter
        Dim objLisFactorPagoAVC As New List(Of FactorPagoAVC)
        Dim oDt As DataTable
        Try
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_FACTOR_PAGO_AVC_CLIENTE", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New FactorPagoAVC
                objEntidad.CCLNT = objData.Item("CCLNT")
                objEntidad.CLIENTE = objData.Item("CLIENTE")
                objEntidad.TTPMDT = objData.Item("TTPMDT")
                objEntidad.CTPMDT = objData.Item("CTPMDT")
                objEntidad.SCATEG = objData.Item("SCATEG")
                objEntidad.IFCTPG = objData.Item("IFCTPG")
                objEntidad.TCATEG = objData.Item("TCATEG")
                objLisFactorPagoAVC.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return objLisFactorPagoAVC
    End Function

    Public Sub Mantenimiento_Factor_Pago_AVC(ByVal objEntidad As FactorPagoAVC)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNCTPMDT", objEntidad.CTPMDT)
            objParam.Add("PSSCATEG", objEntidad.SCATEG)
            objParam.Add("PNIFCTPG", objEntidad.IFCTPG)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MANTENIMIENTO_FACTOR_PAGO_AVC_CLIENTE", objParam)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class

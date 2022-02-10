Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class AsignacionRuta_DAL
    Private objSql As New SqlManager

    Public Function ListarAsignacion_Km_AVC_Ruta(ByVal objEntidad As AsignacionRuta) As List(Of AsignacionRuta)
        Dim objParam As New Parameter
        Dim objLisAsignacionRuta As New List(Of AsignacionRuta)
        Dim oDt As DataTable
        Try
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNCTPMDT", objEntidad.CTPMDT)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_ASIGNACION_KM_AVC_RUTA", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New AsignacionRuta
                objEntidad.CLCLOR = objData.Item("CLCLOR")
                objEntidad.ORIGEN = objData.Item("ORIGEN")
                objEntidad.CLCLDS = objData.Item("CLCLDS")
                objEntidad.DESTINO = objData.Item("DESTINO")
                objEntidad.CTPMDT = objData.Item("CTPMDT")
                objEntidad.TTPMDT = objData.Item("TTPMDT")
                objEntidad.QDSTKM = objData.Item("QDSTKM")
                objEntidad.FVGAVC = objData.Item("FVGAVC")
                objEntidad.IRTAVC = objData.Item("IRTAVC")
                objEntidad.IGSTVJ = objData.Item("IGSTVJ")
                objLisAsignacionRuta.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return objLisAsignacionRuta
    End Function

    Public Sub MantenimientoAsignacion_Km_AVC_Ruta(ByVal objEntidad As AsignacionRuta)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCTPMDT", objEntidad.CTPMDT)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNIRTAVC", objEntidad.IRTAVC)
            objParam.Add("PNFVGAVC", objEntidad.FVGAVC)
            objParam.Add("PNQDSTKM", objEntidad.QDSTKM)
            objParam.Add("PNIGSTVJ", objEntidad.IGSTVJ)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MANTENIMIENTO_ASIGNACION_KM_AVC_RUTA", objParam)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub


End Class

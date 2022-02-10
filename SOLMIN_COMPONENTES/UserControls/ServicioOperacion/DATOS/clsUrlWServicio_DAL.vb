Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsUrlWServicio_DAL

    Public Function Listar_Url_Servicio(Proceso As String, SubProceso As String, TipoProc As String, CodCliente As Decimal) As DataTable
        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objSql As New SqlManager
        objParam.Add("PSPROCWS", Proceso)     'COMPAÑIA
        objParam.Add("PSSPRCWS", SubProceso)   'NUMERO DE LIQUIDACION
        objParam.Add("PSTIPPROC", TipoProc)
        objParam.Add("PNCCLNT", CodCliente)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SD_CTRL_SERVICIO_LISTAR_CONFIGURACION_MAPEO_URL", objParam)

        Return dt
    End Function

End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports IBM.Data.DB2.iSeries
Imports RANSA.TYPEDEF
Public Class daConsultaEriMensual
    'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-INICIO
    Public Function ListarEriMensual(ByVal objMensualERI As beConsultaEriMensual) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("IN_CCMPN", objMensualERI.IN_CCMPN)
        objParam.Add("IN_CPLNDV", objMensualERI.IN_CPLNDV)
        objParam.Add("IN_CCLNT", objMensualERI.IN_CCLNT)
        objParam.Add("IN_ANIO", objMensualERI.IN_ANIO)
        objParam.Add("IN_MES", objMensualERI.IN_MES)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_CONSULTA_ERI_MENSUAL", objParam)
        Return oDs
    End Function
End Class
'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-FIN
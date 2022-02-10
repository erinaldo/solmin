Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef
Imports System.Configuration
Public Class daUsuario
    Public Function Validar_Usuario_Autorizado(ByVal objetoParametro As Hashtable) As beUsuario
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Dim oDt As DataTable
        Dim objEntidad As New beUsuario
        Try
            objParam.Add("PSMMCAPL", objetoParametro("MMCAPL"))
            objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
            objParam.Add("PSMMNPVB", objetoParametro("MMNPVB"))
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_VALIDAR_USUARIO_AUTORIZADO", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                objEntidad.STSOP1 = objDataRow("STSOP1").ToString.Trim()
                objEntidad.STSOP2 = objDataRow("STSOP2").ToString.Trim()
                objEntidad.STSADI = objDataRow("STSADI").ToString.Trim()
            Next
            Return objEntidad
        Catch ex As Exception
            Return objEntidad
        End Try
    End Function
    Public Function getAppSetting(ByVal Nombre As String) As String
        Dim retorno As String = ""
        Try
            retorno = ConfigurationManager.AppSettings(Nombre)
        Catch ex As Exception
            retorno = ""
        End Try
        Return retorno
    End Function
End Class

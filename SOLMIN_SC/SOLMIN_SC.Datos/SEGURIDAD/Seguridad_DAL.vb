Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data


Public Class Seguridad_DAL

    Dim objSql As New SqlManager

    Public Function IsValid(ByVal ConnStr) As Boolean
        Return objSql.Probar_Conexion(ConnStr)
    End Function

    Public Function Obtener_Datos_Usuarios(ByVal lstr_Usurario As String) As Data.DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PARAM_MMCUSR", lstr_Usurario)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SS_OBTENER_DATOS_USUARIO", lobjParams)
        Return dt
    End Function


End Class

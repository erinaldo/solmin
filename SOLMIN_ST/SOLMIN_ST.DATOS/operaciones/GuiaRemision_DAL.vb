Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario

Public Class GuiaRemision_DAL

    Dim objSql As New SqlManager

    'Public Function ObtieneDatosAdicionalesGuia(ByVal NGUIRM As String, ByVal CCLNT As String) As DataTable
    '    Dim dtb As DataTable
    '    Try
    '        Dim objParam As New Parameter
    '        objParam.Add("PNNGUIRM", NGUIRM)
    '        objParam.Add("PNCCLNT", CCLNT)
    '        dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_DATOS_ADICIONALES_GUIA_REMISION", objParam)
    '    Catch ex As Exception
    '        dtb = New DataTable
    '    End Try
    '    Return dtb
    'End Function

    '

End Class

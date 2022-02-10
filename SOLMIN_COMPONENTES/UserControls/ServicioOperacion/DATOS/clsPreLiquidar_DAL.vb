Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsPreLiquidar_DAL

    Private objSql As New SqlManager
    Public Function Registrar_PreLiquidacion(ByVal objEntidad As PreLiquidar_BE, ByVal NSECFC As String, ByRef NPRLCF As Decimal) As String

        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim msg As String = ""
       
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PSNSECFC", NSECFC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PSTPDCPE", objEntidad.TPDCPE)
        objParam.Add("PSDCCLNT", objEntidad.DCCLNT)
        objParam.Add("PSSBCLNT", objEntidad.SBCLNT)

       
        dt = objSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_PRE_LIQUIDACION_ADMIN", objParam)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim
        If msg.Length = 0 And dt.Rows.Count > 0 Then
            NPRLCF = dt.Rows(0)("NPRLCF")
        End If
 
        Return msg
    End Function
End Class

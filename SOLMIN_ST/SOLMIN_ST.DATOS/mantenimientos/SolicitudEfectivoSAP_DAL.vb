Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES

Public Class SolicitudEfectivoSAP_DAL
    Private objSql As New SqlManager

    Public Function Guardar_Solicitud_Efectivo_SAP(ByVal objEntidad As SolicitudEfectivoSAP) As SolicitudEfectivoSAP
        'Try
        Dim objParam As New Parameter
        Dim oDt As DataTable

        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSICTMYS", objEntidad.ICTMYS)
        objParam.Add("PNNMSLPE", objEntidad.NMSLPE)
        objParam.Add("PNFCSLPE", objEntidad.FCSLPE)
        objParam.Add("PNCMSLPE", objEntidad.CMSLPE)
        objParam.Add("PNISLPES", objEntidad.ISLPES)
        objParam.Add("PNFVENDP", objEntidad.FVENDP)
        objParam.Add("PSTADSAP", objEntidad.TADSAP)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PNHRACRT", objEntidad.HRACRT)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PSTCBDCS", objEntidad.TCBDCS)
        objParam.Add("PSCMTCDS", objEntidad.CMTCDS)
        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GUARDAR_SOLICITUD_EFECTIVO_SAP", objParam)
        For Each objDataRow As DataRow In oDt.Rows
            objEntidad.NRFSAP = objDataRow.Item("NRFSAP")
            objEntidad.NORINS = objDataRow.Item("NORINS")
            objEntidad.TSTERS = objDataRow.Item("TSTERS")
        Next
        'Catch ex As Exception
        '    objEntidad.NRFSAP = 0
        '    objEntidad.NORINS = 0
        'End Try
        Return objEntidad
    End Function

End Class

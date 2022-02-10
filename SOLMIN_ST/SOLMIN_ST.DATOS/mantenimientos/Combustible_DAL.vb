'CSR-HUNDRED-feature/151116_Combustibles-INICIO
Imports ransa.Utilitario

Public Class Combustible_DAL
    Private objSql As New Db2Manager.RansaData.iSeries.DataObjects.SqlManager

    Public Function ListaReporteCombustible(ByVal objParametro As ENTIDADES.Combustible_BE) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Db2Manager.RansaData.iSeries.DataObjects.Parameter

        objParam.Add("PSCCMPN", objParametro.CCMPN)
        objParam.Add("PSCDVSN", objParametro.CDVSN)
        'objParam.Add("PNCPLNDV", objParametro.CPLNDV)
        'objParam.Add("PNCCLNT", objParametro.CCLNT)
        'objParam.Add("PSCRGVTA", objParametro.CRGVTA)
        'objParam.Add("PNCMEDTR", objParametro.CMEDTR)
        objParam.Add("PNFINIOP", objParametro.FINIOP)
        objParam.Add("PNFFINOP", objParametro.FFINOP)
        objParam.Add("PSNPLCUN", objParametro.NPLCUN)
        objParam.Add("PNNOPRCN", objParametro.NOPRCN)
        objParam.Add("PNNGUIRM", objParametro.NGUIRM)
        'objParam.Add("PNCBRCNT", objParametro.CBRCNT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro.CCMPN)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_REPORTE_COMBUSTIBLE", objParam)

        For Each Item As DataRow In objDataTable.Rows
            Item("FINCOP") = HelpClass.FechaNum_a_Fecha(Item("FINCOP"))
            Item("FATNSR") = HelpClass.FechaNum_a_Fecha(Item("FATNSR"))
            Item("FIVIAJE") = HelpClass.FechaNum_a_Fecha(Item("FIVIAJE"))
            Item("FLQDCN") = HelpClass.FechaNum_a_Fecha(Item("FLQDCN"))
            Item("FCRCMB") = HelpClass.FechaNum_a_Fecha(Item("FCRCMB"))
            Item("FSLCMB") = HelpClass.FechaNum_a_Fecha(Item("FSLCMB"))
        Next

        Return objDataTable
    End Function

    Public Function ListaReporteCombustible_V2(ByVal objParametro As ENTIDADES.Combustible_BE) As DataSet
        Dim ds As New DataSet
        Dim objParam As New Db2Manager.RansaData.iSeries.DataObjects.Parameter

        objParam.Add("PSCCMPN", objParametro.CCMPN)
        objParam.Add("PSCDVSN", objParametro.CDVSN)
        objParam.Add("PNNLQCMB", objParametro.NLQCMB)
        objParam.Add("PNFINIOP", objParametro.FINIOP)
        objParam.Add("PNFFINOP", objParametro.FFINOP)
        objParam.Add("PSNPLCUN", objParametro.NPLCUN)
        'objParam.Add("PNNOPRCN", objParametro.NOPRCN)
        'objParam.Add("PNNGUIRM", objParametro.NGUIRM)
        'objParam.Add("PNCBRCNT", objParametro.CBRCNT)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro.CCMPN)
        ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_REPORTE_COMBUSTIBLE_NEW", objParam)

        For Each Item As DataRow In ds.Tables(0).Rows
            Item("FLQDCN") = HelpClass.FechaNum_a_Fecha(Item("FLQDCN"))
        Next

        For Each Item As DataRow In ds.Tables(1).Rows
            Item("Fecha_Liq") = HelpClass.FechaNum_a_Fecha(Item("Fecha_Liq"))
            Item("Fecha_Carga") = HelpClass.FechaNum_a_Fecha(Item("Fecha_Carga"))
            Item("Fecha_Doc") = HelpClass.FechaNum_a_Fecha(Item("Fecha_Doc"))
        Next

        For Each Item As DataRow In ds.Tables(2).Rows
            Item("Fecha_Op") = HelpClass.FechaNum_a_Fecha(Item("Fecha_Op"))
            Item("Fecha_Servicio") = HelpClass.FechaNum_a_Fecha(Item("Fecha_Servicio"))
        Next

        Return ds
    End Function


End Class
'CSR-HUNDRED-feature/151116_Combustibles-FIN

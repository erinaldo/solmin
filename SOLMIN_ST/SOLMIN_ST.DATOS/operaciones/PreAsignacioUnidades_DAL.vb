Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario

Public Class PreAsignacioUnidades_DAL

    Dim lstPreAsignacionUnidades_BE As List(Of PreAsignacionUnidades_BE)
    Dim oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE

    Function Registrar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNPRASG", oPreAsignacionUnidades_BE.PNNPRASG)
        lobjParams.Add("PNFPRASG", HelpClass.CDate_a_Numero8Digitos(oPreAsignacionUnidades_BE.PNFPRASG))
        lobjParams.Add("PSCCMPN", oPreAsignacionUnidades_BE.PSCCMPN)
        lobjParams.Add("PSCDVSN", oPreAsignacionUnidades_BE.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oPreAsignacionUnidades_BE.PNCPLNDV)
        lobjParams.Add("PNCCLNT", oPreAsignacionUnidades_BE.PNCCLNT)
        lobjParams.Add("PNCLCLOR", oPreAsignacionUnidades_BE.PNCLCLOR)
        lobjParams.Add("PNCLCLDS", oPreAsignacionUnidades_BE.PNCLCLDS)
        lobjParams.Add("PSTDRORI", oPreAsignacionUnidades_BE.PSTDRORI)
        lobjParams.Add("PSTDRENT", oPreAsignacionUnidades_BE.PSTDRENT)
        lobjParams.Add("PNNRUCTR", oPreAsignacionUnidades_BE.PNNRUCTR)
        lobjParams.Add("PSNPLCUN", oPreAsignacionUnidades_BE.PSNPLCUN)
        lobjParams.Add("PSNPLCAC", oPreAsignacionUnidades_BE.PSNPLCAC)
        lobjParams.Add("PSCBRCNT", oPreAsignacionUnidades_BE.PSCBRCNT)
        lobjParams.Add("PSCBRCN2", oPreAsignacionUnidades_BE.PSCBRCN2)
        lobjParams.Add("PNNGUITR", oPreAsignacionUnidades_BE.PNNGUITR)
        If oPreAsignacionUnidades_BE.PNNGUITR = 0 Then
            lobjParams.Add("PNFGUITR", 0)
        Else
            lobjParams.Add("PNFGUITR", HelpClass.CDate_a_Numero8Digitos(oPreAsignacionUnidades_BE.PSFGUITR))
        End If
        lobjParams.Add("PNNOPRCN", oPreAsignacionUnidades_BE.PNNOPRCN)
        lobjParams.Add("PNCMEDTR", oPreAsignacionUnidades_BE.PNCMEDTR)
        lobjParams.Add("PSTOBS", oPreAsignacionUnidades_BE.PSTOBS)

        lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
        lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
        lobjParams.Add("PSNTRMCR", Environment.MachineName) 'usuario creador
        lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
        lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
        lobjParams.Add("PSNTRMNL", Environment.MachineName) 'usuario (actualización)
        'lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oPreAsignacionUnidades_BE.PSCCMPN)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERT_PRE_ASIGNACION_UNIDADES", lobjParams)
        Return 1
    End Function


    Function Modificar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNPRASG", oPreAsignacionUnidades_BE.PNNPRASG)
        lobjParams.Add("PSCCMPN", oPreAsignacionUnidades_BE.PSCCMPN)
        lobjParams.Add("PSCDVSN", oPreAsignacionUnidades_BE.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oPreAsignacionUnidades_BE.PNCPLNDV)
        lobjParams.Add("PNCCLNT", oPreAsignacionUnidades_BE.PNCCLNT)
        lobjParams.Add("PNCLCLOR", oPreAsignacionUnidades_BE.PNCLCLOR)
        lobjParams.Add("PNCLCLDS", oPreAsignacionUnidades_BE.PNCLCLDS)
        lobjParams.Add("PSTDRORI", oPreAsignacionUnidades_BE.PSTDRORI)
        lobjParams.Add("PSTDRENT", oPreAsignacionUnidades_BE.PSTDRENT)
        lobjParams.Add("PNNRUCTR", oPreAsignacionUnidades_BE.PNNRUCTR)
        lobjParams.Add("PSNPLCUN", oPreAsignacionUnidades_BE.PSNPLCUN)
        lobjParams.Add("PSNPLCAC", oPreAsignacionUnidades_BE.PSNPLCAC)
        lobjParams.Add("PSCBRCNT", oPreAsignacionUnidades_BE.PSCBRCNT)
        lobjParams.Add("PSCBRCN2", oPreAsignacionUnidades_BE.PSCBRCN2)
        lobjParams.Add("PNNGUITR", oPreAsignacionUnidades_BE.PNNGUITR)
        If oPreAsignacionUnidades_BE.PNNGUITR = 0 Then
            lobjParams.Add("PNFGUITR", 0)
        Else
            lobjParams.Add("PNFGUITR", HelpClass.CDate_a_Numero8Digitos(oPreAsignacionUnidades_BE.PSFGUITR))
        End If
        lobjParams.Add("PNNOPRCN", oPreAsignacionUnidades_BE.PNNOPRCN)
        lobjParams.Add("PNCMEDTR", oPreAsignacionUnidades_BE.PNCMEDTR)
        lobjParams.Add("PSTOBS", oPreAsignacionUnidades_BE.PSTOBS)

        lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
        lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
        lobjParams.Add("PSNTRMNL", Environment.MachineName) 'usuario (actualización)
        'lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oPreAsignacionUnidades_BE.PSCCMPN)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_UPDATE_PRE_ASIGNACION_UNIDADES", lobjParams)
        Return 1
    End Function

    Function Asignar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNPRASG", oPreAsignacionUnidades_BE.PNNPRASG)
        lobjParams.Add("PNNOPRCN", oPreAsignacionUnidades_BE.PNNOPRCN)

        lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
        lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
        lobjParams.Add("PSNTRMNL", Environment.MachineName) 'usuario (actualización)
        'lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oPreAsignacionUnidades_BE.PSCCMPN)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_ASIGNACION_UNIDADES", lobjParams)
        Return 1
    End Function

    Function Eliminar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNPRASG", oPreAsignacionUnidades_BE.PNNPRASG)
        lobjParams.Add("PSCCMPN", oPreAsignacionUnidades_BE.PSCCMPN)
        lobjParams.Add("PSCDVSN", oPreAsignacionUnidades_BE.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oPreAsignacionUnidades_BE.PNCPLNDV)
        lobjParams.Add("PNCCLNT", oPreAsignacionUnidades_BE.PNCCLNT)

        lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
        lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
        lobjParams.Add("PSNTRMNL", Environment.MachineName) 'usuario (actualización)
        'lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oPreAsignacionUnidades_BE.PSCCMPN)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_DELETE_PRE_ASIGNACION_UNIDADES", lobjParams)
        Return 1
    End Function


    Function Buscar_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE, ByRef NumPaginas As Int64) As List(Of PreAsignacionUnidades_BE)

        lstPreAsignacionUnidades_BE = New List(Of PreAsignacionUnidades_BE)


        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNPRASG", oPreAsignacionUnidades_BE.PNNPRASG)
        lobjParams.Add("PSCCMPN", oPreAsignacionUnidades_BE.PSCCMPN)
        lobjParams.Add("PSCDVSN", oPreAsignacionUnidades_BE.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oPreAsignacionUnidades_BE.PNCPLNDV)
        lobjParams.Add("PNCCLNT", oPreAsignacionUnidades_BE.PNCCLNT)

        lobjParams.Add("PNFPRASG_INI", oPreAsignacionUnidades_BE.PNFPRASG_INI)
        lobjParams.Add("PNFPRASG_FIN", oPreAsignacionUnidades_BE.PNFPRASG_FIN)

        lobjParams.Add("PSSESASG", oPreAsignacionUnidades_BE.SESASG)

        lobjParams.Add("PAGESIZE", oPreAsignacionUnidades_BE.PageSize)
        lobjParams.Add("PAGENUMBER", oPreAsignacionUnidades_BE.PageNumber)
        lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oPreAsignacionUnidades_BE.PSCCMPN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PRE_ASIGNACION_UNIDADES", lobjParams)
        NumPaginas = lobjSql.ParameterCollection("PAGECOUNT")
        For Each dr As DataRow In dt.Rows
            oPreAsignacionUnidades_BE = New PreAsignacionUnidades_BE

            oPreAsignacionUnidades_BE.PNNPRASG = dr("NPRASG")
            oPreAsignacionUnidades_BE.PNFPRASG = HelpClass.CNumero8Digitos_a_Fecha(dr("FPRASG"))
            oPreAsignacionUnidades_BE.PSCCMPN = dr("CCMPN")
            oPreAsignacionUnidades_BE.PSCDVSN = dr("CDVSN")
            oPreAsignacionUnidades_BE.PNCPLNDV = dr("CPLNDV")
            oPreAsignacionUnidades_BE.PNCCLNT = dr("CCLNT")
            oPreAsignacionUnidades_BE.PNCLCLOR = dr("CLCLOR")
            oPreAsignacionUnidades_BE.PNCLCLDS = dr("CLCLDS")
            oPreAsignacionUnidades_BE.PSTDRORI = dr("TDRORI")
            oPreAsignacionUnidades_BE.PSTDRENT = dr("TDRENT")
            oPreAsignacionUnidades_BE.PNNRUCTR = dr("NRUCTR")
            oPreAsignacionUnidades_BE.PSNPLCUN = dr("NPLCUN")
            oPreAsignacionUnidades_BE.PSNPLCAC = dr("NPLCAC")
            oPreAsignacionUnidades_BE.PSCBRCNT = dr("CBRCNT")
            oPreAsignacionUnidades_BE.PSCBRCN2 = dr("CBRCN2")
            oPreAsignacionUnidades_BE.PNNGUITR = dr("NGUITR")
            oPreAsignacionUnidades_BE.PSFGUITR = IIf(dr("FGUITR") = "0", "", HelpClass.CNumero8Digitos_a_Fecha(dr("FGUITR")))
            oPreAsignacionUnidades_BE.PNNOPRCN = dr("NOPRCN")
            oPreAsignacionUnidades_BE.PNCMEDTR = dr("CMEDTR")
            oPreAsignacionUnidades_BE.PSTOBS = HelpClass.ToStringCvr(dr("TOBS"))
            oPreAsignacionUnidades_BE.TCMPCL = HelpClass.ToStringCvr(dr("TCMPCL"))
            oPreAsignacionUnidades_BE.TCMTRT = HelpClass.ToStringCvr(dr("TCMTRT"))
            oPreAsignacionUnidades_BE.TNMCMC = HelpClass.ToStringCvr(dr("TNMCMC"))
            oPreAsignacionUnidades_BE.SESASG = dr("SESASG")
            lstPreAsignacionUnidades_BE.Add(oPreAsignacionUnidades_BE)
        Next
        Return lstPreAsignacionUnidades_BE

    End Function


    Function Ver_PreAsignacionUnidades(ByVal oPreAsignacionUnidades_BE As PreAsignacionUnidades_BE) As List(Of PreAsignacionUnidades_BE)

        lstPreAsignacionUnidades_BE = New List(Of PreAsignacionUnidades_BE)


        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        'lobjParams.Add("PNNPRASG", oPreAsignacionUnidades_BE.PNNPRASG)
        lobjParams.Add("PSCCMPN", oPreAsignacionUnidades_BE.PSCCMPN)
        lobjParams.Add("PSCDVSN", oPreAsignacionUnidades_BE.PSCDVSN)
        lobjParams.Add("PNCPLNDV", oPreAsignacionUnidades_BE.PNCPLNDV)
        lobjParams.Add("PNCCLNT", oPreAsignacionUnidades_BE.PNCCLNT)

        lobjParams.Add("PNCMEDTR", oPreAsignacionUnidades_BE.PNCMEDTR)
        lobjParams.Add("PNCLCLOR", oPreAsignacionUnidades_BE.PNCLCLOR)
        lobjParams.Add("PNCLCLDS", oPreAsignacionUnidades_BE.PNCLCLDS)

        'lobjParams.Add("PAGESIZE", oPreAsignacionUnidades_BE.PageSize)
        'lobjParams.Add("PAGENUMBER", oPreAsignacionUnidades_BE.PageNumber)
        'lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oPreAsignacionUnidades_BE.PSCCMPN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_VER_PRE_ASIGNACION_UNIDADES", lobjParams)

        For Each dr As DataRow In dt.Rows
            oPreAsignacionUnidades_BE = New PreAsignacionUnidades_BE

            oPreAsignacionUnidades_BE.PNNPRASG = dr("NPRASG")
            oPreAsignacionUnidades_BE.PNFPRASG = HelpClass.CNumero8Digitos_a_Fecha(dr("FPRASG"))
            oPreAsignacionUnidades_BE.PSCCMPN = dr("CCMPN")
            oPreAsignacionUnidades_BE.PSCDVSN = dr("CDVSN")
            oPreAsignacionUnidades_BE.PNCPLNDV = dr("CPLNDV")
            oPreAsignacionUnidades_BE.PNCCLNT = dr("CCLNT")
            oPreAsignacionUnidades_BE.PNCLCLOR = dr("CLCLOR")
            oPreAsignacionUnidades_BE.PNCLCLDS = dr("CLCLDS")
            oPreAsignacionUnidades_BE.PSTDRORI = dr("TDRORI")
            oPreAsignacionUnidades_BE.PSTDRENT = dr("TDRENT")
            oPreAsignacionUnidades_BE.PNNRUCTR = dr("NRUCTR")
            oPreAsignacionUnidades_BE.PSNPLCUN = dr("NPLCUN")
            oPreAsignacionUnidades_BE.PSNPLCAC = dr("NPLCAC")
            oPreAsignacionUnidades_BE.PSCBRCNT = dr("CBRCNT")
            oPreAsignacionUnidades_BE.PSCBRCN2 = dr("CBRCN2")
            oPreAsignacionUnidades_BE.PNNGUITR = dr("NGUITR")
            oPreAsignacionUnidades_BE.PSFGUITR = IIf(dr("FGUITR") = "0", "", HelpClass.CNumero8Digitos_a_Fecha(dr("FGUITR")))
            oPreAsignacionUnidades_BE.PNNOPRCN = dr("NOPRCN")
            oPreAsignacionUnidades_BE.PNCMEDTR = dr("CMEDTR")
            oPreAsignacionUnidades_BE.PSTOBS = HelpClass.ToStringCvr(dr("TOBS"))
            oPreAsignacionUnidades_BE.TCMPCL = HelpClass.ToStringCvr(dr("TCMPCL"))
            oPreAsignacionUnidades_BE.TCMTRT = HelpClass.ToStringCvr(dr("TCMTRT"))
            oPreAsignacionUnidades_BE.TNMCMC = HelpClass.ToStringCvr(dr("TNMCMC"))
            oPreAsignacionUnidades_BE.TNMCMC2 = HelpClass.ToStringCvr(dr("TNMCMC2"))

            oPreAsignacionUnidades_BE.SESASG = dr("SESASG")
            lstPreAsignacionUnidades_BE.Add(oPreAsignacionUnidades_BE)
        Next
        Return lstPreAsignacionUnidades_BE

    End Function

    Function Exportar_PreAsignacionUnidades() As List(Of PreAsignacionUnidades_BE)

        lstPreAsignacionUnidades_BE = New List(Of PreAsignacionUnidades_BE)

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        'lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oPreAsignacionUnidades_BE.PSCCMPN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PRE_ASIGNACION_UNIDADES_EXP", lobjParams)

        For Each dr As DataRow In dt.Rows

            oPreAsignacionUnidades_BE = New PreAsignacionUnidades_BE
            oPreAsignacionUnidades_BE.PNNPRASG = dr("NPRASG")
            oPreAsignacionUnidades_BE.PNFPRASG = HelpClass.CNumero8Digitos_a_Fecha(dr("FPRASG"))
            oPreAsignacionUnidades_BE.PSCCMPN = dr("CCMPN")
            oPreAsignacionUnidades_BE.PSCDVSN = dr("CDVSN")
            oPreAsignacionUnidades_BE.PNCPLNDV = dr("CPLNDV")
            oPreAsignacionUnidades_BE.PNCCLNT = dr("CCLNT")
            oPreAsignacionUnidades_BE.PNCLCLOR = dr("CLCLOR")
            oPreAsignacionUnidades_BE.PNCLCLDS = dr("CLCLDS")
            oPreAsignacionUnidades_BE.PSTDRORI = dr("TDRORI")
            oPreAsignacionUnidades_BE.PSTDRENT = dr("TDRENT")
            oPreAsignacionUnidades_BE.PNNRUCTR = dr("NRUCTR")
            oPreAsignacionUnidades_BE.PSNPLCUN = dr("NPLCUN")
            oPreAsignacionUnidades_BE.PSNPLCAC = dr("NPLCAC")
            oPreAsignacionUnidades_BE.PSCBRCNT = dr("CBRCNT")
            oPreAsignacionUnidades_BE.PSCBRCN2 = dr("CBRCN2")
            oPreAsignacionUnidades_BE.PNNGUITR = dr("NGUITR")
            oPreAsignacionUnidades_BE.PSFGUITR = IIf(dr("FGUITR") = "0", "", HelpClass.CNumero8Digitos_a_Fecha(dr("FGUITR")))
            oPreAsignacionUnidades_BE.PNNOPRCN = dr("NOPRCN")
            oPreAsignacionUnidades_BE.PNCMEDTR = dr("CMEDTR")
            oPreAsignacionUnidades_BE.PSTOBS = HelpClass.ToStringCvr(dr("TOBS"))
            oPreAsignacionUnidades_BE.TCMPCL = HelpClass.ToStringCvr(dr("TCMPCL"))
            oPreAsignacionUnidades_BE.TCMTRT = HelpClass.ToStringCvr(dr("TCMTRT"))
            oPreAsignacionUnidades_BE.TNMCMC = HelpClass.ToStringCvr(dr("TNMCMC"))
            oPreAsignacionUnidades_BE.SESASG = dr("SESASG")
            lstPreAsignacionUnidades_BE.Add(oPreAsignacionUnidades_BE)
        Next

        Return lstPreAsignacionUnidades_BE
    End Function

End Class
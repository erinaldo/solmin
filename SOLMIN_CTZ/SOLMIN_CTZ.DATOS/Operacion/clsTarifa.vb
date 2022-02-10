
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class clsTarifa
    Public Function Lista_Tarifa_X_Contrato(ByVal pobjTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNCPLNDV", pobjTarifa.CPLNDV)
        lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
        lobjParams.Add("PNNRRUBR", pobjTarifa.NRRUBR)
        lobjParams.Add("PSCDVSN", pobjTarifa.CDVSN)
        lobjParams.Add("PSSESTRG", pobjTarifa.SESTRG)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PNNORSRT", pobjTarifa.NORSRT)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_X_CONTRATO_RZSC03", lobjParams)

        For Each Item As DataRow In dt.Rows
            Item("FCHAPR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(Item("FCHAPR"))
        Next

        'dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_X_CONTRATO", lobjParams)
        Return dt

    End Function

    Public Sub Eliminar_Tarifa(ByVal pobjTarifa As Tarifa)

        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLCT_ELIMINAR_TARIFA", lobjParams)
       
    End Sub

    Public Sub Crear_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)

        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
        lobjParams.Add("PNCMNDA1", pobjTarifa.CMNDA1)
        lobjParams.Add("PSDESRNG", pobjRango.DESRNG)
        lobjParams.Add("PSTOBS", pobjTarifa.TOBS)
        lobjParams.Add("PNIVLSRV", pobjTarifa.IVLSRV)
        lobjParams.Add("PNCPLNDV", pobjTarifa.CPLNDV)
        lobjParams.Add("PSCUNDMD", pobjRango.CUNDMD)
        lobjParams.Add("PNVALMAX", pobjRango.VALMAX)
        lobjParams.Add("PNVALMIN", pobjRango.VALMIN)
        lobjParams.Add("PNVALCTE", pobjRango.VALCTE)
        lobjParams.Add("PSSTPTRA", pobjRango.STPTRA)
        lobjParams.Add("PSDESTAR", pobjTarifa.DESTAR)

        lobjParams.Add("CCNTCS", pobjTarifa.CCNTCS)  'Comentar Temporalmente

        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        oSqlMan.ExecuteNonQuery("SP_SOLCT_CREAR_TARIFA", lobjParams)
       
    End Sub

    Public Function Crear_Tarifa_RZSC03(ByVal objEntidad As Tarifa) As String
        Dim lstr_resultado As String = ""

        Dim objSql As New SqlManager()
        Dim objParam As New Parameter
        objParam.Add("PNNRTFSV", objEntidad.NRTFSV, ParameterDirection.Output)
        objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
        objParam.Add("PSDESTAR", objEntidad.DESTAR)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNNRRUBR", objEntidad.NRRUBR)
        objParam.Add("PNNRSRRB", objEntidad.NRSRRB)
        objParam.Add("PNNRRELF", objEntidad.NRRELF)
        objParam.Add("PNCDTREF", objEntidad.CDTREF) 'cod. tarifa ref
        objParam.Add("PNDIACOR", objEntidad.DIACOR)
        objParam.Add("PNCCNTCS", objEntidad.CCNTCS)

        'RCS-HUNDRED-INICIO
        objParam.Add("PNCENCOS", objEntidad.CENCOS)
        objParam.Add("PNCENCO2", objEntidad.CENCO2)
        objParam.Add("PNISRVTI", objEntidad.ISRVTI)
        'RCS-HUNDRED-FIN

        objParam.Add("PSSTPTRA", objEntidad.STPTRA)
        objParam.Add("PSCUNDMD", objEntidad.CUNDMD)
        objParam.Add("PNVALCTE", objEntidad.VALCTE)
        objParam.Add("PNCMNDA1", objEntidad.CMNDA1)
        objParam.Add("PNIVLSRV", objEntidad.IVLSRV)
        objParam.Add("PNPRLBPG", objEntidad.PRLBPG)
        objParam.Add("PSFAPLBR", objEntidad.FAPLBR)
        objParam.Add("PNNDIAPL", objEntidad.NDIAPL)
        objParam.Add("PSTTPOMR", objEntidad.TTPOMR)
        objParam.Add("PSCTPALM", objEntidad.CTPALM)
        objParam.Add("PSTOBS", objEntidad.TOBS)

        '<[AHM]>
        objParam.Add("PSCDSDSP", objEntidad.CDSDSP)
        objParam.Add("PSCDSRSP", objEntidad.CDSRSP)
        objParam.Add("PSCDTSSP", objEntidad.CDTSSP)
        objParam.Add("PSCDTASP", objEntidad.CDTASP)
        objParam.Add("PSCDSPSP", objEntidad.CDSPSP)
        objParam.Add("PSCDUPSP", objEntidad.CDUPSP)
        objParam.Add("PSCDSCSP", objEntidad.CDSCSP)
        '</[AHM]>

        objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
        objParam.Add("PSSESTRG", "P")

        objSql.ExecuteNonQuery("SP_SOLCT_REGISTRA_TARIFA_RZSC03", objParam)
        lstr_resultado = objSql.ParameterCollection("PNNRTFSV")
       
        Return lstr_resultado
    End Function

    Public Sub Modificar_Tarifa_RZSC03(ByVal objEntidad As Tarifa)

        Dim objSql As New SqlManager()
        Dim objParam As New Parameter
        objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
        objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
        objParam.Add("PSDESTAR", objEntidad.DESTAR)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNNRRUBR", objEntidad.NRRUBR)
        objParam.Add("PNNRSRRB", objEntidad.NRSRRB)
        objParam.Add("PNNRRELF", objEntidad.NRRELF)
        objParam.Add("PNCDTREF", objEntidad.CDTREF) 'cod. tarifa ref
        objParam.Add("PNDIACOR", objEntidad.DIACOR) ' 
        objParam.Add("PNCCNTCS", objEntidad.CCNTCS)

        'RCS-HUNDRED-INICIO
        objParam.Add("PNCENCOS", objEntidad.CENCOS)
        objParam.Add("PNCENCO2", objEntidad.CENCO2)
        objParam.Add("PNISRVTI", objEntidad.ISRVTI)
        'RCS-HUNDRED-FIN

        objParam.Add("PSSTPTRA", objEntidad.STPTRA)
        objParam.Add("PSCUNDMD", objEntidad.CUNDMD)
        objParam.Add("PNVALCTE", objEntidad.VALCTE)
        objParam.Add("PNCMNDA1", objEntidad.CMNDA1)
        objParam.Add("PNIVLSRV", objEntidad.IVLSRV)
        objParam.Add("PNPRLBPG", objEntidad.PRLBPG)
        objParam.Add("PSFAPLBR", objEntidad.FAPLBR)
        objParam.Add("PNNDIAPL", objEntidad.NDIAPL)
        objParam.Add("PSTOBS", objEntidad.TOBS)

        '<[AHM]>
        objParam.Add("CDSDSP", objEntidad.CDSDSP)
        objParam.Add("CDSRSP", objEntidad.CDSRSP)
        objParam.Add("CDTSSP", objEntidad.CDTSSP)
        objParam.Add("CDTASP", objEntidad.CDTASP)
        objParam.Add("CDSPSP", objEntidad.CDSPSP)
        objParam.Add("CDUPSP", objEntidad.CDUPSP)
        objParam.Add("CDSCSP", objEntidad.CDSCSP)
        '</[AHM]>

        objParam.Add("PSTTPOMR", objEntidad.TTPOMR)
        objParam.Add("PSCTPALM", objEntidad.CTPALM)
        objParam.Add("PSCULUSA", ConfigurationWizard.UserName)

        objSql.ExecuteNonQuery("SP_SOLCT_MODIFICAR_TARIFA_RZSC03", objParam)
      
    End Sub
    Public Sub Crear_Rango_RZSC03A(ByVal objRango As Rango, ByVal objTarifa As Tarifa)

        Dim objSql As New SqlManager()
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", objTarifa.CCMPN)
        objParam.Add("PNNRCTSL", objTarifa.NRCTSL)
        objParam.Add("PNNRTFSV", objTarifa.NRTFSV)
        objParam.Add("PNNRRNGO", objRango.NRRNGO)
        objParam.Add("PNVALMIN", objRango.VALMIN)
        objParam.Add("PNVALMAX", objRango.VALMAX)
        objParam.Add("PNIVLSRV", objRango.IVLSRV)
        objParam.Add("PSDESRNG", objRango.DESRNG)
       
        objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
       
        objSql.ExecuteNonQuery("SP_SOLCT_REGISTRA_RANGO_RZSC03A", objParam)
       
    End Sub

    Public Sub Elimina_Rango_RZSC03A(ByVal objRango As Rango, ByVal objTarifa As Tarifa)

        Dim objSql As New SqlManager()
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", objTarifa.CCMPN)
        objParam.Add("PNNRCTSL", objTarifa.NRCTSL)
        objParam.Add("PNNRTFSV", objTarifa.NRTFSV)
        objParam.Add("PNNRRNGO", objRango.NRRNGO)
        objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
        objSql.ExecuteNonQuery("SP_SOLCT_ELIMINAR_RANGO_RZSC03A", objParam)
      
    End Sub


    Public Function ObtenerDivTarifa_RZSC08(ByVal oTarifa As Tarifa) As Tarifa
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oTarifa.CCMPN)
        lobjParams.Add("PNNRRUBR", oTarifa.NRRUBR)
        lobjParams.Add("PNNRSRRB", oTarifa.NRSRRB)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_DIVISION_TARIFA_RZSC08", lobjParams)
        oTarifa.NRRUBR = dt.Rows(0).Item("NRRUBR")
        oTarifa.CDVSN = dt.Rows(0).Item("CDVSN")
        Return oTarifa
    End Function

    Public Function Lista_Rango_RZSC03A(ByVal objTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", objTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", objTarifa.NRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_RANGO_RZSC03A", lobjParams)
        Return dt
    End Function

    Public Sub Actualiza_Tarifa_V2(ByVal objEntidad As List(Of String))
        Dim lstr_resultado As String = ""

        Dim objSql As New SqlManager()
        Dim objParam As New Parameter

        objParam.Add("PNNRTFSV", objEntidad(0))
        objParam.Add("PNNRCTSL", objEntidad(1))
        objParam.Add("PSDESTAR", objEntidad(2))
        objParam.Add("PSCCMPN", objEntidad(3))
        objParam.Add("PSCDVSN", objEntidad(4))
        objParam.Add("PNCPLNDV", objEntidad(5))
        objParam.Add("PNNRRUBR", objEntidad(6))
        objParam.Add("PNNRSRRB", objEntidad(7))
        objParam.Add("PNCCNTCS", objEntidad(8))
        objParam.Add("PSSTPTRA", objEntidad(9))
        objParam.Add("PSCUNDMD", objEntidad(10))
        objParam.Add("PNVALCTE", objEntidad(11))
        objParam.Add("PNCMNDA1", objEntidad(12))
        objParam.Add("PNIVLSRV", objEntidad(13))
        objParam.Add("PSTOBS", objEntidad(14))
        objParam.Add("PSCUSCRT", objEntidad(15))
        objParam.Add("PNFCHCRT", objEntidad(16))
        objParam.Add("PNHRACRT", objEntidad(17))
        objParam.Add("PSCULUSA", objEntidad(18))
        objParam.Add("PNFULTAC", objEntidad(19))
        objParam.Add("PNHULTAC", objEntidad(20))
        objParam.Add("PSSESTRG", objEntidad(21))

        objSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZA_TARIFA_V2", objParam)

      
    End Sub

    Public Sub Actualizar_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)

        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PNNRRNGO", pobjTarifa.NRRNGO)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
        lobjParams.Add("PNCMNDA1", pobjTarifa.CMNDA1)
        lobjParams.Add("PSTOBS", pobjTarifa.TOBS)
        lobjParams.Add("PNIVLSRV", pobjTarifa.IVLSRV)
        lobjParams.Add("PNCPLNDV", pobjTarifa.CPLNDV)
        lobjParams.Add("PSCUNDMD", pobjRango.CUNDMD)
        lobjParams.Add("PSDESRNG", pobjRango.DESRNG)
        lobjParams.Add("PNVALMAX", pobjRango.VALMAX)
        lobjParams.Add("PNVALMIN", pobjRango.VALMIN)
        lobjParams.Add("PNVALCTE", pobjRango.VALCTE)
        lobjParams.Add("PSSTPTRA", pobjRango.STPTRA)
        lobjParams.Add("PSDESTAR", pobjTarifa.DESTAR)

        lobjParams.Add("PNCCNTCS", pobjTarifa.CCNTCS) 'Comentar Temporalmente

        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        oSqlMan.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_TARIFA", lobjParams)
      
    End Sub

    Public Function Lista_Tarifa_Servicio(ByVal pobjTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PSCDVSN", pobjTarifa.CDVSN)
        lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_X_SERVICIO_RZSC03", lobjParams)

        Return dt
    End Function

    Public Function Eliminar_Tarifa_X_Servicio(ByVal pobjTarifa As Tarifa) As Integer
        Dim lint_resultado As Integer = 0

        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PNREG", 0, ParameterDirection.Output)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLCT_ELIMINAR_TARIFA_X_SERVICIO", lobjParams)
        lint_resultado = lobjSql.ParameterCollection("PNREG")
       
        Return lint_resultado
    End Function

    Public Function Eliminar_TarifaC(ByVal pobjTarifa As Tarifa)

        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLCT_ELIMINAR_TARIFA_C", lobjParams)
        

    End Function


    Public Function ListaTotalServiciosXTarifa(ByVal objTarifa As Tarifa) As Integer
        Dim intNumReg As Integer
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PNNRTFSV", objTarifa.NRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_X_TARIFA", lobjParams)
        intNumReg = dt.Rows(0).Item("NUM_REG")
        Return intNumReg
    End Function

    Public Sub Modificar_Tarifa_Flete_RZSC03(ByVal objEntidad As Tarifa)

        Dim objSql As New SqlManager()
        Dim objParam As New Parameter
        objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
        objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
        objParam.Add("PNNRRUBR", objEntidad.NRRUBR)
        objParam.Add("PNNRSRRB", objEntidad.NRSRRB)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNNRRELF", objEntidad.NRRELF)
        objParam.Add("PNCMNDA1", objEntidad.CMNDA1)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PNCCLNFC", objEntidad.CCLNFC)
        objParam.Add("PNCCNTCS", objEntidad.CCNTCS)
        objParam.Add("PNCCNCS1", objEntidad.CCNCS1)
        objParam.Add("PSSSCGST", objEntidad.SSCGST)
        objParam.Add("PNCMRCDR", objEntidad.CMRCDR)
        objParam.Add("PSCTPUNV", objEntidad.CTPUNV)
        objParam.Add("PNCFRMPG", objEntidad.CFRMPG)
        objParam.Add("PNCFRAPG", objEntidad.CFRAPG)
        objParam.Add("PSSSGRCT", objEntidad.SSGRCT)
        objParam.Add("PNNPLSGC", objEntidad.NPLSGC)
        objParam.Add("PNCCMPSG", objEntidad.CCMPSG)
        objParam.Add("PNQPRCS1", objEntidad.QPRCS1)
        objParam.Add("PSCTPOSR", objEntidad.CTPOSR)
        objParam.Add("PNQMRCDR", objEntidad.QMRCDR)
        objParam.Add("PSCUNDMD", objEntidad.CUNDMD)
        objParam.Add("PNVMRCDR", objEntidad.VMRCDR)
        objParam.Add("PNLMRCDR", objEntidad.LMRCDR)
        objParam.Add("PSTRFMRC", objEntidad.TRFMRC)
        objParam.Add("PNPMRCDR", objEntidad.PMRCDR)
        objParam.Add("PSSTPTRA", objEntidad.STPTRA)
        objParam.Add("PSDESTAR", objEntidad.DESTAR)
        objParam.Add("PNVALCTE", objEntidad.VALCTE)
        objParam.Add("PNIVLSRV", objEntidad.IVLSRV)
        objParam.Add("PSCTPSBS", objEntidad.CTPSBS)
        objParam.Add("PNPRLBPG", objEntidad.PRLBPG)
        objParam.Add("PSFAPLBR", objEntidad.FAPLBR)
        objParam.Add("PSTOBS", objEntidad.TOBS)
        objParam.Add("PSSFLZNP", objEntidad.SFLZNP)
        objParam.Add("PSSFSANF", objEntidad.SFSANF)
        objParam.Add("PSSTSTRF", objEntidad.STSTRF)
        '<[AHM]>
        'objParam.Add("PSCDSDSP", objEntidad.CDSDSP)
        'objParam.Add("PSCDSRSP", objEntidad.CDSRSP)
        objParam.Add("PSCDTSSP", objEntidad.CDTSSP)
        'objParam.Add("PSCDTASP", objEntidad.CDTASP)
        'objParam.Add("PSCDSPSP", objEntidad.CDSPSP)
        objParam.Add("PSCDUPSP", objEntidad.CDUPSP)
        'objParam.Add("PSCDSCSP", objEntidad.CDSCSP)
        '</[AHM]>
        objParam.Add("PSFTRTSG", objEntidad.FTRTSG)

        objParam.Add("PSCULUSA", StringExtension.SubString(ConfigurationWizard.UserName, 0, 10))
        objParam.Add("PSNTRMNL", StringExtension.SubString(objEntidad.NTRMNL, 0, 10))
        'RCS-HUNDRED-INICIO
        objParam.Add("PSCTTRAN", objEntidad.CTTRAN)
        objParam.Add("PNCPATIN", objEntidad.CPATIN)
        objParam.Add("PSCTIPCG", objEntidad.CTIPCG)
        objParam.Add("PNCENCOS", objEntidad.CENCOS)
        objParam.Add("PNCENCO1", objEntidad.CENCO1)
        objParam.Add("PNCCNTBN", objEntidad.CCNTBN)
        objParam.Add("PNCENCO2", objEntidad.CENCO2)
        objParam.Add("PNCCNTB1", objEntidad.CCNTB1)
        objParam.Add("PNCENCO3", objEntidad.CENCO3)
        'RCS-HUNDRED-FIN

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        objParam.Add("PNCPLNFC", objEntidad.CPLNFC)
        objParam.Add("PSFTCLNT", objEntidad.FTCLNT)
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
        objSql.ExecuteNonQuery("SP_SOLCT_MODIFICAR_TARIFA_FLETE_RZSC03", objParam)
       
    End Sub

    'Public Sub Crear_Tarifa_Flete_RZSC03()
    Public Function Crear_Tarifa_Flete_RZSC03(ByVal objEntidad As Tarifa) As String
        Dim lstr_resultado As String = ""

        Dim objSql As New SqlManager()
        Dim objParam As New Parameter

        objParam.Add("PNNRTFSV", objEntidad.NRTFSV, ParameterDirection.Output)
        objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
        objParam.Add("PNNRRUBR", objEntidad.NRRUBR)
        objParam.Add("PNNRSRRB", objEntidad.NRSRRB)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNNRRELF", objEntidad.NRRELF)
        objParam.Add("PNCMNDA1", objEntidad.CMNDA1)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PNCCLNFC", objEntidad.CCLNFC)
        objParam.Add("PNCCNTCS", objEntidad.CCNTCS)
        objParam.Add("PNCCNCS1", objEntidad.CCNCS1)
        objParam.Add("PSSSCGST", objEntidad.SSCGST)
        objParam.Add("PNCMRCDR", objEntidad.CMRCDR)
        objParam.Add("PSCTPUNV", objEntidad.CTPUNV)
        objParam.Add("PNCFRMPG", objEntidad.CFRMPG)
        objParam.Add("PNCFRAPG", objEntidad.CFRAPG)
        objParam.Add("PSSSGRCT", objEntidad.SSGRCT)
        objParam.Add("PNNPLSGC", Convert.ToDouble(objEntidad.NPLSGC))
        objParam.Add("PNCCMPSG", objEntidad.CCMPSG)
        objParam.Add("PNQPRCS1", objEntidad.QPRCS1)
        objParam.Add("PSCTPOSR", objEntidad.CTPOSR)
        objParam.Add("PNQMRCDR", objEntidad.QMRCDR)
        objParam.Add("PSCUNDMD", objEntidad.CUNDMD)
        objParam.Add("PNVMRCDR", objEntidad.VMRCDR)
        objParam.Add("PNLMRCDR", objEntidad.LMRCDR)
        objParam.Add("PSTRFMRC", objEntidad.TRFMRC)
        objParam.Add("PNPMRCDR", objEntidad.PMRCDR)
        objParam.Add("PSSTPTRA", objEntidad.STPTRA)
        objParam.Add("PSDESTAR", objEntidad.DESTAR)
        objParam.Add("PNVALCTE", Convert.ToDouble(objEntidad.VALCTE))
        objParam.Add("PNIVLSRV", objEntidad.IVLSRV)
        objParam.Add("PSCTPSBS", objEntidad.CTPSBS)
        objParam.Add("PNPRLBPG", objEntidad.PRLBPG)
        objParam.Add("PSFAPLBR", objEntidad.FAPLBR)
        objParam.Add("PSTOBS", objEntidad.TOBS)
        objParam.Add("PSSFLZNP", objEntidad.SFLZNP)
        objParam.Add("PSSFSANF", objEntidad.SFSANF)
        objParam.Add("PSSTSTRF", objEntidad.STSTRF)
        objParam.Add("PNNORSRT", objEntidad.NORSRT)

        '<[AHM]>
       
        objParam.Add("PSCDTSSP", objEntidad.CDTSSP)
       
        objParam.Add("PSCDUPSP", objEntidad.CDUPSP)

        '</[AHM]>


        objParam.Add("PSCUSCRT", StringExtension.SubString(ConfigurationWizard.UserName, 0, 10))
        objParam.Add("PSCULUSA", StringExtension.SubString(ConfigurationWizard.UserName, 0, 10))

        objParam.Add("PSSESTRG", "P")
        objParam.Add("PSNTRMCR", StringExtension.SubString(objEntidad.NTRMCR, 0, 10))

        'RCS-HUNDRED-INICIO
        objParam.Add("PSCTTRAN", objEntidad.CTTRAN)
        objParam.Add("PNCPATIN", objEntidad.CPATIN)
        objParam.Add("PSCTIPCG", objEntidad.CTIPCG)
        objParam.Add("PNCENCOS", objEntidad.CENCOS)
        objParam.Add("PNCENCO1", objEntidad.CENCO1)
        objParam.Add("PNCCNTBN", objEntidad.CCNTBN)
        objParam.Add("PNCENCO2", objEntidad.CENCO2)
        objParam.Add("PNCCNTB1", objEntidad.CCNTB1)
        objParam.Add("PNCENCO3", objEntidad.CENCO3)
        'RCS-HUNDRED-FIN

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        objParam.Add("PNCPLNFC", objEntidad.CPLNFC)
        objParam.Add("PSFTCLNT", objEntidad.FTCLNT)
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
        objParam.Add("PSFTRTSG", objEntidad.FTRTSG)
        objSql.ExecuteNonQuery("SP_SOLCT_REGISTRA_TARIFA_FLETE_RZSC03", objParam)
        lstr_resultado = objSql.ParameterCollection("PNNRTFSV")
       
        Return lstr_resultado
    End Function

    Public Function Obtener_Tarifa_Flete_RZSC03(ByVal objEntidad As Tarifa) As Tarifa
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objEntidad.CCMPN)
        lobjParams.Add("PNNRCTSL", objEntidad.NRCTSL)
        lobjParams.Add("PNNRTFSV", objEntidad.NRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_TARIFA_RZSC03", lobjParams)
        objEntidad.DESTAR = dt.Rows(0).Item("DESTAR")
        objEntidad.CDVSN = dt.Rows(0).Item("CDVSN")
        objEntidad.CPLNDV = dt.Rows(0).Item("CPLNDV")
        objEntidad.NRRUBR = dt.Rows(0).Item("NRRUBR")
        objEntidad.NRSRRB = dt.Rows(0).Item("NRSRRB")
        objEntidad.STPTRA = dt.Rows(0).Item("STPTRA")
        objEntidad.CUNDMD = dt.Rows(0).Item("CUNDMD")
        objEntidad.VALCTE = dt.Rows(0).Item("VALCTE")
        objEntidad.CMNDA1 = dt.Rows(0).Item("CMNDA1")
        objEntidad.IVLSRV = dt.Rows(0).Item("IVLSRV")
        objEntidad.CCNTCS = dt.Rows(0).Item("CCNTCS")
        objEntidad.CMNDA1 = dt.Rows(0).Item("CMNDA1")
        objEntidad.IVLSRV = dt.Rows(0).Item("IVLSRV")
        objEntidad.PRLBPG = dt.Rows(0).Item("PRLBPG")
        objEntidad.FAPLBR = dt.Rows(0).Item("FAPLBR")
        objEntidad.TOBS = dt.Rows(0).Item("TOBS")
        objEntidad.CCNCS1 = dt.Rows(0).Item("CCNCS1")
        objEntidad.CCLNFC = dt.Rows(0).Item("CCLNFC")
        objEntidad.SFLZNP = dt.Rows(0).Item("SFLZNP")
        objEntidad.SFSANF = dt.Rows(0).Item("SFSANF")
        objEntidad.STSTRF = dt.Rows(0).Item("STSTRF")
        objEntidad.SSCGST = dt.Rows(0).Item("SSCGST")
        objEntidad.CMRCDR = dt.Rows(0).Item("CMRCDR")
        objEntidad.CTPOSR = dt.Rows(0).Item("CTPOSR")
        objEntidad.CTPSBS = dt.Rows(0).Item("CTPSBS")
        objEntidad.CFRMPG = dt.Rows(0).Item("CFRMPG")
        objEntidad.SSGRCT = dt.Rows(0).Item("SSGRCT")
        objEntidad.CCMPSG = dt.Rows(0).Item("CCMPSG")
        objEntidad.NPLSGC = dt.Rows(0).Item("NPLSGC")
        objEntidad.QPRCS1 = dt.Rows(0).Item("QPRCS1")
        objEntidad.QMRCDR = dt.Rows(0).Item("QMRCDR")
        objEntidad.PMRCDR = dt.Rows(0).Item("PMRCDR")
        objEntidad.VMRCDR = dt.Rows(0).Item("VMRCDR")
        objEntidad.LMRCDR = dt.Rows(0).Item("LMRCDR")
        objEntidad.TRFMRC = dt.Rows(0).Item("TRFMRC")
        objEntidad.CTPUNV = dt.Rows(0).Item("CTPUNV")
        objEntidad.CFRAPG = dt.Rows(0).Item("CFRAPG")
        objEntidad.NORSRT = dt.Rows(0).Item("NORSRT")
        objEntidad.SESTRG = dt.Rows(0).Item("SESTRG")
        objEntidad.CCLNT = dt.Rows(0).Item("CCLNT")
        '<[AHM]>
        objEntidad.CDSDSP = dt.Rows(0).Item("CDSDSP")
        objEntidad.CDSRSP = dt.Rows(0).Item("CDSRSP")
        objEntidad.CDTSSP = dt.Rows(0).Item("CDTSSP")
        objEntidad.CDTASP = dt.Rows(0).Item("CDTASP")
        objEntidad.CDSPSP = dt.Rows(0).Item("CDSPSP")
        objEntidad.CDUPSP = dt.Rows(0).Item("CDUPSP")
        objEntidad.CDSCSP = dt.Rows(0).Item("CDSCSP")
        '</[AHM]>
        'RCS-HUNDRED-INICIO
        objEntidad.CENCOS = dt.Rows(0).Item("CENCOS")
        objEntidad.CENCO1 = dt.Rows(0).Item("CENCO1")
        objEntidad.CCNTBN = dt.Rows(0).Item("CCNTBN")
        objEntidad.CENCO2 = dt.Rows(0).Item("CENCO2")
        objEntidad.CCNTB1 = dt.Rows(0).Item("CCNTB1")
        objEntidad.CENCO3 = dt.Rows(0).Item("CENCO3")
        objEntidad.CPATIN = dt.Rows(0).Item("CPATIN")
        objEntidad.CTTRAN = dt.Rows(0).Item("CTTRAN")
        objEntidad.CTIPCG = dt.Rows(0).Item("CTIPCG")
        'RCS-HUNDRED-FIN


        objEntidad.CECO_OR_P_DESC = dt.Rows(0).Item("CECO_OR_P_DESC")
        objEntidad.CEBE_OR_P_DESC = dt.Rows(0).Item("CEBE_OR_P_DESC")
        objEntidad.CECO_OR_T_DESC = dt.Rows(0).Item("CECO_OR_T_DESC")
        objEntidad.CEBE_OR_T_DESC = dt.Rows(0).Item("CEBE_OR_T_DESC")

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        objEntidad.CPLNFC = dt.Rows(0).Item("CPLNFC")
        objEntidad.SECTCCLNT = dt.Rows(0).Item("SECTCCLNT")
        objEntidad.FTCLNT = dt.Rows(0).Item("FTCLNT")

        objEntidad.CEBEP_D = dt.Rows(0).Item("CEBEP_D")
        objEntidad.CEBET_D = dt.Rows(0).Item("CEBET_D")
        objEntidad.CECOP_D = dt.Rows(0).Item("CECOP_D")
        objEntidad.CECOT_D = dt.Rows(0).Item("CECOT_D")

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

        Return objEntidad
    End Function


    Public Function fdtListarDetalleTarifaFlete(ByVal pobjTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_DETALLE_TARIFA_TIPO_FLETE", lobjParams)
        'dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_X_SERVICIO", lobjParams)
        Return dt
    End Function

    ''' <summary>
    ''' Cerrar OS
    ''' </summary>
    ''' <param name="pobjTarifa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function fintCerrarOS(ByVal pobjTarifa As Tarifa) As Integer

    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    Try
    '        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
    '        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
    '        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
    '        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
    '        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
    '        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_CERRAR_OS", lobjParams)
    '        Return 1
    '    Catch ex As Exception
    '        Return -1
    '    End Try

    'End Function



    Public Function fdtListarTarifaExportar(ByVal pobjTarifa As Tarifa) As DataSet

        Dim dt As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PSCDVSN", pobjTarifa.CDVSN)
        lobjParams.Add("PNCPLNDV", pobjTarifa.CPLNDV)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
        lobjParams.Add("PNNRRUBR", pobjTarifa.NRRUBR)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PSSESTRG", pobjTarifa.SESTRG)
        lobjParams.Add("PNNORSRT", pobjTarifa.NORSRT)
        dt = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_TARIFAS_EXPORTAR", lobjParams)
        'dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_X_CONTRATO", lobjParams)

 

        Return dt
     
    End Function

    Public Function ListaTotalServiciosXTarifaFlete(ByVal PNNORSRT As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSRT", PNNORSRT)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_X_TARIFA", lobjParams)
        Return dt
    End Function

    Public Function Anular_Tarifa_X_Servicio(ByVal pobjTarifa As Tarifa)

        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        'lobjParams.Add("PSSESTRG", pobjTarifa.SESTRG)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_TARIFA_X_SERVICIO", lobjParams)
     

    End Function

    'Public Function Eliminar_Tarifa_X_Servicio_Fact(ByVal pobjTarifa As Tarifa)
    '    Dim lint_resultado As Integer = 0
    '    'Try
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
    '    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)

    '    lobjSql.ExecuteNonQuery("SP_SOLCT_ELIMINAR_TARIFA_X_SERVICIO_FAC", lobjParams)

    'End Function

    Public Function Eliminar_Tarifa_Flete_X_Servicio(ByVal pobjTarifa As Tarifa)
        Dim lint_resultado As Integer = 0

        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PSSESTRG", pobjTarifa.SESTRG)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

        lobjSql.ExecuteNonQuery("SP_SOLCT_ELIMINAR_TARIFA_FLETE_X_SERVICIO", lobjParams)
       
    End Function


    Public Function fintActivarTarifa(ByVal pobjTarifa As Tarifa) As Integer

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PSSTPTRA", pobjTarifa.STPTRA)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)

        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_ACTIVAR_TARIFA", lobjParams)
        Return 1
      

    End Function

    Public Function ListaSolicitudXServicio(ByVal objTarifa As Tarifa) As Integer
        Dim dt As DataTable
        Dim intNumReg As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PNNORSRT", objTarifa.NORSRT)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SOLICITUD_X_SERVICIO", lobjParams)
        intNumReg = dt.Rows(0).Item("NUM_REG")
        Return intNumReg
    End Function

    Public Function ListaOperacionXServicio(ByVal objTarifa As Tarifa) As Integer
        Dim dt As DataTable
        Dim intNumReg As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PNNORSRT", objTarifa.NORSRT)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_OPERACION_X_SERVICIO", lobjParams)
        intNumReg = dt.Rows(0).Item("NUM_REG")
        Return intNumReg
    End Function

    Public Function ListaOperacionXServicio_Cerrar(ByVal objTarifa As Tarifa) As Integer
        Dim dt As DataTable
        Dim intNumReg As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PNNORSRT", objTarifa.NORSRT)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_OPERACION_X_SERVICIO_CERRAR", lobjParams)
        intNumReg = dt.Rows(0).Item("NUM_REG")
        Return intNumReg
    End Function

    Public Function ListaTotalServiciosXTarifaCerrar(ByVal objTarifa As Tarifa) As Integer
        Dim intNumReg As Integer
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PNNRTFSV", objTarifa.NRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_X_TARIFA_CERRAR", lobjParams)
        intNumReg = dt.Rows(0).Item("NUM_REG")
        Return intNumReg
    End Function

    Public Function ListaTarifaXCodTarifa(ByVal objTarifa As Tarifa) As DataSet

        Dim dt As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PSNRTFSV", objTarifa.sNRTFSV)

        dt = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_TARIFAS_X_CODIGO", lobjParams)
        Return dt
      
    End Function

     




    Public Function ListaTarifaFija(ByVal objTarifa As Tarifa) As List(Of Tarifa)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of Tarifa)
        Dim objParam As New Parameter
        Dim lobjSql As New SqlManager

        objParam.Add("PSCCMPN", objTarifa.CCMPN) '(Compañía)
        objParam.Add("PSCDVSN", objTarifa.CDVSN) '(División)
        objParam.Add("PNCPLNDV", objTarifa.CPLNDV) '(PLanta)
        objParam.Add("PNNRCTSL", objTarifa.NRCTSL) '(Cod. Contrato)
        objParam.Add("PNNRRUBR", objTarifa.NRRUBR) '(Cod. Rubro General)
        objParam.Add("PNNRSRRB", objTarifa.NRSRRB) ' (Cod. Rubro Especifico)
        objParam.Add("PNCMNDA1", objTarifa.CMNDA1) '(Cod. Moneda)
        objParam.Add("PSCUNDMD", objTarifa.CUNDMD) '(Unidad Medida)
        objParam.Add("PSCCNTCS", objTarifa.CCNTCS) '(Centro Beneficio)

        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objTarifa.CCMPN)
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA__FIJA_RELACIONAL", objParam)
        'Procesandolos como una Lista
        For Each objDataRow As DataRow In objDataTable.Rows
            Dim objDatos As New Tarifa

            objDatos.CDTREF = objDataRow("NRTFSV").ToString.Trim '(Cod. Tarifa )
            objDatos.NOMSER = objDataRow("NOMSER").ToString.Trim '(Nombra Servicio)
            objDatos.VALCTE = objDataRow("VALCTE").ToString.Trim '(Cantidad)
            objDatos.CUNDMD = objDataRow("CUNDMD").ToString.Trim '(UNidad medida)
            objDatos.IVLSRV = objDataRow("IVLSRV").ToString.Trim '(Valor)
            objDatos.TSGNMN = objDataRow("TSGNMN").ToString.Trim '(Moneda)
            objDatos.TALMC = objDataRow("TALMC").ToString.Trim '(Tipo Almacén)
            objDatos.TIPMER = objDataRow("TIPMER").ToString.Trim '(Tipo Mercadería) 
            objGenericCollection.Add(objDatos)
        Next
      
        Return objGenericCollection
    End Function

    '<[AHM] AZP>
    Public Function ValidarMaterialSAP(ByVal objTarifa As Tarifa) As TarifaSAP

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Dim tarifaSAP As New TarifaSAP
        Dim estado As String = ""

        Try
            lobjParams.Add("PARAM_CCMPN", objTarifa.CCMPN)
            lobjParams.Add("PARAM_CRGVTA", objTarifa.CRGVTA)
            lobjParams.Add("PARAM_TSRVIN", objTarifa.TSRVIN.Trim.ToString.PadLeft(10, "0"))


            lobjParams.Add("PARAM_VTWEG", "95")
            lobjParams.Add("PARAM_FLGSTS", estado, ParameterDirection.InputOutput)
            lobjParams.Add("PARAM_TOBS", tarifaSAP.Observaciones, ParameterDirection.InputOutput)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP101", lobjParams)

            'tarifaSAP.CodMaterial = lobjParams.Item(0).Value
            'tarifaSAP.CodRegionVenta = lobjParams.Item(1).Value
            'tarifaSAP.CanalDistribucion = lobjParams.Item(2).Value
            If (lobjParams.Item(5).Value = "S") Then
                tarifaSAP.EsValida = True
            Else
                tarifaSAP.EsValida = False
            End If
            tarifaSAP.Observaciones = lobjParams.Item(6).Value.ToString.Trim
        Catch ex As Exception
            tarifaSAP.EsValida = False
        End Try

        Return tarifaSAP
    End Function
    '</[AHM]>

    'RCS-HUNDRED-INICIO

    Public Function Cargar_Datos_Generales_Tarifa_Transporte(ByVal objTarifa As Tarifa) As DataSet 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_DATOS_MAESTROS_RELACIONADOS", lobjParams)
        Return ds
    End Function

    'RCS-HUNDRED-FIN
    Public Function CopiarTarifa(ByVal objTarifa As Tarifa) As Integer
        Dim intNumReg As Integer
        'Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSCCMPN", objTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", objTarifa.NRCTSL)
        lobjParams.Add("PSNRTFSV", objTarifa.sNRTFSV)
        lobjParams.Add("PSCUSCRT", objTarifa.CUSCRT)
        lobjParams.Add("PSNTRMCR", objTarifa.NTRMCR)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_COPY_TARIFA", lobjParams)
        intNumReg = 1
        'Catch ex As Exception
        '    intNumReg = -1
        'End Try

        Return intNumReg
    End Function


    Public Function Listar_datos_Cliente(ByVal ccmpn As String, ByVal cclnt As Double) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim output As New DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", ccmpn)
        parameter.Add("PNCCLNT", cclnt)
        sqlManager.DefaultSchema = Autenticacion_DAL.GetLibrary(ccmpn)
        output = sqlManager.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_CLIENTE", parameter)

      

        Return output
    End Function


    Public Function Cerrar_Tarifa_Flete_X_Servicio_Item(ByVal pobjTarifa As Tarifa) As String

        Dim msgerror As String = ""
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PNNCRRSR", pobjTarifa.NCRRSR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_CERRAR_TARIFA_FLETE_X_SERVICIO_ITEM", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msgerror = msgerror & Chr(13) & ("" & item("OBSRESULT")).ToString.Trim
            End If
        Next
        msgerror = msgerror.Trim
        Return msgerror
    End Function

    Public Function Lista_Validar_Margen_Tarifa(ByVal pobjTarifa As Tarifa, ByRef msgError As String) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL ", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_VALIDAR_MARGEN_ORDEN_SERVICIO", lobjParams)
        Dim dtval As New DataTable
        dtval = ds.Tables(0)
        For Each dr As DataRow In dtval.Rows
            If dr("STATUS") = "E" Then
                msgError = msgError & dr("OBSRESULT").ToString & vbNewLine
            End If
        Next
        msgError = msgError.Trim
        Return ds
    End Function
    Public Sub Enviar_Aprobar_Tarifa(ByVal pobjTarifa As Tarifa)


        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL ", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PNMRGAPROB", pobjTarifa.MRGPOR)
        lobjParams.Add("PNNLBFLT", pobjTarifa.NLBFLT)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_ENVIAR_APROBACION_OS", lobjParams)

    End Sub
    Public Function Lista_Cotizacion_por_Aprobar(ByVal pobjTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PSCDVSN ", pobjTarifa.CDVSN)
        lobjParams.Add("PNCCLNT", pobjTarifa.CCLNT)
        lobjParams.Add("PNNORSRT", pobjTarifa.NORSRT)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_COTIZACION_POR_APROBAR", lobjParams)
        Return dt
    End Function
    Public Function Lista_Servicio_Mercaderia_Aprobacion(ByVal pobjTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIO_MERCADERIA_APROBACION", lobjParams)
        Return dt
    End Function

    Public Function Actualizar_Estado_OS(ByVal pobjTarifa As Tarifa) As Integer
        Dim intNumReg As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PSAPRBTF", pobjTarifa.APRBTF)
        lobjParams.Add("PNFCHAPR", pobjTarifa.FCHAPR)
        lobjParams.Add("PSOBSAPR", pobjTarifa.OBSAPR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_ESTADO_ORDEN_SERVICIO_V3", lobjParams)
        intNumReg = 1
        Return intNumReg
    End Function


    Public Sub Cancelar_Envio_Aprobacion_tarifa(ByVal pobjTarifa As Tarifa)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_CANCELAR_ENVIO_APROBACION", lobjParams)


    End Sub


  


End Class

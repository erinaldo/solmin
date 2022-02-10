Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class AlquilerUnidad_DAL
    Private objSql As New SqlManager
    Public Function Listar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Dim objDataTable As New DataTable
        Dim objDataSet As New DataSet
        Dim objGenericCollection As New List(Of AlquilerUnidad)
        Dim objParam As New Parameter


        'Obteniendo resultados
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PSSESALQ", objEntidad.SESALQ)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PNNLQDCN", objEntidad.NLQDCN)
        objParam.Add("PNFCHASGI", objEntidad.FCHASGI)
        objParam.Add("PNFCHASGF", objEntidad.FCHASGF)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)

 
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ALQUILER_UNIDADES", objParam)


        For Each objDataRow As DataRow In objDataTable.Rows
            Dim objDatos As New AlquilerUnidad
            objDatos.CCMPN = objDataRow("CCMPN")
            objDatos.CDVSN = objDataRow("CDVSN")
            objDatos.CPLNDV = objDataRow("CPLNDV")
            objDatos.NRALQT = objDataRow("NRALQT")
            objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
            objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
            objDatos.STPRCS = objDataRow("STPRCS").ToString.Trim
            objDatos.TDSDES = objDataRow("TDSDES").ToString.Trim
            objDatos.NPLRCS = objDataRow("NPLRCS").ToString.Trim
            objDatos.FCHASG_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FCHASG").ToString.Trim)
            objDatos.FVALIN_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FVALIN").ToString.Trim)
            objDatos.FVALFI_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FVALFI").ToString.Trim)
            objDatos.CMNALQ = objDataRow("CMNALQ")
            objDatos.QCNALQ = objDataRow("QCNALQ")
            objDatos.IRVALQ = objDataRow("IRVALQ")
            objDatos.CSRVNV = objDataRow("CSRVNV")
            objDatos.CCNCS1 = objDataRow("CCNCS1")
            objDatos.TMNDA = objDataRow("TMNDA").ToString.Trim
            objDatos.IMP_TOTAL = Val(objDataRow("IMP_TOTAL").ToString.Trim)
            objDatos.SESALQ = objDataRow("SESALQ").ToString.Trim
            objDatos.SESALQ_S = objDataRow("SESALQ_S").ToString.Trim
            objDatos.NORINS = Val(objDataRow("NORINS").ToString.Trim)
            ''objDatos.NLQDCN = objDataRow("NLQDCN").ToString.Trim
            objDatos.TCMTRF = objDataRow("TCMTRF").ToString.Trim
            objDatos.NOPRCN = objDataRow("NOPRCN")
            objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
            objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
            objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
            objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
            objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
            objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim

            objDatos.CUSRCR = objDataRow("CUSRCR").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(objDataRow("FCHCIE")) & " " & IIf(objDataRow("HRACER").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HRACER")), "")

            objDatos.TOBRES = objDataRow("TOBRES").ToString.Trim

            objDatos.CUSAPR = objDataRow("CUSAPR").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(objDataRow("FCHAPR")) & " " & IIf(objDataRow("HRAAPR").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(objDataRow("HRAAPR")), "")

            objDatos.TOBRES2 = ("" & objDataRow("TOBRES2")).ToString.Trim
            objDatos.FLGAPR = ("" & objDataRow("FLGAPR")).ToString.Trim
            objDatos.FLGAPR_APR = ("" & objDataRow("FLGAPR_APR")).ToString.Trim

            objDatos.REFDO1 = objDataRow("REFDO1").ToString.Trim
            objDatos.TOBS = objDataRow("TOBS").ToString.Trim
            objDatos.TOBRE3 = objDataRow("TOBRE3").ToString.Trim

            objGenericCollection.Add(objDatos)
        Next
        '    End If
        'Next
        'Procesandolos como una Lista

        Return objGenericCollection
    End Function

    Public Function Listar_Recursos_Asignados(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of AlquilerUnidad)
        Dim objParam As New Parameter


        'Obteniendo resultados
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)


        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_RECURSOS_ASIGNADOS", objParam)

        If objEntidad.STPRCS = "T" Then
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New AlquilerUnidad
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.STPRCS = objDataRow("STPRCS").ToString.Trim
                objDatos.TDSDES = objDataRow("TDSDES").ToString.Trim
                objDatos.NPLRCS = objDataRow("NPLRCS").ToString.Trim
                objDatos.TIPO_UNIDAD = objDataRow("TIPO_UNIDAD").ToString.Trim
                objDatos.MARCA = objDataRow("MARCA").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next
        ElseIf objEntidad.STPRCS = "A" Then
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New AlquilerUnidad
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.STPRCS = objDataRow("STPRCS").ToString.Trim
                objDatos.TDSDES = objDataRow("TDSDES").ToString.Trim
                objDatos.NPLRCS = objDataRow("NPLRCS").ToString.Trim
                objDatos.TIPO_UNIDAD = objDataRow("TIPO_UNIDAD").ToString.Trim
                objDatos.MARCA = objDataRow("MARCA").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next
        End If


        'Procesandolos como una Lista


        Return objGenericCollection
    End Function

    Public Function Registrar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad

        Dim objParam As New Parameter
        objParam.Add("POS_NRALQT", objEntidad.NRALQT, ParameterDirection.Output)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
        objParam.Add("PNFCHASG", objEntidad.FCHASG)
        objParam.Add("PNFVALIN", objEntidad.FVALIN)
        objParam.Add("PNFVALFI", objEntidad.FVALFI)
        objParam.Add("PNCSRVNV", objEntidad.CSRVNV)
        objParam.Add("PNCCNCS1", objEntidad.CCNCS1)
        objParam.Add("PNCMNALQ", objEntidad.CMNALQ)
        objParam.Add("PNQCNALQ", objEntidad.QCNALQ)
        objParam.Add("PNIRVALQ", objEntidad.IRVALQ)
        objParam.Add("PSSESALQ", objEntidad.SESALQ)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
        objParam.Add("PSREFDO1", objEntidad.REFDO1)
        objParam.Add("PSTOBS", objEntidad.TOBS)

 

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ALQUILER_UNIDAD", objParam)

        objEntidad.NRALQT = objSql.ParameterCollection("POS_NRALQT")

        Return objEntidad
    End Function

    Public Function Modificar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad

        Dim objParam As New Parameter
        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
        objParam.Add("PNFCHASG", objEntidad.FCHASG)
        objParam.Add("PNFVALIN", objEntidad.FVALIN)
        objParam.Add("PNFVALFI", objEntidad.FVALFI)
        objParam.Add("PNCSRVNV", objEntidad.CSRVNV)
        objParam.Add("PNCCNCS1", objEntidad.CCNCS1)
        objParam.Add("PNCMNALQ", objEntidad.CMNALQ)
        objParam.Add("PNQCNALQ", objEntidad.QCNALQ)
        objParam.Add("PNIRVALQ", objEntidad.IRVALQ)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSREFDO1", objEntidad.REFDO1)
        objParam.Add("PSTOBS", objEntidad.TOBS)
        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_ALQUILER_UNIDAD", objParam)

        Return objEntidad
    End Function

    Public Function Eliminar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad

        Dim objParam As New Parameter
        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_ALQUILER_UNIDAD", objParam)

        Return objEntidad
    End Function
    '1  SOTORE PARA  CERRAR EL ALQUILER
    Public Function Cerrar_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad

        Dim objParam As New Parameter
        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSTOBRES", objEntidad.TOBRES)

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_ALQUILER_UNIDAD", objParam)

        Return objEntidad
    End Function

    Public Function Listar_Operacion_X_Proveedor(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of AlquilerUnidad)
        Dim objParam As New Parameter


        'Obteniendo resultados
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
        objParam.Add("PNFINCOPI", objEntidad.FINCOPINI)
        objParam.Add("PNFINCOPF", objEntidad.FINCOPFIN)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_PROVEEDOR_RECURSO", objParam)

        For Each objDataRow As DataRow In objDataTable.Rows
            Dim objDatos As New AlquilerUnidad
            objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
            objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
            objDatos.NOPRCN = objDataRow("NOPRCN")
            objDatos.FINCOP_S = HelpClass.CFecha_de_8_a_10(objDataRow("FINCOP").ToString.Trim)
            objDatos.NORSRT = objDataRow("NORSRT").ToString.Trim
            objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
            objDatos.CCLNT_S = objDataRow("CCLNT_S").ToString.Trim
            objDatos.RUTA = objDataRow("CLCLOR_S").ToString.Trim & " - " & objDataRow("CLCLDS_S").ToString.Trim
            objDatos.CLCLOR = objDataRow("CLCLOR")
            objDatos.CLCLOR_S = objDataRow("CLCLOR_S").ToString.Trim
            objDatos.CLCLDS = objDataRow("CLCLDS")
            objDatos.CLCLDS_S = objDataRow("CLCLDS_S").ToString.Trim
            objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
            objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
            objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
            objDatos.CBRCND = objDataRow("CBRCND").ToString.Trim
            objDatos.SESTOP = objDataRow("SESTOP").ToString.Trim
            objDatos.FATNSR = HelpClass.CFecha_de_8_a_10(objDataRow("FATNSR").ToString.Trim)
            objGenericCollection.Add(objDatos)
        Next
        'Procesandolos como una Lista
        Return objGenericCollection
    End Function

    Public Function Validar_Existe_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of AlquilerUnidad)
        Dim objParam As New Parameter


        'Obteniendo resultados
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_EXISTE_ALQUILER_UNIDAD", objParam)

        For Each objDataRow As DataRow In objDataTable.Rows
            Dim objDatos As New AlquilerUnidad
            objDatos.NRALQT = objDataRow("NRALQT")
            objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
            objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
            objDatos.CPLNDV = objDataRow("CPLNDV")
            objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
            objDatos.STPRCS = objDataRow("STPRCS").ToString.Trim
            objDatos.NPLRCS = objDataRow("NPLRCS").ToString.Trim

            objGenericCollection.Add(objDatos)
        Next
        'Procesandolos como una Lista

        Return objGenericCollection
    End Function

    Public Function Obtener_Datos_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Dim objDataTable As New DataTable
        Dim objDataSet As New DataSet
        Dim objGenericCollection As New List(Of AlquilerUnidad)
        Dim objParam As New Parameter

        'Obteniendo resultados
        objParam.Add("PNNRALQT", objEntidad.NRALQT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DATOS_ALQUILER_UNIDAD", objParam)


        'For Each objDataRow As DataRow In objDataTable.Rows
        Dim objDatos As New AlquilerUnidad
        If objDataTable.Rows.Count > 0 Then
            objDatos.NRALQT = objDataTable.Rows(0)("NRALQT")
            objDatos.CCMPN = objDataTable.Rows(0)("CCMPN")
            objDatos.NRUCTR = objDataTable.Rows(0)("NRUCTR").ToString.Trim
            objDatos.SESALQ = objDataTable.Rows(0)("SESALQ").ToString.Trim
            objDatos.FLGAPR = objDataTable.Rows(0)("FLGAPR").ToString.Trim
            objDatos.FVALIN = objDataTable.Rows(0)("FVALIN")
            objDatos.FVALFI = objDataTable.Rows(0)("FVALFI")
            objDatos.CMNALQ = objDataTable.Rows(0)("CMNALQ")
            objDatos.IRVALQ = objDataTable.Rows(0)("IRVALQ")
            objDatos.TOBRE3 = objDataTable.Rows(0)("TOBRE3")
            objDatos.CMNAL1 = objDataTable.Rows(0)("CMNAL1")
            objDatos.IRVAL1 = objDataTable.Rows(0)("IRVAL1")
        Else
            objDatos = Nothing
        End If
        'objGenericCollection.Add(objDatos)
        'Next
        Return objDatos
    End Function

    Public Function Generar_Orden_Interna_Alquiler(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Dim objParam As New Parameter
        objParam.Add("PARAM_NORINS", objEntidad.NORINS, ParameterDirection.Output)
        objParam.Add("PARAM_CCLORI", objEntidad.CCLORI, ParameterDirection.Output)
        objParam.Add("PARAM_NOPRCN", objEntidad.NRALQT)
        objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
        objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_ORDEN_INTERNA_ALQUILER", objParam)

        objEntidad.NORINS = objSql.ParameterCollection("PARAM_NORINS")
        objEntidad.CCLORI = objSql.ParameterCollection("PARAM_CCLORI")

        Return objEntidad
    End Function

    Public Function Registrar_Operacion_Transporte_Alquiler(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Dim objParam As New Parameter
        objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
        objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
        objParam.Add("PARAM_NRALQT", objEntidad.NRALQT)
        objParam.Add("PARAM_NORINS", objEntidad.NORINS)
        objParam.Add("PARAM_CCLORI", objEntidad.CCLORI)

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_OPERACION_TRANSPORTE_ALQUILER", objParam)

        Return objEntidad
    End Function

    Public Function Procesar_Liquidacion_Alquiler(ByVal objEntidad As AlquilerUnidad) As AlquilerUnidad
        Dim objParam As New Parameter
        objParam.Add("PARAM_NRALQT", objEntidad.NRALQT)
        objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
        objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_ALQUILER", objParam)

        Return objEntidad
    End Function

    Public Function Listar_Datos_Liquidacion_Alquiler(ByVal objEntidad As AlquilerUnidad) As DataTable
        Dim objDataTable As New DataTable
        Dim objDataSet As New DataSet
        Dim objGenericCollection As New List(Of AlquilerUnidad)
        Dim objParam As New Parameter

        'Obteniendo resultados
        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DATOS_LIQUIDACION_ALQUILER", objParam)


        'For Each objDataRow As DataRow In objDataTable.Rows
        '    Dim objDatos As New AlquilerUnidad
        '    objDatos.NLQDCN = objDataRow("NLQDCN")
        '    objDatos.FLQDCN = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FLQDCN").ToString.Trim)
        '    objDatos.NRFSAP = objDataRow("NRFSAP")
        '    objDatos.TSTERS = objDataRow("TSTERS").ToString.Trim
        '    objDatos.FSTTRS = objDataRow("FSTTRS").ToString.Trim
        '    objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
        '    objDatos.NUMOPG = objDataRow("NUMOPG").ToString.Trim
        '    objDatos.ILQDTR = objDataRow("ILQDTR").ToString.Trim
        '    objDatos.ITCCTC = objDataRow("ITCCTC")
        '    objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
        '    objDatos.CDVSN = objDataRow("CDVSN")
        '    objDatos.CPLNDV = objDataRow("CPLNDV")
        '    objDatos.CSRVC = objDataRow("CSRVC")
        '    objDatos.SERVICIO = objDataRow("SERVICIO").ToString.Trim
        '    objGenericCollection.Add(objDatos)
        'Next
        '    End If
        'Next
        'Procesandolos como una Lista

        Return objDataTable



    End Function

    Public Function Obtener_Operacion_Alquiler_Unidad(ByVal objEntidad As AlquilerUnidad) As DataTable
        Dim objDataTable As New DataTable
        Dim objDataSet As New DataSet
        Dim objGenericCollection As New List(Of AlquilerUnidad)
        Dim objParam As New Parameter


        'Obteniendo resultados
        objParam.Add("PNNRALQT", objEntidad.NRALQT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_OPERACION_ALQUILER_UNIDAD", objParam)


        'For Each objDataRow As DataRow In objDataTable.Rows
        '    Dim objDatos As New AlquilerUnidad
        '    objDatos.NRALQT = objDataRow("NRALQT")
        'objDatos.CDVSN = objDataRow("CDVSN")
        'objDatos.CPLNDV = objDataRow("CPLNDV")
        'objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
        'objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
        'objDatos.STPRCS = objDataRow("STPRCS").ToString.Trim
        'objDatos.TDSDES = objDataRow("TDSDES").ToString.Trim
        'objDatos.NPLRCS = objDataRow("NPLRCS").ToString.Trim
        'objDatos.FCHASG_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FCHASG").ToString.Trim)
        'objDatos.FVALIN_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FVALIN").ToString.Trim)
        'objDatos.FVALFI_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FVALFI").ToString.Trim)
        'objDatos.CMNALQ = objDataRow("CMNALQ")
        'objDatos.QCNALQ = objDataRow("QCNALQ")
        'objDatos.IRVALQ = objDataRow("IRVALQ")
        'objDatos.CSRVNV = objDataRow("CSRVNV")
        'objDatos.CCNCS1 = objDataRow("CCNCS1")
        'objDatos.TMNDA = objDataRow("TMNDA").ToString.Trim
        'objDatos.IMP_TOTAL = Val(objDataRow("IMP_TOTAL").ToString.Trim)
        'objDatos.SESALQ = objDataRow("SESALQ").ToString.Trim
        'objDatos.SESALQ_S = objDataRow("SESALQ_S").ToString.Trim
        'objDatos.NORINS = Val(objDataRow("NORINS").ToString.Trim)
        'objDatos.TCMTRF = objDataRow("TCMTRF").ToString.Trim
        'objDatos.NOPRCN = objDataRow("NOPRCN")

        'objGenericCollection.Add(objDatos)
        'Next
        '    End If
        'Next
        'Procesandolos como una Lista

        'Return objGenericCollection
        Return objDataTable
    End Function

    Public Function Validar_Configuracion_Servicio_Alquiler(ByVal objEntidad As AlquilerUnidad, ByRef strMensajeError As String) As Boolean
        Dim bResultado As Boolean = True
        Dim slist() As String
        Dim msg As String = ""
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_NRALQT", objEntidad.NRALQT)
            objParam.Add("PARAM_MSG", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_CONFIGURACION_SERVICIO_ALQUILER", objParam)
            strMensajeError = "" & objSql.ParameterCollection("PARAM_MSG")
            strMensajeError = strMensajeError.Trim
            If strMensajeError.Length > 0 Then
                slist = strMensajeError.Split("|")
                For Each Item As String In slist
                    msg = msg & Chr(13) & Item
                Next
                msg = msg.Trim
            End If
            strMensajeError = msg
            If strMensajeError <> "" Then bResultado = False
        Catch ex As Exception
            strMensajeError = ex.Message
            bResultado = False
        End Try
        Return bResultado

    End Function

    Public Function Listar_Unidad_Alquiler_Operaciones_RPT(ByVal objEntidad As AlquilerUnidad) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter


        'Obteniendo resultados
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PSSESALQ", objEntidad.SESALQ)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PNNLQDCN", objEntidad.NLQDCN)
        objParam.Add("PNFCHASGI", objEntidad.FCHASGI)
        objParam.Add("PNFCHASGF", objEntidad.FCHASGF)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ALQUILER_UNIDADES_OPERACIONES_RPT", objParam)
        For Each row As DataRow In objDataTable.Rows
            row("FCHASG") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(row("FCHASG"))).ToString
            row("FVALIN") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(row("FVALIN"))).ToString
            row("FVALFI") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(row("FVALFI"))).ToString
            row("FINCOP") = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(row("FINCOP"))).ToString

            row("CUSRCR") = row("CUSRCR").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(row("FCHCIE")) & " " & IIf(row("HRACER").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(row("HRACER")), "")
            row("TOBRES") = row("TOBRES").ToString.Trim
            row("TOBRE3") = row("TOBRE3").ToString.Trim
            row("TOBS") = row("TOBS").ToString.Trim
            row("CUSAPR") = row("CUSAPR").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(row("FCHAPR")) & " " & IIf(row("HRAAPR").ToString.Trim <> "0", HelpClass.HoraNum_a_Hora(row("HRAAPR")), "")
            row("TOBRES2") = ("" & row("TOBRES2")).ToString.Trim
            row("FLGAPR") = ("" & row("FLGAPR")).ToString.Trim
            row("FLGAPR_APR") = ("" & row("FLGAPR_APR")).ToString.Trim
        Next
        Return objDataTable
    End Function


    Public Sub Eliminar_Operaciones_Alquiler(ByVal objEntidad As AlquilerUnidad)
        Try
            Dim objParam As New Parameter

            objParam.Add("PNNRALQT", objEntidad.NRALQT)
            objParam.Add("PNNCRRRT", objEntidad.NCRRRT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_OPERACION_ALQUILER_UNIDAD", objParam)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Modificar_Alquiler_Unidad_Vigencia(ByVal objEntidad As AlquilerUnidad)
        Dim objParam As New Parameter

        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PNFVALIN", objEntidad.FVALIN)
        objParam.Add("PNFVALFI", objEntidad.FVALFI)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSTOBS", objEntidad.TOBS)
        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_ALQUILER_UNIDAD_VIGENCIA", objParam)
    End Sub

 
    Public Sub Actualizar_Alquiler_Unidad_Liquidacion(ByVal objEntidad As AlquilerUnidad)
        Dim objParam As New Parameter
        objParam.Add("PNNRALQT", objEntidad.NRALQT)
        objParam.Add("PNCMNAL1", objEntidad.CMNAL1)
        objParam.Add("PNIRVAL1", objEntidad.IRVAL1)
        objParam.Add("PSTOBRE3", objEntidad.TOBRE3)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_ALQUILER_UNIDAD_ENVIO_SAP", objParam)
    End Sub

End Class

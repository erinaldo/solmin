Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports SOLMIN_CTZ.Entidades        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

Public Class clsGeneral
    Inherits clsBase(Of ClaseGeneral)


    Public Function Listar_Mercaderia() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeMercaderia As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_MERCADERIATRANSPORTES", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim()
            objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim()
            objEntidad.TAMRCD = objDataRow("TAMRCD").ToString.Trim()
            objEntidad.CGRMRC = objDataRow("CGRMRC").ToString.Trim()

            lbeMercaderia.Add(objEntidad)
        Next

        Return lbeMercaderia
    End Function

    Public Function Listar_Unidad_Transporte() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeUnidadMedida As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UNIDADES_TRANSPORTE", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.SESTRG = objDataRow("SESTRG").ToString.Trim()
            objEntidad.SCLSPS = objDataRow("SCLSPS").ToString.Trim()
            objEntidad.CUNDVH = objDataRow("CUNDVH").ToString.Trim()
            objEntidad.TUNDVH = objDataRow("TUNDVH").ToString.Trim()
            objEntidad.CTPUNV = objDataRow("CTPUNV").ToString.Trim()
            objEntidad.STPOUN = objDataRow("STPOUN").ToString.Trim()
            objEntidad.CTPCRA = objDataRow("CTPCRA")

            lbeUnidadMedida.Add(objEntidad)
        Next
        Return lbeUnidadMedida
    End Function

    Public Function Listar_Parametros_Facturacion() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeUnidadMedida As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_MEDIDAS_FACTURACION", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CFRMPG = objDataRow("CFRMPG")
            objEntidad.TCMFRP = objDataRow("TCMFRP").ToString.Trim()
            objEntidad.TABFRP = objDataRow("TABFRP").ToString.Trim()
            lbeUnidadMedida.Add(objEntidad)
        Next
        Return lbeUnidadMedida
    End Function

    Public Function Listar_Compania_Seguro() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeCompSeguro As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_COMPANIA_SEGURO", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CCMPSG = objDataRow("CCMPSG")
            objEntidad.TCMPSG = objDataRow("TCMPSG").ToString.Trim()
            objEntidad.TABCMS = objDataRow("TABCMS").ToString.Trim()
            objEntidad.NRUCCS = objDataRow("NRUCCS").ToString.Trim()
            objEntidad.CUBGEO = objDataRow("CUBGEO").ToString.Trim()
            objEntidad.TDRCMS = objDataRow("TDRCMS").ToString.Trim()
            objEntidad.NTLCMS = objDataRow("NTLCMS").ToString.Trim()
            objEntidad.NFXCMS = objDataRow("NFXCMS").ToString.Trim()
            objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim()
            objEntidad.SESTRG = objDataRow("SESTRG").ToString.Trim()
            lbeCompSeguro.Add(objEntidad)
        Next

        Return lbeCompSeguro
    End Function

    Public Function Listar_Tipo_Servicio_Transp() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeTipSerTrsp As New List(Of ClaseGeneral)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim()
            objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim()
            objEntidad.TABTPS = objDataRow("TABTPS").ToString.Trim()
            objEntidad.CDUPSP = objDataRow("CDUPSP").ToString.Trim() 'RCS-HUNDRED
            lbeTipSerTrsp.Add(objEntidad)
        Next

        Return lbeTipSerTrsp
    End Function

    Public Function Listar_Tipo_SubServicio(ByVal obeClaseGeneral As ClaseGeneral) As List(Of ClaseGeneral)
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim objEntidad As ClaseGeneral
        Dim lbeSubServicio As New List(Of ClaseGeneral)
        lobjParams.Add("PARAM_CTPOSR", obeClaseGeneral.CTPOSR)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SUB_SERVICIO", lobjParams)
        'Dim dr As DataRow = dt.NewRow
        'dr("CTPSBS") = "0"
        'dr("TABSBS") = "--- Escoja Elemento ---"
        'Agrega la fila al datatable
        'dt.Rows.InsertAt(dr, 0)

        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CTPSBS = objDataRow("CTPSBS")
            objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim()
            lbeSubServicio.Add(objEntidad)
        Next

        Return lbeSubServicio
    End Function

    Public Function Listar_UnidadMedida_Combo() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeUnidadMedida As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UNIDADES", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CUNDMD = objDataRow("CUNDMD").ToString.Trim()
            objEntidad.TCMPUN = objDataRow("TCMPUN").ToString.Trim()
            lbeUnidadMedida.Add(objEntidad)
        Next
        Return lbeUnidadMedida
    End Function

    Public Function Listar_Localidad_Origen() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        Dim objEntidad As ClaseGeneral
        Dim lbeLocOrigen As New List(Of ClaseGeneral)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LOCALIDADES", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CLCLD = objDataRow("CLCLD")
            objEntidad.TCMLCL = objDataRow("TCMLCL").ToString.Trim()
            lbeLocOrigen.Add(objEntidad)
        Next
        Return lbeLocOrigen
    End Function

    Public Function Listar_Moneda() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeLocOrigen As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_MONEDA", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CMNDA1 = objDataRow("CMNDA1")
            objEntidad.TMNDA = objDataRow("TMNDA").ToString.Trim()
            lbeLocOrigen.Add(objEntidad)
        Next
        Return lbeLocOrigen
    End Function

    Public Function Listar_Ubigeo() As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objEntidad As ClaseGeneral
        Dim lbeUbigeo As New List(Of ClaseGeneral)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UBICACION_GEOGRAFICA", Nothing)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.UBIGEO = objDataRow("UBIGEO")
            objEntidad.DESCRIPCION = objDataRow("DESCRIPCION").ToString.Trim()
            lbeUbigeo.Add(objEntidad)
        Next
        Return lbeUbigeo
    End Function

    Public Function Listar_Logica_Facturacion(ByVal strNegocio As String) As List(Of ClaseGeneral)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim objEntidad As ClaseGeneral
        Dim lbeLogFac As New List(Of ClaseGeneral)
        lobjParams.Add("PSCCRGVTA", strNegocio)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_LOGICA_FACTURACION", lobjParams)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CODIGO_LF = objDataRow("CODIGO_LF")
            objEntidad.FORMULA_LF = objDataRow("FORMULA_LF").ToString.Trim()
            objEntidad.NOMBRE_LF = objDataRow("NOMBRE_LF").ToString.Trim()
            objEntidad.DESCRIPCION_LF = objDataRow("DESCRIPCION_LF").ToString.Trim()
            lbeLogFac.Add(objEntidad)
        Next
        Return lbeLogFac
    End Function


    Public Function intInsertarUsuarioReversionProvision(ByVal obeGeneral As ClaseGeneral) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter
            objParam.Add("PSCCMPRN", obeGeneral.USUARIO)
            objParam.Add("PSCUSCRT", obeGeneral.CUSCRT)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_INSERTAR_USUARIO_REVERSION_PROVISION", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function intActualizarUsuarioReversionProvision(ByVal obeGeneral As ClaseGeneral) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter
            objParam.Add("PSCCMPRN", obeGeneral.USUARIO)
            objParam.Add("PSSMARCA", obeGeneral.ESTADO)
            objParam.Add("PSCULUSA", obeGeneral.CULUSA)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_ACTUALIZAR_USUARIO_REVERSION_PROVISION", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function dtListarUsuarioReversionProvision(ByVal obeGeneral As ClaseGeneral) As DataTable
        Dim oDt As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPRN", obeGeneral.USUARIO)
        oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_USUARIO_REVERSION_PROVISION", objParam)

        'Catch ex As Exception
        'End Try
        Return oDt
    End Function

    Public Function ListaTipoDeAlmacen() As List(Of ClaseGeneral)
        Dim objParam As New Parameter
        'Try
        Return Listar("SP_SOLMIN_SA_LISTA_TIPO_ALMACEN", objParam)
        'Catch ex As Exception
        '    Return New List(Of ClaseGeneral)
        'End Try
    End Function

    Public Function ListaTipoDeMaterial() As List(Of ClaseGeneral)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCODVAR", "TIPMAT")
            objParam.Add("PSTTPOMR", "")
            Return Listar("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", objParam)
        Catch ex As Exception
            Return New List(Of ClaseGeneral)
        End Try
    End Function
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidades.mantenimientos.ClaseGeneral)

    End Sub

    '<[AHM]>
    Public Function Listar_Tipo_Servicio_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCDSRSP", PSCDSRSP)

        Return Listar("SP_SOLMIN_CT_LISTA_TIPO_SERVICIO_SAP", objParam)
        'Catch ex As Exception
        '    Return New List(Of ClaseGeneral)
        'End Try
    End Function

    Public Function Listar_Tipo_UnidadProductiva_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCDSRSP", PSCDSRSP)

        Return Listar("SP_SOLMIN_CT_LISTA_UNIDAD_PRODUCTIVA_SAP", objParam)
        'Catch ex As Exception
        '    Return New List(Of ClaseGeneral)
        'End Try
    End Function

    Public Function Listar_Tipo_UnidadProductiva_SAP_SEDEMACRO(ByVal PSCDSRSP As String, ByVal PSCDSPSP As String) As List(Of ClaseGeneral)
        Dim objParam As New Parameter
        'Try

        objParam.Add("PSCDSRSP", PSCDSRSP)
        objParam.Add("PSCDSPSP", PSCDSPSP)

        Return Listar("SP_SOLMIN_CT_LISTA_UNIDAD_PRODUCTIVA_SAP_X_SEDE_MACRO", objParam)
        'Catch ex As Exception
        '    Return New List(Of ClaseGeneral)
        'End Try
    End Function



    Public Function Listar_Tipo_Activo_SAP() As List(Of ClaseGeneral)
        Dim objParam As New Parameter
        'Try
        Return Listar("SP_SOLMIN_CT_LISTA_TIPO_ACTIVO_SAP", objParam)
        'Catch ex As Exception
        '    Return New List(Of ClaseGeneral)
        'End Try
    End Function
    '</[AHM]>
	 'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Public Function Listar_Datos_Estructura_Cebe()
        'Try
        Dim ds As DataSet
        Dim lobjSql As New SqlManager

        Dim objParam As New Parameter


        ds = lobjSql.ExecuteDataSet("SP_SOLCT_LISTA_DATOS_ESTRUCTURA_CEBE", objParam)
        Return ds
        'Catch ex As Exception
        '    Return New List(Of ClaseGeneral)
        'End Try
    End Function

    Public Function Buscar_CeCo2(ByVal objCentroCosto As CentroCosto) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lbeLogFac As New List(Of ClaseGeneral)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", objCentroCosto.PSCCMPN)
        objParam.Add("PNCCNTCS", objCentroCosto.PNCCNTCS)
        objParam.Add("PSCCNCOS", objCentroCosto.PSCCNCOS)
        objParam.Add("PSCDSRSP", objCentroCosto.PSCDSRSP)
        objParam.Add("PSCDSPSP", objCentroCosto.PSCDSPSP)
        objParam.Add("PSCDUPSP", objCentroCosto.PSCDUPSP)
        objParam.Add("PSCDSCSP", objCentroCosto.PSCDSCSP)
        objParam.Add("PSTCNTCS", objCentroCosto.PSTCNTCS)
        objParam.Add("PSCDTASP", objCentroCosto.PSCDTASP)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_BUSCAR_CECO", objParam)

        Return dt
    End Function
 
    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

    Public Function Buscar_CeBe(ByVal objImput As beImputCeBe) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim output As New DataTable
        'Try
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", objImput.CodCompania)
        parameter.Add("PSCRGVTA", objImput.CodRegionVentaSAP)
        parameter.Add("PSCDSRSP", objImput.CodMacroServicioSAP)
        parameter.Add("PSCDTSSP", objImput.CodTipoServicioSAP)
        parameter.Add("PSCDTASP", objImput.CodTipoActivoSAP)
        parameter.Add("PSCDSPSP", objImput.CodSedeSAP)
        parameter.Add("PSCDUPSP", objImput.CodUnidadProdcutivaSAP)
        parameter.Add("PSCDTPCE", objImput.TipoCentroSAP)

        parameter.Add("PNCCNTCS", objImput.Codigo)
        parameter.Add("PSTCNTCS", objImput.Descripcion)
        parameter.Add("PSCCNBNS", objImput.CodigoSAP)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CENTRO_BENEFICIO_SALM", parameter)

        'Catch ex As Exception
        '    output = Nothing
        'End Try

        Return output
    End Function

    Public Function Buscar_CeCo(ByVal objImput As beImputCeCo) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim output As New DataTable
        'Try
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PSCCMPN", objImput.CCMPN)
        parameter.Add("PNCCNTBN", objImput.CODCEBE)

        parameter.Add("PNCCNTCS", objImput.Codigo)
        parameter.Add("PSTCNTCS", objImput.Descripcion)
        parameter.Add("PSCCNCOS", objImput.CodigoSAP)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_CECO_X_CEBE_SALM", parameter)

        'Catch ex As Exception
        '    output = Nothing
        'End Try

        Return output
    End Function




    Public Function Listar_Autorizacion_Liquidacion_Opcion(ByVal obeGeneral As ClaseGeneral) As DataTable
        Dim output As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PARAM_MMCAPL", obeGeneral.MMCAPL)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_AUTO_LIQUI_OPCION", parameter)
        Return output
    End Function
    Public Function Listar_Autorizacion_Usuario(ByVal obeGeneral As ClaseGeneral) As DataTable
        Dim output As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PARAM_MMCAPL", obeGeneral.MMCAPL)
        parameter.Add("PARAM_NCROPC ", obeGeneral.NCROPC)
        parameter.Add("PARAM_MMCUSR ", obeGeneral.MMCUSR)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_AUTORIZACION_USUARIO", parameter)


        Return output
    End Function
    Public Function Listar_Registro_Autorizacion(ByVal obeGeneral As ClaseGeneral) As DataTable
        Dim output As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PARAM_MMCAPL", obeGeneral.MMCAPL)
        parameter.Add("PARAM_NCROPC ", obeGeneral.NCROPC)
        parameter.Add("PARAM_MMCUSR ", obeGeneral.MMCUSR)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_REGI_AUTO", parameter)
        Return output
    End Function

    Public Function Listar_Opciones_Autorizacion(ByVal obeGeneral As ClaseGeneral) As DataTable
        Dim output As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PARAM_MMCAPL", obeGeneral.MMCAPL)
        parameter.Add("PARAM_NCROPC ", obeGeneral.NCROPC)
        'parameter.Add("PARAM_MMCUSR ", obeGeneral.MMCUSR)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_OPCIONES_AUTORIZACION", parameter)
        Return output
    End Function


    Public Function Asignar_autorizacion_usuario(ByVal obeGeneral As ClaseGeneral) As String
        Dim output As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PARAM_MMCUSR", obeGeneral.MMCUSR)
        parameter.Add("PARAM_MMCAPL", obeGeneral.MMCAPL)
        parameter.Add("PARAM_NCROPC", obeGeneral.NCROPC)
        parameter.Add("PARAM_CODACC", obeGeneral.CODACC)
        parameter.Add("PARAM_NTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        parameter.Add("PARAM_CUSCRT", ConfigurationWizard.UserName)
        'parameter.Add("PARAM_CHKAUT", obeGeneral.CHKAUT)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_ASIGNAR_AUTORIZACION_USUARIO", parameter)

        Dim msg As String = ""
        For Each item As DataRow In output.Rows
            If item("STATUS").ToString = "E" Then
                msg = msg & item("OBSRESULT").ToString
            End If
        Next

        'If output.Rows.Count <> 0 Then
        '    If (output.Rows(0)("STATUS").ToString = "E") Then
        '        '    obeGeneral.EsValida = True
        '        'Else
        '        '    obeGeneral.EsValida = False
        '        msg=msg & 
        '    End If
        '    obeGeneral.Observaciones = output.Rows(0)("OBSRESULT").ToString
        '    Return obeGeneral.EsValida
        'Else
        '    obeGeneral.EsValida = False
        '    obeGeneral.Observaciones = "No se obtuvo una respuesta "
        'End If
        Return msg

    End Function


    Public Function Eliminar_autorizacion_usuario(ByVal obeGeneral As ClaseGeneral) As String
        Dim output As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PARAM_MMCUSR", obeGeneral.MMCUSR)
        parameter.Add("PARAM_MMCAPL", obeGeneral.MMCAPL)
        parameter.Add("PARAM_NCROPC", obeGeneral.NCROPC)
        parameter.Add("PARAM_CODACC", obeGeneral.CODACC)
        parameter.Add("PARAM_NTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        parameter.Add("PARAM_CUSCRT", ConfigurationWizard.UserName)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_ELIMINAR_AUTORIZACION_USUARIO", parameter)

        Dim msg As String = ""
        For Each item As DataRow In output.Rows
            If item("STATUS").ToString = "E" Then
                msg = msg & item("OBSRESULT").ToString
            End If
        Next
 
        Return msg

    End Function






End Class
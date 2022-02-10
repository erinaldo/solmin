Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef
Imports RANSA.TYPEDEF.GuiaRemision

Public Class cGuiaRemision
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region

#Region " Métodos "
    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información de la Orden de Compra
    ''' </summary>
    Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal oGuiaRemision As TD_GuiaRemision, ByVal strUsuario As String, _
                                  ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oGuiaRemision.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", oGuiaRemision.pNORCML_NroOrdenCompra)
            .Add("IN_TPOOCM", oGuiaRemision.pTPOOCM_TipoOC)
            .Add("IN_CPRVCL", oGuiaRemision.pCPRVCL_CodigoClienteTercero)
            .Add("IN_FORCML", oGuiaRemision.pFORCML_FechaOCInt)
            .Add("IN_FSOLIC", oGuiaRemision.pFSOLIC_FechaSolicOCInt)
            .Add("IN_TDSCML", oGuiaRemision.pTDSCML_Descripcion)
            .Add("IN_TCMAEM", oGuiaRemision.pTCMAEM_DescAreaEmpresa)
            .Add("IN_TTINTC", oGuiaRemision.pTTINTC_TerminoIntern)
            .Add("IN_NREFCL", oGuiaRemision.pNREFCL_ReferenciaCliente)
            .Add("IN_TPAGME", oGuiaRemision.pTPAGME_TerminoPago)
            .Add("IN_REFDO1", oGuiaRemision.pREFDO1_ReferenciaDocumento)
            .Add("IN_NTPDES", oGuiaRemision.pNTPDES_Prioridad)
            .Add("IN_CMNDA1", oGuiaRemision.pCMNDA1_Moneda)
            .Add("IN_TEMPFAC", oGuiaRemision.pTEMPFAC_EmpresaFacturar)
            .Add("IN_TNOMCOM", oGuiaRemision.pTNOMCOM_NombreComprador)
            .Add("IN_TCTCST", oGuiaRemision.pTCTCST_CentroCosto)
            .Add("IN_CREGEMB", oGuiaRemision.pCREGEMB_RegEmbarque)
            .Add("IN_CMEDTR", oGuiaRemision.pCMEDTR_MedioTransporte)
            .Add("IN_TDEFIN", oGuiaRemision.pTDEFIN_DestinoFinal)
            .Add("IN_IVCOTO", oGuiaRemision.pIVCOTO_ImporteCostoTotal)
            .Add("IN_IVTOCO", oGuiaRemision.pIVTOCO_ImporteTotalCompra)
            .Add("IN_IVTOIM", oGuiaRemision.pIVTOIM_ImporteTotalImpuesto)
            .Add("IN_TDAITM", oGuiaRemision.pTDAITM_Observaciones)
            .Add("IN_USUARI", strUsuario)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_RZOL38_INS_V1", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoGuiaRemision >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function



    Public Function ListarServicio(ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal pGUIARANSA As Decimal, ByVal pNGUIRM As Decimal) As DataTable
        Dim odt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSqlManager As New SqlManager
        objParametros.Add("IN_CCLNT", PNCCLNT)
        objParametros.Add("IN_NORCML", PSNORCML)
        objParametros.Add("IN_NRITOC", PNNRITOC)
        objParametros.Add("IN_GUIARANSA", pGUIARANSA)
        'objParametros.Add("IN_NGUIRM", pNGUIRM)
        odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_SOLICITUD_SERVICIO_LM", objParametros)
        Return odt
    End Function





    'Public Shared Function GrabarABB(ByVal objSqlManager As SqlManager, ByVal oGuiaRemision As beGuiaRemision, ByVal strUsuario As String, _
    '                          ByRef strMensajeError As String) As Boolean
    '    Dim objParametros As Parameter = New Parameter
    '    Dim blnResultado As Boolean = True
    '    ' Ingresamos los parametros del Procedure
    '    With objParametros
    '        .Add("IN_CCLNT", oGuiaRemision.PNCCLNT)
    '        .Add("IN_NORCML", oGuiaRemision.PSNORCML)
    '        '.Add("IN_TPOOCM", oGuiaRemision.PSTPOOCM)
    '        '.Add("IN_CPRVCL", oGuiaRemision.PNCPRVCL)
    '        '.Add("IN_FORCML", oGuiaRemision.PNFORCML)
    '        '.Add("IN_FSOLIC", oGuiaRemision.PNFSOLIC)
    '        '.Add("IN_TDSCML", oGuiaRemision.PSTDSCML)
    '        '.Add("IN_TCMAEM", oGuiaRemision.PSTCMAEM)
    '        '.Add("IN_TTINTC", oGuiaRemision.PSTTINTC)
    '        '.Add("IN_NREFCL", oGuiaRemision.PSNREFCL)
    '        '.Add("IN_TPAGME", oGuiaRemision.PSTPAGME)
    '        '.Add("IN_REFDO1", oGuiaRemision.PSREFDO1)
    '        '.Add("IN_NTPDES", oGuiaRemision.PNNTPDES)
    '        '.Add("IN_CMNDA1", oGuiaRemision.PNCMNDA1)
    '        '.Add("IN_TEMPFAC", oGuiaRemision.PSTEMPFAC)
    '        '.Add("IN_TNOMCOM", oGuiaRemision.PSTNOMCOM)
    '        '.Add("IN_TCTCST", oGuiaRemision.PSTCTCST)
    '        '.Add("IN_CREGEMB", oGuiaRemision.PSCREGEMB)
    '        '.Add("IN_CMEDTR", oGuiaRemision.PNCMEDTR)
    '        '.Add("IN_TDEFIN", oGuiaRemision.PSTDEFIN)
    '        '.Add("IN_IVCOTO", oGuiaRemision.PNIVCOTO)
    '        '.Add("IN_IVTOCO", oGuiaRemision.PNIVTOCO)
    '        '.Add("IN_IVTOIM", oGuiaRemision.PNIVTOIM)
    '        '.Add("IN_TDAITM", oGuiaRemision.PSTDAITM)
    '        .Add("IN_USUARI", strUsuario)
    '    End With
    '    Try
    '        strMensajeError = ""

    '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_RZOL38_INS_V1", objParametros)
    '    Catch ex As Exception
    '        strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoGuiaRemision >> " & vbNewLine & _
    '                          "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_INS >> " & vbNewLine & _
    '                          "Motivo del Error : " & ex.Message
    '        blnResultado = False
    '    Finally
    '        objSqlManager = Nothing
    '        objParametros = Nothing
    '    End Try
    '    Return blnResultado
    'End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información de la Orden de Compra a través del Web Services
    ''' </summary>
    Public Shared Function Grabar(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                  ByVal oGuiaRemision As TD_GuiaRemision, ByRef strMensajeError As String) As Boolean
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstResultado As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        Return Grabar(objSqlManager, oGuiaRemision, strUsuario, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de eliminar el registro de la Tabla RZOL38
    ''' </summary>
    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal objGuiaRemisionPK As TD_GuiaRemisionPK, ByVal strUsuario As String, _
                                  ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", objGuiaRemisionPK._PNCCLNT)
            .Add("IN_NORCML", objGuiaRemisionPK._NORCML)
            .Add("IN_USUARI", strUsuario)
            '.Add("IN_NTRMNL", objOrdenCompraPK.pNTRMNL_Terminal)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_RZOL38_DEL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Delete >> de la clase << daoGuiaRemision >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_DEL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Obtener la información del Item en una instancia
    ''' </summary>
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal objGuiaRemisionPK As TD_GuiaRemisionPK, ByRef strMensajeError As String) As TD_GuiaRemision
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        Dim oGuiaRemision As TD_GuiaRemision = New TD_GuiaRemision
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", objGuiaRemisionPK._PNCCLNT)
            .Add("IN_NORCML", objGuiaRemisionPK._NORCML)
            .Add("OU_TDAITM", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_RZOL38_OBJ", objParametros)
            Dim htResultado As Hashtable
            ' Obteniendo los valores devueltos
            htResultado = objSqlManager.ParameterCollection
            If dtTemp.Rows.Count > 0 Then
                Dim dteTemp As Date
                With oGuiaRemision
                    .pCCLNT_CodigoCliente = objGuiaRemisionPK._PNCCLNT
                    .pNORCML_NroOrdenCompra = objGuiaRemisionPK._NORCML
                    Date.TryParse("" & dtTemp.Rows(0).Item("FORCML"), dteTemp)
                    .pFORCML_FechaOCDte = dteTemp
                    Date.TryParse("" & dtTemp.Rows(0).Item("FSOLIC"), dteTemp)
                    .pFSOLIC_FechaSolicOCDte = dteTemp
                    .pTDSCML_Descripcion = ("" & dtTemp.Rows(0).Item("TDSCML")).ToString.Trim
                    .pTCMAEM_DescAreaEmpresa = ("" & dtTemp.Rows(0).Item("TCMAEM")).ToString.Trim
                    .pTTINTC_TerminoIntern = ("" & dtTemp.Rows(0).Item("TTINTC")).ToString.Trim
                    .pNREFCL_ReferenciaCliente = ("" & dtTemp.Rows(0).Item("NREFCL")).ToString.Trim
                    .pTPAGME_TerminoPago = ("" & dtTemp.Rows(0).Item("TPAGME")).ToString.Trim
                    .pREFDO1_ReferenciaDocumento = ("" & dtTemp.Rows(0).Item("REFDO1")).ToString.Trim
                    .pNTPDES_Prioridad = dtTemp.Rows(0).Item("NTPDES")
                    .pCPRVCL_CodigoClienteTercero = dtTemp.Rows(0).Item("CPRVCL")
                    .pCMNDA1_Moneda = dtTemp.Rows(0).Item("CMNDA1")
                    .pTEMPFAC_EmpresaFacturar = ("" & dtTemp.Rows(0).Item("TEMPFAC")).ToString.Trim
                    .pTNOMCOM_NombreComprador = ("" & dtTemp.Rows(0).Item("TNOMCOM")).ToString.Trim
                    .pTCTCST_CentroCosto = ("" & dtTemp.Rows(0).Item("TCTCST")).ToString.Trim
                    .pCREGEMB_RegEmbarque = ("" & dtTemp.Rows(0).Item("CREGEMB")).ToString.Trim
                    .pCMEDTR_MedioTransporte = dtTemp.Rows(0).Item("CMEDTR")
                    .pTDEFIN_DestinoFinal = ("" & dtTemp.Rows(0).Item("TDEFIN")).ToString.Trim
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("IVCOTO"), .pIVCOTO_ImporteCostoTotal)
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("IVTOCO"), .pIVTOCO_ImporteTotalCompra)
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("IVTOIM"), .pIVTOIM_ImporteTotalImpuesto)
                    .pTPOOCM_TipoOC = ("" & dtTemp.Rows(0).Item("TPOOCM")).ToString.Trim
                    .pTCNDPG_CondicionPago = ("" & dtTemp.Rows(0).Item("TCNDPG")).ToString.Trim
                    .pTRSCN_NombreContacto = ("" & dtTemp.Rows(0).Item("TPRSCN")).ToString.Trim
                    .pTLFNO2_TelefonoContacto = ("" & dtTemp.Rows(0).Item("TLFNO2")).ToString.Trim
                    .pTEMAI3_EmailContacto = ("" & dtTemp.Rows(0).Item("TEMAI3")).ToString.Trim
                    .pTDAITM_Observaciones = ("" & htResultado("OU_TDAITM")).ToString.Trim

                End With
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoGuiaRemision >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return oGuiaRemision
    End Function


    ''' <summary>
    ''' Listado de Órdenes de Compras en Formato L01 para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    'Public Shared Function fdtListar_GuiaRemision_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_QRY_GuiaRemision_L01, _
    '                                                  ByRef intNroTotalPaginas As Int32, ByRef strMensajeError As String, value As Boolean) As DataTable
    Public Shared Function fdtListar_GuiaRemision_L01(ByVal TD_Filtro As TD_QRY_GuiaRemision_L01, _
                                                    ByRef intNroTotalPaginas As Int32   ) As DataTable
        'Dim ds As New DataSet
        Dim dt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSqlManager As New SqlManager
        With objParametros
            .Add("PSCCMPN", TD_Filtro.PSCCMPN)
            .Add("PSCDVSN", TD_Filtro.PSCDVSN)
            .Add("PNCPLNDV", TD_Filtro.PNCPLNDV)
            .Add("PNCCLNT", TD_Filtro.PNCCLNT)
            .Add("PNGUISL", TD_Filtro.GUIASALIDA)
            .Add("PNGUIRM", TD_Filtro.NGUIRM)
            .Add("PFGUIRM1", TD_Filtro.pFGUIRM_FechaGR_Inicio)
            .Add("PFGUIRM2", TD_Filtro.pFGUIRM_FechaGR_Fin)
            '.Add("PAGESIZE", TD_Filtro.PAGESIZE)
            '.Add("PAGENUMBER", TD_Filtro.PAGENUMBER)
          
        End With
        'ds = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_GR_RZIM36", objParametros) 'Cambiar
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GR_RZIM36", objParametros) 'Cambiar

        'Dim dtPag As New DataTable
        'Dim dtresult As New DataTable
        'dtPag = ds.Tables(0)
        'dtresult = ds.Tables(1)
        'If dtPag.Rows.Count > 0 Then
        '    intNroTotalPaginas = dtPag.Rows(0)("OBSRESULT")
        'End If
        'dtresult = ds.Tables(0)
        For Each Item As DataRow In dt.Rows
            Item("FGUIRM") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(("" & Item("FGUIRM")))
        Next
       
        Return dt
    End Function

    Public Shared Function fdtListar_Reporte_Por_GR(ByVal TD_Filtro As TD_QRY_GuiaRemision_L01) As DataTable

        Dim dtTemp As DataTable
        Dim objSqlManager As New SqlManager
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure

        With objParametros
            .Add("PSCCMPN", TD_Filtro.PSCCMPN)
            .Add("PSCDVSN", TD_Filtro.PSCDVSN)
            .Add("PNCPLNDV", TD_Filtro.PNCPLNDV)
            .Add("PNCCLNT", TD_Filtro.PNCCLNT)
            .Add("PNGUISL", 0)
            .Add("PNGUIRM", TD_Filtro.NGUIRM)
            .Add("PFGUIRM1", TD_Filtro.pFGUIRM_FechaGR_Inicio)
            .Add("PFGUIRM2", TD_Filtro.pFGUIRM_FechaGR_Fin)
            'If value = True Then
            '    .Add("PFGUIRM1", TD_Filtro.pFGUIRM_FechaGR_Inicio)
            '    .Add("PFGUIRM2", TD_Filtro.pFGUIRM_FechaGR_Fin)
            'End If
        End With

        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GR_RZIM36_REP", objParametros)

        For Each item As DataRow In dtTemp.Rows
            item("FGUIRM") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(("" & item("FGUIRM")))
        Next

        'FGUIRM


        'Try
        '    If value = True Then
        '        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GR_RZIM36_REP_FECHA", objParametros) 'Cambiar
        '    Else
        '        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GR_RZIM36_REP", objParametros) 'Cambiar
        '    End If

        '    strMensajeError = ""

        '    Dim htResultado As Hashtable
        '    htResultado = objSqlManager.ParameterCollection

        'Catch ex As Exception
        '    dtTemp = New DataTable
        '    strMensajeError = "Error producido en la funcion : << fdtListar_GuiaRemision_L01 >> de la clase << daoGuiaRemision >> " & vbNewLine & _
        '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_L01 >> " & vbNewLine & _
        '                      "Motivo del Error : " & ex.Message
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
        Return dtTemp
    End Function






    Public Shared Function FechaNum_a_Fecha(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Left(FechaNum, 4).PadLeft(2, "0")
            m = Right(Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Right(FechaNum, 2).PadLeft(2, "0")
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function

#End Region





End Class

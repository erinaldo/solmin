Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra




Public Class cOrdenCompra
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
    Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal oOrdenCompra As TD_OrdenCompra, ByVal strUsuario As String, _
                                  ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oOrdenCompra.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", oOrdenCompra.pNORCML_NroOrdenCompra)
            .Add("IN_TPOOCM", oOrdenCompra.pTPOOCM_TipoOC)
            .Add("IN_CPRVCL", oOrdenCompra.pCPRVCL_CodigoClienteTercero)
            .Add("IN_FORCML", oOrdenCompra.pFORCML_FechaOCInt)
            .Add("IN_FSOLIC", oOrdenCompra.pFSOLIC_FechaSolicOCInt)
            .Add("IN_TDSCML", oOrdenCompra.pTDSCML_Descripcion)
            .Add("IN_TCMAEM", oOrdenCompra.pTCMAEM_DescAreaEmpresa)
            .Add("IN_TTINTC", oOrdenCompra.pTTINTC_TerminoIntern)
            .Add("IN_NREFCL", oOrdenCompra.pNREFCL_ReferenciaCliente)
            .Add("IN_TPAGME", oOrdenCompra.pTPAGME_TerminoPago)
            .Add("IN_REFDO1", oOrdenCompra.pREFDO1_ReferenciaDocumento)
            .Add("IN_NTPDES", oOrdenCompra.pNTPDES_Prioridad)
            .Add("IN_CMNDA1", oOrdenCompra.pCMNDA1_Moneda)
            .Add("IN_TEMPFAC", oOrdenCompra.pTEMPFAC_EmpresaFacturar)
            .Add("IN_TNOMCOM", oOrdenCompra.pTNOMCOM_NombreComprador)
            .Add("IN_TCTCST", oOrdenCompra.pTCTCST_CentroCosto)
            .Add("IN_CREGEMB", oOrdenCompra.pCREGEMB_RegEmbarque)
            .Add("IN_CMEDTR", oOrdenCompra.pCMEDTR_MedioTransporte)
            .Add("IN_TDEFIN", oOrdenCompra.pTDEFIN_DestinoFinal)
            .Add("IN_IVCOTO", oOrdenCompra.pIVCOTO_ImporteCostoTotal)
            .Add("IN_IVTOCO", oOrdenCompra.pIVTOCO_ImporteTotalCompra)
            .Add("IN_IVTOIM", oOrdenCompra.pIVTOIM_ImporteTotalImpuesto)
            .Add("IN_TDAITM", oOrdenCompra.pTDAITM_Observaciones)
            .Add("IN_USUARI", strUsuario)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_RZOL38_INS_V1", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoOrdenCompra >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    Public Shared Function GrabarABB(ByVal objSqlManager As SqlManager, ByVal oOrdenCompra As beOrdenCompra, ByVal strUsuario As String, _
                              ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oOrdenCompra.PNCCLNT)
            .Add("IN_NORCML", oOrdenCompra.PSNORCML)
            .Add("IN_TPOOCM", oOrdenCompra.PSTPOOCM)
            .Add("IN_CPRVCL", oOrdenCompra.PNCPRVCL)
            .Add("IN_FORCML", oOrdenCompra.PNFORCML)
            .Add("IN_FSOLIC", oOrdenCompra.PNFSOLIC)
            .Add("IN_TDSCML", oOrdenCompra.PSTDSCML)
            .Add("IN_TCMAEM", oOrdenCompra.PSTCMAEM)
            .Add("IN_TTINTC", oOrdenCompra.PSTTINTC)
            .Add("IN_NREFCL", oOrdenCompra.PSNREFCL)
            .Add("IN_TPAGME", oOrdenCompra.PSTPAGME)
            .Add("IN_REFDO1", oOrdenCompra.PSREFDO1)
            .Add("IN_NTPDES", oOrdenCompra.PNNTPDES)
            .Add("IN_CMNDA1", oOrdenCompra.PNCMNDA1)
            .Add("IN_TEMPFAC", oOrdenCompra.PSTEMPFAC)
            .Add("IN_TNOMCOM", oOrdenCompra.PSTNOMCOM)
            .Add("IN_TCTCST", oOrdenCompra.PSTCTCST)
            .Add("IN_CREGEMB", oOrdenCompra.PSCREGEMB)
            .Add("IN_CMEDTR", oOrdenCompra.PNCMEDTR)
            .Add("IN_TDEFIN", oOrdenCompra.PSTDEFIN)
            .Add("IN_IVCOTO", oOrdenCompra.PNIVCOTO)
            .Add("IN_IVTOCO", oOrdenCompra.PNIVTOCO)
            .Add("IN_IVTOIM", oOrdenCompra.PNIVTOIM)
            .Add("IN_TDAITM", oOrdenCompra.PSTDAITM)
            .Add("IN_USUARI", strUsuario)
        End With
        Try
            strMensajeError = ""

            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_RZOL38_INS_V1", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoOrdenCompra >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información de la Orden de Compra a través del Web Services
    ''' </summary>
    Public Shared Function Grabar(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                  ByVal oOrdenCompra As TD_OrdenCompra, ByRef strMensajeError As String) As Boolean
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstResultado As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        Return Grabar(objSqlManager, oOrdenCompra, strUsuario, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de eliminar el registro de la Tabla RZOL38
    ''' </summary>
    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal objOrdenCompraPK As TD_OrdenCompraPK, ByVal strUsuario As String, _
                                  ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", objOrdenCompraPK.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", objOrdenCompraPK.pNORCML_NroOrdenCompra)
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
            strMensajeError = "Error producido en la funcion : << Delete >> de la clase << daoOrdenCompra >> " & vbNewLine & _
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
    ''' 
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal objOrdenCompraPK As TD_OrdenCompraPK, ByRef strMensajeError As String) As TD_OrdenCompra
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        Dim oOrdenCompra As TD_OrdenCompra = New TD_OrdenCompra
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", objOrdenCompraPK.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", objOrdenCompraPK.pNORCML_NroOrdenCompra)
            '.Add("OU_TDAITM", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_RZOL38_OBJ", objParametros)
            Dim htResultado As Hashtable
            ' Obteniendo los valores devueltos
            htResultado = objSqlManager.ParameterCollection
            Dim pfecha As String = ""
            If dtTemp.Rows.Count > 0 Then
                Dim dteTemp As Date
                With oOrdenCompra
                    .pCCLNT_CodigoCliente = objOrdenCompraPK.pCCLNT_CodigoCliente
                    .pNORCML_NroOrdenCompra = objOrdenCompraPK.pNORCML_NroOrdenCompra
                    'Date.TryParse("" & dtTemp.Rows(0).Item("FORCML"), dteTemp)
                    pfecha = FechaNum_a_Fecha(dtTemp.Rows(0).Item("FORCML"))
                    Date.TryParse(pfecha, dteTemp)
                    .pFORCML_FechaOCDte = dteTemp

                    'Date.TryParse("" & dtTemp.Rows(0).Item("FSOLIC"), dteTemp)
                    pfecha = FechaNum_a_Fecha(dtTemp.Rows(0).Item("FSOLIC"))
                    .pFSOLIC_FechaSolicOCstr = pfecha
                    If pfecha = "" Then
                        .pFSOLIC_FechaSolicOCDte = Nothing
                    Else

                        Date.TryParse(pfecha, dteTemp)
                        .pFSOLIC_FechaSolicOCDte = dteTemp
                    End If
                   
                    '.pFSOLIC_FechaSolicOCDte = pfecha
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
                    '.pTDAITM_Observaciones = ("" & htResultado("OU_TDAITM")).ToString.Trim
                    .pTDAITM_Observaciones = ("" & dtTemp.Rows(0).Item("OU_TDAITM")).ToString.Trim
                    .pTPRVCL_Proveedor = ("" & dtTemp.Rows(0).Item("TPRVCL")).ToString.Trim

                End With
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoOrdenCompra >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return oOrdenCompra
    End Function
 

    ''' <summary>
    ''' Listado de Órdenes de Compras en Formato L01 para ser utilizadas en un DataGrid con opciones de Paginación
    ''' </summary>
    Public Shared Function fdtListar_OrdenCompras_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Qry_OrdenCompra_L01, _
                                                      ByRef intNroTotalPaginas As Int32, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
            .Add("IN_CPRVCL", TD_Filtro.pCPRVCL_Proveedor)
            .Add("IN_TDSCML", TD_Filtro.pTDSCML_DescripcionOC)
            .Add("IN_FORCML_INI", TD_Filtro.pFORCML_FechaOC_Inicio_FNum)
            .Add("IN_FORCML_FIN", TD_Filtro.pFORCML_FechaOC_Final_FNum)
            .Add("IN_TTINTC", TD_Filtro.pTTINTC_TermInterCarga)
            .Add("IN_CMEDTR", TD_Filtro.pCMEDTR_MedioTransporte)
            .Add("IN_NREFCL", TD_Filtro.pNREFCL_ReferenciaCliente)
            .Add("IN_REFDO1", TD_Filtro.pREFDO1_ReferenciaDocumento)
            .Add("IN_NTPDES", TD_Filtro.pNTPDES_Prioridad)
            .Add("IN_SITUOC", TD_Filtro.pSITUOC_SituacionOC)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""

            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_RZOL38_L01", objParametros)

            For Each Item As DataRow In dtTemp.Rows
                Item("NORCML") = ("" & Item("NORCML")).ToString.Trim
                Item("TPOOCM") = ("" & Item("TPOOCM")).ToString.Trim
                Item("TPRVCL") = ("" & Item("TPRVCL")).ToString.Trim
                Item("TPRSCN") = ("" & Item("TPRSCN")).ToString.Trim
                Item("TLFNO2") = ("" & Item("TLFNO2")).ToString.Trim
                Item("TEMAI3") = ("" & Item("TEMAI3")).ToString.Trim
                Item("CMNDA1") = ("" & Item("CMNDA1")).ToString.Trim
                Item("TTINTC") = ("" & Item("TTINTC")).ToString.Trim
                Item("REFDO1") = ("" & Item("REFDO1")).ToString.Trim
                Item("SESTRG") = ("" & Item("SESTRG")).ToString.Trim
                Item("TPAGME") = ("" & Item("TPAGME")).ToString.Trim
                Item("NREFCL") = ("" & Item("NREFCL")).ToString.Trim
                Item("TPRVCL") = ("" & Item("TPRVCL")).ToString.Trim
                Item("TDEFIN") = ("" & Item("TDEFIN")).ToString.Trim
                Item("NTPDES") = ("" & Item("NTPDES")).ToString.Trim
                Item("TDSCML") = ("" & Item("TDSCML")).ToString.Trim
                Item("NRUCPR") = ("" & Item("NRUCPR")).ToString.Trim
                Item("SFLGES") = ("" & Item("SFLGES")).ToString.Trim
                Item("FORCML") = FechaNum_a_Fecha(Item("FORCML"))


            Next

            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            strMensajeError = "Error producido en la funcion : << fdtListar_OrdenCompras_L01 >> de la clase << daoOrdenCompra >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_RZOL38_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
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
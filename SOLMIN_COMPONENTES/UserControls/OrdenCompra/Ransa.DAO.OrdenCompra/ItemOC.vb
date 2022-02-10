Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef

Public Class cItemOrdenCompra
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información del Item en una instancia
    ''' </summary>
    Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal TD_ItemOC As TD_ItemOC, ByVal strUsuario As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter

        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_ItemOC.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", TD_ItemOC.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", TD_ItemOC.pNRITOC_NroItemOC)
            .Add("IN_TCITCL", TD_ItemOC.pTCITCL_CodigoCliente)
            .Add("IN_TCITPR", TD_ItemOC.pTCITPR_CodigoProveedor)
            .Add("IN_TDITES", TD_ItemOC.pTDITES_DescripcionES)
            .Add("IN_TDITIN", TD_ItemOC.pTDITIN_DescripcionIN)
            .Add("IN_CPTDAR", TD_ItemOC.pCPTDAR_PartidaArancelaria)
            .Add("IN_QCNTIT", TD_ItemOC.pQCNTIT_Cantidad)
            .Add("IN_TUNDIT", TD_ItemOC.pTUNDIT_Unidad)
            .Add("IN_IVUNIT", TD_ItemOC.pIVUNIT_ImporteUnitario)
            .Add("IN_IVTOIT", TD_ItemOC.pIVTOIT_ImporteTotal)
            .Add("IN_QTOLMIN", TD_ItemOC.pQTOLMIN_ToleranciaMin)
            .Add("IN_QTOLMAX", TD_ItemOC.pQTOLMAX_ToleranciaMax)
            .Add("IN_FMPDME", TD_ItemOC.pFMPDME_FechaEstEntregaInt)
            .Add("IN_FMPIME", TD_ItemOC.pFMPIME_FechaReqPlantaInt)
            .Add("IN_TLUGOR", TD_ItemOC.pTLUGOR_LugarOrigen)
            If TD_ItemOC.pTLUGEN_LugarEntrega.Trim.Length > 50 Then
                .Add("IN_TLUGEN", TD_ItemOC.pTLUGEN_LugarEntrega.Substring(0, 50))
            Else
                .Add("IN_TLUGEN", TD_ItemOC.pTLUGEN_LugarEntrega)
            End If
            Dim strLugarEntrega As String = TD_ItemOC.pTLUGEN_LugarEntrega.Trim
            .Add("IN_TCTCST", TD_ItemOC.pTCTCST_CentroDeCosto)
            .Add("IN_TRFRN", TD_ItemOC.pTRFRN_RefSolicitante)
            .Add("IN_FLGPEN", TD_ItemOC.pFLGPEN_FlagSeguimiento)
            '-- Seguridad
            .Add("IN_USUARIO", strUsuario)
            '.Add("IN_NTRMNL", TD_ItemOC.pNTRMNL_NrTerminal)
            'miguel 27012015

            ' .Add("IN_PTRFRNA", TD_ItemOC.PTRFRNA_RefA)
            .Add("IN_PTRFRNB", TD_ItemOC.PTRFRNB_RefB)
            .Add("IN_PTRFRN1", TD_ItemOC.PTRFRN1_CentroDestino)
            .Add("IN_PTRFRN2", TD_ItemOC.PTRFRN2_AlmDestino)
            .Add("IN_PTRFRN3", TD_ItemOC.PTRFRN3_Ref3)
            .Add("IN_PTRFRN4", TD_ItemOC.PTRFRN4_AlmProcedencia)
            .Add("IN_PTRFRN5", TD_ItemOC.PTRFRN5_Direccion5)
            .Add("IN_PTRFRN6", TD_ItemOC.PTRFRN6_ClaseValoracion)
            .Add("IN_UNSPSC", TD_ItemOC.pUNSPSC_Sunat)

        End With
        Try
            strMensajeError = ""

            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_ITEM_RZOL39_INS_V2", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoOrdenCompraItem >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function


    Public Shared Function GrabarABB(ByVal objSqlManager As SqlManager, ByVal oOrdenCompra As beOrdenCompra, ByVal strUsuario As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter

        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oOrdenCompra.PNCCLNT)
            .Add("IN_NORCML", oOrdenCompra.PSNORCML)
            .Add("IN_NRITOC", oOrdenCompra.PNNRITOC)
            .Add("IN_TCITCL", oOrdenCompra.PSTCITCL.Trim.Replace("-!", "-"))
            .Add("IN_TCITPR", oOrdenCompra.PSTCITPR)
            .Add("IN_TDITES", oOrdenCompra.PSTDITES)
            .Add("IN_TDITIN", oOrdenCompra.PSTDITIN)
            .Add("IN_CPTDAR", oOrdenCompra.PSCPTDAR)
            .Add("IN_QCNTIT", oOrdenCompra.PNQCNTIT)
            .Add("IN_TUNDIT", oOrdenCompra.PSTUNDIT)
            .Add("IN_IVUNIT", oOrdenCompra.PNIVUNIT)
            .Add("IN_IVTOIT", oOrdenCompra.PNIVTOIT)
            .Add("IN_QTOLMIN", oOrdenCompra.PNQTOLMIN)
            .Add("IN_QTOLMAX", oOrdenCompra.PNQTOLMAX)
            .Add("IN_FMPDME", oOrdenCompra.PNFMPDME)
            .Add("IN_FMPIME", oOrdenCompra.PNFMPIME)
            .Add("IN_TLUGOR", oOrdenCompra.PSTLUGOR)
            If oOrdenCompra.PSTLUGEN.ToString().Trim().Length > 50 Then
                .Add("IN_TLUGEN", oOrdenCompra.PSTLUGEN.Substring(0, 50))
            Else
                .Add("IN_TLUGEN", oOrdenCompra.PSTLUGEN.ToString().Replace("ø", "Nr").Trim())
            End If
            'Dim strLugarEntrega As String = TD_ItemOC.pTLUGEN_LugarEntrega.Trim
            .Add("IN_TCTCST", oOrdenCompra.PSTCTCST)
            .Add("IN_IN_TRFRN", oOrdenCompra.PSTRFRN)
            .Add("IN_FLGPEN", oOrdenCompra.PSFLGPEN)
            '-- Seguridad
            .Add("IN_USUARIO", strUsuario)
            '.Add("IN_NTRMNL", oOrdenCompra.PSNTRMNL)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_ITEM_RZOL39_INS_V1", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoOrdenCompraItem >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información del Item en una Orden de Compra a través del Web Services
    ''' </summary>
    Public Shared Function Grabar(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                  ByVal TD_ItemOC As TD_ItemOC, ByRef strMensajeError As String) As Boolean
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstResultado As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        Return Grabar(objSqlManager, TD_ItemOC, strUsuario, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de eliminar el registro de la Tabla RZOL39
    ''' </summary>
    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal oItemOC As TD_ItemOCPK, ByVal strUsuario As String, _
                                  ByRef strStatusUltReg As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        strStatusUltReg = "N"
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oItemOC.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", oItemOC.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", oItemOC.pNRITOC_NroItemOC)
            '-- Seguridad
            .Add("IN_USUARI", strUsuario)
            '.Add("IN_NTRMNL", oItemOC.pNTRMNL_Terminal)
            .Add("OU_STULTR", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_OC_ITEM_RZOL39_DEL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strStatusUltReg = htResultado("OU_STULTR").ToString
            strMensajeError = htResultado("OU_MSGERR").ToString
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Delete >> de la clase << daoItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_OC_ITEM_RZOL39_DEL >> " & vbNewLine & _
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
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal oItemPK As TD_ItemOCPK, ByRef strMensajeError As String) As TD_ItemOC
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        Dim oItemOC As TD_ItemOC = New TD_ItemOC
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oItemPK.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", oItemPK.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", oItemPK.pNRITOC_NroItemOC)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_ITEM_RZOL39_OBJ", objParametros)
            If dtTemp.Rows.Count > 0 Then
                Dim dteTemp As Date
                With oItemOC
                    .pCCLNT_CodigoCliente = oItemPK.pCCLNT_CodigoCliente
                    .pNORCML_NroOrdenCompra = oItemPK.pNORCML_NroOrdenCompra
                    .pNRITOC_NroItemOC = oItemPK.pNRITOC_NroItemOC
                    .pTCITCL_CodigoCliente = ("" & dtTemp.Rows(0).Item("TCITCL")).ToString.Trim
                    .pTCITPR_CodigoProveedor = ("" & dtTemp.Rows(0).Item("TCITPR")).ToString.Trim
                    .pTDITES_DescripcionES = ("" & dtTemp.Rows(0).Item("TDITES")).ToString.Trim
                    .pTDITIN_DescripcionIN = ("" & dtTemp.Rows(0).Item("TDITIN")).ToString.Trim
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("QCNTIT"), .pQCNTIT_Cantidad)
                    .pTUNDIT_Unidad = ("" & dtTemp.Rows(0).Item("TUNDIT")).ToString.Trim
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("IVUNIT"), .pIVUNIT_ImporteUnitario)
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("IVTOIT"), .pIVTOIT_ImporteTotal)
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("QTOLMAX"), .pQTOLMAX_ToleranciaMax)
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("QTOLMIN"), .pQTOLMIN_ToleranciaMin)
                    Date.TryParse("" & dtTemp.Rows(0).Item("FMPDME"), dteTemp)
                    .pFMPDME_FechaEstEntregaDte = dteTemp
                    Date.TryParse("" & dtTemp.Rows(0).Item("FMPIME"), dteTemp)
                    .pFMPIME_FechaReqPlantaDte = dteTemp
                    .pTLUGOR_LugarOrigen = ("" & dtTemp.Rows(0).Item("TLUGOR")).ToString.Trim
                    .pTLUGEN_LugarEntrega = ("" & dtTemp.Rows(0).Item("TLUGEN")).ToString.Trim
                    .pTRFRN_RefSolicitante = ("" & dtTemp.Rows(0).Item("TRFRN")).ToString.Trim
                End With
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return oItemOC
    End Function

    ''' <summary>
    ''' Listado de Items de una Orden de Compra en Formato L01 para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtListar_ItemsOC_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_OrdenCompraPK, _
                                                 ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros

            If Not TD_Filtro.pCCMPN_CodCompania.Trim.Equals("") Then
                .Add("IN_CCMPN", TD_Filtro.pCCMPN_CodCompania)
                .Add("IN_CDVSN", TD_Filtro.pCDVSN_CodDivision)
                .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_CodPlanta)
            End If
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
            If Not TD_Filtro.pTDITES_DescripcionItems.Trim.Equals("") Then
                .Add("IN_TDITES", TD_Filtro.pTDITES_DescripcionItems)
            End If
            .Add("PAGESIZE", TD_Filtro.PAGESIZE)
            .Add("PAGENUMBER", TD_Filtro.PAGENUMBER)
            .Add("PAGECOUNT", 0, ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_ITEM_RZOL39_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            TD_Filtro.PAGECOUNT = htResultado("PAGECOUNT")
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_ItemsOC_L01 >> de la clase << daoItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de los Lugares de Entrega del Cliente
    ''' </summary>
    Public Shared Function fdtListar_LugarEntrega(ByVal objSqlManager As SqlManager, ByVal pCCLNT_CodigoCliente As Int64, _
                                                  ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", pCCLNT_CodigoCliente)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_ITEM_RZOL39_L03", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_LugarEntrega_L01 >> de la clase << daoItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_L03 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function
#End Region
End Class
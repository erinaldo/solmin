Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TYPEDEF.GuiaRemision
Imports Ransa.TYPEDEF.ItemGR
Imports Ransa.TYPEDEF
Public Class cItemGuiaRemision
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
    Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal TD_ItemGR As TD_ItemGR, ByVal strUsuario As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter

        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_ItemGR.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", TD_ItemGR.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", TD_ItemGR.pNRITOC_NroItemOC)
            .Add("IN_TCITCL", TD_ItemGR.pTCITCL_CodigoCliente)
            .Add("IN_TCITPR", TD_ItemGR.pTCITPR_CodigoProveedor)
            .Add("IN_TDITES", TD_ItemGR.pTDITES_DescripcionES)
            .Add("IN_TDITIN", TD_ItemGR.pTDITIN_DescripcionIN)
            .Add("IN_CPTDAR", TD_ItemGR.pCPTDAR_PartidaArancelaria)
            .Add("IN_QCNTIT", TD_ItemGR.pQCNTIT_Cantidad)
            .Add("IN_TUNDIT", TD_ItemGR.pTUNDIT_Unidad)
            .Add("IN_IVUNIT", TD_ItemGR.pIVUNIT_ImporteUnitario)
            .Add("IN_IVTOIT", TD_ItemGR.pIVTOIT_ImporteTotal)
            .Add("IN_QTOLMIN", TD_ItemGR.pQTOLMIN_ToleranciaMin)
            .Add("IN_QTOLMAX", TD_ItemGR.pQTOLMAX_ToleranciaMax)
            .Add("IN_FMPDME", TD_ItemGR.pFMPDME_FechaEstEntregaInt)
            .Add("IN_FMPIME", TD_ItemGR.pFMPIME_FechaReqPlantaInt)
            .Add("IN_TLUGOR", TD_ItemGR.pTLUGOR_LugarOrigen)
            If TD_ItemGR.pTLUGEN_LugarEntrega.Trim.Length > 50 Then
                .Add("IN_TLUGEN", TD_ItemGR.pTLUGEN_LugarEntrega.Substring(0, 50))
            Else
                .Add("IN_TLUGEN", TD_ItemGR.pTLUGEN_LugarEntrega)
            End If
            Dim strLugarEntrega As String = TD_ItemGR.pTLUGEN_LugarEntrega.Trim
            .Add("IN_TCTCST", TD_ItemGR.pTCTCST_CentroDeCosto)
            .Add("IN_TRFRN", TD_ItemGR.pTRFRN_RefSolicitante)
            .Add("IN_FLGPEN", TD_ItemGR.pFLGPEN_FlagSeguimiento)
            '-- Seguridad
            .Add("IN_USUARIO", strUsuario)
            '.Add("IN_NTRMNL", TD_ItemOC.pNTRMNL_NrTerminal)
            'miguel 27012015

            ' .Add("IN_PTRFRNA", TD_ItemOC.PTRFRNA_RefA)
            .Add("IN_PTRFRNB", TD_ItemGR.PTRFRNB_RefB)
            .Add("IN_PTRFRN1", TD_ItemGR.PTRFRN1_CentroDestino)
            .Add("IN_PTRFRN2", TD_ItemGR.PTRFRN2_AlmDestino)
            .Add("IN_PTRFRN3", TD_ItemGR.PTRFRN3_Ref3)
            .Add("IN_PTRFRN4", TD_ItemGR.PTRFRN4_AlmProcedencia)
            .Add("IN_PTRFRN5", TD_ItemGR.PTRFRN5_Direccion5)
            .Add("IN_PTRFRN6", TD_ItemGR.PTRFRN6_ClaseValoracion)
            .Add("IN_UNSPSC", TD_ItemGR.pUNSPSC_Sunat)

        End With
        Try
            strMensajeError = ""

            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_ITEM_RZOL39_INS_V2", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoGuiaRemisionItem >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function


    Public Shared Function GrabarABB(ByVal objSqlManager As SqlManager, ByVal oGuiaRemision As beGuiaRemision, ByVal strUsuario As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter

        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oGuiaRemision.PNCCLNT)
            .Add("IN_NORCML", oGuiaRemision.PSNORCML)
            .Add("IN_NRITOC", oGuiaRemision.PNNRITOC)
            .Add("IN_TCITCL", oGuiaRemision.PSTCITCL.Trim.Replace("-!", "-"))
            '.Add("IN_TCITPR", oGuiaRemision.PSTCITPR)
            '.Add("IN_TDITES", oGuiaRemision.PSTDITES)
            '.Add("IN_TDITIN", oGuiaRemision.PSTDITIN)
            '.Add("IN_CPTDAR", oGuiaRemision.PSCPTDAR)
            '.Add("IN_QCNTIT", oGuiaRemision.PNQCNTIT)
            '.Add("IN_TUNDIT", oGuiaRemision.PSTUNDIT)
            '.Add("IN_IVUNIT", oGuiaRemision.PNIVUNIT)
            '.Add("IN_IVTOIT", oGuiaRemision.PNIVTOIT)
            '.Add("IN_QTOLMIN", oGuiaRemision.PNQTOLMIN)
            '.Add("IN_QTOLMAX", oGuiaRemision.PNQTOLMAX)
            '.Add("IN_FMPDME", oGuiaRemision.PNFMPDME)
            '.Add("IN_FMPIME", oGuiaRemision.PNFMPIME)
            '.Add("IN_TLUGOR", oGuiaRemision.PSTLUGOR)
            If oGuiaRemision.PSTLUGEN.ToString().Trim().Length > 50 Then
                .Add("IN_TLUGEN", oGuiaRemision.PSTLUGEN.Substring(0, 50))
            Else
                .Add("IN_TLUGEN", oGuiaRemision.PSTLUGEN.ToString().Replace("ø", "Nr").Trim())
            End If
            'Dim strLugarEntrega As String = TD_ItemOC.pTLUGEN_LugarEntrega.Trim
            '.Add("IN_TCTCST", oGuiaRemision.PSTCTCST)
            '.Add("IN_IN_TRFRN", oGuiaRemision.PSTRFRN)
            '.Add("IN_FLGPEN", oGuiaRemision.PSFLGPEN)
            '-- Seguridad
            .Add("IN_USUARIO", strUsuario)
            '.Add("IN_NTRMNL", oOrdenCompra.PSNTRMNL)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_ITEM_RZOL39_INS_V1", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoGuiaRemisionItem >> " & vbNewLine & _
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
                                  ByVal TD_ItemGR As TD_ItemGR, ByRef strMensajeError As String) As Boolean
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstResultado As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        Return Grabar(objSqlManager, TD_ItemGR, strUsuario, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de eliminar el registro de la Tabla RZOL39
    ''' </summary>
    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal oItemGR As TD_ItemGRPK, ByVal strUsuario As String, _
                                  ByRef strStatusUltReg As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        strStatusUltReg = "N"
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oItemGR.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", oItemGR.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", oItemGR.pNRITOC_NroItemOC)
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
            strMensajeError = "Error producido en la funcion : << Delete >> de la clase << daoItemGR >> " & vbNewLine & _
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
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal oItemPK As TD_ItemGRPK, ByRef strMensajeError As String) As TD_ItemGR
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        Dim oItemOC As TD_ItemGR = New TD_ItemGR
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
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoItemGR >> " & vbNewLine & _
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
    Public Shared Function fdt_update_itemgr(ByVal objSqlManager As SqlManager, ByVal codigo As Int32, ByVal nguia As Int16, ByVal norden As String, ByVal cmerca As String, _
                                                 ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter

        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PCCLNT", codigo)
            .Add("PNGUIRM", nguia)
            .Add("PNORCML", norden)
            .Add("PCMRCLR", cmerca)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_GR_UP_RZIM37_MRC", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            'TD_Filtro.PAGECOUNT = htResultado("PAGECOUNT")
        Catch ex As Exception
            blnResultado = False
            strMensajeError = "Error producido en la funcion : << fdtListar_ItemsGR_L01 >> de la clase << daoItemGR >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    Public Shared Function fdt_update_itemgr2(ByVal objSqlManager As SqlManager, ByVal codigo As Int32, ByVal nguia As Int16, ByVal nordenCompra As String, ByVal nordenServicio As Integer, _
                                                ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter

        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PCCLNT", codigo)
            .Add("PNGUIRM", nguia)
            .Add("PNORCML", nordenCompra)
            .Add("PNORDSR", nordenServicio)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_GR_UP_RZIM37_OS", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            'TD_Filtro.PAGECOUNT = htResultado("PAGECOUNT")
        Catch ex As Exception
            blnResultado = False
            strMensajeError = "Error producido en la funcion : << fdtListar_ItemsGR_L01 >> de la clase << daoItemGR >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_ITEM_RZOL39_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function
    Public Shared Function fdtListar_ItemsGR_L01(ByVal TD_Filtro As TD_GuiaRemisionPK ) As DataTable

        Dim objSqlManager As New SqlManager
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter

       


        With objParametros
            .Add("PSCCMPN", TD_Filtro._PSCCMPN)
            .Add("PNCCLNT", TD_Filtro._PNCCLNT)
            .Add("PNGUIRM", TD_Filtro._NGUIRM)
            .Add("PSCDVSN", TD_Filtro._PSCDVSN)
            .Add("PNCPLNDV", TD_Filtro._PNCPLNDV)


            'If Not TD_Filtro._PSCCMPN.Trim.Equals("") Then
            '    .Add("PSCCMPN", TD_Filtro._PSCCMPN)
            '    .Add("PNCPLNDV", TD_Filtro._PSCDVSN)
            '    .Add("PCPLNDV", TD_Filtro._PNCPLNDV)
            'End If
            '.Add("PNCCLNT", TD_Filtro._PNCCLNT)
        End With

        'strMensajeError = ""
        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GR_ITEM_RZIM37", objParametros)
        For Each item As DataRow In dtTemp.Rows
            item("QCNGU") = Val(item("QCNGU"))
            item("QCNREC") = Val(item("QCNREC"))
            item("QCNPEN") = Val(item("QCNPEN"))
        Next
        'Dim htResultado As Hashtable
        'htResultado = objSqlManager.ParameterCollection
        'TD_Filtro.PAGECOUNT = htResultado("PAGECOUNT")
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
            strMensajeError = "Error producido en la funcion : << fdtListar_LugarEntrega_L01 >> de la clase << daoItemGR >> " & vbNewLine & _
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

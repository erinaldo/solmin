Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.SubItemOC
Imports Ransa.TypeDef.OrdenCompra.ItemOC

Public Class CSubItemOrdenCompra
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información del Sub Item en una instancia
    ''' </summary>
    Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal TD_SubItemOC As TD_SubItemOC, ByVal strUsuario As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_SubItemOC.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", TD_SubItemOC.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", TD_SubItemOC.pNRITOC_NroItemOC)
            .Add("IN_SBITOC", TD_SubItemOC.pSBITOC_NroSubItemOC)
            .Add("IN_TCITCL", TD_SubItemOC.pTCITCL_CodigoCliente)
            .Add("IN_TCITPR", TD_SubItemOC.pTCITPR_CodigoProveedor)
            .Add("IN_TDITES", TD_SubItemOC.pTDITES_DescripcionES.Replace("™", ""))
            .Add("IN_CPTDAR", TD_SubItemOC.pCPTDAR_PartidaArancelaria)
            .Add("IN_CODTPN", TD_SubItemOC.pCODTPN_TratoPreferencial)
            .Add("IN_QCNTIT", TD_SubItemOC.pQCNTIT_Cantidad)
            .Add("IN_TUNDIT", TD_SubItemOC.pTUNDIT_Unidad)
            .Add("IN_IVUNIT", TD_SubItemOC.pIVUNIT_ImporteUnitario)
            .Add("IN_IVTOIT", TD_SubItemOC.pIVTOIT_ImporteTotal)
            '-- Seguridad
            .Add("IN_USUARIO", strUsuario)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_SUB_ITEM_RZOL39S_INS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoOrdenCompraSubItem >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_SUB_ITEM_RZOL39S_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function





    ''' <summary>
    ''' Procedimiento que se encarga de Grabar y/o Actualizar la información del Sub Item en una Orden de Compra a través del Web Services
    ''' </summary>
    Public Shared Function Grabar(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                  ByVal TD_SubItemOC As TD_SubItemOC, ByRef strMensajeError As String) As Boolean
        ' Creando el Objeto de Conexion
        Dim strCadenaConexion As String = ""
        Dim dstResultado As DataSet = Nothing
        strCadenaConexion = My.Settings.Item(strServidor).ToString()
        strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
        ' Llamada a la Rutina ya existente
        Return Grabar(objSqlManager, TD_SubItemOC, strUsuario, strMensajeError)
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de eliminar el registro de la Tabla RZOL39
    ''' </summary>
    Public Shared Function Delete(ByVal objSqlManager As SqlManager, ByVal oSubItemOC As TD_SubItemOCPK, ByVal strUsuario As String, _
                                  ByRef strStatusUltReg As String, ByRef strMensajeError As String) As Boolean
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        strStatusUltReg = "N"
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oSubItemOC.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", oSubItemOC.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", oSubItemOC.pNRITOC_NroItemOC)
            .Add("IN_SBITOC", oSubItemOC.pSBITOC_NroSubItemOC)
            '-- Seguridad
            .Add("IN_USUARI", strUsuario)
            .Add("OU_STULTR", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_OC_SUB_ITEM_RZOL39S_DEL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            strStatusUltReg = htResultado("OU_STULTR").ToString
            strMensajeError = htResultado("OU_MSGERR").ToString
            If strMensajeError <> "" Then blnResultado = False
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Delete >> de la clase << daoSubItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_OC_SUB_ITEM_RZOL39S_DEL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de Obtener la información del Sub Item en una instancia
    ''' </summary>
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal oSubItemPK As TD_SubItemOCPK, ByRef strMensajeError As String) As TD_SubItemOC
        Dim objParametros As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        Dim oSubItemOC As TD_SubItemOC = New TD_SubItemOC
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", oSubItemPK.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", oSubItemPK.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", oSubItemPK.pNRITOC_NroItemOC)
            .Add("IN_SBITOC", oSubItemPK.pSBITOC_NroSubItemOC)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_SUB_ITEM_RZOL39S_OBJ", objParametros)
            If dtTemp.Rows.Count > 0 Then
                Dim dteTemp As Date
                With oSubItemOC
                    .pCCLNT_CodigoCliente = oSubItemPK.pCCLNT_CodigoCliente
                    .pNORCML_NroOrdenCompra = oSubItemPK.pNORCML_NroOrdenCompra
                    .pNRITOC_NroItemOC = oSubItemPK.pNRITOC_NroItemOC
                    .pSBITOC_NroSubItemOC = oSubItemPK.pSBITOC_NroSubItemOC
                    .pTCITCL_CodigoCliente = ("" & dtTemp.Rows(0).Item("TCITCL")).ToString.Trim
                    .pTCITPR_CodigoProveedor = ("" & dtTemp.Rows(0).Item("TCITPR")).ToString.Trim
                    .pTDITES_DescripcionES = ("" & dtTemp.Rows(0).Item("TDITES")).ToString.Trim
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("QCNTIT"), .pQCNTIT_Cantidad)
                    .pTUNDIT_Unidad = ("" & dtTemp.Rows(0).Item("TUNDIT")).ToString.Trim
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("IVUNIT"), .pIVUNIT_ImporteUnitario)
                    Decimal.TryParse("" & dtTemp.Rows(0).Item("IVTOIT"), .pIVTOIT_ImporteTotal)
                End With
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << daoSubItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_SUB_ITEM_RZOL39S_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return oSubItemOC
    End Function

    ''' <summary>
    ''' Listado de Sub Items de una Orden de Compra en Formato L01 para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtListar_SubItemsOC_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_ItemOCPK, _
                                                 ByRef strMensajeError As String) As DataTable
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", TD_Filtro.pNRITOC_NroItemOC)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_OC_SUB_ITEM_RZOL39S_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_SubItemsOC_L01 >> de la clase << daoSubItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_OC_SUB_ITEM_RZOL39S_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Sub Items en almacén
    ''' </summary>
    Public Shared Function fdtListar_Bulto_SubItemsOC_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_ItemOCPK, _
                                                 ByRef strMensajeError As String) As DataTable
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
            .Add("IN_CREFFW", TD_Filtro.pCREFFW_FrdForw)
            .Add("IN_CIDPAQ", TD_Filtro.pCIDPAQ_CodIndentificacionPaquete)
            .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra.Trim)
            .Add("IN_NRITOC", TD_Filtro.pNRITOC_NroItemOC)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_LIST", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_SubItemsOC_L01 >> de la clase << daoSubItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_LIST >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Genera bultos de sub items de orden de compra
    ''' </summary>
    Public Shared Function Generar_Bultos_SubItems_OC(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_SubItemOC, _
                                                 ByRef strMensajeError As String, ByVal pUsuario As String) As DataTable
        Dim dtTemp As New DataTable
        objSqlManager = New SqlManager()
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CREFFW", TD_Filtro.pCREFFW_FrdForw)
            .Add("PSCIDPAQ", TD_Filtro.pCIDPAQ_CodIndentificacionPaquete)
            .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
            .Add("IN_NRITOC", TD_Filtro.pNRITOC_NroItemOC)
            .Add("IN_SBITOC", TD_Filtro.pSBITOC_NroSubItemOC)
            .Add("IN_QCNRCP", TD_Filtro.pQCNREC_QtaRecibida)
            .Add("IN_CUSCRT", pUsuario)
            .Add("IN_CULUSA", pUsuario)
            'Adicionales
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)

        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_INS", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_INS >> de la clase << daoSubItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_INS >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Genera bultos de sub items de orden de compra
    ''' </summary>
    Public Shared Function Eliminar_Bultos_SubItems_OC(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_SubItemOCPK, _
                                                 ByRef strMensajeError As String, ByVal pUsuario As String) As Boolean
        objSqlManager = New SqlManager()
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("PSCCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("PSCDVSN", TD_Filtro.pCDVSN_Division)
            .Add("PNCPLNDV", TD_Filtro.pCPLNDV_Planta)
            .Add("PSCREFFW", TD_Filtro.pCREFFW_FrdForw.Trim)
            .Add("PSCIDPAQ", TD_Filtro.pCIDPAQ_CodIndentificacionPaquete.Trim)
            .Add("PSNORCML", TD_Filtro.pNORCML_NroOrdenCompra.Trim)
            .Add("PNNRITOC", TD_Filtro.pNRITOC_NroItemOC)
            .Add("PSSBITOC", TD_Filtro.pSBITOC_NroSubItemOC)
            .Add("PNQCNRCP", TD_Filtro.pQCNREC_QtaRecibida)
            .Add("PSCULUSA", pUsuario)
        End With
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_DELETE", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_DELETE >> de la clase << daoSubItemOC >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_SUB_ITEM_BULTO_RZOL66S_DELETE >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return True
    End Function


#End Region
End Class

'Imports Ransa.TYPEDEF.Cliente
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.NEGO.slnSOLMIN_SAT.Recepcion
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.Utilitario
Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.TypeDef.slnSOLMIN_SDS_SIMPLE


Public Class frmDevolucionOCSDS

#Region " Atributos "
    Private booStatus As Boolean = False
    Private strPersiana As String = "I"
    Private CurrentOrdenCompra As TD_OrdenCompraPK
#End Region

#Region " Propiedades "

#End Region

#Region " Procedimientos y Funciones "
    Private Sub pActualizarInformacion()
        Dim objAppConfig As cAppConfig = New cAppConfig
        booStatus = False
        '-- Cargo la Informacion de las Ordenes de Compras
        Dim objFiltroOC As TD_Qry_OrdenCompra_L01 = New TD_Qry_OrdenCompra_L01
        objFiltroOC.pCCLNT_CodigoCliente = txtCliente.pCodigo
        objFiltroOC.pTDSCML_DescripcionOC = txtDescripcion.Text.Trim
        Date.TryParse(Me.txtFechaFinal.Text, objFiltroOC.pFORCML_FechaOC_Final)
        Date.TryParse(Me.txtFechaInicial.Text, objFiltroOC.pFORCML_FechaOC_Inicio)
        objFiltroOC.pNORCML_NroOrdenCompra = txtOrdenCompra.Text.Trim
        objFiltroOC.pCPRVCL_Proveedor = txtProveedor.pCodigo
        objFiltroOC.pTTINTC_TermInterCarga = cmbTermInter.pInformacionSelec.pCCMPRN_Codigo
        If cmbPrioridad.pInformacionSelec.pCCMPRN_Codigo <> "" Then objFiltroOC.pNTPDES_Prioridad = cmbPrioridad.pInformacionSelec.pCCMPRN_Codigo
        objFiltroOC.pSITUOC_SituacionOC = cmbSituacionOC.pInformacionSelec.pCCMPRN_Codigo
        dgOrdenCompra.pActualizar(objFiltroOC)
        '-- Habilito Status
        booStatus = True
        '-- Registro los nuevos valores de los campos de los clientes
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RecepcionOC_CodigoCliente", txtCliente.pCodigo)
        objAppConfig.SetValue("RecepcionOC_DetalleCliente", txtCliente.pRazonSocial)
        objAppConfig = Nothing
        '-- Reinicio las persianas
        EnlazarCliente()
    End Sub

    Private Sub SelectTabPage(ByVal OrdenCompra As TD_OrdenCompraPK)
        'If tbcDetalles.SelectedTab Is tbpDetalle Then
        dgItemsOC.pActualizar(OrdenCompra)
        'ElseIf tbcDetalles.SelectedTab Is tbpMovimientos Then
        'ElseIf tbcDetalles.SelectedTab Is tbpObservaciones Then
        '    If dgOrdenCompra.pOrdenCompraSeleccionada.pNORCML_NroOrdenCompra <> "" Then
        '        Dim objBulto As clsPrimaryKey_OrdenCompra = New clsPrimaryKey_OrdenCompra
        '        With objBulto
        '            .pintCodigoCliente_CCLNT = dgOrdenCompra.pOrdenCompraSeleccionada.pCCLNT_CodigoCliente
        '            .pstrNroOrdenCompra_NORCML = dgOrdenCompra.pOrdenCompraSeleccionada.pNORCML_NroOrdenCompra
        '        End With
        '        txtObservacion.Text = mfstrInformacion_ObservacionesItemOC(objBulto)
        '    End If
        'End If

    End Sub

#End Region

#Region " Eventos "
    Private Sub btnCambiarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarCliente.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        Dim fClienteDestino As frmClienteDestino = New frmClienteDestino
        With fClienteDestino
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' proceso el cambio
                Dim objOrdenCompra As clsPrimaryKey_OrdenCompra = New clsPrimaryKey_OrdenCompra
                objOrdenCompra.pintCodigoCliente_CCLNT = dgOrdenCompra.pOrdenCompraSeleccionada.pCCLNT_CodigoCliente
                objOrdenCompra.pstrNroOrdenCompra_NORCML = dgOrdenCompra.pOrdenCompraSeleccionada.pNORCML_NroOrdenCompra
                ' Procedimiento que realiza el cambio según las condiciones que tuviese
                If mfblnCambiarClienteOC(objOrdenCompra, .pintCodigoCliente_CCLNT) Then
                    dgOrdenCompra.pRefrescar()
                    'dgOrdenesCompras.Rows.Remove(dgOrdenesCompras.CurrentRow)
                End If
            End If
            .Dispose()
            fClienteDestino = Nothing
        End With
    End Sub

    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub bsaDescripcionLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaDescripcionLimpiar.Click
        txtDescripcion.Text = ""
    End Sub

    Private Sub bsaOrdenCompraLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaOrdenCompraLimpiar.Click
        txtOrdenCompra.Text = ""
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    Private Sub dgItemsOC_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
        If MessageBox.Show(strPregunta, "Recepceción:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgItemsOC_DeleteHeadOC()
        dgOrdenCompra.pRefrescar()
    End Sub

    Private Sub dgItemsOC_ErrorMessage(ByVal strMensaje As String)
        MessageBox.Show(strMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgOrdenCompra_Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgOrdenCompra.Confirmar
        If MessageBox.Show(strPregunta, "Confirmar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgOrdenCompra_CurrentRowChanged(ByVal OrdenCompra As TD_OrdenCompraPK) Handles dgOrdenCompra.CurrentRowChanged
        SelectTabPage(OrdenCompra)
        CurrentOrdenCompra = OrdenCompra
    End Sub

    Private Sub dgOrdenCompra_DataLoadCompleted(ByVal OrdenCompra As TD_OrdenCompraPK) Handles dgOrdenCompra.DataLoadCompleted
        SelectTabPage(OrdenCompra)
        CurrentOrdenCompra = OrdenCompra
    End Sub

    Private Sub dgOrdenCompra_ErrorMessage(ByVal strMensaje As String) Handles dgOrdenCompra.ErrorMessage
        MessageBox.Show(strMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


    Private Sub dgItemsOC_GenerarRecepcion(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As System.Collections.Generic.List(Of TD_ItemOCForWayBill), ByVal TotalItem As System.Collections.Generic.List(Of TD_ItemOCForWayBill)) Handles dgItemsOC.GenerarRecepcion

        '==============Validar que el cliente tenga contrato
        Dim obrGeneral As New brGeneral
        Dim obeGeneral As New beGeneral
        Dim strError As String = String.Empty
        With obeGeneral
            .PSCCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            .PNCCLNT = Me.txtCliente.pCodigo
        End With
        If Not obrGeneral.fbolValidarClienteContrato(obeGeneral, strError) Then
            HelpClass.MsgBox(strError)
            Exit Sub
        End If
        '=============Validacion contrato==========================

        Dim fSolicInforRecOCAlmacen As frmSolicInforRecOCAlmacen = New frmSolicInforRecOCAlmacen
        Dim fGenerarRecepcion As frmGenerarRecepcion = New frmGenerarRecepcion
        Dim objMovimientoMercaderia As clsMovimientoMercaderia = Nothing
        With fSolicInforRecOCAlmacen
            .txtNroOrdenCompra.Text = CurrentOrdenCompra.pNORCML_NroOrdenCompra
            'TD_OC_Actual.pCPRVCL_CodProveedor = dgOrdenesCompras.CurrentRow.Cells("M_CPRVCL").Value.ToString.Trim
            .pstrCodProveedor = CurrentOrdenCompra.pCPRVCL_CodProveedor
            .pstrTerminoInternacional = CurrentOrdenCompra.pTTINTC_TerminoIntern
            .pintCliente = Me.txtCliente.pCodigo
            .pstrRazonSocialCliente = Me.txtCliente.pRazonSocial
            .pstrCodProvCliente = CurrentOrdenCompra.pCPRPCL_CodProvCliente
            .pstrTipoRelacion = CurrentOrdenCompra.pSTPORL_TipoRelacion
            .EsDevolucion = True
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub 'dgItemsOC.pRefrescar()
            Dim objHashTable As Hashtable
            objHashTable = New Hashtable

            objHashTable.Add("TPOOCM", CurrentOrdenCompra.pTPOOCM_TipoOC)
            objHashTable.Add("NORCCL", .pstrNroOrdenCompra)
            objHashTable.Add("NGUICL", .pstrNroGuiaCliente)
            objHashTable.Add("NRUCLL", .pstrNroRUCCliente)
            objHashTable.Add("STPING", .pstrTipoRecepcion)
            objHashTable.Add("CTPALM", .pstrTipoAlmacen)
            objHashTable.Add("TALMC", .pstrDetalleAlmacen)
            objHashTable.Add("CALMC", .pstrAlmacen)
            objHashTable.Add("TCMPAL", .pstrDetalleTipoAlmacen)
            objHashTable.Add("CZNALM", .pstrZonaAlmacen)
            objHashTable.Add("TCMZNA", .pstrDetalleZonaAlmacen)
            objHashTable.Add("CCNTD", .pstrContenedor)
            objHashTable.Add("CTPOCN", .pblnDesglose)
            objHashTable.Add("NOMPRO", CurrentOrdenCompra.pNOMBPR_NombreProveedor)
            objHashTable.Add("NOMBPR", CurrentOrdenCompra.pNRUCPR_NroRucProveedor + " <-> " + CurrentOrdenCompra.pNOMBPR_NombreProveedor)
            objHashTable.Add("NORSCI", .pdecEmbarque)
            objHashTable.Add("CPRPCL", CurrentOrdenCompra.pCPRPCL_CodProvCliente)
            objHashTable.Add("TIPORG", .pstrTipoOrigen_TIPORG)
            objHashTable.Add("TIPORI", .pstrTipoDocumentoOrigen_TIPORI)
            objHashTable.Add("CPRVCL", .pstrCodProvCliente)
            objHashTable.Add("SCNEMB", .pstrEmbalajaOC)


            fGenerarRecepcion.objInformacionIngresada = .pobjInformacionIngresada
            fGenerarRecepcion.pHashTable = objHashTable
            fGenerarRecepcion.ItemSelec_List = ItemSelec
            fGenerarRecepcion.Cliente_CCLNT = Me.txtCliente.pCodigo
            fGenerarRecepcion.RazonSocial = Me.txtCliente.pRazonSocial
            fGenerarRecepcion.EsDevolucion = True
            If fGenerarRecepcion.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            'fGenerarRecepcion.UcSerie_Lista.Guardar()
            'fGenerarRecepcion.UcUbicaciones_Lista.Guardar(fGenerarRecepcion.intNroGuiaRansa)
            dgItemsOC.pActualizar(OrdenCompra)
            .Dispose()
            fSolicInforRecOCAlmacen = Nothing
            fGenerarRecepcion = Nothing
        End With
    End Sub

    Private Sub dgItemsOC_InsertarMercaderia(ByVal objInformacion As System.Collections.Hashtable) Handles dgItemsOC.InsertarMercaderia
        Dim frmMercaderia As New frmMercaderiaSDS
        With frmMercaderia
            .pintTipoInvoke = 1
            .pintCodigoCliente_CCLNT = Me.txtCliente.pCodigo
            .txtCodigoMercaderia.Text = objInformacion("M_CMRCLR").ToString.Trim
            .txtDescMerca01.Text = IIf(objInformacion("M_TMRCD2").ToString.Trim.Length > .txtDescMerca01.MaxLength, objInformacion("M_TMRCD2").ToString.Substring(.txtDescMerca01.MaxLength), objInformacion("M_TMRCD2").ToString.Trim)
            '.txtProveedor.pCodigo = IIf(objInformacion("M_TCITPR").ToString.Trim.Equals(""), 0, CType(objInformacion("M_TCITPR").ToString.Trim, Int64))
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Me.dgItemsOC.UpdateCell_Mercaderia(objInformacion("M_CMRCLR").ToString.Trim, IIf(objInformacion("M_TMRCD2").ToString.Trim.Length > .txtDescMerca01.MaxLength, objInformacion("M_TMRCD2").ToString.Substring(.txtDescMerca01.MaxLength), objInformacion("M_TMRCD2").ToString.Trim))
        End With
    End Sub

    Private Sub dgItemsOC_InsertarOrdenServicio(ByVal objInformacion As System.Collections.Hashtable) Handles dgItemsOC.InsertarOrdenServicio
        Dim frmOrdenServicio As New frmOrdenServicioSDS
        Dim objHashtable As New Hashtable
        With frmOrdenServicio
            .Cliente_CCLNT = Me.txtCliente.pCodigo
            .Mercaderia_CMRCLR = objInformacion("M_CMRCLR").ToString.Trim
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Me.dgItemsOC.UpdateCell_OrdenServicio(.pobjHashTable) '.OrdenServicio, .NroContrato, .NroCorrelativoContrato, .NroAutorizacionContrato, .TipoDeposito, .Estado)
        End With
    End Sub

    Private Sub dgItemsOC_Message(ByVal strMensaje As String)
        MessageBox.Show(strMensaje, "Orden Compra:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgOrdenCompra_Message(ByVal strMensaje As String) Handles dgOrdenCompra.Message
        MessageBox.Show(strMensaje, "Orden Compra:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgOrdenCompra_TableWithOutData() Handles dgOrdenCompra.TableWithOutData
        dgItemsOC.pClear()
    End Sub

    Private Sub frmOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-- Inicializando las variables status por control con F4
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        objAppConfig = Nothing
        dgOrdenCompra.pUsuario = objSeguridadBN.pUsuario
        dgItemsOC.pEstado = "Devolucion"
        dgItemsOC.pUsuario = objSeguridadBN.pUsuario
        EnlazarCliente()
    End Sub

    Private Sub txtCliente_ExitFocusWithOutData() Handles txtCliente.ExitFocusWithOutData
        dgOrdenCompra.pClear()
        EnlazarCliente()
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgOrdenCompra.pClear()
        EnlazarCliente()
    End Sub


    Private Sub EnlazarCliente()
        dgOrdenCompra.CCLNT_Pendiente_Cod_Cliente = txtCliente.pCodigo
        dgOrdenCompra.TCMPCL_Pendiente_Des_Cliente = txtCliente.pCodigo & " - " & txtCliente.pRazonSocial
    End Sub
    Private Sub tbcDetalles_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs)
        SelectTabPage(CurrentOrdenCompra)
    End Sub
#End Region

#Region " Métodos "

#End Region

    Private Sub dgOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgOrdenCompra.Load

    End Sub

    'Private Sub dgOrdenCompra_ShowfrmImportarOcSDS() Handles dgOrdenCompra.ShowfrmImportarOcSDS
    '    If (txtCliente.pCodigo = 11232) Then
    '        Dim ofrmImportarOcSDS As New frmImportarOcSDS
    '        ofrmImportarOcSDS.Cod_Cliente = txtCliente.pCodigo.ToString().Trim()
    '        ofrmImportarOcSDS.strUsuario = objSeguridadBN.pUsuario
    '        ofrmImportarOcSDS.ShowDialog()
    '    End If

    '    If (txtCliente.pCodigo = 30507) Or (txtCliente.pCodigo = 11731) Then
    '        Dim ofrmImportarOcSDSexcel As New frmImportarOcSDSexcel
    '        ofrmImportarOcSDSexcel.Cod_Cliente = txtCliente.pCodigo.ToString().Trim()
    '        ofrmImportarOcSDSexcel.strUsuario = objSeguridadBN.pUsuario
    '        ofrmImportarOcSDSexcel.ShowDialog()
    '    End If


    'End Sub

    'Private Sub txtCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Load
    '    If (txtCliente.pCodigo = 11232) Then
    '        dgOrdenCompra.VisualizarImportarOCSDS(True)
    '    Else
    '        If (txtCliente.pCodigo = 30507) Or (txtCliente.pCodigo = 11731) Then
    '            dgOrdenCompra.VisualizarImportarOCSDS(True)
    '        Else
    '            dgOrdenCompra.VisualizarImportarOCSDS(False)
    '        End If
    '    End If

    'End Sub

End Class

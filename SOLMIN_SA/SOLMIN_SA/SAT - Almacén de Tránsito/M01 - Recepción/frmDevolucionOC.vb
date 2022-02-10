Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion
Imports RANSA.Utilitario

Public Class frmDevolucionOC

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
    End Sub

    Private Sub SelectTabPage(ByVal OrdenCompra As TD_OrdenCompraPK)
        'If tbcDetalles.SelectedTab Is tbpDetalle Then
        dgItemsOC.pActualizar(OrdenCompra)
        'ElseIf tbcDetalles.SelectedTab Is tbpMovimientos Then
        With dgItemsOC.pItemSeleccionada
            If .pNRITOC_NroItemOC <> 0 Then
                ' dgMovimientoItemOC.DataSource = mfdtListar_MovimientoItemOrdenCompraUnRegistro(.pCCLNT_CodigoCliente, .pNORCML_NroOrdenCompra, .pNRITOC_NroItemOC, UcCompania_Cmb011.CCMPN_CodigoCompania, UcDivision_Cmb011.Division, UcPLanta_Cmb011.Planta)
                ListaMovimientoItemsDeOC(.pNORCML_NroOrdenCompra, .pNRITOC_NroItemOC)
            End If
        End With
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

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

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

    Private Sub txtCliente_ExitFocusWithOutData() Handles txtCliente.ExitFocusWithOutData
        dgOrdenCompra.pClear()
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgOrdenCompra.pClear()
    End Sub

    Private Sub frmDevolucionOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        ' dgItemsOC.pUsuario = objSeguridadBN.pUsuario
        ' dgMovimientoItemOC.AutoGenerateColumns = False

        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        dgOrdenCompra.pCCMPN_CodCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        dgItemsOC.pCCMPN_CodCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy

    End Sub

    Private Sub dgOrdenCompra_Confirmar(ByVal strPregunta As System.String, ByRef blnCancelar As System.Boolean) Handles dgOrdenCompra.Confirmar
        If MessageBox.Show(strPregunta, "Confirmar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgOrdenCompra_CurrentRowChanged(ByVal OrdenCompra As Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK) Handles dgOrdenCompra.CurrentRowChanged
        OrdenCompra.pCCMPN_CodCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
        OrdenCompra.pCDVSN_CodDivision = UcDivision_Cmb011.Division
        OrdenCompra.pCPLNDV_CodPlanta = UcPLanta_Cmb011.Planta
        SelectTabPage(OrdenCompra)
        CurrentOrdenCompra = OrdenCompra
    End Sub

    Private Sub dgOrdenCompra_DataLoadCompleted(ByVal OrdenCompra As RANSA.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK) Handles dgOrdenCompra.DataLoadCompleted
        SelectTabPage(OrdenCompra)
        CurrentOrdenCompra = OrdenCompra
    End Sub

    Private Sub dgOrdenCompra_ErrorMessage(ByVal strMensaje As System.String) Handles dgOrdenCompra.ErrorMessage
        MessageBox.Show(strMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgOrdenCompra_Message(ByVal strMensaje As System.String) Handles dgOrdenCompra.Message
        MessageBox.Show(strMensaje, "Orden Compra:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgOrdenCompra_TableWithOutData() Handles dgOrdenCompra.TableWithOutData
        dgItemsOC.pClear()
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
        dgOrdenCompra.pCCMPN_CodCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        dgItemsOC.pCCMPN_CodCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy

    End Sub

    Private Sub dgItemsOC_Confirm(ByVal strPregunta As System.String, ByRef blnCancelar As System.Boolean) Handles dgItemsOC.Confirm
        If MessageBox.Show(strPregunta, "Recepceción:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgItemsOC_CurrentRowChanged(ByVal Item As Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK) Handles dgItemsOC.CurrentRowChanged
        'dgMovimientoItemOC.DataSource = Nothing
        'dgMovimientoItemOC.DataSource = mfdtListar_MovimientoItemOrdenCompraUnRegistro(Item.pCCLNT_CodigoCliente, Item.pNORCML_NroOrdenCompra, Item.pNRITOC_NroItemOC, UcCompania_Cmb011.CCMPN_CodigoCompania, UcDivision_Cmb011.Division, UcPLanta_Cmb011.Planta)
        ListaMovimientoItemsDeOC(Item.pNORCML_NroOrdenCompra, Item.pNRITOC_NroItemOC)
    End Sub

    Private Sub dgItemsOC_DeleteHeadOC() Handles dgItemsOC.DeleteHeadOC
        dgOrdenCompra.pRefrescar()
    End Sub

    Private Sub dgItemsOC_ErrorMessage(ByVal strMensaje As System.String) Handles dgItemsOC.ErrorMessage
        MessageBox.Show(strMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


    Private Function ValidarContratro() As Boolean
        '==============Validar que el cliente tenga contrato
        Dim obrGeneral As New brGeneral
        Dim obeGeneral As New beGeneral
        Dim strError As String = String.Empty
        With obeGeneral
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PNCCLNT = Me.txtCliente.pCodigo
        End With
        If Not obrGeneral.fbolValidarClienteContrato(obeGeneral, strError) Then
            HelpClass.MsgBox(strError)
            Return True
        End If
        Return False
        '=============Validacion contrato==========================
    End Function

    Private Sub dgItemsOC_GenerarBulto(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As System.Collections.Generic.List(Of TD_ItemOCForWayBill), ByVal TotalItem As System.Collections.Generic.List(Of TD_ItemOCForWayBill), ByVal oHasSubItems As Hashtable) Handles dgItemsOC.GenerarBulto
        If ValidarContratro() Then Exit Sub
        Dim fRecepcionOCGenerarBulto As frmGenerarBultoN = New frmGenerarBultoN
        With fRecepcionOCGenerarBulto
            .pCodigoCliente_CCLNT = OrdenCompra.pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
            .pStatusBultoNormal = True
            .pSoloLectura_QCNREC = False
            .pSoloLectura_TDAITM = False
            .pItemsSelec = ItemSelec
            .pTotalItems = TotalItem
            .poHasSubItems = oHasSubItems
            .pCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pDivision = UcDivision_Cmb011.Division
            .pPlanta = UcPLanta_Cmb011.Planta
            .pEstado = "Devolucion"
            .strDesPlanta = Me.UcPLanta_Cmb011.DescripcionPlanta
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                dgItemsOC.pRefrescar()
                dgItemsOC.oHasSubItems = New Hashtable()
            End If
            .Dispose()
            fRecepcionOCGenerarBulto = Nothing
        End With
    End Sub

    Private Sub dgItemsOC_Message(ByVal strMensaje As System.String) Handles dgItemsOC.Message
        MessageBox.Show(strMensaje, "Orden Compra:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgMovimientoItemOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMovimientoItemOC.CellContentClick
        If dgMovimientoItemOC.Columns(e.ColumnIndex) Is M_IMBULTO Then
            Dim frmDetalle As New frmDetalleBulto

            frmDetalle.dgBultosDetalle.DataSource = mfdtListar_ItemsBultos(txtCliente.pCodigo, dgMovimientoItemOC.Rows(e.RowIndex).Cells("M_CREFFW").Value, UcCompania_Cmb011.CCMPN_CodigoCompania, UcDivision_Cmb011.Division, UcPLanta_Cmb011.Planta)
            frmDetalle.ShowDialog()
            frmDetalle.Dispose()
        End If
    End Sub

    Private Sub bsaDescripcionLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaDescripcionLimpiar.Click
        txtDescripcion.Text = ""
    End Sub

    Private Sub bsaOrdenCompraLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaOrdenCompraLimpiar.Click
        txtOrdenCompra.Text = ""
    End Sub

    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub ListaMovimientoItemsDeOC(ByVal strOc As String, ByVal decNrItem As Decimal)

        'dgMovimientoItemOC.DataSource = Nothing
        'dgMovimientoItemOC.DataSource = mfdtListar_MovimientoItemOrdenCompraUnRegistro(Item.pCCLNT_CodigoCliente, Item.pNORCML_NroOrdenCompra, Item.pNRITOC_NroItemOC, UcCompania_Cmb011.CCMPN_CodigoCompania, UcDivision_Cmb011.Division, UcPLanta_Cmb011.Planta)
        '==============Nuevo====================
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSNORCML = strOc
            .PNNRITOC = decNrItem
        End With
        dgMovimientoItemOC.DataSource = obrBulto.ListarMovimientoItemOrdenCompra(obeBulto)
    End Sub

#End Region

End Class

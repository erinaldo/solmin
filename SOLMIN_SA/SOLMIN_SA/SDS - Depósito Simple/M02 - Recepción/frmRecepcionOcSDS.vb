Imports Ransa.TYPEDEF.Cliente
Imports Ransa.TYPEDEF.OrdenCompra.OrdenCompra
Imports Ransa.TYPEDEF.OrdenCompra.ItemOC
Imports Ransa.NEGO.slnSOLMIN_SAT.Recepcion
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.Utilitario
Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE


Public Class frmRecepcionOcSDS

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
        dgOrdenCompra.pCCMPN_CodCompania = GLOBAL_COMPANIA

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
    Private Sub ListaMovimientoItemsDeOC(ByVal strOc As String, Optional ByVal decNrItem As Decimal = 0)
        'If tbcDetalles.SelectedIndex = 1 Then
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSCCMPN = GLOBAL_COMPANIA
            .PSCDVSN = GLOBAL_DIVISION
            .PNCPLNDV = 0 'UcPLanta_Cmb011.Planta
            .PSNORCML = strOc
        End With
        dgMovimientoItemOC.DataSource = obrBulto.ListarMovimientoItemOrdenCompra(obeBulto)
        'End If
    End Sub

    Private Sub SelectTabPage(ByVal OrdenCompra As TD_OrdenCompraPK)
        'If tbcDetalles.SelectedTab Is tbpDetalle Then
        Try
            dgItemsOC.pCCMPN_CodCompania = OrdenCompra.pCCMPN_CodCompania
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
            ListaMovimientoItemsDeOC(OrdenCompra.pNORCML_NroOrdenCompra)
            dgvMovimiento.AutoGenerateColumns = False
            dgvMovimiento.DataSource = dgOrdenCompra.ListarServicio(dgOrdenCompra.pOrdenCompraSeleccionada.pCCLNT_CodigoCliente, dgOrdenCompra.pOrdenCompraSeleccionada.pNORCML_NroOrdenCompra)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

        tbpMovimiento_DS.Parent = Nothing
        tbpMovimientosOC.Parent = Nothing
        If dgOrdenCompra.isDepositoSimple Then
            tbpMovimientosOC.Parent = Nothing
            Me.tbcDetalles.TabPages.Add(tbpMovimiento_DS)
        Else
            tbpMovimiento_DS.Parent = Nothing
            Me.tbcDetalles.TabPages.Add(tbpMovimientosOC)
        End If
    End Sub

    Private Sub dgItemsOC_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgItemsOC.Confirm
        If MessageBox.Show(strPregunta, "Recepceción:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgItemsOC_DeleteHeadOC() Handles dgItemsOC.DeleteHeadOC
        dgOrdenCompra.pRefrescar()
    End Sub

    Private Sub dgItemsOC_ErrorMessage(ByVal strMensaje As String) Handles dgItemsOC.ErrorMessage
        MessageBox.Show(strMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgOrdenCompra_Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgOrdenCompra.Confirmar
        If MessageBox.Show(strPregunta, "Confirmar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgOrdenCompra_CurrentRowChanged(ByVal OrdenCompra As TD_OrdenCompraPK) Handles dgOrdenCompra.CurrentRowChanged
        With OrdenCompra
            .pCCMPN_CodCompania = GLOBAL_COMPANIA
            .pCDVSN_CodDivision = GLOBAL_DIVISION
            .pCPLNDV_CodPlanta = 1
        End With
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

    Private Sub dgItemsOC_GenerarBulto(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As System.Collections.Generic.List(Of TD_ItemOCForWayBill), ByVal TotalItem As System.Collections.Generic.List(Of TD_ItemOCForWayBill), ByVal oHasSubItems As Hashtable) Handles dgItemsOC.GenerarBulto
        Dim fRecepcionOCGenerarBulto As frmGenerarBultoN = New frmGenerarBultoN
        With fRecepcionOCGenerarBulto
            .pCodigoCliente_CCLNT = OrdenCompra.pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
            .pStatusBultoNormal = True
            .pSoloLectura_QCNREC = False
            .pSoloLectura_TDAITM = False
            .pItemsSelec = ItemSelec
            .pTotalItems = TotalItem
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then dgItemsOC.pRefrescar()
            .Dispose()
            fRecepcionOCGenerarBulto = Nothing
        End With
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
        '=============Validación contrato==========================

        If CurrentOrdenCompra.pSFLGES_FlagEstado = "1" And Me.txtCliente.pCodigo = 11232 Then
            If MessageBox.Show("La O/C no debe ser procesada por RANSA, desea seguir con la operación.", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If



        If obrGeneral.fIntValidarEnvioABB(OrdenCompra.pNORCML_NroOrdenCompra) = 1 And Me.txtCliente.pCodigo = 11232 Then
            MessageBox.Show("La OC no se procederá a enviar por interfaz porque ya fue recepcionada en ABB.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

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
            .txtDescMerca01.Text = IIf(objInformacion("M_TMRCD2").ToString.Trim.Length > .txtDescMerca01.MaxLength, objInformacion("M_TMRCD2").ToString.Substring(0, .txtDescMerca01.MaxLength), objInformacion("M_TMRCD2").ToString.Trim)
            .txtDescMerca02.Text = IIf(objInformacion("M_TMRCD2").ToString.Trim.Length > .txtDescMerca01.MaxLength, objInformacion("M_TMRCD2").ToString.Substring(.txtDescMerca01.MaxLength), "")
            '.txtProveedor.pCodigo = IIf(objInformacion("M_TCITPR").ToString.Trim.Equals(""), 0, CType(objInformacion("M_TCITPR").ToString.Trim, Int64))
            '.txtProveedor.pCodigo = IIf(objInformacion("M_TCITPR").ToString.Trim.Equals(""), 0, CType(objInformacion("M_TCITPR").ToString.Trim, Int64))
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Me.dgItemsOC.UpdateCell_Mercaderia(objInformacion("M_CMRCLR").ToString.Trim, IIf(objInformacion("M_TMRCD2").ToString.Trim.Length > .txtDescMerca01.MaxLength, objInformacion("M_TMRCD2").ToString.Substring(0, .txtDescMerca01.MaxLength), objInformacion("M_TMRCD2").ToString.Trim))
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

    Private Sub dgItemsOC_Message(ByVal strMensaje As String) Handles dgItemsOC.Message
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
        dgMovimientoItemOC.AutoGenerateColumns = False
        dgvMovimiento.AutoGenerateColumns = False
        objAppConfig = Nothing
        dgOrdenCompra.pUsuario = objSeguridadBN.pUsuario
        dgItemsOC.pUsuario = objSeguridadBN.pUsuario
        dgItemsOC.Agregar = True
        dgItemsOC.Modificar = True
        dgItemsOC.Eliminar = True
        EnlazarCliente()
        tbpMovimientosOC.Parent = Nothing
        Me.tbpMovimiento_DS.Parent = tbcDetalles

        dgOrdenCompra.RecepcionInterfazSap = True
        'borrar para pasar producción
        GLOBAL_COMPANIA = "EZ"
    End Sub

    Private Sub txtCliente_ExitFocusWithOutData() Handles txtCliente.ExitFocusWithOutData
        dgOrdenCompra.pClear()
        EnlazarCliente()
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgOrdenCompra.pClear()
        Me.dgvMovimiento.DataSource = Nothing
        Me.dgMovimientoItemOC.DataSource = Nothing
        EnlazarCliente()
    End Sub


    Private Sub EnlazarCliente()
        dgOrdenCompra.CCLNT_Pendiente_Cod_Cliente = txtCliente.pCodigo
        dgOrdenCompra.TCMPCL_Pendiente_Des_Cliente = txtCliente.pCodigo & " - " & txtCliente.pRazonSocial
    End Sub
    Private Sub tbcDetalles_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles tbcDetalles.Selecting
        SelectTabPage(CurrentOrdenCompra)
    End Sub
#End Region

#Region " Métodos "

#End Region


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

    Private Sub dgvMovimiento_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovimiento.CellContentDoubleClick
        Dim ColName As String = ""
        Try
            If (e.ColumnIndex < 0 Or e.RowIndex < 0) Then
                Exit Sub
            End If
            If dgvMovimiento.Columns(dgvMovimiento.CurrentCell.ColumnIndex) IsNot Nothing Then
                ColName = dgvMovimiento.Columns(dgvMovimiento.CurrentCell.ColumnIndex).Name
                Select Case ColName
                    Case "MOVIMIENTO_DETALLE"

                        Dim oFrmMovimientoOC As New Ransa.Controls.OrdenCompra.frmMovimientoOcSDS
                        oFrmMovimientoOC.pCCLNT = CurrentOrdenCompra.pCCLNT_CodigoCliente
                        oFrmMovimientoOC.pNORCML = CurrentOrdenCompra.pNORCML_NroOrdenCompra
                        oFrmMovimientoOC.pGUIARANSA = Val(dgvMovimiento.Item("NGUIRN", e.RowIndex).Value)
                        oFrmMovimientoOC.ShowDialog()

                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgMovimientoItemOC_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMovimientoItemOC.CellContentClick
        If dgMovimientoItemOC.Columns(e.ColumnIndex) Is M_IMBULTO Then
            '----------frmObservacionItemOC-------------
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PSCCMPN = GLOBAL_COMPANIA
                .PSCDVSN = GLOBAL_DIVISION
                .PNCPLNDV = dgMovimientoItemOC.Rows(e.RowIndex).Cells("M_CPLNDV").Value
                .PSCREFFW = dgMovimientoItemOC.Rows(e.RowIndex).Cells("M_CREFFW").Value
                .PNNSEQIN = dgMovimientoItemOC.Rows(e.RowIndex).Cells("M_NSEQIN").Value
                .PNCCLNT = txtCliente.pCodigo
            End With
            Dim frmDetalle As New frmDetalleBulto
            frmDetalle.obeBulto = obeBulto
            frmDetalle.ShowDialog()
            frmDetalle.Dispose()
        End If
    End Sub

    Private Sub dgOrdenCompra_TrasladoDeBultos() Handles dgOrdenCompra.TrasladoDeBultos
        If txtCliente.pCodigo = 0 Then Exit Sub
        Dim ofrmSolicInforRecTransferencia As New frmSolicInforRecTransferencia
        ofrmSolicInforRecTransferencia.pintCCLNT = Me.txtCliente.pCodigo
        ofrmSolicInforRecTransferencia.pintServicio_CSRVC = 1
        ofrmSolicInforRecTransferencia.pstrRazonSocialCliente = Me.txtCliente.pRazonSocial
        ofrmSolicInforRecTransferencia.pstrCCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        ofrmSolicInforRecTransferencia.pstrCDVSN = "R"
        ofrmSolicInforRecTransferencia.pintCCLNT = Me.txtCliente.pCodigo

        ofrmSolicInforRecTransferencia.ShowDialog()
    End Sub

    Private Sub dgOrdenCompra_RecepcionInterfazEvent() Handles dgOrdenCompra.RecepcionInterfazEvent
        Try
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Ingresar CLiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim frmInterfaseRecSAP As New frmInterfaseRecSAP
            frmInterfaseRecSAP.pCodigoCliente_CCLNT = txtCliente.pCodigo
            frmInterfaseRecSAP.pCodigoCompania_CCMPN = GLOBAL_COMPANIA
            frmInterfaseRecSAP.pRazonSocialCliente = txtCliente.pRazonSocial
            If frmInterfaseRecSAP.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBox.Show("Culminó Satisfactoriamente")
            End If
        Catch ex As Exception

        End Try
    End Sub



End Class

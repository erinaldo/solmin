'Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion
Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Imports RANSA.Utilitario
''' <summary>
''' Dagnino 09/25/2015
''' </summary>
''' <remarks></remarks>
Public Class frmRecepcionOC
#Region " Atributos "
    Private booStatus As Boolean = False
    Private strPersiana As String = "I"
    Private CurrentOrdenCompra As TD_OrdenCompraPK

    Private TD_ItemOC_Actual As TD_ItemOCPK = New Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
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
        dgItemsOC.strItem = String.Empty
        dgItemsOC.pActualizar(OrdenCompra)
        ListaMovimientoItemsDeOC(OrdenCompra.pNORCML_NroOrdenCompra)
        dgvMovimiento.AutoGenerateColumns = False
        dgvMovimiento.DataSource = dgOrdenCompra.ListarServicio(dgOrdenCompra.pOrdenCompraSeleccionada.pCCLNT_CodigoCliente, dgOrdenCompra.pOrdenCompraSeleccionada.pNORCML_NroOrdenCompra)
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
        tbpObservaciones.Parent = Nothing
        tbpMovimiento_DS.Parent = Nothing
        tbpMovimientos.Parent = Nothing
        tbcDetalles.SelectedTab = tbpDetalle
        If dgOrdenCompra.isDepositoSimple Then
            tbpMovimientos.Parent = Nothing
            Me.tbcDetalles.TabPages.Add(tbpMovimiento_DS)

        Else
            tbpMovimiento_DS.Parent = Nothing
            Me.tbcDetalles.TabPages.Add(tbpMovimientos)
            Me.tbcDetalles.TabPages.Add(tbpObservaciones)
        End If
        tbcDetalles.SelectTab(0)
    End Sub

    Private Sub dgItemsOC_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgItemsOC.Confirm
        If MessageBox.Show(strPregunta, "Recepceción:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub


    Private Sub dgItemsOC_CurrentRowChanged(ByVal Item As Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK) Handles dgItemsOC.CurrentRowChanged

        TD_ItemOC_Actual = Item

    End Sub

    Private Sub ListaMovimientoItemsDeOC(ByVal strOc As String, Optional ByVal decNrItem As Decimal = 0)
        If tbcDetalles.SelectedIndex = 1 Then
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PNCCLNT = Me.txtCliente.pCodigo
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = 0'UcPLanta_Cmb011.Planta
                .PSNORCML = strOc
            End With
            dgMovimientoItemOC.DataSource = obrBulto.ListarMovimientoItemOrdenCompra(obeBulto)
        End If
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
        OrdenCompra.pCCMPN_CodCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
        OrdenCompra.pCDVSN_CodDivision = UcDivision_Cmb011.Division
        OrdenCompra.pCPLNDV_CodPlanta = UcPLanta_Cmb011.Planta
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
        Try
            If ValidarContratro() Then Exit Sub
            Dim fRecepcionOCGenerarBulto As frmGenerarBultoN = New frmGenerarBultoN
            With fRecepcionOCGenerarBulto
                .pCodigoCliente_CCLNT = OrdenCompra.pCCLNT_CodigoCliente
                .pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
                .pStatusBultoNormal = True
                .pSoloLectura_QCNREC = False
                .pSoloLectura_TDAITM = False
                .pItemsSelec = ItemSelec
                .strDesPlanta = Me.UcPLanta_Cmb011.DescripcionPlanta

                Dim strLugarEntrega As String = ""
                For Each obeItem As TD_ItemOCForWayBill In ItemSelec
                    If strLugarEntrega <> "" And strLugarEntrega <> obeItem.pTLUGEN_LugarDeEntrega Then
                        If MessageBox.Show("Existen Items que van a diferentes lugares de Entrega." & _
                            Chr(10) & "¿Desea continuar?", "Información", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        Else
                            Exit For
                        End If
                    End If
                    strLugarEntrega = obeItem.pTLUGEN_LugarDeEntrega
                Next
                .pTotalItems = TotalItem
                .poHasSubItems = oHasSubItems
                .pCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
                .pDivision = UcDivision_Cmb011.Division
                .pPlanta = UcPLanta_Cmb011.Planta
                'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-001)-INICIO
                Dim obrBulto As New brBulto
                If obrBulto.ValidarClienteParaConfirmacion(OrdenCompra.pCCLNT_CodigoCliente) Then
                    Dim pCentroOrigen As New beInputValidarCentroOrigen
                    Dim centroOrigen As New CentroOrigen
                    With pCentroOrigen
                        .Cclnt = OrdenCompra.pCCLNT_CodigoCliente 'Cliente
                        .Norcml = OrdenCompra.pNORCML_NroOrdenCompra 'Orden de compra
                        .Item = dgItemsOC.ItemChecked 'Items
                    End With

                    centroOrigen.pCentroOrigen = pCentroOrigen
                    Dim output As String = centroOrigen.ValidarIngreso()
                    If Len(output) > 0 Then
                        MsgBox(output, MsgBoxStyle.Exclamation, "Advertencia")
                        Exit Sub
                    End If
                End If
                'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-001)-FIN
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    dgItemsOC.pRefrescar()
                    dgItemsOC.oHasSubItems = New Hashtable()
                End If
                .Dispose()
                fRecepcionOCGenerarBulto = Nothing
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
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

        objAppConfig = Nothing
        dgOrdenCompra.pUsuario = objSeguridadBN.pUsuario
        'dgOrdenCompra.pHostName = objSeguridadBN.pstrPCName
        dgItemsOC.pUsuario = objSeguridadBN.pUsuario
        dgMovimientoItemOC.AutoGenerateColumns = False
        dgvMovimiento.AutoGenerateColumns = False
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        dgOrdenCompra.pCCMPN_CodCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        dgItemsOC.pCCMPN_CodCompania = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        Me.tbpMovimiento_DS.Parent = Nothing

    End Sub

    'Private Sub txtCliente_ExitFocusWithOutData() Handles txtCliente.ExitFocusWithOutData
    '    dgOrdenCompra.pClear()
    'End Sub

    'Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
    '    dgOrdenCompra.pClear()
    '    If Me.txtCliente.pCodigo = 11232 Then
    '        '  Me.dgOrdenCompra.ImportarMasivoOC = True
    '    End If
    'End Sub

    Private Sub txtCliente_ExitFocusWithOutData() Handles txtCliente.ExitFocusWithOutData
        dgOrdenCompra.pClear()
        EnlazarCliente()
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgOrdenCompra.pClear()
        EnlazarCliente()
        Me.dgvMovimiento.DataSource = Nothing
        Me.dgMovimientoItemOC.DataSource = Nothing
    End Sub



    Private Sub EnlazarCliente()
        dgOrdenCompra.CCLNT_Pendiente_Cod_Cliente = txtCliente.pCodigo
        dgOrdenCompra.TCMPCL_Pendiente_Des_Cliente = txtCliente.pCodigo & " - " & txtCliente.pRazonSocial
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


    Private Sub tbcDetalles_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles tbcDetalles.Selecting
        ListaMovimientoItemsDeOC(dgOrdenCompra.pOrdenCompraSeleccionada.pNORCML_NroOrdenCompra)
    End Sub
#End Region
#Region " Métodos "

#End Region

    Private Sub dgMovimientoItemOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMovimientoItemOC.CellContentClick
        If dgMovimientoItemOC.Columns(e.ColumnIndex) Is M_IMBULTO Then
            '----------frmObservacionItemOC-------------
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
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

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
        dgOrdenCompra.pCCMPN_CodCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        dgItemsOC.pCCMPN_CodCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub dgItemsOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgItemsOC.Load
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    End Sub

    Private Sub dgOrdenCompra_TrasladoDeBultos() Handles dgOrdenCompra.TrasladoDeBultos
        Dim ofrmTraslado As New frmTrasladoBulto
        ofrmTraslado.PNCCLNT = Me.txtCliente.pCodigo
        ofrmTraslado.PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
        ofrmTraslado.PSCDVSN = Me.UcDivision_Cmb011.Division
        ofrmTraslado.PNCPLNDV = Me.UcPLanta_Cmb011.Planta
        If ofrmTraslado.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call pActualizarInformacion()
        End If
    End Sub

    Private Sub dgItemsOC_GenerarRecojo(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As System.Collections.Generic.List(Of TD_ItemOCForWayBill), ByVal TotalItem As System.Collections.Generic.List(Of TD_ItemOCForWayBill), ByVal oHasSubItems As Hashtable) Handles dgItemsOC.GenerarRecojo
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
            .strDesPlanta = Me.UcPLanta_Cmb011.DescripcionPlanta
            Dim strLugarEntrega As String = ""
            For Each obeItem As TD_ItemOCForWayBill In ItemSelec
                If strLugarEntrega <> "" And strLugarEntrega <> obeItem.pTLUGEN_LugarDeEntrega Then
                    If MessageBox.Show("Existen Items que van a diferentes lugares de Entrega." & _
                        Chr(10) & "¿Desea continuar?", "Información", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        Exit For
                    End If
                End If
                strLugarEntrega = obeItem.pTLUGEN_LugarDeEntrega
            Next

            .poHasSubItems = oHasSubItems
            .pCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pDivision = UcDivision_Cmb011.Division
            .pPlanta = UcPLanta_Cmb011.Planta
            .pEstado = "Recojo"

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                dgItemsOC.pRefrescar()
                dgItemsOC.oHasSubItems = New Hashtable()
            End If
            .Dispose()
            fRecepcionOCGenerarBulto = Nothing
        End With
    End Sub

    Private Sub dgItemsOC_VerMovimiento_X_Item(ByVal TD_ItemOC_Actual As Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK) Handles dgItemsOC.VerMovimiento_X_Item
        Try
            Dim ofrmMovimientoxItem As New frmMovimientoxItem
            ofrmMovimientoxItem.pCCLNT = TD_ItemOC_Actual.pCCLNT_CodigoCliente
            ofrmMovimientoxItem.pCCMPN = TD_ItemOC_Actual.pCCMPN_Compania
            ofrmMovimientoxItem.pCDVSN = TD_ItemOC_Actual.pCDVSN_Division
            ofrmMovimientoxItem.pCPLNDV = TD_ItemOC_Actual.pCPLNDV_Planta
            ofrmMovimientoxItem.pNORCML = TD_ItemOC_Actual.pNORCML_NroOrdenCompra
            ofrmMovimientoxItem.pNRITOC = TD_ItemOC_Actual.pNRITOC_NroItemOC
            ofrmMovimientoxItem.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

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

    'Private Sub dgItemsOC_GenerarRecojo( OrdenCompra As TD_OrdenCompraPK,  ItemSelec As System.Collections.Generic.List`1,  TotalItem As System.Collections.Generic.List`1,  oHsSubItems As Hashtable)

    '    End Sub

    'Private Sub dgItemsOC_GenerarBulto( OrdenCompra As TD_OrdenCompraPK,  ItemSelec As System.Collections.Generic.List`1,  TotalItem As System.Collections.Generic.List`1,  oHsSubItems As Hashtable)

    '    End Sub
End Class

Imports SOLMIN_SC.Negocio
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports System.Web

Public Class frmOCDet
    Private Sub frmOCDet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            dgOrdenCompra.pUsuario = HelpUtil.UserName
            ' dgOrdenCompra.pCCMPN_CodCompania = GetCompania()
            dgItemsOC.pUsuario = HelpUtil.UserName
            'dgItemsOC.pCCMPN_CodCompania = GetCompania()
            Cargar_Transporte()
            cmbTermIternN.pCargarDatos("TERINT", "::TODOS::")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub
    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpUtil.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function
    Private Sub Cargar_Transporte()
        Dim oEnvio As New clsEnvio
        cmbTransporte.DataSource = oEnvio.Listar_Envio
        cmbTransporte.ValueMember = "CMEDTR"
        cmbTransporte.DisplayMember = "TNMMDT"
    End Sub

    Private Sub Buscar_Orden_Compra()

        dgOrdenCompra.pCCMPN_CodCompania = GetCompania()
        dgItemsOC.pCCMPN_CodCompania = GetCompania()

        Dim TermIntern As String = ""
        Dim objFiltroOC As TD_Qry_OrdenCompra_L01 = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_Qry_OrdenCompra_L01
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        objFiltroOC.pCCLNT_CodigoCliente = Me.cmbCliente.pCodigo
        If Me.chxFecha.Checked Then
            Date.TryParse(Me.dtpFin.Text, objFiltroOC.pFORCML_FechaOC_Final)
            Date.TryParse(Me.dtpInicio.Text, objFiltroOC.pFORCML_FechaOC_Inicio)
        End If
        If Me.chxOC.Checked Then
            objFiltroOC.pNORCML_NroOrdenCompra = Me.txtOC.Text.Trim
        Else
            objFiltroOC.pNORCML_NroOrdenCompra = ""
        End If
        If Me.chxReq.Checked Then
            objFiltroOC.pNREFCL_ReferenciaCliente = "*" & Me.txtReq.Text & "*"
        Else
            objFiltroOC.pNREFCL_ReferenciaCliente = ""
        End If
        objFiltroOC.pCPRVCL_Proveedor = UcProveedor.pCodigo
        objFiltroOC.pTTINTC_TermInterCarga = cmbTermIternN.pInformacionSelec.pCCMPRN_Codigo
        objFiltroOC.pCMEDTR_MedioTransporte = Me.cmbTransporte.SelectedValue
        objFiltroOC.pTTINTC_TermInterCarga = cmbTermIternN.pInformacionSelec.pCCMPRN_Codigo
        dgOrdenCompra.pActualizar(objFiltroOC)
    End Sub

    Private Sub dgOrdenCompra_Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgOrdenCompra.Confirmar
        If MessageBox.Show("Está seguro de eliminar la O/C?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgOrdenCompra_CurrentRowChanged(ByVal OrdenCompra As Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK) Handles dgOrdenCompra.CurrentRowChanged
        dgItemsOC.pActualizar(OrdenCompra)
    End Sub

    Private Sub dgOrdenCompra_DataLoadCompleted(ByVal OrdenCompra As Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK) Handles dgOrdenCompra.DataLoadCompleted
        dgItemsOC.pActualizar(OrdenCompra)
    End Sub

    Private Sub dgOrdenCompra_ErrorMessage(ByVal strMensaje As String) Handles dgOrdenCompra.ErrorMessage
        HelpUtil.MsgBox(strMensaje)
    End Sub

    Private Sub dgOrdenCompra_Message(ByVal strMensaje As String) Handles dgOrdenCompra.Message
        HelpUtil.MsgBox(strMensaje)
    End Sub

    Private Sub dgOrdenCompra_TableWithOutData() Handles dgOrdenCompra.TableWithOutData
        dgItemsOC.pClear()
    End Sub

    Private Sub dgItemsOC_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgItemsOC.Confirm
        If MessageBox.Show("Está seguro de eliminar el item de la O/C?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgItemsOC_DeleteHeadOC() Handles dgItemsOC.DeleteHeadOC
        dgOrdenCompra.pRefrescar()
    End Sub

    Private Sub chxOC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chxOC.CheckedChanged
        If chxOC.Checked Then
            Me.txtOC.Enabled = True
        Else
            Me.txtOC.Enabled = False
        End If
    End Sub

    Private Sub chxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chxFecha.CheckedChanged
        If chxFecha.Checked Then
            Me.dtpInicio.Enabled = True
            Me.dtpFin.Enabled = True
        Else
            Me.dtpInicio.Enabled = False
            Me.dtpFin.Enabled = False
        End If
    End Sub

    Private Sub dgItemsOC_ErrorMessage(ByVal strMensaje As String) Handles dgItemsOC.ErrorMessage
        HelpUtil.MsgBox(strMensaje)
    End Sub

    Private Sub dgItemsOC_Message(ByVal strMensaje As String) Handles dgItemsOC.Message
        HelpUtil.MsgBox(strMensaje)
    End Sub

    Private Sub chxReq_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chxReq.CheckedChanged
        If chxReq.Checked Then
            Me.txtReq.Enabled = True
        Else
            Me.txtReq.Enabled = False
        End If
    End Sub

    Private Sub cmbCliente_ExitFocusWithOutData() Handles cmbCliente.ExitFocusWithOutData
        dgOrdenCompra.pClear()
      
    End Sub

    Private Sub cmbCliente_InformationChanged() Handles cmbCliente.InformationChanged
        dgOrdenCompra.pClear()
    End Sub

    Private Sub cmbCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.Load
        dgOrdenCompra.pClear()
    End Sub

    Private Sub cmbCliente_TextChanged() Handles cmbCliente.TextChanged
        Dim PNCCLNT As Decimal = 0
        dgOrdenCompra.pClear()
        dgItemsOC.pClear()
        If Me.cmbCliente.pCodigo <> 0 Then
            If Me.cmbCliente.pCodigo > 0 Then
                PNCCLNT = Me.cmbCliente.pCodigo
            Else
                Exit Sub
            End If
        End If

    End Sub
    Private Sub dgOrdenCompra_BuscarOrdenCompra() Handles dgOrdenCompra.BuscarOrdenCompra
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Buscar_Orden_Compra()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dgOrdenCompra_ImportacionMIQ() Handles dgOrdenCompra.ImportacionMIQ
        Buscar_Orden_Compra()
    End Sub
End Class
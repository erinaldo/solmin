Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.OrdenCompra
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.OrdenCompra

Public Class ucItemOC_MItem
#Region " Tipo "
    
#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private TD_ItemPK As TD_ItemOCPK = New TD_ItemOCPK
    Private strUsuario As String = ""
    Private strMensajeError As String = ""
    Private blnResultado As Boolean = False
#End Region
#Region " Propiedades "
    Public WriteOnly Property pOrdenCompra() As TD_OrdenCompraPK
        Set(ByVal value As TD_OrdenCompraPK)
            TD_ItemPK.pCCLNT_CodigoCliente = value.pCCLNT_CodigoCliente
            TD_ItemPK.pNORCML_NroOrdenCompra = value.pNORCML_NroOrdenCompra
        End Set
    End Property

    Public WriteOnly Property pItemOC() As TD_ItemOC
        Set(ByVal value As TD_ItemOC)
            Call pCargarItemOC(value)
        End Set
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Public Property pHabilitarNroItem() As Boolean
        Get
            Return txtNroItemOC.Enabled
        End Get
        Set(ByVal value As Boolean)
            txtNroItemOC.Enabled = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidarItemOC() As Boolean
        Dim strMensajeError As String = ""
        Dim blnEstado As Boolean = True

        If txtNroItemOCCliente.Text = "" Then
            strMensajeError &= "Debe ingresar Nro. de Item Cliente." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtDescripcionItemES.Text = "" Then
            strMensajeError &= "Debe ingresar la descripción del Item." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtCantidadItem.Text <= 0 Then
            strMensajeError &= "Debe ingresar alguna cantidad mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If cbxUnidadMedida.Text = "" Then
            strMensajeError &= "Debe ingresar la Unidad del Item." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtToleranciaMax.Text < 0 Then
            strMensajeError &= "Debe ingresar una Tolerancia Máx. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtToleranciaMin.Text < 0 Then
            strMensajeError &= "Debe ingresar una Tolerancia Mín. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If Decimal.Parse(txtToleranciaMin.Text) > Decimal.Parse(txtToleranciaMax.Text) Then
            strMensajeError &= "Tolerancia Mín. debe ser menor a la Tolerancia Máx." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtLugarEntrega.Text = "" Then
            strMensajeError &= "Debe ingresar el Lugar de Entrega." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnEstado = False
        End If
        Return blnEstado
    End Function

    Private Sub pCargarItemOC(ByVal objItemOC As TD_ItemOC)
        With objItemOC
            TD_ItemPK.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            TD_ItemPK.pNORCML_NroOrdenCompra = .pNORCML_NroOrdenCompra
            TD_ItemPK.pNRITOC_NroItemOC = .pNRITOC_NroItemOC
            txtNroItemOC.Text = .pNRITOC_NroItemOC
            txtNroItemOCCliente.Text = .pTCITCL_CodigoCliente.Trim
            txtNroItemOCProveedor.Text = .pTCITPR_CodigoProveedor.Trim
            txtDescripcionItemES.Text = .pTDITES_DescripcionES.Trim
            txtDescripcionItemIN.Text = .pTDITIN_DescripcionIN.Trim
            txtCantidadItem.Text = .pQCNTIT_Cantidad
            cbxUnidadMedida.Text = .pTUNDIT_Unidad
            txtImporteUnitario.Text = .pIVUNIT_ImporteUnitario
            txtImporteTotal.Text = .pIVTOIT_ImporteTotal
            txtToleranciaMax.Text = .pQTOLMAX_ToleranciaMax
            txtToleranciaMin.Text = .pQTOLMIN_ToleranciaMin
            If .pFMPDME_FechaEstEntregaInt <> 0 Then
                txtFechaEstEntrega.Value = .pFMPDME_FechaEstEntregaDte
                txtFechaEstEntrega.Checked = True
            Else
                txtFechaEstEntrega.Checked = False
            End If
            If .pFMPIME_FechaReqPlantaInt <> 0 Then
                txtFechaReqPlanta.Value = .pFMPIME_FechaReqPlantaDte
                txtFechaReqPlanta.Checked = True
            Else
                txtFechaReqPlanta.Checked = False
            End If
            txtLugarOrigen.Text = .pTLUGOR_LugarOrigen.Trim
            txtLugarEntrega.Text = .pTLUGEN_LugarEntrega.Trim
        End With
    End Sub

    Private Sub pClear()
        txtNroItemOCCliente.Text = ""
        txtNroItemOCProveedor.Text = ""
        txtDescripcionItemES.Text = ""
        txtDescripcionItemIN.Text = ""
        txtCantidadItem.Text = "0"
        'txtUnidadMedida.Text = ""
        txtImporteUnitario.Text = "0.00"
        txtImporteTotal.Text = "0.00"
        txtToleranciaMax.Text = "0"
        txtToleranciaMin.Text = "0"
        txtFechaEstEntrega.Text = ""
        txtFechaReqPlanta.Text = ""
        'txtLugarOrigen.Text = ""
        'txtLugarEntrega.Text = ""
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If fblnValidarItemOC() Then
            Dim TD_Item As TD_ItemOC = New TD_ItemOC
            With TD_Item
                .pCCLNT_CodigoCliente = TD_ItemPK.pCCLNT_CodigoCliente
                .pNORCML_NroOrdenCompra = TD_ItemPK.pNORCML_NroOrdenCompra
                Int32.TryParse(txtNroItemOC.Text, .pNRITOC_NroItemOC)
                .pTCITCL_CodigoCliente = txtNroItemOCCliente.Text.Trim
                .pTCITPR_CodigoProveedor = txtNroItemOCProveedor.Text.Trim
                .pTDITES_DescripcionES = txtDescripcionItemES.Text.Trim
                .pTDITIN_DescripcionIN = txtDescripcionItemIN.Text.Trim
                Decimal.TryParse(txtCantidadItem.Text, .pQCNTIT_Cantidad)
                .pTUNDIT_Unidad = cbxUnidadMedida.Text
                Decimal.TryParse(txtImporteUnitario.Text, .pIVUNIT_ImporteUnitario)
                Decimal.TryParse(txtImporteTotal.Text, .pIVTOIT_ImporteTotal)
                Decimal.TryParse(txtToleranciaMax.Text, .pQTOLMAX_ToleranciaMax)
                Decimal.TryParse(txtToleranciaMin.Text, .pQTOLMIN_ToleranciaMin)
                If txtFechaEstEntrega.Checked Then .pFMPDME_FechaEstEntregaDte = txtFechaEstEntrega.Value
                If txtFechaReqPlanta.Checked Then .pFMPIME_FechaReqPlantaDte = txtFechaReqPlanta.Value
                .pTLUGOR_LugarOrigen = txtLugarOrigen.Text
                .pTLUGEN_LugarEntrega = txtLugarEntrega.Text
            End With
            ' Limpio los controles de entrada de información
            If daoItemOC.Grabar(objSqlManager, TD_Item, strUsuario, strMensajeError) Then
                txtNroItemOC.Text = "0"
                Call pClear()
                If Not txtNroItemOC.Enabled Then
                    blnResultado = True
                    Me.Close()
                Else
                    txtNroItemOC.Focus()
                End If
            Else
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
    End Sub

    Private Sub txtCantidadItem_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadItem.Validated
        txtImporteTotal.Text = Decimal.Parse(txtCantidadItem.Text) * Decimal.Parse(txtImporteUnitario.Text)
    End Sub

    Private Sub txtImporteUnitario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteUnitario.Validated
        txtImporteTotal.Text = Decimal.Parse(txtCantidadItem.Text) * Decimal.Parse(txtImporteUnitario.Text)
    End Sub

    Private Sub txtNroItemOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroItemOC.TextChanged
        txtNroItemOC.CausesValidation = True
    End Sub

    Private Sub txtNroItemOC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroItemOC.Validating
        Dim intTemp As Int32 = 0
        If Int32.TryParse(txtNroItemOC.Text, intTemp) Then
            Dim objItemOCPK As TD_ItemOCPK = New TD_ItemOCPK
            objItemOCPK.pCCLNT_CodigoCliente = TD_ItemPK.pCCLNT_CodigoCliente
            objItemOCPK.pNORCML_NroOrdenCompra = TD_ItemPK.pNORCML_NroOrdenCompra
            objItemOCPK.pNRITOC_NroItemOC = intTemp
            Dim objItemOC As TD_ItemOC = daoItemOC.Obtener(objSqlManager, objItemOCPK, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call pClear()
                If objItemOC.pNRITOC_NroItemOC <> 0 Then pCargarItemOC(objItemOC)
            End If
        Else
                txtNroItemOC.Text = "0"
        End If
        txtNroItemOC.CausesValidation = False
    End Sub

    Private Sub ucItemOC_DgF01_MItem_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucItemOC_DgF01_MItem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub

    Private Sub ucItemOC_DgF01_MItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager
        Dim dtTemp As DataTable = daoItemOC.fdtListar_Unidades_L01(objSqlManager, strMensajeError)
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            If dtTemp.Rows.Count > 0 Then
                Dim rwTemp As DataRow
                For Each rwTemp In dtTemp.Rows
                    cbxUnidadMedida.Items.Add(("" & rwTemp.Item(0)).ToString.Trim)
                Next
            End If
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
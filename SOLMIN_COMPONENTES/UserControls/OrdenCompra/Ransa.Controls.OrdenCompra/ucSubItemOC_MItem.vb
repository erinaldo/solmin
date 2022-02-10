Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.DAO.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef.OrdenCompra.SubItemOC

Public Class ucSubItemOC_MItem
#Region " Definición Eventos "
    '-------------------------------------------------
    ' Eventos a Informar
    '-------------------------------------------------
    Public Event pDisposeForm(ByVal bStatusProceso As Boolean)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private objSqlManager As SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oSaveInfForm As cSaveInfForm = New Ransa.Rutime.CtrlsSolmin.cSaveInfForm(Application.ProductName, "ManSubItemOC.xml")
    Private TD_SubItemPK As TD_SubItemOCPK = New Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOCPK

    Private sDetalleSubItemOld As String = ""
    Private strMensajeError As String = ""
    Private nNroRegGrabados As Int16 = 0
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public Property pHabilitarNroSubItem() As Boolean
        Get
            Return txtNroSubItemOC.Enabled
        End Get
        Set(ByVal value As Boolean)
            txtNroSubItemOC.Enabled = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidarSubItemOC() As Boolean
        Dim strMensajeError As String = ""
        Dim blnEstado As Boolean = True

        If txtNroSubItemOCCliente.Text = "" Then
            strMensajeError &= "Debe ingresar Nro. de Sub Item Cliente." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtDescripcionSubItemES.Text = "" Then
            strMensajeError &= "Debe ingresar la descripción del Sub Item." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtCantidadSubItem.Text <= 0 Then
            strMensajeError &= "Debe ingresar alguna cantidad mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnEstado = False
        End If
        Return blnEstado
    End Function

    Private Sub pCargarSubItemOC(ByVal objSubItemOC As TD_SubItemOC)
        With objSubItemOC
            TD_SubItemPK.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            TD_SubItemPK.pNORCML_NroOrdenCompra = .pNORCML_NroOrdenCompra
            TD_SubItemPK.pNRITOC_NroItemOC = .pNRITOC_NroItemOC
            TD_SubItemPK.pSBITOC_NroSubItemOC = .pSBITOC_NroSubItemOC
            txtNroSubItemOC.Text = .pSBITOC_NroSubItemOC
            txtNroSubItemOCCliente.Text = .pTCITCL_CodigoCliente.Trim
            txtNroSubItemOCProveedor.Text = .pTCITPR_CodigoProveedor.Trim
            txtDescripcionSubItemES.Text = .pTDITES_DescripcionES.Trim
            sDetalleSubItemOld = txtDescripcionSubItemES.Text.ToUpper.Trim
            txtCantidadSubItem.Text = .pQCNTIT_Cantidad
            cbxUnidadMedida.Text = .pTUNDIT_Unidad
            txtImporteUnitario.Text = .pIVUNIT_ImporteUnitario
            txtImporteTotal.Text = .pIVTOIT_ImporteTotal
        End With
    End Sub

    Private Sub pClear()
        txtNroSubItemOCCliente.Text = ""
        txtNroSubItemOCProveedor.Text = ""
        txtDescripcionSubItemES.Text = ""
        txtCantidadSubItem.Text = "0"
        txtImporteUnitario.Text = "0.00"
        txtImporteTotal.Text = "0.00"
    End Sub

    Private Sub pGrabarParametros()
        Dim dtParameters As DataTable = New DataTable("Parameters")
        Dim rwParameter As DataRow
        Try
            With dtParameters
                .Columns.Add("TCITCL", System.Type.GetType("System.String"))
                .Columns.Add("TCITPR", System.Type.GetType("System.String"))
                .Columns.Add("TDITES", System.Type.GetType("System.String"))
                .Columns.Add("TUNDIT", System.Type.GetType("System.String"))
            End With
            ' Obtenemos el formato de la Fila
            rwParameter = dtParameters.NewRow
            With rwParameter
                .Item("TCITCL") = txtNroSubItemOCCliente.Text.Trim
                .Item("TCITPR") = txtNroSubItemOCProveedor.Text.Trim
                .Item("TDITES") = txtDescripcionSubItemES.Text.Trim
                .Item("TUNDIT") = cbxUnidadMedida.Text
            End With
            dtParameters.Rows.Add(rwParameter)
            ' Guardamos la función 
            Call oSaveInfForm.pSetParametros(dtParameters)
        Catch ex As Exception
        Finally
            dtParameters.Dispose()
            dtParameters = Nothing
            cMemory.ClearMemory()
        End Try
    End Sub

    Private Sub pObtenerParametros()
        Dim dtParameters As DataTable = New DataTable("Parameters")
        Try
            With dtParameters
                .Columns.Add("TCITCL", System.Type.GetType("System.String"))
                .Columns.Add("TCITPR", System.Type.GetType("System.String"))
                .Columns.Add("TDITES", System.Type.GetType("System.String"))
                .Columns.Add("TUNDIT", System.Type.GetType("System.String"))
            End With
            Call oSaveInfForm.pGetParametros(dtParameters)
            ' Valido que exista data
            If dtParameters.Rows.Count = 0 Then Exit Sub
            ' Se carga la información obtenida
            With dtParameters.Rows(0)
                txtNroSubItemOCCliente.Text = .Item("TCITCL")
                txtNroSubItemOCProveedor.Text = .Item("TCITPR")
                txtDescripcionSubItemES.Text = .Item("TDITES")
                sDetalleSubItemOld = txtDescripcionSubItemES.Text.ToUpper.Trim
                cbxUnidadMedida.Text = .Item("TUNDIT")
            End With
        Catch ex As Exception
        Finally
            dtParameters.Dispose()
            dtParameters = Nothing
            cMemory.ClearMemory()
        End Try
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Item As TD_ItemOCPK, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TD_SubItemPK.pCCLNT_CodigoCliente = Item.pCCLNT_CodigoCliente
        TD_SubItemPK.pNORCML_NroOrdenCompra = Item.pNORCML_NroOrdenCompra
        TD_SubItemPK.pNRITOC_NroItemOC = Item.pNRITOC_NroItemOC
        ' Llenamos la información de los Lugares de Entrega para un cliente
        strUsuario = Usuario
    End Sub

    Sub New(ByVal SubItem As TD_SubItemOC, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Call pCargarSubItemOC(SubItem)
        strUsuario = Usuario
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If fblnValidarSubItemOC() Then
            Dim TD_subItem As TD_SubItemOC = New TD_SubItemOC
            With TD_subItem
                .pCCLNT_CodigoCliente = TD_SubItemPK.pCCLNT_CodigoCliente
                .pNORCML_NroOrdenCompra = TD_SubItemPK.pNORCML_NroOrdenCompra
                .pNRITOC_NroItemOC = TD_SubItemPK.pNRITOC_NroItemOC
                .pSBITOC_NroSubItemOC = txtNroSubItemOC.Text
                .pTCITCL_CodigoCliente = txtNroSubItemOCCliente.Text.Trim
                .pTCITPR_CodigoProveedor = txtNroSubItemOCProveedor.Text.Trim
                .pTDITES_DescripcionES = txtDescripcionSubItemES.Text.Trim
                Decimal.TryParse(txtCantidadSubItem.Text, .pQCNTIT_Cantidad)
                .pTUNDIT_Unidad = cbxUnidadMedida.Text
                Decimal.TryParse(txtImporteUnitario.Text, .pIVUNIT_ImporteUnitario)
                Decimal.TryParse(txtImporteTotal.Text, .pIVTOIT_ImporteTotal)
            End With
            ' Limpio los controles de entrada de información
            If CSubItemOrdenCompra.Grabar(objSqlManager, TD_subItem, strUsuario, strMensajeError) Then
                nNroRegGrabados += 1
                If Not txtNroSubItemOC.Enabled Then
                    Me.Close()
                Else
                    txtNroSubItemOC.Text = ""
                    Call pClear()
                    txtNroSubItemOC.Focus()
                End If
            Else
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCantidadSubItem_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadSubItem.Validated
        txtImporteTotal.Text = Math.Round(Decimal.Parse(txtCantidadSubItem.Text) * Decimal.Parse(txtImporteUnitario.Text), 5)
    End Sub

    Private Sub txtDescripcionSubItemES_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcionSubItemES.Validated
        sDetalleSubItemOld = txtDescripcionSubItemES.Text.ToUpper.Trim
    End Sub

    Private Sub txtImporteUnitario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteUnitario.Validated
        txtImporteTotal.Text = Math.Round(Decimal.Parse(txtCantidadSubItem.Text) * Decimal.Parse(txtImporteUnitario.Text), 5)
    End Sub

    Private Sub txtNroSubItemOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroSubItemOC.TextChanged
        txtNroSubItemOC.CausesValidation = True
    End Sub

    Private Sub txtNroSubItemOC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroSubItemOC.Validating
        Dim objSubItemOCPK As TD_SubItemOCPK = New TD_SubItemOCPK
        objSubItemOCPK.pCCLNT_CodigoCliente = TD_SubItemPK.pCCLNT_CodigoCliente
        objSubItemOCPK.pNORCML_NroOrdenCompra = TD_SubItemPK.pNORCML_NroOrdenCompra
        objSubItemOCPK.pNRITOC_NroItemOC = TD_SubItemPK.pNRITOC_NroItemOC
        objSubItemOCPK.pSBITOC_NroSubItemOC = Me.txtNroSubItemOC.Text
        Dim objSubItemOC As TD_SubItemOC = CSubItemOrdenCompra.Obtener(objSqlManager, objSubItemOCPK, strMensajeError)
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call pClear()
            If objSubItemOC.pNRITOC_NroItemOC <> 0 Then pCargarSubItemOC(objSubItemOC)
        End If
        txtNroSubItemOC.CausesValidation = False
    End Sub

    Private Sub ucSubItemOC_DgF01_MItem_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not oSaveInfForm Is Nothing Then oSaveInfForm.Dispose()
        oSaveInfForm = Nothing

        If Not objSqlManager Is Nothing Then objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucSubItemOC_MItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim bStatusOperacion As Boolean = IIf(nNroRegGrabados > 0, True, False)
        RaiseEvent pDisposeForm(bStatusOperacion)
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class

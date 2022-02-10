

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC

Public Class ucItemOC_MItem
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
    Private objSqlManager As SqlManager = New SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oSaveInfForm As cSaveInfForm = New cSaveInfForm(Application.ProductName, "ManItemOC.xml")
    Private TD_ItemPK As TD_ItemOCPK = New TD_ItemOCPK

    Private sDetalleItemOld As String = ""
    Private strMensajeError As String = ""
    Private nNroRegGrabados As Int16 = 0
    Private oMSubItemOC As ucSubItemOC_MItem = Nothing
    Private _pCCLIENT_CodigoClinteYRC As Decimal = 0
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public Property pHabilitarNroItem() As Boolean
        Get
            Return txtNroItemOC.Enabled
        End Get
        Set(ByVal value As Boolean)
            txtNroItemOC.Enabled = value
        End Set
    End Property

    Private _phabilitarBulto As Boolean
    Public Property phabilitarBulto() As Boolean
        Get
            Return _phabilitarBulto
        End Get
        Set(ByVal value As Boolean)
            _phabilitarBulto = value
        End Set
    End Property

#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidarItemOC() As Boolean
        Dim strMensajeError As String = ""
        Dim blnEstado As Boolean = True

        'If txtNroItemOCCliente.Text = "" Then
        '    strMensajeError &= "Debe ingresar Nro. de Item Cliente." & Convert.ToChar(10) & Convert.ToChar(13)
        'End If
        If txtDescripcionItemES.Text = "" Then
            strMensajeError &= "Debe ingresar la descripción del Item." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtCantidadItem.Text <= 0 Then
            strMensajeError &= "Debe ingresar alguna cantidad mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        'If cbxUnidadMedida.pInformacionSelec = "" Then
        '    strMensajeError &= "Debe ingresar la Unidad del Item." & Convert.ToChar(10) & Convert.ToChar(13)
        'End If
        If txtToleranciaMax.Text < 0 Then
            strMensajeError &= "Debe ingresar una Tolerancia Máx. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If txtToleranciaMin.Text < 0 Then
            strMensajeError &= "Debe ingresar una Tolerancia Mín. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        If Decimal.Parse(txtToleranciaMin.Text) > Decimal.Parse(txtToleranciaMax.Text) Then
            strMensajeError &= "Tolerancia Mín. debe ser menor a la Tolerancia Máx." & Convert.ToChar(10) & Convert.ToChar(13)
        End If
        'If cbxLugarEntrega.Text = "" Then
        '    strMensajeError &= "Debe ingresar el Lugar de Entrega." & Convert.ToChar(10) & Convert.ToChar(13)
        'End If
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnEstado = False
        End If
        Return blnEstado
    End Function

    Private Sub pCargarCbxLugarEntrega()
        Dim obrLugarEntrega As New NEGO.brGeneral
        Dim obeLugarentrega As New TYPEDEF.beGeneral
        With obeLugarentrega
            .PNCCLNT = TD_ItemPK.pCCLNT_CodigoCliente
        End With
        If TD_ItemPK.pCCLNT_CodigoCliente = 11731 OrElse TD_ItemPK.pCCLNT_CodigoCliente = 30507 OrElse TD_ItemPK.pCCLNT_CodigoCliente = 49490 OrElse TD_ItemPK.pCCLNT_CodigoCliente = 51991 OrElse TD_ItemPK.pCCLNT_CodigoCliente = 50068 Then
            lblLugarEntrega.Text = "Lote :"
            cbxLugarEntrega.DataSource = obrLugarEntrega.ListaLotesDeEntrega(obeLugarentrega)
            cbxLugarEntrega.ValueMember = "PSTLTECL"
            cbxLugarEntrega.DisplayMember = "PSTLUGEN"
            cbxLugarEntrega.DropDownStyle = ComboBoxStyle.DropDownList
        Else
            For Each obeLugarentrega In obrLugarEntrega.ListaLotesDeEntrega(obeLugarentrega)
                cbxLugarEntrega.Items.Add(obeLugarentrega.PSTLUGEN)
            Next
        End If
    End Sub

    Private Sub pCargarItemOC(ByVal objItemOC As TD_ItemOC)

        With objItemOC
            TD_ItemPK.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            TD_ItemPK.pNORCML_NroOrdenCompra = .pNORCML_NroOrdenCompra
            TD_ItemPK.pNRITOC_NroItemOC = .pNRITOC_NroItemOC
            txtNroItemOC.Text = .pNRITOC_NroItemOC
            txtNroItemOCCliente.Text = .pTCITCL_CodigoCliente.Trim
            txtNroItemOCProveedor.Text = .pTCITPR_CodigoProveedor.Trim
            txtDescripcionItemES.Text = .pTDITES_DescripcionES.Trim
            sDetalleItemOld = txtDescripcionItemES.Text.ToUpper.Trim
            txtDescripcionItemIN.Text = .pTDITIN_DescripcionIN.Trim
            txtCantidadItem.Text = .pQCNTIT_Cantidad
            cbxUnidadMedida.Text = .pTUNDIT_Unidad
            txtImporteUnitario.Text = .pIVUNIT_ImporteUnitario
            txtImporteTotal.Text = .pIVTOIT_ImporteTotal
            txtToleranciaMax.Text = .pQTOLMAX_ToleranciaMax
            txtToleranciaMin.Text = .pQTOLMIN_ToleranciaMin
            txtSolicitante.Text = .pTRFRN_RefSolicitante.Trim

            If .pFMPDME_FechaEstEntregaInt <> 0 AndAlso IsDate(.pFMPDME_FechaEstEntregaDte) AndAlso .pFMPDME_FechaEstEntregaInt <> 99991231 Then
                txtFechaEstEntrega.Value = .pFMPDME_FechaEstEntregaDte
                txtFechaEstEntrega.Checked = True
            Else
                txtFechaEstEntrega.Checked = False
            End If
            If .pFMPIME_FechaReqPlantaInt <> 0 AndAlso IsDate(.pFMPIME_FechaReqPlantaDte) AndAlso .pFMPIME_FechaReqPlantaInt <> 99991231 Then
                txtFechaReqPlanta.Value = .pFMPIME_FechaReqPlantaDte
                txtFechaReqPlanta.Checked = True
            Else
                txtFechaReqPlanta.Checked = False
            End If

            Call pCargarCboLugarOrigen()
            txtLugarOrigen.Text = .pTLUGOR_LugarOrigen.Trim

            Me.chkSeguimiento.Checked = IIf(.pFLGPEN_FlagSeguimiento.Trim.Equals(""), True, False)

            Me.txtCentroDeCosto.Text = .pTCTCST_CentroDeCosto
            Call pCargarCbxLugarEntrega()

            If TD_ItemPK.pCCLNT_CodigoCliente = 11731 OrElse TD_ItemPK.pCCLNT_CodigoCliente = 30507 OrElse TD_ItemPK.pCCLNT_CodigoCliente = 49490 Then
                cbxLugarEntrega.DropDownStyle = ComboBoxStyle.DropDownList
                cbxLugarEntrega.SelectedValue = .pTLUGEN_LugarEntrega.Trim
            Else
                cbxLugarEntrega.DropDownStyle = ComboBoxStyle.DropDown
                cbxLugarEntrega.Text = .pTLUGEN_LugarEntrega.Trim
            End If

            txtRefBotros.Text = .PTRFRNB_RefB
            txtRefCentroDes.Text = .PTRFRN1_CentroDestino
            txtRefAlmDest.Text = .PTRFRN2_AlmDestino
            txtDesRef3.Text = .PTRFRN3_Ref3
            txtRefalmProc4.Text = .PTRFRN4_AlmProcedencia
            txtrefDireccion5.Text = .PTRFRN5_Direccion5
            txtRefClaseValoracion.Text = .PTRFRN6_ClaseValoracion

            'cargando item codigo sunat
            Me.txtCodigoSunat.Text = .pUNSPSC_Sunat

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
        'cbxLugarEntrega.Text = ""
        txtRefBotros.Text = ""
        txtRefCentroDes.Text = ""
        txtRefAlmDest.Text = ""
        txtDesRef3.Text = ""
        txtRefalmProc4.Text = ""
        txtrefDireccion5.Text = ""
        txtRefClaseValoracion.Text = ""


    End Sub

    Private Sub pGrabarParametros()
        Dim dtParameters As DataTable = New DataTable("Parameters")
        Dim rwParameter As DataRow
        Try
            With dtParameters
                .Columns.Add("TCITCL", System.Type.GetType("System.String"))
                .Columns.Add("TCITPR", System.Type.GetType("System.String"))
                .Columns.Add("TDITES", System.Type.GetType("System.String"))
                .Columns.Add("TDITIN", System.Type.GetType("System.String"))
                .Columns.Add("TUNDIT", System.Type.GetType("System.String"))
                .Columns.Add("TLUGOR", System.Type.GetType("System.String"))
                .Columns.Add("TLUGEN", System.Type.GetType("System.String"))
            End With
            ' Obtenemos el formato de la Fila
            rwParameter = dtParameters.NewRow
            With rwParameter
                .Item("TCITCL") = txtNroItemOCCliente.Text.Trim
                .Item("TCITPR") = txtNroItemOCProveedor.Text.Trim
                .Item("TDITES") = txtDescripcionItemES.Text.Trim
                .Item("TDITIN") = txtDescripcionItemIN.Text.Trim
                .Item("TUNDIT") = cbxUnidadMedida.Text
                .Item("TLUGOR") = txtLugarOrigen.Text.Trim
                .Item("TLUGEN") = cbxLugarEntrega.Text.Trim
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
                .Columns.Add("TDITIN", System.Type.GetType("System.String"))
                .Columns.Add("TUNDIT", System.Type.GetType("System.String"))
                .Columns.Add("TLUGOR", System.Type.GetType("System.String"))
                .Columns.Add("TLUGEN", System.Type.GetType("System.String"))
            End With
            Call oSaveInfForm.pGetParametros(dtParameters)
            ' Valido que exista data
            If dtParameters.Rows.Count = 0 Then Exit Sub
            ' Se carga la información obtenida
            With dtParameters.Rows(0)
                txtNroItemOCCliente.Text = .Item("TCITCL")
                txtNroItemOCProveedor.Text = .Item("TCITPR")
                txtDescripcionItemES.Text = .Item("TDITES")
                sDetalleItemOld = txtDescripcionItemES.Text.ToUpper.Trim
                txtDescripcionItemIN.Text = .Item("TDITIN")
                cbxUnidadMedida.Text = .Item("TUNDIT")
                txtLugarOrigen.Text = .Item("TLUGOR")
                cbxLugarEntrega.Text = .Item("TLUGEN")
            End With
        Catch ex As Exception
        Finally
            dtParameters.Dispose()
            dtParameters = Nothing
            cMemory.ClearMemory()
        End Try
    End Sub

    Private Sub pDisposeFormServF01(ByVal StatusProceso As Boolean)
        ' Habilitamos el Formulario a través del KrytonPanel
        KryptonPanel.Enabled = True
        RemoveHandler oMSubItemOC.pDisposeForm, AddressOf pDisposeFormServF01
        oMSubItemOC.Dispose()
        oMSubItemOC = Nothing
        Call pClear()
        Me.txtNroItemOC.Focus()
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TD_ItemPK.pCCLNT_CodigoCliente = OrdenCompra.pCCLNT_CodigoCliente
        TD_ItemPK.pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
        ' Llenamos la información de los Lugares de Entrega para un cliente
        Call pCargarCbxLugarEntrega()
        strUsuario = Usuario
        'CargarClienteYRC()
        Call pCargarCboLugarOrigen()
    End Sub

    Sub New(ByVal Item As TD_ItemOC, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Call pCargarItemOC(Item)
        strUsuario = Usuario
        'CargarClienteYRC()

    End Sub

    'Private Sub CargarClienteYRC()
    '    Dim odaBasicClass As New NEGO.clsBasicClass()
    '    _pCCLIENT_CodigoClinteYRC = odaBasicClass.fdsCodigoClienteDelPortar(objSqlManager, "", TD_ItemPK.pCCLNT_CodigoCliente)
    '    If _pCCLIENT_CodigoClinteYRC <> 0 Then
    '        btnImportarYRC.Visible = True
    '    End If
    'End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Guardar()
    End Sub

    Private Function Guardar() As Double
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
                .pTLUGEN_LugarEntrega = cbxLugarEntrega.Text
                .pTCTCST_CentroDeCosto = Me.txtCentroDeCosto.Text
                .pTRFRN_RefSolicitante = txtSolicitante.Text
                .pFLGPEN_FlagSeguimiento = IIf(Me.chkSeguimiento.Checked, "", "*")
                'miguel 27012015
                ' .PTRFRNA_RefSolicitanteOA = txtrefsolicitante.Text
                '.PTRFRNA_RefA = txtreferenciaA.Text
                .PTRFRNB_RefB = txtRefBotros.Text
                .PTRFRN1_CentroDestino = txtRefCentroDes.Text
                .PTRFRN2_AlmDestino = txtRefAlmDest.Text
                .PTRFRN3_Ref3 = txtDesRef3.Text
                .PTRFRN4_AlmProcedencia = txtRefalmProc4.Text
                .PTRFRN5_Direccion5 = txtrefDireccion5.Text
                .PTRFRN6_ClaseValoracion = txtRefClaseValoracion.Text

                'guardar codigo sunat
                .pUNSPSC_Sunat = txtCodigoSunat.Text


            End With
            ' Limpio los controles de entrada de información
            If cItemOrdenCompra.Grabar(objSqlManager, TD_Item, strUsuario, strMensajeError) Then
                nNroRegGrabados += 1
                If Not txtNroItemOC.Enabled Then
                    Return True
                Else
                    TD_ItemPK.pNRITOC_NroItemOC = txtNroItemOC.Text
                    txtNroItemOC.Text = "0"
                    Call pClear()
                    txtNroItemOC.Focus()
                    Return True
                End If
            Else
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCantidadItem_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadItem.Validated
        txtImporteTotal.Text = Math.Round(Decimal.Parse(txtCantidadItem.Text) * Decimal.Parse(txtImporteUnitario.Text), 5)
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
        Call pGrabarParametros()
    End Sub

    Private Sub btnPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegar.Click
        Call pObtenerParametros()
        txtNroItemOCCliente.Focus()
    End Sub

    Private Sub txtDescripcionItemES_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcionItemES.Validated
        If sDetalleItemOld <> txtDescripcionItemES.Text.ToUpper.Trim Then
            txtDescripcionItemIN.Text = txtDescripcionItemES.Text
        End If
        sDetalleItemOld = txtDescripcionItemES.Text.ToUpper.Trim
    End Sub

    Private Sub txtDescripcionItemIN_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcionItemIN.GotFocus
        txtDescripcionItemIN.SelectAll()
    End Sub

    Private Sub txtImporteUnitario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteUnitario.Validated
        txtImporteTotal.Text = Math.Round(Decimal.Parse(txtCantidadItem.Text) * Decimal.Parse(txtImporteUnitario.Text), 5)
    End Sub

    Private Sub txtNroItemOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroItemOC.TextChanged
        txtNroItemOC.CausesValidation = True
    End Sub

    Private Sub txtNroItemOC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroItemOC.Validating
        Dim intTemp As Int32 = 0
        If Int32.TryParse(txtNroItemOC.Text, intTemp) Then
            If intTemp <> 0 Then
                Dim objItemOCPK As TD_ItemOCPK = New TD_ItemOCPK
                objItemOCPK.pCCLNT_CodigoCliente = TD_ItemPK.pCCLNT_CodigoCliente
                objItemOCPK.pNORCML_NroOrdenCompra = TD_ItemPK.pNORCML_NroOrdenCompra
                objItemOCPK.pNRITOC_NroItemOC = intTemp
                Dim objItemOC As TD_ItemOC = cItemOrdenCompra.Obtener(objSqlManager, objItemOCPK, strMensajeError)
                If strMensajeError <> "" Then
                    MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Call pClear()
                    If objItemOC.pNRITOC_NroItemOC <> 0 Then pCargarItemOC(objItemOC)
                End If
            Else
                Call pClear()
            End If
        Else
            txtNroItemOC.Text = "0"
        End If
        txtNroItemOC.CausesValidation = False
    End Sub

    Private Sub ucItemOC_DgF01_MItem_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not oSaveInfForm Is Nothing Then oSaveInfForm.Dispose()
        oSaveInfForm = Nothing

        If Not objSqlManager Is Nothing Then objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucItemOC_MItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim bStatusOperacion As Boolean = IIf(nNroRegGrabados > 0, True, False)
        RaiseEvent pDisposeForm(bStatusOperacion)
    End Sub

    Private Sub btnSubItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubItems.Click
        If Guardar() Then

            Dim Item As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
            With Item
                .pCCLNT_CodigoCliente = TD_ItemPK.pCCLNT_CodigoCliente
                .pNORCML_NroOrdenCompra = TD_ItemPK.pNORCML_NroOrdenCompra
                .pNRITOC_NroItemOC = TD_ItemPK.pNRITOC_NroItemOC
            End With
            Dim oucListaSubItemOC As New ucListaSubItemOC_DgF01(Item)
            oucListaSubItemOC.ShowDialog()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region


    Private Sub btnImportarYRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarYRC.Click
        Try

            Dim strError As String = ""
            Dim sDefault_Peso As String = ""
            Dim oImportasOC As New TypeDef.OrdenCompra.ImportarOC.ImportarOcYRC
            Dim oDtOCItem As DataTable
            If _pCCLIENT_CodigoClinteYRC = 0 Then Exit Sub
            oDtOCItem = oImportasOC.GetItems(_pCCLIENT_CodigoClinteYRC, TD_ItemPK.pNORCML_NroOrdenCompra)
            If oDtOCItem.Rows.Count > 0 Then
                txtNroItemOCCliente.Text = oDtOCItem.Rows(0).Item(2)
                txtDescripcionItemES.Text = oDtOCItem.Rows(0).Item(7)
                txtCantidadItem.Text = oDtOCItem.Rows(0).Item(3)

                'objSqlManager = New SqlManager()
                '-- Información Unidad Peso y Volumen
                'Dim oUnidad As DAO.Unidad.cUnidad = New DAO.Unidad.cUnidad
                Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
                '-- Peso
                Dim strResultado = oUnidad.fsBuscarAbreviatura(oDtOCItem.Rows(0).Item(4), sDefault_Peso)
                If Not strResultado.ToString.Trim.Equals("") Then
                    cbxUnidadMedida.Text = strResultado
                End If
                txtImporteUnitario.Text = oDtOCItem.Rows(0).Item(6)
                cbxLugarEntrega.Text = oDtOCItem.Rows(0).Item(9)
                txtImporteTotal.Text = Val(oDtOCItem.Rows(0).Item(3)) * Val(oDtOCItem.Rows(0).Item(6))
            End If

        Catch : End Try

    End Sub


    Private Sub pCargarCboLugarOrigen()
        Dim obrLugarOrigen As New NEGO.brGeneral

        txtLugarOrigen.DataSource = obrLugarOrigen.olLugarOrigen("")
        txtLugarOrigen.ValueMember = "PSCCMPRN"
        txtLugarOrigen.DisplayMember = "PSTDSDES"
        txtLugarOrigen.SelectedIndex = -1
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click

        If KryptonHeaderGroup2.Collapsed Then
            Me.Height = KryptonHeaderGroup1.Height + 300
            btnSubItems.Location = New Point(541, 513)
            btnAceptar.Location = New Point(643, 513)
            btnCancelar.Location = New Point(746, 513)

        Else
            Me.Height = KryptonHeaderGroup1.Height + 100

            btnSubItems.Location = New Point(541, 310)
            btnAceptar.Location = New Point(643, 310)
            btnCancelar.Location = New Point(746, 310)
        End If


    End Sub

   
   
    
    Private Sub ucItemOC_MItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

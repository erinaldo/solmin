'Imports SOLMIN_CTZ.Entidades.mantenimientos
'Imports SOLMIN_CTZ.NEGOCIO
'Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class frmAgregarServicioReembolso
    ''' <summary>
    ''' Variables
    ''' </summary>
    ''' <remarks></remarks>
    Private bolBuscar As Boolean = False
    Private _oServicio As Servicio_BE
    Private _oServReemb As ServicioReembolso_BE
    Private oDtAlmacenes As DataTable
    Private oDtZonas As DataTable
    Private dgBULTO As New DataTable
    Private estatico As New Estaticos
    Public oDtValidaDocumento As New DataTable
    Public oDtValidaDetraccion As New DataTable
    Private sNumeroDoc As String = String.Empty
    Private sNumeroRuc As String = String.Empty
    Private sTipoDoc As String = String.Empty

    '<[AHM]>
    Private oClaseGeneral As New clsClaseGeneral_BL
    Private oCentroCosto As New clsCentroCosto_BL
    Private ClienteInterno As Boolean = True

    Private _pCodigoCompania As String = ""
    Private ListSalmon As New Hashtable
    Private List_UnidadProductivaSAP As New Hashtable
    Private List_TipoServicioSAP As New Hashtable
    Public Property pCodigoCompania() As String
        Get
            Return _pCodigoCompania
        End Get
        Set(ByVal value As String)
            _pCodigoCompania = value
        End Set
    End Property

    Private _pNegocio As String = ""
    Public Property pNegocio() As String
        Get
            Return _pNegocio
        End Get
        Set(ByVal value As String)
            _pNegocio = value
        End Set
    End Property
    '</[AHM]>

    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property
    Public Property oServicioReembolso() As ServicioReembolso_BE
        Get
            Return _oServReemb
        End Get
        Set(ByVal value As ServicioReembolso_BE)
            _oServReemb = value
        End Set
    End Property
    Public ReadOnly Property valBULTO() As DataTable
        Get
            Return dgBULTO
        End Get
    End Property

    Private Sub frmAgregarServicioReembolso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarTipoActivoSAP()
        cargaTipoDocumento()
        'cargarCentroCostoOrigen()
        CargarLotes()
        cargarRubro()
        If _oServicio.TIPO = Comun.ESTADO_Modificado Then
            cmbRubro.SelectedValue = _oServicio.NRRUBR
            cmbServicio.SelectedValue = _oServicio.NRTFSV
            If Not _oServicio.TLUGEN Is Nothing Then
                cmbLote.SelectedValue = _oServicio.TLUGEN.Trim
            End If

            dteFechaServicio.Text = Comun.FormatoFecha(_oServicio.FATNSR)

            If Not _oServicio.NORCML Is Nothing Then
                txtOrdenCompra.Text = _oServicio.NORCML.Trim
            End If

            '<[AHM]>
            'If Not _oServicio.CCNTCS Is Nothing Then
            '    txtCentroCosto.Text = _oServicio.CCNTCS.Trim
            'End If
            '</[AHM]>


            '========Verificamos que tenga Cargo Plan========'
            If _oServReemb.NGUITR = 0 And _oServReemb.CTRMNC = 0 Then
                If Not _oServicio.TCTCST Is Nothing Then
                    txtCI.Text = _oServicio.TCTCST.Trim
                End If


            Else
                txtCI.Text = "IMP_CARGO_PLAN"
            End If
            txtNroDocumento.Text = _oServReemb.NUMDOC
            sNumeroDoc = _oServReemb.NUMDOC
            txtRUC.Text = _oServReemb.NRUCPR
            sNumeroRuc = _oServReemb.NRUCPR
            txtImporte.Text = _oServReemb.IMPFAC
            txtObservacion.Text = ("" & _oServReemb.TOBSSR & "").Trim
            cmbTipoDocumento.SelectedValue = _oServReemb.TPODOC
            sTipoDoc = _oServReemb.TPODOC
            'txtProveedor.Text = _oServReemb.TPRVD
            'Buscamos proveedor por el Ruc
            txtReferencia.Text = _oServicio.TRFSRC

            If _oServReemb.ITPCMT > 0 Then
                txtTC.txtDecimales.Text = _oServReemb.ITPCMT.ToString("N3")
            End If

            Dim oSe As New clsServicio_BL
            UcProveedor.ActualizarBusqueda(oSe.ObtieneCodigoProveedor(_oServReemb.NRUCPR))

            If IsNumeric(txtCentroCosto.Text) Then
                oDtCCosto = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)

                For Each dr As DataRow In oDtCCosto.Select("CCNTCS =" & txtCentroCosto.Text)
                    txtCentroCosto.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                Next

            End If

            If Not _oServReemb.FechaDeDocumento.Trim.Equals("") Then
                Me.dtpFechaDoc.Value = _oServReemb.FechaDeDocumento
            End If

            '<[AHM]>'
            txtTipoServicio.Valor = _oServicio.CDTSSP
            txtUnidadProductiva.Valor = _oServicio.CDUPSP
            cboTipoActivo.SelectedValue = _oServicio.PRCODI
            txtCentroCosto.Valor = _oServicio.CCNTCS

            txtTipoServicio.Enabled = False
            txtUnidadProductiva.Enabled = False
            cboTipoActivo.Enabled = False
            txtCentroCosto.Enabled = False
            '</[AHM]>'           

            'JM
            uCentroCostoOrig.Valor = _oServicio.CENCO2
            uCentroCostoDest.Valor = _oServicio.CENCOS
        End If
        'JM
        MostrarControlesClienteFacturar(_oServicio.CCMPN, _oServicio.CCLNFC)
    End Sub

    ''' <summary>
    ''' Cargar TipoDocumento
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargaTipoDocumento()
        Dim oTipoDocumento As New clsTipoDocumento_BL
        oTipoDocumento.Crea_TipoDocumento()
        Me.cmbTipoDocumento.DataSource = oTipoDocumento.Lista_TipoDocumento
        Me.cmbTipoDocumento.ValueMember = "CTPODC"
        Me.cmbTipoDocumento.DisplayMember = "TCMTPD"

        If _oServicio.CTPODC <> 0 Then
            cmbTipoDocumento.ComboBox.SelectedValue = _oServicio.CTPODC
        Else
            cmbTipoDocumento.ComboBox.SelectedValue = 1
        End If
    End Sub

    ''' <summary>
    ''' Cargar Cargar Lotes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarLotes()
        Dim oServicioOpeNeg As New clsServicio_BL
        Me.cmbLote.DataSource = oServicioOpeNeg.ListarLotes(_oServicio.CCLNT)
        Me.cmbLote.ValueMember = "TLTECL"
        Me.cmbLote.DisplayMember = "TLTECL"
        If _oServicio.TLUGEN <> "" Then
            cmbLote.SelectedValue = _oServicio.TLUGEN
        Else
            cmbLote.ComboBox.SelectedIndex = 0
        End If
    End Sub
    '''' <summary>
    '''' Cargar Campos
    '''' </summary>
    '''' <remarks></remarks>
    'Private Sub CargarCampos()
    '    Dim oDtDetReembolso As New DataTable
    '    Dim oServicioOpeNeg As New clsServicio_BL
    '    oDtDetReembolso = oServicioOpeNeg.fdtListaDetalleServiciosReembolso(_oServicio)
    '    If oDtDetReembolso.Rows.Count = 0 Then Exit Sub
    '    txtNroDocumento.Text = oDtDetReembolso.Rows(0).Item("NUMDOC").ToString.Trim
    '    'Buscar el proveedor por Nro RUC y debe ser unico
    '    '----------------------UcProveedor.ActualizarBusqueda(36422) 'Poner el codigo de proveedor---------------------------------
    '    txtRUC.Text = oDtDetReembolso.Rows(0).Item("NRUCPR").ToString.Trim
    '    txtImporte.Text = oDtDetReembolso.Rows(0).Item("IMPFAC").ToString.Trim
    '    txtProveedor.Text = oDtDetReembolso.Rows(0).Item("TPRVD").ToString.Trim
    '    txtObservacion.Text = oDtDetReembolso.Rows(0).Item("TOBSSR").ToString.Trim
    '    cmbTipoDocumento.SelectedValue = oDtDetReembolso.Rows(0).Item("TPODOC").ToString.Trim
    'End Sub
    ''' <summary>
    ''' Carga Rubro
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarRubro()
        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        bolBuscar = False
        oDt = oServicioBL.fdtListaRubroXCompaniaDivision(_oServicio)
        oDt.DefaultView.RowFilter = "NRRUBR = 7"
        oDt = oDt.DefaultView.ToTable
        cmbRubro.ComboBox.DataSource = oDt
        cmbRubro.ComboBox.ValueMember = "NRRUBR"
        bolBuscar = True
        cmbRubro.ComboBox.DisplayMember = "NOMRUB"
        cmbRubro_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    ''' <summary>
    ''' Selecciona el rubro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbRubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bolBuscar Then
            cargarServicio()
        End If
    End Sub
    ''' <summary>
    ''' Carga informacion del servicio
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarServicio()
        Dim oServicioBL As New clsServicio_BL
        _oServicio.NRRUBR = Me.cmbRubro.SelectedValue
        bolBuscar = False
        cmbServicio.ComboBox.DataSource = oServicioBL.Cargar_Servicios_Tarifa_Cliente(_oServicio)
        cmbServicio.ComboBox.ValueMember = "NRTFSV"
        bolBuscar = True
        cmbServicio.ComboBox.DisplayMember = "DESTAR"
    End Sub
    Private Sub cmbServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServicio.SelectedIndexChanged
        If bolBuscar Then
            cargarDatosServicio()
        End If
    End Sub
    ''' <summary>
    ''' Datos del Servicio
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarDatosServicio()
        Try
            Dim odtTarifa As New DataTable
            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(cmbServicio.SelectedValue)
            If (odtTarifa.Rows.Count > 0) Then
                txtCentroCosto.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim
                txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA_DESC").ToString.Trim
                Codigo = odtTarifa.Rows(0)("CCNTCS").ToString.Trim
                txtUnidadMedida.Text = odtTarifa.Rows(0)("CUNDMD").ToString.Trim
                txtMoneda.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim

                '<[AHM]>
                Dim CDSRSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSRSP").ToString()
                Dim CDSPSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSPSP").ToString()
                Dim CDTASP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDTASP").ToString()

                Dim CDTSSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDTSSP").ToString()
                Dim CDUPSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDUPSP").ToString()

                Me.CargarTipoServicioSAP(CDSRSP)
                Me.CargarUnidadProductivaSAP(CDSPSP)
                'Me.CargarTipoActivoSAP()

                txtTipoServicio.Valor = CDTSSP
                txtUnidadProductiva.Valor = CDUPSP
                cboTipoActivo.SelectedValue = CDTASP
                '</[AHM]>
                txtTarifaInterna.Text = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("ISRVTI").ToString()
                uCentroCostoOrig.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CENCO2").ToString()
                uCentroCostoDest.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CENCOS").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 
    Private Sub UcProveedor_InformationChanged() Handles UcProveedor.InformationChanged
        txtRUC.Text = UcProveedor.pNroRuc
    End Sub

    Private Sub UcProveedor_ExitFocusWithOutData() Handles UcProveedor.ExitFocusWithOutData
        txtRUC.Text = "" 'LIMPIAMOS
    End Sub

    Private Function validaDatos() As Boolean
        '<[AHM]>
        'If (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania) Then
        If PerteneceSalmon() Then
            '
            Dim TipoServicio As ClaseGeneral_BE = CType(txtTipoServicio.Resultado, ClaseGeneral_BE)
            Dim TipoActivo As ClaseGeneral_BE = CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE)
            Dim UnidadProductiva As ClaseGeneral_BE = CType(txtUnidadProductiva.Resultado, ClaseGeneral_BE)
            If (TipoServicio Is Nothing) Then
                MessageBox.Show("Debe de seleccionar el Tipo de Servicio  ", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            If (UnidadProductiva Is Nothing) Then
                MessageBox.Show("Debe de seleccionar  la  Unidad Productiva ", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            If (TipoActivo Is Nothing) Then
                MessageBox.Show("Debe de seleccionar el Tipo Activo ", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            If (txtCentroCosto.Resultado Is Nothing) Then
                MessageBox.Show("Ingrese Centro de Beneficio", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If


        'Dim cc() As String
        'If txtCentroCosto.Text.Trim.Length > 0 Then
        '    cc = txtCentroCosto.Text.Trim.Split("-")
        '    If cc.Length > 1 Then
        '        txtCentroCosto.Text = cc(0)
        '        'CargaCentroCosto()
        '    Else
        '        _oServicio.CCNTCS = "0"
        '    End If

        'End If
        'If txtCentroCosto.Text.Trim.Length = 0 Then
        '    MessageBox.Show("Ingrese Centro de Costo", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return False
        'End If
        'If Val(_oServicio.CCNTCS) = 0 Then
        '    MessageBox.Show("Ingrese Centro de Costo", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return False
        'End If
        '</[AHM]>

        If Val(_oServicio.CCNTCS) = 0 Then
            MessageBox.Show("Ingrese Centro de Costo", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If


        'Centro de costo origen y centro de costo destino 
        'son obligatorios si el cliente es interno
        If (ClienteInterno) Then
            Dim msje As String = ""
            If (uCentroCostoOrig.Resultado Is Nothing) Then
                msje = "Seleccione Centro Costo Origen." & Environment.NewLine
            End If
            If (uCentroCostoDest.Resultado Is Nothing) Then
                msje = msje & "Seleccione Centro Costo Destino." & Environment.NewLine
            End If
            If msje.Trim.Length > 0 Then
                MessageBox.Show(msje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click


        If Not validaDatos() Then Exit Sub

        'If Not ValidaDocumento() Then
        '    MessageBox.Show("Ya se agrego este número de documento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        'If Not ValidaDocuentoBD() Then
        '    Exit Sub
        'End If

        If Not ValidaDetraccion() Then
            Exit Sub
        End If

        ' Cargamos el objeto con la informacion del servicio seleccionado
        _oServicio.NRTFSV = cmbServicio.SelectedValue
        _oServicio.TARIFA_DESC = cmbServicio.Text

        _oServicio.VALCTE = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("VALCTE")
        _oServicio.CUNDMD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CUNDMD")
        ''_oServicio.CCNTCS = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
        _oServicio.CCNTCS = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
        _oServicio.IVLSRV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("IVLSRV")
        _oServicio.TSGNMN = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("TSGNMN")
        _oServicio.SRBAFD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("SRBAFD") 'DETRACCION
        _oServicio.CRGVTA = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CRGVTA") 'region venta
        _oServicio.QATNAN = 1 ' el importe es uno por defecto
        _oServicio.QATNRL = txtImporte.Text
        _oServicio.FATNSR = Format(dteFechaServicio.Value, "yyyyMMdd")
        _oServicio.TCTCST = txtCI.Text
        _oServicio.NORCML = txtOrdenCompra.Text

        _oServicio.TRFSRC = txtReferencia.Text.Trim

        If Not cmbLote.SelectedIndex = 0 Then
            _oServicio.TLUGEN = cmbLote.Text.Trim
        End If
        _oServicio.TSRVC = txtObservacion.Text.Trim

        _oServReemb.TOBSSR = txtObservacion.Text
        _oServReemb.TPRVD = UcProveedor.pRazonSocial
        _oServReemb.NRUCPR = UcProveedor.pNroRuc
        _oServReemb.TPODOC = cmbTipoDocumento.SelectedValue
        _oServReemb.NUMDOC = IIf(txtNroDocumento.Text = "", 0, txtNroDocumento.Text)
        _oServReemb.IMPFAC = txtImporte.Text
        _oServReemb.NRUCPR = Val(txtRUC.Text.Trim)
        _oServReemb.NGUITR = _oServicio.NGUITR
        _oServReemb.CTRMNC = _oServicio.CTRMNC
        _oServReemb.FechaDeDocumento = Me.dtpFechaDoc.Value
        _oServReemb.ITPCMT = Val("" & txtTC.txtDecimales.Text & "")
        '------------------------------------------
        _oServicio.CCNBNS = CType(txtCentroCosto.Resultado, CentroCosto_BE).PSCCNBNS
        If ClienteInterno Then
            _oServicio.CENCOS = CType(uCentroCostoDest.Resultado, CentroCosto_BE).PNCCNTCS
            _oServicio.CENCO2 = CType(uCentroCostoOrig.Resultado, CentroCosto_BE).PNCCNTCS
            _oServicio.ISRVTI = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("ISRVTI")
        Else
            _oServicio.CENCOS = 0
            _oServicio.CENCO2 = 0
            _oServicio.ISRVTI = 0
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function ValidaDocumento() As Boolean
        Dim nCantDoc As Integer = 0
        If _oServicio.TIPO = Comun.ESTADO_Modificado Then
            Dim blExisteRuc As Boolean = False

            oDtValidaDocumento.DefaultView.Sort = "NRUCPR"
            oDtValidaDocumento = oDtValidaDocumento.DefaultView.ToTable

            For Each dr As DataRow In oDtValidaDocumento.Select(" NRUCPR  = '" & txtRUC.Text & "' AND TPODOC ='" & cmbTipoDocumento.SelectedValue & "'")
                blExisteRuc = True
                Exit For
            Next
            If blExisteRuc Then
                If sNumeroDoc <> txtNroDocumento.Text Or sNumeroRuc <> txtRUC.Text Or sTipoDoc <> cmbTipoDocumento.SelectedValue.ToString Then
                    For Each dr As DataRow In oDtValidaDocumento.Select("NRUCPR = '" & txtRUC.Text & "' AND TPODOC ='" & cmbTipoDocumento.SelectedValue & "'")
                        If txtNroDocumento.Text = dr("NUMDOC") Then
                            Return False
                        End If

                    Next
                End If

            End If


        Else
            For Each dr As DataRow In oDtValidaDocumento.Select("NRUCPR = '" & txtRUC.Text & "'AND TPODOC ='" & cmbTipoDocumento.SelectedValue & "'")
                If txtNroDocumento.Text = dr("NUMDOC") Then
                    Return False
                End If

            Next
        End If


        Return True

    End Function


    Private Function ValidaDetraccion() As Boolean
        Dim strDetraccion As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("SRBAFD").ToString
        Dim strRegionVenta As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CRGVTA").ToString

        For Each dr As DataRow In oDtValidaDetraccion.Rows
            If dr("SRBAFD") <> strDetraccion Then
                If strDetraccion = "S" Then
                    MessageBox.Show("El servicio que se esta registrando a esta operación no debe tener  detracción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("El servicio registrando a esta operación debe tener detracción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                Return False
            End If

            'region venta
            If dr("CRGVTA") <> strRegionVenta Then
                MessageBox.Show("La región venta que esta agregando deben de ser iguales", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        Next

        Return True

    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCalculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculadora.Click
        'Abrir Calculadora Simple
        Dim frmCalc As New frmCalculadoraSimple
        frmCalc.result = IIf(txtImporte.Text = "", 0, txtImporte.Text)
        If txtTC.txtDecimales.Text.Length > 0 And Val("" & txtTC.txtDecimales.Text & "") > 0 Then
            frmCalc.txtTipoCambio.Text = txtTC.txtDecimales.Text
        End If

        If frmCalc.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtImporte.Text = frmCalc.result
            txtTC.txtDecimales.Text = frmCalc.txtTipoCambio.Text
        Else
            txtImporte.Text = 0
        End If
    End Sub

    Private Sub btnCI_CargoPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCI_CargoPlan.Click
        Dim frmCP As New frmBuscarCargoPlan
        frmCP.result = txtCI.Text
        If _oServicio.NGUITR <> 0 Then

        Else
            _oServicio.NGUITR = _oServReemb.NGUITR
            _oServicio.CTRMNC = _oServReemb.CTRMNC
        End If
        frmCP.oServicio = _oServicio
        If frmCP.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCI.Text = frmCP.result
            txtCI.ReadOnly = True
        Else
            txtCI.Text = ""
            txtCI.ReadOnly = False
        End If
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        If Comun.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtNroDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Comun.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
    Private Codigo As String = ""

    '<[AHM]>
    'Private Sub btnCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CargarAllCC()
    'End Sub
    '<[AHM]>

    '<[AHM]>
    'Private Sub txtCentroCosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCentroCosto.KeyDown
    '    If e.KeyCode = Keys.F4 Then
    '        CargarAllCC()
    '    Else
    '        If e.KeyCode = Keys.Enter Then
    '            CargaCentroCosto()
    '        End If
    '    End If
    'End Sub
    'Private Sub txtCentroCosto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCentroCosto.Validating
    '    CargaCentroCosto()
    'End Sub
    '<[AHM]>
    Private oServicioBL As New clsServicio_BL
    Private oDtCCosto As New DataTable

    Private Sub CargarAllCC()
        Dim frmCCosto As New frmCentroCosto
        Dim dt As New DataTable
        dt = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
        frmCCosto.oDtCentroCosto = dt
        If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCentroCosto.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
            _oServicio.CCNTCS = frmCCosto.nCodigo
            _oServicio.TSRVC = frmCCosto.sDescripcion
            Codigo = _oServicio.CCNTCS

        End If
    End Sub

    Private Sub CargaCentroCosto()
        Dim frmCCosto As New frmCentroCosto
        Dim blEncontrado As Boolean = False
        Dim nCount As Integer = 0
        Dim sDes As String = txtCentroCosto.Text


        If IsNumeric(txtCentroCosto.Text.Trim) Then
            Codigo = txtCentroCosto.Text.Trim
        Else
            Dim nCod As String = txtCentroCosto.Text.Split("-")(0)
            If Not nCod Is Nothing Then
                If Codigo = nCod.Trim Then
                    Exit Sub
                End If
            End If
        End If


        _oServicio.CCNTCS = 0
        Dim oDtCCostoDes As New DataTable
        oDtCCosto = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
        If txtCentroCosto.Text.Trim.Length > 0 Then
            If IsNumeric(txtCentroCosto.Text) Then
                For Each dr As DataRow In oDtCCosto.Select("CCNTCS=" & txtCentroCosto.Text.Trim)
                    txtCentroCosto.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                    blEncontrado = True
                    _oServicio.CCNTCS = dr("CCNTCS")
                    _oServicio.TSRVC = dr("CCNBNS")
                    Exit For
                Next
            Else
                oDtCCosto.DefaultView.RowFilter = "    CCNBNS LIKE '%" & txtCentroCosto.Text.Trim & "%'"
                oDtCCostoDes = oDtCCosto.DefaultView.ToTable

                For Each dr As DataRow In oDtCCostoDes.Rows
                    txtCentroCosto.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                    _oServicio.CCNTCS = dr("CCNTCS")
                    _oServicio.TSRVC = dr("CCNBNS")
                    blEncontrado = True
                    nCount += 1
                    If nCount > 1 Then
                        blEncontrado = False
                        txtCentroCosto.Text = sDes
                        '_oServicio.CCNTCS = 0
                        _oServicio.TSRVC = ""
                        Exit For
                    End If

                Next

            End If
            If _oServicio.CCNTCS = "0" Then txtCentroCosto.Text = ""

            If oDtCCosto.Rows.Count > 1 And oDtCCostoDes.Rows.Count > 1 Then

                If blEncontrado = False And Not (nCount = 0 Or nCount = 1) Then
                    If oDtCCostoDes.Rows.Count > 1 Then
                        oDtCCosto = oDtCCosto.DefaultView.ToTable

                    End If
                    frmCCosto.oDtCentroCosto = oDtCCosto
                    frmCCosto.txtDescripcion.Text = "* " & txtCentroCosto.Text.Trim & " *"
                    If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                        txtCentroCosto.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
                        _oServicio.CCNTCS = frmCCosto.nCodigo
                        _oServicio.TSRVC = frmCCosto.sDescripcion
                        Codigo = _oServicio.CCNTCS

                    End If
                Else
                    If blEncontrado = False And nCount = 0 And oDtCCosto.Rows.Count > 1 Then
                        If oDtCCostoDes.Rows.Count > 1 Then
                            oDtCCosto = oDtCCosto.DefaultView.ToTable
                        End If
                        frmCCosto.oDtCentroCosto = oDtCCosto
                        If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                            txtCentroCosto.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
                            _oServicio.CCNTCS = frmCCosto.nCodigo
                            _oServicio.TSRVC = frmCCosto.sDescripcion
                            Codigo = _oServicio.CCNTCS

                        End If
                    End If
                End If

            End If
            If _oServicio.CCNTCS = "0" Then txtCentroCosto.Text = ""
        Else
            frmCCosto.oDtCentroCosto = oDtCCosto
            If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCentroCosto.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
                _oServicio.CCNTCS = frmCCosto.nCodigo
                _oServicio.TSRVC = frmCCosto.sDescripcion

            End If
        End If


    End Sub

    '<[AHM]>
    Private Sub CargarCentroBeneficio()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Beneficio"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCNBNS"
        oColumnas.DataPropertyName = "PSCCNBNS"
        oColumnas.HeaderText = "Ce.Be SAP"
        oListColum.Add(3, oColumnas)

        Dim olCentroCosto As New List(Of CentroCosto_BE)

        Dim TipoServicio As ClaseGeneral_BE = CType(txtTipoServicio.Resultado, ClaseGeneral_BE)
        Dim TipoActivo As ClaseGeneral_BE = CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE)
        Dim UnidadProductiva As ClaseGeneral_BE = CType(txtUnidadProductiva.Resultado, ClaseGeneral_BE)

        Dim codTipoServicioSAP As String = ""
        Dim codUnidadProdcutivaSAP As String = ""


        Dim codCompania = String.Empty
        Dim codRegionVentaSAP As String = String.Empty
        Dim codMacroServicioSAP As String = String.Empty

        Dim codTipoActivoSAP As String = String.Empty
        Dim codSedeSAP As String = String.Empty
        Dim tipoCentroSAP As String = String.Empty


        If PerteneceSalmon() Then
            'If (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then

            If (TipoServicio Is Nothing) Then Exit Sub
            If (UnidadProductiva Is Nothing) Then Exit Sub

            codTipoServicioSAP = TipoServicio.CDTSSP
            codUnidadProdcutivaSAP = UnidadProductiva.CDUPSP

            codCompania = _oServicio.CCMPN  'tarifa.CCMPN
            codRegionVentaSAP = Me.pNegocio 'CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CRGVTA")    'oContrato.CRGVTA
            codMacroServicioSAP = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSRSP")  'macroServicio.CDSRSP

            codTipoActivoSAP = TipoActivo.PRCODI
            codSedeSAP = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSPSP")   'UcPLanta_Cmb011.CodSedeSAP
            tipoCentroSAP = "0"

        End If
        'olCentroCosto = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        olCentroCosto = oCentroCosto.Lista_CentroBeneficio_Tokio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        'Lista_CentroBeneficio_Tokio

        If olCentroCosto.Count > 0 Then
            txtCentroCosto.DataSource = olCentroCosto
        Else
            txtCentroCosto.DataSource = Nothing
        End If

        txtCentroCosto.ListColumnas = oListColum
        txtCentroCosto.Cargas()
        txtCentroCosto.Limpiar()
        txtCentroCosto.ValueMember = "PNCCNTCS"
        txtCentroCosto.DispleyMember = "PSTCNTCS"

        'ESTABLECEMOS EL VALOR DE SERVICIO
        If (_oServicio.TIPO <> Comun.ESTADO_Modificado) Then
            If (olCentroCosto.Count > 0) Then
                txtCentroCosto.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
            End If
        End If
    End Sub
    '</[AHM]>

    'JM
    'Private Sub cargarCentroCostoOrigen()

    '    Dim oListColum As New Hashtable
    '    Dim oColumnas As New DataGridViewTextBoxColumn
    '    oColumnas.Name = "CCNTCS"
    '    oColumnas.DataPropertyName = "PNCCNTCS"
    '    oColumnas.HeaderText = "Código"
    '    oListColum.Add(1, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "TCNTCS"
    '    oColumnas.DataPropertyName = "PSTCNTCS"
    '    oColumnas.HeaderText = "Descripción"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    oListColum.Add(2, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "CCNCOS"
    '    oColumnas.DataPropertyName = "PSCCNCOS"
    '    oColumnas.HeaderText = "Ce.Co. SAP"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    oListColum.Add(3, oColumnas)


    '    Dim olCentroCostoOrigen As New List(Of CentroCosto_BE)
    '    olCentroCostoOrigen = oCentroCosto.Listar_CentroCosto_Origen_Tarifa(_oServicio.CCMPN)

    '    uCentroCostoOrig.DataSource = olCentroCostoOrigen
    '    uCentroCostoOrig.ListColumnas = oListColum
    '    uCentroCostoOrig.Cargas()
    '    uCentroCostoOrig.ValueMember = "PNCCNTCS"
    '    uCentroCostoOrig.DispleyMember = "PSTCNTCS"

    'End Sub

    Private Sub cargarCentroCostoDestino(ByVal ccosto As String)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNCOS"
        oColumnas.DataPropertyName = "PSCCNCOS"
        oColumnas.HeaderText = "Ce.Co. SAP"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)

        Dim olCentroCostoDest As New List(Of CentroCosto_BE)
        olCentroCostoDest = oCentroCosto.Listar_CentroCosto_Destino_Tarifa(_oServicio.CCMPN, Convert.ToDouble(ccosto))
        uCentroCostoDest.DataSource = olCentroCostoDest
        uCentroCostoDest.ListColumnas = oListColum
        uCentroCostoDest.Cargas()
        uCentroCostoDest.ValueMember = "PNCCNTCS"
        uCentroCostoDest.DispleyMember = "PSTCNTCS"

    End Sub
    'Jm-------------------------------------------------


    Private Function ValidaDocuentoBD() As Boolean
        Dim oServicioBL As New clsServicio_BL
        Dim oReembolso As New ServicioReembolso_BE

        oReembolso.CCLNT = oServicio.CCLNT
        oReembolso.NOPRCN = oServicio.NOPRCN

        oReembolso.NRUCPR = Val(txtRUC.Text.Trim)
        oReembolso.TPODOC = cmbTipoDocumento.SelectedValue.ToString
        oReembolso.NUMDOC = Val(txtNroDocumento.Text.Trim)
        oReembolso.NCRRDC = oServicio.NCRROP

        oReembolso.FLGTIPO = oServicio.TIPO
        oReembolso.PSERROR = oServicioBL.fstrValidaDocumentoReembolosSA(oReembolso)
        If Not oReembolso.PSERROR.Equals("") Then
            MsgBox(oReembolso.PSERROR, MessageBoxIcon.Exclamation, "Validación")
            Return False
        End If

        Return True
    End Function

    Private Sub txtRUC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRUC.Validating
        Dim oSe As New clsServicio_BL
        UcProveedor.ActualizarBusqueda(oSe.ObtieneCodigoProveedor(txtRUC.Text))
    End Sub

    '<[AHM]>
    Private Sub CargarTipoServicioSAP(ByVal PSCDSRSP As String)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CDTSSP"
        oColumnas.DataPropertyName = "CDTSSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDTSSP"
        oColumnas.DataPropertyName = "TDTSSP"
        oColumnas.HeaderText = "Tipo Servicio "
        oListColum.Add(2, oColumnas)

        Dim claseGeneralList As List(Of ClaseGeneral_BE)


        If Not List_TipoServicioSAP.Contains(PSCDSRSP) Then
            claseGeneralList = oClaseGeneral.Listar_Tipo_Servicio_SAP(PSCDSRSP)
            List_TipoServicioSAP(PSCDSRSP) = claseGeneralList
        Else
            claseGeneralList = List_TipoServicioSAP(PSCDSRSP)
        End If


        txtTipoServicio.DataSource = claseGeneralList
        txtTipoServicio.ListColumnas = oListColum
        txtTipoServicio.Cargas()
        txtTipoServicio.ValueMember = "CDTSSP"
        txtTipoServicio.DispleyMember = "TDTSSP"

    End Sub

    Private Sub CargarTipoActivoSAP()
        Dim tipoActivoList As New List(Of ClaseGeneral_BE)
        tipoActivoList = oClaseGeneral.Listar_Tipo_Activo_SAP()

        cboTipoActivo.DataSource = tipoActivoList
        cboTipoActivo.DisplayMember = "PRDESC"
        cboTipoActivo.ValueMember = "PRCODI"
    End Sub

    Private Sub CargarUnidadProductivaSAP(ByVal PSCDSRSP As String)

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CDUPSP"
        oColumnas.DataPropertyName = "CDUPSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDUPSP"
        oColumnas.DataPropertyName = "TDUPSP"
        oColumnas.HeaderText = "Unidad Productiva "
        oListColum.Add(2, oColumnas)

        Dim claseGeneralList As List(Of ClaseGeneral_BE)
        If Not List_UnidadProductivaSAP.ContainsKey(PSCDSRSP) Then
            claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP(PSCDSRSP)
            List_UnidadProductivaSAP(PSCDSRSP) = claseGeneralList
        Else
            claseGeneralList = List_UnidadProductivaSAP(PSCDSRSP)
        End If


        txtUnidadProductiva.DataSource = claseGeneralList
        txtUnidadProductiva.ListColumnas = oListColum
        txtUnidadProductiva.Cargas()
        txtUnidadProductiva.ValueMember = "CDUPSP"
        txtUnidadProductiva.DispleyMember = "TDUPSP"

    End Sub

    Private Sub txtTipoServicio_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicio.CambioDeTexto
        Try
            'If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
            '    Exit Sub
            'End If

            If Not PerteneceSalmon() Then
                Exit Sub
            End If

            txtCentroCosto.Limpiar()
            txtCentroCosto.DataSource = Nothing

            If (txtTipoServicio.Resultado Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.CDTSSP = CType(txtTipoServicio.Resultado, ClaseGeneral_BE).CDTSSP
            End If

            Me.CargarCentroBeneficio()
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Function PerteneceSalmon() As Boolean
        'ListSalmon
        Dim result As Boolean = False
        If Not ListSalmon.Contains(_oServicio.CCMPN) Then
            Dim es_salmon As Boolean = False
            es_salmon = (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN)
            ListSalmon(_oServicio.CCMPN) = es_salmon
            result = es_salmon
        Else
            result = ListSalmon(_oServicio.CCMPN)
        End If
        Return result
    End Function

    Private Sub txtUnidadProductiva_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductiva.CambioDeTexto
        Try
            'If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
            If Not PerteneceSalmon() Then
                Exit Sub
            End If
            txtCentroCosto.Limpiar()
            txtCentroCosto.DataSource = Nothing

            If (txtUnidadProductiva.Resultado Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.CDUPSP = CType(txtUnidadProductiva.Resultado, ClaseGeneral_BE).CDUPSP
            End If

            Me.CargarCentroBeneficio()
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub cboTipoActivo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoActivo.SelectedValueChanged
        Try
            'If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
            If Not PerteneceSalmon() Then
                Exit Sub
            End If
            '
            txtCentroCosto.Limpiar()
            txtCentroCosto.DataSource = Nothing

            If (CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE) Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.PRCODI = CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE).PRCODI
            End If

            Me.CargarCentroBeneficio()
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtCentroCosto_CambioDeTexto(ByVal objData As System.Object) Handles txtCentroCosto.CambioDeTexto
        Try
            uCentroCostoDest.DataSource = Nothing
            uCentroCostoDest.Limpiar()
            If (txtCentroCosto.Resultado Is Nothing) Then
                Exit Sub
            Else
                cargarCentroCostoDestino(CType(txtCentroCosto.Resultado, CentroCosto_BE).PNCCNTCS) 'JM
            End If

            _oServicio.CCNTCS = CType(txtCentroCosto.Resultado, CentroCosto_BE).PNCCNTCS
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtCentroCosto_ClickOnArrow(ByVal objData As System.Object) Handles txtCentroCosto.ClickOnArrow
        Try
            'If Not (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania) Then
            If Not PerteneceSalmon() Then
                Exit Sub
            End If
            '

            If (txtCentroCosto.DataSource Is Nothing) Then
                MessageBox.Show("Parámetros insuficiente para listar el centro de beneficio, debe de seleccionar el Tipo de servicio, Unidad Productiva.")
            End If

        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub
    '</[AHM]>


    'JM
    Private Sub MostrarControlesClienteFacturar(ByVal CCMPN As String, ByVal pCodigoCliente As Integer)


        Dim objNcliente As New clsCliente_BL
        Dim ListaCliente As New List(Of Cliente_BE)
        ListaCliente = objNcliente.Validar_Cliente_Interno_v2(CCMPN, pCodigoCliente)
        If ListaCliente.Count = 0 Then
            ClienteInterno = False
            lblTarifaInterna.Visible = False
            txtTarifaInterna.Visible = False
            lblCentroCostoOrig.Visible = False
            uCentroCostoOrig.Visible = False
            lblCentroCostroDes.Visible = False
            uCentroCostoDest.Visible = False

            '******************* LOCALIZACION  DE LOS CONTROLES ************

            lbltarifa.Location() = New Point(86, 95)
            txtTarifaAplicar.Location() = New Point(143, 93)
            txtTarifaAplicar.Width = 180
            lblMoneda.Location() = New Point(356, 68)
            txtMoneda.Location() = New Point(419, 66)
            txtMoneda.Width = 142

            KryptonLabel11.Location() = New Point(379, 146)
            txtReferencia.Location() = New Point(419, 149)

        End If
    End Sub

End Class

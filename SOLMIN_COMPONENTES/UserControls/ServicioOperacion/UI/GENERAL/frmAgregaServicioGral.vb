
Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports SOLMIN_CTZ.Entidades.mantenimientos
'Imports SOLMIN_CTZ.NEGOCIO
'Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class frmAgregaServicioGral
#Region "Propiedades"
    ''' <summary>
    ''' Variables
    ''' </summary>
    ''' <remarks></remarks>
    Private bolBuscar As Boolean = False
    Private _oServicio As Servicio_BE
    Private oDtAlmacenes As DataTable
    Private oDtZonas As DataTable
    Private dgBULTO As New DataTable
    Private estatico As New Estaticos
    Public CodigoCliente As Decimal = 0
    Public CodigoPlanta As Decimal = 0
    Public Tipofrm As Integer = 0 ' si es igual a 0 va a aser de tipo servicio
    Public oDtListaPorServicio As New DataTable
    Public bolLoteDiferente As Boolean = False
    Public mListaBultoServicio As List(Of Servicio_BE)

    Public mListaServicioDetalleEmbarque As New List(Of Servicio_BE)

    Public nCorr As Integer = 0

    Public oDtMercaderia As New DataTable
    Public oDtEmbarques As New DataTable
    Public oDtValidaDetraccion As New DataTable
    Private bolLoteBulto As Boolean = True
    Public strLote As String = String.Empty

    '<[AHM]>
    Private oClaseGeneral As New clsClaseGeneral_BL
    Private oCentroCosto As New clsCentroCosto_BL

    Private ClienteInterno As Boolean = True



    Private _pCodigoCompania As String = ""
    Private ListSalmon As New Hashtable
    Private List_TipoServicioSAP As New Hashtable
    Private List_UnidadProductivaSAP As New Hashtable
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
    Public ReadOnly Property valBULTO() As DataTable
        Get
            Return dgBULTO
        End Get
    End Property

    Public por_det_primer_reg As Decimal = 0
    Public cant_reg_adic As Decimal = 0

 

#End Region

    Private Sub frmAgregaServicioGral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'cargarCentroCostoOrigen()
            dtgEmbarque.AutoGenerateColumns = False
            CargarTipoActivoSAP()
            cargarRubro()
            cargarServicio()
            cmbServicio_SelectionChangeCommitted(cmbServicio, Nothing)
            CargarLotes()



            If _oServicio.TIPO = Comun.ESTADO_Modificado Then
                dteFechaServicio.Text = Comun.FormatoFecha(_oServicio.FATNSR)
                txtCantidad.Text = _oServicio.QATNAN
                txtCantidadReal.Text = _oServicio.QATNRL

                txtObservacion.Text = _oServicio.TSRVC.Trim
                Me.txtReferencia.Text = _oServicio.TRFSRC
                txtCI.Text = _oServicio.TCTCST.Trim
                txtOrdenCompra.Text = _oServicio.NORCML.Trim
                bolBuscar = False
                cmbRubro.SelectedValue = _oServicio.NRRUBR
                cmbRubro.Enabled = False
                '******adicionando esto
                bolBuscar = True
                '****************
                cmbServicio.SelectedValue = _oServicio.NRTFSV
                '---------*************
                bolBuscar = False
                '************************
                cmbServicio.Enabled = False
                cmbLote.SelectedValue = _oServicio.TLUGEN.Trim
                bolBuscar = True
                '<[AHM]>
                txtTipoServicio.Valor = _oServicio.CDTSSP
                txtUnidadProductiva.Valor = _oServicio.CDUPSP
                cboTipoActivo.SelectedValue = _oServicio.PRCODI
                txtCentroBeneficio.Valor = _oServicio.CCNTCS
                '</[AHM]>
                'JM
                uCentroCostoOrig.Valor = _oServicio.CENCO2
                uCentroCostoDest.Valor = _oServicio.CENCOS

                Select Case _oServicio.CDVSN
                    Case "R"
                        Select Case _oServicio.STPODP
                            Case Comun.eTipoAlmacen.AlmTransito
                                If Tipofrm = 0 Then
                                    If nCorr = 0 Then
                                        CargarBultos2()
                                    Else
                                        CargarBultos()
                                    End If
                                End If
                            Case Comun.eTipoAlmacen.DepSimple
                                If Tipofrm = 0 Then
                                    If nCorr = 0 Then
                                        dtgMercaderia.AutoGenerateColumns = False
                                        dtgMercaderia.DataSource = oDtListaPorServicio
                                        lblItems.Text = oDtListaPorServicio.Rows.Count.ToString
                                    Else
                                        CargaMercaderia()
                                    End If
                                End If
                        End Select
                    Case "S"

                        dtgEmbarque.DataSource = oDtEmbarques
                        lblItems.Text = dtgEmbarque.Rows.Count.ToString

                End Select
                If IsNumeric(txtCentroBeneficio.Text) Then
                    oDtCCosto = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
                    For Each dr As DataRow In oDtCCosto.Select("CCNTCS =" & txtCentroBeneficio.Text)
                        txtCentroBeneficio.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                    Next
                End If
                'Else
                '    txtCantidad.Text = 0
                '    txtCantidadReal.Text = 0
                '<[AHM]>
                txtTipoServicio.Enabled = False
                txtUnidadProductiva.Enabled = False
                cboTipoActivo.Enabled = False
                txtCentroBeneficio.Enabled = False
                '</[AHM]>'

            End If

            '---ADICIONADO TOKIO-----------------
            'txtTipoServicio.Enabled = False
            'txtUnidadProductiva.Enabled = False
            'cboTipoActivo.Enabled = False
            'If PerteneceSalmon() Then
            '    txtCentroBeneficio.Enabled = False
            'Else
            '    txtCentroBeneficio.Enabled = True  ' PARA SELVA
            'End If

            '--------------------------------------------


            If Tipofrm = 1 Then
                KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
                KryptonSplitContainer1.Panel2MinSize = 25
                KryptonSplitContainer1.Panel1MinSize = KryptonSplitContainer1.Height
                'Me.Size = New Size(800, 350)
                Me.Size = New Size(975, 350)
                Me.StartPosition = FormStartPosition.CenterScreen
            End If

            'JM
            MostrarControlesClienteFacturar(_oServicio.CCMPN, _oServicio.CCLNFC)


            Select Case _oServicio.CDVSN
                Case "R"
                    Select Case _oServicio.STPODP
                        Case Comun.eTipoAlmacen.AlmTransito
                            Me.dtgMercaderia.Visible = False
                            Me.dtgBultos.Visible = True
                            dtgBultos.Dock = DockStyle.Fill
                            Me.dtgBultos.AutoGenerateColumns = False
                            cmbTerminoBusquedaDS.Visible = False
                            Me.cmbTerminoBusquedaSAT.Visible = True
                            Me.cmbTerminoBusquedaSIL.Visible = False
                            dtgEmbarque.Visible = False
                        Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple
                            Me.dtgBultos.Visible = False
                            Me.dtgMercaderia.Visible = True
                            dtgMercaderia.Dock = DockStyle.Fill
                            dtgMercaderia.AutoGenerateColumns = False
                            Me.dtgBultos.AutoGenerateColumns = True
                            cmbTerminoBusquedaDS.Visible = True
                            Me.cmbTerminoBusquedaSAT.Visible = False
                            Me.cmbTerminoBusquedaSIL.Visible = False
                            dtgEmbarque.Visible = False

                    End Select
                Case "S"
                    KryptonHeaderGroup3.ValuesSecondary.Heading = "Embarque"
                    Me.dtgMercaderia.Visible = False
                    Me.dtgEmbarque.Visible = True
                    Me.dtgBultos.Visible = False
                    dtgEmbarque.Dock = DockStyle.Fill
                    Me.dtgEmbarque.AutoGenerateColumns = False
                    cmbTerminoBusquedaDS.Visible = False
                    Me.cmbTerminoBusquedaSIL.Visible = True
                    Me.cmbTerminoBusquedaSAT.Visible = False

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub




    ''' <summary>
    ''' Carga Rubro
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarRubro()
        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        bolBuscar = False
        oDt = oServicioBL.fdtListaRubroXCompaniaDivision(_oServicio)
        oDt.DefaultView.RowFilter = "NRRUBR <> 7" ' NO ENTRAN LOS REEMBOLSOS
        oDt = oDt.DefaultView.ToTable
        cmbRubro.DataSource = oDt
        cmbRubro.ValueMember = "NRRUBR"
        bolBuscar = True
        cmbRubro.DisplayMember = "NOMRUB"
    End Sub
    'Private Sub cmbRubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRubro.SelectedIndexChanged
    '    If bolBuscar Then
    '        cargarServicio()
    '        cargarDatosServicio()
    '    End If
    'End Sub
    ''' <summary>
    ''' Carga informacion del servicio
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarServicio()
        Dim oServicioBL As New clsServicio_BL
        Dim oDtServicio As New DataTable
        bolBuscar = False
        If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
            _oServicio.NRRUBR = cmbRubro.SelectedValue
        End If
        oDtServicio = oServicioBL.Cargar_Servicios_Tarifa_Cliente(_oServicio)
        cmbServicio.DataSource = oDtServicio
        cmbServicio.ValueMember = "NRTFSV"
        bolBuscar = True
        cmbServicio.DisplayMember = "DESTAR"

        'cmbServicio_SelectionChangeCommitted(cmbServicio, Nothing)
        '<[AHM]>
        'If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
        'If Me.cmbServicio.SelectedItem IsNot Nothing Then _oServicio.CCNTCS = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
        'End If
        '</[AHM]>


        'cmbServicio.SelectedIndex = 0
    End Sub
    'Private Sub cmbServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServicio.SelectedIndexChanged
    '    If bolBuscar Then
    '        cargarDatosServicio()
    '    End If
    'End Sub
    ''' <summary>
    ''' Cargar Cargar Lotes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarLotes()
        Dim oServicioOpeNeg As New clsServicio_BL
        Me.cmbLote.DataSource = oServicioOpeNeg.ListarLotesMantenimiento(_oServicio.CCLNT)
        Me.cmbLote.ValueMember = "TLTECL"
        Me.cmbLote.DisplayMember = "TLTECL"
        If _oServicio.TLUGEN <> "" Then
            cmbLote.SelectedValue = _oServicio.TLUGEN
        Else
            cmbLote.ComboBox.SelectedIndex = 0
        End If
    End Sub
    ''' <summary>
    ''' Datos del Servicio
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub cargarDatosServicio()
        'Try
        Dim odtTarifa As New DataTable
        Dim obrclsServicioSC_BL As New clsServicioSC_BL
        odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(cmbServicio.SelectedValue)

        txtTipoServicio.Limpiar()
        txtUnidadProductiva.Limpiar()

        If (odtTarifa.Rows.Count > 0) Then
            txtCentroBeneficio.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim
            txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA_DESC").ToString.Trim
            Codigo = odtTarifa.Rows(0)("CCNTCS").ToString.Trim
            txtValorServicio.Text = CDbl(odtTarifa.Rows(0)("IVLSRV").ToString.Trim)
            txtUnidadMedida.Text = odtTarifa.Rows(0)("CUNDMD").ToString.Trim
            txtMoneda.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim

            If odtTarifa.Rows(0)("STPTRA").ToString.Trim.Equals("F") Then
                txtCantidad.Text = 1
                txtCantidad.Enabled = False
            Else
                If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
                    txtCantidad.Text = 0
                End If
                txtCantidad.Enabled = True
            End If
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
            'If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
            '    CargarCentroBeneficio()
            'End If

            'If PerteneceSalmon() Then
            CargarCentroBeneficio()
            'End If

        Else
            txtValorServicio.Text = ""
            txtCentroBeneficio.Text = ""
            txtTarifaAplicar.Text = ""
            txtUnidadMedida.Text = ""
            txtMoneda.Text = ""
            txtCantidad.Text = 0


            txtTarifaInterna.Text = ""
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
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

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Comun.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Function valida() As Boolean

        '<[AHM]>
        'If (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
        If PerteneceSalmon() Then
            'PerteneceSalmon()
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
            If (txtCentroBeneficio.Resultado Is Nothing) Then
                MessageBox.Show("Ingrese Centro Beneficio Dest", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        If CDbl(Val(txtCantidad.Text)) = "0" Then
            MessageBox.Show("Ingrese Cantidad", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Select Case _oServicio.CDVSN
            Case "R"
                If _oServicio.STPODP = Comun.eTipoAlmacen.AlmTransito Then
                    If dtgBultos.RowCount = 0 And Tipofrm = 0 Then
                        MessageBox.Show("Ingrese bultos", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End If
                Else
                    If dtgMercaderia.RowCount = 0 And Tipofrm = 0 Then
                        MessageBox.Show("Ingrese Mercadería", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End If
                End If
            Case "S"
                If dtgEmbarque.RowCount = 0 And Tipofrm = 0 Then
                    MessageBox.Show("Debe ingresar al menos un Embarque", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
        End Select

        If Not ValidaDetraccion() Then
            Return False
        End If

        If strLote.Length > 0 And Not bolLoteDiferente Then
            If strLote <> cmbLote.SelectedValue.ToString.Trim Then
                If MessageBox.Show("El Lote que esta agregando es diferente al anterior, Desea continuar?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Return False
                Else
                    bolLoteDiferente = True
                End If

            End If
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
    Private Function ValidaDetraccion() As Boolean
        Dim strDetraccion As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("SRBAFD").ToString
        Dim strRegionVenta As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CRGVTA").ToString


        Dim porDetraccionActual As Decimal = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("IPRCDT")


        For Each dr As DataRow In oDtValidaDetraccion.Rows
            If dr("SRBAFD") <> strDetraccion Then
                If strDetraccion = "N" Then
                    MessageBox.Show("El servicio que se esta registrando a esta operación no debe tener  detracción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("El servicio registrando a esta operación debe detracción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                Return False
            End If
            'region venta
            If dr("CRGVTA") <> strRegionVenta Then
                MessageBox.Show("La region venta que esta agregando debe de ser iguales", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

        Next

 


        If cant_reg_adic > 0 Then
            If por_det_primer_reg <> porDetraccionActual Then
                MessageBox.Show("Los % detracción deben ser iguales ( %detracción inicial:" & por_det_primer_reg & ")", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

      

        Return True

    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            ' Cargamos el objeto con la informacion del servicio seleccionado
            If valida() = False Then Exit Sub
            _oServicio.NRTFSV = cmbServicio.SelectedValue
            _oServicio.TARIFA_DESC = cmbServicio.Text
            _oServicio.QATNAN = IIf(IsNumeric(txtCantidad.Text), txtCantidad.Text, 0)
            _oServicio.QATNRL = IIf(IsNumeric(txtCantidadReal.Text), txtCantidadReal.Text, 0)
            _oServicio.VALCTE = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("VALCTE")
            _oServicio.CUNDMD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CUNDMD")
            '_oServicio.CCNTCS = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
            _oServicio.CCNTCS = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
            _oServicio.IVLSRV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("IVLSRV")
            _oServicio.TSGNMN = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("TSGNMN")
            _oServicio.SRBAFD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("SRBAFD") 'DETRACCION
            _oServicio.CRGVTA = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CRGVTA") 'region venta

            _oServicio.IPRCDT = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("IPRCDT")



            _oServicio.FATNSR = Format(dteFechaServicio.Value, "yyyyMMdd")
            _oServicio.TCTCST = txtCI.Text
            _oServicio.NORCML = txtOrdenCompra.Text
            _oServicio.TRFSRC = Me.txtReferencia.Text

            _oServicio.CCNBNS = CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PSCCNBNS
            If ClienteInterno Then
                _oServicio.CENCOS = CType(uCentroCostoDest.Resultado, CentroCosto_BE).PNCCNTCS
                _oServicio.CENCO2 = CType(uCentroCostoOrig.Resultado, CentroCosto_BE).PNCCNTCS
                _oServicio.ISRVTI = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("ISRVTI")
            Else
                _oServicio.CENCOS = 0
                _oServicio.CENCO2 = 0
                _oServicio.ISRVTI = 0
            End If

            If Not cmbLote.SelectedIndex = 0 Then
                _oServicio.TLUGEN = cmbLote.Text.Trim
            End If
            _oServicio.TSRVC = txtObservacion.Text.Trim

            Dim bStatusSalir As Boolean = False
            Select Case _oServicio.CDVSN
                Case "R"
                    If _oServicio.STPODP = Comun.eTipoAlmacen.AlmTransito Then
                        mListaBultoServicio = New List(Of Servicio_BE)
                        Dim obeServicio As New Servicio_BE
                        Dim nCount As Integer = 0
                        For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos
                            obeServicio = New Servicio_BE
                            obeServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                            obeServicio.DESCWB = dtgBultos.Rows(i).Cells("DESCWB").Value
                            obeServicio.TUBRFR = dtgBultos.Rows(i).Cells("TUBRFR").Value
                            obeServicio.QREFFW = dtgBultos.Rows(i).Cells("QREFFW").Value
                            obeServicio.TIPBTO = dtgBultos.Rows(i).Cells("TIPBTO").Value
                            obeServicio.QPSOBL = dtgBultos.Rows(i).Cells("QPSOBL").Value
                            obeServicio.TUNPSO = dtgBultos.Rows(i).Cells("TUNPSO").Value
                            obeServicio.QVLBTO = dtgBultos.Rows(i).Cells("QVLBTO").Value
                            obeServicio.TUNVOL = dtgBultos.Rows(i).Cells("TUNVOL").Value
                            obeServicio.QAROCP = dtgBultos.Rows(i).Cells("QAROCP").Value
                            obeServicio.SESTRG = dtgBultos.Rows(i).Cells("SESTRG").Value
                            obeServicio.CPRCN1 = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                            obeServicio.NSRCN1 = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                            obeServicio.CPLNDV = _oServicio.CPLNDV
                            obeServicio.CTPALM = dtgBultos.Rows(i).Cells("CTPALM").Value
                            obeServicio.CALMC = dtgBultos.Rows(i).Cells("CALMC").Value
                            obeServicio.CZNALM = dtgBultos.Rows(i).Cells("CZNALM").Value
                            obeServicio.NSEQIN = dtgBultos.Rows(i).Cells("NSEQIN").Value

                            obeServicio.NGRPRV = dtgBultos.Rows(i).Cells("NGRPRV").Value
                            obeServicio.NGUIRM = Val("" & dtgBultos.Rows(i).Cells("NGUIRM_2").Value & "")
                            obeServicio.NRGUSA = Val("" & dtgBultos.Rows(i).Cells("NRGUSA_2").Value & "")

                            If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
                                obeServicio.NCRROP = nCorr + 1
                            Else
                                obeServicio.NCRROP = IIf(dtgBultos.Rows(i).Cells("NCRROP3").Value Is Nothing, IIf(nCorr > 0, nCorr, nCorr + 1), dtgBultos.Rows(i).Cells("NCRROP3").Value)
                            End If

                            mListaBultoServicio.Add(obeServicio)
                            nCount += 1
                        Next

                    Else
                        If Tipofrm = 0 Then oDtMercaderia = CType(dtgMercaderia.DataSource, DataTable).Copy
                    End If
                Case "S"
                    oDtEmbarques = CType(dtgEmbarque.DataSource, DataTable)

            End Select
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If oServicio.CCLNT = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If (Me.cmbTerminoBusquedaSAT.Text <> "" OrElse cmbTerminoBusquedaDS.Text <> "" OrElse cmbTerminoBusquedaSIL.Text <> "") And txtCodigo.Text <> "" Then
                If _oServicio.CDVSN = "S" Then
                    BuscarSustentoSIL()
                ElseIf _oServicio.STPODP = "7" Then
                    BuscarBultos()
                Else
                    BuscarSolicituServicio()
                End If
            End If
        End If
    End Sub
    Private Sub BuscarBultos()
        Dim oSerAlmacen As New Servicio_BE
        With oSerAlmacen
            .CCLNT = _oServicio.CCLNT 'Me.CodigoCliente
            .NOPRCN = _oServicio.NOPRCN
            .CCMPN = _oServicio.CCMPN
            .CDVSN = _oServicio.CDVSN
            .CPLNDV = _oServicio.CPLNDV 'Me.CodigoPlanta
            Select Case Mid(cmbTerminoBusquedaSAT.Text, 1, 1)
                Case "B"
                    .CREFFW = txtCodigo.Text.ToUpper.Trim
                Case "P"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.PALETA"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROPLT = intTemp
                    End If
                Case "D"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROCTL = intTemp
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NRGUSA = intTemp
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.GUIA"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRM = intTemp
                    End If
                Case "V"
                    .NGRPRV = txtCodigo.Text.ToUpper
            End Select
            CargarBultos(oSerAlmacen)
        End With



    End Sub

    Private Sub BuscarSolicituServicio()
        Dim oServicioAlmacen As New Servicio_BE
        With oServicioAlmacen
            .CCLNT = _oServicio.CCLNT
            .NOPRCN = _oServicio.NOPRCN
            .CCMPN = _oServicio.CCMPN
            .CDVSN = _oServicio.CDVSN
            .CPLNDV = Me.CodigoPlanta
            Select Case Mid(cmbTerminoBusquedaDS.Text, 1, 1)
                Case "P"
                    .NGUICL = txtCodigo.Text.ToUpper
                Case "I"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.INGRESO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 1
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 2
                    End If
            End Select
        End With
        BuscarOS(oServicioAlmacen)
    End Sub

    Private Sub CargarBultos(ByVal oSerAlmacen As Servicio_BE)

        Dim bolLote As Boolean = False
        Dim strMensaje As String = String.Empty
        Dim oServicioBL As New clsServicio_BL
        Dim dtTemp As DataTable = oServicioBL.fdtListaBultoFacturarSA(oSerAlmacen)

        If Not oSerAlmacen.PSERROR.Trim.Equals("") Then
            MsgBox(oSerAlmacen.PSERROR, MsgBoxStyle.Information, "Información")
        End If

        For i As Integer = 0 To dtTemp.Rows.Count - 1
            bolLote = flValidaLote(dtTemp.Rows(i).Item("TLUGEN").ToString.Trim, strMensaje)
            If bolLote Then Exit For
        Next

        If Not bolLote And dtTemp.Rows.Count > 0 Then
            If MessageBox.Show(strMensaje, "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                bolLoteBulto = False
            End If
        End If


        Dim dtWayBill As DataTable
        Dim oDrVw As DataGridViewRow
        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos

        If dtTemp.Rows.Count > 0 Then
            Dim dwFila As DataRow
            dtWayBill = dtTemp.Clone

            For Each dwFila In dtTemp.Rows

                If _oServicio.SSTINV = "R" Then
                    If dwFila.Item("CBLTOR").ToString.Trim <> "" Then Continue For
                End If

                If Not fblnBuscarBulto(dwFila.Item("CREFFW").ToString.Trim, dwFila.Item("NSEQIN").ToString.Trim) Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgBultos)

                    dtgBultos.Rows.Insert(0, oDrVw)
                    oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    With Me.dtgBultos

                        .Rows(0).Cells("CREFFW").Value = dwFila.Item("CREFFW").ToString.Trim
                        .Rows(0).Cells("NCRRDC").Value = DBNull.Value
                        .Rows(0).Cells("DESCWB").Value = dwFila.Item("DESCWB").ToString.Trim
                        .Rows(0).Cells("TUBRFR").Value = dwFila.Item("TUBRFR").ToString.Trim
                        '.Rows(0).Cells("QREFFW").Value = dwFila.Item("QREFFW")
                        .Rows(0).Cells("TIPBTO").Value = dwFila.Item("TIPBTO").ToString.Trim
                        '.Rows(0).Cells("QPSOBL").Value = dwFila.Item("QPSOBL")
                        .Rows(0).Cells("TUNPSO").Value = dwFila.Item("TUNPSO").ToString.Trim
                        '.Rows(0).Cells("QVLBTO").Value = dwFila.Item("QVLBTO")

                        If oServicio.SSTINV = "R" Then
                            .Rows(0).Cells("QREFFW").Value = dwFila.Item("QREFBO") 'Cantidad de Bulto Origen
                            .Rows(0).Cells("QPSOBL").Value = dwFila.Item("QPSOBO") 'Peso Bultos Origen      
                            .Rows(0).Cells("QVLBTO").Value = dwFila.Item("QVOLBO") 'Volumen del Bulto Origen 
                            .Rows(0).Cells("QAROCP").Value = dwFila.Item("QAROBO") 'Cant.Area Origen   
                        Else
                            .Rows(0).Cells("QREFFW").Value = dwFila.Item("QREFFW") 'Cantidad recibida por el Freight Forward
                            .Rows(0).Cells("QPSOBL").Value = dwFila.Item("QPSOBL") 'Peso Bultos
                            .Rows(0).Cells("QVLBTO").Value = dwFila.Item("QVLBTO") 'Volumen del Bulto
                            .Rows(0).Cells("QAROCP").Value = dwFila.Item("QAROCP") 'Cant.Area Ocupada mt2 
                        End If

                        .Rows(0).Cells("TUNVOL").Value = dwFila.Item("TUNVOL").ToString.Trim
                        '.Rows(0).Cells("QAROCP").Value = dwFila.Item("QAROCP")
                        .Rows(0).Cells("SESTRG").Value = dwFila.Item("SESTRG").ToString.Trim
                        .Rows(0).Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        .Rows(0).Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        .Rows(0).Cells("CTPALM").Value = dwFila.Item("CTPALM").ToString.Trim
                        .Rows(0).Cells("CALMC").Value = dwFila.Item("CALMC").ToString.Trim
                        .Rows(0).Cells("CZNALM").Value = dwFila.Item("CZNALM").ToString.Trim
                        .Rows(0).Cells("NSEQIN").Value = CInt(dwFila.Item("NSEQIN").ToString.Trim)

                        .Rows(0).Cells("NGRPRV").Value = dwFila.Item("NGRPRV").ToString.Trim
                        .Rows(0).Cells("NGUIRM_2").Value = dwFila.Item("NGUIRM").ToString.Trim
                        .Rows(0).Cells("NRGUSA_2").Value = dwFila.Item("NRGUSA").ToString.Trim
                        .Rows(0).Cells("TLUGEN2").Value = dwFila.Item("TLUGEN").ToString.Trim



                        lblItems.Text = Val(lblItems.Text) + 1

                    End With
                    txtCodigo.Text = ""
                    txtCodigo.Focus()
                End If
            Next
        End If
    End Sub

    Private Function flValidaLote(ByVal strLote As String, ByRef strMensaje As String) As Boolean
        Dim intIndice As Integer = 0
        Dim bolBultos As Boolean = False

        If bolLoteBulto Then
            If Not cmbLote.SelectedIndex = 0 Then
                If cmbLote.SelectedValue = strLote Then
                    Return True
                Else
                    strMensaje = "El Lote del bulto que esta agregando debe ser igual al lote seleccionado, desea agregar?"
                    Return False
                End If
            Else
                bolBultos = True
            End If


            If bolBultos Then

                strMensaje = String.Empty
                For intIndice = 0 To dtgBultos.RowCount - 1
                    If strLote = ("" & dtgBultos.Rows(intIndice).Cells("TLUGEN").Value & "").ToString.Trim Then
                        Return True

                    End If
                Next
                strMensaje = "El Lote del bulto que esta agregando debe ser igual al anterior, desea agregar?"


                If dtgBultos.RowCount = 0 And bolBultos Then
                    Return True
                End If
            End If

        Else
            Return True
        End If


        Return False
    End Function
    Private Function fblnBuscarBulto(ByVal strCodigo As String, ByVal strSeq As String) As Boolean
        Dim intIndice As Integer
        For intIndice = 0 To dtgBultos.RowCount - 1
            If strCodigo.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim And strSeq = CType(dtgBultos.Rows(intIndice).Cells("NSEQIN").Value.ToString.Trim, Decimal) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub BuscarOS(ByVal oServicioAlmacen As Servicio_BE)


        Dim oServicioBL As New clsServicio_BL
        Dim dtTemp As DataTable = oServicioBL.fdtListaSolicitudDeServicioSDS(oServicioAlmacen)

        dtTemp.Columns.Add("NCRROP4", GetType(Integer))
        For i As Integer = 0 To dtTemp.Rows.Count - 1
            dtTemp.Rows(i).Item("NCRROP4") = IIf(_oServicio.TIPO = Comun.ESTADO_Modificado, nCorr, nCorr + 1)
        Next


        If Me.dtgMercaderia.DataSource Is Nothing And Not dtTemp Is Nothing Then
            dtTemp.Columns.Add("CPRCN1")
            dtTemp.Columns.Add("NSRCN1")
            dtTemp.Columns.Add("NCRRDC", GetType(String))


            Me.dtgMercaderia.DataSource = dtTemp
            lblItems.Text = dtTemp.Rows.Count.ToString
            txtCodigo.Text = ""
            txtCodigo.Focus()

        ElseIf (Not dtTemp Is Nothing) Then

            For Each oDr As DataRow In dtTemp.Rows

                If Not fblnBuscarSolicitudServicio(oDr) Then
                    Dim oDrMercaderia As DataRow
                    oDrMercaderia = Me.dtgMercaderia.DataSource.NewRow
                    For intColumna As Integer = 0 To dtTemp.Columns.Count - 1

                        oDrMercaderia.Item(intColumna) = oDr.Item(intColumna)
                        oDrMercaderia.Item("NCRROP4") = oDr("NCRROP4")
                        oDrMercaderia.Item("NCRRDC") = 0

                    Next
                    Me.dtgMercaderia.DataSource.Rows.Add(oDrMercaderia)

                    lblItems.Text = Val(lblItems.Text) + 1

                    dtgMercaderia.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    dtgMercaderia.CurrentRow.Cells("CPRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    dtgMercaderia.CurrentRow.Cells("NSRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                End If
            Next

            txtCodigo.Text = ""
            txtCodigo.Focus()
        End If
    End Sub

    Private Function fblnBuscarSolicitudServicio(ByVal oDr As DataRow) As Boolean
        For Each oDrMercaderia As DataRow In Me.dtgMercaderia.DataSource.Rows
            If oDrMercaderia.Item("NORDSR") = oDr.Item("NORDSR") And oDrMercaderia.Item("NSLCSR") = oDr.Item("NSLCSR") And oDrMercaderia.Item("NCRROP4") = oDr.Item("NCRROP4") Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub CargarBultos()

        Dim oDrVw As DataGridViewRow
        For Each dr As DataRow In oDtListaPorServicio.Select("NCRROP=" & nCorr.ToString & "")
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgBultos)
            Me.dtgBultos.Rows.Add(oDrVw)
            oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            With Me.dtgBultos
                Dim pos As Integer = dtgBultos.Rows.Count - 1
                .Rows(pos).Cells("CREFFW").Value = dr("CREFFW").ToString.Trim
                .Rows(pos).Cells("NCRRDC").Value = dr("NCRRDC").ToString.Trim 'DBNull.Value
                .Rows(pos).Cells("DESCWB").Value = dr("DESCWB").ToString.Trim
                .Rows(pos).Cells("TUBRFR").Value = dr("TUBRFR").ToString.Trim
                .Rows(pos).Cells("QREFFW").Value = dr("QREFFW")
                .Rows(pos).Cells("TIPBTO").Value = dr("TIPBTO").ToString.Trim
                .Rows(pos).Cells("QPSOBL").Value = dr("QPSOBL")
                .Rows(pos).Cells("TUNPSO").Value = dr("TUNPSO").ToString.Trim
                .Rows(pos).Cells("QVLBTO").Value = dr("QVLBTO")
                .Rows(pos).Cells("TUNVOL").Value = dr("TUNVOL").ToString.Trim
                .Rows(pos).Cells("QAROCP").Value = dr("QAROCP")
                .Rows(pos).Cells("SESTRG").Value = dr("SESTRG").ToString.Trim
                .Rows(pos).Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                .Rows(pos).Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                .Rows(pos).Cells("NSRCN1").Value = dr("NSRCN1")
                .Rows(pos).Cells("CPRCN1").Value = dr("CPRCN1")
                .Rows(pos).Cells("CTPALM").Value = dr("CTPALM").ToString.Trim
                .Rows(pos).Cells("CALMC").Value = dr("CALMC").ToString.Trim
                .Rows(pos).Cells("CZNALM").Value = dr("CZNALM").ToString.Trim
                .Rows(pos).Cells("NSEQIN").Value = CInt(dr("NSEQIN").ToString.Trim)
                .Rows(pos).Cells("NCRROP3").Value = CInt(dr("NCRROP").ToString.Trim)

                .Rows(pos).Cells("NGRPRV").Value = dr("NGRPRV").ToString.Trim
                .Rows(pos).Cells("NGUIRM_2").Value = dr("NGUIRM").ToString.Trim
                .Rows(pos).Cells("NRGUSA_2").Value = dr("NRGUSA").ToString.Trim



                lblItems.Text = Val(lblItems.Text) + 1

            End With
        Next
    End Sub

    Private Sub CargarBultos2()

        Dim oDrVw As DataGridViewRow
        For Each dr As DataRow In oDtListaPorServicio.Rows
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgBultos)
            Me.dtgBultos.Rows.Add(oDrVw)
            oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            With Me.dtgBultos
                Dim pos As Integer = dtgBultos.Rows.Count - 1
                .Rows(pos).Cells("CREFFW").Value = dr("CREFFW").ToString.Trim
                .Rows(pos).Cells("NCRRDC").Value = dr("NCRRDC").ToString.Trim 'DBNull.Value
                .Rows(pos).Cells("DESCWB").Value = dr("DESCWB").ToString.Trim
                .Rows(pos).Cells("TUBRFR").Value = dr("TUBRFR").ToString.Trim
                .Rows(pos).Cells("QREFFW").Value = dr("QREFFW")
                .Rows(pos).Cells("TIPBTO").Value = dr("TIPBTO").ToString.Trim
                .Rows(pos).Cells("QPSOBL").Value = dr("QPSOBL")
                .Rows(pos).Cells("TUNPSO").Value = dr("TUNPSO").ToString.Trim
                .Rows(pos).Cells("QVLBTO").Value = dr("QVLBTO")
                .Rows(pos).Cells("TUNVOL").Value = dr("TUNVOL").ToString.Trim
                .Rows(pos).Cells("QAROCP").Value = dr("QAROCP")
                .Rows(pos).Cells("SESTRG").Value = dr("SESTRG").ToString.Trim
                .Rows(pos).Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                .Rows(pos).Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                .Rows(pos).Cells("CTPALM").Value = dr("CTPALM").ToString.Trim
                .Rows(pos).Cells("CALMC").Value = dr("CALMC").ToString.Trim
                .Rows(pos).Cells("CZNALM").Value = dr("CZNALM").ToString.Trim
                .Rows(pos).Cells("NSEQIN").Value = CInt(dr("NSEQIN").ToString.Trim)
                .Rows(pos).Cells("NCRROP3").Value = CInt(dr("NCRROP").ToString.Trim)

                .Rows(pos).Cells("NGRPRV").Value = dr("NGRPRV").ToString.Trim
                .Rows(pos).Cells("NGUIRM_2").Value = dr("NGUIRM").ToString.Trim
                .Rows(pos).Cells("NRGUSA_2").Value = dr("NRGUSA").ToString.Trim


                lblItems.Text = Val(lblItems.Text) + 1

            End With
        Next
    End Sub

    Private Sub CargaMercaderia()

        Dim dtAux As New DataTable
        dtAux = oDtListaPorServicio.Clone
        For Each dr As DataRow In oDtListaPorServicio.Select("NCRROP4=" & nCorr & "")
            dtAux.ImportRow(dr)


            lblItems.Text = Val(lblItems.Text) + 1
        Next
        dtgMercaderia.AutoGenerateColumns = False
        dtgMercaderia.DataSource = dtAux
    End Sub


    Private oServicioBL As New clsServicio_BL
    Private oDtCCosto As New DataTable
    '<[AHM]>
    'Private Sub btnCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CargarAllCC()
    'End Sub
    '</[AHM]>
    Private Sub CargarAllCC()
        Dim frmCCosto As New frmCentroCosto
        Dim dt As New DataTable
        dt = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
        frmCCosto.oDtCentroCosto = dt
        If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
            _oServicio.CCNTCS = frmCCosto.nCodigo
            _oServicio.TSRVC = frmCCosto.sDescripcion
            Codigo = _oServicio.CCNTCS

        End If
    End Sub

    Private Sub CargaCentroCosto(ByVal nada As String)
        Dim frmCCosto As New frmCentroCosto
        Dim blEncontrado As Boolean = False
        Dim nCount As Integer = 0
        Dim sDes As String = txtCentroBeneficio.Text


        If IsNumeric(txtCentroBeneficio.Text.Trim) Then
            Codigo = txtCentroBeneficio.Text.Trim
        Else
            Dim nCod As String = txtCentroBeneficio.Text.Split("-")(0)
            If Not nCod Is Nothing Then
                If Codigo = nCod.Trim Then
                    Exit Sub
                End If
            End If
        End If


        _oServicio.CCNTCS = 0
        Dim oDtCCostoDes As New DataTable
        oDtCCosto = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
        If txtCentroBeneficio.Text.Trim.Length > 0 Then
            If IsNumeric(txtCentroBeneficio.Text) Then
                For Each dr As DataRow In oDtCCosto.Select("CCNTCS=" & txtCentroBeneficio.Text.Trim)
                    txtCentroBeneficio.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                    blEncontrado = True
                    _oServicio.CCNTCS = dr("CCNTCS")
                    _oServicio.TSRVC = dr("CCNBNS")
                    Exit For
                Next
            Else
                oDtCCosto.DefaultView.RowFilter = "    CCNBNS LIKE '%" & txtCentroBeneficio.Text.Trim & "%'"
                oDtCCostoDes = oDtCCosto.DefaultView.ToTable

                For Each dr As DataRow In oDtCCostoDes.Rows
                    txtCentroBeneficio.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                    _oServicio.CCNTCS = dr("CCNTCS")
                    _oServicio.TSRVC = dr("CCNBNS")
                    blEncontrado = True
                    nCount += 1
                    If nCount > 1 Then
                        blEncontrado = False
                        txtCentroBeneficio.Text = sDes
                        '_oServicio.CCNTCS = 0
                        _oServicio.TSRVC = ""
                        Exit For
                    End If

                Next

            End If
            If _oServicio.CCNTCS = "0" Then txtCentroBeneficio.Text = ""

            If oDtCCosto.Rows.Count > 1 And oDtCCostoDes.Rows.Count > 1 Then

                If blEncontrado = False And Not (nCount = 0 Or nCount = 1) Then
                    If oDtCCostoDes.Rows.Count > 1 Then
                        oDtCCosto = oDtCCosto.DefaultView.ToTable

                    End If
                    frmCCosto.oDtCentroCosto = oDtCCosto
                    frmCCosto.txtDescripcion.Text = "* " & txtCentroBeneficio.Text.Trim & " *"
                    If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                        txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
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
                            txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
                            _oServicio.CCNTCS = frmCCosto.nCodigo
                            _oServicio.TSRVC = frmCCosto.sDescripcion
                            Codigo = _oServicio.CCNTCS

                        End If
                    End If
                End If

            End If
            If _oServicio.CCNTCS = "0" Then txtCentroBeneficio.Text = ""
        Else
            frmCCosto.oDtCentroCosto = oDtCCosto
            If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
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

        Dim codTipoActivoSAP As String = String.Empty
        Dim codSedeSAP As String = String.Empty
        Dim tipoCentroSAP As String = String.Empty
        Dim codRegionVentaSAP As String = String.Empty
        Dim codMacroServicioSAP As String = String.Empty

        Dim codCompania = _oServicio.CCMPN  'tarifa.CCMPN

        'If (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
        If PerteneceSalmon() Then
            If (TipoServicio Is Nothing) Then Exit Sub
            If (UnidadProductiva Is Nothing) Then Exit Sub
            If (TipoActivo Is Nothing) Then Exit Sub

            codTipoServicioSAP = TipoServicio.CDTSSP
            codUnidadProdcutivaSAP = UnidadProductiva.CDUPSP

            codTipoActivoSAP = TipoActivo.PRCODI
            codSedeSAP = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSPSP")   'UcPLanta_Cmb011.CodSedeSAP
            tipoCentroSAP = "0"
            codRegionVentaSAP = Me.pNegocio
            codMacroServicioSAP = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSRSP")  'macroServicio.CDSRSP

        End If

        'olCentroCosto = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        olCentroCosto = oCentroCosto.Lista_CentroBeneficio_Tokio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        'Lista_CentroBeneficio_Tokio

        If olCentroCosto.Count > 0 Then
            txtCentroBeneficio.DataSource = olCentroCosto
        Else
            txtCentroBeneficio.DataSource = Nothing
        End If

        txtCentroBeneficio.ListColumnas = oListColum
        txtCentroBeneficio.Cargas()
        txtCentroBeneficio.Limpiar()
        txtCentroBeneficio.ValueMember = "PNCCNTCS"
        txtCentroBeneficio.DispleyMember = "PSTCNTCS"

        'ESTABLECEMOS EL VALOR DE SERVICIO
        If (_oServicio.TIPO <> Comun.ESTADO_Modificado) Then
            If (olCentroCosto.Count > 0) Then
                txtCentroBeneficio.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
            End If
        End If
    End Sub
    '</[AHM]>
    Private Codigo As String = ""



    Private Sub txtCentroCosto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'CargaCentroCosto("")
    End Sub



    Private Sub BtnEliminarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarTermino.Click
        EliminarDetalleOperacion()
    End Sub

    Private Sub EliminarDetalleOperacion()
        Select Case _oServicio.CDVSN
            Case "R"

                If _oServicio.STPODP = "7" Then
                    Dim oServicioBL As New clsServicio_BL

                    If Me.dtgBultos.RowCount <= 0 Then
                        MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    If Me.dtgBultos.RowCount = 1 And _oServicio.TIPO = Comun.ESTADO_Modificado Then
                        MsgBox("El servicio tiene que tener detalles, eliminar el servicio.", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If Val("" & Me.dtgBultos.CurrentRow.Cells("NCRRDC").Value & "") = 0 Then
                        dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                        lblItems.Text = dtgBultos.Rows.Count.ToString

                        If dtgBultos.Rows.Count = 0 Then bolLoteBulto = True
                        Exit Sub
                    End If
                    If MessageBox.Show("Está seguro de eliminar el bulto seleccionado?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Dim oServicioDel As New Servicio_BE
                        oServicioDel.NOPRCN = _oServicio.NOPRCN
                        oServicioDel.CCLNT = _oServicio.CCLNT
                        oServicioDel.NCRRDC = Me.dtgBultos.CurrentRow.Cells("NCRRDC").Value
                        oServicioDel.STPODP = _oServicio.STPODP
                        If oServicioBL.fintEliminarDetalleServiciosFacturacionSA(oServicioDel) = 0 Then
                            MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                        Else
                            dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                            lblItems.Text = dtgBultos.Rows.Count.ToString
                            If dtgBultos.Rows.Count = 0 Then bolLoteBulto = True
                        End If
                    End If

                Else
                    Dim oServicioBL As New clsServicio_BL

                    If Me.dtgMercaderia.RowCount <= 0 Then
                        MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Exclamation, "Validación")
                        Exit Sub
                    End If

                    If Me.dtgMercaderia.RowCount = 1 Then
                        MsgBox("El servicio tiene que tener detalles, eliminar el servicio.", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If Me.dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC").ToString.Trim.Equals("") Then
                        CType(dtgMercaderia.DataSource, DataTable).Rows.Remove(CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, DataRowView).Row)
                        lblItems.Text = dtgMercaderia.Rows.Count.ToString
                        Exit Sub
                    End If
                    If MessageBox.Show("Está seguro de eliminar el registro seleccionado ?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Dim oServicioDel As New Servicio_BE
                        oServicioDel.NOPRCN = _oServicio.NOPRCN
                        oServicioDel.CCLNT = _oServicio.CCLNT
                        oServicioDel.NCRRDC = dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC")
                        oServicioDel.STPODP = _oServicio.STPODP
                        If oServicioBL.fintEliminarDetalleServiciosFacturacionSA(oServicioDel) = 0 Then
                            MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                        Else
                            CType(dtgMercaderia.DataSource, DataTable).Rows.Remove(CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, DataRowView).Row)
                            lblItems.Text = dtgMercaderia.Rows.Count.ToString
                        End If
                    End If

                End If
                '**************************************
            Case "S"
                Dim msgInformativo As String = ""
                Dim PNNORSCI As Decimal = 0
                Dim PNNRITEM As Decimal = 0
                Dim obrclsServicioSC_BL As New clsServicioSC_BL
                Dim retorno As Int32 = 0
                Dim PNFLAG_REGISTRO As Int32 = 0
                If (dtgEmbarque.CurrentRow IsNot Nothing) Then
                    PNFLAG_REGISTRO = Val("" & dtgEmbarque.CurrentRow.Cells("FLAG_REGISTRO").Value & "")
                    PNNORSCI = dtgEmbarque.CurrentRow.Cells("NORSCI").Value
                    PNNRITEM = dtgEmbarque.CurrentRow.Cells("NRITEM").Value
                    If (PNFLAG_REGISTRO = 1) Then
                        msgInformativo = String.Format("Está seguro de eliminar el embarque {0} asociado a la operación", PNNORSCI)
                        If (MessageBox.Show(msgInformativo, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                            Dim oEmbarqueServicio As New Servicio_BE
                            oEmbarqueServicio.CCLNT = _oServicio.CCLNT
                            oEmbarqueServicio.NOPRCN = _oServicio.NOPRCN
                            oEmbarqueServicio.NORSCI = PNNORSCI
                            oEmbarqueServicio.PSUSUARIO = ConfigurationWizard.UserName
                            oEmbarqueServicio.NRITEM = PNNRITEM
                            If (obrclsServicioSC_BL.Eliminar_Item_Embarque_Servicio_SC(oEmbarqueServicio) = -1) Then
                                MsgBox("Error Comuníquese con el departamento de sistemas", MessageBoxIcon.Error)
                            Else
                                CType(dtgEmbarque.DataSource, DataTable).Rows.Remove(CType(Me.dtgEmbarque.CurrentRow.DataBoundItem, DataRowView).Row)
                                lblItems.Text = dtgEmbarque.Rows.Count.ToString
                            End If
                        End If
                    Else
                        CType(dtgEmbarque.DataSource, DataTable).Rows.Remove(CType(Me.dtgEmbarque.CurrentRow.DataBoundItem, DataRowView).Row)
                        lblItems.Text = dtgEmbarque.Rows.Count.ToString
                    End If
                End If

        End Select
    End Sub

    Private Sub btnAgregarTermino_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregarTermino.Click
        If oServicio.CCLNT = 0 Then Exit Sub
        If (Me.cmbTerminoBusquedaSAT.Text <> "" OrElse cmbTerminoBusquedaDS.Text <> "" OrElse cmbTerminoBusquedaSIL.Text <> "") And txtCodigo.Text <> "" Then
            If _oServicio.CDVSN = "S" Then
                BuscarSustentoSIL()
            ElseIf _oServicio.STPODP = "7" Then
                BuscarBultos()
            Else
                BuscarSolicituServicio()
            End If
        End If

    End Sub

    Private Sub BuscarSustentoSIL()
        Dim oSerAlmacen As New Servicio_BE
        Dim CodigoBusqueda As Decimal = 0
        Dim IsValidoCodigo As Boolean = False
        If Decimal.TryParse(txtCodigo.Text.Trim, CodigoBusqueda) Then
            With oSerAlmacen
                '.CCLNT = Me.UcClienteOperacion.pCodigo
                .CCLNT = _oServicio.CCLNT
                '_oServicio
                .NOPRCN = _oServicio.NOPRCN
                .CCMPN = _oServicio.CCMPN
                .CDVSN = _oServicio.CDVSN
                '.CPLNDV = cmbPlanta.SelectedValue
                .CPLNDV = _oServicio.CPLNDV
                Select Case Mid(Me.cmbTerminoBusquedaSIL.Text, 1, 1)
                    Case "E"
                        .NORSCI = CodigoBusqueda
                        .PSBUSQUEDA = "E"
                    Case "O"
                        .PNNMOS = CodigoBusqueda
                        .PSBUSQUEDA = "O"
                End Select
            End With
            BuscarEmbarque(oSerAlmacen)
        End If
    End Sub

    Private Sub BuscarEmbarque(ByVal oSerAlmacen As Servicio_BE)
        Dim msgValidacionEmbarque As String = ""

        Dim oDt As DataTable
        Dim obrclsServicioSC_BL As New clsServicioSC_BL
        msgValidacionEmbarque = obrclsServicioSC_BL.ValidaIngresoEmbarqueAOperacion(oSerAlmacen)
        If (msgValidacionEmbarque.Length <> 0) Then
            MessageBox.Show(msgValidacionEmbarque, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        oDt = obrclsServicioSC_BL.Lista_OC_X_Embarque_OS(oSerAlmacen)


        oDt.Columns.Add("NCRROP5", GetType(Integer))
        oDt.Columns.Add("SESTRG_EMB", GetType(String))

        If Me.dtgEmbarque.DataSource Is Nothing And Not oDt Is Nothing Then



            For i As Integer = 0 To oDt.Rows.Count - 1
                oDt.Rows(i).Item("NCRROP5") = IIf(_oServicio.TIPO = Comun.ESTADO_Modificado, nCorr, nCorr + 1)
                oDt.Rows(i).Item("SESTRG_EMB") = "A"
            Next

            dtgEmbarque.DataSource = oDt
            lblItems.Text = oDt.Rows.Count.ToString
        Else

            For i As Integer = 0 To oDt.Rows.Count - 1
                oDt.Rows(i).Item("NCRROP5") = IIf(_oServicio.TIPO = Comun.ESTADO_Modificado, nCorr, nCorr + 1)
                oDt.Rows(i).Item("SESTRG_EMB") = "A"
            Next

            If oDt.Rows.Count > 0 Then
                If dtgEmbarque.DataSource Is Nothing Then dtgEmbarque.DataSource = oDt.Clone

                Dim dr As DataRow = Nothing
                For Each dr In oDt.Rows
                    If Not fblnValidaEmbarque(dr) Then
                        dtgEmbarque.DataSource.ImportRow(dr)
                        lblItems.Text = Val(lblItems.Text) + 1
                    End If
                Next

            End If

        End If

        txtCodigo.Text = ""
        txtCodigo.Focus()
    End Sub

    Private Function fblnValidaEmbarque(ByVal oDr As DataRow) As Boolean
        If dtgEmbarque.DataSource IsNot Nothing Then
            For Each oDrEmbarque As DataRow In Me.dtgEmbarque.DataSource.Rows
                If oDrEmbarque.Item("NORSCI") = oDr.Item("NORSCI") Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function

    'Private Sub txtCentroCosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.F4 Then
    '        CargarAllCC()
    '    Else
    '        If e.KeyCode = Keys.Enter Then
    '            'CargaCentroCosto("")
    '        End If
    '    End If
    'End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        CType(sender, TextBox).Tag = "10-5"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub txtCantidad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        If txtCantidad.Text.EndsWith(".") Then
            txtCantidad.Text = txtCantidad.Text.Replace(".", "")
        End If
    End Sub

    Private Sub txtCantidadReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadReal.KeyPress
        CType(sender, TextBox).Tag = "10-5"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub txtCantidadReal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadReal.Leave
        If txtCantidadReal.Text.EndsWith(".") Then
            txtCantidadReal.Text = txtCantidadReal.Text.Replace(".", "")
        End If
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




    Private Sub txtTipoServicio_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicio.CambioDeTexto
        Try
            'If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
            '    Exit Sub
            'End If
            If Not PerteneceSalmon() Then
                Exit Sub
            End If

            txtCentroBeneficio.Limpiar()
            txtCentroBeneficio.DataSource = Nothing

            If (txtTipoServicio.Resultado Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.CDTSSP = CType(txtTipoServicio.Resultado, ClaseGeneral_BE).CDTSSP
            End If

            Me.CargarCentroBeneficio()
        Catch ex As Exception
            'Dim manejadorExcepciones As New ManejadorExcepciones()
            'manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUnidadProductiva_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductiva.CambioDeTexto
        Try
            'If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
            '    Exit Sub
            'End If
            If Not PerteneceSalmon() Then
                Exit Sub
            End If

            txtCentroBeneficio.Limpiar()
            txtCentroBeneficio.DataSource = Nothing

            If (txtUnidadProductiva.Resultado Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.CDUPSP = CType(txtUnidadProductiva.Resultado, ClaseGeneral_BE).CDUPSP
            End If
            Me.CargarCentroBeneficio()
        Catch ex As Exception
            'Dim manejadorExcepciones As New ManejadorExcepciones()
            'manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboTipoActivo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoActivo.SelectedValueChanged
        Try
            'If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
            '    Exit Sub
            'End If
            If Not PerteneceSalmon() Then
                Exit Sub
            End If
            txtCentroBeneficio.Limpiar()
            txtCentroBeneficio.DataSource = Nothing

            If (CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE) Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.PRCODI = CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE).PRCODI
            End If

            Me.CargarCentroBeneficio()
        Catch ex As Exception
            'Dim manejadorExcepciones As New ManejadorExcepciones()
            'manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub txtCentroCosto_CambioDeTexto(ByVal objData As System.Object) Handles txtCentroBeneficio.CambioDeTexto
    '    Try
    '        uCentroCostoDest.DataSource = Nothing
    '        uCentroCostoDest.Limpiar()
    '        If (txtCentroBeneficio.Resultado Is Nothing) Then
    '            Exit Sub
    '        Else
    '            cargarCentroCostoDestino(CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PNCCNTCS) 'JM
    '        End If
    '        _oServicio.CCNTCS = CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PNCCNTCS

    '    Catch ex As Exception
    '        'Dim manejadorExcepciones As New ManejadorExcepciones()
    '        'manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub txtCentroCosto_ClickOnArrow(ByVal objData As System.Object) Handles txtCentroBeneficio.ClickOnArrow
    '    Try

    '        'If Not (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania) Then
    '        '    Exit Sub
    '        'End If
    '        If Not PerteneceSalmon() Then
    '            Exit Sub
    '        End If

    '        If (txtCentroBeneficio.DataSource Is Nothing) Then
    '            MessageBox.Show("Parámetros insuficiente para listar el centro de beneficio, debe de seleccionar el Tipo de servicio, Unidad Productiva.")
    '        End If

    '    Catch ex As Exception
    '        'Dim manejadorExcepciones As New ManejadorExcepciones()
    '        'manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
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
            lblTipoTarifa.Location() = New Point(329, 116)
            txtTarifaAplicar.Location() = New Point(415, 114)
            txtTarifaAplicar.Width = 165

            lblMoneda.Location() = New Point(611, 116)
            txtMoneda.Location() = New Point(685, 114)
            txtMoneda.Width = 218

            lblCuentaImputacion.Location() = New Point(305, 173)
            txtCI.Location() = New Point(435, 170)
            txtCI.Width = 468

            KryptonLabel19.Location() = New Point(28, 197)
            txtOrdenCompra.Location() = New Point(146, 197)

            KryptonLabel21.Location() = New Point(521, 197)
            cmbLote.Location() = New Point(631, 197)

            KryptonLabel12.Location() = New Point(66, 225)
            txtReferencia.Location() = New Point(146, 225)

            KryptonLabel8.Location() = New Point(56, 250)
            txtObservacion.Location() = New Point(146, 250)

        End If
    End Sub


    Private Sub cmbRubro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRubro.SelectionChangeCommitted
        Try
            If bolBuscar Then
                cargarServicio()
                cargarDatosServicio()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub cmbServicio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbServicio.SelectionChangeCommitted
        Try
            If bolBuscar Then
                cargarDatosServicio()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
    End Sub
End Class

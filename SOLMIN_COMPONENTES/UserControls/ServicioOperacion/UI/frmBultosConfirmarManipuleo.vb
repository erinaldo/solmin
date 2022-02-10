'Imports SOLMIN_CTZ.Entidades.mantenimientos
'Imports SOLMIN_CTZ.NEGOCIO
'Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class frmBultosConfirmarManipuleo
#Region "Propiedades"
    ''' <summary>
    ''' Variable
    ''' </summary>
    ''' <remarks></remarks>
    Private bolBuscar As Boolean = False
    Private _oServicio As Servicio_BE
    Private oDtAlmacenes As DataTable
    Private oDtZonas As DataTable
    Private dgBULTO As New DataTable
    Private dgBULTO_GRAL As New DataTable
    Private estatico As New Estaticos
    Private whereLote As String = ""
    Private whereSentidoCarga As String = ""
    Private whereAlmacen As String = ""
    Private whereZona As String = ""
    Public oDtValidaDetraccion As New DataTable
    Public nCorr As Integer = 0
    Public mListaBultoServicio As List(Of Servicio_BE)
    Public oDtListaPorServicio As New DataTable
    Private Cambiar As Boolean = False
    Private bolCambioxFecha As Boolean = False

    '<[AHM]>
    Dim oClaseGeneral As New clsClaseGeneral_BL
    Dim oCentroCosto As New clsCentroCosto_BL

    'JM
    Private ClienteInterno As Boolean = True


    Dim _pCodigoCompania As String = ""
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
#End Region
#Region "Metodos"
    Private Sub frmBultosConfirma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case _oServicio.CTPALJ
            Case estatico.E_ESP_AlmacenajePeso
                lblLote.Visible = False
                lblSentidoCarga.Visible = False
                cmbLote.Visible = False
                cmbSentidoCarga.Visible = False
                dtgBultos.Columns("SSNCRG_D").Visible = False
                dtgBultos.Columns("TLUGEN").Visible = False
                lblMedioEnvio.Visible = False
                cmbMedioEnvio.Visible = False
                Me.dteFechaInicio.Visible = False
                Me.dteFechaFin.Visible = False
                lblDesde.Visible = False
                lblHasta.Visible = False
            Case estatico.E_ESP_ManipuleoPeso
                'VISIBLE
                If _oServicio.SSTINV = "R" Then
                    lblMedioEnvio.Visible = False
                    cmbMedioEnvio.Visible = False
                Else
                    cmbMedioEnvio.Visible = True
                    lblMedioEnvio.Visible = True
                End If
                Me.dteFechaInicio.Visible = True
                Me.dteFechaFin.Visible = True
                lblDesde.Visible = True
                lblHasta.Visible = True
        End Select

        '<[AHM]>
        'If _oServicio.CCNTCS.Trim.Length > 0 Then txtCentroCosto.Text = _oServicio.CCNTCS

        'If IsNumeric(txtCentroCosto.Text) Then
        '    oDtCCosto = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)

        '    For Each dr As DataRow In oDtCCosto.Select("CCNTCS =" & txtCentroCosto.Text)
        '        txtCentroCosto.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
        '    Next

        'End If
        '</[AHM]>
        cargarCentroCostoOrigen() 'JM
        CargarUnidadMedida()
        CargarMedioEnvio()
        CargarLotesServicio()
        cargarDatosServicio()

        If _oServicio.TIPO = Comun.ESTADO_Modificado Then

            'tsbSalir.Visible = False

            If _oServicio.FOPRCN <> 0 Then
                Me.dteFechaOperacion.Value = Comun.FormatoFecha(_oServicio.FOPRCN)
            End If

            If nCorr = 0 Then
                CargarBultosTemp_1()
            Else
                CargarBultosTemp_2()
            End If
            dgBULTO_GRAL = CType(Me.dtgBultos.DataSource, DataTable).Copy
            CargarLotes()
            cargarSentidoCarga()
            If _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Then
                If _oServicio.FINPRF <> 0 Then
                    Me.dteFechaInicio.Value = Comun.FormatoFecha(_oServicio.FINPRF)
                End If
                If _oServicio.FFNPRF <> 0 Then
                    Me.dteFechaFin.Value = Comun.FormatoFecha(_oServicio.FFNPRF)
                End If
                cmbUnidadMedida.SelectedValue = _oServicio.CUNDMD

            End If
            txtCantidadServicio.txtDecimales.Text = _oServicio.QATNAN.ToString
            txtCantidadReal.txtDecimales.Text = _oServicio.QATNRL.ToString
            Cambiar = True
            '<[AHM]>'
            txtTipoServicio.Valor = _oServicio.CDTSSP
            txtUnidadProductiva.Valor = _oServicio.CDUPSP
            cboTipoActivo.SelectedValue = _oServicio.PRCODI
            txtCentroBeneficio.Valor = _oServicio.CCNTCS

            txtTipoServicio.Enabled = False
            txtUnidadProductiva.Enabled = False
            cboTipoActivo.Enabled = False
            txtCentroBeneficio.Enabled = False
            '</[AHM]>'

            'JM
            uCentroCostoOrig.Valor = _oServicio.CENCO2
            uCentroCostoDest.Valor = _oServicio.CENCOS

        Else
            Cambiar = True
            cargarBultos()
            cargarSumaCantidades()
        End If

        cargarTipoAlmacen()

        txtCI.Text = _oServicio.TCTCST.Trim
        txtObservacion.Text = _oServicio.TSRVC.Trim
        txtOrdenCompra.Text = _oServicio.NORCML.Trim
        txtReferencia.Text = _oServicio.TRFSRC.Trim
        If Not _oServicio.TLUGEN Is Nothing Then
            cmbLote.SelectedValue = _oServicio.TLUGEN.Trim
        End If
        If dgBULTO_GRAL.Rows.Count > 0 Then cargarTipoAlmacen()


        'JM  
        MostrarControlesClienteFacturar(_oServicio.CCMPN, _oServicio.CCLNFC)

    End Sub

    Private Sub CargarBultosTemp_1()
        dtgBultos.AutoGenerateColumns = False
        Me.dtgBultos.DataSource = oDtListaPorServicio
        Dim nTotal As Integer = 0
        Try
            nTotal = oDtListaPorServicio.Compute("Sum( QREFFW)", "")
        Catch ex As Exception

        End Try

        KryptonHeaderGroup1.ValuesSecondary.Heading = "Total Cantidad: " & nTotal.ToString

    End Sub
    Private Sub CargarBultosTemp_2()
        dtgBultos.AutoGenerateColumns = False
        oDtListaPorServicio.DefaultView.RowFilter = "NCRROP=" & nCorr.ToString
        oDtListaPorServicio = oDtListaPorServicio.DefaultView.ToTable
        dtgBultos.DataSource = oDtListaPorServicio
        Dim nTotal As Integer
        Try
            nTotal = oDtListaPorServicio.Compute("Sum( QREFFW)", "")
        Catch ex As Exception

        End Try

        KryptonHeaderGroup1.ValuesSecondary.Heading = "Total Cantidad: " & nTotal.ToString

    End Sub
    Private Sub CargarMedioEnvio()
        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        Dim oDtAux As New DataTable

        oDt.Columns.Add("CMEDTR", GetType(Integer))
        oDt.Columns.Add("TNMMDT", GetType(String))
        Dim dr As DataRow
        dr = oDt.NewRow()
        dr("CMEDTR") = 0
        dr("TNMMDT") = "-------TODOS-------"
        oDt.Rows.Add(dr)

        oDtAux = oServicioBL.fdtListaMedioEnvio()
        oDtAux.DefaultView.Sort = "TNMMDT"
        oDtAux = oDtAux.DefaultView.ToTable

        For Each dr0 As DataRow In oDtAux.Rows
            oDt.ImportRow(dr0)
        Next
        cmbMedioEnvio.DataSource = oDt

        cmbMedioEnvio.ValueMember = "CMEDTR"
        cmbMedioEnvio.DisplayMember = "TNMMDT"
        cmbMedioEnvio.SelectedValue = 0
    End Sub
    Private Sub CargarUnidadMedida()
        Dim UM As New clsUnidadMedida_BL
        bolBuscar = False
        Me.cmbUnidadMedida.DataSource = UM.Lista_UnidadMedida
        Me.cmbUnidadMedida.ValueMember = "COD"
        bolBuscar = True
        Me.cmbUnidadMedida.DisplayMember = "VAL"
    End Sub
    Private Sub cargarBultos()
        If _oServicio.CCLNT = 0 Then Exit Sub
        Dim oSerV_BL As New clsServicio_BL
        dtgBultos.DataSource = Nothing
        dtgBultos.AutoGenerateColumns = False

        If Not _oServicio.BULTOS Is Nothing Then
            If _oServicio.BULTOS.Rows.Count > 0 Then
                dtgBultos.DataSource = _oServicio.BULTOS
                dgBULTO_GRAL = _oServicio.BULTOS.Copy
            End If
        Else

            If Cambiar Then
                Select Case _oServicio.CTPALJ
                    Case estatico.E_ESP_AlmacenajePeso ' "AP"
                        _oServicio.FSLFFW = Format(dteFechaOperacion.Value, "yyyyMMdd")
                        dgBULTO = oSerV_BL.ListarBultosAlmacenaje_RangoFecha(_oServicio)

                    Case estatico.E_ESP_ManipuleoPeso ' "MP"
                        _oServicio.FREFFW = Format(dteFechaInicio.Value, "yyyyMMdd")
                        _oServicio.FSLFFW = Format(dteFechaFin.Value, "yyyyMMdd")
                        _oServicio.MEDIOENVIO = cmbMedioEnvio.SelectedValue

                        dgBULTO = oSerV_BL.ListarBultosAlmacenaje_RangoFecha_MP(_oServicio)
                End Select
                dtgBultos.DataSource = Nothing
                dtgBultos.DataSource = dgBULTO
                'End Select
                dgBULTO_GRAL = dgBULTO.Copy 'HACEMOS UNA COPIA PARA USAR EN EL FILTRADO
            End If

        End If

        If _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Then
            CargarLotes()
            cargarSentidoCarga()
            cargarTipoAlmacen()
        End If

        Dim nTotal As Integer = 0
        Try
            nTotal = dgBULTO_GRAL.Compute("Sum( QREFFW)", "")
        Catch ex As Exception
        End Try


        'KryptonHeaderGroup1.ValuesSecondary.Heading = "Total Bultos: " & nTotal.ToString

    End Sub

    ''' <summary>
    ''' Cargar Cargar Lotes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarLotes()
        Dim oDtSentCarga As New DataTable
        Dim oDtListaLotes As New DataTable
        '===Listamos los Sentidos Existentes en la Grilla==='
        If CType(dtgBultos.DataSource, DataTable).Columns.Count = 0 Then Exit Sub
        oDtListaLotes = CType(dtgBultos.DataSource, DataTable).Copy
        oDtListaLotes = oDtListaLotes.DefaultView.ToTable(True, "TLUGEN")
        oDtListaLotes.Columns.Add("KEY")
        For Each oDr As DataRow In oDtListaLotes.Rows
            oDr("KEY") = oDr("TLUGEN")
        Next
        Dim oServicioOpeNeg As New clsServicio_BL
        Dim oSer As New Servicio_BE
        cmbLote.ValueMember = "KEY"
        cmbLote.DisplayMember = "TLUGEN"
        cmbLote.DataSource = oDtListaLotes
        For i As Integer = 0 To cmbLote.Items.Count - 1
            cmbLote.SetItemChecked(i, True)
        Next
    End Sub

    ''' <summary>
    ''' Carga el Sentido de Carga
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarSentidoCarga()
        Dim oServicioOpeNeg As New clsServicio_BL
        Dim oDtSentCarga As New DataTable
        Dim oDtListaSSNCRGgrilla As New DataTable
        oDtSentCarga = oServicioOpeNeg.ListarSentidoCargaManipuleo()
        '===Listamos los Sentidos Existentes en la Grilla==='
        If CType(dtgBultos.DataSource, DataTable).Columns.Count = 0 Then Exit Sub
        oDtListaSSNCRGgrilla = CType(dtgBultos.DataSource, DataTable).Copy
        oDtListaSSNCRGgrilla = oDtListaSSNCRGgrilla.DefaultView.ToTable(True, "SSNCRG", "SSNCRG_D")
        cmbSentidoCarga.ValueMember = "SSNCRG"
        cmbSentidoCarga.DisplayMember = "SSNCRG_D"
        cmbSentidoCarga.DataSource = oDtListaSSNCRGgrilla
        For i As Integer = 0 To cmbSentidoCarga.Items.Count - 1
            cmbSentidoCarga.SetItemChecked(i, True)
        Next
    End Sub

    ''' <summary>
    ''' Carga Tipo Almacen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarTipoAlmacen()
        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        bolBuscar = False
        oDt = oServicioBL.Listar_TipoAlmacen(_oServicio.CCLNT)
        cmbTipoAlmacen.DataSource = AgregarTodosAlInicio(oDt)
        cmbTipoAlmacen.ValueMember = "CTPALM"
        bolBuscar = True
        cmbTipoAlmacen.DisplayMember = "TALMC"

        For i As Integer = 0 To cmbTipoAlmacen.Items.Count - 1
            If cmbTipoAlmacen.Items.Item(i).Value = "0" Then
                cmbTipoAlmacen.SetItemChecked(i, True)
                If cmbAlmacen.DataSource Is Nothing Then
                    cargaAlmacen()
                Else
                    If bolCambioxFecha Then
                        cargaAlmacen()
                    End If
                End If

            End If
        Next
    End Sub


    ''' <summary>
    ''' Carga Almacen Combo con CheckBox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargaAlmacen()
        Dim dgFiltro As DataTable
        Dim strFiltro As String = ""

        If Me.cmbTipoAlmacen.CheckedItems.Count <> 0 Then
            If cmbTipoAlmacen.CheckedItems(0).Value <> "0" Then
                strFiltro = " (" & Lista_TipoAlmacen() & ")   "
            End If
        End If

        dgFiltro = dgBULTO_GRAL.Copy
        If dgFiltro.Rows.Count > 0 Then dgFiltro = dgFiltro.DefaultView.ToTable(True, "CALMC", "TCMPAL", "CTPALM") Else Exit Sub
        dgFiltro.DefaultView.RowFilter = strFiltro
        '------------------------------------------------------------------
        cmbAlmacen.ValueMember = "CALMC"
        cmbAlmacen.DisplayMember = "TCMPAL"
        cmbAlmacen.DataSource = AgregarTodosAlInicio(dgFiltro.DefaultView.ToTable)
        For i As Integer = 0 To cmbAlmacen.Items.Count - 1
            If cmbAlmacen.Items.Item(i).Value = "0" Then
                cmbAlmacen.SetItemChecked(i, True)
                If cmbZona.DataSource Is Nothing Then
                    cargaZona()
                Else
                    If bolCambioxFecha Then
                        cargaZona()
                    End If
                End If

            End If
        Next
    End Sub

    Private Function AgregarTodosAlInicio(ByVal dtObjecto As DataTable) As DataTable
        Dim objDr As DataRow
        If dtObjecto.Rows.Count > 0 Then
            objDr = dtObjecto.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            dtObjecto.Rows.InsertAt(objDr, 0)
        End If
        Return dtObjecto
    End Function

    ''' <summary>
    ''' Carga Zona Combo con CheckBox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargaZona()
        Dim dgFiltro As DataTable
        Dim strFiltro As String = ""

        If Me.cmbTipoAlmacen.CheckedItems.Count <> 0 Then
            If cmbTipoAlmacen.CheckedItems(0).Value <> "0" Then
                strFiltro = " (" & Lista_TipoAlmacen() & ") AND "
            End If
        End If
        If Me.cmbAlmacen.CheckedItems.Count <> 0 Then
            If cmbAlmacen.CheckedItems(0).Value <> "0" Then
                If strFiltro.Trim.EndsWith("AND") Then
                    strFiltro = strFiltro & " (" & ListaAlmacen() & ")  AND "
                Else
                    strFiltro = " (" & ListaAlmacen() & ") AND "
                End If
            End If
        End If

        dgFiltro = dgBULTO_GRAL.Copy
        If dgFiltro.Rows.Count > 0 Then dgFiltro = dgFiltro.DefaultView.ToTable(True, "CZNALM", "TCMZNA", "CTPALM", "CALMC") Else Exit Sub

        If strFiltro.Trim.Length = 0 Then
            dgFiltro.DefaultView.RowFilter = ""
        Else
            If strFiltro.Trim.EndsWith("AND") Then
                strFiltro = strFiltro.Trim.Remove(strFiltro.Trim.Length - 3, 3)
            End If
            dgFiltro.DefaultView.RowFilter = strFiltro
        End If

        '------------------------------------------------------------------
        cmbZona.ValueMember = "CZNALM"
        cmbZona.DisplayMember = "TCMZNA"
        cmbZona.DataSource = AgregarTodosAlInicio(dgFiltro.DefaultView.ToTable)
        For i As Integer = 0 To cmbZona.Items.Count - 1
            If cmbZona.Items.Item(i).Value = "0" Then
                cmbZona.SetItemChecked(i, True)
            End If
        Next
    End Sub

    Private Function Lista_Almacen() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbAlmacen.CheckedItems.Count - 1
            If cmbAlmacen.CheckedItems(i).Value = "0" Then
                For j As Integer = 0 To oDtAlmacenes.Rows.Count - 1
                    strCadDocumentos += oDtAlmacenes.Rows(j).Item("CALMC") & ","
                Next
                Exit For
            End If
            For j As Integer = 0 To oDtAlmacenes.Rows.Count - 1
                If (oDtAlmacenes.Rows(j).Item("CALMC") = cmbAlmacen.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtAlmacenes.Rows(j).Item("CALMC") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Function ListaAlmacen() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbAlmacen.CheckedItems.Count - 1
            strCadDocumentos += " CALMC = '" & cmbAlmacen.CheckedItems(i).Value & "' OR"
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 2)
        Return strCadDocumentos
    End Function

    Private Function ListaTipoAlmacen() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbTipoAlmacen.CheckedItems.Count - 1
            strCadDocumentos += " CALMC = '" & cmbTipoAlmacen.CheckedItems(i).Value & "' OR"
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 2)
        Return strCadDocumentos
    End Function


    Private Sub cargarServicio()
        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        If oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Then
            _oServicio.NRRUBR = 1 'Solo el rubro de almacenaje -_-_-_-_-_-_- 
        Else
            _oServicio.NRRUBR = 2 'Solo el rubro de almacenaje -_-_-_-_-_-_- 
        End If

        If Not _oServicio.TIPO = Comun.ESTADO_Modificado Then
            _oServicio.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
        End If


        ' bolBuscar = False
        oDt = oServicioBL.Cargar_Servicios_Tarifa_Cliente(_oServicio)

        If _oServicio.TIPO = Comun.ESTADO_Modificado Then
            oDt.DefaultView.RowFilter = "CUNDMD = '" & _oServicio.CUNDMD & "' AND NRTFSV = " & _oServicio.NRTFSV
            oDt = oDt.DefaultView.ToTable
            If oDt.Rows.Count > 0 Then
                cmbServicio.DataSource = oDt
                cmbServicio.ValueMember = "NRTFSV"
                bolBuscar = True
                cmbServicio.DisplayMember = "DESTAR"
            End If

        Else
            oDt.DefaultView.RowFilter = "CUNDMD = '" & cmbUnidadMedida.SelectedValue & "' "
            oDt = oDt.DefaultView.ToTable
            If oDt.Rows.Count > 0 Then
                cmbServicio.DataSource = oDt
                cmbServicio.ValueMember = "NRTFSV"
                bolBuscar = True
                cmbServicio.DisplayMember = "DESTAR"
            Else
                cmbServicio.DataSource = Nothing
            End If

        End If





    End Sub


    Private Function Lista_Zona() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbZona.CheckedItems.Count - 1
            strCadDocumentos += " CZNALM = '" & cmbZona.CheckedItems(i).Value & "' OR"
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 2)
        Return strCadDocumentos
    End Function

    Private Sub cargarDatosServicio()
        Try
            Dim odtTarifa As New DataTable
            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            If Not Me.cmbServicio.DataSource Is Nothing Then
                _oServicio.NRTFSV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("NRTFSV")
            End If
            odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(_oServicio.NRTFSV)

            If (odtTarifa.Rows.Count > 0) Then

                '<[AHM]>
                'If txtCentroCosto.Text.Length = 0 Then
                '    txtCentroCosto.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim

                '    _oServicio.CCNTCS = odtTarifa.Rows(0)("CCNTCS").ToString.Trim
                'End If
                '</[AHM]>

                txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA_DESC").ToString.Trim
                txtValorServicio.Text = CDbl(odtTarifa.Rows(0)("IVLSRV").ToString.Trim)

                txtMoneda.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim
                '<[AHM]>
                Dim CDSRSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSRSP").ToString()
                Dim CDSPSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSPSP").ToString()
                Dim CDTASP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDTASP").ToString()

                Dim CDTSSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDTSSP").ToString()
                Dim CDUPSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDUPSP").ToString()

                Me.CargarTipoServicioSAP(CDSRSP)
                Me.CargarUnidadProductivaSAP(CDSPSP)
                Me.CargarTipoActivoSAP()

                txtTipoServicio.Valor = CDTSSP
                txtUnidadProductiva.Valor = CDUPSP
                cboTipoActivo.SelectedValue = CDTASP
                '<[AHM]>

                'JM
                txtTarifaInterna.Text = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("ISRVTI").ToString()
                uCentroCostoOrig.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CENCO2").ToString()
                uCentroCostoDest.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CENCOS").ToString()

                If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
                    CargarCentroBeneficio()
                End If

            Else

                txtCentroBeneficio.Text = String.Empty
                txtTarifaAplicar.Text = String.Empty
                txtValorServicio.Text = String.Empty
                txtMoneda.Text = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Lista_Lote() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbLote.CheckedItems.Count - 1
            strCadDocumentos += " TLUGEN = '" & cmbLote.CheckedItems(i).Value & "' OR"
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 2)
        Return strCadDocumentos
    End Function

    Private Function Lista_SentidoCarga() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbSentidoCarga.CheckedItems.Count - 1 'cmbSentidoCarga.CheckedItems.Count - 1
            strCadDocumentos += " SSNCRG = '" & cmbSentidoCarga.CheckedItems(i).Value & "' OR"
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 2)
        Return strCadDocumentos
    End Function

    Private Function Lista_TipoAlmacen() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To Me.cmbTipoAlmacen.CheckedItems.Count - 1 'cmbSentidoCarga.CheckedItems.Count - 1
            strCadDocumentos += " CTPALM = '" & cmbTipoAlmacen.CheckedItems(i).Value & "' OR"
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 2)
        Return strCadDocumentos
    End Function

#End Region

    Private Sub tsbConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConfirmar.Click
        If _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Then
            '===Recalcula antes de ser enviado===
        End If

        If Not valida() Then Exit Sub

        If Me.cmbServicio.DataSource IsNot Nothing Then
            _oServicio.NRTFSV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("NRTFSV")
            _oServicio.DESTAR = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("DESTAR")
            _oServicio.VALCTE = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("VALCTE")
            _oServicio.CUNDMD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CUNDMD")
            _oServicio.TSGNMN = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("TSGNMN")
            '_oServicio.CCNTCS = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
            _oServicio.IVLSRV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("IVLSRV")
            _oServicio.SRBAFD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("SRBAFD") 'DETRACCION
            _oServicio.TCTCST = txtCI.Text.Trim
            _oServicio.TARIFA_DESC = cmbServicio.Text
            _oServicio.NORCML = txtOrdenCompra.Text.Trim
            _oServicio.FINPRF = Format(dteFechaInicio.Value, "yyyyMMdd")
            _oServicio.FFNPRF = Format(dteFechaFin.Value, "yyyyMMdd")
            _oServicio.FATNSR = Format(dteFechaOperacion.Value, "yyyyMMdd")
            _oServicio.FOPRCN = _oServicio.FATNSR
            _oServicio.TSRVC = txtObservacion.Text
            _oServicio.TRFSRC = txtReferencia.Text
            'Cantidad Real
            _oServicio.QATNAN = IIf(IsNumeric(txtCantidadServicio.txtDecimales.Text), txtCantidadServicio.txtDecimales.Text, 0)
            _oServicio.QATNRL = IIf(IsNumeric(txtCantidadReal.txtDecimales.Text), txtCantidadReal.txtDecimales.Text, 0)
            If Not cmbLoteServicio.SelectedIndex = 0 Then
                _oServicio.TLUGEN = cmbLoteServicio.Text.Trim
            End If

            'JM
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

            'dtgBultos.EndEdit()
            'dgBULTO = dtgBultos.DataSource
            mListaBultoServicio = New List(Of Servicio_BE)
            Dim obeServicio As New Servicio_BE
            For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos
                obeServicio = New Servicio_BE
                obeServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                obeServicio.DESCWB = dtgBultos.Rows(i).Cells("DESCWB").Value
                obeServicio.TUBRFR = Convert.ToString(dtgBultos.Rows(i).Cells("TUBRFR").Value)
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

                obeServicio.TCMZNA = dtgBultos.Rows(i).Cells("TCMZNA").Value
                obeServicio.TALMC = dtgBultos.Rows(i).Cells("TALMC").Value
                obeServicio.TCMPAL = dtgBultos.Rows(i).Cells("TCMPAL").Value

                obeServicio.NSEQIN = dtgBultos.Rows(i).Cells("NSEQIN").Value

                obeServicio.SSNCRG = dtgBultos.Rows(i).Cells("SSNCRG").Value
                obeServicio.SSNCRG_D = dtgBultos.Rows(i).Cells("SSNCRG_D").Value
                obeServicio.TLUGEN = dtgBultos.Rows(i).Cells("TLUGEN").Value
                If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
                    obeServicio.NCRROP = nCorr + 1
                Else
                    obeServicio.NCRROP = IIf(dtgBultos.Rows(i).Cells("NCRROP").Value Is Nothing, IIf(nCorr > 0, nCorr, nCorr + 1), dtgBultos.Rows(i).Cells("NCRROP").Value)
                End If
                mListaBultoServicio.Add(obeServicio)
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub cargarSumaCantidades()
        Dim Total As Double = 0D
        For intCont As Integer = 0 To Me.dtgBultos.Rows.Count - 1
            Select Case cmbUnidadMedida.SelectedValue
                Case Comun.UNIDAD_MT2
                    Total += Me.dtgBultos.Rows(intCont).Cells("QAROCP").Value
                Case Comun.UNIDAD_MT3
                    Total += Me.dtgBultos.Rows(intCont).Cells("QVLBTO").Value
                Case Comun.UNIDAD_KGS
                    Total += Me.dtgBultos.Rows(intCont).Cells("QPSOBL").Value
            End Select
        Next
        txtCantidadServicio.txtDecimales.Text = Total.ToString
        txtCantidadReal.txtDecimales.Text = Total.ToString
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function valida() As Boolean

        If cmbServicio.DataSource Is Nothing Then
            MessageBox.Show("Ingrese Servicio", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        '<[AHM]>
        If (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania) Then
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


        'Centro de costo origen y centro de costo destino 
        'son obligatorios si el cliente es interno  (JM)
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

        If dtgBultos.Rows.Count = 0 Then
            MessageBox.Show("Ingrese Bultos", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If


        Return True
    End Function

    Private Sub FiltrarCOnsulta()

        Dim dgFiltro As New DataTable
        Dim strFiltro As String = ""

        If dgBULTO_GRAL.Rows.Count = 0 Then
            dgBULTO_GRAL = CType(dtgBultos.DataSource, DataTable).Copy
            Exit Sub
        End If
        dgFiltro = dgBULTO_GRAL.Copy
        dtgBultos.DataSource = Nothing

        If Me.cmbTipoAlmacen.CheckedItems.Count <> 0 Then
            If cmbTipoAlmacen.CheckedItems(0).Value <> "0" Then
                strFiltro = " (" & Lista_TipoAlmacen() & ") AND "
            End If
        End If

        If Me.cmbAlmacen.CheckedItems.Count <> 0 Then
            If cmbAlmacen.CheckedItems(0).Value <> "0" Then
                If strFiltro.Trim.EndsWith("AND") Then
                    strFiltro = strFiltro & " (" & ListaAlmacen() & ")  AND "
                Else
                    strFiltro = " (" & ListaAlmacen() & ") AND "
                End If
            End If
        End If
        If Me.cmbZona.CheckedItems.Count <> 0 Then
            If cmbZona.CheckedItems(0).Value <> "0" Then
                If strFiltro.Trim.EndsWith("AND") Then
                    strFiltro = strFiltro & " (" & Lista_Zona() & ")  AND "
                Else
                    strFiltro = " (" & Lista_Zona() & ")  AND "
                End If
            End If
        End If
        If Me.cmbSentidoCarga.CheckedItems.Count <> 0 And _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Then
            If cmbSentidoCarga.CheckedItems(0).Value <> "0" Then
                If strFiltro.Trim.EndsWith("AND") Then
                    strFiltro = strFiltro & " (" & Lista_SentidoCarga() & ")  AND "
                Else
                    strFiltro = " (" & Lista_SentidoCarga() & ")  AND "
                End If
            End If

        End If
        If Me.cmbLote.CheckedItems.Count <> 0 And _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Then
            If cmbLote.CheckedItems(0).Value <> "0" Then
                If strFiltro.Trim.EndsWith("AND") Then
                    strFiltro = strFiltro & " (" & Lista_Lote() & ") AND "
                Else
                    strFiltro = " (" & Lista_Lote() & ") AND "
                End If
            End If

        End If

        If strFiltro.Trim.Length = 0 Then
            dgFiltro.DefaultView.RowFilter = ""
        Else
            If strFiltro.Trim.EndsWith("AND") Then
                strFiltro = strFiltro.Trim.Remove(strFiltro.Trim.Length - 3, 3)
            End If
            dgFiltro.DefaultView.RowFilter = strFiltro
        End If
        dtgBultos.DataSource = dgFiltro.DefaultView.ToTable
        cargarSumaCantidades()
        'Dim nTotal As Integer = 0
        'Try
        '    nTotal = CType(dtgBultos.DataSource, DataTable).Compute("Sum( QREFFW)", "")
        'Catch ex As Exception

        'End Try

        'KryptonHeaderGroup1.ValuesSecondary.Heading = "Total Cantidad: " & nTotal.ToString
    End Sub


    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        FiltrarCOnsulta()
    End Sub

    Private Sub cmbSentidoCarga_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSentidoCarga.SelectedIndexChanged

    End Sub

    Private Sub cmbTipoAlmacen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoAlmacen.Leave
        If cmbAlmacen.DataSource Is Nothing Then cargaAlmacen()
    End Sub



    Private Sub cmbAlmacen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.Leave
        If cmbZona.DataSource Is Nothing Then cargaZona()
    End Sub


    Private Sub cmbServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServicio.SelectedIndexChanged
        If (bolBuscar) Then
            cargarDatosServicio()
        End If
    End Sub

#Region "Centro de Costo"
    Private Codigo As String = ""
    '<[AHM]>
    'Private Sub btnCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CargarAllCC()
    'End Sub
    '<[AHM]>

    'Private Sub txtCentroCosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.F4 Then
    '        CargarAllCC()
    '    Else
    '        If e.KeyCode = Keys.Enter Then
    '            CargaCentroCosto()
    '        End If
    '    End If
    'End Sub

    'Private Sub txtCentroCosto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    CargaCentroCosto()
    'End Sub
    Private oServicioBL As New clsServicio_BL
    Private oDtCCosto As New DataTable

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



        Dim codCompania As String = String.Empty
        Dim codRegionVentaSAP As String = String.Empty
        Dim codMacroServicioSAP As String = String.Empty

        Dim codTipoActivoSAP As String = String.Empty
        Dim codSedeSAP As String = String.Empty
        Dim tipoCentroSAP As String = String.Empty


        If (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then

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
#End Region

    Private Sub cmbUnidadMedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnidadMedida.SelectedIndexChanged
        If bolBuscar Then
            cargarServicio()
            cargarSumaCantidades()
        End If
    End Sub

    Private Sub dteFechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteFechaInicio.ValueChanged
        If bolBuscar And _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso And Cambiar Then
            cargarBultos()
            bolCambioxFecha = True
            cargarTipoAlmacen()
            bolCambioxFecha = False
            cargarSumaCantidades()
        End If
    End Sub

    Private Sub dteFechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteFechaFin.ValueChanged
        If bolBuscar And _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso And Cambiar Then
            cargarBultos()
            bolCambioxFecha = True
            cargarTipoAlmacen()
            bolCambioxFecha = False
            cargarSumaCantidades()
        End If
    End Sub



    Private Sub cmbMedioEnvio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedioEnvio.SelectedIndexChanged
        If bolBuscar And Cambiar Then

            Dim valMedio As String = ""

            Try
                valMedio = cmbMedioEnvio.SelectedValue
            Catch ex As Exception
            End Try

            If valMedio <> String.Empty And _oServicio.SSTINV = "D" Then

                cargarBultos()

            End If


        End If
    End Sub


    Private Sub dteFechaOperacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteFechaOperacion.ValueChanged
        If bolBuscar And _oServicio.CTPALJ = estatico.E_ESP_AlmacenajePeso And Cambiar Then
            cargarBultos()
            bolCambioxFecha = True
            cargarTipoAlmacen()
            bolCambioxFecha = False
        End If
    End Sub

    ''' <summary>
    ''' Cargar Cargar Lotes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarLotesServicio()
        Dim oServicioOpeNeg As New clsServicio_BL
        Me.cmbLoteServicio.DataSource = oServicioOpeNeg.ListarLotes(_oServicio.CCLNT)
        Me.cmbLoteServicio.ValueMember = "TLTECL"
        Me.cmbLoteServicio.DisplayMember = "TLTECL"
        If _oServicio.TLUGEN <> "" Then
            cmbLoteServicio.SelectedValue = _oServicio.TLUGEN
        Else
            cmbLoteServicio.ComboBox.SelectedIndex = 0
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
        claseGeneralList = oClaseGeneral.Listar_Tipo_Servicio_SAP(PSCDSRSP)

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
        claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP(PSCDSRSP)

        txtUnidadProductiva.DataSource = claseGeneralList
        txtUnidadProductiva.ListColumnas = oListColum
        txtUnidadProductiva.Cargas()
        txtUnidadProductiva.ValueMember = "CDUPSP"
        txtUnidadProductiva.DispleyMember = "TDUPSP"

    End Sub

    'JM
    Private Sub cargarCentroCostoOrigen()

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
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(3, oColumnas)

        Dim olCentroCostoOrigen As New List(Of CentroCosto_BE)
        olCentroCostoOrigen = oCentroCosto.Listar_CentroCosto_Origen_Tarifa(_oServicio.CCMPN)

        uCentroCostoOrig.DataSource = olCentroCostoOrigen
        uCentroCostoOrig.ListColumnas = oListColum
        uCentroCostoOrig.Cargas()
        uCentroCostoOrig.ValueMember = "PNCCNTCS"
        uCentroCostoOrig.DispleyMember = "PSTCNTCS"

    End Sub

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



    Private Sub txtTipoServicio_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicio.CambioDeTexto
        Try

            If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
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
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtUnidadProductiva_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductiva.CambioDeTexto
        Try
            If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
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
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub cboTipoActivo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoActivo.SelectedValueChanged
        Try
            If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
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
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtCentroCosto_CambioDeTexto(ByVal objData As System.Object) Handles txtCentroBeneficio.CambioDeTexto
        Try
            'JM
            uCentroCostoDest.DataSource = Nothing
            uCentroCostoDest.Limpiar()
            If (txtCentroBeneficio.Resultado Is Nothing) Then
                Exit Sub
            Else
                cargarCentroCostoDestino(CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PNCCNTCS) 'JM
            End If

            _oServicio.CCNTCS = CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PNCCNTCS
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtCentroCosto_ClickOnArrow(ByVal objData As System.Object) Handles txtCentroBeneficio.ClickOnArrow
        Try
            If Not (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania) Then
                Exit Sub
            End If

            If (txtCentroBeneficio.DataSource Is Nothing) Then
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
            lblCCOrigen.Visible = False
            uCentroCostoOrig.Visible = False
            lblCCDestino.Visible = False
            uCentroCostoDest.Visible = False
            '******************* LOCALIZACION  DE LOS CONTROLES ************
            txtCentroBeneficio.Width = 417
            KryptonLabel10.Location() = New Point(798, 87)
            txtMoneda.Location() = New Point(858, 85)
            txtMoneda.Width = 117
            dteFechaOperacion.Width = 100
            txtTarifaAplicar.Width = 100
            txtValorServicio.Width = 100
        End If
    End Sub
End Class

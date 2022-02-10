Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmContrato
    Private oCliente As SOLMIN_CTZ.NEGOCIO.clsCliente
    Private oEstado As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private oTipoProducto As SOLMIN_CTZ.NEGOCIO.clsTipoProducto
    Private oTipoDeposito As SOLMIN_CTZ.NEGOCIO.clsTipoDeposito
    Private oContratoNeg As SOLMIN_CTZ.NEGOCIO.clsContrato
    Private oContrato As SOLMIN_CTZ.Entidades.Contrato
    Private oPlanta As SOLMIN_CTZ.NEGOCIO.clsPlanta
    Private oUsuario As SOLMIN_CTZ.NEGOCIO.clsUsuario
    Private oBitacora_Contrato As SOLMIN_CTZ.Entidades.Bitacora_Contrato
    Private oDetContratoNeg As SOLMIN_CTZ.NEGOCIO.clsDetContrato
    Private oDetContrato As SOLMIN_CTZ.Entidades.Detalle_Contrato
    Private oBitacoraDet As SOLMIN_CTZ.Entidades.Bitacora_Detalle
    Private oFiltro As SOLMIN_CTZ.Entidades.Filtro
    Private oTarifaNeg As SOLMIN_CTZ.NEGOCIO.clsTarifa
    Private oTarifarioNeg As SOLMIN_CTZ.NEGOCIO.clsTarifario
    Private oMoneda As SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oDivision As clsDivision
    Private oIGV As SOLMIN_CTZ.NEGOCIO.clsIGV
    Private oEjecutivoSIL As SOLMIN_CTZ.NEGOCIO.clsEjecutivoSIL
    Private oContratoTransporte As SOLMIN_CTZ.Entidades.Contrato_Transporte
    Private oContratoSIL As SOLMIN_CTZ.Entidades.Contrato_SIL
    Private oContratoAlmacen As SOLMIN_CTZ.Entidades.Contrato_Almacen
    Private oContratoAS400Neg As SOLMIN_CTZ.NEGOCIO.clsContratoAS400

    Private Sub frmContrato_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oUsuario = DirectCast(HttpRuntime.Cache.Get("Usuario"), clsUsuario)
        oCliente = DirectCast(HttpRuntime.Cache.Get("Cliente"), clsCliente)
        oDivision = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision)
        oEstado = New clsEstado
        oTipoProducto = New clsTipoProducto
        oTipoDeposito = New clsTipoDeposito
        oContratoNeg = New SOLMIN_CTZ.NEGOCIO.clsContrato
        oContrato = New SOLMIN_CTZ.Entidades.Contrato
        oBitacora_Contrato = New SOLMIN_CTZ.Entidades.Bitacora_Contrato
        oDetContratoNeg = New SOLMIN_CTZ.NEGOCIO.clsDetContrato
        oDetContrato = New SOLMIN_CTZ.Entidades.Detalle_Contrato
        oBitacoraDet = New SOLMIN_CTZ.Entidades.Bitacora_Detalle
        oFiltro = New SOLMIN_CTZ.Entidades.Filtro
        oTarifaNeg = New SOLMIN_CTZ.NEGOCIO.clsTarifa
        oTarifarioNeg = New SOLMIN_CTZ.NEGOCIO.clsTarifario
        oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
        oPlanta = New SOLMIN_CTZ.NEGOCIO.clsPlanta
        oIGV = New SOLMIN_CTZ.NEGOCIO.clsIGV
        oEjecutivoSIL = New SOLMIN_CTZ.NEGOCIO.clsEjecutivoSIL
        oContratoTransporte = New SOLMIN_CTZ.Entidades.Contrato_Transporte
        oContratoSIL = New SOLMIN_CTZ.Entidades.Contrato_SIL
        oContratoAlmacen = New SOLMIN_CTZ.Entidades.Contrato_Almacen
        oContratoAS400Neg = New SOLMIN_CTZ.NEGOCIO.clsContratoAS400

        Ocultar_Datos_Contrato()
        Llenar_Combos()
        Llenar_Filtro_Cliente_Tarifario()
        Cargar_Moneda()
        Cargar_IGV()
        Cargar_Negocios()
        Cargar_Plantas()
        Cargar_Ejecutivo()
        Crear_Grilla_Contratos()
        Crear_Grilla_Observaciones()
        Crear_Grilla_Detalle_Contrato()
        Crear_Grilla_Bitacora_Detalle_Contrato()
    End Sub

    Private Sub Ocultar_Datos_Contrato()
        Me.KryptonHeaderGroup2.Visible = False
        Me.KryptonHeaderGroup5.Visible = False
        Me.KryptonHeaderGroup6.Visible = False
        Me.KryptonHeaderGroup16.Visible = False
    End Sub

    Private Sub Mostrar_Datos_Contrato()
        Me.KryptonHeaderGroup2.Visible = True
        Me.KryptonHeaderGroup5.Visible = True
        Me.KryptonHeaderGroup16.Visible = True
    End Sub

    Private Sub Cargar_Ejecutivo()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oEjecutivoSIL.Crea_Lista()
            cmbEjecutivoAddSil.DataSource = oEjecutivoSIL.Lista
            cmbEjecutivoAddSil.DisplayMember = "TEJCT"
            cmbEjecutivoAddSil.ValueMember = "CEJCT"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_IGV()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oIGV.Crea_Lista()
            cmbIGVAddAlm.DataSource = oIGV.Lista
            cmbIGVAddAlm.DisplayMember = "TIPO"
            cmbIGVAddAlm.ValueMember = "CTIGVA"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Plantas()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.cmbPlantaAddSil.DataSource = oPlanta.Lista_Planta(oUsuario.Compania, Me.cmbNegocio.SelectedValue)
            cmbPlantaAddSil.DisplayMember = "TPLNTA"
            cmbPlantaAddSil.ValueMember = "CPLNDV"
            cmbPlantaAddSil.SelectedIndex = 0
            Me.cmbPlantaAddTra.DataSource = oPlanta.Lista_Planta(oUsuario.Compania, Me.cmbNegocio.SelectedValue)
            cmbPlantaAddTra.DisplayMember = "TPLNTA"
            cmbPlantaAddTra.ValueMember = "CPLNDV"
            cmbPlantaAddTra.SelectedIndex = 0
            Me.cmbPlantaAddTraFact.DataSource = oPlanta.Lista_Planta(oUsuario.Compania, Me.cmbNegocio.SelectedValue)
            cmbPlantaAddTraFact.DisplayMember = "TPLNTA"
            cmbPlantaAddTraFact.ValueMember = "CPLNDV"
            cmbPlantaAddTraFact.SelectedIndex = 0
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Negocios()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            cmbNegocio.DataSource = oDivision.Lista_Division(oUsuario.Compania)
            cmbNegocio.ValueMember = "CDVSN"
            cmbNegocio.DisplayMember = "TCMPDV"
            cmbNegocio.SelectedValue = Me.oUsuario.Division
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Moneda()
        oMoneda.Crea_Moneda()
        cmbMonedaSel.DataSource = oMoneda.Lista_Moneda
        cmbMonedaSel.ValueMember = "CMNDA1"
        cmbMonedaSel.DisplayMember = "TMNDA"

        cmbMonedaAddAlm.DataSource = oMoneda.Lista_Moneda(1)
        cmbMonedaAddAlm.ValueMember = "CMNDA1"
        cmbMonedaAddAlm.DisplayMember = "TMNDA"

        cmbMonedaAddTra.DataSource = oMoneda.Lista_Moneda(1)
        cmbMonedaAddTra.ValueMember = "CMNDA1"
        cmbMonedaAddTra.DisplayMember = "TMNDA"

    End Sub

    Private Sub Llenar_Combos()
        cmbCliente.DataSource = oCliente.Lista_Cliente(-1).Copy
        cmbCliente.ValueMember = "NRCTCL"
        cmbCliente.DisplayMember = "NOMCAR"

        oEstado.Estado_Contrato()
        cmbEstado.DataSource = oEstado.Tabla
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "0"

        oTarifarioNeg.Lista_Tarifario()

        oPlanta.Crea_Lista()

        oTipoProducto.Tipo_Almacen()
        cmbTipoProdAddAlm.DataSource = oTipoProducto.Tabla
        cmbTipoProdAddAlm.ValueMember = "COD"
        cmbTipoProdAddAlm.DisplayMember = "TEX"

        oTipoDeposito.Tipo_Almacen()
        cmbTipoDepAddAlm.DataSource = oTipoDeposito.Tabla
        cmbTipoDepAddAlm.ValueMember = "COD"
        cmbTipoDepAddAlm.DisplayMember = "TEX"
    End Sub

    Private Sub Llenar_Filtro_Cliente_Tarifario()
        cmbClienteSel.DataSource = oCliente.Lista_Cliente_Unico(Me.cmbCliente.SelectedValue)
        cmbClienteSel.ValueMember = "NRCTCL"
        cmbClienteSel.DisplayMember = "NOMCAR"
        cmbClienteSel.SelectedValue = Me.cmbCliente.SelectedValue
    End Sub

#Region "Crear Grilla Bitacora"

    Private Sub Crear_Grilla_Observaciones()
        Dim oDcTx As DataGridViewColumn
        Dim oDcFc As CalendarColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRITOC"
        oDcTx.HeaderText = "NRITOC"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgObservaciones.Columns.Add(oDcTx)

        oDcFc = New CalendarColumn
        oDcFc.Name = "TFCOBS"
        oDcFc.HeaderText = "Fecha"
        oDcFc.Width = 70
        oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dtgObservaciones.Columns.Add(oDcFc)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOBS"
        oDcTx.HeaderText = "Observaciones"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 500
        oDcTx.ReadOnly = False
        Me.dtgObservaciones.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Crear Grilla Bitacora Detalle Contrato"

    Private Sub Crear_Grilla_Bitacora_Detalle_Contrato()
        Dim oDcTx As DataGridViewColumn
        Dim oDcFc As CalendarColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRITEM"
        oDcTx.HeaderText = "NRITEM"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgObsDetalleCont.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRITOC"
        oDcTx.HeaderText = "NRITOC"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgObsDetalleCont.Columns.Add(oDcTx)

        oDcFc = New CalendarColumn
        oDcFc.Name = "TFCOBS"
        oDcFc.HeaderText = "Fecha"
        oDcFc.Width = 70
        oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dtgObsDetalleCont.Columns.Add(oDcFc)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOBS"
        oDcTx.HeaderText = "Observaciones"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 500
        oDcTx.ReadOnly = False
        Me.dtgObsDetalleCont.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Crear Grilla Contratos"

    Private Sub Crear_Grilla_Contratos()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRCTSL"
        oDcTx.HeaderText = "NRCTSL"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgContratos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCNTRT"
        oDcTx.HeaderText = "Contrato"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgContratos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TCNCTO"
        oDcTx.HeaderText = "Contacto"
        oDcTx.Resizable = DataGridViewTriState.True
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 200
        oDcTx.ReadOnly = True
        Me.dtgContratos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "FECINI"
        oDcTx.HeaderText = "Inicio Vigencia"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgContratos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "FECFIN"
        oDcTx.HeaderText = "Fin Vigencia"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgContratos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOBS"
        oDcTx.HeaderText = "Bitácora"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 500
        oDcTx.ReadOnly = True
        Me.dtgContratos.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Crear Grilla Detalle Contrato"

    Private Sub Crear_Grilla_Detalle_Contrato()
        Dim oDcTx As DataGridViewColumn
        Dim oDcFc As CalendarColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRTFSV"
        oDcTx.HeaderText = "NRTFSV"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRITEM"
        oDcTx.HeaderText = "NRITEM"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NEGOCIO"
        oDcTx.HeaderText = "Negocio"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "RUBRO"
        oDcTx.HeaderText = "Rubro"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SERVICIO"
        oDcTx.HeaderText = "Servicio"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "RANGO"
        oDcTx.HeaderText = "Rango"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcFc = New CalendarColumn
        oDcFc.Name = "FECINI"
        oDcFc.HeaderText = "Inicio Vigencia"
        oDcFc.Width = 100
        oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dtgServicios.Columns.Add(oDcFc)

        oDcFc = New CalendarColumn
        oDcFc.Name = "FECFIN"
        oDcFc.HeaderText = "Fin Vigencia"
        oDcFc.Width = 90
        oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dtgServicios.Columns.Add(oDcFc)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONEDA"
        oDcTx.HeaderText = "Moneda"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TARIFA"
        oDcTx.HeaderText = "Tarifa"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        Me.dtgServicios.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOBS"
        oDcTx.HeaderText = "Bitácora"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDcTx.Width = 500
        oDcTx.ReadOnly = True
        Me.dtgServicios.Columns.Add(oDcTx)

    End Sub

#End Region

#Region "Buscar Contrato"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Ocultar_Datos_Contrato()
        Ocultar_Detalle_AS400()
        Cargar_Clientes_Grupo()
        Limpiar_Paneles()
        Buscar_Contrato()
        Llenar_Observaciones()
        Llenar_Filtro_Cliente_Tarifario()
    End Sub

    Private Sub Llenar_Observaciones()
        Dim oDtObs As DataTable
        Dim intCont As Integer
        Dim strDato As String

        oDtObs = oContratoNeg.Lista_Observacion_Cliente(oContrato)
        For intCont = 0 To Me.dtgContratos.Rows.Count - 1
            strDato = Buscar_Observaciones(oDtObs, Me.dtgContratos.Rows(intCont).Cells(0).Value)
            dtgContratos.Rows(intCont).Cells(5).Value = strDato
        Next intCont
    End Sub

    Private Function Buscar_Observaciones(ByVal poDt As DataTable, ByVal pdblContrato As Double) As String
        Dim strCadena As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow

        oDr = poDt.Select("NRCTSL=" & pdblContrato)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                If oDr(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                    strCadena = strCadena & oDr(intCont).Item("TFCOBS").ToString.Trim & "  " & oDr(intCont).Item("TOBS").ToString.Trim.Replace(Chr(10), Chr(10) & "                 ")
                    If intCont < oDr.Length - 1 Then
                        strCadena = strCadena & Chr(10)
                    End If
                End If
            Next intCont
        End If
        Return strCadena
    End Function

    Private Sub Buscar_Contrato()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oContrato.NRCTCL = cmbCliente.SelectedValue
            oContrato.NCNTRT = txtContrato.Text.Trim
            oContrato.CCMPN = oUsuario.Compania
            oContrato.CDVSN = oUsuario.Division
            oContrato.CPLNDV = 1
            If Me.cmbEstado.Text = "TODOS" Then
                oContrato.SESTRG = ""
            Else
                oContrato.SESTRG = cmbEstado.SelectedValue
            End If
            oContratoNeg.Buscar_Contrato(oContrato)
            Limpiar_Controles()
            Llenar_Controles()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Controles()
        Me.tvwContrato.Nodes(0).Nodes.Clear()
        Me.dtgContratos.Rows.Clear()
    End Sub

    Private Sub Limpiar_Paneles()
        Limpiar_Datos_Contrato()
        Limpiar_Observaciones()
        Limpiar_Detalles_Contrato()
        Limpiar_Panel_Transporte()
        Limpiar_Panel_SIL()
        Limpiar_Panel_Almacen()
        Limpiar_Arbol_Detalle()
    End Sub

    Private Sub Limpiar_Detalles_Contrato()
        Me.dtgServicios.Rows.Clear()
    End Sub

    Private Sub Limpiar_Observaciones()
        Me.dtgObservaciones.Rows.Clear()
    End Sub

    Private Sub Limpiar_Datos_Contrato()
        Me.txtDatNumContrato.Text = ""
        Me.mskDatFechaContrato.Text = ""
        Me.txtDatDescContrato.Text = ""
        Me.txtDatObsContrato.Text = ""
        Me.txtDatContContrato.Text = ""
        Me.txtDatCorreoContrato.Text = ""
        Me.txtDatTelContrato.Text = ""
        Me.mskDatIniContrato.Text = ""
        Me.mskDatFinContrato.Text = ""
    End Sub

    Private Sub Llenar_Controles()
        Llenar_Arbol()
        Llenar_Grilla_Contrato()
    End Sub

    Private Sub Llenar_Grilla_Contrato()
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        Dim strContacto As String

        With oContratoNeg.Lista_Contratos
            For intCont = 0 To .Rows.Count - 1
                strContacto = ""
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgContratos)
                oDrVw.Cells(0).Value = .Rows(intCont).Item("NRCTSL").ToString.Trim
                oDrVw.Cells(1).Value = .Rows(intCont).Item("NCNTRT").ToString.Trim
                strContacto = .Rows(intCont).Item("TCNCTO").ToString.Trim & Chr(10) & .Rows(intCont).Item("TMACTO").ToString.Trim & Chr(10) & .Rows(intCont).Item("NTLCTO").ToString.Trim
                oDrVw.Cells(2).Value = strContacto
                oDrVw.Cells(3).Value = .Rows(intCont).Item("FECINI").ToString.Trim
                oDrVw.Cells(4).Value = .Rows(intCont).Item("FECFIN").ToString.Trim
                oDrVw.Cells(5).Value = ""
                Me.dtgContratos.Rows.Add(oDrVw)
            Next intCont
        End With

    End Sub

    Private Sub Llenar_Arbol()
        Dim tndNodo As TreeNode
        Dim intCont As Integer

        With oContratoNeg.Lista_Contratos
            For intCont = 0 To .Rows.Count - 1
                Dim obj(1) As Object
                obj(0) = .Rows(intCont).Item("NRCTSL").ToString.Trim
                obj(1) = .Rows(intCont).Item("SESTRG").ToString.Trim
                Select Case .Rows(intCont).Item("SESTRG").ToString.Trim
                    Case "P" 'Cotizacion
                        tndNodo = New TreeNode(.Rows(intCont).Item("NCNTRT").ToString.Trim, 4, 5)
                    Case "A" 'Vigente
                        tndNodo = New TreeNode(.Rows(intCont).Item("NCNTRT").ToString.Trim, 0, 1)
                    Case "C" 'Vencido
                        tndNodo = New TreeNode(.Rows(intCont).Item("NCNTRT").ToString.Trim, 7, 8)
                    Case "R" 'Anulado, Rechazado
                        tndNodo = New TreeNode(.Rows(intCont).Item("NCNTRT").ToString.Trim, 2, 3)
                End Select
                tndNodo.Tag = obj
                Me.tvwContrato.Nodes(0).Nodes.Add(tndNodo)
            Next intCont
        End With
        Me.tvwContrato.SelectedNode = Me.tvwContrato.Nodes(0)
        Me.tvwContrato.Nodes(0).Expand()
    End Sub

#End Region

#Region "Agregar Contrato"

    Private Sub tvwContrato_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwContrato.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.ctmContrato.Items(0).Visible = False
            Me.ctmContrato.Items(1).Visible = False
            Me.ctmContrato.Items(2).Visible = False
            Me.ctmContrato.Items(3).Visible = False
            If Me.tvwContrato.SelectedNode.Name = "Raiz" Then
                Me.ctmContrato.Items(0).Visible = True
            Else
                Select Case Me.tvwContrato.SelectedNode.Tag(1)
                    Case "P"
                        Me.ctmContrato.Items(1).Visible = True
                        Me.ctmContrato.Items(3).Visible = True
                    Case "A"
                        Me.ctmContrato.Items(2).Visible = True
                        Me.ctmContrato.Items(3).Visible = True
                End Select
            End If
        Else
            If e.Button = Windows.Forms.MouseButtons.Left Then
                If e.Node.Name <> "Raiz" Then
                    Mostrar_Datos_Contrato()
                    Limpiar_Paneles()
                    oContrato.NRCTSL = e.Node.Tag(0)
                    oContrato.SESTRG = e.Node.Tag(1)
                    Cargar_Datos_Contrato()
                    Llenar_Observaciones_Contrato()
                    Cargar_Detalle_Contrato()
                    Llenar_Bitacora_Detalle_Contrato()
                    If oContrato.SESTRG <> "P" Then
                        Mostrar_Detalle_AS400()
                        Carga_Detalle_Negocio_Contrato()
                    Else
                        Ocultar_Detalle_AS400()
                    End If
                Else
                    Ocultar_Datos_Contrato()
                    Ocultar_Detalle_AS400()
                    Limpiar_Paneles()
                End If
            End If
        End If
    End Sub

    Private Sub Mostrar_Detalle_AS400()
        Me.KryptonHeaderGroup6.Visible = True
    End Sub

    Private Sub Ocultar_Detalle_AS400()
        Me.KryptonHeaderGroup6.Visible = False
    End Sub

    Private Sub tsmAddContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddContrato.Click
        Mostrar_Panel_Nuevo_Contrato()
    End Sub

    Private Sub Grabar_Nuevo_Contrato()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oContrato.CCMPN = oUsuario.Compania
            oContrato.CDVSN = oUsuario.Division
            oContrato.CPLNDV = 1
            oContrato.NRCTCL = Me.cmbCliente.SelectedValue
            oContrato.NCNTRT = Me.txtNumContrato.Text.Trim
            oContratoNeg.Crear_Contrato(oContrato)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox("Se agregó un nuevo contrato correctamente")
            Ocultar_Panel_Nuevo_Contrato()
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarContrato.Click
        Grabar_Nuevo_Contrato()
        Buscar_Contrato()
    End Sub

    Private Sub btnCancelarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarContrato.Click
        Ocultar_Panel_Nuevo_Contrato()
    End Sub

    Private Sub Ocultar_Panel_Nuevo_Contrato()
        Me.KryptonHeaderGroup17.Collapsed = True
        Me.KryptonHeaderGroup17.Visible = False
    End Sub

    Private Sub Mostrar_Panel_Nuevo_Contrato()
        Me.KryptonHeaderGroup17.Visible = True
        Me.KryptonHeaderGroup17.Collapsed = False
    End Sub

#End Region

#Region "Estado de Contrato"

    Private Sub tsmAceptarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAceptarContrato.Click
        Actualizar_Estado_Contrato("A")
        Buscar_Contrato()
        Ocultar_Datos_Contrato()
        Ocultar_Detalle_AS400()
        Limpiar_Paneles()
    End Sub

    Private Sub tsmCerrarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCerrarContrato.Click
        Actualizar_Estado_Contrato("C")
        Buscar_Contrato()
    End Sub

    Private Sub tsmAnularContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAnularContrato.Click
        Actualizar_Estado_Contrato("R")
        Buscar_Contrato()
    End Sub

    Private Sub Actualizar_Estado_Contrato(ByVal pstrEstado As String)
        Try
            Dim strCadena As String = ""

            oContrato.NRCTSL = Me.tvwContrato.SelectedNode.Tag(0)
            Select Case pstrEstado
                Case "A"
                    strCadena = "Esta seguro de cambiar a estado Activo el contrato : " & Me.tvwContrato.SelectedNode.Text.Trim & " ?"
                    oContrato.SESTRG = "A"
                Case "C"
                    strCadena = "Esta seguro de cambiar a estado Vencido el contrato : " & Me.tvwContrato.SelectedNode.Text.Trim & " ?"
                    oContrato.SESTRG = "C"
                Case "R"
                    strCadena = "Esta seguro de cambiar a estado Anulado el contrato : " & Me.tvwContrato.SelectedNode.Text.Trim & " ?"
                    oContrato.SESTRG = "R"
            End Select
            If HelpClass.RspMsgBox(strCadena) = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oContratoNeg.Actualizar_Estado_Contrato(oContrato)
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Actualizar Información del contrato"

    Private Sub btnGrabarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarDatos.Click
        If Me.tvwContrato.SelectedNode.Name <> "Raiz" Then
            Actualizar_Informacion_Contrato()
            Actualizar_Grilla(2) '2 - Datos del Contrato
        Else
            HelpClass.MsgBox("Debe seleccionar un contrato")
        End If
    End Sub

    Private Sub Actualizar_Informacion_Contrato()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oContrato.NCNTRT = Me.txtDatNumContrato.Text.Trim
            oContrato.TCNCTO = Me.txtDatContContrato.Text.Trim
            oContrato.TMACTO = Me.txtDatCorreoContrato.Text.Trim
            oContrato.NTLCTO = Me.txtDatTelContrato.Text.Trim
            If Me.mskDatIniContrato.Text.Trim = "/  /" Then
                oContrato.FECINI = 0
            Else
                oContrato.FECINI = Format(CType(Me.mskDatIniContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            If Me.mskDatFinContrato.Text.Trim = "/  /" Then
                oContrato.FECFIN = 0
            Else
                oContrato.FECFIN = Format(CType(Me.mskDatFinContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            oContrato.DESCTR = Me.txtDatDescContrato.Text.Trim
            oContrato.TOBS = Me.txtDatObsContrato.Text.Trim
            oContratoNeg.Actualizar_Datos_Contrato(oContrato)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Datos de Contrato"

    Private Sub Cargar_Datos_Contrato()
        Try
            Dim oDt As DataTable

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oDt = oContratoNeg.Cargar_Datos_Contrato(oContrato)
            Me.txtDatNumContrato.Text = oDt.Rows(0).Item("NCNTRT").ToString.Trim
            Me.mskDatFechaContrato.Text = oDt.Rows(0).Item("FCHCRT").ToString.Trim
            Me.txtDatDescContrato.Text = oDt.Rows(0).Item("DESCTR").ToString.Trim
            Me.txtDatObsContrato.Text = oDt.Rows(0).Item("TOBS").ToString.Trim
            Me.txtDatContContrato.Text = oDt.Rows(0).Item("TCNCTO").ToString.Trim
            Me.txtDatCorreoContrato.Text = oDt.Rows(0).Item("TMACTO").ToString.Trim
            Me.txtDatTelContrato.Text = oDt.Rows(0).Item("NTLCTO").ToString.Trim
            Me.mskDatIniContrato.Text = oDt.Rows(0).Item("FECINI").ToString.Trim
            Me.mskDatFinContrato.Text = oDt.Rows(0).Item("FECFIN").ToString.Trim
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Observaciones de Contrato"

    Private Sub btnAgregarObs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarObs.Click
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgObservaciones)
        Me.dtgObservaciones.Rows.Add(oDrVw)
    End Sub

    Private Sub btnGrabarObs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarObs.Click
        Grabar_Observaciones_Contrato()
    End Sub

    Private Sub dtgObservaciones_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgObservaciones.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            CType(e.Control, TextBox).MaxLength = 250
        End If
    End Sub

    Private Sub Grabar_Observaciones_Contrato()
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.dtgObservaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            oSqlMan.TransactionController(TransactionType.Manual)
            oSqlMan.BeginGlobalTransaction()
            oContratoNeg.Eliminar_Observaciones(oSqlMan, oContrato)
            oBitacora_Contrato.NRCTSL = oContrato.NRCTSL
            With Me.dtgObservaciones
                For intCont = 0 To .Rows.Count - 1
                    If (Not .Rows(intCont).Cells("TFCOBS").Value = Nothing) And (Not .Rows(intCont).Cells("TOBS").Value = Nothing) Then
                        oBitacora_Contrato.NRITOC = intCont + 1
                        oBitacora_Contrato.TFCOBS = Format(CType(.Rows(intCont).Cells("TFCOBS").Value, Date), "yyyyMMdd")
                        oBitacora_Contrato.TOBS = .Rows(intCont).Cells("TOBS").Value.ToString.Trim
                        oContratoNeg.Grabar_Observacion(oSqlMan, oBitacora_Contrato)
                    End If
                Next intCont
            End With
            oSqlMan.CommitGlobalTransaction()
            Actualizar_Grilla(1) '1 - Observaciones del Contrato
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub

    Private Sub Actualizar_Grilla(ByVal pintTipo As Integer)
        Dim intCont As Integer
        Dim intIndice As Integer

        Select Case pintTipo
            Case 1
                Dim strObs As String = vbNullString
                For intCont = 0 To Me.dtgContratos.Rows.Count - 1
                    If Double.Parse(Me.dtgContratos.Rows(intCont).Cells("NRCTSL").Value.ToString.Trim) = oContrato.NRCTSL Then
                        With Me.dtgContratos.Rows(intCont)
                            For intIndice = 0 To Me.dtgObservaciones.Rows.Count - 1
                                If intIndice > 0 Then
                                    strObs = strObs & Chr(10)
                                End If
                                strObs = strObs & Me.dtgObservaciones.Rows(intIndice).Cells(1).Value & "  " & Me.dtgObservaciones.Rows(intIndice).Cells(2).Value.ToString.Trim.Replace(Chr(10), Chr(10) & "                 ")
                            Next intIndice
                            .Cells("TOBS").Value = strObs
                        End With
                        Exit For
                    End If
                Next intCont
            Case 2
                Dim strContacto As String = ""
                For intCont = 0 To Me.dtgContratos.Rows.Count - 1
                    If Double.Parse(Me.dtgContratos.Rows(intCont).Cells("NRCTSL").Value.ToString.Trim) = oContrato.NRCTSL Then
                        With Me.dtgContratos.Rows(intCont)
                            .Cells("NCNTRT").Value = txtDatNumContrato.Text.Trim
                            strContacto = Me.txtDatContContrato.Text.Trim & Chr(10) & Me.txtDatCorreoContrato.Text.Trim & Chr(10) & Me.txtDatTelContrato.Text.Trim
                            .Cells("TCNCTO").Value = strContacto
                            If mskDatIniContrato.Text.Trim <> "/  /" Then
                                .Cells("FECINI").Value = mskDatIniContrato.Text
                            Else
                                .Cells("FECINI").Value = ""
                            End If
                            If mskDatFinContrato.Text.Trim <> "/  /" Then
                                .Cells("FECFIN").Value = mskDatFinContrato.Text
                            Else
                                .Cells("FECFIN").Value = ""
                            End If
                        End With
                        Exit For
                    End If
                Next intCont
        End Select
    End Sub

    Private Sub Llenar_Observaciones_Contrato()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim oDr() As DataRow
        Dim intCont As Integer

        oDt = oContratoNeg.Lista_Observacion_Cliente(oContrato)
        oDr = oDt.Select("NRCTSL=" & oContrato.NRCTSL)

        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                If oDr(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgObservaciones)
                    oDrVw.Cells(0).Value = oDr(intCont).Item("NRITOC").ToString.Trim
                    oDrVw.Cells(1).Value = oDr(intCont).Item("TFCOBS").ToString.Trim
                    oDrVw.Cells(2).Value = oDr(intCont).Item("TOBS").ToString.Trim
                    Me.dtgObservaciones.Rows.Add(oDrVw)
                End If
            Next intCont
        End If
    End Sub

    Private Sub tsmDelObs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelObs.Click
        Quitar_Observacion()
    End Sub

    Private Sub Quitar_Observacion()
        If Me.dtgObservaciones.SelectedRows.Count > 0 Then
            Me.dtgObservaciones.Rows.RemoveAt(Me.dtgObservaciones.SelectedRows(0).Index)
        End If
    End Sub

#End Region

#Region "Detalle de Contrato"

    Private Sub Cargar_Detalle_Contrato()
        Try
            Dim oDt As DataTable
            Dim intCont As Integer

            Me.Cursor = System.Windows.Forms.Cursors.Default
            oDetContratoNeg.Busca_Detalle_Contrato(oContrato)
            oDt = oDetContratoNeg.Lista_Detalle_Contrato
            For intCont = 0 To oDt.Rows.Count - 1
                Agregar_Detalle_Contrato()
                With Me.dtgServicios
                    .Rows(intCont).Cells(0).Value = oDt.Rows(intCont).Item("NRTFSV").ToString.Trim
                    .Rows(intCont).Cells(1).Value = oDt.Rows(intCont).Item("NRITEM").ToString.Trim
                    .Rows(intCont).Cells(2).Value = oDt.Rows(intCont).Item("TCMPDV").ToString.Trim
                    .Rows(intCont).Cells(3).Value = oDt.Rows(intCont).Item("NOMRUB").ToString.Trim
                    .Rows(intCont).Cells(4).Value = oDt.Rows(intCont).Item("NOMSER").ToString.Trim
                    .Rows(intCont).Cells(5).Value = oDt.Rows(intCont).Item("DESRNG").ToString.Trim
                    .Rows(intCont).Cells(6).Value = oDt.Rows(intCont).Item("FECINI").ToString.Trim
                    .Rows(intCont).Cells(7).Value = oDt.Rows(intCont).Item("FECFIN").ToString.Trim
                    .Rows(intCont).Cells(8).Value = oDt.Rows(intCont).Item("TSGNMN").ToString.Trim
                    .Rows(intCont).Cells(9).Value = oDt.Rows(intCont).Item("IVLSRV").ToString.Trim
                    .Rows(intCont).Cells(10).Value = ""
                End With
            Next intCont
            Me.Cursor = System.Windows.Forms.Cursors.Hand
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Agregar_Detalle_Contrato()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgServicios)
        Me.dtgServicios.Rows.Add(oDrVw)
    End Sub

    Private Sub Deshabilitar_Servicios()
        Me.dtgServicios.Enabled = False
    End Sub

    Private Sub Habilitar_Servicios()
        Me.dtgServicios.Enabled = True
    End Sub

#End Region

#Region "Panel Agregar Detalle de Contrato"

    Private Sub btnAgregarObsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarObsDet.Click
        Deshabilitar_Servicios()
        Limpiar_Tarifas()
        Mostrar_Panel_Agregar()
        Achicar_Grilla_Detalle()
    End Sub

    Private Sub Achicar_Grilla_Detalle()
        Me.dtgServicios.Height = 67
    End Sub

    Private Sub Agrandar_Grilla_Detalle()
        Me.dtgServicios.Height = 257
    End Sub

    Private Sub Mostrar_Panel_Agregar()
        Me.KryptonHeaderGroup7.Collapsed = False
        Me.KryptonHeaderGroup7.Visible = True
    End Sub

    Private Sub btnCancelarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDetalle.Click
        Agrandar_Grilla_Detalle()
        Habilitar_Servicios()
        Ocultar_Panel_Agregar()
    End Sub

    Private Sub btnGrabarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarDetalle.Click
        Habilitar_Servicios()
        Grabar_Nuevo_Detalle_Contrato()
        Ocultar_Panel_Agregar()
        Limpiar_Detalles_Contrato()
        Cargar_Detalle_Contrato()
        Agrandar_Grilla_Detalle()
    End Sub

    Private Sub Ocultar_Panel_Agregar()
        Me.KryptonHeaderGroup7.Visible = False
        Me.KryptonHeaderGroup7.Collapsed = True
    End Sub

    Private Sub Grabar_Nuevo_Detalle_Contrato()
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            If Me.lsvServicios.CheckedItems.Count > 0 Then
                If HelpClass.RspMsgBox("Está seguro de agregar los servicios seleccionados?") = Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    oDetContrato.NRCTSL = oContrato.NRCTSL
                    oSqlMan.TransactionController(TransactionType.Manual)
                    oSqlMan.BeginGlobalTransaction()
                    For intCont = 0 To Me.lsvServicios.CheckedItems.Count - 1
                        oDetContrato.NRTFSV = Me.lsvServicios.CheckedItems(intCont).SubItems(6).Text.Trim
                        oDetContratoNeg.Agregar_Detalle_Contrato(oSqlMan, oDetContrato)
                    Next intCont
                    oSqlMan.CommitGlobalTransaction()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    HelpClass.MsgBox("Se agregaron los servicios correctamente")
                End If
            Else
                HelpClass.MsgBox("Debe seleccionar algún servicios")
            End If
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub

#End Region

#Region "Observaciones Detalle Contrato"

    Private Sub btnAddObsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddObsDet.Click
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgObsDetalleCont)
        Me.dtgObsDetalleCont.Rows.Add(oDrVw)
    End Sub

    Private Sub btnCancelObsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelObsDet.Click
        Habilitar_Servicios()
        Ocultar_Panel_Bitacora_Detalle()
    End Sub

    Private Sub Ocultar_Panel_Bitacora_Detalle()
        Me.KryptonHeaderGroup3.Visible = False
        Me.KryptonHeaderGroup3.Collapsed = True
    End Sub

    Private Sub Mostrar_Panel_Bitacora_Detalle()
        Me.KryptonHeaderGroup3.Collapsed = False
        Me.KryptonHeaderGroup3.Visible = True
    End Sub

    Private Sub btnGrabarObsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarObsDet.Click
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.dtgObsDetalleCont.CommitEdit(DataGridViewDataErrorContexts.Commit)
            oSqlMan.TransactionController(TransactionType.Manual)
            oSqlMan.BeginGlobalTransaction()
            oDetContratoNeg.Eliminar_Observaciones(oSqlMan, oBitacoraDet)
            With Me.dtgObsDetalleCont
                For intCont = 0 To .Rows.Count - 1
                    If (Not .Rows(intCont).Cells("TFCOBS").Value = Nothing) And (Not .Rows(intCont).Cells("TOBS").Value = Nothing) Then
                        oBitacoraDet.NRITOC = intCont + 1
                        oBitacoraDet.TFCOBS = Format(CType(.Rows(intCont).Cells("TFCOBS").Value, Date), "yyyyMMdd")
                        oBitacoraDet.TOBS = .Rows(intCont).Cells("TOBS").Value.ToString.Trim
                        oDetContratoNeg.Grabar_Observacion(oSqlMan, oBitacoraDet)
                    End If
                Next intCont
            End With
            oSqlMan.CommitGlobalTransaction()
            Ocultar_Panel_Bitacora_Detalle()
            Actualizar_Grilla_Detalle(1) '1 - Observaciones del Contrato
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
            Habilitar_Servicios()
        End Try
    End Sub

    Private Sub Actualizar_Grilla_Detalle(ByVal pintTipo As Integer)
        Dim intCont As Integer
        Dim intIndice As Integer

        Select Case pintTipo
            Case 1
                Dim strObs As String = vbNullString
                For intCont = 0 To Me.dtgServicios.Rows.Count - 1
                    If Double.Parse(Me.dtgServicios.Rows(intCont).Cells("NRITEM").Value.ToString.Trim) = oBitacoraDet.NRITEM Then
                        With Me.dtgServicios.Rows(intCont)
                            For intIndice = 0 To Me.dtgObsDetalleCont.Rows.Count - 1
                                If intIndice > 0 Then
                                    strObs = strObs & Chr(10)
                                End If
                                strObs = strObs & Me.dtgObsDetalleCont.Rows(intIndice).Cells(2).Value & "  " & Me.dtgObsDetalleCont.Rows(intIndice).Cells(3).Value.ToString.Trim.Replace(Chr(10), Chr(10) & "                 ")
                            Next intIndice
                            .Cells("TOBS").Value = strObs
                        End With
                        Exit For
                    End If
                Next intCont
        End Select
    End Sub

    Private Sub Llenar_Observaciones_Detalle_Contrato()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim oDr() As DataRow
        Dim intCont As Integer

        oDt = oDetContratoNeg.Lista_Observacion_Det_Contrato(oContrato)
        oDr = oDt.Select("NRITEM=" & oBitacoraDet.NRITEM)

        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                If oDr(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgObsDetalleCont)
                    oDrVw.Cells(0).Value = oDr(intCont).Item("NRITEM").ToString.Trim
                    oDrVw.Cells(1).Value = oDr(intCont).Item("NRITOC").ToString.Trim
                    oDrVw.Cells(2).Value = oDr(intCont).Item("TFCOBS").ToString.Trim
                    oDrVw.Cells(3).Value = oDr(intCont).Item("TOBS").ToString.Trim
                    Me.dtgObsDetalleCont.Rows.Add(oDrVw)
                End If
            Next intCont
        End If
    End Sub

    Private Sub Llenar_Bitacora_Detalle_Contrato()
        Dim oDtObs As DataTable
        Dim intCont As Integer
        Dim strDato As String

        oDtObs = oDetContratoNeg.Lista_Observacion_Det_Contrato(oContrato)
        For intCont = 0 To Me.dtgServicios.Rows.Count - 1
            strDato = Buscar_Observaciones_Detalle_Contrato(oDtObs, Me.dtgServicios.Rows(intCont).Cells(1).Value)
            dtgServicios.Rows(intCont).Cells(10).Value = strDato
        Next intCont
    End Sub

    Private Function Buscar_Observaciones_Detalle_Contrato(ByVal poDt As DataTable, ByVal pdblItem As Double) As String
        Dim strCadena As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow

        oDr = poDt.Select("NRITEM=" & pdblItem)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                If oDr(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                    strCadena = strCadena & oDr(intCont).Item("TFCOBS").ToString.Trim & "  " & oDr(intCont).Item("TOBS").ToString.Trim.Replace(Chr(10), Chr(10) & "                 ")
                    If intCont < oDr.Length - 1 Then
                        strCadena = strCadena & Chr(10)
                    End If
                End If
            Next intCont
        End If
        Return strCadena
    End Function

    Private Sub Quitar_Observacion_Detalle_Contrato()
        If Me.dtgObsDetalleCont.SelectedRows.Count > 0 Then
            Me.dtgObsDetalleCont.Rows.RemoveAt(Me.dtgObsDetalleCont.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub tsmDelObsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelObsDet.Click
        Quitar_Observacion_Detalle_Contrato()
    End Sub

    Private Sub tsmEditObsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEditObsDet.Click
        Deshabilitar_Servicios()
        Limpiar_Observaciones_Detalle_Contrato()
        oBitacoraDet.NRCTSL = oContrato.NRCTSL
        oBitacoraDet.NRITEM = Double.Parse(dtgServicios.SelectedRows(0).Cells(1).Value)
        Llenar_Observaciones_Detalle_Contrato()
        Mostrar_Panel_Bitacora_Detalle()
    End Sub

    Private Sub Limpiar_Observaciones_Detalle_Contrato()
        Me.dtgObsDetalleCont.Rows.Clear()
    End Sub

#End Region

#Region "Buscar Servicio"

    Private Sub btnBuscarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarServicio.Click
        Limpiar_Tarifas()
        Buscar_Servicio()
    End Sub

    Private Sub Limpiar_Tarifas()
        Me.lsvServicios.Items.Clear()
    End Sub

    Private Sub Buscar_Servicio()
        Dim strFiltro As String


        strFiltro = Buscar_Tarifario()
        If strFiltro = vbNullString Then
            HelpClass.MsgBox("No existe tarifario definido para esta combinación")
        Else
            Buscar_Tarifa_Servicio(strFiltro)
        End If
    End Sub

    Private Function Buscar_Tarifario() As String
        oFiltro.Parametro1 = Me.cmbClienteSel.SelectedValue
        If Me.cmbMonedaSel.SelectedValue = "0" Then
            oFiltro.Parametro2 = ""
        Else
            oFiltro.Parametro2 = Me.cmbMonedaSel.SelectedValue
        End If
        Return oTarifarioNeg.Buscar_Tarifario(oFiltro)
    End Function

    Private Sub Buscar_Tarifa_Servicio(ByVal pstrFiltro As String)
        Try
            Dim oDt As DataTable
            Dim intCont As Integer
            Dim lsvRow As ListViewItem

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.lsvServicios.View = View.Details
            Me.lsvServicios.GridLines = True
            oFiltro.Parametro1 = oUsuario.Compania
            oFiltro.Parametro2 = pstrFiltro
            oFiltro.Parametro3 = UCase(Me.txtServicioSel.Text.Trim)
            oFiltro.Parametro4 = ""
            oFiltro.Parametro5 = Me.tvwContrato.SelectedNode.Tag(0)
            oDt = oTarifaNeg.Buscar_Tarifa_Faltante(oFiltro)
            For intCont = 0 To oDt.Rows.Count - 1
                lsvRow = New ListViewItem(oDt.Rows(intCont).Item("TCMPDV").ToString.Trim, 0)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("NOMRUB").ToString.Trim)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("NOMSER").ToString.Trim)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("DESRNG").ToString.Trim)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("TSGNMN").ToString.Trim)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("IVLSRV").ToString.Trim)
                lsvRow.SubItems.Add(oDt.Rows(intCont).Item("NRTFSV").ToString.Trim)
                lsvServicios.Items.Add(lsvRow)
            Next intCont
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtServicioSel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServicioSel.KeyPress
        If e.KeyChar = Chr(13) Then
            Buscar_Servicio()
        End If
    End Sub

#End Region

#Region "Quitar Detalle de Contrato"

    Private Sub tsmDelDetContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelDetContrato.Click
        Quitar_Detalle_Contrato()
        Limpiar_Detalles_Contrato()
        Cargar_Detalle_Contrato()
    End Sub

    Private Sub Quitar_Detalle_Contrato()
        Try
            If HelpClass.RspMsgBox("Está seguro de eliminar el detalle seleccionado?") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oDetContrato.NRCTSL = oContrato.NRCTSL
                oDetContrato.NRITEM = Double.Parse(dtgServicios.SelectedRows(0).Cells(1).Value)
                oDetContratoNeg.Quitar_Detalle_Contrato(oDetContrato)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Detalle eliminado correctamente")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Actualizar Vigencia del Detalle"

    Private Sub dtgServicios_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtgServicios.CellBeginEdit
        oDetContrato.NRITEM = Double.Parse(Me.dtgServicios.CurrentRow.Cells(1).Value)
    End Sub

    Private Sub dtgServicios_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgServicios.CellEndEdit
        If Me.dtgServicios.CurrentCell.Value <> vbNullString Then
            Actualizar_Vigencia()
        End If
    End Sub

    Private Sub Actualizar_Vigencia()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oDetContrato.NRCTSL = oContrato.NRCTSL
            If Me.dtgServicios.CurrentRow.Cells(6).Value = vbNullString Then
                oDetContrato.FECINI = 0
            Else
                oDetContrato.FECINI = Format(CType(Me.dtgServicios.CurrentRow.Cells(6).Value, Date), "yyyyMMdd")
            End If
            If Me.dtgServicios.CurrentRow.Cells(7).Value = vbNullString Then
                oDetContrato.FECFIN = 0
            Else
                oDetContrato.FECFIN = Format(CType(Me.dtgServicios.CurrentRow.Cells(7).Value, Date), "yyyyMMdd")
            End If
            oDetContratoNeg.Actualizar_Vigencia_Detalle_Contrato(oDetContrato)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub btnAddDetContratado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDetContratado.Click
        Select Case Me.cmbNegocio.SelectedValue
            Case "R"
                Mostrar_Panel_Add_Det_Almacen()
            Case "S"
                Mostrar_Panel_Add_Det_SIL()
            Case "T"
                Mostrar_Panel_Add_Det_Transporte()
        End Select
    End Sub

    Private Sub Cargar_Clientes_Grupo()
        Me.cmbClienteAddTra.DataSource = oCliente.Lista_Cliente_Grupo(Me.cmbCliente.SelectedValue)
        cmbClienteAddTra.ValueMember = "CCLNT"
        cmbClienteAddTra.DisplayMember = "TCMPCL"

        Me.cmbClienteAddSil.DataSource = oCliente.Lista_Cliente_Grupo(Me.cmbCliente.SelectedValue)
        cmbClienteAddSil.ValueMember = "CCLNT"
        cmbClienteAddSil.DisplayMember = "TCMPCL"

        Me.cmbClienteAddAlm.DataSource = oCliente.Lista_Cliente_Grupo(Me.cmbCliente.SelectedValue)
        cmbClienteAddAlm.ValueMember = "CCLNT"
        cmbClienteAddAlm.DisplayMember = "TCMPCL"
    End Sub

    Private Sub Mostrar_Panel_Add_Det_Almacen()
        Me.KryptonHeaderGroup10.Collapsed = False
        Me.KryptonHeaderGroup10.Visible = True
    End Sub

    Private Sub Mostrar_Panel_Add_Det_SIL()
        Me.KryptonHeaderGroup11.Collapsed = False
        Me.KryptonHeaderGroup11.Visible = True
    End Sub

    Private Sub Mostrar_Panel_Add_Det_Transporte()
        Me.KryptonHeaderGroup9.Collapsed = False
        Me.KryptonHeaderGroup9.Visible = True
    End Sub

    Private Sub Ocultar_Panel_Add_Det_Almacen()
        Me.KryptonHeaderGroup10.Visible = False
        Me.KryptonHeaderGroup10.Collapsed = True
    End Sub

    Private Sub Ocultar_Panel_Add_Det_SIL()
        Me.KryptonHeaderGroup11.Visible = False
        Me.KryptonHeaderGroup11.Collapsed = True
    End Sub

    Private Sub Ocultar_Panel_Add_Det_Transporte()
        Me.KryptonHeaderGroup9.Visible = False
        Me.KryptonHeaderGroup9.Collapsed = True
    End Sub

    Private Sub btnCancelarSIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarSIL.Click
        Ocultar_Panel_Add_Det_SIL()
        Limpiar_Panel_SIL()
    End Sub

    Private Sub btnCancelarAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarAlmacen.Click
        Ocultar_Panel_Add_Det_Almacen()
        Limpiar_Panel_Almacen()
    End Sub

    Private Sub btnCancelarTransp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTransp.Click
        Ocultar_Panel_Add_Det_Transporte()
        Limpiar_Panel_Transporte()
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        If Me.KryptonHeaderGroup2.Collapsed Then
            Mostrar_Botones_Datos_Contrato()
        Else
            Ocultar_Botones_Datos_Contrato()
        End If
    End Sub

    Private Sub ButtonSpecHeaderGroup14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup14.Click
        If Me.KryptonHeaderGroup16.Collapsed Then
            Mostrar_Botones_Bitacora()
        Else
            Ocultar_Botones_Bitacora()
        End If
    End Sub

    Private Sub ButtonSpecHeaderGroup6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup6.Click
        If Me.KryptonHeaderGroup5.Collapsed Then
            Mostrar_Botones_Detalle_Contrato()
        Else
            Ocultar_Botones_Detalle_Contrato()
        End If
    End Sub

    Private Sub Ocultar_Botones_Datos_Contrato()
        Me.KryptonHeaderGroup2.ButtonSpecs(0).Visible = False
    End Sub

    Private Sub Mostrar_Botones_Datos_Contrato()
        Me.KryptonHeaderGroup2.ButtonSpecs(0).Visible = True
    End Sub

    Private Sub Ocultar_Botones_Bitacora()
        Me.KryptonHeaderGroup16.ButtonSpecs(0).Visible = False
        Me.KryptonHeaderGroup16.ButtonSpecs(1).Visible = False
    End Sub

    Private Sub Mostrar_Botones_Bitacora()
        Me.KryptonHeaderGroup16.ButtonSpecs(0).Visible = True
        Me.KryptonHeaderGroup16.ButtonSpecs(1).Visible = True
    End Sub

    Private Sub Ocultar_Botones_Detalle_Contrato()
        Me.KryptonHeaderGroup5.ButtonSpecs(0).Visible = False
        Me.KryptonHeaderGroup5.ButtonSpecs(1).Visible = False
    End Sub

    Private Sub Mostrar_Botones_Detalle_Contrato()
        Me.KryptonHeaderGroup5.ButtonSpecs(0).Visible = True
        Me.KryptonHeaderGroup5.ButtonSpecs(1).Visible = True
    End Sub

    Private Sub btnGrabarTransp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarTransp.Click
        Crear_Contrato_Transporte()
        Ocultar_Panel_Add_Det_Transporte()
        Limpiar_Panel_Transporte()
        Carga_Detalle_Negocio_Contrato()
    End Sub

    Private Sub Crear_Contrato_Transporte()
        Try
            If HelpClass.RspMsgBox("Está seguro de grabar un detalle en transporte") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oContratoTransporte.CCMPN = oUsuario.Compania
                oContratoTransporte.CDVSN = cmbNegocio.SelectedValue
                oContratoTransporte.CCLNT = cmbClienteAddTra.SelectedValue
                oContratoTransporte.NCNTRT = Me.tvwContrato.SelectedNode.Tag(0)
                oContratoTransporte.TDRGDA = txtDirigidoAddTra.Text.Trim
                oContratoTransporte.TCARGO = txtCargoAddTra.Text.Trim
                oContratoTransporte.TCNCLC = txtContactoAddTra.Text.Trim
                oContratoTransporte.CPLNDV = cmbPlantaAddTra.SelectedValue
                oContratoTransporte.CPLNFC = cmbPlantaAddTraFact.SelectedValue
                oContratoTransporte.CMNDA = cmbMonedaAddTra.SelectedValue
                If chbSerAfecAddTra.Checked Then
                    oContratoTransporte.SFSANF = 1
                Else
                    oContratoTransporte.SFSANF = 0
                End If
                If chbFleteAddTra.Checked Then
                    oContratoTransporte.SFLZNP = "N"
                Else
                    oContratoTransporte.SFLZNP = ""
                End If
                If rdbRemitenteAddTra.Checked Then
                    oContratoTransporte.SCBRMD = "R"
                Else
                    oContratoTransporte.SCBRMD = "D"
                End If
                oContratoTransporte.NTRMCR = ""
                If Trim(Me.mskFecFinVigAddTrp.Text) <> "/  /" Then
                    oContratoTransporte.FVGCTZ = Format(CType(Me.mskFecFinVigAddTrp.Text, Date), "yyyyMMdd")
                Else
                    oContratoTransporte.FVGCTZ = 0
                End If
                oContratoAS400Neg.Crear_Contrato_Transporte(oContratoTransporte)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se grabó correctamente")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Panel_Transporte()
        cmbClienteAddTra.SelectedIndex = 0
        txtDirigidoAddTra.Text = vbNullString
        txtCargoAddTra.Text = vbNullString
        txtContactoAddTra.Text = vbNullString
        mskFecFinVigAddTrp.Text = "  /  /    "
        cmbPlantaAddTra.SelectedIndex = 0
        cmbPlantaAddTraFact.SelectedIndex = 0
        cmbMonedaAddTra.SelectedIndex = 0
        chbSerAfecAddTra.Checked = True
        chbFleteAddTra.Checked = False
        rdbDestinaAddTra.Checked = True
    End Sub

    Private Sub Carga_Detalle_Negocio_Contrato()
        Limpiar_Arbol_Detalle()
        Cargar_Det_Transporte()
        Cargar_Det_SIL()
        Cargar_Det_Almacen()
        Me.tvwDetContrato.ExpandAll()
    End Sub

    Private Sub Limpiar_Arbol_Detalle()
        Me.tvwDetContrato.Nodes(0).Nodes.Clear()
    End Sub

    Private Sub Cargar_Det_Transporte()
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim tndNodo As TreeNode
        Dim tndNodoH As TreeNode
        Dim NewObj(1) As Object
        Dim strCadena As String
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oDt = oContratoAS400Neg.Lista_Contrato_Transporte(oContrato)
            If oDt.Rows.Count > 0 Then
                NewObj(0) = "T"
                NewObj(1) = ""
                tndNodo = New TreeNode("Transporte", 11, 11)
                tndNodo.Tag = NewObj
                For intCont = 0 To oDt.Rows.Count - 1
                    Dim obj(12) As Object
                    obj(0) = "T"
                    obj(1) = oDt.Rows(intCont).Item("NCTZCN").ToString.Trim
                    obj(2) = oDt.Rows(intCont).Item("CCLNT").ToString.Trim
                    obj(3) = oDt.Rows(intCont).Item("TDRGDA").ToString.Trim
                    obj(4) = oDt.Rows(intCont).Item("TCARGO").ToString.Trim
                    obj(5) = oDt.Rows(intCont).Item("TCNCLC").ToString.Trim
                    obj(6) = oDt.Rows(intCont).Item("CPLNDV").ToString.Trim
                    obj(7) = oDt.Rows(intCont).Item("CPLNFC").ToString.Trim
                    obj(8) = oDt.Rows(intCont).Item("CMNDA").ToString.Trim
                    obj(9) = oDt.Rows(intCont).Item("FECFIN").ToString.Trim
                    obj(10) = oDt.Rows(intCont).Item("SFSANF").ToString.Trim
                    obj(11) = oDt.Rows(intCont).Item("SFLZNP").ToString.Trim
                    obj(12) = oDt.Rows(intCont).Item("SCBRMD").ToString.Trim
                    strCadena = "Contrato: " & oDt.Rows(intCont).Item("NCTZCN").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Cliente: " & oDt.Rows(intCont).Item("TCMPCL").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Dirigido a: " & oDt.Rows(intCont).Item("TDRGDA").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Cargo: " & oDt.Rows(intCont).Item("TCARGO").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Contacto: " & oDt.Rows(intCont).Item("TCNCLC").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Planta: " & oDt.Rows(intCont).Item("PLTDIV").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Planta de Facturación: " & oDt.Rows(intCont).Item("PLTFAC").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Moneda: " & oDt.Rows(intCont).Item("TMNDA").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Fin Vigencia: " & oDt.Rows(intCont).Item("FECFIN").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Servicio Afecto: " & oDt.Rows(intCont).Item("AFECTO").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Flete Zona Primaria: " & oDt.Rows(intCont).Item("ZONA").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Cobranza: " & oDt.Rows(intCont).Item("COBRAR").ToString.Trim
                    tndNodoH = New TreeNode(oDt.Rows(intCont).Item("NCTZCN").ToString.Trim, 11, 11)
                    tndNodoH.Tag = obj
                    tndNodoH.ToolTipText = strCadena
                    Cargar_Detalles_Transporte(tndNodoH, tndNodoH.Tag(1).ToString)
                    tndNodo.Nodes.Add(tndNodoH)
                Next intCont
                tvwDetContrato.Nodes(0).Nodes.Add(tndNodo)
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Detalles_Transporte(ByRef pobjNodo As TreeNode, ByVal pstrContrato As String)
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim oNodo As TreeNode

        oFiltro.Parametro1 = pstrContrato
        oDt = oDetContratoNeg.Lista_Detalle_Contrato_AS400_TRP(oFiltro)
        For intCont = 0 To oDt.Rows.Count - 1
            Dim obj(1) As Object
            oNodo = New TreeNode(oDt.Rows(intCont).Item("TCMRCD").ToString.Trim, 11, 11)
            obj(1) = "V"
            oNodo.Tag = obj
            pobjNodo.Nodes.Add(oNodo)
        Next intCont
    End Sub

    Private Sub btnGrabarSIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarSIL.Click
        Crear_Contrato_SIL()
        Ocultar_Panel_Add_Det_SIL()
        Limpiar_Panel_SIL()
        Carga_Detalle_Negocio_Contrato()
    End Sub

    Private Sub Crear_Contrato_SIL()
        Try
            If HelpClass.RspMsgBox("Está seguro de grabar un detalle para el Sil") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oContratoSIL.CCMPN = oUsuario.Compania
                oContratoSIL.CDVSN = cmbNegocio.SelectedValue
                oContratoSIL.CCLNT = cmbClienteAddSil.SelectedValue
                oContratoSIL.CPLNDV = cmbPlantaAddTra.SelectedValue
                oContratoSIL.TRFSRC = Me.tvwContrato.SelectedNode.Tag(0)
                oContratoSIL.TCNCLC = txtContactoAddSil.Text.Trim
                oContratoSIL.CEJCT = Me.cmbEjecutivoAddSil.SelectedValue
                If rdbFijoAddSil.Checked Then
                    oContratoSIL.SFRMFC = "A"
                Else
                    If rdbVariadoAddSil.Checked Then
                        oContratoSIL.SFRMFC = "B"
                    Else
                        oContratoSIL.SFRMFC = "C"
                    End If
                End If
                If rdbMensualAddSil.Checked Then
                    oContratoSIL.PERFAC = "M"
                Else
                    If rdbDiarioAddSil.Checked Then
                        oContratoSIL.PERFAC = "D"
                    Else
                        oContratoSIL.PERFAC = "U"
                    End If
                End If
                If Trim(Me.mskFecFinVigAddSil.Text) <> "/  /" Then
                    oContratoSIL.FVGNCT = Format(CType(Me.mskFecFinVigAddSil.Text, Date), "yyyyMMdd")
                Else
                    oContratoSIL.FVGNCT = 0
                End If
                oContratoAS400Neg.Crear_Contrato_SIL(oContratoSIL)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se grabó correctamente")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Panel_SIL()
        rdbDiarioAddSil.Checked = True
        rdbVariadoAddSil.Checked = True
        cmbPlantaAddSil.SelectedIndex = 0
        cmbEjecutivoAddSil.SelectedIndex = 0
        txtContactoAddSil.Text = ""
        mskFecFinVigAddSil.Text = "  /  /    "
    End Sub

    Private Sub Cargar_Det_SIL()
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim tndNodo As TreeNode
        Dim tndNodoH As TreeNode
        Dim NewObj(1) As Object
        Dim strCadena As String
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oDt = oContratoAS400Neg.Lista_Contrato_SIL(oContrato)
            If oDt.Rows.Count > 0 Then
                NewObj(0) = "S"
                NewObj(1) = ""
                tndNodo = New TreeNode("SIL", 10, 10)
                tndNodo.Tag = NewObj
                For intCont = 0 To oDt.Rows.Count - 1
                    Dim obj(8) As Object
                    obj(0) = "S"
                    obj(1) = oDt.Rows(intCont).Item("NCTZCN").ToString.Trim
                    obj(2) = oDt.Rows(intCont).Item("CCLNT").ToString.Trim
                    obj(3) = oDt.Rows(intCont).Item("TCNCLC").ToString.Trim
                    obj(4) = oDt.Rows(intCont).Item("CEJCT").ToString.Trim
                    obj(5) = oDt.Rows(intCont).Item("CPLNDV").ToString.Trim
                    obj(6) = oDt.Rows(intCont).Item("FECFIN").ToString.Trim
                    obj(7) = oDt.Rows(intCont).Item("SFRMFC").ToString.Trim
                    obj(8) = oDt.Rows(intCont).Item("PERFAC").ToString.Trim
                    strCadena = "Contrato: " & oDt.Rows(intCont).Item("NCTZCN").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Cliente: " & oDt.Rows(intCont).Item("TCMPCL").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Contacto: " & oDt.Rows(intCont).Item("TCNCLC").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Ejecutivo: " & oDt.Rows(intCont).Item("TEJCT").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Planta: " & oDt.Rows(intCont).Item("TPLNTA").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Fin Vigencia: " & oDt.Rows(intCont).Item("FECFIN").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Clase: " & oDt.Rows(intCont).Item("CLASE").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Periodo de Facturación: " & oDt.Rows(intCont).Item("PERIODO").ToString.Trim
                    tndNodoH = New TreeNode(oDt.Rows(intCont).Item("NCTZCN").ToString.Trim, 10, 10)
                    tndNodoH.Tag = obj
                    tndNodoH.ToolTipText = strCadena
                    Cargar_Detalles_SIL(tndNodoH, tndNodoH.Tag(1).ToString)
                    tndNodo.Nodes.Add(tndNodoH)
                Next intCont
                tvwDetContrato.Nodes(0).Nodes.Add(tndNodo)
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Detalles_SIL(ByRef pobjNodo As TreeNode, ByVal pstrContrato As String)
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim oNodo As TreeNode

        oFiltro.Parametro1 = pstrContrato
        oDt = oDetContratoNeg.Lista_Detalle_Contrato_AS400_SIL(oFiltro)
        For intCont = 0 To oDt.Rows.Count - 1
            Dim obj(1) As Object
            oNodo = New TreeNode(oDt.Rows(intCont).Item("TRFSRC").ToString.Trim, 10, 10)
            obj(1) = "D"
            oNodo.Tag = obj
            pobjNodo.Nodes.Add(oNodo)
        Next intCont
    End Sub

    Private Sub btnGrabarAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarAlmacen.Click
        Crear_Contrato_Almacen()
        Ocultar_Panel_Add_Det_Almacen()
        Limpiar_Panel_Almacen()
        Carga_Detalle_Negocio_Contrato()
    End Sub

    Private Sub Crear_Contrato_Almacen()
        Try
            If HelpClass.RspMsgBox("Está seguro de grabar un detalle para el Almacén") = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oContratoAlmacen.CCLNT1 = cmbClienteAddAlm.SelectedValue
                oContratoAlmacen.NCNTRF = Me.tvwContrato.SelectedNode.Tag(0)
                If cmbTipoProdAddAlm.SelectedValue <> "0" Then
                    oContratoAlmacen.CTPPR1 = cmbTipoProdAddAlm.SelectedValue
                Else
                    oContratoAlmacen.CTPPR1 = ""
                End If
                oContratoAlmacen.CTIGVA = cmbIGVAddAlm.SelectedValue
                oContratoAlmacen.CMNDA1 = cmbMonedaAddAlm.SelectedValue
                oContratoAlmacen.CTPDP3 = cmbTipoDepAddAlm.SelectedValue
                If Trim(Me.mskFecFinVigAddAlm.Text) <> "/  /" Then
                    oContratoAlmacen.FTRMCN = Format(CType(Me.mskFecFinVigAddAlm.Text, Date), "yyyyMMdd")
                Else
                    oContratoAlmacen.FTRMCN = 0
                End If
                oContratoAS400Neg.Crear_Contrato_Almacen(oContratoAlmacen)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se grabó correctamente")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Panel_Almacen()
        cmbTipoProdAddAlm.SelectedIndex = 0
        cmbIGVAddAlm.SelectedIndex = 0
        cmbMonedaAddAlm.SelectedIndex = 0
        cmbTipoDepAddAlm.SelectedIndex = 0
        mskFecFinVigAddAlm.Text = "  /  /    "
    End Sub

    Private Sub Cargar_Det_Almacen()
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim tndNodo As TreeNode
        Dim tndNodoH As TreeNode
        Dim NewObj(1) As Object
        Dim strCadena As String
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oDt = oContratoAS400Neg.Lista_Contrato_Almacen(oContrato)
            If oDt.Rows.Count > 0 Then
                NewObj(0) = "R"
                NewObj(1) = ""
                tndNodo = New TreeNode("Almacen", 12, 12)
                tndNodo.Tag = NewObj
                For intCont = 0 To oDt.Rows.Count - 1
                    Dim obj(7) As Object
                    obj(0) = "R"
                    obj(1) = oDt.Rows(intCont).Item("NCNTR").ToString.Trim
                    obj(2) = oDt.Rows(intCont).Item("CCLNT1").ToString.Trim
                    obj(3) = oDt.Rows(intCont).Item("CTPDP3").ToString.Trim
                    obj(4) = oDt.Rows(intCont).Item("CTIGVA").ToString.Trim
                    obj(5) = oDt.Rows(intCont).Item("CTPPR1").ToString.Trim
                    obj(6) = oDt.Rows(intCont).Item("CMNDA1").ToString.Trim
                    obj(7) = oDt.Rows(intCont).Item("FECFIN").ToString.Trim
                    strCadena = "Contrato: " & oDt.Rows(intCont).Item("NCNTR").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Cliente: " & oDt.Rows(intCont).Item("TCMPCL").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Tipo Deposito: " & oDt.Rows(intCont).Item("TDEPO").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Tipo IGV: " & oDt.Rows(intCont).Item("TIGV").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Tipo Producto: " & oDt.Rows(intCont).Item("TPROD").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Moneda: " & oDt.Rows(intCont).Item("TMNDA").ToString.Trim & vbCrLf
                    strCadena = strCadena & "Fin Vigencia: " & oDt.Rows(intCont).Item("FECFIN").ToString.Trim
                    tndNodoH = New TreeNode(oDt.Rows(intCont).Item("NCNTR").ToString.Trim, 12, 12)
                    tndNodoH.Tag = obj
                    tndNodoH.ToolTipText = strCadena
                    Cargar_Mercaderias(tndNodoH, tndNodoH.Tag(1).ToString)
                    tndNodo.Nodes.Add(tndNodoH)
                Next intCont
                tvwDetContrato.Nodes(0).Nodes.Add(tndNodo)
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Mercaderias(ByRef pobjNodo As TreeNode, ByVal pstrContrato As String)
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim oNodo As TreeNode

        oFiltro.Parametro1 = pstrContrato
        oDt = oDetContratoNeg.Lista_Detalle_Contrato_AS400_ALM(oFiltro)
        For intCont = 0 To oDt.Rows.Count - 1
            Dim obj(1) As Object
            oNodo = New TreeNode(oDt.Rows(intCont).Item("TCMPMR").ToString.Trim, 12, 12)
            obj(1) = "M"
            oNodo.Tag = obj
            pobjNodo.Nodes.Add(oNodo)
        Next intCont
    End Sub

    Private Sub tsmEditDetContAS400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEditDetContAS400.Click
        Cargar_Información_AS400()
    End Sub

    Private Sub Cargar_Información_AS400()
        Select Case Me.tvwDetContrato.SelectedNode.Tag(0)
            Case "R"
                Limpiar_Panel_Almacen()
                Me.cmbClienteAddAlm.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(2)
                Me.cmbMonedaAddAlm.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(6)
                Me.cmbIGVAddAlm.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(4)
                Me.cmbTipoDepAddAlm.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(3)
                Me.cmbTipoProdAddAlm.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(5)
                Me.mskFecFinVigAddAlm.Text = Me.tvwDetContrato.SelectedNode.Tag(7)
                Mostrar_Panel_Add_Det_Almacen()
            Case "S"
                Limpiar_Panel_SIL()
                Me.cmbClienteAddSil.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(2)
                Me.txtContactoAddSil.Text = Me.tvwDetContrato.SelectedNode.Tag(3)
                Me.cmbEjecutivoAddSil.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(4)
                Me.cmbPlantaAddSil.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(5)
                Me.mskFecFinVigAddSil.Text = Me.tvwDetContrato.SelectedNode.Tag(6)
                If Me.tvwDetContrato.SelectedNode.Tag(7) = "A" Then
                    Me.rdbFijoAddSil.Checked = True
                Else
                    If Me.tvwDetContrato.SelectedNode.Tag(7) = "B" Then
                        Me.rdbVariadoAddSil.Checked = True
                    Else
                        If Me.tvwDetContrato.SelectedNode.Tag(7) = "C" Then
                            Me.rdbMixtoAddSil.Checked = True
                        End If
                    End If
                End If
                If Me.tvwDetContrato.SelectedNode.Tag(8) = "M" Then
                    Me.rdbMensualAddSil.Checked = True
                Else
                    If Me.tvwDetContrato.SelectedNode.Tag(8) = "D" Then
                        Me.rdbDiarioAddSil.Checked = True
                    Else
                        If Me.tvwDetContrato.SelectedNode.Tag(8) = "U" Then
                            Me.rdbUnicoAddSil.Checked = True
                        End If
                    End If
                End If
                Mostrar_Panel_Add_Det_SIL()
            Case "T"
                Limpiar_Panel_Transporte()
                Me.cmbClienteAddTra.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(2)
                Me.txtDirigidoAddTra.Text = Me.tvwDetContrato.SelectedNode.Tag(3)
                Me.txtCargoAddTra.Text = Me.tvwDetContrato.SelectedNode.Tag(4)
                Me.txtContactoAddTra.Text = Me.tvwDetContrato.SelectedNode.Tag(5)
                Me.cmbPlantaAddTra.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(6)
                Me.cmbPlantaAddTraFact.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(7)
                Me.cmbMonedaAddTra.SelectedValue = Me.tvwDetContrato.SelectedNode.Tag(8)
                Me.mskFecFinVigAddTrp.Text = Me.tvwDetContrato.SelectedNode.Tag(9)
                If Me.tvwDetContrato.SelectedNode.Tag(10) = "1" Then
                    Me.chbSerAfecAddTra.Checked = True
                Else
                    Me.chbSerAfecAddTra.Checked = False
                End If
                If Me.tvwDetContrato.SelectedNode.Tag(11) = "1" Then
                    Me.chbFleteAddTra.Checked = True
                Else
                    Me.chbFleteAddTra.Checked = False
                End If
                If Me.tvwDetContrato.SelectedNode.Tag(12) = "R" Then
                    Me.rdbRemitenteAddTra.Checked = True
                Else
                    Me.rdbDestinaAddTra.Checked = True
                End If
                Mostrar_Panel_Add_Det_Transporte()
        End Select
    End Sub

    Private Sub tvwDetContrato_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwDetContrato.NodeMouseClick
        Ocultar_Agregar_Detalle_Contrato_AS400()
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cmtDetContAS400.Items(0).Visible = False
            If Me.tvwDetContrato.SelectedNode.Name <> "Raiz" And e.Node.Tag(1).ToString <> "M" And e.Node.Tag(1).ToString <> "V" And e.Node.Tag(1).ToString <> "D" Then
                If Me.tvwDetContrato.SelectedNode.Tag(1).ToString <> "" Then
                    Me.cmtDetContAS400.Items(0).Visible = True
                End If
            End If
        Else
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Limpiar_Grilla_Detalle_AS400()
                If e.Node.Name <> "Raiz" Then
                    If e.Node.Tag(1).ToString <> "" Then
                        If e.Node.Tag(1).ToString <> "M" And e.Node.Tag(1).ToString <> "V" And e.Node.Tag(1).ToString <> "D" Then
                            Select Case e.Node.Tag(0).ToString
                                Case "R"
                                    Mostrar_Grilla_Det_Cont_AS400_ALM(e.Node.Tag(1).ToString)
                                    Mostrar_Agregar_Detalle_Contrato_AS400()
                                Case "S"
                                    Mostrar_Grilla_Det_Cont_AS400_SIL(e.Node.Tag(1).ToString)
                                    Mostrar_Agregar_Detalle_Contrato_AS400()
                                Case "T"
                                    Mostrar_Grilla_Det_Cont_AS400_TRP(e.Node.Tag(1).ToString)
                                    Mostrar_Agregar_Detalle_Contrato_AS400()
                            End Select
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Limpiar_Grilla_Detalle_AS400()
        Me.dtgDetContratoAS400.Rows.Clear()
        Me.dtgDetContratoAS400.Columns.Clear()
    End Sub

    Private Sub Mostrar_Grilla_Det_Cont_AS400_ALM(ByVal pstrContrato As String)
        Crear_Estructura_Almacenes()
        Cargar_Detalle_Contrato_AS400_ALM(pstrContrato)
    End Sub

    Private Sub Mostrar_Grilla_Det_Cont_AS400_SIL(ByVal pstrContrato As String)
        Crear_Estructura_SIL()
        Cargar_Detalle_Contrato_AS400_SIL(pstrContrato)
    End Sub

    Private Sub Mostrar_Grilla_Det_Cont_AS400_TRP(ByVal pstrContrato As String)
        Crear_Estructura_TRP()
        Cargar_Detalle_Contrato_AS400_TRP(pstrContrato)
    End Sub

    Private Sub Crear_Estructura_TRP()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCTZCN"
        oDcTx.HeaderText = "NCTZCN"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCRRCT"
        oDcTx.HeaderText = "N°"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CMRCDR"
        oDcTx.HeaderText = "CMRCDR"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TCMRCD"
        oDcTx.HeaderText = "Mercadería"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "QMRCDR"
        oDcTx.HeaderText = "Cantidad"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NORSRT"
        oDcTx.HeaderText = "O/S"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CTPUNV"
        oDcTx.HeaderText = "Tipo Unidad"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

    End Sub

    Private Sub Crear_Estructura_SIL()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCTZCN"
        oDcTx.HeaderText = "NCTZCN"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCRRAC"
        oDcTx.HeaderText = "N°"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TRFSRC"
        oDcTx.HeaderText = "Referencia del Cliente"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

    End Sub

    Private Sub Cargar_Detalle_Contrato_AS400_TRP(ByVal pstrContrato As String)
        Dim oDt As DataTable
        Dim intCont As Integer

        oFiltro.Parametro1 = pstrContrato
        oDt = oDetContratoNeg.Lista_Detalle_Contrato_AS400_TRP(oFiltro)
        For intCont = 0 To oDt.Rows.Count - 1
            Agregar_Fila_DataGrid()
            dtgDetContratoAS400.Rows(intCont).Cells(0).Value = oDt.Rows(intCont).Item("NCTZCN").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(1).Value = oDt.Rows(intCont).Item("NCRRCT").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(2).Value = oDt.Rows(intCont).Item("CMRCDR").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(3).Value = oDt.Rows(intCont).Item("TCMRCD").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(4).Value = oDt.Rows(intCont).Item("QMRCDR").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(5).Value = oDt.Rows(intCont).Item("NORSRT").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(6).Value = oDt.Rows(intCont).Item("CTPUNV").ToString
        Next intCont
    End Sub

    Private Sub Cargar_Detalle_Contrato_AS400_SIL(ByVal pstrContrato As String)
        Dim oDt As DataTable
        Dim intCont As Integer

        oFiltro.Parametro1 = pstrContrato
        oDt = oDetContratoNeg.Lista_Detalle_Contrato_AS400_SIL(oFiltro)
        For intCont = 0 To oDt.Rows.Count - 1
            Agregar_Fila_DataGrid()
            dtgDetContratoAS400.Rows(intCont).Cells(0).Value = oDt.Rows(intCont).Item("NCTZCN").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(1).Value = oDt.Rows(intCont).Item("NCRRAC").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(2).Value = oDt.Rows(intCont).Item("TRFSRC").ToString
        Next intCont
    End Sub

    Private Sub Cargar_Detalle_Contrato_AS400_ALM(ByVal pstrContrato As String)
        Dim oDt As DataTable
        Dim intCont As Integer

        oFiltro.Parametro1 = pstrContrato
        oDt = oDetContratoNeg.Lista_Detalle_Contrato_AS400_ALM(oFiltro)
        For intCont = 0 To oDt.Rows.Count - 1
            Agregar_Fila_DataGrid()
            dtgDetContratoAS400.Rows(intCont).Cells(0).Value = oDt.Rows(intCont).Item("NCNTR").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(1).Value = oDt.Rows(intCont).Item("NCRCTC").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(2).Value = oDt.Rows(intCont).Item("CMRCD").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(3).Value = oDt.Rows(intCont).Item("TCMPMR").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(4).Value = oDt.Rows(intCont).Item("CTPALM").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(5).Value = oDt.Rows(intCont).Item("CALMC").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(6).Value = oDt.Rows(intCont).Item("CUNCN3").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(7).Value = oDt.Rows(intCont).Item("QMRCD").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(8).Value = oDt.Rows(intCont).Item("CUNPS3").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(9).Value = oDt.Rows(intCont).Item("QPSMR").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(10).Value = oDt.Rows(intCont).Item("CUNVL3").ToString
            dtgDetContratoAS400.Rows(intCont).Cells(11).Value = oDt.Rows(intCont).Item("QVLMR").ToString
        Next intCont
    End Sub

    Private Sub Agregar_Fila_DataGrid()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgDetContratoAS400)
        Me.dtgDetContratoAS400.Rows.Add(oDrVw)
    End Sub

    Private Sub Crear_Estructura_Almacenes()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCNTR"
        oDcTx.HeaderText = "NCNTR"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCRCTC"
        oDcTx.HeaderText = "N°"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CMRCD"
        oDcTx.HeaderText = "CMRCD"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TCMPMR"
        oDcTx.HeaderText = "Mercadería"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CTPALM"
        oDcTx.HeaderText = "Tipo Almacén"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CALMC"
        oDcTx.HeaderText = "Almacén"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CUNCN3"
        oDcTx.HeaderText = "UM"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "QMRCD"
        oDcTx.HeaderText = "Cantidad"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CUNPS3"
        oDcTx.HeaderText = "UM"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "QPSMR"
        oDcTx.HeaderText = "Peso"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CUNVL3"
        oDcTx.HeaderText = "UM"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "QVLMR"
        oDcTx.HeaderText = "Valor"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgDetContratoAS400.Columns.Add(oDcTx)
    End Sub

    Private Sub Ocultar_Agregar_Detalle_Contrato_AS400()
        btnAddDetCont.Visible = False
    End Sub

    Private Sub Mostrar_Agregar_Detalle_Contrato_AS400()
        btnAddDetCont.Visible = True
    End Sub

    Private Sub btnAddDetCont_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddDetCont.Click
        Agregar_Detalle_Contrato_AS400()
    End Sub

    Private Sub Agregar_Detalle_Contrato_AS400()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgDetContratoAS400)
        Me.dtgDetContratoAS400.Rows.Add(oDrVw)
    End Sub

    Private Sub Actualizar_Detalle_Contrato_AS400()
        Select Case Me.tvwDetContrato.SelectedNode.Tag(1)
            Case "R"
                'oContratoAlmacen.
                oContratoAS400Neg.Actualizar_Contrato_Almacen(oContratoAlmacen)
            Case "S"
                oContratoAS400Neg.Actualizar_Contrato_SIL(oContratoSIL)
            Case "T"
                oContratoAS400Neg.Actualizar_Contrato_Transporte(oContratoTransporte)
        End Select
    End Sub
End Class

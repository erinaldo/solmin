'/*------------------------------------------------------------------------------*/
'/*----- Empresa          	: RANSA S.A.                                    -----*/
'/*----- Sistema          	: Solmin                  	                    -----*/
'/*----- Módulo          	: SD-SA-SC                  	     	        -----*/
'/*----- Nombre Programa    : UcServicioAtendido			                -----*/
'/*----- Desarrollado por	: Alann Crispin	                                -----*/
'/*----- Fecha Creación     : 23/05/2011                      	            -----*/
'/*----- Fecha Modificacion : 03/08/2011                      	            -----*/
'/*----- Fecha Modificacion : 26/08/2011                      	            -----*/
'/*----- Descripción        : Control que contiene los                    	-----*/
'/*-----                      servicios por operación                     	-----*/
'/*----- Descripción        : Servicios Especiales y nuevo filtro          	-----*/
'/*----- Descripción        : Nuevas Columnas detalle de servicios y bultos	-----*/
'/*------------------------------------------------------------------------------*/
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Data.Odbc
Imports Newtonsoft
Imports Newtonsoft.Json

Public Class UCServicioAtendido
#Region "Propiedades"
    Private _pUsuario As String = "SOLMIN"
    Public Property pUsuario() As String
        '====Obligatorio====
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pDivision As eDivision = eDivision.Todos
    <Browsable(True)> _
    Public Property pDivision() As eDivision
        '====Obligatorio====
        Get
            Return _pDivision
        End Get
        Set(ByVal value As eDivision)
            _pDivision = value

        End Set
    End Property

    Private _pTipoAlmacen As Comun.eTipoAlmacen = Comun.eTipoAlmacen.NoAplica
    <Browsable(True)> _
    Public Property pTipoAlmacen() As Comun.eTipoAlmacen
        Get
            Return _pTipoAlmacen
        End Get
        Set(ByVal value As Comun.eTipoAlmacen)
            _pTipoAlmacen = value

        End Set
    End Property


    Private _pServicioEstado As Comun.eServicioEstado = Comun.eServicioEstado.Defaults
    <Browsable(True)> _
    Public Property ServicioEstado() As Comun.eServicioEstado
        Get
            Return _pServicioEstado
        End Get
        Set(ByVal value As Comun.eServicioEstado)
            _pServicioEstado = value
        End Set
    End Property

    '<Browsable(False)> _
    'Public Property MostrarBotonFactura() As Boolean
    '    Get
    '        Return btnFacturar.Visible
    '    End Get
    '    Set(ByVal value As Boolean)
    '        btnFacturar.Visible = value
    '    End Set
    'End Property

    Private _pCompaniaActual As String
    Public Property pCompaniaActual() As String
        Get
            Return _pCompaniaActual
        End Get
        Set(ByVal value As String)
            _pCompaniaActual = value
        End Set
    End Property

#End Region
#Region "Atributos"
    Private oEstadoFactura As clsEstadoNeg = New clsEstadoNeg
    Private oEstadoPendiente As clsEstadoNeg = New clsEstadoNeg
    Private oCompania As clsCompaniaNeg = New clsCompaniaNeg
    Private oDivision As clsDivisionNeg = New clsDivisionNeg
    Private oPlanta As clsPlantaNeg = New clsPlantaNeg
    Private oServicioOpeNeg As New clsServicio_BL
    Private oServicio As Servicio_BE
    Private bolBuscar As Boolean
    Dim oDtTiposDocumentos As New DataTable
    Private Estatico As New Estaticos
    Private Marcar As Image
    Private Desmarcar As Image
    Private oDtPlanta As New DataTable
    Public Event Facturar(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
    Private oFacturaNeg As New clsFactura_BL  'CSR-HUNDRED-ESTIMACION-INGRESO
#End Region
#Region "Eventos"
    Public Sub pCargaInicial()

        'oCompania.Crea_Lista(_pUsuario)
        'oDivision.Crea_Lista(_pUsuario)
        oPlanta.Crea_Lista(_pUsuario)

        Marcar = btnMarcarItems.BackgroundImage
        Desmarcar = btnMarcarItems.Image

        btnRevisado.Visible = False

        Carga_Estado()
        'Cargar_Compania()
        'Cargar_Division()
        'Carga_Servicios()
        cargaProceso()
        Cargar_TipoServicio()
        chkFecha.Checked = True
        dtFeFinal.Value = Now
        dtFeInicial.Value = Now.AddDays(1 - CInt(Today.Day.ToString))
        HGDatos.ValuesSecondary.Heading = "Servicios por Facturar" '========Utilizada para totaliza cantidades==========
        '===================== OBtenemos el Tipo de Cambio para el dia de Hoy===================
        Dim oLis As New List(Of String)
        oLis.Add("100")
        oLis.Add(Format(Now, "yyyyMMdd"))
        If oServicioOpeNeg.Lista_Tipo_Cambio(oLis).Rows.Count > 0 Then
            lblTipoCambio_1.Text = oServicioOpeNeg.Lista_Tipo_Cambio(oLis).Rows(0).Item("IVNTA").ToString.Trim
        Else
            lblTipoCambio_1.Text = "0"
        End If

        Select Case _pServicioEstado
            Case Comun.eServicioEstado.Pendiente
                cmbEstadoPendiente.SelectedValue = "N"
                cmbEstadoPendiente.Enabled = False
            Case Comun.eServicioEstado.PorFacturar
                cmbEstadoPendiente.SelectedValue = "S"
                Me.btnEliminar.Visible = False
                Me.btnAgregar.Visible = False
                cmbEstadoPendiente.Enabled = False
        End Select
        cmbEstadoPendiente_SelectionChangeCommitted(cmbEstadoPendiente, Nothing)

        UcCompania.Usuario = _pUsuario
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(pCompaniaActual)

        Me.cmbTipoAlmacenaje_SelectedIndexChanged(Nothing, Nothing)
        Valida_Estados()

        'btnRevisado.Visible = False
    End Sub
#End Region
#Region "Funciones y Procedimientos"
    '=========Codigo Comun para todas las Divisiones============
    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = _pUsuario

        UcDivision.pActualizar()
    End Sub

    Private Sub Cargar_Planta()
        Try
            Dim oDtAux As New DataTable
            Dim oDr As DataRow

            oDtAux.Columns.Add("CPLNDV", GetType(String))
            oDtAux.Columns.Add("TPLNTA", GetType(String))

            If bolBuscar Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                bolBuscar = False

                oDtPlanta = oPlanta.Lista_Planta_Division(UcCompania.CCMPN_CodigoCompania, UcDivision.Division)
                For Each dr As DataRow In oDtPlanta.Rows
                    oDr = oDtAux.NewRow
                    oDr("CPLNDV") = dr("CPLNDV")
                    oDr("TPLNTA") = dr("TPLNTA")
                    oDtAux.Rows.Add(oDr)
                Next
                oDtPlanta = oDtAux
                cmbPlanta.ValueMember = "CPLNDV"
                bolBuscar = True
                cmbPlanta.DisplayMember = "TPLNTA"
                cmbPlanta.DataSource = oDtPlanta
                For i As Integer = 0 To cmbPlanta.Items.Count - 1
                    If cmbPlanta.Items.Item(i).Value = "0" Then
                        cmbPlanta.SetItemChecked(i, True)
                    End If
                Next
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function Lista_Tipo_Planta() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                If (oDtPlanta.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtPlanta.Rows(j).Item("CPLNDV") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub Carga_Estado()
        oEstadoFactura.Estado_Servicio()
        bolBuscar = False
        cmbEstadoFactura.DataSource = oEstadoFactura.Tabla
        cmbEstadoFactura.ValueMember = "COD"
        bolBuscar = True
        cmbEstadoFactura.DisplayMember = "TEX"
        cmbEstadoFactura.SelectedValue = "N"

        oEstadoPendiente.Estado_Pendiente()
        bolBuscar = False
        cmbEstadoPendiente.DataSource = oEstadoPendiente.Tabla
        cmbEstadoPendiente.ValueMember = "COD"
        bolBuscar = True
        cmbEstadoPendiente.DisplayMember = "TEX"
        cmbEstadoPendiente.SelectedValue = "N"
    End Sub
    Private Sub cargaProceso()
        Dim oServicioBL As New clsServicio_BL
        oDtTiposDocumentos = oServicioBL.Listar_TablaAyuda_L01("TIPROC")
        '------------------------------------------------------------------
        cmbProceso.ValueMember = "SMARCA"
        cmbProceso.DisplayMember = "TDSDES"
        cmbProceso.DataSource = oDtTiposDocumentos
        For i As Integer = 0 To cmbProceso.Items.Count - 1
            If cmbProceso.Items.Item(i).Value = "0" Then
                cmbProceso.SetItemChecked(i, True)
            End If
        Next
    End Sub
    'Private Sub Carga_Servicios()
    '    oServicio = New Servicio_BE
    '    oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
    '    oServicio.CDVSN = UcDivision.Division
    '    oServicio.CCLNT = UcCliente.pCodigo
    '    bolBuscar = False
    '    cmbServicio.DataSource = oServicioOpeNeg.Lista_Servicios_Activos(oServicio)
    '    cmbServicio.ValueMember = "NRTFSV"
    '    bolBuscar = True
    '    cmbServicio.DisplayMember = "DESTAR"
    '    cmbServicio.SelectedValue = 0


    'End Sub

    Private Sub Cargar_TipoServicio()
        '====Cargamos tipo de Almacenaje====
        bolBuscar = False
        'Try
        Me.cmbTipoAlmacenaje.DataSource = oServicioOpeNeg.ListaTipoAlmacenaje(UcDivision.Division)


        Me.cmbTipoAlmacenaje.ValueMember = "COD"
        Me.cmbTipoAlmacenaje.DisplayMember = "VAL"
        If pTipoAlmacen <> "0" Then
            If pTipoAlmacen <> Comun.eTipoAlmacen.AlmTransito Then
                If pTipoAlmacen = Comun.eTipoAlmacen.DepSimple Then
                    cmbTipoAlmacenaje.SelectedValue = "1"
                Else
                    cmbTipoAlmacenaje.SelectedValue = "5"
                End If
                cmbTipoServicio.Enabled = True
            End If
            cmbTipoAlmacenaje.Enabled = False
        Else
            cmbTipoServicio.Enabled = True
        End If
        '===Carga los Servicios Especiales===
        Dim oDtProceso As New DataTable
        'If UcDivision.Division <> "T" Then

        If UcDivision.Division Is Nothing Then
            Exit Sub
        End If

        oDtProceso = oServicioOpeNeg.ListaServiciosEsp(UcDivision.Division, 1)
        oDtProceso.DefaultView.RowFilter = "SMARCA NOT IN (4)"
        oDtProceso = oDtProceso.DefaultView.ToTable
        Me.cmbTipoServicio.DataSource = oDtProceso
        Me.cmbTipoServicio.ValueMember = "CCMPRN"
        Me.cmbTipoServicio.SelectedValue = "0"
        bolBuscar = True
        Me.cmbTipoServicio.DisplayMember = "TDSDES"

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmbTipoAlmacenaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoAlmacenaje.SelectedIndexChanged
        If bolBuscar Then
            If cmbTipoAlmacenaje.SelectedValue = "1" Then
                cmbTipoServicio.Enabled = False
                cmbTipoServicio.SelectedValue = Estatico.E_ESP_General
            Else
                cmbTipoServicio.Enabled = True
            End If
        End If
    End Sub


    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        Try


            Limpiar_Grilla_Servicio()
            Limpiar_Detalle_Servicios()
            InhabilitaTabs()
            InhabilitaBotones(UcDivision.Division)
            HabilitaTabs(UcDivision.Division)
            'Carga_Servicios()
            Cargar_Planta()
            Cargar_TipoServicio()
        Catch : End Try
    End Sub

    Private Sub cmbEstadoPendiente_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoPendiente.SelectionChangeCommitted
        If bolBuscar Then
            Valida_Estados()
            Limpiar_Grilla_Servicio()
            Limpiar_Detalle_Servicios()
        End If
    End Sub

    Private Sub cmbEstadoFactura_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoFactura.SelectionChangeCommitted
        If bolBuscar Then
            Valida_Estados()
            Limpiar_Grilla_Servicio()
            Limpiar_Detalle_Servicios()
        End If
    End Sub

    Private Sub InhabilitaTabs()
        Me.TabDetalles.TabPages.Remove(TabBulto)
        Me.TabDetalles.TabPages.Remove(TabEmbarque)
        Me.TabDetalles.TabPages.Remove(TabMercaderia)
        Me.TabDetalles.TabPages.Remove(TabReembolso)
    End Sub
    Private Sub HabilitaTabs(ByVal pstrDivision As String, Optional ByVal tAlm As Integer = 0, Optional ByVal tCTPALJ As String = "")
        Dim iValida As String
        iValida = _pTipoAlmacen
        If iValida = 0 Then iValida = tAlm 'En caso de ser generico utiliza el tipo de la celda     
        If tCTPALJ <> Estatico.E_ESP_General Then iValida = tCTPALJ '"GE"
        Select Case pstrDivision
            Case "S"
                Me.TabDetalles.TabPages.Add(TabEmbarque)
            Case "R"
                Select Case iValida
                    Case Comun.eTipoAlmacen.AlmTransito, Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_Almacenaje '"AL"
                        Me.TabDetalles.TabPages.Add(TabBulto)
                    Case Estatico.E_ESP_PesoPromedio
                        '====================================================================
                        '======================EL TAB CON LOS PROMEDIOS======================
                        '====================================================================
                    Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple
                        Me.TabDetalles.TabPages.Add(TabMercaderia)
                    Case Estatico.E_ESP_Reembolso  'Comun.ESP_Reembolso '"RE"
                        Me.TabDetalles.TabPages.Add(TabReembolso)
                End Select
        End Select
    End Sub
    Private Sub InhabilitaBotones(ByVal pstrDivision As String)
        btnAgregarDetalle.Visible = False
        Select Case pstrDivision

            Case "R"
                btnImprimir.Visible = False

                '==============combo proceso solo para almacen=========
                cmbProceso.Visible = True
                lblProceso.Visible = True
                '======================================================
                HabilitaBotones()
            Case "S"
                btnImprimir.Visible = False
                '==============combo proceso solo para almacen=========
                cmbProceso.Visible = False
                lblProceso.Visible = False
                '======================================================
                HabilitaBotones()
            Case "T"
                btnImprimir.Visible = False
                '==============combo proceso solo para almacen=========
                cmbProceso.Visible = False
                lblProceso.Visible = False
                '======================================================
                HabilitaBotones()
            Case "X"
                btnAgregar.Visible = False
                btnModificar.Visible = False
                btnEliminar.Visible = False

                btnEliminarDetalle.Visible = False
                btnConsistencia.Visible = False
                btnRevisado.Visible = False
        End Select
    End Sub
    Private Sub HabilitaBotones()
        If cmbEstadoPendiente.SelectedValue = "N" Then
            btnAgregar.Visible = True
            btnEliminar.Visible = True
        End If

        btnModificar.Visible = True


        btnEliminarDetalle.Visible = True
        btnConsistencia.Visible = True
        ' btnRevisado.Visible = True

    End Sub
    Private Function Lista_Tipo_Proceso() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbProceso.CheckedItems.Count - 1
            For j As Integer = 0 To oDtTiposDocumentos.Rows.Count - 1
                If (oDtTiposDocumentos.Rows(j).Item("SMARCA") = cmbProceso.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtTiposDocumentos.Rows(j).Item("SMARCA") & ","   'CCMPRN
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function
    Private Sub Limpiar_Grilla_Servicio()
        dtgOperaciones.DataSource = Nothing
    End Sub
    Private Sub Limpiar_Detalle_Servicios()
        Me.dtgServiciosOperacion.DataSource = Nothing
        Me.dtgDetalleServicioSil.DataSource = Nothing
        Me.dtgBultos.DataSource = Nothing
        Me.dtgMercaderia.DataSource = Nothing
        Me.dtgReembolso.DataSource = Nothing
    End Sub



    Private Sub Valida_Estados()


        Select Case cmbEstadoPendiente.SelectedValue
            'ESTADO DE SERVICIO
            Case "S"

                cmbEstadoFactura.Visible = True
                lblFacturacion.Visible = True
                btnConsistencia.Text = "Reporte Consistencia Facturar"
                'btnQuitaConsistencia.Visible = False

                'btnRevisado.Visible = True
                btnRevisado.Visible = False
                btnAgregar.Visible = False
                btnEliminar.Visible = False

                'If cmbEstadoFactura.SelectedValue.ToString = "N" Then btnQuitaConsistencia.Visible = True
            Case "0"
                btnConsistencia.Text = "Reporte Consistencia"
                cmbEstadoFactura.Visible = True
                lblFacturacion.Visible = True
                Select Case cmbEstadoFactura.SelectedValue
                    Case "S", "0"
                        dtgOperaciones.Columns("chk").ReadOnly = True
                        btnAgregar.Visible = False
                        btnModificar.Visible = False
                        btnEliminar.Visible = False

                        btnAdjuntar.Visible = False

                        btnRevisado.Visible = False
                        'btnQuitaConsistencia.Visible = False

                    Case "N"
                        dtgOperaciones.Columns("chk").ReadOnly = False
                        btnAgregar.Visible = False
                        btnModificar.Visible = False
                        btnEliminar.Visible = False

                        btnAdjuntar.Visible = False
                        btnRevisado.Visible = False
                        'btnQuitaConsistencia.Visible = True

                End Select

            Case "N"
                btnConsistencia.Text = "Reporte Consistencia Operativa"
                dtgOperaciones.Columns("chk").ReadOnly = False

                btnAgregar.Visible = True
                btnModificar.Visible = True
                btnEliminar.Visible = True
                btnAdjuntar.Visible = True

                btnRevisado.Visible = True
                'btnQuitaConsistencia.Visible = False

                cmbEstadoFactura.Visible = False
                lblFacturacion.Visible = False
        End Select



    End Sub

    Private Sub Llenar_Servicios()
        Dim oServicio As New Servicio_BE
        Dim oDt As DataTable
        oServicio.TIPO_PROCESO = Lista_Tipo_Proceso()
        oServicio.CCLNT = UcCliente.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo

        If Me.chkFecha.Checked Then
            oServicio.FECINI = Comun.FormatoFechaAS400(Me.dtFeInicial.Text)
            oServicio.FECFIN = Comun.FormatoFechaAS400(Me.dtFeFinal.Text)
        Else
            oServicio.FECINI = 0
            oServicio.FECFIN = 99999999
        End If
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.CDVSN = UcDivision.Division

        oServicio.TIPO_PLANTA = Lista_Tipo_Planta()
        If chkFechaOperacion.Checked Then
            oServicio.FECSERV_INI = Comun.FormatoFechaAS400(Me.dtpFechaServIni.Text)
            oServicio.FECSERV_FIN = Comun.FormatoFechaAS400(Me.dtpFechaServFin.Text)
        Else
            oServicio.FECSERV_INI = 0
            oServicio.FECSERV_FIN = 0

        End If

        oServicio.FLGFAC = Me.cmbEstadoFactura.SelectedValue

        'oServicio.NRTFSV = Me.cmbServicio.SelectedValue
        oServicio.NRTFSV = 0

        oServicio.FLGPEN = cmbEstadoPendiente.SelectedValue
        If oServicio.FLGFAC = "N" Then
            dtgOperaciones.Columns("NDCCTC").Visible = False
        Else
            dtgOperaciones.Columns("NDCCTC").Visible = True

        End If

        If oServicio.FLGPEN = "N" Then
            dtgOperaciones.Columns("NSECFC").Visible = False
        Else
            dtgOperaciones.Columns("NSECFC").Visible = True
        End If
        oServicio.NORCML = txtOC.Text.Trim
        'oServicio.TLUGEN = IIf(cmbLote.SelectedIndex = 0, "", cmbLote.SelectedValue)
        oServicio.TLUGEN = ""

        oServicio.STPODP = cmbTipoAlmacenaje.SelectedValue 'TIPO DEPOSITO
        oServicio.CTPALJ = cmbTipoServicio.SelectedValue   'TIPO ALMACENJAE (TIPO SERVICIO)
        oServicio.NOPRCN = IIf(txtOperacion.Text.Length > 0, txtOperacion.Text, 0)
        oDt = oServicioOpeNeg.Lista_Servicios_x_Cliente(oServicio)
        dtgOperaciones.AutoGenerateColumns = False
        dtgOperaciones.DataSource = oDt
    End Sub


    'Private Sub CargarLotes()
    '    If UcCliente.pCodigo > 0 Then
    '        Dim oServicioOpeNeg As New clsServicio_BL
    '        Me.cmbLote.DataSource = oServicioOpeNeg.ListarLotes(UcCliente.pCodigo)
    '        Me.cmbLote.ValueMember = "TLTECL"
    '        Me.cmbLote.DisplayMember = "TLTECL"
    '        cmbLote.ComboBox.SelectedIndex = 0
    '    End If


    'End Sub
    Private Sub dtgOperaciones_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOperaciones.DataBindingComplete
        Try
            Dim sumaDolares As Double = 0D
            Dim sumaSoles As Double = 0D
            Dim cambio As Double = IIf(lblTipoCambio_1.Text = 0, 0D, lblTipoCambio_1.Text)
            Dim montoTemp As Double = 0D
            Dim listOC As String = ""
            For i As Integer = 0 To dtgOperaciones.Rows.Count - 1
                If Me.dtgOperaciones.Rows(i).Cells("CMNDA1").Value() = 100 Then
                    montoTemp = IIf(IsDBNull(Me.dtgOperaciones.Rows(i).Cells("MONTO").Value()), 0, Me.dtgOperaciones.Rows(i).Cells("MONTO").Value())
                    sumaDolares = sumaDolares + montoTemp
                    If cambio <> 0 Then
                        sumaSoles = sumaSoles + (Me.dtgOperaciones.Rows(i).Cells("MONTO").Value() * cambio)
                    End If
                Else
                    If cambio <> 0 Then
                        sumaDolares = sumaDolares + (Me.dtgOperaciones.Rows(i).Cells("MONTO").Value() / cambio)
                    End If
                    sumaSoles = sumaSoles + Me.dtgOperaciones.Rows(i).Cells("MONTO").Value()
                End If
                'DESCRIPCION TIPO ALMACENAJE
                Select Case Me.dtgOperaciones.Rows(i).Cells("CTPALJ").Value.ToString.Trim
                    Case Estatico.E_ESP_Manual '"MA"
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANUAL"
                    Case Estatico.E_ESP_Adicional '"AD"
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ADICIONAL"
                    Case Estatico.E_ESP_General, "" '"GE"
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "GENERAL"
                    Case Estatico.E_ESP_Reembolso
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "REEMBOLSO"
                    Case Estatico.E_ESP_Almacenaje '"AL"
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE"
                    Case Estatico.E_ESP_AlmacenajePeso 'AP
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR FECHA DE CORTE"
                    Case Estatico.E_ESP_ManipuleoPeso 'MP
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANIPULEO POR FECHA DE CORTE"
                    Case Estatico.E_ESP_PesoPromedio 'PP
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PESO PROMEDIOS"
                    Case Estatico.E_ESP_Permanencia 'PE
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PERMANENCIA"

                    Case Estatico.E_RangoViaje 'RV
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "RANGO VIAJE"

                    Case Estatico.E_RecuperoSeguro 'RS
                        Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "RECUPERO SEGURO"


                End Select

                If Me.dtgOperaciones.Rows(i).DataBoundItem.Item("NMRGIM") > 0 Then
                    Me.dtgOperaciones.Rows(i).Cells("LINK").Value() = My.Resources.text_block
                Else
                    Me.dtgOperaciones.Rows(i).Cells("LINK").Value() = My.Resources.filesave
                End If


                listOC = dtgOperaciones.Rows(i).Cells("NORCML2").Value.ToString().Trim

                dtgOperaciones.Rows(i).Cells("CON_OC").Value = "Sin OC"
                If listOC.Length > 0 Then
                    dtgOperaciones.Rows(i).Cells("CON_OC").Value = "Ver OC"
                End If


            Next
            HGDatos.ValuesSecondary.Heading = "Monto a Cobrar : S/. " & Format(sumaSoles, "###,###,###,###.00") & " / - - / Monto a Cobrar : USD " & Format(sumaDolares, "###,###,###,###.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If chkFecha.Checked Then
            Me.dtFeInicial.Enabled = True
            Me.dtFeFinal.Enabled = True
            dtFeFinal.Value = Now
            dtFeInicial.Value = Now.AddDays(1 - CInt(Today.Day.ToString))
        Else
            Me.dtFeInicial.Enabled = False
            Me.dtFeFinal.Enabled = False
        End If
    End Sub
    'Private Sub dtgOperaciones_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgOperaciones.CurrentCellChanged
    '    If dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
    '    Cargar_Servicios_x_Operacion()
    'End Sub

    Private Sub UcCliente_InformationChanged() Handles UcCliente.InformationChanged
        'Carga_Servicios()
        RealizarBusqueda()
        'CargarLotes()
    End Sub
#End Region
#Region "SIL / Almacen"
    Private Sub Cargar_Servicios_x_Operacion()
        Dim oDt As New DataTable
        Me.dtgServiciosOperacion.DataSource = Nothing
        If dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        oServicio = New Servicio_BE
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.CDVSN = UcDivision.Division
        oServicio.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
        oDt = oServicioOpeNeg.fdtListaServicioOperacion(oServicio)
        dtgServiciosOperacion.AutoGenerateColumns = False
        dtgServiciosOperacion.DataSource = oDt
        Cargar_Detalle_Servicios()

    End Sub
    Private Sub Cargar_Detalle_Servicios()
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        If Me.dtgServiciosOperacion.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dtgBultos.DataSource = Nothing
        Me.dtgMercaderia.DataSource = Nothing
        dtgDetalleServicioSil.DataSource = Nothing
        Dim oServicio As New Servicio_BE

        oServicio.CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
        oServicio.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
        oServicio.NRTFSV = dtgServiciosOperacion.CurrentRow.DataBoundItem.Item("NRTFSV")
        oServicio.CPLNDV = dtgOperaciones.CurrentRow.DataBoundItem.Item("CPLNDV")
        oServicio.STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.CDVSN = UcDivision.Division
        oServicio.CTPALJ = dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")

        Dim iValida As String = oServicio.STPODP

        If oServicio.CTPALJ <> Estatico.E_ESP_General Then iValida = oServicio.CTPALJ.Trim '"GE"

        Select Case UcDivision.Division
            Case "R" ' =========ALMACEN===========
                InhabilitaTabs()
                HabilitaTabs(UcDivision.Division, oServicio.STPODP.Trim, oServicio.CTPALJ.Trim)
                Select Case iValida
                    Case Comun.eTipoAlmacen.AlmTransito, Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_PesoPromedio, Estatico.E_ESP_Almacenaje
                        dtgBultos.AutoGenerateColumns = False
                        dtgBultos.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosFacturacionSA(oServicio)
                    Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple '"1", "5"
                        dtgMercaderia.AutoGenerateColumns = False
                        Me.dtgMercaderia.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosFacturacionSA(oServicio)
                    Case Estatico.E_ESP_Reembolso  'Comun.ESP_Reembolso '"RE"
                        dtgReembolso.AutoGenerateColumns = False
                        Me.dtgReembolso.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosReembolso(oServicio)
                End Select
            Case "S" ' ===========SIL=============
                Dim oDt As New DataTable
                Dim oclsServicioSC_DAL As New clsServicioSC_DAL
                oDt = oclsServicioSC_DAL.Lista_Detalle_Servicios_SC(oServicio)
                dtgDetalleServicioSil.AutoGenerateColumns = False
                dtgDetalleServicioSil.DataSource = oDt

        End Select
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dtgOperaciones.RowCount = 0 Then Exit Sub
        '=====Elimina Segun el Tipo de Servicio Sil o Almacen====
        Dim oServicio As New Servicio_BE
        Try

            '=========Validamos si esta provisionado
            Dim obeServicio As Servicio_BE
            Dim olstServicio As New List(Of Servicio_BE)
            obeServicio = New Servicio_BE
            obeServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
            obeServicio.CDVSN = UcDivision.Division
            obeServicio.CPLNDV = cmbPlanta.SelectedValue
            obeServicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
            obeServicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
            obeServicio.NSECFC = dtgOperaciones.CurrentRow.Cells("NSECFC").Value
            obeServicio.TIPO_REV = "2"
            olstServicio.Add(obeServicio)
            If fblnValidarProvision(olstServicio) Then Exit Sub
            '=========Validamos si esta provisionado

            If dtgOperaciones.CurrentRow.DataBoundItem.Item("NSECFC") > 0 Then
                MsgBox("No se puede Anular pues tiene asignado un Nro de Consistencia", MsgBoxStyle.Information, "Información")
                Exit Sub
            End If
            Select Case UcDivision.Division
                Case "R" '=========ALMACEN===========
                    If Comun.RspMsgBox(Comun.Mensaje("MENSAJE.CONFIRMA.ELIMINA.SERVICIO")) = Windows.Forms.DialogResult.Yes Then
                        Dim oServicio_BE As New Servicio_BE
                        oServicio_BE.CTPALJ = dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")
                        oServicio_BE.CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
                        oServicio_BE.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
                        oServicio_BE.SESTRG = "*"
                        oServicio_BE.PSUSUARIO = _pUsuario

                        If oServicio_BE.CTPALJ = Estatico.E_ESP_Reembolso Then
                            If oServicioOpeNeg.AnularOperacionReembolsoSA_ALL(oServicio_BE) = "0" Then
                                MsgBox("Error", MessageBoxIcon.Information, "Información")
                            Else
                                Me.dtgOperaciones.Rows.RemoveAt(Me.dtgOperaciones.CurrentCellAddress.Y)
                                Limpiar_Detalle_Servicios()
                                Cargar_Detalle_Servicios()
                            End If
                        ElseIf oServicio_BE.CTPALJ = Estatico.E_ESP_PesoPromedio Then
                            If oServicioOpeNeg.AnularOperacionPromediosSA(oServicio_BE) = "0" Then
                                MsgBox("Error", MessageBoxIcon.Information, "Información")
                            Else
                                Me.dtgOperaciones.Rows.RemoveAt(Me.dtgOperaciones.CurrentCellAddress.Y)
                                Limpiar_Detalle_Servicios()
                                Cargar_Detalle_Servicios()
                            End If
                        Else
                            If oServicioOpeNeg.fdecActualizarOperacionFacturacionSA(oServicio_BE) = 0 Then
                                MsgBox("Error", MessageBoxIcon.Information, "Información")
                            Else
                                Me.dtgOperaciones.Rows.RemoveAt(Me.dtgOperaciones.CurrentCellAddress.Y)
                                Limpiar_Detalle_Servicios()
                                Cargar_Detalle_Servicios()
                            End If
                        End If
                    End If

                Case "S" ' ===========SIL=============
                    If Me.dtgOperaciones.SelectedRows.Count > 0 Then
                        oServicio.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")

                        If Comun.RspMsgBox(Comun.Mensaje("MENSAJE.CONFIRMA.ELIMINA.SERVICIO")) = Windows.Forms.DialogResult.Yes Then
                            oServicioOpeNeg.Quitar_Servicio(oServicio)
                            Me.dtgOperaciones.Rows.RemoveAt(Me.dtgOperaciones.SelectedRows(0).Index)
                            Limpiar_Detalle_Servicios()
                        End If
                    End If
                Case "T" ' ===========TRANSPORTE=============
                    If Me.dtgOperaciones.SelectedRows.Count > 0 Then
                        oServicio.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")

                        If Comun.RspMsgBox(Comun.Mensaje("MENSAJE.CONFIRMA.ELIMINA.SERVICIO")) = Windows.Forms.DialogResult.Yes Then
                            oServicioOpeNeg.Quitar_Servicio(oServicio)
                            Me.dtgOperaciones.Rows.RemoveAt(Me.dtgOperaciones.SelectedRows(0).Index)
                            Limpiar_Detalle_Servicios()
                        End If
                    End If
                Case Else
                    MsgBox(Comun.Mensaje("MENSAJE.ERROR.ELIMINA.SERVICIO2"), MessageBoxIcon.Error)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim TituloAdicion As String = ""
        Dim strPLanta As String = ""
        Dim lstrPLanta As String()
        Dim oServicio As New Servicio_BE
        Me.Cursor = Cursors.WaitCursor
        With oServicio
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CDVSN = UcDivision.Division
            strPLanta = Lista_Tipo_Planta()

            If strPLanta <> "" Then
                lstrPLanta = strPLanta.Split(",")
                If lstrPLanta.Length = 1 Then
                    .CPLNDV = strPLanta
                Else
                    .CPLNDV = lstrPLanta(0)
                End If
            ElseIf strPLanta = "" Then
                .CPLNDV = 0
            End If

            .NOPRCN = 0
            .CCLNFC = UcCliente.pCodigo
            .CCLNT = UcCliente.pCodigo
            .NRTFSV = 0
            .QATNAN = 0
            .TIPO = Comun.ESTADO_Nuevo
            .FOPRCN = 0
            .FECINI = 0
            .FECFIN = 0
            .STPODP = pTipoAlmacen
            .PSUSUARIO = _pUsuario
        End With

        If UcCliente.pCodigo = 0 Then
            MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Select Case UcDivision.Division
            Case "R"
                If cmbTipoServicio.SelectedValue = "0" Then ' CASO NO TENGA SELECCIONADO UN TIPO DE SERVICIO A CREAR
                    oServicio.STPODP = 7
                    oServicio.CTPALJ = "GE"
                Else
                    oServicio.STPODP = cmbTipoAlmacenaje.SelectedValue
                    oServicio.CTPALJ = cmbTipoServicio.SelectedValue
                End If
                TituloAdicion = "SERVICIO GENERAL - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
            Case "S"

                oServicio.CTPALJ = "MA"

                TituloAdicion = "SERVICIO MANUAL - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.SIL")

            Case "T"

                oServicio.CTPALJ = "MA"

                TituloAdicion = "SERVICIO MANUAL - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.SIL")
        End Select

        Dim frm As New UcFrmServicioAgregarSA_DS
        frm.oServicio = oServicio

        frm.Text = TituloAdicion
        frm.pCodigoCompania = UcDivision.Compania
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Limpiar_Grilla_Servicio()
            Llenar_Servicios()
        End If

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim oServicio As New Servicio_BE
        '=========VALIDACIONES=============
        If Me.dtgOperaciones.Rows.Count = 0 Then Exit Sub
        If Me.dtgServiciosOperacion.Rows.Count = 0 Then Exit Sub

        '=========Validamos si esta provisionado
        Dim obeServicio As Servicio_BE
        Dim olstServicio As New List(Of Servicio_BE)
        obeServicio = New Servicio_BE
        obeServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        obeServicio.CDVSN = UcDivision.Division
        obeServicio.CPLNDV = cmbPlanta.SelectedValue
        obeServicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
        obeServicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
        obeServicio.NSECFC = dtgOperaciones.CurrentRow.Cells("NSECFC").Value
        obeServicio.CDIRSE = dtgOperaciones.CurrentRow.Cells("CDIRSE").Value
        obeServicio.TIPO_REV = "2"
        olstServicio.Add(obeServicio)
        If fblnValidarProvision(olstServicio) Then Exit Sub
        '=========Validamos si esta provisionado


        '==================================
        Me.Cursor = Cursors.WaitCursor
        With oServicio
            .TIPO = Comun.ESTADO_Modificado
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CDVSN = UcDivision.Division
            .NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
            .NSECFC = dtgOperaciones.CurrentRow.DataBoundItem.Item("NSECFC")
            .CCLNFC = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNFC")
            .CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
            .CPLNDV = dtgOperaciones.CurrentRow.DataBoundItem.Item("CPLNDV")
            .FOPRCN = Comun.FormatoFechaAS400(("" & dtgOperaciones.CurrentRow.DataBoundItem.Item("FOPRCN")).ToString.Trim)
            .STIPPR = dtgOperaciones.CurrentRow.DataBoundItem.Item("STIPPR")
            .CTPALJ = dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")
            .STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")
            .PSUSUARIO = _pUsuario
            .CUNDMD = dtgServiciosOperacion.Rows(0).Cells("CUNDMD").Value 'Enviamos la 1ra. unidad de medida 
            .FECINI = dtgServiciosOperacion.Rows(0).Cells("FINPRF").Value 'Fecha Inicio 
            .FECFIN = dtgServiciosOperacion.Rows(0).Cells("FFNPRF").Value 'Fecha Fin
            .TLUGEN = dtgServiciosOperacion.Rows(0).Cells("TLUGEN").Value.ToString.Trim
            .TCTCST = dtgServiciosOperacion.Rows(0).Cells("TCTCST").Value.ToString.Trim
            .NORCML = dtgServiciosOperacion.Rows(0).Cells("NORCML").Value.ToString.Trim
            .FLGPEN = cmbEstadoPendiente.SelectedValue
            If dtgBultos.Rows.Count > 0 Then .CTPALM = dtgBultos.Rows(0).Cells("CTPALM").Value.ToString.Trim 'SOLO CUANDO GUARDAN SUSTENTO
        End With

        ' Iniciamos el proceso, siempre que tenga ingresado el Nro de Operación
        If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN").ToString.Equals("0") Then

            Dim frm As New UcFrmServicioAgregarSA_DS()
            frm.oServicio = oServicio
            frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.MODIFICA.SERVICIO")
            frm.txtDireccion.Text = dtgOperaciones.CurrentRow.DataBoundItem.Item("DIRECSERV").ToString.Trim
            frm.txtUbigeo.Text = dtgOperaciones.CurrentRow.DataBoundItem.Item("UBIGEO").ToString.Trim
            frm.codigoDireccionServicio = dtgOperaciones.CurrentRow.DataBoundItem.Item("CDIRSE").ToString.Trim

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Limpiar_Grilla_Servicio()
                Llenar_Servicios()
                Limpiar_Detalle_Servicios()
                Cargar_Detalle_Servicios()
                Cargar_Servicios_x_Operacion()
            End If

        End If

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            RealizarBusqueda()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub RealizarBusqueda()
        Me.Cursor = Cursors.WaitCursor
        Limpiar_Grilla_Servicio()
        Llenar_Servicios()
        Limpiar_Detalle_Servicios()
        Me.Cursor = Cursors.Default
        'dtgOperaciones_CurrentCellChanged(Nothing, Nothing)
        dtgOperaciones_SelectionChanged(Nothing, Nothing)
    End Sub

    'Private Sub btnQuitaConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitaConsistencia.Click
    '    If dtgOperaciones.Rows.Count = 0 Then Exit Sub


    '    If MsgBox("Seguro que desea eliminar la Consistencia ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
    '        Me.dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
    '        FiltrarDatos()

    '    Else
    '        Exit Sub
    '    End If
    'End Sub
    'Private Sub FiltrarDatos()
    '    Dim intCont As Integer
    '    Dim intProcesado As Integer = 0

    '    If dtgOperaciones.RowCount = 0 Then
    '        MsgBox("No hay Registro para anular")
    '        Return
    '    End If

    '    '=========Validamos si esta provisionado
    '    Dim obeServicio As Servicio_BE
    '    Dim olstServicio As New List(Of Servicio_BE)
    '    For intCont = dtgOperaciones.RowCount - 1 To 0 Step -1
    '        If Convert.ToBoolean(dtgOperaciones.Rows(intCont).Cells("chk").Value) = True Then
    '            obeServicio = New Servicio_BE
    '            obeServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
    '            obeServicio.CCLNT = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
    '            obeServicio.NOPRCN = dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value
    '            obeServicio.NSECFC = dtgOperaciones.Rows(intCont).Cells("NSECFC").Value
    '            obeServicio.TIPO_REV = "2"
    '            olstServicio.Add(obeServicio)
    '        End If
    '    Next intCont
    '    If fblnValidarProvision(olstServicio) Then Exit Sub
    '    '=========Validamos si esta provisionado

    '    For intCont = dtgOperaciones.RowCount - 1 To 0 Step -1
    '        If CType(dtgOperaciones.Rows(intCont).Cells("chk").Value, Boolean) Then
    '            If dtgOperaciones.Rows(intCont).Cells("NSECFC").Value <> 0 Then
    '                oServicio.NSECFC = CType(dtgOperaciones.Rows(intCont).Cells("NSECFC").Value, Double)
    '                oServicio.PSUSUARIO = _pUsuario
    '                oServicioOpeNeg.AnularConsistencia(oServicio)

    '                'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
    '                Dim oDt As DataTable
    '                Dim oFiltro As New Filtro_BE
    '                Dim oFacturaNeg As New clsFactura_BL  'CSR-HUNDRED-ESTIMACION-INGRESO
    '                oFiltro.Parametro1 = UcCompania.CCMPN_CodigoCompania 'Compañía
    '                oFiltro.Parametro12 = 0 'Tipo de Documento
    '                oFiltro.Parametro13 = 0 'Nro. Documento 
    '                oFiltro.Parametro14 = oServicio.NSECFC 'Nro. Revisión
    '                oDt = oFacturaNeg.Estimacion_Ingreso_Revertir(oFiltro)



    '                'Invocar el Servicio Web con los parametros devueltos del SP
    '                If oDt.Rows.Count > 0 Then
    '                    Dim IdEstimacion As Double, AnioContaSap As Double, FechaDocCtaCte As Double
    '                    Dim NroDocEstimacionSap As String, CodSociedadSap As String, NumDocElectronico As String


    '                    Dim dt_url_servicio As New DataTable
    '                    Dim oda_url_servicio As New ClsUrlWServicio
    '                    dt_url_servicio = oda_url_servicio.Listar_Url_Servicio("SDESTSAPSALM", "", "", 0)
    '                    Dim url_ws_servicio As String = ""
    '                    If dt_url_servicio.Rows.Count > 0 Then
    '                        url_ws_servicio = ("" & dt_url_servicio.Rows(0)("URL")).ToString.Trim
    '                    End If

    '                    For index As Integer = 0 To oDt.Rows.Count - 1
    '                        IdEstimacion = oDt.Rows(index).Item("IDESTM")
    '                        NroDocEstimacionSap = oDt.Rows(index).Item("NDESAP").ToString.Trim
    '                        CodSociedadSap = oDt.Rows(index).Item("CSCDSP").ToString.Trim
    '                        AnioContaSap = oDt.Rows(index).Item("ACNTSP")
    '                        NumDocElectronico = oDt.Rows(index).Item("NDCCTE").ToString.Trim
    '                        FechaDocCtaCte = oDt.Rows(index).Item("FDCFCC")
    '                        'INI-ECM-ActualizacionTarifario[RF001]-160516
    '                        Dim wssalmon As New ws_reversion_Ingreso.ws_salmon
    '                        wssalmon.Url = url_ws_servicio
    '                        wssalmon.ws_reversion_ingreso(IdEstimacion, CodSociedadSap, NroDocEstimacionSap, AnioContaSap, NumDocElectronico, FechaDocCtaCte)
    '                        'FIN-ECM-ActualizacionTarifario[RF001]-160516
    '                    Next

    '                End If


    '                dtgOperaciones.Rows.RemoveAt(intCont)
    '                intProcesado = 1
    '            End If
    '        End If
    '    Next intCont
    '    If intProcesado = 0 Then
    '        MsgBox("No hay Registro habilitado para Anular")
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '        Return
    '    End If
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    RealizarBusqueda()
    '    MsgBox("Se Anuló correctamente")


    'End Sub

    Private Sub ActualizarDatos()
        Dim intCont As Integer
        Dim dblAcumulado As Double = 0
        For intCont = dtgOperaciones.RowCount - 1 To 0 Step -1
            If dtgOperaciones.Rows(intCont).Cells("VALIDAR").Value = 0 Then
                dtgOperaciones.Rows.RemoveAt(intCont)
            End If
        Next intCont
    End Sub
    Private Function validarInformacionCliente() As Boolean
        Dim b As Boolean = True
        Dim intProcesado As Integer = 0
        Dim intCont As Integer
        Dim cliOpePri As Integer = 0
        Dim cliFacPri As Integer = 0
        Dim cliOpeSig As Integer = 0
        Dim cliFacSig As Integer = 0
        Dim cliComp1 As String = ""
        Dim cliComp2 As String = ""
        Dim opeRG1 As String = "" 'Region Venta 1
        Dim opeRG2 As String = "" 'Region Venta 2
        Dim valCTPALJ1 As String = ""
        Dim valCTPALJ2 As String = ""
        Dim valCMNDA1 As String = ""
        Dim valCMNDA2 As String = ""
        '=================Valida que este marcado y que pertenezca a la misma Region Venta===============
        For intCont = 0 To dtgOperaciones.Rows.Count - 1
            If Convert.ToBoolean(dtgOperaciones.Rows(intCont).Cells("chk").Value) = True Then
                intProcesado = intProcesado + 1
                If intProcesado = 1 Then
                    cliFacPri = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                    cliOpePri = dtgOperaciones.Rows(intCont).Cells("CCLNFC").Value
                    cliComp1 = cliFacPri.ToString & "-" & cliOpePri.ToString
                    opeRG1 = dtgOperaciones.Rows(intCont).Cells("CRGVTA").Value
                    valCTPALJ1 = dtgOperaciones.Rows(intCont).Cells("CTPALJ").Value
                    valCMNDA1 = dtgOperaciones.Rows(intCont).Cells("CMNDA1").Value
                Else
                    cliFacSig = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                    cliOpeSig = dtgOperaciones.Rows(intCont).Cells("CCLNFC").Value
                    cliComp2 = cliFacSig.ToString & "-" & cliOpeSig.ToString
                    opeRG2 = dtgOperaciones.Rows(intCont).Cells("CRGVTA").Value
                    valCTPALJ2 = dtgOperaciones.Rows(intCont).Cells("CTPALJ").Value
                    valCMNDA2 = dtgOperaciones.Rows(intCont).Cells("CMNDA1").Value
                End If
                If cliComp1 <> cliComp2 And intProcesado > 1 Then
                    b = False
                    MsgBox("Operaciones no pertenecen al mismo Cliente Operación y Cliente a Facturar", MsgBoxStyle.Information)
                    Exit For
                End If
                If valCTPALJ1 <> valCTPALJ2 And intProcesado > 1 Then
                    If (valCTPALJ2 = Estatico.E_ESP_Reembolso Or valCTPALJ1 = Estatico.E_ESP_Reembolso) Then
                        b = False
                        MsgBox("Las Operaciones de Reembolso deben ir juntas", MsgBoxStyle.Information)
                        Exit For
                    ElseIf (valCTPALJ2 = Estatico.E_ESP_PesoPromedio Or valCTPALJ1 = Estatico.E_ESP_PesoPromedio) Then
                        b = False
                        MsgBox("Las Operaciones de Almacenaje Promedio deben ir juntas", MsgBoxStyle.Information)
                        Exit For
                    Else
                    End If
                End If
                If opeRG1 <> opeRG2 And intProcesado > 1 Then
                    b = False
                    MsgBox("Los Servicios Pertenecen a Diferentes Regiones de Venta, No es posible generar un Nro.  de Revisión", MsgBoxStyle.Information)
                    Exit For
                End If
                If valCMNDA1 <> valCMNDA2 And intProcesado > 1 Then
                    b = False
                    MsgBox("Las operaciones estan en diferentes monedas, No es posible generar un Nro.  de Revisión", MsgBoxStyle.Information)
                    Exit For
                End If
            End If
        Next

        If intProcesado = 0 Then
            b = False
            MsgBox("No hay Registros habilitados para Procesar", MsgBoxStyle.Information)
        End If
        Return b


    End Function

    Private Sub Procesar_Consistencia_Masivo(obeServicio As Servicio_BE)
     
        Try
            dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If validarInformacionCliente() = False Then
                Exit Sub
            End If 
            Dim nroConsistencia As Decimal = 0
            nroConsistencia = oServicioOpeNeg.GenerarConsistenciaMasivo(oServicio)
            MsgBox("Se generó Nro. de Consistencia: " & nroConsistencia, MsgBoxStyle.Information)
 
        Catch ex As Exception         
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'Private Sub Procesar_Consistencia()
    '    Dim dblCodigo As Double
    '    Dim intCont As Integer
    '    Dim oServicio As New Servicio_BE
    '    Try
    '        dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
    '        If validarInformacionCliente() = False Then
    '            Exit Sub
    '        End If
    '        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '        dblCodigo = oServicioOpeNeg.ObtenerCodigoConsistencia.Rows(0).Item("NULCTR")
    '        For intCont = 0 To dtgOperaciones.Rows.Count - 1
    '            If Convert.ToBoolean(dtgOperaciones.Rows(intCont).Cells("chk").Value) = True Then
    '                oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
    '                oServicio.CDVSN = UcDivision.Division
    '                oServicio.CPLNDV = cmbPlanta.SelectedValue
    '                oServicio.CCLNT = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
    '                oServicio.NOPRCN = dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value

    '                oServicio.NSECFC = dblCodigo
    '                oServicioOpeNeg.ActualizarServicio_Atendido(oServicio)
    '            End If


    '        Next intCont
    '        MsgBox("Se genero el Nro. de Consistencia: " & CStr(dblCodigo), MsgBoxStyle.Information)
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '        MsgBox(ex.Message, MsgBoxStyle.Information)
    '    End Try
    'End Sub
    Private Sub dtgOperaciones_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellDoubleClick

        Try
            If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub



            If dtgOperaciones.Columns(e.ColumnIndex).Name = "LINK" Then
                If Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("NMRGIM") <> 0 Then




                    'Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos
                    'ofrmAdjuntarDocumentos.PNCCLNT = Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                    'ofrmAdjuntarDocumentos.pCCMPN = UcCompania.CCMPN_CodigoCompania
                    'ofrmAdjuntarDocumentos.pNMRGIM = Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("NMRGIM")
                    'ofrmAdjuntarDocumentos.PNNOPRCN = Me.dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                    'ofrmAdjuntarDocumentos.pTABLE_NAME = "RZSC19"
                    'ofrmAdjuntarDocumentos.PSUSUARIO = _pUsuario
                    'ofrmAdjuntarDocumentos.ShowDialog()
                    'btnBuscar_Click(Nothing, Nothing)
                End If
            End If

            If dtgOperaciones.Columns(e.ColumnIndex).Name = "AUDI" Then
                Dim ofrmAuditoria As New frmAuditoria
                With ofrmAuditoria

                    .txtUsuarioCreador.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("CUSCRT")
                    .txtFechaCreacion.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("FCHCRT")
                    .txtHoraCreacion.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("HRACRT")




                    .txtFechaActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("FULTAC")
                    .txtUsuarioActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("CULUSA")
                    .txtHoraActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("HULTAC")



                End With


                ofrmAuditoria.ShowDialog()

            End If

            If dtgOperaciones.Columns(e.ColumnIndex).Name = "CON_OC" Then             
                Dim ofrmverDetalle As New frmverDetalle
                ofrmverDetalle.pListDetalle = dtgOperaciones.CurrentRow.Cells("NORCML2").Value.ToString().Trim
                ofrmverDetalle.ShowDialog()

            End If

        Catch : End Try
    End Sub
    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(intCont).Cells("chk").Value = True Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)
        Valida_Estados()
        Dim intCont As Integer
        For intCont = 0 To dtgOperaciones.RowCount - 1
            dtgOperaciones.Rows(intCont).Cells("chk").Value = blnEstado
        Next intCont

    End Sub
    Private Sub btnRevisado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRevisado.Click

        Try

            If dtgOperaciones.RowCount = 0 Then Exit Sub
            dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim obeServicio As Servicio_BE
            Dim olstServicio As New List(Of Servicio_BE)
            Dim cadOperacion As String = String.Empty

            Dim JsOP As Dictionary(Of String, Object)
            Dim listJsOP As New List(Of Dictionary(Of String, Object))
            Dim CodCliente As Decimal = 0
            Dim por_det_inicio As Decimal = 0
            Dim por_det_actual As Decimal = 0
            Dim fila_reg As Int64 = 0
            Dim msgValDetraccion As String = ""

            For intCont As Integer = 0 To dtgOperaciones.Rows.Count - 1
                If Convert.ToBoolean(dtgOperaciones.Rows(intCont).Cells("chk").Value) = True Then

                    If fila_reg = 0 Then
                        por_det_inicio = dtgOperaciones.Rows(intCont).Cells("IPRCDT").Value
                        por_det_actual = por_det_inicio
                        fila_reg = 1
                    Else
                        fila_reg = fila_reg + 1
                        por_det_actual = dtgOperaciones.Rows(intCont).Cells("IPRCDT").Value
                    End If

                    If por_det_inicio <> por_det_actual Then
                        msgValDetraccion = "Las operaciones a revisar deben contar con el mismo % detracción."
                        Exit For
                    End If

                    obeServicio = New Servicio_BE
                    obeServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
                    obeServicio.CDVSN = UcDivision.Division
                    obeServicio.CPLNDV = cmbPlanta.SelectedValue
                    obeServicio.CCLNT = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                    obeServicio.NOPRCN = dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value
                    obeServicio.NSECFC = dtgOperaciones.Rows(intCont).Cells("NSECFC").Value
                    obeServicio.TIPO_REV = "2"
                    cadOperacion = cadOperacion & dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value & ","
                    olstServicio.Add(obeServicio)

                    CodCliente = obeServicio.CCLNT
                    JsOP = New Dictionary(Of String, Object)
                    JsOP.Add("NOP", obeServicio.NOPRCN)
                    listJsOP.Add(JsOP)

                End If
            Next intCont


           

            If olstServicio.Count = 0 Then
                MessageBox.Show("No ha seleccionado alguna operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If msgValDetraccion.Length > 0 Then
                MessageBox.Show(msgValDetraccion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'If fblnValidarProvision(olstServicio) Then Exit Sub


            If listJsOP.Count > 0 Then
                obeServicio = New Servicio_BE
                Dim StrJson As String = JsonConvert.SerializeObject(listJsOP)
                oServicio.CCLNT = CodCliente
                oServicio.LISTJSON = StrJson
                oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
                oServicio.CDVSN = UcDivision.Division
                Procesar_Consistencia_Masivo(oServicio)
            End If


            'Dim mensValDirServ As String = String.Empty
            'mensValDirServ = oServicioOpeNeg.Validar_Direccion_Servicio(UcCompania.CCMPN_CodigoCompania, UcDivision.Division, cadOperacion.Substring(0, cadOperacion.Length - 1), "")

            'If mensValDirServ <> String.Empty Or mensValDirServ <> "" Then
            '    MessageBox.Show(mensValDirServ, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'Procesar_Consistencia()

            Limpiar_Grilla_Servicio()
            Limpiar_Detalle_Servicios()
            Llenar_Servicios()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
      
    End Sub

    Private Function fblnValidarProvision(ByVal olstServicio As List(Of Servicio_BE)) As Boolean
        Dim intResultado As Integer = 0


        For Each obeServicio As Servicio_BE In olstServicio
            intResultado = oServicioOpeNeg.intTieneProvision(obeServicio)
            Select Case intResultado
                Case 0
                    Ransa.Utilitario.HelpClass.ErrorMsgBox()
                Case 2
                    'Validamos si el Usuario tiene permiso para Anular la provisión
                    Try
                        If oServicioOpeNeg.fblnUsuarioPermitidoRevertirProvision(ConfigurationWizard.UserName) Then
                            If obeServicio.TIPO_REV = "1" Then
                                If MsgBox("La Revisión :" & obeServicio.NSECFC & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                    Return True
                                    Me.Cursor = System.Windows.Forms.Cursors.Default
                                    Return True
                                End If
                            Else
                                If MsgBox("La Operación :" & obeServicio.NOPRCN & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                    Me.Cursor = System.Windows.Forms.Cursors.Default
                                    Return True
                                End If
                            End If
                        Else
                            'Usuario No puede Generar un revisado o Eliminar la provisión
                            MsgBox("Usted no tiene  autorización para administrar la operación :" & obeServicio.NOPRCN & " porque se encuentra provisionada.")
                            Return True
                        End If
                    Catch ex As Exception
                        Ransa.Utilitario.HelpClass.ErrorMsgBox()
                        Return True
                    End Try
            End Select
        Next




        Return False
    End Function
    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim oServ As New Servicio_BE

        oServ.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServ.CDVSN = UcDivision.Division
        oServ.CPLNDV = cmbPlanta.SelectedValue
        oServ.CCLNT = UcCliente.pCodigo
        oServ.PSUSUARIO = _pUsuario
        oServ.CCMPN_DESC = UcCompania.CCMPN_Descripcion
        oServ.CDVSN_DESC = UcDivision.DivisionDescripcion
        oServ.TIPO_PLANTA = Lista_Tipo_Planta()

        oServ.FLGPEN = cmbEstadoPendiente.SelectedValue
        oServ.CTPALJ = cmbTipoServicio.SelectedValue
        oServ.FLGFAC = Me.cmbEstadoFactura.SelectedValue
        If Me.chkFecha.Checked Then
            oServ.FechaInicio = dtFeInicial.Value
            oServ.FechaFin = dtFeFinal.Value
        End If
        Dim frm As New UcFrmConsistencia(oServ)

        frm.TipoAlmacen = cmbTipoAlmacenaje.SelectedValue
        frm.Revision = Val(dtgOperaciones.CurrentRow.Cells("NSECFC").Value)

        If Val(dtgOperaciones.CurrentRow.Cells("NSECFC").Value) > 0 And oServ.CTPALJ = "0" Then
            oServ.CTPALJ = dtgOperaciones.CurrentRow.Cells("CTPALJ").Value
        End If
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Limpiar_Grilla_Servicio()
            Llenar_Servicios()
            Limpiar_Detalle_Servicios()
        End If
    End Sub
    '==================MANTENIMIENTO DETALLE (EMBARQUES/BULTOS)====================
    Private Sub btnAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDetalle.Click
        If dtgOperaciones.CurrentRow Is Nothing Then Exit Sub
        Select Case TabDetalles.SelectedTab.Name
            Case "TabServicio"
                'btnModificar_Click(Nothing, Nothing)
            Case "TabReembolso"
                Exit Sub
            Case "TabBulto"
                Select Case dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")
                    Case Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_PesoPromedio
                        Exit Sub
                End Select
                Dim oServicio As New Servicio_BE
                With oServicio
                    .TIPO = Comun.ESTADO_Modificado
                    .CCMPN = UcCompania.CCMPN_CodigoCompania
                    .CDVSN = UcDivision.Division
                    .NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
                    .CPLNDV = dtgOperaciones.CurrentRow.DataBoundItem.Item("CPLNDV")
                    .CCLNFC = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNFC")
                    .CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
                    .NRTFSV = dtgServiciosOperacion.CurrentRow.DataBoundItem.Item("NRTFSV")
                    .QATNAN = dtgServiciosOperacion.CurrentRow.DataBoundItem.Item("QATNAN")
                    .FOPRCN = Comun.FormatoFechaAS400(dtgOperaciones.CurrentRow.DataBoundItem.Item("FOPRCN"))
                    .STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")
                    .PSUSUARIO = _pUsuario
                End With
                If oServicio.STPODP = "7" Then
                    Dim ofrmBuscarBulto As New frmBuscarBulto(oServicio)
                    If ofrmBuscarBulto.ShowDialog = DialogResult.OK Then
                        Cargar_Detalle_Servicios()
                    End If
                Else
                    Dim ofrmBuscarOs As New frmBuscarOs(oServicio)
                    If ofrmBuscarOs.ShowDialog = DialogResult.OK Then
                        Cargar_Detalle_Servicios()
                    End If
                End If
            Case "TabEmbarque"
                Dim intCont As Integer
                Dim oServicio As New Servicio_BE
                If Me.dtgOperaciones.Rows.Count = 0 Then Exit Sub
                intCont = Me.dtgOperaciones.CurrentRow.Index
                If dtgOperaciones.Rows(intCont).Cells("NDCCTC").Value <> 0 Then Exit Sub
                Me.Cursor = Cursors.WaitCursor
                With oServicio
                    .TIPO = Comun.ESTADO_Modificado
                    .CCMPN = UcCompania.CCMPN_CodigoCompania
                    .CDVSN = UcDivision.Division
                    .NOPRCN = Me.dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value
                    .CCLNFC = Me.dtgOperaciones.Rows(intCont).Cells("CCLNFC").Value
                    .CCLNT = Me.dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                    .NRTFSV = Me.dtgOperaciones.Rows(intCont).Cells("NRTFSV").Value
                    .QATNAN = Me.dtgOperaciones.Rows(intCont).Cells("QATNAN").Value
                    .CPLNDV = Me.dtgOperaciones.Rows(intCont).Cells("CPLNDV").Value
                    .FOPRCN = Comun.FormatoFechaAS400(dtgOperaciones.Rows(intCont).Cells("FOPRCN").Value)
                    .STIPPR = Me.dtgOperaciones.Rows(intCont).Cells("STIPPR").Value
                    .TIPOALM = 7
                End With
                Dim frm As New frmBuscarEmbarque
                frm.pCCLNT = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                frm.pNOPRCN = Me.dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value
                frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.MODIFICA.SERVICIO")
                frm.ShowDialog()
                If (frm.pDialogResult = True) Then
                    Limpiar_Grilla_Servicio()
                    Llenar_Servicios()
                    Limpiar_Detalle_Servicios()
                    Cargar_Detalle_Servicios()
                End If
                Me.Cursor = Cursors.Default
        End Select
    End Sub
    Private Sub btnEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDetalle.Click
        If dtgOperaciones.CurrentRow Is Nothing Then Exit Sub
        Select Case TabDetalles.SelectedTab.Name
            Case "TabServicio"

                '=========Validamos si esta provisionado
                Dim obeServicio As Servicio_BE
                Dim olstServicio As New List(Of Servicio_BE)
                obeServicio = New Servicio_BE
                obeServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
                obeServicio.CDVSN = UcDivision.Division
                obeServicio.CPLNDV = cmbPlanta.SelectedValue
                obeServicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                obeServicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                obeServicio.NSECFC = dtgOperaciones.CurrentRow.Cells("NSECFC").Value
                obeServicio.TIPO_REV = "2"
                olstServicio.Add(obeServicio)
                If fblnValidarProvision(olstServicio) Then Exit Sub
                '=========Validamos si esta provisionado

                '''''''''''ELIMINAR SERVICIO Y EN CASO DE SER EL ULTIMO ELIMINAR LA OPERACION Y LOS DETALLES'''''''''''''''
                Dim msjMoneda As String = ""
                Dim msjMonto As String = ""
                Dim flgEliminaExito As Integer = 0
                If dtgServiciosOperacion.Rows.Count = 0 Then Exit Sub
                If dtgServiciosOperacion.Rows.Count > 1 Then
                    msjMoneda = dtgServiciosOperacion.CurrentRow.Cells("TSGNMN_SRV").Value
                    msjMonto = "" & dtgServiciosOperacion.CurrentRow.Cells("MONTO_SRV").Value
                    If msjMonto.Length = 0 Then
                        msjMoneda = msjMoneda & " 0"
                    Else
                        msjMoneda = msjMoneda & " " & Math.Round(dtgServiciosOperacion.CurrentRow.Cells("MONTO_SRV").Value, 2)
                    End If



                    If MsgBox("Va a eliminar un Servicio con tarifa = " & msjMoneda & ". ¿Desea Continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim oServEli As New Servicio_BE
                        oServEli.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                        oServEli.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                        oServEli.NCRROP = dtgServiciosOperacion.CurrentRow.Cells("NCRROP").Value
                        oServEli.PSUSUARIO = _pUsuario
                        flgEliminaExito = oServicioOpeNeg.EliminarServiciosFacturacionAlmacenaje(oServEli)

                    End If
                End If
                If dtgServiciosOperacion.Rows.Count = 1 Then
                    If MsgBox("Se eliminara tambien la operación asociada al servicio a eliminar. ¿Desea Continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        btnEliminar_Click(Nothing, Nothing)
                        Llenar_Servicios()
                    End If
                End If
                If flgEliminaExito = 1 Then
                    dtgServiciosOperacion.Rows.Remove(dtgServiciosOperacion.CurrentRow)
                    Llenar_Servicios()
                End If
            Case "TabReembolso"
                Exit Sub
            Case "TabBulto"
                If dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP").Trim.Equals("7") And dtgBultos.CurrentRow Is Nothing Then
                    Exit Sub
                End If
                If dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP") <> "7" And dtgMercaderia.CurrentRow Is Nothing Then
                    Exit Sub
                End If
                Select Case dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")
                    Case Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_PesoPromedio
                        Exit Sub
                End Select
                If MessageBox.Show("Esta seguro de eliminar el bulto seleccionado?", "Información", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim oServAdqu As New Servicio_BE
                    oServAdqu.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
                    oServAdqu.CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
                    oServAdqu.STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")
                    If oServAdqu.STPODP.Trim.Equals("7") Then
                        oServAdqu.NCRRDC = Me.dtgBultos.CurrentRow.DataBoundItem.Item("NCRRDC")
                    Else
                        oServAdqu.NCRRDC = Me.dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC")
                    End If
                    oServAdqu.PSUSUARIO = _pUsuario
                    If oServicioOpeNeg.fintEliminarDetalleServiciosFacturacionSA(oServAdqu) = 0 Then
                        MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                    Else
                        If oServAdqu.STPODP.Trim.Equals("7") Then
                            dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                        Else
                            dtgMercaderia.Rows.Remove(dtgMercaderia.CurrentRow)
                        End If
                    End If
                End If
            Case "TabEmbarque"
                Dim msgInformativo As String = ""
                Dim PNNORSCI As Decimal = 0
                Dim PNNRITEM As Decimal = 0
                Dim obrclsServicioSC_BL As New clsServicioSC_BL
                Dim retorno As Int32 = 0
                If (dtgDetalleServicioSil.CurrentRow IsNot Nothing) Then
                    PNNORSCI = dtgDetalleServicioSil.CurrentRow.Cells("NORSCI").Value
                    PNNRITEM = dtgDetalleServicioSil.CurrentRow.Cells("NRITEM").Value
                    msgInformativo = String.Format("Está seguro de eliminar el embarque {0} asociado a la operación", PNNORSCI)
                    If (MessageBox.Show(msgInformativo, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        Dim oEmbarqueServicio As New Servicio_BE
                        oEmbarqueServicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                        oEmbarqueServicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                        oEmbarqueServicio.NORSCI = PNNORSCI
                        oEmbarqueServicio.PSUSUARIO = ConfigurationWizard.UserName
                        oEmbarqueServicio.NRITEM = PNNRITEM
                        retorno = obrclsServicioSC_BL.Eliminar_Item_Embarque_Servicio_SC(oEmbarqueServicio)
                        If (retorno = 1) Then
                            Cargar_Detalle_Servicios()
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub dtgDetalleServicioSil_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetalleServicioSil.CellDoubleClick
        If Me.dtgDetalleServicioSil.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgDetalleServicioSil.Columns(e.ColumnIndex).Name = "DETALLE" Then
            Dim oUcFrmEmbarqueDetalle As New UcFrmEmbarqueDetalle
            oUcFrmEmbarqueDetalle.pCCLNT = Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
            oUcFrmEmbarqueDetalle.pNORSCI = Me.dtgDetalleServicioSil.Rows(e.RowIndex).Cells("NORSCI").Value
            oUcFrmEmbarqueDetalle.ShowDialog()
        End If
    End Sub


    Private Sub dtgBultos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBultos.CellContentClick
        If Me.dtgBultos.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgBultos.Columns(e.ColumnIndex).Name = "IMG" Then
            Dim oServicio As New Servicio_BE
            With oServicio
                .CCMPN = UcCompania.CCMPN_CodigoCompania
                .CDVSN = UcDivision.Division
                .CPLNDV = Me.dtgOperaciones.CurrentRow.Cells("CPLNDV").Value.ToString.Trim
                .CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value.ToString.Trim
                .CREFFW = Me.dtgBultos.CurrentRow.Cells("CREFFW").Value.ToString.Trim
                .NSEQIN = Me.dtgBultos.CurrentRow.Cells("NSEQIN").Value.ToString.Trim
                .STIPPR = Me.dtgOperaciones.CurrentRow.Cells("STIPPR").Value.ToString.Trim
            End With
            Dim ofrmDetalleBulto As New frmDetalleBulto
            ofrmDetalleBulto.oDetalleServicio = oServicio
            If ofrmDetalleBulto.ShowDialog() = DialogResult.Cancel Then
            End If
        End If
    End Sub

    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntar.Click
        Try
            'Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos
            'ofrmAdjuntarDocumentos.PNCCLNT = Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
            'ofrmAdjuntarDocumentos.pCCMPN = UcCompania.CCMPN_CodigoCompania
            'ofrmAdjuntarDocumentos.pNMRGIM = Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("NMRGIM")
            'ofrmAdjuntarDocumentos.PNNOPRCN = Me.dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
            'ofrmAdjuntarDocumentos.pTABLE_NAME = "RZSC19"
            'ofrmAdjuntarDocumentos.PSUSUARIO = _pUsuario
            'ofrmAdjuntarDocumentos.ShowDialog()
            'btnBuscar_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If dtgOperaciones.RowCount = 0 Then Exit Sub
        Dim objDs As New DataSet
        Dim objDt As New DataTable
        Dim obj_Servicio As New Servicio_BE
        Dim cloServicio As New clsServicio_BL
        Dim objPrintForm As New PrintForm
        Dim rptOperacion As New rptOperacionSASAT

        obj_Servicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
        obj_Servicio.CPLNDV = dtgOperaciones.CurrentRow.Cells("CPLNDV").Value
        obj_Servicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
        objDt = cloServicio.RptOS_Almacen_RZSC22(obj_Servicio)
        If objDt.Rows.Count = 0 Then
            MsgBox("La operacion seleccionada no tiene bultos asociados", MsgBoxStyle.Information)
        End If
        objDt.TableName = "SrvOpe"
        objDs.Tables.Add(objDt)
        rptOperacion.SetDataSource(objDs)
        objPrintForm.ShowForm(rptOperacion, Me)
    End Sub
#End Region

    Private Sub txtOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperacion.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                If Asc(e.KeyChar) = 13 Then
                    btnBuscar_Click(Nothing, Nothing)
                Else
                    e.Handled = False
                End If

            Else

                e.Handled = True
            End If
        End If
    End Sub

    'Private Sub FacturaResumidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaResumidadToolStripMenuItem.Click
    '    If UcCliente.pCodigo = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Facturar(floOpercionesConCheck, 1)
    '    RealizarBusqueda()
    'End Sub

    'Private Sub FacturaDetalladaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaDetalladaToolStripMenuItem.Click
    '    If UcCliente.pCodigo = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Facturar(floOpercionesConCheck, 2)
    '    RealizarBusqueda()
    'End Sub

    Private Function floOpercionesConCheck() As List(Of Servicio_BE)
        dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim olOperacion As New List(Of Servicio_BE)
        Dim intCOnt As Integer
        For intCOnt = 0 To dtgOperaciones.Rows.Count - 1
            If Convert.ToBoolean(dtgOperaciones.Rows(intCOnt).Cells("chk").Value) = True And dtgOperaciones.Rows(intCOnt).DataBoundItem.Item("NDCFCC").ToString.Equals("0") Then
                oServicio = New Servicio_BE
                oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
                oServicio.CDVSN = UcDivision.Division
                oServicio.CPLNDV = cmbPlanta.SelectedValue
                oServicio.CCLNT = dtgOperaciones.Rows(intCOnt).Cells("CCLNT").Value
                oServicio.NOPRCN = dtgOperaciones.Rows(intCOnt).Cells("NOPRCN").Value
                oServicio.CMNDA1 = dtgOperaciones.Rows(intCOnt).Cells("CMNDA1").Value
                oServicio.TSGNMN = dtgOperaciones.Rows(intCOnt).Cells("TSGNMN").Value
                oServicio.CCLNFC = dtgOperaciones.Rows(intCOnt).Cells("CCLNFC").Value
                oServicio.TCMPDV = UcDivision.DivisionDescripcion
                olOperacion.Add(oServicio)
            End If
        Next intCOnt
        Return olOperacion
    End Function

    Public Sub Refrescar()
        RealizarBusqueda()
    End Sub


    Private Sub chkFechaOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaOperacion.CheckedChanged
        If chkFechaOperacion.Checked Then
            dtpFechaServIni.Enabled = True
            dtpFechaServFin.Enabled = True
        Else
            dtpFechaServIni.Enabled = False
            dtpFechaServFin.Enabled = False
        End If
    End Sub



    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click

        Me.Cursor = Cursors.WaitCursor
        dtgOperaciones.ReadOnly = True
        If dtgOperaciones.RowCount > 0 Then
            If Existe_Check() Then
                Poner_Check_Todo_OC(False)
                btnMarcarItems.Image = Desmarcar
            Else
                If Not (cmbEstadoFactura.SelectedValue = "S" OrElse cmbEstadoFactura.SelectedValue = "0") Then
                    Poner_Check_Todo_OC(True)
                    btnMarcarItems.Image = Marcar
                End If
            End If
        End If

        Me.dtgOperaciones.EndEdit()
        dtgOperaciones.ReadOnly = False
        Me.Cursor = Cursors.Default

    End Sub

    'Private Sub dtgOperaciones_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellClick
    '    Try
    '        If dtgOperaciones.Columns(e.ColumnIndex).Name = "chk" Then


    '        End If
    '    Catch : End Try


    'End Sub

    Private Sub chkOrdenCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOrdenCompra.CheckedChanged
        If chkOrdenCompra.Checked Then
            txtOC.Enabled = True
            dtgOperaciones.Columns.Item(32).Visible = True
        Else
            txtOC.Enabled = False
            dtgOperaciones.Columns.Item(32).Visible = False
        End If
    End Sub

    Private Sub UCServicioAtendido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkOrdenCompra.Checked = False
        txtOC.Enabled = False
        dtgOperaciones.Columns.Item(32).Visible = False
    End Sub


    'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
    'Private Function Estimacion_Ingreso_Revertir() As DataTable
    '    Dim oDtNew As DataTable
    '    Dim oFiltro As New Filtro_BE

    '    oFiltro.Parametro1 = UcCompania.CCMPN_CodigoCompania 'Compañía
    '    oFiltro.Parametro12 = 0 'Tipo de Documento
    '    oFiltro.Parametro13 = 0 'Nro. Documento 
    '    oFiltro.Parametro14 = oServicio.NSECFC 'Nro. Revisión

    '    oDtNew = oFacturaNeg.Estimacion_Ingreso_Revertir(oFiltro)

    '    Return oDtNew
    'End Function

    'CSR-HUNDRED-ESTIMACION-INGRESO-FIN

    Private Sub dtgOperaciones_SelectionChanged(sender As Object, e As EventArgs) Handles dtgOperaciones.SelectionChanged
        Try
            Cargar_Servicios_x_Operacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class


#Region "Tipos"
Public Enum eDivision
    Todos = 0
    Sil = 1
    Almacen = 2
    Transporte = 3
End Enum

#End Region


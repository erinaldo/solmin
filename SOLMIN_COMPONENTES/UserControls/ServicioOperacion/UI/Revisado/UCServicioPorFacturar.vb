'/*------------------------------------------------------------------------------*/
'/*----- Empresa          	: RANSA S.A.                                    -----*/
'/*----- Sistema          	: Solmin                  	                    -----*/
'/*----- Módulo          	: SD-SA-SC                  	     	        -----*/
'/*----- Nombre Programa    : UCServicioPorFacturar			                -----*/
'/*----- Desarrollado por	: Juan Carlos Torres U.                         -----*/
'/*----- Fecha Creación     : 29/11/2011                      	            -----*/
'/*----- Fecha Modificacion : //                            	            -----*/
'/*----- Fecha Modificacion : //                            	            -----*/
'/*----- Descripción        : Control que contiene los                    	-----*/
'/*-----                      servicios por operación                     	-----*/
'/*----- Descripción        : Servicios Especiales y nuevo filtro por revision --*/
'/*----- Descripción        :                                           	-----*/
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
'Imports Ransa.DAO.Cliente
'Imports Ransa.TypeDef.Cliente
Imports Ransa.Utilitario
Imports Newtonsoft.Json

Public Class UCServicioPorFacturar

#Region "Propiedades"

    Public pUsuario As String = "SOLMIN"
 


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

    Public pCompaniaActual As String = ""

 

    Public pFacturacionElectronica As Int32 = 0

 

    Private Estatico As New Estaticos
    Private oEstadoFactura As clsEstadoNeg = New clsEstadoNeg
    Private bolBuscar As Boolean = False
    Private oServicioOpeNeg As New clsServicio_BL
    Private oServicio As Servicio_BE
    Private oDtTiposDocumentos As New DataTable
    Private oDtPlanta As New DataTable
    Private oPlanta As clsPlantaNeg = New clsPlantaNeg
    Private olOperacion As New List(Of Servicio_BE)
    Private oDtSerivcio As DataTable
    Public Event FacturarConsistencia(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
    Public Event GenerarBoletaConsistencia(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)

    Public Event FacturarElectronicaConsistencia(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer, pTipoLista As Ransa.Utilitario.HelpClass.TipoLista)


#End Region

#Region "Eventos de Control"

    Public Sub pCargaInicial()
        CargarInformacion()
        Carga_Estado()
        CargarTipoServicio()
        'Carga_Servicios()
        cargaProceso()
        oPlanta.Crea_Lista(pUsuario)
        CargarPlanta()
        Visible_Control()
        Dim oLis As New List(Of String)
        oLis.Add("100")
        oLis.Add(Format(Now, "yyyyMMdd"))
        If oServicioOpeNeg.Lista_Tipo_Cambio(oLis).Rows.Count > 0 Then
            UcPorOperacion.lblTipoCambio_1.Text = oServicioOpeNeg.Lista_Tipo_Cambio(oLis).Rows(0).Item("IVNTA").ToString.Trim
            UcPorRevision.lblTipoCambio_1.Text = UcPorOperacion.lblTipoCambio_1.Text
        Else
            UcPorOperacion.lblTipoCambio_1.Text = "0"
            UcPorRevision.lblTipoCambio_1.Text = "0"
        End If
        chkFecha.Checked = True

        UcPorOperacion.btnQuitaConsistencia.Visible = False
        UcPorOperacion.btnFacturaElectronica.Visible = chkPorRevision.Checked
        'UcPorOperacion.btnRevisado.Visible = False

    End Sub

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = pUsuario
        UcDivision.pActualizar()

    End Sub

    Private Sub chkPoOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPoOperacion.CheckedChanged
        Me.lblBusqueda.Text = "Nr. Operación :"
        Me.chkFecha.Text = "Rango Operación :"
        Me.UcPorOperacion.Visible = True
        UcPorRevision.Visible = False
        UcPorOperacion.Dock = DockStyle.Fill
        VisualizarControles(True)
        cmbEstadoFactura_SelectedIndexChanged(Nothing, Nothing)
        If UcCliente.pCodigo > 0 Then RealizarBusqueda()
        txtOperacion.Text = String.Empty


        Visible_Control()
        UcPorOperacion.btnQuitaConsistencia.Visible = False
        UcPorOperacion.btnFacturaElectronica.Visible = chkPorRevision.Checked
        'UcPorOperacion.btnRevisado.Visible = False
        'UcPorRevision.btnRevisado.Visible = False
    End Sub

    Private Sub chkPorRevision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorRevision.CheckedChanged
        Me.lblBusqueda.Text = "Nr. Revisión :"
        Me.chkFecha.Text = "Rango Revisión :"
        Me.UcPorOperacion.Visible = False
        UcPorRevision.Visible = True
        UcPorRevision.Dock = DockStyle.Fill
        VisualizarControles(False)
        cmbEstadoFactura_SelectedIndexChanged(Nothing, Nothing)
        If UcCliente.pCodigo > 0 Then RealizarBusqueda()
        txtOperacion.Text = String.Empty
        Visible_Control()

        UcPorOperacion.btnQuitaConsistencia.Visible = True
        UcPorOperacion.btnFacturaElectronica.Visible = chkPorRevision.Checked
        'UcPorOperacion.btnRevisado.Visible = False
        'UcPorRevision.btnRevisado.Visible = False

    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar

        If chkPoOperacion.Checked Then
            UcPorOperacion.Limpiar_Grilla_Servicio()
            UcPorOperacion.Limpiar_Detalle_Servicios()
            UcPorOperacion.InhabilitaTabs()
            UcPorOperacion.HabilitaTabs(UcDivision.Division)

        Else
            UcPorRevision.LimpiarDetalleRevision()
            UcPorRevision.Limpiar_Revision()
        End If
        HGDatos.ValuesSecondary.Heading = "--"
        CargarPlanta()
        CargarTipoServicio()

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

    Private Sub chkFechaOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaOperacion.CheckedChanged

        If chkFechaOperacion.Checked Then
            dtpFechaOperacionIni.Enabled = True
            dtpFechaOperacionFin.Enabled = True
        Else
            dtpFechaOperacionIni.Enabled = False
            dtpFechaOperacionFin.Enabled = False
        End If

    End Sub

    Private Sub cmbEstadoFactura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoFactura.SelectedIndexChanged
        Try
            If cmbEstadoFactura.SelectedIndex = 1 Then

                VisualizarTipoFacturado(False)

            Else
                If cmbEstadoFactura.SelectedIndex = 2 Then

                    VisualizarTipoFacturado(True)

                Else

                    VisualizarTipoFacturado(False)

                End If
            End If

            If chkPoOperacion.Checked Then
                UcPorOperacion.Limpiar_Grilla_Servicio()
                UcPorOperacion.Limpiar_Detalle_Servicios()
            Else
                UcPorRevision.Limpiar_Revision()
                UcPorRevision.LimpiarDetalleRevision()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub txtOperacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOperacion.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                RealizarBusqueda()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtOperacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperacion.TextChanged
        Try
            If txtOperacion.Text.Trim.Length = 0 Then
                RealizarBusqueda()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Metodos y Funciones"

    Private Sub CargarInformacion()
        'Cargamos compania por usuario
        UcCompania.Usuario = pUsuario
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(pCompaniaActual)
    End Sub

    ''' <summary>
    ''' Cambiamos el estado de visibilidad de los controles dependiendo del tipo de visualizacion
    ''' </summary>
    ''' <param name="bolEstado"></param>
    ''' <remarks></remarks>
    Private Sub VisualizarControles(ByVal bolEstado As Boolean)
        lblProceso.Visible = bolEstado
        cmbProceso.Visible = bolEstado
        'lblServicio.Visible = bolEstado
        'cmbServicio.Visible = bolEstado
        lblTipoServicio.Visible = bolEstado
        cmbTipoServicio.Visible = bolEstado

        chkFechaOperacion.Visible = bolEstado
        lblDe02.Visible = bolEstado
        dtpFechaOperacionIni.Visible = bolEstado
        lblA02.Visible = bolEstado
        dtpFechaOperacionFin.Visible = bolEstado

        lblOc.Visible = bolEstado
        txtOrdenCompra.Visible = bolEstado


        blnrovlr.Visible = bolEstado
        txtnrovlr.Visible = bolEstado
        lbldocvlr.Visible = bolEstado
        txtdocvlr.Visible = bolEstado

        If bolEstado Then
            HGDatos.ValuesSecondary.Heading = "" & UcPorOperacion.sTotalDatosPorOperacion & ""
        Else
            HGDatos.ValuesSecondary.Heading = "" & UcPorRevision.sTotalDatosPorRevision & ""
        End If
    End Sub

    Private Sub Carga_Estado()
        oEstadoFactura.Estado_Servicio()
        bolBuscar = False
        cmbEstadoFactura.DataSource = oEstadoFactura.Tabla
        cmbEstadoFactura.ValueMember = "COD"
        bolBuscar = True
        cmbEstadoFactura.DisplayMember = "TEX"
        cmbEstadoFactura.SelectedValue = "N"

    End Sub

    Public Sub CargarTipoServicio()
        Dim oDtProceso As New DataTable
        bolBuscar = False
        oDtProceso = oServicioOpeNeg.ListaServiciosEsp(UcDivision.Division, 1)

        If oDtProceso IsNot Nothing Then
            oDtProceso = oServicioOpeNeg.ListaServiciosEsp(UcDivision.Division, 1)
            oDtProceso.DefaultView.RowFilter = "SMARCA NOT IN (4)"
            oDtProceso = oDtProceso.DefaultView.ToTable
            Me.cmbTipoServicio.DataSource = oDtProceso
            Me.cmbTipoServicio.ValueMember = "CCMPRN"
            bolBuscar = True
            Me.cmbTipoServicio.SelectedValue = "0"
            Me.cmbTipoServicio.DisplayMember = "TDSDES"
        Else
            Me.cmbTipoServicio.DataSource = Nothing
        End If


    End Sub

    Private Sub UcCliente_InformationChanged() Handles UcCliente.InformationChanged
        Try
            'Carga_Servicios()
            'CargarLotes()
            RealizarBusqueda()
            Visible_Control()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Visible_Control()
        Dim objCliente As New Ransa.Controls.Cliente.TD_ClientePK
        Dim daoCliente As New Ransa.Controls.Cliente.FCliente
        Dim TipoDoc As String = ""
        If UcCliente.pCodigo <> 0 Then
            objCliente.pCCLNT_Cliente = UcCliente.pCodigo
            objCliente.pCCMPN_CodigoCompania = UcCompania.CCMPN_CodigoCompania

            TipoDoc = daoCliente.ObtenerFacturaCliente(objCliente)
            If chkPoOperacion.Checked = True Then
                Visible_Fac_Operacion(TipoDoc)
            Else
                Visible_Fac_Revision(TipoDoc)
            End If
        Else
            If chkPoOperacion.Checked = True Then
                Visible_Fac_Operacion(TipoDoc)
            Else
                Visible_Fac_Revision(TipoDoc)
            End If
        End If
    End Sub

    Private Sub Visible_Fac_Operacion(ByVal TipoDoc As String)
        Dim DOC As String = TipoDoc.Trim
        If pFacturacionElectronica = 1 Then
            'If DOC = "PT" Then    'Parte Transferencia
            '    'UcPorOperacion.btnParteTransferencia.Visible = True
            '    'UcPorOperacion.btnBoletaElectronica.Visible = False
            '    UcPorOperacion.btnFacturaElectronica.Visible = False
            'ElseIf DOC = "LE" Then 'Boleta Elect.
            '    'UcPorOperacion.btnParteTransferencia.Visible = False
            '    UcPorOperacion.btnFacturaElectronica.Visible = False
            '    'UcPorOperacion.btnBoletaElectronica.Visible = True
            'Else 'Factura Elect.
            '    'UcPorOperacion.btnParteTransferencia.Visible = False
            '    'UcPorOperacion.btnBoletaElectronica.Visible = False
            '    UcPorOperacion.btnFacturaElectronica.Visible = True
            'End If
            UcPorOperacion.btnFacturaElectronica.Visible = True

            'UcPorOperacion.btnFacturar.Visible = False
            'UcPorOperacion.btnBoleta.Visible = False
        Else
            If DOC = "PT" Then    'Parte Transferencia

                'UcPorOperacion.btnBoleta.Visible = False
                'UcPorOperacion.btnFacturar.Visible = False
            ElseIf DOC = "LE" Then   'Boleta
                'UcPorOperacion.btnBoleta.Visible = True

                'UcPorOperacion.btnFacturar.Visible = False
            Else '  Factura
                'UcPorOperacion.btnFacturar.Visible = True

                'UcPorOperacion.btnBoleta.Visible = False
            End If
            UcPorOperacion.btnFacturaElectronica.Visible = False

        End If

    End Sub



    Private Sub Visible_Fac_Revision(ByVal TipoDoc As String)
        Dim DOC As String = TipoDoc.Trim
        If pFacturacionElectronica = 1 Then

            UcPorRevision.btnFacturaElectronica.Visible = True
            'UcPorRevision.btnFacturar.Visible = False
            'UcPorRevision.btnBoleta.Visible = False
        Else
            'If DOC = "PT" Then    'Parte Transferencia

            '    'UcPorRevision.btnBoleta.Visible = False
            '    'UcPorRevision.btnFacturar.Visible = False
            'ElseIf DOC = "LE" Then   'Boleta
            '    UcPorRevision.btnBoleta.Visible = True

            '    UcPorRevision.btnFacturar.Visible = False
            'Else '  Factura
            '    UcPorRevision.btnFacturar.Visible = True

            '    UcPorRevision.btnBoleta.Visible = False
            'End If
            UcPorRevision.btnFacturaElectronica.Visible = False

        End If





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

    Private Sub CargarPlanta()

        Dim oDtAux As New DataTable
        Dim oDr As DataRow

        oDtAux.Columns.Add("CPLNDV", GetType(String))
        oDtAux.Columns.Add("TPLNTA", GetType(String))


        oDtPlanta = oPlanta.Lista_Planta_Division(UcCompania.CCMPN_CodigoCompania, UcDivision.Division)
        For Each dr As DataRow In oDtPlanta.Rows
            oDr = oDtAux.NewRow
            oDr("CPLNDV") = dr("CPLNDV")
            oDr("TPLNTA") = dr("TPLNTA")
            oDtAux.Rows.Add(oDr)
        Next
        oDtPlanta = oDtAux
        cmbPlanta.ValueMember = "CPLNDV"
        cmbPlanta.DisplayMember = "TPLNTA"
        cmbPlanta.DataSource = oDtPlanta
        For i As Integer = 0 To cmbPlanta.Items.Count - 1
            If cmbPlanta.Items.Item(i).Value = "0" Then
                cmbPlanta.SetItemChecked(i, True)
            End If
        Next


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

    Private Sub ObtenerFiltros(ByVal bolTipo As Boolean)
        oDtSerivcio = New DataTable
        oServicio = New Servicio_BE
        oServicio.TIPO_PROCESO = Lista_Tipo_Proceso()
        oServicio.CCLNT = UcCliente.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo
        'oServicio.TLUGEN = IIf(cmbLugarEntrega.SelectedIndex > 0, cmbLugarEntrega.SelectedValue, "")
        oServicio.TLUGEN = ""

        If bolTipo Then
            If Me.chkFecha.Checked Then
                oServicio.FECINI = Comun.FormatoFechaAS400(Me.dtFeInicial.Text)
                oServicio.FECFIN = Comun.FormatoFechaAS400(Me.dtFeFinal.Text)
            Else
                oServicio.FECINI = 0
                oServicio.FECFIN = 99999999
            End If

            If chkFechaOperacion.Checked Then
                oServicio.FECSERV_INI = Comun.FormatoFechaAS400(Me.dtpFechaOperacionIni.Text)
            Else
                oServicio.FECSERV_INI = 0
                oServicio.FECSERV_FIN = 0
            End If
            oServicio.NORCML = txtOrdenCompra.Text.Trim
        Else
            oServicio.FECINI = 0
            oServicio.FECFIN = 99999999
            oServicio.FECSERV_INI = 0
            oServicio.FECSERV_FIN = 0
            oServicio.TLUGEN = ""
            oServicio.NORCML = ""
        End If

        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.CDVSN = UcDivision.Division
        oServicio.TIPO_PLANTA = Lista_Tipo_Planta()



        oServicio.FLGFAC = Me.cmbEstadoFactura.SelectedValue

        'oServicio.NRTFSV = Me.cmbServicio.SelectedValue
        oServicio.NRTFSV = 0

        oServicio.FLGPEN = "S"

        oServicio.CTPALJ = cmbTipoServicio.SelectedValue
        If chkPoOperacion.Checked Then
            oServicio.NOPRCN = IIf(txtOperacion.Text.Length > 0, txtOperacion.Text, 0)
            oServicio.NSECFC = 0
        Else
            oServicio.NSECFC = IIf(txtOperacion.Text.Length > 0, txtOperacion.Text, 0)
            oServicio.NOPRCN = 0
        End If

        If chkPoOperacion.Checked Then
            oServicio.NROVLR = Val(txtnrovlr.Text.Trim)
            oServicio.DOCVLR = txtdocvlr.Text.Trim
        Else
            oServicio.NROVLR = 0
            oServicio.DOCVLR = ""
        End If



    End Sub

    Private Sub Llenar_ServiciosOperacion(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal bolTipo As Boolean)
        Try

            ObtenerFiltros(bolTipo)
            If bolTipo Then

                If oServicio.FLGFAC = "N" Then
                    dtg.Columns("NDCCTC").Visible = False
                Else
                    dtg.Columns("NDCCTC").Visible = True

                End If

            Else

                If chkPorRevision.Checked Then oServicio.NSECFC = Val(UcPorRevision.dtgFacturacion.CurrentRow.Cells("NSECFC1").Value)


            End If


            oDtSerivcio = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)

            dtg.AutoGenerateColumns = False
            dtg.DataSource = oDtSerivcio
            oServicio.NSECFC = 0
            If bolTipo Then
                HGDatos.ValuesSecondary.Heading = UcPorOperacion.sTotalDatosPorOperacion
            Else
                HGDatos.ValuesSecondary.Heading = UcPorRevision.sTotalDatosPorRevision
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub LenarServiciosRevision()
        ObtenerFiltros(True)

        oDtSerivcio = oServicioOpeNeg.Lista_OperacionesRevisadas(oServicio)
        UcPorRevision.dtgFacturacion.AutoGenerateColumns = False
        UcPorRevision.dtgFacturacion.DataSource = oDtSerivcio

        HGDatos.ValuesSecondary.Heading = UcPorRevision.sTotalDatosPorRevision

    End Sub

    Private Function Lista_Tipo_Proceso() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbProceso.CheckedItems.Count - 1
            For j As Integer = 0 To oDtTiposDocumentos.Rows.Count - 1
                If (oDtTiposDocumentos.Rows(j).Item("SMARCA") = cmbProceso.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtTiposDocumentos.Rows(j).Item("SMARCA") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

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

    Public Sub RealizarBusqueda()
        If chkPoOperacion.Checked Then
            Listar_Operaciones(Nothing, UcPorOperacion.dtgOperaciones)
        Else
            Listar_Revisiones(Nothing)
        End If
    End Sub

    Private Sub Listar_Operaciones(ByVal oServicio As Servicio_BE, ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UcPorOperacion.Listar_Operaciones

        Try
            oServicio = New Servicio_BE

            UcPorOperacion._pTipoAlmacen = _pTipoAlmacen
            oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
            oServicio.PSUSUARIO = pUsuario
            oServicio.CDVSN = UcDivision.Division
            oServicio.CCLNT = UcCliente.pCodigo
            oServicio.CCLNFC = UcClienteFact.pCodigo
            oServicio.FLGPEN = "S"

            oServicio.FLGFAC = cmbEstadoFactura.SelectedValue
            oServicio.TCMPDV = UcDivision.DivisionDescripcion

            If Me.chkFecha.Checked Then
                oServicio.FechaInicio = dtFeInicial.Value
                oServicio.FechaFin = dtFeFinal.Value
            End If

            oServicio.CCMPN_DESC = UcCompania.CCMPN_Descripcion
            oServicio.CDVSN_DESC = UcDivision.DivisionDescripcion
            oServicio.CCLNT_DESC = UcCliente.pRazonSocial

            oServicio.NROVLR = Val(txtnrovlr.Text.Trim)
            oServicio.DOCVLR = txtdocvlr.Text.Trim

            UcPorOperacion.oServicio = oServicio

            Llenar_ServiciosOperacion(dtg, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub Listar_Control_Revision_Operaciones(ByVal oServicio As Servicio_BE, ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UcPorRevision.Listar_Operaciones
        Try
            Llenar_ServiciosOperacion(dtg, False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Listar_Revisiones(ByVal oServicio As Servicio_BE) Handles UcPorRevision.Listar_Revisiones
        oServicio = New Servicio_BE

        UcPorRevision._pTipoAlmacen = _pTipoAlmacen
        oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        oServicio.PSUSUARIO = pUsuario
        oServicio.CDVSN = UcDivision.Division
        oServicio.CCLNT = UcCliente.pCodigo
        oServicio.CCLNFC = UcClienteFact.pCodigo
        oServicio.FLGPEN = "S"

        oServicio.FLGFAC = cmbEstadoFactura.SelectedValue
        oServicio.TCMPDV = UcDivision.DivisionDescripcion

        If Me.chkFecha.Checked Then
            oServicio.FechaInicio = dtFeInicial.Value
            oServicio.FechaFin = dtFeFinal.Value
        End If


        oServicio.CCMPN_DESC = UcCompania.CCMPN_Descripcion
        oServicio.CDVSN_DESC = UcDivision.DivisionDescripcion
        oServicio.CCLNT_DESC = UcCliente.pRazonSocial

        UcPorRevision.oServicio = oServicio
        LenarServiciosRevision()




    End Sub

    'Private Sub Procesar_Control_Consistencia_Operacion(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UcPorOperacion.Procesar_Consistencias
    '    Try
    '        Procesar_Consistencia(dtg)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub Procesar_Control_Consistencia_Revision(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UcPorRevision.Procesar_Consistencias
    '    Try
    '        Procesar_Consistencia(dtg)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub Anular_Control_Consistencia_Revision(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UcPorOperacion.Anular_Revision
    '    Try
    '        Anular_Revision(dtg)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub Anular_Control_Revision_Revision(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UcPorRevision.Anular_Revision
        Try
            Anular_Revision(dtg)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function validarInformacionCliente(ByVal dtgOperaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) As Boolean
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
        Dim oDtRevision As New DataTable
        Dim PLANTA1 As String = ""
        Dim PLANTA2 As String = ""


        '=================Valida que este marcado y que pertenezca a la misma Region Venta===============
        For intCont = 0 To dtgOperaciones.Rows.Count - 1
            If Convert.ToBoolean(dtgOperaciones.Rows(intCont).Cells("chk").Value) = True Then
                intProcesado = intProcesado + 1
                If intProcesado = 1 Then
                    cliFacPri = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                    cliOpePri = dtgOperaciones.Rows(intCont).Cells("CCLNFC").Value
                    cliComp1 = cliFacPri.ToString & "-" & cliOpePri.ToString
                    opeRG1 = dtgOperaciones.Rows(intCont).Cells("CRGVTA").Value

                    oServicio.TIPO_REV = dtgOperaciones.Rows(intCont).Cells("TIPO_REV").Value
                    If oServicio.TIPO_REV = "1" Then

                        oServicio.NSECFC = dtgOperaciones.Rows(intCont).Cells("NSECFC1").Value
                        oDtRevision = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)
                        If oDtRevision.Rows.Count > 0 Then
                            valCTPALJ1 = oDtRevision.Rows(0).Item("CTPALJ")
                        End If
                        PLANTA1 = dtgOperaciones.Rows(intCont).Cells("CPLNDV1").Value
                    Else
                        valCTPALJ1 = dtgOperaciones.Rows(intCont).Cells("CTPALJ").Value
                        PLANTA1 = dtgOperaciones.Rows(intCont).Cells("CPLNDV").Value
                    End If


                    valCMNDA1 = dtgOperaciones.Rows(intCont).Cells("CMNDA1").Value
                Else
                    cliFacSig = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                    cliOpeSig = dtgOperaciones.Rows(intCont).Cells("CCLNFC").Value
                    cliComp2 = cliFacSig.ToString & "-" & cliOpeSig.ToString
                    opeRG2 = dtgOperaciones.Rows(intCont).Cells("CRGVTA").Value

                    If oServicio.TIPO_REV = "1" Then
                        oServicio.NSECFC = dtgOperaciones.Rows(intCont).Cells("NSECFC1").Value
                        oDtRevision = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)

                        If oDtRevision.Rows.Count > 0 Then
                            valCTPALJ2 = oDtRevision.Rows(0).Item("CTPALJ")
                        End If
                        PLANTA2 = dtgOperaciones.Rows(intCont).Cells("CPLNDV1").Value
                    Else
                        valCTPALJ2 = dtgOperaciones.Rows(intCont).Cells("CTPALJ").Value
                        PLANTA2 = dtgOperaciones.Rows(intCont).Cells("CPLNDV").Value
                    End If


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

                    End If
                End If

                If PLANTA1 <> PLANTA2 And intProcesado > 1 Then
                    MsgBox("Las Plantas deben ir juntas", MsgBoxStyle.Information)
                    b = False
                    Exit For
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

    'Private Sub Procesar_Consistencia(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
    '    Dim dblCodigo As Double
    '    Dim intCont As Integer


    '    dtg.CommitEdit(DataGridViewDataErrorContexts.Commit)
    '    If validarInformacionCliente(dtg) = False Then
    '        Exit Sub
    '    End If

    '    '=========Validamos si esta provisionado
    '    Dim obeServicio As Servicio_BE
    '    Dim olstServicio As New List(Of Servicio_BE)
    '    For intCont = 0 To dtg.Rows.Count - 1
    '        If Convert.ToBoolean(dtg.Rows(intCont).Cells("chk").Value) = True Then
    '            obeServicio = New Servicio_BE
    '            oServicio.TIPO_REV = dtg.Rows(intCont).Cells("TIPO_REV").Value
    '            obeServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
    '            obeServicio.CDVSN = UcDivision.Division
    '            obeServicio.CPLNDV = cmbPlanta.SelectedValue
    '            obeServicio.CCLNT = dtg.Rows(intCont).Cells("CCLNT").Value
    '            If oServicio.TIPO_REV = "1" Then
    '                obeServicio.NSECFC = dtg.Rows(intCont).Cells("NSECFC1").Value
    '                obeServicio.TIPO_REV = "1"
    '            Else
    '                obeServicio.NOPRCN = dtg.Rows(intCont).Cells("NOPRCN").Value
    '                obeServicio.NSECFC = dtg.Rows(intCont).Cells("NSECFC").Value
    '                obeServicio.TIPO_REV = "2"
    '            End If

    '            olstServicio.Add(obeServicio)
    '        End If
    '    Next
    '    If fblnValidarProvision(olstServicio) Then Exit Sub
    '    '=========Validamos si esta provisionado

    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    dblCodigo = oServicioOpeNeg.ObtenerCodigoConsistencia.Rows(0).Item("NULCTR")
    '    For intCont = 0 To dtg.Rows.Count - 1
    '        If Convert.ToBoolean(dtg.Rows(intCont).Cells("chk").Value) = True Then
    '            oServicio.TIPO_REV = dtg.Rows(intCont).Cells("TIPO_REV").Value
    '            If oServicio.TIPO_REV = "1" Then
    '                oServicio.NSECFC_UPD = dblCodigo
    '                oServicio.NSECFC = dtg.Rows(intCont).Cells("NSECFC1").Value
    '            Else
    '                oServicio.NOPRCN = dtg.Rows(intCont).Cells("NOPRCN").Value
    '                oServicio.NSECFC = dblCodigo
    '            End If
    '            oServicioOpeNeg.ActualizarServicio_Atendido(oServicio)
    '        End If
    '    Next intCont
    '    oServicio.NOPRCN = 0
    '    oServicio.NSECFC = 0
    '    MsgBox("Se genero el Nro. de Consistencia: " & CStr(dblCodigo), MsgBoxStyle.Information)
    '    Me.Cursor = System.Windows.Forms.Cursors.Default

    'End Sub


    Private Sub Anular_Revision(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
        AnularConsistencias(dtg)
    End Sub

    'Private Function fblnValidarAccionLiquidacionServicios(ccmpn As String, cdvsn As String, cclnt As Decimal, usuario As String, strListadoConsistencia As String, strListadoOperacion As String) As Boolean
    '    Dim oClsServicioBL As New clsServicio_BL
    '    Dim EsValido As Boolean = True
    '    Dim dtOPValorizada As New DataTable
    '    Dim TieneAccesoAccionOPValorizada As Boolean = False
    '    dtOPValorizada = oClsServicioBL.ListarValorizacionOperacion(ccmpn, cdvsn, cclnt, strListadoOperacion, strListadoConsistencia)
    '    If dtOPValorizada.Rows.Count > 0 Then
    '        TieneAccesoAccionOPValorizada = oClsServicioBL.ValidarAccesoModificarOpValorizada(ccmpn, usuario)
    '        If TieneAccesoAccionOPValorizada = True Then
    '            If MessageBox.Show("La(s) operación(es) se encuentra(n) valorizada(s) " & Chr(13) & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
    '                EsValido = False
    '            Else
    '                EsValido = True
    '            End If
    '        Else
    '            MessageBox.Show("La(s) operación(es) se encuentra(n) valorizada(s) " & Chr(13) & " No tiene permiso para ejecutar la acción.")
    '            EsValido = False
    '        End If
    '    End If

    '    Return EsValido
    'End Function


    Private Sub AnularConsistencias(ByVal dtgOperaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
        Dim intCont As Integer
        'Dim intProcesado As Integer = 0
        Dim strConsistencias As String = ""
        Dim strOperaciones As String = ""
        '=========Validamos si esta provisionado
        Dim obeServicio As Servicio_BE
        Dim olstServicio As New List(Of Servicio_BE)
        Dim JsConsistencias As Dictionary(Of String, Object)
        Dim listJsConsistencias As New List(Of Dictionary(Of String, Object))
        Dim listItemsE As New SortedList


        For intCont = dtgOperaciones.RowCount - 1 To 0 Step -1
            If Convert.ToBoolean(dtgOperaciones.Rows(intCont).Cells("chk").Value) = True Then

                If dtgOperaciones.Rows(intCont).Cells("NPRELIQ").Value <> 0 Then
                    MessageBox.Show("No puede anular consistencia con PL.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                 
                obeServicio = New Servicio_BE
                obeServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
                obeServicio.CDVSN = UcDivision.Division
                obeServicio.CPLNDV = cmbPlanta.SelectedValue
                obeServicio.CCLNT = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                obeServicio.NSECFC = dtgOperaciones.Rows(intCont).Cells("NSECFC1").Value
                obeServicio.TIPO_REV = "1"
                strConsistencias = strConsistencias & "," & obeServicio.NSECFC                 
                listItemsE.Add(intCont.ToString, intCont.ToString)
                JsConsistencias = New Dictionary(Of String, Object)
                JsConsistencias.Add("NSECFC", obeServicio.NSECFC)
                listJsConsistencias.Add(JsConsistencias)
                olstServicio.Add(obeServicio)
            End If
        Next

        If olstServicio.Count = 0 Then
            MessageBox.Show("No hay Registro habilitado para Anular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If olstServicio.Count > 1 Then
            MessageBox.Show("Seleccionar solo una consistencia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If listJsConsistencias.Count > 0 Then

            Dim StrJsonSecValid As String = ""
            StrJsonSecValid = JsonConvert.SerializeObject(listJsConsistencias)
            obeServicio = New Servicio_BE
            obeServicio.CCMPN = olstServicio(0).CCMPN
            obeServicio.CDVSN = olstServicio(0).CDVSN
            obeServicio.CCLNT = olstServicio(0).CCLNT
            obeServicio.LISTJSON = StrJsonSecValid
            Dim estadovalid As String = ""
            Dim msgvalid As String = ""
            oServicioOpeNeg.validar_anulacion_consistencia(oServicio, estadovalid, msgvalid)
            If estadovalid = "A" Then
                If MessageBox.Show(msgvalid & "Desea continuar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            If estadovalid = "E" Then
                MessageBox.Show(msgvalid, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim StrJsonSecFact As String = ""
            StrJsonSecFact = JsonConvert.SerializeObject(listJsConsistencias)
            obeServicio = New Servicio_BE
            oServicio.NTRMNC = HelpClass.NombreMaquina()
            oServicio.CCMPN = olstServicio(0).CCMPN
            oServicio.LISTJSON = StrJsonSecFact
            Dim nroConsistencia As Decimal = 0
            oServicioOpeNeg.AnularConsistenciaMasivo(oServicio)
            For intCont = dtgOperaciones.RowCount - 1 To 0 Step -1
                If listItemsE.Contains(intCont.ToString) Then
                    dtgOperaciones.Rows.RemoveAt(intCont)
                End If              
            Next
            Estimacion_Ingreso_Revertir(StrJsonSecFact)         
            MessageBox.Show("Se Anuló correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            'If intProcesado = 0 Then
            '    MessageBox.Show("No hay Registro habilitado para Anular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return
            'End If

        End If
    
        'MsgBox("Se Anuló correctamente")


    End Sub


    'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
    Private Sub Estimacion_Ingreso_Revertir(ListJSSecFact As String)
        Dim oDt As DataTable
        Dim oFiltro As New Filtro_BE
        Dim oFacturaNeg As New clsFactura_BL  'CSR-HUNDRED-ESTIMACION-INGRESO
        'oFiltro.Parametro1 = UcCompania.CCMPN_CodigoCompania 'Compañía
        'oFiltro.Parametro12 = 0 'Tipo de Documento
        'oFiltro.Parametro13 = 0 'Nro. Documento 
        'oFiltro.Parametro14 = oServicio.NSECFC 'Nro. Revisión
        'Public Function Estimacion_Ingreso_RevertirMasivo(tipo As String, oServ As Servicio_BE) As DataTable

        If ListJSSecFact = "" Then Exit Sub

        Dim oServ As New Servicio_BE
        oServ.CCMPN = ""
        oServ.CTPODC = 0
        oServ.NDCCTC = 0
        oServ.LISTJSON = ListJSSecFact
        oDt = oFacturaNeg.Estimacion_Ingreso_RevertirMasivo("NSECF", oServ)


        'Invocar el Servicio Web con los parametros devueltos del SP
        If oDt.Rows.Count > 0 Then
            Dim IdEstimacion As Double, AnioContaSap As Double, FechaDocCtaCte As Double
            Dim NroDocEstimacionSap As String, CodSociedadSap As String, NumDocElectronico As String


            Dim dt_url_servicio As New DataTable
            Dim oda_url_servicio As New ClsUrlWServicio
            dt_url_servicio = oda_url_servicio.Listar_Url_Servicio("SDESTSAPSALM", "", "", 0)
            Dim url_ws_servicio As String = ""
            If dt_url_servicio.Rows.Count > 0 Then
                url_ws_servicio = ("" & dt_url_servicio.Rows(0)("URL")).ToString.Trim
            End If

            'se adiciono redirecion url  20201007

            For index As Integer = 0 To oDt.Rows.Count - 1
                IdEstimacion = oDt.Rows(index).Item("IDESTM")
                NroDocEstimacionSap = oDt.Rows(index).Item("NDESAP").ToString.Trim
                CodSociedadSap = oDt.Rows(index).Item("CSCDSP").ToString.Trim
                AnioContaSap = oDt.Rows(index).Item("ACNTSP")
                NumDocElectronico = oDt.Rows(index).Item("NDCCTE").ToString.Trim
                FechaDocCtaCte = oDt.Rows(index).Item("FDCFCC")
                'INI-ECM-ActualizacionTarifario[RF001]-160516
                Dim wssalmon As New ws_reversion_Ingreso.ws_salmon

                wssalmon.Url = url_ws_servicio

                wssalmon.ws_reversion_ingreso(IdEstimacion, CodSociedadSap, NroDocEstimacionSap, AnioContaSap, NumDocElectronico, FechaDocCtaCte)
                'FIN-ECM-ActualizacionTarifario[RF001]-160516
            Next

        End If


        'Return oDtNew
    End Sub
    Private Sub FacturarPorOperacion(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer) Handles UcPorOperacion.Facturar
        RaiseEvent FacturarConsistencia(olOperacion, Tipo)
    End Sub

    Private Sub FacturarPorRevision(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer) Handles UcPorRevision.Facturar
        RaiseEvent FacturarConsistencia(olOperacion, Tipo)
    End Sub

    Private Sub BoletaPorOperacion(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer) Handles UcPorOperacion.Boleta
        RaiseEvent GenerarBoletaConsistencia(olOperacion, Tipo)
    End Sub

    Private Sub BoletaPorRevision(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer) Handles UcPorRevision.Boleta
        RaiseEvent GenerarBoletaConsistencia(olOperacion, Tipo)
    End Sub

#Region "Facturacion Electronica"

    Private Sub FacturarElectronicaPorOperacion(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer, pTipoLista As Ransa.Utilitario.HelpClass.TipoLista) Handles UcPorOperacion.FacturarElectronica
        RaiseEvent FacturarElectronicaConsistencia(olOperacion, Tipo, pTipoLista)
    End Sub

    Private Sub FacturarElectronicaPorRevision(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer, pTipoLista As Ransa.Utilitario.HelpClass.TipoLista) Handles UcPorRevision.FacturarElectrinica
        RaiseEvent FacturarElectronicaConsistencia(olOperacion, Tipo, pTipoLista)
    End Sub


#End Region

#Region "Parte Transferencia"

    'Private Sub ParteTransfereciaPorOperacion(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer) Handles UcPorOperacion.ParteTransferencia
    '    RaiseEvent ParteTransferenciaConsistencia(olOperacion, Tipo)
    'End Sub
    'Private Sub ParteTransfereciaPorRevision(ByVal olOperacion As List(Of Servicio_BE), ByVal Tipo As Integer) Handles UcPorRevision.ParteTransferencia
    '    RaiseEvent ParteTransferenciaConsistencia(olOperacion, Tipo)
    'End Sub



#End Region



    Private Sub VisualizarTipoFacturado(ByVal bolVisible As Boolean)

        If chkPoOperacion.Checked Then
            'UcPorOperacion.btnRevisado.Visible = bolVisible
            UcPorOperacion.btnQuitaConsistencia.Visible = bolVisible
            UcPorOperacion.btnAdjuntar.Visible = bolVisible
            UcPorOperacion.btnAgregarDetalle.Visible = bolVisible
            UcPorOperacion.btnEliminarDetalle.Visible = bolVisible
            'UcPorOperacion.btnFacturar.Visible = bolVisible
            'UcPorOperacion.btnModificar.Visible = bolVisible

            UcPorOperacion.ToolStripButton3.Visible = bolVisible

        Else
            UcPorRevision.btnQuitaConsistencia.Visible = bolVisible
            'UcPorRevision.btnRevisado.Visible = bolVisible
            UcPorRevision.btntrasladar.Visible = bolVisible
            'UcPorRevision.btnFacturar.Visible = bolVisible

        End If
        Visible_Control()
    End Sub

    'Private Sub CargarLotes()
    '    If UcCliente.pCodigo > 0 Then
    '        Dim oServicioOpeNeg As New clsServicio_BL
    '        Me.cmbLugarEntrega.DataSource = oServicioOpeNeg.ListarLotes(UcCliente.pCodigo)
    '        Me.cmbLugarEntrega.ValueMember = "TLTECL"
    '        Me.cmbLugarEntrega.DisplayMember = "TLTECL"
    '        cmbLugarEntrega.ComboBox.SelectedIndex = 0
    '    End If

    'End Sub


#End Region


    'Private Function fblnValidarProvision(ByVal olstServicio As List(Of Servicio_BE)) As Boolean
    '    Dim intResultado As Integer = 0
    '    ddddd()

    '    For Each obeServicio As Servicio_BE In olstServicio
    '        intResultado = oServicioOpeNeg.intTieneProvision(obeServicio)
    '        Select Case intResultado
    '            Case 0
    '                Ransa.Utilitario.HelpClass.ErrorMsgBox()
    '            Case 2
    '                'Validamos si el Usuario tiene permiso para Anular la provisión
    '                'Try
    '                If oServicioOpeNeg.fblnUsuarioPermitidoRevertirProvision(ConfigurationWizard.UserName) Then
    '                    If obeServicio.TIPO_REV = "1" Then
    '                        If MsgBox("La Revisión :" & obeServicio.NSECFC & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
    '                            Return True
    '                            Me.Cursor = System.Windows.Forms.Cursors.Default
    '                            Return True
    '                        End If
    '                    Else
    '                        If MsgBox("La Operación :" & obeServicio.NOPRCN & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
    '                            Me.Cursor = System.Windows.Forms.Cursors.Default
    '                            Return True
    '                        End If
    '                    End If
    '                Else
    '                    'Usuario No puede Generar un revisado o Eliminar la provisión
    '                    MsgBox("Usted no tiene  autorización para administrar la" & IIf(obeServicio.TIPO_REV = "1", "  revisión :" & obeServicio.NSECFC, "  operación :" & obeServicio.NOPRCN) & " porque se encuentra provisionada.")
    '                    Return True
    '                End If

    '        End Select
    '    Next

    '    FFFFF()
    '    Return False
    'End Function

End Class



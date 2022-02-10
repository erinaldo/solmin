Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO

Imports Newtonsoft.Json
Imports System.Net
Imports System.Globalization

Public Class frmSeguimientoEmbarqueIM


#Region "Atributos"
    Private oEmbarque As clsEmbarque
    Private oDocApertura As clsDocApertura
    Private oAgenteCarga As clsAgenteCarga
    Private oTerminal As clsTerminal
    Private oEstado As clsEstado
    Private oMultiTabla As clsMultiTabla
    Private oVapor As clsVapor
    Private oZona As clsZona
    Private oDtCiaTran As DataTable
    Private oMoneda As clsMoneda
    Private bolBuscarSegAdu As Boolean
    Private dblEmbSelec As Double
    Private dblEmbarqueGrilla As Double
    Private objDtDia As DataTable
    Private oNoLaborable As clsNoLaborable
    Private intPosicion As Integer
    Private oBanco As clsBanco
    Private TabActivo As Double = 0
    Private oTab As clsTab
    Private bolEstadoCombos As Boolean = True

    Private _STSCHG1 As Boolean
    Private objEntidadAcceso As New Entidad.beAcceso

    Dim NameColumna As String = ""
    Dim IndexColumna As Int32 = 0
    Dim FilaEmbarque As Int32 = 0
    Private oHebra As Thread
    Private oHebraCheckPointABB As Thread
    Private oHebraCheckPointTrackingPacasmayo As Thread

    Private oHebraCheckPointYRC_ITEM_EMB As Thread
    Private oHebraCheckPointYRC_INFO_EMB As Thread
    Private oHebraCheckPointYRC_COSTO_EMB As Thread
    Private oHebraCheckPointYRC_OBS_EMB As Thread
    Private oHebraCheckPointYRC_CHK_EMB As Thread
    Private oHebraCheckPointYRC_STATUSOC_EMB As Thread
    Private oHebraCheckPointYRC_ITEM_EMB_CHK_EMB As Thread
    Private oHebraActualPortal As Thread

    Private PARAM_PSTNMBCM As String = ""
 

    Private oclsCheckPointEnvio As New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointNotifGeneral

    Private dblEmbSelecEstado As String = ""

    Private odtMaestroPartidasArancelarias As New DataTable


    Private oBL_TipoDato As New Negocio.clsTipoDato
    Private oBL_Canal As New Negocio.clsCanal
    Private oBL_MedioTransporte As New Negocio.clsMedioTransporte
    Private oBL_Pais As New Negocio.clsPais
    Private oBL_Puerto As New Negocio.clsPuerto

    Private oListGenRegimen As New List(Of beRegimen)

    Private oListGenTipoDespacho As New List(Of beTipoDato)
    Private oListGenTransporteAgencia As New List(Of beTipoDato)
    Private oListGenTipoCarga As New List(Of beTipoDato)
    Private oListGenAlmacenDestinoLocal As New List(Of beTipoDato)
    Private oListGenCanal As New List(Of beCanal)
    Private oListGenMedioTransporte As New List(Of beMedioTransporte)
    Private oListGenPais As New List(Of bePais)
    Private oListGenPuerto As New List(Of bePuerto)

    Private oListGenOperacionRegimen As New List(Of beOperacionRegimen)
    Private oDtDocApertura As New DataTable

    Private dtListaClienteEnvioxModCheckpoint As New DataTable


    Dim dtClientesTracking As New DataTable

    Private oAccionTracking As AccionTracking

    Private dtChkPointTrackingInicial As New DataTable

    Public Property STSCHG1() As Boolean
        Get
            Return _STSCHG1
        End Get
        Set(ByVal value As Boolean)
            _STSCHG1 = value
        End Set
    End Property

    Private _STSOP11 As Boolean
    Public Property STSOP11() As Boolean
        Get
            Return _STSOP11
        End Get
        Set(ByVal value As Boolean)
            _STSOP11 = value
        End Set
    End Property

    Private _STSOP22 As Boolean
    Public Property STSOP22() As Boolean
        Get
            Return _STSOP22
        End Get
        Set(ByVal value As Boolean)
            _STSOP22 = value
        End Set
    End Property

#End Region

#Region "Enums"
    Enum ACTUALIZACION_GRILLA
        EMBARQUE
        ORDENSERVICIO
        COSTOS
        'ETD
        'ETA
        OBSERVACION
        DOCADJUNTO
        DUA
        CHECKPOINT
    End Enum

#End Region

    Private Sub Crear_Estructura_CiaTran()
        oDtCiaTran.Columns.Add(New DataColumn("CCIANV", GetType(System.String)))
        oDtCiaTran.Columns.Add(New DataColumn("TNMCIN", GetType(System.String)))
    End Sub


    Private Sub Cargar_Inicio()
        Dim oListTipoDatos As New List(Of beTipoDato)
        oListTipoDatos = oBL_TipoDato.Lista_TipoDato_Todos
        Dim obrclsRegimen As New clsRegimen
        Dim PSTPSRVA As String = ""
        oListGenRegimen = obrclsRegimen.ListarRegimen()
        oListGenOperacionRegimen = obrclsRegimen.ListarOperacionRegimen()
        oListGenTipoDespacho = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.TIPO_DESPACHO)
        oListGenTransporteAgencia = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.TRASNPORTE_AGENCIA)
        oListGenTipoCarga = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.TIPO_CARGA)
        oListGenAlmacenDestinoLocal = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.ALMACEN_DESTINO_LOCAL)

        oListGenCanal = oBL_Canal.Lista_Canal("IM")
        oListGenMedioTransporte = oBL_MedioTransporte.Lista_Medio_Transporte
        oListGenPais = oBL_Pais.Listar_Pais
        oListGenPuerto = oBL_Puerto.Listar_Puerto

        oEmbarque = New clsEmbarque
        oDocApertura = New clsDocApertura
        oAgenteCarga = New clsAgenteCarga
        oTerminal = New clsTerminal
        oEstado = New clsEstado
        oMultiTabla = New clsMultiTabla
        oVapor = New clsVapor

        oDtCiaTran = New DataTable
        Crear_Estructura_CiaTran()
        oAgenteCarga.Crea_Lista()
        oDsSegAdu.Tables("oDtAgenteCarga").Load(oAgenteCarga.Lista_Agente_Carga(1).CreateDataReader)
        oTerminal.Crea_Lista()
        oDsSegAdu.Tables("oDtTerminal").Load(oTerminal.Lista_Terminal(1).CreateDataReader)
        oMoneda = New clsMoneda
        dtpInicio.Value = Now.AddMonths(-2)
        dtpFin.Value = Now
        oZona = New clsZona
        oZona.Crea_Lista()
        oNoLaborable = New clsNoLaborable
        oVapor.Crea_Lista()

        oBanco = New clsBanco
        oBanco.Crea_Lista()
        oTab = New clsTab

        Dim oListCanal As New List(Of beCanal)
        Dim obeCanal As New beCanal
        Dim oCloneListC As New CloneObject(Of beCanal)
        oListCanal = oCloneListC.CloneListObject(oListGenCanal)
        obeCanal.PSNCANAL = "-1"
        obeCanal.PSTCANAL = "::Seleccione::"
        oListCanal.Insert(0, obeCanal)


        cboCanal.DataSource = oListCanal
        cboCanal.DisplayMember = "PSTCANAL"
        cboCanal.ValueMember = "PSNCANAL"
        cboCanal.SelectedValue = "-1"

        CargaClienteNotificacionTracking()



    End Sub




    Private Sub CargarCombos()

        ctbAgenteDeCarga.DataSource = oDsSegAdu.Tables("oDtAgenteCarga").Copy
        ctbAgenteDeCarga.DisplayMember = "TNMAGC"
        ctbAgenteDeCarga.ValueMember = "CAGNCR"
        ctbAgenteDeCarga.DataBind()


        Dim oListMedioTransporte As New List(Of beMedioTransporte)
        Dim obeMedioTransporte As New beMedioTransporte
        Dim oCloneListMT As New CloneObject(Of beMedioTransporte)
        oListMedioTransporte = oCloneListMT.CloneListObject(oListGenMedioTransporte)

        obeMedioTransporte.PNCMEDTR = -1
        obeMedioTransporte.PSTNMMDT = "::Seleccione::"
        oListMedioTransporte.Insert(0, obeMedioTransporte)


        ctbMedioTransportes.DataSource = oListMedioTransporte
        ctbMedioTransportes.DisplayMember = "PSTNMMDT"
        ctbMedioTransportes.ValueMember = "PNCMEDTR"



        Dim oListDespacho As New List(Of beTipoDato)
        Dim obeDespacho As New beTipoDato
        Dim oCloneList As New CloneObject(Of beTipoDato)
        oListDespacho = oCloneList.CloneListObject(oListGenTipoDespacho)
        obeDespacho.PNNCODRG = -1
        obeDespacho.PSTDSCRG = "::Seleccione::"
        oListDespacho.Insert(0, obeDespacho)

        cmbTipoDespachos.DataSource = oListDespacho
        cmbTipoDespachos.DisplayMember = "PSTDSCRG"
        cmbTipoDespachos.ValueMember = "PNNCODRG"
        cmbTipoDespachos.SelectedValue = -1D


        ctbTerminal.DataSource = oDsSegAdu.Tables("oDtTerminal").Copy
        ctbTerminal.DisplayMember = "TTRMAL"
        ctbTerminal.ValueMember = "CTRMAL"
        ctbTerminal.DataBind()


        Dim oCloneListPais As New CloneObject(Of bePais)
        Dim oListPaisOrigen As New List(Of bePais)
        Dim obePais As bePais
        Dim oListPaisDestino As New List(Of bePais)

        oListPaisOrigen = oCloneListPais.CloneListObject(oListGenPais)
        obePais = New bePais
        obePais.PNCPAIS = -1
        obePais.PSTCMPPS = "::Seleccione::"
        oListPaisOrigen.Insert(0, obePais)

        oListPaisDestino = oCloneListPais.CloneListObject(oListGenPais)
        obePais = New bePais
        obePais.PNCPAIS = -1
        obePais.PSTCMPPS = "::Seleccione::"
        oListPaisDestino.Insert(0, obePais)

        cmbPaisOrg.DataSource = oListPaisOrigen
        cmbPaisOrg.ValueMember = "PNCPAIS"
        cmbPaisOrg.DisplayMember = "PSTCMPPS"
        cmbPaisOrg.SelectedValue = -1D


        cmbPaisOrg_SelectionChangeCommitted(cmbPaisOrg, Nothing)



        cmbPaisDest.DataSource = oListPaisDestino
        cmbPaisDest.ValueMember = "PNCPAIS"
        cmbPaisDest.DisplayMember = "PSTCMPPS"
        cmbPaisDest.SelectedValue = 589D

        cmbPaisDest_SelectionChangeCommitted(cmbPaisDest, Nothing)


    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub


    Private Sub CargarIdioma()

        Dim odtIdioma As New DataTable
        Dim dr As DataRow
        odtIdioma.Columns.Add("VALUE")
        odtIdioma.Columns.Add("DISPLAY")
        dr = odtIdioma.NewRow
        dr("VALUE") = "ES"
        dr("DISPLAY") = "Español"
        odtIdioma.Rows.Add(dr)

        dr = odtIdioma.NewRow
        dr("VALUE") = "IN"
        dr("DISPLAY") = "Inglés"
        odtIdioma.Rows.Add(dr)

        cboIdioma.DataSource = odtIdioma
        cboIdioma.DisplayMember = "DISPLAY"
        cboIdioma.ValueMember = "VALUE"

        cboIdioma.SelectedValue = "ES"
    End Sub

    Private Sub VisualizarIdioma(ByVal Ver As Boolean)
        lblIdioma.Visible = Ver
        cboIdioma.Visible = Ver
    End Sub



    Private Sub frmSegAduanero_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            txtRegimen.Tag = -1D
            txtOSOrigen.ReadOnly = True
            dtgDocAdjuntos.AutoGenerateColumns = False
            dgvOSRegularizados.AutoGenerateColumns = False

            Dim oclsEstado As New clsEstado
            Dim dtTipoOperacion As New DataTable
            dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
            Dim dr As DataRow
            dr = dtTipoOperacion.NewRow
            dr("COD") = "0"
            dr("TEX") = "TODOS"
            dtTipoOperacion.Rows.InsertAt(dr, 0)
            cboTipoOperacion.DataSource = dtTipoOperacion
            cboTipoOperacion.DisplayMember = "TEX"
            cboTipoOperacion.ValueMember = "COD"
            cboTipoOperacion.SelectedValue = "IM"
            cboTipoOperacion.Enabled = False


            Dim dtEstadoCF As New DataTable
            oEstado = New clsEstado
            dtEstadoCF = oEstado.Estado_CartaFianza
            cboEstadoCF.DataSource = dtEstadoCF
            cboEstadoCF.DisplayMember = "DISPLAY"
            cboEstadoCF.ValueMember = "VALUE"
            cboEstadoCF.SelectedValue = "V"






            cmbCliente.pAccesoPorUsuario = True
            cmbCliente.pRequerido = True
            cmbCliente.pUsuario = HelpUtil.UserName


            TabObservacion.SelectTab(TabEmbarqueAduana)
            dtgObsCargaInternacional.AutoGenerateColumns = False

            btnReaperturar.Visible = False
            gvOrdenesEmb.AutoGenerateColumns = False
            Dim oDs As New DataSet
            oDs.Tables.Clear()

            Cargar_Inicio()
            CargarCombos()


            objEntidadAcceso = New beAcceso
            objEntidadAcceso.STSCHG = "X"
            objEntidadAcceso.STSOP1 = "X"
            objEntidadAcceso.STSOP2 = "X"
            Accesos(objEntidadAcceso)


            bolBuscarSegAdu = False
            btnActPortal.Visible = False
            gbxFianza.Visible = False
            dblEmbSelec = 0
            dblEmbSelecEstado = ""
            Cargar_Tablas()
            ConfigurarDatosGrid()
            bolBuscarSegAdu = True
            Crear_TabPages()
            dtgSegAduaneroReducido.AutoGenerateColumns = False
            chkVistaExtendida.Checked = False
            dtgSegAduaneroReducido.Visible = True
            dtgSegAduanero.Visible = False
            dtgServicios.AutoGenerateColumns = False
            CargarIdioma()
            VisualizarIdioma(False)

            Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
            dtListaClienteEnvioxModCheckpoint = odaClienteEnvio.Listar_FomatosNotificacion_X_Cliente(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division, odaClienteEnvio.Tipo_Envio_Chk_x_Aduana)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Tablas()

     

        cmbEstado.DataSource = oEstado.Estado_Aduanero
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "A"

        oDocApertura.Crea_Lista()
        oDocApertura.Codigo = CType(oDocApertura.Lista, DataTable).Rows(0).Item("NTPODT").ToString.Trim
        oDtDocApertura = oDocApertura.Lista_Doc_Apertura(1)
        oDtDocApertura.Columns.Add("FLGORG")
        oDtDocApertura.Columns.Add("FLGCOP")
        oDtDocApertura.Columns.Add("NUMDOC")

        dtgDocAdjuntos.DataSource = oDtDocApertura

        oMultiTabla.Tabla = "C"
        oMultiTabla.Crea_Detalles()
        oDsSegAdu.Tables("oDtCiaTransporte").Load(oMultiTabla.Lista_Detalles.CreateDataReader())

        Dim oListTransporteAgencia As New List(Of beTipoDato)
        Dim obeTransporteAgencia As New beTipoDato
        Dim oCloneList As New CloneObject(Of beTipoDato)
        oListTransporteAgencia = oCloneList.CloneListObject(oListGenTransporteAgencia)
        obeTransporteAgencia.PNNCODRG = -1
        obeTransporteAgencia.PSTDSCRG = "::Seleccione::"
        oListTransporteAgencia.Insert(0, obeTransporteAgencia)

        cmbTransporte.DataSource = oListTransporteAgencia
        cmbTransporte.DisplayMember = "PSTDSCRG"
        cmbTransporte.ValueMember = "PNNCODRG"
        cmbTransporte.SelectedValue = -1D
        oDsSegAdu.Tables("oDtDocumento").Load(oDocApertura.Lista_Documento.CreateDataReader())
        oMoneda.Crea_Lista()

        cmbPolizaMoneda.DataSource = oMoneda.Lista_Moneda(1)
        cmbPolizaMoneda.ValueMember = "CMNDA1"
        cmbPolizaMoneda.DisplayMember = "TSGNMN"
        cmbPolizaMoneda.SelectedValue = "100"

        cmbPolizaBanco.DataSource = oBanco.Lista_Banco(1)
        cmbPolizaBanco.ValueMember = "CBNCFN"
        cmbPolizaBanco.DisplayMember = "TCMBCF"

        cmbZona.DataSource = oZona.Lista_Zona(1)
        cmbZona.ValueMember = "CZNFCC"
        cmbZona.DisplayMember = "TAZNFC"
        oNoLaborable.Inicio = 20080101
        oNoLaborable.Fin = Now.ToString("yyyyMMdd")
        objDtDia = oNoLaborable.dtNoLaborables
    End Sub


    Private Sub ConfigurarDatosGrid()
        Dim oDcBx As DataGridViewComboBoxColumn
        oDcBx = CType(dtgDocumentos.Columns("TDOCIN"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = oDsSegAdu.Tables("oDtDocumento")
        oDcBx.DisplayMember = "TDOCIN"
        oDcBx.ValueMember = "NDOCIN"
        oDcBx.DataPropertyName = "NDOCIN"

        Dim oListTipoCarga As New List(Of beTipoDato)
        Dim oCloneList As New CloneObject(Of beTipoDato)
        oListTipoCarga = oCloneList.CloneListObject(oListGenTipoCarga)

        oDcBx = CType(dtgCarga.Columns("CARGA"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = oListTipoCarga
        oDcBx.DisplayMember = "PSTDSCRG"
        oDcBx.ValueMember = "PNNCODRG"

        oDcBx = CType(dtgDocumentosAdjuntos.Columns("DOCCOSTO_TDOCIN"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = oEmbarque.Lista_Documento_Costo_Seguimiento
        oDcBx.DisplayMember = "NOMVAR"
        oDcBx.ValueMember = "VALVAR"

        oDcBx = CType(dtgDocumentosAdjuntos.Columns("DOCCOSTO_MONEDA"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = oMoneda.Lista_Moneda(1)
        oDcBx.DisplayMember = "TSGNMN"
        oDcBx.ValueMember = "CMNDA1"


    End Sub



#Region "Vista basica"
    Private Sub Llenar_Aduanero_Vista_Basica()
        If cmbCliente.pCodigo > 0 Then
            dtgSegAduaneroReducido.DataSource = Nothing
            Dim odtSegBasico As New DataTable
            Dim obrEmbarque As New clsEmbarque
            Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
            oFiltroEmbarque = ObtenerFiltroDatos()
            odtSegBasico = obrEmbarque.ListarSeguimientoAduaneroVistaReducido(oFiltroEmbarque)
            dtgSegAduaneroReducido.DataSource = odtSegBasico
            Dim estadoImg As String = ""
            Dim bmpImage As Bitmap = Nothing
            For Each row As DataGridViewRow In dtgSegAduaneroReducido.Rows
                estadoImg = row.Cells("FSTENV").Value
                row.Cells("FSTENV").ToolTipText = ("" & row.Cells("MSTENV").Value).ToString.Trim
                Select Case estadoImg
                    Case "S"
                        bmpImage = My.Resources.Resources.verde
                        row.Cells("IMG_STATUS").Value = bmpImage
                    Case "E"
                        bmpImage = My.Resources.Resources.Rojo
                        row.Cells("IMG_STATUS").Value = bmpImage
                    Case ""
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        row.Cells("IMG_STATUS").Value = bmpImage
                    Case Else
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        row.Cells("IMG_STATUS").Value = bmpImage
                End Select

            Next
        End If
    End Sub

#End Region



#Region "Limpiar Información"

    Private Sub Limpiar_Informacion()

        Me.dtgDocumentos.Rows.Clear()
        If oDtCiaTran IsNot Nothing Then
            oDtCiaTran.Rows.Clear()
        End If
        ctbCiaTransp.Limpiar()
        cmbPaisOrg.SelectedValue = -1D
        cmbPaisDest.SelectedValue = -1D

        cmbPaisOrg_SelectionChangeCommitted(cmbPaisOrg, Nothing)
        cmbPaisDest_SelectionChangeCommitted(cmbPaisDest, Nothing)

        ctbNave.Limpiar()
        Limpiar_Documentos_Forol()
        Limpiar_Datos_Embarque()
        dtgCarga.Rows.Clear()

        Limpiar_Carta_Fianza()
        Limpiar_Apertura_OS()
        dtgObservaciones.Rows.Clear()
        dtgObsCargaInternacional.DataSource = Nothing
        dtgServicios.DataSource = Nothing
        dtgCheckPoint.Rows.Clear()
        Limpiar_Documentos_Adjuntos()
        Limpiar_Costos_Totales_X_Embarque()
        If oTab IsNot Nothing Then
            oTab.Limpiar()
        End If
        gvOrdenesEmb.DataSource = Nothing
    End Sub

    Private Sub Limpiar_Carta_Fianza()
        txtPolizaNum.Clear()
        txtPolizaMonto.Clear()
        cmbPolizaBanco.SelectedValue = 0
        cmbPolizaMoneda.SelectedValue = 100
        mskPolizaFecEmi.Text = "  /  /    "
        mskPolizaFecVen.Text = "  /  /    "
        cboEstadoCF.SelectedValue = "V"
    End Sub

    Private Sub Limpiar_Apertura_OS()

        cmbZona.SelectedValue = 1
        cmbTipoDespachos.SelectedValue = -1D
        txtNroOS.Clear()
        txtNroOC.Clear()
        txtRefDoc.Clear()
        txtRefCli.Clear()
        txtMercaderia.Clear()


        txtTransTercero.Text = "LINO SALVATIERRA NEXTEL 426*2685"
        txtTransTercero.Visible = False
        cmbTransporte.SelectedValue = -1D
        txtBeneficio.Clear()
        txtDireccion.Text = "RANSA SAN AGUSTIN"
        txtHorario.Text = "8:00 a.m. A 5:00 p.m."
        txtContacto.Clear()
        txtObservacion.Clear()

        mskEmbarque.Text = Now
        mskApertura.Text = "  /  /    "

        ctbTerminal.Limpiar()
        UcProveedor_tab.pClear()
        Uc_AgenteAduana.pClear()
        txtDUA.Text = ""
        cboCanal.SelectedValue = "-1"

        LimpiarRegimen()

        mskFVencRegimen.Text = "  /  /    "

    End Sub


    Private Sub Limpiar_Datos_Embarque()

        mskETD.Clear()
        mskETD.Tag = ""
        mskETA.Clear()
        txtTipoEmbarque.Clear()
        txtNumDocEmb.Clear()
        txtNumEmbarcador.Clear()
        txtEmbarqueMan.Clear()
        txtEstado.Clear()
        ctbAgenteDeCarga.Limpiar()
        ctbMedioTransportes.SelectedValue = -1D

        txtResponsableCliente.Clear()
        txtResponsableAgencia.Clear()

        txtKg.Clear()
        txtSobreEstadia.Clear()
        txtDiaLibre.Clear()
        txtM3.Clear()

    End Sub

    Private Sub Limpiar_Documentos_Forol()
        Dim intCont As Integer

        For intCont = 0 To dtgDocAdjuntos.Rows.Count - 1
            dtgDocAdjuntos.Rows(intCont).Cells("FLGORG").Value = ""
            dtgDocAdjuntos.Rows(intCont).Cells("FLGCOP").Value = ""
            dtgDocAdjuntos.Rows(intCont).Cells("NUMDOC").Value = ""
        Next intCont
    End Sub

#End Region

#Region "Cargar Información"

    Private Sub Cargar_Informacion_Embarque()

        If Not oTab.Tab_Cargado(TabActivo) And dblEmbSelec > 0 Then
            Me.Cursor = Cursors.WaitCursor
            oEmbarque.pNORSCI = dblEmbSelec
            oEmbarque.EmbarqueEstado = dblEmbSelecEstado
            oEmbarque.Cargar_Informacion_Inicial(oEmbarque.pNORSCI)
            Select Case TabActivo
                Case 0 'Ordenes Embarcadas
                    Llenar_Detalle_Embarque() 'Ordenes Embarcadas
                Case 1 'Apertura O/S
                    If Not oTab.Tab_Cargado(1) Then
                        oEmbarque.Datos_Embarque_VB(oEmbarque.pCCLNT, oEmbarque.pNORSCI) 'Apertura O/S y Datos de Embarque
                    End If
                    Llenar_Datos_Embarque() 'Apertura O/S y Datos de Embarque
                    Llenar_Documentos_Forol() 'Apertura O/S
                Case 2 'Documentos Adjuntos
                    Llenar_Documentos_Embarque() 'Documentos Adjuntos
                Case 3 'Datos de Embarque
                    If Not oTab.Tab_Cargado(3) Then
                        oEmbarque.Datos_Embarque_VB(oEmbarque.pCCLNT, oEmbarque.pNORSCI) 'Apertura O/S y Datos de Embarque
                    End If
                    Llenar_Naves() 'Datos de Embarque
                    Llenar_Carga() 'Datos de Embarque
                    Llenar_Datos_Embarque() 'Apertura O/S y Datos de Embarque
                Case 4 'Costos del Seguimiento
                    LLenar_Costos_Totales_X_Embarque() 'Costos del Seguimiento
                    Llenar_Documentos_Adjuntos() 'Documentos de los costos del Seguimiento
                Case 5 'Observaciones del Seguimiento
                    Llenar_Observaciones() 'Observaciones del Seguimiento
                    Llenar_Observacion_Carga_Internacional() 'Observaciones Carga Internacional
                Case 6 'Servicios
                    Llenar_Servicios_X_Embarque()
                Case 7 'CheckPoints
                    Llenar_CheckPoint() 'CheckPoints
                Case 8
                    ListarOrdenesRegularizados()
            End Select
            oTab.Cargar_Tab(TabActivo)
            Me.Cursor = Cursors.Default
        End If


    End Sub


    Private Sub ListarOrdenesRegularizados()
        Dim odtOrdenesReg As New DataTable
        Dim PNNORSCI As Decimal = 0
        Dim obrEmbarque As New clsEmbarque
        dgvOSRegularizados.DataSource = Nothing
        odtOrdenesReg = oEmbarque.ListarOrdenesRegularizacion(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
        dgvOSRegularizados.DataSource = odtOrdenesReg
    End Sub

    Private Sub Llenar_Servicios_X_Embarque()
        dtgServicios.DataSource = Nothing
        dtgServicios.DataSource = ListaServiciosxEmbarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
    End Sub

    Private Function ListaServiciosxEmbarque(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
        Dim obrServicio As New clsServicio
        Dim odtServicios As New DataTable
        Dim obeServicioCns As New beServicioFacturar
        obeServicioCns.PNCCLNT = CCLNT
        obeServicioCns.PNNORSCI = NORSCI
        obeServicioCns.PSBUSQUEDA = "EMBARQUE"
        'OBTIENE EL SERVICIO GENERAL Y EL ESPECIFICO
        odtServicios = obrServicio.Lista_Servicios_X_Operacion(obeServicioCns)
        Return odtServicios
    End Function

    Private Sub Llenar_Observacion_Carga_Internacional()
        Dim odtObsCI As New DataTable
        Dim obrEmbarque As New clsEmbarque
        obrEmbarque.pCCLNT = oEmbarque.pCCLNT
        dtgObsCargaInternacional.DataSource = Nothing
        odtObsCI = oEmbarque.Lista_Observacion_CI_X_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
        dtgObsCargaInternacional.DataSource = odtObsCI
    End Sub

    Private Function IsEmbarqueCerrado(ByVal EstadoEmbarque As String) As Boolean
        Dim IsCerrado As Boolean = False
        IsCerrado = (EstadoEmbarque = "C")
        Return IsCerrado
    End Function

    Private Sub Llenar_CheckPoint()

        dtgCheckPoint.Rows.Clear()

        Dim oListCheckPoint As New List(Of beCheckPoint)
        Dim obrCheckPoint As New clsCheckPoint
        Dim obeParamCheckPoint As New beCheckPoint
        Dim FILA As Int32 = 0
        Dim oDrVw As DataGridViewRow
        obeParamCheckPoint.PNCCLNT = oEmbarque.pCCLNT
        obeParamCheckPoint.PNNORSCI = oEmbarque.pNORSCI
        obeParamCheckPoint.PSCCMPN = oEmbarque.pCCMPN
        obeParamCheckPoint.PSCDVSN = GetDivision(obeParamCheckPoint.PSCCMPN)
        oListCheckPoint = obrCheckPoint.Lista_CheckPoint_X_Embarque(obeParamCheckPoint)

        For Each CheckPoint As beCheckPoint In oListCheckPoint
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dtgCheckPoint)
            'ADICION HABILITAR X ESTADO*************************************
            oDrVw.ReadOnly = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            '****************************************************************
            dtgCheckPoint.Rows.Add(oDrVw)
            FILA = dtgCheckPoint.Rows.Count - 1
            dtgCheckPoint.Rows(FILA).Cells("NESTDO").Value = CheckPoint.PNNESTDO.ToString
            dtgCheckPoint.Rows(FILA).Cells("TTIPO").Value = CheckPoint.PSNOMVAR
            dtgCheckPoint.Rows(FILA).Cells("CHECKP").Value = CheckPoint.PSTDESES

            If (CheckPoint.PSFESEST.Length <> 0) Then
                dtgCheckPoint.Rows(FILA).Cells("FESEST").Value = CheckPoint.PSFESEST
            End If
            If (CheckPoint.PSFRETES.Length <> 0) Then
                dtgCheckPoint.Rows(FILA).Cells("FRETES").Value = CheckPoint.PSFRETES
            End If


            dtgCheckPoint.Rows(FILA).Cells("TOBS").Value = CheckPoint.PSTOBS
            dtgCheckPoint.Rows(FILA).Cells("CEMB").Value = CheckPoint.PSCEMB
            dtgCheckPoint.Rows(FILA).Cells("TABRST").Value = CheckPoint.PSTABRST




            If (CheckPoint.PSFRETES.Length <> 0) Then
                dtgCheckPoint.Rows(FILA).Cells("FRETES2").Value = CheckPoint.PSFRETES
            End If


            dtgCheckPoint.Rows(FILA).Cells("STRNSM").Value = CheckPoint.PSSTRNSM 'FLAG WEB SERVICE
            dtgCheckPoint.Rows(FILA).Cells("RFCLNT").Value = CheckPoint.PSRFCLNT 'COD TRACKING CLIENTE



        Next
    End Sub

    Private Sub Llenar_Carga()
        dtgCarga.Rows.Clear()
        Dim oDrVw As DataGridViewRow
        Dim oListCarga As New List(Of beDetalleCargaInternacional)
        oListCarga = oEmbarque.Lista_Carga_Embarque(oEmbarque.pNORSCI)
        Dim FILA As Int32 = 0
        Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        For Each ItemCarga As beDetalleCargaInternacional In oListCarga
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dtgCarga)
            'ADICION HABILITAR X ESTADO*************************************
            oDrVw.ReadOnly = IsCerrado
            '***************************************************************
            Me.dtgCarga.Rows.Add(oDrVw)
            FILA = dtgCarga.Rows.Count - 1
            dtgCarga.Rows(FILA).Cells("CARGA").Value = ItemCarga.PNNCODRG
            dtgCarga.Rows(FILA).Cells("CARGA").ReadOnly = True
            dtgCarga.Rows(FILA).Cells("NBULTO").Value = ItemCarga.PNQCANTI

            dtgCarga.Rows(FILA).Cells("CARGA_FECINI").Value = ItemCarga.PSFECINI
            dtgCarga.Rows(FILA).Cells("CARGA_FECVEN").Value = ItemCarga.PSFECVEN

            dtgCarga.Rows(FILA).Cells("EXISTS_CARGA").Value = ItemCarga.PNEXISTS
            dtgCarga.Rows(FILA).Cells("DELETE_CARGA").ToolTipText = "Elimina el tipo de carga seleccionada."
        Next
        dtgCarga.Columns("DELETE_CARGA").Visible = Not IsCerrado
    End Sub

    Private Sub Llenar_Detalle_Embarque()
        Dim oDt As DataTable
        oDt = oEmbarque.Lista_Detalle_OC_Embarque_Ajuste(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
        gvOrdenesEmb.DataSource = Nothing
        gvOrdenesEmb.DataSource = oDt
        For Each Item As DataGridViewRow In gvOrdenesEmb.Rows
            Item.Cells("CPTDAR").ToolTipText = Item.Cells("TDEPTD").Value.ToString.Trim
        Next
        'ADICION HABILITAR X ESTADO*************************************
        Dim NameColumna As String = ""
        For Columna As Integer = 0 To gvOrdenesEmb.Columns.Count - 1
            NameColumna = gvOrdenesEmb.Columns(Columna).Name
            If (NameColumna = "CPTDAR" Or NameColumna = "NFCTCM" Or NameColumna = "QTPCM2" Or NameColumna = "NSEQIN") OrElse NameColumna = "NMITFC" Then
                gvOrdenesEmb.Columns(NameColumna).ReadOnly = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            Else
                gvOrdenesEmb.Columns(NameColumna).ReadOnly = True
            End If
        Next
        '****************************************************************
    End Sub

    Private Sub Llenar_Observaciones()
        dtgObservaciones.Rows.Clear()
        Dim oDrVw As DataGridViewRow
        Dim FILA As Int32 = 0
        Dim oListObservacion As New List(Of beObservacionCarga)
        oListObservacion = oEmbarque.Lista_Observacion_Embarque(oEmbarque.pNORSCI)
        Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        dtgObservaciones.Columns("DELETE_OBS").Visible = Not IsCerrado
        For Each obeObservacion As beObservacionCarga In oListObservacion
            If (obeObservacion.PSTOBS.Length <> 0) Then
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(dtgObservaciones)
                'ADICION HABILITAR X ESTADO*************************************
                oDrVw.ReadOnly = IsCerrado
                '****************************************************************
                dtgObservaciones.Rows.Add(oDrVw)
                FILA = dtgObservaciones.Rows.Count - 1
                dtgObservaciones.Rows(FILA).Cells("NRITEM_OBS").Value = obeObservacion.PNNRITEM
                dtgObservaciones.Rows(FILA).Cells("FECOBS").Value = obeObservacion.PSFECOBS
                dtgObservaciones.Rows(FILA).Cells("OBSERV").Value = obeObservacion.PSTOBS
                dtgObservaciones.Rows(FILA).Cells("EXISTS_OBS").Value = obeObservacion.PNEXISTS
                dtgObservaciones.Rows(FILA).Cells("DELETE_OBS").ToolTipText = "Elimina la observación seleccionada"
            End If
        Next
    End Sub



    Private Sub Llenar_Naves()
        ctbNave.DataSource = oVapor.Lista_Vapor(1)
        ctbNave.ValueMember = "CVPRCN"
        ctbNave.DisplayMember = "TCMPVP"
        ctbNave.DataBind()
    End Sub


    Private Sub Llenar_Datos_Embarque()
        Dim obeDatosEmbarque As New beDatosEmbarque
        Dim oDtDatosCFianza As DataTable
        Dim oCartaFianzaNeg As New clsCartaFianza
        obeDatosEmbarque = oEmbarque.DatosEmbarque
        Dim oFnEmbarque As New clsEmbarqueAduanas
        oDtDatosCFianza = oCartaFianzaNeg.Listar_Datos_Carta_Fianza(oEmbarque.pNORSCI)
        If obeDatosEmbarque IsNot Nothing Then
            Uc_Almacen_Local.CCLNT = oEmbarque.pCCLNT
            uc_Transportista.pObtenerTransportista(obeDatosEmbarque.PNCTRSPT)
            If (obeDatosEmbarque.PNALM_LOCAL > 0) Then
                Uc_Almacen_Local.pObtenerAlmacen(obeDatosEmbarque.PNALM_LOCAL)
            Else
                Uc_Almacen_Local.pClear()
            End If

            If obeDatosEmbarque.PNCAGNAD > 0 Then
                Uc_AgenteAduana.pObtenerAgenteAduana(obeDatosEmbarque.PNCAGNAD)
            Else
                Uc_AgenteAduana.pClear()
            End If


            txtEmbarqueMan.Text = obeDatosEmbarque.PNNORSCI
            If obeDatosEmbarque.PSCTRMAL.Length > 0 Then
                ctbTerminal.Codigo = obeDatosEmbarque.PSCTRMAL
            Else
                ctbTerminal.Limpiar()
            End If
            If obeDatosEmbarque.PNCAGNCR > 0 Then
                ctbAgenteDeCarga.Codigo = obeDatosEmbarque.PNCAGNCR
            Else
                ctbAgenteDeCarga.Limpiar()
            End If
            txtEstado.Text = obeDatosEmbarque.PSSESTRG_DESC
            txtNroOS.Text = obeDatosEmbarque.PNPNNMOS
            If obeDatosEmbarque.PNCZNFCC > 0 Then
                cmbZona.SelectedValue = obeDatosEmbarque.PNCZNFCC
            End If

            mskApertura.Text = obeDatosEmbarque.PSFCEMSN
            mskEmbarque.Text = obeDatosEmbarque.PSFORSCI

            txtNroOC.Text = obeDatosEmbarque.PSNORCML
            If obeDatosEmbarque.PNCPRVCL > 0 Then
                UcProveedor_tab.pCodigo = obeDatosEmbarque.PNCPRVCL
            Else
                UcProveedor_tab.pClear()
            End If




            txtRefDoc.Text = obeDatosEmbarque.PSREFDO1
            txtRefCli.Text = obeDatosEmbarque.PSNREFCL


            txtNumEmbarcador.Text = obeDatosEmbarque.PSNOREMB
            txtNumDocEmb.Text = obeDatosEmbarque.PSNDOCEM
            txtMercaderia.Text = obeDatosEmbarque.PSTOBERV
            ctbMedioTransportes.SelectedValue = IIf(obeDatosEmbarque.PNCMEDTR <> 0, obeDatosEmbarque.PNCMEDTR, -1D)
            CambioMedioTrasportes()
            If obeDatosEmbarque.PNCCIANV > 0 Then
                ctbCiaTransp.Codigo = obeDatosEmbarque.PNCCIANV
            Else
                ctbCiaTransp.Limpiar()
            End If
            If (obeDatosEmbarque.PSTNMCTT.Length = 0) Then
                obeDatosEmbarque.PSTNMCTT = "LINO SALVATIERRA NEXTEL 426*2685"
            End If
            txtTransTercero.Text = obeDatosEmbarque.PSTNMCTT
            txtBeneficio.Text = obeDatosEmbarque.PSTBFTRB
            txtDireccion.Text = obeDatosEmbarque.PSTDRENT
            txtHorario.Text = obeDatosEmbarque.PSHORATN
            txtContacto.Text = obeDatosEmbarque.PSTPRSCN
            txtObservacion.Text = obeDatosEmbarque.PSTRECOR
            If obeDatosEmbarque.PNCCIANV > 0 Then
                ctbCiaTransp.Codigo = obeDatosEmbarque.PNCCIANV
            Else
                ctbCiaTransp.Limpiar()
            End If
            If (obeDatosEmbarque.PSCVPRCN.Length > 0) Then
                ctbNave.Codigo = obeDatosEmbarque.PSCVPRCN
            Else
                ctbNave.Limpiar()
            End If
            If obeDatosEmbarque.PNCPAIS = 0 Then
                cmbPaisOrg.SelectedValue = -1D
            Else
                cmbPaisOrg.SelectedValue = obeDatosEmbarque.PNCPAIS
            End If
            cmbPaisOrg_SelectionChangeCommitted(cmbPaisOrg, Nothing)
            If obeDatosEmbarque.PSCPRTOE = "" Then
                cmbPuertoOrg.SelectedValue = "-1"
            Else
                cmbPuertoOrg.SelectedValue = obeDatosEmbarque.PSCPRTOE
            End If

            If obeDatosEmbarque.PNCPAIS_DESTINO = 0 Then
                'cmbPaisDest.SelectedValue = 589D 'PERU
                cmbPaisDest.SelectedValue = -1D
            Else
                cmbPaisDest.SelectedValue = obeDatosEmbarque.PNCPAIS_DESTINO
            End If

            cmbPaisDest_SelectionChangeCommitted(cmbPaisDest, Nothing)
            If obeDatosEmbarque.PSCPRTOA = "" Then
                cmbPuertoDest.SelectedValue = "-1"
            Else
                cmbPuertoDest.SelectedValue = obeDatosEmbarque.PSCPRTOA
            End If


            mskETD.Text = obeDatosEmbarque.PSFAPREV
            mskETA.Text = obeDatosEmbarque.PSFAPRAR

            If (obeDatosEmbarque.PNTPORGE > 0) Then
                txtRegimen.Tag = obeDatosEmbarque.PNTPORGE
                txtRegimen.Text = obeDatosEmbarque.PSTCMRGA
            Else
                txtRegimen.Tag = -1
                txtRegimen.Text = ""
            End If
            txtRegimen_SelectionChangeCommitted(txtRegimen.Tag)


            If (obeDatosEmbarque.PSTCANAL.Length > 0) Then
                cboCanal.SelectedValue = obeDatosEmbarque.PSTCANAL
            Else
                cboCanal.SelectedValue = "-1"
            End If
            txtDUA.Text = obeDatosEmbarque.PSTNRODU

            mskFVencRegimen.Text = obeDatosEmbarque.PSFTRORS_REG
            txtTipoEmbarque.Text = obeDatosEmbarque.PSTCMTSR

            chkseguimiento.Checked = False
            If obeDatosEmbarque.PSFTRTSG = "X" Then
                chkseguimiento.Checked = True
            End If

            txtEmbOrigen.Text = obeDatosEmbarque.PNNORSCO_REG
            txtOSOrigen.Text = obeDatosEmbarque.PNPNNMOS_REG

            Dim PNREGIMEN As Decimal = 0
            PNREGIMEN = obeDatosEmbarque.PNTPORGE

            txtM3.Text = obeDatosEmbarque.PNQVOLMR
            txtDiaLibre.Text = obeDatosEmbarque.PNNDIALB
            txtSobreEstadia.Text = obeDatosEmbarque.PNNDIASE
            txtKg.Text = obeDatosEmbarque.PNQPSOAR

            txtResponsableCliente.Text = obeDatosEmbarque.PSTRSPCL
            txtResponsableAgencia.Text = obeDatosEmbarque.PSTRSPRN


            If oDtDatosCFianza.Rows.Count > 0 Then
                txtPolizaNum.Text = oDtDatosCFianza.Rows(0).Item("NDOCUM").ToString.Trim
                txtPolizaMonto.Text = Double.Parse(oDtDatosCFianza.Rows(0).Item("ITTDOC")).ToString.Trim
                cmbPolizaBanco.SelectedValue = oDtDatosCFianza.Rows(0).Item("CBNCFN").ToString.Trim
                cmbPolizaMoneda.SelectedValue = oDtDatosCFianza.Rows(0).Item("CMNDA1").ToString.Trim
                mskPolizaFecEmi.Text = oDtDatosCFianza.Rows(0).Item("FECEDC").ToString.Trim
                mskPolizaFecVen.Text = oDtDatosCFianza.Rows(0).Item("FECVEN").ToString.Trim
                cboEstadoCF.SelectedValue = oDtDatosCFianza.Rows(0).Item("SESFNZ").ToString.Trim
                txtObsCF.Text = oDtDatosCFianza.Rows(0).Item("TOBFNZ").ToString.Trim 'SESFNZ
            End If
            gbxFianza.Visible = oFnEmbarque.IsRegimenTemporal(PNREGIMEN)

            If obeDatosEmbarque.PNTRANSPORTE = 0 Then
                cmbTransporte.SelectedValue = -1D
            Else
                cmbTransporte.SelectedValue = obeDatosEmbarque.PNTRANSPORTE
                If obeDatosEmbarque.PSTERCERO = "TERCEROS" Then
                    txtTransTercero.Visible = True
                Else
                    txtTransTercero.Visible = False
                End If
            End If
            If (obeDatosEmbarque.PNNCODRG_DESPACHO > 0) Then
                cmbTipoDespachos.SelectedValue = obeDatosEmbarque.PNNCODRG_DESPACHO
            Else
                cmbTipoDespachos.SelectedValue = -1D
            End If
            oEmbarque.pPNNMOS = obeDatosEmbarque.PNPNNMOS
            oEmbarque.pCZNFCC = obeDatosEmbarque.PNCZNFCC
        End If
    End Sub

    Private Sub Llenar_Documentos_Forol()
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim intContY As Integer

        oDt = oDocApertura.Lista_Doc_Forol(dblEmbSelec)
        For intCont = 0 To oDt.Rows.Count - 1
            For intContY = 0 To dtgDocAdjuntos.Rows.Count - 1
                If dtgDocAdjuntos.Rows(intContY).Cells("NCODRG").Value.ToString.Trim = oDt.Rows(intCont).Item("NCODRG").ToString.Trim Then
                    If oDt.Rows(intCont).Item("SORDOC").ToString.Trim = "O" Then
                        dtgDocAdjuntos.Rows(intContY).Cells("FLGORG").Value = "X"
                    Else
                        dtgDocAdjuntos.Rows(intContY).Cells("FLGCOP").Value = "X"
                    End If
                    dtgDocAdjuntos.Rows(intContY).Cells("NUMDOC").Value = oDt.Rows(intCont).Item("QCANTI").ToString.Trim
                    Exit For
                End If

            Next intContY
        Next intCont

        'ADICION HABILITAR X ESTADO**************************************************************
        Dim NomColumna As String = ""
        For Columna As Integer = 0 To dtgDocAdjuntos.Columns.Count - 1
            NomColumna = dtgDocAdjuntos.Columns(Columna).Name
            If (NomColumna = "NUMDOC") Then
                dtgDocAdjuntos.Columns(Columna).ReadOnly = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            Else
                dtgDocAdjuntos.Columns(Columna).ReadOnly = True
            End If
        Next
        ''ADICION HABILITAR X ESTADO**************************************************************
    End Sub

    Private Sub Llenar_Documentos_Embarque()
        dtgDocumentos.Rows.Clear()
        Dim Fila As Int32 = 0
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        Dim oLitstbeDocCargaInternacional_BE As New List(Of beDocCargaInternacional)
        Dim obeItemDocCarga As beDocCargaInternacional
        Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        oLitstbeDocCargaInternacional_BE = oDocApertura.Lista_Doc_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
        For intCont = 0 To oLitstbeDocCargaInternacional_BE.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dtgDocumentos)
            'ADICION HABILITAR X ESTADO**************************************
            oDrVw.ReadOnly = IsCerrado
            '****************************************************************
            dtgDocumentos.Rows.Add(oDrVw)
            Fila = dtgDocumentos.Rows.Count - 1
            obeItemDocCarga = oLitstbeDocCargaInternacional_BE(intCont)
            dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value = obeItemDocCarga.PNNDOCIN.ToString
            dtgDocumentos.Rows(Fila).Cells("TDOCIN").ReadOnly = True
            dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value = obeItemDocCarga.PSNDOCLI
            dtgDocumentos.Rows(Fila).Cells("FECORG").Value = obeItemDocCarga.PSFCDCOR
            dtgDocumentos.Rows(Fila).Cells("FECCOP").Value = obeItemDocCarga.PSFCDCCP
            dtgDocumentos.Rows(Fila).Cells("UPLOAT").Value = "..."
            dtgDocumentos.Rows(Fila).Cells("NORSCI_ADJ").Value = obeItemDocCarga.PNNORSCI
            dtgDocumentos.Rows(Fila).Cells("NCRRDC").Value = obeItemDocCarga.PNNCRRDC
            dtgDocumentos.Rows(Fila).Cells("NMRGIM_DOC").Value = obeItemDocCarga.PNNMRGIM
            dtgDocumentos.Rows(Fila).Cells("NDOCIN").Value = obeItemDocCarga.PNNDOCIN
            dtgDocumentos.Rows(Fila).Cells("EXISTS_DOCADJ").Value = obeItemDocCarga.PNEXISTS
            If obeItemDocCarga.PNNMRGIM > 0 Then
                dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.Archivo
            Else
                dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            End If
        Next
        dtgDocumentos.Columns("DELETE_DOCADJ").Visible = Not IsCerrado
        'ADICION HABILITAR X ESTADO*************************************
        Dim oDcBt As DataGridViewButtonColumn
        oDcBt = CType(dtgDocumentos.Columns("UPLOAT"), DataGridViewButtonColumn)
        If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then
            oDcBt.Visible = False
        Else
            oDcBt.Visible = Not Me.STSCHG1
        End If
        '****************************************************************
    End Sub

#End Region

#Region "Datos de Embarque"

    Private Sub Filtrar_CiaTransporte(ByVal PdblMedio As Double)
        oDtCiaTran.Rows.Clear()
        Dim oDrCol() As DataRow
        Dim oDr As DataRow
        Dim intCont As Integer
        oDrCol = oDsSegAdu.Tables("oDtCiaTransporte").Select("SMETRA=" & PdblMedio & " AND SESTRG<>'*'")
        For intCont = 0 To oDrCol.Length - 1
            oDr = oDtCiaTran.NewRow
            oDr.Item("CCIANV") = oDrCol(intCont).Item("CCIANV")
            oDr.Item("TNMCIN") = oDrCol(intCont).Item("TNMCIN")
            oDtCiaTran.Rows.Add(oDr)
        Next intCont
        ctbCiaTransp.DataSource = oDtCiaTran.Copy
        ctbCiaTransp.ValueMember = "CCIANV"
        ctbCiaTransp.DisplayMember = "TNMCIN"
        ctbCiaTransp.DataBind()
    End Sub

    Private Sub cmbPaisOrg_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaisOrg.SelectionChangeCommitted
        Try
            Dim CPAIS As Decimal = cmbPaisOrg.SelectedValue
            Dim oFNEmbarque As New Negocio.clsEmbarqueAduanas
            Dim oListPuertoFind As New List(Of bePuerto)
            If CPAIS <> -1 Then
                oListPuertoFind = oFNEmbarque.Puerto_x_Pais(oListGenPuerto, CPAIS)
            End If
            Dim obePuerto As New bePuerto
            obePuerto.PSCPRTOR = "-1"
            obePuerto.PSTCMPR1 = "::Seleccione::"
            oListPuertoFind.Insert(0, obePuerto)

            cmbPuertoOrg.DataSource = oListPuertoFind
            cmbPuertoOrg.DisplayMember = "PSTCMPR1"
            cmbPuertoOrg.ValueMember = "PSCPRTOR"
            cmbPuertoOrg.SelectedValue = "-1"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmbPaisDest_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaisDest.SelectionChangeCommitted
        Try
            Dim oFNEmbarque As New Negocio.clsEmbarqueAduanas
            Dim oListPuertoFind As New List(Of bePuerto)
            Dim CPAIS As Decimal = cmbPaisDest.SelectedValue
            If CPAIS <> -1 Then
                oListPuertoFind = oFNEmbarque.Puerto_x_Pais(oListGenPuerto, CPAIS)
            End If
            Dim obePuerto As New bePuerto
            obePuerto.PSCPRTOR = "-1"
            obePuerto.PSTCMPR1 = "::Seleccione::"
            oListPuertoFind.Insert(0, obePuerto)

            cmbPuertoDest.DataSource = oListPuertoFind
            cmbPuertoDest.DisplayMember = "PSTCMPR1"
            cmbPuertoDest.ValueMember = "PSCPRTOR"
            cmbPuertoDest.SelectedValue = "-1"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub Grabar_Datos_Embarque()

        Dim obedatoEmbarque As New beDatosEmbarque
        Dim retorno As Int32 = 0

        obedatoEmbarque.PNNORSCI = oEmbarque.pNORSCI
        If ctbCiaTransp.NoHayCodigo Then
            obedatoEmbarque.PNCCIANV = 0
        Else
            obedatoEmbarque.PNCCIANV = ctbCiaTransp.Codigo
        End If
        If ctbMedioTransportes.SelectedValue = 2D Then 'MARITIMO
            If ctbNave.NoHayCodigo Then
                obedatoEmbarque.PSCVPRCN = ""
            Else
                obedatoEmbarque.PSCVPRCN = ctbNave.Codigo
            End If
        Else
            obedatoEmbarque.PSCVPRCN = ""
        End If

        Dim FnEmbarque As New clsEmbarqueAduanas

        If mskEmbarque.Text.Trim.Length > 4 Then
            If Not FnEmbarque.isValidFecha(mskEmbarque.Text) Then
                MessageBox.Show("Fecha Embarque no válida.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            obedatoEmbarque.PNFORSCI = Format(CType(mskEmbarque.Text.Trim, Date), "yyyyMMdd")
        Else
            obedatoEmbarque.PNFORSCI = 0
        End If

        If cmbPaisOrg.SelectedValue = -1D Then
            obedatoEmbarque.PNCPAIS = 0
            obedatoEmbarque.PSCPRTOE = ""
        Else
            obedatoEmbarque.PNCPAIS = cmbPaisOrg.SelectedValue
            If cmbPuertoOrg.SelectedValue = "-1" Then
                obedatoEmbarque.PSCPRTOE = ""
            Else
                obedatoEmbarque.PSCPRTOE = cmbPuertoOrg.SelectedValue.ToString.Trim
            End If
        End If

        If cmbPaisDest.SelectedValue = -1D Then
            obedatoEmbarque.PNCPAIS_DESTINO = 0
        Else
            obedatoEmbarque.PNCPAIS_DESTINO = cmbPaisDest.SelectedValue
        End If

        If cmbPuertoDest.SelectedValue = "-1" Then
            obedatoEmbarque.PSCPRTOA = ""
        Else
            obedatoEmbarque.PSCPRTOA = cmbPuertoDest.SelectedValue.ToString.Trim
        End If


        obedatoEmbarque.PSNOREMB = txtNumEmbarcador.Text.Trim

        If ctbAgenteDeCarga.NoHayCodigo Then
            obedatoEmbarque.PNCAGNCR = 0
        Else
            obedatoEmbarque.PNCAGNCR = ctbAgenteDeCarga.Codigo
        End If

        If ctbTerminal.NoHayCodigo Then
            obedatoEmbarque.PSCTRMAL = ""
        Else
            obedatoEmbarque.PSCTRMAL = ctbTerminal.Codigo
        End If
        obedatoEmbarque.PNCMEDTR = IIf(ctbMedioTransportes.SelectedValue = -1D, 0, ctbMedioTransportes.SelectedValue)


        obedatoEmbarque.PNQVOLMR = IIf(txtM3.Text = "", 0, txtM3.Text)
        obedatoEmbarque.PNNDIALB = IIf(txtDiaLibre.Text = "", 0, txtDiaLibre.Text)
        obedatoEmbarque.PNNDIASE = IIf(txtSobreEstadia.Text = "", 0, txtSobreEstadia.Text)
        obedatoEmbarque.PNQPSOAR = IIf(txtKg.Text.Trim = "", 0, txtKg.Text.Trim)

        obedatoEmbarque.PSTRSPCL = txtResponsableCliente.Text.Trim
        obedatoEmbarque.PSTRSPRN = txtResponsableAgencia.Text.Trim

        obedatoEmbarque.PSFTRTSG = IIf(chkseguimiento.Checked = True, "X", "")

        retorno = oEmbarque.Mantenimiento_Datos_Embarque_VB(obedatoEmbarque)

    End Sub

    Private Function GrabarDatosCartaFianza() As Boolean
        Dim IsValid As Boolean = False
        If gbxFianza.Visible Then
            Dim oCartaFianzaNeg As New clsCartaFianza
            Dim obeCartaFinaza As New beCartaFianza
            Dim FnEmbarque As New clsEmbarqueAduanas

            Dim NUMERO As Decimal = 0
            obeCartaFinaza.PNNORSCI = oEmbarque.pNORSCI
            obeCartaFinaza.PSNDOCUM = txtPolizaNum.Text.Trim

            If (cmbPolizaBanco.Text <> vbNullString) Then
                obeCartaFinaza.PNCBNCFN = cmbPolizaBanco.SelectedValue
            End If
            If mskPolizaFecEmi.Text.Trim.Length > 4 Then
                If Not FnEmbarque.isValidFecha(mskPolizaFecEmi.Text) Then
                    MessageBox.Show("Fecha emisión Carta Fianza no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
                obeCartaFinaza.PNFECEDC = Format(CType(mskPolizaFecEmi.Text.Trim, Date), "yyyyMMdd")
            Else
                obeCartaFinaza.PNFECEDC = 0
            End If
            If mskPolizaFecVen.Text.Trim.Length > 4 Then
                If Not FnEmbarque.isValidFecha(Me.mskPolizaFecVen.Text) Then
                    MessageBox.Show("Fecha vencimiento Carta Fianza no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
                obeCartaFinaza.PNFECVEN = Format(CType(mskPolizaFecVen.Text.Trim, Date), "yyyyMMdd")
            Else
                obeCartaFinaza.PNFECVEN = 0
            End If

            If (Decimal.TryParse(txtPolizaMonto.Text, NUMERO)) Then
                obeCartaFinaza.PNITTDOC = NUMERO
            Else
                obeCartaFinaza.PNITTDOC = 0
            End If

            If (cmbPolizaMoneda.Text <> vbNullString) Then
                obeCartaFinaza.PSNMONOC = cmbPolizaMoneda.Text.Trim
            End If
            If (cmbPolizaMoneda.Text <> vbNullString) Then
                obeCartaFinaza.PNCMNDA1 = cmbPolizaMoneda.SelectedValue
            End If

            obeCartaFinaza.PSSESFNZ = cboEstadoCF.SelectedValue
            obeCartaFinaza.PSTOBFNZ = txtObsCF.Text.Trim

            If obeCartaFinaza.PNCBNCFN <> 0 Then
                oCartaFianzaNeg.Mant_Carta_Fianza(obeCartaFinaza)
            End If
        End If
        IsValid = True
        Return IsValid
    End Function



    Private Function IsValidoItemCarga(ByVal Fila As Int32) As Boolean
        Dim IsValido As Boolean = False
        IsValido = dtgCarga.Rows(Fila).Cells("CARGA").Value IsNot Nothing
        Return IsValido
    End Function

    Private Sub Grabar_Carga()
        Dim VALOR As Decimal = 0
        Dim obeCargaEmbarque As beDetalleCargaInternacional
        dtgCarga.EndEdit()
        Dim Fila As Int32 = 0
        Dim FECHA As Date
        For Fila = 0 To dtgCarga.Rows.Count - 1
            If IsValidoItemCarga(Fila) Then
                obeCargaEmbarque = New beDetalleCargaInternacional
                obeCargaEmbarque.PNNORSCI = oEmbarque.pNORSCI
                obeCargaEmbarque.PNNCODRG = dtgCarga.Rows(Fila).Cells("CARGA").Value
                If dtgCarga.Rows(Fila).Cells("NBULTO").Value IsNot Nothing Then
                    obeCargaEmbarque.PNQCANTI = dtgCarga.Rows(Fila).Cells("NBULTO").Value
                Else
                    obeCargaEmbarque.PNQCANTI = 0
                End If
                If Date.TryParse(dtgCarga.Rows(Fila).Cells("CARGA_FECINI").Value, FECHA) Then
                    obeCargaEmbarque.PNFECINI = FECHA.ToString("yyyyMMdd")
                Else
                    obeCargaEmbarque.PNFECINI = 0
                End If
                If Date.TryParse(dtgCarga.Rows(Fila).Cells("CARGA_FECVEN").Value, FECHA) Then
                    obeCargaEmbarque.PNFECVEN = FECHA.ToString("yyyyMMdd")
                Else
                    obeCargaEmbarque.PNFECVEN = 0
                End If
                oEmbarque.Actualiza_Carga(obeCargaEmbarque)
            End If
        Next
    End Sub


#End Region

#Region "Apertura O/S"

    Private Sub Grabar_Datos_AperturaOS()
        Dim retorno As Int32 = 0
        Dim msgOS As New StringBuilder
        Dim FnEmbarque As New clsEmbarqueAduanas
        Dim ExistOSEnAgencia As Boolean = False
        Dim odatoEmbarque As New beDatosEmbarque
        'Dim ContinuarActualizacion As Boolean = True

        If mskApertura.Text.Trim.Length > 4 Then
            If Not FnEmbarque.isValidFecha(mskApertura.Text) Then
                MessageBox.Show("Fecha Apertura no válida.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            odatoEmbarque.PNFCEMSN = Format(CType(mskApertura.Text.Trim, Date), "yyyyMMdd")
        Else
            odatoEmbarque.PNFCEMSN = 0
        End If
        odatoEmbarque.PNPNNMOS = IIf(txtNroOS.Text.Trim = "", 0, txtNroOS.Text.Trim)

        odatoEmbarque.PSREFDO1 = txtRefDoc.Text.Trim
        odatoEmbarque.PSNREFCL = txtRefCli.Text.Trim
        odatoEmbarque.PSTOBERV = txtMercaderia.Text.Trim

        If Me.cmbTransporte.SelectedValue = -1D Then
            odatoEmbarque.PNTRANSPORTE = 0
            odatoEmbarque.PSTNMCTT = ""
        Else
            odatoEmbarque.PNTRANSPORTE = cmbTransporte.SelectedValue
            odatoEmbarque.PSTNMCTT = IIf(odatoEmbarque.PNTRANSPORTE = 3, txtTransTercero.Text.Trim, "")
        End If

        odatoEmbarque.PSTBFTRB = txtBeneficio.Text.Trim
        odatoEmbarque.PSTDRENT = txtDireccion.Text.Trim
        odatoEmbarque.PSHORATN = txtHorario.Text.Trim
        odatoEmbarque.PSTPRSCN = txtContacto.Text.Trim
        odatoEmbarque.PSTRECOR = txtObservacion.Text.Trim
        odatoEmbarque.PNCZNFCC = cmbZona.SelectedValue
        odatoEmbarque.PNCTRSPT = uc_Transportista.pPNCTRSPT
        odatoEmbarque.PNALM_LOCAL = Uc_Almacen_Local.pPNNCODRG

        odatoEmbarque.PNTPORGE = IIf(txtRegimen.Tag <> -1D, txtRegimen.Tag, 0)
        odatoEmbarque.PNTPOPRG = IIf(cboRegOperacion.SelectedValue <> -1D, cboRegOperacion.SelectedValue, 0)

        odatoEmbarque.PSTCANAL = IIf(cboCanal.SelectedValue <> "-1", cboCanal.SelectedValue, "")
        odatoEmbarque.PSTNRODU = txtDUA.Text.Trim
        odatoEmbarque.PNNORSCI = oEmbarque.pNORSCI

        odatoEmbarque.PNNCODRG_DESPACHO = IIf(cmbTipoDespachos.SelectedValue = -1D, 0, cmbTipoDespachos.SelectedValue)
        odatoEmbarque.PNCPRVCL = UcProveedor_tab.pCodigo
        'If FnEmbarque.IsRegimenTemporal(txtRegimen.Tag) Then
        If mskFVencRegimen.Text.Trim.Length > 4 Then
            If Not FnEmbarque.isValidFecha(mskFVencRegimen.Text) Then
                MessageBox.Show("Fecha vencimiento régimen no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            odatoEmbarque.PNFTRORS_REG = Format(CType(mskFVencRegimen.Text.Trim, Date), "yyyyMMdd")
        Else
            odatoEmbarque.PNFTRORS_REG = 0
        End If
        odatoEmbarque.PNNORSCO_REG = IIf(txtEmbOrigen.Text.Trim = "", 0, txtEmbOrigen.Text.Trim)
        'Else
        'odatoEmbarque.PNNORSCO_REG = 0
        'odatoEmbarque.PNFTRORS_REG = 0
        'End If

        odatoEmbarque.PNCAGNAD = Uc_AgenteAduana.pCAGNAD
        Dim obeAgencia As New beAgencia
        obeAgencia = oEmbarque.VERIFICA_EXISTENCIA_OS_EN_AGENCIA(odatoEmbarque.PNPNNMOS, odatoEmbarque.PNCZNFCC)
       
        retorno = oEmbarque.Mantenimiento_Datos_Forol_Completo(odatoEmbarque)

        Dim PSTNRODU As String = ""
        Dim PSTCANAL As String = ""
        If (obeAgencia IsNot Nothing) Then
            PSTNRODU = obeAgencia.PSTNRODU
            PSTCANAL = obeAgencia.PSTCANAL
        End If

        If (odatoEmbarque.PSTCANAL <> PSTCANAL) Then
            EnviaMensajeTexto(txtEmbarqueMan.Text.Trim)
        End If

        oEmbarque.Datos_Embarque_VB(oEmbarque.pCCLNT, oEmbarque.pNORSCI) 'Apertura O/S y Datos de Embarque
        Llenar_Datos_Embarque() 'Apertura O/S y Datos de Embarque

        Dim REGIMEN As Decimal = txtRegimen.Tag
        gbxFianza.Visible = FnEmbarque.IsRegimenTemporal(REGIMEN)
        Actualizar_Grilla(ACTUALIZACION_GRILLA.EMBARQUE)

    End Sub

    Private Function Validar_Doc_Forol(ByVal pintRow As Integer) As Boolean
        If ("" & dtgDocAdjuntos.Rows(pintRow).Cells("NUMDOC").Value).ToString.Trim <> vbNullString And (("" & dtgDocAdjuntos.Rows(pintRow).Cells("FLGORG").Value).ToString.Trim = "X" Or ("" & dtgDocAdjuntos.Rows(pintRow).Cells("FLGCOP").Value).ToString.Trim = "X") Then
            Return True
        End If
        Return False
    End Function

    Private Sub Grabar_Documentos_Forol()
        Dim obeDetCargaInternacional_BE As beDetalleCargaInternacional
        Dim intCont As Integer
        Dim PSSORDOC As String
        Dim PNQCANTI As Double
        oDocApertura.Borrar_Doc_Forol(dblEmbSelec)
        For intCont = 0 To Me.dtgDocAdjuntos.Rows.Count - 1
            If Validar_Doc_Forol(intCont) Then
                If ("" & dtgDocAdjuntos.Rows(intCont).Cells("FLGORG").Value).ToString.Trim = "X" Then
                    PSSORDOC = "O"
                Else
                    PSSORDOC = "C"
                End If
                PNQCANTI = dtgDocAdjuntos.Rows(intCont).Cells("NUMDOC").Value.ToString.Trim
                obeDetCargaInternacional_BE = New beDetalleCargaInternacional
                obeDetCargaInternacional_BE.PNNORSCI = dblEmbSelec
                obeDetCargaInternacional_BE.PNNTPODT = oDocApertura.Codigo
                obeDetCargaInternacional_BE.PNNCODRG = dtgDocAdjuntos.Rows(intCont).Cells("NCODRG").Value
                obeDetCargaInternacional_BE.PSSORDOC = PSSORDOC
                obeDetCargaInternacional_BE.PNQCANTI = PNQCANTI
                oDocApertura.Mant_Doc_Forol(obeDetCargaInternacional_BE)
            End If
        Next intCont
    End Sub

    Private Sub dtgDocAdjuntos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDocAdjuntos.DoubleClick
        Try
            'ADICION HABILITAR X ESTADO*************************************
            Dim IndexNTPODT As Int32 = 0
            Dim IndexFLGORG As Int32 = dtgDocAdjuntos.Columns("FLGORG").Index
            Dim IndexFLGCOP As Int32 = dtgDocAdjuntos.Columns("FLGCOP").Index
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
            '****************************************************************
            If dtgDocAdjuntos.SelectedCells.Count = 1 Then
                If Me.dtgDocAdjuntos.SelectedCells(0).ColumnIndex = IndexFLGORG Or dtgDocAdjuntos.SelectedCells(0).ColumnIndex = IndexFLGCOP Then
                    If ("" & dtgDocAdjuntos.SelectedCells(0).Value).ToString.Trim = "X" Then
                        dtgDocAdjuntos.SelectedCells(0).Value = ""
                        dtgDocAdjuntos.CurrentRow.Cells("NUMDOC").Value = ""
                    Else
                        If ("" & dtgDocAdjuntos.CurrentRow.Cells("NUMDOC").Value).ToString.Trim = "" Then
                            dtgDocAdjuntos.SelectedCells(0).Value = "X"
                            dtgDocAdjuntos.CurrentRow.Cells("NUMDOC").Value = "1"
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Documentos Adjuntos"

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Try
            Dim oDrVw As New DataGridViewRow
            Dim Fila As Int32 = 0
            oDrVw.CreateCells(dtgDocumentos)
            dtgDocumentos.Rows.Add(oDrVw)
            Fila = dtgDocumentos.Rows.Count - 1
            dtgDocumentos.Rows(Fila).Cells("TNMBAR").Value = ""
            dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            dtgDocumentos.Rows(Fila).Cells("UPLOAT").Value = "..."
            dtgDocumentos.Rows(Fila).Cells("NORSCI_ADJ").Value = 0
            dtgDocumentos.Rows(Fila).Cells("URLARC").Value = ""
            dtgDocumentos.Rows(Fila).Cells("EXISTS_DOCADJ").Value = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Validar(ByVal pintIndice As Integer) As Boolean
        If dtgDocumentos.Rows(pintIndice).Cells("TDOCIN").Value <> Nothing Then
            Return True
        End If
        Return False
    End Function

    Private Function ValidarIngresoDocAdjunto() As String
        Dim isValido As Boolean = True
        Dim Fila As Int32 = 0
        Dim oListaDocAdjunt As New List(Of String)
        Dim DocAdjunt As String = ""
        Dim PSTDOCIN As String = ""
        Dim PSNDOCLI As String = ""
        For Fila = 0 To dtgDocumentos.Rows.Count - 1
            If Validar(Fila) Then
                PSTDOCIN = ("" & dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value).ToString.Trim
                PSNDOCLI = ("" & dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value).ToString.Trim.ToUpper
                DocAdjunt = PSTDOCIN & PSNDOCLI
                If Not oListaDocAdjunt.Contains(DocAdjunt) Then
                    oListaDocAdjunt.Add(DocAdjunt)
                Else
                    isValido = False
                    Exit For
                End If
            End If
        Next
        Return isValido
    End Function


    Private Sub GrabarFilaDocAdjunto(ByVal Fila As Int32)
        Dim Fecha As Date
        Dim IsFecha As Boolean = False
        Dim obeDocAdjuntoEmbarque As beDocCargaInternacional
        obeDocAdjuntoEmbarque = New beDocCargaInternacional
        obeDocAdjuntoEmbarque.PNNORSCI = oEmbarque.pNORSCI
        obeDocAdjuntoEmbarque.PNCCLNT = oEmbarque.pCCLNT
        obeDocAdjuntoEmbarque.PNNDOCIN = dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value
        obeDocAdjuntoEmbarque.PSNDOCLI = ("" & dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value).ToString.Trim
        obeDocAdjuntoEmbarque.PNNCRRDC = dtgDocumentos.Rows(Fila).Cells("NCRRDC").Value

        IsFecha = Date.TryParse(dtgDocumentos.Rows(Fila).Cells("FECORG").Value, Fecha)
        If IsFecha Then
            obeDocAdjuntoEmbarque.PNFECORG = Fecha.ToString("yyyyMMdd")
        Else
            obeDocAdjuntoEmbarque.PNFECORG = 0
        End If
        IsFecha = Date.TryParse(dtgDocumentos.Rows(Fila).Cells("FECCOP").Value, Fecha)
        If IsFecha Then
            obeDocAdjuntoEmbarque.PNFECCOP = Fecha.ToString("yyyyMMdd")
        Else
            obeDocAdjuntoEmbarque.PNFECCOP = 0
        End If
        oDocApertura.Actualizar_Documentos_Adjunto(obeDocAdjuntoEmbarque)

    End Sub

    Private Sub Grabar_DocAdj(Optional ByVal FilaUpdate As Int32 = -1)
      
        Dim Fila As Integer
        If FilaUpdate <> -1 Then
            If Validar(FilaUpdate) Then
                GrabarFilaDocAdjunto(FilaUpdate)
            End If
        Else
            For Fila = 0 To dtgDocumentos.Rows.Count - 1
                If Validar(Fila) Then
                    GrabarFilaDocAdjunto(Fila)
                End If
            Next
        End If
        'Actualizar_Grilla(ACTUALIZACION_GRILLA.DOCADJUNTO) '2 - Documentos Adjuntos
        If FilaUpdate = -1 Then
            dtgDocumentos.Rows.Clear()
            Llenar_Documentos_Embarque()
        End If

        Limpiar_Informacion()
        Cargar_Informacion_Embarque()

        Actualizar_Grilla(ACTUALIZACION_GRILLA.DOCADJUNTO) '2 - Documentos Adjuntos
    End Sub
#End Region

    Private Sub dtgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellDoubleClick

        Try
            Dim ColName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
            If (e.ColumnIndex < 0 Or e.RowIndex < 0) Then
                Exit Sub
            End If
            Select Case ColName
                Case "LINK"
                    Dim CCLNT As Decimal = oEmbarque.pCCLNT
                    Dim CCMPN As String = oEmbarque.pCCMPN
                    Dim NMRGIM As Decimal = dtgDocumentos.CurrentRow.Cells("NMRGIM_DOC").Value
                    If NMRGIM = 0 Then
                        Exit Sub
                    End If
                    Dim TABLE_NAME As String = "RZOL53"
                    Dim USER_NAME As String = HelpUtil.UserName
                    Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocEmb)
                    ofrmAdjuntarDocumentos.ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub dtgDocumentos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgDocumentos.MouseDown

        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                ctmEmbarque.Items(0).Visible = False
                ctmEmbarque.Items(1).Visible = False
                If (dtgDocumentos.Rows.Count <= 0) Then Exit Sub

                Dim ColName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
                If ColName = "FECORG" Or ColName = "FECCOP" Then
                    ctmEmbarque.Items(0).Visible = True
                End If
               
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgDocumentos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellClick
        Try
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then
                Exit Sub
            End If

            intPosicion = e.RowIndex
            Dim ColName As String = dtgDocumentos.Columns(e.ColumnIndex).Name
            Select Case ColName
                Case "UPLOAT"
                    If dtgDocumentos.Rows(e.RowIndex).Cells("NORSCI_ADJ").Value.ToString = 0 Then
                        HelpClass.MsgBox("Debe grabar antes la información para poder subir una imagen")
                        Exit Sub
                    End If

                    Dim CCLNT As Decimal = oEmbarque.pCCLNT
                    Dim CCMPN As String = oEmbarque.pCCMPN
                    Dim NMRGIM As Decimal = dtgDocumentos.CurrentRow.Cells("NMRGIM_DOC").Value
                    Dim TABLE_NAME As String = "RZOL53"
                    Dim USER_NAME As String = HelpUtil.UserName
                    Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocEmb)
                    ofrmAdjuntarDocumentos.pPNORSCI = dtgDocumentos.CurrentRow.Cells("NORSCI_ADJ").Value
                    ofrmAdjuntarDocumentos.pNDOCIN = dtgDocumentos.CurrentRow.Cells("NDOCIN").Value
                    ofrmAdjuntarDocumentos.pNCRRDC = dtgDocumentos.CurrentRow.Cells("NCRRDC").Value
                    ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
                    ofrmAdjuntarDocumentos.ShowDialog()
                    If ofrmAdjuntarDocumentos.myDialogResult = True Then
                        Llenar_Documentos_Embarque()
                    End If

                Case "DELETE_DOCADJ"

                    Dim ExisteDocBD As Int32 = 0
                    Dim obeCargaEmbarque As New beDocCargaInternacional
                    Dim obeDocAdjunto As New beDocCargaInternacional
                    ExisteDocBD = dtgDocumentos.Rows(e.RowIndex).Cells("EXISTS_DOCADJ").Value

                    If ExisteDocBD = 1 Then
                        If MessageBox.Show("¿ Está seguro de eliminar el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            
                            obeCargaEmbarque.PNCCLNT = oEmbarque.pCCLNT
                            obeCargaEmbarque.PNNORSCI = oEmbarque.pNORSCI
                            obeCargaEmbarque.PNNDOCIN = dtgDocumentos.Rows(e.RowIndex).Cells("TDOCIN").Value
                            obeCargaEmbarque.PNNCRRDC = dtgDocumentos.Rows(e.RowIndex).Cells("NCRRDC").Value
                            oDocApertura.Borrar_Documentos_Adjunto_Item(obeCargaEmbarque)
                            dtgDocumentos.Rows.RemoveAt(e.RowIndex)
                            Actualizar_Grilla(ACTUALIZACION_GRILLA.DOCADJUNTO)
                        End If
                    ElseIf ExisteDocBD = 0 Then
                        dtgDocumentos.Rows.RemoveAt(e.RowIndex)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



#Region "Editar Grilla Aduanera"

    Private Sub Actualizar_Datos(ByVal pdblEmbarque As Double, ByVal pstrColumna As String, ByVal pstrDato As String)
        Dim pCCMPN As String = oEmbarque.pCCMPN
        Dim pCDVSN As String = oEmbarque.pCDVSN
        Dim oFuncionServSeguimiento As New FuncionServSeguimiento

        Select Case pstrColumna
            Case "FECDCP"

                oEmbarque.Actualiza_Status_Documentos(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                oFuncionServSeguimiento.ActualizarCalculosColumnas(objDtDia, dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                '----------------*************---------------
                'If oEmbarque.pCCLNT_PORTAL > 0 Then
                '    If oEmbarque.pNOREMB.Length > 0 Then

                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                '    End If
                'End If




            Case "FECNUM"
                oEmbarque.Actualiza_Status_Numeracion(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))

                Dim bolClienteTracking As Boolean = False
                bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                If bolClienteTracking = True Then
                    Dim obrCheckPoint As New clsCheckPoint
                    dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                    dtChkPointTrackingInicial.Columns.Add("FRETES2")
                    dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                    For Each item As DataRow In dtChkPointTrackingInicial.Rows
                        If item("NESTDO") = 121 Then
                            item("FLG_APLICA") = "SI"
                        End If
                    Next
                    oAccionTracking = AccionTracking.ListadoRegChk
                    oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                    oHebraCheckPointTrackingPacasmayo.Start()
                End If



                EnviaMensajeTexto(pdblEmbarque)
                oFuncionServSeguimiento.ActualizarCalculosColumnas(objDtDia, dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                '----------------*************---------------
                'If oEmbarque.pCCLNT_PORTAL > 0 Then
                '    If oEmbarque.pNOREMB.Length > 0 Then

                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                '    End If
                'End If
            Case "FECPGD"
                oEmbarque.Actualiza_Status_Pago_Derechos(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                oFuncionServSeguimiento.ActualizarCalculosColumnas(objDtDia, dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)

                Dim bolClienteTracking As Boolean = False
                bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                If bolClienteTracking = True Then
                    Dim obrCheckPoint As New clsCheckPoint
                    dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                    dtChkPointTrackingInicial.Columns.Add("FRETES2")
                    dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                    For Each item As DataRow In dtChkPointTrackingInicial.Rows
                        If item("NESTDO") = 122 Then
                            item("FLG_APLICA") = "SI"
                        End If
                    Next
                    oAccionTracking = AccionTracking.ListadoRegChk
                    oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                    oHebraCheckPointTrackingPacasmayo.Start()
                End If

                'If oEmbarque.pCCLNT_PORTAL > 0 Then
                '    If oEmbarque.pNOREMB.Length > 0 Then

                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                '    End If
                'End If


            Case "FECLEV"
                oEmbarque.Actualiza_Status_Levante(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                EnviaMensajeTexto(pdblEmbarque)
                'Select Case oEmbarque.pCCLNT
                '    Case 2287, 48916, 46550, 48623, 48622
                '        If Me.txtNumEmbarcador.Text.Trim <> vbNullString Then
                '            Enviar_Checkpoint_Embarcador()
                '        End If
                'End Select

                Dim bolClienteTracking As Boolean = False
                bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                If bolClienteTracking = True Then
                    Dim obrCheckPoint As New clsCheckPoint
                    dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                    dtChkPointTrackingInicial.Columns.Add("FRETES2")
                    dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                    For Each item As DataRow In dtChkPointTrackingInicial.Rows
                        If item("NESTDO") = 123 Then
                            item("FLG_APLICA") = "SI"
                        End If
                    Next
                    oAccionTracking = AccionTracking.ListadoRegChk
                    oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                    oHebraCheckPointTrackingPacasmayo.Start()
                End If

                '*********POR ADICION G YM
                oFuncionServSeguimiento.ActualizarCalculosColumnas(objDtDia, dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                '*********************
            Case "FECPRO"
                oEmbarque.Actualiza_Status_Proforma(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
            Case "FECALM"
                oEmbarque.Actualiza_Status_Entrega(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))

                Dim bolClienteTracking As Boolean = False
                bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                If bolClienteTracking = True Then
                    Dim obrCheckPoint As New clsCheckPoint
                    dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                    dtChkPointTrackingInicial.Columns.Add("FRETES2")
                    dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                    For Each item As DataRow In dtChkPointTrackingInicial.Rows
                        If item("NESTDO") = 124 Then
                            item("FLG_APLICA") = "SI"
                        End If
                    Next
                    oAccionTracking = AccionTracking.ListadoRegChk
                    oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                    oHebraCheckPointTrackingPacasmayo.Start()
                End If

                oFuncionServSeguimiento.ActualizarCalculosColumnas(objDtDia, dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                '********************************************************************
                'Select Case oEmbarque.pCCLNT
                '    Case 2287, 48916, 46550, 48623, 48622
                '        If Me.txtNumEmbarcador.Text.Trim <> vbNullString Then
                '            Enviar_Checkpoint_Embarcador()
                '            If Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "7" Then 'DEPOSITO
                '                Cambiar_Status_OC("D")
                '            Else
                '                If Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "1" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "2" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "8" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "5" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "18" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "15" Then
                '                    Cambiar_Status_OC("T")
                '                End If
                '            End If
                '        End If
                'End Select



            Case "FECPGP"
                oEmbarque.Actualiza_Status_Pago_Proforma(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
            Case "PROFOR"
                oEmbarque.Actualiza_Proforma(pdblEmbarque, pstrDato)
            Case "TIPTRA"
                oEmbarque.Actualiza_Tipo_Transporte(pdblEmbarque, pstrDato)
            Case "DOCPEN"
                oEmbarque.Actualiza_Doc_Pendiente(pdblEmbarque, pstrDato)
        End Select
    End Sub

#End Region

#Region "Exportar Excel"
    Private Function ContieneColumna(ByVal Listcolumnas As String, ByVal NameColumna As String) As Boolean
        Dim columnas() As String = Listcolumnas.Split("|")
        Dim Has As New Hashtable
        For Each Item As String In columnas
            Has(Item) = Item
        Next
        Return Has.Contains(NameColumna)
    End Function
    Private Sub FormatoCabecera(ByVal ColName As String, ByRef ColorFondoCab As String, ByRef ColorLetraCab As String)
        Dim FormatoFMLB As String = "NORSCI|STATUS|REGIMENOS|NREFCLEMB|REFDO1|TPRVCL|TDITES|TNOMCOM|" & _
                             "FORCML|OCORACLE|MONEDA|MNTITM|MNTDLR|TTINTC|CPRTOE|CPRTOA|TPAGME|CONDPAGO|TIPENT|CMEDTR|FECFACCON|" & _
                             "CAGNCR|DOCEMB|CVPRCN|CAGNAD|NUMDUA|DESPACHO|CANAL|RECPOP|CKCLPV|FAPREV|FAPRAR" & "|FECALM|" & _
                             "TOBERV|RESPONS|NUMFAC|EXW|GFOB|FOB|FLETE|SEGURO|CIF" & "|ADVALOREM|OIMPAD|COSVAR|ITTCAG|TOTALDER|" & _
                             "TAGENCIAAD|COSTCOMPL" & "|FECFACIMP|FECFACCON|" & _
                             "NCA|STATUSFIN"
        Dim FormatoFMLA As String = "FECNUM|FECPGD" & "|FECFAC"
        Dim FormatoFRLA As String = "DIFEMEPROV" & "|DIFNUMLLEG" & "|DIFRECEMAT"
        Dim FormatoFRLB As String = "DIFERM" & "|DIFEME" & "|DIFCONIMPO"
        Dim FormatoFNLB As String = "PCIFFOB|PTOTDERCIF"

        Dim EstaEnFormato As Boolean = False
        Dim Morado As Short = 32
        Dim Rojo As Short = 2
        Dim Amarillo As Short = 5
        Dim Blanco As Short = 1
        Dim Naranja As Short = 53

        If ContieneColumna(FormatoFMLB, ColName) Then
            ColorFondoCab = Morado
            ColorLetraCab = Blanco
            EstaEnFormato = True
        ElseIf ContieneColumna(FormatoFMLA, ColName) Then
            ColorFondoCab = Morado
            ColorLetraCab = Amarillo
            EstaEnFormato = True
        ElseIf ContieneColumna(FormatoFRLA, ColName) Then
            ColorFondoCab = Rojo
            ColorLetraCab = Amarillo
            EstaEnFormato = True
        ElseIf ContieneColumna(FormatoFRLB, ColName) Then
            ColorFondoCab = Rojo
            ColorLetraCab = Blanco
            EstaEnFormato = True
        ElseIf ContieneColumna(FormatoFNLB, ColName) Then
            ColorFondoCab = Naranja
            ColorLetraCab = Blanco
            EstaEnFormato = True
        End If

        If EstaEnFormato = False Then
            ColorFondoCab = Morado
            ColorLetraCab = Blanco
            EstaEnFormato = True
        End If
    End Sub
    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        Try
            If chkVistaExtendida.Checked = True Then

                Dim odtTa As New DataTable
                Dim odtSegAduanas As New DataTable
                Dim ColTitle As String = ""
                Dim ColName As String = ""
                Dim ColValida As Boolean = False
                Dim TipoDato As String = ""
                Dim MdataColumna As String = ""
                Dim NPOI_SC As New HelpClass_NPOI_SC
                If dtgSegAduanero.Columns.Count = 0 Then Exit Sub

                Dim oFnSEguimiento As New FuncionServSeguimiento

                Dim ColorFondoCab As String = ""
                Dim ColorLetraCab As String = ""

                For Each Item As DataGridViewColumn In dtgSegAduanero.Columns
                    ColValida = False
                    ColTitle = oFnSEguimiento.FormatearCabecera(Item.HeaderText.Trim)
                    ColName = Item.Name.Trim
                    TipoDato = ""

                    If ColName = "IMGENVIO" Then
                        Continue For
                    End If


                    If (odtSegAduanas.Columns(ColName) Is Nothing) Then
                        If (Item.Visible = True) Then
                            odtSegAduanas.Columns.Add(ColName)
                            ColValida = True
                        Else
                            If (Item.Name = "TOBERV" Or Item.Name = "TOBERVDIF" AndAlso Item.Visible = False) Then
                                odtSegAduanas.Columns.Add(ColName)
                                ColValida = True
                            End If
                        End If

                    End If
                    

                    If (ColValida = True) Then
                        If (Item.Tag IsNot Nothing) Then
                            TipoDato = Item.Tag
                        Else
                            TipoDato = NPOI_SC.keyDatoTexto
                        End If

                        If dtgSegAduanero.Columns("PINT_GYM") IsNot Nothing Then
                            FormatoCabecera(ColName, ColorFondoCab, ColorLetraCab)
                            MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato, Nothing, ColorFondoCab, ColorLetraCab)
                            odtSegAduanas.Columns(ColName).Caption = MdataColumna
                        Else
                            MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                            odtSegAduanas.Columns(ColName).Caption = MdataColumna
                        End If

                    End If
                Next



                Dim dr As DataRow
                For Fila As Integer = 0 To dtgSegAduanero.Rows.Count - 1
                    dr = odtSegAduanas.NewRow
                    For Columna As Integer = 0 To odtSegAduanas.Columns.Count - 1
                        ColName = odtSegAduanas.Columns(Columna).ColumnName
                        If (dtgSegAduanero.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                            dr(ColName) = dtgSegAduanero.Rows(Fila).Cells(ColName).FormattedValue
                        End If
                    Next
                    odtSegAduanas.Rows.Add(dr)
                Next

                Dim ListLeyenda As List(Of DataTable)
                ListLeyenda = Nothing
                If dtgSegAduanero.Columns("PINT_GYM") IsNot Nothing Then

                    Dim WHITE As Short = 1
                    Dim LIGHT_YELLOW As Short = 43
                    Dim LIGHT_GREEN As Short = 42

                    Dim Blanco As Short = 1
                    Dim Verde As Short = 17
                    Dim Naranja As Short = 53
                    Dim Rojo As Short = 2
                    Dim Negro As Short = 8
                    Dim AmarilloAmbar As Short = 26

                    ListLeyenda = New List(Of DataTable)
                    Dim ExistColSatus As Boolean = dtgSegAduanero.Columns("CODSTATUS") IsNot Nothing
                    Dim ColNameFormato As String = NPOI_SC.keyNameColFormatoFila
                    If ExistColSatus = True Then
                        odtSegAduanas.Columns.Add(ColNameFormato)
                        Dim CodStatus As Int64 = 0
                        For index As Integer = 0 To dtgSegAduanero.Rows.Count - 1
                            CodStatus = Val(("" & dtgSegAduanero.Rows(index).Cells("CODSTATUS").Value).ToString.Trim)

                            Select Case CodStatus
                                Case 1
                                    odtSegAduanas.Rows(index)(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(WHITE)
                                Case 2, 3, 4
                                    odtSegAduanas.Rows(index)(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(LIGHT_YELLOW)
                                Case 5
                                    odtSegAduanas.Rows(index)(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(LIGHT_GREEN)
                            End Select
                        Next
                    End If

                    Dim dtLeyendaStatus As New DataTable
                    Dim dtLeyendaCanal As New DataTable

                    Dim drCanal As DataRow
                    dtLeyendaCanal.Columns.Add(ColNameFormato)
                    dtLeyendaCanal.Columns.Add("DESC")


                    drCanal = dtLeyendaCanal.NewRow
                    drCanal("DESC") = "CANAL"
                    drCanal(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(Blanco, Negro)
                    dtLeyendaCanal.Rows.Add(drCanal)

                    drCanal = dtLeyendaCanal.NewRow
                    drCanal("DESC") = "VERDE"
                    drCanal(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(Blanco, Verde)
                    dtLeyendaCanal.Rows.Add(drCanal)

                    drCanal = dtLeyendaCanal.NewRow
                    drCanal("DESC") = "ROJO"
                    drCanal(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(Blanco, Rojo)
                    dtLeyendaCanal.Rows.Add(drCanal)

                    drCanal = dtLeyendaCanal.NewRow
                    drCanal("DESC") = "NARANJA"
                    drCanal(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(Blanco, Naranja)
                    dtLeyendaCanal.Rows.Add(drCanal)

                    Dim drStatus As DataRow
                    dtLeyendaStatus.Columns.Add(ColNameFormato)
                    dtLeyendaStatus.Columns.Add("LEYENDA")
                  
                    drStatus = dtLeyendaStatus.NewRow
                    drStatus("LEYENDA") = "LEYENDA"
                    drStatus(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(Blanco, Negro)
                    dtLeyendaStatus.Rows.Add(drStatus)

                    drStatus = dtLeyendaStatus.NewRow
                    drStatus("LEYENDA") = "EN FABRICACION"
                    drStatus(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(Blanco, Negro)
                    dtLeyendaStatus.Rows.Add(drStatus)

                    drStatus = dtLeyendaStatus.NewRow
                    drStatus("LEYENDA") = "EN EMBARCADOR/TRÁNSITO/ADUANAS"
                    drStatus(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(LIGHT_YELLOW, Negro)
                    dtLeyendaStatus.Rows.Add(drStatus)

                    drStatus = dtLeyendaStatus.NewRow
                    drStatus("LEYENDA") = "ENTREGADO EN OBRA / ALMACÉN DE TRÁNSITO"
                    drStatus(ColNameFormato) = HelpClass_NPOI_SC.FormatoFila(LIGHT_GREEN, Negro)
                    dtLeyendaStatus.Rows.Add(drStatus)

                    ListLeyenda.Add(dtLeyendaCanal)
                    ListLeyenda.Add(dtLeyendaStatus)


                End If
                odtTa = odtSegAduanas.Copy
                Dim oLisParametros As New SortedList
                oLisParametros(0) = "CLIENTE:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
                oLisParametros(1) = "DESDE | " & dtpInicio.Value.ToShortDateString & " AL " & dtpFin.Value.ToShortDateString
                Dim Titulo As String = "SEGUIMIENTO ADUANERO "
                Dim NFilas As String = NPOI_SC.keySepNFilas
                Dim ColNFilas As String = "NORCML" & NFilas & "TOBERV" & NFilas & "TOBERVDIF" & NFilas & "NUMFAC" & NFilas & "TCITCLOC" & NFilas & _
                   "QCNTITOC" & NFilas & "QRLCSCEMB" & NFilas & "TTINTC" & NFilas & "NRITOCS" & NFilas & "CONDPAGO" & NFilas & _
                   "PARARN" & NFilas & "TPAGME" & NFilas & "MONEDA" & NFilas & "NREFCL" & NFilas & "FORCML" & NFilas & _
                   "CODTPN" & NFilas & "TOBERVEMB" & NFilas & "TNOMCOM"
                Ransa.Utilitario.HelpClass_NPOI_SC.ExportExcelSeguimientoAduanas(odtTa, Titulo, ColNFilas, oLisParametros, ListLeyenda)

            ElseIf chkVistaExtendida.Checked = False Then





                Dim NPOI_SC As New HelpClass_NPOI_SC
                Dim lstrPeriodo As String = ""
                Dim dtExport As New DataTable
                Dim ColName As String = ""
                Dim ColCaption As String = ""
                Dim MdataColumna As String = ""

                Dim TableName As String = ""
                Dim ColTitle As String = ""
                Dim TipoDato As String = ""

                For Each Item As DataGridViewColumn In dtgSegAduaneroReducido.Columns
                    ColTitle = Item.HeaderText.Trim
                    ColName = Item.Name
                    TipoDato = ""
                    If Item.Visible = True Then
                        Select Case ColName
                            Case "FORSCI_R", "FAPREV_R", "FAPRAR_R"
                                TipoDato = NPOI_SC.keyDatoFecha
                                'FECHAS
                            Case Else
                                'TEXTO
                                TipoDato = NPOI_SC.keyDatoTexto
                        End Select

                        If ColName = "IMG_STATUS" Then
                            Continue For
                        End If

                        dtExport.Columns.Add(ColName)
                        MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                        dtExport.Columns(ColName).Caption = MdataColumna
                    End If
                Next
                Dim dr As DataRow
                For Fila As Integer = 0 To dtgSegAduaneroReducido.Rows.Count - 1
                    dr = dtExport.NewRow
                    For Columna As Integer = 0 To dtExport.Columns.Count - 1
                        ColName = dtExport.Columns(Columna).ColumnName
                        If (dtgSegAduaneroReducido.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                            dr(ColName) = dtgSegAduaneroReducido.Rows(Fila).Cells(ColName).FormattedValue
                        End If
                    Next
                    dtExport.Rows.Add(dr)
                Next
             

                Dim ListaDatatable As New List(Of DataTable)
                ListaDatatable.Add(dtExport.Copy)

                Dim LisFiltros As New List(Of SortedList)
                Dim itemSortedList As SortedList

                itemSortedList = New SortedList
                itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
                itemSortedList.Add(itemSortedList.Count, "Desde | " & dtpInicio.Value.ToShortDateString & " al " & dtpFin.Value.ToShortDateString)
                LisFiltros.Add(itemSortedList)

                Dim ListTitulo As New List(Of String)
                ListTitulo.Add("SEGUIMIENTO ADUANERO RESUMEN")

                NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

#End Region

    Private Sub AutorizacionPortal()
        Dim oclsCliente As New clsCliente
        Dim CCLNT_PORTAL As Decimal = 0
        CCLNT_PORTAL = oclsCliente.fdsCodigoClienteDelPortar(cmbCliente.pCodigo)
        If CCLNT_PORTAL > 0 Then
            If (Me.STSOP11) Then
                btnImpInfEmb.Visible = True
                btnActPortal.Visible = False
            Else
                btnImpInfEmb.Visible = True
                btnActPortal.Visible = False
            End If
        Else
            If (Me.STSCHG1) Then
                btnImpInfEmb.Visible = True
                btnActPortal.Visible = False
            Else
                btnImpInfEmb.Visible = False
                btnActPortal.Visible = False
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If oEmbarque IsNot Nothing Then
            oEmbarque.Inicializar()
        End If
        dblEmbSelec = 0
        Try
            If Me.cmbCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Debe de seleccionar un cliente")
                Exit Sub
            End If
            btnReaperturar.Visible = False

            Dim oclsCierreEmbarque As New clsCierreEmbarque
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If (chkVistaExtendida.Checked = True) Then
                Filtrar_SegAduanero()
                AutorizacionPortal()
                Limpiar_Informacion()
                If dtgSegAduanero.RowCount > 0 Then
                    dblEmbSelec = dtgSegAduanero.Rows(0).Cells("NORSCI").Value
                    dblEmbSelecEstado = dtgSegAduanero.Rows(0).Cells("SESTRG").Value.ToString.Trim
                    Cargar_Informacion_Embarque()
                    btnReaperturar.Visible = (oclsCierreEmbarque.NoContieneACliente(oEmbarque.pCCLNT) And IsEmbarqueCerrado(oEmbarque.EmbarqueEstado))
                End If
            Else
                Limpiar_Informacion()
                Llenar_Aduanero_Vista_Basica()
                AutorizacionPortal()
                If dtgSegAduaneroReducido.RowCount > 0 Then
                    dblEmbSelec = dtgSegAduaneroReducido.Rows(0).Cells("NORSCI_R").Value
                    dblEmbSelecEstado = dtgSegAduaneroReducido.Rows(0).Cells("SESTRG_R").Value
                    Cargar_Informacion_Embarque()
                    btnReaperturar.Visible = (oclsCierreEmbarque.NoContieneACliente(oEmbarque.pCCLNT) And IsEmbarqueCerrado(oEmbarque.EmbarqueEstado))
                End If
            End If




            Me.Cursor = System.Windows.Forms.Cursors.Default


            HabilitarEdicionControlXEstado()
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Function ObtenerFiltroDatos() As beSeguimientoCargaFiltro
        Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
        Dim PSCPRVCL As String = ""
        Dim strEstado As String = ""
        Dim IsNumero As Boolean = False
        oFiltroEmbarque.PSCCMPN = GetCompania()
        oEmbarque.pCCLNT = Me.cmbCliente.pCodigo
        PSCPRVCL = UcProveedor.pCodigo

        Dim NORSCI As Decimal = 0
        Dim PNNMOS As Decimal = 0

        If cmbEstado.SelectedValue = "0" Then
            strEstado = "T"
        Else
            strEstado = Me.cmbEstado.SelectedValue
        End If
        oFiltroEmbarque.PNCCLNT = oEmbarque.pCCLNT
        oFiltroEmbarque.PNFECINI = dtpInicio.Value.ToString("yyyyMMdd")
        oFiltroEmbarque.PNFECFIN = dtpFin.Value.ToString("yyyyMMdd")
        oFiltroEmbarque.PSNORCML = txtOC.Text.Trim
        oFiltroEmbarque.PSCPRVCL = UcProveedor.pCodigo

        If txtFilOS.Text.Trim.Length > 0 Then
            IsNumero = Decimal.TryParse(txtFilOS.Text.Trim, PNNMOS)
            oFiltroEmbarque.PSPNNMOS = PNNMOS
        End If

        oFiltroEmbarque.PSDOCEMB = txtDocEmbarque.Text.Trim

        If Me.txtEmbarque.Text.Trim.Length > 0 Then
            IsNumero = Decimal.TryParse(txtEmbarque.Text.Trim, NORSCI)
            oFiltroEmbarque.PSNORSCI = NORSCI
        End If

        If cboTipoOperacion.SelectedValue = "0" Then
            oFiltroEmbarque.PSTPSRVA = "T"
        ElseIf cboTipoOperacion.SelectedValue <> "0" Then
            oFiltroEmbarque.PSTPSRVA = cboTipoOperacion.SelectedValue
        End If
        oFiltroEmbarque.PSSESTRG = strEstado
        oFiltroEmbarque.PSCDVSN = cmbPlanta.CodigoDivision
        oFiltroEmbarque.PNCPLNDV = cmbPlanta.Planta

        Return oFiltroEmbarque

    End Function

    Private Sub Filtrar_SegAduanero()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dblEmbSelec = 0
        dblEmbSelecEstado = ""
        Limpiar_Informacion()
        Dim oFuncionServSeguimiento As New FuncionServSeguimiento
        Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
        If cmbCliente.pCodigo <> 0 Then
            oFiltroEmbarque = ObtenerFiltroDatos()
            If cboIdioma.SelectedValue = "IN" Then
                oFuncionServSeguimiento.CrearConfigurarColumnas(oFiltroEmbarque, FuncionServSeguimiento.ENUM_IDIOMA.ING, dtgSegAduanero)
            ElseIf cboIdioma.SelectedValue = "ES" Then
                oFuncionServSeguimiento.CrearConfigurarColumnas(oFiltroEmbarque, FuncionServSeguimiento.ENUM_IDIOMA.ESP, dtgSegAduanero)
            End If
            Dim oListTipoCarga As New List(Of beTipoDato)
            Dim oCloneList As New CloneObject(Of beTipoDato)
            Dim oCloneListRegimen As New CloneObject(Of beRegimen)
            oListTipoCarga = oCloneList.CloneListObject(oListGenTipoCarga)
            Dim oListDespacho As New List(Of beTipoDato)
            oListDespacho = oCloneList.CloneListObject(oListGenTipoDespacho)
            Dim oListAlmacenDestinoLocal As New List(Of beTipoDato)
            oListAlmacenDestinoLocal = oCloneList.CloneListObject(oListGenAlmacenDestinoLocal)
            If (dtgSegAduanero.Columns("PRARAN") IsNot Nothing) Then
                If odtMaestroPartidasArancelarias.Rows.Count = 0 Then
                    odtMaestroPartidasArancelarias = oEmbarque.Lista_Maestro_Partidas_Arancelarias_Embarque()
                End If
            End If


            Dim PSCCMPN As String = oFiltroEmbarque.PSCCMPN
            Dim PNCCLNT As Decimal = oFiltroEmbarque.PNCCLNT
            oFuncionServSeguimiento.Llenar_Seguimiento_Aduanero(oFiltroEmbarque, dtgSegAduanero, oListTipoCarga, oListDespacho, oListAlmacenDestinoLocal, odtMaestroPartidasArancelarias, objDtDia)

        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
   


    Private Sub ActualizaDatoCeldaGridExt(ByVal Fila As Int32, ByVal NameColumna As String, ByVal Valor As String)
        If dtgSegAduanero.Columns(NameColumna) IsNot Nothing Then
            dtgSegAduanero.Rows(Fila).Cells(NameColumna).Value = Valor
        End If
    End Sub


    Private Sub Actualizar_Grilla(ByVal TIPO_UPDATE As ACTUALIZACION_GRILLA, Optional ByVal strDato As String = "")
        If (chkVistaExtendida.Checked = False) Then Exit Sub
        Dim intCont As Integer
        Dim intDoc As Integer

        Dim intIndice As Integer
        Dim intContTabla As Integer
        Dim FechaOriginal As String = ""
        Dim FechaCopia As String = ""
        Dim NumeroDoc As String = ""

        Dim oFuncionServSeguimiento As New FuncionServSeguimiento
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim tFactura As String = ""
        Select Case TIPO_UPDATE
            Case ACTUALIZACION_GRILLA.DOCADJUNTO   '2 '
                oFuncionServSeguimiento.ActualizarFechaActualizacionReg(dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                Dim strFact As String = vbNullString

                Dim PosFilaEmb As Int32 = BuscarFilaEmbarque(Me.dblEmbSelec)

                Dim dtDocumento As New DataTable
                Dim drDoc As DataRow
                Dim ValorDoc As String = ""
                Dim PNNORSCI As Decimal = Me.dblEmbSelec
                dtDocumento.Columns.Add("NORSCI", GetType(System.Decimal))
                dtDocumento.Columns.Add("NDOCLI")
                dtDocumento.Columns.Add("NDOCIN", GetType(System.Decimal))
                dtDocumento.Columns.Add("FCDCOR")
                dtDocumento.Columns.Add("FCDCCP")
                Dim EsFecha As Boolean = False
                Dim ValorFecha As DateTime
                For intDoc = 0 To dtgDocumentos.Rows.Count - 1
                    drDoc = dtDocumento.NewRow
                    drDoc("NORSCI") = PNNORSCI
                    drDoc("NDOCIN") = dtgDocumentos.Rows(intDoc).Cells("TDOCIN").Value
                    drDoc("NDOCLI") = ("" & dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value).ToString.Trim
                    EsFecha = Date.TryParse(("" & dtgDocumentos.Rows(intDoc).Cells("FECORG").Value).ToString.Trim, ValorFecha)
                    If EsFecha = True Then
                        drDoc("FCDCOR") = CType(ValorFecha, Date).ToString("yyyyMMdd")
                    Else
                        drDoc("FCDCOR") = 0
                    End If

                    EsFecha = Date.TryParse(("" & dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value).ToString.Trim, ValorFecha)
                    If EsFecha = True Then
                        drDoc("FCDCCP") = CType(ValorFecha, Date).ToString("yyyyMMdd")
                    Else
                        drDoc("FCDCCP") = 0
                    End If
                    dtDocumento.Rows.Add(drDoc)
                Next


                ValorDoc = oFnAduanas.Fecha_Factura_Copia(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "FACCOP", ValorDoc)

                ValorDoc = oFnAduanas.Fecha_Factura_Original(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "FACORG", ValorDoc)


                ValorDoc = oFnAduanas.Fecha_DocEmbarque_Copia(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "DEMCOP", ValorDoc)

                ValorDoc = oFnAduanas.Fecha_DocEmbarque_Original(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "DEMORG", ValorDoc)


                ValorDoc = oFnAduanas.Fecha_Traduccion_Copia(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "TRACOP", ValorDoc)

                ValorDoc = oFnAduanas.Fecha_Traduccion_Original(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "TRAORG", ValorDoc)

            
                ValorDoc = oFnAduanas.Fecha_Volante_Copia(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "VOLCOP", ValorDoc)

                ValorDoc = oFnAduanas.Fecha_Volante_Original(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "VOLORG", ValorDoc)


                ValorDoc = oFnAduanas.Fecha_Seguro_Copia(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "SEGCOP", ValorDoc)

                ValorDoc = oFnAduanas.Fecha_Seguro_Original(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "SEGORG", ValorDoc)


                ValorDoc = oFnAduanas.Fecha_Certificado_Origen_Copia(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "CORCOP", ValorDoc)

                ValorDoc = oFnAduanas.Fecha_Certificado_Origen_Original(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "CORORG", ValorDoc)
             
                ValorDoc = oFnAduanas.Fecha_Otro_Documento_Original(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "OTRORG", ValorDoc)


                ValorDoc = oFnAduanas.Buscar_Doc_Emb(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "DOCEMB", ValorDoc)

                ValorDoc = oFnAduanas.Buscar_Seguro(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "NUMSEG", ValorDoc)


                ValorDoc = oFnAduanas.Llenar_Factura(dtDocumento, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "NUMFAC", ValorDoc)



            Case ACTUALIZACION_GRILLA.EMBARQUE '3
                oFuncionServSeguimiento.ActualizarFechaActualizacionReg(dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                Dim oListTipoCarga As New List(Of beTipoDato)
                Dim oCloneList As New CloneObject(Of beTipoDato)
                oListTipoCarga = oCloneList.CloneListObject(oListGenTipoCarga)
                Dim strCarga As String = ""
                Dim strCant As String = ""
                For intCont = 0 To dtgSegAduanero.Rows.Count - 1
                    If Double.Parse(dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                        With dtgSegAduanero.Rows(intCont)
                            If Not dtgSegAduanero.Columns.Item("CVPRCN") Is Nothing Then
                                If ctbMedioTransportes.SelectedValue = 2D Then 'MARITIMO
                                    .Cells("CVPRCN").Value = ctbNave.Descripcion.Trim
                                Else
                                    .Cells("CVPRCN").Value = ctbCiaTransp.Descripcion.Trim
                                End If

                            End If

                            If Not dtgSegAduanero.Columns.Item("CPRTOE") Is Nothing Then

                                If cmbPuertoOrg.SelectedValue = "-1" Then
                                    If cmbPaisOrg.SelectedValue = -1D Then
                                        .Cells("CPRTOE").Value = ""
                                    Else
                                        .Cells("CPRTOE").Value = oFnAduanas.FormatearPuerto(cmbPaisOrg.Text.Trim, "")
                                    End If
                                Else
                                    .Cells("CPRTOE").Value = oFnAduanas.FormatearPuerto(cmbPaisOrg.Text.Trim, cmbPuertoOrg.Text.Trim)
                                End If

                            End If

                            If dtgSegAduanero.Columns.Item("CPRTOA") IsNot Nothing Then

                                If cmbPuertoDest.SelectedValue = "-1" Then
                                    If cmbPaisDest.SelectedValue = -1D Then
                                        .Cells("CPRTOA").Value = ""
                                    Else
                                        .Cells("CPRTOA").Value = oFnAduanas.FormatearPuerto(cmbPaisDest.Text.Trim, "")
                                    End If
                                Else
                                    .Cells("CPRTOA").Value = oFnAduanas.FormatearPuerto(cmbPaisDest.Text.Trim, cmbPuertoDest.Text.Trim)
                                End If
                            End If

                            If Not dtgSegAduanero.Columns.Item("TNIMCIN") Is Nothing Then
                                If ctbMedioTransportes.SelectedValue = 2D Then
                                    If ctbCiaTransp.Descripcion.Trim <> vbNullString Then
                                        .Cells("TNIMCIN").Value = ctbCiaTransp.Descripcion.Trim
                                    Else
                                        .Cells("TNIMCIN").Value = ""
                                    End If
                                Else
                                    .Cells("TNIMCIN").Value = ""
                                End If
                            End If
                            If Not dtgSegAduanero.Columns.Item("REGIMEN") Is Nothing Then
                                If txtRegimen.Tag = -1D Then
                                    .Cells("REGIMEN").Value = ""
                                Else
                                    .Cells("REGIMEN").Value = txtRegimen.Text.ToString.Trim
                                End If
                            End If

                            If Not dtgSegAduanero.Columns.Item("DESPACHO") Is Nothing Then

                                If cmbTipoDespachos.SelectedValue = -1D Then
                                    .Cells("DESPACHO").Value = ""
                                Else
                                    .Cells("DESPACHO").Value = cmbTipoDespachos.Text.ToString.Trim
                                End If

                            End If

                            If Not dtgSegAduanero.Columns.Item("CMEDTR") Is Nothing Then
                                If (ctbMedioTransportes.SelectedValue = -1D) Then
                                    .Cells("CMEDTR").Value = ""
                                Else
                                    .Cells("CMEDTR").Value = ctbMedioTransportes.Text.Trim
                                End If

                            End If

                            If Not dtgSegAduanero.Columns.Item("CANAL") Is Nothing Then
                                If cboCanal.SelectedValue = "-1" Then
                                    .Cells("CANAL").Value = ""
                                Else
                                    .Cells("CANAL").Value = cboCanal.SelectedValue.ToString.Trim
                                End If

                            End If


                            If Not dtgSegAduanero.Columns.Item("NUMDUA") Is Nothing Then
                                .Cells("NUMDUA").Value = txtDUA.Text.Trim
                            End If

                            If Not dtgSegAduanero.Columns.Item("TPRVCL") Is Nothing Then
                                .Cells("TPRVCL").Value = UcProveedor_tab.pRazonSocial
                            End If

                            If Not dtgSegAduanero.Columns.Item("QPSOAR") Is Nothing Then
                                .Cells("QPSOAR").Value = IIf(txtKg.Text.Trim = "", 0, txtKg.Text.Trim)
                            End If
                            If Not dtgSegAduanero.Columns.Item("NDIALB") Is Nothing Then
                                .Cells("NDIALB").Value = IIf(txtDiaLibre.Text.Trim = "", 0, txtDiaLibre.Text.Trim)
                            End If
                            If Not dtgSegAduanero.Columns.Item("NDIASE") Is Nothing Then
                                .Cells("NDIASE").Value = IIf(txtSobreEstadia.Text.Trim = "", 0, txtSobreEstadia.Text.Trim)
                            End If
                            If Not dtgSegAduanero.Columns.Item("QVOLMR") Is Nothing Then
                                .Cells("QVOLMR").Value = IIf(txtM3.Text.Trim = "", 0, txtM3.Text.Trim)
                            End If

                            Dim dtCarga As New DataTable
                            dtCarga.Columns.Add("NORSCI", GetType(System.Decimal))
                            dtCarga.Columns.Add("NTPODT", GetType(System.Decimal))
                            dtCarga.Columns.Add("NCODRG", GetType(System.Decimal))
                            dtCarga.Columns.Add("QCANTI", GetType(System.Decimal))
                            Dim dr As DataRow
                            For intIndice = 0 To Me.dtgCarga.Rows.Count - 1
                                dr = dtCarga.NewRow
                                dr("NORSCI") = dblEmbSelec
                                dr("NTPODT") = 9
                                dr("NCODRG") = dtgCarga.Rows(intIndice).Cells("CARGA").Value
                                dr("QCANTI") = HelpClass.ToDecimalCvr(dtgCarga.Rows(intIndice).Cells("NBULTO").Value)
                                dtCarga.Rows.Add(dr)

                            Next intIndice

                            If Not dtgSegAduanero.Columns.Item("TCARGA") Is Nothing Then
                                .Cells("TCARGA").Value = oFnAduanas.TipoCargaDesc_X_Embarque(oListTipoCarga, dtCarga, dblEmbSelec)
                            End If
                            If Not dtgSegAduanero.Columns.Item("NBLTAR") Is Nothing Then
                                .Cells("NBLTAR").Value = oFnAduanas.TipoCargaCantidad_X_Embarque(dtCarga, dblEmbSelec)
                            End If

                            If Not dtgSegAduanero.Columns.Item("PNNMOS") Is Nothing Then
                                .Cells("PNNMOS").Value = txtNroOS.Text.Trim
                            End If
                            If Not dtgSegAduanero.Columns.Item("TDITES") Is Nothing Then
                                .Cells("TDITES").Value = txtMercaderia.Text.Trim
                            End If
                            If dtgSegAduanero.Columns.Item("CTRSPT") IsNot Nothing Then
                                dtgSegAduanero.Rows(intCont).Cells("CTRSPT").Value = uc_Transportista.pPSTCMTRT
                            End If
                            If dtgSegAduanero.Columns.Item("ALMDES") IsNot Nothing Then
                                dtgSegAduanero.Rows(intCont).Cells("ALMDES").Value = Uc_Almacen_Local.pPSTDSCRG
                            End If
                            If dtgSegAduanero.Columns.Item("NREFCLEMB") IsNot Nothing Then
                                dtgSegAduanero.Rows(intCont).Cells("NREFCLEMB").Value = txtRefCli.Text.Trim
                            End If
                            If dtgSegAduanero.Columns.Item("REFDO1") IsNot Nothing Then
                                dtgSegAduanero.Rows(intCont).Cells("REFDO1").Value = txtRefDoc.Text.Trim
                            End If

                            If dtgSegAduanero.Columns.Item("CAGNAD") IsNot Nothing Then
                                dtgSegAduanero.Rows(intCont).Cells("CAGNAD").Value = Uc_AgenteAduana.pTCMAA
                            End If

                            If dtgSegAduanero.Columns.Item("RESPONS") IsNot Nothing Then
                                dtgSegAduanero.Rows(intCont).Cells("RESPONS").Value = txtResponsableCliente.Text.Trim
                            End If

                            Dim oFnEmbarque As New clsEmbarqueAduanas
                            If dtgSegAduanero.Columns.Item("TAGENCIAAD") IsNot Nothing Then
                                dtgSegAduanero.Rows(intCont).Cells("TAGENCIAAD").Value = oFnEmbarque.EsTransporteAgAduana(cmbTransporte.SelectedValue)
                            End If

                            If Not dtgSegAduanero.Columns.Item("CTRMAL") Is Nothing Then
                                .Cells("CTRMAL").Value = ctbTerminal.Descripcion
                            End If

                            If Not dtgSegAduanero.Columns.Item("CAGNCR") Is Nothing Then
                                .Cells("CAGNCR").Value = ctbAgenteDeCarga.Descripcion
                            End If

                            If dtgSegAduanero.Columns.Item("CMEDTRAGEN") IsNot Nothing Then
                                If (cmbTransporte.SelectedValue = -1D) Then
                                    dtgSegAduanero.Rows(intCont).Cells("CMEDTRAGEN").Value = ""
                                Else
                                    dtgSegAduanero.Rows(intCont).Cells("CMEDTRAGEN").Value = cmbTransporte.Text.Trim
                                End If
                            End If
                        End With
                        Exit For
                    End If
                Next intCont

            Case ACTUALIZACION_GRILLA.COSTOS '4
                oFuncionServSeguimiento.ActualizarFechaActualizacionReg(dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)

                Dim PosFilaEmb As Int32 = BuscarFilaEmbarque(Me.dblEmbSelec)
                Dim dtTemPoral As New DataTable
                Dim dtCostos As New DataTable
                Dim drCosto As DataRow
                dtCostos.Columns.Add("NORSCI")
                dtCostos.Columns.Add("CODVAR")
                dtCostos.Columns.Add("IVLDOL")
                Dim NORSCI As Decimal = Me.dblEmbSelec
                Dim CostoEmb As String = ""

                Dim NameVar As String = ""
                For intContTabla = 0 To oDs.Tables.Count - 1
                    dtTemPoral = oDs.Tables.Item(intContTabla).Copy
                    For Fila As Integer = 0 To dtTemPoral.Rows.Count - 1
                        If dtTemPoral.Rows(Fila)("IVLDOL") IsNot DBNull.Value Then
                            drCosto = dtCostos.NewRow
                            drCosto("NORSCI") = NORSCI
                            drCosto("CODVAR") = dtTemPoral.Rows(Fila)("VALVAR")
                            drCosto("IVLDOL") = dtTemPoral.Rows(Fila)("IVLDOL")
                            dtCostos.Rows.Add(drCosto)
                        End If
                    Next
                Next

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "ITTEXW", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "EXW", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "GFOB", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "GFOB", CostoEmb)


                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "FOB", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "FOB", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "FOB", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "FOB", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "FLETE", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "FLETE", CostoEmb)


                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "SEGURO", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "SEGURO", CostoEmb)


                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "CIF", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "CIF", CostoEmb)


                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "ADVALO", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "ADVALOREM", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "IGV", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "IGV", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "IPM", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "IPM", CostoEmb)
           
                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "TOLDER", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "TOTALDER", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "ITTGOA", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "ITTGOA", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "ITTCAG", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "ITTCAG", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "TASDES", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "TASDES", CostoEmb)

                'CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "OTSGAS", dtCostos)
                'ActualizaDatoCeldaGridExt(PosFilaEmb, "OTSGAS", CostoEmb)

                CostoEmb = oFnAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, "ITTCEM", dtCostos)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "ITTCEM", CostoEmb)

                'CostoEmb = oFuncionServSeguimiento.CalculaTotalOtrosCostos(dtCostos, NORSCI)
                'ActualizaDatoCeldaGridExt(PosFilaEmb, "GASVAR", CostoEmb)
                CostoEmb = oFuncionServSeguimiento.CalculaTotalOtrosCostos(dtCostos, NORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "COSVAR", CostoEmb)


                oFuncionServSeguimiento.ActualizarCalculosColumnas(objDtDia, dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)

            Case ACTUALIZACION_GRILLA.OBSERVACION '5

                oFuncionServSeguimiento.ActualizarFechaActualizacionReg(dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                Dim obrFnEmbarque As New clsEmbarqueAduanas
                Dim odtObsCI As New DataTable
                odtObsCI.Columns.Add("TOBS")
                odtObsCI.Columns.Add("FECOBS", Type.GetType("System.Decimal"))
                odtObsCI.Columns.Add("NORSCI")
                Dim drCI As DataRow

                Dim odtObsEmb As New DataTable
                odtObsEmb.Columns.Add("NORSCI")
                odtObsEmb.Columns.Add("TOBS")
                odtObsEmb.Columns.Add("FECOBS", Type.GetType("System.Decimal"))
                Dim strFecha As String = ""
                Dim dFecha As Date
                Dim drEmb As DataRow
                Dim valor As String = ""

                Dim PosFilaEmb As Int32 = BuscarFilaEmbarque(Me.dblEmbSelec)
                Dim PNNORSCI As Decimal = Me.dblEmbSelec

                For intIndice = 0 To Me.dtgObsCargaInternacional.Rows.Count - 1
                    drCI = odtObsCI.NewRow
                    drCI("NORSCI") = dblEmbSelec
                    drCI("TOBS") = dtgObsCargaInternacional.Rows(intIndice).Cells("CITOBS").Value.ToString
                    strFecha = ("" & dtgObsCargaInternacional.Rows(intIndice).Cells("CIFECOBS").Value).ToString.Trim
                    If Date.TryParse(strFecha, dFecha) Then
                        drCI("FECOBS") = dFecha.ToString("yyyyMMdd")
                    Else
                        drCI("FECOBS") = 0
                    End If
                    odtObsCI.Rows.Add(drCI)
                Next
                For intIndice = 0 To dtgObservaciones.Rows.Count - 1
                    drEmb = odtObsEmb.NewRow
                    drEmb("NORSCI") = dblEmbSelec
                    drEmb("TOBS") = dtgObservaciones.Rows(intIndice).Cells("OBSERV").Value.ToString
                    strFecha = ("" & dtgObservaciones.Rows(intIndice).Cells("FECOBS").Value).ToString.Trim
                    If Date.TryParse(strFecha, dFecha) Then
                        drEmb("FECOBS") = dFecha.ToString("yyyyMMdd")
                    Else
                        drEmb("FECOBS") = 0
                    End If

                    odtObsEmb.Rows.Add(drEmb)
                Next

                valor = obrFnEmbarque.Buscar_Observaciones_NoDiferenciado(odtObsCI, odtObsEmb, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "TOBERV", valor)

                valor = obrFnEmbarque.Buscar_Observaciones_Diferenciado(odtObsCI, odtObsEmb, PNNORSCI)
                ActualizaDatoCeldaGridExt(PosFilaEmb, "TOBERVDIF", valor)


            Case ACTUALIZACION_GRILLA.DUA '6
                oFuncionServSeguimiento.ActualizarFechaActualizacionReg(dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)

                If Not Me.dtgSegAduanero.Columns.Item("NUMDUA") Is Nothing Then
                    Me.dtgSegAduanero.CurrentRow.Cells("NUMDUA").Value = strDato
                End If

            Case ACTUALIZACION_GRILLA.CHECKPOINT

                oFuncionServSeguimiento.ActualizarFechaActualizacionReg(dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)
                Dim FechaETD As String = ""
                Dim FechaValorETD As Date
                Dim FechaETA As String = ""
                Dim FechaValorETA As Date
                '***********ETD***************
                If Date.TryParse(mskETD.Text.Trim, FechaValorETD) Then
                    FechaETD = FechaValorETD.ToString("dd/MM/yyyy")
                End If
                If Date.TryParse(mskETA.Text.Trim, FechaValorETA) Then
                    FechaETA = FechaValorETA.ToString("dd/MM/yyyy")
                End If
                If dtgSegAduanero.Columns("CHKETD") IsNot Nothing Then
                    dtgSegAduanero.CurrentRow.Cells("CHKETD").Value = FechaETD
                End If
                If Not Me.dtgSegAduanero.Columns.Item("CHKETA") Is Nothing Then 'Ahora se actualiza cuando se graba fecha por fecha 23/01/2009
                    Me.dtgSegAduanero.CurrentRow.Cells("CHKETA").Value = FechaETA
                End If
                Dim NomCheck As String = ""
                For intCont = 0 To Me.dtgCheckPoint.Rows.Count - 1
                    NomCheck = ("" & dtgCheckPoint.Rows(intCont).Cells("TABRST").Value).ToString.Trim
                    If dtgSegAduanero.Columns(NomCheck) IsNot Nothing Then
                        dtgSegAduanero.CurrentRow.Cells(NomCheck).Value = ("" & dtgCheckPoint.Rows(intCont).Cells("FRETES").Value).ToString.Trim
                    End If
                Next

                oFuncionServSeguimiento.ActualizarCalculosColumnas(objDtDia, dtgSegAduanero, dtgSegAduanero.CurrentRow.Index)

        End Select
    End Sub

    Private Function BuscarFilaEmbarque(ByVal NORSCI As Decimal) As Int32
        Dim FilaEmb As Int32 = -1
        For Fila As Int32 = 0 To dtgSegAduanero.Rows.Count - 1
            If dtgSegAduanero.Rows(Fila).Cells("NORSCI").Value = NORSCI Then
                FilaEmb = Fila
                Exit For
            End If
        Next
        Return FilaEmb
    End Function

  

    Private Sub btnETD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnETD.Click
        Me.mskETD.Text = Me.mskETD.Text.Trim
        Dim Val_Fecha As Boolean = False
        Dim FnEmbarque As New clsEmbarqueAduanas
        Try
            Dim EnviarCorreo As Boolean = False

            If mskETD.ReadOnly Then
                mskETD.ReadOnly = False
                btnETD.ImageIndex = 0
                ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Guardar ETD" & vbCrLf & "Presionar ESC para Cancelar")
            Else
                If Me.mskETD.Text.Trim.Length > 4 Then
                    If Not FnEmbarque.isValidFecha(Me.mskETD.Text.Trim) Then
                        Val_Fecha = False
                    Else
                        Val_Fecha = True
                    End If
                    If Val_Fecha = False Then
                        Me.ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Guardar ETD" & vbCrLf & "Presionar ESC para Cancelar")
                        MessageBox.Show("Fecha ETD no válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                mskETD.ReadOnly = True
                btnETD.ImageIndex = 1
                ttlAduanas.SetToolTip(btnETD, "Presionar para Editar ETD")

                If Val_Fecha = True Then
                    Dim PSFORMATOENVIO As String = "" 'Variable para obtener el formato
                    '**************ADICION PARA ENVIO DE EMAIL X CAMBIO CHECKPOINT****************************
                    Control.CheckForIllegalCrossThreadCalls = False
                    PARAM_PSTNMBCM = "FAPREV"
                    Dim CodFormato As String = ""
                    Dim obeCheckPointFind As Ransa.Servicio.EmailCheckPointAduana.beCheckPointEnvio

                    oclsCheckPointEnvio = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointNotifGeneral

                    Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
                    odaClienteEnvio.Asignar_Lista_Cliente_Envio_Notificacion(dtListaClienteEnvioxModCheckpoint)
                    CodFormato = odaClienteEnvio.RetornaFormatoEnvio_X_Cliente(oEmbarque.pCCLNT)

                    oclsCheckPointEnvio.CodFormato = CodFormato
                    oclsCheckPointEnvio.Tipo_Envio = odaClienteEnvio.Tipo_Envio_Chk_x_Aduana
                    If (odaClienteEnvio.DebeNotificarEnvio_X_Cliente(oEmbarque.pCCLNT) And CodFormato <> "") Then
                     
                        oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        obeCheckPointFind = oclsCheckPointEnvio.ExisteChkEnvioxPSTNMBCM(PARAM_PSTNMBCM)
                        If (obeCheckPointFind IsNot Nothing) Then
                            EnviarCorreo = True
                        End If
                    End If
                    '*********************************************************************
                    oEmbarque.Mantenimiento_ETD_Embarque(oEmbarque.pNORSCI, Format(CType(Me.mskETD.Text.Trim, Date), "yyyyMMdd"))

                    Actualizar_Grilla(ACTUALIZACION_GRILLA.CHECKPOINT)
                    If (EnviarCorreo = True) Then
                        '****ADICIONADO PARA ABB************
                        oHebraCheckPointABB = New Thread(AddressOf EnviarActualizacionFechas_Interfaz_ABB_Asinc)
                        oHebraCheckPointABB.Start()
                        '************************************


                        oHebra = New Thread(AddressOf ProcesarEnvioEmail_x_Change_CHK)
                        oHebra.Start()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnETA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnETA.Click
        Dim Val_Fecha As Boolean = False
        mskETA.Text = mskETA.Text.Trim
        Dim FnEmbarque As New clsEmbarqueAduanas
        Try
            Dim EnviarCorreo As Boolean = False
            If mskETA.ReadOnly Then
                mskETA.ReadOnly = False
                btnETA.ImageIndex = 0
                ttlAduanas.SetToolTip(btnETA, "Presionar para Guardar ETA" & vbCrLf & "Presionar ESC para Cancelar")
            Else
                If mskETA.Text.Trim.Length > 4 Then
                    If Not FnEmbarque.isValidFecha(mskETA.Text.Trim) Then
                        Val_Fecha = False
                    Else
                        Val_Fecha = True
                    End If

                    If Val_Fecha = False Then
                        ttlAduanas.SetToolTip(Me.btnETA, "Presionar para Guardar ETA" & vbCrLf & "Presionar ESC para Cancelar")
                        MessageBox.Show("Fecha ETA no válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                mskETA.ReadOnly = True
                btnETA.ImageIndex = 1
                ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Editar ETA")
                If Val_Fecha = True Then
                    'Dim PSFORMATOENVIO As String = "" 'Variable para obtener el formato
                    Dim CodFormato As String = ""
                    '**************ADICION PARA ENVIO DE EMAIL X CAMBIO CHECKPOINT****************************
                    Control.CheckForIllegalCrossThreadCalls = False
                    PARAM_PSTNMBCM = "FAPREV"
                    Dim obeCheckPointFind As Ransa.Servicio.EmailCheckPointAduana.beCheckPointEnvio

                    oclsCheckPointEnvio = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointNotifGeneral
                    Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
                    odaClienteEnvio.Asignar_Lista_Cliente_Envio_Notificacion(dtListaClienteEnvioxModCheckpoint)
                    CodFormato = odaClienteEnvio.RetornaFormatoEnvio_X_Cliente(oEmbarque.pCCLNT)

                    oclsCheckPointEnvio.CodFormato = CodFormato
                    oclsCheckPointEnvio.Tipo_Envio = odaClienteEnvio.Tipo_Envio_Chk_x_Aduana

                    If (odaClienteEnvio.DebeNotificarEnvio_X_Cliente(oEmbarque.pCCLNT) And CodFormato <> "") Then
                      
                        oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        obeCheckPointFind = oclsCheckPointEnvio.ExisteChkEnvioxPSTNMBCM(PARAM_PSTNMBCM)
                        If (obeCheckPointFind IsNot Nothing) Then
                            EnviarCorreo = True
                        End If
                    End If
                    '*********************************************************************
                    oEmbarque.Mantenimiento_ETA_Embarque(oEmbarque.pNORSCI, Format(CType(Me.mskETA.Text.Trim, Date), "yyyyMMdd"))
                    Actualizar_Grilla(ACTUALIZACION_GRILLA.CHECKPOINT)
                    If (EnviarCorreo = True) Then
                        '****ADICIONADO PARA ABB
                        oHebraCheckPointABB = New Thread(AddressOf EnviarActualizacionFechas_Interfaz_ABB_Asinc)
                        oHebraCheckPointABB.Start()
                        '**********************


                        oHebra = New Thread(AddressOf ProcesarEnvioEmail_x_Change_CHK)
                        oHebra.Start()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub mskETD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskETD.KeyDown
        If e.KeyCode = Keys.Escape Then
            mskETD.ReadOnly = True
            btnETD.ImageIndex = 1
            ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Editar ETD")
        End If
    End Sub

    Private Sub mskETA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskETA.KeyDown
        If e.KeyCode = Keys.Escape Then
            mskETA.ReadOnly = True
            btnETA.ImageIndex = 1
            ttlAduanas.SetToolTip(btnETA, "Presionar para Editar ETA")
        End If
    End Sub



    Private Sub Actualizar_Datos_OrdenesEmbarcadas()
        gvOrdenesEmb.EndEdit()
        Grabar_Facturas()
        Grabar_Partidas()
        Llenar_Detalle_Embarque()
    End Sub

    Private Sub Grabar_Facturas()
        gvOrdenesEmb.EndEdit()
        Dim Fila As Integer = 0
        Dim PNNRPEMB As Double = 0
        Dim PSNFCTCM As String = ""
        Dim PNQTPCM2 As Decimal = 0
        Dim PNNMITFC As Decimal = 0
        Dim PNNSEQIN As Decimal = 0
        For Fila = 0 To gvOrdenesEmb.Rows.Count - 1
            PSNFCTCM = HelpClass.ToStringCvr(gvOrdenesEmb.Rows(Fila).Cells("NFCTCM").Value)
            PNNRPEMB = gvOrdenesEmb.Rows(Fila).Cells("NRPEMB").Value
            PNQTPCM2 = HelpClass.ToDecimalCvr(gvOrdenesEmb.Rows(Fila).Cells("QTPCM2").Value)
            PNNMITFC = HelpClass.ToDecimalCvr(gvOrdenesEmb.Rows(Fila).Cells("NMITFC").Value)
            PNNSEQIN = HelpClass.ToDecimalCvr(gvOrdenesEmb.Rows(Fila).Cells("NSEQIN").Value)
            If gvOrdenesEmb.Rows(Fila).Cells("NSEQIN").Value IsNot DBNull.Value Then
                PNNSEQIN = gvOrdenesEmb.Rows(Fila).Cells("NSEQIN").Value
            Else
                PNNSEQIN = 0
            End If
            oEmbarque.Actualiza_Embarque_Datos(oEmbarque.pCCLNT, PNNRPEMB, oEmbarque.pNORSCI, PNQTPCM2, PSNFCTCM, PNNMITFC, PNNSEQIN)
        Next
    End Sub

    Private Sub Grabar_Partidas()
        gvOrdenesEmb.EndEdit()
        Dim Fila As Integer = 0
        Dim oDetOC As New clsDetOC
        Dim PNCCLNT As Decimal = 0
        Dim PSNORCML As String = ""
        Dim PSSBITOC As String = ""
        Dim PNNRITEM As Double = 0
        Dim PSCPTDAR As String = ""
        PNCCLNT = oEmbarque.pCCLNT
        For Fila = 0 To gvOrdenesEmb.Rows.Count - 1
            PSCPTDAR = gvOrdenesEmb.Rows(Fila).Cells("CPTDAR").Value.ToString.Trim
            PSNORCML = gvOrdenesEmb.Rows(Fila).Cells("NORCML").Value.ToString.Trim
            PNNRITEM = gvOrdenesEmb.Rows(Fila).Cells("NRITEM").Value
            PSSBITOC = gvOrdenesEmb.Rows(Fila).Cells("SBITOC").Value.ToString.Trim
            oDetOC.Actualiza_Item_OC_Partida(PNCCLNT, PSNORCML, PNNRITEM, PSCPTDAR, PSSBITOC)
        Next
    End Sub

#Region "CheckPoints"

    Private Sub Grabar_Checkpoint()
        Dim obeCheckPoint As beCheckPoint
        Dim FECHA As Date
        For Each item As DataGridViewRow In dtgCheckPoint.Rows
            obeCheckPoint = New beCheckPoint
            obeCheckPoint.PNNORSCI = oEmbarque.pNORSCI
            obeCheckPoint.PNNESTDO = item.Cells("NESTDO").Value
            obeCheckPoint.PSCEMB = item.Cells("CEMB").Value.ToString.Trim
            If Date.TryParse(item.Cells("FRETES").Value, FECHA) Then
                obeCheckPoint.PNFRETES = FECHA.ToString("yyyyMMdd")
            Else
                obeCheckPoint.PNFRETES = 0
            End If
            If Date.TryParse(item.Cells("FESEST").Value, FECHA) Then
                obeCheckPoint.PNFESEST = FECHA.ToString("yyyyMMdd")
            Else
                obeCheckPoint.PNFESEST = 0
            End If
            If IsNothing(item.Cells("TOBS").Value) Then
                obeCheckPoint.PSTOBS = ""
            Else
                obeCheckPoint.PSTOBS = item.Cells("TOBS").Value.ToString.Trim
            End If
            oEmbarque.Mantenimiento_Checkpoint(oEmbarque.pCCMPN, oEmbarque.pCDVSN, obeCheckPoint)
        Next
    End Sub


    Private Sub dtgCheckPoint_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCheckPoint.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim ColName As String = dtgCheckPoint.Columns(dtgCheckPoint.CurrentCell.ColumnIndex).Name
            If ColName = "FESEST" Or ColName = "FRETES" Then
                cmtChk.Items(0).Visible = True
            Else
                cmtChk.Items(0).Visible = False
            End If
        End If
    End Sub

#End Region

    Private Sub Grabar_Observaciones()
        Dim obeObservacion As beObservacionCarga
        Dim IsValido As Boolean = False
        Me.dtgObservaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
        With Me.dtgObservaciones
            For intCont As Int32 = 0 To .Rows.Count - 1
                IsValido = .Rows(intCont).Cells("FECOBS").Value IsNot Nothing
                IsValido = IsValido AndAlso .Rows(intCont).Cells("OBSERV").Value IsNot Nothing
                If IsValido = True Then
                    obeObservacion = New beObservacionCarga
                    obeObservacion.PNNORSCI = oEmbarque.pNORSCI
                    obeObservacion.PNTFCOBS = Format(CType(.Rows(intCont).Cells("FECOBS").Value, Date), "yyyyMMdd")
                    obeObservacion.PSTOBS = .Rows(intCont).Cells("OBSERV").Value.ToString.Trim
                    obeObservacion.PNNRITEM = .Rows(intCont).Cells("NRITEM_OBS").Value
                    oEmbarque.Actualiza_Observaciones(obeObservacion)
                End If
            Next intCont
        End With

    End Sub



    Private Function ValidarDatosCarga() As String
        Dim oListaTipoOcurrencia As New List(Of Decimal)
        Dim msgValidacion As String = ""
        Dim Fila As Int32 = 0
        Dim IS_TIPO_CARGA_UNICO As Boolean = True
        For Fila = 0 To dtgCarga.Rows.Count - 1
            If (dtgCarga.Rows(Fila).Cells("CARGA").Value IsNot Nothing) Then
                'VALIDAR QUE NO SE REPITA EL TIPO DE CARGA
                If (Not oListaTipoOcurrencia.Contains(dtgCarga.Rows(Fila).Cells("CARGA").Value)) Then
                    oListaTipoOcurrencia.Add(dtgCarga.Rows(Fila).Cells("CARGA").Value)
                Else
                    IS_TIPO_CARGA_UNICO = False
                End If
            End If
        Next
        If (IS_TIPO_CARGA_UNICO = False) Then
            msgValidacion = msgValidacion & "Verifique los tipos de carga.Elimine los duplicados."
        End If
        Return msgValidacion.Trim
    End Function


    Private Sub Actualizar_Datos_Embarque()
        Dim msgValidacion As String = ""
        msgValidacion = ValidarDatosCarga()
        If (msgValidacion.Length > 0) Then
            MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Grabar_Datos_Embarque()
        Grabar_Carga()
        If GrabarDatosCartaFianza() Then
            Actualizar_Grilla(ACTUALIZACION_GRILLA.EMBARQUE) '3 - Datos de Embarque
            Limpiar_Informacion()
            Cargar_Informacion_Embarque()
        End If
    End Sub


    Private Function ValidarExistenciaOrdenServicio(ByVal PNPNNMOS As Decimal, ByVal PNNORSCI As Decimal) As String
        Dim sbmsg As New StringBuilder
        Dim obrEmbarque As New clsEmbarque
        Dim dt As New DataTable
        dt = obrEmbarque.VerificarExistenciaOrdenServicio(PNPNNMOS, PNNORSCI)
        If dt.Rows.Count Then
            sbmsg.AppendLine(String.Format("La orden de servicio {0} está asociada a otro embarque :", PNPNNMOS))
            For Each Item As DataRow In dt.Rows
                sbmsg.Append(String.Format("Embarque: {0}", Item("NORSCI")))
                sbmsg.Append(String.Format("  Cliente: {0} - {1}", Item("CCLNT"), ("" & Item("TCMPCL")).ToString.Trim))
                sbmsg.Append(Chr(13) & "----------------------------------------------")
            Next
        End If
        Return sbmsg.ToString.Trim
    End Function

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            'Dim strmsgEnvioTracking As String = ""
            Dim indice As Int32 = ObtenerIndiceTabSeleccionado(Me.TabControl1.SelectedTab.Name)
            If oEmbarque.pCCLNT = 0 Then
                HelpClass.MsgBox("Debe de seleccionar un cliente")
                Exit Sub
            End If

            If (oEmbarque.pNORSCI = 0) Then
                MessageBox.Show("Debe de seleccionar Embarque", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Select Case indice
                Case 0
                    Actualizar_Datos_OrdenesEmbarcadas()

                    'If oEmbarque.pCCLNT_PORTAL > 0 Then
                    '    If oEmbarque.pNOREMB.Length > 0 Then
                    '        oHebraCheckPointYRC_ITEM_EMB = New Thread(AddressOf Enviar_Items_Embarcador)
                    '        oHebraCheckPointYRC_ITEM_EMB.Start()
                    '    End If
                    'End If

                Case 1
                    Dim PNPNNMOS As Decimal = IIf(Me.txtNroOS.Text.Trim = "", 0, Me.txtNroOS.Text.Trim)
                    Dim msg As String = ""
                    Dim continuar As Boolean = True
                    If PNPNNMOS > 0 Then
                        msg = ValidarExistenciaOrdenServicio(PNPNNMOS, oEmbarque.pNORSCI)
                    End If
                    If msg.Length > 0 Then
                        If MessageBox.Show("Desea continuar ? " & Chr(13) & msg, "Aviso-Verificar OS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                            continuar = True
                        Else
                            continuar = False
                        End If
                    End If
                    If continuar = True Then

                        Grabar_Datos_AperturaOS()
                        Grabar_Documentos_Forol()
                        Limpiar_Documentos_Forol()
                        Llenar_Documentos_Forol()

                        Limpiar_Informacion()
                        Cargar_Informacion_Embarque()

                        'If oEmbarque.pCCLNT_PORTAL > 0 Then
                        '    If oEmbarque.pNOREMB.Length > 0 Then
                        '        oHebraCheckPointYRC_INFO_EMB = New Thread(AddressOf Enviar_Informacion_Embarcador)
                        '        oHebraCheckPointYRC_INFO_EMB.Start()

                        '        oHebraCheckPointYRC_ITEM_EMB = New Thread(AddressOf Enviar_Items_Embarcador)
                        '        oHebraCheckPointYRC_ITEM_EMB.Start()
                        '    End If
                        'End If

                        Dim bolClienteTracking As Boolean = False
                        bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                        If bolClienteTracking = True Then

                            Dim obrCheckPoint As New clsCheckPoint
                            dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                            dtChkPointTrackingInicial.Columns.Add("FRETES2")
                            dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                            Dim cantReg As Int32 = dtChkPointTrackingInicial.Rows.Count
                            If cantReg > 0 Then
                                dtChkPointTrackingInicial.Rows(cantReg - 1)("FLG_APLICA") = "SI"
                            End If
                            oAccionTracking = AccionTracking.ListadoRegChk

                            oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                            oHebraCheckPointTrackingPacasmayo.Start()
                           
                        End If




                    End If
                Case 2
                    Grabar_DocAdj()
                Case 3
                    Actualizar_Datos_Embarque()

                    'If oEmbarque.pCCLNT_PORTAL > 0 Then
                    '    If oEmbarque.pNOREMB.Length > 0 Then

                    '        oHebraCheckPointYRC_INFO_EMB = New Thread(AddressOf Enviar_Informacion_Embarcador)
                    '        oHebraCheckPointYRC_INFO_EMB.Start()

                    '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                    '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()

                    '    End If
                    'End If

                    Dim bolClienteTracking As Boolean = False
                    bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                    If bolClienteTracking = True Then
                        Dim obrCheckPoint As New clsCheckPoint
                        dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        dtChkPointTrackingInicial.Columns.Add("FRETES2")
                        dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                        Dim cantReg As Int32 = dtChkPointTrackingInicial.Rows.Count
                        If cantReg > 0 Then
                            dtChkPointTrackingInicial.Rows(cantReg - 1)("FLG_APLICA") = "SI"
                        End If

                        oAccionTracking = AccionTracking.ListadoRegChk
                        oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                        oHebraCheckPointTrackingPacasmayo.Start()
                    End If

                Case 4
                    GuardarCostoEmbarque()

                    'If oEmbarque.pCCLNT_PORTAL > 0 Then
                    '    If oEmbarque.pNOREMB.Length > 0 Then

                    '        oHebraCheckPointYRC_ITEM_EMB = New Thread(AddressOf Enviar_Items_Embarcador)
                    '        oHebraCheckPointYRC_ITEM_EMB.Start()

                    '        oHebraCheckPointYRC_COSTO_EMB = New Thread(AddressOf Enviar_Costos_Embarcador)
                    '        oHebraCheckPointYRC_COSTO_EMB.Start()

                    '    End If
                    'End If

                    Dim bolClienteTracking As Boolean = False
                    bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                    If bolClienteTracking = True Then
                        oAccionTracking = AccionTracking.ListadoRegChk
                        Dim obrCheckPoint As New clsCheckPoint
                        dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        dtChkPointTrackingInicial.Columns.Add("FRETES2")
                        dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                        Dim cantReg As Int32 = dtChkPointTrackingInicial.Rows.Count
                        If cantReg > 0 Then
                            dtChkPointTrackingInicial.Rows(cantReg - 1)("FLG_APLICA") = "SI"
                        End If

                        oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                        oHebraCheckPointTrackingPacasmayo.Start()
                    End If

                Case 5
                    Grabar_Observaciones()
                    Llenar_Observaciones() 'Observaciones del Seguimiento
                    Actualizar_Grilla(ACTUALIZACION_GRILLA.OBSERVACION) '5 - Observaciones del Seguimiento

                    'If oEmbarque.pCCLNT_PORTAL > 0 Then
                    '    If oEmbarque.pNOREMB.Length > 0 Then
                    '        oHebraCheckPointYRC_OBS_EMB = New Thread(AddressOf Enviar_Observaciones_Embarcador)
                    '        oHebraCheckPointYRC_OBS_EMB.Start()
                    '    End If
                    'End If

                Case 7

                    Dim EnviarCorreo As Boolean = False
                    Dim PSREGIMEN As String = ""
                    Dim CodFormato As String = ""
                    '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
                    'oclsCheckPointEnvio = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointEnvio
                    oclsCheckPointEnvio = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointNotifGeneral
                    Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
                    odaClienteEnvio.Asignar_Lista_Cliente_Envio_Notificacion(dtListaClienteEnvioxModCheckpoint)
                    CodFormato = odaClienteEnvio.RetornaFormatoEnvio_X_Cliente(oEmbarque.pCCLNT)
                    oclsCheckPointEnvio.CodFormato = CodFormato
                    oclsCheckPointEnvio.Tipo_Envio = odaClienteEnvio.Tipo_Envio_Chk_x_Aduana
                    If (odaClienteEnvio.DebeNotificarEnvio_X_Cliente(oEmbarque.pCCLNT) And CodFormato <> "") Then

                        oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        EnviarCorreo = True
                    End If
                    '***********************************************************************

                    Dim bolClienteTracking As Boolean = False
                    bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)

                    If bolClienteTracking = True Then
                        Dim obrCheckPoint As New clsCheckPoint
                        dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        dtChkPointTrackingInicial.Columns.Add("FRETES2")
                        dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                        For Each item As DataRow In dtChkPointTrackingInicial.Rows
                            item("FLG_APLICA") = "SI"
                        Next

                    End If
                   
                    Grabar_Checkpoint()
                    'HH()

                    If bolClienteTracking = True Then
                        oAccionTracking = AccionTracking.EdicionChk

                        oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                        oHebraCheckPointTrackingPacasmayo.Start()

                    End If

                    Llenar_CheckPoint()
                    Actualizar_Grilla(ACTUALIZACION_GRILLA.CHECKPOINT)
                    PSREGIMEN = txtRegimen.Tag
                    EnviaMensajeTexto(oEmbarque.pNORSCI)


                    '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
                    If (EnviarCorreo = True) Then
                        oHebraCheckPointABB = New Thread(AddressOf EnviarActualizacionFechas_Interfaz_ABB_Asinc)
                        oHebraCheckPointABB.Start()

                        oHebra = New Thread(AddressOf ProcesarEnvioEmail_x_Change_CHK)
                        oHebra.Start()
                    End If
                    '****************************************************************************

                    'If oEmbarque.pCCLNT_PORTAL > 0 Then
                    '    If oEmbarque.pNOREMB.Length > 0 Then
                    '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                    '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                    '    End If
                    'End If

                 



            End Select


            'If strmsgEnvioTracking.Length > 0 Then
            '    MessageBox.Show(strmsgEnvioTracking, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private oHasFormato As New Hashtable
    Private Sub CambiarStatusOC(ByVal EnviarCheckPointEmbarcador As Boolean, ByVal PSREGIMEN As String)
        Dim PBREGIMEN As Boolean = False
        Try
            If oEmbarque.pCCLNT_PORTAL > 0 Then
                If oEmbarque.pNOREMB.Length > 0 Then
                    If PSREGIMEN = "7" Then 'DEPOSITO
                        Cambiar_Status_OC("D")
                    Else
                        PSREGIMEN = PSREGIMEN.Trim
                        PBREGIMEN = (PSREGIMEN = "1" OrElse PSREGIMEN = "2" OrElse PSREGIMEN = "8" OrElse PSREGIMEN = "5" OrElse PSREGIMEN = "18" OrElse PSREGIMEN = "15")
                        If PBREGIMEN = True Then
                            Cambiar_Status_OC("T")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

#Region "Envio Mail x Cambio CheckPoint"
    Private Sub ProcesarEnvioEmail_x_Change_CHK()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim FECHA_FIN As Decimal = 0
            Dim Envio As Int32 = 0
            Dim obeListaCheckPointFinal As New List(Of Ransa.Servicio.EmailCheckPointAduana.beCheckPointFormato)
            oclsCheckPointEnvio.MailAccount = HelpClass.getSetting("email_account")
            oclsCheckPointEnvio.Mailpassword = HelpClass.getSetting("email_password")
            oclsCheckPointEnvio.MailAccount_Gmail = HelpClass.getSetting("email_account_gmail")
            oclsCheckPointEnvio.MailPassword_Gmail = HelpClass.getSetting("email_password_gmail")
            oclsCheckPointEnvio.Mailto_Error = HelpClass.getSetting("emailto_error")
            oclsCheckPointEnvio.CULUSA = HelpUtil.UserName
            Envio = oclsCheckPointEnvio.EnviarEmail_X_Modificacion_CheckPoint(oEmbarque.pCCLNT, oEmbarque.pNORSCI, cmbCliente.pRazonSocial)
        Catch ex As Exception
        End Try
    End Sub
  


  




    Private Sub EnviarActualizacionFechas_Interfaz_ABB_Asinc()
        Dim CCLNT As Decimal = oEmbarque.pCCLNT
        Dim PNNORSCI As Decimal = oEmbarque.pNORSCI
        Dim oCierreEmbarque As New clsCierreEmbarque
        Dim msgExitoEnvioFechas As String = ""
        Dim CULUSA As String = HelpUtil.UserName
        Control.CheckForIllegalCrossThreadCalls = False
        'Try
        If oCierreEmbarque.DebeEnviarDatosIntegracionEmbarqueABB(CCLNT) Then
            msgExitoEnvioFechas = oCierreEmbarque.EnviarChangesEmbarque(CCLNT, PNNORSCI, CULUSA)
        End If
        If msgExitoEnvioFechas.Length > 0 Then
            MessageBox.Show(msgExitoEnvioFechas, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Catch ex As Exception
        'End Try

    End Sub

#End Region

#Region "Envio YRC"

    Private Sub Enviar_Items_Embarcador_CheckPoint()
        Enviar_Items_Embarcador()
        Enviar_Checkpoint_Embarcador()
    End Sub

    Private Sub Enviar_Items_Embarcador()
        Dim PNNORSCI As Decimal = 0
        Try
            Dim CCLNT As Decimal = oEmbarque.pCCLNT
            PNNORSCI = oEmbarque.pNORSCI
            Control.CheckForIllegalCrossThreadCalls = False
            Dim objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
            Dim strMensaje As String
            objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
            strMensaje = objImpInfo.Enviar_T007(PNNORSCI)
        Catch ex As Exception
            HelpClass.MsgBox("Embarcador-Items(" & PNNORSCI & "):" & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub Enviar_Informacion_Embarcador()
        Dim PNNORSCI As Decimal = 0
        Try
            Dim CCLNT As Decimal = oEmbarque.pCCLNT
            PNNORSCI = oEmbarque.pNORSCI
            Control.CheckForIllegalCrossThreadCalls = False
            Dim objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
            Dim strMensaje As String
            objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
            strMensaje = objImpInfo.Enviar_T005(PNNORSCI)
        Catch ex As Exception
            HelpClass.MsgBox("Embarcador-Información(" & PNNORSCI & "):" & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub Enviar_Costos_Embarcador()
        Dim PNNORSCI As Decimal = 0
        Try
            Dim CCLNT As Decimal = oEmbarque.pCCLNT
            PNNORSCI = oEmbarque.pNORSCI
            Control.CheckForIllegalCrossThreadCalls = False
            Dim objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
            Dim strMensaje As String
            objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
            strMensaje = objImpInfo.Enviar_T006(PNNORSCI)
        Catch ex As Exception
            MessageBox.Show("Embarcador-Costos(" & PNNORSCI & "):" & Chr(13) & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Enviar_Observaciones_Embarcador()
        Dim PNNORSCI As Decimal = 0
        Try
            Dim CCLNT As Decimal = oEmbarque.pCCLNT
            PNNORSCI = oEmbarque.pNORSCI
            Control.CheckForIllegalCrossThreadCalls = False
            Dim objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
            Dim strMensaje As String
            objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
            strMensaje = objImpInfo.Enviar_T013(PNNORSCI)
        Catch ex As Exception
            MessageBox.Show("Embarcador-Observaciones(" & PNNORSCI & "):" & Chr(13) & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Enviar_Checkpoint_Embarcador()
        Dim PNNORSCI As Decimal = 0
        Try
            Dim CCLNT As Decimal = oEmbarque.pCCLNT
            PNNORSCI = oEmbarque.pNORSCI
            Control.CheckForIllegalCrossThreadCalls = False
            Dim objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
            Dim strMensaje As String
            objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
            strMensaje = objImpInfo.Enviar_T008(PNNORSCI)
        Catch ex As Exception
            MessageBox.Show("Embarcador-CheckPoint(" & PNNORSCI & "):" & Chr(13) & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cambiar_Status_OC(ByVal pstrAlmacen As String)
        Try
            Dim CCLNT As Decimal = oEmbarque.pCCLNT
            Dim PNNORSCI As Decimal = oEmbarque.pNORSCI
            Control.CheckForIllegalCrossThreadCalls = False
            Dim objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
            Dim strMensaje As String = ""
            Dim oDt As DataTable
            objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
            oDt = objImpInfo.Lista_Status_Envio_Embarcador(PNNORSCI)
            If oDt.Rows(0).Item("CANTIDAD").ToString.Trim = 0 Then
                strMensaje = objImpInfo.Cambiar_Status_T002(PNNORSCI, pstrAlmacen)
                objImpInfo.Agregar_Cambio_Status(oEmbarque.pNORSCI)
                Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


    Private Sub btnAgregarCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarga.Click
        Try
            Dim oDrVw As New DataGridViewRow
            Dim FilaUltima As Int32 = 0
            oDrVw.CreateCells(Me.dtgCarga)
            dtgCarga.Rows.Add(oDrVw)
            FilaUltima = dtgCarga.Rows.Count - 1
            dtgCarga.Rows(FilaUltima).Cells("EXISTS_CARGA").Value = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAgregarObservaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarObservaciones.Click
        Try
            Dim oDrVw As New DataGridViewRow
            Dim FilaUltima As Int32 = 0
            oDrVw.CreateCells(dtgObservaciones)
            dtgObservaciones.Rows.Add(oDrVw)
            FilaUltima = dtgObservaciones.Rows.Count - 1
            dtgObservaciones.Rows(FilaUltima).Cells("EXISTS_OBS").Value = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerIndiceTabSeleccionado(ByVal nombreTabSeleccionado As String) As Int32
        nombreTabSeleccionado = nombreTabSeleccionado.Trim
        Dim indice As Int32 = -1
        Select Case nombreTabSeleccionado
            Case "TabPage1"
                indice = 0
            Case "TabPage2"
                indice = 1
            Case "TabPage3"
                indice = 2
            Case "TabPage4"
                indice = 3
            Case "TabPage5"
                indice = 4
            Case "TabPage6"
                indice = 5
            Case "TabPage7"
                indice = 6
            Case "TabPage8"
                indice = 7
            Case "TabPage9"
                indice = 8
            Case Else
                indice = -1
        End Select
        Return indice
    End Function

    Private Sub CambiarVisibilidadPorOpcion(ByVal Indice As Int32)
        If (Not IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)) Then
            Select Case Indice
                Case 0
                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnGrabar.Visible = True
                        btnImprimirForol.Visible = False
                        btnAgregar.Visible = False
                        btnAgregarCarga.Visible = False
                        btnAgregarObservaciones.Visible = False
                        btnImportarAgencia.Visible = False
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = False
                        btnAgregarItem.Visible = True
                        btnModificarItem.Visible = True
                        btnDelItem.Visible = True
                        btnServicio.Visible = False
                    End If

                Case 1

                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnGrabar.Visible = True
                        btnImprimirForol.Visible = True
                        btnAgregar.Visible = False
                        btnAgregarCarga.Visible = False
                        btnAgregarObservaciones.Visible = False
                        btnImportarAgencia.Visible = True
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = False
                        btnAgregarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnDelItem.Visible = False
                        btnServicio.Visible = False
                    End If

                Case 2

                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnGrabar.Visible = True
                        btnImprimirForol.Visible = False
                        btnAgregar.Visible = True
                        btnAgregarCarga.Visible = False
                        btnAgregarObservaciones.Visible = False
                        btnImportarAgencia.Visible = False
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = False
                        btnAgregarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnDelItem.Visible = False
                        btnServicio.Visible = False
                    End If
                Case 3
                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnGrabar.Visible = True
                        btnImprimirForol.Visible = False
                        btnAgregar.Visible = False
                        btnAgregarCarga.Visible = True
                        btnAgregarObservaciones.Visible = False
                        btnImportarAgencia.Visible = False
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = False
                        btnAgregarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnDelItem.Visible = False
                        btnServicio.Visible = False
                    End If


                Case 4

                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnGrabar.Visible = True
                        btnImprimirForol.Visible = False
                        btnAgregar.Visible = False
                        btnAgregarCarga.Visible = False
                        btnAgregarObservaciones.Visible = False
                        btnImportarAgencia.Visible = False
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = True
                        btnAgregarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnDelItem.Visible = False
                        btnServicio.Visible = False
                    End If

                Case 5

                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnImprimirForol.Visible = False
                        btnAgregar.Visible = False
                        btnAgregarCarga.Visible = False
                        btnImportarAgencia.Visible = False
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = False
                        btnAgregarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnDelItem.Visible = False
                        btnServicio.Visible = False
                        Dim TabObsSeleccionado As String = TabObservacion.SelectedTab.Name.Trim
                        If (TabObsSeleccionado.ToUpper = "TabEmbarqueAduana".ToUpper) Then
                            btnGrabar.Visible = True
                            btnAgregarObservaciones.Visible = True
                        Else
                            btnGrabar.Visible = False
                            btnAgregarObservaciones.Visible = False
                        End If
                    End If

                Case 6

                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnGrabar.Visible = False
                        btnImprimirForol.Visible = False
                        btnAgregar.Visible = False
                        btnAgregarCarga.Visible = False
                        btnAgregarObservaciones.Visible = False
                        btnImportarAgencia.Visible = False
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = False
                        btnAgregarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnDelItem.Visible = False
                        btnServicio.Visible = True
                    End If

                Case 7

                    If (Me.STSOP22) Then
                        Acceso_OrdenesEmbarcadas_Adicionar(False)
                        Acceso_OrdenesEmbarcadas_Eliminar(False)
                    Else
                        btnGrabar.Visible = True
                        btnImprimirForol.Visible = False
                        btnAgregar.Visible = False
                        btnAgregarCarga.Visible = False
                        btnAgregarObservaciones.Visible = False
                        btnImportarAgencia.Visible = False
                        btnImportarAgenAscinsa.Visible = False
                        btnAgregarDocumentoCosto.Visible = False
                        btnAgregarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnDelItem.Visible = False
                        btnServicio.Visible = False
                    End If

            End Select
        End If

    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            Dim indice As Int32 = ObtenerIndiceTabSeleccionado(TabControl1.SelectedTab.Name)
            CambiarVisibilidadPorOpcion(indice)
            TabActivo = indice
            Cargar_Informacion_Embarque()
            HabilitarEdicionControlXEstado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   

    Private Function Obtener_Descripcion_Cliente(ByVal CCLNT As Decimal) As String
        Dim dtb As New DataTable
        Dim TCMPCL As String = ""
        dtb = New clsCliente().Obtener_datos_cliente(CCLNT)
        If dtb.Rows.Count > 0 Then
            TCMPCL = HelpClass.ToStringCvr(dtb.Rows(0).Item("TMTVBJ"))
        End If
        Return TCMPCL
    End Function

    Function ValidarImpresionForol() As String
        Dim sbMensaje As New StringBuilder
        Dim AnioFechaApertura As Int32 = 0
        Dim Fecha As Date
        If Date.TryParse(mskEmbarque.Text.Trim, Fecha) = False Then
            sbMensaje.Append("Debe ingresar(Dato Embarque) válida")
            sbMensaje.AppendLine()
        End If
        Return sbMensaje.ToString
    End Function

    Private Function ConsistenciarOperacion_Embarque(ByVal CCLNT_EMB As Decimal, ByVal NORSCI_EMB As Decimal) As String
        Dim NumeroRevisionGenerada As String = ""
        Try
            Dim odtServiciosEmbarque As New DataTable
            odtServiciosEmbarque = ListaServiciosxEmbarque(CCLNT_EMB, NORSCI_EMB)

            Dim oServicio As New Ransa.Controls.ServicioOperacion.DATOS.clsServicio_DAL
            Dim oListOperacConsistencia As New Hashtable

            Dim PNNOPRCN As Decimal = 0
            Dim PNNSECFC As Decimal = 0
            Dim PNNSECFC_GENERAL As Decimal = 0
            Dim PNNSECFC_ADICIONAL As Decimal = 0
            Dim PNNRTFSV As Decimal = 0
            Dim PNCCLNT As Decimal = 0
            Dim Numero_Consistencia As Decimal = 0
            Dim poServiciosAtendidos As Ransa.Controls.ServicioOperacion.Servicio_BE
            Dim drServicioGeneral() As DataRow
            Dim drServicioAdicional() As DataRow
            drServicioGeneral = odtServiciosEmbarque.Select("CTPALJ='GE'")
            drServicioAdicional = odtServiciosEmbarque.Select("CTPALJ='AD'")

            If drServicioGeneral.Length > 0 Then
                PNNSECFC_GENERAL = drServicioGeneral(0)("NSECFC")
                If PNNSECFC_GENERAL = 0 Then
                    PNNSECFC_GENERAL = oServicio.ObtenerCodigoConsistencia().Rows(0)("NULCTR")
                End If
                If drServicioAdicional.Length > 0 Then
                    PNNSECFC_ADICIONAL = drServicioAdicional(0)("NSECFC")
                    If PNNSECFC_ADICIONAL = 0 Then
                        PNNSECFC_ADICIONAL = PNNSECFC_GENERAL
                    End If
                End If
            End If
            If PNNSECFC_GENERAL > 0 Then
                For Each Item As DataRow In drServicioGeneral
                    PNNOPRCN = Item("NOPRCN")
                    PNNSECFC = Item("NSECFC")
                    PNNRTFSV = Item("NRTFSV")
                    PNCCLNT = Item("CCLNT")
                    poServiciosAtendidos = New Ransa.Controls.ServicioOperacion.Servicio_BE
                    poServiciosAtendidos.CCMPN = oEmbarque.pCCMPN
                    poServiciosAtendidos.CDVSN = oEmbarque.pCDVSN

                    poServiciosAtendidos.CPLNDV = 1
                    poServiciosAtendidos.CCLNT = PNCCLNT
                    poServiciosAtendidos.NOPRCN = PNNOPRCN
                    poServiciosAtendidos.NRTFSV = PNNRTFSV
                    poServiciosAtendidos.NSECFC = PNNSECFC_GENERAL
                    oServicio.ActualizarServicio_Atendido(poServiciosAtendidos)
                Next
                For Each Item As DataRow In drServicioAdicional
                    PNNOPRCN = Item("NOPRCN")
                    PNNSECFC = Item("NSECFC")
                    PNNRTFSV = Item("NRTFSV")
                    PNCCLNT = Item("CCLNT")
                    poServiciosAtendidos = New Ransa.Controls.ServicioOperacion.Servicio_BE
                    poServiciosAtendidos.CCMPN = oEmbarque.pCCMPN
                    poServiciosAtendidos.CDVSN = oEmbarque.pCDVSN
                    poServiciosAtendidos.CPLNDV = 1
                    poServiciosAtendidos.CCLNT = PNCCLNT
                    poServiciosAtendidos.NOPRCN = PNNOPRCN
                    poServiciosAtendidos.NRTFSV = PNNRTFSV
                    poServiciosAtendidos.NSECFC = PNNSECFC_ADICIONAL
                    oServicio.ActualizarServicio_Atendido(poServiciosAtendidos)
                Next

            End If


            odtServiciosEmbarque = ListaServiciosxEmbarque(CCLNT_EMB, NORSCI_EMB)
            drServicioGeneral = odtServiciosEmbarque.Select("CTPALJ='GE'")
            drServicioAdicional = odtServiciosEmbarque.Select("CTPALJ='AD'")
            If drServicioGeneral.Length > 0 Then
                PNNSECFC_GENERAL = drServicioGeneral(0)("NSECFC")
            End If
            If drServicioAdicional.Length > 0 Then
                PNNSECFC_ADICIONAL = drServicioAdicional(0)("NSECFC")
            End If

            If PNNSECFC_GENERAL = PNNSECFC_ADICIONAL Then
                NumeroRevisionGenerada = String.Format("REVISION GENERADA N°:{0}", PNNSECFC_GENERAL)
            ElseIf PNNSECFC_GENERAL <> PNNSECFC_ADICIONAL Then
                NumeroRevisionGenerada = String.Format("REVISION GENERADA N°:{0}{1}{2}", PNNSECFC_GENERAL, ",", PNNSECFC_ADICIONAL)
            End If

        Catch ex As Exception
            NumeroRevisionGenerada = "Error en generación de n°de revisión."
        End Try
        Return NumeroRevisionGenerada
    End Function

    Private Function ValidarInformacionCompletaEmbarque(ByVal CCLNT As Decimal, ByVal obeDatoEmbarque As beDatosEmbarque) As String
        Dim msgAdd As String = ""
        Dim sbMensaje As New StringBuilder

        If obeDatoEmbarque.PNTPORGE = 0 Then
            sbMensaje.AppendLine("Régimen")
        End If
        If obeDatoEmbarque.PSTCANAL.Length = 0 Then
            sbMensaje.AppendLine("Canal")
        End If
        If obeDatoEmbarque.PNNCODRG_DESPACHO = 0 Then
            sbMensaje.AppendLine("Despacho")
        End If
        If obeDatoEmbarque.PNCMEDTR = 0 Then
            sbMensaje.AppendLine("Medio Transporte")
        End If
        If obeDatoEmbarque.PNFAPRAR = 0 Then
            sbMensaje.AppendLine("ETA")
        End If
        If obeDatoEmbarque.PNFAPREV = 0 Then
            sbMensaje.AppendLine("ETD")
        End If
        If obeDatoEmbarque.PNCHK_LEVANTE = 0 Then
            sbMensaje.AppendLine("(123)CheckPoint Fecha Levante")
        End If
        If obeDatoEmbarque.PNCHK_ENTREGA_ALMACEN = 0 Then
            sbMensaje.AppendLine("(124)CheckPoint Fecha Entrega Almacén")
        End If
        If CCLNT = 11232 Then
            If obeDatoEmbarque.PNCHK_PAGO_DERECHO = 0 Then
                sbMensaje.AppendLine("(122) CheckPoint Pago Derecho")
            End If
            If obeDatoEmbarque.PNCHK_NUMERACION = 0 Then
                sbMensaje.AppendLine("(121) Fecha Numeración  ")
            End If
        End If
        If sbMensaje.ToString.Trim.Length > 0 Then
            msgAdd = "Falta Ingresar los siguientes Datos:" & Chr(13)
        End If

        If sbMensaje.ToString.Trim.Length > 0 Then
            sbMensaje.Insert(0, msgAdd)
        End If
        Return sbMensaje.ToString

    End Function



    Private Function VerificarOCRegularizada_ABB(ByVal PNNORSCI As Decimal) As String
        Dim msg As String = ""
        Dim clsAperturaVerificar As New clsDocApertura
        Dim dt As New DataTable
        dt = clsAperturaVerificar.ListarOCRegularizados_ABB(PNNORSCI)
        If dt.Rows.Count > 0 Then
            msg = "Los costos del embarque no se enviarán a ABB. Estos ya fueron regularizados."
        End If
        msg = msg.Trim
        Return msg
    End Function

    Private Sub btnCerrarEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarEmbarque.Click
        'Dim Exito As Boolean = False
        Dim PNNOPRCN As Decimal = 0
        Dim msgCierre As String = ""
        Dim msValidacion As String = ""
        Dim PSCCMPN As String = oEmbarque.pCCMPN
        Dim PSCDVSN As String = oEmbarque.pCDVSN
        Dim CreacionOperacion As Boolean = False
        Dim DatoOperacion As New DataTable
        Dim obrclsServicio As New clsServicio
        Dim obeDatoEmbarque As New beDatosEmbarque
        Dim obrEmbarque As New clsEmbarque

        Dim ExitoOperacion As String = ""
        Dim MsgOperacion As String = ""

        Dim oCierreEmbarque As New clsCierreEmbarque


        Dim DebeEnviarCostoABB As Boolean = True

        Dim dtOperacionCierre As New DataTable
        If Me.cmbCliente.pCodigo = 0 Then
            HelpClass.MsgBox("Debe de seleccionar un cliente")
            Exit Sub
        End If
        If (oEmbarque.pNORSCI = 0) Then
            MessageBox.Show("Debe de seleccionar el Embarque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            Dim UserName As String = HelpUtil.UserName
            Dim CCLNT As Decimal = oEmbarque.pCCLNT
            Dim NORSCI As Decimal = oEmbarque.pNORSCI
            Dim TipoSeguimiento As String = ""
            obeDatoEmbarque = obrEmbarque.Listar_Datos_Validacion_Embarque(CCLNT, NORSCI)
            TipoSeguimiento = obeDatoEmbarque.PSFTRTSG.Trim


            msValidacion = ValidarInformacionCompletaEmbarque(oEmbarque.pCCLNT, obeDatoEmbarque)
            If msValidacion.Length > 0 Then
                MessageBox.Show(msValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim msgEnvioCostos As String = ""
            If oCierreEmbarque.DebeEnviarCostoACliente(oEmbarque.pCCLNT) Then
                Dim oDocApertura As New clsDocApertura
                Dim msgValidacion As String = ""
                msgValidacion = oDocApertura.Lista_Validacion_Datos_Envio_ABB(oEmbarque.pNORSCI, oEmbarque.pCCLNT)
                If msgValidacion.Length > 0 Then
                    If MessageBox.Show("Considerar lo siguiente para el envio de costos:" & Chr(13) & msgValidacion & Chr(13) & " ¿ Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If


            Dim msgcierre_embarque As String = "¿ Está seguro que desea cerrar el embarque ?"
            If TipoSeguimiento = "X" Then
                msgcierre_embarque = msgcierre_embarque & Chr(10) & "Despacho solo seguimiento(No se generará operación)."
            End If

            If MessageBox.Show(msgcierre_embarque, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If oCierreEmbarque.DebeEnviarCostoACliente(cmbCliente.pCodigo) Then
                    Dim msgOCRegularizado As String = ""
                    msgOCRegularizado = VerificarOCRegularizada_ABB(dblEmbSelec)
                    If msgOCRegularizado.Length > 0 Then
                        msgOCRegularizado = msgOCRegularizado & Chr(13) & "¿ Desea continuar con el cierre sin el envio de costos ?"
                        If MessageBox.Show(msgOCRegularizado, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        Else
                            DebeEnviarCostoABB = False
                        End If
                    End If
                End If

                DatoOperacion = obrclsServicio.Existe_Embarque_En_Operacion(oEmbarque.pNORSCI, oEmbarque.pCCLNT, "GE")
                If (DatoOperacion.Rows.Count > 0) Then
                    PNNOPRCN = DatoOperacion.Rows(0)("NOPRCN")
                Else
                    PNNOPRCN = 0
                End If
                If (PNNOPRCN <> 0) Then
                    'Exito = True
                    oEmbarque.Cerrar_Embarque(oEmbarque.pNORSCI)
                    msgCierre = "El embarque " & oEmbarque.pNORSCI & " fue Cerrado." & Chr(13)
                    msgCierre = msgCierre & "El embarque " & oEmbarque.pNORSCI & " está asignado a la OPERACIÓN " & PNNOPRCN
                    MessageBox.Show(msgCierre, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If oCierreEmbarque.DebeEnviarCostoACliente(cmbCliente.pCodigo) AndAlso DebeEnviarCostoABB = True Then
                        oCierreEmbarque.EnviarCostos(cmbCliente.pCodigo, dblEmbSelec, UserName)
                    End If
                    chkVista_CheckedChanged(chkVistaExtendida, Nothing)
                Else
                    'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    Dim dblFecAlm As Double
                    dblFecAlm = obeDatoEmbarque.PNCHK_ENTREGA_ALMACEN

                    Select Case TipoSeguimiento
                        Case ""
                            If dblFecAlm > 0 Then
                                Dim ofrm As New frmTarifasDeServicios
                                ofrm.CodCompania = oEmbarque.pCCMPN
                                ofrm.CodDivision = oEmbarque.pCDVSN
                                ofrm.CodPlanta = oEmbarque.pNCPLNDV
                                ofrm.CodCliente = cmbCliente.pCodigo
                                ofrm.Embarque = dblEmbSelec
                                ofrm.FechaDeServicio = dblFecAlm

                                If ofrm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                                    Dim dblTarifa As Double = ofrm.TarifaDeServicios.Cells("NRTFSV").Value
                                    Dim strTipo As String = ("" & ofrm.TarifaDeServicios.Cells("STPTRA").Value).ToString.Trim
                                    Dim strUnidad As String = ("" & ofrm.TarifaDeServicios.Cells("CUNDMD").Value).ToString.Trim
                                    Dim dblValor As Double = ofrm.TarifaDeServicios.Cells("VALCTE").Value
                                    Dim PNCCLNFC As Decimal = ofrm.CodClienteFacturacion
                                    Dim CPLNDV As Decimal = ofrm.PlantaFacturacion
                                    Dim PNCCNTCS As String = ofrm.CodCentroBeneficio 'ECM-ValidacionSectorCliente[RF001]-160516
                                    Dim CDIRSE As Decimal = ofrm.CDIRSE
                                    dtOperacionCierre = oEmbarque.Enviar_Operacion_Facturacion(PSCCMPN, PSCDVSN, oEmbarque.pCCLNT, dblFecAlm, dblTarifa, strTipo, strUnidad, dblValor, PNCCLNFC, CPLNDV, PNCCNTCS, CDIRSE) 'ECM-ValidacionSectorCliente[RF001]-160516

                                    ExitoOperacion = ("" & dtOperacionCierre.Rows(0)("WK_EXITO")).ToString.Trim
                                    MsgOperacion = ("" & dtOperacionCierre.Rows(0)("MSGIMP")).ToString.Trim

                                    If (ExitoOperacion = "1") Then
                                        'Exito = True
                                        Dim mensajeCierre As String = ""
                                        oEmbarque.Cerrar_Embarque(oEmbarque.pNORSCI)
                                        Dim NumeroRevisionGenerada As String = ""
                                        NumeroRevisionGenerada = ConsistenciarOperacion_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                                        mensajeCierre = "Embarque cerrado correctamente."
                                        'Dim oCierreEmbarque As New clsCierreEmbarque

                                        If oCierreEmbarque.DebeEnviarCostoACliente(oEmbarque.pCCLNT) AndAlso DebeEnviarCostoABB = True Then
                                            oCierreEmbarque.EnviarCostos(cmbCliente.pCodigo, dblEmbSelec, UserName)
                                        End If
                                        MsgOperacion = mensajeCierre & Chr(13) & MsgOperacion
                                        MsgOperacion = MsgOperacion & Chr(13) & NumeroRevisionGenerada
                                        chkVista_CheckedChanged(chkVistaExtendida, Nothing)
                                    End If
                                    'HelpClass.MsgBox(MsgOperacion)
                                    MessageBox.Show(MsgOperacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Else
                                    MsgOperacion = "NO HA SELECCIONADO TARIFA PARA EL SERVICIO DE MANAGEMENT FEE "
                                    'HelpClass.MsgBox(MsgOperacion)
                                    MessageBox.Show(MsgOperacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If

                            Else
                                'Me.Cursor = System.Windows.Forms.Cursors.Default
                                'HelpClass.MsgBox("No se puede enviar a facturación por no existir Fecha de Entrega en Almacén")
                                MessageBox.Show("No se puede enviar a facturación por no existir Fecha de Entrega en Almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If

                        Case "X"

                            'If (ExitoOperacion = "1") Then
                            'Exito = True
                            Dim mensajeCierre As String = ""
                            oEmbarque.Cerrar_Embarque(oEmbarque.pNORSCI)
                            'Dim NumeroRevisionGenerada As String = ""
                            'NumeroRevisionGenerada = ConsistenciarOperacion_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                            mensajeCierre = "Embarque cerrado correctamente."
                            'Dim oCierreEmbarque As New clsCierreEmbarque
                            If oCierreEmbarque.DebeEnviarCostoACliente(oEmbarque.pCCLNT) AndAlso DebeEnviarCostoABB = True Then
                                oCierreEmbarque.EnviarCostos(cmbCliente.pCodigo, dblEmbSelec, UserName)
                            End If
                            'MsgOperacion = mensajeCierre & Chr(13) & MsgOperacion
                            'MsgOperacion = MsgOperacion & Chr(13) & NumeroRevisionGenerada
                            chkVista_CheckedChanged(chkVistaExtendida, Nothing)
                            'End If
                            'HelpClass.MsgBox(MsgOperacion)
                            MessageBox.Show(mensajeCierre, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End Select


                End If

                'If (Exito = True) Then
                'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                'If oEmbarque.pCCLNT_PORTAL > 0 Then
                '    If oEmbarque.pNOREMB.Length > 0 Then

                '        oHebraCheckPointYRC_INFO_EMB = New Thread(AddressOf Enviar_Informacion_Embarcador)
                '        oHebraCheckPointYRC_INFO_EMB.Start()

                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()


                '        oHebraCheckPointYRC_COSTO_EMB = New Thread(AddressOf Enviar_Costos_Embarcador)
                '        oHebraCheckPointYRC_COSTO_EMB.Start()

                '    End If
                'End If
                'Me.Cursor = System.Windows.Forms.Cursors.Default
                'End If

            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnImpInfEmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpInfEmb.Click
        Try
            Dim frm As frmImpInfEmb
            Cursor = Cursors.WaitCursor
            Dim oCliente As New clsCliente
            frm = New frmImpInfEmb(Me.txtNumDocEmb.Text.Trim)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtNumEmbarcador.Text = frm.strNumEmbarcador
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgCheckPoint_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCheckPoint.CellEndEdit
        Dim intCont As Integer
        Try
            If (chkVistaExtendida.Checked) Then
                If (Not dtgSegAduanero.Columns.Item(dtgCheckPoint.Rows(e.RowIndex).Cells("TABRST").Value) Is Nothing) Then
                    For intCont = 0 To dtgSegAduanero.Rows.Count - 1
                        If Me.dblEmbSelec = dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value Then
                            Me.dtgSegAduanero.Rows(intCont).Cells(dtgCheckPoint.Rows(e.RowIndex).Cells("TABRST").Value).Value = dtgCheckPoint.Rows(e.RowIndex).Cells("FRETES").Value
                        End If
                    Next
                End If
            End If
            Dim Columna As String = dtgCheckPoint.Columns(dtgCheckPoint.CurrentCell.ColumnIndex).Name
            Dim ExisteColumna As Boolean = False
            If (Columna = "FESEST") Then
                Dim CHK_NOMVAR As String = dtgCheckPoint.Rows(e.RowIndex).Cells("TABRST").Value
                Dim FECHA As Date
                Select Case CHK_NOMVAR
                    Case "FAPREV"
                        If (Date.TryParse(dtgCheckPoint.Rows(e.RowIndex).Cells("FESEST").Value, FECHA)) Then
                            mskETD.Text = FECHA.ToString("dd/MM/yyyy")
                            ExisteColumna = dtgSegAduanero.Columns("CHKETD") IsNot Nothing
                            If (ExisteColumna) Then
                                dtgSegAduanero.Rows(dtgSegAduanero.CurrentRow.Index).Cells("CHKETD").Value = FECHA.ToString("dd/MM/yyyy")
                            End If

                        End If

                    Case "FAPRAR"
                        Dim ETA As String = ""
                        If (Date.TryParse(dtgCheckPoint.Rows(e.RowIndex).Cells("FESEST").Value, FECHA)) Then
                            mskETA.Text = FECHA.ToString("dd/MM/yyyy")
                            ExisteColumna = dtgSegAduanero.Columns("CHKETA") IsNot Nothing
                            If (ExisteColumna) Then
                                dtgSegAduanero.Rows(dtgSegAduanero.CurrentRow.Index).Cells("CHKETA").Value = FECHA.ToString("dd/MM/yyyy")
                            End If
                        End If

                End Select

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Documentos Adjunto Embarque"

    Private Sub dtgDocumentosAdjuntos_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgDocumentosAdjuntos.MouseDown
        Try
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.ctmDocumentoAdjunto.Items(0).Visible = False
                If (dtgDocumentosAdjuntos.Rows.Count = 0) Then Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Llenar_Documentos_Adjuntos()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        Dim Fila As Int32 = 0
        dtgDocumentosAdjuntos.Rows.Clear()
        Dim IsEmbCerrado As Boolean = False
        IsEmbCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        oDt = oDocApertura.Lista_Documentos_Costo_Embarque(dblEmbSelec)
        Dim fnSeguimiento As New FuncionServSeguimiento
        Dim rutaDua As String = ""
        For intCont = 0 To oDt.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dtgDocumentosAdjuntos)
            'ADICION HABILITAR X ESTADO*************************************
            oDrVw.ReadOnly = IsEmbCerrado
            '***************************************************************
            dtgDocumentosAdjuntos.Rows.Add(oDrVw)
            Fila = dtgDocumentosAdjuntos.Rows.Count - 1

            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TDOCIN").Value = oDt.Rows(intCont).Item("NDOCIN").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("NDOCIN_COS").Value = oDt.Rows(intCont).Item("NDOCIN")
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TDOCIN").ReadOnly = True
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NDOCLI").Value = oDt.Rows(intCont).Item("NDOCUM").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONORG").Value = Double.Parse(oDt.Rows(intCont).Item("IVLORG").ToString.Trim)
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONEDA").Value = oDt.Rows(intCont).Item("CMNDA1")
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONDOL").Value = Double.Parse(oDt.Rows(intCont).Item("IVLDOL").ToString.Trim)
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_UPLOAT").Value = "..."
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NORSCI").Value = oDt.Rows(intCont).Item("NORSCI").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NCRRDC").Value = oDt.Rows(intCont).Item("NCRRDC").ToString.Trim

            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_EXISTS").Value = 1

            dtgDocumentosAdjuntos.Rows(Fila).Cells("NMRGIM_COS").Value = oDt.Rows(intCont).Item("NMRGIM")


            If oDt.Rows(intCont).Item("NDOCIN") = 106 Then

                rutaDua = fnSeguimiento.ObtenerRutaDua(oDt.Rows(intCont).Item("NDOCUM").ToString.Trim)
                If rutaDua.Length > 0 Then
                    dtgDocumentosAdjuntos.Rows(Fila).Cells("RUTA_DUA").Value = rutaDua
                    dtgDocumentosAdjuntos.Rows(Fila).Cells("DUA_COSTO").Value = "DUA"
                Else
                    dtgDocumentosAdjuntos.Rows(Fila).Cells("RUTA_DUA").Value = ""
                    dtgDocumentosAdjuntos.Rows(Fila).Cells("DUA_COSTO").Value = ""
                End If
            End If

            If oDt.Rows(intCont).Item("NMRGIM") > 0 Then
                dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_LINK").Value = SOLMIN_SC.My.Resources.Resources.Archivo
            Else
                dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            End If

        Next intCont

        'ADICION HABILITAR X ESTADO*************************************
        Dim oDcBt As DataGridViewButtonColumn
        oDcBt = New DataGridViewButtonColumn
        oDcBt = dtgDocumentosAdjuntos.Columns("DOCCOSTO_UPLOAT")
        oDcBt.Visible = Not IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)

        Dim oDcVI As New DataGridViewImageColumn
        oDcVI = dtgDocumentosAdjuntos.Columns("DELETE_DOCCOSTO")
        oDcVI.Visible = Not IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        '***************************************************************
    End Sub

    Private Sub Limpiar_Documentos_Adjuntos()
        dtgDocumentosAdjuntos.Rows.Clear()
    End Sub

    Private Function IsValidoDocumentoCosto(ByVal Fila As Int32) As Boolean
        Dim ValidarFila As Boolean = False
        ValidarFila = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TDOCIN").Value IsNot Nothing
        Return ValidarFila
    End Function

    Private Sub GrabarDocumentoCostoItem(ByVal Fila As Int32)
        Dim strRuta As String = ""
        'Dim PSNDOCLI As String = ""
        Dim obeDocumentoCosto As beDocumentoCostos
        obeDocumentoCosto = New beDocumentoCostos
        obeDocumentoCosto.PNNORSCI = dblEmbSelec
        obeDocumentoCosto.PNNDOCIN = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TDOCIN").Value
        If dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONDOL").Value = Nothing Then
            obeDocumentoCosto.PNIVLDOL = 0
        Else
            obeDocumentoCosto.PNIVLDOL = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONDOL").Value
        End If
        If dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONORG").Value = Nothing Then
            obeDocumentoCosto.PNIVLORG = 0
        Else
            obeDocumentoCosto.PNIVLORG = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONORG").Value
        End If
        If dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONEDA").Value = Nothing Then
            obeDocumentoCosto.PNCMNDA1 = 0
            obeDocumentoCosto.PSNMONOC = ""
        Else
            obeDocumentoCosto.PNCMNDA1 = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONEDA").Value
            obeDocumentoCosto.PSNMONOC = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONEDA").FormattedValue.ToString.Trim
        End If

        obeDocumentoCosto.PNNCRRDC = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NCRRDC").Value
        obeDocumentoCosto.PSNDOCUM = ("" & dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NDOCLI").Value).ToString.Trim

        oDocApertura.Grabar_Documentos_Costos_Embarque(obeDocumentoCosto)
        'Actualizar_Grilla(ACTUALIZACION_GRILLA.DUA, PSNDOCLI)

    End Sub


    Private Sub Grabar_Documentos_Costos_Embarque(Optional ByVal FilaUpdate As Int32 = -1)
        Dim Fila As Integer = 0
        If (FilaUpdate <> -1) Then
            If IsValidoDocumentoCosto(FilaUpdate) Then
                GrabarDocumentoCostoItem(FilaUpdate)
            End If
        Else
            For Fila = 0 To Me.dtgDocumentosAdjuntos.Rows.Count - 1
                If IsValidoDocumentoCosto(Fila) Then
                    GrabarDocumentoCostoItem(Fila)
                End If
            Next
        End If
    End Sub
#End Region


    Private Sub GuardarCostoEmbarque()
        Grabar_Documentos_Costos_Embarque()
        Guardar_Costos_Totales_Embarque()
        Limpiar_Documentos_Adjuntos()
        'Llenar_Documentos_Adjuntos()
        Limpiar_Informacion()
        Cargar_Informacion_Embarque()

        Actualizar_Grilla(ACTUALIZACION_GRILLA.COSTOS)
        '==============ACD ===============
        '================================================      
    End Sub



#Region "Costos Totales por Embarque"
    Friend WithEvents oDtgVar As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private oDs As New DataSet
    Private strCodVariable As String

    Private Sub dtgGrillaDinamica_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        Try
            If e.ColumnIndex = 0 Then
                If sender.Rows(e.RowIndex).Cells("MONEDA").Value Is Nothing Then
                    oDs.Tables.Item(sender.NAME.ToString()).Rows(e.RowIndex).Item("CMNDA1") = DBNull.Value
                    oDs.Tables.Item(sender.NAME.ToString()).Rows(e.RowIndex).Item("NMONOC") = DBNull.Value
                Else
                    oDs.Tables.Item(sender.NAME.ToString()).Rows(e.RowIndex).Item("CMNDA1") = sender.Rows(e.RowIndex).Cells("MONEDA").Value
                    oDs.Tables.Item(sender.NAME.ToString()).Rows(e.RowIndex).Item("NMONOC") = sender.Rows(e.RowIndex).Cells("MONEDA").FormattedValue
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgGrillaDinamica_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
       
        Try
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
            If e.RowIndex > -1 And e.ColumnIndex > -1 Then
                Dim ColName As String = sender.Columns(e.ColumnIndex).Name

                Select Case ColName
                    Case "REF"

                        Dim frm As New frmBuscarDocCosto(Me.dblEmbSelec, sender.Rows(e.RowIndex).Cells("VALVAR").Value.ToString.Trim)
                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Dim oDt As New DataTable
                            oDt = oDocApertura.Lista_Documentos_Costo_X_Costo_Total_Embarque(Me.dblEmbSelec, sender.Rows(e.RowIndex).Cells("VALVAR").Value.ToString.Trim)
                            oDs.Tables.Item(sender.Rows(e.RowIndex).Cells("CVARBL").Value.ToString.Trim).Rows(e.RowIndex).Item("TOBS") = Lista_Documento_Costo_X_Costo_Total(oDt, sender.Rows(e.RowIndex).Cells("VALVAR").Value.ToString.Trim)
                        End If

                    Case "COSTOUPLOAT"
                        If dtgSegAduaneroReducido.CurrentRow IsNot Nothing Then
                            Dim PNNORSCI As String = oEmbarque.pNORSCI
                            Dim PSCODVAR As String = sender.CurrentRow.Cells("VALVAR").Value.ToString
                            If oDocApertura.ExisteCostoxEmbarque(PNNORSCI, PSCODVAR) = 0 Then
                                HelpClass.MsgBox("Debe grabar el costo, para cargar imágenes")
                                Exit Sub
                            End If
                            Dim CCLNT As Decimal = oEmbarque.pCCLNT
                            Dim CCMPN As String = oEmbarque.pCCMPN
                            Dim NMRGIM As Decimal = sender.CurrentRow.Cells("NMRGIM").Value
                            Dim TABLE_NAME As String = "RZOL42C"
                            Dim USER_NAME As String = HelpUtil.UserName
                            Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.CostoxEmbarque)
                            ofrmAdjuntarDocumentos.pPNORSCI = oEmbarque.pNORSCI
                            ofrmAdjuntarDocumentos.pCODVAR = PSCODVAR
                            ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
                            ofrmAdjuntarDocumentos.ShowDialog()
                            If ofrmAdjuntarDocumentos.myDialogResult = True Then
                                LLenar_Costos_Totales_X_Embarque() 'Costos del Seguimiento
                                Llenar_Documentos_Adjuntos() 'Documentos de los costos del Seguimiento
                            End If
                        End If
                End Select

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgGrillaDinamica_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then
                Exit Sub
            End If
            Dim intCont As Integer
            If e.Button = Windows.Forms.MouseButtons.Right Then
                intCont = sender.CurrentRow.Index
                strCodVariable = sender.Rows(intCont).Cells("VALVAR").Value.ToString.Trim()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Crear_TabPages()
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim oTabVar As System.Windows.Forms.TabPage

        oDt = oEmbarque.Lista_Para_Crear_TabPages()


        Dim CellStyle As New System.Windows.Forms.DataGridViewCellStyle
        CellStyle.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold)
        CellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        CellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        CellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText


        For intCont = 0 To oDt.Rows.Count - 1
            oTabVar = New System.Windows.Forms.TabPage()
            oTabVar.Name = "tab" & intCont
            oTabVar.Size = New System.Drawing.Size(998, 282)
            oTabVar.TabIndex = 1
            oTabVar.Text = oDt.Rows(intCont).Item("NOMVAR")
            oTabVar.BackColor = Color.White
            oTabVar.ResumeLayout(False)
            oDtgVar = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
            oDtgVar.Name = oDt.Rows(intCont).Item("VALVAR")
            oDtgVar.Size = New System.Drawing.Size(998, 282)
            oDtgVar.Text = oDt.Rows(intCont).Item("NOMVAR")
            oDtgVar.StateCommon.Background.Color1 = Color.White

            oDtgVar.AllowUserToAddRows = False
            oDtgVar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            oDtgVar.AutoGenerateColumns = True
            oDtgVar.ContextMenuStrip = ctmGrillaDinamica
            oDtgVar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            oDtgVar.Dock = DockStyle.Fill
            oDtgVar.AccessibleName = oDt.Rows(intCont).Item("VALVAR")
            oDtgVar.RowsDefaultCellStyle = CellStyle

            oDtgVar.StateCommon.Background.Color1 = System.Drawing.Color.White
            oDtgVar.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
            oDtgVar.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText

            oDtgVar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            AddHandler oDtgVar.CellClick, AddressOf dtgGrillaDinamica_CellClick
            AddHandler oDtgVar.CellEndEdit, AddressOf dtgGrillaDinamica_CellEndEdit
            AddHandler oDtgVar.MouseDown, AddressOf dtgGrillaDinamica_MouseDown

            AddHandler oDtgVar.CellContentClick, AddressOf dtgGrillaDinamica_CellContentClick
            AddHandler oDtgVar.CellContentDoubleClick, AddressOf dtgGrillaDinamica_CellContentDoubleClick

            AddHandler oDtgVar.EditingControlShowing, AddressOf dtgGrillaDinamica_EditingControlShowing
            AddHandler oDtgVar.CellDoubleClick, AddressOf dtgGrillaDinamica_CellDoubleClick

            Me.Controls.Add(oDtgVar)
            oTabVar.Controls.Add(oDtgVar)
            Me.TabControl3.Controls.Add(oTabVar)
            LLenar_Grilla_Dinamica(oDt.Rows(intCont).Item("VALVAR"))
        Next
    End Sub




    Private Sub LLenar_Grilla_Dinamica(ByVal pstrDescripcion As String)
        Dim oDt As DataTable
        Dim oDcBt As DataGridViewButtonColumn
        Dim oDcBx As DataGridViewComboBoxColumn
        Dim oCHK As DataGridViewCheckBoxColumn

        oDt = oDocApertura.Lista_Concepto_Costo_Embarque(pstrDescripcion)
        oDt.Columns.Add(New DataColumn("IVLORG"))
        oDt.Columns.Add(New DataColumn("IVLDOL"))

        oDt.Columns.Add(New DataColumn("TOBS"))
        oDt.Columns.Add(New DataColumn("CMNDA1", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("NMONOC"))

        oDt.Columns.Add(New DataColumn("NMRGIM"))
        'ADICIONADO
        '-------------------------------------------
        oDt.Columns.Add(New DataColumn("CHKCOSTO"))
        '--------------------------------------------


        oDt.TableName = pstrDescripcion
        oDs.Tables.Add(oDt.Copy)
        oDtgVar.DataSource = oDs.Tables.Item(pstrDescripcion)

        oDtgVar.Columns("CVARBL").Visible = False
        oDtgVar.Columns("VALVAR").Visible = False



        oDtgVar.Columns("NOMVAR").HeaderText = "Concepto"
        oDtgVar.Columns("NOMVAR").Width = 250
        oDtgVar.Columns("NOMVAR").Resizable = DataGridViewTriState.False
        oDtgVar.Columns("NOMVAR").SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns("NOMVAR").ReadOnly = True

        oDtgVar.Columns("IVLORG").HeaderText = "Monto (Moneda Origen)"
        oDtgVar.Columns("IVLORG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        oDtgVar.Columns("IVLORG").Resizable = DataGridViewTriState.False
        oDtgVar.Columns("IVLORG").SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns("IVLORG").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDtgVar.Columns("IVLORG").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDtgVar.Columns("IVLORG").Width = 150

        oDtgVar.Columns("IVLDOL").HeaderText = "Monto Dolares"
        oDtgVar.Columns("IVLDOL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        oDtgVar.Columns("IVLDOL").Resizable = DataGridViewTriState.False
        oDtgVar.Columns("IVLDOL").SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns("IVLDOL").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDtgVar.Columns("IVLDOL").DefaultCellStyle.WrapMode = DataGridViewTriState.True

        oDtgVar.Columns("TOBS").HeaderText = "Referencia"
        oDtgVar.Columns("TOBS").Resizable = DataGridViewTriState.False
        oDtgVar.Columns("TOBS").SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns("TOBS").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDtgVar.Columns("TOBS").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDtgVar.Columns("TOBS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDtgVar.Columns("TOBS").ReadOnly = True
        oDtgVar.Columns("TOBS").Width = 250

        oDtgVar.Columns("CMNDA1").Visible = False
        oDtgVar.Columns("NMONOC").Visible = False

        'ADICIONADO
        '------------------------------
        oDtgVar.Columns("CHKCOSTO").Visible = False
        '---------------------------------

        oDtgVar.Columns("NMRGIM").HeaderText = "Img"
        oDtgVar.Columns("NMRGIM").Resizable = DataGridViewTriState.False
        oDtgVar.Columns("NMRGIM").SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns("NMRGIM").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDtgVar.Columns("NMRGIM").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDtgVar.Columns("NMRGIM").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDtgVar.Columns("NMRGIM").ReadOnly = True
        oDtgVar.Columns("NMRGIM").Width = 40



        oDcBx = New DataGridViewComboBoxColumn
        oDcBx.Name = "MONEDA"
        oDcBx.HeaderText = "Moneda Origen"
        oDcBx.DataSource = oMoneda.Lista_Moneda(1)
        oDcBx.DisplayMember = "TSGNMN"
        oDcBx.ValueMember = "CMNDA1"
        oDcBx.Resizable = DataGridViewTriState.False
        oDcBx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcBx.ReadOnly = Me.STSCHG1
        oDtgVar.Columns.Insert(4, oDcBx)


        Dim oCostoLink As New System.Windows.Forms.DataGridViewImageColumn
        oCostoLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        oCostoLink.HeaderText = "Link"
        oCostoLink.Name = "COSTOLINK"
        oCostoLink.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        oCostoLink.Width = 39
        oCostoLink.Image = My.Resources.EnBlanco1
        oDtgVar.Columns.Insert(7, oCostoLink)


        Dim oCostoUpload As New System.Windows.Forms.DataGridViewButtonColumn()
        oCostoUpload.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        oCostoUpload.HeaderText = " "
        oCostoUpload.Name = "COSTOUPLOAT"
        oCostoUpload.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        oCostoUpload.Width = 35
        oDtgVar.Columns.Insert(8, oCostoUpload)

        oDcBt = New DataGridViewButtonColumn
        oDcBt.Name = "REF"
        oDcBt.HeaderText = ""
        oDcBt.Resizable = DataGridViewTriState.False
        oDcBt.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcBt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        If (Me.STSCHG1) Then
            oDcBt.Visible = False
        Else
            oDcBt.ReadOnly = True
        End If

        oDtgVar.Columns.Add(oDcBt)


        oCHK = New DataGridViewCheckBoxColumn
        oCHK.Name = "COSTEO"
        oCHK.HeaderText = "Costear"
        oCHK.Resizable = DataGridViewTriState.False
        oCHK.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oCHK.ReadOnly = False
        oDtgVar.Columns.Add(oCHK)
    End Sub


    Private Sub Guardar_Costos_Totales_Embarque()

        Dim obeCostoTotalEmbarque As beCostoTotalEmbarque

        Dim intCont, intRow As Integer
        Dim objeto As Object
        Dim oCosteo As New beDistribucionCostoxItemOC
        Me.Cursor = Cursors.WaitCursor
        Dim oListConceptosDistribucion As New List(Of String)
        For intCont = 0 To oDs.Tables.Count - 1
            For intRow = 0 To oDs.Tables.Item(intCont).Rows.Count - 1

                If oDs.Tables.Item(intCont).Rows(intRow).Item("IVLORG").ToString <> vbNullString AndAlso _
                     oDs.Tables.Item(intCont).Rows(intRow).Item("IVLDOL").ToString <> vbNullString AndAlso _
                     oDs.Tables.Item(intCont).Rows(intRow).Item("CMNDA1").ToString <> vbNullString Then
                    obeCostoTotalEmbarque = New beCostoTotalEmbarque
                    obeCostoTotalEmbarque.PNNORSCI = Me.dblEmbSelec
                    obeCostoTotalEmbarque.PSCODVAR = oDs.Tables.Item(intCont).Rows(intRow).Item("VALVAR")
                    obeCostoTotalEmbarque.PNIVLORG = oDs.Tables.Item(intCont).Rows(intRow).Item("IVLORG")
                    obeCostoTotalEmbarque.PNIVLDOL = oDs.Tables.Item(intCont).Rows(intRow).Item("IVLDOL")
                    obeCostoTotalEmbarque.PNCMNDA1 = oDs.Tables.Item(intCont).Rows(intRow).Item("CMNDA1")
                    obeCostoTotalEmbarque.PSNMONOC = oDs.Tables.Item(intCont).Rows(intRow).Item("NMONOC")

                    oDocApertura.Guardar_Costos_Totales_Embarque("A", obeCostoTotalEmbarque)
                    'ADICIONADO -----------------------------------------------------------------------
                    If (oDs.Tables.Item(intCont).Rows(intRow).Item("CHKCOSTO") IsNot DBNull.Value) Then
                        If (oDs.Tables.Item(intCont).Rows(intRow).Item("CHKCOSTO") = "True") Then
                            oCosteo = New beDistribucionCostoxItemOC
                            oCosteo.PNCCLNT = oEmbarque.pCCLNT
                            oCosteo.PNNORSCI = oEmbarque.pNORSCI
                            oCosteo.PSCODVAR = oDs.Tables.Item(intCont).Rows(intRow).Item("VALVAR")
                            oListConceptosDistribucion.Add(oCosteo.PSCODVAR)
                        End If
                    End If
                    '-------------------------------------------------------------
                    ' Actualizar_Grilla(ACTUALIZACION_GRILLA.COSTOS)
                End If
            Next
        Next
        'Actualizar_Grilla(ACTUALIZACION_GRILLA.COSTOS)

        If (oListConceptosDistribucion.Count > 0) Then
            Dim oclsCostoItem As New Negocio.clsCostoItem
            Dim odtOrdenesEmbarcadas As New DataTable

           

            oclsCostoItem.Distribuir_Costos_Ordenes_Embarcadas(oEmbarque.pCCLNT, oEmbarque.pNORSCI, oListConceptosDistribucion)
        End If
        '===============================QUITANDO CHECKS===============================
        For intCont = 0 To oDs.Tables.Count - 1

            For intRow = 0 To CType(TabControl3.Controls("tab" & intCont).Controls(0), ComponentFactory.Krypton.Toolkit.KryptonDataGridView).Rows.Count - 1
                '-------------------------------------------------------------------   

                objeto = CType(TabControl3.Controls("tab" & intCont).Controls(0), ComponentFactory.Krypton.Toolkit.KryptonDataGridView).Rows(intRow).Cells("COSTEO").Value
                If (objeto IsNot DBNull.Value Or objeto IsNot Nothing) Then
                    If (objeto = "True") Then
                        CType(TabControl3.Controls("tab" & intCont).Controls(0), ComponentFactory.Krypton.Toolkit.KryptonDataGridView).Rows(intRow).Cells("COSTEO").Value = False
                    End If
                End If
                oDs.Tables.Item(intCont).Rows(intRow).Item("CHKCOSTO") = "False"
            Next
        Next
        '-------------------------------------------
    End Sub

    Private Sub Limpiar_Costos_Totales_X_Embarque()
        Dim intCont, intRow As Integer
        Dim oBj As Object
        For intCont = 0 To oDs.Tables.Count - 1
            For intRow = 0 To oDs.Tables.Item(intCont).Rows.Count - 1
                oDs.Tables.Item(intCont).Rows(intRow).Item("IVLORG") = vbNullString
                oDs.Tables.Item(intCont).Rows(intRow).Item("IVLDOL") = vbNullString
                oDs.Tables.Item(intCont).Rows(intRow).Item("TOBS") = DBNull.Value
                oDs.Tables.Item(intCont).Rows(intRow).Item("CMNDA1") = DBNull.Value
                oDs.Tables.Item(intCont).Rows(intRow).Item("NMONOC") = vbNullString
                oBj = Me.TabControl3.Controls.Item("tab" & intCont).Controls.Item(oDs.Tables.Item(intCont).Rows(intRow).Item("CVARBL").ToString.Trim)
                oBj.Rows(intRow).Cells("MONEDA").Value = vbNullString
                oBj.Rows(intRow).Cells("REF").Value = "..."
                oBj.Rows(intRow).Cells("COSTOUPLOAT").Value = "..."
                oBj.Rows(intRow).Cells("NMRGIM").Value = ""
                oBj.Rows(intRow).Cells("COSTOLINK").Value = My.Resources.EnBlanco
            Next
        Next
    End Sub

    Private Sub LLenar_Costos_Totales_X_Embarque()
        Dim intCont, intContTablas, intRow As Integer
        Dim ds As New DataSet
        Dim oDt As DataTable
        Dim dtDocumentoCostos As New DataTable
        Dim oBj As Object

        Dim Suma As Double = 0
        Dim SumaDol As Double = 0
        ds = oDocApertura.Lista_Costos_Totales_Embarque(Me.dblEmbSelec)
        oDt = ds.Tables("dtCosto")
        dtDocumentoCostos = ds.Tables("dtDocumentoCosto")

        For intCont = 0 To oDs.Tables.Count - 1
            For intContTablas = 0 To oDs.Tables.Item(intCont).Rows.Count - 1
                For intRow = 0 To oDt.Rows.Count - 1
                    If oDs.Tables.Item(intCont).Rows(intContTablas).Item("VALVAR").ToString = oDt.Rows(intRow).Item("CODVAR").ToString Then
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("IVLORG") = Double.Parse(oDt.Rows(intRow).Item("IVLORG"))
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("IVLDOL") = Double.Parse(oDt.Rows(intRow).Item("IVLDOL"))
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("TOBS") = Lista_Documento_Costo_X_Costo_Total(dtDocumentoCostos, oDs.Tables.Item(intCont).Rows(intContTablas).Item("VALVAR").ToString)
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("CMNDA1") = oDt.Rows(intRow).Item("CMNDA1")
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("NMONOC") = oDt.Rows(intRow).Item("NMONOC")
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("NMRGIM") = oDt.Rows(intRow).Item("NMRGIM")

                        oBj = Me.TabControl3.Controls.Item("tab" & intCont).Controls.Item(oDs.Tables.Item(intCont).Rows(intContTablas).Item("CVARBL").ToString.Trim)
                        oBj.Rows(intContTablas).Cells("MONEDA").Value = oDt.Rows(intRow).Item("CMNDA1")

                        If oDt.Rows(intRow).Item("NMRGIM") = 0 Then
                            oBj.Rows(intContTablas).Cells("COSTOLINK").Value = SOLMIN_SC.My.Resources.EnBlanco
                        Else
                            oBj.Rows(intContTablas).Cells("COSTOLINK").Value = SOLMIN_SC.My.Resources.Archivo
                        End If

                        oBj.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    End If

                Next intRow
            Next intContTablas
        Next intCont
        'ADICION HABILITAR X ESTADO*************************************
        HabilitacionEstadoCostos()
        '***********************************************************************
    End Sub
    Private Sub HabilitacionEstadoCostos()
        Dim FILA_TABLAS As Int32 = 0
        Dim odtDatoCosto As New DataTable

        Dim gv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Dim NameGridView As String = ""
        For FILA_TABLAS = 0 To oDs.Tables.Count - 1
            odtDatoCosto = oDs.Tables.Item(FILA_TABLAS)
            If (odtDatoCosto.Rows.Count > 0) Then
                NameGridView = odtDatoCosto.Rows(0).Item("CVARBL").ToString.Trim

                gv = CType(Me.TabControl3.Controls.Item("tab" & FILA_TABLAS).Controls.Item(NameGridView), ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
                For Each dgv As DataGridViewRow In gv.Rows
                    dgv.ReadOnly = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
                Next
            End If
        Next
    End Sub

    Private Function Lista_Documento_Costo_X_Costo_Total(ByVal dtDocumentoCosto As DataTable, ByVal strCodVariable As String) As String
        Dim strDato As String = ""
        Dim intCont As Integer
        Dim dr() As DataRow
        dr = dtDocumentoCosto.Select("CODVAR='" & strCodVariable & "'")
        For intCont = 0 To dr.Length - 1
            If dr.Length - 1 = intCont Then
                strDato = strDato & dr(intCont).Item("NOMVAR").ToString.Trim & "  N° " & dr(intCont).Item("NDOCUM").ToString.Trim
            Else
                strDato = strDato & dr(intCont).Item("NOMVAR").ToString.Trim & "  N° " & dr(intCont).Item("NDOCUM").ToString.Trim & Chr(10)
            End If
        Next
        Return strDato
    End Function


    Private Sub btnAgregarDocumentoCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDocumentoCosto.Click
        Try
            Dim oDrVw As New DataGridViewRow
            oDrVw.CreateCells(Me.dtgDocumentosAdjuntos)
            Me.dtgDocumentosAdjuntos.Rows.Add(oDrVw)
            Dim Fila As Int32 = dtgDocumentosAdjuntos.Rows.Count - 1
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TNMBAR").Value = ""
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_UPLOAT").Value = "..."
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NORSCI").Value = 0
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_URLARC").Value = ""
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TNMBAR").Value = ""
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_EXISTS").Value = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub Borrar_Costo_Total()
        Me.Cursor = Cursors.WaitCursor
        Dim oBj As Object
        Dim intContTabla, intRow As Integer
        Dim obeCostoTotalEmbarque As beCostoTotalEmbarque
        Try
            For intContTabla = 0 To oDs.Tables.Count - 1
                For intRow = 0 To oDs.Tables.Item(intContTabla).Rows.Count - 1
                    If oDs.Tables.Item(intContTabla).Rows(intRow).Item("VALVAR").ToString = strCodVariable Then
                        oBj = TabControl3.Controls.Item("tab" & intContTabla).Controls.Item(oDs.Tables.Item(intContTabla).Rows(intRow).Item("CVARBL").ToString.Trim)
                        If oBj.SelectedRows.Count > 0 Then
                            obeCostoTotalEmbarque = New beCostoTotalEmbarque
                            obeCostoTotalEmbarque.PNNORSCI = dblEmbSelec
                            obeCostoTotalEmbarque.PSCODVAR = oDs.Tables.Item(intContTabla).Rows(intRow).Item("VALVAR")
                            obeCostoTotalEmbarque.PNIVLORG = oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLORG")
                            obeCostoTotalEmbarque.PNIVLDOL = oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")
                            obeCostoTotalEmbarque.PNCMNDA1 = oDs.Tables.Item(intContTabla).Rows(intRow).Item("CMNDA1")
                            obeCostoTotalEmbarque.PSNMONOC = oDs.Tables.Item(intContTabla).Rows(intRow).Item("NMONOC")
                            oDocApertura.Guardar_Costos_Totales_Embarque("E", obeCostoTotalEmbarque)
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub


#End Region

    Private Sub TabControl3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl3.SelectedIndexChanged
        Try
            Select Case Me.TabControl3.SelectedIndex
                Case TabControl3.SelectedIndex
                    If TabControl3.SelectedIndex > 0 Then
                        Cargar_Moneda_En_Grilla(TabControl3.SelectedIndex, sender)
                    End If
            End Select
            'REPINTADO DE LA CELDA DE COSTOS
            '*********************************************************************************
            Dim odtgCosto As New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
            Dim intCont As Integer
            Dim oBj As Object
            Dim COLUMNA As Int32 = 0
            Dim VALVAR As String = ""
            If (TabControl3.SelectedIndex > 0) Then
                For intCont = 0 To oDs.Tables.Item(TabControl3.SelectedIndex - 1).Rows.Count - 1
                    oBj = sender.Controls.Item("tab" & TabControl3.SelectedIndex - 1).Controls.Item(oDs.Tables.Item(TabControl3.SelectedIndex - 1).Rows(intCont).Item(0).ToString.Trim)

                    odtgCosto = CType(oBj, ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
                    If (odtgCosto.Name = "GASADU") Then
                        COLUMNA = odtgCosto.Columns("NOMVAR").Index
                        For INDEX As Integer = 0 To odtgCosto.Rows.Count - 1
                            VALVAR = odtgCosto.Rows(INDEX).Cells("VALVAR").Value
                            If (VALVAR = "ITTGOA" OrElse VALVAR = "ITTCAG" OrElse VALVAR = "ITTRAC") Then
                                odtgCosto.Rows(INDEX).Cells(COLUMNA).Style.BackColor = Color.FromArgb(255, 255, 192)
                                odtgCosto.Rows(INDEX).Cells(COLUMNA).ToolTipText = "Ver Detalle Costo"
                            End If
                        Next
                        Exit For
                    End If
                Next
            End If
            '*************************************************************************************
            HabilitacionEstadoCostos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Moneda_En_Grilla(ByVal intIndice As Integer, ByVal oObj As Object)
        Dim intCont As Integer
        Dim oBj As Object
        For intCont = 0 To oDs.Tables.Item(intIndice - 1).Rows.Count - 1
            oBj = oObj.Controls.Item("tab" & intIndice - 1).Controls.Item(oDs.Tables.Item(intIndice - 1).Rows(intCont).Item(0).ToString.Trim)
            If Not oBj.Rows(intCont).Cells("CMNDA1").Value Is DBNull.Value Then
                oBj.Rows(intCont).Cells("MONEDA").Value = CType((oBj.Rows(intCont).Cells("CMNDA1").Value), Decimal)
            End If
            oBj.Rows(intCont).Cells("REF").Value = "..."
        Next
    End Sub

    Private Sub btnActPortal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActPortal.Click
        Try
            If Me.cmbCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Debe de seleccionar un cliente")
                Exit Sub
            End If
            btnActPortal.Text = "Actualizando....."
            btnActPortal.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

            oHebraActualPortal = New Thread(AddressOf ActualizarPortal)
            oHebraActualPortal.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ActualizarPortal()
        Dim CCLNT As Decimal = oEmbarque.pCCLNT
        Dim CCLNT_PORTAL As Decimal = oEmbarque.pCCLNT_PORTAL
        Dim strMensaje As String = ""
        If oEmbarque.pCCLNT_PORTAL > 0 Then
            Dim objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
            objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
            strMensaje = objImpInfo.Actualizar_Status_OC_Almacenes(CCLNT, CCLNT_PORTAL)
            MessageBox.Show("Embarcador: " & strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("No es Cliente del Portal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        btnActPortal.Text = "Actualizar Portal"
        btnActPortal.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

    End Sub

    Public Sub EnviaMensajeTexto(ByVal pdblEmbarque As Double)
        Dim strMensaje As String = ""
        Dim TextoEnvia As String
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim bolEnvio As Boolean = True
        Try
            oDt = oEmbarque.Lista_Numero_X_Operador(Me.cmbCliente.pCodigo)
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To oDt.Rows.Count - 1
                    If oDt.Rows(intCont).Item("TXTOPR").ToString.Trim = "N" Then
                        strMensaje = Dame_Mensaje(pdblEmbarque)
                        TextoEnvia = "http://demosdata.nextel.com.pe/sms_demourl/web/mensajes/enviar2.asp?usuarios=" & oDt.Rows(intCont).Item("TLFNO1").ToString.Trim & ";&grupos=test&asunto=SOLMIN&mensaje=" & strMensaje

                        'TextoEnvia = "http://demosdata.nextel.com.pe/sms_demourl/web/mensajes/enviar2.asp?usuarios=" & 998106735 & ";&grupos=test&asunto=SOLMIN&mensaje=" & "PruebaEnvio"

                        'TextoEnvia = "http://demosdata.nextel.com.pe/sms_demourl/web/mensajes/enviar2.asp?usuarios=991983268;&grupos=test&asunto=SOLMIN&mensaje=" & strMensaje


                        If strMensaje <> "" Then
                            Dim fr As System.Net.HttpWebRequest
                            Dim targetURI As New Uri(TextoEnvia)
                            fr = DirectCast(System.Net.HttpWebRequest.Create(targetURI), System.Net.HttpWebRequest)
                            If (fr.GetResponse().ContentLength > 0) Then
                                Dim str As New System.IO.StreamReader(fr.GetResponse().GetResponseStream())
                                Dim strCadena As String
                                strCadena = str.ReadToEnd()
                                str.Close()
                                If strCadena.Substring(145, 2) <> "OK" Then
                                    bolEnvio = False
                                End If
                            End If
                        End If
                    End If
                    If Not bolEnvio Then
                        HelpClass.MsgBox("No se pudo enviar el mensaje de Texto al número: " & oDt.Rows(intCont).Item("TLFNO1").ToString.Trim)
                    End If
                    bolEnvio = True
                Next intCont
            End If
        Catch ex As System.Net.WebException

        End Try
    End Sub



    Private Function Dame_Mensaje(ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDt As DataTable

        oDt = oEmbarque.Lista_Datos_Mensaje_Texto(pdblEmbarque)
        If oDt.Rows.Count > 0 Then
            With oDt.Rows(0)
                If Not IsDBNull(.Item("NORSCI")) Then
                    strCadena = "Embarque : " & .Item("NORSCI").ToString.Trim & " "
                End If
                If Not IsDBNull(.Item("PNNMOS")) Then
                    If .Item("PNNMOS").ToString.Trim <> "" Then
                        strCadena = strCadena & "O/S : " & .Item("PNNMOS").ToString.Trim & " "
                    End If
                End If
                If Not IsDBNull(.Item("FECNUM")) Then
                    If .Item("FECNUM").ToString.Trim <> "" Then
                        strCadena = strCadena & "Fecha Numeracion : " & .Item("FECNUM").ToString.Trim & " "
                    End If
                End If
                If Not IsDBNull(.Item("FECLEV")) Then
                    If .Item("FECLEV").ToString.Trim <> "" Then
                        strCadena = strCadena & "Fecha Levante : " & .Item("FECLEV").ToString.Trim & " "
                    End If
                End If
                If Not IsDBNull(.Item("TCANAL")) Then
                    If .Item("TCANAL").ToString.Trim <> "" Then
                        strCadena = strCadena & "Canal : " & .Item("TCANAL").ToString.Trim
                    End If
                End If
            End With
        End If
        Return strCadena
    End Function

    Private Sub ActualizarCellDeSeguimiento(ByVal strNombreDeColumna As String, ByVal strValor As String, ByVal strCodigo As String)
        Try
            If Not Me.dtgSegAduanero.Columns.Item(strNombreDeColumna) Is Nothing Then
                dblEmbSelec = dtgSegAduanero.CurrentRow.Cells("NORSCI").Value
                dblEmbSelecEstado = dtgSegAduanero.CurrentRow.Cells("SESTRG").Value
                Me.dtgSegAduanero.CurrentRow.Cells(strNombreDeColumna).Value = strValor
                Actualizar_Datos(dblEmbSelec, strNombreDeColumna, strCodigo)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnularEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularEmbarque.Click
        Try
            If (chkVistaExtendida.Checked) Then
                If dtgSegAduanero.RowCount = 0 Then Exit Sub
            Else
                If dtgSegAduaneroReducido.RowCount = 0 Then Exit Sub
            End If
            Dim Operaciones As New StringBuilder
            Dim msg As String = ""
            If oEmbarque.EmbarqueEstado = "A" Then
                Dim obrclsServicio As New clsServicio
                Dim DatoOperacion As New DataTable
                DatoOperacion = obrclsServicio.Existe_Embarque_En_Operacion(oEmbarque.pNORSCI, oEmbarque.pCCLNT, "")
                For index As Integer = 0 To DatoOperacion.Rows.Count - 1
                    Operaciones.Append(DatoOperacion.Rows(index)("NOPRCN"))
                    If (index < DatoOperacion.Rows.Count - 1) Then
                        Operaciones.Append(",")
                    End If
                Next
                If (Operaciones.ToString.Trim.Length <> 0) Then
                    msg = "No se puede eliminar,el embarque está en las siguientes operaciones:" & Operaciones.ToString.Trim
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    If MessageBox.Show("Está seguro que desea anular el embarque " & dblEmbSelec & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'INICALMENTE NO SE ELIMINAR LOS 'PREEMBARQUE
                        Dim pEliminarPreEmbarque As clsEmbarque.EliminarItemPreEmbarque = clsEmbarque.EliminarItemPreEmbarque.NO
                        If MessageBox.Show("Se va eliminar el embarque" & Chr(13) & "Desea eliminar también su PreEmbarque asociado ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            'ELIMINAR SUS PREEMBARQUE ASOCIADO.
                            pEliminarPreEmbarque = clsEmbarque.EliminarItemPreEmbarque.SI
                        End If
                        oEmbarque.Mantenimiento_Anular_Embarque(dblEmbSelec, pEliminarPreEmbarque)
                        Me.btnBuscar_Click(Nothing, Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Accesos(ByVal objEntidadAcceso As Entidad.beAcceso)
        If objEntidadAcceso.STSCHG = "" Then
            Me.STSCHG1 = True
            Item2(False)

        Else
            Me.STSCHG1 = False
            Item2(True)

        End If
        If objEntidadAcceso.STSOP1 = "" Then
            Me.STSOP11 = True
        Else
            Me.STSOP11 = False
        End If
        If objEntidadAcceso.STSOP2 = "" Then
            Acceso_OrdenesEmbarcadas_Adicionar(False)
            Acceso_OrdenesEmbarcadas_Eliminar(False)
            Me.STSOP22 = True
        Else
            Me.STSOP22 = False
        End If

    End Sub



    Private Sub Acceso_OrdenesEmbarcadas_Adicionar(ByVal Estado As Boolean)
        btnAgregarDocumentoCosto.Visible = Estado
        btnAgregar.Visible = Estado
        btnAgregarCarga.Visible = Estado
        btnAgregarObservaciones.Visible = Estado
        btnGrabar.Visible = Estado
        btnServicio.Visible = Estado
        btnAgregarItem.Visible = Estado
        btnModificarItem.Visible = Estado
        btnDelItem.Visible = Estado
    End Sub

    Private Sub Acceso_OrdenesEmbarcadas_Eliminar(ByVal Estado As Boolean)
        btnAnularEmbarque.Visible = Estado
        btnCerrarEmbarque.Visible = Estado
    End Sub

    Private Sub Item2(ByVal Estado As Boolean)

        ctbAgenteDeCarga.Enabled = Estado
        ctbMedioTransportes.Enabled = Estado
        ctbTerminal.Enabled = Estado
        cmbPaisOrg.Enabled = Estado
        cmbPuertoOrg.Enabled = Estado
        mskETD.Enabled = Estado
        btnETD.Enabled = Estado
        cmbPaisDest.Enabled = Estado
        cmbPuertoDest.Enabled = Estado
        mskETA.Enabled = Estado
        btnETA.Enabled = Estado

        txtPolizaNum.Enabled = Estado
        txtPolizaMonto.Enabled = Estado

        cmbPolizaBanco.Enabled = Estado
        mskPolizaFecEmi.Enabled = Estado
        mskPolizaFecVen.Enabled = Estado
        cmbPolizaMoneda.Enabled = Estado
        btnImpInfEmb.Enabled = Estado

        'ADICION  DE VALIDACION 
        txtNroOS.Enabled = Estado
        cboCanal.Enabled = Estado

        txtRegimen.Enabled = Estado
        btnBuscaRegimen.Enabled = Estado

        Uc_Almacen_Local.Enabled = Estado
        txtRefDoc.Enabled = Estado
        txtRefCli.Enabled = Estado
        txtMercaderia.Enabled = Estado
        txtDUA.Enabled = Estado
        txtBeneficio.Enabled = Estado
        uc_Transportista.Enabled = Estado
        Uc_AgenteAduana.Enabled = Estado
        txtDireccion.Enabled = Estado
        txtHorario.Enabled = Estado
        txtObservacion.Enabled = Estado
        txtContacto.Enabled = Estado

        txtDiaLibre.Enabled = Estado
        txtKg.Enabled = Estado
        txtM3.Enabled = Estado
        txtSobreEstadia.Enabled = Estado

        txtResponsableCliente.Enabled = Estado
        txtResponsableAgencia.Enabled = Estado

        cmbZona.Enabled = Estado
        mskApertura.Enabled = Estado
        UcProveedor_tab.Enabled = Estado
        cmbTipoDespachos.Enabled = Estado
        cmbTransporte.Enabled = Estado


        cboRegOperacion.Enabled = Estado
        mskEmbarque.Enabled = Estado
        mskFVencRegimen.Enabled = Estado
        txtTransTercero.Enabled = Estado
        txtOSOrigen.Enabled = Estado
        chkseguimiento.Enabled = Estado

    End Sub



    Private Sub dtgGrillaDinamica_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            If (e.RowIndex < 0) Then Exit Sub
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
            Dim ColName As String = sender.columns(e.ColumnIndex).name
            If (ColName = "COSTEO") Then
                sender.EndEdit()
                oDs.Tables.Item(sender.NAME.ToString()).Rows(e.RowIndex).Item("CHKCOSTO") = sender.Rows(e.RowIndex).Cells("COSTEO").Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgGrillaDinamica_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            If sender.CurrentRow IsNot Nothing Then
                Exit Sub
            End If

            If (e.RowIndex < 0) Then Exit Sub
            If (e.ColumnIndex = 2) Then
                If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
                sender.EndEdit()
                oDs.Tables.Item(sender.NAME.ToString()).Rows(e.RowIndex).Item("CHKCOSTO") = sender.Rows(e.RowIndex).Cells("COSTEO").Value.ToString
            End If

            Dim gvCostos As New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
            gvCostos = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
            Dim VALVAR As String = ""
            Dim PSCODVAR As String = gvCostos.Rows(e.RowIndex).Cells("VALVAR").Value
            VALVAR = gvCostos.Rows(e.RowIndex).Cells("VALVAR").Value
            If (VALVAR = "ITTGOA" OrElse VALVAR = "ITTCAG" OrElse VALVAR = "ITTRAC") Then
                Dim ofrmConsultaDetalleCosto As New frmConsultaDetalleCosto
                ofrmConsultaDetalleCosto.pNORSCI = oEmbarque.pNORSCI
                ofrmConsultaDetalleCosto.pCODVAR = PSCODVAR
                ofrmConsultaDetalleCosto.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub gvOrdenesEmb_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub InicializarFormularioDatos()
        btnReaperturar.Visible = False
        dblEmbSelec = 0
        dblEmbSelecEstado = ""
        If oEmbarque IsNot Nothing Then
            oEmbarque.Inicializar()
        End If
        dtgSegAduanero.Rows.Clear()
        dtgSegAduaneroReducido.DataSource = Nothing
        dtgSegAduanero.Columns.Clear()
        If (chkVistaExtendida.Checked = True) Then

            dtgSegAduanero.Visible = True
            dtgSegAduaneroReducido.Visible = False
            Limpiar_Informacion()
            VisualizarIdioma(True)
        Else
            Accesos(objEntidadAcceso)
            dtgSegAduanero.Visible = False
            dtgSegAduaneroReducido.Visible = True

            Limpiar_Informacion()
            cboIdioma.SelectedValue = "ES"
            VisualizarIdioma(False)
        End If

    End Sub

    Private Sub chkVista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVistaExtendida.CheckedChanged
        Try
            InicializarFormularioDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgSegAduanero_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSegAduanero.CellClick

        Dim oclsCierreEmbarque As New clsCierreEmbarque
        Me.Cursor = Cursors.WaitCursor
        If e.RowIndex > -1 Then
            If dblEmbSelec <> dtgSegAduanero.Rows(e.RowIndex).Cells("NORSCI").Value Then
                dblEmbSelec = dtgSegAduanero.Rows(e.RowIndex).Cells("NORSCI").Value
                dblEmbSelecEstado = dtgSegAduanero.Rows(e.RowIndex).Cells("SESTRG").Value
                Limpiar_Informacion()
                Cargar_Informacion_Embarque()
            End If
        End If
        TabControl1_SelectedIndexChanged(TabControl1, Nothing)
        If (e.RowIndex >= 0) Then
            dtgSegAduanero.Rows(e.RowIndex).ReadOnly = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            btnReaperturar.Visible = (oclsCierreEmbarque.NoContieneACliente(oEmbarque.pCCLNT) And IsEmbarqueCerrado(oEmbarque.EmbarqueEstado))
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgSegAduanero_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgSegAduanero.KeyUp
        Dim oclsCierreEmbarque As New clsCierreEmbarque
        Me.Cursor = Cursors.WaitCursor
        If dtgSegAduanero.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
            dblEmbSelec = dtgSegAduanero.Rows(Me.dtgSegAduanero.CurrentCellAddress.Y).Cells("NORSCI").Value
            dblEmbSelecEstado = dtgSegAduanero.Rows(Me.dtgSegAduanero.CurrentCellAddress.Y).Cells("SESTRG").Value
            Limpiar_Informacion()
            Cargar_Informacion_Embarque()

            btnReaperturar.Visible = (oclsCierreEmbarque.NoContieneACliente(oEmbarque.pCCLNT) And IsEmbarqueCerrado(oEmbarque.EmbarqueEstado))
        End If
        TabControl1_SelectedIndexChanged(TabControl1, Nothing)
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub dtgSegAduanero_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgSegAduanero.DataError

    End Sub


    Private Sub dtgSegAduanero_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtgSegAduanero.CellBeginEdit
        dblEmbarqueGrilla = Double.Parse(Me.dtgSegAduanero.CurrentRow.Cells("NORSCI").Value)
    End Sub

    Private Sub dtgSegAduanero_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSegAduanero.CellEndEdit
        Dim EnviarCorreo As Boolean = False
        '***************PARA ENVIO EMAIL X CAMBIO CHECKPOINT*********************
        Control.CheckForIllegalCrossThreadCalls = False
        Dim CodFormato As String = ""
        PARAM_PSTNMBCM = Me.dtgSegAduanero.Columns(e.ColumnIndex).Name
        IndexColumna = e.ColumnIndex
        FilaEmbarque = e.RowIndex

        oclsCheckPointEnvio = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointNotifGeneral
        Dim obeCheckPointFind As Ransa.Servicio.EmailCheckPointAduana.beCheckPointEnvio

        Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
        odaClienteEnvio.Asignar_Lista_Cliente_Envio_Notificacion(dtListaClienteEnvioxModCheckpoint)
        CodFormato = odaClienteEnvio.RetornaFormatoEnvio_X_Cliente(oEmbarque.pCCLNT)

        oclsCheckPointEnvio.CodFormato = CodFormato
        oclsCheckPointEnvio.Tipo_Envio = odaClienteEnvio.Tipo_Envio_Chk_x_Aduana
        If (odaClienteEnvio.DebeNotificarEnvio_X_Cliente(oEmbarque.pCCLNT) And CodFormato <> "") Then
         
            oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
            obeCheckPointFind = oclsCheckPointEnvio.ExisteChkEnvioxPSTNMBCM(PARAM_PSTNMBCM)
            If (obeCheckPointFind IsNot Nothing) Then
                EnviarCorreo = True
            End If
        End If
        '***************PARA ENVIO EMAIL X CAMBIO CHECKPOINT*********************
        Dim intCont As Integer
        If Me.dtgSegAduanero.CurrentCell.Value <> vbNullString Then
            Actualizar_Datos(dblEmbarqueGrilla, Me.dtgSegAduanero.Columns(e.ColumnIndex).Name, Me.dtgSegAduanero.CurrentCell.Value)
        End If
        For intCont = 0 To Me.dtgCheckPoint.Rows.Count - 1
            If dtgCheckPoint.Rows(intCont).Cells("TABRST").Value = Me.dtgSegAduanero.Columns(e.ColumnIndex).Name Then
                dtgCheckPoint.Rows(intCont).Cells("FRETES").Value = Me.dtgSegAduanero.CurrentCell.Value
            End If
        Next
        '***************PARA ENVIO EMAIL X CAMBIO CHECKPOINT*********************
        If (EnviarCorreo = True) Then
            '****ADICIONADO PARA ABB************
            oHebraCheckPointABB = New Thread(AddressOf EnviarActualizacionFechas_Interfaz_ABB_Asinc)
            oHebraCheckPointABB.Start()
            '************************************
            oHebra = New Thread(AddressOf ProcesarEnvioEmail_x_Change_CHK)
            oHebra.Start()
        End If
        '***************PARA ENVIO EMAIL X CAMBIO CHECKPOINT*********************
    End Sub

    Private Sub cmbTransporte_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTransporte.SelectionChangeCommitted

        If Me.cmbTransporte.SelectedValue = 3 Then
            Me.txtTransTercero.Visible = True
        Else
            Me.txtTransTercero.Visible = False
        End If
    End Sub

    Private Sub CambioMedioTrasportes()
        ctbCiaTransp.Limpiar()
        ctbNave.Limpiar()
        If (ctbMedioTransportes.SelectedValue = -1D) Then
            ctbCiaTransp.Limpiar()
            ctbCiaTransp.Enabled = False
        Else
            ctbCiaTransp.Enabled = True
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then
                ctbCiaTransp.Enabled = False
            End If
            Filtrar_CiaTransporte(Decimal.Parse(ctbMedioTransportes.SelectedValue))
        End If
        If (ctbMedioTransportes.SelectedValue = 2D) Then
            ctbNave.Enabled = True
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then
                ctbNave.Enabled = False
            End If
        Else
            ctbNave.Limpiar()
            ctbNave.Enabled = False
        End If



    End Sub

    Private Sub ctbMedioTransportes_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctbMedioTransportes.SelectionChangeCommitted
        Try
            CambioMedioTrasportes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub HabilitarEdicionControlXEstado()
        'ADICION HABILITAR X ESTADO*************************************
        btnAnularEmbarque.Visible = True
        btnCerrarEmbarque.Visible = True
        Dim EstadoEmbarque As String = oEmbarque.EmbarqueEstado.ToUpper
        Select Case EstadoEmbarque
            Case "C"
                Acceso_OrdenesEmbarcadas_Adicionar(False)
                Acceso_OrdenesEmbarcadas_Eliminar(False)
                Item2(False)
                'Item3(False)
                btnImportarAgencia.Visible = False
                btnImportarAgenAscinsa.Visible = False
            Case Else
                Accesos(objEntidadAcceso)
        End Select

        '***********************************************************************
    End Sub

    Private Sub btnReaperturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReaperturar.Click
        Dim obrCierreEmbarque As New clsCierreEmbarque
        Dim msg As String = ""
        Dim retorno As Int32 = 0
        Try
            If (MessageBox.Show("Está seguro de Reaperturar el Embarque " & oEmbarque.pNORSCI, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                retorno = obrCierreEmbarque.Reaperturar_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                If (retorno = 1) Then
                    msg = "EMBARQUE REAPERTURADO." & Chr(13)
                    msg = msg & " Consulte nuevamente el Embarque " & oEmbarque.pNORSCI & " en el estado de Atención."
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    chkVista_CheckedChanged(chkVistaExtendida, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicio.Click
        Try
            Dim odtDatosOpAdicional As New DataTable
            Dim EstadoOperacion As String = ""
            Dim Titulo As String = ""
            Dim PNCCLNFC As Decimal = oEmbarque.pCCLNT
            Dim PNFOPRCN As Decimal = 0
            Dim PNNOPRCN As Decimal = 0
            Dim PSFLGFAC As String = ""
            Dim PNNSECFC As Decimal = 0
            Dim PNNDCFCC As Decimal = 0
            Dim PNCCLNT As Decimal = oEmbarque.pCCLNT
            Dim PNNORSCI As Decimal = oEmbarque.pNORSCI
            odtDatosOpAdicional = ObtenerDatosOperacionTipoAdicional(PNNORSCI, PNCCLNT)
            If (odtDatosOpAdicional.Rows.Count = 0) Then
                Titulo = Ransa.Controls.ServicioOperacion.Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.SIL")
                EstadoOperacion = Ransa.Controls.ServicioOperacion.Comun.ESTADO_Nuevo
            ElseIf odtDatosOpAdicional.Rows.Count > 0 Then
                EstadoOperacion = Ransa.Controls.ServicioOperacion.Comun.ESTADO_Modificado
                Titulo = Ransa.Controls.ServicioOperacion.Comun.Mensaje("MENSAJE.MANTENIMIENTO.MODIFICA.SERVICIO")
                PNCCLNFC = odtDatosOpAdicional.Rows(0)("CCLNFC")
                PNFOPRCN = odtDatosOpAdicional.Rows(0)("FOPRCN")
                PNNOPRCN = odtDatosOpAdicional.Rows(0)("NOPRCN")
                PSFLGFAC = odtDatosOpAdicional.Rows(0)("FLGFAC")
                PNNSECFC = odtDatosOpAdicional.Rows(0)("NSECFC")
                PNNDCFCC = odtDatosOpAdicional.Rows(0)("NDCFCC")
            End If

            Dim oServicio As New Ransa.Controls.ServicioOperacion.Servicio_BE
            With oServicio
                .TIPO = EstadoOperacion
                .CCMPN = oEmbarque.pCCMPN
                .CDVSN = oEmbarque.pCDVSN
                .NOPRCN = PNNOPRCN
                .NSECFC = PNNSECFC
                .CCLNFC = PNCCLNFC
                .CCLNT = PNCCLNT
                .CPLNDV = 1
                .FOPRCN = PNFOPRCN
                .STIPPR = "O" 'otros
                .CTPALJ = "AD" 'ADICIONAL
                .STPODP = "0" 'NO APLICA
                .PSUSUARIO = HelpUtil.UserName
                .NORSCI = PNNORSCI
            End With
            Dim frm As New Ransa.Controls.ServicioOperacion.UcFrmServicioAgregarSA_DS()
            frm.oServicio = oServicio
            frm.Text = Titulo
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Llenar_Servicios_X_Embarque()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerDatosOperacionTipoAdicional(ByVal NORSCI As Decimal, ByVal CCLNT As Decimal) As DataTable
        Dim odtDatosOpAdicional As New DataTable
        Dim obrServicio As New clsServicio
        odtDatosOpAdicional = obrServicio.Existe_Embarque_En_Operacion(NORSCI, CCLNT, "AD")
        Return odtDatosOpAdicional
    End Function



    Private Sub TabObservacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabObservacion.SelectedIndexChanged
        Try
            Dim indice As Int32 = ObtenerIndiceTabSeleccionado(TabControl1.SelectedTab.Name)
            CambiarVisibilidadPorOpcion(indice)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgCheckPoint_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCheckPoint.CellContentDoubleClick
        If (dtgCheckPoint.CurrentRow IsNot Nothing) Then
            Try
                Dim columna As String = dtgCheckPoint.Columns(e.ColumnIndex).Name
                If (columna = "CHKLOG") Then
                    Dim PSCEMB As String = dtgCheckPoint.Rows(e.RowIndex).Cells("CEMB").Value
                    Dim ofrmCheckPointLog As New frmCheckPointLog
                    If (PSCEMB = "P") Then
                        ofrmCheckPointLog.pTipoLog = frmCheckPointLog.TipoLog.EmbarquePreEmbarque
                    ElseIf PSCEMB = "A" Then
                        ofrmCheckPointLog.pTipoLog = frmCheckPointLog.TipoLog.Embarque
                    End If
                    ofrmCheckPointLog.pCCLNT = oEmbarque.pCCLNT
                    ofrmCheckPointLog.pNORSCI = oEmbarque.pNORSCI
                    ofrmCheckPointLog.pNESTDO = dtgCheckPoint.CurrentRow.Cells("NESTDO").Value
                    ofrmCheckPointLog.pCHK = dtgCheckPoint.Rows(e.RowIndex).Cells("CHECKP").Value
                    ofrmCheckPointLog.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub dtgSegAduaneroReducido_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSegAduaneroReducido.CellClick
        Try
            Dim oclsCierreEmbarque As New clsCierreEmbarque
            Me.Cursor = Cursors.WaitCursor
            If e.RowIndex > -1 Then
                If dblEmbSelec <> dtgSegAduaneroReducido.Rows(e.RowIndex).Cells("NORSCI_R").Value Then
                    dblEmbSelec = dtgSegAduaneroReducido.Rows(e.RowIndex).Cells("NORSCI_R").Value
                    dblEmbSelecEstado = dtgSegAduaneroReducido.Rows(e.RowIndex).Cells("SESTRG_R").Value
                    Limpiar_Informacion()
                    Cargar_Informacion_Embarque()
                End If
                btnReaperturar.Visible = (oclsCierreEmbarque.NoContieneACliente(oEmbarque.pCCLNT) And IsEmbarqueCerrado(oEmbarque.EmbarqueEstado))
            End If
            TabControl1_SelectedIndexChanged(TabControl1, Nothing)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgSegAduaneroReducido_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgSegAduaneroReducido.KeyUp
        Try
            Dim oclsCierreEmbarque As New clsCierreEmbarque
            Me.Cursor = Cursors.WaitCursor
            If dtgSegAduaneroReducido.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
                dblEmbSelec = dtgSegAduaneroReducido.Rows(Me.dtgSegAduaneroReducido.CurrentCellAddress.Y).Cells("NORSCI_R").Value
                dblEmbSelecEstado = dtgSegAduaneroReducido.Rows(Me.dtgSegAduaneroReducido.CurrentCellAddress.Y).Cells("SESTRG_R").Value
                Limpiar_Informacion()
                Cargar_Informacion_Embarque()
                btnReaperturar.Visible = (oclsCierreEmbarque.NoContieneACliente(oEmbarque.pCCLNT) And IsEmbarqueCerrado(oEmbarque.EmbarqueEstado))
            End If
            TabControl1_SelectedIndexChanged(TabControl1, Nothing)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "FUNCIONES TOOLSTRIP"
    Private Sub tsmLimpiarFec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLimpiarFec.Click
        Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        If IsCerrado Then Exit Sub
        Me.dtgDocumentos.CurrentCell.Value = ""
    End Sub
    Private Sub tsmQuitarArc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmQuitarArc.Click
        Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        If IsCerrado Then Exit Sub
        Try
            dtgDocumentos.Rows(intPosicion).Cells("URLARC").Value = ""
            dtgDocumentos.Rows(intPosicion).Cells("TNMBAR").Value = ""
            dtgDocumentos.Rows(intPosicion).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub tsmDelChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelChk.Click
        Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        If IsCerrado Then Exit Sub
        Me.dtgCheckPoint.CurrentCell.Value = ""

    End Sub



    Private Sub tsmBorrarCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmBorrarCosto.Click
        Try
            Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            If IsCerrado Then Exit Sub
            If MessageBox.Show("Está seguro de eliminar el costo?.Si elimina el costo también se eliminá los documentos adjuntados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Borrar_Costo_Total()
                Limpiar_Costos_Totales_X_Embarque()
                LLenar_Costos_Totales_X_Embarque()
                Actualizar_Grilla(ACTUALIZACION_GRILLA.COSTOS)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#End Region

#Region "VALIDACION INGRESO DE DATOS(max longitud-numeros decimales)"
    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgDocumentos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgDocumentos.EditingControlShowing
        Try
            Dim colName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
            Dim Texto As New TextBox
            Select Case colName
                Case "NDOCLI"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 20
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgObservaciones_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgObservaciones.EditingControlShowing
        Try
            Dim colName As String = dtgObservaciones.Columns(dtgObservaciones.CurrentCell.ColumnIndex).Name
            Dim Texto As New TextBox
            Select Case colName
                Case "OBSERV"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 250
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub gvOrdenesEmb_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gvOrdenesEmb.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = gvOrdenesEmb.Columns(gvOrdenesEmb.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "CPTDAR"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 20
                Case "NFCTCM"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 30
                Case "QTPCM2"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "NMITFC"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "6-0"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "NSEQIN"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "3-0"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgCarga_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgCarga.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = dtgCarga.Columns(dtgCarga.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "NBULTO"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "6-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub dtgDocAdjuntos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgDocAdjuntos.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = dtgDocAdjuntos.Columns(dtgDocAdjuntos.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "NUMDOC"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "6-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dtgGrillaDinamica_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles oDtgVar.EditingControlShowing
        Try
            Dim Texto As New TextBox
            Dim ColunName As String = sender.Columns(sender.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case ColunName
                Case "IVLORG", "IVLDOL"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5" 'VALIDACION:10 ENTEROS - 5 DECIMALES
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dtgGrillaDinamica_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
            If e.RowIndex > -1 Then
                Dim ColName As String = sender.Columns(e.ColumnIndex).Name
                Select Case ColName
                    Case "COSTOLINK"
                        If sender.CurrentRow.Cells("NMRGIM").Value IsNot DBNull.Value Then
                            Dim CCLNT As Decimal = oEmbarque.pCCLNT
                            Dim CCMPN As String = oEmbarque.pCCMPN
                            Dim NMRGIM As Decimal = Decimal.Parse(sender.CurrentRow.Cells("NMRGIM").Value.ToString)
                            If NMRGIM = 0 Then
                                Exit Sub
                            End If
                            Dim TABLE_NAME As String = "RZOL42C"
                            Dim USER_NAME As String = HelpUtil.UserName
                            Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.CostoxEmbarque)
                            ofrmAdjuntarDocumentos.ShowDialog()
                        End If
                End Select

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgDocumentosAdjuntos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgDocumentosAdjuntos.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            colName = dtgDocumentosAdjuntos.Columns(dtgDocumentosAdjuntos.CurrentCell.ColumnIndex).Name
            Select Case colName
                Case "DOCCOSTO_NDOCLI"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 40
                Case "DOCCOSTO_MONORG"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "DOCCOSTO_MONDOL"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


    Private Sub dtgCarga_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCarga.CellClick
        dtgCarga.EndEdit()
        Try
            If (e.ColumnIndex <= -1 OrElse e.RowIndex <= -1) Then
                Exit Sub
            End If
            Dim ExisteCargaBD As Int32 = 0
            Dim ColName As String = dtgCarga.Columns(e.ColumnIndex).Name
            If (ColName = "DELETE_CARGA") Then
                Dim obeCargaEmbarque As New beDetalleCargaInternacional
                ExisteCargaBD = dtgCarga.Rows(e.RowIndex).Cells("EXISTS_CARGA").Value
                If ExisteCargaBD = 1 Then
                    If MessageBox.Show("¿ Está seguro de eliminar la carga ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        obeCargaEmbarque.PNNORSCI = oEmbarque.pNORSCI
                        obeCargaEmbarque.PNNCODRG = dtgCarga.Rows(e.RowIndex).Cells("CARGA").Value
                        oEmbarque.Elimina_Carga_Tipo(obeCargaEmbarque)
                        dtgCarga.Rows.RemoveAt(e.RowIndex)
                        Actualizar_Grilla(ACTUALIZACION_GRILLA.EMBARQUE) '3 - Datos de Embarque
                    End If
                ElseIf ExisteCargaBD = 0 Then
                    dtgCarga.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgObservaciones_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgObservaciones.CellClick
        dtgObservaciones.EndEdit()
        Try
            If (e.ColumnIndex <= -1 OrElse e.RowIndex <= -1) Then
                Exit Sub
            End If
            Dim ExisteCargaBD As Int32 = 0
            Dim ColName As String = dtgObservaciones.Columns(e.ColumnIndex).Name
            If (ColName = "DELETE_OBS") Then
                Dim PNNORSCI As Decimal = 0
                Dim NRITEM As Decimal = 0
                ExisteCargaBD = dtgObservaciones.Rows(e.RowIndex).Cells("EXISTS_OBS").Value
                If ExisteCargaBD = 1 Then
                    If MessageBox.Show("¿ Está seguro de eliminar la observación ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        PNNORSCI = oEmbarque.pNORSCI
                        NRITEM = dtgObservaciones.Rows(e.RowIndex).Cells("NRITEM_OBS").Value
                        oEmbarque.Eliminar_Observaciones_X_Item(PNNORSCI, NRITEM)
                        dtgObservaciones.Rows.RemoveAt(e.RowIndex)
                        Actualizar_Grilla(ACTUALIZACION_GRILLA.OBSERVACION)
                    End If
                ElseIf ExisteCargaBD = 0 Then
                    dtgObservaciones.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgDocumentosAdjuntos_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgDocumentosAdjuntos.DataError

    End Sub

    Private Sub dtgDocumentosAdjuntos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentosAdjuntos.CellClick
        Try

            Dim ColName As String = ""

            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                intPosicion = e.RowIndex
                ColName = dtgDocumentosAdjuntos.Columns(e.ColumnIndex).Name
                Select Case ColName
                    Case "DOCCOSTO_UPLOAT"
                        If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub

                        If dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_NORSCI").Value.ToString = 0 Then
                            HelpClass.MsgBox("Debe grabar antes la información para poder subir una imagen")
                            Exit Sub
                        End If


                        Dim CCLNT As Decimal = oEmbarque.pCCLNT
                        Dim CCMPN As String = oEmbarque.pCCMPN
                        Dim NMRGIM As Decimal = dtgDocumentosAdjuntos.CurrentRow.Cells("NMRGIM_COS").Value
                        Dim TABLE_NAME As String = "RZOL53C"
                        Dim USER_NAME As String = HelpUtil.UserName
                        Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocCosto)
                        ofrmAdjuntarDocumentos.pPNORSCI = dtgDocumentosAdjuntos.CurrentRow.Cells("DOCCOSTO_NORSCI").Value
                        ofrmAdjuntarDocumentos.pNDOCIN = dtgDocumentosAdjuntos.CurrentRow.Cells("NDOCIN_COS").Value
                        ofrmAdjuntarDocumentos.pNCRRDC = dtgDocumentosAdjuntos.CurrentRow.Cells("DOCCOSTO_NCRRDC").Value
                        ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
                        ofrmAdjuntarDocumentos.ShowDialog()
                        If ofrmAdjuntarDocumentos.myDialogResult = True Then
                            Llenar_Documentos_Adjuntos()
                        End If


                    Case "DUA_COSTO"
                        Dim PSURLARC As String = ""
                        If ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("RUTA_DUA").Value).ToString.Trim.Length > 0 Then
                            PSURLARC = ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_URLARC").Value).ToString.Trim
                            Dim URLARC As String = ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("RUTA_DUA").Value).ToString.Trim

                            Dim url_completo As String = URLARC
                            Process.Start(url_completo)
                        End If

                    Case "DELETE_DOCCOSTO"
                        If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
                        Dim ExisteCargaBD As Int32 = 0
                        ExisteCargaBD = dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_EXISTS").Value
                        If ExisteCargaBD = 1 Then
                            Dim obeDocumentoCosto As New beDocumentoCostos
                            If MessageBox.Show("¿ Está seguro de eliminar el documento de costo ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                obeDocumentoCosto.PNNORSCI = oEmbarque.pNORSCI
                                obeDocumentoCosto.PNNDOCIN = dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_TDOCIN").Value
                                obeDocumentoCosto.PNNCRRDC = dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_NCRRDC").Value
                                oDocApertura.Eliminar_X_Documento_Adj_Costo_Item(obeDocumentoCosto)
                                dtgDocumentosAdjuntos.Rows.RemoveAt(e.RowIndex)

                                If obeDocumentoCosto.PNNDOCIN = 106 Then
                                    Actualizar_Grilla(ACTUALIZACION_GRILLA.DUA, "")
                                End If
                            End If
                        ElseIf ExisteCargaBD = 0 Then
                            dtgDocumentosAdjuntos.Rows.RemoveAt(e.RowIndex)
                        End If
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub dtgDocumentosAdjuntos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentosAdjuntos.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim ColName As String = ""
                Dim PSURLARC As String = ""
                ColName = dtgDocumentosAdjuntos.Columns(e.ColumnIndex).Name
                Select Case ColName
                    Case "DOCCOSTO_LINK"


                        Dim CCLNT As Decimal = oEmbarque.pCCLNT
                        Dim CCMPN As String = oEmbarque.pCCMPN
                        Dim NMRGIM As Decimal = dtgDocumentosAdjuntos.CurrentRow.Cells("NMRGIM_COS").Value
                        If NMRGIM = 0 Then
                            Exit Sub
                        End If
                        Dim TABLE_NAME As String = "RZOL53C"
                        Dim USER_NAME As String = HelpUtil.UserName
                        Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocCosto)
                        ofrmAdjuntarDocumentos.ShowDialog()
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Dim PNTPORGE As Decimal = 0
    Private Function BuscarOperacionRegimen(ByVal obeOpRegimen As beOperacionRegimen) As Boolean
        Return obeOpRegimen.PNTPORGE = PNTPORGE
    End Function

    Private Sub tsmnuBorrarFechaContenedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmnuBorrarFechaContenedor.Click
        Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        If IsCerrado Then Exit Sub
        Me.dtgCarga.CurrentCell.Value = ""
    End Sub

    Private Sub dtgCarga_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCarga.MouseDown

        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.ctmTipoCarga.Items(0).Visible = False
                If (dtgCarga.Rows.Count <= 0) Then Exit Sub
                Dim ColName As String = dtgCarga.Columns(Me.dtgCarga.CurrentCell.ColumnIndex).Name
                If ColName = "CARGA_FECINI" Or ColName = "CARGA_FECVEN" Then
                    Me.ctmTipoCarga.Items(0).Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            Try
                cmbDivision.Usuario = HelpUtil.UserName
                cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
                If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                    cmbDivision.DivisionDefault = "S"
                    cmbDivision.pHabilitado = False
                End If
                cmbDivision.pActualizar()
                cmbDivision_Seleccionar(Nothing)

                InicializarFormularioDatos()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If



    End Sub


    Private Sub btnSolTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolTrans.Click
        Try
            Dim ofrmInformSolicitudTransporte As New frmInformSolicitudTransporte(oEmbarque.pNORSCI)
            ofrmInformSolicitudTransporte.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  

    Private Sub btnImportarAgencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarAgencia.Click
        Try
            Dim oListRegimen As New List(Of beRegimen)
            Dim oListDespacho As New List(Of beTipoDato)
            Dim obeRegimen As New beTipoDato
            Dim oCloneList As New CloneObject(Of beTipoDato)
            Dim oCloneListRegimen As New CloneObject(Of beRegimen)



            Dim obrEmbarque As New clsEmbarque
            If Me.cmbCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Debe de seleccionar un cliente")
                Exit Sub
            End If
            If oEmbarque.pNORSCI = 0 Then
                MessageBox.Show("Seleccione Embarque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim frm As frmImportarAgencia_2
            Me.Cursor = Cursors.WaitCursor
            oEmbarque.pCCLNT = Me.cmbCliente.pCodigo
            oEmbarque.pNORSCI = Me.dblEmbSelec
            oEmbarque.EmbarqueEstado = Me.dblEmbSelecEstado

            If oEmbarque.pPNNMOS > 0 Then
                oListRegimen = oCloneListRegimen.CloneListObject(oListGenRegimen)
                PSVIGENCIA = ConstantesEmbarque.RegimenVigente
                Dim pred As New Predicate(Of beRegimen)(AddressOf BuscarRegimenVigentes)
                oListRegimen = oListGenRegimen.FindAll(pred)
                oListDespacho = oCloneList.CloneListObject(oListGenTipoDespacho)


                frm = New frmImportarAgencia_2(oEmbarque.pCCMPN, oEmbarque.pCDVSN, oEmbarque, oListDespacho, oListRegimen, oEmbarque.pCMEDTR)
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Limpiar_Informacion()
                    Cargar_Informacion_Embarque()
                    Llenar_CheckPoint()


                    '''''' ENVIO TRACKING PACASMAYO''''
                    Dim bolClienteTracking As Boolean = False
                    bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
                    If bolClienteTracking = True Then
                        oAccionTracking = AccionTracking.ListadoRegChk
                        Dim obrCheckPoint As New clsCheckPoint
                        dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        dtChkPointTrackingInicial.Columns.Add("FRETES2")
                        dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
                        For Each item As DataRow In dtChkPointTrackingInicial.Rows
                            item("FLG_APLICA") = "SI"
                        Next
                        oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
                        oHebraCheckPointTrackingPacasmayo.Start()
                    End If
                    '''''' ENVIO TRACKING PACASMAYO''''


                    'If oEmbarque.pCCLNT_PORTAL > 0 Then
                    '    If oEmbarque.pNOREMB.Length > 0 Then
                    '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                    '        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                    '        oHebraCheckPointYRC_COSTO_EMB = New Thread(AddressOf Enviar_Costos_Embarcador)
                    '        oHebraCheckPointYRC_COSTO_EMB.Start()
                    '    End If
                    'End If
                End If
            Else
                MessageBox.Show("Ingrese Orden Servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDetalleEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleEmbarque.Click
        Try
            Dim NORSCI_REG As Decimal = Val(txtEmbOrigen.Text)
            Dim oFrmConsultaEmbarque As FrmConsultaEmbarque
            oFrmConsultaEmbarque = New FrmConsultaEmbarque(oEmbarque.pCCMPN, oEmbarque.pCCLNT, NORSCI_REG, FrmConsultaEmbarque.ENUM_TIPO_EMBARQUE.EX)
            If oFrmConsultaEmbarque.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtEmbOrigen.Text = oFrmConsultaEmbarque.pNORSCI_REG
                txtOSOrigen.Text = oFrmConsultaEmbarque.pPNNMOS_REG
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmnuLimpiarOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmnuLimpiarOrigen.Click
        txtEmbOrigen.Text = 0
        txtOSOrigen.Text = 0
    End Sub

    Private Sub dgvOSRegularizados_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOSRegularizados.CellContentDoubleClick
        If dgvOSRegularizados.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Try
            Dim Name As String = dgvOSRegularizados.Columns(e.ColumnIndex).Name
            Select Case Name
                Case "DET_EMBARQUE"
                    Dim oFrmConsultaDetalleEmbarque As New FrmConsultaDetalleEmbarque
                    oFrmConsultaDetalleEmbarque.pCCMPN = ("" & dgvOSRegularizados.CurrentRow.Cells("CCMPN_RE").Value).ToString.Trim
                    oFrmConsultaDetalleEmbarque.pCDVSN = ("" & dgvOSRegularizados.CurrentRow.Cells("CDVSN_RE").Value).ToString.Trim
                    oFrmConsultaDetalleEmbarque.pCCLNT = dgvOSRegularizados.CurrentRow.Cells("CCLNT_RE").Value
                    oFrmConsultaDetalleEmbarque.pNORSCI = dgvOSRegularizados.CurrentRow.Cells("NORSCI_RE").Value
                    oFrmConsultaDetalleEmbarque.ShowDialog()
            End Select
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtRegimen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRegimen.KeyPress
        If Asc(e.KeyChar) = Keys.Back Then
            LimpiarRegimen()
            txtRegimen_SelectionChangeCommitted(txtRegimen.Tag)
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub LimpiarRegimen()
        txtRegimen.Tag = -1D
        txtRegimen.Text = ""
    End Sub

    Private Sub txtRegimen_SelectionChangeCommitted(ByVal COD_REGIMEN As Decimal)
        Dim FnEmbarque As New clsEmbarqueAduanas

        Dim oListOpRegimen As New List(Of beOperacionRegimen)
        PNTPORGE = COD_REGIMEN
        If PNTPORGE > 0 Then
            Dim pred As New Predicate(Of beOperacionRegimen)(AddressOf BuscarOperacionRegimen)
            oListOpRegimen = oListGenOperacionRegimen.FindAll(pred)
        End If
        Dim obeOperacionRegimen As New beOperacionRegimen
        obeOperacionRegimen.PNTPOPRG = -1
        obeOperacionRegimen.PSTCMPRO = "::Seleccione::"
        oListOpRegimen.Insert(0, obeOperacionRegimen)
        cboRegOperacion.DataSource = oListOpRegimen
        cboRegOperacion.DisplayMember = "PSTCMPRO"
        cboRegOperacion.ValueMember = "PNTPOPRG"
        cboRegOperacion.SelectedValue = -1D

    End Sub

    Private TipoEmb As String = ""
    Private PSVIGENCIA As String = ""
    Private Sub btnBuscaRegimen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaRegimen.Click
        Try
            Dim ofrmRegimen As New frmRegimen
            Dim oListRegimen As New List(Of beRegimen)
            PSVIGENCIA = ConstantesEmbarque.RegimenVigente
            'TipoEmb = "IM"
            Dim pred As New Predicate(Of beRegimen)(AddressOf BuscarRegimenVigentes)
            oListRegimen = oListGenRegimen.FindAll(pred)
            ofrmRegimen.ListRegimen = oListRegimen
            If ofrmRegimen.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtRegimen.Tag = ofrmRegimen.pCodRegimen
                txtRegimen.Text = ofrmRegimen.pRegimen
                txtRegimen_SelectionChangeCommitted(txtRegimen.Tag)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Function BuscarRegimenVigentes(ByVal obeRegimen As beRegimen) As Boolean
        Return (obeRegimen.PSVIGENCIA = PSVIGENCIA)
    End Function

    'Private Function BuscarRegimenVigentes(ByVal obeRegimen As beRegimen) As Boolean
    '    Return (obeRegimen.PSVIGENCIA = PSVIGENCIA AndAlso obeRegimen.PSTPSRVA = TipoEmb)
    'End Function

    Private Sub ConsultaDUA(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtDUA.Text.ToString.Trim.Length > 0 Then
            Dim objFRM As New frmConsultaDUA
            objFRM.DUA = txtDUA.Text.ToString.Trim
            objFRM.ShowDialog()
        End If
    End Sub

    Private Sub Agregar_Item(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarItem.Click

        Dim ObjFrm As New frmAgregarItem
        ObjFrm.pNORSCI = oEmbarque.pNORSCI
        ObjFrm.pCCMPN = oEmbarque.pCCMPN
        ObjFrm.pCCLNT = oEmbarque.pCCLNT
        If ObjFrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Llenar_Detalle_Embarque()
        End If

    End Sub

    Private Sub tsmBorrarDistribucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmBorrarDistribucion.Click
        Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        If IsCerrado Then Exit Sub
        oDocApertura.Borrar_Costos_Embarque_Distribucion_Detalle(oEmbarque.pNORSCI, strCodVariable)
        Llenar_Detalle_Embarque()
    End Sub

    Private Sub btnDelItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelItem.Click

        If gvOrdenesEmb.CurrentRow Is Nothing OrElse gvOrdenesEmb.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim CCLNT As Decimal = 0
        Dim NORSCI As Decimal = 0
        Dim NRPEMB As Decimal = 0
        Dim NORCML As String = ""
        Dim NRITEM As Decimal = 0
        Dim SBITOC As String = ""
        Dim Fila As Int32 = gvOrdenesEmb.CurrentRow.Index
        Try
            If Fila >= 0 Then
                If gvOrdenesEmb.Rows.Count = 1 Then
                    MessageBox.Show("Debe anular el Embarque", "Aviso", MessageBoxButtons.OK)
                Else
                    CCLNT = gvOrdenesEmb.Rows(Fila).Cells("CCLNT").Value
                    NORSCI = gvOrdenesEmb.Rows(Fila).Cells("NORSCI").Value
                    NORCML = ("" & gvOrdenesEmb.Rows(Fila).Cells("NORCML").Value).ToString.Trim
                    NRPEMB = gvOrdenesEmb.Rows(Fila).Cells("NRPEMB").Value
                    NRITEM = gvOrdenesEmb.Rows(Fila).Cells("NRITEM").Value
                    SBITOC = ("" & gvOrdenesEmb.Rows(Fila).Cells("SBITOC").Value).ToString.Trim
                    If MessageBox.Show("Está seguro de eliminar el ítem " & NORCML & "-" & NRITEM & "-" & SBITOC & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        oEmbarque.Eliminar_Item_Embarcado(NORSCI, CCLNT, NORCML, NRITEM, NRPEMB)
                        gvOrdenesEmb.Rows.RemoveAt(Fila)
                        MessageBox.Show("Debe nuevamente distribuir los costos", "Aviso", MessageBoxButtons.OK)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarItem.Click

        Dim ObjFrm As New frmModificarItem

        If gvOrdenesEmb.CurrentRow Is Nothing OrElse gvOrdenesEmb.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Fila As Int32 = gvOrdenesEmb.CurrentRow.Index

        ObjFrm.pCCLNT = gvOrdenesEmb.Rows(Fila).Cells("CCLNT").Value
        ObjFrm.pNORSCI = gvOrdenesEmb.Rows(Fila).Cells("NORSCI").Value
        ObjFrm.pNRPEMB = gvOrdenesEmb.Rows(Fila).Cells("NRPEMB").Value
        ObjFrm.pNORCML = ("" & gvOrdenesEmb.Rows(Fila).Cells("NORCML").Value).ToString.Trim
        ObjFrm.pNRITEM = gvOrdenesEmb.Rows(Fila).Cells("NRITEM").Value
        ObjFrm.pSBITOC = ("" & gvOrdenesEmb.Rows(Fila).Cells("SBITOC").Value).ToString.Trim

        ObjFrm.pQRLCSC = gvOrdenesEmb.Rows(Fila).Cells("QRLCSC").Value
        ObjFrm.pCPTDAR = ("" & gvOrdenesEmb.Rows(Fila).Cells("CPTDAR").Value).ToString.Trim
        ObjFrm.pNFCTCM = ("" & gvOrdenesEmb.Rows(Fila).Cells("NFCTCM").Value).ToString.Trim
        ObjFrm.pNMITFC = gvOrdenesEmb.Rows(Fila).Cells("NMITFC").Value

        If ObjFrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Llenar_Detalle_Embarque()
        End If

    End Sub

    Private Sub Imprimir_FOROL(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFOROL.Click

        Try
            Dim sbValidacion As String = ""
            sbValidacion = ValidarImpresionForol()
            If (sbValidacion.Length <> 0) Then
                MessageBox.Show(sbValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim strTipo As String = Convert.ToDateTime(Me.mskEmbarque.Text.Trim).ToString("yyyyMMdd")
            Dim frm As frmVisorForol
            Dim objForol As New beForol

            objForol.OS = txtNroOS.Text.Trim
            objForol.Cliente = cmbCliente.pRazonSocial.ToUpper() & "(" & Me.cmbCliente.pCodigo & ") " & Obtener_Descripcion_Cliente(CInt(Me.cmbCliente.pCodigo))
            objForol.Mercaderia = txtMercaderia.Text.Trim
            objForol.Proveedor = UcProveedor_tab.pRazonSocial
            objForol.RefCliente = txtNroOC.Text.Trim
            objForol.Beneficio = txtBeneficio.Text.Trim
            If Me.cmbTransporte.SelectedValue = 3 Then
                objForol.Tercero = txtTransTercero.Text.Trim
            Else
                objForol.Tercero = ""
            End If
            objForol.Direccion = txtDireccion.Text.Trim
            objForol.Horario = txtHorario.Text.Trim
            objForol.Contacto = txtContacto.Text.Trim
            If txtObservacion.Text.Trim.Length > 120 Then
                objForol.Observacion1 = txtObservacion.Text.Substring(1, 110).Trim
                objForol.Observacion2 = txtObservacion.Text.Substring(111, Me.txtObservacion.Text.Trim.Length - 111).Trim
            Else
                objForol.Observacion1 = txtObservacion.Text.Trim
                objForol.Observacion2 = ""
            End If
            objForol.Medio = IIf(ctbMedioTransportes.SelectedValue = -1D, "", ctbMedioTransportes.Text)
            objForol.Regimen = IIf(txtRegimen.Tag = -1D, "", txtRegimen.Text.Trim)

            objForol.Despacho = cmbTipoDespachos.Text.Trim
            objForol.Transporte = cmbTransporte.Text.Trim

            objForol.Documentos = dtgDocAdjuntos.DataSource
            frm = New frmVisorForol(objForol, strTipo, "FOROL")
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Imprimir_FMIN(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFMIN.Click

        Try
            Dim sbValidacion As String = ""
            sbValidacion = ValidarImpresionForol()
            If (sbValidacion.Length <> 0) Then
                MessageBox.Show(sbValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim strTipo As String = Convert.ToDateTime(Me.mskEmbarque.Text.Trim).ToString("yyyyMMdd")
            Dim frm As frmVisorForol
            Dim objForol As New beForol

            objForol.OS = txtNroOS.Text.Trim
            objForol.Cliente = cmbCliente.pRazonSocial.ToUpper() & "(" & Me.cmbCliente.pCodigo & ") " & Obtener_Descripcion_Cliente(CInt(Me.cmbCliente.pCodigo))
            objForol.Mercaderia = txtMercaderia.Text.Trim
            objForol.Proveedor = UcProveedor_tab.pRazonSocial
            objForol.RefCliente = txtNroOC.Text.Trim
            objForol.Beneficio = txtBeneficio.Text.Trim
            If Me.cmbTransporte.SelectedValue = 3 Then
                objForol.Tercero = txtTransTercero.Text.Trim
            Else
                objForol.Tercero = ""
            End If
            objForol.Direccion = txtDireccion.Text.Trim
            objForol.Horario = txtHorario.Text.Trim
            objForol.Contacto = txtContacto.Text.Trim
            If txtObservacion.Text.Trim.Length > 120 Then
                objForol.Observacion1 = txtObservacion.Text.Substring(1, 110).Trim
                objForol.Observacion2 = txtObservacion.Text.Substring(111, Me.txtObservacion.Text.Trim.Length - 111).Trim
            Else
                objForol.Observacion1 = txtObservacion.Text.Trim
                objForol.Observacion2 = ""
            End If
            objForol.Medio = IIf(ctbMedioTransportes.SelectedValue = -1D, "", ctbMedioTransportes.Text)
            objForol.Regimen = IIf(txtRegimen.Tag = -1D, "", txtRegimen.Text.Trim)

            objForol.Despacho = cmbTipoDespachos.Text.Trim
            objForol.Transporte = cmbTransporte.Text.Trim

            objForol.Documentos = dtgDocAdjuntos.DataSource
            frm = New frmVisorForol(objForol, strTipo, "FMIN")
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            cmbPlanta.Usuario = HelpUtil.UserName
            cmbPlanta.CodigoCompania = cmbDivision.Compania
            cmbPlanta.CodigoDivision = cmbDivision.Division
            cmbPlanta.PlantaDefault = 1
            cmbPlanta.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CargaClienteNotificacionTracking()
        'Dim dtClientesTracking As New DataTable
        Dim oTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
        dtClientesTracking = oTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo("CLTTKN")
    End Sub

    Public Function ValidaClienteNotifTracking(ByVal intCCLNT As Integer) As Boolean
        If dtClientesTracking.Rows.Count > 0 Then
            For intRow As Integer = 0 To dtClientesTracking.Rows.Count - 1
                If intCCLNT.ToString.Trim = dtClientesTracking.Rows(intRow).Item("CCMPRN").ToString.Trim Then 'dt.Rows(0)("CTPCRG").ToString.Trim
                    Return True
                    Exit Function
                End If
            Next
        End If
        Return False
    End Function


    Enum AccionTracking
        'ACT_CHK
        EdicionChk
        ListadoRegChk
        'ACT_MANT
        'ACT_TODOS_CHK
    End Enum
    Private Sub EnviarWebServiceTracking()
        Dim strmensajeError As String = ""
        Dim Embarque As Decimal = dblEmbSelec
        Dim TotalErrores As Integer = 0
        Dim obrGeneral As New Negocio.clsGeneral
        Dim oHasEnLista As New Hashtable
        Try

            Dim obrCheckPoint As New clsCheckPoint
            Dim obeCheckPoint As New beCheckPoint
            Dim aplicarEnvio As Boolean = False
            Dim oListChkModificados As New List(Of beCheckPoint)
            Dim json_r_in As Object


            Dim dtChkTrackingFinal As New DataTable
            Select Case oAccionTracking
                Case AccionTracking.EdicionChk

                    dtChkTrackingFinal = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, Me.cmbCliente.pCodigo, Embarque)
                    Dim dr() As DataRow
                    Dim pnestdo As Decimal = 0
                    For Each item As DataRow In dtChkPointTrackingInicial.Rows
                        pnestdo = item("NESTDO")
                        dr = dtChkTrackingFinal.Select("NESTDO='" & pnestdo & "'")
                        If dr.Length > 0 Then
                            item("FRETES2") = Val("" & dr(0)("FRETES"))
                        Else
                            item("FRETES2") = Val("" & item("FRETES2"))
                        End If

                    Next


                    For Each item As DataRow In dtChkPointTrackingInicial.Rows
                        obeCheckPoint = New beCheckPoint
                        If (item("FRETES")) <> item("FRETES2") AndAlso ("" & item("STRNSM")).ToString = "X" And item("FLG_APLICA") = "SI" Then
                            obeCheckPoint.PSCCMPN = cmbCompania.CCMPN_CodigoCompania
                            obeCheckPoint.PNNORSCI = dblEmbSelec
                            obeCheckPoint.PSRFCLNT = item("RFCLNT")
                            obeCheckPoint.PNFRETES = Val("" & item("FRETES2"))
                            oListChkModificados.Add(obeCheckPoint)
                            aplicarEnvio = True
                        End If
                    Next


                  
                Case AccionTracking.ListadoRegChk

                    For Each item As DataRow In dtChkPointTrackingInicial.Rows
                        obeCheckPoint = New beCheckPoint
                        If (item("FRETES")) > 0 AndAlso ("" & item("STRNSM")).ToString = "X" And ("" & item("FLG_APLICA")) = "SI" Then
                            obeCheckPoint.PSCCMPN = cmbCompania.CCMPN_CodigoCompania
                            obeCheckPoint.PNNORSCI = dblEmbSelec
                            obeCheckPoint.PSRFCLNT = item("RFCLNT")
                            obeCheckPoint.PNFRETES = Val("" & item("FRETES"))
                            oListChkModificados.Add(obeCheckPoint)
                            aplicarEnvio = True
                        End If
                    Next

                    'Case AccionTracking.ACT_TODOS_CHK

                    '    dtChkTrackingFinal = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, Me.cmbCliente.pCodigo, Embarque)
                    '    For Each item As DataRow In dtChkTrackingFinal.Rows
                    '        obeCheckPoint = New beCheckPoint
                    '        If item("FRETES") <> 0 AndAlso ("" & item("STRNSM")).ToString = "X" Then
                    '            obeCheckPoint.PSCCMPN = cmbCompania.CCMPN_CodigoCompania
                    '            obeCheckPoint.PNNORSCI = dblEmbSelec
                    '            obeCheckPoint.PSRFCLNT = item("RFCLNT")
                    '            obeCheckPoint.PNFRETES = Val("" & item("FRETES"))
                    '            oListChkModificados.Add(obeCheckPoint)
                    '            aplicarEnvio = True
                    '        End If
                    '    Next




            End Select


          


            Dim obeJson As ClassJson

            If aplicarEnvio = True Then
                'inicializamos parametros 
                Dim rutaweb As String = ""
                Dim MiUser As String = ""
                Dim MiPwd As String = ""
                Dim jsondata As String = ""
                Dim token As String = ""
                Dim json_envio As Object
                Dim json_sincodificar As Object
                Dim json_utf8 As Object
                Dim json_de_respuesta As Object
                Dim DocEmbarque As String = ""

                Dim xStr As String = ""

                Dim r As Object
                Dim leer_respuesta As Object

            
                Dim dtURLCheckPoint As New DataTable
                dtURLCheckPoint = obrCheckPoint.DevuelveURL_CheckPoint("SCTRACKPM", cmbCliente.pCodigo)
                If dtURLCheckPoint.Rows.Count > 0 Then
                    rutaweb = Strings.Trim(dtURLCheckPoint.Rows(0).Item("URL"))
                    MiUser = Strings.Trim(dtURLCheckPoint.Rows(0).Item("USURWS"))
                    MiPwd = Strings.Trim(dtURLCheckPoint.Rows(0).Item("USURPW"))
                End If

                If rutaweb = "" Then
                    strmensajeError = "Verificar URL"
                End If
                If MiUser = "" Or MiPwd = "" Then
                    strmensajeError = strmensajeError & Chr(13) & "Verificar usuario/psw URL"
                End If
                If strmensajeError.Length > 0 Then
                    Exit Sub
                End If

                'buscamos dentro del store la data

                Dim obrJsonT As New clsCheckPoint
                Dim dstJsonT As New DataSet
                Dim dtJsonCab As New DataTable
                Dim dtJsonDet As New DataTable
                dstJsonT = obrJsonT.Lista_DataJSON_TramaTracking(cmbCompania.CCMPN_CodigoCompania, cmbCliente.pCodigo, Embarque)
                dtJsonCab = dstJsonT.Tables(0)
                dtJsonDet = dstJsonT.Tables(1)

                If dtJsonCab.Rows.Count > 0 Then
                    DocEmbarque = ("" & dtJsonCab.Rows(0)("DOC_EMBARQUE")).ToString.Trim
                End If
                If DocEmbarque = "" Then
                    Exit Sub
                End If


                Dim TotalBulto As Decimal = 0
                Dim TipoCarga As String = ""
                Dim TotalContenedor As Decimal = 0
                For Each item As DataRow In dtJsonDet.Rows
                    If item("TIPO") = "BULTO" Then
                        TotalBulto = TotalBulto + item("QCANTI")
                        TipoCarga = TipoCarga & item("TIPO_CARGA").ToString.Trim & ","
                    End If
                    If item("TIPO") = "CONTENEDOR" Then
                        TotalContenedor = TotalContenedor + item("QCANTI")
                        TipoCarga = TipoCarga & item("TIPO_CARGA").ToString.Trim & ","
                    End If
                    'TIPO
                Next
                TipoCarga = TipoCarga.Trim
                If TipoCarga.Length > 0 Then
                    TipoCarga = TipoCarga.Substring(0, TipoCarga.Length - 1)
                End If
                If TipoCarga.Length > 50 Then
                    TipoCarga = TipoCarga.Substring(0, 50)
                End If

                'TIPO

                If dtJsonDet.Rows.Count < 0 Then
                    Exit Sub
                End If

                Dim DocBLEmbarque As String = ""
                Dim ListMensaje As New Hashtable
                Dim OC As String = ""

                Dim Bloque_FechaHora As String = Date.Today.ToString("yyyyMMdd") & Now.ToString("HHmmss")

                For Each itemChk As beCheckPoint In oListChkModificados

                    'TotalEnvio = dtJsonCab.Rows.Count
                    TotalErrores = 0
                    'strmensajeError = ""
                    If dtJsonCab.Rows.Count > 0 Then
                        For intRow As Integer = 0 To dtJsonCab.Rows.Count - 1
                            'cargamos el Object
                            obeJson = New ClassJson

                            obeJson.orden_compra_sap = ("" & dtJsonCab.Rows(intRow).Item("ORDEN_COMPRA")).ToString.Trim
                            OC = ("" & dtJsonCab.Rows(intRow).Item("ORDEN_COMPRA")).ToString.Trim
                            DocBLEmbarque = ("" & dtJsonCab.Rows(intRow).Item("DOC_EMBARQUE")).ToString.Trim
                            obeJson.bl = DocBLEmbarque.Replace(" ", "")
                            obeJson.id_tracking = itemChk.PSRFCLNT.Trim

                            'xStr = (obeCheckPoint.PNFRETES).ToString("YYYY-MM-DD 00:00:00")
                            'xStr = FechaNum_a_FechaHoraMinutoSeg(obeCheckPoint.PNFRETES2)
                            'xStr = (itemChk.PNFRETES).ToString("YYYY-MM-DD 00:00:00")
                            'If itemChk.PNFRETES2 = 0 Then
                            '    xStr = "0-0-0 0:0:0"
                            'Else
                            '    xStr = FechaNum_a_FechaHoraMinutoSeg(itemChk.PNFRETES2)
                            'End If
                            If itemChk.PNFRETES = 0 Then
                                xStr = "0-0-0 0:0:0"
                            Else
                                xStr = FechaNum_a_FechaHoraMinutoSeg(itemChk.PNFRETES)
                            End If


                            obeJson.fecha_tracking = xStr
                            obeJson.tipo_despacho = ("" & dtJsonCab.Rows(intRow).Item("DESPACHO")).ToString.Trim

                            obeJson.tipo_carga = TipoCarga
                            obeJson.cantidad_bultos = TotalBulto
                            obeJson.cantidad_contenedores = TotalContenedor

                            obeJson.fob = Val("" & dtJsonCab.Rows(intRow).Item("FOB"))
                            obeJson.flete = Val("" & dtJsonCab.Rows(intRow).Item("FLETE"))
                            obeJson.seguro = Val("" & dtJsonCab.Rows(intRow).Item("SEGURO"))
                            obeJson.cif = Val("" & dtJsonCab.Rows(intRow).Item("CIF"))
                            obeJson.total_derechos = Val("" & dtJsonCab.Rows(intRow).Item("TOTAL_DERECHO"))
                            obeJson.canal = ("" & dtJsonCab.Rows(intRow).Item("CANAL")).ToString.Trim
                            obeJson.dua = ("" & dtJsonCab.Rows(intRow).Item("DUA")).ToString.Trim

                            'inicia envio json
                            jsondata = ""
                            jsondata = JsonConvert.SerializeObject(obeJson)

                            json_envio = New Object
                            json_envio = JsonConvert.SerializeObject(obeJson, Formatting.Indented)


                            json_sincodificar = New Object
                            json_sincodificar = Encoding.UTF8.GetBytes(json_envio)


                            json_utf8 = New Object

                            json_utf8 = Encoding.UTF8.GetString(json_sincodificar)

                            token = "xxTxx"
                            json_de_respuesta = New Object

                            json_de_respuesta = sendJson(rutaweb, MiUser, MiPwd, token, json_utf8)


                            Dim obeRespuestaR As RespuestaR
                            obeRespuestaR = New RespuestaR
                            obeJson = New ClassJson



                            Dim oDatosLog As New BEDatosLog
                            oDatosLog.Sistema = "SC-EMBARQUE/ADUANAS"
                            oDatosLog.Modulo = dblEmbSelec
                            oDatosLog.Rutina = "aplicaciones/Tracking"

                            Try
                                r = New Object
                                json_r_in = New Object
                                leer_respuesta = New Object
                                r = JsonConvert.DeserializeObject(Of RespuestaR)(json_de_respuesta)
                                json_r_in = JsonConvert.SerializeObject(r, Formatting.Indented)
                                leer_respuesta = JsonConvert.DeserializeObject(Of RespuestaR)(json_de_respuesta)

                                Dim codresultado As String = ""
                                Dim msgresultado As String = ""
                                oDatosLog.Codigo = leer_respuesta.resultado

                                If IsNothing(leer_respuesta.error_code) Then
                                    msgresultado = "Envio:" & Bloque_FechaHora & " OC : " & OC & " " & ("" & leer_respuesta.message).ToString.Trim
                                Else
                                    msgresultado = "Envio:" & Bloque_FechaHora & " OC : " & OC & (" Código Error:" & leer_respuesta.error_code & " Error:" & leer_respuesta.message & " Error mensaje:" & leer_respuesta.error_message).ToString.Trim
                                End If
                                oDatosLog.Mensaje = msgresultado

                                If leer_respuesta.resultado = "0" Then
                                    If Not oHasEnLista.Contains(msgresultado) Then
                                        strmensajeError = strmensajeError & msgresultado & Chr(13)
                                    Else
                                        oHasEnLista(msgresultado) = msgresultado
                                    End If

                                    TotalErrores = TotalErrores + 1
                                End If


                            Catch ex As Exception
                                oDatosLog.Codigo = "Error"
                                oDatosLog.Mensaje = "Envio:" & Bloque_FechaHora & " OC : " & OC & ("" & json_de_respuesta).ToString.Trim
                                strmensajeError = ex.Message
                                TotalErrores = TotalErrores + 1
                            End Try

                            oDatosLog.ErrorDescriptor = ""
                            oDatosLog.observaciones = ""
                            oDatosLog.lstr_request_stream = json_utf8
                            obrGeneral.RegistrarLog(oDatosLog)

                        Next

                        strmensajeError = strmensajeError.Trim

                        'TotalErrores
                        Dim msgErrorEnvio As String = strmensajeError
                        Dim obeEnvioInterfazLog As New SOLMIN_SC.Entidad.beEnvioInterfazLog
                        obeEnvioInterfazLog.CMMPN = cmbCompania.CCMPN_CodigoCompania
                        obeEnvioInterfazLog.NORSCI = Embarque
                        If TotalErrores > 0 Then
                            obeEnvioInterfazLog.FSTENV = "E"
                            obeEnvioInterfazLog.USUENV = HelpUtil.UserName
                            If msgErrorEnvio.Length > 250 Then
                                obeEnvioInterfazLog.MSTENV = msgErrorEnvio.Substring(0, 249)
                            Else
                                obeEnvioInterfazLog.MSTENV = msgErrorEnvio
                            End If
                        Else
                            obeEnvioInterfazLog.FSTENV = "S"
                            obeEnvioInterfazLog.MSTENV = ""
                            obeEnvioInterfazLog.MSTEN2 = ""
                            obeEnvioInterfazLog.USUENV = HelpUtil.UserName
                        End If

                        obrGeneral.RegistraEnvioRespuestaTracking(obeEnvioInterfazLog)
                        AsignarEstadoEnvioFilaActual(Embarque, obeEnvioInterfazLog.FSTENV)                     
                    End If


                Next

            End If
            strmensajeError = strmensajeError.Trim


        Catch ex As Exception
            strmensajeError = ex.Message

        End Try

       


        If strmensajeError.Length > 0 Then
            MessageBox.Show("Para el embarque : " & Embarque & Chr(13) & strmensajeError, "AVISO - Envío información Tracking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub AsignarEstadoEnvioFilaActual(pEmbarque As Decimal, EstadoEnvio As String)
        Dim msgEnvio As String = ""
        Select Case EstadoEnvio
            Case "S"
                msgEnvio = "OK"
            Case "E"
                msgEnvio = "ERROR"
            Case ""
                msgEnvio = ""
        End Select
        If dtgSegAduaneroReducido.CurrentRow IsNot Nothing Then
            If dtgSegAduaneroReducido.CurrentRow.Cells("NORSCI_R").Value = pEmbarque Then
                'dtgSegAduaneroReducido.CurrentRow.Cells("FSTENV").Value = obeEnvioInterfazLog.FSTENV
                'dtgSegAduaneroReducido.CurrentRow.Cells("USUARIO_ENVIO").Value = HelpUtil.UserName
                dtgSegAduaneroReducido.CurrentRow.Cells("STATUS_ENVIO").Value = msgEnvio


                Dim estadoImg As String = ""
                Dim bmpImage As Bitmap = Nothing
                estadoImg = EstadoEnvio
                Select Case estadoImg
                    Case "S"
                        bmpImage = My.Resources.Resources.verde
                        dtgSegAduaneroReducido.CurrentRow.Cells("IMG_STATUS").Value = bmpImage
                    Case "E"
                        bmpImage = My.Resources.Resources.Rojo
                        dtgSegAduaneroReducido.CurrentRow.Cells("IMG_STATUS").Value = bmpImage
                    Case ""
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        dtgSegAduaneroReducido.CurrentRow.Cells("IMG_STATUS").Value = bmpImage
                    Case Else
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        dtgSegAduaneroReducido.CurrentRow.Cells("IMG_STATUS").Value = bmpImage
                End Select
            End If
        End If

        If dtgSegAduanero.CurrentRow IsNot Nothing And dtgSegAduanero.Columns("IMGENVIO") IsNot Nothing Then
            If dtgSegAduanero.CurrentRow.Cells("NORSCI").Value = pEmbarque Then

                If dtgSegAduanero.Columns("IMGENVIO") IsNot Nothing Then
                    dtgSegAduanero.CurrentRow.Cells("TEXTENVIO").Value = msgEnvio
                End If


                Dim estadoImg As String = ""
                Dim bmpImage As Bitmap = Nothing
                estadoImg = EstadoEnvio
                Select Case estadoImg
                    Case "S"
                        bmpImage = My.Resources.Resources.verde
                        dtgSegAduanero.CurrentRow.Cells("IMGENVIO").Value = bmpImage
                    Case "E"
                        bmpImage = My.Resources.Resources.Rojo
                        dtgSegAduanero.CurrentRow.Cells("IMGENVIO").Value = bmpImage
                    Case ""
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        dtgSegAduanero.CurrentRow.Cells("IMGENVIO").Value = bmpImage
                    Case Else
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        dtgSegAduanero.CurrentRow.Cells("IMGENVIO").Value = bmpImage
                End Select
            End If

        End If

    End Sub
    Function sendJson(ruta As String, usuario As String, password As String, token As String, json As String) As String
        Using wc As New WebClient

            Try
                '  wc.Headers.Add(HttpRequestHeader.Authorization, "Token token=" & token)

                Dim CadA As String
                Dim CadenaBase64 As String
                CadA = usuario + ":" + password

                Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(CadA)
                CadenaBase64 = Convert.ToBase64String(byt)

                ' wc.Headers.Add(HttpRequestHeader.Authorization, "Token token=" & token)


                wc.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8;")

                wc.Headers.Add(HttpRequestHeader.Authorization, "Basic " & CadenaBase64)




                Dim respuesta = wc.UploadString(ruta, "POST", json)

                Return respuesta


                'wc.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8")
                'wc.Headers.Add(HttpRequestHeader.Authorization, "Token token=" & token)
                'Dim respuesta = wc.UploadString(ruta, "POST", json)
                'Return respuesta


                'wc.UseDefaultCredentials = True
                'wc.Credentials = New NetworkCredential("username", "password")


            Catch x As WebException
                Return New StreamReader(x.Response.GetResponseStream).ReadToEnd
            End Try
        End Using
    End Function

   
    Public Shared Function FechaNum_a_FechaHoraMinutoSeg(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim hms As String = ""

        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Strings.Left(FechaNum, 4).PadLeft(2, "0")
            m = Strings.Right(Strings.Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Strings.Right(FechaNum, 2).PadLeft(2, "0")
            hms = "00:00:00"

            FechaFormada = y & "-" & m & "-" & d & " " & hms
        End If
        Return FechaFormada
    End Function


    Private Sub btnReenviarTracking_Click(sender As Object, e As EventArgs) Handles btnReenviarTracking.Click
        Try
            Dim bolClienteTracking As Boolean = False
            If Me.cmbCliente.pCodigo = 0 Then
                MessageBox.Show("El cliente debe estar seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            bolClienteTracking = ValidaClienteNotifTracking(Me.cmbCliente.pCodigo)
            If bolClienteTracking = False Then
                MessageBox.Show("El reenvío tracking no es aplicable para el cliente seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim obrCheckPoint As New clsCheckPoint
            dtChkPointTrackingInicial = obrCheckPoint.ListarChkTracking(cmbCompania.CCMPN_CodigoCompania, oEmbarque.pCCLNT, oEmbarque.pNORSCI)
            dtChkPointTrackingInicial.Columns.Add("FRETES2")
            dtChkPointTrackingInicial.Columns.Add("FLG_APLICA")
            For Each item As DataRow In dtChkPointTrackingInicial.Rows
                item("FLG_APLICA") = "SI"
            Next
            oAccionTracking = AccionTracking.ListadoRegChk
            oHebraCheckPointTrackingPacasmayo = New Thread(AddressOf EnviarWebServiceTracking)
            oHebraCheckPointTrackingPacasmayo.Start()

        Catch ex As Exception
            btnReenviarTracking.Enabled = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbnLogTracking_Click(sender As Object, e As EventArgs) Handles tbnLogTracking.Click
        Try
            If oEmbarque.pNORSCI = 0 Then
                Exit Sub
            End If
            Dim ofrmLogTracking As New frmLogTracking
            ofrmLogTracking.pNORSCI = oEmbarque.pNORSCI
            ofrmLogTracking.pCCMPN = cmbCompania.CCMPN_CodigoCompania
            ofrmLogTracking.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

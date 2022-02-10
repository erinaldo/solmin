Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO
Public Class frmSeguimientoEmbarqueEX
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

    Private oHebraCheckPointYRC_ITEM_EMB As Thread
    Private oHebraCheckPointYRC_INFO_EMB As Thread
    Private oHebraCheckPointYRC_COSTO_EMB As Thread
    Private oHebraCheckPointYRC_OBS_EMB As Thread
    Private oHebraCheckPointYRC_CHK_EMB As Thread
    Private oHebraCheckPointYRC_STATUSOC_EMB As Thread
    Private oHebraCheckPointYRC_ITEM_EMB_CHK_EMB As Thread
    Private oHebraActualPortal As Thread

    Private PARAM_PSTNMBCM As String = ""
    Private oclsCheckPointEnvio As New clsCheckPointEnvio
    Private dblEmbSelecEstado As String = ""

    Private odtMaestroPartidasArancelarias As New DataTable


    Private oBL_TipoDato As New Negocio.clsTipoDato
    Private oBL_Canal As New Negocio.clsCanal
    Private oBL_MedioTransporte As New Negocio.clsMedioTransporte
    Private oBL_Pais As New Negocio.clsPais
    Private oBL_Puerto As New Negocio.clsPuerto

    'Private oListGenRegimen As New List(Of beTipoDato)
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
        ETD
        ETA
        OBSERVACION
        DOCADJUNTO
        DUA
    End Enum

#End Region

    Private Sub Crear_Estructura_CiaTran()
        oDtCiaTran.Columns.Add(New DataColumn("CCIANV", GetType(System.String)))
        oDtCiaTran.Columns.Add(New DataColumn("TNMCIN", GetType(System.String)))
    End Sub


    Private Sub Cargar_Inicio()
        Dim oListTipoDatos As New List(Of beTipoDato)
        oListTipoDatos = oBL_TipoDato.Lista_TipoDato_Todos
        'oListGenRegimen = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.REGIMEN)

        Dim obrclsRegimen As New clsRegimen

        oListGenRegimen = obrclsRegimen.ListarRegimen()
        oListGenOperacionRegimen = obrclsRegimen.ListarOperacionRegimen()

        oListGenTipoDespacho = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.TIPO_DESPACHO)
        oListGenTransporteAgencia = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.TRASNPORTE_AGENCIA)
        oListGenTipoCarga = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.TIPO_CARGA)
        oListGenAlmacenDestinoLocal = oBL_TipoDato.Lista_TipoDato_x_NTPODT(oListTipoDatos, Negocio.clsTipoDato.TIPO_DATO.ALMACEN_DESTINO_LOCAL)
        oListGenCanal = oBL_Canal.Lista_Canal_Todos
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

        'para combo regimen,canal

        'Dim oListRegimen As New List(Of beTipoDato)
        'Dim obeRegimen As New beTipoDato
        'Dim oCloneList As New CloneObject(Of beTipoDato)
        'oListRegimen = oCloneList.CloneListObject(oListGenRegimen)
        'obeRegimen.PNNCODRG = -1
        'obeRegimen.PSTDSCRG = "::Seleccione::"
        'oListRegimen.Insert(0, obeRegimen)

        'cboRegimen.DataSource = oListRegimen
        'cboRegimen.DisplayMember = "PSTDSCRG"
        'cboRegimen.ValueMember = "PNNCODRG"
        'cboRegimen.SelectedValue = -1D


        Dim oListRegimen As New List(Of beRegimen)
        Dim obeRegimen As New beRegimen
        Dim oCloneList As New CloneObject(Of beRegimen)
        oListRegimen = oCloneList.CloneListObject(oListGenRegimen)
        obeRegimen.PNTPORGE = -1
        obeRegimen.PSTCMRGA = "::Seleccione::"
        oListRegimen.Insert(0, obeRegimen)

        cboRegimen.DataSource = oListRegimen
        cboRegimen.DisplayMember = "PSTCMRGA"
        cboRegimen.ValueMember = "PNTPORGE"
        cboRegimen.SelectedValue = -1D



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


    End Sub




    Private Sub CargarCombos()

        ctbAgenteDeCarga.DataSource = oDsSegAdu.Tables("oDtAgenteCarga").Copy
        ctbAgenteDeCarga.DisplayMember = "TNMAGC"
        ctbAgenteDeCarga.ValueMember = "CAGNCR"
        Me.ctbAgenteDeCarga.DataBind()


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



        Llenar_Paises()
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub
    Private Sub CargarCliente()
        cmbCliente.pAccesoPorUsuario = True
        cmbCliente.pRequerido = True
        cmbCliente.pUsuario = HelpUtil.UserName
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

            txtEmbOrigen.ReadOnly = True
            txtOSOrigen.ReadOnly = True


            dgvOSRegularizados.AutoGenerateColumns = False



            Dim oclsEstado As New clsEstado
            Dim dtTipoOperacion As New DataTable
            cboTipoOperacion.DataSource = oclsEstado.Listar_TipoOperacionEmbarque
            cboTipoOperacion.DisplayMember = "TEX"
            cboTipoOperacion.ValueMember = "COD"
            cboTipoOperacion.SelectedValue = "EX"
            cboTipoOperacion.Enabled = False


            Cargar_Compania()
            CargarCliente()

            TabObservacion.SelectTab(TabEmbarqueAduana)
            dtgObsCargaInternacional.AutoGenerateColumns = False

            btnReaperturar.Visible = False
            gvOrdenesEmb.AutoGenerateColumns = False
            Dim oDs As New DataSet
            oDs.Tables.Clear()
            Cargar_Inicio()
            CargarCombos()
            Validar_Usuario_Autoridado()
            bolBuscarSegAdu = False
            btnActPortal.Visible = False
            gbxFianza.Visible = False
            dblEmbSelec = 0
            dblEmbSelecEstado = ""
            Cargar_Tablas()
            Crear_Grilla_Documentos()
            Crear_Grilla_Carga()
            bolBuscarSegAdu = True
            Filtrar_SegAduanero()
            Crear_TabPages()
            Crear_Grilla_Documentos_Adjuntos()
            dtgSegAduaneroReducido.AutoGenerateColumns = False
            chkVistaExtendida.Checked = False
            dtgSegAduaneroReducido.Visible = True
            dtgSegAduanero.Visible = False
            btnExportarXLS.Visible = False

            dtgServicios.AutoGenerateColumns = False

            CargarIdioma()
            VisualizarIdioma(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Tablas()


        Me.cmbEstado.DataSource = oEstado.Estado_Aduanero
        Me.cmbEstado.ValueMember = "COD"
        Me.cmbEstado.DisplayMember = "TEX"
        Me.cmbEstado.SelectedValue = "A"

        oDocApertura.Crea_Lista()
        oDocApertura.Codigo = CType(oDocApertura.Lista, DataTable).Rows(0).Item("NTPODT").ToString.Trim
        'Me.oDsSegAdu.Tables("oDtDocApertura").Load(oDocApertura.Lista_Doc_Apertura(1).CreateDataReader)
        oDtDocApertura = oDocApertura.Lista_Doc_Apertura(1)
        dtgDocAdjuntos.DataSource = oDtDocApertura



        oMultiTabla.Tabla = "C"
        oMultiTabla.Crea_Detalles()
        Me.oDsSegAdu.Tables("oDtCiaTransporte").Load(oMultiTabla.Lista_Detalles.CreateDataReader())



        Dim oListTransporteAgencia As New List(Of beTipoDato)
        Dim obeTransporteAgencia As New beTipoDato
        Dim oCloneList As New CloneObject(Of beTipoDato)
        oListTransporteAgencia = oCloneList.CloneListObject(oListGenTransporteAgencia)
        obeTransporteAgencia.PNNCODRG = -1
        obeTransporteAgencia.PSTDSCRG = "::Seleccione::"
        oListTransporteAgencia.Insert(0, obeTransporteAgencia)


        Me.cmbTransporte.DataSource = oListTransporteAgencia
        Me.cmbTransporte.DisplayMember = "PSTDSCRG"
        Me.cmbTransporte.ValueMember = "PNNCODRG"
        Me.cmbTransporte.SelectedValue = -1D



        Me.oDsSegAdu.Tables("oDtDocumento").Load(oDocApertura.Lista_Documento.CreateDataReader())


        oMoneda.Crea_Lista()


        Me.cmbPolizaMoneda.DataSource = oMoneda.Lista_Moneda(1)
        Me.cmbPolizaMoneda.ValueMember = "CMNDA1"
        Me.cmbPolizaMoneda.DisplayMember = "TSGNMN"
        Me.cmbPolizaMoneda.SelectedValue = "100"

        Me.cmbPolizaBanco.DataSource = oBanco.Lista_Banco(1)
        Me.cmbPolizaBanco.ValueMember = "CBNCFN"
        Me.cmbPolizaBanco.DisplayMember = "TCMBCF"

        Me.cmbZona.DataSource = oZona.Lista_Zona(1)
        Me.cmbZona.ValueMember = "CZNFCC"
        Me.cmbZona.DisplayMember = "TAZNFC"
        oNoLaborable.Inicio = 20080101
        oNoLaborable.Fin = Now.ToString("yyyyMMdd")
        objDtDia = oNoLaborable.dtNoLaborables
    End Sub





    Private Sub Crear_Grilla_Documentos()
        Dim oDcBx As DataGridViewComboBoxColumn
        Dim oDcFc As CalendarColumn
        Dim oDcBp As DataGridViewImageColumn
        Dim oDcBt As DataGridViewButtonColumn

        oDcBx = CType(dtgDocumentos.Columns("TDOCIN"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = Me.oDsSegAdu.Tables("oDtDocumento")
        oDcBx.DisplayMember = "TDOCIN"
        oDcBx.ValueMember = "NDOCIN"
        oDcBx.DataPropertyName = "NDOCIN"
        oDcBx.ReadOnly = Me.STSCHG1


        oDcFc = CType(dtgDocumentos.Columns("FECORG"), CalendarColumn)
        oDcFc.ReadOnly = Me.STSCHG1

        oDcFc = CType(dtgDocumentos.Columns("FECCOP"), CalendarColumn)
        oDcFc.ReadOnly = Me.STSCHG1


        oDcBp = CType(dtgDocumentos.Columns("LINK"), DataGridViewImageColumn)
        oDcBp.ReadOnly = Me.STSCHG1

        oDcBt = CType(dtgDocumentos.Columns("UPLOAT"), DataGridViewButtonColumn)
        oDcBt.Visible = Not Me.STSCHG1

    End Sub

    Private Sub Crear_Grilla_Carga()
        Dim oListTipoCarga As New List(Of beTipoDato)
        Dim oCloneList As New CloneObject(Of beTipoDato)
        oListTipoCarga = oCloneList.CloneListObject(oListGenTipoCarga)

        Dim oDcBx As DataGridViewComboBoxColumn
        oDcBx = CType(dtgCarga.Columns("CARGA"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = oListTipoCarga
        oDcBx.DisplayMember = "PSTDSCRG"
        oDcBx.ValueMember = "PNNCODRG"

    End Sub

    Private Function Llenar_Resumen_Datos() As DataTable
        Dim odtResumEmb As New DataTable
        Dim CCLNT As Decimal = 0
        Dim ofnEmbarqueAduanas As New clsEmbarqueAduanas
        If Me.cmbCliente.pCodigo Then
            Dim oDtTotales As DataTable
            Dim SESTRG_EMBARQUE As String = ""
            Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
            oFiltroEmbarque = ObtenerFiltroDatos()
            CCLNT = oFiltroEmbarque.PNCCLNT
            SESTRG_EMBARQUE = oFiltroEmbarque.PSSESTRG
            oDtTotales = oEmbarque.Lista_Embarque_Aduana(oFiltroEmbarque)
            odtResumEmb = ofnEmbarqueAduanas.FormarDatosResumenInicialEmbarque(CCLNT, oDtTotales)
        End If
        Return odtResumEmb
    End Function

#Region "Crear Grilla Aduanera"
    Private Function IsVisible(ByVal Visible As String)
        Dim EsVisible As Boolean = False
        EsVisible = Visible.Equals("S")
        Return EsVisible
    End Function
    Private Sub Llenar_Aduanero()
        If Me.cmbCliente.pCodigo <> 0 Then
            Me.dtgSegAduanero.Rows.Clear()
            Me.dtgSegAduanero.Columns.Clear()

            Dim oDt As DataTable
            Dim intCont As Integer

            Dim oDcTx As DataGridViewColumn
            Dim oDcFc As CalendarColumn

            Dim oTableroDatos As New clsTableroDatos
            oDt = oTableroDatos.Llenar_Tabla_X_Opcion(GetCompania, cmbCliente.pCodigo, "A", 1, "")

            Dim dr() As DataRow

            dr = oDt.Select("TNMBCM='NORSCI'")
            If (dr.Length = 0) Then
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = "NORSCI"
                oDcTx.HeaderText = "Embarque"
                oDcTx.Resizable = DataGridViewTriState.False
                oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.ReadOnly = True
                oDcTx.Frozen = True
                Me.dtgSegAduanero.Columns.Add(oDcTx)
            End If

            Dim NAME_COLUMNA As String = ""
            Dim DES_COLUMNA As String = ""
            Dim EsVisible As Boolean = False
            Dim COLUMNA_IDIOMA As String = ""
            If cboIdioma.SelectedValue = "IN" Then
                COLUMNA_IDIOMA = "TDITIN"
            Else
                COLUMNA_IDIOMA = "TCOLUM"
            End If
            For intCont = 0 To oDt.Rows.Count - 1
                NAME_COLUMNA = oDt.Rows(intCont).Item("TNMBCM").ToString.Trim
                DES_COLUMNA = oDt.Rows(intCont).Item(COLUMNA_IDIOMA).ToString.Trim
                EsVisible = IsVisible(oDt.Rows(intCont).Item("STPCRE").ToString.Trim)
                Select Case NAME_COLUMNA
                    Case "NORSCI"

                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.Visible = EsVisible
                        oDcTx.Frozen = True
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        oDcTx.ReadOnly = True
                        Me.dtgSegAduanero.Columns.Add(oDcTx)

                    Case "REGIMEN", "DESPACHO"

                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        oDcTx.ReadOnly = True
                        oDcTx.Visible = EsVisible
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        Me.dtgSegAduanero.Columns.Add(oDcTx)

                    Case "FECDCP", "FECNUM", "FECPGD", "FECLEV", "FECALM", _
                         "FECPRO", "FECPGP"

                        oDcFc = New CalendarColumn
                        oDcFc.Name = NAME_COLUMNA
                        oDcFc.HeaderText = DES_COLUMNA
                        oDcFc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcFc.Visible = EsVisible
                        oDcFc.Tag = HelpClass_NPOI_SC.keyDatoFecha
                        Me.dtgSegAduanero.Columns.Add(oDcFc)

                    Case "RECPOP", "FAPRAR", "FAPREV", "CKCLPV", "CKRECO", _
                         "CKIGAT", "CKAECL", "CHKEPR", _
                         "DEMCOP", "FACORG", "DEMORG", "TRACOP", "TRAORG", "FACCOP", "SEGCOP", "SEGORG", _
                          "CHKETD", "CHKETA", "FECFAC", "FCDCOR", "CKCROK", "CKCRDS"


                        oDcFc = New CalendarColumn
                        oDcFc.Name = NAME_COLUMNA
                        oDcFc.HeaderText = DES_COLUMNA
                        oDcFc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcFc.Visible = EsVisible
                        oDcFc.ReadOnly = True
                        oDcFc.Tag = HelpClass_NPOI_SC.keyDatoFecha
                        Me.dtgSegAduanero.Columns.Add(oDcFc)


                    Case "GFOB", "FLETE", "SEGURO", "CIF", "ADVALOREM", "IGV", "IPM", "TOTALDER", "FOB", "EXW", _
                          "ITTCAG", "OTSGAS", "SUMIPM", "ITTCEM", "ITTGOA"
                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        oDcTx.ReadOnly = True
                        oDcTx.Visible = EsVisible
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoNumero
                        Me.dtgSegAduanero.Columns.Add(oDcTx)

                    Case "QVOLMR", "QPSOAR", "NDIALB", "NDIASE"

                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        oDcTx.DefaultCellStyle.Padding = New Padding(2)
                        oDcTx.ReadOnly = True
                        oDcTx.Visible = EsVisible
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoNumero
                        Me.dtgSegAduanero.Columns.Add(oDcTx)


                    Case "CODTPN", "PARARN", "PRARAN", "NUMFAC", _
                          "FORCML", "MONEDA"
                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        oDcTx.ReadOnly = True
                        oDcTx.Visible = EsVisible
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        Me.dtgSegAduanero.Columns.Add(oDcTx)

                    Case "TOBERV", "TOBERVDIF", "TOBERVEMB"
                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        oDcTx.ReadOnly = True
                        oDcTx.Width = 600
                        oDcTx.Visible = False
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        Me.dtgSegAduanero.Columns.Add(oDcTx)

                    Case "DOCPEN"
                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        oDcTx.ReadOnly = False
                        oDcTx.Width = 200
                        oDcTx.Visible = EsVisible
                        oDcTx.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        Me.dtgSegAduanero.Columns.Add(oDcTx)

                    Case "CTRMAL", "CAGNCR", "TPRVCL", "CTRSPT", "ALMDES", "NORCML", _
                           "TNOMCOM", "TDITES", "CMEDTR", _
                           "DOCEMB", "CVPRCN", "CTRMAL", "CPRTOE", "TCARGA", "NBLTAR", "PNNMOS", _
                           "NREFCLEMB", "TTINTC", "NREFCL", "TIPENT", "TPAGME", "TCITCLOC", _
                            "QCNTITOC", "QRLCSCEMB", "NRITOCS"
                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        oDcTx.ReadOnly = True
                        oDcTx.Visible = EsVisible
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        Me.dtgSegAduanero.Columns.Add(oDcTx)


                    Case "DIFDCN", "DIFPDA", "DXF8F4", "NUMSEG", "DXF4F3", "DXF6F5", _
                        "DIFERM", "DIFEME", "DIFEEP", "MNTITM", "MNTDLR", "PORGIM"

                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        oDcTx.ReadOnly = True
                        oDcTx.Visible = EsVisible
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        Me.dtgSegAduanero.Columns.Add(oDcTx)

                    Case Else
                        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                        oDcTx.Name = NAME_COLUMNA
                        oDcTx.HeaderText = DES_COLUMNA
                        oDcTx.Resizable = DataGridViewTriState.False
                        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        oDcTx.Visible = EsVisible
                        oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                        oDcTx.ReadOnly = True
                        Me.dtgSegAduanero.Columns.Add(oDcTx)
                End Select
            Next intCont

            If (dtgSegAduanero.Columns("SESTRG") Is Nothing) Then
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = "SESTRG"
                oDcTx.HeaderText = "SESTRG"
                oDcTx.Resizable = DataGridViewTriState.False
                oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.Visible = False
                oDcTx.ReadOnly = True
                oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                Me.dtgSegAduanero.Columns.Add(oDcTx)
            End If
            If (dtgSegAduanero.Columns("SESTRG_ESTADO") Is Nothing) Then
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = "SESTRG_ESTADO"
                oDcTx.HeaderText = "Estado"
                oDcTx.Resizable = DataGridViewTriState.False
                oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.ReadOnly = True
                oDcTx.Tag = HelpClass_NPOI_SC.keyDatoTexto
                Me.dtgSegAduanero.Columns.Add(oDcTx)
            End If
            If oDt.Rows.Count > 0 Then
                Dim oDrVw As DataGridViewRow
                Dim Fila As Int32 = 0
                Dim ExistColOrdenCompra As Boolean = dtgSegAduanero.Columns("NORCML") IsNot Nothing
                Dim ExistColComprador As Boolean = dtgSegAduanero.Columns("TNOMCOM") IsNot Nothing

                Dim odtResumEmb As New DataTable
                odtResumEmb = Llenar_Resumen_Datos()

                For intCont = 0 To odtResumEmb.Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgSegAduanero)
                    Me.dtgSegAduanero.Rows.Add(oDrVw)
                    Fila = dtgSegAduanero.Rows.Count - 1
                    dtgSegAduanero.Rows(Fila).Cells("NORSCI").Value = odtResumEmb.Rows(intCont)("NORSCI")
                    If (ExistColOrdenCompra) Then
                        dtgSegAduanero.Rows(Fila).Cells("NORCML").Value = odtResumEmb.Rows(intCont)("NORCML").ToString.Trim
                        dtgSegAduanero.Rows(Fila).Cells("NORCML").ToolTipText = "Órdenes de Compra"
                    End If
                    If (ExistColComprador = True) Then
                        dtgSegAduanero.Rows(Fila).Cells("TNOMCOM").Value = odtResumEmb.Rows(intCont)("TNOMCOM").ToString.Trim
                        dtgSegAduanero.Rows(Fila).Cells("TNOMCOM").ToolTipText = "Comprador"
                    End If
                Next intCont

                Llenar_Seguimiento_Aduanero()
            End If

        End If
    End Sub


#Region "Vista basica"
    Private Sub Llenar_Aduanero_Vista_Basica()

        If Me.cmbCliente.pCodigo > 0 Then
            Me.dtgSegAduaneroReducido.DataSource = Nothing
            Dim odtSegBasico As New DataTable
            Dim obrEmbarque As New clsEmbarque
            'Dim odtEmbarque As New DataTable
            Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
            oFiltroEmbarque = ObtenerFiltroDatos()
            odtSegBasico = obrEmbarque.ListarSeguimientoAduaneroVistaReducido(oFiltroEmbarque)
            'odtSegBasico = Llenar_Seguimiento_Aduanero_Basica()
            dtgSegAduaneroReducido.DataSource = odtSegBasico
        End If
    End Sub

    'Private Function Llenar_Seguimiento_Aduanero_Basica() As DataTable
    '    Dim obrEmbarque As New clsEmbarque
    '    Dim odtEmbarque As New DataTable
    '    Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
    '    oFiltroEmbarque = ObtenerFiltroDatos()
    '    odtEmbarque = obrEmbarque.ListarSeguimientoAduaneroVistaReducido(oFiltroEmbarque)
    '    Return odtEmbarque
    'End Function

#End Region

#End Region

#Region "Llenar Grilla Aduanera"
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

        If Me.cmbEstado.Text = "TODOS" Then
            strEstado = ""
        Else
            strEstado = Me.cmbEstado.SelectedValue
        End If
        oFiltroEmbarque.PNCCLNT = oEmbarque.pCCLNT
        oFiltroEmbarque.PNFECINI = Me.dtpInicio.Value.ToString("yyyyMMdd")
        oFiltroEmbarque.PNFECFIN = Me.dtpFin.Value.ToString("yyyyMMdd")
        oFiltroEmbarque.PSNORCML = Me.txtOC.Text.Trim
        oFiltroEmbarque.PSCPRVCL = UcProveedor.pCodigo

        If Me.txtFilOS.Text.Trim.Length > 0 Then
            IsNumero = Decimal.TryParse(Me.txtFilOS.Text.Trim, PNNMOS)
            oFiltroEmbarque.PSPNNMOS = PNNMOS
        End If




        oFiltroEmbarque.PSDOCEMB = Me.txtDocEmbarque.Text.Trim

        If Me.txtEmbarque.Text.Trim.Length > 0 Then
            IsNumero = Decimal.TryParse(Me.txtEmbarque.Text.Trim, NORSCI)
            oFiltroEmbarque.PSNORSCI = NORSCI
        End If

        If cboTipoOperacion.SelectedValue = "0" Then
            oFiltroEmbarque.PSTPSRVA = ""
        ElseIf cboTipoOperacion.SelectedValue <> "0" Then
            oFiltroEmbarque.PSTPSRVA = cboTipoOperacion.SelectedValue
        End If
        oFiltroEmbarque.PSSESTRG = strEstado
        Return oFiltroEmbarque
    End Function


    Private Sub Llenar_Seguimiento_Aduanero()
        'Dim CMEDTR As Decimal = 0
        Dim sbListaEmbarques As New StringBuilder
        Dim xFila As Int32 = 0
        Dim stListaListaEmbarques As String = ""
        For Each Item As DataGridViewRow In dtgSegAduanero.Rows
            sbListaEmbarques.Append(Item.Cells("NORSCI").Value)
            If (xFila < dtgSegAduanero.Rows.Count - 1) Then
                sbListaEmbarques.Append(",")
            End If
            xFila += 1
        Next
        stListaListaEmbarques = sbListaEmbarques.ToString
        If (stListaListaEmbarques.Length = 0) Then
            Exit Sub
        End If

        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim EvaluaValor As Boolean = False
        Dim oDt As DataTable
        Dim oDtFac As DataTable
        Dim oDtDato As DataTable
        Dim oDtStatus As DataTable
        Dim oDtObs As DataTable
        Dim oDtObsCI As DataTable
        Dim oDtStatusCI As DataTable
        Dim oDtCostos As DataTable

        Dim intCont As Integer
        Dim intCol As Integer
        'Dim strFactura As String
        'Dim strDato As String
        Dim strCant As String

        'Dim strFechaOrg As String
        'Dim strFechaCop As String
        Dim oDr() As DataRow
        Dim SESTRG_EMBARQUE As String = ""


        Dim oListTipoCarga As New List(Of beTipoDato)
        Dim oCloneList As New CloneObject(Of beTipoDato)
        Dim oCloneListRegimen As New CloneObject(Of beRegimen)

        oListTipoCarga = oCloneList.CloneListObject(oListGenTipoCarga)

        Dim oListDespacho As New List(Of beTipoDato)
        oListDespacho = oCloneList.CloneListObject(oListGenTipoDespacho)

        Dim oListAlmacenDestinoLocal As New List(Of beTipoDato)
        oListAlmacenDestinoLocal = oCloneList.CloneListObject(oListGenAlmacenDestinoLocal)

        Dim PNNORSCI As Decimal = 0
        Dim IGV As Decimal = 0
        Dim IPM As Decimal = 0
        Dim odtItemEmbarcados As New DataTable
        Dim ExisteColumnaCalculo As Boolean = False
        Dim CHK_EMBARQUE_NESTDO_107 As String = ""
        Dim CHK_LLEGADA_108 As String = ""
        Dim CHK_LEVANTE_123 As String = ""
        Dim CHK_ALMACEN_124 As String = ""
        Dim MONTO_OC_ORIGEN As Decimal = 0
        Dim MONTO_OC_EQUIV_DOLAR As Decimal = 0
        Dim TOTAL_DERECHO As Decimal = 0
        Dim POR_GASTOS_NACIONALIZACION As Decimal = 0


        Dim obrTransporte As New clsTransporte
        Dim odtTransporteForol As New DataTable
        obrTransporte.Transporte_Forol()
        odtTransporteForol = obrTransporte.Tabla

        Dim COLNAME As String = ""
        Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
        oFiltroEmbarque = ObtenerFiltroDatos()
        oFiltroEmbarque.PSEMBARQUES = stListaListaEmbarques
        'SESTRG_EMBARQUE = oFiltroEmbarque.PSSESTRG


        'Lista_Datos_Seguimiento_Extendido
        'dsExtendido.Tables(0).TableName = "DATOS_EMBARQUE"
        'dsExtendido.Tables(1).TableName = "DOCUMENTO_EMBARQUE"
        'dsExtendido.Tables(2).TableName = "DETALLE_EMBARQUE"
        'dsExtendido.Tables(3).TableName = "CHECKPOINT_EMBARQUE"
        'dsExtendido.Tables(4).TableName = "OBSERVACION_EMBARQUE"
        'dsExtendido.Tables(5).TableName = "ITEM_EMBARQUE"
        'dsExtendido.Tables(6).TableName = "COSTOS_EMBARQUE"

        'oDt = oEmbarque.Lista_Seguimiento_Aduanero_Resumido(oFiltroEmbarque)
        'oDtFac = oEmbarque.Lista_Documento_Cliente(GetCompania, oEmbarque.pCCLNT, SESTRG_EMBARQUE)
        'oDtDato = oEmbarque.Lista_Datos_X_Cliente(GetCompania, oEmbarque.pCCLNT, SESTRG_EMBARQUE)
        'oDtStatus = oEmbarque.Lista_Status_X_Cliente(GetCompania, oEmbarque.pCCLNT, SESTRG_EMBARQUE)
        'oDtObs = oEmbarque.Lista_Observacion_X_Cliente(GetCompania, oEmbarque.pCCLNT, SESTRG_EMBARQUE)
        'odtItemEmbarcados = oEmbarque.Datos_Ordenes_Compra_X_Embarques(GetCompania, oEmbarque.pCCLNT, stListaListaEmbarques)
        'oDtCostos = oDocApertura.Lista_Costos_Totales_Embarque_ALL(stListaListaEmbarques)

        Dim dsDatosEmbarque As New DataSet
        dsDatosEmbarque = oEmbarque.Lista_Datos_Seguimiento_Extendido(oFiltroEmbarque)


        oDt = dsDatosEmbarque.Tables("DATOS_EMBARQUE")
        oDtFac = dsDatosEmbarque.Tables("DOCUMENTO_EMBARQUE")
        oDtDato = dsDatosEmbarque.Tables("DETALLE_EMBARQUE")
        oDtStatus = dsDatosEmbarque.Tables("CHECKPOINT_EMBARQUE")
        oDtObs = dsDatosEmbarque.Tables("OBSERVACION_EMBARQUE")
        odtItemEmbarcados = dsDatosEmbarque.Tables("ITEM_EMBARQUE")
        oDtCostos = dsDatosEmbarque.Tables("COSTOS_EMBARQUE")
        oDtObsCI = dsDatosEmbarque.Tables("OBSSERVACION_CI")
        oDtStatusCI = dsDatosEmbarque.Tables("CHECKPOINT_CI")

        If (dtgSegAduanero.Columns("PRARAN") IsNot Nothing) Then
            If odtMaestroPartidasArancelarias.Rows.Count = 0 Then
                odtMaestroPartidasArancelarias = oEmbarque.Lista_Maestro_Partidas_Arancelarias_Embarque()
            End If
        End If

        ' Dim obeParamCheckPoint As New beCheckPoint
        ' obeParamCheckPoint.PNCCLNT = oEmbarque.pCCLNT
        Dim NameColumnaCalculo As String = ""

        For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
            PNNORSCI = dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value
            oDr = oDt.Select("NORSCI=" & PNNORSCI)
            'oDtObsCI = oEmbarque.Lista_Observacion_CI_X_Embarque(oEmbarque.pCCLNT, PNNORSCI)
            ' obeParamCheckPoint.PNNORSCI = PNNORSCI
            '' oDtStatusCI = oEmbarque.Lista_Status_CI_X_Embarque(obeParamCheckPoint) 'DEMORA
            strCant = ""
            If oDr.Length > 0 Then
                For intCol = 0 To dtgSegAduanero.Columns.Count - 1
                    Select Case dtgSegAduanero.Columns(intCol).Name
                        Case "CODTPN"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_TPN(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "TPN"
                        Case "PARARN"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Partidas_Arancelarias(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Partida Arancelaria"
                        Case "TPAGME"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Forma_Pago(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Forma de Pago"
                        Case "TIPENT"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Tipo_Entrega(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Forma de Entrega"
                        Case "TDITES"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TOBERV"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Descripción Mercaderia"
                        Case "NREFCL"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Referencia_Cliente_SegunOC(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Referencia Cliente según OC"
                        Case "FORCML"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_FECHA_OC(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Orden Compra"
                        Case "TTINTC"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_ICOTERM(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Icoterm"
                        Case "TPRVCL"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TPRVCL"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Proveedor"
                        Case "PNNMOS"
                            If oDr(0)("PNNMOS") = 0 Then
                                dtgSegAduanero.Rows(intCont).Cells(intCol).Value = ""
                            Else
                                dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0)("PNNMOS").ToString.Trim
                            End If
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Orden Servicio"
                        Case "QVOLMR"
                            If oDr(0).Item("QVOLMR").ToString.Trim <> vbNullString Then
                                dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0)("QVOLMR")
                            End If
                        Case "TCARGA"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.TipoCargaDesc_X_Embarque(oListTipoCarga, oDtDato, PNNORSCI, strCant)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Tipo Carga"
                        Case "NBLTAR"
                            If oDr(0).Item("NBLTAR").ToString.Trim <> vbNullString Then
                                dtgSegAduanero.Rows(intCont).Cells(intCol).Value = strCant
                            End If
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Bultos/Cnt"
                        Case "QPSOAR"
                            If oDr(0).Item("QPSOAR").ToString.Trim <> vbNullString Then
                                dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0).Item("QPSOAR")
                            End If
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Kg.Brutos"
                        Case "NDIALB"
                            If oDr(0).Item("NDIALB").ToString.Trim <> vbNullString Then
                                dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0)("NDIALB")
                            End If
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Días Libres"
                        Case "NDIASE"
                            If oDr(0).Item("NDIASE").ToString.Trim <> vbNullString Then
                                dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0)("NDIASE")
                            End If
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "SobreEstadía"

                        Case "EXW"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTEXW", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "EXW"

                        Case "GFOB"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GFOB", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "GFOB"
                        Case "FOB"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "FOB", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "FOB"
                        Case "FLETE"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "FLETE", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "FLETE"
                        Case "SEGURO"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "SEGURO", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "SEGURO"
                        Case "CIF"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "CIF", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "CIF"
                        Case "ADVALOREM"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ADVALO", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "ADVALOREM"
                        Case "IGV"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IGV", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "IGV"
                        Case "IPM"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IPM", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "IPM"
                        Case "TOTALDER"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "TOLDER", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "TOTAL DERECHOS"

                        Case "ITTGOA"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTGOA", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "GASTOS OPERATIVOS"

                        Case "NUMFAC"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Llenar_Factura(oDtFac, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Facturas"
                        Case "CAGNCR"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNMAGC"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Agente de Carga"
                        Case "CTRMAL"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TTRMAL"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Terminal de Almacenamiento"

                        Case "REGIMEN"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("REGIMEN"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "REGIMEN"
                        Case "DESPACHO"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.DespachoDesc_X_Embarque(oListDespacho, oDtDato, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Despacho"

                        Case "DOCEMB"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Doc_Emb(oDtFac, PNNORSCI)
                        Case "CMEDTR"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNMMDT"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Medio Transporte"
                        Case "NUMDUA"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNRODU"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Número Dua"
                        Case "CANAL"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TCANAL"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Canal"
                        Case "TNIMCIN"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNIMCIN"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Línea Naviera"
                        Case "CVPRCN"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TCMPVP"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Nave/Cia. Transporte"
                        Case "CPRTOE"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TCMPPS"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Origen"
                        Case "CPRTOA"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TCMPR1"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Destino"
                        Case "FACCOP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Factura_Copia(oDtFac, PNNORSCI)
                        Case "FACORG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Factura_Original(oDtFac, PNNORSCI)
                        Case "DEMCOP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_DocEmbarque_Copia(oDtFac, PNNORSCI)
                        Case "DEMORG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_DocEmbarque_Original(oDtFac, PNNORSCI)
                        Case "TRACOP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Traduccion_Copia(oDtFac, PNNORSCI)
                        Case "TRAORG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Traduccion_Original(oDtFac, PNNORSCI)
                        Case "VOLCOP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Volante_Copia(oDtFac, PNNORSCI)
                        Case "VOLORG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Volante_Original(oDtFac, PNNORSCI)
                        Case "SEGCOP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Seguro_Copia(oDtFac, PNNORSCI)
                        Case "SEGORG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Seguro_Original(oDtFac, PNNORSCI)
                        Case "CORCOP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Certificado_Origen_Copia(oDtFac, PNNORSCI)
                        Case "CORORG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Certificado_Origen_Original(oDtFac, PNNORSCI)
                        Case "OTRORG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Otro_Documento_Original(oDtFac, PNNORSCI)
                        Case "FECDCP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Doc_Completos(oDtStatus, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "F. Documentos Completos"
                        Case "FECNUM"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Numeracion(oDtStatus, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Numeración"
                        Case "FECPGD"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Pago_Derechos(oDtStatus, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Pago Derechos"
                        Case "FECLEV"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Levante(oDtStatus, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Levante"
                        Case "FECALM"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Entrega_Alm_Cliente(oDtStatus, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Entrega Almacén"
                        Case "FECPRO"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Proforma(oDtStatus, PNNORSCI)
                        Case "FECPGP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Pago_Proforma(oDtStatus, PNNORSCI)
                        Case "NUMSEG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Seguro(oDtFac, PNNORSCI)
                            '*************************VISUALIZACION OBSERVACIONES
                        Case "TOBERV" 'observaciones carga intern. y embarque no diferenciado
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Observaciones_NoDiferenciado(oDtObsCI, oDtObs, PNNORSCI)
                        Case "TOBERVDIF"  'observaciones carga intern. y embarque  diferenciado
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Observaciones_Diferenciado(oDtObsCI, oDtObs, PNNORSCI)
                        Case "TOBERVEMB"  'observaciones solo embarque
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Observaciones_Embarque(oDtObs, PNNORSCI)
                            '************************************
                        Case "PROFOR"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Proforma(oDtDato, PNNORSCI)
                        Case "DOCPEN"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Doc_Pendiente(oDtDato, PNNORSCI)
                        Case "CKCLPV"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_EntregaProv(oDtStatusCI, PNNORSCI)
                        Case "CKRECO"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_RecojoMaterial(oDtStatusCI, PNNORSCI)
                        Case "CKIGAT"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Llegada_Material_Al_Emb(oDtStatusCI, PNNORSCI)
                        Case "CKAECL"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_AprobacionDocs(oDtStatusCI, PNNORSCI)
                        Case "CHKEPR"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_EntregaOrigen(oDtStatusCI, PNNORSCI)
                        Case "CTRSPT"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0)("TCMTRT")
                        Case "ALMDES"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.AlmacenDestinoLocalDesc_X_Embarque(oListAlmacenDestinoLocal, oDtDato, PNNORSCI, oEmbarque.pCCLNT)
                        Case "SESTRG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0)("SESTRG")
                        Case "SESTRG_ESTADO"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0)("SESTRG_ESTADO")

                            'ADICIONADOS PARA GYM
                            '*****************************************************************************************************
                        Case "NREFCLEMB"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("NREFCL"))
                        Case "ITTCAG"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTCAG", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "COMISIÓN AGENCIAMIENTO"
                        Case "OTSGAS"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "OTSGAS", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "TASA DESPACHO"
                        Case "SUMIPM"
                            IGV = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IGV", oDtCostos)
                            IPM = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IPM", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = IGV + IPM
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "IGV+IPM"
                        Case "ITTCEM"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTCEM", oDtCostos)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "CARGO EMBARCADOR"
                        Case "RECPOP"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.BuscarFechaEntregaOC(oDtStatusCI, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Entrega de la OC"
                        Case "CHKETA"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.FechaNum_a_Fecha(oDr(0).Item("FAPRAR"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "ETA"
                        Case "CHKETD"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.FechaNum_a_Fecha(oDr(0).Item("FAPREV"))
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "ETD"
                        Case "FAPRAR"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.BuscarFechaEmbarque(oDtStatusCI, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha de Llegada"
                        Case "FAPREV"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.BuscarFechaLlegada(oDtStatusCI, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha de Embarque"
                        Case "MNTDLR"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Total_Orden_Embarcada_X_Embarque_Equiv_Dolares(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Monto OC en Moneda Origen Eq Dolares"
                        Case "MNTITM"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Total_Orden_Embarcada_X_Embarque_Origen(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Monto OC en Moneda Origen"
                        Case "PRARAN" ' % ARANCEL
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Porcentajes_Arancel_X_Embarque(odtMaestroPartidasArancelarias, odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "% Arancel"
                        Case "REFDO1"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0).Item("REFDO1"))
                        Case "CMEDTRAGEN"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.BuscarMedioTransporteAgencia(odtTransporteForol, oDr(0).Item("TRANSPORTE_AGENCIA"))
                            '------adicionado para 6318 cliente
                        Case "TCITCLOC" 'Codigo Item
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_OC_CODITEM)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Código Item"
                        Case "QCNTITOC" 'Cantidad segun OC
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_QITEM_SEGUNOC)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Cantidad según OC"
                        Case "QRLCSCEMB" 'Cantidad Embarcada
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_QITEM_EMBARCADO)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Cantidad Embarcada"
                        Case "NRITOCS"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_OC_NUMITEM)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Número Item"
                            '//////// adicion
                        Case "MONEDA"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Buscar_Moneda_OC(odtItemEmbarcados, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Moneda"
                        Case "FECFAC"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Entrega_Factura(oDtStatus, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Entrega Factura"
                        Case "NOREMB"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oDr(0).Item("NOREMB")
                        Case "FCDCOR"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Volante(oDtStatus, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Volante"
                        Case "CKCROK"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_CargaOK(oDtStatusCI, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Carga OK"
                        Case "CKCRDS"
                            dtgSegAduanero.Rows(intCont).Cells(intCol).Value = oFnAduanas.Fecha_Carga_Discrepancia(oDtStatusCI, PNNORSCI)
                            dtgSegAduanero.Rows(intCont).Cells(intCol).ToolTipText = "Fecha Carga en Discrepancia"
                    End Select
                Next intCol

                '***
                ActualizarDiferencia_Numeracion_Vs_DocCompleto(intCont)
                ActualizarDiferencia_FecAt_Vs_PagoDer(intCont)
                'ADICIONADOS PARA GYM
                '*****************************************************************************************************
                ActualizarDiferencia_Embarque_VS_Llegada(intCont)
                ActualizarDiferencia_LLegada_VS_Levante(intCont)
                ActualizarDiferencia_Levante_VS_Almacen(intCont)
                ActualizarDiferencia_EntregaOC_VS_EntregaPorProveedor(intCont)
                ActualizarPor100_TotalDerechos_VS_MontoEquivDolares(intCont)
                '*****************************************************************************************************
                '*************************************************************************************************
                ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(intCont)
                ActualizarDiferencia_DocumentosCompletos_VS_ETA(intCont)
                ActualizarDiferencia_Numeracion_VS_PagoDerecho(intCont)
            End If
        Next intCont
        HelpUtil.ClearMemory()
    End Sub

#Region "Funciones Consulta"
    Private Function ExistAllColumGridSegAduanero(ByVal ParamArray NameColumnas()) As Boolean
        Dim existeColumnas As Boolean = False
        Dim Col As Int32 = 0
        For Col = 0 To NameColumnas.Length - 1
            If dtgSegAduanero.Columns(NameColumnas(Col)) IsNot Nothing Then
                existeColumnas = True
            Else
                existeColumnas = False
                Exit For
            End If
        Next
        Return existeColumnas
    End Function
    Private Function ExistAllValueGridSegAduanero(ByVal ParamArray NameColumnas()) As Boolean
        Dim existeColumnas As Boolean = False
        Dim Col As Int32 = 0
        Dim Fila As Int32 = 0
        If NameColumnas.Length > 0 Then
            Fila = NameColumnas(0) 'Primer parametro es la Fila de registro que se requiere verificar
            ' por tanto las comparaciones seran a partir de la segunda columna
            For Col = 1 To NameColumnas.Length - 1
                If dtgSegAduanero.Rows(Fila).Cells(NameColumnas(Col)).Value IsNot Nothing Then
                    existeColumnas = True
                Else
                    existeColumnas = False
                    Exit For
                End If
            Next
        End If
        Return existeColumnas
    End Function

    Private Function Existo(ByVal lis As List(Of String)) As Boolean
        Return True
    End Function


    Private Sub ActualizarDiferencia_FecAt_Vs_PagoDer(ByVal FILA As Int32)
        'If (Me.dtgSegAduanero.Columns.Item("DIFPDA") IsNot Nothing) AndAlso (Me.dtgSegAduanero.Columns.Item("FECALM") IsNot Nothing) AndAlso (Me.dtgSegAduanero.Columns.Item("FECPGD") IsNot Nothing) Then
        '    If dtgSegAduanero.Rows(FILA).Cells("FECALM").Value IsNot Nothing AndAlso dtgSegAduanero.Rows(FILA).Cells("FECPGD").Value IsNot Nothing Then
        '        Calcular_FecAt_Vs_PagoDer(dtgSegAduanero.Rows(FILA).Cells("FECPGD").Value.ToString.Trim, dtgSegAduanero.Rows(FILA).Cells("FECALM").Value.ToString.Trim, FILA)
        '    End If
        'End If
        If (Me.dtgSegAduanero.Columns.Item("DIFPDA") IsNot Nothing) AndAlso (Me.dtgSegAduanero.Columns.Item("FECALM") IsNot Nothing) AndAlso (Me.dtgSegAduanero.Columns.Item("FECPGD") IsNot Nothing) Then
            If dtgSegAduanero.Rows(FILA).Cells("FECALM").Value IsNot Nothing AndAlso dtgSegAduanero.Rows(FILA).Cells("FECPGD").Value IsNot Nothing Then
                Calcular_FecAt_Vs_PagoDer(dtgSegAduanero.Rows(FILA).Cells("FECPGD").Value.ToString.Trim, dtgSegAduanero.Rows(FILA).Cells("FECALM").Value.ToString.Trim, FILA)
            End If
        End If
    End Sub
    Private Sub ActualizarDiferencia_Numeracion_Vs_DocCompleto(ByVal FILA As Int32)
        If (Me.dtgSegAduanero.Columns.Item("DIFDCN") IsNot Nothing) AndAlso (Me.dtgSegAduanero.Columns.Item("FECNUM") IsNot Nothing) AndAlso (Me.dtgSegAduanero.Columns.Item("FECDCP") IsNot Nothing) Then
            If (dtgSegAduanero.Rows(FILA).Cells("FECNUM").Value IsNot Nothing) AndAlso (dtgSegAduanero.Rows(FILA).Cells("FECDCP").Value IsNot Nothing) Then
                Calcular_Numeracion_Vs_DocCompleto(dtgSegAduanero.Rows(FILA).Cells("FECDCP").Value.ToString.Trim, dtgSegAduanero.Rows(FILA).Cells("FECNUM").Value.ToString.Trim, FILA)
            End If
        End If
    End Sub

    Private Sub ActualizarDiferencia_EntregaOC_VS_EntregaPorProveedor(ByVal FILA As Int32)
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim ExisteColumna As Boolean = False
        Dim CHK_ENTREGAOC_NESTDO_100 As String = ""
        Dim CHK_ENTREGA_X_PROVEEDOR_NESTDO_102 As String = ""
        ExisteColumna = dtgSegAduanero.Columns("DIFRCCK") IsNot Nothing
        If (ExisteColumna = True) Then
            dtgSegAduanero.Rows(FILA).Cells("DIFRCCK").ToolTipText = "ENTREGA OC VS ENTREGA POR EL PROVEEDOR"
            ExisteColumna = dtgSegAduanero.Columns("RECPOP") IsNot Nothing _
                           AndAlso dtgSegAduanero.Columns("CKCLPV") IsNot Nothing
        End If
        If (ExisteColumna) Then
            If (dtgSegAduanero.Rows(FILA).Cells("RECPOP").Value <> vbNullString) Then
                CHK_ENTREGAOC_NESTDO_100 = dtgSegAduanero.Rows(FILA).Cells("RECPOP").Value
            End If
            If (dtgSegAduanero.Rows(FILA).Cells("CKCLPV").Value <> vbNullString) Then
                CHK_ENTREGA_X_PROVEEDOR_NESTDO_102 = dtgSegAduanero.Rows(FILA).Cells("CKCLPV").Value
            End If
            dtgSegAduanero.Rows(FILA).Cells("DIFRCCK").Value = DiferenciaFechas(CHK_ENTREGAOC_NESTDO_100, CHK_ENTREGA_X_PROVEEDOR_NESTDO_102)
        End If
    End Sub

    Private Sub ActualizarPor100_TotalDerechos_VS_MontoEquivDolares(ByVal FILA As Int32)
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim ExisteColumna As Boolean = False
        Dim TOTAL_DERECHO As Decimal = 0
        Dim MONTO_OC_EQUIV_DOLAR As Decimal = 0
        Dim POR_GASTOS_NACIONALIZACION As String
        ExisteColumna = dtgSegAduanero.Columns("PORGIM") IsNot Nothing
        If (ExisteColumna = True) Then
            dtgSegAduanero.Rows(FILA).Cells("PORGIM").ToolTipText = "(%)TOTAL DERECHOS/TOTAL OC DOLARES"
            ExisteColumna = dtgSegAduanero.Columns("TOTALDER") IsNot Nothing _
                           AndAlso dtgSegAduanero.Columns("MNTDLR") IsNot Nothing
        End If
        If (ExisteColumna = True) Then
            If (dtgSegAduanero.Rows(FILA).Cells("TOTALDER").Value <> vbNullString) Then
                TOTAL_DERECHO = dtgSegAduanero.Rows(FILA).Cells("TOTALDER").Value
            End If
            If (dtgSegAduanero.Rows(FILA).Cells("MNTDLR").Value <> vbNullString) Then
                MONTO_OC_EQUIV_DOLAR = dtgSegAduanero.Rows(FILA).Cells("MNTDLR").Value
            End If
            If (MONTO_OC_EQUIV_DOLAR = 0) Then
                POR_GASTOS_NACIONALIZACION = ""
            Else
                POR_GASTOS_NACIONALIZACION = Math.Round((TOTAL_DERECHO / MONTO_OC_EQUIV_DOLAR) * 100, 2).ToString
            End If
            dtgSegAduanero.Rows(FILA).Cells("PORGIM").Value = POR_GASTOS_NACIONALIZACION
        End If
    End Sub

    Private Sub ActualizarDiferencia_Embarque_VS_Llegada(ByVal FILA As Int32)
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim ExisteColumna As Boolean = False
        Dim CHK_EMBARQUE_NESTDO_107 As String = ""
        Dim CHK_LLEGADA_108 As String = ""
        ExisteColumna = dtgSegAduanero.Columns("DIFERM") IsNot Nothing
        If (ExisteColumna = True) Then
            dtgSegAduanero.Rows(FILA).Cells("DIFERM").ToolTipText = "EMBARQUE VS LLEGADA"
            ExisteColumna = dtgSegAduanero.Columns("FAPRAR") IsNot Nothing _
                           AndAlso dtgSegAduanero.Columns("FAPREV") IsNot Nothing
        End If
        If (ExisteColumna) Then
            If (dtgSegAduanero.Rows(FILA).Cells("FAPRAR").Value <> vbNullString) Then
                CHK_EMBARQUE_NESTDO_107 = dtgSegAduanero.Rows(FILA).Cells("FAPRAR").Value
            End If
            If (dtgSegAduanero.Rows(FILA).Cells("FAPREV").Value <> vbNullString) Then
                CHK_LLEGADA_108 = dtgSegAduanero.Rows(FILA).Cells("FAPREV").Value
            End If
            dtgSegAduanero.Rows(FILA).Cells("DIFERM").Value = DiferenciaFechas(CHK_EMBARQUE_NESTDO_107, CHK_LLEGADA_108)
        End If
    End Sub
    Private Sub ActualizarDiferencia_LLegada_VS_Levante(ByVal FILA As Int32)
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim CHK_LLEGADA_108 As String = ""
        Dim CHK_LEVANTE_123 As String = ""
        Dim ExisteColumna As Boolean = dtgSegAduanero.Columns("DIFEME") IsNot Nothing
        If (ExisteColumna = True) Then
            ExisteColumna = dtgSegAduanero.Columns("FAPREV") IsNot Nothing _
                           AndAlso dtgSegAduanero.Columns("FECLEV") IsNot Nothing
        End If
        If (ExisteColumna = True) Then
            If (dtgSegAduanero.Rows(FILA).Cells("FAPREV").Value <> vbNullString) Then
                CHK_LLEGADA_108 = dtgSegAduanero.Rows(FILA).Cells("FAPREV").Value
            End If
            If (dtgSegAduanero.Rows(FILA).Cells("FECLEV").Value <> vbNullString) Then
                CHK_LEVANTE_123 = dtgSegAduanero.Rows(FILA).Cells("FECLEV").Value
            End If
            dtgSegAduanero.Rows(FILA).Cells("DIFEME").Value = DiferenciaFechas(CHK_LLEGADA_108, CHK_LEVANTE_123)
            dtgSegAduanero.Rows(FILA).Cells("DIFEME").ToolTipText = "LLEGADA VS LEVANTE"
        End If

    End Sub
    Private Sub ActualizarDiferencia_Levante_VS_Almacen(ByVal FILA As Int32)
        Dim CHK_ALMACEN_124 As String = ""
        Dim CHK_LEVANTE_123 As String = ""
        Dim ExisteColumna As Boolean = dtgSegAduanero.Columns("DIFEEP") IsNot Nothing
        If (ExisteColumna = True) Then
            ExisteColumna = dtgSegAduanero.Columns("FECLEV") IsNot Nothing _
                           AndAlso dtgSegAduanero.Columns("FECALM") IsNot Nothing
        End If
        If (ExisteColumna) Then
            If (dtgSegAduanero.Rows(FILA).Cells("FECALM").Value <> vbNullString) Then
                CHK_ALMACEN_124 = dtgSegAduanero.Rows(FILA).Cells("FECALM").Value
            End If
            If (dtgSegAduanero.Rows(FILA).Cells("FECLEV").Value <> vbNullString) Then
                CHK_LEVANTE_123 = dtgSegAduanero.Rows(FILA).Cells("FECLEV").Value
            End If
            dtgSegAduanero.Rows(FILA).Cells("DIFEEP").Value = DiferenciaFechas(CHK_LEVANTE_123, CHK_ALMACEN_124)
            dtgSegAduanero.Rows(FILA).Cells("DIFEEP").ToolTipText = "LEVANTE VS ALMACEN"
        End If
    End Sub

    Private Function DiferenciaFechas(ByVal FechaMenor As String, ByVal FechaMayor As String) As String
        Dim DifReferencia As String = ""
        Dim FechaMin As Date
        Dim FechaMax As Date
        If (Date.TryParse(FechaMenor, FechaMin) AndAlso Date.TryParse(FechaMayor, FechaMax)) Then
            DifReferencia = DateDiff(DateInterval.Day, FechaMin, FechaMax)
        End If
        Return DifReferencia
    End Function


    Private Sub ActualizarDiferencia_Numeracion_VS_PagoDerecho(ByVal Fila As Int32)
        Dim EvaluaValor As Boolean = False
        EvaluaValor = (dtgSegAduanero.Columns("DXF6F5") IsNot Nothing)
        If EvaluaValor Then
            EvaluaValor = (Me.dtgSegAduanero.Columns.Item("FECPGD") IsNot Nothing) And (Me.dtgSegAduanero.Columns.Item("FECNUM") IsNot Nothing)
            If EvaluaValor Then
                EvaluaValor = (dtgSegAduanero.Rows(Fila).Cells("FECPGD").Value IsNot Nothing) And (dtgSegAduanero.Rows(Fila).Cells("FECNUM").Value IsNot Nothing)
                If EvaluaValor Then
                    Calcular_Numeracion_Vs_PagoDerechos(dtgSegAduanero.Rows(Fila).Cells("FECNUM").Value.ToString.Trim, dtgSegAduanero.Rows(Fila).Cells("FECPGD").Value.ToString.Trim, Fila)
                End If
            End If
        End If
    End Sub

    Private Sub ActualizarDiferencia_DocumentosCompletos_VS_ETA(ByVal Fila As Int32)
        Dim EvaluaValor As Boolean = False
        EvaluaValor = dtgSegAduanero.Columns("DXF4F3") IsNot Nothing
        If (EvaluaValor) Then
            EvaluaValor = (Me.dtgSegAduanero.Columns.Item("FECDCP") IsNot Nothing) And (Me.dtgSegAduanero.Columns.Item("CHKETA") IsNot Nothing)
            If EvaluaValor Then
                EvaluaValor = (dtgSegAduanero.Rows(Fila).Cells("FECDCP").Value IsNot Nothing) And (dtgSegAduanero.Rows(Fila).Cells("CHKETA").Value IsNot Nothing)
                If EvaluaValor Then
                    Calcular_DocumentosCompletos_Vs_ETA(dtgSegAduanero.Rows(Fila).Cells("CHKETA").Value.ToString.Trim, dtgSegAduanero.Rows(Fila).Cells("FECDCP").Value.ToString.Trim, Fila)
                End If
            End If
        End If
    End Sub

    Private Sub ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(ByVal Fila As Int32)
        Dim EvaluaValor As Boolean = False
        EvaluaValor = dtgSegAduanero.Columns("DXF8F4") IsNot Nothing
        If (EvaluaValor) Then
            EvaluaValor = (Me.dtgSegAduanero.Columns.Item("FECALM") IsNot Nothing) And (Me.dtgSegAduanero.Columns.Item("FECDCP") IsNot Nothing)
            If EvaluaValor Then
                EvaluaValor = (dtgSegAduanero.Rows(Fila).Cells("FECALM").Value IsNot Nothing) And (dtgSegAduanero.Rows(Fila).Cells("FECDCP").Value IsNot Nothing)
                If EvaluaValor Then
                    Calcular_FecAlmacen_Vs_DocumentosCompletos(dtgSegAduanero.Rows(Fila).Cells("FECDCP").Value.ToString.Trim, dtgSegAduanero.Rows(Fila).Cells("FECALM").Value.ToString.Trim, Fila)
                End If
            End If
        End If
    End Sub

    Private Sub OrdenFechas(ByRef pstrFecIni As String, ByRef pstrFecFin As String)
        Dim Fecha1 As Decimal = 0
        Dim Fecha2 As Decimal = 0
        Dim FecIni As String = pstrFecIni
        Dim FecFin As String = pstrFecFin
        Fecha1 = Format(CType(pstrFecIni, Date), "yyyyMMdd")
        Fecha2 = Format(CType(pstrFecFin, Date), "yyyyMMdd")
        If (Fecha1 > Fecha2) Then
            pstrFecIni = FecFin
            pstrFecFin = FecIni
        End If
    End Sub

    Private Sub Calcular_FecAlmacen_Vs_DocumentosCompletos(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer
        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            OrdenFechas(pstrFecIni, pstrFecFin)
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            Me.dtgSegAduanero.Rows(pintRow).Cells("DXF8F4").Value = lintDias
        End If
    End Sub
    Private Sub Calcular_DocumentosCompletos_Vs_ETA(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            OrdenFechas(pstrFecIni, pstrFecFin)
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            Me.dtgSegAduanero.Rows(pintRow).Cells("DXF4F3").Value = lintDias
        End If
    End Sub
    Private Sub Calcular_Numeracion_Vs_PagoDerechos(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            OrdenFechas(pstrFecIni, pstrFecFin)
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            Me.dtgSegAduanero.Rows(pintRow).Cells("DXF6F5").Value = lintDias
        End If
    End Sub

#End Region


#End Region

#Region "Limpiar Información"

    Private Sub Limpiar_Informacion()

        Me.dtgDocumentos.Rows.Clear()
        If oDtCiaTran IsNot Nothing Then
            oDtCiaTran.Rows.Clear()
        End If
        Me.ctbCiaTransp.Limpiar()
        cmbPaisOrg.SelectedValue = -1D
        cmbPaisDest.SelectedValue = -1D

        cmbPaisOrg_SelectionChangeCommitted(cmbPaisOrg, Nothing)
        cmbPaisDest_SelectionChangeCommitted(cmbPaisDest, Nothing)

        Me.ctbNave.Limpiar()
        Limpiar_Documentos_Forol()
        Limpiar_Datos_Embarque()
        Me.dtgCarga.Rows.Clear()

        Limpiar_Carta_Fianza()
        Limpiar_Apertura_OS()
        Me.dtgObservaciones.Rows.Clear()
        dtgObsCargaInternacional.DataSource = Nothing
        Me.dtgServicios.DataSource = Nothing
        Me.dtgCheckPoint.Rows.Clear()
        Limpiar_Documentos_Adjuntos()
        Limpiar_Costos_Totales_X_Embarque()
        If oTab IsNot Nothing Then
            oTab.Limpiar()
        End If
        gvOrdenesEmb.DataSource = Nothing
    End Sub

    Private Sub Limpiar_Carta_Fianza()
        Me.txtPolizaNum.Clear()
        Me.txtPolizaMonto.Clear()
        Me.cmbPolizaBanco.SelectedValue = 0
        Me.cmbPolizaMoneda.SelectedValue = 100
        Me.mskPolizaFecEmi.Text = "  /  /    "
        Me.mskPolizaFecVen.Text = "  /  /    "
    End Sub

    Private Sub Limpiar_Apertura_OS()

        Me.cmbZona.SelectedValue = 1
        cmbTipoDespachos.SelectedValue = -1D
        Me.txtNroOS.Clear()
        Me.txtNroOC.Clear()
        Me.txtRefDoc.Clear()
        txtRefCli.Clear()
        Me.txtMercaderia.Clear()

        Me.txtTransTercero.Text = "LINO SALVATIERRA NEXTEL 426*2685"
        Me.txtTransTercero.Visible = False
        Me.cmbTransporte.SelectedValue = -1D
        Me.txtBeneficio.Clear()
        Me.txtDireccion.Text = "RANSA SAN AGUSTIN"
        Me.txtHorario.Text = "8:00 a.m. A 5:00 p.m."
        Me.txtContacto.Clear()
        Me.txtObservacion.Clear()

        mskEmbarque.Text = Now
        mskApertura.Text = "  /  /    "

        ctbTerminal.Limpiar()
        UcProveedor_tab.pClear()
        txtDUA.Text = ""
        cboCanal.SelectedValue = "-1"
        cboRegimen.SelectedValue = -1D

        mskFVencRegimen.Text = "  /  /    "

    End Sub


    Private Sub Limpiar_Datos_Embarque()

        Me.mskETD.Clear()
        Me.mskETD.Tag = ""
        Me.mskETA.Clear()
        Me.txtNumDocEmb.Clear()
        Me.txtNumEmbarcador.Clear()
        Me.txtEmbarqueMan.Clear()
        Me.txtEstado.Clear()
        Me.ctbAgenteDeCarga.Limpiar()
        ctbMedioTransportes.SelectedValue = -1D

        txtKg.Clear()
        txtSobreEstadia.Clear()
        txtDiaLibre.Clear()
        txtM3.Clear()

    End Sub

    Private Sub Limpiar_Documentos_Forol()
        Dim intCont As Integer

        For intCont = 0 To Me.dtgDocAdjuntos.Rows.Count - 1
            Me.dtgDocAdjuntos.Rows(intCont).Cells("FLGORG").Value = ""
            Me.dtgDocAdjuntos.Rows(intCont).Cells("FLGCOP").Value = ""
            Me.dtgDocAdjuntos.Rows(intCont).Cells("NUMDOC").Value = ""
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
                    'oEmbarque.Datos_Embarque_VB(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                    Llenar_Datos_Embarque() 'Apertura O/S y Datos de Embarque
                    Llenar_Documentos_Forol() 'Apertura O/S
                Case 2 'Documentos Adjuntos
                    Llenar_Documentos_Embarque() 'Documentos Adjuntos
                Case 3 'Datos de Embarque
                    'If Not oTab.Tab_Cargado(2) Then
                    If Not oTab.Tab_Cargado(3) Then
                        oEmbarque.Datos_Embarque_VB(oEmbarque.pCCLNT, oEmbarque.pNORSCI) 'Apertura O/S y Datos de Embarque
                    End If
                    'oEmbarque.Datos_Embarque_VB(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
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

    Private Sub Llenar_Paises()

        Dim oCloneList As New CloneObject(Of bePais)
        Dim oListPaisOrigen As New List(Of bePais)
        Dim obePais As bePais
        Dim oListPaisDestino As New List(Of bePais)

        oListPaisOrigen = oCloneList.CloneListObject(oListGenPais)
        obePais = New bePais
        obePais.PNCPAIS = -1
        obePais.PSTCMPPS = "::Seleccione::"
        oListPaisOrigen.Insert(0, obePais)

        oListPaisDestino = oCloneList.CloneListObject(oListGenPais)
        obePais = New bePais
        obePais.PNCPAIS = -1
        obePais.PSTCMPPS = "::Seleccione::"
        oListPaisDestino.Insert(0, obePais)

        Me.cmbPaisOrg.DataSource = oListPaisOrigen
        Me.cmbPaisOrg.ValueMember = "PNCPAIS"
        Me.cmbPaisOrg.DisplayMember = "PSTCMPPS"
        Me.cmbPaisOrg.SelectedValue = -1D


        cmbPaisOrg_SelectionChangeCommitted(cmbPaisOrg, Nothing)



        Me.cmbPaisDest.DataSource = oListPaisDestino
        Me.cmbPaisDest.ValueMember = "PNCPAIS"
        Me.cmbPaisDest.DisplayMember = "PSTCMPPS"
        Me.cmbPaisDest.SelectedValue = 589D

        cmbPaisDest_SelectionChangeCommitted(cmbPaisDest, Nothing)


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
        Dim PNNORSCI As Decimal = 0
        Dim obrEmbarque As New clsEmbarque
        obrEmbarque.pCCLNT = oEmbarque.pCCLNT
        dtgObsCargaInternacional.DataSource = Nothing
        PNNORSCI = oEmbarque.pNORSCI
        odtObsCI = oEmbarque.Lista_Observacion_CI_X_Embarque(oEmbarque.pCCLNT, PNNORSCI)
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
            oDrVw.CreateCells(Me.dtgCheckPoint)
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
        Next
    End Sub

    Private Sub Llenar_Carga()
        dtgCarga.Rows.Clear()
        Dim oDrVw As DataGridViewRow
        Dim oListCarga As New List(Of beDetalleCargaInternacional)
        Dim PNNORSCI As Decimal = oEmbarque.pNORSCI
        oListCarga = oEmbarque.Lista_Carga_Embarque(PNNORSCI)
        Dim FILA As Int32 = 0
        Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        For Each ItemCarga As beDetalleCargaInternacional In oListCarga
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgCarga)
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
        Me.dtgObservaciones.Rows.Clear()
        Dim oDrVw As DataGridViewRow
        Dim FILA As Int32 = 0
        Dim PNNORSCI As Decimal = oEmbarque.pNORSCI
        Dim oListObservacion As New List(Of beObservacionCarga)
        oListObservacion = oEmbarque.Lista_Observacion_Embarque(PNNORSCI)
        Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        dtgObservaciones.Columns("DELETE_OBS").Visible = Not IsCerrado
        For Each obeObservacion As beObservacionCarga In oListObservacion
            If (obeObservacion.PSTOBS.Length <> 0) Then
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgObservaciones)
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
        Me.ctbNave.DataSource = oVapor.Lista_Vapor(1)
        Me.ctbNave.ValueMember = "CVPRCN"
        Me.ctbNave.DisplayMember = "TCMPVP"
        Me.ctbNave.DataBind()
    End Sub


    Private Sub Llenar_Datos_Embarque()
        Dim obeDatosEmbarque As New beDatosEmbarque
        Dim oDtDatosCFianza As DataTable
        Dim oCartaFianzaNeg As New clsCartaFianza
        obeDatosEmbarque = oEmbarque.DatosEmbarque
        oDtDatosCFianza = oCartaFianzaNeg.Listar_Datos_Carta_Fianza(oEmbarque.pNORSCI)
        If obeDatosEmbarque IsNot Nothing Then
            Uc_Almacen_Local.CCLNT = oEmbarque.pCCLNT
            uc_Transportista.pObtenerTransportista(obeDatosEmbarque.PNCTRSPT)
            If (obeDatosEmbarque.PNALM_LOCAL > 0) Then
                Uc_Almacen_Local.pObtenerAlmacen(obeDatosEmbarque.PNALM_LOCAL)
            Else
                Uc_Almacen_Local.pClear()
            End If
            txtEmbarqueMan.Text = obeDatosEmbarque.PNNORSCI
            If obeDatosEmbarque.PSCTRMAL.Length > 0 Then
                Me.ctbTerminal.Codigo = obeDatosEmbarque.PSCTRMAL
            Else
                Me.ctbTerminal.Limpiar()
            End If
            If obeDatosEmbarque.PNCAGNCR > 0 Then
                ctbAgenteDeCarga.Codigo = obeDatosEmbarque.PNCAGNCR
            Else
                ctbAgenteDeCarga.Limpiar()
            End If
            txtEstado.Text = obeDatosEmbarque.PSSESTRG_DESC
            Me.txtNroOS.Text = obeDatosEmbarque.PNPNNMOS
            If obeDatosEmbarque.PNCZNFCC > 0 Then
                Me.cmbZona.SelectedValue = obeDatosEmbarque.PNCZNFCC
            End If

            Me.mskApertura.Text = obeDatosEmbarque.PSFCEMSN
            Me.mskEmbarque.Text = obeDatosEmbarque.PSFORSCI

            Me.txtNroOC.Text = obeDatosEmbarque.PSNORCML
            If obeDatosEmbarque.PNCPRVCL > 0 Then
                Me.UcProveedor_tab.pCodigo = obeDatosEmbarque.PNCPRVCL
            Else
                Me.UcProveedor_tab.pClear()
            End If
            Me.txtRefDoc.Text = obeDatosEmbarque.PSREFDO1
            Me.txtRefCli.Text = obeDatosEmbarque.PSNREFCL


            Me.txtNumEmbarcador.Text = obeDatosEmbarque.PSNOREMB
            Me.txtNumDocEmb.Text = obeDatosEmbarque.PSNDOCEM
            Me.txtMercaderia.Text = obeDatosEmbarque.PSTOBERV
            ctbMedioTransportes.SelectedValue = IIf(obeDatosEmbarque.PNCMEDTR <> 0, obeDatosEmbarque.PNCMEDTR, -1D)
            CambioMedioTrasportes()
            If obeDatosEmbarque.PNCCIANV > 0 Then
                Me.ctbCiaTransp.Codigo = obeDatosEmbarque.PNCCIANV
            Else
                ctbCiaTransp.Limpiar()
            End If
            If (obeDatosEmbarque.PSTNMCTT.Length = 0) Then
                obeDatosEmbarque.PSTNMCTT = "LINO SALVATIERRA NEXTEL 426*2685"
            End If
            Me.txtTransTercero.Text = obeDatosEmbarque.PSTNMCTT
            Me.txtBeneficio.Text = obeDatosEmbarque.PSTBFTRB
            Me.txtDireccion.Text = obeDatosEmbarque.PSTDRENT
            Me.txtHorario.Text = obeDatosEmbarque.PSHORATN
            Me.txtContacto.Text = obeDatosEmbarque.PSTPRSCN
            Me.txtObservacion.Text = obeDatosEmbarque.PSTRECOR
            If obeDatosEmbarque.PNCCIANV > 0 Then
                Me.ctbCiaTransp.Codigo = obeDatosEmbarque.PNCCIANV
            Else
                Me.ctbCiaTransp.Limpiar()
            End If
            If (obeDatosEmbarque.PSCVPRCN.Length > 0) Then
                Me.ctbNave.Codigo = obeDatosEmbarque.PSCVPRCN
            Else
                Me.ctbNave.Limpiar()
            End If
            If obeDatosEmbarque.PNCPAIS = 0 Then
                Me.cmbPaisOrg.SelectedValue = -1D
            Else
                Me.cmbPaisOrg.SelectedValue = obeDatosEmbarque.PNCPAIS
            End If
            cmbPaisOrg_SelectionChangeCommitted(cmbPaisOrg, Nothing)
            If obeDatosEmbarque.PSCPRTOE = "" Then
                Me.cmbPuertoOrg.SelectedValue = "-1"
            Else
                Me.cmbPuertoOrg.SelectedValue = obeDatosEmbarque.PSCPRTOE
            End If

            'PNCPAIS_DESTINO

            If obeDatosEmbarque.PNCPAIS_DESTINO = 0 Then
                'cmbPaisDest.SelectedValue = 589D 'PERU
                cmbPaisDest.SelectedValue = -1D
            Else
                cmbPaisDest.SelectedValue = obeDatosEmbarque.PNCPAIS_DESTINO
            End If

            cmbPaisDest_SelectionChangeCommitted(cmbPaisDest, Nothing)
            If obeDatosEmbarque.PSCPRTOA = "" Then
                Me.cmbPuertoDest.SelectedValue = "-1"
            Else
                Me.cmbPuertoDest.SelectedValue = obeDatosEmbarque.PSCPRTOA
            End If


            Me.mskETD.Text = obeDatosEmbarque.PSFAPREV
            Me.mskETA.Text = obeDatosEmbarque.PSFAPRAR

            'If (obeDatosEmbarque.PNNCODRG_REG > 0) Then
            '    cboRegimen.SelectedValue = obeDatosEmbarque.PNNCODRG_REG
            'Else
            '    cboRegimen.SelectedValue = -1D
            'End If

            If (obeDatosEmbarque.PNTPORGE > 0) Then
                cboRegimen.SelectedValue = obeDatosEmbarque.PNTPORGE
            Else
                cboRegimen.SelectedValue = -1D
            End If


            If (obeDatosEmbarque.PSTCANAL.Length > 0) Then
                cboCanal.SelectedValue = obeDatosEmbarque.PSTCANAL
            Else
                cboCanal.SelectedValue = "-1"
            End If
            txtDUA.Text = obeDatosEmbarque.PSTNRODU
            'mskFInicioRegimen.Text = obeDatosEmbarque.PSFECINI_REG
            'mskFVencRegimen.Text = obeDatosEmbarque.PSFECVEN_REG
            mskFVencRegimen.Text = obeDatosEmbarque.PSFTRORS_REG
            txtTipoEmbarque.Text = obeDatosEmbarque.PSTCMTSR
            txtEmbOrigen.Text = obeDatosEmbarque.PNNORSCO_REG
            txtOSOrigen.Text = obeDatosEmbarque.PNPNNMOS_REG


            'obeDatosEmbarque_BE.PSTPSRVA = HelpClass.ToStringCvr(dt.Rows(0)("TPSRVA"))
            'obeDatosEmbarque_BE.PSTCMTSR = String.Format("{0} - {1}", HelpClass.ToStringCvr(dt.Rows(0)("TPSRVA")), HelpClass.ToStringCvr(dt.Rows(0)("TCMTSR")))
            'obeDatosEmbarque_BE.PNNORSCO = dt.Rows(0)("NORSCO")
            'obeDatosEmbarque_BE.PNNMOSO = dt.Rows(0)("PNNMOSO")
            'txtTipoEmbarque.Text = obeDatosEmbarque


            Dim PNREGIMEN As Decimal = 0
            'PNREGIMEN = obeDatosEmbarque.PNNCODRG_REG
            PNREGIMEN = obeDatosEmbarque.PNTPORGE

            txtM3.Text = obeDatosEmbarque.PNQVOLMR
            txtDiaLibre.Text = obeDatosEmbarque.PNNDIALB
            txtSobreEstadia.Text = obeDatosEmbarque.PNNDIASE
            txtKg.Text = obeDatosEmbarque.PNQPSOAR


            If oDtDatosCFianza.Rows.Count > 0 Then
                txtPolizaNum.Text = oDtDatosCFianza.Rows(0).Item("NDOCUM").ToString.Trim
                txtPolizaMonto.Text = Double.Parse(oDtDatosCFianza.Rows(0).Item("ITTDOC")).ToString.Trim
                cmbPolizaBanco.SelectedValue = oDtDatosCFianza.Rows(0).Item("CBNCFN").ToString.Trim
                cmbPolizaMoneda.SelectedValue = oDtDatosCFianza.Rows(0).Item("CMNDA1").ToString.Trim
                mskPolizaFecEmi.Text = oDtDatosCFianza.Rows(0).Item("FECEDC").ToString.Trim
                mskPolizaFecVen.Text = oDtDatosCFianza.Rows(0).Item("FECVEN").ToString.Trim
            End If
            Me.gbxFianza.Visible = IsRegimenTemporal(PNREGIMEN)


            cboRegimen_SelectionChangeCommitted(cboRegimen, Nothing)

            If obeDatosEmbarque.PNTRANSPORTE = 0 Then
                Me.cmbTransporte.SelectedValue = -1D
            Else
                Me.cmbTransporte.SelectedValue = obeDatosEmbarque.PNTRANSPORTE
                If obeDatosEmbarque.PSTERCERO = "TERCEROS" Then
                    Me.txtTransTercero.Visible = True
                Else
                    Me.txtTransTercero.Visible = False
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

    Private Function IsRegimenTemporal(ByVal PNREGIMEN As Decimal)
        Dim isTemporal As Boolean = False
        If PNREGIMEN = 2 OrElse PNREGIMEN = 5 OrElse PNREGIMEN = 15 OrElse PNREGIMEN = 18 Then
            isTemporal = True
        Else
            isTemporal = False
        End If
        Return isTemporal
    End Function

    Private Sub Llenar_Documentos_Forol()
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim intContY As Integer

        oDt = oDocApertura.Lista_Doc_Forol(dblEmbSelec)
        For intCont = 0 To oDt.Rows.Count - 1
            For intContY = 0 To Me.dtgDocAdjuntos.Rows.Count - 1
                If Me.dtgDocAdjuntos.Rows(intContY).Cells("NCODRG").Value.ToString.Trim = oDt.Rows(intCont).Item("NCODRG").ToString.Trim Then
                    If oDt.Rows(intCont).Item("SORDOC").ToString.Trim = "O" Then
                        Me.dtgDocAdjuntos.Rows(intContY).Cells("FLGORG").Value = "X"
                    Else
                        Me.dtgDocAdjuntos.Rows(intContY).Cells("FLGCOP").Value = "X"
                    End If
                    Me.dtgDocAdjuntos.Rows(intContY).Cells("NUMDOC").Value = oDt.Rows(intCont).Item("QCANTI").ToString.Trim
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
        Me.dtgDocumentos.Rows.Clear()
        Dim Fila As Int32 = 0
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        Dim oLitstbeDocCargaInternacional_BE As New List(Of beDocCargaInternacional)
        Dim obeItemDocCarga As beDocCargaInternacional
        Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        oLitstbeDocCargaInternacional_BE = oDocApertura.Lista_Doc_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
        For intCont = 0 To oLitstbeDocCargaInternacional_BE.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgDocumentos)
            'ADICION HABILITAR X ESTADO**************************************
            oDrVw.ReadOnly = IsCerrado
            '****************************************************************
            Me.dtgDocumentos.Rows.Add(oDrVw)
            Fila = dtgDocumentos.Rows.Count - 1
            obeItemDocCarga = oLitstbeDocCargaInternacional_BE(intCont)

            dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value = obeItemDocCarga.PNNDOCIN.ToString
            dtgDocumentos.Rows(Fila).Cells("TDOCIN").ReadOnly = True
            dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value = obeItemDocCarga.PSNDOCLI
            dtgDocumentos.Rows(Fila).Cells("OC").Value = obeItemDocCarga.PSNORCML
            dtgDocumentos.Rows(Fila).Cells("DOCADJUN_NRPARC").Value = obeItemDocCarga.PNNRPARC

            If obeItemDocCarga.PNIVFOBD > 0 Then
                dtgDocumentos.Rows(Fila).Cells("FOB").Value = obeItemDocCarga.PNIVFOBD
            End If
            dtgDocumentos.Rows(Fila).Cells("FECORG").Value = obeItemDocCarga.PSFCDCOR
            dtgDocumentos.Rows(Fila).Cells("FECCOP").Value = obeItemDocCarga.PSFCDCCP
            If obeItemDocCarga.PSTNMBAR.Length > 0 Then
                dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.Archivo
            Else
                dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            End If
            dtgDocumentos.Rows(Fila).Cells("UPLOAT").Value = "..."
            dtgDocumentos.Rows(Fila).Cells("URLARC").Value = obeItemDocCarga.PSURLARC
            dtgDocumentos.Rows(Fila).Cells("TNMBAR").Value = obeItemDocCarga.PSTNMBAR
            dtgDocumentos.Rows(Fila).Cells("NORSCI_ADJ").Value = obeItemDocCarga.PNNORSCI
            dtgDocumentos.Rows(Fila).Cells("NCRRDC").Value = obeItemDocCarga.PNNCRRDC
            dtgDocumentos.Rows(Fila).Cells("SECSUS").Value = obeItemDocCarga.PNSECSUS

            dtgDocumentos.Rows(Fila).Cells("EXISTS_DOCADJ").Value = obeItemDocCarga.PNEXISTS

            'End If
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
        oDrCol = Me.oDsSegAdu.Tables("oDtCiaTransporte").Select("SMETRA=" & PdblMedio & " AND SESTRG<>'*'")
        For intCont = 0 To oDrCol.Length - 1
            oDr = oDtCiaTran.NewRow
            oDr.Item("CCIANV") = oDrCol(intCont).Item("CCIANV")
            oDr.Item("TNMCIN") = oDrCol(intCont).Item("TNMCIN")
            oDtCiaTran.Rows.Add(oDr)
        Next intCont
        Me.ctbCiaTransp.DataSource = oDtCiaTran.Copy
        Me.ctbCiaTransp.ValueMember = "CCIANV"
        Me.ctbCiaTransp.DisplayMember = "TNMCIN"
        Me.ctbCiaTransp.DataBind()
    End Sub


    Private Sub Filtrar_Puerto_Org(ByVal oListPuerto As List(Of bePuerto), ByVal CPAIS As Decimal)
        Dim oFNEmbarque As New Negocio.clsEmbarqueAduanas
        Dim oListPuertoFind As New List(Of bePuerto)
        If CPAIS <> -1 Then
            oListPuertoFind = oFNEmbarque.Puerto_x_Pais(oListPuerto, CPAIS)
        End If
        Dim obePuerto As New bePuerto
        obePuerto.PSCPRTOR = "-1"
        obePuerto.PSTCMPR1 = "::Seleccione::"
        oListPuertoFind.Insert(0, obePuerto)


        Me.cmbPuertoOrg.DataSource = oListPuertoFind
        Me.cmbPuertoOrg.DisplayMember = "PSTCMPR1"
        Me.cmbPuertoOrg.ValueMember = "PSCPRTOR"
        cmbPuertoOrg.SelectedValue = "-1"


    End Sub


    Private Sub Filtrar_Puerto_Dest(ByVal oListPuerto As List(Of bePuerto), ByVal CPAIS As Decimal)
        Dim oFNEmbarque As New Negocio.clsEmbarqueAduanas
        Dim oListPuertoFind As New List(Of bePuerto)
        If CPAIS <> -1 Then
            oListPuertoFind = oFNEmbarque.Puerto_x_Pais(oListPuerto, CPAIS)
        End If
        Dim obePuerto As New bePuerto
        obePuerto.PSCPRTOR = "-1"
        obePuerto.PSTCMPR1 = "::Seleccione::"
        oListPuertoFind.Insert(0, obePuerto)

        Me.cmbPuertoDest.DataSource = oListPuertoFind
        Me.cmbPuertoDest.DisplayMember = "PSTCMPR1"
        Me.cmbPuertoDest.ValueMember = "PSCPRTOR"
        cmbPuertoDest.SelectedValue = "-1"
    End Sub

    Private Sub cmbPaisOrg_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaisOrg.SelectionChangeCommitted
        Try
            Filtrar_Puerto_Org(oListGenPuerto, cmbPaisOrg.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmbPaisDest_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaisDest.SelectionChangeCommitted
        Try
            Filtrar_Puerto_Dest(oListGenPuerto, cmbPaisDest.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub Grabar_Datos_Embarque()

        Dim obedatoEmbarque As New beDatosEmbarque
        Dim retorno As Int32 = 0
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        obedatoEmbarque.PNNORSCI = oEmbarque.pNORSCI
        If Me.ctbCiaTransp.NoHayCodigo Then
            obedatoEmbarque.PNCCIANV = 0
        Else
            obedatoEmbarque.PNCCIANV = Me.ctbCiaTransp.Codigo
        End If

        If ctbMedioTransportes.SelectedValue = 2D Then 'MARITIMO
            If Me.ctbNave.NoHayCodigo Then
                obedatoEmbarque.PSCVPRCN = ""
            Else
                obedatoEmbarque.PSCVPRCN = Me.ctbNave.Codigo
            End If
        Else
            obedatoEmbarque.PSCVPRCN = ""
        End If

        If Me.mskEmbarque.Text.Trim.Length > 4 Then
            If Not isValidFecha(Me.mskEmbarque.Text) Then
                MessageBox.Show("Fecha Embarque no válida.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            obedatoEmbarque.PNFORSCI = Format(CType(Me.mskEmbarque.Text.Trim, Date), "yyyyMMdd")
        Else
            obedatoEmbarque.PNFORSCI = 0
        End If

        If Me.cmbPaisOrg.SelectedValue = -1D Then
            obedatoEmbarque.PNCPAIS = 0
            obedatoEmbarque.PSCPRTOE = ""
        Else
            obedatoEmbarque.PNCPAIS = Me.cmbPaisOrg.SelectedValue
            If Me.cmbPuertoOrg.SelectedValue = "-1" Then
                obedatoEmbarque.PSCPRTOE = ""
            Else
                obedatoEmbarque.PSCPRTOE = Me.cmbPuertoOrg.SelectedValue.ToString.Trim
            End If
        End If

        If Me.cmbPaisDest.SelectedValue = -1D Then
            obedatoEmbarque.PNCPAIS_DESTINO = 0
        Else
            obedatoEmbarque.PNCPAIS_DESTINO = cmbPaisDest.SelectedValue
        End If

        If Me.cmbPuertoDest.SelectedValue = "-1" Then
            obedatoEmbarque.PSCPRTOA = ""
        Else
            obedatoEmbarque.PSCPRTOA = Me.cmbPuertoDest.SelectedValue.ToString.Trim
        End If


        obedatoEmbarque.PSNOREMB = Me.txtNumEmbarcador.Text.Trim

        If Me.ctbAgenteDeCarga.NoHayCodigo Then
            obedatoEmbarque.PNCAGNCR = 0
        Else
            obedatoEmbarque.PNCAGNCR = ctbAgenteDeCarga.Codigo
        End If

        If Me.ctbTerminal.NoHayCodigo Then
            obedatoEmbarque.PSCTRMAL = ""
        Else
            obedatoEmbarque.PSCTRMAL = ctbTerminal.Codigo
        End If
        obedatoEmbarque.PNCMEDTR = IIf(ctbMedioTransportes.SelectedValue = -1D, 0, ctbMedioTransportes.SelectedValue)


        obedatoEmbarque.PNQVOLMR = IIf(txtM3.Text = "", 0, txtM3.Text)
        obedatoEmbarque.PNNDIALB = IIf(txtDiaLibre.Text = "", 0, txtDiaLibre.Text)
        obedatoEmbarque.PNNDIASE = IIf(txtSobreEstadia.Text = "", 0, txtSobreEstadia.Text)
        obedatoEmbarque.PNQPSOAR = IIf(txtKg.Text.Trim = "", 0, txtKg.Text.Trim)


        retorno = oEmbarque.Mantenimiento_Datos_Embarque_VB(obedatoEmbarque)

    End Sub

    Private Function GrabarDatosCartaFianza() As Boolean
        Dim IsValid As Boolean = False
        If Me.gbxFianza.Visible Then
            Dim oCartaFianzaNeg As New clsCartaFianza
            Dim obeCartaFinaza As New beCartaFianza

            Dim NUMERO As Decimal = 0
            obeCartaFinaza.PNNORSCI = oEmbarque.pNORSCI
            obeCartaFinaza.PSNDOCUM = Me.txtPolizaNum.Text.Trim

            If (Me.cmbPolizaBanco.Text <> vbNullString) Then
                obeCartaFinaza.PNCBNCFN = Me.cmbPolizaBanco.SelectedValue
            End If
            If mskPolizaFecEmi.Text.Trim.Length > 4 Then
                If Not isValidFecha(Me.mskPolizaFecEmi.Text) Then
                    MessageBox.Show("Fecha emisión Carta Fianza no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
                obeCartaFinaza.PNFECEDC = Format(CType(mskPolizaFecEmi.Text.Trim, Date), "yyyyMMdd")
            Else
                obeCartaFinaza.PNFECEDC = 0
            End If
            If mskPolizaFecVen.Text.Trim.Length > 4 Then
                If Not isValidFecha(Me.mskPolizaFecVen.Text) Then
                    MessageBox.Show("Fecha vencimiento Carta Fianza no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
                obeCartaFinaza.PNFECVEN = Format(CType(mskPolizaFecVen.Text.Trim, Date), "yyyyMMdd")
            Else
                obeCartaFinaza.PNFECVEN = 0
            End If

            If (Decimal.TryParse(Me.txtPolizaMonto.Text, NUMERO)) Then
                obeCartaFinaza.PNITTDOC = NUMERO
            Else
                obeCartaFinaza.PNITTDOC = 0
            End If

            If (Me.cmbPolizaMoneda.Text <> vbNullString) Then
                obeCartaFinaza.PSNMONOC = Me.cmbPolizaMoneda.Text.Trim
            End If
            If (Me.cmbPolizaMoneda.Text <> vbNullString) Then
                obeCartaFinaza.PNCMNDA1 = Me.cmbPolizaMoneda.SelectedValue
            End If
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

    Private Function isValidFecha(ByVal Fecha As String) As Boolean
        Dim FechaValida As Date
        Dim IsValid As Boolean = False
        Fecha = Fecha.Trim
        If (Date.TryParse(Fecha, FechaValida) = False) Then
            IsValid = False
        Else
            If FechaValida.Year > 1000 Then
                IsValid = True
            Else
                IsValid = False
            End If
        End If
        Return IsValid
    End Function

    Private Sub Grabar_Datos_Forol()
        Dim retorno As Int32 = 0
        Dim msgOS As New StringBuilder
        Dim ExistOSEnAgencia As Boolean = False
        Dim odatoEmbarque As New beDatosEmbarque
        Dim ContinuarActualizacion As Boolean = True

        If Me.mskApertura.Text.Trim.Length > 4 Then
            If Not isValidFecha(Me.mskApertura.Text) Then
                MessageBox.Show("Fecha Apertura no válida.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            odatoEmbarque.PNFCEMSN = Format(CType(Me.mskApertura.Text.Trim, Date), "yyyyMMdd")
        Else
            odatoEmbarque.PNFCEMSN = 0
        End If
        odatoEmbarque.PNPNNMOS = IIf(Me.txtNroOS.Text.Trim = "", 0, Me.txtNroOS.Text.Trim)

        odatoEmbarque.PSREFDO1 = Me.txtRefDoc.Text.Trim
        odatoEmbarque.PSNREFCL = txtRefCli.Text.Trim
        odatoEmbarque.PSTOBERV = Me.txtMercaderia.Text.Trim

        If Me.cmbTransporte.SelectedValue = -1D Then
            odatoEmbarque.PNTRANSPORTE = 0
            odatoEmbarque.PSTNMCTT = ""
        Else
            odatoEmbarque.PNTRANSPORTE = Me.cmbTransporte.SelectedValue
            odatoEmbarque.PSTNMCTT = IIf(odatoEmbarque.PNTRANSPORTE = 3, Me.txtTransTercero.Text.Trim, "")
        End If

        odatoEmbarque.PSTBFTRB = Me.txtBeneficio.Text.Trim
        odatoEmbarque.PSTDRENT = Me.txtDireccion.Text.Trim
        odatoEmbarque.PSHORATN = Me.txtHorario.Text.Trim
        odatoEmbarque.PSTPRSCN = Me.txtContacto.Text.Trim
        odatoEmbarque.PSTRECOR = Me.txtObservacion.Text.Trim
        odatoEmbarque.PNCZNFCC = Me.cmbZona.SelectedValue
        odatoEmbarque.PNCTRSPT = uc_Transportista.pPNCTRSPT
        odatoEmbarque.PNALM_LOCAL = Uc_Almacen_Local.pPNNCODRG
        'odatoEmbarque.PNNCODRG_REG = IIf(cboRegimen.SelectedValue <> -1D, cboRegimen.SelectedValue, 0)
        odatoEmbarque.PNTPORGE = IIf(cboRegimen.SelectedValue <> -1D, cboRegimen.SelectedValue, 0)
        odatoEmbarque.PSTCANAL = IIf(cboCanal.SelectedValue <> "-1", cboCanal.SelectedValue, "")
        odatoEmbarque.PSTNRODU = txtDUA.Text.Trim
        odatoEmbarque.PNNORSCI = oEmbarque.pNORSCI

        odatoEmbarque.PNNCODRG_DESPACHO = IIf(cmbTipoDespachos.SelectedValue = -1D, 0, cmbTipoDespachos.SelectedValue)
        odatoEmbarque.PNCPRVCL = UcProveedor_tab.pCodigo
        If IsRegimenTemporal(cboRegimen.SelectedValue) Then

            'If Me.mskFInicioRegimen.Text.Trim.Length > 4 Then
            '    If Not isValidFecha(Me.mskFInicioRegimen.Text) Then
            '        MessageBox.Show("Fecha inicio régimen no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            '    odatoEmbarque.PNFECINI_REG = Format(CType(Me.mskFInicioRegimen.Text.Trim, Date), "yyyyMMdd")
            'Else
            '    odatoEmbarque.PNFECINI_REG = 0
            'End If
            'If Me.mskFVencRegimen.Text.Trim.Length > 4 Then
            '    If Not isValidFecha(Me.mskFVencRegimen.Text) Then
            '        MessageBox.Show("Fecha vencimiento régimen no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            '    odatoEmbarque.PNFECVEN_REG = Format(CType(Me.mskFVencRegimen.Text.Trim, Date), "yyyyMMdd")
            'Else
            '    odatoEmbarque.PNFECVEN_REG = 0
            'End If

            If Me.mskFVencRegimen.Text.Trim.Length > 4 Then
                If Not isValidFecha(Me.mskFVencRegimen.Text) Then
                    MessageBox.Show("Fecha vencimiento régimen no válido.", "Verificar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                odatoEmbarque.PNFTRORS_REG = Format(CType(Me.mskFVencRegimen.Text.Trim, Date), "yyyyMMdd")
            Else
                odatoEmbarque.PNFTRORS_REG = 0
            End If

        Else
            odatoEmbarque.PNFTRORS_REG = 0
            'odatoEmbarque.PSTOBSRL_REG = ""
        End If

        If txtEmbOrigen.Text.Length > 0 Then

        End If

        odatoEmbarque.PNNORSCO_REG = IIf(Me.txtEmbOrigen.Text.Trim = "", 0, Me.txtEmbOrigen.Text.Trim)


        Dim obeAgencia As New beAgencia
        obeAgencia = oEmbarque.VERIFICA_EXISTENCIA_OS_EN_AGENCIA(odatoEmbarque.PNPNNMOS, odatoEmbarque.PNCZNFCC)
        If (odatoEmbarque.PNPNNMOS > 0) Then
            If (obeAgencia Is Nothing) Then
                msgOS.Append("La OS " & odatoEmbarque.PNPNNMOS & " No existe en Agencia. Se procederá a crear la OS en Agencias.")
                msgOS.AppendLine()
                msgOS.Append("¿ Desea continuar con la actualización de Apertura OS?")
                If (Not MessageBox.Show(msgOS.ToString, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    ContinuarActualizacion = False
                End If
            End If
        End If
        If ContinuarActualizacion = False Then Exit Sub

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

        Dim REGIMEN As String = cboRegimen.SelectedValue
        VizualizarDatosFianza(REGIMEN)
        Actualizar_Grilla(ACTUALIZACION_GRILLA.EMBARQUE)

    End Sub

    Private Function Validar_Doc_Forol(ByVal pintRow As Integer) As Boolean
        If dtgDocAdjuntos.Rows(pintRow).Cells("NUMDOC").Value.ToString.Trim <> vbNullString And (dtgDocAdjuntos.Rows(pintRow).Cells("FLGORG").Value.ToString.Trim = "X" Or dtgDocAdjuntos.Rows(pintRow).Cells("FLGCOP").Value.ToString.Trim = "X") Then
            Return True
        End If
        Return False
    End Function

    Private Sub Grabar_Documentos_Forol()
        Dim obeDetCargaInternacional_BE As beDetalleCargaInternacional
        Dim intCont As Integer
        Dim PSSORDOC As String
        Dim PNQCANTI As Double
        oDocApertura.Borrar_Doc_Forol(Me.dblEmbSelec)
        For intCont = 0 To Me.dtgDocAdjuntos.Rows.Count - 1
            If Validar_Doc_Forol(intCont) Then
                If dtgDocAdjuntos.Rows(intCont).Cells("FLGORG").Value.ToString.Trim = "X" Then
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
            If Me.dtgDocAdjuntos.SelectedCells.Count = 1 Then
                If dtgDocAdjuntos.SelectedCells(0).ColumnIndex = IndexFLGORG Or Me.dtgDocAdjuntos.SelectedCells(0).ColumnIndex = IndexFLGCOP Then
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
                'Me.oDsSegAdu.Tables("oDtDocApertura").AcceptChanges()
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
            oDrVw.CreateCells(Me.dtgDocumentos)
            Me.dtgDocumentos.Rows.Add(oDrVw)
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
        If Me.dtgDocumentos.Rows(pintIndice).Cells("TDOCIN").Value <> Nothing Then
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
        For Fila = 0 To Me.dtgDocumentos.Rows.Count - 1
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
        Dim PSTIPO_UPDATE As String = ""
        Dim PSNORCML As String = ""
        Dim NRPARC As Decimal = 0
        obeDocAdjuntoEmbarque = New beDocCargaInternacional
        obeDocAdjuntoEmbarque.PNNORSCI = oEmbarque.pNORSCI
        obeDocAdjuntoEmbarque.PNCCLNT = oEmbarque.pCCLNT
        obeDocAdjuntoEmbarque.PNNDOCIN = dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value
        obeDocAdjuntoEmbarque.PSNDOCLI = ("" & dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value).ToString.Trim
        obeDocAdjuntoEmbarque.PNNCRRDC = dtgDocumentos.Rows(Fila).Cells("NCRRDC").Value

        NRPARC = dtgDocumentos.Rows(Fila).Cells("DOCADJUN_NRPARC").Value
        PSNORCML = ("" & dtgDocumentos.Rows(Fila).Cells("OC").Value).ToString.Trim

        If obeDocAdjuntoEmbarque.PNNDOCIN = 2 Then
            If PSNORCML.Length > 0 Then
                obeDocAdjuntoEmbarque.PSNORCML = PSNORCML
                obeDocAdjuntoEmbarque.PNNRPARC = NRPARC
                If Me.dtgDocumentos.Rows(Fila).Cells("FOB").Value <> Nothing Then
                    If Not Decimal.TryParse(Me.dtgDocumentos.Rows(Fila).Cells("FOB").Value, obeDocAdjuntoEmbarque.PNFOB) Then
                        obeDocAdjuntoEmbarque.PNFOB = 0
                    End If
                Else
                    obeDocAdjuntoEmbarque.PNFOB = 0
                End If
            Else
                obeDocAdjuntoEmbarque.PSNORCML = ""
                obeDocAdjuntoEmbarque.PNNRPARC = 0
                obeDocAdjuntoEmbarque.PNFOB = 0
            End If
        Else
            obeDocAdjuntoEmbarque.PSNORCML = ""
            obeDocAdjuntoEmbarque.PNNRPARC = 0
            obeDocAdjuntoEmbarque.PNFOB = 0
        End If
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
        obeDocAdjuntoEmbarque.PNSECSUS = dtgDocumentos.Rows(Fila).Cells("SECSUS").Value
        obeDocAdjuntoEmbarque.PSURLARC = ("" & dtgDocumentos.Rows(Fila).Cells("URLARC").Value).ToString.Trim
        obeDocAdjuntoEmbarque.PSTNMBAR = ("" & dtgDocumentos.Rows(Fila).Cells("TNMBAR").Value).ToString.Trim
        If obeDocAdjuntoEmbarque.PSNORCML.Length > 0 Then
            PSTIPO_UPDATE = "FAC_OS"
        Else
            PSTIPO_UPDATE = "DOC_OS"
        End If
        oDocApertura.Actualizar_Documentos_Adjunto(obeDocAdjuntoEmbarque, PSTIPO_UPDATE)

    End Sub

    Private Sub Grabar_DocAdj(Optional ByVal FilaUpdate As Int32 = -1)
        Dim isValidDoc As Boolean = False
        isValidDoc = ValidarIngresoDocAdjunto()
        If isValidDoc = False Then
            MessageBox.Show("Verifique los documentos. Varios documentos del mismo tipo" & Chr(13) & "no pueden tener el mismo N° de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Fila As Integer
        If FilaUpdate <> -1 Then
            If Validar(FilaUpdate) Then
                GrabarFilaDocAdjunto(FilaUpdate)
            End If
        Else
            For Fila = 0 To Me.dtgDocumentos.Rows.Count - 1
                If Validar(Fila) Then
                    GrabarFilaDocAdjunto(Fila)
                End If
            Next
        End If
        Actualizar_Grilla(ACTUALIZACION_GRILLA.DOCADJUNTO) '2 - Documentos Adjuntos
        If FilaUpdate = -1 Then
            Me.dtgDocumentos.Rows.Clear()
            Llenar_Documentos_Embarque()
        End If

        Limpiar_Informacion()
        Cargar_Informacion_Embarque()
    End Sub
#End Region

    Private Sub dtgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellDoubleClick
        Try
            If (e.ColumnIndex < 0 Or e.RowIndex < 0) Then
                Exit Sub
            End If
            Dim ColName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
            If ColName = "LINK" AndAlso dtgDocumentos.Rows(e.RowIndex).Cells("TNMBAR").Value.ToString <> vbNullString Then
                Process.Start(dtgDocumentos.Rows(e.RowIndex).Cells("URLARC").Value.ToString.Trim & dtgDocumentos.Rows(e.RowIndex).Cells("TNMBAR").Value.ToString.Trim)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgDocumentos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgDocumentos.MouseDown

        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.ctmEmbarque.Items(0).Visible = False
                Me.ctmEmbarque.Items(1).Visible = False
                If (dtgDocumentos.Rows.Count <= 0) Then Exit Sub

                Dim ColName As String = dtgDocumentos.Columns(Me.dtgDocumentos.CurrentCell.ColumnIndex).Name
                If ColName = "FECORG" Or ColName = "FECCOP" Then
                    Me.ctmEmbarque.Items(0).Visible = True
                End If
                If ColName = "LINK" Then
                    Me.ctmEmbarque.Items(1).Visible = True
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
            Dim strCadena As String
            intPosicion = e.RowIndex
            Dim ColName As String = dtgDocumentos.Columns(e.ColumnIndex).Name
            Select Case ColName
                Case "UPLOAT"
                    If dtgDocumentos.Rows(e.RowIndex).Cells("NORSCI_ADJ").Value.ToString = 0 Then
                        HelpClass.MsgBox("Debe grabar antes la información para poder subir una imagen")
                        Exit Sub
                    End If
                    Dim NORSCI_ADJ As String = dtgDocumentos.Rows(e.RowIndex).Cells("NORSCI_ADJ").Value.ToString.Trim
                    Dim NCRRDC As String = dtgDocumentos.Rows(e.RowIndex).Cells("NCRRDC").Value.ToString.Trim
                    Dim TDOCIN As String = dtgDocumentos.Rows(e.RowIndex).Cells("TDOCIN").Value.ToString.Trim
                    strCadena = NORSCI_ADJ & "_" & NCRRDC & "_" & TDOCIN
                    Dim objfrmSA As New frmSubirArchivo(strCadena)
                    If objfrmSA.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim objCargarImagen As New Negocio.clsImageWebUpload
                        If objCargarImagen.ExisteImagen("SOLMIN_SC", strCadena & objCargarImagen.GetFileExtencion("SOLMIN_SC", strCadena)) Then
                            dtgDocumentos.Rows(e.RowIndex).Cells("URLARC").Value = HelpUtil.getSetting("URL_ADJ_SIL")
                            dtgDocumentos.Rows(e.RowIndex).Cells("TNMBAR").Value = strCadena & objCargarImagen.GetFileExtencion("SOLMIN_SC", strCadena)
                            dtgDocumentos.Rows(e.RowIndex).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.Archivo
                            Grabar_DocAdj(e.RowIndex)
                        End If
                    End If

                Case "DELETE_DOCADJ"
                    Dim PSNORCML_ALL As String = ""
                    Dim NORCML() As String

                    Dim ExisteDocBD As Int32 = 0
                    Dim obeCargaEmbarque As New beDocCargaInternacional
                    Dim obeDocAdjunto As New beDocCargaInternacional
                    ExisteDocBD = dtgDocumentos.Rows(e.RowIndex).Cells("EXISTS_DOCADJ").Value

                    If ExisteDocBD = 1 Then
                        If MessageBox.Show("¿ Está seguro de eliminar el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            PSNORCML_ALL = ("" & dtgDocumentos.Rows(e.RowIndex).Cells("OC").Value).ToString.Trim
                            If PSNORCML_ALL.Length > 0 Then
                                NORCML = Split(PSNORCML_ALL, "-")
                                obeCargaEmbarque.PSNORCML = NORCML(0)
                                obeCargaEmbarque.PNNRPARC = NORCML(1)
                            Else
                                obeCargaEmbarque.PSNORCML = ""
                                obeCargaEmbarque.PNNRPARC = 0
                            End If
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


    Private Sub VizualizarDatosFianza(ByVal PSREGIMEN As String)
        If PSREGIMEN = "2" OrElse PSREGIMEN = "5" OrElse PSREGIMEN = "15" OrElse PSREGIMEN = "18" Then
            Me.gbxFianza.Visible = True
        Else
            Me.gbxFianza.Visible = False
        End If
    End Sub
    Private Sub Actualizar_Datos(ByVal pdblEmbarque As Double, ByVal pstrColumna As String, ByVal pstrDato As String)
        Dim pCCMPN As String = oEmbarque.pCCMPN
        Dim pCDVSN As String = oEmbarque.pCDVSN
        Select Case pstrColumna
            'Case "QVOLMR"
            '    oEmbarque.Actualiza_M3(pdblEmbarque, Double.Parse(pstrDato))
            'Case "QPSOAR"
            '    oEmbarque.Actualiza_Kg_Bruto(pdblEmbarque, Double.Parse(pstrDato))
            'Case "NDIALB"
            '    oEmbarque.Actualiza_Dia_Libre(pdblEmbarque, Double.Parse(pstrDato))
            'Case "NDIASE"
            '    oEmbarque.Actualiza_Sobre_Estadia(pdblEmbarque, Double.Parse(pstrDato))
            Case "FECDCP"
                oEmbarque.Actualiza_Status_Documentos(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                If (Not Me.dtgSegAduanero.Columns.Item("DIFDCN") Is Nothing) And (Not Me.dtgSegAduanero.Columns.Item("FECNUM") Is Nothing) Then
                    Calcular_Numeracion_Vs_DocCompleto(Me.dtgSegAduanero.CurrentRow.Cells("FECDCP").Value.ToString.Trim, Me.dtgSegAduanero.CurrentRow.Cells("FECNUM").Value.ToString.Trim)
                End If
                'adicionado ---***************----------------
                ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(dtgSegAduanero.CurrentRow.Index)
                ActualizarDiferencia_DocumentosCompletos_VS_ETA(dtgSegAduanero.CurrentRow.Index)
                '----------------*************---------------
                'Select Case oEmbarque.pCCLNT
                '    Case 2287, 48916, 46550, 48623, 48622
                '        If Me.txtNumEmbarcador.Text <> vbNullString Then
                '            Enviar_Checkpoint_Embarcador()
                '        End If
                'End Select

                If oEmbarque.pCCLNT_PORTAL > 0 Then
                    If oEmbarque.pNOREMB.Length > 0 Then
                        'Enviar_Checkpoint_Embarcador()

                        'oHebraCheckPointYRC_CHK_EMB = New Thread(AddressOf Enviar_Checkpoint_Embarcador)
                        'oHebraCheckPointYRC_CHK_EMB.Start()
                        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                    End If
                End If




            Case "FECNUM"
                oEmbarque.Actualiza_Status_Numeracion(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                EnviaMensajeTexto(pdblEmbarque)
                If (Not Me.dtgSegAduanero.Columns.Item("DIFDCN") Is Nothing) And (Not Me.dtgSegAduanero.Columns.Item("FECDCP") Is Nothing) Then
                    Calcular_Numeracion_Vs_DocCompleto(Me.dtgSegAduanero.CurrentRow.Cells("FECDCP").Value.ToString.Trim, Me.dtgSegAduanero.CurrentRow.Cells("FECNUM").Value.ToString.Trim)
                End If

                'adicionado ---***************----------------
                ActualizarDiferencia_Numeracion_VS_PagoDerecho(dtgSegAduanero.CurrentRow.Index)
                '----------------*************---------------
                'Select Case oEmbarque.pCCLNT
                '    Case 2287, 48916, 46550, 48623, 48622
                '        If Me.txtNumEmbarcador.Text <> vbNullString Then
                '            Enviar_Checkpoint_Embarcador()
                '        End If
                'End Select

                If oEmbarque.pCCLNT_PORTAL > 0 Then
                    If oEmbarque.pNOREMB.Length > 0 Then
                        'Enviar_Checkpoint_Embarcador()

                        'oHebraCheckPointYRC_CHK_EMB = New Thread(AddressOf Enviar_Checkpoint_Embarcador)
                        'oHebraCheckPointYRC_CHK_EMB.Start()
                        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                    End If
                End If
            Case "FECPGD"
                oEmbarque.Actualiza_Status_Pago_Derechos(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                If (Not Me.dtgSegAduanero.Columns.Item("DIFPDA") Is Nothing) And (Not Me.dtgSegAduanero.Columns.Item("FECALM") Is Nothing) Then
                    Calcular_FecAt_Vs_PagoDer(Me.dtgSegAduanero.CurrentRow.Cells("FECPGD").Value.ToString.Trim, Me.dtgSegAduanero.CurrentRow.Cells("FECALM").Value.ToString.Trim)
                End If

                'adicionado ---***************----------------
                ActualizarDiferencia_Numeracion_VS_PagoDerecho(dtgSegAduanero.CurrentRow.Index)
                '----------------*************---------------
                'Select Case oEmbarque.pCCLNT
                '    Case 2287, 48916, 46550, 48623, 48622
                '        If Me.txtNumEmbarcador.Text <> vbNullString Then
                '            Enviar_Checkpoint_Embarcador()
                '        End If
                'End Select

                If oEmbarque.pCCLNT_PORTAL > 0 Then
                    If oEmbarque.pNOREMB.Length > 0 Then
                        'Enviar_Checkpoint_Embarcador()

                        'oHebraCheckPointYRC_CHK_EMB = New Thread(AddressOf Enviar_Checkpoint_Embarcador)
                        'oHebraCheckPointYRC_CHK_EMB.Start()
                        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                        oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                    End If
                End If


            Case "FECLEV"
                oEmbarque.Actualiza_Status_Levante(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                EnviaMensajeTexto(pdblEmbarque)
                Select Case oEmbarque.pCCLNT
                    Case 2287, 48916, 46550, 48623, 48622
                        If Me.txtNumEmbarcador.Text.Trim <> vbNullString Then
                            Enviar_Checkpoint_Embarcador()
                        End If
                End Select


                '*********POR ADICION G YM
                ActualizarDiferencia_LLegada_VS_Levante(dtgSegAduanero.CurrentRow.Index)
                ActualizarDiferencia_Levante_VS_Almacen(dtgSegAduanero.CurrentRow.Index)
                '*********************
            Case "FECPRO"
                oEmbarque.Actualiza_Status_Proforma(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
            Case "FECALM"
                oEmbarque.Actualiza_Status_Entrega(pCCMPN, pCDVSN, pdblEmbarque, Format(CType(pstrDato, Date), "yyyyMMdd"))
                If (Not Me.dtgSegAduanero.Columns.Item("DIFPDA") Is Nothing) And (Not Me.dtgSegAduanero.Columns.Item("FECPGD") Is Nothing) Then
                    Calcular_FecAt_Vs_PagoDer(Me.dtgSegAduanero.CurrentRow.Cells("FECPGD").Value.ToString.Trim, Me.dtgSegAduanero.CurrentRow.Cells("FECALM").Value.ToString.Trim)
                End If
                'adicionado ---***************----------------
                ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(dtgSegAduanero.CurrentRow.Index)
                '----------------*************---------------
                'ADICIONADO POR GY M*************************************************
                ActualizarDiferencia_Levante_VS_Almacen(dtgSegAduanero.CurrentRow.Index)
                '********************************************************************
                Select Case oEmbarque.pCCLNT
                    Case 2287, 48916, 46550, 48623, 48622
                        If Me.txtNumEmbarcador.Text.Trim <> vbNullString Then
                            Enviar_Checkpoint_Embarcador()
                            If Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "7" Then 'DEPOSITO
                                Cambiar_Status_OC("D")
                            Else
                                If Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "1" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "2" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "8" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "5" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "18" Or Me.dtgSegAduanero.CurrentRow.Cells("REGIMEN").Value.ToString.Trim = "15" Then
                                    Cambiar_Status_OC("T")
                                End If
                            End If
                        End If
                End Select

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

    Private Sub Calcular_FecAt_Vs_PagoDer(ByVal pstrFecIni As String, ByVal pstrFecFin As String, Optional ByVal pintRow As Integer = -1)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            If pintRow = -1 Then
                Me.dtgSegAduanero.CurrentRow.Cells("DIFPDA").Value = lintDias
            Else
                Me.dtgSegAduanero.Rows(pintRow).Cells("DIFPDA").Value = lintDias
            End If
        End If
    End Sub

    Private Sub Calcular_Numeracion_Vs_DocCompleto(ByVal pstrFecIni As String, ByVal pstrFecFin As String, Optional ByVal pintRow As Integer = -1)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            If pintRow = -1 Then
                Me.dtgSegAduanero.CurrentRow.Cells("DIFDCN").Value = lintDias
            Else
                Me.dtgSegAduanero.Rows(pintRow).Cells("DIFDCN").Value = lintDias
            End If
        End If
    End Sub

    Private Function fintDiferencia_Dia(ByVal pstrDiaFinal As String, ByVal pstrDiaInicio As String, ByVal pintDia As Integer) As Integer
        Dim lintDif As Integer
        If IsDBNull(pstrDiaFinal) Or pstrDiaFinal = vbNullString Or IsDBNull(pstrDiaInicio) Or pstrDiaInicio = vbNullString Then
            Return 0
        End If
        lintDif = DateDiff(DateInterval.Day, CType(pstrDiaInicio, Date), CType(pstrDiaFinal, Date))
        If lintDif >= 0 Then
            lintDif = lintDif - pintDia
        Else
            lintDif = lintDif + pintDia
        End If
        Return lintDif
    End Function

#End Region

#Region "Exportar Excel"

    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        Try
            Dim odtTa As New DataTable
            odtTa = ListarDatosGridToTableSegAduanas()
            Dim FechaInicial As String = Me.dtpInicio.Value.ToString("dd/MM/yyyy")
            Dim FechaFinal As String = Me.dtpFin.Value.ToString("dd/MM/yyyy")
            Dim Cliente As String = Me.cmbCliente.pRazonSocial
            Ransa.Utilitario.HelpClass_NPOI_SC.ExportExcelSeguimientoAduanas(odtTa, "SEGUIMIENTO ADUANERO", Cliente, FechaInicial, FechaFinal)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function ListarDatosGridToTableSegAduanas() As DataTable
        Dim odtSegAduanas As New DataTable
        Dim ColTitle As String = ""
        Dim ColName As String = ""
        Dim ColValida As Boolean = False
        Dim TipoDato As String = ""
        Dim MdataColumna As String = ""
        Dim NPOI As New HelpClass_NPOI_SC
        For Each Item As DataGridViewColumn In dtgSegAduanero.Columns
            ColValida = False
            ColTitle = Item.HeaderText.Trim
            ColName = Item.Name.Trim
            TipoDato = ""
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
                    TipoDato = HelpClass_NPOI_SC.keyDatoTexto
                End If
                MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
                odtSegAduanas.Columns(ColName).Caption = MdataColumna
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
        Return odtSegAduanas
    End Function

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


    Private Sub Buscar()
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
            'Limpiar_Informacion()
            If dtgSegAduaneroReducido.RowCount > 0 Then
                dblEmbSelec = dtgSegAduaneroReducido.Rows(0).Cells("NORSCI_R").Value
                dblEmbSelecEstado = dtgSegAduaneroReducido.Rows(0).Cells("SESTRG_R").Value
                Cargar_Informacion_Embarque()
                btnReaperturar.Visible = (oclsCierreEmbarque.NoContieneACliente(oEmbarque.pCCLNT) And IsEmbarqueCerrado(oEmbarque.EmbarqueEstado))
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
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
            Buscar()
            HabilitarEdicionControlXEstado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Filtrar_SegAduanero()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dblEmbSelec = 0
        dblEmbSelecEstado = ""
        Limpiar_Informacion()
        Llenar_Aduanero()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Actualizar_Grilla(ByVal TIPO_UPDATE As ACTUALIZACION_GRILLA, Optional ByVal strDato As String = "")
        Dim intCont As Integer
        Dim intDoc As Integer
        Dim intIndice As Integer
        Dim intContTabla, intRow As Integer
        Dim ColName As String = ""
        Select Case TIPO_UPDATE
            Case ACTUALIZACION_GRILLA.DOCADJUNTO   '2 '
                Dim strFact As String = vbNullString
                Limpiar_Fechas()
                For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                    If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                        With Me.dtgSegAduanero.Rows(intCont)
                            For intDoc = 0 To Me.dtgDocumentos.Rows.Count - 1
                                Select Case Me.dtgDocumentos.Rows(intDoc).Cells("TDOCIN").Value
                                    Case 0 ' Otros
                                        If Not Me.dtgSegAduanero.Columns.Item("OTRORG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("OTRORG").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If

                                        End If
                                    Case 2 ' Factura Comercial
                                        If strFact = vbNullString Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value Is Nothing Then
                                                strFact = Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value.ToString.Trim
                                            End If
                                        Else
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value Is Nothing Then
                                                strFact = strFact & vbCrLf & Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value.ToString.Trim
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("FACORG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("FACORG").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("FACCOP") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("FACCOP").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                    Case 4, 5, 15 ' Bill of Lading, Air Way Bill
                                        If Not Me.dtgSegAduanero.Columns.Item("DOCEMB") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("DOCEMB").Value = Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value.ToString.Trim
                                                End If
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("DEMORG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("DEMORG").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("DEMCOP") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("DEMCOP").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                    Case 6 ' Volante
                                        If Not Me.dtgSegAduanero.Columns.Item("VOLORG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("VOLORG").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("VOLCOP") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("VOLCOP").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                    Case 10 ' Seguro
                                        If Not Me.dtgSegAduanero.Columns.Item("NUMSEG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("NUMSEG").Value = Me.dtgDocumentos.Rows(intDoc).Cells("NDOCLI").Value.ToString.Trim
                                                End If
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("SEGORG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("SEGORG").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("SEGCOP") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("SEGCOP").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                    Case 13 ' Traducción
                                        If Not Me.dtgSegAduanero.Columns.Item("TRAORG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("TRAORG").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                        If Not Me.dtgSegAduanero.Columns.Item("TRACOP") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("TRACOP").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECCOP").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                    Case 14 ' Certificado de Origen
                                        If Not Me.dtgSegAduanero.Columns.Item("CORORG") Is Nothing Then
                                            If Not Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value Is Nothing Then
                                                If Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim <> vbNullString Then
                                                    .Cells("CORORG").Value = Mid(Me.dtgDocumentos.Rows(intDoc).Cells("FECORG").Value.ToString.Trim, 1, 10)
                                                End If
                                            End If
                                        End If
                                End Select
                            Next intDoc
                            If Not Me.dtgSegAduanero.Columns.Item("NUMFAC") Is Nothing Then
                                .Cells("NUMFAC").Value = strFact
                            End If
                        End With
                        Exit For
                    End If
                Next intCont
            Case ACTUALIZACION_GRILLA.EMBARQUE '3
                Dim strCarga As String = ""
                Dim strCant As String = ""
                For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                    If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                        With Me.dtgSegAduanero.Rows(intCont)
                            If Not Me.dtgSegAduanero.Columns.Item("CVPRCN") Is Nothing Then
                                If Me.ctbMedioTransportes.SelectedValue = 2D Then 'MARITIMO
                                    .Cells("CVPRCN").Value = ctbNave.Descripcion.Trim
                                Else
                                    .Cells("CVPRCN").Value = ctbCiaTransp.Descripcion.Trim
                                End If

                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("CPRTOE") Is Nothing Then

                                If cmbPuertoOrg.SelectedValue = "-1" Then
                                    If cmbPaisOrg.SelectedValue = -1D Then
                                        .Cells("CPRTOE").Value = ""
                                    Else
                                        .Cells("CPRTOE").Value = cmbPaisOrg.Text.Trim
                                    End If
                                Else
                                    .Cells("CPRTOE").Value = cmbPaisOrg.Text.Trim & " - " & cmbPuertoOrg.Text.Trim
                                End If

                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("CPRTOA") Is Nothing Then

                                If cmbPuertoDest.SelectedValue = "-1" Then
                                    .Cells("CPRTOA").Value = ""
                                Else
                                    .Cells("CPRTOA").Value = cmbPuertoDest.Text.Trim
                                End If

                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("TNIMCIN") Is Nothing Then
                                If ctbMedioTransportes.SelectedValue = 2D Then
                                    If Me.ctbCiaTransp.Descripcion.Trim <> vbNullString Then
                                        .Cells("TNIMCIN").Value = Me.ctbCiaTransp.Descripcion.Trim
                                    Else
                                        .Cells("TNIMCIN").Value = "---"
                                    End If
                                Else
                                    .Cells("TNIMCIN").Value = "---"
                                End If

                            End If
                            If Not Me.dtgSegAduanero.Columns.Item("REGIMEN") Is Nothing Then
                                If cboRegimen.SelectedValue = -1D Then
                                    .Cells("REGIMEN").Value = ""
                                Else
                                    .Cells("REGIMEN").Value = cboRegimen.Text.ToString.Trim
                                End If
                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("DESPACHO") Is Nothing Then

                                If cmbTipoDespachos.SelectedValue = -1D Then
                                    .Cells("DESPACHO").Value = ""
                                Else
                                    .Cells("DESPACHO").Value = cmbTipoDespachos.Text.ToString.Trim
                                End If

                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("CMEDTR") Is Nothing Then
                                If (ctbMedioTransportes.SelectedValue = -1D) Then
                                    .Cells("CMEDTR").Value = ""
                                Else
                                    .Cells("CMEDTR").Value = ctbMedioTransportes.Text.Trim
                                End If

                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("CANAL") Is Nothing Then
                                If cboCanal.SelectedValue = "-1" Then
                                    .Cells("CANAL").Value = ""
                                Else
                                    .Cells("CANAL").Value = cboCanal.SelectedValue.ToString.Trim
                                End If

                            End If


                            If Not Me.dtgSegAduanero.Columns.Item("NUMDUA") Is Nothing Then
                                .Cells("NUMDUA").Value = txtDUA.Text.Trim
                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("TPRVCL") Is Nothing Then
                                .Cells("TPRVCL").Value = UcProveedor_tab.pRazonSocial
                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("QPSOAR") Is Nothing Then
                                .Cells("QPSOAR").Value = IIf(txtKg.Text.Trim = "", 0, txtKg.Text.Trim)
                            End If
                            If Not Me.dtgSegAduanero.Columns.Item("NDIALB") Is Nothing Then
                                .Cells("NDIALB").Value = IIf(txtDiaLibre.Text.Trim = "", 0, txtDiaLibre.Text.Trim)
                            End If
                            If Not Me.dtgSegAduanero.Columns.Item("NDIASE") Is Nothing Then
                                .Cells("NDIASE").Value = IIf(txtSobreEstadia.Text.Trim = "", 0, txtSobreEstadia.Text.Trim)
                            End If
                            If Not Me.dtgSegAduanero.Columns.Item("QVOLMR") Is Nothing Then
                                .Cells("QVOLMR").Value = IIf(txtM3.Text.Trim = "", 0, txtM3.Text.Trim)
                            End If





                            For intIndice = 0 To Me.dtgCarga.Rows.Count - 1
                                If intIndice > 0 Then
                                    strCarga = strCarga & vbCrLf
                                    strCant = strCant & vbCrLf
                                End If
                                strCarga = strCarga & Me.dtgCarga.Rows(intIndice).Cells("CARGA").FormattedValue.ToString.Trim
                                strCant = strCant & Format(Double.Parse(Me.dtgCarga.Rows(intIndice).Cells("NBULTO").Value.ToString), "###,###")
                            Next intIndice
                            If Not Me.dtgSegAduanero.Columns.Item("TCARGA") Is Nothing Then
                                .Cells("TCARGA").Value = strCarga
                            End If
                            If Not Me.dtgSegAduanero.Columns.Item("NBLTAR") Is Nothing Then
                                .Cells("NBLTAR").Value = strCant
                            End If

                            If Not Me.dtgSegAduanero.Columns.Item("PNNMOS") Is Nothing Then
                                .Cells("PNNMOS").Value = txtNroOS.Text.Trim
                            End If
                            If Not Me.dtgSegAduanero.Columns.Item("TDITES") Is Nothing Then
                                .Cells("TDITES").Value = txtMercaderia.Text.Trim
                            End If
                            If Me.dtgSegAduanero.Columns.Item("CTRSPT") IsNot Nothing Then
                                Me.dtgSegAduanero.Rows(intCont).Cells("CTRSPT").Value = uc_Transportista.pPSTCMTRT
                            End If
                            If Me.dtgSegAduanero.Columns.Item("ALMDES") IsNot Nothing Then
                                Me.dtgSegAduanero.Rows(intCont).Cells("ALMDES").Value = Uc_Almacen_Local.pPSTDSCRG
                            End If
                            If Me.dtgSegAduanero.Columns.Item("NREFCLEMB") IsNot Nothing Then
                                Me.dtgSegAduanero.Rows(intCont).Cells("NREFCLEMB").Value = txtRefCli.Text.Trim
                            End If
                            If Me.dtgSegAduanero.Columns.Item("REFDO1") IsNot Nothing Then
                                Me.dtgSegAduanero.Rows(intCont).Cells("REFDO1").Value = txtRefDoc.Text.Trim
                            End If

                            If Me.dtgSegAduanero.Columns.Item("CMEDTRAGEN") IsNot Nothing Then
                                If (cmbTransporte.SelectedValue = -1D) Then
                                    Me.dtgSegAduanero.Rows(intCont).Cells("CMEDTRAGEN").Value = ""
                                Else
                                    Me.dtgSegAduanero.Rows(intCont).Cells("CMEDTRAGEN").Value = cmbTransporte.Text.Trim
                                End If
                            End If
                        End With
                        Exit For
                    End If
                Next intCont
            Case ACTUALIZACION_GRILLA.COSTOS '4
                For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                    If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                        With Me.dtgSegAduanero.Rows(intCont)
                            For intContTabla = 0 To oDs.Tables.Count - 1
                                For intRow = 0 To oDs.Tables.Item(intContTabla).Rows.Count - 1
                                    Select Case oDs.Tables.Item(intContTabla).Rows(intRow).Item(1).ToString
                                        Case "ITTEXW"
                                            If Not Me.dtgSegAduanero.Columns.Item("EXW") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("EXW").Value = "0.00"
                                                Else
                                                    .Cells("EXW").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If
                                        Case "GFOB"
                                            If Not Me.dtgSegAduanero.Columns.Item("GFOB") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("GFOB").Value = "0.00"
                                                Else
                                                    .Cells("GFOB").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "FOB"
                                            If Not Me.dtgSegAduanero.Columns.Item("FOB") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("FOB").Value = "0.00"
                                                Else
                                                    .Cells("FOB").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "FLETE"
                                            If Not Me.dtgSegAduanero.Columns.Item("FLETE") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("FLETE").Value = "0.00"
                                                Else
                                                    .Cells("FLETE").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "SEGURO"
                                            If Not Me.dtgSegAduanero.Columns.Item("SEGURO") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("SEGURO").Value = "0.00"
                                                Else
                                                    .Cells("SEGURO").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "CIF"
                                            If Not Me.dtgSegAduanero.Columns.Item("CIF") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("CIF").Value = "0.00"
                                                Else
                                                    .Cells("CIF").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "ADVALO"
                                            If Not Me.dtgSegAduanero.Columns.Item("ADVALOREM") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("ADVALOREM").Value = "0.00"
                                                Else
                                                    .Cells("ADVALOREM").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "IGV"
                                            If Not Me.dtgSegAduanero.Columns.Item("IGV") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("IGV").Value = "0.00"
                                                Else
                                                    .Cells("IGV").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If



                                        Case "IPM"
                                            If Not Me.dtgSegAduanero.Columns.Item("IPM") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("IPM").Value = "0.00"
                                                Else
                                                    .Cells("IPM").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "TOLDER"
                                            If Not Me.dtgSegAduanero.Columns.Item("TOTALDER") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("TOTALDER").Value = "0.00"
                                                Else
                                                    .Cells("TOTALDER").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If

                                        Case "ITTCEM"
                                            If Not Me.dtgSegAduanero.Columns.Item("ITTCEM") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("ITTCEM").Value = "0.00"
                                                Else
                                                    .Cells("ITTCEM").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If
                                        Case "ITTCAG"
                                            If Not Me.dtgSegAduanero.Columns.Item("ITTCAG") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("ITTCAG").Value = "0.00"
                                                Else
                                                    .Cells("ITTCAG").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If
                                        Case "OTSGAS"
                                            If Not Me.dtgSegAduanero.Columns.Item("OTSGAS") Is Nothing Then
                                                If IsDBNull(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL")) Then
                                                    .Cells("OTSGAS").Value = "0.00"
                                                Else
                                                    .Cells("OTSGAS").Value = Double.Parse(oDs.Tables.Item(intContTabla).Rows(intRow).Item("IVLDOL"))
                                                End If
                                            End If
                                    End Select
                                Next
                            Next
                        End With
                        Exit For
                    End If
                Next intCont
            Case ACTUALIZACION_GRILLA.OBSERVACION '5

                Dim obrFnEmbarque As New clsEmbarqueAduanas
                Dim odtObsCI As New DataTable
                odtObsCI.Columns.Add("TOBS")
                odtObsCI.Columns.Add("FECOBS")
                Dim drCI As DataRow

                Dim odtObsEmb As New DataTable
                odtObsEmb.Columns.Add("NORSCI")
                odtObsEmb.Columns.Add("TOBS")
                odtObsEmb.Columns.Add("FECOBS")
                Dim drEmb As DataRow

                If Not Me.dtgSegAduanero.Columns.Item("TOBERV") Is Nothing Then
                    For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                        If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                            With Me.dtgSegAduanero.Rows(intCont)

                                For intIndice = 0 To Me.dtgObsCargaInternacional.Rows.Count - 1
                                    drCI = odtObsCI.NewRow
                                    drCI("TOBS") = dtgObsCargaInternacional.Rows(intIndice).Cells("CITOBS").Value.ToString
                                    drCI("FECOBS") = dtgObsCargaInternacional.Rows(intIndice).Cells("CIFECOBS").Value
                                    odtObsCI.Rows.Add(drCI)
                                Next intIndice

                                For intIndice = 0 To Me.dtgObservaciones.Rows.Count - 1
                                    drEmb = odtObsEmb.NewRow
                                    drEmb("NORSCI") = Me.dblEmbSelec
                                    drEmb("TOBS") = dtgObservaciones.Rows(intIndice).Cells("OBSERV").Value.ToString
                                    drEmb("FECOBS") = dtgObservaciones.Rows(intIndice).Cells("FECOBS").Value
                                    odtObsEmb.Rows.Add(drEmb)
                                Next intIndice

                                .Cells("TOBERV").Value = obrFnEmbarque.Buscar_Observaciones_NoDiferenciado(odtObsCI, odtObsEmb, Me.dblEmbSelec)
                            End With
                            Exit For
                        End If
                    Next intCont
                End If

                If Not Me.dtgSegAduanero.Columns.Item("TOBERVDIF") Is Nothing Then
                    For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                        If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                            With Me.dtgSegAduanero.Rows(intCont)

                                For intIndice = 0 To Me.dtgObsCargaInternacional.Rows.Count - 1
                                    drCI = odtObsCI.NewRow
                                    drCI("TOBS") = dtgObsCargaInternacional.Rows(intIndice).Cells("CITOBS").Value.ToString
                                    drCI("FECOBS") = dtgObsCargaInternacional.Rows(intIndice).Cells("CIFECOBS").Value
                                    odtObsCI.Rows.Add(drCI)
                                Next intIndice
                                For intIndice = 0 To Me.dtgObservaciones.Rows.Count - 1
                                    drEmb = odtObsEmb.NewRow
                                    drEmb("NORSCI") = Me.dblEmbSelec
                                    drEmb("TOBS") = dtgObservaciones.Rows(intIndice).Cells("OBSERV").Value.ToString
                                    drEmb("FECOBS") = dtgObservaciones.Rows(intIndice).Cells("FECOBS").Value
                                    odtObsEmb.Rows.Add(drEmb)
                                Next intIndice

                                .Cells("TOBERVDIF").Value = obrFnEmbarque.Buscar_Observaciones_Diferenciado(odtObsCI, odtObsEmb, Me.dblEmbSelec)
                            End With
                            Exit For
                        End If
                    Next intCont
                End If
            Case ACTUALIZACION_GRILLA.DUA '6
                If Not Me.dtgSegAduanero.Columns.Item("NUMDUA") Is Nothing Then
                    For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                        If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                            Me.dtgSegAduanero.Rows(intCont).Cells("NUMDUA").Value = strDato
                            Exit For
                        End If
                    Next intCont
                End If

            Case ACTUALIZACION_GRILLA.ETA '7 'ACTUALIZACION ETA

                Dim Fecha As String = ""
                Dim FechaValor As Date
                If Date.TryParse(mskETA.Text.Trim, FechaValor) Then
                    Fecha = FechaValor.ToString("dd/MM/yyyy")
                End If
                For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                    If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                        If Not Me.dtgSegAduanero.Columns.Item("CHKETA") Is Nothing Then 'Ahora se actualiza cuando se graba fecha por fecha 23/01/2009
                            With Me.dtgSegAduanero.Rows(intCont)
                                .Cells("CHKETA").Value = Fecha
                            End With
                        End If
                    End If
                Next
                For intCont = 0 To Me.dtgCheckPoint.Rows.Count - 1
                    If dtgCheckPoint.Rows(intCont).Cells("TABRST").Value = "FAPRAR" Then
                        If (Fecha <> "") Then
                            dtgCheckPoint.Rows(intCont).Cells("FESEST").Value = Fecha
                        End If
                        If (dtgCheckPoint.Rows(intCont).Cells("FRETES").Value = vbNullString) Then
                            dtgCheckPoint.Rows(intCont).Cells("FRETES").Value = Fecha
                        End If
                    End If
                Next
            Case ACTUALIZACION_GRILLA.ETD '8 'ACTUALIZACION ETD
                'ETA
                Dim Fecha As String = ""
                Dim FechaValor As Date
                If Date.TryParse(mskETD.Text.Trim, FechaValor) Then
                    Fecha = FechaValor.ToString("dd/MM/yyyy")
                End If
                For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                    If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                        If Not Me.dtgSegAduanero.Columns.Item("CHKETD") Is Nothing Then 'Ahora se actualiza cuando se graba fecha por fecha 23/01/2009
                            With Me.dtgSegAduanero.Rows(intCont)
                                .Cells("CHKETD").Value = Fecha
                            End With
                        End If
                    End If
                Next
                For intCont = 0 To Me.dtgCheckPoint.Rows.Count - 1
                    If dtgCheckPoint.Rows(intCont).Cells("TABRST").Value = "FAPREV" Then
                        If (Fecha <> "") Then
                            dtgCheckPoint.Rows(intCont).Cells("FESEST").Value = Fecha
                        End If
                        If (dtgCheckPoint.Rows(intCont).Cells("FRETES").Value = vbNullString) Then
                            dtgCheckPoint.Rows(intCont).Cells("FRETES").Value = Fecha
                        End If
                    End If
                Next
        End Select
    End Sub


    Private Sub Limpiar_Fechas()
        Dim intCont As Integer

        For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
            If Double.Parse(Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value.ToString.Trim) = Me.dblEmbSelec Then
                If Not Me.dtgSegAduanero.Columns.Item("OTRORG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("OTRORG").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("NUMFAC") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("NUMFAC").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("FACCOP") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("FACCOP").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("FACORG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("FACORG").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("DOCEMB") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("DOCEMB").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("DEMCOP") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("DEMCOP").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("DEMORG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("DEMORG").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("VOLCOP") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("VOLCOP").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("VOLORG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("VOLORG").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("NUMSEG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("NUMSEG").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("SEGCOP") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("SEGCOP").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("SEGORG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("SEGORG").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("TRACOP") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("TRACOP").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("TRAORG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("TRAORG").Value = ""
                End If
                If Not Me.dtgSegAduanero.Columns.Item("CORORG") Is Nothing Then
                    Me.dtgSegAduanero.Rows(intCont).Cells("CORORG").Value = ""
                End If
                Exit For
            End If
        Next intCont
    End Sub

    Private Sub btnETD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnETD.Click
        Me.mskETD.Text = Me.mskETD.Text.Trim
        Dim Val_Fecha As Boolean = False
        Try
            Dim EnviarCorreo As Boolean = False

            If Me.mskETD.ReadOnly Then
                Me.mskETD.ReadOnly = False
                Me.btnETD.ImageIndex = 0
                Me.ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Guardar ETD" & vbCrLf & "Presionar ESC para Cancelar")
            Else
                If Me.mskETD.Text.Trim.Length > 4 Then
                    If Not isValidFecha(Me.mskETD.Text.Trim) Then
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
                Me.mskETD.ReadOnly = True
                Me.btnETD.ImageIndex = 1
                Me.ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Editar ETD")

                If Val_Fecha = True Then
                    '**************ADICION PARA ENVIO DE EMAIL X CAMBIO CHECKPOINT****************************
                    Control.CheckForIllegalCrossThreadCalls = False
                    PARAM_PSTNMBCM = "FAPREV"
                    Dim obeCheckPointFind As beCheckPointEnvio
                    oclsCheckPointEnvio = New clsCheckPointEnvio
                    If (oclsCheckPointEnvio.DebeNotificarEnvio__X_Cliente(oEmbarque.pCCLNT)) Then
                        obeCheckPointFind = oclsCheckPointEnvio.ExisteChkEnvioxPSTNMBCM(PARAM_PSTNMBCM)
                        If (obeCheckPointFind IsNot Nothing) Then
                            oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                            EnviarCorreo = True
                        End If
                    End If
                    '*********************************************************************
                    oEmbarque.Mantenimiento_ETD_Embarque(oEmbarque.pNORSCI, Format(CType(Me.mskETD.Text.Trim, Date), "yyyyMMdd"))
                    Actualizar_Grilla(ACTUALIZACION_GRILLA.ETD)
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
        Me.mskETA.Text = Me.mskETA.Text.Trim
        Try
            Dim EnviarCorreo As Boolean = False
            If Me.mskETA.ReadOnly Then
                Me.mskETA.ReadOnly = False
                Me.btnETA.ImageIndex = 0
                Me.ttlAduanas.SetToolTip(Me.btnETA, "Presionar para Guardar ETA" & vbCrLf & "Presionar ESC para Cancelar")
            Else
                If Me.mskETA.Text.Trim.Length > 4 Then
                    If Not isValidFecha(Me.mskETA.Text.Trim) Then
                        Val_Fecha = False
                    Else
                        Val_Fecha = True
                    End If

                    If Val_Fecha = False Then
                        Me.ttlAduanas.SetToolTip(Me.btnETA, "Presionar para Guardar ETA" & vbCrLf & "Presionar ESC para Cancelar")
                        MessageBox.Show("Fecha ETA no válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                Me.mskETA.ReadOnly = True
                Me.btnETA.ImageIndex = 1
                Me.ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Editar ETA")
                If Val_Fecha = True Then
                    '**************ADICION PARA ENVIO DE EMAIL X CAMBIO CHECKPOINT****************************
                    Control.CheckForIllegalCrossThreadCalls = False
                    PARAM_PSTNMBCM = "FAPREV"
                    Dim obeCheckPointFind As beCheckPointEnvio
                    oclsCheckPointEnvio = New clsCheckPointEnvio
                    If (oclsCheckPointEnvio.DebeNotificarEnvio__X_Cliente(oEmbarque.pCCLNT)) Then
                        obeCheckPointFind = oclsCheckPointEnvio.ExisteChkEnvioxPSTNMBCM(PARAM_PSTNMBCM)
                        If (obeCheckPointFind IsNot Nothing) Then
                            oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                            EnviarCorreo = True
                        End If
                    End If
                    '*********************************************************************
                    oEmbarque.Mantenimiento_ETA_Embarque(oEmbarque.pNORSCI, Format(CType(Me.mskETA.Text.Trim, Date), "yyyyMMdd"))
                    Actualizar_Grilla(ACTUALIZACION_GRILLA.ETA)
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
            Me.mskETD.ReadOnly = True
            Me.btnETD.ImageIndex = 1
            Me.ttlAduanas.SetToolTip(Me.btnETD, "Presionar para Editar ETD")
        End If
    End Sub

    Private Sub mskETA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskETA.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.mskETA.ReadOnly = True
            Me.btnETA.ImageIndex = 1
            Me.ttlAduanas.SetToolTip(Me.btnETA, "Presionar para Editar ETA")
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
                Me.cmtChk.Items(0).Visible = True
            Else
                Me.cmtChk.Items(0).Visible = False
            End If
        End If
    End Sub

#End Region

    Private Sub Grabar_Forol()
        Grabar_Datos_Forol()
        Grabar_Documentos_Forol()
        Limpiar_Documentos_Forol()
        Llenar_Documentos_Forol()
    End Sub



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

                    If oEmbarque.pCCLNT_PORTAL > 0 Then
                        If oEmbarque.pNOREMB.Length > 0 Then
                            oHebraCheckPointYRC_ITEM_EMB = New Thread(AddressOf Enviar_Items_Embarcador)
                            oHebraCheckPointYRC_ITEM_EMB.Start()
                        End If
                    End If

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
                        Grabar_Forol()
                        Limpiar_Informacion()
                        Cargar_Informacion_Embarque()
                        'oEmbarque.Cargar_Informacion_Inicial(oEmbarque.pNORSCI)
                        If oEmbarque.pCCLNT_PORTAL > 0 Then
                            If oEmbarque.pNOREMB.Length > 0 Then
                                oHebraCheckPointYRC_INFO_EMB = New Thread(AddressOf Enviar_Informacion_Embarcador)
                                oHebraCheckPointYRC_INFO_EMB.Start()

                                oHebraCheckPointYRC_ITEM_EMB = New Thread(AddressOf Enviar_Items_Embarcador)
                                oHebraCheckPointYRC_ITEM_EMB.Start()
                            End If
                        End If

                    End If
                Case 2

                    Grabar_DocAdj()



                Case 3
                    Actualizar_Datos_Embarque()

                    If oEmbarque.pCCLNT_PORTAL > 0 Then
                        If oEmbarque.pNOREMB.Length > 0 Then

                            oHebraCheckPointYRC_INFO_EMB = New Thread(AddressOf Enviar_Informacion_Embarcador)
                            oHebraCheckPointYRC_INFO_EMB.Start()

                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()

                        End If
                    End If

                Case 4
                    GuardarCostoEmbarque()

                    If oEmbarque.pCCLNT_PORTAL > 0 Then
                        If oEmbarque.pNOREMB.Length > 0 Then

                            oHebraCheckPointYRC_ITEM_EMB = New Thread(AddressOf Enviar_Items_Embarcador)
                            oHebraCheckPointYRC_ITEM_EMB.Start()

                            oHebraCheckPointYRC_COSTO_EMB = New Thread(AddressOf Enviar_Costos_Embarcador)
                            oHebraCheckPointYRC_COSTO_EMB.Start()

                        End If
                    End If

                Case 5
                    Grabar_Observaciones()
                    Llenar_Observaciones() 'Observaciones del Seguimiento
                    Actualizar_Grilla(ACTUALIZACION_GRILLA.OBSERVACION) '5 - Observaciones del Seguimiento

                    If oEmbarque.pCCLNT_PORTAL > 0 Then
                        If oEmbarque.pNOREMB.Length > 0 Then
                            oHebraCheckPointYRC_OBS_EMB = New Thread(AddressOf Enviar_Observaciones_Embarcador)
                            oHebraCheckPointYRC_OBS_EMB.Start()
                        End If
                    End If

                Case 7

                    Dim EnviarCorreo As Boolean = False
                    Dim PSREGIMEN As String = ""
                    '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
                    oclsCheckPointEnvio = New clsCheckPointEnvio
                    If (oclsCheckPointEnvio.DebeNotificarEnvio__X_Cliente(oEmbarque.pCCLNT)) Then
                        oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                        EnviarCorreo = True
                    End If
                    '***********************************************************************
                    Grabar_Checkpoint()
                    Llenar_CheckPoint()

                    PSREGIMEN = cboRegimen.SelectedValue
                    'CambiarStatusOC(True, PSREGIMEN)
                    EnviaMensajeTexto(oEmbarque.pNORSCI)


                    '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
                    If (EnviarCorreo = True) Then
                        oHebraCheckPointABB = New Thread(AddressOf EnviarActualizacionFechas_Interfaz_ABB_Asinc)
                        oHebraCheckPointABB.Start()
                        oHebra = New Thread(AddressOf ProcesarEnvioEmail_x_Change_CHK)
                        oHebra.Start()
                    End If
                    '****************************************************************************

                    If oEmbarque.pCCLNT_PORTAL > 0 Then
                        If oEmbarque.pNOREMB.Length > 0 Then
                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()
                        End If
                    End If


            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

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
            Dim obeListaCheckPointFinal As New List(Of beCheckPointFormato)
            oclsCheckPointEnvio.MailAccount = HelpClass.getSetting("email_account")
            oclsCheckPointEnvio.Mailpassword = HelpClass.getSetting("email_password")
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
        Try
            If oCierreEmbarque.DebeEnviarDatosIntegracionEmbarqueABB(CCLNT) Then
                msgExitoEnvioFechas = oCierreEmbarque.EnviarChangesEmbarque(CCLNT, PNNORSCI, CULUSA)
            End If
            If msgExitoEnvioFechas.Length > 0 Then
                MessageBox.Show(msgExitoEnvioFechas, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
        End Try

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
            Me.dtgCarga.Rows.Add(oDrVw)
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
            oDrVw.CreateCells(Me.dtgObservaciones)
            Me.dtgObservaciones.Rows.Add(oDrVw)
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

    Private Sub Importar_Forol()
        Dim strTipo As String
        Dim frm As frmVisorForol
        Dim objForol As New beForol

        objForol.OS = Me.txtNroOS.Text.Trim
        objForol.Cliente = Me.cmbCliente.pRazonSocial.ToUpper() & " " & Obtener_Descripcion_Cliente(CInt(oEmbarque.pCCLNT))
        objForol.Mercaderia = Me.txtMercaderia.Text.Trim
        objForol.Proveedor = UcProveedor_tab.pRazonSocial
        objForol.RefCliente = Me.txtRefDoc.Text.Trim
        objForol.Beneficio = Me.txtBeneficio.Text.Trim
        If Me.cmbTransporte.SelectedValue = 3 Then
            objForol.Tercero = Me.txtTransTercero.Text.Trim
        Else
            objForol.Tercero = ""
        End If
        objForol.Direccion = Me.txtDireccion.Text.Trim
        objForol.Horario = Me.txtHorario.Text.Trim
        objForol.Contacto = Me.txtContacto.Text.Trim
        If Me.txtObservacion.Text.Trim.Length > 120 Then
            objForol.Observacion1 = Me.txtObservacion.Text.Substring(1, 110).Trim
            objForol.Observacion2 = Me.txtObservacion.Text.Substring(111, Me.txtObservacion.Text.Trim.Length - 111).Trim
        Else
            objForol.Observacion1 = Me.txtObservacion.Text.Trim
            objForol.Observacion2 = ""
        End If
        objForol.Medio = IIf(ctbMedioTransportes.SelectedValue = -1D, "", ctbMedioTransportes.Text.Trim)
        objForol.Regimen = IIf(cboRegimen.SelectedValue = -1D, "", cboRegimen.Text)
        objForol.Despacho = cmbTipoDespachos.Text.Trim
        objForol.Transporte = Me.cmbTransporte.Text.Trim
        'objForol.Documentos = Me.oDsSegAdu.Tables("oDtDocApertura").Copy
        objForol.Documentos = oDtDocApertura.Copy

        strTipo = Me.mskApertura.Text.Trim.Substring(6, 4)
        frm = New frmVisorForol(objForol, strTipo)
        frm.Show()
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
        If Date.TryParse(Me.mskEmbarque.Text.Trim, Fecha) = False Then
            sbMensaje.Append("Debe ingresar(Dato Embarque) válida")
            sbMensaje.AppendLine()
        End If
        Return sbMensaje.ToString
    End Function
    Private Sub btnImportarForol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirForol.Click
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

            objForol.OS = Me.txtNroOS.Text.Trim
            objForol.Cliente = Me.cmbCliente.pRazonSocial.ToUpper() & "(" & Me.cmbCliente.pCodigo & ") " & Obtener_Descripcion_Cliente(CInt(Me.cmbCliente.pCodigo))
            objForol.Mercaderia = Me.txtMercaderia.Text.Trim
            objForol.Proveedor = UcProveedor_tab.pRazonSocial
            objForol.RefCliente = txtNroOC.Text.Trim
            objForol.Beneficio = Me.txtBeneficio.Text.Trim
            If Me.cmbTransporte.SelectedValue = 3 Then
                objForol.Tercero = Me.txtTransTercero.Text.Trim
            Else
                objForol.Tercero = ""
            End If
            objForol.Direccion = Me.txtDireccion.Text.Trim
            objForol.Horario = Me.txtHorario.Text.Trim
            objForol.Contacto = Me.txtContacto.Text.Trim
            If Me.txtObservacion.Text.Trim.Length > 120 Then
                objForol.Observacion1 = Me.txtObservacion.Text.Substring(1, 110).Trim
                objForol.Observacion2 = Me.txtObservacion.Text.Substring(111, Me.txtObservacion.Text.Trim.Length - 111).Trim
            Else
                objForol.Observacion1 = Me.txtObservacion.Text.Trim
                objForol.Observacion2 = ""
            End If
            objForol.Medio = IIf(ctbMedioTransportes.SelectedValue = -1D, "", ctbMedioTransportes.Text)
            objForol.Regimen = IIf(cboRegimen.SelectedValue = -1D, "", cboRegimen.Text.Trim)
            objForol.Despacho = cmbTipoDespachos.Text.Trim
            objForol.Transporte = Me.cmbTransporte.Text.Trim
            'objForol.Documentos = Me.oDsSegAdu.Tables("oDtDocApertura").Copy
            objForol.Documentos = oDtDocApertura.Copy
            frm = New frmVisorForol(objForol, strTipo)
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


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
        'If obeDatoEmbarque.PNNCODRG_REG = 0 Then
        '    sbMensaje.AppendLine("Régimen")
        'End If
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
            If obeDatoEmbarque.PNCHK_PAGO_DERECHO = 0 OrElse obeDatoEmbarque.PNCHK_NUMERACION = 0 Then
                sbMensaje.AppendLine("(122) CheckPoint Pago Derecho ó (121) Fecha Numeración  ")
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

    Private Sub btnCerrarEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarEmbarque.Click
        Dim Exito As Boolean = False
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
            obeDatoEmbarque = obrEmbarque.Listar_Datos_Validacion_Embarque(CCLNT, NORSCI)
            msValidacion = ValidarInformacionCompletaEmbarque(oEmbarque.pCCLNT, obeDatoEmbarque)
            If msValidacion.Length > 0 Then
                MessageBox.Show(msValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If MessageBox.Show("¿ Está seguro que desea cerrar el embarque ?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                DatoOperacion = obrclsServicio.Existe_Embarque_En_Operacion(oEmbarque.pNORSCI, oEmbarque.pCCLNT, "GE")
                If (DatoOperacion.Rows.Count > 0) Then
                    PNNOPRCN = DatoOperacion.Rows(0)("NOPRCN")
                Else
                    PNNOPRCN = 0
                End If
                If (PNNOPRCN <> 0) Then
                    Exito = True
                    oEmbarque.Cerrar_Embarque(oEmbarque.pNORSCI)
                    msgCierre = "El embarque " & oEmbarque.pNORSCI & " fue Cerrado." & Chr(13)
                    msgCierre = msgCierre & "El embarque " & oEmbarque.pNORSCI & " está asignado a la OPERACIÓN " & PNNOPRCN
                    MessageBox.Show(msgCierre, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim oCierreEmbarque As New clsCierreEmbarque
                    If oCierreEmbarque.DebeEnviarCostoACliente(cmbCliente.pCodigo) Then
                        oCierreEmbarque.EnviarCostos(cmbCliente.pCodigo, dblEmbSelec, UserName)
                    End If
                    chkVista_CheckedChanged(chkVistaExtendida, Nothing)
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    Dim dblFecAlm As Double
                    dblFecAlm = obeDatoEmbarque.PNCHK_ENTREGA_ALMACEN

                    If dblFecAlm > 0 Then
                        Dim ofrm As New frmTarifasDeServicios
                        ofrm.CodCompania = oEmbarque.pCCMPN
                        ofrm.CodDivision = oEmbarque.pCDVSN

                        ofrm.CodCliente = cmbCliente.pCodigo
                        ofrm.Embarque = dblEmbSelec
                        ofrm.FechaDeServicio = dblFecAlm
                        If ofrm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                            Dim dblTarifa As Double = ofrm.TarifaDeServicios.Cells("NRTFSV").Value
                            Dim strTipo As String = ofrm.TarifaDeServicios.Cells("STPTRA").Value
                            Dim strUnidad As String = ofrm.TarifaDeServicios.Cells("CUNDMD").Value
                            Dim dblValor As Double = ofrm.TarifaDeServicios.Cells("VALCTE").Value

                            dtOperacionCierre = oEmbarque.Enviar_Operacion_Facturacion(PSCCMPN, PSCDVSN, oEmbarque.pCCLNT, dblFecAlm, dblTarifa, strTipo, strUnidad, dblValor)
                            ExitoOperacion = ("" & dtOperacionCierre.Rows(0)("WK_EXITO")).ToString.Trim
                            MsgOperacion = ("" & dtOperacionCierre.Rows(0)("MSGIMP")).ToString.Trim

                            If (ExitoOperacion = "1") Then
                                Exito = True
                                Dim mensajeCierre As String = ""
                                oEmbarque.Cerrar_Embarque(oEmbarque.pNORSCI)
                                Dim NumeroRevisionGenerada As String = ""
                                NumeroRevisionGenerada = ConsistenciarOperacion_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
                                mensajeCierre = "Embarque cerrado correctamente."
                                Dim oCierreEmbarque As New clsCierreEmbarque

                                If oCierreEmbarque.DebeEnviarCostoACliente(oEmbarque.pCCLNT) Then
                                    oCierreEmbarque.EnviarCostos(cmbCliente.pCodigo, dblEmbSelec, UserName)
                                End If
                                MsgOperacion = mensajeCierre & Chr(13) & MsgOperacion
                                MsgOperacion = MsgOperacion & Chr(13) & NumeroRevisionGenerada
                                chkVista_CheckedChanged(chkVistaExtendida, Nothing)
                            End If
                            HelpClass.MsgBox(MsgOperacion)
                        Else
                            MsgOperacion = "NO HA SELECCIONADO TARIFA PARA EL SERVICIO DE MANAGEMENT FEE "
                            HelpClass.MsgBox(MsgOperacion)
                        End If
                    Else
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                        HelpClass.MsgBox("No se puede enviar a facturación por no existir Fecha de Entrega en Almacén")
                        Exit Sub
                    End If
                End If

                If (Exito = True) Then
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    If oEmbarque.pCCLNT_PORTAL > 0 Then
                        If oEmbarque.pNOREMB.Length > 0 Then

                            oHebraCheckPointYRC_INFO_EMB = New Thread(AddressOf Enviar_Informacion_Embarcador)
                            oHebraCheckPointYRC_INFO_EMB.Start()

                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()


                            oHebraCheckPointYRC_COSTO_EMB = New Thread(AddressOf Enviar_Costos_Embarcador)
                            oHebraCheckPointYRC_COSTO_EMB.Start()

                        End If
                    End If
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                End If

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
                If (Not Me.dtgSegAduanero.Columns.Item(dtgCheckPoint.Rows(e.RowIndex).Cells("TABRST").Value) Is Nothing) Then
                    For intCont = 0 To Me.dtgSegAduanero.Rows.Count - 1
                        If Me.dblEmbSelec = Me.dtgSegAduanero.Rows(intCont).Cells("NORSCI").Value Then
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

                Dim ColName As String = dtgDocumentosAdjuntos.Columns(dtgDocumentosAdjuntos.CurrentCell.ColumnIndex).Name
                If ColName = "DOCCOSTO_LINK" Then
                    Me.ctmDocumentoAdjunto.Items(0).Visible = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Crear_Grilla_Documentos_Adjuntos()

        Dim oDcBx As DataGridViewComboBoxColumn
        oDcBx = CType(dtgDocumentosAdjuntos.Columns("DOCCOSTO_TDOCIN"), DataGridViewComboBoxColumn)

        oDcBx.DataSource = oEmbarque.Lista_Documento_Costo_Seguimiento
        oDcBx.DisplayMember = "NOMVAR"
        oDcBx.ValueMember = "VALVAR"

        oDcBx = CType(dtgDocumentosAdjuntos.Columns("DOCCOSTO_MONEDA"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = oMoneda.Lista_Moneda(1)
        oDcBx.DisplayMember = "TSGNMN"
        oDcBx.ValueMember = "CMNDA1"

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
        For intCont = 0 To oDt.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dtgDocumentosAdjuntos)
            'ADICION HABILITAR X ESTADO*************************************
            oDrVw.ReadOnly = IsEmbCerrado
            '***************************************************************
            dtgDocumentosAdjuntos.Rows.Add(oDrVw)
            Fila = dtgDocumentosAdjuntos.Rows.Count - 1

            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TDOCIN").Value = oDt.Rows(intCont).Item("NDOCIN").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TDOCIN").ReadOnly = True
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NDOCLI").Value = oDt.Rows(intCont).Item("NDOCUM").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONORG").Value = Double.Parse(oDt.Rows(intCont).Item("IVLORG").ToString.Trim)
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONEDA").Value = oDt.Rows(intCont).Item("CMNDA1")
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_MONDOL").Value = Double.Parse(oDt.Rows(intCont).Item("IVLDOL").ToString.Trim)
            If oDt.Rows(intCont).Item("URLARC").ToString.Trim <> vbNullString Then
                dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_LINK").Value = SOLMIN_SC.My.Resources.Resources.Archivo
            Else
                dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            End If
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_UPLOAT").Value = "..."
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_URLARC").Value = oDt.Rows(intCont).Item("URLARC").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TNMBAR").Value = oDt.Rows(intCont).Item("TNMBAR").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NORSCI").Value = oDt.Rows(intCont).Item("NORSCI").ToString.Trim
            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NCRRDC").Value = oDt.Rows(intCont).Item("NCRRDC").ToString.Trim

            dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_EXISTS").Value = 1

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
        Dim PSNDOCLI As String = ""
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
        obeDocumentoCosto.PSTNMBAR = ("" & dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TNMBAR").Value).ToString.Trim
        obeDocumentoCosto.PNNCRRDC = dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NCRRDC").Value
        obeDocumentoCosto.PSNDOCUM = ("" & dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NDOCLI").Value).ToString.Trim
        obeDocumentoCosto.PSURLARC = ("" & dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_URLARC").Value).ToString.Trim

        If dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TDOCIN").Value = 106 Then
            Dim strArr() As String
            PSNDOCLI = ("" & dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_NDOCLI").Value).ToString.Trim
            strArr = PSNDOCLI.Split("-")
            If strArr.Length = 1 Then
                strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & Mid(PSNDOCLI, 8, 2)
                strRuta = strRuta & "&codaduana=" & Mid(PSNDOCLI, 1, 3)
                strRuta = strRuta & "&anoprese=" & Mid(PSNDOCLI, 4, 4)
                strRuta = strRuta & "&numecorre=" & Mid(PSNDOCLI, 10, 6)
            Else
                strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & strArr(2)
                strRuta = strRuta & "&codaduana=" & strArr(0)
                strRuta = strRuta & "&anoprese=" & strArr(1)
                strRuta = strRuta & "&numecorre=" & strArr(3)
            End If
            obeDocumentoCosto.PSURLARC = strRuta
            oDocApertura.Grabar_Documentos_Costos_Embarque(obeDocumentoCosto)
            Actualizar_Grilla(ACTUALIZACION_GRILLA.DUA, PSNDOCLI)
        Else
            oDocApertura.Grabar_Documentos_Costos_Embarque(obeDocumentoCosto)
        End If

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
        Llenar_Documentos_Adjuntos()
        Limpiar_Informacion()
        Cargar_Informacion_Embarque()
        '==============ACD ===============
        'Distribuir_Costos_Embarque()
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
            If e.RowIndex > -1 Then
                If e.ColumnIndex = 1 Then
                    Dim frm As New frmBuscarDocCosto(Me.dblEmbSelec, sender.Rows(e.RowIndex).Cells("VALVAR").Value.ToString.Trim)
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        oDs.Tables.Item(sender.Rows(e.RowIndex).Cells("CVARBL").Value.ToString.Trim).Rows(e.RowIndex).Item("TOBS") = Lista_Documento_Costo_X_Costo_Total(sender.Rows(e.RowIndex).Cells("VALVAR").Value.ToString.Trim)
                    End If
                End If
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
        'ADICIONADO
        '-------------------------------------------
        oDt.Columns.Add(New DataColumn("CHKCOSTO"))
        '--------------------------------------------


        oDt.TableName = pstrDescripcion
        oDs.Tables.Add(oDt.Copy)
        oDtgVar.DataSource = oDs.Tables.Item(pstrDescripcion)

        oDtgVar.Columns(0).Visible = False
        oDtgVar.Columns(1).Visible = False



        oDtgVar.Columns(2).HeaderText = "Concepto"
        oDtgVar.Columns(2).Width = 250
        oDtgVar.Columns(2).Resizable = DataGridViewTriState.False
        oDtgVar.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns(2).ReadOnly = True

        oDtgVar.Columns(3).HeaderText = "Monto (Moneda Origen)"
        oDtgVar.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDtgVar.Columns(3).DefaultCellStyle.Format = "D2"
        oDtgVar.Columns(3).Resizable = DataGridViewTriState.False
        oDtgVar.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDtgVar.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDtgVar.Columns(3).Width = 150

        oDtgVar.Columns(4).HeaderText = "Monto Dolares"
        oDtgVar.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDtgVar.Columns(4).DefaultCellStyle.Format = "D2"
        oDtgVar.Columns(4).Resizable = DataGridViewTriState.False
        oDtgVar.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDtgVar.Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        oDtgVar.Columns(5).HeaderText = "Referencia"
        oDtgVar.Columns(5).Resizable = DataGridViewTriState.False
        oDtgVar.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        oDtgVar.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDtgVar.Columns(5).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        oDtgVar.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDtgVar.Columns(5).ReadOnly = True
        oDtgVar.Columns(5).Width = 250

        oDtgVar.Columns(6).Visible = False
        oDtgVar.Columns(7).Visible = False

        'ADICIONADO
        '------------------------------
        oDtgVar.Columns(8).Visible = False
        '---------------------------------


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
                    Actualizar_Grilla(ACTUALIZACION_GRILLA.COSTOS)
                End If
            Next
        Next

        If (oListConceptosDistribucion.Count > 0) Then
            Dim oclsCostoItem As New Negocio.clsCostoItem
            oclsCostoItem.Distribuir_Costos_Ordenes_Embarcadas(oEmbarque.pCCLNT, oEmbarque.pNORSCI, oListConceptosDistribucion)
        End If
        '===============================QUITANDO CHECKS===============================
        For intCont = 0 To oDs.Tables.Count - 1
            For intRow = 0 To CType(TabControl3.Controls("tab" & intCont).Controls(0), DataGridView).Rows.Count - 1
                '-------------------------------------------------------------------   
                objeto = CType(TabControl3.Controls("tab" & intCont).Controls(0), DataGridView).Rows(intRow).Cells("COSTEO").Value
                If (objeto IsNot DBNull.Value Or objeto IsNot Nothing) Then
                    If (objeto = "True") Then
                        CType(TabControl3.Controls("tab" & intCont).Controls(0), DataGridView).Rows(intRow).Cells("COSTEO").Value = False
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
            Next
        Next
    End Sub

    Private Sub LLenar_Costos_Totales_X_Embarque()
        Dim intCont, intContTablas, intRow As Integer
        Dim oDt As DataTable
        Dim oBj As Object
        Dim Suma As Double = 0
        Dim SumaDol As Double = 0
        oDt = oDocApertura.Lista_Costos_Totales_Embarque(Me.dblEmbSelec).Tables("dtCosto")
        For intCont = 0 To oDs.Tables.Count - 1
            For intContTablas = 0 To oDs.Tables.Item(intCont).Rows.Count - 1
                For intRow = 0 To oDt.Rows.Count - 1
                    If oDs.Tables.Item(intCont).Rows(intContTablas).Item("VALVAR").ToString = oDt.Rows(intRow).Item("CODVAR").ToString Then
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("IVLORG") = Double.Parse(oDt.Rows(intRow).Item("IVLORG"))
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("IVLDOL") = Double.Parse(oDt.Rows(intRow).Item("IVLDOL"))
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("TOBS") = Lista_Documento_Costo_X_Costo_Total(oDs.Tables.Item(intCont).Rows(intContTablas).Item("VALVAR").ToString)
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("CMNDA1") = oDt.Rows(intRow).Item("CMNDA1")
                        oDs.Tables.Item(intCont).Rows(intContTablas).Item("NMONOC") = oDt.Rows(intRow).Item("NMONOC")
                        oBj = Me.TabControl3.Controls.Item("tab" & intCont).Controls.Item(oDs.Tables.Item(intCont).Rows(intContTablas).Item("CVARBL").ToString.Trim)
                        oBj.Rows(intContTablas).Cells("MONEDA").Value = oDt.Rows(intRow).Item("CMNDA1")
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
        Dim gv As DataGridView
        Dim NameGridView As String = ""
        For FILA_TABLAS = 0 To oDs.Tables.Count - 1
            odtDatoCosto = oDs.Tables.Item(FILA_TABLAS)
            If (odtDatoCosto.Rows.Count > 0) Then
                NameGridView = odtDatoCosto.Rows(0).Item("CVARBL").ToString.Trim
                gv = CType(Me.TabControl3.Controls.Item("tab" & FILA_TABLAS).Controls.Item(NameGridView), DataGridView)
                For Each dgv As DataGridViewRow In gv.Rows
                    dgv.ReadOnly = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
                Next
            End If
        Next
    End Sub
    Private Function Lista_Documento_Costo_X_Costo_Total(ByVal strCodVariable As String) As String
        Dim strDato As String = ""
        Dim intCont As Integer
        Dim oDt As DataTable
        oDt = oDocApertura.Lista_Documentos_Costo_X_Costo_Total_Embarque(Me.dblEmbSelec, strCodVariable)
        For intCont = 0 To oDt.Rows.Count - 1
            If oDt.Rows.Count - 1 = intCont Then
                strDato = strDato & oDt.Rows(intCont).Item("NOMVAR").ToString.Trim & "  N° " & oDt.Rows(intCont).Item("NDOCUM").ToString.Trim
            Else
                strDato = strDato & oDt.Rows(intCont).Item("NOMVAR").ToString.Trim & "  N° " & oDt.Rows(intCont).Item("NDOCUM").ToString.Trim & Chr(10)
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
                        oBj = Me.TabControl3.Controls.Item("tab" & intContTabla).Controls.Item(oDs.Tables.Item(intContTabla).Rows(intRow).Item("CVARBL").ToString.Trim)
                        If oBj.SelectedRows.Count > 0 Then
                            obeCostoTotalEmbarque = New beCostoTotalEmbarque
                            obeCostoTotalEmbarque.PNNORSCI = Me.dblEmbSelec
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
            Dim odtgCosto As New DataGridView
            Dim intCont As Integer
            Dim oBj As Object
            Dim COLUMNA As Int32 = 0
            Dim VALVAR As String = ""
            If (TabControl3.SelectedIndex > 0) Then
                For intCont = 0 To oDs.Tables.Item(TabControl3.SelectedIndex - 1).Rows.Count - 1
                    oBj = sender.Controls.Item("tab" & TabControl3.SelectedIndex - 1).Controls.Item(oDs.Tables.Item(TabControl3.SelectedIndex - 1).Rows(intCont).Item(0).ToString.Trim)
                    odtgCosto = CType(oBj, DataGridView)
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
            Item3(False)
        Else
            Me.STSCHG1 = False
            Item2(True)
            Item3(True)
        End If
        If objEntidadAcceso.STSOP1 = "" Then
            'Acceso_SeguientoAduanero_Cambiar(False)
            Me.STSOP11 = True
        Else
            'Acceso_SeguientoAduanero_Cambiar(True)
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

    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New Negocio.clsAcceso
        Dim objUsuario As New Negocio.clsUsuario
        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objUsuario.GetUserName)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidadAcceso = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
        Accesos(objEntidadAcceso)
    End Sub

    Private Sub Acceso_OrdenesEmbarcadas_Adicionar(ByVal Estado As Boolean)
        btnAgregarDocumentoCosto.Visible = Estado
        btnAgregar.Visible = Estado
        btnAgregarCarga.Visible = Estado
        btnAgregarObservaciones.Visible = Estado
        btnGrabar.Visible = Estado
        btnServicio.Visible = Estado
    End Sub

    Private Sub Acceso_OrdenesEmbarcadas_Eliminar(ByVal Estado As Boolean)
        btnAnularEmbarque.Visible = Estado
        btnCerrarEmbarque.Visible = Estado
    End Sub

    Private Sub Item2(ByVal Estado As Boolean)
        Me.ctbAgenteDeCarga.Enabled = Estado
        Me.ctbMedioTransportes.Enabled = Estado
        Me.ctbTerminal.Enabled = Estado
        Me.cmbPaisOrg.Enabled = Estado
        Me.cmbPuertoOrg.Enabled = Estado
        Me.mskETD.Enabled = Estado
        Me.btnETD.Enabled = Estado
        Me.cmbPaisDest.Enabled = Estado
        Me.cmbPuertoDest.Enabled = Estado
        Me.mskETA.Enabled = Estado
        Me.btnETA.Enabled = Estado

        txtPolizaNum.Enabled = Estado
        txtPolizaMonto.Enabled = Estado

        Me.cmbPolizaBanco.Enabled = Estado
        Me.mskPolizaFecEmi.Enabled = Estado
        Me.mskPolizaFecVen.Enabled = Estado
        Me.cmbPolizaMoneda.Enabled = Estado
        Me.btnImpInfEmb.Enabled = Estado


        'ADICION  DE VALIDACION 
        Me.txtNroOS.Enabled = Estado
        Me.cboCanal.Enabled = Estado
        Me.cboRegimen.Enabled = Estado
        Me.Uc_Almacen_Local.Enabled = Estado
        Me.txtRefDoc.Enabled = Estado
        txtRefCli.Enabled = Estado
        Me.txtMercaderia.Enabled = Estado
        Me.txtDUA.Enabled = Estado
        Me.txtBeneficio.Enabled = Estado
        Me.uc_Transportista.Enabled = Estado
        Me.txtDireccion.Enabled = Estado
        Me.txtHorario.Enabled = Estado
        Me.txtObservacion.Enabled = Estado
        Me.txtContacto.Enabled = Estado


        txtDiaLibre.Enabled = Estado
        txtKg.Enabled = Estado
        txtM3.Enabled = Estado
        txtSobreEstadia.Enabled = Estado


    End Sub

    Private Sub Item3(ByVal Estado As Boolean)
        Me.cmbZona.Enabled = Estado
        Me.mskApertura.Enabled = Estado
        Me.UcProveedor_tab.Enabled = Estado
        Me.cmbTipoDespachos.Enabled = Estado
        Me.cmbTransporte.Enabled = Estado
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
            If (e.RowIndex < 0) Then Exit Sub
            If (e.ColumnIndex = 2) Then
                If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
                sender.EndEdit()
                oDs.Tables.Item(sender.NAME.ToString()).Rows(e.RowIndex).Item("CHKCOSTO") = sender.Rows(e.RowIndex).Cells("COSTEO").Value.ToString
            End If
            Dim gvCostos As New DataGridView
            gvCostos = CType(sender, DataGridView)
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
            btnExportarXLS.Visible = True
            dtgSegAduanero.Visible = True
            dtgSegAduaneroReducido.Visible = False
            Limpiar_Informacion()
            VisualizarIdioma(True)
        Else
            Accesos(objEntidadAcceso)
            dtgSegAduanero.Visible = False
            dtgSegAduaneroReducido.Visible = True
            btnExportarXLS.Visible = False
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
        PARAM_PSTNMBCM = Me.dtgSegAduanero.Columns(e.ColumnIndex).Name
        IndexColumna = e.ColumnIndex
        FilaEmbarque = e.RowIndex
        oclsCheckPointEnvio = New clsCheckPointEnvio
        Dim obeCheckPointFind As beCheckPointEnvio
        If (oclsCheckPointEnvio.DebeNotificarEnvio__X_Cliente(oEmbarque.pCCLNT)) Then
            obeCheckPointFind = oclsCheckPointEnvio.ExisteChkEnvioxPSTNMBCM(PARAM_PSTNMBCM)
            If (obeCheckPointFind IsNot Nothing) Then
                oclsCheckPointEnvio.ListaDatosCheckPointInicial(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
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
        If bolBuscarSegAdu Then
            If Me.cmbTransporte.SelectedValue = 3 Then
                Me.txtTransTercero.Visible = True
            Else
                Me.txtTransTercero.Visible = False
            End If
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
                Item3(False)
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
                '.CCMPN = "EZ"
                '.CDVSN = "S"
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
            Grabar_DocAdj(intPosicion)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub tsmDelChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelChk.Click
        Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        If IsCerrado Then Exit Sub
        Me.dtgCheckPoint.CurrentCell.Value = ""
        Grabar_Checkpoint()
    End Sub

    Private Sub tsmQuitarArchDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmQuitarArchDoc.Click
        Try
            Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            If IsCerrado Then Exit Sub

            If (dtgDocumentosAdjuntos.Rows.Count > 0) Then
                Dim Fila As Int32 = dtgDocumentosAdjuntos.CurrentCell.RowIndex
                dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_URLARC").Value = ""
                dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_TNMBAR").Value = ""
                dtgDocumentosAdjuntos.Rows(Fila).Cells("DOCCOSTO_LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsmBorrarCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmBorrarCosto.Click
        Try
            Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            If IsCerrado Then Exit Sub

            Borrar_Costo_Total()
            Me.Limpiar_Costos_Totales_X_Embarque()
            Me.LLenar_Costos_Totales_X_Embarque()
            Actualizar_Grilla(ACTUALIZACION_GRILLA.COSTOS)
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
            If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then Exit Sub
            Dim ColName As String = ""
            Dim strCadena As String
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                intPosicion = e.RowIndex
                ColName = dtgDocumentosAdjuntos.Columns(e.ColumnIndex).Name
                Select Case ColName
                    Case "DOCCOSTO_UPLOAT"
                        If dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_NORSCI").Value.ToString = 0 Then
                            HelpClass.MsgBox("Debe grabar antes la información para poder subir una imagen")
                            Exit Sub
                        End If
                        strCadena = dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_NORSCI").Value.ToString & "_" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_NCRRDC").Value.ToString & "_" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_TDOCIN").Value.ToString
                        Dim objfrmSACE As New frmSubirArchivoCostoEmbarque(strCadena)
                        If objfrmSACE.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Dim objCargarImagen As New Negocio.clsImageWebUpload
                            If objCargarImagen.ExisteImagen(HelpUtil.getSetting("URL_COSTO_CARPETA"), strCadena & objCargarImagen.GetFileExtencion(HelpUtil.getSetting("URL_COSTO_CARPETA"), strCadena)) Then
                                dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_URLARC").Value = HelpUtil.getSetting("URL_ADJ_SIL_COSTO")
                                '"http://asp.ransa.net/wapmineria/imagenes/solmin/SOLMIN_SC/COSTOS_EMBARQUE/"
                                '"http://asp.ransa.net/wapmineria/imagenes/solmin/SOLMIN_SC/"
                                dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_TNMBAR").Value = strCadena & objCargarImagen.GetFileExtencion("SOLMIN_SC\COSTOS_EMBARQUE", strCadena)
                                dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_LINK").Value = SOLMIN_SC.My.Resources.Resources.Archivo
                                Grabar_Documentos_Costos_Embarque(e.RowIndex)
                            End If
                        End If

                    Case "DELETE_DOCCOSTO"

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
                                    Actualizar_Datos(obeDocumentoCosto.PNNORSCI, "NUMDUA", "")
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
                        If ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_TNMBAR").Value).ToString.Trim.Length > 0 Then
                            PSURLARC = ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_URLARC").Value).ToString.Trim
                            Dim URLARC As String = ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_URLARC").Value).ToString.Trim
                            Dim TNMBAR As String = ("" & dtgDocumentosAdjuntos.Rows(e.RowIndex).Cells("DOCCOSTO_TNMBAR").Value).ToString.Trim
                            Dim url_completo As String = URLARC & TNMBAR
                            Process.Start(url_completo)
                        End If
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    'Private Sub cboRegimen_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegimen.SelectionChangeCommitted
    '    Dim COD_REG As Decimal = cboRegimen.SelectedValue
    '    Dim IsVisible As Boolean = IsRegimenTemporal(COD_REG)
    '    lblFechaVencImport.Visible = IsVisible
    '    mskFVencRegimen.Visible = IsVisible
    '    'lblFechaIniImport.Visible = IsVisible
    '    'mskFInicioRegimen.Visible = IsVisible
    'End Sub


    Private Sub cboRegimen_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegimen.SelectionChangeCommitted
        Try
            Dim COD_REG As Decimal = cboRegimen.SelectedValue
            Dim IsVisible As Boolean = IsRegimenTemporal(COD_REG)
            lblFechaVencImport.Visible = IsVisible
            mskFVencRegimen.Visible = IsVisible
            Dim oListRegimen As New List(Of beOperacionRegimen)
            PNTPORGE = cboRegimen.SelectedValue
            If PNTPORGE > 0 Then
                Dim pred As New Predicate(Of beOperacionRegimen)(AddressOf BuscarOperacionRegimen)
                oListRegimen = oListGenOperacionRegimen.FindAll(pred)
            End If
            Dim obeOperacionRegimen As New beOperacionRegimen
            obeOperacionRegimen.PNTPOPRG = -1
            obeOperacionRegimen.PSTCMPRO = "::Seleccione::"
            oListRegimen.Insert(0, obeOperacionRegimen)
            cboRegOperacion.DataSource = oListRegimen
            cboRegOperacion.DisplayMember = "PSTCMPRO"
            cboRegOperacion.ValueMember = "PNTPOPRG"
            cboRegOperacion.SelectedValue = -1D
            'lblFechaIniImport.Visible = IsVisible
            'mskFInicioRegimen.Visible = IsVisible
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

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            Try
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

    Private Sub gvOrdenesEmb_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvOrdenesEmb.CellClick
        Dim ColName As String = ""
        Dim CCLNT As Decimal = 0
        Dim NORSCI As Decimal = 0
        Dim NRPEMB As Decimal = 0
        Dim NORCML As String = ""
        Dim NRITEM As Decimal = 0
        Dim SBITOC As String = ""
        Dim Fila As Int32 = e.RowIndex
        Dim Columna As Int32 = e.ColumnIndex
        Try
            If Columna >= 0 AndAlso Fila >= 0 Then
                ColName = gvOrdenesEmb.Columns(e.ColumnIndex).Name
                If gvOrdenesEmb.CurrentRow IsNot Nothing Then
                    If ColName = "btnEliminarItem" Then
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
                                gvOrdenesEmb.Rows.RemoveAt(e.RowIndex)
                                MessageBox.Show("Debe nuevamente distribuir los costos", "Aviso", MessageBoxButtons.OK)
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImportarAgencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarAgencia.Click
        Try
            'Dim oListRegimen As New List(Of beTipoDato)
            Dim oListRegimen As New List(Of beRegimen)

            Dim oListDespacho As New List(Of beTipoDato)
            Dim obeRegimen As New beTipoDato
            'Dim oCloneList As New CloneObject(Of beTipoDato)
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
                'oListRegimen = oCloneList.CloneListObject(oListGenRegimen)
                oListRegimen = oCloneListRegimen.CloneListObject(oListGenRegimen)
                oListDespacho = oCloneList.CloneListObject(oListGenTipoDespacho)
                frm = New frmImportarAgencia_2(oEmbarque.pCCMPN, oEmbarque.pCDVSN, oEmbarque, oListDespacho, oListRegimen, oEmbarque.pCMEDTR)
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Limpiar_Informacion()
                    Cargar_Informacion_Embarque()
                    Llenar_CheckPoint()

                    If oEmbarque.pCCLNT_PORTAL > 0 Then
                        If oEmbarque.pNOREMB.Length > 0 Then
                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB = New Thread(AddressOf Enviar_Items_Embarcador_CheckPoint)
                            oHebraCheckPointYRC_ITEM_EMB_CHK_EMB.Start()

                            oHebraCheckPointYRC_COSTO_EMB = New Thread(AddressOf Enviar_Costos_Embarcador)
                            oHebraCheckPointYRC_COSTO_EMB.Start()

                        End If
                    End If
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
            oFrmConsultaEmbarque = New FrmConsultaEmbarque(oEmbarque.pCCMPN, oEmbarque.pCCLNT, NORSCI_REG, FrmConsultaEmbarque.ENUM_TIPO_EMBARQUE.IM)
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

End Class

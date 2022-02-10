Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports IBM.Data.DB2
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports System.Xml
Imports System.Text
Public Class frmGenTarifaAdmin
   

     
    Private oCentroCosto As New SOLMIN_CTZ.NEGOCIO.clsCentroCosto
    Private oClaseGeneral As New SOLMIN_CTZ.NEGOCIO.clsClaseGeneral
   
    Private oNegTarifa As New SOLMIN_CTZ.NEGOCIO.clsTarifa

    Private oTarifa As New SOLMIN_CTZ.Entidades.Tarifa
    Private oContrato As New SOLMIN_CTZ.Entidades.Contrato
    Private oRango As New SOLMIN_CTZ.Entidades.Rango
    Private frmContrato As frmListaTarifas
    Private oTarifaDescripciones As New SOLMIN_CTZ.Entidades.Tarifa
   
    Private _ListaRango As New List(Of Tarifa)
    Private obj_tarifa As Tarifa
    Private obj_contrato As Contrato
    
    Private bolClienteInterno As Boolean
     

    Dim dsMelsap As DataSet
    Private imputCeBe As New beImputCeBe 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private imputCeCo As New beImputCeCo 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Private lbeCeCoTarifario As New List(Of CentroCostoTarifa)
    Private _pCodigoCompania As String = ""

    
    Public Property pCodigoCompania() As String
        Get
            Return _pCodigoCompania
        End Get
        Set(ByVal value As String)
            _pCodigoCompania = value
        End Set
    End Property




    Enum EnumTipo
        Neutro
        Edicion
        Nuevo
    End Enum
    Private Tipo As EnumTipo = EnumTipo.Neutro

    Sub New(ByVal pobjfrm As frmListaTarifas, ByVal objTarifa As Object, ByVal objContrato As Object, ByVal objRango As Object, ByVal pEnumTipo As EnumTipo)

        Tipo = pEnumTipo
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        frmContrato = pobjfrm

        oTarifa = CType(objTarifa, Tarifa)
        If Not IsNothing(objRango) Then
            oRango = CType(objRango, Rango)

        Else

        End If

        oContrato = CType(objContrato, SOLMIN_CTZ.Entidades.Contrato)

        '_Tipo = pEnumTipo
    End Sub



    Public ReadOnly Property GetTarifa() As Tarifa
        Get
            Return obj_tarifa
        End Get
    End Property

    Private Sub frmDefTarifa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Me.UcDivision.pHabilitado = True
            Me.UcPLanta_Cmb011.pHabilitado = True
            Me.UcPLanta_Cmb011.pRequerido = True
            'Me.UcDivision.pRequerido = True
            Crea_Division()

            cboDivision_SelectionChangeCommitted(cboDivision, Nothing)

            Dim oCliente As New clsCliente
            bolClienteInterno = oCliente.Validar_Cliente_Interno(oTarifa.CCMPN, oTarifa.NRCTSL).Count > 0
            Mostrar_Controles_Cliente_Interno(bolClienteInterno)
            If bolClienteInterno = True Then
                Cargar_CentroCosto_Origen()
            End If

            Dim tarifa As Tarifa = oTarifa
            Dim olCentroBeneficio As New List(Of CentroCosto)
            'If Not PerteneceASalmon(Me.pCodigoCompania) Then
            '    olCentroBeneficio = oCentroCosto.Lista_CentroBeneficio(tarifa.CCMPN, "", "", "", "", "", "", "")  'JM
            '    cmbCentroBeneficio.DataSource = olCentroBeneficio
            'End If

            dsMelsap = (New clsTarifa).Cargar_Datos_Generales_Tarifa_Transporte(oTarifa)


            


            Dim oFiltroPlanta As New SOLMIN_CTZ.Entidades.Filtro
            ListarTipoTarifa()
            cboTipoTarifa.SelectedValue = "C"
            cboTipoTarifa_SelectionChangeCommitted(cboTipoTarifa, Nothing)

            txtCodTarifa.Text = oTarifa.NRTFSV
            Dim dtPlanta As New DataTable()
         
            oCentroCosto = New SOLMIN_CTZ.NEGOCIO.clsCentroCosto

            
            CargarTipoMaterial()
            CargarTipoAlmacen()
            Listar_TipoActivo_SAP()
            Cargar_Moneda()
            Cargar_UnidadMedida()



            If Not PerteneceASalmon(Me.pCodigoCompania) Then
                'Cargar_CentroBeneficio()
                Dim oListColum, oListColum2, oListColum3 As New Hashtable
                Dim oColumnas As New DataGridViewTextBoxColumn

                oColumnas.Name = "PNCCNTCS"
                oColumnas.DataPropertyName = "PNCCNTCS"
                oColumnas.HeaderText = "Código"
                oListColum3.Add(1, oColumnas.Clone()) 'RCS-HUNDRED

                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "PSTCNTCS"
                oColumnas.DataPropertyName = "PSTCNTCS"
                oColumnas.HeaderText = "Centro de Beneficio"
                oListColum3.Add(2, oColumnas.Clone()) 'RCS-HUNDRED


                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "PSCCNBNS"
                oColumnas.DataPropertyName = "PSCCNBNS"
                oColumnas.HeaderText = "Ce.Be SAP"
                oListColum3.Add(3, oColumnas.Clone())

                olCentroBeneficio = oCentroCosto.Lista_CentroBeneficio(tarifa.CCMPN, "", "", "", "", "", "", "")  'JM
                cmbCentroBeneficio.DataSource = olCentroBeneficio


                cmbCentroBeneficio.ListColumnas = oListColum3
                cmbCentroBeneficio.Cargas()
                cmbCentroBeneficio.ValueMember = "PNCCNTCS"
                cmbCentroBeneficio.DispleyMember = "PSCCNBNS"
            End If

            Select Case Tipo
                Case EnumTipo.Edicion
                    Cargar_Tarifa()
                    If oTarifa.SESTRG = "P" Then
                        Habilitar_Controles_Tarifa(True)
                    Else
                        tsBarraRango.Enabled = False
                        Habilitar_Controles_Tarifa(False)
                    End If
                Case EnumTipo.Nuevo
                    Habilitar_Controles_Tarifa(True)
            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub Habilitar_Controles_Tarifa(ByVal bolEstado As Boolean)


        txtCantidad.Enabled = bolEstado
        txtMonto.Enabled = bolEstado
        txtDescripcion.Enabled = bolEstado
        txtTarifa.Enabled = bolEstado
        txtPeriodoLibre.Enabled = bolEstado

        'cboDivision.Enabled = bolEstado
        txtDiasFacturar.Enabled = bolEstado

        chkPeriodoLibre.Enabled = bolEstado
        cmbUnidadMedida.Enabled = bolEstado
        cmbMoneda.Enabled = bolEstado

        btnGrabarTarifa.Enabled = bolEstado

        'dtgRangoTarifa.Enabled = bolEstado
        'cboLogicaFacturacion.Enabled = bolEstado

        TxtTipoMaterial.Enabled = bolEstado
        txtTipoAlmacen.Enabled = bolEstado
        txtCodTarifaRef.Enabled = bolEstado
        txtDiasdeCorte.Enabled = bolEstado

        'cboPlantaFact.Enabled = bolEstado 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        If cboTipoTarifa.SelectedValue = "R" Then
            txtCantidad.Enabled = False
            txtMonto.Enabled = False
            txtMonto.Text = ""
        End If

        '<[AHM]>
        txtTipoServicio.Enabled = bolEstado
        txtUnidadProductiva.Enabled = bolEstado
        cboTipoActivo.Enabled = bolEstado
        cmbCentroBeneficio.Enabled = bolEstado

        dtgRangoTarifa.Enabled = bolEstado


        cboServicio.Enabled = bolEstado

        '</[AHM]>
        'Habilitar_CentCosto_Cliente_Interno(bolEstado) 'RCS-HUNDRED
    End Sub

    Private Sub ListarTipoTarifa()

        Dim dt As New DataTable
        dt.Columns.Add("DISPLAY")
        dt.Columns.Add("VALUE")
        Dim dr As DataRow
        dr = dt.NewRow
        dr("DISPLAY") = "Fija"
        dr("VALUE") = "F"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Cantidad"
        dr("VALUE") = "C"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Rango"
        dr("VALUE") = "R"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Rango Viajes"
        dr("VALUE") = "V"
        dt.Rows.Add(dr)


        dr = dt.NewRow
        dr("DISPLAY") = "Días Permanencia"
        dr("VALUE") = "D"
        dt.Rows.Add(dr)


        dr = dt.NewRow
        dr("DISPLAY") = "Día/Semana de permanencia"
        dr("VALUE") = "S"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Día/Quincena de permanencia"
        dr("VALUE") = "Q"
        dt.Rows.Add(dr)


        dr = dt.NewRow
        dr("DISPLAY") = "Día/Mes de permanencia"
        dr("VALUE") = "M"
        dt.Rows.Add(dr)


        For Each Item As DataRow In dt.Rows
            Item("DISPLAY") = Item("VALUE") & "-" & Item("DISPLAY")
        Next

        cboTipoTarifa.DataSource = dt
        cboTipoTarifa.DisplayMember = "DISPLAY"
        cboTipoTarifa.ValueMember = "VALUE"

    End Sub

    Private Sub Crea_Division()

        'UcDivision.Compania = oTarifa.CCMPN
        'UcDivision.Usuario = ConfigurationWizard.UserName
        'UcDivision.pActualizar()

        Dim oDivisionBL As New clsDivision
        Dim dt As New DataTable
        dt = oDivisionBL.Lista_Division_X_CompaniaUsuario(oTarifa.CCMPN, ConfigurationWizard.UserName)
        cboDivision.DataSource = dt
        cboDivision.DisplayMember = "TCMPDV"
        cboDivision.ValueMember = "CDVSN"

    End Sub



    

    Private Sub ListarServicio()

        Dim oServicioNeg As SOLMIN_CTZ.NEGOCIO.clsServicio
        oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        oFiltro.Parametro1 = oTarifa.CCMPN
        oFiltro.Parametro2 = cboDivision.SelectedValue

        cboServicio.ListColumnas = Nothing

        cboServicio.DataSource = Nothing

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn



        oColumnas.Name = "COD_SERV"
        oColumnas.DataPropertyName = "COD_SERV"
        oColumnas.HeaderText = "CÓDIGO"
        oColumnas.Visible = False
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NRSRRB"
        oColumnas.DataPropertyName = "NRSRRB"
        oColumnas.HeaderText = "Cod. Servicio"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NOMSER"
        oColumnas.DataPropertyName = "NOMSER"
        oColumnas.HeaderText = "Servicio"
        oListColum.Add(3, oColumnas)


        Dim olRubxServ As New List(Of Servicio_X_Rubro)
        olRubxServ = oServicioNeg.Lista_Servicio_X_Compania_Division(oFiltro)

        'Se esta cargando la planta por defecto 1 (CAllao)
        If olRubxServ.Count > 0 Then
            cboServicio.DataSource = olRubxServ
        Else
            cboServicio.DataSource = Nothing
        End If
        cboServicio.ListColumnas = oListColum
        cboServicio.Cargas()
        cboServicio.Limpiar()
        cboServicio.ValueMember = "COD_SERV"
        cboServicio.DispleyMember = "NOMSER"

    End Sub




    

    

    Private Sub Cargar_Moneda()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CMNDA1"
        oColumnas.DataPropertyName = "CMNDA1"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMNDA"
        oColumnas.DataPropertyName = "TMNDA"
        oColumnas.HeaderText = "Moneda"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TSGNMN"
        oColumnas.DataPropertyName = "TSGNMN"
        oColumnas.HeaderText = "Símbolo"
        oListColum.Add(3, oColumnas)

        Dim oMoneda As New SOLMIN_CTZ.NEGOCIO.clsMoneda
        Dim olMoneda As New List(Of Moneda)
        olMoneda = oMoneda.Listar_Moneda

        If olMoneda.Count > 0 Then
            cmbMoneda.DataSource = olMoneda
        Else
            cmbMoneda.DataSource = Nothing
        End If
        cmbMoneda.ListColumnas = oListColum
        cmbMoneda.Cargas()
        cmbMoneda.Limpiar()
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.DispleyMember = "TSGNMN"

    End Sub

    Private Sub Cargar_UnidadMedida()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CUNDMD"
        oColumnas.DataPropertyName = "CUNDMD"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPUN"
        oColumnas.DataPropertyName = "TCMPUN"
        oColumnas.HeaderText = "Unidad de Medida"
        oListColum.Add(2, oColumnas)

        Dim oListColum2 As New Hashtable
        Dim oColumnas2 As New DataGridViewTextBoxColumn
        oColumnas2.Name = "CUNDMD"
        oColumnas2.DataPropertyName = "CUNDMD"
        oColumnas2.HeaderText = "Código"
        oListColum2.Add(1, oColumnas2)

        oColumnas2 = New DataGridViewTextBoxColumn
        oColumnas2.Name = "TCMPUN"
        oColumnas2.DataPropertyName = "TCMPUN"
        oColumnas2.HeaderText = "Unidad de Medida"
        oListColum2.Add(2, oColumnas2)


        Dim oUM As New SOLMIN_CTZ.NEGOCIO.clsUM
        Dim olUM As New List(Of mantenimientos.ClaseGeneral)
        olUM = oUM.Listar_UnidadMedida()


         
        If olUM.Count > 0 Then
            cmbUnidadMedida.DataSource = olUM
        Else
            cmbUnidadMedida.DataSource = Nothing
        End If
        cmbUnidadMedida.ListColumnas = oListColum2
        cmbUnidadMedida.Cargas()
        cmbUnidadMedida.Limpiar()
        cmbUnidadMedida.ValueMember = "CUNDMD"
        cmbUnidadMedida.DispleyMember = "TCMPUN"


    End Sub

    Private Sub CargaCeBe_x_Id(CeBe As Decimal)

        Dim oListColum3 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum3.Add(1, oColumnas) 'RCS-HUNDRED

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Beneficio"
        oListColum3.Add(2, oColumnas) 'RCS-HUNDRED

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCNBNS"
        oColumnas.DataPropertyName = "PSCCNBNS"
        oColumnas.HeaderText = "Ce.Be SAP"
        oListColum3.Add(3, oColumnas)
       

 
        Dim olCentroBeneficio As New List(Of CentroCosto)

        olCentroBeneficio = oCentroCosto.Listar_CentroBeneficio_Id(oTarifa.CCMPN, CeBe)

        If olCentroBeneficio.Count > 0 Then
            cmbCentroBeneficio.DataSource = olCentroBeneficio 'RCS-HUNDRED
        Else
            cmbCentroBeneficio.DataSource = Nothing 'RCS-HUNDRED
        End If

        cmbCentroBeneficio.ListColumnas = oListColum3
        cmbCentroBeneficio.Cargas()
        cmbCentroBeneficio.ValueMember = "PNCCNTCS"
        cmbCentroBeneficio.DispleyMember = "PSCCNBNS"
        'cmbCentroBeneficio.DispleyMember = "PSTCNTCS"

    End Sub

    Private Sub Cargar_CentroBeneficio()
        Dim oListColum, oListColum2, oListColum3 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oListColum2.Add(1, oColumnas.Clone()) 'RCS-HUNDRED
        oListColum3.Add(1, oColumnas.Clone()) 'RCS-HUNDRED

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Beneficio"
        oListColum.Add(2, oColumnas)
        oListColum2.Add(2, oColumnas.Clone()) 'RCS-HUNDRED
        oListColum3.Add(2, oColumnas.Clone()) 'RCS-HUNDRED


        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCNBNS"
        oColumnas.DataPropertyName = "PSCCNBNS"
        oColumnas.HeaderText = "Ce.Be SAP"
        oListColum.Add(3, oColumnas)
        oListColum2.Add(3, oColumnas.Clone())
        oListColum3.Add(3, oColumnas.Clone())


        Dim olCentroBeneficio As New List(Of CentroCosto)
        Dim olCentroCostoTercero As New List(Of CentroCosto)

        Dim tarifa As Tarifa = oTarifa
        Dim macroServicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
        Dim TipoServicio As ClaseGeneral = CType(txtTipoServicio.Resultado, ClaseGeneral)
        Dim TipoActivo As ClaseGeneral = CType(cboTipoActivo.SelectedItem, ClaseGeneral)
        Dim UnidadProductiva As ClaseGeneral = CType(txtUnidadProductiva.Resultado, ClaseGeneral)

        'Dim tipoServicioTransporte As ClaseGeneral = CType(txtTipoServicioTransporte.Resultado, ClaseGeneral)
        'Dim unidadProductivaTransporte As ClaseGeneral = CType(txtUnidadProductivaTransporte.Resultado, ClaseGeneral)

        Dim codTipoServicioSAP As String = ""
        Dim codUnidadProdcutivaSAP As String = ""
        Dim codRegionVentaSAP As String = oContrato.CRGVTA
        'If Not PerteneceASalmon(Me.pCodigoCompania) Then
        '    'If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
        '    olCentroCosto = oCentroCosto.Lista_CentroBeneficio(tarifa.CCMPN, "", "", "", "", "", "", "")  'JM
        '    cmbCentroBeneficio.DataSource = olCentroCosto
        'Else
        If Not PerteneceASalmon(Me.pCodigoCompania) Then
            'olCentroBeneficio = oCentroCosto.Lista_CentroBeneficio(tarifa.CCMPN, "", "", "", "", "", "", "")  'JM
            'cmbCentroBeneficio.DataSource = olCentroBeneficio
            Exit Sub
        End If

        Dim codSedeSAP As String = "" 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        'If (_modoVisualTarifa <> ModoVisualTarifa.Flete) Then
        If (TipoServicio Is Nothing) Then Exit Sub
        If (UnidadProductiva Is Nothing) Then Exit Sub

        codTipoServicioSAP = TipoServicio.CDTSSP
        codUnidadProdcutivaSAP = UnidadProductiva.CDUPSP
        codRegionVentaSAP = oContrato.CRGVTA
        codSedeSAP = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        

        Dim codCompania = tarifa.CCMPN
        Dim codMacroServicioSAP As String = macroServicio.CDSRSP
        Dim codTipoActivoSAP As String = TipoActivo.PRCODI

        codSedeSAP = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim tipoCentroSAP As String = Obtener_Dato_General("TIPOCENTROSAP", "CB").CODREL 'RCS-HUNDRED

        Dim oCebe As New CentroCosto
        Dim oCebe2 As New CentroCosto
        'olCentroBeneficio = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        oCentroCosto.Lista_CentroBeneficio_Tokio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP, oCebe, oCebe2)

        If oCebe.PNCCNTCS > 0 Then
            olCentroBeneficio.Add(oCebe)
            cmbCentroBeneficio.DataSource = olCentroBeneficio
        Else
            cmbCentroBeneficio.DataSource = Nothing 'RCS-HUNDRED
        End If

        'If olCentroBeneficio.Count > 0 Then
        '    cmbCentroBeneficio.DataSource = olCentroBeneficio 'RCS-HUNDRED
        'Else
        '    cmbCentroBeneficio.DataSource = Nothing 'RCS-HUNDRED
        'End If

        'RCS-HUNDRED-INICIO
        cmbCentroBeneficio.ListColumnas = oListColum3
        cmbCentroBeneficio.Cargas()
        cmbCentroBeneficio.ValueMember = "PNCCNTCS"
        'cmbCentroBeneficio.DispleyMember = "PSTCNTCS"
        cmbCentroBeneficio.DispleyMember = "PSCCNBNS"
        'RCS-HUNDRED-FIN


    End Sub


    



    Private Sub CargarTipoAlmacen()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "CTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "TALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)

        txtTipoAlmacen.DataSource = oClaseGeneral.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "CTPALM"
        txtTipoAlmacen.DispleyMember = "TALMC"
    End Sub

    Private Sub CargarTipoMaterial()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "CCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "TDSDES"
        oColumnas.HeaderText = "Tipo Movimiento "
        oListColum.Add(2, oColumnas)



        TxtTipoMaterial.DataSource = oClaseGeneral.ListaTipoDeMaterial()
        TxtTipoMaterial.ListColumnas = oListColum
        TxtTipoMaterial.Cargas()
        TxtTipoMaterial.ValueMember = "CCMPRN"
        TxtTipoMaterial.DispleyMember = "TDSDES"

    End Sub

    Private Sub cboTipoTarifa_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoTarifa.SelectionChangeCommitted
        Try
            Dim oTipoTarifa As String = cboTipoTarifa.SelectedValue.ToString.Trim
            txtCantidad.Text = 1
            Select Case oTipoTarifa
                Case "R", "V"
                    TabControl1.TabPages.Clear()
                    TabControl1.TabPages.Add(tpDatosAdic)

                    txtCantidad.Enabled = False
                    txtMonto.Enabled = False
                    tsBarraRango.Enabled = True
                    txtMonto.Text = ""
                    'lbltipoTarifa.Text = cboTipoTarifa.Text
                Case "C"
                    TabControl1.TabPages.Clear()
                    TabControl1.TabPages.Add(tpDatosAdic)

                    txtCantidad.Enabled = True
                    txtMonto.Enabled = True
                    tsBarraRango.Enabled = False
                    'lbltipoTarifa.Text = cboTipoTarifa.Text
                Case "F"

                    TabControl1.TabPages.Clear()
                    TabControl1.TabPages.Add(tpTipoFijo)
                    txtCantidad.Enabled = True
                    txtMonto.Enabled = True
                    txtDiasdeCorte.Text = ""
                    tsBarraRango.Enabled = False

                Case "S", "Q", "M", "D"
                    TabControl1.TabPages.Clear()
                    TabControl1.TabPages.Add(tpTipoPermanencia)
                    cmbUnidadMedida.Valor = "MT2"
                    tsBarraRango.Enabled = False
                     
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

       
    End Sub


    Private Sub Cargar_Tarifa()

        Dim oTarifaNeg As New clsTarifa
        Me.cmbMoneda.Valor = oTarifa.CMNDA1
        If IsNothing(oTarifa.CUNDMD) Then
            Me.cmbUnidadMedida.Valor = "NADA"
        Else
            If oTarifa.CUNDMD.Trim = "" Then
                Me.cmbUnidadMedida.Valor = "NADA"
            Else
                Me.cmbUnidadMedida.Valor = oTarifa.CUNDMD
            End If
        End If


        cboDivision.SelectedValue = oTarifa.CDVSN
        cboDivision_SelectionChangeCommitted(cboDivision, Nothing)
        'LLL()
        cboDivision.Enabled = False
        
        UcPLanta_Cmb011.CodigoCompania = oTarifa.CCMPN
        UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
        UcPLanta_Cmb011.PlantaDefault = oTarifa.CPLNDV
        UcPLanta_Cmb011.pActualizar()

        Me.cboServicio.Valor = oTarifa.COD_SERV
        UcPLanta_Cmb011_Seleccionar(Nothing)

        Me.UcPLanta_Cmb011.pHabilitado = False
        'Me.cboServicio.Enabled = False

        Dim oTipoTarifa As String = oTarifa.STPTRA

        Select Case oTipoTarifa
            Case "F", "C", "D", "S", "Q", "M"
                txtDescripcion.Text = oTarifa.TOBS
                'Me.cboTipoTarifa.SelectedValue = "F"
                Me.cboTipoTarifa.SelectedValue = oTipoTarifa
                'Case "C"
                '    txtDescripcion.Text = oTarifa.TOBS
                '    Me.cboTipoTarifa.SelectedValue = "C"
            Case "R", "V"
                txtDescripcion.Text = oRango.DESRNG.Trim
                'Me.cboTipoTarifa.SelectedValue = "R"
                Me.cboTipoTarifa.SelectedValue = oTipoTarifa

                '=========Cargamos Grilla Rango==========
                Dim dt As DataTable = oTarifaNeg.Lista_Rango_RZSC03A(oTarifa)
                Dim iRow As Integer = 0
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim dr As New DataGridViewRow
                    dr.CreateCells(dtgRangoTarifa)
                    dtgRangoTarifa.Rows.Add(dr)
                    'iRow = dtgRangoTarifa.Rows.Count - 1
                    dtgRangoTarifa.Rows(i).Cells("CodTarifa").Value = dt.Rows(i).Item("NRTFSV")
                    dtgRangoTarifa.Rows(i).Cells("CodRango").Value = dt.Rows(i).Item("NRRNGO")
                    dtgRangoTarifa.Rows(i).Cells("RangoInicial").Value = dt.Rows(i).Item("VALMIN")
                    dtgRangoTarifa.Rows(i).Cells("RangoFinal").Value = dt.Rows(i).Item("VALMAX")
                    dtgRangoTarifa.Rows(i).Cells("Tarifa").Value = dt.Rows(i).Item("IVLSRV")
                Next


        End Select
        cboTipoTarifa.ComboBox.Enabled = False

        cboTipoTarifa_SelectionChangeCommitted(cboTipoTarifa, Nothing)

        txtMonto.Text = oTarifa.IVLSRV
        txtCantidad.Text = oTarifa.VALCTE
        txtPeriodoLibre.Text = oTarifa.PRLBPG

        'Falta mapear
        txtDiasFacturar.Text = oTarifa.NDIAPL


        txtTipoAlmacen.Valor = oTarifa.CTPALM
        TxtTipoMaterial.Valor = oTarifa.TTPOMR


        txtDiasdeCorte.Text = oTarifa.DIACOR

        txtTipoServicio.Valor = oTarifa.CDTSSP
        txtUnidadProductiva.Valor = oTarifa.CDUPSP
        cboTipoActivo.SelectedValue = oTarifa.CDTASP

        txtCodTarifaRef.Valor = oTarifa.CDTREF

        CargaCeBe_x_Id(oTarifa.CCNTCS)
        Dim CeBe As String = oTarifa.CCNTCS.ToString.Trim
        cmbCentroBeneficio.Valor = CeBe

        Me.chkPeriodoLibre.Checked = IIf(oTarifa.FAPLBR.Trim.Equals("X"), True, False)
        Cargar_Cliente_Interno(oTarifa) 'RCS-HUNDRED
        Generar_Tarifa()
    End Sub

    '<[AHM]>'
    Private oHasTipoServicioSAP As New Hashtable
    Private Sub Cargar_TipoServicio_SAP(ByVal PSCDSRSP As String)
        Dim oListColum, oListColum2 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        'ddd()
        oColumnas.Name = "CDTSSP"
        oColumnas.DataPropertyName = "CDTSSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oListColum2.Add(1, oColumnas.Clone())
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDTSSP"
        oColumnas.DataPropertyName = "TDTSSP"
        oColumnas.HeaderText = "Tipo Servicio "
        oListColum.Add(2, oColumnas)
        oListColum2.Add(2, oColumnas.Clone())

        Dim claseGeneralList As New List(Of ClaseGeneral)
        If Not oHasTipoServicioSAP.Contains(PSCDSRSP) Then
            claseGeneralList = oClaseGeneral.Listar_Tipo_Servicio_SAP(PSCDSRSP)
            oHasTipoServicioSAP(PSCDSRSP) = claseGeneralList
        End If
        claseGeneralList = oHasTipoServicioSAP(PSCDSRSP)

        txtTipoServicio.DataSource = claseGeneralList
        txtTipoServicio.ListColumnas = oListColum
        txtTipoServicio.Cargas()
        txtTipoServicio.ValueMember = "CDTSSP"
        txtTipoServicio.DispleyMember = "TDTSSP"
       
    End Sub

    Private Sub Listar_TipoActivo_SAP()
        Dim tipoActivoList As New List(Of mantenimientos.ClaseGeneral)
        tipoActivoList = oClaseGeneral.Listar_Tipo_Activo_SAP()

        cboTipoActivo.DataSource = tipoActivoList
        cboTipoActivo.DisplayMember = "PRDESC"
        cboTipoActivo.ValueMember = "PRCODI"
    End Sub

    Private oHasUnidadProductivaSAP As New Hashtable
    Private Sub Cargar_UnidadProductiva_SAP(ByVal PSCDSRSP As String, ByVal PSCDSPSP As String)
        'RCS-HUNDRED-INICIO
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

        Dim claseGeneralList As New List(Of ClaseGeneral)
        'claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP(PSCDSRSP)
        If Not oHasUnidadProductivaSAP.Contains(PSCDSRSP & "_" & PSCDSPSP) Then
            claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP_SEDEMACRO(PSCDSRSP, PSCDSPSP)
            oHasUnidadProductivaSAP(PSCDSRSP & "_" & PSCDSPSP) = claseGeneralList
        End If
        'claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP_SEDEMACRO(PSCDSRSP, PSCDSPSP)
        claseGeneralList = oHasUnidadProductivaSAP(PSCDSRSP & "_" & PSCDSPSP)

        txtUnidadProductiva.DataSource = claseGeneralList
        txtUnidadProductiva.ListColumnas = oListColum
        txtUnidadProductiva.Cargas()
        txtUnidadProductiva.ValueMember = "CDUPSP"
        txtUnidadProductiva.DispleyMember = "TDUPSP"
        'RCS-HUNDRED-FIN
    End Sub
    '</[AHM]>'


    Private Sub Generar_Tarifa()
      
        Dim strTarifa As String = ""
        If cmbMoneda.Resultado Is Nothing Then Exit Sub
        strTarifa = CType(cmbMoneda.Resultado, Moneda).TSGNMN 'Me.cmbMoneda.Text.Trim
        If Me.txtMonto.Text.Trim <> vbNullString And IsNumeric(txtMonto.Text.Trim) Then
            strTarifa = strTarifa & " " & Format(CType(Me.txtMonto.Text.Trim, Double), "###,###,###,##0.000")
        End If
        Generar_Concepto()
        oTarifaDescripciones.MntTarifa = strTarifa

        If cboTipoTarifa.SelectedValue = "R" Then
            Me.txtTarifa.Text = oTarifaDescripciones.DesConcepto
        Else
            Me.txtTarifa.Text = oTarifaDescripciones.MntTarifa & " " & oTarifaDescripciones.DesConcepto
        End If
        
    End Sub





    Private Sub Generar_Concepto()
        Dim strConcepto As String = ""
        Dim oTipoTarifa As String = cboTipoTarifa.SelectedValue.ToString.Trim
        Select Case oTipoTarifa
            Case "F", "C"
                If Me.txtCantidad.Text.Trim = "1" Then
                    strConcepto = strConcepto & " por"
                Else
                    strConcepto = strConcepto & " por " & Format(CType(Me.txtCantidad.Text.Trim, Double), "###,###,###,##0")
                End If
            Case "R"
                Dim rango_text As String = ""
                For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                    If Not (CDbl(obj.Cells("RangoInicial").Value.ToString()) = 0 And CDbl(obj.Cells("RangoFinal").Value.ToString()) = 0) Then
                        rango_text = rango_text & " de " & obj.Cells("RangoInicial").Value.ToString() & " a " & obj.Cells("RangoFinal").Value.ToString() & " por " & CType(cmbMoneda.Resultado, Moneda).TSGNMN & obj.Cells("Tarifa").Value.ToString() & vbNewLine
                    End If
                Next
                strConcepto = strConcepto & rango_text
        End Select
        If cmbUnidadMedida.Resultado IsNot Nothing Then
            If CType(cmbUnidadMedida.Resultado, mantenimientos.ClaseGeneral).CUNDMD <> "NADA" Then
                strConcepto = strConcepto & " " & CType(cmbUnidadMedida.Resultado, mantenimientos.ClaseGeneral).CUNDMD 'Me.cmbUnidadMedida.Text.Trim
            End If
        End If

        If Me.txtDescripcion.Text <> vbNullString Then
            strConcepto = strConcepto & " " & Me.txtDescripcion.Text.Trim
        End If
        oTarifaDescripciones.DesConcepto = strConcepto

        
    End Sub

#Region "Validacion de Campos Numericos"
    '-----------------------------------
    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Try
            CType(sender, TextBox).Tag = "10-3"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            CType(sender, TextBox).Tag = "10-5"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtPeriodoLibre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeriodoLibre.KeyPress
        Try
            CType(sender, TextBox).Tag = "3-0"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        Try
            If txtMonto.Text.EndsWith(".") Then
                txtMonto.Text = txtMonto.Text.Replace(".", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub
    Private Sub txtCantidad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        Try
            If txtCantidad.Text.EndsWith(".") Then
                txtCantidad.Text = txtCantidad.Text.Replace(".", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub




#End Region

    Private Sub btnAgregaRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaRango.Click
        Try
            If txtIniRango.Text = "" Then Exit Sub
            If txtFinRango.Text = "" Then Exit Sub
            If txtMontoRango.Text = "" Or txtMontoRango.Text = "0" Then Exit Sub
            If CDbl(txtIniRango.Text) > CDbl(txtFinRango.Text) Then
                MsgBox("El Valor Maximo debe ser Mayor a Valor Minimo", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim dr As New DataGridViewRow
            Dim iRow As Integer = 0
            dr.CreateCells(dtgRangoTarifa)
            dtgRangoTarifa.Rows.Add(dr)
            iRow = dtgRangoTarifa.Rows.Count - 1
            dtgRangoTarifa.Rows(iRow).Cells("CodTarifa").Value = oTarifa.NRTFSV
            dtgRangoTarifa.Rows(iRow).Cells("CodRango").Value = 0
            dtgRangoTarifa.Rows(iRow).Cells("RangoInicial").Value = txtIniRango.Text
            dtgRangoTarifa.Rows(iRow).Cells("RangoFinal").Value = txtFinRango.Text
            dtgRangoTarifa.Rows(iRow).Cells("Tarifa").Value = txtMontoRango.Text
            txtIniRango.Text = ""
            txtFinRango.Text = ""
            txtMontoRango.Text = ""
            txtIniRango.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub btnQuitaRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitaRango.Click
        Try
            'If dtgRangoTarifa.Rows.Count = 0 Then Exit Sub
            'If dtgRangoTarifa.Rows(dtgRangoTarifa.CurrentRow.Index).Cells("CodRango").Value = 0 Then
            '    dtgRangoTarifa.Rows.RemoveAt(dtgRangoTarifa.CurrentRow.Index)
            'Else
            '    MsgBox("No es posible eliminar el rango, debido a que ya tiene un código asignado", MsgBoxStyle.Information)
            'End If
            If dtgRangoTarifa.CurrentRow Is Nothing Then Exit Sub

            If dtgRangoTarifa.Rows(dtgRangoTarifa.CurrentRow.Index).Cells("CodRango").Value = 0 Then
                dtgRangoTarifa.Rows.RemoveAt(dtgRangoTarifa.CurrentRow.Index)
            Else
                Dim objRango As New Rango
                objRango.NRRNGO = dtgRangoTarifa.CurrentRow.Cells("CodRango").Value
                Dim objProcesoTarifa As New clsTarifa
                objProcesoTarifa.Elimina_Rango_RZSC03A(objRango, oTarifa)
                dtgRangoTarifa.Rows.RemoveAt(dtgRangoTarifa.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboServicio_CambioDeTexto(ByVal objData As System.Object) Handles cboServicio.CambioDeTexto
        Try
           
            txtTipoServicio.Limpiar()
            txtTipoServicio.DataSource = Nothing

            If PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                cmbCentroBeneficio.Limpiar()
                cmbCentroBeneficio.DataSource = Nothing
            End If

            If cboServicio.Resultado IsNot Nothing Then
                Dim servicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
                Cargar_TipoServicio_SAP(servicio.CDSRSP)

                Cargar_UnidadProductiva_SAP(servicio.CDSRSP, UcPLanta_Cmb011.CodSedeSAP)
            End If


           
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub Cargar_CentroCosto_Origen()

        Dim oListColumns As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim olCentroCosto As List(Of CentroCosto)

        oListColumns = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn

        olCentroCosto = oCentroCosto.Listar_CentroCosto_Origen_Tarifa(oTarifa.CCMPN)

        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColumns.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Costo"
        oListColumns.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNCOS"
        oColumnas.DataPropertyName = "PSCCNCOS"
        oColumnas.HeaderText = "Ce.Co. SAP"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColumns.Add(3, oColumnas)

        If olCentroCosto.Count > 0 Then
            cmbCentCostoOrigen.DataSource = olCentroCosto
        Else
            cmbCentCostoOrigen.DataSource = Nothing
        End If
        cmbCentCostoOrigen.ListColumnas = oListColumns
        cmbCentCostoOrigen.Cargas()
        cmbCentCostoOrigen.ValueMember = "PNCCNTCS"
        cmbCentCostoOrigen.DispleyMember = "PSTCNTCS"
        'End If


        olCentroCosto = oCentroCosto.Listar_CentroCosto_Destino_Tarifa(oTarifa.CCMPN, CType(cmbCentroBeneficio.Resultado, CentroCosto).PNCCNTCS)

        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColumns.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Costo"
        oListColumns.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNCOS"
        oColumnas.DataPropertyName = "PSCCNCOS"
        oColumnas.HeaderText = "Ce.Co. SAP"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColumns.Add(3, oColumnas)


        If olCentroCosto.Count > 0 Then
            cmbCentCostoDestino.DataSource = olCentroCosto
        Else
            cmbCentCostoDestino.DataSource = Nothing
        End If
        cmbCentCostoDestino.ListColumnas = oListColumns
        cmbCentCostoDestino.Cargas()
        cmbCentCostoDestino.ValueMember = "PNCCNTCS"
        cmbCentCostoDestino.DispleyMember = "PSTCNTCS"



    End Sub


    Private Sub Mostrar_Controles_Cliente_Interno(ByVal pbolMostrar)
        ' muestra campos de cliente interno
        lblTarifaInterna.Visible = pbolMostrar
        txtTarifaInterna.Visible = pbolMostrar
        lblCentCostoOrigen.Visible = pbolMostrar
        cmbCentCostoOrigen.Visible = pbolMostrar
        lblCentCostoDestino.Visible = pbolMostrar
        cmbCentCostoDestino.Visible = pbolMostrar
        txtTarifaInterna.Text = 0
    End Sub

   
    Private Function Validar_Controles_Cliente_Interno() As Boolean
        If Not bolClienteInterno Then Return True

        If cmbCentCostoOrigen.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe de seleccionar Centro de Costo Origen.", MessageBoxIcon.Information)
            Return False
        End If
        If cmbCentCostoDestino.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe de seleccionar Centro de Costo Destino.", MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub Guardar_Cliente_Interno(ByRef objTarifa As Tarifa)
        If Not bolClienteInterno Then Return
        objTarifa.ISRVTI = CDbl(IIf(txtTarifaInterna.Text.Trim = "", 0, txtTarifaInterna.Text.Trim))
        objTarifa.CENCO2 = CType(cmbCentCostoOrigen.Resultado, CentroCosto).PNCCNTCS
        objTarifa.CENCOS = CType(cmbCentCostoDestino.Resultado, CentroCosto).PNCCNTCS
    End Sub

    Private Sub Cargar_Cliente_Interno(ByRef objTarifa As Tarifa)
        If Not bolClienteInterno Then Return
        txtTarifaInterna.Text = objTarifa.ISRVTI
        cmbCentCostoOrigen.Valor = objTarifa.CENCO2
        cmbCentCostoDestino.Valor = objTarifa.CENCOS
    End Sub

    Public Function Listar_Datos_Generales(ByRef pdtDatosGenerales As DataTable) As List(Of DatosGenerales)
        Dim objDatosGenerales As DatosGenerales
        Dim lbeDatosGenerales As New List(Of DatosGenerales)
        For Each objDataRow As DataRow In pdtDatosGenerales.Rows
            objDatosGenerales = New DatosGenerales()
            objDatosGenerales.CODIGO = objDataRow("CODIGO")
            objDatosGenerales.DESCRIPCION = objDataRow("DESCRIPCION").ToString.Trim()
            objDatosGenerales.CODREL = objDataRow("CODREL").ToString.Trim()
            lbeDatosGenerales.Add(objDatosGenerales)
        Next
        Return lbeDatosGenerales
    End Function

    
    Private Sub Cargar_Centro_Costo_Propio_Tercero()
        Dim oListColumns, oListColumns2 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "COD_CECO"
        oColumnas.DataPropertyName = "COD_CECO"
        oColumnas.HeaderText = "Cod CeCo"
        oListColumns.Add(1, oColumnas)
        oListColumns2.Add(1, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESC_CECO"
        oColumnas.DataPropertyName = "DESC_CECO"
        oColumnas.HeaderText = "Desc Ceco"
        oListColumns.Add(2, oColumnas)
        oListColumns2.Add(2, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CODSAP_CECO"
        oColumnas.DataPropertyName = "CODSAP_CECO"
        oColumnas.HeaderText = "Cod  CeCo SAP"
        oListColumns.Add(3, oColumnas)
        oListColumns2.Add(3, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "COD_CEBE"
        oColumnas.DataPropertyName = "COD_CEBE"
        oColumnas.HeaderText = "Cod CeBe"
        oListColumns.Add(4, oColumnas)
        oListColumns2.Add(4, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESC_CEBE"
        oColumnas.DataPropertyName = "DESC_CEBE"
        oColumnas.HeaderText = "Desc CeBe"
        oListColumns.Add(5, oColumnas)
        oListColumns2.Add(5, oColumnas.Clone())


    End Sub

    Private Function Listar_CeCo_Tarifario(ByRef pdtCeCoTarifario As DataTable) As List(Of CentroCostoTarifa)
        Dim objCeCoTarifario As CentroCostoTarifa
        Dim lbeCeCoTarifario As New List(Of CentroCostoTarifa)
        For Each objDataRow As DataRow In pdtCeCoTarifario.Rows
            objCeCoTarifario = New CentroCostoTarifa()
            objCeCoTarifario.COD_CECO = objDataRow("COD_CECO").ToString.Trim()
            objCeCoTarifario.DESC_CECO = objDataRow("DESC_CECO").ToString.Trim()
            objCeCoTarifario.CODSAP_CECO = objDataRow("CODSAP_CECO").ToString.Trim()
            objCeCoTarifario.COD_CEBE = objDataRow("COD_CEBE").ToString.Trim()
            objCeCoTarifario.CODSAP_CEBE = objDataRow("CODSAP_CEBE").ToString.Trim()
            objCeCoTarifario.DESC_CEBE = objDataRow("DESC_CEBE").ToString.Trim()
            lbeCeCoTarifario.Add(objCeCoTarifario)
        Next
        Return lbeCeCoTarifario
    End Function

    Public Function Obtener_Dato_General(ByVal pstrTipo As String, ByVal pstrCodigo As String) As DatosGenerales 'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Select Case pstrTipo
            Case "TIPOCENTROSAP" 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                If Not dsMelsap.Tables("Table1") Is Nothing AndAlso dsMelsap.Tables("Table1").Rows.Count > 0 Then
                    Dim dvDatosGenerales As DataView = dsMelsap.Tables("Table1").DefaultView
                    Dim lbeDatosGenerales As List(Of DatosGenerales)

                    dvDatosGenerales.RowFilter = String.Format("TIPO = '{0}' AND CODIGO = '{1}'", pstrTipo, pstrCodigo)
                    lbeDatosGenerales = Listar_Datos_Generales(dvDatosGenerales.ToTable()) ' datos generales
                    If lbeDatosGenerales.Count > 0 Then
                        Return lbeDatosGenerales(0)
                    End If
                End If
            Case "TIPOACTIVOSAP" 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                If Not dsMelsap.Tables("Table") Is Nothing AndAlso dsMelsap.Tables("Table").Rows.Count > 0 Then
                    Dim dvDatosGenerales As DataView = dsMelsap.Tables("Table").DefaultView
                    Dim lbeDatosGenerales As List(Of DatosGenerales)

                    dvDatosGenerales.RowFilter = String.Format("TIPO = '{0}' AND CODIGO = '{1}'", pstrTipo, pstrCodigo)
                    lbeDatosGenerales = Listar_Datos_Generales(dvDatosGenerales.ToTable()) ' datos generales
                    If lbeDatosGenerales.Count > 0 Then
                        Return lbeDatosGenerales(0)
                    End If
                End If
        End Select

        Return Nothing
    End Function

     
    Private Sub Cargar_CeBe_x_Tipo(ByVal pstrTipo As String)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim olCentroCosto As List(Of CentroCosto)
        Dim strCeBe As String

        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Costo"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNCOS"
        oColumnas.DataPropertyName = "PSCCNCOS"
        oColumnas.HeaderText = "Ce.Co. SAP"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)

        If pstrTipo = "P" Then
            If strCeBe = "" Then Return ' si no hay valor de centro beneficio sale
            olCentroCosto = oCentroCosto.Listar_CentroCosto_CeBe(oTarifa.CCMPN, strCeBe)
        Else
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
            If strCeBe = "" Then Return ' si no hay valor de centro beneficio sale
            olCentroCosto = oCentroCosto.Listar_CentroCosto_CeBe(oTarifa.CCMPN, strCeBe)
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO

            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
        End If
    End Sub

   
    Private Sub btnCancelarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTarifa.Click
        Me.Close()
    End Sub

    Private Sub cmbMoneda_CambioDeTexto(ByVal objData As Object) Handles cmbMoneda.CambioDeTexto
        Try
            Generar_Tarifa()
            'If cmbMoneda.Resultado IsNot Nothing Then

            '    CargarTarifaReferencial()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub cmbUnidadMedida_CambioDeTexto(ByVal objData As System.Object) Handles cmbUnidadMedida.CambioDeTexto
        Try
            Generar_Tarifa()
            'If cmbUnidadMedida.Resultado IsNot Nothing Then

            '    CargarTarifaReferencial()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtMonto_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyUp
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtCantidad_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyUp
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.LostFocus
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.LostFocus
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.LostFocus
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Function Validar_Tarifa() As Boolean

        If cboServicio.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe Seleccionar el Servicio", MessageBoxIcon.Information)
            Return False
        End If
        'If cboLogicaFacturacion.Resultado Is Nothing Then
        '    HelpClass.MsgBox("Debe Seleccionar Lógica de Facturación", MessageBoxIcon.Information)
        '    Return False
        'End If
        Dim dblNum As Double
        Decimal.TryParse(Me.txtMonto.Text.Trim, dblNum)
        If dblNum = 0 AndAlso cboTipoTarifa.SelectedValue <> "R" AndAlso cboTipoTarifa.SelectedValue <> "V" Then
            MessageBox.Show("Debe ingresar importe válido mayor a cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Me.cboTipoTarifa.SelectedValue = "R" OrElse Me.cboTipoTarifa.SelectedValue = "V" Then
            For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                If obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" OrElse obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" OrElse obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" Then
                    If CDbl(obj.Cells("RangoInicial").Value.ToString()) > CDbl(obj.Cells("RangoFinal").Value.ToString()) Then
                        Return False
                    End If
                    If CInt(obj.Cells("Tarifa").Value.ToString()) = 0 Then
                        Return False
                    End If
                End If
            Next
        End If
        If cmbUnidadMedida.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe Seleccionar la Unidad de Medida", MessageBoxIcon.Information)
            Return False
        End If

        If Me.cmbCentroBeneficio.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe Seleccionar un Centro de Costo", MessageBoxIcon.Information)
            Return False
        End If

        If cmbMoneda.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe Seleccionar la Moneda", MessageBoxIcon.Information)
            Return False
        End If

        If TxtTipoMaterial.Resultado Is Nothing AndAlso cboTipoTarifa.SelectedValue = "D" Then
            HelpClass.MsgBox("Debe de seleccionar el Tipo de Mercadería", MessageBoxIcon.Information)
            Return False
        End If

        If txtTipoAlmacen.Resultado Is Nothing AndAlso cboTipoTarifa.SelectedValue = "D" Then
            HelpClass.MsgBox("Debe de seleccionar el Tipo de Almacén", MessageBoxIcon.Information)
            Return False
        End If

        '<[AHM]>
        'SI LA COMPAÑIA PERTENECE A SALMON SE CONTINUA CON LAS SIGUIENTES VALIDACIONES
        If Not PerteneceASalmon(Me.pCodigoCompania) Then
            'If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
            'Exit Function
            Return True
        End If

        'VALIDACION DE TARIFA EN SAP
        Dim servicioXRubro As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)


        Dim objTarifa As New Tarifa
        objTarifa.CCMPN = oTarifa.CCMPN
        objTarifa.CRGVTA = oContrato.CRGVTA
        objTarifa.TSRVIN = servicioXRubro.TSRVIN
        Dim tarifaSAP As TarifaSAP = (New clsTarifa).ValidarMaterialSAP(objTarifa)
        If (Not tarifaSAP.EsValida) Then
            HelpClass.MsgBox(String.Format("'El Material: {0} no está configurado para el negocio: {1}.{2}", servicioXRubro.NOMSER, oContrato.CRGVTA, Environment.NewLine), _
                             MessageBoxIcon.Information)
            Return False
        End If


        If txtTipoServicio.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe de seleccionar el Tipo de Servicio", MessageBoxIcon.Information)
            Return False
        End If

        If txtUnidadProductiva.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe de seleccionar  la  Unidad Productiva", MessageBoxIcon.Information)
            Return False
        End If

        If cboTipoActivo.SelectedValue = "" Then
            HelpClass.MsgBox("Debe de seleccionar el Tipo Activo", MessageBoxIcon.Information)
            Return False
        End If
        '</[AHM]>
        Return True 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

     
    End Function

    Private Sub btnGrabarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarTarifa.Click
        Try
            If Validar_Tarifa() = True Then
                'If Validar_Controles_Visibles() = True Then
                Dim objTarifa As New Tarifa
                Dim oTrfTemp As New Tarifa
                Dim objProcesoTarifa As New clsTarifa
                Generar_Tarifa()
                objTarifa.NRCTSL = oTarifa.NRCTSL
                objTarifa.CCMPN = oTarifa.CCMPN

                Dim PNNRRUBR As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRRUBR
                Dim PNNRSRRB As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRSRRB

                objTarifa.NRRUBR = PNNRRUBR
                objTarifa.NRSRRB = PNNRSRRB
                oTrfTemp = objProcesoTarifa.ObtenerDivTarifa_RZSC08(objTarifa)
                objTarifa.CDVSN = oTrfTemp.CDVSN
                objTarifa.NRRUBR = oTrfTemp.NRRUBR
                objTarifa.CPLNDV = UcPLanta_Cmb011.Planta
                objTarifa.CMNDA1 = CType(cmbMoneda.Resultado, Moneda).CMNDA1 'cmbMoneda.SelectedValue
                objTarifa.CUNDMD = CType(cmbUnidadMedida.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CUNDMD 'cmbUnidadMedida.SelectedValue
                objTarifa.CCNTCS = CType(cmbCentroBeneficio.Resultado, CentroCosto).PNCCNTCS 'cmbCentroCosto.SelectedValue
                objTarifa.MntTarifa = oTarifaDescripciones.MntTarifa
                objTarifa.IVLSRV = IIf(txtMonto.Text.Trim = "", 0, txtMonto.Text.Trim)
                objTarifa.VALCTE = CDbl(Me.txtCantidad.Text)
                objTarifa.TOBS = txtDescripcion.Text
                objTarifa.PRLBPG = Val(Me.txtPeriodoLibre.Text)
                'Falta
                objTarifa.NDIAPL = txtDiasFacturar.Text
                objTarifa.NRTFSV = oTarifa.NRTFSV
                objTarifa.FAPLBR = IIf(chkPeriodoLibre.Checked, "X", "")
                'objTarifa.NRRELF = CType(cboLogicaFacturacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO_LF
                objTarifa.NRRELF = 0
                If Not TxtTipoMaterial.Resultado Is Nothing Then
                    objTarifa.TTPOMR = CType(TxtTipoMaterial.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CCMPRN
                End If

                If Not txtTipoAlmacen.Resultado Is Nothing Then
                    objTarifa.CTPALM = CType(txtTipoAlmacen.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPALM
                End If

                'Tarifa fija referencial   ...jm   +
                If Not txtCodTarifaRef.Resultado Is Nothing Then
                    objTarifa.CDTREF = CType(txtCodTarifaRef.Resultado, Tarifa).CDTREF
                End If
                If Not String.IsNullOrEmpty(txtDiasdeCorte.Text.Trim) Then
                    objTarifa.DIACOR = Double.Parse(txtDiasdeCorte.Text.Trim)
                End If

                '<[AHM]>
                objTarifa.CDSDSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSDSP
                objTarifa.CDSRSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSRSP
                objTarifa.CDTSSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDTSSP
                objTarifa.CDTASP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDTASP
                objTarifa.CDSPSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSPSP
                objTarifa.CDUPSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDUPSP
                objTarifa.CDSCSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSCSP
                '</[AHM]>
                Dim oTipoTarifa As String = cboTipoTarifa.SelectedValue
                Select Case oTipoTarifa
                    Case "F", "C", "D", "S", "Q", "M"
                        'objTarifa.STPTRA = "F"
                        objTarifa.STPTRA = oTipoTarifa
                        objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        'Case "C"
                        '    objTarifa.STPTRA = "C"
                        '    objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                    Case "R", "V"
                        'objTarifa.STPTRA = "R"
                        objTarifa.STPTRA = oTipoTarifa
                        If dtgRangoTarifa.RowCount = 0 Then Exit Sub
                        objTarifa.DESTAR = "Por Rango"
                        'Case "D"
                        '    objTarifa.STPTRA = "D"
                        '    objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        'Case "S"
                        '    objTarifa.STPTRA = "S"
                        '    objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        'Case "Q"
                        '    objTarifa.STPTRA = "Q"
                        '    objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        'Case "M"
                        '    objTarifa.STPTRA = "M"
                        '    objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                End Select
                '-----------------------------------------------
                Guardar_Cliente_Interno(objTarifa) 'RCS-HUNDRED

                If objTarifa.NRTFSV <> 0 Then
                    objProcesoTarifa.Modificar_Tarifa_RZSC03(objTarifa)
                Else
                    objTarifa.NRTFSV = objProcesoTarifa.Crear_Tarifa_RZSC03(objTarifa)
                End If

                If cboTipoTarifa.SelectedValue = "R" OrElse cboTipoTarifa.SelectedValue = "V" Then
                    For i As Integer = 0 To dtgRangoTarifa.Rows.Count - 1
                        Dim objRango As New Rango
                        objRango.VALMIN = dtgRangoTarifa.Rows(i).Cells("RangoInicial").Value
                        objRango.VALMAX = dtgRangoTarifa.Rows(i).Cells("RangoFinal").Value
                        objRango.IVLSRV = dtgRangoTarifa.Rows(i).Cells("Tarifa").Value
                        objRango.NRRNGO = dtgRangoTarifa.Rows(i).Cells("CodRango").Value
                        objRango.DESRNG = txtDescripcion.Text.Trim & " (Rango)"
                        objProcesoTarifa.Crear_Rango_RZSC03A(objRango, objTarifa)
                    Next
                End If

                Select Case Tipo
                    Case EnumTipo.Nuevo
                        If objTarifa.NRTFSV <> 0 Then
                            MessageBox.Show("Se ha creado la Tarifa:" & objTarifa.NRTFSV, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                End Select

                Me.DialogResult = Windows.Forms.DialogResult.OK

               
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

  

    Public Shared Function SoloNumerosConDecimal(ByVal sender As TextBox, ByVal Keyascii As Short) As Short
        Dim TextBox As TextBox
        Dim NumeroTexto As String
        TextBox = CType(sender, TextBox)
        Dim ArrayEnteroDecimal() As String
        Dim NEnteros As Int32 = 0
        Dim NDecimales As Int32 = 0
        If TextBox.Tag IsNot Nothing Then
            ArrayEnteroDecimal = TextBox.Tag.ToString.Split("-")
            If ArrayEnteroDecimal.Length = 2 Then
                NEnteros = Convert.ToInt32(ArrayEnteroDecimal(0))
                NDecimales = Convert.ToInt32(ArrayEnteroDecimal(1))
            End If
        End If
        Dim InicioEnteros As String = IIf(NEnteros = 0, "0", 1)
        Dim RegexExpresion As String = "^[0-9]{" & InicioEnteros & "," & NEnteros & "}(\.[0-9]{0," & NDecimales & "})?$"
        NumeroTexto = TextBox.Text.Trim
        Dim NumeroOriginal As String = NumeroTexto
        NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
        If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
            NumeroTexto = NumeroOriginal
            SoloNumerosConDecimal = 0
        Else
            SoloNumerosConDecimal = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConDecimal = Keyascii
            Case 13
                SoloNumerosConDecimal = Keyascii
            Case 32
                SoloNumerosConDecimal = Keyascii
        End Select
    End Function

 

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try 'RCS-HUNDRED
            If clsComun.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimalToolStrip(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try 'RCS-HUNDRED
            If clsComun.SoloNumerosConDecimal(CType(sender, ToolStripTextBox), CShort(Asc(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasFacturar.KeyPress
        Try
            CType(sender, TextBox).Tag = "3-0"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub txtDiasdeCorte_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasdeCorte.KeyPress
        Try
            CType(sender, TextBox).Tag = "2-0"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

 

    Private Sub txtTipoServicio_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicio.CambioDeTexto
        Try
            'If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
            If Not PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            cmbCentroBeneficio.Limpiar()
            cmbCentroBeneficio.DataSource = Nothing

            If (txtTipoServicio.Resultado Is Nothing) Then
                Exit Sub
            End If
            'Me.Cargar_CentroBeneficio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtUnidadProductiva_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductiva.CambioDeTexto
        Try
            'If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
            If Not PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            cmbCentroBeneficio.Limpiar()
            cmbCentroBeneficio.DataSource = Nothing

            If (txtUnidadProductiva.Resultado Is Nothing) Then
                Exit Sub
            End If
            'Me.Cargar_CentroBeneficio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboTipoActivo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoActivo.SelectedValueChanged
        Try
            'If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
            If Not PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            cmbCentroBeneficio.Limpiar()
            cmbCentroBeneficio.DataSource = Nothing
            'Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub
    Private Sub cmbCentroCosto_ClickOnArrow(ByVal objData As System.Object) Handles cmbCentroBeneficio.ClickOnArrow
        Try
            'If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
            If Not PerteneceASalmon(Me.pCodigoCompania) Then
                Exit Sub
            End If

            Dim msgerror As String = ""

            If cboServicio.Resultado Is Nothing Then
                msgerror = "Servicio"
            End If
            If txtTipoServicio.Resultado Is Nothing Then
                msgerror = msgerror & Chr(10) & "Tipo servicio"
            End If
            If cboTipoActivo.SelectedValue Is Nothing Then
                msgerror = msgerror & Chr(10) & "Tipo Activo"
            End If
            If txtUnidadProductiva.Resultado Is Nothing Then
                msgerror = msgerror & Chr(10) & "Unidad Productiva"
            End If
            If UcPLanta_Cmb011.CodSedeSAP = "" Then
                msgerror = msgerror & Chr(10) & "Planta"
            End If
            If msgerror.Length > 0 Then
                msgerror = "Seleccione:" & Chr(10) & msgerror
            End If

            If msgerror.Length > 0 Then
                MessageBox.Show(msgerror, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try

    End Sub

    Private Sub cboCentroCostoTercero_ClickOnArrow(ByVal objData As System.Object)
        Try
            'If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
            If Not PerteneceASalmon(Me.pCodigoCompania) Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub
    Private Sub UcPLanta_Cmb011_Seleccionar(ByVal obePlanta As Ransa.Controls.UbicacionPlanta.Planta.bePlanta) Handles UcPLanta_Cmb011.SelectionChangeCommitted
        Try

            txtUnidadProductiva.Limpiar()
            txtUnidadProductiva.DataSource = Nothing
            Dim PSCDSRSP As String = ""
            If cboServicio.Resultado IsNot Nothing Then
                PSCDSRSP = CType(cboServicio.Resultado, Servicio_X_Rubro).CDSRSP
                Cargar_UnidadProductiva_SAP(PSCDSRSP, UcPLanta_Cmb011.CodSedeSAP)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Dim oHasPerteneceSalmon As New Hashtable
    Private Function PerteneceASalmon(pCCMPN As String)
        Dim result As Boolean = False
        'Dim strResult As 
        If oHasPerteneceSalmon.Contains(pCCMPN) = False Then
            Dim resultado As Boolean = False
            resultado = (New clsCliente).PerteneceASalmon(Me.pCodigoCompania)
            oHasPerteneceSalmon(pCCMPN) = resultado
        End If
        result = oHasPerteneceSalmon(pCCMPN)
        Return result
    End Function

    Private Sub txtCodTarifaRef_ClickOnArrow(objData As Object) Handles txtCodTarifaRef.ClickOnArrow
        Try
            Dim msgerror As String = ""
            If cboServicio.Resultado Is Nothing Then
                msgerror = "servicio"
            End If
            If cmbMoneda.Resultado Is Nothing Then
                msgerror = msgerror & Chr(10) & "moneda"
            End If
            If cmbUnidadMedida.Resultado Is Nothing Then
                msgerror = msgerror & Chr(10) & "unidad medida"
            End If
            If cmbCentroBeneficio.Resultado Is Nothing Then
                msgerror = msgerror & Chr(10) & "Centro Beneficio"
            End If
            If msgerror.Length > 0 Then
                MessageBox.Show("Seleccione" & Chr(10) & msgerror, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            CargarTarifaReferencial()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarTarifaReferencial()

        Dim objTarifa As New Tarifa
        Dim BLTarifa As New clsTarifa
        Dim lista As New List(Of Tarifa)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "CDTREF"
        oColumnas.DataPropertyName = "CDTREF"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NOMSER"
        oColumnas.DataPropertyName = "NOMSER"
        oColumnas.HeaderText = "Servicio "
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "VALCTE"
        oColumnas.DataPropertyName = "VALCTE"
        oColumnas.HeaderText = "Cantidad "
        oListColum.Add(3, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CUNDMD"
        oColumnas.DataPropertyName = "CUNDMD"
        oColumnas.HeaderText = "Unidad medida "
        oListColum.Add(4, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "IVLSRV"
        oColumnas.DataPropertyName = "IVLSRV"
        oColumnas.HeaderText = "Valor "
        oListColum.Add(5, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TSGNMN"
        oColumnas.DataPropertyName = "TSGNMN"
        oColumnas.HeaderText = "Moneda "
        oListColum.Add(6, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "TALMC"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(7, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TIPMER"
        oColumnas.DataPropertyName = "TIPMER"
        oColumnas.HeaderText = "Tipo Material "
        oListColum.Add(8, oColumnas)
        '======================================

        If cboServicio.Resultado IsNot Nothing And cmbMoneda.Resultado IsNot Nothing Then

            objTarifa.CCMPN = oTarifa.CCMPN
            'objTarifa.CDVSN = UcDivision.Division
            objTarifa.CDVSN = cboDivision.SelectedValue
            objTarifa.CPLNDV = UcPLanta_Cmb011.Planta
            objTarifa.NRCTSL = oTarifa.NRCTSL
            objTarifa.NRRUBR = CType(cboServicio.Resultado, Servicio_X_Rubro).NRRUBR
            objTarifa.NRSRRB = CType(cboServicio.Resultado, Servicio_X_Rubro).NRSRRB
            objTarifa.CMNDA1 = CType(cmbMoneda.Resultado, Moneda).CMNDA1
            objTarifa.CUNDMD = CType(cmbUnidadMedida.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CUNDMD
            If (Not cmbCentroBeneficio.Resultado Is Nothing) Then
                objTarifa.CCNTCS = CType(cmbCentroBeneficio.Resultado, CentroCosto).PNCCNTCS
            End If
            lista = BLTarifa.ListarTarifaFija(objTarifa)
            If lista.Count > 0 Then
                txtCodTarifaRef.DataSource = lista
            Else
                txtCodTarifaRef.DataSource = Nothing
            End If
        End If
        txtCodTarifaRef.ListColumnas = oListColum
        txtCodTarifaRef.Cargas()
        txtCodTarifaRef.Limpiar()

        txtCodTarifaRef.ValueMember = "CDTREF"
        txtCodTarifaRef.DispleyMember = "NOMSER"

    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDivision.SelectionChangeCommitted
        Try
            UcPLanta_Cmb011.CodigoDivision = cboDivision.SelectedValue
            UcPLanta_Cmb011.CodigoCompania = oTarifa.CCMPN
            UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
            UcPLanta_Cmb011.pActualizar()
            ListarServicio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtIniRango_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIniRango.KeyPress, txtFinRango.KeyPress, txtMontoRango.KeyPress
        Try
            CType(sender, ToolStripTextBox).Tag = "10-3"
            Event_KeyPress_NumeroWithDecimalToolStrip(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

   

    Private Sub dtgRangoTarifa_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dtgRangoTarifa.EditingControlShowing
       
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = dtgRangoTarifa.Columns(dtgRangoTarifa.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "Tarifa"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
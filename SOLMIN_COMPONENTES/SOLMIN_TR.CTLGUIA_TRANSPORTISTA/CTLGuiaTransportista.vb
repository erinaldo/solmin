Imports SOLMIN_TR.NEGOCIO
Imports SOLMIN_TR.DATOS.Entidades
Imports System.Data
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine 

Public Class CTLGuiaTransportista

    Dim objEntidadUsuario As New Usuario

    'Variables para uso interno
    'variable de numero de planeamiento
    Dim lint_NPLNMT As Integer
    'variable de localidad de origen en base al numero de planeamiento
    Dim lint_CLCLOR As Integer
    'variable de localidad de destino en base al numero de planeamiento
    Dim lint_CLCLDS As Integer
    'variable local para saber si es guía autogenerada o manual, seteado para autogenerada falso
    Dim lbool_TipoGuia_Autogenerada As Boolean = False

    'Objeto que almacena las guias de cliente seleccionada
    Dim objDTB_GuiasCliente As New DataTable
    'Objeto que almacena las guias anexas de transportista
    Dim objDTB_GuiasTransportistaAnexas As New DataTable
    'Objeto que almacena con las ordenes de compra
    Dim objDTB_OrdenesdeCompra As New DataTable

    'Variable que indica si es que se han agregado elementos de guia de cliente
    Dim lbool_GuardadoGuiaTransportista As Boolean = False
    Dim lsrt_NumeroGuiaTransportista As String = ""

    Private Sub CTLGuiaTransportista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Cargando los datos de combos
        Cargar_Combo()
        'Cargando los datos de usuario
        Cargar_Datos_Usuarios()
        'Estableciendo los datos iniciales del formulario
        Establecer_Compania_Usuario_Actual()
        'Estableciendo la disposicion de elementos
        Me.HGRegistroGuiasTransportista.Collapsed = False
        'Cargando la estructura de datatable
        Estructura_Datatables()
        'Mostrando el mes acutal en el datetimepicker
        Me.dtpFecha.Value = Today

        ClearMemory()

    End Sub

    Private Sub Estructura_Datatables()

        objDTB_GuiasCliente.Columns.Add("NGUIRM")
        objDTB_GuiasCliente.Columns.Add("CLIENTE")
        objDTB_GuiasCliente.Columns.Add("CCLNT")
        objDTB_GuiasCliente.Columns.Add("FECHA")
        objDTB_GuiasCliente.Columns.Add("NUEVO")
 
        objDTB_GuiasTransportistaAnexas.Columns.Add("NGUIAD")
        objDTB_GuiasTransportistaAnexas.Columns.Add("FGUIRM")
        objDTB_GuiasTransportistaAnexas.Columns.Add("NUEVO")
 
        objDTB_OrdenesdeCompra.Columns.Add("NGUICL")
        objDTB_OrdenesdeCompra.Columns.Add("NORCMC")
        objDTB_OrdenesdeCompra.Columns.Add("NUEVO")

    End Sub

    Public Sub Cargar_Combo()

        Dim objCompania As New CompaniaDAO
        Dim objTransportista As New TransportistaDAO
        Dim objUbigeo As New UbigeoDAO
        Dim objUnidadMedida As New UnidadMedidaDAO
        Dim objMoneda As New MonedaDAO
        Dim objCliente As New ClienteDAO
        Dim objchofer As New ChoferDAO

        With Me.cboCompania
            .DataSource = objCompania.Listar_Compania_Combo()
            .ValueMember = "CCMPN"
            .DisplayMember = "TCMPCM"
        End With

        With Me.txtTransportista
            .DataSource = objTransportista.Listar_Transportes()
            .KeyField = "CTRSPT"
            .ValueField = "TCMTRT"
            .DataBind()
        End With

        With Me.txtBrevete
            .DataSource = objchofer.Listar_Choferes()
            .KeyField = "CBRCNT"
            .ValueField = "TNMBCH"
            .DataBind()
        End With

        With Me.txtOrigen
            .DataSource = objUbigeo.Listar_Ubigeo
            .KeyField = "CUBGEO"
            .ValueField = "TDSTR"
            .DataBind()
        End With

        With Me.txtDestino
            .DataSource = objUbigeo.Listar_Ubigeo
            .KeyField = "CUBGEO"
            .ValueField = "TDSTR"
            .DataBind()
        End With

        With Me.txtUnidadMedida
            .DataSource = objUnidadMedida.Listar_Unidad_Medida_Combo()
            .KeyField = "CUNDMD"
            .ValueField = "TCMPUN"
            .DataBind()
        End With

        With Me.txtMonedaFlete
            .DataSource = objMoneda.Listar_Monedas_Combo
            .KeyField = "CMNDA1"
            .ValueField = "TMNDA"
            .DataBind()
        End With

        With Me.txtMonedaValorPatrimonio
            .DataSource = objMoneda.Listar_Monedas_Combo
            .KeyField = "CMNDA1"
            .ValueField = "TMNDA"
            .DataBind()
        End With

        Me.cboCompania.SelectedIndex = 0

        ClearMemory()

    End Sub

    Private Sub cboCompaniaConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
        If sender.focused = False Then
            Exit Sub
        End If
        Me.Carga_Combo_Division(Me.cboCompania, Me.cboDivision)
    End Sub

    Private Sub cboDivisionConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
        If sender.focused = False Then
            Exit Sub
        End If
        Carga_Combo_Planta(Me.cboCompania, Me.cboDivision, Me.cboPlanta)
    End Sub

    Private Sub Establecer_Compania_Usuario_Actual()

        'Estableciendo como origen el codigo de la compañia actual
        Me.cboCompania.SelectedValue = objEntidadUsuario.CCMPOR
        Carga_Combo_Division(Me.cboCompania, Me.cboDivision)
        Me.cboDivision.SelectedValue = objEntidadUsuario.CDVSNU
        Carga_Combo_Planta(Me.cboCompania, Me.cboDivision, Me.cboPlanta)

        Try
            Me.cboPlanta.SelectedValue = HelpClass.getSetting("Planta")
        Catch:End Try

    End Sub

    Private Sub Carga_Combo_Division(ByRef objcboCompania As Windows.Forms.ComboBox, ByRef objcboDivision As Windows.Forms.ComboBox)

        Dim objEntidad As New Division
        Dim objDivision As New DivisionDAO
        objEntidad.CCMPN = objcboCompania.SelectedValue
        objcboDivision.DataSource = Nothing
        With objcboDivision
            .DataSource = objDivision.Listar_Division_Combo(objEntidad)
            .ValueMember = "CDVSN"
            .DisplayMember = "TCMPDV"
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub Carga_Combo_Planta(ByRef objcboCompania As Windows.Forms.ComboBox, ByRef objcboDivision As Windows.Forms.ComboBox, ByRef objcboPlanta As Windows.Forms.ComboBox)
        Dim objEntidad As New Detalle_Planta_Division_Compania
        Dim objPlanta As New PlantaDAO
        objEntidad.CCMPN = objcboCompania.SelectedValue
        objEntidad.CDVSN = objcboDivision.SelectedValue
        objcboPlanta.DataSource = Nothing
        With objcboPlanta
            .DataSource = objPlanta.Listar_Planta_Combo(objEntidad)
            .ValueMember = "CPLNDV"
            .DisplayMember = "TPLNTA"
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub Cargar_Datos_Usuarios()
        Dim objEntidad As New Usuario
        Dim objUsuario As New UsuarioDAO
        objEntidad.MMCUSR = ConfigurationWizard.UserName()
        objEntidad = objUsuario.Obtener_Datos_Usuario(objEntidad)
        objEntidadUsuario = objEntidad
    End Sub

    Private Sub Registrar_Guia()

        'Aplicando validaciones de ingreso de datos
        Dim validacion As String = ""
        'asignando lo obtenido de la validacion
        validacion = Validar_Registro_Guia_Transportista()
        'preguntando si paso la validacion
        If validacion.Equals("") = False Then
            MessageBox.Show(validacion, "Solmin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
       
        Dim objEntidad As New GuiaRemisionTransporte
        Dim objGuiaRemisionTransporte As New GuiasTransportistaDAO

        objEntidad.CTRMNC = Me.txtTransportista.Codigo

        If Me.lbool_TipoGuia_Autogenerada = False Then
            objEntidad.NGUIRM = CInt(Replace(Me.txtNroGuiaRemision.Text, "-", ""))
        End If

        objEntidad.FGUIRM = HelpClass.CtypeDate(Me.dtpFechaGuia.Value)
        objEntidad.NPLNMT = Me.txtPlaneamiento.Text
        objEntidad.CLCLOR = Me.lint_CLCLOR
        objEntidad.CLCLDS = Me.lint_CLCLDS
        objEntidad.TDIROR = Me.txtDireccionOrigen.Text
        objEntidad.TDIRDS = Me.txtDireccionDestino.Text
        objEntidad.NOPRCN = "0"
        objEntidad.TRFRGU = Me.txtLugar.Text
        objEntidad.QMRCMC = IIf(Me.txtCantidad.Text.Equals("") = True, "0", Me.txtCantidad.Text)
        objEntidad.PMRCMC = IIf(Me.txtPeso.Text.Equals("") = True, "0", Me.txtPeso.Text)
        objEntidad.CUNDMD = Me.txtUnidadMedida.Codigo
        'Datos que están sólo en Produccion, mas no en Desarrollo
        objEntidad.QGLGSL = IIf(Me.txtGalonesGasolina.Text.Equals("") = True, "0", Me.txtGalonesGasolina.Text)
        objEntidad.QGLDSL = IIf(Me.txtGalonesDiesel.Text.Equals("") = True, "0", Me.txtGalonesDiesel.Text)
        objEntidad.NRHJCR = IIf(Me.txtHojaCarguio.Text.Equals("") = True, "0", Me.txtHojaCarguio.Text)
        '---
        objEntidad.CTRSPT = Me.txtTransportista.Codigo
        objEntidad.NPLCTR = Me.txtPlacaTracto.Text
        objEntidad.NPLCAC = Me.txtAcoplado.Text
        objEntidad.CBRCNT = Me.txtBrevete.Codigo
        objEntidad.TNMBRM = Me.txtRemitente.Text
        objEntidad.TDRCRM = Me.txtDireccionRemitente.Text
        objEntidad.TPDCIR = IIf(Me.rdRucRemitente.Checked = True, "R", "L")
        objEntidad.NRUCRM = IIf(Me.txtNroDocumentoRemitente.Text.Equals("") = True, "0", Me.txtNroDocumentoRemitente.Text)
        objEntidad.TNMBCN = Me.txtConsignatario.Text
        objEntidad.TDRCNS = Me.txtDireccionConsignatario.Text
        objEntidad.TPDCIC = IIf(Me.rdRucConsignatario.Checked = True, "R", "L")
        objEntidad.NRUCCN = IIf(Me.txtNroDocumentoConsignatario.Text.Equals("") = True, "0", Me.txtNroDocumentoConsignatario.Text)
        objEntidad.SACRGO = IIf(Me.ckbRemitente.Checked = True, "R", "D")
        objEntidad.CMNFLT = IIf(Me.txtMonedaFlete.NoHayCodigo = True, "0", Me.txtMonedaFlete.Codigo)
        objEntidad.SESTRG = "A"
        objEntidad.FLGADC = ""
        objEntidad.SIDAVL = IIf(Me.ckbIda.Checked = True, "I", "V")
        objEntidad.QKMREC = IIf(Me.txtKilometrosXRecorrer.Text.Equals("") = True, "0", Me.txtKilometrosXRecorrer.Text)
        objEntidad.ICSTRM = IIf(Me.txtCostoTramo.Text.Equals("") = True, "0", Me.txtCostoTramo.Text)
        objEntidad.QPSOBR = IIf(Me.txtPesoBruto.Text.Equals("") = True, "0", Me.txtPesoBruto.Text)
        objEntidad.QVLMOR = IIf(Me.txtVolumenRemision.Text.Equals("") = True, "0", Me.txtVolumenRemision.Text)
        objEntidad.SMRPLG = IIf(Me.ckbMercaderiaPeligrosa.Checked = True, "X", "")
        objEntidad.SMRPRC = IIf(Me.ckbMercaderiaPerecible.Checked = True, "X", "")
        objEntidad.IVLPRT = IIf(Me.txtValorPatrimonio.Text.Equals("") = True, "0", Me.txtValorPatrimonio.Text)
        objEntidad.CMNVLP = IIf(Me.txtMonedaValorPatrimonio.NoHayCodigo = True, "0", Me.txtMonedaValorPatrimonio.Codigo)
        objEntidad.CCMPN = Me.cboCompania.SelectedValue
        objEntidad.CDVSN = Me.cboDivision.SelectedValue
        objEntidad.CPLNDV = Me.cboPlanta.SelectedValue
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = ConfigurationWizard.UserName
        objEntidad.NTRMNL = HelpClass.NombreMaquina
        objEntidad.CUBORI = Me.txtOrigen.Codigo
        objEntidad.CUBDES = Me.txtDestino.Codigo
        objEntidad.FEMVLH = HelpClass.CtypeDate(Me.dtpFechaTranslado.Value)
        objEntidad.NESTDO = "0"
        objEntidad.NRSERI = "0"
        objEntidad.NPRGUI = "0"

        'Procedemos a verificar si ya existe ese numero de guia registrada
        If objGuiaRemisionTransporte.Existe_Guia_Transportista(objEntidad) = True Then
            MessageBox.Show("Ya existe una guia con el número " & objEntidad.NGUIRM & " para el transportista seleccionado", "solmin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim objResultado As String
        If Me.lbool_TipoGuia_Autogenerada = False Then
            objResultado = objGuiaRemisionTransporte.Registrar_Guia_Transportista(objEntidad)
        Else
            objResultado = objGuiaRemisionTransporte.Registrar_Guia_Transportista_AutoGenerada(objEntidad)
        End If

        If objResultado.Equals("NO") = False Then 'si se ha grabado correctamente
            lbool_GuardadoGuiaTransportista = True
            lsrt_NumeroGuiaTransportista = Me.txtNroGuiaRemision.Text.Trim.Replace("-", "")
            MessageBox.Show("Guía Generada Correctamente - Nro Guia :" & lsrt_NumeroGuiaTransportista)
        End If

        MessageBox.Show(IIf(objResultado.Equals("NO") = True, "Error al Registrar", objResultado), "Solmin", MessageBoxButtons.OK)

        Me.HGRegistroGuiasTransportista.Collapsed = True

        ClearMemory()

    End Sub

    Private Function Validar_Registro_Guia_Transportista() As String

        Dim validacion As String = ""

        If Me.txtTransportista.NoHayCodigo = True Then
            validacion += "Debe de Seleccionar un Transportista" & Chr(13)
        End If

        'si es guía autogenerada
        If Me.lbool_TipoGuia_Autogenerada = True Then
            If Me.txtNroGuiaRemision.Equals("") = True Then
                validacion += "Debe de Ingresar un N° de Guia de Remisión" & Chr(13)
            End If
        End If

        If Me.txtPlaneamiento.Text.Equals("") = True Then
            validacion += "Debe de establecer el número de planeamiento en base al nro de operación" & Chr(13)
        End If

        If Me.txtOrigen.NoHayCodigo = True Then
            validacion += "Debe de seleccionar un punto de origen" & Chr(13)
        End If
        If Me.txtDestino.NoHayCodigo = True Then
            validacion += "Debe de seleccionar un punto de destino" & Chr(13)
        End If
        If Me.txtDireccionOrigen.Equals("") = True Then
            validacion += "Debe de ingresar una direccion de origen" & Chr(13)
        End If
        If Me.txtDireccionDestino.Equals("") = True Then
            validacion += "Debe de ingresar una direccion de destino" & Chr(13)
        End If
        If Me.txtLugar.Equals("") = True Then
            validacion += "Debe de ingresar un lugar" & Chr(13)
        End If
        If Me.txtCantidad.Equals("") = True Or IsNumeric(Me.txtCantidad.Text) = False Then
            validacion += "Debe de ingresar la cantidad a registrar" & Chr(13)
        End If
        If Me.txtPeso.Equals("") = True Or IsNumeric(Me.txtPeso.Text) = False Then
            validacion += "Debe de ingresar el peso de la mercadería" & Chr(13)
        End If
        If Me.txtUnidadMedida.NoHayCodigo = True Then
            validacion += "Debe de ingresar la unidad de medida" & Chr(13)
        End If
        If Me.txtPlacaTracto.Equals("") = True Then
            validacion += "Debe de ingresar la placa del tracto" & Chr(13)
        End If
        If Me.txtAcoplado.Equals("") = True Then
            validacion += "Debe de ingresar la placa del acoplado" & Chr(13)
        End If
        If Me.txtBrevete.Equals("") = True Then
            validacion += "Debe de ingresar el n° de brevete" & Chr(13)
        End If
        If Me.txtRemitente.Text.Equals("") = True Then
            validacion += "Debe de ingresar el Remitente" & Chr(13)
        End If  
        If Me.txtConsignatario.Text.Equals("") = True Then
            validacion += "Debe de ingresar el Consignatario" & Chr(13)
        End If    
        If Me.cboCompania.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una companía" & Chr(13)
        End If
        If Me.cboDivision.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una división" & Chr(13)
        End If
        If Me.cboPlanta.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una planta" & Chr(13)
        End If

        Return validacion

    End Function

    Private Sub Listar_GuiasTransportista_x_Transportista()
        'Si Hay un codigo seleccionado
        If txtTransportista.NoHayCodigo = False Then

            Dim objGuiaRemisionCliente As New GuiasTransportistaDAO
            Dim objEntidad As New GuiaRemisionTransporte
            Dim objDatos As New DataTable

            objEntidad.CTRMNC = Me.txtTransportista.Codigo
            objEntidad.FGUIRM = HelpClass.CtypeDate(Me.dtpFecha.Value)

            objDatos = objGuiaRemisionCliente.Listar_Guias_Transportista_x_Transportista(objEntidad)

            Me.dtgGuiasTransporte.DataSource = Nothing
            dtgGuiasTransporte.Columns.Clear()

            If objDatos.Rows.Count > 1 Then

                'Estableciendo el origen de datos
                Me.dtgGuiasTransporte.DataSource = objDatos
                'Estableciendo el nombre de las columnas
                Me.dtgGuiasTransporte.Columns(0).HeaderText = "N° Guía Transportista"
                Me.dtgGuiasTransporte.Columns(0).Width = 180
                Me.dtgGuiasTransporte.Columns(1).HeaderText = "Fecha"
                Me.dtgGuiasTransporte.Columns(1).Width = 80
                Me.dtgGuiasTransporte.Columns(2).HeaderText = "N° Planeamiento"
                Me.dtgGuiasTransporte.Columns(2).Width = 100
                Me.dtgGuiasTransporte.Columns(3).HeaderText = "N° Placa Tracto"
                Me.dtgGuiasTransporte.Columns(3).Width = 100
                Me.dtgGuiasTransporte.Columns(4).HeaderText = "N° Placa Acoplado"
                Me.dtgGuiasTransporte.Columns(4).Width = 100
                Me.dtgGuiasTransporte.Columns(5).HeaderText = "Cant. Mercadería"
                Me.dtgGuiasTransporte.Columns(5).Width = 100
                Me.dtgGuiasTransporte.Columns(6).HeaderText = "Peso Mercadería"
                Me.dtgGuiasTransporte.Columns(6).Width = 100
                Me.dtgGuiasTransporte.Columns(7).HeaderText = "Ida / Vuelta"
                Me.dtgGuiasTransporte.Columns(7).Width = 100

            End If

        End If
    End Sub

    Private Sub Listar_Guias_Cliente()
        'Si Hay un codigo seleccionado
        If txtTransportista.NoHayCodigo = False Then

            Dim objGuiaRemisionCliente As New GuiaRemisionClienteDAO
            Dim objEntidad As New GuiaRemisionCliente
            Dim objDatos As New DataTable

            objEntidad.CTRSP = Me.txtTransportista.Codigo

            objDatos = objGuiaRemisionCliente.Listar_Guias_x_Transportista(objEntidad)

            dtgGuiaRemision.DataSource = Nothing
            dtgGuiaRemision.Columns.Clear()
            HGGuiaRemision.ValuesPrimary.Heading = "Guías de Transportista  "
            
            If objDatos.Rows.Count > 1 Then

                'Estableciendo el origen de datos
                Me.dtgGuiaRemision.DataSource = objDatos
                'Estableciendo la columan de checks de seleccion
                Dim Columna As New DataGridViewCheckBoxColumn(False)
                Columna.Width = 25
                dtgGuiaRemision.Columns.Insert(0, Columna)
                dtgGuiaRemision.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                'Dando el nombre de la columna
                HGGuiaRemision.ValuesPrimary.Heading = "Guías de Remisión para el Transportista " & Me.txtTransportista.Descripcion
                 'Estableciendo el nombre de las columnas
                Me.dtgGuiaRemision.Columns(1).HeaderText = "N° Guía"
                Me.dtgGuiaRemision.Columns(1).Width = 80
                Me.dtgGuiaRemision.Columns(2).HeaderText = "Cliente"
                Me.dtgGuiaRemision.Columns(2).Width = 200
                Me.dtgGuiaRemision.Columns(3).Visible = False
                Me.dtgGuiaRemision.Columns(4).HeaderText = "Fecha"
                Me.dtgGuiaRemision.Columns(4).Width = 70
                Me.dtgGuiaRemision.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End If

        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        If Me.txtPlaneamiento.Text.Equals("") = True Then
            MessageBox.Show("Debe de seleccionar datos de cabecera antes de registrar una guía de transportista", "Solmin", MessageBoxButtons.OK)
            Exit Sub
        End If

        Me.HGRegistroGuiasTransportista.Collapsed = False
        lbool_TipoGuia_Autogenerada = False
        LimpiarTextos() 
        lbool_GuardadoGuiaTransportista = False
        Me.lsrt_NumeroGuiaTransportista = ""
        Me.txtNroGuiaRemision.Enabled = True
        Me.TabControl1.SelectedIndex = 0
        Me.LimpiarCodigosBase()

    End Sub

    Private Sub LimpiarTextos()

         Me.txtNroGuiaRemision.Text = ""
        Me.lint_CLCLDS = 0
        Me.lint_CLCLOR = 0
        Me.dtpFechaGuia.Value = Today
        Me.txtOrigen.Limpiar()
        Me.txtDestino.Limpiar()
        Me.txtDireccionOrigen.Text = ""
        Me.txtDireccionDestino.Text = ""
        Me.txtLugar.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtPeso.Text = ""
        Me.txtUnidadMedida.Limpiar()
         Me.txtPlacaTracto.Text = ""
        Me.txtAcoplado.Text = ""
        Me.txtBrevete.Limpiar()
        Me.txtRemitente.Text = ""
        Me.txtDireccionRemitente.Text = ""
        Me.rdRucRemitente.Checked = True
        Me.txtNroDocumentoRemitente.Text = ""
        Me.txtConsignatario.Text = ""
        Me.txtDireccionConsignatario.Text = ""
        Me.rdRucConsignatario.Checked = True
        Me.txtNroDocumentoConsignatario.Text = ""
        Me.ckbRemitente.Checked = True
        Me.txtMonedaFlete.Limpiar()
        Me.ckbIda.Checked = True
        Me.txtKilometrosXRecorrer.Text = ""
        Me.txtCostoTramo.Text = ""
        Me.txtPesoBruto.Text = ""
        Me.txtVolumenRemision.Text = ""
        Me.ckbMercaderiaPeligrosa.Checked = False
        Me.ckbMercaderiaPerecible.Checked = False
        Me.txtValorPatrimonio.Text = ""
        Me.txtMonedaValorPatrimonio.Limpiar()
        Me.txtOrigen.Limpiar()
        Me.txtDestino.Limpiar()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.HGRegistroGuiasTransportista.Collapsed = True
        lbool_GuardadoGuiaTransportista = False
        Me.LimpiarTextos()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim frmPrint As New PrintForm
        frmPrint.ShowForm(ReporteGuiaTransportista, Me)

    End Sub

    Private Function ReporteGuiaTransportista() As ReportClass

        Dim validacion As String = ""

        If Me.cboCompania.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una compania" & Chr(13)
        End If
        If Me.cboDivision.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una division" & Chr(13)
        End If
        If Me.cboPlanta.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una planta" & Chr(13)
        End If

        If Me.txtTransportista.NoHayCodigo = True Then
            validacion += "Debe de seleccionar un transportista" & Chr(13)
        Else
            If Me.txtTransportista.Codigo <> 1 Then
                validacion += "El transportista debe ser del tipo propio"
            End If
        End If

        'Mostrando la validacion
        If validacion.Equals("") = False Then
            MessageBox.Show(validacion, "Solmin", MessageBoxButtons.OK)
            Return Nothing
            Exit Function
        End If

        'Objeto para obtener los datos
        Dim objEntidad As New GuiaRemisionTransporte
        Dim objGuiaTransporte As New GuiasTransportistaDAO
        'Objeto reporte de guia de transportista
        Dim objReporte As New rptGuiaTransportista
        'Estableciendo el codigo del transportista
        objEntidad.CTRMNC = Me.txtTransportista.Codigo
        Dim nroGuiaRemision As String = txtNroGuiaRemision.Text.Trim().Replace("-", "")

        'Primero verificando la obtencion de los datos
        'si es que la casilla de nro de guia esta lleno, se procede a
        'utilizar ese dato, sino muestra la pantalla de solicitud de input

        If nroGuiaRemision.Equals("") = False And Me.txtPlaneamiento.Text.Trim().Equals("") = False Then
            objEntidad.NGUIRM = CType(Me.txtNroGuiaRemision.Text.Trim.Replace("-", ""), Long)
        Else
            Dim NumeroGuia As String
            NumeroGuia = InputBox("Ingrese Número de Guía de Transportista.  ", "Solmin", "")
            'Verificando la autenticidad del numero ingresado
            objEntidad.NGUIRM = CType(NumeroGuia.Replace("-", ""), Long)

            If objGuiaTransporte.Existe_Guia_Transportista(objEntidad) = False Then
                MessageBox.Show("El Número de Guía ingresado no corresponde al transportista", "Solmin", MessageBoxButtons.OK)
                Return Nothing
                Exit Function
            End If

        End If

        'Obteniendo todos los datos de la guia
        objEntidad = objGuiaTransporte.Obtener_Guia_Transportista(objEntidad)

        'Limpiando todos los ITextObject del Reporte
        Me.Limpiar_Contenido_Reporte(objReporte)

        'Enlazando los datos del ITextObject del Reporte 
        CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = objEntidad.TRFRGU & "  -   " & HelpClass.CNumero_a_Fecha(objEntidad.FGUIRM)
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""

        Dim objEntidadChofer As New Chofer
        Dim objChofer As New ChoferDAO
        objEntidadChofer.CBRCNT = objEntidad.CBRCNT
        objEntidadChofer = objChofer.Obtener_Chofer(objEntidadChofer)

        CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = objEntidadChofer.TNMBCH
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = objEntidad.CBRCNT
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = objEntidadChofer.NLELCH
        CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = objEntidad.TNMBRM
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = objEntidad.TNMBCN
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = objEntidad.TDRCRM
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = objEntidad.NRUCRM
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = objEntidad.TDRCNS
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = objEntidad.NRUCCN

        CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = "Prueba de Guias" & Chr(13) & Chr(10) & Chr(9) & "en varias lineas" & Chr(13) & Chr(10) & Chr(9) & "guias"

        CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = objEntidad.QMRCMC
        CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = objEntidad.PMRCMC
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = objEntidad.SMRPLG
        CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = objEntidad.SMRPRC
        CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = objEntidad.QVLMOR
        CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = objEntidad.IVLPRT
        CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = objEntidad.QKMREC
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = objEntidad.TDIRDS
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = objEntidad.TDIRDS
        CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = HelpClass.CNumero_a_Fecha(objEntidad.FEMVLH)

        'retornando el reporte
        Return objReporte

    End Function

    Private Sub Limpiar_Contenido_Reporte(ByVal objReporte As ReportClass)

        CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = ""

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If lbool_GuardadoGuiaTransportista = False Then
            Registrar_Guia()
            GoTo ZonaDetalles
        End If

        If Me.lsrt_NumeroGuiaTransportista.Equals("") = False Then
            If MessageBox.Show("Desea modificar los datos?", "Solmin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Modificar_Guia()
            End If
        End If

ZonaDetalles:
        'Verificando si hay registros en el datatable de Guias de Cliente
        If Me.objDTB_GuiasCliente.Rows.Count > 0 Then
            Registro_Guias_Cliente()
        End If

        'Verificando si hay registros en el datatable de Ordenes de Compra
        If Me.objDTB_OrdenesdeCompra.Rows.Count > 0 Then
            Registro_Ordenes_Compra()
        End If

        'Verificando si hay registros en el datatable de Guias de Transportista Anexa
        If Me.objDTB_GuiasTransportistaAnexas.Rows.Count > 0 Then
            Registro_Guias_Transportista_Anexa()
        End If

        'Listando las guias de remision
        Listar_GuiasTransportista_x_Transportista()
    
    End Sub

    Private Sub Modificar_Guia()

        'Aplicando validaciones de ingreso de datos
        Dim validacion As String = ""
        'asignando lo obtenido de la validacion
        validacion = Validar_Registro_Guia_Transportista()
        'preguntando si paso la validacion
        If validacion.Equals("") = False Then
            MessageBox.Show(validacion, "Solmin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim objEntidad As New GuiaRemisionTransporte
        Dim objGuiaRemisionTransporte As New GuiasTransportistaDAO

        objEntidad.CTRMNC = Me.txtTransportista.Codigo
        'Numero de Guia
        objEntidad.NGUIRM = Me.lsrt_NumeroGuiaTransportista
        objEntidad.FGUIRM = HelpClass.CtypeDate(Me.dtpFechaGuia.Value)

        objEntidad.NPLNMT = Me.txtPlaneamiento.Text
        objEntidad.CLCLOR = Me.lint_CLCLOR
        objEntidad.CLCLDS = Me.lint_CLCLDS
        objEntidad.TDIROR = Me.txtDireccionOrigen.Text
        objEntidad.TDIRDS = Me.txtDireccionDestino.Text
        objEntidad.NOPRCN = "0"
        objEntidad.TRFRGU = Me.txtLugar.Text
        objEntidad.QMRCMC = IIf(Me.txtCantidad.Text.Equals("") = True, "0", Me.txtCantidad.Text)
        objEntidad.PMRCMC = IIf(Me.txtPeso.Text.Equals("") = True, "0", Me.txtPeso.Text)
        objEntidad.CUNDMD = Me.txtUnidadMedida.Codigo
        'Datos sólo de produccion no de desarrollo
        objEntidad.QGLGSL = IIf(Me.txtGalonesGasolina.Text.Equals("") = True, "0", Me.txtGalonesGasolina.Text)
        objEntidad.QGLDSL = IIf(Me.txtGalonesDiesel.Text.Equals("") = True, "0", Me.txtGalonesDiesel.Text)
        objEntidad.NRHJCR = IIf(Me.txtHojaCarguio.Text.Equals("") = True, "0", Me.txtHojaCarguio.Text)
        '----
        objEntidad.CTRSPT = Me.txtTransportista.Codigo
        objEntidad.NPLCTR = Me.txtPlacaTracto.Text
        objEntidad.NPLCAC = Me.txtAcoplado.Text
        objEntidad.CBRCNT = Me.txtBrevete.Codigo
        objEntidad.TNMBRM = Me.txtRemitente.Text
        objEntidad.TDRCRM = Me.txtDireccionRemitente.Text
        objEntidad.TPDCIR = IIf(Me.rdRucRemitente.Checked = True, "R", "L")
        objEntidad.NRUCRM = IIf(Me.txtNroDocumentoRemitente.Text.Equals("") = True, "0", Me.txtNroDocumentoRemitente.Text)
        objEntidad.TNMBCN = Me.txtConsignatario.Text
        objEntidad.TDRCNS = Me.txtDireccionConsignatario.Text
        objEntidad.TPDCIC = IIf(Me.rdRucConsignatario.Checked = True, "R", "L")
        objEntidad.NRUCCN = IIf(Me.txtNroDocumentoConsignatario.Text.Equals("") = True, "0", Me.txtNroDocumentoConsignatario.Text)
        objEntidad.SACRGO = IIf(Me.ckbRemitente.Checked = True, "R", "D")
        objEntidad.CMNFLT = IIf(Me.txtMonedaFlete.NoHayCodigo = True, "0", Me.txtMonedaFlete.Codigo)
        objEntidad.SESTRG = "A"
        objEntidad.FLGADC = ""
        objEntidad.SIDAVL = IIf(Me.ckbIda.Checked = True, "I", "V")
        objEntidad.QKMREC = IIf(Me.txtKilometrosXRecorrer.Text.Equals("") = True, "0", Me.txtKilometrosXRecorrer.Text)
        objEntidad.ICSTRM = IIf(Me.txtCostoTramo.Text.Equals("") = True, "0", Me.txtCostoTramo.Text)
        objEntidad.QPSOBR = IIf(Me.txtPesoBruto.Text.Equals("") = True, "0", Me.txtPesoBruto.Text)
        objEntidad.QVLMOR = IIf(Me.txtVolumenRemision.Text.Equals("") = True, "0", Me.txtVolumenRemision.Text)
        objEntidad.SMRPLG = IIf(Me.ckbMercaderiaPeligrosa.Checked = True, "X", "")
        objEntidad.SMRPRC = IIf(Me.ckbMercaderiaPerecible.Checked = True, "X", "")
        objEntidad.IVLPRT = IIf(Me.txtValorPatrimonio.Text.Equals("") = True, "0", Me.txtValorPatrimonio.Text)
        objEntidad.CMNVLP = IIf(Me.txtMonedaValorPatrimonio.NoHayCodigo = True, "0", Me.txtMonedaValorPatrimonio.Codigo)
        objEntidad.CCMPN = Me.cboCompania.SelectedValue
        objEntidad.CDVSN = Me.cboDivision.SelectedValue
        objEntidad.CPLNDV = Me.cboPlanta.SelectedValue
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = ConfigurationWizard.UserName
        objEntidad.NTRMNL = HelpClass.NombreMaquina
        objEntidad.CUBORI = Me.txtOrigen.Codigo
        objEntidad.CUBDES = Me.txtDestino.Codigo
        objEntidad.FEMVLH = HelpClass.CtypeDate(Me.dtpFechaTranslado.Value)
        objEntidad.NESTDO = "0"
        objEntidad.NRSERI = "0"
        objEntidad.NPRGUI = "0"

        Dim objResultado As String = objGuiaRemisionTransporte.Modificar_Guia_Transportista(objEntidad)

        MessageBox.Show(IIf(objResultado.Equals("NO") = True, "Error al Modificar", objResultado), "Solmin", MessageBoxButtons.OK)
          Me.HGRegistroGuiasTransportista.Collapsed = True

    End Sub

    Private Sub Registro_Guias_Cliente()

        Dim objEntidadGuiaCliente As New GuiaRemisionCliente
        Dim objGuiasRemisionCliente As New GuiaRemisionClienteDAO

        Dim objEntidadAnexoGuiaCliente As New AnexoGuiasRemisionGuiasCliente
        Dim objanexoGuiaCliente As New AnexoGuiasRemisionGuiasClienteDAO

        For i As Integer = 0 To objDTB_GuiasCliente.Rows.Count - 1

            If objDTB_GuiasCliente.Rows(i).Item("NUEVO").ToString().Trim().Equals("SI") = True Then
                'Limpiando el contenido
                objEntidadGuiaCliente.CCLNT = 0
                objEntidadGuiaCliente.NGUIRM = 0
                objEntidadGuiaCliente.CTRSP = 0
                'Estableciendo el nuevo contenido
                objEntidadGuiaCliente.CCLNT = objDTB_GuiasCliente.Rows(i).Item("CCLNT")
                objEntidadGuiaCliente.NGUIRM = objDTB_GuiasCliente.Rows(i).Item("NGUIRM")
                objEntidadGuiaCliente.CTRSP = Me.txtTransportista.Codigo
                'Obteniendo todos los datos de la guia de cliente
                objEntidadGuiaCliente = objGuiasRemisionCliente.Obtener_Guia_Cliente(objEntidadGuiaCliente)
                'Llenando los datos de la guia de Anexo

                objEntidadAnexoGuiaCliente.CTRMNC = Me.txtTransportista.Codigo
                objEntidadAnexoGuiaCliente.NGUIRM = CType(lsrt_NumeroGuiaTransportista, Long)
                objEntidadAnexoGuiaCliente.NRGUCL = objDTB_GuiasCliente.Rows(i).Item("NGUIRM")
                objEntidadAnexoGuiaCliente.FCGUCL = objEntidadGuiaCliente.FGUIRM
                objEntidadAnexoGuiaCliente.CCLNT = objDTB_GuiasCliente.Rows(i).Item("CCLNT")
                objEntidadAnexoGuiaCliente.FULTAC = HelpClass.TodayNumeric
                objEntidadAnexoGuiaCliente.HULTAC = HelpClass.NowNumeric
                objEntidadAnexoGuiaCliente.CULUSA = ConfigurationWizard.UserName
                objEntidadAnexoGuiaCliente.NTRMNL = HelpClass.NombreMaquina
                objEntidadAnexoGuiaCliente.NRSERI = 0
                objEntidadAnexoGuiaCliente.NPRGUI = 0

                'Proceso de registro
                objanexoGuiaCliente.Registrar_GuiasCliente(objEntidadAnexoGuiaCliente)
            End If

        Next

        'Lista las guias de cliente pendiente
        Listar_Guias_Cliente()
        'Lista las guias ya registradas
        Cargar_Guias_Cliente_registradas()

    End Sub

    Private Sub Cargar_Guias_Cliente_registradas()

        Dim objEntidadAnexoGuiaCliente As New AnexoGuiasRemisionGuiasCliente
        Dim objanexoGuiaCliente As New AnexoGuiasRemisionGuiasClienteDAO

        Dim objDTB_ListadoGuiasRegistradas As New DataTable
        objEntidadAnexoGuiaCliente.CTRMNC = Me.txtTransportista.Codigo
        objEntidadAnexoGuiaCliente.NGUIRM = Me.lsrt_NumeroGuiaTransportista
        objDTB_ListadoGuiasRegistradas = objanexoGuiaCliente.Listar_Guias_Anexas(objEntidadAnexoGuiaCliente)

        Me.objDTB_GuiasCliente.Clear()

        For i As Integer = 0 To objDTB_ListadoGuiasRegistradas.Rows.Count - 1

            Dim dr As DataRow = objDTB_GuiasCliente.NewRow
            dr(0) = objDTB_ListadoGuiasRegistradas.Rows(i).Item("NRGUCL")
            dr(1) = objDTB_ListadoGuiasRegistradas.Rows(i).Item("cliente")
            dr(2) = objDTB_ListadoGuiasRegistradas.Rows(i).Item("CCLNT")
            dr(3) = HelpClass.CNumero_a_Fecha(objDTB_ListadoGuiasRegistradas.Rows(i).Item("FCGUCL")).ToShortDateString()
            dr(4) = "NO"
            objDTB_GuiasCliente.Rows.Add(dr)
            dr = Nothing

        Next

        Enlace_Datos_Guias_Seleccionadas()

    End Sub

    Private Sub Registro_Ordenes_Compra()

        Dim objEntidad As New GuiaOCManifiestoCarga
        Dim objGuiaOCManifiestoCarga As New GuiaOCManifiestoCargaDAO

        For i As Integer = 0 To Me.objDTB_OrdenesdeCompra.Rows.Count - 1

            If objDTB_OrdenesdeCompra.Rows(i).Item("NUEVO").Equals("SI") = True Then

                objEntidad.NMNFCR = Me.lsrt_NumeroGuiaTransportista
                objEntidad.NGUICL = objDTB_OrdenesdeCompra.Rows(i).Item("NGUICL")
                objEntidad.NORCMC = objDTB_OrdenesdeCompra.Rows(i).Item("NORCMC")
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric
                objEntidad.CULUSA = ConfigurationWizard.UserName
                objEntidad.NTRMNL = HelpClass.NombreMaquina

                objGuiaOCManifiestoCarga.Registrar_ManifiestoCarga(objEntidad)

            End If

        Next

        Cargar_Ordenes_Compra_registradas()

    End Sub

    Private Sub Cargar_Ordenes_Compra_registradas()

        Dim objEntidad As New GuiaOCManifiestoCarga
        Dim objGuiaOCManifiestoCarga As New GuiaOCManifiestoCargaDAO

        Dim objDTB_ListadoOrdenesCompra As New DataTable 
        objEntidad.NMNFCR = Me.lsrt_NumeroGuiaTransportista
        objDTB_ListadoOrdenesCompra = objGuiaOCManifiestoCarga.Listar_Ordenes_Compra_x_MC(objEntidad)

        Dim objDTB_Clon As DataTable = Me.objDTB_OrdenesdeCompra.Copy

        Me.objDTB_OrdenesdeCompra.Clear()

        For i As Integer = 0 To objDTB_ListadoOrdenesCompra.Rows.Count - 1

            Dim dr As DataRow = objDTB_OrdenesdeCompra.NewRow
            dr(0) = objDTB_ListadoOrdenesCompra.Rows(i).Item("NGUICL")
            dr(1) = objDTB_ListadoOrdenesCompra.Rows(i).Item("NORCMC")
            dr(2) = "NO"
            objDTB_OrdenesdeCompra.Rows.Add(dr)
            dr = Nothing

        Next

        For i As Integer = 0 To objDTB_Clon.Rows.Count - 1

            If objDTB_Clon.Rows(i).Item("NUEVO").Equals("SI") = True Then

                Dim dr As DataRow = objDTB_Clon.NewRow
                dr(0) = objDTB_Clon.Rows(i).Item("NGUICL")
                dr(1) = objDTB_Clon.Rows(i).Item("NORCMC")
                dr(2) = "SI"
                objDTB_Clon.Rows.Add(dr)
                dr = Nothing

            End If

        Next

        Enlace_Datos_Ordenes_Compra()

    End Sub

    Private Sub Enlace_Datos_Ordenes_Compra()

        'Limpiando la estructura del grid
        Me.dtgOrdenCompra.DataSource = Nothing
        dtgOrdenCompra.Columns.Clear()

        'Dando origen de datos a la grilla de items seleccionados
        Me.dtgOrdenCompra.DataSource = Me.objDTB_OrdenesdeCompra
 
        dtgOrdenCompra.Columns(0).HeaderText = "N° Guia"
        dtgOrdenCompra.Columns(1).HeaderText = "Orden de Compra"
        dtgOrdenCompra.Columns(2).HeaderText = "NUEVO_REGISTRO"
        dtgOrdenCompra.Columns(2).Visible = False

    End Sub

    Private Sub Registro_Guias_Transportista_Anexa()

        Dim objEntidad As New GuiaTransportistaAdicional
        Dim objGuiaTransportistaAdicional As New GuiaTransportistaAnexoDAO

        For i As Integer = 0 To Me.objDTB_GuiasTransportistaAnexas.Rows.Count - 1

            If objDTB_GuiasTransportistaAnexas.Rows(i).Item("NUEVO").Equals("SI") = True Then

                objEntidad.CTRMNC = Me.txtTransportista.Codigo
                objEntidad.SESTRG = "A"
                objEntidad.NGUIRM = Me.lsrt_NumeroGuiaTransportista
                objEntidad.NGUIAD = objDTB_GuiasTransportistaAnexas.Rows(i).Item("NGUIAD")
                objEntidad.FGUIRM = HelpClass.CtypeDate(objDTB_GuiasTransportistaAnexas.Rows(i).Item("FGUIRM"))
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric
                objEntidad.CULUSA = ConfigurationWizard.UserName
                objEntidad.NTRMNL = HelpClass.NombreMaquina
                objGuiaTransportistaAdicional.Registrar_GuiaTransportistaAdicional(objEntidad)

            End If

        Next

        Cargar_Guias_Transportista_Anexa_registradas()

    End Sub

    Private Sub Cargar_Guias_Transportista_Anexa_registradas()

        Dim objEntidad As New GuiaTransportistaAdicional
        Dim objGuiaTransportistaAdicional As New GuiaTransportistaAnexoDAO

        Dim objDTB_ListadoGuiasRegistradas As New DataTable
        objEntidad.CTRMNC = Me.txtTransportista.Codigo
        objEntidad.NGUIRM = Me.lsrt_NumeroGuiaTransportista
        objDTB_ListadoGuiasRegistradas = objGuiaTransportistaAdicional.Listar_Guias_Anexas(objEntidad)

        'Creando un clon para guardar lo que contenia la tabla
        Dim objDTB_Clon As DataTable = objDTB_GuiasTransportistaAnexas.Copy()

        Me.objDTB_GuiasTransportistaAnexas.Clear()

        For i As Integer = 0 To objDTB_ListadoGuiasRegistradas.Rows.Count - 1

            Dim dr As DataRow = objDTB_GuiasTransportistaAnexas.NewRow
            dr(0) = objDTB_ListadoGuiasRegistradas.Rows(i).Item("NGUIAD")
            dr(1) = objDTB_ListadoGuiasRegistradas.Rows(i).Item("FGUIRM")
            dr(2) = "NO"
            objDTB_GuiasTransportistaAnexas.Rows.Add(dr)
            dr = Nothing

        Next

        For i As Integer = 0 To objDTB_Clon.Rows.Count - 1

            If objDTB_Clon.Rows(i).Item("NUEVO").Equals("SI") = True Then

                Dim dr As DataRow = objDTB_Clon.NewRow
                dr(0) = objDTB_Clon.Rows(i).Item("NGUIAD")
                dr(1) = objDTB_Clon.Rows(i).Item("FGUIRM")
                dr(2) = "SI"
                objDTB_Clon.Rows.Add(dr)
                dr = Nothing

            End If

        Next

        Enlace_Datos_Guias_Transportista_Anexa()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar_Datos()
    End Sub

    Private Sub Buscar_Datos()

        Dim validacion As String = ""

        If Me.cboCompania.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una compania" & Chr(13)
        End If
        If Me.cboDivision.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una division" & Chr(13)
        End If
        If Me.cboPlanta.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una planta" & Chr(13)
        End If
        If Me.txtTransportista.NoHayCodigo = True Then
            validacion += "Debe de seleccionar un transportista" & Chr(13)
        End If
        If Me.txtNroOperacion.Text.Equals("") = True Then
            validacion += "Debe de indicar un número de operacion"
        End If

        If validacion.Equals("") = False Then
            MessageBox.Show(validacion, "Solmin", MessageBoxButtons.OK)
            Exit Sub
        End If

        'Primero Verificando si la operacion existe
        Dim objEntidadOperacion As New Operaciones
        Dim objOperacion As New OperacionDAO
        Dim objPlaneamiento As New PlaneamientoDAO
        Dim objEntidadPlaneamiento As New RecursoPlaneamiento
        Dim dtbPlaneamiento As New DataTable

        objEntidadOperacion.NOPRCN = Me.txtNroOperacion.Text
        objEntidadOperacion.CCMPN = Me.cboCompania.SelectedValue
        objEntidadOperacion.CDVSN = Me.cboDivision.SelectedValue
        objEntidadOperacion.CPLNDV = Me.cboPlanta.SelectedValue

        Dim dtbOperacion As New DataTable
        dtbOperacion = objOperacion.Existe_Operacion(objEntidadOperacion)

        'Verificando si tiene datos, procede a seguir buscando
        If dtbOperacion.Rows.Count > 0 Then

            Me.txtPlaneamiento.Text = dtbOperacion.Rows(0).Item("NPLNMT").ToString()
            objEntidadPlaneamiento.NPLNMT = dtbOperacion.Rows(0).Item("NPLNMT").ToString()
            objEntidadPlaneamiento.CTRSPT = Me.txtTransportista.Codigo

            'Obteniendo el codigo de transportista
            dtbPlaneamiento = objPlaneamiento.Listar_Transportista_x_Planeamiento(objEntidadPlaneamiento)

            'Verificando si es que el codigo de transportista ingresado
            ' tiene operaciones asignadas
            If dtbPlaneamiento.Rows.Count > 0 Then

                'si corresponde al transportista, procede a seleccionar su ruta
                dtbPlaneamiento = objPlaneamiento.Listar_Localidad_x_Planeamiento(objEntidadPlaneamiento)

                If dtbPlaneamiento.Rows.Count > 0 Then
                    Me.lint_CLCLOR = dtbPlaneamiento.Rows(0).Item("CLCLOR").ToString()
                    Me.lint_CLCLDS = dtbPlaneamiento.Rows(0).Item("CLCLDS").ToString()
                Else
                    MessageBox.Show("No tiene asignado localidad de origen y de destino", "solmin", MessageBoxButtons.OK)
                    Me.LimpiarCodigosBase()
                    Exit Sub
                End If

                'Listado de Guias de Cliente por transportista
                Me.Listar_Guias_Cliente()
                Listar_GuiasTransportista_x_Transportista()

                'Obteniendo los datos de factor de retorno y de distancia
                Estableciendo_Datos_Servicio_Cotizacion()

                'Averiguando si el transportista es local o no
                'y segun eso se establece si la guia es automatica
                'o la guia es manual
                If Me.txtTransportista.NoHayCodigo = False Then

                    Dim objEntidad As New Transportista
                    Dim objTransportista As New TransportistaDAO
                    'Estableciendo los datos
                    objEntidad.CTRSPT = Me.txtTransportista.Codigo
                    'Obteniendo los datos de la guia
                    objEntidad = objTransportista.Obtener_Datos_Transportista(objEntidad)

                    'Averiguando si el ruc seleccionado le pertenece o no a Ransa
                    'si es asi se emitira automaticamente la guia autogenerada
                    'y bloqueara el ingreso del numero de guia

                    'Ruc de Ransa (ASI ME DIJERON QUE LO ESCRIBA!!!!)
                    If objEntidad.NRUCTR = CType(HelpClass.getSetting("RUCRANSA"), Long) Then
                        'guia autogenerada
                        lbool_TipoGuia_Autogenerada = True
                    Else
                        'guia manual
                        lbool_TipoGuia_Autogenerada = False
                    End If

                    'Listando los planeamientos de vehiculos
                    'Averiguando si es que tiene vehiculos pendientes ese planeamiento
                    'Estableciendo el codigo de planeamiento
                    objEntidadPlaneamiento.NPLNMT = Me.txtPlaneamiento.Text

                    If objPlaneamiento.Listar_Vehiculos_x_Planeamiento(objEntidadPlaneamiento).Rows.Count >= 1 Then

                        'Estableciendo el codigo de transportista
                        objEntidadPlaneamiento.CTRSPT = Me.txtTransportista.Codigo

                        'Mostrando la pantalla
                        Dim objfrmVehiculosPlaneamiento As New frmSeleccionarPlaneamiento
                        objfrmVehiculosPlaneamiento.showForm(objEntidadPlaneamiento, Me)
                        'Recuperando los datos de la guia de transportista
                        objEntidadPlaneamiento = objfrmVehiculosPlaneamiento.Obtener_Recurso_Planeamiento()

                        'Verificando que se hayan seleccionado algun datos
                        If objEntidadPlaneamiento.CBRCNT.Equals("") = True And objEntidadPlaneamiento.NPLCTR.Equals("") = True And objEntidadPlaneamiento.NPLCAC.Equals("") = True And objEntidadPlaneamiento.TNMBCH.Equals("") = True Then
                            MessageBox.Show("Debe de seleccionar un recurso de planeamiento para utilizar esta opcion", "Solmin")
                            Me.LimpiarTextos()
                            Me.LimpiarCodigosBase()
                            Exit Sub
                        Else

                            'Imprimie en las cajas de texto el contenido
                            Me.txtPlacaTracto.Text = objEntidadPlaneamiento.NPLCTR
                            Me.txtAcoplado.Text = objEntidadPlaneamiento.NPLCAC
                            Me.txtBrevete.Codigo = objEntidadPlaneamiento.CBRCNT

                        End If

                    Else
                        MessageBox.Show("No dispone de vehiculos para generar guías con ese número de operación y planeamiento", "Solmin", MessageBoxButtons.OK)
                        Me.LimpiarTextos()
                        Me.LimpiarCodigosBase()
                        Exit Sub
                    End If

                    'Termino del proceso

                End If

            Else
                MessageBox.Show("El transportista ingresado no tiene esa operacion asignada", "solmin", MessageBoxButtons.OK)
                Me.LimpiarCodigosBase()
                Exit Sub
            End If

        Else
            LimpiarCodigosBase()
            MessageBox.Show("N° de operación no válido")
            Exit Sub
        End If
    End Sub

    Private Sub Estableciendo_Datos_Servicio_Cotizacion()

        Dim objEntidadPlaneamiento As New RecursoPlaneamiento
        Dim objPlaneamiento As New PlaneamientoDAO
        Dim objEntidadServicio As New Servicios
        Dim objServicio As New ServicioDAO

        'Estableciendo el planeamiento
        objEntidadPlaneamiento.NPLNMT = Me.txtPlaneamiento.Text
        objEntidadPlaneamiento = objPlaneamiento.Obtener_Servicio_Cotizacion_X_Planeamiento(objEntidadPlaneamiento)

        'recuperando los datos del servicios 
        objEntidadServicio.NCRRSR = objEntidadPlaneamiento.NCRRSR
        objEntidadServicio.NCTZCN = objEntidadPlaneamiento.NCTZCN
        objEntidadServicio.NCRRCT = objEntidadPlaneamiento.NCRRCT

        objEntidadServicio = objServicio.Obtener_Servicio(objEntidadServicio)

        Me.txtKilometrosXRecorrer.Text = objEntidadServicio.QDSTVR

        If objEntidadServicio.SFCRTV.Equals("I") = True Then
            Me.ckbIda.Checked = True
            Me.ckbIdaVuelta.Checked = False
        End If
        If objEntidadServicio.SFCRTV.Equals("V") = True Then
            Me.ckbIda.Checked = False
            Me.ckbIdaVuelta.Checked = True
        End If

    End Sub

    Private Sub LimpiarCodigosBase()
        lsrt_NumeroGuiaTransportista = ""
        Me.txtPlaneamiento.Text = ""
        Me.lint_CLCLDS = 0
        Me.lint_CLCLOR = 0
    End Sub

    Private Sub Elimina_Fila(ByVal indice As Integer)

        Dim guia As String

        guia = Me.dtgGuiaRemision.Rows(indice).Cells(1).Value

        For i As Integer = 0 To Me.objDTB_GuiasCliente.Rows.Count - 1
            If Me.objDTB_GuiasCliente.Rows(i).Item(1).ToString().Equals(guia) = True Then
                objDTB_GuiasCliente.Rows(i).Delete()
            End If
        Next

    End Sub

    Private Sub Agregar_Fila(ByVal indice As Integer)

        Dim guia As String
        Dim cliente As String
        Dim cod_cliente As String
        Dim fecha As String

        'Obteniendo los valores de la grilla y agregandolos al segundo grid
        Dim dr As DataRow = Me.objDTB_GuiasCliente.NewRow

        guia = Me.dtgGuiaRemision.Item(1, indice).Value
        cliente = Me.dtgGuiaRemision.Item(2, indice).Value
        cod_cliente = Me.dtgGuiaRemision.Item(3, indice).Value
        fecha = Me.dtgGuiaRemision.Item(4, indice).Value

        'Averiguando si es que en la lista de elementos seleccionados
        'esta el elemento ingresado
        For i As Integer = 0 To Me.objDTB_GuiasCliente.Rows.Count - 1
            If objDTB_GuiasCliente.Rows(i).Item(0).ToString().Equals(guia) = True Then
                Exit Sub
            End If
        Next

        'Agregando elementos al datarow
        dr(0) = guia
        dr(1) = cliente
        dr(2) = cod_cliente
        dr(3) = fecha
        dr(4) = "SI" 'campo que indica si es un nuevo registro

        'Para cada guia de remision, traemos las ordenes de compra

        Dim dtbListadoOrdenesCompra As New DataTable
        Dim objEntidadDetalleCargaRecepcionada As New DetalleCargaRecepcionada
        Dim objDetalleCargaRecepcionada As New DetalleCargaRecepcionadaDAO

        objEntidadDetalleCargaRecepcionada.NGUIRM = guia
        dtbListadoOrdenesCompra = objDetalleCargaRecepcionada.Listar_Guias_Anexas(objEntidadDetalleCargaRecepcionada)

        For i As Integer = 0 To dtbListadoOrdenesCompra.Rows.Count - 1
            Dim drOrdenCompra As DataRow
            drOrdenCompra = Me.objDTB_OrdenesdeCompra.NewRow
            drOrdenCompra(0) = guia
            drOrdenCompra(1) = dtbListadoOrdenesCompra.Rows(i).Item("NORCML")
            drOrdenCompra(2) = "SI"
            objDTB_OrdenesdeCompra.Rows.Add(drOrdenCompra)
            drOrdenCompra = Nothing
        Next

        'Agregando item al DataTable
        objDTB_GuiasCliente.Rows.Add(dr)
        dr = Nothing

    End Sub

    Private Sub Enlace_Datos_Guias_Seleccionadas()

        'Limpiando la estructura del grid
        dtgGuiasSeleccionadas.DataSource = Nothing
        dtgGuiasSeleccionadas.Columns.Clear()

        'Dando origen de datos a la grilla de items seleccionados
        Me.dtgGuiasSeleccionadas.DataSource = objDTB_GuiasCliente

        Dim Columna As New DataGridViewCheckBoxColumn(False)
        Columna.Width = 25
        dtgGuiasSeleccionadas.Columns.Insert(0, Columna)
        dtgGuiasSeleccionadas.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2

        dtgGuiasSeleccionadas.Columns(0).HeaderText = ""
        dtgGuiasSeleccionadas.Columns(1).HeaderText = "N° Guia"
        dtgGuiasSeleccionadas.Columns(2).HeaderText = "Cliente"
        dtgGuiasSeleccionadas.Columns(3).HeaderText = "Cliente"
        dtgGuiasSeleccionadas.Columns(3).Visible = False
        dtgGuiasSeleccionadas.Columns(4).HeaderText = "FECHA"
        dtgGuiasSeleccionadas.Columns(5).HeaderText = "NUEVO_REGISTRO"
        dtgGuiasSeleccionadas.Columns(5).Visible = False

    End Sub

    Private Sub txtNroOperacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroOperacion.KeyDown

        If e.KeyCode = Keys.Enter Then
            Buscar_Datos()
        End If

    End Sub

    Private Sub btnSeleccionarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarTodos.Click

        'Procediendo a seleccionar todos los elementos de la grilla
        For i As Integer = 0 To Me.dtgGuiaRemision.Rows.Count - 2
            Me.dtgGuiaRemision.Rows(i).Cells(0).Value = True
        Next

    End Sub

    Private Sub btnDeseleccionartodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeseleccionartodos.Click

        'Procediendo a seleccionar todos los elementos de la grilla
        For i As Integer = 0 To Me.dtgGuiaRemision.Rows.Count - 2
            Me.dtgGuiaRemision.Rows(i).Cells(0).Value = False
        Next

    End Sub

    Private Sub btnPasarLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasarLista.Click

        'Procedimiento para agregar un elemento
        For i As Integer = 0 To Me.dtgGuiaRemision.Rows.Count - 1
            If CBool(Me.dtgGuiaRemision.Rows(i).Cells(0).Value) = True Then
                Agregar_Fila(i)
            End If
        Next

        Enlace_Datos_Guias_Seleccionadas()

    End Sub

    Private Sub btnQuitarElemento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarElemento.Click

        'Procedimiento para eliminar un elemento
        For i As Integer = 0 To Me.dtgGuiasSeleccionadas.Rows.Count - 2
            If CBool(Me.dtgGuiasSeleccionadas.Rows(i).Cells(0).FormattedValue) = True Then
                'Primero se deselecciona de la grilla de guias
                For x As Integer = 0 To Me.dtgGuiaRemision.Rows.Count - 2
                    If Me.dtgGuiaRemision.Rows(x).Cells(1).Value.ToString().Equals(Me.dtgGuiasSeleccionadas.Rows(i).Cells(1).Value) = True Then
                        Me.dtgGuiaRemision.Rows(x).Cells(0).Value = False
                    End If
                Next

                'Por cada elemento retirado tambien se tienen que 
                'marcar para eliminar sus correspondientes ordenes de compra
                Dim nro_guia As String = objDTB_GuiasCliente.Rows(i).Item(0).v
                For x As Integer = 0 To Me.objDTB_OrdenesdeCompra.Rows.Count - 1
                    If Me.objDTB_OrdenesdeCompra.Rows(x).Item("NGUICL").Equals(nro_guia) = True Then
                        Me.objDTB_OrdenesdeCompra.Rows(x).Item("NGUICL") = "0"
                    End If
                Next

                'Se marca el codigo de la guia(del datatable) como cero
                'para posteriormente eliminarlo y hacer el databind
                Me.objDTB_GuiasCliente.Rows(i).Item(0) = "0"

            End If
        Next

        'Por cada elemento del datatable con cero, se procede a eliminar
BucleInterno_GuiasCliente:

        For i As Integer = 0 To Me.objDTB_GuiasCliente.Rows.Count - 1
            If Me.objDTB_GuiasCliente.Rows(i).Item(0).Equals("0") = True Then
               
                'se elimina la guia de remision cliente
                Me.objDTB_GuiasCliente.Rows(i).Delete()

                'Repite el bucle ya que al eliminarse este nodo
                'todo el datatable se altera en indices
                GoTo BucleInterno_GuiasCliente
            End If
        Next

        'enlace de datos del datatable 
        Enlace_Datos_Guias_Seleccionadas()

BucleInterno_OrdenesCompra:

        For i As Integer = 0 To Me.objDTB_OrdenesdeCompra.Rows.Count - 1
            If Me.objDTB_OrdenesdeCompra.Rows(i).Item("NGUICL").Equals("0") = True Then
                'se elimina la orden de compra
                Me.objDTB_OrdenesdeCompra.Rows(i).Delete()
                'Repite el bucle ya que al eliminarse este nodo
                'todo el datatable se altera en indices
                GoTo BucleInterno_OrdenesCompra
            End If
        Next

        Me.Cargar_Ordenes_Compra_registradas()

    End Sub

    Private Sub dtgGuiaRemision_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgGuiaRemision.MouseUp
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lsrt_NumeroGuiaTransportista = InputBox("")
    End Sub

    Private Sub btnAgregarLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLista.Click

        Dim resultado = "" '= ValidacionGeneral()

        If Me.txtNroGuiaAnexa.Text.Equals("") = True Then
            resultado = resultado & Chr(13) & "Debe de ingresar el número de guia anexa"
        End If

        If resultado.Equals("") = False Then
            MessageBox.Show(resultado, "Solmin")
            Exit Sub
        End If

        Agregar_Elemento_Anexo_Guias_Transportista()

        Enlace_Datos_Guias_Transportista_Anexa()


    End Sub

    Private Function ValidacionGeneral() As String

        Dim validacion As String = ""

        If Me.lsrt_NumeroGuiaTransportista.Equals("") = True Then
            validacion += "Debe de indicar una guia de transportista" & Chr(13)
        End If
        If Me.cboCompania.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una compania" & Chr(13)
        End If
        If Me.cboDivision.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una division" & Chr(13)
        End If
        If Me.cboPlanta.SelectedIndex = 0 Then
            validacion += "Debe de seleccionar una planta" & Chr(13)
        End If
        If Me.txtTransportista.NoHayCodigo = True Then
            validacion += "Debe de seleccionar un transportista" & Chr(13)
        End If
        If Me.txtNroOperacion.Text.Equals("") = True Then
            validacion += "Debe de indicar un número de operacion" & Chr(13)
        End If
        If Me.lsrt_NumeroGuiaTransportista.Equals("") = True Then
            validacion += "Debe de seleccionar una guia de transportista"
        End If

        Return validacion

    End Function

    Private Sub Agregar_Elemento_Anexo_Guias_Transportista()

        Dim guia_anexa As String = Me.txtNroGuiaAnexa.Text
        Dim fecha As String = Me.dtpFechaGuiaAnexa.Value

        'Obteniendo los valores de la grilla y agregandolos al segundo grid
        Dim dr As DataRow = Me.objDTB_GuiasTransportistaAnexas.NewRow

        'Averiguando si es que en la lista de elementos seleccionados
        'esta el elemento ingresado
        For i As Integer = 0 To Me.objDTB_GuiasTransportistaAnexas.Rows.Count - 1
            If objDTB_GuiasTransportistaAnexas.Rows(i).Item(0).ToString().Equals(guia_anexa) = True Then
                Exit Sub
            End If
        Next

        'Agregando elementos al datarow
        dr(0) = guia_anexa 
        dr(1) = fecha
        dr(2) = "SI" 'campo que indica si es un nuevo registro

        'Agregando item al DataTable
        objDTB_GuiasTransportistaAnexas.Rows.Add(dr)
        dr = Nothing

        Me.txtNroGuiaAnexa.Text = ""

    End Sub

    Private Sub Cargar_Guias_Transportista_registradas()

        Dim objEntidad As New GuiaTransportistaAdicional
        Dim objGuiaTransportistaAdicional As New GuiaTransportistaAnexoDAO

        Dim objDTB_ListadoGuiasRegistradas As New DataTable
        objEntidad.CTRMNC = Me.txtTransportista.Codigo
        objEntidad.NGUIRM = Me.lsrt_NumeroGuiaTransportista
        objDTB_ListadoGuiasRegistradas = objGuiaTransportistaAdicional.Listar_Guias_Anexas(objEntidad)

        Me.objDTB_GuiasTransportistaAnexas.Clear()

        For i As Integer = 0 To objDTB_ListadoGuiasRegistradas.Rows.Count - 1

            Dim dr As DataRow = objDTB_GuiasTransportistaAnexas.NewRow
            dr(0) = objDTB_ListadoGuiasRegistradas.Rows(i).Item("NGUIAD")
            dr(1) = HelpClass.CNumero_a_Fecha(objDTB_ListadoGuiasRegistradas.Rows(i).Item("FGUIRM")).ToShortDateString()
            dr(2) = "NO"
            objDTB_GuiasTransportistaAnexas.Rows.Add(dr)
            dr = Nothing

        Next

        Enlace_Datos_Guias_Transportista_Anexa()

    End Sub

    Private Sub Enlace_Datos_Guias_Transportista_Anexa()

        'Limpiando la estructura del grid
        Me.dtgGuiasTransportistaAnexa.DataSource = Nothing
        dtgGuiasTransportistaAnexa.Columns.Clear()

        'Dando origen de datos a la grilla de items seleccionados
        Me.dtgGuiasTransportistaAnexa.DataSource = Me.objDTB_GuiasTransportistaAnexas

        dtgGuiasTransportistaAnexa.Columns(0).HeaderText = "N° Guia"
        dtgGuiasTransportistaAnexa.Columns(0).Width = 150
        dtgGuiasTransportistaAnexa.Columns(1).HeaderText = "Fecha"
        dtgGuiasTransportistaAnexa.Columns(2).HeaderText = "NUEVO_REGISTRO"
        dtgGuiasTransportistaAnexa.Columns(2).Visible = False

    End Sub

    Private Sub dtgGuiasSeleccionadas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgGuiasSeleccionadas.MouseUp
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub Validacion_Solo_Numeros(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged, txtNroOperacion.TextChanged

        Dim control As TextBox
        control = CType(sender, TextBox)

        If control.Text.Length = 0 Then
            Exit Sub
        End If

        If IsNumeric(control.Text.Chars(control.Text.Length - 1)) = False Then
            control.Text = control.Text.Substring(0, control.Text.Length - 1)
            control.SelectionStart = control.Text.Length
        End If

    End Sub

    Private Sub Validacion_Solo_NumerosDecimales(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPeso.TextChanged, txtCostoTramo.TextChanged, txtKilometrosXRecorrer.TextChanged, txtPesoBruto.TextChanged, txtValorPatrimonio.TextChanged, txtVolumenRemision.TextChanged, txtGalonesDiesel.TextChanged, txtGalonesGasolina.TextChanged

        Dim control As TextBox
        Dim patron As String = ".0123456789"

        control = CType(sender, TextBox)

        If control.Text.Length = 0 Then
            Exit Sub
        End If

        If patron.LastIndexOf(control.Text.Chars(control.Text.Length - 1)) = -1 Then
            control.Text = control.Text.Substring(0, control.Text.Length - 1)
            control.SelectionStart = control.Text.Length
        End If

    End Sub

    Private Sub btnAgregarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarOrdenCompra.Click

        Dim resultado = "" '= ValidacionGeneral()

        If Me.txtGuiaCliente.Text.Equals("") = True Then
            resultado = resultado & Chr(13) & "Debe de indicar el número de guía de cliente"
        End If
        If Me.txtOrdenCompra.Text.Equals("") = True Then
            resultado = resultado & Chr(13) & "Debe de indicar el número de orden de compra"
        End If

        If resultado.Equals("") = False Then
            MessageBox.Show(resultado, "Solmin")
            Exit Sub
        End If

        Dim drOrdenCompra As DataRow
        drOrdenCompra = Me.objDTB_OrdenesdeCompra.NewRow
        drOrdenCompra(0) = Me.txtGuiaCliente.Text
        drOrdenCompra(1) = Me.txtOrdenCompra.Text
        drOrdenCompra(2) = "SI"
        objDTB_OrdenesdeCompra.Rows.Add(drOrdenCompra)
        drOrdenCompra = Nothing

        'Limpiando elementos
        Me.txtGuiaCliente.Text = ""
        Me.txtOrdenCompra.Text = ""

        Enlace_Datos_Ordenes_Compra()

    End Sub

    Private Sub btnEliminarLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarLista.Click

        If Me.dtgGuiasTransportistaAnexa.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If Me.dtgGuiasTransportistaAnexa.Rows.Count < 0 Then
            Exit Sub
        End If

        Dim resultado = ValidacionGeneral()
        If resultado.Equals("") = False Then
            MessageBox.Show(resultado, "Solmin")
            Exit Sub
        End If

        'Procedimiento para eliminar de la lista las guias de transportista anexas
        Dim indice As Integer
        Dim nro_guia As String

        indice = Me.dtgGuiasTransportistaAnexa.CurrentCellAddress.Y
        nro_guia = Me.dtgGuiasTransportistaAnexa.Rows(indice).Cells(0).Value

        If MessageBox.Show("Desea Eliminar la Guía " & nro_guia & " ?", "Solmin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Averiguando si ese registro esta como nuevo o como ya registrado
            If Me.dtgGuiasTransportistaAnexa.Rows(indice).Cells(2).Value.Equals("SI") Then
                Me.objDTB_GuiasTransportistaAnexas.Rows(indice).Delete()
                Cargar_Guias_Transportista_Anexa_registradas()
            Else
                MessageBox.Show("El elemento seleccionado ya se encuentra registrado en el sistema, no se puede eliminar", "Solmin", MessageBoxButtons.OK)
            End If

        End If

        Me.txtNroGuiaAnexa.Text = ""

    End Sub

    Private Sub dtgGuiasTransporte_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGuiasTransporte.CellClick

        If e.RowIndex = -1 Then
            Exit Sub
        End If

        If Me.dtgGuiasTransporte.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If sender.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then
            Exit Sub
        End If

        If Me.dtgGuiasTransporte.Rows.Count < 0 Then
            Exit Sub
        End If

        'Objetos empleados para recuperar los datos
        Dim objEntidad As New GuiaRemisionTransporte
        Dim objGuiasTransportista As New GuiasTransportistaDAO

        'Obteniendo el indice de las guias de transporte
        Dim indice As Integer 
        indice = Me.dtgGuiasTransporte.CurrentCellAddress.Y

        'Estableciendo los datos
        objEntidad.CTRMNC = Me.txtTransportista.Codigo
        objEntidad.NGUIRM = CType(Me.dtgGuiasTransporte.Rows(indice).Cells(0).Value, Long)

        objEntidad = objGuiasTransportista.Obtener_Guia_Transportista(objEntidad)

        'Levantando los datos
        Me.txtNroGuiaRemision.Text = objEntidad.NGUIRM
        Me.txtNroGuiaRemision.Enabled = False
        Me.lsrt_NumeroGuiaTransportista = objEntidad.NGUIRM

        If objEntidad.FGUIRM > 0 Then
            Me.dtpFechaGuia.Value = HelpClass.CNumero_a_Fecha(objEntidad.FGUIRM)
        End If

        If objEntidad.FEMVLH > 0 Then
            Me.dtpFechaTranslado.Value = HelpClass.CNumero_a_Fecha(objEntidad.FEMVLH)
        End If

        Me.txtPlaneamiento.Text = objEntidad.NPLNMT.ToString.Trim()
        Me.lint_CLCLOR = objEntidad.CLCLOR
        Me.lint_CLCLDS = objEntidad.CLCLDS
        Me.txtDireccionOrigen.Text = objEntidad.TDIROR.ToString.Trim()
        Me.txtDireccionDestino.Text = objEntidad.TDIRDS.ToString.Trim()
        Me.txtLugar.Text = objEntidad.TRFRGU.ToString.Trim()
        Me.txtCantidad.Text = objEntidad.QMRCMC.ToString.Trim()
        Me.txtPeso.Text = objEntidad.PMRCMC.ToString.Trim()
        Me.txtUnidadMedida.Codigo = objEntidad.CUNDMD
        Me.txtPlacaTracto.Text = objEntidad.NPLCTR.ToString.Trim()
        Me.txtAcoplado.Text = objEntidad.NPLCAC.ToString.Trim()
        Me.txtBrevete.Text = objEntidad.CBRCNT.ToString.Trim()
        Me.txtRemitente.Text = objEntidad.TNMBRM.ToString.Trim()
        Me.txtDireccionRemitente.Text = objEntidad.TDRCRM.ToString.Trim()
        IIf(objEntidad.TPDCIR.Equals("R") = True, Me.rdRucRemitente.Checked = True, Me.rdRucRemitente.Checked = False)
        Me.txtNroDocumentoRemitente.Text = objEntidad.NRUCRM.ToString.Trim()
        Me.txtConsignatario.Text = objEntidad.TNMBCN.ToString.Trim()
        Me.txtDireccionConsignatario.Text = objEntidad.TDRCNS.ToString.Trim()
        IIf(objEntidad.TPDCIC.Equals("R") = True, Me.rdRucConsignatario.Checked = True, Me.rdRucConsignatario.Checked = False)
        Me.txtNroDocumentoConsignatario.Text = objEntidad.NRUCCN.ToString.Trim()
        IIf(objEntidad.SACRGO.Equals("R") = True, Me.ckbRemitente.Checked = True, Me.ckbRemitente.Checked = False)
        Me.txtMonedaFlete.Codigo = objEntidad.CMNFLT
        IIf(objEntidad.SIDAVL.Equals("I") = True, Me.ckbIda.Checked = True, Me.ckbIda.Checked = False)
        Me.txtKilometrosXRecorrer.Text = objEntidad.QKMREC.ToString.Trim()
        Me.txtCostoTramo.Text = objEntidad.ICSTRM.ToString.Trim()
        Me.txtPesoBruto.Text = objEntidad.QPSOBR.ToString.Trim()
        Me.txtVolumenRemision.Text = objEntidad.QVLMOR.ToString.Trim()
        IIf(objEntidad.SMRPLG.Equals("I") = True, Me.ckbMercaderiaPeligrosa.Checked = True, Me.ckbMercaderiaPeligrosa.Checked = False)
        IIf(objEntidad.SMRPRC.Equals("I") = True, Me.ckbMercaderiaPerecible.Checked = True, Me.ckbMercaderiaPerecible.Checked = False)
        Me.txtValorPatrimonio.Text = objEntidad.IVLPRT.ToString.Trim()
        Me.txtMonedaValorPatrimonio.Codigo = objEntidad.CMNVLP
        Me.txtOrigen.Codigo = objEntidad.CUBORI
        Me.txtDestino.Codigo = objEntidad.CUBDES
        ' Me.txtTransportista.Codigo = objEntidad.CTRSPT
        Me.txtBrevete.Codigo = objEntidad.CBRCNT

        Me.txtGalonesGasolina.Text = objEntidad.QGLGSL.ToString.Trim()
        Me.txtGalonesDiesel.Text = objEntidad.QGLDSL.ToString.Trim()
        Me.txtHojaCarguio.Text = objEntidad.NRHJCR.ToString.Trim()

        'Carga las guias ya registradas
        Cargar_Guias_Cliente_registradas()
        'Carga las guias de transportista anexas
        Cargar_Guias_Transportista_registradas()
        'Cargando las ordenes de compra
        Cargar_Ordenes_Compra_registradas()

        'Estableciendo las variables
        lbool_GuardadoGuiaTransportista = True

    End Sub
 
    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        'Listando las guias de transportista por el codigo de transportista
        Me.Listar_GuiasTransportista_x_Transportista()
    End Sub
 
    Private Sub btnEliminarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarOrdenCompra.Click

        If Me.dtgOrdenCompra.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If Me.dtgOrdenCompra.Rows.Count < 0 Then
            Exit Sub
        End If

        Dim resultado = ValidacionGeneral()
        If resultado.Equals("") = False Then
            MessageBox.Show(resultado, "Solmin")
            Exit Sub
        End If

        'Procedimiento para eliminar de la lista las guias de transportista anexas
        Dim indice As Integer
        Dim nro_guia As String

        indice = Me.dtgOrdenCompra.CurrentCellAddress.Y
        nro_guia = Me.dtgOrdenCompra.Rows(indice).Cells(0).Value

        If MessageBox.Show("Desea Eliminar la Orden de Compra " & nro_guia & " ?", "Solmin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Averiguando si ese registro esta como nuevo o como ya registrado
            If Me.dtgOrdenCompra.Rows(indice).Cells(2).Value.Equals("SI") Then
                Me.objDTB_OrdenesdeCompra.Rows(indice).Delete()
                Me.Cargar_Ordenes_Compra_registradas()
            Else
                MessageBox.Show("El elemento seleccionado ya esta registrado en el sistema, no se puede eliminar", "Solmin", MessageBoxButtons.OK)
            End If

        End If

        Me.txtGuiaCliente.Text = ""
        Me.txtOrdenCompra.Text = ""

    End Sub

    Private Sub txtNroGuiaRemision_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroGuiaRemision.TextChanged

        If Me.txtNroGuiaRemision.Text.Equals("-") = True Then
            Exit Sub
        End If

        'Verificando que no sea el transporte propio
        If lbool_TipoGuia_Autogenerada = True And Me.HGRegistroGuiasTransportista.Collapsed = False Then
            Me.txtNroGuiaRemision.Text = ""
            MessageBox.Show("No puede ingresar el número de guía ya que el transportista el propio", "Solmin", MessageBoxButtons.OK)
            Exit Sub
        End If

    End Sub

    Private Sub txtTransportista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransportista.GotFocus
        Me.LimpiarTextos()
        Me.LimpiarCodigosBase()
    End Sub
 
    Private Sub txtTransportista_Texto_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransportista.Texto_KeyEnter

        If Me.txtTransportista.NoHayCodigo = False Then
            Listar_GuiasTransportista_x_Transportista()
        End If

    End Sub

    Private Sub HGRegistroGuiasTransportista_CollapsedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HGRegistroGuiasTransportista.CollapsedChanged

        If Me.HGRegistroGuiasTransportista.Collapsed = True Then
            Me.LimpiarTextos()
        End If

    End Sub
 
End Class

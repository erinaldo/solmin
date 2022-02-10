
Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports System.Threading
Imports System.Configuration

Public Class frmRegistroIncidencias

#Region "PROPIEDADES"

    Private _PSCCMPN As String = ""
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PSCARINC As String = ""
    Public Property PSCARINC() As String
        Get
            Return _PSCARINC
        End Get
        Set(ByVal value As String)
            _PSCARINC = value
        End Set
    End Property

    Private _PNCINCID As String = ""
    Public Property PNCINCID() As String
        Get
            Return _PNCINCID
        End Get
        Set(ByVal value As String)
            _PNCINCID = value
        End Set
    End Property

    Private _PSTINCSI As String
    Public Property PSTINCSI() As String
        Get
            Return _PSTINCSI
        End Get
        Set(ByVal value As String)
            _PSTINCSI = value
        End Set
    End Property

    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Private _PNNINCSI As Decimal
    Public Property PNNINCSI() As Decimal
        Get
            Return _PNNINCSI
        End Get
        Set(ByVal value As Decimal)
            _PNNINCSI = value
        End Set
    End Property

    Private _obeIncidencia As New beIncidencias
    Public Property obeIncidencia() As beIncidencias
        Get
            Return _obeIncidencia
        End Get
        Set(ByVal value As beIncidencias)
            _obeIncidencia = value
        End Set
    End Property

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property


    Private _pCTPINC As Decimal = 0
    Public Property pCTPINC() As Decimal
        Get
            Return _pCTPINC
        End Get
        Set(ByVal value As Decimal)
            _pCTPINC = value
        End Set
    End Property

    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF004]-190516
    Private _FiltroData As Object

    Private _objResultado As Object
    Public Property objResultado() As Object
        Get
            Return _objResultado
        End Get
        Set(ByVal value As Object)
            _objResultado = value
        End Set
    End Property

    Private ofrmFRASimple As New ucRASimple_FRASimple
    'END: JDT-Almacén Repuestos On Side - Piura[RF004]-190516

    Private IncidenciaEnvio As New beIncidencias
    Private oHebraReqServ As Thread
#End Region

#Region "EVENTOS"

    Private Sub frmMIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtResponsable.Enabled = False
            LimpiarControl()
            Cargar_Nivel_Reportado()
            Lista_Inc_Negocio()
            Lista_Inc_Para()
            cmbIncPara.SelectedValue = _pCTPINC
            txtTitulo.Text = ""
            txtTitulo.Text = "Nro. Incidencia = " & _obeIncidencia.PNNINCSI.ToString
            Cargar_Area()
            cmbArea.SelectedValue = _PSCARINC
            Cargar_Plantas()
            'cmbArea_SelectionChangeCommitted(Nothing, Nothing)
            'UcDivision_Cmb011_Seleccionar_1(Nothing)
            CargaTipoAlmacen()
            CargaMoneda()
            CargarUnidadMedida()
            Cargar_Responsable()
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, _pUsuario)
            txtCliente.pCargar(ClientePK)
            txtCliente.pCargar(_PNCCLNT)

            If _PNCCLNT > 0D Then
                ListarIncidencias()
            End If
            dteHoraRecepcion.Format = DateTimePickerFormat.Custom

            If _obeIncidencia.PNNINCSI <> 0 Then

                cmbArea.Enabled = False


                UcPLanta_Cmb011.pHabilitado = False
                UcPLanta_Cmb011.Planta = _obeIncidencia.PNCPLNDV
                UcPLanta_Cmb011.PlantaDefault = _obeIncidencia.PNCPLNDV
                UcPLanta_Cmb011.pActualizar()


                txtCliente.Enabled = False
                'txtIncidencia.Enabled = False

                With _obeIncidencia
                    dteFechaRecepcion.Value = .FechaRegistro
                    dteHoraRecepcion.Value = Date.Parse(.HoraRegistro)

                    Me.txtDescripcion.Text = .PSTINCDT.Trim
                    Me.txtDocRefCliente.Text = .PSTRDCCL.Trim
                    txtTipoAlmacen.Valor = .PSCTPALM

                    Select Case .PSSNVINC.Trim
                        Case ""
                            cboNivel.SelectedValue = "0"
                        Case Else
                            cboNivel.SelectedValue = .PSSNVINC
                    End Select

                    Select Case .PSSORINC.Trim
                        Case ""
                            cboOrigen.SelectedValue = "0"
                        Case Else
                            cboOrigen.SelectedValue = .PSSORINC
                    End Select

                    cmbIncPara.SelectedValue = .PNCTPINC

                    Select Case .PSCRGVTA.Trim
                        Case ""
                            cmbNegocio.SelectedValue = "0"
                        Case Else
                            cmbNegocio.SelectedValue = .PSCRGVTA
                    End Select

                    txtAlmacen.Valor = .PSCALMC
                    txtZonaAlmacen.Valor = .PSCZNALM
                    txtCliente.pCargar(.PNCCLNT)
                    txtCliente.Refresh()
                    txtIncidencia.Valor = ""
                    ListarIncidencias()
                    txtIncidencia.Valor = .PNCINCID
                    UcClienteTercero_xtF011.MostrarRuc = True
                    UcClienteTercero_xtF011.CodCliente = .PNCCLNT
                    UcClienteTercero_xtF011.TipoRelacion = ""
                    Dim obePlantaDeEntregaC As New TypeDef.PlantaDeEntrega.bePlantaDeEntrega
                    obePlantaDeEntregaC.PNCCLNT = .PNCCLNT
                    If .PNCPRVCL <> 0 Then
                        obePlantaDeEntregaC.PNCPRVCL = .PNCPRVCL
                        obePlantaDeEntregaC.PSSTPORL = ""
                        UcClienteTercero_xtF011.pCargar(obePlantaDeEntregaC)
                        If .PNCPLCLP <> 0 Then
                            Dim obePlantaDeEntrega As New TypeDef.PlantaDeEntrega.bePlantaDeEntrega
                            obePlantaDeEntrega.TIPOCLIENTE = False  'propio o tercero
                            obePlantaDeEntrega.PNCCLNT = .PNCCLNT
                            obePlantaDeEntrega.PNCPRVCL = .PNCPRVCL
                            obePlantaDeEntrega.PNCPLNCL = .PNCPLCLP
                            UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)
                        End If
                    End If
                    txtCantidad.txtDecimales.Text = Val(.PNQAINSM)
                    txtUnidadCantidad.Valor = .PSCUNDCN
                    'txtCosto.txtDecimales.Text = .PNICSTOS
                    'txtMoneda.Valor = .PNCDMNDA

                    txtResponsable.Text = .PSTIRALC.Trim
                    'ucResponsable.Valor = .PSTIRALC.Trim
                    'ucResponsable_CambioDeTexto(Nothing)

                    txtContacto.Text = .PSPRSCNT.Trim
                    cbxTipoDocRef.SelectedValue = .PSTIPDRF 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516
                End With

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Area()

        Dim objBLL As New brIncidencias
        Dim dt As New DataTable

        dt = objBLL.Lista_Areas
        cmbArea.DataSource = dt
        cmbArea.Tag = dt.Copy
        cmbArea.DisplayMember = "TDARINC"
        cmbArea.ValueMember = "CARINC"


    End Sub

    Function Codigo_Division_X_Area(ByVal dt As DataTable, ByVal CCMPN As String, ByVal codigo_area As String) As String
        Dim resultado As String = ""
        Dim dr() As DataRow
        dr = dt.Select("CCMPN = '" & CCMPN & "' AND CARINC = '" & codigo_area & "'")
        If dr.Length > 0 Then
            resultado = ("" & dr(0)("CDVSN")).ToString.Trim
        End If
        Return resultado
    End Function


    Private Sub Cargar_Plantas()

        Dim Codigo_Division As String = ""
        Codigo_Division = Codigo_Division_X_Area(cmbArea.Tag, _PSCCMPN, cmbArea.SelectedValue)

        Me.UcPLanta_Cmb011.Usuario = _pUsuario
        Me.UcPLanta_Cmb011.CodigoCompania = _PSCCMPN

        Me.UcPLanta_Cmb011.CodigoDivision = Codigo_Division

        Me.UcPLanta_Cmb011.PlantaDefault = 1
        Me.UcPLanta_Cmb011.pActualizar()
        txtIncidencia.Valor = ""
        ListarIncidencias()

    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click

        Try
            If Validar() Then Exit Sub
            Dim obr As New brIncidencias
            Dim obe As New beIncidencias
            With obe
                .PSCCMPN = _PSCCMPN
                .PNNINCSI = _PNNINCSI
                .FechaRegistro = dteFechaRecepcion.Value.Date
                .HoraRegistro = String.Format("{0:HH:mm:ss}", dteHoraRecepcion.Value)
                .PNCINCID = CType(txtIncidencia.Resultado, beIncidencias).PNCINCID
                .PSCARINC = cmbArea.SelectedValue
                .PNCPLNDV = CDec(UcPLanta_Cmb011.Planta)
                .PNCCLNT = txtCliente.pCodigo
                .PSTRDCCL = txtDocRefCliente.Text.Trim
                .PSTINCDT = Me.txtDescripcion.Text.Trim

                .PSSNVINC = cboNivel.SelectedValue
                .PSSORINC = cboOrigen.SelectedValue

                .PNCTPINC = cmbIncPara.SelectedValue
                .PSCRGVTA = cmbNegocio.SelectedValue

                If txtTipoAlmacen.Resultado Is Nothing Then
                    .PSCTPALM = ""
                Else
                    .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
                End If
                If txtAlmacen.Resultado Is Nothing Then
                    .PSCALMC = ""
                Else
                    .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
                End If
                If txtZonaAlmacen.Resultado Is Nothing Then
                    .PSCZNALM = ""
                Else
                    .PSCZNALM = CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM
                End If

                .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
                .PNCPLCLP = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                .PNQAINSM = CDec(Me.txtCantidad.txtDecimales.Text)
                .PSCUNDCN = CType(txtUnidadCantidad.Resultado, beGeneral).PSCUNDMD
                'If Me.txtCosto.txtDecimales.Text.ToString.Trim = "" Then
                '    .PNICSTOS = 0
                'Else
                '    .PNICSTOS = CDec(Me.txtCosto.txtDecimales.Text)
                'End If
                'If txtMoneda.Resultado Is Nothing Then
                '    .PNCDMNDA = 0
                'Else
                '    .PNCDMNDA = CType(txtMoneda.Resultado, beGeneral).PNCMNDA1
                'End If
                .PSTIRALC = txtResponsable.Text.Trim 'CType(ucResponsable.Resultado, beDestinatario).PSTNMYAP
                .PSPRSCNT = txtContacto.Text.Trim
                .PSSESTRG = "A"
                .PSUSUARIO = _pUsuario
                .PSNTRMNL = Environment.MachineName
                .PSSTIPPR = ktbxProceso.Tag.ToString.Trim 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516
                .PSTIPDRF = cbxTipoDocRef.SelectedValue.ToString.Trim 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516
            End With
            If _obeIncidencia.PNNINCSI = 0 Then
                Dim codigo As Integer = 0
                If MessageBox.Show("Está seguro de registrar en la incidencia como responsable a " & txtResponsable.Text & " ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    codigo = obr.intInsertarRegistroIncidencias(obe)
                    MessageBox.Show("Registro ingresado, código incidencia generado : " & codigo, "Información: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    obe.PSTDARINC = cmbArea.Text
                    obe.PNNINCSI = codigo
                    obe.PSEMAIL = txtEmail.Text.Trim  'CType(ucResponsable.Resultado, beDestinatario).PSEMAILTO
                    IncidenciaEnvio = obe
                    If txtEmail.Text.Trim <> "" Then
                        oHebraReqServ = New Thread(AddressOf Enviar_Email_Incidencia)
                        oHebraReqServ.Start()
                    End If
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                obr.intActualizarRegistroIncidencias(obe)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Enviar_Email_Incidencia()
        Try
            Dim Entidad As New beIncidencias
            Control.CheckForIllegalCrossThreadCalls = False
            Dim Envio As New brIncidenciaEnvioEmail
            Envio.CULUSA = _pUsuario
            Envio.MailAccount = System.Configuration.ConfigurationManager.AppSettings("email_account")
            Envio.Mailpassword = System.Configuration.ConfigurationManager.AppSettings("email_password")
            Envio.MailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("email_account_gmail")
            Envio.MailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("email_password_gmail")
            Envio.Mailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")
            Envio.EnviarEmail_Incidencia(IncidenciaEnvio)
            'If Envio.EnviarEmail_Incidencia(IncidenciaEnvio) = 1 Then
            '    'OK
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcClienteTercero_xtF011_TextChanged() Handles UcClienteTercero_xtF011.TextChanged
        Try
            UcPlantaDeEntrega_TxtF011.pClear()
            UcPlantaDeEntrega_TxtF011.CodClienteTercero = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Try
            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            oColumnas.Name = "CALMC"
            oColumnas.DataPropertyName = "PSCALMC"
            oColumnas.HeaderText = "Código"
            oListColum.Add(1, oColumnas)
            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TCMPAL"
            oColumnas.DataPropertyName = "PSTCMPAL"
            oColumnas.HeaderText = "Almacén "
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            oListColum.Add(2, oColumnas)
            Dim obrAlmacen As New brAlmacen
            'Se esta cargando la planta por defecto 1 (CAllao)
            If Not objData Is Nothing Then
                CType(objData, beAlmacen).PNCPLNFC = 1
                txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
            Else
                txtAlmacen.DataSource = Nothing
            End If
            txtAlmacen.ListColumnas = oListColum
            txtAlmacen.Cargas()
            txtAlmacen.Limpiar()
            txtAlmacen.ValueMember = "PSCALMC"
            txtAlmacen.DispleyMember = "PSTCMPAL"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
        Try
            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            oColumnas.Name = "CZNALM"
            oColumnas.DataPropertyName = "PSCZNALM"
            oColumnas.HeaderText = "Código"
            oListColum.Add(1, oColumnas)
            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TCMZNA"
            oColumnas.DataPropertyName = "PSTCMZNA"
            oColumnas.HeaderText = "Zona Almacén "
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            oListColum.Add(2, oColumnas)
            Dim obrAlmacen As New brAlmacen
            If Not objData Is Nothing Then
                txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
            Else
                txtZonaAlmacen.DataSource = Nothing
            End If
            txtZonaAlmacen.ListColumnas = oListColum
            txtZonaAlmacen.Cargas()
            txtZonaAlmacen.Limpiar()
            txtZonaAlmacen.ValueMember = "PSCZNALM".Trim()
            txtZonaAlmacen.DispleyMember = "PSTCMZNA"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision)
        Try
            ListarIncidencias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "METODOS"

    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""

        If cmbArea.SelectedIndex = -1 Then strMensajeError &= "* Seleccione una área" & vbNewLine
        If UcPLanta_Cmb011.Planta = 0 Then strMensajeError &= "* Seleccione una planta" & vbNewLine

        If Me.txtCliente.pCodigo = 0 Then
            strMensajeError &= "* Seleccionar cliente" & vbNewLine
        End If

        If cmbIncPara.SelectedValue = 0 Then strMensajeError &= "* Seleccione Inc. Para." & vbNewLine
        If txtIncidencia.Resultado Is Nothing Then strMensajeError &= "* Seleccionar una incidencia." & vbNewLine

        'If txtTipoAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar Tipo de Almacén." & vbNewLine
        'If txtAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar Almacén." & vbNewLine
        'If txtZonaAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar Zona de Almacén." & vbNewLine

        If txtDocRefCliente.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese Doc. Ref. Cliente." & vbNewLine
        If cmbNegocio.SelectedValue = "0" Then strMensajeError &= "* Seleccione un negocio." & vbNewLine
        If cboOrigen.SelectedValue = "0" Then strMensajeError &= "* Seleccionar reportado." & vbNewLine
        If cboNivel.SelectedValue = "0" Then strMensajeError &= "* Seleccionar un nivel." & vbNewLine
        If txtCantidad.txtDecimales.Text.ToString = "" Then strMensajeError &= "* Ingrese una cantidad." & vbNewLine
        If txtUnidadCantidad.Resultado Is Nothing Then strMensajeError &= "* Seleccionar una unidad." & vbNewLine

        If txtResponsable.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese un responsable." & vbNewLine
        If cbxTipoDocRef.SelectedValue = "0" Then 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516
            strMensajeError &= "* Seleccionar un Tipo Doc. Ref." & vbNewLine
        End If


        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Sub Lista_Inc_Para()

        Dim objBLL As New brIncidencias
        Dim dtIncPara As New DataTable
        Dim dr As DataRow

        dtIncPara = objBLL.Lista_Inc_Para

        dr = dtIncPara.NewRow
        dr("CTPINC") = 0
        dr("TTPINC") = ":: Seleccione ::"
        dtIncPara.Rows.InsertAt(dr, 0)

        cmbIncPara.DataSource = dtIncPara
        cmbIncPara.DisplayMember = "TTPINC"
        cmbIncPara.ValueMember = "CTPINC"
        cmbIncPara.SelectedValue = 0

    End Sub


    Sub Lista_Inc_Negocio()

        Dim objBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim dtNegocio As New DataTable
        Dim dr As DataRow

        objBE.PSCCMPN = _PSCCMPN

        dtNegocio = objBLL.Lista_Inc_Negocio(objBE)

        dr = dtNegocio.NewRow
        dr("CCMPN") = "EZ"
        dr("CRGVTA") = "0"
        dr("TCRVTA") = ":: Seleccione ::"
        dtNegocio.Rows.InsertAt(dr, 0)

        cmbNegocio.DataSource = dtNegocio
        cmbNegocio.DisplayMember = "TCRVTA"
        cmbNegocio.ValueMember = "CRGVTA"
        cmbNegocio.SelectedValue = "0"

    End Sub
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF004]-190516
    Sub Lista_TipoDocRef(ByVal objBE As beIncidencias)

        Dim objBLL As New brIncidencias
        Dim dtTipoDocRef As New DataTable
        Dim dr As DataRow

        dtTipoDocRef = objBLL.Lista_TipoDocRef(objBE)

        dr = dtTipoDocRef.NewRow
        dr("TIPDRF") = "0"
        dr("DESDRF") = ":: Seleccione ::"
        dtTipoDocRef.Rows.InsertAt(dr, 0)

        cbxTipoDocRef.DataSource = dtTipoDocRef
        cbxTipoDocRef.DisplayMember = "DESDRF"
        cbxTipoDocRef.ValueMember = "TIPDRF"
        cbxTipoDocRef.SelectedValue = "0"
    End Sub
    'END: JDT-Almacén Repuestos On Side - Piura[RF004]-190516

    Sub Cargar_Nivel_Reportado()

        Dim BLL As New brIncidencias
        Dim ds As New DataSet

        ds = BLL.Lista_Nivel_y_Reportado

        '   CARGAR NIVEL

        Dim dt As New DataTable
        Dim dr As DataRow

        dt = ds.Tables(0).Copy
        dr = dt.NewRow
        dr("SNVINC") = "0"
        dr("DESCRIPCION") = ":: Seleccione ::"
        dt.Rows.InsertAt(dr, 0)

        cboNivel.DataSource = dt

        cboNivel.DisplayMember = "DESCRIPCION"
        cboNivel.ValueMember = "SNVINC"
        cboNivel.SelectedValue = "0"

        '   CARGAR REPORTADO

        Dim dt1 As New DataTable
        Dim dr1 As DataRow

        dt1 = ds.Tables(1).Copy
        dr1 = dt1.NewRow
        dr1("SORINC") = "0"
        dr1("DESCRIPCION") = ":: Seleccione ::"
        dt1.Rows.InsertAt(dr1, 0)

        cboOrigen.DataSource = dt1
        cboOrigen.DisplayMember = "DESCRIPCION"
        cboOrigen.ValueMember = "SORINC"
        cboOrigen.SelectedValue = "0"

    End Sub

    Private Sub LimpiarControl()
        UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = False
        UcPlantaDeEntrega_TxtF011.CodCliente = _PNCCLNT
        UcClienteTercero_xtF011.CodCliente = _PNCCLNT
        UcPlantaDeEntrega_TxtF011.pClear()
        UcClienteTercero_xtF011.pClear()

    End Sub

    Private Sub ListarIncidencias()
        Dim DS As New DataSet
        Dim obrIncidencia As New brIncidencias
        Dim obeIncidencias As New beIncidencias
        Dim obj As New beIncidencias
        Dim Lista As New List(Of beIncidencias)
        Dim Lista1 As New List(Of beIncidencias)
        With obeIncidencias
            .PSCCMPN = _PSCCMPN
            .PSCARINC = cmbArea.SelectedValue
            .PNCTPINC = cmbIncPara.SelectedValue
        End With
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CINCID"
        oColumnas.DataPropertyName = "PNCINCID"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TINCSI"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.DataPropertyName = "PSTINCSI"
        oColumnas.HeaderText = "Incidencia"
        oListColum.Add(2, oColumnas)

        If _obeIncidencia.PNNINCSI = 0 Then 'NUEVO

            Lista = obrIncidencia.olisListarTipoIncidenciasCliente(obeIncidencias)

            For Each obj1 As beIncidencias In Lista
                If obj1.PSSESTRG <> "C" Then
                    Lista1.Add(obj1)
                End If
            Next

            If Lista1.Count = 0 Then
                txtIncidencia.DataSource = Nothing
            Else
                txtIncidencia.DataSource = Lista1
            End If

            txtIncidencia.ListColumnas = oListColum
            txtIncidencia.Cargas()
            txtIncidencia.ValueMember = "PNCINCID"
            txtIncidencia.DispleyMember = "PSTINCSI"

        Else 'MODIFICAR

            txtIncidencia.DataSource = obrIncidencia.olisListarTipoIncidenciasCliente(obeIncidencias)
            txtIncidencia.ListColumnas = oListColum
            txtIncidencia.Cargas()
            txtIncidencia.ValueMember = "PNCINCID"
            txtIncidencia.DispleyMember = "PSTINCSI"

        End If

    End Sub

    Private Sub CargaTipoAlmacen()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub

    Private Sub CargaMoneda()
        'Dim oListColum As New Hashtable
        'Dim oColumnas As New DataGridViewTextBoxColumn
        'oColumnas.Name = "CMNDA1"
        'oColumnas.DataPropertyName = "PNCMNDA1"
        'oColumnas.HeaderText = "Código "
        'oListColum.Add(1, oColumnas)
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "TMNDA"
        'oColumnas.DataPropertyName = "PSTMNDA"
        'oColumnas.HeaderText = "Moneda "
        'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'oListColum.Add(2, oColumnas)
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "TSGNMN"
        'oColumnas.DataPropertyName = "PSTSGNMN"
        'oColumnas.HeaderText = "Signo "
        'oListColum.Add(3, oColumnas)
        'Dim obrGeneral As New brGeneral
        'txtMoneda.DataSource = obrGeneral.ListaMoneda()
        'txtMoneda.ListColumnas = oListColum
        'txtMoneda.Cargas()
        'txtMoneda.ValueMember = "PNCMNDA1"
        'txtMoneda.DispleyMember = "PSTMNDA"
    End Sub

    Private Sub CargarUnidadMedida()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrGeneral As New brGeneral
        Dim obeGeneral As New beGeneral
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCUNDMD"
        oColumnas.DataPropertyName = "PSCUNDMD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCMPUN"
        oColumnas.DataPropertyName = "PSTCMPUN"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        With obeGeneral
            .PSSTPOUN = "C"
        End With
        Me.txtUnidadCantidad.DataSource = obrGeneral.ListaUnidadDeMedida(obeGeneral)
        Me.txtUnidadCantidad.ListColumnas = oListColum
        Me.txtUnidadCantidad.Cargas()
        Me.txtUnidadCantidad.DispleyMember = "PSTCMPUN"
        Me.txtUnidadCantidad.ValueMember = "PSCUNDMD"
    End Sub

    Private Sub Cargar_Responsable()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrIncidencias As New brIncidencias
        Dim obeResponsable As New beDestinatario
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSNCRRIT"
        oColumnas.DataPropertyName = "PSNCRRIT"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.Visible = False
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMYAP"
        oColumnas.DataPropertyName = "PSTNMYAP"
        oColumnas.HeaderText = "Nombre"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSEMAILTO"
        oColumnas.DataPropertyName = "PSEMAILTO"
        oColumnas.HeaderText = "Correo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)

        With obeResponsable
            .PNCCLNT = 999999
            .PSTIPPROC = "SC_INCREG"
        End With

        Etiquetas.Add("Nombre")
        Etiquetas.Add("Email")

        Me.ucResponsable.Etiquetas_Form = Etiquetas
        Me.ucResponsable.DataSource = obrIncidencias.olisListarResponsables(obeResponsable)
        Me.ucResponsable.ListColumnas = oListColum
        Me.ucResponsable.Cargas()
        Me.ucResponsable.DispleyMember = "PSEMAILTO"
        Me.ucResponsable.ValueMember = "PSTNMYAP"
    End Sub

#End Region

    Private Sub UcDivision_Cmb011_Seleccionar_1(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision)
        Try

            'Me.UcPLanta_Cmb011.Usuario = _pUsuario
            ''Me.UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            ''Me.UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            ''Me.UcPLanta_Cmb011.PlantaDefault = 1
            'Me.UcPLanta_Cmb011.CodigoCompania = UcDivision_Cmb011.Compania
            'Me.UcPLanta_Cmb011.CodigoDivision = UcDivision_Cmb011.Division
            'Me.UcPLanta_Cmb011.PlantaDefault = 1
            ''If Me.UcDivision_Cmb011.CDVSN_ANTERIOR <> Me.UcDivision_Cmb011.Division Then
            ''    Me.UcPLanta_Cmb011.pActualizar()
            ''End If
            'Me.UcPLanta_Cmb011.pActualizar()
            ''If txtCliente.pCodigo > 0 Then
            ''    txtIncidencia.Valor = ""
            ''    ListarIncidencias()
            ''End If
            'txtIncidencia.Valor = ""
            'ListarIncidencias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbIncPara_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIncPara.SelectionChangeCommitted
        Try
            txtIncidencia.Valor = ""
            ListarIncidencias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbArea_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectionChangeCommitted

        Try
            'Me.UcPLanta_Cmb011.Usuario = _pUsuario
            'Me.UcPLanta_Cmb011.CodigoCompania = _PSCCMPN
            'Me.UcPLanta_Cmb011.CodigoDivision = cmbArea.SelectedValue
            'Me.UcPLanta_Cmb011.PlantaDefault = 1
            'Me.UcPLanta_Cmb011.pActualizar()

            Cargar_Plantas()
            'txtIncidencia.Valor = ""
            'ListarIncidencias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub txtUsuario_InformationChanged()

    '    Try
    '        If txtUsuario.pPSMMCUSR.ToString.Trim <> "" Then
    '            txtResponsable.Text = txtUsuario.pPSMMNUSR.ToString.Trim
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    Private Sub ucResponsable_CambioDeTexto(ByVal objData As System.Object) Handles ucResponsable.CambioDeTexto

        If ucResponsable.Resultado IsNot Nothing Then
            txtResponsable.Text = CType(ucResponsable.Resultado, beDestinatario).PSTNMYAP
            txtEmail.Text = CType(ucResponsable.Resultado, beDestinatario).PSEMAILTO
        End If
    End Sub

    Private Sub txtResponsable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResponsable.TextChanged
        txtEmail.Text = ""
    End Sub
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF004]-190516
    Private Sub txtIncidencia_CambioDeTexto(ByVal objData As System.Object) Handles txtIncidencia.CambioDeTexto
        If Not objData Is Nothing Then
            Dim obj As beIncidencias = CType(objData, beIncidencias)
            ktbxProceso.Text = obj.PSDESPRO
            ktbxProceso.Tag = obj.PSSTIPPR
            Lista_TipoDocRef(obj)
            If ktbxProceso.Tag.ToString.Trim <> "R" And ktbxProceso.Tag.ToString.Trim <> "D" Then
                btnRAlmacenSimple.Visible = False
                txtDocRefCliente.Enabled = True
            Else
                btnRAlmacenSimple.Visible = True
                txtDocRefCliente.Enabled = False
            End If
        End If
    End Sub
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF004]-190516

    Private Sub btnRAlmacenSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRAlmacenSimple.Click
        Try
            If Not ktbxProceso.Tag Is Nothing Then
                CargarComboBusquedaPor()
                ofrmFRASimple.PNCCLNT = txtCliente.pCodigo
                ofrmFRASimple.PSSTIPPR = ktbxProceso.Tag.ToString.Trim
                If ofrmFRASimple.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    objResultado = ofrmFRASimple.objResultado
                    _FiltroData = objResultado
                    If Not _FiltroData Is Nothing Then
                        txtDocRefCliente.Text = _FiltroData.GetType.GetProperty("PNNGUIRN").GetValue(_FiltroData, Nothing)
                    End If
                End If
            Else
                MessageBox.Show("Seleccionar una incidencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar el Formulario : " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarComboBusquedaPor()
        Try
            If ktbxProceso.Tag.ToString.Trim = "R" Then
                Dim dt As DataTable
                dt = New DataTable("Tabla")
                dt.Columns.Add("Codigo")
                dt.Columns.Add("Descripcion")
                Dim dr As DataRow
                dr = dt.NewRow()
                dr("Codigo") = "0"
                dr(1) = ":: Seleccione ::"
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                dr("Codigo") = "PNNGUIRN"
                dr(1) = "Guía de recepción"
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                dr(0) = "PSNGUICL"
                dr(1) = "Guía de remisión"
                dt.Rows.Add(dr)
                ofrmFRASimple.cbxBusquedaPor.DataSource = dt
                ofrmFRASimple.cbxBusquedaPor.ValueMember = "Codigo"
                ofrmFRASimple.cbxBusquedaPor.DisplayMember = "Descripcion"

            ElseIf ktbxProceso.Tag.ToString.Trim = "D" Then
                Dim dt As DataTable
                dt = New DataTable("Tabla")
                dt.Columns.Add("Codigo")
                dt.Columns.Add("Descripcion")
                Dim dr As DataRow
                dr = dt.NewRow()
                dr("Codigo") = "0"
                dr(1) = ":: Seleccione ::"
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                dr("Codigo") = "PNNGUIRN"
                dr(1) = "Guía de despacho"
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                dr(0) = "PSNGUICL"
                dr(1) = "Guía de remisión"
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                dr(0) = "PNCDPEPL"
                dr(1) = "Pedido"
                dt.Rows.Add(dr)
                ofrmFRASimple.cbxBusquedaPor.DataSource = dt
                ofrmFRASimple.cbxBusquedaPor.ValueMember = "Codigo"
                ofrmFRASimple.cbxBusquedaPor.DisplayMember = "Descripcion"
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar el ComboBox 'Busqueda Por' : " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

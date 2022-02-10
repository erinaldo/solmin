Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Imports System.Text

Public Class frmPreAsignacionUnidades

#Region "Variables"

    Dim oPreAsignacionUnidades_BE As SOLMIN_ST.ENTIDADES.PreAsignacionUnidades_BE
    Dim oPreAsignacionUnidades_BLL As SOLMIN_ST.NEGOCIO.PreAsignacionUnidades_BLL
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL

    Private texto_Guardar As String = "Guardar"
    Private texto_Modificar As String = "Modificar"
    Private texto_Registrar As String = "Registrar"

    Dim compania, division As String
    Dim planta As Integer

    Private OPCION As String

#End Region

#Region "Metodos"

    Enum Mantenimiento
        Inicio
        Edicion
        Nuevo
        Inactivo
    End Enum

    Private Sub HabilitarBotonMantenimiento(ByVal opc As Mantenimiento)

        Select Case opc

            Case Mantenimiento.Inicio

                txtPreAsignacionUnidades.Text = ""
                UcCliente_TxtF012.pClear()
                txtTransportista.pClear()
                txtTracto.pClear()
                txtAcoplado.pClear()
                cmbConductor.pClear()
                cmbSegundoConductor.pClear()
                cboMedioTransporteFiltro.SelectedValue = 4
                cboLugarorigen.Limpiar()
                cboLugarDestino.Limpiar()
                txtDesDireccionOrigen.Text = ""
                txtNGuiaTransporte.Text = ""
                dtpGuiaRemision.Value = Now.Date
                txtNOperacion.Text = ""
                txtDireccionEntregaMercaderia.Text = ""
                txtObservaciones.Text = ""

                txtPreAsignacionUnidades.Enabled = False
                UcCliente_TxtF012.Enabled = False
                txtTransportista.Enabled = False
                txtTracto.Enabled = False
                txtAcoplado.Enabled = False
                cmbConductor.Enabled = False
                cmbSegundoConductor.Enabled = False
                cboMedioTransporteFiltro.Enabled = False
                cboLugarorigen.Enabled = False
                cboLugarDestino.Enabled = False
                txtDesDireccionOrigen.Enabled = False
                txtNGuiaTransporte.Enabled = False
                dtpGuiaRemision.Enabled = False
                txtNOperacion.Enabled = False
                txtDireccionEntregaMercaderia.Enabled = False
                txtObservaciones.Enabled = False

                btnNuevo.Enabled = True
                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Modificar
                OPCION = texto_Modificar
                btnEliminar.Enabled = True
                btnCancelar.Enabled = False

            Case Mantenimiento.Nuevo

                txtPreAsignacionUnidades.Text = ""
                UcCliente_TxtF012.pClear()
                txtTransportista.pClear()
                txtTracto.pClear()
                txtAcoplado.pClear()
                cmbConductor.pClear()
                cmbSegundoConductor.pClear()
                cboMedioTransporteFiltro.SelectedValue = 4
                cboLugarorigen.Limpiar()
                cboLugarDestino.Limpiar()
                txtDesDireccionOrigen.Text = ""
                txtNGuiaTransporte.Text = ""
                dtpGuiaRemision.Value = Now.Date
                txtNOperacion.Text = ""
                txtDireccionEntregaMercaderia.Text = ""
                txtObservaciones.Text = ""

                txtPreAsignacionUnidades.Enabled = False
                UcCliente_TxtF012.Enabled = True
                txtTransportista.Enabled = True
                txtTracto.Enabled = True
                txtAcoplado.Enabled = True
                cmbConductor.Enabled = True
                cmbSegundoConductor.Enabled = True
                cboMedioTransporteFiltro.Enabled = True
                cboLugarorigen.Enabled = True
                cboLugarDestino.Enabled = True
                txtDesDireccionOrigen.Enabled = True
                txtNGuiaTransporte.Enabled = True
                dtpGuiaRemision.Enabled = True
                txtNOperacion.Enabled = False
                txtDireccionEntregaMercaderia.Enabled = True
                txtObservaciones.Enabled = True

                cmbCompania_SelectionChangeCommitted(Nothing, Nothing)

                btnNuevo.Enabled = False
                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Guardar
                OPCION = texto_Registrar
                btnEliminar.Enabled = False
                btnCancelar.Enabled = True

            Case Mantenimiento.Edicion

                txtPreAsignacionUnidades.Enabled = False

                UcCliente_TxtF012.Enabled = True
                txtTransportista.Enabled = True
                txtTracto.Enabled = True
                txtAcoplado.Enabled = True
                cmbConductor.Enabled = True
                cmbSegundoConductor.Enabled = True
                cboMedioTransporteFiltro.Enabled = True
                cboLugarorigen.Enabled = True
                cboLugarDestino.Enabled = True
                txtDesDireccionOrigen.Enabled = True
                txtNGuiaTransporte.Enabled = True
                dtpGuiaRemision.Enabled = True
                txtNOperacion.Enabled = False
                txtDireccionEntregaMercaderia.Enabled = True
                txtObservaciones.Enabled = True

                btnNuevo.Enabled = False
                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Guardar
                OPCION = texto_Guardar
                btnEliminar.Enabled = False
                btnCancelar.Enabled = True

                'Case Mantenimiento.Inactivo

                '  txtPreAsignacionUnidades.Enabled = False
                '  UcCliente_TxtF012.Enabled = False
                '  txtTransportista.Enabled = False
                '  txtTracto.Enabled = False
                '  txtAcoplado.Enabled = False
                '  cmbConductor.Enabled = False
                '  cmbSegundoConductor.Enabled = False
                '  cboMedioTransporteFiltro.Enabled = False
                '  cboLugarorigen.Enabled = False
                '  cboLugarDestino.Enabled = False
                '  txtDesDireccionOrigen.Enabled = False
                '  txtNGuiaTransporte.Enabled = False
                '  dtpGuiaRemision.Enabled = False
                '  txtNOperacion.Enabled = False
                '  txtDireccionEntregaMercaderia.Enabled = False
                '  txtObservaciones.Enabled = False

        End Select

    End Sub

    Private Sub Llenar_Estado()

        Dim dt As New DataTable
        dt.Columns.Add("Display")
        dt.Columns.Add("Value")
        Dim dr As DataRow

        dr = dt.NewRow
        dr("Display") = "Pendiente"
        dr("Value") = "P"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("Display") = "Asignado"
        dr("Value") = "A"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("Display") = "Todos"
        dr("Value") = "T"
        dt.Rows.Add(dr)

        cmbEstado.DataSource = dt
        cmbEstado.DisplayMember = "Display"
        cmbEstado.ValueMember = "Value"
        cmbEstado.SelectedValue = "P"

    End Sub

    Private Sub Cargar_Compania()
        Try
            objCompaniaBLL.Crea_Lista()
            cmbCompania.DataSource = objCompaniaBLL.Lista
            cmbCompania.ValueMember = "CCMPN"
            cmbCompania.DisplayMember = "TCMPCM"
            'Me.cmbCompania.SelectedValue = "EZ"

            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            cmbCompania_SelectionChangeCommitted(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cargar_Division()
        Try
            If (Me.cmbCompania.SelectedValue IsNot Nothing) Then
                objDivision.Crea_Lista()
                cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
                cmbDivision.ValueMember = "CDVSN"
                cmbDivision.DisplayMember = "TCMPDV"
                cmbDivision.SelectedValue = "T"
                If Me.cmbDivision.SelectedIndex = -1 Then
                    Me.cmbDivision.SelectedIndex = 0
                End If
                cmbDivision_SelectionChangeCommitted(Nothing, Nothing)
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Planta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try
            If (Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then

                objPlanta.Crea_Lista()
                objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.DataSource = objLisEntidad
                cmbPlanta.ValueMember = "CPLNDV"
                cmbPlanta.DisplayMember = "TPLNTA"

                Me.cmbPlanta.SelectedIndex = 0
                'cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(cmbCompania.SelectedValue)
        Me.cboMedioTransporteFiltro.DataSource = objTabla.Copy
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
    End Sub

    Private Sub CargarTransportista()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = cmbCompania.SelectedValue   'Me.cmbCompania.SelectedValue
        Me.txtTransportista.pCargar(obeTransportista)
    End Sub
    ' localidad origen y destino
    'Private Sub Cargar_Combos()
    '    Dim objDt As List(Of LocalidadRuta)
    '    Dim obj_Logica_Localidad As New Localidad_BLL
    '    objDt = obj_Logica_Localidad.Listar_Localidades(cmbCompania.SelectedValue)

    '    Dim oListColum As New Hashtable
    '    Dim oColumnas As New DataGridViewTextBoxColumn
    '    oColumnas.Name = "CLCLD"
    '    oColumnas.DataPropertyName = "CLCLD"
    '    oColumnas.HeaderText = "Código "
    '    oListColum.Add(1, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "TCMLCL"
    '    oColumnas.DataPropertyName = "TCMLCL"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    oColumnas.HeaderText = "Descripción "
    '    oListColum.Add(2, oColumnas)

    '    Me.cboLugarorigen.DataSource = objDt
    '    Me.cboLugarorigen.ListColumnas = oListColum
    '    Me.cboLugarorigen.Cargas()
    '    Me.cboLugarorigen.DispleyMember = "TCMLCL"
    '    Me.cboLugarorigen.ValueMember = "CLCLD"

    '    Dim oListColum2 As New Hashtable
    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "CLCLD"
    '    oColumnas.DataPropertyName = "CLCLD"
    '    oColumnas.HeaderText = "Código "
    '    oListColum2.Add(1, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "TCMLCL"
    '    oColumnas.DataPropertyName = "TCMLCL"
    '    oColumnas.HeaderText = "Descripción "
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    oListColum2.Add(2, oColumnas)

    '    Me.cboLugarDestino.DataSource = objDt
    '    Me.cboLugarDestino.ListColumnas = oListColum2
    '    Me.cboLugarDestino.Cargas()
    '    Me.cboLugarDestino.DispleyMember = "TCMLCL"
    '    Me.cboLugarDestino.ValueMember = "CLCLD"

    'End Sub

    Private Function Valida_Campos() As String
        Dim sbMensaje As New StringBuilder
        If UcCliente_TxtF012.pCodigo.ToString.Trim.Length = 0 Then
            sbMensaje.AppendLine("* Cliente")
        End If

        If txtTransportista.pRucTransportista.ToString.Trim.Length = 0 Then
            sbMensaje.AppendLine("* Transportista")
        End If

        If txtTracto.pBrevete.ToString.Trim.Length = 0 Then
            sbMensaje.AppendLine("* Tracto")
        End If

        If cmbConductor.pBrevete.ToString.Trim.Length = 0 Then
            sbMensaje.AppendLine("* Conductor 1")
        End If

        If cboLugarorigen.Resultado Is Nothing Then
            sbMensaje.AppendLine("* Localidad Origen")
        End If

        If cboLugarDestino.Resultado Is Nothing Then
            sbMensaje.AppendLine("* Localidad Destino")
        End If

        Return sbMensaje.ToString
    End Function


    Private Function Valida_Filtros() As String
        Dim sbMensaje As New StringBuilder
        If cmbCompania.Text = "" Then
            sbMensaje.AppendLine("* Compañia")
        End If

        If cmbDivision.Text = "" Then
            sbMensaje.AppendLine("* División")
        End If

        If cmbPlanta.Text = "" Then
            sbMensaje.AppendLine("* Planta")
        End If

        Return sbMensaje.ToString
    End Function

    Sub Registrar_PreAsignacionUnidades()

        oPreAsignacionUnidades_BE = New SOLMIN_ST.ENTIDADES.PreAsignacionUnidades_BE
        oPreAsignacionUnidades_BLL = New SOLMIN_ST.NEGOCIO.PreAsignacionUnidades_BLL

        oPreAsignacionUnidades_BE.PNNPRASG = 1
        oPreAsignacionUnidades_BE.PNFPRASG = Now.Date
        oPreAsignacionUnidades_BE.PSCCMPN = cmbCompania.SelectedValue
        oPreAsignacionUnidades_BE.PSCDVSN = cmbDivision.SelectedValue
        oPreAsignacionUnidades_BE.PNCPLNDV = cmbPlanta.SelectedValue
        oPreAsignacionUnidades_BE.PNCCLNT = UcCliente_TxtF012.pCodigo
        oPreAsignacionUnidades_BE.PNCLCLOR = CType(Me.cboLugarorigen.Resultado, LocalidadRuta).CLCLD
        oPreAsignacionUnidades_BE.PNCLCLDS = CType(Me.cboLugarDestino.Resultado, LocalidadRuta).CLCLD
        oPreAsignacionUnidades_BE.PSTDRORI = txtDesDireccionOrigen.Text
        oPreAsignacionUnidades_BE.PNNRUCTR = Val(txtTransportista.pRucTransportista)
        oPreAsignacionUnidades_BE.PSNPLCUN = txtTracto.pNroPlacaUnidad
        oPreAsignacionUnidades_BE.PSTDRENT = txtDireccionEntregaMercaderia.Text.Trim
        oPreAsignacionUnidades_BE.PSNPLCAC = txtAcoplado.pNroAcoplado

        oPreAsignacionUnidades_BE.PSCBRCNT = cmbConductor.pBrevete
        oPreAsignacionUnidades_BE.PSCBRCN2 = cmbSegundoConductor.pBrevete
        oPreAsignacionUnidades_BE.PNNGUITR = Val(txtNGuiaTransporte.Text)
        oPreAsignacionUnidades_BE.PSFGUITR = dtpGuiaRemision.Value.Date
        oPreAsignacionUnidades_BE.PNNOPRCN = Val(txtNOperacion.Text)
        oPreAsignacionUnidades_BE.PNCMEDTR = cboMedioTransporteFiltro.SelectedValue
        oPreAsignacionUnidades_BE.PSTOBS = txtObservaciones.Text.Trim
        If oPreAsignacionUnidades_BLL.Registrar_PreAsignacionUnidades(oPreAsignacionUnidades_BE) = 1 Then

        End If
    End Sub

    Sub Modificar_PreAsignacionUnidades()

        oPreAsignacionUnidades_BE = New SOLMIN_ST.ENTIDADES.PreAsignacionUnidades_BE
        oPreAsignacionUnidades_BLL = New SOLMIN_ST.NEGOCIO.PreAsignacionUnidades_BLL

        oPreAsignacionUnidades_BE.PNNPRASG = Val(txtPreAsignacionUnidades.Text)
        oPreAsignacionUnidades_BE.PSCCMPN = cmbCompania.SelectedValue
        oPreAsignacionUnidades_BE.PSCDVSN = cmbDivision.SelectedValue
        oPreAsignacionUnidades_BE.PNCPLNDV = cmbPlanta.SelectedValue
        oPreAsignacionUnidades_BE.PNCCLNT = UcCliente_TxtF012.pCodigo
        oPreAsignacionUnidades_BE.PNCLCLOR = CType(Me.cboLugarorigen.Resultado, LocalidadRuta).CLCLD
        oPreAsignacionUnidades_BE.PNCLCLDS = CType(Me.cboLugarDestino.Resultado, LocalidadRuta).CLCLD
        oPreAsignacionUnidades_BE.PSTDRORI = txtDesDireccionOrigen.Text
        oPreAsignacionUnidades_BE.PNNRUCTR = Val(txtTransportista.pRucTransportista)
        oPreAsignacionUnidades_BE.PSNPLCUN = txtTracto.pNroPlacaUnidad
        oPreAsignacionUnidades_BE.PSTDRENT = txtDireccionEntregaMercaderia.Text.Trim
        oPreAsignacionUnidades_BE.PSNPLCAC = txtAcoplado.pNroAcoplado

        oPreAsignacionUnidades_BE.PSCBRCNT = cmbConductor.pBrevete
        oPreAsignacionUnidades_BE.PSCBRCN2 = cmbSegundoConductor.pBrevete
        oPreAsignacionUnidades_BE.PNNGUITR = Val(txtNGuiaTransporte.Text)
        oPreAsignacionUnidades_BE.PSFGUITR = dtpGuiaRemision.Value.Date
        oPreAsignacionUnidades_BE.PNNOPRCN = Val(txtNOperacion.Text)
        oPreAsignacionUnidades_BE.PNCMEDTR = cboMedioTransporteFiltro.SelectedValue
        oPreAsignacionUnidades_BE.PSTOBS = txtObservaciones.Text.Trim

        If oPreAsignacionUnidades_BLL.Modificar_PreAsignacionUnidades(oPreAsignacionUnidades_BE) = 1 Then

        End If

    End Sub

    Sub Eliminar_PreAsignacionUnidades()

        oPreAsignacionUnidades_BE = New SOLMIN_ST.ENTIDADES.PreAsignacionUnidades_BE
        oPreAsignacionUnidades_BLL = New SOLMIN_ST.NEGOCIO.PreAsignacionUnidades_BLL

        oPreAsignacionUnidades_BE.PNNPRASG = Val(txtPreAsignacionUnidades.Text)
        oPreAsignacionUnidades_BE.PSCCMPN = cmbCompania.SelectedValue
        oPreAsignacionUnidades_BE.PSCDVSN = cmbDivision.SelectedValue
        oPreAsignacionUnidades_BE.PNCPLNDV = cmbPlanta.SelectedValue
        oPreAsignacionUnidades_BE.PNCCLNT = UcCliente_TxtF012.pCodigo

        If oPreAsignacionUnidades_BLL.Eliminar_PreAsignacionUnidades(oPreAsignacionUnidades_BE) = 1 Then

        End If
    End Sub

    Sub Cargar_Tracto_Acoplado(Optional ByVal tracto As String = "", Optional ByVal acoplado As String = "")

        Me.txtTracto.pClear()
        Me.txtAcoplado.pClear()

        'Cargar Tracto
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        obeTracto.pCCMPN_Compania = cmbCompania.SelectedValue
        obeTracto.pCDVSN_Division = cmbDivision.SelectedValue
        obeTracto.pCPLNDV_Planta = cmbPlanta.SelectedValue
        obeTracto.pNRUCTR_RucTransportista = Me.txtTransportista.pRucTransportista
        obeTracto.pNPLCUN_NroPlacaUnidad = tracto
        Me.txtTracto.pCargar(obeTracto)

        'Cargar Acoplado
        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
        obeAcoplado.pCCMPN_Compania = cmbCompania.SelectedValue
        obeAcoplado.pCDVSN_Division = cmbDivision.SelectedValue
        obeAcoplado.pCPLNDV_Planta = cmbPlanta.SelectedValue
        obeAcoplado.pNRUCTR_RucTransportista = Me.txtTransportista.pRucTransportista
        obeAcoplado.pNPLCAC_NroAcoplado = acoplado
        Me.txtAcoplado.pCargar(obeAcoplado)

    End Sub

    Sub Cargar_Conductores(Optional ByVal conductor1 As String = "", Optional ByVal conductor2 As String = "")

        Me.cmbConductor.pClear()
        Me.cmbSegundoConductor.pClear()

        'Cargar Conductores
        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
        obeConductor.pCCMPN_Compania = cmbCompania.SelectedValue
        obeConductor.pCBRCNT_Brevete = conductor1.ToString.Trim
        'obeConductor.pNRUCTR_RucTransportista = txtTransportista.pRucTransportista
        Me.cmbConductor.pCargar(obeConductor)
        obeConductor.pCBRCNT_Brevete = conductor2.ToString.Trim
        Me.cmbSegundoConductor.pCargar(obeConductor)

    End Sub

    Sub Buscar_PreAsignacionUnidad()

        Dim msgValidacion As String = Valida_Filtros()
        If msgValidacion.Length > 0 Then
            MessageBox.Show("Seleccionar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            oPreAsignacionUnidades_BE = New SOLMIN_ST.ENTIDADES.PreAsignacionUnidades_BE
            oPreAsignacionUnidades_BLL = New SOLMIN_ST.NEGOCIO.PreAsignacionUnidades_BLL
            Dim lstPreAsignacionUnidades_BE As List(Of PreAsignacionUnidades_BE)
            'dgvPreAsignacion.DataSource = Nothing
            oPreAsignacionUnidades_BE.PNNPRASG = Val(txtNPreAsignacion.Text)
            oPreAsignacionUnidades_BE.PNFPRASG_INI = Val(HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value))
            oPreAsignacionUnidades_BE.PNFPRASG_FIN = Val(HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value))
            oPreAsignacionUnidades_BE.PSCCMPN = cmbCompania.SelectedValue
            'compania = cmbCompania.SelectedValue
            oPreAsignacionUnidades_BE.PSCDVSN = cmbDivision.SelectedValue
            'division = cmbDivision.SelectedValue
            oPreAsignacionUnidades_BE.PNCPLNDV = cmbPlanta.SelectedValue
            'planta = cmbPlanta.SelectedValue
            oPreAsignacionUnidades_BE.PNCCLNT = ctlCliente.pCodigo
            oPreAsignacionUnidades_BE.SESASG = cmbEstado.SelectedValue
            oPreAsignacionUnidades_BE.PageNumber = UcPaginacion.PageNumber
            oPreAsignacionUnidades_BE.PageSize = UcPaginacion.PageSize

            Dim NumPaginas As Int64
            lstPreAsignacionUnidades_BE = oPreAsignacionUnidades_BLL.Buscar_PreAsignacionUnidades(oPreAsignacionUnidades_BE, NumPaginas)
            dgvPreAsignacion.DataSource = lstPreAsignacionUnidades_BE
            If dgvPreAsignacion.Rows.Count > 0 Then
                UcPaginacion.PageCount = NumPaginas
            Else
                HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            End If
        End If

    End Sub

#End Region

#Region "Eventos"

    Private Sub frmPreAsignacionUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvPreAsignacion.AutoGenerateColumns = False
            Cargar_Compania()
            cmbCompania_SelectionChangeCommitted(Nothing, Nothing)
            'Cargar_Conductores()
            Llenar_Estado()
            Carga_MedioTransporte()
            cboMedioTransporteFiltro.SelectedValue = 4
            'Cargar_Combos()
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)

            'ctlCliente.CCMPN = cmbCompania.SelectedValue

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guardar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            Dim TextoOpcion As String = OPCION
            Select Case TextoOpcion
                Case texto_Modificar
                    If Me.dgvPreAsignacion.CurrentRow IsNot Nothing Then
                        HabilitarBotonMantenimiento(Mantenimiento.Edicion)
                    End If
                Case texto_Guardar
                    Dim msgValidacion As String = Valida_Campos()
                    If msgValidacion.Length > 0 Then
                        MessageBox.Show("Seleccionar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Modificar_PreAsignacionUnidades()
                        Buscar(Nothing, Nothing)
                    End If
                Case texto_Registrar
                    Dim msgValidacion As String = Valida_Campos()
                    If msgValidacion.Length > 0 Then
                        MessageBox.Show("Seleccionar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Registrar_PreAsignacionUnidades()
                        Buscar(Nothing, Nothing)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTransportista_InformationChanged() Handles txtTransportista.InformationChanged
        Try
            Cargar_Tracto_Acoplado(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectionChangeCommitted
        Try
            Cargar_Division()
            CargarTransportista()
            Cargar_Conductores()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectionChangeCommitted
        Try
            Cargar_Planta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_PreAsignacionUnidad()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Nuevo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Nuevo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvPreAsignacion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPreAsignacion.SelectionChanged

        Try

            Dim tracto, acoplado, conductor1, conductor2 As String
            If dgvPreAsignacion.CurrentRow IsNot Nothing And dgvPreAsignacion.Rows.Count > 0 Then

                Dim lint_indice As Integer = Me.dgvPreAsignacion.CurrentCellAddress.Y

                cmbCompania.SelectedValue = Me.dgvPreAsignacion.Item("PSCCMPN", lint_indice).Value.ToString.Trim
                'cmbCompania_SelectionChangeCommitted(Nothing, Nothing)
                cmbDivision.SelectedValue = Me.dgvPreAsignacion.Item("PSCDVSN", lint_indice).Value.ToString.Trim
                cmbPlanta.SelectedValue = Me.dgvPreAsignacion.Item("PNCPLNDV", lint_indice).Value.ToString.Trim

                txtPreAsignacionUnidades.Text = Me.dgvPreAsignacion.Item("PNNPRASG", lint_indice).Value.ToString.Trim
                'UcCliente_TxtF012.CCMPN = dgvPreAsignacion.Item("PSCCMPN", lint_indice).Value.ToString.Trim
                UcCliente_TxtF012.pCargar(dgvPreAsignacion.Item("PNCCLNT", lint_indice).Value)

                'Cargar transportista
                Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
                obeTransportista.pCCMPN_Compania = cmbCompania.SelectedValue
                obeTransportista.pNRUCTR_RucTransportista = dgvPreAsignacion.Item("PNNRUCTR", lint_indice).Value
                Me.txtTransportista.pCargar(obeTransportista)
                'txtTransportista_InformationChanged()

                tracto = dgvPreAsignacion.Item("PSNPLCUN", lint_indice).Value.ToString.Trim
                acoplado = dgvPreAsignacion.Item("PSNPLCAC", lint_indice).Value.ToString.Trim
                Cargar_Tracto_Acoplado(tracto, acoplado)

                conductor1 = dgvPreAsignacion.Item("PSCBRCNT", lint_indice).Value.ToString.Trim
                conductor2 = dgvPreAsignacion.Item("PSCBRCN2", lint_indice).Value.ToString.Trim

                Cargar_Conductores(conductor1, conductor2)

                'Carga_MedioTransporte()
                cboMedioTransporteFiltro.SelectedValue = dgvPreAsignacion.Item("PNCMEDTR", lint_indice).Value

                'Cargar_Combos()
                cboLugarorigen.Valor = dgvPreAsignacion.Item("PNCLCLOR", lint_indice).Value
                cboLugarDestino.Valor = dgvPreAsignacion.Item("PNCLCLDS", lint_indice).Value

                txtDesDireccionOrigen.Text = dgvPreAsignacion.Item("PSTDRORI", lint_indice).Value
                txtNGuiaTransporte.Text = dgvPreAsignacion.Item("PNNGUITR", lint_indice).Value
                If dgvPreAsignacion.Item("PSFGUITR", lint_indice).Value.ToString.Trim = "" Then
                    dtpGuiaRemision.Value = Now.Date
                Else
                    dtpGuiaRemision.Value = CDate(dgvPreAsignacion.Item("PSFGUITR", lint_indice).Value)
                End If

                txtNOperacion.Text = dgvPreAsignacion.Item("PNNOPRCN", lint_indice).Value

                txtDireccionEntregaMercaderia.Text = dgvPreAsignacion.Item("PSTDRENT", lint_indice).Value.ToString.Trim
                txtObservaciones.Text = dgvPreAsignacion.Item("PSTOBS", lint_indice).Value.ToString.Trim

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNPreAsignacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNPreAsignacion.KeyPress, txtNGuiaTransporte.KeyPress, txtNOperacion.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            Buscar_PreAsignacionUnidad()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cancelar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            dgvPreAsignacion_SelectionChanged(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Eliminar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If dgvPreAsignacion.CurrentRow IsNot Nothing Then
                If MessageBox.Show("Desea eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Eliminar_PreAsignacionUnidades()
                    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
                    Buscar_PreAsignacionUnidad()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportarParcial(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarParcial.Click

        Try
            'Dim NPOI As New HelpClass_NPOI_SC
            Dim NPOI As New HelpClass_NPOI_ST
            Dim lstrPeriodo As String = ""
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            If dgvPreAsignacion.Rows.Count > 0 Then
                For Each Item As DataGridViewColumn In dgvPreAsignacion.Columns
                    ColTitle = Item.HeaderText.Trim
                    ColName = Item.Name
                    TipoDato = ""
                    If Item.Visible = True Then
                        If ColName.Contains("PNFGUITR") Or ColName.Contains("PNFPRASG") Then
                            TipoDato = HelpClass_NPOI_ST.keyDatoFecha
                        ElseIf ColName.Contains("PNNPRASG") Or ColName.Contains("PNNGUITR") Or ColName.Contains("PNNOPRCN") Then
                            TipoDato = HelpClass_NPOI_St.keyDatoNumero
                        Else
                            TipoDato = HelpClass_NPOI_ST.keyDatoTexto
                        End If
                        dtExport.Columns.Add(ColName)
                        MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
                        dtExport.Columns(ColName).Caption = MdataColumna
                    End If
                Next

                Dim dr As DataRow
                For Fila As Integer = 0 To dgvPreAsignacion.Rows.Count - 1
                    dr = dtExport.NewRow
                    For Columna As Integer = 0 To dtExport.Columns.Count - 1
                        ColName = dtExport.Columns(Columna).ColumnName
                        If (dgvPreAsignacion.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                            dr(ColName) = dgvPreAsignacion.Rows(Fila).Cells(ColName).FormattedValue
                        End If
                    Next
                    dtExport.Rows.Add(dr)
                Next
                Dim oLisParametros As New SortedList
                oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
                oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")
                Dim Titulo As String = "PRE-ASIGNACIONES DE UNIDADES"
                'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, Titulo, Nothing, oLisParametros)
                HelpClass_NPOI_ST.ExportExcelGeneralRelease(dtExport, Titulo, Nothing, oLisParametros)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportarTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarTotal.Click

        Try
            oPreAsignacionUnidades_BE = New SOLMIN_ST.ENTIDADES.PreAsignacionUnidades_BE
            oPreAsignacionUnidades_BLL = New SOLMIN_ST.NEGOCIO.PreAsignacionUnidades_BLL
            Dim lstPreAsignacionUnidades_BE As List(Of PreAsignacionUnidades_BE)

            lstPreAsignacionUnidades_BE = oPreAsignacionUnidades_BLL.Exportar_PreAsignacionUnidades()
            dgvPreAsignacion.DataSource = lstPreAsignacionUnidades_BE

            'Dim NPOI As New HelpClass_NPOI_SC
            Dim NPOI As New HelpClass_NPOI_ST
            Dim lstrPeriodo As String = ""
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            If dgvPreAsignacion.Rows.Count > 0 Then
                For Each Item As DataGridViewColumn In dgvPreAsignacion.Columns
                    ColTitle = Item.HeaderText.Trim
                    ColName = Item.Name
                    TipoDato = ""
                    If Item.Visible = True Then
                        If ColName.Contains("PSFGUITR") Or ColName.Contains("PNFPRASG") Then
                            TipoDato = HelpClass_NPOI_ST.keyDatoFecha
                        ElseIf ColName.Contains("PNNPRASG") Or ColName.Contains("PNNGUITR") Or ColName.Contains("PNNOPRCN") Then
                            TipoDato = HelpClass_NPOI_St.keyDatoNumero
                        Else
                            TipoDato = HelpClass_NPOI_St.keyDatoTexto
                        End If
                        dtExport.Columns.Add(ColName)
                        MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
                        dtExport.Columns(ColName).Caption = MdataColumna
                    End If
                Next

                Dim dr As DataRow
                For Fila As Integer = 0 To dgvPreAsignacion.Rows.Count - 1
                    dr = dtExport.NewRow
                    For Columna As Integer = 0 To dtExport.Columns.Count - 1
                        ColName = dtExport.Columns(Columna).ColumnName
                        If (dgvPreAsignacion.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                            dr(ColName) = dgvPreAsignacion.Rows(Fila).Cells(ColName).FormattedValue
                        End If
                    Next
                    dtExport.Rows.Add(dr)
                Next
                Dim oLisParametros As New SortedList
                oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
                oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")
                Dim Titulo As String = "PRE-ASIGNACIONES DE UNIDADES"
                'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, Titulo, Nothing, oLisParametros)
                HelpClass_NPOI_ST.ExportExcelGeneralRelease(dtExport, Titulo, Nothing, oLisParametros)
            End If

            Buscar(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

    End Sub
End Class

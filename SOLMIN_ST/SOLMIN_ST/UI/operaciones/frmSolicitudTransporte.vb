Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports System.Data
Imports System.Text

Public Class frmSolicitudTransporte
    Private oSeguridad As Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(USUARIO)
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private _estado As Integer = 0
    Private objFormBuscarOrdenServicio As frmBuscarOrdenServicio
    Private _CTPOVJ As String = "E"
    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"

    Private Sub frmSolicitudTransporte_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If gintEstado = 0 Then
            txtOrdenServicio.Text = ""
            'ctlLocalidadOrigen.Limpiar()
            '      ctlLocalidadDestino.Limpiar()
            '      txtUbigeoOrigen.Limpiar()
            '      txtUbigeoDestino.Limpiar()

            txtUbigeoOrigen1.Text = ""
            txtUbigeoOrigen1.Tag = 0
            txtUbigeoDestino1.Text = ""
            txtUbigeoDestino1.Tag = 0

            txtLocalidadCarga1.Text = ""
            txtLocalidadCarga1.Tag = 0
            txtLocalidadEntrega1.Text = ""
            txtLocalidadEntrega1.Tag = 0


        End If
        If gintEstado = 2 Then
            LimpiarDatosGenerales()
            'ctlLocalidadOrigen.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR
            'ctlLocalidadDestino.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS

            txtOrdenServicio.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT
            txtTipoServicio.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTPOSR
            ctbMercaderias.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CMRCDR
            txtUnidadMedida.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUNDMD
            txtCantidadMercaderia.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.QMRCDR



            'txtUbigeoOrigen.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI
            'txtUbigeoDestino.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES
            txtUbigeoOrigen1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI
            If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI = 0 Then
                txtUbigeoOrigen1.Text = ""
            Else
                txtUbigeoOrigen1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_O
                txtUbigeoOrigen1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI
            End If
            txtUbigeoDestino1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES
            If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES = 0 Then
                txtUbigeoDestino1.Text = ""
            Else
                txtUbigeoDestino1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_D
                txtUbigeoDestino1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES
            End If
            txtLocalidadCarga1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTORG
            txtLocalidadCarga1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR
            txtLocalidadEntrega1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTDES
            txtLocalidadEntrega1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS

            Exit Sub
        End If
        gintEstado = -1
    End Sub

    Private Sub frmSolicitudTransporte_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not oSeguridad Is Nothing Then oSeguridad.Dispose()
        oSeguridad = Nothing
    End Sub

    Private Sub frmSolicitudTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Me.btnGuardar.Enabled = False
            Me.btnCancelar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.ckbRangoFechas.Checked = False
            KryptonCheckBox1.Checked = False
            Me.txtCantidadMercaderia.TextValidationType = ValidationInputType.Numeric
            Me.txtCantidadSolicitada.TextValidationType = ValidationInputType.Numeric
            'Me.ctlLocalidadDestino.Enabled = False
            'Me.ctlLocalidadOrigen.Enabled = False
            ddlEstado.SelectedIndex = 1

            Me.Cargar_Compania()
            Me.Limpiar_Controles()
            Me.Carga_TipoSolicitud()
            Me.Carga_Usuario()
            Me.Carga_TipoPrioridad()
            Me.ddlPrioridad.SelectedValue = "N"
            Me.Cargar_Combos()
            Me.Carga_MedioTransporte()
            Me.Estado_Controles(False)
            Me.cboMedioTransporteFiltro.SelectedValue = 4
            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
            gintEstado = 0
            Me.Alinear_Columnas_Grilla()
            Me.Validar_Acceso_Opciones_Usuario()
            Me.btnAdjuntarDocumentos.Visible = False
        Catch : End Try
    End Sub

    Private Sub Alinear_Columnas_Grilla()

        Me.gwdDatos.AutoGenerateColumns = False
        Me.dtgRecursosAsignados.AutoGenerateColumns = False

        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador As Integer = 0 To Me.dtgRecursosAsignados.ColumnCount - 1
            Me.dtgRecursosAsignados.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        dtgRecursosAsignados.Columns.Item(2).DisplayIndex = 0
        dtgRecursosAsignados.Columns.Item(3).DisplayIndex = 1
        dtgRecursosAsignados.Columns.Item(4).DisplayIndex = 2
        dtgRecursosAsignados.Columns.Item(5).DisplayIndex = 3
        dtgRecursosAsignados.Columns.Item(6).DisplayIndex = 4
        dtgRecursosAsignados.Columns.Item(28).DisplayIndex = 5
        dtgRecursosAsignados.Columns.Item(7).DisplayIndex = 6
        dtgRecursosAsignados.Columns.Item(8).DisplayIndex = 7
        dtgRecursosAsignados.Columns.Item(9).DisplayIndex = 8
        dtgRecursosAsignados.Columns.Item(10).DisplayIndex = 9
        dtgRecursosAsignados.Columns.Item(24).DisplayIndex = 10
        dtgRecursosAsignados.Columns.Item(11).DisplayIndex = 11
        dtgRecursosAsignados.Columns.Item(12).DisplayIndex = 12
        dtgRecursosAsignados.Columns.Item(13).DisplayIndex = 13
        dtgRecursosAsignados.Columns.Item(14).DisplayIndex = 14
        dtgRecursosAsignados.Columns.Item(15).DisplayIndex = 15
        dtgRecursosAsignados.Columns.Item(16).DisplayIndex = 16

        dtgRecursosAsignados.Columns.Item(18).DisplayIndex = 17
        dtgRecursosAsignados.Columns.Item(19).DisplayIndex = 18
        dtgRecursosAsignados.Columns.Item(20).DisplayIndex = 19
        dtgRecursosAsignados.Columns.Item(21).DisplayIndex = 20
        dtgRecursosAsignados.Columns.Item(22).DisplayIndex = 21

        dtgRecursosAsignados.Columns.Item(17).DisplayIndex = 22
        dtgRecursosAsignados.Columns.Item(23).DisplayIndex = 23

        dtgRecursosAsignados.Columns.Item(25).DisplayIndex = 24
        dtgRecursosAsignados.Columns.Item(26).DisplayIndex = 25

        dtgRecursosAsignados.Columns.Item(0).DisplayIndex = 26
        dtgRecursosAsignados.Columns.Item(1).DisplayIndex = 27
        dtgRecursosAsignados.Columns.Item(27).DisplayIndex = 28
        dtgRecursosAsignados.Columns.Item(29).DisplayIndex = 29
        dtgRecursosAsignados.Columns.Item(30).DisplayIndex = 30
    End Sub

    Private Sub Cargar_Combos()
        Dim obj_Logica_Unidad As New NEGOCIO.UnidadMedida_BLL
        Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
        Dim obj_Logica_Servicio As New NEGOCIO.mantenimientos.ServicioTransporte_BLL
        Dim obj_Entidad_Servicio As New ENTIDADES.mantenimientos.ServicioTransporte
        Dim obj_Logica_Mercaderia As New NEGOCIO.mantenimientos.MercaderiaTransportes_BLL
        Dim obj_Entidad_Mercaderia As New ENTIDADES.mantenimientos.MercaderiaTransportes
        obj_Entidad_Mercaderia.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Dim obj_Logica_Ubigeo As New NEGOCIO.mantenimientos.LocalidadRuta_BLL

        Dim objTipoCarroceria As New TipoCarroceria_BLL
        With Me.ctlTipoVehiculo
            .DataSource = HelpClass.GetDataSetNative(objTipoCarroceria.Listar_TipoCarroceria(Me.cmbCompania.CCMPN_CodigoCompania))
            .KeyField = "CTPCRA"
            .ValueField = "TCMCRA"
            .DataBind()
        End With

        With Me.ctbMercaderias
            .DataSource = HelpClass.GetDataSetNative(obj_Logica_Mercaderia.Listar_MercaderiaTransportes(obj_Entidad_Mercaderia))
            .KeyField = "CMRCDR"
            .ValueField = "TCMRCD"
            .DataBind()
        End With

        obj_Entidad_Servicio.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        With Me.txtTipoServicio
            .DataSource = HelpClass.GetDataSetNative(obj_Logica_Servicio.Listar_ServicioTransporte(obj_Entidad_Servicio))
            .KeyField = "CTPOSR"
            .ValueField = "TCMTPS"
            .DataBind()
        End With

        'Dim objDt As DataTable
        'objDt = obj_Logica_Localidad.Listar_Localidades_Combo(Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim)
        'With Me.ctlLocalidadOrigen
        '  .DataSource = objDt.Copy
        '  .KeyField = "CLCLD"
        '  .ValueField = "TCMLCL"
        '  .DataBind()
        'End With

        'With Me.ctlLocalidadDestino
        '  .DataSource = objDt.Copy
        '  .KeyField = "CLCLD"
        '  .ValueField = "TCMLCL"
        '  .DataBind()
        'End With

        With Me.txtUnidadMedida
            .DataSource = obj_Logica_Unidad.Listar_Unidad_Medida_Combo(Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim)
            .KeyField = "CUNDMD"
            .ValueField = "TCMPUN"
            .DataBind()
        End With


        'With Me.txtUbigeoOrigen
        '    .DataSource = obj_Logica_Ubigeo.Listar_Ubigeo(Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim)
        '    .KeyField = "UBIGEO"
        '    .ValueField = "DESCRIPCION"
        '    .DataBind()
        'End With

        'With Me.txtUbigeoDestino
        '    .DataSource = obj_Logica_Ubigeo.Listar_Ubigeo(Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim)
        '    .KeyField = "UBIGEO"
        '    .ValueField = "DESCRIPCION"
        '    .DataBind()
        'End With



    End Sub

#Region "Cargar Compania Division Planta"

    Private Sub Cargar_Compania()
        Try
            cmbCompania.Usuario = MainModule.USUARIO
            'cmbCompania.CCMPN_CompaniaDefault = "EZ"
            cmbCompania.pActualizar()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboMedioTransporte.DataSource = objTabla.Copy
        Me.cboMedioTransporte.ValueMember = "CMEDTR"
        Me.cboMedioTransporte.DisplayMember = "TNMMDT"

        Me.cboMedioTransporteFiltro.DataSource = objTabla.Copy
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
    End Sub

#End Region

    Private Function Asignar_Valor() As String

        Dim cadena As String = ""

        If Me.ddlEstado.SelectedIndex = 0 Then
            cadena = ""
        ElseIf Me.ddlEstado.SelectedIndex = 1 Then
            cadena = "P"
        ElseIf Me.ddlEstado.SelectedIndex = 2 Then
            cadena = "C"
        ElseIf ddlEstado.SelectedIndex = 3 Then
            cadena = ""
        End If
        Return cadena
    End Function

    Private Function Asignar_Valor_Estado() As String
        Dim estado As String = ""

        If Me.ddlEstado.SelectedIndex = 0 Then
            estado = ""
        ElseIf Me.ddlEstado.SelectedIndex = 1 Or Me.ddlEstado.SelectedIndex = 2 Then
            estado = "A"
        ElseIf ddlEstado.SelectedIndex = 3 Then
            estado = "*"
        End If
        Return estado
    End Function

    Private Sub Listar()
        'Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        'Dim objSolicitud As New Solicitud_Transporte
        'Dim objParamList As New List(Of String)
        'Dim lstr_FecIni As String = ""
        'Dim lstr_FecFin As String = ""

        'If Me.ckbRangoFechas.Checked = True Then
        '  lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
        '  lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        'End If

        'If Me.txtNroSolicitud.Text.Trim.Equals("") Then
        '  objParamList.Add("0")
        'Else
        '  objParamList.Add(Me.txtNroSolicitud.Text.Trim)
        'End If
        'If txtClienteFiltro.pCodigo <> 0 Then
        '  objParamList.Add(txtClienteFiltro.pCodigo)
        'Else
        '  objParamList.Add("0")
        'End If
        'objParamList.Add(Asignar_Valor)
        'objParamList.Add(lstr_FecIni)
        'objParamList.Add(lstr_FecFin)
        'objParamList.Add(Me.cboMedioTransporteFiltro.SelectedValue)
        'objParamList.Add(Me.cmbCompania.CCMPN_CodigoCompania)
        'objParamList.Add(Me.cmbDivision.Division)
        'objParamList.Add(Me.cmbPlanta.Planta)
        'If Me.txtNroOperacion.Text.Trim.Equals("") Then
        '  objParamList.Add("0")
        'Else
        '  objParamList.Add(Me.txtNroOperacion.Text.Trim)
        'End If
        'objParamList.Add("0")
        'objParamList.Add("0")
        'Me.gwdDatos.AutoGenerateColumns = False
        'Me.gwdDatos.DataSource = objSolicitudTransporte.Listar_Solicitud_Transporte_Estado(objParamList)
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objSolicitud As New Solicitud_Transporte
        Dim objParamList As New List(Of String)
        'Dim lstr_FecIni As Int32 = 0
        'Dim lstr_FecFin As Int32 = 0

        'If Me.ckbRangoFechas.Checked = True Then
        '  lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
        '  lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        '    End If

        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        Dim lstr_HoraIni As Int32 = 0
        Dim lstr_HoraFin As Int32 = 0

        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        Else
            lstr_FecIni = 0
            lstr_FecFin = 0
        End If

        If KryptonCheckBox1.Checked = True Then
            lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
            lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
        Else
            lstr_HoraIni = 0
            lstr_HoraFin = 0
        End If

        If Me.txtNroSolicitud.Text.Trim.Equals("") Then
            objSolicitud.NCSOTR = 0 'objParamList.Add("0")
        Else
            objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim 'objParamList.Add(Me.txtNroSolicitud.Text.Trim)
        End If
        If txtClienteFiltro.pCodigo <> 0 Then
            objSolicitud.CCLNT = txtClienteFiltro.pCodigo 'objParamList.Add(txtClienteFiltro.pCodigo)
        Else
            objSolicitud.CCLNT = 0 'objParamList.Add("0")
        End If
        If Me.txtNroOperacion.Text.Trim.Equals("") Then
            objSolicitud.NOPRCN = 0 'objParamList.Add("0")
        Else
            objSolicitud.NOPRCN = Me.txtNroOperacion.Text.Trim 'objParamList.Add(Me.txtNroOperacion.Text.Trim)
        End If
        objSolicitud.SESSLC = Asignar_Valor()                           'objParamList.Add(Asignar_Valor)
        objSolicitud.SESTRG = Asignar_Valor_Estado()
        objSolicitud.FE_INI = lstr_FecIni                               'objParamList.Add(lstr_FecIni)
        objSolicitud.FE_FIN = lstr_FecFin                               'objParamList.Add(lstr_FecFin)
        objSolicitud.HR_INI = lstr_HoraIni
        objSolicitud.HR_FIN = lstr_HoraFin
        objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue 'objParamList.Add(Me.cboMedioTransporteFiltro.SelectedValue)
        objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania        'objParamList.Add(Me.cmbCompania.CCMPN_CodigoCompania)
        objSolicitud.CDVSN = Me.cmbDivision.Division                    'objParamList.Add(Me.cmbDivision.Division)
        objSolicitud.CPLNDV = Me.cmbPlanta.Planta                       'objParamList.Add(Me.cmbPlanta.Planta)
        If ckbUsuarioCreador.Checked = True Then
            objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim 'txtUsuarioCreador.Text.Trim
        Else
            objSolicitud.CUSCRT = ""
        End If
        objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim

        objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue

        'objSolicitud.CUSCRT
        'objSolicitud.CLCLOR_C = 0               'objParamList.Add(cmbOrigen.SelectedValue)
        'objSolicitud.CLCLDS_C = 0               'objParamList.Add(cmbDestino.SelectedValue)
        'objParamList.Add(cmbOrigen.Text.Trim)
        'objParamList.Add(cmbDestino.Text.Trim)
        Me.gwdDatos.AutoGenerateColumns = False
        'Me.gwdDatos.DataSource = objSolicitudTransporte.Listar_Solicitud_Transporte_Estado(objParamList)
        Me.gwdDatos.DataSource = objSolicitudTransporte.Listar_Solicitud_Transporte_Estado(objSolicitud)

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            'Dim strMensaje As String = ""
            'If oSeguridad.fblnIsLocked(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division, txtCliente.pCodigo, "SOLMIN_ST", strMensaje) Then
            '  If strMensaje <> "" Then MessageBox.Show(strMensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '  Exit Sub
            'End If
            If validar_inputs() = True Then
                Exit Sub
            End If
            Me.Nuevo_Registro()
            Me.AccionCancelar()
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If validar_inputs() = True Then
                Exit Sub
            End If
            Me.Modificar_Registro()
            Me.AccionCancelar()
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            Me.Estado_Controles(True)
            Me.btnGuardar.Text = "Guardar"
            Me.btnNuevo.Enabled = False
            Me.btnCancelar.Enabled = True
            Me.btnEliminar.Enabled = False
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        End If
    End Sub

    Private Sub AccionCancelar()
        Select Case Me.gEnum_Mantenimiento
            Case MANTENIMIENTO.NUEVO
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Me.Limpiar_Controles()
                Me.Estado_Controles(False)
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.gwdDatos.CurrentRow.Selected = False
                End If
                Me.btnNuevo.Enabled = True
                Me.btnGuardar.Enabled = False
                Me.btnCancelar.Enabled = False
                Me.btnEliminar.Enabled = False
            Case MANTENIMIENTO.MODIFICAR, MANTENIMIENTO.EDITAR
                Me.Estado_Controles(False)
                Me.btnNuevo.Enabled = True
                If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
                Me.Cargar_Datos_Grilla()
        End Select

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.AccionCancelar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        If Me.gwdDatos.SelectedRows(0).Cells("CANTOP").Value <> 0 Then
            HelpClass.MsgBox("La solicitud tiene unidades asignadas")
            Exit Sub
        Else
            Dim objSolicitudLogica As New Solicitud_Transporte_BLL
            Dim lintStatus As Int32 = objSolicitudLogica.Validar_Unidades_Asignadas(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
            Select Case lintStatus
                Case -1
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                Case Is > 0
                    HelpClass.MsgBox("La solicitud tiene unidades asignadas")
                    Exit Sub
            End Select
            Dim lintCantSol As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
            Select Case lintCantSol
                Case -1
                    HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                    Exit Sub
                Case -2
                    HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                    Exit Sub
                Case -3
                    HelpClass.ErrorMsgBox()
                    Exit Sub
            End Select
        End If
        If MsgBox("Desea eliminar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Cambiar_Estado_Solicitud("*")
    End Sub

    Private Sub Cambiar_Estado_Solicitud(ByVal lstr_Estado As String)
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Try
            objEntidad.NCSOTR = Me.Codigo.Text
            objEntidad.SESTRG = lstr_Estado
            objEntidad.CULUSA = MainModule.USUARIO
            'objEntidad.FULTAC = HelpClass.TodayNumeric
            'objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objEntidad.CDVSN = Me.cmbDivision.Division
            objEntidad.CPLNDV = Me.cmbPlanta.Planta

            objEntidad = objSolicitudTransporte.Cambiar_Estado_Solicitud_Transporte(objEntidad)
            If objEntidad.NCSOTR = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
            End If
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Me.Listar()
            Me.AccionCancelar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cerrar_Solicitud()
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Try
            objEntidad.NCSOTR = Me.Codigo.Text
            objEntidad.SESSLC = "C"
            'objEntidad.SESTRG = "*"
            objEntidad.CULUSA = MainModule.USUARIO
            'objEntidad.FULTAC = HelpClass.TodayNumeric
            'objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objEntidad.CDVSN = Me.cmbDivision.Division
            objEntidad.CPLNDV = Me.cmbPlanta.Planta

            objEntidad = objSolicitudTransporte.Cerrar_Solicitud_Transporte(objEntidad)
            If objEntidad.NCSOTR = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Cerró Satisfactoriamente")
            End If
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Me.Listar()
            Me.AccionCancelar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Nuevo_Registro()

        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        'Try
        objEntidad.NCSOTR = "0"
        objEntidad.CCLNT = txtCliente.pCodigo
        objEntidad.CMRCDR = Me.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.NORSRT = IIf(Me.txtOrdenServicio.Text = "", 0, Me.txtOrdenServicio.Text)

        If _estado = 1 Then
            objEntidad.FECOST = HelpClass.TodayNumeric
            _estado = 0
        Else
            objEntidad.FECOST = HelpClass.CtypeDate(Me.dtpFechaSolicitud.Value)
        End If

        objEntidad.CLCLOR = txtLocalidadCarga1.Tag 'Me.ctlLocalidadOrigen.Codigo
        objEntidad.TDRCOR = Me.txtDireccionLocalidadCarga.Text
        objEntidad.CLCLDS = txtLocalidadEntrega1.Tag 'Me.ctlLocalidadDestino.Codigo
        objEntidad.TDRENT = Me.txtDireccionLocalidadEntrega.Text
        objEntidad.CUNDMD = txtUnidadMedida.Codigo
        objEntidad.QSLCIT = IIf(Me.txtCantidadSolicitada.Text = "", "0", Me.txtCantidadSolicitada.Text)
        objEntidad.QATNAN = "0"
        objEntidad.FINCRG = HelpClass.CtypeDate(Me.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(Me.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(Me.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(Me.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(Me.txtCantidadMercaderia.Text = "", "0", Me.txtCantidadMercaderia.Text)
        objEntidad.SESTRG = "A"
        objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
        objEntidad.CUNDVH = Me.ctlTipoVehiculo.Codigo
        objEntidad.CUSCRT = MainModule.USUARIO
        'objEntidad.FCHCRT = HelpClass.TodayNumeric
        'objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO
        'objEntidad.FULTAC = HelpClass.TodayNumeric
        'objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.TOBS = Me.txtObservaciones.Text
        'NUEVO 
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.CDVSN = Me.cmbDivision.Division
        objEntidad.CPLNDV = Me.cmbPlanta.Planta
        objEntidad.SFCRTV = Me.cmbTipoSolicitud.SelectedValue
        objEntidad.CMEDTR = Me.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = Me.txtCentroCostoCliente.Text.Trim
        objEntidad.TRFRN = Me.txtUsuarioSolicitante.Text.Trim
        objEntidad.CTPOVJ = Me._CTPOVJ
        objEntidad.SPRSTR = Me.ddlPrioridad.SelectedValue

        objEntidad.CUBORI = txtUbigeoOrigen1.Tag 'txtUbigeoOrigen.Codigo
        objEntidad.CUBDES = txtUbigeoDestino1.Tag 'txtUbigeoDestino.Codigo

        Dim msgReg As String = ""
        objEntidad = objSolicitudTransporte.Registrar_Solicitud_Transporte(objEntidad, msgReg)
        If msgReg.Length > 0 Then
            MessageBox.Show(msgReg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        HelpClass.MsgBox("Se Registró Satisfactoriamente la Solicitud N° " & objEntidad.NCSOTR)

        'If objEntidad.NCSOTR = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    HelpClass.MsgBox("Se Registró Satisfactoriamente la Solicitud N° " & objEntidad.NCSOTR)
        '    Try
        '        If objEntidad.SPRSTR = "U" And objEntidad.CMEDTR = 4 Then
        '            SendMail(objEntidad)
        '        End If
        '    Catch ex As Exception
        '    End Try
        'End If

        Me.Listar()

        'Catch ex As Exception
        'End Try

    End Sub

    Private Function SendMail(ByVal objEntidad As Solicitud_Transporte) As Boolean
        Dim strSMSRespuesta As String = ""
        Dim strServer As String = System.Configuration.ConfigurationSettings.AppSettings("ServerMail").ToString()
        Dim strMailCo As String = System.Configuration.ConfigurationSettings.AppSettings("MailCO").ToString()
        Dim strMailFrom As String = System.Configuration.ConfigurationSettings.AppSettings("MailFrom").ToString()
        Dim strMailFromClave As String = System.Configuration.ConfigurationSettings.AppSettings("MailFromClave").ToString()
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim strAdress As String = objSolicitudTransporte.Lista_Destinatarios(objEntidad)
        Dim strAsunto As String
        strAsunto = "Solicitud de Transporte -  " & Date.Today.ToString("yyyy/MM/dd") & " - " & String.Format("{0:HH:mm:ss tt}", Date.Today.Now) & " - " & "Urgente"
        If Not Ransa.Utilitario.HelpClass.flSendMail(strServer, strMailCo, strMailFrom, strMailFromClave, _
               strAdress, "", strAsunto.Trim, CrearDatosCuerpoOperacion(objEntidad), True, strSMSRespuesta) Then
            MessageBox.Show(strSMSRespuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


    Private Function CrearDatosCuerpoOperacion(ByVal objEntidad As Solicitud_Transporte) As String
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim dt As DataTable = objSolicitudTransporte.Lista_ObtenerSolicitud_Envio(objEntidad)
        Dim bodyemail As New StringBuilder
        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<b> Sres. OPERACIONES TRANSPORTES.</b>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")

        bodyemail.Append(" Se ha registrado la siguiente solicitud de Transporte - Urgente : ")
        bodyemail.Append(dt.Rows(0).Item("""Planta""").ToString.Trim)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        Dim color As String = ""
        Dim colum As String
        Dim strValor As String = ""

        For Each dc As Data.DataColumn In dt.Columns
            colum = dc.ColumnName.Replace("""", "")
            strValor = dt.Rows(0).Item(dc.ColumnName).ToString.Trim
            Select Case colum
                Case "Nro Solicitud"
                    strValor = strValor & "     " & dt.Rows(0).Item("""Medio Envio""").ToString.Trim & " -  " & Date.Today.ToString("yyyy/MM/dd") & " - " & String.Format("{0:HH:mm:ss tt}", Date.Today.Now)
                Case "Medio Envio", "Planta"
                    Continue For
                Case "Unidades Solicitadas", "Cliente", "Ruta"
                    color = " style= 'color:red '"
                Case Else
                    color = ""
            End Select
            bodyemail.Append("<tr>")
            bodyemail.Append("<td style='text-align:left; font-weight: bold;'> <b> ")
            bodyemail.Append("<span ")
            bodyemail.Append(color)
            bodyemail.Append(">")
            bodyemail.Append(dc.ColumnName.Replace("""", ""))
            bodyemail.Append("</span >")
            bodyemail.Append(" </b>")
            bodyemail.Append("</td>")
            bodyemail.Append("<td style='text-align:left'>")
            bodyemail.Append("<span ")
            bodyemail.Append(color)
            bodyemail.Append(">")
            bodyemail.Append(strValor)
            bodyemail.Append("</span >")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")
        Next

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("</table>")
        bodyemail.Append(HTMLFin)
        Return bodyemail.ToString.Trim
    End Function

    Private Sub Modificar_Registro()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim lintCantSol As Int32 = objSolicitudTransporte.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintCantSol
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select
        Try
            objEntidad.NCSOTR = Me.Codigo.Text
            objEntidad.NORSRT = IIf(Me.txtOrdenServicio.Text = "", 0, Me.txtOrdenServicio.Text)
            objEntidad.CCLNT = txtCliente.pCodigo
            objEntidad.CMRCDR = Me.ctbMercaderias.Codigo
            objEntidad.FECOST = HelpClass.TodayNumeric
            objEntidad.HRAOTR = HelpClass.NowNumeric
            objEntidad.FECOST = HelpClass.CtypeDate(Me.dtpFechaSolicitud.Value)
            objEntidad.CLCLOR = txtLocalidadCarga1.Tag 'Me.ctlLocalidadOrigen.Codigo
            objEntidad.TDRCOR = Me.txtDireccionLocalidadCarga.Text
            objEntidad.CLCLDS = txtLocalidadEntrega1.Tag 'Me.ctlLocalidadDestino.Codigo
            objEntidad.TDRENT = Me.txtDireccionLocalidadEntrega.Text
            objEntidad.CUNDMD = txtUnidadMedida.Codigo
            objEntidad.QSLCIT = IIf(Me.txtCantidadSolicitada.Text = "", "0", Me.txtCantidadSolicitada.Text)
            objEntidad.FINCRG = HelpClass.CtypeDate(Me.dtpFechaInicioCarga.Value)
            objEntidad.HINCIN = HelpClass.CompletarCadena(Me.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
            objEntidad.FENTCL = HelpClass.CtypeDate(Me.dtpFinCarga.Value)
            objEntidad.HRAENT = HelpClass.CompletarCadena(Me.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
            objEntidad.QMRCDR = IIf(Me.txtCantidadMercaderia.Text = "", "0", Me.txtCantidadMercaderia.Text)
            objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
            objEntidad.CUNDVH = Me.ctlTipoVehiculo.Codigo
            objEntidad.CULUSA = MainModule.USUARIO
            'objEntidad.FULTAC = HelpClass.TodayNumeric
            'objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.TOBS = Me.txtObservaciones.Text
            objEntidad.SFCRTV = Me.cmbTipoSolicitud.SelectedValue
            objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objEntidad.CDVSN = Me.cmbDivision.Division
            objEntidad.CPLNDV = Me.cmbPlanta.Planta
            objEntidad.CMEDTR = Me.cboMedioTransporte.SelectedValue
            objEntidad.CCTCSC = Me.txtCentroCostoCliente.Text.Trim
            objEntidad.TRFRN = Me.txtUsuarioSolicitante.Text.Trim
            objEntidad.SPRSTR = Me.ddlPrioridad.SelectedValue

            objEntidad.CUBORI = txtUbigeoOrigen1.Tag 'Me.txtUbigeoOrigen.Codigo
            objEntidad.CUBDES = txtUbigeoDestino1.Tag 'Me.txtUbigeoDestino.Codigo

            objEntidad = objSolicitudTransporte.Modificar_Solicitud_Transporte(objEntidad)
            If objEntidad.NCSOTR = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Modificó Satisfactoriamente")
            End If
            Me.Listar()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEliminar.Enabled = False
        Limpiar_Controles()
        Estado_Controles(True)
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
        End If
        Me.cboMedioTransporte.SelectedValue = 4
    End Sub

    Private Function validar_inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        'Evaluando llaves primaria de la tabla
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If txtCliente.pCodigo = 0 Then
                lstr_validacion = "* CODIGO DE CLIENTE " & Chr(13)
            End If
        End If
        'If txtLocalidadCarga1.Tag.ToString.Trim = "" Then
        '    lstr_validacion += "* LOCALIDAD DE CARGA " & Chr(13)
        'End If
        If txtLocalidadCarga1.Tag Is Nothing OrElse txtLocalidadCarga1.Tag.ToString.Trim = "0" Then
            lstr_validacion += "* LOCALIDAD DE CARGA " & Chr(13)
        End If
        If txtDireccionLocalidadCarga.Text.Trim = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE CARGA " & Chr(13)
        End If
        If Me.ctbMercaderias.NoHayCodigo = True Then
            lstr_validacion += "* MERCADERIA DE TRANSLADO " & Chr(13)
        End If
        'If txtLocalidadCarga1.Tag.ToString.Trim = "" Then
        '    lstr_validacion += "* LOCALIDAD DE ENTREGA" & Chr(13)
        'End If
        If txtLocalidadEntrega1.Tag Is Nothing OrElse txtLocalidadEntrega1.Tag.ToString.Trim = "0" Then
            lstr_validacion += "* LOCALIDAD DE ENTREGA" & Chr(13)
        End If

        If txtDireccionLocalidadEntrega.Text.Trim = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If Me.txtOrdenServicio.Text = "" Then
            lstr_validacion += "* ORDEN DE SERVICIO" & Chr(13)
        End If
        If txtCantidadSolicitada.Text = "" Or IsNumeric(Me.txtCantidadSolicitada.Text) = False Then
            lstr_validacion += "* CANTIDAD DE VEHICULOS" & Chr(13)
        Else
            Dim objSolicitudLogica As New Solicitud_Transporte_BLL
            Dim lintStatus As Int32 = objSolicitudLogica.Validar_Unidades_Asignadas(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
            If txtCantidadSolicitada.Text < lintStatus Then
                lstr_validacion += "* LA CANTIDAD DE VEHICULOS ES MENOR A LAS UNIDADES ASIGNADAS" & Chr(13)
            End If
        End If
        If txtTipoServicio.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE SERVICIO" & Chr(13)
        End If
        If Me.ctlTipoVehiculo.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE VEHICULO" & Chr(13)
        End If
        If Me.txtUnidadMedida.NoHayCodigo = True Then
            lstr_validacion += "* UNIDAD DE MEDIDA DE MERCADERIA" & Chr(13)
        End If
        'If HelpClass.CtypeDate(Me.dtpFechaSolicitud.Value) > HelpClass.CtypeDate(Me.dtpFinCarga.Value) Then
        '  lstr_validacion += "* FECHA SOLICITUD MAYOR A FECHA DE ENTREGA" & Chr(13)
        'End If
        'If HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicioCarga.Value.ToShortDateString) > HelpClass.CFecha_a_Numero8Digitos(Me.dtpFinCarga.Value.ToShortDateString) Then
        '  lstr_validacion += "* FECHA DE CARGA MAYOR A FECHA DE ENTREGA" & Chr(13)
        'End If
        If Me.txtUsuarioSolicitante.Text.Trim = "" Then
            lstr_validacion += "* USUARIO SOLICITANTE" & Chr(13)
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)

        txtCliente.Enabled = lbool_Estado
        Me.txtDireccionLocalidadCarga.Enabled = lbool_Estado
        Me.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
        Me.txtCantidadSolicitada.Enabled = lbool_Estado

        Me.txtTipoServicio.Enabled = lbool_Estado
        Me.ctlTipoVehiculo.Enabled = lbool_Estado
        Me.ctbMercaderias.Enabled = lbool_Estado
        Me.txtUnidadMedida.Enabled = lbool_Estado
        Me.txtCantidadMercaderia.Enabled = lbool_Estado
        'Me.dtpFechaSolicitud.Enabled = lbool_Estado
        Me.dtpFechaInicioCarga.Enabled = lbool_Estado
        Me.dtpFinCarga.Enabled = lbool_Estado
        Me.txtObservaciones.Enabled = lbool_Estado
        Me.txtHoraCarga.Enabled = lbool_Estado
        Me.txtHoraEntrega.Enabled = lbool_Estado
        Me.txtOrdenServicio.Enabled = lbool_Estado
        Me.btnBuscaOrdenServicio.Enabled = lbool_Estado
        Me.cmbTipoSolicitud.Enabled = lbool_Estado
        Me.cboMedioTransporte.Enabled = lbool_Estado
        Me.txtCentroCostoCliente.Enabled = lbool_Estado
        Me.txtUsuarioSolicitante.Enabled = lbool_Estado
        Me.cmbUsuarioSolicitante.Enabled = lbool_Estado
        Me.ddlPrioridad.Enabled = lbool_Estado

    End Sub

    Private Sub Limpiar_Controles()
        Me.Codigo.Text = 0
        txtCliente.pClear()

        Me.txtLocalidadEntrega1.Text = ""
        Me.txtLocalidadEntrega1.Tag = 0
        Me.txtLocalidadCarga1.Text = ""
        Me.txtLocalidadCarga1.Tag = 0

        Me.txtUbigeoOrigen1.Text = ""
        Me.txtUbigeoOrigen1.Tag = 0
        Me.txtUbigeoDestino1.Text = ""
        Me.txtUbigeoDestino1.Tag = 0

        'Me.txtUbigeoOrigen.Limpiar()
        'Me.txtUbigeoDestino.Limpiar()
        Me.dtpFechaSolicitud.Value = Date.Now

        'Me.ctlLocalidadOrigen.Limpiar()
        Me.txtDireccionLocalidadCarga.Text = ""

        'Me.ctlLocalidadDestino.Limpiar()
        Me.txtDireccionLocalidadEntrega.Text = ""
        Me.txtCantidadSolicitada.Text = ""
        Me.txtTipoServicio.Limpiar()
        Me.ctlTipoVehiculo.Limpiar()
        Me.ctbMercaderias.Limpiar()
        Me.txtUnidadMedida.Limpiar()
        Me.txtCantidadMercaderia.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtHoraCarga.Text = "00:00:00"
        Me.txtHoraEntrega.Text = "00:00:00"
        Me.txtFechaSolicitud.Text = ""
        Me.txtFechaEntrega.Text = ""
        Me.txtFechaCarga.Text = ""
        Me.dtgRecursosAsignados.Rows.Clear()
        Me.txtOrdenServicio.Text = ""
        Me.txtUsuarioSolicitante.Text = ""
        Me.txtCentroCostoCliente.Text = ""
        kgvUnidadProgramada.DataSource = Nothing
    End Sub

    'Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    '  If Me.gwdDatos.RowCount = 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    '  If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '    If Me.gwdDatos.Rows.Count > 0 Then
    '      Me.gwdDatos.CurrentRow.Selected = False
    '    End If
    '    MsgBox("Debe guardar la solicitud o cancelarla.", MsgBoxStyle.Exclamation)
    '    Exit Sub
    '  ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL Then
    '    Me.AccionCancelar()
    '    If Me.gwdDatos.Rows.Count > 0 Then
    '      Me.gwdDatos.CurrentRow.Selected = True
    '    End If
    '  End If
    '  'Me.Cargar_Datos_Grilla()
    '  'Me.Cargar_Detalle_Solicitud()
    'End Sub

    Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
        'If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        'If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        If Me.gwdDatos.RowCount = 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        'If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        '  If Me.gwdDatos.Rows.Count > 0 Then
        '    Me.gwdDatos.CurrentRow.Selected = False
        '  End If
        '  MsgBox("Debe guardar la solicitud o cancelarla.", MsgBoxStyle.Exclamation)
        '  Exit Sub
        'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL Then
        'Me.AccionCancelar()
        '  If Me.gwdDatos.Rows.Count > 0 Then
        '    Me.gwdDatos.CurrentRow.Selected = True
        '  End If
        'End If
        Me.Estado_Controles(False)
        Me.btnNuevo.Enabled = True
        If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.Cargar_Datos_Grilla()
        Me.Cargar_Detalle_Solicitud()
        Cargar_Detalle_Junta_Programadas()
        'MessageBox.Show(TabSolicitudFlete.Enabled)
    End Sub

    Private Sub Cargar_Detalle_Junta_Programadas()
        kgvUnidadProgramada.AutoGenerateColumns = False
        Dim oDetalle_Solicitud_Transporte As New Detalle_Solicitud_Transporte_BLL
        Dim dtJuntaxSolicitud As New DataTable
        kgvUnidadProgramada.DataSource = Nothing
        dtJuntaxSolicitud = oDetalle_Solicitud_Transporte.Listar_Juntas_x_Solicitud(gwdDatos.CurrentRow.Cells("NCSOTR").Value, cmbCompania.CCMPN_CodigoCompania)
        kgvUnidadProgramada.DataSource = dtJuntaxSolicitud
    End Sub

    Private Sub gwdDatos_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gwdDatos.ColumnHeaderMouseClick
        If Me.gwdDatos.RowCount = 0 Then Exit Sub
        Dim oucOrdena As UCOrdena(Of Solicitud_Transporte)
        Dim olbeSolicitud_Transporte As List(Of Solicitud_Transporte) = Me.gwdDatos.DataSource  'olbeGrifo
        oucOrdena = New UCOrdena(Of Solicitud_Transporte)(Me.gwdDatos.Columns(e.ColumnIndex).Name, UCOrdena(Of Grifo).TipoOrdenacion.Ascendente)
        olbeSolicitud_Transporte.Sort(oucOrdena)
        Me.gwdDatos.DataSource = olbeSolicitud_Transporte
        Me.gwdDatos.Refresh()
    End Sub

    Private Sub Cargar_Datos_Grilla()
        Me.Limpiar_Controles()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", lint_indice).Value.ToString().Trim()

        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad = objSolicitudTransporte.Obtener_Solicitud_Transporte(objEntidad)
        Me.Codigo.Text = objEntidad.NCSOTR
        Me.txtOrdenServicio.Text = objEntidad.NORSRT
        txtCliente.pCargar(objEntidad.CCLNT)
        Me.dtpFechaSolicitud.Text = HelpClass.CNumero_a_Fecha(objEntidad.FECOST)

        'txtUbigeoOrigen.Codigo = objEntidad.CUBORI
        'txtUbigeoDestino.Codigo = objEntidad.CUBDES
        txtUbigeoOrigen1.Tag = objEntidad.CUBORI
        If objEntidad.CUBORI <> 0 Then
            txtUbigeoOrigen1.Text = objEntidad.CUBORI & " - " & objEntidad.UBIGEO_O
        End If

        txtUbigeoDestino1.Tag = objEntidad.CUBDES
        If objEntidad.CUBDES <> 0 Then
            txtUbigeoDestino1.Text = objEntidad.CUBDES & " - " & objEntidad.UBIGEO_D
        End If
        'txtLocalidadCarga1.Text = objEntidad.CLCLDS_C & " - " & objEntidad.CLCLOR
        txtLocalidadCarga1.Text = objEntidad.CLCLOR_C & " - " & objEntidad.CLCLOR_D
        txtLocalidadCarga1.Tag = objEntidad.CLCLOR_C

        'txtLocalidadEntrega1.Text = objEntidad.CLCLDS_C & " - " & objEntidad.CLCLDS
        'txtLocalidadEntrega1.Tag = objEntidad.CLCLDS_C
        txtLocalidadEntrega1.Text = objEntidad.CLCLDS_C & " - " & objEntidad.CLCLDS_D
        txtLocalidadEntrega1.Tag = objEntidad.CLCLDS_C


        'Me.ctlLocalidadOrigen.Codigo = objEntidad.CLCLOR
        Me.txtDireccionLocalidadCarga.Text = objEntidad.TDRCOR
        'Me.ctlLocalidadDestino.Codigo = objEntidad.CLCLDS
        Me.txtDireccionLocalidadEntrega.Text = objEntidad.TDRENT
        Me.txtCantidadSolicitada.Text = objEntidad.QSLCIT
        Me.txtTipoServicio.Codigo = objEntidad.CTPOSR
        Me.ctlTipoVehiculo.Codigo = objEntidad.CUNDVH
        Me.ctbMercaderias.Codigo = objEntidad.CMRCDR
        txtUnidadMedida.Codigo = objEntidad.CUNDMD
        txtCantidadMercaderia.Text = objEntidad.QMRCDR
        Me.txtObservaciones.Text = objEntidad.TOBS.Trim
        Me.dtpFechaInicioCarga.Text = HelpClass.CNumero_a_Fecha(objEntidad.FINCRG)
        Me.dtpFinCarga.Text = HelpClass.CNumero_a_Fecha(objEntidad.FENTCL)
        Me.txtHoraCarga.Text = HelpClass.CompletarCadena(objEntidad.HINCIN, 6, "0", HorizontalAlignment.Left)
        Me.txtHoraEntrega.Text = HelpClass.CompletarCadena(objEntidad.HRAENT, 6, "0", HorizontalAlignment.Left)

        Me.ddlPrioridad.SelectedValue = objEntidad.SPRSTR

        'Pintando los datos de cabecera
        Me.HeaderDatos.ValuesPrimary.Heading = " Nro : " & objEntidad.NCSOTR & " | Clte : " + txtCliente.pRazonSocial & " | Ori : " & Me.txtLocalidadCarga1.Text & " | Dest : " & Me.txtLocalidadEntrega1.Text
        'Marcando el estado de Edicion
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.Enabled = True
        CambioEstadoTabSolicitudFlete()
        'Asignando Datos Informacion de Asignación
        Me.txtFechaSolicitud.Text = Me.gwdDatos.Item("FECOST", lint_indice).Value
        Me.txtFechaCarga.Text = Me.gwdDatos.Item("FINCRG", lint_indice).Value & " - " & Me.gwdDatos.Item("HINCIN", lint_indice).Value
        Me.txtFechaEntrega.Text = Me.gwdDatos.Item("FENTCL", lint_indice).Value & " - " & Me.gwdDatos.Item("HRAENT", lint_indice).Value
        Me.cmbTipoSolicitud.SelectedValue = Me.gwdDatos.CurrentRow.Cells("SFCRTV").Value ' Me.gwdDatos.Rows(lint_indice).Cells("SFCRTV").Value
        Me.cboMedioTransporte.SelectedValue = objEntidad.CMEDTR
        Me.txtCentroCostoCliente.Text = objEntidad.CCTCSC
        Me.txtUsuarioSolicitante.Text = objEntidad.TRFRN
        Dim Estado_Actual_Guardar As Boolean = Me.btnGuardar.Enabled
        Dim Estado_Actual_Eliminar As Boolean = Me.btnEliminar.Enabled
        If Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
            Me.btnGuardar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnCerrarSolicitud.Enabled = False
        ElseIf Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "*" Then
            Me.btnGuardar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnCerrarSolicitud.Enabled = False
        Else
            Me.btnGuardar.Enabled = Estado_Actual_Guardar
            Me.btnEliminar.Enabled = Estado_Actual_Eliminar
        End If
    End Sub

    Private Sub Limpiar_Detalle_Solicitud()
        Me.dtgRecursosAsignados.Rows.Clear()
    End Sub

    Private Sub Cargar_Detalle_Solicitud()
        Dim dwvrow As DataGridViewRow
        Dim objEntidad As New ClaseGeneral
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        Me.Limpiar_Detalle_Solicitud()
        objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        For Each obj_Entidad As ClaseGeneral In objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtgRecursosAsignados)
            dwvrow.Cells(0).Value = obj_Entidad.SEGUIMIENTO
            dwvrow.Cells(2).Value = obj_Entidad.NCSOTR
            dwvrow.Cells(3).Value = obj_Entidad.NCRRSR
            dwvrow.Cells(4).Value = obj_Entidad.NPLNJT
            dwvrow.Cells(5).Value = obj_Entidad.NCRRPL
            dwvrow.Cells(6).Value = obj_Entidad.NRUCTR
            dwvrow.Cells(7).Value = obj_Entidad.NPLCUN
            dwvrow.Cells(8).Value = obj_Entidad.NPLCAC
            dwvrow.Cells(9).Value = obj_Entidad.CBRCND
            dwvrow.Cells(10).Value = obj_Entidad.CBRCNT
            dwvrow.Cells(11).Value = obj_Entidad.FASGTR
            dwvrow.Cells(12).Value = obj_Entidad.HASGTR
            dwvrow.Cells(13).Value = obj_Entidad.FATALM
            dwvrow.Cells(14).Value = obj_Entidad.HATALM
            dwvrow.Cells(15).Value = obj_Entidad.FSLALM
            dwvrow.Cells(16).Value = obj_Entidad.HSLALM
            dwvrow.Cells(17).Value = obj_Entidad.NGUITR
            dwvrow.Cells(18).Value = obj_Entidad.SESPLN
            dwvrow.Cells(19).Value = obj_Entidad.GPSLAT
            dwvrow.Cells(20).Value = obj_Entidad.GPSLON
            dwvrow.Cells(21).Value = obj_Entidad.FECGPS
            dwvrow.Cells(22).Value = obj_Entidad.HORGPS

            If obj_Entidad.NCOREG <> 0 Then
                dwvrow.Cells(1).Value = My.Resources.button_ok1
            Else
                dwvrow.Cells(1).Value = My.Resources.Nada_1
            End If
            dwvrow.Cells(23).Value = obj_Entidad.NOPRCN
            dwvrow.Cells(24).Value = obj_Entidad.CBRCN2
            dwvrow.Cells(25).Value = obj_Entidad.NORINSS
            If obj_Entidad.NORINSS.Trim.ToString = "" OrElse obj_Entidad.NORINSS <= 0 Then
                dwvrow.Cells(25).Style.ForeColor = Color.Blue
                dwvrow.Cells(25).Value = "Enviar SAP"
                dwvrow.Cells(25).ToolTipText = "Dar Click para " & Chr(10) & "enviar Orden Interna a SAP"
            End If
            dwvrow.Cells(26).Value = obj_Entidad.NPLNMT
            dwvrow.Cells(27).Value = ImageList1.Images.Item(0)
            dwvrow.Cells(28).Value = obj_Entidad.TCMTRT
            dwvrow.Cells(29).Value = obj_Entidad.NGSGWP
            dwvrow.Cells(30).Value = obj_Entidad.NCOREG
            dwvrow.Cells(31).Value = obj_Entidad.CTRSPT
            Me.dtgRecursosAsignados.Rows.Add(dwvrow)
        Next

    End Sub

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Limpiar_Controles()
        Me.Listar()
        Me.dtgRecursosAsignados.Rows.Clear()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnImprimirSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirSolicitud.Click
        'Imprime la solicitud de flete por estado
        Me.Cursor = Cursors.WaitCursor
        'Dim ListaParametros As New List(Of String)
        Dim ListaParametros As New Hashtable
        Dim lstr_FecIni As String = ""
        Dim lstr_FecFin As String = ""
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        Dim NroSol As Int32
        If Me.txtNroSolicitud.Text.Trim = "" Then
            NroSol = 0
        Else
            NroSol = Convert.ToInt32(Me.txtNroSolicitud.Text)
        End If
        'ListaParametros.Add(NroSol)
        'If txtClienteFiltro.pCodigo <> 0 Then
        '    ListaParametros.Add(txtClienteFiltro.pCodigo)
        'Else
        '    ListaParametros.Add("0")
        'End If
        'ListaParametros.Add(Asignar_Valor)
        'ListaParametros.Add(Me.cboMedioTransporteFiltro.SelectedValue)
        'ListaParametros.Add(lstr_FecIni)
        'ListaParametros.Add(lstr_FecFin)
        'ListaParametros.Add(Me.cmbCompania.CCMPN_CodigoCompania)
        'ListaParametros.Add(Me.cmbDivision.Division)
        'ListaParametros.Add(Me.cmbPlanta.Planta)

        ListaParametros("PNNCSOTR") = NroSol
        If txtClienteFiltro.pCodigo <> 0 Then
            ListaParametros("PNCCLNT") = txtClienteFiltro.pCodigo
        Else
            ListaParametros("PNCCLNT") = "0"
        End If
        ListaParametros("PSSESSLC") = Asignar_Valor()
        ListaParametros("PNCMEDTR") = Me.cboMedioTransporteFiltro.SelectedValue
        ListaParametros("PNFECINI") = lstr_FecIni
        ListaParametros("PNFECFIN") = lstr_FecFin
        ListaParametros("PSCCMPN") = cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        ListaParametros("PSCDVSN") = cmbDivision.Division.ToString.Trim
        ListaParametros("PNCPLNDV") = Me.cmbPlanta.Planta.ToString.Trim

        Imprimir2(ListaParametros)
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub Imprimir2(ByVal ListaParametros As List(Of String))
    Private Sub Imprimir2(ByVal ListaParametros As Hashtable)
        Dim objRep As New Solicitud_Transporte_BLL

        Dim objCrep As New rptSolicitudPendiente1 'nuevas modificaciones

        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim objPrintForm As New PrintForm
        objDt = objRep.Lista_Solicitudes_Transporte2(ListaParametros)
        objDt.TableName = "RZST07"
        objDs.Tables.Add(objDt.Copy)
        objDt = objRep.Listar_Solicitudes_Vehiculo(ListaParametros)
        objDt.TableName = "RZST071"
        objDs.Tables.Add(objDt.Copy)

        HelpClass.CrystalReportTextObject(objCrep, "lblEstado", Me.ddlEstado.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objCrep, "lblDivision", Me.cmbDivision.DivisionDescripcion)
        HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", Me.cmbPlanta.DescripcionPlanta)
        HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
        If Me.ckbRangoFechas.Checked Then
            HelpClass.CrystalReportTextObject(objCrep, "lblFiltro", Me.dtpFechaInicio.Value.ToShortDateString & " AL " & Me.dtpFechaFin.Value.ToShortDateString)
        End If
        objCrep.SetDataSource(objDs)
        objPrintForm.ShowForm(objCrep, Me)
    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged

        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
        Me.KryptonCheckBox1.Enabled = ckbRangoFechas.Checked
        Me.KryptonCheckBox1.Checked = False 'ckbRangoFechas.Checked

    End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        If Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If e.KeyCode = Keys.F8 Then
            mnuCopiar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
                Me.Limpiar_Controles()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnImprimirDetalleSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDetalleSolicitud.Click
        Try
            'Dim ListaParametros As New List(Of String)
            Dim ListaParametros As New Hashtable
            If Me.gwdDatos.Rows.Count > 0 Then
                If Me.gwdDatos.CurrentRow IsNot Nothing Then
                    'If Me.gwdDatos.CurrentRow.Selected = True Then
                    'ListaParametros.Add(Me.gwdDatos.Item("NCSOTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString)
                    'ListaParametros.Add("")
                    'ListaParametros.Add("")
                    'ListaParametros.Add("")
                    'ListaParametros.Add("")
                    'ListaParametros.Add(Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim)
                    'ListaParametros.Add(Me.cmbDivision.Division.ToString.Trim)
                    'ListaParametros.Add(Me.cmbPlanta.Planta.ToString.Trim)

                    ListaParametros("PNNCSOTR") = Me.gwdDatos.Item("NCSOTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
                    ListaParametros("PNCCLNT") = ""
                    ListaParametros("PSSESSLC") = ""
                    ListaParametros("PNCMEDTR") = ""
                    ListaParametros("PNFECINI") = ""
                    ListaParametros("PNFECFIN") = ""
                    ListaParametros("PSCCMPN") = cmbCompania.CCMPN_CodigoCompania.ToString.Trim
                    ListaParametros("PSCDVSN") = cmbDivision.Division.ToString.Trim
                    ListaParametros("PNCPLNDV") = Me.cmbPlanta.Planta.ToString.Trim


                    Dim objRep As New Solicitud_Transporte_BLL
                    Dim objCrep As New rptSolicitudTransp_RecursosAsignados

                    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
                    Dim objReporteSolicitudAsignada As New rptSolicitudAsignada

                    Dim objDt As DataTable
                    Dim objDs As New DataSet
                    Dim objPrintForm As New PrintForm
                    objDt = objRep.Lista_Solicitudes_Transporte(ListaParametros)
                    objDt.TableName = "RZST07"
                    objDs.Tables.Add(objDt.Copy)
                    objDt = objRep.Listar_Solicitudes_Vehiculo(ListaParametros)
                    objDt.TableName = "RZST071"
                    objDs.Tables.Add(objDt.Copy)

                    'HelpClass.CrystalReportTextObject(objCrep, "lblEstado", Me.ddlEstado.Text)
                    HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
                    HelpClass.CrystalReportTextObject(objCrep, "lblDivision", Me.cmbDivision.DivisionDescripcion)
                    HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", Me.cmbPlanta.DescripcionPlanta)
                    HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
                    Dim objEntidad As New ClaseGeneral
                    objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()

                    objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
                    'Subreporte Recursos Asignados
                    Dim dtbRecursosAsignados As DataTable = HelpClass.GetDataSetNative(objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad))

                    If dtbRecursosAsignados.Rows.Count > 0 Then
                        objCrep.OpenSubreport("rptSolicitudAsignada.rpt").SetDataSource(dtbRecursosAsignados)
                    End If

                    objCrep.SetDataSource(objDs)
                    objPrintForm.ShowForm(objCrep, Me)

                    objCrep.Close()
                    objCrep.Dispose()

                End If
            End If
        Catch : End Try
    End Sub

    Private Sub mnuCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopiar.Click
        If Me.gwdDatos.RowCount > 0 Then
            If Me.gwdDatos.CurrentRow.Selected = True Then
                _estado = 1
                Me.Nuevo_Registro()
                Me.AccionCancelar()
            End If
        End If
    End Sub

    Private Sub dtgRecursosAsignados_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRecursosAsignados.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            Dim hash As New Hashtable()
            hash("CCMPN") = cmbCompania.CCMPN_CodigoCompania.ToString()
            Select Case e.ColumnIndex
                Case 1
                    If Me.dtgRecursosAsignados.Item("GPSLON", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value.ToString <> "" Then
                        Dim objGpsBrowser As New frmMapa
                        With objGpsBrowser
                            .Latitud = Me.dtgRecursosAsignados.Item("GPSLAT", e.RowIndex).Value
                            .Longitud = Me.dtgRecursosAsignados.Item("GPSLON", e.RowIndex).Value
                            .Fecha = Me.dtgRecursosAsignados.Item("FECGPS", e.RowIndex).Value
                            .Hora = Me.dtgRecursosAsignados.Item("HORGPS", e.RowIndex).Value.ToString.Trim
                            .WindowState = FormWindowState.Maximized
                            .ShowForm(.Latitud, .Longitud, Me)
                        End With
                    End If
                Case 7
                    Informacion_Detallada_Transportista(1, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
                Case 8
                    Informacion_Detallada_Transportista(2, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
                Case 9
                    Informacion_Detallada_Transportista(3, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
                Case 25
                    If dtgRecursosAsignados.Item(25, e.RowIndex).Value.ToString = "Enviar SAP" Then
                        Enviar_Orden_Interna_SAP()
                    End If
                Case 27
                    Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
                    Dim obj_Entidad As New Detalle_Solicitud_Transporte
                    Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
                    Dim lstr_Estado As String = ""

                    obj_Entidad.NCSOTR = Me.dtgRecursosAsignados.Item(2, lint_indice).Value
                    obj_Entidad.NCRRSR = Me.dtgRecursosAsignados.Item(3, lint_indice).Value
                    obj_Entidad.NPLNJT = Me.dtgRecursosAsignados.Item(4, lint_indice).Value
                    obj_Entidad.NCRRPL = Me.dtgRecursosAsignados.Item(5, lint_indice).Value
                    obj_Entidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania

                    obj_Entidad = obj_LogicaDetalleSolcitud.Validar_Existencias_PAG(obj_Entidad)

                    If obj_Entidad.NGUITR <> "0" Then
                        lstr_Estado += Chr(13) + " GUIA TRANSPORTISTA         :" + obj_Entidad.NGUITR
                        If obj_Entidad.NCTAVC <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 1         :" + obj_Entidad.NCTAVC
                        If obj_Entidad.NCSLPE <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 1 :" + obj_Entidad.NCSLPE
                        If obj_Entidad.NCTAV2 <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 2         :" + obj_Entidad.NCTAV2
                        If obj_Entidad.NCSLP2 <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 2 :" + obj_Entidad.NCSLP2
                        lstr_Estado = "NO SE PUEDE MODIFICAR POR QUE TIENE ASIGNADO : " + Chr(13) + lstr_Estado
                        HelpClass.MsgBox(lstr_Estado)
                        Exit Sub
                    End If

                    obj_Entidad.NRUCTR = Me.dtgRecursosAsignados.Item(6, lint_indice).Value '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
                    obj_Entidad.NPLCUN = Me.dtgRecursosAsignados.Item(7, lint_indice).Value '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
                    obj_Entidad.NPLCAC = Me.dtgRecursosAsignados.Item(8, lint_indice).Value '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
                    obj_Entidad.CBRCNT = Me.dtgRecursosAsignados.Item(9, lint_indice).Value '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
                    obj_Entidad.CBRCN2 = Me.dtgRecursosAsignados.Item(24, lint_indice).Value '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value

                    Dim frmReasignarRecurso As New frmReasignarRecurso
                    frmReasignarRecurso.IsMdiContainer = True
                    With frmReasignarRecurso
                        ._obj_Entidad = obj_Entidad
                        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        .CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                        .CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
                        If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub

                        Me.dtgRecursosAsignados.Item(7, lint_indice).Value = .ctbTracto.pNroPlacaUnidad
                        Me.dtgRecursosAsignados.Item(8, lint_indice).Value = .ctbAcoplado.pNroAcoplado
                        Me.dtgRecursosAsignados.Item(9, lint_indice).Value = .cmbConductor.pBrevete
                        Me.dtgRecursosAsignados.Item(10, lint_indice).Value = .cmbConductor.pNombreChofer
                        Me.dtgRecursosAsignados.Item(24, lint_indice).Value = .cmbSegundoConductor.pBrevete

                    End With
            End Select
        Catch : End Try
    End Sub

    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click
        If txtCliente.pCodigo = 0 Then
            MsgBox("Debe de seleccionar el cliente para buscar las ordenes de servicio relacionadas")
            Exit Sub
        End If
        gintEstado = 0

        Dim objSolicitudLogica As New SOLMIN_ST.NEGOCIO.Operaciones.Solicitud_Transporte_BLL
        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Unidades_Asignadas(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.ErrorMsgBox()
                Exit Sub
            Case Is > 0
                HelpClass.MsgBox("No se puede cambiar la O/S porque cuenta con unidades asignadas")
                Exit Sub
        End Select

        objFormBuscarOrdenServicio = New frmBuscarOrdenServicio
        With objFormBuscarOrdenServicio
            gintEstado = -1
            .MdiParent = Me.Parent.Parent
            .CodigoCliente = txtCliente.pCodigo
            .CCMPN = cmbCompania.CCMPN_CodigoCompania.ToString().Trim()
            .CDVSN = cmbDivision.Division
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub LimpiarDatosGenerales()
        'ctlLocalidadOrigen.Limpiar()
        'ctlLocalidadDestino.Limpiar()
        'txtUbigeoOrigen.Limpiar()
        'txtUbigeoDestino.Limpiar()
        'txtOrdenServicio.Text = ""
        txtTipoServicio.Limpiar()
        ctbMercaderias.Limpiar()
        txtUnidadMedida.Limpiar()
        txtCantidadMercaderia.Text = ""

        txtUbigeoOrigen1.Text = ""
        txtUbigeoOrigen1.Tag = 0
        txtUbigeoDestino1.Text = ""
        txtUbigeoDestino1.Tag = 0

        txtLocalidadCarga1.Text = ""
        txtLocalidadCarga1.Tag = 0
        txtLocalidadEntrega1.Text = ""
        txtLocalidadEntrega1.Tag = 0

    End Sub

    Private Function Validar_Recursos_Asignados(ByVal lint_indice As Integer) As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        'Evaluando la Asignación: Tracto, Acoplado y Conductor
        If Me.dtgRecursosAsignados.Item(7, lint_indice).Value.ToString = "" Then
            lstr_validacion += "* TRACTO" & Chr(13)
        End If
        'If Me.dtgRecursosAsignados.Item(8, lint_indice).Value.ToString = "" Then
        '    lstr_validacion += "* ACOPLADO" & Chr(13)
        'End If
        Select Case Me.cboMedioTransporte.SelectedValue
            Case 4
                If Me.dtgRecursosAsignados.Item(9, lint_indice).Value.ToString = "" Then
                    lstr_validacion += "* CONDUCTOR" & Chr(13)
                End If
        End Select

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSADI = "" Then
            Me.btnNuevo.Visible = False
            Me.Separator1.Visible = False
        End If
        If objEntidad.STSCHG = "" Then
            Me.btnGuardar.Visible = False
            Me.Separator2.Visible = False
        End If
        If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
            Me.btnCancelar.Visible = False
            Me.Separator3.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False

            Me.Separator4.Visible = False
        End If
        If objEntidad.STSVIS = "" Then
            Me.btnAnularOperacion.Visible = False
            Me.Separator9.Visible = False
        End If
        If objEntidad.STSOP2 = "" Then
            Me.btnServicioAlmacen.Visible = False
            Me.Separator6.Visible = False
        End If
        If objEntidad.STSOP1 = "" Then
            Me.btnAsignacionManual.Visible = False
            Me.Separator5.Visible = False
        End If
        If objEntidad.STSOP3 = "" Then
            Me.btnAdjuntarDocumentos.Visible = False
            Me.btnAsignacionManual_1.Visible = False
            Me.Separator7.Visible = False

        Else
            If objEntidad.STSOP1 = "X" Then
                Me.btnAsignacionManual.Visible = False
                Me.Separator5.Visible = False
            End If
        End If
    End Sub

    Private Sub btnServicioAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicioAlmacen.Click
        Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
        Dim frm_frmServicioAlmacen As New frmServicioAlmacen

        If Me.dtgRecursosAsignados.RowCount = 0 Then Exit Sub
        If Me.dtgRecursosAsignados.CurrentRow.Selected = False Then Exit Sub
        If Validar_Recursos_Asignados(lint_indice) = True Then Exit Sub
        If Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value = 0 Then
            HelpClass.MsgBox("No tiene una Operación asignada")
            Exit Sub
        End If
        If Me.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value <> 0 Then
            HelpClass.MsgBox("Ya tiene una Guía de Transporte")
            Exit Sub
        End If
        Dim objSolicitudLogica As New Solicitud_Transporte_BLL
        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select

        frm_frmServicioAlmacen.IsMdiContainer = True
        Try
            With frm_frmServicioAlmacen
                .txtFechaSolicitud.Text = Me.txtFechaSolicitud.Text
                .txtFechaAsignacion.Text = Me.dtgRecursosAsignados.Item(11, lint_indice).Value
                .Tag = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
                ._NOPRCN = Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
                ._NCSOTR = Me.dtgRecursosAsignados.Item("NCSOT", lint_indice).Value
                ._NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value
                ._NPLNJT = Me.dtgRecursosAsignados.Item("NPLNJT", lint_indice).Value
                ._NCRRPL = Me.dtgRecursosAsignados.Item("NCRRPL", lint_indice).Value
                ._CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
                .Estado = Me.cboMedioTransporte.SelectedValue
                .ProcesoEjecutar = 0
                If txtLocalidadCarga1.Tag.ToString.Trim = "" Then
                    .ObjetoServicio_Entidad_Guia.CLCLOR = 0
                Else
                    .ObjetoServicio_Entidad_Guia.CLCLOR = CType(txtLocalidadCarga1.Tag, Double)
                End If
                If txtLocalidadEntrega1.Tag.ToString.Trim = "" Then
                    .ObjetoServicio_Entidad_Guia.CLCLDS = 0
                Else
                    .ObjetoServicio_Entidad_Guia.CLCLDS = CType(txtLocalidadEntrega1.Tag, Double)
                End If
                .ObjetoServicio_Entidad_Guia.TDIROR = Me.txtDireccionLocalidadCarga.Text
                .ObjetoServicio_Entidad_Guia.TDIRDS = Me.txtDireccionLocalidadEntrega.Text
                .ObjetoServicio_Entidad_Guia.QMRCMC = IIf(Me.txtCantidadMercaderia.Text = "", 0, CType(Me.txtCantidadMercaderia.Text, Double))
                .ObjetoServicio_Entidad_Guia.CUNDMD = Me.txtUnidadMedida.Codigo
                .ObjetoServicio_Entidad_Guia.NRUCTR = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
                .ObjetoServicio_Entidad_Guia.NPLCTR = Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
                .ObjetoServicio_Entidad_Guia.NPLCAC = Me.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
                .ObjetoServicio_Entidad_Guia.CBRCNT = Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
                .ObjetoServicio_Entidad_Guia.CBRCND = Me.dtgRecursosAsignados.Item("CBRCND", lint_indice).Value

                .ObjetoServicio_Entidad_Guia.CMEDTR = Me.cboMedioTransporte.SelectedValue
                .ObjetoServicio_Entidad_Guia.CTPOVJ = _CTPOVJ

                Dim obj_Logica_Guia As New GuiaTransportista_BLL
                Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
                obj_Entidad_Guia_Transporte.NOPRCN = ._NOPRCN
                obj_Entidad_Guia_Transporte.CCMPN = cmbCompania.CCMPN_CodigoCompania.ToString.Trim
                obj_Entidad_Guia_Transporte.NPLCTR = .ObjetoServicio_Entidad_Guia.NPLCTR

                obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
                .ObjetoServicio_Entidad_Guia.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
                .ObjetoServicio_Entidad_Guia.QKMREC = obj_Entidad_Guia_Transporte.QKMREC

                .ObjetoServicio_Entidad_Guia.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM
                .ObjetoServicio_Entidad_Guia.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
                .ObjetoServicio_Entidad_Guia.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
                .ObjetoServicio_Entidad_Guia.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
                .ObjetoServicio_Entidad_Guia.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
                .ObjetoServicio_Entidad_Guia.TDRCNS = .ObjetoServicio_Entidad_Guia.TDIRDS
                .ObjetoServicio_Entidad_Guia.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR
                .ObjetoServicio_Entidad_Guia.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
                .ObjetoServicio_Entidad_Guia.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
                .ObjetoServicio_Entidad_Guia.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
                .ObjetoServicio_Entidad_Guia.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                .ObjetoServicio_Entidad_Guia.CDVSN = Me.cmbDivision.Division
                .ObjetoServicio_Entidad_Guia.CPLNDV = Me.cmbPlanta.Planta

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'Me.Listar()
                    Dim NCOREG As String = ""
                    Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
                    obeSeguimientoGPS.NPLCTR = Me.dtgRecursosAsignados.CurrentRow.Cells("NPLCUN").Value
                    obeSeguimientoGPS.NCSOTR = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.CurrentRow.Cells("NCSOT").Value)
                    obeSeguimientoGPS.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                    obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.CurrentRow.Cells("NCRRSR").Value)
                    obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(Me.dtgRecursosAsignados.CurrentRow.Cells("NGSGWP").Value)
                    obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.CurrentRow.Cells("NCOREG").Value)
                    Dim ofrmGPSWAP As New frmGPSWAP()
                    ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
                    ofrmGPSWAP.Estado = 1
                    ofrmGPSWAP.ShowDialog(Me)
                    Me.Cargar_Detalle_Solicitud()
                    Me.gwdDatos.Rows(Me.gwdDatos.CurrentCellAddress.Y).Selected = True
                End If
            End With

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLimpiarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtOrdenServicio.Text = ""
        'ctlLocalidadOrigen.Limpiar()
        'ctlLocalidadDestino.Limpiar()
        'txtUbigeoOrigen.Limpiar()
        'txtUbigeoDestino.Limpiar()

        Me.txtLocalidadEntrega1.Text = ""
        Me.txtLocalidadEntrega1.Tag = 0
        Me.txtLocalidadCarga1.Text = ""
        Me.txtLocalidadCarga1.Tag = 0

        Me.txtUbigeoOrigen1.Text = ""
        Me.txtUbigeoOrigen1.Tag = 0
        Me.txtUbigeoDestino1.Text = ""
        Me.txtUbigeoDestino1.Tag = 0

    End Sub

    Private Sub CambioEstadoTabSolicitudFlete()
        'Select Case Me.TabSolicitudFlete.SelectedIndex
        '    Case 0
        '        If Me.gwdDatos.CurrentCellAddress.Y = -1 Then
        '            Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "N")
        '        ElseIf Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "*" Or Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
        '            Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "C")
        '        Else
        '            Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "N")
        '        End If
        '    Case 1
        '        If Me.gwdDatos.CurrentCellAddress.Y = -1 Then
        '            Estado_Botones(True, TabSolicitudFlete.SelectedIndex, "N")

        '        ElseIf Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "*" Or Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
        '            Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "C")
        '        Else
        '            Estado_Botones(True, TabSolicitudFlete.SelectedIndex, "N")
        '        End If
        'End Select
        Dim NameTabSelected As String = TabSolicitudFlete.SelectedTab.Name
        Select Case NameTabSelected
            Case "tbInformacionGeneral"
                If Me.gwdDatos.CurrentCellAddress.Y = -1 Then
                    'Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "N")
                    Estado_Botones(False, TabSolicitudFlete.SelectedTab.Name, "N")
                ElseIf Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "*" Or Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
                    'Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "C")
                    Estado_Botones(False, TabSolicitudFlete.SelectedTab.Name, "C")
                Else
                    'Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "N")
                    Estado_Botones(False, TabSolicitudFlete.SelectedTab.Name, "N")
                End If
            Case "tbAsignacion"
                If Me.gwdDatos.CurrentCellAddress.Y = -1 Then
                    'Estado_Botones(True, TabSolicitudFlete.SelectedIndex, "N")
                    Estado_Botones(True, TabSolicitudFlete.SelectedTab.Name, "N")

                ElseIf Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "*" Or Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
                    'Estado_Botones(False, TabSolicitudFlete.SelectedIndex, "C")
                    Estado_Botones(False, TabSolicitudFlete.SelectedTab.Name, "C")
                Else
                    'Estado_Botones(True, TabSolicitudFlete.SelectedIndex, "N")
                    Estado_Botones(True, TabSolicitudFlete.SelectedTab.Name, "N")
                End If
        End Select
    End Sub

    Private Sub TabSolicitudFlete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabSolicitudFlete.SelectedIndexChanged
        CambioEstadoTabSolicitudFlete()

    End Sub

    Private Sub btnAdjuntarDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarDocumentos.Click
        'Dim ht As New Hashtable

        'If Me.dtgRecursosAsignados.Rows.Count = 0 Then Exit Sub
        'If Me.dtgRecursosAsignados.CurrentRow.Selected = False Then Exit Sub
        'If Me.dtgRecursosAsignados.Item("NGUITR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value <> 0 Then Exit Sub

        'Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y

        'ht.Add("NCSOTR", Me.dtgRecursosAsignados.Item(2, lint_indice).Value)
        'ht.Add("NCRRSR", Me.dtgRecursosAsignados.Item(3, lint_indice).Value)

        'Dim f As New frmDocumentosAdjuntos
        'f.cargarDatos(ht)
        'f.Show()
        Dim objSolicitudLogica As New Solicitud_Transporte_BLL
        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select
        '==========New============
        Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
        '============NUEVO =============
        Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumento
        With ofrmAdjuntarDocumento
            .docsAdjunto.CCMPN = cmbCompania.CCMPN_CodigoCompania
            .docsAdjunto.CDVSN = cmbDivision.Division
            .docsAdjunto.CPLNDV = cmbPlanta.Planta
            .docsAdjunto.CTRSPT = Me.dtgRecursosAsignados.Item("CTRSPT", lint_indice).Value
            .docsAdjunto.NGUITR = Me.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value
        End With
        If ofrmAdjuntarDocumento.ShowDialog() Then
        End If
    End Sub

    Private Sub txtCantidadSolicitada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadSolicitada.KeyPress, txtNroSolicitud.KeyPress, txtNroOperacion.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub CargarControles()
        Me.txtClienteFiltro.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Me.txtCliente.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        'Me.Cargar_Combos()
        '  Me.Listar()
        'Me.dtgRecursosAsignados.Rows.Clear()
    End Sub

    'Private Sub InicializarFormulario(ByVal bolCargarCombo As Boolean)

    '  If (bolCargarCombo = True) Then
    '    Me.Cargar_Combos()
    '  End If
    '  gwdDatos.DataSource = Nothing
    '  Me.dtgRecursosAsignados.Rows.Clear()
    '  gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '  Me.btnNuevo.Enabled = True
    '  Me.btnGuardar.Enabled = False
    '  Me.btnCancelar.Enabled = False
    '  Me.btnEliminar.Enabled = False
    '  Me.ckbRangoFechas.Checked = False
    '  Me.Limpiar_Controles()
    '  Me.txtCantidadMercaderia.TextValidationType = ValidationInputType.Numeric
    '  Me.txtCantidadSolicitada.TextValidationType = ValidationInputType.Numeric
    '  Me.ctlLocalidadDestino.Enabled = False
    '  Me.ctlLocalidadOrigen.Enabled = False
    '  Estado_Controles(False)
    '  Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    '  gintEstado = 0

    '  txtClienteFiltro.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    '  txtCliente.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania

    'End Sub

    Private Sub Carga_TipoSolicitud()
        Me.cmbTipoSolicitud.DataSource = TipoSolicitud()
        Me.cmbTipoSolicitud.ValueMember = "COD"
        Me.cmbTipoSolicitud.DisplayMember = "NOM"
    End Sub

    Private Sub Carga_TipoPrioridad()
        Me.ddlPrioridad.DataSource = TipoPrioridad()
        Me.ddlPrioridad.ValueMember = "COD"
        Me.ddlPrioridad.DisplayMember = "NOM"

        Me.cboPrioridadFiltro.DataSource = TipoPrioridadFiltro()
        Me.cboPrioridadFiltro.ValueMember = "COD"
        Me.cboPrioridadFiltro.DisplayMember = "NOM"

    End Sub

    Private Sub Carga_Usuario()
        ckbUsuarioCreador.Checked = False
        cmbUsuarioCreador.Enabled = False
    End Sub

    Private Function TipoSolicitud()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")

        Dim oDr As DataRow

        oDr = oDt.NewRow
        oDr.Item(0) = "I"
        oDr.Item(1) = "Ida"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "R"
        oDr.Item(1) = "Retorno"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "V"
        oDr.Item(1) = "Ida y Vuelta"
        oDt.Rows.Add(oDr)

        Return oDt

    End Function

    Private Function TipoPrioridadFiltro()
        Dim oDt As New DataTable
        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")
        Dim oDr As DataRow
        oDr = oDt.NewRow
        oDr.Item(0) = "T"
        oDr.Item(1) = "TODOS"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item(0) = "N"
        oDr.Item(1) = "NORMAL"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item(0) = "U"
        oDr.Item(1) = "URGENTE"
        oDt.Rows.Add(oDr)
        Return oDt

    End Function


    Private Function TipoPrioridad()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")
        Dim oDr As DataRow
        oDr = oDt.NewRow
        oDr.Item(0) = "N"
        oDr.Item(1) = "NORMAL"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item(0) = "U"
        oDr.Item(1) = "URGENTE"
        oDt.Rows.Add(oDr)
        Return oDt

    End Function

    Private Sub btnAuditoria1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria1.Click
        If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim NrSol As String = Me.gwdDatos.CurrentRow.Cells("NCSOTR").Value
        Auditoria(NrSol)
    End Sub

    Private Sub Auditoria(ByVal pdblNroSolicitud As String)
        If pdblNroSolicitud.Trim.Length = 0 OrElse pdblNroSolicitud = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        Dim objLogica As New Solicitud_Transporte_BLL
        Dim objEntidad As New Solicitud_Transporte
        objEntidad.NCSOTR = pdblNroSolicitud
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        objEntidad = objLogica.Auditoria(objEntidad)
        Dim objfrmAuditoria As New frmAuditoria
        objfrmAuditoria.USUARIO_CREACION = objEntidad.CUSCRT
        objfrmAuditoria.FECHA_CREACION = objEntidad.FCHCRT
        objfrmAuditoria.HORA_CREACION = objEntidad.HRACRT
        objfrmAuditoria.TERMINAL_CREACION = objEntidad.NTRMCR
        objfrmAuditoria.USUARIO_ACTUALIZACION = objEntidad.CULUSA
        objfrmAuditoria.FECHA_ACTUALIZACION = objEntidad.FULTAC
        objfrmAuditoria.HORA_ACTUALIZACION = objEntidad.HULTAC
        objfrmAuditoria.TERMINAL_ACTUALIZACION = objEntidad.NTRMNL
        objfrmAuditoria.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnAsignacionManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignacionManual.Click
        Dim objSolicitudLogica As New Solicitud_Transporte_BLL
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        If Me.gwdDatos.RowCount = 0 OrElse lint_Indice < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        If CType(Me.gwdDatos.Item("QATNAN", lint_Indice).Value, Integer) >= CType(Me.gwdDatos.Item("QSLCIT", lint_Indice).Value, Integer) Then Exit Sub
        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select


        Try
            'Dim frm_frmAsignacionManual As New frmAsignacionManual(False)
            Dim frm_frmAsignacionManual As New frmAsignacionManual()
            With frm_frmAsignacionManual
                .obj_Entidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", lint_Indice).Value
                .obj_Entidad.NCRRSR = 1
                .obj_Entidad.NORSRT = Me.gwdDatos.Item("NORSRT", lint_Indice).Value
                .obj_Entidad.CCLNT = Me.txtCliente.pCodigo
                .obj_Entidad.CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
                .obj_Entidad.CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
                .obj_Entidad.CTPOVJ = Me._CTPOVJ
                .obj_Entidad.CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value
                .CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
                .CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
                .CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value
                .CLCLOR = Me.gwdDatos.Item("CLCLOR_C", lint_Indice).Value 'origen - string
                .CLCLDS = Me.gwdDatos.Item("CLCLDS_C", lint_Indice).Value 'destino - string
                .MedioTransporte = Me.cboMedioTransporte.SelectedValue
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                Me.gwdDatos.Item("QATNAN", lint_Indice).Value = Me.gwdDatos.Item("QATNAN", lint_Indice).Value + 1
                If CType(Me.gwdDatos.Item("QATNAN", lint_Indice).Value, Int64) >= CType(Me.gwdDatos.Item("QSLCIT", lint_Indice).Value, Int64) Then
                    Me.Listar()
                    Me.Limpiar_Detalle_Solicitud()
                Else
                    Me.Cargar_Detalle_Solicitud()
                End If

            End With
        Catch : End Try
    End Sub

    Private Sub btnAsignacionManual_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignacionManual_1.Click
        Dim objSolicitudLogica As New Solicitud_Transporte_BLL
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        If Me.gwdDatos.RowCount = 0 OrElse lint_Indice < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        If CType(Me.gwdDatos.Item("QATNAN", lint_Indice).Value, Integer) >= CType(Me.gwdDatos.Item("QSLCIT", lint_Indice).Value, Integer) Then Exit Sub
        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select
        Try
            'Dim frm_frmAsignacionManual As New frmAsignacionManual(1)
            Dim frm_frmAsignacionManual As New frmAsignacionManual()
            With frm_frmAsignacionManual
                .obj_Entidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", lint_Indice).Value
                .obj_Entidad.NCRRSR = 1
                .obj_Entidad.NORSRT = Me.gwdDatos.Item("NORSRT", lint_Indice).Value
                .obj_Entidad.CCLNT = Me.txtCliente.pCodigo
                .obj_Entidad.CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
                .obj_Entidad.CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
                .obj_Entidad.CTPOVJ = Me._CTPOVJ
                .obj_Entidad.CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value
                .CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
                .CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
                .CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value
                .MedioTransporte = Me.cboMedioTransporte.SelectedValue
                .CLCLOR = Me.gwdDatos.Item("CLCLOR_C", lint_Indice).Value 'origen - string
                .CLCLDS = Me.gwdDatos.Item("CLCLDS_C", lint_Indice).Value 'destino - string
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                Me.gwdDatos.Item("QATNAN", lint_Indice).Value = Me.gwdDatos.Item("QATNAN", lint_Indice).Value + 1
                If CType(Me.gwdDatos.Item("QATNAN", lint_Indice).Value, Int64) >= CType(Me.gwdDatos.Item("QSLCIT", lint_Indice).Value, Int64) Then
                    Me.Listar()
                    Me.Limpiar_Detalle_Solicitud()
                Else
                    Me.Cargar_Detalle_Solicitud()
                End If

            End With
        Catch : End Try
    End Sub

    'Private Sub btnNuevoOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    NuevoOS()
    'End Sub

    'Private Sub NuevoOS()
    '    If txtCliente.pCodigo = 0 Then
    '        MsgBox("Debe de seleccionar el cliente para crear orden de servicio")
    '        Exit Sub
    '    End If
    '    Dim ofrmNewOs As New frmCrearOsManual
    '    With ofrmNewOs
    '        .obeCotizacion.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    '        .obeCotizacion.CDVSN = Me.cmbDivision.Division
    '        .obeCotizacion.CPLNDV = Me.cmbPlanta.Planta

    '        .obeCotizacion.CCLNT = Me.txtCliente.pCodigo
    '        If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Dim oParametro As New List(Of String)
    '            Dim obeOrdenServicio As New OrdenServicioTransporte
    '            Dim olbeoblOrdenServicio As New List(Of OrdenServicioTransporte)
    '            txtOrdenServicio.Text = .NORSRT
    '            Dim oblOrdenServicio As New OrdenServicio_BLL

    '            oParametro.Add(.NORSRT.ToString)
    '            oParametro.Add(txtCliente.pCodigo.ToString)
    '            oParametro.Add(Me.cmbCompania.CCMPN_CodigoCompania)
    '            oParametro.Add(Me.cmbDivision.Division)
    '            oParametro.Add(cmbPlanta.Planta)
    '            olbeoblOrdenServicio = oblOrdenServicio.Listar_Ordenes_Servicio(oParametro)
    '            If olbeoblOrdenServicio.Count > 0 Then

    '                'ctlLocalidadOrigen.Codigo = olbeoblOrdenServicio.Item(0).PNTORG
    '                'ctlLocalidadDestino.Codigo = olbeoblOrdenServicio.Item(0).PNTDES

    '                txtLocalidadCarga1.Text = olbeoblOrdenServicio.Item(0).PNTORG
    '                txtLocalidadCarga1.Tag = olbeoblOrdenServicio.Item(0).CLCLOR

    '                txtLocalidadEntrega1.Text = olbeoblOrdenServicio.Item(0).PNTDES
    '                txtLocalidadEntrega1.Tag = olbeoblOrdenServicio.Item(0).CLCLDS

    '                txtOrdenServicio.Text = olbeoblOrdenServicio.Item(0).NORSRT
    '                txtTipoServicio.Codigo = olbeoblOrdenServicio.Item(0).TIPSRV
    '                ctbMercaderias.Codigo = olbeoblOrdenServicio.Item(0).CODMER
    '                txtUnidadMedida.Codigo = olbeoblOrdenServicio.Item(0).CUNDMD
    '                txtCantidadMercaderia.Text = olbeoblOrdenServicio.Item(0).QMRCDR
    '            End If

    '        End If
    '    End With
    'End Sub

    Private Sub tsmLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLimpiar.Click
        Me.txtOrdenServicio.Text = ""
        'ctlLocalidadOrigen.Limpiar()
        'ctlLocalidadDestino.Limpiar()
        'txtUbigeoOrigen.Limpiar()
        'txtUbigeoDestino.Limpiar()

        txtUbigeoOrigen1.Text = ""
        txtUbigeoOrigen1.Tag = 0
        txtUbigeoDestino1.Text = ""
        txtUbigeoDestino1.Tag = 0

        txtLocalidadEntrega1.Text = ""
        txtLocalidadEntrega1.Tag = 0
        txtLocalidadCarga1.Text = ""
        txtLocalidadCarga1.Tag = 0


    End Sub

    'Private Sub tsmNuevoOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNuevoOS.Click
    '    NuevoOS()
    'End Sub

    Private Sub txtNroSolicitud_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroSolicitud.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Me.txtNroSolicitud.Text.Trim.Equals("") Then Exit Sub
            Me.btnProcesarConsulta_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Enviar_Orden_Interna_SAP()
        Dim intIndice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
        If Me.dtgRecursosAsignados.Item("NOPRCN", intIndice).Value = 0 Then
            HelpClass.MsgBox("No Tiene Operación Asignada")
            Exit Sub
        End If
        If Me.dtgRecursosAsignados.Item("NORINS", intIndice).Value.ToString.Trim <> "Enviar SAP" Then
            HelpClass.MsgBox("La Operación tiene Orden Interna Asignada N° " & _
            Me.dtgRecursosAsignados.Item("NORINS", intIndice).Value.ToString)
            Exit Sub
        End If
        If HelpClass.RspMsgBox("Desea generar la Orden Interna a la Operación de Transporte Nro " & _
           Me.dtgRecursosAsignados.Item("NOPRCN", intIndice).Value & " ?") = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Generar_Orden_Interna(intIndice)
    End Sub

    Private Sub Generar_Orden_Interna(ByVal intIndice As Integer)
        If Me.dtgRecursosAsignados.CurrentRow Is Nothing OrElse intIndice < 0 Then
            Exit Sub
        End If
        Dim objFila As DataGridViewRow = Me.dtgRecursosAsignados.CurrentRow
        Dim objBLL As New Solicitud_Transporte_BLL
        Dim msgValidacion As String = objBLL.Valida_OrdenInterna_CentroCosto(CDec(objFila.Cells("NOPRCN").Value))
        msgValidacion = msgValidacion.Trim
        If msgValidacion.Length > 0 Then
            MessageBox.Show("La orden Interna no puede ser generada." & Chr(10) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim objOrdenInterna As New OrdenInterna_BLL
        Dim objEntidad As New Planeamiento
        Dim objParametros As New List(Of String)
        'fila Seleccionada de la grilla
        'Dim objFila As DataGridViewRow = Me.dtgRecursosAsignados.CurrentRow
        'Llenando el parametros de valores
        objParametros.Add(objFila.Cells("NOPRCN").Value.ToString())
        objParametros.Add(MainModule.USUARIO)
        objParametros.Add(HelpClass.TodayNumeric)
        objParametros.Add(HelpClass.NowNumeric)
        objParametros.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
        objParametros.Add(objFila.Cells("NPLCUN").Value.ToString())
        objParametros.Add(objFila.Cells("NPLCAC").Value.ToString())
        objParametros.Add(objFila.Cells("CBRCNT").Value.ToString())
        objParametros.Add(Me.cmbCompania.CCMPN_CodigoCompania)
        'objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)

        If objEntidad.NORINS > 0 Then
            HelpClass.MsgBox("Orden Interna N° " + CStr(objEntidad.NORINS) + " se envió al SAP satisfactoriamente")
            Me.dtgRecursosAsignados.Item("NORINS", intIndice).Value = objEntidad.NORINS
            Me.dtgRecursosAsignados.Item("NORINS", intIndice).Style.ForeColor = Color.Black
        Else
            HelpClass.MsgBox("Ocurrió un error en el envió al SAP")
        End If
        'Imprimiendo el numero de orden interna

    End Sub

    'Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar

    '    cmbDivision.Usuario = MainModule.USUARIO
    '    cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
    '    cmbDivision.DivisionDefault = "T"
    '    cmbDivision.pActualizar()
    '    Me.CargarControles()
    '    If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
    '        Me.gwdDatos.DataSource = Nothing
    '        Me.dtgRecursosAsignados.Rows.Clear()
    '        Me.Limpiar()
    '        Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
    '    End If

    'End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        cmbDivision.Usuario = MainModule.USUARIO
        cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
        If obeCompania.CCMPN_CodigoCompania = "EZ" Then
            cmbDivision.DivisionDefault = "T"
        End If
        cmbDivision.pActualizar()
        Me.CargarControles()
        'If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
        Me.gwdDatos.DataSource = Nothing
        Me.dtgRecursosAsignados.Rows.Clear()
        Me.Limpiar()
        Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
        'End If
        cmbDivision_Seleccionar(Nothing)
    End Sub


    'Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
    '    Me.cmbPlanta.Usuario = MainModule.USUARIO
    '    Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
    '    Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
    '    Me.cmbPlanta.PlantaDefault = 1
    '    If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
    '        Me.cmbPlanta.pActualizar()
    '    End If
    'End Sub
    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Me.cmbPlanta.Usuario = MainModule.USUARIO
        'Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        'Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        Me.cmbPlanta.CodigoCompania = cmbDivision.Compania
        Me.cmbPlanta.CodigoDivision = cmbDivision.Division
        Me.cmbPlanta.PlantaDefault = 1
        'If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
        Me.cmbPlanta.pActualizar()
        'End If
    End Sub

    Private Sub Limpiar()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnEliminar.Enabled = False
        'Me.ctlLocalidadDestino.Enabled = False
        'Me.ctlLocalidadOrigen.Enabled = False
        Me.Limpiar_Controles()
        'If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
        Me.Cargar_Combos()
        Me.Carga_MedioTransporte()
        'End If
        Me.Estado_Controles(False)
        gintEstado = 0

    End Sub

    Private Sub btnSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguimiento.Click
        If (Me.dtgRecursosAsignados.Rows.Count = 0) OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim objSolicitudLogica As New Solicitud_Transporte_BLL
        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select
        Try
            Dim vNPLCUN As String = ""
            Dim NCSOTR As Decimal = 0
            Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
            vNPLCUN = dtgRecursosAsignados.CurrentRow.Cells("NPLCUN").Value
            NCSOTR = dtgRecursosAsignados.CurrentRow.Cells("NCSOT").Value
            obeSeguimientoGPS.NPLCTR = vNPLCUN
            obeSeguimientoGPS.NCSOTR = NCSOTR
            obeSeguimientoGPS.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(dtgRecursosAsignados.CurrentRow.Cells("NCRRSR").Value)
            obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(dtgRecursosAsignados.CurrentRow.Cells("NGSGWP").Value)
            obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(dtgRecursosAsignados.CurrentRow.Cells("NCOREG").Value)
            Dim ofrmGPSWAP As New frmGPSWAP()
            ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
            ofrmGPSWAP.ShowDialog(Me)
            Me.Cargar_Detalle_Solicitud()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAnularOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularOperacion.Click
        If (Me.dtgRecursosAsignados.Rows.Count = 0) OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim objLogica As New Solicitud_Transporte_BLL

        Dim lintStatus As Int32 = objLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select
        If Me.dtgRecursosAsignados.Item("NGUITR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value <> 0 Then
            HelpClass.MsgBox("Tiene asignada Guía de Transporte", MessageBoxIcon.Information)
            Exit Sub
        End If
        Try

            '=============Validamos esta de provisión de la operación
            Dim obeOrdenServicioTransporte As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
            With obeOrdenServicioTransporte
                .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                .CDVSN = Me.cmbDivision.Division
                .NLQDCN = 0
                .NOPRCN = Me.dtgRecursosAsignados.Item("NOPRCN", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
                .TIPO = 2
            End With
            If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub
            '=============Validamos esta de provisión de la operación


            Dim objEntidad As New Solicitud_Transporte
            objEntidad.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOT", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
            objEntidad.NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            Dim lstrList As List(Of String) = objLogica.Anulacion_Operacion_Transporte(objEntidad)
            HelpClass.MsgBox(lstrList(0), MessageBoxIcon.Information)
            If lstrList(1).Trim = "1" Then
                Me.gwdDatos.Item("QATNAN", Me.gwdDatos.CurrentCellAddress.Y).Value = CType(Me.gwdDatos.Item("QATNAN", Me.gwdDatos.CurrentCellAddress.Y).Value, Int32) - 1
                Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"
                Me.Cargar_Detalle_Solicitud()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function fblnValidarProvision(ByVal obeOrdenServicioTransporte) As Boolean
        '================verificamos si la liquidación esta provisionada
        Dim intResultado As Integer = 0
        Dim obrOrdenServicio As New SOLMIN_ST.NEGOCIO.Operaciones.OrdenServicio_BLL

        intResultado = obrOrdenServicio.intTieneProvision(obeOrdenServicioTransporte)
        Select Case intResultado
            Case -1
                HelpClass.ErrorMsgBox()
            Case 2
                If obrOrdenServicio.fblnUsuarioPermitidoRevertirProvision(MainModule.USUARIO) Then
                    If MsgBox("La Operación :" & obeOrdenServicioTransporte.NOPRCN & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Return True
                    End If
                Else
                    'Usuario No puede Generar un revisado o Eliminar la provisión
                    MsgBox("Usted no tiene  autorización para administrar la Operación :" & obeOrdenServicioTransporte.NOPRCN & " porque se encuentra provisionada.")
                    Return True
                End If
        End Select
        '=================verificamos si la liquidación esta provisionada
        Return False
    End Function

    Private Sub ckbUsuarioCreador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbUsuarioCreador.CheckedChanged
        If ckbUsuarioCreador.Checked = True Then
            cmbUsuarioCreador.pObtenerUsuario(MainModule.USUARIO.ToString.Trim)
            cmbUsuarioCreador.Enabled = True

        Else
            cmbUsuarioCreador.pClear()
            cmbUsuarioCreador.Enabled = False
        End If
    End Sub

    Private Sub btnCerrarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSolicitud.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim lintStatus As Int32 = objSolicitudTransporte.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub
            Case -3
                HelpClass.ErrorMsgBox()
                Exit Sub
        End Select
        'If Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value = "C" Then
        'MsgBox("La Solicitud de Transporte se encuentra cerrada", MsgBoxStyle.Information)
        'Else
        If MsgBox("Desea cerrar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Cerrar_Solicitud()
        'End If

    End Sub

    'Private Sub Estado_Botones(ByVal lbool_Estado As Boolean, ByVal Tab As Integer, ByVal Reg As Char)
    '    Select Case Tab
    '        Case 0
    '            Select Case Reg
    '                Case "N"
    '                    Me.btnCerrarSolicitud.Enabled = (Not lbool_Estado)
    '                    Me.btnServicioAlmacen.Enabled = lbool_Estado
    '                    Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual_1.Enabled = lbool_Estado
    '                    Me.btnSeguimiento.Enabled = lbool_Estado
    '                    Me.btnAnularOperacion.Enabled = False
    '                    If Not Me.btnCancelar.Enabled Then
    '                        If Not Me.btnGuardar.Enabled Then
    '                            Me.btnEliminar.Enabled = lbool_Estado
    '                        Else
    '                            Me.btnEliminar.Enabled = (Not lbool_Estado)
    '                        End If
    '                    Else
    '                        Me.btnEliminar.Enabled = (Not lbool_Estado)
    '                    End If
    '                Case "C"
    '                    Me.btnServicioAlmacen.Enabled = lbool_Estado
    '                    Me.btnEliminar.Enabled = lbool_Estado
    '                    Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual_1.Enabled = lbool_Estado
    '                    Me.btnSeguimiento.Enabled = lbool_Estado
    '                    Me.btnAnularOperacion.Enabled = lbool_Estado
    '                    Me.btnCerrarSolicitud.Enabled = lbool_Estado
    '            End Select

    '        Case 1
    '            Select Case Reg
    '                Case "N"
    '                    Me.btnServicioAlmacen.Enabled = lbool_Estado
    '                    Me.btnEliminar.Enabled = (Not lbool_Estado)
    '                    Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual_1.Enabled = lbool_Estado
    '                    Me.btnSeguimiento.Enabled = lbool_Estado
    '                    Me.btnAnularOperacion.Enabled = lbool_Estado
    '                    Me.btnCerrarSolicitud.Enabled = (Not lbool_Estado)
    '                Case "C"
    '                    Me.btnServicioAlmacen.Enabled = (Not lbool_Estado)
    '                    Me.btnEliminar.Enabled = lbool_Estado
    '                    Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual.Enabled = lbool_Estado
    '                    Me.btnAsignacionManual_1.Enabled = lbool_Estado
    '                    Me.btnCerrarSolicitud.Enabled = lbool_Estado
    '                    Me.btnSeguimiento.Enabled = (Not lbool_Estado)
    '                    Me.btnAnularOperacion.Enabled = (Not lbool_Estado)
    '            End Select

    '    End Select

    'End Sub

    Private Sub Estado_Botones(ByVal lbool_Estado As Boolean, ByVal Tab As String, ByVal Reg As Char)
        Select Case Tab
            Case "tbInformacionGeneral"
                Select Case Reg
                    Case "N"
                        Me.btnCerrarSolicitud.Enabled = (Not lbool_Estado)
                        Me.btnServicioAlmacen.Enabled = lbool_Estado
                        Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
                        Me.btnAsignacionManual.Enabled = lbool_Estado
                        Me.btnAsignacionManual_1.Enabled = lbool_Estado
                        Me.btnSeguimiento.Enabled = lbool_Estado
                        Me.btnAnularOperacion.Enabled = False
                        If Not Me.btnCancelar.Enabled Then
                            If Not Me.btnGuardar.Enabled Then
                                Me.btnEliminar.Enabled = lbool_Estado
                            Else
                                Me.btnEliminar.Enabled = (Not lbool_Estado)
                            End If
                        Else
                            Me.btnEliminar.Enabled = (Not lbool_Estado)
                        End If
                    Case "C"
                        Me.btnServicioAlmacen.Enabled = lbool_Estado
                        Me.btnEliminar.Enabled = lbool_Estado
                        Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
                        Me.btnAsignacionManual.Enabled = lbool_Estado
                        Me.btnAsignacionManual_1.Enabled = lbool_Estado
                        Me.btnSeguimiento.Enabled = lbool_Estado
                        Me.btnAnularOperacion.Enabled = lbool_Estado
                        Me.btnCerrarSolicitud.Enabled = lbool_Estado
                End Select

            Case "tbAsignacion"
                Select Case Reg
                    Case "N"
                        Me.btnServicioAlmacen.Enabled = lbool_Estado
                        Me.btnEliminar.Enabled = (Not lbool_Estado)
                        Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
                        Me.btnAsignacionManual.Enabled = lbool_Estado
                        Me.btnAsignacionManual_1.Enabled = lbool_Estado
                        Me.btnSeguimiento.Enabled = lbool_Estado
                        Me.btnAnularOperacion.Enabled = lbool_Estado
                        Me.btnCerrarSolicitud.Enabled = (Not lbool_Estado)
                    Case "C"
                        Me.btnServicioAlmacen.Enabled = (Not lbool_Estado)
                        Me.btnEliminar.Enabled = lbool_Estado
                        Me.btnAdjuntarDocumentos.Enabled = lbool_Estado
                        Me.btnAsignacionManual.Enabled = lbool_Estado
                        Me.btnAsignacionManual_1.Enabled = lbool_Estado
                        Me.btnCerrarSolicitud.Enabled = lbool_Estado
                        Me.btnSeguimiento.Enabled = (Not lbool_Estado)
                        Me.btnAnularOperacion.Enabled = (Not lbool_Estado)
                End Select

        End Select

    End Sub


    Private Sub KryptonCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonCheckBox1.CheckedChanged

        If ckbRangoFechas.Enabled = True Then
            Me.dtpHora_Ini.Enabled = KryptonCheckBox1.Checked
            Me.dtpHora_Ini.Value = Date.Parse("08:00:00")
            Me.dtpHora_Fin.Enabled = KryptonCheckBox1.Checked
            Me.dtpHora_Fin.Value = Date.Parse("18:00:00")
        End If

    End Sub

    Private Sub btnProgramadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProgramadas.Click

        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SOLICITUDES_PROGRAMADAS"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SOLICITUDES_PROGRAMADAS"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "LISTA DE SOLICITUDES DE TRANSPORTE - PROGRAMADAS"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objSolicitud As New Solicitud_Transporte
        Dim objParamList As New List(Of String)
        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        Dim lstr_HoraIni As Int32 = 0
        Dim lstr_HoraFin As Int32 = 0

        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        Else
            lstr_FecIni = 0
            lstr_FecFin = 0
        End If
        If KryptonCheckBox1.Checked = True Then
            lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
            lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
        Else
            lstr_HoraIni = 0
            lstr_HoraFin = 0
        End If

        If Me.txtNroSolicitud.Text.Trim.Equals("") Then
            objSolicitud.NCSOTR = 0
        Else
            objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim
        End If
        If txtClienteFiltro.pCodigo <> 0 Then
            objSolicitud.CCLNT = txtClienteFiltro.pCodigo
        Else
            objSolicitud.CCLNT = 0
        End If
        'If Me.txtNroOperacion.Text.Trim.Equals("") Then
        '    objSolicitud.NOPRCN = 0
        'Else
        '    objSolicitud.NOPRCN = Me.txtNroOperacion.Text.Trim
        'End If
        objSolicitud.SESSLC = Asignar_Valor()
        objSolicitud.SESTRG = Asignar_Valor_Estado()
        objSolicitud.FE_INI = lstr_FecIni
        objSolicitud.FE_FIN = lstr_FecFin
        objSolicitud.HR_INI = lstr_HoraIni
        objSolicitud.HR_FIN = lstr_HoraFin
        objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
        objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objSolicitud.CDVSN = Me.cmbDivision.Division
        objSolicitud.CPLNDV = Me.cmbPlanta.Planta
        If ckbUsuarioCreador.Checked = True Then
            objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
        Else
            objSolicitud.CUSCRT = ""
        End If
        'objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim
        If Me.cboPrioridadFiltro.SelectedValue = "T" Then
            objSolicitud.SPRSTR = ""
        Else
            objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue
        End If

        ODs.Tables.Add(objSolicitudTransporte.Listar_Solicitudes_Transporte_Export_Solicitudes_Programadas_Urgentes(objSolicitud).Copy)
        For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
                Case "Fecha Solicitud", "Hora Solicitud", "Fecha Carga", "Hora Carga", "Fecha Entrega", "Hora Entrega"
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)
                Case "Unidades Solicitadas", "Unidades Atendidas", "Cantidad", "Cantidades Programadas"
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                Case Else
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
            End Select
        Next

        HelpClass_NPOI.ExportExcelGenerico_V1(loEncabezados, ODs)

    End Sub

    Private Sub btnUrgentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUrgentes.Click

        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SOLICITUDES_URGENTES"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SOLICITUDES_URGENTES"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "LISTA DE SOLICITUDES DE TRANSPORTE - URGENTES"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objSolicitud As New Solicitud_Transporte
        Dim objParamList As New List(Of String)
        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        Dim lstr_HoraIni As Int32 = 0
        Dim lstr_HoraFin As Int32 = 0

        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        Else
            lstr_FecIni = 0
            lstr_FecFin = 0
        End If

        If KryptonCheckBox1.Checked = True Then
            lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
            lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
        Else
            lstr_HoraIni = 0
            lstr_HoraFin = 0
        End If

        If Me.txtNroSolicitud.Text.Trim.Equals("") Then
            objSolicitud.NCSOTR = 0
        Else
            objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim
        End If
        If txtClienteFiltro.pCodigo <> 0 Then
            objSolicitud.CCLNT = txtClienteFiltro.pCodigo
        Else
            objSolicitud.CCLNT = 0
        End If
        'If Me.txtNroOperacion.Text.Trim.Equals("") Then
        '    objSolicitud.NOPRCN = 0
        'Else
        '    objSolicitud.NOPRCN = Me.txtNroOperacion.Text.Trim
        'End If
        objSolicitud.SESSLC = Asignar_Valor()
        objSolicitud.SESTRG = Asignar_Valor_Estado()
        objSolicitud.FE_INI = lstr_FecIni
        objSolicitud.FE_FIN = lstr_FecFin
        objSolicitud.HR_INI = lstr_HoraIni
        objSolicitud.HR_FIN = lstr_HoraFin
        objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
        objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objSolicitud.CDVSN = Me.cmbDivision.Division
        objSolicitud.CPLNDV = Me.cmbPlanta.Planta
        If ckbUsuarioCreador.Checked = True Then
            objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
        Else
            objSolicitud.CUSCRT = ""
        End If

        'objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim
        objSolicitud.SPRSTR = "U"
        ODs.Tables.Add(objSolicitudTransporte.Listar_Solicitudes_Transporte_Export_Solicitudes_Programadas_Urgentes(objSolicitud).Copy)
        For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
                Case "Fecha Solicitud", "Hora Solicitud", "Fecha Carga", "Hora Carga", "Fecha Entrega", "Hora Entrega"
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)
                Case "Unidades Solicitadas", "Unidades Atendidas", "Cantidad", "Cantidades Programadas"
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                Case Else
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
            End Select
        Next
        HelpClass_NPOI.ExportExcelGenerico_V1(loEncabezados, ODs)

    End Sub

    Private Sub btnGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneral.Click
        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SOLICITUD_DE_TRANSPORTE"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SOLICITUD_TRANSPORTE"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "SOLICITUD DE TRANSPORTE - GENERAL"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objSolicitud As New Solicitud_Transporte
        Dim objParamList As New List(Of String)
        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        If Me.txtNroSolicitud.Text.Trim.Equals("") Then
            objSolicitud.NCSOTR = 0
        Else
            objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim
        End If
        If txtClienteFiltro.pCodigo <> 0 Then
            objSolicitud.CCLNT = txtClienteFiltro.pCodigo
        Else
            objSolicitud.CCLNT = 0
        End If
        If Me.txtNroOperacion.Text.Trim.Equals("") Then
            objSolicitud.NOPRCN = 0
        Else
            objSolicitud.NOPRCN = Me.txtNroOperacion.Text.Trim
        End If
        objSolicitud.SESSLC = Asignar_Valor()
        objSolicitud.SESTRG = Asignar_Valor_Estado()
        objSolicitud.FE_INI = lstr_FecIni
        objSolicitud.FE_FIN = lstr_FecFin
        objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
        objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objSolicitud.CDVSN = Me.cmbDivision.Division
        objSolicitud.CPLNDV = Me.cmbPlanta.Planta
        If ckbUsuarioCreador.Checked = True Then
            objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
        Else
            objSolicitud.CUSCRT = ""
        End If
        objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim
        objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue
        ODs.Tables.Add(objSolicitudTransporte.Listar_Solicitudes_Transporte_Export(objSolicitud).Copy)
        For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
                Case "Fecha Solicitud", "Hora Solicitud", "Fecha Carga", "Hora Carga", "Fecha Entrega", "Hora Entrega"
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)
                Case "Unidades Solicitadas", "Unidades  Atendidas", "Cantidad"
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                Case Else
                    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
            End Select
        Next
        HelpClass_NPOI.ExportExcelGenerico_V1(loEncabezados, ODs)
    End Sub

    Private Sub cmbUsuarioSolicitante_InformationChanged() Handles cmbUsuarioSolicitante.InformationChanged
        txtUsuarioSolicitante.Text = cmbUsuarioSolicitante.pPSMMNUSR.ToString.Trim
    End Sub
End Class

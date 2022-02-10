
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports System.Data

Public Class frmJuntaTransporteReq

    '#Region "Variables"
    'Private gEnum_Mantenimiento As MANTENIMIENTO
    'Private _strNPLNJT As String = ""
    'Private _strNCRRPL As String = ""
    'Private bolBuscar As Boolean
    '#End Region

#Region "Metodos y Funciones"
    'Enum TAB_SEL
    '    DATO_GENERAL
    '    PROG_UNIDAD
    '    ASIG_UNIDAD
    'End Enum

    'Private TabActualSeleccionado As Int32 = 0
    Private gEnumOpc As EnumMan = EnumMan.Neutro
    Enum EnumMan
        Neutro
        Nuevo
        Editar
    End Enum
    Private TabSeleccionado As String = ""

    'Const TabDatoGeneral As String = "tbInformacionGeneral"
    'Const TabAsignarUnidad As String = "tbInformacionJunta"
    'Const TabProgUnidad As String = "tabInfoUnidadProgramada"

    '   Case "tbInformacionGeneral" 'DATOS GENERALES
    ''Me.MenuBar.Enabled = True
    '            HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, TAB_SEL.DATO_GENERAL)
    '            Me.btnGenerarOperacion.Enabled = False
    '        Case "tabInfoUnidadProgramada"
    '            HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, TAB_SEL.PROG_UNIDAD)
    '        Case "tbInformacionJunta" 'UNIDADES ASIGNADAS

    Private Sub frmJuntaTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gwdDatos.AutoGenerateColumns = False
            dgvJuntaReq.AutoGenerateColumns = False
            'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
            'For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            '    Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Next
            Estado_Controles(False)
            ckbRangoFechas.Checked = False
            CargarFiltro()
            Limpiar_Controles()
            Validar_Acceso_Opciones_Usuario()
            Cargar_Compania()
            chkNumReq.Checked = False
            txtNroReqFiltro.Enabled = False
            HeaderDatos.ValuesPrimary.Heading = "Información de Junta Transportista"
            ' HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSolicitudFlete.SelectedTab.Name, Estado_Actual_Junta)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HabilitarOpcion(ByVal opc As EnumMan, ByVal tabActivo As String)
        Select Case tabActivo
            Case "tbInformacionGeneral"
                Select Case opc
                    Case EnumMan.Neutro

                        btnNuevo.Enabled = True

                        btnModificar.Enabled = True
                        btnGuardar.Visible = False
                        btnGuardar.Enabled = False

                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnAtender.Enabled = True
                        btnAsignacionUnidades.Enabled = False
                        btnProgramarUnidades.Enabled = False
                        btnImprimir.Enabled = True

                    Case EnumMan.Nuevo

                        btnNuevo.Enabled = False

                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnGuardar.Enabled = True
                        btnCancelar.Enabled = True
                        btnEliminar.Enabled = False
                        btnAtender.Enabled = False
                        btnAsignacionUnidades.Enabled = False
                        btnProgramarUnidades.Enabled = False
                        btnImprimir.Enabled = True

                    Case EnumMan.Editar

                        btnNuevo.Enabled = False

                        btnModificar.Enabled = True
                        btnGuardar.Visible = True
                        btnGuardar.Enabled = True
                        btnModificar.Enabled = False

                        btnCancelar.Enabled = True
                        btnEliminar.Enabled = False
                        btnAtender.Enabled = False
                        btnAsignacionUnidades.Enabled = False
                        btnProgramarUnidades.Enabled = False
                        btnImprimir.Enabled = True

                End Select
            Case "tbInformacionJunta"

                btnNuevo.Enabled = False
                btnGuardar.Visible = False
                btnGuardar.Enabled = True
                btnModificar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = False
                btnAtender.Enabled = True
                btnAsignacionUnidades.Enabled = False
                btnProgramarUnidades.Enabled = False
                btnImprimir.Enabled = True

            Case "tabInfoUnidadProgramada"


                btnNuevo.Enabled = False
                btnGuardar.Visible = False
                btnGuardar.Enabled = True
                btnModificar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = False
                btnAtender.Enabled = True
                btnAsignacionUnidades.Enabled = False
                btnProgramarUnidades.Enabled = False
                btnImprimir.Enabled = True


            Case "tbRequerimientos"


                btnNuevo.Enabled = False
                btnGuardar.Visible = False
                btnGuardar.Enabled = False
                btnModificar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = False
                btnAtender.Enabled = True
                btnAsignacionUnidades.Enabled = False
                btnProgramarUnidades.Enabled = False
                btnImprimir.Enabled = True


        End Select

    End Sub


    'Private Function Estado_Actual_Junta() As String
    '    Dim estadoActual As String = ""
    '    If gwdDatos.CurrentRow Is Nothing Then
    '        estadoActual = "P"
    '    Else
    '        estadoActual = gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
    '    End If
    '    Return estadoActual
    'End Function
    '     HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSolicitudFlete.SelectedTab.Name, Estado_Actual_Junta)

    'Private Sub HabilitarOpcionxEstadoJunta()
    '    Dim TabSelect As String = TabSolicitudFlete.SelectedTab.Name
    '    Dim Estado As String = ""
    '    If gwdDatos.Rows.Count > 0 Then
    '        Estado = ("" & gwdDatos.CurrentRow.Cells("SESREQ").Value).ToString.Trim
    '    End If
    '    Select Case Estado
    '        Case "C"
    '            btnNuevo.Enabled = False
    '            btnModificar.Enabled = False
    '            btnEliminar.Enabled = False
    '            btnAtender.Enabled = False
    '    End Select
    'End Sub

    Private Sub Estado_Controles(ByVal estado As Boolean)
        dtpFechaJunta.Enabled = estado
        txtHoraJunta.Enabled = estado
        txtResponsableJunta.Enabled = estado
        txtCantidadJunta.Enabled = estado
        txtDescripcionJunta.Enabled = estado
    End Sub


    'Private Sub HabilitarBotonOpcion(ByVal _Tipo As MANTENIMIENTO, ByVal _TAB As String, ByVal EstadoJunta As String)
    '    ' CUANDO LA JUNTA SE ENCUENTRE CERRADO 'C' LAS OPCIONES ESTARAN DESABILITADA CASO CONTRARIO SE HABILITAN 
    '    'DE ACUERDO AL TAB SELECCIONADO.
    '    Select Case _TAB
    '        Case TabDatoGeneral
    '            If EstadoJunta = "C" Then

    '                btnNuevo.Enabled = False

    '                btnModificar.Visible = True
    '                btnGuardar.Visible = False
    '                btnModificar.Enabled = False
    '                btnGuardar.Enabled = False

    '                btnCancelar.Enabled = False
    '                btnEliminar.Enabled = False
    '                btnAtender.Enabled = False
    '                btnAsignacionUnidades.Enabled = False
    '                btnProgramarUnidades.Enabled = False
    '                btnImprimir.Enabled = True

    '                dtpFechaJunta.Enabled = False
    '                txtHoraJunta.Enabled = False
    '                txtResponsableJunta.Enabled = False
    '                txtCantidadJunta.Enabled = False
    '                txtDescripcionJunta.Enabled = False

    '            Else
    '                Select Case _Tipo
    '                    Case MANTENIMIENTO.NEUTRAL
    '                        btnNuevo.Enabled = True

    '                        btnModificar.Visible = True
    '                        btnGuardar.Visible = False
    '                        btnModificar.Enabled = True
    '                        btnGuardar.Enabled = False


    '                        btnCancelar.Enabled = False
    '                        btnEliminar.Enabled = True
    '                        btnAtender.Enabled = True
    '                        btnAsignacionUnidades.Enabled = False
    '                        btnProgramarUnidades.Enabled = False
    '                        btnImprimir.Enabled = True

    '                        dtpFechaJunta.Enabled = False
    '                        txtHoraJunta.Enabled = False
    '                        txtResponsableJunta.Enabled = False
    '                        txtCantidadJunta.Enabled = False
    '                        txtDescripcionJunta.Enabled = False

    '                    Case MANTENIMIENTO.NUEVO
    '                        btnNuevo.Enabled = False

    '                        btnModificar.Visible = False
    '                        btnGuardar.Visible = True
    '                        btnModificar.Enabled = False
    '                        btnGuardar.Enabled = True

    '                        btnCancelar.Enabled = True
    '                        btnEliminar.Enabled = False
    '                        btnAtender.Enabled = False
    '                        btnAsignacionUnidades.Enabled = False
    '                        btnProgramarUnidades.Enabled = False
    '                        btnImprimir.Enabled = False

    '                        dtpFechaJunta.Enabled = True
    '                        txtHoraJunta.Enabled = True
    '                        txtResponsableJunta.Enabled = True
    '                        txtCantidadJunta.Enabled = True
    '                        txtDescripcionJunta.Enabled = True

    '                    Case MANTENIMIENTO.EDITAR
    '                        btnNuevo.Enabled = False

    '                        btnModificar.Visible = False
    '                        btnGuardar.Visible = True
    '                        btnModificar.Enabled = False
    '                        btnGuardar.Enabled = True

    '                        btnCancelar.Enabled = True
    '                        btnEliminar.Enabled = False
    '                        btnAtender.Enabled = False
    '                        btnAsignacionUnidades.Enabled = False
    '                        btnProgramarUnidades.Enabled = False
    '                        btnImprimir.Enabled = False

    '                        dtpFechaJunta.Enabled = True
    '                        txtHoraJunta.Enabled = True
    '                        txtResponsableJunta.Enabled = True
    '                        txtCantidadJunta.Enabled = True
    '                        txtDescripcionJunta.Enabled = True
    '                End Select
    '            End If

    '        Case TabProgUnidad

    '            If EstadoJunta = "C" Then

    '                btnNuevo.Enabled = False
    '                btnModificar.Visible = True
    '                btnGuardar.Visible = False
    '                btnModificar.Enabled = False
    '                btnGuardar.Enabled = False

    '                btnCancelar.Enabled = False
    '                btnEliminar.Enabled = False
    '                btnAtender.Enabled = False
    '                btnAsignacionUnidades.Enabled = False
    '                btnProgramarUnidades.Enabled = False
    '                btnImprimir.Enabled = False

    '                dtpFechaJunta.Enabled = False
    '                txtHoraJunta.Enabled = False
    '                txtResponsableJunta.Enabled = False
    '                txtCantidadJunta.Enabled = False
    '                txtDescripcionJunta.Enabled = False

    '            Else

    '                btnNuevo.Enabled = False
    '                btnModificar.Visible = True
    '                btnModificar.Enabled = False
    '                btnGuardar.Visible = False
    '                btnGuardar.Enabled = False

    '                btnCancelar.Enabled = False
    '                btnEliminar.Enabled = True
    '                btnAtender.Enabled = True
    '                btnAsignacionUnidades.Enabled = False
    '                btnProgramarUnidades.Enabled = True
    '                btnImprimir.Enabled = False

    '                dtpFechaJunta.Enabled = False
    '                txtHoraJunta.Enabled = False
    '                txtResponsableJunta.Enabled = False
    '                txtCantidadJunta.Enabled = False
    '                txtDescripcionJunta.Enabled = False


    '            End If


    '        Case TabAsignarUnidad

    '            If EstadoJunta = "C" Then

    '                btnNuevo.Enabled = False
    '                btnModificar.Visible = True
    '                btnGuardar.Visible = False
    '                btnModificar.Enabled = False
    '                btnGuardar.Enabled = False

    '                btnCancelar.Enabled = False
    '                btnEliminar.Enabled = False
    '                btnAtender.Enabled = False
    '                btnAsignacionUnidades.Enabled = False
    '                btnProgramarUnidades.Enabled = False
    '                btnImprimir.Enabled = False

    '                dtpFechaJunta.Enabled = False
    '                txtHoraJunta.Enabled = False
    '                txtResponsableJunta.Enabled = False
    '                txtCantidadJunta.Enabled = False
    '                txtDescripcionJunta.Enabled = False

    '            Else
    '                btnNuevo.Enabled = False
    '                btnModificar.Visible = True
    '                btnGuardar.Visible = False
    '                btnModificar.Enabled = False
    '                btnGuardar.Enabled = False

    '                btnCancelar.Enabled = False
    '                btnEliminar.Enabled = False
    '                btnAtender.Enabled = False
    '                btnAsignacionUnidades.Enabled = True
    '                btnProgramarUnidades.Enabled = False
    '                btnImprimir.Enabled = False

    '                dtpFechaJunta.Enabled = False
    '                txtHoraJunta.Enabled = False
    '                txtResponsableJunta.Enabled = False
    '                txtCantidadJunta.Enabled = False
    '                txtDescripcionJunta.Enabled = False
    '            End If


    '    End Select

    'End Sub
   
    Public Sub Listar_Junta(ByVal lstr_NroJunta As String)
        gwdDatos.DataSource = Nothing
        dgvJuntaReq.DataSource = Nothing
        Limpiar_Controles()
        Dim obj_Logica As New JuntaRequerimiento_BLL
        Dim objParamList As New List(Of String)
        Dim lstr_FecIni As String = ""
        Dim lstr_FecFin As String = ""
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        objParamList.Add(Me.txtNroJunta.Text.Trim)
        If ddlEstado.SelectedValue = "0" Then
            objParamList.Add("")
        Else
            objParamList.Add(ddlEstado.SelectedValue)
        End If
        objParamList.Add(lstr_FecIni)
        objParamList.Add(lstr_FecFin)
        objParamList.Add(Me.cboCompania.SelectedValue)
        objParamList.Add(Me.cboDivision.SelectedValue)
        objParamList.Add(Me.cboPlanta.SelectedValue)
        If chkNumReq.Checked = True Then
            objParamList.Add(CDec(Val(txtNroReqFiltro.Text)))
        Else
            objParamList.Add(0D)
        End If
        gwdDatos.DataSource = obj_Logica.Listar_Junta_Transporte(objParamList)
        'If gwdDatos.Rows.Count = 0 Then
        '    Limpiar_Controles()
        'End If

    End Sub

    Private Function Validar_Ingreso_Junta() As String
        Dim lstr_validacion As String = ""
        txtCantidadJunta.Text = txtCantidadJunta.Text.Trim
        If Me.txtResponsableJunta.Text = "" Then
            lstr_validacion = "* Responsable de Junta"
        End If
        Dim QJunta As Decimal = 0
        Decimal.TryParse(txtCantidadJunta.Text, QJunta)
        If QJunta = 0 Then
            lstr_validacion = lstr_validacion & Chr(13) & "* La cantidad de asistentes debe ser mayor cero(0)." & Chr(13)
        End If
        Return lstr_validacion.Trim
    End Function

  
    Private Sub Limpiar_Controles()
        Me.txtHoraJunta.Text = ""
        Me.txtResponsableJunta.Text = ""
        Me.txtCantidadJunta.Text = ""
        Me.cboEstadoJunta.SelectedValue = "P"
        Me.txtDescripcionJunta.Text = ""
    End Sub

    Private Sub Asignacion_Masiva()
        Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
        'Dim lfrm_DetalleSolicitud As New frmDetalleSolicitudTransporte_1
        Dim lfrm_DetalleSolicitud As New Object
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        lfrm_DetalleSolicitud.MdiParent = Me.Parent.Parent
        'Try
        With lfrm_DetalleSolicitud
            .txtNroJunta.Text = Me.gwdDatos.Item("NPLNJT", lint_Indice).Value
            .txtCorrelativoJunta.Text = Me.gwdDatos.Item("NCRRPL", lint_Indice).Value
            .txtFechaJunta.Text = Me.gwdDatos.Item("FPLNJT", lint_Indice).Value
            .txtHoraJunta.Text = Me.gwdDatos.Item("HPLNJT", lint_Indice).Value
            .txtResponsableJunta.Text = Me.gwdDatos.Item("TRSPAT", lint_Indice).Value
            .txtDescripcionJunta.Text = Me.gwdDatos.Item("TDSCPL", lint_Indice).Value
            ._obj_Entidad.CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
            ._obj_Entidad.CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
            ._obj_Entidad.CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value

            'If Me.gwdDatos.Item(7, lint_Indice).Value.ToString <> "P" Then
            '  .ctbTransportista.Enabled = False
            '  .ctbTipoCarroceria.Enabled = False
            '  .txtVehiculo.Enabled = False
            '  .MenuBar.Enabled = False
            '  .btnBuscarVehiculo.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            'End If
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

  

   
    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
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
            Me.Separator5.Visible = False
        End If
        If objEntidad.STSOP1 = "" Then
            Me.btnCerrarJunta.Visible = False
        End If
        If objEntidad.STSOP2 = "" Then
            Me.btnAsignacionUnidades.Visible = False
        End If
        If objEntidad.STSOP3 = "" Then
            Me.btnGenerarOperacion.Visible = False
        End If

    End Sub

    Private Sub Cargar_Compania()
        Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
        objCompaniaBLL.Crea_Lista()
        'bolBuscar = False
        cboCompania.DataSource = objCompaniaBLL.Lista
        cboCompania.ValueMember = "CCMPN"
        cboCompania.DisplayMember = "TCMPCM"
        'bolBuscar = True
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cboCompania_SelectionChangeCommitted(Nothing, Nothing)
    End Sub

    Private Sub Cargar_Division()
        Dim objDivision As New NEGOCIO.Division_BLL
        'Try
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'bolBuscar = False
        objDivision.Crea_Lista()
        cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
        cboDivision.ValueMember = "CDVSN"
        cboDivision.DisplayMember = "TCMPDV"
        Me.cboDivision.SelectedValue = "T"
        'bolBuscar = True
        If Me.cboDivision.SelectedIndex = -1 Then
            Me.cboDivision.SelectedIndex = 0
        End If
        cboDivision_SelectionChangeCommitted(Nothing, Nothing)
        'Me.Cursor = System.Windows.Forms.Cursors.Default
        'Catch ex As Exception
        '    'Me.Cursor = System.Windows.Forms.Cursors.Default
        '    HelpClass.MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Cargar_Planta()
        Dim objPlanta As New NEGOCIO.Planta_BLL
        'Try
        'If bolBuscar Then
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'bolBuscar = False
        objPlanta.Crea_Lista()
        cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
        cboPlanta.ValueMember = "CPLNDV"
        cboPlanta.DisplayMember = "TPLNTA"
        cboPlanta.SelectedValue = "1"
        'bolBuscar = True
        If cboPlanta.SelectedIndex = -1 Then
            cboPlanta.SelectedIndex = 0
        End If
        'Me.Cursor = System.Windows.Forms.Cursors.Default
        'End If
        'Catch ex As Exception
        '    'Me.Cursor = System.Windows.Forms.Cursors.Default
        '    HelpClass.MsgBox(ex.Message)
        'End Try
    End Sub

#End Region

#Region "Eventos"



    Private Sub btnCerrarJunta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarJunta.Click
        If Me.gwdDatos.CurrentRow Is Nothing Then Exit Sub
        Try
         
            If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
                HelpClass.MsgBox("Esta Junta de Transporte esta cerrada", MessageBoxIcon.Information)
                Exit Sub
            End If
            'For lint_Contador As Integer = 0 To Me.dgDatosGeneral.RowCount - 1
            '    If Me.dgDatosGeneral.Item("G_NPLCUN", lint_Contador).Value.ToString.Trim = "" Or Me.dgDatosGeneral.Item("G_CBRCNT", lint_Contador).Value.ToString.Trim = "" Then
            '        HelpClass.MsgBox(" Falta Asignar Tracto y/o Conductor a Solicitud(es) ", MessageBoxIcon.Warning)
            '        Exit Sub
            '    End If
            'Next
            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            Dim objeto_logica As New Junta_Transporte_BLL
            Dim obj_Entidad As New Junta_Transporte
            obj_Entidad.NPLNJT = Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
            obj_Entidad.NCRRPL = Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
            obj_Entidad.SESPLN = "C"
            obj_Entidad.NPLNJT = objeto_logica.Actualizar_Junta_Transporte(obj_Entidad).NPLNJT
            'If obj_Entidad.NPLNJT = "0" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            'Else
            'HelpClass.MsgBox("La Junta de Transportes se cerró satisfactoriamente")
            'Me.ddlEstado.SelectedIndex = 1
            'Me.ddlEstado.SelectedValue = "C"
            MessageBox.Show("La Junta de Transportes se cerró satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Listar_Junta(Me.gwdDatos.Item("NPLNJT", lint_Indice).Value.ToString.Trim)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim objParamList As New List(Of String)
        Try
            If Me.gwdDatos.RowCount > 0 Then
                If gwdDatos.CurrentRow IsNot Nothing Then
                    'If Me.gwdDatos.CurrentRow.Selected = True Then
                    Dim lestado_Junta As String = Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
                    objParamList.Add(Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParamList.Add(Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParamList.Add(Me.cboCompania.SelectedValue)
                    objParamList.Add(Me.cboDivision.SelectedValue)
                    objParamList.Add(Me.cboPlanta.SelectedValue)
                    'Imprimir(objParamList)
                    Dim objRep As New Junta_Transporte_BLL
                    Dim objCrep As New rptJuntaTransportista
                    Dim objDt As DataTable
                    Dim objDs As New DataSet
                    Dim objPrintForm As New PrintForm
                    'Try
                    objDt = HelpClass.GetDataSetNative(objRep.Listar_Junta_Transporte_Detalle(objParamList))
                    If objDt.Rows.Count = 0 Then
                        HelpClass.MsgBox("Esta Junta no tiene solicitudes para atender")
                        Exit Sub
                    End If
                    objDt.TableName = "RZST21"
                    'objDt.WriteXml("D:\xlee.xml")
                    objDs.Tables.Add(objDt.Copy)
                    objCrep.SetDataSource(objDs)
                    objPrintForm.ShowForm(objCrep, Me)
                    'Catch ex As Exception
                    '    End Try
                    'End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Try
    '      If TabSeleccionado <> TabRequerimiento.SelectedTab.Name Then
    '          If (gEnumOpc = EnumMan.Editar Or gEnumOpc = EnumMan.Nuevo) Then
    '              TabRequerimiento.SelectTab(TabSeleccionado)
    '              MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '              Exit Sub
    '          ElseIf gEnumOpc = EnumMan.Neutro Then
    '              gEnumOpc = EnumMan.Neutro
    '              HabilitarOpcion(EnumMan.Neutro, TabRequerimiento.SelectedTab.Name)
    '              HabilitarOpcionxEstadoRequerimiento()
    '          End If
    '      End If
    '      TabSeleccionado = TabRequerimiento.SelectedTab.Name
    '  Catch ex As Exception
    '      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try

    Private Sub TabSolicitudFlete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabSolicitudFlete.SelectedIndexChanged
        'If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
        '    'MessageBox.Show("Debe guardar o cancelar", "Aviso", MessageBoxButtons.OK)
        '    TabSolicitudFlete.SelectedIndex = TabActualSeleccionado
        '    ' TabSolicitudFlete.SelectedTab.Name =
        '    Exit Sub
        'End If
        'TabActualSeleccionado = TabSolicitudFlete.SelectedIndex
        'Dim NameTab As String = TabSolicitudFlete.SelectedTab.Name

        ''Dim estadoActual As String = ""
        ''If gwdDatos.CurrentRow Is Nothing Then
        ''    estadoActual = "C"
        ''Else
        ''    estadoActual = gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
        ''End If

        'Select Case NameTab
        '    'FLFLLF
        '    Case TabDatoGeneral  'DATOS GENERALES
        '        'Me.MenuBar.Enabled = True
        '        HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, NameTab, Estado_Actual_Junta)
        '        Me.btnGenerarOperacion.Enabled = False
        '    Case TabProgUnidad
        '        HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, NameTab, Estado_Actual_Junta)
        '    Case TabAsignarUnidad  'UNIDADES ASIGNADAS
        '        'Me.MenuBar.Enabled = False
        '        HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, NameTab, Estado_Actual_Junta)
        '        Me.btnGenerarOperacion.Enabled = True

        '    Case "tbRequerimientos"
        '        HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, NameTab, Estado_Actual_Junta)
        '        Me.btnGenerarOperacion.Enabled = True
        'End Select
        Try
            If TabSeleccionado <> TabSolicitudFlete.SelectedTab.Name Then
                If (gEnumOpc = EnumMan.Editar Or gEnumOpc = EnumMan.Nuevo) Then
                    TabSolicitudFlete.SelectTab(TabSeleccionado)
                    MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf gEnumOpc = EnumMan.Neutro Then
                    gEnumOpc = EnumMan.Neutro
                    HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
                    'HabilitarOpcionxEstadoJunta()
                End If
            End If
            TabSeleccionado = TabSolicitudFlete.SelectedTab.Name
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private Function Estado_Actual_Junta() As String
    '    Dim estadoActual As String = ""
    '    If gwdDatos.CurrentRow Is Nothing Then
    '        estadoActual = "P"
    '    Else
    '        estadoActual = gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
    '    End If
    '    Return estadoActual
    'End Function
    '     HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSolicitudFlete.SelectedTab.Name, Estado_Actual_Junta)

    Private Sub btnAsignacionUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignacionUnidades.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then Exit Sub
            'If Me.gwdDatos.RowCount > 0 Then
            'If Me.gwdDatos.CurrentRow.Selected = True Then
            If ("" & gwdDatos.CurrentRow.Cells("SESPLN").Value).ToString.Trim <> "C" Then
                Me.Asignacion_Masiva()
            Else
                HelpClass.MsgBox("No se puede asignar unidades.La Junta de Transportes está cerrada", MessageBoxIcon.Information)
            End If
            'End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub CargarFiltro()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("DISPLAY")
        dtEstado.Columns.Add("VALUE")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("DISPLAY") = "::TODOS::"
        dr("VALUE") = "0"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "Pendiente"
        dr("VALUE") = "P"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "Cerrado"
        dr("VALUE") = "C"
        dtEstado.Rows.Add(dr)

        ddlEstado.DataSource = dtEstado
        ddlEstado.DisplayMember = "DISPLAY"
        ddlEstado.ValueMember = "VALUE"
        ddlEstado.SelectedValue = "P"


        Dim dtEstadoJunta As New DataTable
        dtEstadoJunta.Columns.Add("DISPLAY")
        dtEstadoJunta.Columns.Add("VALUE")
        Dim drJunta As DataRow

        drJunta = dtEstadoJunta.NewRow
        drJunta("DISPLAY") = "Pendiente"
        drJunta("VALUE") = "P"
        dtEstadoJunta.Rows.Add(drJunta)

        drJunta = dtEstadoJunta.NewRow
        drJunta("DISPLAY") = "Cerrado"
        drJunta("VALUE") = "C"
        dtEstadoJunta.Rows.Add(drJunta)

        cboEstadoJunta.DataSource = dtEstadoJunta
        cboEstadoJunta.DisplayMember = "DISPLAY"
        cboEstadoJunta.ValueMember = "VALUE"

    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Dim obj_Entidad As New Junta_Transporte
            Dim obj_Logica As New Junta_Transporte_BLL
            TabSeleccionado = TabSolicitudFlete.SelectedTab.Name
            Select Case TabSeleccionado
                Case "tbInformacionGeneral"
                    obj_Entidad.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
                    obj_Entidad.CDVSN = Me.cboDivision.SelectedValue.ToString.Trim
                    obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                    obj_Entidad.NPLNJT = obj_Logica.Existe_Junta_Pendiente_Transporte(obj_Entidad).NPLNJT
                    'If obj_Entidad.NPLNJT = "-1" Then
                    'HelpClass.MsgBox("Existe una Junta Pendiente")
                    'MessageBox.Show("Existe una Junta Pendiente.Debe cerrar la Junta Pendiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Exit Sub
                    'ElseIf obj_Entidad.NPLNJT = "0" Then
                    '  HelpClass.ErrorMsgBox()
                    '  Exit Sub
                    'End If
                    ' Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
                    'DDD()
                    'Me.btnGuardar.Text = "Guardar"
                    'Me.btnGuardar.Enabled = True
                    'Me.btnCancelar.Enabled = True
                    'Me.btnEliminar.Enabled = False
                    'Me.Limpiar_Controles()
                    'Me.Estado_Controles(True)
                    gEnumOpc = EnumMan.Nuevo
                    Limpiar_Controles()
                    'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                    'HabilitarBotonOpcion(MANTENIMIENTO.NUEVO, TabDatoGeneral, "P")
                    HabilitarOpcion(EnumMan.Nuevo, TabSeleccionado)
                    dtpFechaJunta.Value = Date.Today
                    dtpFechaJunta.Enabled = True
                    txtHoraJunta.Enabled = True
                    txtResponsableJunta.Enabled = True
                    txtCantidadJunta.Enabled = True
                    txtDescripcionJunta.Enabled = True
                    txtHoraJunta.Text = HelpClass.Now_Hora
                    'Me.cboEstadoJunta.SelectedIndex = 0
                    cboEstadoJunta.SelectedValue = "P"
                    'If Me.gwdDatos.Rows.Count > 0 Then
                    '    Me.gwdDatos.CurrentRow.Selected = False
                    'End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim NameTab As String = TabSolicitudFlete.SelectedTab.Name
            Dim Validar As String = ""
            Select Case NameTab
                Case "tbInformacionGeneral"
                    'If Validar_Ingreso_Junta() = True Then
                    '    Exit Sub
                    'End If
                    Select Case gEnumOpc
                        Case EnumMan.Nuevo
                            Validar = Validar_Ingreso_Junta()
                            If Validar.Length > 0 Then
                                MessageBox.Show(Validar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            'Me.Nueva_Junta()
                            'Me.AccionCancelar()
                            Dim obj_Entidad As New Junta_Transporte
                            Dim obj_Logica As New Junta_Transporte_BLL
                            'Try
                            obj_Entidad.FPLNJT = HelpClass.CtypeDate(Me.dtpFechaJunta.Value)
                            obj_Entidad.HPLNJT = HelpClass.ConvertHoraNumeric(Me.txtHoraJunta.Text.Substring(0, 8))
                            obj_Entidad.TRSPAT = Me.txtResponsableJunta.Text.Trim
                            obj_Entidad.TDSCPL = Me.txtDescripcionJunta.Text.Trim
                            obj_Entidad.QCNASI = IIf(Me.txtCantidadJunta.Text.Trim = "", "0", Me.txtCantidadJunta.Text.Trim)
                            'obj_Entidad.SESPLN = Asignar_Valor(Me.cboEstadoJunta)
                            'obj_Entidad.SESPLN = cboEstadoJunta.SelectedValue
                            obj_Entidad.SESPLN = "P"
                            obj_Entidad.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
                            obj_Entidad.CDVSN = Me.cboDivision.SelectedValue.ToString.Trim
                            obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                            obj_Entidad.CUSCRT = MainModule.USUARIO
                            obj_Entidad.FCHCRT = HelpClass.TodayNumeric
                            obj_Entidad.HRACRT = HelpClass.NowNumeric
                            obj_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                            obj_Entidad.NPLNJT = obj_Logica.Registrar_Junta_Transporte(obj_Entidad).NPLNJT
                            MessageBox.Show("Se registró satisfactoriamente la Junta: " & obj_Entidad.NPLNJT & " - " & obj_Entidad.NCRRPL, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Me.ddlEstado.SelectedValue = "P"
                            'Listar_Junta(obj_Entidad.NPLNJT)
                            gEnumOpc = EnumMan.Neutro
                            HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
                            Estado_Controles(False)
                            Listar_Junta("")
                            'Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                            'HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabDatoGeneral, Estado_Actual_Junta)
                        Case EnumMan.Editar
                            If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString = "P" Then
                                'Me.Modificar_Junta()
                                'Me.AccionCancelar()
                                Validar = Validar_Ingreso_Junta()
                                If Validar.Length > 0 Then
                                    MessageBox.Show(Validar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                End If
                                Dim obj_Entidad As New Junta_Transporte
                                Dim obj_Logica As New Junta_Transporte_BLL
                                'Try
                                'obj_Entidad.NPLNJT = _strNPLNJT
                                'obj_Entidad.NCRRPL = _strNCRRPL
                                obj_Entidad.NPLNJT = gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value
                                obj_Entidad.NCRRPL = gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value
                                obj_Entidad.FPLNJT = HelpClass.CtypeDate(Me.dtpFechaJunta.Value)
                                obj_Entidad.HPLNJT = HelpClass.ConvertHoraNumeric(Me.txtHoraJunta.Text.Substring(0, 8))
                                obj_Entidad.TRSPAT = Me.txtResponsableJunta.Text.Trim
                                obj_Entidad.TDSCPL = Me.txtDescripcionJunta.Text.Trim
                                obj_Entidad.QCNASI = IIf(Me.txtCantidadJunta.Text.Trim = "", "0", Me.txtCantidadJunta.Text.Trim)
                                'obj_Entidad.SESPLN = Asignar_Valor(Me.cboEstadoJunta)
                                obj_Entidad.SESPLN = cboEstadoJunta.SelectedValue
                                obj_Entidad.CULUSA = MainModule.USUARIO
                                obj_Entidad.FULTAC = HelpClass.TodayNumeric
                                obj_Entidad.HULTAC = HelpClass.NowNumeric
                                obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                                obj_Entidad.NPLNJT = obj_Logica.Modificar_Junta_Transporte(obj_Entidad).NPLNJT
                                HelpClass.MsgBox("Se modificó satisfactoriamente")
                                'Listar_Junta(obj_Entidad.NPLNJT)
                                gEnumOpc = EnumMan.Neutro
                                HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
                                Estado_Controles(False)
                                Listar_Junta("")
                                '  Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                                'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                                ' HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabDatoGeneral, Estado_Actual_Junta)
                            End If
                    End Select
                    'If gEnumOpc = EnumMan.Nuevo Then
                    'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                    '    'Me.Estado_Controles(True)
                    '    Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                    '    HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, TabSeleccionado)

                    '    'Me.btnGuardar.Text = "Guardar"
                    '    'Me.btnNuevo.Enabled = False
                    '    'Me.btnCancelar.Enabled = True
                    '    'Me.btnEliminar.Enabled = False
                    '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    'End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Me.AccionCancelar()
        'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        'Select Case TabSeleccionado
        '    Case TabDatoGeneral
        '        'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        '        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '        HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)
        'End Select
        'gwdDatos_SelectionChanged(Nothing, Nothing)
        Try
            'Dim tabSelect As String = TabSolicitudFlete.SelectedTab.Name
            Limpiar_Controles()
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
            Estado_Controles(False)

            If gwdDatos.Rows.Count = 0 Then
                dgvJuntaReq.DataSource = Nothing
            Else
                CargarDatosJunta()
                'Listar_Unidades_Programadas()
                Lista_Requerimientos_X_Junta()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'Me.AccionCancelar()
        'If gwdDatos.CurrentRow Is Nothing Then
        '    Exit Sub
        'End If
        'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        'Select Case TabSeleccionado
        '    Case TabDatoGeneral
        '        Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        '        Dim estadoActual As String = ""
        '        'If gwdDatos.CurrentRow Is Nothing Then
        '        '    estadoActual = "C"
        '        'Else
        '        '    estadoActual = gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
        '        'End If
        '        HabilitarBotonOpcion(MANTENIMIENTO.EDITAR, TabDatoGeneral, "P")
        '    Case TabProgUnidad

        'End Select
        Try
            Dim TabSelect As String = TabSolicitudFlete.SelectedTab.Name
            If gwdDatos.CurrentRow Is Nothing Then Exit Sub
            Select Case TabSelect
                Case "tbInformacionGeneral"

                    If gwdDatos.CurrentRow.Cells("SESPLN").Value.ToString.Trim = "C" Then
                        MessageBox.Show("La junta se encuentra cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    gEnumOpc = EnumMan.Editar
                    HabilitarOpcion(EnumMan.Editar, TabSolicitudFlete.SelectedTab.Name)
                    dtpFechaJunta.Enabled = True
                    txtHoraJunta.Enabled = True
                    txtResponsableJunta.Enabled = True
                    txtCantidadJunta.Enabled = True
                    txtDescripcionJunta.Enabled = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim obj_LogicaJunta As New Detalle_Solicitud_Transporte_BLL
        Dim objParametro As New Hashtable
        Dim validar As String = ""
        Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        If gwdDatos.CurrentRow Is Nothing Then Exit Sub
        'Exit Sub
        'End If
        Try
            'TabSeleccionado
            Select Case TabSeleccionado
                Case "tbInformacionGeneral"

                    If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
                        HelpClass.MsgBox("Esta Junta de Transporte esta cerrada", MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        If dgvJuntaReq.Rows.Count > 0 Then
                            MessageBox.Show("No se puede eliminar, existen requerimientos asignados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                    objParametro.Add("PNNPLNJT", Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParametro.Add("PNNCRRPL", Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParametro.Add("PSCCMPN", cboCompania.SelectedValue)
                    For Each obj_Entidad As Detalle_Solicitud_Transporte In obj_LogicaJunta.Listar_Detalle_Solicitud(objParametro)
                        If obj_Entidad.NOPRCN <> 0 Then
                            validar = "No se puede eliminar la junta." & Chr(13) & "* Esta Junta tiene asignada N° de Operación"
                            'HelpClass.MsgBox("Esta Junta tiene asignada N° de Operacion; si quiere eliminar comuniquese al Dpto. de Sistemas")
                            'MessageBox.Show("No se puede eliminar la junta" & Chr(13) & "Esta Junta tiene asignada N° de Operación", "Aviso")
                            Exit For
                        End If
                    Next
                    'If kdgvUnidadProgramada.Rows.Count > 0 Then
                    '  MessageBox.Show("No se puede eliminar la junta " & Chr(13) & "Tiene unidades programadas", "Aviso", MessageBoxButtons.OK)
                    'validar = validar & Chr(13) & "Tiene unidades programadas"
                    'Exit Sub
                    'End If
                    'If MsgBox("Desea eliminar esta Junta de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                    'Me.Eliminar_Junta_Transporte()
                    If validar.Length > 0 Then
                        MessageBox.Show(validar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If MessageBox.Show("Está seguro de eliminar esta Junta de Transporte ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

                            Dim obj_Entidad As New Junta_Transporte
                            Dim obj_Logica As New Junta_Transporte_BLL
                            obj_Entidad.NPLNJT = Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value
                            obj_Entidad.NCRRPL = Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value
                            obj_Entidad.CULUSA = MainModule.USUARIO
                            obj_Entidad.FULTAC = HelpClass.TodayNumeric
                            obj_Entidad.HULTAC = HelpClass.NowNumeric
                            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                            obj_Entidad.CCMPN = Me.cboCompania.SelectedValue
                            obj_Entidad.CDVSN = Me.cboDivision.SelectedValue
                            obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                            obj_Entidad.NPLNJT = obj_Logica.Eliminar_Junta_Transporte(obj_Entidad).NPLNJT
                            'If obj_Entidad.NPLNJT <> "0" Then
                            '    HelpClass.MsgBox("Se eliminó satisfactoriamente")
                            'Else
                            '    HelpClass.ErrorMsgBox()
                            '    Exit Sub
                            'End If
                            MessageBox.Show("Se eliminó satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '  Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                            gEnumOpc = EnumMan.Neutro
                            HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
                            Me.Listar_Junta("")
                            'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                            'HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)

                        End If
                        'Me.Eliminar_Junta_Transporte()
                    End If

                    'Case "tabInfoUnidadProgramada"

                    '    If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
                    '        HelpClass.MsgBox("Esta Junta de Transporte esta cerrada", MessageBoxIcon.Information)
                    '        Exit Sub
                    '    End If
                    'If kdgvUnidadProgramada.CurrentRow Is Nothing Then
                    '    Exit Sub
                    'End If
                    'Dim objDetalle_Junta_Transporte As New Detalle_Junta_Transporte
                    'Dim oblJunta_Transporte_BLL As New Junta_Transporte_BLL
                    'objDetalle_Junta_Transporte.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                    'objDetalle_Junta_Transporte.NPLNJT = kdgvUnidadProgramada.CurrentRow.Cells("NPLNJT_UP").Value
                    'objDetalle_Junta_Transporte.NCRRPL = kdgvUnidadProgramada.CurrentRow.Cells("NCRRPL_UP").Value
                    'objDetalle_Junta_Transporte.NCSOTR = kdgvUnidadProgramada.CurrentRow.Cells("NCSOTR").Value
                    'objDetalle_Junta_Transporte.CULUSA = MainModule.USUARIO
                    'objDetalle_Junta_Transporte.NTRMNL = HelpClass.NombreMaquina
                    'If MessageBox.Show("Está seguro de eliminar la programación para la junta", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    '    oblJunta_Transporte_BLL.Eliminar_Junta_Solicitud_Programado(objDetalle_Junta_Transporte)
                    '    Listar_Unidades_Programadas_x_Junta()
                    'End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Try
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
            Limpiar_Controles()
            Me.Listar_Junta("")
            ' Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
            ' HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        If Me.ckbRangoFechas.Checked = True Then
            Me.dtpFechaInicio.Enabled = True
            Me.dtpFechaFin.Enabled = True
        Else
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub

  
    Private Sub txtNroJunta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroJunta.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtCantidadJunta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadJunta.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtResponsableJunta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResponsableJunta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloLetras(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectionChangeCommitted
        'If bolBuscar Then
        Try
            Me.Cargar_Division()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'End If
    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectionChangeCommitted
        'If bolBuscar Then
        Try
            Me.Cargar_Planta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'End If
    End Sub

    Private Sub btnImprimirLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirLista.Click
        Try
            'Me.Cursor = Cursors.WaitCursor
            Dim obj_Logica As New Junta_Transporte_BLL
            Dim objParamList As New List(Of String)
            Dim lstr_FecIni As String = ""
            Dim lstr_FecFin As String = ""
            'objParamList.Add(Asignar_Valor(Me.ddlEstado))
            If ddlEstado.SelectedValue = "0" Then
                objParamList.Add("")
            Else
                objParamList.Add(ddlEstado.SelectedValue)
            End If
            objParamList.Add(Me.txtNroJunta.Text)
            If Not ckbRangoFechas.Checked Then
                objParamList.Add(0)
                objParamList.Add(0)
            Else
                objParamList.Add(lstr_FecIni)
                objParamList.Add(lstr_FecFin)
            End If
            objParamList.Add(Me.cboCompania.SelectedValue)
            objParamList.Add(Me.cboDivision.SelectedValue)
            objParamList.Add(Me.cboPlanta.SelectedValue)
            Dim objCrep As New rptReporteListaJuntaTransportista
            Dim objDt As DataTable
            Dim objDs As New DataSet
            Dim objPrintForm As New PrintForm

            objDt = HelpClass.GetDataSetNative(obj_Logica.Lista_Reporte_Junta_Transporte(objParamList))
            If objDt.Rows.Count = 0 Then
                HelpClass.MsgBox("Esta Junta no tiene solicitudes para atender")
                Exit Sub
            End If
            objDt.TableName = "RZST21"
            'objDt.WriteXml("D:\xlee.xml")
            objDs.Tables.Add(objDt.Copy)
            objCrep.SetDataSource(objDs)
            objPrintForm.ShowForm(objCrep, Me)
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region



    Private Sub btnProgramarUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProgramarUnidades.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then Exit Sub
            Dim ofrmSolicitudPendiente As New frmSolPendprogramar
            ofrmSolicitudPendiente.pCCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            ofrmSolicitudPendiente.pCDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
            ofrmSolicitudPendiente.pCPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
            ofrmSolicitudPendiente.pNPLNJT = gwdDatos.CurrentRow.Cells("NPLNJT").Value
            ofrmSolicitudPendiente.pNCRRPL = gwdDatos.CurrentRow.Cells("NCRRPL").Value
            ofrmSolicitudPendiente.ShowDialog()
            If ofrmSolicitudPendiente.MyDialogResult = True Then
                'Listar_Unidades_Programadas_x_Junta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDatosJunta()
        Limpiar_Controles()
        If gwdDatos.CurrentRow Is Nothing Then Exit Sub
        Dim lint_indice As Integer = gwdDatos.CurrentCellAddress.Y
        Dim objEntidad As New Junta_Transporte
        Dim objJuntaTransporte As New Junta_Transporte_BLL
        '_strNPLNJT = gwdDatos.Item("NPLNJT", lint_indice).Value
        '_strNCRRPL = gwdDatos.Item("NCRRPL", lint_indice).Value
        dtpFechaJunta.Value = gwdDatos.Item("FPLNJT", lint_indice).Value
        txtHoraJunta.Text = gwdDatos.Item("HPLNJT", lint_indice).Value
        txtResponsableJunta.Text = gwdDatos.Item("TRSPAT", lint_indice).Value
        txtDescripcionJunta.Text = gwdDatos.Item("TDSCPL", lint_indice).Value
        txtCantidadJunta.Text = gwdDatos.Item("QCNASI", lint_indice).Value
        'Quitar_Valor(Me.gwdDatos.Item("SESPLN", lint_indice).Value.ToString, Me.cboEstadoJunta)
        cboEstadoJunta.SelectedValue = gwdDatos.Item("SESPLN", lint_indice).Value
        'HeaderDatos.ValuesPrimary.Heading = " Nro : " & _strNPLNJT & " | Responsable Junta : " + Me.txtResponsableJunta.Text & " | Estado Junta : " & Me.cboEstadoJunta.Text
        HeaderDatos.ValuesPrimary.Heading = " Nro : " & gwdDatos.Item("NPLNJT", lint_indice).Value & " | Responsable Junta : " + Me.txtResponsableJunta.Text & " | Estado Junta : " & Me.cboEstadoJunta.Text
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
            ' HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)
            'Me.Cargar_Datos_Grilla()
            'Limpiar_Datos_General_Junta()
            'Dim lint_indice As Integer = gwdDatos.CurrentCellAddress.Y
            'Dim objEntidad As New Junta_Transporte
            'Dim objJuntaTransporte As New Junta_Transporte_BLL
            '_strNPLNJT = gwdDatos.Item("NPLNJT", lint_indice).Value
            '_strNCRRPL = gwdDatos.Item("NCRRPL", lint_indice).Value
            'dtpFechaJunta.Value = gwdDatos.Item("FPLNJT", lint_indice).Value
            'txtHoraJunta.Text = gwdDatos.Item("HPLNJT", lint_indice).Value
            'txtResponsableJunta.Text = gwdDatos.Item("TRSPAT", lint_indice).Value
            'txtDescripcionJunta.Text = gwdDatos.Item("TDSCPL", lint_indice).Value
            'txtCantidadJunta.Text = gwdDatos.Item("QCNASI", lint_indice).Value
            ''Quitar_Valor(Me.gwdDatos.Item("SESPLN", lint_indice).Value.ToString, Me.cboEstadoJunta)
            'cboEstadoJunta.SelectedValue = gwdDatos.Item("SESPLN", lint_indice).Value
            'HeaderDatos.ValuesPrimary.Heading = " Nro : " & _strNPLNJT & " | Responsable Junta : " + Me.txtResponsableJunta.Text & " | Estado Junta : " & Me.cboEstadoJunta.Text

            'Listar_Solicitudes_Asignadas_X_Junta_Transportista()
            'Listar_Unidades_Programadas_x_Junta()
            ' CargarDatosJunta()
            ' Lista_Requerimientos_X_Junta()

            'Try
            Limpiar_Controles()
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, TabSolicitudFlete.SelectedTab.Name)
            Estado_Controles(False)
            'HabilitarOpcionxEstadoJunta()
            'If dgvDatos.CurrentRow Is Nothing Then
            '    Exit Sub
            'End If
            ' dgvPreAsignacion.DataSource = Nothing
            dgvJuntaReq.DataSource = Nothing
            CargarDatosJunta()
            Lista_Requerimientos_X_Junta()
            ' TabRequerimiento_SelectedIndexChanged(Nothing, Nothing)
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Lista_Requerimientos_X_Junta()
        Dim ObjBLL As New JuntaRequerimiento_BLL
        Dim ObjBE As New JuntaRequerimiento
        dgvJuntaReq.DataSource = Nothing
        'dgvJuntaReq.AutoGenerateColumns = False
        ' With ObjBE
        ObjBE.NPLNJT = gwdDatos.CurrentRow.Cells("NPLNJT").Value
        ObjBE.NCRRPL = gwdDatos.CurrentRow.Cells("NCRRPL").Value
        ' End With
        dgvJuntaReq.DataSource = ObjBLL.Lista_Requerimientos_X_Junta(ObjBE)
    End Sub


    Private Sub Atender(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtender.Click
        Try
            If gwdDatos.CurrentRow IsNot Nothing Then

                If gwdDatos.CurrentRow.Cells("SESPLN").Value.ToString.Trim = "C" Then
                    MessageBox.Show("La junta se encuentra cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim ObjFrm As New frmAtenderJuntaTransporteReq
                Dim Entidad As New Junta_Transporte
                '   With Entidad
                Entidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                Entidad.CDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
                Entidad.CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                Entidad.NPLNJT = gwdDatos.CurrentRow.Cells("NPLNJT").Value
                Entidad.FPLNJT = gwdDatos.CurrentRow.Cells("FPLNJT").Value
                Entidad.HPLNJT = gwdDatos.CurrentRow.Cells("HPLNJT").Value
                Entidad.NCRRPL = gwdDatos.CurrentRow.Cells("NCRRPL").Value
                '  End With
                ObjFrm.Entidad = Entidad
                ObjFrm.ShowDialog()
                Lista_Requerimientos_X_Junta()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvJuntaReq_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvJuntaReq.DataBindingComplete
        Try

            For Each Item As DataGridViewRow In dgvJuntaReq.Rows
                If (Item.Cells("UNIDADES").Value > 0) Then
                    Item.Cells("IMAGEN").Value = My.Resources.text_block
                Else
                    Item.Cells("IMAGEN").Value = My.Resources.CuadradoBlanco
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvJuntaReq_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJuntaReq.CellDoubleClick

        Try
            If dgvJuntaReq.CurrentRow IsNot Nothing Then
                If dgvJuntaReq.Columns(e.ColumnIndex).Name = "IMAGEN" Then
                    Dim ObjFrm As New frmVerUnidadesProgramadas_Junta
                    ObjFrm.pNUMREQT = dgvJuntaReq.CurrentRow.Cells("NUMREQT").Value
                    ObjFrm.pCCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                    ObjFrm.pBarra = False
                    ObjFrm.ShowDialog()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub chkNumReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNumReq.CheckedChanged
        Try
            txtNroReqFiltro.Enabled = chkNumReq.Checked
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Exportar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try

            If gwdDatos.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC

            Dim ListaExcel As List(Of ENTIDADES.Operaciones.Junta_Transporte) = Me.gwdDatos.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NPLNJT").Caption = NPOI_SC.FormatDato("N° Junta", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NCRRPL").Caption = NPOI_SC.FormatDato("N° Correlativo", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FPLNJT").Caption = NPOI_SC.FormatDato("Fecha Junta", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HPLNJT").Caption = NPOI_SC.FormatDato("Hora Junta", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("TRSPAT").Caption = NPOI_SC.FormatDato("Responsable Junta", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("QCNASI").Caption = NPOI_SC.FormatDato("Cantidad Asistentes", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QREQUERIMIENTOS").Caption = NPOI_SC.FormatDato("Nro Requerimientos ", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QUNIDADES").Caption = NPOI_SC.FormatDato("Nro Unidades", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("ESTADO_JNT").Caption = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TDSCPL").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)

            For Each item As ENTIDADES.Operaciones.Junta_Transporte In ListaExcel
                dr = dtExcel.NewRow
                dr("NPLNJT") = item.NPLNJT
                dr("NCRRPL") = item.NCRRPL
                dr("FPLNJT") = item.FPLNJT
                dr("HPLNJT") = item.HPLNJT
                dr("TRSPAT") = item.TRSPAT

                dr("QCNASI") = item.QCNASI
                dr("QREQUERIMIENTOS") = item.QREQUERIMIENTOS
                dr("QUNIDADES") = item.QUNIDADES
                dr("SESPLN") = item.SESPLN
                dr("TDSCPL") = item.TDSCPL

                dtExcel.Rows.Add(dr)
            Next

            Dim ListaDatatable As New List(Of DataTable)
            dtExcel.TableName = "JUNTA_TRANSPORTE"
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("LISTA DE JUNTA DE TRANSPORTE REQUERIMIENTO")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cboCompania.Text)
            F.Add(1, "División:|" & cboDivision.Text)
            F.Add(2, "Planta:| " & cboPlanta.Text)

            'If chkFecha.Checked = True Then
            '    F.Add(5, "Fecha:| " & Me.dtpFechaInicioReq.Value.Date & " - " & Me.dtpFechaFinReq.Value.Date)
            'End If
            'F.Add(5, "Fecha:| " & Me.dtpFechaInicioReq.Value.Date & " - " & Me.dtpFechaFinReq.Value.Date)

            oLisFiltro.Add(F)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNroReqFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroReqFiltro.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    End Sub
End Class

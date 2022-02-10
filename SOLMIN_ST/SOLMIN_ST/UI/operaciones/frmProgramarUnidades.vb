Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data
Public Class frmProgramarUnidades

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property
    Private _pCDVSN As String = ""
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property
    Private _pCPLNDV As Decimal = 0
    Public Property pCPLNDV() As Decimal
        Get
            Return _pCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _pCPLNDV = value
        End Set
    End Property

    Private _pNPLNJT As Decimal = 0
    Public Property pNPLNJT() As Decimal
        Get
            Return _pNPLNJT
        End Get
        Set(ByVal value As Decimal)
            _pNPLNJT = value
        End Set
    End Property
    Private _pNCRRPL As Decimal = 0
    Public Property pNCRRPL() As Decimal
        Get
            Return _pNCRRPL
        End Get
        Set(ByVal value As Decimal)
            _pNCRRPL = value
        End Set
    End Property


    Private _AccionRegistro As Accion = Accion.ADICIONAR
    Public Property AccionRegistro() As Accion
        Get
            Return _AccionRegistro
        End Get
        Set(ByVal value As Accion)
            _AccionRegistro = value
        End Set
    End Property

    Enum Estado
        Neutral
        Edicion
    End Enum
    Enum Accion
        ADICIONAR
        MODIFICAR
    End Enum

    Private _Estado As Estado = Estado.Neutral


    Private _MyDialogResult As Boolean = False
    Public Property MyDialogResult() As Boolean
        Get
            Return _MyDialogResult
        End Get
        Set(ByVal value As Boolean)
            _MyDialogResult = value
        End Set
    End Property


    Private Sub AsignarEstado(ByVal _ActualEstado As Estado)
        Select Case _ActualEstado
            Case Estado.Neutral
                btnAsignar.Enabled = True

                btnGuardar.Visible = False
                btnModificar.Visible = True
                btnCancelar.Visible = False

                btnEliminar.Enabled = True

                Panel1.Enabled = False
            Case Estado.Edicion
                btnAsignar.Enabled = False

                btnGuardar.Visible = True
                btnModificar.Visible = False
                btnCancelar.Visible = True

                btnEliminar.Enabled = False
                Panel1.Enabled = True
        End Select
    End Sub

    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    Try

    '        Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    '        Dim objSolicitud As New Solicitud_Transporte
    '        Dim lstr_FecIni As Int32 = 0
    '        Dim lstr_FecFin As Int32 = 0
    '        Dim lstr_HoraIni As Int32 = 0
    '        Dim lstr_HoraFin As Int32 = 0

    '        If Me.ckbRangoFechas.Checked = True Then
    '            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
    '            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
    '        Else
    '            lstr_FecIni = 0
    '            lstr_FecFin = 0
    '        End If
    '        If chkRangoHora.Checked = True Then
    '            lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
    '            lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
    '        Else
    '            lstr_HoraIni = 0
    '            lstr_HoraFin = 0
    '        End If
    '        If Me.txtSolicitud.Text.Trim.Equals("") Then
    '            objSolicitud.NCSOTR = 0
    '        Else
    '            objSolicitud.NCSOTR = Me.txtSolicitud.Text.Trim
    '        End If
    '        If UcCliente_TxtF011.pCodigo <> 0 Then
    '            objSolicitud.CCLNT = UcCliente_TxtF011.pCodigo
    '        Else
    '            objSolicitud.CCLNT = 0
    '        End If
    '        objSolicitud.NOPRCN = 0
    '        objSolicitud.SESSLC = ddlEstado.SelectedValue
    '        objSolicitud.SESTRG = "A"
    '        objSolicitud.FE_INI = lstr_FecIni
    '        objSolicitud.FE_FIN = lstr_FecFin
    '        objSolicitud.HR_INI = lstr_HoraIni
    '        objSolicitud.HR_FIN = lstr_HoraFin
    '        objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
    '        objSolicitud.CCMPN = _pCCMPN
    '        objSolicitud.CDVSN = _pCDVSN
    '        objSolicitud.CPLNDV = _pCPLNDV
    '        If ckbUsuarioCreador.Checked = True Then
    '            objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
    '        Else
    '            objSolicitud.CUSCRT = ""
    '        End If
    '        objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim
    '        objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue
    '        dgSolicitud.DataSource = obj_Logica.Listar_Cliente_Solicitud_Programacion(objSolicitud)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    Private Sub kdgvUnidadProgramada_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kdgvUnidadProgramada.SelectionChanged
        Try
            Limpiar()
            txtNroSolicitud.Text = kdgvUnidadProgramada.CurrentRow.Cells("NCSOTR").Value
            txtCliente.Text = kdgvUnidadProgramada.CurrentRow.Cells("CCLNT").Value
            txtTipoVehiculo.Text = kdgvUnidadProgramada.CurrentRow.Cells("CUNDVH").Value
            txtRuta.Text = kdgvUnidadProgramada.CurrentRow.Cells("CLCLOR").Value & "->" & kdgvUnidadProgramada.CurrentRow.Cells("CLCLDS").Value
            'kdgvUnidadProgramada.CurrentRow.Cells("CLCLOR").Value & "->" & dgSolicitud.CurrentRow.Cells("CLCLDS").Value
            txtQSolicitado.Text = Convert.ToDouble(kdgvUnidadProgramada.CurrentRow.Cells("QSLCIT").Value)
            txtQProgramado.Text = Convert.ToDouble(kdgvUnidadProgramada.CurrentRow.Cells("QANPRG").Value)
            txtQAtendido.Text = Convert.ToDouble(kdgvUnidadProgramada.CurrentRow.Cells("QATNAN").Value)
            AsignarEstado(Estado.Neutral)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

  
    Private Sub frmProgramarUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'dgSolicitud.AutoGenerateColumns = False
            AsignarEstado(Estado.Neutral)
            'ckbRangoFechas.Checked = False
            'ckbRangoFechas_CheckedChanged(ckbRangoFechas, Nothing)
            'ckbUsuarioCreador.Checked = False
            'ckbUsuarioCreador_CheckedChanged(ckbUsuarioCreador, Nothing)
            'CargarFiltros()
            txtNroJunta.Text = _pNPLNJT
            txtCorr.Text = _pNCRRPL
            kdgvUnidadProgramada.AutoGenerateColumns = False
            Listar_Unidades_Programadas_x_Junta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub Listar_Unidades_Programadas_x_Junta()
        Dim obj_LogicaJunta As New Junta_Transporte_BLL
        Dim dtSolProgJunta As New DataTable
        kdgvUnidadProgramada.DataSource = Nothing
        Dim obj As New Junta_Transporte
        obj.NPLNJT = _pNPLNJT
        obj.NCRRPL = _pNCRRPL
        obj.CCMPN = _pCCMPN
        dtSolProgJunta = obj_LogicaJunta.Lista_Solicitud_Programas_x_Junta(obj)
        If dtSolProgJunta.Rows.Count = 0 Then
            Limpiar()
        End If
        kdgvUnidadProgramada.DataSource = dtSolProgJunta
    End Sub
    'Private Function TipoPrioridadFiltro()
    '    Dim oDt As New DataTable
    '    oDt.Columns.Add("COD")
    '    oDt.Columns.Add("NOM")
    '    Dim oDr As DataRow
    '    oDr = oDt.NewRow
    '    oDr.Item("COD") = "T"
    '    oDr.Item("NOM") = "TODOS"
    '    oDt.Rows.Add(oDr)
    '    oDr = oDt.NewRow
    '    oDr.Item("COD") = "N"
    '    oDr.Item("NOM") = "NORMAL"
    '    oDt.Rows.Add(oDr)
    '    oDr = oDt.NewRow
    '    oDr.Item("COD") = "U"
    '    oDr.Item("NOM") = "URGENTE"
    '    oDt.Rows.Add(oDr)
    '    Return oDt
    'End Function

    'Private Sub CargarFiltros()
    '    Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
    '    Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(_pCCMPN)

    '    Me.cboMedioTransporteFiltro.DataSource = objTabla.Copy
    '    Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
    '    Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
    '    cboMedioTransporteFiltro.SelectedValue = 4


    '    Me.cboPrioridadFiltro.DataSource = TipoPrioridadFiltro()
    '    Me.cboPrioridadFiltro.ValueMember = "COD"
    '    Me.cboPrioridadFiltro.DisplayMember = "NOM"

    '    Dim dtEstadoSolicitud As New DataTable
    '    Dim dr As DataRow
    '    dtEstadoSolicitud.Columns.Add("DISPLAY")
    '    dtEstadoSolicitud.Columns.Add("VALUE")
    '    dr = dtEstadoSolicitud.NewRow
    '    dr("DISPLAY") = "Pendiente"
    '    dr("VALUE") = "P"
    '    dtEstadoSolicitud.Rows.Add(dr)
    '    ddlEstado.DisplayMember = "DISPLAY"
    '    ddlEstado.ValueMember = "VALUE"
    '    ddlEstado.DataSource = dtEstadoSolicitud
    '    ddlEstado.SelectedValue = "P"
    '    ddlEstado.ComboBox.Enabled = False

    'End Sub

    'Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
    '    Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
    '    Me.chkRangoHora.Enabled = ckbRangoFechas.Checked
    '    Me.chkRangoHora.Checked = False
    '    dtpHora_Ini.Enabled = chkRangoHora.Checked
    '    dtpHora_Fin.Enabled = chkRangoHora.Checked
    'End Sub

    Private Function Validar(ByVal NCSOTR As Decimal, ByVal PNNPLNJT As Decimal, ByVal PNNCRRPL As Decimal) As String
        Dim oDetalle_Solicitud_Transporte_BLL As New Detalle_Solicitud_Transporte_BLL
        Dim dsResultado As New DataSet
        Dim odtSolicitud As New DataTable
        Dim odtProgxSolicitud As New DataTable
        Dim objEntidad As New Detalle_Solicitud_Transporte
        objEntidad.CCMPN = _pCCMPN
        objEntidad.NCSOTR = NCSOTR
        objEntidad.NPLNJT = PNNPLNJT
        objEntidad.NCRRPL = PNNCRRPL
        Dim strValidar As String = ""
        If txtNroSolicitud.Text.Trim = "" Then
            strValidar = "Seleccione la solicitud "
        End If
        dsResultado = oDetalle_Solicitud_Transporte_BLL.Listar_Datos_Solicitud_Validacion(objEntidad)
        odtSolicitud = dsResultado.Tables(0).Copy
        odtProgxSolicitud = dsResultado.Tables(1).Copy
        Dim ActualProgramado As Decimal = 0
        Dim PendienteProgramar As Decimal = 0
        For Each Item As DataRow In odtProgxSolicitud.Rows
            ActualProgramado = ActualProgramado + Item("QANPRG")
        Next
        Dim Solicitado As Decimal = odtSolicitud.Rows(0)("QSLCIT")
        PendienteProgramar = Solicitado - ActualProgramado
        If txtQSolicitado.Text.Trim = "" OrElse txtQSolicitado.Text.Trim = "0" Then
            strValidar = strValidar & Chr(13) & "No se ha solicitado unidades"
        Else
            If txtQProgramado.Text.Trim = "" OrElse txtQProgramado.Text.Trim = "0" Then
                strValidar = strValidar & Chr(13) & "La cantidad a programar debe ser mayor a cero."
            Else
                Dim QProgramar As Decimal = txtQProgramado.Text.Trim
                If QProgramar > PendienteProgramar Then
                    strValidar = strValidar & Chr(13) & "La cantidad a programar no debe exceder" & Chr(13) & "a lo Pendiente por Programar y/o solicitado"
                End If
            End If
        End If
        Return strValidar.Trim
    End Function
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim objDetalle_Junta_Transporte As New Detalle_Junta_Transporte
            Dim oblJunta_Transporte_BLL As New Junta_Transporte_BLL
            objDetalle_Junta_Transporte.CCMPN = _pCCMPN
            objDetalle_Junta_Transporte.NPLNJT = _pNPLNJT
            objDetalle_Junta_Transporte.NCRRPL = _pNCRRPL
            objDetalle_Junta_Transporte.NCSOTR = txtNroSolicitud.Text.Trim
            objDetalle_Junta_Transporte.QANPRG = txtQProgramado.Text.Trim
            objDetalle_Junta_Transporte.CULUSA = MainModule.USUARIO
            objDetalle_Junta_Transporte.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            Dim msgVal As String = Validar(objDetalle_Junta_Transporte.NCSOTR, objDetalle_Junta_Transporte.NPLNJT, objDetalle_Junta_Transporte.NCRRPL)
            If msgVal.Length > 0 Then
                MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            oblJunta_Transporte_BLL.Guardar_Junta_Solicitud_Programado(objDetalle_Junta_Transporte)
            _MyDialogResult = True
            AsignarEstado(Estado.Neutral)
            Listar_Unidades_Programadas_x_Junta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Limpiar()
        AsignarEstado(Estado.Edicion)
    End Sub
    Private Sub Limpiar()
        txtNroSolicitud.Text = ""
        txtCliente.Text = ""
        txtTipoVehiculo.Text = ""
        txtRuta.Text = ""
        txtQSolicitado.Text = 0
        txtQProgramado.Text = 0
        txtQAtendido.Text = 0
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        AsignarEstado(Estado.Neutral)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        AsignarEstado(Estado.Edicion)
    End Sub

    'Private Sub chkRangoHora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dtpHora_Ini.Enabled = chkRangoHora.Checked
    '    dtpHora_Fin.Enabled = chkRangoHora.Checked
    'End Sub

    'Private Sub ckbUsuarioCreador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cmbUsuarioCreador.Enabled = ckbUsuarioCreador.Checked
    'End Sub

    Private Sub btnBuscaSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaSolicitud.Click
        Try
            Dim ofrmSolicitudPendiente As New frmSolPendprogramar
            ofrmSolicitudPendiente.pCCMPN = _pCCMPN
            ofrmSolicitudPendiente.pCDVSN = _pCDVSN
            ofrmSolicitudPendiente.pCPLNDV = _pCPLNDV
            ofrmSolicitudPendiente.ShowDialog()
            'If ofrmSolicitudPendiente.pNCSOTR <> 0 Then
            '    Dim oDetalle_Solicitud_Transporte_BLL As New Detalle_Solicitud_Transporte_BLL
            '    Dim dsResultado As New DataSet
            '    Dim odtSolicitud As New DataTable
            '    Dim odtProgxSolicitud As New DataTable
            '    Dim objEntidad As New Detalle_Solicitud_Transporte
            '    objEntidad.CCMPN = _pCCMPN
            '    objEntidad.NCSOTR = ofrmSolicitudPendiente.pNCSOTR
            '    objEntidad.NPLNJT = _pNPLNJT
            '    objEntidad.NCRRPL = _pNCRRPL
            '    dsResultado = oDetalle_Solicitud_Transporte_BLL.Listar_Datos_Solicitud_Validacion(objEntidad)
            '    odtSolicitud = dsResultado.Tables(0).Copy
            '    If odtSolicitud.Rows.Count > 0 Then
            '        txtNroSolicitud.Text = odtSolicitud.Rows(0)("NCSOTR")
            '        txtCliente.Text = odtSolicitud.Rows(0)("CCLNT")
            '        txtTipoVehiculo.Text = odtSolicitud.Rows(0)("CUNDVH")
            '        txtRuta.Text = odtSolicitud.Rows(0)("CLCLOR") & " -> " & odtSolicitud.Rows(0)("CLCLDS")
            '        txtQSolicitado.Text = Convert.ToDouble(odtSolicitud.Rows(0)("QSLCIT"))
            '        txtQProgramado.Text = Convert.ToDouble(odtSolicitud.Rows(0)("QANPRG_JUNTA"))
            '        txtQAtendido.Text = Convert.ToDouble(odtSolicitud.Rows(0)("QATNAN"))
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim objDetalle_Junta_Transporte As New Detalle_Junta_Transporte
            Dim oblJunta_Transporte_BLL As New Junta_Transporte_BLL
            objDetalle_Junta_Transporte.CCMPN = _pCCMPN
            objDetalle_Junta_Transporte.NPLNJT = _pNPLNJT
            objDetalle_Junta_Transporte.NCRRPL = _pNCRRPL
            objDetalle_Junta_Transporte.NCSOTR = txtNroSolicitud.Text.Trim
            objDetalle_Junta_Transporte.CULUSA = MainModule.USUARIO
            objDetalle_Junta_Transporte.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            If MessageBox.Show("Está seguro de eliminar la programación para la junta", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                oblJunta_Transporte_BLL.Eliminar_Junta_Solicitud_Programado(objDetalle_Junta_Transporte)
                _MyDialogResult = True
                Listar_Unidades_Programadas_x_Junta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

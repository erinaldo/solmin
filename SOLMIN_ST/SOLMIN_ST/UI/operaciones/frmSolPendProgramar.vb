Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data
Public Class frmSolPendprogramar
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

    'Private _pNCSOTR As Decimal = 0
    'Public Property pNCSOTR() As Decimal
    '    Get
    '        Return _pNCSOTR
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _pNCSOTR = value
    '    End Set
    'End Property

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
    Private _MyDialogResult As Boolean = False
    Public Property MyDialogResult() As Boolean
        Get
            Return _MyDialogResult
        End Get
        Set(ByVal value As Boolean)
            _MyDialogResult = value
        End Set
    End Property
    Private Sub frmSolicitudPendiente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            HeaderSolicitud.ValuesPrimary.Heading = "SOLITUDES PENDIENTES DE LA JUNTA:" & _pNPLNJT & " - " & _pNCRRPL
            dgSolicitud.AutoGenerateColumns = False
            ckbRangoFechas.Checked = True
            ckbRangoFechas_CheckedChanged(ckbRangoFechas, Nothing)
            ckbUsuarioCreador.Checked = False
            ckbUsuarioCreador_CheckedChanged(ckbUsuarioCreador, Nothing)
            CargarFiltros()
            btnBuscar_Click(btnBuscar, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            dgSolicitud.AutoGenerateColumns = False
            Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
            Dim objSolicitud As New Solicitud_Transporte
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
            If chkRangoHora.Checked = True Then
                lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
                lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
            Else
                lstr_HoraIni = 0
                lstr_HoraFin = 0
            End If
            If Me.txtSolicitud.Text.Trim.Equals("") Then
                objSolicitud.NCSOTR = 0
            Else
                objSolicitud.NCSOTR = Me.txtSolicitud.Text.Trim
            End If
            If UcCliente_TxtF011.pCodigo <> 0 Then
                objSolicitud.CCLNT = UcCliente_TxtF011.pCodigo
            Else
                objSolicitud.CCLNT = 0
            End If
            objSolicitud.NOPRCN = 0
            objSolicitud.SESSLC = ddlEstado.SelectedValue
            objSolicitud.SESTRG = "A"
            objSolicitud.FE_INI = lstr_FecIni
            objSolicitud.FE_FIN = lstr_FecFin
            objSolicitud.HR_INI = lstr_HoraIni
            objSolicitud.HR_FIN = lstr_HoraFin
            objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
            objSolicitud.CCMPN = _pCCMPN
            objSolicitud.CDVSN = _pCDVSN
            objSolicitud.CPLNDV = _pCPLNDV
            If ckbUsuarioCreador.Checked = True Then
                objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
            Else
                objSolicitud.CUSCRT = ""
            End If
            objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim
            objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue
            objSolicitud.NPLNJT = _pNPLNJT
            objSolicitud.NCRRPL = _pNCRRPL
            Dim dt As New DataTable
            dt = obj_Logica.Listar_Cliente_Solicitud_Programacion(objSolicitud)
            dgSolicitud.DataSource = dt
            For FILA As Integer = 0 To dgSolicitud.Rows.Count - 1
                dgSolicitud.Rows(FILA).Cells("CHK").Value = False
                If dgSolicitud.Rows(FILA).Cells("QPPROG").Value > 0 Then
                    dgSolicitud.Rows(FILA).Cells("CHK").ReadOnly = False
                Else
                    dgSolicitud.Rows(FILA).Cells("CHK").ReadOnly = True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Function TipoPrioridadFiltro()
        Dim oDt As New DataTable
        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")
        Dim oDr As DataRow
        oDr = oDt.NewRow
        oDr.Item("COD") = "T"
        oDr.Item("NOM") = "TODOS"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item("COD") = "N"
        oDr.Item("NOM") = "NORMAL"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item("COD") = "U"
        oDr.Item("NOM") = "URGENTE"
        oDt.Rows.Add(oDr)
        Return oDt
    End Function

    Private Sub CargarFiltros()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(_pCCMPN)

        Me.cboMedioTransporteFiltro.DataSource = objTabla.Copy
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
        cboMedioTransporteFiltro.SelectedValue = 4


        Me.cboPrioridadFiltro.DataSource = TipoPrioridadFiltro()
        Me.cboPrioridadFiltro.ValueMember = "COD"
        Me.cboPrioridadFiltro.DisplayMember = "NOM"

        Dim dtEstadoSolicitud As New DataTable
        Dim dr As DataRow
        dtEstadoSolicitud.Columns.Add("DISPLAY")
        dtEstadoSolicitud.Columns.Add("VALUE")
        dr = dtEstadoSolicitud.NewRow
        dr("DISPLAY") = "Pendiente"
        dr("VALUE") = "P"
        dtEstadoSolicitud.Rows.Add(dr)
        ddlEstado.DisplayMember = "DISPLAY"
        ddlEstado.ValueMember = "VALUE"
        ddlEstado.DataSource = dtEstadoSolicitud
        ddlEstado.SelectedValue = "P"
        ddlEstado.ComboBox.Enabled = False

    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
        Me.chkRangoHora.Enabled = ckbRangoFechas.Checked
        Me.chkRangoHora.Checked = False
        dtpHora_Ini.Enabled = chkRangoHora.Checked
        dtpHora_Fin.Enabled = chkRangoHora.Checked
    End Sub
    Private Sub chkRangoHora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRangoHora.CheckedChanged
        dtpHora_Ini.Enabled = chkRangoHora.Checked
        dtpHora_Fin.Enabled = chkRangoHora.Checked
    End Sub

    Private Sub ckbUsuarioCreador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbUsuarioCreador.CheckedChanged
        cmbUsuarioCreador.Enabled = ckbUsuarioCreador.Checked
    End Sub

    Private Function Validar() As String
        Dim msg As String = ""
        Dim check As Boolean = False
        dgSolicitud.EndEdit()
        Dim CanProgramar As String = ""
        Dim AsignacionVerificado As Boolean = True
        Dim CantSolicitado As Double = 0
        Dim CantPendprogramar As Double = 0
        For Each Item As DataGridViewRow In dgSolicitud.Rows
            If Item.Cells("CHK").Value = True Then
                check = True
                CanProgramar = ("" & Item.Cells("QPROGRAMAR").Value).ToString.Trim
                If CanProgramar.Length > 0 Then
                    CantSolicitado = Item.Cells("QSLCIT").Value
                    CantPendprogramar = Item.Cells("QPPROG").Value
                    If (Convert.ToDouble(CanProgramar) > CantSolicitado OrElse Convert.ToDouble(CanProgramar) > CantPendprogramar) Then
                        msg = "La cantidad a programar excede a lo solicitado o a lo pendiente por programar"
                    End If
                Else
                    msg = "La cantidad a programar debe ser mayor a cero."
                End If
            End If
        Next
        If check = False Then
            msg = "Debe seleccionar con check las solicitudes a programar"
        End If
        Return msg

    End Function
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If dgSolicitud.Rows.Count = 0 Then
                MessageBox.Show("No hay registro seleccionados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim msg As String = ""
            msg = Validar()
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim objDetalle_Junta_Transporte As Detalle_Junta_Transporte

            Dim pNCSOTR As Decimal = 0
            Dim oblJunta_Transporte_BLL As New Junta_Transporte_BLL
            Dim Check As Boolean = False
            Dim QProgramar As String = "0"
            For fila As Integer = 0 To dgSolicitud.Rows.Count - 1
                pNCSOTR = dgSolicitud.Rows(fila).Cells("NCSOTR").Value
                Check = dgSolicitud.Rows(fila).Cells("CHK").Value
                QProgramar = ("" & dgSolicitud.Rows(fila).Cells("QPROGRAMAR").Value).ToString.Trim
                If Check = True AndAlso QProgramar.Length > 0 AndAlso Convert.ToDouble(QProgramar) > 0 Then
                    objDetalle_Junta_Transporte = New Detalle_Junta_Transporte
                    objDetalle_Junta_Transporte.CCMPN = _pCCMPN
                    objDetalle_Junta_Transporte.NPLNJT = _pNPLNJT
                    objDetalle_Junta_Transporte.NCRRPL = _pNCRRPL
                    objDetalle_Junta_Transporte.NCSOTR = pNCSOTR
                    objDetalle_Junta_Transporte.QANPRG = Convert.ToDouble(QProgramar)
                    objDetalle_Junta_Transporte.CULUSA = MainModule.USUARIO
                    objDetalle_Junta_Transporte.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    oblJunta_Transporte_BLL.Guardar_Junta_Solicitud_Programado(objDetalle_Junta_Transporte)
                End If
            Next
            MessageBox.Show("Las solicitudes fueron programadas correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _MyDialogResult = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValidarProgramacionUnidad(ByVal sender As Object, ByVal e As EventArgs)
        Dim valorProgramar As String = CType(sender, TextBox).Text.Trim
        If dgSolicitud.Rows(FilaEdicion).Cells("CHK").Value = False Then
            dgSolicitud.Rows(FilaEdicion).Cells("QPROGRAMAR").Value = ""
            Exit Sub
        End If
        If valorProgramar.Length > 0 Then
            If Convert.ToDouble(valorProgramar) = 0 Then
                dgSolicitud.Rows(FilaEdicion).Cells("QPROGRAMAR").Value = ""
            Else
                If Convert.ToDouble(valorProgramar) > Solicitado Then
                    dgSolicitud.Rows(FilaEdicion).Cells("QPROGRAMAR").Value = ""
                    MessageBox.Show("La cantidad a programar" & Chr(13) & "excede a lo pendiente por programar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If         
        End If
    End Sub
    Dim Solicitado As Decimal = 0
    Dim FilaEdicion As Int32 = 0

    Private Sub HabilitarEdicionCantProgramar(ByVal Fila As Int32, ByVal Columna As Int32)

    End Sub

    'Private Sub dgSolicitud_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSolicitud.CellClick
    '    Dim colName As String = ""
    '    If dgSolicitud.CurrentCell.ColumnIndex > -1 Then
    '        colName = dgSolicitud.Columns(dgSolicitud.CurrentCell.ColumnIndex).Name
    '        If colName = "CHK" Then
    '            'dgSolicitud.EndEdit()
    '            'If dgSolicitud.CurrentRow.Cells("CHK").Value Then
    '            '    dgSolicitud.CurrentRow.Cells("CHK").Value = Not (dgSolicitud.CurrentRow.Cells("QPPROG").Value > 0)
    '            'End If
    '            dgSolicitud.Rows(e.RowIndex).Cells("QPROGRAMAR").ReadOnly = Not dgSolicitud.Rows(e.RowIndex).Cells("CHK").Value
    '        End If
    '    End If
    'End Sub
    Dim Habilitado As Boolean = False
    Private Sub dgSolicitud_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgSolicitud.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                RemoveHandler CType(e.Control, TextBox).Leave, AddressOf ValidarProgramacionUnidad
            End If
            colName = dgSolicitud.Columns(dgSolicitud.CurrentCell.ColumnIndex).Name
            Select Case colName
                Case "QPROGRAMAR"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-0"
                    'Habilitado = dgSolicitud.Rows(dgSolicitud.CurrentRow.Index).Cells("CHK").Value
                    'If Habilitado = False Then
                    '    Texto.Text = ""
                    'End If
                    Solicitado = dgSolicitud.Rows(dgSolicitud.CurrentRow.Index).Cells("QSLCIT").Value
                    FilaEdicion = dgSolicitud.CurrentRow.Index
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                    AddHandler CType(e.Control, TextBox).Leave, AddressOf ValidarProgramacionUnidad
            End Select
            'Dim tz As TextBox
            'AddHandler tz.Leave, AddressOf ValidarProgrmacionUnidad
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    'Private Function Validar(ByVal NCSOTR As Decimal, ByVal PNNPLNJT As Decimal, ByVal PNNCRRPL As Decimal) As String
    '    Dim oDetalle_Solicitud_Transporte_BLL As New Detalle_Solicitud_Transporte_BLL
    '    Dim dsResultado As New DataSet
    '    Dim odtSolicitud As New DataTable
    '    Dim odtProgxSolicitud As New DataTable
    '    Dim objEntidad As New Detalle_Solicitud_Transporte
    '    objEntidad.CCMPN = _pCCMPN
    '    objEntidad.NCSOTR = NCSOTR
    '    objEntidad.NPLNJT = PNNPLNJT
    '    objEntidad.NCRRPL = PNNCRRPL
    '    Dim strValidar As String = ""
    '    If txtNroSolicitud.Text.Trim = "" Then
    '        strValidar = "Seleccione la solicitud "
    '    End If
    '    dsResultado = oDetalle_Solicitud_Transporte_BLL.Listar_Datos_Solicitud_Validacion(objEntidad)
    '    odtSolicitud = dsResultado.Tables(0).Copy
    '    odtProgxSolicitud = dsResultado.Tables(1).Copy
    '    Dim ActualProgramado As Decimal = 0
    '    Dim PendienteProgramar As Decimal = 0
    '    For Each Item As DataRow In odtProgxSolicitud.Rows
    '        ActualProgramado = ActualProgramado + Item("QANPRG")
    '    Next
    '    Dim Solicitado As Decimal = odtSolicitud.Rows(0)("QSLCIT")
    '    PendienteProgramar = Solicitado - ActualProgramado
    '    If txtQSolicitado.Text.Trim = "" OrElse txtQSolicitado.Text.Trim = "0" Then
    '        strValidar = strValidar & Chr(13) & "No se ha solicitado unidades"
    '    Else
    '        If txtQProgramado.Text.Trim = "" OrElse txtQProgramado.Text.Trim = "0" Then
    '            strValidar = strValidar & Chr(13) & "La cantidad a programar debe ser mayor a cero."
    '        Else
    '            Dim QProgramar As Decimal = txtQProgramado.Text.Trim
    '            If QProgramar > PendienteProgramar Then
    '                strValidar = strValidar & Chr(13) & "La cantidad a programar no debe exceder" & Chr(13) & "a lo Pendiente por Programar y/o solicitado"
    '            End If
    '        End If
    '    End If
    '    Return strValidar.Trim
    'End Function
    'Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    '    Try
    '        Dim objDetalle_Junta_Transporte As New Detalle_Junta_Transporte
    '        Dim oblJunta_Transporte_BLL As New Junta_Transporte_BLL
    '        objDetalle_Junta_Transporte.CCMPN = _pCCMPN
    '        objDetalle_Junta_Transporte.NPLNJT = _pNPLNJT
    '        objDetalle_Junta_Transporte.NCRRPL = _pNCRRPL
    '        objDetalle_Junta_Transporte.NCSOTR = txtNroSolicitud.Text.Trim
    '        objDetalle_Junta_Transporte.QANPRG = txtQProgramado.Text.Trim
    '        objDetalle_Junta_Transporte.CULUSA = MainModule.USUARIO
    '        objDetalle_Junta_Transporte.NTRMNL = HelpClass.NombreMaquina
    '        Dim msgVal As String = Validar(objDetalle_Junta_Transporte.NCSOTR, objDetalle_Junta_Transporte.NPLNJT, objDetalle_Junta_Transporte.NCRRPL)
    '        If msgVal.Length > 0 Then
    '            MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK)
    '            Exit Sub
    '        End If
    '        oblJunta_Transporte_BLL.Guardar_Junta_Solicitud_Programado(objDetalle_Junta_Transporte)
    '        _MyDialogResult = True
    '        AsignarEstado(Estado.Neutral)
    '        Listar_Unidades_Programadas_x_Junta()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

End Class


Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario

Public Class frmBusquedaRequerimiento

    Private _pEntidadRequerimiento As AtencionRequerimiento
    Public Property pEntidadRequerimiento() As AtencionRequerimiento
        Get
            Return _pEntidadRequerimiento
        End Get
        Set(ByVal value As AtencionRequerimiento)
            _pEntidadRequerimiento = value
        End Set
    End Property

    Private _pEntidadJunta As Programacion_Unidad
    Public Property pEntidadJunta() As Programacion_Unidad
        Get
            Return _pEntidadJunta
        End Get
        Set(ByVal value As Programacion_Unidad)
            _pEntidadJunta = value
        End Set
    End Property


    Private isCheckRequerimiento As Boolean = False

    Private Sub frmBusquedaRequerimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue

            txtClienteFiltro.CCMPN = _pEntidadRequerimiento.CCMPN

            'txtClienteFiltro.pCargar(_pEntidad.CCLNT)

            dtpHoraIniReq.Enabled = False
            dtpHoraFinReq.Enabled = False
            dtpHoraIniAtencion.Enabled = False
            dtpHoraFinAtencion.Enabled = False

            Cargar_Estado()
            Cargar_Prioridad()
            'Cargar_TipoCarroceria()
            'Cargar_TipoServicio()
            'Cargar_UnidadMedida()
            'Cargar_Mercaderia()

            'Carga_TipoSolicitud()
            'Carga_TipoPrioridad()
            'Carga_MedioTransporte()

            chkFechaAtencion.Checked = False
            chkNumReq.Checked = False
            txtNroReq.Enabled = False
            chkHora.Checked = False
            chkHoraAtencion.Checked = False

            'Validad_Botones(False)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Cargar_Estado()

        Dim dtEstado As New DataTable
        Dim dr As DataRow

        dtEstado.Columns.Add("SESREQ", Type.GetType("System.String"))
        dtEstado.Columns.Add("SESREQ_S", Type.GetType("System.String"))

        'dr = dtEstado.NewRow
        'dr("SESREQ") = "0"
        'dr("SESREQ_S") = "Todos"
        'dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("SESREQ") = "P"
        dr("SESREQ_S") = "Pendiente"
        dtEstado.Rows.Add(dr)

        'dr = dtEstado.NewRow
        'dr("SESREQ") = "R"
        'dr("SESREQ_S") = "Revisado"
        'dtEstado.Rows.Add(dr)

        'dr = dtEstado.NewRow
        'dr("SESREQ") = "A"
        'dr("SESREQ_S") = "Asignado"
        'dtEstado.Rows.Add(dr)

        cmbEstado.DataSource = dtEstado
        cmbEstado.DisplayMember = "SESREQ_S"
        cmbEstado.ValueMember = "SESREQ"
        cmbEstado.SelectedValue = "P"

    End Sub

    Sub Cargar_Prioridad()

        Dim dtPrioridad As New DataTable
        Dim dr As DataRow

        dtPrioridad.Columns.Add("SPRSTR", Type.GetType("System.String"))
        dtPrioridad.Columns.Add("SPRSTR_S", Type.GetType("System.String"))

        dr = dtPrioridad.NewRow
        dr("SPRSTR") = "0"
        dr("SPRSTR_S") = "Todos"
        dtPrioridad.Rows.Add(dr)

        dr = dtPrioridad.NewRow
        dr("SPRSTR") = "N"
        dr("SPRSTR_S") = "Normal"
        dtPrioridad.Rows.Add(dr)

        dr = dtPrioridad.NewRow
        dr("SPRSTR") = "U"
        dr("SPRSTR_S") = "Urgente"
        dtPrioridad.Rows.Add(dr)

        cmbPrioridad.DataSource = dtPrioridad
        cmbPrioridad.DisplayMember = "SPRSTR_S"
        cmbPrioridad.ValueMember = "SPRSTR"
        cmbPrioridad.SelectedValue = "0"

    End Sub



    Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try

            'If txtClienteFiltro.pCodigo = 0 Then
            '    MessageBox.Show("Seleccione un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'Limpiar_Controles()

            Dim Entidad As New AtencionRequerimiento
            Dim Negocio As New JuntaRequerimiento_BLL

            dgvDatos.AutoGenerateColumns = False

            With Entidad

                .CCMPN = _pEntidadRequerimiento.CCMPN
                .CDVSN = _pEntidadRequerimiento.CDVSN
                .CPLNDV = _pEntidadRequerimiento.CPLNDV
                .SESREQ = cmbEstado.SelectedValue
                .CCLNT = txtClienteFiltro.pCodigo
                .SPRSTR = cmbPrioridad.SelectedValue

                'FECHA DE REQUERIMIENTO 


                .FECREQ_INI = CDec(String.Format("{0:yyyyMMdd}", dtpFechaInicioReq.Value))
                .FECREQ_FIN = CDec(String.Format("{0:yyyyMMdd}", dtpFechaFinReq.Value))


                If chkHora.Checked = True Then
                    .HRAREQ_INI = CDec(String.Format("{0:HHmmss}", dtpHoraIniReq.Value))
                    .HRAREQ_FIN = CDec(String.Format("{0:HHmmss}", dtpHoraFinReq.Value))
                Else
                    .HRAREQ_INI = 0D
                    .HRAREQ_FIN = 0D
                End If

                'FECHA DE REQUERIMIENTO ATENDIDO

                If chkFechaAtencion.Checked = True Then
                    .FCHATN_INI = CDec(String.Format("{0:yyyyMMdd}", dtpFechaInicioAtencion.Value))
                    .FCHATN_FIN = CDec(String.Format("{0:yyyyMMdd}", dtpFechaFinAtencion.Value))
                Else
                    .FCHATN_INI = 0D
                    .FCHATN_FIN = 0D
                End If

                If chkHoraAtencion.Checked = True Then
                    .HRAATN_INI = CDec(String.Format("{0:HHmmss}", dtpHoraIniAtencion.Value))
                    .HRAATN_FIN = CDec(String.Format("{0:HHmmss}", dtpHoraFinAtencion.Value))
                Else
                    .HRAATN_INI = 0D
                    .HRAATN_FIN = 0D
                End If


                If chkNumReq.Checked = True Then
                    .NUMREQT = CDec(Val(txtNroReq.Text))
                Else
                    .NUMREQT = 0D
                End If

                .NCSOTR = 0D
                .NPLNJT = _pEntidadJunta.NPLNJT
                .NCRRPL = _pEntidadJunta.NCRRPL

            End With

            dgvDatos.DataSource = Negocio.Lista_Requerimiento_X_Junta_RZOL48(Entidad)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Aceptar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try

            dgvDatos.EndEdit()
            Dim Fila As Int32 = 0
            Dim retorno As Int32 = 0
            Dim _Entidad As JuntaRequerimiento
            Dim ObjBLL As New JuntaRequerimiento_BLL

            If HaySeleccionRequerimiento() = True Then

                If dgvDatos.CurrentRow IsNot Nothing And dgvDatos.Rows.Count > 0 Then

                    For Fila = 0 To dgvDatos.RowCount - 1

                        If dgvDatos.Rows(Fila).Cells("CHK").Value = True Then

                            _Entidad = New JuntaRequerimiento

                            _Entidad.NPLNJT = _pEntidadJunta.NPLNJT
                            _Entidad.NCRRPL = _pEntidadJunta.NCRRPL
                            _Entidad.NUMREQT = Me.dgvDatos.Item("NUMREQT", Fila).Value.ToString().Trim()
                            _Entidad.CUSCRT = MainModule.USUARIO
                            _Entidad.NTRMCR = Environment.MachineName

                            ObjBLL.Insertar_Requerimientos_X_Junta(_Entidad)

                            Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
                            Dim objAteReq As New AtencionRequerimiento
                            objAteReq.NUMREQT = _Entidad.NUMREQT
                            objAteReq.CCMPN = Me.dgvDatos.Item("CCMPN", Fila).Value.ToString().Trim()
                            objAteReq.CUSCRT = MainModule.USUARIO
                            objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                            objAtencionRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)


                        End If
                    Next

                    Me.DialogResult = Windows.Forms.DialogResult.OK

                End If

            Else
                MessageBox.Show("Debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub chkFechaAtencion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaAtencion.CheckedChanged
        Try

            dtpFechaInicioAtencion.Enabled = chkFechaAtencion.Checked
            dtpFechaFinAtencion.Enabled = chkFechaAtencion.Checked

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHora.CheckedChanged
        Try

            dtpHoraIniReq.Enabled = chkHora.Checked
            dtpHoraFinReq.Enabled = chkHora.Checked

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHoraAtencion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHoraAtencion.CheckedChanged
        Try

            dtpHoraIniAtencion.Enabled = chkHoraAtencion.Checked
            dtpHoraFinAtencion.Enabled = chkHoraAtencion.Checked

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDatos_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDatos.ColumnHeaderMouseClick
        Try

            If dgvDatos.Columns(e.ColumnIndex).Name = "CHK" And e.RowIndex = -1 Then
                dgvDatos.EndEdit()
                isCheckRequerimiento = Not isCheckRequerimiento
                Poner_Check_Todo_Requerimiento(isCheckRequerimiento)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Poner_Check_Todo_Requerimiento(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dgvDatos.RowCount - 1
            dgvDatos.Rows(intCont).Cells("CHK").Value = blnEstado
        Next
    End Sub

    Private Function HaySeleccionRequerimiento() As Boolean
        dgvDatos.EndEdit()
        Dim intCont As Integer
        Dim HaySeleccionadosOpcion As Boolean = False
        For intCont = 0 To dgvDatos.RowCount - 1
            If dgvDatos.Rows(intCont).Cells("CHK").Value = True Then
                HaySeleccionadosOpcion = True
                Exit For
            End If
        Next
        Return HaySeleccionadosOpcion
    End Function

    Private Sub chkNumReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNumReq.CheckedChanged
        Try
            dtpFechaInicioReq.Enabled = Not chkNumReq.Checked
            dtpFechaFinReq.Enabled = Not chkNumReq.Checked
            txtNroReq.Enabled = chkNumReq.Checked

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNroReq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroReq.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

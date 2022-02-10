Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad

Public Class frmNotificacionChekckPoints
    Private oCheckPoint As clsCheckPoint
    Public Division As String = ""
    Public objNoficacion As New beSegNotificacion
    Public Modificar As Boolean

    Private Sub frmNotificacionChekckPoints_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'frmNotificacionChekckPoints.ControlBox = False
        CargarNotificar()
        CargarVisualizar()
        CargarTipoCheckMantenimiento()
        If Modificar Then
            CargarDatos(objNoficacion)
            HabilitarControles(True)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
 
    'Private Sub cmbTipoCheckpoint_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCheckpoint.SelectionChangeCommitted
    '  Cargar_Checkpoint(Nothing, Nothing)
    'End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            Dim Mensaje As String = ""
            If ValidarControles(Mensaje) Then
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim brSegNotificacion As New Negocio.clsSegNotificacion
            Dim dt As New DataTable
            Dim beSegNotificacion As beSegNotificacion
            beSegNotificacion = New beSegNotificacion
            With beSegNotificacion
                .PSCCMPN = objNoficacion.PSCCMPN
                .PSCDVSN = objNoficacion.PSCDVSN
                .PNCCLNT = objNoficacion.PNCCLNT
                .PSNLTECL = objNoficacion.PSNLTECL
                .PSCODFMT = objNoficacion.PSCODFMT.Trim
                .PNNESTDO = CType(UcCheckpoint.Resultado, beCheckPoint).PNNESTDO
                .PSTCOLUM = txtDescripNotificacion.Text.Trim
                .PNNSEPRE = txtOrden.txtDecimales.Text
                .PSCFMCHK = ""
                .PSFLGEST = cmbVisualizar.SelectedValue
                .PSFLGNTE = cmbNotificar.SelectedValue
                .PSCULUSA = HelpUtil.UserName
                .PNCFCHK = objNoficacion.PNCFCHK
            End With
            Dim msg As String = ""
            If Modificar Then
                brSegNotificacion.ModificarCheckPointsNotificacionEmail(beSegNotificacion)
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                msg = brSegNotificacion.RegistarCheckPointsNotificacionEmail(beSegNotificacion)
                If msg.Length > 0 Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub

    Private Sub UcCheckpoint_CambioDeTexto(ByVal objData As System.Object) Handles UcCheckpoint.CambioDeTexto
        Try
            If Not UcCheckpoint.Resultado Is Nothing Then
                txtDescripNotificacion.Text = CType(UcCheckpoint.Resultado, beCheckPoint).PSTDESES.Trim
                txtOrden.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

#Region "Metodos y Funciones"

    Private Sub CargarTipoCheckMantenimiento()
        Dim dtCheckPoint As New DataTable
        oCheckPoint = New clsCheckPoint()
        dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint(-1)
        cmbTipoCheckpoint.DataSource = dtCheckPoint
        cmbTipoCheckpoint.ValueMember = "VALVAR"
        cmbTipoCheckpoint.DisplayMember = "NOMVAR"
        'cmbTipoCheckpoint.SelectedValue = "" 
        cmbTipoCheckpoint.SelectedValue = "A" 'ADUANA
        Cargar_Checkpoint(Nothing, Nothing)
    End Sub

    Private Sub Cargar_Checkpoint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCheckpoint.SelectionChangeCommitted
        Dim beCheck As beCheckPoint
        Dim Lista As List(Of beCheckPoint)
        Lista = New List(Of beCheckPoint)
        Dim dtCheckpointDivision As New DataTable
        dtCheckpointDivision = oCheckPoint.Lista_CheckPoint_X_Division(objNoficacion.PSCDVSN)
        For Each dr As DataRow In dtCheckpointDivision.Rows
            beCheck = New beCheckPoint
            If objNoficacion.PSCDVSN = "S" Then
                If cmbTipoCheckpoint.SelectedValue = dr("CEMB") Then
                    beCheck.PNNESTDO = dr("NESTDO")
                    beCheck.PSTDESES = dr("TDESES")
                    Lista.Add(beCheck)
                End If
            Else
                beCheck.PNNESTDO = dr("NESTDO")
                beCheck.PSTDESES = dr("TDESES")
                Lista.Add(beCheck)
            End If
        Next
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PNNESTDO"
        oColumnas.DataPropertyName = "PNNESTDO"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTDESES"
        oColumnas.DataPropertyName = "PSTDESES"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        If Lista.Count > 0 Then
            UcCheckpoint.DataSource = Lista
        Else
            UcCheckpoint.DataSource = Nothing
        End If
        UcCheckpoint.ListColumnas = oListColum
        UcCheckpoint.Cargas()
        UcCheckpoint.Limpiar()
        UcCheckpoint.ValueMember = "PNNESTDO"
        UcCheckpoint.DispleyMember = "PSTDESES"
    End Sub

    Private Sub CargarVisualizar()
        Dim dt As New DataTable

        dt.Columns.Add("CODIGO", Type.GetType("System.String"))
        dt.Columns.Add("DESCRIP", Type.GetType("System.String"))

        Dim dr As DataRow = dt.NewRow
        dr("CODIGO") = "R"
        dr("DESCRIP") = "Real"
        dt.Rows.Add(dr)

        Dim dr1 As DataRow = dt.NewRow
        dr1("CODIGO") = "E"
        dr1("DESCRIP") = "Estimado"
        dt.Rows.Add(dr1)

        cmbVisualizar.DataSource = dt
        cmbVisualizar.ValueMember = "CODIGO"
        cmbVisualizar.DisplayMember = "DESCRIP"

    End Sub

    Private Sub CargarNotificar()
        Dim dt As New DataTable

        dt.Columns.Add("CODIGO", Type.GetType("System.String"))
        dt.Columns.Add("DESCRIP", Type.GetType("System.String"))

        Dim dr As DataRow = dt.NewRow
        dr("CODIGO") = "R"
        dr("DESCRIP") = "Real"
        dt.Rows.Add(dr)

        Dim dr1 As DataRow = dt.NewRow
        dr1("CODIGO") = "E"
        dr1("DESCRIP") = "Estimado"
        dt.Rows.Add(dr1)

        Dim dr2 As DataRow = dt.NewRow
        dr2("CODIGO") = "T"
        dr2("DESCRIP") = "Todos"
        dt.Rows.Add(dr2)

        cmbNotificar.DataSource = dt
        cmbNotificar.ValueMember = "CODIGO"
        cmbNotificar.DisplayMember = "DESCRIP"

    End Sub

    Private Sub CargarDatos(ByVal obeSegNotificacion As beSegNotificacion)
        cmbTipoCheckpoint.SelectedValue = obeSegNotificacion.CEMB
        Cargar_Checkpoint(Nothing, Nothing)
        UcCheckpoint.Valor = obeSegNotificacion.PNNESTDO
        txtDescripNotificacion.Text = obeSegNotificacion.PSTCOLUM
        cmbVisualizar.SelectedValue = obeSegNotificacion.PSFLGEST
        cmbNotificar.SelectedValue = obeSegNotificacion.PSFLGNTE
        txtOrden.txtDecimales.Text = obeSegNotificacion.PNNSEPRE
        txtDescripNotificacion.Focus()
    End Sub

    Private Sub HabilitarControles(ByVal Estado As Boolean)
        cmbTipoCheckpoint.Enabled = Not (Estado)
        UcCheckpoint.Enabled = Not (Estado)
        txtDescripNotificacion.Enabled = Estado
        cmbVisualizar.Enabled = Estado
        cmbNotificar.Enabled = Estado
        txtOrden.Enabled = Estado
    End Sub

    Private Function ValidarControles(ByRef Mensaje As String) As Boolean
        Dim Respuesta As Boolean = False
        If cmbTipoCheckpoint.SelectedValue = "" Then
            Mensaje = "Seleccione CheckPoint" & Environment.NewLine
        End If
        If UcCheckpoint.Resultado Is Nothing Then
            Mensaje = Mensaje & "Seleccione CheckPoint" & Environment.NewLine
        End If

        If txtDescripNotificacion.Text.Trim = "" Then
            Mensaje = Mensaje & "Ingrese una Descripción" & Environment.NewLine
        End If

        If txtOrden.txtDecimales.Text.Trim = "" Then
            Mensaje = Mensaje & "Ingrese Orden" & Environment.NewLine
        End If

        If Mensaje.Length > 0 Then
            Respuesta = True
        End If

        Return Respuesta
    End Function

#End Region

   
End Class

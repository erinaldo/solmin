Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Moneda
Imports Ransa.Utilitario

Public Class frmRegistroIncidencias
    Public _CCMPN As String
    Public _NRUCTR As String
    Public _NGUITR As Decimal
    Private Nuevo As Boolean
    Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL

    Private Sub frmRegistroIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Listar_EvaluacionOperativa()
        cargarCategoria()
        Asignar_Datos()
        EstadoBotones(False, 1)

        'If dgvIncidecias_EVO.RowCount > 0 Then
        '    btnModificarIncidencia.Enabled = True
        'Else
        '    btnModificarIncidencia.Enabled = False
        'End If

    End Sub

    Private Sub btnNuevoIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoIncidencia.Click
        Nuevo = True
        btnNuevoIncidencia.Enabled = False
        EstadoBotones(True, 2)
        Limpiar_Controles()
    End Sub

    Private Sub btnCancelarIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarIncidencia.Click
        EstadoBotones(False, 1)
        Nuevo = False
        If dgvIncidecias_EVO.Rows.Count > 0 Then
            Listar_EvaluacionOperativa()
            Asignar_Datos()
        End If
    End Sub

    Private Sub btnGuardarIncidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarIncidente.Click
        Try
            If Nuevo = True Then
                GrabarIncidencia()
                Nuevo = False
            Else
                ModificarIncidencia()
                Nuevo = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvIncidecias_EVO_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIncidecias_EVO.CellClick
        Try
            Asignar_Datos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarIncidencia.Click
        Try
            Dim Entidad As New EvaluacionOperativa
            If dgvIncidecias_EVO.Rows.Count > 0 Then
                Dim lista As New List(Of EvaluacionOperativa)
                With Entidad
                    .CCMPN = _CCMPN
                    .NSEQIN = dgvIncidecias_EVO.CurrentRow.Cells("NSEQIN").Value
                    .CULUSA = MainModule.USUARIO
                    .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                End With
                lista.Add(Entidad)
                If MessageBox.Show("¿Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    ObjNegocioEvalOperativa.Eliminar_Evaluacion_Operacion(lista)
                    Listar_EvaluacionOperativa()
                    MessageBox.Show("El registro se eliminó satisfactoriamente.")
                End If
            Else
                MessageBox.Show("No hay registros. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificarIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarIncidencia.Click
        If dgvIncidecias_EVO.Rows.Count > 0 Then
            EstadoBotones(True, 2)
            Nuevo = False
        Else
            MessageBox.Show("Seleccione un registro ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        

    End Sub

#Region "METODOS"

    Public Sub cargarIncidencia(ByVal objEntidad As GuiaTransportista)
        txtProveedor.Text = objEntidad.TCMTRT
        txtOperacion.Text = objEntidad.NOPRCN

    End Sub

    Public Sub Listar_EvaluacionOperativa()
        Dim Entidad As New EvaluacionOperativa
        Entidad.CCMPN = _CCMPN
        Entidad.NOPRCN = Convert.ToDecimal(txtOperacion.Text)
        dgvIncidecias_EVO.AutoGenerateColumns = False
        Dim oList As New List(Of EvaluacionOperativa)
        oList = ObjNegocioEvalOperativa.Listar_Evaluacion_Operativa(Entidad)
        'Dim lista2 As New List(Of EvaluacionOperativa)
        'For Each Lista As EvaluacionOperativa In oList
        '    If Lista.NRUCTR = _NRUCTR And Lista.NOPRCN = Convert.ToDecimal(txtOperacion.Text) Then
        '        lista2.Add(Lista)
        '    End If
        'Next
        dgvIncidecias_EVO.DataSource = oList
        If dgvIncidecias_EVO.RowCount = 0 Then
            Limpiar_Controles()
        End If
    End Sub

    Public Sub cargarCategoria()

        Try
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            cboMcategoria.DataSource = ObjNegocioEvalOperativa.Listar_categorias(1, _CCMPN)
            cboMcategoria.ValueMember = "CODCAT"
            cboMcategoria.DisplayMember = "DESCAT"
            cargarSubCategoria(cboMcategoria.SelectedValue)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub cargarSubCategoria(ByVal Categoria As Integer)
        Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
        cboMSubacategoria.DataSource = ObjNegocioEvalOperativa.Listar_Subcategorias(1, Categoria, _CCMPN)
        cboMSubacategoria.ValueMember = "CODSCT"
        cboMSubacategoria.DisplayMember = "DESSCT"

    End Sub

    Private Sub Asignar_Datos()
        Dim lint_Indice As Integer = Me.dgvIncidecias_EVO.CurrentCellAddress.Y
        If Me.dgvIncidecias_EVO.Rows.Count > 0 Then
            Limpiar_Controles()
            Me.dtpFechaIncidencia.Value = Me.dgvIncidecias_EVO.Item("FOPRCN_S", lint_Indice).Value.ToString().Trim()
            Me.cboMcategoria.SelectedValue = Me.dgvIncidecias_EVO.Item("CODCAT", lint_Indice).Value.ToString().Trim()
            cargarSubCategoria(cboMcategoria.SelectedValue)
            Me.txtNroIncidencia.Text = Me.dgvIncidecias_EVO.Item("NSEQIN", lint_Indice).Value.ToString().Trim()
            Me.cboMSubacategoria.SelectedValue = Me.dgvIncidecias_EVO.Item("CODSCT", lint_Indice).Value.ToString().Trim()
            Me.ndCantidadIncidencia.Value = Me.dgvIncidecias_EVO.Item("QAINSM", lint_Indice).Value.ToString().Trim()
            Me.txtObeservacionIncidencia.Text = Me.dgvIncidecias_EVO.Item("TOBS", lint_Indice).Value.ToString().Trim()
        Else
            'Me.dgvIncidecias_EVO.CurrentRow.Selected = False
            Exit Sub
        End If
    End Sub

    Private Sub EstadoBotones(ByVal estado As Boolean, ByVal Btn As Integer)
        btnModificarIncidencia.Enabled = IIf(Btn = 2, False, True)
        'btnEliminarIncidencia.Enabled = IIf(Btn = 1, False, True)
        btnNuevoIncidencia.Enabled = IIf(Btn = 2, False, True)
        btnCancelarIncidencia.Enabled = estado
        btnGuardarIncidente.Enabled = estado
        txtObeservacionIncidencia.Enabled = estado
        'txtNroIncidencia.Enabled = estado
        cboMcategoria.Enabled = estado
        cboMSubacategoria.Enabled = estado
        dtpFechaIncidencia.Enabled = estado
    End Sub

    Public Sub Limpiar_Controles()
        txtNroIncidencia.Text = ""
        txtObeservacionIncidencia.Text = ""
        cboMcategoria.SelectedValue = 1
        cargarSubCategoria(cboMcategoria.SelectedValue)
        dtpFechaIncidencia.Value = Date.Now
    End Sub
    Private Sub ModificarIncidencia()
        Try
            Dim Entidad As New EvaluacionOperativa
            If dgvIncidecias_EVO.Rows.Count < 0 Then
                MessageBox.Show("Debe de seleccionar un registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim lista As New List(Of EvaluacionOperativa)
                With Entidad
                    .CCMPN = _CCMPN
                    .NSEQIN = dgvIncidecias_EVO.CurrentRow.Cells("NSEQIN").Value
                    .CODCAT = cboMcategoria.SelectedValue
                    .CODSCT = cboMSubacategoria.SelectedValue
                    .FOPRCN = HelpClass.CDate_a_Numero8Digitos(dtpFechaIncidencia.Value)
                    .QAINSM = ndCantidadIncidencia.Value
                    .TOBS = txtObeservacionIncidencia.Text
                    .CULUSA = MainModule.USUARIO
                    .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                End With
                lista.Add(Entidad)
                ObjNegocioEvalOperativa.Actualizar_Evaluacion_Operacion(lista)
                Listar_EvaluacionOperativa()
                Asignar_Datos()
                EstadoBotones(False, 1)
                MessageBox.Show("El registro se Actualizo satisfactoriamente.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GrabarIncidencia()
        Dim Entidad As New EvaluacionOperativa
        Dim lista As New List(Of EvaluacionOperativa)
        With Entidad
            .CCMPN = _CCMPN
            .NRUCTR = _NRUCTR
            .CODCAT = cboMcategoria.SelectedValue
            .CODSCT = cboMSubacategoria.SelectedValue
            .FOPRCN = HelpClass.CDate_a_Numero8Digitos(dtpFechaIncidencia.Value)
            .NOPRCN = txtOperacion.Text.Trim
            .NGUITR = _NGUITR
            .QAINSM = ndCantidadIncidencia.Value
            .TOBS = txtObeservacionIncidencia.Text
            .CUSCRT = MainModule.USUARIO
            .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        End With
        lista.Add(Entidad)
        ObjNegocioEvalOperativa.Registrar_Evaluacion_Operacion(lista)
        Listar_EvaluacionOperativa()
        Asignar_Datos()
        EstadoBotones(False, 1)
        MessageBox.Show("El registro se registro satisfactoriamente.")
    End Sub
#End Region

    Private Sub cboMcategoria_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMcategoria.SelectionChangeCommitted
        Try
            Dim CODCAT As Integer = Convert.ToInt32(cboMcategoria.SelectedValue)
            cargarSubCategoria(CODCAT)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " " & ex.Source)
        End Try
    End Sub

End Class

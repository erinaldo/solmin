Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports Ransa.Utilitario

Public Class frmProveedorRecurso
#Region " Atributos "
    Private objProveedorBLL As New Proveedor_BLL
    Private objTransportistaBLL As New Transportista_BLL
#End Region
#Region " Eventos "
    Private Sub frmProveedorRecurso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar_Compania()
            KryptonCheckBox1.Checked = False
            KryptonCheckBox1_CheckedChanged(Nothing, Nothing)
            'Me.Cargar_Tipo_Proveedor()
            'Cargar_Estado()
            Cargar_Tipo_Recurso()
            Cargar_Asignación()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Listar_Proveedor()
            If Me.gwdDatos.RowCount > 0 Then Me.gwdDatos.CurrentRow.Selected = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "T"
            End If
            cmbDivision.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtRUC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC.KeyPress
        Try
            If e.KeyChar = "." Then
                e.Handled = True
                Exit Sub
            End If
            If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    '    Try
    '        If e.RowIndex < 0 Then Exit Sub
    '        'Me.gwdUnidAlquiler.Rows.Clear()
    '        Listar_Unidades_Alquiler()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub gwdDatos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    '    Try
    '        If Me.gwdDatos.RowCount = 0 Then Exit Sub
    '        Select Case e.KeyCode
    '            Case Keys.Enter, Keys.Up, Keys.Down
    '                Me.gwdUnidAlquiler.Rows.Clear()
    '                Me.Listar_Unidades_Alquiler()
    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        Try
            If (gwdDatos.CurrentRow Is Nothing) Then
                Exit Sub
            End If
            Dim Columna As String = gwdDatos.Columns(e.ColumnIndex).Name

            If Columna = "ESTADO_HOMOLOGACION" Then
                Dim strResultado As String = Validar_Proveedor_Homologado()
                If strResultado.Trim = "" Then
                    strResultado = "Apto"
                    Me.gwdDatos.Item("ESTADO_HOMOLOGACION", gwdDatos.CurrentCellAddress.Y).Value = My.Resources.button_ok1
                Else
                    Me.gwdDatos.Item("ESTADO_HOMOLOGACION", gwdDatos.CurrentCellAddress.Y).Value = My.Resources.button_cancel
                End If
                HelpClass.MsgBox("Estado Homologación : " & strResultado, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Dim fNuevoAsigProveedor As frmNuevoAsignacionProveedorRecurso
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If gwdDatos.CurrentRow.Cells("SESTRG").Value = "*" Then
                MessageBox.Show("No se puede agregar Unidad para Alquiler a un Proveedor Anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                fNuevoAsigProveedor = New frmNuevoAsignacionProveedorRecurso(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division, gwdDatos.CurrentRow.Cells("NRUCTR").Value, gwdDatos.CurrentRow.Cells("TCMTRT").Value)
                If fNuevoAsigProveedor.ShowDialog = Windows.Forms.DialogResult.Yes Then
                    Listar_Unidades_Alquiler()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscarUndAlq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarUndAlq.Click
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Listar_Unidades_Alquiler()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.gwdUnidAlquiler.RowCount = 0 OrElse Me.gwdUnidAlquiler.CurrentCellAddress.Y < 0 OrElse Me.gwdUnidAlquiler.CurrentRow.Selected = False Then Exit Sub
            If gwdDatos.CurrentRow.Cells("SESTRG").Value = "*" Then
                MessageBox.Show("No se puede agregar Unidad para Alquiler a un Proveedor Anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MsgBox("Desea Eliminar esta Unidad", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                Me.Eliminar_Unidades_Alquiler()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#Region " Procedimiento "
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    'Private Sub Cargar_Tipo_Proveedor()
    '    cmbTipoProveedor.DataSource = objProveedorBLL.Listar_Tipos(cmbCompania.CCMPN_CodigoCompania, "TIPROV")
    '    cmbTipoProveedor.ValueMember = "CCMPRN"
    '    cmbTipoProveedor.DisplayMember = "TDSDES"
    '    cmbTipoProveedor.SelectedValue = "T"
    'End Sub

    'Private Sub Cargar_Estado()
    '    Dim dtEstado As New DataTable
    '    dtEstado.Columns.Add("VALUE")
    '    dtEstado.Columns.Add("DISPLAY")

    '    Dim dr As DataRow

    '    dr = dtEstado.NewRow
    '    dr("DISPLAY") = "ACTIVO"
    '    dr("VALUE") = "A"
    '    dtEstado.Rows.Add(dr)

    '    dr = dtEstado.NewRow
    '    dr("DISPLAY") = "ANULADO"
    '    dr("VALUE") = "*"
    '    dtEstado.Rows.Add(dr)

    '    cmbEstado.DataSource = dtEstado
    '    cmbEstado.ValueMember = "VALUE"
    '    cmbEstado.DisplayMember = "DISPLAY"
    '    cmbEstado.SelectedValue = "A"
    'End Sub

    Private Sub Cargar_Tipo_Recurso()
        'Dim oDt As New DataTable
        'oDt.Columns.Add("CCMPRN")
        'oDt.Columns.Add("TDSDES")

        Dim dtTipoRecurso As New DataTable


        'Dim dr As DataRow
        'dr = oDt.NewRow
        'dr("CCMPRN") = "*"
        'dr("TDSDES") = "TODOS"
        'oDt.Rows.Add(dr)

        'For Each oDr As DataRow In objProveedorBLL.Listar_Tipos(cmbCompania.CCMPN_CodigoCompania, "TIRSO").Rows
        '    dr = oDt.NewRow
        '    dr("CCMPRN") = oDr("CCMPRN")
        '    dr("TDSDES") = oDr("TDSDES")
        '    oDt.Rows.Add(dr)
        'Next

        'Dim olstProv As New List(Of Proveedor)
        'Dim beProveedor As New Proveedor
        'beProveedor.CCMPRN = "*"
        'beProveedor.TDSDES = "TODOS"
        'olstProv.Add(beProveedor)
        dtTipoRecurso = objProveedorBLL.Listar_Tipos(cmbCompania.CCMPN_CodigoCompania, "TIRSO")

        Dim dtTipoRecFiltro As New DataTable
        dtTipoRecFiltro = dtTipoRecurso.Copy

        Dim dr As DataRow
        dr = dtTipoRecurso.NewRow
        dr("CCMPRN") = "*"
        dr("TDSDES") = "TODOS"
        dtTipoRecurso.Rows.InsertAt(dr, 0)

        'For Each beEntidad As Proveedor In objProveedorBLL.Listar_Tipos(cmbCompania.CCMPN_CodigoCompania, "TIRSO")
        '    Dim beProv As New Proveedor
        '    beProv.CCMPRN = beEntidad.CCMPRN
        '    beProv.TDSDES = beEntidad.TDSDES
        '    olstProv.Add(beProv)
        'Next
        cmbTipoRecurso.DataSource = dtTipoRecurso
        cmbTipoRecurso.ValueMember = "CCMPRN"
        cmbTipoRecurso.DisplayMember = "TDSDES"
        cmbTipoRecurso.SelectedValue = "*"

        KryptonComboBox2.DataSource = dtTipoRecFiltro
        KryptonComboBox2.ValueMember = "CCMPRN"
        KryptonComboBox2.DisplayMember = "TDSDES"
        KryptonComboBox2.SelectedValue = "T"


        'KryptonTextBox1
        'KryptonComboBox2
        'cmbTipoRecursoFiltro.DataSource = oDt.Copy
        'cmbTipoRecursoFiltro.ValueMember = "CCMPRN"
        'cmbTipoRecursoFiltro.DisplayMember = "TDSDES"
        'cmbTipoRecursoFiltro.SelectedValue = "*"

    End Sub

    Private Sub Cargar_Asignación()
        Dim dtAsignacion As New DataTable
        dtAsignacion.Columns.Add("VALUE")
        dtAsignacion.Columns.Add("DISPLAY")

        Dim dr As DataRow

        dr = dtAsignacion.NewRow
        dr("DISPLAY") = "ASIGNADO"
        dr("VALUE") = "A"
        dtAsignacion.Rows.Add(dr)

        'dr = dtAsignacion.NewRow
        'dr("DISPLAY") = "NO ASIGNADO"
        'dr("VALUE") = "*"
        'dtAsignacion.Rows.Add(dr)

        cmbAsignacion.DataSource = dtAsignacion
        cmbAsignacion.ValueMember = "VALUE"
        cmbAsignacion.DisplayMember = "DISPLAY"
        cmbAsignacion.SelectedValue = "A"
        cmbAsignacion.ComboBox.Enabled = False
    End Sub

    Private Sub Listar_Proveedor()
        gwdUnidAlquiler.DataSource = Nothing
        gwdDatos.DataSource = Nothing
        Dim objEntidad As New Transportista
        objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
        objEntidad.NRUCTR = txtRUC.Text.Trim
        objEntidad.TCMTRT = txtRazonSocial.Text.Trim
        'objEntidad.SINDRC = cmbTipoProveedor.SelectedValue.ToString.Trim
        'objEntidad.SESTRG = cmbEstado.SelectedValue
        objEntidad.SESTRG = "A"
        objEntidad.FLARSO = "S"

        If KryptonCheckBox1.Checked = True Then
            objEntidad.TipoRecurso = ("" & KryptonComboBox2.SelectedValue).ToString.Trim
            objEntidad.Placa = KryptonTextBox1.Text.Trim
        Else
            objEntidad.TipoRecurso = ""
            objEntidad.Placa = ""
        End If
   


        gwdDatos.AutoGenerateColumns = False
        gwdDatos.DataSource = objTransportistaBLL.Listar_Proveedor(objEntidad)
        If gwdDatos.Rows.Count = 0 Then
            gwdUnidAlquiler.DataSource = Nothing
        End If

    End Sub

    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        objHashTable.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        objHashTable.Add("NRUCTR", Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function

    Private Sub Listar_Unidades_Alquiler()
        Dim objProveedorAlquiler As New Proveedor
        objProveedorAlquiler.CCMPN = cmbCompania.CCMPN_CodigoCompania
        objProveedorAlquiler.NRUCTR = gwdDatos.CurrentRow.Cells("NRUCTR").Value
        objProveedorAlquiler.STPRCS = cmbTipoRecurso.SelectedValue.ToString.Trim
        objProveedorAlquiler.NPLRCS = txtPlaca.Text.Trim
        objProveedorAlquiler.SESRCS = cmbAsignacion.SelectedValue
        gwdUnidAlquiler.AutoGenerateColumns = False
        gwdUnidAlquiler.DataSource = objProveedorBLL.Listar_Proveedores_Alquiler(objProveedorAlquiler)
    End Sub

    Private Sub Eliminar_Unidades_Alquiler()
        Dim objEntidad As New Proveedor
        objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
        objEntidad.NRUCTR = gwdDatos.CurrentRow.Cells("NRUCTR").Value
        objEntidad.STPRCS = gwdUnidAlquiler.CurrentRow.Cells("STPRCS").Value ''STPRCS
        objEntidad.NPLRCS = gwdUnidAlquiler.CurrentRow.Cells("NPLRCS").Value ''txtPlaca.Text.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        If objProveedorBLL.Eliminar_Asignacion_Proveedor_Recurso(objEntidad) = 1 Then
            MessageBox.Show("Se eliminó satifactoriamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Listar_Unidades_Alquiler()
        End If
    End Sub

#End Region

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If (gwdDatos.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim oHasColumnas As New Hashtable
            Dim odtDatoExportar As New DataTable
            odtDatoExportar.TableName = "Proveedor - Recursos"
            Dim dr As DataRow
            Dim oListExportar As New List(Of DataTable)
            Dim NameColumna As String = ""
            For Columna As Integer = 0 To gwdDatos.Columns.Count - 1
                NameColumna = gwdDatos.Columns(Columna).Name
                If (gwdDatos.Columns(Columna).Visible = True And gwdDatos.Columns(Columna).Name <> "ESTADO_HOMOLOGACION") Then
                    odtDatoExportar.Columns.Add(NameColumna)
                    oHasColumnas(NameColumna) = gwdDatos.Columns(Columna).HeaderText
                End If
            Next
            For Fila As Integer = 0 To gwdDatos.Rows.Count - 1
                dr = odtDatoExportar.NewRow
                For Columna As Integer = 0 To odtDatoExportar.Columns.Count - 1
                    NameColumna = odtDatoExportar.Columns(Columna).ColumnName
                    If (gwdDatos.Rows(Fila).Cells(NameColumna).Value IsNot Nothing) Then
                        dr(NameColumna) = gwdDatos.Rows(Fila).Cells(NameColumna).FormattedValue
                    End If
                Next
                odtDatoExportar.Rows.Add(dr)
            Next
            For Columna As Integer = 0 To odtDatoExportar.Columns.Count - 1
                NameColumna = odtDatoExportar.Columns(Columna).ColumnName
                odtDatoExportar.Columns(Columna).ColumnName = oHasColumnas(NameColumna)
            Next
            oListExportar.Add(odtDatoExportar)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oListExportar, "Lista de Proveedores")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportarUnidades_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportarUnidades.Click
        Try
            If (gwdUnidAlquiler.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim MdataColumna As String = ""
            Dim NPOI As New HelpClass_NPOI_ST
            Dim dtResumen As New DataTable
            dtResumen.Columns.Add("TDSDES").Caption = NPOI.FormatDato("Tipo Recurso", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPLRCS").Caption = NPOI.FormatDato("Placa", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("MARCA").Caption = NPOI.FormatDato("Marca", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TIPO_UNIDAD").Caption = NPOI.FormatDato("Tipo Unidad", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("FECINI_S").Caption = NPOI.FormatDato("Fecha Inicio Asignación", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FECFIN_S").Caption = NPOI.FormatDato("Fecha Fin Asignación", HelpClass_NPOI_ST.keyDatoFecha)

            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Fila As Integer = 0 To gwdUnidAlquiler.Rows.Count - 1
                dr = dtResumen.NewRow
                For Each Col As DataColumn In dtResumen.Columns
                    NameColumna = Col.ColumnName
                    dr(NameColumna) = gwdUnidAlquiler.Rows(Fila).Cells(NameColumna).Value
                Next
                dtResumen.Rows.Add(dr)
            Next

            Dim oListDtReport As New List(Of DataTable)
            dtResumen.TableName = "Proveedor - Recursos"
            oListDtReport.Add(dtResumen.Copy)

            Dim ListTitulo As New List(Of String)
            Dim LisFiltros As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "Código:| " & gwdDatos.CurrentRow.Cells("CTRSPT").Value)
            F.Add(2, "RUC:| " & gwdDatos.CurrentRow.Cells("NRUCTR").Value)
            F.Add(3, "Razón Social:| " & gwdDatos.CurrentRow.Cells("TCMTRT").Value)
            F.Add(4, "Dirección:| " & gwdDatos.CurrentRow.Cells("TDRCTR").Value)
            F.Add(5, "Cuenta Acreedora SAP:| " & gwdDatos.CurrentRow.Cells("RUCPR2").Value)
            LisFiltros.Add(F)

            ListTitulo.Add("UNIDADES PARA ALQUILER")

            NPOI.ExportExcelGeneralMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            'Me.gwdUnidAlquiler.Rows.Clear()
            Listar_Unidades_Alquiler()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevoProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProv.Click
        Try
            Dim fAsignarRecursoProveedor As frmAsignarRecursoProveedor
            fAsignarRecursoProveedor = New frmAsignarRecursoProveedor(cmbCompania.CCMPN_CodigoCompania)

            If fAsignarRecursoProveedor.ShowDialog = Windows.Forms.DialogResult.Yes Then
                Listar_Proveedor()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.Click
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If MsgBox("Desea Eliminar Proveedor?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub

            Dim objProveedorAlquiler As New Proveedor
            objProveedorAlquiler.CCMPN = cmbCompania.CCMPN_CodigoCompania
            objProveedorAlquiler.NRUCTR = gwdDatos.CurrentRow.Cells("NRUCTR").Value
            objProveedorAlquiler.STPRCS = "T"
            objProveedorAlquiler.NPLRCS = ""
            objProveedorAlquiler.SESRCS = cmbAsignacion.SelectedValue

            If objProveedorBLL.Listar_Proveedores_Alquiler(objProveedorAlquiler).Count = 0 Then
                Dim objTransportistaBLL As New Transportista_BLL
                Dim objEntidad As New Transportista
                objEntidad.NRUCTR = gwdDatos.CurrentRow.Cells("NRUCTR").Value
                objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
                objEntidad.FLARSO = ""
                objTransportistaBLL.Actualizar_Flag_Recurso_Proveedor(objEntidad)
                MessageBox.Show("Proveedor eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Listar_Proveedor()
            Else
                MessageBox.Show("Proveedor tiene recursos asignados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdUnidAlquiler_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdUnidAlquiler.CellContentDoubleClick
        Try
            Dim ccmpn As String = ("" & gwdUnidAlquiler.CurrentRow.Cells("CCMPN_1").Value).ToString.Trim
            Dim cdvsn As String = ("" & gwdUnidAlquiler.CurrentRow.Cells("CDVSN").Value).ToString.Trim
            Dim _TIPO_RECURSO As String = ("" & gwdUnidAlquiler.CurrentRow.Cells("STPRCS").Value).ToString.Trim
            Dim _PLACA As String = ("" & gwdUnidAlquiler.CurrentRow.Cells("NPLRCS").Value).ToString.Trim
            Dim ofrmUnidAsignacion As New frmUnidadesAsignacion
            ofrmUnidAsignacion.ccmpn = ccmpn
            ofrmUnidAsignacion.cdvsn = cdvsn
            ofrmUnidAsignacion.TIPO_RECURSO = _TIPO_RECURSO
            ofrmUnidAsignacion.PLACA = _PLACA
            ofrmUnidAsignacion.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KryptonCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonCheckBox1.CheckedChanged
        KryptonComboBox2.Enabled = KryptonCheckBox1.Checked
        KryptonTextBox1.Enabled = KryptonCheckBox1.Checked
    End Sub
End Class

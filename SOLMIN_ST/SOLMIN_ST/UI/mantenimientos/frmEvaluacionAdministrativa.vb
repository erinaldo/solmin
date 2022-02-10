Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Moneda
Imports System.Reflection
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO


Public Class frmEvaluacionAdministrativa
    Private _CCMP As String = ""
    Public Nuevo As Boolean

    Private Sub frmEvaluacionAdministrativa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _CCMP = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy.ToString.Trim
            '_CCMP = "EZ"
            EstadoBotones(False, 1)
            cmbRegionVentaMant.Enabled = False
            txtAnio.Text = HelpClass.TodayAnio()
            txtMAnio.Text = HelpClass.TodayAnio()
            Cargar_Mes()

            Cargar_Proveedor_Filtro()
            Cargar_Proveedor()
            Cargar_Region_Venta()
            cargarCategoria(CboFCategorias, "TODOS")
            cargarCategoria(cboMcategorias, "SELECCIONE")

            If dgvEvaluacionAdm.RowCount > 0 Then
                btnModificar.Enabled = True
            Else
                btnModificar.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Origen: " & ex.Source & Chr(13) & " Contenido: " & ex.Message)
        End Try
       
    End Sub

    ''' <summary>
    ''' Cargar Mes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Mes()
        cmbMes.Properties.DataSource = HelpClass.odtMeses ' dtMes
        cmbMes.Properties.ValueMember = "Codigo"
        cmbMes.Properties.DisplayMember = "Descripcion"
        cmbMes.SetEditValue(Now.Month.ToString.PadLeft(2, "0"))
        Me.Cursor = System.Windows.Forms.Cursors.Default


        cboMes.DataSource = HelpClass.odtMeses ' dtMes
        cboMes.ValueMember = "Codigo"
        cboMes.DisplayMember = "Descripcion"
        cboMes.SelectedValue = Now.Month.ToString.PadLeft(2, "0")
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub


    ''' <summary>
    ''' Cargar Region Venta (Negocio)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New RegionVenta_BLL
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.fdtListaRegionVenta(_CCMP)
        Me.cmbRegionVenta.Properties.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.Properties.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.Properties.DataSource = oDtRegionVenta
        cmbRegionVenta.SetEditValue("R04")

        Me.cmbRegionVentaMant.ValueMember = "CRGVTA"
        Me.cmbRegionVentaMant.DisplayMember = "TCRVTA"
        Me.cmbRegionVentaMant.DataSource = oDtRegionVenta
        cmbRegionVentaMant.SelectedValue = "R04"

    End Sub


    Private Sub CboFCategorias_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFCategorias.SelectionChangeCommitted, ComboBox1.SelectionChangeCommitted
        cargarSubCategoria(cboFSubcategorias, "TODOS", CboFCategorias.SelectedValue)
    End Sub



    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarEvaluacionAdministrativa()

        If dgvEvaluacionAdm.RowCount > 0 Then
            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim msgVal As String = ""
        If cmbProveedor.pRucTransportista = String.Empty Then
            msgVal = "Debe de seleccionar el Proveedor"
        End If
        If cmbRegionVentaMant.SelectedValue = "" Then
            msgVal = msgVal & Chr(13) & "Debe seleccionar Región de Venta. "
        End If
        If txtAnio.Text = String.Empty Then
            msgVal = msgVal & Chr(13) & "Debe ingresar Año"
        End If
        If cboMes.SelectedValue = 0 Then
            msgVal = msgVal & Chr(13) & "Debe seleccionar un Mes"
        End If
        If cboMcategorias.SelectedValue = 0 Then
            msgVal = msgVal & Chr(13) & "Debe de seleccionar la Categoría"
        End If
        If cboMsubcategorias.SelectedValue = 0 Then
            msgVal = msgVal & Chr(13) & "Debe de seleccionar el Sub Categoría"
        End If
        If msgVal.Length > 0 Then
            MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Nuevo = True Then
            GrabarEvalAdm()
            Nuevo = False
        Else
            ModificarIncidencia()
            Nuevo = False
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo = True
        'MessageBox.Show(Now.Month)

        btnNuevo.Enabled = False
        EstadoBotones(True, 2)
        cmbRegionVentaMant.Enabled = True
        Limpiar_Controles()
        cboMes.SelectedValue = Now.Month.ToString.PadLeft(2, "0")
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        EstadoBotones(False, 1)
        cmbRegionVentaMant.Enabled = False
        Nuevo = False
        If dgvEvaluacionAdm.Rows.Count > 0 Then
            Limpiar_Controles()
        End If
        If dgvEvaluacionAdm.RowCount > 0 Then
            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim Entidad As New EvaluacionOperativa
            Dim objNegocio As New EvaluacionOperativa_BLL
            If dgvEvaluacionAdm.Rows.Count > 0 Then
                Dim lista As New List(Of EvaluacionOperativa)
                With Entidad
                    .CCMPN = dgvEvaluacionAdm.CurrentRow.Cells("CCMPN").Value
                    .NSEQIN = dgvEvaluacionAdm.CurrentRow.Cells("NSEQIN").Value
                    .CULUSA = MainModule.USUARIO
                    .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                End With
                lista.Add(Entidad)
                If MessageBox.Show("¿Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    objNegocio.ELIMINAR_EVA_ADMIN(lista)
                    BuscarEvaluacionAdministrativa()
                    MessageBox.Show("El registro se eliminó satisfactoriamente.")
                    BuscarEvaluacionAdministrativa()
                End If
            Else
                MessageBox.Show("No hay registros. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If dgvEvaluacionAdm.Rows.Count > 0 Then
            EstadoBotones(True, 2)
            Nuevo = False
            cmbRegionVentaMant.Enabled = False
            Asignar_Datos()
        Else
            MessageBox.Show("Seleccione un registro ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtMAnio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMAnio.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtAnio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress, KryptonTextBox1.KeyPress
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        'End If
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
    Private Sub ExportGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportGeneral.Click
        ExportarGeneral()
    End Sub

#Region "Metodos"

    Private Sub cargarCategoria(ByRef pSelectControl As ComboBox, ByVal STR As String)
        Try
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            Dim dtCategoria As New DataTable

            dtCategoria = ObjNegocioEvalOperativa.Listar_categorias(2, _CCMP)
            Dim dr As DataRow
            dr = dtCategoria.NewRow
            dr("CODCAT") = 0
            dr("DESCAT") = STR

            dtCategoria.Rows.InsertAt(dr, 0)
            pSelectControl.DataSource = dtCategoria
            pSelectControl.DisplayMember = "DESCAT"
            pSelectControl.ValueMember = "CODCAT"
            pSelectControl.SelectedValue = 0

            If STR.Equals("TODOS") Then
                cargarSubCategoria(cboFSubcategorias, "TODOS", pSelectControl.SelectedValue)
            Else
                cargarSubCategoria(cboMsubcategorias, "SELECCIONE", pSelectControl.SelectedValue)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cargarSubCategoria(ByRef pSelectControl As ComboBox, ByVal STR As String, ByVal Categoria As Integer)
        Try
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            If Categoria <> 0 Then
                Dim dtSubCategoria As New DataTable
                dtSubCategoria = ObjNegocioEvalOperativa.Listar_Subcategorias(2, Categoria, _CCMP)
                Dim dr As DataRow
                dr = dtSubCategoria.NewRow
                dr("CODSCT") = 0
                dr("DESSCT") = STR
                dtSubCategoria.Rows.InsertAt(dr, 0)
                pSelectControl.DataSource = dtSubCategoria
                pSelectControl.DisplayMember = "DESSCT"
                pSelectControl.ValueMember = "CODSCT"
            Else
                Dim tb As New DataTable
                Dim dr As DataRow
                tb.Columns.Add("CODSCT")
                tb.Columns.Add("DESSCT")
                dr = tb.NewRow
                dr(0) = 0
                dr(1) = STR
                tb.Rows.Add(dr)
                pSelectControl.DataSource = tb
                pSelectControl.DisplayMember = "DESSCT"
                pSelectControl.ValueMember = "CODSCT"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & "  Origen:" & ex.Source.ToString)
        End Try
    End Sub

    Private Sub ListarMeses(ByRef pSelectControl As ComponentFactory.Krypton.Toolkit.KryptonComboBox, ByVal Anio As Integer, ByVal STR As String)
        pSelectControl.DataSource = Listar_Meses_X_Anio(Anio, STR)
        pSelectControl.ValueMember = "VALUE"
        pSelectControl.DisplayMember = "MES"
    End Sub

    Public Shared Function Listar_Meses_X_Anio(ByVal oAnio As String, ByVal STR As String) As DataTable
        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("VALUE")
        odtMeses.Columns.Add("ANIO")
        odtMeses.Columns.Add("MES")

        odtMeses.Rows.Add(New Object() {0, oAnio, STR})
        odtMeses.Rows.Add(New Object() {1, oAnio, "ENERO"})
        odtMeses.Rows.Add(New Object() {2, oAnio, "FEBRERO"})
        odtMeses.Rows.Add(New Object() {3, oAnio, "MARZO"})
        odtMeses.Rows.Add(New Object() {4, oAnio, "ABRIL"})
        odtMeses.Rows.Add(New Object() {5, oAnio, "MAYO"})
        odtMeses.Rows.Add(New Object() {6, oAnio, "JUNIO"})
        odtMeses.Rows.Add(New Object() {7, oAnio, "JULIO"})
        odtMeses.Rows.Add(New Object() {8, oAnio, "AGOSTO"})
        odtMeses.Rows.Add(New Object() {9, oAnio, "SETIEMBRE"})
        odtMeses.Rows.Add(New Object() {10, oAnio, "OCTUBRE"})
        odtMeses.Rows.Add(New Object() {11, oAnio, "NOVIEMBRE"})
        odtMeses.Rows.Add(New Object() {12, oAnio, "DICIEMBRE"})

        Return odtMeses
    End Function

    Private Sub EstadoBotones(ByVal estado As Boolean, ByVal Btn As Integer)
        btnModificar.Enabled = IIf(Btn = 2, False, True)
        'btnEliminar.Enabled = IIf(Btn = 1, False, True)
        btnNuevo.Enabled = IIf(Btn = 2, False, True)
        btnCancelar.Enabled = estado
        btnGuardar.Enabled = estado
        txtObeservacion.Enabled = estado
        txtMAnio.Enabled = estado
        cboMes.Enabled = estado
        cboMcategorias.Enabled = estado
        cboMsubcategorias.Enabled = estado
        cmbProveedor.Enabled = estado

        cmbRegionVentaMant.Enabled = IIf(Btn = 2, False, True)
    End Sub

    Private Sub Cargar_Proveedor_Filtro()
        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeProveedor.pCCMPN_Compania = _CCMP
        'obeTransportista.pNRUCTR_RucTransportista = .pNRUCTR_RucProveedor
        cmbProveedorFiltro.pCargar(obeProveedor)
    End Sub

    Private Sub Cargar_Proveedor()
        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeProveedor.pCCMPN_Compania = _CCMP
        'obeTransportista.pNRUCTR_RucTransportista = .pNRUCTR_RucProveedor
        cmbProveedor.pCargar(obeProveedor)
    End Sub

    Private Sub BuscarEvaluacionAdministrativa()
        Try
            If Not fblnValidaInformacion() Then Exit Sub

            Dim strMeses As String = String.Empty
            For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
                If cmbMes.Properties.Items(i).CheckState Then
                    strMeses = strMeses & Val(cmbMes.Properties.Items(i).Value) & ","
                End If
            Next

            If strMeses.Length > 0 Then
                strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
            End If

            Dim Entidad As New EvaluacionOperativa
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            Entidad.ANIO = Convert.ToDecimal(txtAnio.Text)
            Entidad.MESES = strMeses
            Entidad.CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            Entidad.NRUCTR = cmbProveedorFiltro.pRucTransportista
            Entidad.CODCAT = Convert.ToDecimal(CboFCategorias.SelectedValue)
            Entidad.CODSCT = Convert.ToDecimal(cboFSubcategorias.SelectedValue)
            Entidad.CCMPN = _CCMP
            Dim oList As New List(Of EvaluacionOperativa)
            oList = ObjNegocioEvalOperativa.LISTAR_EVA_ADMIN_CONSULTA(Entidad)
            dgvEvaluacionAdm.AutoGenerateColumns = False
            dgvEvaluacionAdm.DataSource = oList

        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & " Origen: " & ex.Source.ToString)
        End Try
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If cmbRegionVenta.EditValue = "" Then
            strMensajeError &= "Debe seleccionar Región de Venta. " & vbNewLine
        End If

        If txtAnio.Text.Trim = "" OrElse txtAnio.Text = "0" OrElse txtAnio.Text.Trim <= "2000" Then
            strMensajeError &= "Debe Ingresar un año correcto. " & vbNewLine
        End If

        If cmbMes.EditValue = "" Then
            strMensajeError &= "Debe seleccionar almenos un mes. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub Asignar_Datos()
        Limpiar_Controles()
        If Me.dgvEvaluacionAdm.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim lint_Indice As Integer = Me.dgvEvaluacionAdm.CurrentCellAddress.Y
        If Me.dgvEvaluacionAdm.Rows.Count > 0 Then

            Me.cmbRegionVentaMant.SelectedValue = Me.dgvEvaluacionAdm.Item("CRGVTA", lint_Indice).Value.ToString().Trim()
            Me.txtMAnio.Text = Me.dgvEvaluacionAdm.Item("ANOALF", lint_Indice).Value.ToString().Trim()
            Me.cboMes.SelectedValue = Me.dgvEvaluacionAdm.Item("MESALF", lint_Indice).Value.ToString().Trim().PadLeft(2, "0")
            Me.cboMcategorias.SelectedValue = Me.dgvEvaluacionAdm.Item("CODCAT", lint_Indice).Value.ToString().Trim()
            cargarSubCategoria(cboMsubcategorias, "SELECCIONE", cboMcategorias.SelectedValue)
            Me.cboMsubcategorias.SelectedValue = Me.dgvEvaluacionAdm.Item("CODSCT", lint_Indice).Value.ToString().Trim()
            Me.ndCantidadIncidencia.Value = Me.dgvEvaluacionAdm.Item("QAINSM", lint_Indice).Value.ToString().Trim()
            Me.txtObeservacion.Text = Me.dgvEvaluacionAdm.Item("TOBS", lint_Indice).Value.ToString().Trim()
            Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeProveedor.pNRUCTR_RucTransportista = Me.dgvEvaluacionAdm.Item("NRUCTR", lint_Indice).Value.ToString().Trim()
            obeProveedor.pCCMPN_Compania = Me.dgvEvaluacionAdm.Item("CCMPN", lint_Indice).Value.ToString().Trim()
            cmbProveedor.pCargar(obeProveedor)

        Else
            Exit Sub
        End If
    End Sub

    Public Sub Limpiar_Controles()
        cargarCategoria(cboMcategorias, "SELECCIONE")
        txtMAnio.Text = HelpClass.TodayAnio()
        cboMcategorias.SelectedValue = 0
        cboMes.SelectedValue = Now.Month.ToString.PadLeft(2, "0")
        txtObeservacion.Text = ""
        cmbProveedor.pClear()
    End Sub

    Private Sub GrabarEvalAdm()
        Dim msg As String = ""
        Dim Entidad As New EvaluacionOperativa
        Dim objNegocio As New EvaluacionOperativa_BLL
        Dim lista As New List(Of EvaluacionOperativa)
        With Entidad
            .CCMPN = _CCMP
            .CRGVTA = Me.cmbRegionVentaMant.SelectedValue
            .NRUCTR = cmbProveedor.pRucTransportista
            .CODCAT = cboMcategorias.SelectedValue
            .CODSCT = cboMsubcategorias.SelectedValue
            .ANIO = Convert.ToDecimal(txtMAnio.Text)
            .ANIOMES = Convert.ToDecimal(cboMes.SelectedValue)
            .QAINSM = ndCantidadIncidencia.Value
            .TOBS = txtObeservacion.Text
            .CUSCRT = MainModule.USUARIO
            .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        End With
        lista.Add(Entidad)
        objNegocio.INSERTAR_EVA_ADMIN(lista)
        EstadoBotones(False, 1)
        cmbRegionVentaMant.Enabled = False
        MessageBox.Show("El registro se registró satisfactoriamente.")
        BuscarEvaluacionAdministrativa()
        Limpiar_Controles()
    End Sub

    Private Sub ModificarIncidencia()
        Try
            Dim objNegocio As New EvaluacionOperativa_BLL
            Dim Entidad As New EvaluacionOperativa
            If dgvEvaluacionAdm.Rows.Count < 0 Then
                MessageBox.Show("Debe de seleccionar un registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim lista As New List(Of EvaluacionOperativa)
                With Entidad
                    .NSEQIN = dgvEvaluacionAdm.CurrentRow.Cells("NSEQIN").Value
                    .CCMPN = dgvEvaluacionAdm.CurrentRow.Cells("CCMPN").Value
                    .NRUCTR = cmbProveedor.pRucTransportista
                    .CODCAT = cboMcategorias.SelectedValue
                    .CODSCT = cboMsubcategorias.SelectedValue
                    .ANIO = Convert.ToDecimal(txtMAnio.Text)
                    .ANIOMES = Convert.ToDecimal(cboMes.SelectedValue)
                    .QAINSM = ndCantidadIncidencia.Value
                    .TOBS = txtObeservacion.Text
                    .CULUSA = MainModule.USUARIO
                    .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                End With
                lista.Add(Entidad)
                objNegocio.ACTUALIZAR_EVA_ADMIN(lista)
                Limpiar_Controles()
                EstadoBotones(False, 1)
                MessageBox.Show("El registro se Actualizo satisfactoriamente.")
                BuscarEvaluacionAdministrativa()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Exportaciones"
    Private Sub ExportarGeneral()
        Try
            If dgvEvaluacionAdm.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC
            Dim ListaExcel As List(Of ENTIDADES.EvaluacionOperativa) = Me.dgvEvaluacionAdm.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NSEQIN").Caption = NPOI_SC.FormatDato("Nro Eval.", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("CRGVTA").Caption = NPOI_SC.FormatDato("Cód. Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCRVTA").Caption = NPOI_SC.FormatDato("Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NOMMES").Caption = NPOI_SC.FormatDato("Mes", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NRUCTR").Caption = NPOI_SC.FormatDato("RUC", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMTRT").Caption = NPOI_SC.FormatDato("Proveedor", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("DESCAT").Caption = NPOI_SC.FormatDato("Categoría", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FACCAT").Caption = NPOI_SC.FormatDato("Factor Categoría", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("DESSCT").Caption = NPOI_SC.FormatDato("Sub Categoría", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FACSCT").Caption = NPOI_SC.FormatDato("Factor Sub Categoría", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QAINSM").Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("Observación", NPOI_SC.keyDatoTexto)

            For Each item As ENTIDADES.EvaluacionOperativa In ListaExcel
                dr = dtExcel.NewRow

                dr("NSEQIN") = item.NSEQIN
                dr("CRGVTA") = item.CRGVTA
                dr("TCRVTA") = item.TCRVTA
                dr("NRUCTR") = item.NRUCTR
                dr("NOMMES") = item.NOMMES
                dr("TCMTRT") = item.TCMTRT
                dr("DESCAT") = item.DESCAT
                dr("FACCAT") = item.FACCAT
                dr("DESSCT") = item.DESSCT
                dr("FACSCT") = item.FACSCT
                dr("QAINSM") = item.QAINSM
                dr("TOBS") = item.TOBS

                dtExcel.Rows.Add(dr)

            Next


            Dim ListaDatatable As New List(Of DataTable)
            dtExcel.TableName = "EVALUACION_ADMISTRATIVA"
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("EVALUACIÓN ADMINISTRATIVA")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Año:| " & txtAnio.Text)
            F.Add(1, "Mes:|" & cboMes.Text)
            F.Add(2, "Proveedor:|" & IIf(cmbProveedorFiltro.Text = String.Empty, "TODOS", cmbProveedorFiltro.pRazonSocial))
            F.Add(3, "Categoría:| " & CboFCategorias.Text)
            F.Add(4, "Sub Categoría:| " & cboFSubcategorias.Text)

            oLisFiltro.Add(F)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)

        Catch ex As Exception
            MessageBox.Show("Error al Exportar a Excel")
            ' MessageBox.Show(ex.Message & Chr(13) & ex.Source)
        End Try
    End Sub
#End Region
    Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of t)) As DataTable
        Dim dt As New DataTable()
        Dim propiedades As PropertyInfo() = GetType(T).GetProperties
        For Each p As PropertyInfo In propiedades
            dt.Columns.Add(p.Name, p.PropertyType)
        Next
        For Each item As T In list
            Dim row As DataRow = dt.NewRow
            For Each p As PropertyInfo In propiedades
                row(p.Name) = p.GetValue(item, Nothing)
            Next
            dt.Rows.Add(row)
        Next
        Return dt
    End Function


    Private Sub ExportFormatoEvalOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportFormatoEvalOp.Click

        Try

            If dgvEvaluacionAdm.Rows.Count <= 0 Then
                MessageBox.Show("Realice una Consulta")
                Exit Sub
            End If

            'Dim MesValor As String
            Dim NameMes As String = ""
            If Not fblnValidaInformacion() Then Exit Sub

            Dim strMeses As String = String.Empty
            For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
                If cmbMes.Properties.Items(i).CheckState Then
                    strMeses = strMeses & Val(cmbMes.Properties.Items(i).Value) & ","
                End If
            Next

            If strMeses.Length > 0 Then
                strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
            End If



            Dim titulo As String = ""
            Dim año As String = ""
            Dim mes As String = ""
            titulo = cboMes.Text & "-" & "ADM"
            año = txtAnio.Text
            mes = cboMes.Text
            'MesValor = (100 * Convert.ToInt32(año)) + Convert.ToInt32(cboMes.SelectedValue)

            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            Dim tbCategias As DataTable
            tbCategias = ObjNegocioEvalOperativa.Listar_CategoriasExcel(2, _CCMP)
            Dim tbEvaAdmin As DataTable
            Dim tbProveedoresPeriodo As New DataTable
            'tbProveedoresPeriodo = ObjNegocioEvalOperativa.PROVEEDORES_PERIODO(MesValor, "EZ")
            Dim obeFiltro As New EvaluacionOperativa
            With obeFiltro
                .CCMPN = _CCMP
                .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
                .ANIO = Convert.ToInt32(año)
                .MESES = strMeses
            End With

            tbProveedoresPeriodo = ObjNegocioEvalOperativa.PROVEEDORES_EVA_ADMIN_MES(obeFiltro)

            'tbProveedoresPeriodo = ConvertToDataTable(dgvEvaluacionAdm.DataSource)

            Dim tmp As New DataTable
            tmp.Columns.Add("EVALUACIONES")
            tmp.Columns.Add("DESCAT")
            tmp.Columns.Add("DESSCT")
            tmp.Columns.Add("RUC")
            tmp.Columns.Add("CODCAT")
            tmp.Columns.Add("CODSCT")
            Dim ruc As String = ""
            For index As Integer = 0 To tbProveedoresPeriodo.Rows.Count - 1
                obeFiltro.NRUCTR = tbProveedoresPeriodo.Rows.Item(index)(0).ToString.Trim

                tbEvaAdmin = ObjNegocioEvalOperativa.EVALUACION_ADMINISTRATIVA_MES(obeFiltro)

                For index1 As Integer = 0 To tbEvaAdmin.Rows.Count - 1
                    Dim dr As DataRow
                    dr = tmp.NewRow
                    dr("EVALUACIONES") = tbEvaAdmin.Rows.Item(index1)(0)
                    dr("DESCAT") = tbEvaAdmin.Rows.Item(index1)(1)
                    dr("DESSCT") = tbEvaAdmin.Rows.Item(index1)(2)
                    dr("RUC") = tbEvaAdmin.Rows.Item(index1)(3)
                    dr("CODCAT") = tbEvaAdmin.Rows.Item(index1)(4)
                    dr("CODSCT") = tbEvaAdmin.Rows.Item(index1)(5)
                    tmp.Rows.Add(dr)
                Next
            Next

            Dim strlis As New Hashtable

            strlis.Add(0, "Año : " & Me.txtAnio.Text)
            strlis.Add(1, "Mes : " & cmbMes.Text)
            strlis.Add(2, "Negocio : " & cmbRegionVenta.Text)

            HelpClass_NPOI.ExportExcel_EvalAdmin(titulo, strlis, año, mes, tbCategias, tbProveedoresPeriodo, tmp)
            tmp.Clear()
        Catch ex As Exception
            MessageBox.Show("ERROR AL EXPORTAR AL EXCEL " & Chr(13) & ex.Message & Chr(13) & " origen: " & ex.Source)
        End Try



    End Sub

    Private Sub cboMcategorias_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMcategorias.SelectionChangeCommitted
        cargarSubCategoria(cboMsubcategorias, "SELECCIONE", cboMcategorias.SelectedValue)
    End Sub

    Private Sub dgvEvaluacionAdm_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEvaluacionAdm.SelectionChanged
        Asignar_Datos()
    End Sub
End Class

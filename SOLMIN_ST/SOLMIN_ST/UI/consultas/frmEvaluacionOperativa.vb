Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Moneda
Imports Ransa.Utilitario
Imports System.Reflection

Public Class frmEvaluacionOperativa
    Private _CCMPN As String = ""

    Private Sub frmEvaluacionOperativa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy.ToString.Trim
        '_CCMPN = "EZ"
        Cargar_Region_Venta()
        Cargar_Mes()
        txtAnno.Text = HelpClass.TodayAnio()
        'ListarMeses(Convert.ToInt32(txtAnno.Text))
        cargarCategoria()
        Cargar_Proveedor_Filtro()
        If dtgEvaluacionOperativa.RowCount = 0 Then
            Me.dtgEvaluacionOperativa.Columns(9).Width = 1000
        End If
    End Sub

    ''' <summary>
    ''' Cargar Region Venta (Negocio)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New RegionVenta_BLL
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.fdtListaRegionVenta(_CCMPN)
        Me.cmbRegionVenta.Properties.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.Properties.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.Properties.DataSource = oDtRegionVenta

        cmbRegionVenta.SetEditValue("R04")
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
    End Sub


    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If cmbRegionVenta.EditValue = "" Then
            strMensajeError &= "Debe seleccionar Región de Venta. " & vbNewLine
        End If

        If txtAnno.Text.Trim = "" OrElse txtAnno.Text = "0" OrElse txtAnno.Text.Trim <= "2000" Then
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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            'Realizamos la validación
            If Not fblnValidaInformacion() Then Exit Sub

            Dim Entidad As New EvaluacionOperativa
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            Entidad.ANIO = Convert.ToDecimal(txtAnno.Text)
            Dim strMeses As String = String.Empty
            For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
                If cmbMes.Properties.Items(i).CheckState Then
                    strMeses = strMeses & Val(Me.txtAnno.Text & cmbMes.Properties.Items(i).Value) & ","
                End If
            Next

            If strMeses.Length > 0 Then
                strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
            End If

            Entidad.MESES = strMeses
            Dim ctnl As String = cmbProveedorFiltro.pRazonSocial
            If ctnl = String.Empty Then
                cmbProveedorFiltro.pClear()
                Entidad.NRUCTR = ""
            Else
                Entidad.NRUCTR = cmbProveedorFiltro.pRucTransportista
            End If
            Entidad.CODCAT = Convert.ToDecimal(cboCategoria.SelectedValue)
            Entidad.CODSCT = Convert.ToDecimal(cboSubcategoria.SelectedValue)
            Entidad.CCMPN = _CCMPN
            Entidad.CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")

            dtgEvaluacionOperativa.AutoGenerateColumns = False
            Dim oList As New List(Of EvaluacionOperativa)
            oList = ObjNegocioEvalOperativa.LISTAR_EVA_OP_CONSULTA(Entidad)
            dtgEvaluacionOperativa.DataSource = oList
            If dtgEvaluacionOperativa.RowCount > 0 Then
                Me.dtgEvaluacionOperativa.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & " Origen: " & ex.Source.ToString)
        End Try
    End Sub


    Private Sub txtAnno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnno.Leave
        Dim anio As Integer = Convert.ToInt32(txtAnno.Text)
        'ListarMeses(anio)
    End Sub

    Private Sub cboCategoria_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoria.SelectionChangeCommitted
        cargarSubCategoria(cboCategoria.SelectedValue)
    End Sub

    Private Sub ExportGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportGeneral.Click

        ExportarGeneral()
    End Sub
    Private Sub txtAnno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnno.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
#Region "Metodos"
    Private Sub Cargar_Proveedor_Filtro()
        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeProveedor.pCCMPN_Compania = _CCMPN
        'obeTransportista.pNRUCTR_RucTransportista = .pNRUCTR_RucProveedor
        cmbProveedorFiltro.pCargar(obeProveedor)
    End Sub

    Private Sub cargarCategoria()
        Try
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            Dim dtCategoria As New DataTable
            dtCategoria = ObjNegocioEvalOperativa.Listar_categorias(1, _CCMPN)
            Dim dr As DataRow
            dr = dtCategoria.NewRow
            dr("CODCAT") = 0
            dr("DESCAT") = "TODOS"

            dtCategoria.Rows.InsertAt(dr, 0)
            cboCategoria.DataSource = dtCategoria
            cboCategoria.DisplayMember = "DESCAT"
            cboCategoria.ValueMember = "CODCAT"
            cboCategoria.SelectedValue = 0
            cargarSubCategoria(cboCategoria.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cargarSubCategoria(ByVal Categoria As Integer)
        Try
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            If Categoria <> 0 Then
                Dim dtSubCategoria As New DataTable
                dtSubCategoria = ObjNegocioEvalOperativa.Listar_Subcategorias(1, Categoria, _CCMPN)
                Dim dr As DataRow
                dr = dtSubCategoria.NewRow
                dr("CODSCT") = 0
                dr("DESSCT") = "TODOS"
                dtSubCategoria.Rows.InsertAt(dr, 0)
                cboSubcategoria.DataSource = dtSubCategoria
                cboSubcategoria.DisplayMember = "DESSCT"
                cboSubcategoria.ValueMember = "CODSCT"
            Else
                Dim tb As New DataTable
                Dim dr As DataRow
                tb.Columns.Add("CODSCT")
                tb.Columns.Add("DESSCT")
                dr = tb.NewRow
                dr(0) = 0
                dr(1) = "TODOS"
                tb.Rows.Add(dr)
                cboSubcategoria.DataSource = tb
                cboSubcategoria.DisplayMember = "DESSCT"
                cboSubcategoria.ValueMember = "CODSCT"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & "  Origen:" & ex.Source.ToString)
        End Try

    End Sub

   
    'Public Shared Function Listar_Meses_X_Anio(ByVal oAnio As String) As DataTable
    '    Dim odtMeses As New DataTable
    '    odtMeses.Columns.Add("VALUE")
    '    odtMeses.Columns.Add("ANIO")
    '    odtMeses.Columns.Add("MES")

    '    odtMeses.Rows.Add(New Object() {0, oAnio, "TODOS"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "01", oAnio, "ENERO"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "02", oAnio, "FEBRERO"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "03", oAnio, "MARZO"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "04", oAnio, "ABRIL"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "05", oAnio, "MAYO"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "06", oAnio, "JUNIO"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "07", oAnio, "JULIO"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "08", oAnio, "AGOSTO"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "09", oAnio, "SETIEMBRE"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "10", oAnio, "OCTUBRE"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "11", oAnio, "NOVIEMBRE"})
    '    odtMeses.Rows.Add(New Object() {oAnio + "12", oAnio, "DICIEMBRE"})

    '    Return odtMeses
    'End Function

#End Region

#Region "Exportaciones"

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


    Private Sub ExportarGeneral()
        Try

            If dtgEvaluacionOperativa.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC

            Dim ListaExcel As List(Of ENTIDADES.EvaluacionOperativa) = Me.dtgEvaluacionOperativa.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NSEQIN").Caption = NPOI_SC.FormatDato("Nro Incidencia", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("CRGVTA").Caption = NPOI_SC.FormatDato("Cód. Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCRVTA").Caption = NPOI_SC.FormatDato("Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NRUCTR").Caption = NPOI_SC.FormatDato("RUC", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMTRT").Caption = NPOI_SC.FormatDato("Proveedor", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FOPRCN_S").Caption = NPOI_SC.FormatDato("Fecha Incidencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("DESCAT").Caption = NPOI_SC.FormatDato("Categoría", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FACCAT").Caption = NPOI_SC.FormatDato("Factor Categoría", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("DESSCT").Caption = NPOI_SC.FormatDato("Sub Categoría", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FACSCT").Caption = NPOI_SC.FormatDato("Factor Sub Categoría", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QAINSM").Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("NOPRCN").Caption = NPOI_SC.FormatDato("Operación", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("Observación", NPOI_SC.keyDatoTexto)

            For Each item As ENTIDADES.EvaluacionOperativa In ListaExcel
                dr = dtExcel.NewRow

                dr("NSEQIN") = Convert.ToInt32(item.NSEQIN)
                dr("CRGVTA") = item.CRGVTA
                dr("TCRVTA") = item.TCRVTA
                dr("NRUCTR") = item.NRUCTR
                dr("FOPRCN_S") = item.FOPRCN_S
                dr("TCMTRT") = item.TCMTRT.ToString.Trim
                dr("DESCAT") = item.DESCAT
                dr("FACCAT") = item.FACCAT
                dr("DESSCT") = item.DESSCT
                dr("FACSCT") = Convert.ToSingle(item.FACSCT)
                dr("QAINSM") = Convert.ToInt32(item.QAINSM)
                dr("NOPRCN") = Convert.ToInt32(item.NOPRCN)
                dr("TOBS") = item.TOBS

                dtExcel.Rows.Add(dr)

            Next

            Dim ListaDatatable As New List(Of DataTable)
            dtExcel.TableName = "EVALUACION_OPERATIVA"
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("EVALUACIÓN OPERATIVA")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Año:| " & txtAnno.Text)
            F.Add(1, "Mes:|" & cmbMes.Text)
            F.Add(2, "Negocio:|" & cmbRegionVenta.Text)
            F.Add(3, "Proveedor:|" & IIf(cmbProveedorFiltro.Text = String.Empty, "TODOS", cmbProveedorFiltro.pRazonSocial))
            F.Add(4, "Categoría:| " & cboCategoria.Text)
            F.Add(5, "Sub Categoría:| " & cboSubcategoria.Text)

            oLisFiltro.Add(F)
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)

        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & ex.Source)
        End Try
    End Sub
#End Region



    Private Sub ExportFormatoEvalOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportFormatoEvalOp.Click
        Try
            Dim MesValor As String
            Dim NameMes As String = ""
            If Not fblnValidaInformacion() Then Exit Sub

            Dim strMeses As String = String.Empty
            For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
                If cmbMes.Properties.Items(i).CheckState Then
                    strMeses = strMeses & Val(Me.txtAnno.Text & cmbMes.Properties.Items(i).Value) & ","
                End If
            Next

            If strMeses.Length > 0 Then
                strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
            End If

            NameMes = cmbMes.Text

            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            Dim tbCategias As DataTable
            tbCategias = ObjNegocioEvalOperativa.Listar_CategoriasExcel(1, _CCMPN)
            Dim tbIncidencia As DataTable
            Dim tbKmRecorrido As DataTable
            Dim beFiltro As New EvaluacionOperativa
            beFiltro.CCMPN = _CCMPN
            beFiltro.MESES = strMeses
            beFiltro.CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            tbKmRecorrido = ObjNegocioEvalOperativa.VIAJES_KILOMETROS_PROVEEDOR(beFiltro)

            Dim tmp As New DataTable
            tmp.Columns.Add("INCIDENCIA")
            tmp.Columns.Add("DESCAT")
            tmp.Columns.Add("DESSCT")
            tmp.Columns.Add("RUC")
            tmp.Columns.Add("CODCAT")
            tmp.Columns.Add("CODSCT")
            Dim ruc As String = ""

            For index As Integer = 0 To tbKmRecorrido.Rows.Count - 1
                ruc = tbKmRecorrido.Rows.Item(index)(0)
                beFiltro = New EvaluacionOperativa

                beFiltro.CCMPN = _CCMPN
                beFiltro.CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
                beFiltro.MESES = strMeses
                beFiltro.NRUCTR = tbKmRecorrido.Rows.Item(index)(0)
                tbIncidencia = ObjNegocioEvalOperativa.INCIDENCIAS_CATEGORIA_PROVEEDOR(beFiltro)

                For index1 As Integer = 0 To tbIncidencia.Rows.Count - 1
                    Dim dr As DataRow
                    dr = tmp.NewRow
                    dr("INCIDENCIA") = tbIncidencia.Rows.Item(index1)(0)
                    dr("DESCAT") = tbIncidencia.Rows.Item(index1)(1)
                    dr("DESSCT") = tbIncidencia.Rows.Item(index1)(2)
                    dr("RUC") = tbIncidencia.Rows.Item(index1)(3)
                    dr("CODCAT") = tbIncidencia.Rows.Item(index1)(4)
                    dr("CODSCT") = tbIncidencia.Rows.Item(index1)(5)
                    tmp.Rows.Add(dr)
                Next
            Next
            Dim strlis As New Hashtable

            strlis.Add(0, "Mes : " & cmbMes.Text)
            strlis.Add(1, "Negocio : " & cmbRegionVenta.Text)
            HelpClass_NPOI.ExportExcel_EvalOp(NameMes, strlis, tbCategias, tbKmRecorrido, tmp)
            tmp.Clear()

        Catch ex As Exception
            MessageBox.Show("ERROR AL EXPORTAR AL EXCEL " & Chr(13) & ex.Message & Chr(13) & " origen: " & ex.Source)
        End Try
    End Sub
End Class

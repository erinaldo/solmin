Imports Ransa.TYPEDEF.Cliente
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class frmRecepcionGuia
    Public int_GuiaRemision As Int64

    Private Sub Cargar_Grilla()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        oDt = mfdtListar_OrdenesServicioPorMercaderiaGuia(CType(IIf(txtCliente.Text = "", 0, txtCliente.Text), Long), int_GuiaRemision.ToString.Trim)
        Me.dgMercaderiaGuia.Rows.Clear()
        With oDt
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To .Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dgMercaderiaGuia)
                    oDrVw.Cells(1).Value = .Rows(intCont).Item("NRITOC").ToString.Trim
                    oDrVw.Cells(2).Value = .Rows(intCont).Item("TCITCL").ToString.Trim
                    oDrVw.Cells(3).Value = .Rows(intCont).Item("TMRCD2").ToString.Trim
                    oDrVw.Cells(4).Value = .Rows(intCont).Item("TOBS").ToString.Trim
                    oDrVw.Cells(5).Value = Format(CType(.Rows(intCont).Item("QBLTSR").ToString.Trim, Double), "###,###,##0.00")
                    oDrVw.Cells(6).Value = .Rows(intCont).Item("CUNCN5").ToString.Trim
                    oDrVw.Cells(7).Value = Format(CType(.Rows(intCont).Item("PESO").ToString.Trim, Double), "###,###,##0.00")
                    oDrVw.Cells(8).Value = .Rows(intCont).Item("CUNPS5").ToString.Trim
                    oDrVw.Cells(9).Value = Format(CType(.Rows(intCont).Item("IVUNIT").ToString.Trim, Double), "###,###,##0.00")
                    oDrVw.Cells(10).Value = .Rows(intCont).Item("CUNVL5").ToString.Trim
                    oDrVw.Cells(11).Value = .Rows(intCont).Item("NORDSR").ToString.Trim
                    oDrVw.Cells(12).Value = .Rows(intCont).Item("NORCML").ToString.Trim
                    oDrVw.Cells(13).Value = .Rows(intCont).Item("NCNTR").ToString.Trim
                    oDrVw.Cells(14).Value = .Rows(intCont).Item("NCRCTC").ToString.Trim
                    oDrVw.Cells(15).Value = .Rows(intCont).Item("NAUTR").ToString.Trim
                    oDrVw.Cells(16).Value = .Rows(intCont).Item("FUNDS2").ToString.Trim
                    oDrVw.Cells(17).Value = .Rows(intCont).Item("CMRCD").ToString.Trim
                    oDrVw.Cells(18).Value = .Rows(intCont).Item("NRUCLL").ToString.Trim
                    oDrVw.Cells(19).Value = .Rows(intCont).Item("CTPDP6").ToString.Trim
                    If oDrVw.Cells(2).Value <> "-" Then
                        oDrVw.Cells(0).Value = True
                        oDrVw.Cells(0).ReadOnly = False
                    Else
                        oDrVw.Cells(0).Value = False
                        oDrVw.Cells(0).ReadOnly = True
                    End If
                    If oDrVw.Cells(11).Value <> 0 Then
                        oDrVw.Cells(20).Value = "NO"
                    Else
                        oDrVw.Cells(20).Value = "SI"
                    End If
                    Me.dgMercaderiaGuia.Rows.Add(oDrVw)
                Next intCont
            End If
        End With
    End Sub
#Region " Atributos "
    Dim blnResultado As Boolean = False
#End Region
#Region " Propiedades "
    Public Property pstrTipoAlmacen() As String
        Get
            Return "" & txtTipoAlmacen.Tag
        End Get
        Set(ByVal value As String)
            txtTipoAlmacen.Tag = value
        End Set
    End Property

    Public Property pstrDetalleTipoAlmacen() As String
        Get
            Return txtTipoAlmacen.Text
        End Get
        Set(ByVal value As String)
            txtTipoAlmacen.Text = value
        End Set
    End Property

    Public Property pstrAlmacen() As String
        Get
            Return "" & txtAlmacen.Tag
        End Get
        Set(ByVal value As String)
            txtAlmacen.Tag = value
        End Set
    End Property

    Public Property pstrDetalleAlmacen() As String
        Get
            Return "" & txtAlmacen.Text
        End Get
        Set(ByVal value As String)
            txtAlmacen.Text = value
        End Set
    End Property

    Public Property pstrZonaAlmacen() As String
        Get
            Return "" & txtZonaAlmacen.Tag
        End Get
        Set(ByVal value As String)
            txtZonaAlmacen.Tag = value
        End Set
    End Property

    Public Property pstrDetalleZonaAlmacen() As String
        Get
            Return "" & txtZonaAlmacen.Text
        End Get
        Set(ByVal value As String)
            txtZonaAlmacen.Text = value
        End Set
    End Property

    Public Property pstrTipoRecepcion() As String
        Get
            Return "" & txtTipoRecepcion.Tag
        End Get
        Set(ByVal value As String)
            txtTipoRecepcion.Tag = value
        End Set
    End Property

    Public Property pstrDetalleTipoRecepcion() As String
        Get
            Return txtTipoRecepcion.Text
        End Get
        Set(ByVal value As String)
            txtTipoRecepcion.Text = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub Cargar_cboContratos()
        Try
            Me.cboContratos.DataSource = mfdtListar_ContratosVigentes(txtCliente.Text.Trim, objSeguridadBN.pstrTipoAlmacen)
            Me.cboContratos.DisplayMember = "NCNTR"
            Me.cboContratos.ValueMember = "CTPPR1"
        Catch ex As Exception
        End Try
    End Sub

    Private Function fblnValidarInfItemRecepcion() As Boolean
        Dim strResultado As String = ""
        blnResultado = True
        If txtGuiaRemision.Text = "" Then strResultado &= "Debe digitar el número de Guía de Remisión ." & vbNewLine
        If txtTipoAlmacen.Text = "" Then strResultado &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
        If txtAlmacen.Text = "" Then strResultado &= "Debe seleccionar un Almacén" & vbNewLine
        If txtZonaAlmacen.Text = "" Then strResultado &= "Debe seleccionar una Zona de Almacén." & vbNewLine
        If txtTipoRecepcion.Text = "" Then strResultado &= "Debe seleccionar el Tipo de Recepción." & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Function fblnValidarInfItemValorGrilla(ByVal lint_Contador As Integer) As Boolean
        Dim strResultado As String = ""
        blnResultado = True
        If Me.dgMercaderiaGuia.Item(5, lint_Contador).Value = "" Then strResultado &= "Debe digitar la cantidad." & " - " & lint_Contador + 1 & vbNewLine
        If Me.dgMercaderiaGuia.Item(6, lint_Contador).Value = "" Then strResultado &= "Debe digitar la unidad de la cantidad." & lint_Contador + 1 & vbNewLine
        If Me.dgMercaderiaGuia.Item(7, lint_Contador).Value = "" Then strResultado &= "Debe digitar el peso." & " - " & lint_Contador + 1 & vbNewLine
        If Me.dgMercaderiaGuia.Item(8, lint_Contador).Value = "" Then strResultado &= "Debe digitar la unidad del peso." & " - " & lint_Contador + 1 & vbNewLine
        If Me.dgMercaderiaGuia.Item(9, lint_Contador).Value = "" Then strResultado &= "Debe digitar el valor." & " - " & lint_Contador + 1 & vbNewLine
        If Me.dgMercaderiaGuia.Item(10, lint_Contador).Value = "" Then strResultado &= "Debe digitar la unidad del valor." & " - " & lint_Contador + 1 & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub ProcesarCrearOS(ByVal lint_Contador As Integer)
        Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
        With objNuevaOrdenServicio
            If Me.dgMercaderiaGuia.Item(20, lint_Contador).Value = "SI" Then
                .pintCodigoCliente_CCLNT = txtCliente.Text.Trim
                .pstrCodigoMercaderia_CMRCLR = dgMercaderiaGuia.Item(2, lint_Contador).Value.ToString.Trim
                Decimal.TryParse(cboContratos.Text.Trim, .pintNroContrato_NCNTR)
                .pstrTipoDeposito_CTPDP3 = dgMercaderiaGuia.Item(19, lint_Contador).Value
                .pstrProducto_CTPPR1 = cboContratos.SelectedValue.ToString.Trim
                Decimal.TryParse(dgMercaderiaGuia.Item(5, lint_Contador).Value, .pdecCantidadDeclarada_QMRCD)
                .pstrUnidadCantidad_CUNCND = dgMercaderiaGuia.Item(6, lint_Contador).Value
                Decimal.TryParse(dgMercaderiaGuia.Item(7, lint_Contador).Value, .pdecPesoDeclarado_QPSMR)
                .pstrUnidadPeso_CUNPS0 = dgMercaderiaGuia.Item(8, lint_Contador).Value
                Decimal.TryParse(dgMercaderiaGuia.Item(9, lint_Contador).Value, .pdecValorDeclarado_QVLMR)
                .pstrUnidadValor_CUNVLR = dgMercaderiaGuia.Item(10, lint_Contador).Value
                .pstrControlLotes_FUNCTL = "N"
                .pstrUnidadDespacho_FUNDS = dgMercaderiaGuia.Item(16, lint_Contador).Value
            End If
        End With
        blnResultado = mfblnCrearOrdenServicio(objNuevaOrdenServicio)
        objNuevaOrdenServicio = Nothing
        If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Crear)
    End Sub

    Private Sub dgMercaderiaGuia_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderiaGuia.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If e.ColumnIndex = 20 Then
            If Me.dgMercaderiaGuia.Item(20, e.RowIndex).Value = "SI" Then
                If fblnValidarInfItemValorGrilla(e.RowIndex) Then
                    Me.ProcesarCrearOS(e.RowIndex)
                    Me.Cargar_Grilla()
                End If
            End If
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub bsaCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bsaBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBuscar.Click
        If txtGuiaRemision.Text.Trim.Length > 0 Then
            int_GuiaRemision = CType(txtGuiaRemision.Text, Long)
            Me.Cargar_Grilla()
        End If
    End Sub

    Private Sub bsaProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesar.Click
        Decimal.TryParse(Me.txtGuiaRemision.Text, int_GuiaRemision)
        Me.txtGuiaRemision.Focus()
        If fblnValidarInfItemRecepcion() = True Then
            If blnResultado = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
        End If
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub

    Private Sub bsaTipoRecepcionListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoRecepcionListar.Click
        Call mfblnBuscar_SDSTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
    End Sub

    Private Sub dgMercaderiaGuia_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderiaGuia.CellValueChanged
        If Me.dgMercaderiaGuia.RowCount = 0 Then Exit Sub
        If e.ColumnIndex = 11 Then
            Dim lstr_Cadena As String = ""
            If Me.dgMercaderiaGuia.Item(11, e.RowIndex).Value = Nothing Then
                Me.dgMercaderiaGuia.Item(20, e.RowIndex).Value = "SI"
                Me.dgMercaderiaGuia.Item(0, e.RowIndex).Value = False
                Me.dgMercaderiaGuia.Item(0, e.RowIndex).ReadOnly = True
                Exit Sub
            End If
            lstr_Cadena = Me.dgMercaderiaGuia.Item(11, e.RowIndex).Value.ToString.Trim()
            For lint_Contador As Integer = 0 To lstr_Cadena.Trim.Length - 1
                If Not Char.IsNumber(lstr_Cadena.Substring(lint_Contador, 1).Trim) Then
                    Me.dgMercaderiaGuia.Item(11, e.RowIndex).Value = Nothing
                    Exit Sub
                End If
            Next
            If Me.dgMercaderiaGuia.Item(11, e.RowIndex).Value.ToString.Trim.Length > 0 Then
                Me.dgMercaderiaGuia.Item(20, e.RowIndex).Value = "NO"
                Me.dgMercaderiaGuia.Item(0, e.RowIndex).Value = True
                Me.dgMercaderiaGuia.Item(0, e.RowIndex).ReadOnly = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub frmRecepcionGuia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For lint_Contador As Integer = 0 To Me.dgMercaderiaGuia.RowCount - 1
            Me.dgMercaderiaGuia.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        Me.Cargar_cboContratos()
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
        txtAlmacen.Text = ""
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
        ' Si modificamos el Almacén - debe limpiarse la Zona
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
            Case Keys.Delete
                txtZonaAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtZonaAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
        txtZonaAlmacen.Tag = ""
    End Sub

    Private Sub txtZonaAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
        If txtZonaAlmacen.Text = "" Then
            txtZonaAlmacen.Tag = ""
        Else
            If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
                Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                If txtZonaAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoRecepcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoRecepcion.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_SDSTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoRecepcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoRecepcion.TextChanged
        txtTipoRecepcion.Tag = ""
    End Sub

    Private Sub txtTipoRecepcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoRecepcion.Validating
        If txtTipoRecepcion.Text = "" Then
            txtTipoRecepcion.Tag = ""
        Else
            If txtTipoRecepcion.Text <> "" And "" & txtTipoRecepcion.Tag = "" Then
                Call mfblnBuscar_SDSTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
                If txtTipoRecepcion.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
#End Region
End Class
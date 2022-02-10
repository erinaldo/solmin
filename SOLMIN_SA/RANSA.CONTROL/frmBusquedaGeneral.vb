Imports System.Windows.Forms
'Imports Ransa.Utilitario

Public Class frmBusquedaGeneral
#Region " Atributos "
    Private _mobjListColumnsHide As New List(Of Object)
    Private _mdtDataSource As DataTable
    Private _mdrDataRow As DataRowView 'GridViewRow
    Private _mdvView As DataView
    Private _mdrDataRows As Windows.Forms.DataGridViewSelectedRowCollection
    Private _mblnMultiSelect As Boolean
    Private _mintCampoDefault As Int16 = -1
    Private _mstrTitulo As String
    Private dtPrincipal As New DataTable

    'Paginación
    Dim VistaDefault As Integer = 20
    Dim TotalPaginas As Integer
    Dim PaginaActual As Integer
    Dim ini As Integer = 0
    Dim fin As Integer = 19

#End Region
#Region " Propiedades "

    Public Event Resultado(ByVal objResult As Object)

    Private _DataSource As Object

    'Public Property DataSource() As Object
    '    Get
    '        Return _DataSource
    '    End Get
    '    Set(ByVal value As Object)
    '        _DataSource = value
    '    End Set
    'End Property


    Private _objResultado As Object
    Public Property objResultado() As Object
        Get
            Return _objResultado
        End Get
        Set(ByVal value As Object)
            _objResultado = value
        End Set
    End Property


    Private _DataMember As String = ""
    Public Property DataMember() As String
        Get
            Return _DataMember
        End Get
        Set(ByVal value As String)
            _DataMember = value
        End Set
    End Property

    Private _DataValue As String = ""
    Public Property DataValue() As String
        Get
            Return _DataValue
        End Get
        Set(ByVal value As String)
            _DataValue = value
        End Set
    End Property


    Public WriteOnly Property DataSource() As DataTable
        Set(ByVal value As DataTable)
            _mdtDataSource = value
            If _mdtDataSource IsNot Nothing Then
                dtPrincipal = _mdtDataSource
                If dtPrincipal.Rows.Count > 0 Then
                    txtPaginaActual.Text = "1"
                    num_paginas()
                    cambiar_pagina()
                    paginar()
                Else
                    MessageBox.Show("No hay Datos Encontrados")
                End If

            End If
            Call pAgregar_Columna()
            Call pCargar_Combos()
            Call pAutoSizeColumns()
            Call pAgregar_Columnas_Busqueda()

            ' Validamos el campo default a presentarse
            If _mintCampoDefault >= 0 Then
                If (_mintCampoDefault - 1) <= (cboAtributos.Items.Count - 1) Then
                    cboAtributos.SelectedIndex = (_mintCampoDefault - 1)
                End If
            End If
            cmdAceptar.Enabled = (Me.dgvBusqueda.RowCount > 0)
        End Set
    End Property


    Public ReadOnly Property SelectedRow() As DataRowView 'GridViewRow
        Get
            ' Asigamos la fila seleccionada
            Return _mdrDataRow
        End Get
    End Property

    Public Property ColumnsHide() As List(Of Object)
        Get
            Return _mobjListColumnsHide
        End Get
        Set(ByVal value As List(Of Object))
            _mobjListColumnsHide = value
        End Set
    End Property

    Public Property MultiSelect() As Boolean
        Get
            Return _mblnMultiSelect
        End Get
        Set(ByVal value As Boolean)
            _mblnMultiSelect = value
        End Set
    End Property

    Public Property SelectedRows() As DataGridViewSelectedRowCollection
        Get
            Return _mdrDataRows
        End Get
        Set(ByVal value As DataGridViewSelectedRowCollection)
            _mdrDataRows = value
        End Set
    End Property

    Public Property CampoDefault() As Int16
        Get
            Return _mintCampoDefault
        End Get
        Set(ByVal value As Int16)
            _mintCampoDefault = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return _mstrTitulo
        End Get
        Set(ByVal value As String)
            _mstrTitulo = value
        End Set
    End Property
#End Region
#Region " Procedimientos y Funciones "
    Private Sub pOcultar_Columnas()
        Dim objColumna As Object
        ' Evaluamos si tenemos columnas
        If _mobjListColumnsHide IsNot Nothing AndAlso _mobjListColumnsHide.Count > 0 Then
            ' Evaluamos si tenemos columnas
            If Me.dgvBusqueda.ColumnCount > 0 Then
                ' Recorremos el listado de las columnas
                For Each objColumna In _mobjListColumnsHide
                    ' Verificamos si existe la columna en la grilla
                    If TypeOf objColumna Is Integer AndAlso CType(objColumna, Integer) >= 0 AndAlso _
                       CType(objColumna, Integer) <= (Me.dgvBusqueda.ColumnCount - 1) Then
                        Me.dgvBusqueda.Columns(CType(objColumna, Integer)).Visible = False
                    End If
                    If TypeOf objColumna Is String AndAlso Me.dgvBusqueda.Columns.Contains(objColumna) Then
                        Me.dgvBusqueda.Columns(CType(objColumna, String)).Visible = False
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub pCapturar_Row()
        Dim intRow As Int32

        ' Capturamos el indice actual
        _mdrDataRow = Nothing
        intRow = Me.dgvBusqueda.CurrentRow.Index

        If intRow = -1 Then
            MessageBox.Show("Seleccione una fila...", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _mdrDataRow = _mdvView.Item(intRow) '  .Table.Rows(intRow) '    _mdtDataSource.Rows(intRow) '  Me.dgvBusqueda.CurrentRow
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub pCapturar_Rows()
        If dgvBusqueda.Rows.Count > 0 Then
            _mdrDataRows = dgvBusqueda.SelectedRows
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub pAgregar_Columna()
        Dim objColumna As DataGridViewColumn = _
                               New DataGridViewTextBoxColumn()
        Try
            With objColumna
                .HeaderText = ""
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Name = "Columna"
            End With
            Me.dgvBusqueda.Columns.Add(objColumna)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Columna Adicional", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If objColumna IsNot Nothing Then objColumna.Dispose()
            objColumna = Nothing
        End Try
    End Sub

    Private Sub pCargar_Combos()
        ' Evaluamos si tenemos columnas
        If Me.dgvBusqueda.Columns.Count > 0 Then
            Dim i As Integer

            ' Agregamos los campos de busqueda
            With Me.dgvBusqueda
                For i = 0 To .Columns.Count - 1
                    cboAtributos.Items.Add(.Columns(i).Name)
                Next i
            End With
        End If
    End Sub

    Private Sub pAutoSizeColumns()
        Dim i As Int32
        With Me.dgvBusqueda
            For i = 0 To .ColumnCount - 1
                .AutoResizeColumn(i)
            Next
        End With
    End Sub

    Private Sub pAgregar_Columnas_Busqueda()
        Dim i As Int16
        If _mdtDataSource IsNot Nothing AndAlso dgvBusqueda.ColumnCount > 0 Then
            With Me.dgvBusqueda
                cboAtributos.Items.Clear()
                For i = 0 To .ColumnCount - 1
                    If .Columns(i).HeaderText <> "" Then
                        cboAtributos.Items.Add(.Columns(i).Name.ToUpper)
                    End If
                Next i
                If cboAtributos.Items.Count > 0 Then cboAtributos.SelectedIndex = 0
            End With
        End If
    End Sub

    Private Sub pBusqueda()
        Dim strFiltro As String
        Try
            ' Primero Capturamos el Atributo
            If cboAtributos.Items.Count > 0 Then
                strFiltro = "[" & cboAtributos.Text & "]"

                If cboOperador.Items.Count > 0 Then
                    Select Case cboOperador.SelectedIndex
                        Case 0 ' IGUAL A
                            strFiltro = strFiltro & " = '" & txtBusqueda.Text & "'"
                        Case 1 ' INICIA EN
                            strFiltro = strFiltro & " LIKE '" & txtBusqueda.Text & "%'"
                        Case 2 ' DISTINTO A
                            strFiltro = strFiltro & " <> '" & txtBusqueda.Text & "'"
                        Case 3 ' TERMINA EN
                            strFiltro = strFiltro & " LIKE '%" & txtBusqueda.Text & "'"
                        Case 4 ' CONTIENE EL TEXTO
                            strFiltro = strFiltro & " LIKE '%" & txtBusqueda.Text & "%'"
                        Case Else
                            strFiltro = ""
                    End Select
                End If
                If txtBusqueda.Text.Trim = "" Then strFiltro = ""
                '_mdvView.RowFilter = strFiltro
                ''dtPrincipal = _mdvView
                dtPrincipal.DefaultView.RowFilter = strFiltro
                num_paginas()
                txtPaginaActual.Text = "1"
                cambiar_pagina()
                paginar()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Búsqueda..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pFormato_Grilla()
        dgvBusqueda.MultiSelect = Me.MultiSelect
        If dgvBusqueda.Rows.Count > 0 Then
            dgvBusqueda.Rows(0).Selected = True
        End If
        'dgvBusqueda.SelectedRows
    End Sub
#End Region
#Region " Metodos "
    Private Sub frmSysBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Titulo
        Me.Text = Me.Text & " - " & Me.Titulo

        ' Ocultar columnas
        Call pOcultar_Columnas()
        Call pFormato_Grilla()
        If cboOperador.Items.Count > 0 Then cboOperador.SelectedIndex = 1
        txtBusqueda.Focus()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        ' Capturar Fila
        If Me.MultiSelect Then
            Call pCapturar_Rows()
        Else
            Call pCapturar_Row()
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        Call pBusqueda()
    End Sub

    Private Sub dgvBusqueda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvBusqueda.DoubleClick
        If dgvBusqueda.Rows.Count > 0 Then
            cmdAceptar.PerformClick()
        End If
    End Sub

    Private Sub dgvBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAceptar.PerformClick()
        End If
    End Sub
#End Region

#Region "Paginar"

    Private Sub cambiar_pagina()
        ini = 0
        fin = 0
        If txtPaginaActual.Text = "1" Then
            fin = VistaDefault - 1
        Else
            ini = ((Convert.ToInt32(txtPaginaActual.Text) - 1) * VistaDefault) - 1
            fin = ini + VistaDefault
        End If

        If fin > dtPrincipal.DefaultView.ToTable.Rows.Count Then
            fin = dtPrincipal.DefaultView.ToTable.Rows.Count - 1
        End If
    End Sub

    Private Sub paginar()
        Dim oDt As New DataTable
        oDt = paginarDataDridView(dtPrincipal.DefaultView, ini, fin)
        _mdvView = oDt.DefaultView
        Me.dgvBusqueda.DataSource = _mdvView
    End Sub

    Private Sub num_paginas()
        If dtPrincipal.Rows.Count Mod VistaDefault = 0 Then
            TotalPaginas = dtPrincipal.DefaultView.ToTable.Rows.Count / VistaDefault
        Else
            Dim value As Double = dtPrincipal.DefaultView.ToTable.Rows.Count / VistaDefault
            TotalPaginas = Math.Floor(value) + 1
        End If
        txtNroTotalPagina.Text = TotalPaginas
        'cbmPaginas.Items.Clear()
        'For i As Integer = 0 To TotalPaginas - 1
        '    cbmPaginas.Items.Add(i + 1)
        'Next
    End Sub

#End Region


    Private Sub btnIrSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If Not IsNumeric(txtPaginaActual.Text) OrElse txtPaginaActual.Text = TotalPaginas Then
            txtPaginaActual.Text = TotalPaginas
        Else
            txtPaginaActual.Text += 1
            cambiar_pagina()
            paginar()
        End If
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If Not IsNumeric(txtPaginaActual.Text) OrElse txtPaginaActual.Text = 1 Then
            txtPaginaActual.Text = 1
        Else
            txtPaginaActual.Text -= 1
            cambiar_pagina()
            paginar()
        End If

    End Sub

    Private Sub btnIrInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        txtPaginaActual.Text = 1
        cambiar_pagina()
        paginar()
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        txtPaginaActual.Text = TotalPaginas
        cambiar_pagina()
        paginar()
    End Sub


    Private Sub txtPaginaActual_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPaginaActual.Validating
        If IsNumeric(Me.txtPaginaActual.Text) AndAlso Val(Me.txtPaginaActual.Text) >= 1 And Val(Me.txtPaginaActual.Text) <= TotalPaginas Then
            cambiar_pagina()
            paginar()
        Else
            Me.txtPaginaActual.Text = 1
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtPaginaActual_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaginaActual.KeyUp
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(Me.txtPaginaActual.Text) AndAlso Val(Me.txtPaginaActual.Text) >= 1 And Val(Me.txtPaginaActual.Text) <= TotalPaginas Then
                cambiar_pagina()
                paginar()
            Else
                Me.txtPaginaActual.Text = 1
                cambiar_pagina()
                paginar()
            End If
        End If
    End Sub

    'Public Sub New()

    '    ' Llamada necesaria para el Diseñador de Windows Forms.
    '    InitializeComponent()

    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    'End Sub


    Public Sub New(ByVal T As Object)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    ''' <summary>
    ''' Pagina la grilla
    ''' </summary>
    ''' <param name="dtPaginar"></param>
    ''' <param name="inicial"></param>
    ''' <param name="final"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function paginarDataDridView(ByVal dtPaginar As DataView, ByVal inicial As Integer, ByVal final As Integer)
        Dim oDt As New DataTable
        Dim dtnew As New DataTable
        oDt = dtPaginar.ToTable()
        dtnew = oDt.Clone
        If oDt.Rows.Count <= final Then
            final = oDt.Rows.Count - 1
        End If
        For i As Integer = inicial To final
            dtnew.ImportRow(oDt.Rows(i))
        Next
        Return dtnew
    End Function


End Class
Imports System.Reflection
Imports System.Windows.Forms

Public Class frmCliente_Check


    Private isCheckCliente As Boolean = False

    Private _objResultado As Object
    Public Property objResultado() As Object
        Get
            Return _objResultado
        End Get
        Set(ByVal value As Object)
            _objResultado = value
        End Set
    End Property

    Private _Valida_Booleam As Boolean
    Public Property Valida_Booleam() As Boolean
        Get
            Return _Valida_Booleam
        End Get
        Set(ByVal value As Boolean)
            _Valida_Booleam = value
        End Set
    End Property

    Private _objResultado1 As Object
    Public Property objResultado1() As Object
        Get
            Return _objResultado1
        End Get
        Set(ByVal value As Object)
            _objResultado1 = value
        End Set
    End Property

    Private _DispleyMember As String = ""
    Public Property DispleyMember() As String
        Get
            Return _DispleyMember
        End Get
        Set(ByVal value As String)
            _DispleyMember = value
        End Set
    End Property

    Private _ValueMember As String = ""
    Public Property ValueMember() As String
        Get
            Return _ValueMember
        End Get
        Set(ByVal value As String)
            _ValueMember = value
        End Set
    End Property


    Private _ListaItems_ValueMember As List(Of String)
    Public Property ListaItems_ValueMember() As List(Of String)
        Get
            Return _ListaItems_ValueMember
        End Get
        Set(ByVal value As List(Of String))
            _ListaItems_ValueMember = value
        End Set
    End Property


    Private bs As New BindingSource
    Private mDataSource As Object
    Private FiltroData As Object
    Private mFila As DataGridViewRow

    Public Property DataSource() As Object
        Get
            Return (mDataSource)
        End Get
        Set(ByVal value As Object)
            mDataSource = value
            If mDataSource IsNot Nothing AndAlso mDataSource.Count > 0 Then

                Dim oDtColumnas As New DataTable
                Dim oDrColumns As DataRow
                oDtColumnas.Columns.Add("Codigo")
                oDtColumnas.Columns.Add("Descripcion")

                For x As Integer = 0 To dtgData.ColumnCount - 1
                    oDrColumns = oDtColumnas.NewRow
                    oDrColumns.Item(0) = dtgData.Columns(x).DataPropertyName
                    oDrColumns.Item(1) = dtgData.Columns(x).HeaderText
                    oDtColumnas.Rows.Add(oDrColumns)
                Next
                'cboCriterio.DataSource = oDtColumnas
                'cboCriterio.ValueMember = "Codigo"
                'cboCriterio.DisplayMember = "Descripcion"


                'cboCriterio.SelectedIndex = 0
                bs.DataSource = mDataSource
                dtgData.DataSource = bs
            End If
        End Set
    End Property

    'Private Sub CrearOrdenacion()
    '    Dim cmp As Type = GetType(Comparador(Of ))
    '    Dim tipo As Type = mDataSource(0).GetType
    '    Dim tipos() As Type = {tipo}
    '    Dim obj As Type = cmp.MakeGenericType(tipo)
    '    mDataSource.Sort(Activator.CreateInstance(obj, cboCriterio.SelectedValue))
    '    MostrarTodo()
    'End Sub

    Private Sub MostrarTodo()
        bs.DataSource = mDataSource
        dtgData.DataSource = bs
        dtgData.Refresh()
    End Sub


    Public Property Titulo() As String
        Get
            Return (Me.Text)
        End Get
        Set(ByVal value As String)
            Me.Text = value
        End Set
    End Property

    Public Property Fila() As DataGridViewRow
        Get
            Return (mFila)
        End Get
        Set(ByVal value As DataGridViewRow)
            mFila = value
        End Set
    End Property


    Dim _ItemsV As New List(Of String)
    Dim _ItemsV1 As String

    Public Property ItemsV() As List(Of String)
        Get
            Return (_ItemsV)
        End Get
        Set(ByVal value As List(Of String))
            _ItemsV = value
        End Set
    End Property

    Dim _ItemsS As New List(Of String)

    Public Property ItemsS() As List(Of String)
        Get
            Return (_ItemsS)
        End Get
        Set(ByVal value As List(Of String))
            _ItemsS = value
        End Set
    End Property

    Private Sub dtgData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgData.CellClick
        If e.ColumnIndex = 0 Then

            If dtgData.CurrentRow.Cells("Estado").Value = 0 Then
                Me.dtgData.CurrentRow.Cells("Estado").Value = 1
                Me.dtgData.CurrentRow.Cells("CHK").Value = True

                _ItemsV.Add(Me.dtgData.CurrentRow.Cells("Codigo").Value.ToString.Trim)
                _ItemsS.Add(Me.dtgData.CurrentRow.Cells("Descripcion").Value.ToString)

            Else
                Me.dtgData.CurrentRow.Cells("Estado").Value = 0
                Me.dtgData.CurrentRow.Cells("CHK").Value = False

                _ItemsV.Remove(Me.dtgData.CurrentRow.Cells("Codigo").Value.ToString)
                _ItemsS.Remove(Me.dtgData.CurrentRow.Cells("Descripcion").Value.ToString)

            End If
        End If
    End Sub


    Private Sub NoOrdenarGrilla()
        Dim I As Integer
        For I = 0 To dtgData.ColumnCount - 1
            dtgData.Columns(I).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub OrdenarDatos(ByVal sender As Object, ByVal e As System.EventArgs)
        'CrearOrdenacion()
    End Sub

    Private Sub Buscar_Filtrar_Criterio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDato.TextChanged
        If txtDato.Text <> "" Then
            If mDataSource Is Nothing Then Exit Sub
            Dim pre As Type = GetType(Predicado(Of ))
            Dim tipo As Type = mDataSource(0).GetType
            Dim tipos() As Type = {tipo}
            Dim obj As Type = pre.MakeGenericType(tipos)
            Dim oPred As Object = Activator.CreateInstance(obj, _DispleyMember, "*" & txtDato.Text.Trim.ToUpper)
            If chkMientrasEscribe.Checked Then
                'Filtrar
                FiltroData = mDataSource.FindAll(oPred.Predicado)
                bs.DataSource = FiltroData
                dtgData.DataSource = bs
                dtgData.Refresh()
            Else
                'Buscar
                Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                If pos > -1 Then bs.Position = pos
            End If

            If Valida_Booleam = True Then
                'Filtrar
                FiltroData = mDataSource.FindAll(oPred.Predicado)
                bs.DataSource = FiltroData
                dtgData.DataSource = bs
                dtgData.Refresh()
                Valida_Booleam = False
            Else
                'Buscar
                Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                If pos > -1 Then bs.Position = pos
                Valida_Booleam = False
            End If
        Else
            MostrarTodo()
        End If
    End Sub

    Private Sub Buscar_Filtrar_RUC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.TextChanged
        If txtRUC.Text <> "" Then
            If mDataSource Is Nothing Then Exit Sub
            Dim pre As Type = GetType(Predicado(Of ))
            Dim tipo As Type = mDataSource(0).GetType
            Dim tipos() As Type = {tipo}
            Dim obj As Type = pre.MakeGenericType(tipos)
            Dim oPred As Object = Activator.CreateInstance(obj, "RUC", txtRUC.Text.Trim.ToUpper)
            If chkMientrasEscribe.Checked Then
                'Filtrar
                FiltroData = mDataSource.FindAll(oPred.Predicado)
                bs.DataSource = FiltroData
                dtgData.DataSource = bs
                dtgData.Refresh()
            Else
                'Buscar
                Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                If pos > -1 Then bs.Position = pos
            End If
        Else
            MostrarTodo()
        End If
    End Sub

    Public Sub Buscar()
        Buscar_Filtrar_Criterio(Nothing, Nothing)
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

        If txtCodigo.Text <> "" And IsNumeric(txtCodigo.Text) Then
            If mDataSource Is Nothing Then Exit Sub
            Dim pre As Type = GetType(Predicado(Of ))
            Dim tipo As Type = mDataSource(0).GetType
            Dim tipos() As Type = {tipo}
            Dim obj As Type = pre.MakeGenericType(tipos)
            Dim oPred As Object = Activator.CreateInstance(obj, _ValueMember, "*" & txtCodigo.Text.Trim.ToUpper)
            If chkMientrasEscribe.Checked Then
                'Filtrar
                FiltroData = mDataSource.FindAll(oPred.Predicado)
                bs.DataSource = FiltroData
                dtgData.DataSource = bs
                dtgData.Refresh()
            Else
                'Buscar
                Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                If pos > -1 Then bs.Position = pos
            End If

            If Valida_Booleam = True Then
                'Filtrar
                FiltroData = mDataSource.FindAll(oPred.Predicado)
                bs.DataSource = FiltroData
                dtgData.DataSource = bs
                dtgData.Refresh()
                Valida_Booleam = False
            Else
                'Buscar
                Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                If pos > -1 Then bs.Position = pos
                Valida_Booleam = False
            End If

        Else
            MostrarTodo()
        End If


    End Sub


    Private Sub frmCliente_Check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Inicializar()
        _ItemsV = New List(Of String)
        _ItemsS = New List(Of String)

    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        dtgData.EndEdit()
        isCheckCliente = Not isCheckCliente
        Poner_Check_Todo_Opcion(isCheckCliente)
    End Sub

    Private Sub Poner_Check_Todo_Opcion(ByVal blnEstado As Boolean)

        _ItemsV = New List(Of String)
        _ItemsS = New List(Of String)

        Dim intCont As Integer
        If blnEstado = True Then
            For intCont = 0 To dtgData.RowCount - 1
                dtgData.Rows(intCont).Cells("CHK").Value = blnEstado
                If blnEstado = False Then
                    dtgData.Rows(intCont).Cells("Estado").Value = 0
                    _ItemsV.Add(Me.dtgData.Item("Codigo", intCont).Value.ToString)
                    _ItemsS.Add(Me.dtgData.Item("Descripcion", intCont).Value.ToString)
                Else
                    dtgData.Rows(intCont).Cells("Estado").Value = 1
                    _ItemsV.Add(Me.dtgData.Item("Codigo", intCont).Value.ToString)
                    _ItemsS.Add(Me.dtgData.Item("Descripcion", intCont).Value.ToString)
                End If

            Next
        Else
            For intCont = 0 To dtgData.RowCount - 1
                dtgData.Rows(intCont).Cells("CHK").Value = blnEstado
                dtgData.Rows(intCont).Cells("Estado").Value = 0
            Next
        End If
    End Sub

    Sub Inicializar()
        For i As Integer = 0 To dtgData.RowCount - 1
            dtgData.Rows(i).Cells("Estado").Value = 0
            dtgData.Rows(i).Cells("CHK").Value = False
        Next
    End Sub

    Private Sub dtgData_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgData.DataBindingComplete

        If dtgData.Rows.Count > 0 Then
            For i As Integer = 0 To dtgData.RowCount - 1
                If dtgData.Rows(i).Cells("Estado").Value = 1 Then
                    dtgData.Rows(i).Cells("CHK").Value = True
                Else
                    dtgData.Rows(i).Cells("CHK").Value = False
                End If
            Next
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If ItemsV.Count = 0 Then
            objResultado = Nothing
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End If


        'Dim tipo As Type = mDataSource(0).GetType
        'Dim ListaObj As New List(Of Object)

        'For i As Integer = 0 To dtgData.Rows.Count - 1

        'Next

        objResultado = ItemsV
        objResultado1 = ItemsS
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        objResultado = Nothing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtCodigo.Text <> "" Then
                If mDataSource Is Nothing Then Exit Sub
                Dim pre As Type = GetType(Predicado(Of ))
                Dim tipo As Type = mDataSource(0).GetType
                Dim tipos() As Type = {tipo}
                Dim obj As Type = pre.MakeGenericType(tipos)
                Dim oPred As Object = Activator.CreateInstance(obj, _ValueMember, txtCodigo.Text.Trim.ToUpper)
                If chkFiltrar.Checked Then
                    'Filtrar
                    FiltroData = mDataSource.FindAll(oPred.Predicado)
                    bs.DataSource = FiltroData
                    dtgData.DataSource = bs
                    dtgData.Refresh()
                Else
                    'Buscar
                    Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                    If pos > -1 Then bs.Position = pos
                End If
            Else
                MostrarTodo()
            End If

        End If
    End Sub


    Private Sub txtDato_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDato.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDato.Text <> "" Then
                If mDataSource Is Nothing Then Exit Sub
                Dim pre As Type = GetType(Predicado(Of ))
                Dim tipo As Type = mDataSource(0).GetType
                Dim tipos() As Type = {tipo}
                Dim obj As Type = pre.MakeGenericType(tipos)
                Dim oPred As Object = Activator.CreateInstance(obj, _DispleyMember, "*" & txtDato.Text.Trim.ToUpper)
                If chkFiltrar.Checked Then
                    'Filtrar
                    FiltroData = mDataSource.FindAll(oPred.Predicado)
                    bs.DataSource = FiltroData
                    dtgData.DataSource = bs
                    dtgData.Refresh()
                Else
                    'Buscar
                    Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                    If pos > -1 Then bs.Position = pos
                End If
            Else
                MostrarTodo()
            End If

        End If
    End Sub

    Private Sub txtRUC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtRUC.Text <> "" Then
                If mDataSource Is Nothing Then Exit Sub
                Dim pre As Type = GetType(Predicado(Of ))
                Dim tipo As Type = mDataSource(0).GetType
                Dim tipos() As Type = {tipo}
                Dim obj As Type = pre.MakeGenericType(tipos)
                Dim oPred As Object = Activator.CreateInstance(obj, "RUC", txtRUC.Text.Trim.ToUpper)
                If chkFiltrar.Checked Then
                    'Filtrar
                    FiltroData = mDataSource.FindAll(oPred.Predicado)
                    bs.DataSource = FiltroData
                    dtgData.DataSource = bs
                    dtgData.Refresh()
                Else
                    'Buscar
                    Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
                    If pos > -1 Then bs.Position = pos
                End If
            Else
                MostrarTodo()
            End If

        End If
    End Sub
End Class
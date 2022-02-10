Imports System.Reflection
Imports System.Windows.Forms

Public Class frmBusqueda

    Private _objResultado As Object
    Public Property objResultado() As Object
        Get
            Return _objResultado
        End Get
        Set(ByVal value As Object)
            _objResultado = value
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

    Private _Etiquetas_Form As List(Of String) = Nothing
    Public Property Etiquetas_Form() As List(Of String)
        Get
            Return _Etiquetas_Form
        End Get
        Set(ByVal value As List(Of String))
            _Etiquetas_Form = value
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

    Private _PopupHeight As Integer
    Public Property PopupHeight() As Integer
        Get
            Return _PopupHeight
        End Get
        Set(ByVal value As Integer)
            _PopupHeight = value
        End Set
    End Property

    Private _PopupWidth As Integer
    Public Property PopupWidth() As Integer
        Get
            Return _PopupWidth
        End Get
        Set(ByVal value As Integer)
            _PopupWidth = value
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

    Private Sub CerrarForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgData.DoubleClick
        Me.Close()
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
            Dim oPred As Object = Activator.CreateInstance(obj, _DispleyMember, "*" & txtDato.Text.Trim.ToUpper & "*")
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
    End Sub


    Private Sub dtgAyuda_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgData.CellMouseDoubleClick
        If Me.dtgData.CurrentCellAddress.Y = -1 Then
            objResultado = Nothing
            Exit Sub
        End If

        objResultado = Me.dtgData.CurrentRow.DataBoundItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
 
     
    Public Sub Buscar()
        Buscar_Filtrar_Criterio(Nothing, Nothing)
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text <> "" Then
            If mDataSource Is Nothing Then Exit Sub
            Dim pre As Type = GetType(Predicado(Of ))
            Dim tipo As Type = mDataSource(0).GetType
            Dim tipos() As Type = {tipo}
            Dim obj As Type = pre.MakeGenericType(tipos)
            Dim oPred As Object = Activator.CreateInstance(obj, _ValueMember, "*" & txtCodigo.Text.Trim.ToUpper & "*")
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
    End Sub

   
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        objResultado = Nothing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmBusqueda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If _Etiquetas_Form IsNot Nothing Then

            lblBusqueda.Text = _Etiquetas_Form(0).ToString.Trim
            lblDato.Text = _Etiquetas_Form(1).ToString.Trim

        End If

        If PopupHeight <> 0 Then
            Me.Height = PopupHeight
        End If
        If PopupWidth <> 0 Then
            Me.Width = PopupWidth
        End If

    End Sub
End Class

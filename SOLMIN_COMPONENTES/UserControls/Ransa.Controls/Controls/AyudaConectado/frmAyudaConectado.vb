Imports System.Reflection
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports System.Windows.Forms

Public Class frmAyudaConectado

    Private _objResultado As Object
    Public Property objResultado() As Object
        Get
            Return _objResultado
        End Get
        Set(ByVal value As Object)
            _objResultado = value
        End Set
    End Property


    Private _CriterioBusqueda As ParametrosGlobales.TipoBusqueda
    Public Property CriterioBusqueda() As ParametrosGlobales.TipoBusqueda
        Get
            Return _CriterioBusqueda
        End Get
        Set(ByVal value As ParametrosGlobales.TipoBusqueda)
            _CriterioBusqueda = value
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
                cboCriterio.DataSource = oDtColumnas
                cboCriterio.ValueMember = "Codigo"
                cboCriterio.DisplayMember = "Descripcion"
                cboCriterio.SelectedIndex = 0
                bs.DataSource = mDataSource
                dtgData.DataSource = bs
                If TryCast(bs.DataSource, List(Of beMercaderia)).Count > 0 Then
                    UcPaginacion1.PageCount = TryCast(bs.DataSource, List(Of beMercaderia)).Item(0).PageCount
                End If
            End If
        End Set
    End Property

    Private Sub CrearOrdenacion()
        Dim cmp As Type = GetType(Comparador(Of ))
        Dim tipo As Type = mDataSource(0).GetType
        Dim tipos() As Type = {tipo}
        Dim obj As Type = cmp.MakeGenericType(tipo)
        mDataSource.Sort(Activator.CreateInstance(obj, cboCriterio.SelectedValue))
        MostrarTodo()
    End Sub

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

    Private Sub OrdenarDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCriterio.SelectionChangeCommitted
        CrearOrdenacion()
    End Sub

    Private Sub Buscar_Filtrar_Criterio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDato.TextChanged
        UcPaginacion1.PageNumber = 1
        BuscarDatos()
    End Sub

    Private Sub dtgAyuda_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgData.CellMouseDoubleClick
        If Me.dtgData.CurrentCellAddress.Y = -1 Then
            objResultado = Nothing
            Exit Sub
        End If
        objResultado = Me.dtgData.CurrentRow.DataBoundItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        dtgAyuda_CellMouseDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        objResultado = Nothing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Public Sub Buscar()
        Buscar_Filtrar_Criterio(Nothing, Nothing)
    End Sub

    Private Sub BuscarDatos()
        Try
            Select Case _CriterioBusqueda

                Case ParametrosGlobales.TipoBusqueda.Marca
                    'Dim obrMercaderia As New brMercaderia
                    Dim obrMercaderia As New brMercaderia_BL
                    Dim obemercaderia As New beMercaderia
                    With obemercaderia
                        If Me.cboCriterio.SelectedValue = "PNCMRCA" Then
                            .PNCMRCA = Val(Me.txtDato.Text)
                        Else
                            .PSTCMMRC = Me.txtDato.Text.Trim.ToUpper
                        End If
                        .PageSize = Me.UcPaginacion1.PageSize
                        .PageNumber = Me.UcPaginacion1.PageNumber
                    End With
                    bs.DataSource = obrMercaderia.ListaMarca(obemercaderia)
                    If TryCast(bs.DataSource, List(Of beMercaderia)).Count > 0 Then
                        UcPaginacion1.PageCount = TryCast(bs.DataSource, List(Of beMercaderia)).Item(0).PageCount
                    End If
                    dtgData.DataSource = bs
                    dtgData.Refresh()
            End Select
        Catch ex As Exception
            dtgData.DataSource = Nothing
            dtgData.Refresh()
        End Try
    End Sub


    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        BuscarDatos()
    End Sub
End Class

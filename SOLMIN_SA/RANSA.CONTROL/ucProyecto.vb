Imports System.ComponentModel
Imports RANSA.NEGO
Imports RANSA.DATA
Imports RANSA.TYPEDEF
Imports System.Windows.Forms

Public Class ucProyecto
    Private colListas As New Hashtable

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        colListas = New Hashtable
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pnlMensaje.Visible = False
        dgProyecto.ShowCellErrors = True

    End Sub

    Public Event AgregarProyecto()
    Private intCantidad As Decimal = 0
    Private boEstado As Boolean = True


    Private _EsDevolucion As Boolean = False
    Public Property EsDevolucion() As Boolean
        Get
            Return _EsDevolucion
        End Get
        Set(ByVal value As Boolean)
            _EsDevolucion = value
        End Set
    End Property


    Public Function ListarProyectos(ByVal obeProyecto As beProyecto) As List(Of beProyecto)
        intCantidad = obeProyecto.PNQTRMC
        Me.dgProyecto.EndEdit()
        Dim key As New KeyValuePair(Of Int64, Int32)(obeProyecto.PNNORDSR, obeProyecto.PNNRITOC)
        Dim intSuma As Decimal
        Dim oListaProyecto As New beList(Of beProyecto)
        If Not colListas.ContainsKey(key) Then
            intSuma = 0
            Dim objBRProyecto As New brProyecto
            oListaProyecto = objBRProyecto.ListaProyectos(obeProyecto)
            If (oListaProyecto.Count > 0) Then

                For Each oProyecto As beProyecto In oListaProyecto
                    If Not EsDevolucion Then
                        intSuma += oProyecto.PNQPENDI
                    Else
                        intSuma += oProyecto.PNQCNDPC
                    End If

                Next

                If (obeProyecto.PNQTRMC = intSuma) Then
                    For Each oProyecto As beProyecto In oListaProyecto
                        If Not EsDevolucion Then
                            oProyecto.PNQCNTIT2 = oProyecto.PNQPENDI
                        Else
                            oProyecto.PNQCNTIT2 = oProyecto.PNQCNDPC
                        End If
                    Next
                    colListas(key) = oListaProyecto
                    dgProyecto.AutoGenerateColumns = False
                    dgProyecto.DataSource = colListas(key)
                Else
                    colListas(key) = oListaProyecto
                    dgProyecto.AutoGenerateColumns = False
                    dgProyecto.DataSource = colListas(key)
                End If
            Else
                dgProyecto.DataSource = colListas(key)
            End If

            Return oListaProyecto
        Else
            boEstado = False
            dgProyecto.DataSource = colListas(key)
            boEstado = True
            Return colListas(key)
        End If
    End Function


    Private Sub dgProyecto_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgProyecto.CellValidating
        If Not boEstado Then Exit Sub
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = 4 Then
            If IsNumeric(e.FormattedValue) Then
                If e.FormattedValue = 0 Then Exit Sub
                If Not EsDevolucion Then
                    If e.FormattedValue > Me.dgProyecto.CurrentRow.DataBoundItem.PNQPENDI Or e.FormattedValue > intCantidad Then
                        MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    End If
                Else
                    If e.FormattedValue > Me.dgProyecto.CurrentRow.DataBoundItem.PNqcnrcp Or e.FormattedValue > intCantidad Then
                        MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    End If
                End If

            Else
                MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        End If


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        RaiseEvent AgregarProyecto()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgProyecto.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Esta seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim objBRProyecto As New brProyecto
            Dim obeProyecto As beProyecto
            obeProyecto = dgProyecto.CurrentRow.DataBoundItem
            If obeProyecto.PNQCNRCP <> 0 Then
                MessageBox.Show("No se puede eliminar el registro porque tiene movimientos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If objBRProyecto.fintEliminarProyecto(obeProyecto) Then
                Dim olobeProyecto As New List(Of beProyecto)
                olobeProyecto = dgProyecto.DataSource
                olobeProyecto.Remove(dgProyecto.CurrentRow.DataBoundItem)
                dgProyecto.DataSource = Nothing
                dgProyecto.DataSource = olobeProyecto
                MessageBox.Show("El registro se elimino satisfactiroamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

   
End Class

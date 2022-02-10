Imports RANSA.TypeDef
Imports RANSA.NEGO
Imports Ransa.TypeDef.Cliente
Imports RANSA.Utilitario
Public Class frmMantenimientoProyecto

#Region "Atributos"

    Private _Proyecto As beProyecto
    Public Property Proyecto() As beProyecto
        Get
            Return _Proyecto
        End Get
        Set(ByVal value As beProyecto)
            _Proyecto = value
        End Set
    End Property

#End Region

    Private Sub VisualizarDatosProyecto()
        Me.txtOc.Text = _Proyecto.PSNORCML
        Me.txtNroItem.Text = _Proyecto.PNNRITOC
        Me.txtOS.Text = _Proyecto.PNNORDSR
        Me.txtCantidadRecepcionada.Text = _Proyecto.PNQINMC2
        Dim oListaProyecto As New beList(Of beProyecto)
        Dim objBRProyecto As New brProyecto
        BeProyectoBindingSource.DataSource = objBRProyecto.ListaProyectos(_Proyecto)
        'dgProyecto.DataSource = oListaProyecto
    End Sub

    Private Sub frmMantenimientoSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VisualizarDatosProyecto()
    End Sub

  

   
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim obeProyecto As New beProyecto
        BeProyectoBindingSource.Add(obeProyecto)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'FALTA VALIDACION
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
              BeProyectoBindingSource.Remove(Me.dgProyecto.CurrentRow.DataBoundItem)
                MessageBox.Show("El registro se elimino satisfactiroamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        dgProyecto.EndEdit()
        If dgProyecto.Rows.Count = 0 Then Exit Sub
        Dim bolContieneCheck As Boolean = False
        Dim decSuma As Decimal = 0

        For Each obeProy As beProyecto In dgProyecto.DataSource
            If obeProy.PNQCNTIT = 0 Then
                HelpClass.MsgBox("La cantidad debe de ser mayor a Cero")
                Exit Sub
            End If
            If obeProy.PNQCNTIT < obeProy.PNQCNRCP Then
                HelpClass.MsgBox("Cantidad solicitada de ser mayor o igual a la cantidad ingresada")
                Exit Sub
            End If
            decSuma += obeProy.PNQCNRCP
            If _Proyecto.PNQINMC2 < decSuma Then
                HelpClass.MsgBox("la suma de las Cantidades  Recepcionadas de los proyectos exceden a la cantidad  recepcionada de la Orden de compra item")
                Exit Sub
            End If

            bolContieneCheck = True
        Next
        If bolContieneCheck = False Then Exit Sub

        Dim obeDetProyecto As beProyecto
        Dim obrOrdeDePedCopra As New brProyecto
        For intCont As Integer = 0 To dgProyecto.RowCount - 1
            obeDetProyecto = New beProyecto
            With obeDetProyecto
                .PNCCLNT = _Proyecto.PNCCLNT
                .PSNORCML = _Proyecto.PSNORCML
                .PNNRITOC = _Proyecto.PNNRITOC
                .PSNRFRPD = dgProyecto.Rows(intCont).Cells("PSNRFRPD").Value
                .PNQCNTIT = dgProyecto.Rows(intCont).Cells("PNQCNTIT").Value
                .PNQCNRCP = dgProyecto.Rows(intCont).Cells("PNQCNRCP").Value
                .PSNTRMCR = HelpClass.NombreMaquina
                .PSNTRMNL = HelpClass.NombreMaquina
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PSCULUSA = objSeguridadBN.pUsuario
                .PSSESTRG = "A"
                If obrOrdeDePedCopra.fIntInsertarProyectoOcRegularizacion(obeDetProyecto) = 0 Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
            End With
        Next
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

   

    Private Sub dgProyecto_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgProyecto.CellValidating
        If e.ColumnIndex = 1 Then
            If IsNumeric(e.FormattedValue) Then
                If e.FormattedValue = 0 Then Exit Sub
                If e.FormattedValue < Me.dgProyecto.CurrentRow.DataBoundItem.PNQCNRCP Then
                    MessageBox.Show("Cantidad solicitada debe de ser mayor o igual a la cantidad ingresada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
        End If
        If e.ColumnIndex = 2 Then
            If IsNumeric(e.FormattedValue) Then
                If e.FormattedValue = 0 Then Exit Sub
                If e.FormattedValue > Me.dgProyecto.CurrentRow.DataBoundItem.PNQCNTIT Then
                    MessageBox.Show("Cantidad ingresada debe de ser menor o igual a la cantidad Solicitada ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgProyecto_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgProyecto.DataError
    End Sub

End Class

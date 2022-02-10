Imports RANSA.TYPEDEF
Imports RANSA.NEGO

Public Class frmInventarioProyecto



    Private _OrdenServicio As Decimal
    Public Property OrdenServicio() As Decimal
        Get
            Return _OrdenServicio
        End Get
        Set(ByVal value As Decimal)
            _OrdenServicio = value
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmInventarioProyecto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListaProyecto()
    End Sub

    Private Sub ListaProyecto()
        Dim oListaProyecto As New beList(Of beProyecto)
        Dim objBRProyecto As New brProyecto
        Dim obeProyecto As New beProyecto
        With obeProyecto
            .PNNORDSR = _OrdenServicio
        End With
        oListaProyecto = objBRProyecto.flistProyectosXOs(obeProyecto)
        dgProyecto.AutoGenerateColumns = False
        dgProyecto.DataSource = oListaProyecto
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaAgregar.Click
        If Me.dgProyecto.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmMantenimientoProyecto As New frmMantenimientoProyecto
        ofrmMantenimientoProyecto.Proyecto = Me.dgProyecto.CurrentRow.DataBoundItem
        If ofrmMantenimientoProyecto.ShowDialog = Windows.Forms.DialogResult.OK Then
            ListaProyecto()
        End If
    End Sub
End Class

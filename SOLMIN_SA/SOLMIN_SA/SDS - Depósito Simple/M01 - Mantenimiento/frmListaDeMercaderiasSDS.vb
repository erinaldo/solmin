Imports Ransa.NEGO
Imports Ransa.TypeDef

Public Class frmListaDeMercaderiasSDS


    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _obeMercaderia As beMercaderia
    Public Property obeMercaderia() As beMercaderia
        Get
            Return _obeMercaderia
        End Get
        Set(ByVal value As beMercaderia)
            _obeMercaderia = value
        End Set
    End Property


    Private Sub frmListaDeMercaderiasSDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pActualizarInformacion()
    End Sub

    Private Sub txtFiltroMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroMercaderia.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.txtFiltroMercaderia.Text.Trim.Equals("") Then
                Me.UcPaginacion.PageNumber = 1
            End If
            pActualizarInformacion()
        End If
    End Sub

    Private Sub pActualizarInformacion()
        dgMercaderias.AutoGenerateColumns = False
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        With obeMercaderia
            .PNCCLNT = _PNCCLNT
            .PageSize = Me.UcPaginacion.PageSize
            .PageNumber = Me.UcPaginacion.PageNumber
            .PSCMRCLR = txtFiltroMercaderia.Text
        End With

        dgMercaderias.DataSource = obrMercaderia.ListarMercaderiaPorCliente(obeMercaderia)
        If TryCast(dgMercaderias.DataSource, List(Of beMercaderia)).Count > 0 Then
            UcPaginacion.PageCount = TryCast(dgMercaderias.DataSource, List(Of beMercaderia)).Item(0).PageCount
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgMercaderias_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderias.CellDoubleClick
        If Me.dgMercaderias.CurrentCellAddress.Y = -1 Then Exit Sub
        _obeMercaderia = Me.dgMercaderias.CurrentRow.DataBoundItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnACeptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACeptar.Click
        dgMercaderias_CellDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        pActualizarInformacion()
    End Sub
End Class

Imports Ransa.NEGO
Imports Ransa.TypeDef

Public Class frmListaPosiciones


    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _PSCTPALM As String
    Public Property PSCTPALM() As String
        Get
            Return _PSCTPALM
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property


    Private _PSCALMC As String
    Public Property PSCALMC() As String
        Get
            Return _PSCALMC
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property


    Private _PSCSECTR As String
    Public Property PSCSECTR() As String
        Get
            Return _PSCSECTR
        End Get
        Set(ByVal value As String)
            _PSCSECTR = value
        End Set
    End Property

    Private _obeUbicacion As beUbicacion
    Public Property obeUbicacion() As beUbicacion
        Get
            Return _obeUbicacion
        End Get
        Set(ByVal value As beUbicacion)
            _obeUbicacion = value
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnACeptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACeptar.Click
        dgSloting_CellDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub frmListaDeSloting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarGrilla()
    End Sub

    Private Sub CargarGrilla()
        Dim oBR As New brUbicacion()
        dgPosiciones.AutoGenerateColumns = False
        Dim lis As List(Of beUbicacion) = oBR.Listar(_PSCTPALM, _PSCALMC, _PSCSECTR, Me.txtFiltroPosicion.Text, UcPaginacion)
        dgPosiciones.DataSource = lis
    End Sub


    Private Sub txtFiltroPosicion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroPosicion.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.txtFiltroPosicion.Text.Trim.Equals("") Then
                Me.UcPaginacion.PageNumber = 1
            End If
            CargarGrilla()
        End If

    End Sub

    Private Sub dgSloting_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPosiciones.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        _obeUbicacion = Me.dgPosiciones.CurrentRow.DataBoundItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        CargarGrilla()
    End Sub

   
End Class

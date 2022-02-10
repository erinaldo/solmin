Imports RANSA.Utilitario
Imports Ransa.TYPEDEF
Imports Ransa.NEGO

Public Class frmAgregarDetallePedido

    Private intCCLNT As Integer
    Public Property PNCCLNT() As Integer
        Get
            Return intCCLNT
        End Get
        Set(ByVal value As Integer)
            intCCLNT = value
        End Set
    End Property


    Private strNRFRPD As String
    Public Property PSNRFRPD() As String
        Get
            Return strNRFRPD
        End Get
        Set(ByVal value As String)
            strNRFRPD = value
        End Set
    End Property


    Private _oResultado As List(Of beMercaderia)
    Public Property oResultado() As List(Of beMercaderia)
        Get
            Return _oResultado
        End Get
        Set(ByVal value As List(Of beMercaderia))
            _oResultado = value
        End Set
    End Property


    Private Sub frmAgregarDetallePedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListaDeMercaderiaPorPedido()
    End Sub

    Private Sub ListaDeMercaderiaPorPedido()
        Dim obeMercaderia As New beMercaderia
        Dim obrMercaderia As New brMercaderia

        With obeMercaderia
            .PNCCLNT = intCCLNT
            .PSNRFRPD = strNRFRPD
            .PSCMRCLR = Me.tstCodMercaderia.Text
        End With
        Me.dgItemPedido.AutoGenerateColumns = False
        Me.dgItemPedido.DataSource = obrMercaderia.flistListarMercaderiaPorPedido(obeMercaderia)
    End Sub

    Private Sub tstCodMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tstCodMercaderia.KeyPress
        If e.KeyChar = Chr(13) Then
            ListaDeMercaderiaPorPedido()
        End If
    End Sub

    Private Sub tsbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAceptar.Click
        Me.dgItemPedido.EndEdit()
        _oResultado = New List(Of beMercaderia)
        For Each obeMercaderia As beMercaderia In Me.dgItemPedido.DataSource
            If obeMercaderia.CHK Then
                _oResultado.Add(obeMercaderia)
            End If
        Next
        If _oResultado.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub dgItemPedido_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemPedido.CellClick
        If e.ColumnIndex = 0 Then
            If Me.dgItemPedido.CurrentRow.Cells("CHK").Value Then
                Me.dgItemPedido.CurrentRow.Cells("CHK").Value = False
                dgItemPedido.EndEdit()
                Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").ReadOnly = True
                Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").Value = 0D

            Else
                Me.dgItemPedido.CurrentRow.Cells("CHK").Value = True
                dgItemPedido.EndEdit()
                Me.dgItemPedido.CurrentCell = Me.dgItemPedido.Item("PNQSRVC", dgItemPedido.CurrentCellAddress.Y)
                Me.dgItemPedido.CurrentCell.Selected = True
                Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").ReadOnly = False
                Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").Value = 0D

            End If
        End If

    End Sub

    Private Sub dgItemPedido_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemPedido.CellEndEdit
        'If e.ColumnIndex = 0 Then
        '    If Me.dgItemPedido.CurrentRow.Cells("CHK").Value Then
        '        Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").ReadOnly = True
        '        Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").Value = 0D
        '    Else
        '        Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").ReadOnly = False
        '        Me.dgItemPedido.CurrentRow.Cells("PNQSRVC").Value = 0D
        '    End If
        'End If
    End Sub


    Private Sub dgItemPedido_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgItemPedido.CellValidating
        If dgItemPedido.Columns(e.ColumnIndex).Name = "PNQSRVC" Then
            'SI EL SALDO ES MAYOR QUE LA CANTIDAD SOLICITADA NO PROCEDE 
            If IsNumeric(e.FormattedValue) Then
                If CType(dgItemPedido.CurrentRow.DataBoundItem, beMercaderia).PNQSLMC < e.FormattedValue Then
                    MessageBox.Show("La Cantidad Solicitada es mayor que el Saldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            Else
                MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class

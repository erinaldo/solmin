Imports RANSA.TYPEDEF
Imports Ransa.NEGO
Imports RANSA.Utilitario

Public Class frmAgregarProyecto

    Private _strCodItem As String
    Public Property pstrCodItem() As String
        Get
            Return _strCodItem
        End Get
        Set(ByVal value As String)
            _strCodItem = value
        End Set
    End Property


    Private _objOC As beOrdenCompra
    Public Property objOrdenCompra() As beOrdenCompra
        Get
            Return _objOC
        End Get
        Set(ByVal value As beOrdenCompra)
            _objOC = value
        End Set
    End Property


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim obrPedido As New brInterfazOutoTec
        Dim oParametro As New beDetInfzPedidoOuototec
        With oParametro
            .nordpe = txtNroPedido.Text
            .citems = _objOC.PSTCITCL
        End With
        dgItemPedido.AutoGenerateColumns = False
        dgItemPedido.DataSource = obrPedido.flistObtenerPedidoOutotecXItem(oParametro).Tables(0)
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        dgItemPedido.EndEdit()
        If dgItemPedido.Rows.Count = 0 Then Exit Sub
        Dim bolContieneCheck As Boolean = False
        For intCont As Integer = 0 To dgItemPedido.RowCount - 1
            If dgItemPedido.Rows(intCont).Cells("CHK").Value Then
                If dgItemPedido.Rows(intCont).Cells("PNQCNTIT2").Value = 0 Then
                    HelpClass.MsgBox("La cantidad debe de ser mayor a Cero")
                    Exit Sub
                End If
                bolContieneCheck = True
            End If
        Next
        If bolContieneCheck = False Then Exit Sub

        Dim obeDetPedOc As beOrdenCompra
        Dim obrOrdeDePedCopra As New brOrdenDeCompra
        For intCont As Integer = 0 To dgItemPedido.RowCount - 1
            If dgItemPedido.Rows(intCont).Cells("CHK").Value Then
                obeDetPedOc = New beOrdenCompra
                With obeDetPedOc
                    .PNCCLNT = _objOC.PNCCLNT
                    .PSNORCML = _objOC.PSNORCML
                    .PNNRITOC = _objOC.PNNRITOC
                    .PSNRFRPD = dgItemPedido.Rows(intCont).Cells("PSNRFRPD").Value
                    .PNQCNTIT = dgItemPedido.Rows(intCont).Cells("PNQCNTIT2").Value
                    .PSNTRMCR = HelpClass.NombreMaquina
                    .PSNTRMNL = HelpClass.NombreMaquina
                    .PSCUSCRT = objSeguridadBN.pUsuario
                    .PSCULUSA = objSeguridadBN.pUsuario
                    .PSSESTRG = "A"
                    If obrOrdeDePedCopra.InsertarDetalleOrdenDePedCompra(obeDetPedOc) = 0 Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If
                End With
            End If
        Next
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    'Private Sub dgProyecto_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemPedido.CellClick
    '    If e.ColumnIndex = 0 Then
    '        If Me.dgItemPedido.CurrentRow.Cells("CHK").Value Then
    '            Me.dgItemPedido.CurrentRow.Cells("CHK").Value = False
    '            dgItemPedido.EndEdit()
    '            Me.dgItemPedido.CurrentRow.Cells("PNQCNTIT2").ReadOnly = True
    '            Me.dgItemPedido.CurrentRow.Cells("PNQCNTIT2").Value = 0D

    '        Else
    '            Me.dgItemPedido.CurrentRow.Cells("CHK").Value = True
    '            dgItemPedido.EndEdit()
    '            Me.dgItemPedido.CurrentCell = Me.dgItemPedido.Item("PNQCNTIT2", dgItemPedido.CurrentCellAddress.Y)
    '            Me.dgItemPedido.CurrentCell.Selected = True
    '            Me.dgItemPedido.CurrentRow.Cells("PNQCNTIT2").ReadOnly = False
    '            Me.dgItemPedido.CurrentRow.Cells("PNQCNTIT2").Value = 0D

    '        End If
    '    End If
    'End Sub

    'Private Sub dgItemPedido_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgItemPedido.CellValidating
    '    If dgItemPedido.Columns(e.ColumnIndex).Name = "PNQCNTIT2" Then
    '        'SI EL SALDO ES MAYOR QUE LA CANTIDAD SOLICITADA NO PROCEDE 
    '        If IsNumeric(e.FormattedValue) Then
    '            If dgItemPedido.CurrentRow.Cells("PNQCNTIT").Value < e.FormattedValue Then
    '                MessageBox.Show("La Cantidad digitada es mayor que la Cantidad Solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                e.Cancel = True
    '            End If
    '        Else
    '            MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            e.Cancel = True
    '        End If
    '    End If
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmAgregarProyecto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnBuscar_Click(Nothing, Nothing)
    End Sub
End Class

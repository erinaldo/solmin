Imports Ransa.NEGO
Imports Ransa.TYPEDEF

Public Class frmListaCodigoImprimir


    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _PNNGUIRN As Decimal
    Public Property PNNGUIRN() As Decimal
        Get
            Return _PNNGUIRN
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRN = value
        End Set
    End Property

    Private Sub frmListaCodigoImprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obrRecepcion As New brDespacho
        Dim obeDespacho As New beDespacho
        With obeDespacho
            .PNCCLNT = _PNCCLNT
            .PNNGUIRN = _PNNGUIRN
        End With
        dgMercaderia.AutoGenerateColumns = False
        dgMercaderia.DataSource = obrRecepcion.flistaMercaderiImprimirCodigoBarra(obeDespacho)
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim Etiqueta As String = ""
        dgMercaderia.EndEdit()
        dgMercaderia.Refresh()
        For Each obeDespacho As beDespacho In dgMercaderia.DataSource
            If obeDespacho.CHK Then
                For intCon As Integer = 0 To obeDespacho.PNNCOPY - 1
                    Etiqueta = obeDespacho.PSCZNALM & "-" & obeDespacho.PSTRFRN2
                    ImpresionEtiquetasSDS.Mercaderia_6x4(obeDespacho.PSCMRCLR, obeDespacho.PSDEMERCA, objSeguridadBN.pUsuario, obeDespacho.PSNRFTPD & " - " & obeDespacho.PSNRFRPD, obeDespacho.PSCUNCN6, obeDespacho.PNQTRMC, _PNCCLNT, obeDespacho.PSNORCML, obeDespacho.PSCPSCN, Etiqueta, "", "", obeDespacho.PSCRTLTE)
                Next
            End If
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private iNroChkSelecc As Int32 = 0
    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If Me.dgMercaderia.RowCount > 0 Then
            Dim intCont As Int32 = 0
            iNroChkSelecc = 0
            While intCont < dgMercaderia.RowCount
                dgMercaderia.Rows(intCont).DataBoundItem.CHK = btnMarcarItems.Checked
                intCont += 1
            End While
        End If
        dgMercaderia.EndEdit()
        dgMercaderia.Refresh()
    End Sub

    Private Sub dgMercaderia_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgMercaderia.DataError

    End Sub

    Private Sub KryptonPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonPanel.Paint

    End Sub
End Class

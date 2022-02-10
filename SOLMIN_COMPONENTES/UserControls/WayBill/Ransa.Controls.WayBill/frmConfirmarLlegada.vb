Imports Ransa.NEGO
Imports Ransa.Utilitario
Imports Ransa.TYPEDEF


Public Class frmConfirmarLlegada


    Private _olBulto As List(Of Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
    Public Property olBultos() As List(Of Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
        Get
            Return _olBulto
        End Get
        Set(ByVal value As List(Of Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01))
            _olBulto = value
        End Set
    End Property

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        If Not IsDate(Me.dtpHoraConfirmacion.Text) Then
            HelpClass.MsgBox("Ingrese hora valida")
            Exit Sub
        End If

        For Each oBulto As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01 In _olBulto
            obeBulto = New beBulto
            With obeBulto
                .PNCCLNT = oBulto.pCCLNT_CodigoCliente
                .PSCCMPN = oBulto.pCCMPN_Compania
                .PSCDVSN = oBulto.pCDVSN_Division
                .PNCPLNDV = oBulto.pCPLNDV_Planta
                .PSCREFFW = oBulto.pCREFFW_CodigoBulto
                .PNNSEQIN = oBulto.pNSEQIN_NrSecuencia
                .PSFLGCNL = "X"
                .PSTOBSEN = Me.txtObservaciones.Text
                .PNFCNFCL = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaConfirmacion.Value)
                .PNHCNFCL = HelpClass.ConvertHoraNumeric(dtpHoraConfirmacion.Text)

            End With
            If obrBulto.fintConfirmarLlegada(obeBulto) = 0 Then
                MessageBox.Show("Error", "Comuniquese con departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class

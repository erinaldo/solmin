Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.Utilitario

Public Class frmInterfasePedSAP

#Region "Variables Privadas"
    Private intCCLNT As Decimal
#End Region

#Region "Propiedades Públicas"
    Public Property CCLNT() As Decimal
        Get
            Return intCCLNT
        End Get
        Set(ByVal value As Decimal)
            intCCLNT = value
        End Set
    End Property
#End Region

#Region " Procedimientos y Funciones "
    Private Sub ObtenerInformacionPedidoInterfazSAP()
        Dim strCRGVTA As String = String.Empty
        Dim obrDespacho As New brDespacho
        Dim dsInformacionPedido As New DataSet
        Dim strDCENSA As String = txtNroDocumentoES.Text
        GLOBAL_COMPANIA = "EZ"


        If Not IsNumeric(txtNroDocumentoES.Text) Then
            MessageBox.Show("El Número Documento SAP no es válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim objDatos As New beInferfazSapPedido

        objDatos.CCMPN = GLOBAL_COMPANIA
        objDatos.CCLNT = Me.intCCLNT
        objDatos.CRGVTA = obrDespacho.strObtenerCodigoRegionVenta(objDatos)
        objDatos.DCENSA = txtNroDocumentoES.Text.Trim
        Dim msgError As String = String.Empty
        dsInformacionPedido = obrDespacho.fdtOntenerInformacionPedidoInterfazSAP(objDatos, msgError)


        If String.IsNullOrEmpty(msgError) Then
            Using frm As New frmImportarPedidoSAP
                frm.CCLNT = Me.intCCLNT
                frm.oDs = dsInformacionPedido
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.Close()
                End If

            End Using
        Else
            MessageBox.Show(msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Eventos "
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        ObtenerInformacionPedidoInterfazSAP()
    End Sub

    Private Sub txtNroDocumentoES_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumentoES.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        Else
            If ChrW(Keys.Back) = e.KeyChar Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

#End Region

End Class
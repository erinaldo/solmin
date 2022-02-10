Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports ransa.TYPEDEF.Cliente
Imports Ransa.Utilitario
Imports Ransa.Controls.Proveedor
Public Class frmLProveedor

#Region "Atributos"

#End Region

#Region "Variables"

#End Region

#Region "Metodos y Funciones"

    Private Sub RefreshPlanta()
        'Dim oInfoProveedor As New Ransa.TYPEDEF.Proveedor.beProveedor
        Dim oInfoProveedor As New Ransa.Controls.Proveedor.beProveedor
        oInfoProveedor = UcProveedor_DgGeneral.infoProveedor
        If (oInfoProveedor Is Nothing) Then
            dgPlantaCliente.DataSource = Nothing
        Else
            Dim oBR As New brPlantaClienteProveedor
            Dim lis As List(Of bePlantaClienteProveedor) = oBR.Listar(oInfoProveedor.PNCPRVCL, ucpPlanta)
            dgPlantaCliente.DataSource = lis
        End If
       
    End Sub

#End Region

#Region "Eventos"

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            ActualizarConsulta()
        Catch : End Try

    End Sub

    Private Sub ActualizarConsulta()
        Try
            UcProveedor_DgGeneral.pNRUCPRSTR = txtRUC.Text.Trim
            UcProveedor_DgGeneral.pUsuario = objSeguridadBN.pUsuario
            UcProveedor_DgGeneral.pPSTPRVCL = txtDescripcion.Text.Trim
            UcProveedor_DgGeneral.ActualizarListaProveedor()
            RefreshPlanta()
        Catch : End Try
    End Sub
    Private Sub frmLProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgPlantaCliente.AutoGenerateColumns = False
    End Sub
    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Close()
    End Sub
    Private Sub tsbAgregarPlanta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarPlanta.Click
        Try
            If (UcProveedor_DgGeneral.Count <= 0) Then Exit Sub
            Dim frm As New frmEPlantaProveedor
            Dim oBE As New bePlantaClienteProveedor
            'Dim oInfoProveedor As New Ransa.TYPEDEF.Proveedor.beProveedor
            Dim oInfoProveedor As New Ransa.Controls.Proveedor.beProveedor
            oInfoProveedor = UcProveedor_DgGeneral.infoProveedor
            oBE.PNCPRVCL = oInfoProveedor.PNCPRVCL
            frm.Tag = oBE
            frm.IsNuevo = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshPlanta()
            End If
        Catch : End Try
    End Sub

    Private Sub tsbModificarPlanta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificarPlanta.Click
        Try
            If dgPlantaCliente.CurrentRow IsNot Nothing Then
                Dim frm As New frmEPlantaProveedor
                frm.IsNuevo = False

                frm.Tag = dgPlantaCliente.CurrentRow.DataBoundItem
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then                  
                    RefreshPlanta()
                End If
            End If
        Catch : End Try
    End Sub

    Private Sub tsbEliminarPlanta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarPlanta.Click
        Try
            If dgPlantaCliente.CurrentRow Is Nothing Then Exit Sub
            Dim retorno As Int32 = 0
            If MessageBox.Show("Está seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim obr As New brPlantaClienteProveedor()
                'Dim oInfoProveedor As New Ransa.TypeDef.Proveedor.beProveedor
                Dim oInfoProveedor As New Ransa.Controls.Proveedor.beProveedor
                oInfoProveedor = UcProveedor_DgGeneral.infoProveedor
                Dim obe As bePlantaClienteProveedor = dgPlantaCliente.CurrentRow.DataBoundItem
                retorno = obr.EliminarPlantaClienteTercero(obe)
                If (retorno = 1) Then
                    MessageBox.Show("El registro se eliminó satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    RefreshPlanta()
                End If
            End If
        Catch : End Try
    End Sub
#End Region

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC.KeyPress
        Try

            If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
                ActualizarConsulta()
            Else
                If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                    e.Handled = True
                End If
                Select Case AscW(e.KeyChar)
                    Case 8
                        e.Handled = False
                End Select
            End If
        Catch : End Try
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Try
            If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
                ActualizarConsulta()
            End If
        Catch : End Try
    End Sub

    Private Sub UcProveedor_DgCab1_eventChange() Handles UcProveedor_DgGeneral.eventChange
        RefreshPlanta()
    End Sub

End Class

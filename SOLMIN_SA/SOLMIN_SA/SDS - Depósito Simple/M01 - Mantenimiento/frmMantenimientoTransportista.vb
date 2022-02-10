Imports RANSA.TypeDef
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Public Class frmMantenimientoTransportista

#Region "Atributos"


#End Region

#Region "Variables"
    Public obeInfoTransportista As New beTransportista
    Public ActualizarDatos As Boolean = False
#End Region

#Region "Metodos y Funciones"

    Private Sub VisualizarDatosTransportista()
        InicializarControles()
        txtCodigo.Text = obeInfoTransportista.PNCTRSP
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(obeInfoTransportista.PNCCLNT, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        txtDesCompleto.Text = obeInfoTransportista.PSTCMPTR
        txtDesAbreviado.Text = obeInfoTransportista.PSTABRTR
        txtDireccion1.Text = obeInfoTransportista.PSTDRCTR
        txtDireccion2.Text = obeInfoTransportista.PSTCRGT2
        txtLE.Text = obeInfoTransportista.PSNLBELT
        txtRegMercantil.Text = obeInfoTransportista.PSNRGMRT
        txtNRegIndustrial.Text = obeInfoTransportista.PSNRGINT
        txtRuc.Text = obeInfoTransportista.PNNRUCT
        txtfono1.Text = obeInfoTransportista.PSNTLFTR
        txtfono2.Text = obeInfoTransportista.PSNTLFT2
        txtfax.Text = obeInfoTransportista.PSNFAXTR
        txtContacto1.Text = obeInfoTransportista.PSTCNTTR
        txtContacto2.Text = obeInfoTransportista.PSTCNTT2
        txtCargo.Text = obeInfoTransportista.PSTCRGTR
    End Sub

    Private Function ObtenerDatosTransportista() As beTransportista

        Dim obeTransportista As New beTransportista()
        obeTransportista.PNCTRSP = Val(txtCodigo.Text.Trim)
        obeTransportista.PSNTRMNL = objSeguridadBN.pstrPCName
        obeTransportista.PSCULUSA = objSeguridadBN.pUsuario
        obeTransportista.PNCCLNT = Val(txtCliente.pCodigo)
        obeTransportista.PSTCMPTR = txtDesCompleto.Text.Trim
        obeTransportista.PSTABRTR = txtDesAbreviado.Text.Trim
        obeTransportista.PSTDRCTR = txtDireccion1.Text.Trim
        obeTransportista.PSTCRGT2 = txtDireccion2.Text.Trim
        obeTransportista.PSNLBELT = txtLE.Text.Trim
        obeTransportista.PSNRGMRT = txtRegMercantil.Text.Trim
        obeTransportista.PSNRGINT = txtNRegIndustrial.Text.Trim
        obeTransportista.PNNRUCT = Val(txtRuc.Text.Trim)
        obeTransportista.PSNTLFTR = txtfono1.Text.Trim
        obeTransportista.PSNTLFT2 = txtfono2.Text.Trim
        obeTransportista.PSNFAXTR = txtfax.Text.Trim
        obeTransportista.PSTCNTTR = txtContacto1.Text.Trim
        obeTransportista.PSTCNTT2 = txtContacto2.Text.Trim
        obeTransportista.PSTCRGTR = txtCargo.Text.Trim
        obeTransportista.PSSESTTR = "A"
        Return obeTransportista

    End Function

    Private Sub InicializarControles()
        txtCodigo.Text = ""
        txtCliente.pClear()
        txtDesCompleto.Text = ""
        txtDesAbreviado.Text = ""
        txtDireccion1.Text = ""
        txtDireccion2.Text = ""
        txtLE.Text = ""
        txtRegMercantil.Text = ""
        txtNRegIndustrial.Text = ""
        txtRuc.Text = ""
        txtfono1.Text = ""
        txtfono2.Text = ""
        txtfax.Text = ""
        txtContacto1.Text = ""
        txtContacto2.Text = ""
        txtCargo.Text = ""
        txtCodigo.Enabled = False
    End Sub

    Private Function Validar() As String
        Dim strMensaje As String = ""
        If (txtDesCompleto.Text.Trim = "") Then
            strMensaje = "* Debe de ingresar la Descripción de Transportista"
        End If
        Return strMensaje
    End Function

#End Region

#Region "Eventos"

    Private Sub frmMantenimientoTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objAppConfig As cAppConfig = New cAppConfig
            Dim intTemp As Int64 = 0
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            InicializarControles()
            If (ActualizarDatos = True) Then
                VisualizarDatosTransportista()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim resultado As Int32 = 0
            Dim obrTransportista As New brTransportista
            Dim obeTransportista As New beTransportista
            Dim strmensajeValidacion As String = Validar()
            If (strmensajeValidacion <> "") Then
                MessageBox.Show(strmensajeValidacion, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If (ActualizarDatos = True) Then
                resultado = obrTransportista.ActualizarTransportista(ObtenerDatosTransportista())
                If (resultado = 1) Then
                    MessageBox.Show("Se ha actualizado satisfactoriamente ", "Actualización Proveedor")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Actualización Proveedor")
                End If
            Else
                resultado = obrTransportista.InsertarTransportista(ObtenerDatosTransportista())
                If (resultado = 1) Then
                    MessageBox.Show("Se ha grabado satisfactoriamente  ", "Registro Proveedor")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Registro Proveedor")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13, 32
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtLE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLE.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13, 32
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

#End Region

End Class

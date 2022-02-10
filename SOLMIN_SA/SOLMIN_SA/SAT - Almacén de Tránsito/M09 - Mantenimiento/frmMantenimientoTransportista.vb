Imports RANSA.TypeDef
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente

Public Class frmMantTransportista

#Region "Variables"
    Public obeInfoTransportista As New beTransportista
    Public ActualizarDatos As Boolean = False
#End Region

#Region "Metodos y Funciones"

    Private Sub VisualizarDatosTransportista()
        InicializarControles()
        txtCodigo.Text = obeInfoTransportista.PNCTRSPT
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(obeInfoTransportista.PNCCLNT, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        txtRuc.Text = obeInfoTransportista.PSNRUCTR.Trim
        txtDesCompleto.Text = obeInfoTransportista.PSTCMTRT.Trim
        txtDesAbreviado.Text = obeInfoTransportista.PSTABTRT.Trim
        txtrepresentante.Text = obeInfoTransportista.PSTRPRTR.Trim
        txtLERepresentante.Text = obeInfoTransportista.PSNLBELR.Trim
        txtNumEmpadronamiento.Text = obeInfoTransportista.PSNEMMTC.Trim
        txtDireccion.Text = obeInfoTransportista.PSTDRCTR.Trim
    End Sub

    Private Function ObtenerDatosTransportista() As beTransportista

        Dim obeTransportista As New beTransportista()

        obeTransportista.PNCTRSPT = Val(txtCodigo.Text.Trim)
        obeTransportista.PSNRUCTR = txtRuc.Text.Trim
        obeTransportista.PSTCMTRT = txtDesCompleto.Text.Trim
        obeTransportista.PSTABTRT = txtDesAbreviado.Text.Trim
        obeTransportista.PSTRPRTR = txtrepresentante.Text.Trim
        obeTransportista.PSNLBELR = txtLERepresentante.Text.Trim
        obeTransportista.PSNEMMTC = txtNumEmpadronamiento.Text.Trim
        obeTransportista.PSTDRCTR = txtDireccion.Text.Trim
        obeTransportista.PSNTRMNL = objSeguridadBN.pstrPCName
        obeTransportista.PSCULUSA = objSeguridadBN.pUsuario
        obeTransportista.PSCUSCRT = objSeguridadBN.pUsuario
        obeTransportista.PSNTRMCR = objSeguridadBN.pstrPCName
        obeTransportista.PSTLFTRP = ""
        Return obeTransportista
    End Function

    Private Sub InicializarControles()
        txtCodigo.Text = ""
        txtDesCompleto.Text = ""
        txtDesAbreviado.Text = ""
        txtrepresentante.Text = ""
        txtLERepresentante.Text = ""
        txtrepresentante.Text = ""
        txtNumEmpadronamiento.Text = ""
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

    Private Sub frmMantTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
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
                resultado = obrTransportista.ActualizarTransportistaAT(ObtenerDatosTransportista())
                If (resultado = 1) Then
                    MessageBox.Show("Se ha actualizado satisfactoriamente ", "Actualización Transportista")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Actualización Transportista")
                End If
            Else
                resultado = obrTransportista.InsertarTransportistaAt(ObtenerDatosTransportista())
                If (resultado = 1) Then
                    MessageBox.Show("Se ha grabado satisfactoriamente  ", "Registro Transportista")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Registro Transportista")
                End If
            End If
        Catch ex As Exception
        End Try




    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtLERepresentante_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLERepresentante.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

#End Region

End Class

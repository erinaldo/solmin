Imports Ransa.TypeDef.Cliente
Imports RANSA.TypeDef
Imports RANSA.NEGO
Imports Ransa.Utilitario

Public Class frmMantenimientoUbicacionesXCliente

    Public PNCCLNT As Decimal
    Public PSCCMPN As String
    Public Cliente As String
    Public Compania As String
    Public Ubicacion As String
    Public Ubicacion_Anterior As String
    Public Grabar As Boolean
    Public ActualizarDatos As Boolean = False
    Public Estado As String

    Private Function fnvalidaGuardar() As Boolean
        Dim strMensaje As String = String.Empty
        If UcCliente_TxtF011.pCodigo = 0 Then
            strMensaje = "-Seleccione un cliente" & System.Environment.NewLine
        End If
        If txtUbicacionReferencial.Text.ToString.Trim.Length = 0 Then
            strMensaje = strMensaje & "- Ingrese una ubicación referencial " & System.Environment.NewLine
        End If

        If strMensaje.Length > 0 Then
            HelpClass.MsgBox(strMensaje, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim objBLL As New brUbicacionesXCliente
        Dim respuesta As Boolean = False
        Dim Exito As Int32

        If fnvalidaGuardar() = False Then
            Exit Sub
        End If

        If ActualizarDatos Then
            respuesta = objBLL.Update_UbicacionesXCliente(UcCliente_TxtF011.pCodigo, txtUbicacionReferencial.Text.ToString.Trim, Ubicacion_Anterior, objSeguridadBN.pUsuario, Estado)
            If respuesta = True Then
                MessageBox.Show("Se actualizo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
            Exito = objBLL.Insert_UbicacionesXCliente(UcCliente_TxtF011.pCodigo, txtUbicacionReferencial.Text.ToString.Trim, objSeguridadBN.pUsuario)
            If Exito = 1 Then
                MessageBox.Show("Se ingreso correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
            If Exito = 2 Then
                'If MessageBox.Show("La ubicación se encuentra deshabilitada, ¿Desea habilitarla?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                respuesta = objBLL.Update_UbicacionesXCliente(UcCliente_TxtF011.pCodigo, txtUbicacionReferencial.Text.ToString.Trim, txtUbicacionReferencial.Text.ToString.Trim, objSeguridadBN.pUsuario, "A")
                If respuesta = True Then
                    MessageBox.Show("Se ingreso correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
                'End If
        End If
        If Exito = 0 Then
            MessageBox.Show("La Ubicación se encuentra creada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        End If
    End Sub

    Private Sub frmMantenimientoUbicacionesXCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(PNCCLNT, objSeguridadBN.pUsuario)
        UcCliente_TxtF011.pCargar(ClientePK)

        If ActualizarDatos Then
            txtUbicacionReferencial.Text = Ubicacion
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
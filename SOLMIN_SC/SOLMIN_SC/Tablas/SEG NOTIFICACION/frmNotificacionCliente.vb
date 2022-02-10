Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Imports System.Text.RegularExpressions

Public Class frmNotificacionCliente

    Public objNoficacion As New beSegNotificacion
    Public Modificar As New Boolean
    Private Sub frmNotificacionCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Modificar Then
            CargarDatos(objNoficacion)
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If txtCorreo.Text.Trim = "" Then
                MessageBox.Show("Ingrese Correo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCorreo.Focus()
                Exit Sub
            End If
 
                Dim brSegNotificacion As New Negocio.clsSegNotificacion
                Dim dt As New DataTable
                Dim beSegNotificacion As beSegNotificacion
                beSegNotificacion = New beSegNotificacion
                With beSegNotificacion
                    .PNCCLNT = objNoficacion.PNCCLNT
                    .PSNLTECL = objNoficacion.PSNLTECL
                    .PSEMAILTO = txtCorreo.Text.Trim
                    .PSTNMYAP = txtNombres.Text.Trim
                    .PSTIPPROC = txtDivisionNotif.Text.Trim
                    .PSCULUSA = HelpUtil.UserName
                    .PNNCRRIT = objNoficacion.PNNCRRIT
                End With
                If Modificar Then
                    brSegNotificacion.ActualizarEmailDestinatarioXTipo(beSegNotificacion)
                Else
                    brSegNotificacion.RregistrarEmailDestinatarioXTipo(beSegNotificacion)
                End If
                DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
 
    Private Sub txtCorreo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorreo.TextChanged
        'If EmailAddressCheck(txtCorreo.Text) = True Then
        '    MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
        '    txtCorreo.Text = ""

        'End If
    End Sub

#Region "Metodos y Funciones"

    Private Sub CargarDatos(ByVal objSegNoficacion As beSegNotificacion)
        txtCorreo.Text = objSegNoficacion.PSEMAILTO
        txtNombres.Text = objSegNoficacion.PSTNMYAP
        txtDivisionNotif.Text = objSegNoficacion.PSTIPPROC
        txtCorreo.Focus()
    End Sub

    'Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
    '    'Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
    '    Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.^[a-zA-Z][\w\.-]*[a-zA-Z0-9]"
    '    Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
    '    If emailAddressMatch.Success Then
    '        EmailAddressCheck = True
    '    Else
    '        EmailAddressCheck = False
    '    End If
    'End Function

#End Region

End Class

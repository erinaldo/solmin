Public Class frmLogin
    Private oAcceso As New SOLMIN_SC.Negocio.clsAcceso
    Private oUsuario As New SOLMIN_SC.Negocio.clsUsuario

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        oAcceso.Destruir()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If oAcceso.Verifica_Archivo Then
            'Dim frmPrin As New frmPrincipal(oUsuario)
            Dim frmPrin As New MainForm()
            'Cargar_Tablas_Globales()
            frmPrin.ShowDialog()
            Me.Close()
        End If
        Me.txtUsuario.Text = My.User.Name.Split("\")(1).ToUpper
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Autenticar_Usuario() Then
            Me.Hide()
            'Dim frmPrin As New frmPrincipal(oUsuario)
            Dim frmPrin As New MainForm()
            'Cargar_Tablas_Globales()
            frmPrin.ShowDialog()
            Me.Close()
        Else
            HelpUtil.MsgBox("Usuario no autentificado en AS-400")
            Me.txtPassword.Text = ""
            Me.txtUsuario.Focus()
        End If
    End Sub

    Private Function Autenticar_Usuario() As Boolean
        Dim validar As String = ""

        If String.IsNullOrEmpty(Me.txtPassword.Text) = True Then
            validar += "Debe de ingresar la contraseña" & Chr(13)
        End If
        If String.IsNullOrEmpty(Me.txtUsuario.Text) = True Then
            validar += "Debe de ingresar el nombre de usuario"
        End If

        If String.IsNullOrEmpty(validar) = False Then
            HelpUtil.MsgBox(validar)
            Exit Function
        End If

        Return oAcceso.Valida_Acceso(txtUsuario.Text, txtPassword.Text)

    End Function


End Class

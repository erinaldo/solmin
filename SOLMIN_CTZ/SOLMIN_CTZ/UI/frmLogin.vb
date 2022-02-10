Public Class frmLogin
    Private oAcceso As New SOLMIN_CTZ.NEGOCIO.clsAcceso
    Private oUsuario As New SOLMIN_CTZ.NEGOCIO.clsUsuario

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        oAcceso.Destruir()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If oAcceso.Verifica_Archivo Then
            Dim proceso_precarga As New Threading.Thread(AddressOf MainModule.Preloader)
            Dim frmPrin As New MainForm()

            proceso_precarga.Start()
            Cargar_Tablas_Globales()
            proceso_precarga.Abort()

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
            Dim proceso_precarga As New Threading.Thread(AddressOf MainModule.Preloader)
            Dim frmPrin As New MainForm()

            proceso_precarga.Start()
            Cargar_Tablas_Globales()
            proceso_precarga.Abort()
            frmPrin.ShowDialog()
            Me.Close()
        Else
            HelpClass.MsgBox("Usuario no autentificado en AS-400")
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
            HelpClass.MsgBox(validar)
            Exit Function
        End If

        Return oAcceso.Valida_Acceso(txtUsuario.Text, txtPassword.Text)

    End Function

    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub
End Class

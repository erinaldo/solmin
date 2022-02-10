Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO

Public Class frmLogin

    'Verifica que el usuario tenga permiso para conectarse al AS-400
    Dim ConnStr As String
    Dim Validado As Boolean = False
    Private objOpciones As New frmOpciones
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Autenticar_Usuario()
    End Sub

    Private Sub TextBoxEnter(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown, txtUsuario.KeyDown

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Autenticar_Usuario()
        End If

    End Sub

    Private Sub Autenticar_Usuario()

        Dim validar As String = ""
        Dim objAuthenticated As New Autenticacion_BLL

    If String.IsNullOrEmpty(Me.txtPassword.Text) = True Then
      validar += "Debe de ingresar la contraseña" & Chr(13)
    End If
        If String.IsNullOrEmpty(Me.txtUsuario.Text) = True Then
            validar += "Debe de ingresar el nombre de usuario"
        End If

        If String.IsNullOrEmpty(validar) = False Then
            HelpClass.MsgBox(validar)
            Exit Sub
        End If

        Try

            'reemplazando en la cadena, el usuario y password
            ConnStr = ConnStr.Replace("$USER", Me.txtUsuario.Text)
            ConnStr = ConnStr.Replace("$PASS", Me.txtPassword.Text)

            If objAuthenticated.isAuthenticated(ConnStr) Then
                objAuthenticated.WriteConnectionFile(ConnStr)
                Validado = True
                MainModule.USUARIO = Me.txtUsuario.Text
                Me.Close()
            Else
                Throw New Exception
            End If

        Catch ex As Exception

            HelpClass.MsgBox("Usuario no autentificado en AS-400")
            Me.txtUsuario.Text = ""
            Me.txtPassword.Text = ""
            Me.txtUsuario.Focus()
            Validado = False
            Cargar_Cadena_Conexion()

        End Try



    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtUsuario.Text = Mid(My.User.Name.ToString(), My.User.Name.ToString().LastIndexOf("\") + 2, Len(My.User.Name.ToString()) - My.User.Name.ToString().LastIndexOf("\") + 1)
        Me.txtPassword.Focus()
        Cargar_Cadena_Conexion()
        objOpciones.TipoServidor = frmOpciones.SERVIDOR.DESARROLLO
    End Sub

    Public Sub Cargar_Cadena_Conexion()
        'Verificando el tipo de origen de datos,escoge el servidor
        ' a controlar la autentificación
        ConnStr = HelpClass.getSetting("DataBase")
    End Sub

    Private Sub btnOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpciones.Click
        objOpciones.ShowDialog(Me)
        Me.ConnStr = objOpciones.getConn()
    End Sub

    Public Function ProcesoValidacion() As Boolean
        Return Validado
    End Function
  
End Class

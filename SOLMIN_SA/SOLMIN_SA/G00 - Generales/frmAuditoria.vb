Imports RANSA.TypeDef
Public Class frmAuditoria
    Public obeUsuario As beUsuario
#Region "Eventos"
    Private Sub frmAuditoria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtUsuarioCreador.Text = obeUsuario.USUARIO_CREACION
        Me.txtFechaCreacion.Text = obeUsuario.FECHA_CREACION
        Me.txtHoraCreacion.Text = obeUsuario.HORA_CREACION 
        Me.txtTerminalUsado.Text = obeUsuario.TERMINAL_CREACION
        Me.txtUsuarioActualizado.Text = obeUsuario.USUARIO_ACTUALIZACION
        Me.txtFechaActualizado.Text = obeUsuario.FECHA_ACTUALIZACION
        Me.txtHoraActualizado.Text = obeUsuario.HORA_ACTUALIZACION
        Me.txtTerminalUsadoActualizar.Text = obeUsuario.TERMINAL_ACTUALIZACION
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click, btnCerrar.Click
        Me.Close()
    End Sub
#End Region
End Class

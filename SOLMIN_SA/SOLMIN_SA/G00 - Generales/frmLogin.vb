Imports RANSA.NEGO.slnSOLMIN
Imports System.Data

Public Class frmLogin
#Region " Atributo "
    Private dstListaServidores As DataSet = Nothing
    Private booStatusGeneral As Boolean = False
    Private objParamSeguridad As New clsParametrosSeguridad
    Private blnResultado As Boolean = True
#End Region
#Region " Propiedades "
    Public ReadOnly Property pParametroSeguridad() As clsParametrosSeguridad
        Get
            Return objParamSeguridad
        End Get
    End Property
#End Region
#Region " Procedimientos y Funciones "
    Private Sub pCargarServidores()
        cbxServidor.DataSource = dstListaServidores.Tables("Servidores")
        cbxServidor.DisplayMember = "servidor"
    End Sub

    Private Sub pCagarTipoSistemas()
        cbxTipoSistema.DataSource = dstListaServidores.Tables("TipoSistema")
        cbxTipoSistema.DisplayMember = "Detalle"
        cbxTipoSistema.ValueMember = "Codigo"
    End Sub

    Private Sub pCargarBaseDatos(ByVal strServidor As String)
        Dim rwListaBaseDatos As DataRow()
        Dim rwBaseDatoTemp As DataRow
        cbxBaseDatos.Items.Clear()
        cbxBaseDatos.Text = ""
        rwListaBaseDatos = dstListaServidores.Tables("BasesDatos").Select("Servidor='" & strServidor & "'")
        For Each rwBaseDatoTemp In rwListaBaseDatos
            cbxBaseDatos.Items.Add(rwBaseDatoTemp("BaseDatos").ToString)
        Next
    End Sub

    Private Sub pCargarInfConexion()
        Dim rwListaBaseDatos As DataRow()
        Dim rwBaseDatoTemp As DataRow
        cbxServidor.Text = ""
        cbxBaseDatos.Text = ""
        rwListaBaseDatos = dstListaServidores.Tables("Conexion").Select("Default='X'")
        For Each rwBaseDatoTemp In rwListaBaseDatos
            cbxServidor.Text = rwBaseDatoTemp("servidor").ToString
            ' Cargo las Bases de Datos Disponibles para el servidor default
            Call pCargarBaseDatos(cbxServidor.Text)
            cbxBaseDatos.Text = rwBaseDatoTemp("BaseDatos").ToString
        Next
    End Sub

    Private Function fblnObtenerEsquema(ByVal strServidor As String, ByVal strBaseDatos As String, ByRef strEsquema As String, _
                                        ByRef strDetalleBaseDatos As String, ByRef strIPConexion As String) As Boolean

        Dim rwListaBaseDatos As DataRow()
        Dim rwBaseDatoTemp As DataRow
        Dim blnReultado As Boolean = False
        rwListaBaseDatos = dstListaServidores.Tables("Conexion").Select("Servidor='" & strServidor & "' AND BaseDatos= '" & strBaseDatos & "'")
        For Each rwBaseDatoTemp In rwListaBaseDatos
            blnReultado = True
            strEsquema = rwBaseDatoTemp("Esquema").ToString
            strDetalleBaseDatos = rwBaseDatoTemp("DetalleBDatos").ToString
            strIPConexion = rwBaseDatoTemp("IPConexion").ToString
        Next
        Return blnReultado
    End Function

    Private Sub pMostrarOpcionesAvanzadas()
        If booStatusGeneral Then
            grpParametrosGenerales.Enabled = True
            Me.Height = 305
            Me.grpParametrosGenerales.Visible = True
            Me.btnAceptar.Top = 243
            Me.btnCancelar.Top = 243
            Me.btnOpcionesAvanzadas.Top = 243
            cbxServidor.Focus()
        Else
            grpParametrosGenerales.Enabled = False
            Me.Height = 230
            Me.grpParametrosGenerales.Visible = False
            Me.btnAceptar.Top = 163
            Me.btnCancelar.Top = 163
            Me.btnOpcionesAvanzadas.Top = 163
        End If
        booStatusGeneral = Not booStatusGeneral
    End Sub

    Private Sub pOpenDataServidor()
        Try
            dstListaServidores = New DataSet()
            dstListaServidores.ReadXml(Application.StartupPath & "\Servidores.xml")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function fblnValidar() As Boolean
        blnResultado = True
        Dim strMensajeError As String = ""
        If Me.txtUsuario.Text = "" Then strMensajeError &= "Falta ingresar USUARIO." & vbNewLine
        If Me.txtPassword.Text = "" Then strMensajeError &= "Falta ingresar PASSWORD." & vbNewLine
        If Me.cbxTipoSistema.Text = "" Then strMensajeError &= "No ha seleccionado el SISTEMA." & vbNewLine
        If Me.cbxServidor.Text = "" Then strMensajeError &= "No ha seleccionado el SERVIDOR." & vbNewLine
        If Me.cbxBaseDatos.Text = "" Then strMensajeError &= "No ha seleccionado la BASE DE DATOS." & vbNewLine

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return blnResultado
    End Function
#End Region
#Region " Metodos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If fblnValidar() Then
            With objParamSeguridad
                .pstrServidor = Me.cbxServidor.Text
                .pstrBaseDatos = Me.cbxBaseDatos.Text
                If Not fblnObtenerEsquema(.pstrServidor, .pstrBaseDatos, .pstrEsquema, .pstrDetalleBaseDatos, .pstrIPConexion) Then
                    MessageBox.Show("Error hallando el esquema del Sistema." & vbNewLine & _
                                    "Comunicarse con el Administrador del Sistema", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                .pstrUsuario = Me.txtUsuario.Text
                .pstrPassword = Me.txtPassword.Text
                .pstrAplicativo = "SA"
                .pstrTipoSistema = cbxTipoSistema.SelectedValue
                .pstrDetalleTipoSistema = cbxTipoSistema.Text
                Select Case .pstrTipoSistema
                    Case "04"
                        .pstrTipoAlmacen = "7"
                    Case "03"
                        .pstrTipoAlmacen = "1"
                    Case "02"
                        .pstrTipoAlmacen = "5"
                    Case "04"
                        .pstrTipoAlmacen = "1"
                End Select
            End With
            'OleAnimar.StopAnimation()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
        Me.Close()
    End Sub

    Private Sub btnOpcionesAvanzadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcionesAvanzadas.Click
        Call pMostrarOpcionesAvanzadas()
    End Sub

    Private Sub cbxServidor_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxServidor.SelectionChangeCommitted
        Call pCargarBaseDatos(cbxServidor.Text)
    End Sub

    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objAppConfig As New cAppConfig
        ' Mostrando las opciones básicas
        Call pMostrarOpcionesAvanzadas()
        ' Cargamos la información del Servidor
        Call pOpenDataServidor()
        ' Cargamos los Tipos de Sistemas
        Call pCagarTipoSistemas()
        ' Cargo los controles con la información a seleccionar
        Call pCargarServidores()
        ' Cargo la información por defecto
        Call pCargarInfConexion()
        Try
            '  OleAnimar.Animate()
            txtUsuario.Text = objAppConfig.GetValue("UsuarioLogin", GetType(System.String)).ToString.ToUpper
        Catch ex As Exception
            MessageBox.Show("Error Cargar Login...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objAppConfig = Nothing
        End Try
    End Sub
#End Region
End Class
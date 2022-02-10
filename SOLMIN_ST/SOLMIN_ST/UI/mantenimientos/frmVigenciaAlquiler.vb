

Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimiento
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Moneda
Imports Ransa.Utilitario


Public Class frmVigenciaAlquiler
    Private objAlquilerUnidadBLL As New AlquilerUnidad_BLL

    Public _txtNroAlquiler2 As String = ""
    Public _tipo As String = ""
    Public _placa As String = ""
    Public _obs As String = ""
    Public _fechaInicio As Date
    Public _fechaFin As Date
    Public _estado As String

    Sub frmVigenciaAlquiler(ByVal NroAlquiler As String, ByVal __tipo As String, ByVal __placa As String, ByVal __obs As String, ByVal __estado As String, ByVal __fechaInicio As Date, ByVal __fechaFin As Date)
        _txtNroAlquiler2 = NroAlquiler
        _tipo = __tipo
        _placa = __placa
        _obs = __obs
        _estado = __estado
        _fechaInicio = __fechaInicio
        _fechaFin = __fechaFin
    End Sub

    Private Sub frmVigenciaAlquiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNroAlquiler1.Text = _txtNroAlquiler2
        txtTipo.Text = _tipo
        txtPlaca.Text = _placa
        txtObs.Text = _obs
        dtpFechaInicio.Value = _fechaInicio
        dtpFechaFin.Value = _fechaFin
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim strMensajeError As String = ""
            Dim FechaIni As Decimal = dtpFechaInicio.Value.ToString("yyyyMMdd")
            Dim FechaFin As Decimal = dtpFechaFin.Value.ToString("yyyyMMdd")
            If FechaFin < FechaIni Then strMensajeError &= "* Fecha vigencia de inicio debe ser menor a la fecha vigencia fin. " & vbNewLine
            If strMensajeError.Length > 0 Then
                MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim objAlquilerUnidad As New AlquilerUnidad
            With objAlquilerUnidad
                .TOBS = txtObs.Text.Trim
                .NRALQT = CDec(txtNroAlquiler1.Text.Trim)
                .FVALIN = HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value)
                .FVALFI = HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value)
                .CULUSA = MainModule.USUARIO
                .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            End With
            objAlquilerUnidadBLL.Modificar_Alquiler_Unidad_Vigencia(objAlquilerUnidad)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class

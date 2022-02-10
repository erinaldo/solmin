Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimiento
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.TypeDef.Moneda
Imports Ransa.Utilitario
Public Class frmAprobacionAlquiler

    Dim objAlquilerUnidad As New AlquilerUnidad
    Dim objAlquilerUnidad_BLL As New OperacionesXAlquiler_BLL
    Dim EntidadAlquilerUnidad As New OperacionesXAlquiler
    Public Monto As String
    Public Moneda As String
    Public FechaAsignacion As Date
    Public Unidad As String
    Public FechaVigenciaInicio As Date
    Public FechaVigenciaFin As Date
    Public CCMPN As String
    Public CDVSN As String



    Private Sub btnAceptarAprobacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarAprobacion.Click
        Try

            If gwdUnidAlquiler.Rows.Count > 0 Then
                If MessageBox.Show("El recurso será habilitado para Flota Propia." & Chr(13) & "Está seguro de aprobar el alquiler ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            Dim obeOperacionesXAlquiler As New OperacionesXAlquiler
            With obeOperacionesXAlquiler
                .NRALQT = txtAlquiler.Text
                .CCMPN = CCMPN
                .CDVSN = CDVSN
                .CULUSA = txtUsuario.Text
                .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                .TOBRES = txtObservacion.Text
            End With
            objAlquilerUnidad_BLL.Registrar_Aprobacion_Alquiler(obeOperacionesXAlquiler)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Else
            'MessageBox.Show("Ingrese Observación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelarAprobacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarAprobacion.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub



    Public Sub CargarAlquilerAprobacion(ByVal AlquilerUnidad As AlquilerUnidad)
        txtAlquiler.Text = AlquilerUnidad.NRALQT
        txtProveedor.Text = AlquilerUnidad.TCMTRT
        txtMonto.Text = Monto
        txtMoneda.Text = Moneda
        txtUnidad.Text = Unidad
        dtpFechaAsignacion.Value = FechaAsignacion
        dtpFechaVigenciaInicio.Value = FechaVigenciaInicio
        dtpFechaVigenciaFin.Value = FechaVigenciaFin
        txtUsuario.Text = AlquilerUnidad.CULUSA
        CCMPN = AlquilerUnidad.CCMPN
        CDVSN = AlquilerUnidad.CDVSN
        dtpFechaAprob.Value = Date.Now
        _TIPO_RECURSO = AlquilerUnidad.STPRCS
        _PLACA = AlquilerUnidad.NPLRCS
    End Sub

    Private _TIPO_RECURSO As String = ""
    Private _PLACA As String = ""


    Private Sub frmAprobacionAlquiler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            gwdUnidAlquiler.AutoGenerateColumns = False
            Dim oSolicitudTransporte As New Solicitud_Transporte_BLL
            Dim dtPlacaAsignado As New DataTable
            dtPlacaAsignado = oSolicitudTransporte.Lista_Placa_Asignacion(CCMPN, CDVSN, _TIPO_RECURSO, _PLACA)
            gwdUnidAlquiler.DataSource = dtPlacaAsignado

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

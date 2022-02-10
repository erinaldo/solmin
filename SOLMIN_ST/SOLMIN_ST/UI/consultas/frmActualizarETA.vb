
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmActualizarETA
    Public operacion As Decimal = 0
    Public codigo_transporte As Decimal = 0
    Public guia_transporte As Decimal
    Public fecha_salida_real As String = ""
    Public fecha_ETA As String = ""
    Public fecha_llegada As String = ""
    Public compania As String = ""
    Private Sub frmActualizarETA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            txtoperacion.Text = operacion
            txtgt.Text = guia_transporte
            txtfechasalida.Text = fecha_salida_real

            If fecha_ETA <> "" Then
                chkFechaLlegada.Checked = True
                dtpeta.Value = fecha_ETA
            Else
                dtpeta.Value = Date.Today
                chkFechaLlegada.Checked = False
            End If

            txtfechallegada.Text = fecha_llegada
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
            Dim objParameter As New Hashtable
            objParameter.Add("CTRMNC", codigo_transporte)
            objParameter.Add("NGUIRM", guia_transporte)
            If chkFechaLlegada.Checked = True Then
                fecha_ETA = dtpeta.Value.ToShortDateString
                objParameter.Add("FECETA", HelpClass.CFecha_a_Numero8Digitos(dtpeta.Value.ToShortDateString))
            Else
                fecha_ETA = ""
                objParameter.Add("FECETA", 0)
            End If
            objParameter.Add("CCMPN", compania)
            objParameter.Add("CULUSA", MainModule.USUARIO)
            objParameter.Add("TERMINAL", Ransa.Utilitario.HelpClass.NombreMaquina)
            objSolicitudTransporte.Actualizar_Fecha_ETA(objParameter)
            DialogResult = Windows.Forms.DialogResult.OK
            'Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
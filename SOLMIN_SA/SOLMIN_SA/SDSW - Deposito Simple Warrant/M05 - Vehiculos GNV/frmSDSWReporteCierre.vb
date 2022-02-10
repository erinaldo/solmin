Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO.slnSOLMIN_SDS.ReporteConsistenciaW.Reportes.Generador
Imports RANSA.NEGO.slnSOLMIN_SDS.ReporteConsistenciaW
Public Class frmSDSWReporteCierre
    Private rptTemp As ReportDocument
    Private strMensajeError As String
#Region "Tipos"
    Enum eTipoValidacion
        PROCESAR
        '  ANULAR     
    End Enum
#End Region
    Private Function fblValidaInformacion(ByVal evalidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If evalidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.Text = "" Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado

    End Function
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        'If fblValidaInformacion(eTipoValidacion.PROCESAR) Then
        'If dgvGuia.RowCount = 0 Then
        'MessageBox.Show("No hay ningun dato en Guia", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        If fblValidaInformacion(eTipoValidacion.PROCESAR) Then
            Call pInicioVistaPrevia()
        End If

        ' End If
        ' End If
        'Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub pInicioVistaPrevia()
        pcxEspera.Visible = True
        VisorReportesCrystal.Visible = False
        bgwGifAnimado.RunWorkerAsync()
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pVisualizar()
    End Sub
    Private Sub pVisualizar()
        Dim Compania As String

        If Compania_Usuario = "AM" Then
            Compania = "Almacenera del Perú"
        Else
            Compania = "Compañía Almacenera S.A"
        End If

        Dim objReporte As ReporteConsistencia = New ReporteConsistencia(objSeguridadBN.pUsuario)
        Dim objParametros As clsFiltroReporteConsistencia = New clsFiltroReporteConsistencia
        With objParametros
            Int64.TryParse(txtCliente.Tag, .pintCodigoCliente_CCLNT)
            Date.TryParse(dtpfecha.Text, .pdteFechaInicio)
        End With
        rptTemp = objReporte.frptReporteConsistencia(objParametros, strMensajeError)

    End Sub
    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        VisorReportesCrystal.ReportSource = rptTemp
        VisorReportesCrystal.Visible = True
    End Sub

    Private Sub bsaClienteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
            lblcodcliente.Text = txtCliente.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        txtCliente.Tag = ""
    End Sub

    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If txtCliente.Text = "" Then
            txtCliente.Tag = ""
        Else
            If txtCliente.Text <> "" And "" & txtCliente.Tag = "" Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
                lblcodcliente.Text = txtCliente.Tag
                Cursor = System.Windows.Forms.Cursors.Arrow
                If txtCliente.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
End Class


Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW
Public Class frmConsultaAmcor
    Dim MyNumber(2) As String
    Dim Fecha, Fecha1 As Date

    Public Sub LlenarCabacera()

        If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "I" Then
            'Fecha = Me.dtpFechaIngreso.Text
            Date.TryParse(Me.dtpFechaIngreso.Text, Fecha)
            ' Fecha1 = 0
            Me.dgvCabecera.DataSource = mfblnProceso_SDSWCabeceraAmcor(Fecha, MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)))
            '  dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor(txtGuia.Text, "")
        Else
            Me.dgvCabecera.DataSource = mfblnProceso_SDSWCabeceraAmcor(Fecha, MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)))
            '   dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor("", txtGuia.Text)
        End If
    End Sub
    Public Sub LlenarItem()
        Me.dgvDetalle.DataSource = mfblnProceso_SDSWDetalleAmcorConsulta(Me.dgvCabecera.CurrentRow.Cells("NOPRCN").Value)
    End Sub
    Public Sub LlenarItemDetalle()
        Me.dgvDetalleItem.DataSource = mfblnProceso_SDSWDetalleItemAmcor(Me.dgvDetalle.CurrentRow.Cells("NORDS1").Value)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        LlenarCabacera()
    End Sub

    Private Sub frmConsultaAmcor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbxTipo.Items.Add("Ingreso") : MyNumber(0) = "I"
        Me.cbxTipo.Items.Add("Salida") : MyNumber(1) = "S"
    End Sub

    Private Sub dgvCabecera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCabecera.Click
        If dgvCabecera.RowCount > 0 Then
            LlenarItem()
        End If

    End Sub

    Private Sub dgvDetalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDetalle.Click
        If dgvDetalle.RowCount > 0 Then
            LlenarItemDetalle()
        End If
    End Sub

End Class

Imports Excel = Microsoft.Office.Interop.Excel
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW

Public Class frmRelacionEtiqueta
    Private objMovimiento As clsSDSWInformacionAmcor
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        '  If fblnValidaInformacion(eTipoValidacion.VALIDAR) Then
        If txtRuta.Text <> "" Then
            objMovimiento = New clsSDSWInformacionAmcor
            Ingresar_Datos()
            mfblnProceso_SDSWIngresarInformacionRelacionEtiqueta(objMovimiento)
            Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
        End If

        'If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "I" Then
        'dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor(txtGuia.Text, "")
        'Else
        'dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor("", txtGuia.Text)
        'End If

        ' End If
        ' mfblnProceso_SDSWIngresarInformacionRelacionEtiqueta()
    End Sub

    Private Sub bsaBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBuscar.Click
        Dim dlg As New OpenFileDialog
        'Dim path As String
        dlg.InitialDirectory = "D:\"
        dlg.Filter = "xls files (*.xls)|"
        dlg.FilterIndex = 2
        dlg.RestoreDirectory = True
        If dlg.ShowDialog() = DialogResult.OK Then
            txtRuta.Text = dlg.FileName
        End If
    End Sub
    Public Sub Ingresar_Datos()
        Dim oExcel As Excel.Application = CreateObject("Excel.Application")
        Dim i As Integer
        Try
            'With oExcel
            Dim oBook As Excel.Workbook = oExcel.Workbooks.Open(txtRuta.Text.Trim)
            Dim oSheet As Object = oBook.Worksheets(1)
            For i = 2 To 10000
                Dim objTemp As clsSDSWInformacionAmcor = New clsSDSWInformacionAmcor
                'objTemp.pstrCCLNT = txtCliente.Tag
                objTemp.pstrNETQT = oSheet.Range("A" + Trim(Str(i))).Value
                objTemp.pstrCETQWR = oSheet.Range("B" + Trim(Str(i))).Value
                If objTemp.pstrNETQT = "" Then
                    Exit Sub
                Else
                    objMovimiento.AddItemMovimiento(objTemp)
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        oExcel.Quit() 'Cerrar Aplicacion
        oExcel = Nothing
    End Sub
End Class

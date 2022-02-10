Imports Excel = Microsoft.Office.Interop.Excel
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW
Public Class frmCargarInformacionAmcor
    Private objMovimiento As clsSDSWInformacionAmcor
    Private Sub bsaBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBuscar.Click
        Dim dlg As New OpenFileDialog
        'Dim path As String
        dlg.InitialDirectory = "c:\"
        dlg.Filter = "xls files (*.xls)|"
        dlg.FilterIndex = 2
        dlg.RestoreDirectory = True
        If dlg.ShowDialog() = DialogResult.OK Then
            txtRuta.Text = dlg.FileName
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        objMovimiento = New clsSDSWInformacionAmcor
        Ingresar_Datos()
        mfblnProceso_SDSWIngresarInformacionAmcor(objMovimiento)

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
                objTemp.pstrEntrega = ""
                objTemp.pstrMaterial = ""
                'objTemp.pstrMaterial = oSheet.Range("B" + Trim(Str(i))).Value
                objTemp.pstrLote = oSheet.Range("B" + Trim(Str(i))).Value
                objTemp.pstrDescripcion = ""
                'objTemp.pstrDescripcion = oSheet.Range("B" + Trim(Str(i))).Value()
                objTemp.pstrPeso = ""
                objTemp.pstrFecha = 0
                objTemp.pstrCaja = 1
                objTemp.pstrFlagTipo = "S"
                objTemp.pstrCTPALM = oSheet.Range("D" + Trim(Str(i))).Value
                objTemp.pstrCALMC = oSheet.Range("E" + Trim(Str(i))).Value
                objTemp.PSTRCZNALM = oSheet.Range("F" + Trim(Str(i))).Value
                'objTemp.pstrFlagTipo = MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text))
                objTemp.pstrGUIA = oSheet.Range("A" + Trim(Str(i))).Value
                If objTemp.pstrGUIA = "" Then
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

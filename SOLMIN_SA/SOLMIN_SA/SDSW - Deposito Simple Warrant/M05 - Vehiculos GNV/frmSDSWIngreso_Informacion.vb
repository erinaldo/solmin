Imports Excel = Microsoft.Office.Interop.Excel
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW
Public Class frmSDSWIngreso_Informacion
    Private objMovimiento As clsSDSWInformacionVehiculo
    Dim MyNumber(2) As String
    Enum eTipoValidacion
        VALIDAR
    End Enum
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.VALIDAR Then
            If txtCliente.Text = "" Then strMensajeError &= "No ha seleccionado Cliente." & vbNewLine
            If txtRuta.Text = "" Then strMensajeError &= "No ha seleccionado Archivo." & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function
    Public Sub Ingresar_Datos()
        'Dim oExcel As Excel.Application = CreateObject("Excel.Application")
        'Dim i As Integer
        'Try
        '    'With oExcel
        '    Dim oBook As Excel.Workbook = oExcel.Workbooks.Open(txtRuta.Text.Trim)
        '    Dim oSheet As Object = oBook.Worksheets(1)

        '    For i = 3 To 200

        '        Dim objTemp As clsSDSWInformacionVehiculo = New clsSDSWInformacionVehiculo
        '        objTemp.pstrCCLNT = txtCliente.Tag
        '        objTemp.pstrMarca = oSheet.Range("C" + Trim(Str(i))).Value
        '        objTemp.pstrModelo = oSheet.Range("D" + Trim(Str(i))).Value
        '        objTemp.pstrVin = oSheet.Range("E" + Trim(Str(i))).Value
        '        objTemp.pstrEntrega = oSheet.Range("I" + Trim(Str(i))).Value
        '        Date.TryParse(objTemp.pstrEntrega, objTemp.pdteEntrega)
        '        objTemp.pstrEmpresa = oSheet.Range("K" + Trim(Str(i))).Value
        '        objTemp.pstrWarrant = oSheet.Range("L" + Trim(Str(i))).Value
        '        If objTemp.pstrVin = "" Then
        '            Exit Sub
        '        Else
        '            objMovimiento.AddItemMovimiento(objTemp)
        '        End If
        '    Next

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'oExcel.Quit() 'Cerrar Aplicacion
        'oExcel = Nothing
    End Sub
    Public Sub Limpiar()
        'txtAlmacen.Clear()
        'txtAlmacenD.Clear()
        txtRuta.Clear()
        txtCliente.Clear()

        'cboTipo.Text = ""
        'cboTipoD.Text = ""
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If fblnValidaInformacion(eTipoValidacion.VALIDAR) Then
            objMovimiento = New clsSDSWInformacionVehiculo
            Ingresar_Datos()
            mfblnProceso_SDSWIngresarVehiculo(objMovimiento)
            Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
            Limpiar()
        End If
    End Sub

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

    Private Sub frmIngreso_Informacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
                Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
                If txtCliente.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
End Class

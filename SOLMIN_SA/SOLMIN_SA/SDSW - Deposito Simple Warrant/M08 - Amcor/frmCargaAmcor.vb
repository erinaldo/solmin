Imports Excel = Microsoft.Office.Interop.Excel
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW

Public Class frmCargaAmcor
    Private objMovimiento As clsSDSWInformacionAmcor
    Dim MyNumber(2) As String
    Enum eTipoValidacion
        VALIDAR
    End Enum
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.VALIDAR Then
            '   If txtCliente.Text = "" Then strMensajeError &= "No ha seleccionado Cliente." & vbNewLine
            If txtRuta.Text = "" Then strMensajeError &= "No ha seleccionado Archivo." & vbNewLine
            If Me.txtGuia.Text = "" Then strMensajeError &= "No ha ingresado Guia." & vbNewLine
            If Me.txtTipoAlmacen.Text = "" Then strMensajeError &= "No ha ingresado Tipo de Almacen." & vbNewLine

            If Me.txtAlmacen.Text = "" Then strMensajeError &= "No ha ingresado Almacen." & vbNewLine

            If Me.txtZonaAlmacen.Text = "" Then strMensajeError &= "No ha ingresado Zona de Almacen." & vbNewLine

            If Me.cbxTipo.SelectedIndex = -1 Then strMensajeError &= "No ha seleccionado Tipo de Ingreso." & vbNewLine

        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Public Sub Ingresar_Datos()
        Dim oExcel As Excel.Application = CreateObject("Excel.Application")
        Dim i As Integer
        Try
            'With oExcel
            Dim oBook As Excel.Workbook = oExcel.Workbooks.Open(txtRuta.Text.Trim)
            Dim oSheet As Object = oBook.Worksheets(1)
            For i = 11 To 200
                Dim objTemp As clsSDSWInformacionAmcor = New clsSDSWInformacionAmcor
                'objTemp.pstrCCLNT = txtCliente.Tag
                objTemp.pstrEntrega = oSheet.Range("E" + Trim(Str(i))).Value

                If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "S" Then
                    objTemp.pstrEntregaSalida = oSheet.Range("B" + Trim(Str(i))).Value
                Else
                    objTemp.pstrEntregaSalida = ""
                End If

                objTemp.pstrMaterial = oSheet.Range("I" + Trim(Str(i))).Value
                objTemp.pstrLote = oSheet.Range("H" + Trim(Str(i))).Value
                objTemp.pstrDescripcion = oSheet.Range("K" + Trim(Str(i))).Value
                Date.TryParse(objTemp.pstrFecha, objTemp.pdteFecha)
                objTemp.pstrCantidad = oSheet.Range("V" + Trim(Str(i))).Value
                objTemp.pstrPeso = oSheet.Range("Y" + Trim(Str(i))).Value
                objTemp.pstrFecha = oSheet.Range("O" + Trim(Str(i))).value
                If objTemp.pstrFecha = "" Then
                    objTemp.pstrFecha = 0
                Else
                    objTemp.pstrFecha = objTemp.pstrFecha.Substring(0, 10)
                    Date.TryParse(objTemp.pstrFecha, objTemp.pdteFecha)
                End If

                objTemp.pstrCaja = 1
                objTemp.pstrCTPALM = txtTipoAlmacen.Tag
                objTemp.pstrCALMC = txtAlmacen.Tag
                objTemp.PSTRCZNALM = txtZonaAlmacen.Tag
                objTemp.pstrFlagTipo = MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text))
                objTemp.pstrGUIA = txtGuia.Text
                If objTemp.pstrEntrega = "" Then
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
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If fblnValidaInformacion(eTipoValidacion.VALIDAR) Then
            objMovimiento = New clsSDSWInformacionAmcor
            Ingresar_Datos()
            mfblnProceso_SDSWIngresarInformacionAmcor(objMovimiento)
            Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
            If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "I" Then
                dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor(txtGuia.Text, "")
            Else
                dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor("", txtGuia.Text)
            End If
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub frmCargaAmcor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cbxTipo.Items.Add("Ingreso") : MyNumber(0) = "I"
        cbxTipo.Items.Add("Salida") : MyNumber(1) = "S"

    End Sub
    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacenSDSW(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacenSDSW(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
        txtAlmacen.Text = ""
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacenSDSW(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_AlmacenSDSW("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_AlmacenSDSW("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
        ' Si modificamos el Almacén - debe limpiarse la Zona
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_AlmacenSDSW("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonasAlmacenSDSW("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub

    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_ZonasAlmacenSDSW("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
            Case Keys.Delete
                txtZonaAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtZonaAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
        txtZonaAlmacen.Tag = ""
    End Sub

    Private Sub txtZonaAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
        If txtZonaAlmacen.Text = "" Then
            txtZonaAlmacen.Tag = ""
        Else
            If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
                Call mfblnBuscar_ZonasAlmacenSDSW("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                If txtZonaAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub bsaProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim i As Integer
        Dim orden As DataTable
        Dim DAtos As DataTable
        'Dim Orden As DataTable
        Dim cantidad, peso As Integer
        cantidad = 0
        peso = 0
        Dim Operacion As String

        If fblnValidaInformacion(eTipoValidacion.VALIDAR) Then
            If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "I" Then

                dgvDetalle.DataSource = mfblnProceso_SDSWDetalleAmcor(txtGuia.Text)
                DAtos = mfblnProceso_SDSWDetalleAmcor(txtGuia.Text)
                For i = 0 To Me.dgvDetalle.RowCount - 1
                    Dim objNuevaOrdenServicio As clsSDSWCrearOrdenServicio = New clsSDSWCrearOrdenServicio
                    With objNuevaOrdenServicio
                        Int64.TryParse("" & 12060, .pintCodigoCliente_CCLNT)
                        .pstrCodigoMercaderia_CMRCLR = "1300000030"
                        .pintNroContrato_NCNTR = 658
                        .pstrTipoDeposito_CTPDP3 = "1"
                        .pstrProducto_CTPPR1 = ""
                        ' .pdecCantidadDeclarada_QMRCD = 1
                        'Decimal.TryParse(1, .pdecCantidadDeclarada_QMRCD)
                        Decimal.TryParse(Me.dgvDetalle.Item(3, i).Value.ToString, .pdecCantidadDeclarada_QMRCD)
                        .pstrUnidadCantidad_CUNCND = "CAJ"
                        Decimal.TryParse(Me.dgvDetalle.Item(2, i).Value.ToString, .pdecPesoDeclarado_QPSMR)
                        .pstrUnidadPeso_CUNPS0 = "KGS"
                        Decimal.TryParse(0, .pdecValorDeclarado_QVLMR)
                        .pstrUnidadValor_CUNVLR = "DOL"
                        '.pstrControlLotes_FUNCTL = "N"
                        .pstrControlLotes_FUNCTL = "S"
                        .pstrUnidadDespacho_FUNDS = "C"
                    End With
                    mfblnProceso_SDSWActualizaEstadoAmcor("I", Me.txtGuia.Text)
                    mfblnCrear_SDSWOrdenServicio(objNuevaOrdenServicio)
                    orden = mfblnProceso_BuscaOS()
                    mfblnActualizar_SDSWOrdenAmcor(orden.Rows(0).Item(0).ToString, txtGuia.Text, Me.dgvDetalle.Item(0, i).Value.ToString)
                    'DAtos.Rows(0).Item(0).ToString()
                    'Dim objMercaderia As clsSDSWMovimientoMercaderia = New clsSDSWMovimientoMercaderia
                    'Dim objitem As clsSDSWItemMovimientoMercaderia = New clsSDSWItemMovimientoMercaderia

                    'With objMercaderia
                    '    .pintOrdenServicio_NORDEN = orden.Rows(0).Item(0).ToString
                    'End With
                    'With objitem
                    '    .pstrTipoAlmacen_CTPALM = Me.txtTipoAlmacen.Tag
                    '    .pstrAlmacen_CALMC = txtAlmacen.Tag
                    '    .pstrZonaAlmacen_CZNALM = Me.txtZonaAlmacen.Tag
                    '    .pdecPeso_QTRMP = Me.dgvDetalle.Item(2, i).Value.ToString
                    '    .pdecCantidad_QTRMC = Me.dgvDetalle.Item(3, i).Value.ToString
                    '    .pdteFechaIngreso_FRLZSR = Me.dtpFecha.Text
                    'End With
                    'objMercaderia.AddItemMovimientoMercaderia(objitem)
                    'mfblnRecepcion_MercaderiaAmcor_SDSW(objMercaderia, txtGuia.Text)
                Next

                MessageBox.Show("Se generaron las O/S satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DAtos = mfblnProceso_SDSWDespachoInformacionAmcor(txtGuia.Text)
                orden = mfblnProceso_SDSWConsulta_Estado_Amcor(txtGuia.Text)

                mfblnProceso_SDSWActualizaEstadoAmcor("S", Me.txtGuia.Text)
                If orden.Rows.Count = 0 Then
                    MessageBox.Show("No hay O/S para Generar Liberacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If DAtos.Rows.Count = 0 Then
                        MessageBox.Show("No hay Operaciones para Generar Liberacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        For i = 0 To DAtos.Rows.Count - 1
                            Operacion = DAtos.Rows(0).Item(i).ToString
                            mfblnCrear_SDSWDespachoAmcor(Operacion)
                        Next
                        MessageBox.Show("Se generaron las Liberaciones satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaRuta.Click

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
End Class

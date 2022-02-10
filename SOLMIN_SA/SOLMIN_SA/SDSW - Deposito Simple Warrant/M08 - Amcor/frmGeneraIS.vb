Imports Excel = Microsoft.Office.Interop.Excel
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW

Public Class frmGeneraIS
    Private objMovimiento As clsSDSWInformacionAmcor
    Dim MyNumber(2) As String
    Enum eTipoValidacion
        VALIDAR
    End Enum
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        'fblnValidaInformacion
        If fblnValidaInformacion(eTipoValidacion.VALIDAR) Then
            If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "I" Then
                dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor(txtGuia.Text, "")
            Else
                dgvInformacion.DataSource = mfblnProceso_SDSWListaInformacionAmcor("", txtGuia.Text)
            End If
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    Private Sub frmGeneraIS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbxTipo.Items.Add("Ingreso") : MyNumber(0) = "I"
        Me.cbxTipo.Items.Add("Salida") : MyNumber(1) = "S"
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

                'dgvDetalle.DataSource = mfblnProceso_SDSWDetalleAmcor(txtGuia.Text)
                Me.dgvDetalle.DataSource = mfblnProceso_SDSWDetalleAmcor(txtGuia.Text)

                DAtos = mfblnProceso_SDSWDetalleAmcor(txtGuia.Text)
                For i = 0 To Me.dgvDetalle.RowCount - 1
                    'datos.
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

                    'DAtos.Rows(0).Item(0).ToString)
                    'Dim objMercaderia As clsSDSWMovimientoMercaderia = New clsSDSWMovimientoMercaderia
                    'Dim objitem As clsSDSWItemMovimientoMercaderia = New clsSDSWItemMovimientoMercaderia

                    'With objMercaderia
                    '    .pintOrdenServicio_NORDEN = orden.Rows(0).Item(0).ToString
                    'End With
                    'With objitem
                    '    .pstrTipoAlmacen_CTPALM = Me.dgvDetalle.Item(4, i).Value.ToString.ToString.Trim
                    '    .pstrAlmacen_CALMC = Me.dgvDetalle.Item(5, i).Value.ToString.Trim

                    '    .pstrZonaAlmacen_CZNALM = Me.dgvDetalle.Item(6, i).Value.ToString

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
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.VALIDAR Then
            '   If txtCliente.Text = "" Then strMensajeError &= "No ha seleccionado Cliente." & vbNewLine
            'If txtRuta.Text = "" Then strMensajeError &= "No ha seleccionado Archivo." & vbNewLine
            If Me.txtGuia.Text = "" Then strMensajeError &= "No ha ingresado Guia." & vbNewLine
 
            If Me.cbxTipo.SelectedIndex = -1 Then strMensajeError &= "No ha seleccionado Tipo de Ingreso." & vbNewLine

        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
        'End If

    End Function

End Class

Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.PreFacturaVehiculoW

Public Class frmSDSWPreFactVehiculo
    Dim MyNumber(2) As String
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'Agregado para Almaceneras
        ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region
#Region "Funciones y Procedimientos"
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.Text = "" Then strMensajeError &= "No selecciono el cliente. " & vbNewLine
            'If txtAlmacen.Text = "" Then strMensajeError &= "No selecciono Almacen. " & vbNewLine
            'If cboTipo.Text = "" Then strMensajeError &= "No selecciono Tipo de Almacen." & vbNewLine
            If dtpInicio.Text = "" Then strMensajeError &= "No selecciono Fecha Inicio. " & vbNewLine
            If dtpFinal.Text = "" Then strMensajeError &= "No selecciono Fecha Final. " & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function
    Public Sub ActualizarInfo()
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objFiltro As clsFiltros_SDSWConsultaVehiculos = New clsFiltros_SDSWConsultaVehiculos
            With objFiltro
                .pstrCCLNT = txtCliente.Tag
                Date.TryParse(dtpInicio.Text, .pdteFechaInicio)
                Date.TryParse(dtpFinal.Text, .pdteFechaFin)
            End With
            dgvPreFactura.DataSource = mfdtPreFactura_SDSWVehiculo(objFiltro)
        End If
    End Sub
    Public Sub Reporte_PreFactura()
        Dim objFiltro As clsFiltros_PreFacturaVehiculo = New clsFiltros_PreFacturaVehiculo
        With objFiltro
            .pintCodigoCliente_CCLNT = txtCliente.Tag
            Date.TryParse(dtpInicio.Text, .pdteFechaInicio)
            Date.TryParse(dtpFinal.Text, .pdteFechaFin)
        End With
        Call mpObtenerPreFacturaVehiculoSDSW(objFiltro)
    End Sub
    'Public Shared Function sumarcolumna(ByVal columna As Integer, ByVal grid As DataGridView) As Decimal
    '    Try
    '        Dim total As Decimal = 0
    '        For Each fila As DataGridViewRow In grid.Rows
    '            total += Convert.ToDecimal(fila.Cells(columna).Value)
    '        Next
    '        Return total
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
    Public Sub total()
        Dim i As Integer
        For i = 1 To Me.dgvPreFactura.RowCount - 1
            lblTotal.Text = i
        Next
    End Sub

#End Region

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        ActualizarInfo()
        total()
    End Sub

    Private Sub bsaGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGrabar.Click
        Graba()
    End Sub
    Public Sub Graba()
        If mfblnPreguntas(enumPregVarios.PROCESO_Guardar) Then
            Dim objMovimiento As clsSDSWInformacionVehiculo = New clsSDSWInformacionVehiculo
            With objMovimiento
                .pstrCCLNT = txtCliente.Tag
                Date.TryParse(dtpInicio.Text, .pdteInicio)
                Date.TryParse(dtpFinal.Text, .pdteFinal)
            End With
            mfblnProceso_SDSWPreFactVehiculo(objMovimiento, Compania_Usuario, Division_Usuario)
            mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
            ActualizarInfo()
            Reporte_PreFactura()
        End If
    End Sub
    Private Sub bsaClienteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub frmPreFactVehiculo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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

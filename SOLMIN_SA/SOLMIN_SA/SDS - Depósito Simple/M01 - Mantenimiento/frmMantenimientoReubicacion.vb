Imports RANSA.TYPEDEF
Imports RANSA.NEGO
Public Class frmMantenimientoReubicacion


#Region "Atributos"

#End Region

#Region "Variables"
    Public obeInfoUbicacion As New beUbicacion
    Public myDialogResult As Boolean = False
#End Region

#Region "Metodos y Funciones"

    Private Sub VisualizarDatosOrigen()
        txtTipoAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESTIPO ' obeInfoUbicacion.PSTALMC_I
        txtTipoAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
        txtAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESALM
        txtAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
        txtZonaAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESZONA
        txtZonaAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
        txtPosicionO.Text = obeInfoUbicacion.PSCPSCN_I

        Dim SumLote As Decimal = 0
        If Not dtgKardex.CurrentRow.Cells("ReubicarDelLote").Value Then
            If dgvLotesPosicion.RowCount > 0 Then
                For Each obeLotePosicion As beMercaderia In dgvLotesPosicion.DataSource
                    SumLote = SumLote + obeLotePosicion.PNQSLETQ
                Next
            End If
        End If

        txtCantidadO.Text = (obeInfoUbicacion.PNQTRMC_I - SumLote)
        obeInfoUbicacion.PSCZNALM_I = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
        obeInfoUbicacion.PNNCRRIN = 0
    End Sub






    Private Sub LimpiarControlesOrigen()
        txtTipoAlmacenO.Text = ""
        txtAlmacenO.Text = ""
        txtZonaAlmacenO.Text = ""
        txtPosicionO.Text = ""
        txtCantidadO.Text = ""
    End Sub

    Private Sub ActualizarUbicacionDestino()
        obeInfoUbicacion.PSCTPALM = ("" & txtTipoAlmacen.Tag).ToString.Trim
        obeInfoUbicacion.PSCALMC = ("" & txtAlmacen.Tag).ToString.Trim
        obeInfoUbicacion.PSCZNALM = ("" & txtZonaAlmacen.Tag).ToString.Trim
        obeInfoUbicacion.PSCPSCN = txtPosicion.Text.Trim
        'obeInfoUbicacion.PNQTRMC = Val(txtCantidad.Text.Trim)
        obeInfoUbicacion.PNQTRMC = Val(txtCantidadDestino.Text.Trim)
        obeInfoUbicacion.PSCCMPN = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        obeInfoUbicacion.PSCDVSN = "R"
        obeInfoUbicacion.PSCULUSA = objSeguridadBN.pUsuario
        obeInfoUbicacion.PSCUSCRT = objSeguridadBN.pUsuario
        obeInfoUbicacion.PSNTRMCR = objSeguridadBN.pstrPCName
        obeInfoUbicacion.PSNTRMNL = objSeguridadBN.pstrPCName

    End Sub

    Private Function existeAlmacen() As Boolean
        Dim retorno As Boolean = False
        Return retorno
    End Function

    Private Function EsReubicacion() As Boolean
        Dim retorno As Boolean = True
        ActualizarUbicacionDestino()
        Dim TipoAlmacen As Boolean = obeInfoUbicacion.PSCTPALM_I = obeInfoUbicacion.PSCTPALM
        Dim Almacen As Boolean = obeInfoUbicacion.PSCALMC_I = obeInfoUbicacion.PSCALMC
        Dim Zona As Boolean = obeInfoUbicacion.PSCZNALM_I = obeInfoUbicacion.PSCZNALM
        Dim Posicion As Boolean = obeInfoUbicacion.PSCPSCN_I = obeInfoUbicacion.PSCPSCN
        If (TipoAlmacen And Almacen And Zona And Posicion) Then
            retorno = False
        End If
        Return retorno
    End Function

    Private Function esMovimientoInterno() As String
        Dim retorno As String = "N"
        ActualizarUbicacionDestino()
        Dim TipoAlmacen As Boolean = obeInfoUbicacion.PSCTPALM_I = obeInfoUbicacion.PSCTPALM
        Dim Almacen As Boolean = obeInfoUbicacion.PSCALMC_I = obeInfoUbicacion.PSCALMC
        Dim Zona As Boolean = obeInfoUbicacion.PSCZNALM_I = obeInfoUbicacion.PSCZNALM
        If (TipoAlmacen And Almacen And Zona) Then
            retorno = "S"
        End If
        Return retorno
    End Function

    Private Function ValidarIngreso() As String
        txtPosicion.Text = txtPosicion.Text.Trim
        'txtCantidad.Text = txtCantidad.Text.Trim
        txtCantidadDestino.Text = txtCantidadDestino.Text.Trim
        Dim strmensaje As String = ""
        If (txtTipoAlmacen.Text.Trim = "") Then
            strmensaje = Chr(13) & "* Debe seleccionar Tipo Almacen."
        End If
        If (txtAlmacen.Text.Trim = "") Then
            strmensaje = strmensaje & Chr(13) & "* Debe seleccionar Almacen."
        End If
        If (txtZonaAlmacen.Text.Trim = "") Then
            strmensaje = strmensaje & Chr(13) & "* Debe seleccionar Zona."
        End If
        If (txtPosicion.Text.Trim = "") Then
            strmensaje = strmensaje & Chr(13) & "* Debe Ingresar Posición."
        End If

        If Me.dtgKardex.CurrentCellAddress.Y = -1 Then
            strmensaje = strmensaje & Chr(13) & "* Debe debe de seleccionar la Zona del Kardex."
        End If

        If (strmensaje.Trim = "") Then
            If (EsReubicacion() = False) Then
                strmensaje = strmensaje & "* Para reubicar: "
                strmensaje = strmensaje & "  los almacenes Origen y Destino deben ser diferentes."
            End If
        End If
        'If (txtCantidad.Text.Trim = "" Or Val(txtCantidad.Text.Trim) = 0) Then
        '    txtCantidad.Text = 0
        '    strmensaje = strmensaje & Chr(13) & "* La cantidad  a reubicar debe ser mayor a 0."
        'End If
        'If (txtCantidad.Text.Trim <> "" And Val(txtCantidad.Text.Trim) > Val(txtCantidadO.Text.Trim)) Then
        '    strmensaje = strmensaje & Chr(13) & "* La cantidad a reubicar"
        '    strmensaje = strmensaje & Chr(13) & "   no debe ser mayor a la cantidad origen."
        'End If
        If (txtCantidadDestino.Text.Trim = "" Or Val(txtCantidadDestino.Text.Trim) = 0) Then
            txtCantidadDestino.Text = 0
            strmensaje = strmensaje & Chr(13) & "* La cantidad  a reubicar debe ser mayor a 0."
        End If
        If (txtCantidadDestino.Text.Trim <> "" And Val(txtCantidadDestino.Text.Trim) > Val(txtCantidadO.Text.Trim)) Then
            strmensaje = strmensaje & Chr(13) & "* La cantidad a reubicar"
            strmensaje = strmensaje & Chr(13) & "   no debe ser mayor a la cantidad origen."
        End If


        'If CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNQSLMC2 < Val(txtCantidadO.Text.Trim) Then
        '    strmensaje = strmensaje & Chr(13) & "* La cantidad origen"
        '    strmensaje = strmensaje & Chr(13) & "   no debe ser mayor que el Saldo del Inventario de la Zona Almaacén"
        'End If

        'If CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNQSLMC2 < Val(txtCantidad.Text.Trim) Then
        '    strmensaje = strmensaje & Chr(13) & "* La cantidad a reubicar"
        '    strmensaje = strmensaje & Chr(13) & "   no debe ser mayor al Saldo del Inventario de la Zona Almaacén"
        'End If
        If CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNQSLMC2 < Val(txtCantidadDestino.Text.Trim) Then
            strmensaje = strmensaje & Chr(13) & "* La cantidad a reubicar"
            strmensaje = strmensaje & Chr(13) & "   no debe ser mayor al Saldo del Inventario de la Zona Almaacén"
        End If


        Return strmensaje
    End Function


#End Region

#Region "Eventos"

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Try
            Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Try
            Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Try
            Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                Case Keys.Delete
                    txtAlmacen.Text = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        Try
            If txtAlmacen.Text = "" Then
                txtAlmacen.Tag = ""
            Else
                If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                    Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                    If txtAlmacen.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                Case Keys.Delete
                    txtTipoAlmacen.Text = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        txtAlmacen.Text = ""
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        Try
            If txtTipoAlmacen.Text = "" Then
                txtTipoAlmacen.Tag = ""
            Else
                If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                    Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                    If txtTipoAlmacen.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                Case Keys.Delete
                    txtZonaAlmacen.Text = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtZonaAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
        txtZonaAlmacen.Tag = ""
    End Sub

    Private Sub txtZonaAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
        If txtZonaAlmacen.Text = "" Then
            txtZonaAlmacen.Tag = ""
        Else
            If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
                Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                If txtZonaAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmMantenimientoReubicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obrMercaderia As New brMercaderia
            Dim obeMercaderia As New beMercaderia
            dtgKardex.AutoGenerateColumns = False

            obeMercaderia.PNNORDSR = obeInfoUbicacion.PNNORDSR
            obeMercaderia.PSCTPALM = obeInfoUbicacion.PSCTPALM_I
            obeMercaderia.PSCALMC = obeInfoUbicacion.PSCALMC_I
            obeMercaderia.PSCZNALM = obeInfoUbicacion.PSCZNALM_I 'Agregado'
            Me.dtgKardex.DataSource = obrMercaderia.ListaKardexAlmacen(obeMercaderia)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
    '    Try
    '        If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
    '            e.Handled = True
    '        End If
    '        Select Case AscW(e.KeyChar)
    '            Case 8, 13, 32
    '                e.Handled = False
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim strmensaje As String = ""
            Dim strFlujo As String = ""
            Dim obrUbicacion As New brUbicacion
            ActualizarUbicacionDestino()
            strmensaje = ValidarIngreso()
            If (strmensaje <> "") Then
                MessageBox.Show(strmensaje, "Reubicación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            obeInfoUbicacion.PSINTERNO = esMovimientoInterno()
            obeInfoUbicacion = obrUbicacion.RegistrarReubicacionMercaderia(obeInfoUbicacion)
            If (obeInfoUbicacion.PSEXISTEUBICACION = "N") Then
                MessageBox.Show("La Ubicación Destino no existe." & Chr(13) & "Verifique la posición", "Reubicación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf (obeInfoUbicacion.PSREUBICACION = "INSERT") Then
                MessageBox.Show("La Reubicación se realizó satisfactoriamente.", "Reubicación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                myDialogResult = True
                Me.Close()
                'Else
                '    MessageBox.Show("No se pudo realizar la reubicación.", "Reubicación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub dtgKardex_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgKardex.CellClick
        Try
            If dtgKardex.CurrentCellAddress.Y = -1 Then Exit Sub

            If dtgKardex.Columns(e.ColumnIndex).Name = "ReubicarDelLote" And dtgKardex.CurrentRow.Cells("ExisteLote").Value Then

                dtgKardex.CurrentRow.Cells("ReubicarDelLote").Value = Not dtgKardex.CurrentRow.Cells("ReubicarDelLote").Value
                dtgKardex.EndEdit()
                dgvLotesPosicion.Visible = dtgKardex.CurrentRow.Cells("ReubicarDelLote").Value
                LimpiarControlesOrigen()
                If dgvLotesPosicion.Visible Then
                    VisualizarDatosOrigenLote()
                Else
                    VisualizarDatosOrigen()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgKardex_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgKardex.CellEndEdit
        If dtgKardex.CurrentCellAddress.Y = -1 Then Exit Sub



        'If dtgKardex.Columns(e.ColumnIndex).Name = "ReubicarDelLote" Then
        '    dgvLotesPosicion.Visible = dtgKardex.CurrentRow.Cells("ReubicarDelLote").Value
        '    LimpiarControlesOrigen()
        '    If dgvLotesPosicion.Visible Then
        '        VisualizarDatosOrigenLote()
        '    Else
        '        VisualizarDatosOrigen()
        '    End If
        'End If
    End Sub

    Private Sub dtgKardex_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgKardex.DataBindingComplete
        For Each oDtRow As DataGridViewRow In dtgKardex.Rows
            Dim obrMercaderia As New brMercaderia
            Dim obeMercaderia As New beMercaderia
            obeMercaderia = oDtRow.DataBoundItem
            'For Each obeMercaderiaFiltro As beMercaderia In Me.dtgKardex.DataSource
            Dim key As New KeyValuePair(Of Int64, Int64)(obeMercaderia.PNNORDSR, obeMercaderia.PNNSLCSR)
            With obeMercaderia
                .PNNORDSR = obeInfoUbicacion.PNNORDSR
                '.PSCTPALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
                '.PSCALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
                .PSCSECTR = "G"
                .PSCPSCN = obeInfoUbicacion.PSCPSCN_I
            End With
            Dim olbelote As New List(Of beMercaderia)
            olbelote = obrMercaderia.ListaLotesPorOSPosicion(obeMercaderia)
            dgvLotesPosicion.AutoGenerateColumns = False
            dgvLotesPosicion.DataSource = olbelote

            If olbelote.Count = 0 Then
                oDtRow.Cells("ExisteLote").Value = False
                oDtRow.Cells("ReubicarDelLote").Value = False
                oDtRow.Cells("ReubicarDelLote").ReadOnly = True
            Else
                oDtRow.ReadOnly = False
                oDtRow.Cells("ExisteLote").Value = True
                oDtRow.Cells("ReubicarDelLote").Value = True
                oDtRow.Cells("ReubicarDelLote").ReadOnly = False
            End If
            oDtRow.Tag = olbelote

        Next
    End Sub

    Private Sub dtgKardex_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgKardex.SelectionChanged
        Try
            LimpiarControlesOrigen()
            If Me.dtgKardex.CurrentCellAddress.Y <> -1 Then
                dgvLotesPosicion.Visible = dtgKardex.CurrentRow.Cells("ReubicarDelLote").Value
                If dtgKardex.CurrentRow.Tag Is Nothing OrElse CType(dtgKardex.CurrentRow.Tag, List(Of beMercaderia)).Count = 0 Then
                    VisualizarDatosOrigen()
                Else
                    dgvLotesPosicion.DataSource = dtgKardex.CurrentRow.Tag
                    VisualizarDatosOrigen()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub fAsociarLotes()

        'txtTipoAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESTIPO ' obeInfoUbicacion.PSTALMC_I
        'txtTipoAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
        'txtAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESALM
        'txtAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
        'txtZonaAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESZONA
        'txtZonaAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
        'txtPosicionO.Text = obeInfoUbicacion.PSCPSCN_I
        'txtCantidadO.Text = obeInfoUbicacion.PNQTRMC_I
        'obeInfoUbicacion.PSCZNALM_I = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM

        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        'For Each obeMercaderiaFiltro As beMercaderia In Me.dtgKardex.DataSource
        Dim key As New KeyValuePair(Of Int64, Int64)(obeMercaderia.PNNORDSR, obeMercaderia.PNNSLCSR)
        With obeMercaderia
            .PNNORDSR = obeInfoUbicacion.PNNORDSR
            .PSCTPALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
            .PSCALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
            .PSCSECTR = "G"
            .PSCPSCN = obeInfoUbicacion.PSCPSCN_I
        End With
        Dim olbelote As New List(Of beMercaderia)
        olbelote = obrMercaderia.ListaLotesPorOSPosicion(obeMercaderia)
        dgvLotesPosicion.AutoGenerateColumns = False
        dgvLotesPosicion.DataSource = olbelote

        dtgKardex.CurrentRow.Tag = olbelote
        'Next
    End Sub

    Private Sub dgvLotesPosicion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLotesPosicion.SelectionChanged
        Try
            LimpiarControlesOrigen()
            If Me.dgvLotesPosicion.CurrentCellAddress.Y <> -1 Then
                VisualizarDatosOrigenLote()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub VisualizarDatosOrigenLote()
        txtTipoAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESTIPO ' obeInfoUbicacion.PSTALMC_I
        txtTipoAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
        txtAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESALM
        txtAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
        txtZonaAlmacenO.Text = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSDESZONA
        txtZonaAlmacenO.Tag = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
        txtPosicionO.Text = obeInfoUbicacion.PSCPSCN_I
        txtCantidadO.Text = CType(dgvLotesPosicion.CurrentRow.DataBoundItem, beMercaderia).PNQSLETQ
        obeInfoUbicacion.PSCZNALM_I = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
        obeInfoUbicacion.PNNCRRIN = CType(dgvLotesPosicion.CurrentRow.DataBoundItem, beMercaderia).PNNCRRIN
    End Sub

End Class

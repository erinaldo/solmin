Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Public Class frmSDSWEditaOS
    Public Orden As String

    Private Sub bsaListarUnidadCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadCantidad.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadCantidad.Text, "C")
        txtUnidadCantidad.Tag = txtUnidadCantidad.Text
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaListarUnidadPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadPeso.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadPeso.Text, "P")
        txtUnidadPeso.Tag = txtUnidadPeso.Text
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub txtUnidadCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadCantidad.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadCantidad.Text, "C")
            txtUnidadCantidad.Tag = txtUnidadCantidad.Text
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtUnidadCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidadCantidad.TextChanged
        txtUnidadCantidad.Tag = ""
    End Sub

    Private Sub txtUnidadCantidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadCantidad.Validating
        If txtUnidadCantidad.Text = "" Then
            txtUnidadCantidad.Tag = ""
        Else
            If txtUnidadCantidad.Text <> "" And "" & txtUnidadCantidad.Tag = "" Then
                Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadCantidad.Text, "C")
                txtUnidadCantidad.Tag = txtUnidadCantidad.Text
                If txtUnidadCantidad.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtUnidadPeso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadPeso.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadPeso.Text, "P")
            txtUnidadPeso.Tag = txtUnidadPeso.Text
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtUnidadPeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidadPeso.TextChanged
        txtUnidadPeso.Tag = ""
    End Sub

    Private Sub txtUnidadPeso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadPeso.Validating
        If txtUnidadPeso.Text = "" Then
            txtUnidadPeso.Tag = ""
        Else
            If txtUnidadPeso.Text <> "" And "" & txtUnidadPeso.Tag = "" Then
                Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadPeso.Text, "P")
                txtUnidadPeso.Tag = txtUnidadPeso.Text
                If txtUnidadPeso.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub btnProcesarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarCrearOS.Click
        pEditarOS()
        Me.Close()
    End Sub
    Private Function pEditarOS() As Boolean
        Dim blnResultado As Boolean = True
        If Not fblnValidarInfNuevaOS() Then
            blnResultado = False
        Else
            Dim objNuevaOrdenServicio As clsSDSWInformacionOrdenServicio = New clsSDSWInformacionOrdenServicio
            objNuevaOrdenServicio.pintOrdenServicio_NORDSR = Orden
            'Busca si existe operaciones para la O/S
            If mfblnExiste_SDSWOrdenOperacion(Compania_Usuario, Division_Usuario, objNuevaOrdenServicio, False) = False Then
                With objNuevaOrdenServicio
                    '.pintOrdenServicio_NORDSR
                    Decimal.TryParse(txtCantidad.Text, .pdecCantidadDeclarada_QMRCD)
                    .pstrUnidadCantidad_CUNCND = txtUnidadCantidad.Text
                    Decimal.TryParse(txtPeso.Text, .pdecPesoDeclarado_QPSMR)
                    .pstrUnidadPeso_CUNPS0 = txtUnidadPeso.Text
                    .pstrControlLotes_FUNCTL = "N"
                End With
                blnResultado = mfblnEditar_SDSWOrdenServicio(objNuevaOrdenServicio)
                objNuevaOrdenServicio = Nothing
                If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Crear)
            End If
        End If
        Return blnResultado
    End Function
    Private Function fblnValidarInfNuevaOS() As Boolean
        Dim strResultado As String = ""
        Dim blnResultado As Boolean = True
        Dim decTemp As Decimal
        Decimal.TryParse(txtCantidad.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar una Cantidad mayor o igual a cero. " & vbNewLine
        If txtUnidadCantidad.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información de las Cantidades. " & vbNewLine
        Decimal.TryParse(txtPeso.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar un Peso mayor o igual a cero. " & vbNewLine
        If txtUnidadPeso.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información de los Pesos. " & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub btnCancelarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCrearOS.Click
        Me.Close()
    End Sub
End Class

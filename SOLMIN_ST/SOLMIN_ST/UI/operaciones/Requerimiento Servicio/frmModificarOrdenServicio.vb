Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Public Class frmModificarOrdenServicio

    Private _objEntidad As AtencionRequerimiento

    Public Property objEntidad() As AtencionRequerimiento
        Get
            Return _objEntidad
        End Get
        Set(ByVal value As AtencionRequerimiento)
            _objEntidad = value
        End Set
    End Property

    'Private _CCLNT As Decimal = 0
    'Public Property CCLNT() As Decimal
    '    Get
    '        Return _CCLNT
    '    End Get
    '    Set(ByVal value As Decimal)
    '        If _CCLNT = value Then
    '            Return
    '        End If
    '        _CCLNT = value
    '    End Set
    'End Property

    'Private _NUMREQT As Decimal = 0
    'Public Property NUMREQT() As Decimal
    '    Get
    '        Return _NUMREQT
    '    End Get
    '    Set(ByVal value As Decimal)
    '        If _NUMREQT = value Then
    '            Return
    '        End If
    '        _NUMREQT = value
    '    End Set
    'End Property

    'Private _CCMPN As String = ""
    'Public Property CCMPN() As String
    '    Get
    '        Return _CCMPN
    '    End Get
    '    Set(ByVal value As String)
    '        If _CCMPN = value Then
    '            Return
    '        End If
    '        _CCMPN = value
    '    End Set
    'End Property

    'Private _CDVSN As String = ""
    'Public Property CDVSN() As String
    '    Get
    '        Return _CDVSN
    '    End Get
    '    Set(ByVal value As String)
    '        If _CDVSN = value Then
    '            Return
    '        End If
    '        _CDVSN = value
    '    End Set
    'End Property

    'Private _QSLCIT As Decimal = 0
    'Public Property QSLCIT() As String
    '    Get
    '        Return _QSLCIT
    '    End Get
    '    Set(ByVal value As String)
    '        If _QSLCIT = value Then
    '            Return
    '        End If
    '        _QSLCIT = value
    '    End Set
    'End Property

    Private Sub frmModificarOrdenServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNroReq.Text = objEntidad.NUMREQT
        txtCantidadSolicitada.Text = objEntidad.QSLCIT
        txtOS.Text = objEntidad.NORSRT 'dgvDatos.CurrentRow.Cells("NORSRT").Value
        txtOSAgencia.Text = objEntidad.NDCORM 'dgvDatos.CurrentRow.Cells("NDCORM").Value
        txtOSAgencia.Tag = objEntidad.PNCDTR 'dgvDatos.CurrentRow.Cells("PNCDTR").Value
        txtUbigeoOrigen.Text = objEntidad.CUBORI_S
        txtUbigeoDestino.Text = objEntidad.CUBDES_S
        txtLocalidadOrigen.Text = objEntidad.CLCLOR & " -> " & objEntidad.CLCLOR_S
        txtLocalidadOrigen.Tag = objEntidad.CLCLOR
        txtLocalidadDestino.Text = objEntidad.CLCLDS & " -> " & objEntidad.CLCLDS_S
        txtLocalidadDestino.Tag = objEntidad.CLCLDS
    End Sub

    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click
        'If UcCliente_TxtF011.pCodigo > 0 Then
        If objEntidad.CCLNT > 0 Then
            Try

                Dim objFormBuscarOrdenServicio As New frmBuscarOrdenServicio
                With objFormBuscarOrdenServicio
                    .CodigoCliente = objEntidad.CCLNT
                    .CCMPN = objEntidad.CCMPN 'cmbCompania.CCMPN_CodigoCompania
                    .CDVSN = objEntidad.CDVSN 'cmbDivision.Division
                    '.USUARIO = MainModule.USUARIO
                    .WindowState = FormWindowState.Maximized
                End With

                objFormBuscarOrdenServicio.ShowDialog()

                If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE IsNot Nothing Then

                    txtOS.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT

                    If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR.ToString.Trim = "0" Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR.ToString.Trim = "" Then
                        txtLocalidadOrigen.Text = ""
                        txtLocalidadOrigen.Tag = 0
                    Else
                        txtLocalidadOrigen.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTORG
                        txtLocalidadOrigen.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR
                        objEntidad.CLCLOR_S = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTORG

                    End If

                    If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS.ToString.Trim = "0" Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS.ToString.Trim = "" Then
                        txtLocalidadDestino.Text = ""
                        txtLocalidadDestino.Tag = 0
                    Else
                        txtLocalidadDestino.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTDES
                        txtLocalidadDestino.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS
                        objEntidad.CLCLDS_S = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTDES
                    End If

                    If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI = 0 Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI.ToString.Trim = "" Then
                        txtUbigeoOrigen.Text = ""
                    Else
                        txtUbigeoOrigen.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_O
                    End If

                    If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES = 0 Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES.ToString.Trim = "" Then
                        txtUbigeoDestino.Text = ""
                    Else
                        txtUbigeoDestino.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_D
                    End If

                    'txtTipoUnidad.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTPUNV
                    'txtMercaderia.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CMRCDR

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Debe seleccionar Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnAsignarOSAgencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOSAgencias.Click
        Try

            Dim objfrmOSAgenciasRansa As New frmOperacionAgenciasRansaPopup
            objfrmOSAgenciasRansa.Codigo_Cliente = objEntidad.CCLNT 'txtClienteFiltro.pCodigo
            objfrmOSAgenciasRansa.ShowDialog(Me)
            Me.txtOSAgencia.Text = objfrmOSAgenciasRansa.OrdenServio_AgenciasRansa
            txtOSAgencia.Tag = objfrmOSAgenciasRansa.Operacion_Agencias
            '_PNCDTR_Operacion = objfrmOSAgenciasRansa.Operacion_Agencias
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""

        If txtOS.Text.ToString.Trim = "" Then strMensajeError &= "* Seleccione Orden de Servicio" & vbNewLine
        If txtLocalidadOrigen.Text.ToString.Trim = "" Then strMensajeError &= "* No tiene Localidad Origen" & vbNewLine
        If txtLocalidadDestino.Text.ToString.Trim = "" Then strMensajeError &= "* No tiene Localidad Destino" & vbNewLine

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Validar() Then Exit Sub
            'Dim objAteReq As New AtencionRequerimiento
            Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
            'objEntidad.NUMREQT = Val(txtNroReq.Text)
            'objEntidad.CCMPN = objEntidad.CCMPN
            objEntidad.QSLCIT = Val(txtCantidadSolicitada.Text)
            objEntidad.NDCORM = Val(txtOSAgencia.Text)
            objEntidad.PNCDTR = ("" & txtOSAgencia.Tag).ToString.Trim
            objEntidad.CUSOSAR = MainModule.USUARIO
            objEntidad.NORSRT = Val(txtOS.Text)
            objEntidad.CLCLOR = txtLocalidadOrigen.Tag
            'objEntidad.CLCLOR_S = txtLocalidadOrigen.Text
            objEntidad.CLCLDS = txtLocalidadDestino.Tag
            'objEntidad.CLCLDS_S = txtLocalidadDestino.Text
            If objAtencionRequerimiento.Actualizar_OS_Requerimiento(objEntidad) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCantidadSolicitada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadSolicitada.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

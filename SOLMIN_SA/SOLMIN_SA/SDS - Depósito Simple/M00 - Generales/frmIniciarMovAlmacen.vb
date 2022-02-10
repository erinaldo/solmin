Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class frmIniciarMovAlmacen
#Region " Tipo de Datos "

#End Region
#Region " Atributos "
    Private intCCLNT As Int64 = 0       ' Cliente
    Private strTCMPCL As String = ""    ' Razón Social del Cliente
    Private intCSRVC As Integer = 0     ' Servicio
    Private strCTPDPS As String = ""    ' Tipo de Deposito
    Private blnStatusNuevoAcoplado As Boolean = False
    Private blnStatusNuevoBrevete As Boolean = False
    Private blnStatusValidacion As Boolean = False
    Private objMovimientoMercaderia As clsMovimientoMercaderia = Nothing
#End Region
#Region " Propiedades "
    ' Se proporciona el Codigo del Cliente 
    Public WriteOnly Property pintCodigoCliente() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property
    ' Razon Social del Cliente
    Public WriteOnly Property pstrRazonSocialCliente() As String
        Set(ByVal value As String)
            strTCMPCL = value
        End Set
    End Property
    ' Servicio
    Public WriteOnly Property pintServicio() As Integer
        Set(ByVal value As Integer)
            intCSRVC = value
        End Set
    End Property
    ' Indicar si es un proceso de Recepción / Despacho
    Public WriteOnly Property pstrAdicinarInfTitulo() As String
        Set(ByVal value As String)
            Me.Text &= value
        End Set
    End Property
    ' Información de la Cabecera
    Public ReadOnly Property pobjInformacionIngresada() As clsMovimientoMercaderia
        Get
            Return objMovimientoMercaderia
        End Get
    End Property

    Public ReadOnly Property pCheckServicio() As Boolean
        Get
            Dim blnTemp As Boolean = False
            If Me.chkRegistrarServicio.CheckState = CheckState.Checked Then blnTemp = True
            Return blnTemp
        End Get
    End Property
#End Region
#Region " Procedimientos y Funciones "
    Private Sub pLimpiarCabecera()
        txtEmpresaTransporte.Clear()
        txtNroRUCEmpresaTransporte.Clear()
        txtUnidad.Clear()
        txtMarca.Clear()
        txtAnio.Clear()
        txtBrevete.Clear()
        txtChofer.Clear()
        txtDocIdentidadChofer.Clear()
        txtObservaciones.Clear()
    End Sub

    Private Sub pProcesarRegistroInfCabecera()
        If Not fblnValidar() Then Exit Sub
        ' Ingreso de la Unidad - Camión
        If blnStatusNuevoAcoplado Then If Not mfblnGrabar_Camion(txtEmpresaTransporte.Tag, txtUnidad.Text, txtAnio.Text, txtMarca.Text) Then Exit Sub
        ' Ingreso de la Información del Brevete
        If blnStatusNuevoBrevete Then If Not mfblnGrabar_Chofer(txtEmpresaTransporte.Tag, txtBrevete.Text, txtChofer.Text, txtDocIdentidadChofer.Text) Then Exit Sub
        objMovimientoMercaderia = New clsMovimientoMercaderia
        With objMovimientoMercaderia
            ' Cliente
            .pintCodigoCliente_CCLNT = intCCLNT
            .pstrRazonSocialCliente_TCMPCL = strTCMPCL
            ' Servicio
            .pintServicio_CSRVC = intCSRVC
            ' Empresa de Transporte
            Int32.TryParse("" & txtEmpresaTransporte.Tag, .pintEmpresaTransporte_CTRSP)
            .pstrRazonSocialEmpTransporte_TCMPTR = txtEmpresaTransporte.Text
            Int64.TryParse(txtNroRUCEmpresaTransporte.Text, .pintNroRUCEmpTransporte_NRUCT)
            ' Unidad
            .pstrNroPlacaCamion_NPLCCM = txtUnidad.Text
            .pstrMarcaUnidad_TMRCCM = txtMarca.Text
            Int16.TryParse(txtAnio.Text, .pintAnioUnidad_NANOCM)
            ' Brevete
            .pstrNroBrevete_NBRVCH = txtBrevete.Text
            .pstrChofer_TNMBCH = txtChofer.Text
            Int32.TryParse(txtDocIdentidadChofer.Text, .pintNroDocIdentidadChofer_NLELCH)
            ' Observacion
            .pstrObservaciones_TOBSER = txtObservaciones.Text
            ' Compañía y División
            .pstrCompania_CCMPN = GLOBAL_COMPANIA
            .pstrDivision_CDVSN = GLOBAL_DIVISION
            .pstrFechaRealizacion_FRLZSR = dteFechaRecepcion.Value.Date
        End With
    End Sub

    Private Function fblnValidar() As Boolean
        Dim strResultado As String = ""

        blnStatusValidacion = True
        If txtEmpresaTransporte.Text = "" Then strResultado &= "Debe seleccionar una Empresa de Transporte. " & vbNewLine
        If txtUnidad.Text <> "" Then
            If blnStatusNuevoAcoplado Then
                If txtMarca.Text = "" Then strResultado &= "Debe proporcionar una marca para el NUEVO Acoplado. " & vbNewLine
                If txtAnio.Text = "" Then strResultado &= "Debe ingresar el AÑO para el NUEVO Acoplado. " & vbNewLine
            End If
        End If
        If txtBrevete.Text <> "" Then
            If blnStatusNuevoBrevete Then
                If txtChofer.Text = "" Then strResultado &= "Debe proporcionar el Nombre del Chofer. " & vbNewLine
                If txtDocIdentidadChofer.Text = "" Then strResultado &= "Debe ingresar el Nro. de Doc. de Identidad. " & vbNewLine
            End If
        End If
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnStatusValidacion = False
        End If
        Return blnStatusValidacion
    End Function
#End Region
#Region " Métodos "
    Private Sub bsaUnidadListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUnidadListar.Click
        Try
            Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtUnidad.Text, "", "", txtAnio.Text, txtMarca.Text, "")
            txtUnidad.Tag = txtUnidad.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaBreveteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBreveteListar.Click
        Try
            Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtBrevete.Text, txtChofer.Text, txtDocIdentidadChofer.Text)
            txtBrevete.Tag = txtBrevete.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaEmpresaTransporteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporteListar.Click
        Try
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, txtNroRUCEmpresaTransporte.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ' Se pone en TRUE para no registrar error, lo cual impide salir
        blnStatusValidacion = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Call pProcesarRegistroInfCabecera()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmIniciarMovAlmacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnStatusValidacion Then e.Cancel = True
    End Sub

    Private Sub txtUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtUnidad.Text, "", "", txtAnio.Text, txtMarca.Text, "")
                    txtUnidad.Tag = txtUnidad.Text
                Case Keys.Delete
                    txtUnidad.Text = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidad.TextChanged
        txtUnidad.Tag = ""
    End Sub

    Private Sub txtUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidad.Validating
        Try
            If txtUnidad.Text = "" Or txtEmpresaTransporte.Text = "" Then
                ' Color
                txtAnio.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                txtMarca.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                ' Limpio los controles
                txtUnidad.Tag = ""
                txtAnio.Text = ""
                txtMarca.Text = ""
                txtAnio.ReadOnly = True
                txtMarca.ReadOnly = True
                txtAnio.TabStop = False
                txtMarca.TabStop = False
                ' limpiamos la variable del status de nuevo acoplado
                blnStatusNuevoAcoplado = False
            Else
                If mfblnExiste_PlacaCamion("" & txtEmpresaTransporte.Tag, txtUnidad.Text, "") Then
                    ' Color
                    txtAnio.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                    txtMarca.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                    ' Solo lectura
                    txtAnio.ReadOnly = True
                    txtMarca.ReadOnly = True
                    ' Quitar el enfoque
                    txtAnio.TabStop = False
                    txtMarca.TabStop = False
                    If txtUnidad.Text <> "" And "" & txtUnidad.Tag = "" Then
                        Call mfblnObtenerDetalle_SDSPlacaCamion("" & txtEmpresaTransporte.Tag, txtUnidad.Text, txtAnio.Text, txtMarca.Text)
                        txtUnidad.Tag = txtUnidad.Text
                    End If
                    ' Actualizamos la variable del status de nuevo acoplado
                    blnStatusNuevoAcoplado = False
                Else
                    If txtMarca.Text = "" Then mpMsjeVarios(enumMsjVarios.NOEXIST_Registrar)
                    txtUnidad.Tag = ""
                    ' Color
                    txtAnio.StateCommon.Back.Color1 = txtUnidad.StateCommon.Back.Color1
                    txtMarca.StateCommon.Back.Color1 = txtUnidad.StateCommon.Back.Color1
                    ' Habilitamos la escritura
                    txtAnio.ReadOnly = False
                    txtMarca.ReadOnly = False
                    ' Asignamos el enfoque 
                    txtAnio.TabStop = True
                    txtMarca.TabStop = True
                    txtMarca.Focus()
                    ' Actualizamos la variable del status de nuevo acoplado
                    blnStatusNuevoAcoplado = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAnio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAnio.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                txtAnio.Text = ""
        End Select
    End Sub

    Private Sub txtBrevete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrevete.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtBrevete.Text, txtChofer.Text, txtDocIdentidadChofer.Text)
                    txtBrevete.Tag = txtBrevete.Text
                Case Keys.Delete
                    txtBrevete.Text = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtBrevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrevete.TextChanged
        txtBrevete.Tag = ""
    End Sub

    Private Sub txtBrevete_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBrevete.Validating

        Try
            If txtBrevete.Text = "" Then
                ' Color
                txtChofer.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                txtDocIdentidadChofer.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                txtBrevete.Tag = ""
                txtChofer.Text = ""
                txtDocIdentidadChofer.Text = ""
                txtChofer.ReadOnly = True
                txtDocIdentidadChofer.ReadOnly = True
                txtChofer.TabStop = False
                txtDocIdentidadChofer.TabStop = False
                ' limpiamos la variable del status de nuevo nro. de brevete
                blnStatusNuevoBrevete = False
            Else
                If mfblnExiste_Chofer("" & txtEmpresaTransporte.Tag, txtBrevete.Text, "") Then
                    ' Color
                    txtChofer.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                    txtDocIdentidadChofer.StateCommon.Back.Color1 = txtNroRUCEmpresaTransporte.StateCommon.Back.Color1
                    ' Solo lectura
                    txtChofer.ReadOnly = True
                    txtDocIdentidadChofer.ReadOnly = True
                    ' Quitar el enfoque
                    txtChofer.TabStop = False
                    txtDocIdentidadChofer.TabStop = False
                    If txtBrevete.Text <> "" And "" & txtBrevete.Tag = "" Then
                        Call mfblnObtenerDetalle_SDSChofer("" & txtEmpresaTransporte.Tag, txtBrevete.Text, txtChofer.Text, txtDocIdentidadChofer.Text)
                        txtBrevete.Tag = txtBrevete.Text
                    End If
                    ' Actualizamos la variable del status de nuevo nro. de brevete
                    blnStatusNuevoBrevete = False
                Else
                    If txtChofer.Text = "" Then mpMsjeVarios(enumMsjVarios.NOEXIST_Registrar)
                    txtBrevete.Tag = ""
                    ' Color
                    txtChofer.StateCommon.Back.Color1 = txtUnidad.StateCommon.Back.Color1
                    txtDocIdentidadChofer.StateCommon.Back.Color1 = txtUnidad.StateCommon.Back.Color1
                    ' Habilitamos la escritura
                    txtChofer.ReadOnly = False
                    txtDocIdentidadChofer.ReadOnly = False
                    ' Asignamos el enfoque 
                    txtChofer.TabStop = True
                    txtDocIdentidadChofer.TabStop = True
                    txtChofer.Focus()
                    ' Actualizamos la variable del status de nuevo nro. de brevete
                    blnStatusNuevoBrevete = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtEmpresaTransporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4
                    Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, txtNroRUCEmpresaTransporte.Text)
                Case Keys.Delete
                    txtEmpresaTransporte.Text = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtEmpresaTransporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.TextChanged
        txtEmpresaTransporte.Tag = ""
    End Sub

    Private Sub txtEmpresaTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte.Validating
        Try
            If txtEmpresaTransporte.Text = "" Then
                txtEmpresaTransporte.Tag = ""
                txtNroRUCEmpresaTransporte.Text = ""
            Else
                If txtEmpresaTransporte.Text <> "" And "" & txtEmpresaTransporte.Tag = "" Then
                    Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, txtNroRUCEmpresaTransporte.Text)
                    If txtEmpresaTransporte.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMarca.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                txtMarca.Text = ""
        End Select
    End Sub
#End Region
End Class

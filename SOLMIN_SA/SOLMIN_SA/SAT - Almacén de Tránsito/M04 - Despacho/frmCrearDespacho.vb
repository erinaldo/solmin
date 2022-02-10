Imports RANSA.NEGO.slnSOLMIN_SAT.PreDespacho
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Procesos
Imports RANSA.TypeDef.Servicios
Imports RANSA.Controls.Servicios
Imports Ransa.Controls.ServicioOperacion
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.Utilitario

Public Class frmCrearDespacho
#Region " Atributos "
    ' Creamos la variable PreDespacho
    Private intCCLNT As Integer = 0
    Private intNROCTL As Integer = 0
    '-- Crear status por control con F4
    Private booValidarDespachoRemision As Boolean = False
    Private booValidarPlacaAcoplado As Boolean = False
    Public intFechaBultos As Decimal = 0
#End Region
#Region " Propiedades "
    Public Property pCodigoCliente_CCLNT() As Int32
        Get
            pCodigoCliente_CCLNT = intCCLNT
        End Get
        Set(ByVal value As Int32)
            intCCLNT = value
        End Set
    End Property

    Public Property pNroControl_NROCTL() As Int32
        Get
            pNroControl_NROCTL = intNROCTL
        End Get
        Set(ByVal value As Int32)
            intNROCTL = value
        End Set
    End Property


    Private _pCCMPN_Compania As String = ""
    Public Property pCCMPN_Compania() As String
        Get
            Return _pCCMPN_Compania
        End Get
        Set(ByVal value As String)
            _pCCMPN_Compania = value
        End Set
    End Property


    Private _pCDVSN_CodDivision As String = ""
    Public Property pCDVSN_CodDivision() As String
        Get
            Return _pCDVSN_CodDivision
        End Get
        Set(ByVal value As String)
            _pCDVSN_CodDivision = value
        End Set
    End Property


    Private _pCPLNDV_CodigoPlanta As Decimal = 0
    Public Property pCPLNDV_CodigoPlanta() As Decimal
        Get
            Return _pCPLNDV_CodigoPlanta
        End Get
        Set(ByVal value As Decimal)
            _pCPLNDV_CodigoPlanta = value
        End Set
    End Property

#End Region
#Region " Procedimientos y Funciones "
    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""
        If Me.txtMotivoRecepcion.Text = "" Then _
            strMensajeError &= "Debe seleccionar un Motivo de Recepción..." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub pGrabarDespacho()
        If Not fblnValidar() Then Exit Sub
        Dim objGuiaSalida As clsGuiaSalida = New clsGuiaSalida
        Dim objGestionBultos As clsDespacho = Nothing
        With objGuiaSalida
            .pCodigoCompania_CCMPN = _pCCMPN_Compania
            .pCodigoDivision_CDVSN = _pCDVSN_CodDivision
            .pCodigoPlanta_CPLNDV = _pCPLNDV_CodigoPlanta
            .pCodigoCliente_CCLNT = intCCLNT
            .pNroControl_NROCTL = intNROCTL
            Integer.TryParse(txtNroTicketBalanza.Text, .pNroTicketBalanza_NTCKPS)
            .pFechaSalidaAlmacen_FSLDAL = dteFechaSalida.Value
            .pMotivoRecepcion_SMTRCP = Me.txtMotivoRecepcion.Tag
            .pSentidoCarga_SSNCRG = Me.txtSentidoCarga.Tag
            .pTipoDespacho_STPDSP = txtDespachoRemision.Tag
            .pObservacionGuiaSalidaLinea01 = Me.txtObservacion01.Text
            .pObservacionGuiaSalidaLinea02 = Me.txtObservacion02.Text
            .pFlagEstadoRegistro_SESTRG = "A"
            Int32.TryParse("" & txtEmpresaTransporte.Tag, .pCodigoTransportista_CTRSPT)
            .pNroPlacaUnidad_NPLCUN = Me.txtPlacaUnidad.Text
            .pNroPlacaAcoplado_NPLCAC = Me.txtPlacaAcoplado.Text
            .pCodigoBreveteTransportista_CBRCNT = Me.txtNroBrevete.Text
        End With
        objGestionBultos = New clsDespacho(objSeguridadBN.pUsuario)
        'Try
        Dim iNroGuiaSalida As Int64 = 0
        If objGestionBultos.fblnGenerarGuiaSalida(objGuiaSalida, iNroGuiaSalida) Then
            MessageBox.Show("El Despacho se generó satisfactoriamente." & vbNewLine & "Nro. Guía : " & iNroGuiaSalida, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If chkRegistrarServicio.CheckState = CheckState.Checked Then
                ' Registro de Servicio
                Dim oServicio As New Servicio_BE
                Me.Cursor = Cursors.WaitCursor
                With oServicio
                    .CCMPN = _pCCMPN_Compania
                    .CDVSN = _pCDVSN_CodDivision
                    .CPLNDV = _pCPLNDV_CodigoPlanta
                    .NOPRCN = 0
                    .CCLNFC = intCCLNT
                    .CCLNT = intCCLNT
                    .NRTFSV = 0
                    .QATNAN = 0
                    .TIPO = "N"
                    .FOPRCN = 0
                    .FECINI = 0
                    .FECFIN = 0
                    .STIPPR = "D"
                    .STPODP = objSeguridadBN.pstrTipoAlmacen
                    .TIPOALM = objSeguridadBN.pstrTipoAlmacen
                    .PSUSUARIO = objSeguridadBN.pUsuario
                    .NRGUSA = iNroGuiaSalida
                End With

                Dim frm As New UcFrmServicioAgregarSA_DS
                frm.oServicio = oServicio
                frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                End If
                ' Fin del Registro de Servicio
            End If
            Me.Close()
            'Else
            '    MessageBox.Show("No se pudo generar la Guía de Salida", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Catch ex As Exception
        '    MessageBox.Show("No se pudo generar la Guía de Salida", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Throw
        'Finally
        '    objGuiaSalida = Nothing
        '    objGestionBultos = Nothing
        'End Try
        objGuiaSalida = Nothing
        objGestionBultos = Nothing
    End Sub

    Private Sub pGrabarParametros()
        Dim dtParameters As DataTable = New DataTable("Parameters")
        Dim rwParameter As DataRow
        'Try
        With dtParameters
            .Columns.Add("STPDSP", System.Type.GetType("System.String"))
            .Columns.Add("DSTPDS", System.Type.GetType("System.String"))
            .Columns.Add("NTCKPS", System.Type.GetType("System.String"))
            .Columns.Add("PTCKPS", System.Type.GetType("System.String"))
            .Columns.Add("OBSE01", System.Type.GetType("System.String"))
            .Columns.Add("OBSE02", System.Type.GetType("System.String"))
            .Columns.Add("CTRSPT", System.Type.GetType("System.String"))
            .Columns.Add("TCMTRT", System.Type.GetType("System.String"))
            .Columns.Add("NPLCUN", System.Type.GetType("System.String"))
            .Columns.Add("NPLCAC", System.Type.GetType("System.String"))
            .Columns.Add("CBRCNT", System.Type.GetType("System.String"))
        End With
        ' Obtenemos el formato de la Fila
        rwParameter = dtParameters.NewRow
        With rwParameter
            .Item("STPDSP") = "" & txtDespachoRemision.Tag
            .Item("DSTPDS") = "" & txtDespachoRemision.Text.Trim
            .Item("NTCKPS") = "" & txtNroTicketBalanza.Text.Trim
            .Item("PTCKPS") = "" & txtPesoTicket.Text.Trim
            .Item("OBSE01") = "" & txtObservacion01.Text.Trim
            .Item("OBSE02") = "" & txtObservacion02.Text.Trim
            .Item("CTRSPT") = "" & txtEmpresaTransporte.Tag
            .Item("TCMTRT") = "" & txtEmpresaTransporte.Text.Trim
            .Item("NPLCUN") = "" & txtPlacaUnidad.Text.Trim
            .Item("NPLCAC") = "" & txtPlacaAcoplado.Text.Trim
            .Item("CBRCNT") = "" & txtNroBrevete.Text.Trim
        End With
        dtParameters.Rows.Add(rwParameter)
        ' Guardamos la función 
        Dim oSaveInfForm As cSaveInfForm = New cSaveInfForm(Application.ProductName, "CrearDespacho.xml")
        oSaveInfForm.pSetParametros(dtParameters)
        oSaveInfForm.Dispose()
        oSaveInfForm = Nothing
        'Catch ex As Exception
        'Finally
        '    dtParameters.Dispose()
        '    dtParameters = Nothing
        'End Try
        dtParameters.Dispose()
        dtParameters = Nothing
    End Sub

    Private Sub pObtenerParametros()
        Dim dtParameters As DataTable = New DataTable("Parameters")
        'Try
        With dtParameters
            .Columns.Add("STPDSP", System.Type.GetType("System.String"))
            .Columns.Add("DSTPDS", System.Type.GetType("System.String"))
            .Columns.Add("NTCKPS", System.Type.GetType("System.String"))
            .Columns.Add("PTCKPS", System.Type.GetType("System.String"))
            .Columns.Add("OBSE01", System.Type.GetType("System.String"))
            .Columns.Add("OBSE02", System.Type.GetType("System.String"))
            .Columns.Add("CTRSPT", System.Type.GetType("System.String"))
            .Columns.Add("TCMTRT", System.Type.GetType("System.String"))
            .Columns.Add("NPLCUN", System.Type.GetType("System.String"))
            .Columns.Add("NPLCAC", System.Type.GetType("System.String"))
            .Columns.Add("CBRCNT", System.Type.GetType("System.String"))
        End With
        Dim oSaveInfForm As cSaveInfForm = New cSaveInfForm(Application.ProductName, "CrearDespacho.xml")
        oSaveInfForm.pGetParametros(dtParameters)
        oSaveInfForm.Dispose()
        oSaveInfForm = Nothing
        ' Valido que exista data
        If dtParameters.Rows.Count = 0 Then Exit Sub
        ' Se carga la información obtenida
        With dtParameters.Rows(0)
            txtDespachoRemision.Text = .Item("DSTPDS")
            txtDespachoRemision.Tag = .Item("STPDSP")
            txtNroTicketBalanza.Text = .Item("NTCKPS")
            txtPesoTicket.Text = .Item("PTCKPS")
            txtObservacion01.Text = .Item("OBSE01")
            txtObservacion02.Text = .Item("OBSE02")
            txtEmpresaTransporte.Text = .Item("TCMTRT")
            txtEmpresaTransporte.Tag = .Item("CTRSPT")
            txtPlacaUnidad.Text = .Item("NPLCUN")
            txtPlacaAcoplado.Text = .Item("NPLCAC")
            txtNroBrevete.Text = .Item("CBRCNT")
        End With
        'Catch ex As Exception
        'Finally
        '    dtParameters.Dispose()
        '    dtParameters = Nothing
        'End Try

        dtParameters.Dispose()
        dtParameters = Nothing

    End Sub
#End Region
#Region " Métodos "
    Private Sub bsaDespachoRemisionListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaDespachoRemisionListar.Click
        Call mfblnBuscar_TipoDespacho(txtDespachoRemision.Tag, txtDespachoRemision.Text)
    End Sub

    Private Sub bsaEmpresaTransporteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporteListar.Click
        Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, "")
    End Sub

    Private Sub bsaPlacaUnidadListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlacaUnidadListar.Click
        Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", "")
        txtPlacaUnidad.Tag = txtPlacaUnidad.Text
        txtPlacaUnidad.Focus()
    End Sub

    Private Sub bsaPlacaAcopladoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlacaAcopladoListar.Click
        Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
    End Sub

    Private Sub bsaNroBreveteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNroBreveteListar.Click
        Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, "", "")
        txtNroBrevete.Tag = txtNroBrevete.Text
    End Sub

    Private Sub bsaNroTicketBalanzaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNroTicketBalanzaListar.Click
        'Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
        Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
        If txtNroTicketBalanza.Text = "" Then txtNroTicketBalanza.Text = "0"
        obeMedioTransporte.PNFBLNIN = HelpClass.CtypeDate(dteFechaSalida.Value)
        obeMedioTransporte.PNNTCKPS = Convert.ToDecimal(txtNroTicketBalanza.Text)
        obeMedioTransporte.PSNPLCCM = IIf(txtPlacaUnidad.Text = "", "*", txtPlacaUnidad.Text)
        obeMedioTransporte.PSNBRVCH = IIf(txtNroBrevete.Text = "", "*", txtNroBrevete.Text)
        Call mfDtblnBuscar_Ticket(obeMedioTransporte, txtNroTicketBalanza.Text, txtPesoTicket.Text, txtPlacaUnidad.Text, txtNroBrevete.Text)
        txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        Try

            'Se valida que la fecha de salida no sea menor que la fecha de recepcion del bulto
            Dim pnFechaSalida As Decimal = HelpClass.CtypeDate(Me.dteFechaSalida.Value)

            If intFechaBultos > pnFechaSalida Then
                MessageBox.Show("La fecha de salida no puede ser menor que la fecha de recepción del bulto", "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            ' Se graban los parámetros 
            Call pGrabarParametros()
            ' Llamada al proceso de generación de la Guía de Despacho
            Call pGrabarDespacho()


            'ddddd()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub frmCrearDespacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objInformacion_PreDespacho As clsInformacion_PreDespacho
        ' Instanciamos la clase que administra la Gestion de Bultos
        Dim objPrimaryKey_PreDespacho As clsPrimaryKey_PreDespacho = New clsPrimaryKey_PreDespacho
        With objPrimaryKey_PreDespacho
            .pintCodigoCliente_CCLNT = intCCLNT
            .pintNroControl_NROCTL = intNROCTL
        End With
        ' Obtenemos la información del Pre-Despacho
        objInformacion_PreDespacho = mfobjInformacion_PreDespacho(objPrimaryKey_PreDespacho)
        With objInformacion_PreDespacho
            txtMotivoRecepcion.Text = .pstrMotivoRecepcionDetalle_SMTRCP
            txtMotivoRecepcion.Tag = .pstrMotivoRecepcion_SMTRCP
            txtSentidoCarga.Text = .pstrSentidoCargaDetalle_SSNCRG
            txtSentidoCarga.Tag = .pstrSentidoCarga_SSNCRG
            dteFechaSalida.Value = Date.Now
        End With
        ' Obtenemos los parametros
        Call pObtenerParametros()
    End Sub

    Private Sub txtEmpresaTransporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, "")
        End If
    End Sub

    Private Sub txtEmpresaTransporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.TextChanged
        txtEmpresaTransporte.Tag = ""
    End Sub

    Private Sub txtEmpresaTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte.Validating
        If txtEmpresaTransporte.Text = "" Then
            txtEmpresaTransporte.Tag = ""
        Else
            If txtEmpresaTransporte.Text <> "" And "" & txtEmpresaTransporte.Tag = "" Then
                Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, "")
                If txtEmpresaTransporte.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtDespachoRemision_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDespachoRemision.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_TipoDespacho(txtDespachoRemision.Tag, txtDespachoRemision.Text)
        End If
    End Sub

    Private Sub txtDespachoRemision_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDespachoRemision.TextChanged
        txtDespachoRemision.Tag = ""
    End Sub

    Private Sub txtDespachoRemision_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDespachoRemision.Validating
        If txtDespachoRemision.Text = "" Then
            txtDespachoRemision.Tag = ""
            Exit Sub
        Else
            If txtDespachoRemision.Text <> "" And "" & txtDespachoRemision.Tag = "" Then
                Call mfblnBuscar_TipoDespacho(txtDespachoRemision.Tag, txtDespachoRemision.Text)
                If txtDespachoRemision.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtNroBrevete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroBrevete.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, "", "")
            txtNroBrevete.Tag = txtNroBrevete.Text
        End If
    End Sub

    Private Sub txtNroBrevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroBrevete.TextChanged
        txtNroBrevete.Tag = ""
    End Sub

    Private Sub txtNroBrevete_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroBrevete.Validating
        If txtNroBrevete.Text = "" Then
            txtNroBrevete.Tag = ""
        Else
            Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtNroBrevete.Text, "", "")
            txtNroBrevete.Tag = txtNroBrevete.Text
            If txtNroBrevete.Text = "" Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtNroTicketBalanza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroTicketBalanza.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
            txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
        End If
    End Sub

    Private Sub txtNroTicketBalanza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroTicketBalanza.TextChanged
        txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
    End Sub

    Private Sub txtNroTicketBalanza_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroTicketBalanza.Validating
        If txtNroTicketBalanza.Text = "0" Or txtNroTicketBalanza.Text = "" Then
            txtPesoTicket.Text = "0.00"
            txtNroTicketBalanza.Tag = ""
        Else
            If txtNroTicketBalanza.Text <> "0" And txtNroTicketBalanza.Text <> "" And "" & txtNroTicketBalanza.Tag = "" Then
                Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
                txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
                If txtNroTicketBalanza.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtPlacaAcoplado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlacaAcoplado.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
        End If
    End Sub

    Private Sub txtPlacaAcoplado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacaAcoplado.TextChanged
        booValidarPlacaAcoplado = False
    End Sub

    Private Sub txtPlacaAcoplado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlacaAcoplado.Validating
        If txtPlacaAcoplado.Text = "" Then
            txtPlacaAcoplado.Tag = ""
        Else
            If Not booValidarPlacaAcoplado Then
                Call pBuscarPlacaAcoplado(txtEmpresaTransporte.Tag, txtPlacaAcoplado.Text, booValidarPlacaAcoplado)
                If txtPlacaAcoplado.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtPlacaUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlacaUnidad.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", "")
        End If
    End Sub

    Private Sub txtPlacaUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacaUnidad.TextChanged
        txtPlacaUnidad.Tag = ""
    End Sub

    Private Sub txtPlacaUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlacaUnidad.Validating
        If txtPlacaUnidad.Text = "" Then
            txtPlacaAcoplado.Text = ""
            txtNroBrevete.Text = ""
        Else
            If txtPlacaUnidad.Text <> "" And "" & txtPlacaUnidad.Tag = "" Then
                Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtPlacaUnidad.Text, txtPlacaAcoplado.Text, txtNroBrevete.Text, "", "", "")
                If txtPlacaUnidad.Text = "" Then
                    txtPlacaAcoplado.Text = ""
                    txtNroBrevete.Text = ""
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
#End Region


    'Private Sub UcMedioTransporte1_ActivarAyuda(ByRef objData As Object) Handles UcTicket.ActivarAyuda
    '    'dtEntidad = clsGeneral.fdtBuscar_TipoBulto(strMensajeError, strData)

    '    Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
    '    Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
    '    With obeMedioTransporte
    '        .PNFBLNIN = HelpClass.CtypeDate(Me.dteFechaSalida.Value)
    '    End With
    '    objData = obrMedioTransporte.ListaTicked(obeMedioTransporte)
    'End Sub


    'Private Sub UcMedioTransporte1_CambioDeTexto1(ByVal strData As String, ByRef objData As Object) Handles UcTicket.CambioDeTexto
    '    If Not strData.Trim.Equals("") Then
    '        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
    '        Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
    '        With obeMedioTransporte
    '            .PNFBLNIN = HelpClass.CtypeDate(Me.dteFechaSalida.Value)
    '            .PSNPLCCM = txtPlacaUnidad.Text
    '            .PSNBRVCH = txtNroBrevete.Text
    '        End With
    '        objData = obrMedioTransporte.ListaTicked(obeMedioTransporte)
    '    End If

    'End Sub

End Class


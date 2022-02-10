Imports Ransa.NEGO

Imports Ransa.TypeDef
Imports RANSA.Utilitario

Public Class frmTrasladoBulto

    Private Sub frmTrasladoBulto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'dteFechaInicial.Value = Now.AddYears(-1)
            CargarPlanta()
            CargarControles()
            CargarUbicacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

#Region "Propiedades"
    Private blnSelect As Boolean = False

    Private _PNCCLNT As Decimal
    ''' <summary>
    ''' CODIGO DE CLIENTE
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _PSCCMPN As String
    ''' <summary>
    ''' CODIGO DE COMPANIA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNCPLNDV As Decimal
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

#End Region

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim obrBulto As New brBulto
            Dim obeFiltro As New beBulto
            With obeFiltro
                .PNCCLNT = _PNCCLNT
                .PSCCMPN = _PSCCMPN
                .PSCDVSN = _PSCDVSN
                .PNCPLNDV = Me.cmbPlanta.SelectedValue
                .PNFECINI = HelpClass.CtypeDate(Me.dteFechaInicial.Value)
                .PNFECFIN = HelpClass.CtypeDate(Me.dteFechaFinal.Value)
                '.PNNGUIRM = Val(Me.txtGuiaRemision.Text)
                .PSNGUIRS = Me.txtGuiaRemision.Text.Trim.ToUpper
                .PNCODTRA = Val(Me.UcTransportista_TxtF011.pCodigoRNS)
                '.PNGUITRA = Val(Me.TxtGuiaTransportista.Text)
                .PSNGUITS = Me.TxtGuiaTransportista.Text.Trim.ToUpper
                .PSCREFFW = Me.txtBulto.Text.Trim
            End With

            If obeFiltro.PSNGUIRS <> "" Or obeFiltro.PSCREFFW <> "" Or obeFiltro.PSNGUITS <> "" Then
                obeFiltro.PNFECINI = 0
                obeFiltro.PNFECFIN = 0
            End If

            dgBultos.AutoGenerateColumns = False
            dgBultos.DataSource = obrBulto.ListarBultoPorPlanta(obeFiltro)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub CargarPlanta()
        Dim obrGeneral As New brGeneral
        cmbPlanta.DataSource = obrGeneral.ListaDePlanta()
        cmbPlanta.DisplayMember = "PSTPLNTA"
        cmbPlanta.ValueMember = "PNCPLNDV"
    End Sub

    Private Sub CargarControles()
        Dim obeTransportista As New RANSA.TYPEDEF.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = _PSCCMPN
        obeTransportista.pUsuario = objSeguridadBN.pUsuario
        Me.UcTransportista_TxtF011.pCargar(obeTransportista)


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        UcAyuda1.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        UcAyuda1.ListColumnas = oListColum
        UcAyuda1.Cargas()
        UcAyuda1.ValueMember = "PSCTPALM"
        UcAyuda1.DispleyMember = "PSTALMC"

    End Sub


    Private Sub UcAyuda1_CambioDeTexto(ByVal objData As Object) Handles UcAyuda1.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = _PNCPLNDV
            UcAyuda2.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            UcAyuda2.DataSource = Nothing
        End If
        UcAyuda2.ListColumnas = oListColum
        UcAyuda2.Cargas()
        UcAyuda2.Limpiar()
        UcAyuda2.ValueMember = "PSCALMC"
        UcAyuda2.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub UcAyuda2_CambioDeTexto(ByVal objData As Object) Handles UcAyuda2.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNALM"
        oColumnas.DataPropertyName = "PSCZNALM"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMZNA"
        oColumnas.DataPropertyName = "PSTCMZNA"
        oColumnas.HeaderText = "Zona Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            UcAyuda3.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            UcAyuda3.DataSource = Nothing
        End If
        UcAyuda3.ListColumnas = oListColum
        UcAyuda3.Cargas()
        UcAyuda3.Limpiar()
        UcAyuda3.ValueMember = "PSCZNALM"
        UcAyuda3.DispleyMember = "PSTCMZNA"
    End Sub

    '#Region "EVENTOS"

    'Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.F4
    '            Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    '        Case Keys.Delete
    '            txtTipoAlmacen.Text = ""
    '    End Select
    'End Sub

    'Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
    '    txtTipoAlmacen.Tag = ""
    '    ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
    '    txtAlmacen.Text = ""
    '    txtZonaAlmacen.Text = ""
    'End Sub

    'Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
    '    Try
    '        If txtTipoAlmacen.Text = "" Then
    '            txtTipoAlmacen.Tag = ""
    '        Else
    '            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
    '                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    '                If txtTipoAlmacen.Text = "" Then
    '                    e.Cancel = True
    '                End If
    '            End If
    '        End If
    '    Catch : End Try

    'End Sub
    'Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
    '    Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    'End Sub

    'Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.F4
    '            Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    '        Case Keys.Delete
    '            txtAlmacen.Text = ""
    '    End Select
    'End Sub

    'Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
    '    txtAlmacen.Tag = ""
    '    ' Si modificamos el Almacén - debe limpiarse la Zona
    '    txtZonaAlmacen.Text = ""
    'End Sub

    'Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
    '    If txtAlmacen.Text = "" Then
    '        txtAlmacen.Tag = ""
    '    Else
    '        If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
    '            Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    '            If txtAlmacen.Text = "" Then
    '                e.Cancel = True
    '            End If
    '        End If
    '    End If
    'End Sub
    'Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
    '    Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    'End Sub

    'Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.F4
    '            Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    '        Case Keys.Delete
    '            txtZonaAlmacen.Text = ""
    '    End Select
    'End Sub

    'Private Sub txtZonaAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
    '    txtZonaAlmacen.Tag = ""
    'End Sub

    'Private Sub txtZonaAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
    '    If txtZonaAlmacen.Text = "" Then
    '        txtZonaAlmacen.Tag = ""
    '    Else
    '        If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
    '            Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    '            If txtZonaAlmacen.Text = "" Then
    '                e.Cancel = True
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
    '    Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    'End Sub
    '#End Region

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            Dim intResult As Integer = 0
            Dim strWarning As String = ""
            Dim strResultado As String = ""
            Me.dgBultos.EndEdit()
            If Not Validar() Then Exit Sub
            Dim obrBulto As New brBulto
            For Each obeBulto As beBulto In Me.dgBultos.DataSource
                If obeBulto.CHECK Then
                    obeBulto.PNPLANDES = _PNCPLNDV
                    'obeBulto.PSCTPALM = Me.txtTipoAlmacen.Tag
                    'obeBulto.PSCALMC = Me.txtAlmacen.Tag
                    'obeBulto.PSCZNALM = Me.txtZonaAlmacen.Tag
                    obeBulto.PSCTPALM = CType(UcAyuda1.Resultado, beAlmacen).PSCTPALM
                    obeBulto.PSCALMC = CType(UcAyuda2.Resultado, beAlmacen).PSCALMC
                    obeBulto.PSCZNALM = CType(UcAyuda3.Resultado, beAlmacen).PSCZNALM
                    'obeBulto.PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
                    obeBulto.PSTUBRFR = CType(txtUbicRef.Resultado, beGeneral).PSTUBRFR
                    obeBulto.FechaIngAlmacenCL = Me.dtpFecINgreso.Value
                    obeBulto.PSUSUARIO = objSeguridadBN.pUsuario
                    intResult = obrBulto.CopyBultoDePlanta(obeBulto)
                    Select Case intResult
                        Case -2
                            strWarning = strWarning & obeBulto.PSCREFFW & " , "
                        Case 0
                            HelpClass.MsgBox("Error Comuníquese con departamento de sistemas")
                            Exit Sub
                        Case 1
                            strResultado = strResultado & obeBulto.PSCREFFW.Trim & ", "
                            obeBulto.PNCPLNDV = _PNCPLNDV
                            EnviarCorreo(obeBulto)
                    End Select
                End If
            Next
            If strWarning.Trim.Length > 0 Then
                HelpClass.MsgBox("Los bultos :" & strWarning & " ya pertenecen a la planta ")
            End If
            If strResultado.Trim.Length > 0 Then
                HelpClass.MsgBox("Los bultos " & strResultado & "se trasladaron de manera correcta")

                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'GuardarBultos()
    End Sub

    ''' <summary>
    ''' Valida que todos los datos requeridos esten llenos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""
        'UcAyuda2
        'If txtTipoAlmacen.Text = "" Then strMensajeError &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
        'If txtAlmacen.Text = "" Then strMensajeError &= "Debe seleccionar un Almacén" & vbNewLine
        'If txtZonaAlmacen.Text = "" Then strMensajeError &= "Debe seleccionar una Zona de Almacén." & vbNewLine

        If UcAyuda1.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
        If UcAyuda2.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Almacén" & vbNewLine
        If UcAyuda3.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar una Zona de Almacén." & vbNewLine

        If txtUbicRef.Resultado Is Nothing Then _
                  strMensajeError &= "Debe ingresar una Ubicación para el Bulto creado..." & vbNewLine
        'If txtUbicacionReferencial.Resultado Is Nothing Then _
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        Return True
    End Function

    ''' <summary>
    ''' Guardar los bultos seleccionados 
    ''' </summary>
    ''' <remarks></remarks>
    'Private Sub GuardarBultos()


    'End Sub

    ''' <summary>
    ''' Envia Correo a Pluspetrol
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <remarks></remarks>
    Private Sub EnviarCorreo(ByVal obeBulto As beBulto)
        If obeBulto.PNCCLNT = 11731 Or obeBulto.PNCCLNT = 30507 Then
            Dim obrBulto As New brBulto
            obrBulto.EnviarCorreoPluspetrol(obeBulto)
        End If
    End Sub
     
     
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgBultos_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgBultos.ColumnHeaderMouseClick
        Try
            dgBultos.EndEdit()
            If dgBultos.Columns(e.ColumnIndex).Name = "CHECK" Then
                For Each row As DataGridViewRow In dgBultos.Rows
                    row.Cells("CHECK").Value = IIf(blnSelect, False, True)
                Next
                blnSelect = IIf(blnSelect, False, True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Function Llenar_Combo_Origen()
    '    Dim olbeZonas As New List(Of beBulto)
    '    Dim obeZonas As New beBulto
    '    Dim intCont As Integer
    '    Dim intRow As Integer
    '    Dim intExiste As Integer = 1
    '    If Me.dgBultos.DataSource.Count > 0 Then
    '        obeZonas = New beBulto
    '        obeZonas.PSCZNALM = ""
    '        obeZonas.psCZNALM_DES = "TODOS"
    '        olbeZonas.Add(obeZonas)
    '    End If
    '    For intRow = dgBultos.DataSource.Count - 1 To 0 Step -1
    '        For intCont = 0 To objLisResulOrdenServicioTransporteBE.Count - 1
    '            If objLisResulOrdenServicioTransporteBE.Item(intCont).PNTORG.Trim = objListOrdenServicioTransporteBE.Item(intRow).PNTORG.Trim Then

    '                intExiste = 0
    '                Exit For
    '            Else
    '                intExiste = 1
    '            End If
    '        Next
    '        If intExiste = 1 Then
    '            If objListOrdenServicioTransporteBE.Item(intRow).PNTORG.Trim <> 0 Then
    '                objLisResulOrdenServicioTransporteBE.Add(objListOrdenServicioTransporteBE.Item(intRow))
    '            End If
    '        End If
    '    Next
    '    Return objLisResulOrdenServicioTransporteBE
    '    tsMenuOpciones.cm()
    'End Function


    Private Sub CargarUbicacion()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        Dim objNegocio As New brUbicacionesXCliente

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR_1"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación "
        oColumnas.Visible = False
        oListColum.Add(2, oColumnas)
        'txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(_PNCCLNT)
        'txtUbicacionReferencial.ListColumnas = oListColum
        'txtUbicacionReferencial.Cargas()
        'txtUbicacionReferencial.Limpiar()
        'txtUbicacionReferencial.ValueMember = "PSTUBRFR"
        'txtUbicacionReferencial.DispleyMember = "PSTUBRFR"
        txtUbicRef.DataSource = objNegocio.folistUbicacionXCliente(_PNCCLNT)
        txtUbicRef.ListColumnas = oListColum
        txtUbicRef.Cargas()
        txtUbicRef.Limpiar()
        txtUbicRef.ValueMember = "PSTUBRFR"
        txtUbicRef.DispleyMember = "PSTUBRFR"
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim obrBulto As New brBulto
            Dim obeFiltro As New beBulto
            With obeFiltro
                .PNCCLNT = _PNCCLNT
                .PSCCMPN = _PSCCMPN
                .PSCDVSN = _PSCDVSN
                .PNCPLNDV = Me.cmbPlanta.SelectedValue
                .PNFECINI = HelpClass.CtypeDate(Me.dteFechaInicial.Value)
                .PNFECFIN = HelpClass.CtypeDate(Me.dteFechaFinal.Value)
                '.PNNGUIRM = Val(Me.txtGuiaRemision.Text)
                .PSNGUIRS = Me.txtGuiaRemision.Text.Trim.ToUpper
                .PNCODTRA = Val(Me.UcTransportista_TxtF011.pCodigoRNS)
                '.PNGUITRA = Val(Me.TxtGuiaTransportista.Text)
                .PSNGUITS = Me.TxtGuiaTransportista.Text.Trim.ToUpper
                '.PSCREFFW = Me.txtBulto.Text.Trim
                .PSCREFFW = Me.txtBulto.Text.Trim
            End With

            If obeFiltro.PSNGUIRS <> "" Or obeFiltro.PSCREFFW <> "" Or obeFiltro.PSNGUITS <> "" Then
                obeFiltro.PNFECINI = 0
                obeFiltro.PNFECFIN = 0
            End If

            dgBultos.AutoGenerateColumns = False
            Dim oList As New List(Of beBulto)
            oList = obrBulto.ListarBultoPorPlanta(obeFiltro)
            dgBultos.DataSource = oList

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
End Class

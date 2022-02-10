Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmAsignarGuia

  Private _PLANTA As String = ""
  Private _COMPANIA As String = ""
  Private _CLIENTE As Int32 = 0
  Private _COD_TRANSPORTISTA As Int32 = 0
  Private _GUIA_TRANSPORTISTA As Int64 = 0
  Private _USUARIO As String = ""
  Private _TIPO_VIAJE As Int16 = 0
    'Private _objTable As DataTable
  Private _NOPRCN As Int64 = 0
    Private Objeto_Entidad_Guia As GuiaTransportista
    Public pDialogOK As Boolean = False

  Public Property Guia_Transporte() As GuiaTransportista
    Get
      Return Objeto_Entidad_Guia
    End Get
    Set(ByVal value As GuiaTransportista)
      Objeto_Entidad_Guia = value
    End Set
  End Property

  Public WriteOnly Property Operacion() As Int64
    Set(ByVal value As Int64)
      _NOPRCN = value
    End Set
  End Property

    'Public WriteOnly Property objTable() As DataTable
    '  Set(ByVal value As DataTable)
    '    _objTable = value
    '  End Set
    'End Property

  Public WriteOnly Property TIPO_VIAJE() As Int16
    Set(ByVal value As Int16)
      _TIPO_VIAJE = value
    End Set
  End Property

  Public WriteOnly Property GUIA_TRANSPORTISTA() As Int64
    Set(ByVal value As Int64)
      _GUIA_TRANSPORTISTA = value
    End Set
  End Property

  Public WriteOnly Property COD_TRANSPORTISTA() As Int32
    Set(ByVal value As Int32)
      _COD_TRANSPORTISTA = value
    End Set
  End Property

  Public WriteOnly Property CLIENTE() As Int32
    Set(ByVal value As Int32)
      _CLIENTE = value
    End Set
  End Property

  Public WriteOnly Property PLANTA() As String
    Set(ByVal value As String)
      _PLANTA = value
    End Set
  End Property

  Public WriteOnly Property COMPANIA() As String
    Set(ByVal value As String)
      _COMPANIA = value
    End Set
  End Property

  Public WriteOnly Property USUARIO() As String
    Set(ByVal value As String)
      _USUARIO = value
    End Set
  End Property

    Private Sub frmAsignarGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim dt_tipoGR As New DataTable
            'Dim objAyuda As New Ransa.Controls.TipoAyuda.TipoAyuda_DAL
            'dt_tipoGR = objAyuda.fdtListar_TablaAyuda_L01("TPOGRT", "")
            dt_tipoGR.Columns.Add("CCMPRN")
            dt_tipoGR.Columns.Add("TDSDES")
            Dim dr As DataRow
            dr = dt_tipoGR.NewRow
            dr("CCMPRN") = "F"
            dr("TDSDES") = "FISICO"
            dt_tipoGR.Rows.Add(dr)

            dr = dt_tipoGR.NewRow
            dr("CCMPRN") = "E"
            dr("TDSDES") = "ELECTRONICO"
            dt_tipoGR.Rows.Add(dr)

            cboTipoGR.DataSource = dt_tipoGR
            cboTipoGR.DisplayMember = "TDSDES"
            cboTipoGR.ValueMember = "CCMPRN"
            cboTipoGR.SelectedValue = "F"

            cboTipoGR_SelectionChangeCommitted(cboTipoGR, Nothing)
            'cboTipoGR.Enabled = False


            Me.UcCliente.CCMPN = _COMPANIA
            Me.UcCliente.pCargar(_CLIENTE)
            If _TIPO_VIAJE = 0 Then
                Me.btnBuscaOrdenServicio.Visible = False
                Me.txtOperacion.Visible = False
                Me.lblOperacion.Visible = False
                Me.txtOperacion.Text = Me._NOPRCN
            End If

            txtNroRemision.Select(0, 0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Try
            pDialogOK = True
            Dim msg_alerta As String = ""

            If Me.UcCliente.pCodigo = 0 Then
                msg_alerta = "Ingresar cliente"
            End If

            If msg_alerta.Length > 0 Then
                MessageBox.Show(msg_alerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim Guia As String = txtNroRemision.Text.Trim
            If Guia.Contains(" ") Then
                MessageBox.Show("- Guía no puede tener espacios en blanco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If



            If Me.txtNroRemision.Text.Trim.Equals("") = True Then
                Exit Sub
            End If

            'Dim TipoGR As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
            'If TipoGR = "E" Then
            '    If txtNroRemision.Text.Trim.Length < 12 Then
            '        MessageBox.Show("Completar la guía electrónica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            'End If

       
            'Dim strError As String = "DEBE INGRESAR: " & Chr(13)
            'If Me.UcCliente.pCodigo = 0 Then
            '    strError += "* CLIENTE" & Chr(13)
            '    End If
            '    'txtNroRemision
            '    'If Me.txtGuiaCliente.Text.Equals("") = True Then
            '    '    strError += "* GUIA REMISION CLIENTE" & Chr(13)
            '    'End If
            '    If Me.txtNroRemision.Text.Equals("") = True Then
            '        strError += "* GUIA REMISION CLIENTE" & Chr(13)
            '    End If
            'If strError.Trim.Length > 17 Then
            '    HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
        If Me._TIPO_VIAJE = 1 Then
            If Me.txtOperacion.Text.Trim = "" Then
                HelpClass.MsgBox("* OPERACION", MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
            'Try
            Dim obj_Logica As New GuiaTransportista_BLL
            Dim obj_EntidadGuia As New GuiaTransportista
            'Dim obj_Table As DataTable
            'Llenando los datos de la guia de Anexo
            obj_EntidadGuia.CTRMNC = Me._COD_TRANSPORTISTA
            obj_EntidadGuia.NGUIRM = Me._GUIA_TRANSPORTISTA
            'txtNroRemision
            'obj_EntidadGuia.NRGUCL = Me.txtGuiaCliente.Text.Trim.ToUpper
            'obj_EntidadGuia.NRGUCL = Me.txtNroRemision.Text.Trim.ToUpper
            obj_EntidadGuia.NGUIRS = Me.txtNroRemision.Text.Trim.ToUpper

            obj_EntidadGuia.FCGUCL = CType(HelpClass.CtypeDate(Me.dtpFechaGuia.Value), Double)
            obj_EntidadGuia.CCLNT = Me.UcCliente.pCodigo
            obj_EntidadGuia.CPRVCL = 0
            'obj_EntidadGuia.FULTAC = HelpClass.TodayNumeric
            'obj_EntidadGuia.HULTAC = HelpClass.NowNumeric
            obj_EntidadGuia.CULUSA = Me._USUARIO
            obj_EntidadGuia.NTRMNL = ""
            obj_EntidadGuia.NRSERI = 0
            obj_EntidadGuia.NPRGUI = 0
            obj_EntidadGuia.CCMPN = Me._COMPANIA
            obj_EntidadGuia.PSOVOL = IIf(IsNumeric(Me.txtPesoVolumen.Text) = False, 0, Me.txtPesoVolumen.Text)

            obj_EntidadGuia.CDVSN = "R"
            obj_EntidadGuia.CPLNDV = Me._PLANTA
            ' comentado busqueda 201911
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'obj_Table = New DataTable
            'obj_Table = obj_Logica.Lista_Guia_Salida_Zona_GR(obj_EntidadGuia)
            'Select Case obj_Table.Rows.Count
            '    Case 0
            '        obj_EntidadGuia.NRGUSA = 0
            '    Case Is > 1
            '        frmMovimiento = New frmMovimiento
            '        With frmMovimiento
            '            .Tabla = obj_Table
            '            .ShowDialog()
            '            obj_EntidadGuia.NRGUSA = .Guia_Salida
            '        End With
            '    Case Else
            '        obj_EntidadGuia.NRGUSA = obj_Table.Rows(0).Item("NRGUSA")
            'End Select
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            obj_EntidadGuia.NRGUSA = 0  'por lo comentado en  ' comentado busqueda 201911
            obj_EntidadGuia.NOPRCN = Me.txtOperacion.Text

            obj_EntidadGuia.CTPCRG = "GM"
            obj_EntidadGuia.CTDGRM = ("" & cboTipoGR.SelectedValue).ToString.Trim


            'If obj_EntidadGuia.NRGUSA = 0 Then Exit Sub
            'Proceso de registro
            'Dim objEntidad As GuiaTransportista = obj_Logica.Registrar_GuiasCliente_Manual(obj_EntidadGuia)
            Dim msgregistro As String = ""
            msgregistro = obj_Logica.Registrar_GuiasCliente_Manual_Salm(obj_EntidadGuia)
            If msgregistro.Length > 0 Then
                MessageBox.Show(msgregistro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                'If objEntidad.NRGUCL = -1 Then
                '    HelpClass.MsgBox("Guía Remisión registrada en otra Guía de Transporte" & Chr(13) & Chr(13) & "Código Transportista : " & objEntidad.CTRMNC & Chr(13) & "Guía Transporte: " & objEntidad.NGUIRM, MessageBoxIcon.Information)
                '    Exit Sub
                'Else
                '--PENDIENTE DE IMPLEMENTAR
                'Dim objHash As New Hashtable
                'objHash.Add("NOPRCN", obj_EntidadGuia.NOPRCN)
                'objHash.Add("NGUIRM", obj_EntidadGuia.NRGUCL)
                'objHash.Add("FGUIRM", CType(HelpClass.CtypeDate(Me.dtpFechaGuia.Value), Double))
                'Me.Generar_Carga_Guia_Transporte(objHash)
                MessageBox.Show("El Proceso culminó Satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Me.Listar_Guias_Cliente_Registradas()
            'LIMPIANDO CONTROLES
            'Me.UcCliente.pClear()
            txtNroRemision.Text = ""
            txtNroRemision.Select(0, 0)
            'txtGuiaCliente.Text = ""
            Me.txtPesoVolumen.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtGuiaCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click

        Try
            Dim frmListaoperacion As New frmConsultaOperacion
            With frmListaoperacion
                '.Tabla = Me._objTable.Copy
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Me.txtOperacion.Text = .Operacion
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

  Private Sub Generar_Carga_Guia_Transporte(ByVal objHash As Hashtable)
    Dim Objeto_Logica As New GuiaTransportista_BLL
    Dim sGuiaPrincipal As Int64 = 0
    Dim oHash As New Hashtable
    Dim intEstatus As Int16 = 0
    Dim dFechaGuiaPrincipal As Date = Date.Now
    Dim sRelacionGuiasSeleccionada As String = ""
    Dim intCMRCDR As Integer = 0
    Dim strTCMRCD As String = ""

    oHash.Add("NOPRCN", objHash("NOPRCN"))
    oHash.Add("NGUIRM", objHash("NGUIRM"))
    oHash.Add("CCMPN", Me._COMPANIA)

    intEstatus = Objeto_Logica.Validar_Operacion_Guia_Remision(oHash, intCMRCDR, strTCMRCD)

    If intEstatus = 0 Then

      'LLENANDO EL dtgGuiasPendientes  
      sGuiaPrincipal = objHash("NGUIRM")
      dFechaGuiaPrincipal = objHash("FGUIRM")

      Dim oTemp As New TD_Obj_InfGRemCargada
      With oTemp
        .pCTRMNC_CodigoTransportista = Objeto_Entidad_Guia.CTRMNC
        .pNGUIRM_NroGuiaTransportista = Objeto_Entidad_Guia.NGUIRM
        .pNGUITR_GuiaRemisionCargada = sGuiaPrincipal
        .pFGUITR_FechaGuiaRemision = dFechaGuiaPrincipal
        .pRELGUI_RelacionGuiaHijas = sRelacionGuiasSeleccionada
        .pCCLNT1_CodigoCliente = Me._CLIENTE 'Objeto_Entidad_Guia.CCLNT
        .pCLCLOR_CodigoLocalidadOrigen = Objeto_Entidad_Guia.CLCLOR
        .pTCMLCO_LocalidadOrigen = Objeto_Entidad_Guia.TCMLCO
        .pCLCLDS_CodigoLocalidadDestino = Objeto_Entidad_Guia.CLCLDS
        .pTCMLCD_LocalidadDestino = Objeto_Entidad_Guia.TCMLCD
        .pNOPRCN_NroOperacion = Objeto_Entidad_Guia.NOPRCN
        .pNLQDCN_NroLiquidacion = 0
        .pCTRSPT_Transportista = Objeto_Entidad_Guia.CTRSPT
        .pTCMTRT_RazSocialTransportista = Objeto_Entidad_Guia.TCMTRT ' Me.cboTransportista.pRazonSocial
        .pNPLVHT_Tracto = Objeto_Entidad_Guia.NPLCTR
        .pCBRCNT_Brevete = Objeto_Entidad_Guia.CBRCNT
        .pCMRCDR_Mercaderia = intCMRCDR 'Objeto_Entidad_Guia.CMRCDR Me.gwdSolicitud.Item("D_CMRCDR", int_Indice).Value
        .pTAMRCD_DetalleMercaderia = strTCMRCD 'Objeto_Entidad_Guia.TCMRCD Me.gwdSolicitud.Item("D_TCMRCD", int_Indice).Value
        .pFRCGRM_FechaRecepGuiaRemision = Now
        .pQGLGSL_CantidadGlsGasolina = Objeto_Entidad_Guia.QGLGSL
        .pQGLDSL_CantidadGlsDiesel = Objeto_Entidad_Guia.QGLDSL
        .pNRHJCR_NroHojasCargui = Objeto_Entidad_Guia.NRHJCR
        .pCPRCN1_CodigoPropietarioContenedor1 = ""
        .pNSRCN1_SerieContenedor1 = ""
        .pCPRCN2_CodigoPropietarioContenedor2 = ""
        .pNSRCN2_SerieContenedor2 = ""
        .pFLLGCM_FechaLlegadaCamion = Now
        .pFSLDCM_FechaSalidaCamion = Now
        .pQKLMRC_KilometrosRecorridos = Objeto_Entidad_Guia.QKMREC
        .pQHRSRV_CantidadHorasServicio = 0
        .pQBLRMS_CantidadBultosRemision = Objeto_Entidad_Guia.QMRCMC
        .pPBRTOR_PesoBrutoRemision = IIf(Objeto_Entidad_Guia.QPSOBR = 0, Objeto_Entidad_Guia.PMRCMC, Objeto_Entidad_Guia.QPSOBR)
        If Objeto_Entidad_Guia.QPSOBR <> 0 And Objeto_Entidad_Guia.PMRCMC <> 0 Then
          .pPTRAOR_PesoTaraRemision = Objeto_Entidad_Guia.QPSOBR - Objeto_Entidad_Guia.PMRCMC
          .pPTRDST_PesoTaraRecepcion = Objeto_Entidad_Guia.QPSOBR - Objeto_Entidad_Guia.PMRCMC
        Else
          .pPTRAOR_PesoTaraRemision = 0
          .pPTRDST_PesoTaraRecepcion = 0
        End If
        .pQVLMOR_VolumenRemision = Objeto_Entidad_Guia.QVLMOR
        .pQBLRCP_CantidadBultosRecepcion = Objeto_Entidad_Guia.QMRCMC
        .pPBRDST_PesoBrutoRecepcion = .pPBRTOR_PesoBrutoRemision
        .pQVLMDS_VolumenRecepcion = Objeto_Entidad_Guia.QVLMOR
        .pMMCUSR_Usuario = Me._USUARIO
                .pNTRMNL_Terminal = ""
        .pCCMPN_Compania = Me._COMPANIA
      End With

      Dim bResultado As Boolean = True
      Dim sErrorMesage As String = ""
      Dim resultado As Int32 = 0
      bResultado = Objeto_Logica.Registrar_GuiaRemisionLiqTransp(oTemp, sErrorMesage)
      If Not bResultado Or sErrorMesage <> "" Then
        MessageBox.Show(sErrorMesage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
      End If

    End If

  End Sub

  Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoVolumen.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then
      e.Handled = True
      If (e.KeyChar = ".") And (0 = InStr(sender.Text, ".", CompareMethod.Binary)) Then e.Handled = False
    End If
  End Sub

    Private Sub cboTipoGR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoGR.SelectionChangeCommitted
        Try
            txtNroRemision.Text = ""
          
            Dim tipo As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
            Select Case tipo
                Case "F"
                    txtNroRemision.Mask = "##########"
                    
                Case "E"
                    'txtNroRemision.Mask = "LAAA-00000000" ' Primera caracter : Letra / 3 caracteres alfanumerico/ 8 numericos
                    txtNroRemision.Mask = "LAAA-99999999"
            End Select
            txtNroRemision.Select(0, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txtNroRemision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroRemision.KeyPress
        Try
            e.KeyChar = Char.ToUpper(e.KeyChar)

            If Asc(e.KeyChar) = Keys.Enter Then
                btnProcesar_Click(btnProcesar, Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
      
    End Sub

    'Private Sub txtNroRemision_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNroRemision.KeyUp
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            btnProcesar_Click(btnProcesar, Nothing)

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try
    'End Sub
End Class

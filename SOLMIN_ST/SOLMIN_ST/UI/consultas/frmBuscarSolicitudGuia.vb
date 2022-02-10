Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones


Public Class frmBuscarSolicitudGuia

#Region "Atributos"
  Public pobjGuiaBE As GuiaTransportista
  Private _NCSOTR_1 As Double = 0
  Private _NCRRSR_1 As Double = 0
  Private _CCMPN_1 As String = ""
  Private _CDVSN_1 As String = ""
  Private _CPLNDV_1 As Int32 = 0
  Private _NGSGWP_1 As String = ""
  Private _NCOREG_1 As Double = 0
  Private _CTPOCR As Int32 = 0
  Private objTable As DataTable
    Private _intIndice As Int32 = 0
    Private _ListaConfWap As New List(Of TipoDatoGeneral)
    Private _PlantaDesc As String = ""
    Public pDialogOK As Boolean = False
#End Region

#Region "Propiedades"

  Public Property NCSOTR_1() As Double
    Get
      Return _NCSOTR_1
    End Get
    Set(ByVal value As Double)
      _NCSOTR_1 = value
    End Set
  End Property

  Public Property NCRRSR_1() As Double
    Get
      Return _NCRRSR_1
    End Get
    Set(ByVal value As Double)
      _NCRRSR_1 = value
    End Set
  End Property

  Public Property NGSGWP_1() As String
    Get
      Return _NGSGWP_1
    End Get
    Set(ByVal value As String)
      _NGSGWP_1 = value
    End Set
  End Property

  Public Property NCOREG_1() As Double
    Get
      Return _NCOREG_1
    End Get
    Set(ByVal value As Double)
      _NCOREG_1 = value
    End Set
  End Property

  Public WriteOnly Property CCMPN_1() As String
    Set(ByVal value As String)
      _CCMPN_1 = value
    End Set
  End Property

  Public WriteOnly Property CDVSN_1() As String
    Set(ByVal value As String)
      _CDVSN_1 = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV_1() As Int32
    Set(ByVal value As Int32)
      _CPLNDV_1 = value
    End Set
  End Property

  Public WriteOnly Property CTPOCR() As Int32
    Set(ByVal value As Int32)
      _CTPOCR = value
    End Set
    End Property

    Public WriteOnly Property PlantaDesc() As String
        Set(ByVal value As String)
            _PlantaDesc = value
        End Set
    End Property

#End Region

#Region "Eventos"

  Private Sub frmBuscarSolicitudGuia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            dtgSolicitudGuia.AutoGenerateColumns = False
            'Me.Alinear_Columnas_Grilla()
            If _CTPOCR <> 0 Then
                Me.chkTipoGuia.Visible = False
            End If

            Me.CargarTransportista()
            Me.txtCliente.pUsuario = USUARIO
            Me.txtCliente.CCMPN = _CCMPN_1

            Dim oTipoGeneralBLL As New TipoDatoGeneral_BLL
            _ListaConfWap = oTipoGeneralBLL.Lista_Tipo_Dato_General(_CCMPN_1, "FLGWAP")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    

  End Sub

  Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Try
            Me.Lista_Solicitud_Guia()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub dtgSolicitudGuia_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSolicitudGuia.CellClick
    Try
      If e.RowIndex < 0 Then Exit Sub
      Me.dtgSolicitudGuia.EndEdit()
            Dim colName As String = dtgSolicitudGuia.Columns(e.ColumnIndex).Name


            Select Case colName
                Case "SEL"
                    If Me.dtgSolicitudGuia.Item("NGUITR", e.RowIndex).Value <> 0 Then
                        Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = False
                    Else
                        Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = IIf(Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = True, False, Verificar_Registro(e.RowIndex)) 'Not Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value
                    End If
                    'Case "GPSLAT"
                    '    If Me.dtgSolicitudGuia.Item("NCSOTR", Me.dtgSolicitudGuia.CurrentCellAddress.Y).Value.ToString <> "" Then
                    '        Dim objGpsBrowser As New frmMapa
                    '        With objGpsBrowser
                    '            .Latitud = Me.dtgSolicitudGuia.Item("GPSLAT", e.RowIndex).Value
                    '            .Longitud = Me.dtgSolicitudGuia.Item("GPSLON", e.RowIndex).Value
                    '            .Fecha = Me.dtgSolicitudGuia.Item("FECGPS", e.RowIndex).Value
                    '            .Hora = dtgSolicitudGuia.Item("HORGPS", e.RowIndex).Value
                    '            .WindowState = FormWindowState.Maximized
                    '            .ShowForm(.Latitud, .Longitud, Me)
                    '        End With
                    '    End If
            End Select

            'Select Case e.ColumnIndex
            '  Case 0
            '    If Me.dtgSolicitudGuia.Item("NGUITR", e.RowIndex).Value <> 0 Then
            '      Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = False
            '    Else
            '      Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = IIf(Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = True, False, Verificar_Registro(e.RowIndex)) 'Not Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value
            '    End If
            '  Case 20
            '    If Me.dtgSolicitudGuia.Item(0, Me.dtgSolicitudGuia.CurrentCellAddress.Y).Value.ToString <> "" Then
            '      Dim objGpsBrowser As New frmMapa
            '      With objGpsBrowser
            '        .Latitud = Me.dtgSolicitudGuia.Item(19, e.RowIndex).Value
            '        .Longitud = Me.dtgSolicitudGuia.Item(20, e.RowIndex).Value
            '        .Fecha = Me.dtgSolicitudGuia.Item(21, e.RowIndex).Value
            '        .Hora = dtgSolicitudGuia.Item(22, e.RowIndex).Value
            '        .WindowState = FormWindowState.Maximized
            '        .ShowForm(.Latitud, .Longitud, Me)
            '      End With
            '    End If
            'End Select
      Me._intIndice = e.RowIndex
            'Catch : End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

  End Sub

    Private Sub txtNroSolicitud_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroSolicitud.KeyPress, txtNroOperacion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

  Private Sub dtgSolicitudGuia_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSolicitudGuia.CellDoubleClick
    Try
      If e.RowIndex < 0 Then Exit Sub
      Dim hash As New Hashtable()
      hash("CCMPN") = Me.dtgSolicitudGuia.Rows(e.RowIndex).Cells("CCMPN").Value.ToString()
            Me.dtgSolicitudGuia.EndEdit()
            Dim colName As String = dtgSolicitudGuia.Columns(e.ColumnIndex).Name

            Select Case colName
                Case "SEL"
                    If Me.dtgSolicitudGuia.Item("NGUITR", e.RowIndex).Value <> 0 Then
                        Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = False
                    Else
                        'Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = Not Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value
                        Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = IIf(Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = True, False, Verificar_Registro(e.RowIndex)) 'Not Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value
                    End If
                Case "NPLCUN"

                    Informacion_Detallada_Transportista(1, Me.dtgSolicitudGuia.Item(e.ColumnIndex, e.RowIndex).Value, hash)
                Case "NPLCAC"
                    Informacion_Detallada_Transportista(2, Me.dtgSolicitudGuia.Item(e.ColumnIndex, e.RowIndex).Value, hash)
                Case "CBRCNT"
                    Informacion_Detallada_Transportista(3, Me.dtgSolicitudGuia.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            End Select


            'Select Case e.ColumnIndex
            '  Case 0
            '    If Me.dtgSolicitudGuia.Item("NGUITR", e.RowIndex).Value <> 0 Then
            '      Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = False
            '    Else
            '      'Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = Not Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value
            '      Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = IIf(Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value = True, False, Verificar_Registro(e.RowIndex)) 'Not Me.dtgSolicitudGuia.Item("SEL", e.RowIndex).Value
            '    End If
            '  Case 8
            '    Informacion_Detallada_Transportista(1, Me.dtgSolicitudGuia.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            '  Case 9
            '    Informacion_Detallada_Transportista(2, Me.dtgSolicitudGuia.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            '  Case 10
            '    Informacion_Detallada_Transportista(3, Me.dtgSolicitudGuia.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            'End Select
      Me._intIndice = e.RowIndex
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


  End Sub

    'Private Sub dtgSolicitudGuia_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgSolicitudGuia.DataBindingComplete
    '  Try
    '    If Me.dtgSolicitudGuia.Rows.Count > 0 Then
    '      Me.dtgSolicitudGuia.CurrentRow.Selected = False
    '    End If
    '      Catch ex As Exception
    '          MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '      End Try

    'End Sub

  Private Sub btnGenerarGuiaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarGuiaTransporte.Click

        pDialogOK = True
        Dim strMensaje As String = ""
    If Validar_Tipo_Guia(strMensaje) <> "" Then
      HelpClass.MsgBox(strMensaje, MessageBoxIcon.Information)
      Exit Sub
    End If
    Me.dtgSolicitudGuia.CommitEdit(DataGridViewDataErrorContexts.Commit)
    'Dim lint_Indice As Integer = Me.dtgSolicitudGuia.CurrentCellAddress.Y
    Dim frm_GuiaTransportista As New frmGuiaTransportista
    Dim obj_Logica_Guia As New GuiaTransportista_BLL
    Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
    Dim obj_Entidad_Guia As New GuiaTransportista

    If Me.chkTipoGuia.Checked = False Then
      If Me.dtgSolicitudGuia.Item("NGUITR", Me._intIndice).Value = 0 Then
        Me.Tag = 0
      Else
        HelpClass.MsgBox("Ya tiene Guía de Transporte", MessageBoxIcon.Information)
        Exit Sub
      End If
    Else
      Me._intIndice = Indice_Consolidado()
      Me.Tag = 2
    End If
    Me._NCSOTR_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCSOTR").Value
    Me._NCRRSR_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCRRSR").Value
        'Me._NGSGWP_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NGSGWP").Value
        'Me._NCOREG_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCOREG").Value
    Me.Obtener_Datos_Grilla_Normal(Me._intIndice)

    Select Case _CTPOCR
      Case 0
        Me.Guia_Transportista_Carga()
      Case 1
        Me.Guia_Transportista_Pasajero()
        End Select
        pDialogOK = True
        ' Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnAgregarGuiaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGuiaTransporte.Click
    If Me.dtgSolicitudGuia.RowCount = 0 Then Exit Sub
    If Me.dtgSolicitudGuia.CurrentRow.Selected = False Then Exit Sub
    Dim strMensaje As String = ""
    If Validar_Tipo_Guia(strMensaje) <> "" Then
      HelpClass.MsgBox(strMensaje, MessageBoxIcon.Information)
      Exit Sub
    End If
    Me.dtgSolicitudGuia.CommitEdit(DataGridViewDataErrorContexts.Commit)
    'Dim lint_Indice As Integer = Me.dtgSolicitudGuia.CurrentCellAddress.Y
    If Me.dtgSolicitudGuia.Item("NGUITR", Me._intIndice).Value = 0 Then
      HelpClass.MsgBox("No tiene Guía de Transporte Generado; No puede agregarse G. T. ", MessageBoxIcon.Information)
      Exit Sub
    Else
      Me.Tag = 2
    End If
        Me.Obtener_Datos_Grilla_Normal(Me._intIndice)

    Me._NCSOTR_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCSOTR").Value
    Me._NCRRSR_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCRRSR").Value
        'Me._NGSGWP_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NGSGWP").Value
        'Me._NCOREG_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCOREG").Value
    Select Case _CTPOCR
      Case 0
        Me.Guia_Transportista_Carga()
      Case 1
        Me.Guia_Transportista_Pasajero()
        End Select
        pDialogOK = True
        'Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnAceptarLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarLiquidacion.Click
    If Me.dtgSolicitudGuia.RowCount = 0 Then Exit Sub
    If Me.dtgSolicitudGuia.CurrentRow.Selected = False Then Exit Sub
    'Dim lint_Indice As Integer = Me.dtgSolicitudGuia.CurrentCellAddress.Y
    Me.Obtener_Datos_Grilla_Normal(Me._intIndice)
    _NCSOTR_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCSOTR").Value
    _NCRRSR_1 = Me.dtgSolicitudGuia.Rows(Me._intIndice).Cells("NCRRSR").Value
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub chkTipoGuia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTipoGuia.CheckedChanged
    Me.dtgSolicitudGuia.Columns("SEL").Visible = Me.chkTipoGuia.Checked
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub CargarTransportista()
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    obeTransportista.pCCMPN_Compania = Me._CCMPN_1
    Me.cboTransportista.pCargar(obeTransportista)
  End Sub

  'Private Sub Carga_MedioTransporte()
  '  Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
  '  Me.cboMedioTransporte.DataSource = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me._CCMPN_1)
  '  Me.cboMedioTransporte.ValueMember = "CMEDTR"
  '  Me.cboMedioTransporte.DisplayMember = "TNMMDT"
  'End Sub

  Private Function Validar_Tipo_Guia(ByRef strMensaje As String) As String
    Dim intContador As Int32 = 0
    Dim objRow As DataRow
    objTable = New DataTable
    Me.Generar_Columna_Table()
    Me.dtgSolicitudGuia.EndEdit()
    Select Case Me.chkTipoGuia.Checked
      Case True
        With Me.dtgSolicitudGuia
          For intCount As Int32 = 0 To .RowCount - 1
            If .Item("SEL", intCount).Value = True Then
              objRow = objTable.NewRow
              objRow("TCMPCL") = .Item("CCLNT", intCount).Value
              objRow("NOPRCN") = .Item("NOPRCN", intCount).Value
              objRow("CCMPN") = Me._CCMPN_1
              objTable.Rows.Add(objRow)
              intContador += 1
            End If

          Next
          If intContador < 2 Then strMensaje = "Seleccione 2 a más registro"
        End With

      Case False
        If Me.dtgSolicitudGuia.RowCount = 0 Then strMensaje = "Seleccione un registro"
    End Select

    Return strMensaje
  End Function

  Private Function Indice_Consolidado() As Int32
    Dim intIndiceMuestra As Int32 = -1
    For lintIndice As Int32 = 0 To Me.dtgSolicitudGuia.RowCount - 1
      If Me.dtgSolicitudGuia.Item("SEL", lintIndice).Value = True Then
        intIndiceMuestra = lintIndice
        Exit For
      End If
    Next
    Return intIndiceMuestra

  End Function

  Private Function Verificar_Registro(ByVal intRegistro As Int32) As Boolean
    Dim intIndice As Int32 = -1
    Dim bolResult As Boolean = True

    For lintIndice As Int32 = 0 To Me.dtgSolicitudGuia.RowCount - 1
      If Me.dtgSolicitudGuia.Item("SEL", lintIndice).Value = True Then
        intIndice = lintIndice
        Exit For
      End If
    Next
    If intIndice <> -1 Then
      bolResult = False
      Dim strRuta As String = Me.dtgSolicitudGuia.Item("RUTA", intIndice).Value
      Dim strRuc As String = Me.dtgSolicitudGuia.Item("NRUCTR", intIndice).Value
      Dim strPlaca As String = Me.dtgSolicitudGuia.Item("NPLCUN", intIndice).Value
      Dim strAcoplado As String = Me.dtgSolicitudGuia.Item("NPLCAC", intIndice).Value
      Dim strConductor As String = Me.dtgSolicitudGuia.Item("CBRCNT", intIndice).Value
      Dim strMedioTransporte As String = Me.dtgSolicitudGuia.Item("CMEDTR", intIndice).Value

      If Me.dtgSolicitudGuia.Item("RUTA", intRegistro).Value = strRuta And Me.dtgSolicitudGuia.Item("NRUCTR", intRegistro).Value = strRuc And _
         Me.dtgSolicitudGuia.Item("NPLCUN", intRegistro).Value = strPlaca And Me.dtgSolicitudGuia.Item("NPLCAC", intRegistro).Value = strAcoplado And _
         Me.dtgSolicitudGuia.Item("CBRCNT", intRegistro).Value = strConductor And Me.dtgSolicitudGuia.Item("CMEDTR", intRegistro).Value = strMedioTransporte Then
        bolResult = True
      End If
    End If

    Return bolResult
  End Function

  Private Sub Generar_Columna_Table()
    objTable.Columns.Add("TCMPCL", Type.GetType("System.String"))
    objTable.Columns.Add("NOPRCN", Type.GetType("System.Int64"))
    objTable.Columns.Add("CCMPN", Type.GetType("System.String"))
  End Sub

  Private Sub Lista_Solicitud_Guia()
        'Dim dwvrow As DataGridViewRow
        'Dim objentidad As New List(Of String)
    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        'Dim lint_Contador As Integer = 0
        'If Me.txtNroSolicitud.Text.Trim = "" Then
        '  objentidad.Add(0)
        'Else
        '        objentidad.Add(Val(Me.txtNroSolicitud.Text))
        'End If
        'objentidad.Add(txtCliente.pCodigo)
        'objentidad.Add(HelpClass.CtypeDate(Me.dtpFecIni.Value))
        'objentidad.Add(HelpClass.CtypeDate(Me.dtpFecFin.Value))
        'objentidad.Add(Me.txtTracto.Text.Trim)
        'objentidad.Add(Me._CCMPN_1)
        'objentidad.Add(Me._CDVSN_1)
        'objentidad.Add(Me._CPLNDV_1)
        'objentidad.Add(Me.cboTransportista.pRucTransportista)
        'Me.Limpiar_Solicitud_Guia()
    'Me.dtgSolicitudGuia.DataSource = objSolicitudTransporte.Lista_Solicitud_X_Cliente(objentidad)
        Dim FilaReg As Integer = 0

        Dim pNOPRCN As Decimal = Val(txtNroOperacion.Text)
        Dim pNCSOTR As Decimal = Val(Me.txtNroSolicitud.Text)

        Dim objParametros As New ENTIDADES.Operaciones.OperacionTransporte
        objParametros.NCSOTR = pNCSOTR
        objParametros.CCLNT = txtCliente.pCodigo
        objParametros.NRUCTR = Me.cboTransportista.pRucTransportista
        objParametros.NPLCUN = Me.txtTracto.Text.Trim
        If pNOPRCN > 0 Or pNCSOTR > 0 Then
            objParametros.FECINI = 0
            objParametros.FECFIN = 0
        Else
            objParametros.FECINI = HelpClass.CtypeDate(Me.dtpFecIni.Value)
            objParametros.FECFIN = HelpClass.CtypeDate(Me.dtpFecFin.Value)
        End If
        objParametros.CCMPN = Me._CCMPN_1
        objParametros.CDVSN = Me._CDVSN_1
        objParametros.CPLNDV = Me._CPLNDV_1
        objParametros.NOPRCN = pNOPRCN
        Dim oListSolicitudGuia As New List(Of ClaseGeneral)
        oListSolicitudGuia = objSolicitudTransporte.Lista_Solicitud_X_Cliente(objParametros)
        'oListSolicitudGuia = objSolicitudTransporte.Lista_Solicitud_X_Cliente(objentidad)
        'Lista_Solicitud_X_Cliente
        dtgSolicitudGuia.DataSource = oListSolicitudGuia
        'For Each item As DataGridViewRow In dtgSolicitudGuia.Rows
        '    item.Cells("SEL").Value = False
        'Next

        'For Each obj_Entidad As ClaseGeneral In oListSolicitudGuia
        '    'lint_Contador = 0
        '    'If obj_Entidad.CBRCN2 <> "" Then lint_Contador = 1
        '    'For lint_Numerador As Integer = 0 To lint_Contador
        '    dwvrow = New DataGridViewRow
        '    dwvrow.CreateCells(Me.dtgSolicitudGuia)
        '    dtgSolicitudGuia.Rows.Add(dwvrow)
        '    FilaReg = dtgSolicitudGuia.Rows.Count - 1

        '    dtgSolicitudGuia.Rows(FilaReg).Cells("SEL").Value = False
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NCSOTR").Value = obj_Entidad.NCSOTR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NCRRSR").Value = obj_Entidad.NCRRSR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NPLNJT").Value = obj_Entidad.NPLNJT
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NCRRPL").Value = obj_Entidad.NCRRPL
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CCLNT").Value = obj_Entidad.CCLNT
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NRUCTR").Value = obj_Entidad.NRUCTR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("TCMTRT").Value = obj_Entidad.TCMTRT
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NPLCUN").Value = obj_Entidad.NPLCUN
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NPLCAC").Value = obj_Entidad.NPLCAC
        '    'dtgSolicitudGuia.Rows(FilaReg).Cells("CBRCNT").Value = IIf(lint_Numerador = 0, obj_Entidad.CBRCNT, obj_Entidad.CBRCN2)
        '    'dtgSolicitudGuia.Rows(FilaReg).Cells("CBRCND").Value = IIf(lint_Numerador = 0, obj_Entidad.CBRCND, obj_Entidad.CBRCND2)
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CBRCNT").Value = obj_Entidad.CBRCNT
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CBRCND").Value = obj_Entidad.CBRCND2

        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CLCLOR").Value = obj_Entidad.CLCLOR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("TDRCOR").Value = obj_Entidad.TDRCOR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CLCLDS").Value = obj_Entidad.CLCLDS
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("TDRENT").Value = obj_Entidad.TDRENT
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("RUTA").Value = obj_Entidad.RUTA
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("FASGTR").Value = obj_Entidad.FASGTR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("HASGTR").Value = obj_Entidad.HASGTR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NOPRCN").Value = obj_Entidad.NOPRCN
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("GPSLAT").Value = obj_Entidad.GPSLAT
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("GPSLON").Value = obj_Entidad.GPSLON
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("FECGPS").Value = obj_Entidad.FECGPS
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("HORGPS").Value = obj_Entidad.HORGPS
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("QMRCDR").Value = obj_Entidad.QMRCDR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CUNDMD").Value = obj_Entidad.CUNDMD
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NGUITR").Value = obj_Entidad.NGUITR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CCMPN").Value = obj_Entidad.CCMPN
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NGSGWP").Value = obj_Entidad.NGSGWP
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("NCOREG").Value = obj_Entidad.NCOREG
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CMEDTR").Value = obj_Entidad.CMEDTR
        '    dtgSolicitudGuia.Rows(FilaReg).Cells("CTPOVJ").Value = obj_Entidad.CTPOVJ



        'Next

    End Sub

    'Private Sub Alinear_Columnas_Grilla()
    '  Me.dtgSolicitudGuia.AutoGenerateColumns = False
    '  For lint_contador As Integer = 0 To Me.dtgSolicitudGuia.ColumnCount - 1
    '    Me.dtgSolicitudGuia.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next
    '  If _CTPOCR <> 0 Then
    '    Me.chkTipoGuia.Visible = False
    '  End If
    'End Sub

    'Private Sub Limpiar_Solicitud_Guia()
    '  Me.dtgSolicitudGuia.Rows.Clear()
    'End Sub

    Private Sub Obtener_Datos_Grilla_Normal(ByVal lint_Indice)

        Me.pobjGuiaBE = New GuiaTransportista
        'pobjGuiaBE.CLCLOR = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CLCLOR").Value
        'pobjGuiaBE.CLCLDS = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CLCLDS").Value
        'pobjGuiaBE.TDIROR = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("TDRCOR").Value
        'pobjGuiaBE.TDIRDS = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("TDRENT").Value
        'pobjGuiaBE.QMRCMC = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("QMRCDR").Value
        'pobjGuiaBE.CUNDMD = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CUNDMD").Value
        pobjGuiaBE.CTRMNC = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CTRMNC").Value
        pobjGuiaBE.NRUCTR = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("NRUCTR").Value
        'pobjGuiaBE.NPLCTR = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("NPLCUN").Value
        'pobjGuiaBE.NPLCAC = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("NPLCAC").Value
        'pobjGuiaBE.CBRCNT = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CBRCNT").Value
        pobjGuiaBE.NOPRCN = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("NOPRCN").Value
        'pobjGuiaBE.CBRCND = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CBRCND").Value
        'pobjGuiaBE.RUTA = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("RUTA").Value
        'pobjGuiaBE.TCMPCL = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CCLNT").Value
        'pobjGuiaBE.CMEDTR = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CMEDTR").Value
        pobjGuiaBE.CTPOVJ = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CTPOVJ").Value

      
        'pobjGuiaBE.CPLNDV_DESC = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CPLNDV_DESC").Value
        'pobjGuiaBE.NPLNMT = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("NPLNMT").Value
        'pobjGuiaBE.CTRMNC = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CTRMNC").Value
        'pobjGuiaBE.CUNDMD_DESC = Me.dtgSolicitudGuia.Rows(lint_Indice).Cells("CUNDMD_DESC").Value



    End Sub

  Private Sub Guia_Transportista_Carga()
    Dim frm_GuiaTransportista As New frmGuiaTransportista
    Dim obj_Logica_Guia As New GuiaTransportista_BLL
        'Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
        'Dim obj_Entidad_Guia As New GuiaTransportista

      
        'obj_Entidad_Guia.TDIROR = Me.pobjGuiaBE.TDIROR
        'obj_Entidad_Guia.TDIRDS = Me.pobjGuiaBE.TDIRDS
        '    obj_Entidad_Guia.QMRCMC = Me.pobjGuiaBE.QMRCMC


        'obj_Entidad_Guia.NRUCTR = Me.pobjGuiaBE.NRUCTR
        'obj_Entidad_Guia.NPLCTR = Me.pobjGuiaBE.NPLCTR
        'obj_Entidad_Guia.NPLCAC = Me.pobjGuiaBE.NPLCAC
        'obj_Entidad_Guia.CBRCNT = Me.pobjGuiaBE.CBRCNT
        'obj_Entidad_Guia.CBRCND = Me.pobjGuiaBE.CBRCND
        '    'obj_Entidad_Guia.CMEDTR = Me.pobjGuiaBE.CMEDTR
        '    obj_Entidad_Guia.CTPOVJ = Me.pobjGuiaBE.CTPOVJ
        'obj_Entidad_Guia.TDRCNS = obj_Entidad_Guia.TDIRDS

        'obj_Entidad_Guia.CUNDMD = Me.pobjGuiaBE.CUNDMD
        'obj_Entidad_Guia.CLCLOR = Me.pobjGuiaBE.CLCLOR
        'obj_Entidad_Guia.CLCLDS = Me.pobjGuiaBE.CLCLDS


    'If Me.chkTipoGuia.Checked = False Then
        'obj_Entidad_Guia_Transporte.NOPRCN = Me.pobjGuiaBE.NOPRCN
        'obj_Entidad_Guia_Transporte.NPLCTR = Me.pobjGuiaBE.NPLCTR
        '    obj_Entidad_Guia_Transporte.CCMPN = _CCMPN_1


        '    ' quitando los campos
        'obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
        'obj_Entidad_Guia.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
        'obj_Entidad_Guia.QKMREC = obj_Entidad_Guia_Transporte.QKMREC
        'obj_Entidad_Guia.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM
        'obj_Entidad_Guia.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
        'obj_Entidad_Guia.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
        'obj_Entidad_Guia.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
        'obj_Entidad_Guia.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
        ''obj_Entidad_Guia.TDRCNS = obj_Entidad_Guia.TDIRDS
        'obj_Entidad_Guia.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR
        'obj_Entidad_Guia.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
        'obj_Entidad_Guia.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
        '    obj_Entidad_Guia.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
        '    obj_Entidad_Guia.CUBORI = obj_Entidad_Guia_Transporte.CUBORI
        '    obj_Entidad_Guia.CUBDES = obj_Entidad_Guia_Transporte.CUBDES
        'obj_Entidad_Guia.CMNFLTDESC = obj_Entidad_Guia_Transporte.CMNFLTDESC
        'PSCMNFLTDESC

        'End If

        'CTRMNC

    With frm_GuiaTransportista
      .IsMdiContainer = True
      .AutoSize = True
      Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
            With Comp_Guia
                .ESTADO = False
                .Dock = DockStyle.Fill
                .pCOMPANIA = _CCMPN_1
                .pDIVISION = _CDVSN_1
                .pPLANTA = _CPLNDV_1
                .pPLANTA_DESC = _PlantaDesc
                .pNOPRCN = Me.pobjGuiaBE.NOPRCN
                .pUSUARIO = MainModule.USUARIO
                .pCTPOVJ = Me.pobjGuiaBE.CTPOVJ
                '.Guia_Transporte = obj_Entidad_Guia
                .Tag = Me.Tag
                .pNCSOTR = NCSOTR_1
                .pNCRRSR = NCRRSR_1
                '.objTable = Me.objTable
                .TipoViaje = IIf(Me.objTable.Rows.Count = 0, 0, 1)
                .ChargeForm()
            End With
            If Me.Tag = 2 Then
                .txtNombreFormulario.Text = "  AGREGAR GUIA DE TRANSPORTE A LA OPERACION N° " & Me.pobjGuiaBE.NOPRCN
            Else
                .txtNombreFormulario.Text = "  NUEVA GUIA DE TRANSPORTE "
            End If
            'kkk()
            .panelGuia.Controls.Add(Comp_Guia)

            .ShowDialog()

            'If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
            If Comp_Guia.pDialogOK = True Then
                dtgSolicitudGuia.CurrentRow.Cells("NGUITR").Value = Comp_Guia.pNGUITR
            End If

            'If Comp_Guia.pGuiaTransporte.NGUIRM <> 0 Then
            '    If Me.Tag = 2 Then
            '        Me.Lista_Solicitud_Guia()
            'Else
            '              If Me.chkTipoGuia.Checked = False Then

            '                  If _ListaConfWap.Count > 0 AndAlso _ListaConfWap(0).CODIGO_TIPO = "SI" Then
            '                      Dim NCOREG As String = ""
            '                      Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
            '                      obeSeguimientoGPS.NPLCTR = obj_Entidad_Guia.NPLCTR
            '                      obeSeguimientoGPS.NCSOTR = HelpClass.ObjectToDecimal(Me.NCSOTR_1)
            '                      obeSeguimientoGPS.CCMPN = _CCMPN_1
            '                      obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.NCRRSR_1)
            '                      obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(Me._NGSGWP_1)
            '                      obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(Me._NCOREG_1)
            '                      Dim ofrmGPSWAP As New frmGPSWAP()
            '                      ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
            '                      ofrmGPSWAP.Estado = 1
            '                      ofrmGPSWAP.ShowDialog(Me)
            '                  End If

            '                  Me.Lista_Solicitud_Guia()
            '              End If
            '    End If
            'End If
            'End If
        End With
  End Sub

  Private Sub Guia_Transportista_Pasajero()
    Dim frm_GuiaTransportista As New frmGuiaTransportista
    Dim obj_Logica_Guia As New GuiaTransportista_BLL
    Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
    Dim obj_Entidad_Guia As New GuiaTransportista

    obj_Entidad_Guia.CLCLOR = Me.pobjGuiaBE.CLCLOR
    obj_Entidad_Guia.CLCLDS = Me.pobjGuiaBE.CLCLDS
    obj_Entidad_Guia.TDIROR = Me.pobjGuiaBE.TDIROR
    obj_Entidad_Guia.TDIRDS = Me.pobjGuiaBE.TDIRDS
    obj_Entidad_Guia.QMRCMC = Me.pobjGuiaBE.QMRCMC
    obj_Entidad_Guia.CUNDMD = Me.pobjGuiaBE.CUNDMD
    obj_Entidad_Guia.NRUCTR = Me.pobjGuiaBE.NRUCTR
    obj_Entidad_Guia.NPLCTR = Me.pobjGuiaBE.NPLCTR
    obj_Entidad_Guia.NPLCAC = Me.pobjGuiaBE.NPLCAC
    obj_Entidad_Guia.CBRCNT = Me.pobjGuiaBE.CBRCNT
    obj_Entidad_Guia.CBRCND = Me.pobjGuiaBE.CBRCND
    obj_Entidad_Guia.CMEDTR = Me.pobjGuiaBE.CMEDTR
    obj_Entidad_Guia.CTPOVJ = Me.pobjGuiaBE.CTPOVJ
    obj_Entidad_Guia_Transporte.NOPRCN = Me.pobjGuiaBE.NOPRCN
    obj_Entidad_Guia_Transporte.NPLCTR = Me.pobjGuiaBE.NPLCTR
        obj_Entidad_Guia_Transporte.CCMPN = _CCMPN_1
        obj_Entidad_Guia.TDRCNS = obj_Entidad_Guia.TDIRDS

        'obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
        'obj_Entidad_Guia.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
        'obj_Entidad_Guia.QKMREC = obj_Entidad_Guia_Transporte.QKMREC
        'obj_Entidad_Guia.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM
        'obj_Entidad_Guia.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
        'obj_Entidad_Guia.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
        'obj_Entidad_Guia.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
        'obj_Entidad_Guia.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
        'obj_Entidad_Guia.TDRCNS = obj_Entidad_Guia.TDIRDS
        'obj_Entidad_Guia.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR
        'obj_Entidad_Guia.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
        'obj_Entidad_Guia.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
        '    obj_Entidad_Guia.CCLNT = obj_Entidad_Guia_Transporte.CCLNT

        '    obj_Entidad_Guia.CUBORI = obj_Entidad_Guia_Transporte.CUBORI
        '    obj_Entidad_Guia.CUBDES = obj_Entidad_Guia_Transporte.CUBDES

        With frm_GuiaTransportista
            .IsMdiContainer = True
            .AutoSize = True
            Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportePasajero
            With Comp_Guia
                .ESTADO = False
                .Dock = DockStyle.Fill
                .COMPANIA = _CCMPN_1
                .DIVISION = _CDVSN_1
                .PLANTA = _CPLNDV_1
                .PLANTA_DESC = _PlantaDesc
                .NOPRCN = Me.pobjGuiaBE.NOPRCN
                .USUARIO = MainModule.USUARIO
                .Guia_Transporte = obj_Entidad_Guia
                .Tag = Me.Tag
                .ChargeForm()
                .NCSOTR = NCSOTR_1
                .NCRRSR = NCRRSR_1

            End With
            If Me.Tag = 2 Then
                .txtNombreFormulario.Text = "  AGREGAR GUIA DE TRANSPORTE A LA OPERACION N° " & Me.pobjGuiaBE.NOPRCN
            Else
                .txtNombreFormulario.Text = "  NUEVA GUIA DE TRANSPORTE "
            End If
            .panelGuia.Controls.Add(Comp_Guia)
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                If Comp_Guia.pGuiaTransporte.NGUIRM <> 0 Then
                    If Me.Tag = 2 Then
                        Me.Lista_Solicitud_Guia()
                        'Else

                        '    If _ListaConfWap.Count > 0 AndAlso _ListaConfWap(0).CODIGO_TIPO = "SI" Then

                        '        Dim NCOREG As String = ""
                        '        Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
                        '        obeSeguimientoGPS.NPLCTR = obj_Entidad_Guia.NPLCTR
                        '        obeSeguimientoGPS.NCSOTR = HelpClass.ObjectToDecimal(Me.NCSOTR_1)
                        '        obeSeguimientoGPS.CCMPN = _CCMPN_1
                        '        obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.NCRRSR_1)
                        '        obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(Me._NGSGWP_1)
                        '        obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(Me._NCOREG_1)
                        '        Dim ofrmGPSWAP As New frmGPSWAP()
                        '        ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
                        '        ofrmGPSWAP.Estado = 1
                        '        ofrmGPSWAP.ShowDialog(Me)
                        '    End If

                        '    Me.Lista_Solicitud_Guia()
                    End If
                End If
            End If
        End With
  End Sub

#End Region

End Class

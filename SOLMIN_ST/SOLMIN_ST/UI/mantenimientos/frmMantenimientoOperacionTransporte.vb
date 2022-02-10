Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Text

Public Class frmMantenimientoOperacionTransporte
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private TractoTemporal As New List(Of Tracto)
  Private EventoTemporal As New List(Of AccionWap)
  Private _vCodTransportista As String = ""
  Dim _indiceGrilla As Integer = 0
  Private _lbool_PreCargaData As Boolean = False
  Private _lint_Estado As Integer = 0
    Private bolBuscar As Boolean = False
  Public Property LoadPreviousData() As Boolean
    Get
      Return _lbool_PreCargaData
    End Get
    Set(ByVal value As Boolean)
      _lbool_PreCargaData = value
    End Set
  End Property

  Public Sub ShowForm(ByVal CodigoTrasportista As String, ByVal CodigoUnidad As String, ByVal owner As IWin32Window)
        'Pone el flag en neutral
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            btnEliminar.Enabled = False

            Limpiar_Controles_OperacionTransporte()
            Estado_Controles_OperacionTransporte(False)
            Cargar_Compania()
            Carga_Data_Inicial()
            'Establece el trasportista
            CargarTransportista(CodigoTrasportista)
            Me.ctbTransportista.Enabled = False
            Me.Lista()

            'Establece el nuevo flag para la ventana
            _lbool_PreCargaData = True
            Me.Show(owner)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  

  End Sub

  Private Sub CargarTransportista(ByVal NroRucTransportista As String)
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        If NroRucTransportista = "" Then
            NroRucTransportista = "20100039207"
            obeTransportista.pNRUCTR_RucTransportista = NroRucTransportista
        Else
            obeTransportista.pNRUCTR_RucTransportista = NroRucTransportista
        End If
        ctbTransportista.pCargar(obeTransportista)
    End Sub

  Private Sub CargarTracto(ByVal NroRucTransportista As String)
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
    obeTracto.pCDVSN_Division = Me.cmbDivision.SelectedValue
    obeTracto.pCPLNDV_Planta = Me.cmbPlanta.SelectedValue
    obeTracto.pNRUCTR_RucTransportista = NroRucTransportista
    ctbVehiculo.pCargar(obeTracto)
  End Sub

  Private Sub Estado_Controles_OperacionTransporte(ByVal lbool_Estado As Boolean)
    cboVehiculos.Enabled = lbool_Estado
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
      Me.cboVehiculos.Enabled = Not lbool_Estado
    End If
        cboAcoplados.Enabled = lbool_Estado
        cmbConductor.Enabled = lbool_Estado
        cboTipoVehiculo.Enabled = lbool_Estado
        'cboConductores.Enabled = lbool_Estado
        'cboTipoCarroceria.Enabled = lbool_Estado
    txtCliente.Enabled = lbool_Estado
  End Sub

  Private Sub Limpiar_Controles_OperacionTransporte()
        cboVehiculos.pClear()
        cboAcoplados.pClear()
        'cboConductores.Limpiar()
        'cboTipoCarroceria.Limpiar()
        txtCliente.pClear()
        cmbConductor.pClear()
        cboTipoVehiculo.Limpiar()
        'Me.HeaderOpTransporte.ValuesPrimary.Heading = "Información de Operación de Transporte"
  End Sub

  Private Sub Carga_Data_Inicial()
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    Me.Cargar_Combo_Tracto()
        Me.Cargar_Combo_Acoplado()
        cmbConductor.Enabled = False
        'Me.Cargar_Combo_Conductores()
    Me.Cargar_Combo_TipoCarroceria()
  End Sub

    Private Sub Cargar_Combo_Acoplado(Optional ByVal NroRucTransportista As String = "", Optional ByVal NroAcoplado As String = "")
        'Try
        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
        obeAcoplado.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeAcoplado.pCDVSN_Division = Me.cmbDivision.SelectedValue
        obeAcoplado.pCPLNDV_Planta = Me.cmbPlanta.SelectedValue
        obeAcoplado.pNRUCTR_RucTransportista = NroRucTransportista
        obeAcoplado.pNPLCAC_NroAcoplado = NroAcoplado
        Me.cboAcoplados.pCargar(obeAcoplado)
        'Catch ex As Exception
        'End Try
    End Sub

    'Private Sub Cargar_Combo_Conductores()
    '      Try
    '          Dim obj_logica As New Detalle_Solicitud_Transporte_BLL
    '          With Me.cboConductores
    '              .DataSource = HelpClass.GetDataSetNative(obj_logica.Listar_Conductor_Solicitud(_vCodTransportista, Me.cmbCompania.SelectedValue))
    '              .KeyField = "CBRCNT"
    '              .ValueField = "TOBS"
    '              .DataBind()
    '          End With
    '          '------------------

    '      Catch ex As Exception
    '      End Try
    '  End Sub

    Private Sub Cargar_Combo_Conductor()
        'Try
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        If lint_indice > -1 Then
            Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            obeConductor.pCCMPN_Compania = cmbCompania.SelectedValue()
            obeConductor.pCBRCNT_Brevete = Me.gwdDatos("Conductor", lint_indice).Value.ToString().Trim()
            Me.cmbConductor.pCargar(obeConductor)
            cmbConductor.Enabled = False
            'If Me.cmbConductor.pBrevete = "" Then
            '    cmbConductor.Enabled = True
            'Else
            'cmbConductor.Enabled = False
            'End If
        End If
        'Catch ex As Exception

        'End Try
    End Sub

  Private Sub Cargar_Combo_TipoCarroceria()
        Dim objLogica As New TipoCarroceria_BLL
        Dim objLista As New List(Of TipoCarroceria)
        objLista = objLogica.Listar_TipoCarroceria(Me.cmbCompania.SelectedValue)
        '-----------------------
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPCRA"
        oColumnas.DataPropertyName = "CTPCRA"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMCRA"
        oColumnas.DataPropertyName = "TCMCRA"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oListColum.Add(2, oColumnas)
        Me.cboTipoVehiculo.DataSource = objLista
        Me.cboTipoVehiculo.ListColumnas = oListColum
        Me.cboTipoVehiculo.Cargas()
        Me.cboTipoVehiculo.DispleyMember = "TCMCRA"
        Me.cboTipoVehiculo.ValueMember = "CTPCRA"

  End Sub

  Private Function Asignar_Valor(ByVal lint_Codigo As Integer) As String
    Dim lstr_Valor As String = ""
    Select Case lint_Codigo
      Case 0
        lstr_Valor = "A"
      Case 1
        lstr_Valor = "*"
    End Select
    Return lstr_Valor
  End Function

  Private Sub Lista()
    Dim objSeguimientoWap As New SeguimientoWAP_BLL
    Dim objParametros As New Hashtable
    Dim ldgrow As DataGridViewRow
        'Try
        Me.gwdDatos.Rows.Clear()
        objParametros.Add("NRUCTR", IIf(Me.ctbTransportista.pRucTransportista.Trim.Equals(""), "", Me.ctbTransportista.pRucTransportista))
        objParametros.Add("NPLCUN", IIf(Me.ctbVehiculo.pNroPlacaUnidad.Trim.Equals(""), "0", Me.ctbVehiculo.pNroPlacaUnidad.Trim))
        objParametros.Add("NCOACC", IIf(Me.ctbEvento.Texto.TextLength = 0, "0", Me.ctbEvento.Codigo.Trim))
        objParametros.Add("CCMPN", Me.cmbCompania.SelectedValue)
        objParametros.Add("CDVSN", Me.cmbDivision.SelectedValue)
        objParametros.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
        For Each objDataRow As DataRow In objSeguimientoWap.Listar_Ultima_Ubicacion_ManttOpTransporte(objParametros).Rows
            ldgrow = New DataGridViewRow
            ldgrow.CreateCells(Me.gwdDatos)
            ldgrow.Cells(0).Value = objDataRow.Item("NRUCTR").ToString.Trim
            ldgrow.Cells(1).Value = objDataRow.Item("NPLCUN").ToString.Trim
            ldgrow.Cells(2).Value = objDataRow.Item("TCLRUN").ToString.Trim
            ldgrow.Cells(3).Value = objDataRow.Item("TMRCTR").ToString.Trim
            ldgrow.Cells(4).Value = objDataRow.Item("CBRCND").ToString.Trim
            ldgrow.Cells(5).Value = objDataRow.Item("NPLACP").ToString.Trim
            ldgrow.Cells(6).Value = objDataRow.Item("TCMCRA").ToString.Trim
            If objDataRow.Item("FECGPS").ToString <> vbNullString And objDataRow.Item("HORGPS").ToString <> vbNullString Then
                ldgrow.Cells(8).Value = objDataRow.Item("FECGPS").ToString.Trim & " " & objDataRow.Item("HORGPS").ToString.Trim
                ldgrow.Cells(8).ToolTipText = "Hacer click para" & Chr(10) & " ver  la localización del" & Chr(10) & " vehículo en Google Maps"
            End If
            ldgrow.Cells(9).Value = objDataRow.Item("HORGPS").ToString.Trim
            ldgrow.Cells(10).Value = objDataRow.Item("SEGUIMIENTO").ToString.Trim
            If ldgrow.Cells(10).Value <> vbNullString Then
                ldgrow.Cells(10).ToolTipText = "Hacer click para " & Chr(10) & "ver seguimiento WAP"
            End If
            ldgrow.Cells(11).Value = objDataRow.Item("GPSLAT").ToString.Trim
            ldgrow.Cells(12).Value = objDataRow.Item("GPSLON").ToString.Trim
            ldgrow.Cells(13).Value = objDataRow.Item("CTPCRA").ToString.Trim
            ldgrow.Cells(14).Value = objDataRow.Item("CCLNT").ToString.Trim
            ldgrow.Cells(15).Value = objDataRow.Item("TCMPCL").ToString.Trim
            ldgrow.Cells(16).Value = objDataRow.Item("NCOACC").ToString.Trim
            ldgrow.Cells(17).Value = objDataRow.Item("CBRCNT").ToString.Trim
            If ldgrow.Cells(9).Value <> "" Then
                ldgrow.Cells(7).Value = My.Resources.button_ok1
            Else
                ldgrow.Cells(7).Value = My.Resources.Nada_1
            End If
            Me.gwdDatos.Rows.Add(ldgrow)
            ldgrow.Cells(8).Style.ForeColor = Drawing.Color.Green
        Next

        Me.gwdDatos.Columns(7).Visible = False
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
        End If
        'Catch ex As Exception
        '    End Try
  End Sub

  Private Sub Cargar_Combo_Tracto(Optional ByVal NroRucTransportista As String = "", Optional ByVal NroPlacaUnidad As String = "")
        'Try
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeTracto.pCDVSN_Division = Me.cmbDivision.SelectedValue
        obeTracto.pCPLNDV_Planta = Me.cmbPlanta.SelectedValue
        obeTracto.pNRUCTR_RucTransportista = NroRucTransportista
        'ctbVehiculo.pCargar(obeTracto)
        obeTracto.pNPLCUN_NroPlacaUnidad = NroPlacaUnidad
        cboVehiculos.pCargar(obeTracto)
        'Catch ex As Exception
        'End Try
    End Sub

  Private Sub Lista_Eventos_WAP()
    Dim obrSeguimientoWAP_BLL As New SeguimientoWAP_BLL
    With ctbEvento
            .DataSource = HelpClass.GetDataSetNative(obrSeguimientoWAP_BLL.Lista_Eventos_Wap(Me.cmbCompania.SelectedValue))
      .KeyField = "NCOEVT"
      .ValueField = "TNMEV"
      .DataBind()
    End With
  End Sub

  Private Sub Registrar_OperacionTransporte()
    If Not cboVehiculos.pNroPlacaUnidad.Trim.Equals("") Then
      Dim objLogica As New TransportistaTracto_BLL
      Dim objEntidadTT As New TransportistaTracto

      objEntidadTT.NRUCTR = _vCodTransportista
      objEntidadTT.NPLCUN = cboVehiculos.pNroPlacaUnidad
            objEntidadTT.NPLACP = cboAcoplados.pNroAcoplado
            objEntidadTT.CBRCNT = cmbConductor.pBrevete
            'objEntidadTT.CBRCNT = cboConductores.Codigo
            objEntidadTT.CCLNT = txtCliente.pCodigo
            If Me.cboTipoVehiculo.Resultado IsNot Nothing Then
                If CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA = "" Then
                    objEntidadTT.CTPCRA = 0
                Else
                    objEntidadTT.CTPCRA = CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA 'cboTipoVehiculo.Valor
                End If
            End If
            objEntidadTT.CBRCNT = cmbConductor.pBrevete
            objEntidadTT.FECINI = HelpClass.TodayNumeric
            objEntidadTT.FECFIN = HelpClass.TodayNumeric
            objEntidadTT.TOBS = ""
            objEntidadTT.CUSCRT = MainModule.USUARIO
            objEntidadTT.FCHCRT = HelpClass.TodayNumeric
            objEntidadTT.HRACRT = HelpClass.NowNumeric
            objEntidadTT.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidadTT.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidadTT.POS_RUC_ANTERIOR = ""
            objEntidadTT.FLAG_SKIPCHECKS = 0
            objEntidadTT.CCMPN = Me.cmbCompania.SelectedValue
            objEntidadTT.CDVSN = Me.cmbDivision.SelectedValue
            objEntidadTT.CPLNDV = Me.cmbPlanta.SelectedValue

            Dim objExisteTT As New TransportistaTracto
            objExisteTT = objEntidadTT
            objExisteTT.CCMPN = cmbCompania.SelectedValue.ToString().Trim()

            objExisteTT = objLogica.Registrar_TransportistaTracto(objExisteTT)

            '    If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
            '        HelpClass.ErrorMsgBox()
            '        Exit Sub

            '    ElseIf objExisteTT.POS_RUC_ANTERIOR = "" Then
            '        objEntidadTT.FLAG_SKIPCHECKS = 1
            '        objEntidadTT.CCMPN = cmbCompania.SelectedValue.ToString()
            '        objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
            '        If objEntidadTT.NRUCTR = "-1" Then
            '            HelpClass.ErrorMsgBox()
            '            Exit Sub
            '        Else
            '            Lista()
            '        End If

            '    ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe asignado a otro transportista

            '        Dim objLogicaCia As New Transportista_BLL

            '        Dim objCia1 As New Transportista
            '        objCia1.CCMPN = Me.cmbCompania.SelectedValue
            '        objCia1.CDVSN = Me.cmbDivision.SelectedValue
            '        objCia1.CPLNDV = Me.cmbPlanta.SelectedValue
            '        objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
            '        objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

            '        Dim objCia2 As New Transportista
            '        objCia2.CCMPN = Me.cmbCompania.SelectedValue
            '        objCia2.CDVSN = Me.cmbDivision.SelectedValue
            '        objCia2.CPLNDV = Me.cmbPlanta.SelectedValue
            '        objCia2.NRUCTR = objEntidadTT.NRUCTR
            '        objCia2 = objLogicaCia.Listar_Transportista(objCia2).Item(0)

            '        Dim strMsg As String = "Tracto ya asignado." & vbCrLf & _
            '                                "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
            '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
            '                                "Desea cambiarlo a la compañía " & objCia2.TCMTRT & " ?"

            '        If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            '            objEntidadTT.FLAG_SKIPCHECKS = 1
            '            objEntidadTT.CCMPN = cmbCompania.SelectedValue.ToString().Trim()
            '            objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
            '            If objEntidadTT.NRUCTR = "-1" Then
            '                HelpClass.ErrorMsgBox()
            '                Exit Sub
            '            Else
            '                Lista()
            '            End If
            '        End If
            '    End If
            'End If
            'If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub

            'Else
            If objExisteTT.POS_RUC_ANTERIOR = "" Then
                objEntidadTT.FLAG_SKIPCHECKS = 1
                objEntidadTT.CCMPN = cmbCompania.SelectedValue.ToString()
                objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                'If objEntidadTT.NRUCTR = "-1" Then
                '    HelpClass.ErrorMsgBox()
                '    Exit Sub
                'Else
                Lista()
                'End If

            ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe asignado a otro transportista

                Dim objLogicaCia As New Transportista_BLL

                Dim objCia1 As New Transportista
                objCia1.CCMPN = Me.cmbCompania.SelectedValue
                objCia1.CDVSN = Me.cmbDivision.SelectedValue
                objCia1.CPLNDV = Me.cmbPlanta.SelectedValue
                objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                objCia1 = olbeCia1.Item(0)
                'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

                Dim objCia2 As New Transportista
                objCia2.CCMPN = Me.cmbCompania.SelectedValue
                objCia2.CDVSN = Me.cmbDivision.SelectedValue
                objCia2.CPLNDV = Me.cmbPlanta.SelectedValue
                objCia2.NRUCTR = objEntidadTT.NRUCTR
                Dim olbeCia2 As New List(Of Transportista)
                olbeCia2 = objLogicaCia.Listar_Transportista(objCia2)
                If olbeCia2.Count = 0 Then Exit Sub
                'objCia2 = objLogicaCia.Listar_Transportista(objCia2).Item(0)
                objCia2 = olbeCia2.Item(0)

                Dim strMsg As String = "Tracto ya asignado." & vbCrLf & _
                                        "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "Desea cambiarlo a la compañía " & objCia2.TCMTRT & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    objEntidadTT.CCMPN = cmbCompania.SelectedValue.ToString().Trim()
                    objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                    'If objEntidadTT.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'Else
                    Lista()
                    'End If
            End If
            End If
        End If
  End Sub

  Private Sub Modificar_OperacionTransporte()
    If Not cboVehiculos.pNroPlacaUnidad.Trim.Equals("") Then
      Dim objLogica As New TransportistaTracto_BLL
      Dim objTT As New TransportistaTracto

      objTT.NRUCTR = _vCodTransportista
      objTT.NPLCUN = cboVehiculos.pNroPlacaUnidad
      objTT.NPLACP = cboAcoplados.pNroAcoplado
            objTT.CBRCNT = cmbConductor.pBrevete 'cboConductores.Codigo
      objTT.CCLNT = txtCliente.pCodigo
            If Me.cboTipoVehiculo.Resultado IsNot Nothing Then
                If CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA = "" Then
                    objTT.CTPCRA = 0
                Else
                    objTT.CTPCRA = CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA
                End If
            End If
            objTT.CULUSA = MainModule.USUARIO
            objTT.FULTAC = HelpClass.TodayNumeric
            objTT.HULTAC = HelpClass.NowNumeric
            objTT.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objTT.CCMPN = Me.cmbCompania.SelectedValue

            objTT = objLogica.Modificar_TransportistaTracto(objTT)
            If objTT.NRUCTR = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                Lista()
            End If
        End If
  End Sub

  Private Sub AccionCancelar()
    If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      Limpiar_Controles_OperacionTransporte()
      Estado_Controles_OperacionTransporte(False)
      If Me.gwdDatos.Rows.Count > 0 Then
        Me.gwdDatos.CurrentRow.Selected = False
      End If
    ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      Estado_Controles_OperacionTransporte(False)
      btnGuardar.Text = "Modificar"
    ElseIf gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
      Limpiar_Controles_OperacionTransporte()
    End If

    If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      btnGuardar.Enabled = True
      gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    Else
      btnGuardar.Enabled = False
      gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    End If
    btnNuevo.Enabled = False
    btnCancelar.Enabled = False
        btnEliminar.Enabled = True

  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    'Alineando el orden de las Columnas
    Me.gwdDatos.Columns.Item(1).DisplayIndex = 0
    Me.gwdDatos.Columns.Item(2).DisplayIndex = 1
    Me.gwdDatos.Columns.Item(3).DisplayIndex = 2
    Me.gwdDatos.Columns.Item(5).DisplayIndex = 3
    Me.gwdDatos.Columns.Item(4).DisplayIndex = 4
    Me.gwdDatos.Columns.Item(17).DisplayIndex = 5
    Me.gwdDatos.Columns.Item(6).DisplayIndex = 6
    Me.gwdDatos.Columns.Item(8).DisplayIndex = 7
    Me.gwdDatos.Columns.Item(10).DisplayIndex = 8
    Me.gwdDatos.Columns.Item(15).DisplayIndex = 9

  End Sub

  Private Sub frmConsultarVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    Cargar_Compania()
        '    Activar_Botones()
        '    CargarTracto(ctbTransportista.pRucTransportista)
        'Catch : End Try

        Try
            Cargar_Compania()
            Activar_Botones()
            CargarTracto(ctbTransportista.pRucTransportista)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

    Private Sub CargarControles()
        CargarTransportista("")
        CargarTracto("")
        If _lbool_PreCargaData = False Then
            Carga_Data_Inicial()
        End If
        Me.Alinear_Columnas_Grilla()
        txtCliente.pUsuario = USUARIO
        txtCliente.CCMPN = Me.cmbCompania.SelectedValue
        Lista_Eventos_WAP()
    End Sub

  Private Sub dgwDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
    Try
      If e.RowIndex < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
        Exit Sub
      End If
      Dim CCMPN As String = cmbCompania.SelectedValue.ToString()
      Select Case e.ColumnIndex
        Case 4
          Dim CBRCND As String = Me.gwdDatos.Item("Conductor", e.RowIndex).Value.ToString
          Dim f As New frmInformacionChofer(CBRCND)
          f.CCMPN = CCMPN
          f.ShowForm(Me)
        Case 5
          Dim NPLCAC As String = Me.gwdDatos.Item("Acoplado", e.RowIndex).Value.ToString
          Dim f As New frmInformacionAcoplado(NPLCAC)
          f.CCMPN = CCMPN
          f.ShowForm(Me)
         
            End Select
            Cargar_Bitacora_Vehiculo()
            Activar_Botones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Not Me.ctbTransportista.pRucTransportista.Trim.Equals("") OrElse Me.ctbEvento.Texto.TextLength > 0 Then
                Me.Limpiar_Controles_OperacionTransporte()
                Me.Lista()
                If gwdDatos.Rows.Count > 0 Then
                    If _vCodTransportista <> ctbTransportista.pRucTransportista Then
                        _vCodTransportista = ctbTransportista.pRucTransportista
                        Me.Cargar_Combo_Acoplado()
                        cmbConductor.Enabled = False
                        'Me.Cargar_Combo_Conductores()
                        Me.Cargar_Combo_TipoCarroceria()
                    End If
                End If
            Else
                Me.gwdDatos.Rows.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

        Try
            Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If e.RowIndex < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If

            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.gwdDatos.CurrentRow.Selected = False
                End If
                MsgBox("Debe guardar la operación de transporte o cancelarla.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR

            btnGuardar.Text = "Modificar"
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True

            Limpiar_Controles_OperacionTransporte()
            _indiceGrilla = lint_indice

            Cargar_Combo_Tracto(Me.gwdDatos.Item("RUCTransportista", lint_indice).Value.ToString().Trim(), Me.gwdDatos.Item("Placa", lint_indice).Value.ToString().Trim())
            Cargar_Combo_Acoplado(Me.gwdDatos.Item("RUCTransportista", lint_indice).Value.ToString().Trim(), Me.gwdDatos.Item("Acoplado", lint_indice).Value.ToString().Trim())

            Cargar_Combo_Conductor()
            cboTipoVehiculo.Valor = Me.gwdDatos.Item("CodTipoCarroceria", lint_indice).Value.ToString().Trim()
            txtCliente.pCargar(Me.gwdDatos.Item("CodCliente", lint_indice).Value.ToString().Trim())

            'Link a ventanas Parent

            Select Case e.ColumnIndex
                Case 8 'Ubicacion GPS
                    If Me.gwdDatos.Item("GPSLON", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString <> "" Then
                        Dim objGpsBrowser As New frmMapa
                        With objGpsBrowser
                            .Latitud = Me.gwdDatos.Item("GPSLAT", e.RowIndex).Value
                            .Longitud = Me.gwdDatos.Item("GPSLON", e.RowIndex).Value
                            .Fecha = Me.gwdDatos.Item("FECGPS", e.RowIndex).Value
                            .Hora = Me.gwdDatos.Item("HORGPS", e.RowIndex).Value.ToString.Trim
                            .WindowState = FormWindowState.Maximized
                            .ShowForm(.Latitud, .Longitud, Me)
                        End With
                    End If
                Case 10
                    If gwdDatos.CurrentCellAddress.Y < 0 OrElse Me.gwdDatos.Item("Seguimiento", Me.gwdDatos.CurrentCellAddress.Y).Value = "" Then
                        Exit Sub
                    End If
                    Dim NPLCUN As String = gwdDatos.Item("Placa", gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim()
                    Dim strExiste As String = gwdDatos.Item("Seguimiento", gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim()
                    If strExiste = vbNullString Then Exit Sub
                    Dim f As New frmRegistroWAP(NPLCUN)
                    f.CCMPN = Me.cmbCompania.SelectedValue
                    f.ShowForm(Me)
            End Select

            Cargar_Bitacora_Vehiculo()
            Activar_Botones()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub Cargar_Bitacora_Vehiculo()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Dim objTractoBLL As New Tracto_BLL
        Dim objEntidad As New Tracto
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        objEntidad.NRUCTR = Me.gwdDatos.Item("RUCTransportista", lint_indice).Value.ToString().Trim() 'Me.ctbTransportista.pRucTransportista.Trim
        objEntidad.NPLCUN = Me.gwdDatos.Item("Placa", lint_indice).Value.ToString().Trim()
        objEntidad.FECSEG = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaUbicacion.Value)
        dgwBitacoraVehiculo.AutoGenerateColumns = False
        dgwBitacoraVehiculo.DataSource = objTractoBLL.Listar_Bitacora_Vehiculo(objEntidad)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            If ctbTransportista.pRucTransportista.Trim.Equals("") Then
                HelpClass.MsgBox("Seleccione un transportista", MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            _vCodTransportista = ctbTransportista.pRucTransportista

            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            btnNuevo.Enabled = False
            btnGuardar.Text = "Guardar"
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnEliminar.Enabled = False

            Limpiar_Controles_OperacionTransporte()
            Estado_Controles_OperacionTransporte(True)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If cboVehiculos.pNroPlacaUnidad.Trim.Equals("") Then
                    MsgBox("Seleccione un tracto", MsgBoxStyle.Exclamation)
                Else
                    Registrar_OperacionTransporte()
                    AccionCancelar()
                End If
            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If Not cboVehiculos.pNroPlacaUnidad.Trim.Equals("") Then
                    Modificar_OperacionTransporte()
                    If Me.gwdDatos.Rows.Count > 0 Then
                        Me.Limpiar_Controles_OperacionTransporte()
                        Me.gwdDatos.CurrentRow.Selected = False
                    End If
                    AccionCancelar()
                End If
                'pulso el boton 'modificar'
            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                Me.Estado_Controles_OperacionTransporte(True)
                btnGuardar.Text = "Guardar"
                btnNuevo.Enabled = False
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                'prepara para la sgte accion del btnGuardar (guardar en BD)
                Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim str_PestanaActiva As String
            Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            str_PestanaActiva = Me.TabOperacion.SelectedTab.Name
            If str_PestanaActiva = "tabInformacion" Then
                'If Not cboVehiculos.pNroPlacaUnidad.Trim.Equals("") Then
                Dim objLogica As New TransportistaTracto_BLL
                Dim objTT As New TransportistaTracto

                objTT.NRUCTR = _vCodTransportista
                objTT.NPLCUN = Me.gwdDatos.Item("Placa", lint_indice).Value.ToString().Trim() 'cboVehiculos.pNroPlacaUnidad
                objTT.CULUSA = MainModule.USUARIO
                objTT.FULTAC = HelpClass.TodayNumeric
                objTT.HULTAC = HelpClass.NowNumeric
                objTT.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                objTT.CCMPN = Me.cmbCompania.SelectedValue
                objTT.CDVSN = Me.cmbDivision.SelectedValue
                objTT.CPLNDV = Me.cmbPlanta.SelectedValue

                objLogica.Eliminar_TransportistaTracto(objTT)
                Lista()

                'objTT = objLogica.Eliminar_TransportistaTracto(objTT)
                'If objTT.NRUCTR = 0 Then
                '    HelpClass.ErrorMsgBox()
                '    Exit Sub
                'Else
                '    Lista()
                'End If
                'End If
            Else
                If Me.dgwBitacoraVehiculo.RowCount = 0 Then Exit Sub
                Dim objTractoBLL As New Tracto_BLL
                Dim objEntidad As New Tracto
                objEntidad.NMRCRL = dgwBitacoraVehiculo.Item("NMRCRL", dgwBitacoraVehiculo.CurrentCellAddress.Y).Value.ToString.Trim()
                objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                objEntidad.CULUSA = MainModule.USUARIO
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric
                objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                objEntidad = objTractoBLL.Eliminar_Bitacora_Vehiculo(objEntidad)
                If objEntidad.NMRCRL = 0 Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                Else
                    Cargar_Bitacora_Vehiculo()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub btnRegistroWAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroWAP.Click
        Try
            If gwdDatos.CurrentCellAddress.Y < 0 Then 'OrElse Me.gwdDatos.Item(8, Me.gwdDatos.CurrentCellAddress.Y).Value = "" Then
                Exit Sub
            End If

            Dim NPLCUN As String = gwdDatos.Item("Placa", gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim()
            Dim f As New frmRegistroWAP(NPLCUN)
            f.CCMPN = Me.cmbCompania.SelectedValue
            f.ShowForm(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim objRep As New SeguimientoWAP_BLL
    Dim objCrep As New rptEstadoFlota
    Dim objDt As DataTable
    Dim objDs As New DataSet
    Dim objPrintForm As New PrintForm
    Dim objHash As New Hashtable
    Try
            objHash.Add("CCMPN", Me.cmbCompania.SelectedValue)
            objHash.Add("CDVSN", Me.cmbDivision.SelectedValue)
            objHash.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
            objHash.Add("NRUCTR", IIf(Me.ctbTransportista.pRucTransportista.Trim.Equals(""), "", Me.ctbTransportista.pRucTransportista))
            objHash.Add("NPLCUN", IIf(Me.ctbVehiculo.pNroPlacaUnidad.Trim.Equals(""), "0", Me.ctbVehiculo.pNroPlacaUnidad.Trim))
            objHash.Add("NCOACC", IIf(Me.ctbEvento.Texto.TextLength = 0, "0", Me.ctbEvento.Codigo.Trim))

      objDt = objRep.Listar_Estado_Flota(objHash)
      objDt.TableName = "Estado_Flota"
      objDs.Tables.Add(objDt.Copy)
      objCrep.SetDataSource(objDs)
      objPrintForm.ShowForm(objCrep, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    If Me.gwdDatos.Rows.Count > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
  End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        Try
            Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If lint_indice < 0 Then Exit Sub
            If e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down Then
                Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
                btnGuardar.Text = "Modificar"
                btnGuardar.Enabled = True
                btnEliminar.Enabled = True
                Limpiar_Controles_OperacionTransporte()
                _indiceGrilla = lint_indice

                Cargar_Combo_Tracto(Me.gwdDatos.Item("RUCTransportista", lint_indice).Value.ToString().Trim(), Me.gwdDatos.Item("Placa", lint_indice).Value.ToString().Trim())
                Cargar_Combo_Acoplado(Me.gwdDatos.Item("RUCTransportista", lint_indice).Value.ToString().Trim(), Me.gwdDatos.Item("Acoplado", lint_indice).Value.ToString().Trim())
                Cargar_Combo_Conductor()
                cboTipoVehiculo.Valor = Me.gwdDatos.Item("CodTipoCarroceria", lint_indice).Value.ToString().Trim()
                txtCliente.pCargar(Me.gwdDatos.Item("CodCliente", lint_indice).Value.ToString().Trim())
                Cargar_Bitacora_Vehiculo()
                Activar_Botones()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub btnSeguimientoFlota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguimientoFlota.Click
    If Me.ctbTransportista.pRucTransportista.Trim <> "20100039207" Then
      Exit Sub
    End If

    btnBuscar_Click(sender, e)
    Threading.Thread.Sleep(2000)

    'Solo para flota Propia
    Dim objEntidad As New ENTIDADES.mantenimientos.TransportistaTracto
    Dim objTracto As New NEGOCIO.mantenimientos.Tracto_BLL
    Dim dtbDatos As New DataTable

        dtbDatos = objTracto.Listar_Tractos_Transportista_Propio(Me.cmbCompania.SelectedValue)

    'Creando la cadena de longitud y de latitud para
    Dim lstr_posicion_gps As String = ""
    Dim lstr_documento_xml As String = ""
    Dim archivo As String = ""
    Dim pStart As New System.Diagnostics.Process
    Dim str_localizacion As String = ""
    Dim lint_indice As Integer = 0

    lstr_documento_xml += "<?xml version=""1.0"" encoding=""UTF-8""?>"
    lstr_documento_xml += "<kml xmlns=""http://www.opengis.net/kml/2.2"" xmlns:gx=""http://www.google.com/kml/ext/2.2"" xmlns:kml=""http://www.opengis.net/kml/2.2"" xmlns:atom=""http://www.w3.org/2005/Atom"">"
    lstr_documento_xml += "<Document>"
    lstr_documento_xml += "	<name>SeguimientoWap.kml</name>"
    lstr_documento_xml += "	<open>1</open>"
    lstr_documento_xml += "	<StyleMap id=""msn_truck"">                                                   "
    lstr_documento_xml += "		<Pair>                                                                    "
    lstr_documento_xml += "			<key>normal</key>                                                     "
    lstr_documento_xml += "			<styleUrl>#sn_truck</styleUrl>                                        "
    lstr_documento_xml += "		</Pair>                                                                   "
    lstr_documento_xml += "		<Pair>                                                                    "
    lstr_documento_xml += "			<key>highlight</key>                                                  "
    lstr_documento_xml += "			<styleUrl>#sh_truck</styleUrl>                                        "
    lstr_documento_xml += "		</Pair>                                                                   "
    lstr_documento_xml += "	</StyleMap>                                                                   "
    lstr_documento_xml += "	<Style id=""sh_truck"">                                                       "
    lstr_documento_xml += "		<IconStyle>                                                               "
    lstr_documento_xml += "			<color>ff00aa55</color>                                               "
    lstr_documento_xml += "			<scale>1.4</scale>                                                    "
    lstr_documento_xml += "			<Icon>                                                                "
    lstr_documento_xml += "				<href>http://maps.google.com/mapfiles/kml/shapes/truck.png</href> "
    lstr_documento_xml += "			</Icon>                                                               "
    lstr_documento_xml += "			<hotSpot x=""0.5"" y=""0"" xunits=""fraction"" yunits=""fraction""/>  "
    lstr_documento_xml += "		</IconStyle>                                                              "
    lstr_documento_xml += "		<ListStyle>                                                               "
    lstr_documento_xml += "		</ListStyle>                                                              "
    lstr_documento_xml += "	</Style>                                                                      "
    lstr_documento_xml += "	<Style id=""sn_truck"">                                                       "
    lstr_documento_xml += "		<IconStyle>                                                               "
    lstr_documento_xml += "			<color>ff00aa55</color>                                               "
    lstr_documento_xml += "			<scale>1.2</scale>                                                    "
    lstr_documento_xml += "			<Icon>                                                                "
    lstr_documento_xml += "				<href>http://maps.google.com/mapfiles/kml/shapes/truck.png</href> "
    lstr_documento_xml += "			</Icon>                                                               "
    lstr_documento_xml += "			<hotSpot x=""0.5"" y=""0"" xunits=""fraction"" yunits=""fraction""/>  "
    lstr_documento_xml += "		</IconStyle>                                                              "
    lstr_documento_xml += "		<ListStyle>                                                               "
    lstr_documento_xml += "		</ListStyle>                                                              "
    lstr_documento_xml += "	</Style>       "
    lstr_documento_xml += "	<Folder>"
    lstr_documento_xml += "		<name>Seguimiento de Flota</name>"
    lstr_documento_xml += "		<open>1</open>"
    lstr_documento_xml += "		<Placemark>"
    lstr_documento_xml += "			<name>ruta001</name>"
    lstr_documento_xml += "			<styleUrl>#msn_truck</styleUrl>"
    lstr_documento_xml += "			<LineString>"
    lstr_documento_xml += "				<tessellate>1</tessellate>"
    lstr_documento_xml += "				<coordinates>"
    lstr_documento_xml += "				</coordinates>"
    lstr_documento_xml += "			</LineString>"
    lstr_documento_xml += "		</Placemark>"

    For i As Integer = 0 To dtbDatos.Rows.Count - 2

      If dtbDatos.Rows(i).Item(2).ToString.Trim = "" And dtbDatos.Rows(i).Item(1).ToString.Trim = "" Then
        GoTo NextElement1
      End If

      lstr_documento_xml += "		<Placemark>"
      lstr_documento_xml += "			<name> " & dtbDatos.Rows(i).Item(0).ToString.Trim & "</name>"
      lstr_documento_xml += "<description>" & "Latitud : " & dtbDatos.Rows(i).Item(1).ToString.Trim & Chr(13) & "Longitud : " & dtbDatos.Rows(i).Item(2).ToString.Trim & "</description>"
      lstr_documento_xml += "			<open>1</open>"
      lstr_documento_xml += "			<styleUrl>#msn_truck</styleUrl>"
      lstr_documento_xml += "			<Point>"
      lstr_documento_xml += "				<coordinates>" & dtbDatos.Rows(i).Item(2).ToString.Trim & "," & dtbDatos.Rows(i).Item(1).ToString.Trim & ",0</coordinates>"
      lstr_documento_xml += "			</Point>"
      lstr_documento_xml += "		</Placemark>"

      str_localizacion += dtbDatos.Rows(i).Item(2).ToString.Trim & "," & dtbDatos.Rows(i).Item(1).ToString.Trim & ", 0 "

      lint_indice += 1
Nextelement1:
    Next

    lstr_documento_xml += "	</Folder>"
    lstr_documento_xml += "</Document>"
    lstr_documento_xml += "</kml>"


    Try
      archivo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Ruta_" & HelpClass.TodayNumeric & "" & HelpClass.NowNumeric & ".kml"
      Dim oFile As New IO.StreamWriter(archivo, False, Encoding.ASCII)
      oFile.WriteLine(lstr_documento_xml)
      oFile.Close()
      Process.Start(archivo)
    Catch : End Try
  End Sub

    Private Sub ctbTransportista_InformationChanged() Handles ctbTransportista.InformationChanged
        Try
            Me.ctbVehiculo.pClearAll()
            Me.CargarTracto(ctbTransportista.pRucTransportista.Trim)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub ctbTransportista_ExitFocusWithOutData() Handles ctbTransportista.ExitFocusWithOutData
        Try
            If Me.ctbTransportista.pRucTransportista.Trim.Equals("") Then
                Me.ctbTransportista_InformationChanged()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

#Region "COMPAÑIA DIVISION Y PLANTA"

    Private Sub Cargar_Compania()
        'Try
        Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
        bolBuscar = False
        objCompaniaBLL.Crea_Lista()
        cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        'cmbCompania.SelectedValue = "EZ"
        'If cmbCompania.SelectedIndex = -1 Then
        '    cmbCompania.SelectedIndex = 0
        'End If

        bolBuscar = True
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cmbCompania_SelectedIndexChanged(Nothing, Nothing)
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub Cargar_Division()
        Dim objDivision As New NEGOCIO.Division_BLL
        'Try
        If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
            bolBuscar = False
            objDivision.Crea_Lista()
            cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            Me.cmbDivision.SelectedValue = "T"
            If Me.cmbDivision.SelectedIndex = -1 Then
                Me.cmbDivision.SelectedIndex = 0
            End If
            cmbDivision_SelectedIndexChanged(Nothing, Nothing)
        End If
        'Catch ex As Exception

        '    HelpClass.MsgBox(ex.Message)
        'End Try
    End Sub

  Private Sub Cargar_Planta()
    Dim objPlanta As New NEGOCIO.Planta_BLL
    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        'Try
        If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
            bolBuscar = False
            objPlanta.Crea_Lista()
            objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
            cmbPlanta.DataSource = objLisEntidad
            cmbPlanta.ValueMember = "CPLNDV"
            cmbPlanta.DisplayMember = "TPLNTA"
            bolBuscar = True
            cmbPlanta.SelectedIndex = 0
            cmbPlanta_SelectedIndexChanged(Nothing, Nothing)

        End If
        'Catch ex As Exception
        '        ' HelpClass.MsgBox(ex.Message)
        '    End Try

    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                Cargar_Division()
                If Me.cmbCompania.SelectedValue <> "EZ" Then Me.ctbTransportista.pClearAll()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                InicializarFormulario()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub InicializarFormulario()

        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
        ctbTransportista.pClear()
        Limpiar_Controles_OperacionTransporte()
        Estado_Controles_OperacionTransporte(False)
        If Me.cmbCompania.SelectedValue <> "EZ" Then Me.ctbTransportista.pClearAll()
        Me.ctbTransportista_InformationChanged()
        CargarControles()
        Me.gwdDatos.Rows.Clear()
    End Sub

    Private Sub Activar_Botones()
        Try
            Dim str_PestanaActiva As String
            str_PestanaActiva = Me.TabOperacion.SelectedTab.Name
            If str_PestanaActiva = "tabInformacion" Then
                btnGuardar.Text = "Modificar"
                btnEliminar.Enabled = True
                btnGuardar.Enabled = True
                btnAsignarGFH.Enabled = False
                dtpFechaUbicacion.Enabled = False
            Else
                btnEliminar.Enabled = True
                btnGuardar.Enabled = False
                btnAsignarGFH.Enabled = True
                dtpFechaUbicacion.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabOperacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabOperacion.SelectedIndexChanged
        Try
            Select Case Me.TabOperacion.SelectedIndex
                Case 0
                    Activar_Botones()
                Case 1
                    If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                        Me.TabOperacion.SelectedIndex = 0
                        MsgBox("Debe guardar la operación de transporte o cancelarla.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    Else
                        Activar_Botones()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnAsignarGFH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarGFH.Click
        Try
            Dim frmAsignarUbicacion As New frmAsignarGFH
            Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If lint_indice < 0 Then Exit Sub
            With frmAsignarUbicacion
                .Compania = cmbCompania.SelectedValue
                .Division = cmbDivision.SelectedValue
                .Planta = cmbPlanta.SelectedValue
                .NroRucTransportista = ctbTransportista.pRucTransportista.Trim
                .NroAcoplado = Me.gwdDatos.Item("Acoplado", lint_indice).Value.ToString().Trim()
                .NroPlacaUnidad = Me.gwdDatos.Item("Placa", lint_indice).Value.ToString().Trim()
                .CodTipoCarroceria = Me.gwdDatos.Item("CodTipoCarroceria", lint_indice).Value.ToString().Trim()
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.gwdDatos.Item("Acoplado", lint_indice).Value() = .NroAcoplado
                    Me.gwdDatos.Item("CodTipoCarroceria", lint_indice).Value() = .CodTipoCarroceria
                    Me.gwdDatos.Item("TipoCarroceria", lint_indice).Value() = .TipoCarroceria
                    Me.Cargar_Bitacora_Vehiculo()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

#End Region

    Private Sub dtpFechaUbicacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaUbicacion.ValueChanged
        Try
            Cargar_Bitacora_Vehiculo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Collections.Generic
Imports System.Text
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.MANTENIMIENTO


Public Class frmTransporteConsolidado

#Region "Atributos"

    Private ControlInformacion As New Control_InformacionSolicitud
    Private objFormBuscarOrdenServicio As frmBuscarOrdenServicio
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private bolBuscar As Boolean = False
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Dim TransporteConsolidadoBLL As New TransporteConsolidado_BLL
    Private oSeguridad As Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(USUARIO)
    Private intAccion As Int16 = 0
    Private _TipoOperacion As Int16 = 0
    Private pCTRMNC As Int32 = 0
    Private pNGUIRM As Int64 = 0
    Private pNRGUCL As Int64 = 0
    Private pFCGUCL As Date
    Private pLSTGRE As String = ""
    Private pCCMPN As String = ""
    Private pCTPOVJ As String = "C"
    Private pFechaAtencionServicio As Int32 = 0
    Private pCBRCNT As String = ""
#End Region

#Region "Eventos"


    Private Sub frmTransporteConsolidado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            gwGuiaTransporte.AutoGenerateColumns = False
            'Me.Validar_Acceso_Opciones_Usuario()
            Me.btnGuardar.Enabled = False
            Me.btnCancelar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.ckbRangoFechas.Checked = True
            Me.gwdDatos.AutoGenerateColumns = False
            Me.gwdSolicitud.AutoGenerateColumns = False
            Me.Estado_Controles(False)
            Me.ddlEstado.SelectedIndex = 1
            gintEstado = 0
            Me.Cargar_Compania()
            Me.Cargar_Combos()
            Me.Carga_MedioTransporte()
            Me.PanelInformacionSolicitud.Controls.Add(ControlInformacion)
            Me.ControlInformacion.Dock = DockStyle.Fill
            Me.ControlInformacion.TabSolicitudFlete.TabPages.RemoveAt(1)
            'Me.txtTracto.Tag = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                Cargar_Division()
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
                'Me.Listar()
                Me.CargarTransportista()
                Me.Cargar_Combos()
            End If
            Me.Limpiar_Controles()
            Me.gwdDatos.DataSource = Nothing
            Me.gwdSolicitud.DataSource = Nothing
            Me.gwGuiaTransporte.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

#End Region

#Region "Métodos"
    Private Sub Cargar_Compania()
        'Try
        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        bolBuscar = True
        'cmbCompania.SelectedValue = "EZ"
        'If cmbCompania.SelectedIndex = -1 Then
        '    cmbCompania.SelectedIndex = 0
        'End If
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cmbCompania_SelectedIndexChanged(Nothing, Nothing)
        'cmbCompania.DataSource = objCompaniaBLL.Lista
        'cmbCompania.ValueMember = "CCMPN"
        'cmbCompania.DisplayMember = "TCMPCM"

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Cargar_Division()
        'Try
        If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
            objDivision.Crea_Lista()
            bolBuscar = False
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
            Me.cmbPlanta.SelectedIndex = 0
            cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
        End If
        'Catch ex As Exception
        '    HelpClass.MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtTransportista.Enabled = lbool_Estado
        Me.txtTracto.Enabled = lbool_Estado
        Me.txtAcoplado.Enabled = lbool_Estado
        Me.dtpFechaViaje.Enabled = lbool_Estado
        Me.cboLugarorigen.Enabled = lbool_Estado
        Me.cboLugarDestino.Enabled = lbool_Estado
        Me.cboMedioTransporte.Enabled = lbool_Estado
        Me.txtObservaciones.Enabled = lbool_Estado
    End Sub

    Private Sub CargarTransportista()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        Me.txtTransportistaFiltro.pCargar(obeTransportista)
        Me.txtTransportista.pCargar(obeTransportista)
    End Sub

    Private Sub txtTransportista_InformationChanged() Handles txtTransportista.InformationChanged
        Me.txtTracto.pClear()
        Me.txtAcoplado.pClear()
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeTracto.pCDVSN_Division = Me.cmbDivision.SelectedValue
        obeTracto.pCPLNDV_Planta = Me.cmbPlanta.SelectedValue
        obeTracto.pNRUCTR_RucTransportista = Me.txtTransportista.pRucTransportista
        Me.txtTracto.pCargar(obeTracto)
        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
        obeAcoplado.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeAcoplado.pCDVSN_Division = Me.cmbDivision.SelectedValue
        obeAcoplado.pCPLNDV_Planta = Me.cmbPlanta.SelectedValue
        obeAcoplado.pNRUCTR_RucTransportista = Me.txtTransportista.pRucTransportista
        Me.txtAcoplado.pCargar(obeAcoplado)
    End Sub

    Private Sub txtTransportista_ExitFocusWithOutData() Handles txtTransportista.ExitFocusWithOutData
        Me.txtTransportista_InformationChanged()
    End Sub

    Private Function Asignar_Valor() As String
        Dim cadena As String = ""
        Select Case Me.ddlEstado.SelectedIndex
            Case 0
                cadena = ""
            Case 1
                cadena = "P"
            Case 2
                cadena = "C"
        End Select
        Return cadena
    End Function

#End Region

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            btnNuevo.Enabled = False
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.Enabled = True
            Me.btnCancelar.Enabled = True
            Me.btnEliminar.Enabled = False
            Limpiar_Controles()
            Estado_Controles(True)
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub Limpiar_Controles()
        'If Me.gwdDatos.Rows.Count > 0 Then
        '    Me.gwdDatos.CurrentCell = Nothing
        'End If
        'Try
        Me.dtpFechaViaje.Value = Date.Today
        Me.cboLugarorigen.Limpiar()
        Me.cboLugarDestino.Limpiar()
        Me.txtTransportista.pClear()
        Me.txtTracto.pClear()
        Me.txtAcoplado.pClear()
        Me.txtObservaciones.Clear()
        Me.gwdSolicitud.DataSource = Nothing
        'Me.gwGuiaTransporte.Rows.Clear()
        gwGuiaTransporte.DataSource = Nothing
        Me.cboMedioTransporte.SelectedValue = 4

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Select Case intAccion
                Case 0
                    If validate_fields() = True Then Exit Sub
                    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                        Me.Registrar_transporte()
                        Me.AccionCancelar()
                    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                        Me.Modificar_Transporte()
                        Me.AccionCancelar()
                    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                        Me.Estado_Controles(True)
                        Me.btnGuardar.Text = "Guardar"
                        Me.btnNuevo.Enabled = False
                        Me.btnCancelar.Enabled = True
                        Me.btnEliminar.Enabled = False
                        Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                        If Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString = "C" Then
                            Me.Estado_Controles(False)
                        End If
                    End If
                Case 1
                    Me.Modificar_Solicitud()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
    Private Sub Modificar_Transporte()
        Dim objTranporte As New TransporteConsolidado
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        objTranporte.CCMPN = cmbCompania.SelectedValue
        objTranporte.NMVJCS = Me.gwdDatos.Item("C_NMVJCS", lint_Indice).Value
        objTranporte.FCHVJC = CInt(HelpClass.CDate_a_Numero8Digitos(dtpFechaViaje.Value))
        objTranporte.CTRSPT = Me.txtTransportista.pCodigoRNS
        objTranporte.NPLCUN = Me.txtTracto.pNroPlacaUnidad
        objTranporte.NPLCAC = Me.txtAcoplado.pNroAcoplado
        objTranporte.CLCLOR = CType(Me.cboLugarorigen.Resultado, LocalidadRuta).CLCLD
        objTranporte.CLCLDS = CType(Me.cboLugarDestino.Resultado, LocalidadRuta).CLCLD
        objTranporte.CMEDTR = Me.cboMedioTransporte.SelectedValue
        objTranporte.TOBRCP = Me.txtObservaciones.Text
        objTranporte.CDVSN = Me.cmbDivision.SelectedValue
        objTranporte.CPLNDV = Me.cmbPlanta.SelectedValue
        objTranporte.CULUSA = MainModule.USUARIO
        objTranporte.FULTAC = HelpClass.TodayNumeric
        objTranporte.HULTAC = HelpClass.NowNumeric
        objTranporte.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        Dim strMensaje As String = TransporteConsolidadoBLL.Modificar_Transporte_Consolidado(objTranporte)
        If strMensaje.Length > 0 Then
            HelpClass.MsgBox(strMensaje, MessageBoxIcon.Information)
            Exit Sub
        Else
            HelpClass.MsgBox("Se Modificó correctamente el Traslado Consolidado ", MessageBoxIcon.Information)
            Cargar_Grilla()
        End If
    End Sub
    Private Sub Registrar_transporte()
        Dim objTranporte As New TransporteConsolidado
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

        objTranporte.CCMPN = cmbCompania.SelectedValue
        objTranporte.NMVJCS = 0
        objTranporte.FCHVJC = CInt(HelpClass.CDate_a_Numero8Digitos(dtpFechaViaje.Value))
        objTranporte.CTRSPT = Me.txtTransportista.pCodigoRNS
        objTranporte.NPLCUN = Me.txtTracto.pNroPlacaUnidad
        objTranporte.NPLCAC = Me.txtAcoplado.pNroAcoplado
        objTranporte.CLCLOR = CType(Me.cboLugarorigen.Resultado, LocalidadRuta).CLCLD
        objTranporte.CLCLDS = CType(Me.cboLugarDestino.Resultado, LocalidadRuta).CLCLD
        objTranporte.CMEDTR = Me.cboMedioTransporte.SelectedValue
        objTranporte.TOBRCP = Me.txtObservaciones.Text
        objTranporte.CDVSN = Me.cmbDivision.SelectedValue
        objTranporte.CPLNDV = Me.cmbPlanta.SelectedValue
        objTranporte.FLGSTS = "P" 'Asignar_Valor()
        objTranporte.SESTRG = "A"
        objTranporte.CUSCTR = MainModule.USUARIO
        objTranporte.FCHCRT = HelpClass.TodayNumeric
        objTranporte.HRACRT = HelpClass.NowNumeric
        objTranporte.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objTranporte.CULUSA = MainModule.USUARIO
        objTranporte.FULTAC = HelpClass.TodayNumeric
        objTranporte.HULTAC = HelpClass.NowNumeric
        objTranporte.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
       

        objTranporte = TransporteConsolidadoBLL.Registrar_Transporte_Consolidado(objTranporte)
        If objTranporte.NMVJCS = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            HelpClass.MsgBox("Se Registró Satisfactoriamente Traslado Consolidado N° " & objTranporte.NMVJCS)
            Me.txtNroVjeConsolidado.Text = objTranporte.NMVJCS
            Me.btnProcesarConsulta_Click(Nothing, Nothing)
            Me.btnCancelarSolicitud_Click(Nothing, Nothing)
        End If
    End Sub
    Private Function validate_fields() As Boolean
        Dim message As String = ""
        Dim aviso As Boolean = False
        If cboLugarorigen.Resultado Is Nothing Then
            message += "* LOCALIDAD DE ORIGEN" & vbNewLine
        End If
        If cboLugarDestino.Resultado Is Nothing Then
            message += "* LOCALIDAD DE DESTINO" & vbNewLine
        End If
        'If Me.dtpFechaViaje.Value Then
        '    message += "Debe ingresar una fecha valida" & vbNewLine
        'End If
        If txtTransportista.pRucTransportista = "" Then
            message += "* TRANSPORTISTA" & vbNewLine
        End If
        If txtTracto.pNroPlacaUnidad = "" Then
            message += "* TRACTO" & vbNewLine
        End If
        If Me.cboMedioTransporte.SelectedIndex < -1 Then
            message += "* MEDIO TRANSPORTE" & vbNewLine
        End If

        If message.Length > 0 Then
            HelpClass.MsgBox("COMPLETE LOS SIGUIENTES CAMPOS:" & Chr(13) & StrDup(45, "-") & Chr(13) & message, MessageBoxIcon.Exclamation)
            aviso = True
        End If
        Return aviso
    End Function
    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(cmbCompania.SelectedValue)
        Me.cboMedioTransporte.DataSource = objTabla.Copy
        Me.cboMedioTransporte.ValueMember = "CMEDTR"
        Me.cboMedioTransporte.DisplayMember = "TNMMDT"
    End Sub
    Private Sub Cargar_Combos()
        Dim objDt As List(Of LocalidadRuta)
        Dim obj_Logica_Localidad As New Localidad_BLL
        objDt = obj_Logica_Localidad.Listar_Localidades(cmbCompania.SelectedValue)


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        Me.cboLugarorigen.DataSource = objDt
        Me.cboLugarorigen.ListColumnas = oListColum
        Me.cboLugarorigen.Cargas()
        Me.cboLugarorigen.DispleyMember = "TCMLCL"
        Me.cboLugarorigen.ValueMember = "CLCLD"

        Dim oListColum2 As New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum2.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum2.Add(2, oColumnas)

        Me.cboLugarDestino.DataSource = objDt
        Me.cboLugarDestino.ListColumnas = oListColum2
        Me.cboLugarDestino.Cargas()
        Me.cboLugarDestino.DispleyMember = "TCMLCL"
        Me.cboLugarDestino.ValueMember = "CLCLD"

    End Sub

    Private Sub Cargar_Grilla()
        Dim objTranporte As New TransporteConsolidado
        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        objTranporte.CCMPN = cmbCompania.SelectedValue
        objTranporte.CDVSN = Me.cmbDivision.SelectedValue
        objTranporte.CPLNDV = Me.cmbPlanta.SelectedValue
        objTranporte.NMVJCS = IIf(Me.txtNroVjeConsolidado.Text = "", 0, Me.txtNroVjeConsolidado.Text)
        If objTranporte.NMVJCS > 0 Then
            objTranporte.FCHINI = 0
            objTranporte.FCHFIN = 0
        Else
            objTranporte.FCHINI = lstr_FecIni
            objTranporte.FCHFIN = lstr_FecFin
        End If
       
        objTranporte.FLGSTS = Asignar_Valor()
        objTranporte.CTRSPT = Me.txtTransportistaFiltro.pCodigoRNS
        objTranporte.NOPRCN = IIf(Me.txtNroOperacion.Text = "", 0, Me.txtNroOperacion.Text)
        gwdDatos.DataSource = TransporteConsolidadoBLL.Listar_Transporte_Consolidado(objTranporte)

    End Sub
    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Try
            Me.Limpiar_Controles()
            Me.Estado_Controles(False)
            Me.Cargar_Grilla()
            'Me.Cargar_Datos_Grilla()
            'Me.Cargar_Detalle_Solicitud()
            Me.btnNuevo.Enabled = True
        Catch ex As Exception
            Me.btnNuevo.Enabled = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


   

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim objTranporte As New TransporteConsolidado
            Select Case intAccion
                Case 0
                    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
                    If Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C" OrElse Me.gwdSolicitud.RowCount > 0 Then
                        HelpClass.MsgBox("No se puede eliminar el Traslado Consolidado Cerrada", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If MsgBox("Desea eliminar el Traslado Consolidado", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                    objTranporte.CCMPN = cmbCompania.SelectedValue
                    objTranporte.NMVJCS = Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
                    Dim strMensaje As String = TransporteConsolidadoBLL.Eliminar_Transporte_Consolidado(objTranporte)
                    If strMensaje.Trim.Length > 0 Then
                        HelpClass.MsgBox(strMensaje, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        HelpClass.MsgBox("Se Eliminó el Traslado Consolidado", MessageBoxIcon.Information)
                        Limpiar_Controles()
                        Cargar_Grilla()
                        Cargar_Datos_Grilla()
                    End If
                Case 1
                    If Me.gwdSolicitud.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
                    If Me.gwdSolicitud.Item("D_NGUITR", Me.gwdSolicitud.CurrentCellAddress.Y).Value <> 0 _
                      And Me.gwdSolicitud.Item("D_NMVJCS", Me.gwdSolicitud.CurrentCellAddress.Y).Value <> 0 Then _
                      'And Me.gwdSolicitud.Item("D_NMOPMM", Me.gwdSolicitud.CurrentCellAddress.Y).Value = 0 Then
                        HelpClass.MsgBox("No se puede eliminar tiene Guía de Transporte asignada", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    'If Me.gwdSolicitud.Item("D_NMOPMM", Me.gwdSolicitud.CurrentCellAddress.Y).Value = 0 Then
                    '    If MsgBox("Desea eliminar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                    'Else
                    '    If MsgBox("Desea Quitar esta Operación Multimodal", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                    'End If
                    Me.Eliminar_Solicitud("*")
                Case 2
                    If (Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
                        HelpClass.MsgBox("No permite Eliminar Guía de Transporte , Traslado Consolidado Cerrada", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If MsgBox("Desea eliminar esta Guía de Remisión", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                    Me.Eliminar_GuiaTransportista()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub Eliminar_GuiaTransportista()
        If Me.gwGuiaTransporte.RowCount = 0 Then Exit Sub
        Dim lstr_Mensaje As String = ""
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim objeto_Entidad As New ENTIDADES.mantenimientos.GuiaTransportista
        Dim objeto_Entidad_Consolidado As New TransporteConsolidado
        Dim objeto_Logica As New GuiaTransportista_BLL
        Dim objeto_Logica_Consolidado As New TransporteConsolidado_BLL
        Dim lint_Indice As Integer = Me.gwGuiaTransporte.CurrentCellAddress.Y


        objeto_Entidad.NCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        objeto_Entidad.CTRMNC = Me.gwdDatos.Item("C_CTRSPT", Me.gwdDatos.CurrentCellAddress.Y).Value
        objeto_Entidad.NGUIRM = Me.gwGuiaTransporte.Item("NMNFCR", lint_Indice).Value
        objeto_Entidad.NOPRCN = CType(Me.gwGuiaTransporte.Item("NOPRCN_1", lint_Indice).Value, Double)
        objeto_Entidad.CULUSA = MainModule.USUARIO
        objeto_Entidad.FULTAC = HelpClass.TodayNumeric
        objeto_Entidad.HULTAC = HelpClass.NowNumeric
        objeto_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objeto_Entidad.CCMPN = cmbCompania.SelectedValue

        If objeto_Logica_Consolidado.Eliminar_Guia_Remision_Servicio_Consolidado(objeto_Entidad) > 0 Then
            HelpClass.MsgBox("Se Eliminó la Guia Satisfactoriamente", MessageBoxIcon.Information)
            Me.gwdSolicitud.Item("D_NGUITR", Me.gwdSolicitud.CurrentCellAddress.Y).Value = 0
            Me.Listar_Guias_Transportista()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Else
            HelpClass.ErrorMsgBox()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub Eliminar_Solicitud(ByVal lstr_Estado As String)
        Dim objEntidad As New Solicitud_Transporte 'TransporteConsolidado
        Dim objSolicitudBLL As New Solicitud_Transporte_BLL
        'Try
        'objEntidad.NCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        'objEntidad.SESTRG = lstr_Estado
        'objEntidad.CULUSA = MainModule.USUARIO
        'objEntidad.FULTAC = HelpClass.TodayNumeric
        'objEntidad.HULTAC = HelpClass.NowNumeric
        'objEntidad.NTRMNL = HelpClass.NombreMaquina
        'objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        'objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        'objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        'objEntidad.NOPRCN = Me.gwdSolicitud.Item("D_NOPRCN", Me.gwdSolicitud.CurrentCellAddress.Y).Value

        'objEntidad.NMVJCS = Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
        'objEntidad.CTRSPT = Me.gwdDatos.Item("C_CTRSPT", Me.gwdDatos.CurrentCellAddress.Y).Value
        'objEntidad.NGUITR = Me.gwdSolicitud.Item("D_NGUITR", Me.gwdSolicitud.CurrentCellAddress.Y).Value

        'Dim lstrList As List(Of String) = objSolicitudBLL.Eliminar_Solicitud_Transporte_Consolidado(objEntidad)
        'HelpClass.MsgBox(lstrList(0), MessageBoxIcon.Information)




        objEntidad.NCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        objEntidad.NCRRSR = gwdSolicitud.Item("D_NCRRSR", gwdSolicitud.CurrentCellAddress.Y).Value
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = cmbCompania.SelectedValue
        '------------------------------------------------------------
        'Parametros nuevos
        objEntidad.PNOPAN_CGSTO = ""
        objEntidad.FLGAPG = ""
        objEntidad.NOPRCR = 0
        objEntidad.UATAOP = ""
        objEntidad.USLAOP = ""
        objEntidad.MOTAOP = ""
        objEntidad.OBSAOP = ""
        objEntidad.TRFSRC = ""
        '------------------------------------------------------------

        'Dim lstrList As List(Of String) = objSolicitudTransporte.Anulacion_Operacion_Transporte(objEntidad)
        'Dim dtresult As New DataTable
        Dim msgAlerta As String = ""
        Dim msgError As String = ""
        'Dim Codigo As String = ""
        'msgError = objSolicitudBLL.Anulacion_Operacion_Transporte_Salm(objEntidad, Codigo, msgAlerta)
        msgError = objSolicitudBLL.Anulacion_Operacion_Transporte_Salm(objEntidad, msgAlerta)
        'dtresult = objSolicitudBLL.Anulacion_Operacion_Transporte_Salm(objEntidad)
        'Dim codresult As String = ""
        'Dim msgresult As String = ""
        'If dtresult.Rows.Count > 0 Then
        '    codresult = dtresult.Rows(0)("STATUS")  'STATUS
        '    msgresult = dtresult.Rows(0)("OBSRESULT") 'OBSRESULT
        'End If

        If msgError.Length > 0 Then
            MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim msj As String = ""
        If msgAlerta.Length > 0 Then
            msj = (msgAlerta & Chr(13) & "Desea continuar con anulación de la operación?").Trim
        End If


        'If codresult = "6" Then

        'Dim msj As String = "Desea continuar con anulación de la operación con Gastos ?"
        'If MessageBox.Show(msgresult & vbCrLf & msj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        If MessageBox.Show(msj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim frmAnulacion As New frmAnularOperacion
            frmAnulacion.NCRRSR = gwdSolicitud.Item("D_NCRRSR", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.NCSOTR = gwdSolicitud.Item("D_NCSOTR", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.Operacion = gwdSolicitud.Item("D_NOPRCN", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.CCLINT = Me.gwdSolicitud.Item("D_CCLNT", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.CCMPN = cmbCompania.SelectedValue
            frmAnulacion.CDVSN = cmbDivision.SelectedValue
            If frmAnulacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'codresult = frmAnulacion.codigoresult
                Me.Cargar_Detalle_Solicitud()
                Me.Listar_Guias_Transportista()
            Else
                Exit Sub
            End If
            'Else
            '    Exit Sub
        End If
        'Else
        '    HelpClass.MsgBox(msgresult, MessageBoxIcon.Information)
        'End If


        'If codresult = "1" Then 'OrElse lstrList(1).Trim = "7" Then
        '    Me.Cargar_Detalle_Solicitud()
        '    Me.Listar_Guias_Transportista()
        'End If





        'If lstrList(1).Trim = "1" OrElse lstrList(1).Trim = "7" Then
        '    Me.Cargar_Detalle_Solicitud()
        '    Me.Listar_Guias_Transportista()
        '    'If Me.gwdSolicitud.RowCount = 0 Then
        '    '  Me.gwdDatos.Item("C_CBRCND", Me.gwdDatos.CurrentCellAddress.Y).Value = ""
        '    '  Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value = ""
        '    'End If
        'End If

        'If objEntidad.NCSOTR = "0" Then
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        'Else
        '  HelpClass.MsgBox("Se Eliminó la Solicitud Satisfactoriamente", MessageBoxIcon.Information)
        '  Me.Cargar_Detalle_Solicitud()
        '  If Me.gwdSolicitud.RowCount = 0 Then
        '    Me.gwdDatos.Item("C_CBRCND", Me.gwdDatos.CurrentCellAddress.Y).Value = ""
        '    Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value = ""
        '  End If
        'End If
        'Catch : End Try
    End Sub




    Private Sub Cargar_Datos_Grilla()
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        If lint_Indice < 0 Then
            Me.gwdSolicitud.DataSource = Nothing
            Exit Sub
        End If

        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK

        Me.cboMedioTransporte.SelectedValue = Me.gwdDatos.Item("C_CMEDTR", lint_Indice).Value.ToString
        Me.cboLugarorigen.Valor = Me.gwdDatos.Item("C_CLCLOR", lint_Indice).Value.ToString
        Me.cboLugarorigen.Refresh()
        Me.cboLugarDestino.Valor = Me.gwdDatos.Item("C_CLCLDS", lint_Indice).Value.ToString
        Me.cboLugarDestino.Refresh()

        obeTransportista.pNRUCTR_RucTransportista = Me.gwdDatos.Item("C_NRUCTR", lint_Indice).Value.ToString().Trim()
        obeTransportista.pCCMPN_Compania = cmbCompania.SelectedValue
        Me.txtTransportista.pCargar(obeTransportista)

        obeTracto.pNRUCTR_RucTransportista = Me.gwdDatos.Item("C_NRUCTR", lint_Indice).Value.ToString().Trim()
        obeTracto.pNPLCUN_NroPlacaUnidad = Me.gwdDatos.Item("C_NPLCUN", lint_Indice).Value.ToString().Trim()
        obeTracto.pCCMPN_Compania = cmbCompania.SelectedValue
        obeTracto.pCDVSN_Division = cmbDivision.SelectedValue
        obeTracto.pCPLNDV_Planta = cmbPlanta.SelectedValue
        Me.txtTracto.pCargar(obeTracto)

        obeAcoplado.pNRUCTR_RucTransportista = Me.gwdDatos.Item("C_NRUCTR", lint_Indice).Value.ToString().Trim()
        obeAcoplado.pNPLCAC_NroAcoplado = Me.gwdDatos.Item("C_NPLCAC", lint_Indice).Value.ToString().Trim()
        obeAcoplado.pCCMPN_Compania = cmbCompania.SelectedValue
        obeAcoplado.pCDVSN_Division = cmbDivision.SelectedValue
        obeAcoplado.pCPLNDV_Planta = cmbPlanta.SelectedValue
        Me.txtAcoplado.pCargar(obeAcoplado)

        Me.txtObservaciones.Text = Me.gwdDatos.Item("C_TOBRCP", lint_Indice).Value.ToString
        Me.dtpFechaViaje.Value = Me.gwdDatos.Item("C_FCHVJC_S", lint_Indice).Value.ToString
        'Me.Cargar_Detalle_Solicitud()

        If Me.gwdDatos.Item("C_FLGSTS", lint_Indice).Value.ToString = "C" OrElse Me.gwdSolicitud.RowCount > 0 Then
            If Me.tbConsolidado.SelectedIndex = 0 Then
                Me.btnGuardar.Text = "Guardar"
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
            End If
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
            Me.btnGuardar.Text = "Modificar"
            Me.btnGuardar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If

    End Sub
    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
    End Sub
    Private Sub AccionCancelar()
        Select Case Me.gEnum_Mantenimiento
            Case MANTENIMIENTO.NUEVO
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Me.Limpiar_Controles()
                Me.Estado_Controles(False)
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.gwdDatos.CurrentRow.Selected = False
                End If
                Me.btnNuevo.Enabled = True
                Me.btnGuardar.Enabled = False
                Me.btnCancelar.Enabled = False
                Me.btnEliminar.Enabled = False
            Case MANTENIMIENTO.MODIFICAR, MANTENIMIENTO.EDITAR
                Me.Limpiar_Controles()
                Me.Estado_Controles(False)
                Me.Cargar_Datos_Grilla()
                Me.btnNuevo.Enabled = True
        End Select

    End Sub

    'Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
    '    Try
    '        If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    '        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
    '        pCBRCNT = Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value
    '        Me.Limpiar_Controles()
    '        Me.Cargar_Detalle_Solicitud()
    '        Me.Listar_Guias_Transportista()
    '        Me.Cargar_Datos_Grilla()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub tbConsolidado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConsolidado.SelectedIndexChanged
        Try

            Select Case Me.tbConsolidado.SelectedIndex
                Case 0
                    If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then Exit Sub
                    intAccion = 0
                    Me.Estado_Accion()
                    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCell Is Nothing OrElse Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString = "C" OrElse Me.gwdSolicitud.RowCount > 0 Then
                        Me.btnGuardar.Text = "Guardar"
                        Me.btnGuardar.Enabled = False
                        Me.btnEliminar.Enabled = False
                        Me.btnImportar.Visible = False
                    End If
                Case 1
                    If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                        Me.tbConsolidado.SelectedIndex = 0
                        Exit Sub
                    End If
                    intAccion = 1
                    Me.Estado_Accion()
                    Me.btnGuardar.Text = "Modificar"
                    Me.btnGuardar.Enabled = True
                    Me.btnEliminar.Enabled = True
                    Me.btnImportar.Visible = True
                Case 2
                    If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                        Me.tbConsolidado.SelectedIndex = 0
                        Exit Sub
                    End If
                    intAccion = 2
                    Me.Estado_Accion()
                    Me.btnGuardar.Text = "Modificar"
                    Me.btnGuardar.Enabled = True
                    Me.btnEliminar.Enabled = True
                    'Me.btnEliminar.Visible = True
                    Me.btnImportar.Visible = False
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Estado_Accion()
        Me.btnNuevo.Visible = IIf(intAccion = 0, True, False)
        Me.btnGuardar.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.btnCancelar.Visible = IIf(intAccion = 0, True, False)
        Me.btnEliminar.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.btnAsignarSolicitud.Visible = IIf(intAccion = 1, True, False)
        Me.btnGuiaTransporte.Visible = IIf(intAccion = 1, True, False)

        Me.Separator1.Visible = IIf(intAccion = 0, True, False)
        Me.Separator2.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.Separator3.Visible = IIf(intAccion = 0, True, False)
        Me.Separator4.Visible = IIf(intAccion = 1, True, False)
        Me.Separator5.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.Separator10.Visible = IIf(intAccion = 1, True, False)
        If Me.btnGuiaTransporte.Tag = 0 Then
            Me.btnGuiaTransporte.Visible = IIf(intAccion = 1, True, False)
        End If
        If Me.btnExportarExcel.Tag = 0 Then
            Me.btnExportarExcel.Visible = IIf(intAccion = 0, True, False)
        End If
    End Sub

    Private Sub btnAsignarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarSolicitud.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub

        If (Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
            HelpClass.MsgBox("No se Permite Asignar Solicitud ,  Traslado Consolidado cerrado", MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            If Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value = "" Then
                Dim frmConductor As New frmConsultaConductor
                Dim strCBRCNT As String = ""
                With frmConductor
                    .CCMPN = Me.cmbCompania.SelectedValue
                    .CDVSN = Me.cmbDivision.SelectedValue
                    .CPLNDV = Me.cmbPlanta.SelectedValue
                    .CTRSPT = Me.txtTransportista.pCodigoRNS
                    .NRUCTR = Me.txtTransportista.pRucTransportista
                    .pRazonSocial = Me.txtTransportista.pRazonSocial
                    .CMEDTR = Me.gwdDatos.Item("C_CMEDTR", Me.gwdDatos.CurrentCellAddress.Y).Value
                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    'Me.txtTracto.Tag = .CBRCNT
                    pCBRCNT = .CBRCNT.Trim
                    Me.pFechaAtencionServicio = HelpClass.CtypeDate(.dtpFechaAtencionServicio.Value)
                End With
            Else
                '  Me.txtTracto.Tag = Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value
                pCBRCNT = Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value
                If gwdSolicitud.Rows.Count > 0 Then
                    Me.pFechaAtencionServicio = gwdSolicitud.Rows(0).Cells("FATNSR").Value
                End If

            End If
            Me.panelVjeConsolidado.Visible = False
            Me.PanelFiltros.Enabled = False
            Me.gwdDatos.Enabled = False
            Me.btnCancelarSolicitud.Text = " Cancelar"
            Me._TipoOperacion = 2
            ControlInformacion.CCMPN = Me.cmbCompania.SelectedValue
            ControlInformacion.pCDVSN = Me.cmbDivision.SelectedValue
            ControlInformacion.pCPLNDV = Me.cmbPlanta.SelectedValue
            ControlInformacion.TipoOperacion = Me._TipoOperacion
            ControlInformacion.OPCION = 0

            'Codigo agregado por MREATEGUIP - Ajuste Moneda
            '----- Ini -----
            ControlInformacion.pCTPOVJ = Me.pCTPOVJ
            ControlInformacion.pNOPRCN = Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
            '----- Fin -----

            Me.Limpiar_Controles_Solicitud()
            ControlInformacion.cboMedioTransporte.SelectedValue = Me.gwdDatos.Item("C_CMEDTR", Me.gwdDatos.CurrentCellAddress.Y).Value
            Me.ActivarEstado_Solicitud(True)
            'controlInformacion.txtCliente.pCargar(Me.gwdDatos.Item("C_CTRSPT", Me.gwdDatos.CurrentCellAddress.Y).Value)
            'If (txtTransportista.pCodigoRNS = 0) Then
            '    Me.controlInformacion.txtCliente.Enabled = True
            'Else
            '    Me.controlInformacion.txtCliente.Enabled = False
            'End If
            Me.ControlInformacion.txtCantidadSolicitada.Enabled = False
            Me.ControlInformacion.txtCantidadSolicitada.Text = 1
            Me.panelSolicitudVjeConsolidado.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Limpiar_Controles_Solicitud()
        ControlInformacion.dtpFechaSolicitud.Value = Date.Now.Date
        'ControlInformacion.ctlLocalidadOrigen.Limpiar()
        ControlInformacion.txt_localidad_origen.Text = ""
        ControlInformacion.txtDireccionLocalidadCarga.Text = ""
        'ControlInformacion.ctlLocalidadDestino.Limpiar()
        ControlInformacion.txt_localidad_destino.Text = ""
        ControlInformacion.txtDireccionLocalidadEntrega.Text = ""
        ControlInformacion.txtCantidadSolicitada.Text = ""
        ControlInformacion.txtTipoServicio.Limpiar()
        ControlInformacion.ctlTipoVehiculo.Limpiar()
        ControlInformacion.ctbMercaderias.Limpiar()
        'ControlInformacion.txtUnidadMedida.Limpiar()
        ControlInformacion.txtUnidadMed.Text = ""
        ControlInformacion.txtCantidadMercaderia.Text = ""
        ControlInformacion.txtObservaciones.Text = ""
        ControlInformacion.txtHoraCarga.Text = "00:00:00"
        ControlInformacion.txtHoraEntrega.Text = "00:00:00"
        ControlInformacion.txtFechaSolicitud.Text = ""
        ControlInformacion.txtFechaEntrega.Text = ""
        ControlInformacion.txtFechaCarga.Text = ""
        ControlInformacion.txtOrdenServicio.Text = ""
        ControlInformacion.txtUsuarioSolicitante.Text = ""
        ControlInformacion.txtCliente.pClear()

    End Sub

    Private Sub ActivarEstado_Solicitud(ByVal lbool_Estado As Boolean)

        Select Case _TipoOperacion
            Case 0
                ControlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
                ControlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
                ControlInformacion.txtOrdenServicio.Enabled = lbool_Estado
                ControlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
                ControlInformacion.txtObservaciones.Enabled = lbool_Estado
                ControlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
                ControlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
            Case Else
                ControlInformacion.txtCliente.Enabled = lbool_Estado
                ControlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
                ControlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
                ControlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
                ControlInformacion.txtTipoServicio.Enabled = lbool_Estado
                ControlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
                ControlInformacion.ctbMercaderias.Enabled = lbool_Estado
                'ControlInformacion.txtUnidadMedida.Enabled = lbool_Estado
                ControlInformacion.txtUnidadMed.Enabled = lbool_Estado
                ControlInformacion.txtCantidadMercaderia.Enabled = lbool_Estado
                ControlInformacion.dtpFechaSolicitud.Enabled = lbool_Estado
                ControlInformacion.dtpFechaInicioCarga.Enabled = lbool_Estado
                ControlInformacion.dtpFinCarga.Enabled = lbool_Estado
                ControlInformacion.txtObservaciones.Enabled = lbool_Estado
                ControlInformacion.txtHoraCarga.Enabled = lbool_Estado
                ControlInformacion.txtHoraEntrega.Enabled = lbool_Estado
                ControlInformacion.txtOrdenServicio.Enabled = lbool_Estado
                ControlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
                ControlInformacion.btnLimpiarOS.Enabled = lbool_Estado
                ControlInformacion.cmbTipoSolicitud.Enabled = lbool_Estado
                'controlInformacion.cboMedioTransporte.Enabled = lbool_Estado
        End Select
    End Sub

    Private Sub btnGuardarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarSolicitud.Click
        Try
            If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim tabla() As String = Split(Me.gwdDatos.Item("C_RUTA", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim, "<->")
            Select Case _TipoOperacion
                Case 0, 1
                    If Not Me.Validar_Input_Solicitud Then
                        Me.Modificar_Registro_Solicitud()
                    End If
                Case 2, 4
                    If Not Me.Validar_Input_Solicitud Then
                        'If tabla(0).Equals(ControlInformacion.ctlLocalidadOrigen.Descripcion) And tabla(1).Equals(ControlInformacion.ctlLocalidadDestino.Descripcion) Then
                        If tabla(0).Equals(ControlInformacion.txt_localidad_origen.Text.Trim.ToUpper) And tabla(1).Equals(ControlInformacion.txt_localidad_destino.Text.Trim.ToUpper) Then
                            Dim objNegocio As New TransporteConsolidado_BLL
                            Dim objEntidad As New TransporteConsolidado
                            Dim strMensaje As String = ""
                            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                            objEntidad.NMVJCS = Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
                            strMensaje = objNegocio.Validar_Estado_Traslado_Consolidado(objEntidad).SESSLC
                            If strMensaje.Trim.Length > 0 Then
                                HelpClass.MsgBox(strMensaje, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            Me.Nuevo_Registro_Solicitud()
                        Else
                            MessageBox.Show("El Lugar de Origen y Destino de la programación de Traslado, no coinciden con la Solicitud de Servicio", "SOLMIN_ST", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.ControlInformacion.txtOrdenServicio.Focus()
                            Exit Sub
                        End If
                    End If
            End Select
            pFechaAtencionServicio = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub
    Private Function Validar_Input_Solicitud() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If ControlInformacion.txtCliente.pCodigo = 0 Then
            lstr_validacion += "* CLIENTE " & Chr(13)
        End If
        'If ControlInformacion.ctlLocalidadOrigen.NoHayCodigo = True Then
        If ("" & ControlInformacion.txt_localidad_origen.Tag) = "" Then
            lstr_validacion += "* LOCALIDAD DE CARGA " & Chr(13)
        End If
        If ControlInformacion.txtDireccionLocalidadCarga.Text = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE CARGA " & Chr(13)
        End If
        If ControlInformacion.ctbMercaderias.NoHayCodigo = True Then
            lstr_validacion += "* MERCADERIA DE TRANSLADO " & Chr(13)
        End If
        'If ControlInformacion.ctlLocalidadDestino.NoHayCodigo = True Then
        If ("" & ControlInformacion.txt_localidad_destino.Tag) = "" Then
            lstr_validacion += "* LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If ControlInformacion.txtDireccionLocalidadEntrega.Text = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If ControlInformacion.txtOrdenServicio.Text = "" Then
            lstr_validacion += "* ORDEN DE SERVICIO" & Chr(13)
        End If
        If ControlInformacion.txtCantidadSolicitada.Text = "" Or IsNumeric(ControlInformacion.txtCantidadSolicitada.Text) = False Then
            lstr_validacion += "* CANTIDAD DE VEHICULOS" & Chr(13)
        End If
        If ControlInformacion.txtTipoServicio.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE SERVICIO" & Chr(13)
        End If
        If ControlInformacion.ctlTipoVehiculo.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE VEHICULO" & Chr(13)
        End If
        'If ControlInformacion.txtUnidadMedida.NoHayCodigo = True Then
        If ControlInformacion.txtUnidadMed.Text = "" Then
            lstr_validacion += "* UNIDAD DE MEDIDA DE MERCADERIA" & Chr(13)
        End If

        If HelpClass.CtypeDate(ControlInformacion.dtpFechaSolicitud.Value) > HelpClass.CtypeDate(ControlInformacion.dtpFinCarga.Value) Then
            lstr_validacion += "* FECHA SOLICITUD MAYOR A FECHA DE ENTREGA" & Chr(13)
        End If
        If HelpClass.CFecha_a_Numero8Digitos(ControlInformacion.dtpFechaInicioCarga.Value.ToShortDateString) > HelpClass.CFecha_a_Numero8Digitos(ControlInformacion.dtpFinCarga.Value.ToShortDateString) Then
            lstr_validacion += "* FECHA DE CARGA MAYOR A FECHA DE ENTREGA" & Chr(13)
        End If

        If ControlInformacion.txtUsuarioSolicitante.Text = "" Then
            lstr_validacion += "* USUARIO SOLICITANTE" & Chr(13)
        End If


        If lstr_validacion <> "" Then
            HelpClass.MsgBox("COMPLETE LOS SIGUIENTES CAMPOS :" & Chr(13) & StrDup(45, "-") & Chr(13) & lstr_validacion, MessageBoxIcon.Exclamation)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function
    Private Sub Modificar_Registro_Solicitud()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New TransporteConsolidado
        Dim objSolicitudTransporte As New TransporteConsolidado_BLL
        'Try
        objEntidad.NCSOTR = ControlInformacion.Codigo.Text
        objEntidad.NORSRT = IIf(ControlInformacion.txtOrdenServicio.Text = "", 0, ControlInformacion.txtOrdenServicio.Text)
        objEntidad.CCLNT = ControlInformacion.txtCliente.pCodigo
        objEntidad.CMRCDR = ControlInformacion.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.FECOST = HelpClass.CtypeDate(ControlInformacion.dtpFechaSolicitud.Value)
        'objEntidad.CLCLOR = ControlInformacion.ctlLocalidadOrigen.Codigo
        objEntidad.CLCLOR = ControlInformacion.txt_localidad_origen.Tag
        objEntidad.TDRCOR = ControlInformacion.txtDireccionLocalidadCarga.Text
        'objEntidad.CLCLDS = ControlInformacion.ctlLocalidadDestino.Codigo
        objEntidad.CLCLDS = ControlInformacion.txt_localidad_destino.Tag
        objEntidad.TDRENT = ControlInformacion.txtDireccionLocalidadEntrega.Text
        'objEntidad.CUNDMD = ControlInformacion.txtUnidadMedida.Codigo
        objEntidad.CUNDMD = ControlInformacion.txtUnidadMed.Text
        objEntidad.QSLCIT = IIf(ControlInformacion.txtCantidadSolicitada.Text = "", "0", ControlInformacion.txtCantidadSolicitada.Text)
        objEntidad.QATNAN = "0"
        objEntidad.FINCRG = HelpClass.CtypeDate(ControlInformacion.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(ControlInformacion.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(ControlInformacion.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(ControlInformacion.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(ControlInformacion.txtCantidadMercaderia.Text = "", "0", ControlInformacion.txtCantidadMercaderia.Text)
        objEntidad.CTPOSR = ControlInformacion.txtTipoServicio.Codigo
        objEntidad.CUNDVH = ControlInformacion.ctlTipoVehiculo.Codigo
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        objEntidad.SFCRTV = ControlInformacion.cmbTipoSolicitud.SelectedValue
        objEntidad.TOBS = ControlInformacion.txtObservaciones.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CMEDTR = ControlInformacion.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = ControlInformacion.txtCentroCostoCliente.Text.Trim
        objEntidad.TRFRN = ControlInformacion.txtUsuarioSolicitante.Text
        objEntidad.SPRSTR = "N"
        objEntidad.CTTRAN = CType(ControlInformacion.ucNivelServ.Resultado, ENTIDADES.consultas.AtributosOI).Codigo
        objEntidad.CTIPCG = CType(ControlInformacion.ucTipoCarga.Resultado, ENTIDADES.consultas.AtributosOI).Codigo

        objEntidad = objSolicitudTransporte.Modificar_Solicitud_Transporte_Consolidado(objEntidad)
        If objEntidad.NCSOTR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            HelpClass.MsgBox("Solicitud Modificada Satisfactoriamente", MessageBoxIcon.Information)
        End If
        'Catch : End Try
    End Sub
    Private Sub Nuevo_Registro_Solicitud()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New TransporteConsolidado
        Dim objAsignarSolicitud As New TransporteConsolidado_BLL
        Dim oSeguridad As NEGOCIO.Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(MainModule.USUARIO)
        Dim mensaje As String = oSeguridad.VerificarLineaCreditoCliente(Me.cmbCompania.SelectedValue, ControlInformacion.txtCliente.pCodigo)
        If mensaje.ToString() <> "" Then
            MessageBox.Show(mensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Try
        objEntidad.NCSOTR = "0"
        objEntidad.CBRCNT = pCBRCNT 'Me.txtTracto.Tag
        objEntidad.CCLNT = ControlInformacion.txtCliente.pCodigo
        objEntidad.CMRCDR = ControlInformacion.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.NORSRT = IIf(ControlInformacion.txtOrdenServicio.Text = "", 0, ControlInformacion.txtOrdenServicio.Text)
        objEntidad.FECOST = HelpClass.CtypeDate(ControlInformacion.dtpFechaSolicitud.Value)
        'objEntidad.CLCLOR = ControlInformacion.ctlLocalidadOrigen.Codigo
        objEntidad.CLCLOR = ControlInformacion.txt_localidad_origen.Tag
        objEntidad.TDRCOR = ControlInformacion.txtDireccionLocalidadCarga.Text
        'objEntidad.CLCLDS = ControlInformacion.ctlLocalidadDestino.Codigo
        objEntidad.CLCLDS = ControlInformacion.txt_localidad_destino.Tag
        objEntidad.TDRENT = ControlInformacion.txtDireccionLocalidadEntrega.Text
        'objEntidad.CUNDMD = ControlInformacion.txtUnidadMedida.Codigo
        objEntidad.CUNDMD = ControlInformacion.txtUnidadMed.Text
        objEntidad.QSLCIT = IIf(ControlInformacion.txtCantidadSolicitada.Text = "", "0", ControlInformacion.txtCantidadSolicitada.Text)
        objEntidad.QATNAN = "0"
        objEntidad.FINCRG = HelpClass.CtypeDate(ControlInformacion.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(ControlInformacion.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(ControlInformacion.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(ControlInformacion.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(ControlInformacion.txtCantidadMercaderia.Text = "", "0", ControlInformacion.txtCantidadMercaderia.Text)
        objEntidad.SESTRG = "A"
        objEntidad.CTPOSR = ControlInformacion.txtTipoServicio.Codigo
        objEntidad.CUNDVH = ControlInformacion.ctlTipoVehiculo.Codigo
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.TOBS = ControlInformacion.txtObservaciones.Text
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        objEntidad.SFCRTV = ControlInformacion.cmbTipoSolicitud.SelectedValue
        objEntidad.NMOPMM = 0
        objEntidad.NMOPRP = 0
        objEntidad.NMVJCS = Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
        objEntidad.CMEDTR = ControlInformacion.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = ControlInformacion.txtCentroCostoCliente.Text.Trim
        objEntidad.TRFRN = ControlInformacion.txtUsuarioSolicitante.Text
        objEntidad.CTPOVJ = Me.pCTPOVJ
        objEntidad.SPRSTR = "N"
        objEntidad.CTTRAN = CType(ControlInformacion.ucNivelServ.Resultado, ENTIDADES.consultas.AtributosOI).Codigo
        objEntidad.CTIPCG = CType(ControlInformacion.ucTipoCarga.Resultado, ENTIDADES.consultas.AtributosOI).Codigo

        objEntidad = objAsignarSolicitud.Registrar_Solicitud_Transporte_Consolidado(objEntidad)
        If objEntidad.NCSOTR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            'Me.Generar_Junta_Transporte(objEntidad.NCSOTR, pCBRCNT) 'Me.txtTracto.Tag)
            Generar_Detalle_Solicitud_Transporte(objEntidad.NCSOTR, pCBRCNT)

            HelpClass.MsgBox("Se Registró Satisfactoriamente la Solicitud N° " & objEntidad.NCSOTR)
            Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"

            Me.btnCancelarSolicitud_Click(Nothing, Nothing)
            Me.Cargar_Detalle_Solicitud()
            Me.gwdDatos.Item("C_CBRCND", Me.gwdDatos.CurrentCellAddress.Y).Value = Me.gwdSolicitud.Item("D_CBRCND", Me.gwdSolicitud.CurrentCellAddress.Y).Value.ToString
            Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value = pCBRCNT 'Me.txtTracto.Tag
        End If
        'Catch : End Try

    End Sub

    'Private Sub Generar_Junta_Transporte(ByVal intNCSOTR As Int64, ByVal strCBRCNT As String)
    '    'Try
    '    Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
    '    Dim Objeto_Logica As New Junta_Transporte_BLL
    '    Objeto_Entidad.NCSOTR = intNCSOTR
    '    Objeto_Entidad.CCLNT = ControlInformacion.txtCliente.pCodigo
    '    Objeto_Entidad.NRUCTR = Me.txtTransportista.pRucTransportista
    '    Objeto_Entidad.NPLCUN = Me.txtTracto.pNroPlacaUnidad
    '    Objeto_Entidad.NPLCAC = Me.txtAcoplado.pNroAcoplado
    '    Objeto_Entidad.CBRCNT = strCBRCNT
    '    Objeto_Entidad.CBRCN2 = ""
    '    Objeto_Entidad.CUSCRT = MainModule.USUARIO
    '    Objeto_Entidad.FCHCRT = HelpClass.TodayNumeric
    '    Objeto_Entidad.HRACRT = HelpClass.NowNumeric
    '    Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    '    Objeto_Entidad.CCMPN = Me.cmbCompania.SelectedValue
    '    Objeto_Entidad.CDVSN = Me.cmbDivision.SelectedValue
    '    Objeto_Entidad.CPLNDV = Me.cmbPlanta.SelectedValue
    '    Objeto_Entidad.NPLNJT = Objeto_Logica.Registrar_Junta_Transporte_Manual(Objeto_Entidad).NPLNJT
    '    If Objeto_Entidad.NPLNJT = "0" Then
    '        HelpClass.ErrorMsgBox()
    '        Exit Sub
    '    End If
    '    Dim lobj_Entidad As New Detalle_Solicitud_Transporte
    '    lobj_Entidad.NPLNJT = CType(Objeto_Entidad.NPLNJT, Double)
    '    lobj_Entidad.NCRRPL = 0
    '    lobj_Entidad.NCRRSR = CType(Objeto_Entidad.NCRRSR, Double)
    '    lobj_Entidad.NCSOTR = intNCSOTR
    '    lobj_Entidad.CBRCNT = strCBRCNT
    '    Me.Registrar_Operacion_Transporte(lobj_Entidad)
    '    'Catch : End Try
    'End Sub


    Private Sub Generar_Detalle_Solicitud_Transporte(intNCSOTR As Decimal, strCBRCNT As String)

        'Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
        'Dim Objeto_Logica As New Junta_Transporte_BLL
        'Objeto_Entidad.NCSOTR = Me._obj_Entidad.NCSOTR
        'Objeto_Entidad.CCLNT = Me._obj_Entidad.CCLNT
        'Objeto_Entidad.NRUCTR = Me.cboTransportista.pRucTransportista

        'Objeto_Entidad.NPLCUN = Me.cboTracto.pNroPlacaUnidad
        'Objeto_Entidad.NPLCAC = Me.cboAcoplado.pNroAcoplado

        'Objeto_Entidad.CBRCNT = Me.cmbConductor.pBrevete
        'Objeto_Entidad.CBRCN2 = Me.cmbSegundoConductor.pBrevete
        'Objeto_Entidad.CUSCRT = MainModule.USUARIO
        ''Objeto_Entidad.FCHCRT = HelpClass.TodayNumeric
        ''Objeto_Entidad.HRACRT = HelpClass.NowNumeric
        'Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        'Objeto_Entidad.CCMPN = Me._obj_Entidad.CCMPN
        'Objeto_Entidad.CDVSN = Me._obj_Entidad.CDVSN
        'Objeto_Entidad.CPLNDV = Me._obj_Entidad.CPLNDV

        'Objeto_Entidad.NPLNMT = oRespuestaOP.NPLNMT
        'Objeto_Entidad.NCRRPL = oRespuestaOP.NCRRPL
        'Objeto_Entidad.NSBCRP = oRespuestaOP.NSBCRP


        'Dim msg As String = ""
        'Dim oRespuesta As New beRespuestaOperacion
        'oRespuesta = Objeto_Logica.Registrar_Detalle_Solicitud_Transporte(Objeto_Entidad, msg)
        'If msg.Length > 0 Then
        '    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        'Me._obj_Entidad.NCRRSR = oRespuesta.NCRRSR


        Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
        Dim Objeto_Logica As New Junta_Transporte_BLL
        Objeto_Entidad.NCSOTR = intNCSOTR
        Objeto_Entidad.CCLNT = ControlInformacion.txtCliente.pCodigo
        Objeto_Entidad.NRUCTR = Me.txtTransportista.pRucTransportista
        Objeto_Entidad.NPLCUN = Me.txtTracto.pNroPlacaUnidad
        Objeto_Entidad.NPLCAC = Me.txtAcoplado.pNroAcoplado
        Objeto_Entidad.CBRCNT = strCBRCNT
        Objeto_Entidad.CBRCN2 = ""
        Objeto_Entidad.CUSCRT = MainModule.USUARIO
        'Objeto_Entidad.FCHCRT = HelpClass.TodayNumeric
        'Objeto_Entidad.HRACRT = HelpClass.NowNumeric
        Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        Objeto_Entidad.CCMPN = Me.cmbCompania.SelectedValue
        Objeto_Entidad.CDVSN = Me.cmbDivision.SelectedValue
        Objeto_Entidad.CPLNDV = Me.cmbPlanta.SelectedValue

        Dim msg As String = ""
        Dim oRespuesta As New beRespuestaOperacion
        oRespuesta = Objeto_Logica.Registrar_Detalle_Solicitud_Transporte(Objeto_Entidad, msg)
        'Objeto_Entidad.NPLNJT = Objeto_Logica.Registrar_Junta_Transporte_Manual(Objeto_Entidad).NPLNJT
        If msg.Length > 0 Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'If Objeto_Entidad.NPLNJT = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'End If
        Dim lobj_Entidad As New Detalle_Solicitud_Transporte
        'lobj_Entidad.NPLNJT = CType(Objeto_Entidad.NPLNJT, Double)
        'lobj_Entidad.NCRRPL = 0
        lobj_Entidad.NCRRSR = oRespuesta.NCRRSR
        lobj_Entidad.NCSOTR = intNCSOTR
        lobj_Entidad.CBRCNT = strCBRCNT
        Me.Registrar_Operacion_Transporte(lobj_Entidad)




    End Sub





    Private Sub Registrar_Operacion_Transporte(ByVal obj_Entidad As Detalle_Solicitud_Transporte)
        'Try
        'Dim objEntidad As New List(Of String)
        Dim objOperacionTransporte As New OperacionTransporte_BLL
        'Dim lstr_resultado As String = ""
        'Dim objListaTemporal As New List(Of String)
        'Dim objEntidadOperacion As New OperacionTransporte
        'objEntidad.Add(obj_Entidad.NPLNJT)
        'objEntidad.Add(obj_Entidad.NCRRPL)
        'objEntidad.Add(obj_Entidad.NCSOTR)
        'objEntidad.Add(obj_Entidad.NCRRSR)
        'objEntidad.Add(Me.ControlInformacion.txtOrdenServicio.Text)
        'objEntidad.Add(Me.cmbCompania.SelectedValue)
        'objEntidad.Add(Me.cmbDivision.SelectedValue)
        'objEntidad.Add(Me.cmbPlanta.SelectedValue)
        'objEntidad.Add(MainModule.USUARIO)
        'objEntidad.Add(HelpClass.TodayNumeric)
        'objEntidad.Add(HelpClass.NowNumeric)
        'objEntidad.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
        'objEntidad.Add("NUEVO")
        'objEntidad.Add("")
        'objEntidad.Add(0)
        'objEntidad.Add("")
        'objEntidad.Add(pFechaAtencionServicio)
        'objEntidad.Add(Me.pCTPOVJ)
        

        Dim oParam_OP As New ENTIDADES.beRespuestaOperacion
        oParam_OP.NCSOTR = obj_Entidad.NCSOTR
        oParam_OP.NCRRSR = obj_Entidad.NCRRSR
        oParam_OP.NORSRT = Me.ControlInformacion.txtOrdenServicio.Text
        oParam_OP.CCMPN = Me.cmbCompania.SelectedValue
        oParam_OP.CDVSN = Me.cmbDivision.SelectedValue
        oParam_OP.CPLNDV = Me.cmbPlanta.SelectedValue
        oParam_OP.CUSCRT = MainModule.USUARIO
        oParam_OP.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        oParam_OP.TIPO_REGISTRO = "NUEVO"
        oParam_OP.SORGMV = ""
        oParam_OP.NDCORM = 0
        oParam_OP.PNCDTR = ""
        oParam_OP.FATNSR = pFechaAtencionServicio
        oParam_OP.CTPOVJ = Me.pCTPOVJ


        Dim oRespuestaOP As New ENTIDADES.beRespuestaOperacion
        Dim msgErrorOP As String = ""
        'lstr_resultado = objOperacionTransporte.Registrar_Operacion_Transporte(objEntidad)
        oRespuestaOP = objOperacionTransporte.Registrar_Operacion_Transporte(oParam_OP, msgErrorOP)

        If msgErrorOP.Length > 0 Then
            MessageBox.Show(msgErrorOP, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Generar_Orden_Interna(oRespuestaOP)

        'If IsNumeric(lstr_resultado) Then
        '    If lstr_resultado.Trim.Equals("-1") OrElse lstr_resultado.Trim.Equals("0") Then
        '        HelpClass.ErrorMsgBox()
        '        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        '        Exit Sub
        '    Else
        '        'Me.Generar_Orden_Interna(CType(lstr_resultado, Double), obj_Entidad.CBRCNT)
        '        Me.Generar_Orden_Interna(oRespuesta)
        '        'oRespuesta As ENTIDADES.beRespuestaOperacion
        '    End If
        'Else
        '    HelpClass.MsgBox(lstr_resultado, MessageBoxIcon.Error)
        'End If
        'Catch ex As Exception
        '    HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Cargar_Detalle_Solicitud()
        ' Dim dwvrow As DataGridViewRow
        Dim objEntidad As New TransporteConsolidado
        Dim objSolicitudTransporte As New TransporteConsolidado_BLL
        'Dim objData As DataRow
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        objEntidad.NMVJCS = Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue.ToString.Trim
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        objEntidad.NRUCTR = Me.gwdDatos.Item("C_NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        objEntidad.NPLCUN = Me.gwdDatos.Item("C_NPLCUN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        objEntidad.NPLCAC = Me.gwdDatos.Item("C_NPLCAC", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()

        Me.gwdSolicitud.DataSource = objSolicitudTransporte.Listar_Solicitudes_Transporte_Consolidado(objEntidad)
    End Sub


    Private Sub Generar_Orden_Interna(oRespuesta As ENTIDADES.beRespuestaOperacion)
        'Private Sub Generar_Orden_Interna(ByVal ldbl_NOPRCN As Double, ByVal strCBRCNT As String)
        Dim objOrdenInterna As New OrdenInterna_BLL
        'Dim objEntidad As New Planeamiento
        'Dim objParametros As New List(Of String)
        ''Try
        'objParametros.Add(ldbl_NOPRCN)
        'objParametros.Add(MainModule.USUARIO)
        'objParametros.Add(HelpClass.TodayNumeric)
        'objParametros.Add(HelpClass.NowNumeric)
        'objParametros.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
        'objParametros.Add(Me.txtTracto.pNroPlacaUnidad)
        'objParametros.Add(Me.txtAcoplado.pNroAcoplado)
        'objParametros.Add(strCBRCNT)
        'objParametros.Add(Me.cmbCompania.SelectedValue)
        'objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)
        'If objEntidad.NORINS <= 0 Then
        '    HelpClass.ErrorMsgBox()
        'End If



        Dim msg_oi As String = ""
        Dim oFiltroRecurso As New ENTIDADES.Operaciones.OperacionTransporte
        oFiltroRecurso.NOPRCN = oRespuesta.NOPRCN
        oFiltroRecurso.NCRRPL = oRespuesta.NCRRPL
        oFiltroRecurso.NSBCRP = oRespuesta.NSBCRP
        oFiltroRecurso.CULUSA = MainModule.USUARIO
        oFiltroRecurso.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        Dim orptaOI As New ENTIDADES.beRespuestaOperacion
        orptaOI = objOrdenInterna.Generar_Orden_Interna_SALM(oFiltroRecurso, msg_oi)
        If msg_oi.Length > 0 Then
            MessageBox.Show(msg_oi, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        'Catch ex As Exception
        '    HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub btnCancelarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarSolicitud.Click
        Me.panelSolicitudVjeConsolidado.Visible = False
        Me.panelVjeConsolidado.Visible = True
        Me.PanelFiltros.Enabled = True
        Me.gwdDatos.Enabled = True
        ' Me.txtTracto.Tag = ""
    End Sub

    Private Sub Modificar_Solicitud()
        If Me.gwdSolicitud.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
        If (Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
            HelpClass.MsgBox("No se Permite Modificar Solicitud ,  Traslado Consolidado cerrado", MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.panelVjeConsolidado.Visible = False
        Me.PanelFiltros.Enabled = False
        Me.gwdDatos.Enabled = False
        Me._TipoOperacion = 1
        ControlInformacion.CCMPN = Me.cmbCompania.SelectedValue
        ControlInformacion.pCDVSN = Me.cmbDivision.SelectedValue
        ControlInformacion.pCPLNDV = Me.cmbPlanta.SelectedValue
        ControlInformacion.NCSOTR_1 = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        ControlInformacion.TipoOperacion = Me._TipoOperacion
        ControlInformacion.OPCION = 0
        ControlInformacion.Actualizar_Datos()
        Me.ActivarEstado_Solicitud(True)
        Me.ControlInformacion.dtpFechaSolicitud.Enabled = False
        If Me.gwdSolicitud.Item("D_CANTOP", Me.gwdSolicitud.CurrentCellAddress.Y).Value > 0 Then
            Me.ActivarEstado_Solicitud(False)
            Me.ControlInformacion.txtCantidadSolicitada.Enabled = False
            Me.ControlInformacion.ctlTipoVehiculo.Enabled = True
            Me.ControlInformacion.dtpFechaInicioCarga.Enabled = True
            Me.ControlInformacion.txtHoraCarga.Enabled = True
            Me.ControlInformacion.txtDireccionLocalidadCarga.Enabled = True
            Me.ControlInformacion.dtpFinCarga.Enabled = True
            Me.ControlInformacion.txtHoraEntrega.Enabled = True
            Me.ControlInformacion.txtDireccionLocalidadEntrega.Enabled = True
            Me.ControlInformacion.txtObservaciones.Enabled = True
        End If
        Me.ControlInformacion.txtCliente.Enabled = False
        Me.btnCancelarSolicitud.Text = " Salir"
        Me.panelSolicitudVjeConsolidado.Visible = True
    End Sub

    Private Sub btnGuiaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuiaTransporte.Click
        Try
            Dim lint_indice As Integer = Me.gwdSolicitud.CurrentCellAddress.Y
            If Me.gwdSolicitud.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
            If (Me.gwdSolicitud.Item("D_NGUITR", Me.gwdSolicitud.CurrentCellAddress.Y).Value <> 0) Then
                HelpClass.MsgBox("Ya tiene asignada Guía de Transporte", MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.gwdSolicitud.Item("D_NOPRCN", lint_indice).Value <= 0 Then
                HelpClass.MsgBox("No se Permite Asignar Guia de Transporte , Solicitud no tiene Asignada una Operación", MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.Proceso_Guia_Transporte(Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Proceso_Guia_Transporte(ByVal NroViajeConsolidado As Int64)
        '  Dim obj_Entidad_Solicitud As New Solicitud_Transporte
        ' Dim obj_Logica_Solicitud_Transporte As New Solicitud_Transporte_BLL
        Dim frm_GuiaTransportista As New frmGuiaTransportista
        Dim obj_Logica_Guia As New GuiaTransportista_BLL
        Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
        Dim obj_Entidad_GT As New GuiaTransportista
        Dim int_Indice As Int32 = Me.gwdSolicitud.CurrentCellAddress.Y

        With frm_GuiaTransportista
            .IsMdiContainer = True
            .AutoSize = True
            Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
            With Comp_Guia
                .ESTADO = False
                .Dock = DockStyle.Fill
                '.EstadoGuiaRemisión = True
                .pCOMPANIA = Me.cmbCompania.SelectedValue
                .pDIVISION = Me.cmbDivision.SelectedValue
                .pPLANTA = Me.cmbPlanta.SelectedValue
                .pNOPRCN = Me.gwdSolicitud.Item("D_NOPRCN", int_Indice).Value
                .pUSUARIO = MainModule.USUARIO
                .pCTPOVJ = pCTPOVJ
                .pNMVJCS = NroViajeConsolidado
                .pNCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", int_Indice).Value
                .pNCRRSR = Me.gwdSolicitud.Item("D_NCRRSR", int_Indice).Value
                .pPLANTA_DESC = Me.cmbPlanta.Text.Trim

                '.Guia_Transporte.NOPRCN = Me.gwdSolicitud.Item("D_NOPRCN", int_Indice).Value
                'obj_Entidad_Solicitud.NCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", int_Indice).Value
                ' obj_Entidad_Solicitud.CCMPN = Me.cmbCompania.SelectedValue
                ' obj_Entidad_Solicitud = obj_Logica_Solicitud_Transporte.Obtener_Solicitud_Transporte(obj_Entidad_Solicitud)
                '.Guia_Transporte.CLCLOR = obj_Entidad_Solicitud.CLCLOR
                '.Guia_Transporte.CLCLDS = obj_Entidad_Solicitud.CLCLDS
                '.Guia_Transporte.TDIROR = obj_Entidad_Solicitud.TDRCOR.ToString()
                '.Guia_Transporte.TDIRDS = obj_Entidad_Solicitud.TDRENT.ToString()
                '.Guia_Transporte.QMRCMC = obj_Entidad_Solicitud.QMRCDR
                '.Guia_Transporte.CUNDMD = obj_Entidad_Solicitud.CUNDMD.ToString()
                '.Guia_Transporte.CTPOVJ = pCTPOVJ
                '.Guia_Transporte.NRUCTR = Me.txtTransportista.pRucTransportista
                '.Guia_Transporte.NPLCTR = Me.gwdSolicitud.Item("D_NPLCUN", int_Indice).Value
                '.Guia_Transporte.NPLCAC = Me.gwdSolicitud.Item("D_NPLCAC", int_Indice).Value
                '.Guia_Transporte.CBRCNT = Me.gwdSolicitud.Item("D_CBRCNT", int_Indice).Value
                '.Guia_Transporte.CBRCND = Me.gwdSolicitud.Item("D_CBRCND", int_Indice).Value
                '.Guia_Transporte.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
                '.Guia_Transporte.CCMPN = Me.cmbCompania.SelectedValue
                '.Guia_Transporte.CDVSN = Me.cmbDivision.SelectedValue
                '.Guia_Transporte.CPLNDV = Me.cmbPlanta.SelectedValue
                '.PLANTA_DESC = CType(cmbPlanta.SelectedItem, ClaseGeneral).TPLNTA

                '.Guia_Transporte.NMVJCS = NroViajeConsolidado

                '  'obj_Entidad_Guia_Transporte.NOPRCN = Me.gwdSolicitud.Item("D_NOPRCN", int_Indice).Value
                'obj_Entidad_Guia_Transporte.CCMPN = Me.cmbCompania.SelectedValue
                'obj_Entidad_Guia_Transporte.NPLCTR = Me.gwdSolicitud.Item("D_NPLCUN", int_Indice).Value
                'obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
                '.Guia_Transporte.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
                '.Guia_Transporte.QKMREC = obj_Entidad_Guia_Transporte.QKMREC
                '.Guia_Transporte.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM.ToString()
                '.Guia_Transporte.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM.ToString()
                '.Guia_Transporte.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR.ToString()
                '.Guia_Transporte.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
                '.Guia_Transporte.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN.ToString()
                '.Guia_Transporte.TDRCNS = obj_Entidad_Solicitud.TDRENT.ToString()
                '.Guia_Transporte.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR.ToString()
                '.Guia_Transporte.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
                '.Guia_Transporte.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH.ToString()
                '.Guia_Transporte.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
                '.Guia_Transporte.CCMPN = Me.cmbCompania.SelectedValue
                '.Guia_Transporte.CDVSN = Me.cmbDivision.SelectedValue
                '.Guia_Transporte.CPLNDV = Me.cmbPlanta.SelectedValue
                '.Guia_Transporte.NMVJCS = NroViajeConsolidado
                .Tag = 0

                '.Guia_Transporte.CUBORI = obj_Entidad_Guia_Transporte.CUBORI
                '.Guia_Transporte.CUBDES = obj_Entidad_Guia_Transporte.CUBDES

                .ChargeForm()
                '.objTable = Me.Operacion_Guia_Transporte
                .TipoViaje = 0
                '.TipoOperacion = 1
            End With

            .panelGuia.Controls.Add(Comp_Guia)
            .ShowDialog()
            'If Comp_Guia.pGuiaTransporte.NGUIRM > 0 Then
            If Comp_Guia.pNGUITR > 0 Then
                Me.gwdSolicitud.Item("D_NGUITR", Me.gwdSolicitud.CurrentCellAddress.Y).Value = Comp_Guia.pGuiaTransporte.NGUIRM
                Me.gwdDatos.Item("C_PMRCMC", Me.gwdDatos.CurrentCellAddress.Y).Value = Me.gwdDatos.Item("C_PMRCMC", Me.gwdDatos.CurrentCellAddress.Y).Value + Comp_Guia.pGuiaTransporte.PMRCMC
                Me.gwdDatos.Item("C_QPSOBR", Me.gwdDatos.CurrentCellAddress.Y).Value = Me.gwdDatos.Item("C_QPSOBR", Me.gwdDatos.CurrentCellAddress.Y).Value + Comp_Guia.pGuiaTransporte.QPSOBR
                Me.Listar_Guias_Transportista()
            End If

            '--PENDIENTE DE IMPLEMENTACION
            'If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
            '  If Comp_Guia.pGuiaTransporte.NGUIRM <> 0 Then
            '    Dim Objeto_Logica As New GuiaTransportista_BLL
            '    Dim oGuiaTransportistaPK As New TD_GuiaTransportistaPK
            '    Dim sGuiaPrincipal As Int64 = 0
            '    Dim dFechaGuiaPrincipal As Date = Date.Now
            '    Dim sRelacionGuiasSeleccionada As String = ""

            '    'LIMPIANDO EL dtgGuiasPendientes
            '    oGuiaTransportistaPK.pCTRMNC_CodigoTransportista = Comp_Guia.pGuiaTransporte.CTRMNC
            '    oGuiaTransportistaPK.pNGUIRM_NroGuiaTransportista = Comp_Guia.pGuiaTransporte.NGUIRM
            '    oGuiaTransportistaPK.pCCMPN_Ccompania = Me.cmbCompania.SelectedValue

            '    'LLENANDO EL dtgGuiasPendientes
            '    Dim listTD_Obj_GuiaRemisionGTransp As List(Of TD_Obj_GuiaRemisionGTransp) = Objeto_Logica.Listar_GRemPendientesGTranspLiquidacion(oGuiaTransportistaPK)
            '    Select Case listTD_Obj_GuiaRemisionGTransp.Count
            '      Case 0
            '        HelpClass.MsgBox("No tiene Guía de Remisión Cargada", MessageBoxIcon.Information)
            '        Exit Sub
            '      Case 1
            '        Dim objEntidad As TD_Obj_GuiaRemisionGTransp = listTD_Obj_GuiaRemisionGTransp.Item(0)
            '        sGuiaPrincipal = objEntidad.pNRGUCL_NroGuiaRemision
            '        dFechaGuiaPrincipal = objEntidad.pFCGUCL_FechaGuiaRemision
            '      Case Is > 1
            '        Dim fMostrarGuiasRem As frmLiquidacionFlete_DlgMostrarGuiasRem = New frmLiquidacionFlete_DlgMostrarGuiasRem(Comp_Guia.pGuiaTransporte.CTRMNC, Comp_Guia.pGuiaTransporte.NGUIRM, Me.cmbCompania.SelectedValue)
            '        If fMostrarGuiasRem.ShowDialog = Windows.Forms.DialogResult.OK Then
            '          sGuiaPrincipal = fMostrarGuiasRem.pGuiaRemPrincipal
            '          dFechaGuiaPrincipal = fMostrarGuiasRem.pFechaGuiaPrincipal
            '          sRelacionGuiasSeleccionada = fMostrarGuiasRem.pListaGuiasHijas
            '        End If
            '    End Select
            '    Dim oTemp As New TD_Obj_InfGRemCargada
            '    With oTemp
            '      .pCTRMNC_CodigoTransportista = Comp_Guia.pGuiaTransporte.CTRMNC
            '      .pNGUIRM_NroGuiaTransportista = Comp_Guia.pGuiaTransporte.NGUIRM
            '      .pNGUITR_GuiaRemisionCargada = sGuiaPrincipal
            '      .pFGUITR_FechaGuiaRemision = dFechaGuiaPrincipal
            '      .pRELGUI_RelacionGuiaHijas = sRelacionGuiasSeleccionada
            '      .pCCLNT1_CodigoCliente = Me.gwdSolicitud.Item("D_CCLNT", Me.gwdSolicitud.CurrentCellAddress.Y).Value
            '      .pCLCLOR_CodigoLocalidadOrigen = Comp_Guia.pGuiaTransporte.CLCLOR
            '      .pTCMLCO_LocalidadOrigen = Comp_Guia.pGuiaTransporte.TCMLCO
            '      .pCLCLDS_CodigoLocalidadDestino = Comp_Guia.pGuiaTransporte.CLCLDS
            '      .pTCMLCD_LocalidadDestino = Comp_Guia.pGuiaTransporte.TCMLCD
            '      .pNOPRCN_NroOperacion = Comp_Guia.pGuiaTransporte.NOPRCN
            '      .pNLQDCN_NroLiquidacion = 0
            '      .pCTRSPT_Transportista = Comp_Guia.pGuiaTransporte.CTRSPT
            '      .pTCMTRT_RazSocialTransportista = Me.txtTransportista.pRazonSocial
            '      .pNPLVHT_Tracto = Comp_Guia.pGuiaTransporte.NPLCTR
            '      .pCBRCNT_Brevete = Comp_Guia.pGuiaTransporte.CBRCNT
            '      .pCMRCDR_Mercaderia = Me.gwdSolicitud.Item("D_CMRCDR", int_Indice).Value
            '      .pTAMRCD_DetalleMercaderia = Me.gwdSolicitud.Item("D_TCMRCD", int_Indice).Value
            '      .pFRCGRM_FechaRecepGuiaRemision = Now
            '      .pQGLGSL_CantidadGlsGasolina = Comp_Guia.pGuiaTransporte.QGLGSL
            '      .pQGLDSL_CantidadGlsDiesel = Comp_Guia.pGuiaTransporte.QGLDSL
            '      .pNRHJCR_NroHojasCargui = Comp_Guia.pGuiaTransporte.NRHJCR
            '      .pCPRCN1_CodigoPropietarioContenedor1 = ""
            '      .pNSRCN1_SerieContenedor1 = ""
            '      .pCPRCN2_CodigoPropietarioContenedor2 = ""
            '      .pNSRCN2_SerieContenedor2 = ""
            '      .pFLLGCM_FechaLlegadaCamion = .pFGUITR_FechaGuiaRemision
            '      .pFSLDCM_FechaSalidaCamion = .pFGUITR_FechaGuiaRemision
            '      .pQKLMRC_KilometrosRecorridos = Comp_Guia.pGuiaTransporte.QKMREC
            '      .pQHRSRV_CantidadHorasServicio = 0
            '      .pQBLRMS_CantidadBultosRemision = Comp_Guia.pGuiaTransporte.QMRCMC
            '      .pPBRTOR_PesoBrutoRemision = IIf(Comp_Guia.pGuiaTransporte.QPSOBR = 0, Comp_Guia.pGuiaTransporte.PMRCMC, Comp_Guia.pGuiaTransporte.QPSOBR)
            '      If Comp_Guia.pGuiaTransporte.QPSOBR <> 0 And Comp_Guia.pGuiaTransporte.PMRCMC <> 0 Then
            '        .pPTRAOR_PesoTaraRemision = Comp_Guia.pGuiaTransporte.QPSOBR - Comp_Guia.pGuiaTransporte.PMRCMC
            '        .pPTRDST_PesoTaraRecepcion = Comp_Guia.pGuiaTransporte.QPSOBR - Comp_Guia.pGuiaTransporte.PMRCMC
            '      Else
            '        .pPTRAOR_PesoTaraRemision = 0
            '        .pPTRDST_PesoTaraRecepcion = 0
            '      End If
            '      .pQVLMOR_VolumenRemision = Comp_Guia.pGuiaTransporte.QVLMOR
            '      .pQBLRCP_CantidadBultosRecepcion = Comp_Guia.pGuiaTransporte.QMRCMC
            '      .pPBRDST_PesoBrutoRecepcion = .pPBRTOR_PesoBrutoRemision
            '      .pQVLMDS_VolumenRecepcion = Comp_Guia.pGuiaTransporte.QVLMOR
            '      .pMMCUSR_Usuario = MainModule.USUARIO
            '      .pNTRMNL_Terminal = HelpClass.NombreMaquina
            '      .pCCMPN_Compania = Me.cmbCompania.SelectedValue
            '    End With
            '    Dim bResultado As Boolean = True
            '    Dim sErrorMesage As String = ""
            '    Dim resultado As Int32 = 0
            '    bResultado = Objeto_Logica.Registrar_GuiaRemisionLiqTransp(oTemp, sErrorMesage)
            '    If Not bResultado Or sErrorMesage <> "" Then
            '      MessageBox.Show(sErrorMesage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '      Exit Sub
            '    End If
            '    'FALTA HACER 
            'Me.Listar_Guias_Transportista()
            '  End If
            'End If
        End With
    End Sub

    Private Sub Listar_Guias_Transportista()
        Dim strTemporal As String = ""
        'Dim dwvrow As DataGridViewRow
        Dim Objeto_Logica As New TransporteConsolidado_BLL
        Dim objetoParametro As New Hashtable

        objetoParametro.Add("PSCCMPN", Me.cmbCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", Me.cmbDivision.SelectedValue)
        objetoParametro.Add("PNCPLNDV", CType(Me.cmbPlanta.SelectedValue, Double))
        objetoParametro.Add("PNNMVJCS", Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim())


        Dim dt As New DataTable
        dt = Objeto_Logica.Listar_Guia_Transportista(objetoParametro)

        For Each item As DataRow In dt.Rows
            If strTemporal = item("NMNFCR").ToString Then
                item("NMNFCR") = ""
            Else
                item("NMNFCR") = item("NMNFCR").ToString
                strTemporal = item("NMNFCR").ToString
            End If
        Next
        gwGuiaTransporte.DataSource = dt

        'Me.gwGuiaTransporte.Rows.Clear()

        'Dim fila As Integer

        'For Each objData As DataRow In Objeto_Logica.Listar_Guia_Transportista(objetoParametro).Rows
        '    dwvrow = New DataGridViewRow
        '    dwvrow.CreateCells(Me.gwGuiaTransporte)
        '    Me.gwGuiaTransporte.Rows.Add(dwvrow)
        '    fila = gwGuiaTransporte.Rows.Count - 1


        '    'If strTemporal = objData("NMNFCR").ToString Then
        '    '    dwvrow.Cells(0).Value = ""
        '    'Else
        '    '    dwvrow.Cells(0).Value = objData("NMNFCR").ToString
        '    '    strTemporal = objData("NMNFCR").ToString
        '    'End If
        '    'dwvrow.Cells(1).Value = objData("NOPRCN")
        '    'dwvrow.Cells(2).Value = objData("NGUIRM")
        '    'dwvrow.Cells(3).Value = HelpClass.CFecha_de_8_a_10(objData("FGUIRM_S").ToString)
        '    'dwvrow.Cells(4).Value = objData("NLQDCN")
        '    'dwvrow.Cells(5).Value = objData("TDIROR").ToString
        '    'dwvrow.Cells(6).Value = objData("TDIRDS").ToString
        '    'dwvrow.Cells(7).Value = objData("TCMRCD").ToString
        '    'dwvrow.Cells(8).Value = objData("PMRCMC")
        '    'dwvrow.Cells(9).Value = objData("QKMREC")
        '    'dwvrow.Cells(10).Value = objData("SESGRP").ToString
        '    'dwvrow.Cells(11).Value = objData("SGUIFC").ToString
        '    'dwvrow.Cells(12).Value = objData("CLCLOR")
        '    'dwvrow.Cells(13).Value = objData("CLCLDS")
        '    'dwvrow.Cells(14).Value = objData("CMRCDR")
        '    'dwvrow.Cells(15).Value = objData("NOPRCN")
        '    'dwvrow.Cells("NCRDCO").Value = objData("NCRDCO")
        '    'dwvrow.Cells("SESGRP").Value = objData("SESGRP")
        '    'dwvrow.Cells("FLGSTA").Value = objData("FLGSTA")
        '    'dwvrow.Cells("FLGGTI").Value = objData("FLGGTI")

        '    If strTemporal = objData("NMNFCR").ToString Then
        '        gwGuiaTransporte.Rows(fila).Cells("NMNFCR").Value = ""
        '    Else
        '        gwGuiaTransporte.Rows(fila).Cells("NMNFCR").Value = objData("NMNFCR").ToString
        '        strTemporal = objData("NMNFCR").ToString
        '    End If
        '    gwGuiaTransporte.Rows(fila).Cells("NOPRCN").Value = objData("NOPRCN")
        '    gwGuiaTransporte.Rows(fila).Cells("NGUIRM").Value = objData("NGUIRM")
        '    gwGuiaTransporte.Rows(fila).Cells("FGUIRM_S").Value = HelpClass.CFecha_de_8_a_10(objData("FGUIRM_S").ToString)
        '    gwGuiaTransporte.Rows(fila).Cells("NLQDCN").Value = objData("NLQDCN")
        '    gwGuiaTransporte.Rows(fila).Cells("TDIROR").Value = objData("TDIROR").ToString
        '    gwGuiaTransporte.Rows(fila).Cells("TDIRDS").Value = objData("TDIRDS").ToString
        '    gwGuiaTransporte.Rows(fila).Cells("TCMRCD").Value = objData("TCMRCD").ToString
        '    gwGuiaTransporte.Rows(fila).Cells("PMRCMC").Value = objData("PMRCMC")
        '    gwGuiaTransporte.Rows(fila).Cells("QKMREC").Value = objData("QKMREC")
        '    gwGuiaTransporte.Rows(fila).Cells("SESGRP").Value = objData("SESGRP").ToString
        '    gwGuiaTransporte.Rows(fila).Cells("SGUIFC").Value = objData("SGUIFC").ToString
        '    gwGuiaTransporte.Rows(fila).Cells("CLCLOR").Value = objData("CLCLOR")
        '    gwGuiaTransporte.Rows(fila).Cells("CLCLDS").Value = objData("CLCLDS")
        '    gwGuiaTransporte.Rows(fila).Cells("CMRCDR").Value = objData("CMRCDR")
        '    gwGuiaTransporte.Rows(fila).Cells("NOPRCN").Value = objData("NOPRCN")
        '    gwGuiaTransporte.Rows(fila).Cells("SESGRP").Value = objData("SESGRP")
        '    gwGuiaTransporte.Rows(fila).Cells("FLGSTA").Value = objData("FLGSTA")
        '    gwGuiaTransporte.Rows(fila).Cells("FLGGTI").Value = objData("FLGGTI")
        'Next

    End Sub
    Private Function Operacion_Guia_Transporte() As DataTable
        Dim intContador As Int32 = Me.gwdSolicitud.CurrentCellAddress.Y
        Dim objRow As DataRow
        Dim objTable As New DataTable
        objTable.Columns.Add("TCMPCL", Type.GetType("System.String"))
        objTable.Columns.Add("NOPRCN", Type.GetType("System.Int64"))
        objTable.Columns.Add("CCMPN", Type.GetType("System.String"))
        Me.gwdSolicitud.EndEdit()
        With Me.gwdSolicitud
            objRow = objTable.NewRow
            objRow("TCMPCL") = .Item("D_TCMPCL", intContador).Value
            objRow("NOPRCN") = .Item("D_NOPRCN", intContador).Value
            objRow("CCMPN") = Me.cmbCompania.SelectedValue
            objTable.Rows.Add(objRow)

        End With
        Return objTable
    End Function

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim dtReporte As DataTable
        Dim Objeto_Logica As New TransporteConsolidado_BLL
        Dim objetoParametro As New Hashtable
        Dim oLis As New List(Of DataTable)
        Dim oHash As New Hashtable
        Dim strTitulo As String = ""

        objetoParametro.Add("PSCCMPN", Me.cmbCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", Me.cmbDivision.SelectedValue)
        objetoParametro.Add("PNCPLNDV", CType(Me.cmbPlanta.SelectedValue, Double))
        'objetoParametro.Add("PNNMVJCS", Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value)
        If Me.gwdDatos.Rows.Count > 0 Then
            objetoParametro.Add("PNNMVJCS", Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim())
            strTitulo = "REPORTE TRASLADO CONSOLIDADO NRO " & Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        Else
            objetoParametro.Add("PNNMVJCS", 0)
            strTitulo = "REPORTE TRASLADO CONSOLIDADO"
        End If
        dtReporte = Objeto_Logica.Listar_Reporte_Excel(objetoParametro)

        oHash.Add("COMPAÑIA : ", Me.cmbCompania.Text)
        oHash.Add("DIVISIÓN : ", Me.cmbDivision.Text)
        oHash.Add("PLANTA   : ", Me.cmbPlanta.Text)
        oLis.Add(dtReporte.Copy)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oLis, strTitulo, oHash)
        'HelpClass.ExportarExcel_HTML_dataset(dtReporte)
    End Sub

    Private Sub gwdSolicitud_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdSolicitud.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            Select Case gwdSolicitud.Columns(e.ColumnIndex).Name
                Case "D_NORINS"
                    If gwdSolicitud.Item("D_NORINS", e.RowIndex).Value.ToString = "Enviar SAP" Then
                        Enviar_Orden_Interna_SAP()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try






    End Sub

    Private Sub Enviar_Orden_Interna_SAP()
        Dim intIndice As Integer = Me.gwdSolicitud.CurrentCellAddress.Y
        If Me.gwdSolicitud.Item("D_NOPRCN", intIndice).Value = 0 Then
            HelpClass.MsgBox("No Tiene Operación Asignada")
            Exit Sub
        End If
        If Me.gwdSolicitud.Item("D_NORINS", intIndice).Value.ToString.Trim <> "Enviar SAP" Then
            HelpClass.MsgBox("La Operación tiene Orden Interna Asignada N° " & _
            Me.gwdSolicitud.Item("NORINS", intIndice).Value.ToString)
            Exit Sub
        End If
        If HelpClass.RspMsgBox("Desea generar la Orden Interna a la Operación de Transporte Nro " & _
           Me.gwdSolicitud.Item("D_NOPRCN", intIndice).Value & " ?") = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Generar_Orden_Interna(intIndice)
    End Sub

    Private Sub Generar_Orden_Interna(ByVal intIndice As Integer)
        If Me.gwdSolicitud.CurrentRow Is Nothing OrElse intIndice < 0 Then
            Exit Sub
        End If
        Dim objOrdenInterna As New OrdenInterna_BLL
        'Dim objEntidad As New Planeamiento
        'Dim objParametros As New List(Of String)
        ''fila Seleccionada de la grilla
        'Dim objFila As DataGridViewRow = Me.gwdSolicitud.CurrentRow
        ''Llenando el parametros de valores
        'objParametros.Add(objFila.Cells("D_NOPRCN").Value.ToString())
        'objParametros.Add(MainModule.USUARIO)
        'objParametros.Add(HelpClass.TodayNumeric)
        'objParametros.Add(HelpClass.NowNumeric)
        'objParametros.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
        'objParametros.Add(objFila.Cells("D_NPLCUN").Value.ToString())
        'objParametros.Add(objFila.Cells("D_NPLCAC").Value.ToString())
        'objParametros.Add(objFila.Cells("D_CBRCNT").Value.ToString())
        'objParametros.Add(Me.cmbCompania.SelectedValue)


        Dim msg_oi As String = ""
        Dim orptaOI As New ENTIDADES.beRespuestaOperacion
        Dim oFiltroRecurso As New ENTIDADES.Operaciones.OperacionTransporte
        oFiltroRecurso.NOPRCN = gwdSolicitud.CurrentRow.Cells("D_NOPRCN").Value
        oFiltroRecurso.NCRRPL = gwdSolicitud.CurrentRow.Cells("NCRRPL").Value
        oFiltroRecurso.NSBCRP = gwdSolicitud.CurrentRow.Cells("NSBCRP").Value
        oFiltroRecurso.CULUSA = MainModule.USUARIO
        oFiltroRecurso.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        'objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)
        orptaOI = objOrdenInterna.Generar_Orden_Interna_SALM(oFiltroRecurso, msg_oi)

        If msg_oi.Length > 0 Then
            MessageBox.Show(msg_oi, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            HelpClass.MsgBox("Orden Interna N° " + orptaOI.OI_SAP + " se envió al SAP satisfactoriamente")
            Me.gwdSolicitud.Item("D_NORINS", intIndice).Value = orptaOI.OI_SAP
            Me.gwdSolicitud.Item("D_NORINS", intIndice).Style.ForeColor = Color.Black

        End If



        'If objEntidad.NORINS > 0 Then
        '    HelpClass.MsgBox("Orden Interna N° " + CStr(objEntidad.NORINS) + " se envió al SAP satisfactoriamente")
        '    Me.gwdSolicitud.Item("D_NORINS", intIndice).Value = objEntidad.NORINS
        '    Me.gwdSolicitud.Item("D_NORINS", intIndice).Style.ForeColor = Color.Black
        'Else
        '    HelpClass.MsgBox("Ocurrió un error en el envió al SAP")
        'End If
        'Imprimiendo el numero de orden interna

    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSADI = "" Then
            Me.btnNuevo.Visible = False
            Me.Separator1.Visible = False
        End If
        If objEntidad.STSCHG = "" Then
            Me.btnGuardar.Visible = False
            Me.btnGuardarSolicitud.Visible = False
            Me.Separator2.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False
            Me.Separator4.Visible = False
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try
            If Me.gwdDatos.Rows.Count <= 0 Then Exit Sub
            If Me.gwdDatos.Item("C_NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value Is Nothing Then Exit Sub
            'No se Importan a Operaciones Cerradas
            If Me.gwdDatos.Item("C_FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C" Then Exit Sub
            Dim intIndice As Int32 = Me.gwdDatos.CurrentCellAddress.Y
            Dim objFrm As New frmConsolidadoMultimodal
            Dim objMultimodal As New Multimodal
            objMultimodal.CCMPN = cmbCompania.SelectedValue
            objMultimodal.CDVSN = Me.cmbDivision.SelectedValue
            objMultimodal.CPLNDV = Me.cmbPlanta.SelectedValue
            objMultimodal.PNNMVJCS = Me.gwdDatos.Item("C_NMVJCS", intIndice).Value
            objMultimodal.CMEDTR = Me.gwdDatos.Item("C_CMEDTR", intIndice).Value
            objMultimodal.CTRSPT = Me.gwdDatos.Item("C_CTRSPT", intIndice).Value
            objMultimodal.TNMMDT = Me.gwdDatos.Item("C_TNMMDT", intIndice).Value
            objMultimodal.TCMTRT = Me.gwdDatos.Item("C_TCMTRT", intIndice).Value
            objMultimodal.NPLCUN = Me.gwdDatos.Item("C_NPLCUN", intIndice).Value
            objMultimodal.NPLCAC = Me.gwdDatos.Item("C_NPLCAC", intIndice).Value

            objFrm.objMultimodal = objMultimodal
            If objFrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                MessageBox.Show("Se Importó con Exito", "Importar operación multimodal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cargar_Detalle_Solicitud()
                Me.Listar_Guias_Transportista()
            End If

            'gwdDatos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged
        Try
            If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            pCBRCNT = Me.gwdDatos.Item("C_CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value
            Me.Limpiar_Controles()
            Me.Cargar_Detalle_Solicitud()
            Me.Listar_Guias_Transportista()
            Me.Cargar_Datos_Grilla()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class


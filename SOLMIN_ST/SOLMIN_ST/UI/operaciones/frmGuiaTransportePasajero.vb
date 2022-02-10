Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmGuiaTransportePasajero

#Region "Variables"
  Private _NOPRCN_1 As Double = 0
  Private Objeto_Entidad_Guia As New GuiaTransportista
  Private bolBuscar As Boolean
  Private _NCSOTR As Double = 0
  Private _NCRRSR As Double = 0
  Private bolCargar_Combos As Boolean = True
  Private lintEstadoOperacion As Int16 = 0
  Private lintEstadoGuiaTrans As Int16 = 0
#End Region

#Region "Propiedades"
  Public Property NCSOTR_1() As Double
    Get
      Return _NCSOTR
    End Get
    Set(ByVal value As Double)
      _NCSOTR = value
    End Set
  End Property

  Public Property NCRRSR_1() As Double
    Get
      Return _NCRRSR
    End Get
    Set(ByVal value As Double)
      _NCRRSR = value
    End Set
  End Property

#End Region

#Region "Eventos"

  Private Sub frmGuiaTransporte_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      bolBuscar = False
      Me.Alinear_Columnas_Grilla()
      Me.Validar_Acceso_Opciones_Usuario()
      Me.Cargar_Compania()
      'Me.Cargar_Combos()
      ' Me.Listar_Guias_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            If Me.Validar_Datos_Filtro = True Then Exit Sub
            Me.Limpiar_Controles()
            Me.dtgGuiasSeleccionadas.Rows.Clear()
            'Me.dtgOrdenCompra.Rows.Clear()
            'Me.dtgGuiasTransportistaAnexa.Rows.Clear()
            Me.Listar_Guias_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            Me.Limpiar_Controles()
            Me.Asignacion_Datos_Objeto(e.RowIndex)
            Me.Asignacion_Datos()
            Me.Listar_Pasajeros_Registrados()
            'Me.Listar_Ordenes_Compra()
            'Me.Listar_Guias_Transportista_Registradas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        Try
            If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Select Case e.KeyCode
                Case Keys.Enter, Keys.Down, Keys.Up
                    Me.Limpiar_Controles()
                    Me.Asignacion_Datos_Objeto(Me.gwdDatos.CurrentCellAddress.Y)
                    Me.Asignacion_Datos()
                    Me.Listar_Pasajeros_Registrados()
                    'Me.Listar_Ordenes_Compra()
                    'Me.Listar_Guias_Transportista_Registradas()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try

            'Dim frm_GuiaTransportista As New frmGuiaTransportista
            Dim frm_BuscarSolicitud As New frmBuscarSolicitudGuia
            'Dim frm_OpcionAgregarGuia As New frmOpcionAgregarGuia
            'Dim frm_ListaTractosPlaneamiento As New frmListaTractos_x_Planeamiento
            Dim obj_Entidad_Guia As New GuiaTransportista
            Dim lint_Estado As Integer = 0
            Dim lNPLNMT As Double = 0
            Dim strNGSGWP As String = ""
            Dim intNCOREG As Double = 0

            'With frm_OpcionAgregarGuia
            '  .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
            '  .CDVSN = Me.cmbDivision.Division
            '  .CPLNDV = Me.cmbPlanta.Planta
            '  If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            '  Select Case .OPCION
            '    Case 1
            Dim obj_Logica_Guia As New GuiaTransportista_BLL
            Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
            With frm_BuscarSolicitud
                .CCMPN_1 = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue.ToString.Trim
                .CDVSN_1 = Me.cmbDivision.Division 'Me.cboDivision.SelectedValue
                .CPLNDV_1 = Me.cmbPlanta.Planta 'Me.cboPlanta.SelectedValue
                .PlantaDesc = cmbPlanta.obePlanta.TPLNTA_DescripcionPlanta
                .CTPOCR = 1
                .ShowDialog()
                Me.Limpiar_Controles()
                Me.Listar_Guias_Transportista()
                'If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                'obj_Entidad_Guia.CLCLOR = .pobjGuiaBE.CLCLOR
                'obj_Entidad_Guia.CLCLDS = .pobjGuiaBE.CLCLDS
                'obj_Entidad_Guia.TDIROR = .pobjGuiaBE.TDIROR
                'obj_Entidad_Guia.TDIRDS = .pobjGuiaBE.TDIRDS
                'obj_Entidad_Guia.QMRCMC = .pobjGuiaBE.QMRCMC
                'obj_Entidad_Guia.CUNDMD = .pobjGuiaBE.CUNDMD
                'obj_Entidad_Guia.NRUCTR = .pobjGuiaBE.NRUCTR
                'obj_Entidad_Guia.NPLCTR = .pobjGuiaBE.NPLCTR
                'obj_Entidad_Guia.NPLCAC = .pobjGuiaBE.NPLCAC
                'obj_Entidad_Guia.CBRCNT = .pobjGuiaBE.CBRCNT
                'obj_Entidad_Guia.CBRCND = .pobjGuiaBE.CBRCND
                'obj_Entidad_Guia_Transporte.NOPRCN = .pobjGuiaBE.NOPRCN
                ''EN MODIFICACION
                ''------------------------------------------------------
                'obj_Entidad_Guia_Transporte.NPLCTR = .pobjGuiaBE.NPLCTR
                ''------------------------------------------------------
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
                'obj_Entidad_Guia.CCLNT = obj_Entidad_Guia_Transporte.CCLNT

                'Me._NOPRCN_1 = .pobjGuiaBE.NOPRCN
                'Me.NCSOTR_1 = .NCSOTR_1
                'Me.NCRRSR_1 = .NCRRSR_1
                'strNGSGWP = .NGSGWP_1
                'intNCOREG = .NCOREG_1
                'lint_Estado = .Tag
                'End With
                '    Case 2
                'Dim obj_Logica_Guia As New GuiaTransportista_BLL
                'Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
                'With frm_ListaTractosPlaneamiento
                '  .NPLNMT_1 = frm_OpcionAgregarGuia.NPLNMT
                '  .CCMPN_1 = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
                '  If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                '  obj_Entidad_Guia.NRUCTR = .NRUCTR_1
                '  obj_Entidad_Guia.NPLCTR = .NPLCTR_1
                '  obj_Entidad_Guia.NPLCAC = .NPLCAC_1
                '  obj_Entidad_Guia.CBRCNT = .CBRCNT_1
                '  obj_Entidad_Guia.CBRCND = .CBRCND_1
                'End With
                'obj_Entidad_Guia_Transporte.NOPRCN = .NOPRCN
                ''EN MODIFICACION
                ''------------------------------------------------------
                'obj_Entidad_Guia_Transporte.NPLCTR = obj_Entidad_Guia.NPLCTR
                ''------------------------------------------------------
                'obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
                'obj_Entidad_Guia.CLCLOR = obj_Entidad_Guia_Transporte.CLCLOR
                'obj_Entidad_Guia.CLCLDS = obj_Entidad_Guia_Transporte.CLCLDS
                'obj_Entidad_Guia.QMRCMC = obj_Entidad_Guia_Transporte.QMRCMC
                'obj_Entidad_Guia.CUNDMD = obj_Entidad_Guia_Transporte.CUNDMD
                'obj_Entidad_Guia.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
                'obj_Entidad_Guia.QKMREC = obj_Entidad_Guia_Transporte.QKMREC
                'obj_Entidad_Guia.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM
                'obj_Entidad_Guia.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
                'obj_Entidad_Guia.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
                'obj_Entidad_Guia.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
                'obj_Entidad_Guia.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
                'obj_Entidad_Guia.TDRCNS = obj_Entidad_Guia_Transporte.TDRCNS
                'obj_Entidad_Guia.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIC
                'obj_Entidad_Guia.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
                'obj_Entidad_Guia.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
                'obj_Entidad_Guia.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
                'Me._NOPRCN_1 = .NOPRCN
                'With frm_GuiaTransportista
                '  .IsMdiContainer = True
                '  .AutoSize = True
                '  Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
                '  With Comp_Guia
                '    .ESTADO = False
                '    .Dock = DockStyle.Fill
                '    .COMPANIA = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
                '    .DIVISION = Me.cmbDivision.Division 'Me.cboDivision.SelectedValue
                '    .PLANTA = Me.cmbPlanta.Planta 'Me.cboPlanta.SelectedValue
                '    .NOPRCN = Me._NOPRCN_1
                '    .USUARIO = MainModule.USUARIO
                '    .Guia_Transporte = obj_Entidad_Guia
                '    .Tag = 1
                '    .ChargeForm()
                '    .NCSOTR = NCSOTR_1
                '    .NCRRSR = NCRRSR_1
                '  End With
                '  .txtNombreFormulario.Text = "  NUEVA GUIA DE TRANSPORTE "
                '  .panelGuia.Controls.Add(Comp_Guia)
                '  If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                '    If Comp_Guia.pGuiaTransporte.NGUIRM <> 0 Then
                '      Dim NCOREG As String = ""
                '      Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
                '      obeSeguimientoGPS.NPLCTR = obj_Entidad_Guia.NPLCTR
                '      obeSeguimientoGPS.NCSOTR = HelpClass.ObjectToDecimal(Me.NCSOTR_1)
                '      obeSeguimientoGPS.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
                '      obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.NCRRSR_1)
                '      obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(strNGSGWP)
                '      obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(intNCOREG)
                '      Dim ofrmGPSWAP As New frmGPSWAP()
                '      ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
                '      ofrmGPSWAP.Estado = 1
                '      ofrmGPSWAP.ShowDialog(Me)
                '      Me.Limpiar_Controles()
                '      Me.Listar_Guias_Transportista()
                '    End If
                '  End If
                'End With
                'End Select
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            If Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim <> "" Then
                HelpClass.MsgBox("No se puede Modificar Guia Cargada Y/O Liquidada", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim frm_GuiaTransportista As New frmGuiaTransportista
            Dim lint_CCLNT As Double = 0
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            With frm_GuiaTransportista
                .IsMdiContainer = True
                .AutoSize = True
                Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
                Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportePasajero
                With Comp_Guia
                    .ESTADO = True
                    .Dock = DockStyle.Fill
                    .COMPANIA = Me.gwdDatos.Item("CCMPN", lint_Indice).Value 'EZ
                    .DIVISION = Me.gwdDatos.Item("CDVSN", lint_Indice).Value 'T
                    .PLANTA = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value '1
                    .NOPRCN = Me.Objeto_Entidad_Guia.NOPRCN
                    .USUARIO = MainModule.USUARIO
                    .Guia_Transporte = Me.Objeto_Entidad_Guia
                    .PLANTA_DESC = cmbPlanta.obePlanta.TPLNTA_DescripcionPlanta
                    .ChargeForm()
                End With
                .panelGuia.Controls.Add(Comp_Guia)
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Me.Limpiar_Controles()
                    Me.Listar_Guias_Transportista()
                End If
            End With
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub

            Dim lstr_Mensaje As String = ""
            If Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim.Equals("") Then
                If Me.dtgGuiasSeleccionadas.RowCount > 0 Then lstr_Mensaje += " PASAJEROS" + Chr(13)
                'If Me.dtgOrdenCompra.RowCount > 0 Then lstr_Mensaje += " ORDEN DE COMPRA" + Chr(13)
                'If Me.dtgGuiasTransportistaAnexa.RowCount > 0 Then lstr_Mensaje += " GUIA TRANSPORTISTA ANEXA" + Chr(13)
                If lstr_Mensaje <> "" Then
                    HelpClass.MsgBox("TIENE ASIGNADO : " + Chr(13) + lstr_Mensaje, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                HelpClass.MsgBox("GUIA DE TRANSPORTE : PROCESADA / LIQUIDADA ", MessageBoxIcon.Information)
                Exit Sub
            End If

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim objeto_Entidad As New GuiaTransportista
            Dim objeto_Logica As New GuiaTransportista_BLL
            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            Dim frm_OpcionGuia As New frmOpcionGuia
            If frm_OpcionGuia.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            objeto_Entidad.CTRMNC = Me.gwdDatos.Item("CTRMNC", lint_Indice).Value
            objeto_Entidad.NGUIRM = Me.gwdDatos.Item("NGUIRM", lint_Indice).Value
            objeto_Entidad.NOPRCN = Me.gwdDatos.Item("NOPRCN", lint_Indice).Value 'CType(Me.txtNroOperacion.Text.Trim, Double)
            objeto_Entidad.CULUSA = MainModule.USUARIO
            objeto_Entidad.FULTAC = HelpClass.TodayNumeric
            objeto_Entidad.HULTAC = HelpClass.NowNumeric
            objeto_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objeto_Entidad.SESTRG = frm_OpcionGuia.OPCION
            objeto_Entidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'cboCompania.SelectedValue

            'objeto_Entidad.CTRMNC = objeto_Logica.Eliminar_Guia_Transportista(objeto_Entidad).CTRMNC
            objeto_Logica.Eliminar_Guia_Transportista(objeto_Entidad)
            If objeto_Entidad.CTRMNC <> 0 Then
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
                Me.Limpiar_Controles()
                Me.Listar_Guias_Transportista()
                Me.Cursor = System.Windows.Forms.Cursors.Default
            Else
                HelpClass.ErrorMsgBox()
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub TabGuiaTransportista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabGuiaTransportista.SelectedIndexChanged
    Select Case Me.TabGuiaTransportista.SelectedIndex
      Case 0
        Me.MenuBar.Enabled = True
      Case 1, 2, 3
        Me.MenuBar.Enabled = False
    End Select
  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub InicializarFormulario()
    Me.Limpiar_Controles()
    gwdDatos.DataSource = Nothing
    cboTransportista.pClearAll()
    If (bolCargar_Combos = True) Then
      Me.Cargar_Combos()
    End If

  End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            Dim ds As New DataSet
            Dim objEntidad As New Viaje_Pasajero
            Dim objViaje_Pasajero_BLL As New Viaje_Pasajero_BLL
            objEntidad.PNCTRMNC = Objeto_Entidad_Guia.CTRMNC
            objEntidad.PNNGUITR = Objeto_Entidad_Guia.NGUIRM
            objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
            objEntidad.PSCDVSN = Me.cmbDivision.Division 'Me.cboDivision.SelectedValue
            objEntidad.PNCPLNDV = Me.cmbPlanta.Planta 'CType(Me.cboPlanta.SelectedValue, Double)
            ds = objViaje_Pasajero_BLL.RptListar_PasajerosXGuia(objEntidad)

            Dim oLis As New List(Of DataTable)
            Dim oHash As New Hashtable
            'Llena los Valores Para la cabecera

            Dim dt As DataTable = ds.Tables(0)
            'Dim dt2 As DataTable = ds.Tables(1)
            'If ds.Tables(0).Rows.Count > 0 Then
            '    dr = ds.Tables(0).Rows(0)
            'Else
            '    dr = ds.Tables(1).Rows(0)
            'End If
            If dt.Rows.Count > 0 Then
                Dim dr As DataRow
                dr = dt.Rows(0)
                oHash.Add("TIPO VIAJE     : ", dr("SIDAVL").ToString.Trim)
                oHash.Add("FECHA          : ", dr("FCHPSA").ToString.Trim)
                oHash.Add("HORA           : ", dr("HRAPSA").ToString.Trim)
                oHash.Add("TRANSPORTISTA  : ", dr("TCMTRT").ToString.Trim)
                oHash.Add("TRACTO         : ", dr("NPLCTR").ToString.Trim & " - " & dr("TMRCTR").ToString.Trim)
                oHash.Add("RUTA           : ", dr("ORIGEN").ToString.Trim & " - " & dr("DESTINO").ToString.Trim)
                'oHash.Add("MARCA - MODELO : ", dr("TMRCTR").ToString.Trim)
                dt.TableName = dr("SIDAVL").ToString.Trim
                For Columnax As Integer = dt.Columns.Count - 1 To 0 Step -1
                    Select Case dt.Columns(Columnax).ColumnName.Trim
                        Case "NCREMB"
                            dt.Columns(Columnax).ColumnName = "Nro Asiento"
                            ' dt2.Columns(Columnax).ColumnName = "Nro Emb"
                        Case "APEPER"
                            dt.Columns(Columnax).ColumnName = "Apellidos"
                            ' dt2.Columns(Columnax).ColumnName = "Apellidos"
                        Case "NMBPER"
                            dt.Columns(Columnax).ColumnName = "Nombres"
                            '  dt2.Columns(Columnax).ColumnName = "Nombres"

                        Case "TIPODOC"
                            dt.Columns(Columnax).ColumnName = "Tipo Documento"
                            ' dt2.Columns(Columnax).ColumnName = "Tipo Documento"
                        Case "NMDCPE"
                            dt.Columns(Columnax).ColumnName = "Documento"
                            ' dt2.Columns(Columnax).ColumnName = "Documento"
                        Case "CCTPPE"
                            dt.Columns(Columnax).ColumnName = "Función - Puesto"
                            ' dt2.Columns(Columnax).ColumnName = "Función - Puesto"
                        Case "TPRVCL"
                            dt.Columns(Columnax).ColumnName = "Contratista"
                            ' dt2.Columns(Columnax).ColumnName = "Contratista"
                        Case "TNCION"
                            dt.Columns(Columnax).ColumnName = "Nacionalidad"
                            ' dt2.Columns(Columnax).ColumnName = "Nacionalidad"
                        Case "DESTINO_PASAJERO"
                            dt.Columns(Columnax).ColumnName = "Destino Final"
                            'dt2.Columns(Columnax).ColumnName = "Destino Final"
                        Case Else
                            dt.Columns.RemoveAt(Columnax)
                            '  dt2.Columns.RemoveAt(Columnax)
                    End Select
                Next

                oLis.Add(dt.Copy)
                Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oLis, "MANIFIESTO DE PASAJEROS", oHash)
            Else
                MsgBox("La Guía de Transportes - Pasajeros, No tiene Pasajeros Asignados", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

  Private Sub cboLugarOrigen_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLugarOrigen.Texto_KeyEnter, cboLugarDestino.Texto_KeyEnter, cboOrigenUbigeo.Texto_KeyEnter, cboDestinoUbigeo.Texto_KeyEnter, cboMonedaFlete.Texto_KeyEnter, cboMonedaValorPatr.Texto_KeyEnter, cboUnidadMedida.Texto_KeyEnter
    Me.cboLugarOrigen.Texto.BackColor = Color.White
    Me.cboLugarDestino.Texto.BackColor = Color.White
    Me.cboMonedaFlete.Texto.BackColor = Color.White
    Me.cboMonedaValorPatr.Texto.BackColor = Color.White
    Me.cboOrigenUbigeo.Texto.BackColor = Color.White
    Me.cboUnidadMedida.Texto.BackColor = Color.White
    Me.cboDestinoUbigeo.Texto.BackColor = Color.White
    Me.cboTransportista.BackColor = Color.White
  End Sub

  Private Sub checkGuiaTransporte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkGuiaTransporte.CheckedChanged
    If lintEstadoGuiaTrans = 0 Then
      Select Case checkGuiaTransporte.Checked
        Case True
          Me.dtpFechaFin.Enabled = False
          Me.dtpFechaInicio.Enabled = False
          Me.txtGuiaTransporteFiltro.Enabled = True
          Me.cboTransportista.Enabled = True
          lintEstadoOperacion = 1
          Me.checkOperacion.Checked = False
          lintEstadoOperacion = 0
        Case False
          Me.dtpFechaFin.Enabled = True
          Me.dtpFechaInicio.Enabled = True
          Me.txtGuiaTransporteFiltro.Enabled = False
      End Select
    End If
  End Sub

  Private Sub checkOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkOperacion.CheckedChanged
    If lintEstadoOperacion = 0 Then
      Select Case checkOperacion.Checked
        Case True
          Me.dtpFechaFin.Enabled = False
          Me.dtpFechaInicio.Enabled = False
          Me.txtGuiaTransporteFiltro.Enabled = True
          Me.cboTransportista.Enabled = False
          lintEstadoGuiaTrans = 1
          Me.checkGuiaTransporte.Checked = False
          lintEstadoGuiaTrans = 0
        Case False
          Me.dtpFechaFin.Enabled = True
          Me.dtpFechaInicio.Enabled = True
          Me.txtGuiaTransporteFiltro.Enabled = False
          Me.cboTransportista.Enabled = True
      End Select
    End If
  End Sub

  Private Sub txtGuiaTransporteFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaTransporteFiltro.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Cargar_Combos()
        'Try

        Dim obj_Logica_Transporte As New Transportista_BLL
        Dim obj_Logica_Unidad As New NEGOCIO.UnidadMedida_BLL
        Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
        Dim obj_Logica_Ubigeo As New NEGOCIO.mantenimientos.LocalidadRuta_BLL

        Dim objDt As DataTable
        objDt = obj_Logica_Localidad.Listar_Localidades_Combo(Me.cmbCompania.CCMPN_CodigoCompania) 'Me.cboCompania.SelectedValue.ToString.Trim)

        With Me.cboLugarOrigen
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With

        With Me.cboLugarDestino
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
        objDt = New DataTable
        objDt = obj_Logica_Ubigeo.Listar_Ubigeo(Me.cmbCompania.CCMPN_CodigoCompania) 'Me.cboCompania.SelectedValue.ToString.Trim)

        With Me.cboOrigenUbigeo
            .DataSource = objDt.Copy
            .KeyField = "UBIGEO"
            .ValueField = "DESCRIPCION"
            .DataBind()
        End With

        With Me.cboDestinoUbigeo
            .DataSource = objDt.Copy
            .KeyField = "UBIGEO"
            .ValueField = "DESCRIPCION"
            .DataBind()
        End With

        With Me.cboUnidadMedida
            .DataSource = obj_Logica_Unidad.Listar_Unidad_Medida_Combo(Me.cmbCompania.CCMPN_CodigoCompania) 'Me.cboCompania.SelectedValue.ToString.Trim)
            .KeyField = "CUNDMD"
            .ValueField = "TCMPUN"
            .DataBind()
        End With

        Dim objLogicaGuia As New GuiaTransportista_BLL
        With Me.cboMonedaFlete
            .DataSource = objLogicaGuia.Listar_Moneda(Me.cmbCompania.CCMPN_CodigoCompania) 'Me.cboCompania.SelectedValue)
            .KeyField = "CMNDA1"
            .ValueField = "TMNDA"
            .DataBind()
        End With

        With Me.cboMonedaValorPatr
            .DataSource = objLogicaGuia.Listar_Moneda(Me.cmbCompania.CCMPN_CodigoCompania) 'Me.cboCompania.SelectedValue)
            .KeyField = "CMNDA1"
            .ValueField = "TMNDA"
            .DataBind()
        End With

        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
        obeTransportista.pNRUCTR_RucTransportista = ""
        cboTransportista.pCargar(obeTransportista)

        'Catch ex As Exception
        '    End Try
  End Sub

  Private Sub Asignacion_Datos_Objeto(ByVal lint_Indice As Integer)
    Objeto_Entidad_Guia = New GuiaTransportista
    Objeto_Entidad_Guia.CTRMNC = Me.gwdDatos.Item("CTRMNC", lint_Indice).Value
    Objeto_Entidad_Guia.NGUIRM = Me.gwdDatos.Item("NGUIRM", lint_Indice).Value
    Objeto_Entidad_Guia.FGUIRM_S = Me.gwdDatos.Item("FGUIRM_S", lint_Indice).Value
    Objeto_Entidad_Guia.NPLNMT = Me.gwdDatos.Item("NPLNMT", lint_Indice).Value
    Objeto_Entidad_Guia.CLCLOR = Me.gwdDatos.Item("CLCLOR", lint_Indice).Value
    Objeto_Entidad_Guia.CLCLDS = Me.gwdDatos.Item("CLCLDS", lint_Indice).Value
    Objeto_Entidad_Guia.TDIROR = Me.gwdDatos.Item("TDIROR", lint_Indice).Value
    Objeto_Entidad_Guia.TDIRDS = Me.gwdDatos.Item("TDIRDS", lint_Indice).Value
    Objeto_Entidad_Guia.NOPRCN = Me.gwdDatos.Item("NOPRCN", lint_Indice).Value
    Objeto_Entidad_Guia.QMRCMC = Me.gwdDatos.Item("QMRCMC", lint_Indice).Value
    Objeto_Entidad_Guia.PMRCMC = Me.gwdDatos.Item("PMRCMC", lint_Indice).Value
    Objeto_Entidad_Guia.CUNDMD = Me.gwdDatos.Item("CUNDMD", lint_Indice).Value
    Objeto_Entidad_Guia.QGLGSL = Me.gwdDatos.Item("QGLGSL", lint_Indice).Value
    Objeto_Entidad_Guia.QGLDSL = Me.gwdDatos.Item("QGLDSL", lint_Indice).Value
    Objeto_Entidad_Guia.NRHJCR = Me.gwdDatos.Item("NRHJCR", lint_Indice).Value
    Objeto_Entidad_Guia.CTRSPT = Me.gwdDatos.Item("CTRSPT", lint_Indice).Value
    Objeto_Entidad_Guia.NPLCTR = Me.gwdDatos.Item("NPLCTR", lint_Indice).Value
    Objeto_Entidad_Guia.NPLCAC = Me.gwdDatos.Item("NPLCAC", lint_Indice).Value
    Objeto_Entidad_Guia.CBRCNT = Me.gwdDatos.Item("CBRCNT", lint_Indice).Value
    Objeto_Entidad_Guia.TNMBRM = Me.gwdDatos.Item("TNMBRM", lint_Indice).Value
    Objeto_Entidad_Guia.TDRCRM = Me.gwdDatos.Item("TDRCRM", lint_Indice).Value
    Objeto_Entidad_Guia.TPDCIR = Me.gwdDatos.Item("TPDCIR", lint_Indice).Value
    Objeto_Entidad_Guia.NRUCRM = Me.gwdDatos.Item("NRUCRM", lint_Indice).Value
    Objeto_Entidad_Guia.TNMBCN = Me.gwdDatos.Item("TNMBCN", lint_Indice).Value
    Objeto_Entidad_Guia.TDRCNS = Me.gwdDatos.Item("TDRCNS", lint_Indice).Value
    Objeto_Entidad_Guia.TPDCIC = Me.gwdDatos.Item("TPDCIC", lint_Indice).Value
    Objeto_Entidad_Guia.NRUCCN = Me.gwdDatos.Item("NRUCCN", lint_Indice).Value
    Objeto_Entidad_Guia.SACRGO = Me.gwdDatos.Item("SACRGO", lint_Indice).Value
    Objeto_Entidad_Guia.CMNFLT = Me.gwdDatos.Item("CMNFLT", lint_Indice).Value
    Objeto_Entidad_Guia.FLGADC = Me.gwdDatos.Item("FLGADC", lint_Indice).Value
    Objeto_Entidad_Guia.SIDAVL = Me.gwdDatos.Item("SIDAVL", lint_Indice).Value
    Objeto_Entidad_Guia.QKMREC = Me.gwdDatos.Item("QKMREC", lint_Indice).Value
    Objeto_Entidad_Guia.ICSTRM = Me.gwdDatos.Item("ICSTRM", lint_Indice).Value
    Objeto_Entidad_Guia.QPSOBR = Me.gwdDatos.Item("QPSOBR", lint_Indice).Value
    Objeto_Entidad_Guia.QVLMOR = Me.gwdDatos.Item("QVLMOR", lint_Indice).Value
    Objeto_Entidad_Guia.SMRPLG = Me.gwdDatos.Item("SMRPLG", lint_Indice).Value
    Objeto_Entidad_Guia.SMRPRC = Me.gwdDatos.Item("SMRPRC", lint_Indice).Value
    Objeto_Entidad_Guia.IVLPRT = Me.gwdDatos.Item("IVLPRT", lint_Indice).Value
    Objeto_Entidad_Guia.CMNVLP = Me.gwdDatos.Item("CMNVLP", lint_Indice).Value
    Objeto_Entidad_Guia.CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
    Objeto_Entidad_Guia.CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
    Objeto_Entidad_Guia.CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value
    Objeto_Entidad_Guia.CUBORI = Me.gwdDatos.Item("CUBORI", lint_Indice).Value
    Objeto_Entidad_Guia.CUBDES = Me.gwdDatos.Item("CUBDES", lint_Indice).Value
    Objeto_Entidad_Guia.FEMVLH = Me.gwdDatos.Item("FEMVLH", lint_Indice).Value
    Objeto_Entidad_Guia.FEMVLH_S = Me.gwdDatos.Item("FEMVLH_S", lint_Indice).Value
    Objeto_Entidad_Guia.FECETD_S = Me.gwdDatos.Item("FECETD_S", lint_Indice).Value
    Objeto_Entidad_Guia.FECETA_S = Me.gwdDatos.Item("FECETA_S", lint_Indice).Value
    Objeto_Entidad_Guia.CBRCND = Me.gwdDatos.Item("CBRCND", lint_Indice).Value
    Objeto_Entidad_Guia.TOBS = Me.gwdDatos.Item("TOBS", lint_Indice).Value
    Objeto_Entidad_Guia.TRFRGU = Me.gwdDatos.Item("TRFRGU", lint_Indice).Value
    Objeto_Entidad_Guia.TCNFVH = Me.gwdDatos.Item("TCNFVH", lint_Indice).Value
    Objeto_Entidad_Guia.TCNFG1 = Me.gwdDatos.Item("TCNFG1", lint_Indice).Value
    Objeto_Entidad_Guia.TCNFG2 = Me.gwdDatos.Item("TCNFG2", lint_Indice).Value
    Objeto_Entidad_Guia.NOREMB = Me.gwdDatos.Item("NOREMB", lint_Indice).Value
    Objeto_Entidad_Guia.CMEDTR = Me.gwdDatos.Item("CMEDTR", lint_Indice).Value
    Dim obj_Logica As New GuiaTransportista_BLL
    Dim obj_Entidad As New GuiaTransportista
    obj_Entidad.NOPRCN = Objeto_Entidad_Guia.NOPRCN
    obj_Entidad.NPLCTR = Objeto_Entidad_Guia.NPLCTR
        obj_Entidad.CCMPN = Objeto_Entidad_Guia.CCMPN
        Objeto_Entidad_Guia.CCLNT = Me.gwdDatos.Item("CCLNT", lint_Indice).Value


        ' Objeto_Entidad_Guia.CCLNT = obj_Logica.Obtener_Informacion_Orden_Servicio(obj_Entidad).CCLNT

  End Sub

  Private Sub Listar_Pasajeros_Registrados()

    Dim obj_Entidad As New Hashtable
    Dim objanexoGuiaCliente As New GuiaTransportista_BLL
    Dim dwvrow As DataGridViewRow

    'LIMPIANDO EL dtgGuiasSeleccionadas
    Me.dtgGuiasSeleccionadas.Rows.Clear()
    obj_Entidad.Add("CTRMNC", Objeto_Entidad_Guia.CTRMNC)
    obj_Entidad.Add("NGUITR", Objeto_Entidad_Guia.NGUIRM)
    obj_Entidad.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
    obj_Entidad.Add("CPLNDV", Me.cmbPlanta.Planta)

    'LLENANDO EL dtgGuiasSeleccionadas
    For Each objEntidad As Viaje_Ruta In objanexoGuiaCliente.Listar_Pasajeros_Guia_Transporte(obj_Entidad)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.dtgGuiasSeleccionadas)
      dwvrow.Cells(0).Value = objEntidad.PSNMBPER
      dwvrow.Cells(1).Value = objEntidad.PNNPRGVJ
      dwvrow.Cells(2).Value = objEntidad.RUTA
      dwvrow.Cells(3).Value = objEntidad.PSFSLDRT
      dwvrow.Cells(4).Value = objEntidad.PSHSLDRT
      dwvrow.Cells(5).Value = objEntidad.PNNGUITR
      dwvrow.Cells(6).Value = objEntidad.PNNCRRRT
      dwvrow.Cells(7).Value = objEntidad.PNNCRRIN
      Me.dtgGuiasSeleccionadas.Rows.Add(dwvrow)
    Next
  
  End Sub

  'Private Sub Listar_Guias_Cliente_Registradas()

  '  Dim objEntidadAnexoGuiaCliente As New GuiaTransportista
  '  Dim objanexoGuiaCliente As New GuiaTransportista_BLL
  '  Dim dwvrow As DataGridViewRow

  '  'LIMPIANDO EL dtgGuiasSeleccionadas
  '  Me.dtgGuiasSeleccionadas.Rows.Clear()

  '  objEntidadAnexoGuiaCliente.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidadAnexoGuiaCliente.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidadAnexoGuiaCliente.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue

  '  'LLENANDO EL dtgGuiasSeleccionadas
  '  For Each objEntidad As GuiaTransportista In objanexoGuiaCliente.Listar_Guias_Anexas_Cliente(objEntidadAnexoGuiaCliente)
  '    dwvrow = New DataGridViewRow
  '    dwvrow.CreateCells(Me.dtgGuiasSeleccionadas)
  '    dwvrow.Cells(0).Value = objEntidad.NGUIRM
  '    dwvrow.Cells(1).Value = objEntidad.NRGUCL
  '    dwvrow.Cells(2).Value = objEntidad.TCMPCL
  '    dwvrow.Cells(3).Value = objEntidad.FCGUCL_S
  '    dwvrow.Cells(4).Value = objEntidad.CCLNT
  '    Me.dtgGuiasSeleccionadas.Rows.Add(dwvrow)
  '  Next

  'End Sub

  'Private Sub Listar_Ordenes_Compra()
  '  'Para cada guia de remision, traemos las ordenes de compra
  '  Dim objEntidadDetalleCargaRecepcionada As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
  '  Dim objDetalleCargaRecepcionada As New GuiaTransportista_BLL
  '  Dim dwvrow As DataGridViewRow

  '  'LIMPIANDO EL dtgOrdenCompra
  '  Me.dtgOrdenCompra.Rows.Clear()

  '  objEntidadDetalleCargaRecepcionada.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidadDetalleCargaRecepcionada.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidadDetalleCargaRecepcionada.CCLNT = Objeto_Entidad_Guia.CCLNT
  '  objEntidadDetalleCargaRecepcionada.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
  '  For Each objEntidadOrdenCompra As SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga In objDetalleCargaRecepcionada.Listar_Ordenes_Compra_x_MC(objEntidadDetalleCargaRecepcionada)
  '    dwvrow = New DataGridViewRow
  '    dwvrow.CreateCells(Me.dtgOrdenCompra)
  '    dwvrow.Cells(0).Value = objEntidadOrdenCompra.NGUIRM
  '    dwvrow.Cells(1).Value = objEntidadOrdenCompra.NRGUCL
  '    dwvrow.Cells(2).Value = objEntidadOrdenCompra.CREFFW
  '    dwvrow.Cells(3).Value = objEntidadOrdenCompra.NORCMC
  '    dwvrow.Cells(4).Value = objEntidadOrdenCompra.NRITOC
  '    dwvrow.Cells(5).Value = objEntidadOrdenCompra.TDITES
  '    dwvrow.Cells(6).Value = objEntidadOrdenCompra.QCNTIT
  '    dwvrow.Cells(7).Value = objEntidadOrdenCompra.TUNDIT
  '    Me.dtgOrdenCompra.Rows.Add(dwvrow)
  '  Next
  'End Sub

  'Private Sub Listar_Guias_Transportista_Registradas()

  '  Dim objEntidad As New GuiaTransportista
  '  Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL
  '  Dim dwvrow As DataGridViewRow

  '  'LIMPIANDO EL dtgOrdenCompra
  '  Me.dtgGuiasTransportistaAnexa.Rows.Clear()

  '  objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'cboCompania.SelectedValue
  '  For Each obj_Entidad As GuiaTransportista In objGuiaTransportistaAdicional.Listar_Guias_Anexas_Transportista(objEntidad)
  '    dwvrow = New DataGridViewRow
  '    dwvrow.CreateCells(Me.dtgGuiasTransportistaAnexa)
  '    dwvrow.Cells(0).Value = obj_Entidad.NGUIRM
  '    dwvrow.Cells(1).Value = obj_Entidad.NGUIAD
  '    dwvrow.Cells(2).Value = obj_Entidad.FGUIRM_S
  '    Me.dtgGuiasTransportistaAnexa.Rows.Add(dwvrow)
  '  Next

  'End Sub

  Private Sub Asignacion_Datos()
        'Try
        Me.txtNroRemision.Text = Objeto_Entidad_Guia.NGUIRM
        If Objeto_Entidad_Guia.FGUIRM_S.Substring(0, 2) = "00" Then
            Me.dtpFecGuia.Value = Date.Today
        Else
            Me.dtpFecGuia.Value = CType(Objeto_Entidad_Guia.FGUIRM_S, Date)
        End If
        Me.txtLugar.Text = Objeto_Entidad_Guia.TRFRGU
        Me.txtNroOperacion.Text = Objeto_Entidad_Guia.NOPRCN
        Me.txtNroPlaneamiento.Text = Objeto_Entidad_Guia.NPLNMT
        Me.cboLugarOrigen.Codigo = Objeto_Entidad_Guia.CLCLOR
        Me.cboLugarDestino.Codigo = Objeto_Entidad_Guia.CLCLDS
        Me.txtDirOrigen.Text = Objeto_Entidad_Guia.TDIROR
        Me.txtDirDestino.Text = Objeto_Entidad_Guia.TDIRDS
        Me.cboOrigenUbigeo.Codigo = Objeto_Entidad_Guia.CUBORI
        Me.cboDestinoUbigeo.Codigo = Objeto_Entidad_Guia.CUBDES
        Me.txtCantMercaderia.Text = Objeto_Entidad_Guia.QMRCMC
        Me.txtPesoMercaderia.Text = Objeto_Entidad_Guia.PMRCMC
        Me.cboUnidadMedida.Codigo = Objeto_Entidad_Guia.CUNDMD
        Me.txtGalsGasolina.Text = Objeto_Entidad_Guia.QGLGSL
        Me.txtGalsDiesel.Text = Objeto_Entidad_Guia.QGLDSL
        Me.txtNroHojaGuia.Text = Objeto_Entidad_Guia.NRHJCR
        Me.txtTracto.Text = Objeto_Entidad_Guia.NPLCTR
        Me.txtAcoplado.Text = Objeto_Entidad_Guia.NPLCAC
        Me.txtConfigTracto.Text = Objeto_Entidad_Guia.TCNFVH
        Me.txtConductor.Text = Objeto_Entidad_Guia.CBRCNT + " - " + Objeto_Entidad_Guia.CBRCND
        Me.txtNomRemitente.Text = Objeto_Entidad_Guia.TNMBRM
        Me.txtDirRemitente.Text = Objeto_Entidad_Guia.TDRCRM
        If Objeto_Entidad_Guia.TPDCIR = "D" Then
            Me.rbtnDNIRemit.Checked = True
            Me.rbtnRUCRemit.Checked = False
        Else
            Me.rbtnDNIRemit.Checked = False
            Me.rbtnRUCRemit.Checked = True
        End If
        Me.txtNroDocRemitente.Text = Objeto_Entidad_Guia.NRUCRM
        Me.txtNomConsignatario.Text = Objeto_Entidad_Guia.TNMBCN
        Me.txtDirConsignatario.Text = Objeto_Entidad_Guia.TDRCNS
        If Objeto_Entidad_Guia.TPDCIC = "D" Then
            Me.rbtnDNIConsignatario.Checked = True
            Me.rbtnRUCConsignatario.Checked = False
        Else
            Me.rbtnDNIConsignatario.Checked = False
            Me.rbtnRUCConsignatario.Checked = True
        End If
        Me.txtNroDocConsignatario.Text = Objeto_Entidad_Guia.NRUCCN
        If Objeto_Entidad_Guia.SACRGO = "R" Then
            Me.rbtnRemitente.Checked = True
            Me.rbtnDestinatario.Checked = False
        Else
            Me.rbtnRemitente.Checked = False
            Me.rbtnDestinatario.Checked = True
        End If
        Me.cboMonedaFlete.Codigo = Objeto_Entidad_Guia.CMNFLT
        If Objeto_Entidad_Guia.SIDAVL = "I" Then
            Me.rbtnIda.Checked = True
            Me.rbtnIdaVuelta.Checked = False
        Else
            Me.rbtnIda.Checked = False
            Me.rbtnIdaVuelta.Checked = True
        End If
        Me.txtKmPorRecorrer.Text = Objeto_Entidad_Guia.QKMREC.ToString
        Me.txtCostoTramo.Text = Objeto_Entidad_Guia.ICSTRM.ToString
        Me.txtPesoBruto.Text = Objeto_Entidad_Guia.QPSOBR.ToString
        Me.txtVolumenRemision.Text = Objeto_Entidad_Guia.QVLMOR
        If Objeto_Entidad_Guia.SMRPLG = "X" Then Me.chkMercPeligrosa.Checked = True
        If Objeto_Entidad_Guia.SMRPRC = "X" Then Me.chkMercPerecible.Checked = True
        Me.txtValorPatrimonio.Text = Objeto_Entidad_Guia.IVLPRT.ToString
        Me.cboMonedaValorPatr.Codigo = Objeto_Entidad_Guia.CMNVLP
        If Objeto_Entidad_Guia.FEMVLH_S = "" Then
            Me.dtpFecGuia.Value = Date.Today
        Else
            Me.dtpFecIniTrans.Value = Objeto_Entidad_Guia.FEMVLH_S
        End If
        Me.txtObservación.Text = Objeto_Entidad_Guia.TOBS
        Me.txtConfiguracionTracto.Text = Objeto_Entidad_Guia.TCNFG1
        Me.txtConfiguracionAcoplado.Text = Objeto_Entidad_Guia.TCNFG2
        Me.txtOrdenEmbarcador.Text = Objeto_Entidad_Guia.NOREMB
        'If Me.gwdDatos.CurrentRow.Cells("").Value <> "*" Then
        '    Me.MenuBar.Enabled = True
        'Else
        '    Me.MenuBar.Enabled = False
        'End If
        If Me.gwdDatos.CurrentRow.Cells("SESTRG").Value <> "*" Then
            Me.MenuBar.Enabled = True
        Else
            Me.MenuBar.Enabled = False
        End If


        'Catch : End Try

  End Sub

  Private Sub Limpiar_Controles()

    'Me.txtNroPlaneamiento.Text = 0
    'Me.txtNroOperacion.Text = 0
    Me.txtNroRemision.Text = ""
    Me.txtLugar.Text = ""
    Me.cboLugarOrigen.Limpiar()
    Me.txtDirOrigen.Text = ""
    Me.cboOrigenUbigeo.Limpiar()
    Me.cboLugarDestino.Limpiar()
    Me.txtDirDestino.Text = ""
    Me.cboDestinoUbigeo.Limpiar()
    Me.txtCantMercaderia.Text = ""
    Me.cboUnidadMedida.Limpiar()
    Me.txtGalsGasolina.Text = ""
    Me.txtGalsDiesel.Text = ""
    Me.txtNroHojaGuia.Text = ""
    Me.txtPesoMercaderia.Text = ""
    Me.txtPesoBruto.Text = ""
    Me.txtTracto.Text = ""
    Me.txtAcoplado.Text = ""
    Me.txtConductor.Text = ""
    Me.rbtnRemitente.Checked = True
    Me.rbtnDestinatario.Checked = False
    Me.cboMonedaFlete.Limpiar()
    Me.rbtnIda.Checked = True
    Me.rbtnIdaVuelta.Checked = False
    Me.chkMercPerecible.Checked = False
    Me.chkMercPeligrosa.Checked = False
    Me.txtVolumenRemision.Text = ""
    Me.txtValorPatrimonio.Text = ""
    Me.cboMonedaValorPatr.Limpiar()
    Me.txtKmPorRecorrer.Text = ""
    Me.txtCostoTramo.Text = ""
    Me.txtNomRemitente.Text = ""
    Me.txtDirRemitente.Text = ""
    Me.rbtnDNIRemit.Checked = False
    Me.rbtnRUCRemit.Checked = True
    Me.txtNroDocRemitente.Text = ""
    Me.txtNomConsignatario.Text = ""
    Me.txtDirConsignatario.Text = ""
    Me.rbtnDNIConsignatario.Checked = False
    Me.rbtnRUCConsignatario.Checked = True
    Me.txtNroDocConsignatario.Text = ""
    Me.txtObservación.Text = ""
    Me.txtConfigTracto.Text = ""
    Me.txtConfiguracionTracto.Text = ""
    Me.txtConfiguracionAcoplado.Text = ""
    Me.txtOrdenEmbarcador.Text = ""
    Me.dtgGuiasSeleccionadas.Rows.Clear()
    'Me.dtgOrdenCompra.Rows.Clear()
    'Me.dtgGuiasTransportistaAnexa.Rows.Clear()
    'Me.cboTransportista.pClear()
    'Me.Cargar_Combos()
  End Sub

  Private Sub Listar_Guias_Transportista()
    If Me.Validar_Datos_Filtro = True Then Exit Sub
    Dim Objeto_Logica As New GuiaTransportista_BLL
    Dim objetoParametro As New Hashtable
    objetoParametro.Add("PNCTRMNC", Me.cboTransportista.pCodigoRNS)
    objetoParametro.Add("PNNGUITR", IIf(Me.checkGuiaTransporte.Checked = False, 0, Me.txtGuiaTransporteFiltro.Text.Trim))
    objetoParametro.Add("PNNOPRCN", IIf(Me.checkOperacion.Checked = False, 0, Me.txtGuiaTransporteFiltro.Text.Trim))
    objetoParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania) 'Me.cboCompania.SelectedValue)
    objetoParametro.Add("PSCDVSN", Me.cmbDivision.Division) 'Me.cboDivision.SelectedValue)
    objetoParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta) 'CType(Me.cboPlanta.SelectedValue, Double))
    objetoParametro.Add("PNFECINI", IIf(Me.dtpFechaInicio.Enabled = False, 0, CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double)))
    objetoParametro.Add("PNFECFIN", IIf(Me.dtpFechaFin.Enabled = False, 0, CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double)))
    objetoParametro.Add("ESTADO", 0)
    Me.gwdDatos.DataSource = Objeto_Logica.Listar_Guia_Transportista_Pasajero(objetoParametro)
  End Sub

  Private Function Validar_Datos_Filtro() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False

    If Me.cmbCompania.CCMPN_CodigoCompania = "" Then
      lstr_validacion += "* COMPAÑIA " & Chr(13)
    End If
    If Me.cmbDivision.Division = "" Then
      lstr_validacion += "* DIVISION" & Chr(13)
    End If
    If Me.cmbPlanta.Planta = 0 Then
      lstr_validacion += "* PLANTA" & Chr(13)
    End If
    'If Me.cboTransportista.pRucTransportista.Trim.Equals("") Then
    '  lstr_validacion += "* TRANSPORTISTA" & Chr(13)
    'End If
    If Me.checkGuiaTransporte.Checked = True Then
      If Me.txtGuiaTransporteFiltro.Text.Trim.Equals("") OrElse CType(Me.txtGuiaTransporteFiltro.Text.Trim, Int64) = 0 Then
        lstr_validacion += "* GUÍA TRANSPORTE" & Chr(13)
      End If
    End If
    If Me.checkOperacion.Checked = True Then
      If Me.txtGuiaTransporteFiltro.Text.Trim.Equals("") OrElse CType(Me.txtGuiaTransporteFiltro.Text.Trim, Int64) = 0 Then
        lstr_validacion += "* OPERACION" & Chr(13)
      End If
    End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.dtgGuiasSeleccionadas.ColumnCount - 1
      Me.dtgGuiasSeleccionadas.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    'For lint_contador As Integer = 0 To Me.dtgGuiasTransportistaAnexa.ColumnCount - 1
    '  Me.dtgGuiasTransportistaAnexa.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    'Next
    'For lint_contador As Integer = 0 To Me.dtgOrdenCompra.ColumnCount - 1
    '  Me.dtgOrdenCompra.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    'Next

    'Ordenando las Columnas
    'Me.gwdDatos.Columns.Item(1).DisplayIndex = 0
    'Me.gwdDatos.Columns.Item(2).DisplayIndex = 1
    'Me.gwdDatos.Columns.Item(18).DisplayIndex = 2
    'Me.gwdDatos.Columns.Item(47).DisplayIndex = 3
    'Me.gwdDatos.Columns.Item(16).DisplayIndex = 4
    'Me.gwdDatos.Columns.Item(17).DisplayIndex = 5
    'Me.gwdDatos.Columns.Item(45).DisplayIndex = 6
    'Me.gwdDatos.Columns.Item(8).DisplayIndex = 7
    'Me.gwdDatos.Columns.Item(53).DisplayIndex = 8
    'Me.gwdDatos.Columns.Item(46).DisplayIndex = 9
  End Sub

  Private Sub Cargar_Compania()
        'Try
        Me.cmbCompania.Usuario = MainModule.USUARIO
        'Me.cmbCompania.CCMPN_CompaniaDefault = "EZ"
        Me.cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        'Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
        'objCompaniaBLL.Crea_Lista()
        'bolBuscar = False
        'Me.cboCompania.DataSource = objCompaniaBLL.Lista
        'Me.cboCompania.ValueMember = "CCMPN"
        'Me.cboCompania.DisplayMember = "TCMPCM"
        'bolBuscar = True
        'Me.cboCompania.SelectedIndex = 0
        'cboCompania_SelectedIndexChanged(Nothing, Nothing)
        'Catch ex As Exception

        '    End Try

  End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            Me.cmbDivision.Usuario = MainModule.USUARIO
            Me.cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            Me.cmbDivision.DivisionDefault = "T"
            Me.cmbDivision.pActualizar()
            'Me.CargarControles()
            If (Me.cmbCompania.CCMPN_ANTERIOR <> Me.cmbCompania.CCMPN_CodigoCompania) Then
                Me.gwdDatos.DataSource = Nothing
                Me.Cargar_Combos()
                'Me.dtgRecursosAsignados.Rows.Clear()
                'Me.Limpiar()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            Me.cmbPlanta.Usuario = MainModule.USUARIO
            Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            Me.cmbPlanta.PlantaDefault = 1
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                Me.cmbPlanta.pActualizar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cmbPlanta_Seleccionar(ByVal obePlanta As Ransa.Controls.UbicacionPlanta.Planta.bePlanta) Handles cmbPlanta.Seleccionar
        Me.gwdDatos.DataSource = Nothing
        Me.Limpiar_Controles()
    End Sub

  'Private Sub Cargar_Division()
  '  Dim objDivision As New NEGOCIO.Division_BLL
  '  Try
  '    If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing) Then
  '      bolBuscar = False
  '      objDivision.Crea_Lista()
  '      Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
  '      Me.cboDivision.ValueMember = "CDVSN"
  '      Me.cboDivision.DisplayMember = "TCMPDV"
  '      Me.cboDivision.SelectedIndex = 0
  '      bolBuscar = True
  '      cboDivision_SelectedIndexChanged(Nothing, Nothing)
  '    End If
  '  Catch ex As Exception

  '    HelpClass.MsgBox(ex.Message)
  '  End Try
  'End Sub

  'Private Sub Cargar_Planta()
  '  Dim objPlanta As New NEGOCIO.Planta_BLL
  '  Try
  '    If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
  '      bolBuscar = False
  '      objPlanta.Crea_Lista()
  '      Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
  '      Me.cboPlanta.ValueMember = "CPLNDV"
  '      Me.cboPlanta.DisplayMember = "TPLNTA"
  '      Me.cboPlanta.SelectedIndex = 0
  '      bolBuscar = True
  '      'cboPlanta_SelectedIndexChanged(Nothing, Nothing)
  '    End If
  '  Catch ex As Exception

  '    HelpClass.MsgBox(ex.Message)
  '  End Try
  'End Sub

  'Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If bolBuscar Then
  '    Me.Cargar_Division()
  '  End If
  'End Sub

  'Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If bolBuscar Then
  '    Me.Cargar_Planta()
  '  End If
  'End Sub

  'Private Sub cboPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlanta.SelectedIndexChanged
  '  'If bolBuscar Then
  '  'InicializarFormulario()
  '  'End If
  'End Sub

  Private Sub Validar_Acceso_Opciones_Usuario()
    Dim objParametro As New Hashtable
    Dim objLogica As New Acceso_Opciones_Usuario_BLL
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
      Me.btnModificar.Visible = False
      Me.Separator2.Visible = False
    End If
    If objEntidad.STSELI = "" Then
      Me.btnEliminar.Visible = False
      Me.Separator3.Visible = False
    End If
    If objEntidad.STSOP1 = "" Then
      Me.btnImprimir.Visible = False
    End If

  End Sub

  Private Sub Reporte_Guia_Transportista(ByVal objEntidad As GuiaTransportista)
    Dim objPrintForm As New PrintForm
    Dim objReporte As New rptGuiaTransportista
    Dim ci As Globalization.CultureInfo
    ci = New Globalization.CultureInfo("es-ES")

    'Limpiando todos los ITextObject del Reporte
    Me.Limpiar_Contenido_Reporte(objReporte)
        'Try
        Dim lguia_Transporte As String = objEntidad.NGUIRM
        CType(objReporte.ReportDefinition.ReportObjects("lblGuiaTransportista"), TextObject).Text = lguia_Transporte.Substring(0, 3) + " - " + lguia_Transporte.Substring(3)

        CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = objEntidad.TRFRGU + ", " + HelpClass.CNumero_a_Fecha(objEntidad.FGUIRM).ToString("D", ci)
        If objEntidad.TCNFVH.Substring(0, 1) <> "T" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(0, objEntidad.NPLCTR.IndexOf("-"))
            CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.IndexOf("-") + 1, objEntidad.NPLCTR.LastIndexOf("-") - objEntidad.NPLCTR.IndexOf("-") - 1)
            CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.LastIndexOf("-") + 1, objEntidad.NPLCTR.Length - objEntidad.NPLCTR.LastIndexOf("-") - 1)

            If objEntidad.NPLCAC <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(0, objEntidad.NPLCAC.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.IndexOf("-") + 1, objEntidad.NPLCAC.LastIndexOf("-") - objEntidad.NPLCAC.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.LastIndexOf("-") + 1, objEntidad.NPLCAC.Length - objEntidad.NPLCAC.LastIndexOf("-") - 1)
            End If

        Else
            If objEntidad.NPLCTR <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(0, objEntidad.NPLCTR.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.IndexOf("-") + 1, objEntidad.NPLCTR.LastIndexOf("-") - objEntidad.NPLCTR.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.LastIndexOf("-") + 1, objEntidad.NPLCTR.Length - objEntidad.NPLCTR.LastIndexOf("-") - 1)
            End If
            If objEntidad.NPLCAC <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(0, objEntidad.NPLCAC.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.IndexOf("-") + 1, objEntidad.NPLCAC.LastIndexOf("-") - objEntidad.NPLCAC.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.LastIndexOf("-") + 1, objEntidad.NPLCAC.Length - objEntidad.NPLCAC.LastIndexOf("-") - 1)
            End If
        End If
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = objEntidad.TCNFG1
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""
        If objEntidad.CBRCNT <> "" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(0, objEntidad.CBRCNT.IndexOf("-"))
            CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(objEntidad.CBRCNT.IndexOf("-") + 1, objEntidad.CBRCNT.LastIndexOf("-") - objEntidad.CBRCNT.IndexOf("-") - 1)
            CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(objEntidad.CBRCNT.LastIndexOf("-") + 1, objEntidad.CBRCNT.Length - objEntidad.CBRCNT.LastIndexOf("-") - 1)
        End If
        CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = objEntidad.TNMBRM
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = objEntidad.TDRCRM
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = objEntidad.TPDCIR + "  " + objEntidad.NRUCRM.ToString
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = objEntidad.TNMBCN
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = objEntidad.TDRCNS
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = objEntidad.TPDCIC & "  " & objEntidad.NRUCCN
        If objEntidad.NORSRT <> "" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblOrdenServicio"), TextObject).Text = objEntidad.NORSRT.Substring(0, objEntidad.NORSRT.IndexOf("-"))
            CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMarca"), TextObject).Text = objEntidad.NORSRT.Substring(objEntidad.NORSRT.IndexOf("-") + 1, objEntidad.NORSRT.Length - objEntidad.NORSRT.IndexOf("-") - 1)
        End If
        CType(objReporte.ReportDefinition.ReportObjects("lblOperacion"), TextObject).Text = objEntidad.NOPRCN.ToString + "           Planmt:   " + objEntidad.NPLNMT.ToString
        If objEntidad.NRGUCL_S <> "" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = objEntidad.NRGUCL_S.Remove(0, 1)
        End If
        CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMercaderia"), TextObject).Text = objEntidad.TOBS
        CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartOrigen"), TextObject).Text = objEntidad.CUBORI_S
        CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartDestino"), TextObject).Text = objEntidad.CUBDES_S
        CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = objEntidad.QMRCMC
        CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = Format(objEntidad.QPSOBR, "#,###,###,###.##")
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = Format(objEntidad.PMRCMC, "#,###,###,###.##")
        CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = objEntidad.SMRPLG
        CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = objEntidad.SMRPRC
        CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = objEntidad.QVLMOR
        CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = objEntidad.IVLPRT
        CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = objEntidad.QKMREC
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = objEntidad.TDIRDS
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = objEntidad.TDIROR
        CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = HelpClass.CNumero_a_Fecha(objEntidad.FEMVLH).ToString.Substring(0, 10)

        objPrintForm.ShowForm(objReporte, Me)
        'Catch e As Exception
        '        MsgBox("ERROR: CONSULTE AL AREA DE SISTEMAS", MsgBoxStyle.Information, "SOLIMN")
        '    End Try


  End Sub

  Private Sub Limpiar_Contenido_Reporte(ByVal objReporte As ReportClass)

    CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblOrdenServicio"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMarca"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMercaderia"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartOrigen"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartDestino"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblOperacion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = ""

  End Sub
#End Region

  Private Sub btnAdjuntarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarDocumento.Click
        Try
            Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos
            Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
            With ofrmAdjuntarDocumento
                .pTABLE_NAME = "RZTR96"
                .pUSER_NAME = USUARIO
                .PSCCMPN = cmbCompania.CCMPN_CodigoCompania
                .PSCDVSN = cmbDivision.Division
                .PNCPLNDV = cmbPlanta.Planta
                .PNCCLNT = Me.gwdDatos.Item("CTRMNC", lint_indice).Value
                .pNGUIRM = Me.gwdDatos.Item("NGUIRM", lint_indice).Value
                .pNMRGIM = Me.gwdDatos.Item("NMRGIM", lint_indice).Value

                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

  End Sub

  Private Sub btnAuditoria1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria1.Click
    If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
    Dim CodTransportista As Int32 = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value
    Dim GuiaTransportista As Int64 = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value

    Auditoria(CodTransportista, GuiaTransportista)
  End Sub

  Private Sub Auditoria(ByVal CodTransportista As Int32, ByVal GuiaTransportista As Int64)
    If CodTransportista = 0 OrElse GuiaTransportista = 0 Then Exit Sub

    Me.Cursor = Cursors.WaitCursor
    Dim objLogica As New GuiaTransportista_BLL
    Dim objEntidad As New GuiaTransportista
    objEntidad.CTRMNC = CodTransportista
    objEntidad.NGUIRM = GuiaTransportista
    objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
    objEntidad = objLogica.Auditoria(objEntidad)
    Dim objfrmAuditoria As New frmAuditoria
    objfrmAuditoria.USUARIO_CREACION = objEntidad.USRCRT
    objfrmAuditoria.FECHA_CREACION = objEntidad.FCHCRT_S
    objfrmAuditoria.HORA_CREACION = objEntidad.HRACRT_S
    objfrmAuditoria.TERMINAL_CREACION = objEntidad.NTRMCR
    objfrmAuditoria.USUARIO_ACTUALIZACION = objEntidad.CULUSA
    objfrmAuditoria.FECHA_ACTUALIZACION = objEntidad.FULTAC_S
    objfrmAuditoria.HORA_ACTUALIZACION = objEntidad.HULTAC_S
    objfrmAuditoria.TERMINAL_ACTUALIZACION = objEntidad.NTRMNL
    objfrmAuditoria.ShowDialog()
    Me.Cursor = Cursors.Default
  End Sub

End Class

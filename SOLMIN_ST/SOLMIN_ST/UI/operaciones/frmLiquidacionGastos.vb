Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.Utilitario
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLiquidacionGastos

    '#Region "Variables"

    Private gEnum_Mantenimiento As New MANTENIMIENTO
    Private _Estatus As Boolean = False

    '#End Region

    '#Region "Metodos y Funciones"

    Private Sub Limpiar_Controles()
        Me.txtNroLiquidacion.Text = ""
        Me.txtTransportista.Text = ""
        Me.txtTracto.Text = ""
        Me.txtTacometroSalida.Text = 0
        Me.txtAcoplado.Text = ""
        Me.txtConductor.Text = ""
        Me.cboEstadoLiquidacion.SelectedIndex = 4
        FecideKryptonTextBox.Text = String.Empty
        KryptonTextBox3.Text = ""
        'NLiquidacionKryptonTextBox.Text = String.Empty
        'FecideCheckBox.Checked = False
        'FecideDateTimePicker.Enabled = False
        'FecideDateTimePicker.Format = DateTimePickerFormat.Custom
        'FecideDateTimePicker.CustomFormat = " "
        'FecideDateTimePicker.Value = Date.FromOADate(0)
    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtTracto.Enabled = lbool_Estado
        Me.txtTacometroSalida.Enabled = lbool_Estado
        Me.FecideKryptonTextBox.Enabled = lbool_Estado
        KryptonTextBox3.Enabled = lbool_Estado
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub AccionCancelar()
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Me.Limpiar_Controles()
        Me.Estado_Controles(False)
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
        End If
        Me.btnNuevo.Enabled = True
        Me.btnAsignarOperacion.Enabled = False
        Me.btnEliminar.Enabled = False
    End Sub

    'Private Function Asignar_Valor(ByVal lcontrol As ComponentFactory.Krypton.Toolkit.KryptonComboBox) As String
    '  Dim cadena As String = ""
    '  If lcontrol.SelectedIndex = 0 Then
    '    cadena = "A"
    '  ElseIf lcontrol.SelectedIndex = 1 Then
    '    cadena = "B"
    '  ElseIf lcontrol.SelectedIndex = 2 Then
    '    cadena = ""
    '  End If
    '  Return cadena
    'End Function

    Private Sub Quitar_Valor(ByVal lstr As String, ByVal lcontrol As ComponentFactory.Krypton.Toolkit.KryptonComboBox)
        If lstr.Trim = "Pendiente" Then
            lcontrol.SelectedIndex = 0
        ElseIf lstr.Trim = "Aprobada" Then
            lcontrol.SelectedIndex = 1
        ElseIf lstr.Trim = "Cerrada" Then
            lcontrol.SelectedIndex = 2
        ElseIf lstr.Trim = "Pre Cierre" Then
            lcontrol.SelectedIndex = 3
        ElseIf lstr.Trim = "" Then
            lcontrol.SelectedIndex = 4
        End If
    End Sub

    Private Sub Eliminar_Liquidacion_Gasto()
        Dim obj_Entidad As New LiquidacionGastos
        Dim obj_Logica As New LiquidacionGastos_BLL
        Dim NLQGST As Decimal = 0
        'Try
        obj_Entidad.NLQGST = CType(Me.txtNroLiquidacion.Text, Double)
        obj_Entidad.CULUSA = MainModule.USUARIO
        obj_Entidad.FULTAC = HelpClass.TodayNumeric
        obj_Entidad.HULTAC = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        'obj_Entidad.NLQGST = obj_Logica.Eliminar_Liquidacion_Gasto(obj_Entidad).NLQGST

        NLQGST = obj_Logica.Eliminar_Liquidacion_Gasto(obj_Entidad)

        Select Case NLQGST
            Case 0
                HelpClass.ErrorMsgBox()
            Case -1
                HelpClass.MsgBox("No se puede Eliminar tiene Operaciones Asignadas")
                Exit Sub
            Case Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
        End Select
        'If obj_Entidad.NLQGST = 0 Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'ElseIf obj_Entidad.NLQGST = -1 Then
        '    HelpClass.MsgBox("No se puede Eliminar tiene Operaciones Asignadas")
        '    Exit Sub
        'Else
        '    HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
        'End If
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Me.Listar_Liquidacion_Gastos()
        Me.Listar_Operacion_x_Liquidacion(obj_Entidad.NLQGST)
        Me.AccionCancelar()
        'Catch ex As Exception
        '    End Try
    End Sub

    Public Sub Listar_Liquidacion_Gastos()
        Dim obj_Logica As New LiquidacionGastos_BLL
        Dim objetoParametro As New Hashtable
        'Dim dwv As DataGridViewRow
        Dim estadoFiltroLiq As String = ddlEstado.SelectedValue
        If estadoFiltroLiq = "T" Then
            estadoFiltroLiq = ""
        End If
        objetoParametro.Add("PNNLQGST", Me.txtLiquidacion.Text)
        objetoParametro.Add("PSNPLCUN", Me.txtPlaca.Text)
        objetoParametro.Add("PSCBRCNT", Me.ctbConductor.pBrevete)
        'objetoParametro.Add("PSSESTRG", Asignar_Valor(Me.ddlEstado))
        objetoParametro.Add("PSSESTRG", estadoFiltroLiq)
        If Me.chkFecha.Checked = True Then
            objetoParametro.Add("PNFECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value))
            objetoParametro.Add("PNFECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value))
        Else
            objetoParametro.Add("PNFECINI", 0)
            objetoParametro.Add("PNFECFIN", 0)
        End If
        objetoParametro.Add("PSUSRCRT", Trim(KryptonTextBox1.Text))
        objetoParametro.Add("PSUSRCRR", Trim(KryptonTextBox2.Text))

        gwdDatos.AutoGenerateColumns = False
        gwdDatos.DataSource = obj_Logica.Listar_Liquidacion_Gasto(objetoParametro)

        ' Se formatean las fechas
        'For Each Row As DataGridViewRow In gwdDatos.Rows
        '    Row.Cells(gwdDatos.Columns("FECIDE_G").Index).Value = HelpClass.FechaNum_a_Fecha(Row.Cells(gwdDatos.Columns("FECIDE").Index).Value)
        'Next

        If Me.gwdDatos.RowCount > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
        End If

    End Sub

    'Public Sub Listar_Liquidacion_Gastos_Detalle()


    'End Sub

    'Private Function Dar_Formato_Datatable(ByVal oDt As DataTable) As DataTable
    '    Dim NroLiq As String = ""
    '    Dim Operacion As String = ""
    '    Dim Origen As String = ""
    '    Dim Destino As String = ""
    '    For Each datarow As DataRow In oDt.Rows
    '        If NroLiq = "" Then
    '            NroLiq = datarow.Item("NLQGST").ToString().Trim()
    '            If Operacion = "" And Origen = "" And Destino = "" Then
    '                Operacion = datarow.Item("NOPRCN").ToString().Trim()
    '                Origen = datarow.Item("TLGRSL").ToString().Trim()
    '                Destino = datarow.Item("TLGRLL").ToString().Trim()
    '            End If
    '        Else
    '            If NroLiq = datarow.Item("NLQGST").ToString().Trim() Then
    '                datarow.Item("NLQGST") = ""
    '                datarow.Item("FECIDE") = ""
    '                datarow.Item("NPLCUN") = ""
    '                datarow.Item("NPLCAC") = ""
    '                datarow.Item("CBRCNT") = ""
    '                datarow.Item("CBRCND") = ""
    '                datarow.Item("SESTRG") = ""
    '                datarow.Item("USRCRT") = ""
    '                datarow.Item("FCHCRT") = ""
    '                datarow.Item("HRACRT") = ""
    '                datarow.Item("USRCRR") = ""
    '                datarow.Item("FCHCRR") = ""
    '                datarow.Item("HRACRR") = ""
    '                datarow.AcceptChanges()
    '                If Operacion = datarow.Item("NOPRCN").ToString().Trim() And Origen = datarow.Item("TLGRSL").ToString().Trim() And Destino = datarow.Item("TLGRLL").ToString().Trim() Then
    '                    datarow.Item("NOPRCN") = ""
    '                    datarow.Item("TCMPCL") = ""
    '                    datarow.Item("TCNTCS") = ""
    '                    datarow.Item("TDSCAR") = ""
    '                    datarow.Item("TLGRSL") = ""
    '                    datarow.Item("TLGRLL") = ""
    '                    datarow.Item("FSLDCM") = ""
    '                    datarow.AcceptChanges()
    '                Else
    '                    Operacion = datarow.Item("NOPRCN").ToString().Trim()
    '                    Origen = datarow.Item("TLGRSL").ToString().Trim()
    '                    Destino = datarow.Item("TLGRLL").ToString().Trim()
    '                End If

    '            Else
    '                NroLiq = datarow.Item("NLQGST").ToString().Trim()
    '                Operacion = datarow.Item("NOPRCN").ToString().Trim()
    '                Origen = datarow.Item("TLGRSL").ToString().Trim()
    '                Destino = datarow.Item("TLGRLL").ToString().Trim()
    '            End If
    '        End If
    '    Next

    '    oDt.Columns(0).ColumnName = "Nro. Liquidación"
    '    oDt.Columns(1).ColumnName = "Fecha Recepción"
    '    oDt.Columns(2).ColumnName = "Tracto"
    '    oDt.Columns(3).ColumnName = "Acoplado"
    '    oDt.Columns(4).ColumnName = "Brevete"
    '    oDt.Columns(5).ColumnName = "Conductor"
    '    oDt.Columns(6).ColumnName = "Estado"
    '    oDt.Columns(7).ColumnName = "Usuario Creador"
    '    oDt.Columns(8).ColumnName = "Fecha Creación"
    '    oDt.Columns(9).ColumnName = "Hora Creación"
    '    oDt.Columns(10).ColumnName = "Usuario Liquidador"
    '    oDt.Columns(11).ColumnName = "Fecha Liquidación"
    '    oDt.Columns(12).ColumnName = "Hora Liquidación"
    '    oDt.Columns(13).ColumnName = "Operación"
    '    oDt.Columns(14).ColumnName = "Cliente"
    '    oDt.Columns(15).ColumnName = "Centro Beneficio"
    '    oDt.Columns(16).ColumnName = "Carga"
    '    oDt.Columns(17).ColumnName = "Origen"
    '    oDt.Columns(18).ColumnName = "Destino"
    '    oDt.Columns(19).ColumnName = "Fecha Salida"
    '    oDt.Columns(20).ColumnName = "Concepto"

    '    oDt.Columns(21).ColumnName = "Planilla"
    '    oDt.Columns(22).ColumnName = "S.P. Efectivo"
    '    oDt.Columns(23).ColumnName = "Importe"

    '    'oDt.Columns(21).ColumnName = "Moneda"
    '    'oDt.Columns(22).ColumnName = "Observación"
    '    'oDt.Columns(23).ColumnName = "Nro AVC"
    '    oDt.Columns(24).ColumnName = "Moneda"
    '    oDt.Columns(25).ColumnName = "Observación"
    '    oDt.Columns(26).ColumnName = "Fecha Inicio"
    '    oDt.Columns(27).ColumnName = "Fecha Fin"
    '    oDt.Columns(28).ColumnName = "Nro AVC"
    '    Return oDt
    'End Function

    Private Sub Cargar_Combo_Conductor()
        Dim objEntidad As New Ransa.TypeDef.Transportista.TD_ConductorPK
        objEntidad.pCCMPN_Compania = "EZ"
        Me.ctbConductor.pCargar(objEntidad)

    End Sub

    Private Sub Cargar_Datos_Grilla()
        Me.Limpiar_Controles()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.txtNroLiquidacion.Text = Me.gwdDatos.Item("NLQGST", lint_indice).Value
        Me.txtTransportista.Text = Me.gwdDatos.Item("CTRSPT", lint_indice).Value.ToString + " -> " + Me.gwdDatos.Item("TCMTRT", lint_indice).Value.ToString
        Me.txtTracto.Text = Me.gwdDatos.Item("NPLCUN", lint_indice).Value
        Me.txtAcoplado.Text = Me.gwdDatos.Item("NPLCAC", lint_indice).Value
        Me.txtConductor.Text = Me.gwdDatos.Item("CBRCNT", lint_indice).Value.ToString + " -> " + Me.gwdDatos.Item("CBRCND", lint_indice).Value.ToString
        Me.txtConductor.Tag = Me.gwdDatos.Item("CBRCNT", lint_indice).Value
        Me.txtTacometroSalida.Text = Me.gwdDatos.Item("QTCSDA", lint_indice).Value

        'If (Me.gwdDatos.Item("FECIDE", lint_indice).Value > 0) Then
        '    FecideKryptonTextBox.Text = HelpClass.CNumero8Digitos_a_Fecha(Me.gwdDatos.Item("FECIDE", lint_indice).Value)
        'Else
        '    FecideKryptonTextBox.Text = String.Empty
        'End If
        FecideKryptonTextBox.Text = ("" & gwdDatos.Item("FECIDE", lint_indice).Value).ToString.Trim
        KryptonTextBox3.Text = ("" & gwdDatos.Item("CODIGOSAP", lint_indice).Value).ToString.Trim

        Quitar_Valor(Me.gwdDatos.Item("SESTRG", lint_indice).Value.ToString, Me.cboEstadoLiquidacion)
    End Sub

    Private Sub Listar_Operacion_x_Liquidacion(ByVal ldbl_NLQGST As Double)
        Dim objLogica As New LiquidacionGastos_BLL
        Dim objParametro As New Hashtable
        Dim dwv As DataGridViewRow

        objParametro.Add("PNNLQGST", ldbl_NLQGST)

        Me.gwdOperacionLiquidacion.Rows.Clear()
        Dim Fila As Int32 = 0
        For Each objEntidad As LiquidacionGastos In objLogica.Listar_Operacion_x_Liquidacion(objParametro)
            dwv = New DataGridViewRow()
            dwv.CreateCells(Me.gwdOperacionLiquidacion)
            gwdOperacionLiquidacion.Rows.Add(dwv)
            Fila = gwdOperacionLiquidacion.Rows.Count - 1
            'dwv.Cells(0).Value = My.Resources.runprog
            'dwv.Cells(1).Value = objEntidad.NLQGST
            'dwv.Cells(2).Value = objEntidad.NOPRCN
            'dwv.Cells(3).Value = objEntidad.NPLNMT
            'dwv.Cells(4).Value = objEntidad.NCRRRT
            'dwv.Cells(5).Value = objEntidad.CCNCST
            'dwv.Cells(6).Value = objEntidad.TCNTCS
            'dwv.Cells(7).Value = objEntidad.CCLNT
            'dwv.Cells(8).Value = objEntidad.TCMPCL
            'dwv.Cells(9).Value = objEntidad.TDSCAR
            'dwv.Cells(10).Value = objEntidad.TLGRSL
            'dwv.Cells(11).Value = objEntidad.FSLDCM_S
            'dwv.Cells(12).Value = objEntidad.TLGRLL
            'dwv.Cells(13).Value = objEntidad.FLLGCM_S
            'dwv.Cells(14).Value = objEntidad.NKMRTA
            'dwv.Cells(15).Value = objEntidad.TRLCGU
            'dwv.Cells(16).Value = "Gastos Ruta"
            'dwv.Cells(17).Value = objEntidad.TGASTO
            'dwv.Cells(18).Value = objEntidad.TAVC
            'Me.gwdOperacionLiquidacion.Rows.Add(dwv)
            gwdOperacionLiquidacion.Rows(Fila).Cells("IMG").Value = My.Resources.runprog
            gwdOperacionLiquidacion.Rows(Fila).Cells("NLQGST_C").Value = objEntidad.NLQGST
            gwdOperacionLiquidacion.Rows(Fila).Cells("NOPRCN_C").Value = objEntidad.NOPRCN
            gwdOperacionLiquidacion.Rows(Fila).Cells("NPLNMT_C").Value = objEntidad.NPLNMT
            gwdOperacionLiquidacion.Rows(Fila).Cells("NCRRRT").Value = objEntidad.NCRRRT
            gwdOperacionLiquidacion.Rows(Fila).Cells("CCNCST_C").Value = objEntidad.CCNCST
            gwdOperacionLiquidacion.Rows(Fila).Cells("TCNTCS_C").Value = objEntidad.TCNTCS
            gwdOperacionLiquidacion.Rows(Fila).Cells("CCLNT_C").Value = objEntidad.CCLNT
            gwdOperacionLiquidacion.Rows(Fila).Cells("TCMPCL_C").Value = objEntidad.TCMPCL
            gwdOperacionLiquidacion.Rows(Fila).Cells("TDSCAR_C").Value = objEntidad.TDSCAR
            gwdOperacionLiquidacion.Rows(Fila).Cells("TLGRSL_C").Value = objEntidad.TLGRSL
            gwdOperacionLiquidacion.Rows(Fila).Cells("FSLDCM_C").Value = objEntidad.FSLDCM_S
            gwdOperacionLiquidacion.Rows(Fila).Cells("TLGRLL_C").Value = objEntidad.TLGRLL
            gwdOperacionLiquidacion.Rows(Fila).Cells("FLLGCM_C").Value = objEntidad.FLLGCM_S
            gwdOperacionLiquidacion.Rows(Fila).Cells("NKMRTA_C").Value = objEntidad.NKMRTA
            gwdOperacionLiquidacion.Rows(Fila).Cells("TRLCGU_C").Value = objEntidad.TRLCGU
            gwdOperacionLiquidacion.Rows(Fila).Cells("GRUTA").Value = "Gastos Ruta"
            gwdOperacionLiquidacion.Rows(Fila).Cells("TGASTO").Value = objEntidad.TGASTO
            gwdOperacionLiquidacion.Rows(Fila).Cells("TAVC").Value = objEntidad.TAVC
        Next

        If Me.gwdOperacionLiquidacion.RowCount > 0 Then
            Me.gwdOperacionLiquidacion.CurrentRow.Selected = False
        End If

    End Sub

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
            Me.btnAsignarOperacion.Visible = False
            Me.Separator3.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False
            Me.Separator5.Visible = False
        End If
        If objEntidad.STSOP1 = "" Then
            Me.btnCerrarLiquidacion.Visible = False
            Me.Separator7.Visible = False
        End If

    End Sub

    Private Sub Cargar_Datos()
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        Me.Limpiar_Controles()
        Me.Cargar_Datos_Grilla()
        Me.Listar_Operacion_x_Liquidacion(Me.gwdDatos.Item("NLQGST", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Me.btnNuevo.Enabled = True
        Me.btnAsignarOperacion.Enabled = True
        Me.btnEliminar.Enabled = True
    End Sub

    '#End Region

    '#Region "Eventos"

    Private Sub frmLiquidacionGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            CargaEstadoFiltro()
            'Me.ddlEstado.SelectedIndex = 0
            ddlEstado.SelectedValue = "A"
            Cargar_Combo_Conductor()
            Validar_Acceso_Opciones_Usuario()
            Limpiar_Controles()
            Listar_Liquidacion_Gastos()
            Estado_Controles(False)
            'Alinear_Columnas_Grilla()
            'gwdDatos.Columns(9).DisplayIndex = 1
            'gwdOperacionLiquidacion.Columns(16).DisplayIndex = 0
            Cargar_Datos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargaEstadoFiltro()

        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("VALUE")
        dtEstado.Columns.Add("DISPLAY")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("VALUE") = "A"
        dr("DISPLAY") = "PENDIENTE"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "B"
        dr("DISPLAY") = "CERRADA"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "T"
        dr("DISPLAY") = "TODOS"

        dtEstado.Rows.Add(dr)

        ddlEstado.DataSource = dtEstado
        ddlEstado.DisplayMember = "DISPLAY"
        ddlEstado.ValueMember = "VALUE"

    End Sub

    Private Sub btnCerrarLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarLiquidacion.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 OrElse Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            If Me.gwdOperacionLiquidacion.RowCount = 0 Then
                HelpClass.MsgBox("No se puede Cerrar la Liquidación, no tiene Operaciones Asignadas", MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value = "Cerrada" Then
                HelpClass.MsgBox("Liquidación Gasto está Cerrada", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim frm_LiquidarChofer As New frmLiquidacionChofer
            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            With frm_LiquidarChofer
                .obj_Entidad.NLQGST = Me.gwdDatos.Item("NLQGST", lint_Indice).Value
                .obj_Entidad.NPLCUN = Me.gwdDatos.Item("NPLCUN", lint_Indice).Value.ToString
                .obj_Entidad.NPLCAC = Me.gwdDatos.Item("NPLCAC", lint_Indice).Value.ToString
                .obj_Entidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", lint_Indice).Value.ToString
                .obj_Entidad.CBRCND = Me.gwdDatos.Item("CBRCND", lint_Indice).Value.ToString
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Me.Listar_Liquidacion_Gastos()
                Me.Limpiar_Controles()
                Me.gwdOperacionLiquidacion.Rows.Clear()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Me.Limpiar_Controles()
            Me.Listar_Liquidacion_Gastos()
            Me.gwdOperacionLiquidacion.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

        Try
            If Me.gwdDatos.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            Me.Limpiar_Controles()
            Me.Cargar_Datos_Grilla()
            Me.Listar_Operacion_x_Liquidacion(Me.gwdDatos.Item("NLQGST", Me.gwdDatos.CurrentCellAddress.Y).Value)
            Me.btnNuevo.Enabled = True
            Me.btnAsignarOperacion.Enabled = True
            Me.btnEliminar.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Select Case e.KeyCode
                Case Keys.Up, Keys.Down, Keys.Enter
                    Me.Cargar_Datos_Grilla()
                    Me.Listar_Operacion_x_Liquidacion(Me.gwdDatos.Item("NLQGST", Me.gwdDatos.CurrentCellAddress.Y).Value)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 OrElse Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            Dim lstr_Estado As String = Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
            If lstr_Estado = "C" OrElse lstr_Estado = "B" Then
                HelpClass.MsgBox("No se puede Eliminar esta Liquidación está Cerrada", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Me.gwdOperacionLiquidacion.RowCount > 0 Then
                HelpClass.MsgBox("No se puede Eliminar tiene Operaciones Asignadas", MessageBoxIcon.Information)
                Exit Sub
            End If
            If MsgBox("Desea Eliminar esta Liquidación", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            Me.Eliminar_Liquidacion_Gasto()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            Dim frm_OpcionAgregarGuia As New frmOpcionAgregarGuia
            Dim frm_BuscarSolicitud As New frmBuscarSolicitudGuia
            Dim frm_ListaTractosPlaneamiento As New frmListaTractos_x_Planeamiento
            Dim frm_LiquidarOperacion As New frmLiquidarOperacion
            Dim obj_Entidad_Liquidacion As New LiquidacionGastos
            Dim obj_Logica_Liquidacion As New LiquidacionGastos_BLL

            With frm_OpcionAgregarGuia
                .CCMPN = "EZ"
                .CDVSN = "T"
                .CPLNDV = 0
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim obj_Logica_Guia As New GuiaTransportista_BLL
                Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
                Select Case .OPCION
                    Case 1
                        With frm_BuscarSolicitud
                            .CCMPN_1 = "EZ"
                            .CDVSN_1 = "T"
                            .CPLNDV_1 = 1
                            .btnGenerarGuiaTransporte.Visible = False
                            .btnAgregarGuiaTransporte.Visible = False
                            .btnAceptarLiquidacion.Visible = True
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            obj_Entidad_Liquidacion.CLCLOR = .pobjGuiaBE.CLCLOR
                            obj_Entidad_Liquidacion.CLCLDS = .pobjGuiaBE.CLCLDS
                            obj_Entidad_Liquidacion.NRUCTR = .pobjGuiaBE.NRUCTR
                            obj_Entidad_Liquidacion.NPLCUN = .pobjGuiaBE.NPLCTR
                            obj_Entidad_Liquidacion.NPLCAC = .pobjGuiaBE.NPLCAC
                            obj_Entidad_Liquidacion.CBRCNT = .pobjGuiaBE.CBRCNT
                            obj_Entidad_Liquidacion.NOPRCN = .pobjGuiaBE.NOPRCN
                            obj_Entidad_Liquidacion.NCSOTR = .NCSOTR_1
                        End With
                        obj_Entidad_Guia_Transporte.NOPRCN = obj_Entidad_Liquidacion.NOPRCN
                        obj_Entidad_Guia_Transporte.NPLCTR = obj_Entidad_Liquidacion.NPLCUN
                        obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
                        obj_Entidad_Liquidacion.NKMRTA = obj_Entidad_Guia_Transporte.QKMREC
                        obj_Entidad_Liquidacion.TDSCAR = obj_Entidad_Guia_Transporte.TDSCAR
                        obj_Entidad_Liquidacion.CCNCST = obj_Entidad_Guia_Transporte.CCNCST
                    Case 2
                        With frm_ListaTractosPlaneamiento
                            .NPLNMT_1 = frm_OpcionAgregarGuia.NPLNMT
                            .CCMPN_1 = "EZ"
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            obj_Entidad_Liquidacion.NRUCTR = .NRUCTR_1
                            obj_Entidad_Liquidacion.NPLCUN = .NPLCTR_1
                            obj_Entidad_Liquidacion.NPLCAC = .NPLCAC_1
                            obj_Entidad_Liquidacion.CBRCNT = .CBRCNT_1
                            obj_Entidad_Liquidacion.CBRCND = .CBRCND_1
                        End With
                        obj_Entidad_Guia_Transporte.NOPRCN = .NOPRCN
                        obj_Entidad_Guia_Transporte.NPLCTR = obj_Entidad_Liquidacion.NPLCUN
                        obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
                        obj_Entidad_Liquidacion.CLCLOR = obj_Entidad_Guia_Transporte.CLCLOR
                        obj_Entidad_Liquidacion.CLCLDS = obj_Entidad_Guia_Transporte.CLCLDS
                        obj_Entidad_Liquidacion.TDSCAR = obj_Entidad_Guia_Transporte.TDSCAR
                        obj_Entidad_Liquidacion.NKMRTA = obj_Entidad_Guia_Transporte.QKMREC
                        obj_Entidad_Liquidacion.CCNCST = obj_Entidad_Guia_Transporte.CCNCST
                        obj_Entidad_Liquidacion.NOPRCN = .NOPRCN
                End Select
            End With
            obj_Entidad_Liquidacion.USRCRT = MainModule.USUARIO
            obj_Entidad_Liquidacion.FCHCRT = HelpClass.TodayNumeric
            obj_Entidad_Liquidacion.HRACRT = HelpClass.NowNumeric
            obj_Entidad_Liquidacion.CULUSA = MainModule.USUARIO
            obj_Entidad_Liquidacion.FULTAC = HelpClass.TodayNumeric
            obj_Entidad_Liquidacion.HULTAC = HelpClass.NowNumeric
            obj_Entidad_Liquidacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            obj_Entidad_Liquidacion.NLQGST = obj_Logica_Liquidacion.Registrar_Liquidacion_Gasto(obj_Entidad_Liquidacion).NLQGST
            Select Case obj_Entidad_Liquidacion.NLQGST
                Case -1
                    HelpClass.MsgBox("Vehículo en su última Liquidación, no esta Cerrada ", MessageBoxIcon.Information)
                    Exit Sub
                Case 0
                    HelpClass.ErrorMsgBox()
                    Exit Sub
            End Select
            With frm_LiquidarOperacion
                .NLQGST_1 = obj_Entidad_Liquidacion.NLQGST
                .NPLCUN_1 = obj_Entidad_Liquidacion.NPLCUN
                .CBRCND_1 = obj_Entidad_Liquidacion.CBRCNT + " -> " + obj_Entidad_Liquidacion.CBRCND
                .ShowDialog()
            End With
            Me.Listar_Liquidacion_Gastos()
            Listar_Operacion_x_Liquidacion(obj_Entidad_Liquidacion.NLQGST)
            'Me.Listar_Operacion_x_Liquidacion_Detallada(obj_Entidad_Liquidacion.NLQGST)
            Me.Limpiar_Controles()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAsignarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOperacion.Click

        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            If Me.gwdDatos.Item("SESTRG", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "Cerrada" Then
                HelpClass.MsgBox("No se puede Modificar, la Liquidación esta Cerrada", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
            Select Case TabSeleccionado
                Case "tbInformacionGeneral"
                    Dim ofrmActDatLiquidacion As New frmActLiGastos
                    ''InfoLiqHeaderGroup.Visible = True
                    'NLiquidacionKryptonTextBox.Text = txtNroLiquidacion.Text
                    'If (FecideKryptonTextBox.Text <> String.Empty) Then
                    '    FecideCheckBox.Checked = True
                    '    FecideDateTimePicker.Enabled = True
                    '    FecideDateTimePicker.Format = DateTimePickerFormat.Short
                    '    FecideDateTimePicker.Value = CDate(FecideKryptonTextBox.Text)
                    'Else
                    '    FecideCheckBox.Checked = False
                    '    FecideDateTimePicker.Enabled = False
                    '    FecideDateTimePicker.Format = DateTimePickerFormat.Custom
                    '    FecideDateTimePicker.CustomFormat = " "
                    '    FecideDateTimePicker.Value = Date.FromOADate(0)
                    'End If
                    ofrmActDatLiquidacion.pFECIDE = ("" & gwdDatos.CurrentRow.Cells("FECIDE").Value).ToString.Trim
                    ofrmActDatLiquidacion.pNLQGST = gwdDatos.CurrentRow.Cells("NLQGST").Value
                    ofrmActDatLiquidacion.pConductor = ("" & gwdDatos.CurrentRow.Cells("CBRCND").Value).ToString.Trim
                    If ofrmActDatLiquidacion.ShowDialog = Windows.Forms.DialogResult.OK Then

                        Me.Limpiar_Controles()
                        Me.Listar_Liquidacion_Gastos()
                        Me.gwdOperacionLiquidacion.Rows.Clear()
                        If gwdDatos.CurrentRow IsNot Nothing Then
                            Me.Listar_Operacion_x_Liquidacion(gwdDatos.CurrentRow.Cells("NLQGST").Value)
                        End If
                    End If

                Case "tbOperaciones_x_Liquidacion"
                    Dim frm_LiquidarOperacion As New frmLiquidarOperacion
                    With frm_LiquidarOperacion
                        .NLQGST_1 = CType(Me.txtNroLiquidacion.Text, Double)
                        .NPLCUN_1 = Me.txtTracto.Text
                        .CBRCND_1 = Me.txtConductor.Text
                        '.CTRSPT = Me.gwdDatos.Item("CTRSPT", Me.gwdDatos.CurrentCellAddress.Y).Value
                        .ShowDialog()
                        'Me.Listar_Operacion_x_Liquidacion_Detallada(.NLQGST_1)
                        Me.Listar_Operacion_x_Liquidacion(.NLQGST_1)
                    End With

            End Select

            'If (TabSolicitudFlete.SelectedIndex = 0) Then
            'Else
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtTacometroSalida_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTacometroSalida.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub gwdOperacionLiquidacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdOperacionLiquidacion.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            '  If e.ColumnIndex = 16 Then
            If gwdOperacionLiquidacion.Columns(e.ColumnIndex).Name = "GRUTA" Then
                Dim frm_Consulta_Operacion As New frmConsultaOperacionRuta
                With frm_Consulta_Operacion
                    '.NLQGST = Me.gwdOperacionLiquidacion.CurrentRow.Cells(1).Value
                    '.NOPRCN = Me.gwdOperacionLiquidacion.CurrentRow.Cells(2).Value
                    '.NCRRRT = Me.gwdOperacionLiquidacion.CurrentRow.Cells(4).Value
                    .NLQGST = Me.gwdOperacionLiquidacion.CurrentRow.Cells("NLQGST_C").Value
                    .NOPRCN = Me.gwdOperacionLiquidacion.CurrentRow.Cells("NOPRCN_C").Value
                    .NCRRRT = Me.gwdOperacionLiquidacion.CurrentRow.Cells("NCRRRT").Value
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim objetoParametro As New Hashtable
            Dim obj_DataSet As New DataSet
            Dim objPrintForm As New PrintForm
            'Dim objReporte As New rptLiquidacionGasto
            Dim objReporte As New rptLiquidacionGasto_V2

            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

            objetoParametro.Add("PNNLQGST", Me.gwdDatos.Item("NLQGST", lint_Indice).Value)
            objetoParametro.Add("PNCTRSPT", Me.gwdDatos.Item("CTRSPT", lint_Indice).Value)
            objetoParametro.Add("PSNPLCUN", Me.gwdDatos.Item("NPLCUN", lint_Indice).Value)
            objetoParametro.Add("PSCBRCNT", Me.gwdDatos.Item("CBRCNT", lint_Indice).Value)

            obj_DataSet = obj_Logica.Listar_Detalle_Liquidacion_Gasto(objetoParametro)
            If obj_DataSet.Tables.Count = 0 Then Exit Sub
            obj_DataSet.Tables(0).TableName = "RZTR58"
            obj_DataSet.Tables(1).TableName = "RZTR61"

            obj_DataSet.Tables("RZTR61").Columns.Add("IGSTOS_PLANILLA", Type.GetType("System.Double"))
            obj_DataSet.Tables("RZTR61").Columns.Add("IGSTOS_SPE", Type.GetType("System.Double"))

            Dim tipo_sustento_gasto As String = ""
            For Fila As Integer = 0 To obj_DataSet.Tables("RZTR61").Rows.Count - 1
                If obj_DataSet.Tables("RZTR61").Rows(Fila)("CDMNDA") = 1 Then
                    obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS") = obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS")
                Else
                    obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS") = 0
                End If
                tipo_sustento_gasto = ("" & obj_DataSet.Tables("RZTR61").Rows(Fila)("SSTGSP")).ToString.Trim
                If tipo_sustento_gasto = "X" Then 'X:PLANILLA
                    obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS_PLANILLA") = obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS")
                    obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS_SPE") = DBNull.Value
                End If
                If tipo_sustento_gasto = "" Then ' '' SUSTENTO PEDIDO EFECTIVO
                    obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS_SPE") = obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS")
                    obj_DataSet.Tables("RZTR61").Rows(Fila)("IGSTOS_PLANILLA") = DBNull.Value
                End If
            Next
            'IIF ({RZTR61.CDMNDA} = 1, {RZTR61.IGSTOS}, .00)
            obj_DataSet.Tables(2).TableName = "RZTR62"
            obj_DataSet.Tables(3).TableName = "RZTR63"
            obj_DataSet.Tables(4).TableName = "RZTR55"


            objReporte.SetDataSource(obj_DataSet.Copy)


            If obj_DataSet.Tables(2).Rows.Count = 0 Then
                objReporte.SetParameterValue("pCargaCombustible", True)
            Else
                objReporte.SetParameterValue("pCargaCombustible", False)
            End If
            If obj_DataSet.Tables(4).Rows.Count = 0 Then
                objReporte.SetParameterValue("pAVC", True)
            Else
                objReporte.SetParameterValue("pAVC", False)
            End If

            objPrintForm.ShowForm(objReporte, Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimir_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir_1.Click

        Try
            Dim frm_Opcion_LiquidacionGasto As New frmOpRptLiquidacionGasto
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim objetoParametro As New Hashtable
            Dim obj_DataSet As New DataSet
            Dim objPrintForm As New PrintForm
            Dim objReporte As New rptListaLiquidacionGasto

            With frm_Opcion_LiquidacionGasto
                frm_Opcion_LiquidacionGasto.CCMPN = "EZ" 'ACTUALMENTE SE TRABAJA CON UNA EMPRESA
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

                objetoParametro.Add("PNCCLNT", .CCLNT)
                objetoParametro.Add("PNFECINI", .FECINI)
                objetoParametro.Add("PNFECFIN", .FECFIN)
                objetoParametro.Add("PSNPLCUN", .NPLCUN)
                objetoParametro.Add("PSCBRCNT", .CBRCNT)
                obj_DataSet = obj_Logica.Listar_Liquidacion_Gastos_RPT(objetoParametro)
                If obj_DataSet.Tables.Count = 0 Then Exit Sub
                obj_DataSet.Tables(0).TableName = "RZTR58"
                obj_DataSet.Tables(1).TableName = "RZTR63"

                CType(objReporte.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECINI)
                CType(objReporte.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECFIN)
                Select Case .Tag
                    Case 0
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR FECHA"
                    Case 1
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CLIENTE"
                    Case 2
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CONDUCTOR"
                    Case 3
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR TRACTO"
                End Select
                objReporte.SetDataSource(obj_DataSet)

                objPrintForm.ShowForm(objReporte, Me)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If chkFecha.Checked = True Then
            Me.dtpFechaInicio.Enabled = True
            Me.dtpFechaFin.Enabled = True
        Else
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub txtLiquidacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLiquidacion.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub


    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If (gwdDatos.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim oHasColumnas As New Hashtable
            Dim odtDatoExportar As New DataTable
            odtDatoExportar.TableName = "Liquidaciones"
            Dim dr As DataRow
            Dim oListExportar As New List(Of DataTable)
            Dim NameColumna As String = ""
            For Columna As Integer = 0 To gwdDatos.Columns.Count - 1
                NameColumna = gwdDatos.Columns(Columna).Name
                If (gwdDatos.Columns(Columna).Visible = True) Then
                    odtDatoExportar.Columns.Add(NameColumna)
                    oHasColumnas(NameColumna) = gwdDatos.Columns(Columna).HeaderText
                End If
            Next
            For Fila As Integer = 0 To gwdDatos.Rows.Count - 1
                dr = odtDatoExportar.NewRow
                For Columna As Integer = 0 To odtDatoExportar.Columns.Count - 1
                    NameColumna = odtDatoExportar.Columns(Columna).ColumnName
                    If (gwdDatos.Rows(Fila).Cells(NameColumna).Value IsNot Nothing) Then
                        dr(NameColumna) = gwdDatos.Rows(Fila).Cells(NameColumna).FormattedValue
                    End If
                Next
                odtDatoExportar.Rows.Add(dr)
            Next
            For Columna As Integer = 0 To odtDatoExportar.Columns.Count - 1
                NameColumna = odtDatoExportar.Columns(Columna).ColumnName
                odtDatoExportar.Columns(Columna).ColumnName = oHasColumnas(NameColumna)
            Next
            oListExportar.Add(odtDatoExportar)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oListExportar, "Lista de Liquidación de Gastos")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimir_Seguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir_Seguimiento.Click
        Try
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim EstadoFiltroLiq As String = ""
            EstadoFiltroLiq = ddlEstado.SelectedValue
            If EstadoFiltroLiq = "T" Then
                EstadoFiltroLiq = ""
            End If

            Dim objetoParametro As New Hashtable
            If Trim(Me.txtLiquidacion.Text) = "" Then
                objetoParametro.Add("PNNLQGST", 0)
            Else
                objetoParametro.Add("PNNLQGST", Me.txtLiquidacion.Text)
            End If

            objetoParametro.Add("PSNPLCUN", Me.txtPlaca.Text)
            objetoParametro.Add("PSCBRCNT", Me.ctbConductor.pBrevete)
            ' objetoParametro.Add("PSSESTRG", Asignar_Valor(Me.ddlEstado))
            objetoParametro.Add("PSSESTRG", EstadoFiltroLiq)
            If Me.chkFecha.Checked = True Then
                objetoParametro.Add("PNFECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value))
                objetoParametro.Add("PNFECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value))
            Else
                objetoParametro.Add("PNFECINI", 0)
                objetoParametro.Add("PNFECFIN", 0)
            End If
            objetoParametro.Add("PSUSRCRT", Trim(KryptonTextBox1.Text))
            objetoParametro.Add("PSUSRCRR", Trim(KryptonTextBox2.Text))

            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SEGUIMIENTO_AVC"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SEGUIMIENTO AVC"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "SEGUIMIENTO Y CONTROL DE LIQUIDACIÓN AVC"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            ODs.Tables.Add(obj_Logica.Listar_Seguimiento_AVC(objetoParametro).Copy)
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "CLIENTE", "OPERACION", "AVC_IDA", "AVC_RETORNO", "ORIGEN", "DESTINO", _
                         "USUARIO_CREADOR", "USUARIO_LIQUIDADOR"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    Case "IMPORTE"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CopiarDatosTo(ByVal dtOrigen As DataTable, ByRef dtDestino As DataTable) As DataTable
        dtDestino.Rows.Clear()
        Dim NameColumna As String = ""
        Dim dr As DataRow
        For Fila As Integer = 0 To dtOrigen.Rows.Count - 1
            dr = dtDestino.NewRow
            For Columna As Integer = 0 To dtDestino.Columns.Count - 1
                NameColumna = dtDestino.Columns(Columna).ColumnName
                If dtOrigen.Columns(NameColumna) IsNot Nothing Then
                    dr(NameColumna) = dtOrigen.Rows(Fila)(NameColumna)
                End If
            Next
            dtDestino.Rows.Add(dr)
        Next
        Return dtDestino.Copy
    End Function


    Private Sub tsbiExportarLiqDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbiExportarLiqDetalle.Click
        Try
            'Listar_Liquidacion_Gastos_Detalle()
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim objetoParametro As New Hashtable

            Dim estadoFiltroLiq As String = ddlEstado.SelectedValue
            If estadoFiltroLiq = "T" Then
                estadoFiltroLiq = ""
            End If

            objetoParametro.Add("PNNLQGST", Me.txtLiquidacion.Text)
            objetoParametro.Add("PSNPLCUN", Me.txtPlaca.Text)
            objetoParametro.Add("PSCBRCNT", Me.ctbConductor.pBrevete)
            'objetoParametro.Add("PSSESTRG", Asignar_Valor(Me.ddlEstado))
            objetoParametro.Add("PSSESTRG", estadoFiltroLiq)
            If Me.chkFecha.Checked = True Then
                objetoParametro.Add("PNFECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value))
                objetoParametro.Add("PNFECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value))
            Else
                objetoParametro.Add("PNFECINI", 0)
                objetoParametro.Add("PNFECFIN", 0)
            End If
            objetoParametro.Add("PSUSRCRT", Trim(KryptonTextBox1.Text))
            objetoParametro.Add("PSUSRCRR", Trim(KryptonTextBox2.Text))

            'Dim Fila As Int32 = 0
            'Dim oDtLiqDetalle As New DataTable
            'Dim oDs As New DataSet
            'Dim strTitulo As String
            'strTitulo = "LISTA DE LIQUIDACIÓN DE GASTOS - DETALLE"
            'Dim oListExportar As New List(Of DataTable)
            Dim dtresult As New DataTable
            dtresult = obj_Logica.Listar_Liquidacion_Gasto_Detalle_V2(objetoParametro)

            Dim NPOI_ST As New HelpClass_NPOI_ST
            Dim dtExportar As New DataTable
            dtExportar.Columns.Add("NLQGST").Caption = NPOI_ST.FormatDato("Nro. Liquidación", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("FECIDE").Caption = NPOI_ST.FormatDato("Fecha Recepción", HelpClass_NPOI_ST.keyDatoFecha)
            dtExportar.Columns.Add("NPLCUN").Caption = NPOI_ST.FormatDato("Tracto", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("NPLCAC").Caption = NPOI_ST.FormatDato("Acoplado", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("CODIGOSAP").Caption = NPOI_ST.FormatDato("Cod. SAP", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("CBRCNT").Caption = NPOI_ST.FormatDato("Brevete", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("CBRCND").Caption = NPOI_ST.FormatDato("Conductor", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("SESTRG").Caption = NPOI_ST.FormatDato("Estado", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("USRCRT").Caption = NPOI_ST.FormatDato("Usuario Creador", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("FCHCRT").Caption = NPOI_ST.FormatDato("Fecha Creación", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("HRACRT").Caption = NPOI_ST.FormatDato("Hora Creación", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("USRCRR").Caption = NPOI_ST.FormatDato("Usuario Liquidador", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("FCHCRR").Caption = NPOI_ST.FormatDato("Fecha Liquidación", HelpClass_NPOI_ST.keyDatoFecha)
            dtExportar.Columns.Add("HRACRR").Caption = NPOI_ST.FormatDato("Hora Liquidación", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("NOPRCN").Caption = NPOI_ST.FormatDato("Operación", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("TCMPCL").Caption = NPOI_ST.FormatDato("Cliente", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("TCNTCS").Caption = NPOI_ST.FormatDato("Centro Beneficio", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("TDSCAR").Caption = NPOI_ST.FormatDato("Carga", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("TLGRSL").Caption = NPOI_ST.FormatDato("Origen", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("TLGRLL").Caption = NPOI_ST.FormatDato("Destino", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("FSLDCM").Caption = NPOI_ST.FormatDato("Fecha Salida", HelpClass_NPOI_ST.keyDatoFecha)
            dtExportar.Columns.Add("TGSTOS").Caption = NPOI_ST.FormatDato("Concepto", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("TIPO_CONCEPTO").Caption = NPOI_ST.FormatDato("Tipo Concepto", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("IGSTOS").Caption = NPOI_ST.FormatDato("Importe", HelpClass_NPOI_ST.keyDatoNumero)
            dtExportar.Columns.Add("TMNDA").Caption = NPOI_ST.FormatDato("Moneda", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("TOBDCT").Caption = NPOI_ST.FormatDato("Observación", HelpClass_NPOI_ST.keyDatoTexto)
            dtExportar.Columns.Add("FECINI").Caption = NPOI_ST.FormatDato("Fecha Inicio", HelpClass_NPOI_ST.keyDatoFecha)
            dtExportar.Columns.Add("FECFIN").Caption = NPOI_ST.FormatDato("Fecha Fin", HelpClass_NPOI_ST.keyDatoFecha)
            dtExportar.Columns.Add("NCTAVC").Caption = NPOI_ST.FormatDato("Nro AVC", HelpClass_NPOI_ST.keyDatoTexto)


            dtExportar = CopiarDatosTo(dtresult, dtExportar)


            'Dim NroLiq As String = ""
            'Dim Operacion As String = ""
            'Dim Origen As String = ""
            'Dim Destino As String = ""
            'For Each datarow As DataRow In dtExportar.Rows
            '    If NroLiq = "" Then
            '        NroLiq = datarow.Item("NLQGST").ToString().Trim()
            '        If Operacion = "" And Origen = "" And Destino = "" Then
            '            Operacion = datarow.Item("NOPRCN").ToString().Trim()
            '            Origen = datarow.Item("TLGRSL").ToString().Trim()
            '            Destino = datarow.Item("TLGRLL").ToString().Trim()
            '        End If
            '    Else
            '        If NroLiq = datarow.Item("NLQGST").ToString().Trim() Then
            '            datarow.Item("NLQGST") = ""
            '            datarow.Item("FECIDE") = ""
            '            datarow.Item("NPLCUN") = ""
            '            datarow.Item("NPLCAC") = ""
            '            datarow.Item("CBRCNT") = ""
            '            datarow.Item("CBRCND") = ""
            '            datarow.Item("SESTRG") = ""
            '            datarow.Item("USRCRT") = ""
            '            datarow.Item("FCHCRT") = ""
            '            datarow.Item("HRACRT") = ""
            '            datarow.Item("USRCRR") = ""
            '            datarow.Item("FCHCRR") = ""
            '            datarow.Item("HRACRR") = ""
            '            datarow.AcceptChanges()
            '            If Operacion = datarow.Item("NOPRCN").ToString().Trim() And Origen = datarow.Item("TLGRSL").ToString().Trim() And Destino = datarow.Item("TLGRLL").ToString().Trim() Then
            '                datarow.Item("NOPRCN") = ""
            '                datarow.Item("TCMPCL") = ""
            '                datarow.Item("TCNTCS") = ""
            '                datarow.Item("TDSCAR") = ""
            '                datarow.Item("TLGRSL") = ""
            '                datarow.Item("TLGRLL") = ""
            '                datarow.Item("FSLDCM") = ""
            '                datarow.AcceptChanges()
            '            Else
            '                Operacion = datarow.Item("NOPRCN").ToString().Trim()
            '                Origen = datarow.Item("TLGRSL").ToString().Trim()
            '                Destino = datarow.Item("TLGRLL").ToString().Trim()
            '            End If

            '        Else
            '            NroLiq = datarow.Item("NLQGST").ToString().Trim()
            '            Operacion = datarow.Item("NOPRCN").ToString().Trim()
            '            Origen = datarow.Item("TLGRSL").ToString().Trim()
            '            Destino = datarow.Item("TLGRLL").ToString().Trim()
            '        End If
            '    End If
            'Next

            Dim oListDtReport As New List(Of DataTable)
            dtExportar.TableName = "Liquidacion_Gastos_Detalle"
            oListDtReport.Add(dtExportar.Copy)

            Dim lstrPeriodo As String = ""
            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTA DE LIQUIDACIÓN DE GASTOS - DETALLE")

            Dim LisFiltros As New List(Of SortedList)

            Dim LisColNFilas As New List(Of String)
            LisColNFilas.Add("")

            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim LisColNameD As New List(Of String)
            Dim CombCol As String = ""
            CombCol = "NLQGST:NLQGST/1|FECIDE:NLQGST,FECIDE/1|NPLCUN:NLQGST,NPLCUN/1|NPLCAC:NLQGST,NPLCAC/1|CBRCNT:NLQGST,CBRCNT/1|"
            CombCol = CombCol & "CODIGOSAP:NLQGST,CODIGOSAP/1|CBRCND:NLQGST,CBRCND/1|SESTRG:NLQGST,SESTRG/1|USRCRT:NLQGST,USRCRT/1|FCHCRT:NLQGST,FCHCRT/1|"
            CombCol = CombCol & "HRACRT:NLQGST,HRACRT/1|USRCRR:NLQGST,USRCRR/1|FCHCRR:NLQGST,FCHCRR/1|HRACRR:NLQGST,HRACRR/1|"
            CombCol = CombCol & "NOPRCN:NLQGST,NOPRCN/1|TCMPCL:NLQGST,NOPRCN,TCMPCL/1|TCNTCS:NLQGST,NOPRCN,TCNTCS/1|"
            CombCol = CombCol & "TDSCAR:NLQGST,NOPRCN,TDSCAR/1|TLGRSL:NLQGST,NOPRCN,TLGRSL/1|TLGRLL:NLQGST,NOPRCN,TLGRLL/1|FSLDCM:NLQGST,NOPRCN,FSLDCM/1"
            LisColNameD.Add(CombCol)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(oListDtReport, ListTitulo, LisColNFilas, LisFiltros, 0, LisColNameD, Nothing)

            '       oDtLiqDetalle.TableName = "Liquidacion_Gastos_Detalle"
            'oListExportar.Add(oDtLiqDetalle)
            'HelpClass_NPOI.ExportExcel(oListExportar, strTitulo, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbiGastosAVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbiGastosAVC.Click
        Try

            Dim estadoFiltroLiq As String = ddlEstado.SelectedValue
            If estadoFiltroLiq = "T" Then
                estadoFiltroLiq = ""
            End If

            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim objetoParametro As New Hashtable
            If Trim(Me.txtLiquidacion.Text) = "" Then
                objetoParametro.Add("PNNLQGST", 0)
            Else
                objetoParametro.Add("PNNLQGST", Me.txtLiquidacion.Text)
            End If

            objetoParametro.Add("PSNPLCUN", Me.txtPlaca.Text)
            objetoParametro.Add("PSCBRCNT", Me.ctbConductor.pBrevete)
            'objetoParametro.Add("PSSESTRG", Asignar_Valor(Me.ddlEstado))
            objetoParametro.Add("PSSESTRG", estadoFiltroLiq)

            If Me.chkFecha.Checked = True Then
                objetoParametro.Add("PNFECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value))
                objetoParametro.Add("PNFECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value))
            Else
                objetoParametro.Add("PNFECINI", 0)
                objetoParametro.Add("PNFECFIN", 0)
            End If
            objetoParametro.Add("PSUSRCRT", Trim(KryptonTextBox1.Text))
            objetoParametro.Add("PSUSRCRR", Trim(KryptonTextBox2.Text))

            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SEGUIMIENTO_AVC"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SEGUIMIENTO AVC"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "SEGUIMIENTO Y CONTROL DE LIQUIDACIÓN AVC"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            ODs.Tables.Add(obj_Logica.Listar_Seguimiento_AVC(objetoParametro).Copy)
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "CLIENTE", "OPERACION", "AVC_IDA", "AVC_RETORNO", "ORIGEN", "DESTINO", _
                         "USUARIO_CREADOR", "USUARIO_LIQUIDADOR"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    Case "IMPORTE"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            'Listar_Liquidacion_Gastos_Detalle()
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbiExportarLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbiExportarLiquidacion.Click
        Try
            If (gwdDatos.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim oHasColumnas As New Hashtable
            Dim odtDatoExportar As New DataTable
            odtDatoExportar.TableName = "Liquidaciones"
            Dim dr As DataRow
            Dim oListExportar As New List(Of DataTable)
            Dim NameColumna As String = ""
            For Columna As Integer = 0 To gwdDatos.Columns.Count - 1
                NameColumna = gwdDatos.Columns(Columna).Name
                If (gwdDatos.Columns(Columna).Visible = True) Then
                    odtDatoExportar.Columns.Add(NameColumna)
                    oHasColumnas(NameColumna) = gwdDatos.Columns(Columna).HeaderText
                End If
            Next
            For Fila As Integer = 0 To gwdDatos.Rows.Count - 1
                dr = odtDatoExportar.NewRow
                For Columna As Integer = 0 To odtDatoExportar.Columns.Count - 1
                    NameColumna = odtDatoExportar.Columns(Columna).ColumnName
                    If (gwdDatos.Rows(Fila).Cells(NameColumna).Value IsNot Nothing) Then
                        dr(NameColumna) = gwdDatos.Rows(Fila).Cells(NameColumna).FormattedValue
                    End If
                Next
                odtDatoExportar.Rows.Add(dr)
            Next
            For Columna As Integer = 0 To odtDatoExportar.Columns.Count - 1
                NameColumna = odtDatoExportar.Columns(Columna).ColumnName
                odtDatoExportar.Columns(Columna).ColumnName = oHasColumnas(NameColumna)
            Next
            oListExportar.Add(odtDatoExportar)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oListExportar, "Lista de Liquidación de Gastos")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbiImprimirGastoFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbiImprimirGastoFecha.Click

        Try
            Dim frm_Opcion_LiquidacionGasto As New frmOpRptLiquidacionGasto
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim objetoParametro As New Hashtable
            Dim obj_DataSet As New DataSet
            Dim objPrintForm As New PrintForm
            Dim objReporte As New rptListaLiquidacionGasto

            With frm_Opcion_LiquidacionGasto
                frm_Opcion_LiquidacionGasto.CCMPN = "EZ" 'ACTUALMENTE SE TRABAJA CON UNA EMPRESA
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

                objetoParametro.Add("PNCCLNT", .CCLNT)
                objetoParametro.Add("PNFECINI", .FECINI)
                objetoParametro.Add("PNFECFIN", .FECFIN)
                objetoParametro.Add("PSNPLCUN", .NPLCUN)
                objetoParametro.Add("PSCBRCNT", .CBRCNT)
                obj_DataSet = obj_Logica.Listar_Liquidacion_Gastos_RPT(objetoParametro)
                If obj_DataSet.Tables.Count = 0 Then Exit Sub
                obj_DataSet.Tables(0).TableName = "RZTR58"
                obj_DataSet.Tables(1).TableName = "RZTR63"

                CType(objReporte.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECINI)
                CType(objReporte.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECFIN)
                Select Case .Tag
                    Case 0
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR FECHA"
                    Case 1
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CLIENTE"
                    Case 2
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CONDUCTOR"
                    Case 3
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR TRACTO"
                End Select
                objReporte.SetDataSource(obj_DataSet)

                objPrintForm.ShowForm(objReporte, Me)
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            Me.Limpiar_Controles()
            Me.Listar_Liquidacion_Gastos()
            Me.gwdOperacionLiquidacion.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbiImprimirGastoConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbiImprimirGastoConductor.Click

        Try
            Dim frm_Opcion_LiquidacionGasto As New frmOpRptLiquidacionGasto
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim objetoParametro As New Hashtable
            Dim obj_DataSet As New DataSet
            Dim objPrintForm As New PrintForm
            Dim objReporte As New rptLiquidacionGastoConductor

            With frm_Opcion_LiquidacionGasto
                frm_Opcion_LiquidacionGasto.CCMPN = "EZ" 'ACTUALMENTE SE TRABAJA CON UNA EMPRESA
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

                objetoParametro.Add("PNCCLNT", .CCLNT)
                objetoParametro.Add("PNFECINI", .FECINI)
                objetoParametro.Add("PNFECFIN", .FECFIN)
                objetoParametro.Add("PSNPLCUN", .NPLCUN)
                objetoParametro.Add("PSCBRCNT", .CBRCNT)
                obj_DataSet = obj_Logica.Listar_Liquidacion_Conductor_Gastos_RPT(objetoParametro)
                If obj_DataSet.Tables.Count = 0 Then Exit Sub
                obj_DataSet.Tables(0).TableName = "RZTR61_CONDUCTOR"

                CType(objReporte.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECINI)
                CType(objReporte.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECFIN)
                Select Case .Tag
                    Case 0
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR FECHA"
                    Case 1
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CLIENTE"
                    Case 2
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CONDUCTOR"
                    Case 3
                        CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR TRACTO"
                End Select
                objReporte.SetDataSource(obj_DataSet)

                objPrintForm.ShowForm(objReporte, Me)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '#End Region

    'Private Sub CancelarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    InfoLiqHeaderGroup.Visible = False
    'End Sub

    'Private Sub FecideCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (FecideCheckBox.Checked) Then
    '        FecideDateTimePicker.Enabled = True
    '        FecideDateTimePicker.Format = DateTimePickerFormat.Short
    '        FecideDateTimePicker.Value = Date.Today()
    '    Else
    '        FecideDateTimePicker.Enabled = False
    '        FecideDateTimePicker.Format = DateTimePickerFormat.Custom
    '        FecideDateTimePicker.CustomFormat = " "
    '        FecideDateTimePicker.Value = Date.FromOADate(0)
    '    End If
    'End Sub

    'Private Sub GrabarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim obj_Entidad As LiquidacionGastos
    '        Dim obj_Logica As New LiquidacionGastos_BLL

    '        obj_Entidad = New LiquidacionGastos
    '        obj_Entidad.NLQGST = NLiquidacionKryptonTextBox.Text
    '        If (FecideDateTimePicker.Value = Date.FromOADate(0)) Then
    '            obj_Entidad.FECIDE = 0
    '        Else
    '            obj_Entidad.FECIDE = HelpClass.CDate_a_Numero8Digitos(FecideDateTimePicker.Value)
    '        End If
    '        obj_Entidad.CULUSA = MainModule.USUARIO
    '        obj_Entidad.FULTAC = HelpClass.TodayNumeric
    '        obj_Entidad.HULTAC = HelpClass.NowNumeric
    '        obj_Entidad.NTRMNL = HelpClass.NombreMaquina

    '        obj_Logica.Registrar_FechaRecepcion_Gasto_Ruta_Operacion(obj_Entidad)
    '        Me.Limpiar_Controles()
    '        Me.Listar_Liquidacion_Gastos()
    '        Me.gwdOperacionLiquidacion.Rows.Clear()
    '        InfoLiqHeaderGroup.Visible = False
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
End Class

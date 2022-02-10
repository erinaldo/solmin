Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmLiquidarOperacion

#Region "Atributo Operación x Liquidación"

  Private gEnum_Mantenimiento_Operacion_x_Liquidacion As New MANTENIMIENTO
  Private mNLQGST As Double
  Private mNPLCUN As String
  Private mCBRCND As String
  Private mCTRSPT As Double
  Private mWidth_Operacion As Integer = 0
  Private mWidth_Gasto As Integer = 0
    Private mListaGasto As New List(Of ClaseGeneral)
    Private D_GR As New Dictionary(Of String, String)
#End Region

#Region "Atributo Gasto Ruta"
  Private gEnum_Mantenimiento_Gasto_Ruta As New MANTENIMIENTO
#End Region

#Region "Atributo Gasto Combustible"
  Private gEnum_Mantenimiento_Gasto_Combustible As New MANTENIMIENTO
#End Region

#Region "Properties Operación x Liquidación"

  Public Property NLQGST_1() As Double
    Get
      Return mNLQGST
    End Get
    Set(ByVal value As Double)
      mNLQGST = value
    End Set
  End Property

  Public Property CTRSPT_1() As Double
    Get
      Return mCTRSPT
    End Get
    Set(ByVal value As Double)
      mCTRSPT = value
    End Set
  End Property

  Public Property NPLCUN_1() As String
    Get
      Return mNPLCUN
    End Get
    Set(ByVal value As String)
      mNPLCUN = value
    End Set
  End Property

  Public Property CBRCND_1() As String
    Get
      Return mCBRCND
    End Get
    Set(ByVal value As String)
      mCBRCND = value
    End Set
  End Property

#End Region

#Region "Métodos y Funciones Operación x Liquidación"

    'Private Sub Alinear_Columnas_Grilla_Operacion_x_Liquidacion()
    '  Me.gwdOperacionLiquidacion.AutoGenerateColumns = False
    '  For lint_contador As Integer = 0 To Me.gwdOperacionLiquidacion.ColumnCount - 1
    '    Me.gwdOperacionLiquidacion.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next
    'End Sub

  Private Sub Limpiar_Controles_Operacion_x_Liquidacion()
    Me.txtRelacionGuia.Text = ""
    Me.txtDescripcionMerca.Text = ""
    Me.dtpFechaSalida.Value = Date.Today
    Me.dtpFechaLlegada.Value = Date.Today
    Me.txtKilometroXRecorrer.Text = ""
  End Sub

  Private Sub Estado_Controles_Operacion_x_Liquidacion(ByVal lbool_Estado As Boolean)
    Me.txtRelacionGuia.Enabled = lbool_Estado
    Me.txtDescripcionMerca.Enabled = lbool_Estado
    Me.txtKilometroXRecorrer.Enabled = lbool_Estado
    Me.dtpFechaSalida.Enabled = lbool_Estado
    Me.dtpFechaLlegada.Enabled = lbool_Estado
  End Sub

  Private Sub Cargar_Datos_Grilla_Operacion_x_Liquidacion()
    Me.Limpiar_Controles_Operacion_x_Liquidacion()
    Dim lint_indice As Integer = Me.gwdOperacionLiquidacion.CurrentCellAddress.Y
    Me.txtRelacionGuia.Text = Me.gwdOperacionLiquidacion.Item("TRLCGU_C", lint_indice).Value.ToString
    Me.txtDescripcionMerca.Text = Me.gwdOperacionLiquidacion.Item("TDSCAR_C", lint_indice).Value.ToString
    Me.txtKilometroXRecorrer.Text = Me.gwdOperacionLiquidacion.Item("NKMRTA_C", lint_indice).Value
    Me.dtpFechaSalida.Value = IIf(Me.gwdOperacionLiquidacion.Item("FSLDCM_C", lint_indice).Value = "", Date.Today, Me.gwdOperacionLiquidacion.Item("FSLDCM_C", lint_indice).Value)
    Me.dtpFechaLlegada.Value = IIf(Me.gwdOperacionLiquidacion.Item("FLLGCM_C", lint_indice).Value = "", Date.Today, Me.gwdOperacionLiquidacion.Item("FLLGCM_C", lint_indice).Value)

    Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.MODIFICAR
    Me.btnGuardarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    Me.btnGuardarOpeliqui.Text = "Modificar"
    Me.btnNuevoOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    Me.btnEliminarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
  End Sub

  Private Sub Listar_Operacion_x_Liquidacion()
    Dim objLogica As New LiquidacionGastos_BLL
    Dim objParametro As New Hashtable
    Dim dwv As DataGridViewRow

    objParametro.Add("PNNLQGST", Me.NLQGST_1)
    Me.gwdOperacionLiquidacion.Rows.Clear()

        For Each objEntidad As LiquidacionGastos In objLogica.Listar_Operacion_x_Liquidacion(objParametro)
            dwv = New DataGridViewRow()
            dwv.CreateCells(Me.gwdOperacionLiquidacion)
            dwv.Cells(0).Value = My.Resources.runprog
            dwv.Cells(1).Value = objEntidad.NLQGST
            dwv.Cells(2).Value = objEntidad.NOPRCN
            'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
            dwv.Cells(3).Value = objEntidad.NMSLPE
            dwv.Cells(4).Value = objEntidad.NRFSAP
            dwv.Cells(5).Value = objEntidad.AEJINS
            dwv.Cells(6).Value = objEntidad.ISLPES
            dwv.Cells(7).Value = objEntidad.TADSAP
            'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
            dwv.Cells(8).Value = objEntidad.NPLNMT
            dwv.Cells(9).Value = objEntidad.NCRRRT
            dwv.Cells(10).Value = objEntidad.CCNCST
            dwv.Cells(11).Value = objEntidad.TCNTCS
            dwv.Cells(12).Value = objEntidad.CCLNT
            dwv.Cells(13).Value = objEntidad.TCMPCL
            dwv.Cells(14).Value = objEntidad.TDSCAR
            dwv.Cells(15).Value = objEntidad.TLGRSL
            dwv.Cells(16).Value = objEntidad.FSLDCM_S
            dwv.Cells(17).Value = objEntidad.TLGRLL
            dwv.Cells(18).Value = objEntidad.FLLGCM_S
            dwv.Cells(19).Value = objEntidad.NKMRTA
            dwv.Cells(20).Value = objEntidad.TRLCGU

            Me.gwdOperacionLiquidacion.Rows.Add(dwv)
        Next

    If Me.gwdOperacionLiquidacion.RowCount > 0 Then
      Me.gwdOperacionLiquidacion.CurrentRow.Selected = False
    End If

  End Sub

  Private Sub AccionCancelar_Operacion_x_Liquidacion()
    Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.NEUTRAL
    For lint_Contador As Integer = 0 To Me.gwdOperacionLiquidacion.RowCount - 1
      Me.gwdOperacionLiquidacion.Item(0, lint_Contador).Value = My.Resources.runprog
    Next
    If Me.gwdOperacionLiquidacion.RowCount > 0 Then
      Me.gwdOperacionLiquidacion.CurrentRow.Selected = False
    End If
    Me.btnNuevoOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    Me.btnGuardarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
    Me.btnCancelarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
    Me.btnEliminarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
    Me.Limpiar_Controles_Operacion_x_Liquidacion()
    Me.Estado_Controles_Operacion_x_Liquidacion(False)
    'Me.Limpiar_Controles_Gasto_Ruta()
    Me.Limpiar_Controles_Gasto_Combustible()
  End Sub

  Private Sub Eliminar_Operacion_x_Liquidacion()
    Dim obj_Entidad As New LiquidacionGastos
        Dim obj_Logica As New LiquidacionGastos_BLL
        Dim NLQGST As Decimal = 0
        'Try
        obj_Entidad.NLQGST = CType(Me.txtNroLiquidacion.Text.Trim, Double)
        obj_Entidad.NOPRCN = CType(Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value, Double)
        obj_Entidad.NCRRRT = CType(Me.gwdOperacionLiquidacion.Item("NCRRRT_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value, Double)
        obj_Entidad.CULUSA = MainModule.USUARIO
        obj_Entidad.FULTAC = HelpClass.TodayNumeric
        obj_Entidad.HULTAC = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        'NLQGST = obj_Logica.Eliminar_Operacion_x_Liquidacion(obj_Entidad).NLQGST
        NLQGST = obj_Logica.Eliminar_Operacion_x_Liquidacion(obj_Entidad)
        If NLQGST = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        ElseIf obj_Entidad.NLQGST = -1 Then
            HelpClass.MsgBox("No se puede Eliminar tiene Gastos Asignados")
            Exit Sub
        Else
            HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
        End If
        Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.NEUTRAL
        Me.Listar_Operacion_x_Liquidacion()
        Me.AccionCancelar_Operacion_x_Liquidacion()
        Me.Listar_Gastos()
        Me.dtgGastoCombustible.Rows.Clear()
        'Catch ex As Exception
        '    End Try
  End Sub

  Private Sub Modificar_Registro_Operacion_x_Liquidacion()
    Dim obj_Entidad As New LiquidacionGastos
        Dim obj_Logica As New LiquidacionGastos_BLL
        Dim retorno As Decimal = 0
        'Try
        obj_Entidad.NLQGST = CType(Me.txtNroLiquidacion.Text.Trim, Double)
        obj_Entidad.NOPRCN = CType(Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value, Double)
        obj_Entidad.FLLGCM = CType(HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaLlegada.Value), Double)
        obj_Entidad.FSLDCM = CType(HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaSalida.Value), Double)
        obj_Entidad.TDSCAR = Me.txtDescripcionMerca.Text.Trim
        obj_Entidad.TRLCGU = Me.txtRelacionGuia.Text.Trim
        If Me.txtKilometroXRecorrer.TextLength = 0 Then
            obj_Entidad.NKMRTA = 0
        Else
            obj_Entidad.NKMRTA = CType(Me.txtKilometroXRecorrer.Text.Trim, Double)
        End If

        obj_Entidad.CULUSA = MainModule.USUARIO
        obj_Entidad.FULTAC = HelpClass.TodayNumeric
        obj_Entidad.HULTAC = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        If Me.gwdOperacionLiquidacion.Item("NCRRRT_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value = 0 Then
            ' obj_Entidad.NLQGST = obj_Logica.Registrar_Ruta_x_Operacion(obj_Entidad).NLQGST
            retorno = obj_Logica.Registrar_Ruta_x_Operacion(obj_Entidad)
        Else
            obj_Entidad.NCRRRT = Me.gwdOperacionLiquidacion.Item("NCRRRT_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
            'obj_Entidad.NLQGST = obj_Logica.Modificar_Ruta_x_Operacion(obj_Entidad).NLQGST
            retorno = obj_Logica.Modificar_Ruta_x_Operacion(obj_Entidad)
        End If

        'If obj_Entidad.NLQGST <> 0 Then
        If retorno <> 0 Then
            HelpClass.MsgBox("Se Modificó Satisfactoriamente")
            Me.Listar_Operacion_x_Liquidacion()
            Me.Listar_Gastos()
        Else
            HelpClass.ErrorMsgBox()
        End If
        'Catch ex As Exception
        '    End Try
  End Sub

  'Private Sub OcultarInformacionCabecera(ByVal blnStatus As Boolean, ByVal objeto_hg As Object, ByVal objeto_btn As Object, ByVal Width As Integer)
  '  If blnStatus Then
  '    objeto_hg.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
  '    objeto_hg.Width = Width
  '    objeto_btn.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
  '    objeto_btn.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
  '    objeto_btn.Text = "Visualizar"
  '  Else
  '    objeto_hg.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
  '    objeto_hg.Width = Width
  '    objeto_btn.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
  '    objeto_btn.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
  '    objeto_btn.Text = "Ocultar"
  '  End If
  'End Sub

#End Region

#Region "Eventos Operación x Liquidación"

    Private Sub frmLiquidarOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'OPERACION X LIQUIDACION
            Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.NEUTRAL
            Me.btnGuardarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Me.btnCancelarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Me.btnEliminarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            'Me.Alinear_Columnas_Grilla_Operacion_x_Liquidacion()
            Me.Limpiar_Controles_Operacion_x_Liquidacion()
            Me.Estado_Controles_Operacion_x_Liquidacion(False)
            Me.txtNroLiquidacion.Text = Me.NLQGST_1
            Me.txtPlaca.Text = Me.NPLCUN_1
            Me.txtConductor.Text = Me.CBRCND_1
            Me.Listar_Operacion_x_Liquidacion()
            'Me.mWidth_Operacion = Me.hgMantenimientoOpeLiquida.Width
            Me.hgMantenimientoOpeLiquida.Visible = False
            'Me.mWidth_Gasto = Me.hgGastoCombustible.Width

            If Me.gwdOperacionLiquidacion.RowCount = 0 Then Me.TabOpearcionXLiquidacion.Enabled = False

            'GASTO RUTA

            Me.gEnum_Mantenimiento_Gasto_Ruta = MANTENIMIENTO.NEUTRAL
            Me.Alinear_Columnas_Grilla_Gasto_Ruta()
            'Me.Limpiar_Controles_Gasto_Ruta()
            Me.Listar_Moneda_Gasto_Ruta()
            Me.Listar_Gastos_Gasto_Ruta()
            Me.Listar_Gastos()
            Me.gwdListaAVC.AutoGenerateColumns = False

            'GASTO COMBUSTIBLE

            Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.NEUTRAL
            Me.btnGuardarGastoCombustible.Enabled = False
            Me.btnCancelarGastoCombustible.Enabled = False
            Me.btnEliminarGastoCombustible.Enabled = False
            Me.Alinear_Columnas_Grilla_Gasto_Ruta()
            Me.Limpiar_Controles_Gasto_Combustible()
            Me.Estado_Controles_Gasto_Combustible(False)
            Me.Listar_Tipo_Combustible()
            Me.Listar_Grifo()
            Me.hgGastoCombustible.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub gwdOperacionLiquidacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdOperacionLiquidacion.CellClick
        Try
            If Me.gwdOperacionLiquidacion.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            If Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.EDITAR Then
                MsgBox("Debe Guardar o Cancelar la operación a realizar", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            For lint_Contador As Integer = 0 To Me.gwdOperacionLiquidacion.RowCount - 1
                Me.gwdOperacionLiquidacion.Item(0, lint_Contador).Value = My.Resources.runprog
            Next
            Me.gwdOperacionLiquidacion.Item(0, e.RowIndex).Value = My.Resources.button_ok1
            Me.Cargar_Datos_Grilla_Operacion_x_Liquidacion()
            Me.Listar_Gasto_x_Ruta()
            Me.Listar_Gasto_Combustible()
            Me.Limpiar_Controles_Gasto_Combustible()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  
  End Sub

  Private Sub gwdOperacionLiquidacion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdOperacionLiquidacion.KeyUp

        Try
            If Me.gwdOperacionLiquidacion.RowCount = 0 OrElse Me.gwdOperacionLiquidacion.CurrentCellAddress.Y < 0 Then Exit Sub
            'Me.gwdOperacionLiquidacion.CurrentRow.Selected = False
            Select Case e.KeyCode
                Case Keys.Up, Keys.Down, Keys.Enter
                    If Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.EDITAR Then
                        MsgBox("Debe Guardar o Cancelar la operación a realizar", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    For lint_Contador As Integer = 0 To Me.gwdOperacionLiquidacion.RowCount - 1
                        Me.gwdOperacionLiquidacion.Item(0, lint_Contador).Value = My.Resources.runprog
                    Next
                    Me.gwdOperacionLiquidacion.Item(0, Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value = My.Resources.button_ok1
                    Me.Cargar_Datos_Grilla_Operacion_x_Liquidacion()
                    Me.Listar_Gasto_x_Ruta()
                    Me.Listar_Gasto_Combustible()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  
  End Sub

  Private Sub btnEliminarOpeLiqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarOpeliqui.Click

        Try
            If Me.dtgGastoCombustible.RowCount > 0 Then
                HelpClass.MsgBox("No se puede Eliminar tiene Gastos Asignados", MessageBoxIcon.Information)
                Exit Sub
            End If
            For lint_Indice As Integer = 0 To Me.dtgGastoRuta.RowCount - 1
                If Me.dtgGastoRuta.Item("IGSTOS_G", lint_Indice).Value <> Nothing Then
                    HelpClass.MsgBox("No se puede Eliminar tiene Gastos Asignados", MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next
            If MsgBox("Desea Eliminar esta Operación", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            Me.Eliminar_Operacion_x_Liquidacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
  End Sub

  Private Sub btnNuevoOpeLiqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoOpeliqui.Click

        Try
            Dim frm_OpcionAgregarGuia As New frmOpcionAgregarGuia
            Dim frm_BuscarSolicitud As New frmBuscarSolicitudGuia
            Dim frm_ListaTractosPlaneamiento As New frmListaTractos_x_Planeamiento
            Dim frm_LiquidarOperacion As New frmLiquidarOperacion
            Dim obj_Entidad_Liquidacion As New LiquidacionGastos
            Dim obj_Logica_Liquidacion As New LiquidacionGastos_BLL

            With frm_OpcionAgregarGuia
                .NPLCTR = Me.txtPlaca.Text.Trim
                .CCMPN = "EZ"
                .CDVSN = "T"
                .CPLNDV = 0
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim obj_Logica_Guia As New GuiaTransportista_BLL
                Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
                Select Case .OPCION
                    Case 1
                        With frm_BuscarSolicitud
                            .btnGenerarGuiaTransporte.Visible = False
                            .btnAgregarGuiaTransporte.Visible = False
                            .ToolStripSeparator2.Visible = False
                            .ToolStripSeparator4.Visible = False
                            .btnAceptarLiquidacion.Visible = True
                            .txtTracto.Text = Me.txtPlaca.Text.Trim
                            .CCMPN_1 = "EZ"
                            .CDVSN_1 = "T"
                            '.CPLNDV_1 = 1
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
            obj_Entidad_Liquidacion.NLQGST = Me.NLQGST_1
            obj_Entidad_Liquidacion.USRCRT = MainModule.USUARIO
            obj_Entidad_Liquidacion.FCHCRT = HelpClass.TodayNumeric
            obj_Entidad_Liquidacion.HRACRT = HelpClass.NowNumeric
            obj_Entidad_Liquidacion.CULUSA = MainModule.USUARIO
            obj_Entidad_Liquidacion.FULTAC = HelpClass.TodayNumeric
            obj_Entidad_Liquidacion.HULTAC = HelpClass.NowNumeric
            obj_Entidad_Liquidacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            obj_Entidad_Liquidacion.NLQGST = obj_Logica_Liquidacion.Registrar_Liquidacion_Gasto(obj_Entidad_Liquidacion).NLQGST

            Select Case obj_Entidad_Liquidacion.NLQGST
                Case -2
                    HelpClass.MsgBox("Vehículo Y/O Conductor no coinciden al Retorno del Viaje ", MessageBoxIcon.Information)
                    Exit Sub
                Case -1
                    HelpClass.MsgBox("Vehículo en su última Liquidación, no esta Cerrada ", MessageBoxIcon.Information)
                    Exit Sub
                Case 0
                    HelpClass.ErrorMsgBox()
                    Exit Sub
            End Select

            Me.Listar_Operacion_x_Liquidacion()
            If Me.gwdOperacionLiquidacion.RowCount > 0 Then Me.TabOpearcionXLiquidacion.Enabled = True
            Me.AccionCancelar_Operacion_x_Liquidacion()
            Me.Listar_Gastos()
            Me.dtgGastoCombustible.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub btnGuardarOpeLiqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOpeliqui.Click
        Try
            If Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.EDITAR Then
                Me.Modificar_Registro_Operacion_x_Liquidacion()
                Me.AccionCancelar_Operacion_x_Liquidacion()
                Me.hgMantenimientoOpeLiquida.Visible = False
            ElseIf Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.MODIFICAR Then
                Me.Estado_Controles_Operacion_x_Liquidacion(True)
                Me.btnGuardarOpeliqui.Text = "Guardar"
                Me.btnNuevoOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                Me.btnCancelarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                Me.btnEliminarOpeliqui.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                Me.gEnum_Mantenimiento_Operacion_x_Liquidacion = MANTENIMIENTO.EDITAR
                Me.hgMantenimientoOpeLiquida.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
  End Sub

  Private Sub btnCancelarOpeLiqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarOpeliqui.Click
    Me.AccionCancelar_Operacion_x_Liquidacion()
    Me.hgMantenimientoOpeLiquida.Visible = False
    Me.Listar_Gastos()
    Me.dtgGastoCombustible.Rows.Clear()
  End Sub

#End Region

#Region "Métodos y Funciones Gasto Ruta"

  Private Sub Alinear_Columnas_Grilla_Gasto_Ruta()
    Me.dtgGastoRuta.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.dtgGastoRuta.ColumnCount - 1
      Me.dtgGastoRuta.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  'Private Sub Limpiar_Controles_Gasto_Ruta()
  '  For lint_Contador As Integer = Me.dtgGastoRuta.RowCount - 1 To 0 Step -1
  '    Select Case Me.dtgGastoRuta.Item(8, lint_Contador).Value
  '      Case 1
  '        Me.dtgGastoRuta.Item("NLQGST_G", lint_Contador).Value = ""
  '        Me.dtgGastoRuta.Item("NOPRCN_G", lint_Contador).Value = ""
  '        Me.dtgGastoRuta.Item("NCRRRT_G", lint_Contador).Value = ""
  '        Me.dtgGastoRuta.Item("IGSTOS_G", lint_Contador).Value = ""
  '        Me.dtgGastoRuta.Item("TOBDCT_G", lint_Contador).Value = ""
  '        Me.dtgGastoRuta.Item("NCTAVC_G", lint_Contador).Value = ""
  '        Me.dtgGastoRuta.Rows(lint_Contador).DefaultCellStyle.BackColor = Color.White
  '        Select Case Me.dtgGastoRuta.Item("cboGasto", lint_Contador).Value
  '          Case 1
  '            Me.dtgGastoRuta.Item("AGREGAR", lint_Contador).Value = "Asignar Comb."
  '            Me.dtgGastoRuta.Item("IGSTOS_G", lint_Contador).ReadOnly = True
  '          Case 14, 17
  '            Me.dtgGastoRuta.Item("AGREGAR", lint_Contador).Value = "Elegir AVC"
  '            Me.dtgGastoRuta.Item("IGSTOS_G", lint_Contador).ReadOnly = True
  '        End Select
  '      Case 2
  '        Me.dtgGastoRuta.Rows.RemoveAt(lint_Contador)
  '    End Select
  '  Next

  'End Sub

  Private Sub Listar_Gasto_x_Ruta()
    Dim objLogica As New LiquidacionGastos_BLL
    Dim objLista As New List(Of LiquidacionGastos)
    Dim objParametro As New Hashtable
    Dim dwv As DataGridViewRow
        'Try
        objParametro.Add("PNNLQGST", Me.NLQGST_1)
        objParametro.Add("PNNOPRCN", Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value)
        objParametro.Add("PNNCRRRT", Me.gwdOperacionLiquidacion.Item("NCRRRT_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value)

        objLista = objLogica.Listar_Gasto_Ruta_Operacion(objParametro)

        If objLista.Count = 0 Then
            Me.Listar_Gastos()
            Me.btnEliminarGastoRuta.Enabled = False
        Else
            Me.btnEliminarGastoRuta.Enabled = True
            Me.dtgGastoRuta.Rows.Clear()
            For Each objEntidad As LiquidacionGastos In objLista
                'For lint_Contador As Integer = 0 To Me.dtgGastoRuta.RowCount - 1
                dwv = New DataGridViewRow
                dwv.CreateCells(Me.dtgGastoRuta)
                dwv.Cells(dtgGastoRuta.Columns("NLQGST_G").Index).Value = objEntidad.NLQGST
                dwv.Cells(dtgGastoRuta.Columns("NOPRCN_G").Index).Value = objEntidad.NOPRCN
                dwv.Cells(dtgGastoRuta.Columns("NCRRRT_G").Index).Value = objEntidad.NCRRRT
                dwv.Cells(dtgGastoRuta.Columns("cboGasto").Index).Value = objEntidad.CGSTOS
                dwv.Cells(dtgGastoRuta.Columns("cboGasto").Index).ReadOnly = True
                dwv.Cells(dtgGastoRuta.Columns("TIPO_G").Index).Value = objEntidad.TIPO
                dwv.Cells(dtgGastoRuta.Columns("cboMoneda").Index).Value = CType(objEntidad.CDMNDA, Decimal)
                dwv.Cells(dtgGastoRuta.Columns("cboMoneda").Index).ReadOnly = True
                dwv.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).Value = objEntidad.IGSTOS
                dwv.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).ReadOnly = True
                'If objEntidad.CGSTOS = 1 Then dwv.Cells(5).ReadOnly = True
                dwv.Cells(dtgGastoRuta.Columns("TOBDCT_G").Index).Value = objEntidad.TOBDCT
                dwv.Cells(dtgGastoRuta.Columns("TOBDCT_G").Index).ReadOnly = True
                dwv.Cells(dtgGastoRuta.Columns("NCTAVC_G").Index).Value = objEntidad.NCTAVC
                dwv.Cells(dtgGastoRuta.Columns("NCTAVC_G").Index).ReadOnly = True
                dwv.Cells(dtgGastoRuta.Columns("STATUS_G").Index).Value = 2

                If (objEntidad.FECINI.Length > 0) Then
                    dwv.Cells(dtgGastoRuta.Columns("FECINI_G").Index).Value = Date.Parse(objEntidad.FECINI)
                End If
                If (objEntidad.FECFIN.Length > 0) Then
                    dwv.Cells(dtgGastoRuta.Columns("FECFIN_G").Index).Value = Date.Parse(objEntidad.FECFIN)
                End If
                dwv.Cells(dtgGastoRuta.Columns("FECINI_G").Index).ReadOnly = True
                dwv.Cells(dtgGastoRuta.Columns("FECFIN_G").Index).ReadOnly = True
                dwv.Cells(dtgGastoRuta.Columns("NCRRGT").Index).Value = objEntidad.NCRRGT  'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)

                Select Case objEntidad.CGSTOS
                    Case 1, 14, 17
                        If objEntidad.IGSTOS <> 0 Then dwv.Cells(dtgGastoRuta.Columns("AGREGAR").Index).Value = ""
                        'dwv.Cells(5).ReadOnly = False
                End Select
                Me.dtgGastoRuta.Rows.Add(dwv)
                'Next
            Next
        End If
        'Catch ex As Exception

        '    End Try

        If Me.dtgGastoRuta.RowCount > 0 Then
            Me.dtgGastoRuta.CurrentRow.Selected = False
        End If

  End Sub

  Private Sub AccionCancelar_Gasto_Ruta()
    Me.Listar_Gasto_x_Ruta()
  End Sub

  Private Sub Listar_Gastos()
    Dim obj_Logica As New LiquidacionGastos_BLL
        Dim dwv As DataGridViewRow

        Me.dtgGastoRuta.Rows.Clear()
        D_GR.Clear()
    For lint_Contador As Integer = 0 To Me.mListaGasto.Count - 1
            dwv = New DataGridViewRow()
            dwv.CreateCells(Me.dtgGastoRuta)
            dwv.Cells(dtgGastoRuta.Columns("cboGasto").Index).Value = Me.mListaGasto.Item(lint_Contador).CGSTOS
            dwv.Cells(dtgGastoRuta.Columns("cboGasto").Index).ReadOnly = True
            dwv.Cells(dtgGastoRuta.Columns("TIPO_G").Index).Value = Me.mListaGasto.Item(lint_Contador).TIPO
            dwv.Cells(dtgGastoRuta.Columns("cboMoneda").Index).Value = 1D
            Select Case Me.mListaGasto.Item(lint_Contador).CGSTOS
                Case 1
                    dwv.Cells(dtgGastoRuta.Columns("AGREGAR").Index).Value = "Asignar Combustible"
                    dwv.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).ReadOnly = True
                Case 14, 17
                    dwv.Cells(dtgGastoRuta.Columns("AGREGAR").Index).Value = "Elegir AVC"
                    dwv.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).ReadOnly = True
            End Select
            dwv.Cells(dtgGastoRuta.Columns("NCTAVC_G").Index).ReadOnly = True
            dwv.Cells(dtgGastoRuta.Columns("STATUS_G").Index).Value = 1
            dwv.Cells(dtgGastoRuta.Columns("AGREGAR").Index).ReadOnly = True
            dwv.Cells(dtgGastoRuta.Columns("NCRRGT").Index).Value = 0 'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
            ' Se agrega al diccionario
            D_GR.Add(Me.mListaGasto.Item(lint_Contador).CGSTOS, Me.mListaGasto.Item(lint_Contador).TIPO)
            Me.dtgGastoRuta.Rows.Add(dwv)
        Next
    End Sub

    Private Sub Listar_Moneda_Gasto_Ruta()
        Dim obj_Logica As New SOLMIN_ST.NEGOCIO.Moneda_BLL
        With Me.cboMoneda
            .DataSource = obj_Logica.Listar_Monedas_Combo("EZ")
            .ValueMember = "CMNDA1"
            .DisplayMember = "TMNDA"
        End With
    End Sub

    Private Sub Listar_Gastos_Gasto_Ruta()
        Dim obj_Logica As New LiquidacionGastos_BLL
        Me.mListaGasto = obj_Logica.Listar_Gastos
        With Me.cboGasto
            .DataSource = Me.mListaGasto
            .ValueMember = "CGSTOS"
            .DisplayMember = "TGSTOS"
        End With
    End Sub

    Private Sub Validar_Digitos_Importe(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
        Dim columna As Integer = Me.dtgGastoRuta.CurrentCell.ColumnIndex
        If columna = dtgGastoRuta.Columns("IGSTOS_G").Index Then
            If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Validar_Texto(ByVal sender As Object, ByVal e As EventArgs)
        If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
        Dim columna As Integer = Me.dtgGastoRuta.CurrentCell.ColumnIndex
        Select Case columna
            Case dtgGastoRuta.Columns("IGSTOS_G").Index
                If sender.Text <> "" Then
                    Me.dtgGastoRuta.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen
                Else
                    Me.dtgGastoRuta.CurrentRow.DefaultCellStyle.BackColor = Color.White
                End If
        End Select
    End Sub

    Private Sub Validar_Estado_Controles_Gasto_Ruta(ByVal lbool_Estado As Boolean)
        Me.panelAgregar.Visible = Not lbool_Estado
        Me.dtgGastoRuta.Enabled = lbool_Estado
        Me.MenuBar_2.Enabled = lbool_Estado
        Me.gwdOperacionLiquidacion.Enabled = lbool_Estado
    End Sub

    Private Sub Seleccionar_Valor(ByVal sender As Object, ByVal e As EventArgs)
        If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
        Select Case sender.SelectedValue
            Case 1
                Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).ReadOnly = True
                Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("AGREGAR").Index).Value = "Asignar Combustible"
                Exit Sub
            Case 14, 17
                Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).ReadOnly = True
                Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("AGREGAR").Index).Value = "Elegir AVC"
                Exit Sub
        End Select
        Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).ReadOnly = False
        Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("AGREGAR").Index).Value = ""
    End Sub

#End Region

#Region "Eventos Gasto Ruta"

    Private Sub gwdListaAVC_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdListaAVC.CellDoubleClick
        Try
            If Me.gwdListaAVC.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            For lint_Contador As Integer = 0 To Me.dtgGastoRuta.RowCount - 1
                If Me.dtgGastoRuta.Item("NCTAVC_G", lint_Contador).Value = Me.gwdListaAVC.Item(0, e.RowIndex).Value Then
                    HelpClass.MsgBox("Ya está asignado este AVC", MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next
            Me.dtgGastoRuta.Item("NCTAVC_G", Me.dtgGastoRuta.CurrentCellAddress.Y).Value = Me.gwdListaAVC.Item("NCTAVC", e.RowIndex).Value
            Me.dtgGastoRuta.Item("IGSTOS_G", Me.dtgGastoRuta.CurrentCellAddress.Y).Value = Me.gwdListaAVC.Item("IRTAVC", e.RowIndex).Value
            Me.Validar_Estado_Controles_Gasto_Ruta(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
    End Sub

    Private Sub dtgGastoRuta_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgGastoRuta.EditingControlShowing
        Try
            Select Case Me.dtgGastoRuta.CurrentCell.ColumnIndex
                Case dtgGastoRuta.Columns("cboGasto").Index
                    Dim cbo As DataGridViewComboBoxEditingControl = e.Control
                    AddHandler cbo.SelectionChangeCommitted, AddressOf Seleccionar_Valor
                Case dtgGastoRuta.Columns("IGSTOS_G").Index, dtgGastoRuta.Columns("TOBDCT_G").Index
                    Dim txt As DataGridViewTextBoxEditingControl = e.Control
                    AddHandler txt.KeyPress, AddressOf Validar_Digitos_Importe
                    AddHandler txt.TextChanged, AddressOf Validar_Texto
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


    Private Sub dtgGastoRuta_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGastoRuta.CellClick
        If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
        Try
            Select Case Me.dtgGastoRuta.CurrentCell.ColumnIndex
                Case Me.dtgGastoRuta.Columns("AGREGAR").Index
                    Dim lint_Codigo As Integer = Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("cboGasto").Index).Value
                    If lint_Codigo = 1 Then
                        Dim frm_GastoCombustible As New frmGastoCombustible
                        With frm_GastoCombustible
                            .NLQGST = Me.txtNroLiquidacion.Text
                            .NOPRCN = Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
                            .NKMRCR = Me.gwdOperacionLiquidacion.Item("NKMRTA_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
                            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("IGSTOS_G").Index).Value = .txtImporteGasto.Text
                            Me.Listar_Gasto_Combustible()
                        End With
                    ElseIf lint_Codigo = 14 OrElse lint_Codigo = 17 Then
                        Dim obj_Logica As New LiquidacionGastos_BLL
                        Dim dgvr As DataGridViewRow
                        Dim objParametro As New Hashtable
                        objParametro.Add("PSNPLCUN", Me.txtPlaca.Text.Trim)
                        Me.gwdListaAVC.Rows.Clear()
                        For Each obj_Entidad As ClaseGeneral In obj_Logica.Lista_AVC_x_Tracto(objParametro)
                            If obj_Entidad.CBRCNT = Me.txtConductor.Text.Trim.Substring(0, Me.txtConductor.Text.IndexOf(" ")) Then
                                dgvr = New DataGridViewRow
                                dgvr.CreateCells(Me.gwdListaAVC)
                                dgvr.Cells(0).Value = obj_Entidad.NCTAVC
                                dgvr.Cells(1).Value = obj_Entidad.CBRCNT
                                dgvr.Cells(2).Value = obj_Entidad.CBRCND
                                dgvr.Cells(3).Value = obj_Entidad.NPLCUN
                                dgvr.Cells(4).Value = obj_Entidad.IRTAVC
                                dgvr.Cells(5).Value = obj_Entidad.IARAVC
                                Me.gwdListaAVC.Rows.Add(dgvr)
                            End If
                        Next
                        If Me.gwdListaAVC.RowCount = 0 Then
                            HelpClass.MsgBox("No tiene AVC generado", MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        Me.Validar_Estado_Controles_Gasto_Ruta(False)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelarGastoRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarGastoRuta.Click
        If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
        Me.AccionCancelar_Gasto_Ruta()
    End Sub

    Private Sub btnProcesarGastoRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarGastoRuta.Click
        Try
            If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
            Dim obj_Entidad As LiquidacionGastos
            Dim list_Entidad As New List(Of LiquidacionGastos)
            Dim obj_Logica As New LiquidacionGastos_BLL


            For lint_Contador As Integer = 0 To Me.dtgGastoRuta.RowCount - 1
                Me.dtgGastoRuta.EndEdit()
                If Me.dtgGastoRuta.Item("IGSTOS_G", lint_Contador).Value <> Nothing And Me.dtgGastoRuta.Item("STATUS_G", lint_Contador).Value = 1 Then
                    If Me.dtgGastoRuta.Item("cboGasto", lint_Contador).Value = Nothing Then
                        HelpClass.MsgBox("Seleccione el Gasto a Liquidar" & Chr(13) & " Fila N° " & (lint_Contador + 1), MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    obj_Entidad = New LiquidacionGastos
                    obj_Entidad.NLQGST = Me.NLQGST_1
                    obj_Entidad.NOPRCN = Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
                    obj_Entidad.NCRRRT = Me.gwdOperacionLiquidacion.Item("NCRRRT_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
                    obj_Entidad.CGSTOS = Me.dtgGastoRuta.Item("cboGasto", lint_Contador).Value
                    obj_Entidad.CDMNDA = Me.dtgGastoRuta.Item("cboMoneda", lint_Contador).Value
                    obj_Entidad.IGSTOS = IIf(Me.dtgGastoRuta.Item("IGSTOS_G", lint_Contador).Value.ToString = "", 0, Me.dtgGastoRuta.Item("IGSTOS_G", lint_Contador).Value)
                    If Me.dtgGastoRuta.Item("TOBDCT_G", lint_Contador).Value <> Nothing Then obj_Entidad.TOBDCT = Me.dtgGastoRuta.Item("TOBDCT_G", lint_Contador).Value
                    If Me.dtgGastoRuta.Item("NCTAVC_G", lint_Contador).Value <> Nothing Then obj_Entidad.NCTAVC = IIf(Me.dtgGastoRuta.Item("NCTAVC_G", lint_Contador).Value.ToString = "", 0, Me.dtgGastoRuta.Item("NCTAVC_G", lint_Contador).Value)
                    If (CStr(Me.dtgGastoRuta.Item("FECINI_G", lint_Contador).Value) = String.Empty) Then
                        obj_Entidad.FECINI = 0
                    Else
                        obj_Entidad.FECINI = HelpClass.CFecha_a_Numero8Digitos(Me.dtgGastoRuta.Item("FECINI_G", lint_Contador).Value)
                    End If
                    If (CStr(Me.dtgGastoRuta.Item("FECFIN_G", lint_Contador).Value) = String.Empty) Then
                        obj_Entidad.FECFIN = 0
                    Else
                        obj_Entidad.FECFIN = HelpClass.CFecha_a_Numero8Digitos(Me.dtgGastoRuta.Item("FECFIN_G", lint_Contador).Value)
                    End If
                    obj_Entidad.CULUSA = MainModule.USUARIO
                    obj_Entidad.FULTAC = HelpClass.TodayNumeric
                    obj_Entidad.HULTAC = HelpClass.NowNumeric
                    obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    obj_Entidad.NCRRGT = Me.dtgGastoRuta.Item("NCRRGT", lint_Contador).Value 'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
                    list_Entidad.Add(obj_Entidad)
                End If

            Next
            obj_Logica.Registrar_Gasto_Ruta_Operacion(list_Entidad)
            Me.Listar_Gasto_x_Ruta()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtKilometroXRecorrer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilometroXRecorrer.KeyPress, txtKmRecorrer.KeyPress, txtImporteVenta.KeyPress, txtImporteCosto.KeyPress, txtCantidadGalones.KeyPress
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub btnNuevoGastoRuta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevoGastoRuta.Click
        Try
            If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim dwv As New DataGridViewRow()
            dwv.CreateCells(Me.dtgGastoRuta)
            dwv.Cells(dtgGastoRuta.Columns("cboGasto").Index).Value = Nothing
            dwv.Cells(dtgGastoRuta.Columns("cboGasto").Index).ReadOnly = False
            dwv.Cells(dtgGastoRuta.Columns("cboMoneda").Index).Value = 1D
            dwv.Cells(dtgGastoRuta.Columns("NCTAVC_G").Index).ReadOnly = True
            dwv.Cells(dtgGastoRuta.Columns("STATUS_G").Index).Value = 1
            dwv.Cells(dtgGastoRuta.Columns("NCRRGT").Index).Value = 0 'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
            Me.dtgGastoRuta.Rows.Add(dwv)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnCancelarAVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarAVC.Click
        Me.Validar_Estado_Controles_Gasto_Ruta(True)
    End Sub

#End Region

#Region "Eventos Gasto Combustible"

    Private Sub btnNuevoGastoCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoGastoCombustible.Click
        Try
            If Me.gwdOperacionLiquidacion.CurrentRow.Selected = False Then Exit Sub
            Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.NUEVO
            Me.btnGuardarGastoCombustible.Text = "Guardar"
            Me.btnGuardarGastoCombustible.Enabled = True
            Me.btnCancelarGastoCombustible.Enabled = True
            If Me.dtgGastoCombustible.Rows.Count > 0 Then
                Me.dtgGastoCombustible.CurrentRow.Selected = False
            End If
            Me.Estado_Controles_Gasto_Combustible(True)
            Me.Limpiar_Controles_Gasto_Combustible()
            Me.ctbTipoCombustible.Codigo = "D2"
            Me.hgGastoCombustible.Visible = True
            Me.gwdOperacionLiquidacion.Enabled = False
            Me.PanelFiltros.Enabled = False
            Me.txtKmRecorrer.Text = Me.gwdOperacionLiquidacion.Item("NKMRTA_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnGuardarGastoCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarGastoCombustible.Click
        Try
            If Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.NUEVO Then
                If Me.validar_inputs_Gasto_Combustible = True Then Exit Sub
                Me.Nuevo_Registro_Gasto_Combustible()
                Me.AccionCancelar_Gasto_Combustible()
                Me.hgGastoCombustible.Visible = False
            ElseIf Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.EDITAR Then
                Me.Modificar_Gasto_Combustible()
                Me.AccionCancelar_Gasto_Combustible()
                Me.hgGastoCombustible.Visible = False
            ElseIf Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.MODIFICAR Then
                Me.Estado_Controles_Gasto_Combustible(True)
                Me.btnGuardarGastoCombustible.Text = "Guardar"
                Me.txtValeRansa.Enabled = False
                Me.btnNuevoGastoCombustible.Enabled = False
                Me.btnCancelarGastoCombustible.Enabled = True
                Me.btnEliminarGastoCombustible.Enabled = False
                Me.hgGastoCombustible.Visible = True
                Me.gwdOperacionLiquidacion.Enabled = False
                Me.PanelFiltros.Enabled = False
                Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.EDITAR
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelarGastoCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarGastoCombustible.Click
        Me.AccionCancelar_Gasto_Combustible()
    End Sub

    Private Sub btnEliminarGastoCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarGastoCombustible.Click
        Try
            If MsgBox("Desea Eliminar este Gasto Combustible", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            Me.Eliminar_Gasto_Combustible()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub dtgGastoCombustible_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGastoCombustible.CellClick

        Try
            If Me.dtgGastoCombustible.RowCount = 0 OrElse Me.dtgGastoCombustible.CurrentCellAddress.Y < 0 Then Exit Sub

            If Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.EDITAR Then
                If Me.dtgGastoCombustible.Rows.Count > 0 Then
                    Me.dtgGastoCombustible.CurrentRow.Selected = False
                End If
                MsgBox("Debe Guardar o Cancelar la Operación", MsgBoxStyle.Exclamation)
                Exit Sub
                'ElseIf Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.NEUTRAL Then
                '  Me.Limpiar_Controles_Gasto_Combustible()
                '  If Me.dtgGastoCombustible.Rows.Count > 0 Then
                '    Me.dtgGastoCombustible.CurrentRow.Selected = True
                '  End If
            End If
            'Me.Limpiar_Controles_Gasto_Combustible()
            Me.Cargar_Datos_Grilla_Gasto_Combustible()
            Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.MODIFICAR
            Me.btnGuardarGastoCombustible.Enabled = True
            Me.btnGuardarOpeliqui.Text = "Modificar"
            Me.btnNuevoGastoCombustible.Enabled = True
            Me.btnEliminarGastoCombustible.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  
    End Sub

    Private Sub txtValeRansa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValeRansa.KeyPress, txtValeGrifo.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub btnEliminarGastoRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarGastoRuta.Click
        Try
            If Me.dtgGastoRuta.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.dtgGastoRuta.CurrentCell.Selected = False Then Exit Sub
            If Me.dtgGastoRuta.Item("STATUS_G", Me.dtgGastoRuta.CurrentCellAddress.Y).Value = 1 Then Exit Sub

            If MessageBox.Show("Está seguro de eliminar el gasto", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim obj_Entidad As New LiquidacionGastos
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim lint_Indice As Integer = Me.dtgGastoRuta.CurrentCellAddress.Y
            obj_Entidad.NLQGST = Me.NLQGST_1
            obj_Entidad.NOPRCN = Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
            obj_Entidad.NCRRRT = Me.gwdOperacionLiquidacion.Item("NCRRRT_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
            obj_Entidad.CGSTOS = Me.dtgGastoRuta.Item("cboGasto", lint_Indice).Value
            'obj_Entidad.IGSTOS = Me.dtgGastoRuta.Item("IGSTOS_G", lint_Indice).Value
            obj_Entidad.NCRRGT = Me.dtgGastoRuta.Item("NCRRGT", lint_Indice).Value
            If Not IsNumeric(Me.dtgGastoRuta.Item("NCTAVC_G", lint_Indice).Value) Then
                obj_Entidad.NCTAVC = 0
            Else
                obj_Entidad.NCTAVC = Me.dtgGastoRuta.Item("NCTAVC_G", lint_Indice).Value
            End If
            obj_Entidad.CULUSA = MainModule.USUARIO
            obj_Entidad.FULTAC = HelpClass.TodayNumeric
            obj_Entidad.HULTAC = HelpClass.NowNumeric
            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            obj_Logica.Eliminar_Gasto_Ruta_Operacion(obj_Entidad)
            Me.Listar_Gasto_x_Ruta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgGastoRuta_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGastoRuta.CellValueChanged

        Try
            If Me.gwdOperacionLiquidacion.CurrentCellAddress.Y < 0 Then Exit Sub
            Select Case e.ColumnIndex
                Case dtgGastoRuta.Columns("IGSTOS_G").Index
                    If Me.dtgGastoRuta.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing Then Exit Sub
                    If Not Me.dtgGastoRuta.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Trim.Equals("") Then
                        Me.dtgGastoRuta.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen
                    Else
                        Me.dtgGastoRuta.CurrentRow.DefaultCellStyle.BackColor = Color.White
                    End If

                Case dtgGastoRuta.Columns("cboGasto").Index
                    If (D_GR.ContainsKey(dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("cboGasto").Index).Value)) Then
                        Me.dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("TIPO_G").Index).Value = D_GR.Item(dtgGastoRuta.CurrentRow.Cells(dtgGastoRuta.Columns("cboGasto").Index).Value)
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

#End Region

#Region "Métodos y Funciones Gasto Combustible"

    Private Sub Limpiar_Controles_Gasto_Combustible()
        Me.txtValeGrifo.Text = ""
        Me.txtValeRansa.Text = ""
        Me.ctbTipoCombustible.Limpiar()
        Me.ctbGrifo.Limpiar()
        Me.dtpFechaCarga.Value = Date.Today
        Me.txtCantidadGalones.Text = ""
        Me.txtImporteCosto.Text = ""
        Me.txtKmRecorrer.Text = ""
        Me.txtImporteVenta.Text = ""
    End Sub

    Private Sub Estado_Controles_Gasto_Combustible(ByVal lbool_Estado As Boolean)
        Me.txtValeGrifo.Enabled = lbool_Estado
        Me.txtValeRansa.Enabled = lbool_Estado
        Me.ctbTipoCombustible.Enabled = lbool_Estado
        Me.ctbGrifo.Enabled = lbool_Estado
        Me.dtpFechaCarga.Enabled = lbool_Estado
        Me.txtCantidadGalones.Enabled = lbool_Estado
        Me.txtImporteCosto.Enabled = lbool_Estado
        Me.txtKmRecorrer.Enabled = lbool_Estado
        Me.txtImporteVenta.Enabled = lbool_Estado
    End Sub

    Private Sub Nuevo_Registro_Gasto_Combustible()
        Dim obj_Entidad As New LiquidacionGastos
        Dim obj_Logica As New LiquidacionGastos_BLL
        'Try
        obj_Entidad.NLQGST = Me.NLQGST_1
        obj_Entidad.NOPRCN = Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
        obj_Entidad.NVLRNS = Me.txtValeRansa.Text.Trim
        obj_Entidad.NVLGRF = IIf(Me.txtValeGrifo.Text.Trim = "", 0, Me.txtValeGrifo.Text.Trim)
        obj_Entidad.CGRFO = IIf(Me.ctbGrifo.Codigo.Trim = "", 0, Me.ctbGrifo.Codigo.Trim)
        obj_Entidad.FCRCMB = HelpClass.CDate_a_Numero8Digitos((Me.dtpFechaCarga.Value))
        obj_Entidad.QGLNCM = IIf(Me.txtCantidadGalones.Text.Trim = "", 0, Me.txtCantidadGalones.Text.Trim)
        obj_Entidad.CTPCMB = Me.ctbTipoCombustible.Codigo
        obj_Entidad.NKMRCR = IIf(Me.txtKmRecorrer.Text.Trim = "", 0, Me.txtKmRecorrer.Text.Trim)
        obj_Entidad.ICSTOS = IIf(Me.txtImporteCosto.Text.Trim = "", 0, Me.txtImporteCosto.Text.Trim)
        obj_Entidad.IVNTAS = IIf(Me.txtImporteVenta.Text.Trim = "", 0, Me.txtImporteVenta.Text.Trim)
        obj_Entidad.CULUSA = MainModule.USUARIO
        obj_Entidad.FULTAC = HelpClass.TodayNumeric
        obj_Entidad.HULTAC = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        obj_Entidad.NLQGST = obj_Logica.Registrar_Gasto_Combustible(obj_Entidad).NLQGST

        If obj_Entidad.NLQGST = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            HelpClass.MsgBox("Se Registró Satisfactoriamente")
            Me.Listar_Gasto_Combustible()
        End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Modificar_Gasto_Combustible()
        Dim obj_Entidad As New LiquidacionGastos
        Dim obj_Logica As New LiquidacionGastos_BLL
        'Try
        obj_Entidad.NLQGST = Me.NLQGST_1
        obj_Entidad.NOPRCN = Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value
        obj_Entidad.NVLRNS = Me.txtValeRansa.Text.Trim
        obj_Entidad.NVLGRF = IIf(Me.txtValeGrifo.Text.Trim = "", 0, Me.txtValeGrifo.Text.Trim)
        obj_Entidad.CGRFO = IIf(Me.ctbGrifo.Codigo.Trim = "", 0, Me.ctbGrifo.Codigo)
        obj_Entidad.FCRCMB = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaCarga.Value)
        obj_Entidad.QGLNCM = IIf(Me.txtCantidadGalones.Text.Trim = "", 0, Me.txtCantidadGalones.Text.Trim)
        obj_Entidad.CTPCMB = IIf(Me.ctbTipoCombustible.Codigo.Trim = "", 0, Me.ctbTipoCombustible.Codigo.Trim)
        obj_Entidad.NKMRCR = IIf(Me.txtKmRecorrer.Text.Trim = "", 0, Me.txtKmRecorrer.Text.Trim)
        obj_Entidad.ICSTOS = IIf(Me.txtImporteCosto.Text.Trim = "", 0, Me.txtImporteCosto.Text.Trim)
        obj_Entidad.IVNTAS = IIf(Me.txtImporteVenta.Text.Trim = "", 0, Me.txtImporteVenta.Text.Trim)
        obj_Entidad.CULUSA = MainModule.USUARIO
        obj_Entidad.FULTAC = HelpClass.TodayNumeric
        obj_Entidad.HULTAC = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        obj_Entidad.NLQGST = obj_Logica.Modificar_Gasto_Combustible(obj_Entidad).NLQGST

        If obj_Entidad.NLQGST <> 0 Then
            HelpClass.MsgBox("Se Modificó Satisfactoriamente")
            Me.Listar_Gasto_Combustible()
        Else
            HelpClass.ErrorMsgBox()
        End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Eliminar_Gasto_Combustible()
        Dim obj_Entidad As New LiquidacionGastos
        Dim obj_Logica As New LiquidacionGastos_BLL
        'Try
        obj_Entidad.NLQGST = Me.dtgGastoCombustible.Item("NLQGST_GC", Me.dtgGastoCombustible.CurrentCellAddress.Y).Value
        obj_Entidad.NOPRCN = Me.dtgGastoCombustible.Item("NOPRCN_GC", Me.dtgGastoCombustible.CurrentCellAddress.Y).Value
        obj_Entidad.NVLRNS = Me.dtgGastoCombustible.Item("NVLRNS_GC", Me.dtgGastoCombustible.CurrentCellAddress.Y).Value
        obj_Entidad.NLQGST = obj_Logica.Eliminar_Gasto_Combustible(obj_Entidad).NLQGST
        If obj_Entidad.NLQGST = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            HelpClass.MsgBox("Se Elimino Satisfactoriamente")
        End If
        Me.gEnum_Mantenimiento_Gasto_Ruta = MANTENIMIENTO.NEUTRAL
        Me.Listar_Gasto_Combustible()
        Me.AccionCancelar_Gasto_Combustible()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Function validar_inputs_Gasto_Combustible() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        If Me.txtValeRansa.TextLength = 0 OrElse Me.txtValeRansa.Text = 0 Then
            lstr_validacion += "* VALE RANSA " & Chr(13)
        End If
        If Me.txtValeGrifo.TextLength = 0 OrElse Me.txtValeGrifo.Text = 0 Then
            lstr_validacion += "* VALE GRIFO " & Chr(13)
        End If
        If Me.ctbGrifo.NoHayCodigo = True Then
            lstr_validacion += "* GRIFO" & Chr(13)
        End If
        If Me.ctbTipoCombustible.NoHayCodigo = True Then
            lstr_validacion += "* TIPO COMBUSTIBLE " & Chr(13)
        End If
        If Me.txtCantidadGalones.TextLength = 0 OrElse Me.txtCantidadGalones.Text = 0 Then
            lstr_validacion += "* CANTIDAD GALONES " & Chr(13)
        End If
        If Me.txtKmRecorrer.TextLength = 0 OrElse Me.txtKmRecorrer.Text = 0 Then
            lstr_validacion += "* KILOMETROS RECORRER " & Chr(13)
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub AccionCancelar_Gasto_Combustible()
        Me.gEnum_Mantenimiento_Gasto_Combustible = MANTENIMIENTO.NEUTRAL
        If Me.dtgGastoCombustible.Rows.Count > 0 Then
            Me.dtgGastoCombustible.CurrentRow.Selected = False
        End If
        Me.btnNuevoGastoCombustible.Enabled = True
        Me.btnGuardarGastoCombustible.Enabled = False
        Me.btnCancelarGastoCombustible.Enabled = False
        Me.btnEliminarGastoCombustible.Enabled = False
        Me.Limpiar_Controles_Gasto_Combustible()
        Me.Estado_Controles_Gasto_Combustible(False)
        Me.hgGastoCombustible.Visible = False
        Me.gwdOperacionLiquidacion.Enabled = True
        Me.PanelFiltros.Enabled = True
        Me.hgGastoCombustible.Visible = False
    End Sub

    Private Sub Cargar_Datos_Grilla_Gasto_Combustible()
        Me.Limpiar_Controles_Gasto_Combustible()
        Dim lint_indice As Integer = Me.dtgGastoCombustible.CurrentCellAddress.Y
        Me.txtValeGrifo.Text = Me.dtgGastoCombustible.Item("NVLGRF_GC", lint_indice).Value
        Me.txtValeRansa.Text = Me.dtgGastoCombustible.Item("NVLRNS_GC", lint_indice).Value
        Me.ctbTipoCombustible.Codigo = Me.dtgGastoCombustible.Item("CTPCMB_GC", lint_indice).Value
        Me.ctbGrifo.Codigo = Me.dtgGastoCombustible.Item("CGRFO_GC", lint_indice).Value
        Me.dtpFechaCarga.Value = Me.dtgGastoCombustible.Item("FCRCMB_GC", lint_indice).Value
        Me.txtCantidadGalones.Text = Me.dtgGastoCombustible.Item("QGLNCM_GC", lint_indice).Value
        Me.txtImporteCosto.Text = Me.dtgGastoCombustible.Item("ICSTOS_GC", lint_indice).Value
        Me.txtKmRecorrer.Text = Me.dtgGastoCombustible.Item("NKMRCR_GC", lint_indice).Value
        Me.txtImporteVenta.Text = Me.dtgGastoCombustible.Item("IVNTAS_GC", lint_indice).Value
        Me.gEnum_Mantenimiento_Gasto_Ruta = MANTENIMIENTO.MODIFICAR
        Me.btnGuardarGastoCombustible.Enabled = True
        Me.btnGuardarGastoCombustible.Text = "Modificar"
        Me.btnNuevoGastoCombustible.Enabled = True
        Me.btnEliminarGastoCombustible.Enabled = True
    End Sub

    Private Sub Listar_Gasto_Combustible()
        Dim objLogica As New LiquidacionGastos_BLL
        Dim objParametro As New Hashtable
        Dim dwv As DataGridViewRow
        'Try
        objParametro.Add("PNNLQGST", Me.NLQGST_1)
        objParametro.Add("PNNOPRCN", Me.gwdOperacionLiquidacion.Item("NOPRCN_C", Me.gwdOperacionLiquidacion.CurrentCellAddress.Y).Value)
        Me.dtgGastoCombustible.Rows.Clear()

        For Each objEntidad As LiquidacionGastos In objLogica.Listar_Gasto_Combustible(objParametro)
            dwv = New DataGridViewRow()
            dwv.CreateCells(Me.dtgGastoCombustible)

            dwv.Cells(0).Value = objEntidad.NLQGST
            dwv.Cells(1).Value = objEntidad.NOPRCN
            dwv.Cells(2).Value = objEntidad.NVLRNS
            dwv.Cells(3).Value = objEntidad.NVLGRF
            dwv.Cells(4).Value = objEntidad.FCRCMB_S
            dwv.Cells(5).Value = objEntidad.CGRFO
            dwv.Cells(6).Value = objEntidad.TGRFO
            dwv.Cells(7).Value = objEntidad.TGRIFO
            dwv.Cells(8).Value = objEntidad.CTPCMB
            dwv.Cells(9).Value = objEntidad.TDSCMB
            dwv.Cells(10).Value = objEntidad.QGLNCM
            dwv.Cells(11).Value = objEntidad.NKMRCR
            dwv.Cells(12).Value = objEntidad.ICSTOS
            dwv.Cells(13).Value = objEntidad.IVNTAS
            dwv.Cells(14).Value = objEntidad.NRSCVL

            Me.dtgGastoCombustible.Rows.Add(dwv)
        Next

        If Me.dtgGastoCombustible.RowCount > 0 Then
            Me.dtgGastoCombustible.CurrentRow.Selected = False
        End If
        'Catch : End Try

    End Sub

    Private Sub Listar_Tipo_Combustible()
        Dim obj_Logica As New TipoCombustible_BLL
        With Me.ctbTipoCombustible
            .DataSource = HelpClass.GetDataSetNative(obj_Logica.Listar_TipoCombustible)
            .KeyField = "CTPCMB"
            .ValueField = "TDSCMB"
            .DataBind()
        End With
    End Sub

    Private Sub Listar_Grifo()
        Dim obj_Logica As New Grifo_BLL
        With Me.ctbGrifo
            .DataSource = HelpClass.GetDataSetNative(obj_Logica.Listar_Grifos())
            .KeyField = "CGRFO"
            .ValueField = "TGRFO"
            .DataBind()
        End With
    End Sub

#End Region

    Private Sub dtgGastoRuta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgGastoRuta.KeyDown
        If (dtgGastoRuta.CurrentCell.ColumnIndex = dtgGastoRuta.Columns("FECINI_G").Index Or dtgGastoRuta.CurrentCell.ColumnIndex = dtgGastoRuta.Columns("FECFIN_G").Index) Then
            If (CStr(dtgGastoRuta.CurrentCell.Value) <> String.Empty) Then
                If (e.KeyCode = Keys.Delete) Then
                    dtgGastoRuta.CurrentCell.Value = String.Empty
                End If
            End If
        End If
    End Sub

    Private Sub btnModificarGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarGasto.Click
        Try
            If dtgGastoRuta.Rows.Count > 0 Then
                If dtgGastoRuta.CurrentRow.Cells("STATUS_G").Value = 2 Then


                    'Select Case objEntidad.CGSTOS
                    '    Case 1, 14, 17
                    Dim CodGasto As Decimal = dtgGastoRuta.CurrentRow.Cells("cboGasto").Value
                    Select Case CodGasto
                        Case 1, 14, 17
                            MessageBox.Show("Elimine y asigne nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                    End Select


                    Dim ofrmModifcarGasto As New frmModifcarGasto
                    Dim pLiquidacionGastos As New LiquidacionGastos
                    pLiquidacionGastos.NLQGST = Me.NLQGST_1
                    pLiquidacionGastos.NOPRCN = gwdOperacionLiquidacion.CurrentRow.Cells("NOPRCN_C").Value
                    pLiquidacionGastos.NCRRRT = gwdOperacionLiquidacion.CurrentRow.Cells("NCRRRT_C").Value
                    pLiquidacionGastos.CGSTOS = dtgGastoRuta.CurrentRow.Cells("cboGasto").Value
                    pLiquidacionGastos.IGSTOS_COD = dtgGastoRuta.CurrentRow.Cells("IGSTOS_G").Value


                    pLiquidacionGastos.IGSTOS = dtgGastoRuta.CurrentRow.Cells("IGSTOS_G").Value
                    pLiquidacionGastos.FECINI_S = ("" & dtgGastoRuta.CurrentRow.Cells("FECINI_G").Value).ToString.Trim
                    pLiquidacionGastos.FECFIN_S = ("" & dtgGastoRuta.CurrentRow.Cells("FECFIN_G").Value).ToString.Trim
                    pLiquidacionGastos.MONEDA = ("" & dtgGastoRuta.CurrentRow.Cells("cboMoneda").FormattedValue).ToString.Trim
                    pLiquidacionGastos.GASTO_DESC = ("" & dtgGastoRuta.CurrentRow.Cells("cboGasto").FormattedValue).ToString.Trim
                    pLiquidacionGastos.TIPO = ("" & dtgGastoRuta.CurrentRow.Cells("TIPO_G").Value).ToString.Trim
                    pLiquidacionGastos.TOBDCT = ("" & dtgGastoRuta.CurrentRow.Cells("TOBDCT_G").Value).ToString.Trim
                    pLiquidacionGastos.NCRRGT = dtgGastoRuta.CurrentRow.Cells("NCRRGT").Value 'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
                    ofrmModifcarGasto.pLiquidacionGastos = pLiquidacionGastos
                    If ofrmModifcarGasto.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.Listar_Gasto_x_Ruta()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 

    Private Sub dtgGastoRuta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGastoRuta.CellContentClick

    End Sub

    Private Sub btnGastosSpeSap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGastosSpeSap.Click
        If gwdOperacionLiquidacion.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro para continuar con la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If gwdOperacionLiquidacion.CurrentRow.Cells("NRFSAP").Value.ToString() = String.Empty Or gwdOperacionLiquidacion.CurrentRow.Cells("NRFSAP").Value.ToString() = "0" Then
            MessageBox.Show("Debe asignar SPE con ref Ped SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim formulario As New frmListarGastos
            formulario.Operacion.PSCCMPN = "EZ"
            formulario.Operacion.NRFSAP = gwdOperacionLiquidacion.CurrentRow.Cells("NRFSAP").Value
            formulario.Operacion.AEJINS = gwdOperacionLiquidacion.CurrentRow.Cells("AEJINS").Value
            formulario.Operacion.NLQGST_C = gwdOperacionLiquidacion.CurrentRow.Cells("NLQGST_C").Value
            formulario.Operacion.NOPRCN_C = gwdOperacionLiquidacion.CurrentRow.Cells("NOPRCN_C").Value
            formulario.Operacion.NCRRRT_C = gwdOperacionLiquidacion.CurrentRow.Cells("NCRRRT_C").Value
            formulario.ShowDialog()
            Listar_Gasto_x_Ruta()
        End If
    End Sub

    Private Sub btnAsignarSPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarSPE.Click
        If gwdOperacionLiquidacion.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim formulario As New frmAsignarSPE
        formulario.Operacion.PSCCMPN = "EZ"
        formulario.Operacion.PSCDVN = "T"
        formulario.Operacion.PNNOPRCN = gwdOperacionLiquidacion.CurrentRow.Cells("NOPRCN_C").Value
        formulario.Operacion.NLQGST_C = gwdOperacionLiquidacion.CurrentRow.Cells("NLQGST_C").Value
        formulario.Operacion.NOPRCN_C = gwdOperacionLiquidacion.CurrentRow.Cells("NOPRCN_C").Value
        formulario.Operacion.NCRRRT_C = gwdOperacionLiquidacion.CurrentRow.Cells("NCRRRT_C").Value
        formulario.ShowDialog()
        Listar_Operacion_x_Liquidacion()
    End Sub

    Private Sub btnEliminarSPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarSPE.Click
        If gwdOperacionLiquidacion.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro para continuar con la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Está seguro de eliminar la asignación del SPE?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim liquidarOperacion As New LiquidarOperacion_BL
            Dim liquidacionGastos As New LiquidacionGastos
            liquidacionGastos.CCMPN = "EZ"
            liquidacionGastos.NLQGST = gwdOperacionLiquidacion.CurrentRow.Cells("NLQGST_C").Value
            liquidacionGastos.NOPRCN = gwdOperacionLiquidacion.CurrentRow.Cells("NOPRCN_C").Value
            liquidacionGastos.NCRRRT = gwdOperacionLiquidacion.CurrentRow.Cells("NCRRRT_C").Value
            liquidacionGastos.TPSLPE = String.Empty
            liquidacionGastos.NMSLPE = 0
            liquidacionGastos.CULUSA = MainModule.USUARIO
            liquidarOperacion.ActualizarRutaOperacionSolicitudPedido(liquidacionGastos)
            Listar_Operacion_x_Liquidacion()
        End If
    End Sub
End Class

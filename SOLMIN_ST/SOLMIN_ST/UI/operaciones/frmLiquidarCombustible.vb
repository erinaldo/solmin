Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmLiquidarCombustible

#Region "Variables"
  Private mLista As New List(Of Combustible)
  'Private mValido As Boolean = True
  Private mQGLNSA As Double
#End Region

#Region "Properties"
  Public WriteOnly Property Lista() As List(Of Combustible)
    Set(ByVal value As List(Of Combustible))
      mLista = value
    End Set
  End Property

  Public WriteOnly Property QGLNSA() As Double
    Set(ByVal value As Double)
      mQGLNSA = value
    End Set
  End Property
#End Region

#Region "Eventos"

  Private Sub frmLiquidarCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Alinear_Columnas_Grilla()
    Me.Lista_Vales_Combustible()
    Me.txtGalonesAsignados.Text = 0.0
    Me.txtGalonesTanque.Text = 0.0
    Me.txtGalonesUtilizados.Text = 0.0
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub btnAsignarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOperacion.Click
    Dim frm_OpcionAgregarOperacion As New frmOpcionAgregarOperacion
    Dim frm_BuscarGuia As New frmAgregarOperacion
    Dim frm_ListaTractosPlaneamiento As New frmListaTractos_x_Planeamiento
    Dim frm_LiquidarOperacion As New frmLiquidarOperacion
    Dim obj_Entidad_Liquidacion As New LiquidacionGastos
    Dim obj_Logica_Liquidacion As New LiquidacionGastos_BLL
    Try
      With frm_OpcionAgregarOperacion
        .NPLCTR = Me.txtTracto.Text.Trim
        .CCMPN = Me.txtCompania.Tag
        .CDVSN = Me.txtDivision.Tag
        .CPLNDV = Me.txtPlanta.Tag
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim objParameter As Hashtable
        Select Case .OPCION
          Case 1
            With frm_BuscarGuia
              .txtTracto.Text = Me.txtTracto.Text.Trim
              .txtTracto.Tag = Me.txtTracto.Tag
              .CCMPN = Me.txtCompania.Tag
              .CDVSN = Me.txtDivision.Tag
              .CPLNDV = Me.txtPlanta.Tag
              If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
              For lint_Indice As Integer = 0 To .Lista.Count - 1
                objParameter = New Hashtable
                objParameter.Add("NOPRCN", .Lista.Item(lint_Indice).NOPRCN)
                objParameter.Add("TCMPCL", .Lista.Item(lint_Indice).TCMPCL)
                objParameter.Add("RUTA", .Lista.Item(lint_Indice).RUTA)
                objParameter.Add("NKMRTC_L", .Lista.Item(lint_Indice).QKMREC)
                Me.Agregar_Operacion_Liquidar(objParameter, frm_OpcionAgregarOperacion.OPCION)
              Next
            End With
          Case 2
            With frm_ListaTractosPlaneamiento
                            .NPLNMT_1 = frm_OpcionAgregarOperacion.NPLNMT
                            .CCMPN_1 = "EZ"
              If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
              objParameter = New Hashtable
              objParameter.Add("NRUCTR", .NRUCTR_1)
              objParameter.Add("NPLCTR", .NPLCTR_1)
              objParameter.Add("NOPRCN", frm_OpcionAgregarOperacion.NOPRCN)
              objParameter.Add("TCMPCL", frm_OpcionAgregarOperacion.TCMPCL)
              objParameter.Add("RUTA", .RUTA_1)
              Me.Agregar_Operacion_Liquidar(objParameter, frm_OpcionAgregarOperacion.OPCION)

            End With
        End Select
      End With
      Me.Actualizar_Galones_Utilizados_x_Operacion()
      Me.Actualizar_Total_Galones_x_Operacion()

    Catch : End Try
  End Sub

  Private Sub dtgVales_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgVales.CellContentClick, dtgVales.CellContentDoubleClick
    If e.RowIndex < 0 Then Exit Sub
    Select Case e.ColumnIndex
      Case 0
        Me.Actualizar_Galones_Asignados()
    End Select
    Me.Actualizar_Galones_Utilizados()
    Me.Actualizar_Galones_Utilizados_x_Operacion()
    Me.Actualizar_Total_Galones_x_Operacion()
  End Sub

  Private Sub txtGalonesTanque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGalonesTanque.KeyPress, txtGalonesSaldoAnterior.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then
      e.Handled = True
    Else
      If 1 <= InStr(sender.Text, ".", CompareMethod.Binary) Then
        If e.KeyChar = "." Then
          e.Handled = True
        End If
      End If
    End If
  End Sub

  Private Sub txtGalonesTanque_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGalonesTanque.TextChanged, txtGalonesSaldoAnterior.TextChanged
    Me.Actualizar_Galones_Utilizados()
    Me.Actualizar_Galones_Utilizados_x_Operacion()
    Me.Actualizar_Total_Galones_x_Operacion()
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If Me.dtgLiquidacion.RowCount = 0 Then Exit Sub
    Me.dtgLiquidacion.Rows.RemoveAt(Me.dtgLiquidacion.CurrentCellAddress.Y)
    Me.Actualizar_Galones_Utilizados_x_Operacion()
    Me.Actualizar_Total_Galones_x_Operacion()
  End Sub

  Private Sub btnGeneraLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraLiquidacion.Click
    If Me.Verificar_Seleccion_Vales = False Then
      HelpClass.MsgBox("Seleccionar Vales a Liquidar", MessageBoxIcon.Warning)
      Exit Sub
    End If
    If Me.dtgLiquidacion.RowCount = 0 Then
      HelpClass.MsgBox("Insertar Operaciones a Liquidar", MessageBoxIcon.Warning)
      Exit Sub
    End If
    If Me.Validar_Consistencia_Suma = False Then
      HelpClass.MsgBox("Suma de Combustible(Gals.) por Operación no coincide con Galones Utilizados", MessageBoxIcon.Warning)
      Exit Sub
    End If
    Me.Procesar_Liquidacion()
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub dtgLiquidación_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgLiquidacion.EditingControlShowing
    Dim txt As DataGridViewTextBoxEditingControl = e.Control
    Select Case Me.dtgLiquidacion.CurrentCell.ColumnIndex
      Case 4, 5, 6, 7
        AddHandler txt.KeyPress, AddressOf Validar_IsNumeric
        AddHandler txt.TextChanged, AddressOf Calcular_Kilometros_Reales
    End Select
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Lista_Vales_Combustible()
    Dim dwv As DataGridViewRow



    For Each obj_Entidad As Combustible In mLista
      dwv = New DataGridViewRow
      dwv.CreateCells(Me.dtgVales)
      dwv.Cells(0).Value = False
      dwv.Cells(1).Value = obj_Entidad.NSLCMB
      dwv.Cells(2).Value = obj_Entidad.NVLGRF
      dwv.Cells(3).Value = obj_Entidad.FSLCMB_D.ToShortDateString
      dwv.Cells(4).Value = obj_Entidad.FCRCMB_D.ToShortDateString
      dwv.Cells(5).Value = obj_Entidad.CTPCMB
      dwv.Cells(6).Value = obj_Entidad.QGLNCM
      dwv.Cells(7).Value = obj_Entidad.CSTGLN
      Me.dtgVales.Rows.Add(dwv)
    Next
  End Sub

  Private Sub Actualizar_Galones_Asignados()
    Dim ldobl_Suma As Double = 0
    For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
      Me.dtgVales.EndEdit()
      If Me.dtgVales.Item(0, lint_Contador).Value Then
        ldobl_Suma += Me.dtgVales.Item("QGLNCM_V", lint_Contador).Value
      End If
    Next
    Me.txtGalonesAsignados.Text = IIf(ldobl_Suma = 0, "", String.Format("{0:N2}", ldobl_Suma))
  End Sub

  Private Sub Actualizar_Galones_Utilizados()
    If Me.txtGalonesTanque.Text = "" Then
      Me.txtGalonesUtilizados.Text = Me.txtGalonesAsignados.Text.Trim
    Else
      If Me.txtGalonesAsignados.Text.Trim <> "" Then
        Me.txtGalonesUtilizados.Text = String.Format("{0:N2}", CType(IIf(Me.txtGalonesAsignados.Text.Trim = "", 0.0, Me.txtGalonesAsignados.Text.Trim), Double) + CType(IIf(Me.txtGalonesSaldoAnterior.Text.Trim = "" OrElse Me.txtGalonesSaldoAnterior.Text.Trim = ".", 0.0, Me.txtGalonesSaldoAnterior.Text.Trim), Double) - CType(IIf(Me.txtGalonesTanque.Text.Trim = "" OrElse Me.txtGalonesTanque.Text.Trim = ".", 0.0, Me.txtGalonesTanque.Text.Trim), Double))
      Else
        Me.txtGalonesUtilizados.Text = ""
      End If
    End If
  End Sub

  Private Sub Actualizar_Total_Galones_x_Operacion()
    Dim ldobl_Suma As Double = 0
    Me.dtgLiquidacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      If Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value <> Nothing Then
        ldobl_Suma += Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value
      End If
    Next
    Me.txtTotalGalones.Text = IIf(ldobl_Suma = 0, "", String.Format("{0:N2}", ldobl_Suma))
  End Sub

  Private Sub Actualizar_Galones_Utilizados_x_Operacion()
    Dim ldobl_Suma As Double = 0
    Dim ldobl_Km As Double = 0
    If Me.dtgLiquidacion.RowCount = 0 Then Exit Sub
    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      If Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value Is Nothing OrElse Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value.ToString.Trim = "" Then
        ldobl_Km = 0.0
      Else
        ldobl_Km = CType(Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value, Double)
      End If
      ldobl_Suma += ldobl_Km 'NKMRCR_L
    Next
    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      If Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value Is Nothing OrElse Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value.ToString.Trim = "" Then
        ldobl_Km = 0.0
      Else
        ldobl_Km = CType(Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value, Double)
      End If
      If ldobl_Km = 0 Then ' NKMRCR_L
        Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value = 0.0
      Else
        If ldobl_Suma < 0 Then
          Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value = String.Format("{0:N2}", 0)
        Else
          Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value = String.Format("{0:N2}", (Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value / ldobl_Suma) * CType(IIf(Me.txtGalonesUtilizados.Text.Trim = "", 0.0, Me.txtGalonesUtilizados.Text.Trim), Double)) 'NKMRCR_L
        End If
      End If
    Next
  End Sub

  Private Function Validar_Consistencia_Galones_Utilizados() As Boolean
    Dim ldobl_Suma As Double = 0
    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      ldobl_Suma += Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value ' NKMRCR_L
    Next
    If String.Format("{0:N2}", Me.txtGalonesUtilizados.Text.Trim) = String.Format("{0:N2}", ldobl_Suma) Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub Validar_IsNumeric(ByVal sender As Object, ByVal e As KeyPressEventArgs)
    Dim columna As Integer = Me.dtgLiquidacion.CurrentCell.ColumnIndex
    Select Case columna
      Case 4, 5, 6, 7
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = ".") Then
          e.Handled = True
        Else
          If 1 <= InStr(sender.EditingControlFormattedValue, ".", CompareMethod.Binary) Then
            If e.KeyChar = "." Then
              e.Handled = True
            End If
          End If
        End If
    End Select
    'Me.dtgLiquidación.CommitEdit(DataGridViewDataErrorContexts.Commit)
  End Sub

  Private Function Validar_Existencia_Operación(ByVal ldob_NOPRCN As Double) As Boolean
    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      If Me.dtgLiquidacion.Item("NOPRCN_L", lint_Contador).Value = ldob_NOPRCN Then
        Return True
      End If
    Next
    Dim objLogica As New LiquidacionCombustible_BLL

    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      If Me.dtgLiquidacion.Item("NOPRCN_L", lint_Contador).Value = ldob_NOPRCN Then
        Return True
      End If
    Next
    Return False
  End Function

  Private Sub Agregar_Operacion_Liquidar(ByVal objParameter As Hashtable, ByVal lOpcion As Integer)
    Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
    Dim obj_Logica_Guia As New GuiaTransportista_BLL
    If lOpcion = 2 Then
      If Me.txtTracto.Tag.ToString.Trim = objParameter("NRUCTR") And Me.txtTracto.Text.Trim = objParameter("NPLCTR") Then
      Else
        HelpClass.MsgBox("No es el mismo Tracto a Liquidar", MessageBoxIcon.Information)
        Exit Sub
      End If
      obj_Entidad_Guia_Transporte.NOPRCN = objParameter("NOPRCN")
      obj_Entidad_Guia_Transporte.NPLCTR = objParameter("NPLCTR")
      obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
    End If

    If Me.Validar_Existencia_Operación(objParameter("NOPRCN")) = True Then
      HelpClass.MsgBox("Ya se Asignó esta Operación", MessageBoxIcon.Information)
      Exit Sub
    Else
      Dim objLogica As New LiquidacionCombustible_BLL
      Dim objParam As New Hashtable
      objParam.Add("NOPRCN", objParameter("NOPRCN"))
      If objLogica.Validar_Existencia_Operacion_Liquidacion(objParam) = -1 Then
        If MsgBox("La Operación ya está Liquidado, desea agregarlo ", MsgBoxStyle.YesNo, "Liquidación") = MsgBoxResult.No Then Exit Sub
      End If
    End If

    Dim dwv As New DataGridViewRow()
    dwv.CreateCells(Me.dtgLiquidacion)
    dwv.Cells(0).Value = objParameter("NOPRCN")
    dwv.Cells(1).Value = objParameter("TCMPCL") 'obj_Entidad_Guia_Transporte.CCLNT
    dwv.Cells(2).Value = objParameter("RUTA")
    If lOpcion = 1 Then
      dwv.Cells(3).Value = objParameter("NKMRTC_L")
    Else
      dwv.Cells(3).Value = obj_Entidad_Guia_Transporte.QKMREC
    End If
    dwv.Cells(4).Value = 0
    dwv.Cells(5).Value = 0
    dwv.Cells(6).Value = 0
    dwv.Cells(7).Value = 0
    Me.dtgLiquidacion.Rows.Add(dwv)

  End Sub

  Private Sub Calcular_Kilometros_Reales(ByVal sender As Object, ByVal e As EventArgs)
    Dim txt As DataGridViewTextBoxEditingControl = sender
    Dim ColumnIndex As Integer = Me.dtgLiquidacion.CurrentCell.ColumnIndex
    Select Case ColumnIndex
      Case 4
        If txt.Text <> "" Then
          Dim ldob_TacIni As Double = Double.Parse(txt.Text)
          Dim ldob_TacFin As Double = IIf(Me.dtgLiquidacion.CurrentRow.Cells(5).Value.ToString = "", 0.0, Me.dtgLiquidacion.CurrentRow.Cells(5).Value)
          Me.dtgLiquidacion.CurrentRow.Cells(6).Value = ldob_TacFin - ldob_TacIni
        Else
          Me.dtgLiquidacion.CurrentRow.Cells(6).Value = 0.0
        End If
        Me.Actualizar_Galones_Utilizados_x_Operacion()
        Me.Actualizar_Total_Galones_x_Operacion()

      Case 5
        If txt.Text <> "" Then
          Dim ldob_TacFin As Double = Double.Parse(txt.Text)
          Dim ldob_TacIni As Double = IIf(dtgLiquidacion.CurrentRow.Cells(4).Value.ToString = "", 0.0, dtgLiquidacion.CurrentRow.Cells(4).Value)
          Me.dtgLiquidacion.CurrentRow.Cells(6).Value = ldob_TacFin - ldob_TacIni
        Else
          Me.dtgLiquidacion.CurrentRow.Cells(6).Value = 0.0
        End If
        Me.Actualizar_Galones_Utilizados_x_Operacion()
        Me.Actualizar_Total_Galones_x_Operacion()

      Case 6
        If txt.Text = "" OrElse CType(txt.Text, Double) = 0 Then
          Me.dtgLiquidacion.CurrentRow.Cells(7).Value = 0.0
          Me.txtTotalGalones.Text = ""
        Else
          Me.dtgLiquidacion.CurrentRow.Cells(6).Value = txt.Text
          Me.Actualizar_Galones_Utilizados_x_Operacion()
          Me.Actualizar_Total_Galones_x_Operacion()
        End If

      Case 7
        Dim ldobl_Suma As Double = 0
        If txt.Text <> "" Then
          For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
            If Me.dtgLiquidacion.CurrentCell.RowIndex = lint_Contador Then
              ldobl_Suma += txt.Text
            Else
              If Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value <> Nothing Then
                ldobl_Suma += Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value
              End If
            End If
          Next
        End If
        Me.txtTotalGalones.Text = IIf(ldobl_Suma = 0, "", String.Format("{0:N2}", ldobl_Suma))
    End Select
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.dtgVales.AutoGenerateColumns = False
    Me.dtgLiquidacion.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.dtgVales.ColumnCount - 1
      Me.dtgVales.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.dtgLiquidacion.ColumnCount - 1
      Me.dtgLiquidacion.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Procesar_Liquidacion()
    Dim obj_LiquidacionCombustible_Logica As New LiquidacionCombustible_BLL
    Dim obj_Combustible_Logica As New Combustible_BLL
    Dim obj_Combustible As Combustible
    Dim obj_LiquidCombustible As New LiquidacionCombustible
    Dim list_Combustible As New List(Of Combustible)
    Dim list_LiquidCombustible As New List(Of LiquidacionCombustible)
    Dim lNLQCMB As Int64 = 0

    obj_LiquidCombustible.NPLCUN = Me.txtTracto.Text.ToString.Trim
    obj_LiquidCombustible.NRUCTR = Me.txtTracto.Tag.ToString.Trim
    obj_LiquidCombustible.CCMPN = Me.txtCompania.Tag.ToString.Trim
    obj_LiquidCombustible.CDVSN = Me.txtDivision.Tag.ToString.Trim
    obj_LiquidCombustible.CPLNDV = Me.txtPlanta.Tag.ToString.Trim
    obj_LiquidCombustible.FLQDCN = HelpClass.TodayNumeric
    obj_LiquidCombustible.CTPCMB = Me.dtgVales.Item("CTPCMB_V", 0).Value
    obj_LiquidCombustible.QGLNSA = IIf(Me.txtGalonesTanque.Text.Trim = "", 0, Me.txtGalonesTanque.Text.Trim)
    obj_LiquidCombustible.QTGLIN = IIf(Me.txtGalonesAsignados.Text.Trim = "", 0, Me.txtGalonesAsignados.Text.Trim)
    obj_LiquidCombustible.QGLNUT = IIf(Me.txtGalonesUtilizados.Text.Trim = "", 0, Me.txtGalonesUtilizados.Text.Trim)
    obj_LiquidCombustible.USRCRT = MainModule.USUARIO
    obj_LiquidCombustible.FCHCRT = HelpClass.TodayNumeric
    obj_LiquidCombustible.HRACRT = HelpClass.NowNumeric
        obj_LiquidCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    lNLQCMB = obj_LiquidacionCombustible_Logica.Registrar_Liquidacion_Combustible(obj_LiquidCombustible).NLQCMB

    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      Me.dtgLiquidacion.EndEdit()
      obj_LiquidCombustible = New LiquidacionCombustible
      obj_LiquidCombustible.NLQCMB = lNLQCMB
      obj_LiquidCombustible.NOPRCN = Me.dtgLiquidacion.Item("NOPRCN_L", lint_Contador).Value
      obj_LiquidCombustible.NKMRCR = IIf(Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value.ToString.Trim = "", 0, Me.dtgLiquidacion.Item("NKMRTC_L", lint_Contador).Value) ' NKMRCR_L
      obj_LiquidCombustible.QGLNCM = IIf(Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value.ToString.Trim = "", 0, Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value)
      obj_LiquidCombustible.CTPCMB = Me.dtgVales.Item("CTPCMB_V", 0).Value
      obj_LiquidCombustible.QTCSDA = IIf(Me.dtgLiquidacion.Item("QTCSDA_L", 0).Value.ToString.Trim = "", 0, Me.dtgLiquidacion.Item("QTCSDA_L", 0).Value)
      obj_LiquidCombustible.QTCLLG = IIf(Me.dtgLiquidacion.Item("QTCLLG_L", 0).Value.ToString.Trim = "", 0, Me.dtgLiquidacion.Item("QTCLLG_L", 0).Value)
      obj_LiquidCombustible.FULTAC = HelpClass.TodayNumeric
      obj_LiquidCombustible.HULTAC = HelpClass.NowNumeric
      obj_LiquidCombustible.CULUSA = MainModule.USUARIO
            obj_LiquidCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      list_LiquidCombustible.Add(obj_LiquidCombustible)
    Next
    obj_LiquidacionCombustible_Logica.Registrar_Detalle_Liquidacion_Combustible(list_LiquidCombustible)

    For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
      Me.dtgVales.EndEdit()
      If Me.dtgVales.Item(0, lint_Contador).Value = True Then
        obj_Combustible = New Combustible
        obj_Combustible.NSLCMB = Me.dtgVales.Item("NSLCMB_V", lint_Contador).Value
        obj_Combustible.NLQCMB = lNLQCMB
        obj_Combustible.FCHLQD = HelpClass.TodayNumeric
        obj_Combustible.HRALQD = HelpClass.NowNumeric
        obj_Combustible.USRLQD = MainModule.USUARIO
        obj_Combustible.FULTAC = HelpClass.TodayNumeric
        obj_Combustible.HULTAC = HelpClass.NowNumeric
        obj_Combustible.CULUSA = MainModule.USUARIO
                obj_Combustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        list_Combustible.Add(obj_Combustible)
      End If
    Next
    obj_Combustible_Logica.Actualizar_Asignacion_Combustible_Tracto(list_Combustible)

  End Sub

  Private Function Verificar_Seleccion_Vales() As Boolean
    For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
      If Me.dtgVales.Item(0, lint_Contador).Value = True Then
        Return True
      End If
    Next
    Return False
  End Function

  Private Function Validar_Consistencia_Suma() As Boolean
    Dim ldob_Suma As Double = 0
    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
      Me.dtgLiquidacion.EndEdit()
      ldob_Suma += CType(Me.dtgLiquidacion.Item("QGLNCM_L", lint_Contador).Value, Double)
    Next
    If String.Format("{0:N2}", ldob_Suma) = Me.txtGalonesUtilizados.Text Then
      Return True
    Else
      Return False
    End If
  End Function

#End Region

  Private Sub btnAgregarVale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarVale.Click
    Dim frmValeEnRuta As New frmListaValeRuta
    Dim objEntidad As New LiquidacionCombustible
    With frmValeEnRuta
      .NPLCUN = Me.txtTracto.Text
      .CCMPN = Me.txtCompania.Tag
      If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
      Me.Guardar_Vale_Combustible(.objEntidad)
    End With
  End Sub

  Private Sub Lista_Asignacion_Combustible_x_Tracto()
    Dim obj_LogicaCombustible As New Combustible_BLL
    Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
    Dim objParametro As New Hashtable
    Dim dwv As DataGridViewRow
    Try
      objParametro.Add("PSNPLCUN", Me.txtTracto.Text)
      objParametro.Add("PSCCMPN", Me.txtCompania.Tag)
      objParametro.Add("PSCDVSN", Me.txtDivision.Tag)
      objParametro.Add("PNCPLNDV", CType(Me.txtPlanta.Tag, Double))
      objParametro.Add("PSSESSLC", "P")
        Me.dtgVales.Rows.Clear()
      For Each obj_Combustible As Combustible In obj_LogicaCombustible.Listar_Asignacion_Combustible_x_Tractos(objParametro)
        dwv = New DataGridViewRow
        dwv.CreateCells(Me.dtgVales)
        dwv.Cells(0).Value = False
        dwv.Cells(1).Value = obj_Combustible.NSLCMB
        dwv.Cells(2).Value = obj_Combustible.NVLGRF
        dwv.Cells(3).Value = obj_Combustible.FSLCMB_D.ToShortDateString
        dwv.Cells(4).Value = obj_Combustible.FCRCMB_D.ToShortDateString
        dwv.Cells(5).Value = obj_Combustible.CTPCMB
        dwv.Cells(6).Value = obj_Combustible.QGLNCM
        dwv.Cells(7).Value = obj_Combustible.CSTGLN
        Me.dtgVales.Rows.Add(dwv)
      Next
    Catch : End Try

  End Sub

  Private Sub Guardar_Vale_Combustible(ByVal objEntidad As LiquidacionCombustible)
    Dim obj_Entidad As New Combustible
    Dim obj_Logica As New Combustible_BLL
    obj_Entidad.NSLCMB = 0
    obj_Entidad.FSLCMB = HelpClass.CFecha_a_Numero8Digitos(objEntidad.FCRCMB_S)
    obj_Entidad.CCMPN = Me.txtCompania.Tag
    obj_Entidad.CDVSN = Me.txtDivision.Tag
    obj_Entidad.CPLNDV = Me.txtPlanta.Tag
    obj_Entidad.NRUCTR = objEntidad.NRUCTR
    obj_Entidad.NPLCUN = Me.txtTracto.Text.Trim
    obj_Entidad.CBRCNT = objEntidad.CBRCNT
    obj_Entidad.CGRFO = objEntidad.CGRFO
    obj_Entidad.CTPCMB = objEntidad.CTPCMB
    obj_Entidad.FCRCMB = HelpClass.CFecha_a_Numero8Digitos(objEntidad.FCRCMB_S)
    obj_Entidad.NVLGRF = objEntidad.NVLGRF
    obj_Entidad.QGLNCM = objEntidad.QGLNCM
    obj_Entidad.CSTGLN = Format(objEntidad.CSTGLN, "####,####.##00")
    obj_Entidad.NPRCN1 = ""
    obj_Entidad.NPRCN2 = ""
    obj_Entidad.NPRCN3 = ""
    obj_Entidad.CUSCRT = MainModule.USUARIO
    obj_Entidad.FCHCRT = HelpClass.TodayNumeric
    obj_Entidad.HRACRT = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    obj_Entidad.NSLCMB = obj_Logica.Registrar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB
    If obj_Entidad.NSLCMB = 0 Then
      HelpClass.ErrorMsgBox()
    ElseIf obj_Entidad.NSLCMB = -1 Then
      HelpClass.MsgBox("N° Vale Grifo " & objEntidad.NVLGRF & " , está registrado", MessageBoxIcon.Information)
    Else
      Me.Lista_Asignacion_Combustible_x_Tracto()
    End If
  End Sub

End Class

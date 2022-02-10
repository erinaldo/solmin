Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmAsignarCombustible

#Region "Atributo"
  Private _estado As New Integer
  Private _obj_Entidad_Combustible As New Combustible
  Private _cnt_Galones As New Double
  Private _list_Tarifa As New List(Of Grifo)
  Private _list_Vale_Combustible As New List(Of ValeCombustible)
  Private _match As New Predicate(Of Grifo)(AddressOf Busca_Tarifa)
  Private _match_1 As New Predicate(Of ValeCombustible)(AddressOf Busca_Vale_Combustible)
#End Region

#Region "Propiedades"
  Public Property obj_Entidad_Combustible()
    Get
      Return _obj_Entidad_Combustible
    End Get
    Set(ByVal value)
      _obj_Entidad_Combustible = value
    End Set
  End Property

  Public Property cnt_Galones() As Double
    Get
      Return _cnt_Galones
    End Get
    Set(ByVal value As Double)
      _cnt_Galones = value
    End Set
  End Property
#End Region

#Region "Eventos"

  Private Sub frmAsignarCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    Me.Listar_Combos()
    If Me.Tag = 0 Then
      Select Case _list_Vale_Combustible.Count
        Case 1
          Me.Asignar_Datos_Vale(0)
      End Select
    ElseIf Me.Tag = 1 Then
      Me.Asignar_Datos_Vale(1)
      Me.txtValeCombustible.Enabled = False
      Me.chkValidarVale.Checked = False
      Me.chkValidarVale.Enabled = False
      Me.btnBuscarVale.Enabled = False
    End If
  End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    Dim obj_Entidad As New Combustible
    Dim obj_Logica As New Combustible_BLL
    If Me.Validar_Inputs = True Then Exit Sub
    If Me.chkValidarVale.Checked = True Then
      If _estado = 0 Then
        If _list_Vale_Combustible.Find(_match_1) Is Nothing Then
          HelpClass.MsgBox("Vale de Combustible no Válido", MessageBoxIcon.Information)
          Exit Sub
        End If
      End If
    End If
    obj_Entidad.FSLCMB = HelpClass.TodayNumeric
    obj_Entidad.CCMPN = _obj_Entidad_Combustible.CCMPN
    obj_Entidad.CDVSN = _obj_Entidad_Combustible.CDVSN
    obj_Entidad.CPLNDV = _obj_Entidad_Combustible.CPLNDV
    obj_Entidad.NRUCTR = _obj_Entidad_Combustible.NRUCTR
    obj_Entidad.NPLCUN = _obj_Entidad_Combustible.NPLCUN
    obj_Entidad.CBRCNT = _obj_Entidad_Combustible.CBRCNT
    obj_Entidad.CGRFO = CType(Me.cboGrifo.Codigo, Double)
    obj_Entidad.CTPCMB = Me.cboTipocombustible.Codigo
    obj_Entidad.FCRCMB = CType(HelpClass.CtypeDate(Me.dtpFechaCargaComb.Value), Double)
    obj_Entidad.NVLGRF = CType(Me.txtValeCombustible.Text, Double)
    obj_Entidad.QGLNCM = CType(Me.txtCombAsignado.Text, Double)
    obj_Entidad.NPRCN1 = Me.txtPrecinto_1.Text.Trim
    obj_Entidad.NPRCN2 = Me.txtPrecinto_2.Text.Trim
    obj_Entidad.NPRCN3 = Me.txtPrecinto_3.Text.Trim
    _cnt_Galones = obj_Entidad.QGLNCM
    If Me.txtCostocombustible.TextLength <> 0 Then obj_Entidad.CSTGLN = CType(Me.txtCostocombustible.Text, Double)

    obj_Entidad.NDCCT1 = IIf(Me.txtNroDocumento.Text.Trim.Equals(""), 0, Me.txtNroDocumento.Text.Trim)
    obj_Entidad.CTPOD1 = IIf(Me.cboTipoDocumento.Codigo.Trim.Equals(""), 0, Me.cboTipoDocumento.Codigo)
    obj_Entidad.FDCCT1 = IIf(Me.txtNroDocumento.Text.Trim.Equals(""), 0, HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaDocumento.Value))

    obj_Entidad.CUSCRT = MainModule.USUARIO
    obj_Entidad.FCHCRT = HelpClass.TodayNumeric
    obj_Entidad.HRACRT = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    obj_Entidad.NSLCMB = obj_Logica.Registrar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB
    If obj_Entidad.NSLCMB = 0 Then
      HelpClass.ErrorMsgBox()
    ElseIf obj_Entidad.NSLCMB = -1 Then
      HelpClass.MsgBox("Vale Combustible Registrado ", MessageBoxIcon.Information)
    Else
      Me.DialogResult = Windows.Forms.DialogResult.OK
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtNroDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtPapeleta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValeCombustible.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtCombAsignado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCombAsignado.KeyPress, txtCostocombustible.KeyPress
    If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = ".") Then
      e.Handled = True
    Else
      If 1 <= InStr(sender.Text, ".", CompareMethod.Binary) Then
        If e.KeyChar = "." Then
          e.Handled = True
        End If
      End If
    End If
  End Sub

  Private Sub cboGrifo_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrifo.Texto_KeyEnter, cboTipocombustible.Texto_KeyEnter
    If Me.cboGrifo.NoHayCodigo = True OrElse Me.cboTipocombustible.NoHayCodigo = True Then
      Me.txtCostocombustible.Text = "0.00"
    Else
      Dim objEntidad As Grifo = _list_Tarifa.Find(_match)
      If objEntidad Is Nothing Then
        Me.txtCostocombustible.Text = String.Format("{0:N2}", 0)
      Else
        Me.txtCostocombustible.Text = String.Format("{0:N3}", objEntidad.IPRCMS)
      End If
    End If
  End Sub

  Private Sub txtPapeleta_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValeCombustible.KeyUp
    Select Case e.KeyCode
      Case Keys.Enter, Keys.Tab
        If Me.chkValidarVale.Checked Then
          Me.Validar_Vale_Combustible()
        End If
      Case Keys.Back, Keys.Delete
        If Me.chkValidarVale.Checked Then
          Me.txtCombAsignado.Text = 0.0
          Me.cboTipocombustible.Limpiar()
          _estado = 0
        End If
    End Select
  End Sub

  Private Sub chkValidarVale_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkValidarVale.CheckStateChanged
    If Me.chkValidarVale.Checked Then
      Me.cboTipocombustible.Enabled = False
      Me.btnBuscarVale.Enabled = True
      If Me.Tag = 0 Then
        If _list_Vale_Combustible.Count = 1 Then
          Me.Asignar_Datos_Vale(0)
        Else
          Me.Asignar_Datos_Vale(2)
        End If
      Else
        Me.Asignar_Datos_Vale(1)
      End If
    Else
      Me.cboTipocombustible.Enabled = True
      Me.btnBuscarVale.Enabled = False
      If Me.Tag = 0 Then
        Me.Asignar_Datos_Vale(2)
      End If
    End If
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Dim obj_Entidad As New Combustible
    Dim obj_Logica As New Combustible_BLL
    If Me.Validar_Inputs = True Then Exit Sub
    obj_Entidad.NSLCMB = _obj_Entidad_Combustible.NSLCMB
    'obj_Entidad.FSLCMB = HelpClass.TodayNumeric
    obj_Entidad.CCMPN = _obj_Entidad_Combustible.CCMPN
    obj_Entidad.CDVSN = _obj_Entidad_Combustible.CDVSN
    obj_Entidad.CPLNDV = _obj_Entidad_Combustible.CPLNDV
    obj_Entidad.CGRFO = CType(Me.cboGrifo.Codigo, Double)
    obj_Entidad.CTPCMB = Me.cboTipocombustible.Codigo
    obj_Entidad.FCRCMB = CType(HelpClass.CtypeDate(Me.dtpFechaCargaComb.Value), Double)
    obj_Entidad.NVLGRF = CType(Me.txtValeCombustible.Text, Double)
    obj_Entidad.QGLNCM = CType(Me.txtCombAsignado.Text, Double)
    obj_Entidad.NPRCN1 = Me.txtPrecinto_1.Text.Trim
    obj_Entidad.NPRCN2 = Me.txtPrecinto_2.Text.Trim
    obj_Entidad.NPRCN3 = Me.txtPrecinto_3.Text.Trim
    obj_Entidad.CTPOD1 = IIf(Me.cboTipoDocumento.Codigo.Trim.Equals(""), 0, Me.cboTipoDocumento.Codigo)
    obj_Entidad.NDCCT1 = IIf(Me.txtNroDocumento.Text.Trim.Equals(""), 0, Me.txtNroDocumento.Text)
    obj_Entidad.FDCCT1 = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaDocumento.Value)
    _cnt_Galones = obj_Entidad.QGLNCM
    If Me.txtCostocombustible.TextLength <> 0 Then obj_Entidad.CSTGLN = CType(Me.txtCostocombustible.Text, Double)
    obj_Entidad.CULUSA = MainModule.USUARIO
    obj_Entidad.FULTAC = HelpClass.TodayNumeric
    obj_Entidad.HULTAC = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    obj_Entidad.NSLCMB = obj_Logica.Modificar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB
    If obj_Entidad.NSLCMB = 0 Then
      HelpClass.ErrorMsgBox()
    Else
      Me.DialogResult = Windows.Forms.DialogResult.OK
    End If
  End Sub

  Private Sub btnBuscarVale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarVale.Click
    Dim frmConsultaVale As New frmConsultaValeCombustible
    With frmConsultaVale
      .objLista = Me._list_Vale_Combustible
      If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
      Me.txtValeCombustible.Text = .objEntidad.NRSCVL
      Me.cboTipocombustible.Codigo = .objEntidad.CTPCMB
      Me.txtCombAsignado.Text = .objEntidad.QGLNSL
    End With
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Listar_Combos()
    Dim obj_Entidad_ValeCombustible As New ValeCombustible
    Dim obj_Entidad_TipoDocumento As New TipoDocumento
    Dim obj_Logica_Grifo As New Grifo_BLL
    Dim obj_Logica_TipoCombustible As New TipoCombustible_BLL
    Dim obj_Logica_ValeCombustible As New ValeCombustible_BLL
    Dim obj_Logica_TipoDocumento As New TipoDocumento_BLL
    Dim objParametro As New Hashtable
    objParametro.Add("PSCGRFO", "")

    With Me.cboGrifo
      .DataSource = HelpClass.GetDataSetNative(obj_Logica_Grifo.Listar_Grifos)
      .KeyField = "CGRFO"
      .ValueField = "TGRFO"
      .DataBind()
    End With

    With Me.cboTipocombustible
      .DataSource = HelpClass.GetDataSetNative(obj_Logica_TipoCombustible.Listar_TipoCombustible)
      .KeyField = "CTPCMB"
      .ValueField = "TDSCMB"
      .DataBind()
    End With
    obj_Entidad_TipoDocumento.CCMPN = _obj_Entidad_Combustible.CCMPN
    obj_Entidad_TipoDocumento.CTPODC = 0
    With Me.cboTipoDocumento
      .DataSource = HelpClass.GetDataSetNative(obj_Logica_TipoDocumento.Listar_Tipo_Documento(obj_Entidad_TipoDocumento))
      .KeyField = "CTPODC"
      .ValueField = "TCMTPD"
      .DataBind()
    End With

    obj_Entidad_ValeCombustible.CCMPN = _obj_Entidad_Combustible.CCMPN
    obj_Entidad_ValeCombustible.CDVSN = _obj_Entidad_Combustible.CDVSN
    obj_Entidad_ValeCombustible.CPLNDV = _obj_Entidad_Combustible.CPLNDV
    obj_Entidad_ValeCombustible.CTRSPT = _obj_Entidad_Combustible.CTRSPT
    obj_Entidad_ValeCombustible.NPLVEH = _obj_Entidad_Combustible.NPLCUN
    obj_Entidad_ValeCombustible.SSVLCM = "P"
    _list_Tarifa = obj_Logica_Grifo.Listar_Tarifa_Actual(objParametro)
    _list_Vale_Combustible = obj_Logica_ValeCombustible.Listar_Vale_Combustible_1(obj_Entidad_ValeCombustible)

  End Sub

  Private Function Validar_Inputs() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False

    If Me.txtValeCombustible.TextLength = 0 Then
      lstr_validacion += "* NRO PAPELETA " & Chr(13)
    End If

    If Me.cboGrifo.NoHayCodigo = True Then
      lstr_validacion += "* GRIFO " & Chr(13)
    End If

    If Me.cboTipocombustible.NoHayCodigo = True Then
      lstr_validacion += "* TIPO COMBUSTIBLE " & Chr(13)
    End If

    If Me.txtCombAsignado.TextLength = 0 OrElse Me.txtCombAsignado.Text.Trim.Equals(".") OrElse CType(Me.txtCombAsignado.Text, Double) = 0 Then
      lstr_validacion += "* CANTIDAD COMBUSTIBLE " & Chr(13)
    End If

    If Me.txtCostocombustible.TextLength = 0 OrElse Me.txtCostocombustible.Text.Trim.Equals(".") OrElse CType(Me.txtCostocombustible.Text, Double) = 0 Then
      lstr_validacion += "* COSTO COMBUSTIBLE " & Chr(13)
    End If

    If Me.txtPrecinto_1.Text.Trim.Length = 0 Then
      lstr_validacion += "* PRECINTO " & Chr(13)
    End If

    'If Not Me.cboTipoDocumento.Codigo.Trim.Equals("0") Then
    '  If Me.txtNroDocumento.Text.Trim = 0 Then
    '    lstr_validacion += "* N° DOCUMENTO " & Chr(13)
    '  ElseIf Not IsNumeric(Me.txtNroDocumento.Text) Then
    '    lstr_validacion += "* CORREGIR N° DOCUMENTO " & Chr(13)
    '  End If
    'End If

    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If

    Return lbool_existe_error
  End Function

  Private Function Busca_Tarifa(ByVal objEntidad As Grifo) As Boolean
    Return (objEntidad.CGRFO.ToString = Me.cboGrifo.Codigo.Trim And objEntidad.CTPCMB = Me.cboTipocombustible.Codigo.Trim)
  End Function

  Private Function Busca_Vale_Combustible(ByVal objEntidad As ValeCombustible) As Boolean
    Return (objEntidad.NRSCVL.ToString = Me.txtValeCombustible.Text.Trim And objEntidad.NPLVEH = Me._obj_Entidad_Combustible.NPLCUN)
  End Function

  Private Sub Validar_Vale_Combustible()
    If _estado <> 0 Then Exit Sub
    Dim objEntidad As ValeCombustible = _list_Vale_Combustible.Find(_match_1)
    If objEntidad Is Nothing Then
      Me.txtCombAsignado.Text = 0.0
      Me.cboTipocombustible.Codigo = ""
      Me.cboTipocombustible.Limpiar()
      _estado = 0
    Else
      Me.txtCombAsignado.Text = objEntidad.QGLNSL
      Me.cboTipocombustible.Codigo = objEntidad.CTPCMB
      _estado = 1
    End If
  End Sub

  Private Sub Asignar_Datos_Vale(ByVal Estado As Integer)
    Select Case Estado
      Case 0
        Me.txtValeCombustible.Text = _list_Vale_Combustible(0).NRSCVL
        Me.txtCombAsignado.Text = _list_Vale_Combustible(0).QGLNSL
        Me.cboTipocombustible.Codigo = _list_Vale_Combustible(0).CTPCMB
      Case 1
        Me.txtValeCombustible.Text = Me._obj_Entidad_Combustible.NVLGRF
        Me.dtpFechaCargaComb.Value = Me._obj_Entidad_Combustible.FCRCMB_S.Trim
        Me.cboGrifo.Codigo = Me._obj_Entidad_Combustible.CGRFO
        Me.cboTipocombustible.Codigo = Me._obj_Entidad_Combustible.CTPCMB
        Me.txtCombAsignado.Text = Me._obj_Entidad_Combustible.QGLNCM
        Me.txtCostocombustible.Text = Me._obj_Entidad_Combustible.CSTGLN
        Me.txtPrecinto_1.Text = Me._obj_Entidad_Combustible.NPRCN1
        Me.txtPrecinto_2.Text = Me._obj_Entidad_Combustible.NPRCN2
        Me.txtPrecinto_3.Text = Me._obj_Entidad_Combustible.NPRCN3
        Me.cboTipoDocumento.Codigo = Me._obj_Entidad_Combustible.CTPOD1
        Me.txtNroDocumento.Text = IIf(Me._obj_Entidad_Combustible.NDCCT1 = 0, "", Me._obj_Entidad_Combustible.NDCCT1)
        Me.dtpFechaDocumento.Value = Me._obj_Entidad_Combustible.FDCCT1_S
      Case 2
        Me.txtValeCombustible.Text = ""
        Me.cboTipocombustible.Codigo = "D2"
        Me.cboGrifo.Limpiar()
        Me.txtCombAsignado.Text = 0.0
    End Select

  End Sub

#End Region

End Class

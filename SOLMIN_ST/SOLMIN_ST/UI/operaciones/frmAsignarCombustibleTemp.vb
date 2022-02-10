Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmAsignarCombustibleTemp
#Region "Atributo"
    Private mLista As New List(Of Combustible)
    Private _estado As New Integer
    Private _obj_Entidad_Combustible As New Combustible
    Private _cnt_Galones As New Double
    Private _list_Tarifa As New List(Of Grifo)
    Private _list_Vale_Combustible As New List(Of ValeCombustible)
    Private _match As New Predicate(Of Grifo)(AddressOf Busca_Tarifa)
    Private _match_1 As New Predicate(Of ValeCombustible)(AddressOf Busca_Vale_Combustible)

    Private mFSLCMB As Double = 0
    Private mCCMPN As String = ""
    Private mCDVSN As String = ""
    Private mCPLNDV As Double = 0
    Private mNRUCTR As String = ""
    Private mNPLCUN As String = ""
    Private mCBRCNT As String = ""
    Private mCGRFO As Double = 0
    Private mCTPCMB As String = ""
    Private mFCRCMB As Double = 0
    Private mNVLGRF As Double = 0
    Private mQGLNCM As Double = 0
    Private mNPRCN1 As String = ""
    Private mNPRCN2 As String = ""
    Private mNPRCN3 As String = ""
    Private mCSTGLN As Double = 0
    Private mNDCCT1 As Double = 0
    Private mCTPOD1 As Double = 0
    Private mFDCCT1 As Double = 0
    Private mNSLCMB As Double = 0

#End Region
#Region "Propiedades"
    Public WriteOnly Property Lista() As List(Of Combustible)
        Set(ByVal value As List(Of Combustible))
            mLista = value
        End Set
    End Property

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

    Public ReadOnly Property FSLCMB_1()
        Get
            Return mFSLCMB
        End Get
    End Property

    Public ReadOnly Property CCMPN_1()
        Get
            Return mCCMPN
        End Get
    End Property

    Public ReadOnly Property CDVSN_1()
        Get
            Return mCDVSN
        End Get
    End Property

    Public ReadOnly Property CPLNDV_1()
        Get
            Return mCPLNDV
        End Get
    End Property
    Public ReadOnly Property NRUCTR_1()
        Get
            Return mNRUCTR
        End Get
    End Property

    Public ReadOnly Property NPLCUN_1()
        Get
            Return mNPLCUN
        End Get
    End Property

    Public ReadOnly Property CBRCNT_1()
        Get
            Return mCBRCNT
        End Get
    End Property
    Public ReadOnly Property CGRFO_1()
        Get
            Return mCGRFO
        End Get
    End Property
    Public ReadOnly Property CTPCMB_1()
        Get
            Return mCTPCMB
        End Get
    End Property

    Public ReadOnly Property FCRCMB_1()
        Get
            Return mFCRCMB
        End Get
    End Property
    Public ReadOnly Property NVLGRF_1()
        Get
            Return mNVLGRF
        End Get
    End Property

    Public ReadOnly Property QGLNCM_1()
        Get
            Return mQGLNCM
        End Get
    End Property

    Public ReadOnly Property NPRCN1_1()
        Get
            Return mNPRCN1
        End Get
    End Property

    Public ReadOnly Property NPRCN2_1()
        Get
            Return mNPRCN2
        End Get
    End Property

    Public ReadOnly Property NPRCN3_1()
        Get
            Return mNPRCN3
        End Get
    End Property

    Public ReadOnly Property CSTGLN_1()
        Get
            Return mCSTGLN
        End Get
    End Property

    Public ReadOnly Property NDCCT1_1()
        Get
            Return mNDCCT1
        End Get
    End Property

    Public ReadOnly Property CTPOD1_1()
        Get
            Return mCTPOD1
        End Get
    End Property

    Public ReadOnly Property FDCCT1_1()
        Get
            Return mFDCCT1
        End Get
    End Property

    Public ReadOnly Property NSLCMB_1()
        Get
            Return mNSLCMB
        End Get
    End Property

#End Region

#Region "Eventos"

    Private Sub frmAsignarCombustibleTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.Limpiar_Controles()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim objEntidad As New OperacionTransporte
        Dim obj_OperacionTransporte As New OperacionTransporte_BLL
        Dim objParametro As New Hashtable
        Dim objList As New List(Of OperacionTransporte)
        If Me.Validar_Inputs = True Then Exit Sub
        If Me.chkValidarVale.Checked = True Then
            If _estado = 0 Then
                If _list_Vale_Combustible.Find(_match_1) Is Nothing Then
                    HelpClass.MsgBox("Vale de Combustible no Válido", MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End If

        Try
            objParametro.Add("NVLGRF", CType(Me.txtValeCombustible.Text, Double))
            objParametro.Add("CCMPN", _obj_Entidad_Combustible.CCMPN)
            objParametro.Add("CDVSN", _obj_Entidad_Combustible.CDVSN)
            objParametro.Add("CPLNDV", _obj_Entidad_Combustible.CPLNDV)
            objList = obj_OperacionTransporte.Validar_Existe_Vale_Combustible(objParametro)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If objList.Count > 0 Then
            HelpClass.MsgBox("Vale ya fue registrado", MessageBoxIcon.Information)
            Exit Sub
        Else
            If mLista.Count > 0 Then
                For Each obj_Entidad As Combustible In mLista
                    Dim enc As Boolean = False
                    If obj_Entidad.NVLGRF = CType(Me.txtValeCombustible.Text, Double) Then
                        enc = True
                        If enc = True Then
                            HelpClass.MsgBox("Vale ya fue agregado", MessageBoxIcon.Information)
                            Exit Sub
                        Else
                            Continue For
                        End If
                    End If
                Next
            End If

            mFSLCMB = HelpClass.TodayNumeric
            mCCMPN = _obj_Entidad_Combustible.CCMPN
            mCDVSN = _obj_Entidad_Combustible.CDVSN
            mCPLNDV = _obj_Entidad_Combustible.CPLNDV
            mNRUCTR = _obj_Entidad_Combustible.NRUCTR
            mNPLCUN = _obj_Entidad_Combustible.NPLCUN
            mCBRCNT = _obj_Entidad_Combustible.CBRCNT
            mCGRFO = CType(Me.cboGrifo.Codigo, Double)
            mCTPCMB = Me.cboTipocombustible.Codigo
            mFCRCMB = CType(HelpClass.CtypeDate(Me.dtpFechaCargaComb.Value), Double)
            mNVLGRF = CType(Me.txtValeCombustible.Text, Double)
            mQGLNCM = CType(Me.txtCombAsignado.Text, Double)
            mNPRCN1 = Me.txtPrecinto_1.Text.Trim
            mNPRCN2 = Me.txtPrecinto_2.Text.Trim
            mNPRCN3 = Me.txtPrecinto_3.Text.Trim
            If Me.txtCostocombustible.TextLength <> 0 Then mCSTGLN = CType(Me.txtCostocombustible.Text, Double)
            If rbtnValeTercero.Checked = True Then
                mNDCCT1 = IIf(Me.txtNroDocumento.Text.Trim.Equals(""), 0, Me.txtNroDocumento.Text.Trim)
                mCTPOD1 = IIf(Me.cboTipoDocumento.Codigo.Trim.Equals(""), 0, Me.cboTipoDocumento.Codigo)
                mFDCCT1 = IIf(Me.txtNroDocumento.Text.Trim.Equals(""), 0, HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaDocumento.Value))
            Else
                mNDCCT1 = 0
                mCTPOD1 = 0
                mFDCCT1 = 0
            End If

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
        'Dim obj_Entidad As New Combustible
        'Dim obj_Logica As New Combustible_BLL
        If Me.Validar_Inputs = True Then Exit Sub
        mNSLCMB = _obj_Entidad_Combustible.NSLCMB
        mFSLCMB = CType(HelpClass.TodayNumeric, Double)
        mCCMPN = _obj_Entidad_Combustible.CCMPN
        mCDVSN = _obj_Entidad_Combustible.CDVSN
        mCPLNDV = _obj_Entidad_Combustible.CPLNDV
        mCGRFO = CType(Me.cboGrifo.Codigo, Double)
        mCTPCMB = Me.cboTipocombustible.Codigo
        mFCRCMB = CType(HelpClass.CtypeDate(Me.dtpFechaCargaComb.Value), Double)
        mNVLGRF = CType(Me.txtValeCombustible.Text, Double)
        mQGLNCM = CType(Me.txtCombAsignado.Text, Double)
        mNPRCN1 = Me.txtPrecinto_1.Text.Trim
        mNPRCN2 = Me.txtPrecinto_2.Text.Trim
        mNPRCN3 = Me.txtPrecinto_3.Text.Trim
        mCTPOD1 = IIf(Me.cboTipoDocumento.Codigo.Trim.Equals(""), 0, Me.cboTipoDocumento.Codigo)
        mNDCCT1 = IIf(Me.txtNroDocumento.Text.Trim.Equals(""), 0, Me.txtNroDocumento.Text)
        mFDCCT1 = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaDocumento.Value)
        '_cnt_Galones = obj_Entidad.QGLNCM
        If Me.txtCostocombustible.TextLength <> 0 Then mCSTGLN = CType(Me.txtCostocombustible.Text, Double)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'obj_Entidad.CULUSA = MainModule.USUARIO
        'obj_Entidad.FULTAC = HelpClass.TodayNumeric
        'obj_Entidad.HULTAC = HelpClass.NowNumeric
        'obj_Entidad.NTRMNL = HelpClass.NombreMaquina
        'obj_Entidad.NSLCMB = obj_Logica.Modificar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB
        'If obj_Entidad.NSLCMB = 0 Then
        'HelpClass.ErrorMsgBox()
        'Else
        'Me.DialogResult = Windows.Forms.DialogResult.OK
        'End If
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

    Private Sub rbtnValePropio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnValePropio.CheckedChanged
        Validar_Vale()
    End Sub

    Private Sub rbtnValeTercero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnValeTercero.CheckedChanged
        Validar_Vale()
    End Sub

#End Region

#Region "Métodos y Funciones"

    Private Sub Validar_Vale()
        If rbtnValeTercero.Checked = True Then
            cboTipoDocumento.Enabled = True
            txtNroDocumento.Enabled = True
            dtpFechaDocumento.Enabled = True
        Else
            cboTipoDocumento.Codigo = 0
            cboTipoDocumento.Enabled = False
            txtNroDocumento.Text = ""
            txtNroDocumento.Enabled = False
            dtpFechaDocumento.Enabled = False
        End If
    End Sub

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

        If rbtnValeTercero.Checked = True Then
            If Me.cboTipoDocumento.NoHayCodigo = True Then
                lstr_validacion += "* TIPO DOCUMENTO " & Chr(13)
            End If
            If Me.txtNroDocumento.Text = "" Then
                lstr_validacion += "* NRO. DOCUMENTO " & Chr(13)
            End If
            If HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaDocumento.Value) = 0 Then
                lstr_validacion += "* FECHA DOCUMENTO " & Chr(13)
            End If
        End If
        'If Me.txtPrecinto_1.Text.Trim.Length = 0 Then
        'lstr_validacion += "* PRECINTO " & Chr(13)
        'End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub Limpiar_Controles()
        txtCombAsignado.Text = ""
        Me.cboGrifo.Limpiar()
        txtValeCombustible.Text = ""
        txtCombAsignado.Text = ""
        txtPrecinto_1.Text = ""
        txtPrecinto_2.Text = ""
        txtPrecinto_3.Text = ""
        Me.cboTipoDocumento.Limpiar()
        txtNroDocumento.Text = ""
        txtCostocombustible.Text = ""
        chkValidarVale.Checked = False
        cboTipocombustible.Enabled = True
        Me.cboTipocombustible.Codigo = "D2"
        btnBuscarVale.Enabled = False
    End Sub

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

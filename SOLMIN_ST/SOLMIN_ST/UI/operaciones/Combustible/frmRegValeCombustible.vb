Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Public Class frmRegValeCombustible

#Region "Atributo"
    Private _obj_Entidad_Combustible As New Combustible


    Private pNLQCMB As Decimal = 0
    Private pCCMPN As String = ""
    Private pCDVSN As String = ""
    'Private pCPLNDV As Decimal = 0
    Private pNRITEM As Decimal = 0
    Public pDialogOK As Boolean = False

    Public pCodEstadoLiq As String = ""
    Public Enum Accion
        Nuevo
        Editar
    End Enum
    Public pAccion As Accion = Accion.Nuevo
    
#End Region

    Public Sub New(NLQCMB As Decimal, CCMPN As String, CDVSN As String, NRITEM As Decimal)
        MyBase.New()
        InitializeComponent()
        pNLQCMB = NLQCMB
        pCCMPN = CCMPN
        pCDVSN = CDVSN
        'pCPLNDV = CPLNDV
        pNRITEM = NRITEM
    End Sub

    'Private Sub Listar_Combos()
    'Dim obj_Entidad_ValeCombustible As New ValeCombustible
    ''Dim obj_Logica_Grifo As New Grifo_BLL
    'Dim obj_Logica_TipoCombustible As New TipoCombustible_BLL
    'Dim obj_Logica_ValeCombustible As New ValeCombustible_BLL
    'Dim obj_Logica_TipoDocumento As New TipoDocumento_BLL
    'Dim obj_Entidad_TipoDocumento As New TipoDocumento
    'Dim objParametro As New Hashtable
    'objParametro.Add("PSCGRFO", "")
    'With Me.cboGrifo
    '    .DataSource = HelpClass.GetDataSetNative(obj_Logica_Grifo.Listar_Grifos)
    '    .KeyField = "CGRFO"
    '    .ValueField = "TGRFO"
    '    .DataBind()
    'End With

    'With Me.cboTipocombustible
    '    .DataSource = HelpClass.GetDataSetNative(obj_Logica_TipoCombustible.Listar_TipoCombustible)
    '    .KeyField = "CTPCMB"
    '    .ValueField = "TDSCMB"
    '    .DataBind()
    'End With

    'Me.txtValeCombustible.Text = ""
    'Me.cboTipocombustible.Codigo = "D2"
    'Me.cboGrifo.Limpiar()

    'obj_Entidad_TipoDocumento.CCMPN = pCCMPN
    'obj_Entidad_TipoDocumento.CTPODC = 0
    'With Me.cboTipoDocumento
    '    .DataSource = HelpClass.GetDataSetNative(obj_Logica_TipoDocumento.Listar_Tipo_Documento(obj_Entidad_TipoDocumento))
    '    .KeyField = "CTPODC"
    '    .ValueField = "TCMTPD"
    '    .DataBind()
    'End With


    'End Sub

    Private Sub Tipo_Documento()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj_Logica_TipoDocumento As New TipoDocumento_BLL


        Dim obj_Logica_Grifo As New Grifo_BLL
        Dim obj_Entidad_TipoDocumento As New TipoDocumento
        obj_Entidad_TipoDocumento.CCMPN = pCCMPN
        obj_Entidad_TipoDocumento.CTPODC = 0
        Dim lista As New List(Of ENTIDADES.mantenimientos.TipoDocumento)
        lista = obj_Logica_TipoDocumento.Listar_Tipo_Documento(obj_Entidad_TipoDocumento)



        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPODC"
        oColumnas.DataPropertyName = "CTPODC"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMTPD"
        oColumnas.DataPropertyName = "TCMTPD"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")


        cboTipoDocumento.Etiquetas_Form = Etiquetas
        cboTipoDocumento.DataSource = lista
        cboTipoDocumento.ListColumnas = oListColum
        cboTipoDocumento.Cargas()
        cboTipoDocumento.ValueMember = "CTPODC"
        cboTipoDocumento.DispleyMember = "TCMTPD"





    End Sub

    Private Sub Tipo_Combustible()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj_Logica_TipoCombustible As New TipoCombustible_BLL


        Dim obj_Logica_Grifo As New Grifo_BLL
        Dim lista As New List(Of ENTIDADES.mantenimientos.TipoCombustible)
        lista = obj_Logica_TipoCombustible.Listar_TipoCombustible



        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPCMB"
        oColumnas.DataPropertyName = "CTPCMB"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSCMB"
        oColumnas.DataPropertyName = "TDSCMB"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")


        cboTipocombustible.Etiquetas_Form = Etiquetas
        cboTipocombustible.DataSource = lista
        cboTipocombustible.ListColumnas = oListColum
        cboTipocombustible.Cargas()
        cboTipocombustible.ValueMember = "CTPCMB"
        cboTipocombustible.DispleyMember = "TDSCMB"

        cboTipocombustible.Valor = "D2"

    End Sub

    Private Sub Cargar_Grifo()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New LiquidacionCombustible_BLL


        Dim obj_Logica_Grifo As New Grifo_BLL
        Dim lista As New List(Of ENTIDADES.mantenimientos.Grifo)
        lista = obj_Logica_Grifo.Listar_Grifos()

        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CGRFO"
        oColumnas.DataPropertyName = "CGRFO"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TGRFO"
        oColumnas.DataPropertyName = "TGRFO"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")


        cboGrifo.Etiquetas_Form = Etiquetas
        cboGrifo.DataSource = lista
        cboGrifo.ListColumnas = oListColum
        cboGrifo.Cargas()
        cboGrifo.ValueMember = "CGRFO"
        cboGrifo.DispleyMember = "TGRFO"


    End Sub


    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click



        Try


            Dim obrValeCombustible As New ValeCombustible_BLL
            Dim obeValeCombustible As New ValeCombustible
            Dim msg As String = ""
            If Me.Validar_Inputs = True Then Exit Sub
            With obeValeCombustible
                .NLQCMB = pNLQCMB
                .NRITEM = pNRITEM
                .CCMPN = pCCMPN
                .CDVSN = pCDVSN

                .NVLGRS = txtValeCombustible.Text.Trim
                .CTPCMB = CType(cboTipocombustible.Resultado, ENTIDADES.mantenimientos.TipoCombustible).CTPCMB
                .CGRFO = CType(cboGrifo.Resultado, ENTIDADES.mantenimientos.Grifo).CGRFO
                .FCRCMB = CType(HelpClass.CtypeDate(Me.dtpFechaCargaComb.Value), Double)
                If cboTipoDocumento.Resultado Is Nothing Then
                    .NDCCTS = ""
                    .CTPOD1 = 0
                    .FDCCT1 = 0
                Else
                    .NDCCTS = txtNroDocumento.Text.Trim
                    .CTPOD1 = CType(cboTipoDocumento.Resultado, ENTIDADES.mantenimientos.TipoDocumento).CTPODC
                    .FDCCT1 = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaDocumento.Value)

                End If
                .QGLNCM = Val(txtCombAsignado.Text.Trim)
                .CSTGLN = Val(txtCostoComb.Text.Trim)
                .NPRCN1 = txtPrecintoLlegada.Text.Trim
                .NPRCN2 = txtPrecintoSalida.Text.Trim
                .NPRCN3 = txtPrecintoAd.Text.Trim
                .CULUSA = MainModule.USUARIO
                .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                .CMNDA1 = cboMoneda.SelectedValue
            End With

            msg = obrValeCombustible.Registrar_Vale_CombustibleV2(obeValeCombustible)

            If pAccion = Accion.Nuevo Then
                If msg = "" Then
                    pDialogOK = True
                    txtValeCombustible.Text = ""
                    txtValeCombustible.Focus()
                    MessageBox.Show("Vale Registrado", "Aviso", MessageBoxButtons.OK)
                Else
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If pAccion = Accion.Editar Then
                If msg = "" Then
                    pDialogOK = True
                    MessageBox.Show("Vale Actualizado", "Aviso", MessageBoxButtons.OK)
                Else
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Me.txtValeCombustible.TextLength = 0 Then
            lstr_validacion += "* Nro Vale " & Chr(13)
        End If

        If Me.cboGrifo.Resultado Is Nothing Then
            lstr_validacion += "* Grifo " & Chr(13)
        End If


        If Me.cboTipocombustible.Resultado Is Nothing Then
            lstr_validacion += "* Tipo Combustible " & Chr(13)
        End If


        If Val(txtCombAsignado.Text.Trim) = 0 Then
            lstr_validacion += "* Galones" & Chr(13)
        End If


        'If Val(txtCostocombustible.Text.Trim) = 0 Then
        '    lstr_validacion += "* Costo" & Chr(13)
        'End If

        If cboTipoDocumento.Resultado IsNot Nothing Then
            If txtNroDocumento.Text.Trim = "" Or Val(txtNroDocumento.Text.Trim) = 0 Then
                lstr_validacion += "* Ingrese número documento / Verificar fecha Documento."
            End If
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub CargaMoneda()
        Dim obllMoneda As New NEGOCIO.Moneda_BLL
        Dim dt As New DataTable
        dt = obllMoneda.Listar_Monedas_Basica()
        cboMoneda.DataSource = dt
        cboMoneda.ValueMember = "pCMNDA1_Codigo"
        cboMoneda.DisplayMember = "pTMNDA_Detalle"
        cboMoneda.SelectedValue = 1
        cboMoneda.Enabled = False
    End Sub

    Private Sub frmRegValeCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Me.Listar_Combos()
            Cargar_Grifo()
            Tipo_Combustible()
            Tipo_Documento()
            CargaMoneda()
            cboTipoDocumento_CambioDeTexto(cboTipoDocumento)

            'cboTipoDocumento_Texto_KeyEnter(cboTipoDocumento, Nothing)

            If pAccion = Accion.Editar Then
                Dim obrValeCombustible As New ValeCombustible_BLL
                Dim dtVale As New DataTable
                Dim oVale As New ENTIDADES.Operaciones.ValeCombustible
                oVale.CCMPN = pCCMPN
                oVale.NLQCMB = pNLQCMB
                oVale.NRITEM = pNRITEM

                dtVale = obrValeCombustible.Listar_Item_Vale_Combustible(oVale)
                If dtVale.Rows.Count > 0 Then
                    txtValeCombustible.Text = ("" & dtVale.Rows(0)("NVLGRS")).ToString.Trim

                    dtpFechaCargaComb.Value = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(dtVale.Rows(0)("FCRCMB"))
                    cboGrifo.Valor = dtVale.Rows(0)("CGRFO")
                    cboTipocombustible.Valor = dtVale.Rows(0)("CTPCMB")
                    txtCombAsignado.Text = Val(dtVale.Rows(0)("QGLNCM"))
                    'txtCostocombustible.Text = Val(dtVale.Rows(0)("CSTGLN"))
                    txtCostoComb.Text = Val(dtVale.Rows(0)("CSTGLN"))
                    If dtVale.Rows(0)("CTPOD1") > 0 Then
                        cboTipoDocumento.Valor = dtVale.Rows(0)("CTPOD1")
                    End If
                    txtNroDocumento.Text = ("" & dtVale.Rows(0)("NDCCTS")).ToString.Trim
                    If Val("" & dtVale.Rows(0)("FDCCT1")) > 0 Then
                        dtpFechaDocumento.Value = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(dtVale.Rows(0)("FDCCT1"))
                    Else
                        dtpFechaDocumento.Value = Date.Today
                    End If
                    txtPrecintoLlegada.Text = dtVale.Rows(0)("NPRCN1")
                    txtPrecintoSalida.Text = dtVale.Rows(0)("NPRCN2")
                    txtPrecintoAd.Text = dtVale.Rows(0)("NPRCN3")
                    cboMoneda.SelectedValue = dtVale.Rows(0)("CMNDA1")

                    txtValeCombustible.Enabled = False
                    cboGrifo.Enabled = False

                    'If pCodEstadoLiq = "P" Then ' si liquidacion es pre-cerrado

                    '    txtCombAsignado.Enabled = False
                    '    'txtCostocombustible.Enabled = False
                    '    txtCostoReal.Enabled = True

                    'End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Private Sub txtSoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValeCombustible.KeyPress
    '    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    '    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    '    If KeyAscii = 0 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub cboGrifo_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If Me.cboGrifo.NoHayCodigo = True Then

    '        Me.txtCostocombustible.Text = "0.00"
    '    Else
    '        Dim objParametro As New Hashtable
    '        objParametro.Add("PSCGRFO", cboGrifo.Codigo)
    '        Dim obj_Logica_Grifo As New Grifo_BLL
    '        _list_Tarifa = obj_Logica_Grifo.Listar_Tarifa_Actual(objParametro)

    '    End If
    '    cboTipocombustible_Texto_KeyEnter(cboTipocombustible, Nothing)

    'End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    'Private Sub cboTipocombustible_Texto_KeyEnter(sender As Object, e As KeyEventArgs)
    '    Try
    '        If Me.cboGrifo.NoHayCodigo = True OrElse Me.cboTipocombustible.NoHayCodigo = True Then
    '            Me.txtCostocombustible.Text = "0.00"
    '        Else
    '            _obj_Entidad_Combustible.CGRFO = cboGrifo.Codigo.Trim
    '            _obj_Entidad_Combustible.CTPCMB = cboTipocombustible.Codigo.Trim

    '            Dim objEntidad As Grifo = _list_Tarifa.Find(_match)
    '            If objEntidad Is Nothing Then
    '                Me.txtCostocombustible.Text = String.Format("{0:N2}", 0)
    '            Else
    '                Me.txtCostocombustible.Text = String.Format("{0:N2}", objEntidad.IPRCMS)
    '            End If

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Function Busca_Tarifa(ByVal objEntidad As Grifo) As Boolean
    '    Dim CodGrifo As String = CType(cboGrifo.Resultado, ENTIDADES.mantenimientos.Grifo).CGRFO.ToString.Trim
    '    Dim CodTipoCombustible As String = CType(cboTipocombustible.Resultado, ENTIDADES.mantenimientos.TipoCombustible).CTPCMB.Trim
    '    Return (objEntidad.CGRFO.ToString = CodGrifo And objEntidad.CTPCMB = CodTipoCombustible)
    'End Function

    'Private Sub cboTipoDocumento_Texto_KeyEnter(sender As Object, e As KeyEventArgs)
    '    If cboTipoDocumento.NoHayCodigo = True Then
    '        txtNroDocumento.Enabled = False
    '        dtpFechaDocumento.Enabled = False
    '    Else
    '        txtNroDocumento.Enabled = True
    '        dtpFechaDocumento.Enabled = True
    '    End If
    'End Sub



    'Private Sub cboGrifo_CambioDeTexto(objData As Object) Handles cboGrifo.CambioDeTexto
    '    Try
    '        If cboGrifo.Resultado IsNot Nothing Then
    '            Dim objParametro As New Hashtable
    '            Dim CodGrifo As Decimal = CType(cboGrifo.Resultado, ENTIDADES.mantenimientos.Grifo).CGRFO

    '            objParametro.Add("PSCGRFO", CodGrifo)
    '            Dim obj_Logica_Grifo As New Grifo_BLL
    '            _list_Tarifa = obj_Logica_Grifo.Listar_Tarifa_Actual(objParametro)
    '        Else
    '            txtCostocombustible.Text = "0.00"
    '        End If
    '        BuscarCosto()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    'Private Sub BuscarCosto()
    '    If cboGrifo.Resultado IsNot Nothing And cboTipocombustible.Resultado IsNot Nothing Then
    '        _obj_Entidad_Combustible.CGRFO = CType(cboGrifo.Resultado, ENTIDADES.mantenimientos.Grifo).CGRFO
    '        _obj_Entidad_Combustible.CTPCMB = CType(cboTipocombustible.Resultado, ENTIDADES.mantenimientos.TipoCombustible).CTPCMB

    '        Dim objEntidad As Grifo = _list_Tarifa.Find(_match)
    '        If objEntidad Is Nothing Then
    '            txtCostocombustible.Text = String.Format("{0:N2}", 0)
    '        Else
    '            txtCostocombustible.Text = String.Format("{0:N2}", objEntidad.IPRCMS)
    '        End If

    '    Else
    '        Me.txtCostocombustible.Text = "0.00"

    '    End If
    'End Sub
    'Private Sub cboTipocombustible_CambioDeTexto(objData As Object) Handles cboTipocombustible.CambioDeTexto

    '    Try

    '        BuscarCosto()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub cboTipoDocumento_CambioDeTexto(objData As Object) Handles cboTipoDocumento.CambioDeTexto
        If cboTipoDocumento.Resultado Is Nothing Then
            txtNroDocumento.Enabled = False
            dtpFechaDocumento.Enabled = False
        Else
            txtNroDocumento.Enabled = True
            dtpFechaDocumento.Enabled = True
        End If
    End Sub
End Class
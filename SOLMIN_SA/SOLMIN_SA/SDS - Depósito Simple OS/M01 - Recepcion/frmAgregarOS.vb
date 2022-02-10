Imports RANSA.TYPEDEF
Imports RANSA.NEGO
Imports Ransa.Utilitario
Imports RANSA.TYPEDEF.beMercaderia

Public Class frmAgregarOS


    Dim _PSCMRCD As String
    Private objBE As beMercaderia

    Private _beContrato As beMercaderia

    Public Property beContrato() As beMercaderia
        Get
            Return _beContrato
        End Get
        Set(ByVal value As beMercaderia)
            _beContrato = value
        End Set
    End Property


    Private Sub frmAgregarOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ListaContratosVigentes()
            CargarControles()
            CargarPrimerRegistro()
            If Me.beContrato.PNNORDSR <> 0 Then
                Me.dgContratosVigentes.Visible = False
                'Me.txtFamilia.Enabled = False
                'Me.txtGrupo.Enabled = False
                'Me.txtCodiRansa.Enabled = False
                Me.txtUnidadValor.Enabled = False
                Me.txtUnidadPeso.Enabled = False
                Me.txtUnidadCantidad.Enabled = False
                Me.Size = New System.Drawing.Size(430, 290)
                pProcesarCargarInformación()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub CargarPrimerRegistro()

        Dim obeMercaderia As New beMercaderia
        Dim Lista As New List(Of beMercaderia)
        Dim obrMercaderia As New brMercaderia

        obeMercaderia.PNNCNTR = _beContrato.PNNCNTR
        Lista = obrMercaderia.fCargarPrimerRegistro(obeMercaderia)

        For Each objBE In Lista
            txtUnidadCantidad.Valor = objBE.PSCUNCN5
            txtUnidadPeso.Valor = objBE.PSCUNPS5
            txtUnidadValor.Valor = objBE.PSCUNVL5
            txtCantidad.Text = String.Format("{0:n2}", objBE.PNQMRCD1)
            txtPeso.Text = String.Format("{0:n2}", objBE.PNQPSMR1)
            txtValor.Text = String.Format("{0:n2}", objBE.PNQVLMR1)
            cbxUnidadDespacho.SelectedText = objBE.PSFUNDS2
        Next
    End Sub

    Private Sub ListaContratosVigentes()
        Dim obrOrdenServicio As New brMercaderia
        dgContratosVigentes.AutoGenerateColumns = False
        dgContratosVigentes.DataSource = obrOrdenServicio.ListaContratosVigentes(_beContrato)
    End Sub

    Private Sub CargarControles()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        'oColumnas.Name = "CFMLA"
        'oColumnas.DataPropertyName = "PSCFMLA"
        'oColumnas.HeaderText = "Código "
        'oListColum.Add(1, oColumnas)
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "TCMPFM"
        'oColumnas.DataPropertyName = "PSTCMPFM"
        'oColumnas.HeaderText = "Descripción "
        'oListColum.Add(2, oColumnas)
        'Dim obrMercaderia As New brMercaderia
        'Dim obeFiltro As New beMercaderia
        'Me.txtFamilia.DataSource = obrMercaderia.ListaFamiliaDeMercaderia(obeFiltro)
        'Me.txtFamilia.ListColumnas = oListColum
        'Me.txtFamilia.Cargas()
        'Me.txtFamilia.DispleyMember = "PSTCMPFM"
        'Me.txtFamilia.ValueMember = "PSCFMLA"



        Dim obrGeneral As New brGeneral
        Dim obeGeneral As New beGeneral

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCUNDMD"
        oColumnas.DataPropertyName = "PSCUNDMD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCMPUN"
        oColumnas.DataPropertyName = "PSTCMPUN"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        With obeGeneral
            .PSSTPOUN = "C"
        End With
        Me.txtUnidadCantidad.DataSource = obrGeneral.ListaUnidadDeMedida(obeGeneral)
        Me.txtUnidadCantidad.ListColumnas = oListColum
        Me.txtUnidadCantidad.Cargas()
        Me.txtUnidadCantidad.DispleyMember = "PSTCMPUN"
        Me.txtUnidadCantidad.ValueMember = "PSCUNDMD"


        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCUNDMD"
        oColumnas.DataPropertyName = "PSCUNDMD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCMPUN"
        oColumnas.DataPropertyName = "PSTCMPUN"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        With obeGeneral
            .PSSTPOUN = "P"
        End With
        Me.txtUnidadPeso.DataSource = obrGeneral.ListaUnidadDeMedida(obeGeneral)
        Me.txtUnidadPeso.ListColumnas = oListColum
        Me.txtUnidadPeso.Cargas()
        Me.txtUnidadPeso.DispleyMember = "PSTCMPUN"
        Me.txtUnidadPeso.ValueMember = "PSCUNDMD"

        With obeGeneral
            .PSSTPOUN = "V"
        End With

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCUNDMD"
        oColumnas.DataPropertyName = "PSCUNDMD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCMPUN"
        oColumnas.DataPropertyName = "PSTCMPUN"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)
        Me.txtUnidadValor.DataSource = obrGeneral.ListaUnidadDeMedida(obeGeneral)
        Me.txtUnidadValor.ListColumnas = oListColum
        Me.txtUnidadValor.Cargas()
        Me.txtUnidadValor.DispleyMember = "PSTCMPUN"
        Me.txtUnidadValor.ValueMember = "PSCUNDMD"

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CMRCA"
        oColumnas.DataPropertyName = "PNCMRCA"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMMRC"
        oColumnas.DataPropertyName = "PSTCMMRC"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)
        Me.txtMarca.ListColumnas = oListColum
        Me.txtMarca.Cargas()
        Me.txtMarca.DispleyMember = "PSTCMMRC"
        Me.txtMarca.ValueMember = "PNCMRCA"

    End Sub


    Private Sub btnProcesarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarCrearOS.Click
        Try
            pProcesarCrearOS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub pProcesarCrearOS()
        Dim blnResultado As Boolean = True
        If Not fblnValidarInfNuevaOS() Then
            blnResultado = False
        Else
            Dim obeMercaderia As beMercaderia = New beMercaderia
            With obeMercaderia
                .PNCCLNT = _beContrato.PNCCLNT
                .PNNORDSR = _beContrato.PNNORDSR
                .PNNCNTR = dgContratosVigentes.CurrentRow.Cells("M_NCNTR").Value
                .PSCTPDP3 = dgContratosVigentes.CurrentRow.Cells("M_CTPDP3").Value
                .PSCTPPR1 = dgContratosVigentes.CurrentRow.Cells("M_CTPPR1").Value
                Decimal.TryParse(txtCantidad.Text, .PNQMRCD)
                .PSCUNCND = CType(txtUnidadCantidad.Resultado, beGeneral).PSCUNDMD
                Decimal.TryParse(txtPeso.Text, .PNQPSMR)
                .PSCUNPS0 = CType(txtUnidadPeso.Resultado, beGeneral).PSCUNDMD
                Decimal.TryParse(txtValor.Text, .PNQVLMR)
                .PSCUNVLR = CType(txtUnidadValor.Resultado, beGeneral).PSCUNDMD
                .PSFUNCTL = "N"
                If cbxControlLote.Checked = True Then .PSFUNCTL = "S"
                .PSFUNDS = cbxUnidadDespacho.Text
                'Llenar la informacion
                '.PSCMRCD = CType(txtCodiRansa.Resultado, beMercaderia).PSCMRCD
                .PSCMRCD = _PSCMRCD
                If Me.txtMarca.Resultado Is Nothing Then
                    .PNCMRCA = 0
                Else
                    .PNCMRCA = CType(Me.txtMarca.Resultado, beMercaderia).PNCMRCA
                End If

                .PSUSUARIO = objSeguridadBN.pUsuario
                .PSNTRMNL = objSeguridadBN.pstrPCName

            End With
            Dim obrMercaderi As New brMercaderia
            If _beContrato.PNNORDSR <> 0 Then
                If obrMercaderi.fintActualizarOrdenServicio(obeMercaderia) = 1 Then
                    Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Modificar)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    HelpClass.ErrorMsgBox()
                End If
            Else
                If obrMercaderi.fintCrearOrdenServicio(obeMercaderia) = 1 Then
                    Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Crear)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    HelpClass.ErrorMsgBox()
                End If
            End If


        End If
    End Sub

    Private Function fblnValidarInfNuevaOS() As Boolean
        Dim strResultado As String = ""
        Dim blnResultado As Boolean = True
        Dim decTemp As Decimal
        Decimal.TryParse(txtCantidad.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar una Cantidad mayor o igual a cero. " & vbNewLine
        If txtUnidadCantidad.Resultado Is Nothing Then strResultado &= "No ha seleccionado una Unidad para la información de las Cantidades. " & vbNewLine
        Decimal.TryParse(txtPeso.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar un Peso mayor o igual a cero. " & vbNewLine
        If txtUnidadPeso.Resultado Is Nothing Then strResultado &= "No ha seleccionado una Unidad para la información de los Pesos. " & vbNewLine
        Decimal.TryParse(txtValor.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar un Valor mayor o igual a cero. " & vbNewLine
        If txtUnidadValor.Resultado Is Nothing Then strResultado &= "No ha seleccionado una Unidad para la información del Valor. " & vbNewLine
        'If txtCodiRansa.Resultado Is Nothing Then strResultado &= "No ha seleccionado codigo de Material. " & vbNewLine
        If txtCodRansa.Text = "" Then strResultado &= "No ha seleccionado codigo de Material. " & vbNewLine
        If cbxControlLote.Text = "" Then strResultado &= "No ha seleccionado la Unidad de Despacho . " & vbNewLine
        If dgContratosVigentes.CurrentCellAddress.Y = -1 Then strResultado &= "No ha seleccionado el contrato . " & vbNewLine

        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub pProcesarCargarInformación()
        Me.txtCantidad.Text = _beContrato.PNQMRCD1
        Me.txtPeso.Text = _beContrato.PNQPSMR1
        Me.txtValor.Text = _beContrato.PNQVLMR1
        Me.txtUnidadCantidad.Valor = _beContrato.PSCUNCN5
        Me.txtUnidadPeso.Valor = _beContrato.PSCUNPS5
        Me.txtUnidadValor.Valor = _beContrato.PSCUNVL5
        Me.cbxUnidadDespacho.SelectedIndex = IIf(_beContrato.PSFUNDS2 = "C", 0, 1)
        Me.cbxControlLote.Checked = IIf(_beContrato.PSFUNCTL = "S", True, False)
        'Me.txtFamilia.Valor = _beContrato.PSTCMPFM.Trim
        'Me.txtGrupo.Valor = _beContrato.PSTCMPGR.Trim
        If _beContrato.PNCMRCA <> 0 Then
            Me.txtMarca.Valor = _beContrato.PNCMRCA
        End If

        'Me.txtCodiRansa.Valor = _beContrato.PSCMRCD.Trim
    End Sub



    Private Sub txtFamilia_CambioDeTexto(ByVal objData As Object)
        'Dim oListColum As New Hashtable
        'Dim oColumnas As New DataGridViewTextBoxColumn
        'oColumnas.Name = "CGRPO"
        'oColumnas.DataPropertyName = "PSCGRPO"
        'oColumnas.HeaderText = "Código "
        'oListColum.Add(1, oColumnas)
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "TCMPGR"
        'oColumnas.DataPropertyName = "PSTCMPGR"
        'oColumnas.HeaderText = "Descripción "
        'oListColum.Add(2, oColumnas)
        'If Not objData Is Nothing Then
        '    Dim obrMercaderia As New brMercaderia
        '    Me.txtGrupo.DataSource = obrMercaderia.ListaGrupoDeMercaderia(objData)
        'Else
        '    Me.txtGrupo.DataSource = Nothing
        'End If
        'Me.txtGrupo.ListColumnas = oListColum
        'Me.txtGrupo.Cargas()
        'Me.txtGrupo.Limpiar()
        'Me.txtGrupo.DispleyMember = "PSTCMPGR"
        'Me.txtGrupo.ValueMember = "PSCGRPO"
    End Sub

    Private Sub txtGrupo_CambioDeTexto(ByVal objData As System.Object)
        'Dim oListColum As New Hashtable
        'Dim oColumnas As New DataGridViewTextBoxColumn
        'oColumnas.Name = "CMRCD"
        'oColumnas.DataPropertyName = "PSCMRCD"
        'oColumnas.HeaderText = "Código "
        'oListColum.Add(1, oColumnas)
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "TCMPMR"
        'oColumnas.DataPropertyName = "PSTCMPMR"
        'oColumnas.HeaderText = "Descripción "
        'oListColum.Add(2, oColumnas)
        'If Not objData Is Nothing Then
        '    Dim obrMercaderia As New brMercaderia
        '    Me.txtCodiRansa.DataSource = obrMercaderia.flistListarMercaderiRansa(objData)
        'Else
        '    Me.txtCodiRansa.DataSource = Nothing
        'End If
        'Me.txtCodiRansa.ListColumnas = oListColum
        'Me.txtCodiRansa.Cargas()
        'Me.txtCodiRansa.Limpiar()
        'Me.txtCodiRansa.DispleyMember = "PSTCMPMR"
        'Me.txtCodiRansa.ValueMember = "PSCMRCD"

    End Sub

    Private Sub txtMarca_Consultar(ByVal strData As String, ByRef objData As Object) Handles txtMarca.Consultar
        Dim obrMercaderia As New brMercaderia
        Dim obemercaderia As New beMercaderia
        With obemercaderia
            .PNCMRCA = Val(strData)
            .PSTCMMRC = strData.ToUpper
            .PageSize = 20
            .PageNumber = 1
        End With
        objData = obrMercaderia.ListaMarca(obemercaderia)
    End Sub

    Private Sub ButtonSpecAny1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecAny1.Click
        Try
            Dim objFRM As New frmCodRansa

            If objFRM.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCodRansa.Text = String.Format("{0} - {1}", objFRM.COD_PSCMRCD, objFRM.DES_PSCMRCD)
                _PSCMRCD = objFRM.COD_PSCMRCD
            Else
                txtCodRansa.Text = ""
                _PSCMRCD = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub
End Class

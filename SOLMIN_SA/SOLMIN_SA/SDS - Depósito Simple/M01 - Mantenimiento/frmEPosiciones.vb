'Imports RANSA.TypeDef.Cliente
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS

Public Class frmEPosiciones

#Region "Variables"
    Private oEntidad As beUbicacion
    Private _IsNuevo As Boolean
    Private _IdPlanta As String
#End Region

#Region "Atributos"
    Public Property IsNuevo() As Boolean
        Get
            Return _IsNuevo
        End Get
        Set(ByVal value As Boolean)
            _IsNuevo = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"
    Private Sub SetEnabled(ByVal bValor As Boolean)
        txtTipoAlmacen.Enabled = False
        txtAlmacen.Enabled = False
        txtPSCSECTR.Enabled = False
    End Sub

    Private Sub SetEstado()
        Dim dt As New DataTable
        dt.Columns.Add("codigo", GetType(String))
        dt.Columns.Add("descripcion", GetType(String))
        Dim dr As DataRow
        dr = dt.NewRow
        dr.Item("codigo") = "L"
        dr.Item("descripcion") = "Libre"
        dt.Rows.Add(dr)
        dr = dt.NewRow
        dr.Item("codigo") = "O"
        dr.Item("descripcion") = "Ocupado"
        dt.Rows.Add(dr)
        cboPSCPOS.DataSource = dt

    End Sub

    Private Sub SetDataSource(ByVal obj As beUbicacion)
        'If String.IsNullOrEmpty(obj.PSCTPALM) Then Exit Sub
        'txtPSCTPALM.Tag = obj.PSCTPALM
        'txtPSCTPALM.Text = obj.PSTIPO
        'Call mfblnBuscar_TipoAlmacen(txtPSCTPALM.Tag, txtPSCTPALM.Text)
        'If String.IsNullOrEmpty(obj.PSCALMC) Then Exit Sub
        'txtPSCALMC.Tag = obj.PSCALMC
        'txtPSCALMC.Text = obj.PSALMACEN
        'Call mfblnBuscar_Almacen("" & txtPSCTPALM.Tag, txtPSCALMC.Tag, txtPSCALMC.Text)

        txtTipoAlmacen.Valor = obj.PSCTPALM.Trim
        txtAlmacen.Valor = obj.PSCALMC.Trim
        txtZonaAlmacen.Valor = obj.PSCZNALM.Trim

        txtPSCSECTR.Text = "G"
        If Not IsNuevo Then
            With obj
                txtPSCSECTR.Text = .PSCSECTR
                txtPSCPSCN.Text = .PSCPSCN
                txtPSCPRFMR.Text = .PSCPRFMR
                txtPSCAPIMR.Text = .PSCAPIMR
                txtPSCROTMR.Text = .PSCROTMR
                txtPNCSRVPK.Text = .PNCSRVPK
                txtPNNCOORX.Text = .PNNCOORX
                txtPNNCOORY.Text = .PNNCOORY
                txtPNNCOORZ.Text = .PNNCOORZ
                txtPNNCOOX2.Text = .PNNCOOX2
                txtPNNCOOY2.Text = .PNNCOOY2
                txtPNNCOOZ2.Text = .PNNCOOZ2
                cboPSCPOS.SelectedValue = .PSSSCPOS
                If String.IsNullOrEmpty(.PNCCLNRN) Then Exit Sub
                Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(.PNCCLNRN, objSeguridadBN.pUsuario)
                txtCliente.pCargar(ClientePK)
            End With
        End If
    End Sub

    Private Sub GetDataSource()
        With oEntidad
            If txtTipoAlmacen.Resultado Is Nothing Then
                .PSCTPALM = ""
            Else
                .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM.Trim  'Me.txtTipoAlmacen.Tag
            End If

            If txtAlmacen.Resultado Is Nothing Then
                .PSCALMC = ""
            Else
                .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC.Trim  'Me.txtAlmacen.Tag
            End If
            If txtZonaAlmacen.Resultado Is Nothing Then
                .PSCZNALM = ""
            Else
                .PSCZNALM = CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM.Trim
            End If
            .PSCSECTR = txtPSCSECTR.Text.Trim
            .PSCPSCN = txtPSCPSCN.Text.Trim
            .PSCPRFMR = txtPSCPRFMR.Text.Trim
            .PSCAPIMR = txtPSCAPIMR.Text.Trim
            .PSCROTMR = txtPSCROTMR.Text.Trim
            .PNCSRVPK = Val(txtPNCSRVPK.Text)
            .PNCCLNRN = txtCliente.pCodigo
            .PNNCOORX = Val(txtPNNCOORX.Text)
            .PNNCOORY = Val(txtPNNCOORY.Text)
            .PNNCOORZ = Val(txtPNNCOORZ.Text)
            .PNNCOOX2 = Val(txtPNNCOOX2.Text)
            .PNNCOOY2 = Val(txtPNNCOOY2.Text)
            .PNNCOOZ2 = Val(txtPNNCOOZ2.Text)
            .PSSSCPOS = cboPSCPOS.SelectedValue.ToString.Trim
        End With
    End Sub

    Private Sub CargarControlTipoAlmacen()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub



#End Region

    Public Property IdPlanta() As String
        Get
            Return _IdPlanta
        End Get
        Set(ByVal value As String)
            _IdPlanta = value
        End Set
    End Property

#Region "Eventos"

    Private Sub frmEPosiciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim objAppConfig As cAppConfig = New cAppConfig
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("MANSDS_ClienteCodigo", GetType(System.String)), intTemp)
            If intTemp <> 0 Then
                Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
                txtCliente.pCargar(ClientePK)
            End If
            txtCliente.pUsuario = objSeguridadBN.pUsuario
            objAppConfig = Nothing
            SetEstado()
            oEntidad = TryCast(Me.Tag, beUbicacion)
            CargarControlTipoAlmacen()
            SetDataSource(oEntidad)
            If IsNuevo Then
                SetEnabled(True)
            Else
                SetEnabled(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
    '    Call mfblnBuscar_TipoAlmacen(txtPSCTPALM.Tag, txtPSCTPALM.Text)
    'End Sub

    'Private Sub txtTipoAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPSCTPALM.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.F4
    '            Call mfblnBuscar_TipoAlmacen(txtPSCTPALM.Tag, txtPSCTPALM.Text)
    '        Case Keys.Delete
    '            txtPSCTPALM.Text = ""
    '    End Select

    'End Sub

    'Private Sub txtTipoAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPSCTPALM.TextChanged
    '    txtPSCTPALM.Tag = ""
    '    txtPSCALMC.Text = ""
    'End Sub

    'Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPSCTPALM.Validating
    '    If txtPSCTPALM.Text = "" Then
    '        txtPSCTPALM.Tag = ""
    '    Else
    '        If txtPSCTPALM.Text <> "" And "" & txtPSCTPALM.Tag = "" Then
    '            Call mfblnBuscar_TipoAlmacen(txtPSCTPALM.Tag, txtPSCTPALM.Text)
    '            If txtPSCTPALM.Text = "" Then
    '                e.Cancel = True
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try
            Dim obrEntidad As New brUbicacion
            Dim strText As String
            GetDataSource()
            If IsNuevo Then
                obrEntidad.Insertar(oEntidad)
                strText = "El registro se insertó satisfactoriamente."
            Else
                obrEntidad.Update(oEntidad)
                strText = "El registro se actualizó satisfactoriamente"
            End If
            MessageBox.Show(strText, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    'Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPSCALMC.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.F4
    '            Call mfblnBuscar_Almacen("" & txtPSCTPALM.Tag, txtPSCALMC.Tag, txtPSCALMC.Text)
    '        Case Keys.Delete
    '            txtPSCALMC.Text = ""
    '    End Select
    'End Sub

    'Private Sub txtAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPSCALMC.TextChanged
    '    txtPSCALMC.Tag = ""
    'End Sub

    'Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPSCALMC.Validating
    '    If txtPSCALMC.Text = "" Then
    '        txtPSCALMC.Tag = ""
    '    Else
    '        If txtPSCALMC.Text <> "" And "" & txtPSCALMC.Tag = "" Then
    '            Call mfblnBuscar_Almacen("" & txtPSCTPALM.Tag, txtPSCALMC.Tag, txtPSCALMC.Text)
    '            If txtPSCALMC.Text = "" Then
    '                e.Cancel = True
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
    '    Call mfblnBuscar_Almacen("" & txtPSCTPALM.Tag, txtPSCALMC.Tag, txtPSCALMC.Text)
    'End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Close()
    End Sub


    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = IdPlanta ' 1
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNALM"
        oColumnas.DataPropertyName = "PSCZNALM"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMZNA"
        oColumnas.DataPropertyName = "PSTCMZNA"
        oColumnas.HeaderText = "Zona Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            txtZonaAlmacen.DataSource = Nothing
        End If
        txtZonaAlmacen.ListColumnas = oListColum
        txtZonaAlmacen.Cargas()
        txtZonaAlmacen.Limpiar()
        txtZonaAlmacen.ValueMember = "PSCZNALM".Trim()
        txtZonaAlmacen.DispleyMember = "PSTCMZNA"
    End Sub


#End Region

    Private Sub txtTipoAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.Load

    End Sub
End Class

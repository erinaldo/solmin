Imports RANSA.TypeDef.Cliente
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS
Imports ComponentFactory.Krypton.Toolkit

Public Class frmESloting

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

#Region "Variables"
    Private oEntidad As beSugerenciaMercaderia
    Private _IsNuevo As Boolean
    Private IsGuardar As Boolean
#End Region

#Region "Metodos y Funciones"

    Private Sub SetEnabled(ByVal bValor As Boolean)
        txtTipoAlmacen.Enabled = bValor
        txtAlmacen.Enabled = bValor
        txtCliente.Enabled = bValor
        txtFamilia.Enabled = bValor
        txtGrupo.Enabled = bValor
        txtPosicion.Enabled = bValor
        txtCodigoMercaderia.Enabled = bValor
        txtPasillo.Enabled = bValor
        txtColumna.Enabled = bValor
    End Sub

    Private Sub SetDataSource(ByVal obj As beSugerenciaMercaderia)
        If String.IsNullOrEmpty(obj.PNCCLNT) Then Exit Sub
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(obj.PNCCLNT, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        If String.IsNullOrEmpty(obj.PSCTPALM) Then Exit Sub
        txtTipoAlmacen.Tag = obj.PSCTPALM
        txtTipoAlmacen.Text = obj.PSTIPO
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
        If String.IsNullOrEmpty(obj.PSCALMC) Then Exit Sub
        txtAlmacen.Tag = obj.PSCALMC
        txtAlmacen.Text = obj.PSALMACEN
        Dim almacen As String = txtAlmacen.Text.PadRight(30, " ")
        Call mfblnBuscar_Almacen(txtTipoAlmacen.Tag, txtAlmacen.Tag, almacen)
        If Not IsNuevo Then
            txtFamilia.Text = obj.PSFAMILIA.Trim
            txtFamilia.Tag = obj.PSCFMCLR
            Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
            txtGrupo.Text = obj.PSGRUPO.Trim
            txtGrupo.Tag = obj.PSCGRCLR
            Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
            txtCodigoMercaderia.Text = obj.PSCMRCLR
            txtPosicion.Text = obj.PSCPSCN
            txtColumna.Text = obj.PSCCLMN
            txtPasillo.Text = obj.PSCPSLL
            txtPrioridad.Text = obj.PNNCRPRD
        End If
    End Sub

    Private Sub GetDataSource()
        With oEntidad
            .PNCCLNT = txtCliente.pCodigo
            .PNNCRPRD = Val(txtPrioridad.Text)
            .PSCALMC = txtAlmacen.Tag
            .PSCCLMN = txtColumna.Text
            .PSCFMCLR = txtFamilia.Tag
            .PSCGRCLR = txtGrupo.Tag
            .PSCMRCLR = txtCodigoMercaderia.Text
            .PSCPSCN = txtPosicion.Text
            .PSCPSLL = txtPasillo.Text
            .PSCTPALM = txtTipoAlmacen.Tag
        End With
    End Sub

    Private Sub ValidarControles(ByVal Container As Control)
        For Each c As Control In Container.Controls
            If TypeOf (c) Is KryptonTextBox Then
                If ValidateText(c) Then
                    IsGuardar = True
                End If
            ElseIf c.HasChildren Then
                ValidarControles(c)
            End If
        Next
    End Sub

    Private Sub pCargarControles(ByVal objMercaderia As clsMercaderia)
        With objMercaderia
            txtDescMerca01.Text = .pstrDescripcion_TMRCD2
        End With
    End Sub


#End Region

#Region "Eventos"

    Private Sub frmESloting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("MANSDS_ClienteCodigo", GetType(System.String)), intTemp)
        If intTemp <> 0 Then
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
        End If
        txtCliente.pUsuario = objSeguridadBN.pUsuario
        objAppConfig = Nothing
        oEntidad = TryCast(Me.Tag, beSugerenciaMercaderia)
        SetDataSource(oEntidad)
        If IsNuevo Then
            SetEnabled(True)
        Else
            SetEnabled(False)
        End If
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select

    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        txtAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub txtFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
        Else
            txtFamilia.Text = ""
        End If
    End Sub

    Private Sub txtFamilia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFamilia.TextChanged
        txtFamilia.Tag = ""
        txtGrupo.Text = ""
    End Sub

    Private Sub txtFamilia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFamilia.Validating
        If txtFamilia.Text = "" Then
            txtFamilia.Tag = ""
            Exit Sub
        Else
            If txtFamilia.Text <> "" And "" & txtFamilia.Tag = "" Then
                Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
                If txtFamilia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrupo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
        Else
            txtGrupo.Text = ""
        End If
    End Sub

    Private Sub txtGrupo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrupo.TextChanged
        txtGrupo.Tag = ""
    End Sub

    Private Sub txtGrupo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGrupo.Validating
        If txtGrupo.Text = "" Then
            txtGrupo.Tag = ""
            Exit Sub
        Else
            If txtGrupo.Text <> "" And "" & txtGrupo.Tag = "" Then
                Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
                If txtGrupo.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtCodigoMercaderia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoMercaderia.TextChanged
        txtCodigoMercaderia.Tag = ""
    End Sub

    Private Sub txtCodigoMercaderia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoMercaderia.Validating
        If txtCodigoMercaderia.Text = "" Then
            txtCodigoMercaderia.Tag = ""
            Exit Sub
        Else
            If txtCodigoMercaderia.Text <> "" And "" & txtCodigoMercaderia.Tag = "" Then
                Dim objPrimaryKey_Mercaderia As clsPrimaryKey_Mercaderia = New clsPrimaryKey_Mercaderia
                With objPrimaryKey_Mercaderia
                    .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                    .pstrCodigoFamilia_CFMCLR = "" & txtFamilia.Tag
                    .pstrCodigoGrupo_CGRCLR = "" & txtGrupo.Tag
                    .pstrCodigoMercaderia_CMRCLR = txtCodigoMercaderia.Text
                End With
                Dim strMercaderia As String = Nothing
                If mfblnExiste_Mercaderia(txtCliente.pCodigo, txtCodigoMercaderia.Text, strMercaderia) Then
                    Dim objMercaderia As clsMercaderia = New clsMercaderia
                    If mfblnObtener_Mercaderia(objPrimaryKey_Mercaderia, objMercaderia) Then Call pCargarControles(objMercaderia)
                End If
                txtCodigoMercaderia.Tag = txtCodigoMercaderia.Text
            End If
        End If
    End Sub

    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaFamiliaListar.Click
        Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
    End Sub

    Private Sub bsaGrupoListar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsaGrupoListar.Click
        Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Close()
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Dim obrEntidad As New brSugerenciaMercaderia
        IsGuardar = False
        ValidarControles(Me)
        If IsGuardar = False Then
            Dim strText As String
            GetDataSource()
            If IsNuevo Then
                obrEntidad.Insertar(oEntidad)
                strText = "El registro se inserto satisfactorimanete."
            Else
                obrEntidad.Update(oEntidad)
                strText = "El registro se actualizo satisfactorimanete"
            End If
            MessageBox.Show(strText, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Function ValidateText(ByVal textbox As KryptonTextBox) As Boolean
        If textbox.Name = "txtPrioridad" Then Exit Function
        If textbox.Name = "txtDescMerca01" Then Exit Function
        If String.IsNullOrEmpty(textbox.Text) Then
            ErrorProvider1.SetIconAlignment(textbox, ErrorIconAlignment.MiddleRight)
            ErrorProvider1.SetError(textbox, "Este campo no puede estar vacio.")
            Return True
        Else
            ErrorProvider1.SetError(textbox, "")
            Return False
        End If
    End Function


#End Region

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarMercaderia.Click
        Dim ofrmListaDeMercaderiasSDS As New frmListaDeMercaderiasSDS
        ofrmListaDeMercaderiasSDS.PNCCLNT = txtCliente.pCodigo
        If ofrmListaDeMercaderiasSDS.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtCodigoMercaderia.Text = ofrmListaDeMercaderiasSDS.obeMercaderia.PSCMRCLR
            Me.txtDescMerca01.Text = ofrmListaDeMercaderiasSDS.obeMercaderia.PSTMRCD2
        End If
    End Sub

    
    Private Sub btnBuscarPosicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPosicion.Click
        Dim ofrmListaDeSloting As New frmListaPosiciones
        ofrmListaDeSloting.PNCCLNT = txtCliente.pCodigo
        ofrmListaDeSloting.PSCTPALM = Me.txtTipoAlmacen.Tag
        ofrmListaDeSloting.PSCALMC = Me.txtAlmacen.Tag
        ofrmListaDeSloting.PSCSECTR = "G"
        If ofrmListaDeSloting.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPosicion.Text = ofrmListaDeSloting.obeUbicacion.PSCPSCN
            txtPasillo.Text = ofrmListaDeSloting.obeUbicacion.PSCPSLL
            Me.txtColumna.Text = ofrmListaDeSloting.obeUbicacion.PSCCLMN
        End If
    End Sub
End Class

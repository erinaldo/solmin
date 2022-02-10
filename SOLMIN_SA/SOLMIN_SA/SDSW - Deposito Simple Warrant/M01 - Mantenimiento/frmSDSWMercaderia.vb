Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDSW
Public Class frmSDSWMercaderia
#Region "Atributos"
    Private intCCLNT As Int64 = 0
    Private strTCMPCL As String = ""
#End Region
#Region " Propiedades "
    ' Se proporciona el Codigo del Cliente 
    Public WriteOnly Property pintCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property
    ' Se proporciona la Razón Social del Cliente
    Public WriteOnly Property pstrRazonSocial_TCMPCL() As String
        Set(ByVal value As String)
            strTCMPCL = value
        End Set
    End Property
#End Region
#Region " Métodos "
    Private Sub bsaClienteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        lblcodcliente.Text = txtCliente.Tag
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsafamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsafamilia.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_FamiliaSDSW(txtfamilia.Tag, txtfamilia.Text)
        lblcodfamilia.Text = txtfamilia.Tag
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaproducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaproducto.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_Familia_ProductoSDSW(txtproducto.Tag, txtproducto.Text, txtfamilia.Tag)
        lblcodproducto.Text = txtproducto.Tag
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
            lblcodcliente.Text = txtCliente.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        txtCliente.Tag = ""
    End Sub

    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If txtCliente.Text = "" Then
            txtCliente.Tag = ""
        Else
            If txtCliente.Text <> "" And "" & txtCliente.Tag = "" Then
                Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
                lblcodcliente.Text = txtCliente.Tag
                If txtCliente.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub txtfamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfamilia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_FamiliaSDSW(txtfamilia.Tag, txtfamilia.Text)
            lblcodfamilia.Text = txtfamilia.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub
    Private Sub txtfamilia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfamilia.TextChanged
        txtfamilia.Tag = ""
    End Sub
    Private Sub txtfamilia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtfamilia.Validating
        If txtfamilia.Text = "" Then
            txtfamilia.Tag = ""
        Else
            If txtfamilia.Text <> "" And "" & txtfamilia.Tag = "" Then
                Call mfblnBuscar_FamiliaSDSW(txtfamilia.Tag, txtfamilia.Text)
                lblcodfamilia.Text = txtfamilia.Tag
                If txtfamilia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub txtproducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtproducto.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_Familia_ProductoSDSW(txtproducto.Tag, txtproducto.Text, txtfamilia.Tag)
            lblcodproducto.Text = txtproducto.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub
    Private Sub txtproducto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtproducto.TextChanged
        txtproducto.Tag = ""
    End Sub
    Private Sub txtproducto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtproducto.Validating
        If txtproducto.Text = "" Then
            txtproducto.Tag = ""
        Else
            If txtproducto.Text <> "" And "" & txtproducto.Tag = "" Then
                Call mfblnBuscar_FamiliaSDSW(txtproducto.Tag, txtproducto.Text)
                lblcodproducto.Text = txtproducto.Tag
                If txtproducto.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmMercaderiaSDSW_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not mfblnSalirOpcion() Then
            e.Cancel = True
        End If
    End Sub
    Private Sub frmMercaderiaSDSW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If intCCLNT <> 0 Then
            txtCliente.Text = strTCMPCL
            txtCliente.Tag = intCCLNT
            lblcodcliente.Text = intCCLNT
        End If

        ' Realizamos las validaciones respectivas
        Dim objPrimaryKey_Mercaderia As clsSDSWPrimaryKey_Mercaderia = New clsSDSWPrimaryKey_Mercaderia
        Dim objMercaderia As clsSDSWMercaderia = New clsSDSWMercaderia
        With objPrimaryKey_Mercaderia
            .pintCodigoCliente_CCLNT = intCCLNT
            '.pstrCodigoFamilia_CFMCLR = strCFMCLR
        End With
    End Sub

    Private Sub PGuardarMercaderia()
        If fblnValidarMercaderia() Then
            Dim objMercaderia As clsSDSWMercaderia = New clsSDSWMercaderia
            With objMercaderia
                .pintCodigoCliente_CCLNT = txtCliente.Tag
                .pstrCodigoFamilia_CFMCLR = "0" + txtfamilia.Tag
                .pstrCodigoRANSA_CMRCD = txtproducto.Tag
                .pstrDescripcion_TMRCD2 = txtproducto.Text
                .pstrDescripcionFamilia_TFMCLR = txtfamilia.Text
                '.pintCodigoCliente_CCLNT = lblcodcliente.Text

            End With

            If mfblnGuardar_MercaderiaSDSW(objMercaderia) Then
                Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
                Call limpiar()
            Else
                Call mpMsjeVarios(enumMsjVarios.PROCESO_Ko_Guardar)
            End If
        End If
    End Sub

    Private Function fblnValidarMercaderia() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim strResultado As String = ""

        blnResultado = True
        If txtCliente.Text = "" Then strResultado &= "Debe seleccionar Cliente" & vbNewLine
        If txtfamilia.Text = "" Then strResultado &= "Debe seleccionar Familia" & vbNewLine
        If txtproducto.Text = "" Then strResultado &= "Debe seleccionar Producto" & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub btnProcesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesa.Click

        mfblnExiste_SDSWMercaderiaW(txtCliente.Tag, "0" + lblcodfamilia.Text, txtproducto.Tag, lblMensajeMercaderia.Text)

        If lblMensajeMercaderia.Text = "Código NO EXISTE" Then
            Call PGuardarMercaderia()
        Else
            Call limpiar()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub limpiar()
        txtproducto.Clear()
        txtfamilia.Clear()
        lblcodfamilia.Text = ""
        lblcodproducto.Text = ""
    End Sub

#End Region

    Private Sub KryptonHeaderGroup1_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonHeaderGroup1.Panel.Paint

    End Sub
End Class

Public Class frmSDSWTicketDesAlmacen
    Dim blnResultado As Boolean = False
    Private booStatusGeneral As Boolean = False
#Region " Atributos "
    Public Property pintHoraInicio() As String
        Get
            Return txthorainicio.Text
        End Get
        Set(ByVal value As String)
            txthorainicio.Text = value
        End Set
    End Property
    Public Property pintHorafinal() As String
        Get
            Return txthorafinal.Text
        End Get
        Set(ByVal value As String)
            txthorafinal.Text = value
        End Set
    End Property
    Public Property pdecHoraCalculada() As Decimal
        Get
            Return txthoracalc.Text
        End Get
        Set(ByVal value As Decimal)
            txthoracalc.Text = value
        End Set
    End Property
    Public Property pdecHoraFacturada() As Decimal
        Get
            Return txthorafact.Text
        End Get
        Set(ByVal value As Decimal)
            txthorafact.Text = value
        End Set
    End Property
    Public Property pstrTipoServicio() As String
        Get
            Return "" & txtTipoServicio.Tag
        End Get
        Set(ByVal value As String)
            txtTipoServicio.Tag = value
        End Set
    End Property
    Public Property pstrFecha() As String
        Get
            Return txtFecha.Text
        End Get
        Set(ByVal value As String)
            txtFecha.Text = value
        End Set
    End Property
    Public Property pstrobser() As String
        Get
            Return txtobser.Text
        End Get
        Set(ByVal value As String)
            txtobser.Text = value
        End Set
    End Property
#End Region

    Private Function fblnValidarticketrecepcion() As Boolean
        Dim strResultado As String = ""
        Dim dteFecha As Date
        blnResultado = True
        If txtTipoServicio.Text = "" Then strResultado &= "Debe seleccionar un Tipo de Servicio" & vbNewLine
        ' If txthorainicio.Text = "  :00:00" Then strResultado &= "Debe Ingresar la Hora de Inicio" & vbNewLine
        ' If txthorafinal.Text = "  :00:00" Then strResultado &= "Debe Ingresar la Hora Final" & vbNewLine
        If txthoracalc.Text = "  ." Or txthoracalc.Text = "00.00" Then txthoracalc.Text = txthorafact.Text
        If txthorafact.Text = "00.00" Then strResultado &= "Debe Ingresar Hora Facturada" & vbNewLine
        If Val(Me.txthorainicio.Text) > Val(Me.txthorafinal.Text) Then strResultado &= "La Hora Inicio es Mayor" & vbNewLine
        If Not Date.TryParse(txtFecha.Text, dteFecha) Then strResultado &= "Fecha Incorrecta" & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub bsaTipoServicioListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoServicioListar.Click
        Call mfblnBuscar_ServicioSDSW(txtTipoServicio.Tag, txtTipoServicio.Text, Compania_Usuario, Division_Usuario)
    End Sub

    Private Sub txtTipoServicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoServicio.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_ServicioSDSW(txtTipoServicio.Tag, txtTipoServicio.Text, Compania_Usuario, Division_Usuario)
            Case Keys.Delete
                txtTipoServicio.Text = ""
        End Select
    End Sub

    Private Sub txtTipoServicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoServicio.TextChanged
        txtTipoServicio.Tag = ""
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
        Me.Close()
    End Sub

    Private Sub btnAgregarRecepcionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRecepcionItem.Click
        If fblnValidarticketrecepcion() Then Me.Close()
    End Sub

    Private Sub txtTipoServicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoServicio.Validating
        If txtTipoServicio.Text = "" Then
            txtTipoServicio.Tag = ""
        Else
            If txtTipoServicio.Text <> "" And "" & txtTipoServicio.Tag = "" Then
                Call mfblnBuscar_ServicioSDSW(txtTipoServicio.Tag, txtTipoServicio.Text, Compania_Usuario, Division_Usuario)
                If txtTipoServicio.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFecha.Text = Now
    End Sub

    Private Sub txthorafinal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthorafinal.LostFocus
        Dim A, B, D As Decimal
        A = Mid(txthorainicio.Text, 1, 5).Replace(":", ".")
        B = Mid(txthorafinal.Text, 1, 5).Replace(":", ".")
        D = B - A
        txthoracalc.Text = D
        txthorafact.Text = D
        If Len(txthoracalc.Text) = 4 Then
            txthoracalc.Text = 0 & D
            txthorafact.Text = 0 & D
        End If
    End Sub

    Private Sub txthorainicio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthorainicio.LostFocus
        If Val(txthorainicio.Text) > 24 Then
            MsgBox("Hora Incorrecta", vbOKOnly, "Verifique .... ")
            txthorainicio.Text = ""
        End If
    End Sub
    Private Sub frmTicketDesAlmacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub


    Private Sub txthorafinal_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txthorafinal.MaskInputRejected

    End Sub
End Class

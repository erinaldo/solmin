Imports Ransa.TypeDef
Imports Ransa.Utilitario
Public Class frmProductoPedido

    Public pobeMercaderia As New beMercaderia

    Private _CodCliente As Double

    Public Property CodCliente() As Double
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As Double)
            _CodCliente = value
        End Set
    End Property

    Private _obePedidoPorPlanta As bePedidoPorPlanta

    ''' <summary>
    ''' Datos generales de Pedido 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property obePedidoPorPlanta() As bePedidoPorPlanta
        Get
            Return _obePedidoPorPlanta
        End Get
    End Property


    Private Sub frmProductoPedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 20)
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 20)
        LimpiarControl()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If fblnValidar() Then
            _obePedidoPorPlanta = New bePedidoPorPlanta
            With obePedidoPorPlanta
                If Me.rbtPropio.Checked Then
                    .PNCPLNCL = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                    .PNCPRVCL = 0
                    .PNCPLCLP = 0
                Else
                    .PNCPLNCL = 0
                    .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
                    .PNCPLCLP = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                End If
                .PSNORCML = Me.txtOrdenDeCompra.Text
                .PNNDCFCC = Val(Me.txtFactura.Text)
                .PNFDSPAL = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaDespacho.Value)
                .PSTOBSMD = Me.txtObservaciones.Text
                .PSNRFTPD = Me.txtReferenciaPedido1.Text
                .PSNRFRPD = Me.txtReferenciaPedido2.Text
            End With
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If Me.rbtPropio.Checked And UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL = 0 Then strMensajeError &= "Falta - Planta de Entrega." & vbNewLine
        If Me.rbtTercero.Checked And UcClienteTercero_xtF011.ItemActual.PNCPRVCL = 0 Then strMensajeError &= "Falta - Cliente Tercero." & vbNewLine
        If Me.rbtTercero.Checked And UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL = 0 Then strMensajeError &= "Falta - Planta de Entrega." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub rbtPropio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPropio.CheckedChanged
        If Me.rbtPropio.Checked Then
            UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = True
            UcClienteTercero_xtF011.Visible = False
            lblClienteTercero.Visible = False
            Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 18)
            Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 18)
            LimpiarControl()
        End If
    End Sub

    Private Sub rbtTercero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtTercero.CheckedChanged
        If Me.rbtTercero.Checked Then
            UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = False
            UcClienteTercero_xtF011.Visible = True
            lblClienteTercero.Visible = True
            Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 42)
            Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 42)
            LimpiarControl()
        End If
    End Sub

    Private Sub LimpiarControl()
        UcPlantaDeEntrega_TxtF011.CodCliente = _CodCliente
        UcClienteTercero_xtF011.CodCliente = _CodCliente
        UcPlantaDeEntrega_TxtF011.pClear()
        UcClienteTercero_xtF011.pClear()
    End Sub

    Private Sub UcClienteTercero_xtF011_TextChanged() Handles UcClienteTercero_xtF011.TextChanged
        UcPlantaDeEntrega_TxtF011.pClear()
        UcPlantaDeEntrega_TxtF011.CodClienteTercero = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
    End Sub

    Private Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        If HelpClass.SoloNumeros(AscW(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub KryptonGroup1_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonGroup1.Panel.Paint

    End Sub
End Class

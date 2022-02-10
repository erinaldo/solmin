Public Class frmCalculadoraSimple
    Private _result As Double
    Public Property result() As Double
        Get
            Return _result
        End Get
        Set(ByVal value As Double)
            _result = value
        End Set
    End Property

    
    Private Sub frmCalculadoraSimple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMontoCalcular.Text = _result
        cmbOpcionCambio.SelectedIndex = 0
    End Sub

    Private Sub txtResultado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResultado.KeyPress
        If Comun.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        _result = IIf(txtResultado.Text = "", 0, txtResultado.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmbOpcionCambio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOpcionCambio.SelectedIndexChanged
        RecalculaResultado()
    End Sub

    Private Sub txtTipoCambio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoCambio.Leave
        If txtTipoCambio.Text = "" Then txtTipoCambio.Text = 1
        RecalculaResultado()
    End Sub

    Private Sub txtMontoCalcular_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoCalcular.Leave
        If txtMontoCalcular.Text = "" Then txtMontoCalcular.Text = 0
        RecalculaResultado()
    End Sub

    Private Sub cmbOpcionCambio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpcionCambio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtTipoCambio.Focus()
        End If
    End Sub
    Private Sub txtTipoCambio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoCambio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtMontoCalcular.Focus()
        End If
        If Comun.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
    Private Sub txtMontoCalcular_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCalcular.KeyPress
        If Comun.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        If Asc(e.KeyChar) = Keys.Enter Then
            btnAceptar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub RecalculaResultado()
        If cmbOpcionCambio.SelectedIndex = 0 Then
            txtResultado.Text = Math.Round(txtMontoCalcular.Text / txtTipoCambio.Text, 2)
        Else
            txtResultado.Text = Math.Round(txtMontoCalcular.Text * txtTipoCambio.Text, 2)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class

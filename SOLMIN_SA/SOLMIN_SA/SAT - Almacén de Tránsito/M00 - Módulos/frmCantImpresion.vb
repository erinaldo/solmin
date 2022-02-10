Imports System.Windows.Forms

Public Class frmCantImpresion
 
    Private _init As Integer = 1
    Private _total As Integer = 0
    Private _isdetailled As Boolean = False

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click

        If Me.KryptonRadioButton1.Checked = True Then
            _init = CInt(txtTotal.Text)
            _total = CInt(txtTotal.Text)
        Else
            _init = CInt(txtCantInicial.Text)
            _total = CInt(txtCantFinal.Text)
        End If

        Me.Close()
    End Sub

    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        Me.Close()
    End Sub

    Public ReadOnly Property pIdDetailled() As Boolean
        Get
            Return _isdetailled
        End Get
    End Property

    Private Sub KryptonRadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonRadioButton2.CheckedChanged
        _isdetailled = True
        If Me.KryptonRadioButton2.Checked = True Then
            Me.txtCantFinal.Enabled = True
            Me.txtCantInicial.Enabled = True
            Me.txtCantInicial.Text = "1"
            Me.txtCantFinal.Text = "1"
            Me.txtTotal.Text = "1"
            Me.txtTotal.Enabled = False
        Else
            Me.txtCantFinal.Enabled = False
            Me.txtCantInicial.Enabled = False
            Me.txtCantInicial.Text = "1"
            Me.txtCantFinal.Text = "1"
            Me.txtTotal.Text = "1"
            Me.txtTotal.Enabled = True
        End If

    End Sub

    Private Sub KryptonRadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonRadioButton1.CheckedChanged
        _isdetailled = False
        If Me.KryptonRadioButton1.Checked = True Then
            Me.txtCantFinal.Enabled = False
            Me.txtCantInicial.Enabled = False
            Me.txtCantInicial.Text = "1"
            Me.txtCantFinal.Text = "1"
            Me.txtTotal.Text = "1"
            Me.txtTotal.Enabled = True
        Else
            Me.txtCantFinal.Enabled = True
            Me.txtCantInicial.Enabled = True
            Me.txtCantInicial.Text = "1"
            Me.txtCantFinal.Text = "1"
            Me.txtTotal.Text = "1"
            Me.txtTotal.Enabled = False
        End If

    End Sub

    Public ReadOnly Property pTotal() As Integer
        Get
            Return _total
        End Get
    End Property

    Public ReadOnly Property pInit() As Integer
        Get
            Return _init
        End Get
    End Property

    Private Sub KryptonHeaderGroup1_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonHeaderGroup1.Panel.Paint

    End Sub
End Class

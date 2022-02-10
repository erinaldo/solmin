Public Class frmConsultarTipoMoneda

#Region "Atributos"
    Private _TipoMoneda As String = ""

    Public Property TipoMoneda() As String
        Get
            Return _TipoMoneda
        End Get
        Set(ByVal value As String)
            _TipoMoneda = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Private Sub Seleccion()
        If (Me.rbDolares.Checked) Then
            Me._TipoMoneda = "DOL"
        Else
            If (Me.rbSoles.Checked) Then
                Me._TipoMoneda = "SOL"
            End If
        End If
    End Sub
#End Region

#Region "Eventos"

    Private Sub frmConsultarTipoMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbSoles.Checked = True
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Seleccion()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#End Region


 
End Class

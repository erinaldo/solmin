Imports System.Windows.Forms

Public Class CargarElementos

    Private Sub CargarElementos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Me.pgbProcesos.Step = 10
        Me.pgbProcesos.Maximum = 30
        Me.pgbProcesos.Style = ProgressBarStyle.Marquee
        Me.pgbProcesos.MarqueeAnimationSpeed = 60

    End Sub

    Public Property Texto() As String
        Get
            Return Me.lblTexto.Text
        End Get
        Set(ByVal value As String)
            Me.lblTexto.Text = value
        End Set
    End Property

End Class

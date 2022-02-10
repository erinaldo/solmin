Public Class frmmsgBox
    Public tiempoCierre As Integer = 0
    Public CerrarAutomatico As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CerrarAutomatico = True Then
            tiempoCierre = tiempoCierre - 1
        End If
        If tiempoCierre = 0 And CerrarAutomatico = True Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub frmmsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CerrarAutomatico = True Then
            Timer1.Enabled = True
            Timer1.Interval = 1000
            If tiempoCierre = 0 Then
                tiempoCierre = 3
            End If
        End If
       
    End Sub
End Class
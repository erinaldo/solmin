Imports SOLMIN_SC.Negocio
Public Class frmObservacionesParcial

    Private _pListaPreEmbarques As New List(Of Decimal)
    Public Property pListaPreEmbarques() As List(Of Decimal)
        Get
            Return _pListaPreEmbarques
        End Get
        Set(ByVal value As List(Of Decimal))
            _pListaPreEmbarques = value
        End Set
    End Property

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim msg As String = ""
        msg = ValidaIngreso()
        If (msg <> "") Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim oPreEmbarque As New clsPreEmbarque
        Try
            For Each item As Decimal In pListaPreEmbarques
                oPreEmbarque.Preembarque = item
                If txtObs.Text.Trim() <> String.Empty Then
                    oPreEmbarque.Actualiza_Observaciones(Format(dtpFecha.Value, "yyyyMMdd"), txtObs.Text.Trim())
                End If
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ValidaIngreso() As String
        Dim msg As String = ""
        txtObs.Text = txtObs.Text.Trim
        If (txtObs.Text.Length = 0) Then
            msg = "Debe ingresar la observación."
        End If
        Return msg
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class

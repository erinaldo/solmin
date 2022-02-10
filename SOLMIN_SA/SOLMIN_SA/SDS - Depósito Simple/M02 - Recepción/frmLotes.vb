Imports RANSA.TypeDef
Imports Ransa.NEGO
Imports Ransa.Utilitario
Imports System.Globalization
Public Class frmLotes
    Public infoLote As New beLoteDeMercaderia()
    Public QPendienteLote As Int64 = 0
    Public myDialogOK As Boolean = False
    Private Sub frmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPendiente.Text = QPendienteLote.ToString
        dtpFecProduccionMercaderia.Checked = False
        dtpFecVencimientoLote.Checked = False
    End Sub

    Private Sub txtRecPeso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try

            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13, 32
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim strmesaje As String = ""
            strmesaje = ValidarLote()
            If (strmesaje <> "") Then
                MessageBox.Show(strmesaje, "Lote", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If (OtenerDatosLote() = True) Then
                myDialogOK = True
                Me.Close()
            Else
                MessageBox.Show("El Lote no se adicionó", "Lote", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
     
    End Sub
    Private Function OtenerDatosLote() As Boolean
        Dim adicion As Boolean = False
        Try
            infoLote.PSCRTLTE = txtlotes.Text.Trim
            infoLote.PNQTRMC = Val(txtCantidad.Text.Trim)
            infoLote.PNFINGAL = HelpClass.CDate_a_Numero8Digitos(dtpFechaINgresoAlmacen.Value)

            If (dtpFecProduccionMercaderia.Checked = True) Then
                infoLote.PNFPRDMR = HelpClass.CDate_a_Numero8Digitos(dtpFecProduccionMercaderia.Value)

            End If
            If (dtpFecVencimientoLote.Checked = True) Then
                infoLote.PNFVNLTE = HelpClass.CDate_a_Numero8Digitos(dtpFecVencimientoLote.Value)

            End If
            adicion = True
        Catch ex As Exception
            adicion = False
        End Try
        Return adicion
    End Function

    Private Function ValidarLote() As String
        Dim strmensaje As String = ""
        txtlotes.Text = txtlotes.Text.Trim
        txtCantidad.Text = txtCantidad.Text.Trim
        If (txtlotes.Text.Trim = "") Then
            strmensaje = "Debe ingresar el Lote."
        End If
        If (txtCantidad.Text.Trim = "" Or Val(txtCantidad.Text.Trim) = 0) Then
            txtCantidad.Text = "0"
            strmensaje = strmensaje & Chr(13) & "La cantidad debe ser mayor a cero [0]."
        End If
        If (Val(txtCantidad.Text.Trim) > QPendienteLote) Then
            strmensaje = strmensaje & Chr(13) & "La cantidad debe ser menor o igual"
            strmensaje = strmensaje & Chr(13) & "a la cantidad Pendiente de Asignación de Lote (" & QPendienteLote & ")."
        End If
        Return strmensaje
    End Function
End Class

Imports RANSA.NEGO.SOLMIN.ReporteInventarioW

Public Class frmRepInventario
    Dim MyNumber(2) As String

    Private Sub bsaAlmacenListar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen01SDSW("" & txtZonaAlmacen.Tag, "" & "P", txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen01SDSW("" & txtZonaAlmacen.Tag, "" & "P", txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        'txtAlmacen.Text = ""
        '' Si modificamos el Almacén - debe limpiarse la Zona
        'txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen01SDSW("" & txtZonaAlmacen.Tag, "" & "P", txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonaSDSW(txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub

    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_ZonaSDSW(txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
            Case Keys.Delete
                txtZonaAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtZonaAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
        txtZonaAlmacen.Tag = ""
        txtAlmacen.Text = ""
    End Sub

    Private Sub txtZonaAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
        If txtZonaAlmacen.Text = "" Then
            txtZonaAlmacen.Tag = ""
        Else
            If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
                Call mfblnBuscar_ZonaSDSW(txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                If txtZonaAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Imprime_Reporte()
    End Sub
    Public Sub Imprime_Reporte()
        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            Dim objParametro As FiltrosReporteInventario = New FiltrosReporteInventario
            With objParametro
                .pstrAlmacen = txtAlmacen.Tag
                .pstrZona = txtZonaAlmacen.Tag
            End With
            Call mpObtenerReporteInventarioSDSW(objParametro)
        End If
    End Sub

End Class

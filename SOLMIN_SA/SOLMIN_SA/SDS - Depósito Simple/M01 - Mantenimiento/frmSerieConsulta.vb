Imports Ransa.TypeDef
Imports Ransa.NEGO
Public Class frmSerieConsulta
    Public obeMercaderia As New beMercaderia()

    Private Sub frmSerieConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgMercaderiaSerie.AutoGenerateColumns = False
            ListarSeriexOrdenServicio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListarSeriexOrdenServicio()
        Try
            Dim oblInventarioMercaderia As New blInventarioMercaderia()
            dgMercaderiaSerie.DataSource = oblInventarioMercaderia.ListarInventarioMercaderiaxSerie(obeMercaderia).Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim obeSerie As New Ransa.Controls.Serie.beSerie
            Dim ofrmMantenimientoSerie As New frmMantenimientoSerie()
            obeSerie.PNNORDSR = obeMercaderia.PNNORDSR
            obeSerie.PNCCLNT = obeMercaderia.PNCCLNT
            ofrmMantenimientoSerie.obeInfoserie = obeSerie
            ofrmMantenimientoSerie.ActualizarDatos = False
            If (ofrmMantenimientoSerie.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                ListarSeriexOrdenServicio()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If (dgMercaderiaSerie.Rows.Count = 0) Then
                MessageBox.Show("No hay Datos suficiente. Seleccione registro", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
           
            Dim strmensaje As String = "No puede realizar la operación." & Chr(13)
            strmensaje = strmensaje & "Una mercadería con esta serie ha sido despachada." & Chr(13)
            strmensaje = strmensaje & "Solo las series en stock o sin Guía de Salida se pueden modificar."
            If (dgMercaderiaSerie.CurrentRow.Cells("NGUISL").Value <> 0) Then
                MessageBox.Show(strmensaje, "Modificar Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim ofrmMantenimientoSerie As New frmMantenimientoSerie()
            ofrmMantenimientoSerie.obeInfoserie = ObtenerDatosSerie()
            ofrmMantenimientoSerie.ActualizarDatos = True
            If (ofrmMantenimientoSerie.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                ListarSeriexOrdenServicio()
            End If
             

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If (dgMercaderiaSerie.Rows.Count = 0) Then
                MessageBox.Show("No hay Datos suficiente. Seleccione registro", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim obrSerieMercaderia As New brSerieMercaderia()
            Dim retorno As Int32 = 0


            Dim strmensaje As String = "No puede realizar la operación." & Chr(13)
            strmensaje = strmensaje & " Una mercadería con esta serie ha sido despachada." & Chr(13)
            strmensaje = strmensaje & "Solo las series en stock o sin Guía de Salida se pueden eliminar."

            If (dgMercaderiaSerie.CurrentRow.Cells("NGUISL").Value <> 0) Then
                MessageBox.Show(strmensaje, "Modificar Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If (MessageBox.Show("Está seguro de eliminar el registro.", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
                retorno = obrSerieMercaderia.EliminarSerie(ObtenerDatosSerie())
                If (retorno = 1) Then
                    MessageBox.Show("Se ha eliminado satisfactoriamente.", "Eliminar Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListarSeriexOrdenServicio()
                Else
                    MessageBox.Show("No se pudo realizar la operación.", "Eliminar Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

         

        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerDatosSerie() As Ransa.Controls.Serie.beSerie
        Dim obeInfoSerieMercaderia As New Ransa.Controls.Serie.beSerie
        obeInfoSerieMercaderia.PNNORDSR = obeMercaderia.PNNORDSR
        obeInfoSerieMercaderia.PSCSRECL = ("" & dgMercaderiaSerie.CurrentRow.Cells("CSRECL").Value).ToString.Trim
        obeInfoSerieMercaderia.PSCSRECL_ANT = ("" & dgMercaderiaSerie.CurrentRow.Cells("CSRECL").Value).ToString.Trim
        obeInfoSerieMercaderia.PSTDSMDL = ("" & dgMercaderiaSerie.CurrentRow.Cells("TDSMDL").Value).ToString.Trim
        obeInfoSerieMercaderia.PSTOBSRV = ("" & dgMercaderiaSerie.CurrentRow.Cells("TOBSRV").Value).ToString.Trim
        obeInfoSerieMercaderia.PNCCLNT = obeMercaderia.PNCCLNT
        obeInfoSerieMercaderia.PNNCRPLL = Val(("" & dgMercaderiaSerie.CurrentRow.Cells("NCRPLL").Value).ToString.Trim)
        obeInfoSerieMercaderia.PSCULUSA = objSeguridadBN.pUsuario
        Return obeInfoSerieMercaderia

    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

  
End Class

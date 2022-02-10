Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmUsuarioProvision

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim obrGeneral As New clsClaseGeneral
        Dim obeGeneral As New ClaseGeneral
        With obeGeneral
            .USUARIO = Me.txtUsuario.Text
        End With
        dtgUsuarios.AutoGenerateColumns = False
        Me.dtgUsuarios.DataSource = obrGeneral.dtListarUsuarioReversionProvision(obeGeneral)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dtgUsuarios.CurrentCellAddress.Y = -1 Then Exit Sub
            If MsgBox("Está seguro que desea Eliminar este registro ?.", MsgBoxStyle.YesNo, "Mensaje De Información") = MsgBoxResult.Yes Then
                Dim obrGeneral As New clsClaseGeneral
                Dim obeGeneral As New ClaseGeneral
                With obeGeneral
                    .USUARIO = Me.dtgUsuarios.CurrentRow.Cells("CCMPRN").Value.ToString.Trim
                    .CULUSA = ConfigurationWizard.UserName
                End With
                If obrGeneral.intActualizarUsuarioReversionProvision(obeGeneral) = -1 Then
                    Ransa.Utilitario.HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
                btnBuscar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ofrmAgregar As New frmAgregarUsuario
        If ofrmAgregar.ShowDialog() Then
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub
End Class

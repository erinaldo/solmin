Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.NEGO.slnSOLMIN_SDS
Public Class frmTransportista

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            UcPaginacion.PageNumber = 1
            ActualizarListaTransportista()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ActualizarListaTransportista()
        Try
            dgChofer.DataSource = Nothing
            dgVehiculo.DataSource = Nothing
            Dim oblTransportista As New brTransportista
            Dim obeFiltroTransportista As New beFiltroTransportista
            With obeFiltroTransportista
                .CTRSPSTR = txtCodigo.Text.Trim
                .NRUCTSTR = txtruc.Text.Trim
                .TCMPTRSTR = txtDescripción.Text
                .PAGESIZE = Me.UcPaginacion.PageSize
                .PAGENUMBER = Me.UcPaginacion.PageNumber
            End With
            dgTRansportista.DataSource = oblTransportista.ListarTransportista(obeFiltroTransportista)
            If TryCast(dgTRansportista.DataSource, List(Of beTransportista)).Count > 0 Then
                UcPaginacion.PageCount = TryCast(dgTRansportista.DataSource, List(Of beTransportista)).Item(0).PageCount
            End If
            ActualizarDetalle()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub ActualizarDetalle()
        UcPaginacionVehiculo.PageNumber = 1
        UcPaginacionChofer.PageNumber = 1
        ActualizarListaChofer()
        ActualizarListaVehiculos()
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress, txtruc.KeyPress
        Try
            If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
                UcPaginacion.PageCount = 1
                ActualizarListaTransportista()
            End If
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

    Private Sub txtDescripción_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripción.KeyPress
        Try
            If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
                UcPaginacion.PageCount = 1
                ActualizarListaTransportista()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgTRansportista.AutoGenerateColumns = False
        dgChofer.AutoGenerateColumns = False
        dgVehiculo.AutoGenerateColumns = False
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            ActualizarListaTransportista()
        Catch ex As Exception
        End Try
    End Sub
 
    Private Sub ActualizarListaChofer()
        Try
            Dim obrChofer As New brChofer()
            Dim obeChoferFiltro As New beChoferFiltro
            With obeChoferFiltro
                .CTRSPSTR = ("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim
                .PAGESIZE = Me.UcPaginacionChofer.PageSize
                .PAGENUMBER = Me.UcPaginacionChofer.PageNumber
            End With
            dgChofer.DataSource = obrChofer.ListarChoferxTransportista(obeChoferFiltro)
            If TryCast(dgChofer.DataSource, List(Of beChofer)).Count > 0 Then
                UcPaginacionChofer.PageCount = TryCast(dgChofer.DataSource, List(Of beChofer)).Item(0).PageCount
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub ActualizarListaVehiculos()
        Try
            Dim obrCamion As New brCamion()
            Dim obeCamionFiltro As New beCamionFiltro
            With obeCamionFiltro
                .CTRSPSTR = ("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim
                .PAGESIZE = Me.UcPaginacionVehiculo.PageSize
                .PAGENUMBER = Me.UcPaginacionVehiculo.PageNumber
            End With
            dgVehiculo.DataSource = obrCamion.ListarCamionxTransportista(obeCamionFiltro)
            If TryCast(dgVehiculo.DataSource, List(Of beCamion)).Count > 0 Then
                UcPaginacionVehiculo.PageCount = TryCast(dgVehiculo.DataSource, List(Of beCamion)).Item(0).PageCount
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcPaginacionChofer_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionChofer.PageChanged
        Try
            ActualizarListaChofer()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcPaginacionVehiculo_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionVehiculo.PageChanged
        Try
            ActualizarListaVehiculos()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgTRansportista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTRansportista.CellClick
        Try
            ActualizarDetalle()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim ofrmMantenimientoTransportista As New frmMantenimientoTransportista()
            ofrmMantenimientoTransportista.ActualizarDatos = False
            If ofrmMantenimientoTransportista.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.ActualizarListaTransportista()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If (dgTRansportista.Rows.Count = 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If
            Dim ofrmMantenimientoTransportista As New frmMantenimientoTransportista()
            ofrmMantenimientoTransportista.ActualizarDatos = True
            Dim oInfoTransportista As New beTransportista()
            oInfoTransportista = dgTRansportista.CurrentRow.DataBoundItem
            oInfoTransportista.Trim()
            ofrmMantenimientoTransportista.obeInfoTransportista = oInfoTransportista
            If ofrmMantenimientoTransportista.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.ActualizarListaTransportista()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If (dgTRansportista.Rows.Count = 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If
            If (MessageBox.Show("Está seguro de eliminar el transportista", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
                Dim resultado As Int32 = 0
                Dim obeTransportista As New beTransportista()
                obeTransportista.PSNTRMNL = objSeguridadBN.pstrPCName
                obeTransportista.PSCULUSA = objSeguridadBN.pUsuario
                obeTransportista.PNCTRSP = Val(("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim)
                Dim obrTransportista As New brTransportista()
                resultado = obrTransportista.EliminarTransportista(obeTransportista)
                If (resultado = 1) Then
                    MessageBox.Show("Se ha eliminado satisfactoriamente el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ActualizarListaTransportista()
                Else
                    MessageBox.Show("No se pudo realizar la operación", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgTRansportista_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgTRansportista.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Up, Keys.Down, Keys.Enter
                    ActualizarDetalle()
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDetAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetAgregar.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabDetalle.SelectedTab.Name
            Select Case lstr_PestanaActiva
                Case "tabChofer"
                    Dim ofrmChofer As New frmChofer()
                    ofrmChofer.CTRSP = Val(("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim)
                    ofrmChofer.Brevete = ""
                    ofrmChofer.BuscarDatosDefault = False
                    If (ofrmChofer.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                        UcPaginacionChofer.PageNumber = 1
                        ActualizarListaChofer()
                    End If
                Case "tabVehiculo"
                    Dim ofrmCamion As New frmCamion()
                    ofrmCamion.CTRSP = Val(("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim)
                    ofrmCamion.Placa = ""
                    ofrmCamion.BuscarDatosDefault = False
                    If (ofrmCamion.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                        UcPaginacionVehiculo.PageNumber = 1
                        ActualizarListaVehiculos()
                    End If
                Case Else
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDetModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetModificar.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabDetalle.SelectedTab.Name
            Select Case lstr_PestanaActiva
                Case "tabChofer"
                    Dim ofrmChofer As New frmChofer()
                    ofrmChofer.CTRSP = Val(("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim)
                    ofrmChofer.Brevete = ("" & dgChofer.CurrentRow.Cells("PNNBRVCH").Value).ToString.Trim
                    ofrmChofer.BuscarDatosDefault = True
                    ofrmChofer.ShowDialog(Me)
                Case "tabVehiculo"
                    Dim ofrmCamion As New frmCamion()
                    ofrmCamion.CTRSP = Val(("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim)
                    ofrmCamion.Placa = ("" & dgVehiculo.CurrentRow.Cells("PSNPLCCM").Value).ToString.Trim
                    ofrmCamion.BuscarDatosDefault = True
                    ofrmCamion.ShowDialog(Me)
                Case Else
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDetEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetEliminar.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabDetalle.SelectedTab.Name
            Dim resultado As Int32 = 0
            Select Case lstr_PestanaActiva
                Case "tabChofer"
                    If (dgChofer.Rows.Count = 0) Then
                        MessageBox.Show("No hay información")
                        Exit Sub
                    End If
                    If (MessageBox.Show("Está seguro de eliminar el registro", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
                        Dim obeChofer As New beChofer()
                        Dim obrChofer As New brChofer()
                        obeChofer.PSCULUSA = objSeguridadBN.pUsuario
                        obeChofer.PSNTRMNL = objSeguridadBN.pstrPCName
                        obeChofer.PNCTRSP = Val(("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim)
                        obeChofer.PSNBRVCH = ("" & dgChofer.CurrentRow.Cells("PNNBRVCH").Value).ToString.Trim
                        resultado = obrChofer.EliminarChofer(obeChofer)
                        If (resultado = 1) Then
                            MessageBox.Show("El registro se ha eliminado", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UcPaginacionChofer.PageNumber = 1
                            ActualizarListaChofer()
                        Else
                            MessageBox.Show("No se pudo realizar la operación", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Case "tabVehiculo"
                    If (dgVehiculo.Rows.Count = 0) Then
                        MessageBox.Show("No hay información")
                        Exit Sub
                    End If
                    If (MessageBox.Show("Está seguro de eliminar el registro", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
                        Dim obeCamion As New beCamion()
                        Dim obrCamion As New brCamion
                        obeCamion.PSCULUSA = objSeguridadBN.pUsuario
                        obeCamion.PSNTRMNL = objSeguridadBN.pstrPCName
                        obeCamion.PNCTRSP = Val(("" & dgTRansportista.CurrentRow.Cells("PNCTRSP").Value).ToString.Trim)
                        obeCamion.PSNPLCCM = ("" & dgVehiculo.CurrentRow.Cells("PSNPLCCM").Value).ToString.Trim
                        resultado = obrCamion.EliminarCamion(obeCamion)
                        If (resultado = 1) Then
                            MessageBox.Show("El registro se ha eliminado", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UcPaginacionVehiculo.PageNumber = 1
                            ActualizarListaVehiculos()
                        Else
                            MessageBox.Show("No se pudo realizar la operación", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Case Else
            End Select
        Catch ex As Exception
        End Try
    End Sub
End Class

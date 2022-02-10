


'Eloy
Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
'Imports Ransa.TypeDef.Cliente
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.NEGO.slnSOLMIN_SDS

Public Class frmListaTransportista



#Region "Metodos y Funciones"

    Private Sub ActualizarListaTransportista()
        'Try
        dgChofer.DataSource = Nothing
        dgVehiculo.DataSource = Nothing
        dgAcoplado.DataSource = Nothing

        Dim oblTransportista As New brTransportista
        Dim obeTransportista As New beTransportista
        With obeTransportista
            .PSNRUCTR = txtruc.Text.Trim
            .PSTCMTRT = txtDescripción.Text.Trim
            .PageSize = Me.UcPaginacion.PageSize
            .PageNumber = Me.UcPaginacion.PageNumber
            .PSTRACTO = txtTracto.Text.Trim
            .PSACOPLADO = txtAcoplado.Text.Trim
            .PSBREVETE = txtBrevete.Text.Trim
        End With
        dgTRansportista.DataSource = oblTransportista.ListarTransportistaAT(obeTransportista)
        If TryCast(dgTRansportista.DataSource, List(Of beTransportista)).Count > 0 Then
            UcPaginacion.PageCount = TryCast(dgTRansportista.DataSource, List(Of beTransportista)).Item(0).PageCount
        End If
        ActualizarDetalle()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub ActualizarDetalle()
        UcPaginacionVehiculo.PageNumber = 1
        UcPaginacionChofer.PageNumber = 1
        UcPaginacionAcoplado.PageNumber = 1
        ActualizarListaChofer()
        ActualizarListaVehiculos()
        ActualizarListaAcoplado()
    End Sub

    Private Sub ActualizarListaChofer()
        'Try
        dgChofer.DataSource = Nothing

        If dgTRansportista.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim obrChofer As New brChofer()
        Dim obeChoferFiltro As New beChofer
        With obeChoferFiltro
            .PNCTRSPT = (dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim
            .PSCBRCNT = txtBreveteDet.Text.Trim
            .PageSize = Me.UcPaginacionChofer.PageSize
            .PageNumber = Me.UcPaginacionChofer.PageNumber
        End With
        dgChofer.DataSource = obrChofer.ListarChoferxTransportista_AT(obeChoferFiltro)
        If TryCast(dgChofer.DataSource, List(Of beChofer)).Count > 0 Then
            UcPaginacionChofer.PageCount = TryCast(dgChofer.DataSource, List(Of beChofer)).Item(0).PageCount
        End If
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub ActualizarListaVehiculos()
        'Try
        dgVehiculo.DataSource = Nothing
        If dgTRansportista.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim obrCamion As New brCamion
        Dim obeCamionFiltro As New beCamion
        With obeCamionFiltro
            .PNCTRSPT = (dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim
            .PSNPLCUN = txtTractoDet.Text.Trim
            .PageSize = Me.UcPaginacionVehiculo.PageSize
            .PageNumber = Me.UcPaginacionVehiculo.PageNumber
        End With
        dgVehiculo.DataSource = obrCamion.ListarUnidadxTransportistaAT(obeCamionFiltro)
        If TryCast(dgVehiculo.DataSource, List(Of beCamion)).Count > 0 Then
            UcPaginacionVehiculo.PageCount = TryCast(dgVehiculo.DataSource, List(Of beCamion)).Item(0).PageCount
        End If
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub ActualizarListaAcoplado()
        'Try
        dgAcoplado.DataSource = Nothing
        If dgTRansportista.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim obrAcoplado As New brAcoplado
        Dim obeAcopladoFiltro As New beAcoplado
        With obeAcopladoFiltro
            .PNCTRSPT = (dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim
            .PSNPLCAC = txtAcopladoDet.Text.Trim
            .PageSize = Me.UcPaginacionAcoplado.PageSize
            .PageNumber = Me.UcPaginacionAcoplado.PageNumber
        End With
        dgAcoplado.DataSource = obrAcoplado.ListarAcopladoxTransportistaAT(obeAcopladoFiltro)
        If TryCast(dgAcoplado.DataSource, List(Of beAcoplado)).Count > 0 Then
            UcPaginacionAcoplado.PageCount = TryCast(dgAcoplado.DataSource, List(Of beAcoplado)).Item(0).PageCount
        End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub ElimiarVehiculo()
        'Try
        If (dgVehiculo.Rows.Count = 0) Then
            MessageBox.Show("No hay información")
            Exit Sub
        End If
        If (MessageBox.Show("Está seguro de eliminar el Vehiculo", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
            Dim resultado As Int32 = 0
            Dim obeCamion As New beCamion
            obeCamion.PSNTRMNL = objSeguridadBN.pstrPCName
            obeCamion.PSCULUSA = objSeguridadBN.pUsuario
            obeCamion.PNCTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
            obeCamion.PSNPLCUN = (dgVehiculo.CurrentRow.Cells("PSNPLCUN").Value).ToString.Trim
            Dim obrCamion As New brCamion
            resultado = obrCamion.EliminarCamion_AT(obeCamion)
            If (resultado = 1) Then
                MessageBox.Show("Se ha eliminado satisfactoriamente el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ActualizarListaVehiculos()
            Else
                MessageBox.Show("No se pudo realizar la operación", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub EliminarChofer()
        'Try
        If (dgChofer.Rows.Count = 0) Then
            MessageBox.Show("No hay información")
            Exit Sub
        End If

        If (MessageBox.Show("Está seguro de eliminar el Chofer", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
            Dim resultado As Int32 = 0
            Dim obeChofer As New beChofer
            obeChofer.PSNTRMNL = objSeguridadBN.pstrPCName
            obeChofer.PSCULUSA = objSeguridadBN.pUsuario
            obeChofer.PNCTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
            obeChofer.PSCBRCNT = (dgChofer.CurrentRow.Cells("PSCBRCNT").Value).ToString.Trim
            Dim obrChofer As New brChofer
            resultado = obrChofer.EliminarChoferAT(obeChofer)
            If (resultado = 1) Then
                MessageBox.Show("Se ha eliminado satisfactoriamente el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ActualizarListaChofer()
            Else
                MessageBox.Show("No se pudo realizar la operación", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub EliminarAcoplado()
        'Try
        If (dgAcoplado.Rows.Count = 0) Then
            MessageBox.Show("No hay información")
            Exit Sub
        End If

        If (MessageBox.Show("Está seguro de eliminar el Acoplado", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
            Dim resultado As Int32 = 0
            Dim obeAcoplado As New beAcoplado
            obeAcoplado.PSNTRMNL = objSeguridadBN.pstrPCName
            obeAcoplado.PSCULUSA = objSeguridadBN.pUsuario
            obeAcoplado.PNCTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
            obeAcoplado.PSNPLCAC = (dgAcoplado.CurrentRow.Cells("PSNPLCAC_1").Value).ToString.Trim
            Dim obrAcoplado As New brAcoplado
            resultado = obrAcoplado.EliminarAcopladoAT(obeAcoplado)
            If (resultado = 1) Then
                MessageBox.Show("Se ha eliminado satisfactoriamente el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ActualizarListaAcoplado()
            Else
                MessageBox.Show("No se pudo realizar la operación", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            UcPaginacion.PageNumber = 1
            ActualizarListaTransportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmListaTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgTRansportista.AutoGenerateColumns = False
        Me.dgChofer.AutoGenerateColumns = False
        Me.dgVehiculo.AutoGenerateColumns = False
        Me.dgAcoplado.AutoGenerateColumns = False

        'If (Me.dgZonas.Rows.Count > 0) Then
        '    Me.ListarClientexRuta()
        'End If
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            ActualizarListaTransportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub dgTRansportista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTRansportista.CellClick
    '    Try
    '        ActualizarDetalle()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim ofrmMantTransportista As New frmMantTransportista
            ofrmMantTransportista.ActualizarDatos = False
            If ofrmMantTransportista.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.ActualizarListaTransportista()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try
            If (dgTRansportista.Rows.Count = 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If
            Dim ofrmMantTransportista As New frmMantTransportista()
            ofrmMantTransportista.ActualizarDatos = True
            Dim oInfoTransportista As New beTransportista()
            oInfoTransportista = dgTRansportista.CurrentRow.DataBoundItem
            oInfoTransportista.Trim()
            ofrmMantTransportista.obeInfoTransportista = oInfoTransportista
            If ofrmMantTransportista.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.ActualizarListaTransportista()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                obeTransportista.PNCTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
                Dim obrTransportista As New brTransportista()
                resultado = obrTransportista.EliminarTransportistaAT(obeTransportista)
                If (resultado = 1) Then
                    MessageBox.Show("Se ha eliminado satisfactoriamente el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ActualizarListaTransportista()
                Else
                    MessageBox.Show("No se pudo realizar la operación", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDetAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetAgregar.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabDet.SelectedTab.Name
            Select Case lstr_PestanaActiva
                Case "tabChofer"
                    Dim ofrmMantenimientoChofer As New frmMantenimientoChofer()
                    ofrmMantenimientoChofer.CTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
                    ofrmMantenimientoChofer.Brevete = ""
                    ofrmMantenimientoChofer.BuscarDatosDefault = False
                    If (ofrmMantenimientoChofer.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                        UcPaginacionChofer.PageNumber = 1
                        ActualizarListaChofer()
                    End If

                Case "tabVehiculo"
                    Dim ofrmMantenimientoUnidad As New frmMantenimientoUnidad()
                    ofrmMantenimientoUnidad.CTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
                    ofrmMantenimientoUnidad.Placa = ""
                    ofrmMantenimientoUnidad.BuscarDatosDefault = False
                    If (ofrmMantenimientoUnidad.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                        UcPaginacionVehiculo.PageNumber = 1
                        ActualizarListaVehiculos()
                    End If

                Case "TabAcoplados"
                    Dim ofrmMantenimientoAcoplado As New frmMantenimientoAcoplado()
                    ofrmMantenimientoAcoplado.CTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
                    ofrmMantenimientoAcoplado.Placa = ""
                    ofrmMantenimientoAcoplado.BuscarDatosDefault = False
                    If (ofrmMantenimientoAcoplado.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                        UcPaginacionAcoplado.PageNumber = 1
                        ActualizarListaAcoplado()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDetModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetModificar.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabDet.SelectedTab.Name
            Select Case lstr_PestanaActiva
                Case "tabChofer"
                    Dim ofrmMantenimientoChofer As New frmMantenimientoChofer()
                    ofrmMantenimientoChofer.CTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
                    ofrmMantenimientoChofer.Brevete = (dgChofer.CurrentRow.Cells("PSCBRCNT").Value).ToString.Trim
                    ofrmMantenimientoChofer.Direccion = (dgChofer.CurrentRow.Cells("PSTDRCC").Value).ToString.Trim
                    ofrmMantenimientoChofer.Nacionalidad = (dgChofer.CurrentRow.Cells("PSTNCION").Value).ToString.Trim
                    ofrmMantenimientoChofer.BuscarDatosDefault = True
                    ofrmMantenimientoChofer.ShowDialog(Me)
                    ActualizarListaChofer()

                Case "tabVehiculo"
                    Dim ofrmMantenimientoUnidad As New frmMantenimientoUnidad()
                    ofrmMantenimientoUnidad.CTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
                    ofrmMantenimientoUnidad.Placa = (dgVehiculo.CurrentRow.Cells("PSNPLCUN").Value).ToString.Trim
                    ofrmMantenimientoUnidad.BuscarDatosDefault = True
                    ofrmMantenimientoUnidad.ShowDialog(Me)
                    ActualizarListaVehiculos()

                Case "TabAcoplados"
                    Dim ofrmMantenimientoAcoplado As New frmMantenimientoAcoplado()
                    ofrmMantenimientoAcoplado.CTRSPT = Val((dgTRansportista.CurrentRow.Cells("CTRSPT").Value).ToString.Trim)
                    ofrmMantenimientoAcoplado.Placa = (dgAcoplado.CurrentRow.Cells("PSNPLCAC_1").Value).ToString.Trim
                    ofrmMantenimientoAcoplado.BuscarDatosDefault = True
                    ofrmMantenimientoAcoplado.ShowDialog(Me)
                    ActualizarListaAcoplado()
                Case Else
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnDetEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetEliminar.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabDet.SelectedTab.Name
            Select Case lstr_PestanaActiva
                Case "tabChofer"
                    EliminarChofer()


                Case "tabVehiculo"
                    ElimiarVehiculo()


                Case "TabAcoplados"
                    EliminarAcoplado()

                Case Else
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacionChofer_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionChofer.PageChanged
        Try
            ActualizarListaChofer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacionVehiculo_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionVehiculo.PageChanged
        Try
            ActualizarListaVehiculos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacionAcoplado_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionAcoplado.PageChanged
        Try
            ActualizarListaAcoplado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub dgTRansportista_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgTRansportista.KeyUp
    '    If Me.dgTRansportista.CurrentCellAddress.Y < 0 Then Exit Sub
    '    If Me.dgTRansportista.CurrentRow.Selected = False Then Exit Sub
    '    Select Case e.KeyCode
    '        Case Keys.Enter, Keys.Up, Keys.Down
    '            Me.dgTRansportista_CellClick(Nothing, Nothing)
    '    End Select

    'End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub


#End Region

    Private Sub dgTRansportista_SelectionChanged(sender As Object, e As EventArgs) Handles dgTRansportista.SelectionChanged
        Try
            ActualizarDetalle()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscarBrevete_Click(sender As Object, e As EventArgs) Handles btnBuscarBrevete.Click

        Try
          UcPaginacionChofer.PageNumber = 1
            ActualizarListaChofer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


       
       
    End Sub

    Private Sub btnBuscarTracto_Click(sender As Object, e As EventArgs) Handles btnBuscarTracto.Click
        Try
            UcPaginacionVehiculo.PageNumber = 1

            ActualizarListaVehiculos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      

    End Sub

    Private Sub btnBuscarAcoplado_Click(sender As Object, e As EventArgs) Handles btnBuscarAcoplado.Click
        Try
            UcPaginacionAcoplado.PageNumber = 1
            ActualizarListaAcoplado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub
End Class

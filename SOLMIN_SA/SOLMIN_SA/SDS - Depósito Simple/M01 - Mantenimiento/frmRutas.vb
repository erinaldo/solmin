Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRutas

#Region "Atributos"

#End Region

#Region "Metodos y Funciones"

    Private Sub ListarRutas()
        Try
            Dim oblMaestroRutas As New brMaestroRuta()
            dgZonas.DataSource = oblMaestroRutas.Listar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListarClientexRuta()
        Dim obeRutaTienda As New beRutaTienda
        Dim obrRutaTienda As New brRutaTienda
        With obeRutaTienda
            .PSCRUTAT = dgZonas.CurrentRow.Cells("CRUTAT").Value.ToString.Trim()
        End With
        Me.dgClientexZona.DataSource = obrRutaTienda.Listar(obeRutaTienda)



    End Sub

#End Region

#Region "Eventos"

    Private Sub frmRutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgZonas.AutoGenerateColumns = False
        Me.dgClientexZona.AutoGenerateColumns = False
        ListarRutas()
        If (Me.dgZonas.Rows.Count > 0) Then
            Me.ListarClientexRuta()
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim ofrmMantenimientoRutas As New frmMantenimientoRutas()
            ofrmMantenimientoRutas.BuscarDatosDefault = False
            If (ofrmMantenimientoRutas.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                ListarRutas()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Me.dgZonas.RowCount = 0 OrElse Me.dgZonas.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim ofrmMantenimientoRutas As New frmMantenimientoRutas()
            ofrmMantenimientoRutas.CRUTAT = dgZonas.CurrentRow.Cells("CRUTAT").Value.ToString.Trim()
            ofrmMantenimientoRutas.BuscarDatosDefault = True
            ofrmMantenimientoRutas.txtCodigoRuta.Enabled = False
            ofrmMantenimientoRutas.ShowDialog(Me)
            ListarRutas()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dgZonas.RowCount = 0 OrElse Me.dgZonas.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim resultado As Int32 = 0
            If (dgZonas.Rows.Count = 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If
            If (MessageBox.Show("Está seguro de eliminar el registro", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
                Dim obeMaestroRuta As New beMaestroRuta()
                Dim obrMaestroRuta As New brMaestroRuta()
                obeMaestroRuta.PSCRUTAT = dgZonas.CurrentRow.Cells("CRUTAT").Value.ToString.Trim()
                obeMaestroRuta.PSCULUSA = objSeguridadBN.pUsuario
                obeMaestroRuta.PSSESTRG = "*"
                resultado = obrMaestroRuta.Eliminar(obeMaestroRuta)
                If (resultado = 1) Then
                    MessageBox.Show("El registro se ha eliminado", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListarRutas()
                Else
                    MessageBox.Show("No se pudo realizar la operación", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarCZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCZ.Click
        Try
            If (Me.dgZonas.CurrentRow.Selected = False) Then
                MessageBox.Show("Seleccione Una Zona")
            End If
            Dim ofrmMantenimientoClienteRuta As New frmMantenimientoClienteRuta()
            With ofrmMantenimientoClienteRuta
                .CodRuta = dgZonas.CurrentRow.Cells("CRUTAT").Value.ToString.Trim()
                .BuscarDatosDefault = False
                If (ofrmMantenimientoClienteRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                    ListarClientexRuta()
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnModificarCZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCZ.Click
        Try
            If Me.dgClientexZona.RowCount = 0 OrElse Me.dgClientexZona.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.dgClientexZona.CurrentRow.Selected = False Then Exit Sub
            Dim ofrmMantenimientoClienteRuta As New frmMantenimientoClienteRuta()
            Dim objEntidad As New beRutaTienda
            With objEntidad
                .PNCCLNT = Me.dgClientexZona.CurrentRow.Cells("CCLNT").Value.ToString.Trim()
                .PNCPLNCL = Me.dgClientexZona.CurrentRow.Cells("CPLNCL").Value.ToString.Trim()
                .PNCPRVCL = Me.dgClientexZona.CurrentRow.Cells("CPRVCL").Value.ToString.Trim()
                .PNCPLCLP = Me.dgClientexZona.CurrentRow.Cells("CPLCLP").Value.ToString.Trim()
                .PSCRUTAT = Me.dgClientexZona.CurrentRow.Cells("CRUTAT_S").Value.ToString.Trim()
                .PNFULTAC = Me.dgClientexZona.CurrentRow.Cells("FULTAC_S").Value.ToString.Trim()
                .PNHULTAC = Me.dgClientexZona.CurrentRow.Cells("HULTAC_S").Value.ToString.Trim()
                .PSCULUSA = Me.dgClientexZona.CurrentRow.Cells("CULUSA_S").Value.ToString.Trim()
                .PSNTRMNL = Me.dgClientexZona.CurrentRow.Cells("NTRMNL_S").Value.ToString.Trim()
                .PSCUSCRT = Me.dgClientexZona.CurrentRow.Cells("CUSCRT_S").Value.ToString.Trim()
                .PNFCHCRT = Me.dgClientexZona.CurrentRow.Cells("FCHCRT_S").Value.ToString.Trim()
                .PNHRACRT = Me.dgClientexZona.CurrentRow.Cells("HRACRT_S").Value.ToString.Trim()
                .PSNTRMCR = Me.dgClientexZona.CurrentRow.Cells("NTRMCR_S").Value.ToString.Trim()
                .PNUPDATE_IDENT = Me.dgClientexZona.CurrentRow.Cells("UPDATE_IDENT_S").Value.ToString.Trim()
                .PSTCMPCL = Me.dgClientexZona.CurrentRow.Cells("TCMPCL").Value.ToString.Trim()
                .PSV_TCMPPL = Me.dgClientexZona.CurrentRow.Cells("V_TCMPPL").Value.ToString.Trim()
                .PSTPRVCL = Me.dgClientexZona.CurrentRow.Cells("TPRVCL").Value.ToString.Trim()
                .PSV_TDRPCP = Me.dgClientexZona.CurrentRow.Cells("V_TDRPCP").Value.ToString.Trim()

                .PNHRAINI_D = Me.dgClientexZona.CurrentRow.Cells("HRAINI").Value.ToString.Trim()
                .PNHRAFIN_D = Me.dgClientexZona.CurrentRow.Cells("HRAFIN").Value.ToString.Trim()
                .PSGPSLAT = Me.dgClientexZona.CurrentRow.Cells("GPSLAT").Value.ToString.Trim()
                .PSGPSLON = Me.dgClientexZona.CurrentRow.Cells("GPSLON").Value.ToString.Trim()
                .PNNCRRRT = Me.dgClientexZona.CurrentRow.Cells("NCRRRT").Value.ToString.Trim()
                .PSSESTRG = Me.dgClientexZona.CurrentRow.Cells("SESTRG_S").Value.ToString.Trim()

            End With
            ofrmMantenimientoClienteRuta.oEntidad = objEntidad
            ofrmMantenimientoClienteRuta.BuscarDatosDefault = True
            ofrmMantenimientoClienteRuta.txtCliente.Enabled = False
            ofrmMantenimientoClienteRuta.UcClienteTercero_xtF011.Enabled = False
            ofrmMantenimientoClienteRuta.UcPlantaDeEntrega_TxtF011.Enabled = False
            ofrmMantenimientoClienteRuta.rbtPropio.Enabled = False
            ofrmMantenimientoClienteRuta.rbtTercero.Enabled = False
            If (ofrmMantenimientoClienteRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                ListarClientexRuta()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgZonas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgZonas.CellClick
        Try
            If Me.dgZonas.CurrentCellAddress.Y < 0 Then Exit Sub
            Me.ListarClientexRuta()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgZonas_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgZonas.KeyUp
        If Me.dgZonas.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.dgZonas.CurrentRow.Selected = False Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Up, Keys.Down
                Me.dgZonas_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub btnEliminarCZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCZ.Click
        Try
            Dim resultado As Int32 = 0
            If (dgClientexZona.Rows.Count = 0 OrElse Me.dgClientexZona.CurrentCellAddress.Y < 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If
            If (MessageBox.Show("Está seguro de eliminar el registro", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
                Dim obebeRutaTienda As New beRutaTienda
                Dim obrRutaTienda As New brRutaTienda
                obebeRutaTienda.PNCCLNT = dgClientexZona.CurrentRow.Cells("CCLNT").Value.ToString.Trim()
                obebeRutaTienda.PNCPLNCL = dgClientexZona.CurrentRow.Cells("CPLNCL").Value.ToString.Trim()
                obebeRutaTienda.PNCPRVCL = dgClientexZona.CurrentRow.Cells("CPRVCL").Value.ToString.Trim()
                obebeRutaTienda.PNCPLCLP = dgClientexZona.CurrentRow.Cells("CPLCLP").Value.ToString.Trim()
                obebeRutaTienda.PSCULUSA = objSeguridadBN.pUsuario
                obebeRutaTienda.PSSESTRG = "*"
                resultado = obrRutaTienda.Eliminar(obebeRutaTienda)
                If (resultado = 1) Then
                    MessageBox.Show("El registro se ha eliminado", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListarClientexRuta()
                Else
                    MessageBox.Show("No se pudo realizar la operación", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgClientexZona_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgClientexZona.CellFormatting
        'Dim TipoTrade As String
        'If dgClientexZona.Columns(e.ColumnIndex).Name.Equals("TPRVCL") Then
        '    TipoTrade = (dgClientexZona.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        '    If TipoTrade <> "" Then
        '        e.CellStyle.BackColor = Color.LightSkyBlue
        '    Else
        '        Me.dgClientexZona.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "---"
        '    End If
        'End If

        'If dgClientexZona.Columns(e.ColumnIndex).Name.Equals("V_TDRPCP") Then
        '    TipoTrade = (dgClientexZona.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        '    If TipoTrade <> "" Then
        '        e.CellStyle.BackColor = Color.LightSkyBlue
        '    Else
        '        Me.dgClientexZona.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "---"
        '    End If
        'End If

        'If dgClientexZona.Columns(e.ColumnIndex).Name.Equals("V_TCMPPL") Then
        '    TipoTrade = (dgClientexZona.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        '    If TipoTrade <> "" Then
        '        e.CellStyle.BackColor = Color.LightYellow
        '    Else
        '        Me.dgClientexZona.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "---"
        '    End If
        'End If

    End Sub

    Private Sub dgClientexZona_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgClientexZona.CellContentClick
        Try
            If Me.dgClientexZona.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            If Me.dgClientexZona.CurrentRow.Selected = False Then Exit Sub
            Select Case Me.dgClientexZona.Columns(e.ColumnIndex).Name
                Case "SEGUIMIENTO"
                    Dim objGpsBrowser As New frmMapa
                    With objGpsBrowser
                        .Latitud = dgClientexZona.Item("GPSLAT", dgClientexZona.CurrentCellAddress.Y).Value.ToString.Trim()
                        .Longitud = dgClientexZona.Item("GPSLON", dgClientexZona.CurrentCellAddress.Y).Value.ToString.Trim()
                        .Cliente = dgClientexZona.Item("TCMPCL", dgClientexZona.CurrentCellAddress.Y).Value.ToString.Trim()
                        .Fecha = Date.Now
                        .Hora = Date.Now.ToString("HH:mm:ss")
                        .WindowState = FormWindowState.Maximized
                        .ShowForm(.Latitud, .Longitud, Me)
                    End With
            End Select
        Catch : End Try
    End Sub

#End Region

End Class

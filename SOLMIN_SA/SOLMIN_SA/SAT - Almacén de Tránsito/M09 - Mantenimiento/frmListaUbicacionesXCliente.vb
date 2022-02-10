'Imports Ransa.TypeDef.Cliente
Imports RANSA.TypeDef
Imports RANSA.NEGO
Imports Ransa.Utilitario

Public Class frmListaUbicacionesXCliente

    Private Sub frmListaUbicacionesXCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        UcCompania.Usuario = objSeguridadBN.pUsuario
        UcCompania.pActualizar()
        Validar_Usuario_Autoridado()
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Ingrese Cliente", MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim ofrmUbicaciones = New frmMantenimientoUbicacionesXCliente

            ofrmUbicaciones.PNCCLNT = txtCliente.pCodigo
            ofrmUbicaciones.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            If ofrmUbicaciones.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ListaUbicaciones()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Ingrese Cliente", MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim ofrmUbicaciones = New frmMantenimientoUbicacionesXCliente

            ofrmUbicaciones.PNCCLNT = txtCliente.pCodigo
            ofrmUbicaciones.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            ofrmUbicaciones.Ubicacion = ("" & Me.dgvUbicacionesXCliente.CurrentRow.Cells("TUBRFR").Value).ToString.Trim
            ofrmUbicaciones.Ubicacion_Anterior = ("" & Me.dgvUbicacionesXCliente.CurrentRow.Cells("TUBRFR").Value).ToString.Trim
            ofrmUbicaciones.Estado = ("" & Me.dgvUbicacionesXCliente.CurrentRow.Cells("SESTRG").Value).ToString.Trim

            ofrmUbicaciones.ActualizarDatos = True
            If ofrmUbicaciones.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ListaUbicaciones()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        ListaUbicaciones()
    End Sub

    Sub ListaUbicaciones()

        If txtCliente.pCodigo = 0 Then
            HelpClass.MsgBox("Ingrese Cliente", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim objNegocio As New brUbicacionesXCliente

        dgvUbicacionesXCliente.AutoGenerateColumns = False
        dgvUbicacionesXCliente.DataSource = objNegocio.Lista_UbicacionesXCliente(txtCliente.pCodigo, txtUbicacionReferencial.Text.ToString.Trim)

    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click

        Dim oDtgExcel As New DataGridView
        oDtgExcel = dgvUbicacionesXCliente
        For intCont As Integer = oDtgExcel.ColumnCount - 1 To 1 Step -1
            If Not oDtgExcel.Columns(intCont).Visible Then
                oDtgExcel.Columns.RemoveAt(intCont)
            End If
        Next

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("\n Reporte de Movimientos de Contenedores \n")
        strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Compañia :\n" & Me.UcCompania.CCMPN_Descripcion)
        HelpClass.ExportExcelConTitulos(oDtgExcel, "Reporte de Ubicaciones por Cliente", strlTitulo)

    End Sub

    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New brUsuario
        Dim objEntidad As New beUsuario

        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objSeguridadBN.pUsuario)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)

        If objEntidad.STSOP1 = "" Then
            btnModificar.Visible = False
        Else
            btnModificar.Visible = True
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objBLL As New brUbicacionesXCliente

        Dim respuesta As Int32 = 0
        If MessageBox.Show("¿Desea eliminar la Ubicación Referencial?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            respuesta = objBLL.Delete_UbicacionesXCliente(txtCliente.pCodigo, ("" & Me.dgvUbicacionesXCliente.CurrentRow.Cells("TUBRFR").Value).ToString.Trim)

            If respuesta = 0 Then
                MessageBox.Show("La ubicación se encuentra en uso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                ListaUbicaciones()
            End If

        Else
            Exit Sub

        End If

    End Sub
End Class
Imports Ransa.TypeDef.Cliente
Imports RANSA.TypeDef
Imports RANSA.NEGO
Imports Ransa.Utilitario

Public Class frmListaContenedor

#Region "Declaracion de variables"
    Private obrContenedor As New brContenedor
    Private obeContenedor As New beContenedor
#End Region

#Region "Procedimientos y Funciones"
    Private Sub ListaContenedores(Optional ByVal nProceso As Integer = 0)

        If txtCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese Cliente", "Listado de Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgContenedores.DataSource = Nothing
            Exit Sub
        End If
        obeContenedor = New beContenedor
        obeContenedor.PNCCLNT = txtCliente.pCodigo
        obeContenedor.PSCCMPN = UcCompania.CCMPN_CodigoCompania
        obeContenedor.PSCPRPCN = txtSigla.Text.Trim.ToUpper
        obeContenedor.PSNSRECN = txtNumero.Text.Trim.ToUpper
        obeContenedor.PSSESCN1 = IIf(cboEstado.SelectedIndex = 0, "T", IIf(cboEstado.SelectedIndex = 1, "1", "0"))
        dgContenedores.DataSource = Nothing
        dgContenedores.AutoGenerateColumns = False
        Dim olbeContenedores As New List(Of beContenedor)
        olbeContenedores = obrContenedor.ListarContenedor(obeContenedor)

        For intCont As Integer = olbeContenedores.Count - 1 To 1 Step -1
            If olbeContenedores.Item(intCont).PSCPRPCN = olbeContenedores.Item(intCont - 1).PSCPRPCN And olbeContenedores.Item(intCont).PSNSRECN = olbeContenedores.Item(intCont - 1).PSNSRECN Then
                olbeContenedores.RemoveAt(intCont)
            End If
        Next
        Me.dgContenedores.DataSource = olbeContenedores

    End Sub

#End Region

#Region "Eventos de Control"

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmListaContenedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        UcCompania.Usuario = objSeguridadBN.pUsuario
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Ingrese Cliente", MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim ofrmContenedor = New frmMantenimientoContenedor
            ofrmContenedor.PNCCLNT = txtCliente.pCodigo
            ofrmContenedor.PSCCMPN = UcCompania.CCMPN_CodigoCompania

            ofrmContenedor.Cliente = txtCliente.pRazonSocial
            ofrmContenedor.Compania = UcCompania.CCMPN_Descripcion
            ofrmContenedor.ShowDialog()
            If ofrmContenedor.Grabar = True Then ListaContenedores()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        ListaContenedores(1)

    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgContenedores.Rows.Count > 0 Then
            ListaContenedores()
        End If
    End Sub

    Private Function fnValidarInformacion() As String
        Dim Mensaje As String = String.Empty
        If txtCliente.pCodigo = 0 Then
            Mensaje &= "Falta Seleccionar un Cliente. " & System.Environment.NewLine
        End If

        Return Mensaje
    End Function

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try

            If (dgContenedores.Rows.Count = 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If

            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim ofrmContenedor = New frmMantenimientoContenedor
            obeContenedor = New beContenedor

            obeContenedor = dgContenedores.CurrentRow.DataBoundItem


            ofrmContenedor.PubContenedor = obeContenedor
            ofrmContenedor.ActualizarDatos = True
            ofrmContenedor.PNCCLNT = txtCliente.pCodigo
            ofrmContenedor.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            ofrmContenedor.Cliente = txtCliente.pRazonSocial
            ofrmContenedor.Compania = UcCompania.CCMPN_Descripcion
            ofrmContenedor.ShowDialog()

            If ofrmContenedor.Grabar = True Then ListaContenedores()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If (dgContenedores.Rows.Count = 0) Then
            MessageBox.Show("No hay información")
            Exit Sub
        End If
        obeContenedor = New beContenedor
        obeContenedor = dgContenedores.CurrentRow.DataBoundItem
        obeContenedor.PSSESTRG = "*"

        If obrContenedor.ValidaMovimiento(obeContenedor) > 0 Then
            HelpClass.MsgBox("No se puede eliminar este contenedor porque tiene movimientos", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If (MessageBox.Show("Esta seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then


            If obrContenedor.ActualizarContenedor(obeContenedor) = 1 Then
                HelpClass.MsgBox("Se eliminó el registro satisfactoriamente", MessageBoxIcon.Information)
                ListaContenedores()

            Else
                HelpClass.MsgBox("Hubo un error, Comunique a Sistemas", MessageBoxIcon.Error)
            End If
        End If

    End Sub
#End Region

   
    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click


        Dim oDtgExcel As New DataGridView
        oDtgExcel = dgContenedores
        For intCont As Integer = oDtgExcel.ColumnCount - 1 To 1 Step -1
            If Not oDtgExcel.Columns(intCont).Visible Then
                oDtgExcel.Columns.RemoveAt(intCont)
            End If
        Next

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("\n Reporte de Movimientos de Contenedores \n")
        strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Compañia :\n" & Me.UcCompania.CCMPN_Descripcion)
        HelpClass.ExportExcelConTitulos(oDtgExcel, "Reporte de Movimientos de Contenedores", strlTitulo)
    End Sub
End Class

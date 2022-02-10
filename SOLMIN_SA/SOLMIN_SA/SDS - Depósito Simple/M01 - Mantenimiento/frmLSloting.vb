Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports ransa.TYPEDEF.Cliente
Imports Ransa.Utilitario

Public Class frmLSloting


#Region "Atributos"

#End Region

#Region "Variables"

#End Region

#Region "Metodos y Funciones"

#End Region

#Region "Eventos"

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If String.IsNullOrEmpty(txtCliente.pCodigo) = False And String.IsNullOrEmpty(txtTipoAlmacen.Tag) = False And String.IsNullOrEmpty(txtAlmacen.Tag) = False Then
            Dim oBR As New brSugerenciaMercaderia()
            dgSloting.AutoGenerateColumns = False
            Dim lis As List(Of beSugerenciaMercaderia) = oBR.Listar(txtCliente.pCodigo, txtTipoAlmacen.Tag, txtAlmacen.Tag, UcPaginacion)
            dgSloting.DataSource = lis
        End If
    End Sub

    Private Sub frmLSloting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("MANSDS_ClienteCodigo", GetType(System.String)), intTemp)
        If intTemp <> 0 Then
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
        End If
        txtCliente.pUsuario = objSeguridadBN.pUsuario
        objAppConfig = Nothing
        UCDataGridView.Alinear_Columnas_Grilla(Me.dgSloting)
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        txtAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click
        Dim frm As New frmESloting
        Dim oBE As New beSugerenciaMercaderia
        oBE.PNCCLNT = txtCliente.pCodigo
        oBE.PSCTPALM = txtTipoAlmacen.Tag
        oBE.PSTIPO = txtTipoAlmacen.Text
        oBE.PSCALMC = txtAlmacen.Tag
        oBE.PSALMACEN = txtAlmacen.Text
        frm.Tag = oBE
        frm.IsNuevo = True
        frm.ShowDialog()
        btnActualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        If dgSloting.CurrentRow IsNot Nothing Then
            Dim frm As New frmESloting
            frm.IsNuevo = False
            frm.Tag = dgSloting.CurrentRow.DataBoundItem
            frm.ShowDialog()
            btnActualizar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        If dgSloting.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Esta seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim obr As New brSugerenciaMercaderia()
            obr.Delete(CType(dgSloting.CurrentRow.DataBoundItem, beSugerenciaMercaderia))
            MessageBox.Show("El registro se elimino satisfactiroamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnActualizar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        If String.IsNullOrEmpty(txtCliente.pCodigo) = False And String.IsNullOrEmpty(txtTipoAlmacen.Tag) = False And String.IsNullOrEmpty(txtAlmacen.Tag) = False Then
            Dim rpt As New rptListadoSloting
            Dim oBR As New brSugerenciaMercaderia()
            rpt.SetDataSource(oBR.ListarReporte(txtCliente.pCodigo, txtTipoAlmacen.Tag, txtAlmacen.Tag))
            Dim frmRPT As New frmVisorRPT(rpt)
            frmRPT.Show()
        End If
    End Sub

    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Close()
    End Sub

    Private Sub dgSloting_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgSloting.ColumnHeaderMouseClick
        If dgSloting.RowCount = 0 Then Exit Sub
        Dim olbeSugerenciaMercaderia As New List(Of beSugerenciaMercaderia)
        olbeSugerenciaMercaderia = dgSloting.DataSource
        Dim oucOrdena As UCOrdena(Of beSugerenciaMercaderia)
        oucOrdena = New UCOrdena(Of beSugerenciaMercaderia)(Me.dgSloting.Columns(e.ColumnIndex).Name, UCOrdena(Of beSugerenciaMercaderia).TipoOrdenacion.Ascendente)
        olbeSugerenciaMercaderia.Sort(oucOrdena)
        Me.dgSloting.DataSource = olbeSugerenciaMercaderia
        Me.dgSloting.Refresh()
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        btnActualizar_Click(Nothing, Nothing)
    End Sub

#End Region

End Class

Imports Ransa.DAO.Proveedor
Imports Ransa.TypeDef.Proveedor
Public Class ucProveedor_FProveedor
    Private oInfoProveedor As New InfoProveedor()
    Public oFiltroProveedor As New TD_Qry_Proveedor()
    Private paginaInicial As Int32 = 0
    Public ReadOnly Property pSeleccion() As InfoProveedor
        Get
            Return oInfoProveedor
        End Get
    End Property
    Private Sub ucProveedor_FProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If (IsNumeric(oFiltroProveedor.PSCPRVCLSTR.Trim)) Then
                If IsNumeric(oFiltroProveedor.PSCPRVCLSTR.Trim) Then
                    If (oFiltroProveedor.PSCPRVCLSTR.Trim.Length <= 6) Then
                        txtCodigo.Text = oFiltroProveedor.PSCPRVCLSTR.Trim
                    End If
                End If
                If IsNumeric(oFiltroProveedor.PSNRUCPRSTR.Trim) Then
                    If (oFiltroProveedor.PSNRUCPRSTR.Trim > 6) Then
                        txtRUC.Text = oFiltroProveedor.PSNRUCPRSTR.Trim
                    End If
                End If
            Else
                txtDescripcion.Text = oFiltroProveedor.PSTPRVCL.Trim
            End If
            dgProveedor.AutoGenerateColumns = False
            Me.UcPaginacion.PageNumber = 1
            pCargarInformacion()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pCargarInformacion()
        Try
            dgProveedor.DataSource = Nothing
            Dim odaProveedor As New cProveedor
            Dim obeproveedor As New beProveedor
            With obeproveedor

                .PSCPRVCLSTR = txtCodigo.Text.Trim
                .PSNRUCPRSTR = txtRUC.Text.Trim
                .PSTPRVCL = txtDescripcion.Text.Trim
                .PSBUSQUEDA = ""
                .PageSize = Me.UcPaginacion.PageSize
                .PageNumber = Me.UcPaginacion.PageNumber
            End With
            dgProveedor.DataSource = odaProveedor.ListaProveedoresPaginado(obeproveedor)
            If TryCast(dgProveedor.DataSource, List(Of beProveedor)).Count > 0 Then
                UcPaginacion.PageCount = TryCast(dgProveedor.DataSource, List(Of beProveedor)).Item(0).PageCount
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            pCargarInformacion()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        oInfoProveedor.clear()
        Me.Close()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If chkMientrasEscribe.Checked Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtDescripcion.SelectAll()
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        If chkMientrasEscribe.Checked Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtRUC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRUC.GotFocus
        txtRUC.SelectAll()
    End Sub

    Private Sub txtRUC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.TextChanged
        If chkMientrasEscribe.Checked Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub dgProveedor_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProveedor.CellDoubleClick
        Try
            Dim index As Int32 = dgProveedor.CurrentCellAddress.Y
            oInfoProveedor.PNCPRVCL = Val(("" & dgProveedor.Item("PNCPRVCL", index).Value).ToString.Trim)
            oInfoProveedor.PNNRUCPR = Val(("" & dgProveedor.Item("PNNRUCPR", index).Value).ToString.Trim)
            oInfoProveedor.PSTPRVCL = ("" & dgProveedor.Item("PSTPRVCL", index).Value).ToString.Trim
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class

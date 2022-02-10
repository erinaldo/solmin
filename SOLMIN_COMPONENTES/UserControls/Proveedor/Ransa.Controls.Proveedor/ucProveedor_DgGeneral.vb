'Imports Ransa.DAO.Proveedor
'Imports Ransa.TypeDef.Proveedor
Public Class ucProveedor_DgGeneral
    Public pNRUCPRSTR As String = ""
    Public pUsuario As String = ""
    Public pPSTPRVCL As String = ""
    Private _infoProveedor As New beProveedor
    Private _Count As Int32 = 0

    Public ReadOnly Property Count() As Int32
        Get
            Return _Count
        End Get
    End Property

    Public Property infoProveedor() As beProveedor
        Get
            Return _infoProveedor
        End Get
        Set(ByVal value As beProveedor)
            _infoProveedor = value
        End Set
    End Property
    Private IniciarPagina As Boolean = True
    Public Event eventChange()
    Public Sub DataSourceNothing(ByVal isnothing As Boolean)
        If (isnothing = True) Then         
            pNRUCPRSTR = ""
            pUsuario = ""
            pPSTPRVCL = ""
            dgProveedor.DataSource = Nothing
        End If

    End Sub
    Public Sub ActualizarListaProveedor()
        Try
            dgProveedor.AutoGenerateColumns = False
            dgProveedor.DataSource = Nothing
            Dim oblProveedor As New cProveedor
            Dim obeproveedor As New beProveedor
            With obeproveedor
                .PSNRUCPRSTR = pNRUCPRSTR.Trim.ToUpper
                .PSTPRVCL = pPSTPRVCL.Trim.ToUpper
                .PageSize = Me.UcPaginacion.PageSize
                If (IniciarPagina) Then
                    Me.UcPaginacion.PageNumber = 1
                End If
                .PageNumber = Me.UcPaginacion.PageNumber
            End With
            dgProveedor.DataSource = oblProveedor.ListarProveedorGeneral(obeproveedor)
            If TryCast(dgProveedor.DataSource, List(Of beProveedor)).Count > 0 Then
                UcPaginacion.PageCount = TryCast(dgProveedor.DataSource, List(Of beProveedor)).Item(0).PageCount
            Else
                UcPaginacion.PageCount = 1
            End If

            If (dgProveedor.Rows.Count > 0) Then
                infoProveedor = dgProveedor.CurrentRow.DataBoundItem
                infoProveedor.Trim()
            Else
                infoProveedor = Nothing
            End If
            _Count = dgProveedor.Rows.Count
            IniciarPagina = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click
        Try          
            Dim ofrm As New frmProveedor_MDatos
            ofrm.IsNuevo = True
            ofrm.pUsuario = pUsuario
            ofrm.ShowDialog(Me)
            If (ofrm.myDialogResult = True) Then
                ActualizarListaProveedor()
                RaiseEvent eventChange()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        Try
            Dim ofrm As New frmProveedor_MDatos
            ofrm.IsNuevo = False
            ofrm.Tag = dgProveedor.CurrentRow.DataBoundItem
            ofrm.pUsuario = pUsuario
            ofrm.ShowDialog(Me)
            If (ofrm.myDialogResult = True) Then
                ActualizarListaProveedor()
                RaiseEvent eventChange()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            Dim retorno As Int32 = 0
            If dgProveedor.CurrentRow Is Nothing Then Exit Sub
            'Dim oDaProveedor As New Ransa.DAO.Proveedor.cProveedor
            'Dim oProveedor As New Ransa.TypeDef.Proveedor.beProveedor
            Dim oDaProveedor As New Proveedor.cProveedor
            Dim oProveedor As New Proveedor.beProveedor
            oProveedor.PNCPRVCL = CType(dgProveedor.CurrentRow.DataBoundItem, beProveedor).PNCPRVCL
            oProveedor.PSCULUSA = pUsuario
            If MessageBox.Show("Está seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                retorno = oDaProveedor.EliminarProveedorGeneral(oProveedor)
                If (retorno = 1) Then
                    MessageBox.Show("El registro se eliminó satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ActualizarListaProveedor()
                    RaiseEvent eventChange()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            IniciarPagina = False
            ActualizarListaProveedor()
            infoProveedor = dgProveedor.CurrentRow.DataBoundItem
            infoProveedor.Trim()
            RaiseEvent eventChange()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgProveedor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProveedor.CellClick
        Try
            infoProveedor = dgProveedor.CurrentRow.DataBoundItem
            infoProveedor.Trim()
            RaiseEvent eventChange()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgProveedor_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgProveedor.KeyUp
        Try
            infoProveedor = dgProveedor.CurrentRow.DataBoundItem
            infoProveedor.Trim()
            RaiseEvent eventChange()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            Dim ofrmCargaMasivaProveedor As New frmCargaMasivaProveedor
            ofrmCargaMasivaProveedor.ShowDialog()
            If ofrmCargaMasivaProveedor.pDialog = True Then
                ActualizarListaProveedor()
                RaiseEvent eventChange()
            End If
           

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

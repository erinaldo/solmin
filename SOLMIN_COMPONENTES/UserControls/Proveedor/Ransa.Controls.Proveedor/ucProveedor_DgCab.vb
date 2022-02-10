Imports Ransa.DAO.Proveedor
Imports Ransa.TypeDef.Proveedor
Public Class ucProveedor_DgCab
    Public pCCLNT As Decimal = 0
    Public pNRUCPRSTR As String = ""
    Public pUsuario As String = ""
    Public pPSTPRVCL As String = ""
    Public pPSSTPORL As String = ""
    Private _infoProveedor As New beProveedor
    Private _Count As Int32 = 0
  Private _MostrarTituloOpcion1 As Boolean = False
  Public Event Buscar()
    Public Property pMostrarTituloOpcion1() As Boolean
        Get
            Return _MostrarTituloOpcion1
        End Get
        Set(ByVal value As Boolean)
            _MostrarTituloOpcion1 = value
        End Set
  End Property

  Public Property pMostrarBotonBuscar() As Boolean
    Get
      Return btnBuscar.Visible
    End Get
    Set(ByVal value As Boolean)
      btnBuscar.Visible = value
    End Set
  End Property


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
            pCCLNT = 0
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
            If (pCCLNT = 0) Then Exit Sub
            Dim oblProveedor As New cProveedor
            Dim obeproveedor As New beProveedor
            With obeproveedor
                .PNCCLNT = pCCLNT
                .PSNRUCPRSTR = pNRUCPRSTR.Trim.ToUpper
                .PSTPRVCL = pPSTPRVCL.Trim.ToUpper
                .PSSTPORL = pPSSTPORL.Trim
                .PageSize = Me.UcPaginacion.PageSize
                If (IniciarPagina) Then
                    Me.UcPaginacion.PageNumber = 1
                End If
                .PageNumber = Me.UcPaginacion.PageNumber
            End With
            dgProveedor.DataSource = oblProveedor.ListarClienteTercero_x_Cliente_General(obeproveedor)
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
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If (pCCLNT = 0) Then
                Exit Sub
            Else
                Dim ofrmRelacionClienteProveedor As New frmRelacionClienteProveedor()
                ofrmRelacionClienteProveedor.pMostrarTituloOpcion1 = pMostrarTituloOpcion1
                ofrmRelacionClienteProveedor.pCCLNT = pCCLNT
                ofrmRelacionClienteProveedor.pUsuario = pUsuario
                ofrmRelacionClienteProveedor.ShowDialog(Me)
                ActualizarListaProveedor()
                RaiseEvent eventChange()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim oblProveedor As New cProveedor
            Dim resultado As Int32 = 0
            Dim obeProveedor As New beProveedor()
            If (dgProveedor.Rows.Count = 0) Then
                Exit Sub
            End If
            If (MessageBox.Show("Está seguro de eliminar la relación", "Eliminar Relación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
                obeProveedor.PNCCLNT = Me.dgProveedor.CurrentRow.Cells("PNCCLNT").Value
                obeProveedor.PNCPRVCL = Me.dgProveedor.CurrentRow.Cells("PNCPRVCL").Value
                obeProveedor.PSSTPORL = Me.dgProveedor.CurrentRow.Cells("PSSTPORL").Value
                obeProveedor.PSCULUSA = pUsuario
                resultado = oblProveedor.EliminarRelacionTercero_x_Cliente(obeProveedor)
                If (resultado = 1) Then
                    MessageBox.Show("La operación se realizó satisfactoriamente", "Eliminar Relación", MessageBoxButtons.OK)
                    ActualizarListaProveedor()
                    RaiseEvent eventChange()
                Else
                    MessageBox.Show("La operación no se pudo realizar", "Eliminar Relación", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception

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
        End Try
    End Sub

    Private Sub dgProveedor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProveedor.CellClick
        Try
            infoProveedor = dgProveedor.CurrentRow.DataBoundItem
            infoProveedor.Trim()
            RaiseEvent eventChange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgProveedor_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgProveedor.KeyUp
        Try
            infoProveedor = dgProveedor.CurrentRow.DataBoundItem
            infoProveedor.Trim()
            RaiseEvent eventChange()
        Catch ex As Exception
        End Try
    End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    RaiseEvent Buscar()
  End Sub
End Class

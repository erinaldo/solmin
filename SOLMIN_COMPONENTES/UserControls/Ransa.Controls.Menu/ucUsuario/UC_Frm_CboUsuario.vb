
Imports System.Windows.Forms

Public Class UC_Frm_CboUsuario
  Private oInfoCboUsuario As New beUsuario_InfoUC
  Public oFiltroCboUsuario As New beUsuario_InfoUC
  Private paginaInicial As Int32 = 0
  Private oCboUsuario_BE As New beUsuarioUC
  Public oListInicialCboUsuario As New List(Of beUsuarioUC)
  Public ReadOnly Property pSeleccionUsuario() As beUsuario_InfoUC
    Get
      Return oInfoCboUsuario
    End Get
  End Property

  Private Sub uc_Frm_CboUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dgvUsuario.AutoGenerateColumns = False
      dgvUsuario.DataSource = Nothing
      If (oListInicialCboUsuario.Count <> 0) Then
        dgvUsuario.DataSource = oListInicialCboUsuario
        If TryCast(dgvUsuario.DataSource, List(Of beUsuarioUC)).Count > 0 Then
          UcPaginacion.PageCount = TryCast(dgvUsuario.DataSource, List(Of beUsuarioUC)).Item(0).PageCount
        End If
      Else
        pCargarInformacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub pCargarInformacion()

    dgvUsuario.DataSource = Nothing
    Dim oLisCboUsuario As New List(Of beUsuarioUC)
    Dim oclsCboUsuario As New ucUsuario_DAL
    Dim obeQueryCboUsuario As New beUsuario_InfoUC
    With obeQueryCboUsuario

      .PSMMCUSR = txtCodigo.Text.Trim.ToUpper
      .PSMMNUSR = txtDescripcion.Text.Trim.ToString
      .PageSize = Me.UcPaginacion.PageSize
      .PageNumber = Me.UcPaginacion.PageNumber

    End With
    oLisCboUsuario = oclsCboUsuario.ListarUsuario(obeQueryCboUsuario)
    dgvUsuario.DataSource = oLisCboUsuario
    If TryCast(dgvUsuario.DataSource, List(Of beUsuarioUC)).Count > 0 Then
      UcPaginacion.PageCount = TryCast(dgvUsuario.DataSource, List(Of beUsuarioUC)).Item(0).PageCount
    End If
  End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
    Try
      pCargarInformacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub dgvUsuario_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuario.CellDoubleClick
    Try

      Dim index As Int32 = dgvUsuario.CurrentCellAddress.Y
      oCboUsuario_BE = dgvUsuario.Rows(index).DataBoundItem
      oInfoCboUsuario.PSMMCUSR = oCboUsuario_BE.PSMMCUSR
      oInfoCboUsuario.PSMMNUSR = oCboUsuario_BE.PSMMNUSR
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    Try
      If e.KeyCode = Keys.Enter Then
        Me.UcPaginacion.PageNumber = 1
        Call pCargarInformacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown, txtCodigo.KeyDown
    Try
      If e.KeyCode = Keys.Enter Then
        Me.UcPaginacion.PageNumber = 1
        Call pCargarInformacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      Call pCargarInformacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodig_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Try
      e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class




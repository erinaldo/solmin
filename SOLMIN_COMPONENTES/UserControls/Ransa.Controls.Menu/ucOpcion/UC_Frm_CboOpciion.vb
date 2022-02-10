Imports System.Windows.Forms


Public Class UC_Frm_CboOpciion
  Private oInfoCboOpcion As New beOpcion_InfoUC
  Public oFiltroCboOpcion As New beOpcion_InfoUC
  Private paginaInicial As Int32 = 0
  Private oCboOpcion_BE As New beOpcionUC
  Public oListInicialCboOpcion As New List(Of beOpcionUC)
  Public ReadOnly Property pSeleccionOpcion() As beOpcion_InfoUC
    Get
      Return oInfoCboOpcion
    End Get
  End Property

  Private Sub uc_Frm_CboOpcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dgvOpcion.AutoGenerateColumns = False
      dgvOpcion.DataSource = Nothing
      If (oListInicialCboOpcion.Count <> 0) Then
        dgvOpcion.DataSource = oListInicialCboOpcion
        If TryCast(dgvOpcion.DataSource, List(Of beOpcionUC)).Count > 0 Then
          UcPaginacion.PageCount = TryCast(dgvOpcion.DataSource, List(Of beOpcionUC)).Item(0).PageCount
        End If
      Else
        pCargarInformacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub pCargarInformacion()

    dgvOpcion.DataSource = Nothing
    Dim oLisCboOpcion As New List(Of beOpcionUC)
    Dim oclsCboOpcion As New ucOpcion_DAL
    Dim obeQueryCboOpcion As New beOpcion_InfoUC
    With obeQueryCboOpcion
      .PSMMCAPL = oInfoCboOpcion.PSMMCAPL
      .PSMMCMNU = oInfoCboOpcion.PSMMCMNU

      .PNMMCOPC = Val(txtCodig.Text)
      .PSMMDOPC = txtDescripcion.Text
      .PageSize = Me.UcPaginacion.PageSize
      .PageNumber = Me.UcPaginacion.PageNumber

    End With
    oLisCboOpcion = oclsCboOpcion.ListarOpcion(obeQueryCboOpcion)
    dgvOpcion.DataSource = oLisCboOpcion
    If TryCast(dgvOpcion.DataSource, List(Of beOpcionUC)).Count > 0 Then
      UcPaginacion.PageCount = TryCast(dgvOpcion.DataSource, List(Of beOpcionUC)).Item(0).PageCount
    End If
  End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
    Try
      pCargarInformacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub dgvOpcion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOpcion.CellDoubleClick
    Try

      Dim index As Int32 = dgvOpcion.CurrentCellAddress.Y
      oCboOpcion_BE = dgvOpcion.Rows(index).DataBoundItem
      oInfoCboOpcion.PSMMCAPL = oCboOpcion_BE.PSMMCAPL
      oInfoCboOpcion.PSMMCMNU = oCboOpcion_BE.PSMMCMNU
      oInfoCboOpcion.PNMMCOPC = oCboOpcion_BE.PNMMCOPC
      oInfoCboOpcion.PSMMDOPC = oCboOpcion_BE.PSMMDOPC
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodig.KeyDown

    Try
      If e.KeyCode = Keys.Enter Then
        Me.UcPaginacion.PageNumber = 1
        Call pCargarInformacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
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

  Private Sub txtCodig_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodig.KeyPress
    Try
      e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Try
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class

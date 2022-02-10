Imports System.Windows.Forms
Public Class UC_Frm_CboMenu
  Private oInfoCboMenu As New beMenu_InfoUC
  Public oFiltroCboMenu As New beMenu_InfoUC
  Private paginaInicial As Int32 = 0
  Private oCboMenu_BE As New beMenuUC
  Public oListInicialCboMenu As New List(Of beMenuUC)
  Public ReadOnly Property pSeleccionMenu() As beMenu_InfoUC
    Get
      Return oInfoCboMenu
    End Get
  End Property

  Private Sub uc_Frm_CboMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dgvMenu.AutoGenerateColumns = False
      dgvMenu.DataSource = Nothing
      If (oListInicialCboMenu.Count <> 0) Then
        dgvMenu.DataSource = oListInicialCboMenu
        If TryCast(dgvMenu.DataSource, List(Of beMenuUC)).Count > 0 Then
          UcPaginacion.PageCount = TryCast(dgvMenu.DataSource, List(Of beMenuUC)).Item(0).PageCount
        End If
      Else
        pCargarInformacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub pCargarInformacion()

    dgvMenu.DataSource = Nothing
    Dim oLisCboMenu As New List(Of beMenuUC)
    Dim oclsCboMenu As New ucMenu_DAL
    Dim obeQueryCboMenu As New beMenu_InfoUC
    With obeQueryCboMenu
      .PSMMCAPL = oInfoCboMenu.PSMMCAPL
      .PSMMCMNU = txtCodigo.Text.Trim
      .PSMMTMNU = txtDescripcion.Text
      .PageSize = Me.UcPaginacion.PageSize
      .PageNumber = Me.UcPaginacion.PageNumber

    End With
    oLisCboMenu = oclsCboMenu.ListarMenu(obeQueryCboMenu)
    dgvMenu.DataSource = oLisCboMenu
    If TryCast(dgvMenu.DataSource, List(Of beMenuUC)).Count > 0 Then
      UcPaginacion.PageCount = TryCast(dgvMenu.DataSource, List(Of beMenuUC)).Item(0).PageCount
    End If
  End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
    Try
      pCargarInformacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub dgvMenu_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenu.CellDoubleClick
    Try

      Dim index As Int32 = dgvMenu.CurrentCellAddress.Y
      oCboMenu_BE = dgvMenu.Rows(index).DataBoundItem
      oInfoCboMenu.PSMMCAPL = oCboMenu_BE.PSMMCAPL
      oInfoCboMenu.PSMMCMNU = oCboMenu_BE.PSMMCMNU
      oInfoCboMenu.PSMMTMNU = oCboMenu_BE.PSMMTMNU
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
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

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Try
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class

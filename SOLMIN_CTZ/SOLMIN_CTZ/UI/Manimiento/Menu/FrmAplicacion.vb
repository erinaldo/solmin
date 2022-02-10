Imports Ransa.Controls.Menu
Public Class FrmAplicacion

  Private Sub FrmAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      UcAplicacionBusq_pBuscarAplicacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown, txtDescripcion.KeyDown
    Try
      If e.KeyCode = Keys.Enter Then
        UcAplicacionBusq_pBuscarAplicacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    Private Sub UcAplicacionBusq_pBuscarAplicacion() Handles UcAplicacionBusq.pBuscarAplicacion
    Try
      Dim obeAplicacion As New beAplicacion
      obeAplicacion.PSMMCAPL_CodApl = txtCodigo.Text
      obeAplicacion.PSMMDAPL_DesApl = txtDescripcion.Text.ToUpper
      UcAplicacionBusq.pActualizarDatos(obeAplicacion)
      If UcAplicacionBusq.pnumReg = 0 Then
        UcMenuBusq.pActualizarDatosNothing()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
    Private Sub UcAplicacionBusq_pSelectionFilaAplicacionChanged() Handles UcAplicacionBusq.pSelectionFilaAplicacionChanged
    Try
      Dim obeMenu As New beMenu
      obeMenu.PSMMCAPL_CodApl = UcAplicacionBusq.pInfo_MMCAPL_CodApl
      UcMenuBusq.pActualizarDatos(obeMenu)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    End Sub

  Private Sub UcAplicacionBusq_EventChanged()
    Try
      UcAplicacionBusq_pBuscarAplicacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub UcMenuBusq_EventChanged() Handles UcAplicacionBusq.EventChanged
    Try
      Dim obeMenu As New beMenu
      obeMenu.PSMMCAPL_CodApl = UcAplicacionBusq.pInfo_MMCAPL_CodApl
      UcMenuBusq.pActualizarDatos(obeMenu)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub UcMenuBusq_pMostrarMenu() Handles UcAplicacionBusq.pMostrarMenu
    Try
      Dim oFrmMenu As New FrmMenu
      oFrmMenu.pMMCAPL_CodApl = UcAplicacionBusq.pInfo_MMCAPL_CodApl
      oFrmMenu.MdiParent = Me.ParentForm
      oFrmMenu.Show()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
  
End Class

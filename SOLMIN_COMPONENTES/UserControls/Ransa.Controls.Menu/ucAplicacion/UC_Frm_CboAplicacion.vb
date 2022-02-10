Imports System.Windows.Forms
Public Class UC_Frm_CboAplicacion
  Private oInfoCboAplicacion As New beAplicacionInfoUC
  Public oFiltroCboAplicacion As New beAplicacionInfoUC
  Private paginaInicial As Int32 = 0
  Private oCboAplicacion_BE As New beAplicacionUc
  Public oListInicialCboAplicacion As New List(Of beAplicacionUc)
  Public ReadOnly Property pSeleccion() As beAplicacionInfoUC
    Get
      Return oInfoCboAplicacion
    End Get
  End Property

  Private Sub uc_Frm_CboAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dgvAplicacion.AutoGenerateColumns = False
      dgvAplicacion.DataSource = Nothing
      If (oListInicialCboAplicacion.Count <> 0) Then
        dgvAplicacion.DataSource = oListInicialCboAplicacion
        If TryCast(dgvAplicacion.DataSource, List(Of beAplicacionUc)).Count > 0 Then
          UcPaginacion.PageCount = TryCast(dgvAplicacion.DataSource, List(Of beAplicacionUc)).Item(0).PageCount
        End If
      Else
        pCargarInformacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub pCargarInformacion()
    dgvAplicacion.DataSource = Nothing
    Dim oLisCboAplicacion As New List(Of beAplicacionUc)
    Dim oclsCboAplicacion As New ucAplicacion_DAL
    Dim obeQueryCboAplicacion As New beAplicacionInfoUC
    With obeQueryCboAplicacion
      .PSMMCAPL = txtCodigo.Text.Trim
      .PSMMDAPL = txtDescripcion.Text
      .PageSize = Me.UcPaginacion.PageSize
      .PageNumber = Me.UcPaginacion.PageNumber
    End With
    oLisCboAplicacion = oclsCboAplicacion.ListarAplicacion(obeQueryCboAplicacion)
    dgvAplicacion.DataSource = oLisCboAplicacion
    If TryCast(dgvAplicacion.DataSource, List(Of beAplicacionUc)).Count > 0 Then
      UcPaginacion.PageCount = TryCast(dgvAplicacion.DataSource, List(Of beAplicacionUc)).Item(0).PageCount
    End If
  End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
    Try
      pCargarInformacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub dgvAplicacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAplicacion.CellDoubleClick
    Try

      Dim index As Int32 = dgvAplicacion.CurrentCellAddress.Y
      oCboAplicacion_BE = dgvAplicacion.Rows(index).DataBoundItem
      oInfoCboAplicacion.PSMMCAPL = oCboAplicacion_BE.PSMMCAPL
      oInfoCboAplicacion.PSMMDAPL = oCboAplicacion_BE.PSMMDAPL
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

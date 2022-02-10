Imports System.Windows.Forms
Public Class uc_Frm_AgenteAduana

  Private oInfoAgenteAduana As New AgenteAduana_Info_BE()
  Public oFiltroAgenteAduana As New AgenteAduana_Info_BE()
  Private paginaInicial As Int32 = 0

  Private obeAgenteAduana As New AgenteAduana_BE
  Public oListInicialAgenteAduana As New List(Of AgenteAduana_BE)
  Public ReadOnly Property pSeleccion() As AgenteAduana_Info_BE
    Get
      Return oInfoAgenteAduana
    End Get
  End Property

  Private Sub uc_Frm_AgenteAduana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dgvAgenteAduana.AutoGenerateColumns = False
      dgvAgenteAduana.DataSource = Nothing
      If (oListInicialAgenteAduana.Count <> 0) Then
        dgvAgenteAduana.DataSource = oListInicialAgenteAduana
        If TryCast(dgvAgenteAduana.DataSource, List(Of AgenteAduana_BE)).Count > 0 Then
          UcPaginacion.PageCount = TryCast(dgvAgenteAduana.DataSource, List(Of AgenteAduana_BE)).Item(0).PageCount
        End If
      Else
        pCargarInformacion()
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub pCargarInformacion()
    Try
      dgvAgenteAduana.DataSource = Nothing
      Dim oLisAgenteAduana As New List(Of AgenteAduana_BE)
      Dim oblAgenteAduana As New AgenteAduana_BLL
      Dim obeQueryAgenteAduana As New AgenteAduana_Info_BE
      With obeQueryAgenteAduana
        If (txtCodigo.Text.Trim = "") Then
          .PNCAGNAD = 0
        Else
          .PNCAGNAD = Decimal.Parse(txtCodigo.Text.Trim)
        End If
        '.PSNRUCTR = txtRUC.Text.Trim
        .PSTCMAA = txtDescripcion.Text.Trim
        .PageSize = Me.UcPaginacion.PageSize
        .PageNumber = Me.UcPaginacion.PageNumber
        If (txtCodigo.Text.Trim <> "") Then
          .PSBUSQUEDA = "C" 'BUSQUEDA POR CODIGO
        Else
          .PSBUSQUEDA = ""
        End If

      End With
      oLisAgenteAduana = oblAgenteAduana.ListarAgenteAduana(obeQueryAgenteAduana)
      dgvAgenteAduana.DataSource = oLisAgenteAduana
      If TryCast(dgvAgenteAduana.DataSource, List(Of AgenteAduana_BE)).Count > 0 Then
        UcPaginacion.PageCount = TryCast(dgvAgenteAduana.DataSource, List(Of AgenteAduana_BE)).Item(0).PageCount
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

  Private Sub dgvAgenteAduana_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAgenteAduana.CellDoubleClick
    Try

      Dim index As Int32 = dgvAgenteAduana.CurrentCellAddress.Y
      obeAgenteAduana = dgvAgenteAduana.Rows(index).DataBoundItem
      oInfoAgenteAduana.PNCAGNAD = obeAgenteAduana.PNCAGNAD
      oInfoAgenteAduana.PSTCMAA = obeAgenteAduana.PSTCMAA
      oInfoAgenteAduana.PSTABAA = obeAgenteAduana.PSTABAA
      Me.Close()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
    If e.KeyCode = Keys.Enter Then
      Me.UcPaginacion.PageNumber = 1
      Call pCargarInformacion()
    End If
  End Sub

  Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
    If e.KeyCode = Keys.Enter Then
      Me.UcPaginacion.PageNumber = 1
      Call pCargarInformacion()
    End If
  End Sub

  Private Sub txtRUC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    If e.KeyCode = Keys.Enter Then
      Me.UcPaginacion.PageNumber = 1
      Call pCargarInformacion()
    End If
  End Sub


  Private Sub ValidaEnteros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    Try
      If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
        e.Handled = True
      End If
      Select Case AscW(e.KeyChar)
        Case 8, 13, 32
          e.Handled = False
      End Select
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Call pCargarInformacion()
  End Sub
End Class

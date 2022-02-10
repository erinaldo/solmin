Imports System.Windows.Forms

Public Class FrmPerfilCliente

  Private _pMMCUSR As String = ""
  Public Property pMMCUSR() As String
    Get
      Return _pMMCUSR
    End Get
    Set(ByVal value As String)
      _pMMCUSR = value
    End Set
  End Property
  Private isCheckCliente As Boolean = False

  Private Sub btnManBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManBuscar.Click
    Buscar_Perfil_Cliente()
  End Sub

  Sub Buscar_Perfil_Cliente()

    If Uc_CboUsuario.pPSMMCUSR.Trim.Length = 0 Then
      MessageBox.Show("Seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Dim obeAccesoCliente As New beAccesoCliente
    Dim oclsUsuario_DAL As New clsUsuario_DAL
    obeAccesoCliente.PSMMCUSR = Uc_CboUsuario.pPSMMCUSR
    dgvPerfilCliente.DataSource = oclsUsuario_DAL.Listar_Perfil_AccesoCliente(obeAccesoCliente)

  End Sub

  Private Function HaySeleccionCliente() As Boolean
    dgvPerfilCliente.EndEdit()
    Dim intCont As Integer
    Dim HaySeleccionadosCliente As Boolean = False
    For intCont = 0 To dgvPerfilCliente.RowCount - 1
      If dgvPerfilCliente.Rows(intCont).Cells("CHK_CLIENTE").Value = True Then
        HaySeleccionadosCliente = True
        Exit For
      End If
    Next
    Return HaySeleccionadosCliente
  End Function

  Private Sub Poner_Check_Todo_Cliente(ByVal blnEstado As Boolean)
    Dim intCont As Integer
    For intCont = 0 To dgvPerfilCliente.RowCount - 1
      dgvPerfilCliente.Rows(intCont).Cells("CHK_CLIENTE").Value = blnEstado
    Next
  End Sub

  Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
    dgvPerfilCliente.EndEdit()
    isCheckCliente = Not isCheckCliente
    If isCheckCliente = True Then
      btncheck.Image = My.Resources.btnMarcarItems
    Else
      btncheck.Image = My.Resources.btnNoMarcarItems
    End If
    Poner_Check_Todo_Cliente(isCheckCliente)
  End Sub

  Private Sub btnManGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManGuardar.Click
    Try
      dgvPerfilCliente.EndEdit()
      If HaySeleccionCliente() = True Then
        If dgvPerfilCliente.CurrentRow IsNot Nothing And dgvPerfilCliente.Rows.Count > 0 Then
          Dim obeAccesoCliente As beAccesoCliente
          Dim oclsUsuario_DAL As New clsUsuario_DAL
          Dim Fila As Int32 = 0
          Dim retorno As Int32 = 0
          For Fila = 0 To dgvPerfilCliente.RowCount - 1
            If dgvPerfilCliente.Rows(Fila).Cells("CHK_CLIENTE").Value = True Then

              obeAccesoCliente = New beAccesoCliente
              obeAccesoCliente.PSMMCUSR = pMMCUSR
              obeAccesoCliente.PNCCLNT = Me.dgvPerfilCliente.Item("CCLNT", Fila).Value
              obeAccesoCliente.PNCPLNDV = Me.dgvPerfilCliente.Item("CPLNDV", Fila).Value
              obeAccesoCliente.PSTCMPCL = Me.dgvPerfilCliente.Item("TCMPCL", Fila).Value.ToString.Trim()
              obeAccesoCliente.PSCINTER = Me.dgvPerfilCliente.Item("CINTER", Fila).Value.ToString.Trim()

              oclsUsuario_DAL.Registrar_Perfil_Clientes(obeAccesoCliente)
            End If
          Next
          Me.DialogResult = Windows.Forms.DialogResult.OK
          Me.Close()
        End If
      Else
        MessageBox.Show("Debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub txtUsuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Try
      If e.KeyCode = Keys.Enter Then
        Buscar_Perfil_Cliente()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub FrmPerfilCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = String.Format("{0}   -   Usuario Destino : {1}", Me.Text, pMMCUSR)
    Uc_CboUsuario.pClear()
  End Sub
End Class

Imports System.Windows.Forms
Public Class FrmPerfilOpciones

  Private _pMMCUSR As String = ""
  Public Property pMMCUSR() As String
    Get
      Return _pMMCUSR
    End Get
    Set(ByVal value As String)
      _pMMCUSR = value
    End Set
  End Property

  Private isCheckOpcion As Boolean = False

  Private Sub btnManBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManBuscar.Click
    Try
      BuscarPerfilOpcion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Sub BuscarPerfilOpcion()

    If Uc_CboUsuario.pPSMMCUSR.Trim.Length = 0 Then
      MessageBox.Show("Seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    Dim obeAccesoOpcion As New beAccesoOpcion
    Dim oclsUsuario_DAL As New clsUsuario_DAL
    obeAccesoOpcion.PSMMCUSR = Uc_CboUsuario.pPSMMCUSR
    obeAccesoOpcion.PSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
    obeAccesoOpcion.PSMMCMNU = Uc_CboMenu1.pPSMMCMNU
    dgvPerfilOpciones.DataSource = oclsUsuario_DAL.Listar_Perfil_AccesoOpcion(obeAccesoOpcion)

  End Sub

  Private Sub Uc_CboAplicacion1_InformationChanged() Handles Uc_CboAplicacion1.InformationChanged
    Try
      Uc_CboMenu1.pPSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
      Uc_CboMenu1.pClear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnManGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManGuardar.Click
    Try
      dgvPerfilOpciones.EndEdit()
      If HaySeleccionOpcion() = True Then
        If dgvPerfilOpciones.CurrentRow IsNot Nothing And dgvPerfilOpciones.Rows.Count > 0 Then
          Dim obeAccesoOpcion As beAccesoOpcion
          Dim oclsUsuario_DAL As New clsUsuario_DAL
          Dim Fila As Int32 = 0
          Dim retorno As Int32 = 0
          For Fila = 0 To dgvPerfilOpciones.RowCount - 1
            If dgvPerfilOpciones.Rows(Fila).Cells("CHK_OPCION").Value = True Then
              obeAccesoOpcion = New beAccesoOpcion
              obeAccesoOpcion.PSMMCUSR = pMMCUSR
              obeAccesoOpcion.PSMMCAPL = Me.dgvPerfilOpciones.Item("MMCAPL", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PSMMCMNU = Me.dgvPerfilOpciones.Item("MMCMNU", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PNMMCOPC = Me.dgvPerfilOpciones.Item("MMCOPC", Fila).Value
              obeAccesoOpcion.PSSTSVIS = Me.dgvPerfilOpciones.Item("STSVIS", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PSSTSADI = Me.dgvPerfilOpciones.Item("STSADI", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PSSTSCHG = Me.dgvPerfilOpciones.Item("STSCHG", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PSSTSELI = Me.dgvPerfilOpciones.Item("STSELI", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PSSTSOP1 = Me.dgvPerfilOpciones.Item("STSOP1", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PSSTSOP2 = Me.dgvPerfilOpciones.Item("STSOP2", Fila).Value.ToString.Trim()
              obeAccesoOpcion.PSSTSOP3 = Me.dgvPerfilOpciones.Item("STSOP3", Fila).Value.ToString.Trim()
              oclsUsuario_DAL.Registrar_Perfil_Opciones(obeAccesoOpcion)
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

  Private Function HaySeleccionOpcion() As Boolean
    dgvPerfilOpciones.EndEdit()
    Dim intCont As Integer
    Dim HaySeleccionadosOpcion As Boolean = False
    For intCont = 0 To dgvPerfilOpciones.RowCount - 1
      If dgvPerfilOpciones.Rows(intCont).Cells("CHK_OPCION").Value = True Then
        HaySeleccionadosOpcion = True
        Exit For
      End If
    Next
    Return HaySeleccionadosOpcion
  End Function

  Private Sub Poner_Check_Todo_Opcion(ByVal blnEstado As Boolean)
    Dim intCont As Integer
    For intCont = 0 To dgvPerfilOpciones.RowCount - 1
      dgvPerfilOpciones.Rows(intCont).Cells("CHK_OPCION").Value = blnEstado
    Next
  End Sub

  Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click

    dgvPerfilOpciones.EndEdit()
    isCheckOpcion = Not isCheckOpcion
    If isCheckOpcion = True Then
      btncheck.Image = My.Resources.btnMarcarItems
    Else
      btncheck.Image = My.Resources.btnNoMarcarItems
    End If
    Poner_Check_Todo_Opcion(isCheckOpcion)

  End Sub

  Private Sub txtUsuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Try
      If e.KeyCode = Keys.Enter Then
        BuscarPerfilOpcion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub FrmPerfilOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = String.Format("{0}   -   Usuario Destino : {1}", Me.Text, pMMCUSR)
    Uc_CboUsuario.pClear()
  End Sub
End Class

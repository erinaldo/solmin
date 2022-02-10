Imports System.Windows.Forms

Public Class FrmPerfilPlanta

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

  Private Sub FrmPerfilPlanta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = String.Format("{0}   -  Usuario Destino : {1}", Me.Text, pMMCUSR)
    Uc_CboUsuario1.pClear()
    Cargar_Compania()
    Cargar_Division_X_Compania()
    Cargar_Planta_X_CompaniaDivision()

  End Sub

  Sub Buscar_Perfil_Planta()

    If Uc_CboUsuario1.pPSMMCUSR.Trim.Length = 0 Then
      MessageBox.Show("Seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Dim obeAccesoPlanta As New beAccesoPlanta
    Dim oclsUsuario_DAL As New clsUsuario_DAL
    obeAccesoPlanta.PSMMCUSR = Uc_CboUsuario1.pPSMMCUSR
    If UcAyudaCompania.Resultado Is Nothing Then
      obeAccesoPlanta.PSCCMPN = ""
    Else
      obeAccesoPlanta.PSCCMPN = CType(UcAyudaCompania.Resultado, beCompania).PSCODIGO
    End If
    If UcAyudaDivision.Resultado Is Nothing Then
      obeAccesoPlanta.PSCDVSN = ""
    Else
      obeAccesoPlanta.PSCDVSN = CType(UcAyudaDivision.Resultado, beDivision).PSCODIGO
    End If

    dgvPerfilPlanta.DataSource = oclsUsuario_DAL.Listar_Perfil_AccesoPlanta(obeAccesoPlanta)

  End Sub

  Sub Cargar_Compania()

    Dim oclsUsuario_DAL As New clsUsuario_DAL
    Dim listCompania As New List(Of beCompania)

    listCompania = oclsUsuario_DAL.Listar_Compania()

    Dim oListColum As New Hashtable
    Dim oColumnas As New DataGridViewTextBoxColumn
    oColumnas.Name = "PSCODIGO"
    oColumnas.DataPropertyName = "PSCODIGO"
    oColumnas.HeaderText = "Código "
    oListColum.Add(1, oColumnas)

    oColumnas = New DataGridViewTextBoxColumn
    oColumnas.Name = "PSDESCRIPCION"
    oColumnas.DataPropertyName = "PSDESCRIPCION"
    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    oColumnas.HeaderText = "Descripción "
    oListColum.Add(2, oColumnas)

    Me.UcAyudaCompania.DataSource = listCompania
    Me.UcAyudaCompania.ListColumnas = oListColum
    Me.UcAyudaCompania.Cargas()
    Me.UcAyudaCompania.DispleyMember = "PSDESCRIPCION"
    Me.UcAyudaCompania.ValueMember = "PSCODIGO"
  End Sub


  Sub Cargar_Division_X_Compania()
    Dim oclsUsuario_DAL As New clsUsuario_DAL
    Dim objbeDivision As New beDivision
    Dim listDivision As New List(Of beDivision)

    If UcAyudaCompania.Resultado IsNot Nothing Then
      objbeDivision.PSCODCIA = CType(UcAyudaCompania.Resultado, beCompania).PSCODIGO
      listDivision = oclsUsuario_DAL.Listar_Division_X_Compania(objbeDivision)

      Dim oListColum As New Hashtable
      Dim oColumnas As New DataGridViewTextBoxColumn

      oColumnas = New DataGridViewTextBoxColumn
      oColumnas.Name = "PSCODIGO"
      oColumnas.DataPropertyName = "PSCODIGO"
      oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
      oColumnas.HeaderText = "Codigo "
      oListColum.Add(1, oColumnas)

      oColumnas = New DataGridViewTextBoxColumn
      oColumnas.Name = "PSDESCRIPCION"
      oColumnas.DataPropertyName = "PSDESCRIPCION"
      oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
      oColumnas.HeaderText = "Descripción "
      oListColum.Add(2, oColumnas)

      Me.UcAyudaDivision.DataSource = listDivision
      Me.UcAyudaDivision.ListColumnas = oListColum
      Me.UcAyudaDivision.Cargas()
      Me.UcAyudaDivision.DispleyMember = "PSDESCRIPCION"
      Me.UcAyudaDivision.ValueMember = "PSCODIGO"
    End If
  End Sub

  Sub Cargar_Planta_X_CompaniaDivision()

    Dim oclsUsuario_DAL As New clsUsuario_DAL
    Dim dt As New DataTable
    Dim obePlanta As New bePlanta
    Dim listPlanta As New List(Of bePlanta)
    If UcAyudaCompania.Resultado IsNot Nothing And UcAyudaDivision.Resultado IsNot Nothing Then

      obePlanta.PSCODCIA = CType(UcAyudaCompania.Resultado, beCompania).PSCODIGO
      obePlanta.PSCODDIV = CType(UcAyudaDivision.Resultado, beDivision).PSCODIGO
      listPlanta = oclsUsuario_DAL.Listar_Planta_X_Compania_Division(obePlanta)

      Dim oListColum As New Hashtable
      Dim oColumnas As New DataGridViewTextBoxColumn

      oColumnas = New DataGridViewTextBoxColumn
      oColumnas.Name = "PNCODIGO"
      oColumnas.DataPropertyName = "PNCODIGO"
      oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
      oColumnas.HeaderText = "Codigo "
      oListColum.Add(1, oColumnas)

      oColumnas = New DataGridViewTextBoxColumn
      oColumnas.Name = "PSDESCRIPCION"
      oColumnas.DataPropertyName = "PSDESCRIPCION"
      oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
      oColumnas.HeaderText = "Descripción "
      oListColum.Add(2, oColumnas)

   

    End If
  End Sub

  Private Sub Cargar_Division(ByVal objData As Object) Handles UcAyudaCompania.CambioDeTexto
    Try
      If UcAyudaCompania.Resultado IsNot Nothing Then
        UcAyudaDivision.Valor = ""     
        Cargar_Division_X_Compania()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

 

  Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Try
      If e.KeyCode = Keys.Enter Then
        Buscar_Perfil_Planta()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnManBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManBuscar.Click
    Try
      Buscar_Perfil_Planta()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function HaySeleccionPlanta() As Boolean
    dgvPerfilPlanta.EndEdit()
    Dim intCont As Integer
    Dim HaySeleccionadosPlanta As Boolean = False
    For intCont = 0 To dgvPerfilPlanta.RowCount - 1
      If dgvPerfilPlanta.Rows(intCont).Cells("CHK_PLANTA").Value = True Then
        HaySeleccionadosPlanta = True
        Exit For
      End If
    Next
    Return HaySeleccionadosPlanta
  End Function

  Private Sub Poner_Check_Todo_Opcion(ByVal blnEstado As Boolean)
    Dim intCont As Integer
    For intCont = 0 To dgvPerfilPlanta.RowCount - 1
      dgvPerfilPlanta.Rows(intCont).Cells("CHK_PLANTA").Value = blnEstado
    Next
  End Sub

  Private Sub btnManGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManGuardar.Click
    Try
      dgvPerfilPlanta.EndEdit()
      If HaySeleccionPlanta() = True Then
        If dgvPerfilPlanta.CurrentRow IsNot Nothing And dgvPerfilPlanta.Rows.Count > 0 Then
          Dim obeAccesoPlanta As beAccesoPlanta
          Dim oclsUsuario_DAL As New clsUsuario_DAL
          Dim Fila As Int32 = 0
          Dim retorno As Int32 = 0
          For Fila = 0 To dgvPerfilPlanta.RowCount - 1
            If dgvPerfilPlanta.Rows(Fila).Cells("CHK_PLANTA").Value = True Then

              obeAccesoPlanta = New beAccesoPlanta
              obeAccesoPlanta.PSMMCUSR = pMMCUSR
              obeAccesoPlanta.PSCCMPN = Me.dgvPerfilPlanta.Item("CCMPN", Fila).Value.ToString.Trim()
              obeAccesoPlanta.PSCDVSN = Me.dgvPerfilPlanta.Item("CDVSN", Fila).Value.ToString.Trim()
              obeAccesoPlanta.PNCPLNDV = Me.dgvPerfilPlanta.Item("CPLNDV1", Fila).Value
              obeAccesoPlanta.PSMMCAPL = Me.dgvPerfilPlanta.Item("MMCAPL1", Fila).Value.ToString.Trim()
              obeAccesoPlanta.PSCRGVTA = Me.dgvPerfilPlanta.Item("CRGVTA", Fila).Value.ToString.Trim()
              obeAccesoPlanta.PSCSCDSP = Me.dgvPerfilPlanta.Item("CSCDSP", Fila).Value.ToString.Trim()

              oclsUsuario_DAL.Registrar_Perfil_Plantas(obeAccesoPlanta)
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

  Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
    dgvPerfilPlanta.EndEdit()
    isCheckOpcion = Not isCheckOpcion
    If isCheckOpcion = True Then
      btncheck.Image = My.Resources.btnMarcarItems
    Else
      btncheck.Image = My.Resources.btnNoMarcarItems
    End If
    Poner_Check_Todo_Opcion(isCheckOpcion)
  End Sub
End Class

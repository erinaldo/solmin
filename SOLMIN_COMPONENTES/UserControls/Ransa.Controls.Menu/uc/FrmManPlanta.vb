Imports System.Windows.Forms
Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class FrmManPlanta

  Private _pEstado As New Estado

  Public Property pEstado() As Estado
    Get
      Return _pEstado
    End Get
    Set(ByVal value As Estado)
      _pEstado = value
    End Set
  End Property

  Public Enum Estado
    Nuevo
    Modificar
  End Enum

  Private _pbeAccesoPlanta As New beAccesoPlanta

  Public Property pbeAccesoPlanta() As beAccesoPlanta
    Get
      Return _pbeAccesoPlanta
    End Get
    Set(ByVal value As beAccesoPlanta)
      _pbeAccesoPlanta = value
    End Set
  End Property

  Private Sub FrmManPlanta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Cargar_Compania()
      Cargar_Division_X_Compania()
      Cargar_Planta_X_CompaniaDivision()
      txtUsuario.Enabled = False
      txtUsuario.Text = _pbeAccesoPlanta.PSMMCUSR
      If _pEstado = Estado.Modificar Then
        UcAyudaCompania.Enabled = False
        UcAyudaDivision.Enabled = False
        UcAyudaPlanta.Enabled = False
        UcAyudaCompania.Valor = _pbeAccesoPlanta.PSCCMPN
        UcAyudaDivision.Valor = _pbeAccesoPlanta.PSCDVSN
        UcAyudaPlanta.Valor = _pbeAccesoPlanta.PNCPLNDV
        If (_pbeAccesoPlanta.PSMMCAPL.Trim.Length <> 0) Then
          Uc_CboAplicacion1.pObtenerAplicacion(_pbeAccesoPlanta.PSMMCAPL)
        End If
        txtRegionVenta.Text = _pbeAccesoPlanta.PSCRGVTA
        txtSociedadSAP.Text = _pbeAccesoPlanta.PSCSCDSP
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub Cancelar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Try
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Registrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Try
      Dim oclsUsuario_DAL As New clsUsuario_DAL
      Dim obeAccesoPlanta As New beAccesoPlanta
      Dim msgValidacion As String = Valida_Campos()

      Select Case _pEstado
        Case Estado.Nuevo

          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeAccesoPlanta.PSMMCUSR = txtUsuario.Text
            obeAccesoPlanta.PSCCMPN = CType(UcAyudaCompania.Resultado, beCompania).PSCODIGO
            obeAccesoPlanta.PSCDVSN = CType(UcAyudaDivision.Resultado, beDivision).PSCODIGO
            obeAccesoPlanta.PNCPLNDV = CType(UcAyudaPlanta.Resultado, bePlanta).PNCODIGO
            obeAccesoPlanta.PSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
            obeAccesoPlanta.PSCRGVTA = txtRegionVenta.Text.ToString
            obeAccesoPlanta.PSCSCDSP = txtSociedadSAP.Text.ToString

            If oclsUsuario_DAL.Registrar_Opciones_X_Planta(obeAccesoPlanta) = 1 Or oclsUsuario_DAL.Registrar_Opciones_X_Planta(obeAccesoPlanta) = 0 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
          End If

        Case Estado.Modificar

          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeAccesoPlanta.PSMMCUSR = txtUsuario.Text
            obeAccesoPlanta.PSCCMPN = CType(UcAyudaCompania.Resultado, beCompania).PSCODIGO
            obeAccesoPlanta.PSCDVSN = CType(UcAyudaDivision.Resultado, beDivision).PSCODIGO
            obeAccesoPlanta.PNCPLNDV = CType(UcAyudaPlanta.Resultado, bePlanta).PNCODIGO
            obeAccesoPlanta.PSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
            obeAccesoPlanta.PSCRGVTA = txtRegionVenta.Text.ToString
            obeAccesoPlanta.PSCSCDSP = txtSociedadSAP.Text.ToString

            If oclsUsuario_DAL.Modificar_Opciones_X_Planta(obeAccesoPlanta) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
          End If
      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    If UcAyudaCompania.Resultado Is Nothing Then
      sbMensaje.AppendLine("* Compañia")
    End If
    If UcAyudaDivision.Resultado Is Nothing Then
      sbMensaje.AppendLine("* División")
    End If
    If UcAyudaPlanta.Resultado Is Nothing Then
      sbMensaje.AppendLine("* Planta")
    End If
    Return sbMensaje.ToString
  End Function

  Private Sub txtSociedadSAP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSociedadSAP.KeyPress
    Try
      e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
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

  Private Sub Cargar_Division(ByVal objData As Object) Handles UcAyudaCompania.CambioDeTexto
    Try

      If UcAyudaCompania.Resultado IsNot Nothing Then
        UcAyudaDivision.Valor = ""
        UcAyudaPlanta.Valor = ""
        Cargar_Division_X_Compania()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cargar_Planta(ByVal objData As Object) Handles UcAyudaDivision.CambioDeTexto
    Try
      If (UcAyudaCompania.Resultado IsNot Nothing) And (UcAyudaCompania.Resultado IsNot Nothing) Then
        UcAyudaPlanta.Valor = ""
        Cargar_Planta_X_CompaniaDivision()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
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

      Me.UcAyudaPlanta.DataSource = listPlanta
      Me.UcAyudaPlanta.ListColumnas = oListColum
      Me.UcAyudaPlanta.Cargas()
      Me.UcAyudaPlanta.DispleyMember = "PSDESCRIPCION"
      Me.UcAyudaPlanta.ValueMember = "PNCODIGO"

    End If
  End Sub

End Class

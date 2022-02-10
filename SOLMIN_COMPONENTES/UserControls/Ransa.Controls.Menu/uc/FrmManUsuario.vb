Imports System.Windows.Forms
Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class FrmManUsuario

  Private _pEstado As New Estado
  Private _pbeUsuario As New beUsuario

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

  Public Property pbeUsuario() As beUsuario
    Get
      Return _pbeUsuario
    End Get
    Set(ByVal value As beUsuario)
      _pbeUsuario = value
    End Set
  End Property

  Private Sub FrmManUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try

      Cargar_Compania()
      Cargar_Division_X_Compania()
      If _pEstado = Estado.Modificar Then
        txtUsuario.Enabled = False
        txtNombre.Text = _pbeUsuario.PSMMNUSR
        If (_pbeUsuario.PSMMCAII IsNot Nothing) Then
          Uc_CboAplicacion1.pObtenerAplicacion(_pbeUsuario.PSMMCAII) ' codigo aplicacion inicial
          Uc_CboMenu1.pPSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
          Uc_CboMenu1.pObtenerMenu(_pbeUsuario.PSMMCAII, _pbeUsuario.PSMMCMII)  ' codigo menu inicial
        End If
        If _pbeUsuario.PSCCMPOR Is Nothing Then
          UcAyudaCompania.Valor = Nothing
        Else
          UcAyudaCompania.Valor = _pbeUsuario.PSCCMPOR
        End If

        If _pbeUsuario.PSCDVSNU = "" Then
          UcAyudaDivision.Valor = Nothing
        Else
          UcAyudaDivision.Valor = _pbeUsuario.PSCDVSNU
        End If
        txtCuentaCorriente.Text = _pbeUsuario.PSCOROCC ' codigo de operaciones cuenta corriente
        txtTipoUsuario.Text = _pbeUsuario.PSMMTUSR 'tipo de usuario (D/F)
        txtCodNivelUsuario.Text = _pbeUsuario.PNCNVUSR 'codigo de nivel de usuario
        txtFlag.Text = _pbeUsuario.PSSORGZN 'flag de origen zona
      End If
      txtUsuario.Text = _pbeUsuario.PSMMCUSR
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
      Dim obeUsuario As New beUsuario
      Dim msgValidacion As String = Valida_Campos()
      Select Case _pEstado
        Case Estado.Nuevo
          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeUsuario.PSMMCUSR = txtUsuario.Text.ToString.Trim.ToUpper
            obeUsuario.PSMMNUSR = txtNombre.Text.ToString.Trim.ToUpper
            obeUsuario.PSMMCAII = Uc_CboAplicacion1.pPSMMCAPL  ' codigo aplicacion inicial
            obeUsuario.PSMMCMII = Uc_CboMenu1.pPSMMCMNU  ' codigo menu inicial
            obeUsuario.PSCOROCC = txtCuentaCorriente.Text.ToString.Trim ' codigo de operaciones cuenta corriente

            If UcAyudaCompania.Resultado Is Nothing Then
              obeUsuario.PSCCMPOR = ""
            Else
              obeUsuario.PSCCMPOR = CType(UcAyudaCompania.Resultado, beCompania).PSCODIGO
            End If

            If UcAyudaCompania.Resultado Is Nothing Then
              obeUsuario.PSCDVSNU = ""
            Else
              obeUsuario.PSCDVSNU = CType(UcAyudaDivision.Resultado, beDivision).PSCODIGO
            End If

            obeUsuario.PSMMTUSR = txtTipoUsuario.Text.ToString.ToUpper.Trim 'tipo de usuario (D/F)
            If txtCodNivelUsuario.Text = Nothing Then
              txtCodNivelUsuario.Text = "0"
            End If
            obeUsuario.PNCNVUSR = Val(txtCodNivelUsuario.Text) 'codigo de nivel de usuario
            obeUsuario.PSSORGZN = txtFlag.Text.ToString.Trim 'flag de origen zona

            If oclsUsuario_DAL.Registrar_Usuarios(obeUsuario) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
            If oclsUsuario_DAL.Registrar_Usuarios(obeUsuario) = 0 Then
              MessageBox.Show("Usuario ya creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
              txtUsuario.Focus()
              Exit Sub
            End If
            If oclsUsuario_DAL.Registrar_Usuarios(obeUsuario) = 2 Then
              MessageBox.Show(" El usuario se encuentra deshabilitado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
              txtUsuario.Focus()
              Exit Sub
            End If
          End If
        Case Estado.Modificar
          txtUsuario.Enabled = True
          obeUsuario.PSMMCUSR = _pbeUsuario.PSMMCUSR
          If txtNombre.Text.ToString.Trim <> "" Then
            obeUsuario.PSMMNUSR = txtNombre.Text.ToString.Trim.ToUpper
            obeUsuario.PSMMCAII = Uc_CboAplicacion1.pPSMMCAPL ' codigo aplicacion inicial
            obeUsuario.PSMMCMII = Uc_CboMenu1.pPSMMCMNU ' codigo menu inicial
            obeUsuario.PSCOROCC = txtCuentaCorriente.Text.Trim  ' codigo de operaciones cuenta corriente

            If UcAyudaCompania.Resultado Is Nothing Then
              obeUsuario.PSCCMPOR = ""
            Else
              obeUsuario.PSCCMPOR = CType(UcAyudaCompania.Resultado, beCompania).PSCODIGO
            End If

            If UcAyudaDivision.Resultado Is Nothing Then
              obeUsuario.PSCDVSNU = ""
            Else
              obeUsuario.PSCDVSNU = CType(UcAyudaDivision.Resultado, beDivision).PSCODIGO
            End If

            obeUsuario.PSMMTUSR = txtTipoUsuario.Text.Trim 'tipo de usuario (D/F)
            If txtCodNivelUsuario.Text = Nothing Then
              txtCodNivelUsuario.Text = "0"
            End If
            obeUsuario.PNCNVUSR = Integer.Parse(txtCodNivelUsuario.Text) 'codigo de nivel de usuario
            obeUsuario.PSSORGZN = txtFlag.Text.Trim 'flag de origen zona

            If oclsUsuario_DAL.Modificar_Usuarios(obeUsuario) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
            Else
              Exit Sub
            End If
          Else
            MessageBox.Show("Falta ingresar: Nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          End If

      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    txtUsuario.Text = txtUsuario.Text.Trim
    If txtUsuario.Text.Trim = "" Then
      sbMensaje.AppendLine("* Usuario")
    End If
    If txtNombre.Text.Trim = "" Then
      sbMensaje.AppendLine("* Nombre")
    End If
    Return sbMensaje.ToString
  End Function

  Private Sub Cambio_Aplicacion() Handles Uc_CboAplicacion1.InformationChanged
    Try
      Uc_CboMenu1.pPSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
      Uc_CboMenu1.pClear()
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

    If _pbeUsuario.PSCCMPOR IsNot Nothing Then   
      UcAyudaCompania.Valor = _pbeUsuario.PSCCMPOR
    End If

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

  Private Sub txtCodNivelUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodNivelUsuario.KeyPress
    Try
      e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub UcAyudaCompania_CambioDeTexto(ByVal objData As Object) Handles UcAyudaCompania.CambioDeTexto
    Try
      UcAyudaDivision.Valor = ""
      Cargar_Division_X_Compania()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class

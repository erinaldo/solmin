Imports System.Windows.Forms
Imports System.Text

Public Class FrmManOpcion

  Private _pbeOpcion As New beOpcion
  Private _pEstado As New Estado
  Public Event pSeleccionarTipo()

  Public Property pbeOpcion() As beOpcion
    Get
      Return _pbeOpcion
    End Get
    Set(ByVal value As beOpcion)
      _pbeOpcion = value
    End Set
  End Property

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

  Private Sub MantenimientoMenus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try

      If _pbeOpcion.PSMMCAPL_CodApl.Trim.Length = 0 And _pbeOpcion.PSMMCMNU_CodMnu.Trim.Length = 0 Then
        Me.Close()
      End If

      LabelOpcion.Text = String.Format("{0} - {1}", _pbeOpcion.PSMMCAPL_CodApl, _pbeOpcion.PSMMCMNU_CodMnu)
      cboTipoOpcion.Enabled = True
      Cargar_TipoOpcion()

      If _pEstado = Estado.Modificar Then
        cboTipoOpcion.SelectedValue = _pbeOpcion.PSMMTOPC

        txtCodigo.Enabled = False
        txtCodigo.Text = _pbeOpcion.PNMMCOPC_CodOpc

        txtProgramaVB.Text = _pbeOpcion.PSMMNPVB
        txtDescripcion.Text = _pbeOpcion.PSMMDOPC_DesOpc

        If _pbeOpcion.PSMMCAIN.Trim.Length > 0 Then
          Uc_CboAplicacion.pObtenerAplicacion(_pbeOpcion.PSMMCAIN)
          Uc_CboMenu.pPSMMCAPL = Uc_CboAplicacion.pPSMMCAPL
        End If
        If _pbeOpcion.PSMMCMIN.Trim.Length > 0 Then
          Uc_CboMenu.pObtenerMenu(_pbeOpcion.PSMMCAIN, _pbeOpcion.PSMMCMIN)
        End If

        txtTipoVariable.Text = _pbeOpcion.PSMMTVAR
        txtProceso.Text = _pbeOpcion.PSMMNPRO
        txtFuncion.Text = _pbeOpcion.PSMMNFUN
        'txtPrograma.Text = _pbeOpcion.PSMMNPGM
        txtDireccion.Text = _pbeOpcion.PSURLIMG
        Selecciona_TipoOpcion(cboTipoOpcion.SelectedValue, Nothing)
      End If

      If _pEstado = Estado.Nuevo Then
        cboTipoOpcion.SelectedValue = 0
        txtCodigo.Enabled = True
        txtProceso.Text = "*LIBL"
        txtFuncion.Text = "VISUAL"
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

  Private Sub Registrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Try
      Dim oclsOpcion_DAL As New clsOpcion_DAL
      Dim obeOpcion As New beOpcion
      Dim msgValidacion As String = Valida_Campos()
      Select Case _pEstado
        Case Estado.Nuevo
          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeOpcion.PSMMCAPL_CodApl = _pbeOpcion.PSMMCAPL_CodApl
            obeOpcion.PSMMCMNU_CodMnu = _pbeOpcion.PSMMCMNU_CodMnu
            obeOpcion.PNMMCOPC_CodOpc = Val(txtCodigo.Text)
            If txtProgramaVB.Enabled = True Then
              obeOpcion.PSMMNPVB = txtProgramaVB.Text.ToString.Trim
            Else
              obeOpcion.PSMMNPVB = ""
            End If
            obeOpcion.PSMMDOPC_DesOpc = txtDescripcion.Text.ToString
            If Uc_CboAplicacion.Enabled = True Then
              obeOpcion.PSMMCAIN = Uc_CboAplicacion.pPSMMCAPL
            Else
              obeOpcion.PSMMCAIN = ""
            End If
            If Uc_CboMenu.Enabled = True Then
              obeOpcion.PSMMCMIN = Uc_CboMenu.pPSMMCMNU
            Else
              obeOpcion.PSMMCMIN = ""
            End If
            obeOpcion.PSMMTOPC = cboTipoOpcion.SelectedValue
            If txtTipoVariable.Enabled = True Then
              obeOpcion.PSMMTVAR = txtTipoVariable.Text.Trim.ToString
            Else
              obeOpcion.PSMMTVAR = ""
            End If
            obeOpcion.PSMMNPRO = txtProceso.Text.Trim.ToString
            obeOpcion.PSMMNFUN = txtFuncion.Text.Trim.ToString
            'obeOpcion.PSMMNPGM = txtPrograma.Text.Trim.ToString
            If txtDireccion.Enabled = True Then
              obeOpcion.PSURLIMG = txtDireccion.Text.ToString.Trim.ToString
            Else
              obeOpcion.PSURLIMG = ""
            End If
            If oclsOpcion_DAL.Registrar_Opciones(obeOpcion) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
            If oclsOpcion_DAL.Registrar_Opciones(obeOpcion) = 0 Then
              MessageBox.Show("Opción ya creada, ingrese otro código ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
              txtCodigo.Focus()
              Exit Sub
            End If
            If oclsOpcion_DAL.Registrar_Opciones(obeOpcion) = 2 Then
              If MessageBox.Show("Opción deshabilitada ¿Desea reemplazarla?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                obeOpcion.PSMMCAPL_CodApl = _pbeOpcion.PSMMCAPL_CodApl
                obeOpcion.PSMMCMNU_CodMnu = _pbeOpcion.PSMMCMNU_CodMnu
                obeOpcion.PNMMCOPC_CodOpc = Val(txtCodigo.Text)

                If txtProgramaVB.Enabled = True Then
                  obeOpcion.PSMMNPVB = txtProgramaVB.Text.ToString.Trim
                Else
                  obeOpcion.PSMMNPVB = ""
                End If
                obeOpcion.PSMMDOPC_DesOpc = txtDescripcion.Text.ToString

                If Uc_CboAplicacion.Enabled = True Then
                  obeOpcion.PSMMCAIN = Uc_CboAplicacion.pPSMMCAPL
                Else
                  obeOpcion.PSMMCAIN = ""
                End If
                If Uc_CboMenu.Enabled = True Then
                  obeOpcion.PSMMCMIN = Uc_CboMenu.pPSMMCMNU
                Else
                  obeOpcion.PSMMCMIN = ""
                End If
                obeOpcion.PSMMTOPC = cboTipoOpcion.SelectedValue
                If txtTipoVariable.Enabled = True Then
                  obeOpcion.PSMMTVAR = txtTipoVariable.Text.Trim.ToString
                Else
                  obeOpcion.PSMMTVAR = ""
                End If
                obeOpcion.PSMMNPRO = txtProceso.Text.Trim.ToString
                obeOpcion.PSMMNFUN = txtFuncion.Text.Trim.ToString
                If txtDireccion.Enabled = True Then
                  obeOpcion.PSURLIMG = txtDireccion.Text.ToString.Trim.ToString
                Else
                  obeOpcion.PSURLIMG = ""
                End If

                If oclsOpcion_DAL.Restaurar_Opciones(obeOpcion) = 1 Then
                  Me.DialogResult = Windows.Forms.DialogResult.OK
                  Me.Close()
                  Exit Sub
                End If
              Else
                txtCodigo.Focus()
                Exit Sub
              End If
            End If
          End If
        Case Estado.Modificar
          txtCodigo.Enabled = True
          obeOpcion.PSMMCAPL_CodApl = _pbeOpcion.PSMMCAPL_CodApl
          obeOpcion.PSMMCMNU_CodMnu = _pbeOpcion.PSMMCMNU_CodMnu
          obeOpcion.PNMMCOPC_CodOpc = _pbeOpcion.PNMMCOPC_CodOpc

          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeOpcion.PSMMDOPC_DesOpc = txtDescripcion.Text.ToString.Trim

            If txtProgramaVB.Enabled = True Then
              obeOpcion.PSMMNPVB = txtProgramaVB.Text.ToString.Trim
            Else
              obeOpcion.PSMMNPVB = ""
            End If

            If Uc_CboAplicacion.Enabled = True Then
              obeOpcion.PSMMCAIN = Uc_CboAplicacion.pPSMMCAPL
            Else
              obeOpcion.PSMMCAIN = ""
            End If
            If Uc_CboMenu.Enabled = True Then
              obeOpcion.PSMMCMIN = Uc_CboMenu.pPSMMCMNU
            Else
              obeOpcion.PSMMCMIN = ""
            End If
            obeOpcion.PSMMTOPC = cboTipoOpcion.SelectedValue
            If txtTipoVariable.Enabled = True Then
              obeOpcion.PSMMTVAR = txtTipoVariable.Text.Trim.ToString
            Else
              obeOpcion.PSMMTVAR = ""
            End If
            obeOpcion.PSMMNPRO = txtProceso.Text.Trim.ToString
            obeOpcion.PSMMNFUN = txtFuncion.Text.Trim.ToString
            If txtDireccion.Enabled = True Then
              obeOpcion.PSURLIMG = txtDireccion.Text.ToString.Trim.ToString
            Else
              obeOpcion.PSURLIMG = ""
            End If

            If oclsOpcion_DAL.Modificar_Opciones(obeOpcion) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
            Else
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
    Dim cod As Int32 = Val(txtCodigo.Text)
    If cod < 1 Then
      sbMensaje.AppendLine("* Código")
    End If
    If cboTipoOpcion.SelectedValue = "0" Then
      sbMensaje.AppendLine("* Tipo de opción")
    End If
    If cboTipoOpcion.SelectedValue = "V" Then
      If txtProgramaVB.Text.Trim = "" Then
        sbMensaje.AppendLine("* Formulario")
      End If
    End If
    If txtDescripcion.Text.Trim = "" Then
      sbMensaje.AppendLine("* Título Formulario")
    End If
    Return sbMensaje.ToString
  End Function

  Private Sub Cargar_Menus() Handles Uc_CboAplicacion.InformationChanged
    Try
      Uc_CboMenu.pPSMMCAPL = Uc_CboAplicacion.pPSMMCAPL
      Uc_CboMenu.pClear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Sub Cargar_TipoOpcion()

    Dim dt As New DataTable
    dt.Columns.Add("Display")
    dt.Columns.Add("Value")
    Dim dr As DataRow

    dr = dt.NewRow
    dr("Display") = "V - Visual"
    dr("Value") = "V"
    dt.Rows.Add(dr)

    dr = dt.NewRow
    dr("Display") = "M - Menú"
    dr("Value") = "M"
    dt.Rows.Add(dr)

    dr = dt.NewRow
    dr("Display") = "B - Barra"
    dr("Value") = "B"
    dt.Rows.Add(dr)
    If _pEstado = Estado.Modificar Then
      cboTipoOpcion.SelectedValue = _pbeOpcion.PSMMTOPC
    Else
      dr = dt.NewRow
      dr("Display") = "::Seleccione::"
      dr("Value") = "0"
      dt.Rows.InsertAt(dr, 0)
    End If
    cboTipoOpcion.DataSource = dt
    cboTipoOpcion.DisplayMember = "Display"
    cboTipoOpcion.ValueMember = "Value"

  End Sub

  Private Sub Selecciona_TipoOpcion(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoOpcion.SelectionChangeCommitted
    Try

      Select Case cboTipoOpcion.SelectedValue
        Case "V"
          If _pEstado = Estado.Modificar Then
            txtCodigo.Enabled = False
          Else
            txtCodigo.Enabled = True
          End If
          txtProgramaVB.Enabled = True
          txtDescripcion.Enabled = True
          txtProceso.Enabled = True
          txtFuncion.Enabled = True
          txtDireccion.Enabled = True
          Uc_CboAplicacion.Enabled = False
          Uc_CboMenu.Enabled = False
          txtTipoVariable.Enabled = False
         
        Case "M"
          If _pEstado = Estado.Modificar Then
            txtCodigo.Enabled = False
          Else
            txtCodigo.Enabled = True
          End If
          txtProgramaVB.Enabled = False
          txtDescripcion.Enabled = True
          txtProceso.Enabled = True
          txtFuncion.Enabled = True
          txtDireccion.Enabled = True
          Uc_CboAplicacion.Enabled = True
          Uc_CboMenu.Enabled = True
          txtTipoVariable.Enabled = True

        Case "B"
          If _pEstado = Estado.Modificar Then
            txtCodigo.Enabled = False
          Else
            txtCodigo.Enabled = True
          End If
          txtProgramaVB.Enabled = False
          txtDescripcion.Enabled = True
          txtProceso.Enabled = True
          txtFuncion.Enabled = True
          txtDireccion.Enabled = False
          Uc_CboAplicacion.Enabled = True
          Uc_CboMenu.Enabled = True
          txtTipoVariable.Enabled = False
          
        Case "0"
          txtProgramaVB.Enabled = False
          txtDescripcion.Enabled = False
          txtProceso.Enabled = False
          txtFuncion.Enabled = False
          txtDireccion.Enabled = False
          Uc_CboAplicacion.Enabled = False
          Uc_CboMenu.Enabled = False
          txtTipoVariable.Enabled = False

      End Select

      'RaiseEvent pSeleccionarTipo()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    Try
      e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtTipoVariable_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoVariable.KeyPress
    Try
      e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class


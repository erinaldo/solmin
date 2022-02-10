Imports System.Windows.Forms
Imports System.Text

Public Class FrmManMenu
  Private _pbeMenu As New beMenu
  Private _pEstado As New Estado

  Public Property pbeMenu() As beMenu
    Get
      Return _pbeMenu
    End Get
    Set(ByVal value As beMenu)
      _pbeMenu = value
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
      If _pbeMenu.PSMMCAPL_CodApl.Trim.Length = 0 Then
        Me.Close()
      End If
      LabelMenu.Text = _pbeMenu.PSMMCAPL_CodApl
      If _pEstado = Estado.Modificar Then
        txtCodigo.Enabled = False
      End If
      txtCodigo.Text = _pbeMenu.PSMMCMNU_CodMnu
      txtDescripcion.Text = _pbeMenu.PSMMTMNU_DesMnu
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
            Dim oclsMenu_DAL As New clsMenu_DAL
      Dim obeMenu As New beMenu
      Dim msgValidacion As String = Valida_Campos()
      Select Case _pEstado
        Case Estado.Nuevo
          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeMenu.PSMMCAPL_CodApl = _pbeMenu.PSMMCAPL_CodApl
            obeMenu.PSMMCMNU_CodMnu = txtCodigo.Text.ToString.Trim
            obeMenu.PSMMTMNU_DesMnu = txtDescripcion.Text.ToString
            If oclsMenu_DAL.Registrar_Menus(obeMenu) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
            If oclsMenu_DAL.Registrar_Menus(obeMenu) = 0 Then
              MessageBox.Show("Menú ya creado, ingrese otro código", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
              txtCodigo.Focus()
              Exit Sub
            End If
            If oclsMenu_DAL.Registrar_Menus(obeMenu) = 2 Then
              If MessageBox.Show("Menú deshabilitado ¿Desea reemplazarlo?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                obeMenu.PSMMCAPL_CodApl = _pbeMenu.PSMMCAPL_CodApl
                obeMenu.PSMMCMNU_CodMnu = txtCodigo.Text.ToString.Trim
                obeMenu.PSMMTMNU_DesMnu = txtDescripcion.Text.ToString
                If oclsMenu_DAL.Restaurar_Menus(obeMenu) = 1 Then
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
          obeMenu.PSMMCAPL_CodApl = _pbeMenu.PSMMCAPL_CodApl
          obeMenu.PSMMCMNU_CodMnu = _pbeMenu.PSMMCMNU_CodMnu
          If txtDescripcion.Text.ToString.Trim <> "" Then
            obeMenu.PSMMTMNU_DesMnu = txtDescripcion.Text.ToString.Trim
            If oclsMenu_DAL.Modificar_Menus(obeMenu) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
            Else
              Exit Sub
            End If
          Else
            MessageBox.Show("Falta ingresar: Descripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          End If
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    txtCodigo.Text = txtCodigo.Text.Trim
    If txtCodigo.Text.Trim = "" Then
      sbMensaje.AppendLine("* Código")
    End If
    If txtDescripcion.Text.Trim = "" Then
      sbMensaje.AppendLine("* Descripción")
    End If
    Return sbMensaje.ToString
  End Function

End Class

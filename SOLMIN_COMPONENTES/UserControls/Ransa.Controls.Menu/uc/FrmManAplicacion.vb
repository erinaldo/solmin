Imports System.Windows.Forms
Imports System.Text

Public Class FrmManAplicacion

  Private _pbeAplicacion As New beAplicacion
  Private _pEstado As New Estado

  Public Property pbeAplicacion() As beAplicacion
    Get
      Return _pbeAplicacion
    End Get
    Set(ByVal value As beAplicacion)
      _pbeAplicacion = value
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

  Private Sub MantenimientoAplicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      If _pEstado = Estado.Modificar Then
        txtCodigo.Enabled = False
      End If
      txtCodigo.Text = _pbeAplicacion.PSMMCAPL_CodApl
      txtDescripcion.Text = _pbeAplicacion.PSMMDAPL_DesApl
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
            Dim oclsAplicacion_DAL As New clsAplicacion_DAL
      Dim obeAplicacion As New beAplicacion
      Dim msgValidacion As String = Valida_Campos()
      Select Case _pEstado
        Case Estado.Nuevo
          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeAplicacion.PSMMCAPL_CodApl = txtCodigo.Text.ToString.Trim
            obeAplicacion.PSMMDAPL_DesApl = txtDescripcion.Text.ToString
            If oclsAplicacion_DAL.Registrar_Aplicaciones(obeAplicacion) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
            If oclsAplicacion_DAL.Registrar_Aplicaciones(obeAplicacion) = 0 Then
              MessageBox.Show("La aplicación ya esta creada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
              txtCodigo.Focus()
              Exit Sub
            End If
            If oclsAplicacion_DAL.Registrar_Aplicaciones(obeAplicacion) = 2 Then
              MessageBox.Show("La aplicación se encuentra deshabilitada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
              txtCodigo.Focus()
              Exit Sub
            End If
          End If
        Case Estado.Modificar
          txtCodigo.Enabled = True
          obeAplicacion.PSMMCAPL_CodApl = _pbeAplicacion.PSMMCAPL_CodApl
          If txtDescripcion.Text.ToString.Trim <> "" Then
            obeAplicacion.PSMMDAPL_DesApl = txtDescripcion.Text.ToString.Trim
            If oclsAplicacion_DAL.Modificar_Aplicaciones(obeAplicacion) = 1 Then
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

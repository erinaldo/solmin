Imports System.Windows.Forms
Imports System.Text

Public Class FrmManAccesoOpcion

  Private _pbeAccesoOpcion As New beAccesoOpcion

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

  Public Property pbeAccesoOpcion() As beAccesoOpcion
    Get
      Return _pbeAccesoOpcion
    End Get
    Set(ByVal value As beAccesoOpcion)
      _pbeAccesoOpcion = value
    End Set
  End Property

  Private Sub FrmManAccesoOpcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      If _pEstado = Estado.Modificar Then
        Uc_CboAplicacion1.pObtenerAplicacion(_pbeAccesoOpcion.PSMMCAPL)
        Uc_CboAplicacion1.Enabled = False
        Uc_CboMenu1.pObtenerMenu(_pbeAccesoOpcion.PSMMCAPL, _pbeAccesoOpcion.PSMMCMNU)
        Uc_CboMenu1.Enabled = False
        Uc_CboOpcion1.pObtenerOpcion(_pbeAccesoOpcion.PSMMCAPL, _pbeAccesoOpcion.PSMMCMNU, _pbeAccesoOpcion.PNMMCOPC)
        Uc_CboOpcion1.Enabled = False

        If _pbeAccesoOpcion.PSSTSVIS = "X" Then
          chkVisualizar.Checked = True
        Else
          chkVisualizar.Checked = False
        End If
        If _pbeAccesoOpcion.PSSTSADI = "X" Then
          chkAdicionar.Checked = True
        Else
          chkAdicionar.Checked = False
        End If
        If _pbeAccesoOpcion.PSSTSCHG = "X" Then
          chkCambiar.Checked = True
        Else
          chkCambiar.Checked = False
        End If
        If _pbeAccesoOpcion.PSSTSELI = "X" Then
          chkEliminar.Checked = True
        Else
          chkEliminar.Checked = False
        End If
        If _pbeAccesoOpcion.PSSTSOP1 = "X" Then
          chkOpcion1.Checked = True
        Else
          chkOpcion1.Checked = False
        End If
        If _pbeAccesoOpcion.PSSTSOP2 = "X" Then
          chkOpcion2.Checked = True
        Else
          chkOpcion2.Checked = False
        End If
        If _pbeAccesoOpcion.PSSTSOP3 = "X" Then
          chkOpcion3.Checked = True
        Else
          chkOpcion3.Checked = False
        End If

      End If
        txtUsuario.Enabled = False
        txtUsuario.Text = _pbeAccesoOpcion.PSMMCUSR
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Guardar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Try
      Dim oclsUsuario_DAL As New clsUsuario_DAL
      Dim obeAccesoOpcion As New beAccesoOpcion
      Dim msgValidacion As String = Valida_Campos()

      Select Case _pEstado
        Case Estado.Nuevo

          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeAccesoOpcion.PSMMCUSR = txtUsuario.Text.ToString.Trim
            obeAccesoOpcion.PSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
            obeAccesoOpcion.PSMMCMNU = Uc_CboMenu1.pPSMMCMNU
            obeAccesoOpcion.PNMMCOPC = Uc_CboOpcion1.pPSMMCOPC

            If chkVisualizar.Checked = True Then
              obeAccesoOpcion.PSSTSVIS = "X"
            End If
            If chkAdicionar.Checked = True Then
              obeAccesoOpcion.PSSTSADI = "X"
            End If
            If chkCambiar.Checked = True Then
              obeAccesoOpcion.PSSTSCHG = "X"
            End If
            If chkEliminar.Checked = True Then
              obeAccesoOpcion.PSSTSELI = "X"
            End If

            If chkOpcion1.Checked = True Then
              obeAccesoOpcion.PSSTSOP1 = "X"
            End If
            If chkOpcion2.Checked = True Then
              obeAccesoOpcion.PSSTSOP2 = "X"
            End If
            If chkOpcion3.Checked = True Then
              obeAccesoOpcion.PSSTSOP3 = "X"
            End If

            If oclsUsuario_DAL.Registrar_Opciones_X_Usuario(obeAccesoOpcion) = 1 Or oclsUsuario_DAL.Registrar_Opciones_X_Usuario(obeAccesoOpcion) = 0 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
          End If
        Case Estado.Modificar

          obeAccesoOpcion.PSMMCUSR = txtUsuario.Text.ToString.Trim
          obeAccesoOpcion.PSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
          obeAccesoOpcion.PSMMCMNU = Uc_CboMenu1.pPSMMCMNU
          obeAccesoOpcion.PNMMCOPC = Uc_CboOpcion1.pPSMMCOPC

          If chkVisualizar.Checked = True Then
            obeAccesoOpcion.PSSTSVIS = "X"
          End If
          If chkAdicionar.Checked = True Then
            obeAccesoOpcion.PSSTSADI = "X"
          End If
          If chkCambiar.Checked = True Then
            obeAccesoOpcion.PSSTSCHG = "X"
          End If
          If chkEliminar.Checked = True Then
            obeAccesoOpcion.PSSTSELI = "X"
          End If

          If chkOpcion1.Checked = True Then
            obeAccesoOpcion.PSSTSOP1 = "X"
          End If
          If chkOpcion2.Checked = True Then
            obeAccesoOpcion.PSSTSOP2 = "X"
          End If
          If chkOpcion3.Checked = True Then
            obeAccesoOpcion.PSSTSOP3 = "X"
          End If
          
          If oclsUsuario_DAL.Modificar_Opciones_X_Usuario(obeAccesoOpcion) = 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
          End If

      End Select
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

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    txtUsuario.Text = txtUsuario.Text.Trim
    If Uc_CboAplicacion1.pPSMMCAPL = "" Then
      sbMensaje.AppendLine("* Aplicación")
    End If
    If Uc_CboMenu1.pPSMMCMNU = "" Then
      sbMensaje.AppendLine("* Menú")
    End If
    If Uc_CboOpcion1.pPSMMCOPC = Nothing Then
      sbMensaje.AppendLine("* Opción")
    End If
    Return sbMensaje.ToString
  End Function

  Private Sub Cambiar_Aplicacion() Handles Uc_CboAplicacion1.InformationChanged
    Try
      Uc_CboMenu1.pPSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
      Uc_CboMenu1.pClear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cambiar_Menu() Handles Uc_CboMenu1.InformationChanged
    Try
      Uc_CboOpcion1.pPSMMCAPL = Uc_CboMenu1.pPSMMCAPL
      Uc_CboOpcion1.pPSMMCMNU = Uc_CboMenu1.pPSMMCMNU
      Uc_CboOpcion1.pClear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class

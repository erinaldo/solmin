
Imports System.Windows.Forms
Imports System.Text

Public Class frmManUserOption

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

      txtAplicacion.Text = pbeAccesoOpcion.DES_APLC
      txtMenu.Text = pbeAccesoOpcion.DES_MENU
      txtOpcion.Text = pbeAccesoOpcion.DES_OPCN

      If _pEstado = Estado.Modificar Then

        Uc_CboUsuario1.Enabled = False
        Uc_CboUsuario1.pObtenerUsuario(pbeAccesoOpcion.PSMMCUSR)
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

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Guardar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Try
      Dim oclsUsuario_DAL As New clsUsuario_DAL
      Dim obeAccesoOpcion As New beAccesoOpcion

      Select Case _pEstado
        Case Estado.Nuevo

          If Uc_CboUsuario1.pPSMMCUSR.Trim.Length = 0 Then
            MessageBox.Show("Seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeAccesoOpcion.PSMMCUSR = Uc_CboUsuario1.pPSMMCUSR
            obeAccesoOpcion.PSMMCAPL = _pbeAccesoOpcion.PSMMCAPL
            obeAccesoOpcion.PSMMCMNU = _pbeAccesoOpcion.PSMMCMNU
            obeAccesoOpcion.PNMMCOPC = _pbeAccesoOpcion.PNMMCOPC

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

          obeAccesoOpcion.PSMMCUSR = Uc_CboUsuario1.pPSMMCUSR
          obeAccesoOpcion.PSMMCAPL = _pbeAccesoOpcion.PSMMCAPL
          obeAccesoOpcion.PSMMCMNU = _pbeAccesoOpcion.PSMMCMNU
          obeAccesoOpcion.PNMMCOPC = _pbeAccesoOpcion.PNMMCOPC

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

End Class




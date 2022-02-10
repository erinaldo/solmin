
Imports System.Windows.Forms
Public Class uc_CboUsuario
#Region " Definición Eventos "
  Public Shadows Event InformationChanged()
  Public Shadows Event TextChanged()
  Public Shadows Event ExitFocusWithOutData()
#End Region

#Region " Atributos "
  '-------------------------------------------------
  ' Manejador de la Información
  '-------------------------------------------------
  ' Almacenamiento de Información
  '-------------------------------------------------
  Private oInf_CboUsuario As New beUsuario_InfoUC
  Private oQry_CboUsuario As New beUsuario_InfoUC
  'Private obeTransportista As New CboUsuario_BE()

  Private sErrorMessage As String = ""
  Private verPop As Boolean = False
  '-------------------------------------------------
  ' Información del Estado
  '-------------------------------------------------
  Private bIsRequired As Boolean = False
  '-------------------------------------------------
  ' Datos de Seguridad 
  '-------------------------------------------------
  'Private pUsuario As String = ""

#End Region
#Region " Propiedades "

  Private obeUsuarioUC As New beUsuarioUC
  
  Public Property pPSMMCUSR() As String
    Get
      Return oInf_CboUsuario.PSMMCUSR
    End Get
    Set(ByVal value As String)
      oInf_CboUsuario.PSMMCUSR = value
    End Set
  End Property

  Public Property pPSMMNUSR() As String
    Get
      Return oInf_CboUsuario.PSMMNUSR
    End Get
    Set(ByVal value As String)
      oInf_CboUsuario.PSMMNUSR = value
    End Set
  End Property

#End Region
  Private Sub uc_CboAplicacion_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
    Try
      txtUsuario.Text = oInf_CboUsuario.PSMMNUSR
      txtUsuario.SelectAll()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub uc_cbo_Usuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
    Try
      Select Case e.KeyCode
        Case Keys.Escape
          txtUsuario.Text = (oInf_CboUsuario.PSMMNUSR).Trim
          txtUsuario.SelectAll()
        Case Keys.Enter
          If txtUsuario.Text.Trim = Nothing Then
            oInf_CboUsuario.pClear()
          Else
            If txtUsuario.Text.ToUpper.Trim <> oInf_CboUsuario.PSMMNUSR.ToUpper Then
              Call BusquedaCboUsuario()
            Else
              txtUsuario.SelectAll()
            End If
          End If

        Case Keys.F4
          Call BusquedaCboUsuario()
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cbo_Usuario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.Validated
    Try
      If oInf_CboUsuario.PSMMNUSR <> "" Then
        txtUsuario.Text = oInf_CboUsuario.PSMMCUSR & " - " & oInf_CboUsuario.PSMMNUSR
      Else
        txtUsuario.Text = Nothing
        oInf_CboUsuario.pClear()
        RaiseEvent ExitFocusWithOutData()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
  Private Sub Cbo_Usuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
    Try
      If txtUsuario.Text = "" Then
        oInf_CboUsuario.pClear()
      Else

        If txtUsuario.Text.Trim.Contains(".") Or txtUsuario.Text.Trim.Contains(" ") Or txtUsuario.Text.Trim.Length > 10 Then
          If txtUsuario.Text.ToUpper.Trim <> oInf_CboUsuario.PSMMNUSR.ToUpper.Trim Then e.Cancel = BusquedaCboUsuario()
        Else
          If txtUsuario.Text.Trim <> oInf_CboUsuario.PSMMCUSR Then e.Cancel = BusquedaCboUsuario()
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function BusquedaCboUsuario() As Boolean
    Dim oFiltroUsuario As New beUsuario_InfoUC
    oQry_CboUsuario.pClear()
    oFiltroUsuario.pClear()
    oQry_CboUsuario.PageSize = 20
    oQry_CboUsuario.PageNumber = 1


    If txtUsuario.Text.Trim = "" Then
      oQry_CboUsuario.PSMMCUSR = ""
      oFiltroUsuario.PSMMCUSR = ""
      oQry_CboUsuario.PSMMNUSR = ""
      oFiltroUsuario.PSMMNUSR = ""
    Else
      If txtUsuario.Text.Trim.Contains(".") Or txtUsuario.Text.Trim.Contains(" ") Or txtUsuario.Text.Trim.Length > 10 Then

        If txtUsuario.Text.Trim = (oInf_CboUsuario.PSMMNUSR).ToUpper.Trim Then
          oQry_CboUsuario.PSMMCUSR = ""
          oFiltroUsuario.PSMMCUSR = ""
          oQry_CboUsuario.PSMMNUSR = ""
          oFiltroUsuario.PSMMNUSR = ""
        Else
          oQry_CboUsuario.PSMMNUSR = txtUsuario.Text.ToString
          oFiltroUsuario.PSMMNUSR = txtUsuario.Text.ToString
          oQry_CboUsuario.PSMMCUSR = ""
          oFiltroUsuario.PSMMCUSR = ""
        End If

      Else
        oQry_CboUsuario.PSMMCUSR = txtUsuario.Text.ToString
        oFiltroUsuario.PSMMCUSR = txtUsuario.Text.ToString
        oQry_CboUsuario.PSMMNUSR = ""
        oFiltroUsuario.PSMMNUSR = ""
      End If
    End If

    Dim blnCancelar As Boolean = False
    Try
      Dim oCboUsuario As New List(Of beUsuarioUC)
      Dim oblCboUsuario As New ucUsuario_DAL
      oCboUsuario = oblCboUsuario.ListarUsuario(oQry_CboUsuario)

      If oCboUsuario.Count = 0 Then
        txtUsuario.Text = oInf_CboUsuario.PSMMNUSR
        txtUsuario.SelectAll()
        blnCancelar = True
        RaiseEvent InformationChanged()
      Else
        If oCboUsuario.Count = 1 Then
          oInf_CboUsuario.PSMMCUSR = oCboUsuario.Item(0).PSMMCUSR
          oInf_CboUsuario.PSMMNUSR = oCboUsuario.Item(0).PSMMNUSR
          RaiseEvent InformationChanged()
        Else
          Dim fbusqueda As New UC_Frm_CboUsuario
          fbusqueda.oListInicialCboUsuario = oCboUsuario
          fbusqueda.oFiltroCboUsuario = oFiltroUsuario
          fbusqueda.ShowDialog(Me)
          If fbusqueda.pSeleccionUsuario.PSMMCUSR <> "" Then
            oInf_CboUsuario.PSMMCUSR = fbusqueda.pSeleccionUsuario.PSMMCUSR
            oInf_CboUsuario.PSMMNUSR = fbusqueda.pSeleccionUsuario.PSMMNUSR
            RaiseEvent InformationChanged()
          End If
        End If
        txtUsuario.Text = oInf_CboUsuario.PSMMNUSR
        txtUsuario.SelectAll()
        RaiseEvent TextChanged()
      End If

    Catch ex As Exception
    End Try
    Return blnCancelar
  End Function

  Public Sub pClear()
    txtUsuario.Text = ""
    oInf_CboUsuario.pClear()
  End Sub

  Private Sub bsaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUsuario.Click
    Try
      txtUsuario.Focus()
      Call BusquedaCboUsuario()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub pObtenerUsuario(ByVal PSMMCUSR As String)
    Dim obeCboUsuario As New beUsuarioUC
    Dim oListobeCboUsuario As New List(Of beUsuarioUC)
    Dim oblUsuario As New ucUsuario_DAL
    Dim oQueryoblUsuario As New beUsuario_InfoUC

    oQueryoblUsuario.PSMMCUSR = PSMMCUSR
    oQueryoblUsuario.PSMMNUSR = txtUsuario.Text
    oQueryoblUsuario.PageSize = 20
    oQueryoblUsuario.PageNumber = 1
    oListobeCboUsuario = oblUsuario.ListarUsuario(oQueryoblUsuario)
    If (oListobeCboUsuario.Count > 0) Then
      obeCboUsuario = oListobeCboUsuario(0)
      With oInf_CboUsuario
        .PSMMCUSR = obeCboUsuario.PSMMCUSR
        .PSMMNUSR = obeCboUsuario.PSMMNUSR
      End With
      If Me.Focused Then
        txtUsuario.Text = oInf_CboUsuario.PSMMNUSR
        txtUsuario.SelectAll()
      Else
        If oInf_CboUsuario.PSMMCUSR <> "" And oInf_CboUsuario.PSMMNUSR <> "" Then
          txtUsuario.Text = oInf_CboUsuario.PSMMCUSR & " - " & oInf_CboUsuario.PSMMNUSR
        Else
          txtUsuario.Text = ""
        End If
      End If
    Else
      txtUsuario.Text = ""
      oInf_CboUsuario.pClear()
    End If
  End Sub
End Class

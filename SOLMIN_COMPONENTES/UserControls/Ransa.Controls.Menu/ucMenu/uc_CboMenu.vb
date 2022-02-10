Imports System.Windows.Forms
Public Class uc_CboMenu
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
  Private oInf_CboMenu As New beMenu_InfoUC
  Private oQry_CboMenu As New beMenu_InfoUC
  'Private obeTransportista As New CboMenu_BE()

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

  Private obeMenuUC As New beMenuUC
  'codigo de aplicacion externo
  Public Property pPSMMCAPL() As String
    Get
      Return obeMenuUC.PSMMCAPL
    End Get
    Set(ByVal value As String)
      obeMenuUC.PSMMCAPL = value
    End Set
  End Property

  Public ReadOnly Property pPSMMCMNU() As String
    Get
      Return (oInf_CboMenu.PSMMCMNU)
    End Get
  End Property

  Public ReadOnly Property pPSMMTMNU() As String
    Get
      Return (oInf_CboMenu.PSMMTMNU)
    End Get
  End Property

#End Region
  Private Sub uc_CboAplicacion_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMenu.GotFocus
    Try
      txtMenu.Text = oInf_CboMenu.PSMMTMNU
      txtMenu.SelectAll()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub uc_cbo_Menu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMenu.KeyDown
    Try
      Select Case e.KeyCode
        Case Keys.Escape
          txtMenu.Text = (oInf_CboMenu.PSMMTMNU).Trim
          txtMenu.SelectAll()
        Case Keys.Enter
          If txtMenu.Text.Trim = "" Then
            oInf_CboMenu.pClear()
          Else
            If txtMenu.Text.ToUpper.Trim <> oInf_CboMenu.PSMMTMNU.ToUpper Then
              Call BusquedaCboMenu()
            Else
              txtMenu.SelectAll()
            End If
          End If

        Case Keys.F4
          Call BusquedaCboMenu()
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cbo_Menu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMenu.Validated
    Try
      If oInf_CboMenu.PSMMCMNU <> "" Then
        txtMenu.Text = oInf_CboMenu.PSMMCMNU & " - " & oInf_CboMenu.PSMMTMNU
      Else
        txtMenu.Text = ""
        oInf_CboMenu.pClear()
        RaiseEvent ExitFocusWithOutData()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
  Private Sub Cbo_Menu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMenu.Validating
    Try
      If txtMenu.Text = "" Then
        oInf_CboMenu.pClear()
      Else
        If txtMenu.Text.Trim.Length <= 2 Then
          If txtMenu.Text.Trim <> oInf_CboMenu.PSMMCMNU Then e.Cancel = BusquedaCboMenu()
        Else
          If txtMenu.Text.ToUpper.Trim <> oInf_CboMenu.PSMMTMNU.ToUpper.Trim Then e.Cancel = BusquedaCboMenu()
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function BusquedaCboMenu() As Boolean
    Dim oFiltroMenu As New beMenu_InfoUC
    oQry_CboMenu.pClear()
    oFiltroMenu.pClear()
    oQry_CboMenu.PageSize = 20
    oQry_CboMenu.PageNumber = 1

    If txtMenu.Text.Trim = "" Then
      oQry_CboMenu.PSMMCMNU = ""
      oFiltroMenu.PSMMCMNU = ""
      oQry_CboMenu.PSMMTMNU = ""
      oFiltroMenu.PSMMTMNU = ""
    Else
      If txtMenu.Text.Length <= 2 Then
        oQry_CboMenu.PSMMCMNU = txtMenu.Text.ToString
        oFiltroMenu.PSMMCMNU = txtMenu.Text.ToString

      End If
      If txtMenu.Text.Length > 2 Then
        If txtMenu.Text.Trim = (oInf_CboMenu.PSMMTMNU).ToUpper.Trim Then
          oQry_CboMenu.PSMMTMNU = ""
          oFiltroMenu.PSMMTMNU = ""
          oQry_CboMenu.PSMMCMNU = ""
          oFiltroMenu.PSMMCMNU = ""
        Else
          oQry_CboMenu.PSMMTMNU = txtMenu.Text.ToString
          oFiltroMenu.PSMMTMNU = txtMenu.Text.ToString
        End If
      End If
    End If

    Dim blnCancelar As Boolean = False
    oQry_CboMenu.PSMMCAPL = obeMenuUC.PSMMCAPL
    Try
      Dim oCboMenu As New List(Of beMenuUC)
      Dim oblCboMenu As New ucMenu_DAL
      oCboMenu = oblCboMenu.ListarMenu(oQry_CboMenu)

      If oCboMenu.Count = 0 Then
        txtMenu.Text = oInf_CboMenu.PSMMTMNU
        txtMenu.SelectAll()
        blnCancelar = True
        RaiseEvent InformationChanged()
      Else
        If oCboMenu.Count = 1 Then
          oInf_CboMenu.PSMMCAPL = oCboMenu.Item(0).PSMMCAPL
          oInf_CboMenu.PSMMCMNU = oCboMenu.Item(0).PSMMCMNU
          oInf_CboMenu.PSMMTMNU = oCboMenu.Item(0).PSMMTMNU
          RaiseEvent InformationChanged()
        Else
          Dim fbusqueda As New UC_Frm_CboMenu
          fbusqueda.oListInicialCboMenu = oCboMenu
          fbusqueda.oFiltroCboMenu = oFiltroMenu
          fbusqueda.pSeleccionMenu.PSMMCAPL = obeMenuUC.PSMMCAPL
          fbusqueda.ShowDialog(Me)
          If fbusqueda.pSeleccionMenu.PSMMCMNU <> "" Then
            oInf_CboMenu.PSMMCAPL = fbusqueda.pSeleccionMenu.PSMMCAPL
            oInf_CboMenu.PSMMCMNU = fbusqueda.pSeleccionMenu.PSMMCMNU
            oInf_CboMenu.PSMMTMNU = fbusqueda.pSeleccionMenu.PSMMTMNU
            RaiseEvent InformationChanged()
          End If
        End If
        txtMenu.Text = oInf_CboMenu.PSMMTMNU
        txtMenu.SelectAll()
        RaiseEvent TextChanged()
      End If

    Catch ex As Exception
    End Try
    Return blnCancelar
  End Function

  Public Sub pClear()
    txtMenu.Text = ""
    oInf_CboMenu.pClear()
  End Sub

  Private Sub bsaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaMenu.Click
    Try
      txtMenu.Focus()
      'txtMenu.Text = ""
      Call BusquedaCboMenu()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub pObtenerMenu(ByVal PSMMCAPL As String, ByVal PSMMCMNU As String)
    Dim obeCboMenu As New beMenuUC
    Dim oListobeCboMenu As New List(Of beMenuUC)
    Dim oblMenu As New ucMenu_DAL
    Dim oQueryoblMenu As New beMenu_InfoUC
    oQueryoblMenu.PSMMCAPL = PSMMCAPL
    oQueryoblMenu.PSMMCMNU = PSMMCMNU
    oQueryoblMenu.PSMMTMNU = txtMenu.Text
    oQueryoblMenu.PageSize = 20
    oQueryoblMenu.PageNumber = 1
    oListobeCboMenu = oblMenu.ListarMenu(oQueryoblMenu)
    If (oListobeCboMenu.Count > 0) Then
      obeCboMenu = oListobeCboMenu(0)
      With oInf_CboMenu
        .PSMMCAPL = obeCboMenu.PSMMCAPL
        .PSMMCMNU = obeCboMenu.PSMMCMNU
        .PSMMTMNU = obeCboMenu.PSMMTMNU
      End With
      If Me.Focused Then
        txtMenu.Text = oInf_CboMenu.PSMMTMNU
        txtMenu.SelectAll()
      Else
        If oInf_CboMenu.PSMMCAPL <> "" And oInf_CboMenu.PSMMCMNU <> "" Then
          txtMenu.Text = oInf_CboMenu.PSMMCMNU & " - " & oInf_CboMenu.PSMMTMNU
        Else
          txtMenu.Text = ""
        End If
      End If
    Else
      txtMenu.Text = ""
      oInf_CboMenu.pClear()
    End If
  End Sub
End Class

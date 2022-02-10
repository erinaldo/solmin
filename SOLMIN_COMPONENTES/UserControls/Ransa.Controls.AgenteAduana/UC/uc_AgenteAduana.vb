Imports System.Windows.Forms
Public Class uc_AgenteAduana
#Region " Definición Eventos "
  Public Shadows Event InformationChanged()
  Public Shadows Event TextChanged()
  Public Shadows Event ExitFocusWithOutData()
#End Region

#Region " Atributos "
  '-------------------------------------------------
  ' Manejador de la Información
  '-------------------------------------------------
  ' Private oTransportista As New AgenteAduana_BE
  '-------------------------------------------------
  ' Almacenamiento de Información
  '-------------------------------------------------
  Private oInf_AgenteAduana As New AgenteAduana_Info_BE
  Private oQry_AgenteAduana As New AgenteAduana_Info_BE
  'Private obeTransportista As New AgenteAduana_BE()

  Private sErrorMessage As String = ""
  Private verPop As Boolean = False
  '-------------------------------------------------
  ' Información del Estado
  '-------------------------------------------------
  Private bIsRequired As Boolean = False
  '-------------------------------------------------
  ' Datos de Seguridad 
  '-------------------------------------------------
  Private pUsuario As String = ""

#End Region
#Region " Propiedades "

  Public ReadOnly Property pCAGNAD() As Decimal
    Get
      Return (oInf_AgenteAduana.PNCAGNAD)
    End Get
  End Property

  'Public ReadOnly Property pPSNRUCTR() As String
  '  Get
  '    Return (oInf_Transportista.PSNRUCTR)
  '  End Get

  'End Property
  Public ReadOnly Property pTCMAA() As String
    Get
      Return (oInf_AgenteAduana.PSTCMAA)
    End Get
  End Property

  Public WriteOnly Property pPSCULUSA() As String
    Set(ByVal value As String)
      pUsuario = value
    End Set
  End Property

#End Region
  Private Sub Agente_Aduana_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAgenteAduana.GotFocus
    Try
      txtAgenteAduana.Text = oInf_AgenteAduana.PSTCMAA
      txtAgenteAduana.SelectAll()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Agente_Aduana_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAgenteAduana.KeyDown
    Select Case e.KeyCode
      Case Keys.Escape
        txtAgenteAduana.Text = oInf_AgenteAduana.PSTCMAA
        txtAgenteAduana.SelectAll()
      Case Keys.Enter
        ' Busca segun los ingresado sino muestra todo
        If (txtAgenteAduana.Text.ToUpper.Trim = "") Then
          oInf_AgenteAduana.pClear()
        Else
          If txtAgenteAduana.Text.ToUpper.Trim <> oInf_AgenteAduana.PSTCMAA.ToUpper Then
            Call BusquedaAgenteAduana()
          Else
            txtAgenteAduana.SelectAll()
          End If
        End If

      Case Keys.F4
        Call BusquedaAgenteAduana()
    End Select


  End Sub
  Private Sub Agente_Aduana_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAgenteAduana.Validated

    If oInf_AgenteAduana.PNCAGNAD <> 0 Then
      txtAgenteAduana.Text = oInf_AgenteAduana.PNCAGNAD & " - " & oInf_AgenteAduana.PSTCMAA
    Else
      txtAgenteAduana.Text = ""
      oInf_AgenteAduana.pClear()
      RaiseEvent ExitFocusWithOutData()
    End If

  End Sub
  Private Sub Agente_Aduana_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAgenteAduana.Validating
    If txtAgenteAduana.Text = "" Then
      oInf_AgenteAduana.pClear()
    Else
      If IsNumeric(txtAgenteAduana.Text.Trim) Then
        If txtAgenteAduana.Text.Trim <> oInf_AgenteAduana.PNCAGNAD Then e.Cancel = BusquedaAgenteAduana()
      Else
        If txtAgenteAduana.Text.ToUpper.Trim <> oInf_AgenteAduana.PSTCMAA.ToUpper.Trim Then e.Cancel = BusquedaAgenteAduana()
      End If
      If txtAgenteAduana.Text.ToUpper.Trim <> oInf_AgenteAduana.PSTCMAA.ToUpper.Trim Then e.Cancel = BusquedaAgenteAduana()
    End If

  End Sub
  Private Function BusquedaAgenteAduana() As Boolean
    Dim oFiltroAgenteAduana As New AgenteAduana_Info_BE
    oQry_AgenteAduana.pClear()
    oFiltroAgenteAduana.pClear()
    oQry_AgenteAduana.PageSize = 20
    oQry_AgenteAduana.PageNumber = 1
    If IsNumeric(txtAgenteAduana.Text.Trim) Then
      If txtAgenteAduana.Text.Trim.Length <= 6 Then
        oQry_AgenteAduana.PNCAGNAD = txtAgenteAduana.Text.Trim
        oQry_AgenteAduana.PSBUSQUEDA = "C" ' BUSQUEDA POR CODIGO
        oFiltroAgenteAduana.PNCAGNAD = txtAgenteAduana.Text.Trim
      End If
      If txtAgenteAduana.Text.Length > 6 Then
        oQry_AgenteAduana.PSTCMAA = txtAgenteAduana.Text.Trim
        oQry_AgenteAduana.PSBUSQUEDA = "" 'SIN CRITERIO
        oFiltroAgenteAduana.PSTCMAA = txtAgenteAduana.Text.Trim
      End If
    Else
      oQry_AgenteAduana.PSTCMAA = txtAgenteAduana.Text.Trim
      oQry_AgenteAduana.PSBUSQUEDA = "" 'SIN CRITERIO
      oFiltroAgenteAduana.PSTCMAA = txtAgenteAduana.Text.Trim
    End If
    If Not IsNumeric(txtAgenteAduana.Text) Then
      If txtAgenteAduana.Text.ToUpper.Trim = oInf_AgenteAduana.PSTCMAA.ToUpper Then
        oQry_AgenteAduana.PSTCMAA = ""
        oQry_AgenteAduana.PSBUSQUEDA = "" 'SIN CRITERIO
        oFiltroAgenteAduana.PSTCMAA = ""
      End If
    End If

    Dim blnCancelar As Boolean = False
    Try
      Dim oListaAgenteAduana As New List(Of AgenteAduana_BE)
      Dim oblAgenteAduana As New AgenteAduana_BLL
      oListaAgenteAduana = oblAgenteAduana.ListarAgenteAduana(oQry_AgenteAduana)

      If oListaAgenteAduana.Count = 0 Then
        txtAgenteAduana.Text = oInf_AgenteAduana.PSTCMAA
        txtAgenteAduana.SelectAll()
        blnCancelar = True
        RaiseEvent InformationChanged()
      Else
        If oListaAgenteAduana.Count = 1 Then
          oInf_AgenteAduana.PNCAGNAD = oListaAgenteAduana.Item(0).PNCAGNAD
          oInf_AgenteAduana.PSTCMAA = oListaAgenteAduana.Item(0).PSTCMAA
          'oInf_Transportista.PSNRUCTR = oListaTransportista.Item(0).PSNRUCTR
          RaiseEvent InformationChanged()

        Else

          Dim fbusqueda As New uc_Frm_AgenteAduana()
          fbusqueda.oListInicialAgenteAduana = oListaAgenteAduana
          fbusqueda.oFiltroAgenteAduana = oFiltroAgenteAduana
          fbusqueda.ShowDialog(Me)
          If fbusqueda.pSeleccion.PNCAGNAD <> 0 Then
            oInf_AgenteAduana.PNCAGNAD = fbusqueda.pSeleccion.PNCAGNAD
            oInf_AgenteAduana.PSTCMAA = fbusqueda.pSeleccion.PSTCMAA
            'oInf_Transportista.PSNRUCTR = fbusqueda.pSeleccion.PSNRUCTR
            RaiseEvent InformationChanged()
          End If


        End If
        txtAgenteAduana.Text = oInf_AgenteAduana.PSTCMAA
        txtAgenteAduana.SelectAll()
        RaiseEvent TextChanged()
      End If

    Catch ex As Exception
    End Try
    Return blnCancelar
  End Function

  Public Sub pClear()
    txtAgenteAduana.Text = ""
    oInf_AgenteAduana.pClear()
  End Sub

  Private Sub bsaAgenteAduana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAgenciaAduana.Click

    txtAgenteAduana.Focus()
    Call BusquedaAgenteAduana()

  End Sub

  Public Sub pObtenerAgenteAduana(ByVal PNCAGNAD As Decimal)
    Dim obeAgenteAduana As New AgenteAduana_BE
    Dim oListobeAgenteAduana As New List(Of AgenteAduana_BE)
    Dim oblAgenteAduana As New AgenteAduana_BLL
    Dim oQueryoblAgenteAduana As New AgenteAduana_Info_BE
    oQueryoblAgenteAduana.PSBUSQUEDA = "C"
    oQueryoblAgenteAduana.PNCAGNAD = PNCAGNAD
    oQueryoblAgenteAduana.PageSize = 20
    oQueryoblAgenteAduana.PageNumber = 1
    oListobeAgenteAduana = oblAgenteAduana.ListarAgenteAduana(oQueryoblAgenteAduana)
    If (oListobeAgenteAduana.Count > 0) Then
      obeAgenteAduana = oListobeAgenteAduana(0)
      With oInf_AgenteAduana
        .PNCAGNAD = obeAgenteAduana.PNCAGNAD
        '.PSNRUCTR = obeTransportista.PSNRUCTR
        .PSTCMAA = obeAgenteAduana.PSTCMAA
      End With
      If Me.Focused Then
        txtAgenteAduana.Text = oInf_AgenteAduana.PSTCMAA
        txtAgenteAduana.SelectAll()
      Else
        If oInf_AgenteAduana.PNCAGNAD <> 0 Then
          txtAgenteAduana.Text = oInf_AgenteAduana.PNCAGNAD & " - " & oInf_AgenteAduana.PSTCMAA
        Else
          txtAgenteAduana.Text = ""
        End If
      End If
    Else
      txtAgenteAduana.Text = ""
      oInf_AgenteAduana.pClear()
    End If
  End Sub
End Class

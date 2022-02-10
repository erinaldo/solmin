Imports System.Windows.Forms

Public Class uc_CboAplicacion

#Region " Definición Eventos "
  Public Event pSelectionPSMMCAPL()
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
  Private oInf_CboAplicacion As New beAplicacionInfoUC
  Private oQry_CboAplicacion As New beAplicacionInfoUC
  'Private obeTransportista As New CboAplicacion_BE()
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

  Public ReadOnly Property pPSMMCAPL() As String
    Get
      Return (oInf_CboAplicacion.PSMMCAPL)
    End Get
  End Property

  Public ReadOnly Property pPSMMDAPL() As String
    Get
      Return (oInf_CboAplicacion.PSMMDAPL)
    End Get
  End Property

#End Region
  Private Sub uc_CboAplicacion_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAplicacion.GotFocus
    Try
      txtAplicacion.Text = (oInf_CboAplicacion.PSMMDAPL).Trim
      txtAplicacion.SelectAll()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub uc_cbo_Aplicacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAplicacion.KeyDown
    Try
      Select Case e.KeyCode
        Case Keys.Escape
          txtAplicacion.Text = (oInf_CboAplicacion.PSMMDAPL).Trim
          txtAplicacion.SelectAll()
        Case Keys.Enter
          If txtAplicacion.Text.ToUpper.Trim = "" Then
            oInf_CboAplicacion.pClear()
          Else
            If txtAplicacion.Text.ToUpper.Trim <> oInf_CboAplicacion.PSMMDAPL.ToUpper.Trim Then
              Call BusquedaCboAplicacion()
            Else
              txtAplicacion.SelectAll()
            End If
          End If
        Case Keys.F4
          Call BusquedaCboAplicacion()
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cbo_Aplicacion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAplicacion.Validated
    Try
      If oInf_CboAplicacion.PSMMCAPL <> "" Then  'si encontro el registro, lo muestra: codigo - descripción
        txtAplicacion.Text = (oInf_CboAplicacion.PSMMCAPL).Trim & " - " & (oInf_CboAplicacion.PSMMDAPL).Trim
      Else
        txtAplicacion.Text = ""
        oInf_CboAplicacion.pClear()
        RaiseEvent ExitFocusWithOutData()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cbo_Aplicacion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAplicacion.Validating
    Try
      If txtAplicacion.Text = "" Then
        oInf_CboAplicacion.pClear()
      Else
        If txtAplicacion.Text.Trim.Length <= 2 Then 'si es codigo
          If txtAplicacion.Text.Trim <> oInf_CboAplicacion.PSMMCAPL Then e.Cancel = BusquedaCboAplicacion()
        Else                                        'si es descripción
          If txtAplicacion.Text.ToUpper.Trim <> oInf_CboAplicacion.PSMMDAPL.ToUpper.Trim Then e.Cancel = BusquedaCboAplicacion()
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function BusquedaCboAplicacion() As Boolean
    Dim oFiltroAplicacion As New beAplicacionInfoUC
    oQry_CboAplicacion.pClear()
    oFiltroAplicacion.pClear()
    oQry_CboAplicacion.PageSize = 20
    oQry_CboAplicacion.PageNumber = 1

    If txtAplicacion.Text.Trim = "" Then
      oQry_CboAplicacion.PSMMCAPL = ""
      oFiltroAplicacion.PSMMCAPL = ""
      oQry_CboAplicacion.PSMMDAPL = ""
      oFiltroAplicacion.PSMMDAPL = ""
    Else
      If txtAplicacion.Text.Length <= 2 Then
        oQry_CboAplicacion.PSMMCAPL = txtAplicacion.Text.ToString
        oFiltroAplicacion.PSMMCAPL = txtAplicacion.Text.ToString
      End If
      If txtAplicacion.Text.Length > 2 Then
        If txtAplicacion.Text.Trim = (oInf_CboAplicacion.PSMMDAPL).Trim Then
          oQry_CboAplicacion.PSMMDAPL = ""
          oFiltroAplicacion.PSMMDAPL = ""
          oQry_CboAplicacion.PSMMCAPL = ""
          oFiltroAplicacion.PSMMCAPL = ""
        Else
          oQry_CboAplicacion.PSMMDAPL = txtAplicacion.Text.ToString
          oFiltroAplicacion.PSMMDAPL = txtAplicacion.Text.ToString
        End If
      End If
    End If

      Dim blnCancelar As Boolean = False
      Try
        Dim oCboAplicacion As New List(Of beAplicacionUc)
        Dim oucAplicacion_DAL As New ucAplicacion_DAL
        oCboAplicacion = oucAplicacion_DAL.ListarAplicacion(oQry_CboAplicacion)

        If oCboAplicacion.Count = 0 Then
          txtAplicacion.Text = oInf_CboAplicacion.PSMMDAPL
          txtAplicacion.SelectAll()
          blnCancelar = True
          RaiseEvent InformationChanged()
        Else
          If oCboAplicacion.Count = 1 Then
            oInf_CboAplicacion.PSMMCAPL = oCboAplicacion.Item(0).PSMMCAPL
            oInf_CboAplicacion.PSMMDAPL = oCboAplicacion.Item(0).PSMMDAPL
            RaiseEvent InformationChanged()
          Else
            Dim fbusqueda As New UC_Frm_CboAplicacion
            fbusqueda.oListInicialCboAplicacion = oCboAplicacion
            fbusqueda.oFiltroCboAplicacion = oFiltroAplicacion
            fbusqueda.ShowDialog(Me)
            If fbusqueda.pSeleccion.PSMMCAPL <> "" Then
              oInf_CboAplicacion.PSMMCAPL = fbusqueda.pSeleccion.PSMMCAPL
              oInf_CboAplicacion.PSMMDAPL = fbusqueda.pSeleccion.PSMMDAPL
              RaiseEvent InformationChanged()
            End If

          End If
          txtAplicacion.Text = oInf_CboAplicacion.PSMMDAPL
          txtAplicacion.SelectAll()
          RaiseEvent TextChanged()
        End If

      Catch ex As Exception
      End Try
      Return blnCancelar
  End Function

  Public Sub pClear()
    txtAplicacion.Text = ""
    oInf_CboAplicacion.pClear()
  End Sub

  Private Sub bsaAplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAplicacion.Click
    Try
      txtAplicacion.Focus()
      Call BusquedaCboAplicacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub pObtenerAplicacion(ByVal PSMMCAPL As String)
    Dim obeCboAplicacion As New beAplicacionUc
    Dim oListobeCboApplicacion As New List(Of beAplicacionUc)
    Dim oblAgenteAduana As New ucAplicacion_DAL
    Dim oQueryoblAgenteAduana As New beAplicacionInfoUC
    oQueryoblAgenteAduana.PSMMCAPL = PSMMCAPL
    oQueryoblAgenteAduana.PageSize = 20
    oQueryoblAgenteAduana.PageNumber = 1
    oListobeCboApplicacion = oblAgenteAduana.ListarAplicacion(oQueryoblAgenteAduana)
    If (oListobeCboApplicacion.Count > 0) Then
      obeCboAplicacion = oListobeCboApplicacion(0)
      With oInf_CboAplicacion
        .PSMMCAPL = obeCboAplicacion.PSMMCAPL
        .PSMMDAPL = obeCboAplicacion.PSMMDAPL
      End With
      If Me.Focused Then
        txtAplicacion.Text = oInf_CboAplicacion.PSMMDAPL
        txtAplicacion.SelectAll()
      Else
        If oInf_CboAplicacion.PSMMCAPL <> "" Then
          txtAplicacion.Text = oInf_CboAplicacion.PSMMCAPL & " - " & oInf_CboAplicacion.PSMMDAPL
        Else
          txtAplicacion.Text = ""
        End If
      End If
    Else
      txtAplicacion.Text = ""
      oInf_CboAplicacion.pClear()
    End If
  End Sub
End Class

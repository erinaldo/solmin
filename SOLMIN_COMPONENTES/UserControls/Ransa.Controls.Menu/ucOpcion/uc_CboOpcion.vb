
Imports System.Windows.Forms
Public Class uc_CboOpcion
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
  Private oInf_CboOpcion As New beOpcion_InfoUC
  Private oQry_CboOpcion As New beOpcion_InfoUC
  'Private obeTransportista As New CboOpcion_BE()

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

  Private obeOpcionUC As New beOpcionUC
  'codigo de aplicacion externo
  Public Property pPSMMCAPL() As String
    Get
      Return obeOpcionUC.PSMMCAPL
    End Get
    Set(ByVal value As String)
      obeOpcionUC.PSMMCAPL = value
    End Set
  End Property

  Public Property pPSMMCMNU() As String
    Get
      Return obeOpcionUC.PSMMCMNU
    End Get
    Set(ByVal value As String)
      obeOpcionUC.PSMMCMNU = value
    End Set
  End Property

  Public Property pPSMMCOPC() As Decimal
    Get
      Return oInf_CboOpcion.PNMMCOPC 'obeOpcionUC.PNMMCOPC
    End Get
    Set(ByVal value As Decimal)
      oInf_CboOpcion.PNMMCOPC = value
    End Set
  End Property

  Public Property pPSMMDOPC() As String
    Get
      Return oInf_CboOpcion.PSMMDOPC
    End Get
    Set(ByVal value As String)
      oInf_CboOpcion.PSMMDOPC = value
    End Set

  End Property

#End Region
  Private Sub uc_CboAplicacion_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpcion.GotFocus
    Try
      txtOpcion.Text = oInf_CboOpcion.PSMMDOPC
      txtOpcion.SelectAll()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub uc_cbo_Opcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpcion.KeyDown
    Try
      Select Case e.KeyCode
        Case Keys.Escape
          txtOpcion.Text = (oInf_CboOpcion.PSMMDOPC).Trim
          txtOpcion.SelectAll()
        Case Keys.Enter
          If txtOpcion.Text.Trim = Nothing Then
            oInf_CboOpcion.pClear()
          Else
            If txtOpcion.Text.ToUpper.Trim <> oInf_CboOpcion.PSMMDOPC.ToUpper Then
              Call BusquedaCboOpcion()
            Else
              txtOpcion.SelectAll()
            End If
          End If

        Case Keys.F4
          Call BusquedaCboOpcion()
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cbo_Opcion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpcion.Validated
    Try
      If oInf_CboOpcion.PSMMDOPC <> "" Then
        txtOpcion.Text = oInf_CboOpcion.PNMMCOPC & " - " & oInf_CboOpcion.PSMMDOPC
      Else
        txtOpcion.Text = Nothing
        oInf_CboOpcion.pClear()
        RaiseEvent ExitFocusWithOutData()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
  Private Sub Cbo_Opcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOpcion.Validating
    Try
      If txtOpcion.Text = "" Then
        oInf_CboOpcion.pClear()
      Else
        If IsNumeric(txtOpcion.Text) = True Then
          If txtOpcion.Text.Trim <> oInf_CboOpcion.PNMMCOPC Then e.Cancel = BusquedaCboOpcion()
        Else
          If txtOpcion.Text.ToUpper.Trim <> oInf_CboOpcion.PSMMDOPC.ToUpper.Trim Then e.Cancel = BusquedaCboOpcion()
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function BusquedaCboOpcion() As Boolean
    Dim oFiltroOpcion As New beOpcion_InfoUC
    oQry_CboOpcion.pClear()
    oFiltroOpcion.pClear()
    oQry_CboOpcion.PageSize = 20
    oQry_CboOpcion.PageNumber = 1

    If txtOpcion.Text.Trim = Nothing Then
      oQry_CboOpcion.PNMMCOPC = Nothing
      oFiltroOpcion.PNMMCOPC = Nothing
      oQry_CboOpcion.PSMMDOPC = ""
      oFiltroOpcion.PSMMDOPC = ""
    Else
      If IsNumeric(txtOpcion.Text) = True Then
        oQry_CboOpcion.PNMMCOPC = Val(txtOpcion.Text)
        oFiltroOpcion.PNMMCOPC = Val(txtOpcion.Text)

      End If
      If IsNumeric(txtOpcion.Text) = False Then
        If txtOpcion.Text = (oInf_CboOpcion.PSMMDOPC).ToUpper.Trim Then
          oQry_CboOpcion.PNMMCOPC = 0
          oFiltroOpcion.PNMMCOPC = 0
          oQry_CboOpcion.PSMMDOPC = ""
          oFiltroOpcion.PSMMDOPC = ""
        Else

          oQry_CboOpcion.PSMMDOPC = txtOpcion.Text.ToString
          oFiltroOpcion.PSMMDOPC = txtOpcion.Text.ToString
        End If
      End If
    End If

    Dim blnCancelar As Boolean = False
    oQry_CboOpcion.PSMMCAPL = obeOpcionUC.PSMMCAPL
    oQry_CboOpcion.PSMMCMNU = obeOpcionUC.PSMMCMNU
    Try
      Dim oCboOpcion As New List(Of beOpcionUC)
      Dim oblCboOpcion As New ucOpcion_DAL
      oCboOpcion = oblCboOpcion.ListarOpcion(oQry_CboOpcion)

      If oCboOpcion.Count = 0 Then
        txtOpcion.Text = oInf_CboOpcion.PSMMDOPC
        txtOpcion.SelectAll()
        blnCancelar = True
        RaiseEvent InformationChanged()
      Else
        If oCboOpcion.Count = 1 Then
          oInf_CboOpcion.PSMMCAPL = oCboOpcion.Item(0).PSMMCAPL
          oInf_CboOpcion.PSMMCMNU = oCboOpcion.Item(0).PSMMCMNU
          oInf_CboOpcion.PNMMCOPC = oCboOpcion.Item(0).PNMMCOPC
          oInf_CboOpcion.PSMMDOPC = oCboOpcion.Item(0).PSMMDOPC
          RaiseEvent InformationChanged()
        Else
          Dim fbusqueda As New UC_Frm_CboOpciion
          fbusqueda.oListInicialCboOpcion = oCboOpcion
          fbusqueda.oFiltroCboOpcion = oFiltroOpcion
          fbusqueda.pSeleccionOpcion.PSMMCAPL = obeOpcionUC.PSMMCAPL
          fbusqueda.pSeleccionOpcion.PSMMCMNU = obeOpcionUC.PSMMCMNU
          fbusqueda.ShowDialog(Me)
          If fbusqueda.pSeleccionOpcion.PNMMCOPC <> Nothing Then
            oInf_CboOpcion.PSMMCAPL = fbusqueda.pSeleccionOpcion.PSMMCAPL
            oInf_CboOpcion.PSMMCMNU = fbusqueda.pSeleccionOpcion.PSMMCMNU
            oInf_CboOpcion.PNMMCOPC = fbusqueda.pSeleccionOpcion.PNMMCOPC
            oInf_CboOpcion.PSMMDOPC = fbusqueda.pSeleccionOpcion.PSMMDOPC
            RaiseEvent InformationChanged()
          End If
        End If
        txtOpcion.Text = oInf_CboOpcion.PSMMDOPC
        txtOpcion.SelectAll()
        RaiseEvent TextChanged()
      End If

    Catch ex As Exception
    End Try
    Return blnCancelar
  End Function

  Public Sub pClear()
    txtOpcion.Text = ""
    oInf_CboOpcion.pClear()
  End Sub

  Private Sub bsaOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaOpcion.Click
    Try
      txtOpcion.Focus()
      Call BusquedaCboOpcion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub pObtenerOpcion(ByVal PSMMCAPL As String, ByVal PSMMCMNU As String, ByVal PNMMCOPC As Decimal)
    Dim obeCboOpcion As New beOpcionUC
    Dim oListobeCboOpcion As New List(Of beOpcionUC)
    Dim oblOpcion As New ucOpcion_DAL
    Dim oQueryoblOpcion As New beOpcion_InfoUC
    oQueryoblOpcion.PSMMCAPL = PSMMCAPL
    oQueryoblOpcion.PSMMCMNU = PSMMCMNU
    oQueryoblOpcion.PNMMCOPC = PNMMCOPC
    oQueryoblOpcion.PSMMDOPC = txtOpcion.Text
    oQueryoblOpcion.PageSize = 20
    oQueryoblOpcion.PageNumber = 1
    oListobeCboOpcion = oblOpcion.ListarOpcion(oQueryoblOpcion)
    If (oListobeCboOpcion.Count > 0) Then
      obeCboOpcion = oListobeCboOpcion(0)
      With oInf_CboOpcion
        .PSMMCAPL = obeCboOpcion.PSMMCAPL
        .PSMMCMNU = obeCboOpcion.PSMMCMNU
        .PNMMCOPC = obeCboOpcion.PNMMCOPC
        .PSMMDOPC = obeCboOpcion.PSMMDOPC
      End With
      If Me.Focused Then
        txtOpcion.Text = oInf_CboOpcion.PSMMDOPC
        txtOpcion.SelectAll()
      Else
        If oInf_CboOpcion.PSMMCAPL <> "" And oInf_CboOpcion.PSMMCMNU <> "" Then
          txtOpcion.Text = oInf_CboOpcion.PNMMCOPC & " - " & oInf_CboOpcion.PSMMDOPC
        Else
          txtOpcion.Text = ""
        End If
      End If
    Else
      txtOpcion.Text = ""
      oInf_CboOpcion.pClear()
    End If
  End Sub
End Class




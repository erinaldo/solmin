Public Class uc_Almacen
    Public Shadows Event InformationChanged()
    Public Shadows Event TextChanged()
    Public Shadows Event ExitFocusWithOutData()

    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oAlmacenBE As New Almacen_BE
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Almacen As New Almacen_Info_BE
    Private oQry_Almacen As New Almacen_Info_BE
    Private obeAlmacen As New Almacen_BE()

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

#Region " Propiedades "

    Public ReadOnly Property pPSCTPALM() As String
        Get
            Return (oInf_Almacen.PSCTPALM)
        End Get
    End Property
    Public ReadOnly Property pPSCALMC() As String
        Get
            Return (oInf_Almacen.PSCALMC)
        End Get
    End Property
    Public ReadOnly Property pPSCTPALM_CALMC() As String
        Get
            Return (oInf_Almacen.PSCTPALM_CALMC)
        End Get
    End Property
    Public ReadOnly Property pPSTCMPAL() As String
        Get
            Return (oInf_Almacen.PSTCMPAL)
        End Get
    End Property
#End Region

    Private Sub txtAlmacen_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.GotFocus
        Try
            txtAlmacen.Text = oInf_Almacen.PSTCMPAL
            txtAlmacen.SelectAll()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    txtAlmacen.Text = oInf_Almacen.PSTCMPAL
                    txtAlmacen.SelectAll()
                Case Keys.Enter
                    ' Busca segun los ingresado sino muestra todo
                    If (txtAlmacen.Text.ToUpper.Trim = "") Then
                        oInf_Almacen.pClear()
                    Else
                        If txtAlmacen.Text.ToUpper.Trim <> oInf_Almacen.PSTCMPAL.ToUpper Then
                            Call BusquedaAlmacen()
                        Else
                            txtAlmacen.SelectAll()
                        End If
                    End If

                Case Keys.F4
                    Call BusquedaAlmacen()
            End Select
        Catch ex As Exception

        End Try

      


    End Sub
    Private Sub txtAlmacen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmacen.Validated
        Try
            If oInf_Almacen.PSCTPALM <> "" Then
                txtAlmacen.Text = oInf_Almacen.PSCTPALM & " - " & oInf_Almacen.PSCALMC & ":" & oInf_Almacen.PSTCMPAL
            Else
                txtAlmacen.Text = ""
                oInf_Almacen.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If

        Catch ex As Exception

        End Try
      

    End Sub
    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        Try
            If txtAlmacen.Text = "" Then
                oInf_Almacen.pClear()
            Else
                If IsNumeric(txtAlmacen.Text.Trim) Then
                    If txtAlmacen.Text.Trim <> oInf_Almacen.PSCTPALM Then e.Cancel = BusquedaAlmacen()
                Else
                    If txtAlmacen.Text.ToUpper.Trim <> oInf_Almacen.PSTCMPAL.ToUpper.Trim Then e.Cancel = BusquedaAlmacen()
                End If
                If txtAlmacen.Text.ToUpper.Trim <> oInf_Almacen.PSTCMPAL.ToUpper.Trim Then e.Cancel = BusquedaAlmacen()
            End If
        Catch ex As Exception

        End Try
      

    End Sub
    Private Function BusquedaAlmacen() As Boolean
        Dim oFiltroAlmacen As New Almacen_Info_BE
        oQry_Almacen.pClear()
        oFiltroAlmacen.pClear()
        oQry_Almacen.PageSize = 20
        oQry_Almacen.PageNumber = 1
        oQry_Almacen.PSBUSQUEDA = ""
        oQry_Almacen.PSTCMPAL = txtAlmacen.Text.Trim
        Dim blnCancelar As Boolean = False
        If Not IsNumeric(txtAlmacen.Text) Then
            If txtAlmacen.Text.ToUpper.Trim = oInf_Almacen.PSTCMPAL.ToUpper Then
                oQry_Almacen.PSTCMPAL = ""
                oQry_Almacen.PSBUSQUEDA = "" 'SIN CRITERIO
                oFiltroAlmacen.PSTCMPAL = ""
            End If
        End If
        Try
            Dim oListAlmacen As New List(Of Almacen_BE)
            Dim oblAlmacen As New Almacen_BLL
            oListAlmacen = oblAlmacen.ListarAlmacen(oQry_Almacen)

            If oListAlmacen.Count = 0 Then
                txtAlmacen.Text = oInf_Almacen.PSTCMPAL
                txtAlmacen.SelectAll()
                blnCancelar = True
                RaiseEvent InformationChanged()
            Else
                If oListAlmacen.Count = 1 Then
                    oInf_Almacen.PSCTPALM = oListAlmacen.Item(0).PSCTPALM
                    oInf_Almacen.PSCALMC = oListAlmacen.Item(0).PSCALMC
                    oInf_Almacen.PSCTPALM_CALMC = oListAlmacen.Item(0).PSCTPALM & " - " & oListAlmacen.Item(0).PSCALMC
                    oInf_Almacen.PSTCMPAL = oListAlmacen.Item(0).PSTCMPAL
                    RaiseEvent InformationChanged()

                Else
                    Dim fbusqueda As New uc_Frm_Almacen()
                    fbusqueda.oListInicialAlmacen = oListAlmacen
                    fbusqueda.oFiltroAlmacen = oFiltroAlmacen
                    fbusqueda.ShowDialog(Me)
                    If fbusqueda.pSeleccion.PSCTPALM <> "" Then
                        oInf_Almacen.PSCTPALM = fbusqueda.pSeleccion.PSCTPALM
                        oInf_Almacen.PSCALMC = fbusqueda.pSeleccion.PSCALMC
                        oInf_Almacen.PSCTPALM_CALMC = fbusqueda.pSeleccion.PSCTPALM & " - " & fbusqueda.pSeleccion.PSCALMC
                        oInf_Almacen.PSTCMPAL = fbusqueda.pSeleccion.PSTCMPAL
                        RaiseEvent InformationChanged()
                    End If

                End If
                txtAlmacen.Text = oInf_Almacen.PSTCMPAL
                txtAlmacen.SelectAll()
                RaiseEvent TextChanged()
            End If

        Catch ex As Exception
        End Try
        Return blnCancelar


    End Function
    Private Sub bsaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacen.Click

        Try
            txtAlmacen.Focus()
            Call BusquedaAlmacen()
        Catch ex As Exception

        End Try
       

    End Sub

    Public Sub pObtenerAlmacen(ByVal PSCTPALM As String, ByVal PSCALMC As String)
        Dim obeAlmacen As New Almacen_BE
        Dim oListAlmacen As New List(Of Almacen_BE)
        Dim oblAlmacen As New Almacen_BLL
        Dim oQueryAlmacen As New Almacen_Info_BE
        oQueryAlmacen.PSBUSQUEDA = "C"
        oQueryAlmacen.PSCTPALM = PSCTPALM
        oQueryAlmacen.PSCALMC = PSCALMC
        oQueryAlmacen.PageSize = 20
        oQueryAlmacen.PageNumber = 1
        oListAlmacen = oblAlmacen.ListarAlmacen(oQueryAlmacen)
        If (oListAlmacen.Count > 0) Then
            obeAlmacen = oListAlmacen(0)
            With oInf_Almacen
                .PSCTPALM = obeAlmacen.PSCTPALM
                .PSCALMC = obeAlmacen.PSCALMC
                .PSTCMPAL = obeAlmacen.PSTCMPAL
            End With

            If Me.Focused Then
                txtAlmacen.Text = oInf_Almacen.PSTCMPAL
                txtAlmacen.SelectAll()
            Else
                txtAlmacen.Text = oInf_Almacen.PSCTPALM & " - " & oInf_Almacen.PSCALMC & ":" & oInf_Almacen.PSTCMPAL
            End If
        Else
            txtAlmacen.Text = ""
            oInf_Almacen.pClear()
        End If
       

    End Sub

End Class

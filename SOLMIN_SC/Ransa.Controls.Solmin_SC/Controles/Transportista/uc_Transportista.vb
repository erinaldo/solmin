Public Class uc_Transportista
#Region " Definición Eventos "
    Public Shadows Event InformationChanged()
    Public Shadows Event TextChanged()
    Public Shadows Event ExitFocusWithOutData()
#End Region

#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oTransportista As New Transportista_BE
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Transportista As New Transportista_Info_BE
    Private oQry_Transportista As New Transportista_Info_BE
    Private obeTransportista As New Transportista_BE()

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

    Public ReadOnly Property pPNCTRSPT() As Decimal
        Get
            Return (oInf_Transportista.PNCTRSPT)
        End Get
    End Property

    Public ReadOnly Property pPSNRUCTR() As String
        Get
            Return (oInf_Transportista.PSNRUCTR)
        End Get

    End Property
    Public ReadOnly Property pPSTCMTRT() As String
        Get
            Return (oInf_Transportista.PSTCMTRT)
        End Get
    End Property

    Public WriteOnly Property pPSCULUSA() As String
        Set(ByVal value As String)
            pUsuario = value
        End Set
    End Property

#End Region
    Private Sub txtTransportista_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransportista.GotFocus
        Try
            txtTransportista.Text = oInf_Transportista.PSTCMTRT
            txtTransportista.SelectAll()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTransportista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransportista.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtTransportista.Text = oInf_Transportista.PSTCMTRT
                txtTransportista.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If (txtTransportista .Text.ToUpper.Trim = "") Then
                    oInf_Transportista .pClear()
                Else
                    If txtTransportista.Text.ToUpper.Trim <> oInf_Transportista.PSTCMTRT.ToUpper Then
                        Call BusquedaTransportista()
                    Else
                        txtTransportista.SelectAll()
                    End If
                End If

            Case Keys.F4
                Call BusquedaTransportista()
        End Select


    End Sub
    Private Sub txtTransportista_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransportista.Validated

        If oInf_Transportista.PNCTRSPT <> 0 Then
            txtTransportista.Text = oInf_Transportista.PNCTRSPT & " - " & oInf_Transportista.PSTCMTRT
        Else
            txtTransportista.Text = ""
            oInf_Transportista.pClear()
            RaiseEvent ExitFocusWithOutData()
        End If

    End Sub
    Private Sub txtTransportista_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTransportista.Validating
        If txtTransportista.Text = "" Then
            oInf_Transportista.pClear()
        Else
            If IsNumeric(txtTransportista.Text.Trim) Then
                If txtTransportista.Text.Trim <> oInf_Transportista.PNCTRSPT Then e.Cancel = BusquedaTransportista()
            Else
                If txtTransportista.Text.ToUpper.Trim <> oInf_Transportista.PSTCMTRT.ToUpper.Trim Then e.Cancel = BusquedaTransportista()
            End If
            If txtTransportista.Text.ToUpper.Trim <> oInf_Transportista.PSTCMTRT.ToUpper.Trim Then e.Cancel = BusquedaTransportista()
        End If

    End Sub
    Private Function BusquedaTransportista() As Boolean
        Dim oFiltroTransportista As New Transportista_Info_BE
        oQry_Transportista.pClear()
        oFiltroTransportista.pClear()
        oQry_Transportista.PageSize = 20
        oQry_Transportista.PageNumber = 1
        If IsNumeric(txtTransportista.Text.Trim) Then
            If txtTransportista.Text.Trim.Length <= 6 Then
                oQry_Transportista.PNCTRSPT = txtTransportista.Text.Trim
                oQry_Transportista.PSBUSQUEDA = "C" ' BUSQUEDA POR CODIGO
                oFiltroTransportista.PNCTRSPT = txtTransportista.Text.Trim
            End If
            If txtTransportista.Text.Length > 6 Then
                oQry_Transportista.PSNRUCTR = txtTransportista.Text.Trim
                oQry_Transportista.PSBUSQUEDA = "" 'SIN CRITERIO
                oFiltroTransportista.PSNRUCTR = txtTransportista.Text.Trim
            End If
        Else
            oQry_Transportista.PSTCMTRT = txtTransportista.Text.Trim
            oQry_Transportista.PSBUSQUEDA = "" 'SIN CRITERIO
            oFiltroTransportista.PSTCMTRT = txtTransportista.Text.Trim
        End If
        If Not IsNumeric(txtTransportista.Text) Then
            If txtTransportista.Text.ToUpper.Trim = oInf_Transportista.PSTCMTRT.ToUpper Then
                oQry_Transportista.PSTCMTRT = ""
                oQry_Transportista.PSBUSQUEDA = "" 'SIN CRITERIO
                oFiltroTransportista.PSTCMTRT = ""
            End If
        End If

        Dim blnCancelar As Boolean = False
        Try
            Dim oListaTransportista As New List(Of Transportista_BE)
            Dim oblTrasportista As New Transportista_BLL
            oListaTransportista = oblTrasportista.ListarTransportista(oQry_Transportista)

            If oListaTransportista.Count = 0 Then
                txtTransportista.Text = oInf_Transportista.PSTCMTRT
                txtTransportista.SelectAll()
                blnCancelar = True
                RaiseEvent InformationChanged()
            Else
                If oListaTransportista.Count = 1 Then
                    oInf_Transportista.PNCTRSPT = oListaTransportista.Item(0).PNCTRSPT
                    oInf_Transportista.PSTCMTRT = oListaTransportista.Item(0).PSTCMTRT
                    oInf_Transportista.PSNRUCTR = oListaTransportista.Item(0).PSNRUCTR
                    RaiseEvent InformationChanged()

                Else

                    Dim fbusqueda As New uc_Frm_Transportistas()
                    fbusqueda.oListInicialTransportista = oListaTransportista
                    fbusqueda.oFiltroTransportista = oFiltroTransportista
                    fbusqueda.ShowDialog(Me)
                    If fbusqueda.pSeleccion.PNCTRSPT <> 0 Then
                        oInf_Transportista.PNCTRSPT = fbusqueda.pSeleccion.PNCTRSPT
                        oInf_Transportista.PSTCMTRT = fbusqueda.pSeleccion.PSTCMTRT
                        oInf_Transportista.PSNRUCTR = fbusqueda.pSeleccion.PSNRUCTR
                        RaiseEvent InformationChanged()
                    End If


                End If
                txtTransportista.Text = oInf_Transportista.PSTCMTRT
                txtTransportista.SelectAll()
                RaiseEvent TextChanged()
            End If

        Catch ex As Exception
        End Try
        Return blnCancelar


    End Function
    Private Sub bsaTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTransportista.Click

        txtTransportista.Focus()
        Call BusquedaTransportista()

    End Sub


    Public Sub pObtenerTransportista(ByVal PNCTRSPT As Decimal)
        Dim obeTransportista As New Transportista_BE
        Dim oListTransportista As New List(Of Transportista_BE)
        Dim oblTransportista As New Transportista_BLL
        Dim oQueryTransportista As New Transportista_Info_BE
        oQueryTransportista.PSBUSQUEDA = "C"
        oQueryTransportista.PNCTRSPT = PNCTRSPT
        oQueryTransportista.PageSize = 20
        oQueryTransportista.PageNumber = 1
        oListTransportista = oblTransportista.ListarTransportista(oQueryTransportista)
        If (oListTransportista.Count > 0) Then
            obeTransportista = oListTransportista(0)
            With oInf_Transportista
                .PNCTRSPT = obeTransportista.PNCTRSPT
                .PSNRUCTR = obeTransportista.PSNRUCTR
                .PSTCMTRT = obeTransportista.PSTCMTRT
            End With
            If Me.Focused Then
                txtTransportista.Text = oInf_Transportista.PSTCMTRT
                txtTransportista.SelectAll()
            Else
                If oInf_Transportista.PNCTRSPT <> 0 Then
                    txtTransportista.Text = oInf_Transportista.PNCTRSPT & " - " & oInf_Transportista.PSTCMTRT
                Else
                    txtTransportista.Text = ""
                End If
            End If
        Else
            txtTransportista.Text = ""
            oInf_Transportista.pClear()
        End If
    End Sub

End Class

Public Class uc_Almacen_Local
    Public Shadows Event InformationChanged()
    Public Shadows Event TextChanged()
    Public Shadows Event ExitFocusWithOutData()

    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oAlmacenBE As New TipoDato_BE
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Almacen As New TipoDato_Info_BE
    Private oQry_Almacen As New TipoDato_Info_BE
    Private obeAlmacen As New TipoDato_BE()

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
    Private _CCLNT As Decimal = 0
#Region " Propiedades "
    Public WriteOnly Property CCLNT() As Decimal
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Public ReadOnly Property pPNNTPODT() As Decimal
        Get
            Return (oInf_Almacen.PNNTPODT)
        End Get

    End Property
    Public ReadOnly Property pPNNCODRG() As Decimal
        Get
            Return (oInf_Almacen.PNNCODRG)
        End Get
    End Property
    Public ReadOnly Property pPSTDSCRG() As String
        Get
            Return (oInf_Almacen.PSTDSCRG)
        End Get
    End Property
    Public ReadOnly Property pPNCCLNT() As Decimal
        Get
            Return (oInf_Almacen.PNCCLNT)
        End Get
    End Property
#End Region

    Private Sub txtAlmacen_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.GotFocus
        Try
            txtAlmacen.Text = oInf_Almacen.PSTDSCRG
            txtAlmacen.SelectAll()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    txtAlmacen.Text = oInf_Almacen.PSTDSCRG
                    txtAlmacen.SelectAll()
                Case Keys.Enter
                    ' Busca segun los ingresado sino muestra todo
                    If (txtAlmacen.Text.ToUpper.Trim = "") Then
                        oInf_Almacen.pClear()
                    Else
                        If txtAlmacen.Text.ToUpper.Trim <> oInf_Almacen.PSTDSCRG.ToUpper Then
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
            If oInf_Almacen.PSTDSCRG <> "" Then
                txtAlmacen.Text = oInf_Almacen.PNNTPODT & "-" & oInf_Almacen.PNNCODRG & ":" & oInf_Almacen.PSTDSCRG
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
                    If txtAlmacen.Text.Trim <> oInf_Almacen.PSTDSCRG Then e.Cancel = BusquedaAlmacen()
                Else
                    If txtAlmacen.Text.ToUpper.Trim <> oInf_Almacen.PSTDSCRG.ToUpper.Trim Then e.Cancel = BusquedaAlmacen()
                End If
                If txtAlmacen.Text.ToUpper.Trim <> oInf_Almacen.PSTDSCRG.ToUpper.Trim Then e.Cancel = BusquedaAlmacen()
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Function BusquedaAlmacen() As Boolean
        Dim oFiltroAlmacen As New TipoDato_Info_BE
        oQry_Almacen.pClear()
        oFiltroAlmacen.pClear()
        oQry_Almacen.PageSize = 20
        oQry_Almacen.PageNumber = 1
        oQry_Almacen.PSBUSQUEDA = ""
        oQry_Almacen.PNCCLNT = Me._CCLNT
        oQry_Almacen.PSTDSCRG = txtAlmacen.Text.Trim
        Dim blnCancelar As Boolean = False
        If Not IsNumeric(txtAlmacen.Text) Then
            If txtAlmacen.Text.ToUpper.Trim = oInf_Almacen.PSTDSCRG.ToUpper Then
                oQry_Almacen.PSTDSCRG = ""
                oQry_Almacen.PSBUSQUEDA = "" 'SIN CRITERIO
                oFiltroAlmacen.PSTDSCRG = ""
            End If
        End If
        Try
            Dim oListAlmacen As New List(Of TipoDato_BE)
            Dim oblAlmacen As New TipoDato_BLL
            oListAlmacen = oblAlmacen.ListarAlmacenLocaL(oQry_Almacen)

            If oListAlmacen.Count = 0 Then
                txtAlmacen.Text = oInf_Almacen.PSTDSCRG
                txtAlmacen.SelectAll()
                blnCancelar = True
                RaiseEvent InformationChanged()
            Else
                If oListAlmacen.Count = 1 Then
                    oInf_Almacen.PNNTPODT = oListAlmacen.Item(0).PNNTPODT
                    oInf_Almacen.PNNCODRG = oListAlmacen.Item(0).PNNCODRG
                    oInf_Almacen.PSTDSCRG = oListAlmacen.Item(0).PSTDSCRG
                    oInf_Almacen.PNCCLNT = oListAlmacen.Item(0).PNCCLNT
                    RaiseEvent InformationChanged()

                Else
                    Dim fbusqueda As New uc_Frm_Almacen_Local()
                    fbusqueda.CCLNT = Me._CCLNT
                    fbusqueda.oListInicialAlmacen = oListAlmacen
                    fbusqueda.oFiltroAlmacen = oFiltroAlmacen
                    fbusqueda.ShowDialog(Me)
                    If fbusqueda.pSeleccion.PSTDSCRG <> "" Then
                        oInf_Almacen.PNNTPODT = fbusqueda.pSeleccion.PNNTPODT
                        oInf_Almacen.PNNCODRG = fbusqueda.pSeleccion.PNNCODRG
                        oInf_Almacen.PSTDSCRG = fbusqueda.pSeleccion.PSTDSCRG
                        oInf_Almacen.PNCCLNT = fbusqueda.pSeleccion.PNCCLNT
                        RaiseEvent InformationChanged()
                    End If

                End If
                txtAlmacen.Text = oInf_Almacen.PSTDSCRG
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

    Public Sub pClear()
        txtAlmacen.Text = ""
        oInf_Almacen.pClear()
    End Sub
    Public Sub pObtenerAlmacen(ByVal PNNCODRG As Decimal)
        Dim obeAlmacen As New TipoDato_BE
        Dim oListAlmacen As New List(Of TipoDato_BE)
        Dim oblAlmacen As New TipoDato_BLL
        Dim oQueryAlmacen As New TipoDato_Info_BE
        oQueryAlmacen.PSBUSQUEDA = "C"
        oQueryAlmacen.PNCCLNT = Me._CCLNT
        oQueryAlmacen.PNNCODRG = PNNCODRG
        oQueryAlmacen.PageSize = 20
        oQueryAlmacen.PageNumber = 1
        oListAlmacen = oblAlmacen.ListarAlmacenLocaL(oQueryAlmacen)
        If (oListAlmacen.Count > 0) Then
            obeAlmacen = oListAlmacen(0)
            With oInf_Almacen
                .PNNTPODT = obeAlmacen.PNNTPODT
                .PNNCODRG = obeAlmacen.PNNCODRG
                .PSTDSCRG = obeAlmacen.PSTDSCRG
            End With

            If Me.Focused Then
                txtAlmacen.Text = oInf_Almacen.PSTDSCRG
                txtAlmacen.SelectAll()
            Else
                txtAlmacen.Text = oInf_Almacen.PNNTPODT & "-" & oInf_Almacen.PNNCODRG & ":" & oInf_Almacen.PSTDSCRG
            End If
        Else
            txtAlmacen.Text = ""
            oInf_Almacen.pClear()
        End If


    End Sub

End Class

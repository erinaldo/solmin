Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Cliente
Imports RANSA.DATA.slnSOLMIN.DAO.Cliente

Public Class ucCliente_TxtF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Shadows Event InformationChanged()
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private objSqlManager As SqlManager
    Private TD_ClienteSeleccionado As TD_InfBas_Cliente = New TD_InfBas_Cliente
    Private blnIsRequired As Boolean = False
    Private strMensajeError As String = ""
#End Region
#Region " Propiedades "
    Public WriteOnly Property pCargarPorCodigo() As Int32
        Set(ByVal value As Int32)
            Call pObtenerCliente(value)
        End Set
    End Property

    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                txtCliente.StateCommon.Back.Color1 = Nothing
            Else
                txtCliente.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public ReadOnly Property pClienteSeleccionado() As TD_InfBas_Cliente
        Get
            Return TD_ClienteSeleccionado
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pObtenerCliente(ByVal Codigo As Int32) As Boolean
        Dim objCliente As TD_Cliente = daoCliente.Obtener(objSqlManager, Codigo, strMensajeError)
        Dim blnResultado As Boolean = False
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If objCliente.pCCLNT_Cliente <> 0 Then
                With TD_ClienteSeleccionado
                    .pCCLNT_Cliente = objCliente.pCCLNT_Cliente
                    .pTCMPCL_DescripcionCliente = objCliente.pTCMPCL_DescripcionCliente
                    .pNRUC_NroRUC = objCliente.pNRUC_NroRUC
                End With
            End If
        End If
        If TD_ClienteSeleccionado.pCCLNT_Cliente <> 0 Then
            txtCliente.Text = TD_ClienteSeleccionado.pCCLNT_Cliente & " - " & TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente
            blnResultado = True
        Else
            txtCliente.Text = ""
            strMensajeError = "Cliente no existe."
            RaiseEvent ErrorMessage(strMensajeError)
        End If
        txtCliente.CausesValidation = False
        Return blnResultado
    End Function

    Private Sub pCargarVentana(ByVal strDetalle As String)
        Dim fBuscar As ucCliente_FCliente = New ucCliente_FCliente
        With fBuscar
            If strDetalle <> "" Then .pFiltroDescripcion = "*" & strDetalle & "*"
            .ShowDialog()
            If .pClienteSeleccionado.pCCLNT_Cliente <> 0 Then
                TD_ClienteSeleccionado.pCCLNT_Cliente = .pClienteSeleccionado.pCCLNT_Cliente
                TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente = .pClienteSeleccionado.pTCMPCL_DescripcionCliente
                TD_ClienteSeleccionado.pNRUC_NroRUC = .pClienteSeleccionado.pNRUC_NroRUC
            End If
            .Dispose()
            fBuscar = Nothing
        End With
        If TD_ClienteSeleccionado.pCCLNT_Cliente <> 0 Then
            txtCliente.Text = TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente
            txtCliente.SelectAll()
        Else
            txtCliente.Text = ""
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub bsaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCliente.Click
        Dim strTemp As String = ""
        If txtCliente.CausesValidation Then strTemp = txtCliente.Text
        Call pCargarVentana(strTemp)
        txtCliente.CausesValidation = False
    End Sub

    Private Sub ucCliente_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objSqlManager = New SqlManager
        txtCliente.CausesValidation = False
    End Sub

    Private Sub ucCliente_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = txtCliente.Height
    End Sub

    Private Sub txtCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.GotFocus
        If TD_ClienteSeleccionado.pCCLNT_Cliente <> 0 Then
            txtCliente.Text = TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente
            txtCliente.SelectAll()
        Else
            txtCliente.Text = ""
        End If
        txtCliente.CausesValidation = False
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Escape Then
            If TD_ClienteSeleccionado.pCCLNT_Cliente <> 0 Then
                txtCliente.Text = TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente
            Else
                txtCliente.Text = ""
            End If
            txtCliente.CausesValidation = False
            Exit Sub
        End If
        If Not txtCliente.CausesValidation Then
            txtCliente.CausesValidation = True
            RaiseEvent InformationChanged()
        End If
    End Sub

    Private Sub txtCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.LostFocus
        ' Solo si no se hace validación
        If txtCliente.CausesValidation Then Exit Sub
        ' Visualizo la información y salgo
        If TD_ClienteSeleccionado.pCCLNT_Cliente <> 0 Then
            txtCliente.Text = TD_ClienteSeleccionado.pCCLNT_Cliente & " - " & TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente
        Else
            txtCliente.Text = ""
        End If
        txtCliente.CausesValidation = False
    End Sub

    Private Sub txtCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Validated
        ' Visualizo la información y salgo
        If TD_ClienteSeleccionado.pCCLNT_Cliente <> 0 Then
            txtCliente.Text = TD_ClienteSeleccionado.pCCLNT_Cliente & " - " & TD_ClienteSeleccionado.pTCMPCL_DescripcionCliente
        Else
            txtCliente.Text = ""
        End If
        txtCliente.CausesValidation = False
    End Sub

    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If txtCliente.Text <> "" Then
            Dim intTemp As Int32 = 0
            If Int32.TryParse(txtCliente.Text, intTemp) Then
                If Not pObtenerCliente(intTemp) Then e.Cancel = True
            Else
                Call pCargarVentana(txtCliente.Text)
            End If
        Else
            With TD_ClienteSeleccionado
                .pCCLNT_Cliente = 0
                .pTCMPCL_DescripcionCliente = ""
                .pNRUC_NroRUC = 0
            End With
            txtCliente.Text = ""
            txtCliente.CausesValidation = False
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pClear()
        With TD_ClienteSeleccionado
            .pCCLNT_Cliente = 0
            .pTCMPCL_DescripcionCliente = ""
            .pNRUC_NroRUC = 0
        End With
        txtCliente.Text = ""
        txtCliente.CausesValidation = False
    End Sub
#End Region
End Class
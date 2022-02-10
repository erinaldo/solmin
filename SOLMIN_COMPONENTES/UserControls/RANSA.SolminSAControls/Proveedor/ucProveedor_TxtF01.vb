Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Proveedor
Imports RANSA.DATA.slnSOLMIN.DAO.Proveedor

Public Class ucProveedor_TxtF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private objSqlManager As SqlManager
    Private pProvSelec As TD_InfBas_Proveedor = New TD_InfBas_Proveedor
    Private blnIsRequired As Boolean = False
    Private strMensajeError As String = ""
#End Region
#Region " Propiedades "
    Public WriteOnly Property pCargarPorCodigo() As Int32
        Set(ByVal value As Int32)
            Call pObtenerProveedor(value)
        End Set
    End Property

    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                txtProveedor.StateCommon.Back.Color1 = Nothing
            Else
                txtProveedor.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public ReadOnly Property pProveedorSelec() As TD_InfBas_Proveedor
        Get
            Return pProvSelec
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pObtenerProveedor(ByVal Codigo As Int32) As Boolean
        Dim Proveedor As TD_Proveedor = daoProveedor.Obtener(objSqlManager, Codigo, strMensajeError)
        Dim blnResultado As Boolean = False
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If Proveedor.pCPRVCL_Proveedor <> 0 Then
                With pProvSelec
                    .pCPRVCL_Proveedor = Proveedor.pCPRVCL_Proveedor
                    .pTPRVCL_DescripcionProveedor = Proveedor.pTPRVCL_DescripcionProveedor
                    .pNRUCPR_NroRUC = Proveedor.pNRUCPR_NroRUC
                End With
            End If
        End If
        If pProvSelec.pCPRVCL_Proveedor <> 0 Then
            txtProveedor.Text = pProvSelec.pCPRVCL_Proveedor & " - " & pProvSelec.pTPRVCL_DescripcionProveedor
            blnResultado = True
        Else
            txtProveedor.Text = ""
            strMensajeError = "Proveedor no existe."
            RaiseEvent ErrorMessage(strMensajeError)
        End If
        txtProveedor.CausesValidation = False
        Return blnResultado
    End Function

    Private Sub pCargarVentana(ByVal strDetalle As String)
        Dim fBuscarProv As ucProveedor_FProvF01 = New ucProveedor_FProvF01
        With fBuscarProv
            If strDetalle <> "" Then .pFiltroDescripcion = "*" & strDetalle & "*"
            .ShowDialog()
            If .pProveedorSelec.pCPRVCL_Proveedor <> 0 Then
                pProvSelec.pCPRVCL_Proveedor = .pProveedorSelec.pCPRVCL_Proveedor
                pProvSelec.pTPRVCL_DescripcionProveedor = .pProveedorSelec.pTPRVCL_DescripcionProveedor
                pProvSelec.pNRUCPR_NroRUC = .pProveedorSelec.pNRUCPR_NroRUC
            End If
            .Dispose()
            fBuscarProv = Nothing
        End With
        If pProvSelec.pCPRVCL_Proveedor <> 0 Then
            txtProveedor.Text = pProvSelec.pTPRVCL_DescripcionProveedor
            txtProveedor.SelectAll()
        Else
            txtProveedor.Text = ""
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub bsaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProveedor.Click
        Dim strTemp As String = ""
        If txtProveedor.CausesValidation Then strTemp = txtProveedor.Text
        Call pCargarVentana(strTemp)
        txtProveedor.CausesValidation = False
    End Sub

    Private Sub ucProveedor_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objSqlManager = New SqlManager
        txtProveedor.CausesValidation = False
    End Sub

    Private Sub ucProveedor_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = txtProveedor.Height
    End Sub

    Private Sub txtProveedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProveedor.GotFocus
        If pProvSelec.pCPRVCL_Proveedor <> 0 Then
            txtProveedor.Text = pProvSelec.pTPRVCL_DescripcionProveedor
            txtProveedor.SelectAll()
        Else
            txtProveedor.Text = ""
        End If
        txtProveedor.CausesValidation = False
    End Sub

    Private Sub txtProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Escape Then
            If pProvSelec.pCPRVCL_Proveedor <> 0 Then
                txtProveedor.Text = pProvSelec.pTPRVCL_DescripcionProveedor
            Else
                txtProveedor.Text = ""
            End If
            txtProveedor.CausesValidation = False
        End If
    End Sub

    Private Sub txtProveedor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProveedor.LostFocus
        ' Solo si no se hace validación
        If txtProveedor.CausesValidation Then Exit Sub
        ' Visualizo la información y salgo
        If pProvSelec.pCPRVCL_Proveedor <> 0 Then
            txtProveedor.Text = pProvSelec.pCPRVCL_Proveedor & " - " & pProvSelec.pTPRVCL_DescripcionProveedor
        Else
            txtProveedor.Text = ""
        End If
        txtProveedor.CausesValidation = False
    End Sub

    Private Sub txtProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedor.TextChanged
        txtProveedor.CausesValidation = True
    End Sub

    Private Sub txtProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProveedor.Validated
        ' Visualizo la información y salgo
        If pProvSelec.pCPRVCL_Proveedor <> 0 Then
            txtProveedor.Text = pProvSelec.pCPRVCL_Proveedor & " - " & pProvSelec.pTPRVCL_DescripcionProveedor
        Else
            txtProveedor.Text = ""
        End If
        txtProveedor.CausesValidation = False
    End Sub

    Private Sub txtProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtProveedor.Validating
        If txtProveedor.Text <> "" Then
            Dim intTemp As Int32 = 0
            If Int32.TryParse(txtProveedor.Text, intTemp) Then
                If Not pObtenerProveedor(intTemp) Then e.Cancel = True
            Else
                Call pCargarVentana(txtProveedor.Text)
            End If
        Else
            With pProvSelec
                .pCPRVCL_Proveedor = 0
                .pTPRVCL_DescripcionProveedor = ""
                .pNRUCPR_NroRUC = 0
            End With
            txtProveedor.Text = ""
            txtProveedor.CausesValidation = False
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pClear()
        With pProvSelec
            .pCPRVCL_Proveedor = 0
            .pTPRVCL_DescripcionProveedor = ""
            .pNRUCPR_NroRUC = 0
        End With
        txtProveedor.Text = ""
        txtProveedor.CausesValidation = False
    End Sub
#End Region
End Class
Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.DAO.TipoAyuda
'Imports Ransa.TypeDef.TipoAyuda

Public Class ucTipoAyuda_CmbF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private objSqlManager As SqlManager
    'Private pTipoAyuda As TD_TipoAyuda = New Ransa.TypeDef.TipoAyuda.TD_TipoAyuda
    Private pTipoAyuda As TD_TipoAyuda = New TipoAyuda.TD_TipoAyuda
    Private strCategoria As String
    Private blnIsRequired As Boolean = False
    Private strMensajeError As String = ""
#End Region
#Region " Propiedades "
    Public Property pCategoria() As String
        Get
            Return strCategoria
        End Get
        Set(ByVal value As String)
            strCategoria = value
        End Set
    End Property

    Public WriteOnly Property pCargarPorCodigo() As String
        Set(ByVal value As String)
            Call pObtenerTipoAyuda(value)
        End Set
    End Property

    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                cmbTipoAyuda.StateCommon.Back.Color1 = Nothing
            Else
                cmbTipoAyuda.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public ReadOnly Property pInformacionSelec() As TD_TipoAyuda
        Get
            Return pTipoAyuda
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pObtenerTipoAyuda(ByVal Codigo As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim objTemp As TD_TipoAyuda = cTipoAyuda.Obtener(objSqlManager, strCategoria, Codigo, strMensajeError)
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If objTemp.pCCMPRN_Codigo <> "" Then
                With pTipoAyuda
                    .pCCMPRN_Codigo = objTemp.pCCMPRN_Codigo
                    .pTDSDES_Detalle = objTemp.pTDSDES_Detalle
                End With
            End If
        End If
        If pTipoAyuda.pCCMPRN_Codigo <> "" Then
            cmbTipoAyuda.Text = pTipoAyuda.pCCMPRN_Codigo & " - " & pTipoAyuda.pTDSDES_Detalle
            blnResultado = True
        Else
            cmbTipoAyuda.Text = ""
            strMensajeError = "No existe información."
            RaiseEvent ErrorMessage(strMensajeError)
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub ucTipoAyuda_CmbF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager
        If strCategoria <> "" Then
            Dim dtTemp As DataTable = cTipoAyuda.fdtListar_TablaAyuda_L01(objSqlManager, strCategoria, strMensajeError)
            If strMensajeError <> "" Then RaiseEvent ErrorMessage(strMensajeError)
            cmbTipoAyuda.DataSource = dtTemp
            If pTipoAyuda.pCCMPRN_Codigo <> "" Then
                cmbTipoAyuda.Text = pTipoAyuda.pTDSDES_Detalle
            Else
                cmbTipoAyuda.Text = ""
            End If
        End If
    End Sub

    Private Sub ucTipoAyuda_CmbF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        cmbTipoAyuda.Height = Me.Height
        cmbTipoAyuda.Width = Me.Width
        cmbTipoAyuda.DropDownWidth = Me.Width
    End Sub

    Private Sub cmbTipoAyuda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoAyuda.GotFocus
        If pTipoAyuda.pCCMPRN_Codigo <> "" Then
            cmbTipoAyuda.SelectedText = pTipoAyuda.pTDSDES_Detalle
            'cmbTipoAyuda.Select(0, Len(pTipoAyuda.pTDSDES_Detalle))
            cmbTipoAyuda.SelectAll()
        Else
            cmbTipoAyuda.Text = ""
        End If
    End Sub

    Private Sub cmbTipoAyuda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipoAyuda.KeyDown
        If e.KeyCode = Keys.Escape Then
            If pTipoAyuda.pCCMPRN_Codigo <> "" Then
                cmbTipoAyuda.Text = pTipoAyuda.pTDSDES_Detalle
            Else
                cmbTipoAyuda.Text = ""
            End If
        End If
    End Sub

    Private Sub cmbTipoAyuda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoAyuda.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper()
    End Sub

    Private Sub cmbTipoAyuda_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbTipoAyuda.Validating
        If cmbTipoAyuda.SelectedIndex < 0 Then
            If cmbTipoAyuda.Text <> "" Then
                If Not pObtenerTipoAyuda(cmbTipoAyuda.Text) Then e.Cancel = True
            Else
                With pTipoAyuda
                    .pCCMPRN_Codigo = ""
                    .pTDSDES_Detalle = ""
                End With
                cmbTipoAyuda.Text = ""
            End If
        Else
            If cmbTipoAyuda.SelectedText <> "" Then
                With pTipoAyuda
                    .pCCMPRN_Codigo = cmbTipoAyuda.SelectedValue
                    .pTDSDES_Detalle = cmbTipoAyuda.Text
                End With
                cmbTipoAyuda.Text = pTipoAyuda.pCCMPRN_Codigo & " - " & pTipoAyuda.pTDSDES_Detalle
            Else
                With pTipoAyuda
                    .pCCMPRN_Codigo = ""
                    .pTDSDES_Detalle = ""
                End With
                cmbTipoAyuda.Text = ""
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pClear()
        With pTipoAyuda
            .pCCMPRN_Codigo = ""
            .pTDSDES_Detalle = ""
        End With
        cmbTipoAyuda.Text = ""
    End Sub
#End Region
End Class
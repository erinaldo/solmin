Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Moneda
Imports RANSA.DATA.slnSOLMIN.DAO.Moneda

Public Class ucMoneda_CmbF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private objSqlManager As SqlManager
    Private pMoneda As TD_Moneda = New TD_Moneda
    Private blnIsRequired As Boolean = False
    Private strMensajeError As String = ""
#End Region
#Region " Propiedades "
    Public WriteOnly Property pCargarPorCodigo() As String
        Set(ByVal value As String)
            Call pObtenerMoneda(value)
        End Set
    End Property

    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                cmbMoneda.StateCommon.Back.Color1 = Nothing
            Else
                cmbMoneda.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public ReadOnly Property pInformacionSelec() As TD_Moneda
        Get
            Return pMoneda
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pObtenerMoneda(ByVal Codigo As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim objTemp As TD_Moneda = daoMoneda.Obtener(objSqlManager, Codigo, strMensajeError)
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If objTemp.pCMNDA1_Codigo <> "" Then
                With pMoneda
                    .pCMNDA1_Codigo = objTemp.pCMNDA1_Codigo
                    .pTMNDA_Detalle = objTemp.pTMNDA_Detalle
                End With
            End If
        End If
        If pMoneda.pCMNDA1_Codigo <> "" Then
            cmbMoneda.Text = pMoneda.pCMNDA1_Codigo & " - " & pMoneda.pTMNDA_Detalle
            blnResultado = True
        Else
            cmbMoneda.Text = ""
            strMensajeError = "No existe información."
            RaiseEvent ErrorMessage(strMensajeError)
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub ucTipoAyuda_CmbF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager

        Dim dtTemp As DataTable = daoMoneda.fdtListar_Moneda_L01(objSqlManager, strMensajeError)
        If strMensajeError <> "" Then RaiseEvent ErrorMessage(strMensajeError)
        cmbMoneda.DataSource = dtTemp
        If pMoneda.pCMNDA1_Codigo <> "" Then
            cmbMoneda.Text = pMoneda.pTMNDA_Detalle
        Else
            cmbMoneda.Text = ""
        End If
    End Sub

    Private Sub ucTipoAyuda_CmbF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Height = cmbMoneda.Height
    End Sub

    Private Sub cmbMoneda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMoneda.GotFocus
        If pMoneda.pCMNDA1_Codigo <> "" Then
            cmbMoneda.SelectedText = pMoneda.pTMNDA_Detalle
            cmbMoneda.SelectAll()
        Else
            cmbMoneda.Text = ""
        End If
    End Sub

    Private Sub cmbMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMoneda.KeyDown
        If e.KeyCode = Keys.Escape Then
            If pMoneda.pCMNDA1_Codigo <> "" Then
                cmbMoneda.Text = pMoneda.pTMNDA_Detalle
            Else
                cmbMoneda.Text = ""
            End If
        End If
    End Sub

    Private Sub cmbMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMoneda.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper()
    End Sub

    Private Sub cmbMoneda_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbMoneda.Validating
        If cmbMoneda.SelectedIndex < 0 Then
            If cmbMoneda.Text <> "" Then
                If Not pObtenerMoneda(cmbMoneda.Text) Then e.Cancel = True
            Else
                With pMoneda
                    .pCMNDA1_Codigo = ""
                    .pTMNDA_Detalle = ""
                End With
                cmbMoneda.Text = ""
            End If
        Else
            If cmbMoneda.SelectedText <> "" Then
                With pMoneda
                    .pCMNDA1_Codigo = cmbMoneda.SelectedValue
                    .pTMNDA_Detalle = cmbMoneda.Text
                End With
                cmbMoneda.Text = pMoneda.pCMNDA1_Codigo & " - " & pMoneda.pTMNDA_Detalle
            Else
                With pMoneda
                    .pCMNDA1_Codigo = ""
                    .pTMNDA_Detalle = ""
                End With
                cmbMoneda.Text = ""
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pClear()
        With pMoneda
            .pCMNDA1_Codigo = ""
            .pTMNDA_Detalle = ""
        End With
        cmbMoneda.Text = ""
    End Sub
#End Region
End Class
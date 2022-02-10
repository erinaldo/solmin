Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.ServTransp
Imports Ransa.TypeDef.ServTransp

Public Class ucServTransp_CmbF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    'Private oServTransp As cServTransp = New Ransa.DAO.ServTransp.cServTransp
    Private oServTransp As cServTransp = New ServTransp.cServTransp
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    'Private oInfServTransp As TD_Inf_ServTransp = New Ransa.TypeDef.ServTransp.TD_Inf_ServTransp
    Private oInfServTransp As TD_Inf_ServTransp = New ServTransp.TD_Inf_ServTransp
    Private sCompania As String = ""
    Private sDivision As String = ""
    Private strMensajeError As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnIsRequired As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                cmbServTransp.StateCommon.Back.Color1 = Nothing
            Else
                cmbServTransp.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public Property pCodigoServicio() As Int32
        Get
            Return oInfServTransp.pCSRVNV_Servicio
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then Call pObtenerServTransp(value)
        End Set
    End Property

    Public ReadOnly Property pDescripcionServicio() As String
        Get
            Return oInfServTransp.pTCMTRF_Descripcion
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pObtenerServTransp(ByVal Codigo As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim oTemp As TD_Obj_ServTransp = oServTransp.Obtener(sCompania, sDivision, Codigo, strMensajeError)
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If oTemp.pCSRVNV_Servicio <> 0 Then
                With oInfServTransp
                    .pCSRVNV_Servicio = oTemp.pCSRVNV_Servicio
                    .pTCMTRF_Descripcion = oTemp.pTCMTRF_Descripcion
                End With
            End If
        End If
        If oInfServTransp.pCSRVNV_Servicio <> 0 Then
            cmbServTransp.Text = oInfServTransp.pCSRVNV_Servicio & " - " & oInfServTransp.pTCMTRF_Descripcion
            blnResultado = True
        Else
            cmbServTransp.Text = ""
            strMensajeError = "No existe información."
            RaiseEvent ErrorMessage(strMensajeError)
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub ucServTransp_CmbF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oServTransp.Dispose()
        oServTransp = Nothing
    End Sub

    Private Sub ucTipoAyuda_CmbF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Height = cmbServTransp.Height
    End Sub

    Private Sub cmbServTransp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbServTransp.GotFocus
        If oInfServTransp.pCSRVNV_Servicio <> 0 Then
            cmbServTransp.SelectedText = oInfServTransp.pTCMTRF_Descripcion
            cmbServTransp.SelectAll()
        Else
            cmbServTransp.Text = ""
        End If
    End Sub

    Private Sub cmbServTransp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbServTransp.KeyDown
        If e.KeyCode = Keys.Escape Then
            If oInfServTransp.pCSRVNV_Servicio <> 0 Then
                cmbServTransp.Text = oInfServTransp.pTCMTRF_Descripcion
            Else
                cmbServTransp.Text = ""
            End If
        End If
    End Sub

    Private Sub cmbServTransp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbServTransp.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper()
    End Sub

    Private Sub cmbServTransp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbServTransp.Validating
        If cmbServTransp.SelectedIndex < 0 Then
            If cmbServTransp.Text <> "" Then
                If Not pObtenerServTransp(cmbServTransp.Text) Then e.Cancel = True
            Else
                oInfServTransp.pClear()
                cmbServTransp.Text = ""
            End If
        Else
            If cmbServTransp.SelectedText <> "" Then
                With oInfServTransp
                    .pCSRVNV_Servicio = cmbServTransp.SelectedValue
                    .pTCMTRF_Descripcion = cmbServTransp.Text
                End With
                cmbServTransp.Text = oInfServTransp.pCSRVNV_Servicio & " - " & oInfServTransp.pTCMTRF_Descripcion
            Else
                oInfServTransp.pClear()
                cmbServTransp.Text = ""
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pCargar(ByVal Compania As String, ByVal Division As String)
        sCompania = Compania
        sDivision = Division
        Dim dtTemp As DataTable = oServTransp.fdtListar(sCompania, sDivision)
        If strMensajeError <> "" Then RaiseEvent ErrorMessage(strMensajeError)
        cmbServTransp.DataSource = dtTemp
        If oInfServTransp.pCSRVNV_Servicio <> 0 Then
            cmbServTransp.Text = oInfServTransp.pTCMTRF_Descripcion.Trim
        Else
            cmbServTransp.Text = ""
        End If
    End Sub

    Public Sub pClear()
        oInfServTransp.pClear()
        cmbServTransp.Text = ""
    End Sub
#End Region
End Class
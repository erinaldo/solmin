Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucTransportista_TxtF01
#Region " Definición Eventos "
    Public Shadows Event InformationChanged()
    Public Shadows Event ExitFocusWithOutData()
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oTransportista As cTransportista
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Transportista As TD_Inf_Transportista_L01 = New TD_Inf_Transportista_L01
    Private oQry_Transportista As TD_Qry_Transportista_L01 = New TD_Qry_Transportista_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    Private sAccesoPorUsuario As String = "N"
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private oTransportistaPK As TD_TransportistaPK = New TD_TransportistaPK
#End Region
#Region " Propiedades "
    Public ReadOnly Property pCompania() As String
        Get
            Return oInf_Transportista.pCCMPN_Compania
        End Get
    End Property

    Public ReadOnly Property pPropioTercero() As String
        Get
            Return oInf_Transportista.pSINDRC_PropioTercero
        End Get
    End Property

    Public ReadOnly Property pRucTransportista() As String
        Get
            Return oInf_Transportista.pNRUCTR_RucTransportista
        End Get
    End Property

    Public ReadOnly Property pRazonSocial() As String
        Get
            Return oInf_Transportista.pTCMTRT_RazonSocial
        End Get
    End Property

    Public ReadOnly Property pCodigoRNS() As Int64
        Get
            Return oInf_Transportista.pCTRSPT_CodTransportista
        End Get
    End Property

    Public ReadOnly Property pUsuario() As String
        Get
            Return oTransportistaPK.pUsuario
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return oQry_Transportista.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Transportista.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtTransportista.StateCommon.Back.Color1 = Nothing
            Else
                txtTransportista.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fbBuscar() As Boolean
        '--------------
        ' Variables
        '--------------
        Dim dtTemp As DataTable = Nothing
        Dim blnCancelar As Boolean = False
        ' Limpiamos los filtros existentes
        oQry_Transportista.pClear()
        ' Evaluamos la condición
        If IsNumeric(txtTransportista.Text) Then
            If txtTransportista.Text.Length <= 6 Then oQry_Transportista.pCTRSPT_CodTransportista = txtTransportista.Text
            If txtTransportista.Text.Length > 6 Then oQry_Transportista.pNRUCTR_RucTransportista = txtTransportista.Text
        Else
            Dim sTemp As String = txtTransportista.Text.Replace("*", "")
            Dim iLong As Integer = sTemp.Length
            If IsNumeric(sTemp) Then
                If txtTransportista.Text.Length > 0 Then
                    ' Evaluamos la Asignación
                    If iLong < 6 Then oQry_Transportista.pCTRSPT_CodTransportista = txtTransportista.Text.Trim
                    If iLong >= 6 Then oQry_Transportista.pNRUCTR_RucTransportista = txtTransportista.Text.Trim
                End If
            Else
                ' Busca segun los ingresado sino muestra todo
                If txtTransportista.Text.ToUpper.Trim <> oInf_Transportista.pTCMTRT_RazonSocial.ToUpper Then
                    sTemp = txtTransportista.Text.Trim
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_Transportista.pTCMTRT_RazonSocial = sTemp
                End If
            End If
        End If
        Dim iTPag As Integer = 0
        oQry_Transportista.pCCMPN_Compania = oTransportistaPK.pCCMPN_Compania
        oQry_Transportista.pUsuario = oTransportistaPK.pUsuario
        oQry_Transportista.pNROPAG_NroPagina = 1
        If oQry_Transportista.pREGPAG_NroRegPorPagina <= 0 Then oQry_Transportista.pREGPAG_NroRegPorPagina = 20
        dtTemp = oTransportista.Listar(oQry_Transportista, iTPag)
        '--------------
        ' Proceso
        '--------------
        If oTransportista.ErrorMessage <> "" Then
            MessageBox.Show(oTransportista.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransportista.Text = oInf_Transportista.pTCMTRT_RazonSocial
            txtTransportista.SelectAll()
            blnCancelar = True
        Else
            If dtTemp.Rows.Count = 0 Then
                MessageBox.Show("No existe información que cumpla la condición proporcionada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTransportista.Text = oInf_Transportista.pTCMTRT_RazonSocial
                txtTransportista.SelectAll()
                blnCancelar = True
            Else
                If dtTemp.Rows.Count = 1 Then
                    oInf_Transportista.pCCMPN_Compania = oQry_Transportista.pCCMPN_Compania
                    oInf_Transportista.pNRUCTR_RucTransportista = ("" & dtTemp.Rows(0).Item("NRUCTR")).ToString.Trim
                    oInf_Transportista.pTCMTRT_RazonSocial = ("" & dtTemp.Rows(0).Item("TCMTRT")).ToString.Trim
                    oInf_Transportista.pCTRSPT_CodTransportista = dtTemp.Rows(0).Item("CTRSPT")
                    oInf_Transportista.pSINDRC_PropioTercero = ("" & dtTemp.Rows(0).Item("SINDRC")).ToString.Trim
                    RaiseEvent InformationChanged()
                Else
                    Dim fbusqueda As ucTransportista_FTransportista = New ucTransportista_FTransportista(oQry_Transportista, dtTemp, iTPag)
                    fbusqueda.ShowDialog()
                    If fbusqueda.pSeleccion.pNRUCTR_RucTransportista <> "" Then
                        oInf_Transportista.pCCMPN_Compania = fbusqueda.pSeleccion.pCCMPN_Compania
                        oInf_Transportista.pNRUCTR_RucTransportista = fbusqueda.pSeleccion.pNRUCTR_RucTransportista
                        oInf_Transportista.pTCMTRT_RazonSocial = fbusqueda.pSeleccion.pTCMTRT_RazonSocial
                        oInf_Transportista.pSINDRC_PropioTercero = fbusqueda.pSeleccion.pSINDRC_PropioTercero
                        oInf_Transportista.pCTRSPT_CodTransportista = fbusqueda.pSeleccion.pCTRSPT_CodTransportista
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtTransportista.Text = oInf_Transportista.pTCMTRT_RazonSocial
            End If
        End If
        Return blnCancelar
    End Function

    Private Function pObtenerTransportista() As Boolean
        Dim blnResultado As Boolean = False
        If oTransportistaPK.pNRUCTR_RucTransportista <> "" Then
            ' Obtenemos el Transportista
            Dim objTransportista As TD_Obj_Transportista = oTransportista.Obtener(oTransportistaPK)

            If oTransportista.ErrorMessage <> "" Then
                MessageBox.Show(oTransportista.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If objTransportista.pNRUCTR_RucTransportista <> 0 Then
                    With oInf_Transportista
                        .pCCMPN_Compania = objTransportista.pCCMPN_Compania
                        .pNRUCTR_RucTransportista = objTransportista.pNRUCTR_RucTransportista
                        .pTCMTRT_RazonSocial = objTransportista.pTCMTRT_RazonSocial
                        .pCTRSPT_CodTransportista = objTransportista.pCTRSPT_CodTransportista
                        .pSINDRC_PropioTercero = objTransportista.pSINDRC_PropioTercero
                    End With
                End If
            End If
        Else
            oInf_Transportista.pClear()
        End If
        ' Realizamos la visualización en el control TextBox
        If Me.Focused Then
            txtTransportista.Text = oInf_Transportista.pTCMTRT_RazonSocial
            txtTransportista.SelectAll()
            blnResultado = True
        Else
            If oInf_Transportista.pNRUCTR_RucTransportista <> "" Then
                txtTransportista.Text = oInf_Transportista.pNRUCTR_RucTransportista & " - " & oInf_Transportista.pTCMTRT_RazonSocial
                blnResultado = True
            Else
                txtTransportista.Text = ""
                MessageBox.Show("Transportista no existe.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTransportista.Click
        txtTransportista.Focus()
        Call fbBuscar()
    End Sub

    Private Sub ucTransportista_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtTransportista.Width = Width
        Me.Height = txtTransportista.Height
    End Sub

    Private Sub ucTransportista_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtTransportista.Width = Width
        Me.Height = txtTransportista.Height
    End Sub

    Private Sub txtTransportista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransportista.GotFocus
        txtTransportista.Text = oInf_Transportista.pTCMTRT_RazonSocial
        txtTransportista.SelectAll()
    End Sub

    Private Sub txtTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransportista.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtTransportista.Text = oInf_Transportista.pTCMTRT_RazonSocial
                txtTransportista.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtTransportista.Text = "" Then
                    oInf_Transportista.pClear()
                Else
                    If txtTransportista.Text.ToUpper.Trim <> oInf_Transportista.pTCMTRT_RazonSocial.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtTransportista.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtTransportista_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransportista.Validated
        If oTransportista.ErrorMessage = "" Then
            If oInf_Transportista.pNRUCTR_RucTransportista <> "" Then
                txtTransportista.Text = oInf_Transportista.pNRUCTR_RucTransportista & " - " & oInf_Transportista.pTCMTRT_RazonSocial
            Else
                txtTransportista.Text = ""
                oInf_Transportista.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtTransportista.Text = ""
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtTransportista_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTransportista.Validating
        If txtTransportista.Text = "" Then
            oInf_Transportista.pClear()
        Else
            If IsNumeric(txtTransportista.Text.Trim) Then
                If txtTransportista.Text.Trim <> oInf_Transportista.pNRUCTR_RucTransportista Then e.Cancel = fbBuscar()
            Else
                If txtTransportista.Text.ToUpper.Trim <> oInf_Transportista.pTCMTRT_RazonSocial.ToUpper.Trim Then e.Cancel = fbBuscar()
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oTransportista = New cTransportista
    End Sub

    Public Sub pCargar(ByVal Transportista As TD_TransportistaPK)
        oTransportistaPK.pCCMPN_Compania = Transportista.pCCMPN_Compania
        oTransportistaPK.pNRUCTR_RucTransportista = Transportista.pNRUCTR_RucTransportista
        oTransportistaPK.pUsuario = Transportista.pUsuario.ToUpper.Trim
        If Transportista.pNRUCTR_RucTransportista <> "" Then Call pObtenerTransportista()
    End Sub

    Public Sub pClear()
        oInf_Transportista.pClear()
        txtTransportista.Text = ""
    End Sub

    Public Sub pClearAll()
        oInf_Transportista.pClearAll()
        txtTransportista.Text = ""
    End Sub
#End Region
End Class
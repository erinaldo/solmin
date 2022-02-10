Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucAcopladoTransportista_TxtF01
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
    Private oAcopladoTransportista As cAcopladoTransportista
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_AcopladoTransportista As TD_Inf_AcopladoTransportista_L01 = New TD_Inf_AcopladoTransportista_L01
    Private oQry_AcopladoTransportista As TD_Qry_AcopladoTransportista_L01 = New TD_Qry_AcopladoTransportista_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    Private sAccesoPorUsuario As String = "N"
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private oAcopladoTransportistaPK As TD_AcopladoTransportistaPK = New TD_AcopladoTransportistaPK
#End Region
#Region " Propiedades "
    Public ReadOnly Property pRucTransportista() As String
        Get
            Return oInf_AcopladoTransportista.pNRUCTR_RucTransportista
        End Get
    End Property

    Public ReadOnly Property pCompania() As String
        Get
            Return oInf_AcopladoTransportista.pCCMPN_Compania
        End Get
    End Property

    Public ReadOnly Property pDivision() As String
        Get
            Return oInf_AcopladoTransportista.pCDVSN_Division
        End Get
    End Property

    Public ReadOnly Property pPlanta() As Int32
        Get
            Return oInf_AcopladoTransportista.pCPLNDV_Planta
        End Get
    End Property

    Public ReadOnly Property pNroAcoplado() As String
        Get
            Return oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
        End Get
    End Property

    Public ReadOnly Property pMarca() As String
        Get
            Return oInf_AcopladoTransportista.pTMRCVH_Marca
        End Get
    End Property

    Public ReadOnly Property pDetTipoAcoplado() As Int64
        Get
            Return oInf_AcopladoTransportista.pTDEACP_DetTipoAcoplado
        End Get
    End Property

    Public ReadOnly Property pUsuario() As String
        Get
            Return oAcopladoTransportistaPK.pUsuario
        End Get
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtAcopladoTransportista.StateCommon.Back.Color1 = Nothing
            Else
                txtAcopladoTransportista.StateCommon.Back.Color1 = Color.PaleGoldenrod
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
        oQry_AcopladoTransportista.pClear()
        ' Busca segun los ingresado sino muestra todo
        If txtAcopladoTransportista.Text.ToUpper.Trim <> oInf_AcopladoTransportista.pNPLCAC_NroAcoplado And txtAcopladoTransportista.Text.ToUpper.Trim <> oInf_AcopladoTransportista.pTMRCVH_Marca.ToUpper Then
            ' Condición para el AcopladoTransportista
            Dim sTemp As String = txtAcopladoTransportista.Text.Trim
            If txtAcopladoTransportista.Text.Contains("*") Then
                If sTemp.Replace("*", "").Trim.Length <= 6 Then
                    If sTemp.Length > 0 Then oQry_AcopladoTransportista.pNPLCAC_NroAcoplado = txtAcopladoTransportista.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_AcopladoTransportista.pTMRCVH_Marca = sTemp
                End If
            Else
                If sTemp.Length = 6 Then
                    oQry_AcopladoTransportista.pNPLCAC_NroAcoplado = txtAcopladoTransportista.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_AcopladoTransportista.pTMRCVH_Marca = sTemp
                End If
            End If
        End If
        Dim iTPag As Integer = 0
        oQry_AcopladoTransportista.pNRUCTR_RucTransportista = oAcopladoTransportistaPK.pNRUCTR_RucTransportista
        oQry_AcopladoTransportista.pCCMPN_Compania = oAcopladoTransportistaPK.pCCMPN_Compania
        oQry_AcopladoTransportista.pCDVSN_Division = oAcopladoTransportistaPK.pCDVSN_Division
        oQry_AcopladoTransportista.pCPLNDV_Planta = oAcopladoTransportistaPK.pCPLNDV_Planta
        oQry_AcopladoTransportista.pUsuario = oAcopladoTransportistaPK.pUsuario
        oQry_AcopladoTransportista.pNROPAG_NroPagina = 1
        If oQry_AcopladoTransportista.pREGPAG_NroRegPorPagina <= 0 Then oQry_AcopladoTransportista.pREGPAG_NroRegPorPagina = 20
        dtTemp = oAcopladoTransportista.Listar(oQry_AcopladoTransportista, iTPag)
        '--------------
        ' Proceso
        '--------------
        If oAcopladoTransportista.ErrorMessage <> "" Then
            MessageBox.Show(oAcopladoTransportista.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
            txtAcopladoTransportista.SelectAll()
            blnCancelar = True
        Else
            If dtTemp.Rows.Count = 0 Then
                MessageBox.Show("No existe información que cumpla la condición proporcionada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
                txtAcopladoTransportista.SelectAll()
                blnCancelar = True
            Else
                If dtTemp.Rows.Count = 1 Then
                    oInf_AcopladoTransportista.pNRUCTR_RucTransportista = ("" & dtTemp.Rows(0).Item("NRUCTR")).ToString.Trim
                    oInf_AcopladoTransportista.pCCMPN_Compania = oAcopladoTransportistaPK.pCCMPN_Compania
                    oInf_AcopladoTransportista.pCDVSN_Division = oAcopladoTransportistaPK.pCDVSN_Division
                    oInf_AcopladoTransportista.pCPLNDV_Planta = oAcopladoTransportistaPK.pCPLNDV_Planta
                    oInf_AcopladoTransportista.pNPLCAC_NroAcoplado = ("" & dtTemp.Rows(0).Item("NPLCAC")).ToString.Trim
                    oInf_AcopladoTransportista.pTMRCVH_Marca = ("" & dtTemp.Rows(0).Item("TMRCVH")).ToString.Trim
                    oInf_AcopladoTransportista.pTDEACP_DetTipoAcoplado = ("" & dtTemp.Rows(0).Item("TDEACP")).ToString.Trim
                    RaiseEvent InformationChanged()
                Else
                    ' Llamamos el Formulario para la selección del AcopladoTransportista
                    Dim fbusqueda As ucAcopladoTransportista_FAcoplado = New ucAcopladoTransportista_FAcoplado(oQry_AcopladoTransportista, dtTemp, iTPag)
                    fbusqueda.ShowDialog()
                    If fbusqueda.pSeleccion.pNPLCAC_NroAcoplado <> "" Then
                        oInf_AcopladoTransportista.pNRUCTR_RucTransportista = fbusqueda.pSeleccion.pNRUCTR_RucTransportista
                        oInf_AcopladoTransportista.pCCMPN_Compania = fbusqueda.pSeleccion.pCCMPN_Compania
                        oInf_AcopladoTransportista.pCDVSN_Division = fbusqueda.pSeleccion.pCDVSN_Division
                        oInf_AcopladoTransportista.pCPLNDV_Planta = fbusqueda.pSeleccion.pCPLNDV_Planta
                        oInf_AcopladoTransportista.pNPLCAC_NroAcoplado = fbusqueda.pSeleccion.pNPLCAC_NroAcoplado
                        oInf_AcopladoTransportista.pTMRCVH_Marca = fbusqueda.pSeleccion.pTMRCVH_Marca
                        oInf_AcopladoTransportista.pTDEACP_DetTipoAcoplado = fbusqueda.pSeleccion.pTDEACP_DetTipoAcoplado
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
            End If
        End If
        Return blnCancelar
    End Function

    Private Function pObtenerAcopladoTransportista() As Boolean
        Dim blnResultado As Boolean = False
        If oAcopladoTransportistaPK.pNPLCAC_NroAcoplado <> "" Then
            ' Obtenemos el AcopladoTransportista
            Dim objAcopladoTransportista As TD_Obj_AcopladoTransportista = oAcopladoTransportista.Obtener(oAcopladoTransportistaPK)

            If oAcopladoTransportista.ErrorMessage <> "" Then
                MessageBox.Show(oAcopladoTransportista.ErrorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If objAcopladoTransportista.pNPLCAC_NroAcoplado <> "" Then
                    With oInf_AcopladoTransportista
                        .pNRUCTR_RucTransportista = objAcopladoTransportista.pNRUCTR_RucTransportista
                        .pCCMPN_Compania = objAcopladoTransportista.pCCMPN_Compania
                        .pCDVSN_Division = objAcopladoTransportista.pCDVSN_Division
                        .pCPLNDV_Planta = objAcopladoTransportista.pCPLNDV_Planta
                        .pNPLCAC_NroAcoplado = objAcopladoTransportista.pNPLCAC_NroAcoplado
                        .pTMRCVH_Marca = objAcopladoTransportista.pTMRCVH_Marca
                        .pTDEACP_DetTipoAcoplado = objAcopladoTransportista.pTDEACP_DetTipoAcoplado
                    End With
                End If
            End If
        Else
            oInf_AcopladoTransportista.pClear()
        End If
        ' Realizamos la visualización en el control TextBox
        If Me.Focused Then
            txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
            txtAcopladoTransportista.SelectAll()
            blnResultado = True
        Else
            If oInf_AcopladoTransportista.pNPLCAC_NroAcoplado <> "" Then
                txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
                blnResultado = True
            Else
                txtAcopladoTransportista.Text = ""
                MessageBox.Show("AcopladoTransportista no existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaAcopladoTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAcopladoTransportista.Click
        txtAcopladoTransportista.Focus()
        Call fbBuscar()
    End Sub

    Private Sub ucAcopladoTransportista_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtAcopladoTransportista.Width = Width
        Me.Height = txtAcopladoTransportista.Height
    End Sub

    Private Sub ucAcopladoTransportista_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtAcopladoTransportista.Width = Width
        Me.Height = txtAcopladoTransportista.Height
    End Sub

    Private Sub txtAcopladoTransportista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcopladoTransportista.GotFocus
        txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
        txtAcopladoTransportista.SelectAll()
    End Sub

    Private Sub txtAcopladoTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcopladoTransportista.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado
                txtAcopladoTransportista.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtAcopladoTransportista.Text = "" Then
                    oInf_AcopladoTransportista.pClear()
                Else
                    If txtAcopladoTransportista.Text.ToUpper.Trim <> oInf_AcopladoTransportista.pNPLCAC_NroAcoplado And _
                       txtAcopladoTransportista.Text.ToUpper.Trim <> oInf_AcopladoTransportista.pTMRCVH_Marca.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtAcopladoTransportista.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtAcopladoTransportista_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcopladoTransportista.Validated
        If oAcopladoTransportista.ErrorMessage = "" Then
            If oInf_AcopladoTransportista.pNPLCAC_NroAcoplado <> "" Then
                txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado & " - " & oInf_AcopladoTransportista.pTMRCVH_Marca
            Else
                txtAcopladoTransportista.Text = ""
                oInf_AcopladoTransportista.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtAcopladoTransportista.Text = ""
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtAcopladoTransportista_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAcopladoTransportista.Validating
        If txtAcopladoTransportista.Text = "" Then
            oInf_AcopladoTransportista.pClear()
        Else
            If txtAcopladoTransportista.Text.ToUpper.Trim <> oInf_AcopladoTransportista.pNPLCAC_NroAcoplado And txtAcopladoTransportista.Text.ToUpper.Trim <> oInf_AcopladoTransportista.pTMRCVH_Marca.ToUpper Then
                e.Cancel = fbBuscar()
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oAcopladoTransportista = New cAcopladoTransportista
    End Sub

    Public Sub pCargar(ByVal AcopladoTransportista As TD_AcopladoTransportistaPK)
        oAcopladoTransportistaPK.pNRUCTR_RucTransportista = AcopladoTransportista.pNRUCTR_RucTransportista
        oAcopladoTransportistaPK.pCCMPN_Compania = AcopladoTransportista.pCCMPN_Compania
        oAcopladoTransportistaPK.pCDVSN_Division = AcopladoTransportista.pCDVSN_Division
        oAcopladoTransportistaPK.pCPLNDV_Planta = AcopladoTransportista.pCPLNDV_Planta
        oAcopladoTransportistaPK.pNPLCAC_NroAcoplado = AcopladoTransportista.pNPLCAC_NroAcoplado
        oAcopladoTransportistaPK.pUsuario = AcopladoTransportista.pUsuario.ToUpper.Trim
        If AcopladoTransportista.pNPLCAC_NroAcoplado <> "" Then
            If pObtenerAcopladoTransportista() Then
                If oAcopladoTransportista.ErrorMessage = "" Then
                    If oInf_AcopladoTransportista.pNPLCAC_NroAcoplado <> "" Then
                        txtAcopladoTransportista.Text = oInf_AcopladoTransportista.pNPLCAC_NroAcoplado & " - " & oInf_AcopladoTransportista.pTMRCVH_Marca
                    Else
                        txtAcopladoTransportista.Text = ""
                        oInf_AcopladoTransportista.pClear()
                        RaiseEvent ExitFocusWithOutData()
                    End If
                Else
                    txtAcopladoTransportista.Text = ""
                    RaiseEvent ExitFocusWithOutData()
                End If
            End If
        End If
    End Sub

    Public Sub pClear()
        oInf_AcopladoTransportista.pClear()
        txtAcopladoTransportista.Text = ""
    End Sub

    Public Sub pClearAll()
        oInf_AcopladoTransportista.pClearAll()
        txtAcopladoTransportista.Text = ""
    End Sub
#End Region
End Class
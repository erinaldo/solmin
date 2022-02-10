Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucTractoTransportista_TxtF01
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
    Private oTractoTransportista As cTractoTransportista
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_TractoTransportista As TD_Inf_TractoTransportista_L01 = New TD_Inf_TractoTransportista_L01
    Private oQry_TractoTransportista As TD_Qry_TractoTransportista_L01 = New TD_Qry_TractoTransportista_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    Private sAccesoPorUsuario As String = "N"
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private oTractoTransportistaPK As TD_TractoTransportistaPK = New TD_TractoTransportistaPK
#End Region
#Region " Propiedades "
    Public ReadOnly Property pRucTransportista() As String
        Get
            Return oInf_TractoTransportista.pNRUCTR_RucTransportista
        End Get
    End Property

    Public ReadOnly Property pCompania() As String
        Get
            Return oInf_TractoTransportista.pCCMPN_Compania
        End Get
    End Property

    Public ReadOnly Property pDivision() As String
        Get
            Return oInf_TractoTransportista.pCDVSN_Division
        End Get
    End Property

    Public ReadOnly Property pPlanta() As Int32
        Get
            Return oInf_TractoTransportista.pCPLNDV_Planta
        End Get
    End Property

    Public ReadOnly Property pNroPlacaUnidad() As String
        Get
            Return oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
        End Get
    End Property

    Public ReadOnly Property pMarca_Modelo() As String
        Get
            Return oInf_TractoTransportista.pTMRCTR_Marca_Modelo
        End Get
    End Property

    Public ReadOnly Property pNroMTC() As Int64
        Get
            Return oInf_TractoTransportista.pNRGMT1_NroMTC
        End Get
    End Property

    Public ReadOnly Property pNroAcoplado() As String
        Get
            Return oInf_TractoTransportista.pNPLACP_NroAcoplado
        End Get
    End Property

    Public ReadOnly Property pBrevete() As String
        Get
            Return oInf_TractoTransportista.pCBRCND_Brevete
        End Get
    End Property

    Public ReadOnly Property pUsuario() As String
        Get
            Return oTractoTransportistaPK.pUsuario
        End Get
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtTractoTransportista.StateCommon.Back.Color1 = Nothing
            Else
                txtTractoTransportista.StateCommon.Back.Color1 = Color.PaleGoldenrod
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
        oQry_TractoTransportista.pClear()
        ' Busca segun los ingresado sino muestra todo
        If txtTractoTransportista.Text.ToUpper.Trim <> oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad And txtTractoTransportista.Text.ToUpper.Trim <> oInf_TractoTransportista.pTMRCTR_Marca_Modelo.ToUpper Then
            ' Condición para el TractoTransportista
            Dim sTemp As String = txtTractoTransportista.Text.Trim
            If txtTractoTransportista.Text.Contains("*") Then
                If sTemp.Replace("*", "").Trim.Length <= 6 Then
                    If sTemp.Length > 0 Then oQry_TractoTransportista.pNPLCUN_NroPlacaUnidad = txtTractoTransportista.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_TractoTransportista.pTMRCTR_Marca_Modelo = sTemp
                End If
            Else
                If sTemp.Length = 6 Then
                    oQry_TractoTransportista.pNPLCUN_NroPlacaUnidad = txtTractoTransportista.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_TractoTransportista.pTMRCTR_Marca_Modelo = sTemp
                End If
            End If
        End If
        Dim iTPag As Integer = 0
        oQry_TractoTransportista.pNRUCTR_RucTransportista = oTractoTransportistaPK.pNRUCTR_RucTransportista
        oQry_TractoTransportista.pCCMPN_Compania = oTractoTransportistaPK.pCCMPN_Compania
        oQry_TractoTransportista.pCDVSN_Division = oTractoTransportistaPK.pCDVSN_Division
        oQry_TractoTransportista.pCPLNDV_Planta = oTractoTransportistaPK.pCPLNDV_Planta
        oQry_TractoTransportista.pUsuario = oTractoTransportistaPK.pUsuario
        oQry_TractoTransportista.pNROPAG_NroPagina = 1
        If oQry_TractoTransportista.pREGPAG_NroRegPorPagina <= 0 Then oQry_TractoTransportista.pREGPAG_NroRegPorPagina = 20
        dtTemp = oTractoTransportista.Listar(oQry_TractoTransportista, iTPag)
        '--------------
        ' Proceso
        '--------------
        If oTractoTransportista.ErrorMessage <> "" Then
            MessageBox.Show(oTractoTransportista.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
            txtTractoTransportista.SelectAll()
            blnCancelar = True
        Else
            If dtTemp.Rows.Count = 0 Then
                MessageBox.Show("No existe información que cumpla la condición proporcionada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
                txtTractoTransportista.SelectAll()
                blnCancelar = True
            Else
                If dtTemp.Rows.Count = 1 Then
                    oInf_TractoTransportista.pNRUCTR_RucTransportista = ("" & dtTemp.Rows(0).Item("NRUCTR")).ToString.Trim
                    oInf_TractoTransportista.pCCMPN_Compania = ("" & dtTemp.Rows(0).Item("CCMPN")).ToString.Trim
                    oInf_TractoTransportista.pCDVSN_Division = ("" & dtTemp.Rows(0).Item("CDVSN")).ToString.Trim
                    oInf_TractoTransportista.pCPLNDV_Planta = dtTemp.Rows(0).Item("CPLNDV")
                    oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad = ("" & dtTemp.Rows(0).Item("NPLCUN")).ToString.Trim
                    oInf_TractoTransportista.pTMRCTR_Marca_Modelo = ("" & dtTemp.Rows(0).Item("TMRCTR")).ToString.Trim
                    oInf_TractoTransportista.pNRGMT1_NroMTC = ("" & dtTemp.Rows(0).Item("NRGMT1")).ToString.Trim
                    oInf_TractoTransportista.pNPLACP_NroAcoplado = ("" & dtTemp.Rows(0).Item("NPLACP")).ToString.Trim
                    oInf_TractoTransportista.pCBRCND_Brevete = ("" & dtTemp.Rows(0).Item("CBRCND")).ToString.Trim
                    RaiseEvent InformationChanged()
                Else
                    ' Llamamos el Formulario para la selección del TractoTransportista
                    Dim fbusqueda As ucTractoTransportista_FTracto = New ucTractoTransportista_FTracto(oQry_TractoTransportista, dtTemp, iTPag)
                    fbusqueda.ShowDialog()
                    If fbusqueda.pSeleccion.pNPLCUN_NroPlacaUnidad <> "" Then
                        oInf_TractoTransportista.pNRUCTR_RucTransportista = fbusqueda.pSeleccion.pNRUCTR_RucTransportista
                        oInf_TractoTransportista.pCCMPN_Compania = fbusqueda.pSeleccion.pCCMPN_Compania
                        oInf_TractoTransportista.pCDVSN_Division = fbusqueda.pSeleccion.pCDVSN_Division
                        oInf_TractoTransportista.pCPLNDV_Planta = fbusqueda.pSeleccion.pCPLNDV_Planta
                        oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad = fbusqueda.pSeleccion.pNPLCUN_NroPlacaUnidad
                        oInf_TractoTransportista.pTMRCTR_Marca_Modelo = fbusqueda.pSeleccion.pTMRCTR_Marca_Modelo
                        oInf_TractoTransportista.pNRGMT1_NroMTC = fbusqueda.pSeleccion.pNRGMT1_NroMTC
                        oInf_TractoTransportista.pNPLACP_NroAcoplado = fbusqueda.pSeleccion.pNPLACP_NroAcoplado
                        oInf_TractoTransportista.pCBRCND_Brevete = fbusqueda.pSeleccion.pCBRCND_Brevete
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
            End If
        End If
        Return blnCancelar
    End Function

    Private Function pObtenerTractoTransportista() As Boolean
        Dim blnResultado As Boolean = False
        If oTractoTransportistaPK.pNPLCUN_NroPlacaUnidad <> "" Then
            ' Obtenemos el TractoTransportista
            Dim objTractoTransportista As TD_Obj_TractoTransportista = oTractoTransportista.Obtener(oTractoTransportistaPK)

            If oTractoTransportista.ErrorMessage <> "" Then
                MessageBox.Show(oTractoTransportista.ErrorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If objTractoTransportista.pNPLCUN_NroPlacaUnidad <> "" Then
                    With oInf_TractoTransportista
                        .pNRUCTR_RucTransportista = objTractoTransportista.pNRUCTR_RucTransportista
                        .pCCMPN_Compania = objTractoTransportista.pCCMPN_Compania
                        .pCDVSN_Division = objTractoTransportista.pCDVSN_Division
                        .pCPLNDV_Planta = objTractoTransportista.pCPLNDV_Planta
                        .pNPLCUN_NroPlacaUnidad = objTractoTransportista.pNPLCUN_NroPlacaUnidad
                        .pTMRCTR_Marca_Modelo = objTractoTransportista.pTMRCTR_Marca_Modelo
                        .pNRGMT1_NroMTC = objTractoTransportista.pNRGMT1_NroMTC
                        .pNPLACP_NroAcoplado = objTractoTransportista.pNPLACP_NroAcoplado
                        .pCBRCND_Brevete = objTractoTransportista.pCBRCND_Brevete
                    End With
                End If
            End If
        Else
            oInf_TractoTransportista.pClear()
        End If
        ' Realizamos la visualización en el control TextBox
        If Me.Focused Then
            txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
            txtTractoTransportista.SelectAll()
            blnResultado = True
        Else
            If oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad <> "" Then
                txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
                blnResultado = True
            Else
                txtTractoTransportista.Text = ""
                MessageBox.Show("Tracto asociado al Transportista no existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaTractoTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTractoTransportista.Click
        txtTractoTransportista.Focus()
        Call fbBuscar()
    End Sub

    Private Sub ucTractoTransportista_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtTractoTransportista.Width = Width
        Me.Height = txtTractoTransportista.Height
    End Sub

    Private Sub ucTractoTransportista_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtTractoTransportista.Width = Width
        Me.Height = txtTractoTransportista.Height
    End Sub

    Private Sub txtTractoTransportista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTractoTransportista.GotFocus
        txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
        txtTractoTransportista.SelectAll()
    End Sub

    Private Sub txtTractoTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTractoTransportista.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad
                txtTractoTransportista.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtTractoTransportista.Text = "" Then
                    oInf_TractoTransportista.pClear()
                Else
                    If txtTractoTransportista.Text.ToUpper.Trim <> oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad And _
                       txtTractoTransportista.Text.ToUpper.Trim <> oInf_TractoTransportista.pTMRCTR_Marca_Modelo.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtTractoTransportista.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtTractoTransportista_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTractoTransportista.Validated
        If oTractoTransportista.ErrorMessage = "" Then
            If oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad <> "" Then
                txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad & " - " & oInf_TractoTransportista.pTMRCTR_Marca_Modelo
            Else
                txtTractoTransportista.Text = ""
                oInf_TractoTransportista.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtTractoTransportista.Text = ""
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtTractoTransportista_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTractoTransportista.Validating
        If txtTractoTransportista.Text = "" Then
            oInf_TractoTransportista.pClear()
        Else
            If txtTractoTransportista.Text.ToUpper.Trim <> oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad And txtTractoTransportista.Text.ToUpper.Trim <> oInf_TractoTransportista.pTMRCTR_Marca_Modelo.ToUpper Then
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
        oTractoTransportista = New cTractoTransportista
    End Sub

    Public Sub pCargar(ByVal TractoTransportista As TD_TractoTransportistaPK)
        oTractoTransportistaPK.pNRUCTR_RucTransportista = TractoTransportista.pNRUCTR_RucTransportista
        oTractoTransportistaPK.pCCMPN_Compania = TractoTransportista.pCCMPN_Compania
        oTractoTransportistaPK.pCDVSN_Division = TractoTransportista.pCDVSN_Division
        oTractoTransportistaPK.pCPLNDV_Planta = TractoTransportista.pCPLNDV_Planta
        oTractoTransportistaPK.pNPLCUN_NroPlacaUnidad = TractoTransportista.pNPLCUN_NroPlacaUnidad
        oTractoTransportistaPK.pUsuario = TractoTransportista.pUsuario.ToUpper.Trim
        If TractoTransportista.pNPLCUN_NroPlacaUnidad <> "" Then
            If pObtenerTractoTransportista() Then
                If oTractoTransportista.ErrorMessage = "" Then
                    If oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad <> "" Then
                        txtTractoTransportista.Text = oInf_TractoTransportista.pNPLCUN_NroPlacaUnidad & " - " & oInf_TractoTransportista.pTMRCTR_Marca_Modelo
                    Else
                        txtTractoTransportista.Text = ""
                        oInf_TractoTransportista.pClear()
                        RaiseEvent ExitFocusWithOutData()
                    End If
                Else
                    txtTractoTransportista.Text = ""
                    RaiseEvent ExitFocusWithOutData()
                End If
            End If
        End If
    End Sub

    Public Sub pClear()
        oInf_TractoTransportista.pClear()
        txtTractoTransportista.Text = ""
    End Sub

    Public Sub pClearAll()
        oInf_TractoTransportista.pClearAll()
        txtTractoTransportista.Text = ""
    End Sub
#End Region
End Class
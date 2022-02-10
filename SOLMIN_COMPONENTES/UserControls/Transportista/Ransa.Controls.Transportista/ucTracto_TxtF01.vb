Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucTracto_TxtF01
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
    Private oTracto As cTracto
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Tracto As TD_Inf_Tracto_L01 = New TD_Inf_Tracto_L01
    Private oQry_Tracto As TD_Qry_Tracto_L01 = New TD_Qry_Tracto_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    Private sAccesoPorUsuario As String = "N"
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private oTractoPK As TD_TractoPK = New TD_TractoPK
#End Region
#Region " Propiedades "
    Public ReadOnly Property pCompania() As String
        Get
            Return oInf_Tracto.pCCMPN_Compania
        End Get
    End Property

    Public ReadOnly Property pNroPlacaUnidad() As String
        Get
            Return oInf_Tracto.pNPLCUN_NroPlacaUnidad
        End Get
    End Property

    Public ReadOnly Property pMarca_Modelo() As String
        Get
            Return oInf_Tracto.pTMRCTR_Marca_Modelo
        End Get
    End Property

    Public ReadOnly Property pNroMTC() As Int64
        Get
            Return oInf_Tracto.pNRGMT1_NroMTC
        End Get
    End Property

    Public ReadOnly Property pUsuario() As String
        Get
            Return oTractoPK.pUsuario
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return oQry_Tracto.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Tracto.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtTracto.StateCommon.Back.Color1 = Nothing
            Else
                txtTracto.StateCommon.Back.Color1 = Color.PaleGoldenrod
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
        oQry_Tracto.pClear()
        ' Busca segun los ingresado sino muestra todo
        If txtTracto.Text.ToUpper.Trim <> oInf_Tracto.pNPLCUN_NroPlacaUnidad And txtTracto.Text.ToUpper.Trim <> oInf_Tracto.pTMRCTR_Marca_Modelo.ToUpper Then
            ' Condición para el Tracto
            Dim sTemp As String = txtTracto.Text.Trim
            If txtTracto.Text.Contains("*") Then
                If sTemp.Replace("*", "").Trim.Length <= 6 Then
                    If sTemp.Length > 0 Then oQry_Tracto.pNPLCUN_NroPlacaUnidad = txtTracto.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_Tracto.pTMRCTR_Marca_Modelo = sTemp
                End If
            Else
                If sTemp.Length = 6 Then
                    oQry_Tracto.pNPLCUN_NroPlacaUnidad = txtTracto.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_Tracto.pTMRCTR_Marca_Modelo = sTemp
                End If
            End If
        End If
        Dim iTPag As Integer = 0
        oQry_Tracto.pCCMPN_Compania = oTractoPK.pCCMPN_Compania
        oQry_Tracto.pUsuario = oTractoPK.pUsuario
        oQry_Tracto.pNROPAG_NroPagina = 1
        If oQry_Tracto.pREGPAG_NroRegPorPagina <= 0 Then oQry_Tracto.pREGPAG_NroRegPorPagina = 20
        dtTemp = oTracto.Listar(oQry_Tracto, iTPag)
        '--------------
        ' Proceso
        '--------------
        If oTracto.ErrorMessage <> "" Then
            MessageBox.Show(oTracto.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad
            txtTracto.SelectAll()
            blnCancelar = True
        Else
            If dtTemp.Rows.Count = 0 Then
                MessageBox.Show("No existe información que cumpla la condición proporcionada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad
                txtTracto.SelectAll()
                blnCancelar = True
            Else
                If dtTemp.Rows.Count = 1 Then
                    oInf_Tracto.pCCMPN_Compania = oQry_Tracto.pCCMPN_Compania
                    oInf_Tracto.pNPLCUN_NroPlacaUnidad = ("" & dtTemp.Rows(0).Item("NPLCUN")).ToString.Trim
                    oInf_Tracto.pTMRCTR_Marca_Modelo = ("" & dtTemp.Rows(0).Item("TMRCTR")).ToString.Trim
                    oInf_Tracto.pNRGMT1_NroMTC = ("" & dtTemp.Rows(0).Item("NRGMT1")).ToString.Trim
                    RaiseEvent InformationChanged()
                Else
                    ' Llamamos el Formulario para la selección del Tracto
                    Dim fbusqueda As ucTracto_FTracto = New ucTracto_FTracto(oQry_Tracto, dtTemp, iTPag)
                    fbusqueda.ShowDialog()
                    If fbusqueda.pSeleccion.pNPLCUN_NroPlacaUnidad <> "" Then
                        oInf_Tracto.pCCMPN_Compania = oQry_Tracto.pCCMPN_Compania
                        oInf_Tracto.pNPLCUN_NroPlacaUnidad = fbusqueda.pSeleccion.pNPLCUN_NroPlacaUnidad
                        oInf_Tracto.pTMRCTR_Marca_Modelo = fbusqueda.pSeleccion.pTMRCTR_Marca_Modelo
                        oInf_Tracto.pNRGMT1_NroMTC = fbusqueda.pSeleccion.pNRGMT1_NroMTC
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad
            End If
        End If
        Return blnCancelar
    End Function

    Private Function pObtenerTracto() As Boolean
        Dim blnResultado As Boolean = False
        If oTractoPK.pNPLCUN_NroPlacaUnidad <> "" Then
            ' Obtenemos el Tracto
            Dim objTracto As TD_Obj_Tracto = oTracto.Obtener(oTractoPK)

            If oTracto.ErrorMessage <> "" Then
                MessageBox.Show(oTracto.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If objTracto.pNPLCUN_NroPlacaUnidad <> 0 Then
                    With oInf_Tracto
                        .pCCMPN_Compania = objTracto.pCCMPN_Compania
                        .pNPLCUN_NroPlacaUnidad = objTracto.pNPLCUN_NroPlacaUnidad
                        .pTMRCTR_Marca_Modelo = objTracto.pTMRCTR_Marca_Modelo
                        .pNRGMT1_NroMTC = objTracto.pNRGMT1_NroMTC
                    End With
                End If
            End If
        Else
            oInf_Tracto.pClear()
        End If
        ' Realizamos la visualización en el control TextBox
        If Me.Focused Then
            txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad
            txtTracto.SelectAll()
            blnResultado = True
        Else
            If oInf_Tracto.pNPLCUN_NroPlacaUnidad <> "" Then
                txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad
                blnResultado = True
            Else
                txtTracto.Text = ""
                MessageBox.Show("Tracto no existe.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaTracto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTracto.Click
        txtTracto.Focus()
        Call fbBuscar()
    End Sub

    Private Sub ucTracto_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtTracto.Width = Width
        Me.Height = txtTracto.Height
    End Sub

    Private Sub ucTracto_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtTracto.Width = Width
        Me.Height = txtTracto.Height
    End Sub

    Private Sub txtTracto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTracto.GotFocus
        txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad
        txtTracto.SelectAll()
    End Sub

    Private Sub txtTracto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTracto.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad
                txtTracto.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtTracto.Text = "" Then
                    oInf_Tracto.pClear()
                Else
                    If txtTracto.Text.ToUpper.Trim <> oInf_Tracto.pNPLCUN_NroPlacaUnidad And _
                       txtTracto.Text.ToUpper.Trim <> oInf_Tracto.pTMRCTR_Marca_Modelo.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtTracto.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtTracto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTracto.Validated
        If oTracto.ErrorMessage = "" Then
            If oInf_Tracto.pNPLCUN_NroPlacaUnidad <> "" Then
                txtTracto.Text = oInf_Tracto.pNPLCUN_NroPlacaUnidad & " - " & oInf_Tracto.pTMRCTR_Marca_Modelo
            Else
                txtTracto.Text = ""
                oInf_Tracto.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtTracto.Text = ""
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtTracto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTracto.Validating
        If txtTracto.Text = "" Then
            oInf_Tracto.pClear()
        Else
            If txtTracto.Text.ToUpper.Trim <> oInf_Tracto.pNPLCUN_NroPlacaUnidad And txtTracto.Text.ToUpper.Trim <> oInf_Tracto.pTMRCTR_Marca_Modelo.ToUpper Then
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
        oTracto = New cTracto
    End Sub

    Public Sub pCargar(ByVal Tracto As TD_TractoPK)
        oTractoPK.pCCMPN_Compania = Tracto.pCCMPN_Compania
        oTractoPK.pNPLCUN_NroPlacaUnidad = Tracto.pNPLCUN_NroPlacaUnidad
        oTractoPK.pUsuario = Tracto.pUsuario.ToUpper.Trim
        If Tracto.pNPLCUN_NroPlacaUnidad <> "" Then Call pObtenerTracto()
    End Sub

    Public Sub pClear()
        oInf_Tracto.pClear()
        txtTracto.Text = ""
    End Sub

    Public Sub pClearAll()
        oInf_Tracto.pClearAll()
        txtTracto.Text = ""
    End Sub
#End Region
End Class
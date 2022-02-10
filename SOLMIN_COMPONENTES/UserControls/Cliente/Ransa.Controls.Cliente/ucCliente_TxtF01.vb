Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TYPEDEF.Cliente
'Imports Ransa.DAO.Cliente

Public Class ucCliente_TxtF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Shadows Event InformationChanged()
    Public Shadows Event ExitFocusWithOutData()
    'Public Shadows Event TextChanged(ByVal oInf_Cliente As TD_Inf_Cliente_L01)
    Public Shadows Event TextChanged()
#End Region
#Region " Tipo "
    Public Enum eTipoCliente
        Normal = 0
        Especial = 1
    End Enum

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oCliente As cCliente
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Cliente As TD_Inf_Cliente_L01 = New TD_Inf_Cliente_L01
    Private oQry_Cliente As TD_Qry_Cliente_L01 = New TD_Qry_Cliente_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    Private sTipoCliente As eTipoCliente = 0

    Private sAccesoPorUsuario As String = "N"
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private oClientePK As TD_ClientePK = New TD_ClientePK
#End Region
#Region " Propiedades "
    Private _CCMPN As String = ""

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)

            If value = Nothing Then
                _CCMPN = "EZ"
            Else
                _CCMPN = value
            End If
        End Set
    End Property

    Public ReadOnly Property pCodigo() As Int64
        Get
            Return oInf_Cliente.pCCLNT_Cliente
        End Get
    End Property
 

    Public ReadOnly Property pRazonSocial() As String
        Get
            Return oInf_Cliente.pTCMPCL_DescripcionCliente
        End Get
    End Property


    Public ReadOnly Property pNroRuc() As Int64
        Get
            Return oInf_Cliente.pNRUC_NroRUC
        End Get
    End Property

    Public ReadOnly Property pDireccionOrigen() As String
        Get
            Return oInf_Cliente.pTDRCOR_DireccionOrigen
        End Get
    End Property

    Public ReadOnly Property pNroDocIdentidad() As Int64
        Get
            Return oInf_Cliente.pNLBTEL_NroDocIdentidad
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            If oClientePK.pUsuario <> value.ToUpper.Trim Then
                oClientePK.pUsuario = value.ToUpper.Trim
            End If
        End Set
    End Property

    Public Property pAccesoPorUsuario() As Boolean
        Get
            Dim bTemp As Boolean = False
            If sAccesoPorUsuario = "S" Then bTemp = True
            Return bTemp
        End Get
        Set(ByVal value As Boolean)
            Dim sTemp As String = "N"
            If value Then sTemp = "S"
            sAccesoPorUsuario = sTemp
        End Set
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtCliente.StateCommon.Back.Color1 = Nothing
            Else
                txtCliente.StateCommon.Back.Color1 = ColorTranslator.FromHtml("#FFFFC0") 'Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public Property pTipoCliente() As eTipoCliente
        Get
            Return sTipoCliente
        End Get
        Set(ByVal value As eTipoCliente)
            If value = Nothing Then
                sTipoCliente = 0
            Else
                sTipoCliente = value
            End If
        End Set
    End Property

    '<[AHM]>
    Dim _pCDDRSP_CodClienteSAP As String = ""
    Public Property pCDDRSP_CodClienteSAP() As String
        Get
            Return oInf_Cliente.pCDDRSP_CodClienteSAP
        End Get
        Set(ByVal value As String)
            oInf_Cliente.pCDDRSP_CodClienteSAP = value
        End Set
    End Property
    Public Property pVisualizaNegocio() As Boolean
        Get
            Return oInf_Cliente.pVisualizarNegocio
        End Get
        Set(ByVal value As Boolean)
            oInf_Cliente.pVisualizarNegocio = value
        End Set
    End Property

    Public ReadOnly Property pNegocio() As String
        Get
            Return oInf_Cliente.pCRGVTA_CodigoRegionVenta
        End Get
    End Property

    Public ReadOnly Property pNegocioDescripcion() As String
        Get
            Return oInf_Cliente.pTCRVTA_DescripcionRegionVenta
        End Get
    End Property

    Public ReadOnly Property pSector() As String
        Get
            Return oInf_Cliente.pCDSCSP_CodigoSector
        End Get
    End Property
    '/<[AHM]>
#End Region
#Region " Funciones y Procedimientos "
    Private Function fbBuscar() As Boolean
        '--------------
        ' Variables
        '--------------
        Dim dtTemp As DataTable = Nothing
        Dim blnCancelar As Boolean = False
        ' Limpiamos los filtros existentes
        oQry_Cliente.pClear()
        ' Evaluamos la condición
        If IsNumeric(txtCliente.Text) Then
            If txtCliente.Text.Length <= 6 Then oQry_Cliente.pCCLNT_Cliente = txtCliente.Text
            If txtCliente.Text.Length > 6 Then oQry_Cliente.pNRUC_NroRUC = txtCliente.Text
        Else
            Dim sTemp As String = txtCliente.Text.Replace("*", "")
            Dim iLong As Integer = sTemp.Length
            If IsNumeric(sTemp) Then
                If txtCliente.Text.Length > 0 Then
                    ' Evaluamos la Asignación
                    If iLong < 6 Then oQry_Cliente.pCCLNT_Cliente = txtCliente.Text.Trim
                    If iLong >= 6 Then oQry_Cliente.pNRUC_NroRUC = txtCliente.Text.Trim
                End If
            Else
                ' Busca segun los ingresado sino muestra todo
                If txtCliente.Text.ToUpper.Trim <> oInf_Cliente.pTCMPCL_DescripcionCliente.ToUpper Then
                    sTemp = txtCliente.Text.Trim
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_Cliente.pTCMPCL_DescripcionCliente = sTemp
                End If
            End If
        End If
        Dim iTPag As Integer = 0
        oQry_Cliente.pUsuario = oClientePK.pUsuario
        oQry_Cliente.pNROPAG_NroPagina = 1
        oQry_Cliente.pREGPAG_NroRegPorPagina = 20
        oQry_Cliente.pCCMPN_CodigoCompania = _CCMPN

        'sTipoCliente = 0 Normal = 1  Especial
        dtTemp = oCliente.Listar(oQry_Cliente, sAccesoPorUsuario, iTPag, sTipoCliente)
        '--------------
        ' Proceso
        '--------------
        If oCliente.ErrorMessage <> "" Then
            RaiseEvent ErrorMessage(oCliente.ErrorMessage)
            txtCliente.Text = oInf_Cliente.pTCMPCL_DescripcionCliente
            txtCliente.SelectAll()
            blnCancelar = True
        Else
            If dtTemp.Rows.Count = 0 Then
                RaiseEvent ErrorMessage("No existe información que cumpla la condición proporcionada.")
                txtCliente.Text = oInf_Cliente.pTCMPCL_DescripcionCliente
                txtCliente.SelectAll()
                blnCancelar = True
            Else
                If dtTemp.Rows.Count = 1 Then
                    oInf_Cliente.pCCLNT_Cliente = dtTemp.Rows(0).Item("CCLNT")
                    oInf_Cliente.pTCMPCL_DescripcionCliente = ("" & dtTemp.Rows(0).Item("TCMPCL")).ToString.Trim
                    oInf_Cliente.pNRUC_NroRUC = dtTemp.Rows(0).Item("NRUC")
                    oInf_Cliente.pTDRCOR_DireccionOrigen = ("" & dtTemp.Rows(0).Item("TDRCOR")).ToString.Trim
                    oInf_Cliente.pNLBTEL_NroDocIdentidad = dtTemp.Rows(0).Item("NLBTEL")
                    '<[AHM]>
                    oInf_Cliente.pCRGVTA_CodigoRegionVenta = dtTemp.Rows(0).Item("CRGVTA")
                    oInf_Cliente.pTCRVTA_DescripcionRegionVenta = dtTemp.Rows(0).Item("TCRVTA")
                    oInf_Cliente.pCDSCSP_CodigoSector = dtTemp.Rows(0).Item("CDSCSP")
                    oInf_Cliente.pCDDRSP_CodClienteSAP = dtTemp.Rows(0).Item("CDDRSP").ToString().Trim()
                    '</[AHM]>
                            RaiseEvent InformationChanged()
                Else
                    Dim bTemp As Boolean = False
                    If sAccesoPorUsuario = "S" Then bTemp = True
                    'sTipoCliente = 0 Normal = 1 Especial    
                    oQry_Cliente.pVisualizarNegocio = Me.pVisualizaNegocio
                    Dim fbusqueda As ucCliente_FCliente = New ucCliente_FCliente(oQry_Cliente, dtTemp, iTPag, bTemp, sTipoCliente)
                    fbusqueda.ShowDialog()
                    If fbusqueda.pSeleccion.pCCLNT_Cliente <> 0 Then
                        oInf_Cliente.pCCLNT_Cliente = fbusqueda.pSeleccion.pCCLNT_Cliente
                        oInf_Cliente.pTCMPCL_DescripcionCliente = fbusqueda.pSeleccion.pTCMPCL_DescripcionCliente
                        oInf_Cliente.pTDRCOR_DireccionOrigen = fbusqueda.pSeleccion.pTDRCOR_DireccionOrigen
                        oInf_Cliente.pNRUC_NroRUC = fbusqueda.pSeleccion.pNRUC_NroRUC
                        oInf_Cliente.pNLBTEL_NroDocIdentidad = fbusqueda.pSeleccion.pNLBTEL_NroDocIdentidad
                        '<[AHM]>
                        oInf_Cliente.pCRGVTA_CodigoRegionVenta = fbusqueda.pSeleccion.pCRGVTA_CodigoRegionVenta
                        oInf_Cliente.pTCRVTA_DescripcionRegionVenta = fbusqueda.pSeleccion.pTCRVTA_DescripcionRegionVenta
                        oInf_Cliente.pCDSCSP_CodigoSector = fbusqueda.pSeleccion.pCDSCSP_CodigoSector
                        oInf_Cliente.pCDDRSP_CodClienteSAP = fbusqueda.pSeleccion.pCDDRSP_CodClienteSAP
                        '</[AHM]>
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtCliente.Text = oInf_Cliente.pTCMPCL_DescripcionCliente
                RaiseEvent TextChanged()
            End If
        End If
        Return blnCancelar
    End Function

    Private Function pObtenerCliente() As Boolean
        Dim blnResultado As Boolean = False
        If oClientePK.pCCLNT_Cliente <> 0 Then
            ' Obtenemos el Cliente
            Dim objCliente As TD_Obj_Cliente = oCliente.Obtener(oClientePK, sAccesoPorUsuario)

            If oCliente.ErrorMessage <> "" Then
                RaiseEvent ErrorMessage(oCliente.ErrorMessage)
            Else
                If objCliente.pCCLNT_Cliente <> 0 Then
                    With oInf_Cliente
                        .pCCLNT_Cliente = objCliente.pCCLNT_Cliente
                        .pTCMPCL_DescripcionCliente = objCliente.pTCMPCL_DescripcionCliente
                        .pTDRCOR_DireccionOrigen = objCliente.pTDRCOR_DireccionOrigen
                        .pNRUC_NroRUC = objCliente.pNRUC_NroRUC
                        .pNLBTEL_NroDocIdentidad = objCliente.pNLBTEL_NroDocIdentidad
                        '<[AHM]>
                        .pCRGVTA_CodigoRegionVenta = objCliente.pCRGVTA_CodigoRegionVenta
                        .pTCRVTA_DescripcionRegionVenta = objCliente.pTCRVTA_DescripcionRegionVenta
                        .pCDSCSP_CodigoSector = objCliente.pCDSCSP_CodigoSector
                        .pCDDRSP_CodClienteSAP = objCliente.pCDDRSP_CodClienteSAP
                        '</[AHM]>
                    End With
                End If
            End If
        Else
            oInf_Cliente.pClear()
        End If
        ' Realizamos la visualización en el control TextBox
        If Me.Focused Then
            txtCliente.Text = oInf_Cliente.pTCMPCL_DescripcionCliente
            txtCliente.SelectAll()
            blnResultado = True
        Else
            If oInf_Cliente.pCCLNT_Cliente <> 0 Then
                txtCliente.Text = oInf_Cliente.pCCLNT_Cliente & " - " & oInf_Cliente.pTCMPCL_DescripcionCliente
                blnResultado = True
            Else
                txtCliente.Text = ""
                RaiseEvent ErrorMessage("Cliente no existe.")
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCliente.Click
        txtCliente.Focus() 
        Call fbBuscar()
    End Sub

    Private Sub ucCliente_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCliente.Width = Width
        Me.Height = txtCliente.Height
    End Sub

    Private Sub ucCliente_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtCliente.Width = Width
        Me.Height = txtCliente.Height
    End Sub

    Private Sub txtCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.GotFocus
        txtCliente.Text = oInf_Cliente.pTCMPCL_DescripcionCliente
        txtCliente.SelectAll()
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtCliente.Text = oInf_Cliente.pTCMPCL_DescripcionCliente
                txtCliente.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtCliente.Text = "" Then
                    oInf_Cliente.pClear()
                Else
                    If txtCliente.Text.ToUpper.Trim <> oInf_Cliente.pTCMPCL_DescripcionCliente.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtCliente.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Validated
        If oCliente.ErrorMessage = "" Then
            If oInf_Cliente.pCCLNT_Cliente <> 0 Then
                txtCliente.Text = oInf_Cliente.pCCLNT_Cliente & " - " & oInf_Cliente.pTCMPCL_DescripcionCliente
            Else
                txtCliente.Text = ""
                RaiseEvent TextChanged()
                oInf_Cliente.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtCliente.Text = ""
            RaiseEvent TextChanged()
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If txtCliente.Text = "" Then
            oInf_Cliente.pClear()
        Else
            If IsNumeric(txtCliente.Text.Trim) Then
                If txtCliente.Text.Trim <> oInf_Cliente.pCCLNT_Cliente Then e.Cancel = fbBuscar()
            Else
                If txtCliente.Text.ToUpper.Trim <> oInf_Cliente.pTCMPCL_DescripcionCliente.ToUpper.Trim Then e.Cancel = fbBuscar()
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oCliente = New cCliente
    End Sub

    Public Sub pCargar(ByVal Cliente As TD_ClientePK)
        oClientePK.pCCLNT_Cliente = Cliente.pCCLNT_Cliente
        oClientePK.pUsuario = Cliente.pUsuario.ToUpper.Trim
        oClientePK.pCCMPN_CodigoCompania = _CCMPN
        If Cliente.pCCLNT_Cliente <> 0 Then Call pObtenerCliente()
    End Sub

    Public Sub pCargar(ByVal Cliente As Int64)
        oClientePK.pCCLNT_Cliente = Cliente
        oClientePK.pCCMPN_CodigoCompania = _CCMPN
        If Cliente <> 0 Then Call pObtenerCliente()
    End Sub

    Public Sub pClear()
        oInf_Cliente.pClear()
        txtCliente.Text = ""
    End Sub
#End Region

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
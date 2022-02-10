Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucAcoplado_TxtF01
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
    Private oAcoplado As cAcoplado
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Acoplado As TD_Inf_Acoplado_L01 = New TD_Inf_Acoplado_L01
    Private oQry_Acoplado As TD_Qry_Acoplado_L01 = New TD_Qry_Acoplado_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    Private sAccesoPorUsuario As String = "N"
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private oAcopladoPK As TD_AcopladoPK = New TD_AcopladoPK
#End Region
#Region " Propiedades "
    Public ReadOnly Property pCompania() As String
        Get
            Return oInf_Acoplado.pCCMPN_Compania
        End Get
    End Property

    Public ReadOnly Property pNroAcoplado() As String
        Get
            Return oInf_Acoplado.pNPLCAC_NroAcoplado
        End Get
    End Property

    Public ReadOnly Property pMarca() As String
        Get
            Return oInf_Acoplado.pTMRCVH_Marca
        End Get
    End Property

    Public ReadOnly Property pDetTipoAcoplado() As Int64
        Get
            Return oInf_Acoplado.pTDEACP_DetTipoAcoplado
        End Get
    End Property

    Public ReadOnly Property pUsuario() As String
        Get
            Return oAcopladoPK.pUsuario
        End Get
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtAcoplado.StateCommon.Back.Color1 = Nothing
            Else
                txtAcoplado.StateCommon.Back.Color1 = Color.PaleGoldenrod
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
        oQry_Acoplado.pClear()
        ' Busca segun los ingresado sino muestra todo
        If txtAcoplado.Text.ToUpper.Trim <> oInf_Acoplado.pNPLCAC_NroAcoplado And txtAcoplado.Text.ToUpper.Trim <> oInf_Acoplado.pTMRCVH_Marca.ToUpper Then
            ' Condición para el Acoplado
            Dim sTemp As String = txtAcoplado.Text.Trim
            If txtAcoplado.Text.Contains("*") Then
                If sTemp.Replace("*", "").Trim.Length <= 6 Then
                    If sTemp.Length > 0 Then oQry_Acoplado.pNPLCAC_NroAcoplado = txtAcoplado.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_Acoplado.pTMRCVH_Marca = sTemp
                End If
            Else
                If sTemp.Length = 6 Then
                    oQry_Acoplado.pNPLCAC_NroAcoplado = txtAcoplado.Text
                Else
                    If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                    If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                    oQry_Acoplado.pTMRCVH_Marca = sTemp
                End If
            End If
        End If
        Dim iTPag As Integer = 0
        oQry_Acoplado.pCCMPN_Compania = oAcopladoPK.pCCMPN_Compania
        oQry_Acoplado.pUsuario = oAcopladoPK.pUsuario
        oQry_Acoplado.pNROPAG_NroPagina = 1
        If oQry_Acoplado.pREGPAG_NroRegPorPagina <= 0 Then oQry_Acoplado.pREGPAG_NroRegPorPagina = 20
        dtTemp = oAcoplado.Listar(oQry_Acoplado, iTPag)
        '--------------
        ' Proceso
        '--------------
        If oAcoplado.ErrorMessage <> "" Then
            MessageBox.Show(oAcoplado.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado
            txtAcoplado.SelectAll()
            blnCancelar = True
        Else
            If dtTemp.Rows.Count = 0 Then
                MessageBox.Show("No existe información que cumpla la condición proporcionada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado
                txtAcoplado.SelectAll()
                blnCancelar = True
            Else
                If dtTemp.Rows.Count = 1 Then
                    oInf_Acoplado.pCCMPN_Compania = oQry_Acoplado.pCCMPN_Compania
                    oInf_Acoplado.pNPLCAC_NroAcoplado = ("" & dtTemp.Rows(0).Item("NPLCAC")).ToString.Trim
                    oInf_Acoplado.pTMRCVH_Marca = ("" & dtTemp.Rows(0).Item("TMRCVH")).ToString.Trim
                    oInf_Acoplado.pTDEACP_DetTipoAcoplado = ("" & dtTemp.Rows(0).Item("TDEACP")).ToString.Trim
                    RaiseEvent InformationChanged()
                Else
                    ' Llamamos el Formulario para la selección del Acoplado
                    Dim fbusqueda As ucAcoplado_FAcoplado = New ucAcoplado_FAcoplado(oQry_Acoplado, dtTemp, iTPag)
                    fbusqueda.ShowDialog()
                    If fbusqueda.pSeleccion.pNPLCAC_NroAcoplado <> "" Then
                        oInf_Acoplado.pCCMPN_Compania = fbusqueda.pSeleccion.pCCMPN_Compania
                        oInf_Acoplado.pNPLCAC_NroAcoplado = fbusqueda.pSeleccion.pNPLCAC_NroAcoplado
                        oInf_Acoplado.pTMRCVH_Marca = fbusqueda.pSeleccion.pTMRCVH_Marca
                        oInf_Acoplado.pTDEACP_DetTipoAcoplado = fbusqueda.pSeleccion.pTDEACP_DetTipoAcoplado
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado
            End If
        End If
        Return blnCancelar
    End Function

    Private Function pObtenerAcoplado() As Boolean
        Dim blnResultado As Boolean = False
        If oAcopladoPK.pNPLCAC_NroAcoplado <> "" Then
            ' Obtenemos el Acoplado
            Dim objAcoplado As TD_Obj_Acoplado = oAcoplado.Obtener(oAcopladoPK)

            If oAcoplado.ErrorMessage <> "" Then
                MessageBox.Show(oAcoplado.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If objAcoplado.pNPLCAC_NroAcoplado <> 0 Then
                    With oInf_Acoplado
                        .pCCMPN_Compania = objAcoplado.pCCMPN_Compania
                        .pNPLCAC_NroAcoplado = objAcoplado.pNPLCAC_NroAcoplado
                        .pTMRCVH_Marca = objAcoplado.pTMRCVH_Marca
                        .pTDEACP_DetTipoAcoplado = objAcoplado.pTDEACP_DetTipoAcoplado
                    End With
                End If
            End If
        Else
            oInf_Acoplado.pClear()
        End If
        ' Realizamos la visualización en el control TextBox
        If Me.Focused Then
            txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado
            txtAcoplado.SelectAll()
            blnResultado = True
        Else
            If oInf_Acoplado.pNPLCAC_NroAcoplado <> "" Then
                txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado
                blnResultado = True
            Else
                txtAcoplado.Text = ""
                MessageBox.Show("Acoplado no existe.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaAcoplado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAcoplado.Click
        txtAcoplado.Focus()
        Call fbBuscar()
    End Sub

    Private Sub ucAcoplado_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtAcoplado.Width = Width
        Me.Height = txtAcoplado.Height
    End Sub

    Private Sub ucAcoplado_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtAcoplado.Width = Width
        Me.Height = txtAcoplado.Height
    End Sub

    Private Sub txtAcoplado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcoplado.GotFocus
        txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado
        txtAcoplado.SelectAll()
    End Sub

    Private Sub txtAcoplado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcoplado.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado
                txtAcoplado.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtAcoplado.Text = "" Then
                    oInf_Acoplado.pClear()
                Else
                    If txtAcoplado.Text.ToUpper.Trim <> oInf_Acoplado.pNPLCAC_NroAcoplado And _
                       txtAcoplado.Text.ToUpper.Trim <> oInf_Acoplado.pTMRCVH_Marca.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtAcoplado.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtAcoplado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcoplado.Validated
        If oAcoplado.ErrorMessage = "" Then
            If oInf_Acoplado.pNPLCAC_NroAcoplado <> "" Then
                txtAcoplado.Text = oInf_Acoplado.pNPLCAC_NroAcoplado & " - " & oInf_Acoplado.pTMRCVH_Marca
            Else
                txtAcoplado.Text = ""
                oInf_Acoplado.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtAcoplado.Text = ""
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtAcoplado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAcoplado.Validating
        If txtAcoplado.Text = "" Then
            oInf_Acoplado.pClear()
        Else
            If txtAcoplado.Text.ToUpper.Trim <> oInf_Acoplado.pNPLCAC_NroAcoplado And txtAcoplado.Text.ToUpper.Trim <> oInf_Acoplado.pTMRCVH_Marca.ToUpper Then
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
        oAcoplado = New cAcoplado
    End Sub

    Public Sub pCargar(ByVal Acoplado As TD_AcopladoPK)
        oAcopladoPK.pCCMPN_Compania = Acoplado.pCCMPN_Compania
        oAcopladoPK.pNPLCAC_NroAcoplado = Acoplado.pNPLCAC_NroAcoplado
        oAcopladoPK.pUsuario = Acoplado.pUsuario.ToUpper.Trim
        If Acoplado.pNPLCAC_NroAcoplado <> "" Then Call pObtenerAcoplado()
    End Sub

    Public Sub pClear()
        oInf_Acoplado.pClear()
        txtAcoplado.Text = ""
    End Sub

    Public Sub pClearAll()
        oInf_Acoplado.pClear()
        txtAcoplado.Text = ""
    End Sub
#End Region
End Class
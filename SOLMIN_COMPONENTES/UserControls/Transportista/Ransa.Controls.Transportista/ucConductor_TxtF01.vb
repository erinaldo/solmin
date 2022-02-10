Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Transportista
Imports Ransa.DAO.Transportista

Public Class ucConductor_TxtF01
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
    Private oConductor As cConductor
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Conductor As TD_Inf_Conductor_L01 = New TD_Inf_Conductor_L01
    Private oQry_Conductor As TD_Qry_Conductor_L01 = New TD_Qry_Conductor_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    Private sAccesoPorUsuario As String = "N"
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private oConductorPK As TD_ConductorPK = New TD_ConductorPK

#End Region
#Region " Propiedades "
    Public ReadOnly Property pCompania() As String
        Get
            Return oInf_Conductor.pCCMPN_Compania
        End Get
    End Property

    Public ReadOnly Property pBrevete() As String
        Get
            Return oInf_Conductor.pCBRCNT_Brevete
        End Get
    End Property

    Public ReadOnly Property pRucTransportista() As String
        Get
            Return oInf_Conductor.pNRUCTR_RucTransportista
        End Get
    End Property

    Public ReadOnly Property pNombreChofer() As String
        Get
            Return oInf_Conductor.pTNMCMC_NombreChofer
        End Get
    End Property

    Public ReadOnly Property pStatusRecurso() As Int64
        Get
            Return oInf_Conductor.pSINDRC_StatusRecurso
        End Get
    End Property

    Public ReadOnly Property pUsuario() As String
        Get
            Return oConductorPK.pUsuario
        End Get
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtConductor.StateCommon.Back.Color1 = Nothing
            Else
                txtConductor.StateCommon.Back.Color1 = Color.PaleGoldenrod
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
        oQry_Conductor.pClear()
        ' Busca segun los ingresado sino muestra todo
        If txtConductor.Text.ToUpper.Trim <> oInf_Conductor.pCBRCNT_Brevete And txtConductor.Text.ToUpper.Trim <> oInf_Conductor.pNombreCompleto.ToUpper Then
            ' Condición para el Conductor
            Dim sTemp As String = txtConductor.Text.Trim
            Dim sTem2 As String = ""
            Dim sTem3 As String = ""
            If txtConductor.Text.Contains("*") Then
                ' Quitamos los asteriscos para realizar las evaluaciones respectivas
                sTem2 = sTemp.Replace("*", "")
                ' Realizamos las validaciones
                If sTem2.Length > 0 Then
                    If IsNumeric(sTem2) Then
                        oQry_Conductor.pCBRCNT_Brevete = sTemp
                    Else
                        If sTem2.Length > 1 Then sTem3 = sTem2.Substring(1, sTem2.Length - 1)
                        ' Evaluamos las posibilidades
                        If sTem3.Length = 0 Or (sTem3.Length > 0 And IsNumeric(sTem3)) Then
                            oQry_Conductor.pCBRCNT_Brevete = sTemp
                        Else
                            If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                            If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                            oQry_Conductor.pNombreApellidoChofer = sTemp
                        End If
                    End If
                End If
            Else
                If sTemp.Length > 0 Then
                    If IsNumeric(sTemp) Then
                        oQry_Conductor.pCBRCNT_Brevete = sTemp
                    Else
                        If sTemp.Length > 1 Then sTem2 = sTemp.Substring(1, sTemp.Length - 1)
                        ' Evaluamos las posibilidades
                        If sTem2.Length = 0 Or (sTem2.Length > 0 And IsNumeric(sTem2)) Then
                            oQry_Conductor.pCBRCNT_Brevete = sTemp
                        Else
                            If sTemp.Length > 0 Then If sTemp.Substring(sTemp.Length - 1, 1) <> "*" Then sTemp = sTemp & "*"
                            If sTemp.Length > 0 Then If sTemp.Substring(0, 1) <> "*" Then sTemp = "*" & sTemp
                            oQry_Conductor.pNombreApellidoChofer = sTemp
                        End If
                    End If
                End If
            End If
        End If
        Dim iTPag As Integer = 0
        oQry_Conductor.pCCMPN_Compania = oConductorPK.pCCMPN_Compania
        oQry_Conductor.pUsuario = oConductorPK.pUsuario
        oQry_Conductor.pNRUCTR_RucTransportista = oConductorPK.pNRUCTR_RucTransportista
        oQry_Conductor.pNROPAG_NroPagina = 1
        If oQry_Conductor.pREGPAG_NroRegPorPagina <= 0 Then oQry_Conductor.pREGPAG_NroRegPorPagina = 20
        dtTemp = oConductor.Listar(oQry_Conductor, iTPag)
        '--------------
        ' Proceso
        '--------------
        If oConductor.ErrorMessage <> "" Then
            MessageBox.Show(oConductor.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConductor.Text = oInf_Conductor.pNombreCompleto
            txtConductor.SelectAll()
            blnCancelar = True
        Else
            If dtTemp.Rows.Count = 0 Then
                MessageBox.Show("No existe información que cumpla la condición proporcionada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtConductor.Text = oInf_Conductor.pNombreCompleto
                txtConductor.SelectAll()
                blnCancelar = True
            Else
                If dtTemp.Rows.Count = 1 Then
                    oInf_Conductor.pCCMPN_Compania = oQry_Conductor.pCCMPN_Compania
                    oInf_Conductor.pCBRCNT_Brevete = ("" & dtTemp.Rows(0).Item("CBRCNT")).ToString.Trim
                    oInf_Conductor.pTNMCMC_NombreChofer = ("" & dtTemp.Rows(0).Item("TNMCMC")).ToString.Trim
                    oInf_Conductor.pAPEPAT_ApPaterno = ("" & dtTemp.Rows(0).Item("APEPAT")).ToString.Trim
                    oInf_Conductor.pAPEMAT_ApMaterno = ("" & dtTemp.Rows(0).Item("APEMAT")).ToString.Trim
                    oInf_Conductor.pSINDRC_StatusRecurso = ("" & dtTemp.Rows(0).Item("SINDRC")).ToString.Trim
                    RaiseEvent InformationChanged()
                Else
                    ' Llamamos el Formulario para la selección del Conductor
                    Dim fbusqueda As ucConductor_FConductor = New ucConductor_FConductor(oQry_Conductor, dtTemp, iTPag)
                    fbusqueda.ShowDialog()
                    If fbusqueda.pSeleccion.pCBRCNT_Brevete <> "" Then
                        oInf_Conductor.pCCMPN_Compania = fbusqueda.pSeleccion.pCCMPN_Compania
                        oInf_Conductor.pCBRCNT_Brevete = fbusqueda.pSeleccion.pCBRCNT_Brevete
                        oInf_Conductor.pTNMCMC_NombreChofer = fbusqueda.pSeleccion.pTNMCMC_NombreChofer
                        oInf_Conductor.pAPEPAT_ApPaterno = fbusqueda.pSeleccion.pAPEPAT_ApPaterno
                        oInf_Conductor.pAPEMAT_ApMaterno = fbusqueda.pSeleccion.pAPEMAT_ApMaterno
                        oInf_Conductor.pSINDRC_StatusRecurso = fbusqueda.pSeleccion.pSINDRC_StatusRecurso
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtConductor.Text = oInf_Conductor.pNombreCompleto
            End If
        End If
        Return blnCancelar
    End Function

    Private Function pObtenerConductor() As Boolean
        Dim blnResultado As Boolean = False
        If oConductorPK.pCBRCNT_Brevete <> "" Then
            ' Obtenemos el Conductor
            Dim objConductor As TD_Obj_Conductor = oConductor.Obtener(oConductorPK)

            If oConductor.ErrorMessage <> "" Then
                MessageBox.Show(oConductor.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If objConductor.pCBRCNT_Brevete <> "" Then
                    With oInf_Conductor
                        .pCCMPN_Compania = objConductor.pCCMPN_Compania
                        .pCBRCNT_Brevete = objConductor.pCBRCNT_Brevete
                        .pTNMCMC_NombreChofer = objConductor.pTNMCMC_NombreChofer
                        .pAPEPAT_ApPaterno = objConductor.pAPEPAT_ApPaterno
                        .pAPEMAT_ApMaterno = objConductor.pAPEMAT_ApMaterno
                        .pNRUCTR_RucTransportista = objConductor.pNRUCTR_RucTransportista
                        .pSINDRC_StatusRecurso = objConductor.pSINDRC_StatusRecurso
                    End With
                End If
            End If
        Else
            oInf_Conductor.pClear()
        End If
        ' Realizamos la visualización en el control TextBox
        If Me.Focused Then
            txtConductor.Text = oInf_Conductor.pNombreCompleto
            txtConductor.SelectAll()
            blnResultado = True
        Else
            If oInf_Conductor.pCBRCNT_Brevete <> "" Then
                txtConductor.Text = oInf_Conductor.pCBRCNT_Brevete & " - " & oInf_Conductor.pNombreCompleto
                blnResultado = True
            Else
                txtConductor.Text = ""
                MessageBox.Show("Conductor no existe.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaConductor.Click
        txtConductor.Focus()
        Call fbBuscar()
    End Sub

    Private Sub ucConductor_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtConductor.Width = Width
        Me.Height = txtConductor.Height
    End Sub

    Private Sub ucConductor_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtConductor.Width = Width
        Me.Height = txtConductor.Height
    End Sub

    Private Sub txtConductor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConductor.GotFocus
        txtConductor.Text = oInf_Conductor.pNombreCompleto
        txtConductor.SelectAll()
    End Sub

    Private Sub txtConductor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConductor.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtConductor.Text = oInf_Conductor.pNombreCompleto
                txtConductor.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtConductor.Text = "" Then
                    oInf_Conductor.pClear()
                Else
                    If txtConductor.Text.ToUpper.Trim <> oInf_Conductor.pCBRCNT_Brevete And _
                       txtConductor.Text.ToUpper.Trim <> oInf_Conductor.pNombreCompleto.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtConductor.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtConductor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConductor.Validated
        If oConductor.ErrorMessage = "" Then
            If oInf_Conductor.pCBRCNT_Brevete <> "" Then
                txtConductor.Text = oInf_Conductor.pCBRCNT_Brevete & " - " & oInf_Conductor.pNombreCompleto
            Else
                txtConductor.Text = ""
                oInf_Conductor.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtConductor.Text = ""
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtConductor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtConductor.Validating
        If txtConductor.Text = "" Then
            oInf_Conductor.pClear()
        Else
            If txtConductor.Text.ToUpper.Trim <> oInf_Conductor.pCBRCNT_Brevete And txtConductor.Text.ToUpper.Trim <> oInf_Conductor.pNombreCompleto.ToUpper Then
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
        oConductor = New cConductor
    End Sub

    Public Sub pCargar(ByVal Conductor As TD_ConductorPK)
        oConductorPK.pCCMPN_Compania = Conductor.pCCMPN_Compania
        oConductorPK.pCBRCNT_Brevete = Conductor.pCBRCNT_Brevete
        oConductorPK.pUsuario = Conductor.pUsuario.ToUpper.Trim
        oConductorPK.pNRUCTR_RucTransportista = Conductor.pNRUCTR_RucTransportista
        If Conductor.pCBRCNT_Brevete <> "" Then Call pObtenerConductor()
    End Sub

    Public Sub pClear()
        oInf_Conductor.pClear()
        txtConductor.Text = ""
    End Sub

    Public Sub pClearAll()
        oInf_Conductor.pClearAll()
        txtConductor.Text = ""
    End Sub
#End Region
End Class
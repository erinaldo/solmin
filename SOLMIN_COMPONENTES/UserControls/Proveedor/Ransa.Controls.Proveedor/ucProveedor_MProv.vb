'Imports Ransa.DAO.Proveedor
'Imports Ransa.TypeDef.Proveedor

Public Class ucProveedor_MProv
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal ErrMessage As String)
#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oProveedor As cProveedor
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Proveedor As TD_Inf_LstProveedor_F02 = New TD_Inf_LstProveedor_F02
    Private sErrMessage As String = ""
    '-------------------------------------------------
    ' Satus de Edición de la Información
    '-------------------------------------------------
    Private blnPermitirConsultar As Boolean = True
    Private blnPermitirEliminar As Boolean = True
    Private blnPermitirAgregar As Boolean = True
    Private blnPermitirModificar As Boolean = True

    Private bLoadInf As Boolean = False
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private pUsuario As String = ""
#End Region
#Region " Propiedades "
    Public Property pCodigo() As Int64
        Get
            Return oInf_Proveedor.pCPRVCL_Proveedor
        End Get
        Set(ByVal value As Int64)
            If value > 0 And blnPermitirConsultar Then
                Call pObtenerProveedor(value)
            End If
        End Set
    End Property

    Public ReadOnly Property pRazonSocial() As String
        Get
            Return oInf_Proveedor.pTPRVCL_DescripcionProveedor
        End Get
    End Property

    Public ReadOnly Property pNroRuc() As Int64
        Get
            Return oInf_Proveedor.pNRUCPR_NroRUC
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidar() As Boolean
        Dim blnResultado As Boolean = True
        Dim iTemp As Int64 = 0
        Call pClearErrMsgControls()
        sErrMessage = ""
        ' Validamos si se insta
        If Not bLoadInf Then
            sErrMessage &= "- No se ha instanciado correctamente la clase." & vbNewLine
        End If
        ' Validamos si puede agregar Proveedores
        If txt_CPRVCL.Text = 0 And Not blnPermitirAgregar Then _
            sErrMessage &= "- Ud. no tiene permiso para Agregar información." & vbNewLine
        If txt_CPRVCL.Text > 0 And Not blnPermitirModificar Then _
            sErrMessage &= "- Ud. no tiene permiso para Modificar la información." & vbNewLine
        ' Validación del Nro de RUC del Proveedor - Por si existe con otra Descripción
        If Not Int64.TryParse(txt_NRUCPR.Text, iTemp) Then
            sErrMessage = "- Debe ingresar un Nro. de RUC válido." & vbNewLine
            txt_NRUCPR.StateCommon.Back.Color1 = Color.PeachPuff
        Else
            If iTemp = 0 Then
                sErrMessage = "- Falta ingresar el Nro. de RUC del Proveedor." & vbNewLine
                txt_NRUCPR.StateCommon.Back.Color1 = Color.PeachPuff
            End If
        End If
        ' Validación de la Descripción del Proveedor
        If txt_TPRVCL.Text.Trim = "" Then
            sErrMessage &= "- Falta ingresar el Detalle del Proveedor." & vbNewLine
            txt_TPRVCL.StateCommon.Back.Color1 = Color.PeachPuff
        End If
        ' Validación de la Dirección del Proveedor
        If txt_TDRPRC.Text.Trim = "" Then
            sErrMessage &= "- Falta ingresar la Dirección del Proveedor." & vbNewLine
            txt_TDRPRC.StateCommon.Back.Color1 = Color.PeachPuff
        End If
        ' Validamos el valor de la Cadena de Mensajes de Errores 
        If sErrMessage <> "" Then
            RaiseEvent ErrorMessage(sErrMessage)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Function fblnAgregar() As Boolean
        Dim oObj_Proveedor_F01 As TD_Obj_Proveedor_F01 = New TD_Obj_Proveedor_F01
        Dim intCodigoAsignado As Int32
        With oObj_Proveedor_F01
            .pCPRVCL_Proveedor = txt_CPRVCL.Text.Trim
            .pTPRVCL_DescripcionProveedor = txt_TPRVCL.Text.Trim
            .pTPRCL1_DescripcionAdicional = txt_TPRCL1.Text.Trim
            .pNRUCPR_NroRUC = txt_NRUCPR.Text
            .pNDSDMP_NroDiasDemoraPago = txt_NDSDMP.Text
            Int32.TryParse("" & txt_CPAIS.Tag, .pCPAIS_Pais)
            .pTNACPR_ProvinciaDistrito = txt_TNACPR.Text.Trim
            .pTDRPRC_DireccionProveedor = txt_TDRPRC.Text.Trim
            .pTLFNO1_TelefonoProveedor = txt_TLFNO1.Text.Trim
            .pTNROFX_NroFAX = txt_TNROFX.Text.Trim
            .pTEMAI2_EmailProveedor = txt_TEMAI2.Text.Trim
            .pTPRSCN_ContactoProveedor = txt_TPRSCN.Text.Trim
            .pTLFNO2_TelefonoContacto = txt_TLFNO2.Text.Trim
            .pTEMAI3_EmailContacto = txt_TEMAI3.Text.Trim
        End With
        sErrMessage = ""
        If oProveedor.Grabar(pUsuario, oObj_Proveedor_F01, intCodigoAsignado, sErrMessage) Then
            txt_CPRVCL.Text = intCodigoAsignado
        Else
            RaiseEvent ErrorMessage(sErrMessage)
        End If
    End Function

    Private Sub pClearControls()
        txt_CPRVCL.Text = ""
        txt_TPRVCL.Text = ""
        txt_TPRCL1.Text = ""
        txt_NRUCPR.Text = ""
        txt_NDSDMP.Text = ""
        txt_CPAIS.Text = ""
        txt_TNACPR.Text = ""
        txt_TDRPRC.Text = ""
        txt_TLFNO1.Text = ""
        txt_TNROFX.Text = ""
        txt_TEMAI2.Text = ""
        txt_TPRSCN.Text = ""
        txt_TLFNO2.Text = ""
        txt_TEMAI3.Text = ""
        lbl_Situacion.Text = "."
    End Sub

    Private Sub pClearErrMsgControls()
        txt_CPRVCL.StateCommon.Back.Color1 = Nothing
        txt_TPRVCL.StateCommon.Back.Color1 = Color.PaleGoldenrod
        txt_TPRCL1.StateCommon.Back.Color1 = Nothing
        txt_NRUCPR.StateCommon.Back.Color1 = Color.PaleGoldenrod
        txt_NDSDMP.StateCommon.Back.Color1 = Nothing
        txt_CPAIS.StateCommon.Back.Color1 = Nothing
        txt_TNACPR.StateCommon.Back.Color1 = Nothing
        txt_TDRPRC.StateCommon.Back.Color1 = Color.PaleGoldenrod
        txt_TLFNO1.StateCommon.Back.Color1 = Nothing
        txt_TNROFX.StateCommon.Back.Color1 = Nothing
        txt_TEMAI2.StateCommon.Back.Color1 = Nothing
        txt_TPRSCN.StateCommon.Back.Color1 = Nothing
        txt_TLFNO2.StateCommon.Back.Color1 = Nothing
        txt_TEMAI3.StateCommon.Back.Color1 = Nothing
    End Sub

    Private Function pObtenerProveedor(ByVal Codigo As Int64) As Boolean
        Dim oObj_Proveedor As TD_Obj_Proveedor_F01 = oProveedor.Obtener(Codigo, sErrMessage)
        Dim blnResultado As Boolean = False
        If sErrMessage <> "" Then
            RaiseEvent ErrorMessage(sErrMessage)
            Call pClearControls()
            oInf_Proveedor.pClear()
        Else
            With oObj_Proveedor
                If oObj_Proveedor.pCPRVCL_Proveedor <> 0 Then
                    ' Cargamos la Información
                    With oInf_Proveedor
                        .pCPRVCL_Proveedor = oObj_Proveedor.pCPRVCL_Proveedor
                        .pTPRVCL_DescripcionProveedor = oObj_Proveedor.pTPRVCL_DescripcionProveedor
                        .pNRUCPR_NroRUC = oObj_Proveedor.pNRUCPR_NroRUC
                    End With
                    ' Cargamos la Información en los controles
                    txt_CPRVCL.Text = .pCPRVCL_Proveedor
                    txt_TPRVCL.Text = .pTPRVCL_DescripcionProveedor
                    txt_TPRCL1.Text = .pTPRCL1_DescripcionAdicional
                    txt_NRUCPR.Text = .pNRUCPR_NroRUC
                    txt_NDSDMP.Text = .pNDSDMP_NroDiasDemoraPago
                    txt_CPAIS.Tag = .pCPAIS_Pais
                    txt_TNACPR.Text = .pTNACPR_ProvinciaDistrito
                    txt_TDRPRC.Text = .pTDRPRC_DireccionProveedor
                    txt_TLFNO1.Text = .pTLFNO1_TelefonoProveedor
                    txt_TNROFX.Text = .pTNROFX_NroFAX
                    txt_TEMAI2.Text = .pTEMAI2_EmailProveedor
                    txt_TPRSCN.Text = .pTPRSCN_ContactoProveedor
                    txt_TLFNO2.Text = .pTLFNO2_TelefonoContacto
                    txt_TEMAI3.Text = .pTEMAI3_EmailContacto
                    lbl_Situacion.Text = .pSESTRG_Situacion
                Else
                    Call pClearControls()
                    oInf_Proveedor.pClear()
                End If
            End With
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Not fblnValidar() Then Exit Sub
        If fblnAgregar() Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ucProveedor_MProv_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        oProveedor.Dispose()
        oProveedor = Nothing
    End Sub
#End Region
#Region " Métodos "
    Public Sub New(ByVal Usuario As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        oProveedor = New cProveedor
        pUsuario = Usuario
        bLoadInf = True
    End Sub

    Public Sub pClear()
        Call pClearControls()
        oInf_Proveedor.pClear()
    End Sub
#End Region
End Class
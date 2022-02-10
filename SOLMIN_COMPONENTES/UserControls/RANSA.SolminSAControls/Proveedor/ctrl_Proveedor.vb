Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Proveedor
Imports RANSA.DATA.slnSOLMIN.DAO.Proveedor

Public Class ctrl_Proveedor
    Public Event Click_Aceptar(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event Click_Cancelar(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event MensajeError(ByVal strMensaje As String)
#Region " Tipo "
    
#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    ' Satus de Edición de la Información
    Private blnPermitirConsultar As Boolean = False
    Private blnPermitirEliminar As Boolean = False
    Private blnPermitirAgregar As Boolean = False
    Private blnPermitirModificar As Boolean = False
    ' Mostrar Campos Obligatorios
    Private blnMostrarCamposObligatorios As Boolean = False
    ' Información centralizada para los mensajes de Error
    Private strMensajeError As String = ""

    Private pUsuario As String = ""
#End Region
#Region " Propiedades "
    ' Satus de Edición de la Información
    Public Property pblnPermitirEliminar() As Boolean
        Get
            Return blnPermitirEliminar
        End Get
        Set(ByVal value As Boolean)
            blnPermitirEliminar = value
        End Set
    End Property

    Public Property pblnPermitirConsultar() As Boolean
        Get
            Return blnPermitirConsultar
        End Get
        Set(ByVal value As Boolean)
            blnPermitirConsultar = value
        End Set
    End Property

    Public Property pblnPermitirAgregar() As Boolean
        Get
            Return blnPermitirAgregar
        End Get
        Set(ByVal value As Boolean)
            blnPermitirAgregar = value
        End Set
    End Property

    Public Property pblnPermitirModificar() As Boolean
        Get
            Return blnPermitirModificar
        End Get
        Set(ByVal value As Boolean)
            blnPermitirModificar = value
        End Set
    End Property

    ' Mostrar Campos Obligatorios
    Public Property pblnMostrarCamposObligatorios() As Boolean
        Get
            Return blnMostrarCamposObligatorios
        End Get
        Set(ByVal value As Boolean)
            blnMostrarCamposObligatorios = value
            Call pMostrarCamposObligatorios()
        End Set
    End Property

    ' Cargar la Información de una Proveedor
    Public WriteOnly Property pCPRVCL_Proveedor() As Int32
        Set(ByVal value As Int32)
            If value > 0 And blnPermitirConsultar Then
                strMensajeError = ""
                Dim objProveedorQuery As daoProveedor.TD_ProveedorQuery = daoProveedor.Objeto(objSqlManager, value, strMensajeError)
                If strMensajeError <> "" Then
                    RaiseEvent MensajeError(strMensajeError)
                Else
                    With objProveedorQuery
                        txt_CPRVCL.Text = .pCPRVCL_Proveedor
                        txt_TPRVCL.Text = .pTPRVCL_DescripcionProveedor
                        txt_TPRCL1.Text = .pTPRCL1_DescripcionAdicional
                        txt_NRUCPR.Text = .pNRUCPR_NroRUC
                        txt_NDSDMP.Text = .pNDSDMP_NroDiasDemoraPago
                        txt_CPAIS.Tag = .pCPAIS_Pais
                        txt_CPAIS.Text = .pTCMPPS_DetallePais
                        txt_TNACPR.Text = .pTNACPR_ProvinciaDistrito
                        txt_TDRPRC.Text = .pTDRPRC_DireccionProveedor
                        txt_TLFNO1.Text = .pTLFNO1_TelefonoProveedor
                        txt_TNROFX.Text = .pTNROFX_NroFAX
                        txt_TEMAI2.Text = .pTEMAI2_EmailProveedor
                        txt_TPRSCN.Text = .pTPRSCN_ContactoProveedor
                        txt_TLFNO2.Text = .pTLFNO2_TelefonoContacto
                        txt_TEMAI3.Text = .pTEMAI3_EmailContacto
                        lbl_Situacion.Text = .pSITUAC_DetalleRegistro
                    End With
                End If
            End If
        End Set
    End Property


    Public Property Usuario() As String
        Get
            Return pUsuario
        End Get
        Set(ByVal value As String)
            pUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidarInformacion() As Boolean
        Dim blnResultado As Boolean = True
        strMensajeError = ""
        ' Ponemos los controles a validar en el color original
        Call pMostrarCamposObligatorios()
        ' Valiamos si puede agregar Proveedores
        If txt_CPRVCL.Text = 0 And Not blnPermitirAgregar Then _
            strMensajeError &= "- Ud. no tiene permiso para Agregar información." & vbNewLine
        If txt_CPRVCL.Text > 0 And Not blnPermitirModificar Then _
            strMensajeError &= "- Ud. no tiene permiso para Modificar la información." & vbNewLine
        ' Validación del Nro de RUC del Proveedor - Por si existe con otra Descripción
        If txt_NRUCPR.Text > 0 Then
            If txt_CPRVCL.Text = 0 Then
                Dim objTD_Exist As daoProveedor.TD_ProveedorExist = New daoProveedor.TD_ProveedorExist
                Dim intCodigoExistente As Int32
                objTD_Exist.pNRUCPR_NroRUC = txt_NRUCPR.Text.Trim
                If daoProveedor.Exists(objSqlManager, objTD_Exist, intCodigoExistente, strMensajeError) Then
                    strMensajeError &= "- Nro. de RUC ya fue registrado (Proveedor " & intCodigoExistente & " )." & vbNewLine
                End If
            End If
        Else
            strMensajeError = "- Falta ingresar el Nro. de RUC del Proveedor." & vbNewLine
            txt_NRUCPR.StateCommon.Back.Color1 = Color.Red
        End If
        ' Validación de la Descripción del Proveedor
        If txt_TPRVCL.Text.Trim = "" Then
            strMensajeError &= "- Falta ingresar el Detalle del Proveedor." & vbNewLine
            txt_TPRVCL.StateCommon.Back.Color1 = Color.Red
        End If
        ' Validación de la Dirección del Proveedor
        If txt_TDRPRC.Text.Trim = "" Then
            strMensajeError &= "- Falta ingresar la Dirección del Proveedor." & vbNewLine
            txt_TDRPRC.StateCommon.Back.Color1 = Color.Red
        End If
        ' Validamos el valor de la Cadena de Mensajes de Errores 
        If strMensajeError <> "" Then
            RaiseEvent MensajeError(strMensajeError)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Function fblnAgregarProveedor() As Boolean
        Dim objProveedor As TD_Proveedor = New TD_Proveedor
        Dim intCodigoAsignado As Int32
        With objProveedor
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
        strMensajeError = ""
        If daoProveedor.Grabar(objSqlManager, pUsuario, objProveedor, intCodigoAsignado, strMensajeError) Then
            txt_CPRVCL.Text = intCodigoAsignado
        Else
            RaiseEvent MensajeError(strMensajeError)
        End If
    End Function

    Private Sub pMostrarCamposObligatorios()
        If blnMostrarCamposObligatorios Then
            ' Ponemos los controles a validar en el color original
            txt_NRUCPR.StateCommon.Back.Color1 = Color.LemonChiffon
            txt_TPRVCL.StateCommon.Back.Color1 = Color.LemonChiffon
            txt_TDRPRC.StateCommon.Back.Color1 = Color.LemonChiffon
        Else
            ' Ponemos los controles a validar en el color original
            txt_NRUCPR.StateCommon.Back.Color1 = Nothing
            txt_TPRVCL.StateCommon.Back.Color1 = Nothing
            txt_TDRPRC.StateCommon.Back.Color1 = Nothing
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub ctrl_Proveedor_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ctrl_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Not fblnValidarInformacion() Then Exit Sub
        If fblnAgregarProveedor() Then
            RaiseEvent Click_Aceptar(sender, e)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        RaiseEvent Click_Cancelar(sender, e)
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class

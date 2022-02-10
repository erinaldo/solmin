Imports RANSA.NEGO.slnSOLMIN_SAT.PreDespacho
Imports RANSA.TypeDef.Waybill
Imports RANSA.DAO.WayBill
Imports Ransa.TypeDef
Imports Ransa.NEGO

Public Class frmPreDespachoAgregarBulto
#Region "Atributos"
    Private intCCLNT As Integer = 0
    Private strCRTLTE As String = ""
    Private intNROCTL As Int64 = 0
    Private _STPDES As String = ""

#End Region
#Region "Propiedades"
    Public Property pCodigoCliente_CCLNT() As Int32
        Get
            Return intCCLNT
        End Get
        Set(ByVal value As Int32)
            intCCLNT = value
        End Set
    End Property

    Public Property pCriterioLote_CRTLTE() As String
        Get
            Return strCRTLTE
        End Get
        Set(ByVal value As String)
            strCRTLTE = value
        End Set
    End Property

    Public Property pNroControl_NROCTL() As Int64
        Get
            Return intNROCTL
        End Get
        Set(ByVal value As Int64)
            intNROCTL = value
        End Set
    End Property

    Public Property pSTPDES() As String
        Get
            Return _STPDES
        End Get
        Set(ByVal value As String)
            _STPDES = value
        End Set
    End Property
    Private _pCCMPN_Compania As String = ""
    Public Property pCCMPN_Compania() As String
        Get
            Return _pCCMPN_Compania
        End Get
        Set(ByVal value As String)
            _pCCMPN_Compania = value
        End Set
    End Property


    Private _pCDVSN_CodDivision As String = ""
    Public Property pCDVSN_CodDivision() As String
        Get
            Return _pCDVSN_CodDivision
        End Get
        Set(ByVal value As String)
            _pCDVSN_CodDivision = value
        End Set
    End Property


    Private _pCPLNDV_CodigoPlanta As Decimal = 0
    Public Property pCPLNDV_CodigoPlanta() As Decimal
        Get
            Return _pCPLNDV_CodigoPlanta
        End Get
        Set(ByVal value As Decimal)
            _pCPLNDV_CodigoPlanta = value
        End Set
    End Property

#End Region
#Region "Procedimientos y Funciones"
    Private Sub pAgregarNuevoBulto()
        If mfblnExiste_BultoParaPreDespacho(True, False) Then

            Dim objNuevoBulto As clsInformacion_AgregarBultoPreDespacho = New clsInformacion_AgregarBultoPreDespacho
            With objNuevoBulto
                .pintCodigoCliente_CCLNT = intCCLNT
                .pstrCodigoRecepcion_CREFFW = txtCodigoBulto.Text
                .pstrCriterioLote_CRTLTE = strCRTLTE
                .pintNroControl_NROCTL = intNROCTL
                .psSTPDES = pSTPDES
            End With

            If mfblnAgregar_BultoPreDespachos(objNuevoBulto) Then
                Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
                Me.Close()
            Else
                Call mpMsjeVarios(enumMsjVarios.PROCESO_Ko_Guardar)
            End If
        End If
    End Sub
#End Region
#Region "Métodos"
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        If mfblnSalirOpcion() Then Me.Close()
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If (txtCodigoBulto.Text.Trim = "") Then
            MessageBox.Show("Debe ingresar el Bulto", "Bulto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Call pAgregarNuevoBulto()
    End Sub

    Private Function mfblnExiste_BultoParaPreDespacho(ByVal blnMsgSiExiste As Boolean, _
                                                     ByVal blnMsgSiNoExiste As Boolean) As Boolean
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PSCCMPN = _pCCMPN_Compania
            .PSCDVSN = _pCDVSN_CodDivision
            .PNCPLNDV = _pCPLNDV_CodigoPlanta
            .PNCCLNT = intCCLNT
            .PSCREFFW = Me.txtCodigoBulto.Text
        End With
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = obrBulto.ExisteBultoParaPreDespacho(obeBulto, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Mostrar mensaje si existe información
        If blnMsgSiExiste And Not blnResultado Then _
            MessageBox.Show("El Bulto " & ME.txtCodigoBulto .Text  & " ya se encuentra registra " & vbNewLine & _
                            "en el PreDespacho.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Mostrar mensaje si no existe información
        If blnMsgSiNoExiste And Not blnResultado Then _
            MessageBox.Show("El Bulto " & ME.txtCodigoBulto .Text & " no se encuentra registra " & vbNewLine & _
                            "en el PreDespacho.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

#End Region


End Class

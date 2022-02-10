Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO

Public Class frmLiquidacionFlete_DlgCargarGuia
#Region " Atributos "

    
    Private bResultado As Boolean = True

    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    
    Public pNOPRCN As Decimal = 0
    Public pNGUIAREM As Decimal = 0
    Public pCTRMNC As Decimal = 0
    Public pNGUIAT As Decimal = 0
    Private pSGUIFC As String = ""

    Public sGuiaPrincipal As String = ""
    Public sGuiaPrincipalTxt As String = ""
    Public sRelacionGuiasSeleccionada As String = ""
    Public dFechaGuiaPrincipal As String = ""
      
    'Public pobeAutorizacionLiq As beAutorizacionLiquidacion

    Public Enum Accion
        Nuevo
        Modificar
    End Enum
    Public pAccion As Accion = Accion.Nuevo


    Private oInfoGuiaCargada As New TD_Obj_InfGRemCargada
    Private pNRUCTR_Transportista As String = ""
#End Region
#Region " Propiedades "



    

#End Region
#Region " Procedimientos y Funciones "

#End Region
    'nuevo JMC --------------------
    Public frmInvocado As String = ""
    Public frmInvocadoNombre As String = ""
    
    Private pCRGVTA As String = ""
    
    Public PSStatusLiquidacion_SESGRP As String = ""
    Private pMONEDA_OS As Decimal = 0

    Public pEstadoAprobMargen As String = ""

     

#Region " Eventos "
    Private Function ObtenerDatoGuiaTransporteporLiquidar() As TD_Obj_InfGRemCargada
        Dim objLogica As New GuiaTransportista_BLL
        Dim oGuiaT As GuiaTransportista = New GuiaTransportista
       

        Dim oHasParam As New Hashtable
        oHasParam("PSCCMPN") = pCCMPN
        oHasParam("PNCTRMNC") = pCTRMNC
        oHasParam("PNNGUITR") = pNGUIAT

        oGuiaT = objLogica.Listar_datos_Guia_por_Liquidar(oHasParam)


        Dim oTemp As TD_Obj_InfGRemCargada = New TD_Obj_InfGRemCargada
        With oTemp
            .pCTRMNC_CodigoTransportista = oGuiaT.CTRMNC
            .pNGUIRM_NroGuiaTransportista = oGuiaT.NGUIRM
            .pNGUITS_NroGuiaTransportistaTXT = oGuiaT.NGUITS



            .pNRUCTR_Transportista = oGuiaT.NRUCTR


            'NRUCTR
            .pNGUITR_GuiaRemisionCargada = sGuiaPrincipal
            .pNGUITR_GuiaRemisionCargadaTXT = sGuiaPrincipalTxt

            .pFGUITR_FechaGuiaRemision = dFechaGuiaPrincipal
            .pRELGUI_RelacionGuiaHijas = sRelacionGuiasSeleccionada
            .pCCLNT1_CodigoCliente = oGuiaT.CCLNT
            .pCLCLOR_CodigoLocalidadOrigen = oGuiaT.CLCLOR
            .pTCMLCO_LocalidadOrigen = oGuiaT.TCMLCO
            .pCLCLDS_CodigoLocalidadDestino = oGuiaT.CLCLDS
            .pTCMLCD_LocalidadDestino = oGuiaT.TCMLCD

            .pNOPRCN_NroOperacion = oGuiaT.NOPRCN
            .pNLQDCN_NroLiquidacion = 0
            .pCTRSPT_Transportista = oGuiaT.CTRSPT
            .pTCMTRT_RazSocialTransportista = oGuiaT.TCMTRT
            .pNPLVHT_Tracto = oGuiaT.NPLCTR
            .pCBRCNT_Brevete = oGuiaT.CBRCNT
            .pCMRCDR_Mercaderia = oGuiaT.CMRCDR
            .pTAMRCD_DetalleMercaderia = oGuiaT.TCMRCD
            .pFRCGRM_FechaRecepGuiaRemision = Now

            .pQGLGSL_CantidadGlsGasolina = oGuiaT.QGLGSL
            .pQGLDSL_CantidadGlsDiesel = oGuiaT.QGLDSL
            .pNRHJCR_NroHojasCargui = oGuiaT.NRHJCR
            .pCPRCN1_CodigoPropietarioContenedor1 = ""
            .pNSRCN1_SerieContenedor1 = ""
            .pCPRCN2_CodigoPropietarioContenedor2 = ""
            .pNSRCN2_SerieContenedor2 = ""

            .pFSLDCM_FechaSalidaCamion = dFechaGuiaPrincipal
            .pQKLMRC_KilometrosRecorridos = oGuiaT.QKMREC
            .pQHRSRV_CantidadHorasServicio = 0

            .pQBLRMS_CantidadBultosRemision = oGuiaT.QMRCMC
            .pPBRTOR_PesoBrutoRemision = oGuiaT.QPSOBR
            .pQVLMOR_VolumenRemision = oGuiaT.QVLMOR
            .pPBRTOR_PesoBrutoRemision = oGuiaT.PMRCMC
            .pPBRDST_PesoBrutoRecepcion = oGuiaT.PMRCMC
            .pQBLRCP_CantidadBultosRecepcion = oGuiaT.QMRCMC
            .pQVLMDS_VolumenRecepcion = oGuiaT.QVLMOR
            .pNOREMB_OrdenEmbarcador = oGuiaT.NOREMB
            .pSSINVJ_FlagSiniestroViaje = oGuiaT.SSINVJ
            .pMMCUSR_Usuario = MainModule.USUARIO
            .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina



        End With

        Return oTemp

    End Function

    Private Sub VisualizarGuiaCargada()

       

        Select Case pAccion
            Case Accion.Nuevo

                oInfoGuiaCargada = ObtenerDatoGuiaTransporteporLiquidar()


                CargarDataControles(oInfoGuiaCargada)
            Case Accion.Modificar
                Dim objLogica As New GuiaTransportista_BLL

                Dim objEntidad As New TD_GRemServCargadasGTranspLiqPK
                objEntidad.pNOPRCN_NroOperacion = pNOPRCN
                objEntidad.pCCMPN_Compania = pCCMPN
                objEntidad.pNGUITR_NroGuiaRemision = pNGUIAREM

                oInfoGuiaCargada = objLogica.Get_Guia_Remision(objEntidad)

                CargarDataControles(oInfoGuiaCargada)
        End Select
       


      
      


    End Sub

    Private Sub CargarDataControles(oGuiaRServ As TD_Obj_InfGRemCargada)
       
        txtNroOperacion.Text = oGuiaRServ.pNOPRCN_NroOperacion

        txtNroLiquidacion.Text = oGuiaRServ.pNLQDCN_NroLiquidacion

        txtNroGuiaRemision.Text = oGuiaRServ.pNGUITR_GuiaRemisionCargada ' pNGUIAREM
        NroGuiaRemCliente_Txt.Text = oGuiaRServ.pNGUITR_GuiaRemisionCargadaTXT

        txtFechaGuiaRemision.Text = oGuiaRServ.pFGUITR_FechaGuiaRemision.ToString("dd/MM/yyyy")

        txtFechaRecepGuiaRemision.Text = oGuiaRServ.pFGUITR_FechaGuiaRemision.ToString("dd/MM/yyyy")

        txtNroGuiaTransporte.Text = oGuiaRServ.pNGUIRM_NroGuiaTransportista
        txtNroGuiaTransporteTxt.Text = oGuiaRServ.pNGUITS_NroGuiaTransportistaTXT

        txtTransportista.Text = oGuiaRServ.pCTRSPT_Transportista & " - " & oGuiaRServ.pTCMTRT_RazSocialTransportista
        txtNroPlaca.Text = oGuiaRServ.pNPLVHT_Tracto
        txtNroBrevete.Text = oGuiaRServ.pCBRCNT_Brevete
        txtOrigen.Text = oGuiaRServ.pCLCLOR_CodigoLocalidadOrigen & " - " & oGuiaRServ.pTCMLCO_LocalidadOrigen
        txtDestino.Text = oGuiaRServ.pCLCLDS_CodigoLocalidadDestino & " - " & oGuiaRServ.pTCMLCD_LocalidadDestino
        If oGuiaRServ.pFSLDCM_FechaSalidaCamionFNum > 0 Then
            dteFechaSalidaCamion.Value = oGuiaRServ.pFSLDCM_FechaSalidaCamion
            dteFechaSalidaCamion.Checked = True
        Else
            dteFechaSalidaCamion.Checked = False
        End If
        If oGuiaRServ.pFLLGCM_FechaLlegadaCamionFNum > 0 Then
            dteFechaLlegadaCamion.Value = oGuiaRServ.pFLLGCM_FechaLlegadaCamion
            dteFechaLlegadaCamion.Checked = True
        Else
            dteFechaLlegadaCamion.Checked = False
        End If
        txtMercaderia.Text = oGuiaRServ.pCMRCDR_Mercaderia & " - " & oGuiaRServ.pTAMRCD_DetalleMercaderia
        txtPropContenedor1.Text = oGuiaRServ.pCPRCN1_CodigoPropietarioContenedor1
        txtSerieContenedor1.Text = oGuiaRServ.pNSRCN1_SerieContenedor1
        txtPropContenedor2.Text = oGuiaRServ.pCPRCN2_CodigoPropietarioContenedor2
        txtSerieContenedor2.Text = oGuiaRServ.pNSRCN2_SerieContenedor2
        txtCantGlnGsl.Text = oGuiaRServ.pQGLGSL_CantidadGlsGasolina
        txtCantGlnDsl.Text = oGuiaRServ.pQGLDSL_CantidadGlsDiesel
        txtNroHojaCarguio.Text = oGuiaRServ.pNRHJCR_NroHojasCargui
        txtKmRecorrido.Text = oGuiaRServ.pQKLMRC_KilometrosRecorridos
        txtBultosRemision.Text = oGuiaRServ.pQBLRMS_CantidadBultosRemision
        txtBultosRecepcion.Text = oGuiaRServ.pQBLRCP_CantidadBultosRecepcion
        txtPesoBrutoRemision.Text = oGuiaRServ.pPBRTOR_PesoBrutoRemision
        txtPesoBrutoRecepcion.Text = oGuiaRServ.pPBRDST_PesoBrutoRecepcion
        'txtPesoTaraRemision.Text = oGuiaRServ.pPTRAOR_PesoTaraRemision
        'txtPesoTaraRecepcion.Text = oGuiaRServ.pPTRDST_PesoTaraRecepcion
        txtVolumenRemision.Text = oGuiaRServ.pQVLMOR_VolumenRemision
        txtVolumenRecepcion.Text = oGuiaRServ.pQVLMDS_VolumenRecepcion
        txtHrasServicio.Text = oGuiaRServ.pQHRSRV_CantidadHorasServicio
        txtGuiasSeleccionadas.Text = oGuiaRServ.pRELGUI_RelacionGuiaHijas
        txtOrdenEmbarcador.Text = oGuiaRServ.pNOREMB_OrdenEmbarcador
        If oGuiaRServ.pSSINVJ_FlagSiniestroViaje = "N" Then
            cmbViaje.SelectedItem = "NO"
        ElseIf oGuiaRServ.pSSINVJ_FlagSiniestroViaje = "S" Then
            cmbViaje.SelectedItem = "SI"
        Else
            cmbViaje.SelectedItem = "NO"
        End If
       
        pCRGVTA = oGuiaRServ.pCRGVTA.ToString()
        pMONEDA_OS = oGuiaRServ.pMONEDA_OS
       
        pSGUIFC = oGuiaRServ.SGUIFC
        pEstadoAprobMargen = oGuiaRServ.FLGSTA

        pNRUCTR_Transportista = oGuiaRServ.pNRUCTR_Transportista

    End Sub
    Private Sub frmLiquidacionFlete_DlgCargarGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            VisualizarGuiaCargada()
          
            If Me.pSGUIFC = "F" OrElse Me.PSStatusLiquidacion_SESGRP = "L" Then
                Me.btnAceptar.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
 

        

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim fechaInicio As Decimal = 0
            Dim FechaFin As Decimal = 0
            Dim oInfGRemCargada As New TD_Obj_InfGRemCargada

            If dteFechaLlegadaCamion.Checked = False Then
                MessageBox.Show("Seleccionar fecha Llegada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            With oInfGRemCargada
               
       
                .pCTRMNC_CodigoTransportista = oInfoGuiaCargada.pCTRMNC_CodigoTransportista
                .pNGUIRM_NroGuiaTransportista = oInfoGuiaCargada.pNGUIRM_NroGuiaTransportista
                .pCTRSPT_Transportista = oInfoGuiaCargada.pCTRSPT_Transportista
                .pNPLVHT_Tracto = oInfoGuiaCargada.pNPLVHT_Tracto
                .pCBRCNT_Brevete = oInfoGuiaCargada.pCBRCNT_Brevete
                .pNOPRCN_NroOperacion = oInfoGuiaCargada.pNOPRCN_NroOperacion
                .pNLQDCN_NroLiquidacion = oInfoGuiaCargada.pNLQDCN_NroLiquidacion
                .pNGUITR_GuiaRemisionCargada = oInfoGuiaCargada.pNGUITR_GuiaRemisionCargada
                .pFGUITR_FechaGuiaRemision = oInfoGuiaCargada.pFGUITR_FechaGuiaRemision
                .pRELGUI_RelacionGuiaHijas = oInfoGuiaCargada.pRELGUI_RelacionGuiaHijas
                .pCMRCDR_Mercaderia = oInfoGuiaCargada.pCMRCDR_Mercaderia
                .pCCLNT1_CodigoCliente = oInfoGuiaCargada.pCCLNT1_CodigoCliente
                .pCLCLOR_CodigoLocalidadOrigen = oInfoGuiaCargada.pCLCLOR_CodigoLocalidadOrigen
                .pCLCLDS_CodigoLocalidadDestino = oInfoGuiaCargada.pCLCLDS_CodigoLocalidadDestino


                If dteFechaSalidaCamion.Checked Then
                    .pFSLDCM_FechaSalidaCamion = dteFechaSalidaCamion.Value
                    fechaInicio = dteFechaSalidaCamion.Value.ToString("yyyyMMdd")
                Else
                    .pFSLDCM_FechaSalidaCamion = New Date
                End If

                If dteFechaLlegadaCamion.Checked Then
                    .pFLLGCM_FechaLlegadaCamion = dteFechaLlegadaCamion.Value
                    FechaFin = dteFechaLlegadaCamion.Value.ToString("yyyyMMdd")
                Else
                    .pFLLGCM_FechaLlegadaCamion = New Date
                End If

                If fechaInicio > 0 And FechaFin > 0 Then
                    If FechaFin < fechaInicio Then
                        MessageBox.Show("Fecha llegada debe ser mayor o igual a la fecha salida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If

                .pCPRCN1_CodigoPropietarioContenedor1 = txtPropContenedor1.Text
                .pNSRCN1_SerieContenedor1 = txtSerieContenedor1.Text
                .pCPRCN2_CodigoPropietarioContenedor2 = txtPropContenedor2.Text
                .pNSRCN2_SerieContenedor2 = txtSerieContenedor2.Text
                .pQGLGSL_CantidadGlsGasolina = txtCantGlnGsl.Text
                .pQGLDSL_CantidadGlsDiesel = txtCantGlnDsl.Text
                .pNRHJCR_NroHojasCargui = txtNroHojaCarguio.Text
                .pQKLMRC_KilometrosRecorridos = txtKmRecorrido.Text
                .pQBLRMS_CantidadBultosRemision = txtBultosRemision.Text
                .pQBLRCP_CantidadBultosRecepcion = txtBultosRecepcion.Text
                .pPBRTOR_PesoBrutoRemision = txtPesoBrutoRemision.Text
                .pPBRDST_PesoBrutoRecepcion = txtPesoBrutoRecepcion.Text
                '.pPTRAOR_PesoTaraRemision = txtPesoTaraRemision.Text
                '.pPTRDST_PesoTaraRecepcion = txtPesoTaraRecepcion.Text
                .pPTRAOR_PesoTaraRemision = 0
                .pPTRDST_PesoTaraRecepcion = 0
                .pQVLMOR_VolumenRemision = txtVolumenRemision.Text
                .pQVLMDS_VolumenRecepcion = txtVolumenRecepcion.Text
                .pQHRSRV_CantidadHorasServicio = txtHrasServicio.Text
                .pCCMPN_Compania = Me.pCCMPN

                If cmbViaje.SelectedItem = "NO" Then
                    .pSSINVJ_FlagSiniestroViaje = "N"
                ElseIf cmbViaje.SelectedItem = "SI" Then
                    .pSSINVJ_FlagSiniestroViaje = "S"
                End If

            End With

            oInfGRemCargada.pMMCUSR_Usuario = USUARIO
            Dim Objeto_Logica As New GuiaTransportista_BLL
            Dim sErrorMesage As String = ""




            If oInfGRemCargada.pPBRTOR_PesoBrutoRemision = 0 Or oInfGRemCargada.pPBRDST_PesoBrutoRecepcion = 0 Then
                Dim EsRequierePeso As Boolean = False
                EsRequierePeso = Objeto_Logica.Es_Operacion_Servicio_Flete(pCCMPN, oInfoGuiaCargada.pNOPRCN_NroOperacion)
                If EsRequierePeso = True Then
                    Dim msg As String = ""
                    msg = "Según O/S es un servicio de Flete." & Chr(10)
                    msg = msg & "Verificar ingreso de peso (remisión/recepción)."
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
 

            If pAccion = Accion.Nuevo Then

                oInfGRemCargada.pNGUITR_GuiaRemisionCargadaTXT = sGuiaPrincipalTxt
                bResultado = Objeto_Logica.Registrar_GuiaRemisionLiqTransp(oInfGRemCargada, sErrorMesage)

            End If
            If pAccion = Accion.Modificar Then
                bResultado = Objeto_Logica.Modificar_GuiaRemisionLiqTransp(oInfGRemCargada, sErrorMesage)
            End If
          
            If Not bResultado Or sErrorMesage <> "" Then
                MessageBox.Show(sErrorMesage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        bResultado = True
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmLiquidacionFlete_DlgCargarGuia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = Not bResultado
    End Sub

    Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicios.Click


        Dim pSESTRG As String = ""

        pSESTRG = IIf(Me.pSGUIFC.Trim.Equals(""), PSStatusLiquidacion_SESGRP, Me.pSGUIFC)
       
        Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
        pCCMPN, pCDVSN, CType(txtNroOperacion.Text.Trim, Int64), CType(txtNroGuiaRemision.Text.Trim, Int64), pSESTRG)

      
        'JMC--------------------18/09/2014----
        fMostrarInfAdic.frmInvocado = frmInvocado
        'fMostrarInfAdic.pEstadoAprobMargen = pEstadoAprobMargen

        fMostrarInfAdic.pEstado = PSStatusLiquidacion_SESGRP
        fMostrarInfAdic.frmInvocadoNombre = frmInvocadoNombre
        fMostrarInfAdic.pCRGVTA = pCRGVTA ' ECM-HUNDRED-20150821
        '-----------------------18/09/2014----

      
        fMostrarInfAdic.PSStatusLiquidacion_SESGRP = PSStatusLiquidacion_SESGRP
        '
        'Codigo agregado por MREATEGUIP - Ajuste Moneda
        '----- Ini -----
        fMostrarInfAdic.pMONEDA_OS = pMONEDA_OS

        '----- Fin -----
        'fMostrarInfAdic.pobeAutorizacionLiq = pobeAutorizacionLiq
        fMostrarInfAdic.ShowDialog()
    End Sub

#End Region
#Region " Métodos "
    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    

#End Region

End Class
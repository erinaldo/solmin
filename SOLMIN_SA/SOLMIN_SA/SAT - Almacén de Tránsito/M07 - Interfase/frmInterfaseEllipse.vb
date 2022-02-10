' Librerías del Proyecto
'Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.Waybill
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports Ransa.TypeDef

Public Class frmInterfaseEllipse
#Region " Atributos "
    Private blnDetalleItemChanged As Boolean = False
#End Region
#Region " Procedimientos y Funciones "

    Private Sub pActualizarInformacion()
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim objFiltro As TD_Qry_Bulto_L01 = New TD_Qry_Bulto_L01
        With objFiltro
            .pCCMPN_CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCDVSN_CodigoDivision = UcDivision_Cmb011.Division
            .pCPLNDV_CodigoPlanta = UcPLanta_Cmb011.Planta
            .pCCLNT_CodigoCliente = txtClient.pCodigo
            .pCREFFW_CodigoBulto = txtCodigoRecepcion.Text
            .pNROPLT_NroPaletizado = txtNroPaletizado.Text
            .pCRTLTE_CriterioLote = txtCriterioLote.Text
            'If rbtnRecepcion.Checked Then
            .pFREFFW_FechaRecep_Ini = dteFechaInicial.Value
            .pFREFFW_FechaRecep_Fin = dteFechaFinal.Value
            'Else
            '.pFSLFFW_FechaDesp_Ini = dteFechaInicial.Value
            '.pFSLFFW_FechaDesp_Fin = dteFechaFinal.Value
            'End If
            If rbtnRecepcion.Checked Then
                .pSSTINV_StatusAlmacen = "0"
            Else
                .pSSTINV_StatusAlmacen = "1"
            End If


            .pTTINTC_TermInterCarga = cmbTermInter.pInformacionSelec.pCCMPRN_Codigo
            If rbtnRecepcion.Checked Then
                If chkIncluirEnviados.Checked Then
                    .pSTRNSM_StatusTransmisionEnum = TD_Qry_Bulto_L01.TipoTransmision.PenEnvRecepYEnviados
                Else
                    .pSTRNSM_StatusTransmisionEnum = TD_Qry_Bulto_L01.TipoTransmision.PenEnvRecep
                End If
            Else
                If chkIncluirEnviados.Checked Then
                    .pSTRNSM_StatusTransmisionEnum = TD_Qry_Bulto_L01.TipoTransmision.PenEnvDespYEnviados
                Else
                    .pSTRNSM_StatusTransmisionEnum = TD_Qry_Bulto_L01.TipoTransmision.PenEnvDesp
                End If
            End If
            .pSTPING_TipoMovimiento = "C"


            If txtUbicacionReferencial.Resultado IsNot Nothing Then
                .pTUBRFR_Ubicacion = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            Else
                .pTUBRFR_Ubicacion = ""
            End If

            .pUsuario = objSeguridadBN.pUsuario
        End With
        dgBultos.pActualizar(objFiltro)
        '-- Registro los nuevos valores de los campos de los clientes
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("InterfaseExcel", txtClient.pCodigo)
        objAppConfig = Nothing
    End Sub
#End Region
#Region " Métodos "
    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub
 

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    Private Sub dgBultos_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgBultos.Confirm
        If MessageBox.Show(strPregunta, "Confirmar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgBultos_ErrorMessage(ByVal strMensaje As String) Handles dgBultos.ErrorMessage
        MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgBultos_Etiqueta_Bulto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Bulto
        Dim obeBulto As New beBulto
        obeBulto.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        obeBulto.PSCDVSN = UcPLanta_Cmb011.Planta
        obeBulto.PNCPLNDV = UcDivision_Cmb011.Division
        obeBulto.PSCREFFW = Bulto.pCREFFW_CodigoBulto
        obeBulto.PNCCLNT = Bulto.pCCLNT_CodigoCliente
        Call mpImprimir_EtiquetaBulto(obeBulto)
        'Call mpImprimir_EtiquetaBulto(Bulto.pCCLNT_CodigoCliente, Bulto.pCREFFW_CodigoBulto)
    End Sub

    Private Sub dgBultos_Etiqueta_Paleta(ByVal Bulto As RANSA.TYPEDEF.Waybill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Paleta
        Call mpImprimir_EtiquetaPaleta(Bulto.pCCLNT_CodigoCliente, Bulto.pNROPLT_NroPaletizado)
    End Sub

    Private Sub dgBultos_Etiqueta_SecuenciaBulto() Handles dgBultos.Etiqueta_SecuenciaBulto
        If txtClient.pCodigo = 0 Then Exit Sub
        Dim fGenerarSecuencia As frmGenerarSecuencia = New frmGenerarSecuencia
        With fGenerarSecuencia
            .pintCliente = txtClient.pCodigo
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Beep()
            End If
            fGenerarSecuencia = Nothing
        End With
    End Sub



    Private Sub dgBultos_Export(ByRef oSentido As TD_Qry_ExportInf_F01.Sentido, ByRef Formato As TD_Qry_ExportInf_F01.Formato, ByRef bUpdateInf As Boolean) Handles dgBultos.Export
        If rbtnRecepcion.Checked Then
            oSentido = TD_Qry_ExportInf_F01.Sentido.Recepcion
        Else
            oSentido = TD_Qry_ExportInf_F01.Sentido.Despacho
        End If
        Formato = TD_Qry_ExportInf_F01.Formato.Ellipse
        bUpdateInf = True
    End Sub

    Private Sub dgBultos_RePacking_Bulto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.RePacking_Bulto
        Dim fRePacking As frmRePacking = New frmRePacking
        With fRePacking
            .pCodigoCliente_CCLNT = Bulto.pCCLNT_CodigoCliente
            .pCodigoRecepcion_CREFFW = Bulto.pCREFFW_CodigoBulto
            .pCodigoCompania_CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCodigoDivision_CDVSN = UcDivision_Cmb011.Division
            .pCodigoPlanta_CPLNDV = UcPLanta_Cmb011.Planta
            .ShowDialog()
            .Dispose()
            fRePacking = Nothing
        End With
        dgBultos.pRefrescar()
    End Sub

    Private Sub frmRecepciónBultos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dteFechaInicial.Value = Now
        dteFechaFinal.Value = Now
        ' ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Informamos a los controles el Usuario actual
        dgBultos.pUsuario = objSeguridadBN.pUsuario
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("InterfaseExcel", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtClient.pCargar(ClientePK)

        If txtClient.pCodigo <> 0 Then dgBultos.pCCLNT_CodigoCliente = txtClient.pCodigo
        Call mpMostrarClienteMDI(txtClient.pCodigo)
        objAppConfig = Nothing

        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        CargarUbicacion()
    End Sub

    Private Sub txtClient_InformationChanged() Handles txtClient.InformationChanged
        dgBultos.pClear()
    End Sub

    Private Sub txtClient_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClient.Validating
        dgBultos.pCCLNT_CodigoCliente = txtClient.pCodigo
    End Sub

     
#End Region

    'Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
    '    UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
    '    UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
    '    UcDivision_Cmb011.pActualizar()
    'End Sub

    'Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.TYPEDEF.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
    '    UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
    '    UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
    '    UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
    '    UcPLanta_Cmb011.pActualizar()
    'End Sub
    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    'Ransa.Controls.


    Private Sub CargarUbicacion()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        Dim objNegocio As New Ransa.NEGO.brUbicacionesXCliente

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR_1"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación "
        oColumnas.Visible = False
        oListColum.Add(2, oColumnas)
        txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(Me.txtClient.pCodigo)
        txtUbicacionReferencial.ListColumnas = oListColum
        txtUbicacionReferencial.Cargas()
        txtUbicacionReferencial.Limpiar()
        txtUbicacionReferencial.ValueMember = "PSTUBRFR"
        txtUbicacionReferencial.DispleyMember = "PSTUBRFR"
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtClient.InformationChanged
        CargarUbicacion()
    End Sub
End Class
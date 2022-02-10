Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLiquidacionFleteConsolidado

#Region " Atributos "
    Private bolBuscar As Boolean
    Private lintEstadoOpcion As Integer = 0
    Private pGuiaRemPrincipal As Int64
    Private pGuiaRemPrincipalTxt = ""
    Private pListaGuiasHijas As String
    Private pFechaGuiaPrincipal As Date
#End Region

#Region " Propiedades "

#End Region

#Region " Métodos y Funciones "
    'Private Sub Alinear_Columnas_Grilla()
    '    Me.gwdDatos.AutoGenerateColumns = False
    '    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
    '        Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    Next
    '    For lint_contador As Integer = 0 To Me.dtGRemCargGTransLiq.ColumnCount - 1
    '        Me.dtGRemCargGTransLiq.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    Next
    'End Sub

    Private Sub Cargar_Compania()
        'Try
        cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        cboPlanta.Text = ""

        If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next

            objEntidad = New ENTIDADES.mantenimientos.ClaseGeneral
            objEntidad.CPLNDV = 0
            objEntidad.TPLNTA = "Todos"
            objLisEntidad.Insert(0, objEntidad)


            cboPlanta.DisplayMember = "TPLNTA"
            cboPlanta.ValueMember = "CPLNDV"
            Me.cboPlanta.DataSource = objLisEntidad


            If objLisEntidad.Count > 0 Then
                cboPlanta.SetItemChecked(0, True)
            End If

        End If

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            'cmbPlanta.Usuario = MainModule.USUARIO
            'cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            'cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            'cmbPlanta.PlantaDefault = 1
            'cmbPlanta.pActualizar()
            'Me.InicializarFormulario()
            cargarComboPlanta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Limpiar_Controles()
        Me.gwdDatos.DataSource = Nothing
        'Me.dtGRemCargGTransLiq.Rows.Clear()
        Me.dtGRemCargGTransLiq.DataSource = Nothing
    End Sub

    Private Sub Listar_Viaje_Consolidado()
        'Try
        Dim PlantasSel As String = ""
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PNCTRMNC", Me.cboTransportista.pCodigoRNS)
        objetoParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objetoParametro.Add("PSCDVSN", Me.cmbDivision.Division)
        'objetoParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta)
        PlantasSel = DevuelvePlantaSeleccionadas()
        objetoParametro.Add("PSCPLNDV", PlantasSel)
        objetoParametro.Add("PNFECINI", IIf(Me.dtpFechaInicio.Checked = True, CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double), 0))
        objetoParametro.Add("PNFECFIN", IIf(Me.dtpFechaFin.Checked = True, CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double), 0))
        objetoParametro.Add("PNNMVJCS", IIf(Me.txtViajeConsolidado.Enabled = True, Me.txtViajeConsolidado.Text, 0))

        Me.gwdDatos.DataSource = Objeto_Logica.Listar_Viaje_Consolidado(objetoParametro)

        'Catch : End Try

    End Sub

    Private Sub Listar_GRemCargadasGTranspLiq_Consolidado()
        Dim oFiltro As New TransporteConsolidado
        Dim oGuiaTransportista As New GuiaTransportista_BLL
        'Dim dwvrow As DataGridViewRow

        'LIMPIANDO EL dtGRemCargGTransLiq
        'Me.dtGRemCargGTransLiq.Rows.Clear()
        dtGRemCargGTransLiq.DataSource = Nothing

        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        oFiltro.NMVJCS = Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
        oFiltro.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        'Me.dtGRemCargGTransLiq.DataSource = oGuiaTransportista.Listar_GRemCargadasGTranspLiquidacion_Consolidado(oFiltro)
        'LLENANDO EL dtGRemCargGTransLiq

        Dim oList As New List(Of TD_Obj_GRemCargadasGTranspLiq)
        oList = oGuiaTransportista.Listar_GRemCargadasGTranspLiquidacion_Consolidado(oFiltro)

        dtGRemCargGTransLiq.DataSource = oList

        'dim fila as Integer
        'For Each oEntidad As TD_Obj_GRemCargadasGTranspLiq In oGuiaTransportista.Listar_GRemCargadasGTranspLiquidacion_Consolidado(oFiltro)
        '    dwvrow = New DataGridViewRow
        '    dwvrow.CreateCells(Me.dtGRemCargGTransLiq)
        '    Me.dtGRemCargGTransLiq.Rows.Add(dwvrow)
        '    fila = dtGRemCargGTransLiq.Rows.Count - 1


        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_NOPRCN").Value = oEntidad.pNOPRCN_NroOperacion
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_NGUIRM").Value = oEntidad.pNGUIRM_NroGuiaTransportista
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_NGUITR").Value = oEntidad.pNGUITR_GuiaRemisionCargada
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_FGUITR").Value = oEntidad.pFGUITR_FechaGuiaRemision
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_PMRCMC").Value = oEntidad.pPMRCMC_PesoNeto
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_PBRTOR").Value = oEntidad.pPBRTOR_PesoBruto
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_PSOVOL").Value = oEntidad.pPSOVOL_PesoVolumen
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_QCNDTG").Value = oEntidad.pQCNDTG_CantServicioGuia
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_CUNDSR").Value = oEntidad.pCUNDSR_Unidad
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_NLQDCN").Value = oEntidad.pNLQDCN_NroLiquidacion
        '    dtGRemCargGTransLiq.Rows(fila).Cells("L_SGUIFC").Value = oEntidad.pSGUIFC_StatusFacturado
        '    dtGRemCargGTransLiq.Rows(fila).Cells("NCRDCO").Value = oEntidad.pNCRDCO

        'Next
    End Sub


    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If cmbCompania.CCMPN_CodigoCompania = "" Then
            lstr_validacion += "* COMPAÑIA " & Chr(13)
        End If
        If Me.cmbDivision.Division = "" Then
            lstr_validacion += "* DIVISION" & Chr(13)
        End If
       
        If cboPlanta.CheckedItems.Count = 0 Then
            lstr_validacion += "* Seleccione planta." & Chr(13)
        End If

        If Me.checkViajeConsolidado.Checked = True Then
            If Me.txtViajeConsolidado.Text.Trim.Equals("") Then lstr_validacion += "* N° VIAJE CONSOLIDADO" & Chr(13)
        Else
            If Not Me.cboTransportista.pRucTransportista.Trim.Equals("") Then
                If Me.dtpFechaInicio.Checked = False OrElse Me.dtpFechaFin.Checked = False Then
                    lstr_validacion += "* FECHA" & Chr(13)
                End If
            End If
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

     

        If objEntidad.STSOP2 = "X" Then
            Me.lintEstadoOpcion = 1
        End If

    End Sub

    Private Sub Imprimir_Consistencia()
        Dim obj_Logica_Operacion As GuiaTransportista_BLL = New GuiaTransportista_BLL
        Dim obj_Logica_Reparto As GuiaTransportista_BLL = New GuiaTransportista_BLL
        Dim obj_Logica_Multimodal As GuiaTransportista_BLL = New GuiaTransportista_BLL
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim objDt As New DataTable
        Dim objetoRep As New rptConsistencia_Liquidacion
        Dim objParametro As New Hashtable
        'Try
        If Me.dtGRemCargGTransLiq.RowCount = 0 Then
            MessageBox.Show("Primero debe seleccionar un viaje consolidado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        objParametro.Add("NMVJCS", Me.gwdDatos.Item("NMVJCS", lint_Indice).Value)
        objParametro.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objParametro.Add("CDVSN", Me.cmbDivision.Division)
        'objParametro.Add("CPLNDV", Me.cmbPlanta.Planta)
        objParametro.Add("CPLNDV", gwdDatos.CurrentRow.Cells("CPLNDV").Value)
        objParametro.Add("FECHA", HelpClass.CDate_a_Numero8Digitos(Date.Today))
        objDt = HelpClass.GetDataSetNative(obj_Logica_Reparto.Listar_Consistencia_Liquidacion_Servicio_Consolidado(objParametro))

        objDt.TableName = "RZTR32"

        If objDt.Rows.Count = 0 Then
            HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
            Exit Sub
        End If
        objDs.Tables.Add(objDt.Copy)
        objetoRep.SetDataSource(objDs)
        If Me.checkViajeConsolidado.Checked = True Then
            CType(objetoRep.ReportDefinition.ReportObjects("lblNroReparto"), TextObject).Text = Me.txtViajeConsolidado.Text.Trim
        Else
            CType(objetoRep.ReportDefinition.ReportObjects("lblReparto"), TextObject).Text = ""
        End If
        CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cmbCompania.CCMPN_Descripcion
        CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cmbDivision.DivisionDescripcion
        'CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cmbPlanta.DescripcionPlanta
        CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = gwdDatos.CurrentRow.Cells("TPLNTA").Value
        CType(objetoRep.ReportDefinition.ReportObjects("lblNroLiquidacion"), TextObject).Text = "N° " & Me.dtGRemCargGTransLiq.Item("L_NLQDCN", 0).Value
        objPrintForm.ShowForm(objetoRep, Me)

        'Catch : End Try

    End Sub

    'Private Sub Actualizar_Operaciones_Servicios_Importes(ByVal pNOPRCN As Int64, ByVal pCCMPN As String, ByVal pCDVSN As String)
    '    Dim Objeto_Logica As New GuiaTransportista_BLL
    '    Dim dtOperaciones As DataTable
    '    Dim objParametro As New Hashtable
    '    Dim objParam As New Hashtable
    '    Dim MonedaGuia As Integer = 1
    '    Dim MonedaLiquida As Integer = 1
    '    Dim aSolesGuia As Boolean = True
    '    Dim aSolesLiq As Boolean = True
    '    Dim SumISRVGU As Double = 0
    '    Dim SumILQDTR As Double = 0

    '    'Try
    '    objParametro.Add("NOPRCN", pNOPRCN) 'Me.gwdDatos.Item("NOPRCN", Me.gwdDatos.CurrentCellAddress.Y).Value)
    '    objParametro.Add("CCMPN", pCCMPN) 'Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value)
    '    objParametro.Add("CDVSN", pCDVSN) 'Me.gwdDatos.Item("CDVSN", Me.gwdDatos.CurrentCellAddress.Y).Value)

    '    dtOperaciones = Objeto_Logica.Listar_Operaciones_X_Servicios_Importes(objParametro)
    '    If dtOperaciones.Rows.Count > 0 Then


    '        For indice As Integer = 0 To dtOperaciones.Rows.Count - 1
    '            If aSolesGuia = True Then ' SI SE CONVIERTE A SOLES IMPORTE A COBRAR
    '                If dtOperaciones.Rows(indice).Item("CMNDGU") = 100 Then
    '                    dtOperaciones.Rows(indice).Item("ISRVGU") = dtOperaciones.Rows(indice).Item("ISRVGU") * dtOperaciones.Rows(indice).Item("IVNTA")
    '                End If
    '            Else 'SI SE CONVIERTE A DOLAR IMPORTE A COBRAR
    '                If dtOperaciones.Rows(indice).Item("CMNDGU") = 1 Then
    '                    dtOperaciones.Rows(indice).Item("ISRVGU") = dtOperaciones.Rows(indice).Item("ISRVGU") / dtOperaciones.Rows(indice).Item("IVNTA")
    '                End If
    '            End If
    '            If aSolesLiq = True Then ' SI SE CONVIERTE A SOLES IMPORTE A PAGAR
    '                If dtOperaciones.Rows(indice).Item("CMNLQT") = 100 Then
    '                    dtOperaciones.Rows(indice).Item("ILQDTR") = dtOperaciones.Rows(indice).Item("ILQDTR") * dtOperaciones.Rows(indice).Item("IVNTA")
    '                End If
    '            Else 'SI SE CONVIERTE A DOLAR IMPORTE A PAGAR
    '                If dtOperaciones.Rows(indice).Item("CMNLQT") = 1 Then
    '                    dtOperaciones.Rows(indice).Item("ILQDTR") = dtOperaciones.Rows(indice).Item("ILQDTR") / dtOperaciones.Rows(indice).Item("IVNTA")
    '                End If
    '            End If

    '            SumISRVGU = SumISRVGU + dtOperaciones.Rows(indice).Item("ISRVGU")
    '            SumILQDTR = SumILQDTR + dtOperaciones.Rows(indice).Item("ILQDTR")
    '        Next
    '    Else
    '        MonedaGuia = 0
    '        MonedaLiquida = 0
    '    End If

    '    objParam.Add("NOPRCN", pNOPRCN) 'Me.gwdDatos.Item("NOPRCN", Me.gwdDatos.CurrentCellAddress.Y).Value)
    '    objParam.Add("CMNDGU", MonedaGuia)
    '    objParam.Add("ISRVGU", SumISRVGU)
    '    objParam.Add("CMNLQT", MonedaLiquida)
    '    objParam.Add("ILQDTR", SumILQDTR)
    '    objParam.Add("CCMPN", pCCMPN) 'Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value)
    '    objParam.Add("CDVSN", pCDVSN) 'Me.gwdDatos.Item("CDVSN", Me.gwdDatos.CurrentCellAddress.Y).Value)

    '    Objeto_Logica.Actualizar_Operaciones_X_Servicios_Importes(objParam)
    '    'Catch ex As Exception

    '    'End Try
    'End Sub

#End Region

#Region " Eventos "

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.Validar_Datos_Filtro = True Then Exit Sub
            Me.txtViajeConsolidado.Tag = 0
            Me.Limpiar_Controles()
            Me.Listar_Viaje_Consolidado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnCargarGuiaPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarGuiaPendiente.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim decPSOVOL As Decimal = Me.gwdDatos.Item("PSOVOL", Me.gwdDatos.CurrentCellAddress.Y).Value
            If decPSOVOL = 0 Then
                HelpClass.MsgBox("El Viaje Consolidado N° " & Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value & " no tiene asignado Peso Volumen", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim bResultado As Boolean = True
            Dim sErrorMesage As String = ""
            Dim resultado As Int32 = 0
            Dim objLogica As New GuiaTransportista_BLL
            Dim objEntidad As New GuiaTransportista
            Dim objetoParametro As New Hashtable
            objetoParametro.Add("PNNMVJCS", Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value)
            objetoParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
            objetoParametro.Add("PSCDVSN", Me.cmbDivision.Division)
            'objetoParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta)
            objetoParametro.Add("PNCPLNDV", gwdDatos.CurrentRow.Cells("CPLNDV").Value)

            Dim oList As New List(Of GuiaTransportista)
            oList = objLogica.Lista_Guia_Transporte_Consolidado(objetoParametro)

            For Each Objeto_Entidad_Guia As GuiaTransportista In oList

                If Objeto_Entidad_Guia.SESGRP <> "" Then
                    MessageBox.Show("Guías ya fueron cargadas", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim iCont As Integer = 0

                Me.Listar_GRemPendientesGTranspLiq(Objeto_Entidad_Guia.CTRMNC, Objeto_Entidad_Guia.NGUIRM, Me.cmbCompania.CCMPN_CodigoCompania)

                Dim oTemp As TD_Obj_InfGRemCargada = New TD_Obj_InfGRemCargada
                With oTemp
                    .pCTRMNC_CodigoTransportista = Objeto_Entidad_Guia.CTRMNC
                    .pNGUIRM_NroGuiaTransportista = Objeto_Entidad_Guia.NGUIRM
                    .pNGUITR_GuiaRemisionCargada = pGuiaRemPrincipal
                    .pNGUITR_GuiaRemisionCargadaTXT = pGuiaRemPrincipalTxt
                    .pFGUITR_FechaGuiaRemision = pFechaGuiaPrincipal
                    .pRELGUI_RelacionGuiaHijas = pListaGuiasHijas
                    .pCCLNT1_CodigoCliente = Objeto_Entidad_Guia.CCLNT
                    .pCLCLOR_CodigoLocalidadOrigen = Objeto_Entidad_Guia.CLCLOR
                    .pTCMLCO_LocalidadOrigen = Objeto_Entidad_Guia.TCMLCO
                    .pCLCLDS_CodigoLocalidadDestino = Objeto_Entidad_Guia.CLCLDS
                    .pTCMLCD_LocalidadDestino = Objeto_Entidad_Guia.TCMLCD

                    .pNOPRCN_NroOperacion = Objeto_Entidad_Guia.NOPRCN
                    .pNLQDCN_NroLiquidacion = 0
                    .pCTRSPT_Transportista = Objeto_Entidad_Guia.CTRSPT
                    .pTCMTRT_RazSocialTransportista = Objeto_Entidad_Guia.TCMTRT
                    .pNPLVHT_Tracto = Objeto_Entidad_Guia.NPLCTR
                    .pCBRCNT_Brevete = Objeto_Entidad_Guia.CBRCNT
                    .pCMRCDR_Mercaderia = Objeto_Entidad_Guia.CMRCDR
                    .pTAMRCD_DetalleMercaderia = Objeto_Entidad_Guia.TCMRCD
                    .pFRCGRM_FechaRecepGuiaRemision = Now

                    .pQGLGSL_CantidadGlsGasolina = Objeto_Entidad_Guia.QGLGSL
                    .pQGLDSL_CantidadGlsDiesel = Objeto_Entidad_Guia.QGLDSL
                    .pNRHJCR_NroHojasCargui = Objeto_Entidad_Guia.NRHJCR
                    .pCPRCN1_CodigoPropietarioContenedor1 = ""
                    .pNSRCN1_SerieContenedor1 = ""
                    .pCPRCN2_CodigoPropietarioContenedor2 = ""
                    .pNSRCN2_SerieContenedor2 = ""

                    .pFSLDCM_FechaSalidaCamion = pFechaGuiaPrincipal
                    .pQKLMRC_KilometrosRecorridos = Objeto_Entidad_Guia.QKMREC
                    .pQHRSRV_CantidadHorasServicio = 0

                    .pQBLRMS_CantidadBultosRemision = Objeto_Entidad_Guia.QMRCMC
                    
                    .pQVLMOR_VolumenRemision = Objeto_Entidad_Guia.QVLMOR
                    .pQBLRCP_CantidadBultosRecepcion = Objeto_Entidad_Guia.QMRCMC
                    .pPBRTOR_PesoBrutoRemision = Objeto_Entidad_Guia.PMRCMC  ' nuevo 2019
                    .pPBRDST_PesoBrutoRecepcion = Objeto_Entidad_Guia.PMRCMC  ' nuevo 2019

                    .pQVLMDS_VolumenRecepcion = Objeto_Entidad_Guia.QVLMOR
                    .pNOREMB_OrdenEmbarcador = Objeto_Entidad_Guia.NOREMB
                    .pSSINVJ_FlagSiniestroViaje = Objeto_Entidad_Guia.SSINVJ
                    .pMMCUSR_Usuario = MainModule.USUARIO
                    .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina

                End With

                bResultado = objLogica.Registrar_GuiaRemisionLiqTransp(oTemp, sErrorMesage)
                If Not bResultado Or sErrorMesage <> "" Then
                    MessageBox.Show(sErrorMesage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


            Next
            If sErrorMesage = "" Then
                Me.gwdDatos.Item("FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"
                Me.gwdDatos.EndEdit()
                'Me.dtGRemCargGTransLiq.Rows.Clear()
                dtGRemCargGTransLiq.DataSource = Nothing
                Me.Listar_GRemCargadasGTranspLiq_Consolidado()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.gwdDatos.RowCount > 0 Then
                If dtGRemCargGTransLiq.RowCount <= 0 Then
                    MessageBox.Show("No existe información de alguna Guía cargada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If Me.gwdDatos.Item("FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C" Then
                    MessageBox.Show("Guías cargadas no pueden eliminarse, Viaje Consolidado Liquidado", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If MessageBox.Show("¿Desea eliminar el registro?", "Mensaje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Dim Objeto_Logica As New GuiaTransportista_BLL

                Dim dtServicio As DataTable = Objeto_Logica.ListaServiciosConsolidados(Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value, Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)

                For Each row As DataRow In dtServicio.Rows
                    If (row("NCRDCO") <> 0) Then
                        MessageBox.Show("No se puede eliminar. Tiene tarifa interna asignada", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                Next



                Dim oLiquidacionGT_ViajeConsolidado As New TransporteConsolidado

                With oLiquidacionGT_ViajeConsolidado
                    .NMVJCS = Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .FCHVJC = HelpClass.TodayNumeric
                    .CUSCTR = MainModule.USUARIO
                    .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                    .CDVSN = Me.cmbDivision.Division
                    '.CPLNDV = Me.cmbPlanta.Planta
                    .CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value

                End With

                ' Instanceamos la clase de procesos

                Dim sMensajeError As String = ""
                If Not Objeto_Logica.Eliminar_GRemCargadasGTranspLiquidacion_Consolidado(oLiquidacionGT_ViajeConsolidado, sMensajeError) Then
                    MessageBox.Show("Error en el proceso de Eliminación. " & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    HelpClass.MsgBox("Se eliminó satisfactoriamente", MessageBoxIcon.Information)
                    Me.gwdDatos.Item("FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"
                    'For lintContador As Integer = 0 To Me.dtGRemCargGTransLiq.RowCount - 1
                    '    Actualizar_Operaciones_Servicios_Importes(Me.dtGRemCargGTransLiq.Item("L_NOPRCN", lintContador).Value, Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                    'Next
                    Me.Listar_GRemCargadasGTranspLiq_Consolidado()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub btnLiqGuiaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiqGuiaRemision.Click
        Dim oLiquidacionGT_ViajeConsolidado As TransporteConsolidado
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim sMensajeError As String = ""
        'Dim msgTarifaInterna As String = ""
        Dim sMensajeAlerta As String = ""
        Dim msgFinal As String = ""
        Try
            If dtGRemCargGTransLiq.RowCount <= 0 Then
                MessageBox.Show("No existe información de alguna Guía cargada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            For lintContador As Integer = 0 To Me.dtGRemCargGTransLiq.RowCount - 1
                If dtGRemCargGTransLiq.Item("L_NLQDCN", lintContador).Value <> 0 Then
                    MessageBox.Show("Guía ya posee una Liquidación.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

            'Dim dtServicio As DataTable = Objeto_Logica.ListaServiciosConsolidados(Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value, Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
            
            If MessageBox.Show("¿Desea Generar la Liquidación para el Viaje Consolidado N° " & Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value & "?", "Liquidación:", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub

            Dim bolEstado As Boolean = False

            sMensajeError = ""
            oLiquidacionGT_ViajeConsolidado = New TransporteConsolidado

            With oLiquidacionGT_ViajeConsolidado
                .NMVJCS = Me.gwdDatos.Item("NMVJCS", Me.gwdDatos.CurrentCellAddress.Y).Value
                .FCHVJC = HelpClass.TodayNumeric
                .CUSCTR = MainModule.USUARIO
                .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                .CDVSN = Me.cmbDivision.Division
                '.CPLNDV = Me.cmbPlanta.Planta
                .CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                .TIPO = 1
            End With

            If Objeto_Logica.Validar_GuiaTransportista_ViajeConsolidado(oLiquidacionGT_ViajeConsolidado, sMensajeError, sMensajeAlerta) Then


                ' Dim resp = MsgBox("El valor refencial es mayor al 10% del importe mas su IGV " & Chr(13) & "¿Desea Continuar?", "Liquidación", vbYesNo)
                'If resp = vbYes Then

                If sMensajeAlerta.Length > 0 Then
                    If MessageBox.Show(sMensajeAlerta & Chr(13) & "¿Desea Continuar?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If

                'If MessageBox.Show("El valor refencial es mayor al 10% del importe mas su IGV " & Chr(13) & "¿Desea Continuar?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim msgRespuestaLiq As String = ""
                msgRespuestaLiq = Objeto_Logica.Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(oLiquidacionGT_ViajeConsolidado)
                'If Objeto_Logica.Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(oLiquidacionGT_ViajeConsolidado) = 0 Then
                If msgRespuestaLiq = "" Then
                    oLiquidacionGT_ViajeConsolidado.TIPO = 2
                    If Objeto_Logica.Validar_GuiaTransportista_ViajeConsolidado(oLiquidacionGT_ViajeConsolidado, sMensajeError, sMensajeAlerta) Then

                        'Me.gwdDatos.Item("FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C"
                        gwdDatos.CurrentRow.Cells("FLGSTS").Value = "C"
                        'For lintContador As Integer = 0 To Me.dtGRemCargGTransLiq.RowCount - 1
                        '    Actualizar_Operaciones_Servicios_Importes(Me.dtGRemCargGTransLiq.Item("L_NOPRCN", lintContador).Value, Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                        'Next
                        msgFinal = "Liquidación culminó satisfactoriamente. "
                        If sMensajeAlerta <> "" Then
                            msgFinal = "Liquidación con observaciones."
                            msgFinal = msgFinal & Chr(13) & sMensajeAlerta
                        End If
                        'Objeto_Logica.Procesar_Generacion_Consolidado_AsientoCO_TarifaInterna(oLiquidacionGT_ViajeConsolidado, msgTarifaInterna)

                        'If msgTarifaInterna <> "" Then
                        '    msgFinal = msgFinal & Chr(13) & msgTarifaInterna
                        'End If
                        msgFinal = msgFinal.Trim

                        Dim msgIcono As MessageBoxIcon
                        'If sMensajeAlerta <> "" Or msgTarifaInterna <> "" Then
                        If sMensajeAlerta <> "" Then
                            msgIcono = MessageBoxIcon.Warning
                        Else
                            msgIcono = MessageBoxIcon.Information
                        End If

                        MessageBox.Show(msgFinal, "Liquidación", MessageBoxButtons.OK, msgIcono)
                        'MessageBox.Show(String.Format("Liquidación culminó satisfactoriamente. {0}{1}", Environment.NewLine, sMensajeTarifaInterna), "Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MessageBox.Show(msgRespuestaLiq, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                'Else
                '    MessageBox.Show("Existe un Error al Liquidar Guía.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
            Else
                MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Listar_GRemCargadasGTranspLiq_Consolidado()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

   

    Private Sub InicializarFormulario()
        Me.cboTransportista.pClearAll()
        Dim oTransPK As TD_TransportistaPK = New TD_TransportistaPK(Me.cmbCompania.CCMPN_CodigoCompania, "", "")
        Me.cboTransportista.pCargar(oTransPK)
        Me.Limpiar_Controles()
    End Sub

    Private Sub dtGRemCargGTransLiq_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGRemCargGTransLiq.CellContentClick
        Try
            If dtGRemCargGTransLiq.RowCount <= 0 OrElse e.RowIndex < 0 Then Exit Sub
            ' Verificaos que se haya dado clic en la columna de la Guía de Remisión
            Select Case dtGRemCargGTransLiq.Columns(e.ColumnIndex).Name
                Case "L_NGUITR"
                     
                    Dim fDlgLiqFlete As frmLiquidacionFlete_DlgCargarGuia = New frmLiquidacionFlete_DlgCargarGuia()
                    'fDlgLiqFlete.TPOPRCN = 2
                    fDlgLiqFlete.pAccion = frmLiquidacionFlete_DlgCargarGuia.Accion.Modificar
                    fDlgLiqFlete.pCCMPN = Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value 'Objeto_Entidad_Guia.CCMPN
                    fDlgLiqFlete.pCDVSN = Me.gwdDatos.Item("CDVSN", Me.gwdDatos.CurrentCellAddress.Y).Value 'Objeto_Entidad_Guia.CDVSN
                    fDlgLiqFlete.PSStatusLiquidacion_SESGRP = IIf(Me.gwdDatos.Item("FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value = "C", "L", Me.gwdDatos.Item("FLGSTS", Me.gwdDatos.CurrentCellAddress.Y).Value)

                    fDlgLiqFlete.pNOPRCN = Me.dtGRemCargGTransLiq.Item("L_NOPRCN", e.RowIndex).Value 'Objeto_Entidad_Guia.NOPRCN
                    fDlgLiqFlete.pNGUIAREM = Me.dtGRemCargGTransLiq.Item("L_NGUITR", e.RowIndex).Value
                     
                    If fDlgLiqFlete.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.Listar_GRemCargadasGTranspLiq_Consolidado()
                        'Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
                        '        Objeto_Entidad_Guia.CCMPN, Objeto_Entidad_Guia.CDVSN, _
                        '        dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value, _
                        '        dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value)
                        '' No validamos el resultado obtenido por la ventana
                        'fMostrarInfAdic.ShowDialog()
                    End If
                Case "L_CREFFW"
                    Dim fDlgConsistencia As frmConsistenciaBulto_x_Operacion = New frmConsistenciaBulto_x_Operacion
                    Dim lintIndice As Int32 = Me.gwdDatos.CurrentCellAddress.Y
                    With fDlgConsistencia
                        .txtTransportista.Text = Me.gwdDatos.Item("TCMTRT", lintIndice).Value
                        .txtPlaca.Text = Me.gwdDatos.Item("NPLCTR", lintIndice).Value
                        .txtAcoplado.Text = Me.gwdDatos.Item("NPLCAC", lintIndice).Value
                        .txtConductor.Text = Me.gwdDatos.Item("CBRCND", lintIndice).Value
                        .txtFecha.Text = "" 'Me.gwdDatos.Item("FGUIRM_S", lintIndice).Value
                        .txtGuiaTransporte.Text = Me.dtGRemCargGTransLiq.Item("L_NGUIRM", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                        .txtOperacion.Text = Me.dtGRemCargGTransLiq.Item("L_NOPRCN", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                        .txtOrigen.Text = Me.gwdDatos.Item("RUTA", lintIndice).Value
                        .CTRMNC = Me.dtGRemCargGTransLiq.Item("L_CTRSPT", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                        .NGUITR = Me.dtGRemCargGTransLiq.Item("L_NGUIRM", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                        .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                        .CDVSN = Me.cmbDivision.Division

                        .CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                        '.CPLNDV = Me.cmbPlanta.Planta
                        .txtPlaca.Tag = Me.cmbCompania.CCMPN_Descripcion
                        .txtAcoplado.Tag = Me.cmbDivision.DivisionDescripcion
                        '.txtConductor.Tag = Me.cmbPlanta.DescripcionPlanta
                        .txtConductor.Tag = gwdDatos.CurrentRow.Cells("TPLNTA").Value
                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    End With
                Case "NCRDCO"
                    Dim frm As New frmTarifaInterna()
                    frm.NroOperacion = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                    frm.NroGuiaTransporte = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                    frm.BotonVisibleSAP = True
                    frm.ShowDialog()

                Case "L_NLQDCN"


                    Dim ofrmLiquidacionesConsultaProveedor As New frmLiquidacionesConsultaProveedor
                    ofrmLiquidacionesConsultaProveedor.pNOPRCN = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                    ofrmLiquidacionesConsultaProveedor.pNGUIRM = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                    ofrmLiquidacionesConsultaProveedor.pCCMPN = cmbCompania.CCMPN_CodigoCompania
                    ofrmLiquidacionesConsultaProveedor.pCDVSN = Me.cmbDivision.Division
                    'ofrmLiquidacionesConsultaProveedor.pCPLNDV = Me.cmbPlanta.Planta
                    ofrmLiquidacionesConsultaProveedor.pCPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                    ofrmLiquidacionesConsultaProveedor.ShowDialog()

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub frmLiquidacionFlete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bolBuscar = False
            gwdDatos.AutoGenerateColumns = False
            dtGRemCargGTransLiq.AutoGenerateColumns = False
            Me.Validar_Acceso_Opciones_Usuario()
            Me.Cargar_Compania()
            'Me.Listar_Guias_Transportista()
            'Me.Alinear_Columnas_Grilla()
            Dim oTransPK As TD_TransportistaPK = New TD_TransportistaPK(Me.cmbCompania.CCMPN_CodigoCompania, "", "")
            cboTransportista.pCargar(oTransPK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    '    Try
    '        If e.RowIndex < 0 Then Exit Sub
    '        Me.dtGRemCargGTransLiq.Rows.Clear()
    '        Me.Listar_GRemCargadasGTranspLiq_Consolidado()
    '        'Me.Listar_GRemCargadasGTranspLiq_Operacion()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try



    'End Sub

    'Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    '    Try
    '        If Me.gwdDatos.Rows.Count > 0 Then Me.gwdDatos.CurrentRow.Selected = False
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    '    Try
    '        If Me.gwdDatos.RowCount = 0 Then Exit Sub
    '        Select Case e.KeyCode
    '            Case Keys.Enter, Keys.Up, Keys.Down
    '                Me.dtGRemCargGTransLiq.Rows.Clear()
    '                Me.Listar_GRemCargadasGTranspLiq_Consolidado()
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
        Try
            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 OrElse lint_Indice < 0 Then Exit Sub
            Me.Imprimir_Consistencia()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub txtNroOperacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtViajeConsolidado.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtNroOperacion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtViajeConsolidado.KeyUp
        Try
            If sender.Text.Length > 0 And e.KeyCode = Keys.Enter Then
                Me.cboTransportista.pClear()
                Me.btnBuscar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    

    End Sub

    Private Sub checkViajeConsolidado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkViajeConsolidado.CheckedChanged
        Select Case checkViajeConsolidado.Checked
            Case True
                Me.dtpFechaInicio.Checked = False
                Me.dtpFechaFin.Checked = False
                Me.dtpFechaFin.Enabled = False
                Me.dtpFechaInicio.Enabled = False
                Me.txtViajeConsolidado.Enabled = True
                Me.cboTransportista.Enabled = True
                If Me.gwdDatos.RowCount > 0 Then
                    Me.Limpiar_Controles()
                End If
            Case False
                Me.dtpFechaInicio.Checked = True
                Me.dtpFechaFin.Checked = True
                Me.dtpFechaFin.Enabled = True
                Me.dtpFechaInicio.Enabled = True
                Me.txtViajeConsolidado.Enabled = False
                Me.cboTransportista.Enabled = True
                Me.Limpiar_Controles()
        End Select
    End Sub

    Private Sub Listar_GRemPendientesGTranspLiq(ByVal pCTRMNC As Int32, ByVal pNGUIRM As Int64, ByVal pCCMPN As String)
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim oGuiaTransportistaPK As New TD_GuiaTransportistaPK
        pGuiaRemPrincipal = 0
        pGuiaRemPrincipalTxt = ""
        pListaGuiasHijas = ""
        pFechaGuiaPrincipal = Date.Now

        oGuiaTransportistaPK.pCTRMNC_CodigoTransportista = pCTRMNC
        oGuiaTransportistaPK.pNGUIRM_NroGuiaTransportista = pNGUIRM
        oGuiaTransportistaPK.pCCMPN_Ccompania = pCCMPN


        Dim oListGTLiquidacion As New List(Of TD_Obj_GuiaRemisionGTransp)
        oListGTLiquidacion = Objeto_Logica.Listar_GRemPendientesGTranspLiquidacion(oGuiaTransportistaPK)

        'LLENANDO EL dtgGuiasPendientes
        For Each objEntidad As TD_Obj_GuiaRemisionGTransp In oListGTLiquidacion
            If pGuiaRemPrincipal = 0 Then
                pGuiaRemPrincipal = objEntidad.pNRGUCL_NroGuiaRemision
                pFechaGuiaPrincipal = objEntidad.pFCGUCL_FechaGuiaRemision
                pGuiaRemPrincipalTxt = objEntidad.pNGUIRS
             
            Else
                If objEntidad.pNRGUCL_NroGuiaRemision <> pGuiaRemPrincipal Then
                    If pListaGuiasHijas <> "" Then pListaGuiasHijas = pListaGuiasHijas & ","
                    pListaGuiasHijas = pListaGuiasHijas & objEntidad.pNRGUCL_NroGuiaRemision
                End If
            End If
        Next

    End Sub

    Private Function DevuelvePlantaSeleccionadas() As String
        Dim CodPlanta As String = ""
        Dim strCodPlanta As String = ""
        Dim PlantaTodos As Boolean = False
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            CodPlanta = cboPlanta.CheckedItems(i).Value.ToString.Trim
            If CodPlanta = "0" Then
                PlantaTodos = True
                Exit For
            End If
            strCodPlanta = strCodPlanta & CodPlanta & ","
        Next
        If PlantaTodos = True Then
            strCodPlanta = ""
            For i As Integer = 1 To cboPlanta.Items.Count - 1
                strCodPlanta = strCodPlanta & cboPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return strCodPlanta
    End Function

    'Private Function SumarValoresTI(ByVal data As DataTable) As Decimal

    '    Dim resultado As Decimal

    '    For Each fila As DataRow In data.Rows
    '        If fila("SFLGTI") = "X" Then
    '            resultado = resultado + Val(fila("QCNDTI") * fila("ISRVTI"))
    '        End If
    '    Next

    '    Return resultado

    'End Function

#End Region

    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged
       
        Try
            'Me.dtGRemCargGTransLiq.Rows.Clear()
            'dtGRemCargGTransLiq
            Me.Listar_GRemCargadasGTranspLiq_Consolidado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
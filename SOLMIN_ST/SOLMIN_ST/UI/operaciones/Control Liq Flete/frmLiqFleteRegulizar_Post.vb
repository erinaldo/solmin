Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLiqFleteRegulizar_Post

#Region " Atributos "
    Private bolBuscar As Boolean
    'Public Objeto_Entidad_Guia As New GuiaTransportista
    'Private lintEstadoOpcion As Integer = 0
#End Region

#Region " Métodos y Funciones "
   

    'Private Sub Asignacion_Datos_Objeto(ByVal lint_Indice As Integer)
    '    Objeto_Entidad_Guia = New GuiaTransportista
    '    Objeto_Entidad_Guia.CTRMNC = Me.gwdDatos.Item("CTRMNC", lint_Indice).Value
    '    Objeto_Entidad_Guia.NGUIRM = Me.gwdDatos.Item("NGUIRM", lint_Indice).Value
    '    Objeto_Entidad_Guia.FGUIRM_S = Me.gwdDatos.Item("FGUIRM_S", lint_Indice).Value
    '    Objeto_Entidad_Guia.NPLNMT = Me.gwdDatos.Item("NPLNMT", lint_Indice).Value
    '    Objeto_Entidad_Guia.CLCLOR = Me.gwdDatos.Item("CLCLOR", lint_Indice).Value
    '    Objeto_Entidad_Guia.CLCLDS = Me.gwdDatos.Item("CLCLDS", lint_Indice).Value
    '    Objeto_Entidad_Guia.TDIROR = Me.gwdDatos.Item("TDIROR", lint_Indice).Value
    '    Objeto_Entidad_Guia.TDIRDS = Me.gwdDatos.Item("TDIRDS", lint_Indice).Value
    '    Objeto_Entidad_Guia.NOPRCN = Me.gwdDatos.Item("NOPRCN", lint_Indice).Value
    '    Objeto_Entidad_Guia.QMRCMC = Me.gwdDatos.Item("QMRCMC", lint_Indice).Value
    '    Objeto_Entidad_Guia.PMRCMC = Me.gwdDatos.Item("PMRCMC", lint_Indice).Value
    '    Objeto_Entidad_Guia.CUNDMD = Me.gwdDatos.Item("CUNDMD", lint_Indice).Value
    '    Objeto_Entidad_Guia.QGLGSL = Me.gwdDatos.Item("QGLGSL", lint_Indice).Value
    '    Objeto_Entidad_Guia.QGLDSL = Me.gwdDatos.Item("QGLDSL", lint_Indice).Value
    '    Objeto_Entidad_Guia.NRHJCR = Me.gwdDatos.Item("NRHJCR", lint_Indice).Value
    '    Objeto_Entidad_Guia.CTRSPT = Me.gwdDatos.Item("CTRSPT", lint_Indice).Value
    '    Objeto_Entidad_Guia.NPLCTR = Me.gwdDatos.Item("NPLCTR", lint_Indice).Value
    '    Objeto_Entidad_Guia.NPLCAC = Me.gwdDatos.Item("NPLCAC", lint_Indice).Value
    '    Objeto_Entidad_Guia.CBRCNT = Me.gwdDatos.Item("CBRCNT", lint_Indice).Value
    '    Objeto_Entidad_Guia.TNMBRM = Me.gwdDatos.Item("TNMBRM", lint_Indice).Value
    '    Objeto_Entidad_Guia.TDRCRM = Me.gwdDatos.Item("TDRCRM", lint_Indice).Value
    '    Objeto_Entidad_Guia.TPDCIR = Me.gwdDatos.Item("TPDCIR", lint_Indice).Value
    '    Objeto_Entidad_Guia.NRUCRM = Me.gwdDatos.Item("NRUCRM", lint_Indice).Value
    '    Objeto_Entidad_Guia.TNMBCN = Me.gwdDatos.Item("TNMBCN", lint_Indice).Value
    '    Objeto_Entidad_Guia.TDRCNS = Me.gwdDatos.Item("TDRCNS", lint_Indice).Value
    '    Objeto_Entidad_Guia.TPDCIC = Me.gwdDatos.Item("TPDCIC", lint_Indice).Value
    '    Objeto_Entidad_Guia.NRUCCN = Me.gwdDatos.Item("NRUCCN", lint_Indice).Value
    '    Objeto_Entidad_Guia.SACRGO = Me.gwdDatos.Item("SACRGO", lint_Indice).Value
    '    Objeto_Entidad_Guia.CMNFLT = Me.gwdDatos.Item("CMNFLT", lint_Indice).Value
    '    Objeto_Entidad_Guia.FLGADC = Me.gwdDatos.Item("FLGADC", lint_Indice).Value
    '    Objeto_Entidad_Guia.SIDAVL = Me.gwdDatos.Item("SIDAVL", lint_Indice).Value
    '    Objeto_Entidad_Guia.QKMREC = Me.gwdDatos.Item("QKMREC", lint_Indice).Value
    '    Objeto_Entidad_Guia.ICSTRM = Me.gwdDatos.Item("ICSTRM", lint_Indice).Value
    '    Objeto_Entidad_Guia.QPSOBR = Me.gwdDatos.Item("QPSOBR", lint_Indice).Value
    '    Objeto_Entidad_Guia.QVLMOR = Me.gwdDatos.Item("QVLMOR", lint_Indice).Value
    '    Objeto_Entidad_Guia.SMRPLG = Me.gwdDatos.Item("SMRPLG", lint_Indice).Value
    '    Objeto_Entidad_Guia.SMRPRC = Me.gwdDatos.Item("SMRPRC", lint_Indice).Value
    '    Objeto_Entidad_Guia.IVLPRT = Me.gwdDatos.Item("IVLPRT", lint_Indice).Value
    '    Objeto_Entidad_Guia.CMNVLP = Me.gwdDatos.Item("CMNVLP", lint_Indice).Value
    '    Objeto_Entidad_Guia.CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
    '    Objeto_Entidad_Guia.CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
    '    Objeto_Entidad_Guia.CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value
    '    Objeto_Entidad_Guia.CUBORI = Me.gwdDatos.Item("CUBORI", lint_Indice).Value
    '    Objeto_Entidad_Guia.CUBDES = Me.gwdDatos.Item("CUBDES", lint_Indice).Value
    '    Objeto_Entidad_Guia.FEMVLH = Me.gwdDatos.Item("FEMVLH", lint_Indice).Value
    '    Objeto_Entidad_Guia.CBRCND = Me.gwdDatos.Item("CBRCND", lint_Indice).Value
    '    Objeto_Entidad_Guia.TOBS = Me.gwdDatos.Item("TOBS", lint_Indice).Value
    '    Objeto_Entidad_Guia.TRFRGU = Me.gwdDatos.Item("TRFRGU", lint_Indice).Value
    '    Objeto_Entidad_Guia.TCNFVH = Me.gwdDatos.Item("TCNFVH", lint_Indice).Value
    '    Objeto_Entidad_Guia.TCNFG1 = Me.gwdDatos.Item("TCNFG1", lint_Indice).Value
    '    Objeto_Entidad_Guia.TCNFG2 = Me.gwdDatos.Item("TCNFG2", lint_Indice).Value

    '    Objeto_Entidad_Guia.TCMTRT = Me.gwdDatos.Item("TCMTRT", lint_Indice).Value
    '    Objeto_Entidad_Guia.TCMLCO = Me.gwdDatos.Item("TCMLCO", lint_Indice).Value
    '    Objeto_Entidad_Guia.TCMLCD = Me.gwdDatos.Item("TCMLCD", lint_Indice).Value
    '    Objeto_Entidad_Guia.CMRCDR = Me.gwdDatos.Item("CMRCDR", lint_Indice).Value
    '    Objeto_Entidad_Guia.TCMRCD = Me.gwdDatos.Item("TCMRCD", lint_Indice).Value

    '    Objeto_Entidad_Guia.SESGRP = Me.gwdDatos.Item("SESGRP", lint_Indice).Value
    '    Objeto_Entidad_Guia.NORSRT = Me.gwdDatos.Item("NORSRT", lint_Indice).Value
    '    Objeto_Entidad_Guia.NOREMB = Me.gwdDatos.Item("NOREMB", lint_Indice).Value
    '    Objeto_Entidad_Guia.SSINVJ = Me.gwdDatos.Item("SSINVJ", lint_Indice).Value

    '    '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    '    Objeto_Entidad_Guia.PLANTA = Me.gwdDatos.Item("PLANTA", lint_Indice).Value
    '    '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    '    Objeto_Entidad_Guia.CCLNT = Me.gwdDatos.Item("CCLNT", lint_Indice).Value


    'End Sub

    Private Sub Cargar_Compania()

        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
       
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

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try

            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                cargarComboPlanta()
            End If

            Me.InicializarFormulario()
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS









        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


   

   

    Private Sub Limpiar_Controles()
        Me.gwdDatos.DataSource = Nothing
        Me.dtGRemCargGTransLiq.Rows.Clear()
    End Sub

    Private Sub Listar_Guias_Transportista()
        'Try
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PNCTRMNC", Me.cboTransportista.pCodigoRNS)
        objetoParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objetoParametro.Add("PSCDVSN", Me.cmbDivision.Division)

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.Planta, Double))
        objetoParametro.Add("PSCPLNDV", CType(DevuelvePlantaSeleccionadas(cboPlanta), String))
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        If Me.checkOperacion.Checked = True Then
            objetoParametro.Add("PNFECINI", 0)
            objetoParametro.Add("PNFECFIN", 0)
            objetoParametro.Add("PNNOPRCN", CType(txtNroOperacion.Text, Double))
            objetoParametro.Add("PNNORSRT", 0)
            objetoParametro.Add("ESTADO", 1)


            'adicionado -------------
            objetoParametro.Add("PNNMOPRP", 0)
            objetoParametro.Add("PNNMOPMM", 0)
            objetoParametro.Add("PNNGUITR", 0)
            '----------------
        Else
            If Me.cboTransportista.Enabled = True Then
                objetoParametro.Add("PNFECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
                objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
                objetoParametro.Add("PNNOPRCN", 0)
                objetoParametro.Add("PNNORSRT", IIf(IsNumeric(Me.txtOSTransporte.Text.Trim), Me.txtOSTransporte.Text, 0))
                objetoParametro.Add("ESTADO", 1)

                'adicionado -----
                objetoParametro.Add("PNNMOPRP", 0)
                objetoParametro.Add("PNNMOPMM", 0)
                objetoParametro.Add("PNNGUITR", 0)

                ' ---------
            End If
        End If
        If Me.checkReparto.Checked = True Then
            objetoParametro.Add("PNFECINI", 0)
            objetoParametro.Add("PNFECFIN", 0)
            objetoParametro.Add("PNNMOPRP", CType(Me.txtNroReparto.Text, Double))
            objetoParametro.Add("ESTADO", 2)

            'adicionado----
            objetoParametro.Add("PNNMOPMM", 0)
            objetoParametro.Add("PNNGUITR", 0)
            '-------------
        End If
        If Me.checkMultimodal.Checked = True Then
            objetoParametro.Add("PNFECINI", 0)
            objetoParametro.Add("PNFECFIN", 0)
            objetoParametro.Add("PNNMOPMM", CType(Me.txtNroMultimodal.Text, Double))
            objetoParametro.Add("ESTADO", 3)

            ' adicionado---------------

            objetoParametro.Add("PNNMOPRP", 0)
            objetoParametro.Add("PNNGUITR", 0)


            '--------------------
        End If

        objetoParametro.Add("PSFLGSTA", "")
        objetoParametro.Add("PSSESGRP", "L")
        objetoParametro.Add("PNRESAPR", 0)
        objetoParametro.Add("PNFENINI", 0)
        objetoParametro.Add("PNFENFIN", 0)

        'Me.gwdDatos.DataSource = Objeto_Logica.Listar_Guia_Transportista(objetoParametro)
        Me.gwdDatos.DataSource = Objeto_Logica.Listar_Guias_General(objetoParametro)


    End Sub

    Private Sub Listar_GRemCargadasGTranspLiq_Operacion()
        Dim oFiltro As New TD_GRemCargadasGTranspLiqPK
        Dim oGuiaTransportista As New GuiaTransportista_BLL
        Dim dwvrow As DataGridViewRow

        'LIMPIANDO EL dtGRemCargGTransLiq
        Me.dtGRemCargGTransLiq.Rows.Clear()

        'oFiltro.pNOPRCN_NroOperacion = Objeto_Entidad_Guia.NOPRCN
        'oFiltro.pNGUIRM_NroGuiaTransportista = Objeto_Entidad_Guia.NGUIRM
        'oFiltro.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania

        oFiltro.pNOPRCN_NroOperacion = gwdDatos.CurrentRow.Cells("NOPRCN").Value
        oFiltro.pNGUIRM_NroGuiaTransportista = gwdDatos.CurrentRow.Cells("NGUIRM").Value
        oFiltro.pCCMPN_Compania = gwdDatos.CurrentRow.Cells("CCMPN").Value


        Dim Fila As Int32 = 0
        'LLENANDO EL dtGRemCargGTransLiq
        For Each oEntidad As TD_Obj_GRemCargadasGTranspLiq In oGuiaTransportista.Listar_GRemCargadasGTranspLiquidacion(oFiltro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtGRemCargGTransLiq)
            dtGRemCargGTransLiq.Rows.Add(dwvrow)
            Fila = dtGRemCargGTransLiq.Rows.Count - 1

            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NOPRCN").Value = oEntidad.pNOPRCN_NroOperacion
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUIRM").Value = oEntidad.pNGUIRM_NroGuiaTransportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUITR").Value = oEntidad.pNGUITR_GuiaRemisionCargada
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_FGUITR").Value = oEntidad.pFGUITR_FechaGuiaRemision
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CTRSPT").Value = oEntidad.pCTRSPT_Transportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_TCMTRT").Value = oEntidad.pTCMTRT_RazSocialTransportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NPLVHT").Value = oEntidad.pNPLVHT_Tracto
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CBRCNT").Value = oEntidad.pCBRCNT_Brevete
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_TNMCMC").Value = oEntidad.pTNMCMC_NomApeChofer
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_QCNDTG").Value = oEntidad.pQCNDTG_CantServicioGuia
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CUNDSR").Value = oEntidad.pCUNDSR_Unidad
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NLQDCN").Value = oEntidad.pNLQDCN_NroLiquidacion
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_SGUIFC").Value = oEntidad.pSGUIFC_StatusFacturado

            If oEntidad.pCantLiq > 0 Then
                dtGRemCargGTransLiq.Rows(Fila).Cells("L_NLQDCN_TOT").Value = "Liquid."
            Else
                dtGRemCargGTransLiq.Rows(Fila).Cells("L_NLQDCN_TOT").Value = ""
            End If
        Next
    End Sub

    Private Sub Listar_GRemCargadasGTranspLiq_Reparto()
        Dim oFiltro As New TD_GRemCargadasGTranspLiqPK
        Dim oGuiaTransportista As New GuiaTransportista_BLL
        Dim dwvrow As DataGridViewRow

        oFiltro.pNOPRCN_NroOperacion = CType(IIf(Me.txtNroReparto.Text.Trim.Length = 0, 0, Me.txtNroReparto.Text), Int64)
        oFiltro.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        dtGRemCargGTransLiq.Rows.Clear()
        Dim Fila As Int32 = 0
        'LLENANDO EL dtGRemCargGTransLiq
        For Each oEntidad As TD_Obj_GRemCargadasGTranspLiq In oGuiaTransportista.Listar_GRemCargadasGTranspLiquidacion_Reparto(oFiltro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtGRemCargGTransLiq)
            Me.dtGRemCargGTransLiq.Rows.Add(dwvrow)
            Fila = dtGRemCargGTransLiq.Rows.Count - 1
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NOPRCN").Value = oEntidad.pNOPRCN_NroOperacion
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUIRM").Value = oEntidad.pNGUIRM_NroGuiaTransportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUITR").Value = oEntidad.pNGUITR_GuiaRemisionCargada
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_FGUITR").Value = oEntidad.pFGUITR_FechaGuiaRemision
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CTRSPT").Value = oEntidad.pCTRSPT_Transportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_TCMTRT").Value = oEntidad.pTCMTRT_RazSocialTransportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NPLVHT").Value = oEntidad.pNPLVHT_Tracto
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CBRCNT").Value = oEntidad.pCBRCNT_Brevete
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_TNMCMC").Value = oEntidad.pTNMCMC_NomApeChofer
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_QCNDTG").Value = oEntidad.pQCNDTG_CantServicioGuia
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CUNDSR").Value = oEntidad.pCUNDSR_Unidad
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NLQDCN").Value = oEntidad.pNLQDCN_NroLiquidacion
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_SGUIFC").Value = oEntidad.pSGUIFC_StatusFacturado

            If oEntidad.pCantLiq > 0 Then
                dtGRemCargGTransLiq.Rows(Fila).Cells("L_NLQDCN_TOT").Value = "Liquid."
            Else
                dtGRemCargGTransLiq.Rows(Fila).Cells("L_NLQDCN_TOT").Value = ""
            End If
        Next
    End Sub

    Private Sub Listar_GRemCargadasGTranspLiq_Multimodal()
        Dim oFiltro As New TD_GRemCargadasGTranspLiqPK
        Dim oGuiaTransportista As New GuiaTransportista_BLL
        Dim dwvrow As DataGridViewRow

        oFiltro.pNOPRCN_NroOperacion = CType(IIf(Me.txtNroMultimodal.Text.Trim.Length = 0, 0, Me.txtNroMultimodal.Text), Int64)
        oFiltro.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania

        'LLENANDO EL dtGRemCargGTransLiq
        Dim Fila As Int32 = 0
        For Each oEntidad As TD_Obj_GRemCargadasGTranspLiq In oGuiaTransportista.Listar_GRemCargadasGTranspLiquidacion_Multimodal(oFiltro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtGRemCargGTransLiq)
            dtGRemCargGTransLiq.Rows.Add(dwvrow)
            Fila = dtGRemCargGTransLiq.Rows.Count - 1

            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NOPRCN").Value = oEntidad.pNOPRCN_NroOperacion
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUIRM").Value = oEntidad.pNGUIRM_NroGuiaTransportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUITR").Value = oEntidad.pNGUITR_GuiaRemisionCargada
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_FGUITR").Value = oEntidad.pFGUITR_FechaGuiaRemision
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CTRSPT").Value = oEntidad.pCTRSPT_Transportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_TCMTRT").Value = oEntidad.pTCMTRT_RazSocialTransportista
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NPLVHT").Value = oEntidad.pNPLVHT_Tracto
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CBRCNT").Value = oEntidad.pCBRCNT_Brevete
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_TNMCMC").Value = oEntidad.pTNMCMC_NomApeChofer
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_QCNDTG").Value = oEntidad.pQCNDTG_CantServicioGuia
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_CUNDSR").Value = oEntidad.pCUNDSR_Unidad
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NLQDCN").Value = oEntidad.pNLQDCN_NroLiquidacion
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_SGUIFC").Value = oEntidad.pSGUIFC_StatusFacturado

        Next
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


        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        ' If Me.cmbPlanta.Planta = 0 Then
        'lstr_validacion += "* PLANTA" & Chr(13)
        ' End If
        Dim CadPlanta As String
        CadPlanta = ""
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            CadPlanta += cboPlanta.CheckedItems(i).Value & ","
        Next
        If CadPlanta = "" Then
            lstr_validacion += "* PLANTA" & Chr(13)
        End If
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        'If Me.checkOperacion.Checked = False And Me.checkReparto.Checked = False Then
        '  If Not Me.cboTransportista.pRucTransportista.Trim.Equals("") Then
        '    If Me.dtpFechaInicio.Checked = False OrElse Me.dtpFechaFin.Checked = False Then
        '      lstr_validacion += "* FECHA" & Chr(13)
        '    End If
        '  End If
        'End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
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

     

        'If objEntidad.STSOP2 = "X" Then
        '    Me.lintEstadoOpcion = 1
        'End If

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
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

        If Me.checkOperacion.Checked = True OrElse Me.cboTransportista.Enabled = True Then
            objParametro.Add("PNNOPRCN", Me.gwdDatos.Item("NOPRCN", lint_Indice).Value)
            objParametro.Add("PSNGUIRM", Me.gwdDatos.Item("NGUIRM", lint_Indice).Value)
            objParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
            objParametro.Add("PSCDVSN", Me.cmbDivision.Division)


            '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            'objParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta)

            objParametro.Add("PNCPLNDV", Me.gwdDatos.Item("CPLNDV", lint_Indice).Value)
            '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


            objParametro.Add("PNFECHA", HelpClass.CDate_a_Numero8Digitos(Date.Today))
            objDt = HelpClass.GetDataSetNative(obj_Logica_Operacion.Listar_Consistencia_Liquidacion_x_Orden_Servicio(objParametro))
        ElseIf Me.checkReparto.Checked = True Then
            objParametro.Add("PNNMOPRP", Me.txtNroReparto.Text)
            objParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
            objParametro.Add("PSCDVSN", Me.cmbDivision.Division)


            '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            'objParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta)
            objParametro.Add("PNCPLNDV", Me.gwdDatos.Item("CPLNDV", lint_Indice).Value)
            '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS



            objParametro.Add("PNFECHA", HelpClass.CDate_a_Numero8Digitos(Date.Today))
            objDt = HelpClass.GetDataSetNative(obj_Logica_Reparto.Listar_Consistencia_Liquidacion_Servicio_Reparto(objParametro))
        ElseIf Me.checkMultimodal.Checked = True Then
            objParametro.Add("PNNMOPMM", Me.txtNroMultimodal.Text)
            objParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
            objParametro.Add("PSCDVSN", Me.cmbDivision.Division)

            '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            'objParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta)
            objParametro.Add("PNCPLNDV", Me.gwdDatos.Item("CPLNDV", lint_Indice).Value)
            '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS



            objParametro.Add("PNFECHA", HelpClass.CDate_a_Numero8Digitos(Date.Today))
            objDt = HelpClass.GetDataSetNative(obj_Logica_Multimodal.Listar_Consistencia_Liquidacion_Servicio_Multimodal(objParametro))
        End If

        objDt.TableName = "RZTR32"

        If objDt.Rows.Count = 0 Then
            HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
            Exit Sub
        End If
        objDs.Tables.Add(objDt.Copy)
        objetoRep.SetDataSource(objDs)
        If Me.checkReparto.Checked = True Then
            CType(objetoRep.ReportDefinition.ReportObjects("lblNroReparto"), TextObject).Text = Me.txtNroReparto.Text.Trim
        Else
            CType(objetoRep.ReportDefinition.ReportObjects("lblReparto"), TextObject).Text = ""
        End If
        CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cmbCompania.CCMPN_Descripcion
        CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cmbDivision.DivisionDescripcion

        '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cmbPlanta.DescripcionPlanta
        'CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.dtGRemCargGTransLiq.Item("L_PLANTA", 0).Value
        CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.gwdDatos.CurrentRow.Cells("PLANTA").Value
        '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        CType(objetoRep.ReportDefinition.ReportObjects("lblNroLiquidacion"), TextObject).Text = "N° " & Me.dtGRemCargGTransLiq.Item("L_NLQDCN", 0).Value
        objPrintForm.ShowForm(objetoRep, Me)

        'Catch : End Try

    End Sub

#End Region

    Private Sub InicializarFormulario()
        Me.cboTransportista.pClearAll()
        Dim oTransPK As TD_TransportistaPK = New TD_TransportistaPK(Me.cmbCompania.CCMPN_CodigoCompania, "", "")
        Me.cboTransportista.pCargar(oTransPK)
        Me.Limpiar_Controles()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.Validar_Datos_Filtro = True Then Exit Sub
            Me.txtNroReparto.Tag = 0
            Me.Limpiar_Controles()
            Me.Listar_Guias_Transportista()
            If Me.checkReparto.Checked = True Then
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.Listar_GRemCargadasGTranspLiq_Reparto()
                    Me.txtNroReparto.Tag = Me.txtNroReparto.Text
                End If
            ElseIf Me.checkMultimodal.Checked = True Then
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.Listar_GRemCargadasGTranspLiq_Multimodal()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bolBuscar Then
            InicializarFormulario()
        End If
    End Sub


    Private Sub dtGRemCargGTransLiq_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGRemCargGTransLiq.CellContentClick
        Try
            If dtGRemCargGTransLiq.RowCount <= 0 Then Exit Sub
            ' Verificaos que se haya dado clic en la columna de la Guía de Remisión
            Select Case dtGRemCargGTransLiq.Columns(e.ColumnIndex).Name
                Case "L_NGUITR"
                    'Dim Compania As String = Objeto_Entidad_Guia.CCMPN
                    'Dim Division As String = Objeto_Entidad_Guia.CDVSN

                    Dim Compania As String = Me.cmbCompania.CCMPN_CodigoCompania
                    Dim Division As String = Me.cmbDivision.Division
 

                    Dim Operacion As Decimal = Me.dtGRemCargGTransLiq.Item("L_NOPRCN", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                    Dim GuiaRem As Decimal = Me.dtGRemCargGTransLiq.Item("L_NGUITR", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                    Dim mSESGRP As String = Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
                    Dim mSGUIFC As String = Me.dtGRemCargGTransLiq.Item("L_SGUIFC", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value.ToString.Trim
                    Dim mSESTRG As String = ""

                    'adicionado
                    Dim logica As New GuiaTransportista_BLL()
                    Dim parametros As New Hashtable()
                    'Dim PStatusTarInt As String = ""
                    Dim PSStatusLiquidacion As String = ""
                    Dim CRGVTA As String = ""
                    'parametros.Add("IN_NOPRCN", dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value)
                    'parametros.Add("IN_GUIA_TRANS", dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUIRM").Value)
                    'parametros.Add("IN_CTRMNC", dtGRemCargGTransLiq.CurrentRow.Cells("L_CTRSPT").Value)
                    'parametros.Add("IN_GUIA_REM", dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value)
                    'Dim dt As DataTable = logica.Listar_Datos_Guia_Operacion(parametros)
                    'Dim CRGVTA As String = ""

                    'If dt.Rows.Count > 0 Then
                    '    PStatusTarInt = dt.Rows(0)("FLGGTI").ToString()
                    '    PSStatusLiquidacion = dt.Rows(0)("SESGRP").ToString()
                    '    CRGVTA = dt.Rows(0)("CRGVTA").ToString()

                    'End If
                    'PStatusTarInt = gwdDatos.CurrentRow.Cells("FLGGTI").Value.ToString().Trim
                    PSStatusLiquidacion = gwdDatos.CurrentRow.Cells("SESGRP").Value.ToString()
                    CRGVTA = gwdDatos.CurrentRow.Cells("CRGVTA").Value.ToString.Trim


                    'adicionado


                    mSESTRG = IIf(mSGUIFC.Trim.Equals(""), mSESGRP, mSGUIFC)
                    'Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
                    '        Compania, Division, Operacion, GuiaRem, mSESTRG, lintEstadoOpcion)

                    Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
                       Compania, Division, Operacion, GuiaRem, mSESTRG)

                    ' No validamos el resultado obtenido por la ventana
                    'fMostrarInfAdic.Proceso = 1
                    'JMC--------------------18/09/2014----
                    fMostrarInfAdic.frmInvocado = "L"
                    'fMostrarInfAdic.pEstadoAprobMargen = ""
                    fMostrarInfAdic.pEstado = ""
                    fMostrarInfAdic.frmInvocadoNombre = "POST_LIQ"
                    fMostrarInfAdic.pPostLiquidacion = "SI"


                    'adicionado---
                    'fMostrarInfAdic.PStatusTarInt = PStatusTarInt
                    fMostrarInfAdic.PSStatusLiquidacion_SESGRP = PSStatusLiquidacion
                    fMostrarInfAdic.pCRGVTA = CRGVTA

                    '---------------------


                    fMostrarInfAdic.ShowDialog()

                Case "L_CREFFW"
                    If Me.checkMultimodal.Checked = True OrElse Me.checkReparto.Checked = True Then Exit Sub
                    Dim fDlgConsistencia As frmConsistenciaBulto_x_Operacion = New frmConsistenciaBulto_x_Operacion
                    Dim lintIndice As Int32 = Me.gwdDatos.CurrentCellAddress.Y
                    With fDlgConsistencia
                        .txtTransportista.Text = Me.gwdDatos.Item("TCMTRT", lintIndice).Value
                        .txtPlaca.Text = Me.gwdDatos.Item("NPLCTR", lintIndice).Value
                        .txtAcoplado.Text = Me.gwdDatos.Item("NPLCAC", lintIndice).Value
                        .txtConductor.Text = Me.gwdDatos.Item("CBRCND", lintIndice).Value
                        .txtFecha.Text = Me.gwdDatos.Item("FGUIRM_S", lintIndice).Value
                        .txtGuiaTransporte.Text = Me.gwdDatos.Item("NGUIRM", lintIndice).Value
                        .txtOperacion.Text = Me.gwdDatos.Item("NOPRCN", lintIndice).Value
                        .txtOrigen.Text = Me.gwdDatos.Item("RUTA", lintIndice).Value
                        .CTRMNC = Me.dtGRemCargGTransLiq.Item("L_CTRSPT", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                        .NGUITR = Me.dtGRemCargGTransLiq.Item("L_NGUIRM", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                        .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                        .CDVSN = Me.cmbDivision.Division


                        '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                        '.CPLNDV = Me.cmbPlanta.Planta
                        .CPLNDV = Me.gwdDatos.Item("CPLNDV", lintIndice).Value
                        '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


                        .txtPlaca.Tag = Me.cmbCompania.CCMPN_Descripcion
                        .txtAcoplado.Tag = Me.cmbDivision.DivisionDescripcion

                        '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                        '.txtConductor.Tag = Me.cmbPlanta.DescripcionPlanta
                        '.txtConductor.Tag = Me.dtGRemCargGTransLiq.Item("L_PLANTA", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                        .txtConductor.Tag = Me.gwdDatos.CurrentRow.Cells("PLANTA").Value
                        '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    End With

                Case "L_NLQDCN_TOT"
                    Dim ofrmLiquidacionesConsultaProveedor As New frmLiquidacionesConsultaProveedor
                    ofrmLiquidacionesConsultaProveedor.pNOPRCN = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                    ofrmLiquidacionesConsultaProveedor.pNGUIRM = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                    ofrmLiquidacionesConsultaProveedor.pCCMPN = cmbCompania.CCMPN_CodigoCompania
                    ofrmLiquidacionesConsultaProveedor.pCDVSN = Me.cmbDivision.Division


                    '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                    ' ofrmLiquidacionesConsultaProveedor.pCPLNDV = Me.cmbPlanta.Planta
                    ofrmLiquidacionesConsultaProveedor.pCPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

                    '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                    ofrmLiquidacionesConsultaProveedor.ShowDialog()
            End Select
            'If dtGRemCargGTransLiq.Columns(e.ColumnIndex).Name = "L_NGUITR" Then Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmLiqFleteRegulizar_Post_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bolBuscar = False
            Me.gwdDatos.AutoGenerateColumns = False
            Me.Validar_Acceso_Opciones_Usuario()
            Me.Cargar_Compania()
            'Me.Listar_Guias_Transportista()
            'Me.Alinear_Columnas_Grilla()
            Dim oTransPK As TD_TransportistaPK = New TD_TransportistaPK(Me.cmbCompania.CCMPN_CodigoCompania, "", "")
            cboTransportista.pCargar(oTransPK)


            Me.cargarComboPlanta() '  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    '    Try
    '        If e.RowIndex < 0 Then Exit Sub
    '        If Me.checkOperacion.Checked = True OrElse Me.cboTransportista.Enabled = True OrElse Me.checkMultimodal.Checked = True Then
    '            Me.dtGRemCargGTransLiq.Rows.Clear()
    '            Me.Asignacion_Datos_Objeto(e.RowIndex)
    '            Me.Listar_GRemCargadasGTranspLiq_Operacion()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs)
    '    Try
    '        If Me.gwdDatos.Rows.Count > 0 Then Me.gwdDatos.CurrentRow.Selected = False
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Try
    '        If Me.gwdDatos.RowCount = 0 Then Exit Sub
    '        If Me.checkOperacion.Checked = True OrElse Me.cboTransportista.Enabled = True Then
    '            Select Case e.KeyCode
    '                Case Keys.Enter, Keys.Up, Keys.Down
    '                    Me.dtGRemCargGTransLiq.Rows.Clear()
    '                    Me.Asignacion_Datos_Objeto(Me.gwdDatos.CurrentCellAddress.Y)
    '                    Me.Listar_GRemCargadasGTranspLiq_Operacion()
    '            End Select
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub txtNroOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroOperacion.KeyPress, txtNroReparto.KeyPress, txtNroMultimodal.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtNroOperacion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroOperacion.KeyUp, txtNroReparto.KeyUp, txtNroMultimodal.KeyUp
        Try
            If sender.Text.Length > 0 And e.KeyCode = Keys.Enter Then
                Me.cboTransportista.pClear()
                Me.btnBuscar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub checkOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkOperacion.CheckedChanged
        Select Case checkOperacion.Checked
            Case True
                Me.checkReparto.Checked = False
                Me.checkMultimodal.Checked = False
                Me.txtNroReparto.Enabled = False
                Me.txtNroMultimodal.Enabled = False

                Me.dtpFechaInicio.Checked = False
                Me.dtpFechaFin.Checked = False
                Me.dtpFechaFin.Enabled = False
                Me.dtpFechaInicio.Enabled = False
                Me.txtNroOperacion.Enabled = True
                Me.cboTransportista.Enabled = False
                Me.txtOSTransporte.Enabled = False
                If Me.gwdDatos.RowCount > 0 Then
                    Me.Limpiar_Controles()
                End If
            Case False
                Me.dtpFechaInicio.Checked = True
                Me.dtpFechaFin.Checked = True
                Me.dtpFechaFin.Enabled = True
                Me.dtpFechaInicio.Enabled = True
                Me.txtNroOperacion.Enabled = False
                Me.cboTransportista.Enabled = True
                Me.txtOSTransporte.Enabled = True
                Me.Limpiar_Controles()
        End Select
    End Sub

    Private Sub checkReparto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkReparto.CheckedChanged
        Select Case checkReparto.Checked
            Case True
                Me.checkOperacion.Checked = False
                Me.checkMultimodal.Checked = False
                Me.txtNroOperacion.Enabled = False
                Me.txtNroReparto.Enabled = True
                Me.txtNroMultimodal.Enabled = False

                'Me.dtpFechaInicio.Checked = False
                Me.dtpFechaFin.Checked = False
                Me.dtpFechaFin.Enabled = False
                Me.dtpFechaInicio.Enabled = False
                Me.txtNroOperacion.Enabled = False
                Me.cboTransportista.Enabled = False
                Me.txtOSTransporte.Enabled = False
                Me.gwdDatos.Columns.Item("CHECK").Visible = True
                If Me.gwdDatos.RowCount > 0 Then
                    Me.Limpiar_Controles()
                End If
            Case False
                'Me.dtpFechaInicio.Checked = True
                'Me.dtpFechaFin.Checked = True
                Me.dtpFechaFin.Enabled = True
                Me.dtpFechaInicio.Enabled = True
                Me.txtNroReparto.Enabled = False
                Me.cboTransportista.Enabled = True
                Me.txtOSTransporte.Enabled = True
                Me.gwdDatos.Columns.Item("CHECK").Visible = False
                Me.Limpiar_Controles()
        End Select
    End Sub

    Private Sub checkMultimodal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkMultimodal.CheckedChanged
        Select Case checkMultimodal.Checked
            Case True
                Me.checkReparto.Checked = False
                Me.checkOperacion.Checked = False
                Me.txtNroReparto.Enabled = False
                Me.txtNroOperacion.Enabled = False
                Me.txtNroMultimodal.Enabled = True

                'Me.dtpFechaInicio.Checked = False
                Me.dtpFechaFin.Checked = False
                Me.dtpFechaFin.Enabled = False
                Me.dtpFechaInicio.Enabled = False
                Me.cboTransportista.Enabled = False
                Me.gwdDatos.Columns.Item("CHECK").Visible = False
                If Me.gwdDatos.RowCount > 0 Then
                    Me.Limpiar_Controles()
                End If
            Case False
                'Me.dtpFechaInicio.Checked = True
                'Me.dtpFechaFin.Checked = True
                Me.dtpFechaFin.Enabled = True
                Me.dtpFechaInicio.Enabled = True
                Me.txtNroMultimodal.Enabled = False
                Me.cboTransportista.Enabled = True
                Me.gwdDatos.Columns.Item("CHECK").Visible = False
                Me.Limpiar_Controles()
        End Select
    End Sub

    Private Sub gwdDatos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If Me.gwdDatos.Rows(e.RowIndex).Cells("NMVJCS").Value <> 0 Then
            e.CellStyle.BackColor = Color.Pink
        End If
    End Sub

    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        objHashTable.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objHashTable.Add("NRUCTR", Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value) 'Me.cboTransportista.pRucTransportista)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function

    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        cboPlanta.Text = ""

        If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral

            Dim OPlanta As New ClaseGeneral
            OPlanta.CPLNDV = 0
            OPlanta.TPLNTA = "TODOS"
            objLisEntidad2.Insert(0, OPlanta)

            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next
            cboPlanta.DisplayMember = "TPLNTA"
            cboPlanta.ValueMember = "CPLNDV"
            Me.cboPlanta.DataSource = objLisEntidad
            For i As Integer = 0 To cboPlanta.Items.Count - 1
                If cboPlanta.Items.Item(i).Value = "0" Then
                    cboPlanta.SetItemChecked(i, True)
                End If
            Next
            If cboPlanta.Text = "" Then
                cboPlanta.SetItemChecked(0, True)
            End If
        End If
    End Sub

    Private Function DevuelvePlantaSeleccionadas(MiCombo As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox) As String
        Dim strCodPlanta As String
        strCodPlanta = ""
        For i As Integer = 0 To MiCombo.CheckedItems.Count - 1
            strCodPlanta += MiCombo.CheckedItems(i).Value & ","
        Next
        Dim v As Integer
        v = InStr(1, strCodPlanta, "0,")
        If v = 1 Then
            strCodPlanta = "0,"

        End If
        If strCodPlanta = "0," Then
            strCodPlanta = ""
            For i As Integer = 1 To MiCombo.Items.Count - 1
                strCodPlanta += MiCombo.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return strCodPlanta

    End Function
    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

   
    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged
        Try
            Me.dtGRemCargGTransLiq.Rows.Clear()
            'Me.Asignacion_Datos_Objeto(Me.gwdDatos.CurrentCellAddress.Y)

            If Me.checkReparto.Checked = True Then
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.Listar_GRemCargadasGTranspLiq_Reparto()
                    Me.txtNroReparto.Tag = Me.txtNroReparto.Text
                End If
            ElseIf Me.checkMultimodal.Checked = True Then
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.Listar_GRemCargadasGTranspLiq_Multimodal()
                End If
            Else
                Me.Listar_GRemCargadasGTranspLiq_Operacion()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = gwdDatos.CurrentRow.Cells("CCMPN").Value
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZTR05", "04")
            ofrmCargaAdjuntos.pNroImagen = gwdDatos.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZTR05
            Dim CodCompania As String = gwdDatos.CurrentRow.Cells("CCMPN").Value
            Dim NroOperacion As String = gwdDatos.CurrentRow.Cells("NOPRCN").Value
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZTR05(CodCompania, NroOperacion)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                gwdDatos.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    gwdDatos.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    gwdDatos.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class

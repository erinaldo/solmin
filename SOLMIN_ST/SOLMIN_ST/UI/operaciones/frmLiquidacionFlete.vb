Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Threading


Public Class frmLiquidacionFlete
#Region " Atributos "
    Private bolBuscar As Boolean
   
    Private oHebraEnvioEmailReq As Thread




#End Region
#Region " Propiedades "

#End Region
#Region " Metodos y Funciones "

    Private Sub Cargar_Compania()

        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cmbCompania_SelectionChangeCommitted(cmbCompania.oBeCompania)
    End Sub








    Private Sub Limpiar_Controles()
        Me.gwdDatos.DataSource = Nothing
        Me.dtGRemCargGTransLiq.Rows.Clear()
    End Sub

    Private Sub Listar_Guias_Transportista()


        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable

        objetoParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objetoParametro.Add("PSCDVSN", Me.cmbDivision.Division)

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        objetoParametro.Add("PSCPLNDV", DevuelvePlantaSeleccionadas(cboPlanta))

        Dim cod_tipo_viaje As String = cbtipoviaje.SelectedValue
        Select Case cod_tipo_viaje
            Case "E"

                If Val(txtNroOperacion.Text) > 0 Then
                    objetoParametro.Add("PNNOPRCN", CType(txtNroOperacion.Text, Double))
                    objetoParametro.Add("PNFECINI", 0)
                    objetoParametro.Add("PNFECFIN", 0)
                    objetoParametro.Add("PNCTRMNC", 0)
                    objetoParametro.Add("PNNORSRT", 0)

                    objetoParametro.Add("PNNMOPRP", 0)
                    objetoParametro.Add("PNNMOPMM", 0)
                    objetoParametro.Add("PNNGUITR", 0)

                Else
                    objetoParametro.Add("PNNOPRCN", 0)
                    objetoParametro.Add("PNFECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
                    objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
                    objetoParametro.Add("PNCTRMNC", Me.cboTransportista.pCodigoRNS)
                    objetoParametro.Add("PNNORSRT", IIf(IsNumeric(Me.txtOSTransporte.Text.Trim), Me.txtOSTransporte.Text, 0))
                    objetoParametro.Add("PNNMOPRP", 0)
                    objetoParametro.Add("PNNMOPMM", 0)
                    objetoParametro.Add("PNNGUITR", 0)

                End If

            Case "R"

                objetoParametro.Add("PNNOPRCN", 0)
                objetoParametro.Add("PNFECINI", 0)
                objetoParametro.Add("PNFECFIN", 0)
                objetoParametro.Add("PNCTRMNC", 0)
                objetoParametro.Add("PNNORSRT", 0)
                objetoParametro.Add("PNNMOPRP", CType(txtNroOperacion.Text, Double))
                objetoParametro.Add("PNNMOPMM", 0)
                objetoParametro.Add("PNNGUITR", 0)


            Case "M"
                objetoParametro.Add("PNNOPRCN", 0)
                objetoParametro.Add("PNFECINI", 0)
                objetoParametro.Add("PNFECFIN", 0)
                objetoParametro.Add("PNCTRMNC", 0)
                objetoParametro.Add("PNNORSRT", 0)

                objetoParametro.Add("PNNMOPRP", 0)
                objetoParametro.Add("PNNMOPMM", CType(txtNroOperacion.Text, Double))
                objetoParametro.Add("PNNGUITR", 0)

        End Select

 

        objetoParametro.Add("PSFLGSTA", "")
        objetoParametro.Add("PSSESGRP", "")

        objetoParametro.Add("PNFENINI", 0)
        objetoParametro.Add("PNFENFIN", 0)

        objetoParametro.Add("PSFTRTSG", cboTipoSeg.SelectedValue)

        Me.gwdDatos.DataSource = Objeto_Logica.Listar_Guias_General(objetoParametro)
       



    End Sub

    Private Sub Listar_GRemCargadasGTranspLiq_Operacion()

        Dim oFiltro As New TD_GRemCargadasGTranspLiqPK
        Dim oGuiaTransportista As New GuiaTransportista_BLL
        Dim dwvrow As DataGridViewRow

        Me.dtGRemCargGTransLiq.Rows.Clear()

       

        oFiltro.pNOPRCN_NroOperacion = gwdDatos.CurrentRow.Cells("NOPRCN").Value
        oFiltro.pNGUIRM_NroGuiaTransportista = gwdDatos.CurrentRow.Cells("NGUIRM").Value
        oFiltro.pCCMPN_Compania = gwdDatos.CurrentRow.Cells("CCMPN").Value

 


        Dim Fila As Int32 = 0

        For Each oEntidad As TD_Obj_GRemCargadasGTranspLiq In oGuiaTransportista.Listar_GRemCargadasGTranspLiquidacion(oFiltro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtGRemCargGTransLiq)
            dtGRemCargGTransLiq.Rows.Add(dwvrow)
            Fila = dtGRemCargGTransLiq.Rows.Count - 1
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NOPRCN").Value = oEntidad.pNOPRCN_NroOperacion
            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUIRM").Value = oEntidad.pNGUIRM_NroGuiaTransportista

            dtGRemCargGTransLiq.Rows(Fila).Cells("L_NGUITR").Value = oEntidad.pNGUITR_GuiaRemisionCargada
            dtGRemCargGTransLiq.Rows(Fila).Cells("NGUIRS").Value = oEntidad.pNGUIRS_GuiaRemisionCargada

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
            dtGRemCargGTransLiq.Rows(Fila).Cells("NUMEROCO").Value = oEntidad.pNUMEROCO

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

        'oFiltro.pNOPRCN_NroOperacion = CType(IIf(Me.txtNroReparto.Text.Trim.Length = 0, 0, Me.txtNroReparto.Text), Int64)
        oFiltro.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        dtGRemCargGTransLiq.Rows.Clear()
        Dim Fila As Int32 = 0

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
            dtGRemCargGTransLiq.Rows(Fila).Cells("NUMEROCO").Value = oEntidad.pNUMEROCO




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

        'oFiltro.pNOPRCN_NroOperacion = CType(IIf(Me.txtNroMultimodal.Text.Trim.Length = 0, 0, Me.txtNroMultimodal.Text), Int64)
        oFiltro.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania


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
       
        Dim CadPlanta As String
        CadPlanta = ""
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            CadPlanta += cboPlanta.CheckedItems(i).Value & ","
        Next
        If CadPlanta = "" Then
            lstr_validacion += "* PLANTA" & Chr(13)
        End If
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    'Private Sub Validar_Acceso_Opciones_Usuario()
    '    Dim objParametro As New Hashtable
    '    Dim objLogica As New Acceso_Opciones_Usuario_BLL

    '    Dim dt As New DataTable


    '    objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    '    objParametro.Add("MMCUSR", MainModule.USUARIO)
    '    objParametro.Add("MMNPVB", Me.Name.Trim)
    '    'objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
    '    dt = objLogica.Listar_Autorizacion_Usuario(objParametro)

    '    'For Each item As DataRow In dt.Rows
    '    '    If item("COD_ACCION") = "V" Then
    '    '        obeAutorizacionLiq.Visualizar = "X"
    '    '    End If
    '    '    If item("COD_ACCION") = "M" Then
    '    '        obeAutorizacionLiq.Modificar = "X"
    '    '    End If
    '    '    If item("COD_ACCION") = "A" Then
    '    '        obeAutorizacionLiq.Adicionar = "X"
    '    '    End If
    '    '    If item("COD_ACCION") = "E" Then
    '    '        obeAutorizacionLiq.Eliminar = "X"
    '    '    End If
    '    '    If item("COD_ACCION") = "0011" Then
    '    '        obeAutorizacionLiq.ModifTarifaOS = "X"
    '    '    End If
    '    'Next


    'End Sub

    Private Sub Imprimir_Consistencia()
        Dim obj_Logica_Operacion As GuiaTransportista_BLL = New GuiaTransportista_BLL
        Dim obj_Logica_Reparto As GuiaTransportista_BLL = New GuiaTransportista_BLL
        Dim obj_Logica_Multimodal As GuiaTransportista_BLL = New GuiaTransportista_BLL
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim objDt As New DataTable
        Dim objetoRep As New rptConsistencia_Liquidacion
        Dim objParametro As New Hashtable

        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Dim tipo_viaje As String = cbtipoviaje.SelectedValue

        If tipo_viaje = "E" Then
            'If Me.checkOperacion.Checked = True OrElse Me.cboTransportista.Enabled = True Then
            objParametro.Add("PNNOPRCN", Me.gwdDatos.Item("NOPRCN", lint_Indice).Value)
            objParametro.Add("PSNGUIRM", Me.gwdDatos.Item("NGUIRM", lint_Indice).Value)
            objParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
            objParametro.Add("PSCDVSN", Me.cmbDivision.Division)
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            objParametro.Add("PNCPLNDV", Me.gwdDatos.Item("CPLNDV", lint_Indice).Value)
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            objParametro.Add("PNFECHA", HelpClass.CDate_a_Numero8Digitos(Date.Today))
            objDt = HelpClass.GetDataSetNative(obj_Logica_Operacion.Listar_Consistencia_Liquidacion_x_Orden_Servicio(objParametro))
            'ElseIf Me.checkReparto.Checked = True Then
        ElseIf tipo_viaje = "R" Then
            'objParametro.Add("PNNMOPRP", Me.txtNroReparto.Text)
            objParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
            objParametro.Add("PSCDVSN", Me.cmbDivision.Division)
            'objParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta)
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            objParametro.Add("PNCPLNDV", Me.gwdDatos.Item("CPLNDV", lint_Indice).Value)
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            objParametro.Add("PNFECHA", HelpClass.CDate_a_Numero8Digitos(Date.Today))
            objDt = HelpClass.GetDataSetNative(obj_Logica_Reparto.Listar_Consistencia_Liquidacion_Servicio_Reparto(objParametro))
            'ElseIf Me.checkMultimodal.Checked = True Then
        ElseIf tipo_viaje = "M" Then
            'objParametro.Add("PNNMOPMM", Me.txtNroMultimodal.Text)
            objParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
            objParametro.Add("PSCDVSN", Me.cmbDivision.Division)
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            'objParametro.Add("PNCPLNDV", Me.cmbPlanta.Planta)
            objParametro.Add("PNCPLNDV", Me.gwdDatos.Item("CPLNDV", lint_Indice).Value)
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

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

        'tipo_viaje
        If tipo_viaje = "R" Then
            'If Me.checkReparto.Checked = True Then
            'CType(objetoRep.ReportDefinition.ReportObjects("lblNroReparto"), TextObject).Text = Me.txtNroReparto.Text.Trim
        Else
            CType(objetoRep.ReportDefinition.ReportObjects("lblReparto"), TextObject).Text = ""
        End If
        CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cmbCompania.CCMPN_Descripcion
        CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cmbDivision.DivisionDescripcion
        'CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cmbPlanta.DescripcionPlanta
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cmbPlanta.DescripcionPlanta
        CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.gwdDatos.CurrentRow.Cells("PLANTA").Value
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        CType(objetoRep.ReportDefinition.ReportObjects("lblNroLiquidacion"), TextObject).Text = "N° " & Me.dtGRemCargGTransLiq.Item("L_NLQDCN", 0).Value
        objPrintForm.ShowForm(objetoRep, Me)



    End Sub

#End Region
#Region " Eventos "
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            If Me.Validar_Datos_Filtro = True Then Exit Sub
            'Me.txtNroReparto.Tag = 0
            Me.Limpiar_Controles()
            Me.Listar_Guias_Transportista()

           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCargarGuiaPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarGuiaPendiente.Click

        Try
            Dim tipo_viaje As String = cbtipoviaje.SelectedValue
            'If Me.checkReparto.Checked = False Then
            If tipo_viaje = "E" Then
                If gwdDatos.CurrentRow.Cells("FTRTSG").Value = "X" Then
                    MessageBox.Show("No puede cargar Guías a una operación seguimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If gwdDatos.CurrentRow.Cells("NMVJCS").Value <> 0 Then
                    MessageBox.Show("La Operacion : " & gwdDatos.CurrentRow.Cells("NOPRCN").Value & " es parte de un traslado consolidado", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
                Dim pSESGRP As String = gwdDatos.CurrentRow.Cells("SESGRP").Value ' gwdDatos.Item("SESGRP", lint_Indice).Value
                If pSESGRP <> "" Then
                    'If Objeto_Entidad_Guia.SESGRP <> "" Then
                    MessageBox.Show("Guías ya fueron cargadas.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                ' Variable de Trabajo
                Dim sGuiaPrincipal As String = ""
                Dim sGuiaPrincipalTxt As String = ""
                Dim dFechaGuiaPrincipal As Date
                Dim iCont As Integer = 0
                Dim sRelacionGuiasSeleccionada As String = ""
                ' Evaluamos lo seleccionado
                Dim pCTRMNC As Decimal = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                Dim pNGUIRM As Decimal = gwdDatos.CurrentRow.Cells("NGUIRM").Value
                Dim pCCMPN As String = gwdDatos.CurrentRow.Cells("CCMPN").Value
                Dim fMostrarGuiasRem As frmLiquidacionFlete_DlgMostrarGuiasRem = New frmLiquidacionFlete_DlgMostrarGuiasRem(pCTRMNC, pNGUIRM, pCCMPN)

                If fMostrarGuiasRem.ShowDialog = Windows.Forms.DialogResult.OK Then
                    sGuiaPrincipal = fMostrarGuiasRem.pGuiaRemPrincipal
                    sGuiaPrincipalTxt = fMostrarGuiasRem.pGuiaRemPrincipalTxt
                    dFechaGuiaPrincipal = fMostrarGuiasRem.pFechaGuiaPrincipal
                    sRelacionGuiasSeleccionada = fMostrarGuiasRem.pListaGuiasHijas
                  
                    ' Iniciamos la Carga del Objeto a Transferir a la Ventana
                    Dim oTemp As TD_Obj_InfGRemCargada = New TD_Obj_InfGRemCargada



                    Dim fDlgLiqFlete As frmLiquidacionFlete_DlgCargarGuia = New frmLiquidacionFlete_DlgCargarGuia()
                    fDlgLiqFlete.pAccion = frmLiquidacionFlete_DlgCargarGuia.Accion.Nuevo
                    fDlgLiqFlete.pCCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                    fDlgLiqFlete.pCDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
                    fDlgLiqFlete.pCTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                    fDlgLiqFlete.pNGUIAT = gwdDatos.CurrentRow.Cells("NGUIRM").Value
                    fDlgLiqFlete.sGuiaPrincipal = sGuiaPrincipal
                    fDlgLiqFlete.sGuiaPrincipalTxt = sGuiaPrincipalTxt
                    fDlgLiqFlete.sRelacionGuiasSeleccionada = sRelacionGuiasSeleccionada
                    fDlgLiqFlete.dFechaGuiaPrincipal = dFechaGuiaPrincipal
                    fDlgLiqFlete.PSStatusLiquidacion_SESGRP = ("" & gwdDatos.CurrentRow.Cells("SESGRP").Value).ToString.Trim
                    fDlgLiqFlete.btnServicios.Visible = False
                    'fDlgLiqFlete.pobeAutorizacionLiq = obeAutorizacionLiq
                    
                    If fDlgLiqFlete.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        
                        Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"
                        Me.gwdDatos.EndEdit()
                        Me.dtGRemCargGTransLiq.Rows.Clear()
                        Me.Listar_GRemCargadasGTranspLiq_Operacion()
                    End If
                End If
                'Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    

    Private Function fblnValidarAccionLiquidacionServicios() As Boolean
        Dim EsValido As Boolean = True
        Dim obrOrdenServicio As New SOLMIN_ST.NEGOCIO.Operaciones.OrdenServicio_BLL
        Dim obeOSValorizacion As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
        obeOSValorizacion.CCMPN = cmbCompania.CCMPN_CodigoCompania
        obeOSValorizacion.NOPRCN = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
        obeOSValorizacion.NGUITR = 0
        obeOSValorizacion.NGUIRM = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
        obeOSValorizacion.CULUSA = MainModule.USUARIO
        Dim dtOPValorizada As New DataTable
        Dim TieneAccesoAccionOPValorizada As Boolean = False
        dtOPValorizada = obrOrdenServicio.Listar_operacion_Valorizada(obeOSValorizacion)
        If dtOPValorizada.Rows.Count > 0 Then
            TieneAccesoAccionOPValorizada = obrOrdenServicio.TieneAccesoAccionOperacionesValorizadas(obeOSValorizacion)
            If TieneAccesoAccionOPValorizada = True Then
                If MessageBox.Show("La operación se encuentra valorizada con Nro " & dtOPValorizada.Rows(0)("NROVLR") & Chr(13) & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    EsValido = False
                Else
                    EsValido = True
                End If
            Else
                MessageBox.Show("La operación se encuentra valorizada con Nro " & dtOPValorizada.Rows(0)("NROVLR") & Chr(13) & " No tiene permiso para ejecutar la acción.")
                EsValido = False
            End If
        End If
        Return EsValido
    End Function


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim tipo_viaje As String = cbtipoviaje.SelectedValue
            If tipo_viaje = "E" Then
                'If Me.checkOperacion.Checked = True OrElse Me.cboTransportista.Enabled = True Then
                Dim pSESGRP As String = gwdDatos.CurrentRow.Cells("SESGRP").Value
                If pSESGRP = "L" Then
                    'If Objeto_Entidad_Guia.SESGRP = "L" Then
                    MessageBox.Show("Guías cargadas no pueden eliminarse.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If dtGRemCargGTransLiq.RowCount <= 0 Then
                    MessageBox.Show("No existe información de alguna Guía cargada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim oblGuiaTransporte As New GuiaTransportista_BLL
                Dim dtServicio As New DataTable

                Dim oFiltro As New TD_GRemServCargadasGTranspLiqPK
                oFiltro.pNOPRCN_NroOperacion = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                oFiltro.pNGUITR_NroGuiaRemision = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                oFiltro.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania


                dtServicio = oblGuiaTransporte.Listar_GRemServCargadasGTranspLiqVal(oFiltro)
                Dim ExitLiqAlguno As Boolean = False
                'Dim ExitTarifaInterna As Boolean
                '************************************************************************
                'si los servicios tienen alguna liquidacion no se puede eliminar la carga
                '************************************************************************
                For i As Integer = 0 To dtServicio.Rows.Count - 1
                    If dtServicio.Rows(i)("NLQDCN") <> 0 Then
                        ExitLiqAlguno = True
                        Exit For
                    End If
                Next
              
                Dim strMenssage As String = String.Empty

                If ExitLiqAlguno = True Then
                    strMenssage &= "Guía posee Liquidación(es)." & Environment.NewLine

                End If
             

                If Not String.IsNullOrEmpty(strMenssage) Then
                    MessageBox.Show(strMenssage, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                'Dim TipoAccion As String = "E_GUIAT_GR"
                '********************************************************
                If fblnValidarAccionLiquidacionServicios() = False Then Exit Sub


                If MessageBox.Show("¿Desea eliminar el registro?", "Mensaje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Dim oPK_RZTR06 As TD_GRemServCargadasGTranspLiqPK = New TD_GRemServCargadasGTranspLiqPK
                With oPK_RZTR06
                   

                    .pCTRMNC_CodigoTransportista = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                    .pNGUIRM_NroGuiaTransportista = gwdDatos.CurrentRow.Cells("NGUIRM").Value


                    .pNOPRCN_NroOperacion = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                    .pNGUITR_NroGuiaRemision = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                    .pMMCUSR_Usuario = MainModule.USUARIO
                    .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                    .pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania
                End With
                ' Instanceamos la clase de procesos
                Dim Objeto_Logica As New GuiaTransportista_BLL
                Dim sMensajeError As String = Objeto_Logica.Eliminar_GRemCargadasGTranspLiquidacion(oPK_RZTR06)
                Me.Limpiar_Controles()
                Me.Listar_Guias_Transportista()

                
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Dim HasEnvioEmail As New Hashtable

   

    Private Sub btnLiqGuiaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiqGuiaRemision.Click

        Try

            Dim oLiquidacionGT As New TD_Obj_LiquidacionGuiaRemision
            Dim oLiquidacionGT_Reparto As New Repartos
            Dim Objeto_Logica As New GuiaTransportista_BLL
            Dim sMensajeError As String = ""
            Dim sMensajeAlerta As String = ""
            Dim msgFinal As String = ""


            Dim tipo_viaje As String = cbtipoviaje.SelectedValue
            If tipo_viaje = "E" Then
                'If Me.checkOperacion.Checked = True OrElse Me.cboTransportista.Enabled = True OrElse Me.checkMultimodal.Checked = True Then

                If gwdDatos.CurrentRow.Cells("NMVJCS").Value <> 0 Then
                    MessageBox.Show("La Operación : " & gwdDatos.CurrentRow.Cells("NOPRCN").Value & " es parte de un traslado consolidado", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If dtGRemCargGTransLiq.RowCount <= 0 Then
                    MessageBox.Show("No existe información de alguna Guía cargada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim oblGuiaTransporte As New GuiaTransportista_BLL
                Dim dtServicio As New DataTable

                Dim oFiltro As New TD_GRemServCargadasGTranspLiqPK
                oFiltro.pNOPRCN_NroOperacion = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                oFiltro.pNGUITR_NroGuiaRemision = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                oFiltro.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania

                '***************************************************
                'si todas los servicios ya poseen su liquidacion

                dtServicio = oblGuiaTransporte.Listar_GRemServCargadasGTranspLiqVal(oFiltro)



                Dim ExisteLiqTodos As Boolean = True
                For i As Integer = 0 To dtServicio.Rows.Count - 1

                    If dtServicio.Rows(i)("NLQDCN") = 0 Then
                        ExisteLiqTodos = False
                        Exit For
                    End If
                Next

                If ExisteLiqTodos = True Then
                    MessageBox.Show("Guía ya posee liquidacion(es).", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                'JMC------------------------------------------------------------------
                Dim oLiqGTEnvioAprob As New TD_Obj_LiquidacionGuiaRemision
                Dim FLGSTA = gwdDatos.CurrentRow.Cells("FLGSTA").Value

                Select Case FLGSTA
                    Case "P"
                        MessageBox.Show("La Guía se encuentra Pendiente de aprobación", "Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "", "R"
                     


                        Dim AreaRespAprob As Decimal = 0
                        Dim NombreResp As String = ""

                        Dim dtServicioMargen As New DataTable

                        Dim oDs As New DataSet
                        Dim oDt0 As New DataTable
                        Dim oDt1 As New DataTable
                        Dim oDValorRef As New DataTable
                        Dim oAlerta As String = ""
                        Dim ValidarMargen As Boolean = False

                        With oLiquidacionGT
                            .pCCMPN_Compania = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value 'Cod Compañía
                            .pCTRSPT = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value 'Cod Transportista
                            .pNGUIRM_NroGuiaTransportista = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value 'Guía Transportista
                            .pNOPRCN_NroOperacion = Me.gwdDatos.CurrentRow.Cells("NOPRCN").Value 'Número Operación seleccionada
                            .pTIPVIAJ = "E"
                        End With
                        oDs = Objeto_Logica.Validar_Margen_Operacion(oLiquidacionGT)
                        oDt0 = oDs.Tables(0)
                        oDt1 = oDs.Tables(1)
                        oDValorRef = oDs.Tables(2)

                        Dim msgalertaValorRef As String = ""
                        For Each item As DataRow In oDValorRef.Rows
                            If item("STATUS") = "A" Then
                                msgalertaValorRef = msgalertaValorRef & item("OBSRESULT") & Chr(13)
                            End If
                        Next
                        msgalertaValorRef = msgalertaValorRef.Trim

                        If msgalertaValorRef.Length > 0 Then
                            If MessageBox.Show(msgalertaValorRef & Chr(13) & "¿Desea Continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                                Exit Sub
                            End If
                        End If


                        If oDt0.Rows.Count <> 0 Then
                            'Armamos el mensaje
                            For Each dr As DataRow In oDt0.Rows
                                oAlerta = oAlerta & dr("OBSRESULT").ToString & vbNewLine
                            Next
                            oAlerta = oAlerta.Trim
                            'validamos status
                            Select Case oDt0.Rows.Item(0)("STATUS").ToString
                                Case "E"
                                    MessageBox.Show(oAlerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Exit Sub
                                Case "A"
                                    'Pregunta si Envia correo para aprobar
                                    If MessageBox.Show(oAlerta & Chr(13) & "Desea enviar para aprobación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        With oLiquidacionGT
                                            .pCCMPN_Compania = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value 'Cod Compañía
                                            .pCTRSPT = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value 'Cod Transportista
                                            .pNGUIRM_NroGuiaTransportista = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value 'Guía Transportista
                                            .pMRGPOR = oDt0.Rows.Item(0)("MRGPOR")
                                            .pTIPVIAJ = "E"
                                            .pNROVIAJ = Me.gwdDatos.CurrentRow.Cells("NOPRCN").Value
                                            .pNLBFLT = oDt0.Rows.Item(0)("NLBFLT")
                                        End With

                                        Objeto_Logica.Enviar_Aprobar_Operacion(oLiquidacionGT)
                                        'Enviar correo
                                        Dim dtMargen As New DataTable
                                        Dim msgVerificacion As String = ""
                                        dtMargen = oDt1
                                        HasEnvioEmail = New Hashtable
                                        
                                        HasEnvioEmail("APROBSUG") = oDt0.Rows.Item(0)("APROBSUG") 'Aprobador Sugerido
                                        HasEnvioEmail("MRGPOR") = oDt0.Rows.Item(0)("MRGPOR") '%Aprobador
                                        HasEnvioEmail("REFVIAJE") = ""
                                        Dim tipo_ref_viaje As String = cbtipoviaje.SelectedValue
                                        Select Case tipo_ref_viaje
                                            Case "E"
                                                HasEnvioEmail("REFVIAJE") = " NRO OPERACION - " & gwdDatos.CurrentRow.Cells("NOPRCN").Value
                                            Case "C"
                                                HasEnvioEmail("REFVIAJE") = " NRO CONSOLIDADO - "
                                            Case "R"
                                                HasEnvioEmail("REFVIAJE") = " NRO REPARTO - "
                                            Case "M"
                                        End Select

                                        HasEnvioEmail("DT_SERV") = dtMargen
                                        oHebraEnvioEmailReq = New Thread(AddressOf Enviar_Requerimiento_Aprobacion)
                                        oHebraEnvioEmailReq.Start()

                                       

                                        gwdDatos.CurrentRow.Cells("FLGSTA").Value = "P"
                                        gwdDatos.CurrentRow.Cells("FLGSTA_DESC").Value = "EN APROBACION"

                                        MessageBox.Show("Operación enviado para aprobación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        Exit Sub
                                    Else
                                        Exit Sub
                                    End If
                            End Select
                        End If



                End Select
                '------------------------------------------------------------------------

                '**********************************Validacion Liquidaciones x Proveedor****************************'
                Dim ofrmLiquidacionesXProveedorValida As New frmLiquidacionesXProveedorValida
                ofrmLiquidacionesXProveedorValida.pNOPRCN = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                ofrmLiquidacionesXProveedorValida.pNGUIRM = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                ofrmLiquidacionesXProveedorValida.pCCMPN = cmbCompania.CCMPN_CodigoCompania
                If ofrmLiquidacionesXProveedorValida.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If

                '*************************************************************************************************'


                oLiquidacionGT = New TD_Obj_LiquidacionGuiaRemision
                With oLiquidacionGT
                  
                    .pNOPRCN_NroOperacion = gwdDatos.CurrentRow.Cells("NOPRCN").Value
                    .pNGUIRM_NroGuiaTransportista = gwdDatos.CurrentRow.Cells("NGUIRM").Value

                    .pFTRMOP_FechaOperacion = Now
                    .pMMCUSR_Usuario = MainModule.USUARIO
                    .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                    .pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania
                    .pTipo = 1

                End With

                ' Instanceamos la clase de procesos
                Objeto_Logica = New GuiaTransportista_BLL
                sMensajeError = ""
                'Dim msgAlertaValorReferencial As String = ""
                ' Validar la Guia a Liquidar
                If Objeto_Logica.Validar_GuiaTransportista_ProvVarios(oLiquidacionGT, sMensajeError, sMensajeAlerta) Then

                    Dim msgErrorLiq As String = ""
                    If Objeto_Logica.Registrar_LiquidacionGuiaTransportistaProvVarios(oLiquidacionGT, msgErrorLiq) = 0 Then
                        oLiquidacionGT.pTipo = 2
                        If Objeto_Logica.Validar_GuiaTransportista_ProvVarios(oLiquidacionGT, sMensajeError, sMensajeAlerta) Then

                            ' Me.Actualizar_Operaciones_Servicios_Importes(oLiquidacionGT.pNOPRCN_NroOperacion, Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                            Me.gwdDatos.CurrentRow.Cells("SESGRP").Value = "L"
                            'Me.gwdDatos.CurrentRow.Cells("FLGGTI").Value = "G"
                            msgFinal = "Liquidación culminó satisfactoriamente. "
                            If sMensajeAlerta <> "" Then
                                msgFinal = "Liquidación con observaciones."
                                msgFinal = msgFinal & Chr(13) & sMensajeAlerta
                            End If
                            'Objeto_Logica.Procesar_Asiento_CO_Tarifa_Interna(oLiquidacionGT, msgTarifaInterna)
                            'If msgTarifaInterna <> "" Then
                            '    msgFinal = msgFinal & Chr(13) & msgTarifaInterna
                            'End If
                            Dim msgIcono As MessageBoxIcon
                            'If sMensajeAlerta <> "" Or msgTarifaInterna <> "" Then
                            If sMensajeAlerta <> "" Then
                                msgIcono = MessageBoxIcon.Warning
                            Else
                                msgIcono = MessageBoxIcon.Information
                            End If
                            msgFinal = msgFinal.Trim
                            MessageBox.Show(msgFinal, "Liquidación", MessageBoxButtons.OK, msgIcono)

                        Else

                            Dim msgTemp As String = sMensajeError.ToUpper
                            If msgTemp.Contains("CABECERA DEL PEDIDO TODAVÍA SON ERRÓNEOS") = True Then
                                sMensajeError = "Verificar homologación(No homologado o vencido)" & Chr(10) & sMensajeError
                            End If
                            MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If

                    Else
                        MessageBox.Show(msgErrorLiq, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else

                    MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Me.Listar_GRemCargadasGTranspLiq_Operacion()

                'ElseIf   Me.checkReparto.Checked = True Then
            ElseIf tipo_viaje = "R" Then

                If dtGRemCargGTransLiq.RowCount <= 0 Then
                    MessageBox.Show("No existe información de alguna Guía cargada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                '***************************************************
                'si todas los servicios ya poseen su liquidacion
                'no procede la liqudiacion
                Dim oblGuiaTransporte As New GuiaTransportista_BLL
                Dim dtServicio As New DataTable
                'dtServicio = oblGuiaTransporte.Listar_GRemServCargadasGTranspRepartoLiqVal(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division, Me.txtNroReparto.Tag)
                dtServicio = oblGuiaTransporte.Listar_GRemServCargadasGTranspRepartoLiqVal(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division, 0)

                Dim ExisteLiqTodos As Boolean = True
                For i As Integer = 0 To dtServicio.Rows.Count - 1
                    If dtServicio.Rows(i)("NLQDCN") = 0 Then
                        ExisteLiqTodos = False
                        Exit For
                    End If
                Next
                If ExisteLiqTodos = True Then
                    MessageBox.Show("Guía ya posee liquidacion(es).", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                'JMC------------------------------------------------------------------
                Dim oLiqGTEnvioAprob As New TD_Obj_LiquidacionGuiaRemision
                Dim FLGSTA = gwdDatos.CurrentRow.Cells("FLGSTA").Value

                Select Case FLGSTA
                    Case "P"
                        MessageBox.Show("La Guía se encuentra Pendiente de aprobación", "Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "", "R"
                        Dim AreaRespAprob As Decimal = 0
                        Dim NombreResp As String = ""
                        Dim dtServicioMargen As New DataTable
                        'Dim Rep As Decimal = Val("" & Me.txtNroReparto.Tag)
                        Dim Rep As Decimal = 0
                        'If Verificar_Existencia_MargenNegativo(dtServicioMargen, AreaRespAprob, NombreResp, Rep) = True Then
                        If Rep = True Then
                            Select Case (AreaRespAprob)
                                Case 0
                                    MessageBox.Show("Área sin margen configurado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Exit Sub
                                Case Is <> 0
                                    Dim msgAprob As String = ""
                                    msgAprob = "El margen se encuentra debajo de lo permitido."
                                    msgAprob = msgAprob & Chr(13) & "Requiere aprobación de " & NombreResp & Chr(13) & "Desea enviar para aprobación?"
                                    If MessageBox.Show(msgAprob, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                        Dim Fila As Integer = gwdDatos.CurrentRow.Index
                                        Dim NOPRCN As Decimal = gwdDatos.CurrentRow.Cells("NOPRCN").Value
                                        Dim PNCTRMNC As Decimal = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                                        Dim PNNGUIRM As Decimal = gwdDatos.CurrentRow.Cells("NGUIRM").Value
                                        Dim CCPMN As String = cmbCompania.CCMPN_CodigoCompania

                                        Dim obeAprobacionMargen As New beAprobacionMargen
                                        obeAprobacionMargen.PNNOPRCN = NOPRCN
                                        obeAprobacionMargen.PNCTRMNC = PNCTRMNC
                                        obeAprobacionMargen.PNNGUIRM = PNNGUIRM
                                        obeAprobacionMargen.PNRESAPR = AreaRespAprob
                                        obeAprobacionMargen.PSFLGSTA = "P"
                                        obeAprobacionMargen.PSTOBS = ""
                                        obeAprobacionMargen.PNNMOPRP = Rep
                                        obeAprobacionMargen.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                                        obeAprobacionMargen.PSCULUSA = MainModule.USUARIO
                                        Objeto_Logica.ACTUALIZAR_STATUS_SEGUIMIENTO_APROBACION(obeAprobacionMargen)

                                        HasEnvioEmail = New Hashtable
                                        HasEnvioEmail("NMOPRP") = Rep
                                        HasEnvioEmail("AREA_RESP") = NombreResp
                                        HasEnvioEmail("NOPRCN") = gwdDatos.CurrentRow.Cells("NOPRCN").Value
                                        HasEnvioEmail("NGUIRM") = gwdDatos.CurrentRow.Cells("NGUIRM").Value
                                        HasEnvioEmail("RUTA") = gwdDatos.CurrentRow.Cells("RUTA").Value
                                        HasEnvioEmail("NORSRT") = gwdDatos.CurrentRow.Cells("NORSRT").Value
                                        HasEnvioEmail("DT_SERV") = dtServicioMargen


                                        oHebraEnvioEmailReq = New Thread(AddressOf Enviar_Requerimiento_Aprobacion)
                                        oHebraEnvioEmailReq.Start()



                                        Call Me.Listar_Guias_Transportista()

                                        gwdDatos.FirstDisplayedScrollingRowIndex = Fila
                                        gwdDatos.CurrentCell = gwdDatos.Rows(Fila).Cells("NGUIRM")
                                        gwdDatos.Refresh()
                                        gwdDatos.Rows(Fila).Selected = True


                                        Exit Sub
                                    Else
                                        Exit Sub
                                    End If
                            End Select
                        End If
                End Select
                '------------------------------------------------------------------------



                Dim bolEstado As Boolean = False
                Objeto_Logica = New GuiaTransportista_BLL
                sMensajeError = ""
                oLiquidacionGT_Reparto = New Repartos


                With oLiquidacionGT_Reparto
                    '.NMOPRP = Me.txtNroReparto.Tag
                    .NMOPRP = 0
                    .FECREP = HelpClass.TodayNumeric
                    .CUSCRT = MainModule.USUARIO
                    .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                    .CDVSN = Me.cmbDivision.Division
                    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                    ' .CPLNDV = Me.cmbPlanta.Planta
                    .CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value  'CPLNDV
                    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                    .TIPO = 1

                End With


                Dim oFiltro As New TD_GRemServCargadasGTranspLiqPK
                oFiltro.pNOPRCN_NroOperacion = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                oFiltro.pNGUITR_NroGuiaRemision = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                oFiltro.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania

                '**********************************Validacion Liquidaciones x Proveedor****************************'
                Dim ofrmLiquidacionesXProveedorValida As New frmLiquidacionesXProveedorValida
                'ofrmLiquidacionesXProveedorValida.pNMOPRP = Me.txtNroReparto.Tag
                ofrmLiquidacionesXProveedorValida.pNMOPRP = 0
                ofrmLiquidacionesXProveedorValida.pCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                ofrmLiquidacionesXProveedorValida.pCDVSN = Me.cmbDivision.Division
                ofrmLiquidacionesXProveedorValida.pTipoValidacion = frmLiquidacionesXProveedorValida.Tipovalidacion.ViajeReparto
                If ofrmLiquidacionesXProveedorValida.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If
                '*************************************************************************************************'

                Dim msgAlertaValorReferencialReparto As String = ""

                If Objeto_Logica.Validar_GuiaTransportista_Reparto_ProVarios(oLiquidacionGT_Reparto, sMensajeError, sMensajeAlerta, msgAlertaValorReferencialReparto) Then

                    If msgAlertaValorReferencialReparto.Length > 0 Then
                        If MessageBox.Show(msgAlertaValorReferencialReparto & Chr(13) & "¿Desea Continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        End If
                    End If

                    If Objeto_Logica.Registrar_LiquidacionGuiaTransportista_RepartoFlete_Prov_Varios(oLiquidacionGT_Reparto) = 0 Then
                        oLiquidacionGT_Reparto.TIPO = 2
                        If Objeto_Logica.Validar_GuiaTransportista_Reparto_ProVarios(oLiquidacionGT_Reparto, sMensajeError, sMensajeAlerta, msgAlertaValorReferencialReparto) Then

                            For lintContador As Integer = 0 To Me.dtGRemCargGTransLiq.RowCount - 1
                                Me.gwdDatos.Item("SESGRP", lintContador).Value = "L"
                                'Me.gwdDatos.Item("FLGGTI", lintContador).Value = "G"
                                ' Me.Actualizar_Operaciones_Servicios_Importes(Me.dtGRemCargGTransLiq.Item("L_NOPRCN", lintContador).Value, Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                            Next

                            msgFinal = "Liquidación culminó satisfactoriamente. "
                            If sMensajeAlerta <> "" Then
                                msgFinal = "Liquidación con observaciones."
                                msgFinal = msgFinal & Chr(13) & sMensajeAlerta
                            End If

                            'Objeto_Logica.Procesar_Generacion_Reparto_Asiento_TarifaInterna(oLiquidacionGT_Reparto, msgTarifaInterna)

                            'If msgTarifaInterna <> "" Then
                            '    msgFinal = msgFinal & Chr(13) & msgTarifaInterna
                            'End If

                            Dim msgIcono As MessageBoxIcon
                            ' If sMensajeAlerta <> "" Or msgTarifaInterna <> "" Then
                            If sMensajeAlerta <> "" Then
                                msgIcono = MessageBoxIcon.Warning
                            Else
                                msgIcono = MessageBoxIcon.Information
                            End If
                            msgFinal = msgFinal.Trim
                            MessageBox.Show(msgFinal, "Liquidación", MessageBoxButtons.OK, msgIcono)

                        Else
                            MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Existe un Error al Liquidar Guía.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If


                Else

                    MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Listar_GRemCargadasGTranspLiq_Reparto()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If dtGRemCargGTransLiq.RowCount <= 0 Then Exit Sub
            ' Verificaos que se haya dado clic en la columna de la Guia de Remision
            Select Case dtGRemCargGTransLiq.Columns(e.ColumnIndex).Name
                'Case "L_NGUITR"
                Case "NGUIRS"

                    Dim fDlgLiqFlete As frmLiquidacionFlete_DlgCargarGuia = New frmLiquidacionFlete_DlgCargarGuia()
                    fDlgLiqFlete.pCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                    fDlgLiqFlete.pCDVSN = Me.cmbDivision.Division
                    fDlgLiqFlete.pNOPRCN = Me.dtGRemCargGTransLiq.Item("L_NOPRCN", e.RowIndex).Value 'Objeto_Entidad_Guia.NOPRCN
                    fDlgLiqFlete.pNGUIAREM = Me.dtGRemCargGTransLiq.Item("L_NGUITR", e.RowIndex).Value
                    fDlgLiqFlete.PSStatusLiquidacion_SESGRP = ("" & gwdDatos.CurrentRow.Cells("SESGRP").Value).ToString.Trim
                    fDlgLiqFlete.pAccion = frmLiquidacionFlete_DlgCargarGuia.Accion.Modificar
                     

                    '--------------------------------------------------------------------
                    If fDlgLiqFlete.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.Listar_GRemCargadasGTranspLiq_Operacion()

                    End If
                Case "L_CREFFW"
                    Dim tipo_viaje As String = cbtipoviaje.SelectedValue
                    If tipo_viaje = "E" Then
                        'If Me.checkMultimodal.Checked = True OrElse Me.checkReparto.Checked = True Then Exit Sub
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
                            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                            '.CPLNDV = Me.cmbPlanta.Planta
                            '.CPLNDV = Me.dtGRemCargGTransLiq.Item("L_CPLNDV", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value
                            .CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                            .txtPlaca.Tag = Me.cmbCompania.CCMPN_Descripcion
                            .txtAcoplado.Tag = Me.cmbDivision.DivisionDescripcion
                            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                         
                            .txtConductor.Tag = gwdDatos.CurrentRow.Cells("PLANTA").Value
                            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        End With
                    End If
                Case "L_NLQDCN_TOT"
                    Dim ofrmLiquidacionesConsultaProveedor As New frmLiquidacionesConsultaProveedor
                    ofrmLiquidacionesConsultaProveedor.pNOPRCN = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                    ofrmLiquidacionesConsultaProveedor.pNGUIRM = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                    ofrmLiquidacionesConsultaProveedor.pCCMPN = cmbCompania.CCMPN_CodigoCompania
                    ofrmLiquidacionesConsultaProveedor.pCDVSN = Me.cmbDivision.Division
                    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                    'ofrmLiquidacionesConsultaProveedor.pCPLNDV = dtGRemCargGTransLiq.CurrentRow.Cells("L_CPLNDV").Value
                    ofrmLiquidacionesConsultaProveedor.pCPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                    'ofrmLiquidacionesConsultaProveedor.pCPLNDV = Me.cmbPlanta.Planta
                    ofrmLiquidacionesConsultaProveedor.ShowDialog()
                    'Case "NUMEROCO"
                    '    Dim frm As New frmTarifaInterna()
                    '    frm.StartPosition = FormStartPosition.CenterParent
                    '    frm.NroOperacion = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value
                    '    frm.NroGuiaTransporte = dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUITR").Value
                    '    frm.Compania = cmbCompania.CCMPN_CodigoCompania
                    '    frm.BotonVisibleSAP = True
                    '    frm.ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmLiquidacionFlete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dtTipo As New DataTable
            dtTipo.Columns.Add("COD")
            dtTipo.Columns.Add("DESC")
            Dim dr As DataRow
            dr = dtTipo.NewRow
            dr("COD") = "E"
            dr("DESC") = "Exclusivo"
            dtTipo.Rows.Add(dr)

            tab_tipoviaje.TabPages.Remove(tabReparto)


            'dr = dtTipo.NewRow
            'dr("COD") = "R"
            'dr("DESC") = "Reparto"
            'dtTipo.Rows.Add(dr)

            cbtipoviaje.DataSource = dtTipo
            cbtipoviaje.DisplayMember = "DESC"
            cbtipoviaje.ValueMember = "COD"
            cbtipoviaje.SelectedValue = "E"


            gwdDatos.AutoGenerateColumns = False
            'Me.cargarComboPlanta() 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            bolBuscar = False
            'Me.Validar_Acceso_Opciones_Usuario()
            Me.Cargar_Compania()
            Dim oTransPK As TD_TransportistaPK = New TD_TransportistaPK(Me.cmbCompania.CCMPN_CodigoCompania, "", "")
            cboTransportista.pCargar(oTransPK)

            Dim dtb As New List(Of TipoDatoGeneral)
            Dim objTipoDatoGeneral As New TipoDatoGeneral_BLL
            dtb = objTipoDatoGeneral.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "TPOSSG")
            Dim TipoDatoGeneral = New TipoDatoGeneral
            TipoDatoGeneral.CODIGO_TIPO = "T"
            TipoDatoGeneral.DESC_TIPO = "TODOS"
            dtb.Add(TipoDatoGeneral)
            cboTipoSeg.DataSource = dtb
            cboTipoSeg.DisplayMember = "DESC_TIPO"
            cboTipoSeg.ValueMember = "CODIGO_TIPO"
            cboTipoSeg.SelectedValue = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


   

 

   

    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click

        Try
            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 OrElse lint_Indice < 0 Then Exit Sub
            Me.Imprimir_Consistencia()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

 

#End Region

    Private Sub btnVisualizarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarDocumento.Click

        Try
            'If Me.gwdDatos.RowCount = 0 And Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            ''============NUEVO =============
            'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos
            'Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

            'With ofrmAdjuntarDocumento
            '    .pTABLE_NAME = "RZTR96"
            '    .pUSER_NAME = USUARIO
            '    .PSCCMPN = cmbCompania.CCMPN_CodigoCompania
            '    .PSCDVSN = cmbDivision.Division
            '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            '    '.PNCPLNDV = cmbPlanta.Planta
            '    .PNCPLNDV = Me.gwdDatos.Item("CPLNDV", lint_indice).Value
            '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            '    .PNCCLNT = Me.gwdDatos.Item("CTRMNC", lint_indice).Value
            '    .pNGUIRM = Me.gwdDatos.Item("NGUIRM", lint_indice).Value
            '    .pNMRGIM = Me.gwdDatos.Item("NMRGIM", lint_indice).Value

            '    .ShowDialog()
            'End With

            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = gwdDatos.CurrentRow.Cells("CCMPN").Value
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZTR05", "03")
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

    Private Sub gwdDatos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles gwdDatos.CellFormatting
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

    Private Sub btnIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncidencias.Click
        Dim EstadLiquidado As String = gwdDatos.CurrentRow.Cells("SESGRP").Value
        If EstadLiquidado.Equals("L") Then
            MostrarIncidencias()
        End If
    End Sub


    Private Sub MostrarIncidencias()

        Dim objEntidad As New GuiaTransportista

        If dtGRemCargGTransLiq.RowCount > 0 Then
            objEntidad.TCMTRT = dtGRemCargGTransLiq.CurrentRow.Cells("L_TCMTRT").Value
            objEntidad.NOPRCN = dtGRemCargGTransLiq.CurrentRow.Cells("L_NOPRCN").Value

            Dim fRegistroIncidencias As frmRegistroIncidencias = New frmRegistroIncidencias()
            fRegistroIncidencias._CCMPN = cmbCompania.CCMPN_CodigoCompania
            fRegistroIncidencias._NRUCTR = gwdDatos.CurrentRow.Cells("NRUCTR").Value
            fRegistroIncidencias._NGUITR = Convert.ToDecimal(dtGRemCargGTransLiq.CurrentRow.Cells("L_NGUIRM").Value)
            fRegistroIncidencias.cargarIncidencia(objEntidad)
            fRegistroIncidencias.ShowDialog()
        End If
    End Sub

    


    Private Sub Enviar_Requerimiento_Aprobacion()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim oEntidad As New GuiaTransportista
            Dim DT_SERV As New DataTable

 
            oEntidad.APROBSUG = HasEnvioEmail("APROBSUG")
            oEntidad.MRGPOR = HasEnvioEmail("MRGPOR")
            oEntidad.REFVIAJE = HasEnvioEmail("REFVIAJE")
            DT_SERV = HasEnvioEmail("DT_SERV")


            Dim Envio As New EnvioEmailAprobacionMargen_BLL
            Envio.CULUSA = MainModule.USUARIO
            Envio.MailAccount = System.Configuration.ConfigurationManager.AppSettings("MailFrom")
            Envio.Mailpassword = System.Configuration.ConfigurationManager.AppSettings("MailFromClave")
            Envio.MailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCO")
            Envio.MailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCOClave")
            Envio.Mailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")

            If Envio.Enviar_Email_Requerimiento_Servicio_Notificacion(oEntidad, DT_SERV) = 1 Then
                'MessageBox.Show("Correo enviado", "Envio email", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        Try
            Select Case gwdDatos.Columns(e.ColumnIndex).Name
                Case "SEG_OP"
                    Dim ofrmSegMargen As New frmSegMargen
                    ofrmSegMargen.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN").Value
                    ofrmSegMargen.CCMPN = cmbCompania.CCMPN_CodigoCompania
                    ofrmSegMargen.ShowDialog()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        '
    End Sub

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
            cboPlanta.DataSource = objLisEntidad
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


    Private Function ValidarFiltroPlanta() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = True
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            lstr_validacion += cboPlanta.CheckedItems(i).Value & ","
        Next
        If lstr_validacion = "" Then
            lbool_existe_error = False
        End If
        If lbool_existe_error = False Then HelpClass.MsgBox("Seleccione alguna(s) Planta(s)" & Chr(13) & lstr_validacion, MessageBoxIcon.Information)
        Return lbool_existe_error
    End Function
    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    Private Function DevuelvePlantaSeleccionadas(ocboPlanta As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox) As String
        Dim strCodPlanta As String
        strCodPlanta = ""
        For i As Integer = 0 To ocboPlanta.CheckedItems.Count - 1
            strCodPlanta += ocboPlanta.CheckedItems(i).Value & ","
        Next
        Dim v As Integer
        v = InStr(1, strCodPlanta, "0,")
        If v = 1 Then
            strCodPlanta = "0,"

        End If
        If strCodPlanta = "0," Then
            strCodPlanta = ""
            For i As Integer = 1 To ocboPlanta.Items.Count - 1
                strCodPlanta += ocboPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return strCodPlanta

    End Function

    Private Sub cmbDivision_SelectionChangeCommitted(obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            Me.cargarComboPlanta()
            Me.InicializarFormulario()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()

            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
            End If

            cmbDivision_SelectionChangeCommitted(Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged
        Try

            Dim tipo_viaje As String = cbtipoviaje.SelectedValue
            If tipo_viaje = "E" Then
                Me.dtGRemCargGTransLiq.Rows.Clear()
                Me.Listar_GRemCargadasGTranspLiq_Operacion()
            End If
            If tipo_viaje = "R" Then
                'If Me.checkReparto.Checked = True Then
                Me.Listar_GRemCargadasGTranspLiq_Reparto()
                'Me.txtNroReparto.Tag = Me.txtNroReparto.Text
                'ElseIf Me.checkMultimodal.Checked = True Then
            ElseIf tipo_viaje = "M" Then
                Me.Listar_GRemCargadasGTranspLiq_Multimodal()
            End If

         
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNroOperacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroOperacion.KeyDown
        Try
            
            If e.KeyCode = Keys.Enter Then
                btnBuscar_Click(btnBuscar, Nothing)
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

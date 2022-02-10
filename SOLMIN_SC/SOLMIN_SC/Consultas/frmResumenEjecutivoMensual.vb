Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_SC.NEGOCIO
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class frmResumenEjecutivoMensual

    Dim oDtPlanta As New DataTable

    Private Sub Ocultar_Imagen()
        Me.pbxBuscar.Visible = False
        Me.pbxBuscar.Enabled = False
    End Sub

    Private Sub Muestra_Imagen()
        Application.DoEvents()
        Me.pbxBuscar.Enabled = True
        Me.pbxBuscar.Update()
        Application.DoEvents()
        Me.pbxBuscar.Visible = True
        Application.DoEvents()
    End Sub

    Private Sub MostrarMeses_x_Anio()

        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("key")
        odtMeses.Columns.Add("value")

        odtMeses.Rows.Add(New Object() {"01", "Enero"})
        odtMeses.Rows.Add(New Object() {"02", "Febrero"})
        odtMeses.Rows.Add(New Object() {"03", "Marzo"})
        odtMeses.Rows.Add(New Object() {"04", "Abril"})
        odtMeses.Rows.Add(New Object() {"05", "Mayo"})
        odtMeses.Rows.Add(New Object() {"06", "Junio"})
        odtMeses.Rows.Add(New Object() {"07", "Julio"})
        odtMeses.Rows.Add(New Object() {"08", "Agosto"})
        odtMeses.Rows.Add(New Object() {"09", "Setiembre"})
        odtMeses.Rows.Add(New Object() {"10", "Octubre"})
        odtMeses.Rows.Add(New Object() {"11", "Noviembre"})
        odtMeses.Rows.Add(New Object() {"12", "Diciembre"})

        dbMes.DataSource = odtMeses.Copy
        dbMes.ValueMember = "key"
        dbMes.DisplayMember = "value"
        dbMes.SelectedIndex = Date.Now.Month - 1

        dbMes_SC.DataSource = odtMeses.Copy
        dbMes_SC.ValueMember = "key"
        dbMes_SC.DisplayMember = "value"
        dbMes_SC.SelectedIndex = Date.Now.Month - 1

    End Sub

    'Private Sub pCargaInicial()
    '    UcCompania.Usuario = HelpUtil.UserName
    '    UcCompania.pActualizar()
    'End Sub

    Private Sub frmResumenEjecutivoMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pCargaInicial()
        UcCompania.Usuario = HelpUtil.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        ndAnio.Minimum = 0
        ndAnio.Maximum = Today.Year
        ndAnio.Value = Today.Year
        MostrarMeses_x_Anio()

    End Sub


    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Try
            If UcCliente.pCodigo = 0 Then Exit Sub
            Dim strNumeroSil_CI As Int32 = 0
            Dim strNumeroSil As Int32 = 0
            Dim strNumeroSA As Int32 = 0
            Dim strNumeroST As Int32 = 0
            Dim strNumeroCT As Int32 = 0
            Dim strTitulo As String = ""

            Dim intTipoReporte As beResumenEjecutivo.REPORTE
            Dim FECHAINI As DateTime
            Dim FECHAFIN As DateTime
            Dim FECHAINI_SC As DateTime
            Dim FECHAFIN_SC As DateTime
            'If Me.Lista_Tipo_Proceso.Equals("") Then
            '    MessageBox.Show("Sellecione una Planta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            If Me.gbFecha.Visible Then
                'Rango de Fechas
                FECHAINI = Me.dtFechaIni.Value
                FECHAFIN = Me.dtpFechaFin.Value
                FECHAINI_SC = Me.dtFechaIni_SC.Value
                FECHAFIN_SC = Me.dtpFechaFin_SC.Value
                intTipoReporte = beResumenEjecutivo.REPORTE.FECHA
                If FECHAINI.Year = Date.Now.Year AndAlso FECHAINI.Month > Date.Now.Month Then Exit Sub
                If FECHAFIN.Year = Date.Now.Year AndAlso FECHAFIN.Month > Date.Now.Month Then Exit Sub
                If FECHAINI_SC.Year = Date.Now.Year AndAlso FECHAINI_SC.Month > Date.Now.Month Then Exit Sub
                If FECHAFIN_SC.Year = Date.Now.Year AndAlso FECHAFIN_SC.Month > Date.Now.Month Then Exit Sub
            Else
                If Me.rbAnual.Checked Then
                    'reporte Anual
                    FECHAINI = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/01/01")
                    FECHAFIN = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/12/31")
                    FECHAINI = FECHAINI
                    FECHAFIN = FECHAFIN
                    If FECHAINI.Year > Date.Now.Year Then Exit Sub
                    intTipoReporte = beResumenEjecutivo.REPORTE.ANUAL
                Else
                    'reporte Mensual
                    FECHAINI = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/" + Me.dbMes.SelectedValue.ToString() + "/01")
                    FECHAINI_SC = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/" + Me.dbMes_SC.SelectedValue.ToString() + "/01")

                    'Obtiene la cantidad de dias del mes seleccionado
                    Dim DIASMES As Integer = DateTime.DaysInMonth(FECHAINI.Year, FECHAINI.Month)
                    Dim DIASMES_SC As Integer = DateTime.DaysInMonth(FECHAINI_SC.Year, FECHAINI_SC.Month)

                    FECHAFIN = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/" + Me.dbMes.SelectedValue.ToString() + "/" + DIASMES.ToString())
                    FECHAFIN_SC = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/" + Me.dbMes_SC.SelectedValue.ToString() + "/" + DIASMES_SC.ToString())
                    If FECHAFIN.Year = Date.Now.Year AndAlso FECHAFIN.Month > Date.Now.Month Then Exit Sub
                    If FECHAFIN_SC.Year = Date.Now.Year AndAlso FECHAFIN_SC.Month > Date.Now.Month Then Exit Sub
                    intTipoReporte = beResumenEjecutivo.REPORTE.MENSUAL
                End If
            End If

            Me.Muestra_Imagen()
            Dim ObjEntidad As New beResumenEjecutivo
            ObjEntidad.PSCCMPN = Me.UcCompania.CCMPN_CodigoCompania
            ObjEntidad.PSCPLNDV = Me.UcPLanta_Cmb011.Planta 'me.Lista_Tipo_Proceso
            ObjEntidad.PNCCLNT = Me.UcCliente.pCodigo
            ObjEntidad.PNFECINI = HelpClass.CDate_a_Numero8Digitos(FECHAINI)
            ObjEntidad.PNFECFIN = HelpClass.CDate_a_Numero8Digitos(FECHAFIN)
            ObjEntidad.PNFECINI_SC = HelpClass.CDate_a_Numero8Digitos(FECHAINI_SC)
            ObjEntidad.PNFECFIN_SC = HelpClass.CDate_a_Numero8Digitos(FECHAFIN_SC)
            ObjEntidad.RazonSocial = Me.UcCliente.pRazonSocial

            'Inicializa Plantas Reporte
            '''''''''''''''''
            ' para posibles plantas
            Dim orptIndicadores As New rptResumenEjecutivo_2
            Dim OdsReporte As DataSet = New clsResumenEjecutivo_BLL().Inicializa(Me.UcPLanta_Cmb011.Planta, Me.UcPLanta_Cmb011.DescripcionPlanta)
            '''''''''''''''''
            Dim odsRPT_SIL As DataSet = New clsResumenEjecutivo_BLL().ResumenSIL(ObjEntidad)
            Dim odsRPT As DataSet = New clsResumenEjecutivo_BLL().ResumenAlmacenes(ObjEntidad)
            Dim odsRPT_ST As DataSet = New clsResumenEjecutivo_BLL().ResumenTransportes(ObjEntidad)
            Dim odsRPT_CT As DataSet = New clsResumenEjecutivo_BLL().ResumenCuentaCorriente(ObjEntidad)

            If Not odsRPT_ST.Tables("dtST_MedioTransporte") Is Nothing AndAlso odsRPT_ST.Tables("dtST_MedioTransporte").Rows.Count > 0 Then
                OdsReporte.Tables.Add(odsRPT_ST.Tables("dtST_MedioTransporte").Copy)
            End If

            orptIndicadores.SetDataSource(OdsReporte)

            Select Case intTipoReporte
                Case beResumenEjecutivo.REPORTE.MENSUAL
                    strTitulo = dbMes.Text & " " & Me.ndAnio.Value.ToString()
                Case beResumenEjecutivo.REPORTE.ANUAL
                    strTitulo = Me.ndAnio.Value.ToString()
                Case Else
                    strTitulo = FECHAINI.ToShortDateString & " Al " & FECHAFIN.ToShortDateString
            End Select

            CType(orptIndicadores.ReportDefinition.ReportObjects("lblCliente"), TextObject).Text = Me.UcCliente.pRazonSocial & " ( " & Me.UcCliente.pCodigo & " ) "
            If Me.gbFecha.Visible Then
                CType(orptIndicadores.ReportDefinition.ReportObjects("lblTituloMes_Fecha"), TextObject).Text = strTitulo
            Else
                CType(orptIndicadores.ReportDefinition.ReportObjects("lblTituloMes"), TextObject).Text = strTitulo
            End If

            CType(orptIndicadores.ReportDefinition.ReportObjects("lbCabecera"), TextObject).Text = Me.UcCliente.pRazonSocial & " ( " & Me.UcCliente.pCodigo & " ) "
            CType(orptIndicadores.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.UcPLanta_Cmb011.DescripcionPlanta
            CType(orptIndicadores.ReportDefinition.ReportObjects("lblFecha"), TextObject).Text = strTitulo

            orptIndicadores.Subreports.Item("rptResumenSA_TipoMovimiento").SetDataSource(odsRPT)
            orptIndicadores.Subreports.Item("rptResumenSA_StockPermanencia").SetDataSource(odsRPT.Tables("dtSA_StockTiempo"))
            orptIndicadores.Subreports.Item("rptTiempoPermanenciaStock").SetDataSource(odsRPT.Tables("dtSA_StockTiempo"))
            orptIndicadores.Subreports.Item("rptPesoXMovimiento").SetDataSource(odsRPT)

            If Not odsRPT.Tables("dtSA_Titulo") Is Nothing AndAlso odsRPT.Tables("dtSA_Titulo").Rows.Count > 0 Then
                CType(orptIndicadores.Subreports.Item("rptResumenSA_StockPermanencia").ReportDefinition.ReportObjects("lblTextSA"), TextObject).Text = odsRPT.Tables("dtSA_Titulo").Rows(0)("DESCRIPCION").ToString
            End If

            If Not odsRPT.Tables("dtSA_Titulo") Is Nothing AndAlso odsRPT.Tables("dtSA_Titulo").Rows.Count > 1 Then
                strTitulo = ""
                Select Case intTipoReporte
                    Case beResumenEjecutivo.REPORTE.MENSUAL
                        strTitulo = """En el mes de " & dbMes.Text & " del " & Me.ndAnio.Value.ToString() & " " & _
                     odsRPT.Tables("dtSA_Titulo").Rows(1)("DESCRIPCION").ToString()
                    Case beResumenEjecutivo.REPORTE.ANUAL
                        strTitulo = """En el " & Me.ndAnio.Value.ToString() & " " & _
                        odsRPT.Tables("dtSA_Titulo").Rows(1)("DESCRIPCION").ToString()
                    Case Else
                        strTitulo = """Desde " & FECHAINI.ToShortDateString & " Al " & FECHAFIN.ToShortDateString & " " & _
                     odsRPT.Tables("dtSA_Titulo").Rows(1)("DESCRIPCION").ToString()
                End Select
                CType(orptIndicadores.Subreports.Item("rptPesoXMovimiento").ReportDefinition.ReportObjects("lblTextSA_Movimiento"), TextObject).Text = strTitulo
            End If


            orptIndicadores.Subreports.Item("rptResumenTransporte").SetDataSource(odsRPT_ST)
            orptIndicadores.Subreports.Item("rptUnidadesEmpleadas").SetDataSource(odsRPT_ST)
            orptIndicadores.Subreports.Item("rptResumenTransporte_TipoUnidades").SetDataSource(odsRPT_ST.Tables("dtST_RTipoUnidad"))
            orptIndicadores.Subreports.Item("rptResumenTransporte_Rutas").SetDataSource(odsRPT_ST.Tables("dtST_RRuta"))
            orptIndicadores.Subreports.Item("rptResumenPropietario").SetDataSource(odsRPT_ST)

            If Not odsRPT_ST.Tables("dtST_Titulo") Is Nothing AndAlso odsRPT_ST.Tables("dtST_Titulo").Rows.Count > 0 Then
                orptIndicadores.Subreports.Item("rptMensajeTransporte").SetDataSource(odsRPT_ST.Tables("dtST_Titulo"))
            End If

            If Not odsRPT_SIL.Tables("dtSIL_Titulo") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_Titulo").Rows.Count > 0 Then
                CType(orptIndicadores.Subreports.Item("rptResumenSIL_CostosTotales").ReportDefinition.ReportObjects("lblTextSIl2"), TextObject).Text = odsRPT_SIL.Tables("dtSIL_Titulo").Rows(0)("DESCRIPCION").ToString
                If odsRPT_SIL.Tables("dtSIL_Titulo").Rows.Count > 1 Then
                    CType(orptIndicadores.Subreports.Item("rptGraficoSIL_ContenedorRegimen").ReportDefinition.ReportObjects("lblTextSIL_Contenedor"), TextObject).Text = odsRPT_SIL.Tables("dtSIL_Titulo").Rows(1)("DESCRIPCION").ToString
                End If
            End If

            orptIndicadores.Subreports.Item("rptResumenSIL_CostosTotales").SetDataSource(odsRPT_SIL.Tables("dtSIL_ResumenCostos"))
            orptIndicadores.Subreports.Item("rptResumenSIL_CostosXRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_RCostosRegimen"))
            orptIndicadores.Subreports.Item("rptResumenSIL_EmbarqueXRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_REmbarque"))
            orptIndicadores.Subreports.Item("rptResumenSIL_TipoCanal").SetDataSource(odsRPT_SIL.Tables("dtSIL_RTipoCanal"))
            orptIndicadores.Subreports.Item("rptResumenSIL_TiempoPromedio").SetDataSource(odsRPT_SIL.Tables("dtSIL_RTiempoPromedio"))
            orptIndicadores.Subreports.Item("rptResumenSIL_TipoDespacho").SetDataSource(odsRPT_SIL.Tables("dtSIL_RTipoDespacho"))
            orptIndicadores.Subreports.Item("rptResumenSIL_ContenedorRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_RContenedorRegimen"))
            orptIndicadores.Subreports.Item("rptResumenSIL_ContendorLinea").SetDataSource(odsRPT_SIL.Tables("dtSIL_RContenedorLinea"))
            orptIndicadores.Subreports.Item("rptOrdenServicioSIL").SetDataSource(odsRPT_SIL)

            'Cargan Los Graficos
            'orptIndicadores.Subreports.Item("rptGraficoSIL_CostoTotal").SetDataSource(odsRPT_SIL)
            orptIndicadores.Subreports.Item("rptGraficoSIL_CostoRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_CostosXRegimen"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_EmbarqueRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_EmbarquesxMedio"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_TipoCanal").SetDataSource(odsRPT_SIL.Tables("dtSIL_EmbarquesXCanal"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_ContenedorRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_ContenedorXRegimen"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_ContenedorLinea").SetDataSource(odsRPT_SIL.Tables("dtSIL_ContenedorXLinea"))

            'Carga Internacional
            Dim odsRPT_SIL_CI As DataSet = New clsResumenEjecutivo_BLL().ResumenSIl_CargaInternacional(ObjEntidad)
            orptIndicadores.Subreports.Item("rptResumenSIL_CI_ProveedorOC").SetDataSource(odsRPT_SIL_CI.Tables("dtSIL_RProvedorOC"))
            orptIndicadores.Subreports.Item("rptResumen_CI_PaisOC").SetDataSource(odsRPT_SIL_CI.Tables("dtSIL_RPaisOC"))
            orptIndicadores.Subreports.Item("rptResumenSIL_CI_IncotermOC").SetDataSource(odsRPT_SIL_CI.Tables("dtSIL_RIncotermOC"))
            orptIndicadores.Subreports.Item("rptResumenSIL_CI_AgenteCargaOC").SetDataSource(odsRPT_SIL_CI)
            'orptIndicadores.Subreports.Item("rptGraficoSIL_CI_AgenteCarga").SetDataSource(odsRPT_SIL_CI.Tables("dtSIL_AgentesXOC"))
            'orptIndicadores.Subreports.Item("rptGraficoSIL_CI_PaisOC").SetDataSource(odsRPT_SIL_CI.Tables("dtSIL_RPaisOC"))
            'orptIndicadores.Subreports.Item("rptGraficoSIL_CI_ProveedorOC").SetDataSource(odsRPT_SIL_CI.Tables("vv"))


            If Not odsRPT_SIL_CI.Tables("dtSIL_Titulo") Is Nothing AndAlso odsRPT_SIL_CI.Tables("dtSIL_Titulo").Rows.Count > 0 Then
                CType(orptIndicadores.Subreports.Item("rptResumenSIL_CI_ProveedorOC").ReportDefinition.ReportObjects("txtSIL_CI_Proveedor"), TextObject).Text = odsRPT_SIL_CI.Tables("dtSIL_Titulo").Rows(0)("Descripcion").ToString
                If odsRPT_SIL_CI.Tables("dtSIL_Titulo").Rows.Count > 1 Then
                    CType(orptIndicadores.Subreports.Item("rptResumenSIL_CI_AgenteCargaOC").ReportDefinition.ReportObjects("txtSIL_CI_AgenteCarga"), TextObject).Text = odsRPT_SIL_CI.Tables("dtSIL_Titulo").Rows(1)("DESCRIPCION").ToString
                End If
            End If

            If Not odsRPT_SIL_CI.Tables("DtTotalOC") Is Nothing AndAlso odsRPT_SIL_CI.Tables("DtTotalOC").Rows.Count > 0 Then
                Dim strText As String = CType(orptIndicadores.Subreports.Item("rptResumenSIL_CI_ProveedorOC").ReportDefinition.ReportObjects("txtSIL_CI_TotalOC"), TextObject).Text
                CType(orptIndicadores.Subreports.Item("rptResumenSIL_CI_ProveedorOC").ReportDefinition.ReportObjects("txtSIL_CI_TotalOC"), TextObject).Text = strText + odsRPT_SIL_CI.Tables("DtTotalOC").Rows(0)("TotalOC").ToString
            End If

            'Cuenta Corriente

            orptIndicadores.Subreports.Item("rptResumenCuentaCorriente").SetDataSource(odsRPT_CT.Tables("dtCT_Resumen"))
            orptIndicadores.Subreports.Item("rptGraficoCT_Factura").SetDataSource(odsRPT_CT.Tables("dtCT_FACT_CRED"))

            'Parametros de Validadion Carga Internacional
            If Not odsRPT_SIL_CI.Tables("dtSIL_RProvedorOC") Is Nothing AndAlso odsRPT_SIL_CI.Tables("dtSIL_RProvedorOC").Rows.Count > 0 Then
                strNumeroSil_CI = 1
                orptIndicadores.SetParameterValue("EliminaSIL_CI_Proveedor", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_CI_Proveedor", True)
            End If

            If Not odsRPT_SIL_CI.Tables("dtSIL_RPaisOC") Is Nothing AndAlso odsRPT_SIL_CI.Tables("dtSIL_RPaisOC").Rows.Count > 0 Then
                strNumeroSil_CI = 1
                orptIndicadores.SetParameterValue("EliminaSIL_CI_Pais", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_CI_Pais", True)
            End If

            If Not odsRPT_SIL_CI.Tables("dtSIL_RIncotermOC") Is Nothing AndAlso odsRPT_SIL_CI.Tables("dtSIL_RIncotermOC").Rows.Count > 0 Then
                strNumeroSil_CI = 1
                orptIndicadores.SetParameterValue("EliminaSIL_CI_Incoterm", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_CI_Incoterm", True)
            End If

            If Not odsRPT_SIL_CI.Tables("dtSIL_RAgenteCargaOC") Is Nothing AndAlso odsRPT_SIL_CI.Tables("dtSIL_RAgenteCargaOC").Rows.Count > 0 Then
                strNumeroSil_CI = 1
                orptIndicadores.SetParameterValue("EliminaSIL_CI_AgenteCarga", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_CI_AgenteCarga", True)
            End If

            'Parametros de Validadion SIL

            If Not odsRPT_SIL.Tables("dtSIL_ResumenCostos") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_ResumenCostos").Rows.Count > 0 Then
                strNumeroSil = strNumeroSil_CI + 1
                orptIndicadores.SetParameterValue("EliminaSIL_CostosTotales", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_CostosTotales", True)
            End If

            If Not odsRPT_SIL.Tables("dtSIL_RCostosRegimen") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_RCostosRegimen").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaSIL_CostosRegimen", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_CostosRegimen", True)
            End If


            If Not odsRPT_SIL.Tables("dtSIL_REmbarque") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_REmbarque").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaSIL_EmbarqueRegimen", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_EmbarqueRegimen", True)
            End If

            If Not odsRPT_SIL.Tables("dtSIL_RTipoCanal") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_RTipoCanal").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaSIL_TipoCanal", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_TipoCanal", True)
            End If

            If Not odsRPT_SIL.Tables("dtSIL_RTiempoPromedio") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_RTiempoPromedio").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaSIL_TiempoPromedio", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_TiempoPromedio", True)
            End If

            If Not odsRPT_SIL.Tables("dtSIL_RTipoDespacho") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_RTipoDespacho").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaSIL_TipoDespacho", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_TipoDespacho", True)
            End If

            If Not odsRPT_SIL.Tables("dtSIL_RContenedorRegimen") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_RContenedorRegimen").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaSIL_ContenedorRegimen", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_ContenedorRegimen", True)
            End If

            If Not odsRPT_SIL.Tables("dtSIL_RContenedorLinea") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_RContenedorLinea").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaSIL_ContenedorLinea", False)
            Else
                orptIndicadores.SetParameterValue("EliminaSIL_ContenedorLinea", True)
            End If

            If Not odsRPT_SIL.Tables("dtSIL_OrdenServicio") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_OrdenServicio").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaOrdenServicio", False)
            Else
                orptIndicadores.SetParameterValue("EliminaOrdenServicio", True)
            End If

            'validacion de Los Graficos
            'If Not odsRPT_SIL.Tables("dtSIL_ContenedorXLinea") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_ContenedorXLinea").Rows.Count > 0 Then
            '    orptIndicadores.SetParameterValue("EliminaContLinea", False)
            'Else
            '    orptIndicadores.SetParameterValue("EliminaContLinea", True)
            'End If
            ''''''''''
            'Parametros de Validacón Almacenes
            If Not odsRPT.Tables("dtSA_Recepcion") Is Nothing AndAlso odsRPT.Tables("dtSA_Recepcion").Rows.Count > 0 Then
                strNumeroSA = strNumeroSil + 1
                orptIndicadores.SetParameterValue("EliminarSA", False)
            Else
                orptIndicadores.SetParameterValue("EliminarSA", True)
                strNumeroSA = strNumeroSil
            End If

            If Not odsRPT.Tables("dtSA_StockTiempo") Is Nothing AndAlso odsRPT.Tables("dtSA_StockTiempo").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminarStock", False)
            Else
                orptIndicadores.SetParameterValue("EliminarStock", True)
            End If

            'Parametros de Validación transportes

            If Not odsRPT_ST.Tables("dtST_TotalesTransporte") Is Nothing AndAlso odsRPT_ST.Tables("dtST_TotalesTransporte").Rows.Count > 0 Then
                strNumeroST = strNumeroSA + 1
                orptIndicadores.SetParameterValue("EliminarST", False)
            Else
                strNumeroST = strNumeroSA
                orptIndicadores.SetParameterValue("EliminarST", True)
            End If

            If Not odsRPT_ST.Tables("dtST_RRuta") Is Nothing AndAlso odsRPT_ST.Tables("dtST_RRuta").Rows.Count > 0 Then
                strNumeroST = strNumeroSA + 1
                orptIndicadores.SetParameterValue("EliminarST_Ruta", False)
            Else
                strNumeroST = strNumeroSA
                orptIndicadores.SetParameterValue("EliminarST_Ruta", True)
            End If


            If Not odsRPT_ST.Tables("dtST_RTipoUnidad") Is Nothing AndAlso odsRPT_ST.Tables("dtST_RTipoUnidad").Rows.Count > 0 Then
                strNumeroST = strNumeroSA + 1
                orptIndicadores.SetParameterValue("EliminarST_TipoUnidad", False)
            Else
                strNumeroST = strNumeroSA
                orptIndicadores.SetParameterValue("EliminarST_TipoUnidad", True)
            End If

            If Not odsRPT_ST.Tables("dtST_Propietario") Is Nothing AndAlso odsRPT_ST.Tables("dtST_Propietario").Rows.Count > 0 Then
                strNumeroST = strNumeroSA + 1
                orptIndicadores.SetParameterValue("EliminarST_Propietario", False)
            Else
                strNumeroST = strNumeroSA
                orptIndicadores.SetParameterValue("EliminarST_Propietario", True)
            End If

            'Cuenta COrriente
            If Not odsRPT_CT.Tables("dtCT_Resumen") Is Nothing AndAlso odsRPT_CT.Tables("dtCT_Resumen").Rows.Count > 0 Then
                strNumeroCT = strNumeroST + 1
                orptIndicadores.SetParameterValue("EliminarCT_Resumen", False)
            Else
                strNumeroCT = strNumeroST
                orptIndicadores.SetParameterValue("EliminarCT_Resumen", True)
            End If

            'Titulos de los Reportes
            CType(orptIndicadores.Subreports.Item("rptResumenSIL_CI_ProveedorOC").ReportDefinition.ReportObjects("lblTituloSIL_CI"), TextObject).Text = Numero(strNumeroSil_CI) & ". SEGUIMIENTO ORDEN DE COMPRA"
            CType(orptIndicadores.Subreports.Item("rptResumenSIL_CostosTotales").ReportDefinition.ReportObjects("lblTituloSIL"), TextObject).Text = Numero(strNumeroSil) & ". SEGUIMIENTO ADUANERO"
            CType(orptIndicadores.Subreports.Item("rptResumenSA_TipoMovimiento").ReportDefinition.ReportObjects("lblAlmacen"), TextObject).Text = Numero(strNumeroSA) & ". ALMACENES"
            CType(orptIndicadores.Subreports.Item("rptTituloTransporte").ReportDefinition.ReportObjects("lblTransporte"), TextObject).Text = Numero(strNumeroST) & ". TRANSPORTE"
            CType(orptIndicadores.Subreports.Item("rptResumenCuentaCorriente").ReportDefinition.ReportObjects("lblCuentaCorriente"), TextObject).Text = Numero(strNumeroCT) & ". CUENTA CORRIENTE"
            Me.ReportViewer.ReportSource = orptIndicadores
            Me.Ocultar_Imagen()
        Catch ex As Exception
            Me.Ocultar_Imagen()
            MessageBox.Show("Ocurrió un Error al Procesar el Reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Numero(ByVal n As Int32) As String
        Dim strResult As String = ""
        Select Case n
            Case 1
                strResult = "I"
            Case 2
                strResult = "II"
            Case 3
                strResult = "III"
            Case 4
                strResult = "IV"
            Case 5
                strResult = "V"
            Case 6
                strResult = "VI"
        End Select
        Return strResult
    End Function

    Private Sub rbfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfecha.CheckedChanged
        gbFecha.Visible = True
        GbMesAnio.Visible = True
    End Sub

    Private Sub rbMensual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMensual.CheckedChanged
        gbFecha.Visible = False
        GbMesAnio.Visible = True
        dbMes.Enabled = True
        dbMes_SC.Enabled = True
    End Sub

    Private Sub rbAnual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAnual.CheckedChanged
        gbFecha.Visible = False
        GbMesAnio.Visible = True
        dbMes.Enabled = False
        dbMes_SC.Enabled = False
    End Sub

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        Try

            Me.UcPLanta_Cmb011.Usuario = HelpUtil.UserName
            Me.UcPLanta_Cmb011.CodigoCompania = UcCompania.CCMPN_CodigoCompania
            Me.UcPLanta_Cmb011.CodigoDivision = ""
            Me.UcPLanta_Cmb011.PlantaDefault = 1
            Me.UcPLanta_Cmb011.pActualizar()

            'oDtPlanta = New clsResumenEjecutivo_BLL().Listar_PLANTAS_X_USUARIO(HelpUtil.UserName, UcCompania.CCMPN_CodigoCompania)
            'cmbProceso.ValueMember = "CPLNDV"
            'cmbProceso.DisplayMember = "TPLNTA"
            'cmbProceso.DataSource = odtPlanta
            'For i As Integer = 0 To cmbProceso.Items.Count - 1
            '    '  If cmbProceso.Items.Item(i).Value = "0" Then
            '    cmbProceso.SetItemChecked(i, True)
            '    '  End If
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Lista_Tipo_Proceso() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbProceso.CheckedItems.Count - 1
            For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                If (oDtPlanta.Rows(j).Item("CPLNDV") = cmbProceso.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtPlanta.Rows(j).Item("CPLNDV") & ","   'CCMPRN
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

End Class

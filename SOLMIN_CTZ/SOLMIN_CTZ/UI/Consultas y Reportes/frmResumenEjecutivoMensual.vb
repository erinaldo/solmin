Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Public Class frmResumenEjecutivoMensual

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

        dbMes.DataSource = odtMeses
        dbMes.ValueMember = "key"
        dbMes.DisplayMember = "value"
        dbMes.SelectedIndex = 0
    End Sub

    Private Sub pCargaInicial()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
    End Sub

    Private Sub frmResumenEjecutivoMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pCargaInicial()
        ndAnio.Minimum = 0
        ndAnio.Maximum = Today.Year
        ndAnio.Value = Today.Year
        MostrarMeses_x_Anio()
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Try
            If UcCliente.pCodigo = 0 Then Exit Sub
            Dim strNumeroSil As Int32 = 0
            Dim strNumeroSA As Int32 = 0
            Dim strNumeroST As Int32 = 0

            Dim ObjEntidad As New Filtro
            Dim FEC As DateTime = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/" + Me.dbMes.SelectedValue.ToString() + "/01")
            Dim NDS As Integer = DateTime.DaysInMonth(FEC.Year, FEC.Month)
            If FEC.Year > Date.Now.Year Then Exit Sub
            If FEC.Year = Date.Now.Year AndAlso FEC.Month > Date.Now.Month Then Exit Sub

            Me.Muestra_Imagen()
            ObjEntidad.Parametro1 = Me.UcCompania.CCMPN_CodigoCompania
            ObjEntidad.Parametro2 = Me.UcCliente.pCodigo
            ObjEntidad.Parametro3 = Me.ndAnio.Value.ToString() + "" + Me.dbMes.SelectedValue.ToString() + "" + NDS.ToString()
            Dim odsRPT As DataSet = New clsResumenEjecutivo_BLL().ResumenAlmacenes(ObjEntidad)
            Dim orptIndicadores As New rptResumenEjecutivo
            ' CType(orptIndicadores.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = ConfigurationWizard.UserName
            CType(orptIndicadores.ReportDefinition.ReportObjects("lblTituloMes"), TextObject).Text = dbMes.Text & " " & Me.ndAnio.Value.ToString()
            CType(orptIndicadores.ReportDefinition.ReportObjects("lblCliente"), TextObject).Text = Me.UcCliente.pRazonSocial & " ( " & Me.UcCliente.pCodigo & " ) "

            orptIndicadores.Subreports.Item("rptResumenSA_TipoMovimiento").SetDataSource(odsRPT)
            orptIndicadores.Subreports.Item("rptResumenSA_StockPermanencia").SetDataSource(odsRPT.Tables("dtSA_StockTiempo"))
            orptIndicadores.Subreports.Item("rptTiempoPermanenciaStock").SetDataSource(odsRPT.Tables("dtSA_StockTiempo"))
            orptIndicadores.Subreports.Item("rptPesoXMovimiento").SetDataSource(odsRPT)

            If Not odsRPT.Tables("dtSA_Titulo") Is Nothing AndAlso odsRPT.Tables("dtSA_Titulo").Rows.Count > 0 Then
                CType(orptIndicadores.ReportDefinition.ReportObjects("lblTextSA"), TextObject).Text = odsRPT.Tables("dtSA_Titulo").Rows(0)("DESCRIPCION").ToString
            End If

            If Not odsRPT.Tables("dtSA_Titulo") Is Nothing AndAlso odsRPT.Tables("dtSA_Titulo").Rows.Count > 1 Then
                CType(orptIndicadores.Subreports.Item("rptPesoXMovimiento").ReportDefinition.ReportObjects("lblTextSA_Movimiento"), TextObject).Text = _
                     """En el mes de " & dbMes.Text & " del " & Me.ndAnio.Value.ToString() & " " & _
                     odsRPT.Tables("dtSA_Titulo").Rows(1)("DESCRIPCION").ToString()
            End If


            ObjEntidad.Parametro3 = Convert.ToDecimal(Me.ndAnio.Value.ToString() & Me.dbMes.SelectedValue.ToString())
            Dim odsRPT_ST As DataSet = New clsResumenEjecutivo_BLL().ResumenTransportes(ObjEntidad)

            orptIndicadores.Subreports.Item("rptResumenTransporte").SetDataSource(odsRPT_ST)
            orptIndicadores.Subreports.Item("rptUnidadesEmpleadas").SetDataSource(odsRPT_ST)
            orptIndicadores.Subreports.Item("rptResumenPropietario").SetDataSource(odsRPT_ST)

            If Not odsRPT_ST.Tables("dtST_Titulo") Is Nothing AndAlso odsRPT_ST.Tables("dtST_Titulo").Rows.Count > 0 Then
                CType(orptIndicadores.Subreports.Item("rptResumenPropietario").ReportDefinition.ReportObjects("lblTextST"), TextObject).Text = odsRPT_ST.Tables("dtST_Titulo").Rows(0)("DESCRIPCION").ToString
            End If

            ObjEntidad.Parametro3 = Me.ndAnio.Value.ToString() + "" + Me.dbMes.SelectedValue.ToString() + "01"
            ObjEntidad.Parametro4 = Me.ndAnio.Value.ToString() + "" + Me.dbMes.SelectedValue.ToString() + "" + NDS.ToString()

            ' 
            ObjEntidad.Parametro5 = Me.UcCliente.pRazonSocial
            Dim odsRPT_SIL As DataSet = New clsResumenEjecutivo_BLL().ResumenSIL(ObjEntidad)

            If Not odsRPT_SIL.Tables("dtSIL_Titulo") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_Titulo").Rows.Count > 0 Then
                CType(orptIndicadores.Subreports.Item("rptGraficoSIL_CostoTotal").ReportDefinition.ReportObjects("lblTextSIl2"), TextObject).Text = odsRPT_SIL.Tables("dtSIL_Titulo").Rows(0)("DESCRIPCION").ToString
                If odsRPT_SIL.Tables("dtSIL_Titulo").Rows.Count > 1 Then
                    CType(orptIndicadores.Subreports.Item("rptResumenSIL_ContenedorRegimen").ReportDefinition.ReportObjects("lblTextSIL_Contenedor"), TextObject).Text = odsRPT_SIL.Tables("dtSIL_Titulo").Rows(1)("DESCRIPCION").ToString
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
            orptIndicadores.Subreports.Item("rptGraficoSIL_CostoTotal").SetDataSource(odsRPT_SIL)
            orptIndicadores.Subreports.Item("rptGraficoSIL_CostoRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_CostosXRegimen"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_EmbarqueRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_EmbarquesxMedio"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_TipoCanal").SetDataSource(odsRPT_SIL.Tables("dtSIL_EmbarquesXCanal"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_ContenedorRegimen").SetDataSource(odsRPT_SIL.Tables("dtSIL_ContenedorXRegimen"))
            orptIndicadores.Subreports.Item("rptGraficoSIL_ContenedorLinea").SetDataSource(odsRPT_SIL.Tables("dtSIL_ContenedorXLinea"))


            'Parametros de Validadion SIL
            If Not odsRPT_SIL.Tables("dtSIL_ResumenCostos") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_ResumenCostos").Rows.Count > 0 Then
                strNumeroSil = 1
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
            If Not odsRPT_SIL.Tables("dtSIL_ContenedorXLinea") Is Nothing AndAlso odsRPT_SIL.Tables("dtSIL_ContenedorXLinea").Rows.Count > 0 Then
                orptIndicadores.SetParameterValue("EliminaContLinea", False)
            Else
                orptIndicadores.SetParameterValue("EliminaContLinea", True)
            End If
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

            If Not odsRPT_ST.Tables(1) Is Nothing AndAlso odsRPT_ST.Tables(1).Rows.Count > 0 Then
                strNumeroST = strNumeroSA + 1
                orptIndicadores.SetParameterValue("EliminarST", False)
            Else
                strNumeroST = strNumeroSA
                orptIndicadores.SetParameterValue("EliminarST", True)
            End If

            'Titulos de los Reportes
            CType(orptIndicadores.Subreports.Item("rptResumenSIL_CostosTotales").ReportDefinition.ReportObjects("lblTituloSIL"), TextObject).Text = Numero(strNumeroSil) & ". SEGUIMIENTO ADUANERO"
            CType(orptIndicadores.Subreports.Item("rptResumenSA_TipoMovimiento").ReportDefinition.ReportObjects("lblAlmacen"), TextObject).Text = Numero(strNumeroSA) & ". ALMACENES"
            CType(orptIndicadores.Subreports.Item("rptResumenTransporte").ReportDefinition.ReportObjects("lblTransporte"), TextObject).Text = Numero(strNumeroST) & ". TRANSPORTE"

            Me.ReportViewer.ReportSource = orptIndicadores
            Me.Ocultar_Imagen()
        Catch ex As Exception
            Me.Ocultar_Imagen()
            HelpClass.MsgBox("Ocurrió un Error al Procesar el Reporte", MessageBoxIcon.Error)
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
        End Select
        Return strResult
    End Function
End Class

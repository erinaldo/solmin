'CSR-HUNDRED-feature/151116_Combustibles-INICIO

Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Threading
Imports System.Reflection
Imports System.ComponentModel
Imports Ransa.Utilitario

Public Class frmfptConsCombustible

#Region "Atributos"
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private objCombustible As New NEGOCIO.Combustible_BLL
    Private EntCombustible As New ENTIDADES.Combustible_BE

    'Private dtLiq As New DataTable
    Private gdtOp As New DataTable
    Private gdtvale As New DataTable
    Private gdtuREA As New DataTable
#End Region

#Region "Eventos"
    Private Sub frmConsCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            dtgLiquidacion.AutoGenerateColumns = False
            dtgVales.AutoGenerateColumns = False
            dtgUreaAsignado.AutoGenerateColumns = False
            gvLiqComb.AutoGenerateColumns = False
            dtpFecIni.Value = Now.AddMonths(-1)
            Me.Cargar_Compania()

            chk.Checked = True
            chk_CheckedChanged(chk, Nothing)
            cargarComboEstado()

           

            'ESTADO
            'G : GENERADO
            'P : PRE-CERRADO
            'C : CERRADO
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chk.CheckedChanged

        dtpFecFin.Enabled = chk.Checked
        dtpFecIni.Enabled = chk.Checked

    End Sub

    Private Sub cargarComboEstado()

        Dim oclsGeneral As New TipoDatoGeneral_BLL
        Dim oListbeGeneral As New List(Of TipoDatoGeneral)
        oListbeGeneral = oclsGeneral.Lista_Tipo_Dato_General(Me.cboCompania.SelectedValue.ToString, "STELQC")
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")
        For Each item As TipoDatoGeneral In oListbeGeneral
            oDr = oDt.NewRow
            oDr.Item("COD") = item.CODIGO_TIPO
            oDr.Item("DES") = item.DESC_TIPO
            oDt.Rows.Add(oDr)
        Next
        oDr = oDt.NewRow
        oDr.Item("COD") = "T"
        oDr.Item("DES") = "Todos"
        oDt.Rows.InsertAt(oDr, 0)


        With Me.cboEstado
            .DataSource = oDt
            .ValueMember = "COD"
            .DisplayMember = "DES"
        End With

        For i As Integer = 0 To cboEstado.Items.Count - 1
            If cboestado.Items(i).Value = "G" Then
                cboestado.SetItemChecked(i, True)
            End If
        Next


    End Sub


    Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If bolBuscar Then
                Me.Cargar_Division()
            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   

    Private odsExportar As New DataSet
    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Try
          
            ListarInfoConsolidado()
        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

 



    End Sub


    Private Sub ListarInfoConsolidado()

        Dim lis_estado As String = ""
        If chk.Checked = False Then
            If txtVehiculo.Text.Trim = "" And Val(txtLiquidacion.Text.Trim) = 0 Then
                MessageBox.Show("Ingrese vehículo o Nro Liquidación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            lis_estado = "T"
        Else
            lis_estado = DevuelveEstadoSeleccionadas()
        End If

        Dim obj_LogicaCombustible As New Combustible_BLL
        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
        Dim objParametro As New Hashtable
        objParametro.Add("NLQCMB", Val(txtLiquidacion.Text.Trim))
        objParametro.Add("CCMPN", Me.cboCompania.SelectedValue.ToString)
        objParametro.Add("CDVSN", Me.cboDivision.SelectedValue.ToString)
        objParametro.Add("FECINI", HelpClass.CtypeDate(Me.dtpFecIni.Value))
        objParametro.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFecFin.Value))
        objParametro.Add("NPLCUN", Me.txtVehiculo.Text.Trim)
        objParametro.Add("SESTRG", lis_estado)

        Dim ds As New DataSet
        Dim dtVales As New DataTable
        Dim dtListaLiq As New DataTable
        ds = obj_LogicaLiquidacion.Listar_Reporte_Consolidado_Asig_Liquidacion(objParametro)

        dtListaLiq = ds.Tables(0)
        gdtOp = ds.Tables(1)
        gdtvale = ds.Tables(2)
        gdtuREA = ds.Tables(3)

       

        dtVales = gdtvale.Copy
        Dim FilasItem0 As Int32 = dtVales.Rows.Count - 1
        For index = FilasItem0 To 0 Step -1
            If dtVales.Rows(index)("NRITEM") = 0 Then
                dtVales.Rows.RemoveAt(index)
            End If
        Next
        gvLiqComb.DataSource = dtListaLiq
        dtgVales.DataSource = dtVales
        dtgLiquidacion.DataSource = gdtOp
        dtgUreaAsignado.DataSource = gdtuREA
    End Sub


     

  

    Private Function DevuelveEstadoSeleccionadas() As String
        Dim strCodigo As String
        strCodigo = ""
        For i As Integer = 0 To cboEstado.CheckedItems.Count - 1
            If cboEstado.CheckedItems(i).Value = "T" Then
                strCodigo = "T"
                Exit For
            Else
                strCodigo &= cboEstado.CheckedItems(i).Value & ","
            End If
        Next
        If strCodigo <> "T" Then
            strCodigo = strCodigo.Trim.Substring(0, strCodigo.Trim.Length - 1)
        End If

        Return strCodigo

    End Function


    Private Sub ExportarExcel()


 

        Dim dtExport As New DataTable
        Dim dsExport As New DataSet

        dtExport = odsExportar.Tables(1)
        dtExport.TableName = "Liquidacion_Vales"

        dsExport.Tables.Add(dtExport.Copy)
        dtExport = odsExportar.Tables(2)

        dtExport.TableName = "Liquidacion_Operacion"
        dsExport.Tables.Add(dtExport.Copy)



        Dim ohstFiltro As New Hashtable
        Dim olstr_Table01 As New List(Of String)
        Dim olstr_Table02 As New List(Of String)

        olstr_Table01.Add("Liquidación - Vales :\n")
        olstr_Table02.Add("Liquidación - Operaciones :\n")
      

        ohstFiltro.Add(0, olstr_Table01)
        ohstFiltro.Add(1, olstr_Table02)

        Ransa.Utilitario.HelpClass.ExportExcel_Formato02(dsExport, "REPORTE DE LIQUIDACIONES", ohstFiltro)
 

    End Sub




    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            ExportarExcel()
          

        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

#End Region

#Region "Métodos y Funciones"

    

    

   

    
    Private Sub Cargar_Division()
        bolBuscar = False
        objDivision.Crea_Lista()
        Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
        Me.cboDivision.ValueMember = "CDVSN"
        Me.cboDivision.DisplayMember = "TCMPDV"
        If Me.cboCompania.SelectedValue = "EZ" Then
            Me.cboDivision.SelectedValue = "T"
        End If
        bolBuscar = True
        If Me.cboDivision.SelectedIndex = -1 Then
            Me.cboDivision.SelectedIndex = 0
        End If

    End Sub

    Private Sub Cargar_Compania()
        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        Me.cboCompania.DataSource = objCompaniaBLL.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        cboCompania.SelectedValue = "EZ"
        bolBuscar = True
        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cboCompania_SelectedIndexChanged(Nothing, Nothing)
    End Sub

#End Region

    Private Sub ChkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtpFecIni.Enabled = chk.Checked
        dtpFecFin.Enabled = chk.Checked
    End Sub

    

    Private Sub btExportarGeneral_Click(sender As Object, e As EventArgs) Handles btExportarGeneral.Click
        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
      
        'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        'If tbConsulta.SelectedTab.Name = "tbVale" Then

        Dim tabSel As String = tbConsulta.SelectedTab.Name



        Select Case tabSel
            Case "tbVale"
                loEncabezados = New Generic.List(Of Encabezados)
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Vales"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Vales"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Vales asignados"))

                objDt = CType(Me.dtgVales.DataSource, DataTable).Copy
                ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dtgVales, objDt))

                ODs.Tables(0).TableName = "Vales"
                For Each dc As DataColumn In ODs.Tables(0).Columns
                    Select Case dc.Caption
                        Case "NVLGRS", "NDCCTS"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                            'Case "PBRTOR", "PTRAOR", "PNETO", "IMPCO", "IMPCO_SOLES", "IMPPA", _
                            '     "IMPPA_SOLES", "GASTOS", "GASTOAVC", "QGLNCM", "COSTO", "IMPORTE_NETO", "MARGEN", "GASTOAVC"
                            '    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
                            'Case "TC_COBRAR", "TC_PAGAR"
                            '    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
                    End Select
                Next

            Case "tbOperacion"

                loEncabezados = New Generic.List(Of Encabezados)
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Operaciones"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Operaciones"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Operaciones asignados"))

                objDt = CType(Me.dtgLiquidacion.DataSource, DataTable).Copy
                ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dtgLiquidacion, objDt))

                For Each dc As DataColumn In ODs.Tables(0).Columns
                    Select Case dc.Caption
                        Case "NOPRCN"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    End Select
                Next
                ODs.Tables(0).TableName = "Operaciones"

            Case "tbUrea"

                loEncabezados = New Generic.List(Of Encabezados)
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Urea"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Urea"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Úrea asignada"))


                objDt = CType(Me.dtgUreaAsignado.DataSource, DataTable).Copy
                ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dtgUreaAsignado, objDt))

                ODs.Tables(0).TableName = "Úrea"



            Case "tbLiquidacion"

                loEncabezados = New Generic.List(Of Encabezados)
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Liquidaciones"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Liquidaciones"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Liquidaciones"))


                objDt = CType(Me.gvLiqComb.DataSource, DataTable).Copy
                ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(gvLiqComb, objDt))

                ODs.Tables(0).TableName = "Liquidaciones"

        End Select
       


     
        HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
       

    End Sub

    Private Sub btExportarF1_Click(sender As Object, e As EventArgs) Handles btExportarF1.Click
        Try
            Dim dtExport As New DataTable
            Dim NPOI_ST As New HelpClass_NPOI_SC

            dtExport.Columns.Add("NLQCMB").Caption = NPOI_ST.FormatDato("NRO LIQ.", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("FLQDCN").Caption = NPOI_ST.FormatDato("FECHA LIQ.", HelpClass_NPOI_ST.keyDatoFecha)
            dtExport.Columns.Add("ESTADO").Caption = NPOI_ST.FormatDato("ESTADO LIQ.", HelpClass_NPOI_ST.keyDatoTexto)

            dtExport.Columns.Add("NOPRCN").Caption = NPOI_ST.FormatDato("OPERACIÓN", HelpClass_NPOI_ST.keyDatoTexto)

            dtExport.Columns.Add("FCRCMB").Caption = NPOI_ST.FormatDato("FECHA ABASTECIMIENTO", HelpClass_NPOI_ST.keyDatoFecha)
            dtExport.Columns.Add("NVLGRS").Caption = NPOI_ST.FormatDato("VALE COMBUSTIBLE", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("DCMPPR").Caption = NPOI_ST.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("TLCLGR").Caption = NPOI_ST.FormatDato("CIUDAD ESTACIÓN", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("TGRFO").Caption = NPOI_ST.FormatDato("ESTACIÓN", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("NPLCUN").Caption = NPOI_ST.FormatDato("PLACA", HelpClass_NPOI_ST.keyDatoTexto)

            dtExport.Columns.Add("TMRCTR").Caption = NPOI_ST.FormatDato("MARCA", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("TIPO_TRACTO").Caption = NPOI_ST.FormatDato("TIPO", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("NPLCAC").Caption = NPOI_ST.FormatDato("PLACA REMOLQUE", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("TIPO_ACOPLADO").Caption = NPOI_ST.FormatDato("TIPO REMOLQUE", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("TIPO_CARGA").Caption = NPOI_ST.FormatDato("TIPO CARGA", HelpClass_NPOI_ST.keyDatoTexto) ' falta mapeo
            dtExport.Columns.Add("CONDUCTOR").Caption = NPOI_ST.FormatDato("CONDUCTOR", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("RUTA").Caption = NPOI_ST.FormatDato("RUTA", HelpClass_NPOI_ST.keyDatoTexto)

            dtExport.Columns.Add("TCMPCL").Caption = NPOI_ST.FormatDato("CLIENTE", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("NEGOCIO").Caption = NPOI_ST.FormatDato("NEGOCIO", HelpClass_NPOI_ST.keyDatoTexto)


            dtExport.Columns.Add("KMSINI").Caption = NPOI_ST.FormatDato("KILOMETRAJE INICIAL", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("KMSFIN").Caption = NPOI_ST.FormatDato("KILOMETRAJE FINAL", HelpClass_NPOI_ST.keyDatoNumero)

            dtExport.Columns.Add("KMSRCR").Caption = NPOI_ST.FormatDato("KILÓMETRO VIAJE CERRADO", HelpClass_NPOI_ST.keyDatoNumero)

            dtExport.Columns.Add("PESO_IDA").Caption = NPOI_ST.FormatDato("PESO IDA", HelpClass_NPOI_ST.keyDatoNumero)
            'dtExport.Columns.Add("PESO_RETORNO").Caption = NPOI_ST.FormatDato("PESO VUELTA", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("PESO_RETORNO").Caption = NPOI_ST.FormatDato("PESO VUELTA", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("PESO_INTERNO").Caption = NPOI_ST.FormatDato("PESO INTERNO", HelpClass_NPOI_ST.keyDatoNumero)

            dtExport.Columns.Add("TDSCMB").Caption = NPOI_ST.FormatDato("PRODUCTO", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("QGLNCM").Caption = NPOI_ST.FormatDato("GALONES PARCIAL", HelpClass_NPOI_ST.keyDatoNumero)

            dtExport.Columns.Add("QGLNCM_LIQ").Caption = NPOI_ST.FormatDato("GALONES VIAJE CERRADO", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("REND_VJE_LIQ").Caption = NPOI_ST.FormatDato("RENDIMIENTO VIAJE CERRADO", HelpClass_NPOI_ST.keyDatoNumero)

            dtExport.Columns.Add("QGUREA_LIQ").Caption = NPOI_ST.FormatDato("ÚREA GALONES", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("REND_UREA_LIQ").Caption = NPOI_ST.FormatDato("RENDIMIENTO ÚREA GALONES", HelpClass_NPOI_ST.keyDatoNumero)

            dtExport.Columns.Add("CSTGLN").Caption = NPOI_ST.FormatDato("PRECIO DIESEL", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("SUBT_COMB").Caption = NPOI_ST.FormatDato("COSTO TOTAL DIESEL", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("CSTO_COMB_LIQ").Caption = NPOI_ST.FormatDato("COSTO COMBUSTIBLE CIERRE VIAJE", HelpClass_NPOI_ST.keyDatoNumero)
           
            dtExport.Columns.Add("CSTO_UREA_LIQ").Caption = NPOI_ST.FormatDato("COSTO ÚREA CIERRE VIAJE", HelpClass_NPOI_ST.keyDatoNumero)
            dtExport.Columns.Add("CECO_OP").Caption = NPOI_ST.FormatDato("CENTRO COSTE", HelpClass_NPOI_ST.keyDatoTexto)
            dtExport.Columns.Add("PLANTA_OP").Caption = NPOI_ST.FormatDato("CIUDAD COSTE", HelpClass_NPOI_ST.keyDatoTexto)


            Dim oListvisitado As New Hashtable
            Dim dr As DataRow
            Dim Rendimiento_VjeCerrado As Decimal = 0
            Dim Rendimiento_UreaGalon As Decimal = 0

            Dim TotGalones_Urea As Decimal = 0
            Dim TotCosto_Urea As Decimal = 0
            Dim TotGalones_Combustible As Decimal = 0
            Dim TotCosto_Combustible As Decimal = 0
            Dim TotPesoIda As Decimal = 0
            Dim TotPesoRetorno As Decimal = 0
            Dim TotPesoInterno As Decimal = 0
            Dim NroLiquidacion As String = ""
            For Each item As DataRow In gdtvale.Rows


                dr = dtExport.NewRow
                NroLiquidacion = ("" & item("NLQCMB")).ToString.Trim
                dr("NLQCMB") = item("NLQCMB")
                dr("FLQDCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FLQDCN"))
                dr("ESTADO") = item("ESTADO")
                dr("FCRCMB") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCRCMB"))
                dr("NVLGRS") = item("NVLGRS")
                dr("DCMPPR") = item("DCMPPR")
                dr("TLCLGR") = item("TLCLGR")
                dr("TGRFO") = item("TGRFO")
                dr("TDSCMB") = item("TDSCMB")
                dr("QGLNCM") = item("QGLNCM")
                dr("CSTGLN") = item("CSTGLN")

                dr("NPLCUN") = item("NPLCUN")
                dr("NOPRCN") = GetColumnaDato(gdtOp, item("NLQCMB"), "NOPRCN")
                dr("TMRCTR") = GetColumnaDato(gdtOp, item("NLQCMB"), "TMRCTR")
                dr("TIPO_TRACTO") = GetColumnaDato(gdtOp, item("NLQCMB"), "TIPO_TRACTO")
                dr("NPLCAC") = GetColumnaDato(gdtOp, item("NLQCMB"), "NPLCAC")
                dr("TIPO_ACOPLADO") = GetColumnaDato(gdtOp, item("NLQCMB"), "TIPO_ACOPLADO")
                dr("CONDUCTOR") = GetColumnaDato(gdtOp, item("NLQCMB"), "CONDUCTOR")
                dr("RUTA") = GetColumnaDato(gdtOp, item("NLQCMB"), "RUTA")
                dr("TCMPCL") = GetColumnaDato(gdtOp, item("NLQCMB"), "TCMPCL")

                dr("TIPO_CARGA") = GetColumnaDato(gdtOp, item("NLQCMB"), "TIPO_CARGA")
                dr("NEGOCIO") = GetColumnaDato(gdtOp, item("NLQCMB"), "NEGOCIO")
                dr("PLANTA_OP") = GetColumnaDato(gdtOp, item("NLQCMB"), "PLANTA_OP")
                dr("CECO_OP") = GetColumnaDato(gdtOp, item("NLQCMB"), "CECO_OP")

                dr("SUBT_COMB") = item("SUBT_COMB")



                If Not oListvisitado.Contains(NroLiquidacion) Then

                    oListvisitado(NroLiquidacion) = NroLiquidacion

                    dr("KMSINI") = item("KMSINI")
                    dr("KMSFIN") = item("KMSFIN")
                    dr("KMSRCR") = item("KMSRCR")




                    TotGalones_Urea = 0
                    TotCosto_Urea = 0
                    GetTotales_Urea(gdtuREA, item("NLQCMB"), TotGalones_Urea, TotCosto_Urea)
                    dr("QGUREA_LIQ") = TotGalones_Urea
                    dr("CSTO_UREA_LIQ") = TotCosto_Urea

                    TotGalones_Combustible = 0
                    TotCosto_Combustible = 0
                    GetTotal_Combustible(gdtvale, item("NLQCMB"), TotGalones_Combustible, TotCosto_Combustible)
                    dr("QGLNCM_LIQ") = TotGalones_Combustible
                    dr("CSTO_COMB_LIQ") = TotCosto_Combustible

                    If dr("QGLNCM_LIQ") = 0 Then
                        Rendimiento_VjeCerrado = 0
                    Else
                        Rendimiento_VjeCerrado = Math.Round(dr("KMSRCR") / dr("QGLNCM_LIQ"), 2)
                    End If
                    dr("REND_VJE_LIQ") = Rendimiento_VjeCerrado

                    If dr("QGUREA_LIQ") = 0 Then
                        Rendimiento_UreaGalon = 0
                    Else
                        Rendimiento_UreaGalon = Math.Round(dr("KMSRCR") / dr("QGUREA_LIQ"), 2)
                    End If
                    dr("REND_UREA_LIQ") = Rendimiento_UreaGalon

                    TotPesoIda = 0
                    TotPesoRetorno = 0
                    TotPesoInterno = 0
                    GetTotales_Pesos(gdtOp, item("NLQCMB"), TotPesoIda, TotPesoRetorno, TotPesoInterno)
                    dr("PESO_IDA") = TotPesoIda
                    dr("PESO_RETORNO") = TotPesoRetorno
                    dr("PESO_INTERNO") = TotPesoInterno

                Else
                    dr("KMSINI") = 0
                    dr("KMSFIN") = 0
                    dr("KMSRCR") = 0
                    dr("QGUREA_LIQ") = 0
                    dr("QGLNCM_LIQ") = 0
                    dr("REND_VJE_LIQ") = 0
                    dr("REND_UREA_LIQ") = 0


                    dr("CSTO_UREA_LIQ") = 0
                    dr("CSTO_COMB_LIQ") = 0
                    dr("PESO_IDA") = 0
                    dr("PESO_RETORNO") = 0
                    dr("PESO_INTERNO") = 0

                End If

                dtExport.Rows.Add(dr)
            Next

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LIQUIDACION COMBUSTIBLE")

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            'itemSortedList.Add(itemSortedList.Count, "Compañia :|" & cboCompania.SelectedValue & "  " & cboDivision.SelectedValue)
            'If chk.Checked = True Then
            '    itemSortedList.Add(itemSortedList.Count, "Desde :|" & dtpFecIni.Value.ToString("dd/MM/yyyy") & "  hasta " & dtpFecFin.Value.ToString("dd/MM/yyyy"))
            'End If
            'If txtVehiculo.Text.Trim <> "" Then
            '    itemSortedList.Add(itemSortedList.Count, "Vehículo :|" & txtVehiculo.Text.Trim)
            'End If
            LisFiltros.Add(itemSortedList)


            Dim ListNameCombDuplicado As New List(Of String)
            Dim CombCol As String = "NLQCMB:NLQCMB/1"
            CombCol = CombCol & "|FLQDCN:NLQCMB,FLQDCN/1"
            CombCol = CombCol & "|ESTADO:NLQCMB,ESTADO/1"
            CombCol = CombCol & "|NPLCUN:NLQCMB,NPLCUN/1"

            CombCol = CombCol & "|NOPRCN:NLQCMB,NOPRCN/1"
            CombCol = CombCol & "|TMRCTR:NLQCMB,TMRCTR/1"
            CombCol = CombCol & "|TIPO_TRACTO:NLQCMB,TIPO_TRACTO/1"
            CombCol = CombCol & "|NPLCAC:NLQCMB,NPLCAC/1"
            CombCol = CombCol & "|TIPO_ACOPLADO:NLQCMB,TIPO_ACOPLADO/1"
            CombCol = CombCol & "|CONDUCTOR:NLQCMB,CONDUCTOR/1"
            CombCol = CombCol & "|RUTA:NLQCMB,RUTA/1"

            CombCol = CombCol & "|KMSINI:NLQCMB,KMSINI/0"
            CombCol = CombCol & "|KMSFIN:NLQCMB,KMSFIN/0"
            CombCol = CombCol & "|KMSRCR:NLQCMB,KMSRCR/0"
            CombCol = CombCol & "|QGUREA_LIQ:NLQCMB,QGUREA_LIQ/0"
            CombCol = CombCol & "|TIPO_CARGA:NLQCMB,TIPO_CARGA/1"
            CombCol = CombCol & "|NEGOCIO:NLQCMB,NEGOCIO/1"
            CombCol = CombCol & "|REND_UREA_LIQ:NLQCMB,REND_UREA_LIQ/10"
            CombCol = CombCol & "|QGLNCM_LIQ:NLQCMB,QGLNCM_LIQ/0"
            CombCol = CombCol & "|TCMPCL:NLQCMB,TCMPCL/1"
            CombCol = CombCol & "|REND_VJE_LIQ:NLQCMB,REND_VJE_LIQ/0"
            CombCol = CombCol & "|CSTO_UREA_LIQ:NLQCMB,CSTO_UREA_LIQ/0"
            CombCol = CombCol & "|PLANTA_OP:NLQCMB,PLANTA_OP/1"
            CombCol = CombCol & "|CSTO_COMB_LIQ:NLQCMB,CSTO_COMB_LIQ/0"
            CombCol = CombCol & "|PESO_IDA:NLQCMB,PESO_IDA/0"
            CombCol = CombCol & "|PESO_RETORNO:NLQCMB,PESO_RETORNO/0"
            CombCol = CombCol & "|PESO_INTERNO:NLQCMB,PESO_INTERNO/0"
            CombCol = CombCol & "|CECO_OP:NLQCMB,CECO_OP/1"


            ListNameCombDuplicado.Add(CombCol)


            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExport.Copy)

        
            NPOI_ST.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, ListNameCombDuplicado, Nothing, Nothing)
       
        
        Catch ex As Exception
            MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub GetTotales_Pesos(dtOP As DataTable, NRO_LIQ As Decimal, ByRef Tot_PesoIda As Decimal, ByRef Tot_PesoRetorno As Decimal, ByRef Tot_PesoInterno As Decimal)
        Dim dr() As DataRow
        Tot_PesoIda = 0
        Tot_PesoRetorno = 0
        dr = dtOP.Select("NLQCMB='" & NRO_LIQ & "'")
        For Each item As DataRow In dr
            Tot_PesoIda = Tot_PesoIda + Val("" & item("PESO_IDA"))
            Tot_PesoRetorno = Tot_PesoRetorno + Val("" & item("PESO_RETORNO"))
            Tot_PesoInterno = Tot_PesoInterno + Val("" & item("PESO_INTERNO"))         
        Next
    End Sub

    Private Sub GetTotales_Urea(dtUrea As DataTable, NRO_LIQ As Decimal, ByRef TotGalonesUrea As Decimal, ByRef TotCostoUrea As Decimal)
        Dim dr() As DataRow
        TotGalonesUrea = 0
        TotCostoUrea = 0
        dr = dtUrea.Select("NLQCMB='" & NRO_LIQ & "'")
        For Each item As DataRow In dr
            TotGalonesUrea = TotGalonesUrea + Val("" & item("QGLNCM"))
            TotCostoUrea = TotCostoUrea + Val("" & item("SUB_TOTAL"))
        Next
    End Sub
    
    Private Sub GetTotal_Combustible(dtVale As DataTable, NRO_LIQ As Decimal, ByRef TotGalonesComb As Decimal, ByRef TotCostoComb As Decimal)
        Dim dr() As DataRow
        TotGalonesComb = 0
        TotCostoComb = 0
        dr = dtVale.Select("NLQCMB='" & NRO_LIQ & "'")
        For Each item As DataRow In dr
            TotGalonesComb = TotGalonesComb + Val("" & item("QGLNCM"))
            TotCostoComb = TotCostoComb + Val("" & item("SUBT_COMB"))
        Next
    End Sub
    Private Function GetColumnaDato(dt As DataTable, NRO_LIQ As Decimal, columna As String) As String
        Dim dr() As DataRow
        dr = dt.Select("NLQCMB='" & NRO_LIQ & "'")
        Dim oLista As New Hashtable
        Dim valor As String = ""
        Dim cadLista As String = ""
        For Each item As DataRow In dr
            valor = ("" & item(columna)).ToString.Trim
            If Not oLista.Contains(valor) And valor.Length > 0 Then
                oLista(valor) = valor
                cadLista = cadLista & valor & Chr(10)
            End If
        Next
        cadLista = cadLista.Trim
        Return cadLista
    End Function

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            Dim ofrmCargaVales As New frmCargaVales
            ofrmCargaVales.pCCMPN = cboCompania.SelectedValue
            ofrmCargaVales.pCDVSN = cboDivision.SelectedValue
            ofrmCargaVales.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

'CSR-HUNDRED-feature/151116_Combustibles-FIN
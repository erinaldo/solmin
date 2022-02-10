Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO

Public Class frmRptSegNacional

#Region "Variables"
    Private oDocApertura As clsDocApertura
    Private oEmbarque As clsEmbarque
    Private oclsEstado As clsEstado
    Private oclsDespachoNacional As Negocio.clsDespachoNacional
    Private oclsCiaTransporte As New Negocio.clsCiaTransporte

    Dim Filtro As New Hashtable()
    Dim FiltroFact As New Hashtable
    Dim objCrep As Object
    Private dtResultado As New DataTable

#End Region

#Region "Delegados"

    Private Sub frmRptSegNacional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgDatos.AutoGenerateColumns = False
            dgwFacOperacion.AutoGenerateColumns = False
            Cargar_Compania()
            CargarCombos()
            Cargar_Mes()
            txtAnio.Maximum = Now.Year
            txtAnio.Text = Now.Year
            CargarLocalidadOD()
            verGrafico(False)

            VisorRep.DisplayStatusBar = True
            VisorRep.DisplayToolbar = True

            KryptonCheckBox1_CheckedChanged(KryptonCheckBox1, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function Contar_Num_Documento(ByVal dt As DataTable) As Int32
        Dim doc As String = ""
        Dim CantDoc As Int32 = 0
        Dim Visitado As New Hashtable
        For Each item As DataRow In dt.Rows
            doc = ("" & item("NUMDCR")).ToString.Trim
            If doc.Length > 0 AndAlso doc <> "0" AndAlso Not Visitado.Contains(doc) Then
                Visitado.Add(doc, doc)
            End If
        Next
        Return Visitado.Count
    End Function

    Private Function CopiarInfoReg(ByVal drEmbarques() As DataRow, ByVal dtOrdenes As DataTable) As DataTable
        Dim dtOrdenTemp As New DataTable
        dtOrdenTemp = dtOrdenes.Copy
        dtOrdenTemp.Rows.Clear()
        Dim drLista() As DataRow
        For Each Item As DataRow In drEmbarques
            drLista = dtOrdenes.Select("NORSCI='" & Item("NORSCI") & "'")
            For Each Item1 As DataRow In drLista
                dtOrdenTemp.ImportRow(Item1)
            Next
        Next
        Return dtOrdenTemp
    End Function

    Private Function Elaborar_Cuadro_Resumen_Tiempo_Transito(ByVal dtOrdenes As DataTable, ByVal dtReporte As DataTable, ByVal Fin_Registro As Int64, ByVal Max_Defecto As Int64, ByVal Supera_maximo_defecto As Boolean) As DataTable
        Dim dtRepGraficos As New DataTable
        dtRepGraficos.Columns.Add("DIA")
        dtRepGraficos.Columns.Add("FORMAT_DIA")
        dtRepGraficos.Columns.Add("CANTIDAD", Type.GetType("System.Int32"))
        dtRepGraficos.Columns.Add("CANTIDAD_EMB", Type.GetType("System.Int32"))
        dtRepGraficos.Columns.Add("PORCIENTO", Type.GetType("System.Decimal"))
        dtRepGraficos.Columns.Add("ACUMULADO", Type.GetType("System.Decimal"))
        Dim datRow As DataRow
        Dim dtOrdenRango As New DataTable
       
        For index As Integer = 0 To Fin_Registro
            datRow = dtRepGraficos.NewRow
            datRow("DIA") = index
            datRow("FORMAT_DIA") = index & " días"
            datRow("CANTIDAD") = 0
            datRow("CANTIDAD_EMB") = 0
            datRow("PORCIENTO") = 0
            datRow("ACUMULADO") = 0
            dtRepGraficos.Rows.Add(datRow)
        Next
        If Supera_maximo_defecto = True Then
            datRow = dtRepGraficos.NewRow
            datRow("DIA") = 99
            datRow("FORMAT_DIA") = Max_Defecto & " días +"
            datRow("CANTIDAD") = 0
            datRow("CANTIDAD_EMB") = 0
            datRow("PORCIENTO") = 0
            datRow("ACUMULADO") = 0
            dtRepGraficos.Rows.Add(datRow)
        End If

        Dim Duracion As Int32 = 0
        Dim drCalculo() As DataRow
        Dim TotalDias As Decimal = 0
        For Each dr As DataRow In dtRepGraficos.Rows
            Duracion = dr("DIA")
            If Duracion > Max_Defecto Then
                drCalculo = dtReporte.Select("DIF_158_157 > '" & Max_Defecto & "'")
            Else
                drCalculo = dtReporte.Select("DIF_158_157 = '" & Duracion & "'")
            End If
            dr("CANTIDAD_EMB") = drCalculo.Length
            dtOrdenRango = CopiarInfoReg(drCalculo, dtOrdenes)
            dr("CANTIDAD") = Contar_Num_Documento(dtOrdenRango)
        Next
        TotalDias = Val("" & dtRepGraficos.Compute("SUM(CANTIDAD)", ""))
        For Each dr As DataRow In dtRepGraficos.Rows
            If TotalDias = 0 Then
                dr("PORCIENTO") = 0
            Else
                dr("PORCIENTO") = Math.Round((dr("CANTIDAD") / TotalDias) * 100, 2)
            End If

        Next
        If dtRepGraficos.Rows.Count > 0 Then
            Dim SubTotal As Decimal = 0
            SubTotal = Val("" & dtRepGraficos.Compute("SUM(PORCIENTO)", ""))
            dtRepGraficos.Rows(dtRepGraficos.Rows.Count - 1)("PORCIENTO") = 100 + dtRepGraficos.Rows(dtRepGraficos.Rows.Count - 1)("PORCIENTO") - SubTotal
        End If
        Dim PAR_POR As Decimal = 0
        For Each dr As DataRow In dtRepGraficos.Rows
            PAR_POR = PAR_POR + dr("PORCIENTO")
            dr("ACUMULADO") = PAR_POR
        Next
        Return dtRepGraficos
    End Function

    Private Function Elaborar_Cuadro_Resumen_Tiempo_Transito_TipoTarifa(ByVal dtTipoTarifa As DataTable, ByVal dtOrdenes As DataTable, ByVal dtReporte As DataTable, ByVal Fin_Registro As Int64, ByVal Max_Defecto As Int64, ByVal Supera_maximo_defecto As Boolean) As DataTable
        Dim dsListado As New DataSet

        Dim TipoTarifa As String = ""
        Dim codTipoTarifa As Int64 = 0


        Dim Listatarifa As New DataTable
        Listatarifa = dtTipoTarifa.Copy


        Dim dtRepGraficos As New DataTable
        dtRepGraficos.Columns.Add("COD_TARIFA")
        dtRepGraficos.Columns.Add("TIPO_TARIFA")
        dtRepGraficos.Columns.Add("DIA")
        dtRepGraficos.Columns.Add("FORMAT_DIA")
        dtRepGraficos.Columns.Add("CANTIDAD", Type.GetType("System.Int32")) 'CANTIDAD GUIA
        dtRepGraficos.Columns.Add("CANTIDAD_EMB", Type.GetType("System.Int32"))
        dtRepGraficos.Columns.Add("PORCIENTO", Type.GetType("System.Decimal"))
        dtRepGraficos.Columns.Add("ACUMULADO", Type.GetType("System.Decimal"))




        Dim datRow As DataRow
        Dim dtOrdenRango As New DataTable


    
        For Each ItemTipo As DataRow In Listatarifa.Rows


            dtRepGraficos.Rows.Clear()
            For index As Integer = 0 To Fin_Registro
                datRow = dtRepGraficos.NewRow
            
                datRow("COD_TARIFA") = ItemTipo("COD_TARIFA")
                datRow("TIPO_TARIFA") = ("" & ItemTipo("DESC_TARIFA")).ToString.ToUpper

                datRow("DIA") = index
                datRow("FORMAT_DIA") = index & " días"
                datRow("CANTIDAD") = 0
                datRow("CANTIDAD_EMB") = 0
                datRow("PORCIENTO") = 0
                datRow("ACUMULADO") = 0
                dtRepGraficos.Rows.Add(datRow)
            Next
            If Supera_maximo_defecto = True Then
                datRow = dtRepGraficos.NewRow
              
                datRow("COD_TARIFA") = ItemTipo("COD_TARIFA")
                datRow("TIPO_TARIFA") = ("" & ItemTipo("DESC_TARIFA")).ToString.ToUpper

                datRow("DIA") = 99
                datRow("FORMAT_DIA") = Max_Defecto & " días +"
                datRow("CANTIDAD") = 0
                datRow("CANTIDAD_EMB") = 0
                datRow("PORCIENTO") = 0
                datRow("ACUMULADO") = 0
                dtRepGraficos.Rows.Add(datRow)
            End If

            Dim Duracion As Int32 = 0
            Dim drCalculo() As DataRow
            Dim TotalDias As Decimal = 0
            For Each dr As DataRow In dtRepGraficos.Rows
                Duracion = dr("DIA")
                If Duracion > Max_Defecto Then
                    'drCalculo = dtReporte.Select("DIF_158_157 > '" & Max_Defecto & "'  AND FLGTRF='" & item.Key & "'")
                    drCalculo = dtReporte.Select("DIF_158_157 > '" & Max_Defecto & "'  AND FLGTRF='" & ItemTipo("COD_TARIFA") & "'")
                Else
                    'drCalculo = dtReporte.Select("DIF_158_157 = '" & Duracion & "'  AND FLGTRF='" & item.Key & "'")
                    drCalculo = dtReporte.Select("DIF_158_157 = '" & Duracion & "'  AND FLGTRF='" & ItemTipo("COD_TARIFA") & "'")
                End If
                dr("CANTIDAD_EMB") = drCalculo.Length
                dtOrdenRango = CopiarInfoReg(drCalculo, dtOrdenes)
                dr("CANTIDAD") = Contar_Num_Documento(dtOrdenRango)
            Next
            TotalDias = Val("" & dtRepGraficos.Compute("SUM(CANTIDAD)", ""))
            For Each dr As DataRow In dtRepGraficos.Rows
                If TotalDias = 0 Then
                    dr("PORCIENTO") = 0
                Else
                    dr("PORCIENTO") = Math.Round((dr("CANTIDAD") / TotalDias) * 100, 2)
                End If

            Next
            If dtRepGraficos.Rows.Count > 0 Then
                Dim SubTotal As Decimal = 0
                SubTotal = Val("" & dtRepGraficos.Compute("SUM(PORCIENTO)", ""))
                dtRepGraficos.Rows(dtRepGraficos.Rows.Count - 1)("PORCIENTO") = 100 + dtRepGraficos.Rows(dtRepGraficos.Rows.Count - 1)("PORCIENTO") - SubTotal
            End If
            Dim PAR_POR As Decimal = 0
            For Each dr As DataRow In dtRepGraficos.Rows
                PAR_POR = PAR_POR + dr("PORCIENTO")
                dr("ACUMULADO") = PAR_POR
            Next

            Dim TotalGuias As Decimal = 0
            TotalGuias = Val("" & dtRepGraficos.Compute("SUM(CANTIDAD)", ""))
            If TotalGuias > 0 Then
                dsListado.Tables.Add(dtRepGraficos.Copy)
            End If
            'Next
        Next

        Dim dataUnida As New DataTable
        dataUnida = dtRepGraficos.Copy
        dataUnida.Rows.Clear()
        For Each dt As DataTable In dsListado.Tables
            For Each Item As DataRow In dt.Rows
                dataUnida.ImportRow(Item)
            Next
        Next


        Return dataUnida
    End Function

    Private Function Elaborar_Cuadro_Resumen_Despacho_TipoTarifa(ByVal dtTipoTarifa As DataTable, ByVal dtGeneral As DataTable, ByVal dtOrdenes As DataTable) As DataTable
        Dim dtRepTarifa As New DataTable
        dtRepTarifa.Columns.Add("TIPO_TARIFA")
        dtRepTarifa.Columns.Add("CANTIDAD", Type.GetType("System.Decimal"))
        dtRepTarifa.Columns.Add("CANTIDAD_EMB", Type.GetType("System.Int32"))

        Dim filas() As DataRow
        Dim fila As DataRow
        Dim column As String = ""
        Dim TarifaVisitado As New Hashtable
        Dim dtOrdenRango As New DataTable

        Dim drTipo As DataRow
        For Each Item As DataRow In dtTipoTarifa.Rows
            drTipo = dtRepTarifa.NewRow
            drTipo("TIPO_TARIFA") = ("" & Item("DESC_TARIFA")).ToString.ToUpper
            drTipo("CANTIDAD") = 0
            drTipo("CANTIDAD_EMB") = 0
            dtRepTarifa.Rows.Add(drTipo)
        Next

        For Each Item As DataRow In dtRepTarifa.Rows
            column = ("" & Item("TIPO_TARIFA")).ToString.ToUpper.Trim
            filas = dtGeneral.Select("TIPO_TARIFA = '" & column & "'")
            dtOrdenRango = CopiarInfoReg(filas, dtOrdenes)
            Item("CANTIDAD") = Contar_Num_Documento(dtOrdenRango)
            Item("CANTIDAD_EMB") = filas.Length
        Next

     
        Return dtRepTarifa
    End Function
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            VisorRep.ReportSource = Nothing
            dtgDatos.DataSource = Nothing
            oclsDespachoNacional = New clsDespachoNacional
            Dim cadena As String = ValidarBusqueda()
            If cadena.Length > 0 Then
                MessageBox.Show(cadena.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            verGrafico(True)

            CargarFiltro()
            CargarFiltroFacturacion()
            bgwProcesoReport.RunWorkerAsync()


        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    'Private Function DifDiasFechas(ByVal FechaInf As String, ByVal FechaSup As String) As Int32
    '    FechaInf = FechaInf.Trim
    '    FechaSup = FechaSup.Trim

    '    Dim EsFecha As Date
    '    Dim lintDias As Int32 = 0
    '    If Date.TryParse(FechaInf, EsFecha) AndAlso Date.TryParse(FechaSup, EsFecha) Then
    '        lintDias = DateDiff(DateInterval.Day, CType(FechaInf, Date), CType(FechaSup, Date))
    '    Else
    '        lintDias = 0
    '    End If
    '    Return lintDias
    'End Function

    Private Sub btnExpNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpNormal.Click
        Try
            If dtgDatos.Rows.Count > 0 Then

                Dim dtDatos As New DataTable
                dtDatos = dtgDatos.DataSource

                Dim NPOI_SC As New HelpClass_NPOI_SC
                Dim odtExportar As New DataTable
                odtExportar.TableName = "Datos Embarque"

                odtExportar.Columns.Add("NORSCI").Caption = NPOI_SC.FormatDato("Embarque", NPOI_SC.keyDatoNumero)
                odtExportar.Columns.Add("FORSCI").Caption = NPOI_SC.FormatDato("Fecha apertura", NPOI_SC.keyDatoFecha)
                odtExportar.Columns.Add("NREFCL").Caption = NPOI_SC.FormatDato("Ref. cliente", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("REFDO1").Caption = NPOI_SC.FormatDato("Ref. documento", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TOTGUIAEMB").Caption = NPOI_SC.FormatDato("Cant. Doc", NPOI_SC.keyDatoNumero)
                odtExportar.Columns.Add("NUMDCR").Caption = NPOI_SC.FormatDato("Doc./Guía Remisión", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("NORCML").Caption = NPOI_SC.FormatDato("Órdenes de compra", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TPSRVA").Caption = NPOI_SC.FormatDato("Tipo servicio", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TCMLCL_ORIGEN").Caption = NPOI_SC.FormatDato("Lugar origen", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TDRCOR").Caption = NPOI_SC.FormatDato("Dir. Lugar origen", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TCMLCL_DESTINO").Caption = NPOI_SC.FormatDato("Lugar destino", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TDREN2").Caption = NPOI_SC.FormatDato("Dir. Lugar destino", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TIPO_TARIFA").Caption = NPOI_SC.FormatDato("Tipo tarifa", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("Medio de transporte", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TNMCIN").Caption = NPOI_SC.FormatDato("Cia. transporte", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("NAVE").Caption = NPOI_SC.FormatDato("Tipo transporte", NPOI_SC.keyDatoTexto)
                'odtExportar.Columns.Add("TPRVCL").Caption = NPOI_SC.FormatDato("Proveedor", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TCMPCL").Caption = NPOI_SC.FormatDato("Cliente", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("SESTRG").Caption = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("TOBERV").Caption = NPOI_SC.FormatDato("Mercadería", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato("Doc. embarque", NPOI_SC.keyDatoTexto)
                odtExportar.Columns.Add("QPSOAR").Caption = NPOI_SC.FormatDato("Peso", NPOI_SC.keyDatoNumero)
                odtExportar.Columns.Add("QBULTOS").Caption = NPOI_SC.FormatDato("Cant. Bultos", NPOI_SC.keyDatoNumero) 'jm
                odtExportar.Columns.Add("QVOLMR").Caption = NPOI_SC.FormatDato("Volumen", NPOI_SC.keyDatoNumero)
                odtExportar.Columns.Add("OBS").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)
               
                Dim NameColumna As String = String.Empty
                For Each dc As DataColumn In dtDatos.Columns
                    NameColumna = dc.ColumnName.Trim

                    If (NameColumna.EndsWith("-COSTO")) Then
                        odtExportar.Columns.Add(NameColumna).Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoNumero)
                    End If

                    If (NameColumna.EndsWith("-CHK")) Then
                        odtExportar.Columns.Add(NameColumna).Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoFecha)
                    End If

                    If (NameColumna = "DIF") Then
                        odtExportar.Columns.Add("DIF").Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoNumero)
                    End If
                Next
               
                
                Dim dr As DataRow
                For Each drDatos As DataRow In dtDatos.Rows
                    dr = odtExportar.NewRow
                    For Each dcColumna As DataColumn In odtExportar.Columns
                        NameColumna = dcColumna.ColumnName
                        dr(NameColumna) = drDatos(NameColumna)
                    Next
                    odtExportar.Rows.Add(dr)
                Next
                    
                'dgwFacOperacion   nueva grilla
                Dim odtExportarFacOp As New DataTable
                odtExportarFacOp.TableName = "Datos Facturación"
                odtExportarFacOp.Columns.Add("TABTPD").Caption = NPOI_SC.FormatDato("Tipo Doc", NPOI_SC.keyDatoTexto)
                odtExportarFacOp.Columns.Add("NDCCTC").Caption = NPOI_SC.FormatDato("Nro Doc", NPOI_SC.keyDatoTexto)
                odtExportarFacOp.Columns.Add("F_FDCCTC").Caption = NPOI_SC.FormatDato("Fecha Doc", NPOI_SC.keyDatoFecha)
                odtExportarFacOp.Columns.Add("MONTO_SOL").Caption = NPOI_SC.FormatDato("Monto(S/.)", NPOI_SC.keyDatoNumero)
                odtExportarFacOp.Columns.Add("MONTO_DOL").Caption = NPOI_SC.FormatDato("Monto($/.)", NPOI_SC.keyDatoNumero)
                odtExportarFacOp.Columns.Add("NORSCI").Caption = NPOI_SC.FormatDato("Embarque", NPOI_SC.keyDatoTexto)
                odtExportarFacOp.Columns.Add("F_FORSCI").Caption = NPOI_SC.FormatDato("Fecha apertura", NPOI_SC.keyDatoFecha)
                odtExportarFacOp.Columns.Add("DTTARIFA").Caption = NPOI_SC.FormatDato("Tipo Tarifa", NPOI_SC.keyDatoTexto)
                odtExportarFacOp.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("Medio Trasporte", NPOI_SC.keyDatoTexto)
                odtExportarFacOp.Columns.Add("ORIGEN").Caption = NPOI_SC.FormatDato("Origen", NPOI_SC.keyDatoTexto)
                odtExportarFacOp.Columns.Add("DESTINO").Caption = NPOI_SC.FormatDato("Destino", NPOI_SC.keyDatoTexto)
                Dim dtDatosFac As New DataTable
            
                dtDatosFac = dgwFacOperacion.DataSource


                Dim dr1 As DataRow
                For Each drDatos As DataRow In dtDatosFac.Rows
                    dr1 = odtExportarFacOp.NewRow
                    For Each dcColumna As DataColumn In odtExportarFacOp.Columns
                        NameColumna = dcColumna.ColumnName
                        dr1(NameColumna) = drDatos(NameColumna)
                    Next
                    odtExportarFacOp.Rows.Add(dr1)
                Next
                'Dim Visitado As New Hashtable
                'Dim DocFac As String = ""
                'For Each Item As DataRow In odtExportarFacOp.Rows
                '    DocFac = Item("TABTPD") & "_" & Item("NDCCTC")
                '    If Not Visitado.Contains(DocFac) Then
                '        Visitado.Add(DocFac, DocFac)
                '    Else
                '        Item("MONTO_SOL") = 0
                '        Item("MONTO_DOL") = 0
                '    End If
                'Next

                Dim ListaDatatable As New List(Of DataTable)
                ListaDatatable.Add(odtExportar.Copy)
                ListaDatatable.Add(odtExportarFacOp.Copy) 'nuevo


                'Dim ListNameCombDuplicado As New List(Of String)
                'Dim CombCol As String
                'CombCol = "TABTPD:NDCCTC,TABTPD/1|NDCCTC:NDCCTC/1|F_FDCCTC:NDCCTC,F_FDCCTC/1|MONTO_SOL:NDCCTC,MONTO_SOL/0|MONTO_DOL:NDCCTC,MONTO_DOL/0"

                'ListNameCombDuplicado.Add("")
                'ListNameCombDuplicado.Add(CombCol)


                Dim LisFiltros As New List(Of SortedList)
                Dim itemSortedList As SortedList

                itemSortedList = New SortedList

                itemSortedList.Add(itemSortedList.Count, "Compañia:|" & cmbCompania.oBeCompania.TCMPCM_DescripcionCompania)
                itemSortedList.Add(itemSortedList.Count, "División:|" & cmbDivision.DivisionDescripcion)
                itemSortedList.Add(itemSortedList.Count, "Planta:|" & cmbPlanta.DescripcionPlanta)


                itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pRazonSocial)
                itemSortedList.Add(itemSortedList.Count, "Fecha:|" & dtpFecIni.Value.ToString("dd/MM/yyyy") & " al " & dtpFecFin.Value.ToString("dd/MM/yyyy"))
                itemSortedList.Add(itemSortedList.Count, "Estado:|" & cmbEstado.Text)
 

                If cboLugarorigen.Resultado IsNot Nothing Then
                    itemSortedList.Add(itemSortedList.Count, "Lugar Origen:|" & CType(cboLugarorigen.Resultado, beLocalidad).TCMLCL)
                End If

                If cboLugarDestino.Resultado IsNot Nothing Then
                    itemSortedList.Add(itemSortedList.Count, "Lugar Destino:|" & CType(cboLugarDestino.Resultado, beLocalidad).TCMLCL)
                End If
 
                LisFiltros.Add(itemSortedList)

                Dim ListTitulo As New List(Of String)
                ListTitulo.Add("Embarque Nacional")
                ' NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, ListNameCombDuplicado)
                NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork
        'ReporteFormatoExtendido()
        'ReporteResumido()
        e.Result = oclsDespachoNacional.Listar_Embarque_Nacional_Consulta_Exportar(Filtro, FiltroFact)
     
    End Sub

    Private Sub bgwProcesoReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcesoReport.RunWorkerCompleted
        Try
          
            Dim dtGeneral As New DataTable
            Dim dsResult As New DataSet
            Dim dtOrdenes As New DataTable
            'JM
            'Dim dtFact As New DataTable
            Dim dtTipoTarifa As New DataTable
            Dim dtFacturacion As New DataTable
            Dim dtFactReporte As New DataTable

            dsResult = CType(e.Result, DataSet)
            dtGeneral = dsResult.Tables("dtDatosEmbarque").Copy
            dtOrdenes = dsResult.Tables("dtOrdenesEmbarque").Copy
            
            dtTipoTarifa = dsResult.Tables("dtTipoTarifa").Copy

            'dtFacturacion = Cargar_Fac_Operacion()
            dtFacturacion = dsResult.Tables("dtFacturacion").Copy

            Dim NameColumna As String = ""
            Dim NameCaption As String = ""
            Dim Columna As String = ""
            Dim COLUMNAS_CHK As New List(Of String)
            Dim COLUMNAS_COSTO As New List(Of String)
            Dim DIF_COLUM As String = String.Empty

            For Each COLUMNAS As DataGridViewColumn In dtgDatos.Columns
                NameColumna = COLUMNAS.Name
                If (NameColumna.EndsWith("-CHK") = True) Then
                    COLUMNAS_CHK.Add(NameColumna)
                End If
                If (NameColumna.EndsWith("-COSTO") = True) Then
                    COLUMNAS_COSTO.Add(NameColumna)
                End If
              
            Next

            For Each Item As String In COLUMNAS_CHK
                If (dtgDatos.Columns(Item) IsNot Nothing) Then
                    dtgDatos.Columns.Remove(Item)
                End If
            Next

            For Each Item As String In COLUMNAS_COSTO
                If (dtgDatos.Columns(Item) IsNot Nothing) Then
                    dtgDatos.Columns.Remove(Item)
                End If
            Next


            If dtgDatos.Columns("DIF") IsNot Nothing Then
                dtgDatos.Columns.Remove("DIF")
            End If
            Dim oDcTx As DataGridViewColumn
            Dim ColName() As String

            For Each dc As DataColumn In dtGeneral.Columns
                NameColumna = dc.ColumnName
                NameCaption = dc.Caption
                If (NameColumna.EndsWith("-COSTO") = True) Then
                    ColName = NameCaption.Split("|")
                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NameColumna
                    oDcTx.HeaderText = ColName(0).Trim
                    oDcTx.Resizable = DataGridViewTriState.True
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.DataPropertyName = NameColumna
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    oDcTx.ReadOnly = True
                    dtgDatos.Columns.Add(oDcTx)
                End If
            Next
            For Each dc As DataColumn In dtGeneral.Columns
                NameColumna = dc.ColumnName
                NameCaption = dc.Caption
                NameCaption = NameCaption.Replace(Chr(13), "|")
                If (NameColumna.EndsWith("-FRE-CHK") = True) Then
                    ColName = NameCaption.Split("|")
                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NameColumna
                    ' oDcTx.HeaderText = ColName(0).Trim & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " & ColName(1).Trim
                    'oDcTx.HeaderText = ColName(0).Trim
                    oDcTx.HeaderText = ColName(0).Trim
                    oDcTx.Resizable = DataGridViewTriState.True
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.DataPropertyName = NameColumna
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcTx.ReadOnly = True
                    dtgDatos.Columns.Add(oDcTx)
                End If
            Next

            If dtGeneral.Columns("DIF") IsNot Nothing Then
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = "DIF"
                oDcTx.HeaderText = dtGeneral.Columns("DIF").Caption
                oDcTx.Resizable = DataGridViewTriState.True
                oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                oDcTx.DataPropertyName = "DIF"
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.ReadOnly = True
                dtgDatos.Columns.Add(oDcTx)
            End If




            Dim dtReporte As New DataTable

            dtReporte.Columns.Add("NORSCI") '.Caption = "Embarque"
            dtReporte.Columns.Add("NUMDCR") '.Caption = "Documento(GR)"
            dtReporte.Columns.Add("156-FRE-CHK") '.Caption = "Fecha"
            dtReporte.Columns.Add("FLGTRF")
            dtReporte.Columns.Add("TIPO_TARIFA") '.Caption = "Tarifa"
            dtReporte.Columns.Add("TCMLCL_ORIGEN") '.Caption = "Origen"
            dtReporte.Columns.Add("TCMLCL_DESTINO") '.Caption = "Destino"
            dtReporte.Columns.Add("157-FRE-CHK") '.Caption = "Fecha3"
            dtReporte.Columns.Add("158-FRE-CHK") '.Caption = "Fecha3"
            dtReporte.Columns.Add("DIF_158_157") '.Caption = "Fecha3"
            dtReporte.Columns.Add("SESTRG_DESC")


            Dim MAX As Int32 = 0
            Dim datRow As DataRow
            Dim fecha1 As String = ""
            Dim fecha2 As String = ""
            For Each dr As DataRow In dtGeneral.Rows

                datRow = dtReporte.NewRow
                datRow("NORSCI") = dr("NORSCI")
                datRow("NUMDCR") = dr("NUMDCR").ToString.Replace(Chr(13), "")
                'datRow("156-FRE-CHK") = dr("156-FRE-CHK")
                datRow("FLGTRF") = dr("FLGTRF")
                datRow("TIPO_TARIFA") = dr("TIPO_TARIFA")
                datRow("TCMLCL_ORIGEN") = dr("TCMLCL_ORIGEN")
                datRow("TCMLCL_DESTINO") = dr("TCMLCL_DESTINO")
                datRow("SESTRG_DESC") = dr("SESTRG_DESC")
                datRow("157-FRE-CHK") = dr("157-FRE-CHK")
                datRow("158-FRE-CHK") = dr("158-FRE-CHK")
                'fecha1 = ("" & datRow("157-FRE-CHK")).ToString.Trim
                'fecha2 = ("" & datRow("158-FRE-CHK")).ToString.Trim
                'datRow("DIF_158_157") = DifDiasFechas(fecha1, fecha2)
                datRow("DIF_158_157") = Val("" & dr("DIF"))

                If Val(datRow("DIF_158_157")) > MAX Then
                    MAX = datRow("DIF_158_157")
                End If

                dtReporte.Rows.Add(datRow)
            Next
            dtReporte.TableName = "DT_DESPACHO_NAC"

            Dim dtRepGraficos As New DataTable
            Dim dtGraficos As New DataTable

            Const Max_Defecto As Int64 = 7
            Dim Fin_Registro As Int32 = 0
            Dim Supera_maximo_defecto As Boolean = False
            If MAX > Max_Defecto Then
                Fin_Registro = Max_Defecto
                Supera_maximo_defecto = True
            Else
                Fin_Registro = MAX
            End If

            dtRepGraficos = Elaborar_Cuadro_Resumen_Tiempo_Transito(dtOrdenes, dtReporte, Fin_Registro, Max_Defecto, Supera_maximo_defecto)
            dtRepGraficos.TableName = "DT_DESP_TRANSITO"
            ''----------------------------------------------------------''
            Dim dtRepTarifa As New DataTable
            dtRepTarifa = Elaborar_Cuadro_Resumen_Despacho_TipoTarifa(dtTipoTarifa, dtReporte, dtOrdenes)
            dtRepTarifa.TableName = "DT_DESP_TIPO_TARIFA"

            dtGraficos = Elaborar_Cuadro_Resumen_Tiempo_Transito_TipoTarifa(dtTipoTarifa, dtOrdenes, dtReporte, Fin_Registro, Max_Defecto, Supera_maximo_defecto)

            'Grear los 3 graficos 

            ' bultos  peso x tipo tarifa
            Dim dtTpTarifa1 As New DataTable
            Dim peso As Decimal = 0
            Dim volumen As Decimal = 0
            dtTpTarifa1 = dtTipoTarifa.Copy
            dtTpTarifa1.Columns.Add("PESO", Type.GetType("System.Decimal"))
            dtTpTarifa1.Columns.Add("VOLUMEN", Type.GetType("System.Decimal"))
            For Each Data As DataRow In dtTpTarifa1.Rows
                peso = Val("" & dtGeneral.Compute("SUM(QPSOAR)", "FLGTRF =" & Data("COD_TARIFA")))
                volumen = Val("" & dtGeneral.Compute("SUM(QVOLMR)", "FLGTRF =" & Data("COD_TARIFA")))
                Data("PESO") = peso
                Data("VOLUMEN") = volumen
            Next
            dtTpTarifa1.TableName = "DT_PESO_VOLUMEN_TARIFA"

            ' bultos tipo tarifa
            Dim dtTpTarifa2 As New DataTable
            Dim Bultos As Decimal = 0
            dtTpTarifa2 = dtTipoTarifa.Copy
            dtTpTarifa2.Columns.Add("BULTOS", Type.GetType("System.Decimal"))
            For Each Data As DataRow In dtTpTarifa2.Rows
                Bultos = Val("" & dtGeneral.Compute("SUM(QBULTOS)", "FLGTRF =" & Data("COD_TARIFA")))
                Data("BULTOS") = Bultos
            Next
            dtTpTarifa2.TableName = "DT_BULTOS_TARIFA"
            'Cargo la grilla
          

            'dtFacturacion = Cargar_Fac_Operacion()
            dtFactReporte = dtFacturacion.Copy

            'Dim Visitado As New Hashtable
            'Dim DocFac As String = ""
            'For Each Item As DataRow In dtFactReporte.Rows
            '    DocFac = Item("CTPODC") & "_" & Item("NDCCTC")
            '    If Not Visitado.Contains(DocFac) Then
            '        Visitado.Add(DocFac, DocFac)
            '    Else
            '        Item("MONTO_SOL") = 0
            '        Item("MONTO_DOL") = 0
            '        Item("FLGTRF") = 0
            '        'un factura puede tener asociado mas de un embarque
            '        'los embarques pueden ser de distinto tipo tarifa
            '        'para efectos de los graficos se tomará el primer tipo tarifa.
            '    End If
            'Next



            'facturacion tipo tarifa
            Dim dtTpTarifa3 As New DataTable
            dtTpTarifa3 = dtTipoTarifa.Copy
            cargarMesesDatatable(dtTpTarifa3)
            Dim mes As String = ""
            If dtFacturacion.Rows.Count > 0 Then
                For Each Data As DataRow In dtTpTarifa3.Rows
                    For Each ItemColumn As DataColumn In dtTpTarifa3.Columns
                        If ItemColumn.ColumnName.EndsWith("_TARIFA") = False Then
                            Data(ItemColumn.ColumnName) = Val("" & dtFactReporte.Compute("SUM(MONTO_DOL)", "FLGTRF =" & Data("COD_TARIFA") & " AND SUBSTRING(FDCCTC,5,2)='" & BuscaCodigoMes(ItemColumn.ColumnName) & "'"))
                        End If
                    Next
                Next
            End If
            Dim objRep As New rptDespachoNacional
            Dim objDs As New DataSet
            Dim lstrPeriodo As String
            Dim inicio As String = Filtro("PNFECINI_APERTURA")
            Dim fin As String = Filtro("PNFECFIN_APERTURA")
            lstrPeriodo = inicio & " al " & fin

            objRep.SetDataSource(dtReporte.Copy)




            Dim ruta As String = ""

            If cboLugarorigen.Resultado IsNot Nothing Then
                ruta = "Origen: " & CType(cboLugarorigen.Resultado, beLocalidad).TCMLCL
            End If
            If cboLugarDestino.Resultado IsNot Nothing Then
                If ruta.Length > 0 Then
                    ruta = ruta & " <---> "
                End If
                ruta = ruta & "Destino: " & CType(cboLugarDestino.Resultado, beLocalidad).TCMLCL
            End If
            Dim estado As String = ""

            estado = cmbEstado.Text

            CType(objRep.ReportDefinition.ReportObjects("txtRuta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ruta
            CType(objRep.ReportDefinition.ReportObjects("txtEstado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = estado
            CType(objRep.ReportDefinition.ReportObjects("txtfecha_inicio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = dtpFecIni.Value.ToString("dd/MM/yyyy")
            CType(objRep.ReportDefinition.ReportObjects("txtFecha_fin"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = dtpFecFin.Value.ToString("dd/MM/yyyy")
            CType(objRep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = cmbCliente.pRazonSocial
            CType(objRep.ReportDefinition.ReportObjects("txtPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = cmbPlanta.DescripcionPlanta

            objRep.Subreports.Item("rptTransito").SetDataSource(dtRepGraficos.Copy)
            objRep.Subreports.Item("rpt_Grafico_Despacho_Tarifa").SetDataSource(dtRepTarifa.Copy)
            objRep.Subreports.Item("rpt_Grafico_Despacho_TipoTarifa").SetDataSource(dtGraficos)

            objRep.Subreports.Item("rpt_Grafico_Despacho_TipoTarifa").SetDataSource(dtGraficos)
            'AGregar 
            objRep.Subreports.Item("rpt_Grafico_Peso_Volumen_Tipotarifa").SetDataSource(dtTpTarifa1)
            objRep.Subreports.Item("rpt_Grafico_Bultos_TipoTarifa").SetDataSource(dtTpTarifa2)
            objRep.Subreports.Item("rpt_Grafico_Facturacion_TipoTarifa").SetDataSource(dtTpTarifa3)

            VisorRep.ReportSource = objRep

            dtgDatos.DataSource = dtGeneral
            '2 grilla
            dgwFacOperacion.DataSource = dtFacturacion
            verGrafico(False)
        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


#Region "Métodos"

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Usuario = HelpUtil.UserName
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "S"
                cmbDivision.pHabilitado = False
            End If
            cmbDivision.pActualizar()
            cmbDivision_Seleccionar(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            cmbPlanta.Usuario = HelpUtil.UserName
            cmbPlanta.CodigoCompania = cmbDivision.Compania
            cmbPlanta.CodigoDivision = cmbDivision.Division
            cmbPlanta.PlantaDefault = 1
            cmbPlanta.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarLocalidadOD()
        Dim objDt As List(Of beLocalidad)
        Dim obj_Logica_Localidad As New Negocio.clsLocalidad
        objDt = obj_Logica_Localidad.Listar_Localidades()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        Me.cboLugarorigen.DataSource = objDt
        Me.cboLugarorigen.ListColumnas = oListColum
        Me.cboLugarorigen.Cargas()
        Me.cboLugarorigen.DispleyMember = "TCMLCL"
        Me.cboLugarorigen.ValueMember = "CLCLD"

        Dim oListColum2 As New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código"
        oListColum2.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum2.Add(2, oColumnas)

        Me.cboLugarDestino.DataSource = objDt
        Me.cboLugarDestino.ListColumnas = oListColum2
        Me.cboLugarDestino.Cargas()
        Me.cboLugarDestino.DispleyMember = "TCMLCL"
        Me.cboLugarDestino.ValueMember = "CLCLD"

    End Sub

    Private Sub CargarCombos()

        'Cargar Cliente
        cmbCliente.pAccesoPorUsuario = True
        cmbCliente.pRequerido = True
        cmbCliente.pUsuario = HelpUtil.UserName

        'Cargar Combo Tipo operacion embarque
        oclsEstado = New clsEstado()
        oclsDespachoNacional = New clsDespachoNacional

        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim dr As DataRow
        dr = dtTipoOperacion.NewRow
        dr("COD") = "0"
        dr("TEX") = "TODOS"

        dtTipoOperacion.Rows.InsertAt(dr, 0)
        ctbTipoOperacion.DataSource = dtTipoOperacion
        ctbTipoOperacion.DisplayMember = "TEX"
        ctbTipoOperacion.ValueMember = "COD"
        ctbTipoOperacion.SelectedValue = "NA"
        ctbTipoOperacion.Enabled = False

        'Cargar Combo Estado aduanero
        cmbEstado.DataSource = oclsEstado.Estado_Aduanero
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "A"

    End Sub

    Private Sub verGrafico(ByVal Habilitar As Boolean)
        btnBuscar.Enabled = Not Habilitar
        lblBusqueda.Visible = Habilitar
        lblBusqueda.Text = "Procesando.."
        pbxBuscar.Visible = Habilitar
        btnExportar.Enabled = Not Habilitar
    End Sub

    Public Sub CargarFiltro()
        Filtro = New Hashtable()

        Filtro.Add("PSCCMPN", cmbCompania.CCMPN_CodigoCompania) 'obligatorio(compañía)
        Filtro.Add("PSCDVSN", cmbDivision.Division) 'obligatorio(división)
        Filtro.Add("PNCPLNDV", cmbPlanta.Planta) 'obligatorio(planta)
        Filtro.Add("PNCCLNT", cmbCliente.pCodigo) 'obligatorio(cliente)
        Filtro.Add("PSTPSRVA", ctbTipoOperacion.SelectedValue.ToString.Trim) 'Tipo (nacional por defecto)

        If cmbEstado.SelectedValue = "0" Then
            Filtro.Add("PSSESTRG", "") 'si esta seleccionado todo enviar vacío sino su valor
        Else
            Filtro.Add("PSSESTRG", cmbEstado.SelectedValue)
        End If
        Filtro.Add("PNNORSCI", Val(txtEmbarque.Text.Trim)) 'si no hay valor enviar cero sino su valor


        'KryptonCheckBox1
        If KryptonCheckBox1.Checked = False Then
            Filtro.Add("PNFECINI_APERTURA", HelpClass.CDate_a_Numero8Digitos(dtpFecIni.Value))  'si no está seleccionado enviar cero sino su valor
            Filtro.Add("PNFECFIN_APERTURA", HelpClass.CDate_a_Numero8Digitos(dtpFecFin.Value)) 'si no está seleccionado enviar cero sino su valor

            Filtro.Add("PNNESTDO", 0)
            Filtro.Add("PNCHK_INICIO", 0)
            Filtro.Add("PNCHK_FIN", 0)
          
        Else
            Filtro.Add("PNFECINI_APERTURA", 0)  'si no está seleccionado enviar cero sino su valor
            Filtro.Add("PNFECFIN_APERTURA", 0) 'si no está seleccionado enviar cero sino su valor

            Filtro.Add("PNNESTDO", KryptonComboBox1.SelectedValue)
            Filtro.Add("PNCHK_INICIO", HelpClass.CDate_a_Numero8Digitos(DateTimePicker1.Value))
            Filtro.Add("PNCHK_FIN", HelpClass.CDate_a_Numero8Digitos(DateTimePicker2.Value))
        End If
     
        If cboLugarorigen.Resultado IsNot Nothing Then
            Filtro.Add("PNCLCLOR", CDec(CType(cboLugarorigen.Resultado, beLocalidad).CLCLD)) 'si no está seleccionado enviar cero sino su valor 
        Else
            Filtro.Add("PNCLCLOR", 0)
        End If
        If cboLugarDestino.Resultado IsNot Nothing Then
            Filtro.Add("PNCLCLDS", CDec(CType(cboLugarDestino.Resultado, beLocalidad).CLCLD))
        Else
            Filtro.Add("PNCLCLDS", 0)
        End If

    End Sub

    Private Function ValidarBusqueda() As String
        Dim cadena = String.Empty
        If cmbCompania.CCMPN_CodigoCompania = String.Empty Then
            cadena = "Seleccione Compañía." & Chr(13)
        End If
        If cmbDivision.Division = String.Empty Then
            cadena = cadena & "Seleccione División." & Chr(13)
        End If
        If cmbPlanta.Planta = 0 Then
            cadena = cadena & "Seleccione Planta." & Chr(13)
        End If
        If cmbCliente.pCodigo = 0 Then
            cadena = cadena & "Seleccione Cliente." & Chr(13)
        End If
        If ctbTipoOperacion.SelectedValue.ToString.Trim = String.Empty Then
            cadena = cadena & "Seleccione Operación." & Chr(13)
        End If

        If cmbMes.Text.Equals("[Seleccione]") Or cmbMes.Text.Equals("") Then
            cadena = cadena & "Seleccione el Mes." & Chr(13)
        End If


        Return cadena
    End Function
    Private Sub cmbCliente_TextChanged() Handles cmbCliente.TextChanged

        Dim PNCCLNT As Decimal = 0
        If Me.cmbCliente.pCodigo > 0 Then
            PNCCLNT = Me.cmbCliente.pCodigo
        Else
            Exit Sub
        End If
        Try
            Dim CCMPN As String = cmbCompania.CCMPN_CodigoCompania
            Dim CDVSN As String = cmbDivision.Division
            Dim oclCheckPoint As New clsCheckPoint
            Dim dtCheckPoint As New DataTable
            dtCheckPoint = oclCheckPoint.Lista_CheckPoint_X_Cliente(PNCCLNT, CCMPN, CDVSN, "L", "A")
            KryptonComboBox1.DataSource = dtCheckPoint
            KryptonComboBox1.DisplayMember = "TCOLUM"
            KryptonComboBox1.ValueMember = "NESTDO"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CargarFiltroFacturacion()
        FiltroFact = New Hashtable
        FiltroFact("PSCCMPN") = cmbCompania.CCMPN_CodigoCompania
        FiltroFact("PSCDVSN") = cmbDivision.Division
        FiltroFact("PNCCLNT") = Me.cmbCliente.pCodigo
        FiltroFact("PSTPSRVA") = ctbTipoOperacion.SelectedValue
        FiltroFact("PNFECINI") = 0
        FiltroFact("PNFECFIN") = 0
        FiltroFact("PNANIO") = CInt(txtAnio.Text)
        FiltroFact("PSMESES") = ListaCodigoMeses()

    End Sub
    'Public Function Cargar_Fac_Operacion() As DataTable
    '    Dim oclsDespachoNacional As New clsDespachoNacional
    '    Dim dt As New DataTable
    '    Dim CCMPN As String = cmbCompania.CCMPN_CodigoCompania
    '    Dim CDVSN As String = cmbDivision.Division
    '    Dim PNCCLNT As Decimal = 0
    '    Dim fechaIni As Decimal = 0
    '    Dim fechaFin As Decimal = 0
    '    'If Me.cmbCliente.pCodigo > 0 Then
    '    PNCCLNT = Me.cmbCliente.pCodigo
    '    'Else
    '    'Exit Function
    '    'End If
    '    Dim meses As String = ListaCodigoMeses()
    '    Dim anio As Integer = CInt(txtAnio.Text)
    '    dgwFacOperacion.AutoGenerateColumns = False
    '    dt = oclsDespachoNacional.LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(CCMPN, CDVSN, PNCCLNT, ctbTipoOperacion.SelectedValue, fechaIni, fechaFin, anio, meses)
    '    'dt.Columns.Add("F_FDCCTC", Type.GetType("System.String"))
    '    'dt.Columns.Add("F_FORSCI", Type.GetType("System.String"))
    '    'For Each Item As DataRow In dt.Rows
    '    '    Item("F_FDCCTC") = HelpClass.CNumero8Digitos_a_FechaDefault(Item("FDCCTC"))
    '    '    Item("F_FORSCI") = HelpClass.CNumero8Digitos_a_FechaDefault(Item("FORSCI"))
    '    'Next




    '    Return dt
    'End Function


    Function ListaCodigoMeses() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbMes.Properties.Items.Item(i).Value & ","
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private dtMes As New DataTable
    Sub Cargar_Mes()
        dtMes.Columns.Add("Codigo", Type.GetType("System.String"))
        dtMes.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtMes.Columns.Add("Abreviado", Type.GetType("System.String"))
        Dim dr As DataRow
        dr = dtMes.NewRow
        dr("Codigo") = "01"
        dr("Descripcion") = "Enero"
        dr("Abreviado") = "ENE"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "02"
        dr("Descripcion") = "Febrero"
        dr("Abreviado") = "FEB"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "03"
        dr("Descripcion") = "Marzo"
        dr("Abreviado") = "MAR"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "04"
        dr("Descripcion") = "Abril"
        dr("Abreviado") = "ABR"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "05"
        dr("Descripcion") = "Mayo"
        dr("Abreviado") = "MAY"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "06"
        dr("Descripcion") = "Junio"
        dr("Abreviado") = "JUN"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "07"
        dr("Descripcion") = "Julio"
        dr("Abreviado") = "JUL"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "08"
        dr("Descripcion") = "Agosto"
        dr("Abreviado") = "AGO"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "09"
        dr("Descripcion") = "Septiembre"
        dr("Abreviado") = "SEP"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "10"
        dr("Descripcion") = "Octubre"
        dr("Abreviado") = "OCT"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "11"
        dr("Descripcion") = "Noviembre"
        dr("Abreviado") = "NOV"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "12"
        dr("Descripcion") = "Diciembre"
        dr("Abreviado") = "DIC"
        dtMes.Rows.Add(dr)

        cmbMes.Properties.DataSource = dtMes
        cmbMes.Properties.ValueMember = "Codigo"
        cmbMes.Properties.DisplayMember = "Descripcion"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Function BuscaCodigoMes(ByVal abrMes As String) As String
        Dim dr() As DataRow
        Dim Cod As String = 0
        dr = dtMes.Select("Abreviado='" & abrMes & "'")
        If dr.Length > 0 Then
            Cod = dr(0)("Codigo")
        End If
        Return Cod
    End Function

    Private Sub cargarMesesDatatable(ByVal dt As DataTable)

        For Each Item As DataRow In dtMes.Rows
            dt.Columns.Add(Item("Abreviado"), Type.GetType("System.Decimal"))
        Next
      
    End Sub


#End Region


    Private Sub KryptonCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonCheckBox1.CheckedChanged
        dtpFecIni.Enabled = Not KryptonCheckBox1.Checked
        dtpFecFin.Enabled = Not KryptonCheckBox1.Checked
        KryptonComboBox1.ComboBox.Enabled = KryptonCheckBox1.Checked
        DateTimePicker1.Enabled = KryptonCheckBox1.Checked
        DateTimePicker2.Enabled = KryptonCheckBox1.Checked
    End Sub


End Class

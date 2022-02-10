Imports RANSA.TYPEDEF.Reportes
Imports Ransa.NEGO
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Public Class frmReporteStockPorfecha

#Region "Declaracion de Variables"
    Private objTemp As TipoDato_ResultaReporte
    Private obeFiltros As New beFiltrosDespachoPorAlmacen
    Private brReportes As New brReporteDS
    Private objReporte As New rptStockFecha
    Private dtReportes As New DataTable
    Private dtRepVolumen As New DataTable
    Private dtRepMetro As New DataTable

    Private dsReportes As New DataSet
#End Region

#Region "Procedimientos y Funciones"
    Private Sub UcCompania_Seleccionar(ByVal obeCompania As RANSA.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = objSeguridadBN.pUsuario
        UcDivision.pActualizar()
    End Sub

    Private Sub pGeneraReporte()

        Dim dtRepFinal As New DataTable
        
        dsReportes = New DataSet

        dtReportes = brReportes.dtRepStockPorFecha(obeFiltros)

        dtRepVolumen = dtReportes.Copy
        dtRepVolumen.Columns.Remove("PESO")
        dtRepVolumen.Columns.Remove("MT2")
        dtRepVolumen.TableName = "DataTableVolumen"

        dtRepMetro = dtReportes.Copy
        dtRepMetro.Columns.Remove("PESO")
        dtRepMetro.Columns.Remove("VOLUMEN")
        dtRepMetro.TableName = "DataTableCuadrado"

        Dim dtv As New DataView(dtReportes)
        dtv.Sort = "FECHA"
        dtRepFinal = dtv.ToTable
        dtRepFinal.Columns.Remove("MT2")
        dtRepFinal.Columns.Remove("VOLUMEN")
        dtRepFinal.TableName = "DataTable1"

        dsReportes.Tables.Add(dtRepFinal.Copy)
        dsReportes.Tables.Add(dtRepVolumen.Copy)
        dsReportes.Tables.Add(dtRepMetro.Copy)

        objTemp = New TipoDato_ResultaReporte

        objTemp.pReporte = objReporte
        objReporte.SetDataSource(dsReportes)

        objReporte.SetParameterValue("Usuario", objSeguridadBN.pUsuario)
        objReporte.SetParameterValue("sCliente", txtCliente.pCodigo & " - " & txtCliente.pRazonSocial)
        objReporte.SetParameterValue("sCompania", UcCompania.CCMPN_Descripcion)
        objReporte.SetParameterValue("sDivision", UcDivision.DivisionDescripcion)
        objReporte.SetParameterValue("sFechaInicio", dtFeInicial.Value.ToShortDateString)
        objReporte.SetParameterValue("sFechaFin", dtFeFinal.Value.ToShortDateString)

        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = objReporte


    End Sub

    Private Function pGeneraVolumen() As DataTable
        Dim dtExcel As New DataTable

        Dim dtPlanta As New DataTable
        Dim drPlanta As DataRow

        Dim dtColumName = New DataTable
        Dim drColumName As DataRow

        Dim objDsExcel As New DataSet

        Dim sPlanta As String = String.Empty
        Dim sFECHAS As String = String.Empty

        Dim nTotalPeso As Decimal = 0
        Dim i As Integer = 0

        dtExcel = dtRepVolumen.Copy
        Dim dtv As New DataView(dtExcel)

        dtv.Sort = "PLANTA"
        dtExcel = dtv.ToTable


        dtColumName.Columns.Add(New DataColumn("ColumName", GetType(String)))
        dtPlanta.Columns.Add(New DataColumn("FECHAS", GetType(Date)))

        For Each dr As DataRow In dtExcel.Rows
            If sPlanta.Trim <> dr("PLANTA").ToString.Trim Then
                dtPlanta.Columns.Add(New DataColumn(dr("PLANTA").ToString.Trim, GetType(String)))

                drColumName = dtColumName.NewRow()
                drColumName("ColumName") = dr("PLANTA").ToString.Trim
                dtColumName.Rows.Add(drColumName)

            End If
            sPlanta = dr("PLANTA").ToString.Trim
        Next
        dtPlanta.Columns.Add(New DataColumn("TOTAL", GetType(String)))

        dtv.Sort = "FECHAS"
        dtExcel = dtv.ToTable



        For Each dr As DataRow In dtExcel.Rows
            If sFECHAS <> dr("FECHAS").ToString.Trim Then
                drPlanta = dtPlanta.NewRow()
                drPlanta("FECHAS") = dr("FECHAS")
                sFECHAS = dr("FECHAS").ToString.Trim
                dtPlanta.Rows.Add(drPlanta)
                nTotalPeso = 0
                For Each drp As DataRow In dtExcel.Select("FECHAS='" & dr("FECHAS") & "'")
                    dtPlanta.Rows(i).Item(drp("PLANTA").ToString.Trim) = drp("VOLUMEN")
                    nTotalPeso = nTotalPeso + drp("VOLUMEN")
                Next
                dtPlanta.Rows(i).Item("TOTAL") = nTotalPeso
                dtPlanta.AcceptChanges()
                i = i + 1
            End If
        Next

        dtPlanta.Columns("FECHAS").ColumnName = "FECHAS"

        For Each dr As DataRow In dtColumName.Rows
            dtPlanta.Columns(dr("ColumName").ToString).ColumnName = dr("ColumName").ToString.Trim
        Next
        dtv = New DataView(dtPlanta)

        dtv.Sort = "FECHAS"
        dtPlanta = dtv.ToTable
        dtPlanta.Columns("TOTAL").ColumnName = "TOTAL"

        dtPlanta.TableName = "Stock_VOLUMEN"
        Return dtPlanta
    End Function

    Private Function pGeneraMT2() As DataTable
        Dim dtExcel As New DataTable

        Dim dtPlanta As New DataTable
        Dim drPlanta As DataRow

        Dim dtColumName = New DataTable
        Dim drColumName As DataRow

        Dim objDsExcel As New DataSet

        Dim sPlanta As String = String.Empty
        Dim sFECHAS As String = String.Empty

        Dim nTotalPeso As Decimal = 0
        Dim i As Integer = 0

        dtExcel = dtRepMetro.Copy
        Dim dtv As New DataView(dtExcel)

        dtv.Sort = "PLANTA"
        dtExcel = dtv.ToTable


        dtColumName.Columns.Add(New DataColumn("ColumName", GetType(String)))
        dtPlanta.Columns.Add(New DataColumn("FECHAS", GetType(Date)))

        For Each dr As DataRow In dtExcel.Rows
            If sPlanta.Trim <> dr("PLANTA").ToString.Trim Then
                dtPlanta.Columns.Add(New DataColumn(dr("PLANTA").ToString.Trim, GetType(String)))

                drColumName = dtColumName.NewRow()
                drColumName("ColumName") = dr("PLANTA").ToString.Trim
                dtColumName.Rows.Add(drColumName)

            End If
            sPlanta = dr("PLANTA").ToString.Trim
        Next
        dtPlanta.Columns.Add(New DataColumn("TOTAL", GetType(String)))

        dtv.Sort = "FECHAS"
        dtExcel = dtv.ToTable



        For Each dr As DataRow In dtExcel.Rows
            If sFECHAS <> dr("FECHAS").ToString.Trim Then
                drPlanta = dtPlanta.NewRow()
                drPlanta("FECHAS") = dr("FECHAS")
                sFECHAS = dr("FECHAS").ToString.Trim
                dtPlanta.Rows.Add(drPlanta)
                nTotalPeso = 0
                For Each drp As DataRow In dtExcel.Select("FECHAS='" & dr("FECHAS") & "'")
                    dtPlanta.Rows(i).Item(drp("PLANTA").ToString.Trim) = drp("MT2")
                    nTotalPeso = nTotalPeso + drp("MT2")
                Next
                dtPlanta.Rows(i).Item("TOTAL") = nTotalPeso
                dtPlanta.AcceptChanges()
                i = i + 1
            End If
        Next

        dtPlanta.Columns("FECHAS").ColumnName = "FECHAS"

        For Each dr As DataRow In dtColumName.Rows
            dtPlanta.Columns(dr("ColumName").ToString).ColumnName = dr("ColumName").ToString.Trim
        Next
        dtv = New DataView(dtPlanta)

        dtv.Sort = "FECHAS"
        dtPlanta = dtv.ToTable
        dtPlanta.Columns("TOTAL").ColumnName = "TOTAL"
        dtPlanta.TableName = "Stock_MT2"
        Return dtPlanta
    End Function
#End Region

#Region "Eventos de Control"
    Private Sub frmReporteStockPorFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim intTemp As Int64 = 0

        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        UcCompania.Usuario = objSeguridadBN.pUsuario
        UcCompania.pActualizar()

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If txtCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese Cliente", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        pcxEspera.Visible = True
        pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
        pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)
        crvReporte.Visible = False


        tsbExportarExcel.Enabled = False

        obeFiltros.PSCCMPN = UcCompania.CCMPN_CodigoCompania
        obeFiltros.PSCDVSN = UcDivision.Division
        obeFiltros.PNCCLNT = txtCliente.pCodigo
        obeFiltros.PNFECINI = dtFeInicial.Value
        obeFiltros.PNFECFIN = dtFeFinal.Value
        obeFiltros.PNCANDIA = DateDiff(DateInterval.Day, Date.Parse(dtFeInicial.Value), dtFeFinal.Value) + 1
        obeFiltros.PSUSUARIO = objSeguridadBN.pUsuario
        bgwGifAnimado.RunWorkerAsync()


    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        tsbExportarExcel.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

        Dim dtExcel As New DataTable

        Dim dtPlanta As New DataTable
        Dim drPlanta As DataRow

        Dim dtColumName = New DataTable
        Dim drColumName As DataRow

        Dim objDsExcel As New DataSet

        Dim sPlanta As String = String.Empty
        Dim sFECHAS As String = String.Empty

        Dim nTotalPeso As Decimal = 0
        Dim i As Integer = 0

        dtExcel = dtReportes.Copy
        Dim dtv As New DataView(dtExcel)

        dtv.Sort = "PLANTA"
        dtExcel = dtv.ToTable


        dtColumName.Columns.Add(New DataColumn("ColumName", GetType(String)))
        dtPlanta.Columns.Add(New DataColumn("FECHAS", GetType(Date)))

        For Each dr As DataRow In dtExcel.Rows
            If sPlanta.Trim <> dr("PLANTA").ToString.Trim Then
                dtPlanta.Columns.Add(New DataColumn(dr("PLANTA").ToString.Trim, GetType(String)))

                drColumName = dtColumName.NewRow()
                drColumName("ColumName") = dr("PLANTA").ToString.Trim
                dtColumName.Rows.Add(drColumName)

            End If
            sPlanta = dr("PLANTA").ToString.Trim
        Next
        dtPlanta.Columns.Add(New DataColumn("TOTAL", GetType(String)))

        dtv.Sort = "FECHAS"
        dtExcel = dtv.ToTable



        For Each dr As DataRow In dtExcel.Rows
            If sFECHAS <> dr("FECHAS").ToString.Trim Then
                drPlanta = dtPlanta.NewRow()
                drPlanta("FECHAS") = dr("FECHAS")
                sFECHAS = dr("FECHAS").ToString.Trim
                dtPlanta.Rows.Add(drPlanta)
                nTotalPeso = 0
                For Each drp As DataRow In dtExcel.Select("FECHAS='" & dr("FECHAS") & "'")
                    dtPlanta.Rows(i).Item(drp("PLANTA").ToString.Trim) = drp("PESO")
                    nTotalPeso = nTotalPeso + drp("PESO")
                Next
                dtPlanta.Rows(i).Item("TOTAL") = nTotalPeso
                dtPlanta.AcceptChanges()
                i = i + 1
            End If
        Next



        dtPlanta.Columns("FECHAS").ColumnName = "FECHAS"

        For Each dr As DataRow In dtColumName.Rows
            dtPlanta.Columns(dr("ColumName").ToString).ColumnName = dr("ColumName").ToString.Trim
        Next
        dtv = New DataView(dtPlanta)

        dtv.Sort = "FECHAS"
        dtPlanta = dtv.ToTable
        dtPlanta.Columns("TOTAL").ColumnName = "TOTAL"


        objDsExcel.Tables.Add(dtPlanta)
        objDsExcel.Tables.Add(pGeneraVolumen())
        objDsExcel.Tables.Add(pGeneraMT2())

        dtPlanta.TableName = "Stock_PESOS"
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Reporte de Stock por Fechas \n")
        strlTitulo.Add("Cliente :\n" & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Compañia :\n" & UcCompania.CCMPN_Descripcion)
        strlTitulo.Add("División :\n" & UcDivision.DivisionDescripcion)
        strlTitulo.Add("Fecha Inicio :\n" & dtFeInicial.Value.ToShortDateString)
        strlTitulo.Add("Fecha Fin :\n" & dtFeFinal.Value.ToShortDateString)

        Dim mlistas As New Hashtable
        mlistas.Add("Total1", 2)
        mlistas.Add("Total2", 3)
        mlistas.Add("Total3", 4)
        mlistas.Add("Total4", 5)
        mlistas.Add("Total5", 6)
        HelpClass.ExportExcelConTitulos(objDsExcel, strlTitulo, mlistas)



    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pGeneraReporte()
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region



End Class

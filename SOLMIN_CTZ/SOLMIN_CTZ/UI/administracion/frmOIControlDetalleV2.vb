Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO

Public Class frmOIControlDetalleV2
    Private oOIControlNeg As New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
    Private oOIControlEnt As New SOLMIN_CTZ.Entidades.OrdenInternaControl
    Private oEstadoNeg As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private oDtOI As New DataTable
    Private bolBuscar As Boolean
    Private bolIniciaCarga As Boolean = True
    Private bolPaginar As Boolean = False

    Public Sub New(ByVal oOIControl As OrdenInternaControl)
        InitializeComponent()
        'CARGAMOS EL DATAGRID
        oOIControlEnt = oOIControl
        cargaDtgOIDetalles(oOIControlEnt)
    End Sub
    Private Sub cargaDtgOIDetalles(ByVal oOIControl As OrdenInternaControl)
        If bolPaginar = False Then UcPaginacion1.PageNumber = 1
        '----------------CONSULTA INICIAL------------------
        If bolIniciaCarga = True Then
            Dim oDtFiltro As DataTable = oOIControlNeg.Lista_OI_Control_Detalles_V2(oOIControl)
            If Not oDtOI Is Nothing Then oDtOI.Rows.Clear()
            oDtOI = oDtFiltro.Copy
            bolIniciaCarga = False
        End If
        '---------------CANTIDAD DE PAGINAS----------------
        UcPaginacion1.PageCount = HelpClass.num_paginas(oDtOI, UcPaginacion1.PageSize)
        '-----------------PAGINACION------------------------
        Dim oDt2 As New DataTable
        oDt2.Rows.Clear()
        Dim pagIni As Integer = 0
        Dim pagFin As Integer = 0
        pagIni = (UcPaginacion1.PageNumber - 1) * (UcPaginacion1.PageSize) + 1
        pagFin = UcPaginacion1.PageNumber * UcPaginacion1.PageSize
        oDt2 = HelpClass.paginarDataDridView(oDtOI, pagIni - 1, pagFin - 1)

        dtgOrdenInternaDetalles.AutoGenerateColumns = False
        dtgOrdenInternaDetalles.DataSource = oDt2
    End Sub
    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        bolPaginar = True
        cargaDtgOIDetalles(oOIControlEnt)
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim ListDt As New List(Of DataTable)
        Dim odtReporte As New DataTable
        odtReporte = oDtOI.Copy
        odtReporte.Columns.Remove("ZSTALIB")
        odtReporte.Columns.Remove("ZSTACIE")
        odtReporte.Columns.Remove("ZSTAFI")
        odtReporte.Columns.Remove("CCLORI")
        odtReporte.Columns.Remove("NPLNMT")
        odtReporte.Columns.Remove("NDCMFC")
        '---------Se cambia el nombre de la Cabecera----------
        odtReporte.Columns(0).ColumnName = "NRO OPERACION"
        odtReporte.Columns(1).ColumnName = "NRO ORDEN INTERNA"
        odtReporte.Columns(2).ColumnName = "ESTADO"
        odtReporte.Columns(3).ColumnName = "COSTO"
        odtReporte.Columns(4).ColumnName = "VENTA"
        odtReporte.Columns(5).ColumnName = "FECHA"


        ListDt.Add(odtReporte)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(ListDt, "Detalle Control de ordenes Internas")

        odtReporte.Dispose()
        odtReporte.Clear()
        ListDt.Clear()
    End Sub
End Class

Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO

Public Class frmOrdenInternaControlDetalles
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
        cargaDtgOIDetalles(oOIControl)
    End Sub
    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        bolPaginar = True
        cargaDtgOIDetalles(oOIControlEnt)
    End Sub
    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.Show()
    End Sub
    Private Sub cargaDtgOIDetalles(ByVal oOIControl As OrdenInternaControl)

        If bolPaginar = False Then
            UcPaginacion1.PageNumber = 1
        End If
        Me.dtgOrdenInternaDetalles.Rows.Clear()
        Dim intCont As Integer
        Dim oDt As New DataTable
        If UcPaginacion1.PageCount = 0 Then
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            Dim dtOIControl As New DataTable
            proceso_espera.Start()
            If oOIControl.ESTADO_DETALLE = "PELI" Or oOIControl.ESTADO_DETALLE = "PECT" Or oOIControl.ESTADO_DETALLE = "PECI" Or oOIControl.ESTADO_DETALLE = "PESE" Then
                oDt = oOIControlNeg.Lista_OI_Control_Detalles(oOIControl)
            Else
                oDt = oOIControlNeg.Lista_OI_Control_Detalles_2(oOIControl)
            End If
            proceso_espera.Abort()
        End If
        If UcPaginacion1.PageSize <> oOIControl.PageSize Then
            UcPaginacion1.PageCount = HelpClass.num_paginas(oDtOI, UcPaginacion1.PageSize)
            oOIControl.PageSize = UcPaginacion1.PageSize
        End If
        '---
        If bolIniciaCarga = True Then
            oDtOI = HelpClass.paginarDataDridView(oDt, 0, oDt.Rows.Count - 1)
            UcPaginacion1.PageCount = HelpClass.num_paginas(oDt, UcPaginacion1.PageSize)
            oOIControl.PageSize = UcPaginacion1.PageSize
            bolIniciaCarga = False
        End If
        '---------
        Dim oDt2 As New DataTable
        oDt2.Rows.Clear()
        Dim pagIni As Integer = 0
        Dim pagFin As Integer = 0
        pagIni = (UcPaginacion1.PageNumber - 1) * (UcPaginacion1.PageSize) + 1
        pagFin = UcPaginacion1.PageNumber * UcPaginacion1.PageSize
        oDt2 = HelpClass.paginarDataDridView(oDtOI, pagIni - 1, pagFin - 1)

        For intCont = 0 To oDt2.Rows.Count - 1
            Agrega_Row_OI_Detalle()
            With Me.dtgOrdenInternaDetalles
                'Indicar los nombres de las columnas              
                .Rows(intCont).Cells("NORINS").Value = oDt2.Rows(intCont).Item("NORINS")
                .Rows(intCont).Cells("NOPRCN").Value = oDt2.Rows(intCont).Item("NOPRCN")
                .Rows(intCont).Cells("FINCOP").Value = HelpClass.FormatoFecha(IIf(IsDBNull(oDt2.Rows(intCont).Item("FINCOP")), "", oDt2.Rows(intCont).Item("FINCOP")))
                If oDt2.Rows(intCont).Item("VENTA").ToString.Trim = "" Then
                    .Rows(intCont).Cells("VENTA").Value = 0
                Else
                    .Rows(intCont).Cells("VENTA").Value = Format(CType(oDt2.Rows(intCont).Item("VENTA"), Double), "###,###,###,##0.00")
                End If
                If oDt2.Rows(intCont).Item("GASTO").ToString.Trim = "" Then
                    .Rows(intCont).Cells("COSTO").Value = 0
                Else
                    .Rows(intCont).Cells("COSTO").Value = Format(CType(oDt2.Rows(intCont).Item("GASTO").ToString.Trim, Double), "###,###,###,##0.00")
                End If
                .Rows(intCont).Cells("SESTOP").Value = oDt2.Rows(intCont).Item("SESTOP")

                'If intCont = 0 Then
                '    Me.UcPaginacion1.PageCount = UcPaginacion1.PageCount
                'End If
            End With
        Next intCont
    End Sub
    Private Sub Agrega_Row_OI_Detalle()
        Dim oDrVw As New DataGridViewRow
        oDrVw.CreateCells(Me.dtgOrdenInternaDetalles)
        Me.dtgOrdenInternaDetalles.Rows.Add(oDrVw)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        'Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "006"

        Dim dtNuevo As New DataTable
        dtNuevo = oDtOI.Clone
        'Eliminamos Columnas que no se usaran
        dtNuevo.Columns.Remove("CCMPN")
        dtNuevo.Columns.Remove("CDVSN")
        dtNuevo.Columns.Remove("CPLNDV")
        dtNuevo.Columns.Remove("CFAOAB")
        dtNuevo.Columns.Remove("CFAOLI")
        dtNuevo.Columns.Remove("CFAOCT")
        dtNuevo.Columns.Remove("CFAOCE")
        dtNuevo.Columns.Remove("TRFSRC")
        dtNuevo.Columns.Remove("NPLNMT")
        dtNuevo.Columns.Remove("CSCDSP")
        dtNuevo.Columns.Remove("ROWNUMBER")
        dtNuevo.Columns.Remove("CCLORI")
        dtNuevo.Columns.Remove("CTPDCF")
        dtNuevo.Columns.Remove("FTRMOP")
        dtNuevo.Columns.Remove("FDCPRF")
        dtNuevo.Columns.Remove("ITPCMT")
        dtNuevo.Columns.Remove("NDCMFC")

        dtNuevo.Columns.Remove("NDCPRF")
        dtNuevo.Columns.Remove("NORSRT")

        'Cambiamos de tipo de dato a las Fechas
        dtNuevo.Columns(0).DataType = GetType(String)
        dtNuevo.Columns(1).DataType = GetType(String)
        dtNuevo.Columns(2).DataType = GetType(String)
        dtNuevo.Columns(3).DataType = GetType(String)
        dtNuevo.Columns(4).DataType = GetType(String)
        dtNuevo.Columns(5).DataType = GetType(String)

        'Agegamos datos Filtro
        Dim filaNueva As DataRow
        '----------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Compania:"
        filaNueva(1) = oOIControlEnt.CCMPN_DESC
        dtNuevo.Rows.Add(filaNueva)
        '-----------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Division:"
        filaNueva(1) = oOIControlEnt.CDVSN_DESC
        dtNuevo.Rows.Add(filaNueva)
        '------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Planta:"
        filaNueva(1) = oOIControlEnt.CPLNDV_DESC
        dtNuevo.Rows.Add(filaNueva)
        '-------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Desde: " & HelpClass.FormatoFecha(oOIControlEnt.F_INICIO)
        filaNueva(1) = "Hasta: " & HelpClass.FormatoFecha(oOIControlEnt.F_FINAL)
        dtNuevo.Rows.Add(filaNueva)
        '-------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "NRO ORDEN INTERNA"
        filaNueva(1) = "NRO OPERACION"
        filaNueva(2) = "FECHA"
        filaNueva(3) = "ESTADO"
        filaNueva(4) = "VENTA"
        filaNueva(5) = "COSTO"

        dtNuevo.Rows.Add(filaNueva)

        For i As Integer = 0 To oDtOI.Rows.Count - 1
            If Not (i > (oDtOI.Rows.Count - 1)) Then
                dtNuevo.ImportRow(oDtOI.Rows(i))
                dtNuevo.Rows(i + 5).Item("FINCOP") = HelpClass.FormatoFecha(dtNuevo.Rows(i + 5).Item("FINCOP").ToString.Trim)
            End If
        Next


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dtNuevo.Rows.Count > 1 Then
            Dim list As New List(Of DataTable)
            List.Add(dtNuevo)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel(list, strReporteseleccionado)
        Else
            HelpClass.MsgBox("No hay Registros para exportar")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class frmMovimientoAT


    Private _pCCMPN As String
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property


    Private _pCodClientes As String
    Public Property pCodClientes() As String
        Get
            Return _pCodClientes
        End Get
        Set(ByVal value As String)
            _pCodClientes = value
        End Set
    End Property



    Private _pTipoMov As String
    Public Property pTipoMov() As String
        Get
            Return _pTipoMov
        End Get
        Set(ByVal value As String)
            _pTipoMov = value
        End Set
    End Property

    Private Sub frmMovimientoDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Movimiento Almacén Simple
        UcDivision.Compania = pCCMPN
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()
        If _pTipoMov = "RECEPCION" Then
            Me.Text = "Recepción Almacén Tránsito"
        Else
            Me.Text = "Despacho Almacén Tránsito"
        End If

    End Sub

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        pcxEspera.Visible = True
        bgwGifAnimado.RunWorkerAsync()
        tsbExportar.Enabled = False
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub


    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork

        If _pTipoMov = "RECEPCION" Then
            pReporteStockProductoR01()
        Else
            pReporteDespachoPorAlmacen()
        End If

    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        tsbExportar.Enabled = True
    End Sub


    Private Sub pReporteStockProductoR01()
        Dim obrResumenMensualAlm As New clsResumenMensualAlmacenes
        Dim obeFiltro As New ResumenMensualAlmacenes

        Dim intIsInventarioActual As Integer = 1
        Dim strMensaje As String = String.Empty
        Dim DtReporte As New DataTable
        Try
            With obeFiltro
                .PSCCLNT = pCodClientes
                .PSCCMPN = pCCMPN
                .PSCDVSN = UcDivision.Division
                .PNFECINV = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
                .PNFECFIN = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)
            End With

            DtReporte = obrResumenMensualAlm.fodtMovimientosIngSATResumenMensual(obeFiltro)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
        
        Try
            Dim oDtExcel As New DataTable
            If rbtOrdenDeCompra.Checked Then
                oDtExcel = EliminarRepetido(DtReporte)
                ExportarExcelOC(oDtExcel)
            ElseIf rbtItem.Checked Then

                ExportarExcelItem(DtReporte)
            Else
                ExportarExcelSubItem(DtReporte)
            End If

        Catch : End Try

    End Sub

    Private Sub pReporteDespachoPorAlmacen()
        Dim dtTemp As DataTable
        Dim obeFiltro As New ResumenMensualAlmacenes
        Dim obrReporteAT As New clsResumenMensualAlmacenes

        With obeFiltro
            .PSCCLNT = pCodClientes
            .PNFECINV = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
            .PNFECFIN = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)
            .PSCCMPN = pCCMPN
            .PSCDVSN = Me.UcDivision.Division
        End With
        dtTemp = obrReporteAT.fodtMovimientosSalidaSATResumenMensual(obeFiltro)
        Try
            Dim oDtExcel As New DataTable
            If rbtOrdenDeCompra.Checked Then
                oDtExcel = EliminarRepetidoDespacho(dtTemp)
                ExportarExcelOCDespacho(oDtExcel)
            ElseIf rbtItem.Checked Then
                ExportarExcelItemDespacho(dtTemp)
            Else
                ExportarExcelSubItemDespacho(dtTemp)
            End If

        Catch : End Try
    End Sub
   
    Private Sub ExportarExcelItem(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        Dim oDs As New DataSet
        oDt = oDtExcel.Copy
        Dim objListdt As New List(Of DataTable)
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TPLNTA").ColumnName = "PLANTA"
        oDt.Columns("TIPO_ALMACEN").ColumnName = "TIPO DE ALMACEN"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("FREFFW").ColumnName = "FECHA"
        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDt.Columns("QPSOBL").ColumnName = "PESO"
        oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        oDt.Columns("NORCML").ColumnName = "N° O/C"
        oDt.Columns("TTINTC").ColumnName = "INCONTERM"
        oDt.Columns("DSREFE").ColumnName = "REFERENCIA"
        oDt.Columns("NRITOC").ColumnName = "ITEM "
        oDt.Columns("TCITCL").ColumnName = "COD. CLIENTE"
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM "
        oDt.Columns("QBLTSR").ColumnName = "CANT. ITEM"
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM"
        oDt.Columns("TUNDCN").ColumnName = "UNIDAD  "
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        oDt.Columns("SSTINV").ColumnName = "ESTADO"
        oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        oDt.Columns("FSLFFW").ColumnName = "FECHA SALIDA"
        oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
        oDt.Columns.Remove("CMEDTS")
        oDt.Columns.Remove("CMEDTC")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")

        oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO "
        oDt.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
        oDt.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
        oDt.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"
        oDs.Tables.Add(oDt)

        Dim strlTitulo As New List(Of String)

        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub
    Private Sub ExportarExcelSubItem(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        Dim oDs As New DataSet
        oDt = GeneraDataTableSubItem(oDtExcel.Copy)
        'oDt = oDtExcel.Copy
        Dim objListdt As New List(Of DataTable)
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TPLNTA").ColumnName = "PLANTA"
        oDt.Columns("TIPO_ALMACEN").ColumnName = "TIPO DE ALMACEN"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("FREFFW").ColumnName = "FECHA"
        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDt.Columns("QPSOBL").ColumnName = "PESO"
        oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        oDt.Columns("QAROCP").ColumnName = "AREA OCUPADA"
        oDt.Columns("NORCML").ColumnName = "N° O/C"
        oDt.Columns("TTINTC").ColumnName = "INCONTERM"
        oDt.Columns("DSREFE").ColumnName = "REFERENCIA"
        oDt.Columns("NRITOC").ColumnName = "ITEM "
        oDt.Columns("TCITCL").ColumnName = "COD. CLIENTE"
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM "
        oDt.Columns("QBLTSR").ColumnName = "CANT. ITEM"
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM"
        oDt.Columns("TUNDCN").ColumnName = "UNIDAD  "
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        oDt.Columns("SSTINV").ColumnName = "ESTADO"
        oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        oDt.Columns("FSLFFW").ColumnName = "FECHA SALIDA"
        oDt.Columns.Remove("CMEDTS")
        oDt.Columns.Remove("CMEDTC")
        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO "

        oDt.Columns("SBITOC").ColumnName = "SUBITEM"
        oDt.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        oDt.Columns("TDITES1").ColumnName = "DESCRIPCION"
        oDt.Columns("QCNRCP").ColumnName = "CANTIDAD "

        oDs.Tables.Add(oDt)

        oDt.Columns.Remove("TCTCST")
        oDt.Columns.Remove("TCTCSA")
        oDt.Columns.Remove("TCTCSF")

        Dim strlTitulo As New List(Of String)

        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub

    Private Function GeneraDataTableSubItem(ByVal oDtSubItem As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim bolBultosIguales As Boolean = False

        oDtAux = oDtSubItem.Copy
        For i As Integer = oDtAux.Rows.Count - 1 To 1 Step -1
            bolBultosIguales = False
            If oDtAux.Rows(i).Item("CCLNT").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CCLNT").ToString.Trim) And _
            oDtAux.Rows(i).Item("TCMPCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TCMPCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TPLNTA").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TPLNTA").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUBRFR").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUBRFR").ToString.Trim) And _
            oDtAux.Rows(i).Item("CREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("QREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("TIPBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TIPBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QPSOBL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QPSOBL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNPSO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNPSO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNVOL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNVOL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TPRVCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TPRVCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("NGRPRV").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NGRPRV").ToString.Trim) And _
            oDtAux.Rows(i).Item("QAROCP").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QAROCP").ToString.Trim) And _
            oDtAux.Rows(i).Item("NORCML").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NORCML").ToString.Trim) Then
                oDtAux.Rows(i).Item("CCLNT") = DBNull.Value
                oDtAux.Rows(i).Item("TCMPCL") = DBNull.Value
                oDtAux.Rows(i).Item("TPLNTA") = DBNull.Value
                oDtAux.Rows(i).Item("TUBRFR") = DBNull.Value
                oDtAux.Rows(i).Item("ZONA") = DBNull.Value
                oDtAux.Rows(i).Item("FREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("CREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("QREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("TIPBTO") = DBNull.Value
                oDtAux.Rows(i).Item("QPSOBL") = DBNull.Value
                oDtAux.Rows(i).Item("TUNPSO") = DBNull.Value
                oDtAux.Rows(i).Item("QVLBTO") = DBNull.Value
                oDtAux.Rows(i).Item("TUNVOL") = DBNull.Value
                oDtAux.Rows(i).Item("TPRVCL") = DBNull.Value
                oDtAux.Rows(i).Item("NGRPRV") = DBNull.Value
                oDtAux.Rows(i).Item("QAROCP") = DBNull.Value
                oDtAux.Rows(i).Item("NORCML") = DBNull.Value
                oDtAux.Rows(i).Item("TTINTC") = DBNull.Value

                bolBultosIguales = True
            End If



            If oDtAux.Rows(i).Item("NRITOC").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NRITOC").ToString.Trim) And _
            oDtAux.Rows(i).Item("TCITCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TCITCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TDITES").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TDITES").ToString.Trim) And _
            oDtAux.Rows(i).Item("QBLTSR").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QBLTSR").ToString.Trim) And _
            oDtAux.Rows(i).Item("QPEPQT").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QPEPQT").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNDCN").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNDCN").ToString.Trim) And _
            oDtAux.Rows(i).Item("TLUGEN").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TLUGEN").ToString.Trim) And _
            oDtAux.Rows(i).Item("NGUIRM").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NGUIRM").ToString.Trim) And _
            oDtAux.Rows(i).Item("FREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("FREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("TNMMDT_ENVIO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TNMMDT_ENVIO").ToString.Trim) And _
            bolBultosIguales Then

                oDtAux.Rows(i).Item("NRITOC") = DBNull.Value
                oDtAux.Rows(i).Item("TCITCL") = DBNull.Value
                oDtAux.Rows(i).Item("TDITES") = DBNull.Value
                oDtAux.Rows(i).Item("QBLTSR") = DBNull.Value
                oDtAux.Rows(i).Item("QPEPQT") = DBNull.Value
                oDtAux.Rows(i).Item("TUNDCN") = DBNull.Value
                oDtAux.Rows(i).Item("TLUGEN") = DBNull.Value
                oDtAux.Rows(i).Item("SSTINV") = DBNull.Value
                oDtAux.Rows(i).Item("NGUIRM") = DBNull.Value
                oDtAux.Rows(i).Item("FSLFFW") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCST") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSA") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSF") = DBNull.Value
                oDtAux.Rows(i).Item("TNMMDT_ENVIO") = DBNull.Value
                oDtAux.Rows(i).Item("DSREFE") = DBNull.Value

            End If
            oDtAux.AcceptChanges()
        Next

        Return oDtAux
    End Function


    Private Function GeneraDataTableSubItemDes(ByVal oDtSubItem As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim bolBultosIguales As Boolean = False

        oDtAux = oDtSubItem.Copy
        For i As Integer = oDtAux.Rows.Count - 1 To 1 Step -1
            bolBultosIguales = False
            If oDtAux.Rows(i).Item("CCLNT").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CCLNT").ToString.Trim) And _
            oDtAux.Rows(i).Item("TCMPCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TCMPCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("PLANTA").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("PLANTA").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUBRFR").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUBRFR").ToString.Trim) And _
            oDtAux.Rows(i).Item("CREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("QREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("TIPBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TIPBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QPSOBL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QPSOBL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNPSO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNPSO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNVOL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNVOL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TPRVCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TPRVCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("NGRPRV").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NGRPRV").ToString.Trim) And _
            oDtAux.Rows(i).Item("QAROCP").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QAROCP").ToString.Trim) And _
            oDtAux.Rows(i).Item("NORCML").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NORCML").ToString.Trim) Then
                oDtAux.Rows(i).Item("CCLNT") = DBNull.Value
                oDtAux.Rows(i).Item("TCMPCL") = DBNull.Value
                oDtAux.Rows(i).Item("PLANTA") = DBNull.Value
                oDtAux.Rows(i).Item("TUBRFR") = DBNull.Value
                oDtAux.Rows(i).Item("ZONA") = DBNull.Value
                oDtAux.Rows(i).Item("FSLFFW") = DBNull.Value
                oDtAux.Rows(i).Item("CREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("QREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("TIPBTO") = DBNull.Value
                oDtAux.Rows(i).Item("QPSOBL") = DBNull.Value
                oDtAux.Rows(i).Item("TUNPSO") = DBNull.Value
                oDtAux.Rows(i).Item("QVLBTO") = DBNull.Value
                oDtAux.Rows(i).Item("TUNVOL") = DBNull.Value
                oDtAux.Rows(i).Item("TPRVCL") = DBNull.Value
                oDtAux.Rows(i).Item("NGRPRV") = DBNull.Value
                oDtAux.Rows(i).Item("QAROCP") = DBNull.Value
                oDtAux.Rows(i).Item("NORCML") = DBNull.Value
                oDtAux.Rows(i).Item("TTINTC") = DBNull.Value

                bolBultosIguales = True
            End If



            If oDtAux.Rows(i).Item("NRITOC").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NRITOC").ToString.Trim) And _
            oDtAux.Rows(i).Item("TCITCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TCITCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TDITES").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TDITES").ToString.Trim) And _
            oDtAux.Rows(i).Item("QBLTSR").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QBLTSR").ToString.Trim) And _
            oDtAux.Rows(i).Item("QPEPQT").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QPEPQT").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNDCN").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNDCN").ToString.Trim) And _
            oDtAux.Rows(i).Item("TLUGEN").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TLUGEN").ToString.Trim) And _
            oDtAux.Rows(i).Item("NGUIRM").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NGUIRM").ToString.Trim) And _
            oDtAux.Rows(i).Item("FSLFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("FSLFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("TNMMDT_ENVIO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TNMMDT_ENVIO").ToString.Trim) And _
            bolBultosIguales Then

                oDtAux.Rows(i).Item("NRITOC") = DBNull.Value
                oDtAux.Rows(i).Item("TCITCL") = DBNull.Value
                oDtAux.Rows(i).Item("TDITES") = DBNull.Value
                oDtAux.Rows(i).Item("QBLTSR") = DBNull.Value
                oDtAux.Rows(i).Item("QPEPQT") = DBNull.Value
                oDtAux.Rows(i).Item("TUNDCN") = DBNull.Value
                oDtAux.Rows(i).Item("TLUGEN") = DBNull.Value
                oDtAux.Rows(i).Item("SSTINV") = DBNull.Value
                oDtAux.Rows(i).Item("NGUIRM") = DBNull.Value
                oDtAux.Rows(i).Item("FSLFFW") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCST") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSA") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSF") = DBNull.Value
                oDtAux.Rows(i).Item("TNMMDT_ENVIO") = DBNull.Value
                oDtAux.Rows(i).Item("DSREFE") = DBNull.Value

            End If
            oDtAux.AcceptChanges()
        Next

        Return oDtAux
    End Function

    Private Sub ExportarExcelOC(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet

        'Eliminado
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("QBLTSR")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("TUNDCN")
        oDt.Columns.Remove("CMEDTS")
        oDt.Columns.Remove("CMEDTC")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")

        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TPLNTA").ColumnName = "PLANTA"
        oDt.Columns("TIPO_ALMACEN").ColumnName = "TIPO DE ALMACEN"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("FREFFW").ColumnName = "FECHA"
        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDt.Columns("QPSOBL").ColumnName = "PESO"
        oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
        oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        oDt.Columns("DSREFE").ColumnName = "REFERENCIA"
        oDt.Columns("NORCML").ColumnName = "N° O/C"
        oDt.Columns("TTINTC").ColumnName = "INCONTERM"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        oDt.Columns("SSTINV").ColumnName = "ESTADO"
        oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        oDt.Columns("FSLFFW").ColumnName = "FECHA SALIDA"
        oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO "
        oDt.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
        oDt.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
        oDt.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"
        oDs.Tables.Add(oDt)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub
    Private Function EliminarRepetido(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CCLNT,CREFFW ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CCLNT").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CCLNT").ToString.Trim) And dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function
#Region "SAT-Despacho"
    Private Sub ExportarExcelOCDespacho(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet

        'Eliminado
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("QBLTSR")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("TUNDCN")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")


        'Renombramos las columnas para exportar al excel
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("FSLFFW").ColumnName = "FECHA"
        oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        oDt.Columns("TCMTRT").ColumnName = "TRANSPORTISTA"
        oDt.Columns("NPLCCM").ColumnName = "PLACA"
        oDt.Columns("TABDES").ColumnName = "TIPO TRACTO"
        oDt.Columns("NPLACP").ColumnName = "ACOPLADO"
        oDt.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"
        oDt.Columns("TNMBCH").ColumnName = "CHOFER"
        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDt.Columns("QPSOBL").ColumnName = "PESO "
        oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
        oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        oDt.Columns("NORCML").ColumnName = "N° O/C	"
        oDt.Columns("TTINTC").ColumnName = "INCONTERM"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO"
        oDt.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
        oDt.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
        oDt.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"

        oDs.Tables.Add(oDt)
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)

    End Sub
    Private Function EliminarRepetidoDespacho(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CREFFW ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
            'And dtTemp.Rows(i).Item("CORRELATIVO").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CORRELATIVO").ToString.Trim)
        Next
        Return dtTemp
    End Function
    Private Sub ExportarExcelSubItemDespacho(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        'oDt = oDtExcel.Copy
        Dim oDs As New DataSet

        oDt = GeneraDataTableSubItemDes(oDtExcel)
        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("TCTCST")
        oDt.Columns.Remove("TCTCSA")
        oDt.Columns.Remove("TCTCSF")
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("FSLFFW").ColumnName = "FECHA"
        oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        oDt.Columns("TCMTRT").ColumnName = "TRANSPORTISTA"
        oDt.Columns("NPLCCM").ColumnName = "PLACA"
        oDt.Columns("TABDES").ColumnName = "TIPO TRACTO"
        oDt.Columns("NPLACP").ColumnName = "ACOPLADO"
        oDt.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"
        oDt.Columns("TNMBCH").ColumnName = "CHOFER"
        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDt.Columns("QPSOBL").ColumnName = "PESO "
        oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
        oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        oDt.Columns("NORCML").ColumnName = "N° O/C	"
        oDt.Columns("TTINTC").ColumnName = "INCONTERM"
        oDt.Columns("NRITOC").ColumnName = "ITEM "
        oDt.Columns("TCITCL").ColumnName = "COD. CLIENTE "
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM "
        oDt.Columns("QBLTSR").ColumnName = "CANT. ITEM "
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM "
        oDt.Columns("TUNDCN").ColumnName = "UNIDAD  "
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO"
        'oDt.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
        'oDt.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
        'oDt.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"

        oDt.Columns("SBITOC").ColumnName = "SUBITEM"
        oDt.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        oDt.Columns("TDITES1").ColumnName = "DESCRIPCION"
        oDt.Columns("QCNRCP").ColumnName = "CANTIDAD "

        oDs.Tables.Add(oDt)
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub
    Private Function GeneraDataTableSubItemDespacho(ByVal oDtSubItem As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim bolBultosIguales As Boolean = False

        oDtAux = oDtSubItem.Copy
        For i As Integer = oDtAux.Rows.Count - 1 To 1 Step -1
            bolBultosIguales = False
            If oDtAux.Rows(i).Item("CCLNT").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CCLNT").ToString.Trim) And _
            oDtAux.Rows(i).Item("TCMPCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TCMPCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUBRFR").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUBRFR").ToString.Trim) And _
            oDtAux.Rows(i).Item("CREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("QREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("TIPBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TIPBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QPSOBL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QPSOBL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNPSO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNPSO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNVOL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNVOL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TPRVCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TPRVCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("NGRPRV").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NGRPRV").ToString.Trim) And _
            oDtAux.Rows(i).Item("QAROCP").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QAROCP").ToString.Trim) And _
            oDtAux.Rows(i).Item("NORCML").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NORCML").ToString.Trim) Then

                oDtAux.Rows(i).Item("CCLNT") = DBNull.Value
                oDtAux.Rows(i).Item("TCMPCL") = DBNull.Value
                oDtAux.Rows(i).Item("TUBRFR") = DBNull.Value
                oDtAux.Rows(i).Item("FSLDAL") = DBNull.Value
                oDtAux.Rows(i).Item("CREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("QREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("TIPBTO") = DBNull.Value
                oDtAux.Rows(i).Item("QPSOBL") = DBNull.Value
                oDtAux.Rows(i).Item("TUNPSO") = DBNull.Value
                oDtAux.Rows(i).Item("QVLBTO") = DBNull.Value
                oDtAux.Rows(i).Item("TUNVOL") = DBNull.Value
                oDtAux.Rows(i).Item("TPRVCL") = DBNull.Value
                oDtAux.Rows(i).Item("NGRPRV") = DBNull.Value
                oDtAux.Rows(i).Item("QAROCP") = DBNull.Value
                oDtAux.Rows(i).Item("NORCML") = DBNull.Value
                oDtAux.Rows(i).Item("TTINTC") = DBNull.Value
                oDtAux.Rows(i).Item("REFERENCIA") = DBNull.Value


                bolBultosIguales = True
            End If


            If oDtAux.Rows(i).Item("NRITOC").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NRITOC").ToString.Trim) And _
            oDtAux.Rows(i).Item("CIDPAQ").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CIDPAQ").ToString.Trim) And _
             bolBultosIguales Then

                oDtAux.Rows(i).Item("NRITOC") = DBNull.Value
                oDtAux.Rows(i).Item("TCITCL") = DBNull.Value
                oDtAux.Rows(i).Item("TDITES") = DBNull.Value
                oDtAux.Rows(i).Item("QBLTSR") = DBNull.Value
                oDtAux.Rows(i).Item("QPEPQT") = DBNull.Value
                oDtAux.Rows(i).Item("TUNDCN") = DBNull.Value
                oDtAux.Rows(i).Item("TLUGEN") = DBNull.Value
                oDtAux.Rows(i).Item("NGUIRM") = DBNull.Value
                oDtAux.Rows(i).Item("TNMMDT_ENVIO") = DBNull.Value
                oDtAux.Rows(i).Item("FSLDAL") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCST") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSA") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSF") = DBNull.Value
                oDtAux.Rows(i).Item("REFERENCIA") = DBNull.Value

            End If
            oDtAux.AcceptChanges()
        Next


        Return oDtAux
    End Function
    Private Sub ExportarExcelItemDespacho(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet

        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("FSLFFW").ColumnName = "FECHA"
        oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        oDt.Columns("TCMTRT").ColumnName = "TRANSPORTISTA"
        oDt.Columns("NPLCCM").ColumnName = "PLACA"
        oDt.Columns("TABDES").ColumnName = "TIPO TRACTO"

        oDt.Columns("NPLACP").ColumnName = "ACOPLADO"
        oDt.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"

        oDt.Columns("TNMBCH").ColumnName = "CHOFER"
        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDt.Columns("QPSOBL").ColumnName = "PESO "
        oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
        oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        oDt.Columns("NORCML").ColumnName = "N° O/C	"
        oDt.Columns("TTINTC").ColumnName = "INCONTERM"
        oDt.Columns("NRITOC").ColumnName = "ITEM "
        oDt.Columns("TCITCL").ColumnName = "COD. CLIENTE "
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM "
        oDt.Columns("QBLTSR").ColumnName = "CANT. ITEM "
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM "
        oDt.Columns("TUNDCN").ColumnName = "UNIDAD  "
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO"
        oDt.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
        oDt.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
        oDt.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"
        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")

        oDs.Tables.Add(oDt)
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub

#End Region
End Class

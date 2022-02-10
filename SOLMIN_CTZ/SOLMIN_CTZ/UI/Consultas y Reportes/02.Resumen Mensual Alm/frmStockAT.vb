Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario
Public Class frmStockAT


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


    Private Sub frmStockAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcDivision.Compania = pCCMPN
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()
    End Sub

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        pcxEspera.Visible = True
        tsbExportar.Enabled = False
        bgwGifAnimado.RunWorkerAsync()
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted

        pcxEspera.Visible = False
        tsbExportar.Enabled = True

    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        ExportarExcel()
    End Sub


    Private Sub ExportarExcel()
        Dim oDtExcel As New DataTable
        Try
            Dim obrResumenMensualAlm As New clsResumenMensualAlmacenes
            Dim obeFiltro As New ResumenMensualAlmacenes
            With obeFiltro
                .PSCCLNT = _pCodClientes
                .PSCCMPN = _pCCMPN
                .PSCDVSN = UcDivision.Division
                .PNFECFIN = IIf(Me.dteFechaInventario.Checked, Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInventario.Value), 0)
            End With

            Dim strlCabecera As New List(Of String)
            strlCabecera.Add("Fecha Inventario :" + " " + dteFechaInventario.Value)
            oDtExcel = obrResumenMensualAlm.fodtInventarioSATResumenMensualAll(obeFiltro)
        Catch
        End Try

        Try

            Dim strTitulo As String = ""
            If Me.rbtOrdenDeCompra.Checked Then
                oDtExcel = EliminarRepetido(oDtExcel)
                ExportarExcelOC(oDtExcel, strTitulo)
            ElseIf rbtItem.Checked Then
                ExportarExcelItem(oDtExcel.Copy, strTitulo)
            Else
                ExportarExcelSubItem(oDtExcel.Copy, strTitulo)
            End If

        Catch : End Try


    End Sub

    Private Sub ExportarExcelOC(ByVal oDtExcel As DataTable, ByVal strTitulo As String)
        Dim oDt As New DataTable
        Dim strSentidoCarga As String = ""
        oDt = oDtExcel.Copy


        'Eliminamos datos de item
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("IVUNIT")
        oDt.Columns.Remove("QSLCNB")
        oDt.Columns.Remove("TUNDIT")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("QVOPQT")
        oDt.Columns.Remove("NORAGN")
        oDt.Columns.Remove("NFACPR")
        oDt.Columns.Remove("FFACPR")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")

        Dim oDs As New DataSet
        oDt.Columns("CCLNT").ColumnName = "COD. CLIENTE"
        oDt.Columns("CLIENTE").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("QMTALT").ColumnName = "ALTURA"
        oDt.Columns("QMTANC").ColumnName = "ANCHO"
        oDt.Columns("QMTLRG").ColumnName = "LARGO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NGRPRV").ColumnName = "GUIA PROVEEDOR"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DE ENTREGA"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"

        oDs.Tables.Add(oDt)

       

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        'Suma 
        Dim listSuma As New Hashtable
        listSuma.Add("Suma01", 11)
        listSuma.Add("Suma02", 13)
        listSuma.Add("Suma03", 17)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo, listSuma)
    End Sub

    Private Sub ExportarExcelItem(ByVal oDtExcel As DataTable, ByVal strTitulo As String)
        Dim oDt As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDt = oDtExcel.Copy
        oDt.Columns("CCLNT").ColumnName = "COD. CLIENTE"
        oDt.Columns("CLIENTE").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDt.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDt.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDt.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDt.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDt.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDt.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDt.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDt.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")

        oDt.TableName = "Inventario Almacen "
        oDs.Tables.Add(oDt)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub ExportarExcelSubItem(ByVal oDtExcel As DataTable, ByVal strTitulo As String)
        Dim oDt As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        'oDt = oDtExcel.Copy
        oDt = GeneraDataTableSubItem(oDtExcel.Copy)
        oDt.Columns("CCLNT").ColumnName = "COD. CLIENTE"
        oDt.Columns("CLIENTE").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDt.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDt.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDt.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDt.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDt.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDt.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDt.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDt.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDt.Columns("SBITOC").ColumnName = "SUBITEM"
        oDt.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        oDt.Columns("TDITES1").ColumnName = "DESCRIPCION SUBITEM"
        oDt.Columns("QCNRCP").ColumnName = "CANTIDAD "
        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")
        oDt.TableName = "Inventario Almacen "
        oDs.Tables.Add(oDt)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)

    End Sub

    Private Function GeneraDataTableSubItem(ByVal oDt As DataTable) As DataTable
        Dim bolBultosIguales As Boolean = False

        For i As Integer = oDt.Rows.Count - 1 To 1 Step -1
            bolBultosIguales = False

            If oDt.Rows(i).Item("CCLNT").ToString.Trim.Equals(oDt.Rows(i - 1).Item("CCLNT").ToString.Trim) And _
            oDt.Rows(i).Item("TUBRFR").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TUBRFR").ToString.Trim) And _
            oDt.Rows(i).Item("TIPO_ALMACEN").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TIPO_ALMACEN").ToString.Trim) And _
            oDt.Rows(i).Item("ALMACEN").ToString.Trim.Equals(oDt.Rows(i - 1).Item("ALMACEN").ToString.Trim) And _
            oDt.Rows(i).Item("ZONA").ToString.Trim.Equals(oDt.Rows(i - 1).Item("ZONA").ToString.Trim) And _
            oDt.Rows(i).Item("CREFFW").ToString.Trim.Equals(oDt.Rows(i - 1).Item("CREFFW").ToString.Trim) And _
            oDt.Rows(i).Item("DESCRIPCION").ToString.Trim.Equals(oDt.Rows(i - 1).Item("DESCRIPCION").ToString.Trim) And _
            oDt.Rows(i).Item("FINGAL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("FINGAL").ToString.Trim) And _
            oDt.Rows(i).Item("QREFFW").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QREFFW").ToString.Trim) And _
            oDt.Rows(i).Item("TIPBTO").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TIPBTO").ToString.Trim) And _
            oDt.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDt.Rows(i).Item("QPSOBL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QPSOBL").ToString.Trim) And _
            oDt.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDt.Rows(i).Item("NORAGN").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORAGN").ToString.Trim) And _
            oDt.Rows(i).Item("TTINTC").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TTINTC").ToString.Trim) And _
            oDt.Rows(i).Item("TPRVCL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TPRVCL").ToString.Trim) And _
            oDt.Rows(i).Item("QAROCP").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QAROCP").ToString.Trim) And _
            oDt.Rows(i).Item("TNOMCOM").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TNOMCOM").ToString.Trim) And _
            oDt.Rows(i).Item("NORCML").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORCML").ToString.Trim) And _
            oDt.Rows(i).Item("PARCIAL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("PARCIAL").ToString.Trim) Then
                oDt.Rows(i).Item("CCLNT") = DBNull.Value
                oDt.Rows(i).Item("CLIENTE") = DBNull.Value
                oDt.Rows(i).Item("TUBRFR") = DBNull.Value
                oDt.Rows(i).Item("TIPO_ALMACEN") = DBNull.Value
                oDt.Rows(i).Item("ALMACEN") = DBNull.Value
                oDt.Rows(i).Item("ZONA") = DBNull.Value
                oDt.Rows(i).Item("CREFFW") = DBNull.Value
                oDt.Rows(i).Item("DESCRIPCION") = DBNull.Value
                oDt.Rows(i).Item("FINGAL") = DBNull.Value
                oDt.Rows(i).Item("QREFFW") = DBNull.Value
                oDt.Rows(i).Item("TIPBTO") = DBNull.Value
                oDt.Rows(i).Item("QVLBTO") = DBNull.Value
                oDt.Rows(i).Item("QPSOBL") = DBNull.Value
                oDt.Rows(i).Item("QVLBTO") = DBNull.Value
                oDt.Rows(i).Item("NORAGN") = DBNull.Value
                oDt.Rows(i).Item("TTINTC") = DBNull.Value
                oDt.Rows(i).Item("TPRVCL") = DBNull.Value
                oDt.Rows(i).Item("QAROCP") = DBNull.Value
                oDt.Rows(i).Item("TNOMCOM") = DBNull.Value
                oDt.Rows(i).Item("NORCML") = DBNull.Value
                oDt.Rows(i).Item("PARCIAL") = DBNull.Value
                oDt.Rows(i).Item("IMPORTE") = DBNull.Value
                bolBultosIguales = True

            End If

            If bolBultosIguales And oDt.Rows(i).Item("CCLNT").ToString.Trim.Equals(oDt.Rows(i - 1).Item("CCLNT").ToString.Trim) And _
            oDt.Rows(i).Item("NRITOC").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NRITOC").ToString.Trim) And _
            oDt.Rows(i).Item("TCITCL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TCITCL").ToString.Trim) Then
                oDt.Rows(i).Item("NRITOC") = DBNull.Value
                oDt.Rows(i).Item("TCITCL") = DBNull.Value
                oDt.Rows(i).Item("TDITES") = DBNull.Value
                oDt.Rows(i).Item("IVUNIT") = DBNull.Value
                oDt.Rows(i).Item("QSLCNB") = DBNull.Value
                oDt.Rows(i).Item("NFACPR") = DBNull.Value
                oDt.Rows(i).Item("FFACPR") = DBNull.Value
                oDt.Rows(i).Item("TUNDIT") = DBNull.Value
                oDt.Rows(i).Item("QPEPQT") = DBNull.Value
                oDt.Rows(i).Item("QVOPQT") = DBNull.Value
                oDt.Rows(i).Item("NGRPRV") = DBNull.Value
                oDt.Rows(i).Item("TLUGEN") = DBNull.Value
                oDt.Rows(i).Item("SSNCRG") = DBNull.Value
                oDt.Rows(i).Item("DIAS") = DBNull.Value
                oDt.Rows(i).Item("MARRET") = DBNull.Value
            End If
        Next

        Return oDt

    End Function

    Private Function EliminarRepetido(ByVal dtTemp As DataTable) As DataTable

        Dim dblValor As Decimal = Decimal.Zero
        dtTemp.Select("", "CCLNT,TUBRFR, CREFFW  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CCLNT").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CCLNT").ToString.Trim) And dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) Then
                dblValor = dblValor + dtTemp.Rows(i).Item("IMPORTE")
                dtTemp.Rows.RemoveAt(i)
            Else
                dblValor = dblValor + dtTemp.Rows(i).Item("IMPORTE")
                dtTemp.Rows(i).Item("IMPORTE") = dblValor
                dblValor = 0
            End If

            If i = 1 Then
                dblValor = dblValor + dtTemp.Rows(i - 1).Item("IMPORTE")
                dtTemp.Rows(i - 1).Item("IMPORTE") = dblValor
                dblValor = 0
            End If
        Next
        Return dtTemp
    End Function

End Class

Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Cliente
Imports Ransa.Controls.Cliente
Imports Ransa.DAO.Cliente

Public Class frmFacturacion
#Region "Declaracion de Variables"

    Private oDivision As clsDivision
    Private oCompania As clsCompania
    Private oMoneda As SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oPlanta As clsPlanta
    Private oServicioAtendido As Servicio_Atendido
    Private oServicioAtendidoNeg As clsServicioAtendido
    Private bolBuscar As Boolean
    Private oDtFacturacion As DataTable
    Private oDtFacturacionDetalle As DataTable
    Private oDtAcum As DataTable
    Private tipo_cambio As Double = 0D
    Private valor_igv As Double = 0D
#End Region

#Region "Procedimientos y Funciones"

#Region "Cargar combos"

    Private Sub Cargar_Compania()
        bolBuscar = False
        cmbCompania.DataSource = oCompania.Lista
        cmbCompania.ValueMember = "CCMPN"
        bolBuscar = True
        cmbCompania.DisplayMember = "TCMPCM"
        'cmbCompania.SelectedIndex = 0
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbDivision.DataSource = oDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            cmbDivision_SelectedIndexChanged(Nothing, Nothing)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Planta()
        Try
            If bolBuscar Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                bolBuscar = False
                cmbPlanta.DataSource = oPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.ValueMember = "CPLNDV"
                bolBuscar = True
                If cmbPlanta.FindString("1") = 0 Then
                    cmbPlanta.SelectedValue = 1
                End If
                cmbPlanta.DisplayMember = "TPLNTA"
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Cliente_Usuario()
        UcCliente.CCMPN = Me.cmbCompania.SelectedValue
    End Sub
#End Region

    Private Sub Buscar_Facturacion()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dtgFacturacion.Rows.Clear()
        dtgOperaciones.DataSource = Nothing
        Listar_Facturacion()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Listar_Facturacion()
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow

        oServicioAtendido.CCLNT = UcCliente.pCodigo.ToString  ' cmbCliente.SelectedValue
        oServicioAtendido.CCMPN = cmbCompania.SelectedValue
        oServicioAtendido.CDVSN = cmbDivision.SelectedValue
        oServicioAtendido.CPLNDV = cmbPlanta.SelectedValue
        oDt = oServicioAtendidoNeg.Lista_ParaFaturacion(oServicioAtendido)
        If Not oDtFacturacion Is Nothing Then oDtFacturacion.Rows.Clear()
        oDtFacturacion = oDt.Copy

        With oDt
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To .Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgFacturacion)
                    Me.dtgFacturacion.Rows.Add(oDrVw)
                    dtgFacturacion.Rows(intCont).Cells("VALIDAR").Value = 0
                    dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value = .Rows(intCont).Item("NSECFC").ToString.Trim 'Código 
                    dtgFacturacion.Rows(intCont).Cells("TCMPCL").Value = .Rows(intCont).Item("TCMPCL").ToString.Trim 'Cliente
                    dtgFacturacion.Rows(intCont).Cells("TCMPDV").Value = .Rows(intCont).Item("TCMPDV").ToString.Trim 'Area
                    dtgFacturacion.Rows(intCont).Cells("TPLNTA").Value = .Rows(intCont).Item("TPLNTA").ToString.Trim 'planta
                    dtgFacturacion.Rows(intCont).Cells("TSGNMN").Value = .Rows(intCont).Item("TSGNMN").ToString.Trim 'moneda
                    dtgFacturacion.Rows(intCont).Cells("TOTAL1").Value = Format(CType(.Rows(intCont).Item("TOTAL").ToString.Trim, Double), "###,###,###,##0.000") 'total
                    dtgFacturacion.Rows(intCont).Cells("CCMPN").Value = oServicioAtendido.CCMPN
                    dtgFacturacion.Rows(intCont).Cells("CDVSN").Value = oServicioAtendido.CDVSN
                    dtgFacturacion.Rows(intCont).Cells("DIVISION").Value = Me.cmbDivision.Text.Trim
                    dtgFacturacion.Rows(intCont).Cells("CCLNT").Value = oServicioAtendido.CCLNT
                    dtgFacturacion.Rows(intCont).Cells("CPLNDV1").Value = oServicioAtendido.CPLNDV
                    dtgFacturacion.Rows(intCont).Cells("CMNDA").Value = IIf(.Rows(intCont).Item("TSGNMN").ToString.Trim = "USD", "DOL", "SOL") 'IIf(oServicioAtendido.CMNDA1 = 100, "DOL", "SOL")
                    dtgFacturacion.Rows(intCont).Cells("CCNTCS").Value = .Rows(intCont).Item("CCNTCS") 'Centro Costo|
                    dtgFacturacion.Rows(intCont).Cells("STPODP").Value = .Rows(intCont).Item("STPODP")
                Next intCont
                Cargar_ConsistenciaV2()
            End If
        End With

    End Sub

    Private Sub FiltrarDatos()
        Dim intCont As Integer
        Dim intProcesado As Integer = 0

        If dtgFacturacion.RowCount = 0 Then
            HelpClass.MsgBox("No hay Registro para anular")
            Return
        End If

        For intCont = dtgFacturacion.RowCount - 1 To 0 Step -1
            If CType(dtgFacturacion.Rows(intCont).Cells("VALIDAR").Value, Boolean) Then
                oServicioAtendido.NSECFC = CType(dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value, Double)
                oServicioAtendidoNeg.AnularFactura(oServicioAtendido)
                dtgFacturacion.Rows.RemoveAt(intCont)
                intProcesado = 1
            End If
        Next intCont
        If intProcesado = 0 Then
            HelpClass.MsgBox("No hay Registro habilitado para Anular")
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        HelpClass.MsgBox("Se Anuló correctamente")
    End Sub

    Private Sub Cargar_ConsistenciaV2()
        If dtgFacturacion.RowCount > 0 Then

            oServicioAtendido.NSECFC = CType(dtgFacturacion.CurrentRow.Cells("NSECFC1").Value, Double)
            oServicioAtendido.CODVAR = IIf(cmbDivision.SelectedValue = "R", "TIPSER", "TIPSES")
            If oServicioAtendido.NSECFC = 0 Then Exit Sub
            dtgOperaciones.DataSource = Nothing
            dtgOperaciones.AutoGenerateColumns = False
            dtgOperaciones.DataSource = oServicioAtendidoNeg.Cargar_Operaciones(oServicioAtendido)
        End If
    End Sub

    Private Sub Calcular_Cantidades_Totales(ByVal pdblOpr As Double, ByVal poDt As DataTable, ByRef pobj As Object)
        Dim oDr() As DataRow
        Dim intCont As Integer
        Dim dblMont2a7 As Double = 0
        Dim dblMont10 As Double = 0
        Dim dblCont20 As Double = 0
        Dim dblCont40 As Double = 0
        Dim dblEstiba As Double = 0
        Dim dblEmbala As Double = 0
        Dim dblPaliti As Double = 0
        Dim dblTotal As Double = 0

        oDr = poDt.Select("NOPRCN=" & pdblOpr)
        For intCont = 0 To oDr.Length - 1
            If oDr(intCont).Item("NRSRRB").ToString.Trim = "1" And oDr(intCont).Item("NRTFSV").ToString.Trim = "21" Then
                If dblMont2a7 = 0 Then
                    dblTotal = dblTotal + CType(oDr(intCont).Item("TOTAL").ToString.Trim, Double)
                End If
                dblMont2a7 = oDr(intCont).Item("QATNAN").ToString.Trim
            End If
            If oDr(intCont).Item("NRSRRB").ToString.Trim = "1" And oDr(intCont).Item("NRTFSV").ToString.Trim = "22" Then
                If dblMont10 = 0 Then
                    dblTotal = dblTotal + CType(oDr(intCont).Item("TOTAL").ToString.Trim, Double)
                End If
                dblMont10 = oDr(intCont).Item("QATNAN").ToString.Trim
            End If
            If oDr(intCont).Item("NRSRRB").ToString.Trim = "2" And oDr(intCont).Item("NRTFSV").ToString.Trim = "14" Then
                If dblCont20 = 0 Then
                    dblTotal = dblTotal + CType(oDr(intCont).Item("TOTAL").ToString.Trim, Double)
                End If
                dblCont20 = oDr(intCont).Item("QATNAN").ToString.Trim
            End If
            If oDr(intCont).Item("NRSRRB").ToString.Trim = "2" And oDr(intCont).Item("NRTFSV").ToString.Trim = "15" Then
                If dblCont40 = 0 Then
                    dblTotal = dblTotal + CType(oDr(intCont).Item("TOTAL").ToString.Trim, Double)
                End If
                dblCont40 = oDr(intCont).Item("QATNAN").ToString.Trim
            End If
            If oDr(intCont).Item("NRSRRB").ToString.Trim = "5" Then
                If dblEstiba = 0 Then
                    dblTotal = dblTotal + CType(oDr(intCont).Item("TOTAL").ToString.Trim, Double)
                End If
                dblEstiba = oDr(intCont).Item("QATNAN").ToString.Trim
            End If
            If oDr(intCont).Item("NRSRRB").ToString.Trim = "13" Then
                If dblEmbala = 0 Then
                    dblTotal = dblTotal + CType(oDr(intCont).Item("TOTAL").ToString.Trim, Double)
                End If
                dblEmbala = oDr(intCont).Item("QATNAN").ToString.Trim
            End If
            If oDr(intCont).Item("NRSRRB").ToString.Trim = "14" Then
                If dblPaliti = 0 Then
                    dblTotal = dblTotal + CType(oDr(intCont).Item("TOTAL").ToString.Trim, Double)
                End If
                dblPaliti = oDr(intCont).Item("QATNAN").ToString.Trim
            End If
        Next intCont

        pobj(0) = dblMont2a7
        pobj(1) = dblMont10
        pobj(2) = dblCont20
        pobj(3) = dblCont40
        pobj(4) = dblEstiba
        pobj(5) = dblEmbala
        pobj(6) = dblPaliti
        pobj(7) = dblTotal
    End Sub

    Private Sub LlamarVistaPrevia(ByVal pIntTipo As Integer)
        Dim intCont As Integer
        Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim DtRegionVenta As New DataTable
        Dim objfrmVFactura As frmGenararFactura
        Dim Moneda As String = String.Empty
        Dim dblCCLNFC As Double = 0
        Dim Cant As Integer = 0
        Dim blRegion As Boolean = True
        Dim strConsistencia As String = String.Empty
        Dim strRegionVenta As String = String.Empty
        Dim oDt As DataTable
        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable

        oFiltro("CMNDA1") = "100"
        oFiltro("FCMBO") = Format(Now, "yyyyMMdd")
        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
        If oDt.Rows.Count = 0 Then
            MessageBox.Show("No se puede generar la factura por no existir Tipo de cambio a la fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        For intCont = 0 To dtgFacturacion.RowCount - 1
            If CType(dtgFacturacion.Rows(intCont).Cells("VALIDAR").Value, Boolean) Then

                'oFiltro.Parametro1 = "100" 'tipo cambio dolares
                'oFiltro.Parametro2 = Format(Now, "yyyyMMdd")

                'oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
                'If oDt.Rows.Count = 0 Then
                '    MessageBox.Show("No se puede generar la factura por no existir Tipo de cambio a la fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If


                Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
                oFacturacion.TIPOFACTURA = pIntTipo
                oFacturacion.NSECFC = dtgFacturacion.Rows(intCont).Cells("NSECFC1").Value
                oFacturacion.TCMPDV = dtgFacturacion.Rows(intCont).Cells("DIVISION").Value
                oFacturacion.PSCDVSN = dtgFacturacion.Rows(intCont).Cells("CDVSN").Value
                oFacturacion.PSCCMPN = dtgFacturacion.Rows(intCont).Cells("CCMPN").Value
                oFacturacion.CCLNFC = dtgFacturacion.Rows(intCont).Cells("CCLNT").Value
                oFacturacion.CPLNDV = dtgFacturacion.Rows(intCont).Cells("CPLNDV1").Value
                oFacturacion.CMNDA1 = dtgFacturacion.Rows(intCont).Cells("CMNDA").Value
                oFacturacion.CCNTCS = dtgFacturacion.Rows(intCont).Cells("CCNTCS").Value
                If oFacturacion.CCLNFC <> dblCCLNFC And dblCCLNFC <> 0 Then
                    MessageBox.Show("No puede generar la factura por que las operaciones seleccionadas " & Chr(10) & " cuentan con diferentes Clientes a Facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                dblCCLNFC = oFacturacion.CCLNFC
                If Cant = 0 Then Moneda = dtgFacturacion.Rows(intCont).Cells("TSGNMN").Value
                If Moneda <> dtgFacturacion.Rows(intCont).Cells("TSGNMN").Value Then
                    MessageBox.Show("No puede generar con diferentes monedas", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Moneda = dtgFacturacion.Rows(intCont).Cells("TSGNMN").Value
                DtRegionVenta = oFacturaNeg.Lista_Region_Venta(oFacturacion)
                If DtRegionVenta.Rows.Count = 0 Then
                    blRegion = False
                    strConsistencia += oFacturacion.NOPRCN & System.Environment.NewLine
                Else
                    If strRegionVenta <> DtRegionVenta.Rows(0).Item("CRGVTA") And strRegionVenta <> "" Then
                        MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    strRegionVenta = DtRegionVenta.Rows(0).Item("CRGVTA")
                    oFacturacion.CRGVTA = strRegionVenta
                End If
                mListaFacturas.Add(oFacturacion)
                Cant += 1
            End If
        Next intCont

        If blRegion = False And Cant > 1 Then
            MessageBox.Show("La consistencia " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If mListaFacturas.Count > 0 Then
            'oFiltro = New Filtro
            oFiltro = New Hashtable
            'oFiltro.Parametro1 = mListaFacturas(0).PSCCMPN 'strCodCom
            'oFiltro.Parametro2 = mListaFacturas(0).PSCDVSN 'strCodDiv
            oFiltro("CCMPN") = mListaFacturas(0).PSCCMPN 'strCodCom
            oFiltro("CDVSN") = mListaFacturas(0).PSCDVSN 'strCodDiv
            'lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
            'lobjParams.Add("PSCDVSN", pobjFiltro("CDVSN"))
            Dim oDtGiro As DataTable
            oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
            If oDtGiro.Rows.Count > 0 Then
                objfrmVFactura = New frmGenararFactura(mListaFacturas)
                objfrmVFactura.ShowDialog()
                If objfrmVFactura.Grabar Then
                    Buscar_Facturacion()
                End If
            Else
                MessageBox.Show("Usted no tiene Acceso a facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

#Region "Exportar Excel Antiguo"

    Public Sub pExportarDetalleFactura(ByVal strTitulo As String, ByVal linea1_ As String, ByVal plinea2 As String, ByVal drvRows As DataGridViewRowCollection, _
                         ByVal objListColumns As List(Of String), ByVal objListColumnsHide As List(Of Boolean))
        Dim oExcel As Object
        Dim oBook As Object
        Dim oBooks As Object
        Dim oWorksheet As Object
        Dim objType As Type
        Dim intHeaders As Int32
        Dim intHeaders1 As Int32
        Dim intRow As Int32
        Dim i As Int32
        Dim j As Int32
        Dim intContador As Int16
        Try
            ' Validamos que la coleccion de filas no sea nothing
            If Not drvRows Is Nothing Then
                ' Iniciamos Excel y abrimos un libro
                objType = Type.GetTypeFromProgID("Excel.Application")
                oExcel = Activator.CreateInstance(objType)
                oExcel.Visible = False
                oBooks = oExcel.Workbooks
                oBook = oBooks.Open(Application.StartupPath & "\ExportToXLS\SOLMIN_Contrato.xlt")

                ' Asignamos el objeto Sheet
                oWorksheet = oBook.ActiveSheet

                ' Contamos las columnas q son visibles
                For i = 0 To objListColumnsHide.Count - 1
                    If objListColumnsHide(i) Then
                        intHeaders += 1
                    Else
                        intHeaders1 += 1
                    End If
                Next
                ' Ejecutamos macro, enviamos las columnas y valores
                oBook.MuestraGrid(strTitulo, linea1_, plinea2, intHeaders, drvRows.Count)
                ' Agregar las columnas
                intRow = 5
                For i = 0 To objListColumnsHide.Count - 1 'intHeaders - 1
                    If objListColumnsHide(i) Then
                        oWorksheet.Cells(5, intContador + 3).Value = objListColumns(i) 'mdtTablaMaster.Columns(i).ColumnName
                        intContador += 1
                    End If
                Next
                For i = 0 To objListColumnsHide.Count - 1
                    oWorksheet.columns(i + 3).ColumnWidth = 15
                Next i
                intRow = 6
                For i = 0 To drvRows.Count - 1
                    intContador = 0

                    ' Cargar la data
                    For j = 0 To objListColumnsHide.Count - 1 'intHeaders - 1
                        If objListColumnsHide(j) Then
                            If Not drvRows.Item(i).Cells(j).Value = Nothing Then
                                Select Case Me.dtgDetalleFacturacion.Columns(j).Name.ToString.Trim
                                    Case "SERVICIO", "DESCWB", "CHOFER"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Trim
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4131 'xlLeft
                                        intContador += 1
                                        'Case "FECINI", "FECFIN", "TMNDA"
                                        '    oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Replace(Chr(13) & Chr(10), Chr(10))
                                        '    oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        '    oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        '    oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4108 'xlCenter 
                                        '    intContador += 1
                                    Case "TOTAL", "IVLSRV"
                                        oWorksheet.Cells(intRow + i, intContador + 3).NumberFormat = "###,###,###,##0.00"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = Double.Parse(drvRows.Item(i).Cells(j).FormattedValue.ToString.Trim)
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4152 'xlRight
                                        intContador += 1
                                    Case Else
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Trim
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = True
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4108 'xlCenter
                                        intContador += 1

                                End Select
                            Else
                                oWorksheet.Cells(intRow + i, intContador + 3).Value = ""
                                intContador += 1
                            End If
                        End If
                    Next j
                Next i
            End If
            oExcel.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Eliminamos los objetos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
            oBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
            oBooks = Nothing
            'oExcel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
            oExcel = Nothing
            oExcel = Nothing
            oBook = Nothing
            oBooks = Nothing
            oWorksheet = Nothing
        End Try
    End Sub

    Public Sub pExportar(ByVal strTitulo As String, ByVal linea1_ As String, ByVal plinea2 As String, ByVal drvRows As DataGridViewRowCollection, _
                       ByVal objListColumns As List(Of String), ByVal objListColumnsHide As List(Of Boolean))
        Dim oExcel As Object
        Dim oBook As Object
        Dim oBooks As Object
        Dim oWorksheet As Object
        Dim objType As Type
        Dim intHeaders As Int32
        Dim intHeaders1 As Int32
        Dim intRow As Int32
        Dim i As Int32
        Dim j As Int32
        Dim intContador As Int16
        Try
            ' Validamos que la coleccion de filas no sea nothing
            If Not drvRows Is Nothing Then
                ' Iniciamos Excel y abrimos un libro
                objType = Type.GetTypeFromProgID("Excel.Application")
                oExcel = Activator.CreateInstance(objType)
                oExcel.Visible = False
                oBooks = oExcel.Workbooks
                oBook = oBooks.Open(Application.StartupPath & "\ExportToXLS\SOLMIN_Contrato.xlt")

                ' Asignamos el objeto Sheet
                oWorksheet = oBook.ActiveSheet

                ' Contamos las columnas q son visibles
                For i = 1 To objListColumnsHide.Count - 1
                    If objListColumnsHide(i) Then
                        intHeaders += 1
                    Else
                        intHeaders1 += 1
                    End If
                Next
                ' Ejecutamos macro, enviamos las columnas y valores
                oBook.MuestraGrid(strTitulo, linea1_, plinea2, intHeaders, drvRows.Count)
                ' Agregar las columnas
                intRow = 5
                For i = 1 To objListColumnsHide.Count - 1 'intHeaders - 1
                    If objListColumnsHide(i) Then
                        oWorksheet.Cells(5, intContador + 3).Value = objListColumns(i) 'mdtTablaMaster.Columns(i).ColumnName
                        intContador += 1
                    End If
                Next
                For i = 1 To objListColumnsHide.Count - 1
                    oWorksheet.columns(i + 3).ColumnWidth = 15
                Next i
                intRow = 6
                For i = 0 To drvRows.Count - 1
                    intContador = 0

                    ' Cargar la data
                    For j = 1 To objListColumnsHide.Count - 1 'intHeaders - 1
                        If objListColumnsHide(j) Then
                            If Not drvRows.Item(i).Cells(j).Value = Nothing Then

                                Select Case Me.dtgFacturacion.Columns(j).Name.ToString.Trim
                                    Case "NSECFC", "TCMPCL", "TCMPDV", "TPLNTA"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Trim
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4131 'xlLeft
                                        intContador += 1
                                    Case "TSGNMN"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Trim
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4108 'xlCenter 
                                        intContador += 1
                                    Case "TOTAL"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Trim
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter 
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4152 'xlRight
                                        intContador += 1
                                    Case Else
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Trim
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = True
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4108 'xlCenter
                                        intContador += 1
                                End Select
                            Else
                                oWorksheet.Cells(intRow + i, intContador + 3).Value = ""
                                intContador += 1
                            End If
                        End If
                    Next j
                Next i
            End If
            oExcel.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Eliminamos los objetos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
            oBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
            oBooks = Nothing
            'oExcel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
            oExcel = Nothing
            oExcel = Nothing
            oBook = Nothing
            oBooks = Nothing
            oWorksheet = Nothing
        End Try
    End Sub

    Private Sub pExportarExcelv2(ByVal pstrTitulo As String, ByVal plinea1 As String, ByVal plinea2 As String, Optional ByVal strTipoRep As String = "O")

        Try

            Dim obj_Logica As New Ransa.Controls.ServicioOperacion.clsConsistencia_BL
            Dim obj_Servicio As New Ransa.Controls.ServicioOperacion.Servicio_BE
            Dim ServicioNegocio As New Ransa.Controls.ServicioOperacion.clsServicio_BL
            Dim strMensaje As String = String.Empty

            obj_Servicio.CMNDA1 = 100
            obj_Servicio.FULTAC = Format(Now, "yyyyMMdd")

            tipo_cambio = obj_Logica.Obtener_Tipo_Cambio(obj_Servicio)
            valor_igv = obj_Logica.Obtener_igv_actual(obj_Servicio)
            obj_Servicio.CCLNT = UcCliente.pCodigo
            obj_Servicio.CCLNT_DESC = UcCliente.pRazonSocial

            obj_Servicio.CCMPN = cmbCompania.SelectedValue
            obj_Servicio.CCMPN_DESC = cmbCompania.Text
            obj_Servicio.CDVSN = cmbDivision.SelectedValue
            obj_Servicio.CDVSN_DESC = cmbDivision.Text

            obj_Servicio.CPLNDV = dtgOperaciones.CurrentRow.Cells("CPLNDV").Value
            obj_Servicio.NSECFC = dtgFacturacion.CurrentRow.Cells("NSECFC1").Value
            obj_Servicio.FLGPEN = "S"
            obj_Servicio.FLGFAC = "N"
            obj_Servicio.TIPO = "1"
            obj_Servicio.STPODP = dtgFacturacion.CurrentRow.Cells("STPODP").Value
            obj_Servicio.CTPALJ = dtgOperaciones.CurrentRow.Cells("TIPO_PROCESO").Value

            ServicioNegocio.pExportarConsistenciaRevisionExcel(obj_Servicio, tipo_cambio, valor_igv, strTipoRep, strMensaje)

            If strMensaje <> String.Empty Then
                MsgBox(strMensaje)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgFacturacion.Rows.Count - 1
            If dtgFacturacion.Rows(intCont).Cells("VALIDAR").Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)

        Dim intCont As Integer
        For intCont = 0 To dtgFacturacion.RowCount - 1
            dtgFacturacion.Rows(intCont).Cells("VALIDAR").Value = blnEstado
            dtgFacturacion.EndEdit()
        Next intCont
        dtgFacturacion.Focus()
    End Sub


#End Region

#Region "Eventos de Control"

    Private Sub frmFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
        oServicioAtendido = New SOLMIN_CTZ.Entidades.Servicio_Atendido
        oServicioAtendidoNeg = New SOLMIN_CTZ.NEGOCIO.clsServicioAtendido
        bolBuscar = False
        Cargar_Compania()
        bolBuscar = True
        'Crear_Grilla_Consistencias()
        'Crear_Grilla_DetalleFacturacion()
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
            Cargar_Cliente_Usuario()
        End If
    End Sub

    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Cliente_Usuario()
        End If
    End Sub

    Private Sub btnAnular1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular1.Click
        If dtgFacturacion.Rows.Count = 0 Then Exit Sub
        If MsgBox("Seguro que desea eliminar la Consistencia ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
            FiltrarDatos()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExportar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar1.Click
        If oDtFacturacion Is Nothing Then Exit Sub
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim ListDt As New List(Of DataTable)
        Dim odtReporte As New DataTable
        odtReporte = oDtFacturacion.Copy
        odtReporte.Columns.Remove("CCNTCS")
        '---------Se cambia el nombre de la Cabecera----------
        odtReporte.Columns(0).ColumnName = "NRO CONSISTENCIA"
        odtReporte.Columns(1).ColumnName = "PLANTA"
        odtReporte.Columns(2).ColumnName = "DIVISION"
        odtReporte.Columns(3).ColumnName = "CLIENTE"
        odtReporte.Columns(4).ColumnName = "MONEDA"
        odtReporte.Columns(5).ColumnName = "TOTAL"
        ListDt.Add(odtReporte)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(ListDt, "REPORTE DE FACTURACION")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dtgFacturacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFacturacion.CellClick
        Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Cargar_ConsistenciaV2()
    End Sub

    Private Sub dtgFacturacion_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFacturacion.CellEnter
        Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Cargar_ConsistenciaV2()
    End Sub

    Private Sub dtgOperaciones_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellDoubleClick
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgOperaciones.Columns(e.ColumnIndex).Name = "Det" Then
            Dim oFrmServicios As New frmListaServicios
            oFrmServicios.pCCLNT = UcCliente.pCodigo
            oFrmServicios.pNOPRCN = Me.dtgOperaciones.CurrentRow.Cells("NOPRCN_D").Value
            oFrmServicios.ShowDialog()
        End If
    End Sub

    Private Sub dtgFacturacion_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If e.RowIndex = -1 And e.ColumnIndex = 0 Then
        '    Me.Cursor = Cursors.WaitCursor
        '    dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        '    If dtgFacturacion.RowCount > 0 Then
        '        If Existe_Check() Then
        '            Poner_Check_Todo_OC(False)
        '        Else

        '            Poner_Check_Todo_OC(True)

        '        End If
        '    End If
        '    Me.Cursor = Cursors.Default
        'End If
    End Sub


#End Region

    Private Sub dtgFacturacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFacturacion.CellContentClick

        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            Me.Cursor = Cursors.WaitCursor
            dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dtgFacturacion.RowCount > 0 Then
                If CheckBox1.Checked Then
                    Poner_Check_Todo_OC(False)
                    CheckBox1.Checked = False
                Else

                    Poner_Check_Todo_OC(True)
                    CheckBox1.Checked = True
                End If
            End If

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnBuscar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar1.Click
        Buscar_Facturacion()
    End Sub

    Private Sub FacturacionPorRubroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionPorRubroToolStripMenuItem.Click
        Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        LlamarVistaPrevia(1)
    End Sub

    Private Sub FacturacionDetalladaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDetalladaToolStripMenuItem.Click
        Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        LlamarVistaPrevia(2)
    End Sub

    Private Sub ToolStripItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripItem.Click
        If dtgFacturacion.RowCount > 0 Then
            Dim strTitulo As String
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            strTitulo = cmbDivision.Text.ToString.Trim & " - " + UcCliente.pRazonSocial.ToString.Trim
            Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
            'pExportarExcel("REPORTE DETALLE FACTURACIÓN", "REPORTE DETALLE FACTURACIÓN", strTitulo, "I")
            pExportarExcelv2("REPORTE DETALLE FACTURACIÓN", "REPORTE DETALLE FACTURACIÓN", strTitulo, "I")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub ToolStripOc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripOc.Click
        If dtgFacturacion.RowCount > 0 Then
            Dim strTitulo As String
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            strTitulo = cmbDivision.Text.ToString.Trim & " - " + UcCliente.pRazonSocial.ToString.Trim
            Me.dtgFacturacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
            'pExportarExcel("REPORTE DETALLE FACTURACIÓN", "REPORTE DETALLE FACTURACIÓN", strTitulo, "0")
            pExportarExcelv2("REPORTE DETALLE FACTURACIÓN", "REPORTE DETALLE FACTURACIÓN", strTitulo, "0")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

End Class

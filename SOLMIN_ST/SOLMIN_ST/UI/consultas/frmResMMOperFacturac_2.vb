Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text
Imports System.IO
Imports Ransa.Utilitario

Public Class frmResMMOperFacturac_2
  Private bolBuscar As Boolean = False
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private objTipodeTracto As New NEGOCIO.mantenimientos.TipodeTracto_BLL
    Private strPlanta As String
  Private _lstrTipoCuenta As String

  Dim ht As New Hashtable
  Dim objLogica As New ReportesVariados_BLL

  'Private Sub Cargar_Compania()
  '  Try
  '    bolBuscar = False
  '    objCompaniaBLL.Crea_Lista()
  '    cmbCompania.DataSource = objCompaniaBLL.Lista
  '    cmbCompania.ValueMember = "CCMPN"
  '    cmbCompania.DisplayMember = "TCMPCM"
  '    cmbCompania.SelectedIndex = 0
  '    bolBuscar = True
  '    cmbCompania_SelectedIndexChanged(Nothing, Nothing)
  '  Catch ex As Exception
  '  End Try
  'End Sub

  'Private Sub Cargar_Division()
  '    Dim objDivision As New NEGOCIO.Division_BLL
  '    Try
  '        If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
  '            bolBuscar = False
  '            objDivision.Crea_Lista()
  '            cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
  '            cmbDivision.ValueMember = "CDVSN"
  '            cmbDivision.DisplayMember = "TCMPDV"
  '            'cmbDivision.SelectedIndex = 0
  '            Me.cmbDivision.SelectedValue = "T"
  '            If Me.cmbDivision.SelectedIndex = -1 Then
  '                Me.cmbDivision.SelectedIndex = 0
  '            End If
  '            bolBuscar = True
  '            'cmbDivision_SelectedIndexChanged(Nothing, Nothing)
  '        End If
  '    Catch ex As Exception
  '        HelpClass.MsgBox(ex.Message)
  '    End Try
  'End Sub

  'Private Sub Cargar_Planta()
  '  Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
  '  Try
  '    If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
  '      bolBuscar = False
  '      objPlanta.Crea_Lista()
  '      objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
  '      cmbPlanta.DataSource = objLisEntidad
  '      cmbPlanta.ValueMember = "CPLNDV"
  '      cmbPlanta.DisplayMember = "TPLNTA"
  '      bolBuscar = True
  '      Me.cmbPlanta.SelectedIndex = 0
  '    End If
  '  Catch ex As Exception

  '    HelpClass.MsgBox(ex.Message)
  '  End Try
  'End Sub

  Private Sub CargarTransportista()
    txtTransportista.pClear()
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
    obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    Me.txtTransportista.pCargar(obeTracto)
  End Sub

  Private Sub Cargar_TipoVehiculo()
    Dim objListTipodeTracto As New List(Of ENTIDADES.mantenimientos.TipodeTracto)
    Try
      bolBuscar = False
      objListTipodeTracto = objTipodeTracto.Listar_TipodeTractoCbo()
      chbTipoVehiculo.DisplayMember = "TDETRA"
      chbTipoVehiculo.ValueMember = "CTITRA"
      Me.chbTipoVehiculo.DataSource = objListTipodeTracto
      For i As Integer = 0 To chbTipoVehiculo.Items.Count - 1
        chbTipoVehiculo.SetItemChecked(i, True)
      Next

      bolBuscar = True
      chbTipoVehiculo_SelectedIndexChanged(Nothing, Nothing)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub InicializarFormulario()
    Me.gwdDatos.DataSource = Nothing
    Me.gwdAnexo3.DataSource = Nothing
    Me.gwdAnexo31.DataSource = Nothing
    Me.gwdDetalleAsignado.DataSource = Nothing
    Me.gwdDetalleLiquidado.DataSource = Nothing
    Me.gwdDetalleCredito.DataSource = Nothing
    Me.txtTransportista.pClear()
    Me.CargarTransportista()
  End Sub

  Private Sub frmResMMOperFacturac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      bolBuscar = False
      Cargar_Compania()
      Cargar_TipoVehiculo()
      'SE AGREGO
      Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
      'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
            obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            obeTracto.pNRUCTR_RucTransportista = "20100039207"
      Me.txtTransportista.pCargar(obeTracto)
      Me.gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
      Me.gwdDatos.AutoGenerateColumns = False
      Me.gwdAnexo3.AutoGenerateColumns = False
      Me.gwdAnexo31.AutoGenerateColumns = False
      Me.gwdDetalleLiquidado.AutoGenerateColumns = False
      Me.gwdDetalleAsignado.AutoGenerateColumns = False
      Me.gwdDetalleCredito.AutoGenerateColumns = False
      pbxProceso.Visible = False
            lblProceso.Visible = False

        
            ' Cargar_Planta()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click



        If VerificarSiNoEligePlanta() = True Then  'agregado

            Try
                Me.gwdDatos.DataSource = Nothing
                Me.gwdAnexo3.DataSource = Nothing
                Me.gwdAnexo31.DataSource = Nothing
                Me.gwdDetalleLiquidado.DataSource = Nothing
                Me.gwdDetalleAsignado.DataSource = Nothing
                Me.gwdDetalleCredito.DataSource = Nothing
                If Me.txtTransportista.pCodigoRNS = 0 Then
                    HelpClass.MsgBox("Seleccione un Transportista", MessageBoxIcon.Information)
                    Exit Sub
                End If
                pbxProceso.Visible = True
                lblProceso.Visible = True
                lblProceso.Text = "Procesando..."

                PrepararProceesWorked()
                bgwProceso.RunWorkerAsync()

            Catch ex As Exception
                'HeaderGroupFiltro.Enabled = True
                HelpClass.ErrorMsgBox()
                Me.Cursor = Cursors.Default
                pbxProceso.Visible = False
                lblProceso.Visible = False
                lblProceso.Text = "Finalizado..."
                ClearMemory()
            End Try
            MenuBar.Enabled = True
            Me.Cursor = Cursors.Default
        End If 'agregado

    End Sub

    'se creo esta funcion 23/03/2012
    Private Function VerificarSiNoEligePlanta() As Boolean
        Dim vretorno As Boolean = False

        Dim strCodPlanta As String = ""



        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strCodPlanta += chkcbxPlanta.CheckedItems(i).Value

            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strCodPlanta = String.Concat(strCodPlanta, ",")
            End If

        Next

        If strCodPlanta = "" Then
            HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default
            '    ControlVisorCliente.Ocultar_Imagen()
            vretorno = False
        Else
            vretorno = True

        End If
        Return vretorno

    End Function

  'Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '    If bolBuscar = True Then
  '        Cargar_Division()
  '    End If
  'End Sub

  'Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '    If bolBuscar Then
  '        Cargar_Planta()
  '        CargarTransportista()
  '    End If
  'End Sub

  Private Sub chbTipoVehiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbTipoVehiculo.SelectedIndexChanged
    If bolBuscar = True Then
      InicializarFormulario()
    End If
  End Sub

  Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

    Select Case TabControl1.SelectedIndex
      Case 0
        If (Me.gwdDatos.Rows.Count = 0) Then
          MsgBox("No existen datos a exportar." & TabControl1.TabPages(0).Text, MsgBoxStyle.Information)
          Exit Sub
        End If

        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)

        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Información General"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Información General"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "INFORMACIÓN GENERAL"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

        ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))
        For Each dc As DataColumn In ODs.Tables(0).Columns
          Select Case dc.Caption

                        Case "SISTEMA", "CLIENTE", "PLACA", "MARCA", _
                        "ORIGEN", "DESTINO", "TIPO_TRACTO", "CONDUCTOR", "BREVETE", "NUMERO_GT", "NUMERO_FACT", _
                        "TPLNTA", "NUMERO_RUC", "SERIE_FACT", "NRO_MTC", "SERIE_GT", "PERIODO_DEVOLUCION", "PERIODO_TRIBUTARIO", "OPERACION", "RUC_CLIENTE", "CLIENTE_FACT"

                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                            '"FECHA_GT", "FECHA_FACT",

                            'Case "FECHA_FACT", "FECHA_GT"
                            '    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)

            Case "ORDEN", "TIPO_DOCUMENTO", "TIPO_DOCUMENTO1"
              dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

            Case "VALOR_VENTA", "VALOR_VENTA_IGV"
              dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

          End Select
        Next
                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs, 1)

      Case 1
        If (Me.gwdAnexo3.Rows.Count = 0) Then
          MsgBox("No existen datos a exportar." & TabControl1.TabPages(1).Text, MsgBoxStyle.Information)
          Exit Sub
        End If

        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)

        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Anexo 3"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Anexo 3"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "ANEXO 3"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        objDt = CType(Me.gwdAnexo3.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

        ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdAnexo3, objDt))
        For Each dc As DataColumn In ODs.Tables(0).Columns
                    Select Case dc.Caption

                        Case "SISTEMA", "CLIENTE", "PLACA", "MARCA", _
                        "ORIGEN", "DESTINO", "TIPO_TRACTO", "CONDUCTOR", "BREVETE", "NUMERO_FACT", "NUMERO_GT", "PERIODO_DEVOLUCION", "PERIODO_TRIBUTARIO", "NUMERO_RUC", "SERIE_FACT", "RUC_CLIENTE", "SERIE_GT", "NRO_MTC", "CLIENTE_FACT", "OPERACION"
                            ', "FECHA_FACT_3", "FECHA_GT_3"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

                        Case "ORDEN", "TIPO_DOCUMENTO", "TIPO_DOCUMENTO1"

                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

                        Case "VALOR_VENTA", "VALOR_VENTA_IGV"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

                    End Select
        Next
                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs, 1)
      Case 2
        If (Me.gwdAnexo31.Rows.Count = 0) Then
          MsgBox("No existen datos a exportar." & TabControl1.TabPages(2).Text, MsgBoxStyle.Information)
          Exit Sub
        End If

        'ExportarAExcel(Me.gwdAnexo31)
        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Anexo 3.1"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Anexo 3.1"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "ANEXO 3.1"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        objDt = CType(Me.gwdAnexo31.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

        ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdAnexo31, objDt))
        For Each dc As DataColumn In ODs.Tables(0).Columns
          Select Case dc.Caption
                        Case "SISTEMA", "PLACA", "MARCA", "NUMERO_FACT", "NUMERO_RUC", "SERIE_FACT", "NRO_MTC", "PERIODO_DEVOLUCION", "PERIODO_TRIBUTARIO"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

                        Case "ORDEN", "TIPO_DOCUMENTO"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
            Case "VALOR_VENTA", "VALOR_VENTA_IGV"
              dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
          End Select
        Next
                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs, 1)
      Case 3
        If (Me.gwdDetalleLiquidado.Rows.Count = 0) Then
          MsgBox("No existen datos a exportar." & TabControl1.TabPages(3).Text, MsgBoxStyle.Information)
          Exit Sub
        End If

        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Vales Liquidados"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Vales Liquidados"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "VALES LIQUIDADOS"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        objDt = CType(Me.gwdDetalleLiquidado.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

        ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDetalleLiquidado, objDt))

        For Each dc As DataColumn In ODs.Tables(0).Columns
          Select Case dc.Caption
                        Case "PLACA", "CBRCNT", "CONDUCTOR", "TRANSPORTISTA", "PROPIO_TERCERO", "ESTACION", "NRO_FACTURA_CLI", "NRO_FACTURA_PRO", "VALE_GRIFO", "RUC_PROVEEDOR", "RUC_TRANPORTISTA", "OPERACION"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                            ', "FECHA_VALE", "FEC_FACTURA_PRO", "FEC_FACTURA_CLI"

                            'Case "FECHA_VALE"
                            '    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)

                        Case "CENTRO_COSTO", "ORDEN", "CLIENTE"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

            Case "CENTRO_COSTO", "ORDEN", "CLIENTE"
              dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

            Case "CANTIDAD_GALONES", "COSTO_GALON", "TOTAL"
              dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

          End Select
        Next
                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs, 1)
      Case 4
        If (Me.gwdDetalleAsignado.Rows.Count = 0) Then
          MsgBox("No existen datos a exportar." & TabControl1.TabPages(4).Text, MsgBoxStyle.Information)
          Exit Sub
        End If

        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Vales Asignados"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Vales Asignados"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "VALES ASIGNADOS"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        objDt = CType(Me.gwdDetalleAsignado.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

        ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDetalleAsignado, objDt))
        For Each dc As DataColumn In ODs.Tables(0).Columns
          Select Case dc.Caption
                        Case "VALE_GRIFO", "PLACA", "CBRCNT", "CONDUCTOR", "TRANSPORTISTA", "PROPIO_TERCERO", "NRO_FACTURA_PRO", "ESTACION", "NRO_FACTURA_CLI", "RUC_TRANPORTISTA", "RUC_PROVEEDOR", "OPERACION"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

                            '"Fecha_Vale", "FEC_FACTURA_PRO", "FEC_FACTURA_CLI"

                            'Case "CFECH"
                            '    dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)

                        Case "CENTRO_COSTO", "ORDEN", "CLIENTE"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

            Case "CANTIDAD_GALONES", "COSTO_GALON", "TOTAL"
              dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
          End Select
        Next
                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs, 1)
      Case 5
        If (Me.gwdDetalleCredito.Rows.Count = 0) Then
          MsgBox("No existen datos a exportar." & TabControl1.TabPages(5).Text, MsgBoxStyle.Information)
          Exit Sub
        End If

        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim loEncabezados As New Generic.List(Of Encabezados)
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Notas de Crédito - Débito"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Notas de Crédito - Débito"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "NOTAS DE CRÉDITO - DÉBITO"))
        loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
        objDt = CType(Me.gwdDetalleCredito.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

        ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDetalleCredito, objDt))
        For Each dc As DataColumn In ODs.Tables(0).Columns
          Select Case dc.Caption
                        Case "CTIPO", "CNOTA", "CSERIEF", "CNUMERO", "CRUCCLI", "RZ_CL"
                            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

                            ', "CFECH", "FEC_NOTA"

            Case "CVVENTA", "IGVPROM"
              dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

          End Select
        Next
                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs, 1)
    End Select
  End Sub

  Private Sub ExportarAExcel(ByVal grilla As DataGridView)
    ''averiguando si es que existe el directorio a exportar
    'Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tempo\"

    'If IO.Directory.Exists(path) = False Then
    '  IO.Directory.CreateDirectory(path)
    'End If
    'Dim archivo As String = path & "reporte" & HelpClass.NowNumeric & ".xls"
    'Dim xls As New IO.StreamWriter(archivo, True, Encoding.Default)

    'xls.WriteLine("<TABLE border='1'>")
    'xls.WriteLine("<tr>")
    'For columna As Integer = 0 To grilla.Columns.Count - 1
    '  xls.Write("<td style='background-color:#FEF7DB'>" & grilla.Columns.Item(columna).HeaderText.ToString() & "</td>")
    'Next
    'xls.WriteLine("</tr>")
    'xls.WriteLine("<tr>")
    'For columna As Integer = 0 To grilla.Columns.Count - 1
    '  xls.Write("<td >" & "</td>")
    'Next
    'xls.WriteLine("</tr>")
    'For fila As Integer = 0 To grilla.Rows.Count - 1
    '  xls.WriteLine("<tr>")
    '  For columna As Integer = 0 To grilla.Columns.Count - 1
    '    If grilla.Item(columna, fila).Value.ToString.Trim.Length > 1 AndAlso (grilla.Item(columna, fila).Value.ToString.Trim.Substring(grilla.Item(columna, fila).Value.ToString.Trim.Length - 2, 2).Trim.Equals("pm") OrElse grilla.Item(columna, fila).Value.ToString.Trim.Substring(grilla.Item(columna, fila).Value.ToString.Trim.Length - 2, 2).Trim.Equals("am")) Then
    '      xls.Write("<td>" & grilla.Item(columna, fila).Value.ToString.Trim.Substring(0, grilla.Item(columna, fila).Value.ToString.Trim.Length - 2).Trim & "</td>")
    '    Else
    '      xls.Write("<td>" & grilla.Item(columna, fila).Value.ToString.Trim & "</td>")
    '    End If
    '  Next
    '  xls.WriteLine("</tr>")
    'Next
    'xls.WriteLine("</TABLE>")
    'xls.Flush()
    'xls.Close()
    'xls.Dispose()
    'Help.ShowHelp(Me, archivo)

  End Sub

  Private Sub PrepararProceesWorked()
    ht = New Hashtable
    'ht.Add("CCMPN", Me.cmbCompania.SelectedValue)
    'ht.Add("CDVSN", Me.cmbDivision.SelectedValue)
    'ht.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
    ht.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
    ht.Add("CDVSN", cmbDivision.Division)
        'ht.Add("CPLNDV", cmbPlanta.Planta)
        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        03/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas

        strPlanta = ""
        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strPlanta += chkcbxPlanta.CheckedItems(i).Value

            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strPlanta = String.Concat(strPlanta, ",")
            End If

        Next



        ht.Add("CPLNDV", strPlanta)
    ht.Add("FECINI", HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaInicio.Value))
    ht.Add("FECFIN", HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaFin.Value))
    ht.Add("CTRSPT", txtTransportista.pCodigoRNS)
    ht.Add("NRUCTR", txtTransportista.pRucTransportista)

    Dim strTipoVehiculo As String = ""
    For i As Integer = 0 To chbTipoVehiculo.CheckedItems.Count - 1
      strTipoVehiculo += chbTipoVehiculo.CheckedItems(i).Value & ","
    Next
    If strTipoVehiculo.Trim.Length > 0 Then
      strTipoVehiculo = strTipoVehiculo.Trim.Substring(0, strTipoVehiculo.Trim.Length - 1)
    End If
    If strTipoVehiculo = "" Then
      Throw New Exception("Debe seleccionar al menos un Tipo de Vehículo")
      ht.Add("CTITRA", "0")
    Else
      ht.Add("CTITRA", strTipoVehiculo)
    End If
  End Sub

  Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
    e.Result = objLogica.Reporte_Guia_Transportista_Facturada(ht)
  End Sub

  Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
    Dim dstreporte As New DataSet
    dstreporte = CType(e.Result, DataSet)
    'HeaderGroupFiltro.Enabled = True
    If dstreporte Is Nothing Then
      Me.gwdDatos.DataSource = Nothing
      Me.gwdAnexo3.DataSource = Nothing
      Me.gwdAnexo31.DataSource = Nothing
      Me.gwdDetalleLiquidado.DataSource = Nothing
      Me.gwdDetalleCredito.DataSource = Nothing
      Me.gwdDetalleAsignado.DataSource = Nothing
      Exit Sub
        End If
        For x As Integer = 0 To dstreporte.Tables(0).Rows.Count - 1
            dstreporte.Tables(0).Rows(x)("FECHA_FACT") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECHA_FACT").ToString)
            dstreporte.Tables(0).Rows(x)("FECHA_GT") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECHA_GT").ToString)
        Next
        For x As Integer = 0 To dstreporte.Tables(1).Rows.Count - 1
            dstreporte.Tables(1).Rows(x)("FECHA_FACT_3") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(1).Rows(x)("FECHA_FACT_3").ToString)
            dstreporte.Tables(1).Rows(x)("FECHA_GT_3") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(1).Rows(x)("FECHA_GT_3").ToString)
        Next
        For x As Integer = 0 To dstreporte.Tables(2).Rows.Count - 1
            dstreporte.Tables(2).Rows(x)("FECHA_FACT_31") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(2).Rows(x)("FECHA_FACT_31").ToString)

        Next
        For x As Integer = 0 To dstreporte.Tables(3).Rows.Count - 1
            dstreporte.Tables(3).Rows(x)("FECHA_VALE") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(3).Rows(x)("Fecha_Vale").ToString)
            dstreporte.Tables(3).Rows(x)("FEC_FACTURA_PRO") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(3).Rows(x)("FEC_FACTURA_PRO").ToString)
        Next
        For x As Integer = 0 To dstreporte.Tables(4).Rows.Count - 1
            dstreporte.Tables(4).Rows(x)("FECHA_VALE") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(4).Rows(x)("Fecha_Vale").ToString)
            dstreporte.Tables(4).Rows(x)("FEC_FACTURA_PRO") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(4).Rows(x)("FEC_FACTURA_PRO").ToString)
        Next
        For x As Integer = 0 To dstreporte.Tables(5).Rows.Count - 1
            dstreporte.Tables(5).Rows(x)("CFECH") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(5).Rows(x)("CFECH").ToString)

        Next
        Try
            Me.gwdDatos.DataSource = dstreporte.Tables(0)
            Me.gwdAnexo3.DataSource = dstreporte.Tables(1)
            Me.gwdAnexo31.DataSource = dstreporte.Tables(2)
            Me.gwdDetalleLiquidado.DataSource = dstreporte.Tables(3)
            Me.gwdDetalleAsignado.DataSource = dstreporte.Tables(4)
            Me.gwdDetalleCredito.DataSource = dstreporte.Tables(5)
           
            
            Me.Cursor = Cursors.Default
            'Visualizar mensaje
            pbxProceso.Visible = False
            lblProceso.Visible = False
            lblProceso.Text = "Finalizado..."
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            ClearMemory()
        Finally
            MenuBar.Enabled = True
        End Try
    End Sub

  Private Sub ActivarRangoFecha(ByVal activar As Boolean)
    dtpFechaInicio.Enabled = activar
    dtpFechaFin.Enabled = activar
  End Sub

#Region "Planta"
  Private Sub Cargar_Compania()
    cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

  End Sub
    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                Me.Limpiar()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            Me.cmbPlanta.Usuario = MainModule.USUARIO
            Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            Me.cmbPlanta.PlantaDefault = 1
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                ' Me.cmbPlanta.pActualizar()
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
  Private Sub Limpiar()
    InicializarFormulario()
  End Sub

    ' Agregado por: Hugo Pérez Ryan
    ' Fecha:        03/03/2012
    ' Descripción:  Se está modificando para que la consulta 
    ' pueda ser utilizada para escoger una o más plantas
    Private Sub Cargar_Planta()

        chkcbxPlanta.Text = ""
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try

            If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cmbDivision.Division IsNot Nothing) Then

                objPlanta.Crea_Lista()
                '
                objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                chkcbxPlanta.DisplayMember = "TPLNTA"
                chkcbxPlanta.ValueMember = "CPLNDV"
                Me.chkcbxPlanta.DataSource = objLisEntidad

                For i As Integer = 0 To chkcbxPlanta.Items.Count - 1
                    If chkcbxPlanta.Items.Item(i).Value = "1" Then
                        chkcbxPlanta.SetItemChecked(i, True)
                    End If
                Next

                If chkcbxPlanta.Text = "" Then
                    chkcbxPlanta.SetItemChecked(0, True)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region


End Class
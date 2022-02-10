Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOptRepReparto

#Region "Atributo Y Propiedad"
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Int32 = 0
  Private _CCMPN_D As String
  Private _CDVSN_D As String = ""
  Private _CPLNDV_D As String = ""
  Private dgwPreFacturacionChk As Boolean = False
  Private _lintEstado As Int32 = 0
  Private _Titulo As String = ""
  Private _Tipo As String = ""
  Private _Fecha As Date = Today
  Private _TCMPCL As String = ""

  Public WriteOnly Property Cliente() As String
    Set(ByVal value As String)
      _TCMPCL = value
    End Set
  End Property

  Public WriteOnly Property Fecha() As String
    Set(ByVal value As String)
      _Fecha = value
    End Set
  End Property

  Public WriteOnly Property Titulo() As String
    Set(ByVal value As String)
      _Titulo = value
    End Set
  End Property
  Public WriteOnly Property Tipo() As String
    Set(ByVal value As String)
      _Tipo = value
    End Set
  End Property

  Public WriteOnly Property Estado() As Int32
    Set(ByVal value As Int32)
      _lintEstado = value
    End Set
  End Property

  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As Int32
    Set(ByVal value As Int32)
      _CPLNDV = value
    End Set
  End Property

  Public WriteOnly Property Compania() As String
    Set(ByVal value As String)
      _CCMPN_D = value
    End Set
  End Property

  Public WriteOnly Property Division() As String
    Set(ByVal value As String)
      _CDVSN_D = value
    End Set
  End Property

  Public WriteOnly Property Planta() As String
    Set(ByVal value As String)
      _CPLNDV_D = value
    End Set
  End Property

#End Region

#Region "Métodos"

#End Region

#Region "Eventos Sustento Factura"

    Private dtDocumento As New DataTable
  Private Sub frmOptRepReparto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Select Case _lintEstado
      Case 0, 3
        Me.btnImprimirSustento.Visible = False
      Case 1
        Me.btnProcesarConsulta.Visible = False
    End Select
    If _Tipo = "Consistencia" Then
      Me.Text = _Titulo
      lblOrdenServicio.Text = "Nro. Operación :"
      btnImprimirSustento.Text = "Imprimir Consistencia"
    ElseIf _Tipo = "Pre Liquidación" Then
      Me.Text = _Titulo
      lblOrdenServicio.Text = "Nro. Pre Liquidación :"
      btnImprimirSustento.Text = "Imprimir"
    Else
      Dim obj_Entidad_TipoDocumento As New TipoDocumento
      Dim obj_Logica_TipoDocumento As New TipoDocumento_BLL
            With Me.cboTipoDocumento
                dtDocumento = HelpClass.GetDataSetNative(obj_Logica_TipoDocumento.Listar_Tipo_Documento(obj_Entidad_TipoDocumento))
                .DataSource = dtDocumento
                .ValueMember = "CTPODC"
                .DisplayMember = "TCMTPD"
            End With
      Me.Text = _Titulo
    End If
  End Sub

  Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
    Try
      Select Case _lintEstado
        Case 0
          Dim obj_Logica As New Repartos_BLL
          Dim objHashTable As New Hashtable
          objHashTable.Add("PSCCMPN", _CCMPN)
          objHashTable.Add("PSCDVSN", _CDVSN)
          objHashTable.Add("PNNDCMFC", Me.txtNroFactura.Text)
          Me.Exportar_Excel(obj_Logica.Exportar_Factura_Reparto(objHashTable))
        Case 2
          Dim obj_Logica As New PreLiquidacion_BLL
          Dim oTransporte As New ENTIDADES.Operaciones.Factura_Transporte
          Dim oDtb As New DataTable
          Dim ListaParametros As New List(Of String)
          ListaParametros.Add(txtNroFactura.Text)
          ListaParametros.Add(_CCMPN)
          ListaParametros.Add(_CDVSN)
          ListaParametros.Add(_CPLNDV)
          ListaParametros.Add(HelpClass.TodayNumeric)
          oDtb = obj_Logica.Imprimir_Reporte_Pre_Liquidacion(ListaParametros).Tables(0)
          'oDtb.Columns.Remove("NDCPRF")
          'oDtb.Columns.Remove("NOPRCN")
          oDtb.Columns.Remove("PBRTOR")
          oDtb.Columns.Remove("CSTNDT")
          oDtb.Columns.Remove("QMRCDR")
          'oDtb.Columns.Remove("PESOL")
          Dim intNDCPRF As Int64 = 0
          Dim intNMNFCR As Int64 = 0
          Dim intNGUITR As Int64 = 0
          Dim objlist As New List(Of DataRow)
          For Each objRow As DataRow In oDtb.Rows
            objRow("PESOL") = objRow("PESOL") / 1000
            If intNDCPRF = objRow("NDCPRF") Then
              objRow("NDCPRF") = DBNull.Value
            Else
              intNDCPRF = objRow("NDCPRF")
            End If

            If intNMNFCR = objRow("NMNFCR") And intNGUITR = objRow("NGUITR") Then
              'objlist.Add(objRow)
              objRow("NOREMB") = ""
              objRow("NOPRCN") = DBNull.Value
              objRow("NMNFCR") = DBNull.Value
              objRow("NGUITR") = DBNull.Value
              objRow("CMRCDR") = ""
              objRow("CLCLOR") = ""
              objRow("CLCLDS") = ""
              objRow("NPLVHT") = ""
              objRow("TDSTRT") = ""
              objRow("CBRCNT") = ""
              objRow("NPLCAC") = ""
              objRow("TUNDVH") = ""
              objRow("FSLDCM") = ""
              objRow("FLLGCM") = ""
              objRow("ISRVGU_S") = DBNull.Value
              objRow("ISRVGU_1_S") = DBNull.Value
              objRow("ISRVGU_D") = DBNull.Value
              objRow("ISRVGU_1_D") = DBNull.Value
              objRow("TCNFVH") = ""
              objRow("NDCORM") = DBNull.Value
              objRow("PESOL") = DBNull.Value
              'objRow("QMRCDR") = DBNull.Value
              objRow("VLRFDT") = DBNull.Value
            Else
              intNMNFCR = objRow("NMNFCR")
              intNGUITR = objRow("NGUITR")
            End If
          Next
          'For Each objDataRow As DataRow In objlist
          '  oDtb.Rows.Remove(objDataRow)
          'Next

          oDtb.Columns("NDCPRF").ColumnName = "Nro Pre Factura"
          oDtb.Columns("NOREMB").ColumnName = "Referencia Embarcador"
          oDtb.Columns("NOPRCN").ColumnName = "Operación"
          oDtb.Columns("NMNFCR").ColumnName = "Guía Transportista"
          oDtb.Columns("NGUITR").ColumnName = "Guía Remisión"
          oDtb.Columns("CMRCDR").ColumnName = "Descripción de Materiales"
          oDtb.Columns("CLCLOR").ColumnName = "Punto Partida"
          oDtb.Columns("CLCLDS").ColumnName = "Punto Llegada"
          oDtb.Columns("NPLVHT").ColumnName = "Placa Tracto"
          oDtb.Columns("NPLCAC").ColumnName = "Placa Acoplado"
          oDtb.Columns("TDSTRT").ColumnName = "Conductor"
          oDtb.Columns("CBRCNT").ColumnName = "Brevete"

          oDtb.Columns("TUNDVH").ColumnName = "Tipo Vehículo"
          oDtb.Columns("FSLDCM").ColumnName = "Fecha Salida"
          oDtb.Columns("FLLGCM").ColumnName = "Fecha Llegada"
          oDtb.Columns("ISRVGU_S").ColumnName = "Tarifa / Flete (SOL)"
          oDtb.Columns("ISRVGU_1_S").ColumnName = "Adicional (SOL)"
          oDtb.Columns("ISRVGU_D").ColumnName = "Tarifa / Flete (DOL)"
          oDtb.Columns("ISRVGU_1_D").ColumnName = "Adicional (DOL)"
          oDtb.Columns("PESOL").ColumnName = "Peso TN."
          oDtb.Columns("NDCORM").ColumnName = "O/S Agencia"
          oDtb.Columns("NORCML").ColumnName = "Orden de Compra"
          oDtb.Columns("TCNFVH").ColumnName = "Config."
          oDtb.Columns("VLRFDT").ColumnName = "Valor Referencia (S/.)"

          Dim oLis As New List(Of DataTable)
          Dim oHash As New Hashtable
          oHash.Add("COMPAÑIA : ", Me._CCMPN_D)
          oHash.Add("DIVISIÓN : ", Me._CDVSN_D)
          oHash.Add("PLANTA   : ", Me._CPLNDV_D)
          oLis.Add(oDtb.Copy)
          Ransa.Utilitario.HelpClass_NPOI.ExportExcel(oLis, "FACTURACION TRANSPORTE / PRE APROBACION" + " ( PL N° " + Me.txtNroFactura.Text.Trim + " )", oHash)

        Case 3
          If Me.txtNroFactura.Text.Trim.Equals("") Then Exit Sub
          Dim listCabecera_Movimiento As New Hashtable
          Dim objParametros As New Hashtable
          'DESPACHOS

          With objParametros
            .Add("CCMPN", Me._CCMPN)
            .Add("CDVSN", "R")
            .Add("NPRLQD", Me.txtNroFactura.Text)
          End With

          Dim objNegocio As New PreLiquidacion_BLL
          Dim loDespachoMovimientos_BE As New Data.DataTable
          loDespachoMovimientos_BE = objNegocio.ListarMovimiento_PreLiquidacion(objParametros)

          loDespachoMovimientos_BE.DefaultView.Sort = "TCMPCL,PLANTA,CREFFW,NSEQIN"
          loDespachoMovimientos_BE = loDespachoMovimientos_BE.DefaultView.ToTable()

          'Crea Una Rutina k limpia los Datos Solo para el Exportar.

          With listCabecera_Movimiento
            .Add("TITULO", "REPORTE VALORIZADO")
            .Add("COMPAÑIA : ", Me._CCMPN_D)
            .Add("DIVISION : ", Me._CDVSN_D)
            .Add("CLIENTE  : ", _TCMPCL)
            .Add("PRE LIQUIDACIÓN : ", Me.txtNroFactura.Text)
          End With

          Dim ds As New Data.DataSet
          ds.Tables.Add(loDespachoMovimientos_BE.Copy)

          ' Dim obrIngresoMovimientos_BLL As New SOLMIN_WEB.NEGOCIO.IngresoMovimientos_BLL
          Ransa.Utilitario.HelpClass_NPOI.ExportExcelDespacho("Despacho", listCabecera_Movimiento, objNegocio.CrearResumenes_Despacho(ds.Tables(0)), Me.Obtener_Grilla)

      End Select

    Catch : End Try

  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtNroFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroFactura.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Function Tabla() As DataTable
    Dim dt As New DataTable
    dt.Columns.Add("Item")
    dt.Columns.Add("Tipo")
    dt.Columns.Add("Fecha")
    dt.Columns.Add("Nº Hoja Carguio")
    dt.Columns.Add("Nº Factura Primax")
    dt.Columns.Add("Planta Callao_Diesel")
    dt.Columns.Add("Planta Callao_Gasolinas")
    dt.Columns.Add("Planta Conchan_Diesel")
    dt.Columns.Add("Planta Conchan_Gasolinas")
    dt.Columns.Add("Total Galones")
    dt.Columns.Add("Km")
    dt.Columns.Add("Flete Ransa")
    dt.Columns.Add("Valor Venta S/")
    dt.Columns.Add("Valor Referencial")
    dt.Columns.Add("Operación")
    dt.Columns.Add("Factura Ransa")
    Return dt
  End Function

  Private Function Fila(ByRef dt As DataTable, _
  ByVal Item As String, _
  ByVal Tipo As String, _
  ByVal Fecha As String, _
  ByVal NroHojaCarguio As String, _
  ByVal NroFacturaPrimax As String, _
  ByVal PlantaCallao_Diesel As String, _
  ByVal PlantaCallao_Gasolinas As String, _
  ByVal PlantaConchan_Diesel As String, _
  ByVal PlantaConchan_Gasolinas As String, _
  ByVal TotalGalones As String, _
  ByVal Km As String, _
  ByVal FleteRansa As String, _
  ByVal ValorVentaS As String, _
  ByVal ValorReferencial As String, _
  ByVal Operación As String, _
  ByVal FacturaRansa As String)
    Dim dr As DataRow = dt.NewRow
    dr("Item") = Item
    dr("Tipo") = Tipo
    dr("Fecha") = Fecha
    dr("Nº Hoja Carguio") = NroHojaCarguio
    dr("Nº Factura Primax") = NroFacturaPrimax
    dr("Planta Callao_Diesel") = PlantaCallao_Diesel
    dr("Planta Callao_Gasolinas") = PlantaCallao_Gasolinas
    dr("Planta Conchan_Diesel") = PlantaConchan_Diesel
    dr("Planta Conchan_Gasolinas") = PlantaConchan_Gasolinas
    dr("Total Galones") = TotalGalones
    dr("Km") = Km
    dr("Flete Ransa") = FleteRansa
    dr("Valor Venta S/") = ValorVentaS
    dr("Valor Referencial") = ValorReferencial
    dr("Operación") = Operación
    dr("Factura Ransa") = FacturaRansa
    dt.Rows.Add(dr)
    Return dt
  End Function

  Private Sub Exportar_Excel(ByVal dtExportarExcel As DataTable)

    Dim dt As DataTable = Tabla()
    Dim drow As DataRow
    Dim ldobGasolinaCallao As Double = 0.0
    Dim ldobDieselCallao As Double = 0.0
    Dim ldobGasolinaOtro As Double = 0.0
    Dim ldobDieselOtro As Double = 0.0

    Dim ldobTotalKM As Double = 0.0
    Dim ldobValorVenta As Double = 0.0
    Dim ldobValorReferencial As Double = 0.0
    Dim ldobTotalGalones As Double = 0.0

    With dtExportarExcel
      For lintContador As Integer = 0 To .Rows.Count - 1
        drow = dt.NewRow
        drow("Item") = ""
        drow("Tipo") = ""
        drow("Fecha") = .Rows(lintContador).Item("FSLDCM").ToString.Trim
        drow("Nº Hoja Carguio") = Format(.Rows(lintContador).Item("NRHJCR"), "##########")
        drow("Nº Factura Primax") = Format(.Rows(lintContador).Item("NGUITR"), "##########")
        If .Rows(lintContador).Item("CPLNDV").ToString.Trim.Equals("1") Then
          drow("Planta Callao_Gasolinas") = Format(.Rows(lintContador).Item("QGLGSL"), "###,###,###.##")
          drow("Planta Callao_Diesel") = Format(.Rows(lintContador).Item("QGLDSL"), "###,###,###.##")
          drow("Planta Conchan_Gasolinas") = "0.00"
          drow("Planta Conchan_Diesel") = "0.00"
          ldobGasolinaCallao += .Rows(lintContador).Item("QGLGSL")
          ldobDieselCallao += .Rows(lintContador).Item("QGLDSL")
        Else
          drow("Planta Conchan_Gasolinas") = Format(.Rows(lintContador).Item("QGLGSL"), "###,###,###.##")
          drow("Planta Conchan_Diesel") = Format(.Rows(lintContador).Item("QGLDSL"), "###,###,###.##")
          drow("Planta Callao_Gasolinas") = "0.00"
          drow("Planta Callao_Diesel") = "0.00"
          ldobGasolinaOtro += .Rows(lintContador).Item("QGLGSL")
          ldobDieselOtro += .Rows(lintContador).Item("QGLDSL")
        End If
        drow("Total Galones") = Format(.Rows(lintContador).Item("TOTGAL"), "###,###,###.##")
        drow("Km") = Format(.Rows(lintContador).Item("QCNDTG"), "###,###,###.##")
        drow("Flete Ransa") = Format(.Rows(lintContador).Item("ISRVGU"), "###,###,###.####")
        drow("Valor Venta S/") = Format(.Rows(lintContador).Item("TOTMND"), "###,###,###.####")
        drow("Valor Referencial") = Format(.Rows(lintContador).Item("VLRFDT"), "###,###,###.####")
        drow("Operación") = Format(.Rows(lintContador).Item("NOPRCN"), "##########")
        drow("Factura Ransa") = Format(.Rows(lintContador).Item("NDCMFC"), "##########")
        ldobTotalKM += IIf(drow("Km") = "", 0, Format(.Rows(lintContador).Item("QCNDTG"), "###,###,###.##"))
        ldobValorVenta += IIf(drow("Valor Venta S/") = "", 0, Format(.Rows(lintContador).Item("TOTMND"), "###,###,###.##"))
        ldobValorReferencial += IIf(drow("Valor Referencial") = "", 0, Format(.Rows(lintContador).Item("VLRFDT"), "###,###,###.##"))
        ldobTotalGalones += IIf(drow("Total Galones") = "", 0, Format(.Rows(lintContador).Item("TOTGAL"), "###,###,###.##"))
        dt.Rows.Add(drow)

      Next
    End With
    Fila(dt, " ", " ", "          ", "      ", "         ", "         ", "         ", " ", " ", "         ", "   ", "      ", "      ", "        ", "      ", "          ")
    Fila(dt, " ", " ", "          ", "      ", "         ", Format(ldobDieselCallao, "###,###,###.##"), Format(ldobGasolinaCallao, "###,###,###.##"), Format(ldobDieselOtro, "###,###,###.##"), Format(ldobGasolinaOtro, "###,###,###.##"), Format(ldobTotalGalones, "###,###,###.##"), Format(ldobTotalKM, "###,###,###.##"), "      ", Format(ldobValorVenta, "###,###,###.####"), Format(ldobValorReferencial, "###,###,###.####"), "      ", "          ")
    Fila(dt, " ", " ", "          ", "      ", "         ", "         ", "         ", " ", " ", "         ", "   ", "      ", "      ", "        ", "      ", "          ")

    Fila(dt, " ", " ", "          ", "      ", "         ", "         ", "         ", " ", " ", "         ", "", "VALOR VENTA", Format(ldobValorVenta, "###,###,###.####"), "        ", "      ", "          ")
    Fila(dt, " ", " ", "          ", "      ", "         ", "         ", "         ", " ", " ", "         ", "", "    IGV 19%", Format((ldobValorVenta * 0.19), "###,###,###.##"), "        ", "      ", "          ")
    Fila(dt, " ", " ", "          ", "      ", "         ", "         ", "         ", " ", " ", "         ", "", "      TOTAL", Format((ldobValorVenta + (ldobValorVenta * 0.19)), "###,###,###.####"), "        ", "      ", "          ")


    If dt.Rows.Count = 0 Then Return
    '/////////////////////////////////////////////////
    '// Quitamos columnas que no se usaran
    '/////////////////////////////////////////////////
    Dim oDtExcel As DataTable
    oDtExcel = dt.Copy()
    '/////////////////////////////
    '// Creamos el Objeto StreamWriter
    '/////////////////////////////
    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tempo\"
    If IO.Directory.Exists(path) = False Then
      IO.Directory.CreateDirectory(path)
    End If
    Dim archivo As String = path & "Reporte" & HelpClass.NowNumeric() & ".xls" 'xml
    Dim xls As New IO.StreamWriter(archivo, True, Encoding.Default)

    '/////////////////////////////////////////////////
    '// Iniciamos Tabla html
    '/////////////////////////////////////////////////
    xls.WriteLine("<TABLE border='1'>")
    xls.WriteLine("<tr>")
    xls.WriteLine("<tr>")
    xls.WriteLine("<tr>")
    '/////////////////////////////////////////////////
    '// Armamos la linea con los títulos de columnas
    '/////////////////////////////////////////////////   
    For Each dc As DataColumn In oDtExcel.Columns
      Dim Value As String = String.Empty
      Value = NameFormat(dc.ColumnName)
      Value = Replace(Value, """", String.Empty)
      If Value.EndsWith("_Diesel") Or Value.EndsWith("_Gasolinas") Then
        If Value.EndsWith("_Diesel") Then
          Value = Value.Substring(0, Value.Length - "_Diesel".Length)
          xls.Write("<td colspan='2' style='background:blue; color:white; vertical-align:middle;text-align:center; line-height:18px; Font(-weight): bold()' >")
          xls.Write(Value)
          xls.Write("</td>")
        End If
      Else
        xls.Write("<td rowspan='2' style='background:blue; color:white;vertical-align:middle; text-align:center; line-height:18px; Font(-weight): bold()' >")
        xls.Write(Value)
        xls.Write("</td>")
      End If
    Next
    xls.WriteLine("</tr>")
    xls.WriteLine("<tr>")
    For Each dc As DataColumn In oDtExcel.Columns
      Dim Value As String = String.Empty
      Value = NameFormat(dc.ColumnName)
      Value = Replace(Value, """", String.Empty)
      If Value.EndsWith("_Diesel") Or Value.EndsWith("_Gasolinas") Then
        xls.Write("<td  style='background:blue; color:white; color:white;vertical-align:middle; text-align:center; line-height:18px; Font(-weight): bold()' >")
        xls.Write(IIf(Value.EndsWith("_Diesel"), "Diesel", "Gasolinas"))
        xls.Write("</td>")
      End If
    Next
    xls.WriteLine("</tr>")

    '/////////////////////////////////////////////////
    '// Armamos filas
    '/////////////////////////////////////////////////
    For Each dr As DataRow In oDtExcel.Rows
      xls.WriteLine("<tr>")
      For Each dc As DataColumn In oDtExcel.Columns
        Dim Value As String = String.Empty
        Value = dr(dc.ColumnName).ToString().Trim()
        xls.Write("<td>")
        xls.Write(Value)
        xls.Write("</td>")
      Next
      xls.WriteLine("</tr>")
    Next

    xls.WriteLine("</TABLE>")
    xls.Flush()
    xls.Close()
    xls.Dispose()
    AbrirDocumento(archivo)
  End Sub

  Private Function NameFormat(ByVal ColumnName) As String
    Dim Name As String = ColumnName
    Select Case ColumnName
      Case "NRPEMB" : Name = "PRE EMBARQUE"
      Case "NORSCI" : Name = "NORSCI"
      Case "NRPEM" : Name = "NRPEM"
      Case "CCLNT" : Name = "CCLNT"
      Case "NORCML" : Name = "O/C"
      Case "FORCML" : Name = "FECHA DE O/C"
      Case "FROCMP" : Name = "FECHA DE<br>CONFIRMACION DE O/C"
      Case "TTINTC" : Name = "INCOTERM"
      Case "TCTCST" : Name = "C/C"
      Case "NRPARC" : Name = "NRO PARCIAL<br>DE O/C"
      Case "TPRVCL" : Name = "NOMBRE DEL PROVEEDOR"
      Case "NRITOC" : Name = "ITEM"
      Case "SBITOC" : Name = "SUB ITEM"
      Case "TDITES" : Name = "DESCRIPCION DEL PRODUCTO"
      Case "QCNTIT" : Name = "CANTIDAD<br>SOLICITUD"
      Case "QCNEMB" : Name = "CANTIDAD<br>ATENDIDA"
      Case "QCNPED" : Name = "CANTIDAD<br>PENDIENTE"
      Case "QRLCSC" : Name = "CANTIDAD<br>PRE EMBARCADA"
      Case "TUNDIT" : Name = "UNIDAD<br>COMERCIAL"
      Case "IVUNIT" : Name = "VALOR<br>UNITARIO"
      Case "IVTOIT" : Name = "VALOR TOTAL"
      Case "NMONOC" : Name = "MONEDA<br>DE COMPRA"
      Case "FMPDME" : Name = "FECHA DE ENTREGA<br>PROMETIDA"
      Case "FMPIME" : Name = "FECHA REQUERIDA<br>EN PLANTA"
      Case "TOBS" : Name = "OBSERVACIONES"
    End Select
    Return Name
  End Function

  Private Function AlignText(ByVal Text As Object) As String
    Dim Align As String = "Center"
    Select Case True
      Case IsNumeric(Text) : Align = "Right"
      Case IsDate(Text) : Align = "Center"
      Case Else : Align = "Left"
    End Select
    Return Align
  End Function

  Private Sub AbrirDocumento(ByVal Path As String)
    Try
      Dim InfoProceso As New System.Diagnostics.ProcessStartInfo
      Dim Proceso As New System.Diagnostics.Process
      With InfoProceso
        .FileName = Path
        .CreateNoWindow = True
        .ErrorDialog = True
        .UseShellExecute = True
        .WindowStyle = ProcessWindowStyle.Normal
      End With
      Proceso.StartInfo = InfoProceso
      Proceso.Start()
      Proceso.Dispose()
    Catch
    End Try
  End Sub

  Private Sub btnImprimirSustento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirSustento.Click
    If _Tipo = "Consistencia" Then
      ImprimirConsistencia()
      Exit Sub
    End If
    If _Tipo = "Pre Liquidación" Then
      ImprimirPreLiquidacion()
      Exit Sub
    End If
    Dim obj_Logica As New Factura_Transporte_BLL
    Dim objPrintForm As New PrintForm
    Dim objDs As New DataSet
    Dim objDt As New DataTable
    Dim objetoRepFact As New rptSustento_Factura
    Dim objetoRepBole As New rptSustento_Boleta
    Dim objParametro As New Hashtable
    Try
      If Me.txtNroFactura.Text.Trim.Length = 0 Then Exit Sub
      objParametro.Add("PNCTPODC", Me.cboTipoDocumento.SelectedValue)
      objParametro.Add("PNNDCMFC", Me.txtNroFactura.Text)
      objParametro.Add("PSCCMPN", _CCMPN)
      objParametro.Add("PSCDVSN", _CDVSN)
      objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Sustento_Factura(objParametro))
            objDt.TableName = "RZCT01"

            Dim DesAbrDoc As String = ""
            Dim drDoc() As DataRow
            Dim TipoDoc As Decimal = Me.cboTipoDocumento.SelectedValue
            drDoc = dtDocumento.Select("CTPODC='" & TipoDoc & "'")
            If drDoc.Length > 0 Then
                If TipoDoc = 51 Or TipoDoc = 57 Then
                    DesAbrDoc = drDoc(0)("TABTPD")
                End If
            End If


            Dim oFiltro As New Hashtable
            Dim oFacturaNeg As New Factura_Transporte_BLL
            Dim dtdocSAP As New DataTable
            Dim strNumSAP As String = ""
            oFiltro.Add("PSCCMPN", _CCMPN)
            oFiltro.Add("PNCTPODC", TipoDoc)
            oFiltro.Add("PNNDCCTC", Me.txtNroFactura.Text)
            dtdocSAP = oFacturaNeg.Comprobar_Envio_Documento_SAP(oFiltro)
            If dtdocSAP.Rows.Count > 0 Then
                strNumSAP = dtdocSAP.Rows(0).Item("NDCCTE").ToString.Trim
               

            End If




            If objDt.Rows.Count = 0 Then
                HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
                Exit Sub
            End If
            objDs.Tables.Add(objDt.Copy)

            Select Case Me.cboTipoDocumento.SelectedValue
                Case 1, 51
                    objetoRepFact.SetDataSource(objDs)
                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = _CCMPN_D
                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = _CDVSN_D
                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = _CPLNDV_D
                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblFactura"), TextObject).Text = "FACTURA N° " & Me.txtNroFactura.Text.Trim & "   " & strNumSAP
                    objPrintForm.ShowForm(objetoRepFact, Me)

                Case 7, 57

                    objetoRepBole.SetDataSource(objDs)
                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = _CCMPN_D
                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = _CDVSN_D
                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = _CPLNDV_D
                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblFactura"), TextObject).Text = "BOLETA DE VENTA N° " & Me.txtNroFactura.Text.Trim & "   " & strNumSAP
                    objPrintForm.ShowForm(objetoRepBole, Me)
            End Select


        Catch : End Try

  End Sub

  Private Function Obtener_Grilla() As DataGridView
    Dim objDgView As New DataGridView
    objDgView.Columns.Add("TCMPCL", "Cliente")
    objDgView.Columns.Add("PLANTA", "Planta")
    objDgView.Columns.Add("CREFFW", "Bulto")
    objDgView.Columns.Add("NSEQIN", "NSEQIN")
    objDgView.Columns.Add("DESCWB", "Descripción")
    objDgView.Columns.Add("QBLTSR", "Cant. Despachada")
    objDgView.Columns.Add("TUNDIT", "Unidad Medida")
    objDgView.Columns.Add("QPEPQT", "Peso Despachado")
    objDgView.Columns.Add("TUNPSO", "Unidad Peso")
    objDgView.Columns.Add("QVLBTO", "Volumen Bulto")
    objDgView.Columns.Add("TUNVOL", "Unidad Volumen")
    objDgView.Columns.Add("TPRVCL", "Proveedor")
    objDgView.Columns.Add("NORCML", "Orden de Compra")
    objDgView.Columns.Add("TCMAEM", "Área Solicitante")
    objDgView.Columns.Add("TIPO", "Tipo Movimiento")
    objDgView.Columns.Add("TRFRNA", "Código Lote")
    objDgView.Columns.Add("TLUGEN", "Lugar Entrega")
    objDgView.Columns.Add("FREFFW", "F. Recep. CL")
    objDgView.Columns.Add("FSLFFW", "F. Salida C.L")
    objDgView.Columns.Add("DIASCL", "Días C.L")
    objDgView.Columns.Add("FINGAL", "F. Recep. Almacén (O.L)")
    objDgView.Columns.Add("FSLDAL", "F. Salida Almacén (O.L)")
    objDgView.Columns.Add("DIAS", "Días Almacén (O.L)")
    objDgView.Columns.Add("NGUIRM", "Guía Remisión")
    objDgView.Columns.Add("GRMEDENVIO", "Medio Envio G/R")
    objDgView.Columns.Add("GRTCMTRT", "Transportista")
    objDgView.Columns.Add("GRNPLCCM", "Placa")
    objDgView.Columns.Add("GRNPLACP", "Acoplado")
    objDgView.Columns.Add("FLGCNL", "Estado Entrega")
    objDgView.Columns.Add("FCNFCL", "Fecha Confirmación")
    objDgView.Columns.Add("HCNFCL", "Hora Confirmación")
    objDgView.Columns.Add("SENTIDO", "Sentido de Carga")
    objDgView.Columns.Add("CZNALM", "Almacen/Zona")
    objDgView.Columns.Add("1_MEDENVIO", "1_Medio Envio")
    objDgView.Columns.Add("1_GUIATRANS", "1_Guía Transp.")
    objDgView.Columns.Add("1_FGUIRM", "1_Fecha Guía Transp.")
    objDgView.Columns.Add("1_TUNDVH", "1_Tipo Unidad")
    objDgView.Columns.Add("1_RUTA", "1_Ruta")
    objDgView.Columns.Add("1_TCMTRT", "1_Transportista")
    objDgView.Columns.Add("1_NPLCTR", "1_Placa")
    objDgView.Columns.Add("1_NPLCAC", "1_Acoplado")
    objDgView.Columns.Add("1_CUENTA", "1_Cuenta")
    objDgView.Columns.Add("1_FCHFTR", "1_Fecha de Llegada")
    objDgView.Columns.Add("3_MEDENVIO", "3_Medio Envio")
    objDgView.Columns.Add("3_GUIATRANS", "3_Guía Transp.")
    objDgView.Columns.Add("3_FGUIRM", "3_Fecha Guía Transp.")
    objDgView.Columns.Add("3_TUNDVH", "3_Tipo Unidad")
    objDgView.Columns.Add("3_RUTA", "3_Ruta")
    objDgView.Columns.Add("3_TCMTRT", "3_Transportista")
    objDgView.Columns.Add("3_NPLCTR", "3_Avión")
    objDgView.Columns.Add("3_NPLCAC", "3_Acoplado")
    objDgView.Columns.Add("3_CUENTA", "3_Cuenta")
    objDgView.Columns.Add("3_FCHFTR", "3_Fecha de Llegada")
    objDgView.Columns.Add("2_MEDENVIO", "2_Medio Envio")
    objDgView.Columns.Add("2_GUIATRANS", "2_Guía Transp.")
    objDgView.Columns.Add("2_FGUIRM", "2_Fecha Guía Transp.")
    objDgView.Columns.Add("2_TUNDVH", "2_Tipo Unidad")
    objDgView.Columns.Add("2_RUTA", "2_Ruta")
    objDgView.Columns.Add("2_TCMTRT", "2_Transportista")
    objDgView.Columns.Add("2_NPLCTR", "2_Empujador")
    objDgView.Columns.Add("2_NPLCAC", "2_Artefacto")
    objDgView.Columns.Add("2_CUENTA", "2_Cuenta")
    objDgView.Columns.Add("2_FCHFTR", "2_Fecha de Llegada")
    objDgView.Columns.Add("TCTAFE", "Cuenta AFE")
    Return objDgView
  End Function

#End Region

#Region "Eventos Reimpresion de Consistencia por Operacion"
  Private Sub ImprimirConsistencia()
    Dim obj_Logica As New Factura_Transporte_BLL
    Dim objPrintForm As New PrintForm
    Dim objDs As New DataSet
    Dim objDt As New DataTable
    Dim objetoRep As New rptConsistencia_Factura
    Dim objParametro As New Hashtable
    Try
      objParametro.Add("PSNOPRCN", txtNroFactura.Text) 'lstr_Cadena
      objParametro.Add("PSCCMPN", _CCMPN)
      objParametro.Add("PSCDVSN", _CDVSN)
      objParametro.Add("PNFECHA", HelpClass.CDate_a_Numero8Digitos(_Fecha)) 'Me.dtpFechaConsistencia.Value
      objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Consistencia_Factura_x_Orden_Servicio(objParametro))
      objDt.TableName = "RZCT01"

      If objDt.Rows.Count = 0 Then
        HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
        Exit Sub
      End If
      objDs.Tables.Add(objDt.Copy)
      objetoRep.SetDataSource(objDs)

      CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
      CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = _CCMPN
      CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = _CDVSN
      CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = _CPLNDV
      objPrintForm.ShowForm(objetoRep, Me)
    Catch : End Try
  End Sub
#End Region

#Region "Imprimir Re-impresión  Pre Liquidacion"
    Private Sub ImprimirPreLiquidacion()
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim objetoRep As New rptPreLiquidacion
        Dim ListaParametros As New List(Of String)
        '---------------------------------------------------
        Dim objetoRep_Lote As New rptPreLiquidacion_X_Lote
        Dim oTransporte As New ENTIDADES.Operaciones.Factura_Transporte
        Dim oDtb As New DataTable
        Dim oDtResLote As New DataTable
        oTransporte.CCMPN = _CCMPN
        oTransporte.NPRLQD = txtNroFactura.Text
        '===Buscamos el tipo de reporte correspondiente al cliente (se busca el cliente de la preliquidacion)
        oDtb = obj_Logica.ObtenerTipoReportePreLiquidacion(oTransporte)

        Select Case oDtb.Rows(0).Item(0)
            Case 0
                ListaParametros.Add(txtNroFactura.Text)
                ListaParametros.Add(_CCMPN)
                ListaParametros.Add(_CDVSN)
                ListaParametros.Add(_CPLNDV)
                ListaParametros.Add(HelpClass.TodayNumeric)
                objDs = obj_Logica.Imprimir_Reporte_Pre_Liquidacion(ListaParametros)
                If objDs.Tables.Count = 0 Then Exit Sub
                objDs.Tables(0).TableName = "RZTR06"
                HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", MainModule.USUARIO)
                HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", _CCMPN_D)
                HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", _CDVSN_D)
                HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", _CPLNDV_D)
                HelpClass.CrystalReportTextObject(objetoRep, "lblNroPreliquidacion", "N° " & txtNroFactura.Text)
                objetoRep.SetDataSource(objDs)
                objPrintForm.ShowForm(objetoRep, Me)
            Case 1
                ListaParametros.Add(txtNroFactura.Text)
                ListaParametros.Add(_CCMPN)
                ListaParametros.Add(_CDVSN)
                ListaParametros.Add(_CPLNDV)
                ListaParametros.Add(HelpClass.TodayNumeric)

                oTransporte.CDVSN = _CDVSN
                oDtResLote = obj_Logica.Obtener_Reporte_Resumen_X_Lote(oTransporte)

                objDs = obj_Logica.Imprimir_Reporte_Pre_Liquidacion(ListaParametros)
                oDtResLote.TableName = "ResLote"
                objDs.Tables.Add(oDtResLote.Copy)
                If objDs.Tables.Count = 0 Then Exit Sub
                objDs.Tables(0).TableName = "RZTR06"
                objDs.Tables(1).TableName = "RES_X_LOTE"
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblUsuario", MainModule.USUARIO)
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblCompania", _CCMPN_D)
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblDivision", _CDVSN_D)
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblPlanta", _CPLNDV_D)
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblNroPreliquidacion", "N° " & txtNroFactura.Text)
                objetoRep_Lote.SetDataSource(objDs)
                objPrintForm.ShowForm(objetoRep_Lote, Me)
        End Select
        '---------------------------------------------------
  End Sub
#End Region

End Class

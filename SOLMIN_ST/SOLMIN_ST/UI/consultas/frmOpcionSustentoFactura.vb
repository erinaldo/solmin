Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOpcionSustentoFactura

#Region "Atributo Y Propiedad"
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Int32 = 0
  Private _CCMPN_D As String
  Private _CDVSN_D As String = ""
  Private _CPLNDV_D As String = ""
  Private _Titulo As String = ""
  Private _Tipo As String = ""
  Private _Fecha As Date = Today
  Private _Estado As Boolean

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

  Private Sub frmOpcionSustentoFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.dtpFechaGR_1.Visible = True
    Me.dtpFechaGR_2.Visible = True
    Me.Carga_Estado()
  End Sub

  Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
    Try
      Dim strMensaje As String = Validar_Opcion().Trim
      If strMensaje <> "" Then
        HelpClass.MsgBox(strMensaje, MessageBoxIcon.Warning)
        Exit Sub
      End If
      Dim obj_Logica As New Repartos_BLL
      Dim objHashTable As New Hashtable
      objHashTable.Add("PSCCMPN", _CCMPN)
      objHashTable.Add("PSCDVSN", _CDVSN)
      objHashTable.Add("PNCPLNDV", _CPLNDV)
      objHashTable.Add("PNNORSRT", IIf(Me.txtOrdenServicio.Text.Trim.Equals(""), 0, Me.txtOrdenServicio.Text))
      objHashTable.Add("PNNDCMFC", IIf(Me.txtNroFactura.Text.Trim.Equals(""), 0, Me.txtNroFactura.Text))
      objHashTable.Add("PNFECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaGR_1.Value))
      objHashTable.Add("PNFECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaGR_2.Value))
      Me.Exportar_Excel(obj_Logica.Exportar_Factura_Reparto(objHashTable))
    Catch : End Try

  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtNroFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroFactura.KeyPress, txtOrdenServicio.KeyPress
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
        If .Rows(lintContador).Item("NGUITR").ToString.Trim.PadLeft(10, "0").Substring(0, 3) = "023" Then
          'If .Rows(lintContador).Item("CPLNDV").ToString.Trim.Equals("1") Then
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

  Private Sub Carga_Estado()
    _Estado = False
    Me.cboEstado.DataSource = Tipo_Estado()
    Me.cboEstado.ValueMember = "COD"
    _Estado = True
    Me.cboEstado.DisplayMember = "NOM"
  End Sub

  Private Function Tipo_Estado()
    Dim oDt As New DataTable
    oDt.Columns.Add("COD")
    oDt.Columns.Add("NOM")
    Dim oDr As DataRow
    oDr = oDt.NewRow
    oDr.Item(0) = "T"
    oDr.Item(1) = "TODOS"
    oDt.Rows.Add(oDr)
    oDr = oDt.NewRow
    oDr.Item(0) = "F"
    oDr.Item(1) = "FACTURADO"
    oDt.Rows.Add(oDr)
    oDr = oDt.NewRow
    oDr.Item(0) = "C"
    oDr.Item(1) = "LIQUIDADO"
    oDt.Rows.Add(oDr)
    Return oDt
  End Function

  Private Sub cboEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.SelectedIndexChanged
    If _Estado = True Then
      Select Case Me.cboEstado.SelectedValue
        Case "F"
          Me.lblSeparador.Visible = True
          Me.txtNroFactura.Visible = True
          Me.txtOrdenServicio.Enabled = False
          Me.dtpFechaGR_1.Enabled = False
          Me.dtpFechaGR_2.Enabled = False
          Me.txtOrdenServicio.Text = ""
        Case "T"
          Me.txtOrdenServicio.Enabled = True
          Me.dtpFechaGR_1.Enabled = True
          Me.dtpFechaGR_2.Enabled = True
          Me.lblSeparador.Visible = False
          Me.txtNroFactura.Visible = False
          Me.txtNroFactura.Text = ""
        Case "C"
          Me.lblSeparador.Visible = False
          Me.txtNroFactura.Visible = False
          Me.txtOrdenServicio.Enabled = False
          Me.dtpFechaGR_1.Enabled = True
          Me.dtpFechaGR_2.Enabled = True
          Me.txtNroFactura.Text = ""
          Me.txtOrdenServicio.Text = ""
      End Select
    End If
  End Sub

  Private Function Validar_Opcion() As String
    Dim strMensaje As String = ""
    Select Case Me.cboEstado.SelectedValue
      Case "F"
        If Me.txtNroFactura.Text.Equals("") = True OrElse Me.txtNroFactura.Text = "0" Then strMensaje = "Falta Ingresar Número de Factura"
      Case "T"
        If Me.txtOrdenServicio.Text.Equals("") = True OrElse Me.txtOrdenServicio.Text = "0" Then strMensaje = "Falta Ingresar Orden de Servicio"
    End Select
    Return strMensaje.Trim
  End Function

#End Region

End Class

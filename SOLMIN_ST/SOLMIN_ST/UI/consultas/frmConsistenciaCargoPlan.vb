Public Class frmConsistenciaCargoPlan

#Region "Atributos"
  Private lintNCSOTR As Int64 = 0
  Private lintNCRRSR As Int32 = 0
  Private lstrCCMPN As String = ""
  Private lintNOPRCN As Int64 = 0
  Private strLugar As String = ""
  Private objDsPreliminar As New DataSet
  Private lstrTCMTRT As String = ""
  Private lstrNGUITR As String = ""
  Private lintNGUITR As Int64 = 0
  Private lintCTRMNC As Int32 = 0
  Private lintCPLNDV As Int64 = 0
  Private lintCCLNT As Int64 = 0
  Private lbolExcelFact As Boolean
  Private lintMedioTransporte As Int16 = 0
  Private _lintValidarCalc As Int16 = 0
  Private _dblPesoVolumen As Double = 28000 'Peso definido
  Private _dblConstantePesoVolumen As Double = 69.12 ' Se obtiene de multiplicar Longitud(12) * Ancho(2.4) * Alto(2.4) del vehículo

  Public Property NroSolicitud() As Int64
    Get
      Return lintNCSOTR
    End Get
    Set(ByVal value As Int64)
      lintNCSOTR = value
    End Set
  End Property

  Public Property NroCorrelativo() As Int32
    Get
      Return lintNCRRSR
    End Get
    Set(ByVal value As Int32)
      lintNCRRSR = value
    End Set
  End Property

  Public Property Compania() As String
    Get
      Return lstrCCMPN
    End Get
    Set(ByVal value As String)
      lstrCCMPN = value
    End Set
  End Property

  Public Property NroOperacion() As Int64
    Get
      Return lintNOPRCN
    End Get
    Set(ByVal value As Int64)
      lintNOPRCN = value
    End Set
  End Property

  Public WriteOnly Property CodigoTransportista() As Int32
    Set(ByVal value As Int32)
      lintCTRMNC = value
    End Set
  End Property

  Public WriteOnly Property GuiaTransporte() As Int64
    Set(ByVal value As Int64)
      lintNGUITR = value
    End Set
  End Property

  Public WriteOnly Property GuiaTransporte_STR() As String
    Set(ByVal value As String)
      lstrNGUITR = value
    End Set
  End Property

  Public WriteOnly Property Transportista() As String
    Set(ByVal value As String)
      lstrTCMTRT = value
    End Set
  End Property

  Public WriteOnly Property Planta() As Int64
    Set(ByVal value As Int64)
      lintCPLNDV = value
    End Set
  End Property

  Public WriteOnly Property ClienteNombre() As Int64
    Set(ByVal value As Int64)
      lintCCLNT = value
    End Set
  End Property

  Public WriteOnly Property bExcelFact() As Boolean
    Set(ByVal value As Boolean)
      lbolExcelFact = value
    End Set
  End Property

  Public WriteOnly Property MedioTransporte() As Int16
    Set(ByVal value As Int16)
      lintMedioTransporte = value
    End Set
  End Property

#End Region

  Private Sub Alinear_Columnas_Grilla()

    Me.dtgRecursosAsignados.AutoGenerateColumns = False

    For lint_contador As Integer = 0 To Me.dtgRecursosAsignados.ColumnCount - 1
      Me.dtgRecursosAsignados.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    Select Case lintMedioTransporte
      Case 1
        For lintCount As Int32 = 0 To objDsPreliminar.Tables("T_Detalle").Rows.Count - 1
          If objDsPreliminar.Tables("T_Detalle").Rows(0).Item("TCMPAL").ToString.Trim <> "" Then
            strLugar = objDsPreliminar.Tables("T_Detalle").Rows(0).Item("TCMPAL").ToString
            Exit For
          End If
        Next
      Case 4
        For lintCount As Int32 = 0 To objDsPreliminar.Tables(0).Rows.Count - 1
          If objDsPreliminar.Tables(0).Rows(0).Item("TCMPAL").ToString.Trim <> "" Then
            strLugar = objDsPreliminar.Tables(0).Rows(0).Item("TCMPAL").ToString
            Exit For
          End If
        Next
    End Select
    
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Select Case lintMedioTransporte
      Case 1
        Exportar_Cargo_Plan_Aereo()
      Case 4
        Exportar_Cargo_Plan_Terrestre()
    End Select
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub Exportar_Cargo_Plan_Terrestre()
    Dim objDt As New DataTable
    Dim oDtTemp As New DataTable
    Dim oDtTempCopy As New DataTable
    Dim objDtFormato As New DataTable
    Dim oDtCI_x_OS As New DataTable
    Dim oDtDetAdicional As New DataTable
    Dim objDs As New DataSet
    Dim sGuiaCliente As String = ""
    Dim TotPor As Double = 0D
    Dim PesoTot As Double = Double.Parse(txtPesoVolumen.Text)
    Dim where As String = ""
    Dim fechaRng As String
    Dim drw As DataRow = Nothing
    Dim htFiltro As New Hashtable
    Dim strNroCargoPlan As String = ""
    oDtTemp = Me.dtgRecursosAsignados.DataSource '=====CARGA LOS DATOS DE LA GRILLA
    '=========LOS FILTROS PARA LA CABECERA========
    htFiltro.Add("TITULO", objDsPreliminar.Tables(1).Rows(0).Item("TIPO_VEHICULO").ToString.Trim & "  -  " & "ALMACEN : " & strLugar.Trim)
    htFiltro.Add("FECHA", "FECHA : " & objDsPreliminar.Tables(1).Rows(0).Item("FECHA").ToString)
    htFiltro.Add("CHOFER", "CHOFER :  " & objDsPreliminar.Tables(1).Rows(0).Item("CONDUCTOR").ToString)
    htFiltro.Add("MARCA", "MARCA :  " & objDsPreliminar.Tables(1).Rows(0).Item("MARCA").ToString)
    htFiltro.Add("BREVETE", "BREVETE :  " & objDsPreliminar.Tables(1).Rows(0).Item("BREVETE").ToString)
    htFiltro.Add("PLACAS", "PLACAS :  " & objDsPreliminar.Tables(1).Rows(0).Item("TRACTO").ToString & " / " & objDsPreliminar.Tables(1).Rows(0).Item("ACOPLADO").ToString)
    htFiltro.Add("ORIGEN", "ORIGEN :  " & objDsPreliminar.Tables(1).Rows(0).Item("ORIGEN").ToString)
    htFiltro.Add("DESTINO", "DESTINO :  " & objDsPreliminar.Tables(1).Rows(0).Item("DESTINO").ToString)
    htFiltro.Add("OPERACION", "NRO. OPERACIÓN :  " & lintNOPRCN.ToString)
    htFiltro.Add("VER_COTIZACION", lbolExcelFact)
    htFiltro.Add("TCMTRT", "TRANSPORTISTA :  " & objDsPreliminar.Tables(1).Rows(0).Item("TCMTRT").ToString)
    htFiltro.Add("TARIFA_MONEDA", objDsPreliminar.Tables(1).Rows(0).Item("CMNDGU"))
    htFiltro.Add("TARIFA_MONTO", objDsPreliminar.Tables(1).Rows(0).Item("ISRVGU"))
    'strNroCargoPlan = "00" & CStr(lintNGUITR).Substring(0, 1) & "-" & CStr(lintNGUITR).Substring(1)
    strNroCargoPlan = lintNGUITR.ToString.PadLeft(10, "0").Substring(0, 3) & "-" & lintNGUITR.ToString.PadLeft(10, "0").Substring(3)
    htFiltro.Add("CARGO_PLAN", "NRO. CARGO PLAN : " & strNroCargoPlan)
    '===================LOS FILTROS PARA LOS TOTALES==================
    Dim htTotales As New Hashtable
    htTotales.Add("TBULTOS", objDsPreliminar.Tables(2).Rows(0).Item("BULTOS").ToString)
    htTotales.Add("TPESO", objDsPreliminar.Tables(2).Rows(0).Item("PESO").ToString)
    htTotales.Add("TM3", objDsPreliminar.Tables(2).Rows(0).Item("M3").ToString)
    htTotales.Add("TVOL", PesoTot)
    htTotales.Add("TPORCE", "100 %")
    '============================================
    objDt = oDtTemp.Copy
    objDt.TableName = "Terrestre"
    objDt.Columns.Remove("CCLNT")
    objDt.Columns.Remove("CREFFW")
    objDt.Columns.Remove("TCMPAL")
    objDt.Columns.Remove("NGUIRM")
    'objDt.Columns("GUIA_REMISION").ColumnName = "GUIA_PROV"
    objDt.Columns.Add("POR_CI", GetType(System.Double))
    objDt.Columns.Add("FLAG_DIST", GetType(System.String))
    '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
    oDtCI_x_OS.TableName = "CI_x_OS"
    oDtCI_x_OS = objDsPreliminar.Tables(3)
    '================================================
    oDtTempCopy = objDt.Clone
    For Each dr As DataRow In objDt.Rows
            fechaRng = HelpClass.CFecha_de_10_a_8(objDsPreliminar.Tables(1).Rows(0).Item("FECHA"))
      where = "NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
      oDtDetAdicional = filtraReporteGenerico(oDtCI_x_OS.Copy, where)
      '===CARGAMOS DATA ADICIONAL==='
      If oDtDetAdicional.Rows.Count > 0 Then
        dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
        dr("FLAG_DIST") = "CI_SG"
      Else
        dr("FLAG_DIST") = "0"
      End If
      oDtTempCopy.ImportRow(dr)
      For i As Integer = 0 To oDtDetAdicional.Rows.Count - 1
        drw = oDtTempCopy.NewRow
        drw("POR") = dr("POR")
        drw("POR_CI") = oDtDetAdicional.Rows(i).Item("IPRCTJ")
        drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(i).Item("TCTCST")
        drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
        oDtTempCopy.Rows.Add(drw)
      Next
    Next
    '========RESUMEN CUENTA DE IMPUTACION============
    Dim oDtCtaImput As New DataTable
    Dim oDrCtaImput As DataRow
    Dim drSelect As DataRow() = Nothing
    oDtCtaImput.Columns.Add("Cuenta", GetType(System.String))
    oDtCtaImput.Columns.Add("Importe", GetType(System.Double))
    Dim oDtv As DataView = New DataView(oDtTempCopy.Copy)
    oDtv.Sort = "CUENTA_IMPUTACION DESC"
    Dim oTabla As New DataTable
    oTabla = oDtv.ToTable
    Dim OriginalCount As Integer = oTabla.Rows.Count
    For i As Integer = 0 To OriginalCount - 1
      drSelect = oDtTempCopy.Copy.Select("CUENTA_IMPUTACION = '" + oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim + "' AND FLAG_DIST <> 'CI_SG' ")
      TotPor = 0
      For Each dr As DataRow In drSelect
        If IsDBNull(dr("POR_CI")) Then
          TotPor += Convert.ToDouble(dr("POR"))
        Else
          TotPor += Convert.ToDouble(dr("POR")) * Convert.ToDouble(dr("POR_CI")) * 0.01
        End If
      Next
      If drSelect.Length > 0 Then
        oDrCtaImput = oDtCtaImput.NewRow
        oDrCtaImput.Item("Cuenta") = IIf(oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim = "", "SIN CUENTA IMPUTACION", oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim)
        oDrCtaImput.Item("Importe") = TotPor * objDsPreliminar.Tables(1).Rows(0).Item("ISRVGU") * 0.01
        oDtCtaImput.Rows.Add(oDrCtaImput)
        i = i + drSelect.Length - 1
      End If
    Next i

        oDtTempCopy.Columns.Remove("FLAG_DIST")

        objDs.Tables.Add(oDtTempCopy.Copy)
        oDtCtaImput.TableName = "ResCuenta"
        objDs.Tables.Add(oDtCtaImput.Copy)

        If lintCCLNT = "11731" Then
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelPP_Terrestre_Unitario_Plus(objDs, htFiltro, htTotales)
        Else
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelPP_Terrestre_Unitario(objDs, htFiltro, htTotales)
        End If

    End Sub

  Private Sub Exportar_Cargo_Plan_Aereo()
    If objDsPreliminar.Tables(0).Rows.Count = 0 Then Exit Sub 'SI NO CONTIENE DETALLE NO SE EXPORTA
    '============FILTRO================
    Dim objDt As New DataTable
    Dim objDs As New DataSet
    Dim strNroCargoPlan As String = ""
    Dim htFiltro As New Hashtable
    htFiltro.Add("TITULO_1", "REPORTE DE VUELO : " & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("TRANSPORTISTA").ToString)
    htFiltro.Add("TITULO_2", "AVION : " & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("TRACTO").ToString)
    htFiltro.Add("FECHA", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("FECHA").ToString)
    htFiltro.Add("ORIGEN", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("ORIGEN").ToString)
    htFiltro.Add("DESTINO", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("DESTINO").ToString)
    htFiltro.Add("MEDIO", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("TRANSPORTISTA").ToString & Chr(10) & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("MODELO").ToString)
    htFiltro.Add("OPERACION", "NRO. OPERACIÓN: " & lintNOPRCN.ToString)
    htFiltro.Add("VER_COTIZACION", lbolExcelFact)
    htFiltro.Add("TARIFA_MONEDA", objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("CMNTRN").ToString)
    htFiltro.Add("TARIFA_MONTO", Convert.ToDouble(objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("ITRSRT")).ToString)
    'strNroCargoPlan = "00" & CStr(oSolTrans.PSNGUIRM).Substring(0, 1) & "-" & CStr(oSolTrans.PSNGUIRM).Substring(1)
    strNroCargoPlan = lintNGUITR.ToString.PadLeft(10, "0").Substring(0, 3) & "-" & lintNGUITR.ToString.PadLeft(10, "0").Substring(3)
    htFiltro.Add("CARGO_PLAN", "NRO. CARGO PLAN : " & strNroCargoPlan)
    '================================================
    objDt = objDsPreliminar.Tables("T_Detalle").Copy
    objDt.TableName = "Aereo"
    objDt.Columns.Remove("CCLNT")
    objDt.Columns.Remove("CREFFW")
    objDt.Columns.Remove("TCMPAL")
    objDt.Columns.Remove("NGUIRM")
    objDt.Columns.Remove("PESO_VOL")
    objDt.Columns.Remove("POR")
    objDs.Tables.Add(objDt.Copy)
    '====================RESUMEN LOTES===============
    '================================================
    objDs.Tables.Add(objDsPreliminar.Tables("T_ResLote").Copy)
    objDs.Tables.Add(objDsPreliminar.Tables("ResCuenta").Copy)
    Dim htTotales As New Hashtable
    '============TOTALES==============
    '=================================
    htTotales.Add("T_KILO", objDsPreliminar.Tables("T_Totales").Rows(0).Item("PESO").ToString)
    htTotales.Add("T_M3", objDsPreliminar.Tables("T_Totales").Rows(0).Item("M3").ToString)
    htTotales.Add("T_BULTO", objDsPreliminar.Tables("T_Totales").Rows(0).Item("BULTOS").ToString)
        '=================================
        If lintCCLNT = "11731" Then
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelPP_Aereo_Unitario_Plus(objDs, htFiltro, htTotales)
        Else
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelPP_Aereo_Unitario(objDs, htFiltro, htTotales)
        End If

  End Sub

  Private Function filtraReporteGenerico(ByVal tbl As DataTable, ByVal where As String) As DataTable
    Dim dt As New DataTable
    dt = tbl.Copy
    dt.DefaultView.RowFilter = where
    Return dt.DefaultView.ToTable
  End Function

  Private Sub frmConsistenciaCargoPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Cargar_Informacion()
    '------------------ojo mañana continuar
  End Sub

  Private Sub Cargar_Informacion()
    Dim objSolicitudTransporte As New NEGOCIO.Operaciones.Solicitud_Transporte_BLL
    Dim oSolTrans As New ENTIDADES.Operaciones.Solicitud_Transporte
    Select Case lintMedioTransporte
      Case 1
        '=================LLAMADA AL SOTRE QUE TRAE EL DATATABLE======================
        oSolTrans.PSCTRMNC = lintCTRMNC
        oSolTrans.PSNGUIRM = lintNGUITR
        oSolTrans.CPLNDV = lintCPLNDV
        oSolTrans.CCLNT = lintCCLNT
        oSolTrans.CCMPN = lstrCCMPN
        objDsPreliminar = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Aereo(oSolTrans)
        Me.Alinear_Columnas_Grilla()
        Me.txtTitulo.Text = objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("TIPO_VEHICULO").ToString.Trim & "  -  " & "ALMACEN : " & strLugar.Trim
        Me.txtFecha.Text = objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("FECHA").ToString.Trim
        Me.txtConductor.Text = ""
        Me.txtMarca.Text = "" 'objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("MARCA").ToString.Trim
        Me.txtBrevete.Text = ""
        Me.txtPlaca.Text = objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("MODELO").ToString '& " / " & objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("ACOPLADO").ToString.Trim
        Me.txtOrigen.Text = objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("ORIGEN").ToString.Trim
        Me.txtDestino.Text = objDsPreliminar.Tables("T_Cabecera").Rows(0).Item("DESTINO").ToString.Trim
        Me.txtTransportista.Text = lstrTCMTRT
        Me.txtGuiaTransporte.Text = lstrNGUITR
        Me.dtgRecursosAsignados.DataSource = objDsPreliminar.Tables("T_Detalle")
        Me.Calcular_PesoVolumen_Total()
        'objDt = objDsPreliminar.Tables("T_Detalle").Copy
        'objDt.TableName = "Aereo"
        'objDs.Tables.Add(objDt.Copy)
      Case 4
        '=========EL STORE QUE VA A LLAMAR AL DATATABLE A USAR PARA EL REPORTE===========
        oSolTrans.NCSOTR = lintNCSOTR
        oSolTrans.NCRRSR = lintNCRRSR

        oSolTrans.CCMPN = lstrCCMPN
        oSolTrans.PSCTRMNC = lintCTRMNC
        oSolTrans.PSNGUIRM = lintNGUITR
        oSolTrans.CPLNDV = lintCPLNDV
        oSolTrans.CCLNT = lintCCLNT
        objDsPreliminar = objSolicitudTransporte.Exportar_Reporte_Cargo_Plan_Terrestre(oSolTrans)
        Me.Alinear_Columnas_Grilla()
        Me.txtTitulo.Text = objDsPreliminar.Tables(1).Rows(0).Item("TIPO_VEHICULO").ToString.Trim & "  -  " & "ALMACEN : " & strLugar.Trim
        Me.txtFecha.Text = objDsPreliminar.Tables(1).Rows(0).Item("FECHA").ToString.Trim
        Me.txtConductor.Text = objDsPreliminar.Tables(1).Rows(0).Item("CONDUCTOR").ToString.Trim
        Me.txtMarca.Text = objDsPreliminar.Tables(1).Rows(0).Item("MARCA").ToString.Trim
        Me.txtBrevete.Text = objDsPreliminar.Tables(1).Rows(0).Item("BREVETE").ToString.Trim
        Me.txtPlaca.Text = objDsPreliminar.Tables(1).Rows(0).Item("TRACTO").ToString.Trim & " / " & objDsPreliminar.Tables(1).Rows(0).Item("ACOPLADO").ToString.Trim
        Me.txtOrigen.Text = objDsPreliminar.Tables(1).Rows(0).Item("ORIGEN").ToString.Trim
        Me.txtDestino.Text = objDsPreliminar.Tables(1).Rows(0).Item("DESTINO").ToString.Trim
        Me.txtTransportista.Text = lstrTCMTRT
        Me.txtGuiaTransporte.Text = lstrNGUITR

        Me.dtgRecursosAsignados.DataSource = objDsPreliminar.Tables(0)
        Me.Calcular_PesoVolumen_Total()
                _lintValidarCalc = 1


    End Select
  End Sub

    Private Sub btnActualizarBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarBulto.Click
        Try
            Dim objSolicitudTransporte As New NEGOCIO.Operaciones.Solicitud_Transporte_BLL
            Dim objHashtable As Hashtable
            Dim lintEstado As Int32 = 0
            For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
                If Me.dtgRecursosAsignados.Item("CREFFW", lintContador).Value <> "" Then
                    objHashtable = New Hashtable
                    objHashtable.Add("CTRMNC", lintCTRMNC)
                    objHashtable.Add("NGUITR", lintNGUITR)
                    objHashtable.Add("CCLNT", Me.dtgRecursosAsignados.Item("CCLNT", lintContador).Value)
                    objHashtable.Add("NGUIRM", Me.dtgRecursosAsignados.Item("NGUIRM", lintContador).Value)
                    objHashtable.Add("CREFFW", Me.dtgRecursosAsignados.Item("CREFFW", lintContador).Value)
                    objHashtable.Add("PSOVOL", Me.dtgRecursosAsignados.Item("PESO_VOL", lintContador).Value)
                    objHashtable.Add("PRCRMT", Me.dtgRecursosAsignados.Item("POR", lintContador).Value)
                    objHashtable.Add("CUSCRT", MainModule.USUARIO)
                    objHashtable.Add("FCHCRT", HelpClass.TodayNumeric)
                    objHashtable.Add("HRACRT", HelpClass.NowNumeric)
                    objHashtable.Add("NTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
                    objHashtable.Add("CULUSA", MainModule.USUARIO)
                    objHashtable.Add("FULTAC", HelpClass.TodayNumeric)
                    objHashtable.Add("HULTAC", HelpClass.NowNumeric)
                    objHashtable.Add("NTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
                    objHashtable.Add("CCMPN", lstrCCMPN)
                    If objSolicitudTransporte.Actualizar_Peso_Volumen__CargoPlan(objHashtable) = 0 Then lintEstado = 1
                End If
            Next
            objHashtable = New Hashtable
            objHashtable.Add("CTRMNC", lintCTRMNC)
            objHashtable.Add("NGUITR", lintNGUITR)
            objHashtable.Add("CULUSA", MainModule.USUARIO)
            objHashtable.Add("FULTAC", HelpClass.TodayNumeric)
            objHashtable.Add("HULTAC", HelpClass.NowNumeric)
            objHashtable.Add("NTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            objHashtable.Add("CCMPN", lstrCCMPN)
            objSolicitudTransporte.Actualizar_Peso_Volumen_Viaje_Consolidado(objHashtable)
            If Me.txtPesoVolumen.Text = 0 Then
                For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
                    If Me.dtgRecursosAsignados.Item("CREFFW", lintContador).Value <> "" Then
                        Me.dtgRecursosAsignados.Item("POR", lintContador).Value = (Me.dtgRecursosAsignados.Item("PESO_VOL", lintContador).Value / Me.txtPesoVolumen.Text) * 100
                    End If
                Next
            End If
            HelpClass.MsgBox("Se actualizó Satisfactoriamente", MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub dtgRecursosAsignados_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRecursosAsignados.CellEndEdit
    Select Case e.ColumnIndex
      Case 12
        Me.Calcular_PesoVolumen_Total()
    End Select
  End Sub

  Private Sub Calcular_PesoVolumen_Total()
    Dim SumaTotalPesoVol As Double = 0.0
    Dim SumaTotalPorcentaje As Double = 0.0
    For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
      If Me.dtgRecursosAsignados.Item("CREFFW", lintContador).Value <> "" Then
        SumaTotalPesoVol += Me.dtgRecursosAsignados.Item("PESO_VOL", lintContador).Value
      End If
    Next
    Me.txtPesoVolumen.Text = Math.Round(SumaTotalPesoVol, 2)
    If _lintValidarCalc = 1 Then
      For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
        If Me.dtgRecursosAsignados.Item("CREFFW", lintContador).Value <> "" Then
          If SumaTotalPesoVol <> 0 Then
            Me.dtgRecursosAsignados.Item("POR", lintContador).Value = Math.Round((Me.dtgRecursosAsignados.Item("PESO_VOL", lintContador).Value / SumaTotalPesoVol) * 100, 2)
          End If
        End If
      Next
    End If
    For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
      If Me.dtgRecursosAsignados.Item("CREFFW", lintContador).Value <> "" Then
        SumaTotalPorcentaje += Me.dtgRecursosAsignados.Item("POR", lintContador).Value
      End If
    Next
    Me.txtPorcentaje.Text = Math.Round(SumaTotalPorcentaje, 2, MidpointRounding.ToEven)
  End Sub


  Private Sub dtgRecursosAsignados_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgRecursosAsignados.DataError

  End Sub

  Private Sub dtgRecursosAsignados_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgRecursosAsignados.EditingControlShowing
    Dim txt As DataGridViewTextBoxEditingControl = e.Control
    Select Case Me.dtgRecursosAsignados.CurrentCell.ColumnIndex
      Case 12
        AddHandler txt.KeyPress, AddressOf Validar_IsNumeric
        'AddHandler txt.KeyUp, AddressOf Validar_IsDigits
    End Select
  End Sub

  Private Sub Validar_IsNumeric(ByVal sender As Object, ByVal e As KeyPressEventArgs)
    Dim columna As Integer = Me.dtgRecursosAsignados.CurrentCell.ColumnIndex
    Select Case columna
      Case 12
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = ".") Then
          e.Handled = True
        Else
          If 1 <= InStr(sender.EditingControlFormattedValue, ".", CompareMethod.Binary) Then
            If e.KeyChar = "." Then
              e.Handled = True
            End If
          End If
        End If
    End Select
  End Sub

  'Private Sub Validar_IsDigits(ByVal sender As Object, ByVal e As KeyEventArgs)
  '  Dim Columna As Integer = Me.dtgRecursosAsignados.CurrentCell.ColumnIndex
  '  Dim Fila As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
  '  Select Case Columna
  '    Case 12
  '      Select Case e.KeyCode
  '        Case Keys.Enter, Keys.Up, Keys.Down, Keys.Tab
  '          If Me.dtgRecursosAsignados.Item("PESO_VOL", Fila).Value.ToString.Trim = "" Then
  '            Me.dtgRecursosAsignados.Item("PESO_VOL", Fila).Value = 0.0
  '          End If
  '      End Select
  '  End Select
  'End Sub

  Private Sub btnPasarPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasarPeso.Click
    If Me.dtgRecursosAsignados.RowCount = 0 Then Exit Sub
    For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
      Me.dtgRecursosAsignados.Item("POR", lintContador).Value = 0
    Next
    Me.txtPorcentaje.Text = 0
    For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
      If Me.dtgRecursosAsignados.Item("CREFFW", lintContador).Value <> "" Then
        Me.dtgRecursosAsignados.Item("PESO_VOL", lintContador).Value = Me.dtgRecursosAsignados.Item("PESO", lintContador).Value
      End If
    Next
    Me.Calcular_PesoVolumen_Total()
  End Sub

  Private Sub btnCalcularPesoVolumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularPesoVolumen.Click
    If Me.dtgRecursosAsignados.RowCount = 0 OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
    For lintContador As Int32 = 0 To Me.dtgRecursosAsignados.RowCount - 1
      Me.dtgRecursosAsignados.Item("POR", lintContador).Value = 0
    Next
    Me.txtPorcentaje.Text = 0
    For intIndice As Integer = 0 To Me.dtgRecursosAsignados.RowCount - 1
      If IsNumeric(Me.dtgRecursosAsignados.Item("M3", intIndice).Value) Then
        Me.dtgRecursosAsignados.Item("PESO_VOL", intIndice).Value = Math.Round((Me.dtgRecursosAsignados.Item("M3", intIndice).Value * Me._dblPesoVolumen) / Me._dblConstantePesoVolumen, 2)
      End If
    Next
    Me.Calcular_PesoVolumen_Total()
  End Sub
End Class

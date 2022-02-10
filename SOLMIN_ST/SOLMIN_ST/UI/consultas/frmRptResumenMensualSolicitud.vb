Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmRptResumenMensualSolicitud
    Private strPlanta As String

#Region "Variables"

  Private bolBuscar As Boolean
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private objLisVehiculo As New List(Of ClaseGeneral)
  Private objLisAcoplado As New List(Of ClaseGeneral)
  Private objLisTransportista As New List(Of ClaseGeneral)
  Private objLisConductor As New List(Of ClaseGeneral)
  Private objLisCliente As New List(Of ClaseGeneral)
  Private objLisFecha As New List(Of ClaseGeneral)
  Private bolEstado As Boolean = True

#End Region

#Region "Metodos"

  Private Sub CargarTransportista()
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        'obeTransportista.pCCMPN_Compania = Control_UbicacionPlanta1.cmbCompania.SelectedValue
        obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    ctbTransportista.pCargar(obeTransportista)
  End Sub

  Private Sub CargarTracto()
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoPK
        'obeTracto.pCCMPN_Compania = Control_UbicacionPlanta1.cmbCompania.SelectedValue
        obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    ctbTracto.pCargar(obeTracto)
  End Sub

  Private Sub CargarConductor()
    Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
        'obeConductor.pCCMPN_Compania = Control_UbicacionPlanta1.cmbCompania.SelectedValue
        obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    ctbConductor.pCargar(obeConductor)
  End Sub

  Private Sub CargarAcoplado()
    Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoPK
        'obeAcoplado.pCCMPN_Compania = Control_UbicacionPlanta1.cmbCompania.SelectedValue
        obeAcoplado.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    ctbAcoplado.pCargar(obeAcoplado)
  End Sub

#End Region

#Region "Evento"

    Private Sub frmOpRptResumenMensual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCliente.pUsuario = MainModule.USUARIO
        Cargar_Compania()
        CargarTransportista()
        CargarTracto()
        CargarAcoplado()
        CargarConductor()
        bolEstado = False

        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        02/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        'Cargar_Planta()
    End Sub

  Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
    Dim objLogical As New Solicitud_Transporte_BLL
        Dim objLogica As New Junta_Transporte_BLL

        'Try

        'Catch ex As Exception

        'End Try


        strPlanta = ""
        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strPlanta += chkcbxPlanta.CheckedItems(i).Value

            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strPlanta = String.Concat(strPlanta, ",")
            End If

        Next


        If strPlanta = "" Then
            HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If



        Dim objParamentro As New Hashtable
        'objParamentro.Add("CCMPN", Me.Control_UbicacionPlanta1.cmbCompania.SelectedValue)
        'objParamentro.Add("CDVSN", Me.Control_UbicacionPlanta1.cmbDivision.SelectedValue)
        'objParamentro.Add("CPLNDV", Me.Control_UbicacionPlanta1.cmbPlanta.SelectedValue)
        objParamentro.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        objParamentro.Add("CDVSN", cmbDivision.Division)
        'objParamentro.Add("CPLNDV", cmbPlanta.Planta)

        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        02/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        objParamentro.Add("CPLNDV", strPlanta)

        objParamentro.Add("CCLNT", Me.txtCliente.pCodigo)
        objParamentro.Add("FECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value))
        objParamentro.Add("FECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value))


        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        02/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas

        If chkCliente.Checked Then
            Dim objReporte As New rptListaViajesRealizados
            Me.ControlVisorCliente.Muestra_Imagen()
            objLisCliente = objLogica.Lista_Viajes_Realizados(objParamentro)
            objLisFecha = objLisCliente
            Imprimir(objLisCliente, "RZST20", ControlVisorCliente, objReporte)
        End If

        If chkTransportista.Checked Then
            Dim objReporte As New rptReporteResumenMensualSolicitudTransporte
            objParamentro.Add("NRUCTR", Me.ctbTransportista.pRucTransportista)
            ControlVisorTransportista.Muestra_Imagen()
            objLisTransportista = objLogical.Reporte_Mensual_Transportista(objParamentro)
            Imprimir(objLisTransportista, "TRANSPORTISTA", ControlVisorTransportista, objReporte)
        End If

        If chkVehiculo.Checked Then
            Dim objReporte As New rptReporteResumenMensualSolicitudVehiculo
            objParamentro.Add("NPLCUN", Me.ctbTracto.pNroPlacaUnidad)
            ControlVisorVehiculo.Muestra_Imagen()
            objLisVehiculo = objLogical.Reporte_Mensual_Vehiculo(objParamentro)
            Imprimir(objLisVehiculo, "VEHICULO", ControlVisorVehiculo, objReporte)
        End If

        If chkAcoplado.Checked Then
            Dim objReporte As New rptReporteResumenMensualSolicitudAcoplado
            objParamentro.Add("NPLCAC", Me.ctbAcoplado.pNroAcoplado)
            ControlVisorAcoplado.Muestra_Imagen()
            objLisAcoplado = objLogical.Reporte_Mensual_Acoplado(objParamentro)
            Imprimir(objLisAcoplado, "ACOPLADO", ControlVisorAcoplado, objReporte)
        End If

        If chkConductor.Checked Then
            Dim objReporte As New rptReporteResumenMensualSolicitudConductor
            objParamentro.Add("CBRCNT", Me.ctbConductor.pBrevete)
            ControlVisorConductor.Muestra_Imagen()
            objLisConductor = objLogical.Reporte_Mensual_Conductor(objParamentro)
            Imprimir(objLisConductor, "CONDUCTOR", ControlVisorConductor, objReporte)
        End If

        If chkFecha.Checked Then
            Dim objReporte As New rptListaViajesRealizados_1
            Me.ControlVisorFecha.Muestra_Imagen()
            'objLisFecha = objLogica.Lista_Viajes_Realizados(objParamentro)
            Imprimir(objLisFecha, "RZST20", ControlVisorFecha, objReporte)
        End If

        Me.ControlVisorCliente.Ocultar_Imagen()
        Me.ControlVisorTransportista.Ocultar_Imagen()
        Me.ControlVisorVehiculo.Ocultar_Imagen()
        Me.ControlVisorAcoplado.Ocultar_Imagen()
        Me.ControlVisorConductor.Ocultar_Imagen()
        Me.ControlVisorFecha.Ocultar_Imagen()
    End Sub

  Private Sub Imprimir(ByVal objListEntidad As Object, ByVal TableName As String, _
                       ByVal ControlVisor As Control_Visor_Reporte, ByVal objReporte As Object)
    Dim oDt As New DataTable
    Dim oDs As New DataSet
    oDt = HelpClass.GetDataSetNative(objListEntidad)
    oDt.TableName = TableName
    oDs.Tables.Add(oDt.Copy)
    objReporte.SetDataSource(oDs)
    objReporte.SetParameterValue("pFechaInicio", Me.dtpFechaInicio.Value)
    objReporte.SetParameterValue("pFechaFin", Me.dtpFechaFin.Value)
    CType(objReporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        'CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.Control_UbicacionPlanta1.cmbCompania.Text
        'CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.Control_UbicacionPlanta1.cmbDivision.Text
        'CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.Control_UbicacionPlanta1.cmbPlanta.Text
        CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = cmbCompania.CCMPN_Descripcion
        CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = cmbDivision.DivisionDescripcion
        'CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = cmbPlanta.DescripcionPlanta

        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        02/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = chkcbxPlanta.Text

    If oDs.Tables(0).Rows.Count = 0 Then
      ControlVisor.ReportViewer.ReportSource = Nothing
      Exit Sub
    End If
    ControlVisor.ReportViewer.ReportSource = objReporte
  End Sub

  Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
    Try

      If Me.TabControl1.SelectedIndex = -1 Then Exit Sub
      Me.Cursor = Cursors.WaitCursor
      Dim objListDtg As New List(Of DataGridView)
      Me.dtgReporte.AutoGenerateColumns = False
      Select Case Me.TabControl1.Controls(TabControl1.SelectedIndex).Name
        Case "TabVehiculo"
          CrearColumna(0)
          'dtgReporte.DataSource = objLisVehiculo
          'objListDtg.Add(Me.dtgReporte)
          'HelpClass.ExportarExcel_HTML(objListDtg)
          If (Me.dtgReporte.Rows.Count = 1) Then
            MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
          End If
          'dtgReporte.Columns(7).HeaderText = "Fecha Guía Transporte"
          Me.dtgReporte.DataSource = HelpClass.GetDataSetNative(Of ClaseGeneral)(objLisVehiculo)
          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)
          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Transportista"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Transportista"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE TRANSPORTISTA"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte, objDt))
          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "TCMPCL", "SINDRC", "NPLCUN", "NPLCAC", "CBRCND", "NGUITR", "RUTA", "TPLNTA", "NPLCUN", "NOPRCN"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                '"FGUIRM", "FASGTR"

              Case "NCSOTR"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "QKMREC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Case "TabConductor"
          CrearColumna(1)
          'dtgReporte.DataSource = objLisConductor
          'objListDtg.Add(Me.dtgReporte)
          'HelpClass.ExportarExcel_HTML(objListDtg)
          If (Me.dtgReporte.Rows.Count = 1) Then
            MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
          End If
          dtgReporte.Columns(7).HeaderText = "Fecha Guía Transporte"
          Me.dtgReporte.DataSource = HelpClass.GetDataSetNative(Of ClaseGeneral)(objLisConductor)
          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)
          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Conductor"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Conductor"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE CONDUCTOR"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte, objDt))
          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "TCMPCL", "SINDRC", "NPLCUN", "NPLCAC", "CBRCND", "NGUITR", "RUTA", "TPLNTA", "NPLCUN", "NOPRCN"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                ' "FASGTR", "FGUIRM"

              Case "NCSOTR"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "QKMREC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Case "TabTransportista"
          CrearColumna(2)
          'dtgReporte.DataSource = objLisTransportista
          'objListDtg.Add(Me.dtgReporte)
          'HelpClass.ExportarExcel_HTML(objListDtg)
          If (Me.dtgReporte.Rows.Count = 1) Then
            MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
          End If
          dtgReporte.Columns(7).HeaderText = "Fecha Guía Transporte"
          Me.dtgReporte.DataSource = HelpClass.GetDataSetNative(Of ClaseGeneral)(objLisTransportista)
          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)
          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Transportista"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Transportista"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE TRANSPORTISTA"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte, objDt))
          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "TCMPCL", "SINDRC", "NPLCUN", "NPLCAC", "CBRCND", "NGUITR", "RUTA", "TPLNTA", "NOPRCN"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                ' "FASGTR", "FGUIRM"

              Case "NCSOTR"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "QKMREC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Case "TabAcoplado"
          CrearColumna(3)
          'dtgReporte.DataSource = objLisAcoplado
          'objListDtg.Add(Me.dtgReporte)
          'HelpClass.ExportarExcel_HTML(objListDtg)
          If (Me.dtgReporte.Rows.Count = 1) Then
            MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
          End If
          dtgReporte.Columns(7).HeaderText = "Fecha Guía Transporte"
          Me.dtgReporte.DataSource = HelpClass.GetDataSetNative(Of ClaseGeneral)(objLisAcoplado)

          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)
          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Acoplado"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Acoplado"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE ACOPLADO"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte, objDt))
          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "TCMPCL", "SINDRC", "NPLCUN", "NPLCAC", "CBRCND", "NGUITR", "RUTA", "TPLNTA", "NPLCUN", "NOPRCN"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                ', "FASGTR", "FGUIRM"

              Case "NCSOTR"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "QKMREC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Case "TabCliente"
          CrearColumna(4)
          'dtgReporte.DataSource = objLisCliente
          'objListDtg.Add(Me.dtgReporte)
          'HelpClass.ExportarExcel_HTML(objListDtg)
          'Dim a As Integer = Me.dtgReporte.Rows.Count
          If (Me.dtgReporte.Rows.Count = 1) Then
            MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
          End If
          dtgReporte.Columns(4).HeaderText = "Tracto"
          dtgReporte.Columns(9).HeaderText = "Fecha Guía Transporte"
          Me.dtgReporte.DataSource = HelpClass.GetDataSetNative(Of ClaseGeneral)(objLisCliente)
          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)
          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Cliente"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Cliente"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE CLIENTE"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte, objDt))
          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "TCMPCL", "SINDRC", "NPLCUN", "NPLCAC", "CBRCND", "NGUITR", "RUTA", "NOPRCN"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                ', "FGUIRM", "FASGTR"

              Case "NCSOTR"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "QKMREC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Case "TabFecha"
          CrearColumna(5)
          'dtgReporte.DataSource = objLisFecha
          'objListDtg.Add(Me.dtgReporte)
          'HelpClass.ExportarExcel_HTML(objListDtg)
          If (Me.dtgReporte.Rows.Count = 1) Then
            MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            Exit Sub
          End If
          dtgReporte.Columns(9).HeaderText = "Fecha Guía Transporte"
          Me.dtgReporte.DataSource = HelpClass.GetDataSetNative(Of ClaseGeneral)(objLisFecha)
          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)
          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Fecha"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Fecha"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE FECHA"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte, objDt))
          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "TCMPCL", "SINDRC", "NPLCUN", "NPLCAC", "CBRCND", "NGUITR", "NOPRCN", "NRUCTR", "RUTA"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                ', "FGUIRM", "FASGTR"

              Case "NCSOTR"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "QKMREC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
      End Select
      'Me.Cursor = Cursors.Default
    Catch ex As Exception
      MessageBox.Show(ex, "Error")
    End Try
  End Sub

  Private Sub CrearColumna(ByVal printReporte As Integer)
    dtgReporte.Columns.Clear()
    Dim Columna As DataGridViewTextBoxColumn

    Select Case printReporte
      Case 0
        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Vehículo"
        Columna.DataPropertyName = "NPLCUN"
        dtgReporte.Columns.Add(Columna)
      Case 1
        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Conductor"
        Columna.DataPropertyName = "CONDUCTOR"
        dtgReporte.Columns.Add(Columna)
      Case 2
        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Transportista"
        Columna.DataPropertyName = "TCMTRT"
        dtgReporte.Columns.Add(Columna)
      Case 3
        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Acoplado"
        Columna.DataPropertyName = "NPLCAC"
        dtgReporte.Columns.Add(Columna)
      Case 4
        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Cliente"
        Columna.DataPropertyName = "TCMPCL"
        dtgReporte.Columns.Add(Columna)
      Case 5
        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Fecha " & Chr(10) & " Asignación"
        Columna.DataPropertyName = "FASGTR"
        dtgReporte.Columns.Add(Columna)
    End Select

    If printReporte <> 5 Then
      Columna = New DataGridViewTextBoxColumn
      Columna.HeaderText = "Fecha " & Chr(10) & " Asignación"
      Columna.DataPropertyName = "FASGTR"
      Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
      dtgReporte.Columns.Add(Columna)
    End If

    If printReporte <> 4 Then
      Columna = New DataGridViewTextBoxColumn
      Columna.HeaderText = "Cliente"
      Columna.DataPropertyName = "TCMPCL"
      dtgReporte.Columns.Add(Columna)
    End If

    Columna = New DataGridViewTextBoxColumn
    Columna.HeaderText = "N° Solicitud"
    Columna.DataPropertyName = "NCSOTR"
    Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dtgReporte.Columns.Add(Columna)

    Columna = New DataGridViewTextBoxColumn
    Columna.HeaderText = "T / P"
    Columna.DataPropertyName = "SINDRC"
    Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dtgReporte.Columns.Add(Columna)

    If printReporte = 4 OrElse printReporte = 5 Then
      Columna = New DataGridViewTextBoxColumn
      Columna.HeaderText = "Vehículo"
      Columna.DataPropertyName = "NPLCUN"
      dtgReporte.Columns.Add(Columna)

      Columna = New DataGridViewTextBoxColumn
      Columna.HeaderText = "Acoplado"
      Columna.DataPropertyName = "NPLCAC"
      dtgReporte.Columns.Add(Columna)

      Columna = New DataGridViewTextBoxColumn
      Columna.HeaderText = "Conductor"
      Columna.DataPropertyName = "CBRCND"
      dtgReporte.Columns.Add(Columna)
    End If

    Columna = New DataGridViewTextBoxColumn
    Columna.HeaderText = "N° Operación"
    Columna.DataPropertyName = "NOPRCN"
    Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dtgReporte.Columns.Add(Columna)

    Columna = New DataGridViewTextBoxColumn
    Columna.HeaderText = "N° Guía Trans."
    Columna.DataPropertyName = "NGUITR"
    dtgReporte.Columns.Add(Columna)

    Columna = New DataGridViewTextBoxColumn
    Columna.HeaderText = "Fecha" & Chr(10) & "Guía Trans."
    Columna.DataPropertyName = "FGUIRM"
    dtgReporte.Columns.Add(Columna)

    Columna = New DataGridViewTextBoxColumn
    Columna.HeaderText = "Ruta"
    Columna.DataPropertyName = "RUTA"
    Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dtgReporte.Columns.Add(Columna)

    Columna = New DataGridViewTextBoxColumn
    Columna.HeaderText = "KM. Recorrido"
    Columna.DataPropertyName = "QKMREC"
        dtgReporte.Columns.Add(Columna)

        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        02/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Planta"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Columna.DataPropertyName = "TPLNTA"
        dtgReporte.Columns.Add(Columna)



    Dim lint_Indice As Integer = 0
    If printReporte = 4 OrElse printReporte = 5 Then
      dtgReporte.Columns.Item(0).DisplayIndex = 0
      dtgReporte.Columns.Item(1).DisplayIndex = 1
      dtgReporte.Columns.Item(2).DisplayIndex = 2
      dtgReporte.Columns.Item(3).DisplayIndex = 3
      dtgReporte.Columns.Item(4).DisplayIndex = 4
      dtgReporte.Columns.Item(5).DisplayIndex = 5
      dtgReporte.Columns.Item(6).DisplayIndex = 6
      dtgReporte.Columns.Item(7).DisplayIndex = 7
      dtgReporte.Columns.Item(8).DisplayIndex = 8
      dtgReporte.Columns.Item(9).DisplayIndex = 9
      dtgReporte.Columns.Item(10).DisplayIndex = 10
            'dtgReporte.Columns.Item(11).DisplayIndex = 11
            ' Agregado por: Hugo Pérez Ryan
            ' Fecha:        02/03/2012
            ' Descripción:  Se está modificando para que la consulta 
            ' pueda ser utilizada para escoger una o más plantas
            dtgReporte.Columns.Item(12).DisplayIndex = 12

    End If

  End Sub

  Private Sub chkVehiculo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVehiculo.CheckedChanged
    If bolEstado Then Exit Sub
    If chkVehiculo.Checked Then
      Me.TabControl1.Controls.Add(Me.TabVehiculo)
    Else
      Me.TabControl1.Controls.Remove(Me.TabVehiculo)
    End If
  End Sub

  Private Sub chkConductor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConductor.CheckedChanged
    If bolEstado Then Exit Sub
    If chkConductor.Checked Then
      Me.TabControl1.Controls.Add(Me.TabConductor)
    Else
      Me.TabControl1.Controls.Remove(Me.TabConductor)
    End If
  End Sub

  Private Sub chkTransportista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransportista.CheckedChanged
    If bolEstado Then Exit Sub
    If chkTransportista.Checked Then
      Me.TabControl1.Controls.Add(Me.TabTransportista)
    Else
      Me.TabControl1.Controls.Remove(Me.TabTransportista)
    End If
  End Sub

  Private Sub chkAcoplado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAcoplado.CheckedChanged
    If bolEstado Then Exit Sub
    If chkAcoplado.Checked Then
      Me.TabControl1.Controls.Add(Me.TabAcoplado)
    Else
      Me.TabControl1.Controls.Remove(Me.TabAcoplado)
    End If
  End Sub

  Private Sub chkCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCliente.CheckedChanged
    If bolEstado Then Exit Sub
    If chkCliente.Checked Then
      Me.TabControl1.Controls.Add(Me.TabCliente)
    Else
      Me.TabControl1.Controls.Remove(Me.TabCliente)
    End If
  End Sub

  Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
    If bolEstado Then Exit Sub
    If chkFecha.Checked Then
      Me.TabControl1.Controls.Add(Me.TabFecha)
    Else
      Me.TabControl1.Controls.Remove(Me.TabFecha)
    End If
  End Sub

#End Region

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
                'Me.cmbPlanta.pActualizar()
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Limpiar()

        ControlVisorCliente.ReportViewer.ReportSource = Nothing
        ControlVisorTransportista.ReportViewer.ReportSource = Nothing
        ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
        ControlVisorAcoplado.ReportViewer.ReportSource = Nothing
        ControlVisorConductor.ReportViewer.ReportSource = Nothing
        ControlVisorFecha.ReportViewer.ReportSource = Nothing
        CargarTransportista()
        CargarTracto()
        CargarAcoplado()
        CargarConductor()
    End Sub

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

Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCRepMensual

    Private Sub frmConsultarReporteMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Cargar_Combos()
      gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    Catch : End Try
  End Sub

    Private Sub Cargar_Combos()
        cargarComboCompania()
        cargarComboDivision()
        cargarComboPlanta()
        cargarComboTransportista()
    End Sub

    Private Sub cargarComboCompania()
        Dim objLogica As New NEGOCIO.Compania_BLL
        objLogica.Crea_Lista()
        cboCia.DataSource = objLogica.Lista
        cboCia.ValueMember = "CCMPN"
        cboCia.DisplayMember = "TCMPCM"
    cboCia.SelectedIndex = 0
    End Sub

    Private Sub cargarComboDivision()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim objLogica As New NEGOCIO.Division_BLL
            objLogica.Crea_Lista()
            cboDivision.DataSource = objLogica.Lista_Division(cboCia.SelectedValue.ToString.Trim)
            cboDivision.ValueMember = "CDVSN"
            cboDivision.DisplayMember = "TCMPDV"
      cboDivision.SelectedIndex = 0
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cargarComboPlanta()
        Try
            Dim objLogica As New NEGOCIO.Planta_BLL
            objLogica.Crea_Lista()
            cboPlanta.DataSource = objLogica.Lista_Planta(cboCia.SelectedValue.ToString.Trim, cboDivision.SelectedValue.ToString.Trim)
            cboPlanta.ValueMember = "CPLNDV"
            cboPlanta.DisplayMember = "TPLNTA"
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cargarComboTransportista()
        Try
            
            Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeTransportista.pCCMPN_Compania = Me.cboCia.SelectedValue
            cboTransportista.pCargar(obeTransportista)
           
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Dim dstreporte As New DataSet
        Me.Cursor = Cursors.WaitCursor
        dstreporte = Me.Datos_Reporte_Mensual
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        If dstreporte.Tables.Count > 0 Then
            Me.gwdDatos.AutoGenerateColumns = False
            gwdDatos.DataSource = dstreporte.Tables(0)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function Datos_Reporte_Mensual() As DataSet
        Dim objEntidad As New ReporteMensualEntidad
        Dim objReporte As New ReportesVariados_BLL
        Dim dstReporte As New DataSet

        objEntidad.CCMPN = Me.cboCia.SelectedValue
        objEntidad.CDVSN = Me.cboDivision.SelectedValue
        objEntidad.CPLNDV = Me.cboPlanta.SelectedValue

        If Me.ctlCliente.pCodigo.Equals("") = True Then
            objEntidad.CCLNT = 0
        Else
            objEntidad.CCLNT = CType(Me.ctlCliente.pCodigo, Integer)
        End If

        objEntidad.FGUITR_INI = HelpClass.CtypeDate(Me.dtpFechaInicio.Text)
        objEntidad.FGUITR_FIN = HelpClass.CtypeDate(Me.dtpFechaFin.Text)
        objEntidad.CTRSPT = Me.cboTransportista.pCodigoRNS
        objEntidad.NPLVHT = Me.txtNumeroPlaca.Text

        dstReporte = objReporte.ReporteMensual(objEntidad)

        Return dstReporte
    End Function

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Generar_Reporte_Crystal()
    End Sub

    Private Sub Generar_Reporte_Crystal()
        Dim dstreporte As New DataSet
        dstreporte = Me.Datos_Reporte_Mensual()
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        Try
            Dim objPrintForm = New PrintForm
            Dim objReporte As New ReporteMensual

            HelpClass.CrystalReportTextObject(objReporte, "lblcompania", Me.cboCia.Text.Trim)
            HelpClass.CrystalReportTextObject(objReporte, "lbldivision", Me.cboDivision.Text.Trim)
            HelpClass.CrystalReportTextObject(objReporte, "lblplanta", Me.cboPlanta.Text.Trim)
            HelpClass.CrystalReportTextObject(objReporte, "lbltransportista", Me.cboTransportista.pCodigoRNS)

            HelpClass.CrystalReportTextObject(objReporte, "lblFecha", "del " & Me.dtpFechaInicio.Text & " al " & Me.dtpFechaFin.Text)
            HelpClass.CrystalReportTextObject(objReporte, "lblCliente", Me.ctlCliente.pRazonSocial)
            HelpClass.CrystalReportTextObject(objReporte, "lblTransportista", IIf(Me.cboTransportista.pRazonSocial.Trim.Equals(""), "TODOS", Me.cboTransportista.pRazonSocial))


            objReporte.SetDataSource(dstreporte)
            objPrintForm.ShowForm(objReporte, Me)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            ClearMemory()
        End Try
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim objListDtg As New List(Of DataGridView)
        objListDtg.Add(Me.gwdDatos)
        HelpClass.ExportarExcel_HTML(objListDtg)
    End Sub
End Class
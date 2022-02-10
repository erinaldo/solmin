Imports SOLMIN_SC.Negocio
Imports System.Collections

Public Class frmRpt3PL

  Dim Filtro As New Hashtable()

  Dim objRep1 As New CTLReporte_3PL.rpt3PL

    Private Sub frmRpt3PL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.IdCompaniaDeploy)
            verGrafico(False)
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            dtpFecIni.Value = Now.AddMonths(-1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  

  Private Sub Cargar_Compania()
    cmbCompania.Usuario = HelpUtil.UserName
    cmbCompania.CCMPN_CompaniaDefault = "EZ"
    cmbCompania.pActualizar()
  End Sub
  Private Sub pbxEnvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxEnvio.Click
    Dim dblFecIni As Double
    Dim dblFecFin As Double
        If Me.cmbCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    Try
      Dim PSCCMPN As String = GetCompania()
      Dim PSCDVSN As String = GetDivision(PSCCMPN)
      dblFecIni = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.Month, "00") & "/" & Me.dtpMesEnvio.Value.Year, Date), "yyyyMMdd")
      dblFecFin = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.AddMonths(1).Month, "00") & "/" & Me.dtpMesEnvio.Value.AddMonths(1).Year, Date).AddDays(-1), "yyyyMMdd")
            If Enviar_Operaciones_Mensuales(PSCCMPN, PSCDVSN, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin) Then
                MessageBox.Show("Envio de datos mensuales correcto", "Aviso", MessageBoxButtons.OK)
            End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Private Function Enviar_Operaciones_Mensuales(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As Boolean
        Dim o3PLreport As New clsRep3PL
        Dim ListRegimen As String = "1,2,13"
        If Not o3PLreport.Registrar_Datos_Mensuales(PSCCMPN, PSCDVSN, pdblCliente, pdblFecIni, pdblFecFin, ListRegimen) Then
            MessageBox.Show("No se pudo realizar el Proceso ,Revisar:" & vbCrLf & o3PLreport.Mensaje, "Aviso", MessageBoxButtons.OK)
            Return False
        End If
    Return True
  End Function
  Private Function GetCompania() As String
    Return cmbCompania.CCMPN_CodigoCompania
  End Function
  Private Function GetDivision(ByVal CCMPN As String) As String
    If CCMPN = "EZ" Then
      Return HelpUtil.getSetting("DivisionEZ")
    Else
      Return ""
    End If
  End Function

  Private Sub Llenar_Tabla_Aduanas(ByRef pobjRep As CTLReporte_3PL.rpt3PL, ByVal pobjDt As DataTable, ByVal pobjDtGeneral As DataTable, ByVal pdblRed As Double, ByVal pdblOrange As Double, ByVal pdblGreen As Double, ByVal pdblUrgent As Double, ByVal pdblAnticipated As Double, ByVal pdblNormal As Double)
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(0).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(1).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(2).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(3).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes5"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(4).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes6"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(5).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes7"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(6).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes8"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(7).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes9"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(8).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes10"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(9).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes11"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(10).Item("MES").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtMes12"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(11).Item("MES").ToString.Trim

    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(0).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(1).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(2).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(3).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia5"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(4).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia6"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(5).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia7"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(6).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia8"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(7).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia9"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(8).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia10"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(9).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia11"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(10).Item("NUMDIA").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtDia12"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDt.Rows(11).Item("NUMDIA").ToString.Trim

    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtRed"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pdblRed
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtOrange"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pdblOrange
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtGreen"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pdblGreen
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtUrgent"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pdblUrgent
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtAnticipated"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pdblAnticipated
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pdblNormal

    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtToTalCIFAnho"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(CType(pobjDtGeneral.Rows(0).Item("CIFANHO").ToString.Trim, Double), "###,###,###,###,##0.00")
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtToTalCIFMes"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(CType(pobjDtGeneral.Rows(0).Item("CIFMES").ToString.Trim, Double), "###,###,###,###,##0.00")
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtToTalOCAnho"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDtGeneral.Rows(0).Item("OCANHO").ToString.Trim
    CType(pobjRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtToTalOCMes"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjDtGeneral.Rows(0).Item("OCMES").ToString.Trim
  End Sub


    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
            VisorRep.ReportSource = Nothing
        End If
    End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            VisorRep.ReportSource = Nothing
            If cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Debe seleccionar un Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            verGrafico(True)
            CargarFiltro()
            CheckForIllegalCrossThreadCalls = False
            bgwProcesoReport.RunWorkerAsync()
        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
  End Sub
  Private Sub verGrafico(ByVal ver As Boolean)
    btnBuscar.Enabled = Not ver
    lblBusqueda.Visible = ver
    lblBusqueda.Text = "..Consultando.."
    pbxBuscar.Visible = ver
  End Sub

  Public Sub CargarFiltro()
    Filtro = New Hashtable()
    Filtro.Add("FecIni", Format(Me.dtpFecIni.Value, "yyyyMMdd"))
    Filtro.Add("FecFin", Format(Me.dtpFecFin.Value, "yyyyMMdd"))
    Filtro.Add("PSCCMPN", GetCompania())
    Filtro.Add("PSCDVSN", GetDivision(Filtro("PSCCMPN")))
    Filtro.Add("Inicio", Format(Me.dtpFecIni.Value, "dd/MM/yyyy"))
    Filtro.Add("Fin", Format(Me.dtpFecFin.Value, "dd/MM/yyyy"))
    Filtro.Add("Cod_Cliente", Me.cmbCliente.pCodigo)
    Filtro.Add("Año", Format(Me.dtpFecIni.Value, "yyyy"))
    Filtro.Add("Mes", Format(Me.dtpFecFin.Value, "MM"))
    
  End Sub

    Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork

        Try
            objRep1 = New CTLReporte_3PL.rpt3PL
            Dim dblFecIni, dblFecFin, Cod_Cliente, Año, Mes As Double
            Cod_Cliente = Filtro("Cod_Cliente")
            dblFecIni = Filtro("FecIni")
            dblFecFin = Filtro("FecFin")
            Año = Filtro("Año")
            Mes = Filtro("Mes")

            Dim objDs As New DataSet
            Dim objDt As DataTable
            Dim objDr As DataRow
            Dim obj3PL As New clsRep3PL
            Dim lstrPeriodo As String
            Dim PSCCMPN As String = Filtro("PSCCMPN")
            Dim PSCDVSN As String = Filtro("PSCDVSN")
            Dim inicio As String = Filtro("Inicio")
            Dim fin As String = Filtro("Fin")


            lstrPeriodo = inicio & " al " & fin


            Dim ds As New DataSet
            Dim ListRegimen As String = "1,2,13"
            Dim dtOrdenesDatos As New DataTable
            Dim dtOrdenMensualOrigen As New DataTable
            Dim dtPesoMesualOrigen As New DataTable
            Dim DatoAduana As New DataTable
            Dim dtAduanaGeneral As New DataTable
            Dim dtAduanaGeneralAdicional As New DataTable

            Dim dblFecIniAnho As Decimal = 0
            dblFecIniAnho = Mid(dblFecFin, 1, 4) & "01" & "01"

            ds = obj3PL.Obtener_Datos_3PL_Unificado(PSCCMPN, PSCDVSN, Cod_Cliente, Año, dblFecIni, dblFecFin, dblFecIniAnho, ListRegimen)

            dtOrdenesDatos = ds.Tables("DTORDENDATO").Copy
            dtOrdenMensualOrigen = ds.Tables("DTORDENMENSUALORIGEN").Copy
            dtPesoMesualOrigen = ds.Tables("DTPESOMENSUALORIGEN").Copy
            DatoAduana = ds.Tables("DTDATOADUANA").Copy
            dtAduanaGeneral = ds.Tables("DTADUANAGENERAL").Copy
            dtAduanaGeneralAdicional = ds.Tables("DTADUANAGENERAL_AD").Copy


            objDt = obj3PL.Obtener_Datos(dtOrdenesDatos, PSCCMPN, PSCDVSN, Cod_Cliente, Año, Mes)


            Dim mensaje As String = ("" & obj3PL.Mensaje).ToString.Trim
            If mensaje.Length > 0 Then

                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


            objDt.TableName = "dtImportacion"
            objDs.Tables.Add(objDt.Copy)
            objRep1.Subreports("rpt3PL_SC.rpt").SetDataSource(objDs)

            objDt = New DataTable
            objDs = New DataSet
            objDt = obj3PL.Obtener_Datos_Mes()
            objDt.TableName = "dtImporMes"
            objDs.Tables.Add(objDt.Copy)
            objDt = obj3PL.Datos_Anual
            objDt.TableName = "dtImportacion"
            objDs.Tables.Add(objDt.Copy)
            objRep1.Subreports("rpt3PL_SC_MS.rpt").SetDataSource(objDs)

            CType(objRep1.Subreports("rpt3PL_SC.rpt").ReportDefinition.ReportObjects("txtTotalOC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj3PL.TotalOC
            CType(objRep1.Subreports("rpt3PL_SC.rpt").ReportDefinition.ReportObjects("txtTotalFlete"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj3PL.TotalFlete
            CType(objRep1.Subreports("rpt3PL_SC.rpt").ReportDefinition.ReportObjects("txtTotalTM"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj3PL.TotalPeso

            objDt = New DataTable
            objDs = New DataSet

            'objDt = obj3PL.Obtener_Datos_X_Origen(Cod_Cliente, dblFecIni, dblFecFin)
            objDt = obj3PL.Obtener_Datos_X_Origen(dtOrdenMensualOrigen, dtPesoMesualOrigen, Cod_Cliente, dblFecIni, dblFecFin)

            objDt.TableName = "dtOrigen"
            objDs.Tables.Add(objDt.Copy)
            CType(objRep1.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep1.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo
            CType(objRep1.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep1.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo

            objRep1.Subreports("rpt3PL_SC_PO.rpt").SetDataSource(objDs)
            CType(objRep1.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cmbCliente.pRazonSocial.Trim
            CType(objRep1.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep1.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & " - " & lstrPeriodo
            objDt = New DataTable
            objDs = New DataSet
            objDt = obj3PL.Aduanas
            objDt.TableName = "dtCustom"
            objDs.Tables.Add(objDt.Copy)

            'obj3PL.Obtener_Datos_Aduanas(Cod_Cliente, dblFecIni, dblFecFin)
            obj3PL.Obtener_Datos_Aduanas(DatoAduana, Cod_Cliente, dblFecIni, dblFecFin)

            If obj3PL.Mensaje.ToString.Trim <> "" Then
                HelpUtil.MsgBox(obj3PL.Mensaje.ToString.Trim)
            End If

            'obj3PL.Obtener_Informacion_General_Aduanas(Cod_Cliente, dblFecIni, dblFecFin)
            obj3PL.Obtener_Informacion_General_Aduanas(dtAduanaGeneral, dtAduanaGeneralAdicional, Cod_Cliente, dblFecIni, dblFecFin)
            Llenar_Tabla_Aduanas(objRep1, objDt, obj3PL.AduanasGeneral, obj3PL.Red, obj3PL.Orange, obj3PL.Green, obj3PL.Urgent, obj3PL.Anticipated, obj3PL.Normal)
            CType(objRep1.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep1.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo
            CType(objRep1.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep1.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo
            objRep1.Subreports("rpt3PL_SC_CS.rpt").SetDataSource(objDs)

            objDt = New DataTable
            objDt.Columns.Add(New DataColumn("OBSERV", GetType(System.String)))
            objDr = objDt.NewRow

            objDr.Item("OBSERV") = ""
            objDt.Rows.Add(objDr)
            objDs = New DataSet
            objDt.TableName = "dtObservaciones"
            objDs.Tables.Add(objDt.Copy)
            objRep1.SetDataSource(objDs)

        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub bgwProcesoReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcesoReport.RunWorkerCompleted
    Try
      VisorRep.ReportSource = objRep1
      verGrafico(False)
    Catch ex As Exception
      verGrafico(False)
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class

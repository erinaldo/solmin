Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class FrmRepVenta
    Private oCompania As clsCompania
    Public Enum TipoReporte
        Neutro
        ServicioCliente
        ModuloFacturacion
    End Enum

    Private _TipoRep As TipoReporte = TipoReporte.Neutro
    Public Property TipoRep() As TipoReporte
        Get
            Return _TipoRep
        End Get
        Set(ByVal value As TipoReporte)
            _TipoRep = value
        End Set
    End Property

    Private Sub FrmRepFacSolmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            oCompania = New clsCompania
            oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
            Cargar_Compania()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub btnCerrarRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarRep.Click
        Me.Close()
    End Sub

    Private Function NumDocumentoxModulo(ByVal dtModulo As DataTable, ByVal TFNCCR As String) As Int64
        Dim dr() As DataRow
        Dim LisDocVisitado As New Hashtable
        dr = dtModulo.Select("TFNCCR='" & TFNCCR & "'")
        Dim Doc As String = ""
        Dim NumDoc As Int64 = 0
        For FILA As Integer = 0 To dr.Length - 1
            Doc = dr(FILA)("CTPODC") & "_" & dr(FILA)("NDCCTC")
            If Not LisDocVisitado.Contains(Doc) Then
                NumDoc = NumDoc + 1
                LisDocVisitado.Add(Doc, Doc)
            End If
        Next
        Return NumDoc
    End Function
    Private Sub btnAceptarRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarRep.Click

        Try

            Select Case _TipoRep
                Case TipoReporte.Neutro
                    MessageBox.Show("Asigne tipo Reporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case TipoReporte.ServicioCliente
                    Dim obj_Logica As New clsCuentaCorriente
                    Dim objPrintForm As New PrintForm
                    Dim objDs As New DataSet
                    Dim objetoRep As New rptFacturasSOLMIN_V2
                    Dim ListaParametros As New List(Of String)
                    Dim CadFecha As String = ""
                    ''--------------------------------------------------------
                    Dim oCtaCte As New CuentaCorriente
                    Dim oDtb As New DataTable
                    Dim oDtResLote As New DataTable
                    oCtaCte.PSCCMPN = UcCompania.CCMPN_CodigoCompania

                    oCtaCte.FechaInicio = CType(dtFechaInicio.Text, DateTime).ToString("yyyyMMdd")
                    oCtaCte.FechaFin = CType(dtFechaFin.Text, DateTimeOffset).ToString("yyyyMMdd")
                    CadFecha = "Fecha : Desde " & dtFechaInicio.Text & "  Hasta " & dtFechaFin.Text
                    objDs = obj_Logica.Listar_FacturadoSOLMIN(oCtaCte)
                    If objDs.Tables.Count = 0 Then Exit Sub
                    objDs.Tables(0).TableName = "RZCT01_SOLMIN"
                    HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", ConfigurationWizard.UserName)
                    HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", UcCompania.CCMPN_Descripcion)
                    HelpClass.CrystalReportTextObject(objetoRep, "lblInicio", dtFechaInicio.Text)
                    HelpClass.CrystalReportTextObject(objetoRep, "lblFin", dtFechaFin.Text)


                    objetoRep.SetDataSource(objDs)
                    objPrintForm.WindowState = FormWindowState.Maximized
                    objPrintForm.ShowForm(objetoRep, Me)

                Case TipoReporte.ModuloFacturacion

                    Dim obj_Logica As New clsCuentaCorriente
                    Dim objPrintForm As New PrintForm
                    Dim objDs As New DataSet
                    Dim objetoRep As New rptFacturaCompara_V2
                    Dim ListaParametros As New List(Of String)
                    ''--------------------------------------------------------

                    Dim oCtaCte As New CuentaCorriente
                    Dim oDtb As New DataTable
                    'Dim oDtResLote As New DataTable

                    oCtaCte.PSCCMPN = UcCompania.CCMPN_CodigoCompania
                    oCtaCte.FechaInicio = CType(dtFechaInicio.Text, DateTime).ToString("yyyyMMdd")
                    oCtaCte.FechaFin = CType(dtFechaFin.Text, DateTime).ToString("yyyyMMdd")

                    Dim dtResumen As New DataTable
                    dtResumen = obj_Logica.Listar_Compara_Servicio(oCtaCte)

                    Dim dtResumenModulo As New DataTable
                    dtResumenModulo.Columns.Add("TFNCCR", GetType(System.String))
                    dtResumenModulo.Columns.Add("TCMTRF", GetType(System.String))
                    dtResumenModulo.Columns.Add("NUM_DOC", GetType(System.Int64))
                    dtResumenModulo.Columns.Add("IM_SOLE", GetType(System.Decimal))
                    dtResumenModulo.Columns.Add("IM_DOLA", GetType(System.Decimal))
                   

                    Dim drResumen As DataRow
                    Dim ListVisitados As New Hashtable
                    Dim ListVisitadoModulo As New Hashtable
                    Dim Unico As String = ""
                    Dim TFNCCR As String = ""
                    Dim FilaUpdate As Int64 = 0
                    For FILA As Integer = 0 To dtResumen.Rows.Count - 1
                        TFNCCR = ("" & dtResumen.Rows(FILA)("TFNCCR")).ToString.Trim
                        Unico = ("" & dtResumen.Rows(FILA)("TFNCCR")).ToString.Trim & "_" & ("" & dtResumen.Rows(FILA)("TCMTRF")).ToString.Trim
                        If Not ListVisitados.Contains(Unico) Then
                            drResumen = dtResumenModulo.NewRow
                            drResumen("TFNCCR") = ("" & dtResumen.Rows(FILA)("TFNCCR")).ToString.Trim
                            drResumen("TCMTRF") = ("" & dtResumen.Rows(FILA)("TCMTRF")).ToString.Trim

                            If Not ListVisitadoModulo.Contains(TFNCCR) Then
                                drResumen("NUM_DOC") = NumDocumentoxModulo(dtResumen, TFNCCR)
                                ListVisitadoModulo.Add(TFNCCR, TFNCCR)
                            Else
                                drResumen("NUM_DOC") = 0
                            End If

                            drResumen("IM_SOLE") = dtResumen.Rows(FILA)("IM_SOLE")
                            drResumen("IM_DOLA") = dtResumen.Rows(FILA)("IM_DOLA")
                            dtResumenModulo.Rows.Add(drResumen)
                            ListVisitados.Add(Unico, dtResumenModulo.Rows.Count - 1)
                        Else
                            FilaUpdate = ListVisitados(Unico)
                            dtResumenModulo.Rows(FilaUpdate)("IM_SOLE") = dtResumenModulo.Rows(FilaUpdate)("IM_SOLE") + dtResumen.Rows(FILA)("IM_SOLE")
                            dtResumenModulo.Rows(FilaUpdate)("IM_DOLA") = dtResumenModulo.Rows(FilaUpdate)("IM_DOLA") + dtResumen.Rows(FILA)("IM_DOLA")
                        End If
                    Next

                    objDs.Tables.Add(dtResumenModulo.Copy)
                    If objDs.Tables.Count = 0 Then Exit Sub
                    objDs.Tables(0).TableName = "RZCT01_CMP"


                    Dim dtOrigen As New DataTable
                    dtOrigen = objDs.Tables(0).Copy

                    Dim odtResumen As New DataTable
                    odtResumen.TableName = "dtResumenModFac"

                    odtResumen.Columns.Add("TFNCCR", Type.GetType("System.String"))
                    odtResumen.Columns.Add("NUM_DOC", Type.GetType("System.Int64"))
                    odtResumen.Columns.Add("IM_SOLE", Type.GetType("System.Decimal"))
                    odtResumen.Columns.Add("IM_DOLA", Type.GetType("System.Decimal"))
                    odtResumen.Columns.Add("PORC_SOL", Type.GetType("System.Decimal"))

                    Dim dr As DataRow
                    Dim oHas As New Hashtable
                    'Dim TFNCCR As String = ""
                    TFNCCR = ""
                    For Fila As Integer = 0 To dtOrigen.Rows.Count - 1
                        TFNCCR = ("" & dtOrigen.Rows(Fila)("TFNCCR")).ToString.Trim
                        If Not oHas.Contains(TFNCCR) Then
                            dr = odtResumen.NewRow
                            dr("TFNCCR") = TFNCCR
                            dr("NUM_DOC") = dtOrigen.Compute("SUM(NUM_DOC)", "TFNCCR='" & TFNCCR & "'")
                            dr("IM_SOLE") = dtOrigen.Compute("SUM(IM_SOLE)", "TFNCCR='" & TFNCCR & "'")
                            dr("IM_DOLA") = dtOrigen.Compute("SUM(IM_DOLA)", "TFNCCR='" & TFNCCR & "'")
                            dr("PORC_SOL") = 0
                            odtResumen.Rows.Add(dr)
                            oHas.Add(TFNCCR, TFNCCR)
                        End If
                    Next

                    If odtResumen.Rows.Count > 0 Then
                        Dim TotalSoles As Decimal = 0
                        Dim PorTanto As Decimal = 0
                        TotalSoles = odtResumen.Compute("SUM(IM_SOLE)", "")
                        For Fila As Integer = 0 To odtResumen.Rows.Count - 1
                            If TotalSoles = 0 Then
                                PorTanto = 0
                            Else
                                PorTanto = Math.Round((odtResumen.Rows(Fila)("IM_SOLE") / TotalSoles) * 100, 2)
                            End If
                            odtResumen.Rows(Fila)("PORC_SOL") = PorTanto
                        Next
                    End If

                    Dim dsResumen As New DataSet
                    dsResumen.Tables.Add(odtResumen.Copy)



                    HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", ConfigurationWizard.UserName)
                    HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", UcCompania.CCMPN_Descripcion)
                    HelpClass.CrystalReportTextObject(objetoRep, "lblInicio", dtFechaInicio.Text)
                    HelpClass.CrystalReportTextObject(objetoRep, "lblFin", dtFechaFin.Text)




                    objetoRep.SetDataSource(objDs)

                    objetoRep.Subreports.Item("rptResumen").SetDataSource(dsResumen)

                    objPrintForm.StartPosition = FormStartPosition.CenterScreen
                    objPrintForm.WindowState = FormWindowState.Maximized
                    objPrintForm.ShowForm(objetoRep, Me)
            End Select
       
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class

Imports SOLMIN_SC.Negocio
Imports System.Web
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Imports System.Data
Public Class frmVisorReporte
    Private strReporte As String
    Private bolSelec As Boolean = False

    Private Sub frmVisorReporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            tvwReporte.ExpandAll()
            bolSelec = True

            CargarIdioma()
            lblIdioma.Visible = False
            cboIdioma.Visible = False


            CrearRegimen()
            lblRegimen.Visible = False
            chkRegimen.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try    
    End Sub
    Private Sub CargarIdioma()

        Dim odtIdioma As New DataTable
        Dim dr As DataRow
        odtIdioma.Columns.Add("VALUE")
        odtIdioma.Columns.Add("DISPLAY")
        dr = odtIdioma.NewRow
        dr("VALUE") = "ES"
        dr("DISPLAY") = "Español"
        odtIdioma.Rows.Add(dr)

        dr = odtIdioma.NewRow
        dr("VALUE") = "EN"
        dr("DISPLAY") = "Inglés"
        odtIdioma.Rows.Add(dr)

        cboIdioma.DataSource = odtIdioma
        cboIdioma.DisplayMember = "DISPLAY"
        cboIdioma.ValueMember = "VALUE"

        cboIdioma.SelectedValue = "ES"
    End Sub

    Private Sub CrearRegimen()
        chkRegimen.Items.Clear()
        Dim odtRegimen As New DataTable
        Dim odtRegimenDatos As New DataTable
        odtRegimen.Columns.Add("NCODRG")
        odtRegimen.Columns.Add("TDSCRG")
        Dim oRegimen As New clsRegimen
        oRegimen.Crea_Lista()
        odtRegimenDatos = oRegimen.Lista_Regimen()
        Dim drItem As DataRow
        For Each Item As DataRow In odtRegimenDatos.Rows
            drItem = odtRegimen.NewRow
            drItem("NCODRG") = Item("NCODRG")
            drItem("TDSCRG") = Item("TDSCRG")
            odtRegimen.Rows.Add(drItem)
        Next
        chkRegimen.DataSource = odtRegimen
        chkRegimen.DisplayMember = "TDSCRG"
        chkRegimen.ValueMember = "NCODRG"

        For i As Integer = 0 To chkRegimen.Items.Count - 1
            If chkRegimen.Items.Item(i).Value = "1" OrElse chkRegimen.Items.Item(i).Value = "13" Then
                chkRegimen.SetItemChecked(i, True)
            End If
        Next
    End Sub

    Private Function Obtener_Descripcion_Cliente(ByVal CCLNT As Decimal) As String
        Dim dtb As New DataTable
        Dim TCMPCL As String = ""
        dtb = New clsCliente().Obtener_datos_cliente(CCLNT)
        If dtb.Rows.Count > 0 Then
            TCMPCL = Ransa.Utilitario.HelpClass.ToStringCvr(dtb.Rows(0).Item("TCMPCL"))
            TCMPCL = TCMPCL & " - " & Ransa.Utilitario.HelpClass.ToStringCvr(dtb.Rows(0).Item("TMTVBJ"))
        End If
        Return TCMPCL
    End Function

    Private Function GetCompania() As String
        'Return cmbCompania.CCMPN_CodigoCompania
        Return "EZ"
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.strReporte = "" Then
                HelpClass.MsgBox("Debe seleccionar un reporte")
                Exit Sub
            End If
            If cmbCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Debe seleccionar un Cliente")
                Exit Sub
            End If
            Muestra_Imagen()
            Dim dblFecIni, dblFecFin As Double

            dblFecIni = Format(Me.dtpFecIni.Value, "yyyyMMdd")
            dblFecFin = Format(Me.dtpFecFin.Value, "yyyyMMdd")

            Select Case strReporte
                Case "Rep01"
                    Dim objRep As New clsRptMenCI
                    Dim objCrep As New rptMenCI
                    Dim objDt As DataTable
                    Dim objDs As New DataSet
                    Dim lstrPeriodo As String

                    lstrPeriodo = Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
                    objDt = objRep.dtRepMenCI(GetCompania, Me.cmbCliente.pRazonSocial.ToString.Trim, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin)
                    objDt.TableName = "dtRepMenCI"
                    objDs.Tables.Add(objDt.Copy)
                    objDt = objRep.TotalEnvio
                    objDt.TableName = "dtTotalEnvio"
                    objDs.Tables.Add(objDt.Copy)
                    objCrep.SetDataSource(objDs)
                    CType(objCrep.ReportDefinition.ReportObjects("txtPeriodo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = lstrPeriodo
                    VisorRep.ReportSource = objCrep
        Case "Rep02"

          Dim pIdioma As String = cboIdioma.SelectedValue.ToString.Trim
          '=====Declaro apra Envio de parametro====
          Dim crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue
          Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
          Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
          Dim crParameterValues As CrystalDecisions.Shared.ParameterValues
          '=====Declaro Variables=====

          Dim objRep As New clsRepMenAdn
          Dim objCrep As Object
          Dim objDt As DataTable

          Dim objDtRegimen As New DataTable
          Dim objDs As New DataSet
          Dim lstrPeriodo As String
          '====Rango Fecha====
          Select Case pIdioma
            Case "EN"
              lstrPeriodo = "From " & Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " To " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
              objCrep = New rptMenAdn2010_INGS
            Case "ES"
              lstrPeriodo = "Entrega Almacén Desde " & Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
              objCrep = New rptMenAdn2010
          End Select

          '====Carga Primer Datatable y todas sus entidades====
          'Dim pIdioma As objRep.IDIOMA
          'Idioma = objRep.IDIOMA

          objDt = objRep.dtRepMenAduanero(GetCompania, pIdioma, Obtener_Descripcion_Cliente(Me.cmbCliente.pCodigo), Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, Format(CType("01" & "/" & Format(Me.dtpFecIni.Value.Month, "00") & "/" & Me.dtpFecIni.Value.AddYears(-1).Year, Date), "yyyyMMdd"))
          objDt.TableName = "dtRepMenSA"
          objDs.Tables.Add(objDt.Copy)
          '====Segundo Datatable (Entidad)====
          objDt = objRep.TotalRegimen
          objDt.TableName = "dtTotalRegimen"
          objDs.Tables.Add(objDt.Copy)


          objDtRegimen = objRep.dtRegimen.Copy
          For Each Item As DataRow In objDtRegimen.Rows
            If Item("Codigo") = 0 Then
              Item("Regimen") = "INDEFINITE"
            End If
          Next
          objDtRegimen.TableName = "dtReRegimen"


          Dim numFilas As Int32 = 0
          numFilas = objDtRegimen.Rows.Count - 1
          For FILA As Integer = 0 To numFilas
            If (numFilas >= FILA) Then
              If (objDtRegimen.Rows(FILA)("Cantidad")) = 0 Then
                objDtRegimen.Rows(FILA).Delete()
                numFilas = numFilas - 1
                FILA = FILA - 1
              End If
            End If
          Next
          objDtRegimen.AcceptChanges()
          '====Creamos Objeto RPT
          ' 'rptMenAdn2010_INGS
          'Select Case pIdioma
          '    Case "EN"
          '        objCrep = New rptMenAdn2010_INGS
          '    Case "ES"
          '        objCrep = New rptMenAdn2010
          'End Select
          'objCrep = New rptMenAdn2010_INGS
          'objCrep = New rptMenAdn2010

          'Seteamos en el DataSource el DataSet con nuestras Tablas
          objCrep.SetDataSource(objDs)
          objCrep.Subreports.Item("rptDiferenciaDias").SetDataSource(objDs.Tables(0))

          objCrep.Subreports.Item("rptSub_Regimen").SetDataSource(objDtRegimen)
          '====Enviamos Parametro al Reporte====
          '---PARA LOS DIAS ALMACEN---
          Dim objDiasAlmacenNeg As New SOLMIN_SC.Negocio.clsTipoDato
          Dim objDiasAlmacen As New SOLMIN_SC.Entidad.beTipoDato
          objDiasAlmacen.PNNTPODT = 29
          '---PARA LOS DIAS ALMACEN---
          objDiasAlmacenNeg.Crea_DetalleTipoDato(objDiasAlmacen)
          CType(objCrep.ReportDefinition.ReportObjects("txtPeriodo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = lstrPeriodo
          CType(objCrep.ReportDefinition.ReportObjects("txtMarTierra"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objDiasAlmacenNeg.RetornaDiasAlmacen("MARITIMO", cmbCliente.pCodigo)
          CType(objCrep.ReportDefinition.ReportObjects("txtAire"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objDiasAlmacenNeg.RetornaDiasAlmacen("AEREO", cmbCliente.pCodigo)
          '====Completa Cuadro Aduanero 2010 (Envio por parametros de variables)====

          Select Case pIdioma
            Case "EN"
              Completa_Cuadro_Aduanero_2010_Ingles(objCrep, objDs.Tables("dtRepMenSA").Copy, objRep.Contenedores, objRep.Despachos, objRep.RepDespacho_Div_FueraObj)
            Case "ES"
              Completa_Cuadro_Aduanero_2010_Espaniol(objCrep, objDs.Tables("dtRepMenSA").Copy, objRep.Contenedores, objRep.Despachos, objRep.RepDespacho_Div_FueraObj)
          End Select

          '====Oculta Seccion Condición====
          crParameterFieldDefinitions = objCrep.DataDefinition.ParameterFields
          crParameterFieldLocation = crParameterFieldDefinitions.Item("@Chktiempo")
          crParameterValues = crParameterFieldLocation.CurrentValues
          crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
          crParameterDiscreteValue.Value = chkTiempo.Checked.ToString
          crParameterValues.Add(crParameterDiscreteValue)
          crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

          '====Carga Reporte====
          VisorRep.ReportSource = objCrep

                Case "Rep03"
                    Dim objRep As New clsRepMenSA
                    Dim objCrep As New rptMenSA
                    Dim objDt As DataTable
                    Dim objDs As New DataSet
                    Dim lstrPeriodo As String
                    lstrPeriodo = Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
                    objDt = objRep.dtRepMenAD(GetCompania, Me.cmbCliente.pRazonSocial.ToString.Trim, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, lstrPeriodo)
                    objDt.TableName = "dtRepMenAdn"
                    objDs.Tables.Add(objDt.Copy)
                    objCrep.SetDataSource(objDs)
                    CType(objCrep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "SEGUIMIENTO ADUANERO " & lstrPeriodo.Trim
                    VisorRep.ReportSource = objCrep
                Case "Rep04"
                    If Me.txtOS.Text.ToString.Trim <> vbNullString Then
                        Dim objRep As New clsRepLiqAntamina
                        Dim objCrep As New rptLiqAntamina
                        Dim objDt As DataTable
                        Dim objDs As New DataSet

                        objDt = objRep.dtRepLiqAntamina(GetCompania, Me.txtOS.Text.ToString.Trim)
                        objDt.TableName = "dtRepLiqAntamina"
                        objDs.Tables.Add(objDt.Copy)
                        objCrep.SetDataSource(objDs)
                        CType(objCrep.ReportDefinition.ReportObjects("txtPago"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtNroPago.Text.Trim
                        VisorRep.ReportSource = objCrep
                    Else
                        HelpClass.MsgBox("Debe ingresar un número de Orden de Servicio")
                    End If
                Case "Rep05"
                    Dim objRep As New clsRepSadAntamina
                    Dim objCrep As New rptSadAntamina
                    Dim objDt As DataTable
                    Dim objDs As New DataSet
                    Dim lstrPeriodo As String
                    lstrPeriodo = Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
                    objDt = objRep.dtRepMenADV(GetCompania, Me.cmbCliente.pRazonSocial.ToString.Trim, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, lstrPeriodo)
                    objDt.TableName = "dtRepMenADV"
                    objDs.Tables.Add(objDt.Copy)
                    objCrep.SetDataSource(objDs)
                    CType(objCrep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "SAVING ADVALOREM " & lstrPeriodo.Trim
                    VisorRep.ReportSource = objCrep
                Case "Rep06"
                    Dim objDs As New DataSet
                    Dim objDt As DataTable
                    Dim objDr As DataRow
                    Dim objRep As New CTLReporte_3PL.rpt3PL
                    Dim obj3PL As New clsRep3PL
                    Dim lstrPeriodo As String

                    If Enviar_Operaciones_Mensuales(Me.cmbCliente.pCodigo, dblFecIni, dblFecFin) Then
                        lstrPeriodo = Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
                        objDt = obj3PL.Obtener_Datos(GetCompania, GetDivision(GetCompania()), cmbCliente.pCodigo, Format(Me.dtpFecIni.Value, "yyyy"), Format(Me.dtpFecFin.Value, "MM"))
                        objDt.TableName = "dtImportacion"
                        objDs.Tables.Add(objDt.Copy)
                        objRep.Subreports("rpt3PL_SC.rpt").SetDataSource(objDs)

                        objDt = New DataTable
                        objDs = New DataSet
                        objDt = obj3PL.Obtener_Datos_Mes()
                        objDt.TableName = "dtImporMes"
                        objDs.Tables.Add(objDt.Copy)
                        objDt = obj3PL.Datos_Anual
                        objDt.TableName = "dtImportacion"
                        objDs.Tables.Add(objDt.Copy)
                        objRep.Subreports("rpt3PL_SC_MS.rpt").SetDataSource(objDs)

                        CType(objRep.Subreports("rpt3PL_SC.rpt").ReportDefinition.ReportObjects("txtTotalOC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj3PL.TotalOC
                        CType(objRep.Subreports("rpt3PL_SC.rpt").ReportDefinition.ReportObjects("txtTotalFlete"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj3PL.TotalFlete
                        CType(objRep.Subreports("rpt3PL_SC.rpt").ReportDefinition.ReportObjects("txtTotalTM"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj3PL.TotalPeso

                        objDt = New DataTable
                        objDs = New DataSet
                        objDt = obj3PL.Obtener_Datos_X_Origen(Me.cmbCliente.pCodigo, dblFecIni, dblFecFin)
                        objDt.TableName = "dtOrigen"
                        objDs.Tables.Add(objDt.Copy)
                        CType(objRep.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo
                        CType(objRep.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.Subreports("rpt3PL_SC_PO.rpt").ReportDefinition.ReportObjects("txtSubTitulo4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo

                        objRep.Subreports("rpt3PL_SC_PO.rpt").SetDataSource(objDs)
                        CType(objRep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cmbCliente.pRazonSocial.Trim
                        CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & " - " & lstrPeriodo

                        objDt = New DataTable
                        objDs = New DataSet
                        objDt = obj3PL.Aduanas
                        objDt.TableName = "dtCustom"
                        objDs.Tables.Add(objDt.Copy)
                        obj3PL.Obtener_Datos_Aduanas(Me.cmbCliente.pCodigo, dblFecIni, dblFecFin)
                        If obj3PL.Mensaje.ToString.Trim <> "" Then
                            HelpClass.MsgBox(obj3PL.Mensaje.ToString.Trim)
                        End If
                        obj3PL.Obtener_Informacion_General_Aduanas(Me.cmbCliente.pCodigo, dblFecIni, dblFecFin)
                        Llenar_Tabla_Aduanas(objRep, objDt, obj3PL.AduanasGeneral, obj3PL.Red, obj3PL.Orange, obj3PL.Green, obj3PL.Urgent, obj3PL.Anticipated, obj3PL.Normal)
                        CType(objRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo
                        CType(objRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.Subreports("rpt3PL_SC_CS.rpt").ReportDefinition.ReportObjects("txtSubTitulo2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & lstrPeriodo
                        objRep.Subreports("rpt3PL_SC_CS.rpt").SetDataSource(objDs)

                        objDt = New DataTable
                        objDt.Columns.Add(New DataColumn("OBSERV", GetType(System.String)))
                        objDr = objDt.NewRow
                        objDr.Item("OBSERV") = Me.txtObservacion.Text.Trim
                        objDt.Rows.Add(objDr)
                        objDs = New DataSet
                        objDt.TableName = "dtObservaciones"
                        objDs.Tables.Add(objDt.Copy)
                        objRep.SetDataSource(objDs)
                        VisorRep.ReportSource = objRep
                    End If
                Case "Rep07"
                    Dim objDs As New DataSet
                    Dim objDt As DataTable
                    Dim objRep As New CTLReporte_Monthly.rptMonthly
                    Dim objMonthly As New clsRepMonthly
                    Dim lstrPeriodo As String
                    lstrPeriodo = Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
                    Dim ListaRegimen As String = ListaRegimenSeleccionado()
                    objDt = objMonthly.dtRepMonthlyOperaciones(GetCompania, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, ListaRegimen)
                    objDt.TableName = "dtOperacion"
                    objDs.Tables.Add(objDt.Copy)
                    oDs.Tables("dtOperacion").Rows.Clear()
                    oDs.Tables("dtOperacion").Load(objDt.CreateDataReader)
                    'oDs.Tables("dtOperacion").Columns.RemoveAt(20)
                    'oDs.Tables("dtOperacion").Columns.RemoveAt(19)
                    'oDs.Tables("dtOperacion").Columns.RemoveAt(20)
                    'oDs.Tables("dtOperacion").Columns.RemoveAt(19)

                    oDs.Tables("dtOperacion").Columns.Remove("NORSCI")
                    oDs.Tables("dtOperacion").Columns.Remove("VALTOT")
                    oDs.Tables("dtOperacion").Columns.Remove("IVLEXW")
                    oDs.Tables("dtOperacion").Columns.Remove("IVGFOB")

                    objRep.Subreports("rptMonthly_SC_OP.rpt").SetDataSource(objDs.Copy)
                    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
                    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtAnticipado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0

                    objDt = New DataTable
                    objDs = New DataSet
                    objDt = objMonthly.dtRepMonthlyFacturacion(Me.cmbCliente.pCodigo, dblFecIni, dblFecFin)
                    objDt.TableName = "dtFactAduana"
                    objDs.Tables.Add(objDt.Copy)
                    oDs.Tables("dtFactAduana").Rows.Clear()
                    oDs.Tables("dtFactAduana").Load(objDt.CreateDataReader)
                    objRep.Subreports("rptMonthly_SC_FA.rpt").SetDataSource(objDs.Copy)

                    objDt = New DataTable
                    objDs = New DataSet
                    objDt = objMonthly.dtRepMonthlyDetalleDebito(Me.cmbCliente.pCodigo, dblFecIni, dblFecFin)
                    objDt.TableName = "dtAvisoDebito"
                    objDs.Tables.Add(objDt.Copy)
                    oDs.Tables("dtAvisoDebito").Rows.Clear()
                    oDs.Tables("dtAvisoDebito").Load(objDt.CreateDataReader)
                    objRep.Subreports("rptMonthly_SC_AD.rpt").SetDataSource(objDs.Copy)

                    objDt = New DataTable
                    objDs = New DataSet
                    objDt = objMonthly.dtRepMonthlyContenedores(GetCompania, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, ListaRegimen)
                    objDt.TableName = "dtContenedores"
                    objDs.Tables.Add(objDt.Copy)
                    oDs.Tables("dtContenedores").Rows.Clear()
                    oDs.Tables("dtContenedores").Load(objDt.CreateDataReader)
                    'oDs.Tables("dtContenedores").Columns.RemoveAt(11)
                    'oDs.Tables("dtContenedores").Columns.Remove("NORCML_1")
                    objRep.Subreports("rptMonthly_SC_CN.rpt").SetDataSource(objDs.Copy)

                    objDt = New DataTable
                    objDs = New DataSet
                    objDt = objMonthly.dtRepMonthlyNavieras(GetCompania, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, ListaRegimen)
                    objDt.TableName = "dtNavieras"
                    objDs.Tables.Add(objDt.Copy)
                    objRep.Subreports("rptMonthly_SC_NA.rpt").SetDataSource(objDs.Copy)

                    objDt = New DataTable
                    objDs = New DataSet
                    objDt = objMonthly.dtRepMonthlyTiempoEntrega(GetCompania, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, ListaRegimen)
                    objDt.TableName = "dtTiempoEntrega"
                    objDs.Tables.Add(objDt.Copy)
                    oDs.Tables("dtTiempoEntrega").Rows.Clear()
                    oDs.Tables("dtTiempoEntrega").Load(objDt.CreateDataReader)
                    'oDs.Tables("dtTiempoEntrega").Columns.RemoveAt(18)
                    'oDs.Tables("dtTiempoEntrega").Columns.RemoveAt(17)
                    'oDs.Tables("dtTiempoEntrega").Columns.RemoveAt(16)
                    'oDs.Tables("dtTiempoEntrega").Columns.RemoveAt(15)
                    objRep.Subreports("rptMonthly_SC_TE.rpt").SetDataSource(objDs.Copy)

                    objMonthly.RepMonthlyTiempoAduanas(GetCompania, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, ListaRegimen)
                    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Normal)
                    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromAnticipa"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Anticipado)


                    CType(objRep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cmbCliente.pRazonSocial.Trim
                    CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & " - " & lstrPeriodo
                    VisorRep.ReportSource = objRep
                Case "Rep08"
                    '-----------------
                    Dim crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue
                    Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
                    Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
                    Dim crParameterValues As CrystalDecisions.Shared.ParameterValues
                    '-----------------

                    Dim objDs As New DataSet
                    Dim objDt As DataTable
                    Dim objRepEmbAlm As New clsRepEntregaEmbAlm
                    Dim objrptEmbAlm As New rptEntregaEmbAlm

                    Dim pnCliente As Integer = cmbCliente.pCodigo
                    'Dim pnFechaIni As Integer = HelpClass.DtypeDate(dtpFecIni.Value)
                    'Dim pnFechaFin As Integer = HelpClass.DtypeDate(dtpFecFin.Value)
                    Dim pnFechaIni As Integer = dtpFecIni.Value.ToString("yyyyMMdd")
                    Dim pnFechaFin As Integer = dtpFecFin.Value.ToString("yyyyMMdd")
                    objDt = objRepEmbAlm.RepEntregaEmbAlm(pnCliente, pnFechaIni, pnFechaFin)

                    objDt.TableName = "dtRepEntregaEmbAlm"

                    objDs.Tables.Add(objDt.Copy)

                    objrptEmbAlm.SetDataSource(objDs)
                    '------------------------------
                    crParameterFieldDefinitions = objrptEmbAlm.DataDefinition.ParameterFields
                    crParameterFieldLocation = crParameterFieldDefinitions.Item("@RangoFechas")
                    crParameterValues = crParameterFieldLocation.CurrentValues
                    crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                    crParameterDiscreteValue.Value = "Desde: " & HelpUtil.Str8ToDate(CStr(pnFechaIni)) & " Hasta: " & HelpUtil.Str8ToDate(CStr(pnFechaFin))
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldLocation.ApplyCurrentValues(crParameterValues)
                    '--------------------------------------
                    VisorRep.ReportSource = objrptEmbAlm
            End Select
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Ocultar_Imagen()
            HelpClass.MsgBox(ex.Message)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Ocultar_Imagen()
            HelpUtil.ClearMemory()
        End Try
    End Sub

    Private Function ListaRegimenSeleccionado() As String
        Dim IsTodos As Boolean = False
        Dim ListaRegimen As String = ""
        For i As Integer = 0 To chkRegimen.CheckedItems.Count - 1
            If chkRegimen.CheckedItems(i).Value = "0" Then
                IsTodos = True
                Exit For
            End If
            ListaRegimen += chkRegimen.CheckedItems(i).Value & ","
        Next
        If IsTodos = True Then
            ListaRegimen = ""
            For i As Integer = 0 To chkRegimen.Items.Count - 1
                If chkRegimen.Items.Item(i).Value <> "0" Then
                    ListaRegimen += chkRegimen.Items.Item(i).Value & ","
                End If
            Next
        End If
        If ListaRegimen.Trim.Length > 0 Then
            ListaRegimen = ListaRegimen.Trim.Substring(0, ListaRegimen.Trim.Length - 1)
        End If
        Return ListaRegimen
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

    'Private Sub Completa_Cuadro_Aduanero(ByRef pobjRep As rptMenAdn, ByVal poDt As DataTable, ByVal pobjRepCont As clsRepContenedor, ByVal pobjRepDes As clsRepDespacho)
    '    Dim oDtAnt As New DataTable
    '    Dim oDtNormal As New DataTable
    '    Dim oDtAereo As New DataTable
    '    Dim oDtMaritimo As New DataTable
    '    Dim dblPromAereo As Double = 0
    '    Dim dblPromMaritimo As Double = 0
    '    Dim intContAereo As Integer = 0
    '    Dim intContMaritimo As Integer = 0

    '    oDtAnt.Columns.Add(New DataColumn("OS", GetType(System.String)))
    '    oDtAnt.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

    '    oDtNormal.Columns.Add(New DataColumn("OS", GetType(System.String)))
    '    oDtNormal.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

    '    oDtAereo.Columns.Add(New DataColumn("OS", GetType(System.String)))
    '    oDtAereo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
    '    oDtAereo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

    '    oDtMaritimo.Columns.Add(New DataColumn("OS", GetType(System.String)))
    '    oDtMaritimo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
    '    oDtMaritimo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

    '    Llenar_Tablas(oDtAnt, oDtNormal, oDtAereo, oDtMaritimo, poDt)

    '    CType(pobjRep.ReportDefinition.ReportObjects("txtDespacho"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = poDt.Rows.Count               
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtA20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtA40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40

    '    CType(pobjRep.ReportDefinition.ReportObjects("txtB20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtB40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtBF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtBF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtBO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtBO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtBR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtBI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20SOBRE
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtBI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40SOBRE

    '    If pobjRepCont.PIES20SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtC20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIES
    '    End If
    '    If pobjRepCont.PIES40SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtC40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIES
    '    End If
    '    If pobjRepCont.FLACKPIES20SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtCF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESFLACK
    '    End If
    '    If pobjRepCont.FLACKPIES40SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtCF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESFLACK
    '    End If
    '    If pobjRepCont.OPENPIES20SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtCO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
    '    End If
    '    If pobjRepCont.OPENPIES40SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtCO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
    '    End If
    '    If pobjRepCont.REEFERPIES40SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtCR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESREEFER
    '    End If
    '    If pobjRepCont.ISOPIES20SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtCI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
    '    End If
    '    If pobjRepCont.ISOPIES40SOBRE > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtCI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
    '    End If

    '    CType(pobjRep.ReportDefinition.ReportObjects("txtMarA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Mar
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtMarC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Mar
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtMarG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Mar, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Aer
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Aer
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Aer, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtTerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Ter
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtTerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Ter
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtTerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Ter, "###,###,##0.00")

    '    CType(pobjRep.ReportDefinition.ReportObjects("txtMarB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Maritimo, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Aereo, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtTerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Terrestre, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtMarD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Maritimo, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Aereo, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtTerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Terrestre, "###,###,##0.00")

    '    CType(pobjRep.ReportDefinition.ReportObjects("txtMarE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Mar
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Aer
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtTerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Ter
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtMarF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Maritimo, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtAerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Aereo, "###,###,##0.00")
    '    CType(pobjRep.ReportDefinition.ReportObjects("txtTerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Terrestre, "###,###,##0.00")

    '    If (pobjRepDes.Anticipados_Aer + pobjRepDes.Anticipados_Mar + pobjRepDes.Anticipados_Ter) > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtAntETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Anticipado_ETA_DocCom / (pobjRepDes.Anticipados_Aer + pobjRepDes.Anticipados_Mar + pobjRepDes.Anticipados_Ter), "###,###,##0.00")
    '    Else
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtAntETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
    '    End If
    '    If (pobjRepDes.Normal_Aer + pobjRepDes.Normal_Mar + pobjRepDes.Normal_Ter) > 0 Then
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtNorETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Normal_ETA_DocCom / (pobjRepDes.Normal_Aer + pobjRepDes.Normal_Mar + pobjRepDes.Normal_Ter), "###,###,##0.00")
    '    Else
    '        CType(pobjRep.ReportDefinition.ReportObjects("txtNorETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
    '    End If
    'End Sub

    Private Sub Completa_Cuadro_Aduanero_2010_Espaniol(ByRef pobjRep As rptMenAdn2010, ByVal poDt As DataTable, ByVal pobjRepCont As clsRepContenedor, ByVal pobjRepDes As clsRepDespacho, ByVal pobjRepDesDiv As clsRepDespacho)
        Dim oDtAnt As New DataTable
        Dim oDtNormal As New DataTable
        Dim oDtAereo As New DataTable
        Dim oDtMaritimo As New DataTable
        Dim dblPromAereo As Double = 0
        Dim dblPromMaritimo As Double = 0
        Dim intContAereo As Integer = 0
        Dim intContMaritimo As Integer = 0

        oDtAnt.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAnt.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtNormal.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtNormal.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtAereo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAereo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtAereo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtMaritimo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtMaritimo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtMaritimo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        Llenar_Tablas(oDtAnt, oDtNormal, oDtAereo, oDtMaritimo, poDt)

        CType(pobjRep.ReportDefinition.ReportObjects("txtDespacho"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = poDt.Rows.Count
        CType(pobjRep.ReportDefinition.ReportObjects("txtA20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtA40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40

        CType(pobjRep.ReportDefinition.ReportObjects("txtB20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtB40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40SOBRE

        If pobjRepCont.PIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIES
        End If
        If pobjRepCont.PIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIES
        End If
        If pobjRepCont.FLACKPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESFLACK
        End If
        If pobjRepCont.FLACKPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESFLACK
        End If
        If pobjRepCont.OPENPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.OPENPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.REEFERPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESREEFER
        End If
        If pobjRepCont.ISOPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.ISOPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.HIGHPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESHIGH
        End If
        If pobjRepCont.HIGHPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESHIGH
        End If

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Mar, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Aer, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Ter, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Terrestre, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Terrestre, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Ter

        ''adicion
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Ter
        ''adicion

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Terrestre, "###,###,##0.00")

        'If (pobjRepDes.Anticipados_Aer + pobjRepDes.Anticipados_Mar + pobjRepDes.Anticipados_Ter) > 0 Then
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtAntETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Anticipado_ETA_DocCom / (pobjRepDes.Anticipados_Aer + pobjRepDes.Anticipados_Mar + pobjRepDes.Anticipados_Ter), "###,###,##0.00")
        'Else
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtAntETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
        'End If
        'If (pobjRepDes.Normal_Aer + pobjRepDes.Normal_Mar + pobjRepDes.Normal_Ter) > 0 Then
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtNorETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Normal_ETA_DocCom / (pobjRepDes.Normal_Aer + pobjRepDes.Normal_Mar + pobjRepDes.Normal_Ter), "###,###,##0.00")
        'Else
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtNorETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
        'End If
    End Sub


    Private Sub Completa_Cuadro_Aduanero_2010_Ingles(ByRef pobjRep As rptMenAdn2010_INGS, ByVal poDt As DataTable, ByVal pobjRepCont As clsRepContenedor, ByVal pobjRepDes As clsRepDespacho, ByVal pobjRepDesDiv As clsRepDespacho)
        Dim oDtAnt As New DataTable
        Dim oDtNormal As New DataTable
        Dim oDtAereo As New DataTable
        Dim oDtMaritimo As New DataTable
        Dim dblPromAereo As Double = 0
        Dim dblPromMaritimo As Double = 0
        Dim intContAereo As Integer = 0
        Dim intContMaritimo As Integer = 0

        oDtAnt.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAnt.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtNormal.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtNormal.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtAereo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAereo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtAereo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtMaritimo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtMaritimo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtMaritimo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        Llenar_Tablas(oDtAnt, oDtNormal, oDtAereo, oDtMaritimo, poDt)

        CType(pobjRep.ReportDefinition.ReportObjects("txtDespacho"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = poDt.Rows.Count
        CType(pobjRep.ReportDefinition.ReportObjects("txtA20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtA40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40

        CType(pobjRep.ReportDefinition.ReportObjects("txtB20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtB40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40SOBRE

        If pobjRepCont.PIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIES
        End If
        If pobjRepCont.PIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIES
        End If
        If pobjRepCont.FLACKPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESFLACK
        End If
        If pobjRepCont.FLACKPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESFLACK
        End If
        If pobjRepCont.OPENPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.OPENPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.REEFERPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESREEFER
        End If
        If pobjRepCont.ISOPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.ISOPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.HIGHPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESHIGH
        End If
        If pobjRepCont.HIGHPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESHIGH
        End If

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Mar, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Aer, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Ter, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Terrestre, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Terrestre, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Ter

        ''adicion
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Ter
        ''adicion

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Terrestre, "###,###,##0.00")

        'If (pobjRepDes.Anticipados_Aer + pobjRepDes.Anticipados_Mar + pobjRepDes.Anticipados_Ter) > 0 Then
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtAntETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Anticipado_ETA_DocCom / (pobjRepDes.Anticipados_Aer + pobjRepDes.Anticipados_Mar + pobjRepDes.Anticipados_Ter), "###,###,##0.00")
        'Else
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtAntETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
        'End If
        'If (pobjRepDes.Normal_Aer + pobjRepDes.Normal_Mar + pobjRepDes.Normal_Ter) > 0 Then
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtNorETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Normal_ETA_DocCom / (pobjRepDes.Normal_Aer + pobjRepDes.Normal_Mar + pobjRepDes.Normal_Ter), "###,###,##0.00")
        'Else
        '    CType(pobjRep.ReportDefinition.ReportObjects("txtNorETA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
        'End If
    End Sub


    Private Sub Llenar_Tablas(ByRef pobjAnt As DataTable, ByRef pobjNormal As DataTable, ByRef pobjAereo As DataTable, ByRef pobjMaritimo As DataTable, ByVal pobjDatos As DataTable)
        Dim intCont As Integer
        Dim oDr As DataRow

        'clsRepDespacho
        'COD_DESPACHO
        'COD_TNMMDT

        For intCont = 0 To pobjDatos.Rows.Count - 1
            'If pobjDatos.Rows(intCont).Item("DESPACHO").ToString.Trim = "NORMAL" Then
            If pobjDatos.Rows(intCont).Item("COD_DESPACHO") = clsRepDespacho.TIPO_DESPACHO.NORMAL Then
                oDr = pobjNormal.NewRow
                oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                pobjNormal.Rows.Add(oDr)
            Else
                '  If pobjDatos.Rows(intCont).Item("DESPACHO").ToString.Trim = "ANTICIPADO" Then
                If pobjDatos.Rows(intCont).Item("COD_DESPACHO") = clsRepDespacho.TIPO_DESPACHO.ANTICIPADO Then
                    oDr = pobjAnt.NewRow
                    oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                    oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                    pobjAnt.Rows.Add(oDr)
                End If
            End If
            'If pobjDatos.Rows(intCont).Item("TNMMDT").ToString.Trim = "AEREO" Then
            If pobjDatos.Rows(intCont).Item("COD_TNMMDT") = clsRepDespacho.MEDIO_TRANSPORTE.AEREO Then
                oDr = pobjAereo.NewRow
                oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                oDr.Item("QPSOAR") = pobjDatos.Rows(intCont).Item("QPSOAR").ToString.Trim
                oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                pobjAereo.Rows.Add(oDr)
            Else
                ' If pobjDatos.Rows(intCont).Item("TNMMDT").ToString.Trim = "MARITIMO" Then
                If pobjDatos.Rows(intCont).Item("COD_TNMMDT") = clsRepDespacho.MEDIO_TRANSPORTE.MARITIMO Then
                    oDr = pobjMaritimo.NewRow
                    oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                    oDr.Item("QPSOAR") = pobjDatos.Rows(intCont).Item("QPSOAR").ToString.Trim
                    oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                    pobjMaritimo.Rows.Add(oDr)
                End If
            End If
        Next intCont
    End Sub



    'Private Sub Llenar_Tablas(ByRef pobjAnt As DataTable, ByRef pobjNormal As DataTable, ByRef pobjAereo As DataTable, ByRef pobjMaritimo As DataTable, ByVal pobjDatos As DataTable)
    '    Dim intCont As Integer
    '    Dim oDr As DataRow

    '    For intCont = 0 To pobjDatos.Rows.Count - 1
    '        If pobjDatos.Rows(intCont).Item("DESPACHO").ToString.Trim = "NORMAL" Then
    '            oDr = pobjNormal.NewRow
    '            oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
    '            oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
    '            pobjNormal.Rows.Add(oDr)
    '        Else
    '            If pobjDatos.Rows(intCont).Item("DESPACHO").ToString.Trim = "ANTICIPADO" Then
    '                oDr = pobjAnt.NewRow
    '                oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
    '                oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
    '                pobjAnt.Rows.Add(oDr)
    '            End If
    '        End If
    '        If pobjDatos.Rows(intCont).Item("TNMMDT").ToString.Trim = "AEREO" Then
    '            oDr = pobjAereo.NewRow
    '            oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
    '            oDr.Item("QPSOAR") = pobjDatos.Rows(intCont).Item("QPSOAR").ToString.Trim
    '            oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
    '            pobjAereo.Rows.Add(oDr)
    '        Else
    '            If pobjDatos.Rows(intCont).Item("TNMMDT").ToString.Trim = "MARITIMO" Then
    '                oDr = pobjMaritimo.NewRow
    '                oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
    '                oDr.Item("QPSOAR") = pobjDatos.Rows(intCont).Item("QPSOAR").ToString.Trim
    '                oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
    '                pobjMaritimo.Rows.Add(oDr)
    '            End If
    '        End If
    '    Next intCont
    'End Sub

    Private Sub tvwReporte_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwReporte.AfterSelect

        lblRegimen.Visible = False
        chkRegimen.Visible = False

        lblIdioma.Visible = False
        cboIdioma.Visible = False


        If bolSelec Then
            strReporte = e.Node.Tag
            Select Case strReporte
                Case "Rep02" 'Mensual Embarque Aduanas
                    chkTiempo.Visible = True
                    lblRegimen.Visible = False
                    chkRegimen.Visible = False

                    lblIdioma.Visible = True
                    cboIdioma.Visible = True
                Case "Rep04" 'Liquidación de Pago
                    chkTiempo.Visible = False
                    chkTiempo.Checked = False
                    Me.cmbCliente.Enabled = False
                    Me.lblMes.Visible = False
                    Me.lblFecFin.Visible = False
                    Me.dtpFecIni.Visible = False
                    Me.dtpFecFin.Visible = False
                    Me.lblOS.Visible = True
                    Me.txtOS.Text = ""
                    Me.txtOS.Visible = True
                    Me.txtNroPago.Text = ""
                    Me.txtNroPago.Visible = True
                    Me.KryptonHeaderGroup3.Visible = False
                    Me.KryptonHeaderGroup3.Collapsed = True
                    Me.KryptonHeaderGroup4.Visible = False
                    Me.KryptonHeaderGroup1.ButtonSpecs(0).Visible = False
                    lblRegimen.Visible = False
                    chkRegimen.Visible = False
                Case "Rep05" 'Saving ADVALOREM
                    chkTiempo.Visible = False
                    chkTiempo.Checked = False
                    Me.cmbCliente.Enabled = False
                    Me.lblOS.Visible = False
                    Me.txtOS.Visible = False
                    Me.txtOS.Text = ""
                    Me.lblMes.Visible = True
                    Me.lblFecFin.Visible = True
                    Me.dtpFecIni.Visible = True
                    Me.dtpFecFin.Visible = True
                    Me.txtNroPago.Text = ""
                    Me.txtNroPago.Visible = False
                    Me.KryptonHeaderGroup3.Visible = False
                    Me.KryptonHeaderGroup3.Collapsed = True
                    Me.KryptonHeaderGroup4.Visible = False
                    Me.KryptonHeaderGroup1.ButtonSpecs(0).Visible = False
                    'lblRegimen.Visible = False
                    'chkRegimen.Visible = False
                Case "Rep06" '3PL Report
                    chkTiempo.Visible = False
                    chkTiempo.Checked = False
                    Me.cmbCliente.Enabled = True
                    Me.lblOS.Visible = False
                    Me.txtOS.Visible = False
                    Me.txtOS.Text = ""
                    Me.lblMes.Visible = True
                    Me.lblFecFin.Visible = True
                    Me.dtpFecIni.Visible = True
                    Me.dtpFecFin.Visible = True
                    Me.txtNroPago.Text = ""
                    Me.txtNroPago.Visible = False
                    Me.KryptonHeaderGroup3.Visible = True
                    Me.KryptonHeaderGroup3.Collapsed = False
                    Me.KryptonHeaderGroup4.Visible = True
                    Me.KryptonHeaderGroup1.ButtonSpecs(0).Visible = False
                    'lblRegimen.Visible = False
                    'chkRegimen.Visible = False
                Case "Rep07" 'Monthly Report
                    chkTiempo.Visible = False
                    chkTiempo.Checked = False
                    '-------------------------
                    Me.cmbCliente.Enabled = True
                    Me.lblOS.Visible = False
                    Me.txtOS.Visible = False
                    Me.txtOS.Text = ""
                    Me.lblMes.Visible = True
                    Me.lblFecFin.Visible = True
                    Me.dtpFecIni.Visible = True
                    Me.dtpFecFin.Visible = True
                    Me.txtNroPago.Text = ""
                    Me.txtNroPago.Visible = False
                    Me.KryptonHeaderGroup3.Visible = False
                    Me.KryptonHeaderGroup3.Collapsed = True
                    Me.KryptonHeaderGroup4.Visible = False
                    Me.KryptonHeaderGroup1.ButtonSpecs(0).Visible = True
                    lblRegimen.Visible = True
                    chkRegimen.Visible = True
                Case "Rep08" 'Reporte Entregas - Embarque Almacen
                    chkTiempo.Visible = False
                    chkTiempo.Checked = False
                    '-------------------------
                    Me.cmbCliente.Enabled = True
                    Me.lblOS.Visible = False
                    Me.txtOS.Visible = False
                    Me.txtOS.Text = ""
                    Me.lblMes.Visible = True
                    Me.lblFecFin.Visible = True
                    Me.dtpFecIni.Visible = True
                    Me.dtpFecFin.Visible = True
                    Me.txtNroPago.Text = ""
                    Me.txtNroPago.Visible = False
                    Me.KryptonHeaderGroup3.Visible = False
                    Me.KryptonHeaderGroup3.Collapsed = True
                    Me.KryptonHeaderGroup4.Visible = False
                    Me.KryptonHeaderGroup1.ButtonSpecs(0).Visible = True
                    'lblRegimen.Visible = False
                    'chkRegimen.Visible = False
                Case Else
                    chkTiempo.Visible = False
                    chkTiempo.Checked = False
                    '-------------------------
                    Me.cmbCliente.Enabled = True
                    Me.lblOS.Visible = False
                    Me.txtOS.Visible = False
                    Me.txtOS.Text = ""
                    Me.lblMes.Visible = True
                    Me.lblFecFin.Visible = True
                    Me.dtpFecIni.Visible = True
                    Me.dtpFecFin.Visible = True
                    Me.txtNroPago.Text = ""
                    Me.txtNroPago.Visible = False
                    Me.KryptonHeaderGroup3.Visible = False
                    Me.KryptonHeaderGroup3.Collapsed = True
                    Me.KryptonHeaderGroup4.Visible = False
                    Me.KryptonHeaderGroup1.ButtonSpecs(0).Visible = False
                    'lblRegimen.Visible = False
                    'chkRegimen.Visible = False

                    'lblIdioma.Visible = False
                    'cboIdioma.Visible = False
            End Select
        End If
    End Sub

    Private Sub Muestra_Imagen()
        Application.DoEvents()
        Me.pbxBuscar.Enabled = True
        Me.pbxBuscar.Update()
        Application.DoEvents()
        Me.pbxBuscar.Visible = True
        Application.DoEvents()
    End Sub

    Private Sub Ocultar_Imagen()
        Me.pbxBuscar.Visible = False
        Me.pbxBuscar.Enabled = False
    End Sub

    Private Sub pbxEnvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxEnvio.Click
        Dim dblFecIni As Double
        Dim dblFecFin As Double

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            dblFecIni = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.Month, "00") & "/" & Me.dtpMesEnvio.Value.Year, Date), "yyyyMMdd")
            dblFecFin = Format(CType("01" & "/" & Format(Me.dtpMesEnvio.Value.AddMonths(1).Month, "00") & "/" & Me.dtpMesEnvio.Value.AddMonths(1).Year, Date).AddDays(-1), "yyyyMMdd")
            If Enviar_Operaciones_Mensuales(Me.cmbCliente.pCodigo, dblFecIni, dblFecFin) Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Envío de datos mensuales correcto")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Enviar_Operaciones_Mensuales(ByVal pdblCliente As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As Boolean
        Dim o3PLreport As New clsRep3PL
        'Dim PSCCMPN As String = GetCompania()
        'Dim PSCDVSN As String = GetDivision(PSCCMPN)
        Dim PSCCMPN As String = "EZ"
        Dim PSCDVSN As String = "S"
        If Not o3PLreport.Registrar_Datos_Mensuales(PSCCMPN, PSCDVSN, pdblCliente, pdblFecIni, pdblFecFin) Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox("No se pudo realizar el Proceso , por falta de los datos en el flete : " & vbCrLf & o3PLreport.Mensaje)
            Return False
        End If
        Return True
    End Function

    Private Sub ButtonSpecHeaderGroup3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup3.Click
        Try
            Actualizar_Tabla()
            pExportarExcelNPOIN(Me.oDs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub Actualizar_Tabla()
        Dim strOC As String = ""
        Dim intCont As Integer
        Dim strOS As String = ""

        For intCont = 0 To oDs.Tables(0).Rows.Count - 1
            If strOS = vbNullString Then
                strOS = oDs.Tables(0).Rows(intCont).Item("PNNMOS").ToString.Trim
                strOC = oDs.Tables(0).Rows(intCont).Item("NORCML").ToString.Trim
                If intCont = oDs.Tables(0).Rows.Count - 1 Then
                    Agregar_Referencia_OC(strOS, strOC)
                End If
            Else
                If strOS = oDs.Tables(0).Rows(intCont).Item("PNNMOS").ToString.Trim Then
                    strOC = strOC & Chr(10) & oDs.Tables(0).Rows(intCont).Item("NORCML").ToString.Trim
                    If intCont = oDs.Tables(0).Rows.Count - 1 Then
                        Agregar_Referencia_OC(strOS, strOC)
                    End If
                Else
                    Agregar_Referencia_OC(strOS, strOC)
                    strOC = oDs.Tables(0).Rows(intCont).Item("NORCML").ToString.Trim
                    strOS = oDs.Tables(0).Rows(intCont).Item("PNNMOS").ToString.Trim
                    If intCont = oDs.Tables(0).Rows.Count - 1 Then
                        Agregar_Referencia_OC(strOS, strOC)
                    End If
                End If
            End If
        Next intCont
    End Sub

    Private Sub Agregar_Referencia_OC(ByVal pstrOS As String, ByVal pstrOC As String)
        Dim intCont As Integer
        Dim intRow As Integer

        For intCont = 1 To Me.oDs.Tables.Count - 1
            For intRow = 0 To Me.oDs.Tables(intCont).Rows.Count - 1
                If Not Me.oDs.Tables(intCont).Columns("NORDSR") Is Nothing Then
                    If Me.oDs.Tables(intCont).Rows(intRow).Item("NORDSR").ToString.Trim = pstrOS.Trim Then
                        Me.oDs.Tables(intCont).Rows(intRow).Item("NORCML") = pstrOC
                    End If
                Else
                    If Me.oDs.Tables(intCont).Rows(intRow).Item("PNNMOS").ToString.Trim = pstrOS.Trim Then
                        Me.oDs.Tables(intCont).Rows(intRow).Item("NORCML") = pstrOC
                    End If
                End If
            Next intRow
        Next intCont
    End Sub

    Private Sub pExportarExcelNPOIN(ByVal poDs As DataSet)
        Dim NPOI As New HelpClass_NPOI_SC
        Dim lstrPeriodo As String = ""
        Dim oListDtReport As New List(Of DataTable)
        Dim Periodo As String = ""
        Dim odtTemp As New DataTable
        Dim oListColDel As New List(Of String)
        Dim ColName As String = ""
        Dim ColCaption As String = ""
        Dim MdataColumna As String = ""
        Dim oSystemType As String
        Dim ListaNumero As New List(Of String)
        ListaNumero.Add("System.Double")
        ListaNumero.Add("System.Int32")
        ListaNumero.Add("System.Int64")
        ListaNumero.Add("System.Decimal")
        Dim TableName As String = ""
        lstrPeriodo = Me.dtpFecIni.Value.ToLongDateString.ToUpper.Split(" ")(3) & " " & Me.dtpFecIni.Value.ToLongDateString.ToUpper.Split(" ")(5)
        For Each odt As DataTable In poDs.Tables
            odtTemp = odt.Copy
            oListColDel.Clear()
            TableName = odtTemp.TableName
            Select Case TableName
                Case "dtOperacion"
                Case "dtFactAduana"
                    For Each Item As DataRow In odtTemp.Rows
                        Item("NORCML") = Item("NORCML_1")
                    Next
                    If odtTemp.Columns("NORCML_1") IsNot Nothing Then
                        odtTemp.Columns.Remove("NORCML_1")
                    End If
                Case "dtAvisoDebito"
                    For Each Item As DataRow In odtTemp.Rows
                        Item("NORCML") = Item("NORCML_1")
                    Next
                    If odtTemp.Columns("NORCML_1") IsNot Nothing Then
                        odtTemp.Columns.Remove("NORCML_1")
                    End If
                    If odtTemp.Columns("TOTCO") IsNot Nothing Then
                        odtTemp.Columns.Remove("TOTCO")
                    End If
                    If odtTemp.Columns("IND_CO") IsNot Nothing Then
                        odtTemp.Columns.Remove("IND_CO")
                    End If
                    If odtTemp.Columns("CHECK_CO") IsNot Nothing Then
                        odtTemp.Columns.Remove("CHECK_CO")
                    End If

                Case "dtTiempoEntrega"
                    For Each Item As DataRow In odtTemp.Rows
                        Item("NORCML") = Item("NORCML_1")
                    Next
                    'If odtTemp.Columns("DIADOC") IsNot Nothing Then
                    '    odtTemp.Columns.Remove("DIADOC")
                    'End If
                    If odtTemp.Columns("NORSCI") IsNot Nothing Then
                        odtTemp.Columns.Remove("NORSCI")
                    End If
                    'If odtTemp.Columns("DIATRA") IsNot Nothing Then
                    '    odtTemp.Columns.Remove("DIATRA")
                    'End If

                    If odtTemp.Columns("CZNFCC") IsNot Nothing Then
                        odtTemp.Columns.Remove("CZNFCC")
                    End If

                    If odtTemp.Columns("CPLNDV") IsNot Nothing Then
                        odtTemp.Columns.Remove("CPLNDV")
                    End If
                    If odtTemp.Columns("NORCML_1") IsNot Nothing Then
                        odtTemp.Columns.Remove("NORCML_1")
                    End If
                    If odtTemp.Columns("TPSRVA") IsNot Nothing Then
                        odtTemp.Columns.Remove("TPSRVA")
                    End If
                    If odtTemp.Columns("ETA") IsNot Nothing Then
                        odtTemp.Columns.Remove("ETA")
                    End If
                Case "dtContenedores"
                    For Each Item As DataRow In odtTemp.Rows
                        Item("NORCML") = Item("NORCML_1")
                    Next
                    If odtTemp.Columns("NORCML_1") IsNot Nothing Then
                        odtTemp.Columns.Remove("NORCML_1")
                    End If
            End Select

            For Columna As Integer = 0 To odtTemp.Columns.Count - 1
                ColName = odtTemp.Columns(Columna).ColumnName
                ColCaption = odtTemp.Columns(Columna).Caption
                If (ColCaption = "") Then
                    oListColDel.Add(ColName)
                Else
                    oSystemType = odtTemp.Columns(Columna).DataType.FullName
                    If (ListaNumero.Contains(oSystemType)) Then
                        MdataColumna = NPOI.FormatDato(ColCaption, HelpClass_NPOI_SC.keyDatoNumero)
                        odtTemp.Columns(Columna).Caption = MdataColumna
                    Else
                        MdataColumna = NPOI.FormatDato(ColCaption, HelpClass_NPOI_SC.keyDatoTexto)
                        odtTemp.Columns(Columna).Caption = MdataColumna
                    End If
                End If
            Next
            For Each Item As String In oListColDel
                odtTemp.Columns.Remove(Item)
            Next
            oListDtReport.Add(odtTemp)
        Next
        NPOI.ExportExcelReportMonthly(oListDtReport, cmbCliente.pRazonSocial, lstrPeriodo)
    End Sub

   
  
End Class

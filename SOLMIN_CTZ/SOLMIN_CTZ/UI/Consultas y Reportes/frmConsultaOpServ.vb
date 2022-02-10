

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Odbc
Imports Ransa.Controls.ServicioOperacion
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmConsultaOpServ



    Private oDtPlanta As New DataTable
    Private oPlanta As New clsPlantaNeg

    Private oServicio As Servicio_BE


    Private odtEstadoOP As New DataTable
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click


        Try


            kdgvServicio.DataSource = Nothing
            kdgvOp.DataSource = Nothing

            oServicio = New Servicio_BE
            '''''''''''''''''''''''''''''''''
            oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
            oServicio.PSUSUARIO = ConfigurationWizard.UserName
            oServicio.CDVSN = UcDivision.Division
            ''
            Dim plantas As String = ""
            plantas = Lista_Tipo_Planta()
            oServicio.TIPO_PLANTA = plantas


            Dim strOp As String = ""
            strOp = Lista_Estado_Operacion()
            oServicio.FLGPEN = strOp

            oServicio.CCLNT = UcCliente.pCodigo
            oServicio.CCLNFC = UcClienteFact.pCodigo

            Dim tipoFechaOPc As String = cmbFechaopc.SelectedValue
            Select Case tipoFechaOPc
                Case "01" ' fecha operacion

                    oServicio.FECSERV_INI = 0
                    oServicio.FECSERV_FIN = 0

                    oServicio.FECINI = dtFeInicial.Value.ToString("yyyyMMdd")
                    oServicio.FECFIN = dtFeFinal.Value.ToString("yyyyMMdd")

                    oServicio.FECREV_INI = 0
                    oServicio.FECREV_FIN = 0

                Case "02"  ' fecha servicio

                    oServicio.FECSERV_INI = dtFeInicial.Value.ToString("yyyyMMdd")
                    oServicio.FECSERV_FIN = dtFeFinal.Value.ToString("yyyyMMdd")

                    oServicio.FECINI = 0
                    oServicio.FECFIN = 0

                    oServicio.FECREV_INI = 0
                    oServicio.FECREV_FIN = 0


                Case "03"  ' fecha revision

                    oServicio.FECSERV_INI = 0
                    oServicio.FECSERV_FIN = 0

                    oServicio.FECINI = 0
                    oServicio.FECFIN = 0

                    oServicio.FECREV_INI = dtFeInicial.Value.ToString("yyyyMMdd")
                    oServicio.FECREV_FIN = dtFeFinal.Value.ToString("yyyyMMdd")

            End Select





            oServicio.CRGVTA = Me.cmbRegionVenta.SelectedValue

            oServicio.NOPRCN = Val(txtOperacion.Text.Trim)
            oServicio.NSECFC = Val(txtNroRevision.Text.Trim)
            oServicio.ESRECCARGA = cmbtipoOpServ.ComboBox.SelectedValue.ToString()



            If oServicio.NOPRCN > 0 Or oServicio.NSECFC > 0 Then
                oServicio.FECINI = 0
                oServicio.FECFIN = 0
                oServicio.FECSERV_INI = 0
                oServicio.FECSERV_FIN = 0
            End If


            Me.pbxProceso.Visible = True
            Me.lblProceso.Visible = True
            Me.lblProceso.Text = "Procesando..."

            bgwProceso.RunWorkerAsync()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub



    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New SOLMIN_CTZ.NEGOCIO.clsRegionVenta
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = oDtRegionVenta
    End Sub

    Private Sub Carga_Estado()


        Dim objDr As DataRow
        odtEstadoOP.Columns.Add(New DataColumn("COD", GetType(String)))
        odtEstadoOP.Columns.Add(New DataColumn("TEX", GetType(String)))


        objDr = odtEstadoOP.NewRow
        objDr.Item(0) = "1"
        objDr.Item(1) = "POR REVISAR"
        odtEstadoOP.Rows.Add(objDr)

        objDr = odtEstadoOP.NewRow
        objDr.Item(0) = "2"
        objDr.Item(1) = "REVISADO"
        odtEstadoOP.Rows.Add(objDr)

        objDr = odtEstadoOP.NewRow
        objDr.Item(0) = "3"
        objDr.Item(1) = "FACTURADO"
        odtEstadoOP.Rows.Add(objDr)



        chkcboEstadoOp.ValueMember = "COD"
        chkcboEstadoOp.DisplayMember = "TEX"
        chkcboEstadoOp.DataSource = odtEstadoOP




    End Sub

    Private Sub CargarPlanta()

        Dim oDtAux As New DataTable
        Dim oDr As DataRow

        oDtAux.Columns.Add("CPLNDV", GetType(String))
        oDtAux.Columns.Add("TPLNTA", GetType(String))


        oDtPlanta = oPlanta.Lista_Planta_Division(UcCompania.CCMPN_CodigoCompania, UcDivision.Division)
        For Each dr As DataRow In oDtPlanta.Rows
            oDr = oDtAux.NewRow
            oDr("CPLNDV") = dr("CPLNDV")
            oDr("TPLNTA") = ("" & dr("TPLNTA")).ToString.Trim
            oDtAux.Rows.Add(oDr)
        Next
        oDtPlanta = oDtAux
        cmbPlanta.ValueMember = "CPLNDV"
        cmbPlanta.DisplayMember = "TPLNTA"
        cmbPlanta.DataSource = oDtPlanta


    End Sub


    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()

    End Sub


    Private Sub frmConsultaOperaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaTablaTipoFecha()


            UcCompania.Usuario = ConfigurationWizard.UserName
            UcCompania.pActualizar()
            UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            kdgvServicio.AutoGenerateColumns = False
            kdgvOp.AutoGenerateColumns = False

            Carga_Estado()
            Cargar_Region_Venta()
            oPlanta.Crea_Lista(ConfigurationWizard.UserName)
            CargarPlanta()

            Dim oList As New List(Of beAyudaGeneral)
            Dim oclsGeneral As New clsAyudaGeneral
            Dim item As New beAyudaGeneral
            item.PSCODIGO = ""
            item.PSDESCRIPCION = ""
            oList = oclsGeneral.ListaTablaAyudaGeneral("TPSROP", "")
            oList.Insert(0, item)


            cmbtipoOpServ.ComboBox.DataSource = oList
            cmbtipoOpServ.ComboBox.ValueMember = "PSCODIGO"
            cmbtipoOpServ.ComboBox.DisplayMember = "PSDESCRIPCION"
            cmbtipoOpServ.ComboBox.SelectedValue = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub CargaTablaTipoFecha()
        Dim dtCarga As New DataTable
        dtCarga.Columns.Add("COD")
        dtCarga.Columns.Add("DESC")
        Dim dr As DataRow

        dr = dtCarga.NewRow
        dr("COD") = "01"
        dr("DESC") = "F. Operación"
        dtCarga.Rows.Add(dr)



        dr = dtCarga.NewRow
        dr("COD") = "02"
        dr("DESC") = "F. Servicio"
        dtCarga.Rows.Add(dr)

        dr = dtCarga.NewRow
        dr("COD") = "03"
        dr("DESC") = "F. Revisión"
        dtCarga.Rows.Add(dr)


        cmbFechaopc.DataSource = dtCarga
        cmbFechaopc.DisplayMember = "DESC"
        cmbFechaopc.ValueMember = "COD"

        cmbFechaopc.SelectedValue = "01"
    End Sub

    Private Function Lista_Estado_Operacion() As String
        Dim strCadDocumentos As String = ""
        Dim strEstadoOp As String = ""
        If chkAnulado.Checked = True Then
            strCadDocumentos = "*,"
        Else

            For i As Integer = 0 To chkcboEstadoOp.CheckedItems.Count - 1
                strEstadoOp = chkcboEstadoOp.CheckedItems(i).Value
                For j As Integer = 0 To odtEstadoOP.Rows.Count - 1
                    'If (oDtPlanta.Rows(j).Item("COD") = chkcboEstadoOp.CheckedItems(i).Value) Then
                    If (odtEstadoOP.Rows(j).Item("COD") = strEstadoOp) Then
                        'strCadDocumentos += oDtPlanta.Rows(j).Item("COD") & ","
                        strCadDocumentos += strEstadoOp & ","
                    End If
                Next
            Next



        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function



    Private Function Lista_Tipo_Planta() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                If (oDtPlanta.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtPlanta.Rows(j).Item("CPLNDV") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function










    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Dim tab As String = ""
            tab = TabControl1.SelectedTab.Name




            If tab = "tbpop" Then

                If kdgvOp.Rows.Count <= 0 Then
                    MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim ODs As New DataSet
                Dim objDt As New DataTable
                Dim loEncabezados As New Generic.List(Of Encabezados)

                'Envia los Parametros para la exportacion
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Listado operaciones"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Listado"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Listado"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                objDt = CType(Me.kdgvOp.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy


                ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.kdgvOp, objDt))


                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)


            End If

            If tab = "tbpserv" Then
                If kdgvServicio.Rows.Count <= 0 Then
                    MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim ODs As New DataSet
                Dim objDt As New DataTable
                Dim loEncabezados As New Generic.List(Of Encabezados)

                'Envia los Parametros para la exportacion
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Listado operación servicios"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Listado servicios"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Listado servicios"))
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                objDt = CType(Me.kdgvServicio.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy


                ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.kdgvServicio, objDt))


                HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgwProceso_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim op As Decimal
        Dim msg As String = ""
        Try


            Dim oServicioOpeNeg As New clsServicio_BL
            Dim oDtServicio As New DataTable
            e.Result = oServicioOpeNeg.fdtListaOpListadoServicios(oServicio)


        Catch ex As Exception
            MessageBox.Show(ex.Message & op & " operación: " & msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Try
            Dim dtresultado As New DataTable

            dtresultado = CType(e.Result, DataTable)



            Dim dtopFin As New DataTable

            dtopFin = dtresultado.Copy
            dtopFin.Clear()
            Dim ohasList As New Hashtable
            Dim operacion As String = ""
            Dim CorrServ As Decimal = 0

            Dim dtServicio As New DataTable
            dtServicio = dtresultado.Copy
            dtServicio.Clear()
            For Each item As DataRow In dtresultado.Rows
                CorrServ = item("NCRROP")
                If CorrServ > 0 Then
                    dtServicio.ImportRow(item)
                End If
            Next

            For Each item As DataRow In dtresultado.Rows
                operacion = ("" & item("NOPRCN")).ToString.Trim
                If Not ohasList.Contains(operacion) Then
                    dtopFin.ImportRow(item)
                    ohasList(operacion) = operacion
                End If
            Next

            kdgvOp.DataSource = dtopFin

            kdgvServicio.DataSource = dtServicio
            'kdgvServicio.DataSource = dtresultado



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.lblProceso.Text = "Finalizado..."
        Me.pbxProceso.Visible = False
        Me.lblProceso.Visible = False
    End Sub



    Private Sub chkAnulado_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnulado.CheckedChanged
        chkcboEstadoOp.Enabled = Not chkAnulado.Checked

        For i As Integer = 0 To chkcboEstadoOp.Items.Count - 1
            chkcboEstadoOp.SetItemChecked(i, False)
        Next

    End Sub
End Class


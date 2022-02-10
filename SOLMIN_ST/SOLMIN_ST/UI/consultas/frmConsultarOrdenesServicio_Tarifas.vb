Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Public Class frmConsultarOrdenesServicio_Tarifas
    Private bolBuscar As Boolean
    Private objPlanta As New NEGOCIO.Planta_BLL
    Dim strPlanta As String = ""
    Private Sub frmConsultarOrdenesServicio_Tarifas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenarEstado()

            Cargar_Compania()

            InicializarFormulario()

            Alinear_Columnas_Grilla()

            gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            gwdDatos.AutoGenerateColumns = False
            ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LlenarEstado()
        'Dim dtEstado As New DataTable
        'Dim dr As DataRow
        'dtEstado.Columns.Add("DISPLAY")
        'dtEstado.Columns.Add("VALUE")
        'dr = dtEstado.NewRow
        'dr("DISPLAY") = "Por Aprobar"
        'dr("VALUE") = ""
        'dtEstado.Rows.Add(dr)

        'dr = dtEstado.NewRow
        'dr("DISPLAY") = "Pendiente"
        'dr("VALUE") = "P"
        'dtEstado.Rows.Add(dr)

        'dr = dtEstado.NewRow
        'dr("DISPLAY") = "Cerrado"
        'dr("VALUE") = "C"
        'dtEstado.Rows.Add(dr)
        'cboEstado.DataSource = dtEstado
        'cboEstado.DisplayMember = "DISPLAY"
        'cboEstado.ValueMember = "VALUE"
        'cboEstado.SelectedValue = "P"

        Dim oDt As New DataTable
        Dim objTipoDatoGeneral As New TipoDatoGeneral_BLL

        Dim dtb As New List(Of TipoDatoGeneral)
        dtb = objTipoDatoGeneral.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "ESTTRF")

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")

        For Each o As TipoDatoGeneral In dtb
            'Dim oDr As DataRow = oDt.NewRow
            oDt.Rows.Add(New Object() {o.CODIGO_TIPO, o.DESC_TIPO})
        Next

        cboEstado.DataSource = oDt
        cboEstado.DisplayMember = "NOM"
        cboEstado.ValueMember = "COD"
        cboEstado.SelectedValue = "A"
        'cboEstado.SelectedValue = "P"

    End Sub
    Private Sub Alinear_Columnas_Grilla()
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

      
    Private Sub InicializarFormulario()
        gwdDatos.DataSource = Nothing
        ControlVisorOrdenServicios.ReportViewer.ReportSource = Nothing
        'ctlCliente.CCMPN = Me.cboCia.SelectedValue.ToString().Trim()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
    End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Try

            'If Me.ctlCliente.pCodigo = 0 Then
            '    MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
            gwdDatos.DataSource = Nothing
            ControlVisorOrdenServicios.ReportViewer.ReportSource = Nothing


            ControlVisorOrdenServicios.Muestra_Imagen()


            strPlanta = ""
            For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

                strPlanta += chkcbxPlanta.CheckedItems(i).Value

                If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                    strPlanta = String.Concat(strPlanta, ",")
                End If

            Next

            If strPlanta = "" Then

                HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)

                ControlVisorOrdenServicios.Ocultar_Imagen()


                Exit Sub

            End If
            Generar_Reporte_Crystal()
           
            ControlVisorOrdenServicios.Ocultar_Imagen()


        Catch ex As Exception

            ControlVisorOrdenServicios.Ocultar_Imagen()
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Function Datos_Reporte_Listado_Tarifa() As DataSet
        Dim dstReporte As New DataSet

        Dim objEntidad As New ReporteListadoTarifas
        Dim objReporte As New Reportes_BLL
        


        objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
        objEntidad.CDVSN = cmbDivision.Division

       
        objEntidad.CPLNDV = strPlanta.Trim()
 


        If Me.ctlCliente.pCodigo.Equals("") = True Then
            objEntidad.CCLNT = 0
        Else
            objEntidad.CCLNT = CInt(Me.ctlCliente.pCodigo)
        End If

       

        objEntidad.SESTOS = cboEstado.SelectedValue.ToString.Trim
        
        dstReporte = objReporte.Listado_Tarifas_por_Cliente_Ordenes_Servicio(objEntidad)
        
        Return dstReporte
    End Function


    Private Sub Generar_Reporte_Crystal()
        Dim dstreporte As New DataSet
        dstreporte = Me.Datos_Reporte_Listado_Tarifa()
        gwdDatos.DataSource = dstreporte.Tables(0)
        If dstreporte Is Nothing Then
            Me.ControlVisorOrdenServicios.ReportViewer.ReportSource = Nothing
            Exit Sub
        End If
        'Try
        Dim strCliente As String = ""
        Dim objReporte = New ReporteListadoTarifasxOrdenServicio
      

        HelpClass.CrystalReportTextObject(objReporte, "lblCompania", cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objReporte, "lblDivision", cmbDivision.DivisionDescripcion)

 
        HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", chkcbxPlanta.Text)

        HelpClass.CrystalReportTextObject(objReporte, "lblEstado", Me.cboEstado.Text)
        objReporte.SetDataSource(dstreporte)
        Me.ControlVisorOrdenServicios.ReportViewer.ReportSource = objReporte
        
    End Sub

    

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
      
        Try

            If gwdDatos.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Consulta Ordenes Servicios - Tarifas"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Consulta Ordenes Servicios - Tarifas"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Reporte Consulta Ordenes Servicios - Tarifas"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "DESSCZ", "CCLNT", "CLIENTE", "PARAMETRO_FACTURACION", "UNIDAD_VEHICULAR", "MERCADERIA", _
                          "OBSERVACIONES_SERVICIO", "TCNTCS_PROPIO", "ORIGEN", "DESTINO", "RUTA", "MONEDA_SERVICIO", _
                          "MONEDA_LIQUIDACION_TRANSPORTISTA", "TCNTCS_PROPIO", "TCNTCS_TERCERO", "PARAMETRO_FACTURACION", _
                          "PLANTA_DESCRIPCION", "FACTOR_IDA_VUELTA", "FECHA_ORDEN_SERVICIO", "NCNTRT"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

                    Case "NRTFSV", "NCRRSR", "DISTANCIA_VIRTUAL", "IMPORTE_COBRAR", "IMPORTE_A_PAGAR", _
                   "MRG", "DETRACCION"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
                    Case "ORDEN_SERVICIO", "CCNBNS_PROPIO", "CCNBNS_TERCERO"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#Region "Planta"
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        'cmbCompania_Seleccionar(Nothing)

    End Sub
    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            'If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
            '    Me.Limpiar()
            '    Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            'End If
            cmbDivision_Seleccionar(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    


    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            Cargar_Planta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

    Private Sub Cargar_Planta()

        chkcbxPlanta.Text = ""
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)


        If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cmbDivision.Division IsNot Nothing) Then

            objPlanta.Crea_Lista()
            '
            objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next

            objEntidad = New ENTIDADES.mantenimientos.ClaseGeneral
            objEntidad.CPLNDV = "-1"
            objEntidad.TPLNTA = "TODOS"
            objLisEntidad.Insert(0, objEntidad)

            chkcbxPlanta.DisplayMember = "TPLNTA"
            chkcbxPlanta.ValueMember = "CPLNDV"
            Me.chkcbxPlanta.DataSource = objLisEntidad

            For i As Integer = 0 To chkcbxPlanta.Items.Count - 1
                'If chkcbxPlanta.Items.Item(i).Value = "1" Then
                If chkcbxPlanta.Items.Item(i).Value = "0" Then
                    chkcbxPlanta.SetItemChecked(i, True)
                End If
            Next
            If chkcbxPlanta.Text = "" Then
                chkcbxPlanta.SetItemChecked(0, True)
            End If

        End If
        
    End Sub

#End Region

 
End Class

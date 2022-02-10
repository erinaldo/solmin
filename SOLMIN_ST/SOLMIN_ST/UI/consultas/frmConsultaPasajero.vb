Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario


Public Class frmConsultaPasajero
    Private objViaje_Pasajero As Viaje_Pasajero

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Try
            Me.gwdDatos.DataSource = Nothing
            Me.Cursor = Cursors.WaitCursor
            PrepararProceesWorked()
            bgwProceso.RunWorkerAsync()
        Catch ex As Exception
            MessageBox.Show("Aviso", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrepararProceesWorked()
        objViaje_Pasajero = New Viaje_Pasajero

        Me.Cursor = Cursors.WaitCursor
        Me.pbxProceso.Visible = True
        Me.lblProceso.Visible = True
        Me.lblProceso.Text = "Procesando..."
        objViaje_Pasajero.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objViaje_Pasajero.PNCCLNT = Convert.ToInt32(Me.ctlCliente.pCodigo)
        If Me.ctlContratista.Resultado Is Nothing Then
            objViaje_Pasajero.PNCPRVCL = 0
        Else
            objViaje_Pasajero.PNCPRVCL = CType(Me.ctlContratista.Resultado, Contratista_Cliente).PNCPRVCL
        End If
        If Me.ctlPasajero.Resultado Is Nothing Then
            objViaje_Pasajero.PSTPDCPE = ""
            objViaje_Pasajero.PSNMDCPE = ""
        Else
            'objViaje_Pasajero.PSTPDCPE = CType(Me.ctlContratista.Resultado, Personal_Contratista).PSTPDCPE
            'objViaje_Pasajero.PSNMDCPE = CType(Me.ctlContratista.Resultado, Personal_Contratista).PSNMDCPE
            objViaje_Pasajero.PSTPDCPE = CType(Me.ctlPasajero.Resultado, Personal_Contratista).PSTPDCPE
            objViaje_Pasajero.PSNMDCPE = CType(Me.ctlPasajero.Resultado, Personal_Contratista).PSNMDCPE
        End If
        objViaje_Pasajero.PNFECINI = Format(dtpFechaInicio.Value, "yyyyMMdd")
        objViaje_Pasajero.PNFECFIN = Format(dtpFechaFin.Value, "yyyyMMdd")
        objViaje_Pasajero.PNCMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
    End Sub

    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Try
            Dim objLogicaReportes As New Viaje_Pasajero_BLL
            e.Result = objLogicaReportes.RptListar_Pasajeros_Contratista_Cliente(objViaje_Pasajero)
        Catch ex As Exception
            MessageBox.Show("Aviso", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Try
            Dim dtreporte As New DataTable
            dtreporte = CType(e.Result, DataTable)
            If dtreporte Is Nothing Then Exit Try

            If dtreporte.Rows.Count > 0 Then dtreporte.TableName = "dtmovOperaciones"
            Me.gwdDatos.DataSource = dtreporte
        Catch ex As Exception
            MessageBox.Show("Aviso", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.lblProceso.Text = "Finalizado..."
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False
        End Try
        Me.lblProceso.Text = "Finalizado..."
        Me.pbxProceso.Visible = False
        Me.lblProceso.Visible = False
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        Me.gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                Me.InicializarFormulario()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Dim oDr As DataRow
        oDr = objTabla.NewRow
        oDr.Item("CMEDTR") = 0
        oDr.Item("TNMMDT") = "TODOS"
        objTabla.Rows.Add(oDr)
        objTabla.Select("", "")

        Dim dv As DataView
        dv = New DataView(objTabla, "", "CMEDTR ASC", DataViewRowState.CurrentRows)

        Me.cboMedioTransporteFiltro.DataSource = dv
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"

    End Sub

    Private Sub InicializarFormulario()
        Me.gwdDatos.DataSource = Nothing
        Me.ctlCliente.pClear()
        Me.ctlCliente.pAccesoPorUsuario = True
        Me.ctlCliente.pRequerido = True
        Me.ctlCliente.pUsuario = USUARIO
        Me.ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
    End Sub

    Private Sub CargarFiltroPasajeros()

        'Filtro de Pasajeros
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTIPODOC"
        oColumnas.DataPropertyName = "PSTIPODOC"
        oColumnas.HeaderText = "Tipo Documento"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSNMDCPE"
        oColumnas.DataPropertyName = "PSNMDCPE"
        oColumnas.HeaderText = "Nro Documento"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSAPENOM"
        oColumnas.DataPropertyName = "PSAPENOM"
        oColumnas.HeaderText = "Nombre"
        oListColum.Add(3, oColumnas)

        Dim ObjPersonal_BL As New Personal_Contratista_BL
        Dim ObjPersonal As New Personal_Contratista
        Dim lintContratista As Int32
        If Not Me.ctlContratista.Resultado Is Nothing Then
            lintContratista = CType(Me.ctlContratista.Resultado, Contratista_Cliente).PNCPRVCL
        End If
        ObjPersonal.PNCCLNT = Me.ctlCliente.pCodigo
        ObjPersonal.PNCPRVCL = IIf(Me.ctlContratista.Resultado Is Nothing, 0, lintContratista)
        ObjPersonal.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Me.ctlPasajero.DataSource = ObjPersonal_BL.Listar_Personal_Contratista_Cliente(ObjPersonal)
        Me.ctlPasajero.ListColumnas = oListColum
        Me.ctlPasajero.Cargas()
        Me.ctlPasajero.Limpiar()
        Me.ctlPasajero.DispleyMember = "PSAPENOM"
        Me.ctlPasajero.ValueMember = "PSNMDCPE"
    End Sub

    Private Sub CargarFiltroContratista(ByVal PNCCLNT As Double)
        'Filtro de Contratistas
        Dim oListColum As New Hashtable
        oListColum = New Hashtable

        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCPRVCL"
        oColumnas.DataPropertyName = "PNCPRVCL"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTPRVCL"
        oColumnas.DataPropertyName = "PSTPRVCL"
        oColumnas.HeaderText = "Contratista "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Dim ObjContratista_BL As New Contratista_Cliente_BL
        Dim ObjContratista As New Contratista_Cliente
        ObjContratista.PNCCLNT = PNCCLNT
        Me.ctlContratista.DataSource = ObjContratista_BL.Listar_Contratista_Cliente_Pasajero(ObjContratista)
        Me.ctlContratista.ListColumnas = oListColum
        Me.ctlContratista.Cargas()
        Me.ctlContratista.Limpiar()
        Me.ctlContratista.DispleyMember = "PSTPRVCL"
        Me.ctlContratista.ValueMember = "PNCPRVCL"
    End Sub

        Private Sub ctlCliente_InformationChanged() Handles ctlCliente.InformationChanged
        Me.CargarFiltroContratista(Me.ctlCliente.pCodigo)
    End Sub

    Private Sub ctlContratista_CambioDeTexto(ByVal objData As System.Object) Handles ctlContratista.CambioDeTexto
        Me.CargarFiltroPasajeros()
    End Sub

    Private Sub frmConsultaPasajero_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Alinear_Columnas_Grilla()
        Me.Cargar_Compania()
        Me.Carga_MedioTransporte()
        Me.CargarFiltroContratista(Me.ctlCliente.pCodigo)
        Me.CargarFiltroPasajeros()
    End Sub

    Private Sub ctlCliente_ExitFocusWithOutData() Handles ctlCliente.ExitFocusWithOutData
        If ctlCliente.pCodigo = 0 Then
            Me.CargarFiltroContratista(Me.ctlCliente.pCodigo)
            Me.CargarFiltroPasajeros()
        End If
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            Dim loEncabezados As New Generic.List(Of Encabezados)

            Dim ObjViaje_Pasajero_BL As New Viaje_Pasajero_BLL

            If Me.ctlCliente.pCodigo <> 0 Then
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILTRO, "CLIENTE: " + Me.ctlCliente.pRazonSocial.Trim))
            End If

            If Not Me.ctlContratista.Resultado Is Nothing Then
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILTRO, "CONTRATISTA :" & " " & CType(Me.ctlContratista.Resultado, Contratista_Cliente).PSTPRVCL))
            End If

            'If Not Me.ctlPasajero.Resultado Is Nothing Then
            '    loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.FILTRO, "PASAJERO : " & " " & CType(Me.ctlContratista.Resultado, Contratista_Cliente).PSTPRVCL))
            'End If
            If Not Me.ctlPasajero.Resultado Is Nothing Then
                loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILTRO, "PASAJERO : " & " " & CType(Me.ctlPasajero.Resultado, Personal_Contratista).PSAPENOM))
            End If

            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILTRO, "Fecha Inicio : " & " " & dtpFechaInicio.Value.Date))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILTRO, "Fecha Fin : " & " " & dtpFechaFin.Value.Date))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILTRO, "Medio Envio : " & " " & cboMedioTransporteFiltro.Text.ToString))


            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Pasajeros"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Resumen Pasajero"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "PASAJEROS POR CONTRATISTA"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "0.00"))

            Dim ds As New Data.DataSet
            Dim _DataSourceDefault As DataTable
            Dim dt As New DataTable
            Dim objLogicaReportes As New Viaje_Pasajero_BLL
            _DataSourceDefault = objLogicaReportes.RptListar_Pasajeros_Contratista_Cliente(objViaje_Pasajero)

            ds.Tables.Add(_DataSourceDefault.Copy)

            dt = ObjViaje_Pasajero_BL.CreaResumenMedioEnvio(_DataSourceDefault)
            loEncabezados.Add(New Encabezados(dt.TableName, Encabezados.TIPOENCABEZADO.TITULO, "Resumen Pasajeros x Medio Transporte"))
            loEncabezados.Add(New Encabezados(dt.TableName, Encabezados.TIPOENCABEZADO.HOJA, "Resumen x Medio Transporte"))
            ds.Tables.Add(dt.Copy)

            dt = ObjViaje_Pasajero_BL.CreaResumenRuta(_DataSourceDefault)
            loEncabezados.Add(New Encabezados(dt.TableName, Encabezados.TIPOENCABEZADO.TITULO, "Resumen Pasajeros x Ruta"))
            loEncabezados.Add(New Encabezados(dt.TableName, Encabezados.TIPOENCABEZADO.HOJA, "Resumen x Ruta"))
            ds.Tables.Add(dt.Copy)

            dt = ObjViaje_Pasajero_BL.CreaResumenTransportista(_DataSourceDefault)
            loEncabezados.Add(New Encabezados(dt.TableName, Encabezados.TIPOENCABEZADO.TITULO, "Resumen Viajes Pasajeros x Transportista"))
            loEncabezados.Add(New Encabezados(dt.TableName, Encabezados.TIPOENCABEZADO.HOJA, "Resumen x Transportista"))
            ds.Tables.Add(dt.Copy)

            Ransa.Utilitario.HelpClass_NPOI.TransformarGrilla(gwdDatos, ds.Tables(0))
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel_Pasajero(loEncabezados, ds)

        Catch ex As Exception
            MessageBox.Show("Aviso", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

End Class

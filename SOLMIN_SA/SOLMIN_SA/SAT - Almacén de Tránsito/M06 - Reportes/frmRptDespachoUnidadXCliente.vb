Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes

Imports RANSA.Utilitario


Public Class frmRptDespachoUnidadXCliente
    Public objCliente As beCliente
    Public Lista As List(Of beCliente)

    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""
    Dim objReporte As New DataSet

    Private Sub frmRptSalidaXAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        Cargar_Clientes1()
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

 
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        txtCliente.Refresh()
        If txtCliente.Resultado IsNot Nothing Then

            Dim Estado As String = txtCliente.Resultado.GetType().ToString

            If Estado = "Ransa.Utilitario.beCliente" Then
                Dim ListaS As String
                ListaS = CType(txtCliente.Resultado, beCliente).Codigo
                If ListaS Is Nothing Then
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                End If
            Else
                Dim ListaS As New List(Of String)
                ListaS = CType(txtCliente.Resultado, List(Of String))

                If ListaS Is Nothing Then
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                Else
                    If ListaS.Count = 0 Then
                        strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                    End If
                End If
            End If
        Else
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        End If

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pGenerarReporte()
    End Sub
    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        btnBuscar.Enabled = True
        btnExportarXLS.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
    End Sub

    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig
        pReporteGuiaSalidaMercaderia()
        strDetalleReporte = "Guía de Salida Mercadería"
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RepRecepcionPorAlmacenClienteCodigo", "")
        objAppConfig = Nothing
    End Sub

    Private Sub pReporteGuiaSalidaMercaderia()
        Dim dstTemp As DataSet = Nothing
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        Dim Est As String = txtCliente.Resultado.GetType.ToString
        With obeFiltro
            If Est = "Ransa.Utilitario.beCliente" Then
                .PSCCLNT = CType(txtCliente.Resultado, beCliente).Codigo
            Else
                .PSCCLNT = ListaCodigoClientes()
            End If
            .PNFECINI = dteFechaInicial.Value
            .PNFECFIN = dteFechaFinal.Value
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .PSNPLCUN = txtPlaca.Text.Trim.ToUpper
        End With
        Dim objTemp2 As New TipoDato_ResultaReporte
        Dim rptTemp As ReportDocument

        dstTemp = obrReporteAT.fdtListarSalidaUnidades(obeFiltro)
        If dstTemp.Tables.Count > 0 Then

            rptTemp = New rptSalidaUnidades
            dstTemp.Tables(0).TableName = "dtSalidaUnidad"
            rptTemp.SetDataSource(dstTemp.Tables(0))
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicial", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
            ' Generamos el Nuevo Tipo de Datos
            objTemp2.add_Tables(dstTemp)
            objTemp2.pReporte = rptTemp
            objReporte = dstTemp
        End If
        objTemp = objTemp2
    End Sub
    Private Function ListaCodigoClientes() As String
        Dim strCadDocumentos As String = ""

        Dim ListaS As New List(Of String)

        ListaS = CType(txtCliente.Resultado, List(Of String))

        For Each i As String In ListaS
            strCadDocumentos += i & ","
        Next

        'For Each items As Integer In cmbCliente.Properties.GetCheckedItems
        '    strCadDocumentos += cmbCliente.Properties.ValueMember & ","
        'Next

        'For i As Integer = 0 To cmbCliente.Properties.Items.Count - 1
        '    strCadDocumentos += cmbCliente.CheckedItems(i).Value & ","
        'Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function
    Sub Cargar_Clientes1()

        Dim obrcliente As New Ransa.Controls.Cliente.cCliente
        Dim obeCliente As New Ransa.Controls.Cliente.TD_Qry_Cliente_L01
        Dim oDtCliente As New DataTable

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With obeCliente
            '.pCCLNT_Cliente = 0
            .pNROPAG_NroPagina = 1
            .pREGPAG_NroRegPorPagina = 1000
            .pUsuario = objSeguridadBN.pUsuario
            .pCCMPN_CodigoCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        End With
        oDtCliente = obrcliente.Listar(obeCliente, "S", 1000, 0)

        Lista = New List(Of beCliente)

        For Each dr As DataRow In oDtCliente.Rows
            objCliente = New beCliente
            objCliente.Codigo = dr("CCLNT")
            If dr("TMTVBJ").ToString.Trim = "" Then
                objCliente.Descripcion = String.Format("{0}", dr("TCMPCL").ToString.Trim)
            Else
                objCliente.Descripcion = String.Format("{0}-{1}", dr("TCMPCL").ToString.Trim, dr("TMTVBJ").ToString.Trim)
            End If

            objCliente.RUC = dr("NRUC")
            objCliente.Estado = 0
            Lista.Add(objCliente)
        Next

        Dim oListColum As New Hashtable

        Dim oColumnas1 As New DataGridViewCheckBoxColumn
        oColumnas1.Name = "CHK"
        oColumnas1.DataPropertyName = "CHK"
        oColumnas1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas1.HeaderText = "Check"
        oColumnas1.ReadOnly = False
        oColumnas1.Visible = True
        oListColum.Add(1, oColumnas1)

        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "Codigo"
        oColumnas.DataPropertyName = "Codigo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "Código"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Descripcion"
        oColumnas.DataPropertyName = "Descripcion"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(3, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "RUC"
        oColumnas.DataPropertyName = "RUC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "RUC"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(4, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Estado"
        oColumnas.DataPropertyName = "Estado"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oColumnas.HeaderText = "Estado"
        oColumnas.Visible = False
        oColumnas.ReadOnly = True
        oListColum.Add(5, oColumnas)

        Me.txtCliente.DataSource = Lista
        Me.txtCliente.ListColumnas = oListColum
        Me.txtCliente.Cargas()
        Me.txtCliente.DispleyMember = "Descripcion"
        Me.txtCliente.ValueMember = "Codigo"
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If fblnValidaInformacion() Then
            Dim punto As New Point
            punto.X = (Me.Width / 2) - (pcxEspera.Width / 2)
            punto.Y = (Me.Height / 2) - (pcxEspera.Height / 2)
            pcxEspera.Visible = True
            pcxEspera.Location = punto
            btnExportarXLS.Enabled = False
            btnBuscar.Enabled = False

            bgwGifAnimado.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        Dim strTitulo As New List(Of String)
        Dim dsReporte As DataSet
        dsReporte = objReporte.Copy
        strTitulo.Add("Fecha Despacho : \n" & Me.dteFechaInicial.Value.ToShortDateString & " Hasta " & Me.dteFechaFinal.Value.ToShortDateString)

        '==========================Exportamos==========================
        dsReporte.Tables(0).Columns("FSLDAL").ColumnName = "Fecha Despacho"
        dsReporte.Tables(0).Columns("NPLCUN").ColumnName = "Nro. Placa"
        dsReporte.Tables(0).Columns("TCMPCL").ColumnName = "Razón Social"
        dsReporte.Tables(0).Columns("NGUIRM").ColumnName = "Nro. Guía"
        dsReporte.Tables(0).Columns("TNMBCH").ColumnName = "Nombre del Chofer"
        dsReporte.Tables(0).Columns("TPOUND").ColumnName = "Tipo de Unidad"
        dsReporte.Tables(0).Columns("CREFFW").ColumnName = "Código de Bulto"
        dsReporte.Tables(0).Columns("FREFFW").ColumnName = "Fecha Recepción"
        dsReporte.Tables(0).Columns("DIAS").ColumnName = "Cantidad de Días"
        dsReporte.Tables(0).Columns("TIPBTO").ColumnName = "Tipo Bulto"
        dsReporte.Tables(0).Columns("QREFFW").ColumnName = "Cantidad en Bulto"
        dsReporte.Tables(0).Columns("TPRVCL").ColumnName = "Nombre del Proveedor"
        dsReporte.Tables(0).Columns("NORCML").ColumnName = "OC"
        dsReporte.Tables(0).Columns("NRITOC").ColumnName = "Nro. Item"
        dsReporte.Tables(0).Columns("TDITES").ColumnName = "Descripción del Item"
        dsReporte.Tables(0).Columns("TUNDIT").ColumnName = "Unidad de Medida"
        dsReporte.Tables(0).Columns("QBLTSR").ColumnName = "Cantidad Despachada"
        dsReporte.Tables(0).Columns("TLUGEN").ColumnName = "Lugar de Destino"
        dsReporte.Tables(0).Columns("QPSOBL").ColumnName = "Pesos Bultos"
        dsReporte.Tables(0).Columns("PETOTA").ColumnName = "Peso Total"
        dsReporte.Tables(0).Columns("QDPROM").ColumnName = "Cantidad de Días Promedio"
        dsReporte.Tables(0).Columns("HRASAL").ColumnName = "Hora de Salida"
        dsReporte.Tables(0).Columns("DESTNO").ColumnName = "Destino"
        dsReporte.Tables(0).Columns("TELLDA").ColumnName = "Tiempo Estimada Llegada"
        dsReporte.Tables(0).Columns.Remove("MARRET")
        HelpClass.ExportExcelConTitulos(dsReporte, Me.Text, strTitulo)
    End Sub
End Class



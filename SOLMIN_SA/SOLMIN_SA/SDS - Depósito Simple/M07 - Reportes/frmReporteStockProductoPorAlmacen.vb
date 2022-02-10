'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.TYPEDEF.Reportes
Imports Ransa.TYPEDEF
Imports Ransa.Utilitario

Public Class frmReporteStockProductoPorAlmacen
#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private rptTemp = New StockProductosPorAlmacenR01
    Private DtReporte As New DataTable
    '--------------------------------------
    Public Lista As List(Of beCliente)
    Public objCliente As beCliente
#End Region

#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        UcCliente.Refresh()
        If UcCliente.Resultado IsNot Nothing Then

            Dim Estado As String = UcCliente.Resultado.GetType().ToString

            If Estado = "Ransa.Utilitario.beCliente" Then
                Dim ListaS As String
                ListaS = CType(UcCliente.Resultado, beCliente).Codigo
                If ListaS Is Nothing Then
                    tsbExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                End If
            Else
                Dim ListaS As New List(Of String)
                ListaS = CType(UcCliente.Resultado, List(Of String))

                If ListaS Is Nothing Then
                    tsbExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                Else
                    If ListaS.Count = 0 Then
                        tsbExportarExcel.Enabled = False
                        strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                    End If
                End If

            End If
        Else
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        End If


        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub pReporteStockProductoPorUbicacionR01()
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        rptTemp = New StockProductosPorAlmacenR01
        Dim strMensaje As String = String.Empty
        Dim obrReporteDS As New brReporteDS
        Dim Est As String = UcCliente.Resultado.GetType.ToString

        ' Filtros
        With obeFiltro
            If Est = "Ransa.Utilitario.beCliente" Then
                .PSCCLNT = CType(UcCliente.Resultado, beCliente).Codigo 'cmbCliente.Properties.GetCheckedItems
            Else
                .PSCCLNT = ListaCodigoClientes()
            End If
            .PSCTPDP6 = "1"
            If txtTipoAlmacen.Resultado IsNot Nothing Then .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
            If txtAlmacen.Resultado IsNot Nothing Then .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
            If txtZonaAlmacen.Resultado IsNot Nothing Then .PSCZNALM = CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM
        End With

        DtReporte = obrReporteDS.fdtRepStockProductoXUbicacion(obeFiltro)
        If strMensaje <> String.Empty Then
            MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'If DtReporte.Rows.Count > 0 Then
        DtReporte.TableName = "StockProductosPorAlmacenR01"
        rptTemp.SetDataSource(DtReporte)
        rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
        rptTemp.SetParameterValue("pCliente", "")
        rptTemp.SetParameterValue("pRazonSocial", "")
        rptTemp.SetParameterValue("pFecha", Now)
        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = rptTemp
        'End If
    End Sub

    Private Sub CargarControles()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub


    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = 1
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNALM"
        oColumnas.DataPropertyName = "PSCZNALM"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMZNA"
        oColumnas.DataPropertyName = "PSTCMZNA"
        oColumnas.HeaderText = "Zona Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            txtZonaAlmacen.DataSource = Nothing
        End If
        txtZonaAlmacen.ListColumnas = oListColum
        txtZonaAlmacen.Cargas()
        txtZonaAlmacen.Limpiar()
        txtZonaAlmacen.ValueMember = "PSCZNALM".Trim()
        txtZonaAlmacen.DispleyMember = "PSTCMZNA"
    End Sub

    Private Function ListaCodigoClientes() As String
        Dim strCadDocumentos As String = ""

        Dim ListaS As New List(Of String)

        ListaS = CType(UcCliente.Resultado, List(Of String))

        For Each i As String In ListaS
            strCadDocumentos += i & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Function ListaRazonSocialClientes() As String
        Dim strCadDocumentos As String = ""
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function
#End Region

#Region "Eventos de Control"
    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteStockProductoPorUbicacionR01()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            pcxEspera.Visible = False
            tsbGenerarReporte.Enabled = True

            tsbEnviarCorreo.Enabled = True
            tsbExportarExcel.Enabled = True
            crvReporte.Visible = True
            crvReporte.ReportSource = objTemp.pReporte
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmReporteStockProductoPorAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        CargarControles()
        Cargar_Clientes1()
    End Sub

    Sub Cargar_Clientes1()

        'Dim obrcliente As New Ransa.DAO.Cliente.cCliente
        'Dim obeCliente As New Ransa.TYPEDEF.Cliente.TD_Qry_Cliente_L01
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

        Me.UcCliente.DataSource = Lista

        Me.UcCliente.ListColumnas = oListColum
        Me.UcCliente.Cargas()
        Me.UcCliente.DispleyMember = "Descripcion"
        Me.UcCliente.ValueMember = "Codigo"
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        DtReporte.TableName = "Inventario de Productos por Almacén"

        DtReporte.Columns(0).ColumnName = "CLIENTE \n COD"
        DtReporte.Columns(1).ColumnName = "CLIENTE \n RAZÓN SOCIAL"
        DtReporte.Columns(2).ColumnName = "TIPO ALMACEN \n COD"
        DtReporte.Columns(3).ColumnName = "TIPO ALMACEN \n DETALLE"
        DtReporte.Columns(4).ColumnName = "ALMACEN \n COD"
        DtReporte.Columns(5).ColumnName = "ALMACEN \n DETALLE"
        DtReporte.Columns(6).ColumnName = "ZONA ALMACEN \n COD"
        DtReporte.Columns(7).ColumnName = "ZONA ALMACEN \n DETALLE"
        DtReporte.Columns(8).ColumnName = "CÓDIGO \n MERCADERIA"
        DtReporte.Columns(9).ColumnName = "ORDEN \n SERVICIO"
        DtReporte.Columns(10).ColumnName = "CODIGO \n RANSA"
        DtReporte.Columns(11).ColumnName = "DETALLE \n MERCADERIA"
        DtReporte.Columns(12).ColumnName = "REF. \n UBICACIÓN"
        DtReporte.Columns(13).ColumnName = "SALDO \n CANTIDAD"
        DtReporte.Columns(14).ColumnName = "SALDO \n UNIDAD"
        DtReporte.Columns(15).ColumnName = "SALDO \n PESO"
        DtReporte.Columns(16).ColumnName = "SALDO \n UNIDAD "

        Dim oDs As New DataSet
        oDs.Tables.Add(DtReporte.Copy)
        'Dim strTitulo As String = "INVENTARIO DE PRODUCTOS POR ALMACEN"
        '==========================Exportamos==========================
        'HelpClass.ExportExcelStockProductoXAlmacen(oDs, strTitulo)
        '==============================================================

        Dim strTitulo As New List(Of String)
        strTitulo.Add("Cliente: \n" & " - ")
        strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)
        If txtTipoAlmacen.Text = "" Then
            strTitulo.Add("Tipo Almacén : \n" & "TODOS")
        Else
            strTitulo.Add("Tipo Almacén : \n" & txtTipoAlmacen.Text)
        End If
        If txtAlmacen.Text = "" Then
            strTitulo.Add("Almacén : \n" & "TODOS")
        Else
            strTitulo.Add("Almacén : \n" & txtAlmacen.Text)
        End If
        If txtZonaAlmacen.Text = "" Then
            strTitulo.Add("Zona Almacén : \n" & "TODOS")
        Else
            strTitulo.Add("Zona Almacén : \n" & txtZonaAlmacen.Text)
        End If
        '==========================Exportamos==========================
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

#End Region

    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        Try
            If fblnValidaInformacion() Then

                pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
                pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)

                pcxEspera.Visible = True

                tsbEnviarCorreo.Enabled = False
                tsbExportarExcel.Enabled = False
                tsbGenerarReporte.Enabled = False
                crvReporte.Visible = False
                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class

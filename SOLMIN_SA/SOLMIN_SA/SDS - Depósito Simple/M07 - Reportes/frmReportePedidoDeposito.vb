Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario
Imports Ransa.TypeDef
Imports Microsoft.VisualBasic

Public Class frmReportePedidoDeposito
#Region "Declaracion de variables"
    Private intNroTotalPaginas As Int32 = 0
    Private strMensajeError As String = ""
    Public Event ErrorMessage(ByVal strMensaje As String)
#End Region
#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtCliente.pCodigo = 0 Then
            'tsbExportarExcel.Enabled = False
            If cmbFechas.SelectedIndex = -1 Then
                strMensajeError &= "Debe seleccionar una de las Fechas " & vbNewLine
            End If
            If (HelpClass.CDate_a_Numero8Digitos(Me.dteFechaInicial.Value) = 0) Then
                strMensajeError &= "Debe seleccionar la Fecha Inicial. " & vbNewLine
            End If
            If (HelpClass.CDate_a_Numero8Digitos(Me.dteFechaFinal.Value) = 0) Then
                strMensajeError &= "Debe seleccionar la Fecha Final. " & vbNewLine
            End If

        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub CargarControles()
        ''==========Agente Aduana
        Dim obrGeneral As New RANSA.NEGO.brGeneral
        Dim oListColumTB As New Hashtable
        Dim oColumnasTB As New DataGridViewTextBoxColumn
        oColumnasTB.Name = "CAGNAD"
        oColumnasTB.DataPropertyName = "PNCAGNAD"
        oColumnasTB.HeaderText = "Código "
        oListColumTB.Add(1, oColumnasTB)
        oColumnasTB = New DataGridViewTextBoxColumn
        oColumnasTB.Name = "TCMAA"
        oColumnasTB.DataPropertyName = "PSTCMAA"
        oColumnasTB.HeaderText = "Agente de Aduana"
        oListColumTB.Add(2, oColumnasTB)
        If txtAgenteAduana.Resultado IsNot Nothing Then
            txtAgenteAduana.DataSource = obrGeneral.olAgenteAduana(CType(Me.txtAgenteAduana.Resultado, beGeneral).PSTCMAA)
        Else
            txtAgenteAduana.DataSource = obrGeneral.olAgenteAduana("")
        End If

        txtAgenteAduana.ListColumnas = oListColumTB
        txtAgenteAduana.Cargas()
        txtAgenteAduana.ValueMember = "PNCAGNAD"
        txtAgenteAduana.DispleyMember = "PSTCMAA"

        cmbFechas.Items.Insert(0, "F. INGRESO PED. DEPOSITO")
        cmbFechas.Items.Insert(1, "F. VENCIMIENTO PED. DEPOSITO")
        cmbFechas.Items.Insert(2, "F. DE LLEGADA")
        cmbFechas.Items.Insert(3, "F. DE FACT. COMERCIAL")
        cmbFechas.Items.Insert(4, "F. DE EXPORTACION")
        cmbFechas.Items.Insert(5, "F. NUMERACION PED. ADUANA")
        cmbFechas.Items.Insert(6, "F. DE AFORO")

        cmbFechas.SelectedIndex = 0
        chkFechas.Checked = False
        gbFechas.Enabled = False
    End Sub

    Private Sub pCargarInformacion()
        If fblnValidaInformacion() Then
            Dim objPedidoDeposito As New blPedidoDeposito
            Dim Filtro As New bePedidoDeposito
            With Filtro
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCCLNT = txtCliente.pCodigo
                If chkFechas.Checked = True Then
                    .PNFSLLADINI = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaInicial.Value)
                    .PNFSLLADFIN = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaFinal.Value)
                    .PNFECHA = cmbFechas.SelectedIndex()
                Else
                    .PNFECHA = 7
                End If
                If txtAgenteAduana.Resultado IsNot Nothing Then
                    .PNCAGNAD = CType(txtAgenteAduana.Resultado, beGeneral).PNCAGNAD
                End If
                If txtNumDepAduana.Text.Trim = "" Then
                    .PNNPDDPA = 0
                Else
                    .PNNPDDPA = txtNumDepAduana.Text.Trim
                End If
                If txtNPedRansa.Text.Trim = "" Then
                    .PNNPDDPR = 0
                Else
                    .PNNPDDPR = txtNPedRansa.Text.Trim
                End If
                .PSNFCTCM = txtFactura.Text.Trim.ToUpper()
                .PSNCNCEM = txtB2AWB.Text.Trim.ToUpper()
                .PageSize = Me.UcPaginacion1.PageSize
                .PageNumber = Me.UcPaginacion1.PageNumber
            End With
            dgPedido.AutoGenerateColumns = False
            dgPedido.DataSource = objPedidoDeposito.ListarConsultaPedidoDeposito(Filtro)

            If TryCast(dgPedido.DataSource, List(Of bePedidoDeposito)).Count > 0 Then
                UcPaginacion1.PageCount = TryCast(dgPedido.DataSource, List(Of bePedidoDeposito)).Item(0).PageCount
                tsbExportarExcel.Enabled = True
            End If

        End If
    End Sub

    Private Sub pListarSeries()
        If dgPedido.RowCount = 0 Or dgPedido.CurrentRow Is Nothing Then
            dgSerie.DataSource = New DataTable
            Exit Sub
        End If

        Dim objFiltro As New beSeries
        Dim objSerie As New blSerie
        Dim oListaSeries As New List(Of beSeries)
        With objFiltro
            .PNNPDDPR = dgPedido.CurrentRow.DataBoundItem.PNNPDDPR
        End With

        oListaSeries = objSerie.ListarSerie(objFiltro)
        dgSerie.AutoGenerateColumns = False
        dgSerie.DataSource = oListaSeries
        For i As Integer = 0 To dgSerie.Rows.Count - 1
            dgSerie.Rows(i).Cells("NPDDPR1").Value = dgPedido.CurrentRow.DataBoundItem.PNNPDDPR
        Next
    End Sub

    Private Sub pListarPoliza()
        If dgPedido.RowCount = 0 Or dgPedido.CurrentRow Is Nothing Then
            dgPoliza.DataSource = New DataTable
            Exit Sub
        End If

        Dim objFiltro As New bePoliza
        Dim objPoliza As New blPoliza
        Dim oListaPoliza As New List(Of bePoliza)
        With objFiltro
            .PNNPDDPR = dgPedido.CurrentRow.DataBoundItem.PNNPDDPR
        End With

        oListaPoliza = objPoliza.ListarPoliza(objFiltro)
        dgPoliza.AutoGenerateColumns = False
        dgPoliza.DataSource = oListaPoliza
        For i As Integer = 0 To dgPoliza.Rows.Count - 1
            dgPoliza.Rows(i).Cells("NPDDPR2").Value = dgPedido.CurrentRow.DataBoundItem.PNNPDDPR
        Next
    End Sub

#End Region

#Region "Eventos de control"
    Private Sub frmReportePedidoDeposito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dteFechaInicial.Value = Now.AddYears(-1)
        dteFechaFinal.Value = Now

        'Cargar Cliente
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        'Cargar Compañia
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        'Cargar Division
        UcDivision_Cmb011.Compania = UcCompania_Cmb011.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
        'Cargar Agente de Aduana
        CargarControles()
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania)
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Call pCargarInformacion()
    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        Call pCargarInformacion()
    End Sub

    Private Sub dgPedido_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPedido.CurrentCellChanged
        If dgPedido.Rows.Count > 0 Then
            Call pListarSeries()
            Call pListarPoliza()
        End If
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        If fblnValidaInformacion() Then
            Dim objPedidoDeposito As New blPedidoDeposito
            Dim Filtro As New bePedidoDeposito
            With Filtro
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCCLNT = txtCliente.pCodigo
                If chkFechas.Checked = True Then
                    .PNFSLLADINI = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaInicial.Value)
                    .PNFSLLADFIN = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaFinal.Value)
                    .PNFECHA = cmbFechas.SelectedIndex()
                Else
                    .PNFECHA = 7
                End If
                If txtAgenteAduana.Resultado IsNot Nothing Then
                    .PNCAGNAD = CType(txtAgenteAduana.Resultado, beGeneral).PNCAGNAD
                End If
                If txtNumDepAduana.Text.Trim = "" Then
                    .PNNPDDPA = 0
                Else
                    .PNNPDDPA = txtNumDepAduana.Text.Trim
                End If
                If txtNPedRansa.Text.Trim = "" Then
                    .PNNPDDPR = 0
                Else
                    .PNNPDDPR = txtNPedRansa.Text.Trim
                End If
                .PSNFCTCM = txtFactura.Text.Trim.ToUpper()
                .PSNCNCEM = txtB2AWB.Text.Trim.ToUpper()
                .PageSize = Me.UcPaginacion1.PageSize * UcPaginacion1.PageCount
                .PageNumber = 1
            End With

            Dim oDt As New DataTable
            oDt = Ransa.Utilitario.HelpClass.IList_DataTable(objPedidoDeposito.ListarConsultaPedidoDeposito(Filtro))

            If oDt Is Nothing OrElse oDt.Rows.Count = 0 Then
                Exit Sub
            End If
            oDt.Columns.Remove("PSCCMPN")
            oDt.Columns.Remove("PSCDVSN")
            oDt.Columns.Remove("PSTABRCL")
            oDt.Columns.Remove("PNFLLGD")
            oDt.Columns.Remove("PNCAGNAD")
            oDt.Columns.Remove("PNCCLNT")
            oDt.Columns.Remove("PNFINGDP")
            oDt.Columns.Remove("PNHINGDP")
            oDt.Columns.Remove("PNFVNPDD")
            oDt.Columns.Remove("PSCUNDTR")
            oDt.Columns.Remove("PNCEMTDP")
            'oDt.Columns.Remove("PSTBRUNT")
            oDt.Columns.Remove("PNCVSTRN")
            oDt.Columns.Remove("PSCVPRCN")
            oDt.Columns.Remove("PNFFCTCM")
            oDt.Columns.Remove("PNCPAIS")
            oDt.Columns.Remove("PSCPRTEM")
            oDt.Columns.Remove("PSCPRTOR")
            oDt.Columns.Remove("PNFEMBR")
            oDt.Columns.Remove("PSCPRTDS")
            oDt.Columns.Remove("PNCTPOAD")
            oDt.Columns.Remove("PNFSLLADINI")
            oDt.Columns.Remove("PNFSLLADFIN")
            oDt.Columns.Remove("PSCTRMDP")
            oDt.Columns.Remove("PNFSLLAD")
            'oDt.Columns.Remove("PSCTRMDP")
            oDt.Columns.Remove("PSCTPOCR")
            oDt.Columns.Remove("PNCEXCRI")
            oDt.Columns.Remove("PNFAFRO")
            oDt.Columns.Remove("PNFECHA")
            oDt.Columns.Remove("PageSize")
            oDt.Columns.Remove("PageCount")
            oDt.Columns.Remove("PageNumber")
            oDt.Columns.Remove("PSERROR")
            oDt.Columns.Remove("PSUSUARIO")
            oDt.Columns.Remove("PSNTRMNL")
            oDt.Columns.Remove("PNNGUIRN")

            oDt.Columns(0).ColumnName = " \n N° PED. RANSA"
            oDt.Columns(1).ColumnName = " \n N° CONTRATO"
            oDt.Columns(2).ColumnName = " \n FECHA LLEGADA"
            oDt.Columns(3).ColumnName = " \n CAN. TOTAL BULTOS"
            oDt.Columns(4).ColumnName = " \n N° CERT. DE INSP."
            oDt.Columns(5).ColumnName = " \n AGENTE DE ADUANA"
            oDt.Columns(6).ColumnName = " \n CLIENTE"
            oDt.Columns(7).ColumnName = " \n CONSIGNATARIO"
            oDt.Columns(8).ColumnName = " \n FECHA DE ING. DEP."
            oDt.Columns(9).ColumnName = " \n HORA DE ING. DEP."
            oDt.Columns(10).ColumnName = " \n FECHA DE VENCIMIENTO"
            oDt.Columns(11).ColumnName = " \n UNIDAD DE TRANSPORTE"
            oDt.Columns(12).ColumnName = " \n EMPRESA DE TRANSPORTE"
            oDt.Columns(13).ColumnName = " \n VIAS DE TRANSPORTE"
            oDt.Columns(14).ColumnName = " \n VAPOR"
            oDt.Columns(15).ColumnName = " \n BANDERA DEL VAPOR"
            oDt.Columns(16).ColumnName = " \n N° DE MANIFIESTO"
            oDt.Columns(17).ColumnName = " \n B2 / AWB"
            oDt.Columns(18).ColumnName = " \n N° FACT. COMERCIAL"
            oDt.Columns(19).ColumnName = " \n FECHA DE FAC. COMERCIAL"
            oDt.Columns(20).ColumnName = " \n PAIS"
            oDt.Columns(21).ColumnName = " \n PUERTO DE EMBARQUE"
            oDt.Columns(22).ColumnName = " \n PUERTO ORIGEN"
            oDt.Columns(23).ColumnName = " \n FECHA DE EXPORTACION"
            oDt.Columns(24).ColumnName = " \n PUERTO DESTINO"
            oDt.Columns(25).ColumnName = " \n IMPORTE VAL. FOB"
            oDt.Columns(26).ColumnName = " \n IMPORTE VAL. FLETE"
            oDt.Columns(27).ColumnName = " \n IMPORTE VAL. SEGURO"
            oDt.Columns(28).ColumnName = " \n IMPORTE VAL. CIF PAGADO"
            oDt.Columns(29).ColumnName = " \n TIPO CAMBIO P. DEPÓSITO"
            oDt.Columns(30).ColumnName = " \n TIPO ADUANA"
            oDt.Columns(31).ColumnName = " \n N° PED. DEP. ADUANA"
            oDt.Columns(32).ColumnName = " \n FEC. NUM. PED. ADUANA"
            oDt.Columns(33).ColumnName = " \n TERMINAL P. DEPÓSITO"
            oDt.Columns(34).ColumnName = " \n TIPO CARGA"
            oDt.Columns(35).ColumnName = " \n EXONERACIÓN"
            oDt.Columns(36).ColumnName = " \n CAN. TOTAL BULTOS RECIBIDOS"
            oDt.Columns(37).ColumnName = " \n PESO BRUTO TOTAL"
            oDt.Columns(38).ColumnName = " \n PESO BRUTO TOTAL RECIBIDO"
            oDt.Columns(39).ColumnName = " \n PESO NETO TOTAL"
            oDt.Columns(40).ColumnName = " \n PESO NETO TOTAL RECIBIDO"
            oDt.Columns(41).ColumnName = " \n FECHA DE AFORO"

            Dim oDs As New DataSet
            oDs.Tables.Add(oDt.Copy)

            Dim oLstrTtitulo As New List(Of String)
            oLstrTtitulo.Add("CLIENTE: \n " & txtCliente.pRazonSocial)
            If (chkFechas.Checked = True) Then
                oLstrTtitulo.Add(cmbFechas.SelectedItem.ToString & ": \n " & "Desde: " & dteFechaInicial.Value.Date & "Hasta: " & dteFechaFinal.Value.Date)
            End If
            HelpClass.ExportExcelConTitulos(oDs, Me.Text, oLstrTtitulo)
        End If
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub chkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechas.CheckedChanged
        If chkFechas.Checked = True Then
            gbFechas.Enabled = True
        Else
            gbFechas.Enabled = False
        End If
    End Sub

#End Region


End Class


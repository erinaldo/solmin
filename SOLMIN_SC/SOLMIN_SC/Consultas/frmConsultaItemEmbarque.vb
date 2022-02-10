Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Public Class frmConsultaItemEmbarque

    Dim ListaDatatable As New List(Of DataTable)
    Dim ListaTitulos As New List(Of String)
    Dim dt As New DataTable

    Private Sub frmConsultaItemEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            cmbCliente.pAccesoPorUsuario = True
            cmbCliente.pRequerido = True
            cmbCliente.pUsuario = HelpUtil.UserName
            ListarPais()
            ListarCanal()
            ListarRegimen()
            chkCheckPoint.Checked = False
            chkOS.Checked = False

            'chkFecha_FORSCI.Checked = False
            chkFecha_FORSCI.Checked = True
            chkFecha_FORSCI.Enabled = False
            chkFecha_FORSCI_CheckedChanged(chkFecha_FORSCI, Nothing)

            dtpFORSCI_FIN.Value = Today
            dtpFORSCI_INI.Value = Today
            chkCheckPoint_CheckedChanged(chkCheckPoint, Nothing)
            chkOS_CheckedChanged(chkOS, Nothing)
            dtgDatos.AutoGenerateColumns = False
            Control.CheckForIllegalCrossThreadCalls = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            If cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Debe seleccionar el cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            pbxBuscar.Visible = True
            lblBusqueda.Visible = True
            btnBuscar.Enabled = False
            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception
            pbxBuscar.Visible = False
            lblBusqueda.Visible = False
            btnBuscar.Enabled = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub ListarRegimen()
        chkRegimen.Items.Clear()
        Dim odtRegimen As New DataTable
        odtRegimen.Columns.Add("NCODRG")
        odtRegimen.Columns.Add("TDSCRG")
        Dim obrRegimen As New clsRegimen
        Dim oListRegimen As New List(Of beRegimen)
        oListRegimen = obrRegimen.ListarRegimen()

        Dim obeRegimen As New beRegimen
        obeRegimen.PNTPORGE = 0
        obeRegimen.PSTCMRGA = "::TODOS::"
        oListRegimen.Insert(0, obeRegimen)

        Dim drItem As DataRow
        For Each ItemRegimen As beRegimen In oListRegimen
            drItem = odtRegimen.NewRow
            drItem("NCODRG") = ItemRegimen.PNTPORGE
            drItem("TDSCRG") = ItemRegimen.PSTCMRGA
            odtRegimen.Rows.Add(drItem)
        Next
        chkRegimen.DataSource = odtRegimen
        chkRegimen.DisplayMember = "TDSCRG"
        chkRegimen.ValueMember = "NCODRG"
        For i As Integer = 0 To chkRegimen.Items.Count - 1
            If chkRegimen.Items.Item(i).Value = "0" Then
                chkRegimen.SetItemChecked(i, True)
            End If
        Next
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
        Else
            For i As Integer = 0 To chkRegimen.CheckedItems.Count - 1
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

    Private Sub ListarCanal()
        Dim oBL_Canal As New clsCanal
        Dim oListCanal As New List(Of beCanal)
        'oListCanal = oBL_Canal.Lista_Canal_Todos
        oListCanal = oBL_Canal.Lista_Canal("")

        Dim obeCanal As beCanal
        obeCanal = New beCanal
        obeCanal.PSNCANAL = "::TODOS::"
        obeCanal.PSTCANAL = "-1"
        oListCanal.Insert(0, obeCanal)
        cboCanal.DataSource = oListCanal
        cboCanal.DisplayMember = "PSNCANAL"
        cboCanal.ValueMember = "PSTCANAL"
    End Sub

    Private Sub ListarPais()
        Dim oBL_Pais As New clsPais
        Dim oListPais As New List(Of bePais)
        oListPais = oBL_Pais.Listar_Pais
        Dim obePais As New bePais
        obePais.PNCPAIS = -1
        obePais.PSTCMPPS = "::TODOS::"
        oListPais.Insert(0, obePais)
        cboPaisOrigen.DataSource = oListPais
        cboPaisOrigen.ValueMember = "PNCPAIS"
        cboPaisOrigen.DisplayMember = "PSTCMPPS"
        cboPaisOrigen.SelectedValue = -1D
    End Sub
    Private Function ListaFiltros() As beFiltroBusquedaItem
        Dim obeFiltroBusquedaItem As New beFiltroBusquedaItem
        obeFiltroBusquedaItem.PSCCMPN = cmbCompania.CCMPN_CodigoCompania
        obeFiltroBusquedaItem.PNCCLNT = cmbCliente.pCodigo
        obeFiltroBusquedaItem.PNCPRVCL = UcProveedor.pCodigo
        If cboPaisOrigen.SelectedValue = -1D Then
            obeFiltroBusquedaItem.PNCPAIS = 0
        Else
            obeFiltroBusquedaItem.PNCPAIS = cboPaisOrigen.SelectedValue
        End If
        If chkCheckPoint.Checked = True Then
            obeFiltroBusquedaItem.PNCHK = cboTipoFecha.SelectedValue
            obeFiltroBusquedaItem.PNCHK_FECHA_INI = dtpCHKInicio.Value.ToString("yyyyMMdd")
            obeFiltroBusquedaItem.PNCHK_FECHA_FIN = dtpCHKFin.Value.ToString("yyyyMMdd")
    End If

    ' Agregado FORSCI

    If chkFecha_FORSCI.Checked = True Then
      obeFiltroBusquedaItem.FORSCI_INI = dtpFORSCI_INI.Value.ToString("yyyyMMdd")
      obeFiltroBusquedaItem.FORSCI_FIN = dtpFORSCI_FIN.Value.ToString("yyyyMMdd")
    End If
    '--------------------------------
        If chkOS.Checked = True Then
            obeFiltroBusquedaItem.PNPNNMOS_INI = IIf(txtOSIni.Text.Length > 0, txtOSIni.Text, 0)
            obeFiltroBusquedaItem.PNPNNMOS_FIN = IIf(txtOSFin.Text.Length > 0, txtOSFin.Text, 0)
        End If
        If txtEmbarque.Text.Length > 0 Then
            obeFiltroBusquedaItem.PNNORSCI = txtEmbarque.Text
        End If
        obeFiltroBusquedaItem.PSCPTDAR = txtPartida.Text.Trim.ToUpper
        obeFiltroBusquedaItem.PSTDITES = txtMercadería.Text.Trim.ToUpper
        If cboCanal.SelectedValue <> "-1" Then
            obeFiltroBusquedaItem.PSCANAL = cboCanal.SelectedValue
        End If
        obeFiltroBusquedaItem.PSNDOCEM = txtDocEmbarque.Text.Trim.ToUpper
        obeFiltroBusquedaItem.PSLISTREGIMEN = ListaRegimenSeleccionado()
        obeFiltroBusquedaItem.PSNORCML = txtOC.Text.Trim.ToUpper
        Return obeFiltroBusquedaItem
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpUtil.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

   
    Private Sub cmbCliente_InformationChanged() Handles cmbCliente.InformationChanged
        Try
            cboTipoFecha.DataSource = Nothing
            Dim PNCCLNT As Decimal = 0
            If Me.cmbCliente.pCodigo > 0 Then
                PNCCLNT = Me.cmbCliente.pCodigo
            Else
                Exit Sub
            End If
            Dim oclsCheckPoint As New clsCheckPoint
            Dim CCMPN As String = cmbCompania.CCMPN_CodigoCompania
            Dim CDVSN As String = GetDivision(CCMPN)
            Dim dtListaCheck As New DataTable
            dtListaCheck = oclsCheckPoint.Lista_All_CheckPoint_X_Cliente(PNCCLNT, CCMPN, CDVSN)
            cboTipoFecha.DataSource = dtListaCheck
            cboTipoFecha.DisplayMember = "TDESES"
            cboTipoFecha.ValueMember = "NESTDO"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub chkCheckPoint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckPoint.CheckedChanged
        gbCheckPoint.Enabled = chkCheckPoint.Checked
    End Sub

    Private Sub chkOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOS.CheckedChanged
        gbOrdenServicio.Enabled = chkOS.Checked
    End Sub

    Private Sub dtgDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellContentClick
        If dtgDatos.Columns(e.ColumnIndex).Name = "NORSCI" Then
            If dtgDatos.CurrentRow IsNot Nothing Then
                Dim oFrmConsultaDetalleEmbarque As New FrmConsultaDetalleEmbarque()
                oFrmConsultaDetalleEmbarque.pCCLNT = dtgDatos.CurrentRow.Cells("CCLNT").Value
                oFrmConsultaDetalleEmbarque.pCCMPN = ("" & dtgDatos.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                oFrmConsultaDetalleEmbarque.pCDVSN = ("" & dtgDatos.CurrentRow.Cells("CDVSN").Value).ToString.Trim
                oFrmConsultaDetalleEmbarque.pNORSCI = dtgDatos.CurrentRow.Cells("NORSCI").Value
                oFrmConsultaDetalleEmbarque.ShowDialog()
            End If
        End If

    End Sub

  Private Sub chkFecha_FORSCI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha_FORSCI.CheckedChanged
    gbFecha.Enabled = chkFecha_FORSCI.Checked
  End Sub

    Private Sub btnExportarGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarGeneral.Click
        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim lstrPeriodo As String = ""
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            Dim Cab() As String
            Dim oFnSEguimiento As New FuncionServSeguimiento
            For Each Item As DataGridViewColumn In dtgDatos.Columns
                ColTitle = Item.HeaderText.Trim
                ColName = Item.Name
                TipoDato = ""
                If Item.Visible = True Then
                    If ColName.EndsWith("_CHK") Or ColName.Contains("FORSCI") Or ColName.Contains("FCEMSN") Then
                        TipoDato = NPOI_SC.keyDatoFecha
                        ColTitle = ColTitle.Replace(Chr(13), "")
                        '////FORMATEO COLUMNA CABECERA VARIAS FILAS
                        Cab = ColTitle.Split(Chr(10))
                        ColTitle = oFnSEguimiento.FormatearCabecera(Cab(0))
                        If Cab.Length > 1 Then
                            ColTitle = ColTitle & Chr(10) & Cab(1)
                        End If
                        '///////////////
                    Else
                        TipoDato = NPOI_SC.keyDatoTexto
                    End If
                    dtExport.Columns.Add(ColName)
                    MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                    dtExport.Columns(ColName).Caption = MdataColumna
                End If
            Next

            Dim dr As DataRow
            For Fila As Integer = 0 To dtgDatos.Rows.Count - 1
                dr = dtExport.NewRow
                For Columna As Integer = 0 To dtExport.Columns.Count - 1
                    ColName = dtExport.Columns(Columna).ColumnName
                    If (dtgDatos.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                        dr(ColName) = dtgDatos.Rows(Fila).Cells(ColName).FormattedValue
                    End If
                Next
                dtExport.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(1) = Today.ToString("dd/MM/yyyy")
            'Dim Titulo As String = "LISTA DE MERCADERÍAS"
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, Titulo, Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExport.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTA DE MERCADERÍAS")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportarContugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarContugas.Click
        Try

            If dtgDatos.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim NPOI_SC As New HelpClass_NPOI_SC

            'NPOI = New Ransa.Utilitario.HelpClass_NPOI_SC

            If Me.dtgDatos.Rows.Count = 0 Then Exit Sub

            Dim ListaExcel As New DataTable
            ListaExcel = dtgDatos.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow



            dtExcel.Columns.Add("NORSCI").Caption = NPOI_SC.FormatDato(" INFORMACIÓN GENERAL| Embarque", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PNNMOS").Caption = NPOI_SC.FormatDato(" INFORMACIÓN GENERAL| Orden Servicio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NORCML").Caption = NPOI_SC.FormatDato(" INFORMACIÓN GENERAL| Orden de Compra", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FORCML").Caption = NPOI_SC.FormatDato(" INFORMACIÓN GENERAL| Fecha Puesta Orden", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("TPRVCL").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Proveedor", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TPRSCN").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Contacto (Proveedor)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TTINTC").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Incoterm", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMPPS").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| País de Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TDITES").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Descripción del producto", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TUNDIT").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Unid. Medida", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QCNTIT").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Cantidad Solicitada", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QRLCSC").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Cantidad Embarcada", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QPSOAR").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Peso(Kg)", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("NFCTCM").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Factura Comercial", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("VALORFAC").Caption = NPOI_SC.FormatDato("INFORMACIÓN GENERAL| Valor Factura USD", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FSOLIC").Caption = NPOI_SC.FormatDato(" INFORMACIÓN GENERAL| Fecha Contractual Entrega", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("CKCLPV").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| Fecha Entrega Proveedor", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| Tipo de Transporte", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| Bill of Lading/AWB number", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMPVP").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| Nombre Nave / N° Vuelo", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PAI_ORIGEN").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| País / Puerto de salida", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PAI_DESTINO").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| País / Puerto de llegada", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FAPREV").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| ETD", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("FAPRAR").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| ETA", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("SEGURO_COSTO").Caption = NPOI_SC.FormatDato(" INFORMACIÓN DEL EMBARQUE| Seguro", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TNRODU").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| N° DUA", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FECNUM").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Fecha Numeración", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("IMPUESTOS_USD").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Impuestos USD", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TTRMAL").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Almacén Ingreso", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NOM_ALM").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Nombre Almacén", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FECINSP").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Fecha Inspección", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("NOM_INSPECTOR").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Nombre inspector", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FECLEV").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Fecha Levante", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("FECRCA").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Fecha Retiro", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("ITTCAG_COSTO").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Comisión Agente aduanas", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("NDIASE").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Sobreestadía(Días)", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TRANSPORTE").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Transporte(Hacia Lima-Chincha-Ica)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("MONTACARGAS").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Servicio Montacarga (origen-destino)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("SERV_PERSONAL").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Servicio Personal(carga y descarga)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TDSCRG").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Almacén de entrega", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FECALM").Caption = NPOI_SC.FormatDato(" INFORMACIÓN ADUANAS| Fecha de entrega", NPOI_SC.keyDatoFecha)

            Dim ADVALO As Decimal ' ADVALOREM
            Dim DERESP As Decimal ' DERECHO ESPECIFICO
            Dim SOBTAS As Decimal ' SOBRETASA
            Dim ANTDUM As Decimal ' ANTIDUMPING  
            Dim IMSECO As Decimal ' ISC 
            Dim IGV As Decimal    ' IGV
            Dim IPM As Decimal    ' IPM
            Dim MORA As Decimal   ' MORA
            Dim INTCOM As Decimal ' INTERES COMPENSATORIO 
            Dim TASDES As Decimal ' TASA DE DESPACHOS

            Dim ColName As String = ""
            Dim ListaRepetido As New Hashtable
            For Each item As DataRow In ListaExcel.Rows
                dr = dtExcel.NewRow



                For Each Item1 As DataColumn In ListaExcel.Columns
                    ColName = Item1.ColumnName
                    If dtExcel.Columns(ColName) IsNot Nothing Then
                        dr(Item1.ColumnName) = item(Item1.ColumnName)
                    End If
                Next

                ADVALO = Val(item("ADVALO_COSTO")) ' ADVALOREM
                DERESP = Val(item("DERESP_COSTO")) ' DERECHO ESPECIFICO
                SOBTAS = Val(item("SOBTAS_COSTO")) ' SOBRETASA
                ANTDUM = Val(item("ANTDUM_COSTO")) ' ANTIDUMPING  
                IMSECO = Val(item("IMSECO_COSTO")) ' ISC 
                IGV = Val(item("IGV_COSTO")) ' IGV
                IPM = Val(item("IPM_COSTO")) ' IPM
                MORA = Val(item("MORA_COSTO")) ' MORA
                INTCOM = Val(item("INTCOM_COSTO")) ' INTERES COMPENSATORIO 
                TASDES = Val(item("TASDES_COSTO")) ' TASA DE DESPACHOS
                dr("IMPUESTOS_USD") = ADVALO + DERESP + SOBTAS + ANTDUM + IMSECO + IGV + IPM + MORA + INTCOM + TASDES


                If ListaRepetido.Contains(dr("NORSCI")) Then
                    dr("SEGURO_COSTO") = 0D
                    dr("ITTCAG_COSTO") = 0D
                    dr("IMPUESTOS_USD") = 0D
                Else
                    ListaRepetido.Add(dr("NORSCI"), dr("NORSCI"))
                End If
                dtExcel.Rows.Add(dr)
            Next

            ListaDatatable = New List(Of DataTable)
            dtExcel.TableName = "Importaciones"
            ListaDatatable.Add(dtExcel.Copy)

            ListaTitulos = New List(Of String)
            ListaTitulos.Add("REPORTE DE OPERADOR LOGISTICO")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "Cliente:| " & cmbCliente.pCodigo & " - " & cmbCliente.pRazonSocial)
            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("NORCML")


            Dim ListNameCombDuplicado As New List(Of String)
            Dim CombCol As String
            ''INFORMACIÓN GENERAL
            CombCol = "NORSCI:NORSCI/1|PNNMOS:NORSCI,PNNMOS/1|QPSOAR:NORSCI,QPSOAR/0|NORCML:NORSCI,NORCML/1|FORCML:NORSCI,NORCML,FORCML/0|FSOLIC:NORSCI,NORCML,FSOLIC/0"
            CombCol = CombCol & "|TPRVCL:NORSCI,NORCML,TPRVCL/1|TPRSCN:NORSCI,NORCML,TPRSCN/1|TTINTC:NORSCI,NORCML,TTINTC/1|TCMPPS:NORSCI,TCMPPS/1"
            'INFORMACIÓN DEL EMBARQUE
            CombCol = CombCol & "|CKCLPV:NORSCI,CKCLPV/0|TNMMDT:NORSCI,TNMMDT/0|NDOCEM:NORSCI,NDOCEM/0|TCMPVP:NORSCI,TCMPVP/0"
            CombCol = CombCol & "|PAI_ORIGEN:NORSCI,PAI_ORIGEN/0|PAI_DESTINO:NORSCI,PAI_DESTINO/0|FAPREV:NORSCI,FAPREV/0|FAPRAR:NORSCI,FAPRAR/0"
            CombCol = CombCol & "|SEGURO_COSTO:NORSCI,SEGURO_COSTO/0"

            'INFORMACIÓN ADUANAS
            CombCol = CombCol & "|TNRODU:NORSCI,TNRODU/0|FECNUM:NORSCI,FECNUM/0|IMPUESTOS_USD:NORSCI,IMPUESTOS_USD/0"
            CombCol = CombCol & "|TTRMAL:NORSCI,TTRMAL/0|NOM_ALM:NORSCI,NOM_ALM/0|FECINSP:NORSCI,FECINSP/0|NOM_INSPECTOR:NORSCI,NOM_INSPECTOR/0"
            CombCol = CombCol & "|FECLEV:NORSCI,FECLEV/0|FECRCA:NORSCI,FECRCA/0|ITTCAG_COSTO:NORSCI,ITTCAG_COSTO/0|NDIASE:NORSCI,NDIASE/0|TRANSPORTE:NORSCI,TRANSPORTE/0"
            CombCol = CombCol & "|MONTACARGAS:NORSCI,MONTACARGAS/0|SERV_PERSONAL:NORSCI,SERV_PERSONAL/0|TDSCRG:NORSCI,TDSCRG/0|FECALM:NORSCI,FECALM/0"


        
            ListNameCombDuplicado.Add(CombCol)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, 0, ListNameCombDuplicado)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        dtgDatos.DataSource = Nothing
        dt = New DataTable
        Dim obrEmbarque As New clsEmbarque
        Dim obeFiltroBusquedaItem As New beFiltroBusquedaItem
        obeFiltroBusquedaItem = ListaFiltros()
        dt = obrEmbarque.ListarMercaderiaSeguimiento(obeFiltroBusquedaItem)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Dim NameColumna As String = ""
        Dim NameCaption As String = ""
        Dim Columna As String = ""
        Dim COLUMNAS_CHK As New List(Of String)

        For Each COLUMNAS As DataGridViewColumn In dtgDatos.Columns
            NameColumna = COLUMNAS.Name
            If (NameColumna.EndsWith("_CHK") = True OrElse NameColumna.EndsWith("_COSTO")) Then
                COLUMNAS_CHK.Add(NameColumna)
            End If
        Next
        For Each Item As String In COLUMNAS_CHK
            If (dtgDatos.Columns(Item) IsNot Nothing) Then
                dtgDatos.Columns.Remove(Item)
            End If
        Next

        For Each dc As DataColumn In dt.Columns
            NameColumna = dc.ColumnName
            NameCaption = dc.Caption
            If (NameColumna.EndsWith("_CHK") = True OrElse NameColumna.EndsWith("_COSTO") = True) Then
                If (dtgDatos.Columns(NameColumna) IsNot Nothing) Then
                    dtgDatos.Columns.Remove(NameColumna)
                End If
            End If
        Next
        Dim oDcTx As DataGridViewColumn
        Dim ColName As String

        For Each dc As DataColumn In dt.Columns
            NameColumna = dc.ColumnName
            NameCaption = dc.Caption
            If (NameColumna.EndsWith("_COSTO") = True) Then
                ColName = NameCaption
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = NameColumna
                oDcTx.HeaderText = ColName
                oDcTx.Resizable = DataGridViewTriState.True
                oDcTx.SortMode = DataGridViewColumnSortMode.Automatic
                oDcTx.DataPropertyName = NameColumna
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                oDcTx.ReadOnly = True
                dtgDatos.Columns.Add(oDcTx)
            End If
        Next
        For Each dc As DataColumn In dt.Columns
            NameColumna = dc.ColumnName
            NameCaption = dc.Caption
            If (NameColumna.EndsWith("_CHK") = True) Then
                ColName = NameCaption
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = NameColumna
                oDcTx.HeaderText = ColName & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fecha Real"
                oDcTx.Resizable = DataGridViewTriState.True
                oDcTx.SortMode = DataGridViewColumnSortMode.Automatic
                oDcTx.DataPropertyName = NameColumna
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.ReadOnly = True
                dtgDatos.Columns.Add(oDcTx)
            End If
        Next


        dtgDatos.DataSource = dt
        pbxBuscar.Visible = False
        lblBusqueda.Visible = False
        btnBuscar.Enabled = True

    End Sub
End Class

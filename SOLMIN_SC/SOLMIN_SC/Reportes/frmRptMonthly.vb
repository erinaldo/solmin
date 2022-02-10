Imports SOLMIN_SC.Negocio
Imports System.Collections
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Imports System.Text
Public Class frmRptMonthly
  Dim Filtro As New Hashtable()
    Dim objRep As New CTLReporte_Monthly.rptMonthly
    Private dsTables As New DataSet
    Private Sub frmRptMonthly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            verGrafico(False)
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            CargarFiltroDatos()
            CrearRegimen()
            dtpFecIni.Value = Now.AddMonths(-1)
            'CrearTablaConsulta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  
    Private Sub CargarFiltroDatos()

        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("VALUE")
        dtEstado.Columns.Add("DISPLAY")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("VALUE") = "T"
        dr("DISPLAY") = "::TODOS::"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "A"
        dr("DISPLAY") = "EN ATENCION"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "C"
        dr("DISPLAY") = "CERRADOS"
        dtEstado.Rows.Add(dr)

        cboEstado.DataSource = dtEstado
        cboEstado.ValueMember = "VALUE"
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.SelectedValue = "T"
        cboEstado.Enabled = False



        Dim dtCheckPoint As New DataTable
        dtCheckPoint.Columns.Add("VALUE")
        dtCheckPoint.Columns.Add("DISPLAY")
        Dim drCheck As DataRow
        drCheck = dtCheckPoint.NewRow
        drCheck("VALUE") = "124"
        drCheck("DISPLAY") = "FECHA ENTREGA ALMACEN"
        dtCheckPoint.Rows.Add(drCheck)

        For Each Item As DataRow In dtCheckPoint.Rows
            Item("DISPLAY") = Item("VALUE") & "-" & Item("DISPLAY")
        Next


        cboCheckPoint.DataSource = dtCheckPoint
        cboCheckPoint.ValueMember = "VALUE"
        cboCheckPoint.DisplayMember = "DISPLAY"
        cboCheckPoint.SelectedValue = "124"
        cboCheckPoint.Enabled = False


        Dim oclsEstado As New clsEstado
        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim drTipo As DataRow
        drTipo = dtTipoOperacion.NewRow
        drTipo("COD") = "T"
        drTipo("TEX") = "TODOS"
        dtTipoOperacion.Rows.InsertAt(drTipo, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        'cboTipoOperacion.SelectedValue = "T"
        cboTipoOperacion.SelectedValue = "IM"
        cboTipoOperacion.Enabled = False

    End Sub


  Private Sub CrearRegimen()
    chkRegimen.Items.Clear()
    Dim odtRegimen As New DataTable

    odtRegimen.Columns.Add("NCODRG")
    odtRegimen.Columns.Add("TDSCRG")
        Dim obrRegimen As New clsRegimen
        Dim oListRegimen As New List(Of beRegimen)
        oListRegimen = obrRegimen.ListarRegimen()
     
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
      If chkRegimen.Items.Item(i).Value = "1" OrElse chkRegimen.Items.Item(i).Value = "13" Then
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

  Private Sub Cargar_Compania()
    cmbCompania.Usuario = HelpUtil.UserName
    cmbCompania.CCMPN_CompaniaDefault = "EZ"
    cmbCompania.pActualizar()
  End Sub

  Private Function GetCompania() As String
    Return cmbCompania.CCMPN_CodigoCompania
  End Function
  Private Function GetDivision(ByVal CCMPN As String) As String
    If CCMPN = "EZ" Then
      Return HelpClass.getSetting("DivisionEZ")
    Else
      Return ""
    End If
  End Function


  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Try
        
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim dsReporte As New DataSet

            Dim dtOperacion As New DataTable
            Dim dtFactAduana As New DataTable
            Dim dtAvisoDebito As New DataTable
            Dim dtTiempoEntrega As New DataTable
            Dim dtContenedores As New DataTable

            Dim MdataColumna As String = ""

            MdataColumna = NPOI_SC.FormatDato("REFERENCIA O/C", NPOI_SC.keyDatoTexto)
            dtOperacion.Columns.Add("NORCML").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtOperacion.Columns.Add("PNNMOS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("REGIMEN", NPOI_SC.keyDatoTexto)
            dtOperacion.Columns.Add("REGIMEN").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TIPO DE " & Chr(10) & "DESPACHO", NPOI_SC.keyDatoTexto)
            dtOperacion.Columns.Add("TDSCRG").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("PESO KG", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("QPSOAR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("FOB US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("IVFOBD").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("FLETE US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("VALFLT").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("SEGURO US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("VALSEG").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("CIF US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("IMPCIF").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("ADVALOREM US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("VALADV").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("IGV + IPM US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("IIGVPM").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("OTROS" & Chr(10) & "GASTOS US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("VALOGS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "FOB US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("ITTFOB").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "FLETE US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("IVLFLT").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "SEGURO US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("IVLSGR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "CIF US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("ITTCIF").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "ADVALOREM US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("ITTADV").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "IGV + IPM US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("IGVIPM").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "OTROS GASTOS US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("ITTOGS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL" & Chr(10) & "DERECHOS US$", NPOI_SC.keyDatoNumero)
            dtOperacion.Columns.Add("TOTAL").Caption = MdataColumna
            dtOperacion.TableName = "dtOperacion"
            dsReporte.Tables.Add(dtOperacion.Copy)

            MdataColumna = NPOI_SC.FormatDato("REFERENCIA O/C", NPOI_SC.keyDatoTexto)
            dtFactAduana.Columns.Add("NORCML").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtFactAduana.Columns.Add("NORDSR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("REGIMEN", NPOI_SC.keyDatoTexto)
            dtFactAduana.Columns.Add("REGIMEN").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TIPO" & Chr(10) & "DE DESPACHO", NPOI_SC.keyDatoTexto)
            dtFactAduana.Columns.Add("TDSCRG").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("AVISO DE DEBITO US$", NPOI_SC.keyDatoNumero)
            dtFactAduana.Columns.Add("DEVITO").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("GASTOS VARIOS", NPOI_SC.keyDatoNumero)
            dtFactAduana.Columns.Add("GSTVAR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("COMISION US$", NPOI_SC.keyDatoNumero)
            dtFactAduana.Columns.Add("COMISI").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("OTROS US$", NPOI_SC.keyDatoNumero)
            dtFactAduana.Columns.Add("OTROS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL FACTURA US$", NPOI_SC.keyDatoNumero)
            dtFactAduana.Columns.Add("TOTAL").Caption = MdataColumna

            dtFactAduana.TableName = "dtFactAduana"
            dsReporte.Tables.Add(dtFactAduana)

            MdataColumna = NPOI_SC.FormatDato("REFERENCIA O/C", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("NORCML").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("NORDSR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("REGIMEN", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("REGIMEN").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TIPO DE" & Chr(10) & "DESPACHO", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("TDSCRG").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("COD.", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("CSRVRL").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("SERVICIO", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("TCMTRF").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("MONTO US$", NPOI_SC.keyDatoNumero)
            dtAvisoDebito.Columns.Add("MONTO").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TIPO DOC.", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("TABTPD").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("NRO. DOC.", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("NDCCT1").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("FECHA DOC.", NPOI_SC.keyDatoFecha)
            dtAvisoDebito.Columns.Add("FDCCT1").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("PROVEEDOR", NPOI_SC.keyDatoTexto)
            dtAvisoDebito.Columns.Add("NOMPRO").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TOTAL DEBITO US$", NPOI_SC.keyDatoNumero)
            dtAvisoDebito.Columns.Add("TOTDEB").Caption = MdataColumna
            dtAvisoDebito.TableName = "dtAvisoDebito"
            dsReporte.Tables.Add(dtAvisoDebito)

            MdataColumna = NPOI_SC.FormatDato("REFERENCIA O/C", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("NORCML").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("PNNMOS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("REGIMEN", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("REGIMEN").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TRANSPORTE", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("TNMMDT").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("ORIGEN", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("TCMPPS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("VENDOR", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("TNMAGC").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("VESSEL", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("TCMPVP").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("CANTIDAD", NPOI_SC.keyDatoNumero)
            dtTiempoEntrega.Columns.Add("QCANTI").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TIPO DE CARGA", NPOI_SC.keyDatoTexto)
            dtTiempoEntrega.Columns.Add("TDSCRG").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("PESO KG.", NPOI_SC.keyDatoNumero)
            dtTiempoEntrega.Columns.Add("QPSOAR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("ETA", NPOI_SC.keyDatoFecha)
            dtTiempoEntrega.Columns.Add("FAPRAR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("FACTURA", NPOI_SC.keyDatoFecha)
            dtTiempoEntrega.Columns.Add("FECFAC").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("DOC. EMB.", NPOI_SC.keyDatoFecha)
            dtTiempoEntrega.Columns.Add("FECDOC").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TRADUCCION", NPOI_SC.keyDatoFecha)
            dtTiempoEntrega.Columns.Add("FECTRA").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("DIAS UTILES ANTES" & Chr(10) & "DE ETA-FACTURA", NPOI_SC.keyDatoNumero)
            dtTiempoEntrega.Columns.Add("DIAFAC").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("DIAS UTILES ANTES" & Chr(10) & "DE ETA- DIAS UTILES DOC. EMB.", NPOI_SC.keyDatoNumero)
            dtTiempoEntrega.Columns.Add("DIADOC").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("DIAS UTILES ANTES" & Chr(10) & "DE ETA- TRADUCCION", NPOI_SC.keyDatoNumero)
            dtTiempoEntrega.Columns.Add("DIATRA").Caption = MdataColumna

            dtTiempoEntrega.TableName = "dtTiempoEntrega"
            dsReporte.Tables.Add(dtTiempoEntrega)

            MdataColumna = NPOI_SC.FormatDato("REFERENCIA O/C", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("NORCML").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("PNNMOS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("REGIMEN", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("REGIMEN").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("ORIGEN", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("TCMPPS").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("DOC. EMB.", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("NDOCEM").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("PROVEEDOR", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("TPRCL1").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("NAVE", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("TCMPVP").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("LINEA NAVIERA", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("TNMCIN").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("CANTIDAD", NPOI_SC.keyDatoNumero)
            dtContenedores.Columns.Add("QCANTI").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("TIPO DE CARGA", NPOI_SC.keyDatoTexto)
            dtContenedores.Columns.Add("TDSCRG").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("PESO KG.", NPOI_SC.keyDatoNumero)
            dtContenedores.Columns.Add("QPSOAR").Caption = MdataColumna
            MdataColumna = NPOI_SC.FormatDato("ETA", NPOI_SC.keyDatoFecha)
            dtContenedores.Columns.Add("FAPRAR").Caption = MdataColumna
            dtContenedores.TableName = "dtContenedores"
            dsReporte.Tables.Add(dtContenedores)

            Dim oListDtReport As New List(Of DataTable)
            Dim dtTemp As New DataTable
            dtTemp = CopiarDatosTo(dsTables.Tables("dtOperacion"), dsReporte.Tables("dtOperacion"), True)
            dtTemp.TableName = "Operación Aduanas"
            oListDtReport.Add(dtTemp.Copy)

            dtTemp = CopiarDatosTo(dsTables.Tables("dtFactAduana"), dsReporte.Tables("dtFactAduana"), True)
            dtTemp.TableName = "Facturación Aduanas"
            oListDtReport.Add(dtTemp.Copy)

            dtTemp = CopiarDatosTo(dsTables.Tables("dtAvisoDebito"), dsReporte.Tables("dtAvisoDebito"), True)
            dtTemp.TableName = "Detalle ADD"
            oListDtReport.Add(dtTemp.Copy)

            dtTemp = CopiarDatosTo(dsTables.Tables("dtTiempoEntrega"), dsReporte.Tables("dtTiempoEntrega"), True)
            dtTemp.TableName = "Tiempo Entrega Docs."
            oListDtReport.Add(dtTemp.Copy)


            dtTemp = CopiarDatosTo(dsTables.Tables("dtContenedores"), dsReporte.Tables("dtContenedores"), True)
            dtTemp.TableName = "Contenedores"
            oListDtReport.Add(dtTemp.Copy)

            Dim lstrPeriodo As String = ""
            Dim ListTitulo As New List(Of String)
            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            ListTitulo.Add("OPERACIÓN ADUANAS - " & lstrPeriodo)
            ListTitulo.Add("FACTURACIÓN ADUANAS - " & lstrPeriodo)
            ListTitulo.Add("DETALLE AVISOS DE DÉBITO AGENCIAS RANSA - " & lstrPeriodo)
            ListTitulo.Add(" TIEMPO DE ENTREGA DE DOCUMENTO - " & lstrPeriodo)
            ListTitulo.Add("RELACIÓN CONTENEDORES Y LÍNEAS NAVIERAS - " & lstrPeriodo)

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
            LisFiltros.Add(itemSortedList)

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
            LisFiltros.Add(itemSortedList)

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
            LisFiltros.Add(itemSortedList)

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
            LisFiltros.Add(itemSortedList)

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
            LisFiltros.Add(itemSortedList)

            Dim LisColNFilas As New List(Of String)
            LisColNFilas.Add("NORCML")
            LisColNFilas.Add("NORCML")
            LisColNFilas.Add("NORCML")
            LisColNFilas.Add("NORCML")
            LisColNFilas.Add("NORCML")
            'Dim ListNameCombDuplicado As New List(Of String)
            'ListNameCombDuplicado.Add("NORCML:NORCML/1")
            'ListNameCombDuplicado.Add("NORCML:NORCML/1")
            'ListNameCombDuplicado.Add("NORCML:NORCML/1")
            'ListNameCombDuplicado.Add("NORCML:NORCML/1")
            'ListNameCombDuplicado.Add("NORCML:NORCML/1")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(oListDtReport, ListTitulo, LisColNFilas, LisFiltros, 0, Nothing)

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
    'Private Sub Actualizar_Tabla()
    '  Dim strOC As String = ""
    '  Dim intCont As Integer
    '  Dim strOS As String = ""

    '  For intCont = 0 To oDs.Tables(0).Rows.Count - 1
    '    If strOS = vbNullString Then
    '      strOS = oDs.Tables(0).Rows(intCont).Item("PNNMOS").ToString.Trim
    '      strOC = oDs.Tables(0).Rows(intCont).Item("NORCML").ToString.Trim
    '      If intCont = oDs.Tables(0).Rows.Count - 1 Then
    '        Agregar_Referencia_OC(strOS, strOC)
    '      End If
    '    Else
    '      If strOS = oDs.Tables(0).Rows(intCont).Item("PNNMOS").ToString.Trim Then
    '        strOC = strOC & Chr(10) & oDs.Tables(0).Rows(intCont).Item("NORCML").ToString.Trim
    '        If intCont = oDs.Tables(0).Rows.Count - 1 Then
    '          Agregar_Referencia_OC(strOS, strOC)
    '        End If
    '      Else
    '        Agregar_Referencia_OC(strOS, strOC)
    '        strOC = oDs.Tables(0).Rows(intCont).Item("NORCML").ToString.Trim
    '        strOS = oDs.Tables(0).Rows(intCont).Item("PNNMOS").ToString.Trim
    '        If intCont = oDs.Tables(0).Rows.Count - 1 Then
    '          Agregar_Referencia_OC(strOS, strOC)
    '        End If
    '      End If
    '    End If
    '  Next intCont
    'End Sub

    'Private Sub Agregar_Referencia_OC(ByVal pstrOS As String, ByVal pstrOC As String)
    '  Dim intCont As Integer
    '  Dim intRow As Integer

    '  For intCont = 1 To Me.oDs.Tables.Count - 1
    '    For intRow = 0 To Me.oDs.Tables(intCont).Rows.Count - 1
    '      If Not Me.oDs.Tables(intCont).Columns("NORDSR") Is Nothing Then
    '        If Me.oDs.Tables(intCont).Rows(intRow).Item("NORDSR").ToString.Trim = pstrOS.Trim Then
    '          Me.oDs.Tables(intCont).Rows(intRow).Item("NORCML") = pstrOC
    '        End If
    '      Else
    '        If Me.oDs.Tables(intCont).Rows(intRow).Item("PNNMOS").ToString.Trim = pstrOS.Trim Then
    '          Me.oDs.Tables(intCont).Rows(intRow).Item("NORCML") = pstrOC
    '        End If
    '      End If
    '    Next intRow
    '  Next intCont
    'End Sub




    'Private Sub pExportarExcelNPOIN()
    '    Dim NPOI As New HelpClass_NPOI_SC

    '    Dim dsReporte As New DataSet

    '    Dim dtOperacion As New DataTable
    '    Dim dtFactAduana As New DataTable
    '    Dim dtAvisoDebito As New DataTable
    '    Dim dtTiempoEntrega As New DataTable
    '    Dim dtContenedores As New DataTable


    '    Dim MdataColumna As String = ""


    '    MdataColumna = NPOI.FormatDato("REFERENCIA O/C", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtOperacion.Columns.Add("NORCML").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("O/S", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtOperacion.Columns.Add("PNNMOS").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("REGIMEN", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtOperacion.Columns.Add("REGIMEN").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TIPO DE DESPACHO", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtOperacion.Columns.Add("TDSCRG").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("PESO KG", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("QPSOAR").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("FOB US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("IVFOBD").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("FLETE US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("VALFLT").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("SEGURO US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("VALSEG").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("CIF US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("IMPCIF").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("ADVALOREM US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("VALADV").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("IGV + IPM US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("IIGVPM").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("OTROS GASTOS US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("VALOGS").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL FOB US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("ITTFOB").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL FLETE US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("IVLFLT").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL SEGURO US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("IVLSGR").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL CIF US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("ITTCIF").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL ADVALOREM US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("ITTADV").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL IGV + IPM US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("IGVIPM").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL OTROS GASTOS US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("ITTOGS").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL DERECHOS US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtOperacion.Columns.Add("TOTAL").Caption = MdataColumna
    '    dtOperacion.TableName = "dtOperacion"
    '    dsReporte.Tables.Add(dtOperacion.Copy)

    '    MdataColumna = NPOI.FormatDato("REFERENCIA O/C", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtFactAduana.Columns.Add("NORCML").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("O/S", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtFactAduana.Columns.Add("NORDSR").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("REGIMEN", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtFactAduana.Columns.Add("REGIMEN").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TIPO DE DESPACHO", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtFactAduana.Columns.Add("TDSCRG").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("AVISO DE DEBITO US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtFactAduana.Columns.Add("DEVITO").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("GASTOS VARIOS", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtFactAduana.Columns.Add("GSTVAR").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("COMISION US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtFactAduana.Columns.Add("COMISI").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("OTROS US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtFactAduana.Columns.Add("OTROS").Caption = MdataColumna
    '    dtFactAduana.Columns.Add("TOTAL")

    '    dtFactAduana.TableName = "dtFactAduana"
    '    dsReporte.Tables.Add(dtFactAduana)

    '    MdataColumna = NPOI.FormatDato("REFERENCIA O/C", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("NORCML").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("O/S", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("NORDSR").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("REGIMEN", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("REGIMEN").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TIPO DE DESPACHO", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("TDSCRG").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("COD.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("CSRVRL").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("SERVICIO", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("TCMTRF").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("MONTO US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtAvisoDebito.Columns.Add("MONTO").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TIPO DOC.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("TABTPD").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("NRO. DOC.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("NDCCT1").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("FECHA DOC.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("FDCCT1").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("PROVEEDOR", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtAvisoDebito.Columns.Add("NOMPRO").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TOTAL DEBITO US$", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtAvisoDebito.Columns.Add("TOTDEB")
    '    dtAvisoDebito.TableName = "dtAvisoDebito"
    '    dsReporte.Tables.Add(dtAvisoDebito)

    '    MdataColumna = NPOI.FormatDato("REFERENCIA O/C", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("NORCML").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("O/S", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("PNNMOS").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("REGIMEN", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("REGIMEN").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TRANSPORTE", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("TNMMDT").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("ORIGEN", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("TCMPPS").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("VENDOR", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("TNMAGC").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("VESSEL", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("TCMPVP").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("CANTIDAD", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtTiempoEntrega.Columns.Add("QCANTI").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TIPO DE CARGA", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("TDSCRG").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("PESO KG.", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtTiempoEntrega.Columns.Add("QPSOAR").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("ETA", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("FAPRAR").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("FACTURA", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("FECFAC").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("DOC. EMB.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("FECDOC").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("TRADUCCION", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("FECTRA").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("DIAS UTILES ANTES DE ETA-FACTURA", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("DIAFAC").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("DIAS UTILES ANTES DE ETA- DIAS UTILES DOC. EMB.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("DIADOC").Caption = MdataColumna
    '    MdataColumna = NPOI.FormatDato("DIAS UTILES ANTES DE ETA- TRADUCCION", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtTiempoEntrega.Columns.Add("DIATRA")

    '    dtTiempoEntrega.TableName = "dtTiempoEntrega"
    '    dsReporte.Tables.Add(dtTiempoEntrega)

    '    MdataColumna = NPOI.FormatDato("REFERENCIA O/C", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("NORCML")
    '    MdataColumna = NPOI.FormatDato("O/S", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("PNNMOS")
    '    MdataColumna = NPOI.FormatDato("REGIMEN", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("REGIMEN")
    '    MdataColumna = NPOI.FormatDato("ORIGEN", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("TCMPPS")
    '    MdataColumna = NPOI.FormatDato("DOC. EMB.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("NDOCEM")
    '    MdataColumna = NPOI.FormatDato("PROVEEDOR", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("TPRCL1")
    '    MdataColumna = NPOI.FormatDato("NAVE", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("TCMPVP")
    '    MdataColumna = NPOI.FormatDato("LINEA NAVIERA", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("TNMCIN")
    '    MdataColumna = NPOI.FormatDato("CANTIDAD", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtContenedores.Columns.Add("QCANTI")
    '    MdataColumna = NPOI.FormatDato("TIPO DE CARGA", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("TDSCRG")
    '    MdataColumna = NPOI.FormatDato("PESO KG.", HelpClass_NPOI_SC.keyDatoTexto)
    '    dtContenedores.Columns.Add("QPSOAR")
    '    MdataColumna = NPOI.FormatDato("ETA", HelpClass_NPOI_SC.keyDatoNumero)
    '    dtContenedores.Columns.Add("FAPRAR")
    '    dtContenedores.TableName = "dtContenedores"
    '    dsReporte.Tables.Add(dtContenedores)

    '    Dim oListDtReport As New List(Of DataTable)
    '    Dim dtTemp As New DataTable
    '    dtTemp = CopiarDatosTo(oDs.Tables("dtOperacion"), dsReporte.Tables("dtOperacion"), True)
    '    dtTemp.TableName = "Operación Aduanas"
    '    oListDtReport.Add(dtTemp.Copy)

    '    dtTemp = CopiarDatosTo(oDs.Tables("dtFactAduana"), dsReporte.Tables("dtFactAduana"), True)
    '    dtTemp.TableName = "Facturación Aduanas"
    '    oListDtReport.Add(dtTemp.Copy)

    '    dtTemp = CopiarDatosTo(oDs.Tables("dtAvisoDebito"), dsReporte.Tables("dtAvisoDebito"), True)
    '    dtTemp.TableName = "Detalle ADD"
    '    oListDtReport.Add(dtTemp.Copy)

    '    dtTemp = CopiarDatosTo(oDs.Tables("dtTiempoEntrega"), dsReporte.Tables("dtTiempoEntrega"), True)
    '    dtTemp.TableName = "Tiempo Entrega Docs."
    '    oListDtReport.Add(dtTemp.Copy)


    '    dtTemp = CopiarDatosTo(oDs.Tables("dtContenedores"), dsReporte.Tables("dtContenedores"), True)
    '    dtTemp.TableName = "Contenedores"
    '    oListDtReport.Add(dtTemp.Copy)

    '    Dim lstrPeriodo As String = ""

    '    'Dim Periodo As String = ""
    '    'Dim odtTemp As New DataTable
    '    'Dim oListColDel As New List(Of String)
    '    'Dim ColName As String = ""
    '    'Dim ColCaption As String = ""
    '    'Dim MdataColumna As String = ""
    '    'Dim oSystemType As String
    '    'Dim ListaNumero As New List(Of String)
    '    'ListaNumero.Add("System.Double")
    '    'ListaNumero.Add("System.Int32")
    '    'ListaNumero.Add("System.Int64")
    '    'ListaNumero.Add("System.Decimal")
    '    'Dim TableName As String = ""
    '    'lstrPeriodo = Me.dtpFecIni.Value.ToLongDateString.ToUpper.Split(" ")(3) & " " & Me.dtpFecIni.Value.ToLongDateString.ToUpper.Split(" ")(5)
    '    'For Each odt As DataTable In poDs.Tables
    '    '  odtTemp = odt.Copy
    '    '  oListColDel.Clear()
    '    '  TableName = odtTemp.TableName
    '    '  Select Case TableName
    '    '    Case "dtOperacion"
    '    '    Case "dtFactAduana"
    '    '      For Each Item As DataRow In odtTemp.Rows
    '    '        Item("NORCML") = Item("NORCML_1")
    '    '      Next
    '    '      If odtTemp.Columns("NORCML_1") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("NORCML_1")
    '    '      End If
    '    '    Case "dtAvisoDebito"
    '    '      For Each Item As DataRow In odtTemp.Rows
    '    '        Item("NORCML") = Item("NORCML_1")
    '    '      Next
    '    '      If odtTemp.Columns("NORCML_1") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("NORCML_1")
    '    '      End If
    '    '      If odtTemp.Columns("TOTCO") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("TOTCO")
    '    '      End If
    '    '      If odtTemp.Columns("IND_CO") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("IND_CO")
    '    '      End If
    '    '      If odtTemp.Columns("CHECK_CO") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("CHECK_CO")
    '    '      End If

    '    '    Case "dtTiempoEntrega"
    '    '      For Each Item As DataRow In odtTemp.Rows
    '    '        Item("NORCML") = Item("NORCML_1")
    '    '      Next

    '    '      If odtTemp.Columns("NORSCI") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("NORSCI")
    '    '      End If

    '    '      If odtTemp.Columns("CZNFCC") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("CZNFCC")
    '    '      End If

    '    '      If odtTemp.Columns("CPLNDV") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("CPLNDV")
    '    '      End If
    '    '      If odtTemp.Columns("NORCML_1") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("NORCML_1")
    '    '      End If
    '    '      If odtTemp.Columns("TPSRVA") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("TPSRVA")
    '    '      End If
    '    '      If odtTemp.Columns("ETA") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("ETA")
    '    '      End If
    '    '    Case "dtContenedores"
    '    '      For Each Item As DataRow In odtTemp.Rows
    '    '        Item("NORCML") = Item("NORCML_1")
    '    '      Next
    '    '      If odtTemp.Columns("NORCML_1") IsNot Nothing Then
    '    '        odtTemp.Columns.Remove("NORCML_1")
    '    '      End If
    '    '  End Select

    '    'For Columna As Integer = 0 To odtTemp.Columns.Count - 1
    '    '    ColName = odtTemp.Columns(Columna).ColumnName
    '    '    ColCaption = odtTemp.Columns(Columna).Caption
    '    '    If (ColCaption = "") Then
    '    '        oListColDel.Add(ColName)
    '    '    Else
    '    '        oSystemType = odtTemp.Columns(Columna).DataType.FullName
    '    '        If (ListaNumero.Contains(oSystemType)) Then
    '    '            MdataColumna = NPOI.FormatDato(ColCaption, HelpClass_NPOI_SC.keyDatoNumero)
    '    '            odtTemp.Columns(Columna).Caption = MdataColumna
    '    '        Else
    '    '            MdataColumna = NPOI.FormatDato(ColCaption, HelpClass_NPOI_SC.keyDatoTexto)
    '    '            odtTemp.Columns(Columna).Caption = MdataColumna
    '    '        End If
    '    '    End If
    '    'Next
    '    'For Each Item As String In oListColDel
    '    '    odtTemp.Columns.Remove(Item)
    '    'Next
    '    'oListDtReport.Add(odtTemp)
    '    'Next

    '    'oListDtReport(0).TableName = "Operación Aduanas"
    '    'oListDtReport(1).TableName = "Facturación Aduanas"
    '    'oListDtReport(2).TableName = "Detalle ADD"
    '    'oListDtReport(3).TableName = "Tiempo Entrega Docs."
    '    'oListDtReport(4).TableName = "Contenedores"


    '    Dim ListTitulo As New List(Of String)
    '    Dim LisFiltros As New List(Of SortedList)
    '    Dim itemSortedList As SortedList
    '    ListTitulo.Add("OPERACIÓN ADUANAS - " & lstrPeriodo)
    '    ListTitulo.Add("FACTURACIÓN ADUANAS - " & lstrPeriodo)
    '    ListTitulo.Add("DETALLE AVISOS DE DÉBITO AGENCIAS RANSA - " & lstrPeriodo)
    '    ListTitulo.Add(" TIEMPO DE ENTREGA DE DOCUMENTO - " & lstrPeriodo)
    '    ListTitulo.Add("RELACIÓN CONTENEDORES Y LÍNEAS NAVIERAS - " & lstrPeriodo)

    '    itemSortedList = New SortedList
    '    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
    '    itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
    '    LisFiltros.Add(itemSortedList)

    '    itemSortedList = New SortedList
    '    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
    '    itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
    '    LisFiltros.Add(itemSortedList)

    '    itemSortedList = New SortedList
    '    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
    '    itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
    '    LisFiltros.Add(itemSortedList)

    '    itemSortedList = New SortedList
    '    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
    '    itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
    '    LisFiltros.Add(itemSortedList)

    '    itemSortedList = New SortedList
    '    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
    '    itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Date.Today.ToString("dd/MM/yyyy"))
    '    LisFiltros.Add(itemSortedList)

    '    ' NPOI.ExportExcelReportMonthly(oListDtReport, cmbCliente.pRazonSocial, lstrPeriodo)
    '    NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing)
    'End Sub


    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            VisorRep.ReportSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            VisorRep.ReportSource = Nothing
            If cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Debe seleccionar un Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            verGrafico(True)
            CargarFiltro()
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
        Filtro.Add("Inicio", Format(Me.dtpFecIni.Value, "dd/MM/yyyy"))
        Filtro.Add("Fin", Format(Me.dtpFecFin.Value, "dd/MM/yyyy"))
        Filtro.Add("CCMPN", GetCompania())
        Filtro.Add("ListaRegimen", ListaRegimenSeleccionado())
        Filtro.Add("TipoOperacion", cboTipoOperacion.SelectedValue)
        Filtro.Add("Cod_Cliente", Me.cmbCliente.pCodigo)
        Filtro.Add("PNNESTDO", cboCheckPoint.SelectedValue)
        Filtro.Add("PSESTADO_EMB", cboEstado.SelectedValue)


    End Sub

    'Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork

    '  Dim dblFecIni, dblFecFin, Cod_Cliente As Double

    '  dblFecIni = Filtro("FecIni")
    '  dblFecFin = Filtro("FecFin")
    '  Cod_Cliente = Filtro("Cod_Cliente")
    '  Dim CCMPN As String = Filtro("CCMPN")
    '  Dim objDs As New DataSet
    '      Dim objDt As DataTable
    '      Dim PNNESTDO As Decimal = 0
    '      Dim PSESTADO_EMB As String = ""
    '  objRep = New CTLReporte_Monthly.rptMonthly
    '      Dim objMonthly As New clsRepMonthly
    '  Dim lstrPeriodo As String
    '  Dim inicio As String = Filtro("Inicio")
    '  Dim fin As String = Filtro("Fin")
    '  lstrPeriodo = inicio & " al " & fin
    '  Dim ListaRegimen As String = Filtro("ListaRegimen")
    '      Dim TipoOperacion As String = Filtro("TipoOperacion")
    '      PNNESTDO = Filtro("PNNESTDO")
    '      PSESTADO_EMB = Filtro("PSESTADO_EMB")
    '      ' objDt = objMonthly.dtRepMonthlyOperaciones(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)

    '      objDt = objMonthly.dtRepMonthlyOperaciones(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)

    '  objDt.TableName = "dtOperacion"
    '  objDs.Tables.Add(objDt.Copy)
    '  oDs.Tables("dtOperacion").Rows.Clear()
    '  oDs.Tables("dtOperacion").Load(objDt.CreateDataReader)

    '  oDs.Tables("dtOperacion").Columns.Remove("NORSCI")
    '  oDs.Tables("dtOperacion").Columns.Remove("VALTOT")
    '  oDs.Tables("dtOperacion").Columns.Remove("IVLEXW")
    '  oDs.Tables("dtOperacion").Columns.Remove("IVGFOB")

    '  objRep.Subreports("rptMonthly_SC_OP.rpt").SetDataSource(objDs.Copy)
    '  CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
    '  CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtAnticipado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0

    '  objDt = New DataTable
    '  objDs = New DataSet
    '  objDt = objMonthly.dtRepMonthlyFacturacion(Cod_Cliente, dblFecIni, dblFecFin)
    '  objDt.TableName = "dtFactAduana"
    '  objDs.Tables.Add(objDt.Copy)
    '  oDs.Tables("dtFactAduana").Rows.Clear()
    '  oDs.Tables("dtFactAduana").Load(objDt.CreateDataReader)
    '  objRep.Subreports("rptMonthly_SC_FA.rpt").SetDataSource(objDs.Copy)

    '  objDt = New DataTable
    '  objDs = New DataSet
    '  objDt = objMonthly.dtRepMonthlyDetalleDebito(Cod_Cliente, dblFecIni, dblFecFin)
    '  objDt.TableName = "dtAvisoDebito"
    '  objDs.Tables.Add(objDt.Copy)
    '  oDs.Tables("dtAvisoDebito").Rows.Clear()
    '  oDs.Tables("dtAvisoDebito").Load(objDt.CreateDataReader)
    '  objRep.Subreports("rptMonthly_SC_AD.rpt").SetDataSource(objDs.Copy)

    '  objDt = New DataTable
    '  objDs = New DataSet
    '      objDt = objMonthly.dtRepMonthlyContenedores(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '  objDt.TableName = "dtContenedores"
    '  objDs.Tables.Add(objDt.Copy)
    '  oDs.Tables("dtContenedores").Rows.Clear()
    '  oDs.Tables("dtContenedores").Load(objDt.CreateDataReader)

    '  objRep.Subreports("rptMonthly_SC_CN.rpt").SetDataSource(objDs.Copy)

    '  objDt = New DataTable
    '  objDs = New DataSet
    '      objDt = objMonthly.dtRepMonthlyNavieras(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '  objDt.TableName = "dtNavieras"
    '  objDs.Tables.Add(objDt.Copy)
    '  objRep.Subreports("rptMonthly_SC_NA.rpt").SetDataSource(objDs.Copy)

    '  objDt = New DataTable
    '  objDs = New DataSet
    '      objDt = objMonthly.dtRepMonthlyTiempoEntrega(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '  objDt.TableName = "dtTiempoEntrega"
    '  objDs.Tables.Add(objDt.Copy)
    '  oDs.Tables("dtTiempoEntrega").Rows.Clear()
    '  oDs.Tables("dtTiempoEntrega").Load(objDt.CreateDataReader)

    '  objRep.Subreports("rptMonthly_SC_TE.rpt").SetDataSource(objDs.Copy)

    '      objMonthly.RepMonthlyTiempoAduanas(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '  CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Normal)
    '  CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromAnticipa"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Anticipado)


    '  CType(objRep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cmbCliente.pRazonSocial.Trim
    '  CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & " - " & lstrPeriodo

    'End Sub

    'Private Sub CrearTablaConsulta()

    '    Dim dtOperacion As New DataTable
    '    Dim dtFactAduana As New DataTable
    '    Dim dtAvisoDebito As New DataTable
    '    Dim dtTiempoEntrega As New DataTable
    '    Dim dtContenedores As New DataTable

    '    dtOperacion.Columns.Add("NORCML")
    '    dtOperacion.Columns.Add("PNNMOS")
    '    dtOperacion.Columns.Add("REGIMEN")
    '    dtOperacion.Columns.Add("TDSCRG")
    '    dtOperacion.Columns.Add("QPSOAR", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("IVFOBD", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("VALFLT", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("VALSEG", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("IMPCIF", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("VALADV", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("IIGVPM", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("VALOGS", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("ITTFOB", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("IVLFLT", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("IVLSGR", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("ITTCIF", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("ITTADV", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("IGVIPM", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("ITTOGS", Type.GetType("System.Double"))
    '    dtOperacion.Columns.Add("TOTAL", Type.GetType("System.Double"))
    '    dtOperacion.TableName = "dtOperacion"
    '    dsTables.Tables.Add(dtOperacion.Copy)

    '    dtFactAduana.Columns.Add("NORCML")
    '    dtFactAduana.Columns.Add("NORDSR")
    '    dtFactAduana.Columns.Add("REGIMEN")
    '    dtFactAduana.Columns.Add("TDSCRG")
    '    dtFactAduana.Columns.Add("DEVITO", Type.GetType("System.Double"))
    '    dtFactAduana.Columns.Add("GSTVAR", Type.GetType("System.Double"))
    '    dtFactAduana.Columns.Add("COMISI", Type.GetType("System.Double"))
    '    dtFactAduana.Columns.Add("OTROS", Type.GetType("System.Double"))
    '    dtFactAduana.Columns.Add("TOTAL", Type.GetType("System.Double"))
    '    dtFactAduana.TableName = "dtFactAduana"
    '    dsTables.Tables.Add(dtFactAduana)

    '    dtAvisoDebito.Columns.Add("NORCML")
    '    dtAvisoDebito.Columns.Add("NORDSR")
    '    dtAvisoDebito.Columns.Add("REGIMEN")
    '    dtAvisoDebito.Columns.Add("TDSCRG")
    '    dtAvisoDebito.Columns.Add("CSRVRL")
    '    dtAvisoDebito.Columns.Add("TCMTRF")
    '    dtAvisoDebito.Columns.Add("MONTO", Type.GetType("System.Double"))
    '    dtAvisoDebito.Columns.Add("TABTPD")
    '    dtAvisoDebito.Columns.Add("NDCCT1")
    '    dtAvisoDebito.Columns.Add("FDCCT1")
    '    dtAvisoDebito.Columns.Add("NOMPRO")
    '    dtAvisoDebito.Columns.Add("TOTDEB", Type.GetType("System.Double"))
    '    dtAvisoDebito.TableName = "dtAvisoDebito"
    '    dsTables.Tables.Add(dtAvisoDebito)

    '    dtTiempoEntrega.Columns.Add("NORCML")
    '    dtTiempoEntrega.Columns.Add("PNNMOS")
    '    dtTiempoEntrega.Columns.Add("REGIMEN")
    '    dtTiempoEntrega.Columns.Add("TNMMDT")
    '    dtTiempoEntrega.Columns.Add("TCMPPS")
    '    dtTiempoEntrega.Columns.Add("TNMAGC")
    '    dtTiempoEntrega.Columns.Add("TCMPVP")
    '    dtTiempoEntrega.Columns.Add("QCANTI", Type.GetType("System.Double"))
    '    dtTiempoEntrega.Columns.Add("TDSCRG")
    '    dtTiempoEntrega.Columns.Add("QPSOAR", Type.GetType("System.Double"))
    '    dtTiempoEntrega.Columns.Add("FAPRAR")
    '    dtTiempoEntrega.Columns.Add("FECFAC")
    '    dtTiempoEntrega.Columns.Add("FECDOC")
    '    dtTiempoEntrega.Columns.Add("FECTRA")
    '    dtTiempoEntrega.Columns.Add("DIAFAC")
    '    dtTiempoEntrega.Columns.Add("DIADOC")
    '    dtTiempoEntrega.Columns.Add("DIATRA")
    '    dtTiempoEntrega.TableName = "dtTiempoEntrega"
    '    dsTables.Tables.Add(dtTiempoEntrega)

    '    dtContenedores.Columns.Add("NORCML")
    '    dtContenedores.Columns.Add("PNNMOS")
    '    dtContenedores.Columns.Add("REGIMEN")
    '    dtContenedores.Columns.Add("TCMPPS")
    '    dtContenedores.Columns.Add("NDOCEM")
    '    dtContenedores.Columns.Add("TPRCL1")
    '    dtContenedores.Columns.Add("TCMPVP")
    '    dtContenedores.Columns.Add("TNMCIN")
    '    dtContenedores.Columns.Add("QCANTI", Type.GetType("System.Double"))
    '    dtContenedores.Columns.Add("TDSCRG")
    '    dtContenedores.Columns.Add("QPSOAR", Type.GetType("System.Double"))
    '    dtContenedores.Columns.Add("FAPRAR")
    '    dtContenedores.TableName = "dtContenedores"
    '    dsTables.Tables.Add(dtContenedores)

    'End Sub

    Private Function CopiarDatosTo(ByVal dtOrigen As DataTable, ByRef dtDestino As DataTable, ByVal FormatOC As Boolean, Optional ByVal numOC As Integer = 5) As DataTable
        dtDestino.Rows.Clear()
        Dim NameColumna As String = ""
        Dim dr As DataRow
        For Fila As Integer = 0 To dtOrigen.Rows.Count - 1
            dr = dtDestino.NewRow
            For Columna As Integer = 0 To dtDestino.Columns.Count - 1
                NameColumna = dtDestino.Columns(Columna).ColumnName
                If dtOrigen.Columns(NameColumna) IsNot Nothing Then
                    dr(NameColumna) = dtOrigen.Rows(Fila)(NameColumna)
                    If FormatOC = True AndAlso NameColumna = "NORCML" Then
                        dr(NameColumna) = FormatoOC(("" & dtOrigen.Rows(Fila)(NameColumna)).ToString.Trim, numOC)
                    End If
                End If
            Next
            dtDestino.Rows.Add(dr)
        Next
        Return dtDestino.Copy
    End Function

    Private Function FormatoOC(ByVal OC As String, ByVal numOCFila As Int32) As String
        Dim norcml As String = ""
        Dim cadOC() As String
        cadOC = OC.Split(",")
        Dim sbNorcml As New System.Text.StringBuilder
        Dim strNorcmlFormat As String = ""
        Dim x As Int32 = 1
        For FILA As Integer = 0 To cadOC.Length - 1
            If x <= numOCFila Then
                sbNorcml.Append(cadOC(FILA))
                sbNorcml.Append(",")
            Else
                sbNorcml.Append(Chr(10))
                ' sbNorcml.Append(",")
                sbNorcml.Append(cadOC(FILA))
                x = 0
                If x = 0 Then
                    sbNorcml.Append(",")
                End If
            End If
            x = x + 1
        Next
        strNorcmlFormat = sbNorcml.ToString.Trim
        Dim a As String = ""
        strNorcmlFormat = strNorcmlFormat.Substring(0, strNorcmlFormat.LastIndexOf(","))
        Return strNorcmlFormat
    End Function


    'Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork

    '    Dim dblFecIni, dblFecFin, Cod_Cliente As Double
    '    Dim dtTemp As New DataTable

    '    dblFecIni = Filtro("FecIni")
    '    dblFecFin = Filtro("FecFin")
    '    Cod_Cliente = Filtro("Cod_Cliente")
    '    Dim CCMPN As String = Filtro("CCMPN")
    '    Dim objDs As New DataSet
    '    Dim objDt As DataTable
    '    Dim PNNESTDO As Decimal = 0
    '    Dim PSESTADO_EMB As String = ""
    '    objRep = New CTLReporte_Monthly.rptMonthly
    '    Dim objMonthly As New clsRepMonthly
    '    Dim lstrPeriodo As String
    '    Dim inicio As String = Filtro("Inicio")
    '    Dim fin As String = Filtro("Fin")
    '    lstrPeriodo = inicio & " al " & fin
    '    Dim ListaRegimen As String = Filtro("ListaRegimen")
    '    Dim TipoOperacion As String = Filtro("TipoOperacion")
    '    PNNESTDO = Filtro("PNNESTDO")
    '    PSESTADO_EMB = Filtro("PSESTADO_EMB")

    '    Dim dsReportMonthly As New DataSet

    '    Dim dtOperacion As New DataTable
    '    Dim dtContenedor As New DataTable
    '    Dim dtNaviera As New DataTable
    '    Dim dtOrdenCompra As New DataTable
    '    Dim dtTiempoEntrega As New DataTable
    '    Dim dtFechaDocumento As New DataTable
    '    Dim dtFechaAduana As New DataTable
    '    Dim dtCheckAduana As New DataTable
    '    Dim dtFeriados As New DataTable
    '    Dim dtOrdenesEmbarcados As New DataTable
    '    dsReportMonthly = objMonthly.RepMonthlyAduanas(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '    dtOperacion = dsReportMonthly.Tables("DTOPERACION").Copy
    '    dtContenedor = dsReportMonthly.Tables("DTCONTENEDOR").Copy
    '    dtOrdenCompra = dsReportMonthly.Tables("DTORDENCOMPRA").Copy
    '    dtNaviera = dsReportMonthly.Tables("DTNAVIERRA").Copy
    '    dtTiempoEntrega = dsReportMonthly.Tables("DTTIEMPOENTREGA").Copy
    '    dtFechaDocumento = dsReportMonthly.Tables("DTFECHADOCUMENTOS").Copy
    '    dtFechaAduana = dsReportMonthly.Tables("DTTFECHAADUANA").Copy
    '    dtCheckAduana = dsReportMonthly.Tables("DTCHECKADUANA").Copy
    '    dtFeriados = dsReportMonthly.Tables("DTFERIADO").Copy
    '    dtOrdenesEmbarcados = dsReportMonthly.Tables("DTORDENEMBARCADO").Copy

    '    ' objDt = dtOperacion.Copy
    '    objDt = objMonthly.dtRepMonthlyOperacionesUnificado(dtOperacion.Copy, dtOrdenCompra, dtOrdenesEmbarcados)

    '    dtTemp = CopiarDatosTo(objDt, dsTables.Tables("dtOperacion"))
    '    dtTemp.TableName = "dtOperacion"


    '    objDt.TableName = "dtOperacion"
    '    objDs.Tables.Add(objDt.Copy)
    '    oDs.Tables("dtOperacion").Rows.Clear()
    '    oDs.Tables("dtOperacion").Load(objDt.CreateDataReader)

    '    oDs.Tables("dtOperacion").Columns.Remove("NORSCI")
    '    oDs.Tables("dtOperacion").Columns.Remove("VALTOT")
    '    oDs.Tables("dtOperacion").Columns.Remove("IVLEXW")
    '    oDs.Tables("dtOperacion").Columns.Remove("IVGFOB")

    '    objRep.Subreports("rptMonthly_SC_OP.rpt").SetDataSource(objDs.Copy)
    '    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
    '    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtAnticipado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0

    '    objDt = New DataTable
    '    objDs = New DataSet
    '    objDt = objMonthly.dtRepMonthlyFacturacion(Cod_Cliente, dblFecIni, dblFecFin)
    '    objDt.TableName = "dtFactAduana"
    '    objDs.Tables.Add(objDt.Copy)
    '    oDs.Tables("dtFactAduana").Rows.Clear()
    '    oDs.Tables("dtFactAduana").Load(objDt.CreateDataReader)
    '    objRep.Subreports("rptMonthly_SC_FA.rpt").SetDataSource(objDs.Copy)

    '    objDt = New DataTable
    '    objDs = New DataSet
    '    objDt = objMonthly.dtRepMonthlyDetalleDebito(Cod_Cliente, dblFecIni, dblFecFin)
    '    objDt.TableName = "dtAvisoDebito"
    '    objDs.Tables.Add(objDt.Copy)
    '    oDs.Tables("dtAvisoDebito").Rows.Clear()
    '    oDs.Tables("dtAvisoDebito").Load(objDt.CreateDataReader)
    '    objRep.Subreports("rptMonthly_SC_AD.rpt").SetDataSource(objDs.Copy)

    '    objDt = New DataTable
    '    objDs = New DataSet
    '    'objDt = objMonthly.dtRepMonthlyContenedores(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '    objDt = objMonthly.dtRepMonthlyContenedoresUnificado(dtContenedor, dtOrdenCompra)
    '    objDt.TableName = "dtContenedores"
    '    objDs.Tables.Add(objDt.Copy)
    '    oDs.Tables("dtContenedores").Rows.Clear()
    '    oDs.Tables("dtContenedores").Load(objDt.CreateDataReader)

    '    objRep.Subreports("rptMonthly_SC_CN.rpt").SetDataSource(objDs.Copy)

    '    objDt = New DataTable
    '    objDs = New DataSet
    '    'objDt = objMonthly.dtRepMonthlyNavieras(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '    objDt = objMonthly.dtRepMonthlyNavierasUnificado(dtNaviera)

    '    objDt.TableName = "dtNavieras"
    '    objDs.Tables.Add(objDt.Copy)
    '    objRep.Subreports("rptMonthly_SC_NA.rpt").SetDataSource(objDs.Copy)

    '    objDt = New DataTable
    '    objDs = New DataSet
    '    'objDt = objMonthly.dtRepMonthlyTiempoEntrega(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '    objDt = objMonthly.dtRepMonthlyTiempoEntregaUnificado(dtTiempoEntrega, dtFechaDocumento, dtOrdenCompra, dtFeriados)
    '    objDt.TableName = "dtTiempoEntrega"
    '    objDs.Tables.Add(objDt.Copy)
    '    oDs.Tables("dtTiempoEntrega").Rows.Clear()
    '    oDs.Tables("dtTiempoEntrega").Load(objDt.CreateDataReader)

    '    objRep.Subreports("rptMonthly_SC_TE.rpt").SetDataSource(objDs.Copy)

    '    'objMonthly.RepMonthlyTiempoAduanas(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
    '    objMonthly.RepMonthlyTiempoAduanasUnificado(dtFechaAduana, dtOrdenCompra, dtCheckAduana)
    '    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Normal)
    '    CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromAnticipa"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Anticipado)


    '    CType(objRep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cmbCliente.pRazonSocial.Trim
    '    CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & " - " & lstrPeriodo

    'End Sub

    Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork
        dsTables.Tables.Clear()
        Dim dblFecIni, dblFecFin, Cod_Cliente As Double
        'Dim dtTemp As New DataTable

        dblFecIni = Filtro("FecIni")
        dblFecFin = Filtro("FecFin")
        Cod_Cliente = Filtro("Cod_Cliente")
        Dim CCMPN As String = Filtro("CCMPN")
        Dim objDs As New DataSet
        Dim objDt As DataTable
        Dim PNNESTDO As Decimal = 0
        Dim PSESTADO_EMB As String = ""
        objRep = New CTLReporte_Monthly.rptMonthly
        Dim objMonthly As New clsRepMonthly
        Dim lstrPeriodo As String
        Dim inicio As String = Filtro("Inicio")
        Dim fin As String = Filtro("Fin")
        lstrPeriodo = inicio & " al " & fin
        Dim ListaRegimen As String = Filtro("ListaRegimen")
        Dim TipoOperacion As String = Filtro("TipoOperacion")
        PNNESTDO = Filtro("PNNESTDO")
        PSESTADO_EMB = Filtro("PSESTADO_EMB")

        Dim dsReportMonthly As New DataSet

        Dim dtOperacion As New DataTable
        Dim dtContenedor As New DataTable
        Dim dtNaviera As New DataTable
        Dim dtOrdenCompra As New DataTable
        Dim dtTiempoEntrega As New DataTable
        Dim dtFechaDocumento As New DataTable
        Dim dtFechaAduana As New DataTable
        Dim dtCheckAduana As New DataTable
        Dim dtFeriados As New DataTable
        Dim dtOrdenesEmbarcados As New DataTable
        dsReportMonthly = objMonthly.RepMonthlyAduanas(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
        dtOperacion = dsReportMonthly.Tables("DTOPERACION").Copy
        dtContenedor = dsReportMonthly.Tables("DTCONTENEDOR").Copy
        dtOrdenCompra = dsReportMonthly.Tables("DTORDENCOMPRA").Copy
        dtNaviera = dsReportMonthly.Tables("DTNAVIERRA").Copy
        dtTiempoEntrega = dsReportMonthly.Tables("DTTIEMPOENTREGA").Copy
        dtFechaDocumento = dsReportMonthly.Tables("DTFECHADOCUMENTOS").Copy
        dtFechaAduana = dsReportMonthly.Tables("DTTFECHAADUANA").Copy
        dtCheckAduana = dsReportMonthly.Tables("DTCHECKADUANA").Copy
        dtFeriados = dsReportMonthly.Tables("DTFERIADO").Copy
        dtOrdenesEmbarcados = dsReportMonthly.Tables("DTORDENEMBARCADO").Copy

        ' objDt = dtOperacion.Copy
        objDt = objMonthly.dtRepMonthlyOperacionesUnificado(dtOperacion.Copy, dtOrdenCompra, dtOrdenesEmbarcados)
        'dtTemp = New DataTable
        'dtTemp = CopiarDatosTo(objDt, dsTables.Tables("dtOperacion"))
        objDt.TableName = "dtOperacion"
        dsTables.Tables.Add(objDt.Copy)

        'objDt.TableName = "dtOperacion"
        'objDs.Tables.Add(objDt.Copy)
        'oDs.Tables("dtOperacion").Rows.Clear()
        'oDs.Tables("dtOperacion").Load(objDt.CreateDataReader)

        'oDs.Tables("dtOperacion").Columns.Remove("NORSCI")
        'oDs.Tables("dtOperacion").Columns.Remove("VALTOT")
        'oDs.Tables("dtOperacion").Columns.Remove("IVLEXW")
        'oDs.Tables("dtOperacion").Columns.Remove("IVGFOB")

        objRep.Subreports("rptMonthly_SC_OP.rpt").SetDataSource(objDt.Copy)
        CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0
        CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtAnticipado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = 0

        objDt = New DataTable
        'objDs = New DataSet
        objDt = objMonthly.dtRepMonthlyFacturacion(Cod_Cliente, dblFecIni, dblFecFin)
        'dtTemp = New DataTable
        'dtTemp = CopiarDatosTo(objDt, dsTables.Tables("dtFactAduana"))
        objDt.TableName = "dtFactAduana"
        dsTables.Tables.Add(objDt.Copy)
        'objDt.TableName = "dtFactAduana"
        'objDs.Tables.Add(objDt.Copy)
        'oDs.Tables("dtFactAduana").Rows.Clear()
        'oDs.Tables("dtFactAduana").Load(objDt.CreateDataReader)
        objRep.Subreports("rptMonthly_SC_FA.rpt").SetDataSource(objDt.Copy)

        objDt = New DataTable
        'objDs = New DataSet
        objDt = objMonthly.dtRepMonthlyDetalleDebito(Cod_Cliente, dblFecIni, dblFecFin)
        'dtTemp = New DataTable
        'dtTemp = CopiarDatosTo(objDt, dsTables.Tables("dtAvisoDebito"))
        objDt.TableName = "dtAvisoDebito"
        dsTables.Tables.Add(objDt.Copy)
        'objDt.TableName = "dtAvisoDebito"
        'objDs.Tables.Add(objDt.Copy)
        'oDs.Tables("dtAvisoDebito").Rows.Clear()
        'oDs.Tables("dtAvisoDebito").Load(objDt.CreateDataReader)
        objRep.Subreports("rptMonthly_SC_AD.rpt").SetDataSource(objDt.Copy)

        objDt = New DataTable
        'objDs = New DataSet
        'objDt = objMonthly.dtRepMonthlyContenedores(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
        objDt = objMonthly.dtRepMonthlyContenedoresUnificado(dtContenedor, dtOrdenCompra)
        objDt.TableName = "dtContenedores"
        dsTables.Tables.Add(objDt.Copy)

        'dtTemp = New DataTable
        'dtTemp = CopiarDatosTo(objDt, dsTables.Tables("dtContenedores"))
        'dtTemp.TableName = "dtContenedores"

        'objDt.TableName = "dtContenedores"
        'objDs.Tables.Add(objDt.Copy)
        'oDs.Tables("dtContenedores").Rows.Clear()
        'oDs.Tables("dtContenedores").Load(objDt.CreateDataReader)

        objRep.Subreports("rptMonthly_SC_CN.rpt").SetDataSource(objDt.Copy)

        objDt = New DataTable
        'objDs = New DataSet
        'objDt = objMonthly.dtRepMonthlyNavieras(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
        objDt = objMonthly.dtRepMonthlyNavierasUnificado(dtNaviera)

        ' dtTemp = New DataTable
        '   dtTemp = CopiarDatosTo(objDt, dsTables.Tables("dtNavieras"))
        objDt.TableName = "dtNavieras"

        'objDt.TableName = "dtNavieras"
        'objDs.Tables.Add(objDt.Copy)
        objRep.Subreports("rptMonthly_SC_NA.rpt").SetDataSource(objDt.Copy)

        objDt = New DataTable
        'objDs = New DataSet
        'objDt = objMonthly.dtRepMonthlyTiempoEntrega(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
        objDt = objMonthly.dtRepMonthlyTiempoEntregaUnificado(dtTiempoEntrega, dtFechaDocumento, dtOrdenCompra, dtFeriados)

        'dtTemp = New DataTable
        'dtTemp = CopiarDatosTo(objDt, dsTables.Tables("dtTiempoEntrega"))
        'dtTemp.TableName = "dtTiempoEntrega"


        objDt.TableName = "dtTiempoEntrega"
        dsTables.Tables.Add(objDt.Copy)
        'objDs.Tables.Add(objDt.Copy)
        'oDs.Tables("dtTiempoEntrega").Rows.Clear()
        'oDs.Tables("dtTiempoEntrega").Load(objDt.CreateDataReader)

        objRep.Subreports("rptMonthly_SC_TE.rpt").SetDataSource(objDt.Copy)

        'objMonthly.RepMonthlyTiempoAduanas(CCMPN, Cod_Cliente, dblFecIni, dblFecFin, ListaRegimen, TipoOperacion, PNNESTDO, PSESTADO_EMB)
        objMonthly.RepMonthlyTiempoAduanasUnificado(dtFechaAduana, dtOrdenCompra, dtCheckAduana)
        CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromNormal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Normal)
        CType(objRep.Subreports("rptMonthly_SC_OP.rpt").ReportDefinition.ReportObjects("txtPromAnticipa"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CInt(objMonthly.Promedio_Anticipado)


        CType(objRep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cmbCliente.pRazonSocial.Trim
        CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = CType(objRep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text & " - " & lstrPeriodo

    End Sub

  Private Sub bgwProcesoReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcesoReport.RunWorkerCompleted
    Try
      VisorRep.ReportSource = objRep
      verGrafico(False)
    Catch ex As Exception
      verGrafico(False)
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class

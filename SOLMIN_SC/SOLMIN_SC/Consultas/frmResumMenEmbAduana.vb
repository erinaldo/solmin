Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Negocio.clsEmbarque
Imports SOLMIN_SC.Negocio.clsDocApertura
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.clsTab
Imports SOLMIN_SC.HelpUtil
Imports Ransa.Utilitario
Imports System.Text

Public Class frmResumMenEmbAduana
  Private objDtDia As New DataTable
  Private dtResumenJoin As New DataTable
  Dim dtDatosEmbarqueConsulta As New DataTable
  Private dtItemEmb As New DataTable
  Private dtCostoEmbItem As New DataTable
  Private oListColMerge As New List(Of String)


    Private Sub frmResumMenEmbAduana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try

            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

      kdgvResumen.AutoGenerateColumns = False
         
      CargarCliente()
      TipoOperacion()

      Cargar_Estado()
      dtpFecIni.Value = Now.AddMonths(-2)
      ConfigurarColumna()
      LlenarCheckPoint()
      verGrafico(False)
      Dim oNoLaborable As New clsNoLaborable
      chkCheckPoint.Checked = False
      chkCheckPoint_CheckedChanged(chkCheckPoint, Nothing)
      oNoLaborable.Inicio = 20080101
      oNoLaborable.Fin = Now.ToString("yyyyMMdd")
      objDtDia = oNoLaborable.dtNoLaborables
      Llenar_TipoFecha()
      UcSeguimiento.pLoad()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    End Try
  End Sub

  Private Sub TipoOperacion()
    Dim oclsEstado As New clsEstado
    Dim dtTipoOperacion As New DataTable
    dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
    Dim dr As DataRow
    dr = dtTipoOperacion.NewRow
    dr("COD") = "0"
    dr("TEX") = "TODOS"
    dtTipoOperacion.Rows.InsertAt(dr, 0)
    cboTipoOperacion.DataSource = dtTipoOperacion
    cboTipoOperacion.DisplayMember = "TEX"
    cboTipoOperacion.ValueMember = "COD"
    cboTipoOperacion.SelectedValue = "0"
  End Sub

  Friend WithEvents oDtgVar As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents ctmGrillaDinamica As System.Windows.Forms.ContextMenuStrip
  Private strCodVariable As String

  Private Function IsEmbarqueCerrado(ByVal EstadoEmbarque As String) As Boolean
    Dim IsCerrado As Boolean = False
    IsCerrado = (EstadoEmbarque = "C")
    Return IsCerrado
  End Function

    Private Sub Llenar_TipoFecha()
        Dim obllTipoFecha As New Estado_BLL
        Dim oListTipoFecha As New List(Of beEstadoEmb)
        oListTipoFecha = obllTipoFecha.ListarTipoFecha
        cboTipoFecha.DataSource = oListTipoFecha
        cboTipoFecha.DisplayMember = "TEX"
        cboTipoFecha.ValueMember = "COD"
        cboTipoFecha.SelectedValue = "_DFECREA"
        cboTipoFecha.Enabled = False
    End Sub

    Private Sub LlenarCheckPoint()
        Dim dt As New DataTable
        dt.Columns.Add("DISPLAY")
        dt.Columns.Add("VALUE", Type.GetType("System.Decimal"))

        'A :CHECKPOINT ADUANA
        'P : CHECKPOINT EMBARQUE

        Dim dr As DataRow
        dr = dt.NewRow
        dr("DISPLAY") = "A-DOCUMENTO COMPLETO"
        dr("VALUE") = 120
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "A-NUMERACIÓN DE DUA"
        dr("VALUE") = 121
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "A-PAGO DERECHOS"
        dr("VALUE") = 122
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "A-LEVANTE"
        dr("VALUE") = 123
        dt.Rows.Add(dr)


        dr = dt.NewRow
        dr("DISPLAY") = "A-ENTREGA DE ALMACÉN"
        dr("VALUE") = 124
        dt.Rows.Add(dr)

     

        cboCheckPoint.DataSource = dt
        cboCheckPoint.ValueMember = "VALUE"
        cboCheckPoint.DisplayMember = "DISPLAY"
        cboCheckPoint.SelectedValue = 120
    End Sub
    Private Function IsVisible(ByVal Visible As String)
        Dim EsVisible As Boolean = False
        EsVisible = Visible.Equals("S")
        Return EsVisible
  End Function

  Private Sub CargarCliente()
    cmbCliente.pAccesoPorUsuario = True
    cmbCliente.pRequerido = True
    cmbCliente.pUsuario = HelpUtil.UserName
  End Sub

    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub
    Private Sub Cargar_Estado()
        Dim oEstado As New clsEstado
        'oEstado.Estado_Aduanero()
        Me.cmbEstado.DataSource = oEstado.Estado_Aduanero
        Me.cmbEstado.ValueMember = "COD"
        Me.cmbEstado.DisplayMember = "TEX"
        Me.cmbEstado.SelectedValue = "A"
    End Sub
    
    Dim obeResumenMensual As beResumenMensual

    Private Function GetFiltro() As beResumenMensual
        obeResumenMensual = New beResumenMensual
        Dim TIPO_CHK As String = ""
        Dim DESC_CHK As String = ""
        Dim obrEmbarque As New clsEmbarque

        Dim odt As New DataTable
        If cmbCliente.pCodigo = 0 Then
            obeResumenMensual.PNCCLNT = 0
        Else
            obeResumenMensual.PNCCLNT = cmbCliente.pCodigo
        End If
        obeResumenMensual.PNFECHA_INI = dtpFecIni.Value.ToString("yyyyMMdd")
        obeResumenMensual.PNFECHA_FIN = dtpFecFin.Value.ToString("yyyyMMdd")

        If txtEmbarque.Text.Length > 0 Then
            obeResumenMensual.PNNORSCI = txtEmbarque.Text
        Else
            obeResumenMensual.PNNORSCI = 0
        End If
        If txtOS.Text.Length > 0 Then
            obeResumenMensual.PNPNNMOS = txtOS.Text
        Else
            obeResumenMensual.PNPNNMOS = 0
        End If

        If UcProveedor.pCodigo > 0 Then
            obeResumenMensual.PNCPRVCL = UcProveedor.pCodigo
        Else
            obeResumenMensual.PNCPRVCL = 0
        End If
        If cmbEstado.SelectedValue = "0" Then
            obeResumenMensual.PSESTADO = ""
        Else
            obeResumenMensual.PSESTADO = cmbEstado.SelectedValue
    End If

    Dim Tipo_Operacion As String = cboTipoOperacion.SelectedValue
    If Tipo_Operacion = "0" Then
      obeResumenMensual.PSTPSRVA = ""
    Else
      obeResumenMensual.PSTPSRVA = Tipo_Operacion
    End If

    If chkCheckPoint.Checked = True Then
      DESC_CHK = cboCheckPoint.Text
      Dim chk() As String
      chk = DESC_CHK.Split("-")
      Select Case chk(0)
        Case "A"
          obeResumenMensual.PSTIPO_CHK = "A"
        Case "P"
          obeResumenMensual.PSTIPO_CHK = "P"
      End Select
      obeResumenMensual.PNFECHA_CHK_INI = dtpCHKInicio.Value.ToString("yyyyMMdd")
      obeResumenMensual.PNFECHA_CHK_FIN = dtpCHKFin.Value.ToString("yyyyMMdd")
      obeResumenMensual.PNCHK_COD = cboCheckPoint.SelectedValue
    End If
    Return obeResumenMensual
  End Function

    Private Sub verGrafico(ByVal ver As Boolean)
        lblBusqueda.Visible = ver
        lblBusqueda.Text = "..Consultando.."
        pbxBuscar.Visible = ver
    End Sub

  Private Sub txtEmbarque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbarque.KeyPress
    RemoveHandler txtEmbarque.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
    txtEmbarque.Text = txtEmbarque.Text.Trim
    txtEmbarque.Tag = "10-0"
    AddHandler txtEmbarque.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
  End Sub

  Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
      e.Handled = True
    End If
  End Sub

    Private Sub txtOS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOS.KeyPress
        RemoveHandler txtOS.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
        txtOS.Text = txtOS.Text.Trim
        txtOS.Tag = "10-0"
        AddHandler txtOS.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
    End Sub

    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim obrEmbarque As New clsRepColumnaEmbarque
        e.Result = obrEmbarque.Listar_Resumen_Mensual_Embarque(obeResumenMensual)

        Dim ods As New DataSet
        Dim dtResumen As New DataTable
        Dim dtFact_Documento As New DataTable
        Dim dtStatus_CHK_EMB As New DataTable
        Dim dtStatusCI_CHKCargaIntern As DataTable
        Dim dtCostoEmb As New DataTable
      
        Dim ColName As String = ""
        Dim FechaNum As Decimal = 0
        Dim oFnEmbarque As New clsEmbarqueAduanas
        ods = CType(e.Result, DataSet)

        dtResumen = ods.Tables("DT_RESUMEN").Copy
        dtFact_Documento = ods.Tables("DT_DOCUMENTOS").Copy
        dtStatus_CHK_EMB = ods.Tables("DT_CHK_EMB").Copy
        dtStatusCI_CHKCargaIntern = ods.Tables("DT_CHK_CARGA_INTER").Copy
        dtCostoEmb = ods.Tables("DT_COSTOS_EMB").Copy

        dtItemEmb.Rows.Clear()
        dtCostoEmbItem.Rows.Clear()
        dtItemEmb = ods.Tables("DT_ITEM_EMB").Copy
        dtCostoEmbItem = ods.Tables("DT_COSTOS_EMB_ITEM").Copy

        LlenarDatos(dtResumen, dtFact_Documento, dtStatus_CHK_EMB, dtStatusCI_CHKCargaIntern, dtCostoEmb)


    End Sub



    Private Sub ConfigurarColumna()
        kdgvResumen.Columns.Clear()
        Dim NPOI_SC As New HelpClass_NPOI_SC
     
        Dim oDcTx As DataGridViewColumn
        Dim oclsRepColumnaEmbarque As New clsRepColumnaEmbarque
        Dim odtColumna As New DataTable
        odtColumna = oclsRepColumnaEmbarque.ListaColumnasEmbarque()

        Dim NAME_COLUMNA As String = ""
        Dim DES_COLUMNA As String = ""
        Dim Tipo As String = ""
        For FILA As Integer = 0 To odtColumna.Rows.Count - 1
            NAME_COLUMNA = odtColumna.Rows(FILA)("Codigo").ToString
            DES_COLUMNA = odtColumna.Rows(FILA)("Descripcion").ToString
            Tipo = odtColumna.Rows(FILA)("Tipo").ToString
            Select Case Tipo
                Case NPOI_SC.keyDatoTexto
                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.SortMode = DataGridViewColumnSortMode.Automatic
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    oDcTx.ReadOnly = True
                    oDcTx.DataPropertyName = NAME_COLUMNA
                    Me.kdgvResumen.Columns.Add(oDcTx)
                Case NPOI_SC.keyDatoNumero

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.SortMode = DataGridViewColumnSortMode.Automatic
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    oDcTx.ReadOnly = True
                    oDcTx.Tag = NPOI_SC.keyDatoNumero
                    oDcTx.DataPropertyName = NAME_COLUMNA
                    Me.kdgvResumen.Columns.Add(oDcTx)

                Case NPOI_SC.keyDatoFecha

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.SortMode = DataGridViewColumnSortMode.Automatic
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    oDcTx.ReadOnly = True
                    oDcTx.DataPropertyName = NAME_COLUMNA
                    Me.kdgvResumen.Columns.Add(oDcTx)

            End Select

        Next

        dtResumenJoin.Columns.Clear()
        For FILA As Integer = 0 To odtColumna.Rows.Count - 1
            NAME_COLUMNA = odtColumna.Rows(FILA)("Codigo").ToString
             dtResumenJoin.Columns.Add(NAME_COLUMNA)
        Next

    End Sub

    Public Function CalculaTotalOtrosCostos(ByVal oDtCostos As DataTable, ByVal PNNORSCI As Decimal) As Decimal
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim OtrosGastos As Decimal = 0
        Dim Costo As Decimal = 0
        'Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "OTSGAS", oDtCostos), Costo)
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "TASDES", oDtCostos), Costo)
        OtrosGastos = Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "DERESP", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "SOBTAS", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ANTDUM", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IMSECO", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "MORA", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "INTCOM", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Return OtrosGastos
    End Function

    Private Sub LlenarDatos(ByVal dtResumen As DataTable, ByVal oDtFac As DataTable, ByVal oDtStatus As DataTable, ByVal oDtStatusCI As DataTable, ByVal odtCostos As DataTable)
        Dim oFnAduanas As New clsEmbarqueAduanas
        dtResumenJoin.Rows.Clear()
        Dim dr As DataRow
        Dim NameCol As String = ""
        Dim Valor As String = ""

        Dim PNNORSCI As Decimal = 0
        Dim COD_CHK As Decimal = 0
        Dim dtCHK As New DataTable
        Dim NAME_COLUMNA_FILTRO As String = ""


        If obeResumenMensual.PNCHK_COD > 0 Then
            If obeResumenMensual.PSTIPO_CHK = "A" Then
                dtCHK = oDtStatus.Copy
                'NOMBRE COLUMNA CHECKPOINT EMBARQUE
                NAME_COLUMNA_FILTRO = "FRETES"
            ElseIf obeResumenMensual.PSTIPO_CHK = "P" Then
                dtCHK = oDtStatusCI.Copy
                NAME_COLUMNA_FILTRO = "DFECREA"
                'NOMBRE COLUMNA CHECKPOINT PREEMBARQUE
            End If
        End If


        Dim drCHK() As DataRow
        Dim RangoValidoCHK As Boolean = False
        Dim PNFECHA_FLAG As Decimal = 0
        Dim FILA_ULTIMA_ADD As Int32 = 0

        Dim CostosVarios As Decimal = 0

        For Fila As Integer = 0 To dtResumen.Rows.Count - 1
            RangoValidoCHK = True
            PNNORSCI = dtResumen.Rows(Fila)("NORSCI")

            If obeResumenMensual.PNCHK_COD > 0 Then
                drCHK = dtCHK.Select("NORSCI='" & PNNORSCI & "' AND NESTDO='" & obeResumenMensual.PNCHK_COD & "'")
                If drCHK.Length > 0 Then
                    PNFECHA_FLAG = HelpClass.ToDecimalCvr(drCHK(0)(NAME_COLUMNA_FILTRO))
                    If PNFECHA_FLAG >= obeResumenMensual.PNFECHA_CHK_INI AndAlso PNFECHA_FLAG <= obeResumenMensual.PNFECHA_CHK_FIN Then
                        RangoValidoCHK = True
                    Else
                        RangoValidoCHK = False
                    End If
                End If
             
            End If

            If RangoValidoCHK = True Then
                dr = dtResumenJoin.NewRow
                dr("NORSCI") = dtResumen.Rows(Fila)("NORSCI")

                dr("TDITES") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("MERCADERIA"))

                dr("TPRVCL") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("PROVEEDOR"))
                '"Proveedor"

                dr("PNNMOS") = dtResumen.Rows(Fila)("PNNMOS")
                '"Orden Servicio"

                dr("QVOLMR") = dtResumen.Rows(Fila)("VOLUMEN")

                dr("QPSOAR") = dtResumen.Rows(Fila)("PESO")
                ' "Kg.Brutos"

                dr("NDIALB") = dtResumen.Rows(Fila)("DIAS_LIBRES")
                '"Días Libres"

                dr("NDIASE") = dtResumen.Rows(Fila)("DIAS_SOBREESTADIA")
                '"SobreEstadía"

                dr("EXW") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTEXW", odtCostos)
                ' "EXW"

                dr("GFOB") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GFOB", odtCostos)
                '"GFOB"

                dr("FOB") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "FOB", odtCostos)
                ' "FOB"

                dr("FLETE") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "FLETE", odtCostos)
                ' "FLETE"

                dr("SEGURO") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "SEGURO", odtCostos)
                ' "SEGURO"

                dr("CIF") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "CIF", odtCostos)
                ' "CIF"

                dr("ADVALOREM") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ADVALO", odtCostos)
                ' "ADVALOREM"

                dr("IGV") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IGV", odtCostos)
                ' "IGV"

                dr("IPM") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IPM", odtCostos)
                ' "IPM"

                dr("TOTALDER") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "TOLDER", odtCostos)
                ' "TOTAL DERECHOS"

                dr("ITTGOA") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTGOA", odtCostos)
                '"GASTOS OPERATIVOS"

                'dr("NUMFAC") = oFnAduanas.Llenar_Factura(oDtFac, PNNORSCI)
                ' "Facturas"

                dr("CAGNCR") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("AGENTE_CARGA"))
                ' "Agente de Carga"

                dr("CTRMAL") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("TERMINAL_ALMAC"))
                ' "Terminal de Almacenamiento"

                dr("REGIMEN") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("REGIMEN"))
                ' "REGIMEN"

                dr("DESPACHO") = dtResumen.Rows(Fila)("TIPO_DESPACHO")
                ' "Despacho"

                dr("DOCEMB") = oFnAduanas.Buscar_Doc_Emb(oDtFac, PNNORSCI)

                dr("CMEDTR") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("MEDIO_TRANSPORTE"))
                ' "Medio Transporte"

                dr("NUMDUA") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("TNRODU"))
                ' "Número Dua"

                dr("CANAL") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("TCANAL"))
                ' "Canal"

                dr("TNIMCIN") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("COMP_NAVIERA"))
                '"Línea Naviera"

                dr("CVPRCN") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("NAVE"))
                '"Nave/Cia. Transporte"

                Valor = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("PAIS_ORIGEN"))
                If HelpClass.ToStringCvr(dtResumen.Rows(Fila)("PUERTO_ORIGEN")).Length > 0 Then
                    Valor = Valor & " - " & HelpClass.ToStringCvr(dtResumen.Rows(Fila)("PUERTO_ORIGEN"))
                End If
                dr("CPRTOE") = Valor
                ' "Origen"

                Valor = "PERU"
                If HelpClass.ToStringCvr(dtResumen.Rows(Fila)("PUERTO_DESTINO")).Length > 0 Then
                    Valor = Valor & " - " & HelpClass.ToStringCvr(dtResumen.Rows(Fila)("PUERTO_DESTINO"))
                Else
                    Valor = ""
                End If
                dr("CPRTOA") = "PERU" & " - " & HelpClass.ToStringCvr(dtResumen.Rows(Fila)("PUERTO_DESTINO"))
                ' "Destino"

                dr("FACCOP") = oFnAduanas.Fecha_Factura_Copia(oDtFac, PNNORSCI)

                dr("FACORG") = oFnAduanas.Fecha_Factura_Original(oDtFac, PNNORSCI)

                dr("DEMCOP") = oFnAduanas.Fecha_DocEmbarque_Copia(oDtFac, PNNORSCI)

                dr("DEMORG") = oFnAduanas.Fecha_DocEmbarque_Original(oDtFac, PNNORSCI)

                dr("TRACOP") = oFnAduanas.Fecha_Traduccion_Copia(oDtFac, PNNORSCI)

                dr("TRAORG") = oFnAduanas.Fecha_Traduccion_Original(oDtFac, PNNORSCI)

                dr("VOLCOP") = oFnAduanas.Fecha_Volante_Copia(oDtFac, PNNORSCI)

                dr("VOLORG") = oFnAduanas.Fecha_Volante_Original(oDtFac, PNNORSCI)

                dr("SEGCOP") = oFnAduanas.Fecha_Seguro_Copia(oDtFac, PNNORSCI)

                dr("SEGORG") = oFnAduanas.Fecha_Seguro_Original(oDtFac, PNNORSCI)

                dr("CORCOP") = oFnAduanas.Fecha_Certificado_Origen_Copia(oDtFac, PNNORSCI)

                dr("CORORG") = oFnAduanas.Fecha_Certificado_Origen_Original(oDtFac, PNNORSCI)

                dr("OTRORG") = oFnAduanas.Fecha_Otro_Documento_Original(oDtFac, PNNORSCI)

                dr("FECDCP") = oFnAduanas.Fecha_Doc_Completos(oDtStatus, PNNORSCI)
                '"F. Documentos Completos"

                dr("FECNUM") = oFnAduanas.Fecha_Numeracion(oDtStatus, PNNORSCI)
                ' "Fecha Numeración"

                dr("FECPGD") = oFnAduanas.Fecha_Pago_Derechos(oDtStatus, PNNORSCI)
                ' "Fecha Pago Derechos"

                dr("FECLEV") = oFnAduanas.Fecha_Levante(oDtStatus, PNNORSCI)
                ' "Fecha Levante"

                dr("FECALM") = oFnAduanas.Fecha_Entrega_Alm_Cliente(oDtStatus, PNNORSCI)
                '"Fecha Entrega Almacén"

                dr("FECPRO") = oFnAduanas.Fecha_Proforma(oDtStatus, PNNORSCI)

                dr("FECPGP") = oFnAduanas.Fecha_Pago_Proforma(oDtStatus, PNNORSCI)

                dr("NUMSEG") = oFnAduanas.Buscar_Seguro(oDtFac, PNNORSCI)

                dr("CKCLPV") = oFnAduanas.Fecha_EntregaProv(oDtStatusCI, PNNORSCI)

                dr("CKRECO") = oFnAduanas.Fecha_RecojoMaterial(oDtStatusCI, PNNORSCI)

                dr("CKIGAT") = oFnAduanas.Fecha_Llegada_Material_Al_Emb(oDtStatusCI, PNNORSCI)

                dr("CKAECL") = oFnAduanas.Fecha_AprobacionDocs(oDtStatusCI, PNNORSCI)

                dr("CHKEPR") = oFnAduanas.Fecha_EntregaOrigen(oDtStatusCI, PNNORSCI)

                ''dr("SESTRG") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("SESTRG"))

                'Valor = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("SESTRG"))
                'If Valor = "A" Then
                '    Valor = "ATENCION"
                'ElseIf Valor = "C" Then
                '    Valor = "CERRADO"
                'End If
                'dr("SESTRG_ESTADO") = Valor
                'ADICIONADOS PARA GYM
                '*****************************************************************************************************

                dr("NREFCLEMB") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("REFERENCIA_CLIENTE"))


                dr("ITTCAG") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTCAG", odtCostos)



                dr("COSVAR") = CalculaTotalOtrosCostos(odtCostos, PNNORSCI)


                '   Case "COSVAR"
                'dgv.Rows(Fila).Cells(intCol).Value = CalculaTotalOtrosCostos(odtCostos, PNNORSCI)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "OTROS COSTOS/" & Chr(13) & "Tasa Despacho+SobreTasa+Derecho Especifico+Antidumping+" & Chr(13) & "ISC+Interes Compensantorio+Mora"

                '"COMISIÓN AGENCIAMIENTO"

                'dr("OTSGAS") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "OTSGAS", odtCostos)
                ' "TASA DESPACHO"    

                '   Case "COSVAR"
                'dgv.Rows(Fila).Cells(intCol).Value = CalculaTotalOtrosCostos(odtCostos, PNNORSCI)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "OTROS COSTOS/" & Chr(13) & "Tasa Despacho+SobreTasa+Derecho Especifico+Antidumping+" & Chr(13) & "ISC+Interes Compensantorio+Mora"

                'Case "OTSGAS"
                '    dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "OTSGAS", oDtCostos)
                '    dgv.Rows(Fila).Cells(intCol).ToolTipText = "TASA DESPACHO"

                '        Case "TASDES"
                'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "TASDES", odtCostos)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "TASA DESPACHO"

                '  Case "DERESP"
                'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "DERESP", odtCostos)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "DERECHO ESPECIFICO"

                '        Case "SOBTAS"
                'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "SOBTAS", odtCostos)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "SOBRETASA"

                '        Case "ANTIDUM"
                'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ANTIDUM", odtCostos)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "ANTIDUMPING"

                '        Case "IMSECO"
                'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IMSECO", odtCostos)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "ISC"

                '        Case "INTCOM"
                'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "INTCOM", odtCostos)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "INTERES COMPENSATORIO"

                '        Case "MORA"
                'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "MORA", odtCostos)
                'dgv.Rows(Fila).Cells(intCol).ToolTipText = "MORA"


              

                dr("RECPOP") = oFnAduanas.BuscarFechaEntregaOC(oDtStatusCI, PNNORSCI)
                ' "Fecha Entrega de la OC"

                dr("CHKETA") = HelpClass.FechaNum_a_Fecha(dtResumen.Rows(Fila)("ETA_FECHA"))
                ' "ETA"

                dr("CHKETD") = HelpClass.FechaNum_a_Fecha(dtResumen.Rows(Fila)("ETD_FECHA"))
                ' "ETD"

                dr("FAPRAR") = oFnAduanas.BuscarFechaEmbarque(oDtStatusCI, PNNORSCI)
                ' "Fecha de Llegada"

                dr("FAPREV") = oFnAduanas.BuscarFechaLlegada(oDtStatusCI, PNNORSCI)

                '        Case "FAPRAR"
                '            dr(Columna) = oFnAduanas.BuscarFechaEmbarque(oDtStatusCI, PNNORSCI)
                '            ' "Fecha de Llegada"
                '        Case "FAPREV"
                '            dr(Columna) = oFnAduanas.BuscarFechaLlegada(oDtStatusCI, PNNORSCI)                            


                dr("REFDO1") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("REFERENCIA_DOCUMENTO"))

                dr("CMEDTRAGEN") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("TRANSPORTE_AGENCIA"))

                dr("FECFAC") = oFnAduanas.Fecha_Entrega_Factura(oDtStatus, PNNORSCI)

                dr("FCDCOR") = oFnAduanas.Fecha_Volante(oDtStatus, PNNORSCI)
                '"Fecha Volante"

                dr("CKCROK") = oFnAduanas.Fecha_CargaOK(oDtStatusCI, PNNORSCI)
                ' "Fecha Carga OK"

                dr("CKCRDS") = oFnAduanas.Fecha_Carga_Discrepancia(oDtStatusCI, PNNORSCI)
                ' "Fecha Carga en Discrepancia"

                dr("NOPRCN") = dtResumen.Rows(Fila)("NOPRCN")
                ' "Operacion"

                dr("NDCFCC") = dtResumen.Rows(Fila)("NDCFCC")
                ' "N factura"

                dr("FDCFCC") = HelpClass.FechaNum_a_Fecha(dtResumen.Rows(Fila)("FDCFCC_FECHA"))
                ' "N Fecha Facturacion"

                dr("FORSCI") = HelpClass.FechaNum_a_Fecha(dtResumen.Rows(Fila)("FORSCI_FECHA"))

                dr("ESTADOEMB") = HelpClass.ToStringCvr(dtResumen.Rows(Fila)("ESTADOEMB"))

                dr("ITTCEM") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTCEM", odtCostos)

                dr("ITTRAC") = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTRAC", odtCostos)

                dtResumenJoin.Rows.Add(dr)
                FILA_ULTIMA_ADD = dtResumenJoin.Rows.Count - 1
                ActualizarDiferencia_Numeracion_Vs_DocCompleto(FILA_ULTIMA_ADD)
                ActualizarDiferencia_FecAt_Vs_PagoDer(FILA_ULTIMA_ADD)
                ActualizarDiferencia_Embarque_VS_Llegada(FILA_ULTIMA_ADD)
                ActualizarDiferencia_LLegada_VS_Levante(FILA_ULTIMA_ADD)
                ActualizarDiferencia_Levante_VS_Almacen(FILA_ULTIMA_ADD)
                ActualizarDiferencia_EntregaOC_VS_EntregaPorProveedor(FILA_ULTIMA_ADD)
                ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(FILA_ULTIMA_ADD)
                ActualizarDiferencia_DocumentosCompletos_VS_ETA(FILA_ULTIMA_ADD)
        ActualizarDiferencia_Numeracion_VS_PagoDerecho(FILA_ULTIMA_ADD)


            End If
    Next
    End Sub


    Private Sub ActualizarDiferencia_FecAt_Vs_PagoDer(ByVal FILA As Int32)
        If (dtResumenJoin.Columns("DIFPDA") IsNot Nothing) AndAlso (dtResumenJoin.Columns("FECALM") IsNot Nothing) AndAlso (dtResumenJoin.Columns("FECPGD") IsNot Nothing) Then
            If (dtResumenJoin.Rows(FILA)("FECALM") IsNot Nothing) AndAlso (dtResumenJoin.Rows(FILA)("FECPGD") IsNot Nothing) Then
                Calcular_FecAt_Vs_PagoDer(dtResumenJoin.Rows(FILA)("FECPGD").ToString.Trim, dtResumenJoin.Rows(FILA)("FECALM").ToString.Trim, FILA)
            End If
        End If
    End Sub
    Private Sub ActualizarDiferencia_Numeracion_Vs_DocCompleto(ByVal FILA As Int32)
        If (Me.dtResumenJoin.Columns.Item("DIFDCN") IsNot Nothing) And (Me.dtResumenJoin.Columns.Item("FECNUM") IsNot Nothing) AndAlso (Me.dtResumenJoin.Columns.Item("FECDCP") IsNot Nothing) Then
            If (dtResumenJoin.Rows(FILA)("FECNUM") IsNot Nothing) AndAlso (dtResumenJoin.Rows(FILA)("FECDCP") IsNot Nothing) Then
                Calcular_Numeracion_Vs_DocCompleto(dtResumenJoin.Rows(FILA)("FECDCP").ToString.Trim, dtResumenJoin.Rows(FILA)("FECNUM").ToString.Trim, FILA)
            End If
        End If
    End Sub

    Private Sub Calcular_Numeracion_Vs_DocCompleto(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer
        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            dtResumenJoin.Rows(pintRow)("DIFDCN") = lintDias
        End If
    End Sub

    Private Sub Calcular_FecAt_Vs_PagoDer(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            dtResumenJoin.Rows(pintRow)("DIFPDA") = lintDias
        End If
    End Sub


    Private Sub ActualizarDiferencia_EntregaOC_VS_EntregaPorProveedor(ByVal FILA As Int32)
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim ExisteColumna As Boolean = False
        Dim CHK_ENTREGAOC_NESTDO_100 As String = ""
        Dim CHK_ENTREGA_X_PROVEEDOR_NESTDO_102 As String = ""
        ExisteColumna = dtResumenJoin.Columns("DIFRCCK") IsNot Nothing
        If (ExisteColumna = True) Then
            '"ENTREGA OC VS ENTREGA POR EL PROVEEDOR"
            ExisteColumna = dtResumenJoin.Columns("RECPOP") IsNot Nothing _
                           AndAlso dtResumenJoin.Columns("CKCLPV") IsNot Nothing
        End If
        If (ExisteColumna) Then
            If (dtResumenJoin.Rows(FILA)("RECPOP") <> vbNullString) Then
                CHK_ENTREGAOC_NESTDO_100 = dtResumenJoin.Rows(FILA)("RECPOP")
            End If
            If (dtResumenJoin.Rows(FILA)("CKCLPV") <> vbNullString) Then
                CHK_ENTREGA_X_PROVEEDOR_NESTDO_102 = dtResumenJoin.Rows(FILA)("CKCLPV")
            End If
            dtResumenJoin.Rows(FILA)("DIFRCCK") = DiferenciaFechas(CHK_ENTREGAOC_NESTDO_100, CHK_ENTREGA_X_PROVEEDOR_NESTDO_102)
        End If
    End Sub


    Private Sub ActualizarDiferencia_Embarque_VS_Llegada(ByVal FILA As Int32)
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim ExisteColumna As Boolean = False
        Dim CHK_EMBARQUE_NESTDO_107 As String = ""
        Dim CHK_LLEGADA_108 As String = ""
        ExisteColumna = dtResumenJoin.Columns("DIFERM") IsNot Nothing
        If (ExisteColumna = True) Then
            ' "EMBARQUE VS LLEGADA"
            ExisteColumna = dtResumenJoin.Columns("FAPRAR") IsNot Nothing _
                           AndAlso dtResumenJoin.Columns("FAPREV") IsNot Nothing
        End If
        If (ExisteColumna) Then
            If (dtResumenJoin.Rows(FILA)("FAPRAR") <> vbNullString) Then
                CHK_EMBARQUE_NESTDO_107 = dtResumenJoin.Rows(FILA)("FAPRAR")
            End If
            If (dtResumenJoin.Rows(FILA)("FAPREV") <> vbNullString) Then
                CHK_LLEGADA_108 = dtResumenJoin.Rows(FILA)("FAPREV")
            End If
            dtResumenJoin.Rows(FILA)("DIFERM") = DiferenciaFechas(CHK_EMBARQUE_NESTDO_107, CHK_LLEGADA_108)
        End If
    End Sub
    Private Sub ActualizarDiferencia_LLegada_VS_Levante(ByVal FILA As Int32)
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim CHK_LLEGADA_108 As String = ""
        Dim CHK_LEVANTE_123 As String = ""
        Dim ExisteColumna As Boolean = dtResumenJoin.Columns("DIFEME") IsNot Nothing
        If (ExisteColumna = True) Then
            ExisteColumna = dtResumenJoin.Columns("FAPREV") IsNot Nothing _
                           AndAlso dtResumenJoin.Columns("FECLEV") IsNot Nothing
        End If
        If (ExisteColumna = True) Then
            If (dtResumenJoin.Rows(FILA)("FAPREV") <> vbNullString) Then
                CHK_LLEGADA_108 = dtResumenJoin.Rows(FILA)("FAPREV")
            End If
            If (dtResumenJoin.Rows(FILA)("FECLEV") <> vbNullString) Then
                CHK_LEVANTE_123 = dtResumenJoin.Rows(FILA)("FECLEV")
            End If
            dtResumenJoin.Rows(FILA)("DIFEME") = DiferenciaFechas(CHK_LLEGADA_108, CHK_LEVANTE_123)
            ' "LLEGADA VS LEVANTE"
        End If

    End Sub
    Private Sub ActualizarDiferencia_Levante_VS_Almacen(ByVal FILA As Int32)
        Dim CHK_ALMACEN_124 As String = ""
        Dim CHK_LEVANTE_123 As String = ""
        Dim ExisteColumna As Boolean = dtResumenJoin.Columns("DIFEEP") IsNot Nothing
        If (ExisteColumna = True) Then
            ExisteColumna = dtResumenJoin.Columns("FECLEV") IsNot Nothing _
                           AndAlso dtResumenJoin.Columns("FECALM") IsNot Nothing
        End If
        If (ExisteColumna) Then
            If (dtResumenJoin.Rows(FILA)("FECALM") <> vbNullString) Then
                CHK_ALMACEN_124 = dtResumenJoin.Rows(FILA)("FECALM")
            End If
            If (dtResumenJoin.Rows(FILA)("FECLEV") <> vbNullString) Then
                CHK_LEVANTE_123 = dtResumenJoin.Rows(FILA)("FECLEV")
            End If
            dtResumenJoin.Rows(FILA)("DIFEEP") = DiferenciaFechas(CHK_LEVANTE_123, CHK_ALMACEN_124)
            ' "LEVANTE VS ALMACEN"
        End If
    End Sub

    Private Function DiferenciaFechas(ByVal FechaMenor As String, ByVal FechaMayor As String) As String
        Dim DifReferencia As String = ""
        Dim FechaMin As Date
        Dim FechaMax As Date
        If (Date.TryParse(FechaMenor, FechaMin) AndAlso Date.TryParse(FechaMayor, FechaMax)) Then
            DifReferencia = DateDiff(DateInterval.Day, FechaMin, FechaMax)
        End If
        Return DifReferencia
    End Function


    Private Sub ActualizarDiferencia_Numeracion_VS_PagoDerecho(ByVal Fila As Int32)
        Dim EvaluaValor As Boolean = False
        EvaluaValor = (dtResumenJoin.Columns.Item("DXF6F5") IsNot Nothing)
        If EvaluaValor Then
            EvaluaValor = (dtResumenJoin.Columns.Item("FECPGD") IsNot Nothing) And (dtResumenJoin.Columns.Item("FECNUM") IsNot Nothing)
            If EvaluaValor Then
                EvaluaValor = (dtResumenJoin.Rows(Fila)("FECPGD") IsNot Nothing) And (dtResumenJoin.Rows(Fila)("FECNUM") IsNot Nothing)
                If EvaluaValor Then
                    Calcular_Numeracion_Vs_PagoDerechos(dtResumenJoin.Rows(Fila)("FECNUM").ToString.Trim, dtResumenJoin.Rows(Fila)("FECPGD").ToString.Trim, Fila)
                End If
            End If
        End If
    End Sub

    Private Sub ActualizarDiferencia_DocumentosCompletos_VS_ETA(ByVal Fila As Int32)
        Dim EvaluaValor As Boolean = False
        EvaluaValor = dtResumenJoin.Columns.Item("DXF4F3") IsNot Nothing
        If (EvaluaValor) Then
            EvaluaValor = (dtResumenJoin.Columns.Item("FECDCP") IsNot Nothing) And (dtResumenJoin.Columns.Item("CHKETA") IsNot Nothing)
            If EvaluaValor Then
                EvaluaValor = (dtResumenJoin.Rows(Fila)("FECDCP") IsNot Nothing) And (dtResumenJoin.Rows(Fila)("CHKETA") IsNot Nothing)
                If EvaluaValor Then
                    Calcular_DocumentosCompletos_Vs_ETA(dtResumenJoin.Rows(Fila)("CHKETA").ToString.Trim, dtResumenJoin.Rows(Fila)("FECDCP").ToString.Trim, Fila)
                End If
            End If
        End If
    End Sub

    Private Sub ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(ByVal Fila As Int32)
        Dim EvaluaValor As Boolean = False
        EvaluaValor = dtResumenJoin.Columns("DXF8F4") IsNot Nothing
        If (EvaluaValor) Then
            EvaluaValor = (dtResumenJoin.Columns.Item("FECALM") IsNot Nothing) And (Me.dtResumenJoin.Columns.Item("FECDCP") IsNot Nothing)
            If EvaluaValor Then
                EvaluaValor = (dtResumenJoin.Rows(Fila)("FECALM") IsNot Nothing) And (dtResumenJoin.Rows(Fila)("FECDCP") IsNot Nothing)
                If EvaluaValor Then
                    Calcular_FecAlmacen_Vs_DocumentosCompletos(dtResumenJoin.Rows(Fila)("FECDCP").ToString.Trim, dtResumenJoin.Rows(Fila)("FECALM").ToString.Trim, Fila)
                End If
            End If
        End If
    End Sub

    Private Sub OrdenFechas(ByRef pstrFecIni As String, ByRef pstrFecFin As String)
        Dim Fecha1 As Decimal = 0
        Dim Fecha2 As Decimal = 0
        Dim FecIni As String = pstrFecIni
        Dim FecFin As String = pstrFecFin
        Fecha1 = Format(CType(pstrFecIni, Date), "yyyyMMdd")
        Fecha2 = Format(CType(pstrFecFin, Date), "yyyyMMdd")
        If (Fecha1 > Fecha2) Then
            pstrFecIni = FecFin
            pstrFecFin = FecIni
        End If
    End Sub

    Private Sub Calcular_FecAlmacen_Vs_DocumentosCompletos(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer
        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            OrdenFechas(pstrFecIni, pstrFecFin)
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            dtResumenJoin.Rows(pintRow)("DXF8F4") = lintDias
        End If
    End Sub
    Private Sub Calcular_DocumentosCompletos_Vs_ETA(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            OrdenFechas(pstrFecIni, pstrFecFin)
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            dtResumenJoin.Rows(pintRow)("DXF4F3") = lintDias
        End If
    End Sub
    Private Sub Calcular_Numeracion_Vs_PagoDerechos(ByVal pstrFecIni As String, ByVal pstrFecFin As String, ByVal pintRow As Integer)
        Dim lobjDrList As DataRow()
        Dim lintDias As Integer

        If pstrFecIni <> vbNullString And pstrFecFin <> vbNullString Then
            OrdenFechas(pstrFecIni, pstrFecFin)
            lobjDrList = objDtDia.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
            lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
            dtResumenJoin.Rows(pintRow)("DXF6F5") = lintDias
        End If
    End Sub

    Private Function fintDiferencia_Dia(ByVal pstrDiaFinal As String, ByVal pstrDiaInicio As String, ByVal pintDia As Integer) As Integer
        Dim lintDif As Integer
        If IsDBNull(pstrDiaFinal) Or pstrDiaFinal = vbNullString Or IsDBNull(pstrDiaInicio) Or pstrDiaInicio = vbNullString Then
            Return 0
        End If
        lintDif = DateDiff(DateInterval.Day, CType(pstrDiaInicio, Date), CType(pstrDiaFinal, Date))
        If lintDif >= 0 Then
            lintDif = lintDif - pintDia
        Else
            lintDif = lintDif + pintDia
        End If
        Return lintDif
    End Function

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Try
            kdgvResumen.DataSource = dtResumenJoin
            verGrafico(False)
        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkCheckPoint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckPoint.CheckedChanged
        gbCheckPoint.Enabled = chkCheckPoint.Checked
    End Sub

    Private Sub btnExporEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExporEmbarque.Click
        Try
            If kdgvResumen.Rows.Count = 0 Then
                MessageBox.Show("No existen datos", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim dtResumen As New DataTable
            Dim NameColumna As String = ""
            Dim ColTitle As String = ""
            Dim ColName As String = ""
            Dim MdataColumna As String = ""
            Dim TipoDato As String = ""

            For Each Item As DataGridViewColumn In kdgvResumen.Columns
                ColTitle = Item.HeaderText.Trim
                ColName = Item.Name.Trim
                TipoDato = ("" & Item.Tag).ToString.Trim
                Select Case TipoDato
                    Case NPOI_SC.keyDatoTexto
                        TipoDato = NPOI_SC.keyDatoTexto
                    Case NPOI_SC.keyDatoNumero
                        TipoDato = NPOI_SC.keyDatoNumero
                    Case NPOI_SC.keyDatoFecha
                        TipoDato = NPOI_SC.keyDatoTexto
                End Select
                MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                dtResumen.Columns.Add(ColName)
                dtResumen.Columns(ColName).Caption = MdataColumna
            Next
            Dim dr As DataRow
            For Each drDatos As DataGridViewRow In kdgvResumen.Rows
                dr = dtResumen.NewRow
                For Each dcColumna As DataColumn In dtResumen.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos.Cells(NameColumna).Value
                Next
                dtResumen.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(2) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(3) = "Hora:|" & Now.ToString("hh:mm:ss")
            'oLisParametros(3) = "Rango Fecha:|" & dtpFecIni.Value.ToString("dd/MM/yyyy") & " al " & dtpFecFin.Value.ToString("dd/MM/yyyy")
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtResumen, "LISTA DE EMBARQUES", Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtResumen.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            itemSortedList.Add(itemSortedList.Count, "Rango Fecha:|" & dtpFecIni.Value.ToString("dd/MM/yyyy") & " al " & dtpFecFin.Value.ToString("dd/MM/yyyy"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTA DE EMBARQUES")
            ' HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtCheckPointExportar, "LISTADO DE VAPORES", Nothing, oLisParametros)
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub


 

    Private Function CopiarDatosDetalleItem(ByVal drOrigen As DataRow, ByVal drDestino As DataRow) As DataRow
        drDestino("NORSCI_ITEM") = drOrigen("NORSCI")
        drDestino("NORCML") = ("" & drOrigen("NORCML")).ToString.Trim
        drDestino("NRITEM") = drOrigen("NRITEM")
        drDestino("SBITOC") = ("" & drOrigen("SBITOC")).ToString.Trim
        drDestino("TDITES_ITEM") = ("" & drOrigen("TDITES")).ToString.Trim
        drDestino("QRLCSC") = drOrigen("QRLCSC")
        drDestino("CPTDAR") = ("" & drOrigen("CPTDAR")).ToString.Trim
        drDestino("TCITCL") = ("" & drOrigen("TCITCL")).ToString.Trim
        drDestino("IVUNIT") = drOrigen("IVUNIT")
        drDestino("EXW") = drOrigen("ITTEXW")
        drDestino("GFOB") = drOrigen("GFOB")
        drDestino("FOB") = drOrigen("TOTFOB")
        drDestino("FLETE") = drOrigen("TOTFLT")
        drDestino("SEGURO") = drOrigen("TOTSEG")
        drDestino("CIF") = drOrigen("TOTCIF")
        drDestino("ADVALOREM") = drOrigen("TOTADV")
        drDestino("IGV") = drOrigen("TOTIGV")
        drDestino("IPM") = drOrigen("TOTIPM")
        drDestino("OTSGAS") = drOrigen("TOTOGS")
        drDestino("TOTALDER") = drOrigen("TOLDER")
        drDestino("ITTCAG") = drOrigen("ITTCAG")
        drDestino("ITTGOA") = drOrigen("ITTGOA")
        drDestino("ITTCEM") = drOrigen("ITTCEM")
        drDestino("ITTRAC") = drOrigen("ITTRAC")
        Return drDestino
    End Function

    Private Function CalcularCostosNivelItem(ByVal odtOC As DataTable, ByVal odtCostos As DataTable) As DataTable
       
        Dim NORCML As String = ""
        Dim NRITOC As Decimal = 0
        Dim NRPEMB As Decimal = 0
        Dim CODVAR As String = ""
        Dim SB_EXPRESION As New StringBuilder
        Dim MONTO_DOLAR As Decimal = 0
        Dim oColumnasCostos As New Hashtable
        ' Nombre Columna | Codigo Costo
        oColumnasCostos.Add("TOTFOB", "FOB")
        oColumnasCostos.Add("TOTFLT", "FLETE")
        oColumnasCostos.Add("TOTSEG", "SEGURO")
        oColumnasCostos.Add("TOTCIF", "CIF")
        oColumnasCostos.Add("TOTADV", "ADVALO")
        oColumnasCostos.Add("TOTIGV", "IGV")
        oColumnasCostos.Add("TOTIPM", "IPM")
        oColumnasCostos.Add("TOTOGS", "OTSGAS")
        oColumnasCostos.Add("TOLDER", "CALCULO_TOLDER") 'CALCULO IGV + IPM +ADVALO + OTSGAS
        oColumnasCostos.Add("ITTCAG", "ITTCAG")
        oColumnasCostos.Add("ITTGOA", "ITTGOA")
        oColumnasCostos.Add("ITTRAC", "ITTRAC")
        oColumnasCostos.Add("HANDLI", "HANDLI")
        oColumnasCostos.Add("DESALM", "DESALM")
        oColumnasCostos.Add("ITTAAG", "ITTAAG")
        oColumnasCostos.Add("ITTEXW", "ITTEXW")
        oColumnasCostos.Add("GFOB", "GFOB")
        oColumnasCostos.Add("ITTGAM", "ITTGAM")
        oColumnasCostos.Add("ITTTRM", "ITTTRM")
        oColumnasCostos.Add("ITTCEM", "ITTCEM")
        oColumnasCostos.Add("ITTCRS", "ITTCRS")
        oColumnasCostos.Add("ALMLOC", "ALMLOC")
        oColumnasCostos.Add("CARDES", "CARDES")
        oColumnasCostos.Add("ITTTRA", "ITTTRA")
        oColumnasCostos.Add("CARDEC", "CARDEC")
        oColumnasCostos.Add("INLAD", "INLAD")
        oColumnasCostos.Add("MONIMP", "GASADU")
        'ITTRAC
        For Each item As DictionaryEntry In oColumnasCostos
            odtOC.Columns.Add(item.Key, GetType(System.Decimal))
        Next
        Dim dr() As DataRow
        Dim TOT_DERECHOS As Decimal = 0

        Dim CCLNT As Decimal = 0
        Dim NORSCI As Decimal = 0
        For FILA As Integer = 0 To odtOC.Rows.Count - 1
            CCLNT = odtOC.Rows(FILA)("CCLNT")
            NORSCI = odtOC.Rows(FILA)("NORSCI")
            NORCML = odtOC.Rows(FILA)("NORCML").ToString.Trim
            NRITOC = odtOC.Rows(FILA)("NRITEM")
            NRPEMB = odtOC.Rows(FILA)("NRPEMB")
            For Each item As DictionaryEntry In oColumnasCostos
                CODVAR = item.Value
                SB_EXPRESION.Length = 0
                MONTO_DOLAR = 0
                Select Case CODVAR
                    Case "CALCULO_TOLDER"
                        SB_EXPRESION.Append("CCLNT=" & CCLNT & " AND NORSCI=" & NORSCI & " AND ")
                        SB_EXPRESION.Append(" NORCML='" & NORCML & "'" & " AND NRITEM=" & NRITOC & " AND ")
                        SB_EXPRESION.Append("NRPEMB=" & NRPEMB & " AND CODVAR IN ('IGV','IPM','ADVALO','OTSGAS')")
                    Case Else
                        SB_EXPRESION.Append("CCLNT=" & CCLNT & " AND NORSCI=" & NORSCI & " AND ")
                        SB_EXPRESION.Append(" NORCML='" & NORCML & "'" & " AND NRITEM=" & NRITOC & " AND ")
                        SB_EXPRESION.Append("NRPEMB=" & NRPEMB & " AND CODVAR='" & CODVAR & "'")
                End Select
                dr = odtCostos.Select(SB_EXPRESION.ToString)
                If dr.Length > 0 Then
                    For Each drItem As DataRow In dr
                        MONTO_DOLAR = MONTO_DOLAR + drItem("IVLDOL")
                    Next
                Else
                    MONTO_DOLAR = 0
                End If
                odtOC.Rows(FILA)(item.Key) = MONTO_DOLAR
            Next
        Next
        Return odtOC
    End Function


    'Private Sub btnExporEmbarqueDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExporEmbarqueDetalle.Click
    '    Try
    '        If kdgvResumen.Rows.Count = 0 Then
    '            MessageBox.Show("No existen datos", "Aviso", MessageBoxButtons.OK)
    '            Exit Sub
    '        End If
    '        verGrafico(True)
    '        bgwProcesoReport.RunWorkerAsync()

    '    Catch ex As Exception
    '        verGrafico(False)
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork
    '    Dim dtExportEmbarqueDet As New DataTable
    '    Dim odtColumnaFormt As New DataTable
    '    Dim oclsRepColumnaEmbarque As New clsRepColumnaEmbarque
    '    odtColumnaFormt = oclsRepColumnaEmbarque.ListaColumnasEmbarqueDetalle

    '    Dim NPOI As New HelpClass_NPOI_SC
    '    Dim NameColumna As String = ""
    '    Dim ColTitle As String = ""
    '    Dim ColName As String = ""
    '    Dim MdataColumna As String = ""
    '    Dim TipoDato As String = ""
    '    Dim Nivel As String = ""
    '    Dim oHashColNivelItem As New Hashtable
    '    Dim TipoColumna As String = ""
    '    'Dim oListColMerge As New List(Of String)

    '    dtExportEmbarqueDet.Columns.Add("NORSCI_ITEM")

    '    oListColMerge.Clear()
    '    For FILA As Integer = 0 To odtColumnaFormt.Rows.Count - 1
    '        NameColumna = odtColumnaFormt.Rows(FILA)("CODIGO").ToString
    '        ColTitle = odtColumnaFormt.Rows(FILA)("DESCRIPCION").ToString
    '        TipoDato = odtColumnaFormt.Rows(FILA)("TIPO").ToString.Trim
    '        Nivel = odtColumnaFormt.Rows(FILA)("NIVEL").ToString.Trim
    '        Select Case TipoDato
    '            Case HelpClass_NPOI_SC.keyDatoTexto
    '                TipoDato = HelpClass_NPOI_SC.keyDatoTexto
    '                TipoColumna = "System.String"
    '            Case HelpClass_NPOI_SC.keyDatoNumero
    '                TipoDato = HelpClass_NPOI_SC.keyDatoNumero
    '                TipoColumna = "System.Decimal"
    '            Case HelpClass_NPOI_SC.keyDatoFecha
    '                TipoDato = HelpClass_NPOI_SC.keyDatoTexto
    '                TipoColumna = "System.String"
    '        End Select
    '        If Nivel = clsRepColumnaEmbarque.kNivelEmbarque Then
    '            oListColMerge.Add(NameColumna)
    '        End If
    '        If Nivel = clsRepColumnaEmbarque.kNivelEmbarqueItem Then
    '            oHashColNivelItem.Add(NameColumna, TipoColumna) 'GUARDAMOS EL NIVEL DE 
    '            ' DE LA   IT (Item)
    '        End If
    '        MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
    '        dtExportEmbarqueDet.Columns.Add(NameColumna)
    '        dtExportEmbarqueDet.Columns(NameColumna).Caption = MdataColumna
    '    Next
    '    Dim dr As DataRow

    '    Dim drItemCosto() As DataRow


    'Dim NORSCI As Decimal = 0

    '    Dim odtItemEmbTEMP As New DataTable
    '    Dim odtCostoEmbItemTEMP As New DataTable
    '    Dim odtItemCostoJoin As New DataTable
    '    odtItemEmbTEMP = dtItemEmb.Copy
    '    odtCostoEmbItemTEMP = dtCostoEmbItem.Copy
    '    odtItemCostoJoin = CalcularCostosNivelItem(odtItemEmbTEMP, odtCostoEmbItemTEMP)

    '    Dim drTemp As DataRow
    '    For Each drDatos As DataRow In dtResumenJoin.Rows
    '        dr = dtExportEmbarqueDet.NewRow
    '        drTemp = dtExportEmbarqueDet.NewRow
    '        For Each dcColumna As DataColumn In dtExportEmbarqueDet.Columns
    '            NameColumna = dcColumna.ColumnName
    '            TipoColumna = dcColumna.DataType.FullName
    '            If oHashColNivelItem.Contains(NameColumna) Then
    '                If oHashColNivelItem(NameColumna) IsNot Nothing Then
    '                    TipoColumna = oHashColNivelItem(NameColumna)
    '                End If
    '                Select Case TipoColumna
    '                    Case "System.String"
    '                        dr(NameColumna) = ""
    '                    Case "System.Decimal"
    '                        dr(NameColumna) = 0
    '                    Case Else
    '                        dr(NameColumna) = ""
    '                End Select
    '            Else
    '                If dtResumenJoin.Columns(NameColumna) IsNot Nothing Then
    '                    dr(NameColumna) = ("" & drDatos(NameColumna)).ToString.Trim
    '                    drTemp(NameColumna) = ("" & drDatos(NameColumna)).ToString.Trim
    '                End If
    '            End If
    '        Next

    '        NORSCI = drDatos("NORSCI")
    '        drItemCosto = odtItemCostoJoin.Select("NORSCI='" & NORSCI & "'")

    '        If drItemCosto.Length > 0 Then
    '            For FILA_DR As Integer = 0 To drItemCosto.Length - 1
    '                If FILA_DR = 0 Then
    '                    'SOLO ACTUALIZAMOS DATOS A LA PRIMERA FILA
    '                    dr = CopiarDatosDetalleItem(drItemCosto(0), dr)
    '                    dtExportEmbarqueDet.Rows.Add(dr)
    '                Else
    '                    ' CREAMOS UNA NUEVA Y ACTUALIZAMOS LOS DATOS
    '                    dr = dtExportEmbarqueDet.NewRow
    '                    For Columna As Integer = 0 To dtExportEmbarqueDet.Columns.Count - 1
    '                        NameColumna = dtExportEmbarqueDet.Columns(Columna).ColumnName
    '                        dr(NameColumna) = drTemp(NameColumna)
    '                    Next
    '                    dr = CopiarDatosDetalleItem(drItemCosto(FILA_DR), dr)
    '                    dtExportEmbarqueDet.Rows.Add(dr)
    '                End If
    '            Next
    '        Else
    '            dtExportEmbarqueDet.Rows.Add(dr)
    '        End If
    '    Next

    '    dtExportEmbarqueDet.Columns.Remove("NORSCI_ITEM")

    '    dtExportEmbarqueDet.AcceptChanges()

    '    e.Result = dtExportEmbarqueDet.Copy
    'End Sub

    'Private Sub bgwProcesoReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcesoReport.RunWorkerCompleted
    '    Try
    '        Dim NPOI As New HelpClass_NPOI_SC
    '        Dim oLisParametros As New SortedList
    '        Dim dtExportEmbarqueDet As New DataTable
    '        oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
    '        oLisParametros(2) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
    '        oLisParametros(3) = "Hora:|" & Now.ToString("hh:mm:ss")
    '        oLisParametros(3) = "Rango Fecha:|" & dtpFecIni.Value.ToString("dd/MM/yyyy") & " al " & dtpFecFin.Value.ToString("dd/MM/yyyy")
    '        dtExportEmbarqueDet = CType(e.Result, DataTable)
    '        NPOI.ExportExcelGeneralReleaseEmbarcadoItem(dtExportEmbarqueDet, "LISTA DE EMBARQUES-DETALLE", oListColMerge, "NORSCI", oLisParametros)
    '        verGrafico(False)
    '    Catch ex As Exception
    '        verGrafico(False)
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try

    'End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      kdgvResumen.DataSource = Nothing
      UcSeguimiento.pLimpiar()
      If cmbCliente.pCodigo = 0 Then
        MessageBox.Show("Seleccione un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      txtEmbarque.Text = txtEmbarque.Text.Trim
      txtOS.Text = txtOS.Text.Trim
      GetFiltro()
      verGrafico(True)
      bgwProceso.RunWorkerAsync()
    Catch ex As Exception
      verGrafico(False)
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    End Try
  End Sub

  Private Sub kdgvResumen_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles kdgvResumen.SelectionChanged
    Try
      If Me.kdgvResumen.CurrentCellAddress.X >= 0 Then
        MostrarInfoEmbarque()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub MostrarInfoEmbarque()
    Dim CCMPN As String = cmbCompania.CCMPN_CodigoCompania
    Dim CDVSN As String = GetDivision(cmbCompania.CCMPN_CodigoCompania)
    Dim CCLNT As Decimal = cmbCliente.pCodigo
    Dim lint_indice As Integer = 0
    Dim NORSCI As Decimal = 0
    Dim NOPRCN As Decimal = 0
    If kdgvResumen.CurrentRow IsNot Nothing Then
      lint_indice = Me.kdgvResumen.CurrentCellAddress.Y
      NORSCI = Me.kdgvResumen.Item("NORSCI", lint_indice).Value
      NOPRCN = Me.kdgvResumen.Item("NOPRCN", lint_indice).Value
    End If
        UcSeguimiento.pActualizarInfoEmbarque(CCMPN, CDVSN, CCLNT, NORSCI)
  End Sub

  Private Function GetDivision(ByVal CCMPN As String) As String
    If CCMPN = "EZ" Then
      Return HelpClass.getSetting("DivisionEZ")
    Else
      Return ""
    End If
  End Function

 
End Class

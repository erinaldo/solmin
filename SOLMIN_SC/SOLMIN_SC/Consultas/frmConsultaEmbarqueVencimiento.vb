Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Public Class frmConsultaEmbarqueVencimiento
    Enum TipoReporte
        Regimen
        Tipocarga
        CartaFianza
    End Enum
    Private oTipoReporte As TipoReporte
    Private _ValorIntervalo As Int32 = 0
    Private _CodEscala As String = ""
    Private Sub frmConsultaEmbarqueVencimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            ConstruirTablaEscala()
            dtgRegimen.AutoGenerateColumns = False
            dtgCartaFianza.AutoGenerateColumns = False
            dtgTipoCarga.AutoGenerateColumns = False
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            LlenarFiltro()
            'dtpFin.Value = Now.AddMonths(1)
            rbRegimen.Checked = True
            VisualizarTabxOpcionSelec()
            'dtpInicio.Enabled = False
            'chkFecha_CheckedChanged(chkFecha, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LlenarFiltro()
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


        Dim dtEstadoCF As New DataTable
        dtEstadoCF = oclsEstado.Estado_CartaFianza
        Dim drCF As DataRow
        drCF = dtEstadoCF.NewRow
        drCF("DISPLAY") = "::TODOS::"
        drCF("VALUE") = "T"
        dtEstadoCF.Rows.InsertAt(drCF, 0)
        cboEstadoCF.DataSource = dtEstadoCF
        cboEstadoCF.DisplayMember = "DISPLAY"
        cboEstadoCF.ValueMember = "VALUE"
        cboEstadoCF.SelectedValue = "T"


    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim odtExportar As New DataTable
        Dim ListTitulo As New List(Of String)
        Dim LisFiltros As New List(Of SortedList)
        Dim itemSortedList As SortedList
        Try
            Select Case oTipoReporte
                Case TipoReporte.CartaFianza
                    odtExportar = Exportar_Grilla_CartaFianza()
                    ListTitulo.Add("VENCIMIENTO DE CARTA FIANZAS")
                    itemSortedList = New SortedList
                    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
                    LisFiltros.Add(itemSortedList)
                Case TipoReporte.Regimen
                    odtExportar = Exportar_Grilla_Regimen()
                    ListTitulo.Add("VENCIMIENTO DE REGÍMENES")
                    itemSortedList = New SortedList
                    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
                    LisFiltros.Add(itemSortedList)
                Case TipoReporte.Tipocarga
                    odtExportar = Exportar_Grilla_TipoCarga()
                    ListTitulo.Add("VENCIMIENTO DE CONTENEDORES")
                    itemSortedList = New SortedList
                    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
                    LisFiltros.Add(itemSortedList)
            End Select

            Dim oLisParametros As New SortedList
            Dim NPOI As New HelpClass_NPOI_SC
            Dim oListDtReport As New List(Of DataTable)
            oListDtReport.Add(odtExportar.Copy)
            'oLisParametros(1) = "Cliente :|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, 0, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Function Exportar_Grilla_Regimen() As DataTable

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim odtExportar As New DataTable
        Dim MdataColumna As String = ""
        Dim NameColumna As String = ""
        Dim TitleColumna As String = ""

        For Each Item As DataGridViewColumn In dtgRegimen.Columns
            If Item.Visible Then
                NameColumna = Item.Name
                TitleColumna = Item.HeaderText
                odtExportar.Columns.Add(NameColumna)
                Select Case NameColumna
                    Case "REG_FORSCI", "REG_FECINI", "REG_FECVEN"
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoFecha)
                    Case "DIAS_VENCIMIENTO_REG"
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoNumero)
                    Case Else
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoTexto)
                End Select
                odtExportar.Columns(NameColumna).Caption = MdataColumna
            End If
        Next
        Dim dr As DataRow
        For Each drDatos As DataGridViewRow In dtgRegimen.Rows
            dr = odtExportar.NewRow
            For Each dcColumna As DataColumn In odtExportar.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = drDatos.Cells(NameColumna).Value
            Next
            odtExportar.Rows.Add(dr)
        Next
        'odtExportar = LimpiarTituloDuplicado(odtExportar, "CLASIF_REG")
        'Dim oLisParametros As New SortedList
        'oLisParametros(1) = "Cliente :|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
        'If chkFecha.Checked = True Then
        '    oLisParametros(2) = String.Format("Desde | {0} Hasta {1}", dtpInicio.Value.ToShortDateString, dtpFin.Value.ToShortDateString)
        'End If
        'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtExportar, "VENCIMIENTO DE REGÍMENES", Nothing, oLisParametros)
        Return odtExportar
    End Function



    Private Function Exportar_Grilla_CartaFianza() As DataTable

        Dim otExportar As New DataTable

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim odtExportar As New DataTable
        Dim MdataColumna As String = ""
        Dim NameColumna As String = ""
        Dim TitleColumna As String = ""
        For Each Item As DataGridViewColumn In dtgCartaFianza.Columns
            If Item.Visible Then
                NameColumna = Item.Name
                TitleColumna = Item.HeaderText
                odtExportar.Columns.Add(NameColumna)
                Select Case NameColumna
                    Case "CF_ITTDOC", "DIAS_VENCIMIENTO_CF"
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoNumero)
                    Case "CF_FORSCI", "CF_FECEDC", "CF_FECVEN"
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoFecha)
                    Case Else
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoTexto)
                End Select
                odtExportar.Columns(NameColumna).Caption = MdataColumna
            End If
        Next
        Dim dr As DataRow
        For Each drDatos As DataGridViewRow In dtgCartaFianza.Rows
            dr = odtExportar.NewRow
            For Each dcColumna As DataColumn In odtExportar.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = drDatos.Cells(NameColumna).Value
            Next
            odtExportar.Rows.Add(dr)
        Next
        'odtExportar = LimpiarTituloDuplicado(odtExportar, "CLASIF_CF")

        'Dim oLisParametros As New SortedList
        'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
        'If chkFecha.Checked = True Then
        '    oLisParametros(2) = String.Format("Desde | {0} Hasta {1}", dtpInicio.Value.ToShortDateString, dtpFin.Value.ToShortDateString)
        'End If
        ' HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtExportar, "VENCIMIENTO DE CARTA FIANZAS", Nothing, oLisParametros)
        Return odtExportar
    End Function

    Private Function Exportar_Grilla_TipoCarga() As DataTable

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim odtExportar As New DataTable
        Dim MdataColumna As String = ""
        Dim NameColumna As String = ""
        Dim TitleColumna As String = ""
        For Each Item As DataGridViewColumn In dtgTipoCarga.Columns
            If Item.Visible Then
                NameColumna = Item.Name
                TitleColumna = Item.HeaderText
                odtExportar.Columns.Add(NameColumna)
                Select Case NameColumna
                    Case "TC_QCANTI", "DIAS_VENCIMIENTO_CONT"
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoNumero)
                    Case "TC_FORSCI", "TC_FECINI", "TC_FECVEN"
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoFecha)
                    Case Else
                        MdataColumna = NPOI_SC.FormatDato(TitleColumna, NPOI_SC.keyDatoTexto)
                End Select
                odtExportar.Columns(NameColumna).Caption = MdataColumna
            End If
        Next
        Dim dr As DataRow
        For Each drDatos As DataGridViewRow In dtgTipoCarga.Rows
            dr = odtExportar.NewRow
            For Each dcColumna As DataColumn In odtExportar.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = drDatos.Cells(NameColumna).Value
            Next
            odtExportar.Rows.Add(dr)
        Next
        'odtExportar = LimpiarTituloDuplicado(odtExportar, "CLASIF_CN")
        'Dim oLisParametros As New SortedList
        'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
        'If chkFecha.Checked = True Then
        '    oLisParametros(2) = String.Format("Desde | {0} Hasta {1}", dtpInicio.Value.ToShortDateString, dtpFin.Value.ToShortDateString)
        'End If
        Return odtExportar
        'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtExportar, "VENCIMIENTO DE CONTENEDORES", Nothing, oLisParametros)

    End Function


    Private Function LimpiarTituloDuplicado(ByVal odtExportar As DataTable, ByVal ColLimpiar As String) As DataTable
        Dim Clasificacion As String = ""
        Dim ClasificacionActual As String = ""
        If odtExportar.Rows.Count > 0 Then
            Clasificacion = odtExportar.Rows(0)(ColLimpiar).ToString.Trim
        End If
        For index As Integer = 1 To odtExportar.Rows.Count - 1
            ClasificacionActual = ("" & odtExportar.Rows(index)(ColLimpiar)).ToString.Trim
            If Clasificacion = ClasificacionActual Then
                odtExportar.Rows(index)(ColLimpiar) = ""
            Else
                Clasificacion = ("" & odtExportar.Rows(index)(ColLimpiar)).ToString.Trim
            End If
        Next
        Return odtExportar
    End Function


  

    Private Sub rbRegimen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRegimen.CheckedChanged
        Try
            VisualizarTabxOpcionSelec()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub rbCartaFianza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCartaFianza.CheckedChanged
        Try
            VisualizarTabxOpcionSelec()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub rbContenedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContenedor.CheckedChanged
        Try
            VisualizarTabxOpcionSelec()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub VisualizarTabxOpcionSelec()
        TabResultado.TabPages.Remove(TabPageCartaFianza)
        TabResultado.TabPages.Remove(TabPageTipoCarga)
        TabResultado.TabPages.Remove(TabPageRegimen)
        If rbRegimen.Checked Then
            lblCF.Visible = False
            cboEstadoCF.Visible = False
            oTipoReporte = TipoReporte.Regimen
            TabResultado.TabPages.Add(TabPageRegimen)
        ElseIf rbCartaFianza.Checked Then
            lblCF.Visible = True
            cboEstadoCF.Visible = True
            oTipoReporte = TipoReporte.CartaFianza
            TabResultado.TabPages.Add(TabPageCartaFianza)
        ElseIf rbContenedor.Checked Then
            lblCF.Visible = False
            cboEstadoCF.Visible = False
            oTipoReporte = TipoReporte.Tipocarga
            TabResultado.TabPages.Add(TabPageTipoCarga)
        End If
    End Sub

    Private Function DiferenciaFechas(ByVal FechaMayor As String) As Integer
        Dim DifReferencia As Int32 = 0
        Dim FechaMenor As String = Today.ToString("dd/MM/yyyy")
        Dim FechaMin As Date
        Dim FechaMax As Date
        If (Date.TryParse(FechaMenor, FechaMin) AndAlso Date.TryParse(FechaMayor, FechaMax)) Then
            DifReferencia = DateDiff(DateInterval.Day, FechaMin, FechaMax)
        End If
        Return DifReferencia
    End Function

    Private oListEscala As New List(Of beEscala)
    Private Sub ConstruirTablaEscala()
        oListEscala.Clear()
        Dim Max As Int32 = 0
        Dim Min As Int32 = 0
        Dim obeEscala As beEscala

        Max = 99999
        Min = 45
        obeEscala = New beEscala
        obeEscala.PSCODIGO = "T1"
        obeEscala.PNMAX = Max
        obeEscala.PNMIN = Min
        obeEscala.PSDESCRIPCION = "MAYOR A " & Min & " DÍAS"
        obeEscala.PNORDEN = 3
        obeEscala.PSOBS = "POR VENCER"
        oListEscala.Add(obeEscala)

        Max = 45
        Min = 30
        obeEscala = New beEscala
        obeEscala.PSCODIGO = "T2"
        obeEscala.PNMAX = Max
        obeEscala.PNMIN = Min
        obeEscala.PSDESCRIPCION = "ENTRE " & Min & " - " & Max & " DÍAS"
        obeEscala.PSOBS = "POR VENCER"
        obeEscala.PNORDEN = 2
        oListEscala.Add(obeEscala)

        Max = 30
        Min = 0
        obeEscala = New beEscala
        obeEscala.PSCODIGO = "T3"
        obeEscala.PNMAX = Max
        obeEscala.PNMIN = Min
        obeEscala.PSDESCRIPCION = "ENTRE " & Min & " - " & Max & " DÍAS"
        obeEscala.PSOBS = "POR VENCER"
        obeEscala.PNORDEN = 1
        oListEscala.Add(obeEscala)


        Max = -1
        Min = -9999999
        obeEscala = New beEscala
        obeEscala.PSCODIGO = "T4"
        obeEscala.PNMAX = Max
        obeEscala.PNMIN = Min
        obeEscala.PSDESCRIPCION = "Menor a 0 DÍAS"
        obeEscala.PSOBS = "VENCIDO"
        obeEscala.PNORDEN = 4
        oListEscala.Add(obeEscala)

    End Sub

    Private Function ObtenerClasificacionEscala(ByVal Valor As Decimal) As beEscala
        Dim ItemDescripcion As String = ""
        Dim oEscala As New beEscala
        For Each Item As beEscala In oListEscala
            If Valor > Item.PNMIN AndAlso Valor <= Item.PNMAX Then
                oEscala.PSDESCRIPCION = Item.PSDESCRIPCION
                oEscala.PSOBS = Item.PSOBS
                Exit For
            End If
        Next
        Return oEscala
    End Function

    Private Function ClasificarSegunDifFecha(ByVal odt As DataTable) As DataTable
        If odt.Columns("DIF_FECHA") Is Nothing Then
            odt.Columns.Add("DIF_FECHA", Type.GetType("System.Int32"))
        End If
        If odt.Columns("DES_CLASIFICACION") Is Nothing Then
            odt.Columns.Add("DES_CLASIFICACION", Type.GetType("System.String"))
        End If
        If odt.Columns("DES_OBSERVACION") Is Nothing Then
            odt.Columns.Add("DES_OBSERVACION", Type.GetType("System.String"))
        End If
        Dim oEscala As beEscala
        For Each Item As DataRow In odt.Rows
            Item("DIF_FECHA") = DiferenciaFechas(Item("FECVEN"))
            oEscala = ObtenerClasificacionEscala(Item("DIF_FECHA"))            
            Item("DES_CLASIFICACION") = oEscala.PSDESCRIPCION
            Item("DES_OBSERVACION") = oEscala.PSOBS
        Next
        Return odt
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


    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            dtgRegimen.DataSource = Nothing
            dtgCartaFianza.DataSource = Nothing
            dtgTipoCarga.DataSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If
    End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim PNPORVENCER As Decimal = 0
            Dim oEmbarque As New Negocio.clsEmbarque
            Dim PSCCMPN As String = GetCompania()
            Dim FechaIni As Decimal = 0
            Dim FechaFin As Decimal = 0
            'If chkFecha.Checked = True Then
            '    FechaIni = dtpInicio.Value.ToString("yyyyMMdd")
            '    FechaFin = dtpFin.Value.ToString("yyyyMMdd")
            'ElseIf chkFecha.Checked = False Then
            '    FechaIni = 0
            '    FechaFin = 99999999
            'End If
            FechaIni = 0
            FechaFin = 99999999

            'If chkVencimiento.Checked = True Then
            '    PNPORVENCER = 0
            'ElseIf chkVencimiento.Checked = False Then
            '    PNPORVENCER = 1
            'End If
            PNPORVENCER = 0
      Dim Cliente As Decimal = cmbCliente.pCodigo
      Dim Tipo_Operacion As String = cboTipoOperacion.SelectedValue
      If Tipo_Operacion = "0" Then
        Tipo_Operacion = ""
      End If
      Select Case oTipoReporte
        Case TipoReporte.CartaFianza
          Dim odt As New DataTable
                    odt = oEmbarque.Listar_CartaFianza_X_Vencer(PSCCMPN, Cliente, FechaIni, FechaFin, PNPORVENCER, Tipo_Operacion, cboEstadoCF.SelectedValue)
          odt = ClasificarSegunDifFecha(odt)
          dtgCartaFianza.DataSource = odt
        Case TipoReporte.Regimen
          Dim odt As New DataTable
          odt = oEmbarque.Listar_Regimen_X_Vencer(PSCCMPN, Cliente, FechaIni, FechaFin, PNPORVENCER, Tipo_Operacion)
          odt = ClasificarSegunDifFecha(odt)
          dtgRegimen.DataSource = odt
        Case TipoReporte.Tipocarga
          Dim odt As New DataTable
          odt = oEmbarque.Listar_TipoCarga_X_Vencer(PSCCMPN, Cliente, FechaIni, FechaFin, PNPORVENCER, Tipo_Operacion)
          odt = ClasificarSegunDifFecha(odt)
          dtgTipoCarga.DataSource = odt
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    End Try
  End Sub

    'Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    GroupFecha.Enabled = chkFecha.Checked
    'End Sub
End Class

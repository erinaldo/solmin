Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.clsTab
Imports System.Drawing
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO
Imports Microsoft.VisualBasic.Strings
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Reflection
'Imports SOLMIN_SC.Utilitario.HelpClassUtility
'Imports UTILITY = SOLMIN_SC.Utilitario.HelpClassUtility
Imports System.Collections.Specialized

Public Class FrmConsultaOAgencia
  Private dtPrincipal As New DataTable
  Private dtCheckPoint As New DataTable
    Private oTab As clsTab

  Function Formatear_Datos(ByVal dtResultado As DataTable) As DataTable
    Dim numFilas As Int32 = dtResultado.Rows.Count - 1
    Dim OSTemp As String = ""
    Dim oListOS As New Hashtable
    Dim dr() As DataRow
    Dim sbBL As New StringBuilder
    Dim listRepetido As New List(Of String)
    Dim bl As String = ""
    Dim textBl As String = ""
    Dim pos As Int32 = 0
    For FILA As Integer = 0 To numFilas
      If FILA <= numFilas Then
        OSTemp = ("" & dtResultado.Rows(FILA)("PNNMOS")).ToString.Trim
        If Not oListOS.Contains(OSTemp) Then
          oListOS.Add(OSTemp, OSTemp)
          sbBL.Length = 0
          listRepetido.Clear()
          dr = dtResultado.Select("PNNMOS='" & OSTemp & "'")
          For Each Item As DataRow In dr
            bl = ("" & Item("PCNMDC")).ToString.Trim
            If Not listRepetido.Contains(bl) Then
              listRepetido.Add(bl)
              sbBL.Append(Item("PCNMDC"))
              sbBL.Append(Chr(10))
            End If
          Next
          textBl = sbBL.ToString
          pos = textBl.LastIndexOf(Chr(10))
          textBl = textBl.Substring(0, pos)
          dtResultado.Rows(FILA)("PCNMDC") = textBl
        Else
          dtResultado.Rows.RemoveAt(FILA)
          FILA = FILA - 1
          numFilas = numFilas - 1
        End If
      End If
    Next
    Return dtResultado
  End Function
  Sub Buscar()

        dtgSegDatos.DataSource = Nothing
        dtgAgenciasDetalla.DataSource = Nothing
        dtgDetallaCostos.DataSource = Nothing
        dtgCheckPoint.DataSource = Nothing
        Limpiar_Datos()
        Dim objLogica As New Negocio.clsConsultaOAgencia()
        Dim objEntidad As New Entidad.beConsultaOAgencia()
        Dim dblFecIni, dblFecFin As Double
        dblFecIni = Format(Me.dtpInicio.Value, "yyyyMMdd")
        dblFecFin = Format(Me.dtpFin.Value, "yyyyMMdd")
        objEntidad.PSCCMPN = "FZ" 'Compania
        objEntidad.PNCCLNT = Me.cmbCliente.pCodigo
        objEntidad.PSCDVSN = "A" 'division
        objEntidad.PSCPLNDV = "1" 'planta
        objEntidad.PSPNNMOS = Me.txtFilOS.Text.Trim 'Orden de Servicio
        objEntidad.PNFINGRESO_MIN = dblFecIni
        objEntidad.PNFINGRESO_MAX = dblFecFin
        objEntidad.PSBL = Me.txtDocEmbarque.Text.Trim ' B/L
        Dim dtResultado As New DataTable
        dtResultado = objLogica.Lista_ConsultaOAgencia(objEntidad)
        dtResultado = Formatear_Datos(dtResultado)
        dtPrincipal = dtResultado.Copy
        dtgSegDatos.DataSource = Nothing
        dtgSegDatos.DataSource = dtResultado
        dtgSegDatos.Columns("DDREGI").DefaultCellStyle.Format = "dd/MM/yyyy"

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmConsultaOAgencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbCliente.pAccesoPorUsuario = True
            cmbCliente.pRequerido = True
            cmbCliente.pUsuario = HelpUtil.UserName
            dtgSegDatos.AutoGenerateColumns = False
            dtgAgenciasDetalla.AutoGenerateColumns = False
            dtgDetallaCostos.AutoGenerateColumns = False
            dtgCheckPoint.AutoGenerateColumns = False
            dtpInicio.Value = Now.AddMonths(-1)
            oTab = New clsTab
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Agencia_Detalle()
        dtgAgenciasDetalla.DataSource = Nothing
        Dim blClsImportarCostos As New clsImporCostos
        Dim oListItemAgenciaOrigen As New List(Of beDUAA1)
        Dim obeDUAA As New beDUAA
        If dtgSegDatos.Rows.Count > 0 Then
            Dim lint_indice As Integer = Me.dtgSegDatos.CurrentCellAddress.Y
            obeDUAA.PNNORDSR = Me.dtgSegDatos.Item("PNNMOS", lint_indice).Value
            obeDUAA.PNCZNFCC = Me.dtgSegDatos.Item("PNCDZO", lint_indice).Value
            oListItemAgenciaOrigen = blClsImportarCostos.ListarDetalleDUAA(obeDUAA)
        End If
        dtgAgenciasDetalla.DataSource = oListItemAgenciaOrigen
    End Sub

    Private Sub Cargar_Agencia_Costos()
        dtgDetallaCostos.DataSource = Nothing
        Dim blClsImportarCostos As New clsImporCostos
        Dim oItemAgenciaOrigen As beDUAA
        Dim obeDUAA As New beDUAA
        Dim ListDUAA As New List(Of beDUAA)
        If dtgSegDatos.Rows.Count > 0 Then
            Dim lint_indice As Integer = Me.dtgSegDatos.CurrentCellAddress.Y
            obeDUAA.PNNORDSR = Me.dtgSegDatos.Item("PNNMOS", lint_indice).Value
            obeDUAA.PNCZNFCC = Me.dtgSegDatos.Item("PNCDZO", lint_indice).Value
            oItemAgenciaOrigen = blClsImportarCostos.ListarCabeceraDUAA(obeDUAA)
            If oItemAgenciaOrigen IsNot Nothing Then
                ListDUAA.Add(oItemAgenciaOrigen)
            End If
        End If     
        dtgDetallaCostos.DataSource = ListDUAA
    End Sub

    Private Function FormatearFecha(ByVal oFecha As Object) As String
        Dim FechaText As String = ""
        Dim FechaIn As Date
        FechaText = ("" & oFecha).ToString.Trim
        If Date.TryParse(FechaText, FechaIn) = True Then
            FechaText = FechaIn.ToShortDateString
        Else
            FechaText = ""
        End If
        Return FechaText
    End Function

    Private Sub Cargar_Agencia_CheckPoint()

        dtgCheckPoint.DataSource = Nothing

        Dim objLogica As New Negocio.clsConsultaOAgencia()
        Dim objEntidad As New Entidad.beConsultaOAgencia()
        Dim dtfin As New DataTable
        If dtgSegDatos.Rows.Count > 0 Then
            Dim lint_indice As Integer = Me.dtgSegDatos.CurrentCellAddress.Y
            objEntidad.PNCCLNT = Me.cmbCliente.pCodigo
            objEntidad.PSPNCDTR = Me.dtgSegDatos.Item("PNCDTR", lint_indice).Value
            Dim dtResultado1 As New DataTable
            dtResultado1 = objLogica.Lista_ConsultaOAgencia_Checkpoint(objEntidad)
            If dtResultado1.Rows.Count > 0 Then

                dtfin.Columns.Add("CHECKPOINT", Type.GetType("System.String"))
                dtfin.Columns.Add("FECHA_REAL", Type.GetType("System.String"))
                dtfin.Columns.Add("ORDEN", Type.GetType("System.Int32"))

                Dim drTemp As DataRow = dtResultado1.Rows(0)
                Dim dr As DataRow = dtfin.NewRow()

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "FECHA EMBARQUE"
                dr("FECHA_REAL") = FormatearFecha(drTemp("EMBARQUE_CHK"))
                dr("ORDEN") = 1
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "FECHA LLEGADA"
                dr("FECHA_REAL") = FormatearFecha(drTemp("LLEGADA_CHK"))
                dr("ORDEN") = 2
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "VOLANTE"
                dr("FECHA_REAL") = FormatearFecha(drTemp("VOLANTE_CHK"))
                dr("ORDEN") = 3
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "AFORO PREVIO"
                dr("FECHA_REAL") = FormatearFecha(drTemp("PREVIO_CHK"))
                dr("ORDEN") = 4
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "CARGA DISCREPANCIA"
                dr("FECHA_REAL") = FormatearFecha(drTemp("CARGA_DISCREPANCIA_CHK"))
                dr("ORDEN") = 5
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "NUMERACIÓN DUA"
                dr("FECHA_REAL") = FormatearFecha(drTemp("NUMERACION_CHK"))
                dr("ORDEN") = 6
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "PAGO DERECHO"
                dr("FECHA_REAL") = FormatearFecha(drTemp("PAGO_DERECHO_CHK"))
                dr("ORDEN") = 7
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "AFORO FÍSICO"
                dr("FECHA_REAL") = FormatearFecha(drTemp("AFORO_FISICO_CHK"))
                dr("ORDEN") = 8
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "LEVANTE"
                dr("FECHA_REAL") = FormatearFecha(drTemp("LEVANTE_CHK"))
                dr("ORDEN") = 9
                dtfin.Rows.Add(dr)

                dr = dtfin.NewRow()
                dr("CHECKPOINT") = "ENTREGA ALMACÉN"
                dr("FECHA_REAL") = FormatearFecha(drTemp("ENTREGA_ALMACEN_CHK"))
                dr("ORDEN") = 10
                dtfin.Rows.Add(dr)

                dtCheckPoint = dtfin.Copy
            End If
            dtgCheckPoint.DataSource = dtfin
        End If
    End Sub

    Private Sub Cargar_Datos_Orden()
        If dtgSegDatos.Rows.Count > 0 Then
            Dim lint_indice As Integer = dtgSegDatos.CurrentCellAddress.Y
            txtTI.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DESPACHO", lint_indice).Value)
            txtOrdenServicioAgencias.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("PNNMOS", lint_indice).Value)
            txtDesMercaderia.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCDSME", lint_indice).Value)
            txtTipoServicioAduana.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCTPOS", lint_indice).Value)
            txtFecha.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DDREGI", lint_indice).Value).Substring(0, 10)
            txtOperación.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCDSOP", lint_indice).Value)
            txtVapor.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCNAVE", lint_indice).Value)
            txtDeposito.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCDSAB", lint_indice).Value)
            txtTipoBulto.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCBLTO", lint_indice).Value)
            txtLiquidador.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCDSCD", lint_indice).Value)
            txtNumDUA.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCDUIDUE", lint_indice).Value)
            txtRegimen.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("DCDSRG", lint_indice).Value)
            txtDocumentoBL.Text = HelpClass.ToStringCvr(dtgSegDatos.Item("PCNMDC", lint_indice).Value)
        Else
            Limpiar_Datos()
        End If
      
    End Sub

    Private Sub dtgSegAduaneroReducido_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSegDatos.SelectionChanged
        Try
            If Me.dtgSegDatos.CurrentCellAddress.X > -1 Then
                oTab = New clsTab
                dtgAgenciasDetalla.DataSource = Nothing
                dtgDetallaCostos.DataSource = Nothing
                dtgCheckPoint.DataSource = Nothing
                Limpiar_Datos()
                Cargar_Informacion_Embarque()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Limpiar_Datos()
        Me.txtTI.Clear()
        Me.txtOrdenServicioAgencias.Clear()
        Me.txtDesMercaderia.Clear()
        Me.txtTipoServicioAduana.Clear()
        Me.txtFecha.Clear()
        Me.txtOperación.Clear()
        Me.txtVapor.Clear()
        Me.txtDeposito.Clear()
        Me.txtTipoBulto.Clear()
        Me.txtLiquidador.Clear()
        Me.txtNumDUA.Clear()
        Me.txtRegimen.Clear()
        Me.txtDocumentoBL.Clear()
    End Sub


    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        Try
            If dtgSegDatos.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim lstrPeriodo As String = ""
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            For Each Item As DataGridViewColumn In dtgSegDatos.Columns
                ColTitle = Item.HeaderText.Trim
                ColName = Item.DataPropertyName
                TipoDato = ""
                If Item.Visible = True Then
                    Select Case ColName
                        'FCHAS
                        Case "DDREGI"
                            TipoDato = NPOI_SC.keyDatoFecha
                            'TEXTO
                        Case Else
                            TipoDato = NPOI_SC.keyDatoTexto

                    End Select
                    dtExport.Columns.Add(ColName)
                    MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                    dtExport.Columns(ColName).Caption = MdataColumna
                End If
            Next

            Dim a As Int32 = dtExport.Columns.Count

            Dim dr As DataRow
            For Fila As Integer = 0 To dtgSegDatos.Rows.Count - 1
                dr = dtExport.NewRow
                For Columna As Integer = 0 To dtExport.Columns.Count - 1
                    ColName = dtExport.Columns(Columna).ColumnName
                    If (dtgSegDatos.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                        dr(ColName) = dtgSegDatos.Rows(Fila).Cells(ColName).FormattedValue
                    End If
                Next
                dtExport.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(1) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(2) = "Hora:|" & Now.ToString("hh:mm:ss")


            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExport.Copy)


            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("ORDENES DE SERVICIO DE AGENCIAS")


            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListColCeldaNFilas As New List(Of String)
            ListColCeldaNFilas.Add("PCNMDC")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, ListColCeldaNFilas, LisFiltros, 1, Nothing)

            'NPOI.ExportExcel_Agencia(dtExport, "ORDENES DE SERVICIO DE AGENCIAS", oLisParametros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Informacion_Embarque()
        Dim TabActivo As Int32 = TabControl1.SelectedIndex
        Dim TabName = TabControl1.TabPages(TabActivo).Name
        If Not oTab.Tab_Cargado(TabActivo) Then
            Me.Cursor = Cursors.WaitCursor
            Select Case TabName
                Case "TabOrdenesAgencia"
                    Cargar_Agencia_Detalle()
                Case "TabDatosAgencia"
                    Cargar_Datos_Orden()
                Case "TabCostos"
                    Cargar_Agencia_Costos()
                Case "TabCheckpoint"
                    Cargar_Agencia_CheckPoint()
            End Select
            oTab.Cargar_Tab(TabActivo)
            Me.Cursor = Cursors.Default
        End If

    End Sub

  Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    Try
      Cargar_Informacion_Embarque()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class

Imports System.Web
Imports System.Object
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Windows.Forms

Public Class ucTarifarioContabilidad

#Region "Propiedades"
    Private _pUsuario As String = "SOLMIN"
    Private _pCarga As String = "0"
    Public Property Usuario() As String
        'Obligatorio
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property
    Public Property pCarga() As String
        'Obligatorio
        Get
            Return _pCarga
        End Get
        Set(ByVal value As String)
            _pCarga = value
        End Set
    End Property
#End Region
    Private oPlanta As clsPlantaNeg = New clsPlantaNeg
    Private oCompania As clsCompaniaNeg = New clsCompaniaNeg
    Private oDivision As clsDivisionNeg = New clsDivisionNeg
    Private oMoneda As clsMonedaNeg = New clsMonedaNeg
    Private oFiltro As Filtro = New Filtro
    Private oTarifarioNeg As clsTarifarioNeg = New clsTarifarioNeg
    Private oTarifario As Tarifario = New Tarifario
    Private bolBuscar As Boolean = False

    Private Sub ucTarifarioContabilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _pCarga = "1" Then
            Carga_Inicial()
        End If
    End Sub
    Private Sub Carga_Inicial()
        Dim objCompania As New clsCompaniaNeg
        Dim objDivision As New clsDivisionNeg
        Dim objPlanta As New clsPlantaNeg
        objCompania.Crea_Lista(_pUsuario)
        'HttpRuntime.Cache.Insert("Compania", objCompania)
        objDivision.Crea_Lista(_pUsuario)
        'HttpRuntime.Cache.Insert("Division", objDivision)
        objPlanta.Crea_Lista(_pUsuario)
        'HttpRuntime.Cache.Insert("Planta", objPlanta)
        oDivision = New clsDivisionNeg
        oDivision.Lista = objDivision.Lista.Copy 'DirectCast(HttpRuntime.Cache.Get("Division"), clsDivisionNeg).Lista.Copy
        oCompania = New clsCompaniaNeg
        oCompania.Lista = objCompania.Lista.Copy 'DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompaniaNeg).Lista.Copy
        oPlanta = New clsPlantaNeg
        oPlanta.Lista = objPlanta.Lista.Copy 'DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlantaNeg).Lista.Copy
        oMoneda = New clsMonedaNeg
        oFiltro = New Filtro
        oTarifario = New Tarifario
        oTarifarioNeg = New clsTarifarioNeg
        bolBuscar = False
        'Cargar_Clientes()
        Cargar_Compania()
        Cargar_Moneda()
        Crear_Grilla_Tarifario()
        Cargar_Division()
        bolBuscar = True
    End Sub
    Private Sub Cargar_Compania()
        cmbCompania.DataSource = oCompania.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        cmbCompania.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Moneda()
        oMoneda.Crea_Moneda()
        cmbMoneda.DataSource = oMoneda.Lista_Moneda_x_All(0)
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.DisplayMember = "TMNDA"
    End Sub

    Private Sub Cargar_Cliente_Usuario()
        UcClienteGrupo.pUsuario = _pUsuario 'ConfigurationWizard.UserName
    End Sub

#Region "Crear Grilla Tarifario"

    Private Sub Crear_Grilla_Tarifario()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCNTRT"
        oDcTx.HeaderText = "Contrato"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifario.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SERVICIO"
        oDcTx.HeaderText = "Servicio"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifario.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TPLNTA"
        oDcTx.HeaderText = "Planta"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifario.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TARIFA"
        oDcTx.HeaderText = "Tarifa"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgTarifario.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONEDA"
        oDcTx.HeaderText = "Moneda"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgTarifario.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONTO"
        oDcTx.HeaderText = "Monto"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgTarifario.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "DESCRIPCION"
        oDcTx.HeaderText = "Descripcion"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgTarifario.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TOBS"
        oDcTx.HeaderText = "Observaciones"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.False
        oDcTx.ReadOnly = True
        Me.dtgTarifario.Columns.Add(oDcTx)
    End Sub

#End Region

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
    End Sub

    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbDivision.DataSource = oDivision.Lista_Division_x_All(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
        End If
    End Sub

    Private Sub Cargar_Planta()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            'cmbPlanta.DataSource = oPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
            cmbPlanta.DataSource = oPlanta.Lista_Planta_Division(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
            cmbPlanta.ValueMember = "CPLNDV"
            bolBuscar = True
            cmbPlanta.DisplayMember = "TPLNTA"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Cliente_Usuario()
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Crear_Tarifario()
    End Sub

    Private Sub Crear_Tarifario()
        Limpiar_Tarifario()
        Listar_Tarifas()
    End Sub

    Private Sub Listar_Tarifas()
        Try
            Dim oDt As DataTable
            Dim intCont As Integer

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oFiltro.Parametro1 = Me.cmbCompania.SelectedValue.ToString.Trim
            oFiltro.Parametro2 = IIf(Me.cmbDivision.SelectedValue.ToString.Trim = "-1", "%", Me.cmbDivision.SelectedValue.ToString.Trim)
            oFiltro.Parametro3 = UcClienteGrupo.pCodigoGrupo 'Me.cmbCliente.SelectedValue.ToString.Trim 'UcCliente.pCodigo.ToString
            oFiltro.Parametro4 = Me.cmbMoneda.SelectedValue.ToString.Trim
            oFiltro.Parametro5 = Me.cmbPlanta.SelectedValue.ToString.Trim

            oDt = oTarifarioNeg.Lista_Tarifario(oFiltro)
            For intCont = 0 To oDt.Rows.Count - 1
                Agregar_Row_Tarifa()
                With Me.dtgTarifario.Rows(intCont)
                    .Cells(0).Value = oDt.Rows(intCont).Item("NCNTRT").ToString.Trim
                    .Cells(1).Value = oDt.Rows(intCont).Item("SERVICIO").ToString.Trim
                    .Cells(2).Value = oDt.Rows(intCont).Item("TPLNTA").ToString.Trim
                    .Cells(3).Value = Generar_Tarifa(oDt.Rows(intCont))
                    .Cells(4).Value = oDt.Rows(intCont).Item("TSGNMN").ToString.Trim
                    .Cells(5).Value = Format(CType(oDt.Rows(intCont).Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.000")
                    .Cells(6).Value = Generar_Descripcion(oDt.Rows(intCont))
                    .Cells(7).Value = oDt.Rows(intCont).Item("TOBS").ToString.Trim
                End With
            Next intCont
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message)
        End Try
        'Cargamos el Detalle
        ListarClienteGrupo()

    End Sub

    Private Sub ListarClienteGrupo()
        Dim dt As DataTable
        Dim intCont As Integer
        Try
            dt = oTarifarioNeg.Busca_Cliente_Grupo(UcClienteGrupo.pCodigoGrupo)
            For intCont = 0 To dt.Rows.Count - 1
                Agregar_Row_ClienteGrupo()
                With Me.dtgClienteGrupo.Rows(intCont)
                    .Cells(0).Value = dt.Rows(intCont).Item("CCLNT").ToString.Trim
                    .Cells(1).Value = dt.Rows(intCont).Item("TCMPCL").ToString.Trim
                    .Cells(2).Value = dt.Rows(intCont).Item("TMTVBJ").ToString.Trim
                    .Cells(3).Value = dt.Rows(intCont).Item("NRUC").ToString.Trim
                    .Cells(4).Value = dt.Rows(intCont).Item("TDRCCB").ToString.Trim

                End With
            Next intCont
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Limpiar_Tarifario()
        Me.dtgTarifario.Rows.Clear()
        Me.dtgClienteGrupo.Rows.Clear()
    End Sub

    Private Sub Agregar_Row_Tarifa()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgTarifario)
        Me.dtgTarifario.Rows.Add(oDrVw)
    End Sub

    Private Sub Agregar_Row_ClienteGrupo()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgClienteGrupo)
        Me.dtgClienteGrupo.Rows.Add(oDrVw)
    End Sub

    Private Function Generar_Tarifa(ByVal poRow As DataRow) As String
        Dim strTarifa As String = ""

        With poRow
            'If .Item("COSTOS").ToString.Trim = "" Then
            '    strTarifa = .Item("TSGNMN").ToString.Trim
            '    strTarifa = strTarifa & " " & Format(CType(.Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.00")
            'End If
            'If .Item("COSTOS").ToString.Trim <> "" Then
            '    strTarifa = Double.Parse(.Item("IVLSRV").ToString.Trim) * 100
            '    strTarifa = strTarifa & " % del " & .Item("COSTOS").ToString.Trim
            'End If
            strTarifa = .Item("TSGNMN").ToString.Trim
            strTarifa = strTarifa & " " & Format(CType(.Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.000")
            If .Item("VALCTE").ToString.Trim > 1 Then
                strTarifa = strTarifa & " por " & Format(CType(.Item("VALCTE").ToString.Trim, Double), "###,###,###,##0")
            Else
                If .Item("VALCTE").ToString.Trim = 1 And .Item("VALMIN").ToString.Trim = 0 And .Item("VALMAX").ToString.Trim = 0 Then
                    strTarifa = strTarifa & " por"
                End If
            End If
            If .Item("VALMIN").ToString.Trim > 0 Then
                strTarifa = strTarifa & " de " & Format(CType(.Item("VALMIN").ToString.Trim, Double), "###,###,###,##0")
            End If
            If .Item("VALMAX").ToString.Trim > 0 Then
                strTarifa = strTarifa & " a " & Format(CType(.Item("VALMAX").ToString.Trim, Double), "###,###,###,##0")
            End If
            If .Item("MEDIDA").ToString.Trim <> "" Then
                strTarifa = strTarifa & " " & .Item("MEDIDA").ToString.Trim
            End If
            strTarifa = strTarifa & " " & .Item("DESRNG").ToString.Trim
            'If .Item("VEHICULO").ToString.Trim <> "" Then
            '    strTarifa = strTarifa & " utilizando " & .Item("VEHICULO").ToString.Trim
            'End If
            'If .Item("COSTOS").ToString.Trim <> "" Then
            '    strTarifa = strTarifa & " (" & .Item("TSGNMN").ToString.Trim & ")"
            'End If
            If .Item("STPTRA").ToString.Trim = "F" Then
                strTarifa = strTarifa & " (Fijo)"
            End If
        End With
        Return strTarifa
    End Function

    Private Function Generar_Descripcion(ByVal poRow As DataRow) As String
        Dim strTarifa As String = ""

        With poRow

            If .Item("VALCTE").ToString.Trim > 1 Then
                strTarifa = strTarifa & " por " & Format(CType(.Item("VALCTE").ToString.Trim, Double), "###,###,###,##0")
            Else
                If .Item("VALCTE").ToString.Trim = 1 And .Item("VALMIN").ToString.Trim = 0 And .Item("VALMAX").ToString.Trim = 0 Then
                    strTarifa = strTarifa & " por"
                End If
            End If
            If .Item("VALMIN").ToString.Trim > 0 Then
                strTarifa = strTarifa & " de " & Format(CType(.Item("VALMIN").ToString.Trim, Double), "###,###,###,##0")
            End If
            If .Item("VALMAX").ToString.Trim > 0 Then
                strTarifa = strTarifa & " a " & Format(CType(.Item("VALMAX").ToString.Trim, Double), "###,###,###,##0")
            End If
            If .Item("MEDIDA").ToString.Trim <> "" Then
                strTarifa = strTarifa & " " & .Item("MEDIDA").ToString.Trim
            End If
            strTarifa = strTarifa & " " & .Item("DESRNG").ToString.Trim

            If .Item("STPTRA").ToString.Trim = "F" Then
                strTarifa = strTarifa & " (Fijo)"
            End If
        End With
        Return strTarifa
    End Function

    Private Sub pExportarExcel(ByVal pstrTitulo As String, ByVal plinea1 As String, ByVal plinea2 As String, ByVal drvRows As DataGridViewRowCollection, ByVal pdtgDatos As DataGridView)
        If pdtgDatos.Rows.Count > 0 Then
            Dim objListColumns As New List(Of String)
            Dim objListColumnsHide As New List(Of Boolean)
            Try
                With pdtgDatos
                    For i As Int16 = 0 To .Columns.Count - 1
                        If .Columns(i).HeaderText <> "" Then
                            objListColumns.Add(.Columns(i).HeaderText)
                            objListColumnsHide.Add(.Columns(i).Visible)
                        End If
                    Next i
                End With
                ' Exportar
                Call pExportar(pstrTitulo, plinea1, plinea2, drvRows, objListColumns, objListColumnsHide)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                objListColumns = Nothing
                objListColumnsHide = Nothing
            End Try
        End If
    End Sub

    Public Sub pExportar(ByVal strTitulo As String, ByVal linea1_ As String, ByVal linea2_ As String, ByVal drvRows As DataGridViewRowCollection, _
                        ByVal objListColumns As List(Of String), ByVal objListColumnsHide As List(Of Boolean))
        Dim oExcel As Object
        Dim oBook As Object
        Dim oBooks As Object
        Dim oWorksheet As Object
        Dim objType As Type
        Dim intHeaders As Int32
        Dim intHeaders1 As Int32
        Dim intRow As Int32
        Dim i As Int32
        Dim j As Int32
        'Dim intIndice As Integer
        Dim intContador As Int16
        Try
            ' Validamos que la coleccion de filas no sea nothing
            If Not drvRows Is Nothing Then
                ' Iniciamos Excel y abrimos un libro
                objType = Type.GetTypeFromProgID("Excel.Application")
                oExcel = Activator.CreateInstance(objType)
                oExcel.Visible = False
                oBooks = oExcel.Workbooks
                oBook = oBooks.Open(Application.StartupPath & "\SOLMIN_Contrato.xlt")

                ' Asignamos el objeto Sheet
                oWorksheet = oBook.ActiveSheet

                ' Contamos las columnas q son visibles
                For i = 0 To objListColumnsHide.Count - 1
                    If objListColumnsHide(i) Then
                        intHeaders += 1
                    Else
                        intHeaders1 += 1
                    End If
                Next
                ' Ejecutamos macro, enviamos las columnas y valores
                oBook.MuestraGrid(strTitulo, linea1_, linea2_, intHeaders, drvRows.Count)
                ' Agregar las columnas
                intRow = 5
                For i = 0 To objListColumnsHide.Count - 1 'intHeaders - 1
                    If objListColumnsHide(i) Then
                        oWorksheet.Cells(5, intContador + 3).Value = objListColumns(i) 'mdtTablaMaster.Columns(i).ColumnName
                        intContador += 1
                    End If
                Next
                For i = 0 To objListColumnsHide.Count - 1
                    oWorksheet.columns(i + 3).ColumnWidth = 15
                Next i
                intRow = 6
                For i = 0 To drvRows.Count - 1
                    intContador = 0

                    ' Cargar la data
                    For j = 0 To objListColumnsHide.Count - 1 'intHeaders - 1
                        If objListColumnsHide(j) Then
                            If Not drvRows.Item(i).Cells(j).Value = Nothing Then
                                Select Case Me.dtgTarifario.Columns(j).Name.ToString.Trim
                                    Case "MONEDA", "MONTO"
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Replace(Chr(13) & Chr(10), Chr(10))
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4152 'xlRight
                                        intContador += 1
                                    Case Else
                                        oWorksheet.Cells(intRow + i, intContador + 3).Value = drvRows.Item(i).Cells(j).FormattedValue.ToString.Replace(Chr(13) & Chr(10), Chr(10))
                                        oWorksheet.Cells(intRow + i, intContador + 3).WrapText = False
                                        oWorksheet.Cells(intRow + i, intContador + 3).VerticalAlignment = -4108 'xlCenter
                                        oWorksheet.Cells(intRow + i, intContador + 3).HorizontalAlignment = -4131 'xlLeft
                                        intContador += 1
                                End Select
                            Else
                                oWorksheet.Cells(intRow + i, intContador + 3).Value = ""
                                intContador += 1
                            End If
                        End If
                    Next j
                Next i
            End If
            oExcel.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Eliminamos los objetos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
            oBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
            oBooks = Nothing
            'oExcel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
            oExcel = Nothing
            oExcel = Nothing
            oBook = Nothing
            oBooks = Nothing
            oWorksheet = Nothing
        End Try
    End Sub

    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "001"
        Dim oDt As DataTable

        oFiltro.Parametro1 = Me.cmbCompania.SelectedValue.ToString.Trim
        oFiltro.Parametro2 = IIf(Me.cmbDivision.SelectedValue.ToString.Trim = "-1", "%", Me.cmbDivision.SelectedValue.ToString.Trim)
        oFiltro.Parametro3 = UcClienteGrupo.pCodigoGrupo 'Me.cmbCliente.SelectedValue.ToString.Trim 'UcCliente.pCodigo.ToString
        oFiltro.Parametro4 = Me.cmbMoneda.SelectedValue.ToString.Trim
        oFiltro.Parametro5 = Me.cmbPlanta.SelectedValue.ToString.Trim

        oDt = oTarifarioNeg.Lista_Tarifario(oFiltro)
        '----------------------------------------------------------
        Dim dtNuevo As System.Data.DataTable = New System.Data.DataTable
        Dim colNueva As System.Data.DataColumn
        Dim filaNueva As System.Data.DataRow
        Dim numCols As Integer

        For Each dataGridViewCol As DataGridViewColumn In dtgTarifario.Columns
            colNueva = New System.Data.DataColumn(dataGridViewCol.Name)
            dtNuevo.Columns.Add(colNueva)
        Next
        numCols = dtNuevo.Columns.Count

        For intCont As Integer = 0 To oDt.Rows.Count - 1
            filaNueva = dtNuevo.NewRow()
            With Me.dtgTarifario.Rows(intCont)
                filaNueva(0) = oDt.Rows(intCont).Item("NCNTRT").ToString.Trim
                filaNueva(1) = oDt.Rows(intCont).Item("SERVICIO").ToString.Trim
                filaNueva(2) = oDt.Rows(intCont).Item("TPLNTA").ToString.Trim
                filaNueva(3) = Generar_Tarifa(oDt.Rows(intCont))
                filaNueva(4) = oDt.Rows(intCont).Item("TSGNMN").ToString.Trim
                filaNueva(5) = Format(CType(oDt.Rows(intCont).Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.000")
                filaNueva(6) = Generar_Descripcion(oDt.Rows(intCont))
                filaNueva(7) = oDt.Rows(intCont).Item("TOBS").ToString.Trim
            End With
            dtNuevo.Rows.Add(filaNueva)
        Next intCont
        dtNuevo.Columns.Remove("TARIFA")
        '----------------------------------------------------------



        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mpGenerarXLS.mpGenerarXLS(strReporteseleccionado, dtNuevo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub





End Class

Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports Ransa.Utilitario
'Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class frmConsumoNeumatico

#Region "Atributos"
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private oDtEstado As DataTable
    Private obj_Logica As New ConsumoNeumatico_BLL
    Private obj_EntidadCN As ConsumoNeumatico
#End Region

#Region "Eventos"
    Private Sub frmConsumoNeumatico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
            Me.Cargar_Compania()
            ndAnio.Minimum = 0
            ndAnio.Maximum = HelpClass.TodayAnio
            ndAnio.Value = HelpClass.TodayAnio
            MostrarMeses_x_Anio()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If Me.ndAnio.Value = 0 Then
            MsgBox("Debe seleccionar Año. ", vbCritical)
            Exit Sub
        End If
        If Me.dbMes.SelectedValue = "" Then
            MsgBox("Debe seleccionar Mes. ", vbCritical)
            Exit Sub
        End If
        Me.Listar_Mes_Anio()
        Listar_Vehiculos()
        Listar_Cuadro_Costo()
    End Sub

    Private Sub btnImportarExcelCosto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImportarExcelCosto.Click
        Dim ofrmImportarConsumo As New frmImportarConsumo
        With ofrmImportarConsumo
            .Flag = 1
            .Text = "Importar Costo Neumático de Excel"
            .lblCompania.Text = cboCompania.Text
            .Compania = cboCompania.SelectedValue
        End With
        If ofrmImportarConsumo.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim lint_indice As Integer = Me.dgwDatos.CurrentCellAddress.Y
        Listar_Mes_Anio()
        Listar_Vehiculos()
        Listar_Cuadro_Costo()

        tbVehiculo.SelectTab(0)

    End Sub

    Private Sub dgwDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDatos.CellClick
        If e.RowIndex < 0 Or Me.dgwDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Listar_Vehiculos()
        Listar_Cuadro_Costo()
    End Sub

    Private Sub dgwDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgwDatos.CurrentCellChanged
        If Me.dgwDatos.RowCount <= 0 Then
            Exit Sub
        End If
        Listar_Vehiculos()
        Listar_Cuadro_Costo()
    End Sub

    Private Sub dgwDatos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwDatos.KeyUp
        If Me.dgwDatos.RowCount <= 0 Then
            Exit Sub
        End If
        Listar_Vehiculos()
        Listar_Cuadro_Costo()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImportarExcelCostoOpe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarExcelCostoOpe.Click
        If Me.dgwDatos.RowCount = 0 OrElse Me.dgwDatos.CurrentRow.Selected = False Then Exit Sub
        Dim lint_Indice_A As Integer = Me.dgwDatos.CurrentCellAddress.Y
        Dim FecReg As String = Me.dgwDatos.Item("sFECREG", lint_Indice_A).Value.ToString()

        Dim ofrmOpcionOperacionGuia As New frmOpcionOperacionGuia
        With ofrmOpcionOperacionGuia
            .FechaInicio = FecReg + "01"
            .Compania = cboCompania.SelectedValue()
            .Registro = "N"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Listar_Cuadro_Costo()
                tbVehiculo.SelectTab(1)
            End If
        End With
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.dgwDatos.RowCount = 0 OrElse Me.dgwDatos.CurrentRow.Selected = False Then Exit Sub
        Dim lint_Indice_A As Integer = Me.dgwDatos.CurrentCellAddress.Y
        Dim FecReg As String = Me.dgwDatos.Item("sFECREG", lint_Indice_A).Value.ToString()
        If MsgBox("Desea eliminar el Consumo de Neumatico del Mes de " + dgwDatos.Item(2, lint_Indice_A).Value + " del " + dgwDatos.Item(1, lint_Indice_A).Value, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim obj_Entidad As New ConsumoNeumatico
        obj_Entidad.FECREG = FecReg
        obj_Entidad.CCMPN = cboCompania.SelectedValue()
        If obj_Logica.Eliminar_Consumo_Neumatico(obj_Entidad).NCONEU = 1 Then
            Me.Listar_Mes_Anio()
            Listar_Vehiculos()
            Listar_Cuadro_Costo()
        End If
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        'If dgwDatos.RowCount = 0 Then Exit Sub
        Exportar_Excel_Consumo_Neumatico()
    End Sub

#End Region

#Region "Métodos y Funciones"

    Private Sub Cargar_Compania()
        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        Me.cboCompania.DataSource = objCompaniaBLL.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        cboCompania.SelectedValue = "EZ"
        bolBuscar = True
        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If
        'Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub Listar_Mes_Anio()
        Dim olConsumoNeumatico As New List(Of ConsumoNeumatico)
        Dim objParametro As New Hashtable
        If Me.dbMes.SelectedValue.ToString.Trim = "00" Then
            objParametro.Add("TIPO", "T")
            objParametro.Add("FECREG", 0)
            objParametro.Add("ANIO", Me.ndAnio.Value.ToString())
            objParametro.Add("CCMPN", cboCompania.SelectedValue)
        Else
            objParametro.Add("TIPO", "N")
            objParametro.Add("FECREG", Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01"))
            objParametro.Add("ANIO", 0)
            objParametro.Add("CCMPN", cboCompania.SelectedValue)
        End If

        Me.dgwDatos.Rows.Clear()
        For Each obeConNeuMesAnio As ConsumoNeumatico In obj_Logica.Listar_Importe_Soles_X_Mes_Anio(objParametro)
            Dim dgvrConNeu As DataGridViewRow
            dgvrConNeu = New DataGridViewRow
            dgvrConNeu.CreateCells(Me.dgwDatos)
            dgvrConNeu.Cells(0).Value = obeConNeuMesAnio.FECREG
            dgvrConNeu.Cells(1).Value = obeConNeuMesAnio.FECREG.ToString().Trim().Substring(0, 4) 'obeConNeuMesAnio.ANIO
            dgvrConNeu.Cells(2).Value = MonthName(Convert.ToInt32(HelpClass.CNumero_a_Fecha(obeConNeuMesAnio.FECREG).Month), False).ToUpper
            dgvrConNeu.Cells(3).Value = obeConNeuMesAnio.QATNAN
            dgvrConNeu.Cells(4).Value = obeConNeuMesAnio.IMPTTL
            Me.dgwDatos.Rows.Add(dgvrConNeu)
        Next
    End Sub

    Private Sub MostrarMeses_x_Anio()
        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("key")
        odtMeses.Columns.Add("value")

        odtMeses.Rows.Add(New Object() {"00", "Todos"})
        odtMeses.Rows.Add(New Object() {"01", "Enero"})
        odtMeses.Rows.Add(New Object() {"02", "Febrero"})
        odtMeses.Rows.Add(New Object() {"03", "Marzo"})
        odtMeses.Rows.Add(New Object() {"04", "Abril"})
        odtMeses.Rows.Add(New Object() {"05", "Mayo"})
        odtMeses.Rows.Add(New Object() {"06", "Junio"})
        odtMeses.Rows.Add(New Object() {"07", "Julio"})
        odtMeses.Rows.Add(New Object() {"08", "Agosto"})
        odtMeses.Rows.Add(New Object() {"09", "Setiembre"})
        odtMeses.Rows.Add(New Object() {"10", "Octubre"})
        odtMeses.Rows.Add(New Object() {"11", "Noviembre"})
        odtMeses.Rows.Add(New Object() {"12", "Diciembre"})

        dbMes.DataSource = odtMeses
        dbMes.ValueMember = "key"
        dbMes.DisplayMember = "value"
        dbMes.SelectedIndex = 0
    End Sub

    Private Sub Listar_Vehiculos()
        Dim lint_indice As Integer = Me.dgwDatos.CurrentCellAddress.Y
        If lint_indice >= 0 Then
            Dim Fecha As String = Me.dgwDatos.Item(0, lint_indice).Value.ToString.Trim() + "01"
            obj_EntidadCN = New ConsumoNeumatico
            obj_EntidadCN.FECREG = Fecha
            obj_EntidadCN.CCMPN = cboCompania.SelectedValue()
            dtgVehiculo.AutoGenerateColumns = False
            dtgVehiculo.DataSource = obj_Logica.Listar_Vehiculo_X_Mes_Anio(obj_EntidadCN)
        Else
            dtgVehiculo.DataSource = Nothing
        End If

    End Sub

    Private Sub Listar_Cuadro_Costo()
        dtgOperacion.Rows.Clear()
        Dim lint_indice As Integer = Me.dgwDatos.CurrentCellAddress.Y
        If lint_indice >= 0 Then
            Dim dt As New DataTable
            Dim dwvrow As DataGridViewRow
            Dim rowData As DataRow
            Dim placa As String = ""
            Dim Fecha As String = Me.dgwDatos.Item(0, lint_indice).Value.ToString.Trim() + "01"
            obj_EntidadCN = New ConsumoNeumatico
            obj_EntidadCN.FECREG = Fecha
            obj_EntidadCN.CCMPN = cboCompania.SelectedValue()
            dtgOperacion.AutoGenerateColumns = False

            dt = Validar_Operaciones_Consumo_Neumatico(obj_Logica.Listar_Cuadro_Costo_X_Mes_Anio(obj_EntidadCN))
            For Each rowData In dt.Rows
                dwvrow = New DataGridViewRow
                dwvrow.CreateCells(Me.dtgOperacion)

                If dtgOperacion.Rows.Count = 0 Then
                    placa = rowData.Item("NPLCUN").ToString.Trim
                    dwvrow.Cells(0).Value = rowData.Item("NPLCUN").ToString.Trim
                Else
                    If placa = rowData.Item("NPLCUN").ToString.Trim Then
                        dwvrow.Cells(0).Value = ""
                    Else
                        placa = rowData.Item("NPLCUN").ToString.Trim
                        dwvrow.Cells(0).Value = rowData.Item("NPLCUN").ToString.Trim
                    End If
                End If

                dwvrow.Cells(1).Value = rowData.Item("NOPRCN")
                dwvrow.Cells(2).Value = rowData.Item("NGUIRM")
                dwvrow.Cells(3).Value = rowData.Item("RUTA").ToString.Trim
                dwvrow.Cells(4).Value = rowData.Item("PMRCMC")
                dwvrow.Cells(5).Value = rowData.Item("NKMRCR")
                dwvrow.Cells(6).Value = rowData.Item("IGSTOP")

                Me.dtgOperacion.Rows.Add(dwvrow)
            Next
            'dtgOperacion.DataSource = obj_Logica.Listar_Cuadro_Costo_X_Mes_Anio(obj_EntidadCN)
        Else
            dtgOperacion.DataSource = Nothing
        End If

    End Sub

    Private Sub Exportar_Excel_Consumo_Neumatico()

        Dim olConsumoNeumatico As New List(Of ConsumoNeumatico)
        Dim objParametro As New Hashtable
        If Me.dbMes.SelectedValue.ToString.Trim = "00" Then
            objParametro.Add("TIPO", "T")
            objParametro.Add("FECREG", 0)
            objParametro.Add("ANIO", Me.ndAnio.Value.ToString())
            objParametro.Add("CCMPN", cboCompania.SelectedValue)
        Else
            objParametro.Add("TIPO", "N")
            objParametro.Add("FECREG", Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01"))
            objParametro.Add("ANIO", 0)
            objParametro.Add("CCMPN", cboCompania.SelectedValue)
        End If

        Dim oDt As New DataTable
        oDt = obj_Logica.Listar_Consumo_Neumatico_X_Mes_Anio_Excel(objParametro)
        Exportar_Excel(oDt)
    End Sub

    Private Sub CrearTablaReporteExcel(ByVal oDt As DataTable)
        oDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FECREG", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TDETRA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TCRVTA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NROSER", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TRFDIS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TRFMED", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TMRCTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("RUTA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("PMRCMC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NKMRCR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("IGSTOP", GetType(System.Double)))
    End Sub

    Private Function Sumar_Peso_Mercaderia_Consumo_Neumatico(ByVal dt As DataTable) As DataTable
        Dim oDt As New DataTable
        Dim m As Integer = 0
        Dim NewRows As DataRow

        Try
            CrearTablaReporteExcel(oDt)
            For i As Integer = 0 To dt.Rows.Count - 1

                If oDt.Rows.Count = 0 Then
                    NewRows = oDt.NewRow
                    NewRows("NPLCUN") = dt.Rows(i).Item("NPLCUN").ToString.Trim
                    NewRows("FECREG") = dt.Rows(i).Item("FECREG")
                    NewRows("TDETRA") = dt.Rows(i).Item("TDETRA")
                    NewRows("TCRVTA") = dt.Rows(i).Item("TCRVTA")
                    NewRows("NROSER") = dt.Rows(i).Item("NROSER")
                    NewRows("TRFDIS") = dt.Rows(i).Item("TRFDIS")
                    NewRows("TRFMED") = dt.Rows(i).Item("TRFMED")
                    NewRows("TMRCTR") = dt.Rows(i).Item("TMRCTR")
                    NewRows("NOPRCN") = dt.Rows(i).Item("NOPRCN")
                    NewRows("NGUIRM") = dt.Rows(i).Item("NGUIRM")
                    NewRows("RUTA") = dt.Rows(i).Item("RUTA")
                    NewRows("PMRCMC") = dt.Rows(i).Item("PMRCMC")
                    NewRows("NKMRCR") = dt.Rows(i).Item("NKMRCR")
                    NewRows("IGSTOP") = dt.Rows(i).Item("IGSTOP")

                    oDt.Rows.Add(NewRows)
                Else
                    For j As Integer = 0 To oDt.Rows.Count - 1
                        If oDt.Rows(j).Item("NOPRCN") = dt.Rows(i).Item("NOPRCN") And oDt.Rows(j).Item("FECREG").SubString(0, 7).ToString() = dt.Rows(i).Item("FECREG").SubString(0, 7).ToString() Then
                            oDt.Rows(j).Item("PMRCMC") += dt.Rows(i).Item("PMRCMC")
                            m = 1
                            Exit For
                        End If
                    Next
                    If m = 0 Then
                        NewRows = oDt.NewRow
                        NewRows("NPLCUN") = dt.Rows(i).Item("NPLCUN").ToString.Trim
                        NewRows("FECREG") = dt.Rows(i).Item("FECREG")
                        NewRows("TDETRA") = dt.Rows(i).Item("TDETRA")
                        NewRows("TCRVTA") = dt.Rows(i).Item("TCRVTA")
                        NewRows("NROSER") = dt.Rows(i).Item("NROSER")
                        NewRows("TRFDIS") = dt.Rows(i).Item("TRFDIS")
                        NewRows("TRFMED") = dt.Rows(i).Item("TRFMED")
                        NewRows("TMRCTR") = dt.Rows(i).Item("TMRCTR")
                        NewRows("NOPRCN") = dt.Rows(i).Item("NOPRCN")
                        NewRows("NGUIRM") = dt.Rows(i).Item("NGUIRM")
                        NewRows("RUTA") = dt.Rows(i).Item("RUTA")
                        NewRows("PMRCMC") = dt.Rows(i).Item("PMRCMC")
                        NewRows("NKMRCR") = dt.Rows(i).Item("NKMRCR")
                        NewRows("IGSTOP") = dt.Rows(i).Item("IGSTOP")
                        oDt.Rows.Add(NewRows)
                    End If
                    m = 0
                End If
            Next

        Catch : End Try
        Return oDt
    End Function

    Private Sub Exportar_Excel(ByVal oDt As DataTable)
        Dim oDs As New DataSet
        Dim strlTitulo As New List(Of String)
        Dim LisFiltros As New List(Of SortedList)
        Dim Placa As String = ""
        Dim itemSortedList As SortedList
        Dim NPOI As New HelpClass_NPOI_ST
        Dim oDtNeumatico As New DataTable
        Dim MdataColumna As String = ""

        strlTitulo.Add("LISTA DE CONSUMO DE NEUMÁTICOS")

        itemSortedList = New SortedList
        itemSortedList.Add(itemSortedList.Count, "Compañía:|" & cboCompania.Text)
        itemSortedList.Add(itemSortedList.Count, "Año:|" & Me.ndAnio.Value.ToString())
        Dim Mes As String = ""
        If Me.dbMes.SelectedValue() = "00" Then
            Mes = "TODOS"
        Else
            Mes = MonthName(Convert.ToInt32(dbMes.SelectedValue), False).ToUpper
        End If
        itemSortedList.Add(itemSortedList.Count, "Mes:|" & Mes)
        LisFiltros.Add(itemSortedList)

        Dim oDte As New DataTable
        oDte = Sumar_Peso_Mercaderia_Consumo_Neumatico(oDt)

        For Each datarow As DataRow In oDte.Rows
            If Placa = "" Then
                Placa = datarow.Item("NPLCUN").ToString().Trim()
            Else
                If Placa = datarow.Item("NPLCUN").ToString().Trim() Then
                    datarow.Item("NPLCUN") = ""
                    datarow.Item("FECREG") = ""
                    datarow.Item("TDETRA") = ""
                    datarow.Item("TCRVTA") = ""
                    datarow.Item("NROSER") = ""
                    datarow.Item("TRFDIS") = ""
                    datarow.Item("TRFMED") = ""
                    datarow.Item("TMRCTR") = ""
                    datarow.AcceptChanges()
                Else
                    Placa = datarow.Item("NPLCUN").ToString().Trim()
                End If
            End If
        Next


        MdataColumna = NPOI.FormatDato("PLACA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("NPLCUN").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("FECHA DE REGISTRO", HelpClass_NPOI_ST.keyDatoFecha)
        oDtNeumatico.Columns.Add("FECREG").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("TIPO DE TRACTO", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("TDETRA").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("REGIÓN DE VENTA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("TCRVTA").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("NRO. SERIE", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("NROSER").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("REF. DISEÑO", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("TRFDIS").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("REF. MEDIDA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("TRFMED").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("MARCA / MODELO", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("TMRCTR").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("OPERACIÓN", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("NOPRCN").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("GUÍA TRANSPORTISTA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("NGUIRM").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("RUTA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtNeumatico.Columns.Add("RUTA").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("PESO MERCADERÍA", HelpClass_NPOI_ST.keyDatoNumero)
        oDtNeumatico.Columns.Add("PMRCMC").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("KIL. RECORRIDOS", HelpClass_NPOI_ST.keyDatoNumero)
        oDtNeumatico.Columns.Add("NKMRCR").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("IMPORTE GASTOS" & Chr(10) & "OPERACIÓN S/.", HelpClass_NPOI_ST.keyDatoMonto)
        oDtNeumatico.Columns.Add("IGSTOP").Caption = MdataColumna
        oDtNeumatico.TableName = "Costo_Neumatico"

        Dim NewRow As DataRow
        Dim oListDtReport As New List(Of DataTable)
        For i As Integer = 0 To oDte.Rows.Count - 1
            NewRow = oDtNeumatico.NewRow
            NewRow("NPLCUN") = oDte.Rows(i).Item("NPLCUN").ToString.Trim
            NewRow("FECREG") = oDte.Rows(i).Item("FECREG")
            NewRow("TDETRA") = oDte.Rows(i).Item("TDETRA")
            NewRow("TCRVTA") = oDte.Rows(i).Item("TCRVTA")
            NewRow("NROSER") = oDte.Rows(i).Item("NROSER")
            NewRow("TRFDIS") = oDte.Rows(i).Item("TRFDIS")
            NewRow("TRFMED") = oDte.Rows(i).Item("TRFMED")
            NewRow("TMRCTR") = oDte.Rows(i).Item("TMRCTR")
            NewRow("NOPRCN") = oDte.Rows(i).Item("NOPRCN")
            NewRow("NGUIRM") = oDte.Rows(i).Item("NGUIRM")
            NewRow("RUTA") = oDte.Rows(i).Item("RUTA")
            NewRow("PMRCMC") = oDte.Rows(i).Item("PMRCMC")
            NewRow("NKMRCR") = oDte.Rows(i).Item("NKMRCR")
            NewRow("IGSTOP") = oDte.Rows(i).Item("IGSTOP")
            oDtNeumatico.Rows.Add(NewRow)
        Next
        oListDtReport.Add(oDtNeumatico)

        Dim lista As New List(Of String)

        NPOI.ExportExcelGeneralMultiple(oListDtReport, strlTitulo, Nothing, LisFiltros, Nothing)
    End Sub

    Private Function Validar_Operaciones_Consumo_Neumatico(ByVal dt As DataTable) As DataTable
        Dim oDt As New DataTable
        Dim m As Integer = 0
        Dim NewRows As DataRow

        Try
            CrearTablaReporte(oDt)
            For i As Integer = 0 To dt.Rows.Count - 1

                If oDt.Rows.Count = 0 Then
                    NewRows = oDt.NewRow
                    NewRows("NPLCUN") = dt.Rows(i).Item("NPLCUN").ToString.Trim
                    NewRows("NOPRCN") = dt.Rows(i).Item("NOPRCN")
                    NewRows("NGUIRM") = dt.Rows(i).Item("NGUIRM")
                    NewRows("RUTA") = dt.Rows(i).Item("RUTA")
                    NewRows("PMRCMC") = dt.Rows(i).Item("PMRCMC")
                    NewRows("NKMRCR") = dt.Rows(i).Item("NKMRCR")
                    NewRows("IGSTOP") = dt.Rows(i).Item("IGSTOP")

                    oDt.Rows.Add(NewRows)
                Else
                    For j As Integer = 0 To oDt.Rows.Count - 1
                        If oDt.Rows(j).Item("NOPRCN") = dt.Rows(i).Item("NOPRCN") Then
                            oDt.Rows(j).Item("PMRCMC") += dt.Rows(i).Item("PMRCMC")
                            m = 1
                            Exit For
                        End If
                    Next
                    If m = 0 Then
                        NewRows = oDt.NewRow
                        NewRows("NPLCUN") = dt.Rows(i).Item("NPLCUN").ToString.Trim
                        NewRows("NOPRCN") = dt.Rows(i).Item("NOPRCN")
                        NewRows("NGUIRM") = dt.Rows(i).Item("NGUIRM")
                        NewRows("RUTA") = dt.Rows(i).Item("RUTA")
                        NewRows("PMRCMC") = dt.Rows(i).Item("PMRCMC")
                        NewRows("NKMRCR") = dt.Rows(i).Item("NKMRCR")
                        NewRows("IGSTOP") = dt.Rows(i).Item("IGSTOP")
                        oDt.Rows.Add(NewRows)
                    End If
                    m = 0
                End If
            Next

        Catch : End Try
        Return oDt
    End Function

    Private Sub CrearTablaReporte(ByVal oDt As DataTable)
        oDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("RUTA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("PMRCMC", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("NKMRCR", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("IGSTOP", GetType(System.Double)))
    End Sub

#End Region

End Class

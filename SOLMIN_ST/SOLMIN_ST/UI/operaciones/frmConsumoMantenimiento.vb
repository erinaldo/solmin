Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports Ransa.Utilitario

Public Class frmConsumoMantenimiento

#Region "Atributos"
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private obj_Logica As New CostoMantenimiento_BLL
    Private obj_EntidadCM As New CostoMantenimiento
#End Region

#Region "Eventos"
    Private Sub frmConsumoMantenimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub dgwDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDatos.CellClick
        If e.RowIndex < 0 Or Me.dgwDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Listar_Vehiculos()
        Listar_Cuadro_Costo()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.dgwDatos.Rows.Clear()
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

    Private Sub btnImportarCosMan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImportarCosMan.Click
        Dim ofrmImportarConsumo As New frmImportarConsumo
        With ofrmImportarConsumo
            .Flag = 2
            .Text = "Importar Costo Mantenimiento de Excel"
            .lblCompania.Text = cboCompania.Text
            .Compania = cboCompania.SelectedValue
        End With
        If ofrmImportarConsumo.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim lint_indice As Integer = Me.dgwDatos.CurrentCellAddress.Y
        If lint_indice >= 0 Then
            Listar_Vehiculos()
            Listar_Cuadro_Costo()
        Else
            Listar_Mes_Anio()
            Listar_Vehiculos()
            Listar_Cuadro_Costo()
        End If

        tbVehiculo.SelectTab(0)
    End Sub

    Private Sub btnImportarCosOpe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImportarCosOpe.Click
        If Me.dgwDatos.RowCount = 0 OrElse Me.dgwDatos.CurrentRow.Selected = False Then Exit Sub
        Dim lint_Indice_A As Integer = Me.dgwDatos.CurrentCellAddress.Y
        Dim FecReg As String = Me.dgwDatos.Item("sFECREG", lint_Indice_A).Value.ToString()

        Dim ofrmOpcionOperacionGuia As New frmOpcionOperacionGuia
        With ofrmOpcionOperacionGuia
            .FechaInicio = FecReg + "01"
            .Compania = cboCompania.SelectedValue()
            .Registro = "M"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Listar_Cuadro_Costo()
                tbVehiculo.SelectTab(1)
            End If
        End With
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

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.dgwDatos.RowCount = 0 OrElse Me.dgwDatos.CurrentRow.Selected = False Then Exit Sub
        Dim lint_Indice_A As Integer = Me.dgwDatos.CurrentCellAddress.Y
        Dim FecReg As String = Me.dgwDatos.Item("sFECREG", lint_Indice_A).Value.ToString()
        If MsgBox("Desea eliminar el Costo de Mantenimiento del Mes de " + dgwDatos.Item(2, lint_Indice_A).Value + " del " + dgwDatos.Item(1, lint_Indice_A).Value, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim obj_Entidad As New CostoMantenimiento
        obj_Entidad.FECREG = FecReg
        obj_Entidad.CCMPN = cboCompania.SelectedValue()
        If obj_Logica.Actualizar_Costo_Mantenimiento(obj_Entidad).NCOMNT = 1 Then
            Me.Listar_Mes_Anio()
            Listar_Vehiculos()
            Listar_Cuadro_Costo()
        End If
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Exportar_Excel_Costo_Mantenimiento()
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

    Private Sub Listar_Mes_Anio()
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
        'olCostoMantenimiento = obj_Logica.Listar_Importe_Soles_X_Mes_Anio(objParametro)
        For Each obeCosManMesAnio As CostoMantenimiento In obj_Logica.Listar_Importe_Soles_X_Mes_Anio(objParametro)
            Dim dgvrCosMan As DataGridViewRow
            dgvrCosMan = New DataGridViewRow
            dgvrCosMan.CreateCells(Me.dgwDatos)
            dgvrCosMan.Cells(0).Value = obeCosManMesAnio.FECREG
            dgvrCosMan.Cells(1).Value = obeCosManMesAnio.FECREG.ToString().Trim().Substring(0, 4) 'obeConNeuMesAnio.ANIO
            dgvrCosMan.Cells(2).Value = MonthName(Convert.ToInt32(HelpClass.CNumero_a_Fecha(obeCosManMesAnio.FECREG).Month), False).ToUpper
            dgvrCosMan.Cells(3).Value = obeCosManMesAnio.IMTOTS
            Me.dgwDatos.Rows.Add(dgvrCosMan)
        Next
    End Sub

    Private Sub Listar_Vehiculos()
        Dim lint_indice As Integer = Me.dgwDatos.CurrentCellAddress.Y
        If lint_indice >= 0 Then
            Dim Fecha As String = Me.dgwDatos.Item(0, lint_indice).Value.ToString.Trim() + "01"
            obj_EntidadCM = New CostoMantenimiento
            obj_EntidadCM.FECREG = Fecha
            obj_EntidadCM.CCMPN = cboCompania.SelectedValue()
            dtgVehiculo.AutoGenerateColumns = False
            dtgVehiculo.DataSource = obj_Logica.Listar_Vehiculo_CM_X_Mes_Anio(obj_EntidadCM)
        Else
            dtgVehiculo.DataSource = Nothing
        End If
    End Sub

    Private Sub Listar_Cuadro_Costo()
        Dim lint_indice As Integer = Me.dgwDatos.CurrentCellAddress.Y
        Me.dtgOperacion.Rows.Clear()
        If lint_indice >= 0 Then
            Dim dt As New DataTable
            Dim dwvrow As DataGridViewRow
            Dim rowData As DataRow
            Dim Fecha As String = Me.dgwDatos.Item(0, lint_indice).Value.ToString.Trim() + "01"
            obj_EntidadCM = New CostoMantenimiento
            obj_EntidadCM.FECREG = Fecha
            obj_EntidadCM.CCMPN = cboCompania.SelectedValue()
            dtgOperacion.AutoGenerateColumns = False
            'Dim x As Integer = 0
            Dim placa As String = ""
            dt = Validar_Operaciones_Consumo_Mantenimiento(obj_Logica.Listar_Cuadro_Costo_X_Mes_Anio(obj_EntidadCM))
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
            'dtgOperacion.DataSource = obj_Logica.Listar_Cuadro_Costo_X_Mes_Anio(obj_EntidadCM)
        End If
    End Sub

    Private Sub CrearTablaReporte(ByVal oDt As DataTable)
        oDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("RUTA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("PMRCMC", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("NKMRCR", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("IGSTOP", GetType(System.Double)))
    End Sub

    Private Function Validar_Operaciones_Consumo_Mantenimiento(ByVal dt As DataTable) As DataTable
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

    Private Sub Exportar_Excel_Costo_Mantenimiento()

        Dim olCostoMantenimiento As New List(Of CostoMantenimiento)
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
        oDt = obj_Logica.Listar_Costo_Mantenimiento_X_Mes_Anio_Excel(objParametro)
        If oDt.Rows.Count > 0 Then
            Exportar_Excel(oDt)
        End If
    End Sub

    Private Sub CrearTablaReporteExcel(ByVal oDt As DataTable)
        oDt.Columns.Add(New DataColumn("NPLCUN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("FECREG", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TCNTCS", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TTRBES", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SESTCT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TNBPRV", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("SINDRC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TMRCTR", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TOPRC", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TFAMIL", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NOPRCN", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("RUTA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("PMRCMC", GetType(System.Double)))
        oDt.Columns.Add(New DataColumn("IGSTOP", GetType(System.Double)))
    End Sub

    Private Function Sumar_Peso_Mercaderia_Consumo_Mantenimiento(ByVal dt As DataTable) As DataTable
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
                    NewRows("TCNTCS") = dt.Rows(i).Item("TCNTCS")
                    NewRows("TTRBES") = dt.Rows(i).Item("TTRBES")
                    NewRows("SESTCT") = dt.Rows(i).Item("SESTCT")
                    NewRows("TNBPRV") = dt.Rows(i).Item("TNBPRV")
                    NewRows("SINDRC") = dt.Rows(i).Item("SINDRC")
                    NewRows("TMRCTR") = dt.Rows(i).Item("TMRCTR")
                    NewRows("TOPRC") = dt.Rows(i).Item("TOPRC")
                    NewRows("TFAMIL") = dt.Rows(i).Item("TFAMIL")
                    NewRows("NOPRCN") = dt.Rows(i).Item("NOPRCN")
                    NewRows("NGUIRM") = dt.Rows(i).Item("NGUIRM")
                    NewRows("RUTA") = dt.Rows(i).Item("RUTA")
                    NewRows("PMRCMC") = dt.Rows(i).Item("PMRCMC")
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
                        NewRows("TCNTCS") = dt.Rows(i).Item("TCNTCS")
                        NewRows("TTRBES") = dt.Rows(i).Item("TTRBES")
                        NewRows("SESTCT") = dt.Rows(i).Item("SESTCT")
                        NewRows("TNBPRV") = dt.Rows(i).Item("TNBPRV")
                        NewRows("SINDRC") = dt.Rows(i).Item("SINDRC")
                        NewRows("TMRCTR") = dt.Rows(i).Item("TMRCTR")
                        NewRows("TOPRC") = dt.Rows(i).Item("TOPRC")
                        NewRows("TFAMIL") = dt.Rows(i).Item("TFAMIL")
                        NewRows("NOPRCN") = dt.Rows(i).Item("NOPRCN")
                        NewRows("NGUIRM") = dt.Rows(i).Item("NGUIRM")
                        NewRows("RUTA") = dt.Rows(i).Item("RUTA")
                        NewRows("PMRCMC") = dt.Rows(i).Item("PMRCMC")
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
        Dim itemSortedList As SortedList
        strlTitulo.Add("LISTA DE COSTO DE MANTENIMIENTO")

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
        oDte = Sumar_Peso_Mercaderia_Consumo_Mantenimiento(oDt)

        Dim Placa As String = ""
        For Each datarow As DataRow In oDte.Rows
            If Placa = "" Then
                Placa = datarow.Item("NPLCUN").ToString().Trim()
            Else
                If Placa = datarow.Item("NPLCUN").ToString().Trim() Then
                    datarow.Item("NPLCUN") = ""
                    datarow.Item("FECREG") = ""
                    datarow.Item("TCNTCS") = ""
                    datarow.Item("TTRBES") = ""
                    datarow.Item("SESTCT") = ""
                    datarow.Item("TNBPRV") = ""
                    datarow.Item("SINDRC") = ""
                    datarow.Item("TMRCTR") = ""
                    datarow.Item("TOPRC") = ""
                    datarow.Item("TFAMIL") = ""

                    datarow.AcceptChanges()
                Else
                    Placa = datarow.Item("NPLCUN").ToString().Trim()
                End If
            End If
        Next

        Dim NPOI As New HelpClass_NPOI_ST
        Dim oDtMantenimiento As New DataTable
        Dim MdataColumna As String = ""

        MdataColumna = NPOI.FormatDato("PLACA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("NPLCUN").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("FECHA DE REGISTRO", HelpClass_NPOI_ST.keyDatoFecha)
        oDtMantenimiento.Columns.Add("FECREG").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("CENTRO DE COSTO", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("TCNTCS").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("TRABAJO ESPECIAL", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("TTRBES").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("ESTADO DE COTIZACIÓN", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("SESTCT").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("PROVEEDOR", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("TNBPRV").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("RECURSO", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("SINDRC").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("MARCA / MODELO", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("TMRCTR").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("DESCRIP. OPERACIÓN", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("TOPRC").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("FAMILIA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("TFAMIL").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("OPERACIÓN", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("NOPRCN").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("GUÍA TRANSPORTISTA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("NGUIRM").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("RUTA", HelpClass_NPOI_ST.keyDatoTexto)
        oDtMantenimiento.Columns.Add("RUTA").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("PESO DE MERCADERÍA", HelpClass_NPOI_ST.keyDatoNumero)
        oDtMantenimiento.Columns.Add("PMRCMC").Caption = MdataColumna
        MdataColumna = NPOI.FormatDato("IMPORTE TOTAL SOLES", HelpClass_NPOI_ST.keyDatoMonto)
        oDtMantenimiento.Columns.Add("IGSTOP").Caption = MdataColumna
        oDtMantenimiento.TableName = "Costo_Mantenimiento"

        Dim NewRow As DataRow
        Dim oListDtReport As New List(Of DataTable)
        For i As Integer = 0 To oDte.Rows.Count - 1
            NewRow = oDtMantenimiento.NewRow
            NewRow("NPLCUN") = oDte.Rows(i).Item("NPLCUN").ToString.Trim
            NewRow("FECREG") = oDte.Rows(i).Item("FECREG")
            NewRow("TCNTCS") = oDte.Rows(i).Item("TCNTCS")
            NewRow("TTRBES") = oDte.Rows(i).Item("TTRBES")
            NewRow("SESTCT") = oDte.Rows(i).Item("SESTCT")
            NewRow("TNBPRV") = oDte.Rows(i).Item("TNBPRV")
            NewRow("SINDRC") = oDte.Rows(i).Item("SINDRC")
            NewRow("TMRCTR") = oDte.Rows(i).Item("TMRCTR")
            NewRow("TOPRC") = oDte.Rows(i).Item("TOPRC")
            NewRow("TFAMIL") = oDte.Rows(i).Item("TFAMIL")
            NewRow("NOPRCN") = oDte.Rows(i).Item("NOPRCN")
            NewRow("NGUIRM") = oDte.Rows(i).Item("NGUIRM")
            NewRow("RUTA") = oDte.Rows(i).Item("RUTA")
            NewRow("PMRCMC") = oDte.Rows(i).Item("PMRCMC")
            NewRow("IGSTOP") = oDte.Rows(i).Item("IGSTOP")
            oDtMantenimiento.Rows.Add(NewRow)
        Next
        oListDtReport.Add(oDtMantenimiento)
        NPOI.ExportExcelGeneralMultiple(oListDtReport, strlTitulo, Nothing, LisFiltros, Nothing)

    End Sub
#End Region

End Class

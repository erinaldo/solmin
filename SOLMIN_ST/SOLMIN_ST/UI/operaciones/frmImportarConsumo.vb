Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.Utilitario

Public Class frmImportarConsumo
#Region "Atributos"
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private obj_Worksheet2 As Object
    Private obj_SheetName As String
    Private olConNeu As List(Of ConsumoNeumatico)
    Private olCosMan As List(Of CostoMantenimiento)
    Private objConsumoNeumatico_BLL As New ConsumoNeumatico_BLL
    Private objCostoMantenimiento_BLL As New CostoMantenimiento_BLL
    Private _Flag As String
    Private _Compania As String
#End Region
#Region "Propiedades"
    Public WriteOnly Property Flag() As String
        Set(ByVal value As String)
            _Flag = value
        End Set
    End Property

    Public WriteOnly Property Compania() As String
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property
#End Region
#Region "Eventos"
    Private Sub frmImportarConsumo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ndAnio.Minimum = 0
        ndAnio.Maximum = HelpClass.TodayAnio
        ndAnio.Value = HelpClass.TodayAnio
        MostrarMeses_x_Anio()
        If _Flag = 1 Then
            tabCostos.TabPages(1).Dispose()
        Else
            tabCostos.TabPages(0).Dispose()
        End If
    End Sub

    Private Sub btnExcelCabecera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcelCabecera.Click
        Dim NumSheets As Integer
        Dim NomSheets As String
        Dim i As Integer
        Dim n As Integer
        Dim j As Integer
        Dim m As Integer

        Me.OpenFileDialog.Multiselect = False
        Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal))
        Me.OpenFileDialog.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"
        If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TxtRutaXlsCabecera.Text = Me.OpenFileDialog.FileName
            obj_Excel = CreateObject("Excel.Application")
            obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsCabecera.Text)
            NumSheets = obj_Workbook.sheets.count()
            CmbXlsHoja.Items.Clear()
            For i = 1 To NumSheets
                NomSheets = obj_Workbook.Sheets.Item(i).Name
                CmbXlsHoja.Items.Add(NomSheets)
            Next
            CmbXlsHoja.SelectedIndex = 0

            If _Flag = 1 Then
                obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
                n = 6
                i = 0
                Do Until i = 1 Or n = NmCount.Maximum
                    n = n + 1
                    If Trim(obj_Worksheet.Cells(n, 3).value) = "" Then
                        i = 1
                        Exit Do
                    End If
                Loop
                NmCount.Value = n - 1

            Else
                obj_Worksheet2 = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
                m = 2
                j = 0
                Do Until j = 1 Or m = NmCount2.Maximum
                    m = m + 1
                    If Trim(obj_Worksheet2.Cells(m, 2).value) = "" Then
                        j = 1
                        Exit Do
                    End If
                Loop
                NmCount2.Value = m - 1
            End If
        End If
    End Sub

    Private Sub btnAbrirCabecera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbrirCabecera.Click
        Try
            ' -- Verifica si existe el archivo   
            If Len(Dir(Me.TxtRutaXlsCabecera.Text)) = 0 Then
                MsgBox("No se ha encontrado el archivo: " & Me.TxtRutaXlsCabecera.Text, vbCritical)
                Exit Sub
            End If
            If Me.ndAnio.Value = 0 Then
                MsgBox("Debe seleccionar Año. ", vbCritical)
                Exit Sub
            End If
            If Me.dbMes.SelectedValue = "" Then
                MsgBox("Debe seleccionar Mes. ", vbCritical)
                Exit Sub
            End If

            If _Flag = 1 Then
                Cargar_Consumo_Neumaticos()
            Else
                Cargar_Costo_Mantenimiento()
            End If
            Limpiar_Objetos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        btnProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

        If _Flag = 1 Then
            If olConNeu IsNot Nothing And olConNeu.Count > 0 Then
                For Each obeCoNes As ConsumoNeumatico In olConNeu
                    If obeCoNes.FECREG = 0 Then
                        MessageBox.Show("La Fecha de Registro es Obligatoria.", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If obeCoNes.NPLCUN.Trim = "" Then
                        MessageBox.Show("El Nro. de Placa Unidad es Obligatoria.", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                Registrar_Consumo_Neumatico()
            End If
        Else
            If olCosMan IsNot Nothing And olCosMan.Count > 0 Then
                For Each obeCoMan As CostoMantenimiento In olCosMan
                    If obeCoMan.FECREG = 0 Then
                        MessageBox.Show("La Fecha de Registro es Obligatoria.", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If obeCoMan.NPLCUN.Trim = "" Then
                        MessageBox.Show("El Nro. de Placa Unidad es Obligatoria.", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                Registrar_Consumo_Mantenimiento()
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

#End Region
#Region "Metodos y Funciones"
    Private Sub MostrarMeses_x_Anio()

        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("key")
        odtMeses.Columns.Add("value")

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

    Public Sub Cargar_Consumo_Neumaticos()
        Dim i As Integer
        'Instancia Excel  
        If obj_Excel Is Nothing Then
            obj_Excel = CreateObject("Excel.Application")
            obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsCabecera.Text)
        End If
        ' Referencia la Hoja, por defecto la hoja activa  
        If obj_SheetName = vbNullString Then
            obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
        Else
            obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
        End If
        'Crear lista de Objeto de tipo Combustible
        Dim olbeConsumoNeumatico As New List(Of ConsumoNeumatico)
        Dim obj_Entidad As ConsumoNeumatico
        olConNeu = New List(Of ConsumoNeumatico)
        For i = 6 To NmCount.Value - 1
            obj_Entidad = New ConsumoNeumatico
            If obj_Worksheet.Cells(i + 1, 3).Value.ToString.Trim = "" Then
                obj_Entidad.FECREG = 0
            ElseIf HelpClass.CFecha_a_Numero8Digitos(obj_Worksheet.Cells(i + 1, 3).Value.ToString.Trim).Substring(0, 6) = ndAnio.Value.ToString().Trim() + dbMes.SelectedValue.ToString().Trim() Then
                obj_Entidad.FECREG = HelpClass.CFecha_a_Numero8Digitos(obj_Worksheet.Cells(i + 1, 3).Value.ToString.Trim)
                obj_Entidad.NPLCUN = Trim(obj_Worksheet.Cells(i + 1, 4).Value)
                obj_Entidad.TDETRA = Trim(obj_Worksheet.Cells(i + 1, 5).Value)
                obj_Entidad.TCRVTA = Trim(obj_Worksheet.Cells(i + 1, 6).Value)
                obj_Entidad.NROSER = Trim(obj_Worksheet.Cells(i + 1, 7).Value)
                obj_Entidad.TMRCTR = Trim(obj_Worksheet.Cells(i + 1, 8).Value)
                obj_Entidad.TRFMED = Trim(obj_Worksheet.Cells(i + 1, 9).Value)
                obj_Entidad.TRFDIS = Trim(obj_Worksheet.Cells(i + 1, 10).Value)
                If Trim(obj_Worksheet.Cells(i + 1, 12).Value) = "" Then
                    obj_Entidad.QATNAN = 0
                Else
                    obj_Entidad.QATNAN = obj_Worksheet.Cells(i + 1, 12).Value.ToString.Trim
                End If

                obj_Entidad.TOBS = ("" & obj_Worksheet.Cells(i + 1, 13).Value & "").ToString.Trim

                If Trim(obj_Worksheet.Cells(i + 1, 14).Value) = "" Then
                    obj_Entidad.IMPUNI = 0
                Else
                    obj_Entidad.IMPUNI = obj_Worksheet.Cells(i + 1, 14).Value.ToString.Trim
                End If

                If Trim(obj_Worksheet.Cells(i + 1, 15).Value) = "" Then
                    obj_Entidad.IMPTTL = 0
                Else
                    obj_Entidad.IMPTTL = obj_Worksheet.Cells(i + 1, 15).Value.ToString.Trim
                End If
                obj_Entidad.CCMPN = _Compania
                obj_Entidad.CUSCRT = MainModule.USUARIO
                obj_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                olbeConsumoNeumatico.Add(obj_Entidad)
                olConNeu.Add(obj_Entidad)
            End If
        Next
        If olbeConsumoNeumatico IsNot Nothing And olbeConsumoNeumatico.Count > 0 Then
            Cargar_Grilla_Consumo_Neumaticos(olbeConsumoNeumatico)
        End If

    End Sub

    Public Sub Cargar_Grilla_Consumo_Neumaticos(ByVal olbeConsumoNeumatico As List(Of ConsumoNeumatico))
        While dgwDatos.Rows.Count > 0
            dgwDatos.Rows.RemoveAt(0)
        End While
        Dim a As Integer = 0
        dgwDatos.DataSource = Nothing
        For Each obeConsumoNeumatico As ConsumoNeumatico In olbeConsumoNeumatico
            Dim dgvrConNeu As DataGridViewRow
            dgvrConNeu = New DataGridViewRow
            dgvrConNeu.CreateCells(Me.dgwDatos)
            dgvrConNeu.Cells(0).Value = HelpClass.CNumero8Digitos_a_Fecha(obeConsumoNeumatico.FECREG)
            dgvrConNeu.Cells(1).Value = obeConsumoNeumatico.NPLCUN
            dgvrConNeu.Cells(2).Value = obeConsumoNeumatico.TDETRA
            dgvrConNeu.Cells(3).Value = obeConsumoNeumatico.TCRVTA
            dgvrConNeu.Cells(4).Value = obeConsumoNeumatico.NROSER
            dgvrConNeu.Cells(5).Value = obeConsumoNeumatico.TMRCTR
            dgvrConNeu.Cells(6).Value = obeConsumoNeumatico.TRFMED
            dgvrConNeu.Cells(7).Value = obeConsumoNeumatico.TRFDIS
            dgvrConNeu.Cells(8).Value = obeConsumoNeumatico.QATNAN
            dgvrConNeu.Cells(9).Value = obeConsumoNeumatico.TOBS
            dgvrConNeu.Cells(10).Value = obeConsumoNeumatico.IMPUNI
            dgvrConNeu.Cells(11).Value = obeConsumoNeumatico.IMPTTL
            'dgvrConNeu.Cells(12).Value = obeConsumoNeumatico.CCMPN
            If obeConsumoNeumatico.FECREG = 0 Then
                dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
                For x As Integer = 0 To dgwDatos.Columns.Count - 1
                    dgvrConNeu.Cells(x).ToolTipText = "No tiene Fecha"
                Next
            End If

            If obeConsumoNeumatico.NPLCUN = "" Then
                dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
                For x As Integer = 0 To dgwDatos.Columns.Count - 1
                    dgvrConNeu.Cells(x).ToolTipText = "No tiene Unidad"
                Next
            Else
                If dgwDatos.RowCount > 0 Then
                    For x As Integer = 0 To dgwDatos.RowCount - 1
                        If dgwDatos.Item(5, x).Value.ToString() = obeConsumoNeumatico.NPLCUN Then
                            dgwDatos.Rows(x).DefaultCellStyle.BackColor = Color.MistyRose
                            a = 1
                        End If
                    Next
                End If
            End If

            If obeConsumoNeumatico.TDETRA = "" Then
                dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
                For x As Integer = 0 To dgwDatos.Columns.Count - 1
                    dgvrConNeu.Cells(x).ToolTipText = "No tiene Tipo de Unidad"
                Next
            End If

            If obeConsumoNeumatico.TCRVTA = "" Then
                dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
                For x As Integer = 0 To dgwDatos.Columns.Count - 1
                    dgvrConNeu.Cells(x).ToolTipText = "No tiene Operación"
                Next
            End If

            'If obeConsumoNeumatico.NROSER = "" Then dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
            If obeConsumoNeumatico.TMRCTR = "" Then
                dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
                For x As Integer = 0 To dgwDatos.Columns.Count - 1
                    dgvrConNeu.Cells(x).ToolTipText = "No tiene Marca"
                Next
            End If

            If obeConsumoNeumatico.QATNAN = 0 Then
                dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
                For x As Integer = 0 To dgwDatos.Columns.Count - 1
                    dgvrConNeu.Cells(x).ToolTipText = "No tiene Cantidad"
                Next
            End If
            Me.dgwDatos.Rows.Add(dgvrConNeu)
        Next

        If a = 0 Then
            btnProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Else
            btnProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            a = 0
        End If
        Dim obeCoNe As New ConsumoNeumatico
        obeCoNe.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")

        If objConsumoNeumatico_BLL.Validar_Existe_Mes_Anio(obeCoNe) > 0 Then
            MessageBox.Show("Los Consumos de Neumáticos del Mes de " + dbMes.Text + " del " + Me.ndAnio.Value.ToString().Trim() + " fueron registrados.", "Mensaje : ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function Obtener_Tipo_Cambio() As Double
        Dim obeMoneda As New Moneda
        Dim objMoneda_BLL As New Moneda_BLL
        Dim TipoCambio As Double
        Dim Dias As Integer = System.DateTime.DaysInMonth(ndAnio.Value, Convert.ToInt32(dbMes.SelectedValue))
        obeMoneda.CMNDA1 = 100
        obeMoneda.FULTAC = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + Dias.ToString())
        TipoCambio = objMoneda_BLL.Tipo_Cambio(obeMoneda)
        Return TipoCambio
    End Function

    Public Sub Cargar_Costo_Mantenimiento()
        Dim j As Integer
        'Crear lista de Objeto de tipo Combustible
        Dim olbeCostoMantenimiento As New List(Of CostoMantenimiento)
        Dim obj_Entidad As CostoMantenimiento
        olCosMan = New List(Of CostoMantenimiento)

        For j = 3 To NmCount2.Value - 1
            obj_Entidad = New CostoMantenimiento
            If obj_Worksheet2.Cells(j + 1, 2).Value.ToString.Trim = "" Then
                obj_Entidad.FECREG = 0
            ElseIf HelpClass.CFecha_a_Numero8Digitos(obj_Worksheet2.Cells(j + 1, 2).Value.ToString.Trim).Substring(0, 6) = ndAnio.Value.ToString().Trim() + dbMes.SelectedValue.ToString().Trim() Then
                obj_Entidad.FECREG = HelpClass.CFecha_a_Numero8Digitos(obj_Worksheet2.Cells(j + 1, 2).Value.ToString.Trim)
                obj_Entidad.TCNTCS = Trim(obj_Worksheet2.Cells(j + 1, 3).Value)
                obj_Entidad.TTRBES = Trim(obj_Worksheet2.Cells(j + 1, 4).Value)
                obj_Entidad.SESTCT = IIf(Trim(obj_Worksheet2.Cells(j + 1, 5).Value) = "SI", "S", "N")
                obj_Entidad.TNBPRV = Trim(obj_Worksheet2.Cells(j + 1, 6).Value)
                obj_Entidad.NPLCUN = Trim(obj_Worksheet2.Cells(j + 1, 7).Value)
                obj_Entidad.SINDRC = IIf(Trim(obj_Worksheet2.Cells(j + 1, 8).Value) = "RANSA", "P", "T")
                obj_Entidad.TMRCTR = ("" & obj_Worksheet2.Cells(j + 1, 9).Value & "").ToString.Trim
                obj_Entidad.TOPRC = ("" & obj_Worksheet2.Cells(j + 1, 10).Value & "").ToString.Trim
                If Trim(obj_Worksheet2.Cells(j + 1, 11).Value) = "" Then
                    obj_Entidad.IMTOTD = 0
                Else
                    obj_Entidad.IMTOTD = obj_Worksheet2.Cells(j + 1, 11).Value
                End If

                If Trim(obj_Worksheet2.Cells(j + 1, 12).Value) = "" Then
                    obj_Entidad.IMTOTS = 0
                Else
                    obj_Entidad.IMTOTS = obj_Worksheet2.Cells(j + 1, 12).Value
                End If
                obj_Entidad.TFAMIL = ("" & obj_Worksheet2.Cells(j + 1, 13).Value & "").ToString.Trim
                If Trim(obj_Worksheet2.Cells(j + 1, 17).Value) = "" Then
                    If Trim(obj_Worksheet2.Cells(j + 1, 12).Value) = "" Then
                        obj_Entidad.TOTALS = obj_Worksheet2.Cells(j + 1, 11).Value * Obtener_Tipo_Cambio()
                    Else
                        obj_Entidad.TOTALS = obj_Worksheet2.Cells(j + 1, 12).Value
                    End If
                Else
                    obj_Entidad.TOTALS = obj_Worksheet2.Cells(j + 1, 17).Value
                End If

                If Trim(obj_Worksheet2.Cells(j + 1, 11).Value) = "" Then
                    obj_Entidad.ITPCMT = Obtener_Tipo_Cambio()
                Else
                    If Trim(obj_Worksheet2.Cells(j + 1, 17).Value) = "" Then
                        obj_Entidad.ITPCMT = Obtener_Tipo_Cambio()
                    Else
                        obj_Entidad.ITPCMT = obj_Worksheet2.Cells(j + 1, 17).Value / obj_Worksheet2.Cells(j + 1, 11).Value
                    End If
                End If
                obj_Entidad.CCMPN = _Compania
                obj_Entidad.CUSCRT = MainModule.USUARIO
                obj_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                olbeCostoMantenimiento.Add(obj_Entidad)
                olCosMan.Add(obj_Entidad)
            End If
        Next
        If olbeCostoMantenimiento IsNot Nothing And olbeCostoMantenimiento.Count > 0 Then
            Cargar_Grilla_Costo_Mantenimiento(olbeCostoMantenimiento)
        End If

    End Sub

    Public Sub Cargar_Grilla_Costo_Mantenimiento(ByVal olbeCostoMantenimiento As List(Of CostoMantenimiento))
        While dgwCosMan.Rows.Count > 0
            dgwCosMan.Rows.RemoveAt(0)
        End While
        Dim a As Integer = 0
        For Each obeCostoMantenimiento As CostoMantenimiento In olbeCostoMantenimiento
            Dim dgvrCosMan As DataGridViewRow
            dgvrCosMan = New DataGridViewRow
            dgvrCosMan.CreateCells(Me.dgwCosMan)
            dgvrCosMan.Cells(0).Value = HelpClass.CNumero6Digitos_a_Fecha(obeCostoMantenimiento.FECREG)
            dgvrCosMan.Cells(1).Value = obeCostoMantenimiento.TCNTCS
            dgvrCosMan.Cells(2).Value = obeCostoMantenimiento.TTRBES
            Dim strSESTCT As String = ""
            If obeCostoMantenimiento.SESTCT = "N" Then
                strSESTCT = "NO"
            ElseIf obeCostoMantenimiento.SESTCT = "S" Then
                strSESTCT = "SI"
            Else
                strSESTCT = ""
            End If
            dgvrCosMan.Cells(3).Value = strSESTCT
            dgvrCosMan.Cells(4).Value = obeCostoMantenimiento.TNBPRV
            dgvrCosMan.Cells(5).Value = obeCostoMantenimiento.NPLCUN
            Dim strSINDRC As String = ""
            If obeCostoMantenimiento.SINDRC = "P" Then
                strSINDRC = "PROPIO"
            ElseIf obeCostoMantenimiento.SINDRC = "T" Then
                strSINDRC = "TERCERO"
            Else
                strSINDRC = ""
            End If
            dgvrCosMan.Cells(6).Value = strSINDRC
            dgvrCosMan.Cells(7).Value = obeCostoMantenimiento.TMRCTR
            dgvrCosMan.Cells(8).Value = obeCostoMantenimiento.TOPRC
            dgvrCosMan.Cells(9).Value = IIf(obeCostoMantenimiento.IMTOTD = 0, "", obeCostoMantenimiento.IMTOTD)
            dgvrCosMan.Cells(10).Value = IIf(obeCostoMantenimiento.IMTOTS = 0, "", obeCostoMantenimiento.IMTOTS)
            dgvrCosMan.Cells(11).Value = obeCostoMantenimiento.TFAMIL
            If obeCostoMantenimiento.FECREG = 0 Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(0).ToolTipText = "No tiene Fecha"
            End If

            If obeCostoMantenimiento.TCNTCS = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(1).ToolTipText = "No tiene Centro de Costo"
            End If

            'If obeCostoMantenimiento.TTRBES = "" Then dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
            If obeCostoMantenimiento.SESTCT = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(3).ToolTipText = "No tiene Contrato de Mantenimiento"
            End If

            If obeCostoMantenimiento.TNBPRV = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(4).ToolTipText = "No tiene Proveedor"
            End If

            If obeCostoMantenimiento.NPLCUN = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(5).ToolTipText = "No tiene Marca"
            Else
                If dgwCosMan.RowCount > 0 Then
                    For x As Integer = 0 To dgwCosMan.RowCount - 1
                        If dgwCosMan.Item(5, x).Value.ToString() = obeCostoMantenimiento.NPLCUN Then
                            dgwCosMan.Rows(x).DefaultCellStyle.BackColor = Color.MistyRose
                            a = 1
                        End If
                    Next
                End If
            End If

            If obeCostoMantenimiento.SINDRC = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(6).ToolTipText = "No tiene Propietario"
            End If

            If obeCostoMantenimiento.TMRCTR = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(7).ToolTipText = "No tiene Marca"
            End If

            If obeCostoMantenimiento.TOPRC = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(8).ToolTipText = "No tiene Operación"
            End If

            If obeCostoMantenimiento.IMTOTD = 0 And obeCostoMantenimiento.IMTOTS = 0 Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                If obeCostoMantenimiento.IMTOTD = 0 Then
                    dgvrCosMan.Cells(9).ToolTipText = "No tiene Importe en Dólares"
                ElseIf obeCostoMantenimiento.IMTOTS = 0 Then
                    dgvrCosMan.Cells(10).ToolTipText = "No tiene Importe en Soles"
                End If
                'dgvrCosMan.Cells(9).ToolTipText = "No tiene Operación"
            End If
            If obeCostoMantenimiento.TFAMIL = "" Then
                dgvrCosMan.DefaultCellStyle.BackColor = Color.LightYellow
                dgvrCosMan.Cells(11).ToolTipText = "No tiene Familia"
            End If

            'If objCostoMantenimiento_BLL.Buscar_Costo_Mantenimiento(obeCostoMantenimiento) Then
            '    dgvrCosMan.DefaultCellStyle.BackColor = Color.MistyRose
            '    For x As Integer = 0 To dgwCosMan.Columns.Count - 1
            '        dgvrCosMan.Cells(x).ToolTipText = "Fila ya fue registrada"
            '    Next
            'End If
            Me.dgwCosMan.Rows.Add(dgvrCosMan)
        Next

        If a = 1 Then
            btnProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Else
            btnProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        End If
        Dim obeCoMa As New CostoMantenimiento
        obeCoMa.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")
        obeCoMa.CCMPN = _Compania
        If objCostoMantenimiento_BLL.Validar_Existe_Mes_Anio(obeCoMa) > 0 Then
            MessageBox.Show("Los Costos de Mantenimiento del Mes de " + dbMes.Text + " del " + Me.ndAnio.Value.ToString().Trim() + " fueron registrados.", "Mensaje : ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub Registrar_Consumo_Neumatico()
        Dim objConsumoNeumatico As New ConsumoNeumatico
        Dim objConNeuOpe As New ConsumoNeumatico
        Dim obeCoNe As New ConsumoNeumatico
        obeCoNe.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")
        obeCoNe.CCMPN = _Compania
        If olConNeu IsNot Nothing And olConNeu.Count > 0 Then
            If objConsumoNeumatico_BLL.Validar_Existe_Mes_Anio(obeCoNe) > 0 Then

                If objConsumoNeumatico_BLL.Eliminar_Consumo_Neumatico(obeCoNe).NCONEU = 1 Then
                    objConsumoNeumatico = objConsumoNeumatico_BLL.Registrar_Consumo_Neumatico(olConNeu)
                Else
                    MessageBox.Show("No se eliminó los Consumos de Neumaticos", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                objConsumoNeumatico = objConsumoNeumatico_BLL.Registrar_Consumo_Neumatico(olConNeu)
            End If
            If objConsumoNeumatico.NCONEU <> 0 Then
                HelpClass.MsgBox("Se ha registrado los Consumo de Neumaticos satisfactoriamente", MessageBoxIcon.Information)
                olConNeu = New List(Of ConsumoNeumatico)
            Else
                MessageBox.Show("No se ha registrado Consumo de Neumáticos", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Public Sub Registrar_Consumo_Mantenimiento()
        Dim objCostoMantenimiento As New CostoMantenimiento
        Dim objCosManOpe As New CostoMantenimiento
        Dim obeCoMa As New CostoMantenimiento
        obeCoMa.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")
        obeCoMa.CCMPN = _Compania
        If objCostoMantenimiento_BLL.Validar_Existe_Mes_Anio(obeCoMa) > 0 Then
            If objCostoMantenimiento_BLL.Actualizar_Costo_Mantenimiento(obeCoMa).NCOMNT = 1 Then
                objCostoMantenimiento = objCostoMantenimiento_BLL.Registrar_Costo_Mantenimiento(olCosMan)
            Else
                MessageBox.Show("No se eliminó los Costos de Mantenimiento", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            objCostoMantenimiento = objCostoMantenimiento_BLL.Registrar_Costo_Mantenimiento(olCosMan)
        End If

        If objCostoMantenimiento.NCOMNT <> 0 Then
            HelpClass.MsgBox("Se ha registrado los Consumo de Mantenimiento satisfactoriamente", MessageBoxIcon.Information)
            olCosMan = New List(Of CostoMantenimiento)
        Else
            MessageBox.Show("No se ha registrado Consumo de Mantenimiento", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub Limpiar_Objetos()
        obj_Worksheet = Nothing
        obj_Worksheet2 = Nothing
        obj_Workbook = Nothing
        'obj_Excel.ActiveWorkbook.Close()
        obj_Excel.DisplayAlerts = False
        obj_Excel.Quit()
        obj_Excel = Nothing
    End Sub
#End Region

End Class

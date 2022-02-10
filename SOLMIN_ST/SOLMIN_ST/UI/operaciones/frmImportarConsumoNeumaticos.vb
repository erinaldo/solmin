Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports Ransa.Utilitario

Public Class frmImportarConsumoNeumaticos

#Region "Atributos"
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private obj_Worksheet2 As Object
    Private obj_SheetName As String
    Private olConNeu As List(Of ConsumoNeumatico)
    Private olCosMan As List(Of CostoMantenimiento)
    Private olConNeuOpe As List(Of ConsumoNeumatico)
    Private olCosManOpe As List(Of CostoMantenimiento)
    Private objConsumoNeumatico_BLL As New ConsumoNeumatico_BLL
    Private objCostoMantenimiento_BLL As New CostoMantenimiento_BLL
    'Placa de Unidades no encontradas
    Private olCMNoEnc As New List(Of CostoMantenimiento)
    Private olCNNoEnc As New List(Of ConsumoNeumatico)

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
    Private Sub frmImportarConsumoNeumaticos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub btnExcelCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelCabecera.Click
        Dim NumSheets As Integer
        Dim NomSheets As String
        Dim i As Integer
        Dim n As Integer
        Dim j As Integer  'Adi
        Dim m As Integer  'Adi

        Me.OpenFileDialog.Multiselect = False
        Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal))
        Me.OpenFileDialog.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"
        If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then ' SI DIO CLICK EN ACEPTAR
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

    Private Sub btnAbrirCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirCabecera.Click
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

            btnProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            'Limpiar_Objetos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
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
                Agregar_Fecha_Operacion_Guia_CN()
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
                Agregar_Fecha_Operacion_Guia_CM()
                Registrar_Consumo_Mantenimiento()
            End If
        End If

    End Sub
#End Region

#Region "Metodos y Funciones"

    Public Sub Registrar_Consumo_Neumatico()
        'Dim objConsumoNeumatico As New ConsumoNeumatico
        'Dim objConNeuOpe As New ConsumoNeumatico
        'Dim obeCoNe As New ConsumoNeumatico
        'obeCoNe.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")
        'obeCoNe.CCMPN = _Compania
        'If olConNeuOpe IsNot Nothing And olConNeuOpe.Count > 0 And olConNeu IsNot Nothing And olConNeu.Count > 0 Then
        '    If objConsumoNeumatico_BLL.Validar_Existe_Mes_Anio(obeCoNe) > 0 Then
        '        If objConsumoNeumatico_BLL.Actualizar_Consumo_Neumatico_Operacion(olConNeuOpe).NLQNEM = 1 Then
        '            If objConsumoNeumatico_BLL.Actualizar_Consumo_Neumatico(obeCoNe).NCONEU = 1 Then
        '                objConNeuOpe = objConsumoNeumatico_BLL.Registrar_Consumo_Neumatico_Operacion(olConNeuOpe)
        '                If objConNeuOpe.NLQNEM <> 0 Then
        '                    objConsumoNeumatico = objConsumoNeumatico_BLL.Registrar_Consumo_Neumatico(olConNeu)
        '                End If
        '            Else
        '                MessageBox.Show("No se anuló los Consumos de Neumaticos", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            End If
        '        End If
        '    Else
        '        objConNeuOpe = objConsumoNeumatico_BLL.Registrar_Consumo_Neumatico_Operacion(olConNeuOpe)
        '        If objConNeuOpe.NLQNEM <> 0 Then
        '            objConsumoNeumatico = objConsumoNeumatico_BLL.Registrar_Consumo_Neumatico(olConNeu)
        '        End If
        '    End If
        '    If objConsumoNeumatico.NCONEU <> 0 Then
        '        If olCNNoEnc IsNot Nothing And olCNNoEnc.Count > 0 Then
        '            Dim ofrmOpcionConsumoOperacion As New frmOpcionConsumoOperacion
        '            With ofrmOpcionConsumoOperacion
        '                .olbeConNeu = olCNNoEnc
        '                .Flag = "N"
        '                If .ShowDialog = Windows.Forms.DialogResult.OK Then

        '                End If
        '            End With
        '        Else
        '            HelpClass.MsgBox("Se ha registrado los Consumo de Neumaticos satisfactoriamente", MessageBoxIcon.Information)
        '        End If
        '        olConNeu = New List(Of ConsumoNeumatico)
        '        olConNeuOpe = New List(Of ConsumoNeumatico)
        '        olCNNoEnc = New List(Of ConsumoNeumatico)
        '    Else
        '        MessageBox.Show("No se ha registrado Consumo de Neumáticos", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If

        'End If
    End Sub

    Public Sub Registrar_Consumo_Mantenimiento()
        Dim objCostoMantenimiento As New CostoMantenimiento
        Dim objCosManOpe As New CostoMantenimiento
        Dim obeCoMa As New CostoMantenimiento
        obeCoMa.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")
        obeCoMa.CCMPN = _Compania
        If objCostoMantenimiento_BLL.Validar_Existe_Mes_Anio(obeCoMa) > 0 Then
            If objCostoMantenimiento_BLL.Actualizar_Costo_Mantenimiento_Operacion(olCosManOpe).NLQMNT = 1 Then
                If objCostoMantenimiento_BLL.Actualizar_Costo_Mantenimiento(obeCoMa).NCOMNT = 1 Then
                    objCosManOpe = objCostoMantenimiento_BLL.Registrar_Costo_Mantenimiento_Operacion(olCosManOpe)
                    If objCosManOpe.NLQMNT <> 0 Then
                        objCostoMantenimiento = objCostoMantenimiento_BLL.Registrar_Costo_Mantenimiento(olCosMan)
                    End If
                Else
                    objCostoMantenimiento = objCostoMantenimiento_BLL.Registrar_Costo_Mantenimiento(olCosMan)
                End If
            End If
        Else
            If olCosManOpe IsNot Nothing And olCosManOpe.Count > 0 Then
                objCosManOpe = objCostoMantenimiento_BLL.Registrar_Costo_Mantenimiento_Operacion(olCosManOpe)
                If objCosManOpe.NLQMNT > 0 Then
                    objCostoMantenimiento = objCostoMantenimiento_BLL.Registrar_Costo_Mantenimiento(olCosMan)
                End If
             End If

        End If

        If objCostoMantenimiento.NCOMNT <> 0 Then
            If olCMNoEnc IsNot Nothing And olCMNoEnc.Count > 0 Then
                '*****************************************************
                Dim ofrmOpcionConsumoOperacion As New frmOpcionConsumoOperacion
                With ofrmOpcionConsumoOperacion
                    .olbeCosMnt = olCMNoEnc
                    .Flag = "M"
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    End If
                End With
            Else
                HelpClass.MsgBox("Se ha registrado los Consumo de Mantenimiento satisfactoriamente", MessageBoxIcon.Information)
            End If
            olCosMan = New List(Of CostoMantenimiento)
            olCosManOpe = New List(Of CostoMantenimiento)
            olCMNoEnc = New List(Of CostoMantenimiento)
        Else
            MessageBox.Show("No se ha registrado Consumo de Mantenimiento", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub Limpiar_Objetos()
        obj_Worksheet = Nothing
        obj_Worksheet2 = Nothing
        obj_Workbook = Nothing

        obj_Excel.Quit()
        obj_Excel = Nothing
    End Sub

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

            'If obeConsumoNeumatico.IMPUNI = "" Then dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
            'If obeConsumoNeumatico.TDETRA = "" Then dgvrConNeu.DefaultCellStyle.BackColor = Color.LightYellow
            Me.dgwDatos.Rows.Add(dgvrConNeu)
        Next

        Dim obeCoNe As New ConsumoNeumatico
        obeCoNe.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")

        If objConsumoNeumatico_BLL.Validar_Existe_Mes_Anio(obeCoNe) > 0 Then
            MessageBox.Show("Los Consumos de Neumáticos del Mes de " + dbMes.Text + " del " + Me.ndAnio.Value.ToString().Trim() + " fueron registrados.", "Mensaje : ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

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
                obj_Entidad.TOTALS = obj_Worksheet2.Cells(j + 1, 17).Value
                obj_Entidad.ITPCMT = obj_Worksheet2.Cells(j + 1, 18).Value
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

        Dim obeCoMa As New CostoMantenimiento
        obeCoMa.FECREG = Convert.ToDouble(Me.ndAnio.Value.ToString() + Me.dbMes.SelectedValue.ToString() + "01")
        obeCoMa.CCMPN = _Compania
        If objCostoMantenimiento_BLL.Validar_Existe_Mes_Anio(obeCoMa) > 0 Then
            MessageBox.Show("Los Costos de Mantenimiento del Mes de " + dbMes.Text + " del " + Me.ndAnio.Value.ToString().Trim() + " fueron registrados.", "Mensaje : ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub Agregar_Fecha_Operacion_Guia_CN()
        Dim ofrmOpcionOperacionGuia As New frmOpcionOperacionGuia
        Dim objOperacionTransporte_BLL As New OperacionTransporte_BLL
        Dim olOperacionTransporte As New List(Of OperacionTransporte)
        olConNeuOpe = New List(Of ConsumoNeumatico)
        'Dim olConsNeum As New List(Of ConsumoNeumatico)
        Dim obeConNeu2 As ConsumoNeumatico
        Dim olConNeut As New List(Of ConsumoNeumatico)
        Dim objParametro As New Hashtable
        Dim obeConNemt As ConsumoNeumatico
        Dim adi As Integer = 0
        With ofrmOpcionOperacionGuia
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                objParametro.Add("OPCION", .OPCION)
                objParametro.Add("FECINI", .FechaInicio)
                objParametro.Add("FECFIN", .FechaFin)
                objParametro.Add("CCMPN", _Compania)
                olOperacionTransporte = objOperacionTransporte_BLL.Listar_Operacion_X_Fecha_CN(objParametro)

                'Crear otra Lista de Consumo para sumar Importe Total de las Placas de Unidades que se repitan
                For Each obeConNeu As ConsumoNeumatico In olConNeu
                    If olConNeut.Count = 0 Then
                        obeConNemt = New ConsumoNeumatico
                        obeConNemt.NPLCUN = obeConNeu.NPLCUN
                        obeConNemt.IMPTTL = obeConNeu.IMPTTL
                        olConNeut.Add(obeConNemt)
                        obeConNemt = Nothing
                    Else
                        For Each obeConNemt2 As ConsumoNeumatico In olConNeut
                            If obeConNemt2.NPLCUN = obeConNeu.NPLCUN Then
                                obeConNemt2.IMPTTL += obeConNeu.IMPTTL
                                adi = 1
                                Exit For
                            End If
                        Next
                        If adi = 0 Then
                            obeConNemt = New ConsumoNeumatico
                            obeConNemt.NPLCUN = obeConNeu.NPLCUN
                            obeConNemt.IMPTTL = obeConNeu.IMPTTL
                            olConNeut.Add(obeConNemt)
                        End If
                        adi = 0
                    End If
                Next

                'Utilizar la Nueva Lista de Placas olConNeut para buscar en olOperacionTransporte
                For Each obeConNeu As ConsumoNeumatico In olConNeut
                    Dim SumaKil As Double = 0

                    For Each obeOpeTra As OperacionTransporte In olOperacionTransporte
                        If obeConNeu.NPLCUN = obeOpeTra.NPLCUN Then
                            obeConNeu2 = New ConsumoNeumatico
                            obeConNeu2.NPLCUN = obeOpeTra.NPLCUN
                            obeConNeu2.NOPRCN = obeOpeTra.NOPRCN
                            obeConNeu2.NKMRCR = obeOpeTra.QKMREC
                            obeConNeu2.PMRCMC = obeOpeTra.PMRCMC
                            obeConNeu2.CULUSA = MainModule.USUARIO
                            obeConNeu2.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                            olConNeuOpe.Add(obeConNeu2)
                            SumaKil += obeOpeTra.QKMREC
                        End If
                    Next
                    If SumaKil > 0 Then
                        For Each obeCsNm As ConsumoNeumatico In olConNeuOpe
                            If obeConNeu.NPLCUN = obeCsNm.NPLCUN Then
                                obeCsNm.IGSTOP = obeCsNm.NKMRCR * obeConNeu.IMPTTL / SumaKil
                            End If
                        Next
                    Else
                        'Lista de Placas de Excel No Encontrados para mostrar en Popup
                        Dim CNNoEnc As New ConsumoNeumatico
                        CNNoEnc.NPLCUN = obeConNeu.NPLCUN
                        CNNoEnc.IMPTTL = obeConNeu.IMPTTL
                        olCNNoEnc.Add(CNNoEnc)
                    End If
                Next
            End If
        End With
    End Sub

    Public Sub Agregar_Fecha_Operacion_Guia_CM()
        Dim ofrmOpcionOperacionGuia As New frmOpcionOperacionGuia
        Dim objOperacionTransporte_BLL As New OperacionTransporte_BLL
        Dim olOperacionTransporte As New List(Of OperacionTransporte)
        olCosManOpe = New List(Of CostoMantenimiento)
        'Dim olConsNeum As New List(Of ConsumoNeumatico)
        Dim obeCosMan2 As CostoMantenimiento
        Dim olCosMant As New List(Of CostoMantenimiento)
        Dim objParametro As New Hashtable
        Dim obeCosMntn As CostoMantenimiento
        Dim adi As Integer = 0
        With ofrmOpcionOperacionGuia
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                objParametro.Add("OPCION", .OPCION)
                objParametro.Add("FECINI", .FechaInicio)
                objParametro.Add("FECFIN", .FechaFin)
                objParametro.Add("CCMPN", _Compania)
                olOperacionTransporte = objOperacionTransporte_BLL.Listar_Operacion_X_Fecha_CN(objParametro)

                'Crear otra Lista de Consumo para sumar Importe Total de las Placas de Unidades que se repitan
                For Each obeCosMan As CostoMantenimiento In olCosMan
                    If olCosMant.Count = 0 Then
                        obeCosMntn = New CostoMantenimiento
                        obeCosMntn.NPLCUN = obeCosMan.NPLCUN
                        obeCosMntn.TOTALS = obeCosMan.TOTALS
                        olCosMant.Add(obeCosMntn)
                        obeCosMntn = Nothing
                    Else
                        For Each obeCosMant2 As CostoMantenimiento In olCosMant
                            If obeCosMant2.NPLCUN = obeCosMan.NPLCUN Then
                                obeCosMant2.TOTALS += obeCosMan.TOTALS
                                adi = 1
                                Exit For
                            End If
                        Next
                        If adi = 0 Then
                            obeCosMntn = New CostoMantenimiento
                            obeCosMntn.NPLCUN = obeCosMan.NPLCUN
                            obeCosMntn.TOTALS = obeCosMan.TOTALS
                            olCosMant.Add(obeCosMntn)
                        End If
                        adi = 0
                    End If
                Next

                'Utilizar la Nueva Lista de Placas olConNeut para buscar en olOperacionTransporte
                For Each obeCosMan As CostoMantenimiento In olCosMant
                    Dim Contador As Double = 0

                    For Each obeOpeTra As OperacionTransporte In olOperacionTransporte
                        If obeCosMan.NPLCUN = obeOpeTra.NPLCUN Then
                            obeCosMan2 = New CostoMantenimiento
                            obeCosMan2.NPLCUN = obeOpeTra.NPLCUN
                            obeCosMan2.NOPRCN = obeOpeTra.NOPRCN
                            obeCosMan2.NKMRCR = obeOpeTra.QKMREC
                            obeCosMan2.PMRCMC = obeOpeTra.PMRCMC
                            obeCosMan2.CULUSA = MainModule.USUARIO
                            obeCosMan2.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                            olCosManOpe.Add(obeCosMan2)
                            Contador += 1
                        End If
                    Next
                    If Contador > 0 Then
                        For Each obeCsNm As CostoMantenimiento In olCosManOpe
                            If obeCosMan.NPLCUN = obeCsNm.NPLCUN Then
                                obeCsNm.IGSTOP = obeCosMan.TOTALS / Contador
                            End If
                        Next
                    Else
                        'Lista de Placas de Excel No Encontrados para mostrar en Popup
                        Dim CMNoEnc As New CostoMantenimiento
                        CMNoEnc.NPLCUN = obeCosMan.NPLCUN
                        CMNoEnc.TOTALS = obeCosMan.TOTALS
                        olCMNoEnc.Add(CMNoEnc)
                    End If
                Next
            End If
        End With
    End Sub

    'Private Function Cargar_Operaciones() As String
    '    Dim lstr_Cadena As String = ""
    '    If olConNeuOpe.Count = 0 Then
    '        Return lstr_Cadena
    '        Exit Function
    '    End If
    '    For Each obeOpe As ConsumoNeumatico In olConNeuOpe
    '        lstr_Cadena = lstr_Cadena + obeOpe.NOPRCN.ToString.Trim + ","
    '    Next

    '    If lstr_Cadena.Length <> 0 Then
    '        lstr_Cadena = lstr_Cadena.Substring(0, lstr_Cadena.Length - 1)
    '    End If
    '    Return lstr_Cadena
    'End Function

#End Region

End Class

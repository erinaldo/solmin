Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmImportarValeLiqCombDeExcel

#Region "Atributos"
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private Lista_Vale As String = ""
    Private obj_SheetName As String
    Private _dblCodCliente As Decimal
    Private _strUsuario As String
    Private olComb1 As List(Of Combustible)
    Private obj_CombustibleBLL As New Combustible_BLL
    Private obj_OperacionTransporteBLL As New OperacionTransporte_BLL
    Private obj_LiquidacionCombustibleBLL As New LiquidacionCombustible_BLL

    Public Property dblCodCliente() As Decimal
        Get
            Return _dblCodCliente
        End Get
        Set(ByVal value As Decimal)
            _dblCodCliente = value
        End Set
    End Property


    Public Property strUsuario() As String
        Get
            Return _strUsuario
        End Get
        Set(ByVal value As String)
            _strUsuario = value
        End Set
    End Property

    Private _pTerminal As String
    Public Property pTerminal() As String
        Get
            Return _pTerminal
        End Get
        Set(ByVal value As String)
            _pTerminal = value
        End Set
    End Property


#End Region
#Region "Eventos"
    Private Sub btnExcelCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelCabecera.Click
        Dim NumSheets As Integer
        Dim NomSheets As String
        Dim i As Integer
        Dim n As Integer

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
            n = 2
            i = 0
            obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(2).Name)
            Do Until i = 1 Or n = NmCount.Maximum
                n = n + 1
                If Trim(obj_Worksheet.Cells(n, 2).value) = "" Then
                    i = 1
                End If
            Loop
            NmCount.Value = n - 1
        End If
    End Sub

    Private Sub btnAbrirCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirCabecera.Click
        Try
            Dim i As Integer
            ' -- Verifica si existe el archivo   
            If Len(Dir(Me.TxtRutaXlsCabecera.Text)) = 0 Then
                MsgBox("No se ha encontrado el archivo: " & Me.TxtRutaXlsCabecera.Text, vbCritical)
                Exit Sub
            End If
            '===================================================================
            'Instancia Excel  
            If obj_Excel Is Nothing Then
                obj_Excel = CreateObject("Excel.Application")
                obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsCabecera.Text)
            End If
            ' Referencia la Hoja, por defecto la hoja activa  
            If obj_SheetName = vbNullString Then
                obj_Worksheet = obj_Workbook.ActiveSheet
            Else
                obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
            End If

            'Crear lista de Objeto de tipo Combustible
            Dim olbeCombustible As New List(Of Combustible)
            Dim obj_Entidad As Combustible
            olComb1 = New List(Of Combustible)
            For i = 2 To NmCount.Value - 1
                obj_Entidad = New Combustible
                obj_Entidad.NOPRCN = obj_Worksheet.Cells(i + 1, 2).Value.ToString.Trim
                obj_Entidad.NVLGRF = obj_Worksheet.Cells(i + 1, 3).Value.ToString.Trim
                obj_Entidad.FCRCMB = obj_Worksheet.Cells(i + 1, 4).Value.ToString.Trim
                obj_Entidad.CGRFO = obj_Worksheet.Cells(i + 1, 5).Value.ToString.Trim
                obj_Entidad.CTPCMB = obj_Worksheet.Cells(i + 1, 6).Value.ToString.Trim
                obj_Entidad.QGLNCM = obj_Worksheet.Cells(i + 1, 7).Value.ToString.Trim
                obj_Entidad.CSTGLN = obj_Worksheet.Cells(i + 1, 8).Value.ToString.Trim
                obj_Entidad.NPRCN1 = ("" & obj_Worksheet.Cells(i + 1, 9).Value & "").ToString.Trim
                obj_Entidad.NPRCN2 = ("" & obj_Worksheet.Cells(i + 1, 10).Value & "").ToString.Trim
                obj_Entidad.NPRCN3 = ("" & obj_Worksheet.Cells(i + 1, 11).Value & "").ToString.Trim
                'obj_Entidad.SESSLC = obj_Worksheet.Cells(i + 1, 12).Value.ToString.Trim
                If ("" & obj_Worksheet.Cells(i + 1, 13).Value & "").ToString.Trim = "" Then
                    obj_Entidad.CTPOD1 = 0
                Else
                    obj_Entidad.CTPOD1 = obj_Worksheet.Cells(i + 1, 13).Value.ToString.Trim
                End If

                If ("" & obj_Worksheet.Cells(i + 1, 14).Value & "").ToString.Trim = "" Then
                    obj_Entidad.NDCCT1 = 0
                Else
                    obj_Entidad.NDCCT1 = obj_Worksheet.Cells(i + 1, 14).Value.ToString.Trim
                End If

                If ("" & obj_Worksheet.Cells(i + 1, 15).Value & "").ToString.Trim = "" Then
                    obj_Entidad.FDCCT1 = 0
                Else
                    obj_Entidad.FDCCT1 = obj_Worksheet.Cells(i + 1, 15).Value.ToString.Trim
                End If
                olbeCombustible.Add(obj_Entidad)

                olComb1.Add(obj_Entidad)
            Next
            Dim lsOpe As String = ""
            lsOpe = Cargar_Grilla_Vales(olbeCombustible)
            If dtgVales.Rows.Count > 0 Then
                ListaOperacionesAsignadas()
            End If
            Dim str_MsgError As String = ""
            'If Lista_Vale.Length > 0 Then
            'str_MsgError = Lista_Vale & Chr(13)
            'End If
            If lsOpe.Trim.Length > 0 Then
                str_MsgError = "- Las sgtes. Operaciones " & lsOpe & " no existen" & Chr(13)
            End If
            If str_MsgError.Trim.Length > 0 Then
                HelpClass.MsgBox(str_MsgError, MessageBoxIcon.Warning)
                Lista_Vale = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtgVales_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgVales.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Me.ListaOperacionesAsignadas()
    End Sub

    Private Sub btnAsignarLiquidarCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarLiquidarCombustible.Click
        If Me.dtgVales.RowCount = 0 Then
            HelpClass.MsgBox("Asignar Vales de Combustible", MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Asignacion_Combustible()
        'Dim Fila As String = ""
        'For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
        'If Me.dtgVales.Item("NSLCMB", lint_Contador).Value = -1 Then
        'If Fila <> "" Then
        'Fila = Fila & ", " & lint_Contador + 1
        'Else
        'Fila = lint_Contador + 1
        'End If
        'End If
        'Next
        'If Fila <> "" Then
        'HelpClass.MsgBox("Vale(s) Grifo la(s) fila(s) " & Fila & " ya está registrado, no se puede continuar con la Liquidación", MessageBoxIcon.Warning)
        'Else
        Me.Liquidacion_Combustible()
        HelpClass.MsgBox("Se asignó y liquidó combustible satisfactoriamente", MessageBoxIcon.Information)
        'End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

#End Region
#Region "Metodos y Funciones"
    Private Function Cargar_Grilla_Vales(ByVal olbeCombustible As List(Of Combustible)) As String
        Dim objParam As Hashtable
        'Dim obj_Logica As New Combustible_BLL
        Dim olOpe As List(Of Combustible)
        Dim Lista_Ope As String = ""
        Dim Vale As Integer = 0
        For Each obeCombustible As Combustible In olbeCombustible
            'Valida Vale si esta en RZTR75
            Dim objParamV As New Hashtable
            objParamV.Add("NVLGRF", obeCombustible.NVLGRF)
            objParamV.Add("CCMPN", "EZ")
            If obj_CombustibleBLL.Validar_Existencia_Vale_Asignacion_Combustible(objParamV) = 1 Then
                objParam = New Hashtable
                objParam.Add("NOPRCN", obeCombustible.NOPRCN)
                objParam.Add("CCMPN", "EZ")
                olOpe = obj_CombustibleBLL.Listar_Datos_Adicionales_Asignacion_Combustible(obeCombustible)
                If olOpe IsNot Nothing And olOpe.Count > 0 Then
                    If dtgVales.RowCount = 0 Then
                        Agregar_Vale(obeCombustible, 0)
                    Else
                        Dim Encontrado As Boolean = False
                        For j As Integer = 0 To dtgVales.RowCount - 1
                            If dtgVales.Item(1, j).Value = obeCombustible.NVLGRF Then
                                dtgVales.Item(5, j).Value += obeCombustible.QGLNCM
                                Encontrado = True
                                Exit For
                            Else
                                Encontrado = False
                                Continue For
                            End If
                        Next
                        If Encontrado = False Then
                            Agregar_Vale(obeCombustible, 0)
                        End If
                    End If
                Else
                    Lista_Ope += obeCombustible.NOPRCN + ","
                    If Lista_Ope.Trim.Length > 0 Then
                        Lista_Ope = Lista_Ope.Trim.Substring(0, Lista_Ope.Trim.Length - 1)
                    End If
                End If
            Else
                'Vale = 1
                objParam = New Hashtable
                objParam.Add("NOPRCN", obeCombustible.NOPRCN)
                objParam.Add("CCMPN", "EZ")
                olOpe = obj_CombustibleBLL.Listar_Datos_Adicionales_Asignacion_Combustible(obeCombustible)
                If olOpe IsNot Nothing And olOpe.Count > 0 Then
                    If dtgVales.RowCount = 0 Then
                        Agregar_Vale(obeCombustible, 1)
                    Else
                        Dim Encontrado As Boolean = False
                        For j As Integer = 0 To dtgVales.RowCount - 1
                            If dtgVales.Item(1, j).Value = obeCombustible.NVLGRF Then
                                dtgVales.Item(5, j).Value += obeCombustible.QGLNCM
                                Encontrado = True
                                Exit For
                            Else
                                Encontrado = False
                                Continue For
                            End If
                        Next
                        If Encontrado = False Then
                            Agregar_Vale(obeCombustible, 1)
                        End If
                    End If
                Else
                    If dtgVales.RowCount = 0 Then
                        Agregar_Vale(obeCombustible, 1)
                    Else
                        Dim Encontrado As Boolean = False
                        For j As Integer = 0 To dtgVales.RowCount - 1
                            If dtgVales.Item(1, j).Value = obeCombustible.NVLGRF Then
                                dtgVales.Item(5, j).Value += obeCombustible.QGLNCM
                                Encontrado = True
                                Exit For
                            Else
                                Encontrado = False
                                Continue For
                            End If
                        Next
                        If Encontrado = False Then
                            Agregar_Vale(obeCombustible, 1)
                        End If
                    End If
                    Lista_Ope += obeCombustible.NOPRCN + ","
                    If Lista_Ope.Trim.Length > 0 Then
                        Lista_Ope = Lista_Ope.Trim.Substring(0, Lista_Ope.Trim.Length - 1)
                    End If
                End If
            End If
        Next
        'If Vale = 1 Then
        'Lista_Vale = "- Algunos Vales ya estan registradas y no se mostraran en la grilla"
        'End If
        Return Lista_Ope

    End Function

    Private Sub Agregar_Vale(ByVal obeCombustible As Combustible, ByVal Flag As Integer)
        Dim dgvrVale As DataGridViewRow
        dgvrVale = New DataGridViewRow
        dgvrVale.CreateCells(Me.dtgVales)
        With obeCombustible
            dgvrVale.Cells(0).Value = .NSLCMB
            dgvrVale.Cells(1).Value = .NVLGRF
            dgvrVale.Cells(2).Value = HelpClass.TodayNumeric
            dgvrVale.Cells(3).Value = HelpClass.CFecha_de_8_a_10(.FCRCMB.ToString.Trim)
            dgvrVale.Cells(4).Value = .CTPCMB
            dgvrVale.Cells(5).Value = .QGLNCM
            dgvrVale.Cells(6).Value = .CSTGLN
            dgvrVale.Cells(7).Value = .CGRFO
            dgvrVale.Cells(8).Value = .NPRCN1
            dgvrVale.Cells(9).Value = .NPRCN2
            dgvrVale.Cells(10).Value = .NPRCN3
            dgvrVale.Cells(11).Value = .NDCCT1
            dgvrVale.Cells(12).Value = .CTPOD1
            dgvrVale.Cells(13).Value = .FDCCT1
            If Flag = 1 Then
                dgvrVale.DefaultCellStyle.BackColor = Color.MistyRose
            End If
            Me.dtgVales.Rows.Add(dgvrVale)

        End With
    End Sub

    Private Sub Cargar_Grilla_Operaciones(ByVal olbeCombustible As List(Of Combustible))
        Dim oDt As New DataTable
        oDt.Columns.Add("NOPRCN")
        Dim oDr As DataRow

        For Each obeCombustible As Combustible In olbeCombustible
            oDr = oDt.NewRow()
            oDr.Item("NOPRCN") = obeCombustible.NOPRCN
            oDt.Rows.Add(oDr)
        Next
        Dim oDtOpe As New DataTable
        Dim oDw As DataView = New DataView(oDt)
        oDtOpe = oDw.ToTable(True, "NOPRCN")

        Dim olOpeTra As New List(Of OperacionTransporte)
        If oDtOpe IsNot Nothing AndAlso oDtOpe.Rows.Count > 0 Then
            For Each objDataRow As DataRow In oDtOpe.Rows
                Dim objParametro As New Hashtable
                Dim olOperacionTransporte As New List(Of OperacionTransporte)
                Try
                    objParametro.Add("NOPRCN", objDataRow.Item("NOPRCN"))
                    olOperacionTransporte = obj_OperacionTransporteBLL.Listar_Operacion_Asignar_ImpExcel(objParametro)

                    olOpeTra.Add(olOperacionTransporte.Item(0))
                Catch : End Try
            Next
        End If

    End Sub

    Private Sub ListaOperacionesAsignadas()
        'Eliminar filas de la grilla
        dtgLiquidacion.DataSource = Nothing
        dtgLiquidacion.Rows.Clear()

        Dim olOperacionesDeVale As New List(Of Combustible)
        Dim obj_Entidad As New Combustible
        obj_Entidad.NVLGRF = Me.dtgVales.Item("NVLGRF", Me.dtgVales.CurrentCellAddress.Y).Value.ToString()
        For Each oCombustible As Combustible In olComb1
            If oCombustible.NVLGRF = obj_Entidad.NVLGRF Then
                Dim objParametro As New Hashtable
                Dim olOperacionTransporte As New List(Of OperacionTransporte)
                Try
                    objParametro.Add("NOPRCN", oCombustible.NOPRCN)
                    olOperacionTransporte = obj_OperacionTransporteBLL.Listar_Operacion_Asignar_ImpExcel(objParametro)
                    If olOperacionTransporte.Count > 0 Then
                        Agregar_Operacion(olOperacionTransporte, oCombustible)
                    End If

                Catch : End Try
            End If
        Next
    End Sub

    Private Sub Agregar_Operacion(ByVal olOperacionTransporte As List(Of OperacionTransporte), ByVal oCombustible As Combustible)
        Dim dwv As New DataGridViewRow()
        dwv.CreateCells(Me.dtgLiquidacion)
        dwv.Cells(0).Value = oCombustible.NOPRCN
        dwv.Cells(1).Value = olOperacionTransporte.Item(0).CCLNT
        dwv.Cells(2).Value = olOperacionTransporte.Item(0).TCMPCL
        dwv.Cells(3).Value = olOperacionTransporte.Item(0).RUTA
        dwv.Cells(4).Value = olOperacionTransporte.Item(0).QKMREC
        dwv.Cells(5).Value = olOperacionTransporte.Item(0).PMRCMC
        dwv.Cells(6).Value = olOperacionTransporte.Item(0).QKMREC
        dwv.Cells(7).Value = oCombustible.QGLNCM
        dwv.Cells(8).Value = olOperacionTransporte.Item(0).CTPOVJ
        dwv.Cells(9).Value = olOperacionTransporte.Item(0).NPLCUN
        dwv.Cells(10).Value = olOperacionTransporte.Item(0).NGUIRM
        Me.dtgLiquidacion.Rows.Add(dwv)
    End Sub

    Private Sub Asignacion_Combustible()
        Dim obj_Entidad As New Combustible
        'Dim obj_Logica As New Combustible_BLL
        Dim olDatAdi As New List(Of Combustible)
        Dim oDatAdi As New Combustible
        For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
            For Each oComb As Combustible In olComb1
                If oComb.NVLGRF = Me.dtgVales.Item("NVLGRF", lint_Contador).Value Then
                    olDatAdi = obj_CombustibleBLL.Listar_Datos_Adicionales_Asignacion_Combustible(oComb)
                    Exit For
                End If
            Next
            If olDatAdi IsNot Nothing AndAlso olDatAdi.Count > 0 Then
                obj_Entidad.FSLCMB = HelpClass.TodayNumeric
                obj_Entidad.CCMPN = olDatAdi.Item(0).CCMPN
                obj_Entidad.CDVSN = olDatAdi.Item(0).CDVSN
                obj_Entidad.CPLNDV = olDatAdi.Item(0).CPLNDV
                obj_Entidad.NRUCTR = olDatAdi.Item(0).NRUCTR
                obj_Entidad.NPLCUN = olDatAdi.Item(0).NPLCUN
                obj_Entidad.CBRCNT = olDatAdi.Item(0).CBRCNT
                obj_Entidad.CGRFO = Me.dtgVales.Item("CGRFO", lint_Contador).Value
                obj_Entidad.CTPCMB = Me.dtgVales.Item("CTPCMB", lint_Contador).Value
                obj_Entidad.FCRCMB = CType(HelpClass.CtypeDate(Me.dtgVales.Item("FCRCMB", lint_Contador).Value), Double)
                obj_Entidad.NVLGRF = Me.dtgVales.Item("NVLGRF", lint_Contador).Value
                obj_Entidad.QGLNCM = Me.dtgVales.Item("QGLNCM_V", lint_Contador).Value
                obj_Entidad.NPRCN1 = Me.dtgVales.Item("NPRCN1", lint_Contador).Value
                obj_Entidad.NPRCN2 = Me.dtgVales.Item("NPRCN2", lint_Contador).Value
                obj_Entidad.NPRCN3 = Me.dtgVales.Item("NPRCN3", lint_Contador).Value

                If Me.dtgVales.Item("CSTGLN_V", lint_Contador).Value > 0 Then obj_Entidad.CSTGLN = Me.dtgVales.Item("CSTGLN_V", lint_Contador).Value

                obj_Entidad.NDCCT1 = Me.dtgVales.Item("NDCCT1", lint_Contador).Value
                obj_Entidad.CTPOD1 = Me.dtgVales.Item("CTPOD1", lint_Contador).Value
                obj_Entidad.FDCCT1 = Me.dtgVales.Item("FDCCT1", lint_Contador).Value

                obj_Entidad.CUSCRT = MainModule.USUARIO
                obj_Entidad.FCHCRT = HelpClass.TodayNumeric
                obj_Entidad.HRACRT = HelpClass.NowNumeric
                obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                Dim lNSLCMB As Int64

                lNSLCMB = obj_CombustibleBLL.Registrar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB
                Me.dtgVales.Item("NSLCMB", lint_Contador).Value = lNSLCMB
            End If
        Next
    End Sub

    Private Sub Liquidacion_Combustible()
        Dim oDatAdi As New Combustible
        Dim olDatAdi As New List(Of Combustible)
        Dim olOperacion As New List(Of Combustible)
        Dim obj_LiquidCombustible As New LiquidacionCombustible
        Dim list_Combustible As New List(Of Combustible)
        Dim list_LiquidCombustible As List(Of LiquidacionCombustible)
        Dim lNLQCMB As Int64 = 0
        Dim Liquidado As Integer = 0
        For i As Integer = 0 To dtgVales.Rows.Count - 1
            If Me.dtgVales.Item("NSLCMB", i).Value <> -1 Then
                For Each oComb As Combustible In olComb1
                    If oComb.NVLGRF = Me.dtgVales.Item("NVLGRF", i).Value Then
                        Dim objParam As New Hashtable
                        objParam.Add("NOPRCN", oComb.NOPRCN)
                        objParam.Add("CCMPN", "EZ")
                        olDatAdi = obj_CombustibleBLL.Listar_Datos_Adicionales_Asignacion_Combustible(oComb)
                        If olDatAdi IsNot Nothing AndAlso olDatAdi.Count > 0 Then
                            'Valida Si existe Operacion en RZTR76A
                            If obj_LiquidacionCombustibleBLL.Validar_Existencia_Operacion_Liquidacion(objParam) = 1 Then
                                'Registrar Liquidacion de Combustible        
                                obj_LiquidCombustible.NPLCUN = olDatAdi.Item(0).NPLCUN
                                obj_LiquidCombustible.NRUCTR = olDatAdi.Item(0).NRUCTR
                                obj_LiquidCombustible.CCMPN = olDatAdi.Item(0).CCMPN
                                obj_LiquidCombustible.CDVSN = olDatAdi.Item(0).CDVSN
                                obj_LiquidCombustible.CPLNDV = olDatAdi.Item(0).CPLNDV
                                obj_LiquidCombustible.FLQDCN = HelpClass.TodayNumeric
                                obj_LiquidCombustible.CTPCMB = Me.dtgVales.Item("CTPCMB", i).Value
                                obj_LiquidCombustible.QGLNSA = 0
                                obj_LiquidCombustible.QTGLIN = Me.dtgVales.Item("QGLNCM_V", i).Value
                                obj_LiquidCombustible.QGLNUT = Me.dtgVales.Item("QGLNCM_V", i).Value
                                obj_LiquidCombustible.USRCRT = MainModule.USUARIO
                                obj_LiquidCombustible.FCHCRT = HelpClass.TodayNumeric
                                obj_LiquidCombustible.HRACRT = HelpClass.NowNumeric
                                obj_LiquidCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                                lNLQCMB = obj_LiquidacionCombustibleBLL.Registrar_Liquidacion_Combustible(obj_LiquidCombustible).NLQCMB
                                Liquidado = 0
                                Exit For
                            ElseIf obj_LiquidacionCombustibleBLL.Validar_Existencia_Operacion_Liquidacion(objParam) = -1 Then
                                list_LiquidCombustible = New List(Of LiquidacionCombustible)
                                list_LiquidCombustible = obj_LiquidacionCombustibleBLL.Listar_Operacion_Liquidada(objParam)
                                'Actualizar Nro Liquidacion de Vale
                                Actualizar_Nro_Liquidacion_DeVale(i, lNLQCMB)
                                Actualizar_Liquidacion_Combustible(list_LiquidCombustible.Item(0), oComb, olDatAdi.Item(0))
                                'list_LiquidCombustible.Item(0).NLQCMB
                                Liquidado = 1
                            Else
                                MessageBox.Show("Error al Verificar si Operacion fue Liquidada")
                            End If
                            'Else
                            'MessageBox.Show("Operacion de Transporte No existe")
                        End If
                    End If
                Next

                If Liquidado = 0 Then
                    list_LiquidCombustible = New List(Of LiquidacionCombustible)
                    'Registrar Detalle Liquidacion de Combustible
                    For Each oDetCom As Combustible In olComb1
                        If oDetCom.NVLGRF = Me.dtgVales.Item("NVLGRF", i).Value Then
                            Dim objParametro As New Hashtable
                            Dim olOperacionTransporte As New List(Of OperacionTransporte)
                            Try
                                objParametro.Add("NOPRCN", oDetCom.NOPRCN)
                                olOperacionTransporte = obj_OperacionTransporteBLL.Listar_Operacion_Asignar_ImpExcel(objParametro)
                                If olOperacionTransporte IsNot Nothing AndAlso olOperacionTransporte.Count > 0 Then
                                    If obj_LiquidacionCombustibleBLL.Validar_Existencia_Operacion_Liquidacion(objParametro) = 1 Then
                                        'Agregar_Operacion_A_Liquidar(olOperacionTransporte, oDetCom)
                                        obj_LiquidCombustible = New LiquidacionCombustible
                                        obj_LiquidCombustible.NLQCMB = lNLQCMB
                                        obj_LiquidCombustible.NOPRCN = oDetCom.NOPRCN 'Me.dtgLiquidacion.Item("NOPRCN", lint_Contador).Value
                                        obj_LiquidCombustible.NKMRCR = olOperacionTransporte.Item(0).QKMREC
                                        obj_LiquidCombustible.QGLNCM = oDetCom.QGLNCM
                                        obj_LiquidCombustible.CTPCMB = Me.dtgVales.Item("CTPCMB", i).Value
                                        obj_LiquidCombustible.FULTAC = HelpClass.TodayNumeric
                                        obj_LiquidCombustible.HULTAC = HelpClass.NowNumeric
                                        obj_LiquidCombustible.CULUSA = MainModule.USUARIO
                                        obj_LiquidCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                                        list_LiquidCombustible.Add(obj_LiquidCombustible)
                                    End If
                                End If
                            Catch : End Try
                        End If
                    Next
                    obj_LiquidacionCombustibleBLL.Registrar_Detalle_Liquidacion_Combustible(list_LiquidCombustible)
                    Actualizar_Nro_Liquidacion_DeVale(i, lNLQCMB)
                End If
            End If
        Next
    End Sub

    Private Sub Actualizar_Liquidacion_Combustible(ByVal objLiquidacionCombustible As LiquidacionCombustible, ByVal oCombustible As Combustible, ByVal oDatAdi As Combustible)
        Dim lNLQCMB As Int64 = 0
        'Dim obj_LiquidacionCombustible_Logica As New LiquidacionCombustible_BLL
        Dim obj_LiquidCombustible As New LiquidacionCombustible
        obj_LiquidCombustible.NLQCMB = objLiquidacionCombustible.NLQCMB
        obj_LiquidCombustible.NOPRCN = oCombustible.NOPRCN
        obj_LiquidCombustible.QTGLIN = oCombustible.QGLNCM
        obj_LiquidCombustible.QGLNUT = oCombustible.QGLNCM
        obj_LiquidCombustible.NPLCUN = oDatAdi.NPLCUN
        obj_LiquidCombustible.NRUCTR = oDatAdi.NRUCTR
        obj_LiquidCombustible.CCMPN = oDatAdi.CCMPN
        obj_LiquidCombustible.CDVSN = oDatAdi.CDVSN
        obj_LiquidCombustible.CPLNDV = oDatAdi.CPLNDV
        obj_LiquidCombustible.USRCRT = MainModule.USUARIO
        obj_LiquidCombustible.FCHCRT = HelpClass.TodayNumeric
        obj_LiquidCombustible.HRACRT = HelpClass.NowNumeric
        obj_LiquidCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        lNLQCMB = obj_LiquidacionCombustibleBLL.Actualizar_Liquidacion_Combustible(obj_LiquidCombustible).NLQCMB
    End Sub

    Private Sub Actualizar_Nro_Liquidacion_DeVale(ByVal i As Integer, ByVal lNLQCMB As Int64)
        'Actualizar Nro. Liquidacion en RZTR75
        Dim obj_Combustible As New Combustible
        'Dim obj_Logica2 As New Combustible_BLL
        obj_Combustible.NSLCMB = Me.dtgVales.Item("NSLCMB", i).Value
        obj_Combustible.NLQCMB = lNLQCMB
        obj_Combustible.FCHLQD = HelpClass.TodayNumeric
        obj_Combustible.HRALQD = HelpClass.NowNumeric
        obj_Combustible.USRLQD = MainModule.USUARIO
        obj_Combustible.FULTAC = HelpClass.TodayNumeric
        obj_Combustible.HULTAC = HelpClass.NowNumeric
        obj_Combustible.CULUSA = MainModule.USUARIO
        obj_Combustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        obj_CombustibleBLL.Actualizar_Asignacion_Combustible_Tracto_EX(obj_Combustible)
    End Sub

#End Region


    Private Sub dtgVales_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgVales.KeyUp
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                Me.ListaOperacionesAsignadas()
        End Select
    End Sub
End Class

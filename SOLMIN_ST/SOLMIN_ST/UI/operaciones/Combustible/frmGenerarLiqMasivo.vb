
Imports System.IO
Imports RANSA.Utilitario
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmGenerarLiqMasivo


    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Private UltimaRuta As String = ""
    Private dtCarga As New DataTable
    Public gdtGrifos As New DataTable

    Private Sub frmCargaMasivaVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCargaVale.AutoGenerateColumns = False

        CargaGrifos()
    End Sub
    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click
        Try
            CargaFormato()
        Catch ex As Exception

            MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub CargaGrifos()
        Dim obrGrifo As New SOLMIN_ST.NEGOCIO.mantenimientos.Grifo_BLL
        gdtGrifos = obrGrifo.Listar_Grifo_Validacion_Carga
    End Sub
    Private Sub CargaFormato()

        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object
        Dim obj_SheetName As String

        Dim oUtil As New mUtilEstructuraST

        Dim openFileDialog1 As New OpenFileDialog()
        Dim fileName As String = ""
        Dim source As String = ""
        Dim extension As String = ""

        openFileDialog1.Multiselect = False
        If UltimaRuta = "" Then
            openFileDialog1.InitialDirectory = (System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal))
        Else
            openFileDialog1.InitialDirectory = UltimaRuta
        End If

        openFileDialog1.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileName = openFileDialog1.FileName
            extension = Path.GetExtension(openFileDialog1.FileName)
            source = Path.GetFileNameWithoutExtension(openFileDialog1.FileName)
            UltimaRuta = Path.GetDirectoryName(openFileDialog1.FileName)
        Else
            Exit Sub
        End If


        If Len(Dir(fileName)) = 0 Then
            MsgBox("No se ha encontrado el archivo: " & fileName, vbCritical)
            Exit Sub
        End If
        '===================================================================
        ' -- RUTINA EXCEL   Instancia Excel  
        If obj_Excel Is Nothing Then
            obj_Excel = CreateObject("Excel.Application")
            obj_Workbook = obj_Excel.Workbooks.Open(fileName)
        End If
        ' -- Referencia la Hoja, por defecto la hoja activa  
        If obj_SheetName = vbNullString Then
            obj_Worksheet = obj_Workbook.ActiveSheet
        Else
            obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
        End If

        Dim i As Integer
        Dim NumSheets As Integer
        Dim NomSheets As String

        NumSheets = obj_Workbook.sheets.count()
        For i = 1 To NumSheets
            NomSheets = obj_Workbook.Sheets.Item(i).Name
        Next

        Dim MaxReg As Int64 = 65536


        dtCarga.Columns.Clear()
        dtCarga.Rows.Clear()

        Dim PosExcel As New Hashtable

        dtCarga.Columns.Add("BLOQUE_LIQ")
        dtCarga.Columns.Add("PLACA")
        dtCarga.Columns.Add("RUC_RAZON_SOCIAL")
        dtCarga.Columns.Add("GRIFO")
        dtCarga.Columns.Add("NRO_VALE")
        dtCarga.Columns.Add("TIPO_COMB")
        dtCarga.Columns.Add("FECHA_VALE")
        dtCarga.Columns.Add("CANT_GAL")
        dtCarga.Columns.Add("COSTO_GAL")
        dtCarga.Columns.Add("PRECINTO1")
        dtCarga.Columns.Add("PRECINTO2")
        dtCarga.Columns.Add("PRECINTO3")
        dtCarga.Columns.Add("CANT_UREA1_LT")
        dtCarga.Columns.Add("COSTO_UREA1_GL")
        dtCarga.Columns.Add("CANT_UREA2_LT")
        dtCarga.Columns.Add("COSTO_UREA2_GL")

        Dim dtListaRegla As New DataTable
        dtListaRegla = AsignarReglaValidacionCarga_Ubicacion()

        Dim ListadoValidacion As New List(Of String)
        Dim NombreColumna As String = ""
        For ColIndex As Integer = 0 To dtCarga.Columns.Count - 1
            NombreColumna = dtCarga.Columns(ColIndex).ColumnName
            PosExcel(NombreColumna) = ColIndex + 1
            ListadoValidacion.Add(NombreColumna)
        Next


        Dim FilaRegFormato As Integer = 2
        Dim CeldaColumnaExcel As String = ""
        Dim CeldaColumnaFormato As String = ""
        Dim FormatoOK As Boolean = True
        Dim msgEncontrado As String = ""
        Dim PosCol As Int64 = 0
        Try
            For ColIndex As Integer = 0 To dtCarga.Columns.Count - 1
                CeldaColumnaFormato = dtCarga.Columns(ColIndex).ColumnName
                PosCol = PosExcel(CeldaColumnaFormato)
                CeldaColumnaExcel = ("" & obj_Worksheet.Cells(FilaRegFormato, PosCol).Value).ToString.Trim
                If CeldaColumnaFormato <> CeldaColumnaExcel Then
                    FormatoOK = False
                    Exit For
                End If
            Next
        Catch ex As Exception
            FormatoOK = False
            msgEncontrado = ex.Message
        End Try


        If FormatoOK = False Then

            Dim muestrMensaje As String = "Estructura no válida"
            If msgEncontrado.Length > 0 Then
                muestrMensaje = muestrMensaje & Chr(10) & msgEncontrado

            End If
            MessageBox.Show(muestrMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        dtCarga.Columns.Add("OBS_CARGA")
        dtCarga.Columns.Add("OBS_REGISTRO")

        Dim InicioFilaReg As Int64 = FilaRegFormato + 1
        Dim CeldaValor As String = ""
        Dim msg_carga_validacion As String = ""
        Dim msg_carga As String = ""

        Dim drReg As DataRow

        Dim dtUbicacion As New DataTable
        Dim drGrifo() As DataRow
        Dim RucRazonSocial As String = ""
        Dim RefCodEstacion As String = ""
        Dim oListBloq As New Hashtable
        Dim Bloque As String = ""
        Dim Placa As String = ""
        Dim PlacaHash As String = ""
        For i = InicioFilaReg To MaxReg
            msg_carga_validacion = ""

            CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("BLOQUE_LIQ")).Value).ToString.Trim
            If CeldaValor = "" Then
                Exit For
            End If
            drReg = dtCarga.NewRow

            For Each item As String In ListadoValidacion
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel(item)).Value).ToString.Trim
                msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                drReg(item) = CeldaValor
            Next
            msg_carga_validacion = msg_carga_validacion.Trim
            RucRazonSocial = ("" & obj_Worksheet.Cells(i, PosExcel("RUC_RAZON_SOCIAL")).Value).ToString.Trim
            RefCodEstacion = ("" & obj_Worksheet.Cells(i, PosExcel("GRIFO")).Value).ToString.Trim
            Bloque = ("" & obj_Worksheet.Cells(i, PosExcel("BLOQUE_LIQ")).Value).ToString.Trim
            Placa = ("" & obj_Worksheet.Cells(i, PosExcel("PLACA")).Value).ToString.Trim

            If Not oListBloq.Contains(Bloque) Then
                oListBloq(Bloque) = Placa
            Else
                PlacaHash = oListBloq(Bloque)
                If Placa <> PlacaHash Then
                    msg_carga_validacion = msg_carga_validacion & " Bloque con placa ya asignada previamente."
                End If
            End If

            drGrifo = gdtGrifos.Select("NRUCPR='" & RucRazonSocial & "' AND TGRFO='" & RefCodEstacion & "'")
            If drGrifo.Length = 0 Then
                msg_carga_validacion = msg_carga_validacion & " Combinación Razón Social/ Grifo no existe."
            End If

            If msg_carga_validacion = "" Then
                msg_carga_validacion = "OK"
            End If
            drReg("OBS_CARGA") = msg_carga_validacion
            dtCarga.Rows.Add(drReg)
        Next

        dgvCargaVale.DataSource = dtCarga

    End Sub

    Private Function AsignarReglaValidacionCarga_Ubicacion() As DataTable
        Dim dtReglaValidacion As New DataTable
        Dim oUtil As New mUtilEstructuraST
        dtReglaValidacion = oUtil.EstructuraValidacionColumna

        Dim drRV As DataRow
         

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "BLOQUE_LIQ"
        drRV("MAX_LONGITUD") = 3
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.NUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "PLACA"
        drRV("MAX_LONGITUD") = 10
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "RUC_RAZON_SOCIAL"
        drRV("MAX_LONGITUD") = 20
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "GRIFO"
        drRV("MAX_LONGITUD") = 100
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("ENTEROS") = 15
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "NRO_VALE"
        drRV("MAX_LONGITUD") = 15
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "TIPO_COMB"
        drRV("MAX_LONGITUD") = 5
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "FECHA_VALE"
        drRV("MAX_LONGITUD") = 10
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.FECHA.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CANT_GAL"
        drRV("OBLIGATORIEDAD") = "S"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 2
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COSTO_GAL"
        drRV("OBLIGATORIEDAD") = "N"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 2
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "PRECINTO1"
        drRV("MAX_LONGITUD") = 15
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "N"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "PRECINTO2"
        drRV("MAX_LONGITUD") = 15
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "N"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "PRECINTO1"
        drRV("MAX_LONGITUD") = 15
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "N"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CANT_UREA1_LT"
        drRV("OBLIGATORIEDAD") = "N"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 2
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COSTO_UREA1_GL"
        drRV("OBLIGATORIEDAD") = "N"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 2
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CANT_UREA2_LT"
        drRV("OBLIGATORIEDAD") = "N"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 2
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COSTO_UREA2_GL"
        drRV("OBLIGATORIEDAD") = "N"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 2
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        Return dtReglaValidacion
    End Function



    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Try
            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel

                Case "tpCargaVale"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Resultado"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Resultado"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Resultado"))
                    'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                    objDt = CType(Me.dgvCargaVale.DataSource, DataTable).Copy
                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgvCargaVale, objDt))
                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim drError() As DataRow
            If dtCarga.Rows.Count = 0 Then
                MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            drError = dtCarga.Select("OBS_CARGA <> 'OK'")
            If drError.Length > 0 Then
                MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            drError = dtCarga.Select("OBS_REGISTRO = 'OK'")
            If drError.Length > 0 Then
                MessageBox.Show("Cargue nuevamente.Registros ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim USUARIO As String = MainModule.USUARIO
            Dim TERMINAL As String = Ransa.Utilitario.HelpClass.NombreMaquina
            Dim msgresult As String = ""


            Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
            Dim objParametro As New LiquidacionCombustible

            For Each item As DataRow In dtCarga.Rows
                objParametro = New LiquidacionCombustible
                objParametro.CCMPN = pCCMPN
                objParametro.CDVSN = pCDVSN
                objParametro.REF_GRIFO = item("REF_GRIFO")
                objParametro.NRUCPR = item("RUC_RAZON_SOCIAL")
                objParametro.NVLGRS = item("NRO_VALE")
                objParametro.CSTGLN = item("IMPORTE")
                objParametro.CULUSA = MainModule.USUARIO
                objParametro.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                msgresult = obj_LogicaLiquidacion.Actualizar_Importe_Vale_Desde_Excel(objParametro)
                If msgresult = "" Then
                    item("OBS_REGISTRO") = "OK"
                Else
                    item("OBS_REGISTRO") = msgresult
                End If
            Next
            dgvCargaVale.DataSource = dtCarga
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub btnGenLiq_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub
End Class

Imports System.IO
Imports RANSA.Utilitario
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports NPOI.HSSF.UserModel
Imports NPOI.SS.UserModel
Public Class frmImportarVale
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""


    Private UltimaRuta As String = ""
    Private dtCarga As New DataTable
    Public gdtGrifos As New DataTable
    Public pDialog As Boolean = False
    Private Sub frmCargaMasivaVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvCargaVale.AutoGenerateColumns = False
           
            CargaGrifos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    

    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click
        Try
            CargaFormato()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargaGrifos()
        Dim obrGrifo As New SOLMIN_ST.NEGOCIO.mantenimientos.Grifo_BLL
        gdtGrifos = obrGrifo.Listar_Grifo_Validacion_Carga
    End Sub
    Private Sub CargaFormato()



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

        Dim i As Integer


        Dim hssfwb As HSSFWorkbook
        Dim file As FileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
        hssfwb = New HSSFWorkbook(file)
        Dim oSheet As NPOI.SS.UserModel.Sheet
        oSheet = hssfwb.GetSheetAt(0)



        Dim MaxReg As Int64 = oSheet.LastRowNum



        dtCarga.Columns.Clear()
        dtCarga.Rows.Clear()

        Dim PosExcel As New Hashtable


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


        Dim dtListaRegla As New DataTable
        dtListaRegla = AsignarReglaValidacionCarga_Ubicacion()

        Dim ListadoValidacion As New List(Of String)
        Dim NombreColumna As String = ""
        For ColIndex As Integer = 0 To dtCarga.Columns.Count - 1
            NombreColumna = dtCarga.Columns(ColIndex).ColumnName
            PosExcel(NombreColumna) = ColIndex
            ListadoValidacion.Add(NombreColumna)
        Next



        Dim FilaRegFormato As Integer = 1
        Dim CeldaColumnaExcel As String = ""
        Dim CeldaColumnaFormato As String = ""
        Dim FormatoOK As Boolean = True
        Dim msgEncontrado As String = ""
        Dim PosCol As Int64 = 0
        Dim dtformater As New DataFormatter
        Try
            For ColIndex As Integer = 0 To dtCarga.Columns.Count - 1
                CeldaColumnaFormato = dtCarga.Columns(ColIndex).ColumnName
                PosCol = PosExcel(CeldaColumnaFormato)
                CeldaColumnaExcel = dtformater.FormatCellValue(oSheet.GetRow(FilaRegFormato).GetCell(PosCol))
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

            Dim msgMensaje As String = "Estructura no válida"
            If msgEncontrado.Length > 0 Then
                msgMensaje = msgMensaje & Chr(10) & msgEncontrado

            End If
            MessageBox.Show(msgMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        Dim Placa As String = ""

        For i = InicioFilaReg To MaxReg
            msg_carga_validacion = ""


            CeldaValor = ("" & dtformater.FormatCellValue(oSheet.GetRow(i).GetCell(PosExcel("PLACA")))).ToString.Trim
            If CeldaValor = "" Then
                Exit For
            End If
            drReg = dtCarga.NewRow

            For Each item As String In ListadoValidacion

                CeldaValor = ("" & dtformater.FormatCellValue(oSheet.GetRow(i).GetCell(PosExcel(item)))).ToString.Trim
                msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                drReg(item) = CeldaValor
            Next
            msg_carga_validacion = msg_carga_validacion.Trim

            RucRazonSocial = ("" & dtformater.FormatCellValue(oSheet.GetRow(i).GetCell(PosExcel("RUC_RAZON_SOCIAL")))).ToString.Trim
            RefCodEstacion = ("" & dtformater.FormatCellValue(oSheet.GetRow(i).GetCell(PosExcel("GRIFO")))).ToString.Trim
            Placa = ("" & dtformater.FormatCellValue(oSheet.GetRow(i).GetCell(PosExcel("PLACA")))).ToString.Trim

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
        drRV("MAX_LONGITUD") = 12
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
        drRV("MAX_LONGITUD") = 8
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
        drRV("COLUMNA") = "PRECINTO3"
        drRV("MAX_LONGITUD") = 15
        drRV("TIPO_DATO") = mUtilEstructuraST.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "N"
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
                objParametro.PLACA = item("PLACA")
                objParametro.GRIFO = item("GRIFO")
                objParametro.NRUCPR = item("RUC_RAZON_SOCIAL")
                objParametro.NVLGRS = item("NRO_VALE")
                objParametro.FCRCMB = item("FECHA_VALE")
                objParametro.CTPCMB = item("TIPO_COMB")
                objParametro.QGLNCM = item("CANT_GAL")
                objParametro.CSTGLN = Val("" & item("COSTO_GAL"))
                objParametro.NPRCN1 = item("PRECINTO1")
                objParametro.NPRCN2 = item("PRECINTO2")
                objParametro.NPRCN3 = item("PRECINTO3")
                objParametro.CULUSA = MainModule.USUARIO
                objParametro.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                msgresult = obj_LogicaLiquidacion.Registrar_Vale_Masivo_Desde_Excel(objParametro)
                pDialog = True
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


     

     

 
    
   

    



     
End Class
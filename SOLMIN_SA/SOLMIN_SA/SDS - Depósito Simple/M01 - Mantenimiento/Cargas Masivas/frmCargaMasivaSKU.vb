Imports System.IO
Imports Ransa.Utilitario

'Imports Ransa.TYPEDEF.Cliente
Imports Ransa.NEGO.slnSOLMIN_SDS.MantenimientoSDS
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.TypeDef.slnSOLMIN_SDS_SIMPLE


Public Class frmCargaMasivaSKU
   
    Private UltimaRuta As String = ""

    Private dtUnidMedCantidad As New DataTable
    Private dtUnidMedPeso As New DataTable
    Private dtUnidMedValor As New DataTable



    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click
        'Try
        Dim TabSel As String = TabControl1.SelectedTab.Name
        Select Case TabSel
            Case "tpCargaSKU"
                CargaFormatoSKU()
            Case "tpCargaOS"
                CargaFormatoOrdenServicio()


        End Select
        'Catch ex As Exception
        '    'Limpiar()
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub




    Private Function AsignarReglaValidacionCargaSKU() As DataTable
        Dim dtReglaValidacion As New DataTable
        Dim oUtil As New mUtilEstructura

        dtReglaValidacion = oUtil.EstructuraValidacionColumna

        Dim drRV As DataRow

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "SKU"
        drRV("MAX_LONGITUD") = 30
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "DESCRIPCION_SKU"
        drRV("MAX_LONGITUD") = 50
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "DESCRIPCION_SKU_ADIC"
        drRV("MAX_LONGITUD") = 75
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "MARCA_MODELO"
        drRV("MAX_LONGITUD") = 40
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COD_FAMILIA"
        drRV("MAX_LONGITUD") = 3
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COD_GRUPO"
        drRV("MAX_LONGITUD") = 4
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COD_MERCADERIA_RANSA"
        drRV("MAX_LONGITUD") = 10
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)




        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "MONEDA_COSTO"
        drRV("MAX_LONGITUD") = 3
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("LISTA_VALORES") = "SOL,DOL"
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COSTO"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 5
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "LARGO"
        drRV("ENTEROS") = 5
        drRV("DECIMALES") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "ANCHO"
        drRV("ENTEROS") = 5
        drRV("DECIMALES") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "ALTO"
        drRV("ENTEROS") = 5
        drRV("DECIMALES") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "AREA"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "M3"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COD_INFLAMABILIDAD"
        drRV("MAX_LONGITUD") = 2
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COD_PERFUMANCIA"
        drRV("MAX_LONGITUD") = 2
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "COD_APILABILIDAD"
        drRV("MAX_LONGITUD") = 2
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "EAN13"
        drRV("MAX_LONGITUD") = 15
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CONTROL_UBICACION"
        drRV("MAX_LONGITUD") = 2
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        'drRV("LISTA_VALORES") = "N,,X"
        drRV("LISTA_VALORES") = "SI,"

        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CONTROL_LOTE"
        drRV("MAX_LONGITUD") = 2
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        'drRV("LISTA_VALORES") = "N,,X"
        drRV("LISTA_VALORES") = "SI,"
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CONTROL_SERIE"
        drRV("MAX_LONGITUD") = 2
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        'drRV("LISTA_VALORES") = "N,,X"
        drRV("LISTA_VALORES") = "SI,"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "GENERAR_OS"
        drRV("MAX_LONGITUD") = 2
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("LISTA_VALORES") = "SI,"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "OS_UM_CANTIDAD"
        drRV("MAX_LONGITUD") = 3
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "OS_UM_PESO"
        drRV("MAX_LONGITUD") = 3
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "OS_UM_VALOR"
        drRV("MAX_LONGITUD") = 3
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "OS_UM_DESPACHO"
        drRV("MAX_LONGITUD") = 1
        drRV("LISTA_VALORES") = "C,P"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)




        Return dtReglaValidacion
    End Function


    Private Function AsignarReglaValidacionCargaOrdenServicio() As DataTable
        Dim dtReglaValidacion As New DataTable
        Dim oUtil As New mUtilEstructura
        dtReglaValidacion = oUtil.EstructuraValidacionColumna

        Dim drRV As DataRow

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "SKU"
        drRV("MAX_LONGITUD") = 30
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "UNID_MED_CANTIDAD_OS"
        drRV("MAX_LONGITUD") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "UNID_MED_PESO_OS"
        drRV("MAX_LONGITUD") = 5
        drRV("OBLIGATORIEDAD") = "S"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "UNID_MED_VALOR_OS"
        drRV("MAX_LONGITUD") = 5
        drRV("OBLIGATORIEDAD") = "S"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "UNIDAD_DESPACHO_OS"
        drRV("MAX_LONGITUD") = 1
        drRV("OBLIGATORIEDAD") = "S"
        drRV("LISTA_VALORES") = "C,P"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)



        Return dtReglaValidacion
    End Function


    'Private Sub Limpiar()
    '    obj_Workbook.Close()
    '    obj_Excel = Nothing
    '    obj_Workbook = Nothing
    '    obj_Worksheet = Nothing
    'End Sub



    Private dtCargaOS As New DataTable

    Private Sub CargaFormatoOrdenServicio()

        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object
        Dim obj_SheetName As String

        Try

            Dim oUtil As New mUtilEstructura
            Dim oValida As New ValidarCaracterEspeciales
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

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

            dtCargaOS.Rows.Clear()
            dtCargaOS.Columns.Clear()

            'Dim dtCarga As New DataTable
            Dim PosExcel As New Hashtable
            dtCargaOS.Columns.Add("SKU")
            dtCargaOS.Columns.Add("UNID_MED_CANTIDAD_OS")
            dtCargaOS.Columns.Add("UNID_MED_PESO_OS")
            dtCargaOS.Columns.Add("UNID_MED_VALOR_OS")
            dtCargaOS.Columns.Add("UNIDAD_DESPACHO_OS")

            Dim dtListaRegla As New DataTable
            dtListaRegla = AsignarReglaValidacionCargaOrdenServicio()



            Dim ListadoValidacion As New List(Of String)
            Dim NombreColumna As String = ""
            For ColIndex As Integer = 0 To dtCargaOS.Columns.Count - 1
                NombreColumna = dtCargaOS.Columns(ColIndex).ColumnName
                PosExcel(NombreColumna) = ColIndex + 1
                ListadoValidacion.Add(NombreColumna)
            Next


            Dim FilaRegFormato As Integer = 3
            Dim CeldaColumnaExcel As String = ""
            Dim CeldaColumnaFormato As String = ""
            Dim FormatoOK As Boolean = True
            Dim msgEncontrado As String = ""
            Dim PosCol As Int64 = 0
            Try
                For ColIndex As Integer = 0 To dtCargaOS.Columns.Count - 1
                    CeldaColumnaFormato = dtCargaOS.Columns(ColIndex).ColumnName
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

            dtCargaOS.Columns.Add("OBS_CARGA")
            dtCargaOS.Columns.Add("OBS_REGISTRO")



            Dim obrMercaderia As New Ransa.NEGO.brMercaderia
            Dim ods As New DataSet
            'Dim dtUnidMedCantidad As New DataTable
            'Dim dtUnidMedPeso As New DataTable
            'Dim dtUnidMedValor As New DataTable

            'ods = obrMercaderia.fListUnidadesMedidaOS()
            'dtUnidMedCantidad = ods.Tables(0)
            'dtUnidMedPeso = ods.Tables(1)
            'dtUnidMedValor = ods.Tables(2)




            Dim InicioFilaReg As Int64 = FilaRegFormato + 1
            Dim CeldaValor As String = ""
            Dim msg_carga_validacion As String = ""
            Dim msg_carga As String = ""

            Dim drReg As DataRow
            Dim drExiste() As DataRow



            For i = InicioFilaReg To MaxReg
                msg_carga_validacion = ""
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("SKU")).Value).ToString.Trim
                If CeldaValor = "" Then
                    Exit For
                End If
                drReg = dtCargaOS.NewRow

                For Each item As String In ListadoValidacion
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel(item)).Value).ToString.Trim
                    msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                    If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                    drReg(item) = CeldaValor
                Next
                msg_carga_validacion = msg_carga_validacion.Trim



                'VALIDACION U. Cantidad
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("UNID_MED_CANTIDAD_OS")).Value).ToString.Trim
                drExiste = dtUnidMedCantidad.Select("CUNDMD='" & CeldaValor & "'")
                If drExiste.Length = 0 Then
                    msg_carga_validacion = msg_carga_validacion & Chr(10) & "Unid. Medida Cantidad no existe."
                End If

                ' VALIDACION U. peso
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("UNID_MED_PESO_OS")).Value).ToString.Trim
                If CeldaValor <> "" Then
                    drExiste = dtUnidMedPeso.Select("CUNDMD='" & CeldaValor & "'")
                    If drExiste.Length = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Unid. Medida Peso no existe."
                    End If
                End If

                ' VALIDACION U. Valor
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("UNID_MED_VALOR_OS")).Value).ToString.Trim
                If CeldaValor <> "" Then
                    drExiste = dtUnidMedValor.Select("CUNDMD='" & CeldaValor & "'")
                    If drExiste.Length = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Unid. Medida Valor no existe."
                    End If
                End If

                msg_carga_validacion = msg_carga_validacion.Trim
                If msg_carga_validacion = "" Then
                    msg_carga_validacion = "OK"
                End If
                drReg("OBS_CARGA") = msg_carga_validacion
                dtCargaOS.Rows.Add(drReg)
            Next
            'Limpiar()
            dgcargasos.DataSource = dtCargaOS

            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If

        Catch ex As Exception

            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       


    End Sub

    Private dtCargaSKU As New DataTable

    Private Sub CargaFormatoSKU()

        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object
        Dim obj_SheetName As String

        Try
            Dim oUtil As New mUtilEstructura
            Dim oValida As New ValidarCaracterEspeciales
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

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
            dtCargaSKU.Rows.Clear()
            dtCargaSKU.Columns.Clear()

            'Dim dtCarga As New DataTable
            Dim PosExcel As New Hashtable
            dtCargaSKU.Columns.Add("SKU")
            dtCargaSKU.Columns.Add("DESCRIPCION_SKU")
            dtCargaSKU.Columns.Add("DESCRIPCION_SKU_ADIC")
            dtCargaSKU.Columns.Add("MARCA_MODELO")
            dtCargaSKU.Columns.Add("COD_FAMILIA")
            dtCargaSKU.Columns.Add("COD_GRUPO")
            dtCargaSKU.Columns.Add("COD_MERCADERIA_RANSA")
            dtCargaSKU.Columns.Add("MONEDA_COSTO")
            dtCargaSKU.Columns.Add("COSTO")
            dtCargaSKU.Columns.Add("LARGO")
            dtCargaSKU.Columns.Add("ANCHO")
            dtCargaSKU.Columns.Add("ALTO")
            dtCargaSKU.Columns.Add("AREA")
            dtCargaSKU.Columns.Add("M3")
            dtCargaSKU.Columns.Add("COD_INFLAMABILIDAD")
            dtCargaSKU.Columns.Add("COD_PERFUMANCIA")
            dtCargaSKU.Columns.Add("COD_APILABILIDAD")
            dtCargaSKU.Columns.Add("EAN13")
            dtCargaSKU.Columns.Add("CONTROL_UBICACION")
            dtCargaSKU.Columns.Add("CONTROL_LOTE")
            dtCargaSKU.Columns.Add("CONTROL_SERIE")

            dtCargaSKU.Columns.Add("GENERAR_OS")
            dtCargaSKU.Columns.Add("OS_UM_CANTIDAD")
            dtCargaSKU.Columns.Add("OS_UM_PESO")
            dtCargaSKU.Columns.Add("OS_UM_VALOR")
            dtCargaSKU.Columns.Add("OS_UM_DESPACHO")




            Dim dtListaRegla As DataTable = AsignarReglaValidacionCargaSKU()


            Dim ListadoValidacion As New List(Of String)
            Dim NombreColumna As String = ""
            For ColIndex As Integer = 0 To dtCargaSKU.Columns.Count - 1
                NombreColumna = dtCargaSKU.Columns(ColIndex).ColumnName
                PosExcel(NombreColumna) = ColIndex + 1
                ListadoValidacion.Add(NombreColumna)
            Next


            Dim FilaRegFormato As Integer = 3
            Dim CeldaColumnaExcel As String = ""
            Dim CeldaColumnaFormato As String = ""
            Dim FormatoOK As Boolean = True
            Dim msgEncontrado As String = ""
            Dim PosCol As Int64 = 0
            Try
                For ColIndex As Integer = 0 To dtCargaSKU.Columns.Count - 1
                    CeldaColumnaFormato = dtCargaSKU.Columns(ColIndex).ColumnName
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



            dtCargaSKU.Columns.Add("OBS_CARGA")
            dtCargaSKU.Columns.Add("OBS_REGISTRO")
            dtCargaSKU.Columns.Add("OBS_REGISTRO_OS")

            'dtCargaSKU.Columns.Add("OBS_CARGA_OS")





            Dim objNeg As New Ransa.NEGO.brDespachoMasivo
            Dim ods As New DataSet
            Dim dtGrupoFamilia As New DataTable
            Dim dtPerfumancia As New DataTable
            Dim dtInflamabilidad As New DataTable
            Dim dtApilabilidad As New DataTable
            ods = objNeg.ListarTablaVCalidacionCarga(txtCliente.pCodigo)
            dtGrupoFamilia = ods.Tables(0)
            dtApilabilidad = ods.Tables(1)
            dtInflamabilidad = ods.Tables(2)
            dtApilabilidad = ods.Tables(3)



            Dim InicioFilaReg As Int64 = FilaRegFormato + 1
            Dim CeldaValor As String = ""
            Dim msg_carga_validacion As String = ""
            Dim msg_carga As String = ""

            Dim drReg As DataRow
            Dim drExiste() As DataRow
            Dim CodGrupo As String = ""
            Dim CodFamilia As String = ""

            Dim CostoSKU As String = ""
            Dim generarOS As String = ""
            For i = InicioFilaReg To MaxReg
                msg_carga_validacion = ""
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("SKU")).Value)
                If CeldaValor = "" Then
                    Exit For
                End If
                drReg = dtCargaSKU.NewRow

                For Each item As String In ListadoValidacion
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel(item)).Value).ToString.Trim
                    msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                    If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                    drReg(item) = CeldaValor
                Next
                msg_carga_validacion = msg_carga_validacion.Trim

                'VALIDACION GRUPO FAMILIA
                CodFamilia = ("" & obj_Worksheet.Cells(i, PosExcel("COD_FAMILIA")).Value).ToString.Trim
                drExiste = dtGrupoFamilia.Select("CFMCLR='" & CodFamilia & "'")
                If drExiste.Length = 0 Then
                    msg_carga_validacion = msg_carga_validacion & Chr(10) & "Código Familia no existe."
                End If
                If drExiste.Length > 0 Then
                    'VALIDACION GRUPO
                    CodGrupo = ("" & obj_Worksheet.Cells(i, PosExcel("COD_GRUPO")).Value).ToString.Trim
                    drExiste = dtGrupoFamilia.Select("CFMCLR='" & CodFamilia & "' AND CGRCLR='" & CodGrupo & "'")
                    If drExiste.Length = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Combinación Familia/Grupo no existe."
                    End If
                End If
                ' VALIDACION INFLAMABILIDAD
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("COD_INFLAMABILIDAD")).Value).ToString.Trim
                If CeldaValor <> "" Then
                    drExiste = dtGrupoFamilia.Select("COD='" & CeldaValor & "'")
                    If drExiste.Length = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Código Inflamabilidad no existe."
                    End If
                End If

                ' VALIDACION PERFUMANCIA
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("COD_PERFUMANCIA")).Value).ToString.Trim
                If CeldaValor <> "" Then
                    drExiste = dtGrupoFamilia.Select("COD='" & CeldaValor & "'")
                    If drExiste.Length = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Código Perfumancia no existe."
                    End If
                End If
                ' VALIDACION APILABILIDAD
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("COD_APILABILIDAD")).Value).ToString.Trim
                If CeldaValor <> "" Then
                    drExiste = dtGrupoFamilia.Select("COD='" & CeldaValor & "'")
                    If drExiste.Length = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Código Apilabilidad no existe."
                    End If
                End If

                ' VALIDACION COSTO
                CostoSKU = ("" & obj_Worksheet.Cells(i, PosExcel("COSTO")).Value).ToString.Trim
                If CostoSKU <> "" Then
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("MONEDA_COSTO")).Value)
                    If CeldaValor = "" Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & " Costo sin Moneda asignada."
                    End If
                End If

                generarOS = ("" & obj_Worksheet.Cells(i, PosExcel("GENERAR_OS")).Value).ToString.Trim

                If generarOS = "SI" Then
                    'VALIDACION U. Cantidad
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("OS_UM_CANTIDAD")).Value).ToString.Trim
                    If CeldaValor = "" Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Ingresar unidad medida cantidad OS"
                    Else
                        drExiste = dtUnidMedCantidad.Select("CUNDMD='" & CeldaValor & "'")
                        If drExiste.Length = 0 Then
                            msg_carga_validacion = msg_carga_validacion & Chr(10) & "Unid. Medida Cantidad no existe."
                        End If
                    End If


                    ' VALIDACION U. peso
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("OS_UM_PESO")).Value).ToString.Trim
                    If CeldaValor = "" Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Ingresar unidad medida peso OS"
                    Else

                        drExiste = dtUnidMedPeso.Select("CUNDMD='" & CeldaValor & "'")
                        If drExiste.Length = 0 Then
                            msg_carga_validacion = msg_carga_validacion & Chr(10) & "Unid. Medida Peso no existe."
                        End If
                    End If

                    ' VALIDACION U. Valor
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("OS_UM_VALOR")).Value).ToString.Trim
                    If CeldaValor = "" Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Ingresar unidad medida Valor OS"
                    Else
                        drExiste = dtUnidMedValor.Select("CUNDMD='" & CeldaValor & "'")
                        If drExiste.Length = 0 Then
                            msg_carga_validacion = msg_carga_validacion & Chr(10) & "Unid. Medida Valor no existe."
                        End If
                    End If

                    'OS_UM_DESPACHO

                End If

                msg_carga_validacion = msg_carga_validacion.Trim
                If msg_carga_validacion = "" Then
                    msg_carga_validacion = "OK"
                End If
                drReg("OBS_CARGA") = msg_carga_validacion
                dtCargaSKU.Rows.Add(drReg)
            Next
            'Limpiar()
            dgcargasku.DataSource = dtCargaSKU


            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If


        Catch ex As Exception
            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    


      


    End Sub


  

   
    'msg_carga_validacion = msg_carga_validacion.Trim
    'If msg_carga_validacion = "" Then
    '    msg_carga_validacion = "OK"
    'End If
    'drReg("OBS_CARGA") = msg_carga_validacion



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Ingrese cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel
                Case "tpCargaSKU"
                    'Dim CantReg As Int64 = 0
                    Dim drError() As DataRow
                    If dgcargasku.Rows.Count = 0 Then
                        MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    drError = dtCargaSKU.Select("OBS_CARGA <> 'OK'")
                    If drError.Length > 0 Then
                        MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    drError = dtCargaSKU.Select("OBS_REGISTRO = 'OK'")
                    If drError.Length > 0 Then
                        MessageBox.Show("Cargue nuevamente.Registros ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If



                    Dim obrMercaderia As New Ransa.NEGO.brMercaderia
                    Dim USUARIO As String = objSeguridadBN.pUsuario
                    Dim TERMINAL As String = HelpClass.NombreMaquina
                    Dim pstrError As String = ""
                    '===========Verifica si existe Contrato Vigente. 
                    Dim obeMercaderia As New Ransa.TypeDef.beMercaderia
                    obeMercaderia.PNCCLNT = txtCliente.pCodigo
                    obeMercaderia.PSCTPDP3 = objSeguridadBN.pstrTipoAlmacen
                    Dim dtContrato As New DataTable
                    dtContrato = obrMercaderia.fListContratosVigentesxCliente(obeMercaderia)
                    If dtContrato.Rows.Count = 0 Then
                        MessageBox.Show("El cliente no tiene contrato.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim msgvalidacion As String = ""
                    Dim ListaP As New Hashtable
                    Dim objGeneral As New clsGeneral_SDS("")
                    ListaP("IN_CCLNT") = txtCliente.pCodigo
                    ListaP("IN_CMRCLR") = ""
                    ListaP("IN_NCNTR") = dtContrato.Rows(0)("NCNTR")
                    ListaP("IN_CTPDP3") = dtContrato.Rows(0)("CTPDP3")

                    msgvalidacion = objGeneral.ValidarRegOrdenServicio(ListaP)
                    If msgvalidacion <> "" Then
                        MessageBox.Show(msgvalidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    
                    Dim CodMoneda As String = ""
                    Dim generarOS As String = ""
                    Dim msg_reg_os As String = ""
                    Dim blnResultado As Boolean = False
                    Dim registro_sku As String = ""
                    For Each item As DataRow In dtCargaSKU.Rows

                        If item("OBS_CARGA") = "OK" Then

                            Dim objMercaderia As clsMercaderia = New clsMercaderia
                            With objMercaderia
                                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                                .pstrCodigoFamilia_CFMCLR = ("" & item("COD_FAMILIA")).ToString.Trim
                                .pstrCodigoGrupo_CGRCLR = ("" & item("COD_GRUPO")).ToString.Trim
                                .pstrCodigoMercaderia_CMRCLR = ("" & item("SKU")).ToString.Trim
                                .pstrCodigoMercaderiaReemplazo_CMRCRR = ""
                                .pstrCodigoRANSA_CMRCD = ("" & item("COD_MERCADERIA_RANSA")).ToString.Trim
                                .pstrDescripcion_TMRCD2 = ("" & item("DESCRIPCION_SKU")).ToString.Trim
                                .pstrDescripcion_TMRCD3 = ("" & item("DESCRIPCION_SKU_ADIC")).ToString.Trim
                                .pintProveedor_CPRVCL = 0
                                CodMoneda = ("" & item("MONEDA_COSTO")).ToString.Trim
                                .pintCodigoMoneda_CMNCT = 0
                                If CodMoneda = "SOL" Then
                                    .pintCodigoMoneda_CMNCT = 1
                                End If
                                If CodMoneda = "DOL" Then
                                    .pintCodigoMoneda_CMNCT = 100
                                End If
                                .pdecImporteCosto_QIMCT = Val("" & item("COSTO"))
                                .pdecImporteCostoPromedio_QIMCTP = 0
                                .pdecImporteCostoPromedioSoles_QICOPS = 0
                                .pstrMarcaReembolso_MARCRE = IIf(item("CONTROL_UBICACION") = "SI", "X", "")
                                .pdecImporteVentaDolar_IMVTAS = 0
                                .pdecImporteVentaDolar_IMVTAD = 0
                                .pdecImportePorMts2_IMVLM2 = 0
                                .pdecPorcentajeDescuento_PDSCTO = 0
                                .pstrMarcaModelo_TMRCTR = ("" & item("MARCA_MODELO")).ToString.Trim
                                .pstrUbicacion_UBICA1 = ""
                                .pstrObservacion_TOBSRV = ""
                                .pdecCantidadMinimaReqServicio_QMRSRC = 0
                                .pdecPesoMinimoReqServicio_QMRSRP = 0
                                .pdecCantidadMercaderiaPtoReorden_QMRODC = 0
                                .pdecPesoMercaderiaPtoReorden_QMRODP = 0

                                Decimal.TryParse(item("LARGO"), .pdecLargoMercaderia_QLRGMR)
                                Decimal.TryParse(item("ANCHO"), .pdecAnchoMercaderia_QANCMR)
                                Decimal.TryParse(item("ALTO"), .pdecAlturaMercaderia_QALTMR)
                                Decimal.TryParse(item("AREA"), .pdecAreaMts2_QARMT2)
                                Decimal.TryParse(item("M3"), .pdecVolumenMts3_QARMT3)
                                .pdecVolumenEquivalente_QVOLEQ = 0
                                .pdecCantidadPesoDeclarado_QPSODC = 0
                                .pdecTiempoCargaMercaderia_QTMPCR = 0
                                .pdecTiempoDesargaMercaderia_QTMPDS = 0
                                '.pblnStatusPublicacionWEB_FPUWEB = "" 'chkPublicacionWEB.Checked
                                .pstrStatusPublicacionWEB_FPUWEB = ""

                                .pstrUnidad_CUNCNC = ""
                                .pstrUnidadInventario_CUNCNI = ""

                                .pstrCodigoPerfumancia_CPRFMR = ("" & item("COD_PERFUMANCIA")).ToString.Trim
                                .pstrCodigoInflamabilidad_CINFMR = ("" & item("COD_INFLAMABILIDAD")).ToString.Trim
                                .pstrCodigoRotacion_CROTMR = ""
                                .pstrCodigoApilabilidad_CAPIMR = ("" & item("COD_APILABILIDAD")).ToString.Trim
                                .pstrCodigoDUN14 = ""
                                .pstrCodigoEAN13 = ("" & item("EAN13")).ToString.Trim
                                .pdecCantidadMinimaProducir_QMRPRD = 0
                                .CPTDAR_PartidaArancelaria = "" ' txtPartidaArancelaria.Text
                                .SCNTSR_MarcaControlSerie = IIf(("" & item("CONTROL_SERIE")).ToString.Trim = "SI", "X", "")
                                'JM
                                .FUNCTL = IIf(("" & item("CONTROL_LOTE")).ToString.Trim = "SI", "X", "")
                            End With
                            ' Si el proceso es ok se limpia los controles.
                            registro_sku = ""
                            Dim msgRetorno As String = fblnGuardar_MercaderiaMasivo(objMercaderia)
                            If msgRetorno = "" Then
                                item("OBS_REGISTRO") = "OK"
                                registro_sku = "OK"
                            Else
                                item("OBS_REGISTRO") = msgRetorno
                                'item("RESULT_REGISTRO").Style.ForeColor = Color.Red
                            End If

                            generarOS = ("" & item("GENERAR_OS")).ToString.Trim
                            msg_reg_os = ""
                            If generarOS = "SI" And registro_sku = "OK" Then

                                obeMercaderia = New RANSA.TypeDef.beMercaderia
                                obeMercaderia.PNCCLNT = txtCliente.pCodigo
                                obeMercaderia.PSCMRCLR = ("" & item("SKU")).ToString.Trim
                                msg_reg_os = obrMercaderia.fListValidarCrearOS_SKU(obeMercaderia)
                                If msg_reg_os <> "" Then
                                    item("OBS_REGISTRO_OS") = msg_reg_os
                                Else
                                    Dim objOS As clsCrearOrdenServicio = New clsCrearOrdenServicio
                                    objOS.pintCodigoCliente_CCLNT = txtCliente.pCodigo
                                    objOS.pstrCodigoMercaderia_CMRCLR = ("" & item("SKU")).ToString.Trim

                                    objOS.pintNroContrato_NCNTR = dtContrato.Rows(0)("NCNTR")
                                    objOS.pstrTipoDeposito_CTPDP3 = dtContrato.Rows(0)("CTPDP3")
                                    objOS.pstrProducto_CTPPR1 = dtContrato.Rows(0)("CTPPR1")
                                    objOS.pdecCantidadDeclarada_QMRCD = 1
                                    objOS.pstrUnidadCantidad_CUNCND = ("" & item("OS_UM_CANTIDAD")).ToString.Trim
                                    objOS.pdecPesoDeclarado_QPSMR = 1
                                    objOS.pstrUnidadPeso_CUNPS0 = ("" & item("OS_UM_PESO")).ToString.Trim
                                    objOS.pdecValorDeclarado_QVLMR = 1
                                    objOS.pstrUnidadValor_CUNVLR = ("" & item("OS_UM_VALOR")).ToString.Trim
                                    objOS.pstrControlLotes_FUNCTL = "N"
                                    objOS.pstrUnidadDespacho_FUNDS = ("" & item("OS_UM_DESPACHO")).ToString.Trim
                                    blnResultado = obrMercaderia.fblnCrearOrdenServicio(USUARIO, TERMINAL, objOS, pstrError)
                                    If pstrError = "" Then
                                        item("OBS_REGISTRO_OS") = "OK"
                                    Else
                                        item("OBS_REGISTRO_OS") = pstrError
                                    End If
                                End If
                            End If

                        End If
                    Next

                    dgcargasku.DataSource = dtCargaSKU


                Case "tpCargaOS"


                    Dim drError() As DataRow
                    If dtCargaOS.Rows.Count = 0 Then
                        MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    drError = dtCargaOS.Select("OBS_CARGA <> 'OK'")
                    If drError.Length > 0 Then
                        MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    drError = dtCargaOS.Select("OBS_REGISTRO = 'OK'")
                    If drError.Length > 0 Then
                        MessageBox.Show("Cargue nuevamente.Registros ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If


                    Dim obrMercaderia As New Ransa.NEGO.brMercaderia
                    Dim USUARIO As String = objSeguridadBN.pUsuario
                    Dim TERMINAL As String = HelpClass.NombreMaquina
                    Dim pstrError As String = ""
                    '===========Verifica si existe Contrato Vigente. 
                    Dim obeMercaderia As New Ransa.TYPEDEF.beMercaderia
                    obeMercaderia.PNCCLNT = txtCliente.pCodigo
                    obeMercaderia.PSCTPDP3 = objSeguridadBN.pstrTipoAlmacen
                    Dim dtContrato As New DataTable
                    dtContrato = obrMercaderia.fListContratosVigentesxCliente(obeMercaderia)
                    If dtContrato.Rows.Count = 0 Then
                        MessageBox.Show("El cliente no tiene contrato.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim msgvalidacion As String = ""
                    Dim ListaP As New Hashtable
                    Dim objGeneral As New clsGeneral_SDS("")
                    ListaP("IN_CCLNT") = txtCliente.pCodigo
                    ListaP("IN_CMRCLR") = ""
                    ListaP("IN_NCNTR") = dtContrato.Rows(0)("NCNTR")
                    ListaP("IN_CTPDP3") = dtContrato.Rows(0)("CTPDP3")

                    msgvalidacion = objGeneral.ValidarRegOrdenServicio(ListaP)
                    If msgvalidacion <> "" Then
                        MessageBox.Show(msgvalidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim dtRegOS_X_SKU As New DataTable
                    Dim msg As String = ""
                    Dim blnResultado As Boolean = False



                    'dtCargaOS
                    For Each item As DataRow In dtCargaOS.Rows
                        'For Each item As DataGridViewRow In dgcargasos.Rows

                        If item("OBS_CARGA") = "OK" Then

                            obeMercaderia = New Ransa.TypeDef.beMercaderia
                            obeMercaderia.PNCCLNT = txtCliente.pCodigo
                            obeMercaderia.PSCMRCLR = ("" & item("SKU")).ToString.Trim
                            msg = obrMercaderia.fListValidarCrearOS_SKU(obeMercaderia)
                            If msg <> "" Then
                                item("OBS_REGISTRO").Value = msg
                            Else
                                Dim objOS As clsCrearOrdenServicio = New clsCrearOrdenServicio
                                objOS.pintCodigoCliente_CCLNT = txtCliente.pCodigo
                                objOS.pstrCodigoMercaderia_CMRCLR = ("" & item("SKU")).ToString.Trim

                                objOS.pintNroContrato_NCNTR = dtContrato.Rows(0)("NCNTR")
                                objOS.pstrTipoDeposito_CTPDP3 = dtContrato.Rows(0)("CTPDP3")
                                objOS.pstrProducto_CTPPR1 = dtContrato.Rows(0)("CTPPR1")
                                objOS.pdecCantidadDeclarada_QMRCD = 1
                                objOS.pstrUnidadCantidad_CUNCND = ("" & item("UNID_MED_CANTIDAD_OS")).ToString.Trim
                                objOS.pdecPesoDeclarado_QPSMR = 1
                                objOS.pstrUnidadPeso_CUNPS0 = ("" & item("UNID_MED_PESO_OS")).ToString.Trim
                                objOS.pdecValorDeclarado_QVLMR = 1
                                objOS.pstrUnidadValor_CUNVLR = ("" & item("UNID_MED_VALOR_OS")).ToString.Trim
                                objOS.pstrControlLotes_FUNCTL = "N"
                                objOS.pstrUnidadDespacho_FUNDS = ("" & item("UNIDAD_DESPACHO_OS")).ToString.Trim
                                blnResultado = obrMercaderia.fblnCrearOrdenServicio(USUARIO, TERMINAL, objOS, pstrError)
                                If pstrError = "" Then
                                    item("OBS_REGISTRO") = "OK"
                                Else
                                    item("OBS_REGISTRO") = pstrError
                                    'item("RESULT_REG_OS").Style.ForeColor = Color.Red
                                End If

                            End If


                        End If




                    Next
                    dgcargasos.DataSource = dtCargaOS


                    'Public Function fListContratosVigentesxCliente(ByVal obeMercaderia As TypeDef.beMercaderia) As DataTable
                    '    Dim dt As New DataTable
                    '    Dim obrMercaderia As brMercaderia = New brMercaderia
                    '    dt = obrMercaderia.fListContratosVigentesxCliente(obeMercaderia)
                    '    Return dt
                    'End Function

                    'Public Function fListOrdenServicioxSKU(ByVal obeMercaderia As TypeDef.beMercaderia) As DataTable
                    '    Dim dt As New DataTable
                    '    Dim obrMercaderia As brMercaderia = New brMercaderia
                    '    dt = obrMercaderia.fListOrdenServicioxSKU(obeMercaderia)
                    '    Return dt
                    'End Function


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        Dim TabSel As String = TabControl1.SelectedTab.Name
        Select Case TabSel
            Case "tpListadoSKU"
                btnCargaArchivo.Visible = False
                btnBuscar.Visible = True
                btnGuardar.Visible = False
                btnexportar.Visible = True
            Case "tpCargaSKU"
                btnCargaArchivo.Visible = True
                btnBuscar.Visible = False
                btnGuardar.Visible = True
                btnexportar.Visible = True
            Case "tpCargaOS"
                btnCargaArchivo.Visible = True
                btnBuscar.Visible = False
                btnGuardar.Visible = True
                btnexportar.Visible = True
        End Select

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim dt As New DataTable
            Dim pCompania As String = UcCompania_Cmb011.CCMPN_CodigoCompania
            Dim pCliente As Decimal = txtCliente.pCodigo
            Dim strSku As String = txtsku.Text.Trim

            Dim tipobusq As Decimal = 0
            If chkQ_OS.Checked = True Then
                tipobusq = 1
            Else
                tipobusq = 0
            End If
            dt = Listar_SKU_General(pCompania, pCliente, strSku, tipobusq)
            dgMercaderias.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCargaMasivaSKU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgcargasku.AutoGenerateColumns = False
            dgMercaderias.AutoGenerateColumns = False
            dgcargasos.AutoGenerateColumns = False

            Dim ods As New DataSet
            Dim obrMercaderia As New Ransa.NEGO.brMercaderia
            ods = obrMercaderia.fListUnidadesMedidaOS()
            dtUnidMedCantidad = ods.Tables(0)
            dtUnidMedPeso = ods.Tables(1)
            dtUnidMedValor = ods.Tables(2)



            TabControl1_Selected(Nothing, Nothing)
            txtCliente.pUsuario = objSeguridadBN.pUsuario
            Listar_Compania()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Try
            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel
                Case "tpListadoSKU"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Lista_SKU"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "ListaSKU"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Listado SKU"))

                    objDt = CType(Me.dgMercaderias.DataSource, DataTable).Copy



                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgMercaderias, objDt))


                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
                Case "tpCargaSKU"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Carga_SKU"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "CargaSKU"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Listado Carga SKU"))
                    'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                    objDt = CType(Me.dgcargasku.DataSource, DataTable).Copy



                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgcargasku, objDt))


                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
                Case "tpCargaOS"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Carga_OS"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Carga_OS"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Listado Carga Orden Servicio"))
                    'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                    objDt = CType(Me.dgcargasos.DataSource, DataTable).Copy



                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgcargasos, objDt))


                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
Imports NPOI.HSSF.UserModel
Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.IO.Directory
Imports System.Data
Imports System.Reflection
Imports System.Data.OleDb
Imports System.ComponentModel
Imports NPOI.HPSF
Imports NPOI.POIFS.FileSystem
Imports NPOI.SS.UserModel
Imports NPOI.HSSF.Util
Public Class HelpClass_NPOI_SC
    Private Const pAHIzquierdo As String = "IZQUIERDO"
    Private Const pAHCentro As String = "CENTRO"
    Private Const pAHDerecho As String = "DERECHO"
    Private Const pTNumero As String = "NUMERO"
    Private Const pTTexto As String = "TEXTO"
    Private Const pTFecha As String = "FECHA"
    Private Const pTCalculo_Texto As String = "CALCULO_TEXTO"
    Private Const pTCalculo_Numero As String = "CALCULO_NUMERO"
    Private Const pNFilas As String = "|"
    Private Const pColorFondo As String = "COLOR_FONDO"
    Private Const pColorLetra As String = "COLOR_LETRA"
    Private Const pNameColFormatoFila As String = "FORMATO_FILA"
    Private Const keyAlineacion As String = "ALINEACION"
    Private Const keyTipoDato As String = "TIPO_DATO"
    Private Const keyTituloColumna As String = "TITULO_COLUMNA"




    'Public ReadOnly Property keyAlinHIzquierdo() As String
    '    Get
    '        Return pAHIzquierdo
    '    End Get
    'End Property
    'Public Const keyAlinHIzquierdo As String = pAHIzquierdo
    Public ReadOnly Property keyAlinHIzquierdo() As String
        Get
            Return pAHIzquierdo
        End Get
    End Property

    '  Public Const keyAlinHCentro As String = pAHCentro
    Public ReadOnly Property keyAlinHCentro() As String
        Get
            Return pAHCentro
        End Get
    End Property

    'Public Const keyAlinHDerecho As String = pAHDerecho
    Public ReadOnly Property keyAlinHDerecho() As String
        Get
            Return pAHDerecho
        End Get
    End Property


    'Public Const keyDatoNumero As String = pTNumero
    Public ReadOnly Property keyDatoNumero() As String
        Get
            Return pTNumero
        End Get
    End Property

    '    Public Const keyDatoTexto As String = pTTexto
    Public ReadOnly Property keyDatoTexto() As String
        Get
            Return pTTexto
        End Get
    End Property

    'Public Const keyDatoFecha As String = pTFecha
    Public ReadOnly Property keyDatoFecha() As String
        Get
            Return pTFecha
        End Get
    End Property

    Public ReadOnly Property keyDatoCalculo_Texto() As String
        Get
            Return pTCalculo_Texto
        End Get
    End Property
    Public ReadOnly Property keyDatoCalculo_Numero() As String
        Get
            Return pTCalculo_Numero
        End Get
    End Property


    'Public Const keySepNFilas As String = pNFilas
    Public ReadOnly Property keySepNFilas() As String
        Get
            Return pNFilas
        End Get
    End Property
    ' Public Const keyNameColFormatoFila As String = pNameColFormatoFila
    Public ReadOnly Property keyNameColFormatoFila() As String
        Get
            Return pNameColFormatoFila
        End Get
    End Property
    ' Public Const keyColorFondo As String = pColorFondo
    Public ReadOnly Property keyColorFondo() As String
        Get
            Return pColorFondo
        End Get
    End Property
    '  Public Const keyColorLetra As String = pColorLetra
    Public ReadOnly Property keyColorLetra() As String
        Get
            Return pColorLetra
        End Get
    End Property


    Private Shared Function Formatear_GetFormatoFila(ByRef dtSource As DataTable) As DataTable
        If dtSource.Columns(pNameColFormatoFila) Is Nothing Then
            dtSource.Columns.Add(pNameColFormatoFila, Type.GetType("System.String"))
            For Each Item As DataRow In dtSource.Rows
                Item(pNameColFormatoFila) = FormatoFila("")
            Next
        End If
        Dim dtFormatoFila As New DataTable
        Dim drColor As DataRow
        dtFormatoFila.Columns.Add(pNameColFormatoFila, Type.GetType("System.String"))
        For Each Item As DataRow In dtSource.Rows
            drColor = dtFormatoFila.NewRow
            drColor(pNameColFormatoFila) = Item(pNameColFormatoFila)
            dtFormatoFila.Rows.Add(drColor)
        Next
        dtSource.Columns.Remove(pNameColFormatoFila)
        Return dtFormatoFila
    End Function

    Private Const keyCharSeparacion As Char = Chr(13)
    Private Const keyCharKeyValue As Char = "="
    Private Const fontSizeTituloGeneral As Int32 = 160
    Private Const fontSizeColumnaHeader As Int32 = 158
    Private Const fontSizeCelda As Int32 = 156
    Private Const fontSizeCeldaTotal As Int32 = 163
    Private Const fontSizeFiltros As Int32 = 165

    Public Shared Function FormatoFila(ByVal ColorFondoFila As String, Optional ByVal ColorLetraFila As String = "") As String
        Dim sbFormato As New StringBuilder
        'sbFormato.Append(keyColorFondo)
        sbFormato.Append(pColorFondo)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(ColorFondoFila)
        sbFormato.Append(keyCharSeparacion)
        'sbFormato.Append(keyColorLetra)
        sbFormato.Append(pColorLetra)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(ColorLetraFila)


        Return sbFormato.ToString
    End Function

    Private Shared Function DesFormatoFila(ByVal DatoDetalleFila As String) As Hashtable
        Dim oHasDatos As New Hashtable
        Dim datoTexto() As String
        Dim datoKeyValue() As String
        datoTexto = DatoDetalleFila.Trim.Split(keyCharSeparacion)
        For Each Item As String In datoTexto
            datoKeyValue = Item.Split(keyCharKeyValue)
            oHasDatos.Add(datoKeyValue(0), datoKeyValue(1))
        Next
        Return oHasDatos
    End Function

    Private Shared Function DesFormatDato(ByVal datoDetalle As String) As Hashtable
        Dim oHasDatos As New Hashtable
        Dim datoTexto() As String
        Dim datoKeyValue() As String
        datoTexto = datoDetalle.Trim.Split(keyCharSeparacion)
        For Each Item As String In datoTexto
            datoKeyValue = Item.Split(keyCharKeyValue)
            oHasDatos.Add(datoKeyValue(0), datoKeyValue(1))
        Next
        Return oHasDatos
    End Function
    Public Function FormatDato(ByVal oTituloColumna As String, Optional ByVal oTipoDato As String = "TEXTO", Optional ByVal oAlinH As String = pAHIzquierdo, Optional ByVal oColorFondoCabecera As String = "", Optional ByVal oColorLetraCabecera As String = "") As String
        '  Public Function FormatDato(ByVal oTituloColumna As String, Optional ByVal oTipoDato As String = keyDatoTexto, Optional ByVal oAlinH As String = keyAlinHIzquierdo, Optional ByVal oColorFondoCabecera As String = "", Optional ByVal oColorLetraCabecera As String = "") As String
        Dim sbFormato As New StringBuilder
        oTituloColumna = oTituloColumna.Trim
        If (oTituloColumna.Trim.Length = 0) Then
            oTituloColumna = "Titulo"
        End If
        sbFormato.Append(keyTituloColumna)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(oTituloColumna)
        sbFormato.Append(keyCharSeparacion)

        sbFormato.Append(keyTipoDato)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(oTipoDato)
        sbFormato.Append(keyCharSeparacion)
        sbFormato.Append(keyAlineacion)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(oAlinH)
        sbFormato.Append(keyCharSeparacion)
        sbFormato.Append(pColorFondo)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(oColorFondoCabecera)
        sbFormato.Append(keyCharSeparacion)
        sbFormato.Append(keyColorLetra)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(oColorLetraCabecera)
        Return sbFormato.ToString
    End Function

    Enum TipoEstilo
        Cabecera
        Fecha
        Filtro
        Normal
        Numero
        Texto
        Titulo
    End Enum

    Enum AlineacionH
        Neutro
        Centro
        Izquierda
        Derecha
    End Enum

    Private Shared Sub Estilos_Excel_NPOI(ByVal style As NPOI.SS.UserModel.CellStyle, ByVal _tipoEstilo As TipoEstilo, Optional ByVal _AlineacionH As AlineacionH = AlineacionH.Neutro, Optional ByVal _FillColor As String = "")
        Select Case _tipoEstilo
            Case TipoEstilo.Filtro

                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.DataFormat = NPOI.HSSF.Util.HSSFColor.BLACK.index
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT
                style.FillPattern = FillPatternType.SOLID_FOREGROUND

            Case TipoEstilo.Cabecera

                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.GREEN.index
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.DataFormat = NPOI.HSSF.Util.HSSFColor.BLACK.index
                style.FillPattern = FillPatternType.SOLID_FOREGROUND
                style.BorderRight = CellBorderType.THIN
                style.BorderBottom = CellBorderType.THIN
                style.BorderLeft = CellBorderType.THIN
                style.BorderTop = CellBorderType.THIN
                style.WrapText = True
                style.DataFormat = HSSFDataFormat.GetBuiltinFormat("@")


                'style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                'style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                'style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                'style.DataFormat = NPOI.HSSF.Util.HSSFColor.BLACK.index
                'style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT
                'style.FillPattern = FillPatternType.SOLID_FOREGROUND


            Case TipoEstilo.Normal

                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT
                style.DataFormat = NPOI.HSSF.Util.HSSFColor.BLACK.index
                style.FillPattern = FillPatternType.SOLID_FOREGROUND
                style.BorderRight = CellBorderType.THIN
                style.BorderBottom = CellBorderType.THIN
                style.BorderLeft = CellBorderType.THIN
                style.BorderTop = CellBorderType.THIN
                style.WrapText = True

                'style.DataFormat = HSSFDataFormat.GetBuiltinFormat("text") '"#.##0,00"

            Case TipoEstilo.Texto

                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT
                style.FillPattern = FillPatternType.SOLID_FOREGROUND
                style.BorderRight = CellBorderType.THIN
                style.BorderBottom = CellBorderType.THIN
                style.BorderLeft = CellBorderType.THIN
                style.BorderTop = CellBorderType.THIN
                style.WrapText = True
                style.DataFormat = HSSFDataFormat.GetBuiltinFormat("@") '"#.##0,00"
                'style.DataFormat = HSSFDataFormat.GetBuiltinFormat("text") '"#.##0,00"

            Case TipoEstilo.Titulo
                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                'style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                'style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index

                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.GREEN.index
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index



                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT
                style.DataFormat = NPOI.HSSF.Util.HSSFColor.BLACK.index
                style.FillPattern = FillPatternType.SOLID_FOREGROUND

            Case TipoEstilo.Numero

                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.RIGHT
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                'style.DataFormat = HSSFDataFormat.GetBuiltinFormat("#.##0,00") '"#.##0,00"
                style.FillPattern = FillPatternType.SOLID_FOREGROUND
                style.BorderRight = CellBorderType.THIN
                style.BorderBottom = CellBorderType.THIN
                style.BorderLeft = CellBorderType.THIN
                style.BorderTop = CellBorderType.THIN

            Case TipoEstilo.Fecha

                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillPattern = FillPatternType.SOLID_FOREGROUND
                style.BorderRight = CellBorderType.THIN
                style.BorderBottom = CellBorderType.THIN
                style.BorderLeft = CellBorderType.THIN
                style.BorderTop = CellBorderType.THIN
                style.DataFormat = HSSFDataFormat.GetBuiltinFormat("@")
                'style.DataFormat = HSSFDataFormat.GetBuiltinFormat("text")
        End Select

        Dim ValNumero As Short = 1 'BLANCO
        If Short.TryParse(_FillColor, ValNumero) = True Then
            style.FillForegroundColor = Convert.ToInt16(_FillColor.ToString)
        End If

        Select Case _AlineacionH
            Case AlineacionH.Centro
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER
            Case AlineacionH.Derecha
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.RIGHT
            Case AlineacionH.Izquierda
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT
        End Select

    End Sub
    Public Shared Function FormatTextoxLongitud(ByVal Texto As String, ByVal Maxlen As Int32) As String
        Dim textos() As String
        Dim TextoTemp As New StringBuilder
        Dim sbNewTexto As New StringBuilder
        Dim ListTexto() As String = Texto.Trim.Split(Chr(10))
        Dim strText As New StringBuilder
        Dim ItemTexto As String = ""
        Dim Item As String = ""
        For FilaList As Integer = 0 To ListTexto.Length - 1
            ItemTexto = ListTexto(FilaList).Trim
            sbNewTexto.Length = 0
            If ItemTexto.Length > Maxlen Then
                textos = ItemTexto.Split(" ")
                TextoTemp.Length = 0
                For FilaItem As Integer = 0 To textos.Length - 1
                    Item = textos(FilaItem).ToString.Trim
                    If TextoTemp.ToString.Length + Item.Length > Maxlen Then
                        sbNewTexto.Append(TextoTemp.ToString & Chr(10))
                        TextoTemp.Length = 0
                        TextoTemp.Append(Item & " ")
                    Else
                        If Item.Trim.Length > 0 Then
                            TextoTemp.Append(Item & " ")
                        End If
                        If FilaItem = textos.Length - 1 AndAlso TextoTemp.ToString.Length > 0 Then
                            sbNewTexto.Append(TextoTemp.ToString)
                        End If
                    End If
                Next
                strText.Append(sbNewTexto.ToString.Trim)
                strText.Append(Chr(10))
            Else
                strText.Append(ItemTexto)
                strText.Append(Chr(10))
            End If
        Next
        Return strText.ToString.Trim
    End Function


#Region "EXPORTACION PARA PREEMBARQUE"

    Public Shared Sub ExportExcelSeguimientoPreEmbarquexOCParcial(ByVal odtDataSource As DataTable, ByVal Titulo As String)

        Dim path As String = Application.StartupPath.ToString
        Dim archivo As String = "SeguimientoCargaParcial" & HelpClass.NowNumeric & ".xls"
        Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)

        '=====================================================================
        Dim objWorkBook As New HSSFWorkbook()
        Dim memoryStream As New MemoryStream()
        Dim objWorkSheet As New HSSFSheet(objWorkBook)
        '=============Stilos======================
        Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim stylCentro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()


        Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontFiltro.FontHeight = fontSizeFiltros

        Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
        oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontCab.FontHeight = fontSizeTituloGeneral

        Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.FontHeight = fontSizeCelda

        Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
        Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
        Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
        Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)
        Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
        Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)

        '============================================
        styleFiltro.SetFont(oFontFiltro)
        styleCab.SetFont(oFontCab)
        styleNormal.SetFont(oFont)
        styleTitulo.SetFont(oFontFiltro)
        styleNumber.SetFont(oFont)
        styleFecha.SetFont(oFont)
        stylCentro.SetFont(oFont)
        '===================Se cargan Las Variables de Trabajo=====================
        Dim indice As Integer = 0
        Dim rowActual As Integer = 6
        Dim IndiceColum As Integer = 0
        Dim y As Integer = 0

        Dim intCantidadRows As Integer = 0

        Dim intColumObs As Integer = 0

        Dim lstrTempColum As New Hashtable

        intCantidadRows = odtDataSource.Rows.Count + 20
        objWorkSheet = objWorkBook.CreateSheet("Carga Internacional")


        Dim DobleCabecera As Boolean = False
        Dim VALOR_CELDA As String = ""
        Dim Cabeceras() As String
        For Each dc As DataColumn In odtDataSource.Columns
            VALOR_CELDA = dc.Caption
            Cabeceras = VALOR_CELDA.Split("|")
            If (Cabeceras.Length >= 2) Then
                DobleCabecera = True
                Exit For
            End If
        Next

        For s As Integer = 0 To (intCantidadRows)
            objWorkSheet.CreateRow(s)
        Next


        objWorkSheet.GetRow(2).CreateCell(3).CellStyle = styleTitulo
        objWorkSheet.GetRow(2).GetCell(3).SetCellValue(Titulo)
        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 3, 2, 6))



        Dim styleCenterCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        styleCenterCab = styleCab
        styleCenterCab.VerticalAlignment = VerticalAlignment.CENTER



        For j As Integer = 0 To odtDataSource.Columns.Count - 1
            y = IndiceColum
            VALOR_CELDA = odtDataSource.Columns(j).Caption.ToString().Trim()
            Cabeceras = VALOR_CELDA.Split("|")
            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCenterCab
            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
            If (DobleCabecera = True) Then
                If (Cabeceras.Length >= 2) Then
                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
                Else
                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
                End If
            End If
            IndiceColum += 1
        Next

        Dim row As New NPOI.HSSF.UserModel.HSSFRow
        row = objWorkSheet.GetRow(indice + rowActual - 1)
        For x As Int32 = 0 To odtDataSource.Columns.Count - 1
            If (x + 1 < odtDataSource.Columns.Count) Then
                If row.GetCell(x).StringCellValue.Trim = row.GetCell(x + 1).StringCellValue.Trim Then
                    row.GetCell(x + 1).SetCellValue("")
                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice - 1 + rowActual, x + 1)
                    objWorkSheet.AddMergedRegion(Region)
                    x += 1
                Else
                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice + rowActual, x)
                    objWorkSheet.AddMergedRegion(Region)
                End If
            Else
                Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice + rowActual, x)
                objWorkSheet.AddMergedRegion(Region)
            End If
        Next


        Dim ValorCelda As String = ""
        rowActual += 2

        Dim NORCML_ACTUAL As String = ""
        Dim PARCIAL As String = ""

        Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        styleWrap = styleNormal
        styleWrap.WrapText = True
        styleWrap.VerticalAlignment = VerticalAlignment.CENTER


        Dim IndexWrap As Int32 = 0

        Dim NombreColumna As String = ""

        Dim NORCML_TEMP As String = ""
        Dim PARCIAL_TEMP As String = ""
        Dim PARCIAL_ACTUAL As String = ""

        Dim POS_TEMP_INICIO_OC As Int32 = indice - 1 + rowActual
        Dim POS_TEMP_FIN_OC As Int32 = 0

        Dim POS_TEMP_INICIO_PARCIAL As Int32 = indice - 1 + rowActual
        Dim POS_TEMP_FIN_PARCIAL As Int32 = 0

        Dim CREAR_MERGE_OC As Boolean = False


        Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        styleTexto = styleNormal
        styleTexto.WrapText = True
        styleTexto.VerticalAlignment = VerticalAlignment.CENTER

        Dim DIF As Int32 = 0
        Dim MAX_OBS_GROUP As Int32 = 0
        Const MaxLenObs As Int32 = 120
        Dim CountOverMaxLenObs As Int32 = 0

        Dim FilaUltima As Int32 = 0
        For i As Integer = 0 To odtDataSource.Rows.Count - 1
            IndiceColum = 0
            MAX_OBS_GROUP = 0
            For j As Integer = 0 To odtDataSource.Columns.Count - 1
                NombreColumna = odtDataSource.Columns(j).ColumnName
                y = IndiceColum
                VALOR_CELDA = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                VALOR_CELDA = VALOR_CELDA.Replace(Chr(13), "")

                MAX_OBS_GROUP = FormatTextoxLongitud(odtDataSource.Rows(i).Item("TOBS").ToString.Trim, MaxLenObs).Split(Chr(10)).Length

                Select Case NombreColumna
                    Case "NORCML", "NRPARC", "TTINTC", "NMONOC", "TNMMDT", "NDOCEM", "NFCTCM", "TNOMCOM"

                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    Case "TOBS"

                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                        objWorkSheet.SetColumnWidth(y, 28000)
                    Case Else
                        If IsNumeric(VALOR_CELDA) Then
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNumber
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                        ElseIf IsDate(VALOR_CELDA) Then
                            VALOR_CELDA = String.Format("{0:d}", CDate(VALOR_CELDA))
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleFecha
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                        Else
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNormal
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                        End If
                End Select

                If (NombreColumna = "NORCML") Then
                    NORCML_ACTUAL = ("" & odtDataSource.Rows(i).Item("NORCML")).ToString.Trim
                    If i + 1 > (odtDataSource.Rows.Count - 1) Then
                        FilaUltima = i
                    Else
                        FilaUltima = i + 1
                    End If
                    NORCML_TEMP = ("" & odtDataSource.Rows(FilaUltima).Item("NORCML")).ToString.Trim
                    If (NORCML_ACTUAL <> NORCML_TEMP OrElse (i = odtDataSource.Rows.Count - 1)) Then
                        POS_TEMP_FIN_OC = (indice - 1 + rowActual)
                        Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_OC, j, POS_TEMP_FIN_OC, j)
                        POS_TEMP_INICIO_OC = POS_TEMP_FIN_OC + 1
                        objWorkSheet.AddMergedRegion(Region)
                    End If
                End If
                If NombreColumna = "NRPARC" Then

                    PARCIAL_ACTUAL = odtDataSource.Rows(i).Item("NORCML").ToString.Trim & "_" & odtDataSource.Rows(i).Item("NRPARC").ToString.Trim
                    If i + 1 > (odtDataSource.Rows.Count - 1) Then
                        FilaUltima = i
                    Else
                        FilaUltima = i + 1
                    End If
                    PARCIAL_TEMP = odtDataSource.Rows(FilaUltima).Item("NORCML").ToString.Trim & "_" & odtDataSource.Rows(FilaUltima).Item("NRPARC").ToString.Trim
                    If (PARCIAL_ACTUAL <> PARCIAL_TEMP) OrElse (i = odtDataSource.Rows.Count - 1) Then

                        POS_TEMP_FIN_PARCIAL = (indice - 1 + rowActual)
                        If MAX_OBS_GROUP > 1 Then
                            For X As Int32 = POS_TEMP_INICIO_PARCIAL To POS_TEMP_FIN_PARCIAL
                                objWorkSheet.GetRow(X).Height = 250 * MAX_OBS_GROUP
                            Next
                        End If
                        POS_TEMP_INICIO_PARCIAL = POS_TEMP_FIN_PARCIAL + 1

                    End If
                End If

                IndiceColum += 1
            Next
            rowActual += 1
        Next

        objWorkSheet.DefaultColumnWidth = 35
        objWorkSheet.DefaultRowHeightInPoints = 25
        intColumObs = odtDataSource.Columns("TOBS").Ordinal
        For z As Integer = 0 To odtDataSource.Columns.Count - 1
            If intColumObs <> z Then
                If IsNothing(lstrTempColum(z)) Then
                    objWorkSheet.AutoSizeColumn(z, True)
                Else
                    objWorkSheet.SetColumnWidth(z, 18663)
                End If
            End If
        Next

        objWorkBook.Write(fs)
        fs.Close()
        HelpClass.AbrirDocumento(archivo)

    End Sub
    Public Shared Sub ExportExcelSeguimientoPreEmbarquexOCParcialxItem(ByVal odtListDataSource As List(Of DataTable), ByVal ListTitulo As List(Of String), ByVal ListColNameNFilas As List(Of String), Optional ByVal ListFiltro As List(Of SortedList) = Nothing, Optional ByVal ListNameDelFilDuplic As List(Of String) = Nothing)

        'GGG()

        Dim path As String = Application.StartupPath.ToString
        Dim archivo As String = "SeguimientoCargaParcialItem" & HelpClass.NowNumeric & ".xls"
        Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)

        '=====================================================================
        Dim objWorkBook As New HSSFWorkbook()
        Dim memoryStream As New MemoryStream()
        Dim objWorkSheet As New HSSFSheet(objWorkBook)
        '=============Stilos======================
        Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        'Dim stylCentro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()


        Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontFiltro.FontHeight = fontSizeFiltros

        Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
        oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontCab.FontHeight = fontSizeColumnaHeader

        Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.FontHeight = fontSizeCelda

        Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
        Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
        Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
        Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)
        Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
        Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)
        Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)

        '============================================
        styleFiltro.SetFont(oFontFiltro)
        styleCab.SetFont(oFontCab)
        styleNormal.SetFont(oFont)
        styleTitulo.SetFont(oFontFiltro)
        styleNumber.SetFont(oFont)
        styleFecha.SetFont(oFont)
        styleTexto.SetFont(oFont)

        '===================Se cargan Las Variables de Trabajo=====================
        Dim odtDataSource As New DataTable
        For FilaTable As Integer = 0 To odtListDataSource.Count - 1
            odtDataSource = odtListDataSource(FilaTable).Copy

            Dim indice As Integer = 0
            Dim rowActual As Integer = 6
            Dim IndiceColum As Integer = 0
            Dim y As Integer = 0
            Dim intCantidadRows As Integer = 0
            Dim intColumObs As Integer = 0
            Dim lstrTempColum As New Hashtable
            intCantidadRows = odtDataSource.Rows.Count + 20

            'objWorkSheet = objWorkBook.CreateSheet("Carga Internacional")
            Dim NameHoja As String = ""
            If odtDataSource.TableName.Trim.Length = 0 Then
                NameHoja = "Hoja" & (FilaTable + 1).ToString.PadLeft(2, "0")
            Else
                NameHoja = odtDataSource.TableName
            End If
            objWorkSheet = objWorkBook.CreateSheet(NameHoja)



            'Dim DobleCabecera As Boolean = False
            'Dim VALOR_CELDA As String = ""
            'Dim Cabeceras() As String
            'For Each dc As DataColumn In odtDataSource.Columns
            '    VALOR_CELDA = dc.Caption
            '    Cabeceras = VALOR_CELDA.Split("|")
            '    If (Cabeceras.Length >= 2) Then
            '        DobleCabecera = True
            '        Exit For
            '    End If
            'Next

            'For s As Integer = 0 To (intCantidadRows)
            '    objWorkSheet.CreateRow(s)
            'Next


            'objWorkSheet.GetRow(2).CreateCell(3).CellStyle = styleTitulo
            'objWorkSheet.GetRow(2).GetCell(3).SetCellValue(Titulo)
            'objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 3, 2, 6))



            'Dim styleCenterCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
            'styleCenterCab = styleCab
            'styleCenterCab.VerticalAlignment = VerticalAlignment.CENTER

            'For j As Integer = 0 To odtDataSource.Columns.Count - 1
            '    y = IndiceColum
            '    VALOR_CELDA = odtDataSource.Columns(j).Caption.ToString().Trim()
            '    Cabeceras = VALOR_CELDA.Split("|")
            '    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCenterCab
            '    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
            '    If (DobleCabecera = True) Then
            '        If (Cabeceras.Length >= 2) Then
            '            objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
            '            objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
            '        Else
            '            objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
            '        End If
            '    End If
            '    IndiceColum += 1
            'Next

            'Dim row As New NPOI.HSSF.UserModel.HSSFRow
            'row = objWorkSheet.GetRow(indice + rowActual - 1)
            'For x As Int32 = 0 To odtDataSource.Columns.Count - 1
            '    If (x + 1 < odtDataSource.Columns.Count) Then
            '        If row.GetCell(x).StringCellValue.Trim = row.GetCell(x + 1).StringCellValue.Trim Then
            '            row.GetCell(x + 1).SetCellValue("")
            '            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice - 1 + rowActual, x + 1)
            '            objWorkSheet.AddMergedRegion(Region)
            '            x += 1
            '        Else
            '            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice + rowActual, x)
            '            objWorkSheet.AddMergedRegion(Region)
            '        End If
            '    Else
            '        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice + rowActual, x)
            '        objWorkSheet.AddMergedRegion(Region)
            '    End If
            'Next


            Dim DobleCabecera As Boolean = False
            Dim CaptionColumna As String
            Dim Captions() As String
            Dim Cabeceras() As String

            Dim oHasDatosData As Hashtable
            Dim oListColDobleCabecera As New List(Of String)
            Dim NameColumna As String = ""

            Dim dtFilasFormato As New DataTable
            dtFilasFormato = Formatear_GetFormatoFila(odtDataSource)

            For Each dc As DataColumn In odtDataSource.Columns
                NameColumna = dc.ColumnName.Trim
                CaptionColumna = dc.Caption.Trim
                oHasDatosData = DesFormatDato(CaptionColumna)
                Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
                If (Captions.Length > 1) Then
                    DobleCabecera = True
                    oListColDobleCabecera.Add(NameColumna)
                End If
            Next

            For s As Integer = 0 To (intCantidadRows)
                objWorkSheet.CreateRow(s)
            Next
            Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1
            '==============Verificamos Filtro a utilizar==================
            objWorkSheet.GetRow(2).CreateCell(2).CellStyle = styleTitulo
            If ListTitulo IsNot Nothing AndAlso (ListTitulo.Count - 1) >= FilaTable Then
                objWorkSheet.GetRow(2).GetCell(2).SetCellValue(ListTitulo(FilaTable))
            Else
                objWorkSheet.GetRow(2).GetCell(2).SetCellValue("")
            End If
            objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 2, 2, 5))

            ' If filtro Is Nothing Then
            If ListFiltro Is Nothing AndAlso ListFiltro.Count = 0 Then
                rowActual = rowActual + 1
            ElseIf ListFiltro IsNot Nothing AndAlso ((ListFiltro.Count - 1) >= FilaTable) Then
                Dim x As Integer = 0
                Dim ValCeldas() As String
                Dim DisplayTitle As String = ""
                Dim DipplayValue As String = ""
                For Each items As DictionaryEntry In ListFiltro(FilaTable)
                    DisplayTitle = ""
                    DipplayValue = ""
                    ValCeldas = ("" & items.Value).ToString.Split("|")
                    If ValCeldas.Length > 1 Then
                        DisplayTitle = ValCeldas(0)
                        DipplayValue = ValCeldas(1)
                    End If
                    x = x + 1
                    DipplayValue = DisplayTitle & "  " & DipplayValue
                    objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
                    objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)
                    objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 3))
                Next
                rowActual = rowActual + ListFiltro(FilaTable).Count - 1
            End If

            Dim ValorCelda As String = ""
            Dim tituloColumna As String = ""
            Dim NumMaxFilasTitulo As Int32 = 0
            Dim DatosTitulo() As String
            Dim MaxShortTitulo As Short = 32767
            Dim TotalHeightTitulo As Int32 = 0
            Dim ColorFondoCab As String = ""
            Dim ColorLetraCab As String = ""
            Dim ColorFondo As String = ""
            Dim ColorLetra As String = ""
            Dim ColorIndex As String = ""
            Dim oHasFormatoFila As New Hashtable
            Dim ValCelda As String = ""


            For j As Integer = 0 To odtDataSource.Columns.Count - 1

                y = IndiceColum
                CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
                oHasDatosData = DesFormatDato(CaptionColumna)
                tituloColumna = oHasDatosData(keyTituloColumna)

                'ColorFondoCab = oHasDatosData(keyColorFondo)
                'ColorLetraCab = oHasDatosData(keyColorLetra)
                ColorFondoCab = oHasDatosData(pColorFondo)
                ColorLetraCab = oHasDatosData(pColorLetra)


                Cabeceras = tituloColumna.Split("|")

                If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
                    Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                    Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

                    Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                    oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
                    oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                    oFontCabTemp.FontHeight = fontSizeColumnaHeader
                    styleCabTemp.SetFont(oFontCabTemp)
                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
                Else
                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
                End If
                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))

                '***AMPLIAR EL TAMANIO DEL TITULO DE LA COLUMNA 
                NumMaxFilasTitulo = 1
                DatosTitulo = Cabeceras(0).Split(Chr(10))
                If (DatosTitulo.Length > NumMaxFilasTitulo) Then
                    NumMaxFilasTitulo = DatosTitulo.Length
                End If
                If NumMaxFilasTitulo > 1 Then
                    For X As Int32 = rowActual - 1 To rowActual
                        TotalHeightTitulo = 284 * NumMaxFilasTitulo
                        If TotalHeightTitulo > MaxShortTitulo Then
                            objWorkSheet.GetRow(X).Height = MaxShortTitulo
                        Else
                            objWorkSheet.GetRow(X).Height = TotalHeightTitulo
                        End If
                    Next
                End If
                '*************************************
                If (DobleCabecera = True) Then
                    If (Cabeceras.Length > 1) Then

                        If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
                            Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                            Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

                            Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                            oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
                            oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                            oFontCabTemp.FontHeight = fontSizeColumnaHeader
                            styleCabTemp.SetFont(oFontCabTemp)

                            'objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
                            objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCabTemp
                        Else
                            '  objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
                            objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
                        End If
                        objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
                        'objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
                    Else

                        If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
                            Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                            Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

                            Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                            oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
                            oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                            oFontCabTemp.FontHeight = fontSizeColumnaHeader
                            styleCabTemp.SetFont(oFontCabTemp)
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
                            'objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCabTemp
                        Else
                            objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
                            ' objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
                        End If
                        'objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
                        objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
                    End If
                End If
                IndiceColum += 1
            Next

            Dim row As New NPOI.HSSF.UserModel.HSSFRow
            row = objWorkSheet.GetRow(indice + rowActual - 1)
            Dim IsBreak As Boolean = False
            Dim PosInicioBreak As Int32 = 0
            Dim PosFinalBreak As Int32 = 0
            Dim ValorCeldaActual As String
            Dim ValorCeldaNext As String = ""
            Dim oListCeldaTitleIguales As New List(Of Int32)
            Dim ColIndexInicial As Int32 = 0
            Dim ColIndexFinal As Int32 = 0

            If DobleCabecera = True Then
                For x As Int32 = 0 To odtDataSource.Columns.Count - 1
                    NameColumna = odtDataSource.Columns(x).ColumnName
                    ColIndexInicial = x
                    ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
                    If x = odtDataSource.Columns.Count - 1 Then
                        ColIndexFinal = x
                        ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
                    Else
                        ColIndexFinal = x + 1
                        ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

                    End If
                    If ValorCeldaNext = ValorCeldaActual Then
                        oListCeldaTitleIguales.Add(ColIndexInicial)
                    Else
                        PosFinalBreak = ColIndexInicial
                        oListCeldaTitleIguales.Add(ColIndexInicial)
                        IsBreak = True
                    End If
                    If IsBreak = True Then
                        If oListCeldaTitleIguales.Count > 1 Then
                            'SI TIENE MAS DE 2 COLUMNAS IGUALES
                            For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
                                If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
                                    row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
                                End If
                            Next
                            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
                            objWorkSheet.AddMergedRegion(Region)
                        Else
                            If Not oListColDobleCabecera.Contains(NameColumna) Then
                                'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
                                Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
                                objWorkSheet.AddMergedRegion(Region)
                            End If
                        End If
                        PosInicioBreak = PosFinalBreak + 1
                        oListCeldaTitleIguales = New List(Of Int32)
                        IsBreak = False
                    End If
                Next
                rowActual += 1
            End If
            rowActual += 1

            Dim ValorNumero As Decimal = 0
            Dim NumMaxFilas As Int32 = 0
            Dim Datos() As String
            Const MaxLenDato As Int32 = 120
            Dim Tamanio As Int32 = 0
            Dim IsConTamanio As Boolean = False
            Dim TipoDato As String = ""

            Dim EsVariasFilas As Boolean = False

            Dim ListaColNameNFilas As New List(Of String)
            If ListColNameNFilas IsNot Nothing AndAlso (ListColNameNFilas.Count - 1) >= FilaTable AndAlso ListColNameNFilas(FilaTable) <> "" Then
                For Each Item As String In ListColNameNFilas(FilaTable).Split(pNFilas)
                    ListaColNameNFilas.Add(Item)
                Next
            End If
            '****************


            'Dim ValorCelda As String = ""
            'rowActual += 1

            Dim NORCML_ACTUAL As String = ""
            Dim NORCML_ACTUAL_PARCIAL As String = ""
            Dim PARCIAL_ACTUAL As String = ""

            Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
            styleWrap = styleNormal
            styleWrap.WrapText = True
            styleWrap.VerticalAlignment = VerticalAlignment.CENTER


            Dim IndexWrap As Int32 = 0

            Dim NombreColumna As String = ""

            Dim NORCML_TEMP As String = ""
            Dim NORCML_TEMP_PARCIAL As String = ""
            If (odtDataSource.Rows.Count > 0) Then
                NORCML_TEMP = odtDataSource.Rows(0).Item("NORCML").ToString.Trim
                NORCML_TEMP_PARCIAL = odtDataSource.Rows(0).Item("NORCML").ToString.Trim & "_" & odtDataSource.Rows(0).Item("NRPARC").ToString.Trim
            End If
            Dim POS_TEMP_INICIO_OC As Int32 = indice - 1 + rowActual
            Dim POS_TEMP_FIN_OC As Int32 = 0
            Dim CREAR_MERGE_OC As Boolean = False

            Dim POS_TEMP_INICIO_PARCIAL As Int32 = indice - 1 + rowActual
            Dim POS_TEMP_FIN_PARCIAL As Int32 = 0

            'Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
            'styleTexto = styleNormal
            'styleTexto.WrapText = True

            Dim CAMBIO_OC As Boolean = False
            Dim POS_INICIAL_OC As Int32 = indice - 1 + rowActual
            Dim POS_FINAL_OC As Int32 = 0

            Dim intCountObs As Int32 = 0
            Dim POS_GRUPO_INICIO As Int32 = 0
            Dim POS_GRUPO_FIN As Int32 = 0
            Dim MAX_OBS_GROUP As Int32 = 0
            Dim VAL As Int32 = 0
            Dim OBS() As String
            Dim DIF As Int32 = 0
            Dim CAMBIAR_ALTO_FILA As Boolean = False
            Const MaxLenObs As Int32 = 120
            Dim CountOverMaxLenObs As Int32 = 0

            'Dim CaptionColumna As String = ""
            'Dim NameColumna As String = ""
            'Dim oHasDatosData As Hashtable
            'Dim TipoDato As String = ""
            'Dim ColorIndex As String = ""
            'Dim ValorNumero As Decimal = 0


            'Dim EsVariasFilas As Boolean = False

            'Dim ListaColNameNFilas As New List(Of String)
            'If ListColNameNFilas IsNot Nothing AndAlso (ListColNameNFilas.Count - 1) >= FilaTable AndAlso ListColNameNFilas(FilaTable) <> "" Then
            '    For Each Item As String In ListColNameNFilas(FilaTable).Split(pNFilas)
            '        ListaColNameNFilas.Add(Item)
            '    Next
            'End If




            For i As Integer = 0 To odtDataSource.Rows.Count - 1
                IndiceColum = 0
                For j As Integer = 0 To odtDataSource.Columns.Count - 1
                    'NombreColumna = odtDataSource.Columns(j).ColumnName
                    'y = IndiceColum
                    'VALOR_CELDA = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                    'VALOR_CELDA = VALOR_CELDA.Replace(Chr(13), "")
                    'VALOR_CELDA = VALOR_CELDA.Replace(Chr(10), Chr(10))
                    'Select Case NombreColumna
                    '    Case "NORCML", "NRPARC", "TTINTC", "NMONOC", "TNMMDT", "NRITOC", "SBITOC", "TCITCL", "TUNDIT", "NDOCEM", "NFCTCM"
                    '        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNormal
                    '        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    '    Case "TOBS"
                    '        CountOverMaxLenObs = 0
                    '        If (VALOR_CELDA.Length <> 0) Then
                    '            OBS = VALOR_CELDA.Split(Chr(10))
                    '            If (OBS.Length > MAX_OBS_GROUP) Then
                    '                MAX_OBS_GROUP = OBS.Length
                    '                For Each Item As String In OBS
                    '                    If (Item.Length > MaxLenObs) Then
                    '                        CountOverMaxLenObs += 1
                    '                    End If
                    '                Next
                    '                MAX_OBS_GROUP = MAX_OBS_GROUP + CountOverMaxLenObs
                    '            End If
                    '        End If
                    '        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleTexto
                    '        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    '        objWorkSheet.SetColumnWidth(y, 28000)
                    '    Case "TDITES"
                    '        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNormal
                    '        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    '        objWorkSheet.SetColumnWidth(y, 22800)
                    '    Case Else
                    '        If (NombreColumna.EndsWith("_DIF")) Then

                    '            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNormal
                    '            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    '        Else
                    '            If IsNumeric(VALOR_CELDA) Then
                    '                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNumber
                    '                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    '            ElseIf IsDate(VALOR_CELDA) Then
                    '                VALOR_CELDA = String.Format("{0:d}", CDate(VALOR_CELDA))
                    '                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleFecha
                    '                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    '            Else
                    '                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNormal
                    '                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(VALOR_CELDA)
                    '            End If
                    '        End If
                    'End Select

                    y = IndiceColum
                    ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                    ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
                    CaptionColumna = odtDataSource.Columns(j).Caption.Trim
                    NameColumna = odtDataSource.Columns(j).ColumnName
                    oHasDatosData = DesFormatDato(CaptionColumna)
                    TipoDato = oHasDatosData(keyTipoDato)

                    EsVariasFilas = False
                    If ListaColNameNFilas.Contains(NameColumna) Then
                        '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
                        '// AUMENTANDO 
                        Datos = ValorCelda.Split(Chr(10))
                        If (Datos.Length > NumMaxFilas) Then
                            NumMaxFilas = Datos.Length
                            For Each Item As String In Datos
                                If (Item.Length > MaxLenDato) Then
                                    NumMaxFilas = NumMaxFilas + 1
                                End If
                            Next
                        End If
                        '//(TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO TEXTTO
                        '//TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO NORMAL 
                        If NumMaxFilas > 1 Then
                            EsVariasFilas = True
                        Else
                            EsVariasFilas = False
                        End If

                    End If

                    Select Case TipoDato
                        Case pTNumero
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            If ColorIndex <> "" Then
                                Dim styleNumber_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                Estilos_Excel_NPOI(styleNumber_Temp, TipoEstilo.Numero, Nothing, ColorIndex)
                                styleNumber_Temp.SetFont(oFont)
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber_Temp
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
                            End If
                            If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
                            End If
                        Case pTTexto
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            Select Case EsVariasFilas
                                Case True
                                    If ColorIndex <> "" Then
                                        Dim styleNormal_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                        Estilos_Excel_NPOI(styleNormal_Temp, TipoEstilo.Normal, Nothing, ColorIndex)
                                        styleNormal_Temp.SetFont(oFont)
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal_Temp
                                    Else
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                                    End If

                                    If NameColumna = "TOBS" Then
                                        Dim a As String = ""
                                        CountOverMaxLenObs = 0
                                        If (ValorCelda.Length <> 0) Then
                                            OBS = ValorCelda.Split(Chr(10))
                                            If (OBS.Length > MAX_OBS_GROUP) Then
                                                MAX_OBS_GROUP = OBS.Length
                                                For Each Item As String In OBS
                                                    If (Item.Length > MaxLenObs) Then
                                                        CountOverMaxLenObs += 1
                                                    End If
                                                Next
                                                MAX_OBS_GROUP = MAX_OBS_GROUP + CountOverMaxLenObs
                                            End If
                                        End If
                                        objWorkSheet.SetColumnWidth(y, 28000)
                                    End If
                                Case False
                                    If ColorIndex <> "" Then
                                        Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                        Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Texto, Nothing, ColorIndex)
                                        styleTexto_Temp.SetFont(oFont)
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto_Temp
                                    Else
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
                                    End If
                                    If NameColumna = "TDITES" Then
                                        objWorkSheet.SetColumnWidth(y, 22800)
                                    End If
                                    If NameColumna = "TOBS" Then
                                        CountOverMaxLenObs = 0
                                        If (ValorCelda.Length <> 0) Then
                                            OBS = ValorCelda.Split(Chr(10))
                                            If (OBS.Length > MAX_OBS_GROUP) Then
                                                MAX_OBS_GROUP = OBS.Length
                                                For Each Item As String In OBS
                                                    If (Item.Length > MaxLenObs) Then
                                                        CountOverMaxLenObs += 1
                                                    End If
                                                Next
                                                MAX_OBS_GROUP = MAX_OBS_GROUP + CountOverMaxLenObs
                                            End If
                                        End If
                                        objWorkSheet.SetColumnWidth(y, 28000)
                                    End If
                            End Select
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

                            If (IsConTamanio = True) Then
                                objWorkSheet.SetColumnWidth(y, Tamanio)
                            End If
                        Case pTFecha
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            If ColorIndex <> "" Then
                                Dim styleFecha_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                Estilos_Excel_NPOI(styleFecha_Temp, TipoEstilo.Fecha, Nothing, ColorIndex)
                                styleFecha_Temp.SetFont(oFont)
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha_Temp
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
                            End If
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
                    End Select



                    If (NameColumna = "NORCML") Then
                        NORCML_ACTUAL = ("" & odtDataSource.Rows(i).Item("NORCML")).ToString.Trim
                        NORCML_ACTUAL_PARCIAL = odtDataSource.Rows(i).Item("NORCML").ToString.Trim & "_" & odtDataSource.Rows(i).Item("NRPARC").ToString.Trim
                        If (NORCML_ACTUAL <> NORCML_TEMP) Then

                            POS_TEMP_FIN_OC = (indice - 1 + rowActual) - 1
                            POS_FINAL_OC = (indice - 1 + rowActual) - 1
                            Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_OC, j, POS_TEMP_FIN_OC, j)
                            POS_TEMP_INICIO_OC = POS_TEMP_FIN_OC + 1
                            NORCML_TEMP = NORCML_ACTUAL
                            objWorkSheet.AddMergedRegion(Region)

                        ElseIf i = odtDataSource.Rows.Count - 1 AndAlso NORCML_ACTUAL = NORCML_TEMP Then

                            POS_TEMP_FIN_OC = (indice - 1 + rowActual)
                            POS_FINAL_OC = (indice - 1 + rowActual)
                            Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_OC, j, POS_TEMP_FIN_OC, j)
                            POS_TEMP_INICIO_OC = POS_TEMP_FIN_OC + 1
                            NORCML_TEMP = NORCML_ACTUAL
                            objWorkSheet.AddMergedRegion(Region)

                        End If
                    End If

                    If (NameColumna = "NRPARC") Then
                        NORCML_ACTUAL_PARCIAL = odtDataSource.Rows(i).Item("NORCML").ToString.Trim & "_" & odtDataSource.Rows(i).Item("NRPARC").ToString.Trim
                        If (NORCML_TEMP_PARCIAL <> NORCML_ACTUAL_PARCIAL) Then
                            CAMBIO_OC = True
                            POS_GRUPO_INICIO = POS_TEMP_INICIO_PARCIAL
                            POS_GRUPO_FIN = (indice - 1 + rowActual) - 1

                            POS_TEMP_FIN_PARCIAL = (indice - 1 + rowActual) - 1

                            If (MAX_OBS_GROUP > (POS_TEMP_FIN_PARCIAL - POS_TEMP_INICIO_PARCIAL)) Then
                                DIF = POS_TEMP_FIN_PARCIAL - POS_TEMP_INICIO_PARCIAL
                                If (DIF = 0) Then
                                    DIF = 1
                                End If
                                For X As Int32 = POS_TEMP_INICIO_PARCIAL To POS_TEMP_FIN_PARCIAL
                                    objWorkSheet.GetRow(X).Height = 284 * ((MAX_OBS_GROUP \ DIF))
                                Next
                            End If
                            MAX_OBS_GROUP = 0


                            Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_PARCIAL, j, POS_TEMP_FIN_PARCIAL, j)
                            POS_TEMP_INICIO_PARCIAL = POS_TEMP_FIN_PARCIAL + 1
                            objWorkSheet.AddMergedRegion(Region)
                            NORCML_TEMP_PARCIAL = NORCML_ACTUAL_PARCIAL

                        ElseIf i = odtDataSource.Rows.Count - 1 AndAlso NORCML_TEMP_PARCIAL = NORCML_ACTUAL_PARCIAL Then

                            CAMBIO_OC = True
                            POS_GRUPO_INICIO = POS_TEMP_INICIO_PARCIAL
                            POS_GRUPO_FIN = (indice - 1 + rowActual)
                            POS_TEMP_FIN_PARCIAL = (indice - 1 + rowActual)

                            If (MAX_OBS_GROUP > (POS_TEMP_FIN_PARCIAL - POS_TEMP_INICIO_PARCIAL)) Then
                                DIF = POS_TEMP_FIN_PARCIAL - POS_TEMP_INICIO_PARCIAL
                                If (DIF = 0) Then
                                    DIF = 1
                                End If
                                For X As Int32 = POS_TEMP_INICIO_PARCIAL To POS_TEMP_FIN_PARCIAL
                                    objWorkSheet.GetRow(X).Height = 284 * ((MAX_OBS_GROUP \ DIF))
                                Next
                            End If
                            MAX_OBS_GROUP = 0

                            Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_PARCIAL, j, POS_TEMP_FIN_PARCIAL, j)
                            POS_TEMP_INICIO_PARCIAL = POS_TEMP_FIN_PARCIAL + 1
                            objWorkSheet.AddMergedRegion(Region)
                            NORCML_TEMP_PARCIAL = NORCML_ACTUAL_PARCIAL
                        End If
                    End If
                    IndiceColum += 1
                Next
                If (CAMBIO_OC = True) Then
                    For j As Int32 = 0 To odtDataSource.Columns.Count - 1
                        Select Case odtDataSource.Columns(j).ColumnName.Trim.ToUpper
                            Case "FROCMP", "FORCML", "TTINTC", "TCTCST", "TPRVCL", "NMONOC", "TNMMDT", "NREFCL", "TOBS", "TNOMCOM"
                                Dim RegionOC As New NPOI.SS.Util.Region(POS_GRUPO_INICIO, j, POS_GRUPO_FIN, j)
                                objWorkSheet.AddMergedRegion(RegionOC)
                        End Select
                    Next
                    CAMBIO_OC = False
                End If


                rowActual += 1
            Next


            objWorkSheet.DefaultColumnWidth = 35
            objWorkSheet.DefaultRowHeightInPoints = 25
            intColumObs = odtDataSource.Columns("TOBS").Ordinal
            For z As Integer = 0 To odtDataSource.Columns.Count - 1
                If intColumObs <> z Then
                    If IsNothing(lstrTempColum(z)) Then
                        objWorkSheet.AutoSizeColumn(z, True)
                    Else
                        objWorkSheet.SetColumnWidth(z, 18663)
                    End If
                End If
            Next
        Next
        objWorkBook.Write(fs)
        fs.Close()
        HelpClass.AbrirDocumento(archivo)

    End Sub


    'Public Shared Sub ExportExcelGeneralRelease(ByVal odtDataSource As DataTable, ByVal Titulo As String, ByVal ListColNameNFilas As String, Optional ByVal filtro As SortedList = Nothing, Optional ByVal NameEliminarFilaDuplicada As String = "")

    '    Dim path As String = Application.StartupPath.ToString
    '    Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
    '    Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)

    '    '=====================================================================
    '    Dim objWorkBook As New HSSFWorkbook()
    '    Dim memoryStream As New MemoryStream()
    '    Dim objWorkSheet As New HSSFSheet(objWorkBook)
    '    '=============Stilos======================
    '    Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '    Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '    Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontFiltro.FontHeight = fontSizeFiltros

    '    Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    oFontCab.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontCab.FontHeight = fontSizeColumnaHeader

    '    Dim oFontCabPlomo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontCabPlomo.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    oFontCabPlomo.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontCabPlomo.FontHeight = fontSizeColumnaHeader


    '    Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.FontHeight = fontSizeCelda


    '    Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
    '    Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
    '    Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

    '    Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
    '    Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
    '    Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)
    '    Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)

    '    '============================================
    '    styleFiltro.SetFont(oFontFiltro)
    '    styleCab.SetFont(oFontCab)
    '    styleTitulo.SetFont(oFontFiltro)

    '    styleNormal.SetFont(oFont)
    '    styleNumber.SetFont(oFont)
    '    styleFecha.SetFont(oFont)
    '    styleTexto.SetFont(oFont)

    '    '===================Se cargan Las Variables de Trabajo=====================
    '    Dim indice As Integer = 0
    '    Dim rowActual As Integer = 6
    '    Dim IndiceColum As Integer = 0
    '    Dim y As Integer = 0
    '    Dim intCantidadRows As Integer = 0
    '    Dim intColumObs As Integer = 0
    '    Dim lstrTempColum As New Hashtable
    '    intCantidadRows = odtDataSource.Rows.Count + 20

    '    Dim NameHoja As String = ""
    '    If odtDataSource.TableName.Trim.Length = 0 Then
    '        NameHoja = "Hoja01"
    '    Else
    '        NameHoja = odtDataSource.TableName
    '    End If
    '    objWorkSheet = objWorkBook.CreateSheet(NameHoja)


    '    Dim DobleCabecera As Boolean = False
    '    Dim CaptionColumna As String
    '    Dim Captions() As String
    '    Dim Cabeceras() As String

    '    Dim oHasDatosData As Hashtable
    '    Dim oListColDobleCabecera As New List(Of String)
    '    Dim NameColumna As String = ""

    '    Dim dtFilasFormato As New DataTable
    '    dtFilasFormato = Formatear_GetFormatoFila(odtDataSource)

    '    For Each dc As DataColumn In odtDataSource.Columns
    '        NameColumna = dc.ColumnName.Trim
    '        CaptionColumna = dc.Caption.Trim
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
    '        If (Captions.Length > 1) Then
    '            DobleCabecera = True
    '            oListColDobleCabecera.Add(NameColumna)
    '        End If
    '    Next

    '    For s As Integer = 0 To (intCantidadRows)
    '        objWorkSheet.CreateRow(s)
    '    Next
    '    Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1
    '    '==============Verificamos Filtro a utilizar==================
    '    objWorkSheet.GetRow(2).CreateCell(2).CellStyle = styleTitulo
    '    objWorkSheet.GetRow(2).GetCell(2).SetCellValue(Titulo)
    '    objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 2, 2, 5))

    '    If filtro Is Nothing Then
    '        rowActual = rowActual + 1
    '    Else
    '        Dim x As Integer = 0
    '        Dim ValCeldas() As String
    '        Dim DisplayTitle As String = ""
    '        Dim DipplayValue As String = ""
    '        For Each items As DictionaryEntry In filtro
    '            DisplayTitle = ""
    '            DipplayValue = ""
    '            ValCeldas = ("" & items.Value).ToString.Split("|")
    '            If ValCeldas.Length > 1 Then
    '                DisplayTitle = ValCeldas(0)
    '                DipplayValue = ValCeldas(1)
    '            End If
    '            x = x + 1
    '            DipplayValue = DisplayTitle & "  " & DipplayValue
    '            objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)
    '            objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 3))
    '        Next
    '        rowActual = rowActual + filtro.Count - 1
    '    End If

    '    Dim ValorCelda As String = ""
    '    Dim tituloColumna As String = ""
    '    Dim NumMaxFilasTitulo As Int32 = 0
    '    Dim DatosTitulo() As String
    '    Dim MaxShortTitulo As Short = 32767
    '    Dim TotalHeightTitulo As Int32 = 0
    '    Dim ColorFondoCab As String = ""
    '    Dim ColorLetraCab As String = ""
    '    Dim ColorFondo As String = ""
    '    Dim ColorLetra As String = ""
    '    Dim ColorIndex As String = ""
    '    Dim oHasFormatoFila As New Hashtable
    '    Dim ValCelda As String = ""


    '    For j As Integer = 0 To odtDataSource.Columns.Count - 1

    '        y = IndiceColum
    '        CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        tituloColumna = oHasDatosData(keyTituloColumna)

    '        ColorFondoCab = oHasDatosData(keyColorFondo)
    '        ColorLetraCab = oHasDatosData(keyColorLetra)

    '        Cabeceras = tituloColumna.Split("|")

    '        If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
    '            Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '            Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

    '            Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '            oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
    '            oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '            oFontCabTemp.FontHeight = fontSizeColumnaHeader
    '            styleCabTemp.SetFont(oFontCabTemp)
    '            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '        Else
    '            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
    '        End If
    '        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))

    '        '***AMPLIAR EL TAMANIO DEL TITULO DE LA COLUMNA 
    '        NumMaxFilasTitulo = 1
    '        DatosTitulo = Cabeceras(0).Split(Chr(10))
    '        If (DatosTitulo.Length > NumMaxFilasTitulo) Then
    '            NumMaxFilasTitulo = DatosTitulo.Length
    '        End If
    '        If NumMaxFilasTitulo > 1 Then
    '            For X As Int32 = rowActual - 1 To rowActual
    '                TotalHeightTitulo = 284 * NumMaxFilasTitulo
    '                If TotalHeightTitulo > MaxShortTitulo Then
    '                    objWorkSheet.GetRow(X).Height = MaxShortTitulo
    '                Else
    '                    objWorkSheet.GetRow(X).Height = TotalHeightTitulo
    '                End If
    '            Next
    '        End If
    '        '*************************************
    '        If (DobleCabecera = True) Then
    '            If (Cabeceras.Length > 1) Then

    '                If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
    '                    Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                    Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

    '                    Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '                    oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
    '                    oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '                    oFontCabTemp.FontHeight = fontSizeColumnaHeader
    '                    styleCabTemp.SetFont(oFontCabTemp)

    '                    'objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '                Else
    '                    '  objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
    '                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
    '                End If
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '                'objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '            Else

    '                If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
    '                    Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                    Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

    '                    Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '                    oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
    '                    oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '                    oFontCabTemp.FontHeight = fontSizeColumnaHeader
    '                    styleCabTemp.SetFont(oFontCabTemp)
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '                    'objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '                Else
    '                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
    '                    ' objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
    '                End If
    '                'objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
    '            End If
    '        End If
    '        IndiceColum += 1
    '    Next

    '    Dim row As New NPOI.HSSF.UserModel.HSSFRow
    '    Row = objWorkSheet.GetRow(indice + rowActual - 1)
    '    Dim IsBreak As Boolean = False
    '    Dim PosInicioBreak As Int32 = 0
    '    Dim PosFinalBreak As Int32 = 0
    '    Dim ValorCeldaActual As String
    '    Dim ValorCeldaNext As String = ""
    '    Dim oListCeldaTitleIguales As New List(Of Int32)
    '    Dim ColIndexInicial As Int32 = 0
    '    Dim ColIndexFinal As Int32 = 0

    '    If DobleCabecera = True Then
    '        For x As Int32 = 0 To odtDataSource.Columns.Count - 1
    '            NameColumna = odtDataSource.Columns(x).ColumnName
    '            ColIndexInicial = x
    '            ValorCeldaActual = Row.GetCell(ColIndexInicial).StringCellValue.Trim
    '            If x = odtDataSource.Columns.Count - 1 Then
    '                ColIndexFinal = x
    '                ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
    '            Else
    '                ColIndexFinal = x + 1
    '                ValorCeldaNext = Row.GetCell(ColIndexFinal).StringCellValue.Trim

    '            End If
    '            If ValorCeldaNext = ValorCeldaActual Then
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '            Else
    '                PosFinalBreak = ColIndexInicial
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '                IsBreak = True
    '            End If
    '            If IsBreak = True Then
    '                If oListCeldaTitleIguales.Count > 1 Then
    '                    'SI TIENE MAS DE 2 COLUMNAS IGUALES
    '                    For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
    '                        If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
    '                            Row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
    '                        End If
    '                    Next
    '                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
    '                    objWorkSheet.AddMergedRegion(Region)
    '                Else
    '                    If Not oListColDobleCabecera.Contains(NameColumna) Then
    '                        'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
    '                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
    '                        objWorkSheet.AddMergedRegion(Region)
    '                    End If
    '                End If
    '                PosInicioBreak = PosFinalBreak + 1
    '                oListCeldaTitleIguales = New List(Of Int32)
    '                IsBreak = False
    '            End If
    '        Next
    '        rowActual += 1
    '    End If
    '    rowActual += 1

    '    Dim ValorNumero As Decimal = 0
    '    Dim NumMaxFilas As Int32 = 0
    '    Dim Datos() As String
    '    Const MaxLenDato As Int32 = 120
    '    Dim Tamanio As Int32 = 0
    '    Dim IsConTamanio As Boolean = False
    '    Dim TipoDato As String = ""
    '    Dim Fecha As Date
    '    Dim EsVariasFilas As Boolean = False

    '    Dim ListaColNameNFilas As New List(Of String)
    '    If ListColNameNFilas IsNot Nothing Then
    '        For Each Item As String In ListColNameNFilas.Split(pNFilas)
    '            ListaColNameNFilas.Add(Item)
    '        Next
    '    End If



    '    Dim COL1_KBRE_ACTUAL As String = ""

    '    Dim COL1_KBRE_TEMP As String = ""

    '    Dim POS_TEMP_INICIO_COL1_KBRE As Int32 = indice - 1 + rowActual
    '    Dim POS_TEMP_FIN_COL1_KBRE As Int32 = 0

    '    If (NameEliminarFilaDuplicada.Trim <> "" AndAlso odtDataSource.Columns(NameEliminarFilaDuplicada) IsNot Nothing AndAlso odtDataSource.Rows.Count > 0) Then
    '        COL1_KBRE_TEMP = odtDataSource.Rows(0).Item(NameEliminarFilaDuplicada).ToString.Trim
    '    End If

    '    Dim POS_FINAL_COL1_KBRE As Int32 = 0


    '    For i As Integer = 0 To odtDataSource.Rows.Count - 1
    '        IndiceColum = 0
    '        NumMaxFilas = 1
    '        IsConTamanio = False

    '        oHasFormatoFila = DesFormatoFila(dtFilasFormato.Rows(i)(keyNameColFormatoFila))
    '        ColorIndex = oHasFormatoFila(keyColorFondo)

    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '            y = IndiceColum
    '            ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '            ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
    '            CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '            NameColumna = odtDataSource.Columns(j).ColumnName
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            TipoDato = oHasDatosData(keyTipoDato)

    '            EsVariasFilas = False
    '            If ListaColNameNFilas.Contains(NameColumna) Then
    '                '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
    '                '// AUMENTANDO 
    '                Datos = ValorCelda.Split(Chr(10))
    '                If (Datos.Length > NumMaxFilas) Then
    '                    NumMaxFilas = Datos.Length
    '                    For Each Item As String In Datos
    '                        If (Item.Length > MaxLenDato) Then
    '                            NumMaxFilas = NumMaxFilas + 1
    '                        End If
    '                    Next
    '                End If
    '                '//(TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO TEXTTO
    '                '//TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO NORMAL 
    '                If NumMaxFilas > 1 Then
    '                    EsVariasFilas = True
    '                Else
    '                    EsVariasFilas = False
    '                End If

    '            End If
    '            Select Case TipoDato
    '                Case pTNumero
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                    If ColorIndex <> "" Then
    '                        Dim styleNumber_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                        Estilos_Excel_NPOI(styleNumber_Temp, TipoEstilo.Numero, Nothing, ColorIndex)
    '                        styleNumber_Temp.SetFont(oFont)
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber_Temp
    '                    Else
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
    '                    End If
    '                    If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
    '                    Else
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                    End If
    '                Case pTTexto
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                    Select Case EsVariasFilas
    '                        Case True
    '                            If ColorIndex <> "" Then
    '                                Dim styleNormal_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                                Estilos_Excel_NPOI(styleNormal_Temp, TipoEstilo.Normal, Nothing, ColorIndex)
    '                                styleNormal_Temp.SetFont(oFont)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal_Temp
    '                            Else
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
    '                            End If
    '                        Case False
    '                            If ColorIndex <> "" Then
    '                                Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                                Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Texto, Nothing, ColorIndex)
    '                                styleTexto_Temp.SetFont(oFont)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto_Temp
    '                            Else
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
    '                            End If
    '                    End Select
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

    '                    If (IsConTamanio = True) Then
    '                        objWorkSheet.SetColumnWidth(y, Tamanio)
    '                    End If
    '                Case pTFecha
    '                    If (Date.TryParse(ValorCelda, Fecha)) Then
    '                        ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                    Else
    '                        ValorCelda = ""
    '                    End If
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)

    '                    If ColorIndex <> "" Then
    '                        Dim styleFecha_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                        Estilos_Excel_NPOI(styleFecha_Temp, TipoEstilo.Fecha, Nothing, ColorIndex)
    '                        styleFecha_Temp.SetFont(oFont)
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha_Temp
    '                    Else
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
    '                    End If
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '            End Select

    '            If (NameEliminarFilaDuplicada <> "" AndAlso odtDataSource.Columns(NameEliminarFilaDuplicada) IsNot Nothing AndAlso NameColumna = NameEliminarFilaDuplicada) Then
    '                COL1_KBRE_ACTUAL = ("" & odtDataSource.Rows(i).Item(NameEliminarFilaDuplicada)).ToString.Trim

    '                If (COL1_KBRE_ACTUAL <> COL1_KBRE_TEMP) Then

    '                    POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual) - 1
    '                    POS_FINAL_COL1_KBRE = (indice - 1 + rowActual) - 1
    '                    Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
    '                    POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
    '                    COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
    '                    objWorkSheet.AddMergedRegion(Region)

    '                ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL1_KBRE_ACTUAL = COL1_KBRE_TEMP Then

    '                    POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual)
    '                    POS_FINAL_COL1_KBRE = (indice - 1 + rowActual)
    '                    Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
    '                    POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
    '                    COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
    '                    objWorkSheet.AddMergedRegion(Region)

    '                End If
    '            End If


    '            IndiceColum += 1
    '        Next

    '        Dim MaxShort As Short = 32767
    '        Dim TotalHeight As Int32 = 0
    '        If NumMaxFilas > 1 Then
    '            For X As Int32 = rowActual - 1 To rowActual - 1
    '                TotalHeight = 284 * NumMaxFilas
    '                'TotalHeight = 255 * NumMaxFilas
    '                If TotalHeight > MaxShort Then
    '                    objWorkSheet.GetRow(X).Height = MaxShort
    '                Else
    '                    objWorkSheet.GetRow(X).Height = TotalHeight
    '                End If
    '            Next
    '        End If
    '        rowActual += 1
    '        'Next

    '        objWorkSheet.DefaultColumnWidth = 35
    '        objWorkSheet.DefaultRowHeightInPoints = 25
    '        For z As Integer = 0 To odtDataSource.Columns.Count - 1
    '            objWorkSheet.AutoSizeColumn(z, True)
    '        Next

    '    Next






    '    objWorkBook.Write(fs)
    '    fs.Close()
    '    HelpClass.AbrirDocumento(archivo)

    'End Sub

    'Public Sub ExportExcelReportMonthly(ByVal oListdtDataSource As List(Of DataTable), Optional ByVal Cliente As String = "", Optional ByVal lstrPeriodo As String = "")

    '    Dim path As String = Application.StartupPath.ToString
    '    Dim archivo As String = "Operacion Aduanas Monthly Reports -" & HelpClass.NowNumeric & ".xls"
    '    Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)

    '    '=====================================================================
    '    Dim objWorkBook As New HSSFWorkbook()
    '    Dim memoryStream As New MemoryStream()
    '    Dim objWorkSheet As New HSSFSheet(objWorkBook)
    '    '=============Stilos======================
    '    Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim style As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()


    '    Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontFiltro.FontHeight = fontSizeFiltros

    '    Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontCab.FontHeight = fontSizeColumnaHeader





    '    Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.FontHeight = fontSizeCelda

    '    Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
    '    Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
    '    Estilos_Excel_NPOI(style, TipoEstilo.Normal)
    '    Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

    '    Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
    '    Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)

    '    '============================================
    '    styleFiltro.SetFont(oFontFiltro)
    '    styleCab.SetFont(oFontCab)
    '    style.SetFont(oFont)
    '    styleTitulo.SetFont(oFontFiltro)
    '    styleNumber.SetFont(oFont)
    '    styleFecha.SetFont(oFont)

    '    '===================Se cargan Las Variables de Trabajo=====================
    '    Dim strLibro As String = ""
    '    Dim odtDataSource As New DataTable
    '    Dim subTitulo As String = ""
    '    Dim FechaActual As String = Now.ToString("dd/MM/yyyy")
    '    Dim HoraActual As String = Now.ToString("hh:mm:ss")

    '    For FilaTable As Integer = 0 To oListdtDataSource.Count - 1
    '        odtDataSource = oListdtDataSource(FilaTable).Copy
    '        Dim indice As Integer = 0
    '        Dim rowActual As Integer = 6
    '        Dim IndiceColum As Integer = 0
    '        Dim y As Integer = 0
    '        Dim intCantidadRows As Integer = 0
    '        Dim ValorCelda As String = ""

    '        Select Case FilaTable
    '            Case 0
    '                strLibro = "Operación Aduanas"
    '                subTitulo = "OPERACIÓN ADUANAS - " & lstrPeriodo
    '            Case 1
    '                strLibro = "Facturación Aduanas"
    '                subTitulo = "FACTURACIÓN ADUANAS - " & lstrPeriodo
    '            Case 2
    '                strLibro = "Detalle ADD"
    '                subTitulo = "DETALLE AVISOS DE DÉBITO AGENCIAS RANSA - " & lstrPeriodo
    '            Case 3
    '                strLibro = "Tiempo Entrega Docs."
    '                subTitulo = " TIEMPO DE ENTREGA DE DOCUMENTO - " & lstrPeriodo
    '            Case 4
    '                strLibro = "Contenedores"
    '                subTitulo = "RELACIÓN CONTENEDORES Y LÍNEAS NAVIERAS - " & lstrPeriodo
    '        End Select

    '        intCantidadRows = odtDataSource.Rows.Count + 20
    '        objWorkSheet = objWorkBook.CreateSheet(strLibro)
    '        Dim DobleCabecera As Boolean = False
    '        Dim CaptionColumna As String
    '        Dim Captions() As String
    '        Dim Cabeceras() As String

    '        Dim oHasDatosData As Hashtable
    '        For Each dc As DataColumn In odtDataSource.Columns
    '            CaptionColumna = dc.Caption.Trim
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
    '            If (Captions.Length > 1) Then
    '                DobleCabecera = True
    '                Exit For
    '            End If
    '        Next

    '        For s As Integer = 0 To (intCantidadRows)
    '            objWorkSheet.CreateRow(s)
    '        Next

    '        Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1
    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '            objWorkSheet.GetRow(2).CreateCell(j).CellStyle = styleTitulo
    '            objWorkSheet.GetRow(3).CreateCell(j).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(4).CreateCell(j).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(5).CreateCell(j).CellStyle = styleFiltro
    '        Next

    '        objWorkSheet.GetRow(2).GetCell(0).SetCellValue(subTitulo)
    '        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 0, 2, numColumnas))

    '        If (Cliente.Length <> 0) Then
    '            objWorkSheet.GetRow(3).GetCell(0).SetCellValue("Cliente:")
    '            objWorkSheet.GetRow(3).GetCell(1).SetCellValue(Cliente)
    '            objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(3, 1, 3, numColumnas))
    '        End If

    '        objWorkSheet.GetRow(4).GetCell(0).SetCellValue("Fecha:")
    '        objWorkSheet.GetRow(4).GetCell(1).SetCellValue(FechaActual)
    '        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(4, 1, 4, numColumnas))

    '        objWorkSheet.GetRow(5).GetCell(0).SetCellValue("Hora:")
    '        objWorkSheet.GetRow(5).GetCell(1).SetCellValue(HoraActual)
    '        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(5, 1, 5, numColumnas))

    '        Dim styleCenterCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        styleCenterCab = styleCab
    '        styleCenterCab.VerticalAlignment = VerticalAlignment.CENTER

    '        rowActual += 1

    '        Dim tituloColumna As String = ""
    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '            y = IndiceColum
    '            CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            tituloColumna = oHasDatosData(keyTituloColumna)
    '            Cabeceras = tituloColumna.Split("|")
    '            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
    '            If (DobleCabecera = True) Then
    '                If (Cabeceras.Length > 1) Then
    '                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '                Else
    '                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '                End If
    '            End If
    '            IndiceColum += 1
    '        Next

    '        Dim row As New NPOI.HSSF.UserModel.HSSFRow
    '        row = objWorkSheet.GetRow(indice + rowActual - 1)
    '        For x As Int32 = 0 To odtDataSource.Columns.Count - 1
    '            If (x + 1 < odtDataSource.Columns.Count) Then
    '                If row.GetCell(x).StringCellValue.Trim = row.GetCell(x + 1).StringCellValue.Trim Then
    '                    row.GetCell(x + 1).SetCellValue("")
    '                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice - 1 + rowActual, x + 1)
    '                    objWorkSheet.AddMergedRegion(Region)
    '                    x += 1
    '                Else
    '                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice + rowActual, x)
    '                    objWorkSheet.AddMergedRegion(Region)
    '                End If
    '            Else
    '                Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, x, indice + rowActual, x)
    '                objWorkSheet.AddMergedRegion(Region)
    '            End If
    '        Next
    '        rowActual += 2
    '        Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        styleWrap = style
    '        styleWrap.WrapText = True
    '        styleWrap.VerticalAlignment = VerticalAlignment.CENTER
    '        Dim IndexWrap As Int32 = 0
    '        Dim NombreColumna As String = ""


    '        Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        styleTexto = style
    '        styleTexto.WrapText = True

    '        Dim TipoDato As String = ""
    '        Dim Alineacion As String = ""
    '        Dim ValorNumero As Decimal = 0
    '        Dim NumMaxFilas As Int32 = 0
    '        Dim Datos() As String
    '        Dim Fecha As Date
    '        Dim ColumnName As String = ""
    '        For i As Integer = 0 To odtDataSource.Rows.Count - 1
    '            IndiceColum = 0
    '            NumMaxFilas = 1
    '            For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '                y = IndiceColum
    '                ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '                CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '                oHasDatosData = DesFormatDato(CaptionColumna)
    '                TipoDato = oHasDatosData(keyTipoDato)

    '                ColumnName = odtDataSource.Columns(j).ColumnName

    '                Select Case ColumnName
    '                    Case "NORCML"
    '                        Datos = ValorCelda.Split(Chr(10))
    '                        If (Datos.Length > NumMaxFilas) Then
    '                            NumMaxFilas = Datos.Length
    '                        End If
    '                End Select

    '                Select Case TipoDato
    '                    Case pTNumero
    '                        Decimal.TryParse(ValorCelda, ValorNumero)
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNumber
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                    Case pTTexto
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = style
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                    Case pTFecha
    '                        If (Date.TryParse(ValorCelda, Fecha)) Then
    '                            ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                        Else
    '                            ValorCelda = ""
    '                        End If
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleFecha
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                End Select
    '                IndiceColum += 1
    '            Next
    '            For X As Int32 = rowActual - 1 To rowActual
    '                objWorkSheet.GetRow(X).Height = 284 * NumMaxFilas
    '            Next
    '            rowActual += 1
    '        Next
    '        objWorkSheet.DefaultColumnWidth = 35
    '        objWorkSheet.DefaultRowHeightInPoints = 25
    '        For z As Integer = 0 To odtDataSource.Columns.Count - 1
    '            objWorkSheet.AutoSizeColumn(z, True)
    '        Next

    '    Next

    '    objWorkBook.Write(fs)
    '    fs.Close()
    '    HelpClass.AbrirDocumento(archivo)


    'End Sub


    Public Shared Sub ExportExcelSeguimientoAduanas(ByVal odtDataSource As DataTable, ByVal Titulo As String, ByVal ListColNameNFilas As String, Optional ByVal filtro As SortedList = Nothing, Optional ByVal ListLeyenda As List(Of DataTable) = Nothing)

        Dim path As String = Application.StartupPath.ToString
        Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
        Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)

        '=====================================================================
        Dim objWorkBook As New HSSFWorkbook()
        Dim memoryStream As New MemoryStream()
        Dim objWorkSheet As New HSSFSheet(objWorkBook)
        '=============Stilos======================
        Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

        Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

        Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontFiltro.FontHeight = fontSizeFiltros

        Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
        oFontCab.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontCab.FontHeight = fontSizeColumnaHeader

        Dim oFontCabPlomo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontCabPlomo.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
        oFontCabPlomo.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontCabPlomo.FontHeight = fontSizeColumnaHeader


        Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.FontHeight = fontSizeCelda


        Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
        Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
        Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

        Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
        Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
        Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)
        Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)

        '============================================
        styleFiltro.SetFont(oFontFiltro)
        styleCab.SetFont(oFontCab)
        styleTitulo.SetFont(oFontFiltro)

        styleNormal.SetFont(oFont)
        styleNumber.SetFont(oFont)
        styleFecha.SetFont(oFont)
        styleTexto.SetFont(oFont)

        '===================Se cargan Las Variables de Trabajo=====================
        Dim indice As Integer = 0
        Dim rowActual As Integer = 6
        Dim IndiceColum As Integer = 0
        Dim y As Integer = 0
        Dim intCantidadRows As Integer = 0
        Dim intColumObs As Integer = 0
        Dim lstrTempColum As New Hashtable
        intCantidadRows = odtDataSource.Rows.Count + 20
        objWorkSheet = objWorkBook.CreateSheet("Hoja01")
        Dim DobleCabecera As Boolean = False
        Dim CaptionColumna As String
        Dim Captions() As String
        Dim Cabeceras() As String

        Dim oHasDatosData As Hashtable
        Dim oListColDobleCabecera As New List(Of String)
        Dim NameColumna As String = ""

        Dim dtFilasFormato As New DataTable
        dtFilasFormato = Formatear_GetFormatoFila(odtDataSource)

        For Each dc As DataColumn In odtDataSource.Columns
            NameColumna = dc.ColumnName.Trim
            CaptionColumna = dc.Caption.Trim
            oHasDatosData = DesFormatDato(CaptionColumna)
            Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
            If (Captions.Length > 1) Then
                DobleCabecera = True
                oListColDobleCabecera.Add(NameColumna)
            End If
        Next

        For s As Integer = 0 To (intCantidadRows)
            objWorkSheet.CreateRow(s)
        Next
        Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1
        '==============Verificamos Filtro a utilizar==================
        objWorkSheet.GetRow(2).CreateCell(3).CellStyle = styleTitulo
        objWorkSheet.GetRow(2).GetCell(3).SetCellValue(Titulo)
        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 3, 2, 10))

        If filtro Is Nothing Then
            rowActual = rowActual + 1
        Else
            Dim x As Integer = 0
            Dim ValCeldas() As String
            Dim DisplayTitle As String = ""
            Dim DipplayValue As String = ""
            For Each items As DictionaryEntry In filtro
                DisplayTitle = ""
                DipplayValue = ""
                ValCeldas = ("" & items.Value).ToString.Trim.Split("|")
                If ValCeldas.Length > 1 Then
                    DisplayTitle = ValCeldas(0).Trim
                    DipplayValue = ValCeldas(1).Trim
                End If
                x = x + 1
                DipplayValue = DisplayTitle & "  " & DipplayValue
                objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
                objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)
                objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 5))
            Next
            rowActual = rowActual + filtro.Count - 1
        End If

        Dim ValorCelda As String = ""
        Dim tituloColumna As String = ""
        Dim NumMaxFilasTitulo As Int32 = 0
        Dim DatosTitulo() As String
        Dim MaxShortTitulo As Short = 32767
        Dim TotalHeightTitulo As Int32 = 0
        Dim ColorFondoCab As String = ""
        Dim ColorLetraCab As String = ""
        Dim ColorFondo As String = ""
        Dim ColorLetra As String = ""
        Dim ColorIndex As String = ""
        Dim oHasFormatoFila As New Hashtable
        Dim ValCelda As String = ""

        If ListLeyenda IsNot Nothing Then
            Dim dtLeyendaCanal As New DataTable
            dtLeyendaCanal = ListLeyenda.Item(0)
            Dim XInicio As Int32 = 0
            Dim YInicio As Int32 = 0
            Dim dtFilasFormatoLey As New DataTable
            dtFilasFormatoLey = Formatear_GetFormatoFila(dtLeyendaCanal)

            For i As Integer = 0 To dtLeyendaCanal.Rows.Count - 1
                'oHasFormatoFila = DesFormatoFila(dtFilasFormatoLey.Rows(i)(keyNameColFormatoFila))
                'ColorFondo = oHasFormatoFila(keyColorFondo)
                'ColorLetra = oHasFormatoFila(keyColorLetra)
                oHasFormatoFila = DesFormatoFila(dtFilasFormatoLey.Rows(i)(pNameColFormatoFila))
                ColorFondo = oHasFormatoFila(pColorFondo)
                ColorLetra = oHasFormatoFila(pColorLetra)
                YInicio = odtDataSource.Columns.Count
                For j As Integer = 0 To dtLeyendaCanal.Columns.Count - 1
                    ValCelda = dtLeyendaCanal.Rows(i)(j)
                    Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                    Dim oFontTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                    oFontTemp.Color = Convert.ToInt16(ColorLetra)
                    oFontTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD

                    oFontTemp.FontHeight = fontSizeColumnaHeader
                    styleTexto_Temp.SetFont(oFontTemp)
                    Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Cabecera, Nothing, ColorFondo)

                    objWorkSheet.GetRow(XInicio).CreateCell(YInicio)
                    objWorkSheet.GetRow(XInicio).GetCell(YInicio).CellStyle = styleTexto_Temp
                    objWorkSheet.GetRow(XInicio).GetCell(YInicio).SetCellValue(ValCelda)

                    YInicio = YInicio + 1
                Next

                XInicio = XInicio + 1

            Next

        End If

        For j As Integer = 0 To odtDataSource.Columns.Count - 1

            y = IndiceColum
            CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
            oHasDatosData = DesFormatDato(CaptionColumna)
            tituloColumna = oHasDatosData(keyTituloColumna)

            'ColorFondoCab = oHasDatosData(keyColorFondo)
            'ColorLetraCab = oHasDatosData(keyColorLetra)
            ColorFondoCab = oHasDatosData(pColorFondo)
            ColorLetraCab = oHasDatosData(pColorLetra)

            Cabeceras = tituloColumna.Split("|")

            If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
                Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

                Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
                oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                oFontCabTemp.FontHeight = fontSizeColumnaHeader
                styleCabTemp.SetFont(oFontCabTemp)
                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp

            Else
                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
            End If
            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))

            '***AMPLIAR EL TAMANIO DEL TITULO DE LA COLUMNA 
            NumMaxFilasTitulo = 1
            DatosTitulo = Cabeceras(0).Split(Chr(10))
            If (DatosTitulo.Length > NumMaxFilasTitulo) Then
                NumMaxFilasTitulo = DatosTitulo.Length
            End If
            If NumMaxFilasTitulo > 1 Then
                For X As Int32 = rowActual - 1 To rowActual
                    TotalHeightTitulo = 284 * NumMaxFilasTitulo
                    If TotalHeightTitulo > MaxShortTitulo Then
                        objWorkSheet.GetRow(X).Height = MaxShortTitulo
                    Else
                        objWorkSheet.GetRow(X).Height = TotalHeightTitulo
                    End If
                Next
            End If
            '*************************************
            If (DobleCabecera = True) Then
                If (Cabeceras.Length > 1) Then

                    If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
                        Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                        Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

                        Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                        oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
                        oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                        oFontCabTemp.FontHeight = fontSizeColumnaHeader
                        styleCabTemp.SetFont(oFontCabTemp)

                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
                    Else
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
                    End If


                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
                Else

                    If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
                        Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                        Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

                        Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                        oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
                        oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                        oFontCabTemp.FontHeight = fontSizeColumnaHeader
                        styleCabTemp.SetFont(oFontCabTemp)

                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
                    Else
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
                    End If
                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
                End If
            End If
            IndiceColum += 1
        Next

        Dim row As New NPOI.HSSF.UserModel.HSSFRow
        row = objWorkSheet.GetRow(indice + rowActual - 1)
        Dim IsBreak As Boolean = False
        Dim PosInicioBreak As Int32 = 0
        Dim PosFinalBreak As Int32 = 0
        Dim ValorCeldaActual As String
        Dim ValorCeldaNext As String = ""
        Dim oListCeldaTitleIguales As New List(Of Int32)
        Dim ColIndexInicial As Int32 = 0
        Dim ColIndexFinal As Int32 = 0

        If DobleCabecera = True Then
            For x As Int32 = 0 To odtDataSource.Columns.Count - 1
                NameColumna = odtDataSource.Columns(x).ColumnName
                ColIndexInicial = x
                ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
                If x = odtDataSource.Columns.Count - 1 Then
                    ColIndexFinal = x
                    ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
                Else
                    ColIndexFinal = x + 1
                    ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

                End If
                If ValorCeldaNext = ValorCeldaActual Then
                    oListCeldaTitleIguales.Add(ColIndexInicial)
                Else
                    PosFinalBreak = ColIndexInicial
                    oListCeldaTitleIguales.Add(ColIndexInicial)
                    IsBreak = True
                End If
                If IsBreak = True Then
                    If oListCeldaTitleIguales.Count > 1 Then
                        'SI TIENE MAS DE 2 COLUMNAS IGUALES
                        For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
                            If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
                                row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
                            End If
                        Next
                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
                        objWorkSheet.AddMergedRegion(Region)
                    Else
                        If Not oListColDobleCabecera.Contains(NameColumna) Then
                            'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
                            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
                            objWorkSheet.AddMergedRegion(Region)
                        End If
                    End If
                    PosInicioBreak = PosFinalBreak + 1
                    oListCeldaTitleIguales = New List(Of Int32)
                    IsBreak = False
                End If
            Next
            rowActual += 1
        End If
        rowActual += 1

        Dim ValorNumero As Decimal = 0
        Dim NumMaxFilas As Int32 = 0
        Dim Datos() As String
        Const MaxLenDato As Int32 = 120
        Dim Tamanio As Int32 = 0
        Dim IsConTamanio As Boolean = False
        Dim TipoDato As String = ""
        Dim Fecha As Date
        Dim EsVariasFilas As Boolean = False

        Dim ListaColNameNFilas As New List(Of String)
        If ListColNameNFilas IsNot Nothing Then
            For Each Item As String In ListColNameNFilas.Split(pNFilas)
                ListaColNameNFilas.Add(Item)
            Next
        End If

        For i As Integer = 0 To odtDataSource.Rows.Count - 1
            IndiceColum = 0
            NumMaxFilas = 1
            IsConTamanio = False

            'oHasFormatoFila = DesFormatoFila(dtFilasFormato.Rows(i)(keyNameColFormatoFila))
            'ColorIndex = oHasFormatoFila(keyColorFondo)
            oHasFormatoFila = DesFormatoFila(dtFilasFormato.Rows(i)(pNameColFormatoFila))
            ColorIndex = oHasFormatoFila(pColorFondo)


            For j As Integer = 0 To odtDataSource.Columns.Count - 1
                y = IndiceColum
                ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
                CaptionColumna = odtDataSource.Columns(j).Caption.Trim
                NameColumna = odtDataSource.Columns(j).ColumnName
                oHasDatosData = DesFormatDato(CaptionColumna)
                TipoDato = oHasDatosData(keyTipoDato)

                EsVariasFilas = False
                If ListaColNameNFilas.Contains(NameColumna) Then
                    '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
                    '// AUMENTANDO 
                    Datos = ValorCelda.Split(Chr(10))
                    If (Datos.Length > NumMaxFilas) Then
                        NumMaxFilas = Datos.Length
                        For Each Item As String In Datos
                            If (Item.Length > MaxLenDato) Then
                                NumMaxFilas = NumMaxFilas + 1
                            End If
                        Next
                    End If
                    '//(TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO TEXTTO
                    '//TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO NORMAL 
                    If NumMaxFilas > 1 Then
                        EsVariasFilas = True
                    Else
                        EsVariasFilas = False
                    End If

                End If
                Select Case odtDataSource.Columns(j).ColumnName
                    Case "TOBERV", "TOBERVDIF"
                        IsConTamanio = True
                        Tamanio = 24000
                End Select
                Select Case TipoDato
                    Case pTNumero
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                        If ColorIndex <> "" Then
                            Dim styleNumber_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                            Estilos_Excel_NPOI(styleNumber_Temp, TipoEstilo.Numero, Nothing, ColorIndex)
                            styleNumber_Temp.SetFont(oFont)
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber_Temp
                        Else
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
                        End If
                        If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
                        Else
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
                        End If
                    Case pTTexto
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                        Select Case EsVariasFilas
                            Case True
                                If ColorIndex <> "" Then
                                    Dim styleNormal_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                    Estilos_Excel_NPOI(styleNormal_Temp, TipoEstilo.Normal, Nothing, ColorIndex)
                                    styleNormal_Temp.SetFont(oFont)
                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal_Temp
                                Else
                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                                End If
                            Case False
                                If ColorIndex <> "" Then
                                    Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                    Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Texto, Nothing, ColorIndex)
                                    styleTexto_Temp.SetFont(oFont)
                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto_Temp
                                Else
                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
                                End If
                        End Select
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

                        If (IsConTamanio = True) Then
                            objWorkSheet.SetColumnWidth(y, Tamanio)
                        End If
                    Case pTFecha
                        If (Date.TryParse(ValorCelda, Fecha)) Then
                            ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
                        Else
                            ValorCelda = ""
                        End If
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)

                        If ColorIndex <> "" Then
                            Dim styleFecha_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                            Estilos_Excel_NPOI(styleFecha_Temp, TipoEstilo.Fecha, Nothing, ColorIndex)
                            styleFecha_Temp.SetFont(oFont)
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha_Temp
                        Else
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
                        End If
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
                End Select
                IndiceColum += 1
            Next

            Dim MaxShort As Short = 32767
            Dim TotalHeight As Int32 = 0
            If NumMaxFilas > 1 Then
                For X As Int32 = rowActual - 1 To rowActual - 1
                    TotalHeight = 284 * NumMaxFilas
                    'TotalHeight = 255 * NumMaxFilas
                    If TotalHeight > MaxShort Then
                        objWorkSheet.GetRow(X).Height = MaxShort
                    Else
                        objWorkSheet.GetRow(X).Height = TotalHeight
                    End If
                Next
            End If
            rowActual += 1
        Next


        If ListLeyenda IsNot Nothing Then
            Dim dtLeyendaStatus As New DataTable
            dtLeyendaStatus = ListLeyenda.Item(1)
            Dim XInicio As Int32 = rowActual + 1
            Dim YInicio As Int32 = 1
            Dim dtFilasFormatoStatus As New DataTable
            dtFilasFormatoStatus = Formatear_GetFormatoFila(dtLeyendaStatus)

            For i As Integer = 0 To dtLeyendaStatus.Rows.Count - 1
                'oHasFormatoFila = DesFormatoFila(dtFilasFormatoStatus.Rows(i)(keyNameColFormatoFila)) 'pNameColFormatoFila
                oHasFormatoFila = DesFormatoFila(dtFilasFormatoStatus.Rows(i)(pNameColFormatoFila))
                'ColorFondo = oHasFormatoFila(keyColorFondo)
                ColorFondo = oHasFormatoFila(pColorFondo)
                'ColorLetra = oHasFormatoFila(keyColorLetra) 'pColorLetra
                ColorLetra = oHasFormatoFila(pColorLetra)
                YInicio = 1
                For j As Integer = 0 To dtLeyendaStatus.Columns.Count - 1
                    ValCelda = ("" & dtLeyendaStatus.Rows(i)(j)).ToString.Trim
                    Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                    Dim oFontTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                    oFontTemp.Color = Convert.ToInt16(ColorLetra)
                    oFontTemp.FontHeight = fontSizeColumnaHeader
                    styleTexto_Temp.SetFont(oFontTemp)
                    If ValCelda = "LEYENDA" Then
                        oFontTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                        Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Filtro, Nothing, ColorFondo)
                    Else
                        Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Texto, Nothing, ColorFondo)
                    End If
                    styleTexto_Temp.SetFont(oFontTemp)
                    objWorkSheet.GetRow(XInicio).CreateCell(YInicio)
                    objWorkSheet.GetRow(XInicio).GetCell(YInicio).CellStyle = styleTexto_Temp
                    objWorkSheet.GetRow(XInicio).GetCell(YInicio).SetCellValue(ValCelda)
                    YInicio = YInicio + 1
                Next
                XInicio = XInicio + 1
            Next
        End If

        objWorkSheet.DefaultColumnWidth = 35
        objWorkSheet.DefaultRowHeightInPoints = 25
        If (odtDataSource.Columns("TOBERV") IsNot Nothing) Then
            intColumObs = odtDataSource.Columns("TOBERV").Ordinal
        ElseIf odtDataSource.Columns("TOBERVDIF") IsNot Nothing Then
            intColumObs = odtDataSource.Columns("TOBERVDIF").Ordinal
        Else
            intColumObs = -1
        End If
        For z As Integer = 0 To odtDataSource.Columns.Count - 1
            If intColumObs <> z Then
                objWorkSheet.AutoSizeColumn(z, True)
            End If
        Next
        objWorkBook.Write(fs)
        fs.Close()
        HelpClass.AbrirDocumento(archivo)

    End Sub
    Private Shared Function LoadImage(ByVal path As String, ByVal wb As HSSFWorkbook) As Integer
        Dim file As New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim buffer As Byte() = New Byte(file.Length - 1) {}
        file.Read(buffer, 0, CInt(file.Length))
        Return wb.AddPicture(buffer, PictureType.JPEG)
    End Function


    Public Sub ExportExcelCierreOrdenCompra(ByVal odtDataSource As DataTable, ByVal Titulo As String, ByVal ListFormatComaMiles As List(Of String), ByVal ListTotalizables As List(Of String), Optional ByVal filtro As SortedList = Nothing)

        Dim path As String = Application.StartupPath.ToString
        Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
        Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)


        '=====================================================================
        Dim objWorkBook As New HSSFWorkbook()
        Dim memoryStream As New MemoryStream()
        Dim objWorkSheet As New HSSFSheet(objWorkBook)
        '=============Stilos======================
        Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()


        Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontFiltro.FontHeight = fontSizeFiltros


        Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
        oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontCab.FontHeight = fontSizeColumnaHeader

        Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.FontHeight = fontSizeCelda


        Dim oFontCabPlomo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontCabPlomo.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontCabPlomo.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontCabPlomo.FontHeight = fontSizeCelda



        Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
        Dim GREY_25_PERCENT As Short = 22
        Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera, Nothing, GREY_25_PERCENT)

        Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
        Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

        Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
        Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)


        Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)


        '============================================
        styleFiltro.SetFont(oFontFiltro)
        styleCab.SetFont(oFontCabPlomo)
        styleNormal.SetFont(oFont)
        styleTitulo.SetFont(oFontFiltro)
        styleNumber.SetFont(oFont)
        styleFecha.SetFont(oFont)
        styleTexto.SetFont(oFont)



        '===================Se cargan Las Variables de Trabajo=====================
        Dim indice As Integer = 0
        Dim rowActual As Integer = 6
        Dim IndiceColum As Integer = 0
        Dim y As Integer = 0
        Dim intCantidadRows As Integer = 0
        Dim ValorCelda As String = ""
        intCantidadRows = odtDataSource.Rows.Count + 20
        objWorkSheet = objWorkBook.CreateSheet("Hoja01")
        Dim DobleCabecera As Boolean = False
        Dim CaptionColumna As String
        Dim Captions() As String
        Dim Cabeceras() As String

        Dim oHasDatosData As Hashtable
        Dim oListNameDobleCabecera As New List(Of String)
        Dim NameColumna As String = ""
        For Each dc As DataColumn In odtDataSource.Columns
            NameColumna = dc.ColumnName.Trim
            CaptionColumna = dc.Caption.Trim
            oHasDatosData = DesFormatDato(CaptionColumna)
            Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
            If (Captions.Length > 1) Then
                DobleCabecera = True
                oListNameDobleCabecera.Add(NameColumna)
            End If
        Next

        For s As Integer = 0 To (intCantidadRows)
            objWorkSheet.CreateRow(s)
        Next

        Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1

        '*************
        '==============Verificamos Filtro a utilizar==================
        objWorkSheet.GetRow(2).CreateCell(3).CellStyle = styleTitulo
        objWorkSheet.GetRow(2).GetCell(3).SetCellValue(Titulo)
        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 3, 2, 10))


        If filtro Is Nothing Then
            rowActual = rowActual + 1
        Else
            Dim x As Integer = 0
            Dim ValCeldas() As String
            Dim DisplayTitle As String = ""
            Dim DipplayValue As String = ""
            For Each items As DictionaryEntry In filtro
                DisplayTitle = ""
                DipplayValue = ""
                ValCeldas = ("" & items.Value).ToString.Trim.Split("|")
                If ValCeldas.Length > 1 Then
                    DisplayTitle = ValCeldas(0).Trim
                    DipplayValue = ValCeldas(1).Trim
                End If
                x = x + 1
                DipplayValue = DisplayTitle & "  " & DipplayValue
                objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
                objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)

                objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 5))

            Next
            rowActual = rowActual + filtro.Count - 1
        End If

        Dim tituloColumna As String = ""
        For j As Integer = 0 To odtDataSource.Columns.Count - 1
            y = IndiceColum
            CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
            oHasDatosData = DesFormatDato(CaptionColumna)
            tituloColumna = oHasDatosData(keyTituloColumna)
            Cabeceras = tituloColumna.Split("|")
            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
            If (DobleCabecera = True) Then
                If (Cabeceras.Length > 1) Then
                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
                Else
                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
                End If
            End If
            IndiceColum += 1
        Next
        Dim row As New NPOI.HSSF.UserModel.HSSFRow
        row = objWorkSheet.GetRow(indice + rowActual - 1)
        Dim IsBreak As Boolean = False
        Dim PosInicioBreak As Int32 = 0
        Dim PosFinalBreak As Int32 = 0
        Dim ValorCeldaActual As String
        Dim ValorCeldaNext As String = ""
        Dim oListCeldaTitleIguales As New List(Of Int32)
        Dim ColIndexInicial As Int32 = 0
        Dim ColIndexFinal As Int32 = 0

        If DobleCabecera = True Then
            For x As Int32 = 0 To odtDataSource.Columns.Count - 1
                NameColumna = odtDataSource.Columns(x).ColumnName
                ColIndexInicial = x
                ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
                If x = odtDataSource.Columns.Count - 1 Then
                    ColIndexFinal = x
                    ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
                Else
                    ColIndexFinal = x + 1
                    ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

                End If
                If ValorCeldaNext = ValorCeldaActual Then
                    oListCeldaTitleIguales.Add(ColIndexInicial)
                Else
                    PosFinalBreak = ColIndexInicial
                    oListCeldaTitleIguales.Add(ColIndexInicial)
                    IsBreak = True
                End If
                If IsBreak = True Then
                    If oListCeldaTitleIguales.Count > 1 Then
                        'SI TIENE MAS DE 2 COLUMNAS IGUALES
                        For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
                            If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
                                row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
                            End If
                        Next
                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
                        objWorkSheet.AddMergedRegion(Region)
                    Else
                        If Not oListNameDobleCabecera.Contains(NameColumna) Then
                            'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
                            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
                            objWorkSheet.AddMergedRegion(Region)
                        End If
                    End If
                    PosInicioBreak = PosFinalBreak + 1
                    oListCeldaTitleIguales = New List(Of Int32)
                    IsBreak = False
                End If
            Next
            rowActual += 1
        End If
        rowActual += 1

        Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        styleWrap = styleNormal
        styleWrap.WrapText = True
        styleWrap.VerticalAlignment = VerticalAlignment.CENTER
        Dim IndexWrap As Int32 = 0
        Dim NombreColumna As String = ""


        'Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        'styleTexto = styleNormal
        'styleTexto.WrapText = True

        Dim TipoDato As String = ""
        Dim Alineacion As String = ""
        Dim ValorNumero As Decimal = 0
        Dim Fecha As Date
        Dim CAMBIO_ITEM As Boolean = False
        Dim NRITOC_INIC As Decimal = 0
        Dim NRITOC_TMP As Decimal = 0
        If odtDataSource.Rows.Count > 0 Then
            NRITOC_INIC = odtDataSource.Rows(0)("NRITEM")
        End If

        Dim POS_GRUPO_INICIO As Int32 = 0
        Dim POS_GRUPO_FIN As Int32 = 0
        Dim POS_TEMP_INICIO_PARCIAL As Int32 = indice - 1 + rowActual


        Dim styleNumberFormat As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        styleNumberFormat.Alignment = NPOI.SS.UserModel.HorizontalAlignment.RIGHT
        styleNumberFormat.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
        styleNumberFormat.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
        styleNumberFormat.SetFont(oFont)

        styleNumberFormat.DataFormat = HSSFDataFormat.GetBuiltinFormat("#,##0.00")

        styleNumberFormat.FillPattern = FillPatternType.SOLID_FOREGROUND
        styleNumberFormat.BorderRight = CellBorderType.THIN
        styleNumberFormat.BorderBottom = CellBorderType.THIN
        styleNumberFormat.BorderLeft = CellBorderType.THIN
        styleNumberFormat.BorderTop = CellBorderType.THIN

        Dim NumTotalFilas As Int32 = odtDataSource.Rows.Count - 1
        Dim UltimaFila As Int32 = 0
        If ListTotalizables.Count > 0 Then
            UltimaFila = NumTotalFilas
            NumTotalFilas = NumTotalFilas - 1
        End If



        For i As Integer = 0 To NumTotalFilas
            IndiceColum = 0
            For j As Integer = 0 To odtDataSource.Columns.Count - 1
                NameColumna = odtDataSource.Columns(j).ColumnName

                y = IndiceColum
                ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                CaptionColumna = odtDataSource.Columns(j).Caption.Trim
                oHasDatosData = DesFormatDato(CaptionColumna)
                TipoDato = oHasDatosData(keyTipoDato)

                Select Case TipoDato
                    Case pTNumero
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
                        If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
                        Else
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
                        End If
                    Case pTTexto
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                        'objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
                    Case pTFecha
                        If (Date.TryParse(ValorCelda, Fecha)) Then
                            ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
                        Else
                            ValorCelda = ""
                        End If
                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
                End Select


                If NameColumna = "NRITEM" Then

                    If (i + 1) <= NumTotalFilas Then
                        NRITOC_TMP = odtDataSource.Rows(i + 1)(NameColumna)
                    ElseIf i = NumTotalFilas Then
                        NRITOC_TMP = 0
                    End If

                    If NRITOC_INIC <> NRITOC_TMP Then
                        NRITOC_INIC = NRITOC_TMP
                        CAMBIO_ITEM = True

                        POS_GRUPO_INICIO = POS_TEMP_INICIO_PARCIAL
                        POS_GRUPO_FIN = (indice - 1 + rowActual)
                        POS_TEMP_INICIO_PARCIAL = (indice - 1 + rowActual + 1)
                    End If
                End If


                IndiceColum += 1
            Next

            If (CAMBIO_ITEM = True) Then
                For j As Int32 = 0 To odtDataSource.Columns.Count - 1
                    Select Case odtDataSource.Columns(j).ColumnName.Trim.ToUpper
                        Case "NRITEM", "TDITES", "QCNTIT", "IVTOIT", "TTINTC", "IVUNIT"
                            Dim RegionOC As New NPOI.SS.Util.Region(POS_GRUPO_INICIO, j, POS_GRUPO_FIN, j)
                            objWorkSheet.AddMergedRegion(RegionOC)
                    End Select
                Next
                CAMBIO_ITEM = False
            End If

            rowActual += 1
        Next

        rowActual += 1

        For i As Integer = UltimaFila To UltimaFila
            IndiceColum = 0
            For j As Integer = 0 To odtDataSource.Columns.Count - 1
                NameColumna = odtDataSource.Columns(j).ColumnName
                y = IndiceColum
                ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                CaptionColumna = odtDataSource.Columns(j).Caption.Trim
                oHasDatosData = DesFormatDato(CaptionColumna)
                TipoDato = oHasDatosData(keyTipoDato)

                If ListTotalizables.Contains(NameColumna) Then

                    Select Case TipoDato
                        Case pTNumero
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
                            If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
                            End If
                        Case pTTexto
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
                        Case pTFecha
                            If (Date.TryParse(ValorCelda, Fecha)) Then
                                ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
                            Else
                                ValorCelda = ""
                            End If
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
                    End Select

                End If

                IndiceColum += 1
            Next
            rowActual += 1
        Next

        objWorkSheet.DefaultColumnWidth = 35
        objWorkSheet.DefaultRowHeightInPoints = 25
        For z As Integer = 0 To odtDataSource.Columns.Count - 1
            objWorkSheet.AutoSizeColumn(z, True)
        Next

        Dim patriarch As HSSFPatriarch = DirectCast(objWorkSheet.CreateDrawingPatriarch(), HSSFPatriarch)
        Dim anchor As HSSFClientAnchor
        anchor = New HSSFClientAnchor(0, 0, 0, 80, 0, 0, 0, 0)
        Dim rutaLogo As String = Application.StartupPath & "\Resources\logo_ransas.jpg"
        If IO.File.Exists(rutaLogo) Then
            'load the picture and get the picture index in the workbook
            Dim picture As HSSFPicture = DirectCast(patriarch.CreatePicture(anchor, LoadImage(rutaLogo, objWorkBook)), HSSFPicture)
            'Reset the image to the original size.
            picture.Resize(0.5)
        End If

        objWorkBook.Write(fs)
        fs.Close()
        HelpClass.AbrirDocumento(archivo)


    End Sub

    'Public Shared Sub ExportExcel_OSAgencia(ByVal odtDataSource As DataTable, ByVal Titulo As String, ByVal ListFormatComaMiles As List(Of String), ByVal ListTotalizables As List(Of String), Optional ByVal filtro As SortedList = Nothing)

    '    Dim path As String = Application.StartupPath.ToString
    '    Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
    '    Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)


    '    '=====================================================================
    '    Dim objWorkBook As New HSSFWorkbook()
    '    Dim memoryStream As New MemoryStream()
    '    Dim objWorkSheet As New HSSFSheet(objWorkBook)
    '    '=============Stilos======================
    '    Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()


    '    Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontFiltro.FontHeight = fontSizeFiltros


    '    Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontCab.FontHeight = fontSizeColumnaHeader

    '    Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.FontHeight = fontSizeCelda


    '    Dim oFontCabPlomo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontCabPlomo.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontCabPlomo.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontCabPlomo.FontHeight = fontSizeCelda



    '    Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
    '    Dim GREY_25_PERCENT As Short = 22
    '    Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera, Nothing, GREY_25_PERCENT)

    '    Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
    '    Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

    '    Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
    '    Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)


    '    Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)


    '    '============================================
    '    styleFiltro.SetFont(oFontFiltro)
    '    styleCab.SetFont(oFontCabPlomo)
    '    styleNormal.SetFont(oFont)
    '    styleTitulo.SetFont(oFontFiltro)
    '    styleNumber.SetFont(oFont)
    '    styleFecha.SetFont(oFont)
    '    styleTexto.SetFont(oFont)



    '    '===================Se cargan Las Variables de Trabajo=====================
    '    Dim indice As Integer = 0
    '    Dim rowActual As Integer = 6
    '    Dim IndiceColum As Integer = 0
    '    Dim y As Integer = 0
    '    Dim intCantidadRows As Integer = 0
    '    Dim ValorCelda As String = ""
    '    intCantidadRows = odtDataSource.Rows.Count + 20
    '    objWorkSheet = objWorkBook.CreateSheet("Hoja01")
    '    Dim DobleCabecera As Boolean = False
    '    Dim CaptionColumna As String
    '    Dim Captions() As String
    '    Dim Cabeceras() As String

    '    Dim oHasDatosData As Hashtable
    '    Dim oListNameDobleCabecera As New List(Of String)
    '    Dim NameColumna As String = ""
    '    For Each dc As DataColumn In odtDataSource.Columns
    '        NameColumna = dc.ColumnName.Trim
    '        CaptionColumna = dc.Caption.Trim
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
    '        If (Captions.Length > 1) Then
    '            DobleCabecera = True
    '            oListNameDobleCabecera.Add(NameColumna)
    '        End If
    '    Next

    '    For s As Integer = 0 To (intCantidadRows)
    '        objWorkSheet.CreateRow(s)
    '    Next

    '    Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1

    '    '*************
    '    '==============Verificamos Filtro a utilizar==================
    '    objWorkSheet.GetRow(2).CreateCell(3).CellStyle = styleTitulo
    '    objWorkSheet.GetRow(2).GetCell(3).SetCellValue(Titulo)
    '    objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 3, 2, 10))


    '    If filtro Is Nothing Then
    '        rowActual = rowActual + 1
    '    Else
    '        Dim x As Integer = 0
    '        Dim ValCeldas() As String
    '        Dim DisplayTitle As String = ""
    '        Dim DipplayValue As String = ""
    '        For Each items As DictionaryEntry In filtro
    '            DisplayTitle = ""
    '            DipplayValue = ""
    '            ValCeldas = ("" & items.Value).ToString.Trim.Split("|")
    '            If ValCeldas.Length > 1 Then
    '                DisplayTitle = ValCeldas(0).Trim
    '                DipplayValue = ValCeldas(1).Trim
    '            End If
    '            x = x + 1
    '            DipplayValue = DisplayTitle & "  " & DipplayValue
    '            objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)

    '            objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 5))

    '        Next
    '        rowActual = rowActual + filtro.Count - 1
    '    End If

    '    Dim tituloColumna As String = ""
    '    For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '        y = IndiceColum
    '        CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        tituloColumna = oHasDatosData(keyTituloColumna)
    '        Cabeceras = tituloColumna.Split("|")
    '        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
    '        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
    '        If (DobleCabecera = True) Then
    '            If (Cabeceras.Length > 1) Then
    '                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '            Else
    '                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
    '            End If
    '        End If
    '        IndiceColum += 1
    '    Next
    '    Dim row As New NPOI.HSSF.UserModel.HSSFRow
    '    row = objWorkSheet.GetRow(indice + rowActual - 1)
    '    Dim IsBreak As Boolean = False
    '    Dim PosInicioBreak As Int32 = 0
    '    Dim PosFinalBreak As Int32 = 0
    '    Dim ValorCeldaActual As String
    '    Dim ValorCeldaNext As String = ""
    '    Dim oListCeldaTitleIguales As New List(Of Int32)
    '    Dim ColIndexInicial As Int32 = 0
    '    Dim ColIndexFinal As Int32 = 0

    '    If DobleCabecera = True Then
    '        For x As Int32 = 0 To odtDataSource.Columns.Count - 1
    '            NameColumna = odtDataSource.Columns(x).ColumnName
    '            ColIndexInicial = x
    '            ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
    '            If x = odtDataSource.Columns.Count - 1 Then
    '                ColIndexFinal = x
    '                ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
    '            Else
    '                ColIndexFinal = x + 1
    '                ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

    '            End If
    '            If ValorCeldaNext = ValorCeldaActual Then
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '            Else
    '                PosFinalBreak = ColIndexInicial
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '                IsBreak = True
    '            End If
    '            If IsBreak = True Then
    '                If oListCeldaTitleIguales.Count > 1 Then
    '                    'SI TIENE MAS DE 2 COLUMNAS IGUALES
    '                    For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
    '                        If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
    '                            row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
    '                        End If
    '                    Next
    '                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
    '                    objWorkSheet.AddMergedRegion(Region)
    '                Else
    '                    If Not oListNameDobleCabecera.Contains(NameColumna) Then
    '                        'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
    '                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
    '                        objWorkSheet.AddMergedRegion(Region)
    '                    End If
    '                End If
    '                PosInicioBreak = PosFinalBreak + 1
    '                oListCeldaTitleIguales = New List(Of Int32)
    '                IsBreak = False
    '            End If
    '        Next
    '        rowActual += 1
    '    End If
    '    rowActual += 1

    '    Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleWrap = styleNormal
    '    styleWrap.WrapText = True
    '    styleWrap.VerticalAlignment = VerticalAlignment.CENTER
    '    Dim IndexWrap As Int32 = 0
    '    Dim NombreColumna As String = ""


    '    'Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    'styleTexto = styleNormal
    '    'styleTexto.WrapText = True

    '    Dim TipoDato As String = ""
    '    Dim Alineacion As String = ""
    '    Dim ValorNumero As Decimal = 0
    '    Dim Fecha As Date
    '    Dim CAMBIO_ITEM As Boolean = False
    '    Dim NRITOC_INIC As Decimal = 0
    '    Dim NRITOC_TMP As Decimal = 0
    '    If odtDataSource.Rows.Count > 0 Then
    '        NRITOC_INIC = odtDataSource.Rows(0)("NRITEM")
    '    End If

    '    Dim POS_GRUPO_INICIO As Int32 = 0
    '    Dim POS_GRUPO_FIN As Int32 = 0
    '    Dim POS_TEMP_INICIO_PARCIAL As Int32 = indice - 1 + rowActual


    '    Dim styleNumberFormat As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleNumberFormat.Alignment = NPOI.SS.UserModel.HorizontalAlignment.RIGHT
    '    styleNumberFormat.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    styleNumberFormat.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    styleNumberFormat.SetFont(oFont)

    '    styleNumberFormat.DataFormat = HSSFDataFormat.GetBuiltinFormat("#,##0.00")

    '    styleNumberFormat.FillPattern = FillPatternType.SOLID_FOREGROUND
    '    styleNumberFormat.BorderRight = CellBorderType.THIN
    '    styleNumberFormat.BorderBottom = CellBorderType.THIN
    '    styleNumberFormat.BorderLeft = CellBorderType.THIN
    '    styleNumberFormat.BorderTop = CellBorderType.THIN

    '    Dim NumTotalFilas As Int32 = odtDataSource.Rows.Count - 1
    '    Dim UltimaFila As Int32 = 0
    '    If ListTotalizables.Count > 0 Then
    '        UltimaFila = NumTotalFilas
    '        NumTotalFilas = NumTotalFilas - 1
    '    End If



    '    For i As Integer = 0 To NumTotalFilas
    '        IndiceColum = 0
    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '            NameColumna = odtDataSource.Columns(j).ColumnName

    '            y = IndiceColum
    '            ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '            CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            TipoDato = oHasDatosData(keyTipoDato)

    '            Select Case TipoDato
    '                Case pTNumero
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
    '                    If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
    '                    Else
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                    End If
    '                Case pTTexto
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                    'objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                Case pTFecha
    '                    'If (Date.TryParse(ValorCelda, Fecha)) Then
    '                    '    ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                    'Else
    '                    '    ValorCelda = ""
    '                    'End If
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '            End Select


    '            '    If NameColumna = "NRITEM" Then

    '            '        If (i + 1) <= NumTotalFilas Then
    '            '            NRITOC_TMP = odtDataSource.Rows(i + 1)(NameColumna)
    '            '        ElseIf i = NumTotalFilas Then
    '            '            NRITOC_TMP = 0
    '            '        End If

    '            '        If NRITOC_INIC <> NRITOC_TMP Then
    '            '            NRITOC_INIC = NRITOC_TMP
    '            '            CAMBIO_ITEM = True

    '            '            POS_GRUPO_INICIO = POS_TEMP_INICIO_PARCIAL
    '            '            POS_GRUPO_FIN = (indice - 1 + rowActual)
    '            '            POS_TEMP_INICIO_PARCIAL = (indice - 1 + rowActual + 1)
    '            '        End If
    '            '    End If


    '            IndiceColum += 1
    '        Next

    '        'If (CAMBIO_ITEM = True) Then
    '        '    For j As Int32 = 0 To odtDataSource.Columns.Count - 1
    '        '        Select Case odtDataSource.Columns(j).ColumnName.Trim.ToUpper
    '        '            Case "NRITEM", "TDITES", "QCNTIT", "IVTOIT", "TTINTC", "IVUNIT"
    '        '                Dim RegionOC As New NPOI.SS.Util.Region(POS_GRUPO_INICIO, j, POS_GRUPO_FIN, j)
    '        '                objWorkSheet.AddMergedRegion(RegionOC)
    '        '        End Select
    '        '    Next
    '        '    CAMBIO_ITEM = False
    '        'End If

    '        rowActual += 1
    '    Next

    '    rowActual += 1

    '    'For i As Integer = UltimaFila To UltimaFila
    '    '    IndiceColum = 0
    '    '    For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '    '        NameColumna = odtDataSource.Columns(j).ColumnName
    '    '        y = IndiceColum
    '    '        ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '    '        CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '    '        TipoDato = oHasDatosData(keyTipoDato)

    '    '        If ListTotalizables.Contains(NameColumna) Then

    '    '            Select Case TipoDato
    '    '                Case pTNumero
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
    '    '                    If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
    '    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
    '    '                    Else
    '    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '    '                    End If
    '    '                Case pTTexto
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '    '                Case pTFecha
    '    '                    If (Date.TryParse(ValorCelda, Fecha)) Then
    '    '                        ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '    '                    Else
    '    '                        ValorCelda = ""
    '    '                    End If
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
    '    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '    '            End Select

    '    '        End If

    '    '        IndiceColum += 1
    '    '    Next
    '    '    rowActual += 1
    '    'Next

    '    objWorkSheet.DefaultColumnWidth = 35
    '    objWorkSheet.DefaultRowHeightInPoints = 25
    '    For z As Integer = 0 To odtDataSource.Columns.Count - 1
    '        objWorkSheet.AutoSizeColumn(z, True)
    '    Next

    '    Dim patriarch As HSSFPatriarch = DirectCast(objWorkSheet.CreateDrawingPatriarch(), HSSFPatriarch)
    '    Dim anchor As HSSFClientAnchor
    '    anchor = New HSSFClientAnchor(0, 0, 0, 80, 0, 0, 0, 0)
    '    Dim rutaLogo As String = Application.StartupPath & "\Resources\logo_ransas.jpg"
    '    If IO.File.Exists(rutaLogo) Then
    '        'load the picture and get the picture index in the workbook
    '        Dim picture As HSSFPicture = DirectCast(patriarch.CreatePicture(anchor, LoadImage(rutaLogo, objWorkBook)), HSSFPicture)
    '        'Reset the image to the original size.
    '        picture.Resize(0.5)
    '    End If

    '    objWorkBook.Write(fs)
    '    fs.Close()
    '    HelpClass.AbrirDocumento(archivo)


    'End Sub


    'Public Sub ExportExcelGeneralReleaseEmbarcadoItem(ByVal odtDataSource As DataTable, ByVal Titulo As String, ByVal oListColMerge As List(Of String), ByVal ColMerge As String, Optional ByVal filtro As SortedList = Nothing)

    '    Dim path As String = Application.StartupPath.ToString
    '    Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
    '    Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)


    '    '=====================================================================
    '    Dim objWorkBook As New HSSFWorkbook()
    '    Dim memoryStream As New MemoryStream()
    '    Dim objWorkSheet As New HSSFSheet(objWorkBook)
    '    '=============Stilos======================
    '    Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim style As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '    Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontFiltro.FontHeight = fontSizeFiltros

    '    Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontCab.FontHeight = fontSizeColumnaHeader

    '    Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.FontHeight = fontSizeCelda

    '    Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
    '    Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
    '    Estilos_Excel_NPOI(style, TipoEstilo.Normal)
    '    Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

    '    Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
    '    Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)

    '    '============================================
    '    styleFiltro.SetFont(oFontFiltro)
    '    styleCab.SetFont(oFontCab)
    '    style.SetFont(oFont)
    '    styleTitulo.SetFont(oFontFiltro)
    '    styleNumber.SetFont(oFont)
    '    styleFecha.SetFont(oFont)


    '    '===================Se cargan Las Variables de Trabajo=====================
    '    Dim indice As Integer = 0
    '    Dim rowActual As Integer = 6
    '    Dim IndiceColum As Integer = 0
    '    Dim y As Integer = 0
    '    Dim intCantidadRows As Integer = 0
    '    Dim ValorCelda As String = ""
    '    intCantidadRows = odtDataSource.Rows.Count + 20
    '    objWorkSheet = objWorkBook.CreateSheet("Hoja01")
    '    Dim DobleCabecera As Boolean = False
    '    Dim CaptionColumna As String
    '    Dim Captions() As String
    '    Dim Cabeceras() As String

    '    Dim oHasDatosData As Hashtable
    '    Dim oListNameDobleCabecera As New List(Of String)
    '    Dim NameColumna As String = ""
    '    For Each dc As DataColumn In odtDataSource.Columns
    '        NameColumna = dc.ColumnName.Trim
    '        CaptionColumna = dc.Caption.Trim
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
    '        If (Captions.Length > 1) Then
    '            DobleCabecera = True
    '            oListNameDobleCabecera.Add(NameColumna)
    '        End If
    '    Next

    '    For s As Integer = 0 To (intCantidadRows)
    '        objWorkSheet.CreateRow(s)
    '    Next

    '    Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1


    '    '*************
    '    '==============Verificamos Filtro a utilizar==================
    '    objWorkSheet.GetRow(2).CreateCell(0).CellStyle = styleTitulo
    '    objWorkSheet.GetRow(2).GetCell(0).SetCellValue(Titulo)
    '    objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 0, 2, numColumnas))


    '    If filtro Is Nothing Then
    '        rowActual = rowActual + 1
    '    Else
    '        Dim x As Integer = 0
    '        Dim ValCeldas() As String
    '        Dim DisplayTitle As String = ""
    '        Dim DipplayValue As String = ""
    '        For Each items As DictionaryEntry In filtro
    '            DisplayTitle = ""
    '            DipplayValue = ""
    '            ValCeldas = ("" & items.Value).ToString.Trim.Split("|")
    '            If ValCeldas.Length > 1 Then
    '                DisplayTitle = ValCeldas(0).Trim
    '                DipplayValue = ValCeldas(1).Trim
    '            End If
    '            x = x + 1
    '            objWorkSheet.CreateRow(rowActual + x - 3)
    '            objWorkSheet.GetRow(rowActual + x - 3).CreateCell(0).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(rowActual + x - 3).GetCell(0).SetCellValue(DisplayTitle)

    '            objWorkSheet.GetRow(rowActual + x - 3).CreateCell(1).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(rowActual + x - 3).GetCell(1).SetCellValue(DipplayValue)

    '        Next
    '        rowActual = rowActual + filtro.Count + 1
    '    End If
    '    Dim styleCenterCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleCenterCab = styleCab
    '    styleCenterCab.VerticalAlignment = VerticalAlignment.CENTER

    '    Dim tituloColumna As String = ""
    '    For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '        y = IndiceColum
    '        CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        tituloColumna = oHasDatosData(keyTituloColumna)
    '        Cabeceras = tituloColumna.Split("|")
    '        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
    '        If (DobleCabecera = True) Then
    '            If (Cabeceras.Length > 1) Then
    '                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '            Else
    '                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
    '            End If
    '        End If
    '        IndiceColum += 1
    '    Next

    '    Dim row As New NPOI.HSSF.UserModel.HSSFRow
    '    row = objWorkSheet.GetRow(indice + rowActual - 1)
    '    Dim IsBreak As Boolean = False
    '    Dim PosInicioBreak As Int32 = 0
    '    Dim PosFinalBreak As Int32 = 0
    '    Dim ValorCeldaActual As String
    '    Dim ValorCeldaNext As String = ""
    '    Dim oListCeldaTitleIguales As New List(Of Int32)
    '    Dim ColIndexInicial As Int32 = 0
    '    Dim ColIndexFinal As Int32 = 0

    '    If DobleCabecera = True Then
    '        For x As Int32 = 0 To odtDataSource.Columns.Count - 1
    '            NameColumna = odtDataSource.Columns(x).ColumnName
    '            ColIndexInicial = x
    '            ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
    '            If x = odtDataSource.Columns.Count - 1 Then
    '                ColIndexFinal = x
    '                ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
    '            Else
    '                ColIndexFinal = x + 1
    '                ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

    '            End If
    '            If ValorCeldaNext = ValorCeldaActual Then
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '            Else
    '                PosFinalBreak = ColIndexInicial
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '                IsBreak = True
    '            End If
    '            If IsBreak = True Then
    '                If oListCeldaTitleIguales.Count > 1 Then
    '                    'SI TIENE MAS DE 2 COLUMNAS IGUALES
    '                    For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
    '                        If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
    '                            row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
    '                        End If
    '                    Next
    '                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
    '                    objWorkSheet.AddMergedRegion(Region)
    '                Else
    '                    If Not oListNameDobleCabecera.Contains(NameColumna) Then
    '                        'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
    '                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
    '                        objWorkSheet.AddMergedRegion(Region)
    '                    End If
    '                End If
    '                PosInicioBreak = PosFinalBreak + 1
    '                oListCeldaTitleIguales = New List(Of Int32)
    '                IsBreak = False
    '            End If
    '        Next
    '        rowActual += 1
    '    End If
    '    rowActual += 1


    '    Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleWrap = style
    '    styleWrap.WrapText = True
    '    styleWrap.VerticalAlignment = VerticalAlignment.CENTER
    '    Dim IndexWrap As Int32 = 0
    '    Dim NombreColumna As String = ""


    '    Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleTexto = style
    '    styleTexto.WrapText = True

    '    Dim TipoDato As String = ""
    '    Dim Alineacion As String = ""
    '    Dim ValorNumero As Decimal = 0
    '    Dim Fecha As Date

    '    Dim POS_GRUPO_INICIO As Int32 = 0
    '    Dim POS_GRUPO_FIN As Int32 = 0
    '    Dim POS_TEMP_INICIO_PARCIAL As Int32 = indice - 1 + rowActual

    '    Dim NumTotalFilas As Int32 = odtDataSource.Rows.Count - 1
    '    Dim UltimaFila As Int32 = 0


    '    Dim CAMBIO_MERGE As Boolean = False
    '    Dim MERGE_INIC As Decimal = 0
    '    Dim MERGE_TMP As Decimal = 0
    '    If odtDataSource.Rows.Count > 0 Then
    '        MERGE_INIC = odtDataSource.Rows(0)(ColMerge)
    '    End If



    '    For i As Integer = 0 To odtDataSource.Rows.Count - 1
    '        IndiceColum = 0
    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '            y = IndiceColum
    '            NameColumna = odtDataSource.Columns(j).ColumnName
    '            ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '            CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            TipoDato = oHasDatosData(keyTipoDato)

    '            Select Case TipoDato
    '                Case pTNumero
    '                    Decimal.TryParse(ValorCelda, ValorNumero)
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNumber
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                Case pTTexto
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = style
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                Case pTFecha
    '                    If (Date.TryParse(ValorCelda, Fecha)) Then
    '                        ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                    Else
    '                        ValorCelda = ""
    '                    End If
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleFecha
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '            End Select


    '            If NameColumna = ColMerge Then
    '                If (i + 1) <= NumTotalFilas Then
    '                    MERGE_TMP = odtDataSource.Rows(i + 1)(NameColumna)
    '                ElseIf i = NumTotalFilas Then
    '                    MERGE_TMP = 0
    '                End If
    '                If MERGE_INIC <> MERGE_TMP Then
    '                    MERGE_INIC = MERGE_TMP
    '                    CAMBIO_MERGE = True

    '                    POS_GRUPO_INICIO = POS_TEMP_INICIO_PARCIAL
    '                    POS_GRUPO_FIN = (indice - 1 + rowActual)
    '                    POS_TEMP_INICIO_PARCIAL = (indice - 1 + rowActual + 1)
    '                End If
    '            End If



    '            IndiceColum += 1


    '        Next

    '        If (CAMBIO_MERGE = True) Then
    '            For j As Int32 = 0 To odtDataSource.Columns.Count - 1
    '                NameColumna = odtDataSource.Columns(j).ColumnName.Trim.ToUpper
    '                If oListColMerge.Contains(NameColumna) Then
    '                    Dim RegionOC As New NPOI.SS.Util.Region(POS_GRUPO_INICIO, j, POS_GRUPO_FIN, j)
    '                    objWorkSheet.AddMergedRegion(RegionOC)
    '                End If
    '            Next
    '            CAMBIO_MERGE = False
    '        End If
    '        rowActual += 1
    '    Next
    '    objWorkSheet.DefaultColumnWidth = 35
    '    objWorkSheet.DefaultRowHeightInPoints = 25

    '    For z As Integer = 0 To odtDataSource.Columns.Count - 1
    '        objWorkSheet.AutoSizeColumn(z, True)
    '    Next


    '    objWorkBook.Write(fs)
    '    fs.Close()
    '    HelpClass.AbrirDocumento(archivo)


    'End Sub

    'Public Sub ExportExcel_Agencia(ByVal odtDataSource As DataTable, ByVal Titulo As String, Optional ByVal filtro As SortedList = Nothing)

    '    Dim path As String = Application.StartupPath.ToString
    '    Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
    '    Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)


    '    '=====================================================================
    '    Dim objWorkBook As New HSSFWorkbook()
    '    Dim memoryStream As New MemoryStream()
    '    Dim objWorkSheet As New HSSFSheet(objWorkBook)
    '    '=============Stilos======================
    '    Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim style As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '    Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontFiltro.FontHeight = fontSizeFiltros

    '    Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '    oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontCab.FontHeight = fontSizeColumnaHeader

    '    Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.FontHeight = fontSizeCelda

    '    Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
    '    Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
    '    Estilos_Excel_NPOI(style, TipoEstilo.Normal)
    '    Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

    '    Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
    '    Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)


    '    '============================================
    '    styleFiltro.SetFont(oFontFiltro)
    '    styleCab.SetFont(oFontCab)
    '    style.SetFont(oFont)
    '    styleTitulo.SetFont(oFontFiltro)
    '    styleNumber.SetFont(oFont)
    '    styleFecha.SetFont(oFont)


    '    '===================Se cargan Las Variables de Trabajo=====================
    '    Dim indice As Integer = 0
    '    Dim rowActual As Integer = 6
    '    Dim IndiceColum As Integer = 0
    '    Dim y As Integer = 0
    '    Dim intCantidadRows As Integer = 0
    '    Dim ValorCelda As String = ""
    '    intCantidadRows = odtDataSource.Rows.Count + 20
    '    objWorkSheet = objWorkBook.CreateSheet("Hoja01")
    '    Dim DobleCabecera As Boolean = False
    '    Dim CaptionColumna As String
    '    Dim Captions() As String
    '    Dim Cabeceras() As String

    '    Dim oHasDatosData As Hashtable
    '    Dim oListNameDobleCabecera As New List(Of String)
    '    Dim NameColumna As String = ""
    '    For Each dc As DataColumn In odtDataSource.Columns
    '        NameColumna = dc.ColumnName.Trim
    '        CaptionColumna = dc.Caption.Trim
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
    '        If (Captions.Length > 1) Then
    '            DobleCabecera = True
    '            oListNameDobleCabecera.Add(NameColumna)
    '        End If
    '    Next

    '    For s As Integer = 0 To (intCantidadRows)
    '        objWorkSheet.CreateRow(s)
    '    Next

    '    Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1


    '    '*************
    '    '==============Verificamos Filtro a utilizar==================
    '    objWorkSheet.GetRow(2).CreateCell(0).CellStyle = styleTitulo
    '    objWorkSheet.GetRow(2).GetCell(0).SetCellValue(Titulo)
    '    objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 0, 2, numColumnas))


    '    If filtro Is Nothing Then
    '        rowActual = rowActual + 1
    '    Else
    '        Dim x As Integer = 0
    '        Dim ValCeldas() As String
    '        Dim DisplayTitle As String = ""
    '        Dim DipplayValue As String = ""
    '        For Each items As DictionaryEntry In filtro
    '            DisplayTitle = ""
    '            DipplayValue = ""
    '            ValCeldas = ("" & items.Value).ToString.Trim.Split("|")
    '            If ValCeldas.Length > 1 Then
    '                DisplayTitle = ValCeldas(0).Trim
    '                DipplayValue = ValCeldas(1).Trim
    '            End If
    '            x = x + 1
    '            objWorkSheet.CreateRow(rowActual + x - 3)
    '            objWorkSheet.GetRow(rowActual + x - 3).CreateCell(0).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(rowActual + x - 3).GetCell(0).SetCellValue(DisplayTitle)

    '            objWorkSheet.GetRow(rowActual + x - 3).CreateCell(1).CellStyle = styleFiltro
    '            objWorkSheet.GetRow(rowActual + x - 3).GetCell(1).SetCellValue(DipplayValue)

    '        Next
    '        rowActual = rowActual + filtro.Count + 1
    '    End If
    '    Dim styleCenterCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleCenterCab = styleCab
    '    styleCenterCab.VerticalAlignment = VerticalAlignment.CENTER

    '    Dim tituloColumna As String = ""
    '    For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '        y = IndiceColum
    '        CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
    '        oHasDatosData = DesFormatDato(CaptionColumna)
    '        tituloColumna = oHasDatosData(keyTituloColumna)
    '        Cabeceras = tituloColumna.Split("|")
    '        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
    '        If (DobleCabecera = True) Then
    '            If (Cabeceras.Length > 1) Then
    '                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '            Else
    '                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab
    '                objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
    '            End If
    '        End If
    '        IndiceColum += 1
    '    Next

    '    Dim row As New NPOI.HSSF.UserModel.HSSFRow
    '    row = objWorkSheet.GetRow(indice + rowActual - 1)
    '    Dim IsBreak As Boolean = False
    '    Dim PosInicioBreak As Int32 = 0
    '    Dim PosFinalBreak As Int32 = 0
    '    Dim ValorCeldaActual As String
    '    Dim ValorCeldaNext As String = ""
    '    Dim oListCeldaTitleIguales As New List(Of Int32)
    '    Dim ColIndexInicial As Int32 = 0
    '    Dim ColIndexFinal As Int32 = 0

    '    If DobleCabecera = True Then
    '        For x As Int32 = 0 To odtDataSource.Columns.Count - 1
    '            NameColumna = odtDataSource.Columns(x).ColumnName
    '            ColIndexInicial = x
    '            ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
    '            If x = odtDataSource.Columns.Count - 1 Then
    '                ColIndexFinal = x
    '                ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
    '            Else
    '                ColIndexFinal = x + 1
    '                ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

    '            End If
    '            If ValorCeldaNext = ValorCeldaActual Then
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '            Else
    '                PosFinalBreak = ColIndexInicial
    '                oListCeldaTitleIguales.Add(ColIndexInicial)
    '                IsBreak = True
    '            End If
    '            If IsBreak = True Then
    '                If oListCeldaTitleIguales.Count > 1 Then
    '                    'SI TIENE MAS DE 2 COLUMNAS IGUALES
    '                    For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
    '                        If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
    '                            row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
    '                        End If
    '                    Next
    '                    Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
    '                    objWorkSheet.AddMergedRegion(Region)
    '                Else
    '                    If Not oListNameDobleCabecera.Contains(NameColumna) Then
    '                        'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
    '                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
    '                        objWorkSheet.AddMergedRegion(Region)
    '                    End If
    '                End If
    '                PosInicioBreak = PosFinalBreak + 1
    '                oListCeldaTitleIguales = New List(Of Int32)
    '                IsBreak = False
    '            End If
    '        Next
    '        rowActual += 1
    '    End If
    '    rowActual += 1


    '    Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleWrap = style
    '    styleWrap.WrapText = True
    '    styleWrap.VerticalAlignment = VerticalAlignment.CENTER
    '    Dim IndexWrap As Int32 = 0
    '    Dim NombreColumna As String = ""

    '    Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    styleTexto = style
    '    styleTexto.WrapText = True

    '    Dim ValorNumero As Decimal = 0
    '    Dim NumMaxFilas As Int32 = 0
    '    Dim Datos() As String
    '    Const MaxLenDato As Int32 = 120
    '    Dim Tamanio As Int32 = 0
    '    Dim IsConTamanio As Boolean = False
    '    Dim TipoDato As String = ""
    '    Dim Fecha As Date
    '    For i As Integer = 0 To odtDataSource.Rows.Count - 1
    '        IndiceColum = 0
    '        NumMaxFilas = 1
    '        IsConTamanio = False
    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '            y = IndiceColum
    '            ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '            ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
    '            If (odtDataSource.Columns(j).ColumnName = "PCNMDC") Then
    '                ValorCelda = ValorCelda.Replace(Chr(13), Chr(10))
    '            End If
    '            CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            TipoDato = oHasDatosData(keyTipoDato)

    '            Select Case odtDataSource.Columns(j).ColumnName
    '                Case "PCNMDC"
    '                    Datos = ValorCelda.Split(Chr(10))
    '                    If (Datos.Length > NumMaxFilas) Then
    '                        NumMaxFilas = Datos.Length
    '                        For Each Item As String In Datos
    '                            If (Item.Length > MaxLenDato) Then
    '                                NumMaxFilas = NumMaxFilas + 1
    '                            End If
    '                        Next
    '                    End If
    '            End Select
    '            '---------------------------------------------------******************--------------

    '            Select Case TipoDato
    '                Case pTNumero
    '                    Decimal.TryParse(ValorCelda, ValorNumero)
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleNumber
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                Case pTTexto
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = style
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                Case pTFecha
    '                    If (Date.TryParse(ValorCelda, Fecha)) Then
    '                        ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                    Else
    '                        ValorCelda = ""
    '                    End If
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleFecha
    '                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '            End Select
    '            IndiceColum += 1
    '        Next

    '        Dim MaxShort As Short = 32767
    '        Dim TotalHeight As Int32 = 0
    '        For X As Int32 = rowActual - 1 To rowActual
    '            TotalHeight = 284 * NumMaxFilas
    '            If TotalHeight > MaxShort Then
    '                objWorkSheet.GetRow(X).Height = MaxShort
    '            Else
    '                objWorkSheet.GetRow(X).Height = TotalHeight
    '            End If
    '        Next
    '        rowActual += 1
    '    Next
    '    objWorkSheet.DefaultColumnWidth = 35
    '    objWorkSheet.DefaultRowHeightInPoints = 25
    '    For z As Integer = 0 To odtDataSource.Columns.Count - 1
    '        objWorkSheet.AutoSizeColumn(z, True)
    '    Next

    '    objWorkBook.Write(fs)
    '    fs.Close()
    '    HelpClass.AbrirDocumento(archivo)


    'End Sub


    'Public Sub ExportExcelResumenTipoCarga(ByVal dsDatos As DataSet, ByVal Titulo As String, ByVal numFilasResumen As Int32, ByVal ListTotalizables As List(Of String), Optional ByVal filtro As SortedList = Nothing)
    '    Dim odtDataSource As New DataTable
    '    Dim path As String = Application.StartupPath.ToString
    '    Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
    '    Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)

    '    Dim TableName As String = ""
    '    Dim TableDescripcion As String = ""
    '    '=====================================================================
    '    Dim objWorkBook As New HSSFWorkbook()
    '    Dim memoryStream As New MemoryStream()
    '    Dim objWorkSheet As New HSSFSheet(objWorkBook)

    '    For Each item As DataTable In dsDatos.Tables
    '        odtDataSource.Rows.Clear()
    '        odtDataSource = item.Copy

    '        '=============Stilos======================
    '        Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()


    '        Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        Dim styleMonto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '        Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        Dim styleNothing As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        Dim stylCentro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '        Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '        oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '        oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '        oFontFiltro.FontHeight = fontSizeFiltros


    '        Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '        oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '        oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '        oFontCab.FontHeight = fontSizeColumnaHeader

    '        Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '        oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '        oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '        oFont.FontHeight = fontSizeCelda


    '        Dim oFontCabPlomo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '        oFontCabPlomo.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '        oFontCabPlomo.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '        oFontCabPlomo.FontHeight = fontSizeCelda


    '        Dim GREY_25_PERCENT As Short = 22
    '        Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)
    '        Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera, Nothing, GREY_25_PERCENT)
    '        Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
    '        Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)
    '        Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
    '        Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)


    '        '============================================
    '        styleFiltro.SetFont(oFontFiltro)
    '        styleCab.SetFont(oFontCabPlomo)
    '        styleNormal.SetFont(oFont)
    '        styleTitulo.SetFont(oFontFiltro)
    '        styleNumber.SetFont(oFont)
    '        styleFecha.SetFont(oFont)

    '        '===================Se cargan Las Variables de Trabajo=====================
    '        Dim indice As Integer = 0
    '        Dim rowActual As Integer = 6
    '        Dim IndiceColum As Integer = 0
    '        Dim y As Integer = 0
    '        Dim intCantidadRows As Integer = 0
    '        Dim ValorCelda As String = ""
    '        intCantidadRows = odtDataSource.Rows.Count + 20

    '        TableName = odtDataSource.TableName.Split("/")(0)
    '        TableDescripcion = odtDataSource.TableName.Split("/")(1)

    '        objWorkSheet = objWorkBook.CreateSheet(TableDescripcion)
    '        Dim DobleCabecera As Boolean = False
    '        Dim CaptionColumna As String
    '        Dim Captions() As String
    '        Dim Cabeceras() As String

    '        Dim oHasDatosData As Hashtable
    '        Dim oListNameDobleCabecera As New List(Of String)
    '        Dim NameColumna As String = ""
    '        For Each dc As DataColumn In odtDataSource.Columns
    '            NameColumna = dc.ColumnName.Trim
    '            CaptionColumna = dc.Caption.Trim
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
    '            If (Captions.Length > 1) Then
    '                DobleCabecera = True
    '                oListNameDobleCabecera.Add(NameColumna)
    '            End If
    '        Next

    '        For s As Integer = 0 To (intCantidadRows)
    '            objWorkSheet.CreateRow(s)
    '        Next


    '        Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1
    '        '==============Verificamos Filtro a utilizar==================
    '        objWorkSheet.GetRow(2).CreateCell(3).CellStyle = styleTitulo
    '        objWorkSheet.GetRow(2).GetCell(3).SetCellValue(Titulo)
    '        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 3, 2, 10))


    '        If filtro Is Nothing Then
    '            rowActual = rowActual + 1
    '        Else
    '            Dim x As Integer = 0
    '            Dim ValCeldas() As String
    '            Dim DisplayTitle As String = ""
    '            Dim DipplayValue As String = ""
    '            For Each items As DictionaryEntry In filtro
    '                DisplayTitle = ""
    '                DipplayValue = ""
    '                ValCeldas = ("" & items.Value).ToString.Trim.Split("|")
    '                If ValCeldas.Length > 1 Then
    '                    DisplayTitle = ValCeldas(0).Trim
    '                    DipplayValue = ValCeldas(1).Trim
    '                End If
    '                x = x + 1
    '                DipplayValue = DisplayTitle & "  " & DipplayValue
    '                objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
    '                objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)

    '                objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 5))

    '            Next
    '            rowActual = rowActual + filtro.Count - 1
    '        End If
    '        Dim styleCenterCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        styleCenterCab = styleCab
    '        styleCenterCab.VerticalAlignment = VerticalAlignment.CENTER

    '        Dim tituloColumna As String = ""
    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '            y = IndiceColum
    '            CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            tituloColumna = oHasDatosData(keyTituloColumna)
    '            Cabeceras = tituloColumna.Split("|")

    '            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCenterCab



    '            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
    '            If (DobleCabecera = True) Then
    '                If (Cabeceras.Length > 1) Then
    '                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab


    '                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '                Else
    '                    objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCenterCab


    '                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
    '                End If
    '            End If
    '            IndiceColum += 1
    '        Next

    '        Dim row As New NPOI.HSSF.UserModel.HSSFRow
    '        row = objWorkSheet.GetRow(indice + rowActual - 1)
    '        Dim IsBreak As Boolean = False
    '        Dim PosInicioBreak As Int32 = 0
    '        Dim PosFinalBreak As Int32 = 0
    '        Dim ValorCeldaActual As String
    '        Dim ValorCeldaNext As String = ""
    '        Dim oListCeldaTitleIguales As New List(Of Int32)
    '        Dim ColIndexInicial As Int32 = 0
    '        Dim ColIndexFinal As Int32 = 0

    '        If DobleCabecera = True Then
    '            For x As Int32 = 0 To odtDataSource.Columns.Count - 1
    '                NameColumna = odtDataSource.Columns(x).ColumnName
    '                ColIndexInicial = x
    '                ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
    '                If x = odtDataSource.Columns.Count - 1 Then
    '                    ColIndexFinal = x
    '                    ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
    '                Else
    '                    ColIndexFinal = x + 1
    '                    ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

    '                End If
    '                If ValorCeldaNext = ValorCeldaActual Then
    '                    oListCeldaTitleIguales.Add(ColIndexInicial)
    '                Else
    '                    PosFinalBreak = ColIndexInicial
    '                    oListCeldaTitleIguales.Add(ColIndexInicial)
    '                    IsBreak = True
    '                End If
    '                If IsBreak = True Then
    '                    If oListCeldaTitleIguales.Count > 1 Then
    '                        'SI TIENE MAS DE 2 COLUMNAS IGUALES
    '                        For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
    '                            If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
    '                                row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
    '                            End If
    '                        Next
    '                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
    '                        objWorkSheet.AddMergedRegion(Region)
    '                    Else
    '                        If Not oListNameDobleCabecera.Contains(NameColumna) Then
    '                            'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
    '                            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
    '                            objWorkSheet.AddMergedRegion(Region)
    '                        End If
    '                    End If
    '                    PosInicioBreak = PosFinalBreak + 1
    '                    oListCeldaTitleIguales = New List(Of Int32)
    '                    IsBreak = False
    '                End If
    '            Next
    '            rowActual += 1
    '        End If
    '        rowActual += 1


    '        Dim styleWrap As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '        styleWrap = styleNormal
    '        styleWrap.WrapText = True
    '        styleWrap.VerticalAlignment = VerticalAlignment.CENTER
    '        Dim IndexWrap As Int32 = 0

    '        Select Case TableName
    '            Case "T1"

    '                Dim TipoDato As String = ""
    '                Dim Alineacion As String = ""
    '                Dim ValorNumero As Decimal = 0
    '                Dim Fecha As Date
    '                For i As Integer = 0 To odtDataSource.Rows.Count - 1
    '                    IndiceColum = 0

    '                    If i = odtDataSource.Columns.Count - 2 Then

    '                        Dim s As String = ""
    '                    End If

    '                    For j As Integer = 0 To odtDataSource.Columns.Count - 1

    '                        y = IndiceColum
    '                        ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '                        CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '                        oHasDatosData = DesFormatDato(CaptionColumna)
    '                        TipoDato = oHasDatosData(keyTipoDato)

    '                        Select Case TipoDato
    '                            Case pTNumero
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
    '                                If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
    '                                Else
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                                End If

    '                            Case pTTexto
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

    '                            Case pTFecha
    '                                If (Date.TryParse(ValorCelda, Fecha)) Then
    '                                    ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                                Else
    '                                    ValorCelda = ""
    '                                End If
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                        End Select


    '                        IndiceColum += 1
    '                    Next
    '                    rowActual += 1
    '                Next

    '            Case "T2"


    '                Dim COL1_KBRE_ACTUAL As String = ""
    '                Dim COL2_KBRE_ACTUAL As String = ""
    '                Dim COL1COL2_KBRE_ACTUAL As String = ""
    '                Dim COL1COL2COL3_KBRE_ACTUAL As String = ""
    '                Dim COL1COL2COL3COL4_KBRE_ACTUAL As String = ""
    '                Dim COL1COL2COL3COL4COL5_KBRE_ACTUAL As String = ""

    '                Dim COL1_KBRE_TEMP As String = ""
    '                Dim COL2_KBRE_TEMP As String = ""
    '                Dim COL3_KBRE_TEMP As String = ""
    '                Dim COL4_KBRE_TEMP As String = ""
    '                Dim COL5_KBRE_TEMP As String = ""


    '                Dim POS_TEMP_INICIO_COL1_KBRE As Int32 = indice - 1 + rowActual
    '                Dim POS_TEMP_FIN_COL1_KBRE As Int32 = 0

    '                Dim POS_TEMP_INICIO_COL2_KBRE As Int32 = indice - 1 + rowActual
    '                Dim POS_TEMP_FIN_COL2_KBRE As Int32 = 0

    '                Dim POS_TEMP_INICIO_COL3_KBRE As Int32 = indice - 1 + rowActual
    '                Dim POS_TEMP_FIN_COL3_KBRE As Int32 = 0

    '                Dim POS_TEMP_INICIO_COL4_KBRE As Int32 = indice - 1 + rowActual
    '                Dim POS_TEMP_FIN_COL4_KBRE As Int32 = 0

    '                Dim POS_TEMP_INICIO_COL5_KBRE As Int32 = indice - 1 + rowActual
    '                Dim POS_TEMP_FIN_COL5_KBRE As Int32 = 0

    '                Dim CAMBIO_COL2_KBRE As Boolean = False

    '                If (odtDataSource.Rows.Count > 0) Then
    '                    COL1_KBRE_TEMP = odtDataSource.Rows(0).Item("PAIS").ToString.Trim
    '                    COL2_KBRE_TEMP = odtDataSource.Rows(0).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(0).Item("PUERTO").ToString.Trim
    '                    COL3_KBRE_TEMP = odtDataSource.Rows(0).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(0).Item("PUERTO").ToString.Trim & "-" & odtDataSource.Rows(0).Item("FORWARDER").ToString.Trim
    '                    COL4_KBRE_TEMP = odtDataSource.Rows(0).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(0).Item("PUERTO").ToString.Trim & "-" & odtDataSource.Rows(0).Item("FORWARDER").ToString.Trim & "-" & odtDataSource.Rows(0).Item("TIPO_CARGA").ToString.Trim
    '                    COL5_KBRE_TEMP = odtDataSource.Rows(0).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(0).Item("PUERTO").ToString.Trim & "-" & odtDataSource.Rows(0).Item("FORWARDER").ToString.Trim & "-" & odtDataSource.Rows(0).Item("TIPO_CARGA").ToString.Trim & "-" & odtDataSource.Rows(0).Item("MERCADERIA").ToString.Trim
    '                End If

    '                Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                styleTexto = styleNormal
    '                styleTexto.WrapText = True


    '                Dim POS_FINAL_COL1_KBRE As Int32 = 0
    '                Dim POS_GRUPO_INICIO As Int32 = 0
    '                Dim POS_GRUPO_FIN As Int32 = 0
    '                Dim CAMBIAR_ALTO_FILA As Boolean = False
    '                Dim TipoDato As String = ""
    '                Dim ValorNumero As Decimal = 0
    '                Dim Fecha As Date

    '                Dim NumFilas As Int32 = odtDataSource.Rows.Count
    '                Dim MaxFilaNoResumen As Int32 = (NumFilas - 1) - numFilasResumen


    '                For i As Integer = 0 To MaxFilaNoResumen
    '                    IndiceColum = 0
    '                    For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '                        NameColumna = odtDataSource.Columns(j).ColumnName
    '                        y = IndiceColum
    '                        ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '                        CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '                        oHasDatosData = DesFormatDato(CaptionColumna)
    '                        TipoDato = oHasDatosData(keyTipoDato)

    '                        Select Case TipoDato
    '                            Case pTNumero
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
    '                                If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
    '                                Else
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                                End If

    '                            Case pTTexto

    '                                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

    '                            Case pTFecha
    '                                If (Date.TryParse(ValorCelda, Fecha)) Then
    '                                    ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                                Else
    '                                    ValorCelda = ""
    '                                End If
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
    '                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                        End Select

    '                        'KK()
    '                        If (NameColumna = "PAIS") Then
    '                            COL1_KBRE_ACTUAL = ("" & odtDataSource.Rows(i).Item("PAIS")).ToString.Trim

    '                            If (COL1_KBRE_ACTUAL <> COL1_KBRE_TEMP) Then

    '                                POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual) - 1
    '                                POS_FINAL_COL1_KBRE = (indice - 1 + rowActual) - 1
    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
    '                                POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
    '                                COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
    '                                objWorkSheet.AddMergedRegion(Region)

    '                            ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL1_KBRE_ACTUAL = COL1_KBRE_TEMP Then

    '                                POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual)
    '                                POS_FINAL_COL1_KBRE = (indice - 1 + rowActual)
    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
    '                                POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
    '                                COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
    '                                objWorkSheet.AddMergedRegion(Region)

    '                            End If
    '                        End If

    '                        If (NameColumna = "PUERTO") Then
    '                            COL1COL2_KBRE_ACTUAL = odtDataSource.Rows(i).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(i).Item("PUERTO").ToString.Trim
    '                            If (COL2_KBRE_TEMP <> COL1COL2_KBRE_ACTUAL) Then

    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL2_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual) - 1

    '                                POS_TEMP_FIN_COL2_KBRE = (indice - 1 + rowActual) - 1

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL2_KBRE, j, POS_TEMP_FIN_COL2_KBRE, j)
    '                                POS_TEMP_INICIO_COL2_KBRE = POS_TEMP_FIN_COL2_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL2_KBRE_TEMP = COL1COL2_KBRE_ACTUAL

    '                            ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL2_KBRE_TEMP = COL1COL2_KBRE_ACTUAL Then


    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL2_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual)
    '                                POS_TEMP_FIN_COL2_KBRE = (indice - 1 + rowActual)

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL2_KBRE, j, POS_TEMP_FIN_COL2_KBRE, j)
    '                                POS_TEMP_INICIO_COL2_KBRE = POS_TEMP_FIN_COL2_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL2_KBRE_TEMP = COL1COL2_KBRE_ACTUAL
    '                            End If
    '                        End If

    '                        If (NameColumna = "FORWARDER") Then
    '                            COL1COL2COL3_KBRE_ACTUAL = odtDataSource.Rows(i).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(i).Item("PUERTO").ToString.Trim & "-" & odtDataSource.Rows(i).Item("FORWARDER").ToString.Trim

    '                            If (COL3_KBRE_TEMP <> COL1COL2COL3_KBRE_ACTUAL) Then
    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL3_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual) - 1

    '                                POS_TEMP_FIN_COL3_KBRE = (indice - 1 + rowActual) - 1

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL3_KBRE, j, POS_TEMP_FIN_COL3_KBRE, j)
    '                                POS_TEMP_INICIO_COL3_KBRE = POS_TEMP_FIN_COL3_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL3_KBRE_TEMP = COL1COL2COL3_KBRE_ACTUAL

    '                            ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL3_KBRE_TEMP = COL1COL2COL3_KBRE_ACTUAL Then
    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL3_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual)
    '                                POS_TEMP_FIN_COL3_KBRE = (indice - 1 + rowActual)

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL3_KBRE, j, POS_TEMP_FIN_COL3_KBRE, j)
    '                                POS_TEMP_INICIO_COL3_KBRE = POS_TEMP_FIN_COL3_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL3_KBRE_TEMP = COL1COL2COL3_KBRE_ACTUAL
    '                            End If
    '                        End If


    '                        If (NameColumna = "TIPO_CARGA") Then
    '                            COL1COL2COL3COL4_KBRE_ACTUAL = odtDataSource.Rows(i).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(i).Item("PUERTO").ToString.Trim & "-" & odtDataSource.Rows(i).Item("FORWARDER").ToString.Trim & "-" & odtDataSource.Rows(i).Item("TIPO_CARGA").ToString.Trim

    '                            If (COL4_KBRE_TEMP <> COL1COL2COL3COL4_KBRE_ACTUAL) Then
    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL4_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual) - 1

    '                                POS_TEMP_FIN_COL4_KBRE = (indice - 1 + rowActual) - 1

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL4_KBRE, j, POS_TEMP_FIN_COL4_KBRE, j)
    '                                POS_TEMP_INICIO_COL4_KBRE = POS_TEMP_FIN_COL4_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL4_KBRE_TEMP = COL1COL2COL3COL4_KBRE_ACTUAL

    '                            ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL4_KBRE_TEMP = COL1COL2COL3COL4_KBRE_ACTUAL Then
    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL4_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual)
    '                                POS_TEMP_FIN_COL4_KBRE = (indice - 1 + rowActual)

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL4_KBRE, j, POS_TEMP_FIN_COL4_KBRE, j)
    '                                POS_TEMP_INICIO_COL4_KBRE = POS_TEMP_FIN_COL4_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL4_KBRE_TEMP = COL1COL2COL3COL4_KBRE_ACTUAL
    '                            End If
    '                        End If


    '                        If (NameColumna = "MERCADERIA") Then
    '                            COL1COL2COL3COL4COL5_KBRE_ACTUAL = odtDataSource.Rows(i).Item("PAIS").ToString.Trim & "-" & odtDataSource.Rows(i).Item("PUERTO").ToString.Trim & "-" & odtDataSource.Rows(i).Item("FORWARDER").ToString.Trim & "-" & odtDataSource.Rows(i).Item("TIPO_CARGA").ToString.Trim & "-" & odtDataSource.Rows(i).Item("MERCADERIA").ToString.Trim

    '                            If (COL5_KBRE_TEMP <> COL1COL2COL3COL4COL5_KBRE_ACTUAL) Then
    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL5_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual) - 1

    '                                POS_TEMP_FIN_COL5_KBRE = (indice - 1 + rowActual) - 1

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL5_KBRE, j, POS_TEMP_FIN_COL5_KBRE, j)
    '                                POS_TEMP_INICIO_COL5_KBRE = POS_TEMP_FIN_COL5_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL5_KBRE_TEMP = COL1COL2COL3COL4COL5_KBRE_ACTUAL

    '                            ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL3_KBRE_TEMP = COL1COL2COL3COL4COL5_KBRE_ACTUAL Then
    '                                POS_GRUPO_INICIO = POS_TEMP_INICIO_COL5_KBRE
    '                                POS_GRUPO_FIN = (indice - 1 + rowActual)
    '                                POS_TEMP_FIN_COL5_KBRE = (indice - 1 + rowActual)

    '                                Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL5_KBRE, j, POS_TEMP_FIN_COL5_KBRE, j)
    '                                POS_TEMP_INICIO_COL5_KBRE = POS_TEMP_FIN_COL5_KBRE + 1
    '                                objWorkSheet.AddMergedRegion(Region)
    '                                COL5_KBRE_TEMP = COL1COL2COL3COL4COL5_KBRE_ACTUAL
    '                            End If
    '                        End If

    '                        IndiceColum += 1
    '                    Next

    '                    rowActual += 1
    '                Next
    '                rowActual += 1

    '                If numFilasResumen > 0 Then
    '                    For i As Integer = MaxFilaNoResumen + 1 To NumFilas - 1
    '                        IndiceColum = 0
    '                        For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '                            NameColumna = odtDataSource.Columns(j).ColumnName
    '                            y = IndiceColum
    '                            ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '                            CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '                            oHasDatosData = DesFormatDato(CaptionColumna)
    '                            TipoDato = oHasDatosData(keyTipoDato)


    '                            If ListTotalizables.Contains(NameColumna) Then

    '                                Select Case TipoDato
    '                                    Case pTNumero
    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
    '                                        If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
    '                                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
    '                                        Else
    '                                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                                        End If
    '                                    Case pTTexto

    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

    '                                    Case pTFecha
    '                                        If (Date.TryParse(ValorCelda, Fecha)) Then
    '                                            ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
    '                                        Else
    '                                            ValorCelda = ""
    '                                        End If
    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
    '                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                                End Select

    '                            End If
    '                            IndiceColum += 1
    '                        Next
    '                        rowActual += 1
    '                    Next
    '                End If
    '        End Select
    '        objWorkSheet.DefaultColumnWidth = 35
    '        objWorkSheet.DefaultRowHeightInPoints = 25
    '        For z As Integer = 0 To odtDataSource.Columns.Count - 1
    '            objWorkSheet.AutoSizeColumn(z, True)
    '        Next

    '        Dim patriarch As HSSFPatriarch = DirectCast(objWorkSheet.CreateDrawingPatriarch(), HSSFPatriarch)
    '        Dim anchor As HSSFClientAnchor
    '        anchor = New HSSFClientAnchor(0, 0, 0, 80, 0, 0, 0, 0)
    '        Dim rutaLogo As String = Application.StartupPath & "\Resources\logo_ransas.jpg"
    '        If IO.File.Exists(rutaLogo) Then
    '            'load the picture and get the picture index in the workbook
    '            Dim picture As HSSFPicture = DirectCast(patriarch.CreatePicture(anchor, LoadImage(rutaLogo, objWorkBook)), HSSFPicture)
    '            'Reset the image to the original size.
    '            picture.Resize(0.5)
    '        End If
    '    Next
    '    objWorkBook.Write(fs)
    '    fs.Close()
    '    HelpClass.AbrirDocumento(archivo)

    'End Sub


    'Public Sub ExportExcelGeneralReleaseMultiple(ByVal odtListDataSource As List(Of DataTable), ByVal ListTitulo As List(Of String), ByVal ListColNameNFilas As List(Of String), Optional ByVal ListFiltro As List(Of SortedList) = Nothing, Optional ByVal ListNameDelFilDuplic As List(Of String) = Nothing, Optional ByVal FormatoCabecera As Int32 = 0, Optional ByVal ListNameCombDuplicado As List(Of String) = Nothing)

    '    Dim path As String = Application.StartupPath.ToString
    '    Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
    '    Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)



    '    '=====================================================================
    '    Dim objWorkBook As New HSSFWorkbook()
    '    Dim memoryStream As New MemoryStream()
    '    Dim objWorkSheet As New HSSFSheet(objWorkBook)
    '    '=============Stilos======================
    '    Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '    Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '    Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

    '    Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '    oFontFiltro.FontHeight = fontSizeFiltros

    '    Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    Select Case FormatoCabecera
    '        Case 0
    '            oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
    '            oFontCab.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '            oFontCab.FontHeight = fontSizeColumnaHeader

    '            Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
    '        Case 1
    '            oFontCab.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '            oFontCab.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '            oFontCab.FontHeight = fontSizeCelda

    '            Dim GREY_25_PERCENT As Short = 22
    '            Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera, Nothing, GREY_25_PERCENT)
    '    End Select

    '    '************************************

    '    Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '    oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
    '    oFont.FontHeight = fontSizeCelda


    '    Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)


    '    Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

    '    Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
    '    Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
    '    Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)
    '    Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)

    '    '============================================
    '    styleFiltro.SetFont(oFontFiltro)
    '    styleCab.SetFont(oFontCab)
    '    styleTitulo.SetFont(oFontFiltro)

    '    styleNormal.SetFont(oFont)
    '    styleNumber.SetFont(oFont)
    '    styleFecha.SetFont(oFont)
    '    styleTexto.SetFont(oFont)

    '    '===================Se cargan Las Variables de Trabajo=====================
    '    Dim odtDataSource As New DataTable

    '    For FilaTable As Integer = 0 To odtListDataSource.Count - 1
    '        odtDataSource = odtListDataSource(FilaTable).Copy

    '        Dim indice As Integer = 0
    '        Dim rowActual As Integer = 6
    '        Dim IndiceColum As Integer = 0
    '        Dim y As Integer = 0
    '        Dim intCantidadRows As Integer = 0
    '        Dim intColumObs As Integer = 0
    '        Dim lstrTempColum As New Hashtable
    '        intCantidadRows = odtDataSource.Rows.Count + 20

    '        Dim NameHoja As String = ""
    '        If odtDataSource.TableName.Trim.Length = 0 Then
    '            NameHoja = "Hoja" & (FilaTable + 1).ToString.PadLeft(2, "0")
    '        Else
    '            NameHoja = odtDataSource.TableName
    '        End If
    '        objWorkSheet = objWorkBook.CreateSheet(NameHoja)


    '        Dim DobleCabecera As Boolean = False
    '        Dim CaptionColumna As String
    '        Dim Captions() As String
    '        Dim Cabeceras() As String

    '        Dim oHasDatosData As Hashtable
    '        Dim oListColDobleCabecera As New List(Of String)
    '        Dim NameColumna As String = ""

    '        Dim dtFilasFormato As New DataTable
    '        dtFilasFormato = Formatear_GetFormatoFila(odtDataSource)

    '        For Each dc As DataColumn In odtDataSource.Columns
    '            NameColumna = dc.ColumnName.Trim
    '            CaptionColumna = dc.Caption.Trim
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
    '            If (Captions.Length > 1) Then
    '                DobleCabecera = True
    '                oListColDobleCabecera.Add(NameColumna)
    '            End If
    '        Next

    '        For s As Integer = 0 To (intCantidadRows)
    '            objWorkSheet.CreateRow(s)
    '        Next
    '        Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1
    '        '==============Verificamos Filtro a utilizar==================
    '        objWorkSheet.GetRow(2).CreateCell(1).CellStyle = styleTitulo
    '        If ListTitulo IsNot Nothing AndAlso (ListTitulo.Count - 1) >= FilaTable Then
    '            objWorkSheet.GetRow(2).GetCell(1).SetCellValue(ListTitulo(FilaTable))
    '        Else
    '            objWorkSheet.GetRow(2).GetCell(1).SetCellValue("")
    '        End If
    '        objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 1, 2, odtDataSource.Columns.Count - 1))


    '        If ListFiltro Is Nothing AndAlso ListFiltro.Count = 0 Then
    '            rowActual = rowActual + 1
    '        ElseIf ListFiltro IsNot Nothing AndAlso ((ListFiltro.Count - 1) >= FilaTable) Then
    '            Dim x As Integer = 0
    '            Dim ValCeldas() As String
    '            Dim DisplayTitle As String = ""
    '            Dim DipplayValue As String = ""
    '            For Each items As DictionaryEntry In ListFiltro(FilaTable)
    '                DisplayTitle = ""
    '                DipplayValue = ""
    '                ValCeldas = ("" & items.Value).ToString.Split("|")
    '                If ValCeldas.Length > 1 Then
    '                    DisplayTitle = ValCeldas(0)
    '                    DipplayValue = ValCeldas(1)
    '                End If
    '                x = x + 1
    '                DipplayValue = DisplayTitle & "  " & DipplayValue
    '                objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
    '                objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)
    '                objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 3))
    '            Next
    '            rowActual = rowActual + ListFiltro(FilaTable).Count - 1
    '        End If

    '        Dim ValorCelda As String = ""
    '        Dim tituloColumna As String = ""
    '        Dim NumMaxFilasTitulo As Int32 = 0
    '        Dim DatosTitulo() As String
    '        Dim MaxShortTitulo As Short = 32767
    '        Dim TotalHeightTitulo As Int32 = 0
    '        Dim ColorFondoCab As String = ""
    '        Dim ColorLetraCab As String = ""
    '        Dim ColorFondo As String = ""
    '        Dim ColorLetra As String = ""
    '        Dim ColorIndex As String = ""
    '        Dim oHasFormatoFila As New Hashtable
    '        Dim ValCelda As String = ""


    '        For j As Integer = 0 To odtDataSource.Columns.Count - 1

    '            y = IndiceColum
    '            CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
    '            oHasDatosData = DesFormatDato(CaptionColumna)
    '            tituloColumna = oHasDatosData(keyTituloColumna)

    '            ColorFondoCab = oHasDatosData(keyColorFondo)
    '            ColorLetraCab = oHasDatosData(keyColorLetra)

    '            Cabeceras = tituloColumna.Split("|")

    '            If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
    '                Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

    '                Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '                oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
    '                oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '                oFontCabTemp.FontHeight = fontSizeColumnaHeader
    '                styleCabTemp.SetFont(oFontCabTemp)
    '                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '            Else
    '                objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCab
    '            End If
    '            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))

    '            '***AMPLIAR EL TAMANIO DEL TITULO DE LA COLUMNA 
    '            NumMaxFilasTitulo = 1
    '            DatosTitulo = Cabeceras(0).Split(Chr(10))
    '            If (DatosTitulo.Length > NumMaxFilasTitulo) Then
    '                NumMaxFilasTitulo = DatosTitulo.Length
    '            End If
    '            If NumMaxFilasTitulo > 1 Then
    '                For X As Int32 = rowActual - 1 To rowActual
    '                    TotalHeightTitulo = 284 * NumMaxFilasTitulo
    '                    If TotalHeightTitulo > MaxShortTitulo Then
    '                        objWorkSheet.GetRow(X).Height = MaxShortTitulo
    '                    Else
    '                        objWorkSheet.GetRow(X).Height = TotalHeightTitulo
    '                    End If
    '                Next
    '            End If
    '            '*************************************
    '            If (DobleCabecera = True) Then
    '                If (Cabeceras.Length > 1) Then

    '                    If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
    '                        Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                        Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

    '                        Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '                        oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
    '                        oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '                        oFontCabTemp.FontHeight = fontSizeColumnaHeader
    '                        styleCabTemp.SetFont(oFontCabTemp)
    '                        objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '                    Else
    '                        objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
    '                    End If
    '                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue(Cabeceras(1))
    '                Else

    '                    If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
    '                        Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                        Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

    '                        Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
    '                        oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
    '                        oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
    '                        oFontCabTemp.FontHeight = fontSizeColumnaHeader
    '                        styleCabTemp.SetFont(oFontCabTemp)
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y).CellStyle = styleCabTemp
    '                    Else
    '                        objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
    '                    End If
    '                    objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
    '                End If
    '            End If
    '            IndiceColum += 1
    '        Next



    '        '********************fin copia***********************

    '        Dim row As New NPOI.HSSF.UserModel.HSSFRow
    '        row = objWorkSheet.GetRow(indice + rowActual - 1)
    '        Dim IsBreak As Boolean = False
    '        Dim PosInicioBreak As Int32 = 0
    '        Dim PosFinalBreak As Int32 = 0
    '        Dim ValorCeldaActual As String
    '        Dim ValorCeldaNext As String = ""
    '        Dim oListCeldaTitleIguales As New List(Of Int32)
    '        Dim ColIndexInicial As Int32 = 0
    '        Dim ColIndexFinal As Int32 = 0

    '        If DobleCabecera = True Then
    '            For x As Int32 = 0 To odtDataSource.Columns.Count - 1
    '                NameColumna = odtDataSource.Columns(x).ColumnName
    '                ColIndexInicial = x
    '                ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
    '                If x = odtDataSource.Columns.Count - 1 Then
    '                    ColIndexFinal = x
    '                    ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
    '                Else
    '                    ColIndexFinal = x + 1
    '                    ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

    '                End If
    '                If ValorCeldaNext = ValorCeldaActual Then
    '                    oListCeldaTitleIguales.Add(ColIndexInicial)
    '                Else
    '                    PosFinalBreak = ColIndexInicial
    '                    oListCeldaTitleIguales.Add(ColIndexInicial)
    '                    IsBreak = True
    '                End If
    '                If IsBreak = True Then
    '                    If oListCeldaTitleIguales.Count > 1 Then
    '                        'SI TIENE MAS DE 2 COLUMNAS IGUALES
    '                        For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
    '                            If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
    '                                row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
    '                            End If
    '                        Next
    '                        Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
    '                        objWorkSheet.AddMergedRegion(Region)
    '                    Else
    '                        If Not oListColDobleCabecera.Contains(NameColumna) Then
    '                            'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
    '                            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
    '                            objWorkSheet.AddMergedRegion(Region)
    '                        End If
    '                    End If
    '                    PosInicioBreak = PosFinalBreak + 1
    '                    oListCeldaTitleIguales = New List(Of Int32)
    '                    IsBreak = False
    '                End If
    '            Next
    '            rowActual += 1
    '        End If
    '        rowActual += 1

    '        Dim ValorNumero As Decimal = 0
    '        Dim NumMaxFilas As Int32 = 0
    '        Dim Datos() As String
    '        Const MaxLenDato As Int32 = 120
    '        Dim Tamanio As Int32 = 0
    '        Dim IsConTamanio As Boolean = False
    '        Dim TipoDato As String = ""

    '        Dim EsVariasFilas As Boolean = False

    '        Dim ListaColNameNFilas As New List(Of String)
    '        If ListColNameNFilas IsNot Nothing AndAlso (ListColNameNFilas.Count - 1) >= FilaTable AndAlso ListColNameNFilas(FilaTable) <> "" Then
    '            For Each Item As String In ListColNameNFilas(FilaTable).Split(pNFilas)
    '                ListaColNameNFilas.Add(Item)
    '            Next
    '        End If

    '        Dim COL1_KBRE_ACTUAL As String = ""
    '        Dim COL1_KBRE_TEMP As String = ""
    '        Dim POS_TEMP_INICIO_COL1_KBRE As Int32 = indice - 1 + rowActual
    '        Dim POS_TEMP_FIN_COL1_KBRE As Int32 = 0


    '        Dim oHasListFilasCombinar As New Hashtable
    '        Dim oHasVarComb As New Hashtable
    '        Dim filasComb() As String
    '        Dim ColumnaKey() As String
    '        filasComb = ListNameCombDuplicado(FilaTable).Split("|")
    '        For Each Item As String In filasComb
    '            ColumnaKey = Item.Split(":")
    '            oHasListFilasCombinar.Add(ColumnaKey(0), ColumnaKey(1))
    '        Next

    '        '  Dim COL1COL2COL3COL4COL5_KBRE_ACTUAL As String = ""
    '        Dim COL_ALLKEYS_KBRE_ACTUAL As String = ""
    '        Dim col_comb() As String
    '        Dim comb As String = ""
    '        For Each item As DictionaryEntry In oHasListFilasCombinar
    '            col_comb = item.Value.ToString.Split(",")

    '            For Each Item1 As String In CollectionObject

    '            Next


    '            COL_ALLKEYS_KBRE_ACTUAL = "COL"


    '        Next







    '        If (ListNameDelFilDuplic IsNot Nothing AndAlso ((ListNameDelFilDuplic.Count - 1) >= FilaTable) AndAlso ListNameDelFilDuplic(FilaTable).Trim <> "" AndAlso odtDataSource.Columns(ListNameDelFilDuplic(FilaTable)) IsNot Nothing AndAlso odtDataSource.Rows.Count > 0) Then
    '            COL1_KBRE_TEMP = odtDataSource.Rows(0).Item(ListNameDelFilDuplic(FilaTable)).ToString.Trim
    '        End If

    '        Dim POS_FINAL_COL1_KBRE As Int32 = 0

    '        Dim numFilasActual As Int32 = 0
    '        For i As Integer = 0 To odtDataSource.Rows.Count - 1
    '            IndiceColum = 0
    '            NumMaxFilas = 1
    '            IsConTamanio = False

    '            oHasFormatoFila = DesFormatoFila(dtFilasFormato.Rows(i)(keyNameColFormatoFila))
    '            ColorIndex = oHasFormatoFila(keyColorFondo)

    '            EsVariasFilas = False
    '            numFilasActual = 1
    '            For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '                ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '                ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
    '                CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '                NameColumna = odtDataSource.Columns(j).ColumnName

    '                If ListaColNameNFilas.Contains(NameColumna) Then
    '                    '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
    '                    '// AUMENTANDO 
    '                    Datos = ValorCelda.Split(Chr(10))
    '                    If (Datos.Length > NumMaxFilas) Then
    '                        NumMaxFilas = Datos.Length
    '                        For Each Item As String In Datos
    '                            If (Item.Length > MaxLenDato) Then
    '                                NumMaxFilas = NumMaxFilas + 1
    '                            End If
    '                        Next
    '                    End If
    '                End If
    '            Next


    '            For j As Integer = 0 To odtDataSource.Columns.Count - 1
    '                y = IndiceColum
    '                ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
    '                ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
    '                CaptionColumna = odtDataSource.Columns(j).Caption.Trim
    '                NameColumna = odtDataSource.Columns(j).ColumnName
    '                oHasDatosData = DesFormatDato(CaptionColumna)
    '                TipoDato = oHasDatosData(keyTipoDato)

    '                'EsVariasFilas = False
    '                'If ListaColNameNFilas.Contains(NameColumna) Then
    '                '    '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
    '                '    '// AUMENTANDO 
    '                '    Datos = ValorCelda.Split(Chr(10))
    '                '    If (Datos.Length > NumMaxFilas) Then
    '                '        NumMaxFilas = Datos.Length
    '                '        For Each Item As String In Datos
    '                '            If (Item.Length > MaxLenDato) Then
    '                '                NumMaxFilas = NumMaxFilas + 1
    '                '            End If
    '                '        Next
    '                '    End If
    '                '    '//(TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO TEXTTO
    '                '    '//TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO NORMAL 
    '                '    If NumMaxFilas > 1 Then
    '                '        EsVariasFilas = True
    '                '    Else
    '                '        EsVariasFilas = False
    '                '    End If

    '                'End If

    '                If ListaColNameNFilas.Contains(NameColumna) Then
    '                    '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
    '                    '// AUMENTANDO 
    '                    Datos = ValorCelda.Split(Chr(10))
    '                    If (Datos.Length > numFilasActual) Then
    '                        numFilasActual = Datos.Length
    '                        For Each Item As String In Datos
    '                            If (Item.Length > MaxLenDato) Then
    '                                numFilasActual = numFilasActual + 1
    '                            End If
    '                        Next
    '                    End If
    '                    '//(TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO TEXTTO
    '                    '//TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO NORMAL 
    '                    If numFilasActual > 1 Then
    '                        EsVariasFilas = True
    '                    Else
    '                        EsVariasFilas = False
    '                    End If
    '                End If



    '                Select Case TipoDato
    '                    Case pTNumero
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                        If ColorIndex <> "" Then
    '                            Dim styleNumber_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                            Estilos_Excel_NPOI(styleNumber_Temp, TipoEstilo.Numero, Nothing, ColorIndex)
    '                            styleNumber_Temp.SetFont(oFont)
    '                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber_Temp
    '                        Else
    '                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
    '                        End If
    '                        If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
    '                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
    '                        Else
    '                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
    '                        End If
    '                    Case pTTexto
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                        Select Case EsVariasFilas
    '                            Case True
    '                                If ColorIndex <> "" Then
    '                                    Dim styleNormal_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                                    Estilos_Excel_NPOI(styleNormal_Temp, TipoEstilo.Normal, Nothing, ColorIndex)
    '                                    styleNormal_Temp.SetFont(oFont)
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal_Temp
    '                                Else
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
    '                                End If
    '                            Case False
    '                                If ColorIndex <> "" Then
    '                                    Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                                    Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Texto, Nothing, ColorIndex)
    '                                    styleTexto_Temp.SetFont(oFont)
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto_Temp
    '                                Else
    '                                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
    '                                End If
    '                        End Select
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

    '                        If (IsConTamanio = True) Then
    '                            objWorkSheet.SetColumnWidth(y, Tamanio)
    '                        End If
    '                    Case pTFecha
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
    '                        If ColorIndex <> "" Then
    '                            Dim styleFecha_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
    '                            Estilos_Excel_NPOI(styleFecha_Temp, TipoEstilo.Fecha, Nothing, ColorIndex)
    '                            styleFecha_Temp.SetFont(oFont)
    '                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha_Temp
    '                        Else
    '                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
    '                        End If
    '                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)
    '                End Select

    '                If (ListNameDelFilDuplic IsNot Nothing AndAlso ((ListNameDelFilDuplic.Count - 1) >= FilaTable) AndAlso ListNameDelFilDuplic(FilaTable) <> "" AndAlso odtDataSource.Columns(ListNameDelFilDuplic(FilaTable)) IsNot Nothing AndAlso NameColumna = ListNameDelFilDuplic(FilaTable)) Then
    '                    COL1_KBRE_ACTUAL = ("" & odtDataSource.Rows(i).Item(ListNameDelFilDuplic(FilaTable))).ToString.Trim

    '                    If (COL1_KBRE_ACTUAL <> COL1_KBRE_TEMP) Then

    '                        POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual) - 1
    '                        POS_FINAL_COL1_KBRE = (indice - 1 + rowActual) - 1
    '                        Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
    '                        POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
    '                        COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
    '                        objWorkSheet.AddMergedRegion(Region)

    '                    ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL1_KBRE_ACTUAL = COL1_KBRE_TEMP Then

    '                        POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual)
    '                        POS_FINAL_COL1_KBRE = (indice - 1 + rowActual)
    '                        Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
    '                        POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
    '                        COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
    '                        objWorkSheet.AddMergedRegion(Region)

    '                    End If
    '                End If


    '                IndiceColum += 1
    '            Next

    '            Dim MaxShort As Short = 32767
    '            Dim TotalHeight As Int32 = 0
    '            If NumMaxFilas > 1 Then
    '                For X As Int32 = rowActual - 1 To rowActual - 1
    '                    TotalHeight = 284 * NumMaxFilas
    '                    If TotalHeight > MaxShort Then
    '                        objWorkSheet.GetRow(X).Height = MaxShort
    '                    Else
    '                        objWorkSheet.GetRow(X).Height = TotalHeight
    '                    End If
    '                Next
    '            End If
    '            rowActual += 1
    '        Next

    '        objWorkSheet.DefaultColumnWidth = 35
    '        objWorkSheet.DefaultRowHeightInPoints = 25
    '        For z As Integer = 0 To odtDataSource.Columns.Count - 1
    '            objWorkSheet.AutoSizeColumn(z, True)
    '        Next

    '        Dim patriarch As HSSFPatriarch = DirectCast(objWorkSheet.CreateDrawingPatriarch(), HSSFPatriarch)
    '        Dim anchor As HSSFClientAnchor
    '        anchor = New HSSFClientAnchor(0, 0, 0, 80, 0, 0, 0, 0)
    '        Dim rutaLogo As String = Application.StartupPath & "\Resources\logo_ransas.jpg"
    '        If IO.File.Exists(rutaLogo) Then
    '            'load the picture and get the picture index in the workbook
    '            Dim picture As HSSFPicture = DirectCast(patriarch.CreatePicture(anchor, LoadImage(rutaLogo, objWorkBook)), HSSFPicture)
    '            'Reset the image to the original size.
    '            picture.Resize(0.5)
    '        End If


    '    Next




    '    objWorkBook.Write(fs)
    '    fs.Close()
    '    HelpClass.AbrirDocumento(archivo)

    'End Sub


    'Public Sub ExportExcelGeneralReleaseMultiple(ByVal odtListDataSource As List(Of DataTable), ByVal ListTitulo As List(Of String), ByVal ListColNameNFilas As List(Of String), Optional ByVal ListFiltro As List(Of SortedList) = Nothing, Optional ByVal ListNameDelFilDuplic As String = Nothing, Optional ByVal FormatoCabecera As Int32 = 0, Optional ByVal ListNameCombDuplicado As List(Of String) = Nothing)

    Private Shared Function LetraNumero_NPOI(ByVal i As Integer) As String
        i = i - 1
        Dim AbcD As New Hashtable()
        AbcD.Add(0, "A")
        AbcD.Add(1, "B")
        AbcD.Add(2, "C")
        AbcD.Add(3, "D")
        AbcD.Add(4, "E")
        AbcD.Add(5, "F")
        AbcD.Add(6, "G")
        AbcD.Add(7, "H")
        AbcD.Add(8, "I")
        AbcD.Add(9, "J")
        AbcD.Add(10, "K")
        AbcD.Add(11, "L")
        AbcD.Add(12, "M")
        AbcD.Add(13, "N")
        AbcD.Add(14, "O")
        AbcD.Add(15, "P")
        AbcD.Add(16, "Q")
        AbcD.Add(17, "R")
        AbcD.Add(18, "S")
        AbcD.Add(19, "T")
        AbcD.Add(20, "U")
        AbcD.Add(21, "V")
        AbcD.Add(22, "W")
        AbcD.Add(23, "X")
        AbcD.Add(24, "Y")
        AbcD.Add(25, "Z")
        If i > 25 Then
            Dim intX, intY As Integer
            intX = Math.Floor(i / 26)
            intY = i - intX * 26
            Return AbcD(intX - 1).ToString + AbcD(intY).ToString
        Else
            Return AbcD(i).ToString
        End If
    End Function

    Public Sub ExportExcelGeneralReleaseMultiple(ByVal odtListDataSource As List(Of DataTable), ByVal ListTitulo As List(Of String), ByVal ListCeldaColNameNFilas As List(Of String), Optional ByVal ListFiltro As List(Of SortedList) = Nothing, Optional ByVal FormatoCabecera As Int32 = 0, Optional ByVal ListNameCombDuplicado As List(Of String) = Nothing, Optional ByVal ListSumarColumna As List(Of String) = Nothing, Optional ByVal ColumnaAgrupacionFilaMax As List(Of String) = Nothing)

        Dim path As String = Application.StartupPath.ToString
        Dim archivo As String = "Reporte" & HelpClass.NowNumeric & ".xls"
        Dim fs As New IO.FileStream(archivo, IO.FileMode.Create)



        '=====================================================================
        Dim objWorkBook As New HSSFWorkbook()
        Dim memoryStream As New MemoryStream()
        Dim objWorkSheet As New HSSFSheet(objWorkBook)
        '=============Stilos======================
        Dim styleFiltro As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleCab As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTitulo As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

        Dim styleNormal As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleNumber As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()

        Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontFiltro.FontHeight = fontSizeFiltros


        Dim oFontTitulo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontTitulo.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
        oFontTitulo.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontTitulo.FontHeight = fontSizeFiltros


        Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        Select Case FormatoCabecera
            Case 0
                oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
                oFontCab.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                oFontCab.FontHeight = fontSizeColumnaHeader

                Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera)
            Case 1
                oFontCab.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
                oFontCab.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                oFontCab.FontHeight = fontSizeCelda

                Dim GREY_25_PERCENT As Short = 22
                Estilos_Excel_NPOI(styleCab, TipoEstilo.Cabecera, Nothing, GREY_25_PERCENT)
        End Select

        '************************************

        Dim oFont As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFont.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFont.FontHeight = fontSizeCelda


        Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)


        Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

        Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
        Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
        Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)
        Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)

        '============================================
        styleFiltro.SetFont(oFontFiltro)
        styleCab.SetFont(oFontCab)
        'styleTitulo.SetFont(oFontFiltro)
        styleTitulo.SetFont(oFontTitulo)


        styleNormal.SetFont(oFont)
        styleNumber.SetFont(oFont)
        styleFecha.SetFont(oFont)
        styleTexto.SetFont(oFont)

        '===================Se cargan Las Variables de Trabajo=====================
        Dim odtDataSource As New DataTable
        Dim HasPosicionHojaColumna As Hashtable
        Dim ListColumnasSumar As Hashtable
        Dim POS_INICIO_REGISTRO As Int64 = 0
        Dim POS_FINAL_REGISTRO As Int64 = 0
        Dim HasPosicionFilaColCabecera As Hashtable
        'Dim List_FilasTituloxColumna As List(Of String)
        For FilaTable As Integer = 0 To odtListDataSource.Count - 1
            HasPosicionHojaColumna = New Hashtable
            ListColumnasSumar = New Hashtable
            HasPosicionFilaColCabecera = New Hashtable
            odtDataSource = odtListDataSource(FilaTable).Copy

            If ListSumarColumna IsNot Nothing AndAlso (ListSumarColumna.Count - 1) >= FilaTable AndAlso ListSumarColumna(FilaTable) <> "" Then
                Dim columnasSumar() As String
                columnasSumar = ListSumarColumna(FilaTable).Split("|")
                For Each Item As String In columnasSumar
                    ListColumnasSumar.Add(odtDataSource.Columns(Item).ColumnName, Item)
                Next
            End If


            Dim indice As Integer = 0
            'Dim rowActual As Integer = 6
            Dim rowActual As Integer = 7
            Dim IndiceColum As Integer = 0
            Dim y As Integer = 0
            Dim intCantidadRows As Integer = 0
            Dim intColumObs As Integer = 0
            Dim lstrTempColum As New Hashtable
            intCantidadRows = odtDataSource.Rows.Count + 20

            Dim NameHoja As String = ""
            If odtDataSource.TableName.Trim.Length = 0 Then
                NameHoja = "Hoja" & (FilaTable + 1).ToString.PadLeft(2, "0")
            Else
                NameHoja = odtDataSource.TableName
            End If
            objWorkSheet = objWorkBook.CreateSheet(NameHoja)


            Dim MultipleCabecera As Boolean = False
            Dim CaptionColumna As String
            Dim Captions() As String
            Dim Cabeceras() As String

            Dim oHasDatosData As Hashtable
            Dim oListColMultipleCabecera As New List(Of String)
            Dim NameColumna As String = ""

            Dim dtFilasFormato As New DataTable
            dtFilasFormato = Formatear_GetFormatoFila(odtDataSource)

            Dim MaxTotalCab As Int32 = 1
            For Each dc As DataColumn In odtDataSource.Columns
                NameColumna = dc.ColumnName.Trim
                CaptionColumna = dc.Caption.Trim
                oHasDatosData = DesFormatDato(CaptionColumna)
                Captions = oHasDatosData(keyTituloColumna).ToString.Split("|")
                If (Captions.Length > 1) Then
                    MultipleCabecera = True
                    oListColMultipleCabecera.Add(NameColumna)

                    If Captions.Length > MaxTotalCab Then
                        MaxTotalCab = Captions.Length
                    End If

                End If
            Next

            For s As Integer = 0 To (intCantidadRows)
                objWorkSheet.CreateRow(s)
            Next
            Dim numColumnas As Int32 = odtDataSource.Columns.Count - 1
            '==============Verificamos Filtro a utilizar==================
            'objWorkSheet.GetRow(2).CreateCell(1).CellStyle = styleTitulo
            'If ListTitulo IsNot Nothing AndAlso (ListTitulo.Count - 1) >= FilaTable Then
            '    objWorkSheet.GetRow(2).GetCell(1).SetCellValue(ListTitulo(FilaTable))
            'Else
            '    objWorkSheet.GetRow(2).GetCell(1).SetCellValue("")
            'End If
            'objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 1, 2, odtDataSource.Columns.Count - 1))

            'objWorkSheet.GetRow(3).CreateCell(1).CellStyle = styleTitulo
            'If ListTitulo IsNot Nothing AndAlso (ListTitulo.Count - 1) >= FilaTable Then
            '    objWorkSheet.GetRow(3).GetCell(1).SetCellValue(ListTitulo(FilaTable))
            'Else
            '    objWorkSheet.GetRow(3).GetCell(1).SetCellValue("")
            'End If
            'objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(3, 1, 3, odtDataSource.Columns.Count - 1))

            objWorkSheet.GetRow(3).CreateCell(0).CellStyle = styleTitulo
            If ListTitulo IsNot Nothing AndAlso (ListTitulo.Count - 1) >= FilaTable Then
                objWorkSheet.GetRow(3).GetCell(0).SetCellValue(ListTitulo(FilaTable))
            Else
                objWorkSheet.GetRow(3).GetCell(0).SetCellValue("")
            End If
            objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(3, 0, 3, odtDataSource.Columns.Count - 1))



            If ListFiltro Is Nothing AndAlso ListFiltro.Count = 0 Then
                rowActual = rowActual + 1
            ElseIf ListFiltro IsNot Nothing AndAlso ((ListFiltro.Count - 1) >= FilaTable) Then
                Dim x As Integer = 0
                Dim ValCeldas() As String
                Dim DisplayTitle As String = ""
                Dim DipplayValue As String = ""
                For Each items As DictionaryEntry In ListFiltro(FilaTable)
                    DisplayTitle = ""
                    DipplayValue = ""
                    ValCeldas = ("" & items.Value).ToString.Split("|")
                    If ValCeldas.Length > 1 Then
                        DisplayTitle = ValCeldas(0)
                        DipplayValue = ValCeldas(1)
                    End If
                    x = x + 1
                    DipplayValue = DisplayTitle & "  " & DipplayValue
                    'objWorkSheet.GetRow(rowActual + x - 4).CreateCell(1).CellStyle = styleFiltro
                    'objWorkSheet.GetRow(rowActual + x - 4).GetCell(1).SetCellValue(DipplayValue)
                    'objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 1, rowActual + x - 4, 3))

                    objWorkSheet.GetRow(rowActual + x - 4).CreateCell(0).CellStyle = styleFiltro
                    objWorkSheet.GetRow(rowActual + x - 4).GetCell(0).SetCellValue(DipplayValue)
                    objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(rowActual + x - 4, 0, rowActual + x - 4, 2))

                Next
                rowActual = rowActual + ListFiltro(FilaTable).Count - 1
            End If

            Dim ValorCelda As String = ""
            Dim tituloColumna As String = ""
            Dim NumMaxFilasTitulo As Int32 = 0
            Dim DatosTitulo() As String
            Dim MaxShortTitulo As Short = 32767
            Dim TotalHeightTitulo As Int32 = 0
            Dim ColorFondoCab As String = ""
            Dim ColorLetraCab As String = ""
            Dim ColorFondo As String = ""
            Dim ColorLetra As String = ""
            Dim ColorIndex As String = ""
            Dim oHasFormatoFila As New Hashtable
            Dim ValCelda As String = ""

            Dim AvanceFilaCab As Int32 = 0
            Dim NameColTemp As String = ""
            For j As Integer = 0 To odtDataSource.Columns.Count - 1

                y = IndiceColum
                CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
                oHasDatosData = DesFormatDato(CaptionColumna)
                tituloColumna = oHasDatosData(keyTituloColumna)

                ColorFondoCab = oHasDatosData(keyColorFondo)
                ColorLetraCab = oHasDatosData(keyColorLetra)

                Cabeceras = tituloColumna.Split("|")

                AvanceFilaCab = 0
                NameColTemp = odtDataSource.Columns(j).ColumnName

                Dim itemCabecera As String = ""
                For FilaCabeceraMultiple As Integer = 0 To MaxTotalCab - 1
                    If Cabeceras.Length - 1 >= FilaCabeceraMultiple Then
                        itemCabecera = Cabeceras(FilaCabeceraMultiple)
                    Else
                        itemCabecera = ""
                    End If

                    HasPosicionFilaColCabecera.Add(NameColTemp & "_" & AvanceFilaCab & "_CAB", indice + rowActual + AvanceFilaCab)

                    If ColorFondoCab <> "" AndAlso ColorLetraCab <> "" Then
                        Dim styleCabTemp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                        Estilos_Excel_NPOI(styleCabTemp, TipoEstilo.Cabecera, Nothing, ColorFondoCab)

                        Dim oFontCabTemp As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
                        oFontCabTemp.Color = Convert.ToInt16(ColorLetraCab)
                        oFontCabTemp.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
                        oFontCabTemp.FontHeight = fontSizeColumnaHeader
                        styleCabTemp.DataFormat = HSSFDataFormat.GetBuiltinFormat("@")
                        styleCabTemp.SetFont(oFontCabTemp)
                        objWorkSheet.GetRow(indice - 1 + rowActual + AvanceFilaCab).CreateCell(y).CellStyle = styleCabTemp
                    Else
                        objWorkSheet.GetRow(indice - 1 + rowActual + AvanceFilaCab).CreateCell(y).CellStyle = styleCab
                    End If
                    'objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(Cabeceras(0))
                    objWorkSheet.GetRow(indice - 1 + rowActual + AvanceFilaCab).GetCell(y).SetCellValue(itemCabecera)


                    NumMaxFilasTitulo = 1
                    'DatosTitulo = Cabeceras(0).Split(Chr(10))
                    DatosTitulo = itemCabecera.Split(Chr(10))
                    If (DatosTitulo.Length > NumMaxFilasTitulo) Then
                        NumMaxFilasTitulo = DatosTitulo.Length
                    End If
                    If NumMaxFilasTitulo > 1 Then
                        For X As Int32 = rowActual - 1 To rowActual
                            TotalHeightTitulo = 284 * NumMaxFilasTitulo
                            If TotalHeightTitulo > MaxShortTitulo Then
                                objWorkSheet.GetRow(X).Height = MaxShortTitulo
                            Else
                                objWorkSheet.GetRow(X).Height = TotalHeightTitulo
                            End If
                        Next
                    End If
                    AvanceFilaCab = AvanceFilaCab + 1

                Next
                HasPosicionHojaColumna(odtDataSource.Columns(j).ColumnName) = y
                IndiceColum += 1
            Next

            '********************fin copia***********************

            Dim row As New NPOI.HSSF.UserModel.HSSFRow
            row = objWorkSheet.GetRow(indice + rowActual - 1)
            Dim IsBreak As Boolean = False
            Dim PosInicioBreak As Int32 = 0
            Dim PosFinalBreak As Int32 = 0
            Dim ValorCeldaActual As String
            Dim ValorCeldaNext As String = ""
            Dim oListCeldaTitleIguales As New List(Of Int32)
            Dim ColIndexInicial As Int32 = 0
            Dim ColIndexFinal As Int32 = 0

            If MultipleCabecera = True Then
                'If DobleCabecera = True Then
                For x As Int32 = 0 To odtDataSource.Columns.Count - 1
                    NameColumna = odtDataSource.Columns(x).ColumnName
                    ColIndexInicial = x
                    ValorCeldaActual = row.GetCell(ColIndexInicial).StringCellValue.Trim
                    If x = odtDataSource.Columns.Count - 1 Then
                        ColIndexFinal = x
                        ValorCeldaNext = "*.*.*.*.*.*.*.*.*.*" 'texto cualquiera
                    Else
                        ColIndexFinal = x + 1
                        ValorCeldaNext = row.GetCell(ColIndexFinal).StringCellValue.Trim

                    End If
                    If ValorCeldaNext = ValorCeldaActual Then
                        oListCeldaTitleIguales.Add(ColIndexInicial)
                    Else
                        PosFinalBreak = ColIndexInicial
                        oListCeldaTitleIguales.Add(ColIndexInicial)
                        IsBreak = True
                    End If
                    If IsBreak = True Then
                        If oListCeldaTitleIguales.Count > 1 Then
                            'SI TIENE MAS DE 2 COLUMNAS IGUALES
                            For IndexCelda As Integer = 0 To oListCeldaTitleIguales.Count - 1
                                If PosInicioBreak <> oListCeldaTitleIguales(IndexCelda) Then
                                    row.GetCell(oListCeldaTitleIguales(IndexCelda)).SetCellValue("")
                                End If
                            Next
                            Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, PosInicioBreak, indice - 1 + rowActual, PosFinalBreak)
                            objWorkSheet.AddMergedRegion(Region)
                        Else
                            'If Not oListColDobleCabecera.Contains(NameColumna) Then
                            If Not oListColMultipleCabecera.Contains(NameColumna) Then
                                'SI NO ES UNA COLUMNA QUE TIENE DOBLE CABECERA
                                ' Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual, ColIndexInicial)
                                Dim Region As New NPOI.SS.Util.Region(indice - 1 + rowActual, ColIndexInicial, indice + rowActual + MaxTotalCab - 2, ColIndexInicial)
                                objWorkSheet.AddMergedRegion(Region)
                            End If
                        End If
                        PosInicioBreak = PosFinalBreak + 1
                        oListCeldaTitleIguales = New List(Of Int32)
                        IsBreak = False
                    End If
                Next
                rowActual += 1
            End If
            If MultipleCabecera = True Then
                rowActual = rowActual + MaxTotalCab - 1
            Else
                rowActual = rowActual + MaxTotalCab
            End If

            'rowActual += 1

            Dim ValorNumero As Decimal = 0
            Dim NumMaxFilas As Decimal = 0
            Dim Datos() As String
            Const MaxLenDato As Int32 = 120
            Dim Tamanio As Int32 = 0
            Dim IsConTamanio As Boolean = False
            Dim TipoDato As String = ""

            Dim EsVariasFilas As Boolean = False
            Dim ListaCeldaColNameNFilas As New Hashtable


            Dim oHasListFilasCombinar As New Hashtable
            Dim oHasVarComb As New Hashtable
            Dim filasComb() As String
            Dim ColumnaKey() As String


            If ListCeldaColNameNFilas IsNot Nothing AndAlso (ListCeldaColNameNFilas.Count - 1) >= FilaTable AndAlso ListCeldaColNameNFilas(FilaTable) <> "" Then
                For Each Item As String In ListCeldaColNameNFilas(FilaTable).Split(pNFilas)
                    ListaCeldaColNameNFilas.Add(Item, Item)
                Next
            End If

            If ListNameCombDuplicado IsNot Nothing AndAlso (ListNameCombDuplicado.Count - 1) >= FilaTable AndAlso ListNameCombDuplicado(FilaTable) <> "" Then

                filasComb = ListNameCombDuplicado(FilaTable).Split("|")
                For Each Item As String In filasComb
                    ColumnaKey = Item.Split(":")
                    oHasListFilasCombinar.Add(ColumnaKey(0), ColumnaKey(1))
                Next
            End If


            Dim COL_ALLVALUE_KBRE_ACTUAL As String = ""
            Dim COL_KEY_KBRE_TEMP As String = ""
            Dim POS_TEMP_INICIO_COL_KEY_KBRE As String = ""
            Dim POS_TEMP_FIN_COL_KEY_KBRE As String = ""

            Dim col_comb() As String
            Dim col As String = ""
            Dim valor As String = ""
            Dim FlgTomarValorUltCol As Boolean = False
            Dim TotalCol As Int32 = 0
            For Each item As DictionaryEntry In oHasListFilasCombinar
                col_comb = item.Value.ToString.Split("/")(0).Split(",")

                FlgTomarValorUltCol = False
                If item.Value.ToString.Split("/")(1) = "1" Then
                    FlgTomarValorUltCol = True
                End If
                col = ""
                For Each columna As String In col_comb
                    col = col & columna & "_"
                Next
                COL_ALLVALUE_KBRE_ACTUAL = "COL_" & col & "KBRE_ACTUAL"
                oHasVarComb.Add(COL_ALLVALUE_KBRE_ACTUAL, "")

                COL_KEY_KBRE_TEMP = "COL_" & item.Key & "_KBRE_TEMP"
                oHasVarComb.Add(COL_KEY_KBRE_TEMP, "")

                POS_TEMP_INICIO_COL_KEY_KBRE = "POS_TEMP_INICIO_COL_" & item.Key & "_KBRE"
                oHasVarComb.Add(POS_TEMP_INICIO_COL_KEY_KBRE, indice - 1 + rowActual)

                POS_TEMP_FIN_COL_KEY_KBRE = "POS_TEMP_FIN_COL_" & item.Key & "_KBRE"
                oHasVarComb.Add(POS_TEMP_FIN_COL_KEY_KBRE, 0)

                valor = ""
                If (odtDataSource.Rows.Count > 0) Then
                    TotalCol = col_comb.Length - 1
                    If FlgTomarValorUltCol = False Then
                        TotalCol = TotalCol - 1
                    End If
                    For index As Integer = 0 To TotalCol
                        valor = valor & odtDataSource.Rows(0).Item(col_comb(index)).ToString.Trim & "_"
                    Next
                    oHasVarComb(COL_KEY_KBRE_TEMP) = valor
                End If

            Next

            Dim POS_FINAL_COL1_KBRE As Int32 = 0
            Dim POS_GRUPO_INICIO As Int32 = 0
            Dim POS_GRUPO_FIN As Int32 = 0
            Dim CAMBIAR_ALTO_FILA As Boolean = False

            POS_INICIO_REGISTRO = indice - 1 + rowActual
            Dim numFilasActual As Int32 = 0
            Dim exp_Lista() As String
            Dim exp_Formula As String = ""

            Dim columna_calculo = ""
            Dim pos_columna_hoja_calculo As Int32 = 0
            Dim LetraColumnaExcel_calculo As String = ""

            Dim FilasxPK As Int32 = 0
            Dim dr() As DataRow
            Dim consulta As String = ""
            For i As Integer = 0 To odtDataSource.Rows.Count - 1
                IndiceColum = 0
                NumMaxFilas = 1
                IsConTamanio = False

                oHasFormatoFila = DesFormatoFila(dtFilasFormato.Rows(i)(keyNameColFormatoFila))
                ColorIndex = oHasFormatoFila(keyColorFondo)

                EsVariasFilas = False
                numFilasActual = 1

                FilasxPK = 0
                For j As Integer = 0 To odtDataSource.Columns.Count - 1
                    ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                    ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
                    CaptionColumna = odtDataSource.Columns(j).Caption.Trim
                    NameColumna = odtDataSource.Columns(j).ColumnName

                    'If ListaColNameNFilas.Contains(NameColumna) Then
                    If ListaCeldaColNameNFilas.Contains(NameColumna) Then
                        '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
                        '// AUMENTANDO 
                        Datos = ValorCelda.Split(Chr(10))
                        If (Datos.Length > NumMaxFilas) Then
                            NumMaxFilas = Datos.Length
                            For Each Item As String In Datos
                                If (Item.Length > MaxLenDato) Then
                                    NumMaxFilas = NumMaxFilas + 1
                                End If
                            Next
                        End If
                       
                    End If
                Next
                'ColumnaAgrupacionFilaMax

                For j As Integer = 0 To odtDataSource.Columns.Count - 1
                    y = IndiceColum
                    ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                    ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
                    CaptionColumna = odtDataSource.Columns(j).Caption.Trim
                    NameColumna = odtDataSource.Columns(j).ColumnName
                    oHasDatosData = DesFormatDato(CaptionColumna)
                    TipoDato = oHasDatosData(keyTipoDato)


                    If ColumnaAgrupacionFilaMax IsNot Nothing AndAlso ColumnaAgrupacionFilaMax.Contains(NameColumna) Then
                        consulta = NameColumna & "='" & ValorCelda & "'"
                        dr = odtDataSource.Select(consulta)
                       
                        FilasxPK = dr.Length
                        If FilasxPK > NumMaxFilas Then
                            NumMaxFilas = 1
                        ElseIf NumMaxFilas > FilasxPK Then
                            NumMaxFilas = 1 + Math.Round((NumMaxFilas - FilasxPK) / FilasxPK, 2)
                        End If
                    End If




                    If ListaCeldaColNameNFilas.Contains(NameColumna) Then
                        '//SE VERIFICA LOS QUE TIENES VARIAS FILAS 
                        '// AUMENTANDO 
                        Datos = ValorCelda.Split(Chr(10))
                        If (Datos.Length > numFilasActual) Then
                            numFilasActual = Datos.Length
                            For Each Item As String In Datos
                                If (Item.Length > MaxLenDato) Then
                                    numFilasActual = numFilasActual + 1
                                End If
                            Next
                        End If
                        '//(TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO TEXTTO
                        '//TIPO TEXTO) SI EL DATO DE VERIAS FILAS TIENE MAS DE UNA FILA :ESTILO NORMAL 
                        If numFilasActual > 1 Then
                            EsVariasFilas = True
                        Else
                            EsVariasFilas = False
                        End If
                    End If



                    Select Case TipoDato
                        Case pTNumero
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            If ColorIndex <> "" Then
                                Dim styleNumber_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                Estilos_Excel_NPOI(styleNumber_Temp, TipoEstilo.Numero, Nothing, ColorIndex)
                                styleNumber_Temp.SetFont(oFont)
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber_Temp
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
                            End If
                            If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
                            End If
                        Case pTTexto
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            Select Case EsVariasFilas
                                Case True
                                    If ColorIndex <> "" Then
                                        Dim styleNormal_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                        Estilos_Excel_NPOI(styleNormal_Temp, TipoEstilo.Normal, Nothing, ColorIndex)
                                        styleNormal_Temp.SetFont(oFont)
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal_Temp
                                    Else
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                                    End If
                                Case False
                                    If ColorIndex <> "" Then
                                        Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                        Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Texto, Nothing, ColorIndex)
                                        styleTexto_Temp.SetFont(oFont)
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto_Temp
                                    Else
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
                                    End If

                            End Select
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

                            If (IsConTamanio = True) Then
                                objWorkSheet.SetColumnWidth(y, Tamanio)
                            End If
                        Case pTFecha
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            If ColorIndex <> "" Then
                                Dim styleFecha_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                Estilos_Excel_NPOI(styleFecha_Temp, TipoEstilo.Fecha, Nothing, ColorIndex)
                                styleFecha_Temp.SetFont(oFont)
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha_Temp
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleFecha
                            End If
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

                        Case pTCalculo_Texto

                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            Select Case EsVariasFilas
                                Case True
                                    If ColorIndex <> "" Then
                                        Dim styleNormal_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                        Estilos_Excel_NPOI(styleNormal_Temp, TipoEstilo.Normal, Nothing, ColorIndex)
                                        styleNormal_Temp.SetFont(oFont)
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal_Temp
                                    Else
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNormal
                                    End If
                                Case False
                                    If ColorIndex <> "" Then
                                        Dim styleTexto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                        Estilos_Excel_NPOI(styleTexto_Temp, TipoEstilo.Texto, Nothing, ColorIndex)
                                        styleTexto_Temp.SetFont(oFont)
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto_Temp
                                    Else
                                        objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleTexto
                                    End If

                            End Select

                            exp_Lista = ValorCelda.Split(" ")
                            exp_Formula = ""
                            columna_calculo = ""
                            pos_columna_hoja_calculo = 0
                            LetraColumnaExcel_calculo = ""

                            For Each Item As String In exp_Lista
                                If Item.EndsWith("_COL") Then
                                    columna_calculo = Item.Split("_")(0)
                                    pos_columna_hoja_calculo = HasPosicionHojaColumna(columna_calculo)
                                    LetraColumnaExcel_calculo = LetraNumero_NPOI(pos_columna_hoja_calculo + 1)
                                    exp_Formula = exp_Formula & " " & LetraColumnaExcel_calculo & (indice + rowActual)

                                ElseIf Item.EndsWith("_CAB") Then

                                    columna_calculo = (Item.Split("_CAB")(0)).Split("_")(0)
                                    pos_columna_hoja_calculo = HasPosicionHojaColumna(columna_calculo)
                                    LetraColumnaExcel_calculo = LetraNumero_NPOI(pos_columna_hoja_calculo + 1)
                                    exp_Formula = exp_Formula & " " & LetraColumnaExcel_calculo & (HasPosicionFilaColCabecera(Item))

                                Else
                                    exp_Formula = exp_Formula & " " & Item
                                End If
                            Next
                            exp_Formula = exp_Formula.Trim
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellFormula = (exp_Formula)
                            'objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorCelda)

                            If (IsConTamanio = True) Then
                                objWorkSheet.SetColumnWidth(y, Tamanio)
                            End If

                        Case pTCalculo_Numero

                            exp_Lista = ValorCelda.Split(" ")
                            exp_Formula = ""
                            columna_calculo = ""
                            pos_columna_hoja_calculo = 0
                            LetraColumnaExcel_calculo = ""

                            For Each Item As String In exp_Lista

                                If Item.EndsWith("_COL") Then
                                    columna_calculo = Item.Split("_")(0)
                                    pos_columna_hoja_calculo = HasPosicionHojaColumna(columna_calculo)
                                    LetraColumnaExcel_calculo = LetraNumero_NPOI(pos_columna_hoja_calculo + 1)
                                    exp_Formula = exp_Formula & " " & LetraColumnaExcel_calculo & (indice + rowActual)
                                ElseIf Item.EndsWith("_CAB") Then

                                    columna_calculo = (Item.Split("_CAB")(0)).Split("_")(0)
                                    pos_columna_hoja_calculo = HasPosicionHojaColumna(columna_calculo)
                                    LetraColumnaExcel_calculo = LetraNumero_NPOI(pos_columna_hoja_calculo + 1)
                                    exp_Formula = exp_Formula & " " & LetraColumnaExcel_calculo & (HasPosicionFilaColCabecera(Item))
                                Else
                                    exp_Formula = exp_Formula & " " & Item
                                End If


                            Next

                            exp_Formula = exp_Formula.Trim
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            If ColorIndex <> "" Then
                                Dim styleNumber_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                Estilos_Excel_NPOI(styleNumber_Temp, TipoEstilo.Numero, Nothing, ColorIndex)
                                styleNumber_Temp.SetFont(oFont)
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber_Temp
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleNumber
                            End If

                            'If Decimal.TryParse(ValorCelda, ValorNumero) = False Then
                            '    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue("")
                            'Else
                            '    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).SetCellValue(ValorNumero)
                            'End If
                            objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellFormula = (exp_Formula)

                    End Select

                    If oHasListFilasCombinar IsNot Nothing AndAlso (oHasListFilasCombinar.Count > 0) AndAlso oHasListFilasCombinar.Contains(NameColumna) Then
                        col_comb = oHasListFilasCombinar(NameColumna).ToString.Split("/")(0).Split(",")
                        col = ""
                        valor = ""

                        FlgTomarValorUltCol = False
                        If oHasListFilasCombinar(NameColumna).ToString.Split("/")(1) = "1" Then
                            FlgTomarValorUltCol = True
                        End If
                        TotalCol = col_comb.Length - 1
                        If FlgTomarValorUltCol = False Then
                            TotalCol = TotalCol - 1
                        End If
                        For index As Integer = 0 To TotalCol
                            valor = valor & odtDataSource.Rows(i).Item(col_comb(index)).ToString.Trim & "_"
                        Next


                        COL_ALLVALUE_KBRE_ACTUAL = "COL_" & col & "KBRE_ACTUAL"

                        oHasVarComb(COL_ALLVALUE_KBRE_ACTUAL) = valor

                        COL_KEY_KBRE_TEMP = "COL_" & NameColumna & "_KBRE_TEMP"
                        POS_TEMP_INICIO_COL_KEY_KBRE = "POS_TEMP_INICIO_COL_" & NameColumna & "_KBRE"
                        POS_TEMP_FIN_COL_KEY_KBRE = "POS_TEMP_FIN_COL_" & NameColumna & "_KBRE"

                        If oHasVarComb(COL_KEY_KBRE_TEMP) <> oHasVarComb(COL_ALLVALUE_KBRE_ACTUAL) Then

                            POS_GRUPO_INICIO = oHasVarComb(POS_TEMP_INICIO_COL_KEY_KBRE)
                            POS_GRUPO_FIN = (indice - 1 + rowActual) - 1
                            oHasVarComb(POS_TEMP_FIN_COL_KEY_KBRE) = (indice - 1 + rowActual) - 1
                            Dim Region As New NPOI.SS.Util.Region(oHasVarComb(POS_TEMP_INICIO_COL_KEY_KBRE), j, oHasVarComb(POS_TEMP_FIN_COL_KEY_KBRE), j)
                            oHasVarComb(POS_TEMP_INICIO_COL_KEY_KBRE) = oHasVarComb(POS_TEMP_FIN_COL_KEY_KBRE) + 1
                            objWorkSheet.AddMergedRegion(Region)
                            oHasVarComb(COL_KEY_KBRE_TEMP) = oHasVarComb(COL_ALLVALUE_KBRE_ACTUAL)


                        ElseIf i = odtDataSource.Rows.Count - 1 AndAlso oHasVarComb(COL_KEY_KBRE_TEMP) = oHasVarComb(COL_ALLVALUE_KBRE_ACTUAL) Then

                            POS_GRUPO_INICIO = oHasVarComb(POS_TEMP_INICIO_COL_KEY_KBRE)
                            POS_GRUPO_FIN = (indice - 1 + rowActual)
                            oHasVarComb(POS_TEMP_FIN_COL_KEY_KBRE) = (indice - 1 + rowActual)

                            Dim Region As New NPOI.SS.Util.Region(oHasVarComb(POS_TEMP_INICIO_COL_KEY_KBRE), j, oHasVarComb(POS_TEMP_FIN_COL_KEY_KBRE), j)
                            oHasVarComb(POS_TEMP_INICIO_COL_KEY_KBRE) = oHasVarComb(POS_TEMP_FIN_COL_KEY_KBRE) + 1
                            objWorkSheet.AddMergedRegion(Region)
                            oHasVarComb(COL_KEY_KBRE_TEMP) = oHasVarComb(COL_ALLVALUE_KBRE_ACTUAL)

                        End If

                    End If


                    IndiceColum += 1
                Next

                Dim MaxShort As Short = 32767
                Dim TotalHeight As Int32 = 0
               
 

                If NumMaxFilas > 1 Then
                    For X As Int32 = rowActual - 1 To rowActual - 1
                        TotalHeight = 284 * NumMaxFilas
                        If TotalHeight > MaxShort Then
                            objWorkSheet.GetRow(X).Height = MaxShort
                        Else
                            objWorkSheet.GetRow(X).Height = TotalHeight
                        End If
                    Next
                End If


                rowActual += 1
            Next
            POS_FINAL_REGISTRO = indice - 1 + rowActual

            If ListColumnasSumar.Count > 0 Then
                Dim strFormula As String = ""
                Dim columna_para_suma As String = ""
                Dim pos_columna_hoja As Int64 = 0
                Dim LetraColumnaExcel As String = ""
                For Each item As DictionaryEntry In ListColumnasSumar
                    columna_para_suma = item.Key
                    pos_columna_hoja = HasPosicionHojaColumna(item.Key)
                    LetraColumnaExcel = LetraNumero_NPOI(pos_columna_hoja + 1)
                    strFormula = "SUM(" & LetraColumnaExcel & POS_INICIO_REGISTRO & ":" & LetraColumnaExcel & POS_FINAL_REGISTRO & ")"
                    objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(pos_columna_hoja)
                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(pos_columna_hoja).CellStyle = styleNumber
                    objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(pos_columna_hoja).CellFormula = (strFormula)
                Next
            End If

            objWorkSheet.DefaultColumnWidth = 35
            objWorkSheet.DefaultRowHeightInPoints = 25
            For z As Integer = 0 To odtDataSource.Columns.Count - 1
                objWorkSheet.AutoSizeColumn(z, True)
            Next

            Dim patriarch As HSSFPatriarch = DirectCast(objWorkSheet.CreateDrawingPatriarch(), HSSFPatriarch)
            Dim anchor As HSSFClientAnchor
            anchor = New HSSFClientAnchor(0, 0, 0, 80, 0, 0, 0, 0)
            Dim rutaLogo As String = Application.StartupPath & "\Resources\logo_ransas.jpg"
            If IO.File.Exists(rutaLogo) Then
                'load the picture and get the picture index in the workbook
                Dim picture As HSSFPicture = DirectCast(patriarch.CreatePicture(anchor, LoadImage(rutaLogo, objWorkBook)), HSSFPicture)
                'Reset the image to the original size.
                picture.Resize(0.5)
            End If
        Next

        objWorkBook.Write(fs)
        fs.Close()
        HelpClass.AbrirDocumento(archivo)

    End Sub




#End Region






End Class

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
Public Class HelpClass_NPOI_SA
    Private Const pAHIzquierdo As String = "IZQUIERDO"
    Private Const pAHCentro As String = "CENTRO"
    Private Const pAHDerecho As String = "DERECHO"
    Private Const pTNumero As String = "NUMERO"
    Private Const pTMonto As String = "MONTO"
    Private Const pTTexto As String = "TEXTO"
    Private Const pTFecha As String = "FECHA"
    Private Const pNFilas As String = "|"
    Private Const pColorFondo As String = "COLOR_FONDO"
    Private Const pColorLetra As String = "COLOR_LETRA"
    Private Const pNameColFormatoFila As String = "FORMATO_FILA"
    Private Const keyAlineacion As String = "ALINEACION"
    Private Const keyTipoDato As String = "TIPO_DATO"
    Private Const keyTituloColumna As String = "TITULO_COLUMNA"

    Public Const keyAlinHIzquierdo As String = pAHIzquierdo
    Public Const keyAlinHCentro As String = pAHCentro
    Public Const keyAlinHDerecho As String = pAHDerecho
    Public Const keyDatoNumero As String = pTNumero
    Public Const keyDatoMonto As String = pTMonto
    Public Const keyDatoTexto As String = pTTexto
    Public Const keyDatoFecha As String = pTFecha

    Public Const keySepNFilas As String = pNFilas
    Public Const keyNameColFormatoFila As String = pNameColFormatoFila
    Public Const keyColorFondo As String = pColorFondo
    Public Const keyColorLetra As String = pColorLetra


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
    Private Const fontSizeTitulo As Int32 = 220

    Public Shared Function FormatoFila(ByVal ColorFondoFila As String, Optional ByVal ColorLetraFila As String = "") As String
        Dim sbFormato As New StringBuilder
        sbFormato.Append(keyColorFondo)
        sbFormato.Append(keyCharKeyValue)
        sbFormato.Append(ColorFondoFila)
        sbFormato.Append(keyCharSeparacion)
        sbFormato.Append(keyColorLetra)
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

    Public Function FormatDato(ByVal oTituloColumna As String, Optional ByVal oTipoDato As String = keyDatoTexto, Optional ByVal oAlinH As String = keyAlinHIzquierdo, Optional ByVal oColorFondoCabecera As String = "", Optional ByVal oColorLetraCabecera As String = "") As String
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
        Monto
    End Enum

    Enum AlineacionH
        Neutro
        Centro
        Izquierda
        Derecha
    End Enum

    Private Shared Sub Estilos_Excel_NPOI(ByVal style As NPOI.SS.UserModel.CellStyle, ByVal _tipoEstilo As TipoEstilo, Optional ByVal _AlineacionH As AlineacionH = AlineacionH.Neutro, Optional ByVal _FillColor As String = "")
        'Dim oFontCab As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        'oFontCab.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
        'oFontCab.Boldweight = NPOI.HSSF.Util.HSSFColor.BLACK.index
        'oFontCab.FontHeight = 220

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
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.GREEN.index
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER
                style.WrapText = True
                style.VerticalAlignment = VerticalAlignment.CENTER
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                'style.BorderRight = CellBorderType.THIN
                'style.BorderBottom = CellBorderType.THIN
                'style.BorderLeft = CellBorderType.THIN
                'style.BorderTop = CellBorderType.THIN
                'style.SetFont(oFontCab)
                style.DataFormat = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillPattern = FillPatternType.SOLID_FOREGROUND
                'style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                'style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                'style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                'style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT
                'style.DataFormat = NPOI.HSSF.Util.HSSFColor.BLACK.index
                'style.FillPattern = FillPatternType.SOLID_FOREGROUND

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

            Case TipoEstilo.Monto

                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.RIGHT
                style.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.WHITE.index
                style.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00") 'HSSFDataFormat.GetBuiltinFormat("#.##0,00") '"#.##0,00"
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

    Private Shared Function LoadImage(ByVal path As String, ByVal wb As HSSFWorkbook) As Integer
        Dim file As New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim buffer As Byte() = New Byte(file.Length - 1) {}
        file.Read(buffer, 0, CInt(file.Length))
        Return wb.AddPicture(buffer, PictureType.JPEG)
    End Function

    Public Sub ExportExcelGeneralMultiple(ByVal odtListDataSource As List(Of DataTable), ByVal ListTitulo As List(Of String), ByVal ListColNameNFilas As List(Of String), Optional ByVal ListFiltro As List(Of SortedList) = Nothing, Optional ByVal ListNameDelFilDuplic As List(Of String) = Nothing)

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
        Dim styleMonto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleFecha As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim styleTexto As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
        Dim patriarch As HSSFPatriarch = DirectCast(objWorkSheet.CreateDrawingPatriarch(), HSSFPatriarch)

        Dim oFontFiltro As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontFiltro.Color = NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontFiltro.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontFiltro.FontHeight = fontSizeFiltros

        Dim oFontTitulo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
        oFontTitulo.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index 'NPOI.HSSF.Util.HSSFColor.BLACK.index
        oFontTitulo.Boldweight = NPOI.SS.UserModel.FontBoldWeight.BOLD
        oFontTitulo.FontHeight = fontSizeTitulo

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
        Estilos_Excel_NPOI(styleMonto, TipoEstilo.Monto)
        Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)
        Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)

        '============================================
        styleFiltro.SetFont(oFontFiltro)
        styleCab.SetFont(oFontCab)
        styleTitulo.SetFont(oFontTitulo)

        styleNormal.SetFont(oFont)
        styleNumber.SetFont(oFont)
        styleMonto.SetFont(oFont)
        styleFecha.SetFont(oFont)
        styleTexto.SetFont(oFont)

        '===================Se cargan Las Variables de Trabajo=====================
        'Dim FilaTable As Int32 = 0
        Dim odtDataSource As New DataTable

        For FilaTable As Integer = 0 To odtListDataSource.Count - 1
            odtDataSource = odtListDataSource(FilaTable).Copy

            Dim indice As Integer = 0
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
            objWorkSheet.GetRow(3).CreateCell(0).CellStyle = styleTitulo
            If ListTitulo IsNot Nothing AndAlso (ListTitulo.Count - 1) >= FilaTable Then
                objWorkSheet.GetRow(3).GetCell(0).SetCellValue(ListTitulo(FilaTable))
            Else
                objWorkSheet.GetRow(3).GetCell(0).SetCellValue("")
            End If
            objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(3, 0, 3, odtListDataSource(FilaTable).Columns.Count - 1))

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

                ColorFondoCab = oHasDatosData(keyColorFondo)
                ColorLetraCab = oHasDatosData(keyColorLetra)

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
            Dim Fecha As Date
            Dim EsVariasFilas As Boolean = False

            Dim ListaColNameNFilas As New List(Of String)
            If ListColNameNFilas IsNot Nothing AndAlso (ListColNameNFilas.Count - 1) >= FilaTable AndAlso ListColNameNFilas(FilaTable) <> "" Then
                For Each Item As String In ListColNameNFilas(FilaTable).Split(pNFilas)
                    ListaColNameNFilas.Add(Item)
                Next
            End If



            Dim COL1_KBRE_ACTUAL As String = ""

            Dim COL1_KBRE_TEMP As String = ""

            Dim POS_TEMP_INICIO_COL1_KBRE As Int32 = indice - 1 + rowActual
            Dim POS_TEMP_FIN_COL1_KBRE As Int32 = 0

            If (ListNameDelFilDuplic IsNot Nothing AndAlso ((ListNameDelFilDuplic.Count - 1) >= FilaTable) AndAlso ListNameDelFilDuplic(FilaTable).Trim <> "" AndAlso odtDataSource.Columns(ListNameDelFilDuplic(FilaTable)) IsNot Nothing AndAlso odtDataSource.Rows.Count > 0) Then
                COL1_KBRE_TEMP = odtDataSource.Rows(0).Item(ListNameDelFilDuplic(FilaTable)).ToString.Trim
            End If

            Dim POS_FINAL_COL1_KBRE As Int32 = 0


            For i As Integer = 0 To odtDataSource.Rows.Count - 1
                IndiceColum = 0
                NumMaxFilas = 1
                IsConTamanio = False

                oHasFormatoFila = DesFormatoFila(dtFilasFormato.Rows(i)(keyNameColFormatoFila))
                ColorIndex = oHasFormatoFila(keyColorFondo)

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
                        Case pTMonto
                            objWorkSheet.GetRow(indice - 1 + rowActual).CreateCell(y)
                            If ColorIndex <> "" Then
                                Dim styleMonto_Temp As NPOI.SS.UserModel.CellStyle = objWorkBook.CreateCellStyle()
                                Estilos_Excel_NPOI(styleMonto_Temp, TipoEstilo.Monto, Nothing, ColorIndex)
                                styleMonto_Temp.SetFont(oFont)
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleMonto_Temp
                            Else
                                objWorkSheet.GetRow(indice - 1 + rowActual).GetCell(y).CellStyle = styleMonto
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
                            'If (Date.TryParse(ValorCelda, Fecha)) Then
                            '    ValorCelda = String.Format("{0:d}", CDate(ValorCelda))
                            'Else
                            '    ValorCelda = ""
                            'End If
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

                    If (ListNameDelFilDuplic IsNot Nothing AndAlso ((ListNameDelFilDuplic.Count - 1) >= FilaTable) AndAlso ListNameDelFilDuplic(FilaTable) <> "" AndAlso odtDataSource.Columns(ListNameDelFilDuplic(FilaTable)) IsNot Nothing AndAlso NameColumna = ListNameDelFilDuplic(FilaTable)) Then
                        COL1_KBRE_ACTUAL = ("" & odtDataSource.Rows(i).Item(ListNameDelFilDuplic(FilaTable))).ToString.Trim

                        If (COL1_KBRE_ACTUAL <> COL1_KBRE_TEMP) Then

                            POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual) - 1
                            POS_FINAL_COL1_KBRE = (indice - 1 + rowActual) - 1
                            Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
                            POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
                            COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
                            objWorkSheet.AddMergedRegion(Region)

                        ElseIf i = odtDataSource.Rows.Count - 1 AndAlso COL1_KBRE_ACTUAL = COL1_KBRE_TEMP Then

                            POS_TEMP_FIN_COL1_KBRE = (indice - 1 + rowActual)
                            POS_FINAL_COL1_KBRE = (indice - 1 + rowActual)
                            Dim Region As New NPOI.SS.Util.Region(POS_TEMP_INICIO_COL1_KBRE, j, POS_TEMP_FIN_COL1_KBRE, j)
                            POS_TEMP_INICIO_COL1_KBRE = POS_TEMP_FIN_COL1_KBRE + 1
                            COL1_KBRE_TEMP = COL1_KBRE_ACTUAL
                            objWorkSheet.AddMergedRegion(Region)

                        End If
                    End If


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

            objWorkSheet.DefaultColumnWidth = 35
            objWorkSheet.DefaultRowHeightInPoints = 25
            For z As Integer = 0 To odtDataSource.Columns.Count - 1
                objWorkSheet.AutoSizeColumn(z, True)
            Next


        Next

        Dim patriarch2 As HSSFPatriarch = DirectCast(objWorkSheet.CreateDrawingPatriarch(), HSSFPatriarch)
        Dim anchor As HSSFClientAnchor
        anchor = New HSSFClientAnchor(0, 0, 0, 80, 0, 0, 0, 0)
        Dim rutaLogo As String = Application.StartupPath & "\Resources\logo.png"
        If IO.File.Exists(rutaLogo) Then
            'load the picture and get the picture index in the workbook
            Dim picture As HSSFPicture = DirectCast(patriarch2.CreatePicture(anchor, LoadImage(rutaLogo, objWorkBook)), HSSFPicture)
            'Reset the image to the original size.
            picture.Resize(0.5)
        End If

        'Dim anchor As HSSFClientAnchor
        '' segun la coordenadas ->HSSFClientAnchor(0, 0, 0, 0, x, y, 0, 0)
        'anchor = New HSSFClientAnchor(0, 0, 0, 0, 0, 0, 0, 0)
        'If IO.File.Exists(Application.StartupPath & " \Resources\logo.png") Then
        '    'load the picture and get the picture index in the workbook
        '    Dim picture As HSSFPicture = DirectCast(patriarch.CreatePicture(anchor, LoadImage(Application.StartupPath & " \Resources\logo.png", objWorkBook)), HSSFPicture)
        '    picture.Resize(0.5)
        'End If
        'If IO.File.Exists(Application.StartupPath & "\Imagenes\logo.jpg") Then
        '    'load the picture and get the picture index in the workbook
        '    Dim picture As HSSFPicture = DirectCast(patriarch.CreatePicture(anchor, LoadImage(Application.StartupPath & " \Imagenes\logo.jpg", objWorkBook)), HSSFPicture)
        '    'Reset the image to the original size.
        '    picture.Resize(0.5)
        'End If

        objWorkBook.Write(fs)
        fs.Close()
        HelpClass.AbrirDocumento(archivo)

    End Sub


    Public Sub ExportExcelGeneralReleaseMultiple(ByVal odtListDataSource As List(Of DataTable), ByVal ListTitulo As List(Of String), ByVal ListCeldaColNameNFilas As List(Of String), Optional ByVal ListFiltro As List(Of SortedList) = Nothing, Optional ByVal FormatoCabecera As Int32 = 0, Optional ByVal ListNameCombDuplicado As List(Of String) = Nothing, Optional ByVal listSuma As Hashtable = Nothing)
        Try


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

            Dim oFontTitulo As NPOI.SS.UserModel.Font = objWorkBook.CreateFont
            oFontTitulo.Color = NPOI.HSSF.Util.HSSFColor.WHITE.index
            oFontTitulo.Boldweight = NPOI.HSSF.Util.HSSFColor.WHITE.index
            oFontTitulo.FontHeight = fontSizeTitulo

            Estilos_Excel_NPOI(styleFiltro, TipoEstilo.Filtro)


            Estilos_Excel_NPOI(styleTitulo, TipoEstilo.Titulo)

            Estilos_Excel_NPOI(styleNormal, TipoEstilo.Normal)
            Estilos_Excel_NPOI(styleNumber, TipoEstilo.Numero)
            Estilos_Excel_NPOI(styleFecha, TipoEstilo.Fecha)
            Estilos_Excel_NPOI(styleTexto, TipoEstilo.Texto)

            '============================================
            styleFiltro.SetFont(oFontFiltro)
            styleCab.SetFont(oFontCab)
            styleTitulo.SetFont(oFontTitulo)

            styleNormal.SetFont(oFont)
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

                Dim NameHoja As String = ""
                If odtDataSource.TableName.Trim.Length = 0 Then
                    NameHoja = "Hoja" & (FilaTable + 1).ToString.PadLeft(2, "0")
                Else
                    NameHoja = odtDataSource.TableName
                End If
                objWorkSheet = objWorkBook.CreateSheet(NameHoja)


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
                objWorkSheet.GetRow(2).CreateCell(0).CellStyle = styleTitulo
                If ListTitulo IsNot Nothing AndAlso (ListTitulo.Count - 1) >= FilaTable Then
                    objWorkSheet.GetRow(2).GetCell(0).SetCellValue(ListTitulo(FilaTable))
                Else
                    objWorkSheet.GetRow(2).GetCell(0).SetCellValue("")
                End If
                objWorkSheet.AddMergedRegion(New NPOI.SS.Util.Region(2, 0, 2, odtDataSource.Columns.Count - 1))


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


                For j As Integer = 0 To odtDataSource.Columns.Count - 1

                    y = IndiceColum
                    CaptionColumna = odtDataSource.Columns(j).Caption.ToString().Trim()
                    oHasDatosData = DesFormatDato(CaptionColumna)
                    tituloColumna = oHasDatosData(keyTituloColumna)

                    ColorFondoCab = oHasDatosData(keyColorFondo)
                    ColorLetraCab = oHasDatosData(keyColorLetra)

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
                                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCabTemp
                            Else
                                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
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
                                objWorkSheet.GetRow(indice + rowActual).CreateCell(y).CellStyle = styleCab
                            End If
                            objWorkSheet.GetRow(indice + rowActual).GetCell(y).SetCellValue("")
                        End If
                    End If
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
                'If FilaTable > 0 Then
                If ListNameCombDuplicado IsNot Nothing AndAlso (ListNameCombDuplicado.Count - 1) >= FilaTable AndAlso ListNameCombDuplicado(FilaTable) <> "" Then

                    filasComb = ListNameCombDuplicado(FilaTable).Split("|")
                    For Each Item As String In filasComb
                        ColumnaKey = Item.Split(":")
                        oHasListFilasCombinar.Add(ColumnaKey(0), ColumnaKey(1))
                    Next
                End If
                'End If



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

                Dim numFilasActual As Int32 = 0
                For i As Integer = 0 To odtDataSource.Rows.Count - 1
                    IndiceColum = 0
                    NumMaxFilas = 1
                    IsConTamanio = False

                    oHasFormatoFila = DesFormatoFila(dtFilasFormato.Rows(i)(keyNameColFormatoFila))
                    ColorIndex = oHasFormatoFila(keyColorFondo)

                    EsVariasFilas = False
                    numFilasActual = 1
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


                    For j As Integer = 0 To odtDataSource.Columns.Count - 1
                        y = IndiceColum
                        ValorCelda = ("" & odtDataSource.Rows(i).Item(j)).ToString.Trim
                        ValorCelda = ValorCelda.Replace(Chr(13) & Chr(10), Chr(10))
                        CaptionColumna = odtDataSource.Columns(j).Caption.Trim
                        NameColumna = odtDataSource.Columns(j).ColumnName
                        oHasDatosData = DesFormatDato(CaptionColumna)
                        TipoDato = oHasDatosData(keyTipoDato)


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

                    Dim strFormula As String
                    'odtDataSource = odtListDataSource(FilaTable).Copy
                    objWorkSheet.CreateRow(rowActual + odtDataSource.Rows.Count)
                    If Not listSuma Is Nothing Then
                        For Each items As DictionaryEntry In listSuma
                            strFormula = "SUM(" & LetraNumero_NPOI(items.Value) & (ListFiltro(FilaTable).Count) & ":" & LetraNumero_NPOI(items.Value) & odtDataSource.Rows.Count + (ListFiltro(FilaTable).Count) & ")"
                            If odtDataSource.Rows.Count = 0 Then strFormula = "0"
                            objWorkSheet.GetRow(rowActual + odtDataSource.Rows.Count).CreateCell(items.Value - 1).CellStyle = styleNumber
                            objWorkSheet.GetRow(rowActual + odtDataSource.Rows.Count).GetCell(items.Value - 1).CellFormula = (strFormula)
                        Next
                    End If

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
        Catch ex As Exception

        End Try
    End Sub

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


End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class clsOrdenInternaControl

    Private oOIControlDato As SOLMIN_CTZ.DATOS.clsOrdenInternaControl
    Private oDt As DataTable

    Sub New()
        oOIControlDato = New SOLMIN_CTZ.DATOS.clsOrdenInternaControl
    End Sub

    ReadOnly Property Lista_OrdenInterna() As DataTable
        Get
            Return (Me.oDt)
        End Get
    End Property

    Public Function Lista_Ordenes_Internas(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Return oOIControlDato.Lista_OI_Control(pobjOIControl)
    End Function
    ''' <summary>
    ''' Función que permite listar las ordenes internas según  el formato de "Reporte de ordenes Internas"
    ''' </summary>
    ''' <param name="pobjOIControl"></param>
    ''' <returns>Devuelve un datatable con los datos solicitados</returns>
    ''' <remarks>Creado po: Hugo Pérez (X-Treme Tecnologies); Fecha: 10/02/2012</remarks>
    Public Function Lista_Ordenes_Internas_Reporte(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Return oOIControlDato.Lista_OI_Control_Reporte(pobjOIControl)
    End Function

    Public Function Lista_Ordenes_Internas_Resumen(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Return oOIControlDato.Lista_OI_Control_Resumen(pobjOIControl)
    End Function

    Public Function Lista_OI_Control_Cierre(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Return oOIControlDato.Lista_OI_Control_Cierre(pobjOIControl)
    End Function

    Public Function Lista_OI_Control_Detalles(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Return oOIControlDato.Lista_OI_Control_Detalles(pobjOIControl)
    End Function

    Public Function Lista_OI_Control_Detalles_2(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Return oOIControlDato.Lista_OI_Control_Detalles_2(pobjOIControl)
    End Function

    Public Function Lista_OI_Control_Cierre_Seleccion(ByVal sEstado As String, ByVal oDtSeleccion As DataTable) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()
        If sEstado = "-1" Then
            objListaDr = oDtSeleccion.Select("SESTOP like '%' ")
        Else
            objListaDr = oDtSeleccion.Select("SESTOP = '" & sEstado.Trim & "'")
        End If
        objDt = oDtSeleccion.Copy
        objDt.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(0) = objListaDr(lintCont).Item(0)
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDr(4) = objListaDr(lintCont).Item(4)
            objDr(5) = objListaDr(lintCont).Item(5)
            objDr(6) = objListaDr(lintCont).Item(6)
            objDr(7) = objListaDr(lintCont).Item(7)
            objDr(8) = objListaDr(lintCont).Item(8)
            objDr(9) = objListaDr(lintCont).Item(9)
            objDr(10) = objListaDr(lintCont).Item(10)
            objDr(11) = objListaDr(lintCont).Item(11)
            objDr(12) = objListaDr(lintCont).Item(12)
            objDr(13) = objListaDr(lintCont).Item(13)
            objDr(14) = objListaDr(lintCont).Item(14)
            objDr(15) = objListaDr(lintCont).Item(15)
            objDr(16) = objListaDr(lintCont).Item(16)
            objDr(17) = objListaDr(lintCont).Item(17)
            objDr(18) = objListaDr(lintCont).Item(18)
            ' objDr(19) = objListaDr(lintCont).Item(19)
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function

    Public Sub Cierre_OI_CL_SAP119A(ByVal pobjOIControl As OrdenInternaControl)
        Try
            oOIControlDato.Cierre_OI_CL_SAP119A(pobjOIControl)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Anulacion_OI_CL_SAP119B(ByVal pobjOIControl As OrdenInternaControl)
        Try
            oOIControlDato.Anulacion_OI_CL_SAP119B(pobjOIControl)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#Region "CONTROL OI V2"
    Public Function Lista_Ordenes_Internas_Control_V2(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Dim OdtX As DataTable = oOIControlDato.Lista_OI_Control_V2(pobjOIControl)
        Return OdtX
    End Function
    Public Function Lista_OI_ControlResumenV2(ByVal pobjOIControl As OrdenInternaControl) As Hashtable
        Dim htValores As New Hashtable
        Dim lintCont As Integer
        Dim objListaDr1 As DataRow() '-Facturadas 1
        Dim objListaDr2 As DataRow() '-Facturadas 2
        Dim objListaDr3 As DataRow() '-Facturadas 3
        Dim objListaDr4 As DataRow() '-Facturadas 4

        Dim objListaDr5 As DataRow() '-Anulados 1
        Dim objListaDr6 As DataRow() '-Anulados 2
        Dim objListaDr7 As DataRow() '-Anulados 3
        Dim objListaDr8 As DataRow() '-Anulados 4

        Dim objListaDr9 As DataRow()  '-Pendientes 1 
        Dim objListaDr10 As DataRow() '-Pendientes 2
        Dim objListaDr11 As DataRow() '-Pendientes 3
        Dim objListaDr12 As DataRow() '-Pendientes 4
        Dim objListaDr13 As DataRow() '-Pendientes 5 
        Dim objListaDr14 As DataRow() '-Pendientes 6
        Dim objListaDr15 As DataRow() '-Pendientes 7
        Dim objListaDr16 As DataRow() '-Pendientes 7

        'Eliminamos Repetidos
        Dim vista As New DataView(pobjOIControl.oDtOI)
        Dim columnas(11) As String
        columnas(0) = "NOPRCN"
        columnas(1) = "NPLNMT"
        columnas(2) = "NORINS"
        columnas(3) = "NDCMFC"
        columnas(4) = "SESTOP"
        columnas(5) = "ZSTALIB"
        columnas(6) = "ZSTACIE"
        columnas(7) = "ZSTAFI"
        columnas(8) = "GASTO"
        columnas(9) = "VENTA"
        columnas(10) = "CCLORI"
        columnas(11) = "FINCOP"

        pobjOIControl.oDtOI = vista.ToTable(True, columnas)

        'Filtramos el Datatable
        '***FACTURADOS***
        objListaDr1 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTALIB = 'X' ")
        objListaDr2 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTACIE = 'X' ")
        objListaDr3 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTAFI = 'X' ")
        objListaDr4 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC <> 0 AND CCLORI IS NULL")
        '***ANULADOS***
        objListaDr5 = pobjOIControl.oDtOI.Select("SESTOP = '*' AND ZSTALIB = 'X' ")
        objListaDr6 = pobjOIControl.oDtOI.Select("SESTOP = '*' AND ZSTACIE = 'X' ")
        objListaDr7 = pobjOIControl.oDtOI.Select("SESTOP = '*' AND ZSTAFI = 'X' ")
        objListaDr8 = pobjOIControl.oDtOI.Select("SESTOP = '*' AND CCLORI IS NULL ")
        '***PENDIENTES***
        objListaDr9 = pobjOIControl.oDtOI.Select("SESTOP IN ('A','C') AND ZSTALIB = 'X'")
        objListaDr10 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC = 0 AND ZSTALIB = 'X'")

        objListaDr11 = pobjOIControl.oDtOI.Select("SESTOP IN ('A','C') AND ZSTACIE = 'X'")
        objListaDr12 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC = 0 AND ZSTACIE = 'X'")

        objListaDr13 = pobjOIControl.oDtOI.Select("SESTOP IN ('A','C') AND ZSTAFI = 'X'")
        objListaDr14 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC = 0 AND ZSTAFI = 'X'")

        objListaDr15 = pobjOIControl.oDtOI.Select("SESTOP IN ('A','C') AND CCLORI IS NULL")
        objListaDr16 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC = 0 AND CCLORI IS NULL")

        '****************MONTOS FACTURADOS************
        Dim FALI As Double = 0D
        If objListaDr1.Length > 0 Then
            For lintCont = 0 To objListaDr1.Length - 1
                FALI = FALI + objListaDr1(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        Dim FACT As Double = 0D
        If objListaDr2.Length > 0 Then
            For lintCont = 0 To objListaDr2.Length - 1
                FACT = FACT + objListaDr2(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        Dim FACI As Double = 0D
        If objListaDr3.Length > 0 Then
            For lintCont = 0 To objListaDr3.Length - 1
                FACI = FACI + objListaDr3(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        Dim FASE As Double = 0D
        If objListaDr4.Length > 0 Then
            For lintCont = 0 To objListaDr4.Length - 1
                FASE = FASE + objListaDr4(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        '***********MONTOS ANULADOS***************
        Dim ANLI As Double = 0D
        If objListaDr5.Length > 0 Then
            For lintCont = 0 To objListaDr5.Length - 1
                ANLI = ANLI + objListaDr5(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        Dim ANCT As Double = 0D
        If objListaDr6.Length > 0 Then
            For lintCont = 0 To objListaDr6.Length - 1
                ANCT = ANCT + objListaDr6(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        Dim ANCI As Double = 0D
        If objListaDr7.Length > 0 Then
            For lintCont = 0 To objListaDr7.Length - 1
                ANCI = ANCI + objListaDr7(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        Dim ANSE As Double = 0D
        If objListaDr8.Length > 0 Then
            For lintCont = 0 To objListaDr8.Length - 1
                ANSE = ANSE + objListaDr8(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        '***********MONTOS PENDIENTES***************
        Dim PELI As Double = 0D
        If objListaDr9.Length > 0 Then
            For lintCont = 0 To objListaDr9.Length - 1
                PELI = PELI + objListaDr9(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        If objListaDr10.Length > 0 Then
            For lintCont = 0 To objListaDr10.Length - 1
                PELI = PELI + objListaDr10(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        '----------------------------------
        Dim PECT As Double = 0D
        If objListaDr11.Length > 0 Then
            For lintCont = 0 To objListaDr11.Length - 1
                PECT = PECT + objListaDr11(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        If objListaDr12.Length > 0 Then
            For lintCont = 0 To objListaDr12.Length - 1
                PECT = PECT + objListaDr12(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        '----------------------------------
        Dim PECI As Double = 0D
        If objListaDr13.Length > 0 Then
            For lintCont = 0 To objListaDr13.Length - 1
                PECI = PECI + objListaDr13(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        If objListaDr14.Length > 0 Then
            For lintCont = 0 To objListaDr14.Length - 1
                PECI = PECI + objListaDr14(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        '----------------------------------
        Dim PESE As Double = 0D
        If objListaDr15.Length > 0 Then
            For lintCont = 0 To objListaDr15.Length - 1
                PESE = PESE + objListaDr15(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        If objListaDr16.Length > 0 Then
            For lintCont = 0 To objListaDr16.Length - 1
                PESE = PESE + objListaDr16(lintCont).Item(8) 'Sumamos el Gasto
            Next
        End If
        '********MONTOS*********    
        htValores.Add("FALI", FALI)
        htValores.Add("FACT", FACT)
        htValores.Add("FACI", FACI)
        htValores.Add("FASE", FASE)
        Dim FATO As Double = FALI + FACT + FACI + FASE
        htValores.Add("FATO", FATO)
        '-------------------
        htValores.Add("ANLI", ANLI)
        htValores.Add("ANCT", ANCT)
        htValores.Add("ANCI", ANCI)
        htValores.Add("ANSE", ANSE)
        Dim ANTO As Double = ANLI + ANCT + ANCI + ANSE
        htValores.Add("ANTO", ANTO)
        '-------------------
        htValores.Add("PELI", PELI)
        htValores.Add("PECT", PECT)
        htValores.Add("PECI", PECI)
        htValores.Add("PESE", PESE)
        Dim PETO As Double = PELI + PECT + PECI + PESE
        htValores.Add("PETO", PETO)
        '-------------------
        '******CANTIDADES******
        htValores.Add("PELIcnt", objListaDr9.Length + objListaDr10.Length)
        htValores.Add("PECTcnt", objListaDr11.Length + objListaDr12.Length)
        htValores.Add("PECIcnt", objListaDr13.Length + objListaDr14.Length)
        htValores.Add("PESEcnt", objListaDr15.Length + objListaDr16.Length)
        Dim PETOcnt As Integer = objListaDr9.Length + objListaDr10.Length + objListaDr11.Length + objListaDr12.Length + _
                                objListaDr13.Length + objListaDr14.Length + objListaDr15.Length + objListaDr16.Length
        htValores.Add("PETOcnt", PETOcnt)
        '-------------------
        htValores.Add("FALIcnt", objListaDr1.Length)
        htValores.Add("FACTcnt", objListaDr2.Length)
        htValores.Add("FACIcnt", objListaDr3.Length)
        htValores.Add("FASEcnt", objListaDr4.Length)
        Dim FATOcnt As Integer = objListaDr1.Length + objListaDr2.Length + objListaDr3.Length + objListaDr4.Length
        htValores.Add("FATOcnt", FATOcnt)
        '-------------------
        htValores.Add("ANLIcnt", objListaDr5.Length)
        htValores.Add("ANCTcnt", objListaDr6.Length)
        htValores.Add("ANCIcnt", objListaDr7.Length)
        htValores.Add("ANSEcnt", objListaDr8.Length)
        Dim ANTOcnt As Integer = objListaDr5.Length + objListaDr6.Length + objListaDr7.Length + objListaDr8.Length
        htValores.Add("ANTOcnt", ANTOcnt)
        Return htValores
    End Function

    Public Function Lista_OI_Control_CierreV2(ByVal pobjOIControl As OrdenInternaControl) As OrdenInternaControl
        Dim lintCont As Integer
        Dim objDr As DataRow

        Dim objListaDr1 As DataRow()
        Dim objListaDr2 As DataRow()
        Dim objListaDr3 As DataRow()
        Dim objListaDr4 As DataRow()
        Dim oDtCrtlCierre As DataTable = pobjOIControl.oDtOI.Copy
        'Eliminamos Repetidos
        Dim vista As New DataView(oDtCrtlCierre)
        Dim columnas(7) As String
        columnas(0) = "NOPRCN"
        columnas(1) = "FINCOP"
        columnas(2) = "NPLNMT"
        columnas(3) = "SESTOP"
        columnas(4) = "NDCMFC"
        columnas(5) = "CCLORI"
        columnas(6) = "NORINS"
        columnas(7) = "ZSTALIB"

        ' pobjOIControl.oDtOI = vista.ToTable(True, columnas)
        oDtCrtlCierre = vista.ToTable(True, columnas)
        'Filtramos el Datatable
        'objListaDr1 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTALIB = 'X' ")
        'objListaDr2 = pobjOIControl.oDtOI.Select("SESTOP = 'F' AND NDCMFC <> 0 AND CCLORI IS NULL ")
        'objListaDr3 = pobjOIControl.oDtOI.Select("SESTOP = '*' AND ZSTALIB = 'X' ")
        'objListaDr4 = pobjOIControl.oDtOI.Select("SESTOP = '*' AND CCLORI IS NULL ")

        objListaDr1 = oDtCrtlCierre.Select("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTALIB = 'X' ")
        objListaDr2 = oDtCrtlCierre.Select("SESTOP = 'F' AND NDCMFC <> 0 AND CCLORI IS NULL ")
        objListaDr3 = oDtCrtlCierre.Select("SESTOP = '*' AND ZSTALIB = 'X' ")
        objListaDr4 = oDtCrtlCierre.Select("SESTOP = '*' AND CCLORI IS NULL ")
        Dim objDt As DataTable
        'objDt = pobjOIControl.oDtOI.Copy
        objDt = oDtCrtlCierre.Copy
        objDt.Rows.Clear()
        '---8-COLUMNAS---  NRO OPERACION / FECHA / PLANEAMIENTO / ESTADO / NRO DOCUMENTO / TIPO / ORDEN INTERNA / FASE LIBERADO
        If objListaDr1.Length > 0 Then
            For lintCont = 0 To objListaDr1.Length - 1
                objDr = objDt.NewRow
                For j As Integer = 0 To objDt.Columns.Count - 1
                    objDr(j) = objListaDr1(lintCont).Item(j)
                Next
                objDt.Rows.Add(objDr)
            Next
        End If
        If objListaDr2.Length > 0 Then
            For lintCont = 0 To objListaDr2.Length - 1
                objDr = objDt.NewRow
                For j As Integer = 0 To objDt.Columns.Count - 1
                    objDr(j) = objListaDr2(lintCont).Item(j)
                Next
                objDt.Rows.Add(objDr)
            Next
        End If
        If objListaDr3.Length > 0 Then
            For lintCont = 0 To objListaDr3.Length - 1
                objDr = objDt.NewRow
                For j As Integer = 0 To objDt.Columns.Count - 1
                    objDr(j) = objListaDr3(lintCont).Item(j)
                Next
                objDt.Rows.Add(objDr)
            Next
        End If
        If objListaDr4.Length > 0 Then
            For lintCont = 0 To objListaDr4.Length - 1
                objDr = objDt.NewRow
                For j As Integer = 0 To objDt.Columns.Count - 1
                    objDr(j) = objListaDr4(lintCont).Item(j)
                Next
                objDt.Rows.Add(objDr)
            Next
        End If
        Dim oOIFiltrado As New OrdenInternaControl
        oOIFiltrado.oDtOI = objDt
        oOIFiltrado.PNFACTURADOS = objListaDr1.Length + objListaDr2.Length
        oOIFiltrado.PNANULADOS = objListaDr3.Length + objListaDr4.Length
        Return oOIFiltrado
    End Function

    Public Function Lista_OI_Control_Cierre_SeleccionV2(ByVal sEstado As String, ByVal oDtSeleccion As DataTable) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()
        If sEstado = "-1" Then
            objListaDr = oDtSeleccion.Select("SESTOP like '%' ")
        Else
            objListaDr = oDtSeleccion.Select("SESTOP = '" & sEstado.Trim & "'")
        End If
        objDt = oDtSeleccion.Copy
        objDt.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(0) = objListaDr(lintCont).Item(0)
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDr(4) = objListaDr(lintCont).Item(4)
            objDr(5) = objListaDr(lintCont).Item(5)
            objDr(6) = objListaDr(lintCont).Item(6)
            objDr(7) = objListaDr(lintCont).Item(7)
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function

    Public Function Lista_OI_Control_Detalles_V2(ByVal pobjOIControl As OrdenInternaControl) As DataTable
        Dim lintCont As Integer
        Dim objDr As DataRow
        Dim objListaDr As DataRow() '-Generico
        Dim objListaDr2 As DataRow() '-Generico para Pendientes
        Dim sentencia As New List(Of String)
        Dim flag As Boolean = False
        '***FACTURADOS***
        sentencia.Add("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTALIB = 'X' ")
        sentencia.Add("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTACIE = 'X' ")
        sentencia.Add("SESTOP = 'F' AND NDCMFC <> 0 AND ZSTAFI = 'X' ")
        sentencia.Add("SESTOP = 'F' AND NDCMFC <> 0 AND CCLORI IS NULL")
        '***ANULADOS***
        sentencia.Add("SESTOP = '*' AND ZSTALIB = 'X' ")
        sentencia.Add("SESTOP = '*' AND ZSTACIE = 'X' ")
        sentencia.Add("SESTOP = '*' AND ZSTAFI = 'X' ")
        sentencia.Add("SESTOP = '*' AND CCLORI IS NULL ")
        '***PENDIENTES***
        sentencia.Add("SESTOP IN ('A','C') AND ZSTALIB = 'X'")
        sentencia.Add("SESTOP = 'F' AND NDCMFC = 0 AND ZSTALIB = 'X'")
        sentencia.Add("SESTOP IN ('A','C') AND ZSTACIE = 'X'")
        sentencia.Add("SESTOP = 'F' AND NDCMFC = 0 AND ZSTACIE = 'X'")
        sentencia.Add("SESTOP IN ('A','C') AND ZSTAFI = 'X'")
        sentencia.Add("SESTOP = 'F' AND NDCMFC = 0 AND ZSTAFI = 'X'")
        sentencia.Add("SESTOP IN ('A','C') AND CCLORI IS NULL")
        sentencia.Add("SESTOP = 'F' AND NDCMFC = 0 AND CCLORI IS NULL")

        'Eliminamos Repetidos
        Dim vista As New DataView(pobjOIControl.oDtOI)
        Dim columnas(11) As String
        columnas(0) = "NOPRCN"
        columnas(1) = "NPLNMT"
        columnas(2) = "NORINS"
        columnas(3) = "NDCMFC"
        columnas(4) = "SESTOP"
        columnas(5) = "ZSTALIB"
        columnas(6) = "ZSTACIE"
        columnas(7) = "ZSTAFI"
        columnas(8) = "GASTO"
        columnas(9) = "VENTA"
        columnas(10) = "CCLORI"
        columnas(11) = "FINCOP"

        pobjOIControl.oDtOI = vista.ToTable(True, columnas)
        objListaDr2 = Nothing
        'Filtramos el Datatable
        Select Case pobjOIControl.ESTADO_DETALLE
            Case "FALI"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(0))
            Case "FACT"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(1))
            Case "FACI"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(2))
            Case "FASE"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(3))
            Case "ANLI"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(4))
            Case "ANCT"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(5))
            Case "ANCI"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(6))
            Case "ANSE"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(7))
            Case "PELI"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(8))
                objListaDr2 = pobjOIControl.oDtOI.Select(sentencia.Item(9))
                flag = True
            Case "PECT"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(10))
                objListaDr2 = pobjOIControl.oDtOI.Select(sentencia.Item(11))
                flag = True
            Case "PECI"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(12))
                objListaDr2 = pobjOIControl.oDtOI.Select(sentencia.Item(13))
                flag = True
            Case "PESE"
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(14))
                objListaDr2 = pobjOIControl.oDtOI.Select(sentencia.Item(15))
                flag = True
            Case Else
                objListaDr = pobjOIControl.oDtOI.Select(sentencia.Item(0))
        End Select


        Dim objDt As DataTable
        objDt = pobjOIControl.oDtOI.Copy
        objDt.Rows.Clear()
        '---8-COLUMNAS---  NRO OPERACION / FECHA / PLANEAMIENTO / ESTADO / NRO DOCUMENTO / TIPO / ORDEN INTERNA / FASE LIBERADO
        If objListaDr.Length > 0 Then
            For lintCont = 0 To objListaDr.Length - 1
                objDr = objDt.NewRow
                For j As Integer = 0 To objDt.Columns.Count - 1
                    objDr(j) = objListaDr(lintCont).Item(j)
                Next
                objDt.Rows.Add(objDr)
            Next
        End If
        If flag = True Then
            If objListaDr2.Length > 0 Then
                For lintCont = 0 To objListaDr2.Length - 1
                    objDr = objDt.NewRow
                    For j As Integer = 0 To objDt.Columns.Count - 1
                        objDr(j) = objListaDr2(lintCont).Item(j)
                    Next
                    objDt.Rows.Add(objDr)
                Next
            End If
        End If
        Return objDt
    End Function
#End Region
End Class

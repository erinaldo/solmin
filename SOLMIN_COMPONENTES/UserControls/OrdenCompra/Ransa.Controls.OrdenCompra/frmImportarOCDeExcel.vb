Imports Ransa.DAO.OrdenCompra
Imports RANSA.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.DATA


Public Class frmImportarOCDeExcel
#Region "Atributos"
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private olbeDetOc As New List(Of beOrdenCompra)
    Private obj_SheetName As String
    Private _dblCodCliente As Decimal
    Private _strUsuario As String

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

    Private Sub btnExcelCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelCabecera.Click
        Dim NumSheets As Integer
        Dim NomSheets As String
        Dim i As Integer
        Dim n As Integer

        'No Seleccionar Multiples Archivos 
        Me.OpenFileDialog.Multiselect = False
        'EL DIRECTORIO INICIAL ES MIS DOCUMENTOS
        Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal))
        'FILTRO LAS EXTENSIONES QUE QUIERO MOSTRAR
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
            n = 0
            i = 0
            obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
            Do Until i = 1 Or n = NmCount.Maximum
                n = n + 1
                If Trim(obj_Worksheet.Cells(n, 1).value) = "" Then
                    i = 1
                End If
            Loop
            NmCount.Value = n
        End If
    End Sub

    Private Sub btnAbrirCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirCabecera.Click
        Try
            Dim i As Integer
            Dim Columnas As Integer = 12
            ' -- Verifica si existe el archivo   
            If Len(Dir(Me.TxtRutaXlsCabecera.Text)) = 0 Then
                MsgBox("No se ha encontrado el archivo: " & Me.TxtRutaXlsCabecera.Text, vbCritical)
                Exit Sub
            End If
            '===================================================================
            ' -- RUTINA EXCEL   Instancia Excel  
            If obj_Excel Is Nothing Then
                obj_Excel = CreateObject("Excel.Application")
                obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsCabecera.Text)
            End If
            ' -- Referencia la Hoja, por defecto la hoja activa  
            If obj_SheetName = vbNullString Then
                obj_Worksheet = obj_Workbook.ActiveSheet
            Else
                obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
            End If
            '==================Crear lista de Objeto de tipo OC beOrdenDeCOMPRA
            Dim olbeOrdenDeCompra As New List(Of beOrdenCompra)
            Dim olbeOrdenDeCompraMatch As List(Of beOrdenCompra)
            Dim obeOrdenDeCompra As New beOrdenCompra
            Dim strReferencia As String = ""
            For i = 1 To NmCount.Value - 2
                obeOrdenDeCompra = New beOrdenCompra
                olbeOrdenDeCompraMatch = New List(Of beOrdenCompra)
                strOC = obj_Worksheet.Cells(i + 1, 5).Value
                strRef = ""

                obeOrdenDeCompra.PSNREFCL = obj_Worksheet.Cells(i + 1, 1).Value.ToString.Trim

                obeOrdenDeCompra.PSTPOOCM = obj_Worksheet.Cells(i + 1, 6).Value.ToString.Trim 'Tipo de OC

                obeOrdenDeCompra.PSTRFRN = ("" & obj_Worksheet.Cells(i + 1, 3).Value & "")
                obeOrdenDeCompra.PSTCMAEM = ("" & obj_Worksheet.Cells(i + 1, 12).Value & "") 'Cod. De Ruta De Aprobación
                obeOrdenDeCompra.PSNORCML = obj_Worksheet.Cells(i + 1, 5).Value 'OC
                obeOrdenDeCompra.PNFROCMP = obj_Worksheet.Cells(i + 1, 9).Value 'fecha de entrega
                obeOrdenDeCompra.PSREFDO1 = ("" & obj_Worksheet.Cells(i + 1, 10).Value & "") 'cuenta contable
                obeOrdenDeCompra.PSCPRPCL = ("" & obj_Worksheet.Cells(i + 1, 7).Value & "") 'codigo de proveedor de cliente 
                obeOrdenDeCompra.PSTNOMCOM = ("" & obj_Worksheet.Cells(i + 1, 8).Value & "") '

                If obj_Worksheet.Cells(i + 1, 4).Value.ToString.Trim = "300" OrElse obj_Worksheet.Cells(i + 1, 4).Value.ToString.Trim = "324" OrElse obj_Worksheet.Cells(i + 1, 4).Value.ToString.Trim = "331" OrElse _
               obj_Worksheet.Cells(i + 1, 4).Value.ToString.Trim = "400" OrElse obj_Worksheet.Cells(i + 1, 4).Value.ToString.Trim = "427" Then
                    obeOrdenDeCompra.PSLOTE = obj_Worksheet.Cells(i + 1, 10).Value.ToString.Trim.Substring(0, 4)
                Else
                    obeOrdenDeCompra.PSLOTE = obj_Worksheet.Cells(i + 1, 4).Value
                End If

                Dim obrGeneral As New brGeneral
                Dim obeGeneral As New beGeneral
                Dim olbeGeneral As New List(Of beGeneral)
                With obeGeneral
                    .PSNLTECL = obeOrdenDeCompra.PSLOTE
                End With
                olbeGeneral = obrGeneral.LotesDeEntregaXCliente(obeGeneral)
                If olbeGeneral.Count > 0 Then
                    obeOrdenDeCompra.PNCCLNT = olbeGeneral.Item(0).PNCCLNT
                Else
                    obeOrdenDeCompra.PNCCLNT = 0
                End If
                If obeOrdenDeCompra.PNCCLNT = 0 Then
                    HelpClass.MsgBox("No se puede identificar a que cliente pertenece el código de Lote : " & obeOrdenDeCompra.PSLOTE, MessageBoxIcon.Information)
                    Exit Sub
                End If
                obeOrdenDeCompra.PNCPRVCL = BuscarProveedor(obj_Worksheet.Cells(i + 1, 7).Value, obeOrdenDeCompra.PSNORCML, obeOrdenDeCompra.PNCCLNT)

                obeOrdenDeCompra.PSNRUCPR = Val(obj_Worksheet.Cells(i + 1, 14).Value) 'Ruc del proveedor se necesita para saber si es locar o importacion
                If obeOrdenDeCompra.PSNRUCPR.ToString.Length > 8 Then
                    obeOrdenDeCompra.PSTTINTC = "LOC"
                Else
                    obeOrdenDeCompra.PSTTINTC = "FOB"
                End If
                If obeOrdenDeCompra.PNCPRVCL = 0 Then
                    Dim obeProveedor As New beProveedor
                    With obeProveedor
                        .PNCCLNT = obeOrdenDeCompra.PNCCLNT
                        .PSCPRPCL = obj_Worksheet.Cells(i + 1, 7).Value 'Cod proveedor cliente
                        If ("" & obj_Worksheet.Cells(i + 1, 13).Value & "").ToString.Trim.Length > 30 Then
                            .PSTPRVCL = ("" & obj_Worksheet.Cells(i + 1, 13).Value & "").ToString.Trim.Substring(0, 30) 'Descripcion del proveedor
                            .PSTPRCL1 = ("" & obj_Worksheet.Cells(i + 1, 13).Value & "").ToString.Trim.Substring(30, ("" & obj_Worksheet.Cells(i + 1, 13).Value & "").ToString.Trim.Length - 30) 'Descripcion extedida del proveedor
                        Else
                            .PSTPRVCL = ("" & obj_Worksheet.Cells(i + 1, 13).Value & "").ToString.Trim
                        End If
                        'Ruc del proveedor
                        If IsNumeric(obj_Worksheet.Cells(i + 1, 14).Value()) Then
                            .PNNRUCPR = obj_Worksheet.Cells(i + 1, 14).Value()
                        Else
                            .PNNRUCPR = 0
                        End If


                        .PSCUSCRT = strUsuario
                    End With
                    obeOrdenDeCompra.PNCPRVCL = GrabarProveedoCliente(obeProveedor)
                    If obeOrdenDeCompra.PNCPRVCL = 0 Then
                        Exit Sub
                    End If
                End If
                obeOrdenDeCompra.PNFORCML = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)
                obeOrdenDeCompra.PNFSOLIC = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)


                olbeOrdenDeCompra.Add(obeOrdenDeCompra)
            Next
            Dim oucOrdena As UCOrdena(Of beOrdenCompra)
            oucOrdena = New UCOrdena(Of beOrdenCompra)("PSNORCML", UCOrdena(Of beOrdenCompra).TipoOrdenacion.Ascendente)
            olbeOrdenDeCompra.Sort(oucOrdena)
            For intRow As Integer = olbeOrdenDeCompra.Count - 1 To 1 Step -1
                If olbeOrdenDeCompra.Item(intRow).PSNORCML = olbeOrdenDeCompra.Item(intRow - 1).PSNORCML Then
                    olbeOrdenDeCompra.RemoveAt(intRow)
                End If
            Next
            Me.dgExcelCabecera.AutoGenerateColumns = False
            Me.dgExcelCabecera.DataSource = olbeOrdenDeCompra
            Call Limpiar()
            If (Me.dgExcelCabecera.Rows.Count > 0) Then
                btnExcelDetalle.Enabled = True
                brnAbrirDetalle.Enabled = True
            Else
                btnExcelDetalle.Enabled = False
                brnAbrirDetalle.Enabled = False
            End If
            brnAbrirDetalle.Enabled = True
            btnExcelDetalle.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Call Limpiar()
        End Try

    End Sub

#Region "Metodo"

#Region "Búsqueda de Item"
    Private strOC As String = ""
    Private strRef As String = ""
    Private strNrRef As String = ""
    Private dblNrItem As Decimal = 0

    Private MatchOrdenDeCompra As New Predicate(Of beOrdenCompra)(AddressOf BuscarOrdendeCompra)

    Public Function BuscarOrdendeCompra(ByVal pbeOrdenCompra As beOrdenCompra) As Boolean
        If (pbeOrdenCompra.PSNORCML.Trim.Equals(strOC.Trim)) Then
            strRef = pbeOrdenCompra.PSNREFCL
            Return True
        Else
            Return False
        End If
    End Function

    Private MatchOcBusquedaRef As New Predicate(Of beOrdenCompra)(AddressOf BuscarNrRef)

    Public Function BuscarNrRef(ByVal pbeOrdenCompra As beOrdenCompra) As Boolean
        If (pbeOrdenCompra.PSNREFCL.Trim.Equals(strNrRef)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private MatchBuscarItemRepetidos As New Predicate(Of beOrdenCompra)(AddressOf BuscarItemRepetidos)

    Public Function BuscarItemRepetidos(ByVal pbeOrdenCompra As beOrdenCompra) As Boolean
        If (pbeOrdenCompra.PSNORCML.Trim.Equals(strOC.Trim)) And pbeOrdenCompra.PNNRITOC = dblNrItem Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

    Private Function ClienteDeOCxLote(ByVal strLote As String) As Decimal

        Select Case strLote.Trim
            Case "B1AB301", "B8TRA", "B1ABTRA"
                Return 30507
            Case "B56001", "BGC001", "B88TRA", "B56TRA", "B88TRP"
                Return 11731
            Case Else
                Return 0
        End Select
    End Function

    Private Sub Limpiar()
        obj_Workbook = Nothing
        obj_Excel = Nothing
        obj_Worksheet = Nothing
    End Sub

    ''' <summary>
    ''' Busca el proveedor de acuerdo al código del proveedor del cliente
    ''' </summary>
    ''' <param name="dblCodProvCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function BuscarProveedor(ByVal strCodProvCliente As String, ByVal strOrdeCompra As String, ByVal decCliente As Decimal) As Decimal
        'se busca los proveedores del cliente plus
        Dim decCodProv As Decimal = 0
        Dim obrProveedor As New brProveedor
        Dim obeProveedor As New beProveedor
        obeProveedor.PNCCLNT = decCliente
        obeProveedor.PSCPRPCL = strCodProvCliente
        decCodProv = obrProveedor.ObtenerCodigoProveedorPorCodCliente(obeProveedor)
        If decCodProv = 0 Then
            ' HelpClass.MsgBox("No existe Proveedor registrado para la Oc " & strOrdeCompra, MessageBoxIcon.Warning)
            Return 0
        End If
        Return decCodProv
    End Function

    ''' <summary>
    ''' 'Graba proveedor de cliente
    ''' </summary>
    ''' <param name="obeProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GrabarProveedoCliente(ByVal obeProveedor As beProveedor) As Decimal
        'se busca los proveedores del cliente plus
        Dim decCodProv As Decimal = 0
        Dim obrProveedor As New brProveedor
        decCodProv = obrProveedor.GrabarProveedorDeCliente(obeProveedor)
        If decCodProv = 0 Then
            HelpClass.ErrorMsgBox()
            Return 0
        End If
        Return decCodProv
    End Function


#End Region


    Private Sub btnExcelDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelDetalle.Click
        Dim NumSheets As Integer
        Dim NomSheets As String
        Dim i As Integer
        Dim n As Integer
        'No Seleccionar Multiples Archivos 
        Me.OpenFileDialog.Multiselect = False
        'EL DIRECTORIO INICIAL ES MIS DOCUMENTOS
        Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal))
        'FILTRO LAS EXTENSIONES QUE QUIERO MOSTRAR
        Me.OpenFileDialog.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"
        If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then ' SI DIO CLICK EN ACEPTAR
            Me.TxtRutaXlsDetalle.Text = Me.OpenFileDialog.FileName
            obj_Excel = CreateObject("Excel.Application")
            obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsDetalle.Text)
            NumSheets = obj_Workbook.sheets.count()
            CmbXlsHoja1.Items.Clear()
            For i = 1 To NumSheets
                NomSheets = obj_Workbook.Sheets.Item(i).Name
                CmbXlsHoja1.Items.Add(NomSheets)
            Next
            CmbXlsHoja1.SelectedIndex = 0
            ' Cuenta los datos validos
            n = 0
            i = 0
            obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
            Do Until i = 1 Or n = NmCount1.Maximum
                n = n + 1
                If Trim(obj_Worksheet.Cells(n, 1).value) = "" Then
                    i = 1
                End If
            Loop
            NmCount1.Value = n
        End If
        ' Me.dgExcelCabecera_CellClick(Nothing, Nothing)
    End Sub

    Private Sub brnAbrirDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnAbrirDetalle.Click
        Try
            Dim n As Integer
            Dim i As Integer
            Dim j As Integer
            Dim Columnas As Integer = 12
            ' -- Verifica si existe el archivo   
            If Len(Dir(Me.TxtRutaXlsDetalle.Text)) = 0 Then
                MsgBox("No se ha encontrado el archivo: " & Me.TxtRutaXlsDetalle.Text, vbCritical)
                Exit Sub
            End If
            '===================================================================
            ' -- RUTINA EXCEL   Instancia Excel  
            If obj_Excel Is Nothing Then
                obj_Excel = CreateObject("Excel.Application")
                obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsDetalle.Text)
            End If
            ' -- Referencia la Hoja, por defecto la hoja activa  
            If obj_SheetName = vbNullString Then
                obj_Worksheet = obj_Workbook.ActiveSheet
            Else
                obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
            End If
            olbeDetOc = New List(Of beOrdenCompra)
            Dim obeOrdenCompra As beOrdenCompra
            For i = 1 To NmCount1.Value - 2
                obeOrdenCompra = New beOrdenCompra
                With obeOrdenCompra
                    '======================
                    obeOrdenCompra.PSNORCML = obj_Worksheet.Cells(i + 1, 3).Value 'Oc
                    If IsNumeric(obj_Worksheet.Cells(i + 1, 5).Value) Then 'DOC_NROLINEA'
                        obeOrdenCompra.PNNRITOC = obj_Worksheet.Cells(i + 1, 5).Value
                    End If

                    obeOrdenCompra.PSTIPLIN = obj_Worksheet.Cells(i + 1, 6).Value 'DOC_TIPOLINEA

                    If obeOrdenCompra.PSTIPLIN.Trim.Equals("J") Then
                        obeOrdenCompra.PSFLGPEN = "*"
                    End If
                    obeOrdenCompra.PSTCITCL = ("" & obj_Worksheet.Cells(i + 1, 7).Value & "") 'DOC_CODIGOITEM'
                    obeOrdenCompra.PSTDITES = ValidarCaracter.validaCaracter("" & obj_Worksheet.Cells(i + 1, 8).Value & "", obeOrdenCompra.PSERROR) 'DOC_DESCRIPCIONITEM'
                    If IsNumeric(obj_Worksheet.Cells(i + 1, 9).Value) Then 'DOC_CANTIDADITEM'
                        obeOrdenCompra.PNQCNTIT = Decimal.Parse(obj_Worksheet.Cells(i + 1, 9).Value)
                    End If
                    obeOrdenCompra.PSTUNDIT = obj_Worksheet.Cells(i + 1, 10).Value 'DOC_CODUNIDMEDIDA'
                    obeOrdenCompra.PSTDITIN = ""
                    obeOrdenCompra.PNFMPDME = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)
                    obeOrdenCompra.PSTLUGEN = ""
                    obeOrdenCompra.PSTCTCST = ""
                    obeOrdenCompra.PNIVUNIT = 0
                    obeOrdenCompra.PNIVTOIT = 0
                    obeOrdenCompra.PSTCITPR = ""
                    obeOrdenCompra.PSCPTDAR = ""
                    obeOrdenCompra.PNFMPIME = 0
                    obeOrdenCompra.PSTLUGOR = ""
                    obeOrdenCompra.PNQTOLMIN = 0
                    obeOrdenCompra.PNQTOLMAX = 0
                    olbeDetOc.Add(obeOrdenCompra)
                    strOC = obeOrdenCompra.PSNORCML
                    dblNrItem = obeOrdenCompra.PNNRITOC
                    If olbeDetOc.FindAll(MatchBuscarItemRepetidos).Count > 1 Then
                        HelpClass.MsgBox("Error: La Orden" & obeOrdenCompra.PSNORCML & "Cuenta con uno o más Items repetidos", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If Not obeOrdenCompra.PSERROR.Trim.Equals("") Then
                        HelpClass.MsgBox("Error: " & obeOrdenCompra.PSERROR, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    '===========================================
                End With
            Next
            Me.dgExcelDetalle.AutoGenerateColumns = False
            Me.dgExcelCabecera.RefreshEdit()
            dgExcelCabecera_SelectionChanged(Nothing, Nothing)
            Call Limpiar()
            tsbGuardar.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Call Limpiar()
        End Try
    End Sub

    Private Sub dgExcelCabecera_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgExcelCabecera.SelectionChanged
        strOC = Me.dgExcelCabecera.CurrentRow.DataBoundItem.PSNORCML
        Me.dgExcelDetalle.AutoGenerateColumns = False
        Me.dgExcelDetalle.DataSource = olbeDetOc.FindAll(MatchOrdenDeCompra)
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If Me.dgExcelCabecera.Rows.Count > 0 Then GrabarOc()
    End Sub

    Private Sub GrabarOc()
        Try
            Dim obrOrdeDeCopra As New brOrdenDeCompra
            Dim olbeOcTem As New List(Of beOrdenCompra)
            For Each obeOc As beOrdenCompra In Me.dgExcelCabecera.DataSource
                obeOc.PSSESTRG = "A"
                obeOc.PSCUSCRT = strUsuario
                obeOc.PSCULUSA = strUsuario
                If obrOrdeDeCopra.InsertarOrdenDeCompra(obeOc) = 1 Then
                    olbeOcTem.Clear()
                    strOC = obeOc.PSNORCML
                    olbeOcTem = olbeDetOc.FindAll(MatchOrdenDeCompra)
                    For Each obeDetOc As beOrdenCompra In olbeOcTem
                        obeDetOc.PSSESTRG = "A"
                        obeDetOc.PNCCLNT = obeOc.PNCCLNT
                        obeDetOc.PSCUSCRT = strUsuario
                        obeDetOc.PSCULUSA = strUsuario
                        obeDetOc.PSTRFRN = obeOc.PSTRFRN
                        obeDetOc.PNFMPDME = obeOc.PNFROCMP
                        obeDetOc.PNFMPIME = obeOc.PNFROCMP
                        '    obeDetOc.PSTIPLIN = obeOc.PSTIPLIN
                        'el lote se graba en el lugar de entrega
                        obeDetOc.PSTLUGEN = obeOc.PSLOTE
                        Dim obrGeneral As New brGeneral
                        Dim obeGeneral As New beGeneral
                        With obeGeneral
                            .PNCCLNT = obeOc.PNCCLNT
                            .PSNLTECL = obeOc.PSLOTE
                        End With
                        obeGeneral = obrGeneral.ListaLotesDeEntrega(obeGeneral).Item(0)
                        obeDetOc.PSTRFRNA = obeGeneral.PSNLTECL.Trim
                        obeDetOc.PSTLUGEN = obeGeneral.PSTLTECL.Trim

                        If obrOrdeDeCopra.InsertarDetalleOrdenDeCompra(obeDetOc) = 0 Then
                            HelpClass.ErrorMsgBox()
                            Exit Sub
                        End If
                    Next
                Else
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
            Next
            HelpClass.MsgBox("Registro Satisfactorio.")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
        
    End Sub




    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    
End Class

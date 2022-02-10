Imports Ransa.DAO.OrdenCompra
Imports RANSA.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.DATA


Public Class frmImportarCIExcel_PPC
#Region "Atributos"
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private olbeDetOc As New List(Of beOrdenCompra)
    Private obj_SheetName As String
    Private NmCount As Decimal = 0D

    Private _dblCodCliente As Decimal
    Public Property dblCodCliente() As Decimal
        Get
            Return _dblCodCliente
        End Get
        Set(ByVal value As Decimal)
            _dblCodCliente = value
        End Set
    End Property

    Private _strUsuario As String
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


    Private Sub btnAbrirCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirCabecera.Click
        Try

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

            Dim ListColumna As New SortedList
            ListColumna.Add(1, "Documento compras")
            ListColumna.Add(2, "Posición")
            ListColumna.Add(3, "Imputación actual")
            ListColumna.Add(4, "Cuenta de mayor")
            ListColumna.Add(5, "Centro de coste")
            ListColumna.Add(6, "Elemento PEP")
            ListColumna.Add(7, "Orden")
            ListColumna.Add(8, "Activo fijo")
            ListColumna.Add(9, "Subnúmero")
            ListColumna.Add(10, "Doc.comercial")
            ListColumna.Add(11, "Posición")
            ListColumna.Add(12, "Grafo")
            ListColumna.Add(13, "Operación")
            ListColumna.Add(14, "Cl.documento compras")
            ListColumna.Add(15, "Tipo doc.compras")
            ListColumna.Add(16, "Grupo de compras")
            ListColumna.Add(17, "Historial pedido/Docu.orden entrega")
            ListColumna.Add(18, "Fecha documento")
            ListColumna.Add(19, "Proveedor/Centro suministrador")
            ListColumna.Add(20, "Material")
            ListColumna.Add(21, "Texto breve")
            ListColumna.Add(22, "Grupo de artículos")
            ListColumna.Add(23, "Indicador de borrado")
            ListColumna.Add(24, "Tipo de posición")
            ListColumna.Add(25, "Tipo de imputación")
            ListColumna.Add(26, "Centro")
            ListColumna.Add(27, "Almacén")
            ListColumna.Add(28, "Cantidad de pedido")
            ListColumna.Add(29, "Unidad medida pedido")
            ListColumna.Add(30, "Precio neto")
            ListColumna.Add(31, "Moneda")
            ListColumna.Add(32, "Cantidad de imputación")
            ListColumna.Add(33, "Cantidad base")
            ListColumna.Add(34, "Cantidad de posiciones")

            Dim InicioFila As Int32 = 0
            Dim Encontrado As Boolean = False
            Dim msgEncontrado As String = ""
            Dim Celda As String = ""
            Dim i As Integer
            Try
                For i = 1 To NmCount - 1
                    If ("" & obj_Worksheet.Cells(i, 1).Value).ToString.Trim = "Documento compras" Then
                        InicioFila = i + 2
                        For Each item As DictionaryEntry In ListColumna
                            Celda = ("" & obj_Worksheet.Cells(i, item.Key).Value).ToString.Trim
                            If Celda = item.Value Then
                                Encontrado = True
                            Else
                                Encontrado = False
                                Exit For
                            End If
                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception
                Encontrado = False
                msgEncontrado = ex.Message
            End Try

            If Encontrado = False Then
                Dim muestrMensaje As String = "Estructura no válida"
                If msgEncontrado.Length > 0 Then
                    muestrMensaje = muestrMensaje & Chr(13) & msgEncontrado
                End If
                MessageBox.Show(muestrMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Limpiar()
                Exit Sub
            End If

            For i = InicioFila To NmCount + 1
                obeOrdenDeCompra = New beOrdenCompra
                olbeOrdenDeCompraMatch = New List(Of beOrdenCompra)

                obeOrdenDeCompra.PNCCLNT = _dblCodCliente

                Dim OrdenCompra As String = "" & obj_Worksheet.Cells(i, 1).Value
                If OrdenCompra.Length > 35 Then
                    MessageBox.Show("Orden de compra no válido, máximo permitido 35", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                    Limpiar()
                Else
                    obeOrdenDeCompra.PSNORCML = obj_Worksheet.Cells(i, 1).Value 'OC
                    strOC = obj_Worksheet.Cells(i, 1).Value
                End If

                Dim LugarEntrega As String = "" & obj_Worksheet.Cells(i, 26).Value
                If LugarEntrega.Length > 50 Then
                    MessageBox.Show("Lugar de entrega no válido, máximo permitido 50", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                    Limpiar()
                Else
                    obeOrdenDeCompra.PSLOTE = LugarEntrega
                End If

                Dim obrGeneral As New brGeneral
                Dim obeGeneral As New beGeneral
                With obeGeneral
                    .PNCCLNT = obeOrdenDeCompra.PNCCLNT
                    .PSNLTECL = obeOrdenDeCompra.PSLOTE
                End With
                Dim olbeLote As New List(Of beGeneral)
                olbeLote = obrGeneral.ListaLotesDeEntrega(obeGeneral)
                If olbeLote.Count > 0 Then
                    obeOrdenDeCompra.PSTLUGEN = olbeLote.Item(0).PSTLTECL.Trim
                Else
                    MessageBox.Show("El CeBe :" & obeOrdenDeCompra.PSLOTE & " no existe en el sistema SOLMIN")
                    Continue For
                End If
                'obeOrdenDeCompra.PNFORCML = obj_Worksheet.Cells(i + 1, 5).Value.ToString.Substring(6, 4) & obj_Worksheet.Cells(i + 1, 5).Value.ToString.Substring(3, 2) & obj_Worksheet.Cells(i + 1, 5).Value.ToString.Substring(0, 2)  'fecha de entrega

                Dim TipoImputacion As String = "" & obj_Worksheet.Cells(i, 25).Value
                If TipoImputacion.Length > 1 Then
                    MessageBox.Show("Tipo de imputacion no válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    obeOrdenDeCompra.PSTPIMSA = TipoImputacion
                End If

                Dim TipoPosicion As String = "" & obj_Worksheet.Cells(i, 24).Value
                If TipoPosicion.Length > 1 Then
                    MessageBox.Show("Tipo de posición SAP no válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    obeOrdenDeCompra.PSTPPOSA = TipoPosicion
                End If

                Dim CentroCosto As String = "" & obj_Worksheet.Cells(i, 5).Value
                If CentroCosto.Length > 10 Then
                    MessageBox.Show("Centro de costo no válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    obeOrdenDeCompra.PSCCNCOS = CentroCosto
                End If

                Dim NumeroGrafo As String = "" & obj_Worksheet.Cells(i, 12).Value
                If NumeroGrafo.Length > 12 Then
                    MessageBox.Show("Número grafo no válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    obeOrdenDeCompra.PSNGFSAP = NumeroGrafo
                End If

                Dim NumeroOrdenSap As String = "" & obj_Worksheet.Cells(i, 7).Value
                If NumeroOrdenSap.Length > 12 Then
                    MessageBox.Show("Número orden SAP no válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    obeOrdenDeCompra.PSNORSAP = NumeroOrdenSap
                End If

                Dim ElementoPEP As String = "" & obj_Worksheet.Cells(i, 6).Value
                If ElementoPEP.Length > 25 Then
                    MessageBox.Show("Elemento PEP SAP no válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    obeOrdenDeCompra.PSNELPEP = ElementoPEP
                End If

                Dim CuentaMayor As String = "" & obj_Worksheet.Cells(i, 4).Value
                If CuentaMayor.Length > 20 Then
                    MessageBox.Show("Cuenta mayor no válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    obeOrdenDeCompra.PSNCTAMA = CuentaMayor
                End If

                'Select Case obeOrdenDeCompra.PSTPIMSA
                '    Case "K"
                '        obeOrdenDeCompra.PSTCTCST = obeOrdenDeCompra.PSCCNCOS
                '        obeOrdenDeCompra.PSTCTCSA = obeOrdenDeCompra.PSCCNCOS
                '        obeOrdenDeCompra.PSTCTCSF = obeOrdenDeCompra.PSCCNCOS
                '    Case "N"
                '        obeOrdenDeCompra.PSTCTCST = obeOrdenDeCompra.PSNGFSAP
                '        obeOrdenDeCompra.PSTCTCSA = obeOrdenDeCompra.PSNGFSAP
                '        obeOrdenDeCompra.PSTCTCSF = obeOrdenDeCompra.PSNGFSAP
                '    Case "F"
                '        obeOrdenDeCompra.PSTCTCST = obeOrdenDeCompra.PSNORSAP
                '        obeOrdenDeCompra.PSTCTCSA = obeOrdenDeCompra.PSNORSAP
                '        obeOrdenDeCompra.PSTCTCSF = obeOrdenDeCompra.PSNORSAP
                'End Select

                'TPIMSA     Tipo de Imputacion SAP         
                'TPPOSA     Tipo de Posicion SAP           
                'CCNCOS     Codigo Centro de Costo SAP     
                'CCEBEN     Codigo Centro de Beneficio SAP 
                'NGFSAP     Numero Grafo SAP 
                'NORSAP     Numero Orden SAP 

                '=============Detalle======================
                olbeOrdenDeCompra.Add(obeOrdenDeCompra)

            Next

            Dim oCloneList As New CloneObject(Of beOrdenCompra)
            olbeDetOc = oCloneList.CloneListObject(olbeOrdenDeCompra)

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
            Me.tsbGuardar.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Call Limpiar()
        End Try

    End Sub


#Region "Metodo"

#Region "Búsqueda de Item"
    Private strOC As String = ""

    Private strNrRef As String = ""
    Private dblNrItem As Decimal = 0

    Private MatchOrdenDeCompra As New Predicate(Of beOrdenCompra)(AddressOf BuscarOrdendeCompra)

    Public Function BuscarOrdendeCompra(ByVal pbeOrdenCompra As beOrdenCompra) As Boolean
        If (pbeOrdenCompra.PSNORCML.Trim.Equals(strOC.Trim)) Then
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

    Private Sub Limpiar()
        obj_Workbook = Nothing
        obj_Excel = Nothing
        obj_Worksheet = Nothing
    End Sub

    ''' <summary>
    ''' Busca el proveedor de acuerdo al código del proveedor del cliente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function BuscarProveedor(ByVal strCodProvCliente As String, ByVal decCliente As Decimal) As Decimal
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

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If Me.dgExcelCabecera.Rows.Count > 0 Then GrabarOc()
    End Sub

    Private Sub GrabarOc()
        Try
            Me.dgExcelCabecera.EndEdit()
            Dim obrOrdeDeCopra As New brOrdenDeCompra
            Dim olbeOcTem As New List(Of beOrdenCompra)
            For Each obeOc As beOrdenCompra In Me.dgExcelCabecera.DataSource
                'If obeOc.CHK = False Then Continue For
                obeOc.PSSESTRG = "A"
                obeOc.PSCUSCRT = strUsuario
                obeOc.PSCULUSA = strUsuario
                obeOc.PSUSUARIO = strUsuario
                obeOc.PSNTRMNL = pTerminal

                If obrOrdeDeCopra.CuentaImputacionOrdenDeCompraInsert(obeOc) <> 1 Then
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
            'CmbXlsHoja.Items.Clear()
            For i = 1 To NumSheets
                NomSheets = obj_Workbook.Sheets.Item(i).Name
                'CmbXlsHoja.Items.Add(NomSheets)
            Next
            'CmbXlsHoja.SelectedIndex = 0
            n = 0
            i = 0
            obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
            Do Until i = 1 Or n = 1000
                n = n + 1
                If Trim(obj_Worksheet.Cells(n + 2, 1).value) = "" Then
                    i = 1
                End If
            Loop
            NmCount = n
        End If
    End Sub
End Class

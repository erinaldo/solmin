Imports Ransa.DAO.OrdenCompra
Imports RANSA.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.DATA




Public Class frmImportarOCExcel_PPC
#Region "Atributos"
    'Private obj_Excel As Object
    'Private obj_Workbook As Object
    'Private obj_Worksheet As Object
    Private olbeDetOc As New List(Of beOrdenCompra)
    Private obj_SheetName As String
    'Private _dblCodCliente As Decimal
    'Private _strUsuario As String
    Public strUsuario As String = ""
    Private NmCount As Decimal = 0D
    Private oListLote As New List(Of beGeneral)

    Private obeProveedorCarga As beProveedorCarga
    Private Class beProveedorCarga
        Public IdProveedor As Decimal = 0
        'Public RUCProvedor As String = ""
        Public CodProvCliente As String = ""
        Public Messsage As String = ""
    End Class

    Public dblCodCliente As Decimal = 0
    'Public Property dblCodCliente() As Decimal
    '    Get
    '        Return _dblCodCliente
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _dblCodCliente = value
    '    End Set
    'End Property


    'Public Property strUsuario() As String
    '    Get
    '        Return _strUsuario
    '    End Get
    '    Set(ByVal value As String)
    '        _strUsuario = value
    '    End Set
    'End Property
    Public pTerminal As String = ""
    Private UltimaRuta As String = ""
    'Private _pTerminal As String
    'Public Property pTerminal() As String
    '    Get
    '        Return _pTerminal
    '    End Get
    '    Set(ByVal value As String)
    '        _pTerminal = value
    '    End Set
    'End Property


#End Region


    Private Sub btnAbrirCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirCabecera.Click
        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object

        Try

            'Dim NumSheets As Integer
            'Dim NomSheets As String
            ''Dim i As Integer
            'Dim ROW As Integer
            'Dim n As Integer

            Dim fileName As String = ""

            'No Seleccionar Multiples Archivos 
            Me.OpenFileDialog.Multiselect = False
            'EL DIRECTORIO INICIAL ES MIS DOCUMENTOS
            Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
            (System.Environment.SpecialFolder.Personal))

            If UltimaRuta = "" Then
                OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal))
            Else
                OpenFileDialog.InitialDirectory = UltimaRuta
            End If
            'FILTRO LAS EXTENSIONES QUE QUIERO MOSTRAR
            Me.OpenFileDialog.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"
            If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then ' SI DIO CLICK EN ACEPTAR
                Me.TxtRutaXlsCabecera.Text = Me.OpenFileDialog.FileName
                'obj_Excel = CreateObject("Excel.Application")
                'obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsCabecera.Text)

                'NumSheets = obj_Workbook.sheets.count()
                ''CmbXlsHoja.Items.Clear()
                'For ROW = 1 To NumSheets
                '    NomSheets = obj_Workbook.Sheets.Item(ROW).Name
                '    'CmbXlsHoja.Items.Add(NomSheets)
                'Next
                ''CmbXlsHoja.SelectedIndex = 0
                'n = 0
                'ROW = 0
                'obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
                'Do Until ROW = 1 Or n = 1000
                '    n = n + 1
                '    If Trim(obj_Worksheet.Cells(n, 1).value) = "" Then
                '        ROW = 1
                '    End If
                'Loop
                'NmCount = n
            Else
                Exit Sub
            End If


            Dim i As Integer
            Dim Columnas As Integer = 12
            Dim TextoRuc As String = ""
            Dim Nro_RUCProvedor As Decimal = 0
            Dim RucProveedorHas As New Hashtable
            Dim CodProveedorHas As New Hashtable
            Dim FechaOC As String = ""

            'If Len(Dir(Me.TxtRutaXlsCabecera.Text)) = 0 Then
            '    MsgBox("No se ha encontrado el archivo: " & Me.TxtRutaXlsCabecera.Text, vbCritical)
            '    Exit Sub
            'End If
            Dim CadProveedor As String = ""
            Dim LargoTotalProv As Integer = 0
            Dim CodProveedor As String = ""
            Dim DescProveedor As String = ""
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



            Dim obeLoteEncontrado As New beGeneral
            '==================Crear lista de Objeto de tipo OC beOrdenDeCOMPRA
            Dim olbeOrdenDeCompra As New List(Of beOrdenCompra)
            Dim olbeOrdenDeCompraMatch As List(Of beOrdenCompra)
            Dim obeOrdenDeCompra As New beOrdenCompra
            Dim strReferencia As String = ""
            Dim TipoBusqueda As String = ""
            Dim obrProveedor As New brProveedor

            NmCount = 65536
            Dim OCCelda As String = ""
            For i = 1 To NmCount - 2
                Nro_RUCProvedor = 0
                TextoRuc = ""
                obeOrdenDeCompra = New beOrdenCompra
                olbeOrdenDeCompraMatch = New List(Of beOrdenCompra)
                'strOC = obj_Worksheet.Cells(i + 1, 5).Value
                'obeOrdenDeCompra.PNCCLNT = _dblCodCliente
                obeOrdenDeCompra.PNCCLNT = dblCodCliente

                If obj_Worksheet.Cells(i + 1, 1).Value Is Nothing Then
                    Exit For
                End If
                obeOrdenDeCompra.PSNORCML = obj_Worksheet.Cells(i + 1, 1).Value.ToString.Trim  'OC

                'If obeOrdenDeCompra.PSNORCML = "" Then
                '    Exit For
                'End If

                obeOrdenDeCompra.PNFROCMP = obj_Worksheet.Cells(i + 1, 5).Value.ToString.Substring(6, 4) & obj_Worksheet.Cells(i + 1, 5).Value.ToString.Substring(3, 2) & obj_Worksheet.Cells(i + 1, 5).Value.ToString.Substring(0, 2)  'fecha de entrega
                'obeOrdenDeCompra.PSCPRPCL = obj_Worksheet.Cells(i + 1, 8).Value.ToString.Substring(0, 6) 'codigo de proveedor de cliente 
                obeOrdenDeCompra.PSLOTE = obj_Worksheet.Cells(i + 1, 11).Value.ToString
                TextoRuc = ("" & obj_Worksheet.Cells(i + 1, 8).Value).ToString.Trim
                'Nro_RUCProvedor = Val(TextoRuc)
                Decimal.TryParse(TextoRuc, Nro_RUCProvedor)
                obeOrdenDeCompra.PSNRUCPR = Nro_RUCProvedor

                If Nro_RUCProvedor > 0 Then
                    obeOrdenDeCompra.PSCPRPCL = ""
                    TipoBusqueda = "RUC"
                Else
                    obeOrdenDeCompra.PSCPRPCL = obj_Worksheet.Cells(i + 1, 8).Value.ToString.Substring(0, 6)
                    TipoBusqueda = "COD_PROV"
                End If

                'If Nro_RUCProvedor <> 0 And Nro_RUCProvedor.ToString.Length > 10 Then
                '    If RucProveedorHas.Contains(Nro_RUCProvedor.ToString.Trim) Then
                '        obeOrdenDeCompra.PNCPRVCL = RucProveedorHas(Nro_RUCProvedor.ToString.Trim)
                '    Else
                '        obeOrdenDeCompra.PNCPRVCL = BuscarProveedor_x_RUC(Nro_RUCProvedor.ToString.Trim)
                '        RucProveedorHas(Nro_RUCProvedor.ToString.Trim) = obeOrdenDeCompra.PNCPRVCL.ToString.Trim
                '    End If


                'Else
                '    Dim IdProveedor As Decimal = 0
                '    Dim RucProveedor As Decimal = 0



                '    If CodProveedorHas.Contains(obeOrdenDeCompra.PSCPRPCL.Trim) Then
                '        IdProveedor = CodProveedorHas(obeOrdenDeCompra.PSCPRPCL)
                '    Else
                '        BuscarProveedor(obeOrdenDeCompra.PSCPRPCL, obeOrdenDeCompra.PNCCLNT, IdProveedor, RucProveedor)
                '        CodProveedorHas(obeOrdenDeCompra.PSCPRPCL.Trim) = IdProveedor.ToString.Trim
                '    End If


                '    obeOrdenDeCompra.PNCPRVCL = IdProveedor
                '    obeOrdenDeCompra.PSNRUCPR = RucProveedor

                'End If


                If TipoBusqueda = "RUC" Then


                    If RucProveedorHas.Contains(Nro_RUCProvedor.ToString.Trim) Then

                        obeProveedorCarga = New beProveedorCarga
                        obeProveedorCarga = DirectCast(RucProveedorHas(Nro_RUCProvedor.ToString.Trim), beProveedorCarga)

                        obeOrdenDeCompra.PNCPRVCL = obeProveedorCarga.IdProveedor
                        'obeOrdenDeCompra.PSERROR = obeOrdenDeCompra.PSERROR & obeProveedorCarga.Messsage
                        'obeOrdenDeCompra.PSMESG = obeOrdenDeCompra.PSMESG & obeProveedorCarga.Messsage


                    Else
                        Dim IdProv As Decimal = 0
                        Dim msg As String = ""
                        msg = obrProveedor.ValidarCarga_Proveedor_ImportExcel("RUC", Nro_RUCProvedor.ToString.Trim, 0, "", IdProv)
                        obeProveedorCarga = New beProveedorCarga
                        obeProveedorCarga.IdProveedor = IdProv ' BuscarProveedor_x_RUC(Nro_RUCProvedor.ToString.Trim)
                        obeProveedorCarga.Messsage = msg
                        obeOrdenDeCompra.PNCPRVCL = IdProv 'obeProveedorCarga.IdProveedor
                        RucProveedorHas(Nro_RUCProvedor.ToString.Trim) = obeProveedorCarga


                        'obeOrdenDeCompra.PSERROR = obeOrdenDeCompra.PSERROR & msg
                        'obeOrdenDeCompra.PSMESG = obeOrdenDeCompra.PSMESG & msg

                    End If

                End If


                If TipoBusqueda = "COD_PROV" Then



                    If CodProveedorHas.Contains(obeOrdenDeCompra.PSCPRPCL.Trim) Then

                        obeProveedorCarga = New beProveedorCarga
                        obeProveedorCarga = DirectCast(CodProveedorHas(obeOrdenDeCompra.PSCPRPCL.Trim), beProveedorCarga)
                        obeOrdenDeCompra.PNCPRVCL = obeProveedorCarga.IdProveedor

                        'obeOrdenDeCompra.PSERROR = obeOrdenDeCompra.PSERROR & obeProveedorCarga.Messsage
                        'obeOrdenDeCompra.PSMESG = obeOrdenDeCompra.PSMESG & obeProveedorCarga.Messsage


                        'IdProveedor = CodProveedorHas(obeOrdenDeCompra.PSCPRPCL)
                    Else
                        'BuscarProveedor(obeOrdenDeCompra.PSCPRPCL, obeOrdenDeCompra.PNCCLNT, IdProveedor, RucProveedor)
                        'CodProveedorHas(obeOrdenDeCompra.PSCPRPCL.Trim) = IdProveedor.ToString.Trim

                        Dim IdProv As Decimal = 0
                        Dim msg As String = ""
                        msg = obrProveedor.ValidarCarga_Proveedor_ImportExcel("COD_PROV", "", obeOrdenDeCompra.PNCCLNT, obeOrdenDeCompra.PSCPRPCL, IdProv)
                        obeProveedorCarga = New beProveedorCarga
                        obeProveedorCarga.IdProveedor = IdProv
                        obeProveedorCarga.Messsage = msg
                        obeOrdenDeCompra.PNCPRVCL = IdProv

                        CodProveedorHas(obeOrdenDeCompra.PSCPRPCL.Trim) = obeProveedorCarga

                        'obeOrdenDeCompra.PSERROR = obeOrdenDeCompra.PSERROR & msg
                        'obeOrdenDeCompra.PSMESG = obeOrdenDeCompra.PSMESG & msg

                    End If

                    'obeOrdenDeCompra.PNCPRVCL = IdProveedor
                    'obeOrdenDeCompra.PSNRUCPR = RucProveedor

                End If

                obeOrdenDeCompra.PSTTINTC = "LOC"

                If obeOrdenDeCompra.PNCPRVCL = 0 Then
                    Dim obeProveedor As New beProveedor
                    With obeProveedor
                        .PNCCLNT = obeOrdenDeCompra.PNCCLNT
                        .PSCPRPCL = obeOrdenDeCompra.PSCPRPCL 'Cod proveedor cliente
                        CadProveedor = ("" & obj_Worksheet.Cells(i + 1, 8).Value).ToString.Trim
                        LargoTotalProv = CadProveedor.Length
                        DescProveedor = ("" & CadProveedor.Substring(6, LargoTotalProv - 6) & "").ToString.Trim
                        If DescProveedor.Length > 30 Then
                            .PSTPRVCL = DescProveedor.Substring(0, 30) 'Descripcion del proveedor
                            .PSTPRCL1 = DescProveedor.Substring(30, DescProveedor.Length - 30) 'Descripcion extedida del proveedor
                        Else
                            .PSTPRVCL = DescProveedor
                        End If
                        .PNNRUCPR = 0
                        .PSCUSCRT = strUsuario
                    End With
                    obeOrdenDeCompra.PNCPRVCL = GrabarProveedoCliente(obeProveedor)
                End If


                FechaOC = obj_Worksheet.Cells(i + 1, 5).Value.ToString.Trim
                obeOrdenDeCompra.PNFORCML = FechaOC.Substring(6, 4) & FechaOC.Substring(3, 2) & FechaOC.Substring(0, 2)  'fecha de entrega
                '==================Detalle========================
                If IsNumeric(obj_Worksheet.Cells(i + 1, 2).Value) Then 'DOC_NROLINEA'
                    obeOrdenDeCompra.PNNRITOC = obj_Worksheet.Cells(i + 1, 2).Value
                Else
                    obeOrdenDeCompra.PSERROR = obeOrdenDeCompra.PSERROR & "Error nr. Item no es numérico"
                End If

                obeOrdenDeCompra.PSTCITCL = obj_Worksheet.Cells(i + 1, 9).Value 'DOC_CODIGOITEM'
                If obeOrdenDeCompra.PSTCITCL Is Nothing Then
                    obeOrdenDeCompra.PSTCITCL = ""
                End If

                obeOrdenDeCompra.PSTDITES = ValidarCaracter.validaCaracter("" & obj_Worksheet.Cells(i + 1, 10).Value & "", obeOrdenDeCompra.PSERROR) 'DOC_DESCRIPCIONITEM'
                If IsNumeric(obj_Worksheet.Cells(i + 1, 12).Value) Then 'DOC_CANTIDADITEM'
                    obeOrdenDeCompra.PNQCNTIT = Decimal.Parse(obj_Worksheet.Cells(i + 1, 12).Value)
                End If
                obeOrdenDeCompra.PSTUNDIT = "" & obj_Worksheet.Cells(i + 1, 35).Value & "" 'DOC_CODUNIDMEDIDA'
                obeOrdenDeCompra.PSTDITIN = ""
                obeOrdenDeCompra.PSTLUGEN = ""
                obeOrdenDeCompra.PSTCTCST = ""
                If IsNumeric(obj_Worksheet.Cells(i + 1, 38).Value) Then
                    obeOrdenDeCompra.PNIVUNIT = Decimal.Parse(obj_Worksheet.Cells(i + 1, 38).Value)
                    obeOrdenDeCompra.PNIVTOIT = Decimal.Parse(obj_Worksheet.Cells(i + 1, 38).Value) * obeOrdenDeCompra.PNQCNTIT
                Else
                    obeOrdenDeCompra.PNIVUNIT = 0
                    obeOrdenDeCompra.PNIVTOIT = 0
                End If
                obeOrdenDeCompra.PSNMONOC = obj_Worksheet.Cells(i + 1, 39).Value
                obeOrdenDeCompra.PSTCITPR = ""
                obeOrdenDeCompra.PSCPTDAR = ""
                obeOrdenDeCompra.PNFMPIME = 0
                obeOrdenDeCompra.PSTLUGOR = ""
                obeOrdenDeCompra.PNQTOLMIN = 0
                obeOrdenDeCompra.PNQTOLMAX = 0

                'dblCodCliente

                'strCodLoteBusqueda = ""
                'If _dblCodCliente = 11731 Or _dblCodCliente = 30507 Then
                If dblCodCliente = 11731 Or dblCodCliente = 30507 Then
                    obeLoteEncontrado = BuscarLote(obeOrdenDeCompra.PSLOTE)
                    If obeLoteEncontrado IsNot Nothing Then
                        obeOrdenDeCompra.PSTRFRNA = obeLoteEncontrado.PSNLTECL.Trim
                        obeOrdenDeCompra.PSLOTE = obeLoteEncontrado.PSTLTECL.Trim
                        obeOrdenDeCompra.PSMESG = ""
                    Else
                        obeOrdenDeCompra.PSMESG = obeOrdenDeCompra.PSMESG & ",El centro de Costo :" & obeOrdenDeCompra.PSLOTE & " no existe"
                    End If
                End If
                '=============Detalle======================
                olbeOrdenDeCompra.Add(obeOrdenDeCompra)
            Next

            'Limpiar()


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
            For Each item As DataGridViewRow In dgExcelCabecera.Rows
                'MESG
                If ("" & item.Cells("MESG").Value).ToString.Trim <> "" Then
                    item.Cells("Chk").ReadOnly = True
                End If
            Next

            'Call Limpiar()
            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If

            Me.tsbGuardar.Enabled = True


           

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Call Limpiar()
            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If

        End Try

    End Sub

    Private Function BuscarLote(CodLote As String) As beGeneral
        Dim beGeneral As New beGeneral
        Dim bolEncontrado As Boolean = False
        For Each item As beGeneral In oListLote
            If item.PSNLTECL.Trim = CodLote.Trim Then
                beGeneral.PSNLTECL = item.PSNLTECL.Trim
                beGeneral.PSTLTECL = item.PSTLTECL.Trim
                bolEncontrado = True
                Exit For
            End If
        Next
        If bolEncontrado = False Then
            beGeneral = Nothing
        End If
        Return beGeneral
    End Function
     

#Region "Metodo"

#Region "Búsqueda de Item"
    Private strOC As String = ""

    Private strNrRef As String = ""
    Private dblNrItem As Decimal = 0
    Dim strCodLoteBusqueda As String = ""

    Private MatchOrdenDeCompra As New Predicate(Of beOrdenCompra)(AddressOf BuscarOrdendeCompra)
    'Private MatchLote As New Predicate(Of beOrdenCompra)(AddressOf BuscarLote)

    Public Function BuscarOrdendeCompra(ByVal pbeOrdenCompra As beOrdenCompra) As Boolean
        If (pbeOrdenCompra.PSNORCML.Trim.Equals(strOC.Trim)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Public Function BuscarLote(CodigoLote As String) As Boolean
    '    If (CodigoLote.Equals(strCodLoteBusqueda.Trim)) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    '

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

 

    'Private Sub Limpiar()
    '    obj_Workbook = Nothing
    '    obj_Excel = Nothing
    '    obj_Worksheet = Nothing
    'End Sub

    ''' <summary>
    ''' Busca el proveedor de acuerdo al código del proveedor del cliente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Sub BuscarProveedor(ByVal strCodProvCliente As String, ByVal decCliente As Decimal, ByRef IdProveedor As Decimal, ByRef RucProveedor As Decimal)
        'se busca los proveedores del cliente plus
        Dim decCodProv As Decimal = 0
        Dim obrProveedor As New brProveedor
        Dim obeProveedor As New beProveedor
        obeProveedor.PNCCLNT = decCliente
        obeProveedor.PSCPRPCL = strCodProvCliente
        'decCodProv = obrProveedor.ObtenerCodigoProveedorPorCodCliente(obeProveedor)
        'Dim IdProveedor As Decimal = 0
        'Dim RucProveedor As Decimal = 0
        obrProveedor.ObtenerDatosProveedorPorCodCliente_RZOL05A(obeProveedor, IdProveedor, RucProveedor)
        'If decCodProv = 0 Then
        '    ' HelpClass.MsgBox("No existe Proveedor registrado para la Oc " & strOrdeCompra, MessageBoxIcon.Warning)
        '    Return 0
        'End If
        'Return decCodProv

    End Sub


    Private Function BuscarProveedor_x_RUC(RUC As String) As Decimal
        Dim decCodProv As Decimal = 0
        Dim obrProveedor As New brProveedor
        Dim dt As New DataTable
        dt = obrProveedor.Listar_proveedor_X_RUC(RUC)
        If dt.Rows.Count > 0 Then
            decCodProv = dt.Rows(0)("CPRVCL")
        End If
        Return decCodProv
    End Function

    '    Dim obrProveedor As New brProveedor
    'ValidarCarga_Proveedor_ImportExcel


    ''' <summary>
    ''' 'Graba proveedor de cliente
    ''' </summary>
    ''' <param name="obeProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GrabarProveedoCliente(ByVal obeProveedor As beProveedor) As Decimal

        Dim decCodProv As Decimal = 0
        Dim obrProveedor As New brProveedor
        decCodProv = obrProveedor.GrabarProveedorDeCliente(obeProveedor)
      
        Return decCodProv
    End Function


#End Region


     

    Private Sub dgExcelCabecera_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgExcelCabecera.SelectionChanged
        strOC = Me.dgExcelCabecera.CurrentRow.DataBoundItem.PSNORCML
        Me.dgExcelDetalle.AutoGenerateColumns = False
        Me.dgExcelDetalle.DataSource = olbeDetOc.FindAll(MatchOrdenDeCompra)
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try
            If Me.dgExcelCabecera.Rows.Count > 0 Then GrabarOc()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GrabarOc()
        Dim msgErrorOC As String = ""
        Dim msgErrorItemOC As String = ""
        Dim msgErrorRegProv As String = ""
        Dim bolEncontrado As Boolean = False
        Dim retorno As Integer = 0
        Dim CantRegGuardados As Integer = 0
        Try
            Me.dgExcelCabecera.EndEdit()

            Dim obrOrdeDeCopra As New brOrdenDeCompra
            Dim olbeOcTem As New List(Of beOrdenCompra)
            Dim terminal As String = "IMPEXFPPC"
            For Each obeOc As beOrdenCompra In Me.dgExcelCabecera.DataSource
                If obeOc.CHK = False Then Continue For
                obeOc.PSSESTRG = "A"
                obeOc.PSCUSCRT = strUsuario
                obeOc.PSCULUSA = strUsuario
                obeOc.PSNTRMNL = terminal
                msgErrorOC = obeOc.PSNORCML

                If obrOrdeDeCopra.InsertarOrdenDeCompra(obeOc) = 1 Then

                    CantRegGuardados = CantRegGuardados + 1
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
                        'el lote se graba en el lugar de entrega
                        obeDetOc.PSTLUGEN = obeOc.PSLOTE

                        msgErrorItemOC = obeDetOc.PNNRITOC

                        obeDetOc.PSNTRMNL = terminal

                        'If obeOc.PNCCLNT = 11731 Or obeOc.PNCCLNT = 30507 Then
                        '    Dim obrGeneral As New brGeneral
                        '    Dim obeGeneral As New beGeneral
                        '    With obeGeneral
                        '        .PNCCLNT = obeOc.PNCCLNT
                        '        .PSNLTECL = obeOc.PSLOTE
                        '    End With
                        '    olbeLote = obrGeneral.ListaLotesDeEntrega(obeGeneral)
                        '    If olbeLote.Count > 0 Then
                        '        obeDetOc.PSTRFRNA = olbeLote.Item(0).PSNLTECL.Trim
                        '        obeDetOc.PSTLUGEN = olbeLote.Item(0).PSTLTECL.Trim
                        '    Else
                        '        MessageBox.Show("El centro de Costo :" & obeOc.PSLOTE & " no existe en el sistema SOLMIN en OC " & strOC & " Nro Item: " & msgErrorItemOC)
                        '        Continue For
                        '    End If
                        'End If
                        If obeDetOc.PSMESG = "" Then
                            retorno = obrOrdeDeCopra.InsertarDetalleOrdenDeCompra(obeDetOc)
                        End If

                    Next

                End If
            Next

            If CantRegGuardados > 0 Then
                MessageBox.Show("Registro Satisfactorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Seleccione registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
           
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & "OC: " & msgErrorOC & " Item: " & msgErrorItemOC, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


  
    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        'Limpiar()

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    'Private Sub btnExcelCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelCabecera.Click
    '    Dim NumSheets As Integer
    '    Dim NomSheets As String
    '    Dim i As Integer
    '    Dim n As Integer

    '    'No Seleccionar Multiples Archivos 
    '    Me.OpenFileDialog.Multiselect = False
    '    'EL DIRECTORIO INICIAL ES MIS DOCUMENTOS
    '    Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
    '    (System.Environment.SpecialFolder.Personal))
    '    'FILTRO LAS EXTENSIONES QUE QUIERO MOSTRAR
    '    Me.OpenFileDialog.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"
    '    If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then ' SI DIO CLICK EN ACEPTAR
    '        Me.TxtRutaXlsCabecera.Text = Me.OpenFileDialog.FileName
    '        obj_Excel = CreateObject("Excel.Application")
    '        obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsCabecera.Text)
    '        NumSheets = obj_Workbook.sheets.count()
    '        'CmbXlsHoja.Items.Clear()
    '        For i = 1 To NumSheets
    '            NomSheets = obj_Workbook.Sheets.Item(i).Name
    '            'CmbXlsHoja.Items.Add(NomSheets)
    '        Next
    '        'CmbXlsHoja.SelectedIndex = 0
    '        n = 0
    '        i = 0
    '        obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
    '        Do Until i = 1 Or n = 1000
    '            n = n + 1
    '            If Trim(obj_Worksheet.Cells(n, 1).value) = "" Then
    '                i = 1
    '            End If
    '        Loop
    '        NmCount = n
    '    End If
    'End Sub

    Private iNroChkSelecc As Int32 = 0
    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If dgExcelCabecera.RowCount > 0 Then
            Dim intCont As Int32 = 0
            iNroChkSelecc = 0
            While intCont < dgExcelCabecera.RowCount

                If dgExcelCabecera.Rows(intCont).Cells("Chk").ReadOnly = False Then
                    dgExcelCabecera.Rows(intCont).DataBoundItem.CHK = btnMarcarItems.Checked
                End If

                intCont += 1
            End While
        End If
        dgExcelCabecera.EndEdit()
        dgExcelCabecera.Refresh()
    End Sub

    Private Sub frmImportarOCExcel_PPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim obrGeneral As New brGeneral
            Dim obeGeneral As New beGeneral
            With obeGeneral

                '.PNCCLNT = _dblCodCliente
                .PNCCLNT = dblCodCliente
                .PSNLTECL = ""
            End With
            'If _dblCodCliente = 11731 Or _dblCodCliente = 30507 Then
            If dblCodCliente = 11731 Or dblCodCliente = 30507 Then
                oListLote = obrGeneral.ListaLotesDeEntrega(obeGeneral)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
End Class

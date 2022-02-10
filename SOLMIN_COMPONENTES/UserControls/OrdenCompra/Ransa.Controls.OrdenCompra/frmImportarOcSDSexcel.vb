Imports Ransa.DAO.OrdenCompra
Imports RANSA.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef

Public Class frmImportarOcSDSexcel

#Region "Atributos"
    Dim _Cod_Cliente As String = ""
    Private _strUsuario As String = ""
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private obj_SheetName As String
    Private objSqlManager As New SqlManager
    Private strMensajeError As String = ""
    Dim dt As New DataTable("Cabecera")
    Dim dtd As New DataTable("Detalle")

    Public Property Cod_Cliente() As String
        Get
            Return _Cod_Cliente
        End Get
        Set(ByVal value As String)
            _Cod_Cliente = value
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

#End Region

#Region "Metodos y Funciones"

    Private Sub Descargar()
        obj_Workbook = Nothing
        obj_Excel = Nothing
        obj_Worksheet = Nothing
    End Sub

    Sub CopiarSeleccionadosDGV1aDGV2(ByVal RefCli As String, ByVal NumOC As String)
        Dim i As Integer
        Me.dgFlag.ColumnCount = Me.dgExcelDetalle.ColumnCount
        For i = 0 To Me.dgExcelDetalle.ColumnCount - 1
            Me.dgFlag.Columns(i).Name = Me.dgExcelDetalle.Columns(i).Name
            Me.dgFlag.Columns(i).HeaderText = Me.dgExcelDetalle.Columns(i).HeaderText
        Next
        For Each Seleccion As DataGridViewRow In dgExcelDetalle.Rows
            If (Seleccion.Cells(0).Value.ToString.Trim() = RefCli And Seleccion.Cells(2).Value.ToString.Trim() = NumOC) Then
                Me.dgFlag.Rows.Add(ObtenerValoresFila(Seleccion))
                Me.dgFlag.Columns(0).Visible = False
                Me.dgFlag.Columns(1).Visible = False
                Me.dgFlag.Columns(3).Visible = False
                Me.dgFlag.Columns(5).Visible = False
                Me.dgFlag.Columns(10).Visible = False
                Me.dgFlag.Columns(11).Visible = False
            End If
        Next
    End Sub

    Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.dgExcelDetalle.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        For Ndx As Integer = 0 To (Contenido.Length - 1)
            Contenido(Ndx) = fila.Cells(Ndx).Value
        Next
        Return Contenido
    End Function

    Public Sub CrearEstrucutra()
        dt.Columns.Add("PNCCLNT", Type.GetType("System.String"))
        dt.Columns.Add("PSNREFCL", Type.GetType("System.String"))
        dt.Columns.Add("PSTCMAEM", Type.GetType("System.String"))
        dt.Columns.Add("PSNORCML", Type.GetType("System.String"))
        dt.Columns.Add("PNFROCMP", Type.GetType("System.String"))
        dt.Columns.Add("PSREFDO1", Type.GetType("System.String"))
        dt.Columns.Add("PSCPRPCL", Type.GetType("System.String"))
        dt.Columns.Add("PSTNOMCOM", Type.GetType("System.String"))
        dt.Columns.Add("PNCPRVCL", Type.GetType("System.String"))
        dt.Columns.Add("PNFORCML", Type.GetType("System.String"))
        dt.Columns.Add("PNFSOLIC", Type.GetType("System.String"))
        dt.Columns.Add("PSTDSCML", Type.GetType("System.String"))
        dt.Columns.Add("PSTTINTC", Type.GetType("System.String"))
        dt.Columns.Add("PSTPAGME", Type.GetType("System.String"))
        dt.Columns.Add("PNNTPDES", Type.GetType("System.String"))
        dt.Columns.Add("PNCMNDA1", Type.GetType("System.String"))
        dt.Columns.Add("PSTEMPFAC", Type.GetType("System.String"))
        dt.Columns.Add("PSTCTCST", Type.GetType("System.String"))
        dt.Columns.Add("PSCREGEMB", Type.GetType("System.String"))
        dt.Columns.Add("PNCMEDTR", Type.GetType("System.String"))
        dt.Columns.Add("PNIVCOTO", Type.GetType("System.String"))
        dt.Columns.Add("PNIVTOCO", Type.GetType("System.String"))
        dt.Columns.Add("PNIVTOIM", Type.GetType("System.String"))
        dt.Columns.Add("PSTDEFIN", Type.GetType("System.String"))
        dt.Columns.Add("PSTDAITM", Type.GetType("System.String"))
        dt.Columns.Add("PSDESPROV", Type.GetType("System.String"))
    End Sub

    Public Sub CrearEstructuraDetalle()
        dtd.Columns.Add("PNCCLNT", Type.GetType("System.String"))
        dtd.Columns.Add("PSNORCML", Type.GetType("System.String"))
        dtd.Columns.Add("PNNRITOC", Type.GetType("System.String"))
        dtd.Columns.Add("PSTCITCL", Type.GetType("System.String"))
        dtd.Columns.Add("PSTDITES", Type.GetType("System.String"))
        dtd.Columns.Add("PNQCNTIT", Type.GetType("System.String"))
        dtd.Columns.Add("PSTUNDIT", Type.GetType("System.String"))
        dtd.Columns.Add("PSTDITIN", Type.GetType("System.String"))
        dtd.Columns.Add("PNFMPDME", Type.GetType("System.String"))
        dtd.Columns.Add("PSTLUGEN", Type.GetType("System.String"))
        dtd.Columns.Add("PSTCTCST", Type.GetType("System.String"))
        dtd.Columns.Add("PNIVUNIT", Type.GetType("System.String"))
        dtd.Columns.Add("PNIVTOIT", Type.GetType("System.String"))
        dtd.Columns.Add("PSTCITPR", Type.GetType("System.String"))
        dtd.Columns.Add("PSCPTDAR", Type.GetType("System.String"))
        dtd.Columns.Add("PNFMPIME", Type.GetType("System.String"))
        dtd.Columns.Add("PSTLUGOR", Type.GetType("System.String"))
        dtd.Columns.Add("PNQTOLMIN", Type.GetType("System.String"))
        dtd.Columns.Add("PNQTOLMAX", Type.GetType("System.String"))
    End Sub

    Public Sub Comparar()
        Dim workRow As DataRow
        Dim workRow1() As DataRow
        Dim i As Integer
        Dim j As Integer
        For i = 0 To Me.dgExcelCabecera.Rows.Count - 1
            If (dt.Rows.Count <> 0) Then
              
                Dim Var As String = dgExcelCabecera.Rows(i).Cells(4).Value.ToString.Trim()
                workRow1 = dt.Select("PSNORCML=" & Var)
                If (workRow1.Length > 0) Then
                    For j = 0 To Me.dt.Rows.Count - 1
                        If (dt.Rows(j).Item("PSNORCML").ToString() = Var) Then
                            dt.Rows(j).Item("PSNREFCL") = dt.Rows(j).Item("PSNREFCL").ToString() & "," & dgExcelCabecera.Rows(i).Cells(0).Value.ToString.Trim()
                        End If
                    Next
                Else
                    workRow = dt.NewRow
                    workRow("PNCCLNT") = Cod_Cliente
                    Dim Cadena As String = "" & dgExcelCabecera.Rows(i).Cells(0).Value.ToString.Trim() & ""
                    workRow("PSNREFCL") = Cadena          'DOC_NROREQUERIMIENTO
                    workRow("PSTCMAEM") = "" & dgExcelCabecera.Rows(i).Cells(3).Value.ToString.Trim() & ""  'DOC_CODLOTE
                    workRow("PSNORCML") = "" & dgExcelCabecera.Rows(i).Cells(4).Value.ToString.Trim() & "" 'DOC_NROORDENCOMPRA
                    workRow("PNFROCMP") = "" & dgExcelCabecera.Rows(i).Cells(8).Value.ToString.Trim() & ""     'nuevo fecha entrega  DOC_FECHAENTREGA
                    workRow("PSREFDO1") = "" & dgExcelCabecera.Rows(i).Cells(9).Value.ToString.Trim() & "" 'DOC_CUENTACONTABLE
                    workRow("PSCPRPCL") = "" & dgExcelCabecera.Rows(i).Cells(6).Value.ToString.Trim() & ""  ' nuenvo DOC_CODPROVEEDOR
                    workRow("PSTNOMCOM") = "" & dgExcelCabecera.Rows(i).Cells(7).Value.ToString.Trim() & "" 'DOC_CODCOMPRADOR
                    workRow("PNCPRVCL") = 0
                    workRow("PNFORCML") = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)
                    workRow("PNFSOLIC") = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)  'Fecha Solicitante
                    workRow("PSTDSCML") = ""
                    workRow("PSTTINTC") = ""
                    workRow("PSTPAGME") = ""
                    workRow("PNNTPDES") = 0
                    workRow("PNCMNDA1") = 1
                    workRow("PSTEMPFAC") = ""
                    workRow("PSTCTCST") = ""
                    workRow("PSCREGEMB") = ""
                    workRow("PNCMEDTR") = 0
                    workRow("PNIVCOTO") = 0
                    workRow("PNIVTOCO") = 0
                    workRow("PNIVTOIM") = 0
                    workRow("PSTDEFIN") = ""
                    workRow("PSTDAITM") = ""
                    workRow("PSDESPROV") = dgExcelCabecera.Rows(i).Cells(11).Value.ToString.Trim() & ""

                    dt.Rows.Add(workRow)
                End If
            Else
                workRow = dt.NewRow
                workRow("PNCCLNT") = Cod_Cliente
                Dim Cadena As String = "" & dgExcelCabecera.Rows(i).Cells(0).Value.ToString.Trim() & ""
                workRow("PSNREFCL") = Cadena          'DOC_NROREQUERIMIENTO
                workRow("PSTCMAEM") = "" & dgExcelCabecera.Rows(i).Cells(3).Value.ToString.Trim() & ""  'DOC_CODLOTE
                workRow("PSNORCML") = "" & dgExcelCabecera.Rows(i).Cells(4).Value.ToString.Trim() & "" 'DOC_NROORDENCOMPRA
                workRow("PNFROCMP") = "" & dgExcelCabecera.Rows(i).Cells(8).Value.ToString.Trim() & ""     'nuevo fecha entrega  DOC_FECHAENTREGA
                workRow("PSREFDO1") = "" & dgExcelCabecera.Rows(i).Cells(9).Value.ToString.Trim() & "" 'DOC_CUENTACONTABLE
                workRow("PSCPRPCL") = "" & dgExcelCabecera.Rows(i).Cells(6).Value.ToString.Trim() & ""  ' nuenvo DOC_CODPROVEEDOR
                workRow("PSTNOMCOM") = "" & dgExcelCabecera.Rows(i).Cells(7).Value.ToString.Trim() & "" 'DOC_CODCOMPRADOR
                workRow("PNCPRVCL") = 0
                workRow("PNFORCML") = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)
                workRow("PNFSOLIC") = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)  'Fecha Solicitante
                workRow("PSTDSCML") = ""
                workRow("PSTTINTC") = ""
                workRow("PSTPAGME") = ""
                workRow("PNNTPDES") = 0
                workRow("PNCMNDA1") = 0
                workRow("PSTEMPFAC") = ""
                workRow("PSTCTCST") = ""
                workRow("PSCREGEMB") = ""
                workRow("PNCMEDTR") = 0
                workRow("PNIVCOTO") = 0
                workRow("PNIVTOCO") = 0
                workRow("PNIVTOIM") = 0
                workRow("PSTDEFIN") = ""
                workRow("PSTDAITM") = ""
                workRow("PSDESPROV") = dgExcelCabecera.Rows(i).Cells(11).Value.ToString.Trim() & ""
                dt.Rows.Add(workRow)
            End If
        Next
    End Sub

    Public Function ValidarOrdenCompraDetalle() As Boolean
        Dim workRow As DataRow
        Dim i As Integer
        Dim j As Integer
        For i = 0 To Me.dgExcelDetalle.Rows.Count - 1
            If (dtd.Rows.Count <> 0) Then
                Dim NordenCompra As String = dgExcelDetalle.Rows(i).Cells(2).Value.ToString.Trim()
                Dim CantItem As String = dgExcelDetalle.Rows(i).Cells(4).Value.ToString.Trim()

                For j = 0 To Me.dtd.Rows.Count - 1
                    If ((dtd.Rows(j).Item("PSNORCML").ToString.Trim() = NordenCompra) And (dtd.Rows(j).Item("PNNRITOC").ToString.Trim() = CantItem)) Then
                        MessageBox.Show("El numero de Operacion :" & " " & NordenCompra & " " & " y el Numero de Item :" & " " & CantItem & " " & "se Replican Verificar Excel Detalle Orden de Compra")
                        Return False
                    End If
                Next
                workRow = dtd.NewRow
                workRow("PNCCLNT") = Cod_Cliente
                workRow("PSNORCML") = dgExcelDetalle.Rows(i).Cells(2).Value.ToString.Trim() 'DOC_NROORDENCOMPRA'
                workRow("PNNRITOC") = dgExcelDetalle.Rows(i).Cells(4).Value
                workRow("PSTCITCL") = dgExcelDetalle.Rows(i).Cells(6).Value.ToString.Trim() 'DOC_CODIGOITEM'
                workRow("PSTDITES") = ("" & dgExcelDetalle.Rows(i).Cells(7).Value.ToString.Trim() & "") 'DOC_DESCRIPCIONITEM'
                workRow("PNQCNTIT") = dgExcelDetalle.Rows(i).Cells(8).Value.ToString.Trim()
                workRow("PSTUNDIT") = dgExcelDetalle.Rows(i).Cells(9).Value.ToString.Trim() 'DOC_CODUNIDMEDIDA'
                workRow("PSTDITIN") = ""
                workRow("PNFMPDME") = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)
                workRow("PSTLUGEN") = ""
                workRow("PSTCTCST") = ""
                workRow("PNIVUNIT") = 0
                workRow("PNIVTOIT") = 0
                workRow("PSTCITPR") = ""
                workRow("PSCPTDAR") = ""
                workRow("PNFMPIME") = 0
                workRow("PSTLUGOR") = ""
                workRow("PNQTOLMIN") = 0
                workRow("PNQTOLMAX") = 0
                dtd.Rows.Add(workRow)
            Else
                workRow = dtd.NewRow
                workRow("PNCCLNT") = Cod_Cliente
                workRow("PSNORCML") = dgExcelDetalle.Rows(i).Cells(2).Value.ToString.Trim() 'DOC_NROORDENCOMPRA'
                workRow("PNNRITOC") = dgExcelDetalle.Rows(i).Cells(4).Value
                workRow("PSTCITCL") = dgExcelDetalle.Rows(i).Cells(6).Value.ToString.Trim() 'DOC_CODIGOITEM'
                workRow("PSTDITES") = ("" & dgExcelDetalle.Rows(i).Cells(7).Value.ToString.Trim() & "") 'DOC_DESCRIPCIONITEM'
                workRow("PNQCNTIT") = dgExcelDetalle.Rows(i).Cells(8).Value.ToString.Trim()
                workRow("PSTUNDIT") = dgExcelDetalle.Rows(i).Cells(9).Value.ToString.Trim() 'DOC_CODUNIDMEDIDA'
                workRow("PSTDITIN") = ""
                workRow("PNFMPDME") = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)
                workRow("PSTLUGEN") = ""
                workRow("PSTCTCST") = ""
                workRow("PNIVUNIT") = 0
                workRow("PNIVTOIT") = 0
                workRow("PSTCITPR") = ""
                workRow("PSCPTDAR") = ""
                workRow("PNFMPIME") = 0
                workRow("PSTLUGOR") = ""
                workRow("PNQTOLMIN") = 0
                workRow("PNQTOLMAX") = 0
                dtd.Rows.Add(workRow)
            End If
        Next
        Return True

    End Function

    Private Sub GrabarOrdenCompraCabecera()
        Dim i As Integer
        Dim olbeOrdenCompra As New List(Of beOrdenCompra)
        Dim obeOrdenCompra As New beOrdenCompra
        Comparar()
        For i = 0 To Me.dt.Rows.Count - 1
            obeOrdenCompra.PNCCLNT = Decimal.Parse(Cod_Cliente)
            obeOrdenCompra.PSTCMAEM = "" & dt.Rows(i).Item("PSTCMAEM").ToString.Trim() & ""  'DOC_CODLOTE
            obeOrdenCompra.PSNORCML = "" & dt.Rows(i).Item("PSNORCML").ToString.Trim() & "" 'DOC_NROORDENCOMPRA
            obeOrdenCompra.PNFROCMP = "" & dt.Rows(i).Item("PNFROCMP").ToString.Trim() & ""     'nuevo fecha entrega  DOC_FECHAENTREGA
            obeOrdenCompra.PSREFDO1 = "" & dt.Rows(i).Item("PSREFDO1").ToString.Trim() & "" 'DOC_CUENTACONTABLE
            obeOrdenCompra.PSCPRPCL = "" & dt.Rows(i).Item("PSCPRPCL").ToString.Trim() & ""  ' nuenvo DOC_CODPROVEEDOR
            obeOrdenCompra.PSTNOMCOM = "" & dt.Rows(i).Item("PSTNOMCOM").ToString.Trim() & "" 'DOC_CODCOMPRADOR
            Dim Cadena As String = "" & dt.Rows(i).Item("PSNREFCL").ToString.Trim() & ""
            If (Cadena.Length > 15) Then
                obeOrdenCompra.PSNREFCL = Cadena.Substring(0, 14)            'DOC_NROREQUERIMIENTO
            Else
                obeOrdenCompra.PSNREFCL = Cadena                          'DOC_NROREQUERIMIENTO
            End If

            '===============================
            Dim obrEntidad As New Ransa.NEGO.brProveedor
            Dim oEntidad As New beProveedor
            With oEntidad
                .PSTPRVCL = "" & dt.Rows(i).Item("PSDESPROV").ToString.Trim() & ""
            End With

            '==================================
            obeOrdenCompra.PNCPRVCL = obrEntidad.ObtenerProveedor(oEntidad).PNCPRVCL

            If obeOrdenCompra.PNCPRVCL = -1 Then
                obeOrdenCompra.PNCPRVCL = obrEntidad.RegistrarProveedorGeneral(oEntidad).PNCPRVCL
            End If

            obeOrdenCompra.PNFORCML = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now) 'Fecha OC
            obeOrdenCompra.PNFSOLIC = HelpClass.CFecha_a_Numero8Digitos(DateTime.Now)  'Fecha Solicitante
            obeOrdenCompra.PSTDSCML = ""
            obeOrdenCompra.PSTTINTC = ""
            obeOrdenCompra.PSTPAGME = ""
            obeOrdenCompra.PNNTPDES = 0
            obeOrdenCompra.PNCMNDA1 = 0
            obeOrdenCompra.PSTEMPFAC = ""
            obeOrdenCompra.PSTCTCST = ""
            obeOrdenCompra.PSCREGEMB = ""
            obeOrdenCompra.PNCMEDTR = 0
            obeOrdenCompra.PNIVCOTO = 0
            obeOrdenCompra.PNIVTOCO = 0
            obeOrdenCompra.PNIVTOIM = 0
            obeOrdenCompra.PSTDEFIN = ""
            obeOrdenCompra.PSTDAITM = ""
            If cOrdenCompra.GrabarOTRO(objSqlManager, obeOrdenCompra, strUsuario, strMensajeError) Then

            End If
        Next

    End Sub

    Private Sub GrabarOrdenCompraDetalle()
        Dim i As Integer
        Dim olbeOrdenCompra As New List(Of beOrdenCompra)
        Dim obeOrdenCompra As New beOrdenCompra
        If Not (ValidarOrdenCompraDetalle()) Then
            Me.dgFlag.Columns.Clear()
            Me.dgExcelDetalle.Columns.Clear()
            TxtRutaXlsDetalle.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
            Exit Sub
        End If
        For i = 0 To Me.dgExcelDetalle.Rows.Count - 1
            obeOrdenCompra.PNCCLNT = Decimal.Parse(Cod_Cliente)
            obeOrdenCompra.PSNORCML = dgExcelDetalle.Rows(i).Cells(2).Value.ToString.Trim() 'DOC_NROORDENCOMPRA'
            If IsNumeric(dgExcelDetalle.Rows(i).Cells(4).Value.ToString.Trim()) Then 'DOC_NROLINEA'
                obeOrdenCompra.PNNRITOC = dgExcelDetalle.Rows(i).Cells(4).Value
            End If
            obeOrdenCompra.PSTCITCL = dgExcelDetalle.Rows(i).Cells(6).Value.ToString.Trim() 'DOC_CODIGOITEM'
            obeOrdenCompra.PSTDITES = ("" & dgExcelDetalle.Rows(i).Cells(7).Value.ToString.Trim() & "") 'DOC_DESCRIPCIONITEM'
            If IsNumeric(dgExcelDetalle.Rows(i).Cells(8).Value) Then 'DOC_CANTIDADITEM'
                obeOrdenCompra.PNQCNTIT = Decimal.Parse(dgExcelDetalle.Rows(i).Cells(8).Value)
            End If
            obeOrdenCompra.PSTUNDIT = dgExcelDetalle.Rows(i).Cells(9).Value.ToString.Trim() 'DOC_CODUNIDMEDIDA'
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
            If cItemOrdenCompra.GrabarABB(objSqlManager, obeOrdenCompra, strUsuario, strMensajeError) Then

            End If
        Next
        MessageBox.Show("Registro Satisfactorio.")
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmImportarOcSDSexcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtRutaXlsCabecera.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
        TxtRutaXlsDetalle.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
        CrearEstrucutra()
        CrearEstructuraDetalle()
        btnExcelDetalle.Enabled = False
        brnAbrirDetalle.Enabled = False
    End Sub

    Private Sub btnExcelCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelCabecera.Click
        dt.Rows.Clear()
        dgExcelCabecera.Columns.Clear()
        dgExcelDetalle.Columns.Clear()
        Me.dgFlag.Columns.Clear()
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
        If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then 'SI DIO CLICK EN ACEPTAR
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
            ' Cuenta los datos validos   
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
            Dim n As Integer
            Dim i As Integer
            Dim j As Integer
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
            Me.dgExcelCabecera.Rows.Clear()
            '===================================================================
            ' Llena la CABECERA  
            For i = 1 To Columnas             ' Numero de columnas
                dgExcelCabecera.Columns.Add(i, CambiarNombresCabecera(obj_Worksheet.Cells(1, i).value))
            Next
            dgExcelCabecera.Columns(1).Visible = False
            dgExcelCabecera.Columns(2).Visible = False
            dgExcelCabecera.Columns(5).Visible = False
            dgExcelCabecera.Columns(8).Visible = False
            dgExcelCabecera.Columns(9).Visible = False
            dgExcelCabecera.Columns(10).Visible = False
            dgExcelCabecera.Columns(11).Visible = False
            '===================================================================
            ' Llena el DataGridView   
            For i = 1 To NmCount.Value - 2
                With dgExcelCabecera
                    n = .Rows.Add()
                    For j = 0 To Columnas - 1     ' Numero de columnas 
                        .Rows.Item(n).Cells(j).Value = obj_Worksheet.Cells(n + 2, j + 1).Value
                    Next
                End With
            Next
            ' -- Cerrar Excel   
            'obj_Workbook.Close()
            'obj_Excel.quit()
            Call Descargar()
            If (Me.dgExcelCabecera.Rows.Count > 0) Then
                btnExcelDetalle.Enabled = True
                brnAbrirDetalle.Enabled = True
            Else
                btnExcelDetalle.Enabled = False
                brnAbrirDetalle.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Call Descargar()
        End Try
    End Sub

    Private Function CambiarNombresCabecera(ByVal Evaluar) As String
        Dim Nombre As String = ""
        Select Case Evaluar
            Case "DOC_NROREQUERIMIENTO"
                Nombre = "Referencia Cliente"
            Case "DOC_TIPOREQUERIMIENTO"
                Nombre = "DOC_TIPOREQUERIMIENTO"
            Case "DOC_CODUSUARIO"
                Nombre = "DOC_CODUSUARIO"
            Case "DOC_CODLOTE"
                Nombre = "Area de Empresa"
            Case "DOC_NROORDENCOMPRA"
                Nombre = "N°OrdenCompra"
            Case "DOC_TIPOORDENCOMPRA"
                Nombre = "DOC_TIPOORDENCOMPRA"
            Case "DOC_CODPROVEEDOR"
                Nombre = "Codigo Cliente - Proveedor"
            Case "DOC_CODCOMPRADOR"
                Nombre = "Proveedor"
            Case "DOC_FECHAENTREGA"
                Nombre = "Fecha Entrega"
            Case "DOC_CUENTACONTABLE"
                Nombre = "Referencia Documento"
            Case "DOC_LIBROAUXILIAR"
                Nombre = "DOC_LIBROAUXILIAR"
            Case "DOC_PRICINGGROUP"
                Nombre = "DOC_PRICINGGROUP"
        End Select
        Return Nombre
    End Function

    Private Function CambiarNombreDetalle(ByVal Evaluar) As String
        Dim Nombre As String = ""
        Select Case Evaluar
            Case "DOC_NROREQUERIMIENTO"
                Nombre = "Referencia Cliente"
            Case "DOC_TIPOREQUERIMIENTO"
                Nombre = "DOC_TIPOREQUERIMIENTO"
            Case "DOC_NROORDENCOMPRA"
                Nombre = "N° OrdenCompra"
            Case "DOC_TIPOORDENCOMPRA"
                Nombre = "DOC_TIPOORDENCOMPRA"
            Case "DOC_NROLINEA"
                Nombre = "Numero Item"
            Case "DOC_TIPOLINEA"
                Nombre = "DOC_TIPOLINEA"
            Case "DOC_CODIGOITEM"
                Nombre = "Codigo Item Cliente"
            Case "DOC_DESCRIPCIONITEM"
                Nombre = "Descripcion Item"
            Case "DOC_CANTIDADITEM"
                Nombre = "Cantidad Item"
            Case "DOC_CODUNIDMEDIDA"
                Nombre = "Unidad Medida"
            Case "DOC_OBSERVACIONITEM"
                Nombre = "DOC_OBSERVACIONITEM"
            Case "DOC_ESTADOLINEA"
                Nombre = "DOC_ESTADOLINEA"
        End Select
        Return Nombre
    End Function

    Private Sub btnExcelDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelDetalle.Click
        dgExcelDetalle.Columns.Clear()
        Me.dgFlag.Columns.Clear()
        dtd.Rows.Clear()
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
        Me.dgExcelCabecera_CellClick(Nothing, Nothing)
    End Sub

    Private Sub brnAbrirDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnAbrirDetalle.Click
        dgExcelDetalle.Columns.Clear()
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
            Me.dgExcelDetalle.Rows.Clear()
            '===================================================================
            ' Llena la CABECERA  
            For i = 1 To Columnas             ' Numero de columnas
                Me.dgExcelDetalle.Columns.Add(i, CambiarNombreDetalle(obj_Worksheet.Cells(1, i).value))
            Next
            '===================================================================
            ' Llena el DataGridView   
            For i = 1 To NmCount1.Value - 2
                With dgExcelDetalle
                    n = .Rows.Add()
                    For j = 0 To Columnas - 1     ' Numero de columnas 
                        .Rows.Item(n).Cells(j).Value = obj_Worksheet.Cells(n + 2, j + 1).Value
                    Next
                End With
            Next
            ' -- Cerrar Excel   
            'obj_Workbook.Close()
            'obj_Excel.quit()
            Call Descargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Call Descargar()
        End Try
        Me.dgExcelCabecera_CellClick(Nothing, Nothing)
    End Sub

    Private Sub dgExcelCabecera_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgExcelCabecera.CellClick
        Me.dgFlag.Rows.Clear()
        CopiarSeleccionadosDGV1aDGV2(Me.dgExcelCabecera.CurrentRow.Cells(0).Value.ToString.Trim(), Me.dgExcelCabecera.CurrentRow.Cells(4).Value.ToString.Trim())
    End Sub

    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub dgExcelCabecera_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgExcelCabecera.KeyUp
        If Me.dgExcelCabecera.CurrentCellAddress.Y < 0 Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Up, Keys.Down
                Me.dgExcelCabecera_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If (Me.dgExcelCabecera.Rows.Count = 0 Or Me.dgExcelDetalle.Rows.Count = 0) Then Exit Sub

        If (MessageBox.Show("Desea Guardar el registro", "Guardar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
            GrabarOrdenCompraCabecera()
            GrabarOrdenCompraDetalle()
        End If
    End Sub

#End Region


End Class

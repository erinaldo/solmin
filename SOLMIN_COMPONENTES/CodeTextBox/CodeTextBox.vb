Imports System.Windows.Forms
Imports System.Data
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class CodeTextBox
    Inherits Panel
 
    Public WithEvents Texto As New TextBox
    Public WithEvents btnBuscar As New Button
    Public WithEvents btnLimpiar As New Button
    Public WithEvents panelBotones As New Panel

    Public objDatos As New DataTable
    Public _Codigo As String = ""
    Public _Descripcion As String = ""
    Public _Keyfield As String = ""
    Public _ValueField As String = ""
    Public IndiceKey As Integer
    Public IndiceValue As Integer
    Public _TextColor As New Color
    Public _TextBold As Boolean = False
    Public _FondColor As New Color
    Public _Alto As Integer = 23
    Public _Imagen As Boolean = True
    Public _TextReadOnly As Boolean = False
    Public _KeyColumnWidth As Integer = 100
    Public _ValueColumnWidth As Integer = 600
    Public _ValueSearch As Boolean = True
    Public _KeySearch As Boolean = True

    Public _KeyFieldVisible As Boolean = True
    Public _ValueFieldVisible As Boolean = True

    Public Event Texto_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public Event BusquedaFiltrada_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    Public Sub Columnas_DataTable(ByVal Parametros As Collection)
        For i As Integer = 1 To Parametros.Count
            objDatos.Columns.Add(Parametros(i).ToString())
        Next
    End Sub

    Public Property KeySearch() As Boolean
        Get
            Return _KeySearch
        End Get
        Set(ByVal value As Boolean)
            _KeySearch = value
        End Set
    End Property

    Public Property ValueSearch() As Boolean
        Get
            Return _ValueSearch
        End Get
        Set(ByVal value As Boolean)
            _ValueSearch = value
        End Set
    End Property

    Public Property ValueColumnWidth() As Integer
        Get
            Return _ValueColumnWidth
        End Get
        Set(ByVal value As Integer)
            _ValueColumnWidth = value
        End Set
    End Property

    Public Property KeyColumnWidth() As Integer
        Get
            Return _KeyColumnWidth
        End Get
        Set(ByVal value As Integer)
            _KeyColumnWidth = value
        End Set
    End Property


    Public Property ControlReadOnly() As Boolean
        Get
            Return _TextReadOnly
        End Get
        Set(ByVal value As Boolean)
            _TextReadOnly = value
        End Set
    End Property

    Public Property ControlImage() As Boolean
        Get
            Return _Imagen
        End Get
        Set(ByVal value As Boolean)
            _Imagen = value
        End Set
    End Property

    Public Property ControlHeight() As Integer
        Get
            Return _Alto
        End Get
        Set(ByVal value As Integer)
            _Alto = value
        End Set
    End Property

    Public Property TextBackColor() As Color
        Get
            Return _TextColor
        End Get
        Set(ByVal value As Color)
            _TextColor = value
        End Set
    End Property

    Public Property TextForeColor() As Color
        Get
            Return _FondColor
        End Get
        Set(ByVal value As Color)
            _FondColor = value
        End Set
    End Property

    Public Property ValueColumnVisible() As Boolean
        Get
            Return _KeyFieldVisible
        End Get
        Set(ByVal value As Boolean)
            _KeyFieldVisible = value
        End Set
    End Property

    Public Property DisplayColumnVisible() As Boolean
        Get
            Return _ValueFieldVisible
        End Get
        Set(ByVal value As Boolean)
            _ValueFieldVisible = value
        End Set
    End Property



    Public Sub AgregarDataTableItem(ByVal Parametro As Collection)

        Dim dr As DataRow = objDatos.NewRow
        For i As Integer = 1 To Parametro.Count
            dr(i - 1) = Parametro(i).ToString()
        Next
        objDatos.Rows.Add(dr)
        dr = Nothing

    End Sub

    Private Sub CodeTextBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Me.Height = _Alto '23 
        '  Me.BackColor = Color.Transparent

        btnBuscar.Dock = DockStyle.Left
        btnBuscar.Width = 25
        btnBuscar.Height = 20
        btnBuscar.Margin = New Padding(0)
        If _Imagen Then
            btnBuscar.Image = Images.Images(1)
        Else
            btnBuscar.Image = Nothing
            btnBuscar.TextAlign = ContentAlignment.TopCenter
            btnBuscar.Text = "..."
            btnBuscar.Cursor = Cursors.Hand
        End If

        btnLimpiar.Dock = DockStyle.Right
        btnLimpiar.Width = 25
        btnLimpiar.Height = 25
        btnLimpiar.Image = Images.Images(0)

        panelBotones.Controls.Add(btnBuscar)

        Texto.Dock = DockStyle.Fill
        Texto.Width = 600
        Texto.Height = 23
        Texto.ContextMenuStrip = Me.PopupMenuTexto
        'Texto.CharacterCasing = CharacterCasing.Upper
        'Texto.BackColor = _TextColor
        Texto.ForeColor = _FondColor
        Texto.ReadOnly = _TextReadOnly
        If _TextReadOnly Then
            Texto.CharacterCasing = CharacterCasing.Normal
        End If

        panelBotones.Width = 25
        panelBotones.Dock = DockStyle.Right

        Me.Controls.Add(Texto)
        Me.Controls.Add(panelBotones)


        AddHandler Texto.KeyUp, AddressOf Me.TextoKeyEnter
        AddHandler btnBuscar.Click, AddressOf Me.BusquedaFiltrada

    End Sub

    Public Overridable Sub TextoKeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        RaiseEvent Texto_KeyEnter(sender, e)
    End Sub

    Public Overridable Sub BusquedaFiltrada(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent BusquedaFiltrada_Click(sender, e)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Busqueda_Avanzada()
    End Sub

    Private Sub Busqueda_Avanzada()

        If objDatos Is Nothing Then
            MessageBox.Show("No tiene informacion a mostrar", "Solmin ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Using objFormBusqueda As New frmBuscar
            objFormBusqueda.ShowForm(objDatos, Me)
        End Using

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Public Sub Limpiar()
        _Codigo = ""
        _Descripcion = ""
        Me.Texto.Text = ""
        Me.Texto.BackColor = _TextColor
    End Sub

    Public ReadOnly Property NoHayCodigo() As Boolean

        Get
            If _Codigo.Equals("") = True Then
                Return True
            Else
                Return False
            End If
        End Get

    End Property

    Public Property KeyField() As String
        Get
            Return _Keyfield
        End Get
        Set(ByVal value As String)
            _Keyfield = value
        End Set
    End Property

    Public Property ValueField() As String
        Get
            Return _ValueField
        End Get
        Set(ByVal value As String)
            _ValueField = value
        End Set
    End Property

    Public Property DisplayMember() As String
        Get
            Return _ValueField
        End Get
        Set(ByVal value As String)
            _ValueField = value
        End Set
    End Property

    Public Property ValueMember() As String
        Get
            Return _Keyfield
        End Get
        Set(ByVal value As String)
            _Keyfield = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            Buscar(value)
        End Set
    End Property

    Public Property DataSource() As DataTable
        Get
            Return objDatos
        End Get
        Set(ByVal data As DataTable)
            objDatos = data
        End Set
    End Property

    Public Sub DataBind()

        If objDatos Is Nothing Then
            Limpiar()
        End If

        Establecer_Columnas()
    End Sub

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Sub Establecer_Columnas()

        If objDatos Is Nothing Then
            Exit Sub
        End If

        For i As Integer = 0 To objDatos.Columns.Count - 1

            If objDatos.Columns(i).ColumnName.Equals(_Keyfield) = True Then
                objDatos.Columns(i).ColumnName = "Codigo"
                IndiceKey = i
            ElseIf objDatos.Columns(i).ColumnName.Equals(_ValueField) = True Then
                objDatos.Columns(i).ColumnName = "Valor"
                IndiceValue = i
            Else
                objDatos.Columns(i).ColumnName = i
            End If

        Next

    End Sub

    Public Sub Mostrar_Contenido()

        If _KeyFieldVisible = True Then
            Me.Texto.Text = "" & _Codigo.Trim() & " -> " & _Descripcion.Trim()
        Else
            Me.Texto.Text = "" & _Descripcion.Trim()
        End If

        Me.Texto.BackColor = Color.FromArgb(197, 191, 219)
        RaiseEvent Texto_KeyEnter(New Object, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
        Me.Texto.BackColor = Color.FromArgb(197, 191, 219)
    End Sub

    Private Sub txtDescipcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Texto.KeyDown

        If e.KeyCode = Keys.Enter Then
            Buscar(Me.Texto.Text)
            ' RaiseEvent Texto_KeyEnter(sender, e)
        End If

        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Back Then
            Limpiar()
        End If

        If e.KeyCode = Keys.F4 Then
            Busqueda_Avanzada()
        End If
 

    End Sub

    Private Sub Buscar(ByVal _textobusqueda As String)

        Dim fila As Integer = 0

        'En base al origen de datos, se busca solo el codigo
        For fila = 0 To objDatos.Rows.Count - 1
            If objDatos.Rows(fila).Item(IndiceKey).ToString().Trim().Equals(_textobusqueda.Trim) = True Then

                _Codigo = objDatos.Rows(fila).Item(IndiceKey).ToString().Trim()
                _Descripcion = objDatos.Rows(fila).Item(IndiceValue).ToString().Trim()

                Mostrar_Contenido()

                Exit For
            End If
        Next

        'If fila = objDatos.Rows.Count Then
        'Limpiar()
        ' End If

    End Sub

    Private Sub mnuBusquedaAvanzada_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBusquedaAvanzada.Click
        btnBuscar_Click(sender, e)
    End Sub

    Private Sub mnuLimpiarElemento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLimpiarElemento.Click
        Limpiar()
    End Sub

#Region "Tarifas"

    Public Sub Cargar_Servicios(ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecha As Double)
        'Dim oDt As DataTable

        DataSource = Lista_Servicios(pstrComp, pstrDiv, pstrPlt, pdblCliente, pdblFecha)
        'DataSource = Procesar_Servicios(oDt)
        ValueMember = "NRTFSV"
        DisplayMember = "DESTAR"
    End Sub

    Public Sub Cargar_Servicios_Tarifa_Fija(ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecha As Double)
        'Dim oDt As DataTable

        DataSource = Lista_Servicios_Tarifa_Fija(pstrComp, pstrDiv, pstrPlt, pdblCliente, pdblFecha)
        'DataSource = Procesar_Servicios(oDt)
        ValueMember = "NRTFSV"
        DisplayMember = "DESTAR"
    End Sub

    Public Sub Cargar_Servicios_Tarifa_Cliente(ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecha As Double)

        DataSource = Lista_Tarifa_Servicios_Cliente(pstrComp, pstrDiv, pstrPlt, pdblCliente, pdblFecha)
        ValueMember = "NRTFSV"
        DisplayMember = "DESTAR"
    End Sub

    'Private Function Procesar_Servicios(ByVal poDt As DataTable) As DataTable
    '    Dim oDt As New DataTable
    '    Dim oDr As DataRow
    '    Dim intCont As Integer

    '    oDt.Columns.Add(New DataColumn("NRTFSV", GetType(System.Double)))
    '    oDt.Columns.Add(New DataColumn("SERVICIO", GetType(System.String)))

    '    For intCont = 0 To poDt.Rows.Count - 1
    '        oDr = oDt.NewRow
    '        oDr.Item("NRTFSV") = poDt.Rows(intCont).Item("NRTFSV").ToString.Trim
    '        oDr.Item("SERVICIO") = poDt.Rows(intCont).Item("DESTAR").ToString.Trim 'Generar_Tarifa(poDt.Rows(intCont))
    '        oDt.Rows.Add(oDr)
    '    Next intCont

    '    Return oDt
    'End Function

    'Private Function Generar_Tarifa(ByVal poRow As DataRow) As String
    '    Dim strTarifa As String = ""

    '    With poRow
    '        'If .Item("COSTOS").ToString.Trim = "" Then
    '        '    strTarifa = .Item("TSGNMN").ToString.Trim
    '        '    strTarifa = strTarifa & " " & .Item("IVLSRV").ToString.Trim
    '        'End If
    '        'If .Item("COSTOS").ToString.Trim <> "" Then
    '        '    strTarifa = Double.Parse(.Item("IVLSRV").ToString.Trim) * 100
    '        '    strTarifa = strTarifa & " % del " & .Item("COSTOS").ToString.Trim
    '        'End If
    '        strTarifa = .Item("SERTARF").ToString.Trim
    '        If .Item("VALCTE").ToString.Trim > 1 And .Item("COSTOS").ToString.Trim = "" Then
    '            strTarifa = strTarifa & " por " & .Item("VALCTE").ToString.Trim
    '        Else
    '            If .Item("VALCTE").ToString.Trim = 1 And .Item("COSTOS").ToString.Trim = "" Then
    '                strTarifa = strTarifa & " por"
    '            End If
    '        End If
    '        If .Item("VALMIN").ToString.Trim > 0 Then
    '            strTarifa = strTarifa & " de " & Format(CType(.Item("VALMIN").ToString.Trim, Double), "###,###,###,##0")
    '        End If
    '        If .Item("VALMAX").ToString.Trim > 0 Then
    '            strTarifa = strTarifa & " a " & Format(CType(.Item("VALMAX").ToString.Trim, Double), "###,###,###,##0")
    '        End If
    '        If .Item("MEDIDA").ToString.Trim <> "" Then
    '            strTarifa = strTarifa & " " & .Item("MEDIDA").ToString.Trim
    '        End If
    '        If .Item("VEHICULO").ToString.Trim <> "" Then
    '            strTarifa = strTarifa & " utilizando " & .Item("VEHICULO").ToString.Trim
    '        End If
    '        'If .Item("COSTOS").ToString.Trim <> "" Then
    '        '    strTarifa = strTarifa & " (" & .Item("TSGNMN").ToString.Trim & ")"
    '        'End If
    '    End With
    '    Return strTarifa
    'End Function

    Private Function Lista_Servicios(ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecSer As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrComp)
        lobjParams.Add("PSCDVSN", pstrDiv)
        lobjParams.Add("PNCPLNDV", pstrPlt)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PNFECSER", pdblFecSer)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_TARIFA_SERVICIO_X_DIVISION", lobjParams)
        Return dt
    End Function

    Private Function Lista_Servicios_Tarifa_Fija(ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecSer As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrComp)
        lobjParams.Add("PSCDVSN", pstrDiv)
        lobjParams.Add("PNCPLNDV", pstrPlt)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PNFECSER", pdblFecSer)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_TARIFA_FIJA_SERVICIO_X_DIVISION", lobjParams)
        Return dt
    End Function

    Private Function Lista_Tarifa_Servicios_Cliente(ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecSer As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrComp)
        lobjParams.Add("PSCDVSN", pstrDiv)
        lobjParams.Add("PNCPLNDV", pstrPlt)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PNFECSER", pdblFecSer)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_TARIFA_SERVICIO_CLIENTE_X_DIVISION", lobjParams)
        Return dt
    End Function

#End Region

End Class

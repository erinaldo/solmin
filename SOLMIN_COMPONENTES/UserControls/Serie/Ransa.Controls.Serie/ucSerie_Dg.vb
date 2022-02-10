Imports System.ComponentModel
Imports Ransa.TYPEDEF
'Imports Ransa.NEGO
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

'abraham
Public Class ucSerie_Dg
    Private colListas As New Hashtable
    Private errProvider As New ErrorProvider
    Private _Cantidad As Int32
    Private _Usuario As String
    Private _Pedido As Double = 0
    Private _NrItem As Double = 0
    Public Event VizualizarSerie()

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        colListas = New Hashtable
        pnlMensaje.Visible = False
        dgSerie.ShowCellErrors = True
    End Sub

    Private _GridTipo As eGridSerieTipo
    <Browsable(True)> _
    Public Property GridTipo() As eGridSerieTipo
        Get
            If _GridTipo = Nothing Then _GridTipo = eGridSerieTipo.Ninguno
            Return _GridTipo
        End Get
        Set(ByVal value As eGridSerieTipo)
            _GridTipo = value
            btnAgregar.Visible = False
            If value = eGridSerieTipo.IngresoSerie Then
                kheTitulo.Text = "Registro Serie - Ingreso"
                dgSerie.Columns("PNNCRPLL").Visible = True
                dgSerie.Columns("PSCSRECL").Visible = True
                dgSerie.Columns("PSCSRECL").ReadOnly = False
                dgSerie.Columns("FSAL").Visible = False
            ElseIf value = eGridSerieTipo.DespachoSerie Then
                kheTitulo.Text = "Registro Serie - Despacho"
                dgSerie.Columns("PNNCRPLL").Visible = True
                dgSerie.Columns("PSCSRECL").ReadOnly = True
                dgSerie.Columns("FSAL").Visible = True
                btnAgregar.Visible = True
            Else
                kheTitulo.Text = "Registro Serie - Sin Tipo"
                dgSerie.Columns("PNNCRPLL").Visible = False
                dgSerie.Columns("PSCSRECL").Visible = False
                dgSerie.Columns("FSAL").Visible = False
            End If
        End Set
    End Property

    <Browsable(True)> _
    Public Property DespachoIsReadOnly() As Boolean
        Get
            Return dgSerie.Columns("FSAL").ReadOnly
        End Get
        Set(ByVal value As Boolean)
            dgSerie.Columns("FSAL").ReadOnly = value
        End Set
    End Property

    'Private _GuiaIngreso As Int64
    ' <Browsable(False)> _
    'Public ReadOnly Property GuiaIngreso() As Int32
    '  Get
    '    Return _GuiaIngreso
    '  End Get
    'End Property

    Private _IsGuardarValido As Boolean
    Public ReadOnly Property IsGuardarValido() As Boolean
        Get
            Return _IsGuardarValido
        End Get
    End Property

    Public ReadOnly Property dblPedido() As Double
        Get
            Return _Pedido
        End Get
    End Property

    Public ReadOnly Property dblCantidadSerie()
        Get
            Dim intCantidad As Decimal = 0
            Dim intVar As Integer = 0
            If GridTipo = eGridSerieTipo.DespachoSerie Then
                For Each de As DictionaryEntry In colListas
                    Dim intValor As Integer = 0
                    intVar = 0
                    For intX As Integer = 0 To de.Value.Count - 1
                        If CType(de.Value, List(Of beSerie)).Item(intX).IsDespacho Then
                            intValor = intValor + 1
                        End If
                    Next
                    intVar = Math.Ceiling(intValor / 3)
                    intCantidad = intCantidad + intVar
                Next
            End If
            Return intCantidad
        End Get
    End Property

    Public ReadOnly Property Cantidad() As Int32
        Get
            Return _Cantidad
        End Get
    End Property

    Public ReadOnly Property Usuario() As String
        Get
            Return _Usuario
        End Get
    End Property

    Public WriteOnly Property CheckAll() As Boolean
        Set(ByVal value As Boolean)
            For Each drv As DataGridViewRow In dgSerie.Rows
                drv.Cells("FSAL").Value = value
            Next
        End Set
    End Property

    'Private Function IsValido() As Boolean
    '    If GridTipo = eGridSerieTipo.DespachoSerie Then
    '        For Each de As DictionaryEntry In colListas
    '            ''miList = de.Value
    '            'For Each oSerie As beSerie In miList
    '            '    If oSerie.IsDespacho Then
    '            '        oSerie.PSSSTINV = "0"
    '            '        obrSerie.Update(oSerie)
    '            '    End If
    '            'Next
    '        Next
    '    End If
    'End Function

    'Public Sub IngresoSeries(ByVal nOrdenServicio As Int64, ByVal nNroItem As Int32, ByVal nCantidad As Decimal, ByVal sCliente As Int32, ByVal nGuiaIngreso As Int32, ByVal sUsuario As String) 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
    '    Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItem)
    '    _Usuario = sUsuario
    '    If Not colListas.ContainsKey(key) Then CreateListVirtual(key, nCantidad, sCliente, nGuiaIngreso, nNroItem)
    '    dgSerie.AutoGenerateColumns = False
    '    dgSerie.DataSource = colListas(key)
    'End Sub


    Public Sub IngresoSeries_V2(ByVal nOrdenServicio As Int64, FilaReg As Int32, ByVal nNroItem As Int32, ByVal nCantidad As Decimal, ByVal sCliente As Int32, ByVal nGuiaIngreso As Int32, ByVal sUsuario As String) 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
        Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, FilaReg)
        _Usuario = sUsuario
        If Not colListas.ContainsKey(key) Then CreateListVirtual(key, nCantidad, sCliente, nGuiaIngreso, nNroItem)
        dgSerie.AutoGenerateColumns = False
        dgSerie.DataSource = colListas(key)

    End Sub


    


    ''' <summary>
    ''' Retorna las series de la recepción
    ''' </summary>
    ''' <param name="nOrdenServicio">Orde de servicio</param>
    ''' <param name="nNroItem">Nro. de item</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function ListaSerieXOrdenDeServicioDespacho(ByVal nOrdenServicio As Int64, ByVal nNroItem As Int32) As List(Of Ransa.TYPEDEF.beSerie)
    '    Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItem)
    '    Dim olbeSerie As New List(Of TYPEDEF.beSerie)
    '    If colListas.ContainsKey(key) Then
    '        For Each obeSerie As beSerie In colListas(key)
    '            If obeSerie.IsDespacho Then
    '                olbeSerie.Add(obeSerie)
    '            End If
    '        Next
    '    End If
    '    Return olbeSerie
    'End Function
    Public Function ListaSerieXOrdenDeServicioDespacho(ByVal nOrdenServicio As Int64, ByVal nNroItem As Int32) As List(Of beSerie)
        Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItem)
        Dim olbeSerie As New List(Of beSerie)
        If colListas.ContainsKey(key) Then
            For Each obeSerie As beSerie In colListas(key)
                If obeSerie.IsDespacho Then
                    olbeSerie.Add(obeSerie)
                End If
            Next
        End If
        Return olbeSerie
    End Function

    Public Function ListaSerieXOrdenDeServicioIngreso(ByVal nOrdenServicio As Int64, ByVal nNroItem As Int32) As List(Of Ransa.Controls.Serie.beSerie)
        Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItem)
        Dim olbeSerie As New List(Of beSerie)
        If colListas.ContainsKey(key) Then
            For Each obeSerie As beSerie In colListas(key)
                If Not String.IsNullOrEmpty(obeSerie.PSCSRECL.Trim()) Then
                    olbeSerie.Add(obeSerie)
                End If
            Next
        End If
        Return olbeSerie
    End Function

    Public Function ValidarCantidadSerieXOSIngreso(ByRef pExisteError As Boolean, FlagCtrlSerie As Boolean, QTotalTrx As Decimal, ByVal nOrdenServicio As Int64, SKU As String, ByVal nFilaReg As Int32) As String

        dgSerie.EndEdit()
        Dim msg As String = ""
        Dim CantPendiente As Int64 = 0
        Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nFilaReg)
        Dim CantSeries As Int64 = 0
        pExisteError = False
        If colListas.ContainsKey(key) Then
            For Each obeSerie As beSerie In colListas(key)
                If Not String.IsNullOrEmpty(obeSerie.PSCSRECL.Trim()) Then
                    CantSeries = CantSeries + 1
                End If
            Next
        End If
        CantPendiente = QTotalTrx - CantSeries
        If CantPendiente > 0 Then
            If FlagCtrlSerie = True Then
                pExisteError = True
            End If
            msg = "F(" & nFilaReg + 1 & ") Series pendientes de Ingreso en el SKU " & SKU & " : " & CantPendiente
        End If
        If CantPendiente < 0 Then
            If FlagCtrlSerie = True Then
                pExisteError = True
            End If
            msg = "F(" & nFilaReg + 1 & ") Series excedidos en el Ingreso para el SKU " & SKU & " : " & CantPendiente
        End If
        Return msg
    End Function

    Public Function ValidarCantidadSerieXOSDespacho(ByRef pExisteError As Boolean, FlagCtrlSerie As Boolean, QTotalTrx As Decimal, ByVal nOrdenServicio As Int64, SKU As String, ByVal nNroItemPedido As Int32, nFilaReg As Int32) As String

        dgSerie.EndEdit()
        Dim msg As String = ""
        Dim CantPendiente As Int64 = 0
        Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItemPedido)
        Dim CantSeries As Int64 = 0
        pExisteError = False
        If colListas.ContainsKey(key) Then
            For Each obeSerie As beSerie In colListas(key)
                If obeSerie.IsDespacho Then
                    CantSeries = CantSeries + 1
                End If
            Next
        End If
        CantPendiente = QTotalTrx - CantSeries
        If CantPendiente > 0 Then
            If FlagCtrlSerie = True Then
                pExisteError = True
            End If
            msg = "F(" & nFilaReg + 1 & ") Series pendientes de Despacho en el SKU " & SKU & " : " & CantPendiente
        End If
        If CantPendiente < 0 Then
            If FlagCtrlSerie = True Then
                pExisteError = True
            End If
            msg = "F(" & nFilaReg + 1 & ") Series excedidos en el despacho para el SKU " & SKU & " : " & CantPendiente
        End If
        Return msg
    End Function


    Public Sub DespachoSeries(ByVal dblPedido As Double, ByVal nOrdenServicio As Int64, ByVal nNroItem As Integer, ByVal nCantidad As Decimal, ByVal susuario As String) 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
        Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItem)
        _Pedido = dblPedido
        _Cantidad = nCantidad
        _Usuario = susuario
        _NrItem = nNroItem
        If Not colListas.Contains(key) Then GetDataList(key, nNroItem)
        dgSerie.AutoGenerateColumns = False
        dgSerie.DataSource = colListas(key)
    End Sub

    Private Sub GetDataList(ByVal key As KeyValuePair(Of Int64, Int32), ByVal nNroItem As Int32)
        Dim obrSerie As New brSerie
        Dim li As List(Of beSerie) = obrSerie.Listar(key.Key, dblPedido)
        For intCont As Integer = 0 To li.Count - 1
            li.Item(intCont).PNNRITOC = _NrItem
        Next
        colListas.Add(key, li)
    End Sub

    Private Sub CreateListVirtual(ByVal key As KeyValuePair(Of Int64, Int32), ByVal Cantidad As Int32, ByVal sCliente As Int32, ByVal nGuia As Int32, ByVal nNroItem As Int32)
        Dim lista As List(Of beSerie) = New List(Of beSerie)
        For i As Int32 = 1 To Cantidad
            Dim obj As New beSerie
            obj.PNNORDSR = key.Key
            obj.PNNRITOC = nNroItem
            obj.PNNCRPLL = Convert.ToDecimal(i)
            obj.PNNGUIIN = Convert.ToDecimal(nGuia)
            obj.PSCSRECL = ""
            obj.PNCCLNT = sCliente
            lista.Add(obj)
        Next
        colListas.Add(key, lista)
    End Sub

    'Public Function Guardar(ByVal nGuiaRansa As Int64, ByVal objMovimientoMercaderia As slnSOLMIN_SDSIMPLE.clsMovimientoMercaderia) As Boolean
    Public Function Guardar(ByVal nGuiaRansa As Int64, ByVal objMovimientoMercaderia As clsMovimientoMercaderia) As Boolean
        Dim valor As Boolean = True
        Try
            Me.dgSerie.EndEdit()

            '  _GuiaIngreso = nGuiaRansa
            If colListas.Count > 0 Then
                Dim obrSerie As New brSerie
                Dim miList As List(Of beSerie)
                If GridTipo = eGridSerieTipo.IngresoSerie Then
                    If Not IsErrors() Then
                        For Each de As DictionaryEntry In colListas
                            miList = de.Value
                            For Each oSerie As beSerie In miList
                                If Not String.IsNullOrEmpty(oSerie.PSCSRECL.Trim()) Then
                                    oSerie.PSSSTINV = "1"
                                    oSerie.PNNGUIIN = nGuiaRansa
                                    oSerie.PNFINGAL = Format(Date.Now.Date, "yyyyMMdd")
                                    oSerie.PNFCHCRT = Format(Date.Now.Date, "yyyyMMdd")
                                    oSerie.PNHRACRT = Format(Date.Now, "hhmmss")
                                    oSerie.PNHINGAL = Format(Date.Now, "hhmmss")
                                    oSerie.PSSESTRG = "A"
                                    oSerie.PSCUSCRT = Usuario
                                    obrSerie.Insertar(oSerie)
                                End If
                            Next
                        Next
                    End If
                ElseIf GridTipo = eGridSerieTipo.DespachoSerie Then
                    For Each de As DictionaryEntry In colListas
                        miList = de.Value
                        For Each oSerie As beSerie In miList
                            If oSerie.IsDespacho Then
                                oSerie.PSSSTINV = "2"
                                oSerie.PNNGUISL = nGuiaRansa
                                oSerie.PNFSLDAL = Format(Date.Now.Date, "yyyyMMdd")
                                oSerie.PNFULTAC = Format(Date.Now.Date, "yyyyMMdd")
                                oSerie.PNHSLDAL = Format(Date.Now, "hhmmss")
                                oSerie.PNHULTAC = Format(Date.Now, "hhmmss")
                                oSerie.PSCULUSA = _Usuario
                                oSerie.PSSESTRG = "A"
                                If Not (objMovimientoMercaderia Is Nothing) Then
                                    ''Buscamos Nr de Movimiento de la orden de servicio
                                    oSerie.PNNRITOC = BuscarSolicitudServicioSalida_NSLCSS(objMovimientoMercaderia, oSerie.PNNORDSR, oSerie.PNNRITOC)
                                End If
                                obrSerie.Update(oSerie)
                            End If
                        Next
                    Next
                End If
                'colListas.Clear()
                valor = True
            Else
                valor = False
            End If
        Catch ex As Exception
            valor = False
        End Try
        Return valor
    End Function

#Region "Buscar"
    'Private Function BuscarSolicitudServicioSalida_NSLCSS(ByVal objMovimientoMercaderia As slnSOLMIN_SDSIMPLE.clsMovimientoMercaderia, ByVal dblOrdenDeServicio As Double, ByVal dblNrItemPedidoPLanta As Double)
    '    For Each objItemMovimientoMercaderia As slnSOLMIN_SDSIMPLE.clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
    '        If objItemMovimientoMercaderia.pintOrdenServicio_NORDSR = dblOrdenDeServicio And objItemMovimientoMercaderia.NrItemPedidoPLanta_CDREGP = dblNrItemPedidoPLanta Then
    '            Return objItemMovimientoMercaderia.pintNroSolicitudSalida_NSLCSS
    '            Exit Function
    '        End If
    '    Next
    '    Return 0
    'End Function
    Private Function BuscarSolicitudServicioSalida_NSLCSS(ByVal objMovimientoMercaderia As clsMovimientoMercaderia, ByVal dblOrdenDeServicio As Double, ByVal dblNrItemPedidoPLanta As Double)
        For Each objItemMovimientoMercaderia As clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
            If objItemMovimientoMercaderia.pintOrdenServicio_NORDSR = dblOrdenDeServicio And objItemMovimientoMercaderia.NrItemPedidoPLanta_CDREGP = dblNrItemPedidoPLanta Then
                Return objItemMovimientoMercaderia.pintNroSolicitudSalida_NSLCSS
                Exit Function
            End If
        Next
        Return 0
    End Function

#End Region

    Private Sub dgSerie_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgSerie.CellBeginEdit
       

        If dgSerie.Columns(e.ColumnIndex).Name = "FSAL" Then
            'If e.ColumnIndex = 2 Then
            If Cantidad = GetCantidades() Then
                Dim value As Boolean = dgSerie.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If value = False Then
                    statusBar.Values.Description = "no puede seleccionar mas series."
                    e.Cancel = True
                Else
                    statusBar.Values.Description = ""
                End If

            End If
        End If
    End Sub


    Public Function GetCantidades() As Int32
        Dim ncanti As Int32 = 0
        For Each obj As DataGridViewRow In dgSerie.Rows
            'If obj.Cells(2).Value = True Then
            '    ncanti += 1
            'End If
            If obj.Cells("FSAL").Value = True Then
                ncanti += 1
            End If
        Next
        Return ncanti

    End Function

    Private Sub dgSerie_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSerie.CellEndEdit
        'If Me.dgSerie.Item(1, e.RowIndex).Value.ToString.Trim.Equals("") Then
        '    Me.dgSerie.Item(1, e.RowIndex).Value = ""
        'End If
        If Me.dgSerie.Item("PSCSRECL", e.RowIndex).Value.ToString.Trim.Equals("") Then
            Me.dgSerie.Item("PSCSRECL", e.RowIndex).Value = ""
        End If


    End Sub

    Private Sub dgSerie_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgSerie.CellValidating
        If e.RowIndex = -1 Then Exit Sub
        If String.IsNullOrEmpty(e.FormattedValue) Then Exit Sub
        If Me.GridTipo = eGridSerieTipo.IngresoSerie Then
            Dim isEdit As Boolean = dgSerie.Rows(e.RowIndex).Cells(e.ColumnIndex).IsInEditMode
            If dgSerie.Columns(e.ColumnIndex).Name = "PSCSRECL" Then
                'If e.ColumnIndex = 1 Then
                'dgSerie.EndEdit()
                Dim MiLis As List(Of beSerie) = dgSerie.DataSource
                Dim serie As String = e.FormattedValue
                Dim nCount As Int32 = 0
                Dim nInt As Int32 = 0
                For Each oSer As beSerie In MiLis
                    If nInt = e.RowIndex Then
                        nInt += 1
                        Continue For
                    End If
                    nInt += 1
                    If oSer.PSCSRECL Is Nothing Then Continue For
                    If oSer.PSCSRECL.ToLower() = serie.ToLower() Then
                        nCount += 1
                    End If
                Next
                If (nCount > 1) Or (nCount = 1 And isEdit = True) Then
                    MessageBox.Show("La serie ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Function IsErrors() As Boolean
        Dim valor As Boolean = False
        Dim miList As List(Of beSerie)
        Dim nCount As Int32 = 0

        For Each de As DictionaryEntry In colListas
            miList = de.Value
            For Each oSerie As beSerie In miList
                If oSerie.Isfallacy Then nCount += 1
            Next
        Next
        If nCount > 0 Then
            pnlMensaje.Left = (dgSerie.Width - pnlMensaje.Width) / 2
            pnlMensaje.Top = (dgSerie.Height - pnlMensaje.Height) / 2
            lblError.Text = nCount.ToString
            pnlMensaje.Visible = True
            valor = True
        End If
        Return valor
    End Function

    Private Sub ButtonSpecAny1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecAny1.Click
        pnlMensaje.Visible = False
    End Sub

    Private Sub dgSerie_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgSerie.ColumnHeaderMouseClick

       
        If dgSerie.Columns(e.ColumnIndex).Name = "FSAL" Then
            'If e.ColumnIndex = 2 Then
            dgSerie.EndEdit()
            Dim ncanti As Int32 = GetCantidades()
            If Cantidad > ncanti Then
                ncanti = Cantidad - ncanti
                For Each obj As DataGridViewRow In dgSerie.Rows
                    'If obj.Cells(2).Value = False And ncanti > 0 Then
                    '    obj.Cells(2).Value = True
                    '    ncanti -= 1
                    'End If
                    If obj.Cells("FSAL").Value = False And ncanti > 0 Then
                        obj.Cells("FSAL").Value = True
                        ncanti -= 1
                    End If
                Next
            ElseIf Cantidad = ncanti Then
                For Each obj As DataGridViewRow In dgSerie.Rows
                    'obj.Cells(2).Value = False
                    obj.Cells("FSAL").Value = False
                Next
            End If
        End If
    End Sub

    Public Sub EliminarSeries(ByVal nOrdenServicio As Int64, ByVal nNroItem As Int32)
        Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItem)
        If Me.GridTipo = eGridSerieTipo.IngresoSerie Then
            If colListas.ContainsKey(key) Then
                colListas.Remove(key)
            End If
        Else
            If colListas.ContainsKey(key) Then
                colListas.Remove(key)
            End If
        End If
    End Sub

    Public Sub EliminarSeries(ByVal nOrdenServicio As Int64)
        If Me.GridTipo = eGridSerieTipo.DespachoSerie Then
            Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, 5)
            If colListas.ContainsKey(key) Then
                colListas.Remove(key)
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        RaiseEvent VizualizarSerie()
    End Sub


    ''' <summary>
    ''' Verifica que la cantidad 
    ''' </summary>
    ''' <param name="nOrdenServicio"></param>
    ''' <param name="nNroItem"></param>
    ''' <remarks></remarks>

    'Public Function IsEqualsCantidadSeriesPorOs(ByVal nOrdenServicio As Int64, ByVal nNroItem As Integer, ByVal ndblCantidad As Decimal) As Boolean
    '    Dim key As New KeyValuePair(Of Int64, Int32)(nOrdenServicio, nNroItem)
    '    If Not colListas.Contains(key) Then GetDataList(key, nNroItem)
    '    dgSerie.EndEdit()
    '    'Return colListas(key).Count
    '    Dim dblCantidad As Decimal = 0
    '    For intX As Integer = 0 To colListas(key).Count - 1
    '        If CType(colListas(key).Item(intX), beSerie).IsDespacho Then
    '            dblCantidad = dblCantidad + 1
    '        End If
    '    Next
    '    If ndblCantidad = dblCantidad Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

End Class


Public Enum eGridSerieTipo As Integer
    Ninguno = -1
    IngresoSerie = 1
    DespachoSerie = 2
End Enum

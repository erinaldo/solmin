Imports System.Windows.Forms
Imports System.ComponentModel
'Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.TypeDef.slnSOLMIN_SDS_SIMPLE

Public Class ucLote

#Region "Variables Privadas"

    Private colLote As Hashtable
    Private _OrdenServicio As Decimal = 0
    Private IsError As Boolean
    Private IsEstado As Integer = 0
    Private _RowCount As Integer = 0
    Private _NumeroLote As Integer = 0
    Private _CantidadPedidoPendiente As Integer = 0
    Private _CantidadAtendida As Integer = 0
    Private _NumeroGuiaRansa As Decimal = 0
    Private _Usuario As String = String.Empty
    'Private _LISTAMM As New List(Of slnSOLMIN_SDS.clsItemMovimientoMercaderia)
    Private _LISTAMM As New List(Of clsItemMovimientoMercaderia)
#End Region

#Region "Propiedades Públicas"


    Private _intIndex As Integer
    Public Property intIndex() As Integer
        Get
            Return _intIndex
        End Get
        Set(ByVal value As Integer)
            _intIndex = value
        End Set
    End Property

    Public Property OrdenServicio() As Decimal
        Get
            Return _OrdenServicio
        End Get
        Set(ByVal value As Decimal)
            _OrdenServicio = value
        End Set
    End Property
    Public ReadOnly Property RowCount() As Integer
        Get
            Return _RowCount
        End Get
    End Property
    Public ReadOnly Property NumeroLote() As Integer
        Get
            Return _NumeroLote
        End Get
    End Property

    Public Property CantidadPedidoPendiente() As Integer
        Get
            Return _CantidadPedidoPendiente
        End Get
        Set(ByVal value As Integer)
            If value > -1 Then
                _CantidadPedidoPendiente = value
            End If

        End Set
    End Property

    Public ReadOnly Property CantidadAtendida() As Integer
        Get
            Return _CantidadAtendida
        End Get
    End Property

    Public Property NumeroGuiaRansa() As Decimal
        Get
            Return _NumeroGuiaRansa
        End Get
        Set(ByVal value As Decimal)
            _NumeroGuiaRansa = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    'Public Property LISTAMM() As List(Of slnSOLMIN_SDS.clsItemMovimientoMercaderia)
    '    Get
    '        Return _LISTAMM
    '    End Get
    '    Set(ByVal value As List(Of slnSOLMIN_SDS.clsItemMovimientoMercaderia))
    '        _LISTAMM = value
    '    End Set
    'End Property
    Public Property LISTAMM() As List(Of clsItemMovimientoMercaderia)
        Get
            Return _LISTAMM
        End Get
        Set(ByVal value As List(Of clsItemMovimientoMercaderia))
            _LISTAMM = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        InitializeComponent()
        colLote = New Hashtable
    End Sub

#End Region

#Region "Métodos"
    Public Sub Limpiar()
        colLote.Clear()
    End Sub

    Public Sub LimpiarDatasourse()
        dgLote.Rows.Clear()
    End Sub
    Private ActivarValidacion As Boolean = False
    Public Sub ListarLotes()
        'Try
        Dim Clave As String
        Clave = String.Format("{0}-{1}", _OrdenServicio.ToString(), _intIndex.ToString())
        Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)

        Dim dtLista As DataTable = CType(colLote(key), DataTable)

        If dtLista Is Nothing Then
            Dim obeLote As New Ransa.TYPEDEF.beLote
            dgLote.AutoGenerateColumns = False
            obeLote.NORDSR = _OrdenServicio
            'Dim objLote As New brLote
            Dim objLote As New brLote_BL
            dtLista = objLote.ListaDeLotesPorOC(obeLote)
            colLote.Add(key, dtLista)
        End If
        ActivarValidacion = False
        dgLote.DataSource = CType(colLote(key), DataTable)
        ActivarValidacion = True
        _RowCount = dtLista.Rows.Count
        If dtLista.Rows.Count = 0 Then
            _NumeroLote = 0
        End If
        'Catch ex As Exception

        'End Try

    End Sub

    Public Function ObtenerTotalCantidades(ByVal os As Decimal, ByVal index As Integer) As Decimal
        Dim total As Decimal = 0
        'Try
        Dim Clave As String
        Clave = String.Format("{0}-{1}", _OrdenServicio.ToString(), _intIndex.ToString())
        Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)

        Dim dtLista As DataTable = CType(colLote(key), DataTable)
        If Not dtLista Is Nothing Then
            If dtLista.Rows.Count > 0 Then

                Dim i As Integer = 0
                For i = 0 To dtLista.Rows.Count - 1
                    If Val(dtLista.Rows(i).Item("CANTIDAD").ToString()) > 0 Then
                        total = total + Val(dtLista.Rows(i).Item("CANTIDAD").ToString())
                    End If
                Next
            End If
        End If
        'Catch ex As Exception

        'End Try
        Return total
    End Function

    Public Sub ResetearCantidades()
        'Try

        Dim Clave As String = String.Format("{0}-{1}", _OrdenServicio.ToString(), _intIndex.ToString())


        Dim okeys As New List(Of Object)
        For Each item As Object In colLote
            If item.Key.Key.ToString().Contains(Clave) Then
                okeys.Add(item.Key)
            End If
        Next
        For Each itemKey As Object In okeys
            colLote.Remove(itemKey)

        Next

        ListarLotes()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub LimpiarLotes()
        colLote = New Hashtable
    End Sub

    Public Sub Guardar()
        'Dim broLote As New brLote()
        Dim broLote As New brLote_BL
        Dim obeLote As New beLote()
        Dim LstLote As New List(Of beLote)

        Dim i As Integer
        Dim j As Integer
        Dim dt As DataTable
        Dim row As DataRow

        'For Each item As slnSOLMIN_SDS.clsItemMovimientoMercaderia In LISTAMM
        Dim item As clsItemMovimientoMercaderia = LISTAMM(0)

        For Each obeMoviOS As clsItemMovimientoMercaderia In LISTAMM
            If obeMoviOS.intCorrelativo = 0 Then
                Dim Clave As String = String.Format("{0}-{1}", obeMoviOS.pintOrdenServicio_NORDSR.ToString(), obeMoviOS.NrItemPedidoPLanta_CDREGP.ToString())
                Dim key As New KeyValuePair(Of String, Int32)(Clave, obeMoviOS.NrItemPedidoPLanta_CDREGP)


                dt = CType(colLote(key), DataTable)
                If dt Is Nothing Then
                    Continue For
                End If
                For j = 0 To dt.Rows.Count - 1
                    row = dt.Rows(j)
                    If Val(row.Item("CANTIDAD")) > 0 Then
                        obeLote = New Ransa.TypeDef.beLote()
                        With obeLote
                            .NORDSR = obeMoviOS.pintOrdenServicio_NORDSR
                            .NCRRIN = row.Item("NCRRIN")
                            .NGUIRN = NumeroGuiaRansa
                            .QCMMC1 = Val(row.Item("CANTIDAD").ToString())
                            .QCMMP1 = 0
                            .CTPOAT = "S"
                            .NGUIRN = NumeroGuiaRansa
                            .NSLCS1 = obeMoviOS.pintNroSolicitudSalida_NSLCSS
                            .CTPALM = obeMoviOS.pstrTipoAlmacen_CTPALM
                            .CALMC = obeMoviOS.pstrAlmacen_CALMC
                            .CZNALM = obeMoviOS.pstrZonaAlmacen_CZNALM
                            .CULUSA = Usuario
                        End With
                        LstLote.Add(obeLote)
                    End If

                Next
            End If

        Next

        'For Each hsitem As Object In colLote
        '    dt = hsitem.value
        '    For j = 0 To dt.Rows.Count - 1
        '        row = dt.Rows(j)

        '        If Val(row.Item("CANTIDAD")) > 0 Then
        '            obeLote = New Ransa.TYPEDEF.beLote()
        '            With obeLote
        '                .NORDSR = item.pintOrdenServicio_NORDSR
        '                .NCRRIN = row.Item("NCRRIN")
        '                .NGUIRN = NumeroGuiaRansa
        '                .QCMMC1 = Val(row.Item("CANTIDAD").ToString())
        '                .QCMMP1 = 0
        '                .CTPOAT = "S"
        '                .NGUIRN = NumeroGuiaRansa
        '                .NSLCS1 = item.pintNroSolicitudSalida_NSLCSS
        '                .CTPALM = item.pstrTipoAlmacen_CTPALM
        '                .CALMC = item.pstrAlmacen_CALMC
        '                .CZNALM = item.pstrZonaAlmacen_CZNALM
        '                .CULUSA = Usuario
        '            End With
        '            LstLote.Add(obeLote)
        '        End If

        '    Next
        'Next

        'Next

        If LstLote.Count > 0 Then
            broLote.RegistrarDespachoLote(LstLote)
        End If
    End Sub
#End Region

#Region "Eventos"
    Public Event SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event CambiarCantidad(ByVal sender As System.Object, ByVal e As System.EventArgs)


    Private Sub dgLote_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgLote.EditingControlShowing
        Try
            Dim columna As Integer = dgLote.CurrentCell.ColumnIndex
            If dgLote.Columns(columna).Name = "CANTIDAD" Then
                Dim validar As TextBox = CType(e.Control, TextBox)
                If validar IsNot Nothing Then
                    AddHandler validar.KeyPress, AddressOf validar_Keypress
                Else
                    RemoveHandler validar.KeyPress, AddressOf validar_Keypress
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub dgLote_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLote.SelectionChanged
        Try
            If Not dgLote.CurrentRow Is Nothing Then
                _NumeroLote = Convert.ToInt32(dgLote.CurrentRow.Cells("NCRRIN").Value)
                _CantidadAtendida = Convert.ToInt32(dgLote.CurrentRow.Cells("CANTIDAD").Value)
            Else
                _NumeroLote = 0
                _CantidadAtendida = 0
            End If
            RaiseEvent SelectionChanged(Me, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub dgLote_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgLote.CellValidating
        Try
            If e.ColumnIndex > -1 And e.RowIndex > -1 And ActivarValidacion = True Then
                If dgLote.Columns(e.ColumnIndex).Name = "CANTIDAD" Then
                    If IsNumeric(e.FormattedValue.ToString()) And e.FormattedValue.ToString().Trim <> String.Empty Then
                        Dim Stock As Int32 = Convert.ToInt32(dgLote.CurrentRow.Cells("QMRCSL").Value)
                        Dim Cant As Integer = Convert.ToInt32(e.FormattedValue.ToString())

                        If Cant > Stock Then
                            MessageBox.Show("Cantidad Atender Lote no debe ser mayor a la cantidad stock Lote", "Lote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                        Else
                            Dim suma As Integer = 0
                            Dim i As Integer = 0
                            For i = 0 To dgLote.Rows.Count - 1
                                If i = e.RowIndex Then
                                    suma = suma + Cant
                                Else
                                    suma = suma + Convert.ToInt32(dgLote.Rows(i).Cells("CANTIDAD").Value)
                                End If
                            Next

                            If suma > Me.CantidadPedidoPendiente Then
                                MessageBox.Show("Cantidad Atender Lote no debe ser mayor a la cantidad antender Pedido", "Lote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                            Else
                                _CantidadAtendida = Cant
                                RaiseEvent SelectionChanged(sender, e)
                                If Convert.ToInt32(Cant) <> Convert.ToInt32(dgLote.CurrentRow.Cells("CANTIDAD").Value) Then
                                    RaiseEvent CambiarCantidad(sender, e)
                                End If

                            End If
                        End If

                    Else
                        If e.FormattedValue.ToString().Trim <> String.Empty Then
                            MessageBox.Show("El valor ingresado no es válido", "Lote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                        End If
                    End If
                    If Convert.ToInt32(e.FormattedValue.ToString()) <> Convert.ToInt32(dgLote.CurrentRow.Cells("CANTIDAD").Value) Then
                        RaiseEvent CambiarCantidad(sender, e)
                    End If
                End If

                ' RaiseEvent CambiarCantidad(sender, e)
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try

    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = dgLote.CurrentCell.ColumnIndex
        If dgLote.Columns(columna).Name = "CANTIDAD" Then
            IsEstado = 1
            Dim caracter As Char = e.KeyChar

            Dim c = ChrW(Keys.Escape)
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False And caracter <> "." And caracter <> "," And e.KeyChar <> ChrW(Keys.Escape) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

#End Region

End Class

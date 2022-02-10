Imports System.Windows.Forms
Imports System.ComponentModel

Public Class ucUbicaciones_Dg

    Private colUbicaciones As Hashtable
    Private colDespachos As Hashtable
    Private ColGuardar As Hashtable
    Private IsError As Boolean
    Private IsEstado As Integer = 0

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        colUbicaciones = New Hashtable
        colDespachos = New Hashtable
        ColGuardar = New Hashtable

    End Sub

    <Browsable(True)> _
    Public Property VisibleCaption() As Boolean
        Get
            Return KryptonHeader1.Visible
        End Get
        Set(ByVal value As Boolean)
            KryptonHeader1.Visible = value
        End Set
    End Property

    <Browsable(True)> _
    Public Property PanelSearch() As Boolean
        Get
            Return panSearch.Visible
        End Get
        Set(ByVal value As Boolean)
            panSearch.Visible = value
        End Set
    End Property

    Private _Regularizacion As Boolean
    <Browsable(False)> _
  Public WriteOnly Property Regularizacion() As Boolean
        Set(ByVal value As Boolean)
            _Regularizacion = value
        End Set
    End Property



    Private _nLote As Integer
    Public Property nLote() As Integer
        Get
            Return _nLote
        End Get
        Set(ByVal value As Integer)
            _nLote = value
        End Set
    End Property


    Private _IndexMercaderia As Integer
    Public Property IndexMercaderia() As Integer
        Get
            Return _IndexMercaderia
        End Get
        Set(ByVal value As Integer)
            _IndexMercaderia = value
        End Set
    End Property

    Private _Zona As String
    <Browsable(False)> _
    Public ReadOnly Property Zona() As String
        Get
            Return _Zona
        End Get
    End Property

    Private _Cliente As Decimal
    Public ReadOnly Property Cliente() As Decimal
        Get
            Return _Cliente
        End Get
    End Property

    Private _OrdenServicio As Decimal
    Public ReadOnly Property OrdenServicio() As Decimal
        Get
            Return _OrdenServicio
        End Get
    End Property

    Private _Mobile As Boolean
    Public ReadOnly Property Mobile() As Boolean
        Get
            Return _Mobile
        End Get
    End Property

    Private _TipoAlmacen As String
    <Browsable(False)> _
    Public ReadOnly Property TipoAlmacen() As String
        Get
            Return _TipoAlmacen
        End Get
    End Property

    Private _Almacen As String
    <Browsable(False)> _
    Public ReadOnly Property Almacen() As String
        Get
            Return _Almacen
        End Get
    End Property

    Private _Cantidad As Decimal
    <Browsable(False)> _
    Public ReadOnly Property Cantidad() As Decimal
        Get
            Return _Cantidad
        End Get
    End Property

    Private _Usuario As String
    <Browsable(False)> _
    Public ReadOnly Property Usuario() As String
        Get
            Return _Usuario
        End Get
    End Property

    Private _Mercaderia As String
    <Browsable(False)> _
    Public ReadOnly Property Mercaderia() As String
        Get
            Return _Mercaderia
        End Get
    End Property


    Private _GuiaIngreso As Int64
    <Browsable(False)> _
    Public ReadOnly Property GuiaIngreso() As Int32
        Get
            Return _GuiaIngreso
        End Get
    End Property

    Private _Pedido As Int32
    Public ReadOnly Property Pedido() As Int32
        Get
            Return _Pedido
        End Get
    End Property

    Private _ModoGrid As eModoGrid
    <Browsable(True)> _
    Public Property ModoGrid() As eModoGrid
        Get
            If _ModoGrid = Nothing Then _ModoGrid = eModoGrid.Ninguno
            Return _ModoGrid
        End Get
        Set(ByVal value As eModoGrid)
            _ModoGrid = value
        End Set
    End Property

    Private _Lote As String = String.Empty
    Public Property Lote() As String
        Get
            Return _Lote
        End Get
        Set(ByVal value As String)
            _Lote = value
        End Set
    End Property


    Private _intIndex As Integer = 0

    Private Function ValidarCantidad() As Boolean
        Dim lista As List(Of beUbicacion)
        If ModoGrid = eModoGrid.Ingreso Then
            Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex)
            lista = colUbicaciones(key)
        Else
            Dim key As New KeyValuePair(Of Int64, Int32)(_OrdenServicio, _intIndex)
            lista = CType(colDespachos(key), List(Of beUbicacion))
        End If
     
        If lista Is Nothing Then Return True
        Dim sumaCantidad As Decimal = 0
        For Each l As beUbicacion In lista
            sumaCantidad += l.PNQTRMC1
        Next
        If sumaCantidad <= Cantidad Then
            IsError = True
            Return True
        Else
            IsError = False
            Return False
        End If
    End Function

    'Public Enum TipoProceso
    '    RECEPCION
    '    DESPACHO
    'End Enum
    'Public Function ValidarUbicacionDescarga(ByVal otipo As TipoProceso, ByVal Cantidad_Total As Decimal, ByVal Peso_Total As Decimal) As String
    '    Me.dgUbicaciones.EndEdit()
    '    Dim lista As List(Of beUbicacion)
    '    Dim msgTotal As String = ""
    '    Dim PendienteUbicarDescargar As Decimal = 0
    '    Dim QTotCantUbicacion As Decimal = 0
    '    For Each de As DictionaryEntry In ColGuardar
    '        lista = de.Value
    '        For Each ubi As beUbicacion In lista
    '            QTotCantUbicacion = QTotCantUbicacion + ubi.PNQTRMC1
    '        Next
    '    Next

    '    PendienteUbicarDescargar = Cantidad_Total - QTotCantUbicacion
    '    Select Case otipo
    '        Case TipoProceso.RECEPCION
    '            If PendienteUbicarDescargar > 0 Then
    '                msgTotal = PendienteUbicarDescargar & " productos pendientes de ubicar - nivel posiciones"
    '            End If
    '            If PendienteUbicarDescargar < 0 Then
    '                msgTotal = Math.Abs(PendienteUbicarDescargar) & " productos ubicados en exceso - nivel posiciones"
    '            End If
    '        Case TipoProceso.DESPACHO
    '            If PendienteUbicarDescargar > 0 Then
    '                msgTotal = PendienteUbicarDescargar & " productos pendientes de descarga - nivel posiciones"
    '            End If
    '            If PendienteUbicarDescargar < 0 Then
    '                msgTotal = Math.Abs(PendienteUbicarDescargar) & " productos excedidos en descarga  nivel posiciones."
    '            End If
    '    End Select

    '    Return msgTotal.Trim
    'End Function

    'Public Function ValidarUbicacionDescarga_X_Posicion(ByRef pExisteError As Boolean, FlagCtrlUbicacion As Boolean, otipo As TipoProceso, ByVal Cantidad_Total As Decimal, ByVal Peso_Total As Decimal, pSKU As String, pLote As Int64, pFilaRegistro As Int64) As String
    '    Me.dgUbicaciones.EndEdit()
    '    pExisteError = False
    '    Dim lista As List(Of beUbicacion)
    '    Dim key As New KeyValuePair(Of String, Int32)(pSKU & "-" & pLote & "-" & pFilaRegistro, _intIndex)
    '    lista = colUbicaciones(key)
    '    Dim msgTotal As String = ""
    '    Dim PendienteUbicarDescargar As Decimal = 0
    '    Dim QTotCantUbicacion As Decimal = 0
    '    If lista IsNot Nothing Then
    '        For Each ubi As beUbicacion In lista
    '            QTotCantUbicacion = QTotCantUbicacion + ubi.PNQTRMC1
    '        Next
    '    End If
    '    PendienteUbicarDescargar = Cantidad_Total - QTotCantUbicacion
    '    Select Case otipo
    '        Case TipoProceso.RECEPCION
    '            If PendienteUbicarDescargar > 0 Then
    '                msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Pendientes de Ubicación : " & PendienteUbicarDescargar
    '                If FlagCtrlUbicacion = True Then
    '                    pExisteError = True
    '                End If
    '            End If
    '            If PendienteUbicarDescargar < 0 Then
    '                msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Ubicados en exceso : " & Math.Abs(PendienteUbicarDescargar)
    '                pExisteError = True
    '            End If
    '        Case TipoProceso.DESPACHO
    '            If PendienteUbicarDescargar > 0 Then
    '                msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Pendientes de Descarga de ubicación : " & PendienteUbicarDescargar
    '                If FlagCtrlUbicacion = True Then
    '                    pExisteError = True
    '                End If
    '            End If
    '            If PendienteUbicarDescargar < 0 Then
    '                msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Descarga excedida de ubicación : " & Math.Abs(PendienteUbicarDescargar)
    '                pExisteError = True
    '            End If
    '    End Select

    '    Return msgTotal.Trim
    'End Function

    'Private Sub Validar_X_Posicion_Proceso(ByRef pExisteError As Boolean, ByRef pMsgValidacion As String, FlagCtrlUbicacion As Boolean, Cantidad_Total As Decimal, Peso_Total As Decimal, ClaveLista As String)

    'End Sub
    Public Function Validar_X_Posicion_Recepcion(ByRef pExisteError As Boolean, FlagCtrlUbicacion As Boolean, ByVal Cantidad_Total As Decimal, ByVal Peso_Total As Decimal, pSKU As String, pLote As String, pFilaRegistro As Int64) As String
        Me.dgUbicaciones.EndEdit()
        pExisteError = False

        Dim key As New KeyValuePair(Of String, Int32)(pSKU & "-" & pLote & "-" & pFilaRegistro, _intIndex)

        Dim lista As List(Of beUbicacion)
        lista = colUbicaciones(key)
        Dim msgTotal As String = ""
        Dim PendienteUbicarDescargar As Decimal = 0
        Dim QTotCantUbicacion As Decimal = 0
        If lista IsNot Nothing Then
            For Each ubi As beUbicacion In lista
                QTotCantUbicacion = QTotCantUbicacion + ubi.PNQTRMC1
            Next
        End If
        PendienteUbicarDescargar = Cantidad_Total - QTotCantUbicacion
        'Select Case otipo
        '    Case TipoProceso.RECEPCION
        If PendienteUbicarDescargar > 0 Then
            msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Pendientes de Ubicación : " & Val(PendienteUbicarDescargar)
            If FlagCtrlUbicacion = True Then
                pExisteError = True
            End If
        End If
        If PendienteUbicarDescargar < 0 Then
            msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Ubicados en exceso : " & Val(Math.Abs(PendienteUbicarDescargar))
            pExisteError = True
        End If
        'Case TipoProceso.DESPACHO
        '    If PendienteUbicarDescargar > 0 Then
        '        msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Pendientes de Descarga de ubicación : " & PendienteUbicarDescargar
        '        If FlagCtrlUbicacion = True Then
        '            pExisteError = True
        '        End If
        '    End If
        '    If PendienteUbicarDescargar < 0 Then
        '        msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Descarga excedida de ubicación : " & Math.Abs(PendienteUbicarDescargar)
        '        pExisteError = True
        '    End If
        'End Select

        Return msgTotal.Trim
    End Function

    Public Function Validar_X_Posicion_Despacho(ByRef pExisteError As Boolean, FlagCtrlUbicacion As Boolean, ByVal Cantidad_Total As Decimal, ByVal Peso_Total As Decimal, pSKU As String, Orden_Servicio As String, pLote As String, CodTipoAlmacen As String, CodAlmacen As String, CodZona As String, pFilaRegistro As Int64) As String
        Me.dgUbicaciones.EndEdit()
        pExisteError = False

        'Dim Clave As String = Orden_Servicio & "-" & pFilaRegistro & "-" & CodTipoAlmacen & "-" & CodAlmacen & "-" & CodZona
        'If pLote <> "" Then
        '    Clave = Orden_Servicio & "-" & pFilaRegistro & "-" & pLote & "-" & CodTipoAlmacen & "-" & CodAlmacen & "-" & CodZona
        'End If
        Dim Clave As String = ""
        Clave = Orden_Servicio & "-" & pFilaRegistro & "-" & pLote & "-" & CodTipoAlmacen & "-" & CodAlmacen & "-" & CodZona


        Dim key As New KeyValuePair(Of String, Int32)(Clave, pFilaRegistro)

        Dim lista As List(Of beUbicacion)
        lista = colDespachos(key)
        Dim msgTotal As String = ""
        Dim PendienteUbicarDescargar As Decimal = 0
        Dim QTotCantUbicacion As Decimal = 0
        If lista IsNot Nothing Then
            For Each ubi As beUbicacion In lista
                QTotCantUbicacion = QTotCantUbicacion + ubi.PNQTRMC1
            Next
        End If
        PendienteUbicarDescargar = Cantidad_Total - QTotCantUbicacion
        'Select Case otipo
        '    Case TipoProceso.RECEPCION
        '        If PendienteUbicarDescargar > 0 Then
        '            msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Pendientes de Ubicación : " & PendienteUbicarDescargar
        '            If FlagCtrlUbicacion = True Then
        '                pExisteError = True
        '            End If
        '        End If
        '        If PendienteUbicarDescargar < 0 Then
        '            msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Ubicados en exceso : " & Math.Abs(PendienteUbicarDescargar)
        '            pExisteError = True
        '        End If
        '    Case TipoProceso.DESPACHO
        If PendienteUbicarDescargar > 0 Then
            msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Pendientes de Descarga de ubicación : " & Val(PendienteUbicarDescargar)
            If FlagCtrlUbicacion = True Then
                pExisteError = True
            End If
        End If
        If PendienteUbicarDescargar < 0 Then
            msgTotal = "F" & pFilaRegistro + 1 & "[SKU-" & pSKU & "] -> Descarga excedida de ubicación : " & Val(Math.Abs(PendienteUbicarDescargar))
            pExisteError = True
        End If
        'End Select

        Return msgTotal.Trim
    End Function
   

    Private Function ValidarCantidadIngreso(ByVal obe As beUbicacion, ByVal pnCantidad As Decimal, ByVal pintIndice As Integer) As Boolean

        Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex) 'JM
        Dim lista As List(Of beUbicacion) = CType(colUbicaciones(key), List(Of beUbicacion))
        If lista Is Nothing Then Return True
        Dim sumaCantidad As Decimal = 0
        Dim int As Integer = 0
        For Each l As beUbicacion In lista

            If (l.PSCTPALM = obe.PSCTPALM And l.PSCALMC = obe.PSCALMC And l.PSCSECTR = obe.PSCSECTR And l.PSCPSCN = obe.PSCPSCN And l.PNNORDSR = obe.PNNORDSR) Then
                sumaCantidad += pnCantidad + IIf(_Regularizacion, l.PNQSLETQ, 0)
            Else
                sumaCantidad += l.PNQTRMC1 + IIf(_Regularizacion, l.PNQSLETQ, 0)
            End If



            int += 1
        Next
        If sumaCantidad <= Cantidad Then
            IsError = True
            Return True
        Else
            IsError = False
            Return False
        End If
    End Function

    Private Function ValidarCantidadDespacho(ByVal obe As beUbicacion, ByVal pnCantidad As Decimal, ByVal pintIndice As Integer) As Boolean
        'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", _OrdenServicio.ToString(), pintIndice.ToString(), _TipoAlmacen, _Almacen, _Zona)
        'If _Lote <> String.Empty Then
        '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", _OrdenServicio.ToString(), _intIndex.ToString(), _Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)
        'End If

        Dim Clave As String = ""
        Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", _OrdenServicio.ToString(), _intIndex.ToString(), _Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)



        Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)

        Dim lista As List(Of beUbicacion) = CType(colDespachos(key), List(Of beUbicacion))


        If lista Is Nothing And pnCantidad > 0 Then
            Return False
        ElseIf Cantidad = 0 And pnCantidad = 0 Then
            Return True
        End If

        Dim sumaCantidad As Decimal = 0
        Dim int As Integer = 0
        For Each l As beUbicacion In lista
            If pintIndice = int Then
                If l.PNQSLETQ < pnCantidad Then
                    Return False
                End If
                l.PNQTRMC1 = pnCantidad

            End If
            sumaCantidad += l.PNQTRMC1
            int += 1
        Next

        If sumaCantidad <= Cantidad Then
            IsError = True
            Return True
        Else
            IsError = False
            Return False
        End If
    End Function

    Private Function GetCantidades(ByVal lista As List(Of beUbicacion)) As List(Of beUbicacion)
        Dim miLista As List(Of beUbicacion)
        If ModoGrid = eModoGrid.Ingreso Then

            Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex)
            miLista = ColGuardar(key)
        ElseIf ModoGrid = eModoGrid.Despacho Then
            'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", OrdenServicio.ToString(), _intIndex.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'If Lote <> String.Empty Then
            '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'End If
            Dim Clave As String = ""
            Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)


            Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)



            miLista = ColGuardar(key)
        Else
            Return Nothing
        End If

        'Try
        If miLista IsNot Nothing Then
            For Each obj As beUbicacion In miLista
                For i As Int32 = 0 To lista.Count - 1
                    If lista(i).PNNORDSR = obj.PNNORDSR And lista(i).PSCPSCN = obj.PSCPSCN Then
                        lista(i) = obj
                        Exit For
                    End If
                Next
            Next
        End If
        'Catch ex As Exception

        'End Try
        Return lista
    End Function

    Public Function Guardar() As Boolean
        Return Guardar(Nothing)
    End Function

    Public Sub EliminarUbicaciones(ByVal nOrdenServicio As Int64, ByVal indice As Integer)
        _intIndex = indice
        If ModoGrid = eModoGrid.Despacho Then
            'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", OrdenServicio.ToString(), _intIndex.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'If Lote <> String.Empty Then
            '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'End If

            Dim Clave As String = ""
            Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)



            Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)

            If ColGuardar.ContainsKey(key) Then
                ColGuardar.Remove(key)
                colDespachos.Remove(key)
            End If
        End If

    End Sub

    Public Function Guardar(ByVal nGuiaIngreso As Int64) As Boolean
        'Try
        Me.dgUbicaciones.EndEdit()
        _GuiaIngreso = nGuiaIngreso
        If ValidarCantidad() Then
            Dim br As New brUbicacion()
            Dim lista As List(Of beUbicacion)
            For Each de As DictionaryEntry In ColGuardar
                lista = de.Value
                For Each ubi As beUbicacion In lista
                    If ubi.PNQTRMC1 > 0 Then
                        If ModoGrid = eModoGrid.Ingreso Then
                            ubi.PNCSRVC = 1
                        ElseIf ModoGrid = eModoGrid.Despacho Then
                            ubi.PNCSRVC = 2
                        End If
                        'ubi.PNFCHCRT = Format(Date.Now.Date, "yyyyMMdd")
                        'ubi.PNHRACRT = Format(Date.Now, "hhmmss")
                        'ubi.PSCUSCRT = Usuario
                        'ubi.PNHULTAC = Format(Date.Now, "hhmmss")
                        'ubi.PNFULTAC = Format(Date.Now.Date, "yyyyMMdd")
                        ubi.PSCULUSA = Usuario
                        'ubi.PSCUSCRT = Usuario
                        ubi.PNNGUIRN = GuiaIngreso
                        ubi.PSNTRMNL = ""
                        'ubi.PSSESTRG = "A"
                        'br.Update(ubi)
                        br.RegistrarInventario_X_Ubicacion(ubi)
                        'RegistrarInventario_X_Ubicacion
                    End If
                Next
            Next
            Return True
        End If
        'Catch ex As Exception
        '    Return False
        'End Try

    End Function

    Private Sub ListarUbicaciones()
        IsEstado = 0
        If Not ValidarCantidad() Then
            MessageBox.Show("La Cantidad ingresada supera la cantidad solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If ModoGrid = eModoGrid.Ingreso Then
                ResetearCantidadesRecepcion()
            End If
            Exit Sub
        End If
        Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex)
        dgUbicaciones.AutoGenerateColumns = False
        Dim lista As List(Of beUbicacion) = CType(colUbicaciones(key), List(Of beUbicacion))
        If lista Is Nothing Then
            Dim mobil As Decimal = IIf(Mobile = False, 0, 1)
            'csr-hundred
            lista = New brUbicacion().Listar(Cliente, Mercaderia, TipoAlmacen, Almacen, Zona, mobil, _OrdenServicio, nLote)
            lista = GetCantidades(lista)
            colUbicaciones.Add(key, lista)

        End If
        For Each l As beUbicacion In lista
            l.PNCSRVC = 1
            l.PNNGUIRN = GuiaIngreso
            l.PNNORDSR = OrdenServicio
        Next
        dgUbicaciones.DataSource = lista

    End Sub
    Public Sub LimpiarIngreso()
        colUbicaciones = New Hashtable
    End Sub

    Public Sub LimpiarDespacho()
        colDespachos = New Hashtable
    End Sub

    Public Sub ResetearDespachosLotes(ByVal nPedido As Int32, ByVal nOrdenServicio As Int32, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nCantidad As Decimal, ByVal sUsuario As String, ByVal nMobile As Boolean, ByVal intIndex As Integer, Optional ByVal sLote As String = "") 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
        Dim sOrdenServicio As String = nOrdenServicio.ToString()
        Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", sOrdenServicio, _intIndex.ToString(), _TipoAlmacen, _Almacen, _Zona)


        Dim okeys As New List(Of Object)
        For Each item As Object In colDespachos
            If item.Key.Key.ToString().Contains(Clave) Then
                okeys.Add(item.Key)
            End If
        Next

        Dim lista As List(Of beUbicacion)
        Dim i As Integer = 0
        Dim nLote As Integer = Convert.ToInt32(sLote)
        For Each itemKey As Object In okeys
            ColGuardar.Remove(itemKey)
            colDespachos.Remove(itemKey)
            For i = 0 To nLote
                Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", sOrdenServicio, _intIndex.ToString(), i, _TipoAlmacen, _Almacen, _Zona)
                If Clave = itemKey.Key.ToString() Then
                    'CSR-HUNDRED
                    lista = New brUbicacion().ListarDespachos(nOrdenServicio, sTipoAlmacen, sAlmacen, sZona, nPedido, nLote)
                    lista = GetCantidades(lista)
                    colDespachos.Add(itemKey, lista)
                    For Each item As beUbicacion In lista
                        item.PNQTRMC1 = 0
                    Next
                    dgUbicaciones.DataSource = lista
                End If

            Next
        Next

    End Sub

    Public Sub ResetearCantidades(ByVal nPedido As Int32, ByVal nOrdenServicio As Int32, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nCantidad As Decimal, ByVal sUsuario As String, ByVal nMobile As Boolean, ByVal intIndex As Integer, Optional ByVal sLote As String = "") 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
        Dim sOrdenServicio As String = nOrdenServicio.ToString()
        'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", sOrdenServicio, _intIndex.ToString(), _TipoAlmacen, _Almacen, _Zona)
        'If sLote <> String.Empty Then
        '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", sOrdenServicio, _intIndex.ToString(), sLote, _TipoAlmacen, _Almacen, _Zona)
        'End If

        Dim Clave As String = ""
        Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", sOrdenServicio, _intIndex.ToString(), sLote, _TipoAlmacen, _Almacen, _Zona)


        Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)
        Dim lista As List(Of beUbicacion) = CType(colDespachos(key), List(Of beUbicacion))

        Dim nLote As Integer
        If sLote <> String.Empty Then
            nLote = Convert.ToInt32(sLote)
        End If
        If Not lista Is Nothing Then
            If lista.Count > 0 Then
                ColGuardar.Remove(key)
                colDespachos.Remove(key)
            End If

            'CSR-HUNDRED
            lista = New brUbicacion().ListarDespachos(nOrdenServicio, sTipoAlmacen, sAlmacen, sZona, nPedido, nLote)
            lista = GetCantidades(lista)

            If lista.Count > 0 Then
                colDespachos.Add(key, lista)
            End If

            For Each item As beUbicacion In lista
                item.PNQTRMC1 = 0
            Next
            dgUbicaciones.DataSource = lista
        End If
    End Sub

    Public Sub ResetearCantidadesRecepcion()
        Dim lista As List(Of beUbicacion)
        Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex)
        lista = colUbicaciones(key)
        If Not lista Is Nothing Then
            For Each item As beUbicacion In lista
                item.PNQTRMC1 = 0
            Next
            dgUbicaciones.DataSource = lista
        End If
    End Sub



    Private Sub ListarDespachos(ByVal nPedido As Int32, ByVal sOrdenServicio As String, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nCantidad As Decimal, ByVal sLote As String) 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
        IsEstado = 0
        'Dim indice As Integer = _intIndex
        'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", sOrdenServicio, _intIndex.ToString(), sTipoAlmacen, sAlmacen, sZona)
        'If sLote <> String.Empty Then
        '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", sOrdenServicio, _intIndex.ToString(), sLote, sTipoAlmacen, sAlmacen, sZona)
        'End If

        Dim Clave As String = ""
        Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", sOrdenServicio, _intIndex.ToString(), sLote, sTipoAlmacen, sAlmacen, sZona)


        Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)
        If Not ValidarCantidad() Then
            colDespachos.Remove(key)
            ColGuardar.Remove(key)
            'MessageBox.Show("La Cantidad a despachar supera la cantidad solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Exit Sub
        End If
        dgUbicaciones.AutoGenerateColumns = False
        _Cantidad = nCantidad


        Dim lista As List(Of beUbicacion) = CType(colDespachos(key), List(Of beUbicacion))

        Dim nL As Integer = 0

        Dim nOrdenServicio As Int32 = Convert.ToInt32(sOrdenServicio)
        Dim nLote As Int32 = 0
        If sLote <> String.Empty Then
            nLote = Convert.ToInt32(sLote)
        End If


        'CSR-HUNDRED  
        If lista Is Nothing Then
            lista = New brUbicacion().ListarDespachos(nOrdenServicio, sTipoAlmacen, sAlmacen, sZona, nPedido, nLote)
            lista = GetCantidades(lista)


            colDespachos.Add(key, lista)



        End If

        Dim totalCantidad As Integer = 0
        For Each l As beUbicacion In lista
            totalCantidad = totalCantidad + l.PNQTRMC1
        Next

        For Each l As beUbicacion In lista
            l.PNCSRVC = 2
            If nCantidad < totalCantidad Then
                l.PNQTRMC1 = 0
            End If
        Next

        dgUbicaciones.DataSource = lista
        dgUbicaciones.Refresh()
    End Sub



    Private Sub Refrescar()
        Dim lista As List(Of beUbicacion)
        Dim lista2 As List(Of beUbicacion)
        dgUbicaciones.AutoGenerateColumns = False
        If ModoGrid = eModoGrid.Ingreso Then
            Dim key As New KeyValuePair(Of String, Int32)(Mercaderia, _intIndex)
            lista = CType(colUbicaciones(key), List(Of beUbicacion))
            lista2 = New brUbicacion().Listar(OrdenServicio, TipoAlmacen, Almacen)
            lista2 = GetCantidades(lista2)
            If lista Is Nothing Then
                colUbicaciones.Add(key, lista2)
            Else
                colUbicaciones(key) = lista2
            End If
            If lista IsNot Nothing Then
                For Each l As beUbicacion In lista
                    l.PNCSRVC = 1
                    l.PNNGUIRN = GuiaIngreso
                Next
            End If
        Else
            Dim key As New KeyValuePair(Of Int64, Int32)(OrdenServicio, _intIndex)
            lista = CType(colDespachos(key), List(Of beUbicacion))

            lista2 = New brUbicacion().Listar(OrdenServicio, TipoAlmacen, Almacen)
            lista2 = GetCantidades(lista2)

            If lista Is Nothing Then
                colUbicaciones.Add(key, lista2)
            Else
                colUbicaciones(key) = lista2
            End If
            For Each l As beUbicacion In lista
                l.PNCSRVC = 2
            Next
        End If
        dgUbicaciones.DataSource = Nothing
        dgUbicaciones.DataSource = lista2
    End Sub

   

    Public Sub ConsultarDespachos(ByVal nPedido As Int32, ByVal nOrdenServicio As Int32, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nCantidad As Decimal, ByVal sUsuario As String, ByVal nMobile As Boolean, ByVal intIndex As Integer, Optional ByVal sLote As String = "") 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
        Me.txtPosicion.Text = ""
        _OrdenServicio = nOrdenServicio
        _Cantidad = nCantidad
        _Mobile = nMobile
        _TipoAlmacen = sTipoAlmacen
        _Almacen = sAlmacen
        _Zona = sZona 'CSR-HUNDRED
        _Pedido = nPedido
        _intIndex = intIndex
        _Usuario = sUsuario
        _Lote = Val(sLote)
        'LimpiarDespacho()
        Consultar()
    End Sub

    Public Sub fListaDesp(ByVal nPedido As Int32, ByVal nOrdenServicio As Int32, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nCantidad As Decimal, ByVal sUsuario As String, ByVal nMobile As Boolean, ByVal intIndex As Integer)
        Me.txtPosicion.Text = ""
        _OrdenServicio = nOrdenServicio
        _Cantidad = nCantidad
        _Mobile = nMobile
        _TipoAlmacen = sTipoAlmacen
        _Almacen = sAlmacen
        _Zona = sZona 'CSR-HUNDRED
        _Pedido = nPedido
        _intIndex = intIndex
        _Usuario = sUsuario
        LimpiarDespacho()
        Consultar()
    End Sub

    Public Sub ConsultarIngresos(ByVal nOrdenServicio As Int32, ByVal nCliente As Int32, ByVal sMercaderia As String, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal nCantidad As Decimal, ByVal sUsuario As String, ByVal nMobile As Boolean, ByVal nLote As Integer, ByVal IndexMercaderia As Integer, ByVal sZona As String) 'CSR-HUNDRED-080916-SOPORTE-ALMACENES
        _Cantidad = nCantidad
        _Mercaderia = sMercaderia
        _Cliente = nCliente
        _Mobile = nMobile
        _TipoAlmacen = sTipoAlmacen
        _Almacen = sAlmacen
        _OrdenServicio = nOrdenServicio
        _Usuario = sUsuario
        _nLote = nLote
        _IndexMercaderia = IndexMercaderia
        'EGL - HUNDRED 
        _Zona = sZona
        Consultar()
    End Sub

    Public Sub fListaIng(ByVal nOrdenServicio As Int32, ByVal nCliente As Int32, ByVal sMercaderia As String, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nCantidad As Decimal, ByVal sUsuario As String, ByVal nMobile As Boolean)
        _Cantidad = nCantidad
        _Mercaderia = sMercaderia
        _Cliente = nCliente
        _Mobile = nMobile
        _TipoAlmacen = sTipoAlmacen
        _Almacen = sAlmacen
        _Zona = sZona 'CSR-HUNDRED
        _OrdenServicio = nOrdenServicio
        _Usuario = sUsuario
        LimpiarIngreso()
        Consultar()
    End Sub

    Private Sub Consultar()
        If ModoGrid = eModoGrid.Ingreso Then
            ListarUbicaciones()
        ElseIf ModoGrid = eModoGrid.Despacho Then
            'CSR-HUNDRED
            ListarDespachos(Pedido, OrdenServicio, TipoAlmacen, Almacen, Zona, Cantidad, Lote)
        End If
        KryptonHeader1.Text = "N° Orden: " & OrdenServicio.ToString()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Refrescar()
    End Sub

    Private Sub FiltrarPosicion(ByVal sPosicion As String)
        Dim lista As List(Of beUbicacion) = dgUbicaciones.DataSource
        Dim lis As List(Of beUbicacion) = lista.FindAll(AddressOf Search)
    End Sub

    Function Search(ByVal item As beUbicacion) As Boolean

    End Function

#Region "Controles Almacen"
    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén
        txtAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub dgUbicaciones_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUbicaciones.CellEndEdit
        Try
            If e.RowIndex < 0 Then Exit Sub

            If dgUbicaciones.Columns(e.ColumnIndex).Name = "QTRMC1" Then
                Dim obj As beUbicacion = dgUbicaciones.Rows(e.RowIndex).DataBoundItem

                Dim lista As List(Of beUbicacion) = GetListaUbicaciones()
                If lista IsNot Nothing Then
                    For Each o As beUbicacion In lista
                        If o.PNNORDSR = obj.PNNORDSR And o.PSCPSCN = obj.PSCPSCN Then
                            If obj.PNQTRMC1 > 0 Then
                                o = obj
                                Return
                            Else
                                lista.Remove(o)
                                Return
                            End If
                        End If
                    Next

                    If obj.PNQTRMC1 > 0 Then
                        If ModoGrid = eModoGrid.Ingreso Then
                            obj.PNNCRRIN = nLote
                        Else
                            obj.PNNCRRIN = Val(Lote)
                        End If

                        lista.Add(obj)
                    End If
                    Return
                Else
                    If ModoGrid = eModoGrid.Despacho Then
                        obj.PNNCRRIN = Val(Lote)
                    End If
                    AddUbicacion(obj)
                    Me.dgUbicaciones.EndEdit(DataGridViewDataErrorContexts.Commit)
                    Return
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


      
    End Sub

    Private Sub dgUbicaciones_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgUbicaciones.CellValidating

        Try
            If e.ColumnIndex = 7 Then
                Dim obeUbi As beUbicacion = dgUbicaciones.Rows(e.RowIndex).DataBoundItem

                If String.IsNullOrEmpty(e.FormattedValue.ToString.Trim) Then
                    e.Cancel = True
                    '   obeUbi.PNQSLETQ = 0
                    Return
                End If
                If IsEstado = 0 Then Exit Sub
                Select Case ModoGrid
                    Case eModoGrid.Ingreso
                        If ValidarCantidadIngreso(obeUbi, e.FormattedValue, e.RowIndex) = False Then 'JM
                            MessageBox.Show("la cantidad ingresada es mayor que  el stock en el  almacén.")
                            e.Cancel = True
                            Me.dgUbicaciones.CurrentCell.ErrorText = "la cantidad ingresada es mayor que  el stock en el  almacén."
                        Else
                            Me.dgUbicaciones.CurrentCell.ErrorText = ""
                        End If
                    Case eModoGrid.Despacho

                        If Not _Regularizacion Then
                            If ValidarCantidadDespacho(obeUbi, e.FormattedValue, e.RowIndex) = False Then
                                MessageBox.Show("la cantidad ingresada es mayor.")
                                e.Cancel = True
                                Me.dgUbicaciones.CurrentCell.ErrorText = "la cantidad ingresada es mayor."
                            Else
                                Me.dgUbicaciones.CurrentCell.ErrorText = ""
                            End If
                        Else
                            If e.FormattedValue > obeUbi.PNQSLETQ Then
                                MessageBox.Show("la cantidad ingresada es mayor al stock de la posición.")
                                e.Cancel = True
                            End If
                        End If


                End Select

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


    Private Function GetListaUbicaciones() As List(Of beUbicacion)
        Dim lista As List(Of beUbicacion) = Nothing
        If ModoGrid = eModoGrid.Ingreso Then
            'Dim key As New KeyValuePair(Of String, Int32)(Mercaderia, _intIndex)
            Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex)
            lista = ColGuardar(key)
        ElseIf ModoGrid = eModoGrid.Despacho Then
            'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", OrdenServicio.ToString(), _intIndex.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'If Lote <> String.Empty Then
            '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'End If

            Dim Clave As String = ""
            Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)


            Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)
            lista = ColGuardar(key)
        End If
        Return lista
    End Function

    Private Sub AddUbicacion(ByVal objUbi As beUbicacion)
        Dim lis As New List(Of beUbicacion)
        lis.Add(objUbi)
        If ModoGrid = eModoGrid.Ingreso Then
            'Dim key As New KeyValuePair(Of String, Int32)(Mercaderia, _intIndex)
            Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex)
            objUbi.PNNCRRIN = nLote
            ColGuardar.Add(key, lis)
        ElseIf ModoGrid = eModoGrid.Despacho Then
            'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", OrdenServicio.ToString(), _intIndex.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'If Lote <> String.Empty Then
            '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)
            'End If

            Dim Clave As String = ""
            Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)


            Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)
            ColGuardar.Add(key, lis)
        End If
    End Sub

    Private BuscarPosiciones As New Predicate(Of beUbicacion)(AddressOf Buscar)

    Public Function Buscar(ByVal ObeUbicacion As beUbicacion) As Boolean
        If (ObeUbicacion.PSCPSCN.Trim.IndexOf(Me.txtPosicion.Text.ToUpper.Trim) <> -1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtPosicion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPosicion.TextChanged
        Try
            Dim lista As New List(Of beUbicacion)


            If ModoGrid = eModoGrid.Ingreso Then
                Dim key As New KeyValuePair(Of String, Int32)(Mercaderia & "-" & nLote & "-" & IndexMercaderia, _intIndex)
                lista = CType(colUbicaciones(key), List(Of beUbicacion))

            Else
                'Dim Clave As String = String.Format("{0}-{1}-{2}-{3}-{4}", OrdenServicio.ToString(), _intIndex.ToString(), _TipoAlmacen, _Almacen, _Zona)
                'If Lote <> String.Empty And Lote <> "0" Then
                '    Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)
                'End If

                Dim Clave As String = ""
                Clave = String.Format("{0}-{1}-{2}-{3}-{4}-{5}", OrdenServicio.ToString(), _intIndex.ToString(), Lote.ToString(), _TipoAlmacen, _Almacen, _Zona)


                Dim key As New KeyValuePair(Of String, Int32)(Clave, _intIndex)
                lista = CType(colDespachos(key), List(Of beUbicacion))
            End If


            Me.dgUbicaciones.DataSource = lista.FindAll(BuscarPosiciones)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub dgUbicaciones_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUbicaciones.CellValueChanged
        Try
            If e.RowIndex >= 0 And e.ColumnIndex = 0 Then
                Dim miRow As DataGridViewRow = dgUbicaciones.Rows(e.RowIndex)
                If miRow.Cells("QTRMC1").FormattedValue > 0 Then
                    miRow.DefaultCellStyle.BackColor = Drawing.Color.Orange
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
    End Sub

    Private Sub dgUbicaciones_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgUbicaciones.EditingControlShowing

        Try
            Dim columna As Integer = dgUbicaciones.CurrentCell.ColumnIndex
            Dim colName As String = dgUbicaciones.Columns(columna).Name

            'If dgUbicaciones.CurrentCell.ColumnIndex = 7 Then
            If colName = "QTRMC1" Then
                Dim validar As TextBox = CType(e.Control, TextBox)
                If validar IsNot Nothing Then
                    ' agregar el controlador de eventos para el KeyPress   
                    AddHandler validar.KeyPress, AddressOf validar_Keypress
                Else
                    RemoveHandler validar.KeyPress, AddressOf validar_Keypress
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna   
        Dim columna As Integer = dgUbicaciones.CurrentCell.ColumnIndex
        Dim colName As String = dgUbicaciones.Columns(columna).Name
        ' comprobar si la celda en edición corresponde a la columna 1 o 3   




        'If columna = 7 Then
        If colName = "QTRMC1" Then
            IsEstado = 1
            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' comprobar si el caracter es un número o el retroceso   
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False And caracter <> "." And caracter <> "," Then
                'Me.Text = e.KeyChar   
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

End Class

Public Enum eModoGrid
    Ninguno = -1
    Ingreso = 1
    Despacho = 2
End Enum

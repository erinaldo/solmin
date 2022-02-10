Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones

Public Class ctrlReFactura_ST
    Private dblNumFact As Double
    Private oDt As DataTable
    Private strTipoMoneda As String
    Private strIGV As String
    Private intTipoFactura As Int16
    Private intTipoDocumento As Int32
    Dim dblIGV As Double
    Dim ImporteActuales As New Hashtable
    Dim TotalImporteActual As Double
    Dim TotalIgvActual As Double
    Dim SubTotalActual As Double
    Private intTipoOperacion As Int32

    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal poDt As DataTable, ByVal pdblNumFact As Double, ByVal pstrTipoMoneda As String, ByVal pstrIGV As String, ByVal pTipoFactura As Int16, ByVal pTipoDocumento As Int32)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        intTipoFactura = pTipoFactura
        Crear_Grilla()
        Me.dtgDetalle.DataSource = Nothing
        intTipoDocumento = pTipoDocumento
        dblNumFact = pdblNumFact
        strTipoMoneda = pstrTipoMoneda
        strIGV = pstrIGV
        dblIGV = 1 + CType(strIGV, Double) / 100
        oDt = poDt.Copy
        Llenar_Detalles()
    End Sub

#Region "Propiedades"

    Property Referencia1()
        Get
            Return Me.txtReferencia1.Text
        End Get
        Set(ByVal value)
            Me.txtReferencia1.Text = value
        End Set
    End Property

    Property Referencia2()
        Get
            Return Me.txtReferencia2.Text
        End Get
        Set(ByVal value)
            Me.txtReferencia2.Text = value
        End Set
    End Property

    Property NumFactura()
        Get
            Return Me.lblNumFactura.Text
        End Get
        Set(ByVal value)
            Me.lblNumFactura.Text = value
        End Set
    End Property
    WriteOnly Property GridSoloLectura()
        Set(ByVal value)
            Me.dtgDetalle.Columns("TARIFA").ReadOnly = value
            Me.dtgDetalle.Columns("CANTIDAD").ReadOnly = value
        End Set
    End Property
    WriteOnly Property TipoOperacion()
        Set(ByVal value)
            intTipoOperacion = value
        End Set
    End Property


#End Region

#Region "Crear_Grilla"

    Private Sub Crear_Grilla()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SERVICIO"
        oDcTx.HeaderText = "S E R V I C I O"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.Width = 200
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "DETALLE"
        oDcTx.HeaderText = "D E T A L L E"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.Width = 300
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CANTIDAD"
        oDcTx.HeaderText = "C A N T I D A D"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Width = 150
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "UNIDAD"
        oDcTx.HeaderText = ""
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.Width = 80
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TARIFA"
        oDcTx.HeaderText = "T A R I F A"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Width = 150
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONEDA"
        oDcTx.HeaderText = ""
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.Width = 50
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "IMPORTE"
        oDcTx.HeaderText = "I M P O R T E"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Width = 150
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)
    End Sub

#End Region

    Private Sub Llenar_Detalles()
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        Dim strDato As String
        Dim dblSubTotal As Double = 0
        Dim dblTotal As Double = 0
        Dim bolSoles As Boolean = False
        Dim bolIGV As Boolean = False
        Dim oDtNew As DataTable
        Dim oFacturaNeg As New Factura_Transporte_BLL
        Dim oFiltro As Hashtable
        Select Case intTipoFactura
            Case 0
                For intCont = 0 To oDt.Rows.Count - 1
                    If oDt.Rows(intCont).Item("NDCCTC").ToString.Trim = dblNumFact Then
                        If oDt.Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oFiltro = New Hashtable
                            oFiltro.Add("PSCCMPN", oDt.Rows(intCont).Item("CCMPN").ToString.Trim)
                            oFiltro.Add("PSCDVSN", oDt.Rows(intCont).Item("CDVSN").ToString.Trim)
                            oFiltro.Add("PNCSRVNV", oDt.Rows(intCont).Item("CRBCTC").ToString.Trim)
                            oDtNew = oFacturaNeg.Lista_Datos_Servicio(oFiltro)
                            strDato = oDt.Rows(intCont).Item("NCRDCC").ToString.Trim & ". "
                            strDato = strDato & "   " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                            strDato = strDato & "   " & oDtNew.Rows(0).Item("TCMTRF").ToString.Trim
                            oDrVw.Cells(0).Value = strDato
                            strDato = Format(CType(oDt.Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00")
                            oDrVw.Cells(2).Value = strDato
                            strDato = oDt.Rows(intCont).Item("CUNCNA").ToString.Trim
                            oDrVw.Cells(3).Value = strDato
                            strDato = oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                            oDrVw.Cells(5).Value = strDato
                            strDato = Format(CType(oDt.Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000")
                            oDrVw.Cells(4).Value = strDato

                            'If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                            If strTipoMoneda = "DOL" Then
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCD")
                                bolSoles = False
                            Else
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                                bolSoles = True
                            End If
                            oDrVw.Cells(6).Value = strDato
                            Me.dtgDetalle.Rows.Add(oDrVw)
                            ImporteActuales.Add(intCont, oDrVw.Cells(4).Value)
                        Else
                            bolIGV = True
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oDrVw.Cells(4).Value = "SUB-TOTAL"
                            oDrVw.Cells(6).Value = Format(dblSubTotal, "###,###,###,###.00")
                            Me.dtgDetalle.Rows.Add(oDrVw)

                            If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                strDato = "I.G.V.  " & strIGV & " %"
                                oDrVw.Cells(4).Value = strDato
                            End If

                            If bolSoles Then
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    oDrVw.Cells(6).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                    Me.dtgDetalle.Rows.Add(oDrVw)
                                End If
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCS")
                                Else
                                    dblTotal = dblSubTotal
                                End If
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw.Cells(4).Value = "T O T A L         S/."
                                oDrVw.Cells(6).Value = Format(dblTotal, "###,###,###,###.00")
                            Else
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    oDrVw.Cells(6).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                    Me.dtgDetalle.Rows.Add(oDrVw)
                                End If
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCD")
                                Else
                                    dblTotal = dblSubTotal
                                End If

                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw.Cells(4).Value = "T O T A L         US$"
                                oDrVw.Cells(6).Value = Format(dblTotal, "###,###,###,###.00")

                            End If
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If
                    End If
                Next intCont
                If Not bolIGV Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    oDrVw.Cells(4).Value = "SUB-TOTAL"
                    oDrVw.Cells(6).Value = Format(dblSubTotal, "###,###,###,###.00")
                    Me.dtgDetalle.Rows.Add(oDrVw)
                    If bolSoles Then
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(4).Value = "T O T A L         S/."
                        oDrVw.Cells(6).Value = Format(dblTotal, "###,###,###,###.00")
                    Else
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(4).Value = "T O T A L         US$"
                        oDrVw.Cells(6).Value = Format(dblTotal, "###,###,###,###.00")
                    End If
                    Me.dtgDetalle.Rows.Add(oDrVw)
                End If
            Case 1
                For intCont = 0 To oDt.Rows.Count - 1
                    If oDt.Rows(intCont).Item("NDCCTC").ToString.Trim = dblNumFact Then
                        If oDt.Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oFiltro = New Hashtable
                            'oFiltro.Add("PSCCMPN", oDt.Rows(intCont).Item("CCMPN").ToString.Trim)
                            'oFiltro.Add("PSCDVSN", oDt.Rows(intCont).Item("CDVSN").ToString.Trim)
                            'oFiltro.Add("PNCSRVNV", oDt.Rows(intCont).Item("CRBCTC").ToString.Trim)
                            'oDtNew = oFacturaNeg.Lista_Datos_Servicio(oFiltro)
                            strDato = oDt.Rows(intCont).Item("NCRDCC").ToString.Trim & ". "
                            'strDato = strDato & "   " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                            strDato = strDato & "   " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                            oDrVw.Cells(0).Value = strDato
                            oDrVw.Cells(1).Value = oDt.Rows(intCont).Item("STCCTC").ToString.Trim
                            strDato = Format(CType(oDt.Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00")
                            oDrVw.Cells(2).Value = strDato
                            strDato = oDt.Rows(intCont).Item("CUNCNA").ToString.Trim
                            oDrVw.Cells(3).Value = strDato
                            'If oDt.Rows(intCont).Item("CUNCNA").ToString.Trim = "" Then
                            '  strDato = strDato & "            "
                            'Else
                            '  strDato = strDato & "     " & oDt.Rows(intCont).Item("CUNCNA").ToString.Trim
                            'End If
                            strDato = Format(CType(oDt.Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000")
                            oDrVw.Cells(4).Value = strDato
                            'strDato = strDato & "     " & oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                            strDato = oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                            oDrVw.Cells(5).Value = strDato

                            'If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                            If strTipoMoneda = "DOL" Then
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCD")
                                bolSoles = False
                            Else
                                If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                                bolSoles = True
                            End If
                            oDrVw.Cells(6).Value = strDato
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If
                    End If
                Next intCont
                If strIGV <> "" Then 'Not bolIGV Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    oDrVw.Cells(4).Value = "SUB-TOTAL"
                    oDrVw.Cells(6).Value = Format(dblSubTotal, "###,###,###,###.00")
                    Me.dtgDetalle.Rows.Add(oDrVw)

                    If bolSoles Then
                        If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            'strDato = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(4).Value = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(6).Value = Format((dblSubTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If
                        If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                            dblTotal = dblSubTotal * dblIGV
                        Else
                            dblTotal = dblSubTotal
                        End If

                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(4).Value = "T O T A L"
                        oDrVw.Cells(6).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                        Me.dtgDetalle.Rows.Add(oDrVw)
                    Else
                        If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            'strDato = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(4).Value = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(6).Value = Format((dblSubTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If

                        If intTipoDocumento = 2 OrElse intTipoDocumento = 3 Then
                            dblTotal = dblSubTotal * dblIGV
                        Else
                            dblTotal = dblSubTotal
                        End If

                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(4).Value = "T O T A L"
                        oDrVw.Cells(6).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                        Me.dtgDetalle.Rows.Add(oDrVw)
                    End If
                Else
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    oDrVw.Cells(4).Value = "SUB-TOTAL"
                    oDrVw.Cells(6).Value = Format(dblSubTotal, "###,###,###,###.00")
                    Me.dtgDetalle.Rows.Add(oDrVw)
                    If bolSoles Then
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(4).Value = "T O T A L"
                        oDrVw.Cells(6).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                    Else
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(4).Value = "T O T A L"
                        oDrVw.Cells(6).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                    End If
                    Me.dtgDetalle.Rows.Add(oDrVw)
                End If
        End Select

    End Sub

    Private Sub dtgDetalle_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetalle.CellValueChanged
        Dim subTotal As Double = 0
        Dim fila As Integer
        Dim indice As Integer = Me.dtgDetalle.CurrentCellAddress.Y
        Dim ImporteNuevo As Double = Me.dtgDetalle.Item("TARIFA", indice).Value
        'If ImporteNuevo = ImporteActuales(indice) Then Exit Sub
        If Me.intTipoOperacion = 2 Then
            If ImporteNuevo <= 0 Then
                MsgBox("La Nueva Tarifa, Debe ser Mayor a 0", MsgBoxStyle.Exclamation)
                Me.dtgDetalle.Item("TARI                                                                             ,,,,,,,,,,,,FA", indice).Value = Format(CType(ImporteActuales(indice), Double), "###,###,###,###.00")
                Exit Sub
            Else
                For fila = 0 To Me.dtgDetalle.RowCount - 4
                    subTotal = subTotal + (CType(Me.dtgDetalle.Item("CANTIDAD", fila).Value, Double) * CType(Me.dtgDetalle.Item("TARIFA", fila).Value, Double))
                    Me.dtgDetalle.Item("IMPORTE", fila).Value = Format(subTotal, "###,###,###,###.00")
                Next
                Me.dtgDetalle.Item("IMPORTE", fila).Value = Format(subTotal, "###,###,###,###.00")
                Me.dtgDetalle.Item("IMPORTE", fila + 1).Value = Format((subTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                Me.dtgDetalle.Item("IMPORTE", fila + 2).Value = Format(CType(Me.dtgDetalle.Item("IMPORTE", fila).Value, Double) + CType(Me.dtgDetalle.Item("IMPORTE", fila + 1).Value, Double), "###,###,###,###.00")
            End If
        Else
            If ImporteNuevo <= 0 OrElse ImporteNuevo > CType(ImporteActuales(indice), Double) Then
                MsgBox("La Nueva Tarifa, Debe ser Mayor a 0 y Menor a la Tarifa Actual", MsgBoxStyle.Exclamation)
                Me.dtgDetalle.Item("TARIFA", indice).Value = Format(CType(ImporteActuales(indice), Double), "###,###,###,###.00")

                Exit Sub
            Else
                'Dim numFilas As Integer = Me.dtgDetalle.RowCount
                'Dim moneda As String = Me.dtgDetalle.Item("MONEDA", 0).Value
                '
                For fila = 0 To Me.dtgDetalle.RowCount - 4
                    subTotal = subTotal + (CType(Me.dtgDetalle.Item("CANTIDAD", fila).Value, Double) * CType(Me.dtgDetalle.Item("TARIFA", fila).Value, Double))
                    Me.dtgDetalle.Item("IMPORTE", fila).Value = Format(subTotal, "###,###,###,###.00")
                Next
                Me.dtgDetalle.Item("IMPORTE", fila).Value = Format(subTotal, "###,###,###,###.00")
                Me.dtgDetalle.Item("IMPORTE", fila + 1).Value = Format((subTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                Me.dtgDetalle.Item("IMPORTE", fila + 2).Value = Format(CType(Me.dtgDetalle.Item("IMPORTE", fila).Value, Double) + CType(Me.dtgDetalle.Item("IMPORTE", fila + 1).Value, Double), "###,###,###,###.00")
            End If

        End If
    End Sub

    Private Sub dtgDetalle_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtgDetalle.CellBeginEdit

    End Sub

    Private Sub dtgDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgDetalle.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = dtgDetalle.Columns(dtgDetalle.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName

                Case "TARIFA"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass_ST.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
End Class


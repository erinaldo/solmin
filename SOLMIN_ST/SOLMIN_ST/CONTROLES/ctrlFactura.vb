Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class ctrlFactura
  Private dblNumFact As Double
  Private oDt As DataTable
  Private strTipoMoneda As String
  Private strIGV As String
  Private intTipoFactura As Int16
  Private intTipoDocumento As Int32
    Dim dblIGV As Double

    Enum FormatoVista
        Neutral
        Electronico
        ParteTransferencia
    End Enum


    Sub New(ByVal poDt As DataTable, ByVal pdblNumFact As Double, ByVal pstrTipoMoneda As String, ByVal pstrIGV As String, ByVal pTipoFactura As Int16, ByVal pTipoDocumento As Int32, Optional ByVal _FormatoVista As FormatoVista = FormatoVista.Neutral, Optional ByVal ValorReferencia As Decimal = 0, Optional ByVal SPOT As Decimal = 0, Optional ByVal OrdenCompraCliente As String = "")

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

        If _FormatoVista = FormatoVista.Electronico Or _FormatoVista = FormatoVista.ParteTransferencia Then
            ' se modifico el origen de obtener los servicios y creacion celda con nombres nada mas


            pnlDetraccion.Visible = True

            Select Case intTipoDocumento
                Case 1, 51, 7, 57, 6
                    lblValorReferencia.Text = ValorReferencia.ToString
                Case Else
                    lblValorReferencia.Text = String.Empty
            End Select
            Select Case intTipoDocumento
                Case 1, 51
                    lblPorcentajeDetraccion.Text = SPOT.ToString

                Case Else
                    lblPorcentajeDetraccion.Text = String.Empty
            End Select
            Llenar_Detalles_General()

            If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                txtOCompra.Enabled = True
                txtOCompra.Text = OrdenCompraCliente
            Else
                txtOCompra.Enabled = False
            End If

        Else
            pnlDetraccion.Visible = False
            Llenar_Detalles()
        End If


        '

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


    'OMVB REQ11072019 ORDEN DE COMPRA
    Property OCompra()
        Get
            Return Me.txtOCompra.Text
        End Get
        Set(ByVal value)
            Me.txtOCompra.Text = value
        End Set
    End Property
    'OMVB REQ11072019 ORDEN DE COMPRA


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
        oDcTx.Name = "TARIFA"
        oDcTx.HeaderText = "T A R I F A"
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Width = 150
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
                            If oDt.Rows(intCont).Item("CUNCNA").ToString.Trim = "" Then
                                strDato = strDato & "            "
                            Else
                                strDato = strDato & "     " & oDt.Rows(intCont).Item("CUNCNA").ToString.Trim
                            End If
                            oDrVw.Cells(2).Value = strDato
                            strDato = Format(CType(oDt.Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000")
                            strDato = strDato & "     " & oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                            oDrVw.Cells(3).Value = strDato

                            'If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                            If strTipoMoneda = "DOL" Then
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCD")
                                bolSoles = False
                            Else
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                                bolSoles = True
                            End If
                            oDrVw.Cells(4).Value = strDato
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        Else
                            bolIGV = True
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oDrVw.Cells(3).Value = "SUB-TOTAL"
                            oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                            Me.dtgDetalle.Rows.Add(oDrVw)

                            If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                strDato = "I.G.V.  " & strIGV & " %"
                                oDrVw.Cells(3).Value = strDato
                            End If

                            If bolSoles Then
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                    Me.dtgDetalle.Rows.Add(oDrVw)
                                End If
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCS")
                                Else
                                    dblTotal = dblSubTotal
                                End If
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw.Cells(3).Value = "T O T A L"
                                oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                            Else
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                    Me.dtgDetalle.Rows.Add(oDrVw)
                                End If
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCD")
                                Else
                                    dblTotal = dblSubTotal
                                End If

                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw.Cells(3).Value = "T O T A L"
                                oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                            End If
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If
                    End If
                Next intCont
                If Not bolIGV Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    oDrVw.Cells(3).Value = "SUB-TOTAL"
                    oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                    Me.dtgDetalle.Rows.Add(oDrVw)
                    If bolSoles Then
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                    Else
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
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
                            If oDt.Rows(intCont).Item("CUNCNA").ToString.Trim = "" Then
                                strDato = strDato & "            "
                            Else
                                strDato = strDato & "     " & oDt.Rows(intCont).Item("CUNCNA").ToString.Trim
                            End If
                            oDrVw.Cells(2).Value = strDato
                            strDato = Format(CType(oDt.Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000")
                            strDato = strDato & "     " & oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                            oDrVw.Cells(3).Value = strDato

                            'If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                            If strTipoMoneda = "DOL" Then
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCD")
                                bolSoles = False
                            Else
                                If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                Else
                                    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                End If
                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                                bolSoles = True
                            End If
                            oDrVw.Cells(4).Value = strDato
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If
                    End If
                Next intCont
                If strIGV <> "" Then 'Not bolIGV Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    oDrVw.Cells(3).Value = "SUB-TOTAL"
                    oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                    Me.dtgDetalle.Rows.Add(oDrVw)

                    If bolSoles Then
                        If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            'strDato = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(3).Value = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(4).Value = Format((dblSubTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If
                        If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                            dblTotal = dblSubTotal * dblIGV
                        Else
                            dblTotal = dblSubTotal
                        End If

                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                        Me.dtgDetalle.Rows.Add(oDrVw)
                    Else
                        If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            'strDato = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(3).Value = "I.G.V.  " & strIGV & " %"
                            oDrVw.Cells(4).Value = Format((dblSubTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If

                        If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                            dblTotal = dblSubTotal * dblIGV
                        Else
                            dblTotal = dblSubTotal
                        End If

                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                        Me.dtgDetalle.Rows.Add(oDrVw)
                    End If
                Else
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    oDrVw.Cells(3).Value = "SUB-TOTAL"
                    oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                    Me.dtgDetalle.Rows.Add(oDrVw)
                    If bolSoles Then
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                    Else
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                    End If
                    Me.dtgDetalle.Rows.Add(oDrVw)
                End If

        End Select

    End Sub

    Private Sub Llenar_Detalles_General()
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        Dim strDato As String
        Dim dblSubTotal As Double = 0
        Dim dblTotal As Double = 0
        Dim bolSoles As Boolean = False
        Dim bolIGV As Boolean = False
        'Dim oDtNew As DataTable
        'Dim oFacturaNeg As New Factura_Transporte_BLL
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
                            'oDtNew = oFacturaNeg.Lista_Datos_Servicio(oFiltro)
                            strDato = oDt.Rows(intCont).Item("NCRDCC").ToString.Trim & ". "
                            strDato = strDato & "   " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                            'strDato = strDato & "   " & oDtNew.Rows(0).Item("TCMTRF").ToString.Trim
                            strDato = strDato & "   " & oDt.Rows(intCont).Item("TCMTRF").ToString.Trim
                            oDrVw.Cells(0).Value = strDato
                            oDrVw.Cells(1).Value = oDt.Rows(intCont).Item("STCCTC").ToString.Trim
                            strDato = Format(CType(oDt.Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00000")
                            If oDt.Rows(intCont).Item("CUNCNA").ToString.Trim = "" Then
                                strDato = strDato & "            "
                            Else
                                strDato = strDato & "     " & oDt.Rows(intCont).Item("CUNCNA").ToString.Trim.PadLeft(3, " ")
                            End If
                            oDrVw.Cells(2).Value = strDato
                            strDato = Format(CType(oDt.Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000")
                            strDato = strDato & "     " & oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                            oDrVw.Cells(3).Value = strDato

                            'If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                            If strTipoMoneda = "DOL" Then
                                'If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                '    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                'Else
                                '    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                'End If
                                strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")

                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCD")
                                bolSoles = False
                            Else
                                'If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                                '    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                'Else
                                '    strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                                'End If
                                strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")

                                dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                                bolSoles = True
                            End If
                            oDrVw.Cells(4).Value = strDato
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        Else
                            bolIGV = True
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oDrVw.Cells(3).Value = "SUB-TOTAL"
                            oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                            Me.dtgDetalle.Rows.Add(oDrVw)

                            If (intTipoDocumento = 1 Or intTipoDocumento = 51) Or (intTipoDocumento = 7 Or intTipoDocumento = 57) Then
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                strDato = "I.G.V.  " & strIGV & " %"
                                oDrVw.Cells(3).Value = strDato
                            End If

                            If bolSoles Then
                                If (intTipoDocumento = 1 Or intTipoDocumento = 51) Or (intTipoDocumento = 7 Or intTipoDocumento = 57) Then
                                    oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                                    Me.dtgDetalle.Rows.Add(oDrVw)
                                End If
                                If (intTipoDocumento = 1 Or intTipoDocumento = 51) Or (intTipoDocumento = 7 Or intTipoDocumento = 57) Then
                                    dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCS")
                                Else
                                    dblTotal = dblSubTotal
                                End If
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw.Cells(3).Value = "T O T A L"
                                oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                            Else
                                If (intTipoDocumento = 1 Or intTipoDocumento = 51) Or (intTipoDocumento = 7 Or intTipoDocumento = 57) Then
                                    oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                                    Me.dtgDetalle.Rows.Add(oDrVw)
                                End If
                                If (intTipoDocumento = 1 Or intTipoDocumento = 51) Or (intTipoDocumento = 7 Or intTipoDocumento = 57) Then
                                    dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCD")
                                Else
                                    dblTotal = dblSubTotal
                                End If

                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw = New DataGridViewRow
                                oDrVw.CreateCells(Me.dtgDetalle)
                                oDrVw.Cells(3).Value = "T O T A L"
                                oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                            End If
                            Me.dtgDetalle.Rows.Add(oDrVw)
                        End If
                    End If
                Next intCont
                If Not bolIGV Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    oDrVw.Cells(3).Value = "SUB-TOTAL"
                    oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                    Me.dtgDetalle.Rows.Add(oDrVw)
                    If bolSoles Then
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                    Else
                        dblTotal = dblSubTotal
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                    End If
                    Me.dtgDetalle.Rows.Add(oDrVw)
                End If
                'Case 1
                '    For intCont = 0 To oDt.Rows.Count - 1
                '        If oDt.Rows(intCont).Item("NDCCTC").ToString.Trim = dblNumFact Then
                '            If oDt.Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                '                oDrVw = New DataGridViewRow
                '                oDrVw.CreateCells(Me.dtgDetalle)
                '                oFiltro = New Hashtable
                '                'oFiltro.Add("PSCCMPN", oDt.Rows(intCont).Item("CCMPN").ToString.Trim)
                '                'oFiltro.Add("PSCDVSN", oDt.Rows(intCont).Item("CDVSN").ToString.Trim)
                '                'oFiltro.Add("PNCSRVNV", oDt.Rows(intCont).Item("CRBCTC").ToString.Trim)
                '                'oDtNew = oFacturaNeg.Lista_Datos_Servicio(oFiltro)
                '                strDato = oDt.Rows(intCont).Item("NCRDCC").ToString.Trim & ". "
                '                'strDato = strDato & "   " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                '                strDato = strDato & "   " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                '                strDato = strDato & "   " & oDt.Rows(intCont).Item("TCMTRF").ToString.Trim
                '                oDrVw.Cells(0).Value = strDato
                '                oDrVw.Cells(1).Value = oDt.Rows(intCont).Item("STCCTC").ToString.Trim
                '                strDato = Format(CType(oDt.Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00000")
                '                If oDt.Rows(intCont).Item("CUNCNA").ToString.Trim = "" Then
                '                    strDato = strDato & "            "
                '                Else
                '                    strDato = strDato & "     " & oDt.Rows(intCont).Item("CUNCNA").ToString.Trim.PadLeft(3, " ")
                '                End If
                '                oDrVw.Cells(2).Value = strDato
                '                strDato = Format(CType(oDt.Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000")
                '                strDato = strDato & "     " & oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                '                oDrVw.Cells(3).Value = strDato

                '                'If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                '                If strTipoMoneda = "DOL" Then
                '                    If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                '                        strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                '                    Else
                '                        strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                '                    End If


                '                    dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCD")
                '                    bolSoles = False
                '                Else
                '                    If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                '                        strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                '                    Else
                '                        strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double) * dblIGV, "###,###,###,###.00")
                '                    End If

                '                    dblSubTotal = dblSubTotal + CType(strDato, Double) 'oDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                '                    bolSoles = True
                '                End If
                '                oDrVw.Cells(4).Value = strDato
                '                Me.dtgDetalle.Rows.Add(oDrVw)
                '            End If
                '        End If
                '    Next intCont
                '    If strIGV <> "" Then 'Not bolIGV Then
                '        oDrVw = New DataGridViewRow
                '        oDrVw.CreateCells(Me.dtgDetalle)
                '        oDrVw.Cells(3).Value = "SUB-TOTAL"
                '        oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                '        Me.dtgDetalle.Rows.Add(oDrVw)

                '        If bolSoles Then
                '            If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                '                oDrVw = New DataGridViewRow
                '                oDrVw.CreateCells(Me.dtgDetalle)
                '                'strDato = "I.G.V.  " & strIGV & " %"
                '                oDrVw.Cells(3).Value = "I.G.V.  " & strIGV & " %"
                '                oDrVw.Cells(4).Value = Format((dblSubTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                '                Me.dtgDetalle.Rows.Add(oDrVw)
                '            End If
                '            If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                '                dblTotal = dblSubTotal * dblIGV
                '            Else
                '                dblTotal = dblSubTotal
                '            End If

                '            oDrVw = New DataGridViewRow
                '            oDrVw.CreateCells(Me.dtgDetalle)
                '            oDrVw.Cells(3).Value = "T O T A L"
                '            oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                '            Me.dtgDetalle.Rows.Add(oDrVw)
                '        Else
                '            If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                '                oDrVw = New DataGridViewRow
                '                oDrVw.CreateCells(Me.dtgDetalle)
                '                'strDato = "I.G.V.  " & strIGV & " %"
                '                oDrVw.Cells(3).Value = "I.G.V.  " & strIGV & " %"
                '                oDrVw.Cells(4).Value = Format((dblSubTotal * CType(strIGV, Double) / 100), "###,###,###,###.00")
                '                Me.dtgDetalle.Rows.Add(oDrVw)
                '            End If

                '            If intTipoDocumento = 1 Or intTipoDocumento = 51 Then
                '                dblTotal = dblSubTotal * dblIGV
                '            Else
                '                dblTotal = dblSubTotal
                '            End If

                '            oDrVw = New DataGridViewRow
                '            oDrVw.CreateCells(Me.dtgDetalle)
                '            oDrVw.Cells(3).Value = "T O T A L"
                '            oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                '            Me.dtgDetalle.Rows.Add(oDrVw)
                '        End If
                '    Else
                '        oDrVw = New DataGridViewRow
                '        oDrVw.CreateCells(Me.dtgDetalle)
                '        oDrVw.Cells(3).Value = "SUB-TOTAL"
                '        oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,###.00")
                '        Me.dtgDetalle.Rows.Add(oDrVw)
                '        If bolSoles Then
                '            dblTotal = dblSubTotal
                '            oDrVw = New DataGridViewRow
                '            oDrVw.CreateCells(Me.dtgDetalle)
                '            oDrVw.Cells(3).Value = "T O T A L"
                '            oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                '        Else
                '            dblTotal = dblSubTotal
                '            oDrVw = New DataGridViewRow
                '            oDrVw.CreateCells(Me.dtgDetalle)
                '            oDrVw.Cells(3).Value = "T O T A L"
                '            oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,###.00")
                '        End If
                '        Me.dtgDetalle.Rows.Add(oDrVw)
                '    End If

        End Select

    End Sub

    Private Sub txtReferencia1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReferencia1.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtReferencia1.Lines.Length > 3 Then
                    txtReferencia1.MaxLength = txtReferencia1.Text.Length
                End If
            Else
                If e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Delete) And txtReferencia1.Text.Length > 0 Then
                    txtReferencia1.MaxLength = 280
                    Dim nlinea As Integer = 0
                    nlinea = txtReferencia1.GetLineFromCharIndex(txtReferencia1.SelectionStart)
                    Dim ntext As Integer = 0
                    ntext = txtReferencia1.Lines(nlinea).Length

                    If ntext > 69 Then
                        If txtReferencia1.Lines.Length < 4 Then
                            txtReferencia1.AppendText(vbNewLine)
                        Else
                            e.KeyChar = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtReferencia2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReferencia2.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtReferencia2.Lines.Length > 11 Then
                    txtReferencia2.MaxLength = txtReferencia2.Text.Length
                    e.Handled = False
                End If
            Else
                If e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Delete) And txtReferencia2.Text.Length > 0 Then
                    txtReferencia2.MaxLength = 840
                    Dim nlinea As Integer = 0
                    nlinea = txtReferencia2.GetLineFromCharIndex(txtReferencia2.SelectionStart)
                    Dim ntext As Integer = 0
                    ntext = txtReferencia2.Lines(nlinea).Length
                    If ntext > 69 Then
                        If txtReferencia2.Lines.Length < 12 Then
                            txtReferencia2.AppendText(vbNewLine)
                        Else
                            e.KeyChar = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtReferencia1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReferencia1.KeyUp
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            'Dim lines() As String = txtReferencia1.Text.Split(vbNewLine)
            'MessageBox.Show(lines.Length.ToString)
        End If
    End Sub

    Private Sub txtReferencia2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReferencia2.KeyUp
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then

        End If
    End Sub

    Private Sub txtOCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOCompra.KeyPress
      
    End Sub

    Private Sub txtOCompra_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOCompra.KeyUp
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then

        End If
    End Sub
End Class

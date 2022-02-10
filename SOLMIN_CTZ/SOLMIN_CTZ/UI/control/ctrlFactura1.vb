Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones

Public Class ctrlFactura1
    Private dblNumFact As Double
    Private oDt As DataTable
    Private strTipoMoneda As String
    Private strIGV As String

    Sub New(ByVal poDt As DataTable, ByVal pdblNumFact As Double, ByVal pstrTipoMoneda As String, ByVal pstrIGV As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Crear_Grilla()
        Me.dtgDetalle.DataSource = Nothing
        dblNumFact = pdblNumFact
        strTipoMoneda = pstrTipoMoneda
        strIGV = pstrIGV
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
                    strDato = oDt.Rows(intCont).Item("NCRDCC").ToString.Trim
                    strDato = strDato & "     " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
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
                        strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                        dblSubTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCD")
                        bolSoles = False
                    Else
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

                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    strDato = "I.G.V.  " & strIGV & " %"
                    oDrVw.Cells(3).Value = strDato
                    If bolSoles Then
                        oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00")
                        dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCS")
                        Me.dtgDetalle.Rows.Add(oDrVw)
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "T O T A L"
                        oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,###.00")
                    Else
                        oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00")
                        dblTotal = dblSubTotal + oDt.Rows(intCont).Item("IVLDCD")
                        Me.dtgDetalle.Rows.Add(oDrVw)
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
    End Sub

End Class

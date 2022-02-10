Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports System.ComponentModel

Public Class ctrlReFactura
    Private dblNumFact As Double
    Private oDt As DataTable
    Private dblPorIgv As Decimal = 0
    Private IntTipoImpresionFactura As Integer


    Private _pMaxLonDescripcionServicio As Integer = 30
    Public Property pMaxLonDescripcionServicio() As Integer
        Get
            Return _pMaxLonDescripcionServicio
        End Get
        Set(ByVal value As Integer)
            _pMaxLonDescripcionServicio = value
        End Set
    End Property


    Sub New(ByVal TipoDoc As String, ByVal poDt As DataTable, ByVal pdblNumFact As Double, ByVal pdblPorIgv As Decimal, ByVal pIntTipoFactura As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        IntTipoImpresionFactura = pIntTipoFactura
        Crear_Grilla()
        Me.dtgDetalle.DataSource = Nothing
        dblPorIgv = pdblPorIgv
        dblNumFact = pdblNumFact

        oDt = poDt.Copy
        Llenar_Detalles(TipoDoc)
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

    Public WriteOnly Property ModificarDescripcionFactura() As Boolean
        Set(ByVal value As Boolean)
            Try
                For intx As Integer = 0 To Me.dtgDetalle.RowCount - 4
                    Me.dtgDetalle.Rows(intx).Cells("SERVICIO").ReadOnly = value
                Next
            Catch : End Try
            dtgDetalle.Columns("DETALLE").Visible = value
        End Set
    End Property


#End Region

    Public Function DevuelveDatos() As DataTable
        Dim oDt As New DataTable
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("SERVICIO", GetType(String))
        dt.Columns.Add("NRRUBR", GetType(String))
        dt.Columns.Add("NCRDCC", GetType(String))

        For z As Integer = 0 To Me.dtgDetalle.RowCount - 4
            dr = dt.NewRow
            dr(0) = dtgDetalle.Rows(z).Cells("SERVICIO").Value
            dr(1) = dtgDetalle.Rows(z).Cells("NRRUBR").Value
            dr(2) = dtgDetalle.Rows(z).Cells("NCRDCC").Value
            dt.Rows.Add(dr)
        Next

        Return dt
    End Function

#Region "Crear_Grilla"

    Private Sub Crear_Grilla()

        Me.dtgDetalle.Columns.Clear()
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
        If IntTipoImpresionFactura = 1 Then
            oDcTx.Visible = False
        End If

        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.Width = 300
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CANTIDAD"
        oDcTx.HeaderText = "C A N T I D A D"
        If IntTipoImpresionFactura = 1 Then
            oDcTx.Visible = False

        End If

        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Width = 150
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TARIFA"
        If IntTipoImpresionFactura = 1 Then
            oDcTx.HeaderText = " "
        Else
            oDcTx.HeaderText = "T A R I F A"
        End If
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


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CCMPN"
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CDVSN"
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CRBCTC"
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRTFSV"
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NRRUBR"
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NCRDCC"
        oDcTx.Visible = False
        oDcTx.ReadOnly = True
        Me.dtgDetalle.Columns.Add(oDcTx)

    End Sub

#End Region

    Private Sub Llenar_Detalles(ByVal TipDoc As String)
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        Dim strDato As String = String.Empty
        Dim dblSubTotal As Double = 0
        Dim dblTotal As Double = 0
        Dim bolSoles As Boolean = False
        Dim bolIGV As Boolean = False
        'Dim oDtNew As DataTable
        'Dim oFacturaNeg As New clsFactura
        'Dim oFiltro As New Filtro

        For intCont = 0 To oDt.Rows.Count - 1
            strDato = String.Empty
            If oDt.Rows(intCont).Item("NDCCTC").ToString.Trim = dblNumFact Then
                If oDt.Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgDetalle)
                    Dim NOMSER As String = String.Empty
                    Dim TOBS As String = String.Empty
                    'oFiltro.Parametro1 = oDt.Rows(intCont).Item("CCMPN").ToString.Trim
                    'oFiltro.Parametro2 = oDt.Rows(intCont).Item("CDVSN").ToString.Trim
                    'oFiltro.Parametro3 = oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                    'oFiltro.Parametro4 = Val("" & oDt.Rows(intCont).Item("NRTFSV") & "")
                    'oDtNew = oFacturaNeg.Lista_Datos_Servicio(oFiltro)


                    'If IntTipoImpresionFactura = 1 Then
                    '    NOMSER = oDtNew.Rows(0).Item("TCMTRF").ToString.Trim
                    'Else
                    '    NOMSER = oDtNew.Rows(0).Item("NOMSER").ToString.Trim
                    '    TOBS = oDtNew.Rows(0).Item("TOBS").ToString.Trim
                    '    strDato = oDt.Rows(intCont).Item("NCRDCC").ToString.Trim
                    '    strDato = strDato & "     " & oDt.Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, "0")
                    'End If
                    NOMSER = oDt.Rows(intCont).Item("TCMTRF").ToString.Trim

                    strDato = strDato & "   " & NOMSER
                    oDrVw.Cells(0).Value = strDato


                    strDato = Format(CType(oDt.Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00000")

                    If oDt.Rows(intCont).Item("CUNCNA").ToString.Trim = "" Then
                        strDato = strDato & "            "
                    Else
                        strDato = strDato & "     " & oDt.Rows(intCont).Item("CUNCNA").ToString.Trim
                    End If

                    oDrVw.Cells(1).Value = TOBS

                    oDrVw.Cells(2).Value = strDato


                    strDato = Format(CType(oDt.Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.000")
                    strDato = strDato & "     " & oDt.Rows(intCont).Item("CUTCTC").ToString.Trim
                    If IntTipoImpresionFactura = 1 Then
                        oDrVw.Cells(3).Value = ""
                    Else
                        oDrVw.Cells(3).Value = strDato
                    End If

                    If TipDoc = "RU" Then
                        If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then

                            strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00")

                            dblSubTotal = dblSubTotal + Math.Round(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), 2)
                            bolSoles = False
                        Else

                            strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00")

                            dblSubTotal = dblSubTotal + Math.Round(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), 2)
                            bolSoles = True
                        End If
                        oDrVw.Cells(4).Value = strDato
                    Else
                        If oDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then


                             strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim + (dblPorIgv / 100 * oDt.Rows(intCont).Item("IVLDCD").ToString.Trim), Double), "###,###,###,##0.00")

                            dblSubTotal = dblSubTotal + Math.Round(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim + (dblPorIgv / 100 * oDt.Rows(intCont).Item("IVLDCD").ToString.Trim), Double), 2)
                            bolSoles = False
                        Else

                            strDato = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim + (dblPorIgv / 100 * oDt.Rows(intCont).Item("IVLDCS").ToString.Trim), Double), "###,###,###,##0.00")

                            dblSubTotal = dblSubTotal + Math.Round(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim + (dblPorIgv / 100 * oDt.Rows(intCont).Item("IVLDCS").ToString.Trim), Double), 2)
                            bolSoles = True
                        End If
                        oDrVw.Cells(4).Value = strDato
                    End If

                    oDrVw.Cells(5).Value = oDt.Rows(intCont).Item("CCMPN").ToString.Trim
                    oDrVw.Cells(6).Value = oDt.Rows(intCont).Item("CDVSN").ToString.Trim
                    oDrVw.Cells(7).Value = oDt.Rows(intCont).Item("CRBCTC").ToString.Trim
                    oDrVw.Cells(8).Value = Val("" & oDt.Rows(intCont).Item("NRTFSV") & "")
                    oDrVw.Cells(9).Value = Val("" & oDt.Rows(intCont).Item("NRRUBR") & "")
                    oDrVw.Cells(10).Value = oDt.Rows(intCont).Item("NCRDCC")

                    Me.dtgDetalle.Rows.Add(oDrVw)
                Else
                    If TipDoc = "RU" Then
                        bolIGV = True
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        oDrVw.Cells(3).Value = "SUB-TOTAL"

                        oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,##0.00")
                        Me.dtgDetalle.Rows.Add(oDrVw)
                    End If

                    If TipDoc = "RU" Then
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgDetalle)
                        strDato = "I.G.V. " & dblPorIgv.ToString & " %"
                        oDrVw.Cells(3).Value = strDato


                        If bolSoles Then

                            oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00")

                            dblTotal = dblSubTotal + Math.Round(CType(oDt.Rows(intCont).Item("IVLDCS").ToString.Trim, Double), 2)

                            Me.dtgDetalle.Rows.Add(oDrVw)
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oDrVw.Cells(3).Value = "T O T A L"

                            oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,##0.00")
                        Else

                            oDrVw.Cells(4).Value = Format(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00")

                            dblTotal = dblSubTotal + Math.Round(CType(oDt.Rows(intCont).Item("IVLDCD").ToString.Trim, Double), 2)

                            Me.dtgDetalle.Rows.Add(oDrVw)
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oDrVw = New DataGridViewRow
                            oDrVw.CreateCells(Me.dtgDetalle)
                            oDrVw.Cells(3).Value = "T O T A L"

                            oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,##0.00")
                        End If
                        Me.dtgDetalle.Rows.Add(oDrVw)

                    End If

                End If
            End If
        Next intCont

        If Not bolIGV Then
            If TipDoc = "RU" Then
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgDetalle)
                oDrVw.Cells(3).Value = "SUB-TOTAL"

                oDrVw.Cells(4).Value = Format(dblSubTotal, "###,###,###,##0.00")
                Me.dtgDetalle.Rows.Add(oDrVw)
            End If
            If bolSoles Then
                dblTotal = dblSubTotal
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgDetalle)
                oDrVw.Cells(3).Value = "T O T A L"

                oDrVw.Cells(4).Value = "S/.         " & Format(dblTotal, "###,###,###,##0.00")
            Else
                dblTotal = dblSubTotal
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgDetalle)
                oDrVw.Cells(3).Value = "T O T A L"

                oDrVw.Cells(4).Value = "US$         " & Format(dblTotal, "###,###,###,##0.00")
            End If
            Me.dtgDetalle.Rows.Add(oDrVw)
        End If
    End Sub


    'Private Sub dtgDetalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgDetalle.EditingControlShowing
    '    Try
    '        Dim colName As String = dtgDetalle.Columns(dtgDetalle.CurrentCell.ColumnIndex).Name
    '        Dim Texto As New TextBox
    '        Select Case colName
    '            Case "SERVICIO"
    '                Texto = CType(e.Control, TextBox)
    '                Texto.Text = Texto.Text.Trim
    '                Texto.MaxLength = _pMaxLonDescripcionServicio
    '        End Select
    '    Catch ex As Exception

    '    End Try
    'End Sub
End Class

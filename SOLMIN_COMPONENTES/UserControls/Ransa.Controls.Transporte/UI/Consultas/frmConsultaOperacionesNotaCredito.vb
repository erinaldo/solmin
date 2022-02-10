Imports System.Windows.Forms
Imports System.Text

Public Class frmConsultaOperacionesNotaCredito

    Private strListaOpe As List(Of ConsistenciaOperacion) 'String = ""
    Private strCompania As String = ""
    Private strDivision As String = ""
    Private strTipoDoc As Int32 = 0
    Private strDocument As Int64 = 0
    Private dblImporteFactura As Double = 0
    Private intMonedaFactura As Integer = 0

    Sub New(ByVal pstrConsistencia As List(Of ConsistenciaOperacion), ByVal pstrCodCom As String, ByVal pstrCodDiv As String, ByVal pstrTipoDoc As Int32, ByVal pstrDocument As Int64)
        strListaOpe = pstrConsistencia
        strCompania = pstrCodCom
        strDivision = pstrCodDiv
        strTipoDoc = pstrTipoDoc
        strDocument = pstrDocument
    End Sub

    Private _DtSource As DataTable
    Public Property DtSource() As DataTable
        Get
            Return _DtSource
        End Get
        Set(ByVal value As DataTable)
            _DtSource = value
        End Set
    End Property

    Public Property ListaOperacion() As List(Of ConsistenciaOperacion)
        Get
            Return strListaOpe
        End Get
        Set(ByVal value As List(Of ConsistenciaOperacion))
            strListaOpe = value
        End Set
    End Property

    Private _TNC As Integer
    Public Property TipoNotaCredito() As Integer
        Get
            Return _TNC
        End Get
        Set(ByVal value As Integer)
            _TNC = value
        End Set
    End Property
    Private _TDF As Integer
    Public Property TipoDocumentoReFactura() As Integer
        Get
            Return _TDF
        End Get
        Set(ByVal value As Integer)
            _TDF = value
        End Set
    End Property

    Private _Planta As Decimal
    Public Property PlantaSeleccionada() As Decimal
        Get
            Return _Planta
        End Get
        Set(ByVal value As Decimal)
            _Planta = value
        End Set
    End Property

    Private _compania As String
    Public Property Compania() As String
        Get
            Return _compania
        End Get
        Set(ByVal value As String)
            _compania = value
        End Set
    End Property

    Private _Division As String
    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property

    Private _TipoCambio As Double
    Public Property TipoCambio() As Double
        Get
            Return _TipoCambio
        End Get
        Set(ByVal value As Double)
            _TipoCambio = value
        End Set
    End Property
    Public Property ImporteSaldoFactura() As Double
        Get
            Return dblImporteFactura
        End Get
        Set(ByVal value As Double)
            dblImporteFactura = value
        End Set
    End Property

    Public Property MonedaFactura() As Int32
        Get
            Return intMonedaFactura
        End Get
        Set(ByVal value As Int32)
            intMonedaFactura = value
        End Set
    End Property

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private Sub frmConsultaOperacionesNotaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Insertar_Operaciones_X_Importes_Facturados()
        Me.Alinear_Columnas_Grilla()
        Me.Listar_Operaciones_Facturadas()
    End Sub
    Private Sub Insertar_Operaciones_X_Importes_Facturados()
        Dim RefacturaBLL As New Operaciones.ReFacturacion_BLL
        Dim param As New Hashtable
        Try
            param.Add("PNNOPRCN", ListUnique(ListOperaciones))
            param.Add("PNNDCMFC", ListUnique(ListFacturas))
            param.Add("PNCTPDFC", 1)
            param.Add("PSCCPMN", Compania)
            param.Add("PNCMNDA", MonedaFactura)
            param.Add("PNIVNTA", TipoCambio)
            RefacturaBLL.Insertar_Importes_X_Operaciones_Facturadas(param)

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub Listar_Operaciones_Facturadas()
        Dim RefacturaBLL As New Operaciones.ReFacturacion_BLL
        Dim param As New Hashtable
        Dim rowData As DataRow
        Dim dwvrow As DataGridViewRow
        Try
            param.Add("PNNOPRCN", ListUnique(ListOperaciones))
            param.Add("PNNDCMFC", ListUnique(ListFacturas))
            param.Add("PNCTPDFC", 1)
            param.Add("PNCMNDA1", IIf(ListaOperacion(0).MonedaFactura = 1, "SOL", "DOL"))
            param.Add("PNFECFAC", IIf(TipoDocumentoReFactura = 2, HelpClassST.TodayNumeric, HelpClassST.CFecha_de_10_a_8(ListaOperacion(0).Fecha)))
            param.Add("PSCCPMN", Compania)
            Me.gwdDatos.Rows.Clear()
            For Each rowData In RefacturaBLL.Listar_Importes_X_Operaciones_Facturadas(param).Rows
                dwvrow = New DataGridViewRow
                dwvrow.CreateCells(Me.gwdDatos)
                dwvrow.Cells(1).Value = rowData.Item("NOPRCN")
                dwvrow.Cells(2).Value = rowData.Item("NGUITR")
                dwvrow.Cells(3).Value = rowData.Item("TCMTPD")
                dwvrow.Cells(4).Value = rowData.Item("NDCMFC")
                dwvrow.Cells(5).Value = HelpClassST.CFecha_de_8_a_10(rowData.Item("FECFAC"))
                dwvrow.Cells(6).Value = rowData.Item("TSGNMN")
                dwvrow.Cells(7).Value = Format(rowData.Item("ISRVGU"), "###,###,###,###.00")
                dwvrow.Cells(8).Value = rowData.Item("DETALLE")
                Me.gwdDatos.Rows.Add(dwvrow)
            Next
            If TipoDocumentoReFactura = 2 Then
                Me.gwdDatos.Columns("SELEC_C").Visible = False
                For x As Integer = 0 To Me.gwdDatos.Rows.Count - 1
                    Me.gwdDatos.EndEdit()
                    Me.gwdDatos.Item("SELEC_C", x).Value = False
                Next
            Else
                For x As Integer = 0 To Me.gwdDatos.Rows.Count - 1
                    If Me.gwdDatos.Item("SELEC_C", x).Value = False Then
                        Me.gwdDatos.EndEdit()
                        Me.gwdDatos.Item("SELEC_C", x).Value = True
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        ' If validar_importe() Then
        strListaOpe = Consistencia_Operacion_Facturas()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'Exit Sub
        ' End If

    End Sub

    Private Function Consistencia_Operacion_Facturas() As List(Of ConsistenciaOperacion)
        Dim lstConsistenciaOperacion As New List(Of ConsistenciaOperacion)
        Dim objConsistenciaOperacion As ConsistenciaOperacion
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Return Nothing
            Exit Function
        End If
        Me.gwdDatos.EndEdit()
        'mConsistenciaPlanta = False
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            objConsistenciaOperacion = New ConsistenciaOperacion
            objConsistenciaOperacion.Operacion = Me.gwdDatos.Item("NOPRCN_C", lint_Contador).Value
            objConsistenciaOperacion.Factura = Me.gwdDatos.Item("NDCMFC_C", lint_Contador).Value
            objConsistenciaOperacion.Fecha = Me.gwdDatos.Item("FECFAC_C", lint_Contador).Value
            objConsistenciaOperacion.TipoCambioFactura = TipoCambio
            'objConsistenciaOperacion.MonedaImporte = ListaOperacion(lint_Contador).MonedaImporte
            If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                objConsistenciaOperacion.Liberar = "SI"
            Else
                objConsistenciaOperacion.Liberar = "NO"
            End If
            lstConsistenciaOperacion.Add(objConsistenciaOperacion)
        Next
        Return lstConsistenciaOperacion
    End Function
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call Eliminar_Servicios_A_ReFacturar()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick
        Dim operacion As Double = 0
        Try
            'If Me.gwdDatos.RowCount < 0 OrElse e.RowIndex < 0 Then Exit Sub
            Select Case e.ColumnIndex
                Case 8
                    Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarServicioRefactura = New frmLiquidacionFlete_DlgMostrarServicioRefactura( _
                            Compania, Division, _
                             gwdDatos.CurrentRow.Cells("NOPRCN_C").Value, _
                             gwdDatos.CurrentRow.Cells("NGUITR").Value, "L", 1)
                    With fMostrarInfAdic
                        ' .tcListadoGuiasCargadas.Controls.Remove(.tpGuiasRemisionHijas)
                        .pUsuario = _pUsuario
                        .ShowDialog()
                        Listar_Operaciones_Facturadas()
                    End With

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function Lista_GR_x_Operacion(ByVal operacion As Double, ByVal ndocumento As Double) As DataTable
        Dim parametros As New Hashtable
        Dim ReFacturaDAL As New Operaciones.ReFacturacion_BLL
        Dim dt As DataTable
        Dim importe As Double = 0
        parametros.Add("PSCCMPN", Compania)
        parametros.Add("PSCDVSN", Division)
        parametros.Add("PNCPLNDV", PlantaSeleccionada)
        parametros.Add("PNNOPRCN", operacion)
        parametros.Add("PNNDCMFC", ndocumento)
        dt = ReFacturaDAL.Listar_Guias_X_Operaciones(parametros)
        Return dt
    End Function
    Private Sub Eliminar_Servicios_A_ReFacturar()
        Dim RefacturaBLL As New Operaciones.ReFacturacion_BLL
        Dim param As New Hashtable
        Try
            param.Add("PNNOPRCN", ListUnique(ListOperaciones))
            param.Add("PNNDCMFC", ListUnique(ListFacturas))
            param.Add("PNCTPDFC", 1)
            param.Add("PSCCPMN", Compania)
            RefacturaBLL.Eliminar_Servicios_A_ReFacturar(param)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gwdDatos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gwdDatos.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = gwdDatos.Columns(gwdDatos.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName

                Case "IMPORTE"
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
        If HelpClassST.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Function ListUnique(ByVal listaFactuas As String) As String
        Dim lista() As String = listaFactuas.Split(",")
        Dim oHas As New Hashtable
        Dim Factura As String = ""
        Dim sbLista As New StringBuilder
        Dim Texto As String = ""
        For intX As Integer = 0 To lista.Length - 1
            Factura = ("" & lista(intX)).Trim
            If Factura.Length > 0 Then
                If Not oHas.Contains(Factura) Then
                    oHas(Factura) = Factura
                    sbLista.Append(Factura & ",")
                End If
            End If
        Next
        Texto = sbLista.ToString
        Texto = Texto.Substring(0, Texto.LastIndexOf(","))
        Return Texto
    End Function
    Private Function ListOperaciones() As String
        Dim result As String = ""
        Dim list As String = ""
        For a As Integer = 0 To ListaOperacion.Count - 1
            result += ListaOperacion(a).Operacion & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Function ListFechaFacturas() As String
        Dim result As String = ""
        Dim list As String = ""
        For a As Integer = 0 To ListaOperacion.Count - 1
            result += ListaOperacion(a).Fecha & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Function ListMonedaFacturas() As String
        Dim result As String = ""
        Dim list As String = ""
        For a As Integer = 0 To ListaOperacion.Count - 1
            result += ListaOperacion(a).MonedaImporte & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Function ListFacturas() As String
        Dim result As String = ""
        Dim list As String = ""
        For a As Integer = 0 To ListaOperacion.Count - 1
            result += ListaOperacion(a).Factura & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Function validar_importe() As Boolean
        Dim result As Boolean = True
        Dim dblImporteRefactura As Double = 0
        'For index As Integer = 0 To Me.gwdDatos.RowCount - 1
        '    If Me.gwdDatos.Item("IMPORTE", index).Value < 0 Then
        '        MsgBox("El importe debe ser mayor a 0", MsgBoxStyle.Exclamation)
        '        result = False
        '        Exit Function
        '    End If
        'Next
        If TipoDocumentoReFactura = 3 Then
            For index As Integer = 0 To Me.gwdDatos.RowCount - 1
                dblImporteRefactura += Me.gwdDatos.Item("IMPORTE", index).Value
            Next

            If dblImporteRefactura > ImporteSaldoFactura Then
                MsgBox("El importe excede el saldo de la factura" + _
                vbNewLine + "Saldo: " + ImporteSaldoFactura, MsgBoxStyle.Exclamation)
                result = False
                Exit Function
            End If
        End If
        Return result
    End Function
End Class


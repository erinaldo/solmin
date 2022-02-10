Imports SOLMIN_SC.Negocio

Public Class frmBuscarDocCosto

    Private oEmbarque As clsEmbarque
    Private oMoneda As clsMoneda
    Private oDocApertura As clsDocApertura
    Private dblEmbarque As Double
    Private strCodVariable As String


    Public Sub New(ByVal pdblEmbarque As Double, ByVal pstrCodVariable As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dblEmbarque = pdblEmbarque
        strCodVariable = pstrCodVariable

    End Sub

    Private Sub frmBuscarDocCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oEmbarque = New clsEmbarque
        oMoneda = New clsMoneda
        oDocApertura = New clsDocApertura
        Crear_Grilla_Documentos_Adjuntos()
        Llenar_Documentos_Adjuntos()

    End Sub

    Private Sub Crear_Grilla_Documentos_Adjuntos()
        Dim oDcTx As DataGridViewColumn
        Dim oDcCh As DataGridViewCheckBoxColumn

        oDcCh = New DataGridViewCheckBoxColumn
        oDcCh.Name = "CHECK"
        oDcCh.HeaderText = ""
        oDcCh.Resizable = DataGridViewTriState.False
        oDcCh.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcCh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcCh)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NOMVAR"
        oDcTx.HeaderText = "Documento"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewComboBoxColumn
        oDcTx.Name = "TDOCIN"
        oDcTx.ReadOnly = True
        oDcTx.Visible = False
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewTextBoxColumn
        oDcTx.Name = "NCRRDC"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.Visible = False
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NDOCUM"
        oDcTx.HeaderText = "N° Documento"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = False
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONORG"
        oDcTx.HeaderText = "Monto (Moneda Origen)"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        oDcTx.Visible = True
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONEDA"
        oDcTx.HeaderText = "Moneda Origen"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "MONDOL"
        oDcTx.HeaderText = "Monto Dolares"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dtgDocumentosAdjuntos.Columns.Add(oDcTx)

    End Sub

    Private Sub Llenar_Documentos_Adjuntos()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer

        oDt = oDocApertura.Lista_Documentos_Costo_Embarque(dblEmbarque)
        For intCont = 0 To oDt.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgDocumentosAdjuntos)
            oDrVw.Cells(0).Value = False
            oDrVw.Cells(1).Value = oDt.Rows(intCont).Item("NOMVAR").ToString.Trim
            oDrVw.Cells(2).Value = oDt.Rows(intCont).Item("NDOCIN").ToString.Trim
            oDrVw.Cells(3).Value = oDt.Rows(intCont).Item("NCRRDC").ToString.Trim
            oDrVw.Cells(4).Value = oDt.Rows(intCont).Item("NDOCUM").ToString.Trim
            oDrVw.Cells(5).Value = Format(Double.Parse(oDt.Rows(intCont).Item("IVLORG").ToString.Trim), "###,###,##0.00")
            oDrVw.Cells(6).Value = oDt.Rows(intCont).Item("NMONOC").ToString.Trim
            oDrVw.Cells(7).Value = Format(Double.Parse(oDt.Rows(intCont).Item("IVLDOL").ToString.Trim), "###,###,##0.00")
            Me.dtgDocumentosAdjuntos.Rows.Add(oDrVw)
        Next intCont
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim intCont As Integer
        Dim dblNrDocumento As Double
        Dim dblNrCorrelativo As Double

        Me.Cursor = Cursors.WaitCursor
        dtgDocumentosAdjuntos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For intCont = 0 To Me.dtgDocumentosAdjuntos.RowCount - 1
            If dtgDocumentosAdjuntos.Rows(intCont).Cells("CHECK").Value Then
                dblNrDocumento = Me.dtgDocumentosAdjuntos.Rows(intCont).Cells("TDOCIN").Value
                dblNrCorrelativo = Me.dtgDocumentosAdjuntos.Rows(intCont).Cells("NCRRDC").Value
                oDocApertura.Guardar_Documento_Costo_Total_X_Embarque(dblEmbarque, strCodVariable, dblNrDocumento, dblNrCorrelativo)
            End If
        Next
        Me.Cursor = Cursors.Default
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class

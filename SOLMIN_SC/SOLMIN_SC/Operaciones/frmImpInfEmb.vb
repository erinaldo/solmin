Imports SOLMIN_SC.Negocio

Public Class frmImpInfEmb
    Private objImpInfo As SOLMIN_SC.Negocio.clsImpInfEmbarcador
    Public strNumEmbarcador As String

    Sub New(ByVal pstrEmbarque As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        objImpInfo = New SOLMIN_SC.Negocio.clsImpInfEmbarcador
        objImpInfo.Embarque = pstrEmbarque
    End Sub

    Private Sub frmImpInfEmb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim oDt As DataTable

            Cursor = Cursors.WaitCursor
            Crear_Grilla_Datos_Importacion()
            If objImpInfo.Embarque <> vbNullString Then
                oDt = objImpInfo.Obtener_Informacion_Embarque
            Else
                oDt = objImpInfo.Obtener_Informacion_Total
            End If
            Llenar_Grilla_Importacion(oDt)
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
      
    End Sub

#Region "Crear Grilla Datos de Importacion"

    Private Sub Crear_Grilla_Datos_Importacion()
        Dim oDcTx As DataGridViewColumn

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SIDYRC"
        oDcTx.HeaderText = "N° del Embarcador"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SIDRNS"
        oDcTx.HeaderText = "N° de Embarque"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SNROEMB"
        oDcTx.HeaderText = "DOC. EMBARQUE"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CTIPTRA"
        oDcTx.HeaderText = "MEDIO DE TRANSPORTE"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "STRANS"
        oDcTx.HeaderText = "TRANSPORTISTA"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "SVIAJE"
        oDcTx.HeaderText = "NAVE"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CPAIORI"
        oDcTx.HeaderText = "ORIGEN"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CPTOORI"
        oDcTx.HeaderText = "PUERTO ORIGEN"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        oDcTx.Visible = True
        Me.dtgInformacion.Columns.Add(oDcTx)

    End Sub

#End Region

    Private Sub Llenar_Grilla_Importacion(ByVal poDt As DataTable)
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        
        For intCont = 0 To poDt.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dtgInformacion)
            dtgInformacion.Rows.Add(oDrVw)
            dtgInformacion.Rows(intCont).Cells(0).Value = poDt.Rows(intCont).Item("SIDYRC").ToString.Trim
            dtgInformacion.Rows(intCont).Cells(1).Value = poDt.Rows(intCont).Item("SIDRNS").ToString.Trim
            dtgInformacion.Rows(intCont).Cells(2).Value = poDt.Rows(intCont).Item("SNROEMB").ToString.Trim
            If poDt.Rows(intCont).Item("CTIPTRA").ToString.Trim = "A" Then
                dtgInformacion.Rows(intCont).Cells(3).Value = "AEREO"
            Else
                dtgInformacion.Rows(intCont).Cells(3).Value = "MARITIMO"
            End If
            dtgInformacion.Rows(intCont).Cells(4).Value = poDt.Rows(intCont).Item("STRANS").ToString.Trim
            dtgInformacion.Rows(intCont).Cells(5).Value = poDt.Rows(intCont).Item("SVIAJE").ToString.Trim
            dtgInformacion.Rows(intCont).Cells(6).Value = poDt.Rows(intCont).Item("CPAIORI").ToString.Trim
            dtgInformacion.Rows(intCont).Cells(7).Value = poDt.Rows(intCont).Item("CPTOORI").ToString.Trim
        Next intCont
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub dtgInformacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgInformacion.CellDoubleClick
        If e.RowIndex > -1 Then
            strNumEmbarcador = dtgInformacion.Rows(e.RowIndex).Cells("SIDYRC").Value.ToString.Trim
            Me.DialogResult = Windows.Forms.DialogResult.OK           
        End If
    End Sub
End Class

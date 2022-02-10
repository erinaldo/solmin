Imports SOLMIN_SC.Negocio
'Imports CTLServicios
Imports Ransa.TypeDef.Cliente
Imports System.Web

Public Class frmAsignacionColumnas



    'Private oCliente As clsCliente
    Private oTableros As clsTableroDatos
    Dim Actual As String
    Dim Arriba As String
    Dim Abanjo As String

    Private Sub frmAsignacionColumnas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'oCliente = New clsCliente
        oTableros = New clsTableroDatos
        'oCliente.Lista = DirectCast(HttpRuntime.Cache.Get("Cliente"), clsCliente).Lista.Copy
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pUsuario = HelpUtil.UserName
        Cargar_Reporte()
    End Sub

#Region "Crear Grilla Documentos"

    Private Sub Crear_Grilla_Documentos()
        Dim oDcHx As DataGridViewCheckBoxColumn
        Dim oDcTx As DataGridViewColumn


        oDcHx = New DataGridViewCheckBoxColumn
        oDcHx.Name = "Check"
        oDcHx.HeaderText = ""
        oDcHx.Resizable = DataGridViewTriState.False
        oDcHx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcHx.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        oDcHx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcHx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcHx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "CODIGO"
        oDcTx.HeaderText = "CODIGO"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "COMPANIA"
        oDcTx.HeaderText = "COMPANIA"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "COD_DIVISION"
        oDcTx.HeaderText = "COD_DIVISION"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "COD_CLIENTE"
        oDcTx.HeaderText = "COD_CLIENTE"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TITULO"
        oDcTx.HeaderText = "TITULO"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NOMBRE_CAMPO"
        oDcTx.HeaderText = "NOMBRE_CAMPO"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "NUM_SEC"
        oDcTx.HeaderText = "NUM_SEC"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "TIPO"
        oDcTx.HeaderText = "TIPO"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "FORMATO_COLUMN"
        oDcTx.HeaderText = "FORMATO_COLUMN"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)

        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = "ESTADO"
        oDcTx.HeaderText = "ESTADO"
        oDcTx.Resizable = DataGridViewTriState.False
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.ReadOnly = False
        Me.dtgAsigColumna.Columns.Add(oDcTx)


        dtgAsigColumna.Columns(2).Visible = False
        dtgAsigColumna.Columns(3).Visible = False
        dtgAsigColumna.Columns(4).Visible = False
        dtgAsigColumna.Columns(7).Visible = False
        dtgAsigColumna.Columns(8).Visible = False
        dtgAsigColumna.Columns(9).Visible = False


    End Sub

#End Region

    Private Sub Buscar_Items()
        Limpiar_Grilla_Documentos()
        Cargar_Infromacion_Asignacion_Item()
    End Sub

    Private Sub Cargar_Reporte()
        Me.cmbTipoReporte.DataSource = oTableros.Listar_Estado_ReporteB()
        Me.cmbTipoReporte.DisplayMember = "NOMREP"
        Me.cmbTipoReporte.ValueMember = "NRORPT"
    End Sub

    Private Sub Crear_Arbol()
        Dim tndNodo As TreeNode
        Dim lintCont As Integer

        Me.tvwCheckPoint.Nodes(0).Nodes(0).Nodes.Clear()
        Dim oDt As DataTable
        oDt = oTableros.Listar_Detalle_Asignacion_ItemB(cmbCliente.pCodigo.ToString.Trim, cmbTipoReporte.SelectedValue.ToString())
        With oDt
            For lintCont = 0 To .Rows.Count - 1
                If .Rows(lintCont).Item("ESTADO") = "A" Then
                    tndNodo = New TreeNode(.Rows(lintCont).Item("TITULO").ToString.Trim, 4, 4)
                Else
                    tndNodo = New TreeNode(.Rows(lintCont).Item("ESTADO").ToString.Trim, 5, 5)
                End If
                Dim obj(2) As Object
                obj(0) = .Rows(lintCont).Item("CODIGO").ToString.Trim
                obj(1) = .Rows(lintCont).Item("TITULO").ToString.Trim
                obj(2) = .Rows(lintCont).Item("ESTADO").ToString.Trim
                tndNodo.Tag = obj
                tndNodo.Name = .Rows(lintCont).Item("NUM_SEC").ToString.Trim
                If .Rows(lintCont).Item("ESTADO") = "A" Then

                    Me.tvwCheckPoint.Nodes(0).Nodes(0).Nodes.Add(tndNodo)
                End If
            Next lintCont
        End With
    End Sub





    Private Sub Limpiar_Grilla_Documentos()
        Me.dtgAsigColumna.Rows.Clear()
    End Sub


    Private Sub Cargar_Infromacion_Asignacion_Item()

        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        Dim oDt As DataTable

        oDt = oTableros.Listar_Detalle_Asignacion_ItemB(cmbCliente.pCodigo.ToString.Trim, cmbTipoReporte.SelectedValue.ToString())

        With oDt
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To .Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgAsigColumna)
                    If .Rows(intCont).Item("ESTADO").ToString.Trim = "A" Then
                        oDrVw.Cells(0).Value = True
                        oDrVw.Cells(1).Value = .Rows(intCont).Item("CODIGO").ToString.Trim
                        oDrVw.Cells(2).Value = .Rows(intCont).Item("COMPANIA").ToString.Trim
                        oDrVw.Cells(3).Value = .Rows(intCont).Item("COD_DIVISION").ToString.Trim
                        oDrVw.Cells(4).Value = .Rows(intCont).Item("COD_CLIENTE").ToString.Trim
                        oDrVw.Cells(5).Value = .Rows(intCont).Item("TITULO").ToString.Trim
                        oDrVw.Cells(6).Value = .Rows(intCont).Item("NOMBRE_CAMPO").ToString.Trim
                        oDrVw.Cells(7).Value = .Rows(intCont).Item("NUM_SEC").ToString.Trim
                        oDrVw.Cells(8).Value = .Rows(intCont).Item("TIPO").ToString.Trim
                        oDrVw.Cells(9).Value = .Rows(intCont).Item("FORMATO_COLUMN").ToString.Trim
                        oDrVw.Cells(10).Value = .Rows(intCont).Item("ESTADO").ToString.Trim


                    Else
                        oDrVw.Cells(0).Value = False
                        oDrVw.Cells(1).Value = .Rows(intCont).Item("CODIGO").ToString.Trim
                        oDrVw.Cells(2).Value = .Rows(intCont).Item("COMPANIA").ToString.Trim
                        oDrVw.Cells(3).Value = .Rows(intCont).Item("COD_DIVISION").ToString.Trim
                        oDrVw.Cells(4).Value = .Rows(intCont).Item("COD_CLIENTE").ToString.Trim
                        oDrVw.Cells(5).Value = .Rows(intCont).Item("TITULO").ToString.Trim
                        oDrVw.Cells(6).Value = .Rows(intCont).Item("NOMBRE_CAMPO").ToString.Trim
                        oDrVw.Cells(7).Value = .Rows(intCont).Item("NUM_SEC").ToString.Trim
                        oDrVw.Cells(8).Value = .Rows(intCont).Item("TIPO").ToString.Trim
                        oDrVw.Cells(9).Value = .Rows(intCont).Item("FORMATO_COLUMN").ToString.Trim
                        oDrVw.Cells(10).Value = .Rows(intCont).Item("ESTADO").ToString.Trim


                    End If




                    Me.dtgAsigColumna.Rows.Add(oDrVw)
                Next intCont
                dtgAsigColumna.Columns(2).Visible = False
                dtgAsigColumna.Columns(3).Visible = False
                dtgAsigColumna.Columns(4).Visible = False
                dtgAsigColumna.Columns(7).Visible = False
                dtgAsigColumna.Columns(8).Visible = False
                dtgAsigColumna.Columns(9).Visible = False


            End If
        End With

    End Sub


    Private Sub cmbCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.Load
        Crear_Grilla_Documentos()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.cmbCliente.pCodigo = 0 Then
            HelpUtil.MsgBox("Debe de seleccionar un cliente")
            Exit Sub
        End If
        ' Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Buscar_Items()
        Crear_Arbol()
    End Sub


    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        Me.dtgAsigColumna.EndEdit()
        For intCont = 0 To Me.dtgAsigColumna.Rows.Count - 1
            If dtgAsigColumna.Rows(intCont).Cells(0).Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ActualizarEstado()
        Dim intCont As Integer
        For intCont = 0 To dtgAsigColumna.Rows.Count - 1
            Me.dtgAsigColumna.EndEdit()
            If dtgAsigColumna.Rows(intCont).Cells(0).Value = True Then
                oTableros.Actualizar_Estado_ItemB(dtgAsigColumna.Rows(intCont).Cells(1).Value.ToString.Trim, "A")
            Else
                oTableros.Actualizar_Estado_ItemB(dtgAsigColumna.Rows(intCont).Cells(1).Value.ToString.Trim, "*")
            End If
        Next intCont
        Buscar_Items()
    End Sub


    Private Sub btnActualizarEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarEmbarque.Click
        ActualizarEstado()
        Crear_Arbol()
    End Sub

    Private Sub dtgAsigColumna_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgAsigColumna.CellClick

    End Sub

    Private Sub KryptonPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonPanel.Paint

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Try
            Dim dat As String = tvwCheckPoint.SelectedNode.ToString
            Select Case dat

                Case "TreeNode: Tablas"
                    ContextMenuStrip1.Items(0).Enabled = False
                    ContextMenuStrip1.Items(1).Enabled = False

                    Exit Select
                Case "TreeNode: Columnas"
                    ContextMenuStrip1.Items(0).Enabled = False
                    ContextMenuStrip1.Items(1).Enabled = False

                    Exit Select
                Case Else
                    ContextMenuStrip1.Items(0).Enabled = True
                    ContextMenuStrip1.Items(1).Enabled = True

                    Exit Select
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ValidarArbol(ByVal Arbol() As String, ByVal acutal As Integer)
        Dim intCont As Integer
        For intCont = 0 To Arbol.Length - 2
            If (Arbol(intCont).ToString = acutal.ToString.Trim) Then
                If (intCont <> 0 And intCont <> Arbol.Length - 2) Then
                    Arriba = Arbol(intCont - 1).ToString
                    Abanjo = Arbol(intCont + 1).ToString
                End If

                If (intCont = 0) Then
                    Abanjo = Arbol(intCont + 1).ToString
                    Arriba = "0"
                End If

                If (intCont = Arbol.Length - 2) Then
                    Arriba = Arbol(intCont - 1).ToString
                    Abanjo = "0"
                End If

            End If

        Next
    End Sub

    Private Sub RecorrerArbol(ByVal acutal As Integer)
        Dim intCont As Integer
        Dim oDt As DataTable


        oDt = oTableros.Listar_Detalle_Asignacion_ItemB(cmbCliente.pCodigo.ToString.Trim, cmbTipoReporte.SelectedValue.ToString())
        Dim Arbol(oDt.Rows.Count) As String
        With oDt
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To .Rows.Count - 1
                    Arbol(intCont) = .Rows(intCont).Item("NUM_SEC").ToString.Trim
                Next intCont
                ValidarArbol(Arbol, acutal)
            End If
        End With
    End Sub

    Private Sub ArribaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArribaToolStripMenuItem.Click
        Try
            Dim dat As Integer = CInt(tvwCheckPoint.SelectedNode.Name)
            RecorrerArbol(dat)
            Abanjo = "0"
            oTableros.Actualizar_Secuencia_ItemB(cmbCliente.pCodigo.ToString.Trim, cmbTipoReporte.SelectedValue.ToString(), dat, Arriba, Abanjo)
            Crear_Arbol()

            Dim tvn() As TreeNode = tvwCheckPoint.Nodes.Find(Arriba, True)
            If tvn IsNot Nothing AndAlso tvn.Length > 0 Then
                tvwCheckPoint.SelectedNode = tvn(0)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AbajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbajoToolStripMenuItem.Click

        Try
            Dim dat As Integer = CInt(tvwCheckPoint.SelectedNode.Name)
            RecorrerArbol(dat)
            Arriba = "0"
            oTableros.Actualizar_Secuencia_ItemB(cmbCliente.pCodigo.ToString.Trim, cmbTipoReporte.SelectedValue.ToString(), dat, Arriba, Abanjo)
            Crear_Arbol()
            Dim tvn() As TreeNode = tvwCheckPoint.Nodes.Find(Abanjo, True)
            If tvn IsNot Nothing AndAlso tvn.Length > 0 Then
                tvwCheckPoint.SelectedNode = tvn(0)
            End If
            'tvwCheckPoint.SelectedNode.IsSelected


        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCliente_InformationChanged() Handles cmbCliente.InformationChanged
        If Me.cmbCliente.pCodigo = 0 Then
            HelpUtil.MsgBox("Debe de seleccionar un cliente")
            Exit Sub
        End If
        Buscar_Items()
        Crear_Arbol()
    End Sub
End Class

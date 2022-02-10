Imports System.Windows.Forms
Imports Ransa.Utilitario
Imports System.Drawing.Drawing2D
Imports System.Drawing


Public Class ucAplicacionBusq
#Region "Ver Botones"
    Public Event EventChanged()
    Public Event pSelectionFilaAplicacionChanged()
    Public Event pBuscarAplicacion()
    Public Event pMostrarMenu()
    Private _pnumReg As Int64 = 0
    Public Property pnumReg() As Int64
        Get
            Return _pnumReg
        End Get
        Set(ByVal value As Int64)
            _pnumReg = value
        End Set
    End Property

    Private _pInfo_MMCAPL_CodApl As String = ""
    Public Property pInfo_MMCAPL_CodApl() As String
        Get
            Return _pInfo_MMCAPL_CodApl
        End Get
        Set(ByVal value As String)
            _pInfo_MMCAPL_CodApl = value
        End Set
    End Property


    Public Property pVerBotonNuevo() As Boolean
        Get
            Return btnNuevo.Visible
        End Get
        Set(ByVal value As Boolean)
            btnNuevo.Visible = value
        End Set
    End Property
    Public Property pVerBotonModificar() As Boolean
        Get
            Return btnModificar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnModificar.Visible = value
        End Set
    End Property
    Public Property pVerBotonEliminar() As Boolean
        Get
            Return btnEliminar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnEliminar.Visible = value
        End Set
    End Property

    Public Property pVerBotonExportar() As Boolean
        Get
            Return btnExportar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnExportar.Visible = value
        End Set
    End Property


    Public Property pVerBotonMenu() As Boolean
        Get
            Return btnMenu.Visible
        End Get
        Set(ByVal value As Boolean)
            btnMenu.Visible = value
        End Set
    End Property
    Public Property pVerBotonBuscar() As Boolean
        Get
            Return btnBuscar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnBuscar.Visible = value
        End Set
    End Property
#End Region


  Private Sub Exportar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

    Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
      Dim dtExport As New DataTable
      Dim ColName As String = ""
      Dim MdataColumna As String = ""

      Dim TableName As String = ""
      Dim ColTitle As String = ""
      Dim TipoDato As String = ""

      For Each Item As DataGridViewColumn In dgvAplicaciones.Columns
        ColTitle = Item.HeaderText.Trim
        ColName = Item.Name
        TipoDato = ""
        If Item.Visible = True Then
          If ColName.Contains("MENUS") Or ColName.Contains("OPCION") Or ColName.Contains("USUARIOS") Then
                        TipoDato = NPOI_SC.keyDatoNumero
          Else
                        TipoDato = NPOI_SC.keyDatoTexto
          End If
          dtExport.Columns.Add(ColName)
                    MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
          dtExport.Columns(ColName).Caption = MdataColumna
        End If
      Next

      Dim dr As DataRow
      For Fila As Integer = 0 To dgvAplicaciones.Rows.Count - 1
        dr = dtExport.NewRow
        For Columna As Integer = 0 To dtExport.Columns.Count - 1
          ColName = dtExport.Columns(Columna).ColumnName
          If (dgvAplicaciones.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
            dr(ColName) = dgvAplicaciones.Rows(Fila).Cells(ColName).Value
          End If
        Next
        dtExport.Rows.Add(dr)
      Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")
            'Dim Titulo As String = "LISTADO DE APLICACIONES"

            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, Titulo, Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExport.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTADO DE APLICACIONES")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub


  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Dim objFrmManAplicacion As New FrmManAplicacion
    Try
      objFrmManAplicacion.pEstado = FrmManAplicacion.Estado.Nuevo
      If objFrmManAplicacion.ShowDialog = DialogResult.OK Then
        RaiseEvent EventChanged()
        RaiseEvent pBuscarAplicacion()
      End If
      objFrmManAplicacion.Dispose()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    Dim objFrmManAplicacion As New FrmManAplicacion
    Try
      If dgvAplicaciones.CurrentRow IsNot Nothing And dgvAplicaciones.Rows.Count > 0 Then
        Dim lint_indice As Integer = Me.dgvAplicaciones.CurrentCellAddress.Y
        objFrmManAplicacion.pbeAplicacion.PSMMCAPL_CodApl = Me.dgvAplicaciones.Item("MMCAPL", lint_indice).Value.ToString.Trim
        objFrmManAplicacion.pbeAplicacion.PSMMDAPL_DesApl = Me.dgvAplicaciones.Item("MMDAPL", lint_indice).Value.ToString.Trim
        objFrmManAplicacion.pEstado = FrmManAplicacion.Estado.Modificar
        If objFrmManAplicacion.ShowDialog() = DialogResult.OK Then
          RaiseEvent EventChanged()
          RaiseEvent pBuscarAplicacion()
        End If
        objFrmManAplicacion.Dispose()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Try
      Dim oclsAplicacion_DAL As New clsAplicacion_DAL
      Dim obeAplicacion As New beAplicacion
      If dgvAplicaciones.CurrentRow IsNot Nothing And dgvAplicaciones.Rows.Count > 0 Then
        Dim lint_indice As Integer = Me.dgvAplicaciones.CurrentCellAddress.Y
        obeAplicacion.PSMMCAPL_CodApl = Me.dgvAplicaciones.Item("MMCAPL", lint_indice).Value.ToString.Trim()
        If MessageBox.Show("¿Está seguro de eliminar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
          If oclsAplicacion_DAL.Eliminar_Aplicaciones(obeAplicacion) = 1 Then
            RaiseEvent EventChanged()
            RaiseEvent pBuscarAplicacion()
          Else
            MessageBox.Show("La aplicación contiene menús", "Información: No eliminó", MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub pActualizarDatos(ByVal obeAplicacion As beAplicacion)
    dgvAplicaciones.AutoGenerateColumns = False
    dgvAplicaciones.DataSource = Nothing
    Dim oclsAplicacion_DAL As New clsAplicacion_DAL
    Dim dt As New DataTable
    obeAplicacion.PSMMCAPL_CodApl = obeAplicacion.PSMMCAPL_CodApl
    obeAplicacion.PSMMDAPL_DesApl = obeAplicacion.PSMMDAPL_DesApl.ToUpper
    dt = oclsAplicacion_DAL.Listar_Aplicaciones(obeAplicacion)
    dgvAplicaciones.DataSource = dt
    _pnumReg = dgvAplicaciones.Rows.Count

  End Sub

  Public Sub pActualizarDatosNothing()
    dgvAplicaciones.DataSource = Nothing
  End Sub

  Private Sub dgvAplicaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvAplicaciones.SelectionChanged
    Try
      _pInfo_MMCAPL_CodApl = ""
      If dgvAplicaciones.CurrentRow IsNot Nothing Then
        _pInfo_MMCAPL_CodApl = ("" & Me.dgvAplicaciones.CurrentRow.Cells("MMCAPL").Value).ToString.Trim
        RaiseEvent pSelectionFilaAplicacionChanged()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      RaiseEvent pBuscarAplicacion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  'Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
  '    Try
  '        If dgvAplicaciones.CurrentRow IsNot Nothing Then
  '            Dim oFrmMenu As New FrmPrueba
  '            oFrmMenu.MdiParent = Me.ParentForm.ParentForm
  '            oFrmMenu.Show()
  '        End If
  '    Catch ex As Exception
  '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
  '    End Try

  'End Sub

  Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
    Try
      If dgvAplicaciones.CurrentRow IsNot Nothing Then
        RaiseEvent pMostrarMenu()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    'Private Sub Graficar_Aplicaciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvAplicaciones.CellFormatting
    '  Try

    '    ' Grafico menús
    '    If e.ColumnIndex = 2 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(180, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then
    '        Dim rec As New Rectangle(50, 5, e.Value, 10)
    '        Dim deg As New LinearGradientBrush(rec, Color.Aqua, Color.Blue, LinearGradientMode.BackwardDiagonal)
    '        grafico.FillRectangle(deg, rec)
    '      End If
    '      e.Value = bmp
    '    End If

    '    ' Grafico opciones
    '    If e.ColumnIndex = 3 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(250, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then
    '        Dim rec As New Rectangle(50, 5, Math.Round(e.Value * 0.51, 0), 10)
    '        Dim deg As New LinearGradientBrush(rec, Color.Aqua, Color.Blue, LinearGradientMode.BackwardDiagonal)
    '        grafico.FillRectangle(deg, rec)
    '      End If
    '      e.Value = bmp
    '    End If

    '    'Grafico usuarios
    '    If e.ColumnIndex = 4 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(300, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then

    '        If e.Value > 35 Then
    '          Dim rec As New Rectangle(50, 5, Math.Round(e.Value * 0.028, 0), 10)
    '          Dim deg As New LinearGradientBrush(rec, Color.Aqua, Color.Blue, LinearGradientMode.BackwardDiagonal)
    '          grafico.FillRectangle(deg, rec)
    '        Else
    '          Dim rec As New Rectangle(50, 5, 1, 10)
    '          Dim deg As New LinearGradientBrush(rec, Color.Aqua, Color.Blue, LinearGradientMode.BackwardDiagonal)
    '          grafico.FillRectangle(deg, rec)
    '        End If
    '      End If
    '      e.Value = bmp
    '    End If
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try

    'End Sub
End Class

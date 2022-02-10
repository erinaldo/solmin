Imports System.Windows.Forms
Imports Ransa.Utilitario
Imports System.Drawing.Drawing2D
Imports System.Drawing

Public Class ucMenuBusq
    'Public Event EventChanged()
    Public Event pSelectionMenuChanged()
    Public Event pBuscar()
    Private _pnumReg As Int64 = 0
    Public Event pMostrarOpcion()
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

    Private _pInfo_MMCMNU_CodMenu As String = ""
    Public Property pInfo_MMCMNU_CodMenu() As String
        Get
            Return _pInfo_MMCMNU_CodMenu
        End Get
        Set(ByVal value As String)
            _pInfo_MMCMNU_CodMenu = value
        End Set
    End Property

#Region "Ver Botones"
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

    Public Property pVerBotonOpcion() As Boolean
        Get
            Return btnOpcion.Visible
        End Get
        Set(ByVal value As Boolean)
            btnOpcion.Visible = value
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

      For Each Item As DataGridViewColumn In dgvMenus.Columns
        ColTitle = Item.HeaderText.Trim
        ColName = Item.Name
        TipoDato = ""
        If Item.Visible = True Then
          If ColName.Contains("OPCION") Or ColName.Contains("USUARIOS") Then
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
      For Fila As Integer = 0 To dgvMenus.Rows.Count - 1
        dr = dtExport.NewRow
        For Columna As Integer = 0 To dtExport.Columns.Count - 1
          ColName = dtExport.Columns(Columna).ColumnName
          If (dgvMenus.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
            dr(ColName) = dgvMenus.Rows(Fila).Cells(ColName).Value
          End If
        Next
        dtExport.Rows.Add(dr)
      Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")
            'Dim Titulo As String = "LISTADO DE MENUS POR APLICACIÓN"

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
            ListTitulo.Add("LISTADO DE MENUS POR APLICACIÓN")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim oFrmMantenimientoMenus As New FrmManMenu
    Try
      If _pInfo_MMCAPL_CodApl <> "" Then
        oFrmMantenimientoMenus.pbeMenu.PSMMCAPL_CodApl = _pInfo_MMCAPL_CodApl
        oFrmMantenimientoMenus.pEstado = FrmManMenu.Estado.Nuevo
        If oFrmMantenimientoMenus.ShowDialog() = DialogResult.OK Then
                    'RaiseEvent EventChanged()
          RaiseEvent pBuscar()
        End If
      End If
      oFrmMantenimientoMenus.Dispose()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim OFrmMantenimientoMenus As New FrmManMenu
        Try
            If dgvMenus.CurrentRow IsNot Nothing And dgvMenus.Rows.Count > 0 Then
                Dim lint_indice As Integer = Me.dgvMenus.CurrentCellAddress.Y
                OFrmMantenimientoMenus.pbeMenu.PSMMCAPL_CodApl = ("" & dgvMenus.Item("MMCAPL", lint_indice).Value).ToString.Trim
                OFrmMantenimientoMenus.pbeMenu.PSMMCMNU_CodMnu = ("" & dgvMenus.Item("MMCMNU", lint_indice).Value).ToString.Trim
                OFrmMantenimientoMenus.pbeMenu.PSMMTMNU_DesMnu = ("" & dgvMenus.Item("MMTMNU", lint_indice).Value).ToString.Trim
                OFrmMantenimientoMenus.pEstado = FrmManMenu.Estado.Modificar
                If OFrmMantenimientoMenus.ShowDialog() = DialogResult.OK Then
                    'RaiseEvent EventChanged()
          RaiseEvent pBuscar()
                End If
                OFrmMantenimientoMenus.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim oclsMenu_DAL As New clsMenu_DAL
            Dim obeMenu As New beMenu
            If dgvMenus.Rows.Count > 0 Then
                If dgvMenus.CurrentRow IsNot Nothing Then
                    Dim lint_indice As Integer = Me.dgvMenus.CurrentCellAddress.Y
                    obeMenu.PSMMCMNU_CodMnu = Me.dgvMenus.Item("MMCMNU", lint_indice).Value.ToString.Trim()
                    obeMenu.PSMMCAPL_CodApl = Me.dgvMenus.Item("MMCAPL", lint_indice).Value.ToString.Trim()
                    If MessageBox.Show("¿Está seguro de eliminar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If oclsMenu_DAL.Eliminar_Menus(obeMenu) = 1 Then
                            'RaiseEvent EventChanged()
              RaiseEvent pBuscar()
                        Else
              MessageBox.Show("El menú contiene formularios", "Información: No eliminó", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub pActualizarDatos(ByVal obeMenu As beMenu)
        dgvMenus.AutoGenerateColumns = False
        dgvMenus.DataSource = Nothing
        Dim dt As New DataTable
        Dim oclsMenu_DAL As New clsMenu_DAL
        dt = oclsMenu_DAL.Listar_MenuXAplicacion(obeMenu)
        dgvMenus.DataSource = dt
        _pnumReg = dgvMenus.Rows.Count
    End Sub

    Public Sub pActualizarDatosNothing()
        dgvMenus.DataSource = Nothing
    End Sub

  Private Sub dgvMenus_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMenus.SelectionChanged
    Try
      If dgvMenus.CurrentRow IsNot Nothing Then
        _pInfo_MMCAPL_CodApl = ("" & dgvMenus.CurrentRow.Cells("MMCAPL").Value).ToString.Trim
        _pInfo_MMCMNU_CodMenu = ("" & dgvMenus.CurrentRow.Cells("MMCMNU").Value).ToString.Trim
        RaiseEvent pSelectionMenuChanged()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
    Try
      If dgvMenus.CurrentRow IsNot Nothing Then
        RaiseEvent pMostrarOpcion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnBuscarMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      RaiseEvent pBuscar()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    'Private Sub Graficar_Menu(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMenus.CellFormatting

    '  Try

    '    ' Grafico opciones
    '    If e.ColumnIndex = 4 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(250, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then
    '        Dim rec As New Rectangle(50, 5, e.Value * 3, 10)
    '        Dim deg As New LinearGradientBrush(rec, Color.GreenYellow, Color.Green, LinearGradientMode.BackwardDiagonal)
    '        grafico.FillRectangle(deg, rec)
    '      End If
    '      e.Value = bmp
    '    End If

    '    ' Grafico usuarios
    '    If e.ColumnIndex = 5 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(300, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then
    '        If e.Value > 2 Then
    '          Dim rec As New Rectangle(50, 5, Math.Round(e.Value * 0.33, 0), 10)
    '          Dim deg As New LinearGradientBrush(rec, Color.GreenYellow, Color.Green, LinearGradientMode.BackwardDiagonal)
    '          grafico.FillRectangle(deg, rec)
    '        Else
    '          Dim rec As New Rectangle(50, 5, 1, 10)
    '          Dim deg As New LinearGradientBrush(rec, Color.GreenYellow, Color.Green, LinearGradientMode.BackwardDiagonal)
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

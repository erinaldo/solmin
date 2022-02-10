Imports System.Windows.Forms
Imports Ransa.Utilitario
Imports System.Text
Imports System.Drawing.Drawing2D
Imports System.Drawing

Public Class ucOpcionBusq
    Public Event pSelectionOpcionChanged()
    Public Event pBuscar()
    'Public Event EventChanged()

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

    Private _pInfo_MMCOPC_CodOpc As Decimal = 0
    Public Property pInfo_MMCOPC_CodOpc() As Decimal
        Get
            Return _pInfo_MMCOPC_CodOpc
        End Get
        Set(ByVal value As Decimal)
            _pInfo_MMCOPC_CodOpc = value
        End Set
  End Property


  Private _pInfo_MMDAPL As String = ""
  Public Property pInfo_MMDAPL() As String
    Get
      Return _pInfo_MMDAPL
    End Get
    Set(ByVal value As String)
      _pInfo_MMDAPL = value
    End Set
  End Property

  Private _pInfo_MMTMNU As String = ""
  Public Property pInfo_MMTMNU() As String
    Get
      Return _pInfo_MMTMNU
    End Get
    Set(ByVal value As String)
      _pInfo_MMTMNU = value
    End Set
  End Property

  Private _pInfo_MMDOPC As String = 0
  Public Property pInfo_MMDOPC() As String
    Get
      Return _pInfo_MMDOPC
    End Get
    Set(ByVal value As String)
      _pInfo_MMDOPC = value
    End Set
  End Property

    Private _pnumReg As Int64 = 0

    Public Property pnumReg() As Int64
        Get
            Return _pnumReg
        End Get
        Set(ByVal value As Int64)
            _pnumReg = value
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

    'Public Property pVerBotonExportar() As Boolean
    '    Get
    '        Return btnExportar.Visible
    '    End Get
    '    Set(ByVal value As Boolean)
    '        btnExportar.Visible = value
    '    End Set
    'End Property

    Public Property pVerBotonBuscar() As Boolean
        Get
            Return btnBuscar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnBuscar.Visible = value
        End Set
    End Property
   
#End Region

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Try
      If _pInfo_MMCAPL_CodApl <> "" AndAlso _pInfo_MMCMNU_CodMenu <> "" Then
        Dim oFrmMantenimientoOpciones As New FrmManOpcion
        oFrmMantenimientoOpciones.pEstado = FrmManOpcion.Estado.Nuevo
        oFrmMantenimientoOpciones.pbeOpcion.PSMMCAPL_CodApl = _pInfo_MMCAPL_CodApl
        oFrmMantenimientoOpciones.pbeOpcion.PSMMCMNU_CodMnu = _pInfo_MMCMNU_CodMenu
        If oFrmMantenimientoOpciones.ShowDialog() = DialogResult.OK Then
                    'RaiseEvent EventChanged()
          RaiseEvent pBuscar()
        End If
        oFrmMantenimientoOpciones.Dispose()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim oFrmMantenimientoOpciones As New FrmManOpcion
      If dgvOpciones.Rows.Count > 0 AndAlso dgvOpciones.CurrentRow IsNot Nothing Then
        Dim lint_indice As Integer = Me.dgvOpciones.CurrentCellAddress.Y
        oFrmMantenimientoOpciones.pbeOpcion.PSMMCAPL_CodApl = dgvOpciones.Item("MMCAPL", lint_indice).Value.ToString
        oFrmMantenimientoOpciones.pbeOpcion.PSMMCMNU_CodMnu = dgvOpciones.Item("MMCMNU", lint_indice).Value.ToString
        oFrmMantenimientoOpciones.pbeOpcion.PNMMCOPC_CodOpc = dgvOpciones.Item("MMCOPC", lint_indice).Value
        oFrmMantenimientoOpciones.pbeOpcion.PSMMNPVB = ("" & dgvOpciones.Item("MMNPVB", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSMMDOPC_DesOpc = ("" & dgvOpciones.Item("MMDOPC", lint_indice).Value).ToString.Trim()

        oFrmMantenimientoOpciones.pbeOpcion.PSMMCAIN = ("" & dgvOpciones.Item("MMCAIN", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSMMCMIN = ("" & dgvOpciones.Item("MMCMIN", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSMMTOPC = ("" & dgvOpciones.Item("MMTOPC", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSMMTVAR = ("" & dgvOpciones.Item("MMTVAR", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSMMNPRO = ("" & dgvOpciones.Item("MMNPRO", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSMMNFUN = ("" & dgvOpciones.Item("MMNFUN", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSMMNPGM = ("" & dgvOpciones.Item("MMNPGM", lint_indice).Value).ToString.Trim()
        oFrmMantenimientoOpciones.pbeOpcion.PSURLIMG = ("" & dgvOpciones.Item("URLIMG", lint_indice).Value).ToString.Trim()


        oFrmMantenimientoOpciones.pEstado = FrmManOpcion.Estado.Modificar
        If oFrmMantenimientoOpciones.ShowDialog() = DialogResult.OK Then
                    'RaiseEvent EventChanged()
          RaiseEvent pBuscar()
        End If
      End If
      oFrmMantenimientoOpciones.Dispose()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim oclsOpcion_DAL As New clsOpcion_DAL
            Dim obeOpcion As New beOpcion
            If dgvOpciones.Rows.Count > 0 Then
                If dgvOpciones.CurrentRow IsNot Nothing Then
                    Dim lint_indice As Integer = Me.dgvOpciones.CurrentCellAddress.Y
          obeOpcion.PNMMCOPC_CodOpc = Me.dgvOpciones.Item("MMCOPC", lint_indice).Value
          obeOpcion.PSMMCAPL_CodApl = ("" & Me.dgvOpciones.Item("MMCAPL", lint_indice).Value).ToString.Trim()
          obeOpcion.PSMMCMNU_CodMnu = ("" & Me.dgvOpciones.Item("MMCMNU", lint_indice).Value).ToString.Trim()
                End If
                If MessageBox.Show("¿Está seguro de eliminar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
          If oclsOpcion_DAL.Eliminar_Opciones(obeOpcion) = 1 Then
                        'RaiseEvent EventChanged()
            RaiseEvent pBuscar()
          End If
          If oclsOpcion_DAL.Eliminar_Opciones(obeOpcion) = 0 Then
            MessageBox.Show("La opción contiene usuarios", "Información: No eliminó", MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub pActualizarDatos(ByVal obeOpcion As beOpcion)
        dgvOpciones.AutoGenerateColumns = False
        dgvOpciones.DataSource = Nothing
        Dim oclsOpcion_DAL As New clsOpcion_DAL
        Dim dt As New DataTable
        dt = oclsOpcion_DAL.Listar_MenuOpcion(obeOpcion)
        dgvOpciones.DataSource = dt
        _pnumReg = dgvOpciones.Rows.Count
    End Sub

    Public Sub pActualizarDatosNothing()
        dgvOpciones.DataSource = Nothing
    End Sub
 
  Private Sub dgvOpciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOpciones.SelectionChanged
    Try
      If dgvOpciones.CurrentRow IsNot Nothing Then
        _pInfo_MMCAPL_CodApl = ("" & dgvOpciones.CurrentRow.Cells("MMCAPL").Value).ToString.Trim
        _pInfo_MMCMNU_CodMenu = ("" & dgvOpciones.CurrentRow.Cells("MMCMNU").Value).ToString.Trim
        _pInfo_MMCOPC_CodOpc = Me.dgvOpciones.CurrentRow.Cells("MMCOPC").Value

        _pInfo_MMDOPC = String.Format("{0} - {1}", _pInfo_MMCOPC_CodOpc, ("" & dgvOpciones.CurrentRow.Cells("MMDOPC").Value).ToString.Trim)
        _pInfo_MMTMNU = ("" & dgvOpciones.CurrentRow.Cells("MMTMNU").Value).ToString.Trim
        _pInfo_MMDAPL = ("" & dgvOpciones.CurrentRow.Cells("MMDAPL").Value).ToString.Trim
        RaiseEvent pSelectionOpcionChanged()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      RaiseEvent pBuscar()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

   
    'Private Sub Graficar_Opciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvOpciones.CellFormatting

    '  Try
    '          If e.ColumnIndex = 10 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '              Dim bmp As New Bitmap(300, 20)
    '              Dim grafico As Graphics = Graphics.FromImage(bmp)
    '              grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '              If e.Value > 0 Then
    '                  Dim rec As New Rectangle(50, 5, e.Value * 4, 10)
    '                  Dim deg As New LinearGradientBrush(rec, Color.Yellow, Color.OrangeRed, LinearGradientMode.BackwardDiagonal)
    '                  grafico.FillRectangle(deg, rec)
    '              End If
    '              e.Value = bmp
    '          End If
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try

    'End Sub

    Private Sub btnExportOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportOpcion.Click
        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            For Each Item As DataGridViewColumn In dgvOpciones.Columns
                ColTitle = Item.HeaderText.Trim
                ColName = Item.Name
                TipoDato = ""
                If Item.Visible = True Then
                    If ColName.Contains("USUARIOS") Then
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
            For Fila As Integer = 0 To dgvOpciones.Rows.Count - 1
                dr = dtExport.NewRow
                For Columna As Integer = 0 To dtExport.Columns.Count - 1
                    ColName = dtExport.Columns(Columna).ColumnName
                    If (dgvOpciones.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                        dr(ColName) = dgvOpciones.Rows(Fila).Cells(ColName).Value
                    End If
                Next
                dtExport.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")
            'Dim Titulo As String = "LISTADO DE OPCIONES POR MENÚ"

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
            ListTitulo.Add( "LISTADO DE OPCIONES POR MENÚ")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportUsuarioOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportUsuarioOpcion.Click
        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim ColName As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            Dim dtUsuarioxOpcion As New DataTable

            TipoDato = NPOI_SC.keyDatoTexto
            MdataColumna = NPOI_SC.FormatDato("OPCION MENU", TipoDato)
            dtUsuarioxOpcion.Columns.Add("OPCION").Caption = MdataColumna

            TipoDato = NPOI_SC.keyDatoTexto
            MdataColumna = NPOI_SC.FormatDato("Nro", TipoDato, NPOI_SC.keyAlinHCentro)
            dtUsuarioxOpcion.Columns.Add("ITEM").Caption = MdataColumna

            TipoDato = NPOI_SC.keyDatoTexto
            MdataColumna = NPOI_SC.FormatDato("USUARIO", TipoDato)
            dtUsuarioxOpcion.Columns.Add("MMCUSR").Caption = MdataColumna

            TipoDato = NPOI_SC.keyDatoTexto
            MdataColumna = NPOI_SC.FormatDato("NOMBRE", TipoDato)
            dtUsuarioxOpcion.Columns.Add("MMNUSR").Caption = MdataColumna

            Dim oclsUsuario_DAL As New clsUsuario_DAL
            Dim dtTemp As New DataTable
            Dim sb As New StringBuilder
            Dim LisOPcn As String = ""

            For Each Item As DataGridViewRow In dgvOpciones.Rows
                sb.Append(Item.Cells("MMCOPC").Value)
                sb.Append(",")
            Next
            LisOPcn = sb.ToString
            LisOPcn = LisOPcn.Substring(0, LisOPcn.Length - 1)
            dtTemp = oclsUsuario_DAL.Listar_Usuario_x_Opcion_Export(_pInfo_MMCAPL_CodApl, _pInfo_MMCMNU_CodMenu, LisOPcn)

            Dim dr As DataRow
            Dim NumUsuario As Int32 = 0
            Dim CodUnico As String = ""
            Dim ListVisit As New List(Of String)

            For Fila As Integer = 0 To dtTemp.Rows.Count - 1
                dr = dtUsuarioxOpcion.NewRow
                CodUnico = dtTemp.Rows(Fila)("MMCAPL") & "_" & dtTemp.Rows(Fila)("MMCMNU") & "_" & dtTemp.Rows(Fila)("MMCOPC")
                If Not ListVisit.Contains(CodUnico) Then
                    ListVisit.Add(CodUnico)
                    NumUsuario = 0
                End If
                dr("OPCION") = dtTemp.Rows(Fila)("DES_OPCN")
                NumUsuario = NumUsuario + 1
                dr("ITEM") = NumUsuario
                dr("MMCUSR") = dtTemp.Rows(Fila)("MMCUSR")
                dr("MMNUSR") = dtTemp.Rows(Fila)("MMNUSR")

                dtUsuarioxOpcion.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "APLICACION:|" & _pInfo_MMDAPL
            'oLisParametros(1) = "MENU:|" & _pInfo_MMTMNU
            'oLisParametros(3) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(4) = "Hora:|" & Now.ToString("hh:mm:ss")

            'dtUsuarioxOpcion.TableName = "USUARIO POR OPCION"
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtUsuarioxOpcion, "LISTADO USUARIOS POR OPCION", Nothing, oLisParametros, "OPCION")


            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtUsuarioxOpcion.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "APLICACION:|" & _pInfo_MMDAPL)
            itemSortedList.Add(itemSortedList.Count, "MENU:|" & _pInfo_MMTMNU)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTADO USUARIOS POR OPCION")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

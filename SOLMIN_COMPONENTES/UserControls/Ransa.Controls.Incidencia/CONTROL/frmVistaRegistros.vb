Imports Ransa.Utilitario
Imports System.Windows.Forms

Public Class frmVistaRegistros

    Private _pCompania As String
    Public Property pCompania() As String
        Get
            Return _pCompania
        End Get
        Set(ByVal value As String)
            _pCompania = value
        End Set
    End Property

    Private _pCompaniades As String
    Public Property pCompaniades() As String
        Get
            Return _pCompaniades
        End Get
        Set(ByVal value As String)
            _pCompaniades = value
        End Set
    End Property

    Private _pAreades As String
    Public Property pAreades() As String
        Get
            Return _pAreades
        End Get
        Set(ByVal value As String)
            _pAreades = value
        End Set
    End Property

    Private _pArea As String
    Public Property pArea() As String
        Get
            Return _pArea
        End Get
        Set(ByVal value As String)
            _pArea = value
        End Set
    End Property

    Private _pFechaInicio As Decimal
    Public Property pFechaInicio() As Decimal
        Get
            Return _pFechaInicio
        End Get
        Set(ByVal value As Decimal)
            _pFechaInicio = value
        End Set
    End Property

    Private _pFechaFin As Decimal
    Public Property pFechaFin() As Decimal
        Get
            Return _pFechaFin
        End Get
        Set(ByVal value As Decimal)
            _pFechaFin = value
        End Set
    End Property

    Private _pCodIncidencia As Decimal
    Public Property pCodIncidencia() As Decimal
        Get
            Return _pCodIncidencia
        End Get
        Set(ByVal value As Decimal)
            _pCodIncidencia = value
        End Set
    End Property

    Private _pIncidenciades As String
    Public Property pIncidenciades() As String
        Get
            Return _pIncidenciades
        End Get
        Set(ByVal value As String)
            _pIncidenciades = value
        End Set
    End Property

    Dim ListaDatatable As List(Of DataTable)
    Dim ListaTitulos As List(Of String)

    Private Sub frmVistaRegistros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim obrIncidencia As New brIncidencias
        Dim obeIncidencias As New beIncidencias
        With obeIncidencias
            .PSCCMPN = _pCompania
            .PSCARINC = _pArea
            .PNCCLNT = 0
            .PNCINCID = _pCodIncidencia
            .PNFECINI = _pFechaInicio
            .PNFECFIN = _pFechaFin
        End With
        dtgIncidencias.AutoGenerateColumns = False

        Dim Lista1 As New List(Of beIncidencias)
        Dim Lista2 As New List(Of beIncidencias)

        Lista1 = obrIncidencia.olisListarRegistroIncidenciasVista(obeIncidencias)

        'For Each inc As beIncidencias In Lista1
        '    If inc.PSSNVINC.Trim.Length > 0 Then
        '        Dim dr As DataRow()
        '        dr = obrIncidencia.Lista_Niveles.Select("SNVINC = '" & inc.PSSNVINC & "'")
        '        inc.PSNIVEL = dr(0).Item("DESCRIPCION").ToString.Trim
        '    End If
        '    If inc.PSSORINC.Trim.Length > 0 Then
        '        Dim dr1 As DataRow()
        '        dr1 = obrIncidencia.Lista_Origenes.Select("SORINC = '" & inc.PSSORINC & "'")
        '        inc.PSORIGEN = dr1(0).Item("DESCRIPCION").ToString.Trim
        '    End If
        '    Lista2.Add(inc)
        'Next
        Me.dtgIncidencias.DataSource = Lista1


        txtIncidencia.Text = txtIncidencia.Text & _pIncidenciades

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        'Try
        '    If Me.dtgIncidencias.Rows.Count = 0 Then Exit Sub
        '    Dim strlTitulo As New List(Of String)
        '    strlTitulo.Add("Compañia: \n " & _pCompaniades)
        '    strlTitulo.Add("División: \n " & _pDivisiondes)
        '    strlTitulo.Add("Incidencia: \n " & _pIncidenciades)
        '    strlTitulo.Add("Fecha : \n " & HelpClass.CNumero8Digitos_a_FechaDefault(_pFechaInicio) & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(_pFechaFin))
        '    HelpClass.ExportExcelConTitulos(Me.dtgIncidencias, "INCIDENCIAS POR MES", strlTitulo)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC


            If Me.dtgIncidencias.Rows.Count = 0 Then Exit Sub

            Dim ListaExcel As List(Of beIncidencias) = Me.dtgIncidencias.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("PNNINCSI", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("Nro. Inc", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSTCMPCL").Caption = NPOI_SC.FormatDato("Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTPLNTA").Caption = NPOI_SC.FormatDato("Planta", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("PNCCLNT", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("Código", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSTRDCCL").Caption = NPOI_SC.FormatDato("Doc. Ref. Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTINCSI").Caption = NPOI_SC.FormatDato("Tipo Incidencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FechaRegistro").Caption = NPOI_SC.FormatDato("Fecha", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HoraRegistro").Caption = NPOI_SC.FormatDato("Hora", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("PSTINCDT").Caption = NPOI_SC.FormatDato("Detalle Incidencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSNIVEL").Caption = NPOI_SC.FormatDato("Nivel", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSREPORTADO").Caption = NPOI_SC.FormatDato("Reportado", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTALMC").Caption = NPOI_SC.FormatDato("Tipo almacén", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTCMPAL").Caption = NPOI_SC.FormatDato("Almacén", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTCMZNA").Caption = NPOI_SC.FormatDato("Zona Ubicación", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTPRVCL").Caption = NPOI_SC.FormatDato("Proveedor/Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PNQAINSM", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSMEDIDA").Caption = NPOI_SC.FormatDato("Unidad Medida", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PNICSTOS", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Importe", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSMONEDA").Caption = NPOI_SC.FormatDato("Moneda", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTIRALC").Caption = NPOI_SC.FormatDato("Responsable", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSPRSCNT").Caption = NPOI_SC.FormatDato("Contacto", NPOI_SC.keyDatoTexto)

            For Each inc As beIncidencias In ListaExcel
                dr = dtExcel.NewRow
                dr("PSTPLNTA") = inc.PSTPLNTA
                'dr("PNCCLNT") = CInt(inc.PNCCLNT)
                dr("PSTCMPCL") = inc.PSTCMPCL
                dr("PSTRDCCL") = inc.PSTRDCCL.Trim
                dr("PNNINCSI") = CInt(inc.PNNINCSI)
                dr("PSTINCSI") = inc.PSTINCSI.Trim
                dr("FechaRegistro") = inc.FechaRegistro
                dr("HoraRegistro") = inc.HoraRegistro
                dr("PSTINCDT") = inc.PSTINCDT.Trim
                dr("PSNIVEL") = inc.PSNIVEL
                dr("PSREPORTADO") = inc.PSREPORTADO
                dr("PSTALMC") = inc.PSTALMC
                dr("PSTCMPAL") = inc.PSTCMPAL
                dr("PSTCMZNA") = inc.PSTCMZNA
                dr("PSTPRVCL") = inc.PSTPRVCL
                dr("PNQAINSM") = inc.PNQAINSM
                dr("PSMEDIDA") = inc.PSMEDIDA.Trim
                dr("PNICSTOS") = inc.PNICSTOS
                dr("PSMONEDA") = inc.PSMONEDA.Trim
                dr("PSTIRALC") = inc.PSTIRALC.Trim
                dr("PSPRSCNT") = inc.PSPRSCNT.Trim
                dtExcel.Rows.Add(dr)
            Next

            ListaDatatable = New List(Of DataTable)
            ListaDatatable.Add(dtExcel.Copy)

            ListaTitulos = New List(Of String)
            ListaTitulos.Add("REGISTRO DE INCIDENCIAS")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & _pCompaniades)
            F.Add(1, "División:|" & _pAreades)
            F.Add(2, "Fecha:| " & HelpClass.CNumero8Digitos_a_FechaDefault(_pFechaInicio) & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(_pFechaFin))
            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("PSTINCDT")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, 0)

            Me.dtgIncidencias.DataSource = Nothing
            Me.dtgIncidencias.DataSource = ListaExcel

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class

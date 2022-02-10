Imports System.Windows.Forms
Imports RANSA.TYPEDEF
Imports Ransa.Utilitario
Imports Ransa.Negocio.UbicacionPlanta
Imports Ransa.TypeDef.UbicacionPlanta

Public Class ucSeguimientoInc

#Region "PROPIEDADES"
    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pCompaniaActual As String = ""
    Public Property pCompaniaActual() As String
        Get
            Return _pCompaniaActual
        End Get
        Set(ByVal value As String)
            _pCompaniaActual = value
        End Set
    End Property

    Private _pNameSystem As String = ""
    Public Property pNameSystem() As String
        Get
            Return _pNameSystem
        End Get
        Set(ByVal value As String)
            _pNameSystem = value
        End Set
    End Property

    Dim ListaDatatable As List(Of DataTable)
    Dim ListaTitulos As List(Of String)
    Dim Lista1 As New List(Of beSeguimiento)
#End Region

    Dim dt As DataTable
    Dim dtNegocio As DataTable
    Dim dtReportado As DataTable

#Region "EVENTOS"

    Private Function Lista_Plantas() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") = cboPlanta.CheckedItems(i).Value) Then
                    If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") <> "0") Then
                        strCadDocumentos += dt.Rows(j).Item("CPLNDV_CodigoPlanta") & ","
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") = cboPlanta.CheckedItems(i).Value) Then
                        strCadDocumentos += dt.Rows(j).Item("CPLNDV_CodigoPlanta") & ","
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        If strCadDocumentos = "" Then
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") <> "0") Then
                    strCadDocumentos += dt.Rows(j).Item("CPLNDV_CodigoPlanta") & ","
                End If
            Next
            If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        End If

        Return strCadDocumentos

    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            PictureBox1.Visible = False
            btnBuscar.Enabled = True

            Me.dtgSeguimiento.DataSource = Nothing
            If chkIncidencia.Checked = True Then
                If txtIncFiltro.Text.Trim = "" Then
                    MessageBox.Show("Debe ingresar Nro de Incidencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            PictureBox1.Visible = True
            btnBuscar.Enabled = False
            BackgroundWorker1.RunWorkerAsync()




        Catch ex As Exception
            PictureBox1.Visible = False
            btnBuscar.Enabled = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Negocio_Descripcion() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
            For j As Integer = 0 To dtNegocio.Rows.Count - 1
                If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = cmbNegocio.CheckedItems(i).Value) Then
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For j As Integer = 0 To dtNegocio.Rows.Count - 1
                If dtNegocio.Rows(j).Item("CRGVTA_Codigo") <> "0" Then
                    strCadDocumentos += dtNegocio.Rows(j).Item("TCRVTA_Descripcion") & " - "
                End If
            Next
        Else
            For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
                For j As Integer = 0 To dtNegocio.Rows.Count - 1
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = cmbNegocio.CheckedItems(i).Value) Then
                        strCadDocumentos += dtNegocio.Rows(j).Item("TCRVTA_Descripcion") & " - "
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos

    End Function
    
   
    Private Function Plantas_Descripcion() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") = cboPlanta.CheckedItems(i).Value) Then
                    If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For j As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(j).Item("CPLNDV_CodigoPlanta") <> "0" Then
                    strCadDocumentos += dt.Rows(j).Item("TPLNTA_DescripcionPlanta") & " - "
                End If
            Next
        Else
            For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CPLNDV_CodigoPlanta") = cboPlanta.CheckedItems(i).Value) Then
                        strCadDocumentos += dt.Rows(j).Item("TPLNTA_DescripcionPlanta") & " - "
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos

    End Function

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try

            If dtgSeguimiento.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC


            If Me.dtgSeguimiento.Rows.Count = 0 Then Exit Sub

            Dim ListaExcel As List(Of beSeguimiento) = Me.dtgSeguimiento.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("PNNINCSI", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("Nro. Inc", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSTCMPCL").Caption = NPOI_SC.FormatDato("Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTPLNTA").Caption = NPOI_SC.FormatDato("Planta", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTCRVTA").Caption = NPOI_SC.FormatDato("Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSESTADO").Caption = NPOI_SC.FormatDato("Estado Inc.", NPOI_SC.keyDatoTexto)

            'dtExcel.Columns.Add("PNCCLNT", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSTRDCCL").Caption = NPOI_SC.FormatDato("Doc. Ref. Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTINCSI").Caption = NPOI_SC.FormatDato("Tipo Incidencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FechaRegistro").Caption = NPOI_SC.FormatDato("Fecha Inc. (1)", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HoraRegistro").Caption = NPOI_SC.FormatDato("Hora Inc.", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("PSTINCDT").Caption = NPOI_SC.FormatDato("Detalle Incidencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSNIVEL").Caption = NPOI_SC.FormatDato("Nivel", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSREPORTADO").Caption = NPOI_SC.FormatDato("Reportado", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("PSTALMC").Caption = NPOI_SC.FormatDato("Tipo almacén", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("PSTCMPAL").Caption = NPOI_SC.FormatDato("Almacén", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("PSTCMZNA").Caption = NPOI_SC.FormatDato("Zona Ubicación", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("PSTPRVCL").Caption = NPOI_SC.FormatDato("Proveedor/Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PNQAINSM", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSMEDIDA").Caption = NPOI_SC.FormatDato("Unidad Medida", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTIRALC").Caption = NPOI_SC.FormatDato("Responsable", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSPRSCNT").Caption = NPOI_SC.FormatDato("Contacto", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("PSADJUNTAR").Caption = NPOI_SC.FormatDato("Adj", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("PSTSOLUC").Caption = NPOI_SC.FormatDato("REVISADO| Tipo de solución", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("PSSACPINC").Caption = NPOI_SC.FormatDato("REVISADO| Efecto", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSSACCINC").Caption = NPOI_SC.FormatDato("REVISADO| Acción", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSSCLINC").Caption = NPOI_SC.FormatDato("REVISADO| Clasificación", NPOI_SC.keyDatoTexto)



            dtExcel.Columns.Add("PSFCHREVISION").Caption = NPOI_SC.FormatDato("REVISADO| Fecha revisión (2)", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("PSHRAREVISION").Caption = NPOI_SC.FormatDato("REVISADO| Hora revisión", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("PSCUSEVI").Caption = NPOI_SC.FormatDato("REVISADO| Asignado a", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSTOBRES").Caption = NPOI_SC.FormatDato("REVISADO| Observación", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("PNICSTOS", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("CONCLUÍDO| Costo", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSMONEDA").Caption = NPOI_SC.FormatDato("CONCLUÍDO| Moneda", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSCASUMIDO").Caption = NPOI_SC.FormatDato("CONCLUÍDO|Costo asumido por", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PNPRCASC", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("CONCLUÍDO| (%) Asumido ", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("PSFCHCONCLUIDO").Caption = NPOI_SC.FormatDato("CONCLUÍDO| Fecha concluído (3)", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("PSHRACONCLUIDO").Caption = NPOI_SC.FormatDato("CONCLUÍDO| Hora concluído", NPOI_SC.keyDatoFecha)

            dtExcel.Columns.Add("PSTOBRES2").Caption = NPOI_SC.FormatDato("CONCLUÍDO| Observación", NPOI_SC.keyDatoTexto)



            dtExcel.Columns.Add("PNFCH_2_1").Caption = NPOI_SC.FormatDato("(2) - (1)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PNFCH_3_2").Caption = NPOI_SC.FormatDato("(3) - (2)", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("PSCUSCRT").Caption = NPOI_SC.FormatDato("Usuario creador", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PSCULUSA").Caption = NPOI_SC.FormatDato("Usuario actualizador", NPOI_SC.keyDatoTexto)

            For Each inc As beSeguimiento In ListaExcel
                dr = dtExcel.NewRow
                dr("PSTPLNTA") = inc.PSTPLNTA
                dr("PSESTADO") = inc.PSESTADO
                'dr("PNCCLNT") = CInt(inc.PNCCLNT)
                dr("PSTCMPCL") = inc.PSTCMPCL
                dr("PSTCRVTA") = inc.PSTCRVTA
                dr("PSTRDCCL") = inc.PSTRDCCL.Trim
                dr("PNNINCSI") = CInt(inc.PNNINCSI)
                dr("PSTINCSI") = inc.PSTINCSI.Trim
                dr("FechaRegistro") = inc.FechaRegistro
                dr("HoraRegistro") = inc.HoraRegistro
                dr("PSTINCDT") = inc.PSTINCDT.Trim
                dr("PSNIVEL") = inc.PSNIVEL
                dr("PSREPORTADO") = inc.PSREPORTADO
                'dr("PSTALMC") = inc.PSTALMC
                'dr("PSTCMPAL") = inc.PSTCMPAL
                'dr("PSTCMZNA") = inc.PSTCMZNA
                'dr("PSTPRVCL") = inc.PSTPRVCL
                dr("PNQAINSM") = inc.PNQAINSM
                dr("PSMEDIDA") = inc.PSMEDIDA.Trim
                'dr("PNICSTOS") = inc.PNICSTOS
                'dr("PSMONEDA") = inc.PSMONEDA.Trim
                dr("PSTIRALC") = inc.PSTIRALC.Trim
                dr("PSPRSCNT") = inc.PSPRSCNT.Trim
                dr("PSADJUNTAR") = inc.PSADJUNTAR
                dr("PSCUSCRT") = inc.PSCUSCRT
                dr("PSCULUSA") = inc.PSCULUSA

                dr("PSTSOLUC") = inc.PSTSOLUC
                dr("PSFCHREVISION") = inc.PSFCHREVISION
                dr("PSHRAREVISION") = inc.PSHRAREVISION
                dr("PSCUSEVI") = inc.PSCUSEVI
                dr("PSTOBRES") = inc.PSTOBRES

                dr("PNICSTOS") = CDec(inc.PNICSTOS)
                dr("PSMONEDA") = inc.PSMONEDA
                dr("PSCASUMIDO") = inc.PSCASUMIDO
                dr("PNPRCASC") = CDec(inc.PNPRCASC)
                dr("PSFCHCONCLUIDO") = inc.PSFCHCONCLUIDO
                dr("PSHRACONCLUIDO") = inc.PSHRACONCLUIDO

                dr("PNFCH_2_1") = inc.PNFCH_2_1
                dr("PNFCH_3_2") = inc.PNFCH_3_2

                dr("PSSACPINC") = inc.PSSACPINC
                dr("PSSACCINC") = inc.PSSACCINC
                dr("PSSCLINC") = inc.PSSCLINC
                dr("PSTOBRES2") = inc.PSTOBRES2

                dtExcel.Rows.Add(dr)
            Next

            ListaDatatable = New List(Of DataTable)
            ListaDatatable.Add(dtExcel.Copy)

            ListaTitulos = New List(Of String)
            ListaTitulos.Add("SEGUIMIENTO DE INCIDENCIAS")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & UcCompania_Cmb011.CCMPN_Descripcion)
            F.Add(1, "Área:|" & cmbArea.Text)

            If Lista_Plantas.ToString.Trim.Length > 5 Then
                F.Add(2, "Planta:| " & "Varios")
            Else
                F.Add(2, "Planta:| " & Plantas_Descripcion())
            End If

            F.Add(3, "Cliente:| " & txtCliente.pRazonSocial)

            F.Add(4, "Inc. Para :| " & cmbIncPara.Text)

            F.Add(5, "Fecha:| " & Me.dteFechaInicial.Value.Date & " - " & Me.dteFechaFinal.Value.Date)
            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("PSTINCDT|PSTOBRES")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, 0)

            Me.dtgSeguimiento.DataSource = Nothing
            Me.dtgSeguimiento.DataSource = ListaExcel

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmIncidenciaPorFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmIncidenciaPorFecha.Click
        Try
            Dim ofrmConsultaIncidenciaPorFecha As New frmConsultaSeguimientoPorFecha
            ofrmConsultaIncidenciaPorFecha.Compania = UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmConsultaIncidenciaPorFecha.pUsuario = _pUsuario
            ofrmConsultaIncidenciaPorFecha.pArea = cmbArea.SelectedValue
            ofrmConsultaIncidenciaPorFecha.CompaniaDes = UcCompania_Cmb011.CCMPN_Descripcion
            ofrmConsultaIncidenciaPorFecha.pIncPara = cmbIncPara.SelectedValue
            ofrmConsultaIncidenciaPorFecha.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Try
            Me.ParentForm.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

#End Region

#Region "METODOS"

    Sub pInicializar()

        UcCompania_Cmb011.Usuario = _pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(_pCompaniaActual)
        'Dim ClientePK As TypeDef.Cliente.TD_ClientePK = New TypeDef.Cliente.TD_ClientePK(0, _pUsuario)
        'txtCliente.
        txtCliente.pAccesoPorUsuario = True
        txtCliente.pRequerido = True
        txtCliente.pUsuario = _pUsuario
        Cargar_Estados()
        Lista_Inc_Para()
        Cargar_Area()
        cmbArea_SelectionChangeCommitted(Nothing, Nothing)
        cargarComboNegocio()
        cargarComboReportado()
        txtIncFiltro.Enabled = False
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub Cargar_Area()

        Dim objBLL As New brIncidencias
        Dim dt As New DataTable

        dt = objBLL.Lista_Areas
        cmbArea.DataSource = dt
        cmbArea.Tag = dt.Copy
        cmbArea.DisplayMember = "TDARINC"
        cmbArea.ValueMember = "CARINC"
        cmbArea.SelectedValue = "S"

    End Sub

    Private Sub cargarComboNegocio()

        Dim objBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim dtNegocio_data As New DataTable
        Dim dr As DataRow

        Dim Lista1 As New List(Of beIncidencias)
        Dim entidad1 As beIncidencias
        Dim Lista2 As New List(Of beIncidencias)
        Dim entidad2 As New beIncidencias

        objBE.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania

        dtNegocio_data = objBLL.Lista_Inc_Negocio(objBE)

        dr = dtNegocio_data.NewRow
        dr("CCMPN") = "EZ"
        dr("CRGVTA") = "0"
        dr("TCRVTA") = "TODOS"
        dtNegocio_data.Rows.InsertAt(dr, 0)

        For Each item As DataRow In dtNegocio_data.Rows

            entidad1 = New beIncidencias
            entidad1.PSCRGVTA = item("CRGVTA")
            entidad1.PSTCRVTA = item("TCRVTA")
            Lista1.Add(entidad1)
        Next

        cmbNegocio.DisplayMember = "PSTCRVTA"
        cmbNegocio.ValueMember = "PSCRGVTA"
        Me.cmbNegocio.DataSource = Lista1

        For i As Integer = 0 To cmbNegocio.Items.Count - 1
            If cmbNegocio.Items.Item(i).Value = "0" Then
                cmbNegocio.SetItemChecked(i, True)
            End If
        Next

        If cmbNegocio.Text = "" Then
            cmbNegocio.SetItemChecked(1, True)
        End If

        dtNegocio = New DataTable
        Dim dr1 As DataRow

        dtNegocio.Columns.Add("CRGVTA_Codigo")
        dtNegocio.Columns.Add("TCRVTA_Descripcion")

        For Each item As DataRow In dtNegocio_data.Rows
            dr1 = dtNegocio.NewRow
            dr1("CRGVTA_Codigo") = item("CRGVTA")
            dr1("TCRVTA_Descripcion") = item("TCRVTA")
            dtNegocio.Rows.Add(dr1)
        Next


    End Sub


    Private Sub cargarComboReportado()

        Dim objBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim dtReportado_data As New DataTable
        Dim dr As DataRow

        Dim Lista1 As New List(Of beIncidencias)
        Dim entidad1 As beIncidencias
        Dim Lista2 As New List(Of beIncidencias)
        Dim entidad2 As New beIncidencias

        'objBE.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania

        dtReportado_data = objBLL.Lista_Nivel_y_Reportado().Tables(1)

        dr = dtReportado_data.NewRow

        dr("SORINC") = "0"
        dr("DESCRIPCION") = "TODOS"
        dtReportado_data.Rows.InsertAt(dr, 0)

        For Each item As DataRow In dtReportado_data.Rows

            entidad1 = New beIncidencias
            entidad1.PSSORINC = item("SORINC")
            entidad1.PSTSORINC = item("DESCRIPCION")
            Lista1.Add(entidad1)
        Next

        cmbReportado.DisplayMember = "PSTSORINC"
        cmbReportado.ValueMember = "PSSORINC"
        Me.cmbReportado.DataSource = Lista1

        For i As Integer = 0 To cmbReportado.Items.Count - 1
            If cmbReportado.Items.Item(i).Value = "0" Then
                cmbReportado.SetItemChecked(i, True)
            End If
        Next

        If cmbReportado.Text = "" Then
            cmbReportado.SetItemChecked(1, True)
        End If

        dtReportado = New DataTable
        Dim dr1 As DataRow

        dtReportado.Columns.Add("SORINC_Codigo")
        dtReportado.Columns.Add("TSORINC_Descripcion")

        For Each item As DataRow In dtReportado_data.Rows
            dr1 = dtReportado.NewRow
            dr1("SORINC_Codigo") = item("SORINC")
            dr1("TSORINC_Descripcion") = item("DESCRIPCION")
            dtReportado.Rows.Add(dr1)
        Next


    End Sub



    Private Function Lista_Negocios() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
            For j As Integer = 0 To dtNegocio.Rows.Count - 1
                If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = cmbNegocio.CheckedItems(i).Value) Then
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
                For j As Integer = 0 To dtNegocio.Rows.Count - 1
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") <> "0") Then
                        strCadDocumentos += dtNegocio.Rows(j).Item("CRGVTA_Codigo") & ","
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
                For j As Integer = 0 To dtNegocio.Rows.Count - 1
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = cmbNegocio.CheckedItems(i).Value) Then
                        strCadDocumentos += dtNegocio.Rows(j).Item("CRGVTA_Codigo") & ","
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        If strCadDocumentos = "" Then
            For j As Integer = 0 To dtNegocio.Rows.Count - 1
                If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") <> "0") Then
                    strCadDocumentos += dtNegocio.Rows(j).Item("CRGVTA_Codigo") & ","
                End If
            Next
            If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        End If

        Return strCadDocumentos

    End Function

    Sub Lista_Inc_Para()

        Dim objBLL As New brIncidencias

        cmbIncPara.DataSource = objBLL.Lista_Inc_Para
        cmbIncPara.DisplayMember = "TTPINC"
        cmbIncPara.ValueMember = "CTPINC"
        cmbIncPara.SelectedValue = 1

    End Sub


    Sub Lista_Inc_Negocio()

        Dim objBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim dtNegocio As New DataTable
        Dim dr As DataRow

        objBE.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania

        dtNegocio = objBLL.Lista_Inc_Negocio(objBE)

        dr = dtNegocio.NewRow
        dr("CCMPN") = "EZ"
        dr("CRGVTA") = "0"
        dr("TCRVTA") = "TODOS"
        dtNegocio.Rows.InsertAt(dr, 0)

        cmbIncPara.DataSource = dtNegocio
        cmbIncPara.DisplayMember = "CRGVTA"
        cmbIncPara.ValueMember = "TCRVTA"
        cmbIncPara.SelectedValue = "0"

    End Sub


    Sub Cargar_Estados()

        Dim objBLL As New brSeguimiento
        Dim dtEstados As New DataTable
        Dim dr As DataRow

        dtEstados = objBLL.Lista_Incidencia_Estados

        dr = dtEstados.NewRow
        dr("SESINC") = ""
        dr("DESCRIPCION") = "TODOS"
        dtEstados.Rows.InsertAt(dr, 0)

        cboEstado.DataSource = dtEstados.Copy
        cboEstado.ValueMember = "SESINC"
        cboEstado.DisplayMember = "DESCRIPCION"
        cboEstado.SelectedValue = ""

    End Sub

#End Region

    Private Sub dtgIncidencias_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgSeguimiento.DataBindingComplete

        For Each Item As DataGridViewRow In dtgSeguimiento.Rows

            If (Item.Cells("PNNMRGIM").Value > 0) Then
                Item.Cells("IMAGEN").Value = My.Resources.text_block
            Else
                Item.Cells("IMAGEN").Value = My.Resources.CuadradoBlanco
            End If

            If (Item.Cells("PNNMRGIA").Value > 0) Then
                Item.Cells("IMAGEN_C").Value = My.Resources.text_block
            Else
                Item.Cells("IMAGEN_C").Value = My.Resources.CuadradoBlanco
            End If

        Next

    End Sub

    Private Sub dtgIncidencias_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSeguimiento.CellDoubleClick

        Dim NameColumna As String = ""
        If e.RowIndex <= -1 Then
            Exit Sub
        End If
        NameColumna = dtgSeguimiento.Columns(dtgSeguimiento.CurrentCell.ColumnIndex).Name
        Select Case NameColumna
            Case "IMAGEN"
                If Val(dtgSeguimiento.Item("PNNMRGIM", e.RowIndex).Value) > 0 Then

                    Dim NMRGIM As String = ("" & Me.dtgSeguimiento.Item("PNNMRGIM", e.RowIndex).Value).ToString.Trim
                    Dim NINCSI As Decimal = Me.dtgSeguimiento.CurrentRow.Cells("PNNINCSI").Value
                    Dim PNCCLNT As Long = Me.dtgSeguimiento.CurrentRow.Cells("PNCCLNT").Value

                    'Dim objFrm As New frmAdjuntarDocumentos(NMRGIM, Nothing, PNCCLNT, "RZSC39", UcCompania_Cmb011.CCMPN_CodigoCompania, _pUsuario, frmAdjuntarDocumentos.EnumAdjunto.Incidencias, "SC")
                    'objFrm.TipoModo = frmAdjuntarDocumentos.EnumModo.Neutro
                    'objFrm.NINCSI = NINCSI
                    'objFrm.ShowDialog()
                    'If objFrm.myDialogResult = True Then
                    '    btnBuscar_Click(Nothing, Nothing)
                    'End If
                End If
            Case "IMAGEN_C"
                If Val(dtgSeguimiento.Item("PNNMRGIA", e.RowIndex).Value) > 0 Then
                    Dim NMRGIM As String = ("" & Me.dtgSeguimiento.Item("PNNMRGIA", e.RowIndex).Value).ToString.Trim
                    Dim NINCSI As Decimal = Me.dtgSeguimiento.CurrentRow.Cells("PNNINCSI").Value
                    Dim PNCCLNT As Long = Me.dtgSeguimiento.CurrentRow.Cells("PNCCLNT").Value
                    'Dim objFrm As New frmAdjuntarDocumentos(NMRGIM, Nothing, PNCCLNT, "RZSC39", UcCompania_Cmb011.CCMPN_CodigoCompania, _pUsuario, frmAdjuntarDocumentos.EnumAdjunto.Seguimiento, "SC")
                    'objFrm.TipoModo = frmAdjuntarDocumentos.EnumModo.Neutro
                    'objFrm.NINCSI = NINCSI
                    'objFrm.ShowDialog()
                    'If objFrm.myDialogResult = True Then
                    '    btnBuscar_Click(Nothing, Nothing)
                    'End If
                End If
        End Select
      

    End Sub

    'Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.SelectionChangeCommitted
    '    Try

    '        If Me.UcDivision_Cmb011.CDVSN_ANTERIOR <> Me.UcDivision_Cmb011.Division Then
    '            cargarComboPlanta()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Function Codigo_Division_X_Area(ByVal dt As DataTable, ByVal CCMPN As String, ByVal codigo_area As String) As String
        Dim resultado As String = ""
        Dim dr() As DataRow
        dr = dt.Select("CCMPN = '" & CCMPN & "' AND CARINC = '" & codigo_area & "'")
        If dr.Length > 0 Then
            resultado = ("" & dr(0)("CDVSN")).ToString.Trim
        End If
        Return resultado
    End Function


    Private Sub cargarComboPlanta()

        'Dim objLisEntidad As New List(Of Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta)
        'Dim objLisEntidad2 As New List(Of Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta)
        'Dim objLogica As New Ransa.Negocio.UbicacionPlanta.Planta.brPlanta
        Dim objLisEntidad As New List(Of UbicacionPlanta.Planta.bePlanta)
        Dim objLisEntidad2 As New List(Of UbicacionPlanta.Planta.bePlanta)
        Dim objLogica As New UbicacionPlanta.Planta.brPlanta
        cboPlanta.Text = ""

        Dim codigo_division As String = ""
        Try
            'If (bolBuscar = True And cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
            '    bolBuscar = False
            If (UcCompania_Cmb011.CCMPN_CodigoCompania IsNot Nothing And cmbArea.SelectedIndex <> -1) Then

                codigo_division = Codigo_Division_X_Area(cmbArea.Tag, UcCompania_Cmb011.CCMPN_CodigoCompania, cmbArea.SelectedValue)

                objLogica.Crea_Lista(_pUsuario)
                objLisEntidad2 = objLogica.Lista_Planta_X_Usuario(UcCompania_Cmb011.CCMPN_CodigoCompania, codigo_division) 'cmbArea.SelectedValue)

                Dim objEntidad1 As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
                objEntidad1.CPLNDV_CodigoPlanta = "0"
                objEntidad1.TPLNTA_DescripcionPlanta = "TODOS"
                objLisEntidad.Add(objEntidad1)

                Dim objEntidad As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next

                cboPlanta.DisplayMember = "TPLNTA_DescripcionPlanta"
                cboPlanta.ValueMember = "CPLNDV_CodigoPlanta"
                Me.cboPlanta.DataSource = objLisEntidad

                For i As Integer = 0 To cboPlanta.Items.Count - 1
                    If cboPlanta.Items.Item(i).Value = "0" Then
                        cboPlanta.SetItemChecked(i, True)
                    End If
                Next

                If cboPlanta.Text = "" Then
                    cboPlanta.SetItemChecked(0, True)
                End If

                dt = New DataTable
                Dim dr As DataRow

                dt.Columns.Add("CPLNDV_CodigoPlanta")
                dt.Columns.Add("TPLNTA_DescripcionPlanta")

                Dim objEntidad2 As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta

                For Each objEntidad2 In objLisEntidad
                    dr = dt.NewRow
                    dr("CPLNDV_CodigoPlanta") = objEntidad2.CPLNDV_CodigoPlanta
                    dr("TPLNTA_DescripcionPlanta") = objEntidad2.TPLNTA_DescripcionPlanta
                    dt.Rows.Add(dr)
                Next

                'If objLisEntidad.Count > 0 Then
                '    _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
                'Else
                '    _lstrTipoCuenta = ""
                'End If
                'bolBuscar = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function Lista_Reportado() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbReportado.CheckedItems.Count - 1
            For j As Integer = 0 To dtReportado.Rows.Count - 1
                If (dtReportado.Rows(j).Item("SORINC_Codigo") = cmbReportado.CheckedItems(i).Value) Then
                    If (dtReportado.Rows(j).Item("SORINC_Codigo") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For i As Integer = 0 To cmbReportado.CheckedItems.Count - 1
                For j As Integer = 0 To dtReportado.Rows.Count - 1
                    If (dtReportado.Rows(j).Item("SORINC_Codigo") <> "0") Then
                        strCadDocumentos += dtReportado.Rows(j).Item("SORINC_Codigo") & ","
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To cmbReportado.CheckedItems.Count - 1
                For j As Integer = 0 To dtReportado.Rows.Count - 1
                    If (dtReportado.Rows(j).Item("SORINC_Codigo") = cmbReportado.CheckedItems(i).Value) Then
                        strCadDocumentos += dtReportado.Rows(j).Item("SORINC_Codigo") & ","
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        If strCadDocumentos = "" Then
            For j As Integer = 0 To dtReportado.Rows.Count - 1
                If (dtReportado.Rows(j).Item("SORINC_Codigo") <> "0") Then
                    strCadDocumentos += dtReportado.Rows(j).Item("SORINC_Codigo") & ","
                End If
            Next
            If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        End If

        Return strCadDocumentos

    End Function

    Private Sub btnSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguimiento.Click

        Try

            If Me.dtgSeguimiento.CurrentCellAddress.Y = -1 OrElse dtgSeguimiento.CurrentRow Is Nothing Then Exit Sub
            Dim obeSeguimiento As New beSeguimiento
            obeSeguimiento = CType(Me.dtgSeguimiento.CurrentRow.DataBoundItem, beSeguimiento)
            Dim estadoSeg As String = obeSeguimiento.PSSESINC

            Select Case estadoSeg
                Case "P"
                    Dim objFrm As New frmRevisionInc
                    obeSeguimiento = CType(Me.dtgSeguimiento.CurrentRow.DataBoundItem, beSeguimiento)
                    objFrm.pUsuario = _pUsuario
                    objFrm.pArea = cmbArea.Text
                    objFrm.Entidad = obeSeguimiento
                    If objFrm.ShowDialog = DialogResult.OK Then
                        btnBuscar_Click(Nothing, Nothing)
                    End If

                Case "R"
                    Dim objFrm As New frmConcluidoInc
                   
                    objFrm.pUsuario = _pUsuario
                    objFrm.pArea = cmbArea.Text
                    objFrm.Entidad = obeSeguimiento
                    objFrm.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                    objFrm.pPNCCLNT = obeSeguimiento.PNCCLNT
                    objFrm.pNMRGIM = obeSeguimiento.PNNMRGIA

                    If objFrm.ShowDialog = DialogResult.OK Then
                        btnBuscar_Click(Nothing, Nothing)
                    End If
                Case "C"
                    Dim codigo As Int32 = 0
                    Dim estado As String = ""

                    codigo = CInt(CType(Me.dtgSeguimiento.CurrentRow.DataBoundItem, beSeguimiento).PNNINCSI)
                    estado = CType(Me.dtgSeguimiento.CurrentRow.DataBoundItem, beSeguimiento).PSESTADO

                    MessageBox.Show("La incidencia : " & codigo & " se encuentra en estado " & estado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgSeguimiento_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSeguimiento.SelectionChanged
        Try

            lblTitulo.Text = ""
            lblTitulo.Text = "INCIDENCIA Nro " & dtgSeguimiento.CurrentRow.Cells("PNNINCSI").Value & ": " & dtgSeguimiento.CurrentRow.Cells("PSESTADO").Value
            Dim y As Integer = dtgSeguimiento.CurrentCellAddress.Y
            Select Case dtgSeguimiento.Item("PSSESINC", y).Value

                Case "P"
                    btnSeguimiento.Enabled = True
                    btnSeguimiento.Text = "Revisar"
                    btnAdjuntar.Enabled = False


                Case "R"
                    btnSeguimiento.Enabled = True
                    btnSeguimiento.Text = "Concluir"
                    btnAdjuntar.Enabled = True


                Case "C"
                    btnSeguimiento.Enabled = False
                    btnAdjuntar.Enabled = True

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntar.Click

        Try

            If dtgSeguimiento.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim Y As Integer = dtgSeguimiento.CurrentCellAddress.Y

            Dim NMRGIM As String = dtgSeguimiento.Item("PNNMRGIA", Y).Value
            Dim NINCSI As Decimal = dtgSeguimiento.Item("PNNINCSI", Y).Value
            Dim PNCCLNT As Long = dtgSeguimiento.Item("PNCCLNT", Y).Value

            'Dim objFrm As New frmAdjuntarDocumentos(NMRGIM, Nothing, PNCCLNT, "RZSC39", UcCompania_Cmb011.CCMPN_CodigoCompania, _pUsuario, frmAdjuntarDocumentos.EnumAdjunto.Seguimiento, "SC")
            'objFrm.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
            'objFrm.NINCSI = NINCSI
            'objFrm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub UcCompania_Cmb011_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.SelectionChangeCommitted
        Try
            'UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            'UcDivision_Cmb011.Usuario = _pUsuario
            'UcDivision_Cmb011.pActualizar()
            ''Dim division As New Ransa.TypeDef.UbicacionPlanta.Division.beDivision
            ''division.CCMPN_CodigoCompania = obeCompania.CCMPN_CodigoCompania
            ''If division.CCMPN_CodigoCompania = "EZ" Then
            ''    division.CDVSN_CodigoDivision = "1"
            ''End If
            'UcDivision_Cmb011_SelectionChangeCommitted(Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcDivision_Cmb011_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision)
        Try

            'If Me.UcDivision_Cmb011.CDVSN_ANTERIOR <> Me.UcDivision_Cmb011.Division Then
            cargarComboPlanta()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIncFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIncFiltro.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim obrSeguimiento As New brSeguimiento
        Dim obeSeguimiento As New beSeguimiento
        Lista1 = New List(Of beSeguimiento)
        Dim obeSeguimiento1 As New beSeguimiento
        Dim PLANTAS As String = ""
        With obeSeguimiento
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCARINC = cmbArea.SelectedValue
            .PNCCLNT = txtCliente.pCodigo

            If chkIncidencia.Checked = False Then
                .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value.Date)
                .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value.Date)
            Else
                .PNFECINI = 0
                .PNFECFIN = 0
            End If

            .PSSESINC = cboEstado.SelectedValue
            .PSUSUARIO = txtUsuario.pPSMMCUSR
            If chkIncidencia.Enabled = True Then
                .PNNINCSI = Val(txtIncFiltro.Text)
            Else
                .PNNINCSI = 0D
            End If
            .PNCTPINC = cmbIncPara.SelectedValue
            .PSCRGVTA = Lista_Negocios()
            .PSSORINC = Lista_Reportado()

        End With
        dtgSeguimiento.AutoGenerateColumns = False

        PLANTAS = Lista_Plantas()

        Lista1 = obrSeguimiento.olisListarRegistroIncidencias(obeSeguimiento, PLANTAS)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        PictureBox1.Visible = False
        btnBuscar.Enabled = True
        Me.dtgSeguimiento.DataSource = Lista1
    End Sub

    Private Sub chkIncidencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIncidencia.CheckedChanged
        txtIncFiltro.Enabled = chkIncidencia.Checked
        dteFechaInicial.Enabled = Not chkIncidencia.Checked
        dteFechaFinal.Enabled = Not chkIncidencia.Checked

    End Sub

    Private Sub cmbArea_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectionChangeCommitted
        Try
            cargarComboPlanta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
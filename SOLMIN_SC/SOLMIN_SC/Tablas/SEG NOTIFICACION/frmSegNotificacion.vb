Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad

Public Class frmSegNotificacion
    Private oCheckPoint As New clsCheckPoint

    Private Sub frmSegNotificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dgvSegNotificacion.AutoGenerateColumns = False
            dgvCheckPointsNotificacion.AutoGenerateColumns = False
            dgvNotificacionCliente.AutoGenerateColumns = False
            Cargar_Compania()
            cargar_Cliente()
            Cargar_Cargar_ProcNotificacion()
            Cargar_Cargar_Formatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    

    End Sub
  

    Private Sub tbnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnAgregar.Click
        Try
            If dgvSegNotificacion.RowCount > 0 Then


                If dgvSegNotificacion.CurrentRow.Cells("CODFMT").Value.ToString.Trim = "" Then
                    MessageBox.Show("El registro no contiene formato.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If dgvSegNotificacion.CurrentRow.Cells("PARA_FORMATO").Value.ToString.ToUpper <> "X" Then
                    MessageBox.Show("No se permite adición CheckPoint a este tipo proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Dim objFormulario As Object = Nothing
                Select Case TabControl1.SelectedTab.Name
                    Case "TPCheckPoints"
                        objFormulario = New frmNotificacionChekckPoints()
                        objFormulario.objNoficacion.PSCCMPN = dgvSegNotificacion.CurrentRow().Cells("CCMPN").Value
                        objFormulario.objNoficacion.PSCDVSN = dgvSegNotificacion.CurrentRow().Cells("CDVSN").Value
                        objFormulario.objNoficacion.PNCCLNT = dgvSegNotificacion.CurrentRow().Cells("CCLNT").Value
                        objFormulario.objNoficacion.PSNLTECL = dgvSegNotificacion.CurrentRow().Cells("COD_TIPPROC").Value
                        objFormulario.objNoficacion.PSCODFMT = "" 'dgvSegNotificacion.CurrentRow().Cells("CODFMT").Value
                    Case "TPNotifCliente"
                        objFormulario = New frmNotificacionCliente()
                        objFormulario.objNoficacion.PNCCLNT = dgvSegNotificacion.CurrentRow().Cells("CCLNT").Value
                        objFormulario.objNoficacion.PSNLTECL = dgvSegNotificacion.CurrentRow().Cells("COD_TIPPROC").Value
                End Select

                If objFormulario.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If TabControl1.SelectedTab.Name = "TPCheckPoints" Then
                        ListarCheckPointsNotificacion()
                    Else
                        ListarNotificacionCliente()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub tbnCab_Formato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnCab_Formato.Click
        Try
            If dgvSegNotificacion.RowCount > 0 Then
                If dgvSegNotificacion.CurrentRow.Cells("PARA_FORMATO").Value.ToString.ToUpper <> "X" Then
                    MessageBox.Show("No se permite adición de formato a este tipo proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If dgvSegNotificacion.CurrentRow IsNot Nothing Then
                    Dim frmNotificacionEmail As New frmNotificacionEmail()
                    frmNotificacionEmail.COCNTF = dgvSegNotificacion.CurrentRow().Cells("COCNTF").Value
                    If frmNotificacionEmail.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ListarSeguimientoNotificacion()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub tbnCab_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnCab_Agregar.Click

        Try
            Dim frmAgregarNotificaciones As New frmAgregarNotificaciones()
            frmAgregarNotificaciones.CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            frmAgregarNotificaciones.CDVSN = UcDivision_Cmb011.Division
            If frmAgregarNotificaciones.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListarSeguimientoNotificacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = HelpUtil.UserName
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                UcDivision_Cmb011.DivisionDefault = "S"
                UcDivision_Cmb011.pHabilitado = False
            End If
            UcDivision_Cmb011.pActualizar()




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbnCab_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnCab_Buscar.Click
        Try
            ListarSeguimientoNotificacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbnCab_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnCab_Eliminar.Click
        Try
            If dgvSegNotificacion.Rows.Count > 0 Then
                If dgvSegNotificacion.CurrentRow IsNot Nothing Then

                    If MessageBox.Show("Esta seguro que desea Eliminar.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub
                    If dgvCheckPointsNotificacion.RowCount > 0 Or dgvNotificacionCliente.RowCount > 0 Then
                        MessageBox.Show("No se puede Eliminar . Contiene detalles ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    Dim brSegNotificacion As New Negocio.clsSegNotificacion
                    Dim beSegNotificacion As New beSegNotificacion
                    With beSegNotificacion
                        .PSCULUSA = HelpUtil.UserName
                        .PNCOCNTF = dgvSegNotificacion.CurrentRow().Cells("COCNTF").Value
                    End With
                    brSegNotificacion.EliminarClienteProcesoNotificacion(beSegNotificacion)
                    ListarSeguimientoNotificacion()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

    Private Sub dgvSegNotificacion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSegNotificacion.SelectionChanged
        Try
            ListarCheckPointsNotificacion()
            ListarNotificacionCliente()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbnCopiarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnCopiarPerfil.Click
        Try
            If dgvSegNotificacion.Rows.Count > 0 Then
                If dgvSegNotificacion.CurrentRow.Cells("PARA_FORMATO").Value.ToString.ToUpper <> "X" Then
                    MessageBox.Show("No se permite la acción a este tipo proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                If dgvSegNotificacion.CurrentRow IsNot Nothing Then
                    Dim frmCopiarPerfilChkNotificacion As New frmCopiarPerfilChkNotificacion()
                    frmCopiarPerfilChkNotificacion.PSCCMPN = dgvSegNotificacion.CurrentRow().Cells("CCMPN").Value
                    frmCopiarPerfilChkNotificacion.PSCDVSN = dgvSegNotificacion.CurrentRow().Cells("CDVSN").Value
                    frmCopiarPerfilChkNotificacion.PSNLTECL = dgvSegNotificacion.CurrentRow().Cells("COD_TIPPROC").Value.ToString.Trim
                    frmCopiarPerfilChkNotificacion.PNCCLNT = dgvSegNotificacion.CurrentRow().Cells("CCLNT").Value.ToString.Trim
                    If frmCopiarPerfilChkNotificacion.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ListarCheckPointsNotificacion()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub tbnModicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnModicar.Click

        Try
            Dim objFormulario As Object = Nothing
            Select Case TabControl1.SelectedTab.Name
                Case "TPCheckPoints"

                    If dgvSegNotificacion.RowCount > 0 Then
                        If dgvCheckPointsNotificacion.RowCount > 0 Then
                            objFormulario = New frmNotificacionChekckPoints()
                            objFormulario.Modificar = True
                            Dim obeSegNotificacion As New beSegNotificacion
                            With obeSegNotificacion
                                .PSCCMPN = dgvSegNotificacion.CurrentRow().Cells("CCMPN").Value.ToString.Trim
                                .PSCDVSN = dgvSegNotificacion.CurrentRow().Cells("CDVSN").Value.ToString.Trim
                                .PNCCLNT = Val(dgvSegNotificacion.CurrentRow().Cells("CCLNT").Value)
                                .PSNLTECL = dgvSegNotificacion.CurrentRow().Cells("COD_TIPPROC").Value.ToString.Trim
                                .PSCODFMT = "" 'dgvSegNotificacion.CurrentRow().Cells("COCNTF").Value.ToString.Trim
                                '-------------------------------------------------------------------------
                                .PNCFCHK = dgvCheckPointsNotificacion.CurrentRow.Cells("CFCHK").Value
                                .CEMB = dgvCheckPointsNotificacion.CurrentRow.Cells("CEMB").Value
                                .PNNESTDO = Val(dgvCheckPointsNotificacion.CurrentRow.Cells("NESTDO").Value)
                                .PSTCOLUM = dgvCheckPointsNotificacion.CurrentRow.Cells("TCOLUM").Value.ToString.Trim
                                .PSFLGEST = dgvCheckPointsNotificacion.CurrentRow.Cells("FLGEST").Value.ToString.Trim
                                .PSFLGNTE = dgvCheckPointsNotificacion.CurrentRow.Cells("FLGNTE").Value.ToString.Trim
                                .PNNSEPRE = Val(dgvCheckPointsNotificacion.CurrentRow.Cells("NSEPRE").Value)
                            End With
                            objFormulario.objNoficacion = obeSegNotificacion
                        End If
                    End If
                Case "TPNotifCliente"
                    If dgvSegNotificacion.RowCount > 0 Then
                        If dgvNotificacionCliente.RowCount > 0 Then
                            objFormulario = New frmNotificacionCliente()
                            objFormulario.Modificar = True
                            Dim obeSegNotificacion As New beSegNotificacion
                            With obeSegNotificacion
                                .PNCCLNT = Val(dgvSegNotificacion.CurrentRow().Cells("CCLNT").Value)
                                .PSNLTECL = dgvSegNotificacion.CurrentRow().Cells("COD_TIPPROC").Value.ToString.Trim
                                .PSEMAILTO = dgvNotificacionCliente.CurrentRow.Cells("EMAILTO").Value.ToString.Trim
                                .PNNCRRIT = dgvNotificacionCliente.CurrentRow.Cells("N_NCRRIT").Value
                                .PSTIPPROC = dgvNotificacionCliente.CurrentRow.Cells("TIPPROC").Value.ToString.Trim
                                .PSTNMYAP = dgvNotificacionCliente.CurrentRow.Cells("TNMYAP").Value.ToString.Trim
                            End With
                            objFormulario.objNoficacion = obeSegNotificacion
                        End If
                    End If
            End Select

            If objFormulario.ShowDialog = Windows.Forms.DialogResult.OK Then
                If TabControl1.SelectedTab.Name = "TPCheckPoints" Then
                    ListarCheckPointsNotificacion()
                Else
                    ListarNotificacionCliente()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub tbnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnEliminar.Click
        Try
            If MessageBox.Show("Está seguro de Eliminar.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub

            Dim brSegNotificacion As New Negocio.clsSegNotificacion
            Dim countn As Integer = 0
            Select Case TabControl1.SelectedTab.Name

                Case "TPCheckPoints"

                    dgvCheckPointsNotificacion.EndEdit()
                    If dgvCheckPointsNotificacion.RowCount > 0 Then
                        For Each Fila As DataGridViewRow In dgvCheckPointsNotificacion.Rows
                            If Fila.Cells("Chk").Value = True Then
                                Dim obeSegNotificacion As New beSegNotificacion
                                With obeSegNotificacion
                                    .PNCFCHK = Fila.Cells("CFCHK").Value
                                    .PSCULUSA = HelpUtil.UserName
                                End With
                                brSegNotificacion.EliminarCheckPointsNotificacionEmail(obeSegNotificacion)
                                countn = countn + 1
                            End If
                        Next
                        ListarCheckPointsNotificacion()
                    End If
                   
                Case "TPNotifCliente"
                    dgvNotificacionCliente.EndEdit()
                    If dgvNotificacionCliente.RowCount > 0 Then
                        For Each Fila As DataGridViewRow In dgvNotificacionCliente.Rows
                            If Fila.Cells("Chek").Value = True Then
                                Dim obeSegNotificacion As New beSegNotificacion
                                With obeSegNotificacion
                                    .PNCCLNT = Fila.Cells("N_CCLNT").Value
                                    .PSNLTECL = Fila.Cells("S_NLTECL").Value
                                    .PNNCRRIT = Fila.Cells("N_NCRRIT").Value
                                    .PSCULUSA = HelpUtil.UserName
                                End With
                                brSegNotificacion.EliminarEmailDestinatarioXTipo(obeSegNotificacion)
                                countn = countn + 1
                            End If
                        Next
                        ListarNotificacionCliente()
                    End If
            End Select
            If countn = 0 Then
                MessageBox.Show("seleccione al menos un registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbnActualizarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnActualizarOrden.Click

        Try
            Dim brSegNotificacion As New Negocio.clsSegNotificacion
            If TabControl1.SelectedTab.Name = "TPCheckPoints" Then
                For Each Fila As DataGridViewRow In dgvCheckPointsNotificacion.Rows
                    Dim obeSegNotificacion As New beSegNotificacion
                    With obeSegNotificacion
                        .PNCFCHK = Fila.Cells("CFCHK").Value
                        .PNNSEPRE = Fila.Cells("NSEPRE").Value
                        .PSCULUSA = HelpUtil.UserName
                    End With
                    brSegNotificacion.ActualizarOrdenCheckPointsNotificacionEmail(obeSegNotificacion)
                Next
                ListarCheckPointsNotificacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        If TabControl1.SelectedTab.Name = "TPCheckPoints" Then
            tbnActualizarOrden.Enabled = True
            tbnCopiarPerfil.Enabled = True
        Else
            tbnActualizarOrden.Enabled = False
            tbnCopiarPerfil.Enabled = False
        End If
    End Sub

#Region "Metodos y Funciones"

    Private Sub Cargar_Compania()
        UcCompania_Cmb011.Usuario = HelpUtil.UserName
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub cargar_Cliente()
        txtCliente.pAccesoPorUsuario = False
        txtCliente.pRequerido = False
        txtCliente.pUsuario = HelpUtil.UserName
    End Sub

    Private Sub Cargar_Cargar_Formatos()
        Dim oclsTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
        Dim Lista As New List(Of beTipoDatoGeneral)
        Dim obtipoGeneral As New beTipoDatoGeneral
        Lista = oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo_General("SCFCHK")
        obtipoGeneral.PSCCMPRN = ""
        obtipoGeneral.PSTDSDES = "Ninguno"
        Lista.Insert(0, obtipoGeneral)
        cbmFormato.DataSource = Lista
        cbmFormato.ValueMember = "PSCCMPRN"
        cbmFormato.DisplayMember = "PSTDSDES"
        cbmFormato.SelectedValue = ""
    End Sub

    Private Sub Cargar_Cargar_ProcNotificacion()
        Dim Lista As List(Of beTipoDatoGeneral)
        Dim oclsTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
        Lista = oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo_General("SCCENV")
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        If Lista.Count > 0 Then
            UcProcNotificacion.DataSource = Lista
        Else
            UcProcNotificacion.DataSource = Nothing
        End If
        UcProcNotificacion.ListColumnas = oListColum
        UcProcNotificacion.Cargas()
        UcProcNotificacion.Limpiar()
        UcProcNotificacion.ValueMember = "PSCCMPRN"
        UcProcNotificacion.DispleyMember = "PSTDSDES"
    End Sub


    Private Sub ListarSeguimientoNotificacion()

        dgvSegNotificacion.DataSource = Nothing
        dgvCheckPointsNotificacion.DataSource = Nothing
        dgvNotificacionCliente.DataSource = Nothing

        Dim brSegNotificacion As New Negocio.clsSegNotificacion
        Dim dt As New DataTable
        Dim beSegNotificacion As New beSegNotificacion
        With beSegNotificacion
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCCLNT = txtCliente.pCodigo
            If Not UcProcNotificacion.Resultado Is Nothing Then
                .PSNLTECL = CType(UcProcNotificacion.Resultado, beTipoDatoGeneral).PSCCMPRN
            Else
                .PSNLTECL = ""
            End If
            .PSCODFMT = cbmFormato.SelectedValue
        End With
        dt = brSegNotificacion.ListarClienteProcesoNotificacion(beSegNotificacion)
        dgvSegNotificacion.AutoGenerateColumns = False
        dgvSegNotificacion.DataSource = dt
    End Sub


    Private Sub ListarCheckPointsNotificacion()
        If dgvSegNotificacion.RowCount > 0 Then
            If dgvSegNotificacion.CurrentRow IsNot Nothing Then
                Dim brSegNotificacion As New Negocio.clsSegNotificacion
                Dim dt As New DataTable
                Dim beSegNotificacion As New beSegNotificacion
                With beSegNotificacion
                    .PSCCMPN = dgvSegNotificacion.CurrentRow().Cells("CCMPN").Value
                    .PSCDVSN = dgvSegNotificacion.CurrentRow().Cells("CDVSN").Value
                    .PNCCLNT = dgvSegNotificacion.CurrentRow().Cells("CCLNT").Value
                    .PSNLTECL = dgvSegNotificacion.CurrentRow().Cells("COD_TIPPROC").Value.ToString.Trim
                End With
                dt = brSegNotificacion.ListarCheckPointsNotificacion(beSegNotificacion)
                dgvCheckPointsNotificacion.AutoGenerateColumns = False
                dgvCheckPointsNotificacion.DataSource = dt
            End If
        End If
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvCheckPointsNotificacion_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCheckPointsNotificacion.EditingControlShowing
        Dim Texto As New TextBox
        Dim colName As String = ""
        colName = dgvCheckPointsNotificacion.Columns(dgvCheckPointsNotificacion.CurrentCell.ColumnIndex).Name
        If TypeOf e.Control Is TextBox Then
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
        End If
        Select Case colName
            Case "NSEPRE"
                Texto = CType(e.Control, TextBox)
                Texto.Text = Texto.Text.Trim
                Texto.Tag = "4-0"
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
        End Select
    End Sub

    Private Sub ListarNotificacionCliente()
        If dgvSegNotificacion.RowCount > 0 Then
            If dgvSegNotificacion.CurrentRow IsNot Nothing Then
                Dim brSegNotificacion As New Negocio.clsSegNotificacion
                Dim dt As New DataTable
                Dim beSegNotificacion As New beSegNotificacion
                With beSegNotificacion
                    .PNCCLNT = dgvSegNotificacion.CurrentRow().Cells("CCLNT").Value
                    .PSNLTECL = dgvSegNotificacion.CurrentRow().Cells("COD_TIPPROC").Value.ToString.Trim
                End With
                dt = brSegNotificacion.ListarEmailDestinatarioXTipo(beSegNotificacion)
                'dgvNotificacionCliente.AutoGenerateColumns = False
                dgvNotificacionCliente.DataSource = dt
            End If
        End If
    End Sub

#End Region



    Private Sub btnExportarCab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarCab.Click

        Try
           
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim lstrPeriodo As String = ""
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            Dim dtExportar As New DataTable

            dtExportar.Columns.Add("COCNTF").Caption = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoTexto)
            dtExportar.Columns.Add("DESC_TIPPROC").Caption = NPOI_SC.FormatDato("Proc. Notificación", NPOI_SC.keyDatoTexto)
            dtExportar.Columns.Add("CCLNT").Caption = NPOI_SC.FormatDato("Cod. Cliente", NPOI_SC.keyDatoTexto)
            dtExportar.Columns.Add("TCMPCL").Caption = NPOI_SC.FormatDato("Cliente", NPOI_SC.keyDatoTexto)
            dtExportar.Columns.Add("CODFMT").Caption = NPOI_SC.FormatDato("Formato", NPOI_SC.keyDatoTexto)
            dtExportar.Columns.Add("DES_CODFMT").Caption = NPOI_SC.FormatDato("Desc. Formato", NPOI_SC.keyDatoTexto)
        

            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Each drDatos As DataGridViewRow In dgvSegNotificacion.Rows
                dr = dtExportar.NewRow
                For Each dcColumna As DataColumn In dtExportar.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos.Cells(NameColumna).Value
                Next
                dtExportar.Rows.Add(dr)
            Next



            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExportar.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Compañia:|" & UcCompania_Cmb011.CCMPN_Descripcion)
            itemSortedList.Add(itemSortedList.Count, "División  | " & UcDivision_Cmb011.Division)
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTA PROCESOS NOTIFICACION")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnExportar.Click



        Try

            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim lstrPeriodo As String = ""
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            Dim dtExportarChk As New DataTable
            Dim dtExportarEmail As New DataTable



            dtExportarChk.Columns.Add("NESTDO").Caption = NPOI_SC.FormatDato("Cod. Chk", NPOI_SC.keyDatoTexto)
            dtExportarChk.Columns.Add("DES_TIPOCHK").Caption = NPOI_SC.FormatDato("Tipo chk", NPOI_SC.keyDatoTexto)
            dtExportarChk.Columns.Add("CHK_DES").Caption = NPOI_SC.FormatDato("CheckPoint", NPOI_SC.keyDatoTexto)
            dtExportarChk.Columns.Add("CHK_DES_SEG").Caption = NPOI_SC.FormatDato("Título en Seg.", NPOI_SC.keyDatoTexto)
            dtExportarChk.Columns.Add("TCOLUM").Caption = NPOI_SC.FormatDato("Título en email", NPOI_SC.keyDatoTexto)
            dtExportarChk.Columns.Add("NOTIFICAR_CHK").Caption = NPOI_SC.FormatDato("Notificar", NPOI_SC.keyDatoTexto)
            dtExportarChk.Columns.Add("VER_CHK").Caption = NPOI_SC.FormatDato("Visualizar", NPOI_SC.keyDatoTexto)
            dtExportarChk.Columns.Add("NSEPRE").Caption = NPOI_SC.FormatDato("Orden", NPOI_SC.keyDatoTexto)


            dtExportarEmail.Columns.Add("EMAILTO").Caption = NPOI_SC.FormatDato("Email", NPOI_SC.keyDatoTexto)
            dtExportarEmail.Columns.Add("TNMYAP").Caption = NPOI_SC.FormatDato("Nombres/Apellidos", NPOI_SC.keyDatoTexto)
            dtExportarEmail.Columns.Add("TIPPROC").Caption = NPOI_SC.FormatDato("Div. Notif", NPOI_SC.keyDatoTexto)



            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Each drDatos As DataGridViewRow In dgvCheckPointsNotificacion.Rows
                dr = dtExportarChk.NewRow
                For Each dcColumna As DataColumn In dtExportarChk.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos.Cells(NameColumna).Value
                Next
                dtExportarChk.Rows.Add(dr)
            Next

            For Each drDatos As DataGridViewRow In dgvNotificacionCliente.Rows
                dr = dtExportarEmail.NewRow
                For Each dcColumna As DataColumn In dtExportarEmail.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos.Cells(NameColumna).Value
                Next
                dtExportarEmail.Rows.Add(dr)
            Next




            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExportarChk.Copy)
            ListaDatatable.Add(dtExportarEmail.Copy)


            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Proc. Notif.:|" & dgvSegNotificacion.CurrentRow.Cells("COCNTF").Value.ToString.Trim & "-" & dgvSegNotificacion.CurrentRow.Cells("DESC_TIPPROC").Value.ToString.Trim)
            itemSortedList.Add(itemSortedList.Count, "Cliente  | " & dgvSegNotificacion.CurrentRow.Cells("CCLNT").Value.ToString.Trim & "-" & dgvSegNotificacion.CurrentRow.Cells("TCMPCL").Value.ToString.Trim)
            itemSortedList.Add(itemSortedList.Count, "Formato  | " & dgvSegNotificacion.CurrentRow.Cells("CODFMT").Value.ToString.Trim & "-" & dgvSegNotificacion.CurrentRow.Cells("DES_CODFMT").Value.ToString.Trim)
            LisFiltros.Add(itemSortedList)
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("Lista CheckPoint Notificaciones")
            ListTitulo.Add("Lista Correos Notificaciones")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)





        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Imports Ransa.NEGO
Imports Ransa.TypeDef
'Imports ransa.TYPEDEF.Cliente
Imports Ransa.Utilitario
Imports ComponentFactory.Krypton.Toolkit

Public Class frmLPosiciones



#Region "Atributos"

#End Region

#Region "Variables"

#End Region

#Region "Metodos y Funciones"

#End Region

#Region "Eventos"

    'Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        listarUbicacion()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
    Private Sub listarUbicacion()
        Dim msg As String = ""
        Dim PSTIPO As String = ""
        Dim PSALMACEN As String = ""
        Dim CodCliente As Decimal = 0
        'If txtSector.Text.Trim = "" Then
        '    msg = "Ingrese Sector." & Chr(13)
        'End If
        'If txtTipoAlmacen.Resultado Is Nothing Then
        '    msg = "Seleccione Tipo Almacén" & Chr(13)
        'End If
        'If txtAlmacen.Resultado Is Nothing Then
        '    msg = msg & "Seleccione Tipo Almacén"
        'End If
        'msg = msg.Trim
        'If msg.Length > 0 Then
        '    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If String.IsNullOrEmpty(txtSector.Text) = False And txtTipoAlmacen.Resultado Is Nothing = False And txtAlmacen.Resultado Is Nothing = False Then

        If txtTipoAlmacen.Resultado IsNot Nothing Then
            PSTIPO = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        End If
        If txtAlmacen.Resultado IsNot Nothing Then
            PSALMACEN = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
        End If
        CodCliente = txtCliente.pCodigo

        If Me.txtPosicion.Text.Trim = "" Then

            If CodCliente = 0 Then
                If txtTipoAlmacen.Resultado Is Nothing Then
                    msg = "Seleccione Tipo Almacén o Cliente." & Chr(13)
                End If
            End If

        End If
     

        msg = msg.Trim
        If msg.Length > 0 Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim oBR As New brUbicacion()
        dgPosiciones.AutoGenerateColumns = False
        'Dim lis As List(Of beUbicacion) = oBR.Listar(PSTIPO, PSALMACEN, txtSector.Text, Me.txtPosicion.Text, UcPaginacion)
        'ListarPosiciones
        Dim oFiltrobeUbicacion As New beUbicacion
        oFiltrobeUbicacion.PSTALMC = PSTIPO
        oFiltrobeUbicacion.PSCALMC = PSALMACEN
        oFiltrobeUbicacion.PNCCLNT = CodCliente
        oFiltrobeUbicacion.PSCSECTR = txtSector.Text.Trim
        oFiltrobeUbicacion.PSCPSCN = Me.txtPosicion.Text.Trim
        oFiltrobeUbicacion.PageSize = UcPaginacion.PageSize
        oFiltrobeUbicacion.PageNumber = UcPaginacion.PageNumber
        Dim lis As New List(Of beUbicacion)
        lis = oBR.ListarPosiciones(oFiltrobeUbicacion)
        If lis.Count > 0 Then
            UcPaginacion.PageCount = lis(0).PageCount
        End If
        If Me.UcPaginacion.PageNumber > UcPaginacion.PageCount Then
            Me.UcPaginacion.PageNumber = 1
            'lis = oBR.Listar(PSTIPO, PSALMACEN, txtSector.Text, Me.txtPosicion.Text, UcPaginacion)
        End If
        dgPosiciones.DataSource = lis
        'End If

    End Sub


    Private Sub frmLSloting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            UCDataGridView.Alinear_Columnas_Grilla(Me.dgPosiciones)

            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            CargarControlTipoAlmacen()


            txtCliente.pUsuario = objSeguridadBN.pUsuario

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        Try
            UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcPLanta_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try
            Select Case e.KeyCode
                Case Keys.F4


                    Dim PSTIPO As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
                    Dim PSALMACEN As String = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC

                    Call mfblnBuscar_TipoAlmacen(PSTIPO, PSALMACEN)
                Case Keys.Delete
                    txtTipoAlmacen.Limpiar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén
        txtAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        Try
            Dim PSTIPO As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
            Dim PSTIPONOMBRE As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSTALMC
            Dim PSALMACEN As String = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
            Dim PSALMACENNOMBRE As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL

            If PSTIPONOMBRE = "" Then
                txtTipoAlmacen.Limpiar()
            Else
                If PSTIPONOMBRE <> "" And "" & PSTIPO = "" Then

                    Call mfblnBuscar_TipoAlmacen(PSTIPO, PSTIPONOMBRE)
                    If PSTIPONOMBRE = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim PSTIPO As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
            Dim PSTIPONOMBRE As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSTALMC
            Dim PSALMACEN As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL
            Dim PSALMACENNOMBRE As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL

            Call mfblnBuscar_TipoAlmacen(PSTIPO, PSTIPONOMBRE)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try
            Select Case e.KeyCode
                Case Keys.F4


                    Dim PSTIPO As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
                    Dim PSTIPONOMBRE As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSTALMC
                    Dim PSALMACEN As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL
                    Dim PSALMACENNOMBRE As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL

                    Call mfblnBuscar_Almacen("" & PSTIPO, PSALMACEN, PSALMACENNOMBRE)
                Case Keys.Delete
                    txtAlmacen.Limpiar()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtAlmacen.Tag = ""
    End Sub


    Private Sub CargarControlTipoAlmacen()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = UcPLanta_Cmb011.Planta  ' 1
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    'Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
    'Dim oListColum As New Hashtable
    'Dim oColumnas As New DataGridViewTextBoxColumn
    'oColumnas.Name = "CZNALM"
    'oColumnas.DataPropertyName = "PSCZNALM"
    'oColumnas.HeaderText = "Código"
    'oListColum.Add(1, oColumnas)
    'oColumnas = New DataGridViewTextBoxColumn
    'oColumnas.Name = "TCMZNA"
    'oColumnas.DataPropertyName = "PSTCMZNA"
    'oColumnas.HeaderText = "Zona Almacén "
    'oListColum.Add(2, oColumnas)
    'Dim obrAlmacen As New brAlmacen

    'End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            Dim PSTIPO As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
            Dim PSTIPONOMBRE As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSTALMC
            Dim PSALMACEN As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL
            Dim PSALMACENNOMBRE As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL

            If PSTIPONOMBRE = "" Then
                txtTipoAlmacen.Limpiar()
            Else
                If PSALMACENNOMBRE <> "" And "" & PSALMACEN = "" Then

                    Call mfblnBuscar_Almacen("" & PSTIPO, PSALMACEN, PSALMACENNOMBRE)
                    If PSALMACENNOMBRE = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim PSTIPO As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        Dim PSTIPONOMBRE As String = CType(txtTipoAlmacen.Resultado, beAlmacen).PSTALMC
        Dim PSALMACEN As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL
        Dim PSALMACENNOMBRE As String = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL

        Call mfblnBuscar_Almacen("" & PSTIPO, PSALMACEN, PSALMACENNOMBRE)
    End Sub

    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click
        Try
            Dim msg As String = ""
            If txtTipoAlmacen.Resultado Is Nothing Then
                msg = "Seleccione tipo Almacén" & Chr(13)
            End If
            If txtAlmacen.Resultado Is Nothing Then
                msg = msg & "Seleccione  Almacén"
            End If
            msg = msg.Trim
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim frm As New frmEPosiciones
            Dim oBE As New beUbicacion
            oBE.PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM.Trim
            oBE.PSTIPO = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM.Trim
            oBE.PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC.Trim
            oBE.PSALMACEN = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL.Trim
            frm.Tag = oBE
            frm.IdPlanta = Me.UcPLanta_Cmb011.Planta
            frm.IsNuevo = True
            frm.ShowDialog()
            btnActualizar_Click(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click

        Try
            If dgPosiciones.CurrentRow IsNot Nothing Then
                Dim frm As New frmEPosiciones
                frm.IsNuevo = False
                Dim obeUb As beUbicacion = dgPosiciones.CurrentRow.DataBoundItem
                'obeUb.PSTIPO = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
                'obeUb.PSALMACEN = CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL
                'frm.IdPlanta = Me.UcPLanta_Cmb011.Planta
                frm.IdPlanta = dgPosiciones.CurrentRow.Cells("PNCPLNFC").Value
                frm.Tag = obeUb
                frm.ShowDialog()

                btnActualizar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If dgPosiciones.CurrentRow Is Nothing Then Exit Sub
            If MessageBox.Show("Esta seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim obr As New brUbicacion()
                Dim obj As beUbicacion = dgPosiciones.CurrentRow.DataBoundItem
                obr.Delete(obj.PSCTPALM, obj.PSCALMC, obj.PSCSECTR, obj.PSCPSCN)
                MessageBox.Show("El registro se eliminó satisfactiroamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnActualizar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        ''If String.IsNullOrEmpty(txtCliente.pCodigo) = False And String.IsNullOrEmpty(txtTipoAlmacen.Tag) = False And String.IsNullOrEmpty(txtAlmacen.Tag) = False Then
        'Dim rpt As New rptListadoSloting
        'Dim oBR As New brSugerenciaMercaderia()
        ''rpt.SetDataSource(oBR.ListarReporte(txtCliente.pCodigo, txtTipoAlmacen.Tag, txtAlmacen.Tag))
        'Dim frmRPT As New frmVisorRPT(rpt)
        'frmRPT.Show()
        'End If
    End Sub

    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Close()
    End Sub

    Private Sub dgSloting_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgPosiciones.ColumnHeaderMouseClick
        If dgPosiciones.RowCount = 0 Then Exit Sub
        Dim olbeUbicacion As New List(Of beUbicacion)
        olbeUbicacion = dgPosiciones.DataSource
        Dim oucOrdena As UCOrdena(Of beUbicacion)
        oucOrdena = New UCOrdena(Of beUbicacion)(Me.dgPosiciones.Columns(e.ColumnIndex).Name, UCOrdena(Of beUbicacion).TipoOrdenacion.Ascendente)
        olbeUbicacion.Sort(oucOrdena)
        Me.dgPosiciones.DataSource = olbeUbicacion
        Me.dgPosiciones.Refresh()
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UCPaginacion.PageChanged
        btnActualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub btnImprimirPosiciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPosiciones.Click
        For Each obj As DataGridViewRow In Me.dgPosiciones.SelectedRows
            ImpresionEtiquetasSDS.Posiciones(obj.Cells(2).Value.ToString())
        Next
    End Sub

    Private Sub dgPosiciones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPosiciones.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = 9 Then
            Dim obe As beUbicacion = dgPosiciones.CurrentRow.DataBoundItem
            With obe
                If Not String.IsNullOrEmpty(.PSTMRCD2) Then
                    frmDPosiciones.Show(.PSCTPALM, .PSCALMC, .PSCSECTR, .PSCPSCN, .PNCCLNRN)
                End If
            End With
        End If
    End Sub

#End Region



    Private Sub brnCargamasiva_Click(sender As Object, e As EventArgs) Handles brnCargamasiva.Click
        Try
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim ofrmCargaMasivaPosicion As New frmCargaMasivaPosicion
            ofrmCargaMasivaPosicion.pCliente = txtCliente.pCodigo
            ofrmCargaMasivaPosicion.pCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmCargaMasivaPosicion.ShowDialog()
            If ofrmCargaMasivaPosicion.Procesamiento = True Then
                listarUbicacion()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(objData As Object)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            listarUbicacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)

            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Poisiciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Posiciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Listado Posiciones"))



            Dim dtExport As New DataTable
            For Each item As DataGridViewColumn In dgPosiciones.Columns
                If item.Visible = True And item.Name <> "BTN" And item.HeaderText <> "" Then
                    dtExport.Columns.Add(item.Name)
                End If
            Next


            Dim dr As DataRow
            For Each item As DataGridViewRow In dgPosiciones.Rows
                dr = dtExport.NewRow
                For Each ItemColumna As DataColumn In dtExport.Columns
                    If dgPosiciones.Columns(ItemColumna.ColumnName) IsNot Nothing Then
                        dr(ItemColumna.ColumnName) = item.Cells(ItemColumna.ColumnName).Value
                    End If
                Next
                dtExport.Rows.Add(dr)
            Next


            For Each Item As DataColumn In dtExport.Columns
                If dgPosiciones.Columns(Item.ColumnName) IsNot Nothing Then
                    If dgPosiciones.Columns(Item.ColumnName).HeaderText <> "" Then
                        Item.ColumnName = dgPosiciones.Columns(Item.ColumnName).HeaderText
                    End If

                End If

            Next
            dtExport.TableName = "Listado"
            ODs.Tables.Add(dtExport.Copy)
            'objDt = CType(Me.dgPosiciones.DataSource, DataTable).Copy
            'ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgPosiciones, objDt))

            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

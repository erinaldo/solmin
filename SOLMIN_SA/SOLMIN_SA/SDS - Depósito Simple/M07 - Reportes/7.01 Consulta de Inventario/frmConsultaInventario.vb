Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
'Imports Ransa.TypeDef.Cliente
Imports RANSA.TYPEDEF.Mercaderia
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmConsultaInventario
    Private CCLNT_COD As Int64 = 0
#Region "EventosFiltro"
    Private Sub txtFamilia_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFamilia.Validating
        Try
            If txtFamilia.Text = "" Then
                txtFamilia.Tag = ""
                Exit Sub
            Else
                If txtFamilia.Text <> "" And "" & txtFamilia.Tag = "" Then
                    Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
                    If txtFamilia.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtGrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrupo.TextChanged
        txtGrupo.Tag = ""
    End Sub

    Private Sub txtGrupo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGrupo.Validating
        Try
            If txtGrupo.Text = "" Then
                txtGrupo.Tag = ""
                Exit Sub
            Else
                If txtGrupo.Text <> "" And "" & txtGrupo.Tag = "" Then
                    Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
                    If txtGrupo.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtFamilia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
            Else
                Call pMercadería_KeyDown(e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtGrupo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrupo.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
            Else
                Call pMercadería_KeyDown(e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub pMercadería_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaFamiliaListar.Click
        Try
            Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bsaGrupoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGrupoListar.Click
        Try
            Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub


#End Region

    Private Sub BuscarMercaderiasCliente()
        Try
            txtFiltroMercaderia.Text = txtFiltroMercaderia.Text.Trim
            Dim obeMercaderia As New beMercaderia()
            Dim oblInventarioMercaderia As New blInventarioMercaderia()
            Dim strCliente As String = ""
            Dim ds As New DataSet()
            dgMercaderias.DataSource = Nothing
            If (txtCliente.pCodigo = 0) Then
                MessageBox.Show("Seleccione el cliente", "Filtros", MessageBoxButtons.OK)
                Exit Sub
            End If
            CCLNT_COD = txtCliente.pCodigo ' guarda el cliente de busqueda temporalmente
            obeMercaderia.PNCCLNT = txtCliente.pCodigo
            If (txtGrupo.Tag Is Nothing Or String.IsNullOrEmpty(txtGrupo.Tag)) Then
                obeMercaderia.PSCGRCLR = ""
            Else
                obeMercaderia.PSCGRCLR = txtGrupo.Tag
            End If
            If (txtFamilia.Tag Is Nothing Or String.IsNullOrEmpty(txtFamilia.Tag)) Then
                obeMercaderia.PSCFMCLR = ""
            Else
                obeMercaderia.PSCFMCLR = txtFamilia.Tag
            End If

            If (("" & txtFiltroMercaderia.Text & "").Trim.Length) < 20 Then
                obeMercaderia.PSCMRCLR = txtFiltroMercaderia.Text
            Else
                obeMercaderia.PSCMRCLR = txtFiltroMercaderia.Text.Trim.Substring(0, 20)
            End If

            obeMercaderia.PSTMRCD2 = txtFiltroMercaderia.Text.Trim

            obeMercaderia.PageSize = UcPaginacionMercaderia.PageSize
            obeMercaderia.PageNumber = UcPaginacionMercaderia.PageNumber
            dgMercaderias.DataSource = oblInventarioMercaderia.ListarMercaderiaxClientexGrupoxFamilia(obeMercaderia)

            If TryCast(dgMercaderias.DataSource, List(Of beMercaderia)).Count > 0 Then
                UcPaginacionMercaderia.PageCount = TryCast(dgMercaderias.DataSource, List(Of beMercaderia)).Item(0).PageCount
              
            End If

            VisualizarOrdenesServicioxMercaderia()
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub txtFamilia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFamilia.TextChanged
        txtFamilia.Tag = ""
    End Sub
 

    Private Sub frmConsultaInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objAppConfig As cAppConfig = New cAppConfig
            Dim intTemp As Int64 = 0
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            dgMercaderias.AutoGenerateColumns = False
            dgMercaderiaGuia.AutoGenerateColumns = False
            Validar_Usuario_Autoridado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
 
    End Sub


    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New brUsuario
        Dim objEntidad As New beUsuario

        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objSeguridadBN.pUsuario)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)

        If objEntidad.STSOP1 = "" Then
            btnUbicacion.Visible = False
            btnUbicarDespacho.Visible = False
            btnUbicarIngreso.Visible = False
            tss04.Visible = False
            tss03.Visible = False
            tss02.Visible = False
        Else
            btnUbicacion.Visible = True
            btnUbicarDespacho.Visible = True
            btnUbicarIngreso.Visible = True
            tss04.Visible = True
            tss03.Visible = True
            tss02.Visible = True
        End If
        If objEntidad.STSOP2 = "" Then
            btnSerie.Visible = False
            tss01.Visible = False
        Else
            btnSerie.Visible = True
            tss01.Visible = True
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If (e.KeyChar = ChrW(13)) Then
                UcPaginacionMercaderia.PageNumber = 1
                BuscarMercaderiasCliente()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If (e.KeyChar = ChrW(13)) Then
                UcPaginacionMercaderia.PageNumber = 1
                BuscarMercaderiasCliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            UcPaginacionMercaderia.PageNumber = 1
            BuscarMercaderiasCliente()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try

            'Mostrando el form que imprimira la Etiqueta
            Dim objFrm As New frmTipoEtiqueta

            Dim TCMPCL As String
            TCMPCL = dgMercaderias.CurrentRow.Cells("PSTCMPCL").Value

            objFrm.ShowDialog(Me)

            If objFrm.Accept = True Then

                'Algoritomo para imprimir posiciones    
                Dim cantidad As Integer = objFrm.cantidad

                For Each obj As DataGridViewRow In Me.dgMercaderias.SelectedRows
                    For i As Integer = 1 To cantidad
                        If objFrm.TipoEtiqueta = "NORMAL" Then
                            ImpresionEtiquetasSDS.Mercaderia(obj.Cells(0).Value.ToString(), obj.Cells(1).Value.ToString(), Me.txtCliente.pCodigo)
                        Else 'MERCADERIA
                            ImpresionEtiquetasSDS.Mercaderia_6x4(obj.Cells(0).Value.ToString(), obj.Cells(1).Value.ToString(), objSeguridadBN.pUsuario, objFrm.Referencia, "" & CType(dgMercaderias.CurrentRow.DataBoundItem, beMercaderia).PSUNIDAD & "", objFrm.CantUnidad, Me.txtCliente.pCodigo, objFrm.NroOC, objFrm.Ubicacion, objFrm.vs_almacen, "", TCMPCL, objFrm.Lote)
                        End If
                    Next
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtFiltroMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroMercaderia.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                UcPaginacionMercaderia.PageNumber = 1
                BuscarMercaderiasCliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub dgMercaderias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderias.CellClick
        Try
            VisualizarOrdenesServicioxMercaderia()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub VisualizarOrdenesServicioxMercaderia()
        Try
            Dim obeMercaderia As New beMercaderia
            dgMercaderiaGuia.DataSource = Nothing
            obeMercaderia.PNCCLNT = Val(("" & dgMercaderias.CurrentRow.Cells("PNCCLNT").Value).ToString.Trim)
            obeMercaderia.PSCMRCLR = ("" & dgMercaderias.CurrentRow.Cells("PSCMRCLR").Value).ToString.Trim
            dgMercaderiaGuia.AutoGenerateColumns = False
            dgMercaderiaGuia.DataSource = New blInventarioMercaderia().Lista_Orden_Servicio_por_Cliente(obeMercaderia)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub dgMercaderiaGuia_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgMercaderiaGuia.DataBindingComplete
        Try
            Dim numRegistros As Int64 = dgMercaderiaGuia.Rows.Count - 1
            Dim saldoInventario As Int64 = 0
            Dim saldoSerie As Int64 = 0
            Dim saldoUbicacion As Int64 = 0
            For index As Integer = 0 To numRegistros
                saldoInventario = Val("" & dgMercaderiaGuia.Item("CANTIDAD_ALM", index).Value)
                saldoSerie = Val("" & dgMercaderiaGuia.Item("QSERIES", index).Value)
                saldoUbicacion = Val("" & dgMercaderiaGuia.Item("QUBICACION", index).Value)
                If (saldoSerie <> saldoInventario And saldoSerie <> 0) Then
                    dgMercaderiaGuia.Item("QSERIES", index).Style.ForeColor = Color.Red
                End If
                If (saldoUbicacion <> saldoInventario And saldoUbicacion <> 0) Then
                    dgMercaderiaGuia.Item("QUBICACION", index).Style.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgMercaderiaGuia_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderiaGuia.CellDoubleClick

        Try
            If dgMercaderiaGuia.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            Dim obeMercaderia As New beMercaderia()
            If (e.ColumnIndex = 12) Then
                obeMercaderia.PNNORDSR = Val(("" & dgMercaderiaGuia.CurrentRow.Cells("NORDSR").Value).ToString.Trim)
                obeMercaderia.PNCCLNT = txtCliente.pCodigo
                Dim ofrmInventarioSerie As New frmInventarioSerie()
                ofrmInventarioSerie.obeMercaderia = obeMercaderia
                ofrmInventarioSerie.ShowDialog(Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UcPaginacionMercaderia_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionMercaderia.PageChanged
        Try
            BuscarMercaderiasCliente()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgMercaderias_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgMercaderias.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Up, Keys.Down, Keys.Enter
                    VisualizarOrdenesServicioxMercaderia()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgMercaderias_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgMercaderias.DataBindingComplete
        Try
            Dim numRegistros As Int64 = dgMercaderias.Rows.Count - 1
            Dim saldoInventario As Int64 = 0
            Dim saldoSerie As Int64 = 0
            Dim saldoUbicacion As Int64 = 0
            For index As Integer = 0 To numRegistros
                saldoInventario = Val("" & dgMercaderias.Item("PNSALDO_QSLMC", index).Value)
                saldoSerie = Val("" & dgMercaderias.Item("PNQSERIESXMERCADERIA", index).Value)
                saldoUbicacion = Val("" & dgMercaderias.Item("PNQUBICADOSXMERCADERIA", index).Value)
                If (saldoSerie <> saldoInventario And saldoSerie <> 0) Then
                    dgMercaderias.Item("PNQSERIESXMERCADERIA", index).Style.ForeColor = Color.Red
                End If
                If (saldoUbicacion <> saldoInventario And saldoUbicacion <> 0) Then
                    dgMercaderias.Item("PNQUBICADOSXMERCADERIA", index).Style.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        If (CCLNT_COD <> txtCliente.pCodigo) Then ' verifica que verdaderamente ha cambiado de cliente
            dgMercaderias.DataSource = Nothing
            dgMercaderiaGuia.DataSource = Nothing
        End If

    End Sub

    Private Sub btnSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSerie.Click

        Try
            If (dgMercaderiaGuia.Rows.Count = 0) Then
                MessageBox.Show("No se ha seleccionado ninguna Orden de Servicio")
                Exit Sub
            End If
            Dim obeMercaderia As New beMercaderia()
            obeMercaderia.PNNORDSR = Val(("" & dgMercaderiaGuia.CurrentRow.Cells("NORDSR").Value).ToString.Trim)
            obeMercaderia.PNCCLNT = txtCliente.pCodigo
            Dim ofrmSerieConsulta As New frmSerieConsulta
            ofrmSerieConsulta.obeMercaderia = obeMercaderia
            ofrmSerieConsulta.ShowDialog(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbicacion.Click
        Try
            If (dgMercaderiaGuia.Rows.Count = 0) Then
                MessageBox.Show("No se ha seleccionado ninguna Orden de Servicio")
                Exit Sub
            End If
            Dim obeMercaderia As New beMercaderia()
            obeMercaderia.PNNORDSR = Val(("" & dgMercaderiaGuia.CurrentRow.Cells("NORDSR").Value).ToString.Trim)
            obeMercaderia.PNCCLNT = txtCliente.pCodigo
            Dim ofrmReubicacionConsulta As New frmReubicacionConsulta
            ofrmReubicacionConsulta.obeMercaderia = obeMercaderia
            ofrmReubicacionConsulta.ShowDialog(Me)
            If (ofrmReubicacionConsulta.myDialogResult = Windows.Forms.DialogResult.OK) Then
                UcPaginacionMercaderia.PageNumber = 1
                BuscarMercaderiasCliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub btnInvPosicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If (txtCliente.pCodigo = 0) Then
    '            MessageBox.Show("Seleccione Cliente", "Reporte Inventario por Posición", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        Dim ofrmConsultaPosicion As New frmConsultaPosicion()
    '        ofrmConsultaPosicion.CCLNT = txtCliente.pCodigo
    '        ofrmConsultaPosicion.ShowDialog(Me)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnUbicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbicarDespacho.Click
        Try
            If (dgMercaderiaGuia.Rows.Count = 0) Then
                MessageBox.Show("No se ha seleccionado ninguna Orden de Servicio")
                Exit Sub
            End If
            Dim obeMercaderia As New beMercaderia()
            'obeMercaderia.PNNORDSR = Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PNNORDSR
            'obeMercaderia.PNCCLNT = txtCliente.pCodigo
            Dim OfrmMantUbicacion As New frmMantUbicacion
            OfrmMantUbicacion.IdPlanta = Me.UcPLanta_Cmb011.Planta
            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PNCCLNT = txtCliente.pCodigo
            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSCTPALM = "AX"
            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSCALMC = "AB"
            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSTIPO = "DES"

            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSUSUARIO = objSeguridadBN.pUsuario
            OfrmMantUbicacion.obeMercaderia = Me.dgMercaderiaGuia.CurrentRow.DataBoundItem
            OfrmMantUbicacion.Text = "Ubicación - Despacho"
            OfrmMantUbicacion.ShowDialog(Me)
            If (OfrmMantUbicacion.DialogResult = Windows.Forms.DialogResult.OK) Then
                UcPaginacionMercaderia.PageNumber = 1
                BuscarMercaderiasCliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUbicarIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbicarIngreso.Click
        Try
            If (dgMercaderiaGuia.Rows.Count = 0) Then
                MessageBox.Show("No se ha seleccionado ninguna Orden de Servicio")
                Exit Sub
            End If
            Dim obeMercaderia As New beMercaderia()
            'obeMercaderia.PNNORDSR = Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PNNORDSR
            'obeMercaderia.PNCCLNT = txtCliente.pCodigo
            Dim OfrmMantUbicacion As New frmMantUbicacion
            OfrmMantUbicacion.IdPlanta = Me.UcPLanta_Cmb011.Planta
            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PNCCLNT = txtCliente.pCodigo
            'Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSCTPALM = "AX"
            'Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSCALMC = "AB"
            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSTIPO = "ING"
            Me.dgMercaderiaGuia.CurrentRow.DataBoundItem.PSUSUARIO = objSeguridadBN.pUsuario
            OfrmMantUbicacion.obeMercaderia = Me.dgMercaderiaGuia.CurrentRow.DataBoundItem
            OfrmMantUbicacion.Text = "Ubicación - Ingreso"
            OfrmMantUbicacion.ShowDialog(Me)
            If (OfrmMantUbicacion.DialogResult = Windows.Forms.DialogResult.OK) Then
                UcPaginacionMercaderia.PageNumber = 1
                BuscarMercaderiasCliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProyecto.Click
        If Me.dgMercaderiaGuia.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmInventarioProyecto As New frmInventarioProyecto
        ofrmInventarioProyecto.OrdenServicio = Val(("" & dgMercaderiaGuia.CurrentRow.Cells("NORDSR").Value))
        ofrmInventarioProyecto.ShowDialog()
    End Sub

    Private Sub btnLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLote.Click
        Try
            If dgMercaderiaGuia.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            Dim obeMercaderia As New beMercaderia()
            'If (e.ColumnIndex = 12) Then
            obeMercaderia.PNNORDSR = Val(("" & dgMercaderiaGuia.CurrentRow.Cells("NORDSR").Value).ToString.Trim)
            obeMercaderia.PSCMRCLR = dgMercaderiaGuia.CurrentRow.Cells("CMRCLR").Value
            obeMercaderia.PNCCLNT = txtCliente.pCodigo
            Dim ofrmRegularizarLote As New frmRegularizarLote()
            ofrmRegularizarLote.obeMercaderia = obeMercaderia
            ofrmRegularizarLote.ShowDialog(Me)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
End Class

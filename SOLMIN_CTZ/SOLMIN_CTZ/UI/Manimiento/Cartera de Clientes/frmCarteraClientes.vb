Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades


Public Class frmCarteraClientes

    Private brRegionVenta As clsRegionVenta


    Private Sub frmCarteraClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dtgGrupoCliente.AutoGenerateColumns = False
            dtgContratos.AutoGenerateColumns = False
            dtgRelacionCliente.AutoGenerateColumns = False
            ucCompania.Usuario = ConfigurationWizard.UserName

            CargaEstado()

            brRegionVenta = New clsRegionVenta
            brRegionVenta.Crea_Lista()

            ucCompania.pActualizar()
            ucCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            MostrarMesesXAnio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaEstado()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("COD")
        dtEstado.Columns.Add("DESC")

        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("COD") = ""
        dr("DESC") = "Todos"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("COD") = "A"
        dr("DESC") = "Activo"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("COD") = "C"
        dr("DESC") = "Cerrado"
        dtEstado.Rows.Add(dr)

        cboEstado.DataSource = dtEstado
        cboEstado.DisplayMember = "DESC"
        cboEstado.ValueMember = "COD"
        cboEstado.SelectedValue = "A"
    End Sub

    'cboEstado

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim ofrmMantGrupoCliente As New frmMantGrupoCliente
            ofrmMantGrupoCliente.pCCMPN = ucCompania.CCMPN_CodigoCompania
            ofrmMantGrupoCliente.CRGVTA = UcCliente.pNegocio
            If ofrmMantGrupoCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
                BucarGrupoCliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            UcPaginacion1.PageNumber = 1
            BucarGrupoCliente()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If dtgGrupoCliente.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Try
            Dim ofrmMantGrupoCliente As New frmMantGrupoCliente
            Dim obeCliente As New Cliente
            obeCliente = CType(dtgGrupoCliente.CurrentRow.DataBoundItem, Cliente)
            ofrmMantGrupoCliente.pCCMPN = obeCliente.CCMPN
            With ofrmMantGrupoCliente.oGrupoCliente
                .DESCAR = obeCliente.DESCAR.ToString.Trim
                .NOMCAR = obeCliente.NOMCAR.ToString.Trim
                .NRCTCL = obeCliente.NRCTCL
                .CRGVTA = obeCliente.CRGVTA
            End With
            If ofrmMantGrupoCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
                BucarGrupoCliente()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dtgGrupoCliente.CurrentCellAddress.Y = -1 Then Exit Sub
            If MsgBox("Está seguro que desea anular/cerrar este registro ?.", MsgBoxStyle.YesNo, "Mensaje De Información") = MsgBoxResult.Yes Then
                'Try
                Dim obrCliente As New clsCliente
                Dim msg As String = ""
                Dim pobjCliente As New Cliente
                pobjCliente.NRCTCL = dtgGrupoCliente.CurrentRow.Cells("NRCTCL").Value
                pobjCliente.CCMPN = dtgGrupoCliente.CurrentRow.Cells("CCMPN").Value

                msg = obrCliente.Eliminar_Cliente_Cartera(pobjCliente)
                'If obrCliente.Eliminar_Cliente_Cartera(Me.dtgGrupoCliente.CurrentRow.DataBoundItem) = -1 Then
                If msg.Length > 0 Then
                    'MsgBox("No se puede Anular, el registro cuenta con contratos y tarifas.", MsgBoxStyle.Information, "Mensaje De Información")
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    BucarGrupoCliente()
                End If

                '        Catch ex As Exception
                '    Throw New Exception(ex.Message)
                'End Try
            Else
                MsgBox("El registro no fue ANULADO.", MsgBoxStyle.Information, "Mensaje De Información")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub btnAgregarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDet.Click
        Try

            If dtgGrupoCliente.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Select Case TabGrupoClientes.SelectedTab.Name
                Case "tabClientes"
                    Dim ofrmAgregar As New frmAgregarCliente
                    Dim obeCliente As New Cliente
                    obeCliente = CType(dtgGrupoCliente.CurrentRow.DataBoundItem, Cliente)
                    ofrmAgregar.pCCMPN = obeCliente.CCMPN
                    ofrmAgregar.NRCTCL = obeCliente.NRCTCL
                    '<[AHM]>
                    ofrmAgregar.pCRGVTA = obeCliente.CRGVTA
                    ofrmAgregar.pCodigoCompania = ucCompania.CCMPN_CodigoCompania
                    '</[AHM]>
                    If ofrmAgregar.ShowDialog = Windows.Forms.DialogResult.OK Then
                        CargarDetalle()
                    End If
                Case "tabContratos"
                    AgregarContrato()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnModificarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDet.Click
        Try
            If Me.dtgContratos.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim ofrmMantContrato As New frmMantContratos
            Dim beContrato As SOLMIN_CTZ.Entidades.Contrato
            beContrato = CType(Me.dtgContratos.CurrentRow.DataBoundItem, SOLMIN_CTZ.Entidades.Contrato)
            ofrmMantContrato.NRCTCL = CType(Me.dtgGrupoCliente.CurrentRow.DataBoundItem, SOLMIN_CTZ.Entidades.Cliente).NRCTCL
            ofrmMantContrato.NRCTSL = beContrato.NRCTSL
            ofrmMantContrato.SESTRG = beContrato.SESTRG
            ofrmMantContrato.CCMPN = beContrato.CCMPN
            If ofrmMantContrato.ShowDialog = Windows.Forms.DialogResult.OK Then
                CargarDetalle()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEliminarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDet.Click
        Try
            Select Case TabGrupoClientes.SelectedTab.Name
                Case "tabClientes"
                    AnularRelacionCliente()
                Case "tabContratos"
                    EliminarContrato()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub AnularRelacionCliente()
        If dtgRelacionCliente.CurrentCellAddress.Y = -1 Then Exit Sub

        Dim ClienteRelacion As Integer = Me.dtgRelacionCliente.CurrentRow.Cells("CCLNT_R").Value
        Dim GrupoRelacion As Integer = Me.dtgRelacionCliente.CurrentRow.Cells("NRCTCL_R").Value

        If MsgBox("Está seguro que desea ANULAR este relación ? " & Chr(10) & "Cliente: " & CStr(ClienteRelacion) & _
                    " - Grupo: " & CStr(GrupoRelacion), MsgBoxStyle.YesNo, "Mensaje De Información") = MsgBoxResult.Yes Then
            'Try
            Dim obrCliente As New clsCliente
            Dim msg As String = ""
            'obrCliente.Eliminar_Cliente_Cartera_Relacion(Me.dtgRelacionCliente.CurrentRow.DataBoundItem)
             
            Dim oClienteEnt As New SOLMIN_CTZ.Entidades.Cliente
            'oClienteEnt = Me.dtgRelacionCliente.CurrentRow.DataBoundItem
            oClienteEnt.CCMPN = dtgGrupoCliente.CurrentRow.Cells("CCMPN").Value
            oClienteEnt.NRCTCL = dtgRelacionCliente.CurrentRow.Cells("NRCTCL_R").Value
            oClienteEnt.CCLNT = dtgRelacionCliente.CurrentRow.Cells("CCLNT_R").Value
            msg = obrCliente.Eliminar_Cliente_Cartera_Relacion_V2(oClienteEnt)
            'msg = obrCliente.Eliminar_Cliente_Cartera_Relacion_V2(Me.dtgRelacionCliente.CurrentRow.DataBoundItem)
            If msg.Length > 0 Then
                MessageBox.Show("No se puede anular" & Chr(10) & msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MsgBox("La relación fue anulada.", MsgBoxStyle.Information, "Mensaje De Información")
                CargarDetalle()
            End If

            'Catch : End Try

        End If

    End Sub

    Private Sub btnAgregarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListarTarifa()
    End Sub

    Private Sub btnAgregarBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListarBitacora()
    End Sub

    Private Sub TaClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabGrupoClientes.SelectedIndexChanged
        Select Case TabGrupoClientes.SelectedTab.Name
            Case "tabClientes"
                tsS04.Visible = False
                btnAgregarDet.Visible = True
                tsS05.Visible = True
                btnModificarDet.Visible = False
                tsS04.Visible = False
                btnEliminarDet.Visible = True
                tsS03.Visible = True
                tsExportarExcel.Visible = False
                tsS07.Visible = False
                btnAdjuntarIMG.Visible = False
                tsS07.Visible = False
            Case "tabContratos"
                tsS04.Visible = True
                btnAgregarDet.Visible = True
                tsS05.Visible = True
                btnModificarDet.Visible = True
                tsS04.Visible = True
                btnEliminarDet.Visible = True
                tsS03.Visible = True
                tsExportarExcel.Visible = False
                tsS07.Visible = False
                btnAdjuntarIMG.Visible = True
                tsS07.Visible = True

            Case "TabVentas"
                btnAgregarDet.Visible = False
                tsS05.Visible = False
                btnModificarDet.Visible = False
                tsS04.Visible = False
                btnEliminarDet.Visible = False
                tsS03.Visible = False

                tsExportarExcel.Visible = True
                tsS07.Visible = True
                btnAdjuntarIMG.Visible = False
                tsS07.Visible = False
        End Select

    End Sub

    Private Sub AgregarContrato()
        If ucCompania.CCMPN_CodigoCompania = "" Then
            MsgBox("* El usuario no tiene permiso para ninguna empresa", MessageBoxButtons.OK)
            Exit Sub
        End If

        If dtgGrupoCliente.CurrentRow Is Nothing Then
            Exit Sub
        End If
        If dtgRelacionCliente.Rows.Count = 0 Then
            CargarRelacionCliente()
        End If
        If dtgRelacionCliente.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar algún cliente relacionado con el grupo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim obeCliente As New Cliente
        obeCliente = CType(dtgGrupoCliente.CurrentRow.DataBoundItem, Cliente)

        Dim ofrmMantContrato As New frmMantContratos
        ofrmMantContrato.NRCTCL = obeCliente.NRCTCL
        ofrmMantContrato.SESTRG = "P"
        ofrmMantContrato.CCMPN = obeCliente.CCMPN
        If ofrmMantContrato.ShowDialog = Windows.Forms.DialogResult.OK Then
            CargarDetalle()
        End If
    End Sub

    Private Sub EliminarContrato()
        If Me.dtgContratos.CurrentCellAddress.Y = -1 Then Exit Sub
        If HelpClass.RspMsgBox("Está seguro de eliminar el contrato ?") = Windows.Forms.DialogResult.Yes Then
            'Try
            Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
            Dim obrContrato As New clsContrato
            Dim beContrato As SOLMIN_CTZ.Entidades.Contrato
            beContrato = CType(Me.dtgContratos.CurrentRow.DataBoundItem, SOLMIN_CTZ.Entidades.Contrato)
            With oContrato
                .NRCTSL = beContrato.NRCTSL
                .SESTRG = "*"
                .CCMPN = beContrato.CCMPN
            End With
            If obrContrato.fintEliminarContrato(oContrato) = -1 Then
                MsgBox("No se puede Eliminar, el registro cuenta con tarifas.", MsgBoxStyle.Information, "Mensaje De Información")
            End If
            CargarDetalle()
            'Catch ex As Exception
            '    HelpClass.ErrorMsgBox()
            'End Try
        End If
    End Sub


    Private Sub ListarTarifa()
        If Me.dtgContratos.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmListaTarifa As New frmListaTarifas
        ofrmListaTarifa.oContrato = Me.dtgContratos.CurrentRow.DataBoundItem
        With ofrmListaTarifa.oContrato
            .CCMPN = Me.dtgGrupoCliente.CurrentRow.DataBoundItem.CCMPN
            .NRCTCL = Me.dtgGrupoCliente.CurrentRow.DataBoundItem.NRCTCL
            .DESCAR = Me.dtgGrupoCliente.CurrentRow.DataBoundItem.DESCAR
            .CRGVTA = Me.dtgGrupoCliente.CurrentRow.DataBoundItem.CRGVTA

        End With
        ofrmListaTarifa.MdiParent = Me.Parent.Parent
        ofrmListaTarifa.WindowState = FormWindowState.Maximized
        ofrmListaTarifa.pTipoEnumForm = frmListaTarifas.EnumTIPO_FORM.EDICION
        ofrmListaTarifa.pCodigoCompania = ucCompania.CCMPN_CodigoCompania
        ofrmListaTarifa.Show()
    End Sub

    Private Sub ListarBitacora()
        If Me.dtgContratos.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmListaBitacora As New frmListarBitacora
        ofrmListaBitacora.oContrato = Me.dtgContratos.CurrentRow.DataBoundItem
        If ofrmListaBitacora.ShowDialog = Windows.Forms.DialogResult.OK Then
            CargarDetalle()
        End If
    End Sub

    Private Sub BucarGrupoCliente()
        dtgGrupoCliente.DataSource = Nothing
        Dim oCliente As New clsCliente
        Dim obeCliente As New Cliente
        With obeCliente
            .CCLNT = Me.UcCliente.pCodigo
            .NRCTCL = Me.UcClienteGrupo.pCodigoGrupo
            .CCMPN = ucCompania.CCMPN_CodigoCompania
            .SESTRG = cboEstado.SelectedValue
            .LIST_CRGVTA = ListaRegionVentaSeleccionado()
            .NROPAG = UcPaginacion1.PageNumber
            .PageSize = UcPaginacion1.PageSize
        End With
        Limpiar()

        Dim TotalPag As Decimal = 0    
        Dim List As New List(Of Cliente)
        List = oCliente.floListaCarteCliente(obeCliente, TotalPag)
        UcPaginacion1.PageCount = TotalPag
        dtgGrupoCliente.DataSource = List
        'dtgGrupoCliente.DataSource = oCliente.floListaCarteCliente(obeCliente, TotalPag)

    End Sub


    Private Function ListaRegionVentaSeleccionado() As String
        Dim IsTodos As Boolean = False
        Dim Lista As String = ""
        For i As Integer = 0 To cmbRegionVenta.CheckedItems.Count - 1
            If cmbRegionVenta.CheckedItems(i).Value = "-1" Then
                IsTodos = True
                Exit For
            End If
            Lista += cmbRegionVenta.CheckedItems(i).Value & ","
        Next
        If IsTodos = True Then
            Lista = "-1,"
        End If
        If Lista.Trim.Length > 0 Then
            Lista = Lista.Trim.Substring(0, Lista.Trim.Length - 1)
        End If
        Return Lista

    End Function

    Private Sub dtgGrupoCliente_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgGrupoCliente.SelectionChanged
        Try
            Limpiar()
            CargarDetalle()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub CargarRelacionCliente()
        Dim oCliente As New clsCliente
        dtgRelacionCliente.DataSource = Nothing
        dtgRelacionCliente.DataSource = oCliente.floListaClienteXGrupo(Me.dtgGrupoCliente.CurrentRow.DataBoundItem)
    End Sub

    Private Sub CargarDetalle()
        Limpiar()

        If Me.dtgGrupoCliente.CurrentCellAddress.Y = -1 Then
            Exit Sub
        End If
        CargarRelacionCliente()

        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
        Dim obeCliente As New Cliente
        obeCliente = CType(dtgGrupoCliente.CurrentRow.DataBoundItem, Cliente)
        oContrato.NRCTCL = obeCliente.NRCTCL
        oContrato.CCMPN = obeCliente.CCMPN
        Dim obrContrato As New clsContrato
        'ByRef dtContrato_Clientes As DataTable
        Dim dtContrato_Clientes As New DataTable

        Dim oListContratos As New List(Of SOLMIN_CTZ.Entidades.Contrato)
        oListContratos = obrContrato.floListaContrato(oContrato, dtContrato_Clientes)

        Dim encontrado As Boolean = False
        For Each item As SOLMIN_CTZ.Entidades.Contrato In oListContratos

            If Me.UcCliente.pCodigo > 0 Then

                encontrado = ExisteCliente_x_Contrato(item.NRCTSL, Me.UcCliente.pCodigo, dtContrato_Clientes)
                If encontrado = True Then

                    Select Case item.SESTRG
                        Case "A"
                            item.ORDEN = 0
                        Case "P"
                            item.ORDEN = 1
                        Case Else
                            item.ORDEN = 2
                    End Select
                
                Else
                    item.ORDEN = 3
                End If

            Else

                Select Case item.SESTRG
                    Case "A"
                        item.ORDEN = 0
                    Case "P"
                        item.ORDEN = 1
                    Case Else
                        item.ORDEN = 2
                End Select

            End If

           
        Next
        Dim oucOrdena As Ransa.Utilitario.ucOrdenaS(Of SOLMIN_CTZ.Entidades.Contrato)
        Dim Orden As Ransa.Utilitario.ucOrdenaS(Of SOLMIN_CTZ.Entidades.Contrato).TiposOrden
        Orden = Ransa.Utilitario.ucOrdenaS(Of Global.SOLMIN_CTZ.Entidades.Contrato).TiposOrden.Ascendente
        oucOrdena = New Ransa.Utilitario.ucOrdenaS(Of SOLMIN_CTZ.Entidades.Contrato)("ORDEN", Orden, False)
        oListContratos.Sort(oucOrdena)


        Me.dtgContratos.DataSource = oListContratos

        'Me.dtgContratos.DataSource = obrContrato.floListaContrato(oContrato, dtContrato_Clientes)



        'CargarIndicadorVentaMensual()
    End Sub

    Private Function ExisteCliente_x_Contrato(pContrato As String, pBusqCliente As String, dt As DataTable) As Boolean
        Dim encontrado As Boolean = False
        Dim dr() As DataRow
        dr = dt.Select("NRCTSL='" & pContrato & "' and CCLNT='" & pBusqCliente & "'")
        If dr.Length > 0 Then
            encontrado = True
        End If
        Return encontrado
    End Function

    Private Function VeriricaTipoCambio() As String
        Dim msg As String = ""
        Dim clsCuentaCorriente As New clsCuentaCorriente
        Dim dt As New DataTable
        dt = clsCuentaCorriente.Lista_Tipo_Cambio_Actual(100)
        If dt.Rows.Count = 0 Then
            msg = "No hay tipo cambio a la Fecha"
        Else
            msg = ""
        End If
        Return msg
    End Function
    Private Sub CargarIndicadorVentaMensual()
        Dim msg As String = VeriricaTipoCambio()
        txtMensaje.Text = VeriricaTipoCambio()
        If txtMensaje.Text.Length > 0 Then
            Exit Sub
        End If
        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
        oContrato.NRCTCL = CType(Me.dtgGrupoCliente.CurrentRow.DataBoundItem, Cliente).NRCTCL
        oContrato.CCMPN = Me.ucCompania.CCMPN_CodigoCompania
        oContrato.FECINI = ndAnio.Value & IIf(Me.dbMes.SelectedValue.ToString.Length = 1, "0" & Me.dbMes.SelectedValue, Me.dbMes.SelectedValue) & "01"
        oContrato.FECFIN = ndAnio.Value & IIf(Me.dbMes.SelectedValue.ToString.Length = 1, "0" & Me.dbMes.SelectedValue, Me.dbMes.SelectedValue) & "31"
        Dim obrContrato As New clsContrato
        Me.dtgIndicadorMensual.AutoGenerateColumns = False
        Me.dtgIndicadorMensual.DataSource = obrContrato.Lista_IndicadorVentaMensual(oContrato)
    End Sub


    Private Function CargarIndicadorVentaMensualGeneral() As DataTable
        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
        Dim oDt As New DataTable
        oContrato.CCMPN = Me.ucCompania.CCMPN_CodigoCompania
        oContrato.FECINI = ndAnio.Value & IIf(Me.dbMes.SelectedValue.ToString.Length = 1, "0" & Me.dbMes.SelectedValue, Me.dbMes.SelectedValue) & "01"
        oContrato.FECFIN = ndAnio.Value & IIf(Me.dbMes.SelectedValue.ToString.Length = 1, "0" & Me.dbMes.SelectedValue, Me.dbMes.SelectedValue) & "31"
        Dim obrContrato As New clsContrato

        oDt = obrContrato.fdtListaIndicadorVentaMensualGeneral(oContrato)
        If oDt.Rows.Count > 0 Then
            Dim strCodigo As String = ""
            For intCont As Integer = 0 To oDt.Rows.Count - 1
                If strCodigo <> "" And strCodigo = oDt.Rows(intCont).Item("NRCTCL") Then
                    oDt.Rows(intCont).Item("NRCTCL") = ""
                    oDt.Rows(intCont).Item("DESCAR") = ""
                Else
                    strCodigo = oDt.Rows(intCont).Item("NRCTCL")
                End If

            Next
        End If
        Return oDt
    End Function


    Private Sub Llenar_Observaciones()
        'Try
        Dim obrContrato As New clsContrato
        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
        oContrato.NRCTCL = CType(Me.dtgGrupoCliente.CurrentRow.DataBoundItem, Cliente).NRCTCL

        Dim oDtObs As DataTable
        Dim intCont As Integer
        Dim strDato As String

        Me.Cursor = Cursors.WaitCursor
        oDtObs = obrContrato.Lista_Observacion_Cliente(oContrato)
        For intCont = 0 To Me.dtgContratos.Rows.Count - 1
            strDato = Buscar_Observaciones(oDtObs, Me.dtgContratos.Rows(intCont).Cells(0).Value)
            dtgContratos.Rows(intCont).Cells(7).Value = strDato
        Next intCont
        Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    HelpClass.MsgBox(ex.Message)
        'End Try
    End Sub

    Private Function Buscar_Observaciones(ByVal poDt As DataTable, ByVal pdblContrato As Double) As String
        Dim strCadena As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow

        oDr = poDt.Select("NRCTSL=" & pdblContrato)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                If oDr(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                    strCadena = strCadena & oDr(intCont).Item("TFCOBS").ToString.Trim & "  " & oDr(intCont).Item("TOBS").ToString.Trim.Replace(Chr(10), Chr(10) & "                 ")
                    If intCont < oDr.Length - 1 Then
                        strCadena = strCadena & Chr(10)
                    End If
                End If
            Next intCont
        End If
        Return strCadena
    End Function

    Private Sub dtgContratos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgContratos.CellDoubleClick
        Try
            If e.ColumnIndex = -1 Then Exit Sub
            Select Case Me.dtgContratos.Columns(e.ColumnIndex).Name
                Case "btnTarifa"
                    ListarTarifa()
                Case "btnBitacora"
                    ListarBitacora()
                Case "ImgDoc"
                    Try
                        Dim lobjSql As New SqlManager
                        Dim frm = New SIF.Control2005.User.FrmContrato
                        frm.strNumContrato = Me.dtgContratos.CurrentRow.Cells("NCNTRT").Value.ToString.ToUpper  ' (Nro Documento)
                        frm.strConnection = lobjSql.Conectar()
                        frm.ShowDialog()
                    Catch ex As Exception
                        HelpClass.ErrorMsgBox()
                    End Try

                Case "IMG"
                    'Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos
                    'ofrmAdjuntarDocumentos.PNCCLNT = 999 'Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                    'ofrmAdjuntarDocumentos.pCCMPN = ucCompania.CCMPN_CodigoCompania
                    'ofrmAdjuntarDocumentos.pNRCTSL = Me.dtgContratos.CurrentRow.Cells("NRCTSL").Value
                    'ofrmAdjuntarDocumentos.pNMRGIM = Me.dtgContratos.CurrentRow.DataBoundItem.NMRGIM
                    'ofrmAdjuntarDocumentos.pTABLE_NAME = "RZSC01"
                    'ofrmAdjuntarDocumentos.PSUSUARIO = ConfigurationWizard.UserName
                    'ofrmAdjuntarDocumentos.ShowDialog()
                    'dtgGrupoCliente_SelectionChanged(Nothing, Nothing)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub


    Private Sub MostrarMesesXAnio()
        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("idmes")
        odtMeses.Columns.Add("nombre")
        odtMeses.Rows.Clear()

        odtMeses.Rows.Add(New Object() {1, "Enero"})
        odtMeses.Rows.Add(New Object() {2, "Febrero"})
        odtMeses.Rows.Add(New Object() {3, "Marzo"})
        odtMeses.Rows.Add(New Object() {4, "Abril"})
        odtMeses.Rows.Add(New Object() {5, "Mayo"})
        odtMeses.Rows.Add(New Object() {6, "Junio"})
        odtMeses.Rows.Add(New Object() {7, "Julio"})
        odtMeses.Rows.Add(New Object() {8, "Agosto"})
        odtMeses.Rows.Add(New Object() {9, "Setiembre"})
        odtMeses.Rows.Add(New Object() {10, "Octubre"})
        odtMeses.Rows.Add(New Object() {11, "Noviembre"})
        odtMeses.Rows.Add(New Object() {12, "Diciembre"})
        dbMes.DataSource = odtMeses
        dbMes.ValueMember = "idmes"
        dbMes.DisplayMember = "nombre"
        Me.ndAnio.Value = Today.Year
        Me.dbMes.SelectedIndex = Today.Month - 1
    End Sub

    Private Sub dbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbMes.SelectedIndexChanged

        Try
            If Me.dtgGrupoCliente.CurrentCellAddress.Y = -1 Then
                Me.dtgIndicadorMensual.DataSource = Nothing
            Else
                CargarIndicadorVentaMensual()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub ndAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndAnio.ValueChanged

        Try
            If Me.dtgGrupoCliente.CurrentCellAddress.Y = -1 Then
                Me.dtgIndicadorMensual.DataSource = Nothing
            Else
                CargarIndicadorVentaMensual()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub
 

    Private Sub Limpiar()
        Me.dtgIndicadorMensual.DataSource = Nothing
        Me.dtgRelacionCliente.DataSource = Nothing
        Me.dtgContratos.DataSource = Nothing
    End Sub
    Private Sub exportarExcel(ByVal intTipo As Integer)
        Dim msg As String = VeriricaTipoCambio()
        txtMensaje.Text = VeriricaTipoCambio()
        If txtMensaje.Text.Length > 0 Then
            Exit Sub
        End If

        If Me.dtgIndicadorMensual.DataSource Is Nothing Then Exit Sub
        Dim oDs As New DataSet
        Dim mTitulos As New List(Of String)
        Dim oDt As New DataTable
        If intTipo = 1 Then
            oDt = Me.dtgIndicadorMensual.DataSource.Copy
            oDt.TableName = Me.TabVentas.Text
        Else
            oDt = CargarIndicadorVentaMensualGeneral()
            oDt.TableName = "Ventas en General"

            oDt.Columns("NRCTCL").ColumnName = "Código"
            oDt.Columns("DESCAR").ColumnName = "Grupo Cliente"
        End If

        oDt.Columns.Remove("CSRVNV")
        oDt.Columns("CDVSN").ColumnName = "División"
        oDt.Columns("TCMTRF").ColumnName = "Rubro"
        oDt.Columns("OPERACION").ColumnName = "Monto \n  Por revisar"
        oDt.Columns("REVISADOS").ColumnName = "Monto \n  Revisado"
        oDt.Columns("FACTURADOS").ColumnName = "Monto \n Facturado"
        oDt.Columns("TOTAL").ColumnName = "Total Monto"

        oDs.Tables.Add(oDt)
        mTitulos.Add("\n Compañia :" & Me.ucCompania.CCMPN_Descripcion)
        If intTipo = 1 Then
            mTitulos.Add("\n Grupo de Cliente :" & Me.dtgGrupoCliente.CurrentRow.DataBoundItem.DESCAR.ToString.Trim)
        End If
        mTitulos.Add("\n Año :" & Me.ndAnio.Value)
        mTitulos.Add("\n Mes :" & Me.dbMes.Text)
        Dim lSuma As New Hashtable
        If intTipo = 2 Then
            lSuma.Add("suma1", 5)
            lSuma.Add("suma2", 6)
            lSuma.Add("suma3", 7)
            lSuma.Add("suma4", 8)
        End If

        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, mTitulos, lSuma)
    End Sub


    Private Sub VentasDelGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasDelGrupoToolStripMenuItem.Click
        exportarExcel(1)
    End Sub

    Private Sub VentasGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasGeneralesToolStripMenuItem.Click
        exportarExcel(2)
    End Sub

    Private Sub btnAdjuntarIMG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarIMG.Click

        'If Me.dtgContratos.CurrentRow IsNot Nothing Then
        '    Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos
        '    ofrmAdjuntarDocumentos.PNCCLNT = 999 'Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
        '    ofrmAdjuntarDocumentos.pCCMPN = ucCompania.CCMPN_CodigoCompania
        '    ofrmAdjuntarDocumentos.pNRCTSL = Me.dtgContratos.CurrentRow.Cells("NRCTSL").Value
        '    ofrmAdjuntarDocumentos.pNMRGIM = Me.dtgContratos.CurrentRow.DataBoundItem.NMRGIM
        '    ofrmAdjuntarDocumentos.pTABLE_NAME = "RZSC01"
        '    ofrmAdjuntarDocumentos.PSUSUARIO = ConfigurationWizard.UserName
        '    ofrmAdjuntarDocumentos.ShowDialog()
        '    dtgGrupoCliente_SelectionChanged(Nothing, Nothing)
        'End If

    End Sub

    Private Sub dtgContratos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgContratos.DataBindingComplete
        'NMRGIM
        For intCont As Integer = 0 To Me.dtgContratos.Rows.Count - 1
            If Me.dtgContratos.Rows(intCont).DataBoundItem.NMRGIM = 0 Then
                dtgContratos.Rows(intCont).Cells("IMG").Value = My.Resources.CuadradoBlanco
            End If
        Next

    End Sub

    Private Sub ucCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles ucCompania.Seleccionar
        Try
            Dim dtRegionVenta As New DataTable
            dtRegionVenta = brRegionVenta.Lista_Region_Venta(ucCompania.CCMPN_CodigoCompania)
            Me.cmbRegionVenta.ValueMember = "CRGVTA"
            Me.cmbRegionVenta.DisplayMember = "TCRVTA"
            Me.cmbRegionVenta.DataSource = dtRegionVenta
            For j As Integer = 0 To Me.cmbRegionVenta.Items.Count - 1
                If cmbRegionVenta.Items.Item(j).Value = "-1" Then
                    cmbRegionVenta.SetItemChecked(j, True)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UcPaginacion1_PageChanged(sender As Object, e As EventArgs) Handles UcPaginacion1.PageChanged
        Try
            BucarGrupoCliente()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class



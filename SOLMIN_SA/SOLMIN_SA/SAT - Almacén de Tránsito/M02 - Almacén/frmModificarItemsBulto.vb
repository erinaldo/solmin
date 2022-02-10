Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion
Imports Ransa.Controls.OrdenCompra
Imports RANSA.DAO.OrdenCompra
Imports RANSA.NEGO
Imports Ransa.TypeDef
Imports Ransa.DAO.WayBill
Imports Ransa.TypeDef.WayBill
Imports Ransa.Utilitario
'Imports RANSA.DAO.Unidad

Public Class frmModificarItemsBulto
#Region "Propiedades"
    Private sDefault_Peso As String = ""
    Private sDefault_Volumen As String = ""

    Private _pobeOrdeDeCompra As beOrdenCompra
    Private OrdenCompra_Origen As String = ""

    Private dtListGuiaProvxOC As New DataTable
    Public WriteOnly Property pobeOrdeDeCompra() As beOrdenCompra
        Set(ByVal value As beOrdenCompra)
            _pobeOrdeDeCompra = value
        End Set
    End Property

#End Region

#Region " Métodos "

    'Private Sub dgOrdenComprasSeleccionados_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgOrdenComprasSeleccionados.RowValidating
    '    If booStatusCargaDG Then
    '        With dgOrdenComprasSeleccionados
    '            Decimal.TryParse(.CurrentRow.Cells("QCNREC").Value.ToString, .CurrentRow.Cells("QCNREC").Value)
    '            If .CurrentRow.Cells("QCNREC").Value < 0 Then
    '                .CurrentRow.Cells("QCNREC").Value = 0
    '            End If
    '            If .CurrentRow.Cells("QTOMAX").Value > .CurrentRow.Cells("QCNTIT").Value Then
    '                If .CurrentRow.Cells("QTOMAX").Value - _
    '                   .CurrentRow.Cells("QCNTIT").Value + _
    '                   .CurrentRow.Cells("QCNPEN").Value - _
    '                   .CurrentRow.Cells("QCNREC").Value < 0 And .CurrentRow.Cells("QCNREC").Value > 0 Then
    '                    If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", _
    '                                       MessageBoxButtons.YesNo, _
    '                                       MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
    '                        If .CurrentRow.Cells("QCNPEN").Value > 0 Then
    '                            .CurrentRow.Cells("QCNREC").Value = .CurrentRow.Cells("QCNPEN").Value
    '                        Else
    '                            .CurrentRow.Cells("QCNREC").Value = 0
    '                        End If
    '                    End If
    '                End If
    '            Else
    '                If .CurrentRow.Cells("QCNPEN").Value - _
    '                   .CurrentRow.Cells("QCNREC").Value < 0 And .CurrentRow.Cells("QCNREC").Value > 0 Then
    '                    If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", _
    '                                       MessageBoxButtons.YesNo, _
    '                                       MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
    '                        If .CurrentRow.Cells("QCNPEN").Value > 0 Then
    '                            .CurrentRow.Cells("QCNREC").Value = .CurrentRow.Cells("QCNPEN").Value
    '                        Else
    '                            .CurrentRow.Cells("QCNREC").Value = 0
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End With
    '        'dgOrdenComprasSeleccionados.CurrentCell = Me.dgOrdenComprasSeleccionados.Item("Chk", Me.dgOrdenComprasSeleccionados.CurrentCellAddress.Y)

    '    End If
    'End Sub


#End Region

    Dim ValidarCellChange As Boolean = False
    Public oHasSubItems As New Hashtable()

    Private Sub dgOrdenComprasSeleccionados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenComprasSeleccionados.CellClick
        If Me.dgOrdenComprasSeleccionados.Columns(e.ColumnIndex).Name.Trim = "SUBITEM" Then
            Dim Item As New RANSA.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
            Item.pCCLNT_CodigoCliente = _pobeOrdeDeCompra.PNCCLNT
            Item.pNORCML_NroOrdenCompra = dgOrdenComprasSeleccionados.CurrentRow.Cells("NORCML").Value
            Item.pNRITOC_NroItemOC = dgOrdenComprasSeleccionados.CurrentRow.Cells("NRITOC").Value
            Dim ofrmListSubItem As New RANSA.Controls.OrdenCompra.ucListaSubItemOC_DgF01(Item)
            ofrmListSubItem.oHasSubItems = oHasSubItems
            ofrmListSubItem.pHabilitarBulto = True
            If ofrmListSubItem.ShowDialog() = Windows.Forms.DialogResult.OK Then
                oHasSubItems = ofrmListSubItem.oHasSubItems
            End If
        End If
    End Sub

    Private Sub dgOrdenComprasSeleccionados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenComprasSeleccionados.CellContentClick
        Try
            dgOrdenComprasSeleccionados.EndEdit()
            If e.ColumnIndex = 0 Then
                If dgOrdenComprasSeleccionados.CurrentCellAddress.Y < 0 Then Exit Sub
                If Not dgOrdenComprasSeleccionados.CurrentCell.Value Then
                    dgOrdenComprasSeleccionados.CurrentCell.Value = False
                    Call pMarcarFila(e.RowIndex, False)
                Else
                    If (Me.pEstado <> "Devolucion") Then
                        If (CType(dgOrdenComprasSeleccionados.CurrentRow.DataBoundItem, beOrdenCompra).PNQCNPEN + CType(dgOrdenComprasSeleccionados.CurrentRow.DataBoundItem, beOrdenCompra).PNQBLTSR) <= 0 Then
                            dgOrdenComprasSeleccionados.CurrentCell.Value = False
                            Exit Sub
                        End If
                        dgOrdenComprasSeleccionados.CurrentCell.Value = True
                        Call pMarcarFila(e.RowIndex, True)
                    Else
                        dgOrdenComprasSeleccionados.CurrentCell.Value = True
                        Call pMarcarFila(e.RowIndex, True)
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub pMarcarFila(ByVal Indice As Int32, ByVal Status As Boolean)
        If Indice = -1 Then Exit Sub
        If Status Then
            Me.dgOrdenComprasSeleccionados.Rows(Indice).Cells("QCNREC").Value = CType(dgOrdenComprasSeleccionados.Rows(Indice).DataBoundItem, beOrdenCompra).PNQBLTSR
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QCNREC").ReadOnly = False
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TDAITM").ReadOnly = False
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QPEPQT").ReadOnly = False
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TUNPSO").ReadOnly = False
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TUNPSO").Value = sDefault_Peso
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QPEPQT").Value = 0D
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QVOPQT").ReadOnly = False
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QVOPQT").Value = 0D
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TUNVOL").ReadOnly = False
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TUNVOL").Value = sDefault_Volumen
            iNroChkSelecc += 1
            If iNroChkSelecc = 1 Then
                dgOrdenComprasSeleccionados.Columns("QCNREC").Visible = True
                dgOrdenComprasSeleccionados.Columns("TDAITM").Visible = True
                dgOrdenComprasSeleccionados.Columns("QPEPQT").Visible = True
                dgOrdenComprasSeleccionados.Columns("TUNPSO").Visible = True
                dgOrdenComprasSeleccionados.Columns("QVOPQT").Visible = True
                dgOrdenComprasSeleccionados.Columns("TUNVOL").Visible = True
            End If
        Else
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QCNREC").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TDAITM").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QPEPQT").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TUNPSO").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("QVOPQT").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(Indice).Cells("TUNVOL").ReadOnly = True
            iNroChkSelecc -= 1
            If iNroChkSelecc = 0 Then
                dgOrdenComprasSeleccionados.Columns("QCNREC").Visible = False
                dgOrdenComprasSeleccionados.Columns("TDAITM").Visible = False
                dgOrdenComprasSeleccionados.Columns("QPEPQT").Visible = False
                dgOrdenComprasSeleccionados.Columns("TUNPSO").Visible = False
                dgOrdenComprasSeleccionados.Columns("QVOPQT").Visible = False
                dgOrdenComprasSeleccionados.Columns("TUNVOL").Visible = False
            End If
        End If

    End Sub


    'If Me.dgOrdenComprasSeleccionados.Item("Chk", Me.dgOrdenComprasSeleccionados.CurrentCellAddress.Y).Value = "S" Then
    '              If Me.dgOrdenComprasSeleccionados.Item("QCNPEN", Me.dgOrdenComprasSeleccionados.CurrentCellAddress.Y).Value <= 0 Then
    '                  Me.dgOrdenComprasSeleccionados.Item("Chk", Me.dgOrdenComprasSeleccionados.CurrentCellAddress.Y).Value = "N"
    '              Else
    '                  dgOrdenComprasSeleccionados.CurrentCell = Me.dgOrdenComprasSeleccionados.Item("QCNREC", Me.dgOrdenComprasSeleccionados.CurrentCellAddress.Y)

    '                  dgOrdenComprasSeleccionados.BeginEdit(True)
    '              End If
    '          End If

    Private Sub dgOrdenComprasSeleccionados_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgOrdenComprasSeleccionados.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
            dgOrdenComprasSeleccionados.CurrentCell = Me.dgOrdenComprasSeleccionados.Item("Chk", Me.dgOrdenComprasSeleccionados.CurrentCellAddress.Y)
        End If
    End Sub

    Private Sub dgOrdenComprasSeleccionados_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgOrdenComprasSeleccionados.CellFormatting
        Try
            Dim TipoTrade As Decimal
            If dgOrdenComprasSeleccionados.Columns(e.ColumnIndex).Name.Equals("NORCML") Then

                TipoTrade = dgOrdenComprasSeleccionados.Rows(e.RowIndex).Cells("QCNPEN").Value
                If TipoTrade > 0 Then
                    e.CellStyle.BackColor = Color.Yellow
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        If mfblnSalirOpcion() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
       
        Call GuadarDetalleBulto()
    End Sub


#Region "Metodos"




    Private Sub CargarDetalleOrdeDeCompraXBulto()
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        dgOrdenComprasSeleccionados.AutoGenerateColumns = False

        Dim oList As New List(Of beOrdenCompra)
        oList = obrOrdenDeCompra.ListarDetalleOrdenDeCompraPendientes(_pobeOrdeDeCompra)
        'Me.dgOrdenComprasSeleccionados.DataSource = obrOrdenDeCompra.ListarDetalleOrdenDeCompraPendientes(_pobeOrdeDeCompra)
        Me.dgOrdenComprasSeleccionados.DataSource = obrOrdenDeCompra.ListarDetalleOrdenDeCompraPendientes(_pobeOrdeDeCompra)

        Dim pGuiaProv As String = ""
        If oList IsNot Nothing Then
            If oList.Count > 0 Then
                Dim OC As String = oList(0).PSNORCML
                For Each item As DataRow In dtListGuiaProvxOC.Rows
                    If OC = ("" & item("NORCML")).ToString.Trim Then
                        pGuiaProv = ("" & item("NGRPRV")).ToString.Trim
                        Exit For
                    End If
                Next
            End If
        End If
        txtGuiaProveedor.Text = pGuiaProv

        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN

        If pTipoMaterial = "MATPEL" Then
            ValidarCellChange = True
            For i As Integer = 0 To dgOrdenComprasSeleccionados.Rows.Count - 1
                dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CND").Value = dgOrdenComprasSeleccionados.Rows(i).Cells("PSCMATPE").Value
                dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").Value = dgOrdenComprasSeleccionados.Rows(i).Cells("PSCCLMAT").Value

                If dgOrdenComprasSeleccionados.Rows(i).Cells("PSFGIQBF").Value = "SI" Then
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSFGIQBF2").Value = True
                End If
                'CSR-HUNDRED-041016-MATERIALES-PELIGROSOS-INICIO
                If dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CND").Value <> "RE" Then
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").ReadOnly = True
                Else
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").ReadOnly = False
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").ReadOnly = False
                End If
                dgOrdenComprasSeleccionados.Rows(i).Cells("PSFCHCAD").Value = HelpClass.FechaNum_a_Fecha(dgOrdenComprasSeleccionados.Rows(i).Cells("PSFCHCAD").Value.ToString())
                'CSR-HUNDRED-041016-MATERIALES-PELIGROSOS-FIN
            Next

            PSCMATPE.Visible = False
            PSCCLMAT.Visible = False
            PSFGIQBF.Visible = False
            ValidarCellChange = False
        Else
            For i As Integer = 0 To dgOrdenComprasSeleccionados.Rows.Count - 1
                dgOrdenComprasSeleccionados.Rows(i).Cells("PSFCHCAD").Value = HelpClass.FechaNum_a_Fecha(dgOrdenComprasSeleccionados.Rows(i).Cells("PSFCHCAD").Value.ToString())
                'CSR-HUNDRED-041016-MATERIALES-PELIGROSOS-FIN
            Next

            PSDES_CND.ReadOnly = True
            PSFGIQBF2.ReadOnly = True
            PSDES_CLASE.ReadOnly = True
            PSCPRFUN.ReadOnly = True
            PSCUNMAT.ReadOnly = True
            'PSFCHCAD.ReadOnly = True

            PSCMATPE.Visible = False
            PSCCLMAT.Visible = False
            PSFGIQBF.Visible = False
        End If
        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN
    End Sub

    Private Sub GuadarDetalleBulto()
        Dim bolresultado As Boolean = False
        Dim oBeDetalleBulto As beBulto
        Dim contador As Integer = 0

        Dim validarMatPel As String = ValidacionCamposGrilla().Trim
        Dim GuiaProveedor As String = ""
      

     

        If validarMatPel <> "" Then
            MessageBox.Show(validarMatPel, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim oListOC As New List(Of beOrdenCompra)
        oListOC = CType(Me.dgOrdenComprasSeleccionados.DataSource, List(Of beOrdenCompra))
        Dim OC_actual As String = oListOC(0).PSNORCML.Trim
        Dim drBusq() As DataRow
        drBusq = dtListGuiaProvxOC.Select("NORCML='" & OC_actual & "'")
        If drBusq.Length > 0 Then
            Dim GuiaProv_historial As String = ("" & drBusq(0)("NGRPRV")).ToString.Trim
            Dim GuiaProv_actual As String = txtGuiaProveedor.Text.Trim
            If GuiaProv_historial <> GuiaProv_actual Then
                Dim msg As String = ""
                msg = "No coinciden las Guías a nivel de OC" & Chr(10)
                msg = "Guía Proveedor anterior : " & GuiaProv_historial & Chr(10)
                msg = msg & "Guía Proveedor a ingresar :" & GuiaProv_actual & Chr(10)
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        'If OrdenCompra_Origen.ToUpper <> oListOC(0).PSNORCML.Trim.ToUpper Then
        '    GuiaProveedor = txtGuiaProveedor.Text.Trim
        'Else
        '    GuiaProveedor = _pobeOrdeDeCompra.PSNGRPRV.Trim
        'End If
        If txtGuiaProveedor.Text.Trim = "" Then
            MessageBox.Show("Ingresar guía proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each obeOrdeDeCompra As beOrdenCompra In CType(Me.dgOrdenComprasSeleccionados.DataSource, List(Of beOrdenCompra))

            If obeOrdeDeCompra.CHK Then
                oBeDetalleBulto = New beBulto
                With oBeDetalleBulto
                    .PNCCLNT = _pobeOrdeDeCompra.PNCCLNT
                    .PSCCMPN = _pobeOrdeDeCompra.PSCCMPN
                    .PSCDVSN = _pobeOrdeDeCompra.PSCDVSN
                    .PNCPLNDV = _pobeOrdeDeCompra.PNCPLNDV
                    .PSNORCML = obeOrdeDeCompra.PSNORCML
                    .PNNRITOC = obeOrdeDeCompra.PNNRITOC
                    .PNQBLTSR = obeOrdeDeCompra.PNQCNREC
                    .PSTUNPSO = obeOrdeDeCompra.PSTUNPSO
                    .PNQVOPQT = obeOrdeDeCompra.PNQVOPQT
                    .PSTUNVOL = obeOrdeDeCompra.PSTUNVOL
                    .PSCREFFW = obeOrdeDeCompra.PSCREFFW
                    .PSCIDPAQ = obeOrdeDeCompra.PSCIDPAQ
                    .PNNSEQIN = _pobeOrdeDeCompra.PNNSEQIN
                    .PSTDAITM = obeOrdeDeCompra.PSTDAITM
                    .PSNFACPR = _pobeOrdeDeCompra.PSNFACPR
                    .PNFFACPR = _pobeOrdeDeCompra.PNFFACPR
                    .PSCREFFW = _pobeOrdeDeCompra.PSCREFFW
                    '.PSNGRPRV = _pobeOrdeDeCompra.PSNGRPRV
                    '.PSNGRPRV = GuiaProveedor
                    .PSNGRPRV = txtGuiaProveedor.Text.Trim

                    .PSTIPO = _pEstado
                    .PSUSUARIO = objSeguridadBN.pUsuario
                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
                    .PSDES_CND = CStr(IIf(dgOrdenComprasSeleccionados.Rows(contador).Cells("PSDES_CND").Value Is Nothing, "", dgOrdenComprasSeleccionados.Rows(contador).Cells("PSDES_CND").Value))
                    If (dgOrdenComprasSeleccionados.Rows(contador).Cells("PSFGIQBF2").Value Is Nothing) Then
                        .PSFGIQBF = ""
                    ElseIf (dgOrdenComprasSeleccionados.Rows(contador).Cells("PSFGIQBF2").Value.ToString() = "True") Then
                        .PSFGIQBF = "SI"
                    Else
                        .PSFGIQBF = ""
                    End If

                    .PSDES_CLASE = CStr(IIf(dgOrdenComprasSeleccionados.Rows(contador).Cells("PSDES_CLASE").Value Is Nothing, "", dgOrdenComprasSeleccionados.Rows(contador).Cells("PSDES_CLASE").Value))
                    If (dgOrdenComprasSeleccionados.Rows(contador).Cells("PSDES_CLASE").Value Is Nothing) Then
                        .IN_CPRFUN = ""
                    ElseIf (dgOrdenComprasSeleccionados.Rows(contador).Cells("PSDES_CLASE").Value.ToString().Trim <> "") Then
                        .IN_CPRFUN = obeOrdeDeCompra.PSCPRFUN
                    Else
                        .IN_CPRFUN = ""
                    End If

                    .PSCUNMAT = obeOrdeDeCompra.PSCUNMAT

                    'If (pTipoMaterial <> "MATPEL") Then
                    '    .PSFCHCAD = 0
                    'ElseIf (dgOrdenComprasSeleccionados.Rows(contador).Cells("PSFCHCAD").Value.ToString().Trim = "") Then
                    '    .PSFCHCAD = 0
                    'Else
                    '    .PSFCHCAD = Convert.ToDateTime(dgOrdenComprasSeleccionados.Rows(contador).Cells("PSFCHCAD").Value()).ToString("yyyyMMdd")
                    'End If
                    If dgOrdenComprasSeleccionados.Rows(contador).Cells("PSFCHCAD").Value Is Nothing OrElse dgOrdenComprasSeleccionados.Rows(contador).Cells("PSFCHCAD").Value.ToString.Trim = "" Then
                        .PSFCHCAD = 0
                    Else
                        .PSFCHCAD = Convert.ToDateTime(dgOrdenComprasSeleccionados.Rows(contador).Cells("PSFCHCAD").Value()).ToString("yyyyMMdd")
                    End If

                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN
                End With

                Dim obrBulto As New brBulto
                If Not oBeDetalleBulto.PSCIDPAQ.Trim.Equals("") Then
                    oBeDetalleBulto.PSCIDPAQ = obrBulto.ActualizarDetalleBulto(oBeDetalleBulto)
                    If oBeDetalleBulto.PSCIDPAQ = "" Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If

                    Dim strError As String = ""
                    Dim olbeSubItemOC As New List(Of RANSA.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC)
                    If Not oHasSubItems(oBeDetalleBulto.PNNRITOC.ToString.Trim) Is Nothing Then
                        For Each obeTD_SubItemOC As RANSA.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In oHasSubItems(oBeDetalleBulto.PNNRITOC.ToString.Trim)
                            obeTD_SubItemOC.pCCLNT_CodigoCliente = oBeDetalleBulto.PNCCLNT
                            obeTD_SubItemOC.pCREFFW_FrdForw = oBeDetalleBulto.PSCREFFW
                            olbeSubItemOC.Add(obeTD_SubItemOC)
                        Next
                    End If

                    For Each obeTD_SubItemOC As RANSA.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In olbeSubItemOC
                        If obeTD_SubItemOC.pCREFFW_FrdForw = oBeDetalleBulto.PSCREFFW And obeTD_SubItemOC.pNORCML_NroOrdenCompra = oBeDetalleBulto.PSNORCML And obeTD_SubItemOC.pNRITOC_NroItemOC = oBeDetalleBulto.PNNRITOC Then
                            obeTD_SubItemOC.pCCMPN_Compania = oBeDetalleBulto.PSCCMPN
                            obeTD_SubItemOC.pCDVSN_Division = oBeDetalleBulto.PSCDVSN
                            obeTD_SubItemOC.pCPLNDV_Planta = oBeDetalleBulto.PNCPLNDV
                            obeTD_SubItemOC.pCIDPAQ_CodIndentificacionPaquete = oBeDetalleBulto.PSCIDPAQ
                        End If
                        CSubItemOrdenCompra.Generar_Bultos_SubItems_OC(Nothing, obeTD_SubItemOC, strError, objSeguridadBN.pUsuario)
                    Next

                Else
                    oBeDetalleBulto.PSCIDPAQ = obrBulto.InsertarDetalleBulto(oBeDetalleBulto)
                    If oBeDetalleBulto.PSCIDPAQ = "" Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If

                    Dim strError As String = ""
                    Dim olbeSubItemOC As New List(Of RANSA.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC)
                    If Not oHasSubItems(oBeDetalleBulto.PNNRITOC.ToString.Trim) Is Nothing Then
                        For Each obeTD_SubItemOC As RANSA.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In oHasSubItems(oBeDetalleBulto.PNNRITOC.ToString.Trim)
                            obeTD_SubItemOC.pCCLNT_CodigoCliente = oBeDetalleBulto.PNCCLNT
                            obeTD_SubItemOC.pCREFFW_FrdForw = oBeDetalleBulto.PSCREFFW
                            olbeSubItemOC.Add(obeTD_SubItemOC)
                        Next
                    End If

                    For Each obeTD_SubItemOC As RANSA.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In olbeSubItemOC
                        If obeTD_SubItemOC.pCREFFW_FrdForw = oBeDetalleBulto.PSCREFFW And obeTD_SubItemOC.pNORCML_NroOrdenCompra = oBeDetalleBulto.PSNORCML And obeTD_SubItemOC.pNRITOC_NroItemOC = oBeDetalleBulto.PNNRITOC Then
                            obeTD_SubItemOC.pCCMPN_Compania = oBeDetalleBulto.PSCCMPN
                            obeTD_SubItemOC.pCDVSN_Division = oBeDetalleBulto.PSCDVSN
                            obeTD_SubItemOC.pCPLNDV_Planta = oBeDetalleBulto.PNCPLNDV
                            obeTD_SubItemOC.pCIDPAQ_CodIndentificacionPaquete = oBeDetalleBulto.PSCIDPAQ
                        End If
                        CSubItemOrdenCompra.Generar_Bultos_SubItems_OC(Nothing, obeTD_SubItemOC, strError, objSeguridadBN.pUsuario)
                    Next

                End If
                bolresultado = True
            End If
            contador = contador + 1
        Next
        If bolresultado Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub CargarUnidades()
        'Dim oUnidad As cUnidad = New cUnidad
        Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
        '-- Peso
        TUNPSO.DataSource = oUnidad.fdtListar("P", sDefault_Peso)
        TUNPSO.DisplayMember = "TABRUN"
        TUNPSO.ValueMember = "TABRUN"
        '-- Volumen
        TUNVOL.DataSource = oUnidad.fdtListar("V", sDefault_Volumen)
        TUNVOL.DisplayMember = "TABRUN"
        TUNVOL.ValueMember = "TABRUN"
        ' Limpiamos la Memoria

        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
        Dim obrOrdenCompra As New brOrdenDeCompra
        Dim ValorEnvio As String

        'Obtener GrillaCondicion dentro de la grilla'
        ValorEnvio = "SACDMP"
        Dim dtComboGrilla As DataTable = obrOrdenCompra.ObtenerValoresGrilla(ValorEnvio)
        Dim drCombo As DataRow
        drCombo = dtComboGrilla.NewRow
        drCombo("CODVAR") = "SACDMP"
        drCombo("CCMPRN") = ""
        drCombo("TDSDES") = ":: Seleccione ::"
        drCombo("TDSDE2") = ""
        dtComboGrilla.Rows.InsertAt(drCombo, 0)

        PSDES_CND.DataSource = dtComboGrilla
        PSDES_CND.DisplayMember = "TDSDES"
        PSDES_CND.ValueMember = "CCMPRN"
        PSDES_CND.DataGridView.ReadOnly = False

        'Obtener GrillaClase  dentro de la grilla 
        ValorEnvio = "SACLMT"
        Dim dtClaseGrilla As DataTable = obrOrdenCompra.ObtenerValoresGrilla(ValorEnvio)
        Dim drClase2 As DataRow
        drClase2 = dtClaseGrilla.NewRow
        drClase2("CODVAR") = "SACLMT"
        drClase2("CCMPRN") = ""
        drClase2("TDSDES") = ":: Seleccione ::"
        dtClaseGrilla.Rows.InsertAt(drClase2, 0)

        Dim dtClaseContatenado As New DataTable("Clase")
        dtClaseContatenado.Columns.Add("CODVAR", Type.GetType("System.String"))
        dtClaseContatenado.Columns.Add("CCMPRN", Type.GetType("System.String"))
        dtClaseContatenado.Columns.Add("TDSDES", Type.GetType("System.String"))

        If dtClaseGrilla.Rows.Count > 0 Then
            For i As Integer = 0 To dtClaseGrilla.Rows.Count - 1
                Dim CODVAR As String = dtClaseGrilla.Rows(i).Item(0).ToString
                Dim CCMPRN As String = dtClaseGrilla.Rows(i).Item(1).ToString
                Dim TDSDES As String = dtClaseGrilla.Rows(i).Item(2).ToString
                Dim TDSDE2 As String = dtClaseGrilla.Rows(i).Item(3).ToString
                Dim Concat As String = TDSDES + " " + TDSDE2

                Dim drClase As DataRow
                drClase = dtClaseContatenado.NewRow
                drClase("CODVAR") = CODVAR
                drClase("CCMPRN") = CCMPRN
                drClase("TDSDES") = Concat
                dtClaseContatenado.Rows.InsertAt(drClase, dtClaseGrilla.Rows.Count)
            Next
        End If

        PSDES_CLASE.DataSource = dtClaseContatenado
        PSDES_CLASE.DisplayMember = "TDSDES"
        PSDES_CLASE.ValueMember = "CCMPRN"

        'GrillaDesUN.ReadOnly = True
        'GrillaCboClase.ReadOnly = True
        'GrillaCodUn.ReadOnly = True
        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.
    End Sub
#End Region

    Private Sub frmAgregarItemsBulto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim obrOrdenDeCompra As New brOrdenDeCompra
            'Dim dt As New DataTable
            dtListGuiaProvxOC = obrOrdenDeCompra.ListaGuiaProveedor_OC(_pobeOrdeDeCompra)

            OrdenCompra_Origen = _pobeOrdeDeCompra.PSNORCML.Trim
            'txtGuiaProveedor.Enabled = False
            CargarUnidades()
            CargarDetalleOrdeDeCompraXBulto()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "Metodos"
    Private iNroChkSelecc As Integer = 0
    Private _pEstado As String
    Public Property pEstado() As String
        Get
            Return _pEstado
        End Get
        Set(ByVal value As String)
            _pEstado = value
        End Set
    End Property

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Private _pTipoMaterial As String
    Public Property pTipoMaterial() As String
        Get
            Return _pTipoMaterial
        End Get
        Set(ByVal value As String)
            _pTipoMaterial = value
        End Set
    End Property
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

#End Region

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If Me.dgOrdenComprasSeleccionados.RowCount > 0 Then
            Dim intCont As Int32 = 0
            iNroChkSelecc = 0
            While intCont < dgOrdenComprasSeleccionados.RowCount
                If (Me.pEstado <> "Devolucion") Then
                    If (CType(dgOrdenComprasSeleccionados.Rows(intCont).DataBoundItem, beOrdenCompra).PNQCNPEN + CType(dgOrdenComprasSeleccionados.Rows(intCont).DataBoundItem, beOrdenCompra).PNQBLTSR) > 0 Then
                        dgOrdenComprasSeleccionados.Rows(intCont).Cells("CHK").Value = btnMarcarItems.Checked
                        If btnMarcarItems.Checked Then
                            Call pMarcarFila(intCont, True)
                        Else
                            iNroChkSelecc += 1
                            Call pMarcarFila(intCont, False)
                        End If
                    End If
                    intCont += 1
                Else
                    dgOrdenComprasSeleccionados.Rows(intCont).Cells("CHK").Value = btnMarcarItems.Checked
                    If btnMarcarItems.Checked Then
                        Call pMarcarFila(intCont, True)
                    Else
                        iNroChkSelecc += 1
                        Call pMarcarFila(intCont, False)
                    End If
                    intCont += 1
                End If

            End While
        End If
    End Sub

    Private Sub dgOrdenComprasSeleccionados_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgOrdenComprasSeleccionados.CellValidating
        If CType(dgOrdenComprasSeleccionados.CurrentRow.DataBoundItem, beOrdenCompra).CHK Then
            Select Case dgOrdenComprasSeleccionados.Columns(e.ColumnIndex).Name
                Case "TDAITM"
                    dgOrdenComprasSeleccionados.CurrentCell.Value = dgOrdenComprasSeleccionados.CurrentCell.Value.ToString.ToUpper.Trim
                Case "QCNREC"
                    Dim strMensajeError As String = ""
                    If (Val(e.FormattedValue) <= 0) Then
                        strMensajeError = "El monto debe ser mayor a cero o igual."
                        dgOrdenComprasSeleccionados.CurrentCell.Value = 0D
                    ElseIf (CType(dgOrdenComprasSeleccionados.CurrentRow.DataBoundItem, beOrdenCompra).PNQCNPEN + CType(dgOrdenComprasSeleccionados.CurrentRow.DataBoundItem, beOrdenCompra).PNQBLTSR) < Val(e.FormattedValue) Then
                        strMensajeError = "La cantida a recibir no puede ser mayor a la cantidad pendiente."
                        e.Cancel = True
                        'dgOrdenComprasSeleccionados.CurrentCell.Value = 0D
                    End If
                    If strMensajeError.Trim.Length > 0 Then
                        HelpClass.MsgBox(strMensajeError, MessageBoxIcon.Warning)
                    End If
            End Select
        End If


    End Sub

    'CSR-HUNDRED-051016-MATERIALES-PELIGROSOS-INICIO
    Private Sub dgOrdenComprasSeleccionados_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenComprasSeleccionados.CellValueChanged
        If ValidarCellChange = False Then
            ValidarSeleccionDeCelda(dgOrdenComprasSeleccionados.Columns(e.ColumnIndex).Name.ToString().Trim)
        End If
    End Sub

    Private Sub btnLimpiarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarFecha.Click
        dgOrdenComprasSeleccionados.CurrentRow.Cells("PSFCHCAD").Value = ""
    End Sub
    Private Sub dgOrdenComprasSeleccionados_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOrdenComprasSeleccionados.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                ctmsFecha.Items(0).Visible = False
                If (dgOrdenComprasSeleccionados.Rows.Count <= 0) Then Exit Sub
                Dim ColName As String = dgOrdenComprasSeleccionados.Columns(dgOrdenComprasSeleccionados.CurrentCell.ColumnIndex).Name
                ctmsFecha.Items(0).Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ValidacionCamposGrilla() As String
        '  Dim bandera As Boolean = False
        Dim msj As String = ""
        For i As Integer = 0 To dgOrdenComprasSeleccionados.RowCount - 1
            If dgOrdenComprasSeleccionados.Rows(i).Cells("Chk").Value Then
                Dim valorFila As String = dgOrdenComprasSeleccionados.Rows(i).Cells("NRITOC").Value
                If pTipoMaterial = "MATPEL" Then 'Ingresa si el tipo material es MATPEL
                    If dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CND").Value <> "" Then 'Valida si alguna condicion fue seleccionada
                        If dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CND").Value = "RE" Then 'Valida si la condicion  seleccionada es  "Regulado (RE)" 
                            If dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").Value = Nothing OrElse dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").Value = "" Then 'Valida si clase fue seleccionada
                                msj = msj & "En el Item [" + valorFila + "] - Seleccione Clase" & Chr(13)
                                'MessageBox.Show("En el Item [" + valorFila + "] - Seleccione Clase", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'Return True
                            End If

                            If dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").Value = Nothing OrElse dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").Value = "" Then 'Valida si tiene codigo UN
                                msj = msj & "En el Item [" + valorFila + "] - Ingresar Cód. UN" & Chr(13)
                                'MessageBox.Show("En el Item [" + valorFila + "] - Ingresar Cód. UN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'Return True
                            End If

                        End If
                    Else
                        msj = msj & "En el Item [" + valorFila + "] - Seleccione Condición" & Chr(13)
                        'MessageBox.Show("En el Item [" + valorFila + "] - Seleccione Condición", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Return True
                    End If
                End If
            End If
        Next
        Return msj
    End Function
    Private Sub ValidarSeleccionDeCelda(ByVal vColName As String)
        Dim ColName As String = vColName
        If pTipoMaterial IsNot Nothing And ColName = "PSDES_CND" Then
            For i As Integer = 0 To dgOrdenComprasSeleccionados.RowCount - 1
                If pTipoMaterial = "MATPEL" Then
                    If dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CND").Value = "RE" Then
                        dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").ReadOnly = False
                        dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").ReadOnly = False
                    Else
                        dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").Value = ""
                        dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").Value = ""

                        dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").ReadOnly = True
                        dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").ReadOnly = True
                    End If
                Else
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").Value = ""
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").Value = ""

                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSDES_CLASE").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("PSCUNMAT").ReadOnly = True
                End If
            Next
            dgOrdenComprasSeleccionados.EndEdit()
        End If
    End Sub
    Private Sub dgOrdenComprasSeleccionados_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgOrdenComprasSeleccionados.EditingControlShowing
        If dgOrdenComprasSeleccionados.Columns(dgOrdenComprasSeleccionados.CurrentCell.ColumnIndex).Name.ToString().Trim = "PSCUNMAT" Then
            ' referencia a la celda  
            Dim validar As TextBox = CType(e.Control, TextBox)

            ' agregar el controlador de eventos para el KeyPress  
            AddHandler validar.KeyPress, AddressOf validar_Keypress
        End If
    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Obtener caracter  
        Dim caracter As Char = e.KeyChar

        ' comprobar si el caracter es un número o el retroceso  
        If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    'CSR-HUNDRED-051016-MATERIALES-PELIGROSOS-FIN

 
    Private Sub txtOrdenCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrdenCompra.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then

                Dim OC As String = txtOrdenCompra.Text.Trim.ToUpper
                If OC = "" Then
                    MessageBox.Show("Ingrese Orden Compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                _pobeOrdeDeCompra.PSNORCML = OC
                CargarDetalleOrdeDeCompraXBulto()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscarOC_Click(sender As Object, e As EventArgs) Handles btnBuscarOC.Click
        Try
            Dim OC As String = txtOrdenCompra.Text.Trim.ToUpper
            If OC = "" Then
                MessageBox.Show("Ingrese Orden Compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

          

            _pobeOrdeDeCompra.PSNORCML = OC
            CargarDetalleOrdeDeCompraXBulto()


            'Dim oListOC As New List(Of beOrdenCompra)
            'oListOC = CType(Me.dgOrdenComprasSeleccionados.DataSource, List(Of beOrdenCompra))
            'If oListOC IsNot Nothing Then
            '    If oListOC.Count > 0 Then
            '        If OrdenCompra_Origen.ToUpper = oListOC(0).PSNORCML.Trim.ToUpper Then
            '            txtGuiaProveedor.Enabled = False
            '        Else
            '            txtGuiaProveedor.Enabled = True
            '        End If

            '    End If
            'End If
 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
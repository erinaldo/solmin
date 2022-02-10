
Public Class UcPorOperacion

#Region "Declaracion de Variables"
    Private Estatico As New Estaticos
    Public Event Listar_Operaciones(ByVal oServicioBE As Servicio_BE, ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
    Private oServicioOpeNeg As New clsServicio_BL
    Public Event Facturar(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
    Public Event Boleta(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
    'Public Enum TipoLista
    '    OPERACION
    '    CONSISTENCIA
    '    PRELIQUIDACION
    'End Enum
    Public Event FacturarElectronica(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer, pTipoLista As Ransa.Utilitario.HelpClass.TipoLista)
    'Public Event BoletaElectronica(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)
    'Public Event ParteTransferencia(ByVal olOperaciones As List(Of Servicio_BE), ByVal intTipo As Integer)

    Public Event Procesar_Consistencias(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
    Public Event Anular_Revision(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)

    Public Event SelectionarRegistro()

    Private _pClienteFacturar As Decimal = 0D
    Public Property pClienteFacturar() As Decimal
        Get
            Return _pClienteFacturar
        End Get
        Set(ByVal value As Decimal)
            _pClienteFacturar = value
        End Set
    End Property



    Private Marcar As Image
    Private Desmarcar As Image
    Public _pTipoAlmacen As String
    Private _oServicio As Servicio_BE
    Public sTotalDatosPorOperacion As String
    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property



    Public WriteOnly Property OcultarBotones() As Boolean

        Set(ByVal value As Boolean)
            btnMarcarItems.Visible = value
            'btnFacturar.Visible = value
            'ToolStripSeparator1.Visible = value
            'tss004.Visible = value
            btnAdjuntar.Visible = value
            'tss003.Visible = value
            btnConsistencia.Visible = value
            'tss002.Visible = value
            'btnRevisado.Visible = value
            'tss001.Visible = value
            btnQuitaConsistencia.Visible = value
            tsLabelSeparator.Visible = value
            btnBuscar.Visible = value
            ToolStripButton3.Visible = value
            'btnBoleta.Visible = value
            'btnModificar.Visible = value
            dtgOperaciones.Columns("chk").Visible = value
        End Set
    End Property

#End Region

#Region "Eventos de Control"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Refrescar()
    End Sub

    Private Sub dtgOperaciones_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOperaciones.DataBindingComplete
        Dim sumaDolares As Double = 0D
        Dim sumaSoles As Double = 0D
        Dim cambio As Double = CType(IIf(lblTipoCambio_1.Text = "0", "0", lblTipoCambio_1.Text), Decimal)
        Dim montoTemp As Double = 0D
        For i As Integer = 0 To dtgOperaciones.Rows.Count - 1
            If Me.dtgOperaciones.Rows(i).Cells("CMNDA1").Value() = 100 Then
                montoTemp = IIf(IsDBNull(Me.dtgOperaciones.Rows(i).Cells("MONTO").Value()), 0, Me.dtgOperaciones.Rows(i).Cells("MONTO").Value())
                sumaDolares = sumaDolares + montoTemp
                If cambio <> 0 Then
                    sumaSoles = sumaSoles + (Me.dtgOperaciones.Rows(i).Cells("MONTO").Value() * cambio)
                End If
            Else
                If cambio <> 0 Then
                    sumaDolares = sumaDolares + (Me.dtgOperaciones.Rows(i).Cells("MONTO").Value() / cambio)
                End If
                sumaSoles = sumaSoles + Me.dtgOperaciones.Rows(i).Cells("MONTO").Value()
            End If
            'DESCRIPCION TIPO ALMACENAJE
            Select Case Me.dtgOperaciones.Rows(i).Cells("CTPALJ").Value.ToString.Trim
                Case Estatico.E_ESP_Manual '"MA"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANUAL"
                Case Estatico.E_ESP_Adicional '"AD"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ADICIONAL"
                Case Estatico.E_ESP_General, "" '"GE"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "GENERAL"
                Case Estatico.E_ESP_Reembolso
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "REEMBOLSO"
                Case Estatico.E_ESP_Almacenaje '"AL"
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE"
                Case Estatico.E_ESP_AlmacenajePeso 'AP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR FECHA DE CORTE"
                Case Estatico.E_ESP_ManipuleoPeso 'MP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "MANIPULEO POR FECHA DE CORTE"
                Case Estatico.E_ESP_PesoPromedio 'PP
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PESO PROMEDIOS"
                Case Estatico.E_ESP_Permanencia 'PE
                    Me.dtgOperaciones.Rows(i).Cells("TIP_ALJ").Value = "ALMACENAJE POR PERMANENCIA"

            End Select


            If Me.dtgOperaciones.Rows(i).DataBoundItem.Item("NMRGIM") > 0 Then
                Me.dtgOperaciones.Rows(i).Cells("LINK").Value() = My.Resources.text_block
            Else
                Me.dtgOperaciones.Rows(i).Cells("LINK").Value() = My.Resources.filesave
            End If


        Next

        sTotalDatosPorOperacion = "Monto a Cobrar : S/. " & Format(sumaSoles, "###,###,###,###.00") & " / - - / Monto a Cobrar : USD " & Format(sumaDolares, "###,###,###,###.00")
    End Sub

    'Private Sub dtgOperaciones_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgOperaciones.CurrentCellChanged
    '    If dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
    '    Cargar_Servicios_x_Operacion()
    'End Sub

    Private Sub UcPorOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Marcar = btnMarcarItems.BackgroundImage
        Desmarcar = btnMarcarItems.Image
    End Sub

    Private Sub dtgOperaciones_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellDoubleClick
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        Try
            'If dtgOperaciones.Columns(e.ColumnIndex).Name = "chk" Then
            '    If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("NDCFCC").ToString.Equals("0") Then
            '        dtgOperaciones.CurrentRow.Cells("chk").Value = False
            '        Me.dtgOperaciones.EndEdit()
            '    End If
            'End If
            If dtgOperaciones.Columns(e.ColumnIndex).Name = "chk" Then
                If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("FLGFAC").ToString.Equals("N") Then
                    dtgOperaciones.CurrentRow.Cells("chk").Value = False
                    Me.dtgOperaciones.EndEdit()
                End If
            End If

            If dtgOperaciones.Columns(e.ColumnIndex).Name = "LINK" Then
                If Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("NMRGIM") <> 0 Then

                    'Try
                    'Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos
                    'ofrmAdjuntarDocumentos.PNCCLNT = Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                    'ofrmAdjuntarDocumentos.pCCMPN = Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("CCMPN")
                    'ofrmAdjuntarDocumentos.pNMRGIM = Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("NMRGIM")
                    'ofrmAdjuntarDocumentos.PNNOPRCN = Me.dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                    'ofrmAdjuntarDocumentos.pTABLE_NAME = "RZSC19"
                    'ofrmAdjuntarDocumentos.PSUSUARIO = oServicio.PSUSUARIO
                    'ofrmAdjuntarDocumentos.ShowDialog()
                    'btnBuscar_Click(Nothing, Nothing)
                    'Catch ex As Exception
                    '    MessageBox.Show(ex.Message)
                    'End Try

                End If
            End If


            If dtgOperaciones.Columns(e.ColumnIndex).Name = "AUDI" Then
                Dim ofrmAuditoria As New frmAuditoria
                With ofrmAuditoria

                    .txtUsuarioCreador.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("CUSCRT")
                    .txtFechaCreacion.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("FCHCRT")
                    .txtHoraCreacion.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("HRACRT")

                    .txtFechaActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("FULTAC")
                    .txtUsuarioActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("CULUSA")
                    .txtHoraActualizado.Text = CType(dtgOperaciones.CurrentRow.DataBoundItem, DataRowView).Row.Item("HULTAC")

                End With


                ofrmAuditoria.ShowDialog()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click

        Me.Cursor = Cursors.WaitCursor
        dtgOperaciones.Columns("chk").ReadOnly = True
        If dtgOperaciones.RowCount > 0 Then
            If Existe_Check() Then
                Poner_Check_Todo_OC(False)
                btnMarcarItems.Image = Desmarcar
            Else
                If Not (oServicio.FLGFAC = "S" OrElse oServicio.FLGFAC = "0") Then
                    Poner_Check_Todo_OC(True)
                    btnMarcarItems.Image = Marcar
                End If
            End If
        End If
        Me.dtgOperaciones.EndEdit()
        dtgOperaciones.Columns("chk").ReadOnly = False
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub dtgOperaciones_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperaciones.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        'If dtgOperaciones.Columns(e.ColumnIndex).Name = "chk" Then
        '    If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("NDCFCC").ToString.Equals("0") Then
        '        dtgOperaciones.CurrentRow.Cells("chk").Value = False
        '        Me.dtgOperaciones.EndEdit()
        '    End If
        'End If
        If dtgOperaciones.Columns(e.ColumnIndex).Name = "chk" Then
            If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("FLGFAC").ToString.Equals("N") Then
                dtgOperaciones.CurrentRow.Cells("chk").Value = False
                Me.dtgOperaciones.EndEdit()
            End If
        End If
    End Sub

    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim oServ As New Servicio_BE

        oServ = oServicio

        Dim frm As New UcFrmConsistencia(oServ)
        'frm.TipoAlmacen = _pTipoAlmacen

        frm.TipoAlmacen = dtgOperaciones.CurrentRow.Cells("STPODP").Value

        frm.Revision = Val(dtgOperaciones.CurrentRow.Cells("NSECFC").Value)

        If Val(dtgOperaciones.CurrentRow.Cells("NSECFC").Value) > 0 And (oServ.CTPALJ = "0" Or oServ.CTPALJ = "") Then
            oServ.CTPALJ = dtgOperaciones.CurrentRow.Cells("CTPALJ").Value
        End If
        oServ.CPLNDV = dtgOperaciones.CurrentRow.Cells("CPLNDV").Value
        frm.ShowDialog()


    End Sub

    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntar.Click
        ' oServicio = New Servicio_BE
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        'Try
        '    Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos
        '    ofrmAdjuntarDocumentos.PNCCLNT = Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
        '    ofrmAdjuntarDocumentos.pCCMPN = Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("CCMPN")
        '    ofrmAdjuntarDocumentos.pNMRGIM = Me.dtgOperaciones.CurrentRow.DataBoundItem.Item("NMRGIM")
        '    ofrmAdjuntarDocumentos.PNNOPRCN = Me.dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
        '    ofrmAdjuntarDocumentos.pTABLE_NAME = "RZSC19"
        '    ofrmAdjuntarDocumentos.PSUSUARIO = oServicio.PSUSUARIO
        '    ofrmAdjuntarDocumentos.ShowDialog()
        '    btnBuscar_Click(Nothing, Nothing)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    'Private Sub btnRevisado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevisado.Click
    '    If dtgOperaciones.RowCount = 0 Then Exit Sub
    '    RaiseEvent Procesar_Consistencias(dtgOperaciones)
    '    Limpiar_Grilla_Servicio()
    '    Refrescar()
    'End Sub

    Private Sub btnQuitaConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitaConsistencia.Click

        If dtgOperaciones.Rows.Count = 0 Then Exit Sub

        If MsgBox("Seguro que desea eliminar la Consistencia ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Me.dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            RaiseEvent Anular_Revision(dtgOperaciones)
        Else
            Exit Sub
        End If
        Limpiar_Grilla_Servicio()
        Refrescar()
    End Sub

    'Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

    '    '=========VALIDACIONES=============
    '    If Me.dtgOperaciones.Rows.Count = 0 Then Exit Sub
    '    If Me.dtgServiciosOperacion.Rows.Count = 0 Then Exit Sub
    '    If dtgOperaciones.CurrentRow.DataBoundItem.Item("FLGFAC").ToString.Equals("S") Then Exit Sub
    '    '==================================

    '    '=========Validamos si esta provisionado
    '    Dim obeServicio As Servicio_BE
    '    Dim olstServicio As New List(Of Servicio_BE)
    '    obeServicio = New Servicio_BE
    '    obeServicio.CCMPN = dtgOperaciones.CurrentRow.Cells("CCMPN").Value
    '    obeServicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
    '    obeServicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
    '    obeServicio.NSECFC = dtgOperaciones.CurrentRow.Cells("NSECFC").Value
    '    obeServicio.CDIRSE = dtgOperaciones.CurrentRow.Cells("CDIRSE").Value
    '    obeServicio.TIPO_REV = "2"
    '    olstServicio.Add(obeServicio)
    '    If fblnValidarProvision(olstServicio) Then Exit Sub
    '    '=========Validamos si esta provisionado

    '    Me.Cursor = Cursors.WaitCursor
    '    With oServicio
    '        .TIPO = Comun.ESTADO_Modificado
    '        .NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
    '        .NSECFC = dtgOperaciones.CurrentRow.DataBoundItem.Item("NSECFC")
    '        .CCLNFC = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNFC")
    '        .CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
    '        .CPLNDV = dtgOperaciones.CurrentRow.DataBoundItem.Item("CPLNDV")
    '        .FOPRCN = Comun.FormatoFechaAS400(("" & dtgOperaciones.CurrentRow.DataBoundItem.Item("FOPRCN")).ToString.Trim)
    '        .STIPPR = dtgOperaciones.CurrentRow.DataBoundItem.Item("STIPPR")
    '        .CTPALJ = dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")
    '        .STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")

    '        .CUNDMD = dtgServiciosOperacion.Rows(0).Cells("CUNDMD").Value 'Enviamos la 1ra. unidad de medida 
    '        .FECINI = dtgServiciosOperacion.Rows(0).Cells("FINPRF").Value 'Fecha Inicio 
    '        .FECFIN = dtgServiciosOperacion.Rows(0).Cells("FFNPRF").Value 'Fecha Fin
    '        .TLUGEN = dtgServiciosOperacion.Rows(0).Cells("TLUGEN").Value.ToString.Trim
    '        .TCTCST = dtgServiciosOperacion.Rows(0).Cells("TCTCST").Value.ToString.Trim
    '        .NORCML = dtgServiciosOperacion.Rows(0).Cells("NORCML").Value.ToString.Trim


    '        If dtgBultos.Rows.Count > 0 Then .CTPALM = dtgBultos.Rows(0).Cells("CTPALM").Value.ToString.Trim 'SOLO CUANDO GUARDAN SUSTENTO
    '    End With

    '    If Not dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN").ToString.Equals("0") Then

    '        Dim frm As New UcFrmServicioAgregarSA_DS()
    '        frm.oServicio = oServicio
    '        frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.MODIFICA.SERVICIO")
    '        frm.txtDireccion.Text = dtgOperaciones.CurrentRow.DataBoundItem.Item("DIRECSERV").ToString.Trim
    '        frm.txtUbigeo.Text = dtgOperaciones.CurrentRow.DataBoundItem.Item("UBIGEO").ToString.Trim
    '        frm.codigoDireccionServicio = dtgOperaciones.CurrentRow.DataBoundItem.Item("CDIRSE").ToString.Trim

    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Refrescar()

    '        End If

    '    End If


    '    Me.Cursor = Cursors.Default
    'End Sub

    'Private Sub FacturaResumidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaResumidadToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Facturar(floOpercionesConCheck, 1)

    'End Sub

    'Private Sub FacturaDetalladaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaDetalladaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Facturar(floOpercionesConCheck, 2)

    'End Sub

    'Private Sub BoletaResumidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaResumidaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Boleta(floOpercionesConCheck, 1)
    'End Sub

    'Private Sub BoletaDetalladaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaDetalladaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent Boleta(floOpercionesConCheck, 2)
    'End Sub

    Private Sub btnAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDetalle.Click
        If dtgOperaciones.CurrentRow Is Nothing Then Exit Sub
        Select Case TabDetalles.SelectedTab.Name
            'Case "TabServicio"
            '    btnModificar_Click(Nothing, Nothing)
            Case "TabReembolso"
                Exit Sub
            Case "TabBulto"
                Select Case dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")
                    Case Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_PesoPromedio
                        Exit Sub
                End Select

                With oServicio
                    .TIPO = Comun.ESTADO_Modificado

                    .NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
                    .CPLNDV = dtgOperaciones.CurrentRow.DataBoundItem.Item("CPLNDV")
                    .CCLNFC = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNFC")
                    .CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
                    .NRTFSV = dtgServiciosOperacion.CurrentRow.DataBoundItem.Item("NRTFSV")
                    .QATNAN = dtgServiciosOperacion.CurrentRow.DataBoundItem.Item("QATNAN")
                    .FOPRCN = Comun.FormatoFechaAS400(dtgOperaciones.CurrentRow.DataBoundItem.Item("FOPRCN"))
                    .STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")

                End With
                If oServicio.STPODP = "7" Then
                    Dim ofrmBuscarBulto As New frmBuscarBulto(oServicio)
                    If ofrmBuscarBulto.ShowDialog = DialogResult.OK Then
                        Cargar_Detalle_Servicios()
                    End If
                Else
                    Dim ofrmBuscarOs As New frmBuscarOs(oServicio)
                    If ofrmBuscarOs.ShowDialog = DialogResult.OK Then
                        Cargar_Detalle_Servicios()
                    End If
                End If
            Case "TabEmbarque"
                Dim intCont As Integer
                Dim oServicio As New Servicio_BE
                If Me.dtgOperaciones.Rows.Count = 0 Then Exit Sub
                intCont = Me.dtgOperaciones.CurrentRow.Index
                If dtgOperaciones.Rows(intCont).Cells("NDCCTC").Value <> 0 Then Exit Sub
                Me.Cursor = Cursors.WaitCursor
                With oServicio
                    .TIPO = Comun.ESTADO_Modificado

                    .NOPRCN = Me.dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value
                    .CCLNFC = Me.dtgOperaciones.Rows(intCont).Cells("CCLNFC").Value
                    .CCLNT = Me.dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                    .NRTFSV = Me.dtgOperaciones.Rows(intCont).Cells("NRTFSV").Value
                    .QATNAN = Me.dtgOperaciones.Rows(intCont).Cells("QATNAN").Value
                    .CPLNDV = Me.dtgOperaciones.Rows(intCont).Cells("CPLNDV").Value
                    .FOPRCN = Comun.FormatoFechaAS400(dtgOperaciones.Rows(intCont).Cells("FOPRCN").Value)
                    .STIPPR = Me.dtgOperaciones.Rows(intCont).Cells("STIPPR").Value
                    .TIPOALM = 7
                End With
                Dim frm As New frmBuscarEmbarque
                frm.pCCLNT = dtgOperaciones.Rows(intCont).Cells("CCLNT").Value
                frm.pNOPRCN = Me.dtgOperaciones.Rows(intCont).Cells("NOPRCN").Value
                frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.MODIFICA.SERVICIO")
                frm.ShowDialog()
                If (frm.pDialogResult = True) Then
                    Limpiar_Grilla_Servicio()
                    Refrescar()
                End If
                Me.Cursor = Cursors.Default
        End Select
    End Sub

    Private Sub btnEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDetalle.Click, ToolStripButton3.Click
        If dtgOperaciones.CurrentRow Is Nothing Then Exit Sub
        Select Case TabDetalles.SelectedTab.Name
            Case "TabServicio"

                ''=========Validamos si esta provisionado
                'Dim obeServicio As Servicio_BE
                'Dim olstServicio As New List(Of Servicio_BE)
                'obeServicio = New Servicio_BE
                'obeServicio.CCMPN = dtgOperaciones.CurrentRow.Cells("CCMPN").Value
                'obeServicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                'obeServicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                'obeServicio.NSECFC = dtgOperaciones.CurrentRow.Cells("NSECFC").Value
                'obeServicio.TIPO_REV = "2"
                'olstServicio.Add(obeServicio)
                'If fblnValidarProvision(olstServicio) Then Exit Sub
                ''=========Validamos si esta provisionado


                ' '''''''''''ELIMINAR SERVICIO Y EN CASO DE SER EL ULTIMO ELIMINAR LA OPERACION Y LOS DETALLES'''''''''''''''
                'Dim msjMoneda As String = ""
                'Dim msjMonto As String = ""
                'Dim flgEliminaExito As Integer = 0
                'If dtgServiciosOperacion.Rows.Count = 0 Then Exit Sub
                'If dtgServiciosOperacion.Rows.Count > 1 Then
                '    msjMoneda = dtgServiciosOperacion.CurrentRow.Cells("TSGNMN_SRV").Value
                '    msjMonto = "" & dtgServiciosOperacion.CurrentRow.Cells("MONTO_SRV").Value
                '    If msjMonto.Length = 0 Then
                '        msjMoneda = msjMoneda & " 0"
                '    Else
                '        msjMoneda = msjMoneda & " " & Math.Round(dtgServiciosOperacion.CurrentRow.Cells("MONTO_SRV").Value, 2)
                '    End If



                '    If MsgBox("Va a eliminar un Servicio con tarifa = " & msjMoneda & ". ¿Desea Continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        Dim oServEli As New Servicio_BE
                '        oServEli.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                '        oServEli.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                '        oServEli.NCRROP = dtgServiciosOperacion.CurrentRow.Cells("NCRROP").Value
                '        oServEli.PSUSUARIO = oServicio.PSUSUARIO
                '        flgEliminaExito = oServicioOpeNeg.EliminarServiciosFacturacionAlmacenaje(oServEli)

                '    End If
                'End If
                'If dtgServiciosOperacion.Rows.Count = 1 Then
                '    If MsgBox("Se eliminara también la operación asociada al servicio a eliminar. ¿Desea Continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        If dtgOperaciones.CurrentRow.DataBoundItem.Item("NSECFC") > 0 Then
                '            MsgBox("No se puede Anular , tiene asignado un Nro de Consistencia", MsgBoxStyle.Information, "Información")
                '            Exit Sub
                '        End If
                '        Refrescar()
                '    End If
                'End If
                'If flgEliminaExito = 1 Then
                '    dtgServiciosOperacion.Rows.Remove(dtgServiciosOperacion.CurrentRow)
                '    Refrescar()
                'End If
            Case "TabReembolso"
                Exit Sub
            Case "TabBulto"
                If dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP").Trim.Equals("7") And dtgBultos.CurrentRow Is Nothing Then
                    Exit Sub
                End If
                If dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP") <> "7" And dtgMercaderia.CurrentRow Is Nothing Then
                    Exit Sub
                End If
                Select Case dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")
                    Case Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_PesoPromedio
                        Exit Sub
                End Select
                If MessageBox.Show("Esta seguro de eliminar el bulto seleccionado?", "Información", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim oServAdqu As New Servicio_BE
                    oServAdqu.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
                    oServAdqu.CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
                    oServAdqu.STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")
                    If oServAdqu.STPODP.Trim.Equals("7") Then
                        oServAdqu.NCRRDC = Me.dtgBultos.CurrentRow.DataBoundItem.Item("NCRRDC")
                    Else
                        oServAdqu.NCRRDC = Me.dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC")
                    End If
                    oServAdqu.PSUSUARIO = oServicio.PSUSUARIO
                    If oServicioOpeNeg.fintEliminarDetalleServiciosFacturacionSA(oServAdqu) = 0 Then
                        MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                    Else
                        If oServAdqu.STPODP.Trim.Equals("7") Then
                            dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                        Else
                            dtgMercaderia.Rows.Remove(dtgMercaderia.CurrentRow)
                        End If
                    End If
                End If
            Case "TabEmbarque"
                Dim msgInformativo As String = ""
                Dim PNNORSCI As Decimal = 0
                Dim PNNRITEM As Decimal = 0
                Dim obrclsServicioSC_BL As New clsServicioSC_BL
                Dim retorno As Int32 = 0
                If (dtgDetalleServicioSil.CurrentRow IsNot Nothing) Then
                    PNNORSCI = dtgDetalleServicioSil.CurrentRow.Cells("NORSCI").Value
                    PNNRITEM = dtgDetalleServicioSil.CurrentRow.Cells("NRITEM").Value
                    msgInformativo = String.Format("Está seguro de eliminar el embarque {0} asociado a la operación", PNNORSCI)
                    If (MessageBox.Show(msgInformativo, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        Dim oEmbarqueServicio As New Servicio_BE
                        oEmbarqueServicio.CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value
                        oEmbarqueServicio.NOPRCN = dtgOperaciones.CurrentRow.Cells("NOPRCN").Value
                        oEmbarqueServicio.NORSCI = PNNORSCI
                        oEmbarqueServicio.PSUSUARIO = oServicio.PSUSUARIO
                        oEmbarqueServicio.NRITEM = PNNRITEM
                        retorno = obrclsServicioSC_BL.Eliminar_Item_Embarque_Servicio_SC(oEmbarqueServicio)
                        If (retorno = 1) Then
                            Cargar_Detalle_Servicios()
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub dtgBultos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBultos.CellContentClick
        If Me.dtgBultos.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgBultos.Columns(e.ColumnIndex).Name = "IMG" Then
            'Dim oServicio As New Servicio_BE
            With oServicio
                '.CCMPN = cmbCompania.SelectedValue
                '.CDVSN = cmbDivision.SelectedValue
                .CPLNDV = Me.dtgOperaciones.CurrentRow.Cells("CPLNDV").Value.ToString.Trim
                .CCLNT = dtgOperaciones.CurrentRow.Cells("CCLNT").Value.ToString.Trim
                .CREFFW = Me.dtgBultos.CurrentRow.Cells("CREFFW").Value.ToString.Trim
                .NSEQIN = Me.dtgBultos.CurrentRow.Cells("NSEQIN").Value.ToString.Trim
                .STIPPR = Me.dtgOperaciones.CurrentRow.Cells("STIPPR").Value.ToString.Trim
            End With
            Dim ofrmDetalleBulto As New frmDetalleBulto
            ofrmDetalleBulto.oDetalleServicio = oServicio
            If ofrmDetalleBulto.ShowDialog() = DialogResult.Cancel Then
            End If
        End If


    End Sub

    Private Sub dtgDetalleServicioSil_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetalleServicioSil.CellDoubleClick
        If Me.dtgDetalleServicioSil.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgDetalleServicioSil.Columns(e.ColumnIndex).Name = "DETALLE" Then
            Dim oUcFrmEmbarqueDetalle As New UcFrmEmbarqueDetalle
            oUcFrmEmbarqueDetalle.pCCLNT = Me.dtgOperaciones.CurrentRow.Cells("CCLNT").Value
            oUcFrmEmbarqueDetalle.pNORSCI = Me.dtgDetalleServicioSil.Rows(e.RowIndex).Cells("NORSCI").Value
            oUcFrmEmbarqueDetalle.ShowDialog()
        End If
    End Sub

#End Region

#Region "Procedimientos y funciones"

    Public Sub Refrescar()
        Limpiar_Detalle_Servicios()
        RaiseEvent Listar_Operaciones(_oServicio, dtgOperaciones)
        'dtgOperaciones_CurrentCellChanged(Nothing, Nothing)
    End Sub

    Private Sub Cargar_Servicios_x_Operacion()
        Dim oDt As New DataTable
        Dim _oServicioOper As New Servicio_BE
        Me.dtgServiciosOperacion.DataSource = Nothing
        If dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub


        _oServicioOper.CDVSN = dtgOperaciones.CurrentRow.DataBoundItem.Item("CDVSN")
        _oServicioOper.CCMPN = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCMPN")
        _oServicioOper.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")

        oDt = oServicioOpeNeg.fdtListaServicioOperacion(_oServicioOper)
        dtgServiciosOperacion.AutoGenerateColumns = False
        dtgServiciosOperacion.DataSource = oDt

        Cargar_Detalle_Servicios()

    End Sub

    Private Sub Cargar_Detalle_Servicios()
        If Me.dtgOperaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        If Me.dtgServiciosOperacion.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dtgBultos.DataSource = Nothing
        Me.dtgMercaderia.DataSource = Nothing
        dtgDetalleServicioSil.DataSource = Nothing


        oServicio.CCLNT = dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNT")
        oServicio.NOPRCN = dtgOperaciones.CurrentRow.DataBoundItem.Item("NOPRCN")
        oServicio.NRTFSV = dtgServiciosOperacion.CurrentRow.DataBoundItem.Item("NRTFSV")
        oServicio.CPLNDV = dtgOperaciones.CurrentRow.DataBoundItem.Item("CPLNDV")
        oServicio.STPODP = dtgOperaciones.CurrentRow.DataBoundItem.Item("STPODP")

        oServicio.CTPALJ = dtgOperaciones.CurrentRow.DataBoundItem.Item("CTPALJ")

        Dim iValida As String = oServicio.STPODP

        If oServicio.CTPALJ <> Estatico.E_ESP_General Then iValida = oServicio.CTPALJ.Trim '"GE"

        Select Case oServicio.CDVSN
            Case "R" ' =========ALMACEN===========
                InhabilitaTabs()
                HabilitaTabs(oServicio.CDVSN, oServicio.STPODP.Trim, oServicio.CTPALJ.Trim)
                Select Case iValida
                    Case Comun.eTipoAlmacen.AlmTransito, Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_PesoPromedio, Estatico.E_ESP_Almacenaje
                        dtgBultos.AutoGenerateColumns = False
                        dtgBultos.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosFacturacionSA(oServicio)
                    Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple '"1", "5"
                        dtgMercaderia.AutoGenerateColumns = False
                        Me.dtgMercaderia.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosFacturacionSA(oServicio)
                    Case Estatico.E_ESP_Reembolso  'Comun.ESP_Reembolso '"RE"
                        dtgReembolso.AutoGenerateColumns = False
                        Me.dtgReembolso.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosReembolso(oServicio)
                End Select
            Case "S" ' ===========SIL=============
                Dim oDt As New DataTable
                Dim oclsServicioSC_DAL As New clsServicioSC_DAL
                oDt = oclsServicioSC_DAL.Lista_Detalle_Servicios_SC(oServicio)
                dtgDetalleServicioSil.AutoGenerateColumns = False
                dtgDetalleServicioSil.DataSource = oDt
        End Select
    End Sub

    Public Sub InhabilitaTabs()
        Me.TabDetalles.TabPages.Remove(TabBulto)
        Me.TabDetalles.TabPages.Remove(TabEmbarque)
        Me.TabDetalles.TabPages.Remove(TabMercaderia)
        Me.TabDetalles.TabPages.Remove(TabReembolso)
    End Sub

    Public Sub HabilitaTabs(ByVal pstrDivision As String, Optional ByVal tAlm As Integer = 0, Optional ByVal tCTPALJ As String = "")
        Dim iValida As String
        iValida = _pTipoAlmacen
        If iValida = 0 Then iValida = tAlm 'En caso de ser generico utiliza el tipo de la celda     
        If tCTPALJ <> Estatico.E_ESP_General Then iValida = tCTPALJ '"GE"
        Select Case pstrDivision
            Case "S"
                Me.TabDetalles.TabPages.Add(TabEmbarque)
            Case "R"
                Select Case iValida
                    Case Comun.eTipoAlmacen.AlmTransito, Estatico.E_ESP_AlmacenajePeso, Estatico.E_ESP_ManipuleoPeso, Estatico.E_ESP_Permanencia, Estatico.E_ESP_Almacenaje '"AL"
                        Me.TabDetalles.TabPages.Add(TabBulto)
                    Case Estatico.E_ESP_PesoPromedio
                        '====================================================================
                        '======================EL TAB CON LOS PROMEDIOS======================
                        '====================================================================
                    Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple
                        Me.TabDetalles.TabPages.Add(TabMercaderia)
                    Case Estatico.E_ESP_Reembolso  'Comun.ESP_Reembolso '"RE"
                        Me.TabDetalles.TabPages.Add(TabReembolso)
                End Select
        End Select
    End Sub

    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(intCont).Cells("chk").Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgOperaciones.RowCount - 1
            dtgOperaciones.Rows(intCont).Cells("chk").Value = blnEstado
        Next intCont
    End Sub

    Public Sub Limpiar_Detalle_Servicios()
        Me.dtgServiciosOperacion.DataSource = Nothing
        Me.dtgDetalleServicioSil.DataSource = Nothing
        Me.dtgBultos.DataSource = Nothing
        Me.dtgMercaderia.DataSource = Nothing
        Me.dtgReembolso.DataSource = Nothing
    End Sub

    Public Sub Limpiar_Grilla_Servicio()
        dtgOperaciones.DataSource = Nothing
    End Sub

    Private Function floOpercionesConCheck() As List(Of Servicio_BE)
        dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim olOperacion As New List(Of Servicio_BE)
        Dim BE_servicio As New Servicio_BE
        Dim intCOnt As Integer
        For intCOnt = 0 To dtgOperaciones.Rows.Count - 1
            'If Convert.ToBoolean(dtgOperaciones.Rows(intCOnt).Cells("chk").Value) = True And dtgOperaciones.Rows(intCOnt).DataBoundItem.Item("NDCFCC").ToString.Equals("0") Then
            If Convert.ToBoolean(dtgOperaciones.Rows(intCOnt).Cells("chk").Value) = True AndAlso dtgOperaciones.Rows(intCOnt).DataBoundItem.Item("FLGFAC").ToString.Equals("N") Then
                BE_servicio = New Servicio_BE
                BE_servicio.CCMPN = oServicio.CCMPN
                BE_servicio.CDVSN = oServicio.CDVSN

                BE_servicio.CPLNDV = dtgOperaciones.Rows(intCOnt).Cells("CPLNDV").Value
                BE_servicio.CCLNT = dtgOperaciones.Rows(intCOnt).Cells("CCLNT").Value

                BE_servicio.NOPRCN = dtgOperaciones.Rows(intCOnt).Cells("NOPRCN").Value

                BE_servicio.CMNDA1 = dtgOperaciones.Rows(intCOnt).Cells("CMNDA1").Value
                BE_servicio.TSGNMN = dtgOperaciones.Rows(intCOnt).Cells("TSGNMN").Value

                BE_servicio.CCLNFC = dtgOperaciones.Rows(intCOnt).Cells("CCLNFC").Value

                BE_servicio.TCMPDV = dtgOperaciones.Rows(intCOnt).Cells("TCMPDV").Value

                BE_servicio.CRGVTA = dtgOperaciones.Rows(intCOnt).Cells("CRGVTA").Value


                olOperacion.Add(BE_servicio)
            End If
        Next intCOnt
        Return olOperacion
    End Function

    'Private Function fblnValidarProvision(ByVal olstServicio As List(Of Servicio_BE)) As Boolean
    '    Dim intResultado As Integer = 0
    '    'Dim intCont As Integer = 0

    '    For Each obeServicio As Servicio_BE In olstServicio
    '        intResultado = oServicioOpeNeg.intTieneProvision(obeServicio)
    '        Select Case intResultado
    '            Case 0
    '                Ransa.Utilitario.HelpClass.ErrorMsgBox()
    '            Case 2
    '                'Validamos si el Usuario tiene permiso para Anular la provisión
    '                Try
    '                    If oServicioOpeNeg.fblnUsuarioPermitidoRevertirProvision(Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName) Then
    '                        If obeServicio.TIPO_REV = "1" Then
    '                            If MsgBox("La Revisión :" & obeServicio.NSECFC & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
    '                                Return True
    '                                Me.Cursor = System.Windows.Forms.Cursors.Default
    '                                Return True
    '                            End If
    '                        Else
    '                            If MsgBox("La Operación :" & obeServicio.NOPRCN & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
    '                                Me.Cursor = System.Windows.Forms.Cursors.Default
    '                                Return True
    '                            End If
    '                        End If
    '                    Else
    '                        'Usuario No puede Generar un revisado o Eliminar la provisión
    '                        MsgBox("Usted no tiene  autorización para administrar la operación :" & obeServicio.NOPRCN & " porque se encuentra provisionada.")
    '                        Return True
    '                    End If
    '                Catch ex As Exception
    '                    Ransa.Utilitario.HelpClass.ErrorMsgBox()
    '                    Return True
    '                End Try
    '        End Select
    '    Next




    '    Return False
    'End Function

#End Region

    

#Region "Facturacion Electrnonica"

    Private Sub FacturaResumidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaResumidaToolStripMenuItem.Click
        If oServicio.CCLNT = 0 Then
            MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim olOperacion As New List(Of Servicio_BE)
        RaiseEvent FacturarElectronica(floOpercionesConCheck, 1, Utilitario.HelpClass.TipoLista.OPERACION)

    End Sub

    Private Sub FacturaDetalladaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaDetalladaToolStripMenuItem1.Click
        If oServicio.CCLNT = 0 Then
            MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim olOperacion As New List(Of Servicio_BE)
        RaiseEvent FacturarElectronica(floOpercionesConCheck, 2, Utilitario.HelpClass.TipoLista.OPERACION)

    End Sub

    'Private Sub BoletaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent BoletaElectronica(floOpercionesConCheck, 1)
    'End Sub

    'Private Sub BoletaDetalladaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletaDetalladaToolStripMenuItem1.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent BoletaElectronica(floOpercionesConCheck, 2)
    'End Sub

#End Region

#Region "Parte Transferencia"


    'Private Sub ParteTransResumidaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParteTransResumidaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent ParteTransferencia(floOpercionesConCheck, 1)
    'End Sub

    'Private Sub ParteTransDetalladaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParteTransDetalladaToolStripMenuItem.Click
    '    If oServicio.CCLNT = 0 Then
    '        MsgBox("Ingrese Un Cliente Operación", MsgBoxStyle.Information, "Información")
    '        Me.Cursor = Cursors.Default
    '        Exit Sub
    '    End If

    '    Dim olOperacion As New List(Of Servicio_BE)
    '    RaiseEvent ParteTransferencia(floOpercionesConCheck, 2)
    'End Sub

#End Region

    Private Sub dtgOperaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgOperaciones.SelectionChanged

        RaiseEvent SelectionarRegistro()
        If dtgOperaciones.CurrentRow Is Nothing Then
            _pClienteFacturar = 0
        Else
            _pClienteFacturar = Val(dtgOperaciones.CurrentRow.DataBoundItem.Item("CCLNFC").ToString)
        End If

        Cargar_Servicios_x_Operacion()
    End Sub

End Class

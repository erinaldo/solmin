Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF.Cliente

Public Class frmAnularProcesoIngDesp

    Private Sub frmRecepcionesPendienteAprobacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '-- Crear status por control con F4
        ' Me.bsaPuntoEntrega.Visible = False
        ' Me.bsaAnularItemGS.Visible = False
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Iniciar la fecha de los controles
        dtpFechaInicial.Value = Now.Date
        dtpFechaFinal.Value = Now.Date
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("DespachoClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        objAppConfig = Nothing
    End Sub


    Private Sub Buscar()
        Dim obrDespacho As New brDespacho
        Dim obeDespacho As New beDespacho
        With obeDespacho
            .PNCCLNT = Me.txtCliente.pCodigo
            .PNNGUIRN = Val(Me.txtNroGuiaRANSA.Text)
            .PNFECINI = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaInicial.Value.Date)
            .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaFinal.Value.Date)
            .PNNORDSR = Val(txtNroOS.Text.Trim)

        End With
        dtgGuiasRansa.AutoGenerateColumns = False
        Me.dtgGuiasRansa.DataSource = obrDespacho.ListaGuiaRansa(obeDespacho)
    End Sub

    Private Sub dgGuiasRansa_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgGuiasRansa.SelectionChanged
        If Me.dtgGuiasRansa.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obrDespacho As New brDespacho

        dtgMovimientos.AutoGenerateColumns = False
        Me.dtgMovimientos.DataSource = obrDespacho.ListaMovimientosPorGuiaRansa(Me.dtgGuiasRansa.CurrentRow.DataBoundItem)

        'Dim obrDespacho As New brDespacho
        'Dim obeDespacho As New beDespacho
        'With obeDespacho
        '    .PNCCLNT = _CodCliente
        '    .PNNGUIRN = _CodGuiaRansa
        'End With
        'Me.dtgMovimientos.AutoGenerateColumns = False
        'Me.dtgMovimientos.DataSource = obrDespacho.ListaMovimientosPorGuiaRansa(Me.dtgGuiasRansa.CurrentRow.DataBoundItem)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Buscar()
    End Sub


    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dtgGuiasRansa.CurrentCellAddress.Y < 0 Then Exit Sub
        If MessageBox.Show("Esta seguro de Anular Guía?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim obrDespacho As New brDespacho
            Dim obeDespacho As New beDespacho
            With obeDespacho
                .PNCCLNT = Me.txtCliente.pCodigo
                .PNNGUIRN = dtgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN
                .PSCULUSA = objSeguridadBN.pUsuario
                .PSNLTECL = objSeguridadBN.pstrPCName
            End With
            Dim IntResultado As Integer

            'select case 
            If Not dtgGuiasRansa.CurrentRow.DataBoundItem.PSCTPOAT = "I" Then
                IntResultado = obrDespacho.AnularGuiaDeSalida(obeDespacho)
            Else
                'PENDIENTE
                IntResultado = obrDespacho.AnularGuiaDeIngreso(obeDespacho)
            End If

            If IntResultado = -1 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
            If IntResultado = 0 Then
                'MessageBox.Show("Guia de salida Anulada", "Información")
                Call Buscar()
            Else
                HelpClass.MsgBox("No se puede anular,no es el último movimiento realizado")
            End If
        End If
    End Sub

    Private Sub btnAnularItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularItems.Click
        If Me.dtgGuiasRansa.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim ofrmItemsDeGuia As New frmItemsDeGuia
        With ofrmItemsDeGuia
            .CodCliente = Me.txtCliente.pCodigo
            .CodGuiaRansa = dtgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN.ToString.Trim
            .Tipo = dtgGuiasRansa.CurrentRow.DataBoundItem.PSCTPOAT
            .TipMovimiento = dtgGuiasRansa.CurrentRow.DataBoundItem.PSSTPING
            '.AnularTodos = False
        End With
        If ofrmItemsDeGuia.ShowDialog = Windows.Forms.DialogResult.OK Then
            Buscar()
        End If
    End Sub

    Private Sub btnAnular_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            If Me.dtgGuiasRansa.CurrentCellAddress.Y < 0 Then Exit Sub
            'Dim obrInterfazOutoTec As New brInterfazOutoTec
            'Dim obeInftzOutotec As New beCabInfzOutotec
            'Dim intResultado As Integer = 1
            Dim obrGeneral As New Ransa.NEGO.brGeneral
            Dim IsOutotec As Boolean = False

            If obrGeneral.bolElClienteEsOutotec(txtCliente.pCodigo) Then
                '    With obeInftzOutotec
                '        .CodCliente = dtgGuiasRansa.CurrentRow.DataBoundItem.PNCCLNT
                '        .npensa = dtgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN
                '        .ctpdoc = IIf(dtgGuiasRansa.CurrentRow.DataBoundItem.PSCTPOAT.ToString.Trim.Equals("I"), "PE", "PS")
                '        .usuario = objSeguridadBN.pUsuario
                '    End With
                '    intResultado = obrInterfazOutoTec.fintAnularProcesoIngDesp(obeInftzOutotec)
                '    If intResultado = -1 Then
                '        HelpClass.ErrorMsgBox()

                '    End If
                '    'Si retorna 1 el proceso puede proceder a anular
                '    Select Case intResultado
                '        Case 2
                '            HelpClass.MsgBox("El pedido de anulación esta en proceso de aprobación")
                '        Case 0
                '            HelpClass.MsgBox("Se envió el pedido de anulacion a Outotec")

                '    End Select
                IsOutotec = True
            End If

            'If intResultado = 1 Then

            Dim ofrmItemsDeGuia As New frmItemsDeGuia
            With ofrmItemsDeGuia
                .CodCliente = Me.txtCliente.pCodigo
                .CodGuiaRansa = dtgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN.ToString.Trim
                .Tipo = dtgGuiasRansa.CurrentRow.DataBoundItem.PSCTPOAT
                .TipMovimiento = dtgGuiasRansa.CurrentRow.DataBoundItem.PSSTPING
                '.AnularTodos = False
                .Anular = True
                .IsOutotec = IsOutotec
            End With
            If ofrmItemsDeGuia.ShowDialog = Windows.Forms.DialogResult.OK Then
                Buscar()
            End If
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      


    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        If objSeguridadBN.pUsuario <> "AZORRILLAP" Then
            Dim obrGeneral As New brGeneral
            'Validamos que el clientes sea Outotec
            If obrGeneral.bolElClienteEsOutotec(Me.txtCliente.pCodigo) Then
                Me.btnAnularItems.Visible = False
                Me.tsbRevertir.Visible = False
            Else
                Me.btnAnularItems.Visible = True
                tsbRevertir.Visible = True
            End If
        End If
    End Sub

    Private Sub tsbRevertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRevertir.Click
        If Me.dtgGuiasRansa.CurrentCellAddress.Y < 0 Then Exit Sub
        'Dim obrInterfazOutoTec As New brInterfazOutoTec
        'Dim obeInftzOutotec As New beCabInfzOutotec
        'Dim intResultado As Integer = 1
        'Dim obrGeneral As New Ransa.NEGO.brGeneral

        'If obrGeneral.bolElClienteEsOutotec(txtCliente.pCodigo) Then
        '    With obeInftzOutotec
        '        .CodCliente = dtgGuiasRansa.CurrentRow.DataBoundItem.PNCCLNT
        '        .npensa = dtgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN
        '        .ctpdoc = IIf(dtgGuiasRansa.CurrentRow.DataBoundItem.PSCTPOAT.ToString.Trim.Equals("I"), "PE", "PS")
        '        .usuario = objSeguridadBN.pUsuario
        '    End With
        '    intResultado = obrInterfazOutoTec.fintAnularProcesoIngDesp(obeInftzOutotec)
        '    If intResultado = -1 Then
        '        HelpClass.ErrorMsgBox()
        '    End If
        '    'Si retorna 1 el proceso puede proceder a anular
        '    Select Case intResultado
        '        Case 2
        '            HelpClass.MsgBox("El pedido de anulación esta en proceso de aprobación")
        '        Case 0
        '            HelpClass.MsgBox("Se envió el pedido de anulacion a Outotec")

        '    End Select
        'End If

        'If intResultado = 1 Then

        Dim ofrmItemsDeGuia As New frmItemsDeGuia
        With ofrmItemsDeGuia
            .CodCliente = Me.txtCliente.pCodigo
            .CodGuiaRansa = dtgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN.ToString.Trim
            .Tipo = dtgGuiasRansa.CurrentRow.DataBoundItem.PSCTPOAT
            .TipMovimiento = dtgGuiasRansa.CurrentRow.DataBoundItem.PSSTPING
            '.AnularTodos = False
            .Anular = False
        End With
        If ofrmItemsDeGuia.ShowDialog = Windows.Forms.DialogResult.OK Then
            Buscar()
            'End If
        End If
    End Sub
End Class

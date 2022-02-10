Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmRevisarOCPortalDetalle
    Private objImpInfo As New SOLMIN_SC.Negocio.clsImpInfEmbarcador
    Private odtGlobalOk As DataTable
    Private objPortalDetalle As New SOLMIN_SC.Entidad.bePortalDetalle

    Public Sub New(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        objPortalDetalle = objPD
        CargaDtgDetalle()
    End Sub
    Private Sub CargaDtgDetalle()
        Dim oDtFiltrado As DataTable
        Dim oDtValidado As DataTable
        'Imagenes
        Dim btnOk As Bitmap
        Dim btnCancel As Bitmap
        Dim btnLupa As Bitmap
        Dim btnFlecha As Bitmap
        Dim btnBlanco As Bitmap
        btnOk = New Bitmap(Global.SOLMIN_SC.My.Resources.Resources.button_ok)
        btnCancel = New Bitmap(Global.SOLMIN_SC.My.Resources.Resources.button_cancel)
        btnLupa = New Bitmap(Global.SOLMIN_SC.My.Resources.Resources.lupa_10)
        btnFlecha = New Bitmap(Global.SOLMIN_SC.My.Resources.Resources.flecha)
        btnBlanco = New Bitmap(Global.SOLMIN_SC.My.Resources.Resources.CuadradoBlanco)

        'Bloqueamos boton actualizar
        If objPortalDetalle.PSFILTRO = "REAL" Then
            btnActualizar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Me.dtgDetallesOC.Columns("IrAlmacen").Visible = False
            Me.dtgDetallesOC.Columns("Pendiente").Visible = False
            Me.dtgDetallesOC.Columns("Cerrado").HeaderText = "Cant. Items"
        End If
        'Valida_Resumen_T002_Aduanas()

        oDtFiltrado = objImpInfo.Valida_Resumen_Filtro(objPortalDetalle)

        If objPortalDetalle.PSFILTRO = "REAL" Then
            oDtValidado = objImpInfo.Valida_Resumen_T002_Almacen(oDtFiltrado, objPortalDetalle)
        Else
            oDtValidado = objImpInfo.Valida_Resumen_T002_Aduanas(oDtFiltrado, objPortalDetalle)
        End If

        odtGlobalOk = objImpInfo.Valida_Resumen_T002_Aduanas_Validados(oDtValidado)

        txtCliente.Text = objPortalDetalle.PSCLIENTE_NOMBRE
        txtCantidad.Text = oDtFiltrado.Rows.Count

        Dim intCont As Integer
        For intCont = 0 To oDtValidado.Rows.Count - 1
            Agrega_Row_OC_Detalle()
            With Me.dtgDetallesOC
                .Rows(intCont).Cells("ver").Value = btnLupa
                .Rows(intCont).Cells("ver").ToolTipText = "Ver Detalles de O/C " & oDtValidado.Rows(intCont).Item("SNROOC") & " Item " & oDtValidado.Rows(intCont).Item("SNROITE")

                .Rows(intCont).Cells("SNROOC").Value = oDtValidado.Rows(intCont).Item("SNROOC")
                .Rows(intCont).Cells("SNROITE").Value = oDtValidado.Rows(intCont).Item("SNROITE")
                If objPortalDetalle.PSFILTRO = "REDE" Then
                    .Rows(intCont).Cells("CANTIDAD").Value = Format(CType(oDtValidado.Rows(intCont).Item("NCNTRECDES"), Double), "###,###,###,##0.00")
                Else
                    .Rows(intCont).Cells("CANTIDAD").Value = Format(CType(oDtValidado.Rows(intCont).Item("NCNTRECALM"), Double), "###,###,###,##0.00")
                End If

                If Not IsDBNull(oDtValidado.Rows(intCont).Item("QRLCSC_A")) Then
                    .Rows(intCont).Cells("Pendiente").Value = Format(CType(oDtValidado.Rows(intCont).Item("QRLCSC_A"), Double), "###,###,###,##0.00")
                Else
                    .Rows(intCont).Cells("Pendiente").Value = "0.00"
                End If
                If Not IsDBNull(oDtValidado.Rows(intCont).Item("QRLCSC_C")) Then
                    .Rows(intCont).Cells("Cerrado").Value = Format(CType(oDtValidado.Rows(intCont).Item("QRLCSC_C"), Double), "###,###,###,##0.00")
                Else
                    .Rows(intCont).Cells("Cerrado").Value = "0.00"
                End If
                .Rows(intCont).Cells("Status").Value = IIf(oDtValidado.Rows(intCont).Item("Status") = 1, btnOk, btnCancel)
                .Rows(intCont).Cells("Status").ToolTipText = IIf(oDtValidado.Rows(intCont).Item("Status") = 1, "Correcto", "Incorrecto")
                '-----------------------------------                
                If objPortalDetalle.PSFILTRO = "REDE" Then
                    If oDtValidado.Rows(intCont).Item("Status") = 1 Then
                        If .Rows(intCont).Cells("Pendiente").Value <> .Rows(intCont).Cells("CANTIDAD").Value Then
                            .Rows(intCont).Cells("IrAlmacen").Value = btnFlecha
                            .Rows(intCont).Cells("IrCliente").Value = btnFlecha
                            .Rows(intCont).Cells("IrAlmacen").ToolTipText = "Enviar a Almacen"
                            .Rows(intCont).Cells("IrCliente").ToolTipText = "Enviar a Cliente"
                        Else
                            .Rows(intCont).Cells("IrAlmacen").Value = btnBlanco
                            .Rows(intCont).Cells("IrCliente").Value = btnBlanco
                        End If
                    ElseIf oDtValidado.Rows(intCont).Item("Status") = 2 Then
                        If .Rows(intCont).Cells("Pendiente").Value <> .Rows(intCont).Cells("CANTIDAD").Value Then
                            .Rows(intCont).Cells("IrAlmacen").Value = btnBlanco
                            .Rows(intCont).Cells("IrCliente").Value = btnFlecha
                            .Rows(intCont).Cells("IrCliente").ToolTipText = "Enviar a Cliente"
                        Else
                            .Rows(intCont).Cells("IrAlmacen").Value = btnBlanco
                            .Rows(intCont).Cells("IrCliente").Value = btnBlanco
                        End If
                    Else
                        .Rows(intCont).Cells("IrAlmacen").Value = btnBlanco
                        .Rows(intCont).Cells("IrCliente").Value = btnBlanco
                    End If
                End If
                If objPortalDetalle.PSFILTRO = "REAL" Then
                    If .Rows(intCont).Cells("Cerrado").Value <> .Rows(intCont).Cells("CANTIDAD").Value Then
                        .Rows(intCont).Cells("IrCliente").Value = btnFlecha
                        .Rows(intCont).Cells("IrCliente").ToolTipText = "Enviar a Cliente"
                    Else
                        .Rows(intCont).Cells("IrCliente").Value = btnBlanco
                    End If
                    .Rows(intCont).Cells("IrAlmacen").Value = btnBlanco
                End If
            End With
        Next intCont
    End Sub

    Private Sub Agrega_Row_OC_Detalle()
        Dim oDrVw As New DataGridViewRow
        oDrVw.CreateCells(Me.dtgDetallesOC)
        Me.dtgDetallesOC.Rows.Add(oDrVw)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim x = MsgBox("Desea Actualizar Los Registros?", MsgBoxStyle.YesNo, "Mensaje de Informacion")
        If x = 6 Then
            Dim mensaje As String = objImpInfo.Actualiza_Aduanas_T002(odtGlobalOk)
            HelpUtil.MsgBox(mensaje)
            btnActualizar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
    End Sub


    Private Sub dtgDetallesOC_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetallesOC.CellClick
        
        If e.RowIndex > -1 Then
            objPortalDetalle.PSORDENCOMPRA = Me.dtgDetallesOC.Rows(e.RowIndex).Cells("SNROOC").Value
            objPortalDetalle.PSITEM = Me.dtgDetallesOC.Rows(e.RowIndex).Cells("SNROITE").Value

            objPortalDetalle.PNCNTDESTINO = Me.dtgDetallesOC.Rows(e.RowIndex).Cells("CANTIDAD").Value
            objPortalDetalle.PNCNTALMACEN = Me.dtgDetallesOC.Rows(e.RowIndex).Cells("Pendiente").Value
            objPortalDetalle.PNCNTCLIENTE = Me.dtgDetallesOC.Rows(e.RowIndex).Cells("Cerrado").Value

            If e.ColumnIndex = 0 Then
                Dim frmDetalleT005 As frmRevisarOCPortalDetalleT005
                Cursor = Cursors.WaitCursor
                frmDetalleT005 = New frmRevisarOCPortalDetalleT005(objPortalDetalle)
                If frmDetalleT005.txtSIDYRC.Text <> "" Then
                    frmDetalleT005.ShowInTaskbar = False
                    frmDetalleT005.StartPosition = FormStartPosition.CenterScreen
                    frmDetalleT005.ShowDialog()
                    Cursor = Cursors.Default
                Else
                    HelpUtil.MsgBox("La O/C no tiene un código de YRC asociado")
                    Cursor = Cursors.Default
                End If
            End If
            If e.ColumnIndex = 7 Then  'Envia al Almacen
                If Me.dtgDetallesOC.CurrentCell.ToolTipText = "Enviar a Almacen" Then
                    Dim x As Integer = MsgBox("Desea Pasar este Ítem al Almacén", MsgBoxStyle.OkCancel, "Mensaje de Información")
                    If x = 1 Then
                        HelpUtil.MsgBox(objImpInfo.Actualiza_Almacen_Unitario(objPortalDetalle))
                    End If
                End If
            End If
            If e.ColumnIndex = 8 Then  'Envia al Cliente
                If Me.dtgDetallesOC.CurrentCell.ToolTipText = "Enviar a Cliente" Then
                    Dim x As Integer = MsgBox("Desea Pasar este Ítem a Cliente", MsgBoxStyle.OkCancel, "Mensaje de Información")
                    If x = 1 Then
                        HelpUtil.MsgBox(objImpInfo.Actualiza_Destino_Cliente_Unitario(objPortalDetalle))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class


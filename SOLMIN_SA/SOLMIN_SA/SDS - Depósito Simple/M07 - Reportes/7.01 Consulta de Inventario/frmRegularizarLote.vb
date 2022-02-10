Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports RANSA.Utilitario
Public Class frmRegularizarLote
    Public obeMercaderia As New beMercaderia()

    Private Sub frmInventarioSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            htPosiciones = New Hashtable
            ListarSolicitudServicioxCliente()
            Buscar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListarSolicitudServicioxCliente()
        Try
            Dim oblInventarioMercaderia As New blInventarioMercaderia()
            dtgMovimientos.AutoGenerateColumns = False
            Me.dtgMovimientos.DataSource = oblInventarioMercaderia.Lista_Solicitud_Servicio_Pendiente_por_Lote(obeMercaderia)
        Catch ex As Exception
        End Try

    End Sub


    Private Sub ListarLote()
        Dim obrLote As New brLote
        Dim objLote As New beLote
        With objLote
            .NORDSR = obeMercaderia.PNNORDSR
        End With
        dgvLotes.AutoGenerateColumns = False
        dgvLotes.DataSource = obrLote.ListarLotesPorOS(objLote)
    End Sub

 
    Private Sub Buscar()
        Try
            ListarLote()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnUbicarIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Grabarlotes()
        UcUbicaciones_Lista.Guardar(dtgMovimientos.CurrentRow.DataBoundItem.PNNGUIRN)
    End Sub


    Private Function fbolValidarProceso() As Boolean

        For Each Item As DataGridViewRow In dgvLotes.Rows
            If Val(Item.Cells("QREGUL").Value) > 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub Grabarlotes()

        Try

            If fbolValidarProceso() Then
                HelpClass.MsgBox("Ingrese Cantidad Regularizar Lote", MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim obeLote As beLote
            Dim olistLote As New List(Of beLote)
            Dim obrLote As New brLote
            For Each Item As DataGridViewRow In dgvLotes.Rows
                If Val(Item.Cells("QREGUL").Value) > 0 Then
                    obeLote = New beLote
                    With obeLote
                        .NORDSR = obeMercaderia.PNNORDSR  'Orden de servicio
                        .NCRRIN = Item.DataBoundItem.row("NCRRIN")  'correlativo ingreso (PK de Lote)
                        .FINGAL = dtgMovimientos.CurrentRow.DataBoundItem.PNFRLZSR 'Fecha de recepción.
                        .CULUSA = objSeguridadBN.pUsuario 'Usuario as400.
                        .QTRMC = Val(Item.Cells("QREGUL").Value) 'cantidad recibir lote.
                        .QTRMP = 0 'peso recibir lote.
                        .QCMMC1 = .QTRMC
                        .QCMMP1 = 0
                        If dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 1 Or dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 910 Then
                            .CTPOAT = "I" 'movimiento de ingreso
                        Else
                            .CTPOAT = "S" 'movimiento de Salida
                        End If
                        .NGUIRN = dtgMovimientos.CurrentRow.DataBoundItem.PNNGUIRN   'guía ransa.
                        .NSLCS1 = dtgMovimientos.CurrentRow.DataBoundItem.PNNSLCSR  'Solicitud de servicio del OS. 
                        .CTPALM = dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM  'Tipo de alm.
                        .CALMC = dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC  'almacen.
                        .CZNALM = "" 'Zona alamcén.
                        If .CTPOAT = "S" Then
                            olistLote.Add(obeLote)
                        End If
                    End With
                    If obeLote.CTPOAT = "I" Then
                        If Not obrLote.RegistrarRecepcionLote(obeLote) Then
                            HelpClass.ErrorMsgBox()
                            Exit Sub
                        End If
                    End If

                End If
            Next
            If Not obrLote.RegistrarDespachoLote(olistLote) Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If

            HelpClass.MsgBox("Se proceso se realizó correctamente", MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            HelpClass.ErrorMsgBox()

        End Try
        
    End Sub


    Private Function ValidarProceso() As Boolean
        'For Each oDrv As DataGridViewRow In Me.dtgMovimientos.Rows
        '    UcLote1.OrdenServicio = Me.dtgListaDespachos.CurrentRow.Cells("PNNORDSR").Value
        '    UcLote1.intIndex = Me.dtgListaDespachos.CurrentRow.Cells("PNCDREGP").Value
        '    Dim x = oDrv.Cells("CANTIDAD").Value
        '    If oDrv.Cells("CANTIDAD").Value > UcLote1.ObtenerTotalCantidades(oDrv.Cells("PNNORDSR").Value, oDrv.Cells("PNCDREGP").Value) And oDrv.Cells("PSFUNCTL").Value = "X" Then
        '        strResultado &= "- Suma de cantidad Atender del lote debe de ser igual a Cantidad Atender Pedido." & vbNewLine
        '        Exit For
        '    End If

        'Next
    End Function


    Private Sub dgvLotes_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotes.CellValueChanged
        If dgvLotes.CurrentRow IsNot Nothing Then
            If dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 1 Or dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 910 Then
                UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Ingreso
                Me.UcUbicaciones_Lista.ConsultarIngresos(obeMercaderia.PNNORDSR, obeMercaderia.PNCCLNT, obeMercaderia.PSCMRCLR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, Me.dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"), dtgMovimientos.CurrentRow.Index, dtgMovimientos.CurrentRow.DataBoundItem.PSCZNALM)
            Else
                'UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Despacho
                'UcUbicaciones_Lista.ResetearCantidades(dtgMovimientos.CurrentRow.DataBoundItem.PNCDPEPL, _
                'obeMercaderia.PNNORDSR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, _
                'dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, _
                'dtgMovimientos.CurrentRow.Index, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"))

                UcUbicaciones_Lista.ConsultarDespachos(dtgMovimientos.CurrentRow.DataBoundItem.PNCDPEPL, _
                obeMercaderia.PNNORDSR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, _
                dtgMovimientos.CurrentRow.DataBoundItem.PSCZNALM, dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, _
                dtgMovimientos.CurrentRow.Index, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"))


                UcUbicaciones_Lista.ResetearDespachosLotes(dtgMovimientos.CurrentRow.DataBoundItem.PNCDPEPL, _
               obeMercaderia.PNNORDSR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, _
               dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, _
               dtgMovimientos.CurrentRow.Index, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"))


            End If

        End If
    End Sub

    Private Sub dgvLotes_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvLotes.EditingControlShowing
        If dgvLotes.CurrentCell.ColumnIndex = 1 Then
            Dim validar As TextBox = CType(e.Control, TextBox)
            If validar IsNot Nothing Then
                ' agregar el controlador de eventos para el KeyPress   
                AddHandler validar.KeyPress, AddressOf validar_Keypress
            Else
                RemoveHandler validar.KeyPress, AddressOf validar_Keypress
            End If
        End If
    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna   
        Dim columna As Integer = dgvLotes.CurrentCell.ColumnIndex

        ' comprobar si la celda en edición corresponde a la columna 1 o 3   
        If columna = 1 Then
            'IsEstado = 1
            ' Obtener caracter   
            Dim caracter As Char = e.KeyChar

            ' comprobar si el caracter es un número o el retroceso   
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False And caracter <> "." And caracter <> "," Then
                'Me.Text = e.KeyChar   
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

 
    Private htPosiciones As Hashtable

    Private Sub dgvLotes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLotes.SelectionChanged
        If dgvLotes.CurrentRow IsNot Nothing And dtgMovimientos.CurrentRow IsNot Nothing Then ' dgvLotes.RowCount > 0 Then

            If dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 1 Or dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 910 Then
                UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Ingreso
                Me.UcUbicaciones_Lista.ConsultarIngresos(obeMercaderia.PNNORDSR, obeMercaderia.PNCCLNT, obeMercaderia.PSCMRCLR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, Me.dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"), dtgMovimientos.CurrentRow.Index, dtgMovimientos.CurrentRow.DataBoundItem.PSCZNALM)
            Else
                UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Despacho
                UcUbicaciones_Lista.ConsultarDespachos(dtgMovimientos.CurrentRow.DataBoundItem.PNCDPEPL, _
                obeMercaderia.PNNORDSR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, _
                dtgMovimientos.CurrentRow.DataBoundItem.PSCZNALM, dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, _
                dtgMovimientos.CurrentRow.Index, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"))
                'UcUbicaciones_Lista.ResetearCantidades(dtgMovimientos.CurrentRow.DataBoundItem.PNCDPEPL, _
                'obeMercaderia.PNNORDSR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, _
                'dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, _
                'dtgMovimientos.CurrentRow.Index, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"))
            End If
        End If
    End Sub

    Private Function SearchSeleccionadosMayorCero(ByVal oBeUbicacionesLotes As BeUbicacionesLotes) As Boolean
        Return oBeUbicacionesLotes.CTPALM = dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM And oBeUbicacionesLotes.CALMC = dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC
    End Function


    Private Sub dgvLotes_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvLotes.CellValidating
        Try
            'If e.FormattedValue.ToString = 0 Then Exit Sub
            If e.ColumnIndex = 0 Then
                Dim ValorCantidad As String = e.FormattedValue.ToString
                Dim fila As Integer = e.RowIndex
                If ValidarCantidadIngresadaporMercaderia(fila, ValorCantidad) = False Then
                    MessageBox.Show("Suma de cantidad regularizar del lote debe de ser igual a Cantidad Pendiente Reg.")
                    e.Cancel = True
                    Me.dgvLotes.CurrentCell.ErrorText = "Suma de cantidad regularizar del lote debe de ser igual a Cantidad Pendiente Reg."
                ElseIf dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 2 Or dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 911 Then
                    If (dgvLotes.CurrentRow.Cells("QMRCSL").Value < ValorCantidad) Then
                        MessageBox.Show("Cantidad regularizar del Lote debe de ser menor o igual que el Stock del Lote")

                        e.Cancel = True
                        Me.dgvLotes.CurrentCell.ErrorText = "Cantidad regularizar del Lote debe de ser menor o igual que el Stock del Lote"""
                    Else
                        Me.dgvLotes.CurrentCell.ErrorText = ""

                    End If
                Else
                    Me.dgvLotes.CurrentCell.ErrorText = ""

                    End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ValidarCantidadIngresadaporMercaderia(ByVal fila As Integer, ByVal Cantidad As String) As Boolean
        Dim CantMercaderia As Decimal = 0
        Dim sumaCantidades As Decimal = 0
        Dim IsError As Boolean
        'Dim NORDSR As String
        If dtgMovimientos.CurrentRow IsNot Nothing Then
            'NORDSR = dgMercaderiaSeleccionada.CurrentRow.Cells("S_NORDSR").Value
            CantMercaderia = Val(dtgMovimientos.CurrentRow.Cells("PNCANTIDAD").Value)
            dgvLotes.Rows(fila).Cells("QREGUL").Value = Convert.ToDecimal(Cantidad)
            If dgvLotes.RowCount > 0 Then
                For Each row As DataGridViewRow In dgvLotes.Rows
                    sumaCantidades = sumaCantidades + Convert.ToDecimal(row.Cells.Item("QREGUL").Value)
                Next
                If sumaCantidades > CantMercaderia Then
                    IsError = False
                    Return False
                Else
                    IsError = True
                    Return True
                End If
            End If
        End If
    End Function

    Private Sub dtgMovimientos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgMovimientos.CurrentCellChanged
        Try
            For Each oDr As System.Windows.Forms.DataGridViewRow In dgvLotes.Rows
                oDr.Cells("QREGUL").Value = 0D
            Next
            UcUbicaciones_Lista.LimpiarIngreso()
            UcUbicaciones_Lista.LimpiarDespacho()
        Catch ex As Exception

        End Try

    End Sub
 
    Private Sub dtgMovimientos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgMovimientos.SelectionChanged
        If dgvLotes.CurrentRow IsNot Nothing And dtgMovimientos.CurrentRow IsNot Nothing Then ' dgvLotes.RowCount > 0 Then

            If dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 1 Or dtgMovimientos.CurrentRow.DataBoundItem.PNCSRVC = 910 Then
                UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Ingreso
                Me.UcUbicaciones_Lista.ConsultarIngresos(obeMercaderia.PNNORDSR, obeMercaderia.PNCCLNT, obeMercaderia.PSCMRCLR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, Me.dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"), dtgMovimientos.CurrentRow.Index, dtgMovimientos.CurrentRow.DataBoundItem.PSCZNALM)
            Else
                UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Despacho
                UcUbicaciones_Lista.ConsultarDespachos(dtgMovimientos.CurrentRow.DataBoundItem.PNCDPEPL, _
                obeMercaderia.PNNORDSR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, _
                dtgMovimientos.CurrentRow.DataBoundItem.PSCZNALM, dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, _
                dtgMovimientos.CurrentRow.Index, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"))
                'UcUbicaciones_Lista.ResetearCantidades(dtgMovimientos.CurrentRow.DataBoundItem.PNCDPEPL, _
                'obeMercaderia.PNNORDSR, dtgMovimientos.CurrentRow.DataBoundItem.PSCTPALM, dtgMovimientos.CurrentRow.DataBoundItem.PSCALMC, _
                'dgvLotes.CurrentRow.Cells("QREGUL").Value, objSeguridadBN.pUsuario, False, _
                'dtgMovimientos.CurrentRow.Index, dgvLotes.CurrentRow.DataBoundItem.Item("NCRRIN"))
            End If
        End If
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class


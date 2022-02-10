Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario

Public Class frmItemsDeGuia

#Region "propiedades"

    Private _CodGuiaRansa As Double

    Public Property CodGuiaRansa() As Double
        Get
            Return _CodGuiaRansa
        End Get
        Set(ByVal value As Double)
            _CodGuiaRansa = value
        End Set
    End Property

    Private _CodCliente As Double

    Public Property CodCliente() As Double
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As Double)
            _CodCliente = value
        End Set
    End Property


    Private _Tipos As String
    Public Property Tipo() As String
        Get
            Return _Tipos
        End Get
        Set(ByVal value As String)
            _Tipos = value
        End Set
    End Property


    Private _TipMovimiento As String
    Public Property TipMovimiento() As String
        Get
            Return _TipMovimiento
        End Get
        Set(ByVal value As String)
            _TipMovimiento = value
        End Set
    End Property

    Private _Anular As Boolean
    Public Property Anular() As Boolean
        Get
            Return _Anular
        End Get
        Set(ByVal value As Boolean)
            _Anular = value
        End Set
    End Property

    Private ohtProyectos As New Hashtable
    Private ohtKardex As New Hashtable
    Private ohtSerie As New Hashtable
    Private ohtUbicacion As New Hashtable
    Private ohtLotes As New Hashtable

    Private intIndiceMovimiento As Integer = -1
    Private bolVal As Boolean
    Private _IsOutotec As Boolean = False

    Public Property IsOutotec() As Boolean
        Get
            Return _IsOutotec
        End Get
        Set(ByVal value As Boolean)
            _IsOutotec = value
        End Set
    End Property

#End Region

    Private Sub bsaEliminarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            AnularItems()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' Validamos que la cantidad del movimeinto sea iguia a la cantidad a anular
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fbolValidar() As Boolean

        'Validar que la cantidad Solicitado esa igual que la cantidad de proyecto
        Dim decSuma As Decimal = 0D
        Dim strErrorProyecto As String = ""

        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            If obeDespacho.Estado Then
                If _Tipos = "I" Then
                    If obeDespacho.PNQSLMC < obeDespacho.PNQTRMC Then
                        strErrorProyecto = strErrorProyecto & " * No hay Saldo Mercadería suficiente  para realizar esta operación en la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                End If
                Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
                If Not ohtKardex(key) Is Nothing AndAlso ohtKardex(key).count > 0 Then
                    For Each obeMercaderia As beMercaderia In ohtKardex(key)
                        If _Tipos = "I" Then
                            If obeMercaderia.PNQSLMC2 < obeMercaderia.PNQTRMC1 Then
                                strErrorProyecto = strErrorProyecto & " *  No hay saldo suficiente en el Kardex para realizar esta operación en la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                                Exit For
                            End If
                        End If
                    Next
                End If
                If Not ohtUbicacion(key) Is Nothing AndAlso ohtUbicacion(key).count > 0 Then
                    For Each obeMercaderia As beMercaderia In ohtUbicacion(key)
                        If obeMercaderia.PNQTRMC1 > obeMercaderia.PNQSLETQ Then
                            If _Tipos = "I" Then
                                strErrorProyecto = strErrorProyecto & " * No hay saldo suficiente en la Ubicación para realizar esta operación en la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                                Exit For
                            End If
                        End If
                    Next
                End If
                decSuma = 0
                If Not ohtProyectos(key) Is Nothing AndAlso ohtProyectos(key).count > 0 Then
                    For Each obeProyecto As beProyecto In ohtProyectos(key)
                        If _Tipos = "I" Then
                            decSuma = obeProyecto.PNQCNTIT2 + decSuma
                        Else
                            decSuma = obeProyecto.PNQCNTIT2 + decSuma
                        End If
                    Next
                    If obeDespacho.PNQTRMC <> decSuma Then
                        strErrorProyecto = strErrorProyecto & " * Cantidad anular proyecto debe de ser igual a la antidad del Movimiento de la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                End If




                If Not ohtLotes(key) Is Nothing AndAlso ohtLotes(key).count > 0 Then
                    For Each obeMercaderia As beMercaderia In ohtlotes(key)
                        If obeMercaderia.PNQTRMC1 > obeMercaderia.PNQMRCSL Then
                            If _Tipos = "I" Then
                                strErrorProyecto = strErrorProyecto & " * No hay saldo suficiente en el lote para realizar esta operación en la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                                Exit For
                            End If
                        End If
                    Next
                End If
 

            End If
        Next
        If (strErrorProyecto <> "") Then
            MessageBox.Show(strErrorProyecto, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


    ''' <summary>
    ''' Validamos que la cantidad del movimeinto sea iguia a la cantidad a anular
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fbolValidarRevertir() As Boolean
        'Validar que la cantidad Solicitado esa igual que la cantidad de proyecto
        Dim decSuma As Decimal = 0D
        Dim strErrorProyecto As String = ""
        Dim strError As String = ""
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            If obeDespacho.Estado Then

                If obeDespacho.PNQREMC = 0 Then
                    strError = strError & " * Cantidad Revertir debe de ser mayor que cero para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                End If

                If _Tipos = "I" Then
                    If obeDespacho.PNQSLMC < (obeDespacho.PNQTRMC - obeDespacho.PNQREMC) Then
                        strError = strError & " * No hay Saldo Mercadería suficiente  para realizar esta operación en la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If

                End If

                Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
                decSuma = 0
                If Not ohtKardex(key) Is Nothing AndAlso ohtKardex(key).count > 0 Then
                    For Each obeMercaderia As beMercaderia In ohtKardex(key)
                        If _Tipos = "I" Then
                            'obeMercaderia.PNQSLMC2 < obeMercaderia.PNQREVTR 
                            If obeMercaderia.PNQSLMC2 < (obeMercaderia.PNQTRMC1 - obeMercaderia.PNQREVTR) Then
                                strError = strError & " * No hay saldo suficiente Kardex para realizar esta operación en el almacén " & obeMercaderia.PSDESALM & " para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                                Exit For
                            End If
                        End If
                        decSuma = obeMercaderia.PNQREVTR + decSuma
                    Next
                    If obeDespacho.PNQREMC <> decSuma Then
                        strError = strError & " * Cantidad Revertir debe de ser igual a la cantidad Revertir del Kardex para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                End If

                decSuma = 0
                If Not ohtSerie(key) Is Nothing AndAlso ohtSerie(key).count > 0 Then
                    For Each obeMercaderia As beMercaderia In ohtSerie(key)
                        If obeMercaderia.CHK Then
                            decSuma += 1
                        End If
                    Next
                    If obeDespacho.PNQREMC < decSuma Then
                        strError = strError & " * Cantidad Revertir es menor que la cantidad de Series para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                End If
                decSuma = 0
                If Not ohtUbicacion(key) Is Nothing AndAlso ohtUbicacion(key).count > 0 Then
                    For Each obeMercaderia As beMercaderia In ohtUbicacion(key)
                        decSuma = obeMercaderia.PNQREVTR + decSuma
                        If _Tipos = "I" Then
                            If obeMercaderia.PNQSLETQ < (obeMercaderia.PNQTRMC1 - obeMercaderia.PNQREVTR) Then
                                strErrorProyecto = strErrorProyecto & " * No hay saldo suficiente en la Ubicación para realizar esta operación para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                                Exit For
                            End If
                          
                        End If
                    Next
                    If obeDespacho.PNQREMC < decSuma Then
                        strError = strError & " * Cantidad Revertir es menor que la cantidad revertir ubicación para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                End If

                decSuma = 0
                If Not ohtProyectos(key) Is Nothing AndAlso ohtProyectos(key).count > 0 Then
                    For Each obeProyecto As beProyecto In ohtProyectos(key)
                        If _Tipos = "I" Then
                            decSuma = obeProyecto.PNQCNTIT2 + decSuma
                        Else
                            decSuma = obeProyecto.PNQCNTIT2 + decSuma
                        End If
                    Next
                    If obeDespacho.PNQREMC <> decSuma Then
                        strError = strError & " * Cantidad Revertir debe de ser igual a la Cantidad Anular del Proyecto para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                End If

                decSuma = 0
                If Not ohtLotes(key) Is Nothing AndAlso ohtLotes(key).count > 0 Then


                    For Each obeMercaderia As beMercaderia In ohtLotes(key)
                        decSuma = obeMercaderia.PNQREVTR + decSuma
                        If _Tipos = "I" Then
                            If obeMercaderia.PNQMRCSL < (obeMercaderia.PNQTRMC1 - obeMercaderia.PNQREVTR) Then
                                strErrorProyecto = strErrorProyecto & " * No hay saldo suficiente en el lote para realizar esta operación para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                                Exit For
                            End If
                        End If
                    Next
                    If obeDespacho.PNQREMC <> decSuma Then
                        strError = strError & " * Cantidad Revertir OS debe de ser igual que la cantidad revertir lote para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                    If obeDespacho.PNQREMC < decSuma Then
                        strError = strError & " * Cantidad Revertir es menor que la cantidad revertir lote para la OS : " & obeDespacho.PNNORDSR.ToString & Chr(10)
                    End If
                End If

            End If
        Next
        If (strError <> "") Then
            MessageBox.Show(strError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub AnularItems()
        Me.dtgMovimientos.EndEdit()
        dgProyecto.EndEdit()

        If Not fbolValidar() Then Exit Sub
        Dim intResultado As Integer = 2
        Dim obrDespacho As New brDespacho
        Dim obrProyecto As New brProyecto
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            If obeDespacho.Estado Then
                With obeDespacho
                    .PNCCLNT = _CodCliente
                    .PNNGUIRN = _CodGuiaRansa
                    .PSNTRMNL = objSeguridadBN.pstrPCName
                    .PSUSUARIO = objSeguridadBN.pUsuario
                End With
                If _Tipos = "I" Then
                    intResultado = obrDespacho.AnularMovimientoGuiaIngreso(obeDespacho)
                    If intResultado = 1 Then
                        Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
                        For Each obeProyecto As beProyecto In ohtProyectos(key)
                            obeProyecto.PSSTPING = TipMovimiento
                            obeProyecto.PSNORCML = obeDespacho.PSNORCML.Trim
                            obeProyecto.PNNRITOC = obeDespacho.PNNRITOC
                            intResultado = obrProyecto.fintAnularIngresoProyecto(obeProyecto)
                            'If intResultado = -1 Then
                            '    Ransa.Utilitario.HelpClass.ErrorMsgBox()
                            '    Exit Sub
                            'End If
                        Next
                    End If
                Else
                    intResultado = obrDespacho.AnularMovimientoGuiaSalida(obeDespacho)
                    If intResultado = 1 Then
                        Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
                        For Each obeProyecto As beProyecto In ohtProyectos(key)
                            obeProyecto.PSNORCML = obeDespacho.PSNORCML.Trim
                            obeProyecto.PNNRITOC = obeDespacho.PNNRITOC
                            obrProyecto.fintAnularSalidaProyecto(obeProyecto)
                            'If intResultado = -1 Then
                            '    Ransa.Utilitario.HelpClass.ErrorMsgBox()
                            '    Exit Sub
                            'End If
                        Next
                    End If
                End If
                'If intResultado = -1 Then

                '    Ransa.Utilitario.HelpClass.ErrorMsgBox()
                '    ohtProyectos = New Hashtable
                '    frmItemsDeGuia_Load(Nothing, Nothing)
                '    Exit Sub
                'Else
                'End If
                If intResultado = 0 Then
                    Ransa.Utilitario.HelpClass.MsgBox("No se puede eliminar la Mercadería " & obeDespacho.PSCMRCLR & " , porque el stock queda con negativo", MessageBoxIcon.Warning)
                End If
            End If
        Next
        If intResultado = 1 Then
            MessageBox.Show("Se anuló correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        ohtProyectos = New Hashtable
        ohtKardex = New Hashtable
        ohtSerie = New Hashtable
        ohtUbicacion = New Hashtable
        ohtLotes = New Hashtable

        frmItemsDeGuia_Load(Nothing, Nothing)
    End Sub

    Private Sub frmItemsDeGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim obrDespacho As New brDespacho
            Dim obeDespacho As New beDespacho
            With obeDespacho
                .PNCCLNT = _CodCliente
                .PNNGUIRN = _CodGuiaRansa
            End With
            bolVal = True
            Me.dtgMovimientos.AutoGenerateColumns = False
            ohtProyectos = New Hashtable
            ohtKardex = New Hashtable
            ohtSerie = New Hashtable
            ohtUbicacion = New Hashtable
            ohtLotes = New Hashtable
            Me.dtgMovimientos.DataSource = obrDespacho.ListaMovimientosPorGuiaRansa(obeDespacho)
            fAsocialDetallePedidoConProyecto()
            fAsocialKardex()
            fAsocialSeries()
            fAsociarLotes()
            fAsocialUbicacion()
            bolVal = False
            dtgMovimientos_SelectionChanged(Nothing, Nothing)

            If _Tipos = "I" Then
                dgProyecto.Columns("QCNDPC").Visible = False

            Else
                dgProyecto.Columns("QCNRCP").Visible = False

            End If

            If _Anular Then
                tss02.Visible = False
                btnRevertir.Visible = False
                Me.dtgMovimientos.Columns("PNQREMC").Visible = False
                dtgKardex.Columns("QREVTR").Visible = False
                dtgKardex.Columns("PREVTR").Visible = False
                dtgSeries.Columns("CHK_Serie").Visible = False
                dtgUbicacion.Columns("PNQREVTR").Visible = False
                dtgLote.Columns("L_QREVTR").Visible = False
            Else
                tss01.Visible = False
                btnAnularItems.Visible = False
            End If

            If IsOutotec Then
                btnMarcarItems.Visible = False
                Me.dtgMovimientos.Columns("CHK").Visible = False
                MarcarTodos(True)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub



    
    Private Sub fAsocialDetallePedidoConProyecto()
        Dim obrMercaderia As New brMercaderia
        Dim objBRProyecto As New brProyecto
        Dim obeProyecto As New beProyecto
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            obeProyecto = New beProyecto
            Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)

            With obeProyecto
                .PSNORCML = obeDespacho.PSNORCML
                .PNNRITOC = obeDespacho.PNNRITOC
                .PNCCLNT = obeDespacho.PNCCLNT
                .PNNORDSR = obeDespacho.PNNORDSR
                .PNNSLCSR = obeDespacho.PNNSLCSR
            End With
            Dim olbeProyecto As New List(Of beProyecto)
            olbeProyecto = objBRProyecto.ListaProyectosPorMovimiento(obeProyecto)

            Dim decSuma As Decimal = 0D
            For Each obeProyect As beProyecto In olbeProyecto
                If _Tipos = "I" Then
                    decSuma = decSuma + obeProyect.PNQCNRCP
                Else
                    decSuma = decSuma + obeProyect.PNQCNDPC
                End If

            Next
            If decSuma = obeDespacho.PNQTRMC Then
                For Each obePryct As beProyecto In olbeProyecto
                    If _Tipos = "I" Then
                        obePryct.PNQCNTIT2 = obePryct.PNQCNRCP
                    Else
                        obePryct.PNQCNTIT2 = obePryct.PNQCNDPC
                    End If

                Next
            End If
            ohtProyectos.Add(key, olbeProyecto)
        Next
    End Sub

    Private pdecCantiadRevertir As Decimal = 0

    Private Sub dtgMovimientos_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtgMovimientos.CellBeginEdit
        Try
            If dtgMovimientos.Columns(e.ColumnIndex).Name = "PNQREMC" Then
                pdecCantiadRevertir = dtgMovimientos.CurrentRow.Cells("PNQREMC").Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub dtgMovimientos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgMovimientos.CellEndEdit
        Try
            If dtgMovimientos.Columns(e.ColumnIndex).Name = "PNQREMC" Then
                If pdecCantiadRevertir <> dtgMovimientos.CurrentRow.Cells("PNQREMC").Value Then
                    'Kardex
                    For Each obeKardex As beMercaderia In Me.dtgKardex.DataSource
                        obeKardex.PNQREVTR = 0D
                    Next
                    'Proyecto
                    For Each obeProyecto As beProyecto In dgProyecto.DataSource
                        obeProyecto.PNQCNTIT2 = 0D
                    Next
                    'Series
                    For Each obeSerie As beMercaderia In dtgSeries.DataSource
                        obeSerie.CHK = False
                    Next
                    'Ubicacion
                    For Each obeUbicacion As beMercaderia In dtgUbicacion.DataSource
                        obeUbicacion.PNQREVTR = 0D
                    Next
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub dtgMovimientos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgMovimientos.DataError

    End Sub



    Private Sub dtgMovimientos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgMovimientos.SelectionChanged
        Try
            If dtgMovimientos.CurrentCellAddress.Y = -1 Then
                dgProyecto.DataSource = Nothing
                Exit Sub
            End If
            If dtgMovimientos.CurrentCellAddress.Y = intIndiceMovimiento Or bolVal Then Exit Sub
            Dim key As New KeyValuePair(Of Int64, Int64)(Me.dtgMovimientos.CurrentRow.DataBoundItem.PNNORDSR, Me.dtgMovimientos.CurrentRow.DataBoundItem.PNNSLCSR)

            bolVal = True

            Me.dgProyecto.AutoGenerateColumns = False
            Me.dgProyecto.DataSource = ohtProyectos(key)
            'ListarKardex
            Me.dtgKardex.AutoGenerateColumns = False
            Me.dtgKardex.DataSource = ohtKardex(key)


            'ListarKardex
            Me.dtgSeries.AutoGenerateColumns = False
            Me.dtgSeries.DataSource = ohtSerie(key)

            'ListarKardex
            Me.dtgUbicacion.AutoGenerateColumns = False
            Me.dtgUbicacion.DataSource = ohtUbicacion(key)

            'lista de lotes
            Me.dtgLote.AutoGenerateColumns = False
            dtgLote.DataSource = ohtLotes(key)

            bolVal = False
            CheckMovimientos()

            intIndiceMovimiento = dtgMovimientos.CurrentCellAddress.Y

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub dgProyecto_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgProyecto.CellValidating
        Try
            If e.RowIndex = -1 Then Exit Sub
            If bolVal Then Exit Sub
            If e.ColumnIndex = 5 Then
                If IsNumeric(e.FormattedValue) Then
                    Dim intCantidad As Decimal = 0D
                    If e.FormattedValue = 0 Then Exit Sub
                    If e.FormattedValue < 0 Then
                        e.Cancel = True
                    End If
                    For Each obeProyecto As beProyecto In dgProyecto.DataSource
                        intCantidad = intCantidad + obeProyecto.PNQCNTIT2
                    Next
                    intCantidad = intCantidad - dgProyecto.CurrentRow.DataBoundItem.PNQCNTIT2 + e.FormattedValue
                    If _Tipos = "I" Then
                        'obeProyecto.PNQTRMC - obeProyecto.PNQCNTIT2
                        If Me.dgProyecto.CurrentRow.DataBoundItem.PNQSTKIT < (Me.dgProyecto.CurrentRow.DataBoundItem.PNQTRMC - e.FormattedValue) Then
                            MessageBox.Show("Digite cantidad valida, Cantida Revertir Proyecto no puede ser mayor que el Stock Almacén", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                            Exit Sub
                        End If
                        If e.FormattedValue > Me.dgProyecto.CurrentRow.DataBoundItem.PNQCNRCP Then
                            MessageBox.Show("Digite cantidad valida, Cantidad Revertir Proyecto no puede ser mayor que la Cantidad Recibida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                            Exit Sub
                        End If

                        If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                            MessageBox.Show("Digite cantidad valida, Cantida Revertir Proyecto no puede ser mayor que la cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                            Exit Sub
                        End If
                    Else
                        If e.FormattedValue > Me.dgProyecto.CurrentRow.DataBoundItem.PNQCNDPC Then
                            MessageBox.Show("Digite cantidad valida, Cantidad Revertir Proyecto no puede ser mayor que la Cantidad Despachar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If

                Else
                    MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnAnularItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularItems.Click
        AnularItems()
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        MarcarTodos(btnMarcarItems.Checked)
        CheckMovimientos()
    End Sub

    Private Sub MarcarTodos(ByVal bolCheck As Boolean)
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            obeDespacho.Estado = bolCheck
        Next
        dtgMovimientos.EndEdit()
        dtgMovimientos.Refresh()
    End Sub
    Private Sub tsbRevertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevertir.Click
        Try
            RevertirItems()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub RevertirItems()
        Me.dtgMovimientos.EndEdit()
        dgProyecto.EndEdit()
        If Not fbolValidarRevertir() Then Exit Sub
        Dim intResultado As Integer = 2
        Dim obrDespacho As New brDespacho
        Dim strError As String = String.Empty
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            If obeDespacho.Estado Then
                With obeDespacho
                    .PNCCLNT = _CodCliente
                    .PNNGUIRN = _CodGuiaRansa
                    .PSNTRMNL = objSeguridadBN.pstrPCName
                    .PSUSUARIO = objSeguridadBN.pUsuario
                    .PSSTPING = _TipMovimiento
                End With

                Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
                If _Tipos = "I" Then
                    intResultado = obrDespacho.intRevertirMovimientoGuiaIngreso(obeDespacho, ohtKardex(key), ohtUbicacion(key), ohtSerie(key), ohtProyectos(key), ohtLotes(key), strError)
                   
                Else
                    intResultado = obrDespacho.intRevertirMovimientoGuiaSalida(obeDespacho, ohtKardex(key), ohtUbicacion(key), ohtSerie(key), ohtProyectos(key), ohtLotes(key), strError)
                    
                End If
                If intResultado = -1 Then
                    MessageBox.Show(strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    frmItemsDeGuia_Load(Nothing, Nothing)
                    Exit Sub
                Else
                End If
                'If intResultado = 0 Then
                '    Ransa.Utilitario.HelpClass.MsgBox("No se puede eliminar la Mercadería " & obeDespacho.PSCMRCLR & " , porque el stock queda con negativo", MessageBoxIcon.Warning)
                'End If
            End If
        Next
        If intResultado = 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        ohtProyectos = New Hashtable
        ohtKardex = New Hashtable
        ohtSerie = New Hashtable
        ohtUbicacion = New Hashtable
        frmItemsDeGuia_Load(Nothing, Nothing)
    End Sub

   
    Private Sub dtgMovimientos_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgMovimientos.CellValidating
        Try
            If Me.dtgMovimientos.Columns(e.ColumnIndex).Name = "PNQREMC" Then
                If Me.dtgMovimientos.CurrentRow.DataBoundItem.Estado Then
                    If Not IsNumeric(e.FormattedValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    If e.FormattedValue = 0 Then Exit Sub
                    If e.FormattedValue < 0 Then
                        e.Cancel = True
                    End If
                    If _Tipos = "I" Then
                        If Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQSLMC < (Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQTRMC - e.FormattedValue) Then
                            e.Cancel = True
                            HelpClass.MsgBox("* La cantidad digitada debe de ser mayor" & Chr(10), MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                    If Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQTRMC <= Val(e.FormattedValue) Then
                        e.Cancel = True
                        HelpClass.MsgBox("* La cantidad digitada debe de ser menor que " & Chr(10) & " la cantidad de la transacción ", MessageBoxIcon.Warning)
                    End If
                    'If e.FormattedValue = 0 Then
                    '    HelpClass.MsgBox("* La cantidad digitada debe de ser mayor a Cero", MessageBoxIcon.Warning)
                    'End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub


    Private Sub fAsocialKardex()
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        Dim decSumaQ As Decimal = 0D
        Dim decSumaP As Decimal = 0D
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
            With obeMercaderia
                .PNNORDSR = obeDespacho.PNNORDSR
                .PNNSLCSR = obeDespacho.PNNSLCSR
            End With
            Dim olbeMercaderia As New List(Of beMercaderia)
            olbeMercaderia = obrMercaderia.ListaKardexPorSolicitudServicio(obeMercaderia)
            'decSumaQ = 0
            'decSumaP = 0
            'For Each obeMerc As beMercaderia In olbeMercaderia
            '    decSumaQ = obeMerc.PNQTRMC1 + decSumaQ
            '    decSumaP = obeMerc.PNQTRMP1 + decSumaP
            'Next
            'If decSumaQ = obeDespacho.PNQTRMC Then
            '    For Each obeMerc As beMercaderia In olbeMercaderia
            '        obeDespacho.PNQREVTR = obeMerc.PNQTRMC1
            '    Next
            'End If
            'If decSumaP = obeDespacho.PNQTRMP Then
            '    For Each obeMerc As beMercaderia In olbeMercaderia
            '        obeDespacho.PNPREVTR = obeMerc.PNQTRMC1
            '    Next
            'End If

            ohtKardex.Add(key, olbeMercaderia)
        Next
    End Sub

    Private Sub fAsocialSeries()
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
            With obeMercaderia
                .PNNORDSR = obeDespacho.PNNORDSR
                .PNNSLCSR = obeDespacho.PNNSLCSR
                .PSTIPO = _Tipos
            End With
            Dim olbeSeries As New List(Of beMercaderia)
            olbeSeries = obrMercaderia.ListaSeriePorSolicitudServicio(obeMercaderia)
            ohtSerie.Add(key, olbeSeries)
        Next
    End Sub

    Private Sub fAsociarLotes()
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
            With obeMercaderia
                .PNNORDSR = obeDespacho.PNNORDSR
                .PNNSLCSR = obeDespacho.PNNSLCSR
                .PSTIPO = _Tipos
            End With
            Dim olbelote As New List(Of beMercaderia)
            olbelote = obrMercaderia.ListaLotesPorSolicitudServicio(obeMercaderia)
            ohtLotes.Add(key, olbelote)
        Next
    End Sub

    Private Sub fAsocialUbicacion()
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        For Each obeDespacho As beDespacho In Me.dtgMovimientos.DataSource
            Dim key As New KeyValuePair(Of Int64, Int64)(obeDespacho.PNNORDSR, obeDespacho.PNNSLCSR)
            With obeMercaderia
                .PNNORDSR = obeDespacho.PNNORDSR
                .PNNSLCSR = obeDespacho.PNNSLCSR
            End With
            Dim olbeUbicacion As New List(Of beMercaderia)
            olbeUbicacion = obrMercaderia.ListaUbicacionPorSolicitudServicio(obeMercaderia)
            ohtUbicacion.Add(key, olbeUbicacion)
        Next
    End Sub

    Private Sub dtgKardex_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgKardex.CellValidating
        Try
            If e.RowIndex = -1 Then Exit Sub
            If bolVal Then Exit Sub
            If e.ColumnIndex = 8 And Not _Anular Then
                If Me.dtgMovimientos.CurrentRow.DataBoundItem.Estado Then
                    Dim intCantidad As Decimal = 0D
                    If IsNumeric(e.FormattedValue) Then
                        If e.FormattedValue = 0 Then Exit Sub
                        If e.FormattedValue < 0 Then
                            e.Cancel = True
                        End If

                        For Each obeKar As beMercaderia In dtgKardex.DataSource
                            intCantidad = intCantidad + obeKar.PNQREVTR
                        Next
                        intCantidad = intCantidad - Me.dtgKardex.CurrentRow.DataBoundItem.PNQREVTR + e.FormattedValue
                        If _Tipos = "I" Then
                            If Me.dtgKardex.CurrentRow.DataBoundItem.PNQSLMC2 < (dtgKardex.CurrentRow.DataBoundItem.PNQTRMC1 - e.FormattedValue) Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Kardex no puede ser mayor que el Saldo Kardex", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                            If e.FormattedValue >= Me.dtgKardex.CurrentRow.DataBoundItem.PNQTRMC1 Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Kardex no puede ser mayor que la Cantidad Transacción Kardex", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If

                            If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Kardex no puede ser mayor que la Cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If

                            If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Kardex no puede ser mayor que la Cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If

                        Else
                            If e.FormattedValue >= Me.dtgKardex.CurrentRow.DataBoundItem.PNQTRMC1 Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Kardex no puede ser mayor que la Cantidad Transacción Kardex", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                            If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Kardex no puede ser mayor que la Cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If
                    Else
                        MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub dtgUbicacion_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgUbicacion.CellValidating
        Try
            If e.RowIndex = -1 Then Exit Sub
            If bolVal Then Exit Sub
            If e.ColumnIndex = 5 And Not _Anular Then
                If IsNumeric(e.FormattedValue) Then
                    If Me.dtgMovimientos.CurrentRow.DataBoundItem.Estado Then
                        Dim intCantidad As Decimal = 0D
                        If e.FormattedValue = 0 Then Exit Sub
                        If e.FormattedValue < 0 Then
                            e.Cancel = True
                        End If
                        For Each obeMercaderia As beMercaderia In dtgUbicacion.DataSource
                            intCantidad = intCantidad + obeMercaderia.PNQREVTR
                        Next

                        intCantidad = intCantidad - dtgUbicacion.CurrentRow.DataBoundItem.PNQREVTR + e.FormattedValue
                        If _Tipos = "I" Then
                            If Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQSLETQ < (Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQTRMC1 - e.FormattedValue) Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Ubicación no debe de ser mayor que el Saldo Ubicación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                            If e.FormattedValue > Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQTRMC1 Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Ubicación no debe de ser mayor que la cantidad Transacción Ubicación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                            If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Ubicación no puede ser mayor que la Cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                        Else
                            If e.FormattedValue > Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQTRMC1 Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Ubicación no debe de ser mayor que la cantidad Transacción Ubicación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If

                            If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Ubicación no puede ser mayor que la Cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True

                                Exit Sub
                            End If
                        End If
                    End If

                Else
                    MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
    End Sub

    Private Sub dtgSeries_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtgSeries.CellBeginEdit

    End Sub

    Private Sub dtgSeries_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSeries.CellContentClick
        Try
            dtgSeries.EndEdit()
            If e.RowIndex = -1 Then Exit Sub
            If bolVal Then Exit Sub
            If e.ColumnIndex = 0 Then
                If Me.dtgMovimientos.CurrentRow.DataBoundItem.Estado Then
                    Dim QSeries As Integer = 0
                    For Each obeMerc As beMercaderia In dtgSeries.DataSource
                        If obeMerc.CHK = True Then
                            QSeries += 1
                        End If
                    Next

                    If Not _Anular And QSeries <> 0 Then
                        If Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC < QSeries Then
                            MessageBox.Show("No puede seleccionar más Series", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            dtgSeries.CurrentCell.Value = False
                            dtgSeries.EndEdit()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub


    Private Sub dtgMovimientos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgMovimientos.CellContentClick
        Try
            If e.ColumnIndex = 0 Then
                CheckMovimientos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub CheckMovimientos()
        dtgMovimientos.EndEdit()
        If dtgMovimientos.CurrentRow.Cells("CHK").Value Then
            dtgMovimientos.CurrentRow.Cells("PNQREMC").ReadOnly = False
            dtgKardex.Columns("QREVTR").ReadOnly = False
            dtgKardex.Columns("PREVTR").ReadOnly = False
            dtgSeries.Columns("CHK_Serie").ReadOnly = False
            dtgUbicacion.Columns("PNQREVTR").ReadOnly = False
            'dtgMovimientos.CurrentRow.Cells("PNQREMC").Selected = True
        Else
            dtgMovimientos.CurrentRow.Cells("PNQREMC").ReadOnly = True
            dtgKardex.Columns("QREVTR").ReadOnly = True
            dtgKardex.Columns("PREVTR").ReadOnly = True
            dtgSeries.Columns("CHK_Serie").ReadOnly = True
            dtgUbicacion.Columns("PNQREVTR").ReadOnly = True

            'Limpiamos la información
            dtgMovimientos.CurrentRow.Cells("PNQREMC").Value = 0D
            For intX As Integer = 0 To dtgKardex.RowCount - 1
                dtgKardex.Rows(intX).Cells("QREVTR").Value = 0D
            Next
            For intX As Integer = 0 To dtgSeries.RowCount - 1
                dtgSeries.Rows(intX).Cells("CHK_Serie").Value = False
            Next
            dtgSeries.EndEdit()
            For intX As Integer = 0 To dtgUbicacion.RowCount - 1
                dtgUbicacion.Rows(intX).Cells("PNQREVTR").Value = 0D
            Next
        End If
    End Sub


    Private Sub dgProyecto_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgProyecto.DataError

    End Sub

    Private Sub dtgLote_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgLote.CellValidating
        Try
            If e.RowIndex = -1 Then Exit Sub
            If bolVal Then Exit Sub
            If e.ColumnIndex = 3 And Not _Anular Then
                If IsNumeric(e.FormattedValue) Then
                    If Me.dtgMovimientos.CurrentRow.DataBoundItem.Estado Then
                        Dim intCantidad As Decimal = 0D
                        If e.FormattedValue = 0 Then Exit Sub
                        If e.FormattedValue < 0 Then
                            e.Cancel = True
                        End If
                        For Each obeMercaderia As beMercaderia In dtgLote.DataSource
                            intCantidad = intCantidad + obeMercaderia.PNQREVTR
                        Next

                        intCantidad = intCantidad - dtgUbicacion.CurrentRow.DataBoundItem.PNQREVTR + e.FormattedValue
                        If _Tipos = "I" Then
                            If Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQMRCSL < (Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQTRMC1 - e.FormattedValue) Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Lote no debe de ser mayor que el Saldo Lote", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                            If e.FormattedValue > Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQTRMC1 Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Lote no debe de ser mayor que la cantidad Transacción Lote", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                            If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Lote no puede ser mayor que la Cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If
                        Else
                            If e.FormattedValue > Me.dtgUbicacion.CurrentRow.DataBoundItem.PNQTRMC1 Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Lote no debe de ser mayor que la cantidad Transacción Lote", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                                Exit Sub
                            End If

                            If intCantidad > Me.dtgMovimientos.CurrentRow.DataBoundItem.PNQREMC Then
                                MessageBox.Show("Digite cantidad valida, Cantidad Revertir Lote no puede ser mayor que la Cantidad Revertir OS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True

                                Exit Sub
                            End If
                        End If
                    End If

                Else
                    MessageBox.Show("Digite cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub
End Class

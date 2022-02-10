Imports RANSA.NEGO
Imports RANSA.TypeDef

Public Class frmPedidoTrasladoBulto
    Dim totalCheckBoxes As Integer = 0
    Dim headerCheckBox As CheckBox = Nothing
    Dim isHeaderCheckBoxClicked As Boolean = False
    Dim esValido As Boolean = True
    Dim pedidoTraslado As New brPreDespacho
    Dim todoDetallePedido As New DataTable
    Dim itemsBulto As New DataTable
    Dim itemActual As Integer = -1
    Dim retornarValor As Boolean = False
    Public detalleBultoXPedido As New DataTable
    Public materialXPedido As New DataTable
    Dim mensajeValidacion As String = ""

    Private _parametro As bePedidoTrasladoxBulto
    ''' <summary>
    ''' Parametro pedido traslado por bulto
    ''' </summary>
    Public Property parametro() As bePedidoTrasladoxBulto
        Get
            Return _parametro
        End Get
        Set(ByVal value As bePedidoTrasladoxBulto)
            _parametro = value
        End Set
    End Property

    Private _pedidoTraslado As bePedidoTraslado
    ''' <summary>
    ''' Parametro pedido traslado por bulto
    ''' </summary>
    Public Property inputPedido() As bePedidoTraslado
        Get
            Return _pedidoTraslado
        End Get
        Set(ByVal value As bePedidoTraslado)
            _pedidoTraslado = value
        End Set
    End Property

    Private Sub frmPedidoTrasladoBulto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        headerCheckBox = New CheckBox()
        headerCheckBox.Size = New Size(15, 15)
        Me.dgDetallePedido.Controls.Add(headerCheckBox)

        AddHandler headerCheckBox.KeyUp, AddressOf HeaderCheckBox_KeyUp
        AddHandler headerCheckBox.MouseClick, AddressOf HeaderCheckBox_MouseClick

        ' AddHandler dgDetallePedido.CellValueChanged, AddressOf dgDetallePedido_CellValueChanged
        AddHandler dgDetallePedido.CurrentCellDirtyStateChanged, AddressOf dgDetallePedido_CurrentCellDirtyStateChanged
        AddHandler dgDetallePedido.CellPainting, AddressOf dgDetallePedido_CellPainting

        dgItemsBulto.AutoGenerateColumns = False
        dgCabPedido.AutoGenerateColumns = False
        dgDetallePedido.AutoGenerateColumns = False

        pedidoTraslado.parametroPedido = parametro

        itemsBulto = pedidoTraslado.ListaDetalleBulto
        dgItemsBulto.DataSource = itemsBulto
        dgCabPedido.DataSource = pedidoTraslado.ListaCabeceraPedido


        For Each row As DataGridViewRow In dgCabPedido.Rows
            parametro.psnrpdts = CStr(row.Cells("NRPDTS").Value)
            todoDetallePedido.Merge(pedidoTraslado.ListaTodoDetallePedido, True, MissingSchemaAction.Add)
        Next row

        For Each rowPedido As DataRow In materialXPedido.Rows
            For Each rowDetallePedido As DataRow In todoDetallePedido.Rows
                If rowPedido("IN_ID") = rowDetallePedido("ID") Then
                    rowDetallePedido("CantStock") = CDbl(rowDetallePedido("CantStock")) - CDbl(rowPedido("IN_QBLTSR")) 'logica de negocio
                    rowDetallePedido("QTYPEN") = rowDetallePedido("CantStock") 'presentación
                End If
            Next
        Next

        ListaDetallePedido()

        detalleBultoXPedido = New DataTable
        detalleBultoXPedido.Columns.Add("IN_CCMPN")
        detalleBultoXPedido.Columns.Add("IN_CDVSN")
        detalleBultoXPedido.Columns.Add("IN_CPLNDV")
        detalleBultoXPedido.Columns.Add("IN_CCLNT")
        detalleBultoXPedido.Columns.Add("IN_CREFFW")
        detalleBultoXPedido.Columns.Add("IN_CIDPAQ")
        detalleBultoXPedido.Columns.Add("IN_NSEQIN")
        detalleBultoXPedido.Columns.Add("IN_NORCML")
        detalleBultoXPedido.Columns.Add("IN_NRITOC")
        detalleBultoXPedido.Columns.Add("IN_NRPDTS")
        detalleBultoXPedido.Columns.Add("IN_NROSEC")
        detalleBultoXPedido.Columns.Add("IN_QBLTSR")
        detalleBultoXPedido.Columns.Add("IN_CLARSG")
        detalleBultoXPedido.Columns.Add("IN_NROONU")
        detalleBultoXPedido.Columns.Add("IN_TPOEMB")
        detalleBultoXPedido.Columns.Add("IN_USUARI")
        detalleBultoXPedido.Columns.Add("IN_TCITCL")
        detalleBultoXPedido.Columns.Add("IN_ID")

    End Sub

    Private Sub dgDetallePedido_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetallePedido.CellEndEdit
        Dim nroPedido As String = dgDetallePedido.CurrentRow.Cells("ID").Value

        For Each filaPedido As DataGridViewRow In dgDetallePedido.Rows
            Dim identificador As String = filaPedido.Cells("ID").Value

            For Each detallePedido As DataRow In detalleBultoXPedido.Rows
                If detallePedido.Item("IN_ID") = identificador Then
                    detallePedido.Item("IN_CLARSG") = filaPedido.Cells("CLARSG").Value.ToString() 'Clase de Riesgo
                    detallePedido.Item("IN_NROONU") = filaPedido.Cells("NROONU").Value.ToString() 'Número de ONU
                    detallePedido.Item("IN_TPOEMB") = filaPedido.Cells("TPOEMB").Value.ToString() 'Tipo de Embalaje
                End If
            Next
        Next
    End Sub


    '**Una selección**'
    Private Sub dgDetallePedido_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetallePedido.CellValueChanged
        mensajeValidacion = String.Empty
        If Not isHeaderCheckBoxClicked And e.RowIndex >= 0 And e.ColumnIndex = 0 Then
            Dim RCheckBox As DataGridViewCheckBoxCell = DirectCast(dgDetallePedido(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell)
            itemActual = e.RowIndex
            If RCheckBox IsNot Nothing Then
                If CBool(RCheckBox.Value) Then
                    PreDespachar(itemActual)
                Else
                    QuitarPreDespacho(itemActual)
                End If
            End If
            If Len(mensajeValidacion) > 0 Then
                MsgBox(mensajeValidacion, MsgBoxStyle.Exclamation, "Advertencia")
            End If

            dgItemsBulto.DataSource = itemsBulto
            ListaDetallePedido()
        End If
    End Sub

    '**Multiselección**'
    Private Sub HeaderCheckBoxClick(ByVal HCheckBox As CheckBox)
        isHeaderCheckBoxClicked = True
        mensajeValidacion = String.Empty

        For row As Integer = 0 To dgDetallePedido.Rows.Count - 1
            itemActual = row

            If CBool(HCheckBox.Checked) Then
                QuitarPreDespacho(itemActual)
                'If Not (PreDespachar(itemActual)) Then
                '    Exit For
                'End If
                PreDespachar(itemActual)
            Else
                QuitarPreDespacho(itemActual)
            End If

        Next row

        If Len(mensajeValidacion) > 0 Then
            MsgBox(mensajeValidacion, MsgBoxStyle.Exclamation, "Advertencia")
        End If

        dgItemsBulto.DataSource = itemsBulto
        ListaDetallePedido()
        dgDetallePedido.RefreshEdit()
        isHeaderCheckBoxClicked = False

    End Sub

    Private Function PreDespachar(ByVal indexChecked As Integer) As Boolean
        Dim sumaItemBulto As Double = 0
        Dim cantidadStock As Double = 0
        Dim identificador As String = String.Empty
        Dim codigoMaterialPedido As String = String.Empty
        Dim tcitcl As String = dgDetallePedido.Rows(indexChecked).Cells("TCITCL2").Value

        Dim numeroPedido As String = dgCabPedido.CurrentRow.Cells("NRPDTS").Value
        Dim codigoBulto As String = String.Empty
        Dim descripcionMaterial As String = String.Empty

        'Validamos totales
        Dim dataView As New DataView(itemsBulto)
        dataView.Sort = "TCITCL"
        dataView.RowFilter = String.Format("TCITCL = {0}", tcitcl)

        For Each row As DataRowView In dataView
            sumaItemBulto = sumaItemBulto + row("CantPorAtender")
            codigoBulto = row("CREFFW")
        Next row

        identificador = CStr(dgDetallePedido.Rows(indexChecked).Cells("ID").Value)
        Dim customerRow() As Data.DataRow
        customerRow = todoDetallePedido.Select(String.Format("ID = '{0}'", identificador))
        cantidadStock = CDbl(customerRow(0)("CantStock"))
        descripcionMaterial = Trim(CStr(customerRow(0)("TDITES")))

        Dim idPedido As String = CStr(customerRow(0)("ID"))

        inputPedido = New bePedidoTraslado
        inputPedido.In_ccmpn = parametro.Psccmpn 'Compañía(Compañía del detalle de bulto.)
        inputPedido.In_cdvsn = parametro.Pscdvsn 'División (División  del detalle de bulto.)
        inputPedido.In_cplndv = CDec(parametro.Pncplndv) 'Planta(Planta del detalle de bulto.)
        inputPedido.In_cclnt = CDec(parametro.Pncclnt) 'Cód. Cliente (Cód. Cliente del detalle de bulto.)
        inputPedido.In_creffw = parametro.Pscreffw 'Bulto(Cód. del bulto del detalle de bulto.)
        inputPedido.In_nseqin = parametro.Pnnseqin 'Nro. Secuencia (Nro. Secuencia del detalle de bulto)

        inputPedido.In_nrpdts = numeroPedido 'Número de Pedido de traslado(Nro. Pedido del pedido de traslado seleccionado)
        inputPedido.In_nrosec = CDbl(customerRow(0)("NROSEC")) 'Nro. Ítem del Pedido de traslado (Nro. Ítem del Pedido de traslado.)

        inputPedido.In_clarsg = Trim(CStr(customerRow(0)("CLARSG"))) 'Clase de Riesgo (Clase de riesgo del pedido de traslado( Buscar esta información en el detalle del pedido por Pedido y Correlativo))
        inputPedido.In_nroonu = Trim(CStr(customerRow(0)("NROONU"))) 'Nro. onu (Nro. Onu  del pedido de traslado ( Buscar esta información en el detalle del pedido por Pedido y Correlativo))
        inputPedido.In_tpoemb = Trim(CStr(customerRow(0)("TPOEMB"))) 'Tipo Embalaje del pedido de traslado seleccionado (Tipo de embalaje del pedido de traslado ( Buscar esta información en el detalle del pedido por Pedido y Correlativo))
        inputPedido.In_tcitcl = tcitcl 'CodigoMaterial
        inputPedido.In_id = idPedido 'Identificador

        If sumaItemBulto = 0 Then
            mensajeValidacion = String.Format("El material {0} ya tiene asignado un Pedido de Traslado.", Trim(tcitcl))
            'MsgBox(String.Format("El material {0} ya tienen asignado un pedido de traslado.", Trim(tcitcl)), MsgBoxStyle.Exclamation, "Advertencia")
            customerRow(0)("IsChecked") = False
            Return False
        End If


        If (sumaItemBulto <= cantidadStock) And (sumaItemBulto > 0) Then
            For index As Integer = 0 To itemsBulto.Rows.Count - 1
                Dim codigoMaterialBulto As String = CStr(itemsBulto.Rows(index)("TCITCL").ToString())
                Dim cantidadPorAtender As Double = CDbl(itemsBulto.Rows(index)("CantPorAtender").ToString())

                inputPedido.In_cidpaq = itemsBulto.Rows(index)("CIDPAQ") 'Cód. Identificación de paquete(Cód. Identificación de paquete del detalle de bulto)
                inputPedido.In_norcml = itemsBulto.Rows(index)("NORCML").ToString() 'Nro. OC (Nro. OC del detalle de bulto)
                inputPedido.In_nritoc = CDec(itemsBulto.Rows(index)("NRITOC").ToString()) 'Nro. Ítem (Nro. Ítem del detalle de bulto)

                If Trim(tcitcl) = Trim(codigoMaterialBulto) Then
                    If cantidadPorAtender > 0 Then
                        If cantidadPorAtender = cantidadStock Then
                            itemsBulto.Rows(index)("CantPorAtender") = 0
                            itemsBulto.Rows(index)("CantDespachado") = cantidadStock
                            inputPedido.In_qbltsr = CDbl(cantidadStock) 'Saldo cantidad bulto (Saldo cantidad bulto del pedido de traslado seleccionado)
                            customerRow(0)("CantStock") = 0
                            itemsBulto.Rows(index)("ID") = idPedido
                            dgItemsBulto.Rows(index).DefaultCellStyle.BackColor = Color.LemonChiffon
                            customerRow(0)("IsChecked") = True
                            itemsBulto.Rows(index)("NroPedido") = numeroPedido
                            itemsBulto.Rows(index)("NroPosicionPedido") = inputPedido.In_nrosec
                            AddPedidoTranslado()
                        ElseIf cantidadPorAtender > cantidadStock Then
                            itemsBulto.Rows(index)("CantPorAtender") = itemsBulto.Rows(index)("CantPorAtender") - cantidadStock
                            itemsBulto.Rows(index)("CantDespachado") = cantidadStock
                            inputPedido.In_qbltsr = CDbl(cantidadStock)
                            customerRow(0)("CantStock") = customerRow(0)("CantStock") - cantidadStock
                            itemsBulto.Rows(index)("ID") = idPedido
                            dgItemsBulto.Rows(index).DefaultCellStyle.BackColor = Color.LemonChiffon
                            customerRow(0)("IsChecked") = True
                            itemsBulto.Rows(index)("NroPedido") = numeroPedido
                            itemsBulto.Rows(index)("NroPosicionPedido") = inputPedido.In_nrosec
                            AddPedidoTranslado()
                        ElseIf cantidadPorAtender < cantidadStock Then
                            itemsBulto.Rows(index)("CantPorAtender") = itemsBulto.Rows(index)("CantPorAtender") - cantidadPorAtender
                            itemsBulto.Rows(index)("CantDespachado") = cantidadPorAtender
                            inputPedido.In_qbltsr = CDbl(cantidadPorAtender)
                            customerRow(0)("CantStock") = customerRow(0)("CantStock") - cantidadPorAtender
                            itemsBulto.Rows(index)("ID") = idPedido
                            customerRow(0)("IsChecked") = True
                            dgItemsBulto.Rows(index).DefaultCellStyle.BackColor = Color.LemonChiffon
                            itemsBulto.Rows(index)("NroPedido") = numeroPedido
                            itemsBulto.Rows(index)("NroPosicionPedido") = inputPedido.In_nrosec
                            AddPedidoTranslado()
                        End If
                    End If

                End If
            Next
        Else
            mensajeValidacion = String.Format("No se puede asignar el pedido {0} al bulto {1} debido a que la suma de cantidades del material {2} exceden a la cantidad Pendiente del Pedido", numeroPedido, codigoBulto, Trim(tcitcl))
            'MsgBox(String.Format("No se puede asignar el pedido {0} al bulto {1} debido a que la suma de cantidades del material {2} exceden a la cantidad Pendiente del Pedido", numeroPedido, codigoBulto, Trim(tcitcl)), MsgBoxStyle.Exclamation, "Advertencia")
            customerRow(0)("IsChecked") = False
            Return False
        End If
        Return True
    End Function

    Private Sub QuitarPreDespacho(ByVal indexChecked As Integer)
        Dim identificador As String = Trim(dgDetallePedido.Rows(indexChecked).Cells("ID").Value)
        Dim cantDespachado As Double = 0

        'Revertir formato
        For index As Integer = 0 To dgItemsBulto.RowCount - 1
            If Trim(dgItemsBulto.Rows(index).Cells("IDBulto").Value) = Trim(identificador) Then
                dgItemsBulto.Rows(index).DefaultCellStyle.BackColor = Color.White
            End If
        Next

        'Revertir bultos
        For Each rowBulto As DataRow In itemsBulto.Rows
            Dim idEnBulto As String = Trim(rowBulto("ID"))
            If idEnBulto = identificador Then
                rowBulto("CantPorAtender") = rowBulto("CantDespachado")
                cantDespachado = rowBulto("CantDespachado")
                rowBulto("NroPedido") = String.Empty
                rowBulto("NroPosicionPedido") = String.Empty

                'Revertir Pedidos
                For Each rowPedido As DataRow In todoDetallePedido.Rows
                    Dim idEnPedido As String = Trim(rowPedido("ID"))
                    If idEnPedido = identificador Then
                        rowPedido("CantStock") = rowPedido("CantStock") + cantDespachado
                        rowPedido("IsChecked") = False
                    End If
                Next rowPedido

                rowBulto("CantDespachado") = 0
                rowBulto("ID") = String.Empty

                Dim dtTemporal As DataTable = detalleBultoXPedido
                For rowConsolidado As Integer = dtTemporal.Rows.Count - 1 To 0 Step -1
                    If dtTemporal.Rows(rowConsolidado).Item("IN_ID") = identificador Then
                        dtTemporal.Rows(rowConsolidado).Delete()
                    End If
                Next
                dtTemporal.AcceptChanges()
            End If
        Next rowBulto
    End Sub

    Private Sub dgCabPedido_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCabPedido.CurrentCellChanged
        If dgCabPedido.CurrentCellAddress.Y <> -1 Then
            ListaDetallePedido()
        End If
    End Sub

    Private Sub ListaDetallePedido()
        If todoDetallePedido.Rows.Count > 0 Then
            Dim tmpTabla As New DataTable
            tmpTabla = todoDetallePedido.Clone
            Dim result() As DataRow = todoDetallePedido.Select(String.Format("NRPDTS = {0}", dgCabPedido.CurrentRow.Cells("NRPDTS").Value))

            For Each row As DataRow In result
                tmpTabla.ImportRow(row)
            Next row

            dgDetallePedido.DataSource = tmpTabla

            totalCheckBoxes = tmpTabla.Rows.Count
            ValidarCheckHeader()
        End If
    End Sub

    Private Sub AddPedidoTranslado()
        Dim dataRow As DataRow
        dataRow = detalleBultoXPedido.NewRow()
        dataRow.Item("IN_CCMPN") = inputPedido.In_ccmpn 'Compañía
        dataRow.Item("IN_CDVSN") = inputPedido.In_cdvsn 'División
        dataRow.Item("IN_CPLNDV") = CDec(inputPedido.In_cplndv) 'Planta
        dataRow.Item("IN_CCLNT") = CDec(inputPedido.In_cclnt) 'Cód. Cliente
        dataRow.Item("IN_CREFFW") = inputPedido.In_creffw 'Bulto
        dataRow.Item("IN_CIDPAQ") = inputPedido.In_cidpaq 'Cód. Identificación de paquete
        dataRow.Item("IN_NSEQIN") = inputPedido.In_nseqin 'Nro. Secuencia
        dataRow.Item("IN_NORCML") = inputPedido.In_norcml 'Nro. OC
        dataRow.Item("IN_NRITOC") = CDec(inputPedido.In_nritoc) 'Nro. Ítem
        dataRow.Item("IN_NRPDTS") = inputPedido.In_nrpdts 'Número de Pedido de traslado
        dataRow.Item("IN_NROSEC") = inputPedido.In_nrosec 'Nro. Ítem del Pedido de traslado
        dataRow.Item("IN_QBLTSR") = inputPedido.In_qbltsr 'Saldo cantidad bulto
        dataRow.Item("IN_CLARSG") = inputPedido.In_clarsg 'Clase de Riesgo
        dataRow.Item("IN_NROONU") = inputPedido.In_nroonu 'Nro. onu
        dataRow.Item("IN_TPOEMB") = inputPedido.In_tpoemb 'Tipo Embalaje del pedido de traslado seleccionado
        dataRow.Item("IN_USUARI") = objSeguridadBN.pUsuario 'Usuario del sistema
        dataRow.Item("IN_TCITCL") = inputPedido.In_tcitcl 'CodigoMaterial
        dataRow.Item("IN_ID") = inputPedido.In_id 'Identificador
        detalleBultoXPedido.Rows.Add(dataRow)
    End Sub

#Region "check header"
    Private Sub dgDetallePedido_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDetallePedido.CurrentCellDirtyStateChanged
        If TypeOf dgDetallePedido.CurrentCell Is DataGridViewCheckBoxCell Then
            dgDetallePedido.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub HeaderCheckBox_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        HeaderCheckBoxClick(DirectCast(sender, CheckBox))
    End Sub

    Private Sub HeaderCheckBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            HeaderCheckBoxClick(DirectCast(sender, CheckBox))
        End If
    End Sub

    Private Sub dgDetallePedido_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgDetallePedido.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
            ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex)
        End If
    End Sub


    Private Sub ResetHeaderCheckBoxLocation(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer)
        Dim oRectangle As Rectangle = Me.dgDetallePedido.GetCellDisplayRectangle(ColumnIndex, RowIndex, True)
        Dim oPoint As New Point()

        oPoint.X = oRectangle.Location.X + (oRectangle.Width - headerCheckBox.Width) / 2 + 1
        oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - headerCheckBox.Height) / 2 + 1

        headerCheckBox.Location = oPoint
    End Sub

    Private Sub ValidarCheckHeader()
        Dim dataView As New DataView(todoDetallePedido)
        dataView.Sort = "NRPDTS"
        dataView.RowFilter = String.Format("NRPDTS = {0}", dgCabPedido.CurrentRow.Cells("NRPDTS").Value)

        Dim totalCheckedCheckBoxes As Integer = 0

        For Each row As DataRowView In dataView
            If CBool(row("IsChecked").ToString) Then
                totalCheckedCheckBoxes += 1
            End If
        Next row

        If totalCheckedCheckBoxes < totalCheckBoxes Then
            headerCheckBox.Checked = False
        ElseIf totalCheckedCheckBoxes = totalCheckBoxes Then
            headerCheckBox.Checked = True
        End If
    End Sub
#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        detalleBultoXPedido.Clear()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        retornarValor = False
        If detalleBultoXPedido.Rows.Count > 0 Then
            For Each despacho As DataGridViewRow In dgItemsBulto.Rows
                If Trim(despacho.Cells("IDBulto").Value) = String.Empty Then
                    MsgBox(String.Format("El Bulto {0} tiene materiales que no estan asignados a los Pedidos de Traslado.", parametro.Pscreffw), MsgBoxStyle.Exclamation, "Advertencia")
                    Exit Sub
                End If
            Next
        End If

        retornarValor = True
        Me.Close()

    End Sub

    Private Sub frmPedidoTrasladoBulto_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If retornarValor = False Then
            detalleBultoXPedido.Clear()
        End If
    End Sub

    Private Sub dgItemsBulto_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemsBulto.CellContentDoubleClick

    End Sub

    Private Sub dgItemsBulto_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgItemsBulto.CellMouseClick
        dgItemsBulto.ClearSelection()
    End Sub

    Private Sub dgItemsBulto_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgItemsBulto.CellMouseDown
        dgItemsBulto.ClearSelection()
    End Sub

    Private Sub dgItemsBulto_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgItemsBulto.CellMouseMove
        dgItemsBulto.ClearSelection()
    End Sub

    Private Sub dgItemsBulto_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgItemsBulto.CellMouseUp
        dgItemsBulto.ClearSelection()
    End Sub

    Private Sub dgItemsBulto_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgItemsBulto.CellMouseDoubleClick
        For indexRow As Integer = 0 To dgCabPedido.Rows.Count - 1
            If dgCabPedido.Rows(indexRow).Cells("NRPDTS").Value = dgItemsBulto.CurrentRow.Cells("NroPedido").Value Then
                dgCabPedido.Rows(indexRow).Selected = True
                dgCabPedido.CurrentCell = dgCabPedido.Rows(indexRow).Cells(2)
                Exit For
            End If
        Next

        For indexRow As Integer = 0 To dgDetallePedido.Rows.Count - 1
            If dgDetallePedido.Rows(indexRow).Cells("ID").Value = dgItemsBulto.CurrentRow.Cells("IDBulto").Value Then
                dgDetallePedido.Rows(indexRow).Selected = True
                dgDetallePedido.CurrentCell = dgDetallePedido.Rows(indexRow).Cells(2)
                Exit For
            End If
        Next
    End Sub

    Private Sub dgDetallePedido_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetallePedido.CellContentClick

    End Sub
End Class
Imports RANSA.NEGO
Imports RANSA.TYPEDEF
Imports Ransa.TypeDef.WayBill
Imports Ransa.DAO.WayBill
Imports Ransa.Controls.WayBill
Imports ComponentFactory.Krypton.Toolkit

Public Class frmGenerarPreDespachoPorPedidoTraslado
    Public lstbeDespacho As List(Of beDespacho)
    Private obrDespacho As New brDespacho
    Private obrBulto As New brBulto
    Private DsBultoStock As DataSet
    Private DsDetallePedido As DataSet
    Private DsBultoDetalleStock As DataSet
    Private DsBulto As DataSet
    Private DsBultoDetalle As DataSet
    Private lstBultosAgregados As New List(Of String)
    'Private codigoBultoSeleccionado As String
    Private dtPreDespacho As New DataTable 'cambio
    Private dtSaldo As New DataTable

    Private _tmpPedidos As New DataTable
    Private _tmpStock As New DataTable

    ''' <summary>
    ''' Dagnino
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

#Region "Eventos Formulario"
    'cambio
    Private Sub frmGenerarPreDespachoPorPedidoTraslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsBultoStock = New DataSet
        DsDetallePedido = New DataSet
        DsBultoDetalleStock = New DataSet
        DsBulto = New DataSet
        DsBultoDetalle = New DataSet

        dtSaldo = New DataTable
        dtSaldo.Columns.Add("CodigoBulto")
        dtSaldo.Columns.Add("CodigoMaterial")
        dtSaldo.Columns.Add("Cantidad")

        dgDetPedidoTraslado.AutoGenerateColumns = False
        pCargarCabeceraPedido()
        pCargarBultos()
        pCargarDetalleBultosStock()
        pCargarDetallesPedidoTraslado()

        If (dgCabPedidoTraslado.RowCount > 0) Then
            dgCabPedidoTraslado.Rows(0).Cells("M_FECPED").Selected = True
            dgCabPedidoTraslado.Rows(0).Cells("M_NRPDTS").Selected = True
            dgCabPedidoTraslado.Select()
            'dgCabPedidoTraslado.Rows(0).Cells(4).Selected = True
            'dgCabPedidoTraslado.Rows(0).Cells(2).Selected = True
            'dgCabPedidoTraslado.Rows(0).Cells(1).Selected = True
            'RaiseEvent dgCabPedidoTraslado_CurrentCellChanged()
        End If

        Me.dgDetPedidoTraslado.Columns(15).ReadOnly = False
        Me.dgDetPedidoTraslado.Columns(16).ReadOnly = False
        Me.dgDetPedidoTraslado.Columns(17).ReadOnly = False
        FormatoCantidadAtender()

        dtPreDespacho = New DataTable
        dtPreDespacho.Columns.Add("IN_CCMPN")
        dtPreDespacho.Columns.Add("IN_CDVSN")
        dtPreDespacho.Columns.Add("IN_CPLNDV")
        dtPreDespacho.Columns.Add("IN_CCLNT")
        dtPreDespacho.Columns.Add("IN_CREFFW")
        dtPreDespacho.Columns.Add("IN_CIDPAQ")
        dtPreDespacho.Columns.Add("IN_NSEQIN")
        dtPreDespacho.Columns.Add("IN_NORCML")
        dtPreDespacho.Columns.Add("IN_NRITOC")
        dtPreDespacho.Columns.Add("IN_NRPDTS")
        dtPreDespacho.Columns.Add("IN_NROSEC")
        dtPreDespacho.Columns.Add("IN_QBLTSR")
        dtPreDespacho.Columns.Add("IN_CLARSG")
        dtPreDespacho.Columns.Add("IN_NROONU")
        dtPreDespacho.Columns.Add("IN_TPOEMB")
        dtPreDespacho.Columns.Add("IN_USUARI")
        dtPreDespacho.Columns.Add("CodigoMaterial")


        _tmpPedidos = New DataTable
        _tmpPedidos.Columns.Add("IN_NROSEC")
        _tmpPedidos.Columns.Add("IN_QBLTSR")
        _tmpPedidos.Columns.Add("IN_CLARSG")
        _tmpPedidos.Columns.Add("IN_NROONU")
        _tmpPedidos.Columns.Add("IN_TPOEMB")
        _tmpPedidos.Columns.Add("IN_TCITCL")

        _tmpStock = New DataTable
        _tmpStock.Columns.Add("IN_CCMPN")
        _tmpStock.Columns.Add("IN_CDVSN")
        _tmpStock.Columns.Add("IN_CPLNDV")
        _tmpStock.Columns.Add("IN_CCLNT")
        _tmpStock.Columns.Add("IN_CREFFW")
        _tmpStock.Columns.Add("IN_CIDPAQ")
        _tmpStock.Columns.Add("IN_NSEQIN")
        _tmpStock.Columns.Add("IN_NORCML")
        _tmpStock.Columns.Add("IN_NRITOC")
        _tmpStock.Columns.Add("IN_QBLTSR")
        _tmpStock.Columns.Add("IN_TCITCL")

    End Sub
 


    Private Sub TsbPreDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbPreDespacho.Click  'cambio
        If MessageBox.Show("¿Desea Generar El Pre-Despacho?.", "Pre-despacho", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If fValidarBultosEnPedido() Then
                If fValidarCantidadesMercaderia() Then

                    'For Each dtBulto As DataTable In DsBulto.Tables


                    'Next
                    pGenerarPredespacho(DsBulto)
                    pActualizarBultoPedidoTraslado()
                End If
            End If
        End If
    End Sub

    Private Sub TsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbCerrar.Click

        DsBultoStock.Dispose()
        DsDetallePedido.Dispose()
        DsBultoDetalleStock.Dispose()
        DsBulto.Dispose()
        DsBultoDetalle.Dispose()

        lstBultosAgregados.Clear()

        ' se indica que cancelo la operacion
        Me.Close()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

    End Sub


#End Region

#Region "Funciones, Métodos y Procedimientos"
    Sub pCargarCabeceraPedido()

        Dim dtTemp As New DataTable
        Dim dtPedidos As New DataTable
        Dim indicePedido As Integer = 0

        For Each desp As beDespacho In lstbeDespacho
            dtTemp = obrDespacho.fdtListaPedidoTraslado(desp)
            ' la primera vez hace el clone luego ya no para que no sobreescriba sino solo sale el ultimo pedido
            If indicePedido = 0 Then
                dtPedidos = dtTemp.Clone()
            End If
            indicePedido += 1
            If dtTemp.Rows.Count > 0 Then
                dtPedidos.ImportRow(dtTemp.Rows(0))
            End If
        Next

        If dtPedidos.Rows.Count > 0 Then
            dgCabPedidoTraslado.DataSource = dtPedidos
            'dgCabPedidoTraslado.AutoGenerateColumns = False
            'dgCabPedidoTraslado.DataSource = dtPedidos

        End If
    End Sub
    Sub pCargarDetallesPedidoTraslado()

        Dim DtDetallePedido As DataTable
        Dim obeDespacho As beDespacho
        'Dim cantidad As Decimal = 0D
        'Dim codMaterial As String

        For Each row As DataGridViewRow In dgCabPedidoTraslado.Rows

            obeDespacho = New beDespacho

            obeDespacho.PNCCLNT = Val(row.Cells("M_CCLNT").Value)
            obeDespacho.PNNRPDTS = Val(row.Cells("M_NRPDTS").Value)

            DtDetallePedido = obrDespacho.fdtListaDetallePedidoTrasladoAtender(obeDespacho)

            Dim newCol As New DataColumn
            newCol.ColumnName = "QTYATE"
            newCol.DefaultValue = 0
            DtDetallePedido.Columns.Add(newCol)

            'For Each dr As DataRow In DtDetallePedido.Rows

            '    codMaterial = dr.Item("TCITCL").ToString()

            '    Dim dsTmpBulto = DsBultoStock.Tables(row.Cells("M_NRPDTS").Value.ToString())
            '    cantidad = 0

            '    If Not dsTmpBulto Is Nothing Then
            '        For Each drB As DataRow In dsTmpBulto.Rows
            '            If drB.RowState <> DataRowState.Deleted Then
            '                For Each drDB As DataRow In DsBultoDetalleStock.Tables(drB.Item("CREFFW").ToString()).Rows
            '                    If codMaterial = drDB.Item("TCITCL").ToString() Then
            '                        cantidad = cantidad + Convert.ToDecimal(drDB.Item("QBLTSR"))
            '                    End If
            '                Next
            '            End If
            '        Next
            '    End If

            '    dr.Item("QTYATE") = cantidad

            'Next

            'DsDetallePedido.Tables.Remove(DtDetallePedido.TableName)
            DsDetallePedido.Tables.Add(DtDetallePedido)

        Next

    End Sub

    Function DistinctDTDetalleBultos(ByVal dataTableBultos As DataTable) As DataTable

        Dim i As Integer
        Dim totalCantidad As Decimal

        Dim View As DataView = New DataView(dataTableBultos)
        Dim dtDistinctValues As New DataTable
        dtDistinctValues = View.ToTable(dataTableBultos.TableName, True, "TCITCL") '"NRITOC" , "CIDPAQ" "QBLTSR"

        Dim newCol As New DataColumn
        newCol.ColumnName = "QBLTSR"
        dtDistinctValues.Columns.Add(newCol)

        For i = 0 To dtDistinctValues.Rows.Count - 1

            totalCantidad = CDec(dataTableBultos.Compute("Sum(QBLTSR)", "TCITCL = " & dtDistinctValues.Rows(i).Item("TCITCL")))

            dtDistinctValues.Rows(i).Item("QBLTSR") = totalCantidad

        Next

        Return dtDistinctValues
    End Function


    Sub PCalcularCantidadAtender() 'Cambio
        'dtPreDespacho.Clear()
        Dim nroPedido As String = dgCabPedidoTraslado.CurrentRow.Cells("M_NRPDTS").Value.trim

        Dim dt As DataTable = dtPreDespacho
        For x As Integer = dt.Rows.Count - 1 To 0 Step -1
            If dt.Rows(x).Item("IN_NRPDTS") = nroPedido Then
                dt.Rows(x).Delete()
            End If
        Next
        dt.AcceptChanges()

        Dim dtMatriz As DataTable

        If DsBultoDetalle.Tables.Count > 0 AndAlso Not DsBultoDetalle.Tables(0) Is Nothing Then
            dtMatriz = DsBultoDetalle.Tables(0).Clone()
        End If



        Dim tablaDetalleBulto As String = String.Empty

        For Each bultoSeleccionado As DataGridViewRow In dgBultos.Rows
            Dim codigoBultoSeleccionado As String = bultoSeleccionado.Cells("MBB_CREFFW").Value.ToString()
            tablaDetalleBulto = codigoBultoSeleccionado.Trim + nroPedido

            If Not DsBultoDetalle.Tables(tablaDetalleBulto) Is Nothing Then
                Dim dtSumaCantidadesBultos As New DataTable
                dtSumaCantidadesBultos = DistinctDTDetalleBultos(DsBultoDetalle.Tables(tablaDetalleBulto))


                For Each row As DataRow In DsBultoDetalle.Tables(tablaDetalleBulto).Rows
                    dtMatriz.Rows.Add(row.ItemArray)
                Next row


                For Each bulto As DataRow In dtSumaCantidadesBultos.Rows
                    Dim pedidoAtendido As New List(Of String)

                    Dim codigoMateriaBulto As String = bulto.Item("TCITCL").ToString()
                    Dim pedidoTrabajado As Boolean = False
                    Dim flatAcciom As Boolean = False
                    Dim cantidadStock As Decimal = 0

                    For Each bultoStock As DataRow In dtSumaCantidadesBultos.Rows
                        If codigoMateriaBulto = bultoStock.Item("TCITCL").ToString() Then
                            cantidadStock += CDec(bultoStock.Item("QBLTSR").ToString())
                        End If
                    Next

                    For Each codmaterial As String In pedidoAtendido
                        If (codmaterial = codigoMateriaBulto) Then
                            flatAcciom = True
                            Exit For
                        End If
                    Next

                    If Not flatAcciom Then
                        For Each codmaterial As DataRow In dtSaldo.Rows
                            If (codmaterial.Item("CodigoMaterial").ToString = codigoMateriaBulto) Then
                                pedidoTrabajado = True
                                Exit For
                            End If
                        Next

                        If Not pedidoTrabajado Then
                            Dim dataRow As DataRow
                            dataRow = dtSaldo.NewRow()
                            dataRow.Item("CodigoBulto") = codigoBultoSeleccionado
                            dataRow.Item("CodigoMaterial") = codigoMateriaBulto
                            dataRow.Item("Cantidad") = cantidadStock
                            dtSaldo.Rows.Add(dataRow)
                            pedidoAtendido.Add(codigoMateriaBulto)
                        Else
                            For Each codmaterial As DataRow In dtSaldo.Rows
                                If codmaterial.Item("CodigoMaterial").ToString = codigoMateriaBulto Then
                                    codmaterial.Item("Cantidad") = codmaterial.Item("Cantidad") + cantidadStock
                                End If
                            Next
                        End If
                    End If
                Next
            End If
        Next


        If Not DsDetallePedido.Tables(nroPedido) Is Nothing Then

            For Each pedido As DataRow In DsDetallePedido.Tables(nroPedido).Rows
                Dim codigoMateriaPedido As String = pedido.Item("TCITCL").ToString()
                Dim cantidadPendiente As Decimal = pedido.Item("QTYPEN").ToString()
                pedido.Item("QTYATE") = 0

                If Not dtMatriz Is Nothing Then
                    For Each stock As DataRow In dtMatriz.Rows
                        Dim codMaterial As String = stock.Item("TCITCL").ToString
                        Dim canStock As Decimal = CDec(stock.Item("QBLTSR").ToString)
                        Dim canUsado As Decimal = CDec(stock.Item("QPEPQT").ToString)


                        If codigoMateriaPedido = codMaterial Then
                            If canStock > 0 Then

                                If cantidadPendiente < canStock Then
                                    pedido.Item("QTYATE") = pedido.Item("QTYATE") + cantidadPendiente
                                    stock.Item("QBLTSR") = (canStock - cantidadPendiente)
                                    stock.Item("QPEPQT") = (canUsado + cantidadPendiente)
                                    CrearMatriz(nroPedido, stock.Item("CCMPN").ToString(), stock.Item("CDVSN").ToString(), stock.Item("CPLNDV").ToString(), stock.Item("CCLNT").ToString(), stock.Item("CREFFW").ToString(), stock.Item("CIDPAQ").ToString(), stock.Item("NSEQIN").ToString(), stock.Item("NORCML").ToString(), stock.Item("NRITOC").ToString(), pedido.Item("NROSEC").ToString(), (CInt(stock.Item("QPEPQT").ToString()) - CInt(canUsado)).ToString(), pedido.Item("CLARSG").ToString(), pedido.Item("NROONU").ToString(), pedido.Item("TPOEMB").ToString(), pedido.Item("TCITCL").ToString())
                                    Exit For

                                ElseIf canStock < cantidadPendiente Then
                                    pedido.Item("QTYATE") = pedido.Item("QTYATE") + canStock
                                    stock.Item("QBLTSR") = 0
                                    stock.Item("QPEPQT") = (canUsado + canStock)
                                    cantidadPendiente = (cantidadPendiente - canStock)
                                    CrearMatriz(nroPedido, stock.Item("CCMPN").ToString(), stock.Item("CDVSN").ToString(), stock.Item("CPLNDV").ToString(), stock.Item("CCLNT").ToString(), stock.Item("CREFFW").ToString(), stock.Item("CIDPAQ").ToString(), stock.Item("NSEQIN").ToString(), stock.Item("NORCML").ToString(), stock.Item("NRITOC").ToString(), pedido.Item("NROSEC").ToString(), (CInt(stock.Item("QPEPQT").ToString()) - CInt(canUsado)).ToString(), pedido.Item("CLARSG").ToString(), pedido.Item("NROONU").ToString(), pedido.Item("TPOEMB").ToString(), pedido.Item("TCITCL").ToString())
                                Else
                                    pedido.Item("QTYATE") = pedido.Item("QTYATE") + canStock
                                    stock.Item("QBLTSR") = 0
                                    stock.Item("QPEPQT") = (canUsado + canStock)

                                    CrearMatriz(nroPedido, stock.Item("CCMPN").ToString(), stock.Item("CDVSN").ToString(), stock.Item("CPLNDV").ToString(), stock.Item("CCLNT").ToString(), stock.Item("CREFFW").ToString(), stock.Item("CIDPAQ").ToString(), stock.Item("NSEQIN").ToString(), stock.Item("NORCML").ToString(), stock.Item("NRITOC").ToString(), pedido.Item("NROSEC").ToString(), (CInt(stock.Item("QPEPQT").ToString()) - CInt(canUsado)).ToString(), pedido.Item("CLARSG").ToString(), pedido.Item("NROONU").ToString(), pedido.Item("TPOEMB").ToString(), pedido.Item("TCITCL").ToString())
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                End If
            Next
        End If
        dgDetPedidoTraslado.Update()


        FormatoCantidadAtender()

    End Sub


    Function ValidarCantidadPendiente(ByVal codigoBulto As String, ByVal nroPedido As String) As Boolean

        Dim codMaterialPedido As String
        Dim cantidadTotalPendiente As Integer = 0

        Dim cantidadTotalMaterialStock As Integer = 0
        Dim cantidadTotalMaterialBulto As Integer = 0
        Dim cantidadTotalMaterial As Integer = 0

        If Not DsDetallePedido.Tables(nroPedido) Is Nothing Then
            For Each dr As DataRow In DsDetallePedido.Tables(nroPedido).Rows
                codMaterialPedido = dr.Item("TCITCL").ToString()
                cantidadTotalPendiente = 0

                For Each drRep As DataRow In DsDetallePedido.Tables(nroPedido).Rows
                    If codMaterialPedido = drRep.Item("TCITCL").ToString() Then
                        cantidadTotalPendiente = cantidadTotalPendiente + Convert.ToDecimal(drRep.Item("QTYPEN").ToString())
                    End If
                Next

                cantidadTotalMaterialStock = CantidadTotalMercaderiaStock(codigoBulto, nroPedido, codMaterialPedido)
                cantidadTotalMaterialBulto = CantidadTotalMercaderiaBulto(nroPedido, codMaterialPedido)
                cantidadTotalMaterial = cantidadTotalMaterialStock + cantidadTotalMaterialBulto

                If cantidadTotalMaterial > cantidadTotalPendiente Then
                    MessageBox.Show("No se puede asignar el bulto " & codigoBulto.ToString().Trim() & " al Pedido " & nroPedido & " debido a que la suma de cantidades del material " & codMaterialPedido & " exceden a la cantidad Pendiente del Pedido.", "Pre-Despacho: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

            Next
        End If


        'For Each row As DataGridViewRow In dgCabPedidoTraslado.Rows

        '    If Not DsDetallePedido.Tables(row.Cells("M_NRPDTS").Value.ToString().Trim()) Is Nothing Then
        '        For Each dr As DataRow In DsDetallePedido.Tables(row.Cells("M_NRPDTS").Value.ToString().Trim()).Rows
        '            codMaterialPedido = dr.Item("TCITCL").ToString()
        '            cantidadTotalPendiente = 0

        '            For Each drRep As DataRow In DsDetallePedido.Tables(row.Cells("M_NRPDTS").Value.ToString().Trim()).Rows
        '                If codMaterialPedido.Trim = drRep.Item("TCITCL").ToString().Trim Then
        '                    cantidadTotalPendiente = cantidadTotalPendiente + Convert.ToDecimal(drRep.Item("QTYPEN").ToString())
        '                End If
        '            Next

        '            cantidadTotalMaterialStock = CantidadTotalMercaderiaStock(codigoBulto, nroPedido, codMaterialPedido)
        '            cantidadTotalMaterialBulto = CantidadTotalMercaderiaBulto(nroPedido, codMaterialPedido)
        '            cantidadTotalMaterial = cantidadTotalMaterialStock + cantidadTotalMaterialBulto

        '            If cantidadTotalMaterial > cantidadTotalPendiente Then
        '                MessageBox.Show("No se puede asignar el bulto " & codigoBulto.ToString().Trim() & " al Pedido " & nroPedido & " debido a que la suma de cantidades del material " & codMaterialPedido & " exceden a la cantidad Pendiente del Pedido.", "Pre-Despacho: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                Return False
        '            End If

        '        Next
        '    End If
        'Next

        Return True

    End Function

    Function CantidadTotalMercaderiaStock(ByVal codigoBulto As String, ByVal nroPedido As String, ByVal codigoMaterial As String) As Integer

        Dim cantidadTotalMaterial As Integer = 0

        For Each drDB As DataRow In DsBultoDetalleStock.Tables(codigoBulto.ToString().Trim() + "" + nroPedido.ToString()).Rows
            If codigoMaterial = drDB.Item("TCITCL").ToString() Then
                cantidadTotalMaterial = cantidadTotalMaterial + Convert.ToDecimal(drDB.Item("QBLTSR").ToString())
            End If
        Next

        Return cantidadTotalMaterial

    End Function

    Function CantidadTotalMercaderiaBulto(ByVal nroPedido As String, ByVal codigoMaterial As String) As Integer

        Dim cantidadTotalMaterial As Integer = 0
        Dim codBulto As String

        If Not DsBulto.Tables(nroPedido) Is Nothing Then
            For Each dtB As DataRow In DsBulto.Tables(nroPedido).Rows
                If dtB.RowState <> DataRowState.Deleted Then
                    codBulto = dtB.Item("CREFFW").ToString().Trim()

                    For Each dtD As DataRow In DsBultoDetalle.Tables(codBulto + nroPedido).Rows
                        If codigoMaterial = dtD.Item("TCITCL").ToString() Then
                            cantidadTotalMaterial = cantidadTotalMaterial + Convert.ToDecimal(dtD.Item("QBLTSR").ToString())
                        End If
                    Next

                End If
            Next
        End If

        Return cantidadTotalMaterial

    End Function


    Sub FormatoCantidadAtender()

        Dim cantidadPendiente As Decimal
        Dim cantidadAtender As Decimal

        For Each row As DataGridViewRow In dgDetPedidoTraslado.Rows

            cantidadPendiente = row.Cells("MD_QTYPEN").Value
            cantidadAtender = row.Cells("MD_QTYATE").Value
            If cantidadPendiente <> cantidadAtender Then
                row.Cells("MD_QTYATE").Style.ForeColor = Color.Red
            Else
                row.Cells("MD_QTYATE").Style.ForeColor = Color.Black
            End If

        Next

    End Sub



    Sub pCargarDetallePedido()
        Dim nroPedido As Int64
        Dim obeDespacho As New beDespacho
        Dim dtDetalle As New DataTable
        'Dim cantidadPendiente As Decimal
        'Dim cantidadAtender As Decimal
        'Dim binding As BindingSource
        With dgCabPedidoTraslado
            If .RowCount > 0 Then
                If Not .CurrentRow Is Nothing Then
                    nroPedido = Val(.CurrentRow.Cells.Item("M_NRPDTS").Value)

                    For Each dt As DataTable In DsDetallePedido.Tables
                        If dt.TableName() = nroPedido Then
                            dtDetalle = dt
                        End If
                    Next
                Else
                    'nroPedido = Val(.Rows(0).Cells("M_NRPDTS").Value)
                    If DsDetallePedido.Tables.Count > 0 Then
                        dtDetalle = DsDetallePedido.Tables(0)
                    End If
                End If

                dgDetPedidoTraslado.DataSource = dtDetalle

            End If
        End With

        'FormatoCantidadAtender()
        'For Each row As DataGridViewRow In dgDetPedidoTraslado.Rows

        '    cantidadPendiente = row.Cells("MD_QTYPEN").Value
        '    cantidadAtender = row.Cells("MD_QTYATE").Value
        '    If cantidadPendiente <> cantidadAtender Then
        '        row.Cells("MD_QTYATE").Style.ForeColor = Color.Red
        '    End If

        'Next
    End Sub

    Sub pCargarBultos()

        Dim DtBulto As DataTable
        Dim obebulto As beBulto
        For Each row As DataGridViewRow In dgCabPedidoTraslado.Rows
            obebulto = New beBulto

            obebulto.PSCCMPN = row.Cells("M_CCMPN").Value.ToString()
            obebulto.PSCDVSN = row.Cells("M_CDVSN").Value.ToString()
            obebulto.PNCPLNDV = Val(row.Cells("M_CPLNDV").Value)
            obebulto.PNCCLNT = Val(row.Cells("M_CCLNT").Value)
            obebulto.PSNRPDTS = Convert.ToInt64(row.Cells("M_NRPDTS").Value)

            DtBulto = obrBulto.ObtenerBultoPedidoTraslado(obebulto)
            DsBultoStock.Tables.Add(DtBulto)

        Next

        'Dim codBulto As Integer
        'Dim dtName As String
        'Dim dtNamesRecorridos As New List(Of String)
        'If DsBulto.Tables.Count > 1 Then
        '    For Each dt As DataTable In DsBulto.Tables
        '        dtName = dt.TableName.ToString()

        '        For Each row As DataRow In dt.Rows
        '            codBulto = Val(row.Item("CREFFW"))
        '            For Each dtB As DataTable In DsBulto.Tables
        '                If Not dtName = dtB.TableName And dtNamesRecorridos.Contains(dtName) = False Then
        '                    For Each rowB As DataRow In dt.Rows
        '                        If rowB.RowState <> DataRowState.Deleted Then
        '                            If codBulto = Val(rowB.Item("CREFFW")) Then
        '                                rowB.Delete()
        '                            End If
        '                        End If
        '                    Next
        '                End If
        '            Next
        '        Next

        '        dtNamesRecorridos.Add(dtName)
        '    Next
        'End If

        'Dim codBulto As String
        'Dim lstItemsExistentes As New List(Of String)
        'If DsBulto.Tables.Count > 1 Then

        '    For Each row As DataRow In DsBulto.Tables(0).Rows
        '        lstItemsExistentes.Add(row.Item("CREFFW").ToString())  'agregamos los bultos del primer datatable de bultos como referencia
        '    Next

        '    'For Each dt As DataTable In DsBulto.Tables

        '    'Next

        '    For i As Integer = 1 To DsBulto.Tables.Count - 1

        '        For Each row As DataRow In DsBulto.Tables(i).Rows

        '            If lstItemsExistentes.Contains(row.Item("CREFFW").ToString()) Then
        '                row.Delete()
        '            Else
        '                lstItemsExistentes.Add(row.Item("CREFFW").ToString())
        '            End If

        '        Next

        '    Next


        'End If



        'If DsBulto.Tables.Count > 0 Then
        '    dgBultos.DataSource = DsBulto.Tables(0)
        'End If

    End Sub

    Sub pCargarBulto()

        Dim nroPedido As Int64
        Dim obeDespacho As New beDespacho
        Dim dtBulto As New DataTable
        With dgCabPedidoTraslado
            If .RowCount > 0 Then
                If Not .CurrentRow Is Nothing Then
                    nroPedido = .CurrentRow.Cells.Item("M_NRPDTS").Value

                    For Each dt As DataTable In DsBulto.Tables
                        If dt.TableName() = nroPedido Then
                            dtBulto = dt
                        End If
                    Next
                    'Else
                    '    'nroPedido = Val(.Rows(0).Cells("M_NRPDTS").Value)
                    '    dtBulto = DsBulto.Tables(0)
                    If dtBulto.Rows.Count > 0 Then
                        dgBultos.DataSource = dtBulto
                    End If
                End If


            End If
        End With

    End Sub

    Sub pCargarBultoStock()

        Dim nroPedido As Int64
        Dim obeDespacho As New beDespacho
        Dim dtBulto As New DataTable
        With dgCabPedidoTraslado
            If .RowCount > 0 Then
                If Not .CurrentRow Is Nothing Then
                    nroPedido = .CurrentRow.Cells.Item("M_NRPDTS").Value

                    For Each dt As DataTable In DsBultoStock.Tables
                        If dt.TableName() = nroPedido Then
                            dtBulto = dt
                        End If
                    Next
                    'Else
                    '    'nroPedido = Val(.Rows(0).Cells("M_NRPDTS").Value)
                    '    dtBulto = DsBulto.Tables(0)
                    If dtBulto.Rows.Count > 0 Then
                        dgBultosStock.DataSource = dtBulto
                    Else
                        dgBultosStock.DataSource = Nothing
                    End If
                End If


            End If
        End With

    End Sub

    Sub pCargarDetalleBultosStock()

        Dim DtBultoDetalle As DataTable
        Dim obeBulto As beBulto
        For Each dt As DataTable In DsBultoStock.Tables

            For Each dr As DataRow In dt.Rows
                If dr.RowState <> DataRowState.Deleted Then
                    obeBulto = New beBulto

                    With obeBulto
                        .PSCCMPN = dr.Item("CCMPN").ToString()
                        .PSCDVSN = dr.Item("CDVSN").ToString()
                        .PNCPLNDV = Val(dr.Item("CPLNDV"))
                        .PNCCLNT = Val(dr.Item("CCLNT"))
                        .PSCREFFW = dr.Item("CREFFW").ToString()
                        .PNNSEQIN = Val(dr.Item("NSEQIN"))
                        .PSNRPDTS = dt.TableName.ToString()
                        '.PNFREFFW = dr.Item("FREFFW").ToString()
                        '.PSDESCWB = dr.Item("DESCWB")
                    End With
                    'dgBultoDetalle.AutoGenerateColumns = False
                    DtBultoDetalle = obrBulto.flListarDetalleBulto(obeBulto)

                    DsBultoDetalleStock.Tables.Add(DtBultoDetalle)
                End If
            Next

        Next



    End Sub

    Sub pCargarDetalleBultoStock()

        Dim codBulto As String
        Dim pedido As String
        Dim obeDespacho As New beDespacho
        Dim dtDetalleBulto As New DataTable
        With dgBultosStock
            If .RowCount > 0 Then
                If Not .CurrentRow Is Nothing Then
                    If Not .CurrentRow.Cells.Item("MB_CREFFW").Value Is Nothing Then
                        codBulto = .CurrentRow.Cells.Item("MB_CREFFW").Value.ToString().Trim()
                        pedido = dgCabPedidoTraslado.CurrentRow.Cells("M_NRPDTS").Value.ToString().Trim()
                        For Each dt As DataTable In DsBultoDetalleStock.Tables
                            If dt.TableName().ToString() = codBulto + pedido Then
                                dtDetalleBulto = dt
                            End If
                        Next
                    End If
                Else
                    dtDetalleBulto = New DataTable()
                End If

                dgBultoDetalleStock.DataSource = dtDetalleBulto
            End If




        End With

    End Sub

    Sub pCargarDetalleBulto()

        Dim codBulto, pedido As String
        Dim obeDespacho As New beDespacho
        Dim dtDetalleBulto As New DataTable
        With dgBultos
            If .RowCount > 0 Then
                If Not .CurrentRow Is Nothing Then
                    If Not .CurrentRow.Cells.Item("MBB_CREFFW").Value Is Nothing Then
                        codBulto = .CurrentRow.Cells.Item("MBB_CREFFW").Value.ToString().Trim()
                        pedido = dgCabPedidoTraslado.CurrentRow.Cells("M_NRPDTS").Value.ToString().Trim()
                        For Each dt As DataTable In DsBultoDetalle.Tables
                            If dt.TableName().ToString() = codBulto + pedido Then
                                dtDetalleBulto = dt
                            End If
                        Next
                    End If
                Else
                    dtDetalleBulto = New DataTable()
                End If

                dgBultoDetalle.DataSource = dtDetalleBulto
            End If
        End With

    End Sub
    Private Sub pEliminarItemBulto()

        '' '' ''Try
        If Me.dgBultos.CurrentRow Is Nothing Then Exit Sub

        Dim ss As New DataGridViewRow
        Dim dRow As DataRow
        Dim dtBultoStock As New DataTable
        Dim dtBulto As New DataTable
        Dim strNombreDt As String
        Dim strPedido As String
        dtBultoStock = dgBultosStock.DataSource
        dtBulto = dtBultoStock.Clone()
        strNombreDt = dtBulto.TableName()
        strPedido = dgCabPedidoTraslado.CurrentRow.Cells("M_NRPDTS").Value.ToString().Trim()

        If MessageBox.Show("¿Desea eliminar el bulto seleccionado?.", "Pre-despacho", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            For Each selRow As DataGridViewRow In dgBultos.SelectedRows
                dRow = CType(selRow.DataBoundItem, DataRowView).Row()
                DsBultoStock.Tables(strNombreDt).ImportRow(dRow)
                lstBultosAgregados.Remove(dRow("CREFFW").ToString())


                Dim dt As DataTable = dtPreDespacho
                For x As Integer = dt.Rows.Count - 1 To 0 Step -1
                    If dt.Rows(x).Item("IN_CREFFW") = dRow("CREFFW").ToString() Then
                        dt.Rows(x).Delete()
                    End If
                Next
                dt.AcceptChanges()

                Dim dts As DataTable = dtSaldo
                For x As Integer = dts.Rows.Count - 1 To 0 Step -1
                    If dts.Rows(x).Item("CodigoBulto") = dRow("CREFFW").ToString() Then
                        dts.Rows(x).Delete()
                    End If
                Next
                dts.AcceptChanges()

                If Not DsBultoDetalle.Tables(dRow("CREFFW").ToString().Trim() + strPedido) Is Nothing Then
                    DsBultoDetalle.Tables.Remove(dRow("CREFFW").ToString().Trim() + strPedido)
                End If

                dRow.Delete()
            Next

            dgBultosStock.Update()
            dgBultos.Update()

            PCalcularCantidadAtender()

            If dgBultos.Rows.Count > 0 Then
                dgBultos.Rows(0).Selected = True
            End If


            FormatoCantidadAtender()

        End If
        '' '' ''Catch ex As Exception

        '' '' ''    Throw New Exception(ex.Message)

        '' '' ''End Try

    End Sub


    Function fValidarBultosEnPedido() As Boolean

        'Dim valida As Boolean = True
        Dim nroPedido As String
        Dim codBulto As String
        Dim codMaterial As String
        Dim drDetPed() As DataRow
        Dim mensajeValidacion As String
        Dim lstNoExisteMaterial As New List(Of String)
        Dim lstMensajesValidacion As New List(Of String)
        For Each row As DataGridViewRow In dgCabPedidoTraslado.Rows
            nroPedido = row.Cells.Item("M_NRPDTS").Value.ToString().Trim()
            'DsDetallePedido
            If Not DsBulto.Tables(nroPedido) Is Nothing Then
                For Each dtB As DataRow In DsBulto.Tables(nroPedido).Rows
                    If dtB.RowState <> DataRowState.Deleted Then
                        codBulto = dtB.Item("CREFFW").ToString().Trim()
                        'pedido = row.Cells.Item("M_NRPDTS").Value.ToString()
                        For Each dtD As DataRow In DsBultoDetalle.Tables(codBulto + nroPedido).Rows
                            codMaterial = dtD.Item("TCITCL").ToString()
                            drDetPed = DsDetallePedido.Tables(nroPedido).Select("TCITCL = " & codMaterial)

                            If drDetPed.Length = 0 Then
                                lstNoExisteMaterial.Add(codMaterial.Trim())
                            End If
                        Next

                        If lstNoExisteMaterial.Count > 0 Then
                            mensajeValidacion = String.Format("El o los material(es): {0} del bulto: {1}  no existe(n) en el pedido: {2}" & Chr(10), _
                                             String.Join(",", lstNoExisteMaterial.ToArray()), codBulto, nroPedido)

                            lstMensajesValidacion.Add(mensajeValidacion)
                            'MessageBox.Show(mensajeValidacion, "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            'Return False

                        End If
                    End If
                Next
            End If
        Next

        If lstMensajesValidacion.Count > 0 Then

            MessageBox.Show(String.Join(" - ", lstMensajesValidacion.ToArray()), "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If

        Return True

    End Function

    Function fValidarCantidadesMercaderia() As Boolean

        Dim nroPedido As String
        Dim cantidadPendiente As Decimal
        Dim cantidadAtender As Decimal
        Dim mensajeValidacion As String = String.Empty
        Dim lstPrecaucion As New List(Of String)
        Dim lstValidacion As New List(Of String)

        For Each row As DataGridViewRow In dgCabPedidoTraslado.Rows

            nroPedido = row.Cells.Item("M_NRPDTS").Value.ToString()
            For Each drD As DataRow In DsDetallePedido.Tables(nroPedido).Rows

                cantidadPendiente = Convert.ToDecimal(drD.Item("QTYPEN"))
                cantidadAtender = Convert.ToDecimal(drD.Item("QTYATE"))

                If cantidadPendiente < cantidadAtender Then
                    mensajeValidacion = _
                      String.Format("Error, La cantidad Pendiente debe de ser mayor o igual que la cantidad atender del ítem: {0} del pedido de traslado: {1}. ", _
                                drD.Item("NROSEC").ToString(), nroPedido)
                    lstValidacion.Add(mensajeValidacion)
                    'MessageBox.Show(mensajeValidacion, "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Return False
                End If

                If cantidadPendiente > cantidadAtender Then
                    mensajeValidacion = String.Format("Precauciones, La cantidad atender es menor que la cantidad pendiente del ítem: {0} del pedido de traslado: {1}. ¿Desea continuar? ", _
                                                        drD.Item("NROSEC").ToString(), nroPedido)


                    lstPrecaucion.Add(mensajeValidacion & Chr(10))
                End If


            Next

        Next

        If lstValidacion.Count > 0 Then
            MessageBox.Show(String.Join(" - ", lstValidacion.ToArray()), "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If lstPrecaucion.Count > 0 Then
            If MessageBox.Show(String.Join(" - ", lstPrecaucion.ToArray()), "Advertencia : ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub pGenerarPredespacho(ByVal dsBulto As DataSet)

        Dim lstTD_Bultos As List(Of TD_Sel_Bulto_L01) = New List(Of Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
        Dim oWayBill As cWayBill = New Ransa.DAO.WayBill.cWayBill
        Dim strListaBultos As String = ""
        Dim strListadescs As String = ""
        Dim strCadenaPregunta As String = ""
        Dim objBultoTemp As TD_Sel_Bulto_L01

        For Each dt As DataTable In dsBulto.Tables
            For Each oDr As DataRow In dt.Rows
                If oDr.RowState <> DataRowState.Deleted Then
                    objBultoTemp = New Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01
                    objBultoTemp.pCCLNT_CodigoCliente = Val(oDr.Item("CCLNT"))
                    objBultoTemp.pCCMPN_Compania = oDr.Item("CCMPN")
                    objBultoTemp.pCDVSN_Division = oDr.Item("CDVSN")
                    objBultoTemp.pCPLNDV_Planta = oDr.Item("CPLNDV")
                    objBultoTemp.pCREFFW_CodigoBulto = oDr.Item("CREFFW")
                    objBultoTemp.pNSEQIN_NrSecuencia = oDr.Item("NSEQIN")
                    objBultoTemp.pCBLTOR_CodigoBultoOrigen = oDr.Item("CBLTOR")
                    objBultoTemp.pNSEQIO_NrSecuenciaOrigen = oDr.Item("NSEQIO")
                    objBultoTemp.pNROPLT_NroPaletizado = IIf(IsDBNull(oDr.Item("NROPLT")), 0, oDr.Item("NROPLT"))
                    objBultoTemp.pQREFFW_CantidadRecibida = oDr.Item("QREFFW")
                    ' Insertamos el Bulto
                    lstTD_Bultos.Add(objBultoTemp)
                End If
            Next
        Next



        For Each objBultoTemp In lstTD_Bultos
            ' Cadena de Bultos - Siempre habrá código
            If strListaBultos <> "" Then strListaBultos &= ","
            strListaBultos &= "'" & objBultoTemp.pCREFFW_CodigoBulto & "'"
            ' Cadena de Nros de descs - No siempre un bulto esta asociado a una desc
            If objBultoTemp.pNROPLT_NroPaletizado <> 0 Then
                If strListadescs <> "" Then strListadescs &= ","
                strListadescs &= objBultoTemp.pNROPLT_NroPaletizado
            End If
        Next
        If strListadescs <> "" Then
            strCadenaPregunta &= "(*) Existen Bultos que están PALETIZADOS, tener en cuenta que toda " & vbNewLine & _
                  "    la desc será despachada." & vbNewLine & vbNewLine
        End If
        If Not lstTD_Bultos Is Nothing And lstTD_Bultos.Count > 0 Then
            If oWayBill.fintObtener_NroLugares(lstTD_Bultos(0).pCCLNT_CodigoCliente, strListaBultos, strListadescs) > 1 Then
                strCadenaPregunta &= "(*) Existen Bultos que van a Diferentes lugares de Entrega." & vbNewLine & vbNewLine
            End If
        End If
        If oWayBill.ErrorMessage <> "" Then
            'RaiseEvent ErrorMessage(oWayBill.ErrorMessage)
            MessageBox.Show(oWayBill.ErrorMessage, "Pre-Despacho", MessageBoxButtons.OK)
            Exit Sub
        End If
        If strCadenaPregunta <> "" Then
            If MessageBox.Show(strCadenaPregunta & "¿Desea continuar con el Pre-Despacho?", "Pre-Despacho:", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

        End If
        ' Rutina para registrar el PreDespacho y sus respectivos Waybills
        Dim sMessage As String = ""
        Dim nroPredespacho As String = String.Empty
        If mLocalRutime.fblnRegistrarBultosAlPreDespacho(oWayBill, lstTD_Bultos, "", objSeguridadBN.pUsuario, sMessage, nroPredespacho) Then
            lstTD_Bultos.Clear()
            MessageBox.Show(sMessage, "Pre-Despacho:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(sMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub pActualizarBultoPedidoTraslado() 'cambio


        Dim obeBulto As New beBulto
        Dim errGuardado As Boolean
        Dim codidpaq As String

        For Each despacho As DataRow In dtPreDespacho.Rows
            obeBulto = New beBulto()
            obeBulto.PSCCMPN = despacho.Item("IN_CCMPN").ToString()
            obeBulto.PSCDVSN = despacho.Item("IN_CDVSN").ToString()
            obeBulto.PNCPLNDV = despacho.Item("IN_CPLNDV").ToString()
            obeBulto.PNCCLNT = despacho.Item("IN_CCLNT").ToString()
            obeBulto.PSCREFFW = despacho.Item("IN_CREFFW").ToString()
            obeBulto.PNNSEQIN = despacho.Item("IN_NSEQIN").ToString()
            obeBulto.PSCIDPAQ = despacho.Item("IN_CIDPAQ").ToString()
            obeBulto.PSNORCML = despacho.Item("IN_NORCML").ToString()
            obeBulto.PNNRITOC = despacho.Item("IN_NRITOC").ToString()
            obeBulto.PNQBLTSR = despacho.Item("IN_QBLTSR").ToString()
            obeBulto.PSNRPDTS = despacho.Item("IN_NRPDTS").ToString()
            obeBulto.PSNROSEC = despacho.Item("IN_NROSEC").ToString()
            obeBulto.PSUSUARIO = despacho.Item("IN_USUARI").ToString()
            obeBulto.CLARSG = despacho.Item("IN_CLARSG").ToString()
            obeBulto.NROONU = despacho.Item("IN_NROONU").ToString()
            obeBulto.TPOEMB = despacho.Item("IN_TPOEMB").ToString()

            codidpaq = obrBulto.ActualizarDetalleBultoPedidoTraslado(obeBulto)

            If String.IsNullOrEmpty(codidpaq) Then
                errGuardado = True
            End If

        Next

        If (errGuardado = False) Then

            MessageBox.Show("Proceso de Pre-Despacho culminó satisfactoriamente ", "Pre-Despacho:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Error al generar Nro. De Pre-Despacho", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub


    Private Function ActualizarDetalleBultoPorPedido(ByVal nroPedido As String, ByVal drDet As DataRow, ByVal drB As DataRow, ByVal rowDetalleBulto As DataRow, ByVal cantidadPendienteResiduo As Integer) As Boolean

        Dim obeBulto As New beBulto
        Dim errGuardado As Boolean
        Dim codidpaq As String

        obeBulto = New beBulto()

        'bulto
        obeBulto.PSCCMPN = drB.Item("CCMPN").ToString()
        obeBulto.PSCDVSN = drB.Item("CDVSN").ToString()
        obeBulto.PNCPLNDV = Convert.ToDecimal(drB.Item("CPLNDV"))
        obeBulto.PNCCLNT = Convert.ToDecimal(drB.Item("CCLNT"))
        obeBulto.PSCREFFW = drB.Item("CREFFW").ToString()
        obeBulto.PNNSEQIN = Convert.ToDecimal(drB.Item("NSEQIN"))

        'detalle_bulto
        obeBulto.PSCIDPAQ = rowDetalleBulto.Item("CIDPAQ").ToString()
        obeBulto.PSNORCML = rowDetalleBulto.Item("NORCML").ToString()
        obeBulto.PNNRITOC = Convert.ToDecimal(rowDetalleBulto.Item("NRITOC"))
        obeBulto.PNQBLTSR = IIf(cantidadPendienteResiduo = 0, Convert.ToDecimal(rowDetalleBulto.Item("QBLTSR")), cantidadPendienteResiduo)

        'pedido_traslado
        obeBulto.PSNRPDTS = Val(nroPedido)

        'detalle_pedido
        obeBulto.PSNROSEC = Val(drDet.Item("NROSEC"))

        'objSeguridadBN.pUsuario
        obeBulto.PSUSUARIO = objSeguridadBN.pUsuario

        obeBulto.CLARSG = drDet.Item("CLARSG").ToString()
        obeBulto.NROONU = drDet.Item("NROONU").ToString()
        obeBulto.TPOEMB = drDet.Item("TPOEMB").ToString()

        codidpaq = obrBulto.ActualizarDetalleBultoPedidoTraslado(obeBulto)

        If String.IsNullOrEmpty(codidpaq) Then
            errGuardado = True
        End If

        Return errGuardado

    End Function



#End Region
    Private Sub dgDetPedidoTraslado_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim nroPedido As String = dgCabPedidoTraslado.CurrentRow.Cells("M_NRPDTS").Value

        For Each pedido As DataGridViewRow In dgDetPedidoTraslado.Rows
            Dim posicion As String = pedido.Cells("MD_NROSEC").Value

            For Each preDespacho As DataRow In dtPreDespacho.Rows
                If preDespacho.Item("IN_NRPDTS").ToString = nroPedido And preDespacho.Item("IN_NROSEC").ToString = posicion Then
                    preDespacho.Item("IN_CLARSG") = pedido.Cells("MD_CLARSG").Value.ToString() 'Clase de Riesgo
                    preDespacho.Item("IN_NROONU") = pedido.Cells("MD_NROONU").Value.ToString() 'Nro. onu
                    preDespacho.Item("IN_TPOEMB") = pedido.Cells("MD_TPOEMB").Value.ToString() 'Tipo Embalaje del pedido de traslado seleccionado
                End If
            Next
        Next
    End Sub



    Private Sub CrearMatriz(ByVal nroPedido As String, ByVal CCMPN As String, ByVal CDVSN As String, ByVal CPLNDV As String, ByVal CCLNT As String, ByVal CREFFW As String, ByVal CIDPAQ As String, ByVal NSEQIN As String, ByVal NORCML As String, ByVal NRITOC As String, ByVal NROSEC As String, ByVal QTYATE As String, ByVal CLARSG As String, ByVal NROONU As String, ByVal TPOEMB As String, ByVal TCITCL As String) 'cambio
        Dim dataRow As DataRow
        dataRow = dtPreDespacho.NewRow()
        dataRow.Item("IN_CCMPN") = CCMPN 'Compañía
        dataRow.Item("IN_CDVSN") = CDVSN 'División
        dataRow.Item("IN_CPLNDV") = CDec(CPLNDV) 'Planta
        dataRow.Item("IN_CCLNT") = CDec(CCLNT) 'Cód. Cliente
        dataRow.Item("IN_CREFFW") = CREFFW 'Bulto
        dataRow.Item("IN_CIDPAQ") = CIDPAQ 'Cód. Identificación de paquete
        dataRow.Item("IN_NSEQIN") = NSEQIN 'Nro. Secuencia
        dataRow.Item("IN_NORCML") = NORCML 'Nro. OC
        dataRow.Item("IN_NRITOC") = CDec(NRITOC) 'Nro. Ítem
        dataRow.Item("IN_NRPDTS") = nroPedido 'Número de Pedido de traslado
        dataRow.Item("IN_NROSEC") = NROSEC 'Nro. Ítem del Pedido de traslado
        dataRow.Item("IN_QBLTSR") = QTYATE 'Saldo cantidad bulto
        dataRow.Item("IN_CLARSG") = CLARSG 'Clase de Riesgo
        dataRow.Item("IN_NROONU") = NROONU 'Nro. onu
        dataRow.Item("IN_TPOEMB") = TPOEMB 'Tipo Embalaje del pedido de traslado seleccionado
        dataRow.Item("IN_USUARI") = objSeguridadBN.pUsuario 'Usuario del sistema
        dataRow.Item("CodigoMaterial") = TCITCL
        dtPreDespacho.Rows.Add(dataRow)
    End Sub


    Private Sub dgCabPedidoTraslado_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCabPedidoTraslado.CurrentCellChanged
        pCargarBultoStock()
        'pCargarDetalleBulto()
        pCargarDetallePedido()

        If dgBultos.Rows.Count > 0 Then
            dgBultos.DataSource = Nothing
        End If

        If dgBultoDetalle.Rows.Count > 0 Then
            dgBultoDetalle.DataSource = Nothing
        End If

        pCargarBulto()
        FormatoCantidadAtender()
    End Sub

    Private Sub dgDetPedidoTraslado_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDetPedidoTraslado.CurrentCellChanged

        'If dgDetPedidoTraslado.CurrentCell.ColumnIndex = 15 Or dgDetPedidoTraslado.CurrentCell.ColumnIndex = 16 Or dgDetPedidoTraslado.CurrentCell.ColumnIndex = 17 Then
        'dgDetPedidoTraslado.EndEdit()
        dgDetPedidoTraslado.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
        'End If
    End Sub

    Private Sub dgBultos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgBultos.CurrentCellChanged
        Call pCargarDetalleBulto()
    End Sub

    Private Sub TsbEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbEliminar.Click
        pEliminarItemBulto()
    End Sub

    Private Sub TsbAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbAgregar.Click


        Dim dRow As DataRow
        Dim dtBultoStock As New DataTable
        Dim dtBultoDetalleStock As New DataTable
        Dim dtBulto As New DataTable
        Dim dtBultoDetalle As New DataTable
        Dim strNombreDt As String
        Dim strPedido As String
        dtBultoStock = dgBultosStock.DataSource
        dtBulto = dtBultoStock.Clone()
        strNombreDt = dtBulto.TableName()
        strPedido = dgCabPedidoTraslado.CurrentRow.Cells("M_NRPDTS").Value.ToString().Trim()



        For Each selRow As DataGridViewRow In dgBultosStock.SelectedRows

            If DsBulto.Tables(strNombreDt) Is Nothing Then
                dRow = CType(selRow.DataBoundItem, DataRowView).Row()
                If Not lstBultosAgregados.Contains(dRow("CREFFW").ToString()) Then

                    'EGL - HUNDRED
                    If Not ValidarCantidadPendiente(dRow("CREFFW").ToString(), strPedido) Then
                        Exit Sub
                    End If

                    dtBultoDetalleStock = DsBultoDetalleStock.Tables(dRow("CREFFW").ToString().Trim() + strPedido)
                    dtBultoDetalle = dtBultoDetalleStock.Copy()
                    dtBulto.ImportRow(dRow)
                    lstBultosAgregados.Add(dRow("CREFFW").ToString())
                    dRow.Delete()
                    DsBultoDetalle.Tables.Add(dtBultoDetalle)
                    DsBulto.Tables.Add(dtBulto)
                Else
                    MessageBox.Show("No se puede agregar el bulto porque ya se encuentra asignado a otro pedido.", "Pre-Despacho: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                dRow = CType(selRow.DataBoundItem, DataRowView).Row()
                If Not lstBultosAgregados.Contains(dRow("CREFFW").ToString()) Then

                    'EGL - HUNDRED
                    If Not ValidarCantidadPendiente(dRow("CREFFW").ToString(), strPedido) Then
                        Exit Sub
                    End If

                    DsBulto.Tables(strNombreDt).ImportRow(dRow)
                    dtBultoDetalleStock = DsBultoDetalleStock.Tables(dRow("CREFFW").ToString().Trim() + strPedido)
                    dtBultoDetalle = dtBultoDetalleStock.Copy()
                    lstBultosAgregados.Add(dRow("CREFFW").ToString())
                    dRow.Delete()
                    DsBultoDetalle.Tables.Add(dtBultoDetalle)
                Else
                    MessageBox.Show("No se puede agregar el bulto porque ya se encuentra asignado a otro pedido.", "Pre-Despacho: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Next




        dgBultosStock.Update()
        dgBultoDetalleStock.Update()
        dgBultos.DataSource = DsBulto.Tables(strNombreDt)
        dgBultoDetalle.DataSource = dtBultoDetalle
        PCalcularCantidadAtender()
        FormatoCantidadAtender()

        If dgBultos.Rows.Count > 0 Then
            dgBultos.Rows(0).Selected = True
            Call pCargarDetalleBulto()
        End If
    End Sub

    Private Sub dgBultosStock_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgBultosStock.CurrentCellChanged
        'Dim obeBulto As New beBulto

        'With obeBulto
        '    .PSCCMPN = dgCabPedidoTraslado.CurrentRow.Cells("MB_CCMPN").Value.ToString()
        '    .PSCDVSN = dgCabPedidoTraslado.CurrentRow.Cells("MB_CDVSN").Value.ToString()
        '    .PNCPLNDV = dgCabPedidoTraslado.CurrentRow.Cells("MB_CPLNDV").Value.ToString()
        '    .PNCCLNT = dgCabPedidoTraslado.CurrentRow.Cells("MB_CCLNT").Value.ToString()
        '    .PSCREFFW = dgCabPedidoTraslado.CurrentRow.Cells("MB_CREFFW").Value.ToString()
        '    .PNNSEQIN = dgCabPedidoTraslado.CurrentRow.Cells("MB_NSEQIN").Value.ToString()
        'End With
        'dgBultoDetalle.AutoGenerateColumns = False
        'dgBultoDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
        Call pCargarDetalleBultoStock()
    End Sub
End Class

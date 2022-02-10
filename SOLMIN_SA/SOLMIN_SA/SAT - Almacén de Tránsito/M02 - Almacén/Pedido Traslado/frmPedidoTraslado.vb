Imports RANSA.NEGO
Imports Ransa.TypeDef.Cliente
Imports RANSA.TYPEDEF
''' <summary>
''' Dagnino 09/25/2015
''' </summary>
''' <remarks></remarks>
Public Class frmPedidoTraslado
    Private obrDespacho As New brDespacho

    Private Sub ButtonSpecHeaderGroup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup2.Click
        Me.Close()
    End Sub

    Private Sub frmPedidoTraslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Listar_Compania()
        CargarClientes()
        CargarEstados()

        dteFechaFinal.Value = DateTime.Now
        dteFechaFinal.Value = DateTime.Now
    End Sub

    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    'Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
    '    UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
    '    UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
    '    UcDivision_Cmb011.pActualizar()
    'End Sub
    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    'Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
    '    UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
    '    UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
    '    UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
    '    UcPLanta_Cmb011.pActualizar()
    'End Sub
    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub
    Private Sub CargarEstados()

        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("P", "Pendiente")
        comboSource.Add("A", "Atendido")
        comboSource.Add("T", "Todos")

        cboEstado.DataSource = New BindingSource(comboSource, Nothing)
        cboEstado.DisplayMember = "Value"
        cboEstado.ValueMember = "Key"

        cboEstado.SelectedValue = "P"

    End Sub
    Private Function fObtenerParametrosPedido() As beDespacho

        Dim obeDespacho As New beDespacho

        obeDespacho.PNCCLNT = txtCliente.pCodigo
        obeDespacho.PNFECINI = RANSA.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value.Date)
        obeDespacho.PNFECFIN = RANSA.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value.Date)
        obeDespacho.PNNRPDTS = Val(txtNroPedidoTraslado.Text)
        obeDespacho.PSSESPRC = cboEstado.SelectedValue.ToString()
        obeDespacho.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        obeDespacho.PSCDVSN = UcDivision_Cmb011.Division
        obeDespacho.PNCPLNDV = UcPLanta_Cmb011.Planta
        Return obeDespacho

    End Function

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim dt As New DataTable

        dt = obrDespacho.fdtListaPedidoTraslado(fObtenerParametrosPedido())
        dgCabPedido.DataSource = dt

    End Sub

    Private Sub dgCabPedido_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCabPedido.CellContentClick

        If e.RowIndex = -1 Then Exit Sub

        Dim indexRow, columnIndex As Integer
        indexRow = e.RowIndex
        columnIndex = e.ColumnIndex



        If columnIndex = 0 Then
            Dim estado As String
            estado = dgCabPedido.Rows(indexRow).Cells("M_TDSDES").Value.ToString().Trim().ToUpper()

            If estado = "ATENDIDO" Then

                MessageBox.Show("No puede seleccionar un pedido de traslado con estado ATENDIDO", "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
        End If
        With dgCabPedido
            If .RowCount > 0 Then
                If e.ColumnIndex = 0 Then
                    If .CurrentCell.Value Then
                        .CurrentCell.Value = False
                    Else
                        .CurrentCell.Value = True
                    End If
                End If
            End If
        End With


    End Sub

    

    Private Sub dgCabPedido_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCabPedido.CurrentCellChanged

        Dim codCliente As Integer
        Dim nroPedido As Int64
        Dim obeDespacho As New beDespacho
        Dim dt As New DataTable
        With dgCabPedido
            If .RowCount > 0 Then
                If Not .CurrentRow Is Nothing Then
                    codCliente = Val(.CurrentRow.Cells("M_CCLNT").Value)
                    nroPedido = Val(.CurrentRow.Cells("M_NRPDTS").Value)

                    obeDespacho.PNCCLNT = codCliente
                    obeDespacho.PNNRPDTS = nroPedido

                    dt = obrDespacho.fdtListaDetallePedidoTraslado(obeDespacho)
                Else
                    codCliente = Val(.Rows(0).Cells("M_CCLNT").Value)
                    nroPedido = Val(.Rows(0).Cells("M_NRPDTS").Value)

                    obeDespacho.PNCCLNT = codCliente
                    obeDespacho.PNNRPDTS = nroPedido

                    dt = obrDespacho.fdtListaDetallePedidoTraslado(obeDespacho)
                End If

                dgDetInventario.DataSource = dt
            End If
        End With
    End Sub

  
    Private Sub ToolStripButtonAtender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAtender.Click

        Dim pedidosCheck As Integer
        Dim obeDespacho As beDespacho
        Dim lstDespacho As New List(Of beDespacho)


        For Each row As DataGridViewRow In dgCabPedido.Rows
            If row.Cells("M_CHK").Value = True Then
                pedidosCheck = pedidosCheck + 1
                obeDespacho = New beDespacho()

                obeDespacho.PNCCLNT = Convert.ToDecimal(row.Cells("M_CCLNT").Value)
                obeDespacho.PNFECINI = RANSA.Utilitario.HelpClass.CFecha_a_Numero8Digitos(row.Cells("M_FECPED").Value)
                obeDespacho.PNFECFIN = RANSA.Utilitario.HelpClass.CFecha_a_Numero8Digitos(row.Cells("M_FECPED").Value)
                obeDespacho.PNNRPDTS = Convert.ToDecimal(row.Cells("M_NRPDTS").Value)
                obeDespacho.PSSESPRC = row.Cells("M_SESPRC").Value.ToString()
                obeDespacho.PSCCMPN = row.Cells("M_CCMPN").Value.ToString()
                obeDespacho.PSCDVSN = row.Cells("M_CDVSN").Value.ToString()
                obeDespacho.PNCPLNDV = Convert.ToDecimal(row.Cells("M_CPLNDV").Value)

                lstDespacho.Add(obeDespacho)
            End If
        Next

        If pedidosCheck > 0 Then

            With frmGenerarPreDespachoPorPedidoTraslado
                .lstbeDespacho = lstDespacho
                '.Text &= "Modificar"
                '.pEstado = ""
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    .Dispose()
                    frmGenerarPreDespachoPorPedidoTraslado = Nothing

                    Dim dt As New DataTable

                    dt = obrDespacho.fdtListaPedidoTraslado(fObtenerParametrosPedido())
                    dgCabPedido.DataSource = dt
                    'Call pListarItemsBultos(dgBultos.pBultoSeleccionado)
                Else ' cancela la operacion
                    .Dispose()
                    frmGenerarPreDespachoPorPedidoTraslado = Nothing
                End If
            End With

        End If
    End Sub
End Class
'Imports RANSA.TypeDef.Cliente
Imports Ransa.NEGO
Imports ransa.TypeDef
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.Utilitario

Public Class frmPedidosPorClienteSDS


    Dim objListado As New List(Of beObservacionPedido)
    Dim objObsPedido As New Hashtable

#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region

#Region " Atributos "
    Private booStatus As Boolean = False
    Private pdecOrdenDeServicio As Decimal
    Private pintPkPedido As Integer = 0
#End Region

    Private Sub frmPedidosPorClienteSDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            CargarClientes()
            ' CargarDeposito()
            Me.TabControl1.SelectedIndex = 1
            UcPaginacionListaPedido.PageSize = 5
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
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

    'Private Sub CargarDeposito()
    '    Dim oDt As New DataTable

    '    'Agregamos las columnas
    '    oDt.Columns.Add("COD")
    '    oDt.Columns.Add("NOM")
    '    Dim oDr As DataRow

    '    oDr = oDt.NewRow
    '    oDr.Item(0) = "1"
    '    oDr.Item(1) = "Frio"
    '    oDt.Rows.Add(oDr)

    '    oDr = oDt.NewRow
    '    oDr.Item(0) = "3"
    '    oDr.Item(1) = "Seco"

    '    oDt.Rows.Add(oDr)
    '    cmbDeposito.DataSource = oDt
    '    cmbDeposito.DisplayMember = "NOM"
    '    cmbDeposito.ValueMember = "COD"
    'End Sub

    'Private Sub CargarDespacho()
    '    Dim oDt As New DataTable

    '    'Agregamos las columnas
    '    oDt.Columns.Add("COD")
    '    oDt.Columns.Add("NOM")
    '    Dim oDr As DataRow

    '    oDr = oDt.NewRow
    '    oDr.Item(0) = "P"
    '    oDr.Item(1) = "Propio"
    '    oDt.Rows.Add(oDr)

    '    oDr = oDt.NewRow
    '    oDr.Item(0) = "T"
    '    oDr.Item(1) = "Tercero"

    '    oDt.Rows.Add(oDr)
    '    cmbDeposito.DataSource = oDt
    '    cmbDeposito.DisplayMember = "NOM"
    '    cmbDeposito.ValueMember = "COD"
    'End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnRealizarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedido.Click
        Try
            SelecionarMercaderia()
            Me.TabControl1.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
    End Sub

    Private Sub SelecionarMercaderia()
        If Me.dgMercaderias.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim oDr As DataGridViewRow
        Dim FilaReg As Int64 = 0

        'For Each oDrMercaderia As DataGridViewRow In Me.dgMercaderias.Rows
        '    If oDrMercaderia.Cells("CHK").Value Then

        '        If oDrMercaderia.Cells("PNCANT_OS").Value > 1 Then

        '        End If

        '    End If
        'Next
        Dim msgValidacionOS As String = ""
        For Each oDrMercaderia As DataGridViewRow In Me.dgMercaderias.Rows
            If oDrMercaderia.Cells("CHK").Value Then

                If oDrMercaderia.Cells("PNCANT_OS").Value > 1 Then
                    msgValidacionOS = " SKU " & oDrMercaderia.Cells("M_CMRCLR").Value & " está relacionado a más de 1 OS." & Chr(13)
                    Continue For
                End If

                oDr = New DataGridViewRow
                oDr.CreateCells(dgMercaderiaSeleccionada)
                Me.dgMercaderiaSeleccionada.Rows.Add(oDr)
                FilaReg = dgMercaderiaSeleccionada.Rows.Count - 1
                'If ExisteRegistradoEnPedido(oDrMercaderia.Cells("PNNORDSR").Value) Then
                '    oDrMercaderia.Cells("CHK").Value = False
                'Else
                With oDr
                    '.Cells(0).Value = oDrMercaderia.Cells("M_CMRCLR").Value
                    '.Cells(1).Value = oDrMercaderia.Cells("M_TMRCD2").Value
                    '.Cells(2).Value = oDrMercaderia.Cells("M_CMRCD").Value
                    '.Cells(3).Value = oDrMercaderia.Cells("PNNORDSR").Value
                    '.Cells(4).Value = oDrMercaderia.Cells("M_SALDO").Value
                    '.Cells(5).Value = ""
                    '.Cells(6).Value = 0D
                    '.Cells(7).Value = oDrMercaderia.Cells("PSCUNCN5").Value
                    '.Cells(8).Value = 0D
                    '.Cells(9).Value = oDrMercaderia.Cells("PSCUNPS5").Value
                    '.Cells(11).Value = pintPkPedido
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("CMRCLR").Value = oDrMercaderia.Cells("M_CMRCLR").Value
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("TMRCD2").Value = oDrMercaderia.Cells("M_TMRCD2").Value
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("CMRCD").Value = oDrMercaderia.Cells("M_CMRCD").Value
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("NORDSR1").Value = oDrMercaderia.Cells("PNNORDSR").Value
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("PNSALDO").Value = oDrMercaderia.Cells("M_SALDO").Value
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("TCTCST").Value = ""
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("QSRVC").Value = 0D
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("CUNCN6").Value = oDrMercaderia.Cells("PSCUNCN5").Value
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("PSRVC").Value = 0D
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("CUNPS6").Value = oDrMercaderia.Cells("PSCUNPS5").Value
                    dgMercaderiaSeleccionada.Rows(FilaReg).Cells("PK").Value = pintPkPedido

                End With
                pintPkPedido = pintPkPedido + 1
                'Me.dgMercaderiaSeleccionada.Rows.Add(oDr)
                oDrMercaderia.Cells("CHK").Value = False
                'End If
                Me.dgMercaderias.EndEdit()
            End If
        Next

        msgValidacionOS = msgValidacionOS.Trim
        If msgValidacionOS.Length > 0 Then
            MessageBox.Show("Los sigientes SKU no han sido seleccionados:" & Chr(13) & msgValidacionOS, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Function ExisteRegistradoEnPedido(ByVal dblOrdenDeServicio As String) As Boolean
        For Each oDr As DataGridViewRow In Me.dgMercaderiaSeleccionada.Rows
            If oDr.Cells("NORDSR1").Value = dblOrdenDeServicio Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            pActualizarInformacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LimpiarGrilla()
        Me.dgMercaderias.DataSource = Nothing
        dgMercaderias.Rows.Clear()
        Me.dtgKardex.DataSource = Nothing
        dtgKardex.Rows.Clear()
        Me.dgMercaderiaSeleccionada.DataSource = Nothing
        dgMercaderiaSeleccionada.Rows.Clear()
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.PageNumber = 1
    End Sub

    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.pCodigo = 0 Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub pActualizarInformacion()
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            dgMercaderias.AutoGenerateColumns = False
            Dim obrMercaderia As New brMercaderia
            Dim obeMercaderia As New beMercaderia
            With obeMercaderia
                .PNCCLNT = txtCliente.pCodigo
                .PageSize = Me.UcPaginacion.PageSize
                .PageNumber = Me.UcPaginacion.PageNumber
                .PSCMRCLR = txtFiltroMercaderia.Text
            End With

            dgMercaderias.DataSource = obrMercaderia.ListarMercaderiaPorCliente(obeMercaderia)
            If TryCast(dgMercaderias.DataSource, List(Of beMercaderia)).Count > 0 Then
                UcPaginacion.PageCount = TryCast(dgMercaderias.DataSource, List(Of beMercaderia)).Item(0).PageCount
            End If
        End If
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Me.pActualizarInformacion()
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerKardex.Click
        Try
            pOcultarInformacionCabecera(btnVerKardex.Visible)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub pOcultarInformacionCabecera(ByVal blnStatus As Boolean)
        If blnStatus Then
            btnVerKardex.Text = "Visualizar"
        Else
            btnVerKardex.Text = "Ocultar"
        End If
        btnVerKardex.Visible = Not btnVerKardex.Visible
    End Sub

    Private Function Validar() As Boolean
        For Each DrMercaderias As DataGridViewRow In Me.dgMercaderias.Rows
            If DrMercaderias.Cells("CHK").Value Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub txtCliente_TextChanged() Handles txtCliente.TextChanged
        Me.LimpiarGrilla()
    End Sub


    Private Sub dgMercaderias_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderias.CellContentClick
        Try
            If e.RowIndex = -1 Then Exit Sub
            If e.ColumnIndex = 0 Then
                dgMercaderias.CurrentRow.Cells(0).Value = Not dgMercaderias.CurrentRow.Cells(0).Value
                Me.dgMercaderias.EndEdit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub SeleccionarKardex(ByVal decOrdenDeServicio As Decimal)
        If Me.dgMercaderias.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        With obeMercaderia
            .PNNORDSR = decOrdenDeServicio
        End With
        dtgKardex.AutoGenerateColumns = False
        Me.dtgKardex.DataSource = Nothing
        Me.dtgKardex.DataSource = obrMercaderia.ListaKardex(obeMercaderia)
    End Sub


    Private Sub btnProcesarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarPedido.Click
        Try
            If Me.dgMercaderiaSeleccionada.Rows.Count = 0 Then Exit Sub
            Me.dgMercaderiaSeleccionada.EndEdit()
            If ValidarPedidos() Then
                Dim ofrmProductoPedido As New frmProductoPedido
                With ofrmProductoPedido
                    .CodCliente = Me.txtCliente.pCodigo
                    .pobeMercaderia = CType(dgMercaderias.CurrentRow.DataBoundItem, beMercaderia)
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        GuardarPedido(.obePedidoPorPlanta)
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Function ValidarPedidos() As Double
        Dim strMensajeError As String = "Debe ingresar" & Convert.ToChar(13)
        Dim blnEstado As Boolean = True
        Dim intNumRow As Integer = 0
        For Each oDr As DataGridViewRow In Me.dgMercaderiaSeleccionada.Rows
            If oDr.Cells("QSRVC").Value Is Nothing OrElse Not IsNumeric(oDr.Cells("QSRVC").Value) OrElse Val(oDr.Cells("QSRVC").Value) = 0 Then
                strMensajeError &= "- Cantidad Valido." & Convert.ToChar(10) & Convert.ToChar(13)
            End If
            If oDr.Cells("PSRVC").Value Is Nothing OrElse Not IsNumeric(oDr.Cells("PSRVC").Value) Then
                strMensajeError &= "- Debe ingresar Peso Valido." & Convert.ToChar(10) & Convert.ToChar(13)
            End If
            If strMensajeError.Length > 14 Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgMercaderiaSeleccionada.Rows(intNumRow).Cells("QSRVC").ErrorText = strMensajeError
                blnEstado = False
                Exit Function
            Else
                dgMercaderiaSeleccionada.Rows(intNumRow).ErrorText = ""
            End If
            intNumRow += 1
        Next
        Return blnEstado
    End Function

    Private Sub GuardarPedido(ByVal pobePedidoPlanta As bePedidoPorPlanta)
        Dim obePedidoPlanta As New bePedidoPorPlanta
        Dim olbePedidoPlanta As New List(Of bePedidoPorPlanta)
        Dim obrPedidoPlanta As New brDespacho
        Dim intRow As Integer = 1
        For Each oDrMercaderia As DataGridViewRow In Me.dgMercaderiaSeleccionada.Rows
            obePedidoPlanta = New bePedidoPorPlanta
            With obePedidoPlanta
                .PNCDREGP = intRow
                .PNNORDSR = oDrMercaderia.Cells("NORDSR1").Value
                .PSCMRCLR = oDrMercaderia.Cells("CMRCLR").Value
                .PNFCHSPE = HelpClass.CDate_a_Numero8Digitos(Now)
                .PNHRASPE = HelpClass.NowNumeric
                .PNCCLNT = Me.txtCliente.pCodigo
                .PNCPLNCL = pobePedidoPlanta.PNCPLNCL
                .PNCPRVCL = pobePedidoPlanta.PNCPRVCL
                .PNCPLCLP = pobePedidoPlanta.PNCPLCLP
                .PNQSRVC = oDrMercaderia.Cells("QSRVC").Value
                .PSCUNCN6 = oDrMercaderia.Cells("CUNCN6").Value
                .PNPSRVC = oDrMercaderia.Cells("PSRVC").Value
                .PSCUNPS6 = oDrMercaderia.Cells("CUNPS6").Value
                .PSNRFTPD = pobePedidoPlanta.PSNRFTPD
                .PNNDCFCC = pobePedidoPlanta.PNNDCFCC
                .PSSATSLS = "P"
                .PSSATNAL = "P"
                .PSTCTCST = oDrMercaderia.Cells("TCTCST").Value
                .PSNRFRPD = pobePedidoPlanta.PSNRFRPD
                .PSFLGAPR = ""
                .PSFLGURG = ""
                .PSSBCKRD = ""
                .PSNORCML = pobePedidoPlanta.PSNORCML
                .PNFDSPAL = pobePedidoPlanta.PNFDSPAL
                .PSTOBSMD = pobePedidoPlanta.PSTOBSMD
                .PNNRITOC = intRow
                .PSNLTECL = ""
                .PNNROSEQ = 0
                .PNFULTAC = HelpClass.CDate_a_Numero8Digitos(Now)
                .PNHULTAC = HelpClass.NowNumeric
                .PSCULUSA = objSeguridadBN.pUsuario
                .PNFCHCRT = HelpClass.CDate_a_Numero8Digitos(Now)
                .PNHRACRT = HelpClass.NowNumeric
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PSSESTRG = "A"

                If objObsPedido.Count > 0 Then
                    If objObsPedido(oDrMercaderia.Cells("PK").Value) IsNot Nothing Then
                        For i As Integer = 0 To Me.objObsPedido(oDrMercaderia.Cells("PK").Value).Count - 1
                            CType(objObsPedido(oDrMercaderia.Cells("PK").Value), List(Of beObservacionPedido)).Item(i).PNNCRRLT = "0"
                            CType(objObsPedido(oDrMercaderia.Cells("PK").Value), List(Of beObservacionPedido)).Item(i).PNCDREGP = intRow
                        Next
                    End If

                End If
               

                intRow = intRow + 1
            End With
            olbePedidoPlanta.Add(obePedidoPlanta)
   
        Next

        Dim intResultado As Double = 0
        intResultado = obrPedidoPlanta.GuardarPedidoPlanta(olbePedidoPlanta)
        If intResultado <> 0 Then
            Me.dgMercaderiaSeleccionada.Rows.Clear()
            HelpClass.MsgBox("Se ha creado el Pedido N° " & intResultado, MessageBoxIcon.Information)
            Dim objObservaciones As New brObservacionesPedido
            For Each obelisObj As List(Of beObservacionPedido) In objObsPedido.Values
                If obelisObj IsNot Nothing Then
                    For Each obeObj As beObservacionPedido In obelisObj
                        obeObj.PNCDPEPL = intResultado
                        obeObj.PSUSUARIO = objSeguridadBN.pUsuario
                    Next
                    objObservaciones.fintRegistrarObeservaciones(obelisObj)
                End If

            Next
            objObsPedido.Clear()
            pActualizarInformacion()

        Else
            HelpClass.ErrorMsgBox()
        End If
    End Sub



    Private Sub dgMercaderias_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgMercaderias.SelectionChanged
        Try
            If Me.dgMercaderias.CurrentCellAddress.Y < 0 Then Exit Sub
            SeleccionarKardex(Me.dgMercaderias.CurrentRow.Cells("PNNORDSR").Value)
            UcPaginacionListaPedido.PageNumber = 1
            pdecOrdenDeServicio = Me.dgMercaderias.CurrentRow.Cells("PNNORDSR").Value
            ListaPedidoPorOrdenDeCompra()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub ListaPedidoPorOrdenDeCompra()
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        With obeMercaderia
            .PNNORDSR = pdecOrdenDeServicio
            .PNCCLNT = Me.txtCliente.pCodigo
            .PageCount = UcPaginacionListaPedido.PageCount
            .PageNumber = UcPaginacionListaPedido.PageNumber
            .PageSize = UcPaginacionListaPedido.PageSize
        End With
        dtgListaPedidosPendientes.AutoGenerateColumns = False
        Me.dtgListaPedidosPendientes.DataSource = Nothing
        Me.dtgListaPedidosPendientes.DataSource = obrMercaderia.ListaPedidoPorOrdenDeCompra(obeMercaderia)

        If TryCast(dtgListaPedidosPendientes.DataSource, List(Of beMercaderia)).Count > 0 Then
            UcPaginacionListaPedido.PageCount = TryCast(dtgListaPedidosPendientes.DataSource, List(Of beMercaderia)).Item(0).PageCount
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            EliminarMercaderiaSeleccionada()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EliminarMercaderiaSeleccionada()
        If Me.dgMercaderiaSeleccionada.CurrentCellAddress.Y < 0 Then Exit Sub
        objObsPedido.Remove(dgMercaderiaSeleccionada.CurrentRow.Cells("PK").Value)

        Me.dgMercaderiaSeleccionada.Rows.RemoveAt(Me.dgMercaderiaSeleccionada.CurrentCellAddress.Y)
    End Sub


    Private Sub txtFiltroMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroMercaderia.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.txtFiltroMercaderia.Text.Trim.Equals("") Then
                Me.UcPaginacion.PageNumber = 1
            End If
            pActualizarInformacion()
        End If
    End Sub


    Private Sub dgMercaderiaSeleccionada_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgMercaderiaSeleccionada.CellValidating
        With dgMercaderiaSeleccionada
            Select Case .Columns(e.ColumnIndex).Name
                Case "QSRVC"
                    If Not IsNumeric(e.FormattedValue) OrElse e.FormattedValue.ToString = "0" Then
                        e.Cancel = True
                    Else
                        dgMercaderiaSeleccionada.CurrentRow.Cells("QSRVC").ErrorText = ""
                    End If
                Case "PSRVC"
                    If Not IsNumeric(e.FormattedValue) OrElse e.FormattedValue.ToString = "0" Then
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Private Sub UcPaginacionListaPedido_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionListaPedido.PageChanged
        ListaPedidoPorOrdenDeCompra()
    End Sub

    Private Sub dgMercaderiaSeleccionada_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderiaSeleccionada.CellContentClick

        Try
            If dgMercaderiaSeleccionada.CurrentCellAddress.Y < 0 Then Exit Sub
            SeleccionarKardex(Me.dgMercaderiaSeleccionada.CurrentRow.Cells("NORDSR1").Value)
            pdecOrdenDeServicio = Me.dgMercaderiaSeleccionada.CurrentRow.Cells("NORDSR1").Value
            ListaPedidoPorOrdenDeCompra()

            If dgMercaderiaSeleccionada.Columns(e.ColumnIndex).Name = "SubObservaciones" Then
                'If e.ColumnIndex = 10 Then
                Dim objfrmObservacionesPedido As New frmObservacionesPedido
                objfrmObservacionesPedido.TipoOperacion = "Nuevo"
                objfrmObservacionesPedido.CodigoMercaderia = Me.dgMercaderiaSeleccionada.CurrentRow.Cells("CMRCLR").Value
                objfrmObservacionesPedido.NombreMercaderia = Me.dgMercaderiaSeleccionada.CurrentRow.Cells("TMRCD2").Value
                objfrmObservacionesPedido.NroPedido = 1
                objfrmObservacionesPedido.NroCorrelativo = Me.dgMercaderiaSeleccionada.CurrentRow.Cells("PK").Value
                objfrmObservacionesPedido.getData = objObsPedido(Me.dgMercaderiaSeleccionada.CurrentRow.Cells("PK").Value)
                objfrmObservacionesPedido.ShowDialog(Me)
                If objObsPedido.ContainsKey(Me.dgMercaderiaSeleccionada.CurrentRow.Cells("PK").Value) Then
                    objObsPedido(Me.dgMercaderiaSeleccionada.CurrentRow.Cells("PK").Value) = objfrmObservacionesPedido.getData
                Else
                    objObsPedido.Add(Me.dgMercaderiaSeleccionada.CurrentRow.Cells("PK").Value, objfrmObservacionesPedido.getData)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnImportarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedido.Click
        Try
            Dim ofrmImportarPedido As New frmImportarPedido()
            ofrmImportarPedido.CCLNT = txtCliente.pCodigo
            If (ofrmImportarPedido.CCLNT = 0) Then
                MessageBox.Show("Debe de seleccionar el Cliente", "Cliente", MessageBoxButtons.OK)
            Else
                ofrmImportarPedido.ShowDialog(Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgMercaderiaSeleccionada_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgMercaderiaSeleccionada.EditingControlShowing
        Dim validar As TextBox = CType(e.Control, TextBox)
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub

    Private Sub validar_Keypress( _
ByVal sender As Object, _
ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = ".") Then
            e.Handled = False
            Return
        End If
        If (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgListaPedidosPendientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaPedidosPendientes.CellClick

        Try
            If dtgListaPedidosPendientes.CurrentCellAddress.Y < 0 Then Exit Sub


            If e.ColumnIndex = 13 Then

                Dim objfrmObservacionesPedido As New frmObservacionesPedido
                objfrmObservacionesPedido.getData = objListado
                objfrmObservacionesPedido.TipoOperacion = "listar"
                objfrmObservacionesPedido.CodigoMercaderia = ""
                objfrmObservacionesPedido.NombreMercaderia = Me.dtgListaPedidosPendientes.CurrentRow.Cells("PSTMRCD2").Value
                objfrmObservacionesPedido.CantidadMercaderia = Me.dtgListaPedidosPendientes.CurrentRow.Cells("PNQSRVC").Value
                objfrmObservacionesPedido.NroPedido = Me.dtgListaPedidosPendientes.CurrentRow.Cells("PNCDPEPL").Value
                objfrmObservacionesPedido.NroCorrelativo = "1"
                objfrmObservacionesPedido.ShowDialog(Me)
                'objListado = objfrmObservacionesPedido.getData

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub
 
    Private Sub dtgListaPedidosPendientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaPedidosPendientes.CellContentClick

    End Sub

    Private Sub dtgKardex_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgKardex.CellContentClick

    End Sub
End Class

Public Class ObservacionPedido

    Private _CDPEPL As String = ""
    Private _CDREGP As String = ""
    Private _CMRCLR As String = ""
    Private _NCRRLT As String = ""
    Private _TOBSGS As String = ""
    Private _FULTAC As String = ""
    Private _HULTAC As String = ""
    Private _CULUSA As String = ""
    Private _SESTRG As String = ""

    Public Property CDPEPL() As String
        Get
            Return _CDPEPL
        End Get
        Set(ByVal value As String)
            _CDPEPL = value
        End Set
    End Property
    Public Property CMRCLR() As String
        Get
            Return _CMRCLR
        End Get
        Set(ByVal value As String)
            _CMRCLR = value
        End Set
    End Property
    Public Property CDREGP() As String
        Get
            Return _CDREGP
        End Get
        Set(ByVal value As String)
            _CDREGP = value
        End Set
    End Property
    Public Property NCRRLT() As String
        Get
            Return _NCRRLT
        End Get
        Set(ByVal value As String)
            _NCRRLT = value
        End Set
    End Property
    Public Property TOBSGS() As String
        Get
            Return _TOBSGS
        End Get
        Set(ByVal value As String)
            _TOBSGS = value
        End Set
    End Property
    Public Property FULTAC() As String
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As String)
            _FULTAC = value
        End Set
    End Property
    Public Property HULTAC() As String
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As String)
            _HULTAC = value
        End Set
    End Property
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

End Class

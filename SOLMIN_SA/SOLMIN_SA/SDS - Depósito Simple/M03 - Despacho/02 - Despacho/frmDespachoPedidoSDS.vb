Imports Ransa.Utilitario
Imports Ransa.NEGO
Imports Ransa.TypeDef
'Imports Ransa.TypeDef.Cliente

Public Class frmDespachoPedidoSDS

#Region "Metodos"
    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
        txtCliente_InformationChanged()
    End Sub

    Private Sub ListaDespachos()
        If Me.txtCliente.pCodigo.ToString.Trim.Equals("0") Then
            Limpiar()
            Exit Sub
        End If
        Dim obeDespacho As New beDespacho
        Dim olbeDespacho As New List(Of beDespacho)
        Dim obrDespacho As New brDespacho
        dtgListaDespachos.AutoGenerateColumns = False

        With obeDespacho
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSCTPDP6 = Me.cmbDeposito.SelectedValue
            .PSNRFRPD = txtRefPedido.Text
            .PSCMRCLR = Me.txtCodMercaderia.Text
            .PSTMRCD2 = Me.txtDesMercaderia.Text
            .PNCDPEPL = Val(Me.txtPedido.Text) ' PEDIDO CLIENTE PLANTA 
        End With
        olbeDespacho = obrDespacho.ListarDespachoPorPedido(obeDespacho)
        dtgListaDespachos.DataSource = olbeDespacho

        If olbeDespacho.Count > 0 Then
            ListaPedidos()
        End If
    End Sub

    Private Sub ListaPedidos()
        If dtgListaDespachos.CurrentCellAddress.Y = -1 Then
            dtgPedidos.DataSource = Nothing
            Exit Sub
        End If
        Dim obrDespacho As New brDespacho
        Dim obeDespacho As New beDespacho
        Dim olbePedidoPorPlanta As New List(Of bePedidoPorPlanta)
        With obeDespacho
            .PNCCLNT = dtgListaDespachos.CurrentRow.Cells("CLIENTE").Value
            .PSCTPDP6 = dtgListaDespachos.CurrentRow.Cells("TIPODEPOSITO").Value
            .PNCPLCLP = dtgListaDespachos.CurrentRow.Cells("PNCCLNT").Value
            .PNCPRVCL = dtgListaDespachos.CurrentRow.Cells("PNCPLNCL").Value
            .PNCDPEPL = Val(Me.txtPedido.Text)
            .PSNRFRPD = Me.txtRefPedido.Text
        End With
        olbePedidoPorPlanta = obrDespacho.ListaPedidoPendientePorCliente(obeDespacho)
        If olbePedidoPorPlanta.Count > 0 Then
            dtgPedidos.AutoGenerateColumns = False
            dtgPedidos.DataSource = olbePedidoPorPlanta
        End If
    End Sub

    Private Sub Limpiar()
        dtgListaDespachos.DataSource = Nothing
        dtgPedidos.DataSource = Nothing
    End Sub

    Private Sub CargarDeposito()
        Dim obrTipoDeDeposito As New brTipoDeDeposito
        cmbDeposito.DataSource = obrTipoDeDeposito.ListarTipoDeDeposito()
        cmbDeposito.DisplayMember = "PSTABDPS"
        cmbDeposito.ValueMember = "PSCTPDPS"
        cmbDeposito.SelectedValue = "1"
    End Sub
#End Region

#Region "Eventos"

    Private Sub frmDespachoPedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            CargarClientes()
            CargarDeposito()
            UCDataGridView.Alinear_Columnas_Grilla(Me.dtgListaDespachos)
            UCDataGridView.Alinear_Columnas_Grilla(Me.dtgPedidos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            ListaDespachos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub dtgListaDespachos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgListaDespachos.CurrentCellChanged
        Try
            ListaPedidos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgListaDespachos_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgListaDespachos.ColumnHeaderMouseClick
        Try
            If dtgListaDespachos.RowCount = 0 Then Exit Sub
            Dim olbeDespacho As New List(Of beDespacho)
            olbeDespacho = dtgListaDespachos.DataSource
            Dim oucOrdena As UCOrdena(Of beDespacho)
            oucOrdena = New UCOrdena(Of beDespacho)(Me.dtgListaDespachos.Columns(e.ColumnIndex).Name, UCOrdena(Of beDespacho).TipoOrdenacion.Ascendente)
            olbeDespacho.Sort(oucOrdena)
            Me.dtgListaDespachos.DataSource = olbeDespacho
            Me.dtgListaDespachos.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub dtgPedidos_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgPedidos.ColumnHeaderMouseClick

        Try
            If Me.dtgPedidos.RowCount = 0 Then Exit Sub
            Dim olbePedidoPorPlanta As New List(Of bePedidoPorPlanta)
            olbePedidoPorPlanta = dtgPedidos.DataSource
            Dim oucOrdena As UCOrdena(Of bePedidoPorPlanta)
            oucOrdena = New UCOrdena(Of bePedidoPorPlanta)(Me.dtgPedidos.Columns(e.ColumnIndex).Name, UCOrdena(Of bePedidoPorPlanta).TipoOrdenacion.Ascendente)
            olbePedidoPorPlanta.Sort(oucOrdena)
            Me.dtgPedidos.DataSource = olbePedidoPorPlanta
            Me.dtgPedidos.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAtender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtender.Click
        Try
            If Me.dtgPedidos.CurrentCellAddress.Y = -1 Or dtgListaDespachos.CurrentCellAddress.Y = -1 Then Exit Sub
            Atender()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            If Me.dtgPedidos.CurrentCellAddress.Y = -1 Or dtgListaDespachos.CurrentCellAddress.Y = -1 Then Exit Sub
            Anular()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

#End Region
    Private Function Anular() As Boolean
        Dim obrDespacho As New brDespacho
        Dim obePedidoPorPlanta As New bePedidoPorPlanta
        Dim intResultado As Integer
        With obePedidoPorPlanta
            .PNCCLNT = dtgListaDespachos.CurrentRow.Cells("CLIENTE").Value
            .PSCTPDP6 = dtgListaDespachos.CurrentRow.Cells("TIPODEPOSITO").Value
            .PNCPRVCL = dtgListaDespachos.CurrentRow.Cells("PNCCLNT").Value
            .PNCPLCLP = dtgListaDespachos.CurrentRow.Cells("PNCPLNCL").Value
            .PNCDPEPL = dtgPedidos.CurrentRow.Cells("PNCDPEPL").Value
            .PSCULUSA = objSeguridadBN.pUsuario
        End With
        If MessageBox.Show("Desea anular el registro", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            intResultado = obrDespacho.AnularPedidoMercaderiaPorClientePorPlanta(obePedidoPorPlanta)
            If intResultado = 0 Then
                MessageBox.Show("Error al anular", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Registro Anulado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListaDespachos()
            End If
        End If

    End Function


    Private Sub Atender()
        Dim obePedidoPorPlanta As New bePedidoPorPlanta
        With obePedidoPorPlanta
            .PNCCLNT = dtgListaDespachos.CurrentRow.Cells("CLIENTE").Value
            .PSCTPDP6 = dtgListaDespachos.CurrentRow.Cells("TIPODEPOSITO").Value
            .PNCPRVCL = dtgListaDespachos.CurrentRow.Cells("PNCCLNT").Value
            .PNCPLCLP = dtgListaDespachos.CurrentRow.Cells("PNCPLNCL").Value
            .PSTCMPPL = dtgListaDespachos.CurrentRow.Cells("PSTCMPPL").Value
            .PSSTPORL = dtgListaDespachos.CurrentRow.Cells("PSSTPORL").Value
            .PNCDPEPL = dtgPedidos.CurrentRow.Cells("PNCDPEPL").Value
            .PNFCHSPE = dtgPedidos.CurrentRow.Cells("PNFCHSPE").Value
            .PNFDSPAL = dtgPedidos.CurrentRow.Cells("PNFDSPAL").Value
            .PSNRFRPD = dtgPedidos.CurrentRow.Cells("PSNRFRPD").Value
            .PSNRFTPD = dtgPedidos.CurrentRow.Cells("PSNRFTPD").Value
            .PSTOBSMD = dtgPedidos.CurrentRow.Cells("PSTOBSMD").Value
            .PNNDCFCC = dtgPedidos.CurrentRow.Cells("PNNDCFCC").Value
            .PSNORCML = dtgPedidos.CurrentRow.Cells("PSNORCML").Value
        End With
        Dim ofrmDespachoMercaderiaSDS As New frmDespachoMercaderiaSDS(obePedidoPorPlanta, dtgPedidos.CurrentRow.Cells("PSNRFRPD").Value.ToString(), txtCliente.pCodigo)
        If ofrmDespachoMercaderiaSDS.ShowDialog = Windows.Forms.DialogResult.OK Then
            ListaDespachos()
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Me.dtgPedidos.CurrentCellAddress.Y = -1 Or dtgListaDespachos.CurrentCellAddress.Y = -1 Then Exit Sub
            ShowFormSugerenciaPiking(Val(Me.dtgPedidos.CurrentRow.Cells("PNCDPEPL").Value))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Public Sub ShowFormSugerenciaPiking(ByVal CDPEPL_NroPedido As Int64)
        'Try
        Dim frmPrintForm As New PrintForm
        Dim obeSugerenciaMercaderiaGuia As New beSugerenciaMercaderiaGuia()
        Dim oblUbicacionSugeridaMercaderiaGuia As New blUbicacionSugeridaMercaderiaGuia()
        Dim dt As New DataTable()
        Dim orptSugerenciaPiking As New rptSugerenciaPiking()
        dt = oblUbicacionSugeridaMercaderiaGuia.ListarSugerenciaPiking(CDPEPL_NroPedido)
        orptSugerenciaPiking.SetDataSource(dt)
        orptSugerenciaPiking.Refresh()
        orptSugerenciaPiking.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
        orptSugerenciaPiking.SetParameterValue("pPedido", " Nº PEDIDO:" & CDPEPL_NroPedido)
        frmPrintForm.MaximizeBox = True
        frmPrintForm.ShowForm(orptSugerenciaPiking, Me)
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnPendienteDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPendienteDespacho.Click
        Try
            Dim ofrmPendienteDespacho As New frmPendienteDespacho()
            If (txtCliente.pCodigo <> 0) Then
                ofrmPendienteDespacho.CCLNT = txtCliente.pCodigo
                ofrmPendienteDespacho.TCMPCL = Me.txtCliente.pCodigo & " - " & txtCliente.pRazonSocial
                ofrmPendienteDespacho.pUsuario = objSeguridadBN.pUsuario
                ofrmPendienteDespacho.ShowDialog(Me)
            Else
                MessageBox.Show("Seleccione Cliente", "Pendientes Despacho", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgPedidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPedidos.CellContentClick
        Try
            ListaPedidos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImportarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedido.Click

        Try
            If (txtCliente.pCodigo = 0) Then
                MessageBox.Show("Debe de seleccionar el Cliente", "Cliente", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim ofrmImportarPedido As New frmImportarPedidoABB
            ofrmImportarPedido.CodCliente = Me.txtCliente.pCodigo

            If ofrmImportarPedido.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ListaDespachos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub btnImportarPedidoIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoIndividual.Click
        Try
            Dim obrGeneral As New brGeneral
            If txtCliente.pCodigo = 11232 Then
                Dim ofrmImportarPedido As New frmImportarPedido()
                ofrmImportarPedido.CCLNT = txtCliente.pCodigo
                If (ofrmImportarPedido.CCLNT = 0) Then
                    MessageBox.Show("Debe de seleccionar el Cliente", "Cliente", MessageBoxButtons.OK)
                Else
                    ofrmImportarPedido.ShowDialog(Me)
                End If
            ElseIf obrGeneral.bolElClienteEsOutotec(Me.txtCliente.pCodigo) Then
                Dim ofrmImportarPedido As New frmImportarPedidoOutotec()
                ofrmImportarPedido.CCLNT = txtCliente.pCodigo
                If (ofrmImportarPedido.CCLNT = 0) Then
                    MessageBox.Show("Debe de seleccionar el Cliente", "Cliente", MessageBoxButtons.OK)
                Else
                    ofrmImportarPedido.ShowDialog(Me)
                End If
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        Dim obrGeneral As New brGeneral
        'Validamos que el clientes sea Outotec
        If obrGeneral.bolElClienteEsOutotec(Me.txtCliente.pCodigo) Then
            btnImportarPedido.Visible = False
            ToolStripSeparator2.Visible = False
        Else
            btnImportarPedido.Visible = True
            ToolStripSeparator2.Visible = True
        End If

    End Sub

    Private Sub btnImprimirEtiqueta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirEtiqueta.Click
        Try
            If Me.dtgPedidos.CurrentCellAddress.Y = -1 Or dtgListaDespachos.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim lstr_pedido As String = Me.dtgPedidos.CurrentRow.Cells("PNCDPEPL").Value.ToString()

            Dim lst_result As String = InputBox("0 = Horizontal y 1 = Vertical", "Indicar formato", "1")

            If IsNumeric(lst_result) = False Then
                Exit Sub
            End If

            Dim n_tipo As SByte = Convert.ToByte(lst_result)

            Dim objWs As New ws_sync
            Dim lstr_xml As String
            Dim lstr_result As String
            Dim lstr_etiqueta As String
            lstr_xml = "<data><row><cclnt>" & Me.txtCliente.pCodigo & "</cclnt><nguirm>" & lstr_pedido & "</nguirm></row></data>"
            lstr_result = New ws_sync().Etiqueta6x4Outotec("APPDB2", "APPDB2", lstr_xml)
            lstr_etiqueta = ImprimirEtiqueta6x4Outotec(XmlDataParser.XmltoDataSet(lstr_result).Tables(0), n_tipo)
            RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, lstr_etiqueta)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub


    Public Function ImprimirEtiqueta6x4Outotec(ByVal objData As DataTable, ByVal tipo As SByte) As String


        Dim lstrEtiquetaBulto As New List(Of String)
        If objData.Rows.Count = 0 Then
            GoTo ZonaSalida
        End If

        Dim strEtiqueta As String = ""
        Dim oFile As IO.StreamReader

        If tipo = 1 Then 'si es vertical
            oFile = New IO.StreamReader(My.Application.Info.DirectoryPath & "\zebratextfiles\outotec_6x4_version4.out")
        Else
            oFile = New IO.StreamReader(My.Application.Info.DirectoryPath & "\zebratextfiles\etiqueta_6x4_otk_horizontal_2013.prn")
        End If

        While oFile.EndOfStream = False
            strEtiqueta = strEtiqueta + oFile.ReadLine
        End While

        Dim indice As Short = 0

        For indice = 0 To objData.Rows.Count - 1

            strEtiqueta = strEtiqueta.Replace("VBCANT" & indice + 1 & ".", FormatNumber(objData.Rows(indice).Item("QMERCA").ToString().Trim(), 2))
            strEtiqueta = strEtiqueta.Replace("VBCODIGO" & indice + 1 & ".", objData.Rows(indice).Item("CMRCLR").ToString().Trim())
            strEtiqueta = strEtiqueta.Replace("VBDESCRIPCION" & indice + 1 & ".", objData.Rows(indice).Item("DESMERCA").ToString().Trim())
            strEtiqueta = strEtiqueta.Replace("VBUBICA" & indice + 1 & ".", "")
            strEtiqueta = strEtiqueta.Replace("VBNROITEM" & indice + 1 & ".", objData.Rows(indice).Item("NLTECL").ToString().Trim())

        Next

        'Reemplazando variables simples
        strEtiqueta = strEtiqueta.Replace("VBPEDIDO", objData.Rows(0).Item("NRFTPD").ToString().Trim() & "-" & objData.Rows(0).Item("NRFRPD").ToString().Trim())
        strEtiqueta = strEtiqueta.Replace("VBNOMBRECLIENTEDESTINO", objData.Rows(0).Item("TPRVCL").ToString().Trim())
        strEtiqueta = strEtiqueta.Replace("VBNOMBRECLIENTE", objData.Rows(0).Item("DIRENTREGA").ToString().Trim())
        strEtiqueta = strEtiqueta.Replace("VBORDENCOMPRA", objData.Rows(0).Item("TOBSMD").ToString().Trim())
        strEtiqueta = strEtiqueta.Replace("VBCLIENTEORIGEN", objData.Rows(0).Item("TCMPCL").ToString().Trim())
        strEtiqueta = strEtiqueta.Replace("VBDIRECCIONCLIENTEORIGEN", objData.Rows(0).Item("TDRCCB").ToString().Trim())

        If indice <= 20 Then
            For t As Integer = indice To 20
                strEtiqueta = strEtiqueta.Replace("VBCANT" & t & ".", "")
                strEtiqueta = strEtiqueta.Replace("VBCODIGO" & t & ".", "")
                strEtiqueta = strEtiqueta.Replace("VBDESCRIPCION" & t & ".", "")
                strEtiqueta = strEtiqueta.Replace("VBUBICA" & t & ".", "")
                strEtiqueta = strEtiqueta.Replace("VBNROITEM" & t & ".", "")
            Next
        End If

        lstrEtiquetaBulto.Add(strEtiqueta)

zonasalida:
        Return strEtiqueta
    End Function


    Private Sub PedidoInterfazSap()
        If Me.txtCliente.pCodigo > 0 Then
            Using frm As New frmInterfasePedSAP
                frm.CCLNT = txtCliente.pCodigo
                frm.ShowDialog()
            End Using
        Else
            MessageBox.Show("Debe ingresar un cliente válido en la opción de Filtros", "Pedido Interfaz SAP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPedido.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    
    Private Sub btnPedidoInterfazSap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidoInterfazSap.Click
        Try
            PedidoInterfazSap()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Public Class frmResumenMensualAlm


    Private Sub frmResumenMensualAlm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Compania()
    End Sub

    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar

        Dim oRegionVenta As New clsRegionVenta
        Dim oDtRegionVenta As New DataTable

        oRegionVenta.Crea_Lista()
        oDtRegionVenta = oRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        oDtRegionVenta.Columns.Remove("CCMPN")

        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = oDtRegionVenta
        For j As Integer = 0 To Me.cmbRegionVenta.Items.Count - 1
            If cmbRegionVenta.Items.Item(j).Value = "-1" Then
                cmbRegionVenta.SetItemChecked(j, True)
            End If
        Next
    End Sub

    Private Function ListaRegionVentaSeleccionado() As String
        Dim IsTodos As Boolean = False
        Dim Lista As String = ""
        For i As Integer = 0 To cmbRegionVenta.CheckedItems.Count - 1
            If cmbRegionVenta.CheckedItems(i).Value = "-1" Then
                IsTodos = True
                Exit For
            End If
            Lista += cmbRegionVenta.CheckedItems(i).Value & ","
        Next
        If IsTodos = True Then
            Lista = "-1,"
        End If
        If Lista.Trim.Length > 0 Then
            Lista = Lista.Trim.Substring(0, Lista.Trim.Length - 1)
        End If
        Return Lista

    End Function


    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        BucarClienteSOLMIN()
    End Sub


    Private Sub BucarClienteSOLMIN()
        dtgClienteSOLMIN.DataSource = Nothing
        Dim oCliente As New clsCliente
        Dim obeCliente As New Cliente
        With obeCliente
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .LIST_CRGVTA = ListaRegionVentaSeleccionado()
        End With
        dtgClienteSOLMIN.AutoGenerateColumns = False
        dtgClienteSOLMIN.DataSource = oCliente.fodtListaClientesSOLMIN(obeCliente)
    End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If dtgClienteSOLMIN.RowCount > 0 Then
            Dim intCont As Int32 = 0
            While intCont < dtgClienteSOLMIN.RowCount
                dtgClienteSOLMIN.Rows(intCont).Cells("CHK").Value = btnMarcarItems.Checked
                intCont += 1
            End While
        End If
    End Sub


    Private Sub tsmStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmStock.Click
        If validaCliente() = False Then Exit Sub
        Dim ofrmStockAT As New frmStockAT
        ofrmStockAT.pCCMPN = UcCompania.CCMPN_CodigoCompania
        ofrmStockAT.pCodClientes = fstrCodClientesCheck()
        ofrmStockAT.ShowDialog()
    End Sub

    Private Function fstrCodClientesCheck() As String
        Dim strCodCliente As String = String.Empty
        Try
            Me.dtgClienteSOLMIN.EndEdit()
            For intX As Integer = 0 To Me.dtgClienteSOLMIN.RowCount - 1
                If dtgClienteSOLMIN.Rows(intX).Cells("CHK").Value Then
                    strCodCliente = strCodCliente & dtgClienteSOLMIN.Rows(intX).Cells("CCLNT").Value & ","
                End If
            Next
            If strCodCliente.Trim.Length > 0 Then
                strCodCliente = strCodCliente.Trim.Substring(0, strCodCliente.Trim.Length - 1)
            Else
                strCodCliente = ""
            End If
        Catch ex As Exception

        End Try


        Return strCodCliente
    End Function

    Private Sub tsmStockDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmStockDS.Click
        If validaCliente() = False Then Exit Sub
        Dim ofrmStockDS As New frmStockDS
        ofrmStockDS.pCCMPN = UcCompania.CCMPN_CodigoCompania
        ofrmStockDS.pCodClientes = fstrCodClientesCheck()
        ofrmStockDS.ShowDialog()
    End Sub

    Private Sub tsmIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmIngresos.Click
        If validaCliente() = False Then Exit Sub
        Dim ofrmStockDS As New frmMovimientoDS
        ofrmStockDS.pCCMPN = UcCompania.CCMPN_CodigoCompania
        ofrmStockDS.pCodClientes = fstrCodClientesCheck()
        ofrmStockDS.pTipoMov = "RECEPCION"
        ofrmStockDS.ShowDialog()
    End Sub

    Private Sub tsmDespachos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDespachos.Click
        If validaCliente() = False Then Exit Sub
        Dim ofrmStockDS As New frmMovimientoDS
        ofrmStockDS.pCCMPN = UcCompania.CCMPN_CodigoCompania
        ofrmStockDS.pCodClientes = fstrCodClientesCheck()
        ofrmStockDS.pTipoMov = "DESPACHO"
        ofrmStockDS.ShowDialog()
    End Sub

    Private Sub tsmIngresoAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmIngresoAT.Click
        If validaCliente() = False Then Exit Sub
        Dim ofrmMovimientoAT As New frmMovimientoAT
        ofrmMovimientoAT.pCCMPN = UcCompania.CCMPN_CodigoCompania
        ofrmMovimientoAT.pCodClientes = fstrCodClientesCheck()
        ofrmMovimientoAT.pTipoMov = "RECEPCION"
        ofrmMovimientoAT.ShowDialog()
    End Sub

    Private Sub tsmDespachosAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDespachosAT.Click
        If validaCliente() = False Then Exit Sub
        Dim ofrmMovimientoAT As New frmMovimientoAT
        ofrmMovimientoAT.pCCMPN = UcCompania.CCMPN_CodigoCompania
        ofrmMovimientoAT.pCodClientes = fstrCodClientesCheck()
        ofrmMovimientoAT.pTipoMov = "DESPACHO"
        ofrmMovimientoAT.ShowDialog()

    End Sub
    Private Function validaCliente() As Boolean
        If fstrCodClientesCheck() = "" Then
            MessageBox.Show("Debe de seleccionar por lo menos un Cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim olistTitulo As New List(Of String)
        If Me.dtgClienteSOLMIN.Rows.Count = 0 Then Exit Sub

        olistTitulo.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olistTitulo.Add("Región :\n " & Me.cmbRegionVenta.Text)

        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(Me.dtgClienteSOLMIN, Me.Text, olistTitulo)
    End Sub
End Class

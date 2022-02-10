Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Controls.ServicioOperacion.clsRegionVenta_BL

Public Class UCclienteSolmin

#Region "Declaracion de variables"

    Private oCliente As New clsServicio_BL
    Private beCliente As New Servicio_BE
    Private brRegionVenta As clsRegionVenta_BL
    Private _pCompaniaActual As String = ""
    Public Property pCompaniaActual() As String
        Get
            Return _pCompaniaActual
        End Get
        Set(ByVal value As String)
            _pCompaniaActual = value
        End Set
    End Property

    Public Event pListaTarifario(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)

#End Region

#Region "Eventos de Control"

    Public Sub pCargaInicial()
        brRegionVenta = New clsRegionVenta_BL
        brRegionVenta.Crea_Lista()

        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(pCompaniaActual)

    End Sub

    'Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
    '    UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
    '    UcDivision_Cmb011.Usuario = ConfigurationWizard.UserName
    '    UcDivision_Cmb011.pActualizar()
    'End Sub

    Private Sub dtgClientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgClientes.CellDoubleClick
        '    Dim strMensaje As String = String.Empty
        '    Dim psCliente As String = String.Empty
        '    Dim FnVerificacion As String = String.Empty

        If dtgClientes.Columns(e.ColumnIndex).Name = "img" Then
            Dim ofrmConsulta As New frmConsultaLineaCredito
            ofrmConsulta.pCompania = UcCompania.CCMPN_CodigoCompania
            ofrmConsulta.CRGVTA = dtgClientes.CurrentRow.Cells("CRGVTA").Value
            ofrmConsulta.CCLNT = dtgClientes.CurrentRow.Cells("CCLNT").Value
            ofrmConsulta.ShowDialog()

            '        Select Case UcDivision_Cmb011.Division
            '            Case "T"
            '                FnVerificacion = "SOLMIN_ST"
            '            Case "R"
            '                FnVerificacion = "SOLMIN_SA"
            '            Case "S"
            '                FnVerificacion = ""
            ' End Select

            '        psCliente = dtgClientes.CurrentRow.Cells("CCLNT").Value

            '        oCliente.fblnIsLocked(psCliente, FnVerificacion, strMensaje, UcCompania.CCMPN_CodigoCompania, UcDivision_Cmb011.Division, cmbRv.SelectedValue)
            '        MessageBox.Show(strMensaje, "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If dtgClientes.Columns(e.ColumnIndex).Name = "imgTarifa" Then

            RaiseEvent pListaTarifario(dtgClientes)

        End If

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        beCliente.CCLNT = UcCliente_TxtF011.pCodigo
        beCliente.CCMPN = UcCompania.CCMPN_CodigoCompania
        beCliente.CRGVTA = ListaRegionVentaSeleccionado()
        beCliente.NRCTCL = Me.UcClienteGrupo.pCodigoGrupo
        dtgClientes.AutoGenerateColumns = False
        dtgClientes.DataSource = oCliente.ListaClienteSolmin(beCliente)

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ExportarExcel()
    End Sub

    'Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision)

    '    beCliente.CCMPN = UcCompania.CCMPN_CodigoCompania
    '    beCliente.CDVSN = UcDivision_Cmb011.Division
    '    beCliente.PSUSUARIO = ConfigurationWizard.UserName
    '    cmbRv.DataSource = oCliente.ListarRegionVenta(beCliente)
    '    cmbRv.DisplayMember = "CRGVTA"
    '    cmbRv.ValueMember = "CRGVTA"

    'End Sub

#End Region

#Region "Procedimientos y Funciones"

    Private Sub ExportarExcel()
        If dtgClientes.RowCount = 0 Then Exit Sub
        Dim dtg As New DataGridView
        dtg = dtgClientes
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(UcCliente_TxtF011.pCodigo = 0, "TODOS", UcCliente_TxtF011.pCodigo & " - " & UcCliente_TxtF011.pRazonSocial))
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtg, "Listado de Clientes", strlTitulo)
    End Sub

#End Region

    Private Sub UCclienteSolmin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        Dim dtRegionVenta As New DataTable
        dtRegionVenta = brRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = dtRegionVenta
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

    Private Sub btnExportarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oServicioBL As New clsServicio_BL
        Dim oServicioBE As New Servicio_BE
        Dim dt As DataTable
        Dim dsTarifa As New DataSet
        oServicioBE.CCMPN = UcCompania.CCMPN_CodigoCompania
        dt = oServicioBL.ListaTarifaClienteSolmin(oServicioBE)
        dt.TableName = "TARIFAS"
        dsTarifa.Tables.Add(dt)
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Compañia:\n" & UcCompania.CCMPN_Descripcion)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dsTarifa, "Tarifa de Clientes", strlTitulo)
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        ExportarExcel()
    End Sub

    Private Sub ContratosTarifaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContratosTarifaToolStripMenuItem.Click
        Dim oServicioBL As New clsServicio_BL
        Dim oServicioBE As New Servicio_BE
        Dim dt As DataTable
        Dim dsTarifa As New DataSet
        oServicioBE.CCMPN = UcCompania.CCMPN_CodigoCompania
        dt = oServicioBL.ListaTarifaClienteSolmin(oServicioBE)
        dt.TableName = "TARIFAS"
        dsTarifa.Tables.Add(dt)
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Compañia:\n" & UcCompania.CCMPN_Descripcion)
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dsTarifa, "Tarifa de Clientes", strlTitulo)
    End Sub
End Class

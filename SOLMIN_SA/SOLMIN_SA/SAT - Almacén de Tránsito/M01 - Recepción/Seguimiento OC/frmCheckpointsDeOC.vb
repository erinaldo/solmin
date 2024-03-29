Imports Ransa.NEGO
Imports Ransa.Utilitario
Imports Ransa.TYPEDEF




Public Class frmCheckpointsDeOC

#Region "Metodos"

    Public strItem As String = String.Empty
    Private _codClientePrev As Decimal = 0

    Private Sub ListaOrdenDeCompra()
        Dim obrOrdenCompra As New brOrdenDeCompra
        Dim obeOrdenCompra As New beOrdenCompra
        Me.dgOrdenesCompras.AutoGenerateColumns = False
        With obeOrdenCompra
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSNORCML = Me.txtOrdenCompra.Text
            .PNCPRVCL = Me.txtProveedor.pCodigo
            .PSTTINTC = Me.cmbTipoOc.SelectedValue
            .FechaInicioOC = IIf(chkFechaOc.Checked, Me.dteFechaInicial.Value, "")
            .FechaFinOc = IIf(chkFechaOc.Checked, Me.dteFechaFinal.Value, "")
            .PageSize = UcPaginacion2.PageSize
            .PageNumber = UcPaginacion2.PageNumber
        End With
        CargarColumnasDeCheckpointItems()
        Me.dgOrdenesCompras.DataSource = obrOrdenCompra.ListarOrdenDeCompra(obeOrdenCompra)
        If Me.dgOrdenesCompras.RowCount > 0 Then
            Me.UcPaginacion2.PageCount = CType(Me.dgOrdenesCompras.DataSource, List(Of beOrdenCompra)).Item(0).PageCount
        Else
            Me.dgItemOC.DataSource = Nothing
        End If
        UCDataGridView.Alinear_Columnas_Grilla(Me.dgOrdenesCompras)
        UCDataGridView.Alinear_Columnas_Grilla(Me.dgItemOC)
    End Sub

    Private Sub ListarDetalleOc()
        If Me.dgOrdenesCompras.CurrentCellAddress.Y = -1 Then
            Me.dgItemOC.DataSource = Nothing
            Exit Sub
        End If
        Dim obrOrdenCompra As New brOrdenDeCompra
        With CType(Me.dgOrdenesCompras.CurrentRow.DataBoundItem, beOrdenCompra)
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PNCCLNT = Me.txtCliente.pCodigo
            .PageNumber = UcPaginacion1.PageNumber
            .PageSize = UcPaginacion1.PageSize
        End With
        Me.dgItemOC.AutoGenerateColumns = False
        Me.dgItemOC.DataSource = obrOrdenCompra.ListarDetalleOrdenDeCompra(Me.dgOrdenesCompras.CurrentRow.DataBoundItem)
        If CType(Me.dgItemOC.DataSource, List(Of beOrdenCompra)).Count > 0 Then
            UcPaginacion1.PageCount = CType(Me.dgItemOC.DataSource, List(Of beOrdenCompra)).Item(0).PageCount
        End If
        fnSelPuntoDeControlXItems()

    End Sub

#End Region

    Private Sub frmCheckpointsDeOC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '-- Inicializando las variables status por control con F4
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        dteFechaInicial.Value = Now.AddYears(-1)
        dteFechaFinal.Value = Now
        CargarColumnasDeCheckpointItems()
        UCDataGridView.Alinear_Columnas_Grilla(Me.dgOrdenesCompras)

        'CARGAR TIPO OC============
        Dim obrGeneral As New brGeneral
        Me.cmbTipoOc.DataSource = obrGeneral.olistTipoOC()
        cmbTipoOc.DisplayMember = "DESC"
        cmbTipoOc.ValueMember = "ID"

        cmbTipoOc.SelectedValue = "LOC"
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        ListaOrdenDeCompra()
    End Sub

    Private Sub dgOrdenesCompras_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgOrdenesCompras.DataBindingComplete
        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        Dim olbeCheckpointOC As New List(Of beCheckPoint)
        For intCont As Integer = 0 To Me.dgOrdenesCompras.RowCount - 1
            With obeCheckpoint
                .PNCCLNT = Me.txtCliente.pCodigo
                .PSNORCML = Me.dgOrdenesCompras.Rows(intCont).DataBoundItem.PSNORCML
            End With
            olbeCheckpointOC = obrCheckpoint.ListaCheckPointXItemsDeOC(obeCheckpoint)
            Dim olbeBusqueda As List(Of beCheckPoint)
            Dim oucOrdena As UCOrdena(Of beCheckPoint)

            For Each obeCheck As beCheckPoint In olbeCheckpointOC
                olbeBusqueda = New List(Of beCheckPoint)
                NrOc = obeCheckpoint.PSNORCML
                codCheckpoint = obeCheck.PNNESTDO
                olbeBusqueda = olbeCheckpointOC.FindAll(MatchCheckpoinOC)
                If Not olbeBusqueda Is Nothing Then
                    'oucOrdena = New UCOrdena(Of beCheckPoint)("PSFECESTIMADA", UCOrdena(Of beCheckPoint).TipoOrdenacion.Ascendente)
                    'olbeBusqueda.Sort(oucOrdena)
                    'Me.dgOrdenesCompras.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECREA").Value = RetornarFechasReal(olbeBusqueda)

                    oucOrdena = New UCOrdena(Of beCheckPoint)("PNFESEST", UCOrdena(Of beCheckPoint).TipoOrdenacion.Ascendente)
                    olbeBusqueda.Sort(oucOrdena)
                    Me.dgOrdenesCompras.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECEST").Value = RetornarFechasEstiada(olbeBusqueda)
                End If

            Next
        Next
    End Sub


    Private Sub dgOrdenesCompras_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenesCompras.SelectionChanged
        Me.UcPaginacion1.PageNumber = 1
        ListarDetalleOc()
    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        ListarDetalleOc()
    End Sub
    Private Sub UcPaginacion2_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion2.PageChanged
        ListaOrdenDeCompra()
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As RANSA.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub tsbPuntoDeControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPuntoDeControl.Click
        If Me.dgItemOC.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dgItemOC.EndEdit()
        Dim obeCheckpoint As New beCheckPoint
        With obeCheckpoint
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSNORCML = Me.dgOrdenesCompras.CurrentRow.DataBoundItem.PSNORCML
            .PNNRITOC = Me.dgItemOC.CurrentRow.DataBoundItem.PNNRITOC
            .PSCEMB = ""
        End With
        Dim olbeItem As New List(Of beOrdenCompra)
        olbeItem = Me.dgItemOC.DataSource.FindAll(MatchSelectItems)
        If olbeItem.Count = 0 Then Exit Sub
        If olbeItem.Count = 1 Then
            Dim ofrmEditarCheckpoin As New frmPuntoDeControlCheckpoin(obeCheckpoint)
            With ofrmEditarCheckpoin
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    fnSelPuntoDeControlXItems()
                End If
            End With
        Else
            Dim ofrmEditarCheckpoinMasivo As New frmPuntoDeControlCheckpoinMasivo
            With ofrmEditarCheckpoinMasivo
                .olpbeOrdenCompra = olbeItem
                .ParamCheckPoint = obeCheckpoint
            End With
            If ofrmEditarCheckpoinMasivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                fnSelPuntoDeControlXItems()
            End If
        End If
    End Sub

    Private MatchSelectItems As New Predicate(Of beOrdenCompra)(AddressOf BuscarItemsSelecciondos)

    Public Function BuscarItemsSelecciondos(ByVal pbeOrdenCompra As beOrdenCompra) As Boolean
        If (pbeOrdenCompra.CHK) Then
            Return True
        Else
            Return False
        End If
    End Function

#Region "B�squeda de Checkpoint"

    Private codCheckpoint As Decimal = 0
    Private NrOc As String = ""
    Private NrItem As Decimal = 0
    Private MatchCheckpoinItemOC As New Predicate(Of beCheckPoint)(AddressOf BuscarCheckpointsItemsOC)

    Public Function BuscarCheckpointsItemsOC(ByVal pbeCheckPoint As beCheckPoint) As Boolean
        If (pbeCheckPoint.PNNESTDO = codCheckpoint) And (pbeCheckPoint.PSNORCML = NrOc) And (pbeCheckPoint.PNNRITOC = NrItem) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private MatchCheckpoinOC As New Predicate(Of beCheckPoint)(AddressOf BuscarCheckpointsOC)

    Public Function BuscarCheckpointsOC(ByVal pbeCheckPoint As beCheckPoint) As Boolean
        If (pbeCheckPoint.PNNESTDO = codCheckpoint) And (pbeCheckPoint.PSNORCML = NrOc) Then
            Return True
        Else
            Return False
        End If
    End Function


#End Region


    Private Sub CargarColumnasDeCheckpointItems()

        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        Dim olbeCheckpoint As New List(Of beCheckPoint)
        With obeCheckpoint
            .PNCCLNT = _codClientePrev
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PSCEMB = ""
        End With
        olbeCheckpoint = obrCheckpoint.Lista_CheckPoint_X_Cliente(obeCheckpoint)

        'quitar Columnas a la OC
        For Each obeCheck As beCheckPoint In olbeCheckpoint
            For intCol As Integer = dgOrdenesCompras.Columns.Count - 1 To 0 Step -1
                If Me.dgOrdenesCompras.Columns.Item(intCol).Name = (obeCheck.PNNESTDO.ToString & "_DFECEST") Then

                    'Me.dgOrdenesCompras.Columns.Remove(obeCheck.PNNESTDO & "_DFECREA")
                    Me.dgOrdenesCompras.Columns.Remove(obeCheck.PNNESTDO & "_DFECEST")

                    'Me.dgItemOC.Columns.Remove(obeCheck.PNNESTDO & "_DFECREA")
                    Me.dgItemOC.Columns.Remove(obeCheck.PNNESTDO & "_DFECEST")
                    Exit For
                End If
            Next
        Next
        _codClientePrev = Me.txtCliente.pCodigo
        With obeCheckpoint
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PSCEMB = ""
        End With
        olbeCheckpoint = obrCheckpoint.Lista_CheckPoint_X_Cliente(obeCheckpoint)


        'Agregar Columnas a la OC
        Dim oDtgColums As DataGridViewTextBoxColumn
        For Each obeCheck As beCheckPoint In olbeCheckpoint

            'oDtgColums = New DataGridViewTextBoxColumn
            'oDtgColums.Name = obeCheck.PNNESTDO & "_DFECREA"
            'oDtgColums.HeaderText = obeCheck.PSTDESES & Chr(10) & " REAL "
            'oDtgColums.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            'oDtgColums.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            'dgOrdenesCompras.Columns.Add(oDtgColums)

            oDtgColums = New DataGridViewTextBoxColumn
            oDtgColums.Name = obeCheck.PNNESTDO & "_DFECEST"
            oDtgColums.HeaderText = obeCheck.PSTDESES.Trim & Chr(10) & " "
            oDtgColums.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            oDtgColums.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            oDtgColums.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            oDtgColums.ReadOnly = True
            dgOrdenesCompras.Columns.Add(oDtgColums)

            'oDtgColums = New DataGridViewTextBoxColumn
            'oDtgColums.Name = obeCheck.PNNESTDO & "_DFECREA"
            'oDtgColums.HeaderText = obeCheck.PSTDESES & Chr(10) & " REAL "
            'oDtgColums.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            'dgItemOC.Columns.Add(oDtgColums)

            oDtgColums = New DataGridViewTextBoxColumn
            oDtgColums.Name = obeCheck.PNNESTDO & "_DFECEST"
            oDtgColums.HeaderText = obeCheck.PSTDESES.Trim & Chr(10) & ""
            oDtgColums.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            oDtgColums.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            oDtgColums.ReadOnly = True
            dgItemOC.Columns.Add(oDtgColums)
        Next
    End Sub

    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub fnSelPuntoDeControlXItems()
        If Me.dgItemOC.CurrentCellAddress.Y = -1 Or Me.dgOrdenesCompras.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        'Dim olbeCheckpoint As New List(Of beCheckPoint)
        Dim olbeCheckpointOC As New List(Of beCheckPoint)
        With obeCheckpoint
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSNORCML = Me.dgOrdenesCompras.CurrentRow.DataBoundItem.PSNORCML
            .PNNRITOC = Me.dgItemOC.CurrentRow.DataBoundItem.PNNRITOC
        End With
        olbeCheckpointOC = obrCheckpoint.ListaCheckPointXItemsDeOC(obeCheckpoint)
        Dim obeBusqueda As beCheckPoint
        For intCont As Integer = 0 To Me.dgItemOC.RowCount - 1
            For Each obeCheck As beCheckPoint In olbeCheckpointOC
                obeBusqueda = New beCheckPoint
                NrOc = Me.dgOrdenesCompras.CurrentRow.DataBoundItem.PSNORCML
                NrItem = dgItemOC.Rows(intCont).DataBoundItem.PNNRITOC
                codCheckpoint = obeCheck.PNNESTDO
                obeBusqueda = olbeCheckpointOC.Find(MatchCheckpoinItemOC)
                If Not obeBusqueda Is Nothing Then
                    'Me.dgItemOC.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECREA").Value = HelpClass.CNumero8Digitos_a_FechaDefault(obeBusqueda.PNFRETES)
                    Me.dgItemOC.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECEST").Value = HelpClass.CNumero8Digitos_a_FechaDefault(obeBusqueda.PNFESEST)
                    CType(Me.dgItemOC.Rows(intCont).DataBoundItem, beOrdenCompra).CHK = False
                End If
            Next
        Next
        dgItemOC.Refresh()
        dgItemOC.RefreshEdit()
    End Sub

    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub fnSelPuntoDeControlXoc()
        If Me.dgItemOC.CurrentCellAddress.Y = -1 Or Me.dgOrdenesCompras.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        'Dim olbeCheckpoint As New List(Of beCheckPoint)
        Dim olbeCheckpointOC As New List(Of beCheckPoint)
        With obeCheckpoint
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSNORCML = Me.dgOrdenesCompras.CurrentRow.DataBoundItem.PSNORCML
        End With
        olbeCheckpointOC = obrCheckpoint.ListaCheckPointXItemsDeOC(obeCheckpoint)

        Dim olbeBusqueda As List(Of beCheckPoint)
        Dim oucOrdena As UCOrdena(Of beCheckPoint)
        For intCont As Integer = 0 To Me.dgItemOC.RowCount - 1
            For Each obeCheck As beCheckPoint In olbeCheckpointOC
                olbeBusqueda = New List(Of beCheckPoint)
                NrOc = Me.dgOrdenesCompras.CurrentRow.DataBoundItem.PSNORCML
                codCheckpoint = obeCheck.PNNESTDO
                olbeBusqueda = olbeCheckpointOC.FindAll(MatchCheckpoinOC)

                If Not olbeBusqueda Is Nothing Then
                    'oucOrdena = New UCOrdena(Of beCheckPoint)("PNFECREA", UCOrdena(Of beCheckPoint).TipoOrdenacion.Ascendente)
                    'olbeBusqueda.Sort(oucOrdena)
                    'Me.dgOrdenesCompras.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECREA").Value = RetornarFechasEstiada(olbeBusqueda)
                    oucOrdena = New UCOrdena(Of beCheckPoint)("PNFESEST", UCOrdena(Of beCheckPoint).TipoOrdenacion.Ascendente)
                    olbeBusqueda.Sort(oucOrdena)
                    Me.dgOrdenesCompras.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECEST").Value = RetornarFechasReal(olbeBusqueda)
                End If
            Next
        Next
        dgItemOC.RefreshEdit()
    End Sub

    Private Function RetornarFechasReal(ByVal olbeResultado1 As List(Of beCheckPoint)) As String
        Dim strFecha As String = ""
        Dim strDato As String = ""
        For intCont As Integer = olbeResultado1.Count - 1 To 0 Step -1
            If olbeResultado1(intCont).PSFECREAL <> strDato Then
                If olbeResultado1(intCont).PSFECREAL.Trim.Equals("") Then
                    Continue For
                End If
                strDato = olbeResultado1.Item(intCont).PSFECREAL
                strFecha = strFecha & olbeResultado1.Item(intCont).PSFECREAL & Chr(10)
            End If
        Next
        If Not strFecha.Trim.Equals("") Then
            strFecha.TrimEnd(Chr(10))
        End If
        Return strFecha
    End Function

    Private Function RetornarFechasEstiada(ByVal olbeResultado1 As List(Of beCheckPoint)) As String
        Dim strFecha As String = ""
        Dim strDato As String = ""
        For intCont As Integer = olbeResultado1.Count - 1 To 0 Step -1
            If olbeResultado1(intCont).PSFECESTIMADA.Trim.Equals("") Then
                Continue For
            End If
            If olbeResultado1(intCont).PSFECESTIMADA <> strDato Then
                strDato = olbeResultado1.Item(intCont).PSFECESTIMADA
                strFecha = strFecha & olbeResultado1.Item(intCont).PSFECESTIMADA & Chr(10)
            End If
        Next
        If Not strFecha.Trim.Equals("") Then
            strFecha = strFecha.Substring(0, strFecha.Length - 1)
        End If
        Return strFecha
    End Function

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        strItem = String.Empty
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If dgItemOC.RowCount > 0 Then
            For IntCont As Integer = 0 To Me.dgItemOC.RowCount - 1
                Me.dgItemOC.Rows(IntCont).DataBoundItem.CHK = btnMarcarItems.Checked
            Next
        End If
        Me.dgItemOC.EndEdit()
        Me.dgItemOC.Refresh()
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Dim ofrmFiltroExportarXls As New frmFiltroExportarXls
        Dim obeOc As New beOrdenCompra
        With obeOc
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .Compania = Me.UcCompania_Cmb011.CCMPN_Descripcion
            .PSCDVSN = UcDivision_Cmb011.Division
            .Division = UcDivision_Cmb011.DivisionDescripcion
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .Planta = Me.UcPLanta_Cmb011.DescripcionPlanta
            .PNCCLNT = Me.txtCliente.pCodigo
            .Cliente = Me.txtCliente.pRazonSocial
            .PSNORCML = Me.txtOrdenCompra.Text
            .PNCPRVCL = Me.txtProveedor.pCodigo
            .Proveedor = Me.txtProveedor.pRazonSocial
            .PSTTINTC = "LOC"
            .FechaInicioOC = Me.dteFechaInicial.Value
            .FechaFinOc = dteFechaFinal.Value
        End With
        ofrmFiltroExportarXls.pObeOrdenDeCompra = obeOc
        ofrmFiltroExportarXls.ShowDialog()
    End Sub


    Private Sub btnEnSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnSeguimiento.Click
        If Me.dgItemOC.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dgItemOC.EndEdit()
        Dim obeCheckpoint As New beCheckPoint
        With obeCheckpoint
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSNORCML = Me.dgItemOC.CurrentRow.DataBoundItem.PSNORCML
            .PNNRITOC = Me.dgItemOC.CurrentRow.DataBoundItem.PNNRITOC
            .PSCEMB = ""
        End With
        Dim olbeItem As New List(Of beOrdenCompra)
        olbeItem = Me.dgItemOC.DataSource.FindAll(MatchSelectItems)
        If olbeItem.Count = 0 Then Exit Sub
        Dim obrOc As New brOrdenDeCompra
        If MessageBox.Show("Desea realizar seguimiento", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each obeOc As beOrdenCompra In olbeItem
                obeOc.PSFLGPEN = ""
            Next
            obrOc.finActualizarEstadoSeguimiento(olbeItem)
        Else
            For Each obeOc As beOrdenCompra In olbeItem
                obeOc.PSFLGPEN = "1"
            Next
            obrOc.finActualizarEstadoSeguimiento(olbeItem)
        End If
        ListarDetalleOc()
        btnMarcarItems.Checked = False
    End Sub

    Private Sub dgItemOC_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellDoubleClick
        If e.ColumnIndex = 6 Then
            Dim ofrmBitacora As New frmBitacoras
            Dim obeCheckpoint As New beCheckPoint
            obeCheckpoint.PNCCLNT = Me.txtCliente.pCodigo
            obeCheckpoint.PSNORCML = Me.dgItemOC.CurrentRow.DataBoundItem.PSNORCML
            obeCheckpoint.PNNRITOC = Me.dgItemOC.CurrentRow.DataBoundItem.PNNRITOC
            ofrmBitacora.beCheckPoint = obeCheckpoint
            ofrmBitacora.ShowDialog()
        End If

    End Sub

    Private Sub dgItemOC_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgItemOC.DataBindingComplete
        If Me.dgItemOC.DataSource IsNot Nothing Then
            For intCont As Integer = 0 To dgItemOC.RowCount - 1
                If CType(dgItemOC.Rows(intCont).DataBoundItem, beOrdenCompra).PSFLGPEN.Trim.Equals("") Then
                    dgItemOC.Rows(intCont).Cells("FLGPEN").Value = My.Resources.Enviado
                End If
            Next
        End If
    End Sub


    Private Sub txtCliente_TextChanged() Handles txtCliente.TextChanged
        '_codClientePrev = Me.txtCliente.pCodigo
    End Sub

    Private Sub Modulo01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modulo01ToolStripMenuItem.Click
        Dim ofrmFiltroExportarXls As New frmFiltroExportarXls
        Dim obeOc As New beOrdenCompra
        With obeOc
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .Compania = Me.UcCompania_Cmb011.CCMPN_Descripcion
            .PSCDVSN = UcDivision_Cmb011.Division
            .Division = UcDivision_Cmb011.DivisionDescripcion
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .Planta = Me.UcPLanta_Cmb011.DescripcionPlanta
            .PNCCLNT = Me.txtCliente.pCodigo
            .Cliente = Me.txtCliente.pRazonSocial
            .PSNORCML = Me.txtOrdenCompra.Text
            .PNCPRVCL = Me.txtProveedor.pCodigo
            .Proveedor = Me.txtProveedor.pRazonSocial
            .PSTTINTC = Me.cmbTipoOc.SelectedValue
            .FechaInicioOC = Me.dteFechaInicial.Value
            .FechaFinOc = dteFechaFinal.Value
        End With
        ofrmFiltroExportarXls.pObeOrdenDeCompra = obeOc
        ofrmFiltroExportarXls.ShowDialog()
    End Sub

    Private Sub Modulo02ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modulo02ToolStripMenuItem.Click
        Dim ofrmFiltroExportarXls As New frmFiltroExportarXls_2
        Dim obeOc As New beOrdenCompra
        With obeOc
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .Compania = Me.UcCompania_Cmb011.CCMPN_Descripcion
            .PSCDVSN = UcDivision_Cmb011.Division
            .Division = UcDivision_Cmb011.DivisionDescripcion
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .Planta = Me.UcPLanta_Cmb011.DescripcionPlanta
            .PNCCLNT = Me.txtCliente.pCodigo
            .Cliente = Me.txtCliente.pRazonSocial
            .PSNORCML = Me.txtOrdenCompra.Text
            .PNCPRVCL = Me.txtProveedor.pCodigo
            .Proveedor = Me.txtProveedor.pRazonSocial
            .PSTTINTC = Me.cmbTipoOc.SelectedValue
            .FechaInicioOC = Me.dteFechaInicial.Value
            .FechaFinOc = dteFechaFinal.Value
        End With
        ofrmFiltroExportarXls.pObeOrdenDeCompra = obeOc
        ofrmFiltroExportarXls.ShowDialog()
    End Sub

    Private Sub chkSeguimiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaOc.CheckedChanged
        dteFechaInicial.Enabled = Me.chkFechaOc.Checked
        dteFechaFinal.Enabled = Me.chkFechaOc.Checked
    End Sub

    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub
End Class


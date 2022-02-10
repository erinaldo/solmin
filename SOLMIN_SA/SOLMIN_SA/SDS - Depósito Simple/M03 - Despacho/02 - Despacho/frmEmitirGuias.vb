'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS.Reportes
Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario


Public Class frmEmitirGuias
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        ANULAR
        GENERAR
        RESTAURAR
    End Enum
#End Region
#Region " Atributos "
    Private booStatus As Boolean = False
    Private _widthLeftRight As Int32
    Private strImprimirEtiqueta As String = ""
    Private ListaClntABB As New Hashtable
#End Region
#Region " Propiedades "

#End Region

#Region " Procedimientos y Funciones "
    Private Sub pActualizarInformacion()
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            booStatus = False
            '-- Cargamos las Guías de Salida
            Call pListarGuiasRansa()
            ' Cargamos las Guias de Remisión
            Call pListarGuiasRemision()
            booStatus = True
            'VisorReportesCrystal.ReportSource = Nothing
            '-- Registro los nuevos valores de los campos de los clientes
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("DespachoClienteCodigo", txtCliente.pCodigo)
            objAppConfig = Nothing
        End If
    End Sub

    'Private Sub pProceso_AnularGuiaSalida()
    '    ' Si elige NO entonces salimos del proceso
    '    If Not mfblnPreguntas(enumPregVarios.PROCESO_AnularGuiaSalida) Then Exit Sub
    '    If fblnValidaInformacion(eTipoValidacion.ANULAR) Then
    '        Dim objPrimaryKey_Despacho As clsPrimaryKey_Despacho = New clsPrimaryKey_Despacho
    '        With objPrimaryKey_Despacho
    '            .pintCodigoCliente_CCLNT = txtCliente.pCodigo 
    '            .pstrNroGuiaSalida_NRGUSA = dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value.ToString.Trim
    '        End With
    '        If mfblnProceso_AnularGuiaSalida(objPrimaryKey_Despacho) Then
    '            '-- Eliminamos el registro seleccionado
    '            dgGuiasRansa.Rows.Remove(dgGuiasRansa.CurrentRow)
    '            '-- Actualizamos la información de la Guía de Remisión
    '            Call pListarGuiasRemision()
    '        End If
    '    End If
    'End Sub

    Private Sub pProceso_GenerarGuiaRemision()
        If dgGuiasRansa.RowCount = 0 Or dgGuiasRansa.CurrentRow Is Nothing Then Exit Sub
        If dgGuiasRansa.CurrentRow.Cells("GS_CTPOAT").Value = "I" Then
            MessageBox.Show("Debe seleccionar una Guía de Despacho.", "Guía Remisión:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If BuscarGuiasRemisionActivas() Then
            MessageBox.Show("Ya dispone de Guías de Remisión.", "Guía Remisión:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If fblnValidaInformacion(eTipoValidacion.GENERAR) Then
            Dim fGenerarGRemision As frmGenerarGuiaRemisionSDS = New frmGenerarGuiaRemisionSDS
            With fGenerarGRemision
                .PNCCLNT = txtCliente.pCodigo
                .pNroGuia_NRGUIA = dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value.ToString.Trim
                ' Información relacionada a la Empresa de Transporte
                .pstrEmpresaTransporte_CTRSPT = dgGuiasRansa.CurrentRow.Cells("GS_CTRSP").Value.ToString.Trim
                .pstrPlacaUnidad_NPLCUN = dgGuiasRansa.CurrentRow.Cells("GS_NPLCCM").Value.ToString.Trim
                .pstrBrevete_CBRCNT = dgGuiasRansa.CurrentRow.Cells("GS_NBRVCH").Value.ToString.Trim
                .pintCodigoClienteTercero_CPRVCL = Val(dgGuiasRansa.CurrentRow.Cells("PSCPRVD").Value.ToString.Trim)


                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    booStatus = False
                    '-- Actualizamos la información de la Guía de Remisión
                    Call pListarGuiasRemision()
                    booStatus = True
                End If
            End With
        End If
    End Sub

    Private Function BuscarGuiasRemisionActivas() As Boolean
        For intRows As Integer = 0 To Me.dgGuiasRemision.Rows.Count - 1
            If dgGuiasRemision.Rows(intRows).Cells("GR_SITUAC").Value.ToString.Trim = "ACTIVO" Then
                Return True
            End If
        Next
        Return False
    End Function

    'Private Sub pProceso_RestaurarGuiaSalida()
    '    ' Si elige NO entonces salimos del proceso
    '    If Not mfblnPreguntas(enumPregVarios.PROCESO_RestaurarGuiaSalida) Then Exit Sub
    '    If fblnValidaInformacion(eTipoValidacion.RESTAURAR) Then
    '        Dim objPrimaryKey_Despacho As clsPrimaryKey_Despacho = New clsPrimaryKey_Despacho
    '        With objPrimaryKey_Despacho
    '            .pintCodigoCliente_CCLNT = txtCliente.pClienteSeleccionado .pCCLNT_Cliente
    '            .pstrNroGuiaSalida_NRGUSA = dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value.ToString.Trim
    '        End With
    '        If mfblnProceso_RestaurarGuiaSalida(objPrimaryKey_Despacho) Then
    '            '-- Actualizamos la información de la Guía de Remisión
    '            Call pListarGuiasRemision()
    '        End If
    '    End If
    'End Sub

    Private Sub pListarGuiasRansa()

        Dim objFiltro As New beDespacho
        Dim objDespacho As New brDespacho
        Dim oLista As New List(Of beDespacho)
        With objFiltro
            .PNCCLNT = txtCliente.pCodigo
            If txtNroGuiaRANSA.Text <> "" Then
                .PNNGUIRN = Convert.ToDecimal(txtNroGuiaRANSA.Text.Trim)
            End If
            .PSCTPALM = "" & txtTipoAlmacen.Tag
            .PSCALMC = "" & txtAlmacen.Tag
            If cmbProceso.SelectedItem = "TODOS" Then
                .PSCTPOAT = "0"
            ElseIf cmbProceso.SelectedItem = "RECEPCIÓN" Then
                .PSCTPOAT = "I"
            ElseIf cmbProceso.SelectedItem = "DESPACHO" Then
                .PSCTPOAT = "S"
            Else
                .PSCTPOAT = "0"
            End If
            If dtpFechaInicial.Checked Then .PNFECINI = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaInicial.Value.Date)
            If dtpFechaFinal.Checked Then .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaFinal.Value.Date)
        End With

        oLista = objDespacho.ListaGuiaRansaDesp(objFiltro)
        dgGuiasRansa.AutoGenerateColumns = False
        dgGuiasRansa.DataSource = oLista
    End Sub


    Private Sub pListarGuiasRemision()
        If dgGuiasRansa.RowCount = 0 Or dgGuiasRansa.CurrentRow Is Nothing Then
            dgGuiasRemision.DataSource = New DataTable
            Exit Sub
        End If

        Dim objFiltro As New beDespacho
        Dim objDespachoGR As New brDespacho
        Dim oListaRM As New List(Of beDespacho)
        With objFiltro
            .PNCCLNT = txtCliente.pCodigo
            .PNNGUIRN = dgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN
        End With
        oListaRM = objDespachoGR.ListaGuiaRemisionDesp(objFiltro)
        dgGuiasRemision.AutoGenerateColumns = False
        dgGuiasRemision.DataSource = oListaRM
        For i As Integer = 0 To dgGuiasRemision.Rows.Count - 1
            dgGuiasRemision.Rows(i).Cells("PNNGUIRN").Value = dgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN
        Next
    End Sub

    Private Sub pVisualizarGuiaRansa()
        Dim objFiltro As New beDespacho
        Dim objDespacho As New brDespacho
        With objFiltro
            .PNCCLNT = dgGuiasRansa.CurrentRow.DataBoundItem.PNCCLNT
            .PNNGUIRN = dgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN
            .pRazonSocial = txtCliente.pRazonSocial
            .PSCTPOAT = dgGuiasRansa.CurrentRow.DataBoundItem.PSCTPOAT.ToString.Trim
        End With
        mReporteIngSalRansa(objFiltro)
    End Sub


    Private Sub pVisualizarRuteoxPuntoEntrega()
        Try
            Dim ofrmRuteoPorPuntoEntrega As New frmRuteoPorPuntoEntrega()
            With ofrmRuteoPorPuntoEntrega
                .CodCliente = txtCliente.pCodigo
                .Fecha = Me.dtpFechaInicial.Value
                .ShowDialog(Me)
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pVisualizarGuiaRemision()
        If dgGuiasRemision.RowCount = 0 Then Exit Sub
        Dim obeFiltroGuia As New beGuiaRemision
        With obeFiltroGuia
            .PNCCLNT = txtCliente.pCodigo
            .PSNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNNGUIRM
            .strAplicacion = Application.StartupPath
        End With
        Dim oDs As DataSet
        oDs = New Ransa.NEGO.DespachoSAT.brGuiasRemision().fdsImprimirGuiaRemision(obeFiltroGuia, objSeguridadBN.pstrTipoSistema)
        VistraPreviaGuiaRemisionDS(oDs, obeFiltroGuia.PSMODELO)
    End Sub

    Private Sub VistraPreviaGuiaRemisionDS(ByVal oDs As DataSet, ByVal strModeloGuia As String)
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        ' Cargamos los valores de los parametros de impresión de la Guia
        Select Case strModeloGuia
            Case "M1"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M01
            Case "M2"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M02
            Case "M3"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M03
            Case "M4"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M04
            Case "M5"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M05
            Case "M6"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M06
            Case Else
                rdocGuiaRemision = New rptGuiaRemisionSDS_M01
        End Select
        rdocGuiaRemision.SetDataSource(oDs)
        rdocGuiaRemision.Refresh()
        'Imprime la Guía de Remisión
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
        End With
    End Sub

    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        'If eValidacion = eTipoValidacion.PROCESAR Then
        '    If txtCliente.pClienteSeleccionado .pCCLNT_Cliente = 0 Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        'Else
        '    Dim objPrimaryKey_Despacho As clsPrimaryKey_Despacho = New clsPrimaryKey_Despacho
        '    With objPrimaryKey_Despacho
        '        .pintCodigoCliente_CCLNT = txtCliente.pClienteSeleccionado .pCCLNT_Cliente
        '        .pstrNroGuiaSalida_NRGUSA = dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value
        '    End With
        '    If dgGuiasRansa.RowCount <= 0 Then strMensajeError &= "No existe Guías de Salida para realizar el Proceso. " & vbNewLine
        '    ' Validamos los valores de la Guía de Salida
        '    With dgGuiasRansa
        '        Select Case eValidacion
        '            Case eTipoValidacion.ANULAR
        '                If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Guía de Salida ya se encuentra anulada. " & vbNewLine
        '                If mfblnExiste_GuiaSalidaConGuiaRemision(objPrimaryKey_Despacho) Then _
        '                    strMensajeError &= "La presente Guía de Salida tiene Guía(s) de Remisión. " & vbNewLine
        '            Case eTipoValidacion.GENERAR
        '                If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Guía de Salida esta anulada. " & vbNewLine
        '                If mfblnExiste_GuiaSalidaConGuiaRemision(objPrimaryKey_Despacho) Then _
        '                    strMensajeError &= "Ya se han generado las Guías de Remisión. " & vbNewLine
        '            Case eTipoValidacion.RESTAURAR
        '                If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Guía de Salida se encuentra anulada. " & vbNewLine
        '                If Not mfblnExiste_GuiaSalidaConGuiaRemision(objPrimaryKey_Despacho) Then _
        '                    strMensajeError &= "La presente Guía de Salida no tiene Guía(s) de Remisión. " & vbNewLine
        '        End Select
        '    End With
        'End If
        'If strMensajeError <> "" Then
        '    blnResultado = False
        '    MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        Return blnResultado
    End Function
#End Region

#Region " Métodos "
    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub


    Private Sub bsaAnularGS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAnularGS.Click
        If dgGuiasRansa.CurrentCellAddress.Y < 0 Then Exit Sub
        If MessageBox.Show("Esta seguro de Anular Guía?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim obrDespacho As New brDespacho
            Dim obeDespacho As New beDespacho
            With obeDespacho
                .PNCCLNT = Me.txtCliente.pCodigo
                .PNNGUIRN = dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value.ToString.Trim
                .PSCULUSA = objSeguridadBN.pUsuario
                .PSNLTECL = objSeguridadBN.pstrPCName
            End With
            Dim IntResultado As Integer

            If Not dgGuiasRansa.CurrentRow.Cells("GS_CTPOAT").Value = "I" Then
                IntResultado = obrDespacho.AnularGuiaDeSalida(obeDespacho)
            Else
                'PENDIENTE
                IntResultado = obrDespacho.AnularGuiaDeIngreso(obeDespacho)
            End If

            If IntResultado = -1 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
            If IntResultado = 1 Then
                'MessageBox.Show("Guia de salida Anulada", "Información")
                Call pActualizarInformacion()
            Else
                HelpClass.MsgBox("No se puede anular,no es el último movimiento realizado")
            End If
        End If
    End Sub

    Private Sub bsaAnularTodasGRs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAnularTodasGRs.Click
        'Call pProceso_RestaurarGuiaSalida()
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub bsaGenerarGuiaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGenerarGuiaRemision.Click
        Call pProceso_GenerarGuiaRemision()
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub bsaVistaPreviaGS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaVistaPreviaGS.Click
        Call pVisualizarGuiaRansa()
    End Sub

    Private Sub bsaVistaPreviaGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaVistaPreviaGR.Click
        Call pVisualizarGuiaRemision()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    Private Sub dgGuiasRansa_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGuiasRansa.CurrentCellChanged
        If booStatus Then
            booStatus = False
            If dgGuiasRansa.Rows.Count > 0 Then
                Call pListarGuiasRemision()
            End If
            booStatus = True
        End If
    End Sub

    Private Sub frmEmitirGuias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-- Crear status por control con F4
        ' Me.bsaPuntoEntrega.Visible = False
        ' Me.bsaAnularItemGS.Visible = False
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Iniciar la fecha de los controles
        dtpFechaInicial.Value = Now.Date
        dtpFechaFinal.Value = Now.Date
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("DespachoClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        txtCliente_InformationChanged()
        objAppConfig = Nothing
        cmbProceso.SelectedItem = "TODOS"


        Dim obeClnt As New beGeneral
        Dim obrGeneral As New brGeneral
        obeClnt.PSCODVAR = "CLTABB"
        obeClnt.PSCCMPRN = ""
        Dim listaCliente As New List(Of beGeneral)
        listaCliente = obrGeneral.ListaTablaAyuda(obeClnt)
        For Each beGen As beGeneral In listaCliente
            ListaClntABB(beGen.PSCCMPRN.Trim) = beGen.PSCCMPRN.Trim
        Next

    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
        txtAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub RestaurarGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaRestaurarGR.Click
        If Me.dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
        If MessageBox.Show("Esta seguro de anular Guías ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim obeDespacho As New beDespacho
            Dim obrDespacho As New brDespacho
            With obeDespacho
                .PNCCLNT = Me.txtCliente.pCodigo
                .PNNGUIRN = dgGuiasRemision.CurrentRow.Cells("PNNGUIRN").Value
                .PSCULUSA = objSeguridadBN.pUsuario
            End With
            If obrDespacho.RestaurarGuiaDeRemisionDSD(obeDespacho) = 1 Then
                Call pListarGuiasRemision()
            End If
        End If

    End Sub

#End Region


    Private Sub bsaAnularGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAnularGR.Click
        If Me.dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
        If MessageBox.Show("Esta seguro de Anular Guías ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim obeDespacho As New beDespacho
            Dim obrDespacho As New brDespacho
            With obeDespacho
                .PNCCLNT = Me.txtCliente.pCodigo
                .PNNGUIRN = dgGuiasRemision.CurrentRow.Cells("PNNGUIRN").Value
                .PSCULUSA = objSeguridadBN.pUsuario
            End With
            If obrDespacho.AnularGuiaDeRemisionDSD(obeDespacho) = 1 Then
                Call pListarGuiasRemision()
            End If
        End If
    End Sub

    Private Sub bsaAnularItemGS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAnularItemGS.Click
        If Me.dgGuiasRansa.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim ofrmItemsDeGuia As New frmItemsDeGuia
        With ofrmItemsDeGuia
            .CodCliente = Me.txtCliente.pCodigo
            .CodGuiaRansa = dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value.ToString.Trim
            .Tipo = dgGuiasRansa.CurrentRow.Cells("GS_CTPOAT").Value
        End With
        If ofrmItemsDeGuia.ShowDialog = Windows.Forms.DialogResult.OK Then
            pActualizarInformacion()
        End If

    End Sub

    Private Sub bsaPuntoEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPuntoEntrega.Click
        Call pVisualizarRuteoxPuntoEntrega()
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        Dim obrGeneral As New brGeneral

        'Validamos que el clientes sea Outotec
        If obrGeneral.bolElClienteEsOutotec(Me.txtCliente.pCodigo) Then
            bsaRestaurarGR.Visible = False
            bsaAnularGR.Visible = False
        End If

    End Sub

    Private Sub bsaReenviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaReenviar.Click
        Dim obrGeneral As New brGeneral
        'Validamos que el clientes sea Outotec

        If obrGeneral.bolElClienteEsOutotec(Me.txtCliente.pCodigo) Then
            For intRow As Integer = 0 To dgGuiasRansa.RowCount - 1
                If dgGuiasRansa.Rows(intRow).Cells("GS_STRNSM").Value = "" Then
                    If dgGuiasRansa.Rows(intRow).Cells("GS_CTPOAT").Value = "I" Then
                        EnviarRecepcionOutotec(dgGuiasRansa.Rows(intRow).Cells("GS_NGUIRN").Value)
                    Else
                        EnviarDespachoOutotec(dgGuiasRansa.Rows(intRow).Cells("GS_NGUIRN").Value)
                    End If
                End If
            Next
            pActualizarInformacion()
        End If

        'ListaClntABB
        If ListaClntABB.Contains(Me.txtCliente.pCodigo.ToString.Trim) Then
            'If Me.txtCliente.pCodigo = 11232 Then
            For intRow As Integer = 0 To dgGuiasRansa.RowCount - 1
                If dgGuiasRansa.Rows(intRow).Cells("GS_STRNSM").Value = "" AndAlso dgGuiasRansa.Rows(intRow).Cells("GS_STPING").Value <> "Transferencia" Then
                    If dgGuiasRansa.Rows(intRow).Cells("GS_CTPOAT").Value = "I" Then
                        fEnviarRecepcionABB(Me.txtCliente.pCodigo.ToString.Trim, dgGuiasRansa.Rows(intRow).Cells("GS_NGUIRN").Value)
                    Else
                        fEnviarDespachoABB(Me.txtCliente.pCodigo.ToString.Trim, dgGuiasRansa.Rows(intRow).Cells("GS_NGUIRN").Value)
                    End If
                End If
            Next
            pActualizarInformacion()
        End If

    End Sub
    Private Function retornoListaEnvioRecepcion(ByVal pdecGuiaRansa As Decimal) As Ransa.NEGO.ProxyRansa.WSABB.Integracion.beRecepcion
        'Private Function retornoListaEnvioRecepcion(ByVal pdecGuiaRansa As Decimal) As WSABB.IntegracionABB.beRecepcion

        Dim obrRecepcion As New Ransa.NEGO.brMercaderia
        Dim beFiltro As New beDespacho

        With beFiltro
            .PNCCLNT = Me.txtCliente.pCodigo
            .PNNGUIRN = pdecGuiaRansa
        End With

        Dim obrDespacho As New Ransa.NEGO.brDespacho
        Dim obeDespacho As New Ransa.TypeDef.beDespacho
        Dim odtRecepcion As New DataTable
        obeDespacho.PNCCLNT = Me.txtCliente.pCodigo
        obeDespacho.PNNGUIRN = pdecGuiaRansa
        odtRecepcion = obrDespacho.fdtListaParaExportarABBRecepcion(obeDespacho)

        'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
        'Dim obeRecepcionABB As New WSABB.IntegracionABB.beRecepcion
        Dim oIntegracionABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.IntegracionABB(Me.txtCliente.pCodigo.ToString.Trim)
        Dim obeRecepcionABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beRecepcion


        With odtRecepcion.Rows(0)
            obeRecepcionABB.vc_RansaInGuide = .Item("nguirn")
            obeRecepcionABB.vc_PurchaseOrder = .Item("NORCCL")
            obeRecepcionABB.dt_DeliveryGuideDate = HelpClass.CNumero_a_Fecha(.Item("FRLZSR"))
            obeRecepcionABB.vc_VehiclePlate = .Item("NPLCCM")
            obeRecepcionABB.vc_TransportCarrierName = .Item("TCMPTR")
            obeRecepcionABB.vc_TransportCarrierFiscalCode = .Item("NRUCT")
            obeRecepcionABB.vc_Driver = ""
            obeRecepcionABB.vc_DriversLicense = .Item("NBRVCH")
            obeRecepcionABB.vc_DeliveryGuideComments = ""
            obeRecepcionABB.vc_Usuario = objSeguridadBN.pUsuario

            'Dim olistDetalleRecepcion As New List(Of WSABB.IntegracionABB.beDetalleRecepcion)
            Dim olistDetalleRecepcion As New List(Of Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDetalleRecepcion)

            'Dim obeDetalleRecepcion As WSABB.IntegracionABB.beDetalleRecepcion
            Dim obeDetalleRecepcion As Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDetalleRecepcion
            For IntRow As Integer = 0 To odtRecepcion.Rows.Count - 1
                'obeDetalleRecepcion = New WSABB.IntegracionABB.beDetalleRecepcion
                obeDetalleRecepcion = New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDetalleRecepcion

                With odtRecepcion.Rows(IntRow)
                    obeDetalleRecepcion.in_PurchaseOrder = .Item("NORCCL")
                    obeDetalleRecepcion.in_PurchaseOrderLine = .Item("NRITOC")
                    obeDetalleRecepcion.vc_SupplierCode = .Item("NRUCLL")
                    obeDetalleRecepcion.vc_SupplierFiscalCode = ""
                    obeDetalleRecepcion.vc_SupplierFiscalName = ""
                    obeDetalleRecepcion.vc_StockCode = .Item("CMRCLR")
                    obeDetalleRecepcion.vc_LineDescriptionLine1 = ""
                    obeDetalleRecepcion.vc_LineDescriptionLine2 = ""
                    obeDetalleRecepcion.vc_UnitMeasureCode = .Item("CUNCN5")
                    obeDetalleRecepcion.fl_QuantityReceived = .Item("QTRMC")
                    obeDetalleRecepcion.vc_MDFCode = ""

                    .Item("NGUICL") = .Item("NGUICL").ToString.Replace("-", "")
                    If Not IsNumeric(.Item("NGUICL")) Then
                        .Item("NGUICL") = "0"
                    End If
                    If .Item("NGUICL") > Int32.MaxValue Then
                        .Item("NGUICL") = 0
                    End If
                    obeDetalleRecepcion.in_SupplierDeliveryGuideNumber = Conversion.Int(.Item("NGUICL").ToString)
                    obeDetalleRecepcion.in_Embarque = .Item("NORSCI")
                    obeDetalleRecepcion.vc_Usuario = objSeguridadBN.pUsuario

                End With
                olistDetalleRecepcion.Add(obeDetalleRecepcion)
            Next
            obeRecepcionABB.ListaDetalleRecepcion = olistDetalleRecepcion.ToArray()
        End With

        Return obeRecepcionABB
    End Function




    Private Sub fEnviarRecepcionABB(CodCliente As String, ByVal pdecGuiaRansa As Decimal)
        'Dim obrRecepcion As New Ransa.NEGO.brMercaderia
        'Dim beFiltro As New beDespacho

        'With beFiltro
        '    .PNCCLNT = Me.txtCliente.pCodigo
        '    .PNNGUIRN = pdecGuiaRansa
        'End With

        'Dim obrDespacho As New Ransa.NEGO.brDespacho
        'Dim obeDespacho As New Ransa.TYPEDEF.beDespacho
        'Dim odtRecepcion As New DataTable
        'obeDespacho.PNCCLNT = Me.txtCliente.pCodigo
        'obeDespacho.PNNGUIRN = pdecGuiaRansa
        'odtRecepcion = obrDespacho.fdtListaParaExportarABBRecepcion(obeDespacho)

        'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
        'Dim obeRecepcionABB As New WSABB.IntegracionABB.beRecepcion


        'With odtRecepcion.Rows(0)
        '    obeRecepcionABB.vc_RansaInGuide = .Item("nguirn")
        '    obeRecepcionABB.vc_PurchaseOrder = .Item("NORCCL")
        '    obeRecepcionABB.dt_DeliveryGuideDate = HelpClass.CNumero_a_Fecha(.Item("FRLZSR"))
        '    obeRecepcionABB.vc_VehiclePlate = .Item("NPLCCM")
        '    obeRecepcionABB.vc_TransportCarrierName = .Item("TCMPTR")
        '    obeRecepcionABB.vc_TransportCarrierFiscalCode = .Item("NRUCT")
        '    obeRecepcionABB.vc_Driver = ""
        '    obeRecepcionABB.vc_DriversLicense = .Item("NBRVCH")
        '    obeRecepcionABB.vc_DeliveryGuideComments = ""
        '    obeRecepcionABB.vc_Usuario = objSeguridadBN.pUsuario

        '    Dim olistDetalleRecepcion As New List(Of WSABB.IntegracionABB.beDetalleRecepcion)

        '    Dim obeDetalleRecepcion As WSABB.IntegracionABB.beDetalleRecepcion
        '    For IntRow As Integer = 0 To odtRecepcion.Rows.Count - 1
        '        obeDetalleRecepcion = New WSABB.IntegracionABB.beDetalleRecepcion

        '        With odtRecepcion.Rows(IntRow)
        '            obeDetalleRecepcion.in_PurchaseOrder = .Item("NORCCL")
        '            obeDetalleRecepcion.in_PurchaseOrderLine = .Item("NRITOC")
        '            obeDetalleRecepcion.vc_SupplierCode = .Item("NRUCLL")
        '            obeDetalleRecepcion.vc_SupplierFiscalCode = ""
        '            obeDetalleRecepcion.vc_SupplierFiscalName = ""
        '            obeDetalleRecepcion.vc_StockCode = .Item("CMRCLR")
        '            obeDetalleRecepcion.vc_LineDescriptionLine1 = ""
        '            obeDetalleRecepcion.vc_LineDescriptionLine2 = ""
        '            obeDetalleRecepcion.vc_UnitMeasureCode = .Item("CUNCN5")
        '            obeDetalleRecepcion.fl_QuantityReceived = .Item("QTRMC")
        '            obeDetalleRecepcion.vc_MDFCode = ""

        '            .Item("NGUICL") = .Item("NGUICL").ToString.Replace("-", "")
        '            If Not IsNumeric(.Item("NGUICL")) Then
        '                .Item("NGUICL") = "0"
        '            End If
        '            If .Item("NGUICL") > Int32.MaxValue Then
        '                .Item("NGUICL") = 0
        '            End If
        '            obeDetalleRecepcion.in_SupplierDeliveryGuideNumber = Conversion.Int(.Item("NGUICL").ToString)
        '            obeDetalleRecepcion.in_Embarque = .Item("NORSCI")
        '            obeDetalleRecepcion.vc_Usuario = objSeguridadBN.pUsuario

        '        End With
        '        olistDetalleRecepcion.Add(obeDetalleRecepcion)
        '    Next
        '    obeRecepcionABB.ListaDetalleRecepcion = olistDetalleRecepcion.ToArray()
        'End With
        'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
        'Dim obeRecepcionABB As New WSABB.IntegracionABB.beRecepcion

        Dim oIntegracionABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.IntegracionABB(CodCliente)
        Dim obeRecepcionABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beRecepcion

        Dim obeDespacho As New Ransa.TypeDef.beDespacho
        obeDespacho.PNCCLNT = Me.txtCliente.pCodigo
        obeDespacho.PNNGUIRN = pdecGuiaRansa

        obeRecepcionABB = retornoListaEnvioRecepcion(pdecGuiaRansa)


        Dim x As New Xml.Serialization.XmlSerializer(obeRecepcionABB.GetType)
        Dim sw As New IO.StringWriter()
        x.Serialize(sw, obeRecepcionABB)
        'MessageBox.Show(sw.ToString())

        Dim a As String = sw.ToString()

        'Dim obeResultado As WSABB.IntegracionABB.beResultado
        Dim obeResultado As Ransa.NEGO.ProxyRansa.WSABB.Integracion.beResultado
        Dim BdConexionCliente As String = ""
        'Dim server As String = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.Server()
        'If server = RANSA.Utilitario.HelpClass.ServerRANSA01 Or server = RANSA.Utilitario.HelpClass.ServerRANSAT01 Then
        '    BdConexionCliente = "DESARROLLO"
        'End If
        'If server = RANSA.Utilitario.HelpClass.ServerRANSA Then
        '    BdConexionCliente = "PRODUCCION"
        'End If
        'obeResultado = oIntegracionABB.Integracion_Insertar_Recepcion(BdConexionCliente, obeRecepcionABB)
        obeResultado = oIntegracionABB.Integracion_Insertar_Recepcion(CodCliente, obeRecepcionABB)
        'obeResultado = oIntegracionABB.Integracion_Insertar_Recepcion("PRODUCCION", obeRecepcionABB)
        If obeResultado.Codigo <> 1 Then
            MessageBox.Show("Error : " & obeResultado.Codigo & Chr(10) & "Descripción :" & obeResultado.Mensaje, "Error en el envío")
            Exit Sub
        Else

            MessageBox.Show("Se envió Ok", "Se envió con éxito", MessageBoxButtons.OK)

        End If

        Dim objDespacho As New brDespacho
        Dim obeConfirmacion As New beDespacho

        With obeConfirmacion
            .PSCTPIS = "I"
            .PNCCLNT = obeDespacho.PNCCLNT
            .PNNGUIRN = obeDespacho.PNNGUIRN
            '.PNFRLZSR = oDtCab.Rows(0).Item("FRLZSR")
            .PSSTPODP = objSeguridadBN.pstrTipoAlmacen
            .PNNPRTIN = 0
            .PSSTRNSM = "X"
            .PNFTRNSM = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
            .PNHTRNSM = Convert.ToDecimal(HelpClass.NowNumeric())
            .PSCUSCRT = objSeguridadBN.pUsuario
            .PNFCHCRT = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
            .PNHRACRT = Convert.ToDecimal(HelpClass.NowNumeric())
            .PSCULUSA = objSeguridadBN.pUsuario
            .PNFULTAC = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
            .PNHULTAC = Convert.ToDecimal(HelpClass.NowNumeric())
        End With

        Dim rpta As Integer = 1
        rpta = objDespacho.fintRegistrarEnvioInterfaz(obeConfirmacion)
        'If rpta = 0 Then
        '    MessageBox.Show("Error al Registrar Envio Interfaz", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

    End Sub

    'Private Function DespachoInterfaz(ByVal pdecGuiaRansa) As WSABB.IntegracionABB.beDespacho
    Private Function DespachoInterfaz(ByVal pdecGuiaRansa) As Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDespacho
        Dim obrDespacho As New Ransa.NEGO.brDespacho
        Dim obeDespachoFiltro As New Ransa.TypeDef.beDespacho
        Dim olbeDespacho As New List(Of Ransa.TypeDef.beDespacho)
        obeDespachoFiltro.PNCCLNT = Me.txtCliente.pCodigo
        obeDespachoFiltro.PNNGUIRN = pdecGuiaRansa
        olbeDespacho = obrDespacho.ListaParaExportarABB(obeDespachoFiltro)
        'If olbeDespacho.Count > 0 Then
        'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
        'Dim obeDespachoABB As New WSABB.IntegracionABB.beDespacho
        Dim oIntegracionABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.IntegracionABB(Me.txtCliente.pCodigo.ToString.Trim)
        Dim obeDespachoABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDespacho

        'Ransa.NEGO.ProxyRansa.WSABB.Integracion

        With obeDespachoABB
            .vc_RansaOutGuide = obeDespachoFiltro.PNNGUIRN
            .dt_ReferralGuideDate = Date.Parse(HelpClass.CNumero_a_Fecha(olbeDespacho.Item(0).PNFRLZSR.ToString))
            .vc_TransferReason = ""
            .vc_HomeName = olbeDespacho.Item(0).PSTCMPCL
            .vc_HomeAddress = olbeDespacho.Item(0).PSTDRCOR
            .vc_CustomerCodeDeliver = olbeDespacho.Item(0).PSCPRPCL.Trim
            .vc_CustomerFiscalCodeDeliver = olbeDespacho.Item(0).PSNRUCPR
            .vc_CustomerAddressDeliverLine1 = olbeDespacho.Item(0).PSTDRPCP
            .vc_CustomerAddressDeliverLine2 = olbeDespacho.Item(0).PSTDRDST
            .vc_CustomerAddressLine3 = ""
            .vc_CustomerFiscalName = olbeDespacho.Item(0).PSTPRVCL
            .vc_VehiclePlate = olbeDespacho.Item(0).PSNPLCCM
            .vc_TransportCarrierName = olbeDespacho.Item(0).PSTCMPTR
            .vc_TransportCarrierFiscalCode = olbeDespacho.Item(0).PNNRUCT
            .vc_TransportCarrierAddress = olbeDespacho.Item(0).PSTDRCTR
            .vc_Driver = "" & olbeDespacho.Item(0).PSTNMBCH & ""
            .vc_DriversLicense = "" & olbeDespacho.Item(0).PSNBRVCH & ""
            .vc_ReferralGuideComments = ""
            .vc_Usuario = objSeguridadBN.pUsuario
            .vc_OrderNumber = olbeDespacho.Item(0).PSNRFRPD
            .vc_OrderType = olbeDespacho.Item(0).PSNRFTPD
        End With
        'Dim obelistDetalleDespachoABB As New List(Of WSABB.IntegracionABB.beDetalleDespacho)
        Dim obelistDetalleDespachoABB As New List(Of Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDetalleDespacho)
        For Each obeDespacho As beDespacho In olbeDespacho
            'Dim obeDetalleDespachoABB As New WSABB.IntegracionABB.beDetalleDespacho
            Dim obeDetalleDespachoABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDetalleDespacho

            With obeDetalleDespachoABB
                .vc_OrderNumber = obeDespacho.PSNRFRPD
                .vc_OrderType = obeDespacho.PSNRFTPD
                .in_OrderLine = Val(obeDespacho.PSNLTECL)
                .vc_StockCode = obeDespacho.PSCMRCLR
                If obeDespacho.PSDEMERCA.Trim.Length > 50 Then
                    .vc_LineDescriptionLine1 = obeDespacho.PSDEMERCA.Trim.Substring(0, 50)
                    .vc_LineDescriptionLine2 = obeDespacho.PSDEMERCA
                Else
                    .vc_LineDescriptionLine1 = obeDespacho.PSDEMERCA.Trim
                    .vc_LineDescriptionLine2 = ""
                End If
                .vc_UnitMeasure = obeDespacho.PSCUNCN6  'UNIDA DE MEDIDA
                .fl_Quantity = obeDespacho.PNQTRMC
                .vc_Usuario = objSeguridadBN.pUsuario
                .vc_ReferenceGuide = obeDespacho.PSGUIA
            End With

            'Dim obelistSerie As New List(Of WSABB.IntegracionABB.beSerie)
            Dim obelistSerie As New List(Of Ransa.NEGO.ProxyRansa.WSABB.Integracion.beSerie)
            Dim intCorrelativo As Integer = 0

            Dim olBeSerie As New List(Of Ransa.TypeDef.beDespacho)
            olBeSerie = obrDespacho.ListaSerieExportarABB(obeDespacho)
            For Each obeSeri As Ransa.TypeDef.beDespacho In olBeSerie
                'Dim obeSerie As New WSABB.IntegracionABB.beSerie
                Dim obeSerie As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beSerie
                intCorrelativo = intCorrelativo + 1
                With obeSerie
                    '==========Cabecera Despacho
                    .in_IdSerie = intCorrelativo.ToString
                    '.in_ReferralGuideLine(", intEstado_D.ToString)")
                    '.in_ReferralGuideNumber(", intEstado_C.ToString)")
                    .vc_StockCode = obeSeri.PSCMRCLR
                    .vc_NumeroSerie = obeSeri.PSCSRECL
                End With
                obelistSerie.Add(obeSerie)
            Next

            obeDetalleDespachoABB.listSerie = obelistSerie.ToArray()
            obelistDetalleDespachoABB.Add(obeDetalleDespachoABB)
        Next
        obeDespachoABB.listDetalleDespacho = obelistDetalleDespachoABB.ToArray()

        Return obeDespachoABB
    End Function
    Private Sub fEnviarDespachoABB(CodCliente As String, ByVal pdecGuiaRansa As Decimal)

        'Dim obrDespacho As New Ransa.NEGO.brDespacho
        'Dim obeDespachoFiltro As New Ransa.TYPEDEF.beDespacho
        'Dim olbeDespacho As New List(Of Ransa.TYPEDEF.beDespacho)
        'obeDespachoFiltro.PNCCLNT = Me.txtCliente.pCodigo
        'obeDespachoFiltro.PNNGUIRN = pdecGuiaRansa
        'olbeDespacho = obrDespacho.ListaParaExportarABB(obeDespachoFiltro)
        'If olbeDespacho.Count > 0 Then
        '    Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
        '    Dim obeDespachoABB As New WSABB.IntegracionABB.beDespacho

        '    With obeDespachoABB
        '        .vc_RansaOutGuide = obeDespachoFiltro.PNNGUIRN
        '        .dt_ReferralGuideDate = Date.Parse(HelpClass.CNumero_a_Fecha(olbeDespacho.Item(0).PNFRLZSR.ToString))
        '        .vc_TransferReason = ""
        '        .vc_HomeName = olbeDespacho.Item(0).PSTCMPCL
        '        .vc_HomeAddress = olbeDespacho.Item(0).PSTDRCOR
        '        .vc_CustomerCodeDeliver = olbeDespacho.Item(0).PSCPRPCL.Trim
        '        .vc_CustomerFiscalCodeDeliver = olbeDespacho.Item(0).PSNRUCPR
        '        .vc_CustomerAddressDeliverLine1 = olbeDespacho.Item(0).PSTDRPCP
        '        .vc_CustomerAddressDeliverLine2 = olbeDespacho.Item(0).PSTDRDST
        '        .vc_CustomerAddressLine3 = ""
        '        .vc_CustomerFiscalName = olbeDespacho.Item(0).PSTPRVCL
        '        .vc_VehiclePlate = olbeDespacho.Item(0).PSNPLCCM
        '        .vc_TransportCarrierName = olbeDespacho.Item(0).PSTCMPTR
        '        .vc_TransportCarrierFiscalCode = olbeDespacho.Item(0).PNNRUCT
        '        .vc_TransportCarrierAddress = olbeDespacho.Item(0).PSTDRCTR
        '        .vc_Driver = "" & olbeDespacho.Item(0).PSTNMBCH & ""
        '        .vc_DriversLicense = "" & olbeDespacho.Item(0).PSNBRVCH & ""
        '        .vc_ReferralGuideComments = ""
        '        .vc_Usuario = objSeguridadBN.pUsuario
        '        .vc_OrderNumber = olbeDespacho.Item(0).PSNRFRPD
        '        .vc_OrderType = olbeDespacho.Item(0).PSNRFTPD
        '    End With
        '    Dim obelistDetalleDespachoABB As New List(Of WSABB.IntegracionABB.beDetalleDespacho)
        '    For Each obeDespacho As beDespacho In olbeDespacho
        '        Dim obeDetalleDespachoABB As New WSABB.IntegracionABB.beDetalleDespacho

        '        With obeDetalleDespachoABB
        '            .vc_OrderNumber = obeDespacho.PSNRFRPD
        '            .vc_OrderType = obeDespacho.PSNRFTPD
        '            .in_OrderLine = Val(obeDespacho.PSNLTECL)
        '            .vc_StockCode = obeDespacho.PSCMRCLR
        '            If obeDespacho.PSDEMERCA.Trim.Length > 50 Then
        '                .vc_LineDescriptionLine1 = obeDespacho.PSDEMERCA.Trim.Substring(0, 50)
        '                .vc_LineDescriptionLine2 = obeDespacho.PSDEMERCA
        '            Else
        '                .vc_LineDescriptionLine1 = obeDespacho.PSDEMERCA.Trim
        '                .vc_LineDescriptionLine2 = ""
        '            End If
        '            .vc_UnitMeasure = obeDespacho.PSCUNCN6  'UNIDA DE MEDIDA
        '            .fl_Quantity = obeDespacho.PNQTRMC
        '            .vc_Usuario = objSeguridadBN.pUsuario
        '            .vc_ReferenceGuide = obeDespacho.PSGUIA
        '        End With

        '        Dim obelistSerie As New List(Of WSABB.IntegracionABB.beSerie)
        '        Dim intCorrelativo As Integer = 0

        '        Dim olBeSerie As New List(Of Ransa.TYPEDEF.beDespacho)
        '        olBeSerie = obrDespacho.ListaSerieExportarABB(obeDespacho)
        '        For Each obeSeri As Ransa.TYPEDEF.beDespacho In olBeSerie
        '            Dim obeSerie As New WSABB.IntegracionABB.beSerie
        '            intCorrelativo = intCorrelativo + 1
        '            With obeSerie
        '                '==========Cabecera Despacho
        '                .in_IdSerie = intCorrelativo.ToString
        '                '.in_ReferralGuideLine(", intEstado_D.ToString)")
        '                '.in_ReferralGuideNumber(", intEstado_C.ToString)")
        '                .vc_StockCode = obeSeri.PSCMRCLR
        '                .vc_NumeroSerie = obeSeri.PSCSRECL
        '            End With
        '            obelistSerie.Add(obeSerie)
        '        Next

        '        obeDetalleDespachoABB.listSerie = obelistSerie.ToArray()
        '        obelistDetalleDespachoABB.Add(obeDetalleDespachoABB)
        '    Next
        '    obeDespachoABB.listDetalleDespacho = obelistDetalleDespachoABB.ToArray()

        Dim obeDespachoFiltro As New Ransa.TypeDef.beDespacho
        'Dim olbeDespacho As New List(Of Ransa.TYPEDEF.beDespacho)
        obeDespachoFiltro.PNCCLNT = Me.txtCliente.pCodigo
        obeDespachoFiltro.PNNGUIRN = pdecGuiaRansa

        'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
        'Dim obeDespachoABB As New WSABB.IntegracionABB.beDespacho
        Dim oIntegracionABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.IntegracionABB(CodCliente)
        Dim obeDespachoABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDespacho

        obeDespachoABB = DespachoInterfaz(pdecGuiaRansa)

        Dim x As New Xml.Serialization.XmlSerializer(obeDespachoABB.GetType)
        Dim sw As New IO.StringWriter()
        x.Serialize(sw, obeDespachoABB)
        Dim a As String = sw.ToString()


        Dim obeResultado As Ransa.NEGO.ProxyRansa.WSABB.Integracion.beResultado
        'Dim obeResultado As WSABB.IntegracionABB.beResultado

        'Dim BdConexionCliente As String = ""
        'Dim server As String = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.Server()
        'If server = Ransa.Utilitario.HelpClass.ServerRANSA01 Or server = Ransa.Utilitario.HelpClass.ServerRANSAT01 Then
        '    BdConexionCliente = "DESARROLLO"
        'End If
        'If server = Ransa.Utilitario.HelpClass.ServerRANSA Then
        '    BdConexionCliente = "PRODUCCION"
        'End If
        'obeResultado = oIntegracionABB.Integracion_Insertar_Despacho(BdConexionCliente, obeDespachoABB)
        obeResultado = oIntegracionABB.Integracion_Insertar_Despacho(CodCliente, obeDespachoABB)

        'obeResultado = oIntegracionABB.Integracion_Insertar_Despacho("PRODUCCION", obeDespachoABB)
        If obeResultado.Codigo <> 1 Then
            MessageBox.Show("Error : " & obeResultado.Codigo & Chr(10) & "Descripción :" & obeResultado.Mensaje, "Error en el envío")
            Exit Sub
        Else

            MessageBox.Show("Se envió Ok", "Se envio con éxito", MessageBoxButtons.OK)

        End If
        'Else
        'Exit Sub
        'End If



        Dim objDespacho As New brDespacho
        Dim obeConfirmacion As New beDespacho

        With obeConfirmacion
            .PSCTPIS = "S"
            .PNCCLNT = obeDespachoFiltro.PNCCLNT
            .PNNGUIRN = obeDespachoFiltro.PNNGUIRN
            '.PNFRLZSR = oDtCab.Rows(0).Item("FRLZSR")
            .PSSTPODP = objSeguridadBN.pstrTipoAlmacen
            .PNNPRTIN = 0
            .PSSTRNSM = "X"
            .PNFTRNSM = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
            .PNHTRNSM = Convert.ToDecimal(HelpClass.NowNumeric())
            .PSCUSCRT = objSeguridadBN.pUsuario
            .PNFCHCRT = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
            .PNHRACRT = Convert.ToDecimal(HelpClass.NowNumeric())
            .PSCULUSA = objSeguridadBN.pUsuario
            .PNFULTAC = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
            .PNHULTAC = Convert.ToDecimal(HelpClass.NowNumeric())
        End With

        Dim rpta As Integer = 1
        rpta = objDespacho.fintRegistrarEnvioInterfaz(obeConfirmacion)
        'If rpta = 0 Then
        '    MessageBox.Show("Error al Registrar Envio Interfaz", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

    End Sub

    Private Sub EnviarRecepcionOutotec(ByVal pdecGuiaRansa)

        Dim obrRecepcion As New Ransa.NEGO.brMercaderia
        Dim beFiltro As New beDespacho
        Dim oDs As DataSet

        With beFiltro
            .PNCCLNT = Me.txtCliente.pCodigo
            .PNNGUIRN = pdecGuiaRansa '
        End With
        oDs = obrRecepcion.fdtListaParaExportarOutotecRecepcion(beFiltro)
        If oDs.Tables.Count = 0 Then Exit Sub
        Dim obeCabInterfazOutotec As beCabInfzOutotec
        Dim olbeDetInterfazOutotec As List(Of beDetInfzOutotec)
        Dim oDtCab As DataTable
        Dim oDtDet As DataTable
        Dim oDtSerie As DataTable
        oDtCab = oDs.Tables(0).Copy
        oDtDet = oDs.Tables(1).Copy
        oDtSerie = oDs.Tables(2).Copy
        If oDtCab.Rows.Count = 0 Then Exit Sub

        ''Proyecto Outotec
        Dim obrInterfaz As New brInterfazOutoTec
        Dim obrGeneral As New brGeneral
        '================registro de cabecera========================
        obeCabInterfazOutotec = New beCabInfzOutotec
        With obeCabInterfazOutotec
            .ctpdoc = "PE"
            .codcli = oDtCab.Rows(0).Item("CCLNT")
            .npensa = oDtCab.Rows(0).Item("NGUIRN") '"??"
            .calmac = oDtCab.Rows(0).Item("ALMAOT")
            .femisi = HelpClass.CNumero_a_Fecha(oDtCab.Rows(0).Item("FRLZSR"))
            .cconce = oDtCab.Rows(0).Item("TDSDES").ToString.Trim
            .ctpode = oDtCab.Rows(0).Item("TIPORG")
            .coride = oDtCab.Rows(0).Item("CPRPCL")
            .ctpref = oDtCab.Rows(0).Item("TIPORI")
            .ndcref = oDtCab.Rows(0).Item("NGUICL")
            .dobser = oDtCab.Rows(0).Item("TOBSRV")
            .ctporc = oDtCab.Rows(0).Item("TPOOCM")

            'Validamos si los conceptos tienen Oc
            Select Case oDtCab.Rows(0).Item("TDSDES").ToString.Trim
                Case "01", "03", "04", "09", "18" '"02", "03", "04", "06", "09", "11", "13", "16"
                    .nordco = oDtCab.Rows(0).Item("NORCCL")
                Case Else
                    .nordco = ""
            End Select
            .spensa = "E"
            .sentat = BuscarEntregaTiempo(oDtCab)
            .semboc = oDtCab.Rows(0).Item("SCNEMB")
            .fstatu = Now.Date
            If objSeguridadBN.pUsuario.Trim.Length > 6 Then
                .cusuar = objSeguridadBN.pUsuario.Trim.Substring(1, 6)
            Else
                .cusuar = objSeguridadBN.pUsuario
            End If
        End With
        '================registro de detalle=========================
        olbeDetInterfazOutotec = New List(Of beDetInfzOutotec)
        Dim intNRow As Integer = 1
        Dim _oListaProyecto As List(Of beProyecto)
        Dim obeProyecto As New beProyecto
        Dim oDv() As DataRow
        Dim oDvSerie() As DataRow
        For Each oDr As DataRow In oDtCab.Rows
            _oListaProyecto = New List(Of beProyecto)
            oDv = oDtDet.Select("NORDSR =" + oDr.Item("NORDSR").ToString + " AND NSLCSR =" + oDr.Item("NSLCSR").ToString + " ")

            For Each oDrDet As DataRow In oDv
                obeProyecto = New beProyecto
                obeProyecto.PSNRFRPD = oDrDet.Item("NRFRPD")
                obeProyecto.PSNORCML = oDrDet.Item("NORCML")
                obeProyecto.PNNRITOC = oDrDet.Item("NRITOC")
                obeProyecto.PNQCNTIT2 = oDrDet.Item("QTRMC")
                obeProyecto.PSCMRCLR = oDr.Item("CMRCLR")
                _oListaProyecto.Add(obeProyecto)
            Next

            Dim obeDetInterfazOutotec As New beDetInfzOutotec
            With obeDetInterfazOutotec
                .nordsr = oDr.Item("NORDSR")
                .NSLCSR = oDr.Item("NSLCSR")
                .nritoc = oDr.Item("NRITOC")
                .ctpdoc = "PE"
                .npensa = obeCabInterfazOutotec.npensa
                .codcli = oDr.Item("CCLNT")
                .norden = intNRow
                .citems = oDr.Item("CMRCLR")
                .cunmed = oDr.Item("CUNCN5")
                .qitems = oDr.Item("QTRMC")
                .cubica = IIf(oDr.Item("TCMPAL").ToString.Length > 30, oDr.Item("TCMPAL").ToString.Substring(0, 30), oDr.Item("TCMPAL").ToString.Trim)
                .olistaProyecto = _oListaProyecto
            End With
            olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
            intNRow = intNRow + 1
        Next

        Dim olbeDetInterfaz As New List(Of beDetInfzOutotec)
        Dim intRow As Integer = 1
        Dim intCantidadProyecto As Integer = 0
        Dim olbeProyecto As List(Of beProyecto)
        Dim olbeProyectoTemp As List(Of beProyecto)
        Dim obeDetIntFaz As beDetInfzOutotec
        Dim oCloneList As New CloneObject(Of beDetInfzOutotec)

        For Each obeDetInterfazOutotec As beDetInfzOutotec In olbeDetInterfazOutotec
            oDvSerie = oDtSerie.Select("NORDSR =" + obeDetInterfazOutotec.nordsr.ToString + " AND NSLCSI =" + obeDetInterfazOutotec.NSLCSR.ToString + " ")
            olbeProyecto = obeDetInterfazOutotec.olistaProyecto
            If oDvSerie.Length > 0 Then
                If oDvSerie.Length = obeDetInterfazOutotec.qitems Then
                    For Each oDrSer As DataRow In oDvSerie
                        obeDetIntFaz = oCloneList.CloneObject(obeDetInterfazOutotec)

                        obeDetIntFaz.norden = intRow
                        obeDetIntFaz.qitems = 1
                        obeDetIntFaz.nserie = oDrSer.Item("CSRECL")

                        If Not obeDetIntFaz.olistaProyecto Is Nothing Then
                            obeProyecto = New beProyecto
                            olbeProyectoTemp = New List(Of beProyecto)
                            For Each obeProyec As beProyecto In olbeProyecto
                                If obeProyec.PNQCNTIT2 >= obeDetIntFaz.qitems Then
                                    obeProyecto.PSNRFRPD = obeProyec.PSNRFRPD
                                    obeProyecto.PNQCNTIT2 = obeDetIntFaz.qitems
                                    olbeProyectoTemp.Add(obeProyecto)
                                    obeProyec.PNQCNTIT2 = obeProyec.PNQCNTIT2 - obeDetIntFaz.qitems
                                    Exit For
                                End If
                            Next
                            obeDetIntFaz.olistaProyecto = olbeProyectoTemp
                        End If

                        olbeDetInterfaz.Add(obeDetIntFaz)
                        intRow = intRow + 1

                    Next
                Else
                    'clonamos la entiada 
                    obeDetIntFaz = oCloneList.CloneObject(obeDetInterfazOutotec)

                    obeDetIntFaz.norden = intRow
                    obeDetIntFaz.qitems = obeDetInterfazOutotec.qitems - oDvSerie.Length

                    'asociamos el item al proyecto
                    If Not obeDetIntFaz.olistaProyecto Is Nothing Then
                        obeProyecto = New beProyecto
                        olbeProyectoTemp = New List(Of beProyecto)
                        For Each obeProyec As beProyecto In olbeProyecto
                            obeProyecto = New beProyecto
                            intCantidadProyecto = obeProyec.PNQCNTIT2 + intCantidadProyecto
                            If intCantidadProyecto >= obeDetIntFaz.qitems Then
                                obeProyecto.PSNRFRPD = obeProyec.PSNRFRPD
                                obeProyecto.PNQCNTIT2 = obeDetIntFaz.qitems + obeProyec.PNQCNTIT2 - intCantidadProyecto
                                olbeProyectoTemp.Add(obeProyecto)
                                obeProyec.PNQCNTIT2 = obeProyec.PNQCNTIT2 - obeProyecto.PNQCNTIT2
                                Exit For
                            ElseIf obeProyec.PNQCNTIT2 <> 0 Then
                                obeProyecto.PNQCNTIT2 = obeProyec.PNQCNTIT2
                                obeProyecto.PSNRFRPD = obeProyec.PSNRFRPD
                                olbeProyectoTemp.Add(obeProyecto)
                            End If
                        Next
                        obeDetIntFaz.olistaProyecto = olbeProyectoTemp
                    End If
                    olbeDetInterfaz.Add(obeDetIntFaz)
                    intRow = intRow + 1

                    For Each oDrSer As DataRow In oDvSerie
                        obeDetIntFaz = oCloneList.CloneObject(obeDetInterfazOutotec)

                        obeDetIntFaz.norden = intRow
                        obeDetIntFaz.qitems = 1
                        obeDetIntFaz.nserie = oDrSer.Item("CSRECL")

                        'Asociamos el item al proyecto
                        If Not obeDetIntFaz.olistaProyecto Is Nothing Then
                            obeProyecto = New beProyecto
                            olbeProyectoTemp = New List(Of beProyecto)
                            For Each obeProyec As beProyecto In olbeProyecto
                                If obeProyec.PNQCNTIT2 >= obeDetIntFaz.qitems Then
                                    obeProyecto.PSNRFRPD = obeProyec.PSNRFRPD
                                    obeProyecto.PNQCNTIT2 = obeDetIntFaz.qitems
                                    olbeProyectoTemp.Add(obeProyecto)
                                    obeProyec.PNQCNTIT2 = obeProyec.PNQCNTIT2 - obeDetIntFaz.qitems
                                    Exit For
                                End If
                            Next
                            obeDetIntFaz.olistaProyecto = olbeProyectoTemp
                        End If
                        olbeDetInterfaz.Add(obeDetIntFaz)
                        intRow = intRow + 1
                    Next
                End If
            Else
                obeDetInterfazOutotec.norden = intRow
                olbeDetInterfaz.Add(obeDetInterfazOutotec)
                intRow = intRow + 1
            End If
        Next

        olbeDetInterfazOutotec = Nothing
        olbeDetInterfazOutotec = olbeDetInterfaz

        If obrInterfaz.fintInsertarProceso(obeCabInterfazOutotec, olbeDetInterfazOutotec) = -1 Then
            HelpClass.MsgBox("Error en el proceso de envio a Outotec, Notifique este evento al Dpto. de Sistemas.")
        Else
            Dim objDespacho As New brDespacho
            Dim obeDespacho As New beDespacho

            With obeDespacho
                .PSCTPIS = "I"
                .PNCCLNT = oDtCab.Rows(0).Item("CCLNT")
                .PNNGUIRN = oDtCab.Rows(0).Item("NGUIRN")
                .PNFRLZSR = oDtCab.Rows(0).Item("FRLZSR")
                .PSSTPODP = objSeguridadBN.pstrTipoAlmacen
                .PNNPRTIN = 0
                .PSSTRNSM = "X"
                .PNFTRNSM = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                .PNHTRNSM = Convert.ToDecimal(HelpClass.NowNumeric())
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PNFCHCRT = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                .PNHRACRT = Convert.ToDecimal(HelpClass.NowNumeric())
                .PSCULUSA = objSeguridadBN.pUsuario
                .PNFULTAC = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                .PNHULTAC = Convert.ToDecimal(HelpClass.NowNumeric())
            End With

            Dim rpta As Integer = 1
            rpta = objDespacho.fintRegistrarEnvioInterfaz(obeDespacho)
            If rpta = 0 Then
                MessageBox.Show("Error al Registrar Envio Interfaz", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Function BuscarEntregaTiempo(ByVal oDt As DataTable) As String
        Dim decFechaActual As Decimal = oDt.Rows(0).Item("FRLZSR") ' Now.Date.ToString
        Dim decFechaMaxEntrega As Decimal = 0
        For intCont As Integer = 0 To oDt.Rows.Count - 1
            If Not oDt.Rows(intCont).Item("FMPDME").ToString.Equals("0") Then
                decFechaMaxEntrega = oDt.Rows(intCont).Item("FMPDME")
                Exit For
            End If
        Next
        If decFechaActual > decFechaMaxEntrega Then
            Return "N"
        Else
            Return "S"
        End If
    End Function

    Private Sub EnviarDespachoOutotec(ByVal pdecSalida As Decimal)

        Dim obrDespacho As New Ransa.NEGO.brDespacho
        Dim beFiltro As New Ransa.TypeDef.beDespacho
        Dim obrGeneral As New brGeneral
        Dim obrInterfaz As New brInterfazOutoTec
        Dim oDs As DataSet

        With beFiltro
            .PNCCLNT = Me.txtCliente.pCodigo
            .PNNGUIRN = pdecSalida 'Me.dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value
        End With
        oDs = obrDespacho.fdtListaParaExportarOutotecDespacho(beFiltro)

        If oDs.Tables.Count = 0 Then Exit Sub

        Dim obeCabInterfazOutotec As New beCabInfzOutotec
        Dim olbeDetInterfazOutotec As New List(Of beDetInfzOutotec)
        Dim oDtCab As DataTable
        Dim oDtDet As DataTable
        Dim oDv() As DataRow
        oDtCab = oDs.Tables(0)
        oDtDet = oDs.Tables(1)

        '================registro de cabecera========================

        With obeCabInterfazOutotec
            .ctpdoc = "PS"
            .npensa = oDtCab.Rows(0).Item("NGUIRN")  '"??"
            .codcli = oDtCab.Rows(0).Item("CCLNT")
            .calmac = oDtCab.Rows(0).Item("ALMAOT")
            .femisi = HelpClass.CNumero_a_Fecha(oDtCab.Rows(0).Item("FRLZSR"))
            .cconce = oDtCab.Rows(0).Item("TDSDES").ToString.Trim
            .ctpode = oDtCab.Rows(0).Item("TIPORG")
            .coride = oDtCab.Rows(0).Item("CPRPCL")
            .ctpref = oDtCab.Rows(0).Item("TIPORI")
            .ndcref = oDtCab.Rows(0).Item("NGUICL")
            .dobser = oDtCab.Rows(0).Item("TOBSRV")
            .nordpr = oDtCab.Rows(0).Item("NRFRPD")
            .noccli = oDtCab.Rows(0).Item("TOBSMD") 'Nr. Oc Cliente
            .spensa = "E"
            .fstatu = Now.Date
            .sgaran = "N"
            If objSeguridadBN.pUsuario.Trim.Length > 6 Then
                .cusuar = objSeguridadBN.pUsuario.Trim.Substring(1, 6)
            Else
                .cusuar = objSeguridadBN.pUsuario
            End If
        End With

        '================registro de detalle=========================

        Dim olbeListProyecto As New List(Of beProyecto)

        Dim intNRow As Integer = 1
        Dim obeDetInterfazOutotec As beDetInfzOutotec
        Dim obeProyecto As New beProyecto
        For Each oDr As DataRow In oDtCab.Rows
            oDv = oDtDet.Select("NORDSR =" + oDr.Item("NORDSR").ToString + " AND NSLCSS =" + oDr.Item("NSLCSR").ToString + " ")

            If oDv.Length > 0 Then
                If oDv.Length = oDr.Item("QTRMC") Then
                    For Each oDrDet As DataRow In oDv
                        obeDetInterfazOutotec = New beDetInfzOutotec
                        olbeListProyecto = New List(Of beProyecto)
                        obeProyecto = New beProyecto
                        With obeProyecto
                            .PSNRFRPD = oDr.Item("NRFRPD")
                            .PNQCNTIT2 = 1 ' va solo Uno
                        End With
                        olbeListProyecto.Add(obeProyecto)
                        With obeDetInterfazOutotec
                            .ctpdoc = "PS"
                            .npensa = obeCabInterfazOutotec.npensa
                            .codcli = oDr.Item("CCLNT")
                            .norden = intNRow
                            .citems = oDr.Item("CMRCLR")
                            .cunmed = oDr.Item("CUNCN5")
                            .qitems = 1 'Va uno
                            .norped = 1 '
                            .nserie = oDrDet.Item("CSRECL").ToString.Trim
                            .cubica = IIf(oDr.Item("TCMPAL").ToString.Length > 30, oDr.Item("TCMPAL").ToString.Substring(0, 30), oDr.Item("TCMPAL").ToString.Trim)
                            .olistaProyecto = olbeListProyecto
                        End With
                        olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                        intNRow = intNRow + 1
                    Next
                Else
                    obeDetInterfazOutotec = New beDetInfzOutotec
                    olbeListProyecto = New List(Of beProyecto)
                    obeProyecto = New beProyecto
                    With obeProyecto
                        .PSNRFRPD = oDr.Item("NRFRPD")
                        .PNQCNTIT2 = oDr.Item("QTRMC")
                    End With
                    olbeListProyecto.Add(obeProyecto)
                    With obeDetInterfazOutotec
                        .ctpdoc = "PS"
                        .npensa = obeCabInterfazOutotec.npensa
                        .codcli = oDr.Item("CCLNT")
                        .norden = intNRow
                        .citems = oDr.Item("CMRCLR")
                        .cunmed = oDr.Item("CUNCN5")
                        .qitems = oDr.Item("QTRMC") - oDv.Length
                        .norped = 1 '
                        .cubica = IIf(oDr.Item("TCMPAL").ToString.Length > 30, oDr.Item("TCMPAL").ToString.Substring(0, 30), oDr.Item("TCMPAL").ToString.Trim)
                        .olistaProyecto = olbeListProyecto
                    End With
                    olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                    intNRow = intNRow + 1

                    For Each oDrDet As DataRow In oDv
                        obeDetInterfazOutotec = New beDetInfzOutotec
                        olbeListProyecto = New List(Of beProyecto)
                        obeProyecto = New beProyecto
                        With obeProyecto
                            .PSNRFRPD = oDr.Item("NRFRPD")
                            .PNQCNTIT2 = 1 ' va solo Uno
                        End With
                        olbeListProyecto.Add(obeProyecto)
                        With obeDetInterfazOutotec
                            .ctpdoc = "PS"
                            .npensa = obeCabInterfazOutotec.npensa
                            .codcli = oDr.Item("CCLNT")
                            .norden = intNRow
                            .citems = oDr.Item("CMRCLR")
                            .cunmed = oDr.Item("CUNCN5")
                            .qitems = 1 'Va uno
                            .norped = 1 '
                            .cubica = IIf(oDr.Item("TCMPAL").ToString.Length > 30, oDr.Item("TCMPAL").ToString.Substring(0, 30), oDr.Item("TCMPAL").ToString.Trim)
                            .nserie = oDrDet.Item("CSRECL")
                            .olistaProyecto = olbeListProyecto
                        End With
                        olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                        intNRow = intNRow + 1
                    Next
                End If
            Else
                obeDetInterfazOutotec = New beDetInfzOutotec
                olbeListProyecto = New List(Of beProyecto)
                obeProyecto = New beProyecto
                With obeProyecto
                    .PSNRFRPD = oDr.Item("NRFRPD")
                    .PNQCNTIT2 = oDr.Item("QTRMC") 'obeDesp.PNQTRMC
                End With
                olbeListProyecto.Add(obeProyecto)
                With obeDetInterfazOutotec
                    .ctpdoc = "PS"
                    .npensa = obeCabInterfazOutotec.npensa
                    .codcli = oDr.Item("CCLNT")
                    .norden = intNRow
                    .citems = oDr.Item("CMRCLR")
                    .cunmed = oDr.Item("CUNCN5")
                    .qitems = oDr.Item("QTRMC")
                    .norped = 1 'obeDesp.PSNRFRPD
                    .cubica = IIf(oDr.Item("TCMPAL").ToString.Length > 30, oDr.Item("TCMPAL").ToString.Substring(0, 30), oDr.Item("TCMPAL").ToString.Trim)
                    .olistaProyecto = olbeListProyecto
                End With
                olbeDetInterfazOutotec.Add(obeDetInterfazOutotec)
                intNRow = intNRow + 1
            End If
        Next
        If obrInterfaz.fintInsertarProceso(obeCabInterfazOutotec, olbeDetInterfazOutotec) = -1 Then
            HelpClass.MsgBox("Error en el proceso de envio a Outotec, Notifique este evento al Dpto. de Sistemas.")
        Else
            Dim objDespacho As New brDespacho
            Dim obeDespacho As New beDespacho

            With obeDespacho
                .PSCTPIS = "S"
                .PNCCLNT = oDtCab.Rows(0).Item("CCLNT")
                .PNNGUIRN = oDtCab.Rows(0).Item("NGUIRN")
                .PNFRLZSR = oDtCab.Rows(0).Item("FRLZSR")
                .PSSTPODP = objSeguridadBN.pstrTipoAlmacen
                .PNNPRTIN = 0
                .PSSTRNSM = "X"
                .PNFTRNSM = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                .PNHTRNSM = Convert.ToDecimal(HelpClass.NowNumeric())
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PNFCHCRT = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                .PNHRACRT = Convert.ToDecimal(HelpClass.NowNumeric())
                .PSCULUSA = objSeguridadBN.pUsuario
                .PNFULTAC = Convert.ToDecimal(HelpClass.CtypeDate(DateTime.Today))
                .PNHULTAC = Convert.ToDecimal(HelpClass.NowNumeric())
            End With

            Dim rpta As Integer = 1
            rpta = objDespacho.fintRegistrarEnvioInterfaz(obeDespacho)
            If rpta = 0 Then
                MessageBox.Show("Error al Registrar Envio Interfaz", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        EnviarGuiaRemisionOutotec(obeCabInterfazOutotec.npensa)
    End Sub

    Private Sub EnviarGuiaRemisionOutotec(ByVal pdecSalida As Decimal)
        Dim obrDespacho As New Ransa.NEGO.brDespacho
        Dim obeDespacho As New Ransa.TypeDef.beDespacho
        Dim olbeDespacho As New List(Of Ransa.TypeDef.beDespacho)
        obeDespacho.PNCCLNT = Me.txtCliente.pCodigo
        obeDespacho.PNNGUIRN = pdecSalida


        olbeDespacho = obrDespacho.ListaParaExportarABB(obeDespacho)


        If olbeDespacho.Count > 0 AndAlso olbeDespacho.Item(0).PNNGUIRM <> 0 Then

            ''Proyecto Outotec
            Dim obrInterfaz As New Ransa.NEGO.brInterfazOutoTec
            '================registro de cabecera========================
            Dim obeCabGuiaInfzOutotec As New Ransa.TypeDef.beCabGuiaInfzOutotec
            With obeCabGuiaInfzOutotec
                .nguias = olbeDespacho.Item(0).PNNGUIRM
                .codcli = obeDespacho.PNCCLNT
                .ctpdoc = "PS"
                .nserof = olbeDespacho.Item(0).PSSERIE
                .ndocof = olbeDespacho.Item(0).PSNROFIC
                .npensa = obeDespacho.PNNGUIRN
                .ctpgui = olbeDespacho.Item(0).PSCTPGUI.Trim

                If Not olbeDespacho.Item(0).FechaEmisionGuia Is Nothing AndAlso Not olbeDespacho.Item(0).FechaEmisionGuia.Trim.Equals("") Then
                    .femisi = olbeDespacho.Item(0).FechaEmisionGuia
                Else
                    .femisi = Nothing
                End If
                If Not olbeDespacho.Item(0).FechaInicioTraslado Is Nothing AndAlso Not olbeDespacho.Item(0).FechaInicioTraslado.Trim.Equals("") Then
                    .finitr = olbeDespacho.Item(0).FechaInicioTraslado
                Else
                    .finitr = Nothing
                End If
                .dtpgui = olbeDespacho.Item(0).PSTDSDES.Trim
                .ctpope = olbeDespacho.Item(0).PSNRFTPD
                .nordpr = olbeDespacho.Item(0).PSNRFRPD

                .nordcl = olbeDespacho.Item(0).PSTOBSMD.Trim
                .ddiori = olbeDespacho.Item(0).PSORIGEN
                .ctpode = olbeDespacho.Item(0).PSCLADES
                .coride = olbeDespacho.Item(0).PSTIPCLI
                .ddirec01 = olbeDespacho.Item(0).PSDESTINO
                .nconst = olbeDespacho.Item(0).PSNRGMT1
                .nplaca01 = olbeDespacho.Item(0).PSNPLCCM
                .dobser = olbeDespacho.Item(0).PSTOBSRM
                Select Case olbeDespacho.Item(0).PNTDCFCC
                    Case 1
                        .ctpfac = "FA" 'POR MIENTRAS
                    Case 7
                        .ctpfac = "BO" 'POR MIENTRAS
                End Select
                If Not olbeDespacho.Item(0).FechaContrato Is Nothing AndAlso Not olbeDespacho.Item(0).FechaContrato.Trim.Equals("") Then
                    .fecdoc = olbeDespacho.Item(0).FechaContrato
                    .nfactu01 = olbeDespacho.Item(0).PNNDCFCC
                Else
                    .fecdoc = Nothing
                    .nfactu01 = ""
                End If
                .senlac = "N"
                .sguias = "E"
                .sgepes = "S"
                .clcori = "11" 'temporal
                .cciatr = "22" 'temporal
                .cchofe = "000041" 'tempolar
                .drztra = olbeDespacho.Item(0).PSTCMPTR.Trim
                .cructr = olbeDespacho.Item(0).PNNRUCT
                .dchofe = olbeDespacho.Item(0).PSTNMBCH.Trim
                .nbreve = olbeDespacho.Item(0).PSNBRVCH.Trim
                .qtotpe = olbeDespacho.Item(0).PNQPSGU
                If objSeguridadBN.pUsuario.Length > 6 Then
                    .cusuar = objSeguridadBN.pUsuario.Trim.Substring(1, 6)
                Else
                    .cusuar = objSeguridadBN.pUsuario
                End If
            End With
            If obrInterfaz.fintInsertarCabeceraGuia(obeCabGuiaInfzOutotec) <> -1 Then
                '  ================registro de detalle=========================
                Dim olbeDetGuiaInfzOutotec As New List(Of Ransa.TypeDef.beDetGuiaInfzOutotec)
                Dim intNRow As Integer = 1
                Dim olBeSerie As List(Of Ransa.TypeDef.beDespacho)
                Dim obeDetInterfazOutotec As Ransa.TypeDef.beDetGuiaInfzOutotec

                For Each obeDesp As Ransa.TypeDef.beDespacho In olbeDespacho
                    olBeSerie = New List(Of Ransa.TypeDef.beDespacho)
                    olBeSerie = obrDespacho.ListaSerieExportarABB(obeDesp)

                    If olBeSerie.Count > 0 Then
                        If olBeSerie.Count = obeDesp.PNQTRMC Then
                            For Each obeSerie As Ransa.TypeDef.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                                With obeDetInterfazOutotec
                                    .nguias = obeDesp.PNNGUIRM
                                    .codcli = obeDespacho.PNCCLNT
                                    .norden = intNRow
                                    .citems = obeDesp.PSCMRCLR.Trim
                                    .ditems = obeDesp.PSDEMERCA.Trim
                                    .cunmed = obeDesp.PSCUNCN6.Trim
                                    .qitems = 1
                                    .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                    .qsaldo = 0
                                    .nserie = obeSerie.PSCSRECL.Trim
                                End With
                                olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                                intNRow = intNRow + 1
                            Next
                        Else
                            obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                            With obeDetInterfazOutotec
                                .nguias = obeDesp.PNNGUIRM
                                .codcli = obeDespacho.PNCCLNT
                                .norden = intNRow
                                .citems = obeDesp.PSCMRCLR.Trim
                                .ditems = obeDesp.PSDEMERCA.Trim
                                .cunmed = obeDesp.PSCUNCN6.Trim
                                .qitems = obeDesp.PNQTRMC - olBeSerie.Count
                                .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                .qsaldo = 0
                            End With
                            olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                            intNRow = intNRow + 1

                            For Each obeSerie As Ransa.TypeDef.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                                With obeDetInterfazOutotec
                                    .nguias = obeDesp.PNNGUIRM
                                    .codcli = obeDespacho.PNCCLNT
                                    .norden = intNRow
                                    .citems = obeDesp.PSCMRCLR.Trim
                                    .ditems = obeDesp.PSDEMERCA.Trim
                                    .cunmed = obeDesp.PSCUNCN6.Trim
                                    .qitems = 1
                                    .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                    .qsaldo = 0
                                    .nserie = obeSerie.PSCSRECL.Trim
                                End With
                                olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                                intNRow = intNRow + 1
                            Next
                        End If
                    Else
                        obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                        With obeDetInterfazOutotec
                            .nguias = obeDesp.PNNGUIRM
                            .codcli = obeDespacho.PNCCLNT
                            .norden = intNRow
                            .citems = obeDesp.PSCMRCLR
                            .ditems = obeDesp.PSDEMERCA
                            .cunmed = obeDesp.PSCUNCN6
                            .qitems = obeDesp.PNQTRMC
                            .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                            .qsaldo = 0
                        End With
                        olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                        intNRow = intNRow + 1
                    End If
                Next


                Dim oucOrdena As UCOrdena(Of Ransa.TypeDef.beDetGuiaInfzOutotec)

                oucOrdena = New UCOrdena(Of Ransa.TypeDef.beDetGuiaInfzOutotec)("qunida", UCOrdena(Of Ransa.TypeDef.beDetGuiaInfzOutotec).TipoOrdenacion.Ascendente)
                olbeDetGuiaInfzOutotec.Sort(oucOrdena)

                For intRow As Integer = 0 To olbeDetGuiaInfzOutotec.Count - 1
                    olbeDetGuiaInfzOutotec.Item(intRow).norden = intRow
                Next

                If obrInterfaz.fintInsertarDetalleGuia(olbeDetGuiaInfzOutotec) = -1 Then
                    MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim obrGuia As New DespachoSAT.brGuiasRemision
            Dim objGui As New beGuiaRemision
            With objGui
                .PNCCLNT = obeCabGuiaInfzOutotec.codcli
                .PSNGUIRM = obeCabGuiaInfzOutotec.nguias
                .PSUSUARIO = objSeguridadBN.pUsuario
            End With
            If obrGuia.fintActualizarEnvioGuias(objGui) = 0 Then
                HelpClass.ErrorMsgBox()
            End If

        End If
    End Sub

    Private Sub dgGuiasRansa_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgGuiasRansa.DataBindingComplete
        If Me.dgGuiasRansa.Rows.Count = 0 Then Exit Sub

        For Each oDr As DataGridViewRow In Me.dgGuiasRansa.Rows
            If ("" & oDr.DataBoundItem.PSSTRNSM & "").ToString.Equals("X") Then
                oDr.Cells("TRANSMISION").Value = My.Resources.Enviado
            Else
                oDr.Cells("TRANSMISION").Value = My.Resources.EnBlanco
            End If

        Next


    End Sub

    Private Sub btnTrama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrama.Click
        Try
            If dgGuiasRansa.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ListaClnt As New Hashtable
            Dim obeClnt As New beGeneral
            Dim obrGeneral As New brGeneral
            obeClnt.PSCODVAR = "CLTABB"
            obeClnt.PSCCMPRN = ""
            Dim listaCliente As New List(Of beGeneral)
            listaCliente = obrGeneral.ListaTablaAyuda(obeClnt)
            For Each beGen As beGeneral In listaCliente
                ListaClnt.Add(beGen.PSCCMPRN.Trim, beGen.PSCCMPRN.Trim)
            Next

            If Not ListaClnt.Contains(Me.txtCliente.pCodigo.ToString.Trim) Then
                Exit Sub
            End If

            If dgGuiasRansa.CurrentRow.Cells("GS_CTPOAT").Value = "I" Then

                'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
                Dim obeRecepcionABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beRecepcion
                obeRecepcionABB = retornoListaEnvioRecepcion(dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value)
                Dim x As New Xml.Serialization.XmlSerializer(obeRecepcionABB.GetType)
                Dim sw As New IO.StringWriter()
                x.Serialize(sw, obeRecepcionABB)
                Dim a As String = sw.ToString()
                Dim ofrmTrama As New frmTrama
                ofrmTrama.rtexto.Text = sw.ToString()
                ofrmTrama.ShowDialog()
            Else

                'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
                Dim obeDespachoABB As New Ransa.NEGO.ProxyRansa.WSABB.Integracion.beDespacho
                'RANSA.NEGO.ProxyRansa.WSABB.Integracion
                obeDespachoABB = DespachoInterfaz(dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value)

                Dim x As New Xml.Serialization.XmlSerializer(obeDespachoABB.GetType)
                Dim sw As New IO.StringWriter()
                x.Serialize(sw, obeDespachoABB)

                Dim ofrmTrama As New frmTrama
                ofrmTrama.rtexto.Text = sw.ToString()
                ofrmTrama.ShowDialog()


            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub btnTrama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrama.Click
    '    Try
    '        If dgGuiasRansa.CurrentRow Is Nothing Then
    '            Exit Sub
    '        End If
    '        If Me.txtCliente.pCodigo <> 11232 Then
    '            Exit Sub
    '        End If

    '        If dgGuiasRansa.CurrentRow.Cells("GS_CTPOAT").Value = "I" Then

    '            Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
    '            Dim obeRecepcionABB As New WSABB.IntegracionABB.beRecepcion
    '            obeRecepcionABB = retornoListaEnvioRecepcion(dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value)
    '            Dim x As New Xml.Serialization.XmlSerializer(obeRecepcionABB.GetType)
    '            Dim sw As New IO.StringWriter()
    '            x.Serialize(sw, obeRecepcionABB)
    '            Dim a As String = sw.ToString()
    '            Dim ofrmTrama As New frmTrama
    '            ofrmTrama.rtexto.Text = sw.ToString()
    '            ofrmTrama.ShowDialog()
    '        Else

    '            Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
    '            Dim obeDespachoABB As New WSABB.IntegracionABB.beDespacho
    '            obeDespachoABB = DespachoInterfaz(dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value)

    '            Dim x As New Xml.Serialization.XmlSerializer(obeDespachoABB.GetType)
    '            Dim sw As New IO.StringWriter()
    '            x.Serialize(sw, obeDespachoABB)

    '            Dim ofrmTrama As New frmTrama
    '            ofrmTrama.rtexto.Text = sw.ToString()
    '            ofrmTrama.ShowDialog()


    '        End If



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class

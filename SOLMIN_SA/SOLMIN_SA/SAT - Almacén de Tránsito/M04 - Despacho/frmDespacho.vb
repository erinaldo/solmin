Imports NetPacasmayoService
Imports CrystalDecisions.CrystalReports.Engine
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef
Imports RANSA.NEGO
Imports RANSA.NEGO.DespachoSAT
Imports Ransa.Utilitario

Public Class frmDespacho
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        ANULAR
        GENERAR
        RESTAURAR
    End Enum

    Enum eTipoGuiaVisualizar
        SALIDA
        REMISION
    End Enum
#End Region
#Region " Atributos "
    Private booStatus As Boolean = False
    Private _widthLeftRight As Int32
    Private strImprimirEtiqueta As String = ""
    Private eTipoGuia As eTipoGuiaVisualizar
    Private rptTemp As ReportDocument
    Private objCopiarPegar As clsCopiar_Pegar = Nothing
    Private nTipoGuia As Integer = 1
#End Region
#Region " Propiedades "

#End Region

#Region " Procedimientos y Funciones "
    Private Sub pActualizarInformacion()
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            booStatus = False
            '-- Cargamos las Gu�as de Salida
            Call pListarGuiasSalida()
            ' Cargamos las Guias de Remisi�n
            Call pListarGuiasRemision()
            booStatus = True
            'VisorReportesCrystal.ReportSource = Nothing
            '-- Registro los nuevos valores de los campos de los clientes
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("DespachoClienteCodigo", txtClient.pCodigo)
            objAppConfig = Nothing
        End If
    End Sub

    Private Sub pInicioVistaPrevia()
        'pcxEspera.Top = (hgVisorPrevia.Width / 2) - (pcxEspera.Width / 2)
        'pcxEspera.Left = (hgVisorPrevia.Height / 2) - (pcxEspera.Height / 2)
        'pcxEspera.Visible = True
        'bsaVistaPreviaGS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        'bsaVistaPreviaGR.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        'VisorReportesCrystal.Visible = False
        'bgwGifAnimado.RunWorkerAsync()
        'If dgGuiasRemision.RowCount > 1 Then
        '    VisorReportesCrystal.ShowGroupTreeButton = True
        '    VisorReportesCrystal.DisplayGroupTree = True
        'Else
        '    VisorReportesCrystal.ShowGroupTreeButton = False
        '    VisorReportesCrystal.DisplayGroupTree = False
        'End If
    End Sub

    Private Sub pProceso_AnularGuiaSalida()
        If dgGuiasSalidas.RowCount <= 0 Then Exit Sub
        ' Si elige NO entonces salimos del proceso
        If Not mfblnPreguntas(enumPregVarios.PROCESO_AnularGuiaSalida) Then Exit Sub
        If fblnValidaInformacion(eTipoValidacion.ANULAR) Then
            Dim obrGuiasRemision As New brGuiasRemision
            Dim obeGuiaRemision As New beGuiaRemision
            With obeGuiaRemision
                .PNCCLNT = txtClient.pCodigo
                .PNNRGUSA = dgGuiasSalidas.CurrentRow.Cells("GS_NRGUSA").Value.ToString.Trim
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                .PSCUSCRT = objSeguridadBN.pUsuario
            End With
            If obrGuiasRemision.mfblnProceso_AnularGuiaSalida(obeGuiaRemision) Then
                booStatus = False
                '-- Eliminamos el registro seleccionado
                ' dgGuiasSalidas.Rows.Remove(dgGuiasSalidas.CurrentRow)
                '-- Actualizamos la informaci�n de la Gu�a de Remisi�n
                Call pListarGuiasRemision()
                Call Me.pListarGuiasSalida()
                booStatus = True
            End If
        End If
    End Sub

    Private Sub pProceso_GenerarGuiaRemision()
        If dgGuiasSalidas.RowCount <= 0 Then Exit Sub
        If fblnValidaInformacion(eTipoValidacion.GENERAR) Then
            Dim frmGenerarGuiaRemisionSAT As frmGenerarGuiaRemisionSAT = New frmGenerarGuiaRemisionSAT
            With frmGenerarGuiaRemisionSAT
                .pCopiarPegar = objCopiarPegar
                .PNCCLNT = txtClient.pCodigo
                .pNroGuia_NRGUIA = dgGuiasSalidas.CurrentRow.Cells("GS_NRGUSA").Value.ToString.Trim
                .pManifiesto_NMNFTF = dgGuiasSalidas.CurrentRow.Cells("GS_NMNFTF").Value.ToString.Trim
                .pMotivo_SMTRCP = dgGuiasSalidas.CurrentRow.Cells("GS_SMTRCP").Value.ToString.Trim
                .pMotivo_SMTRCP_DET = dgGuiasSalidas.CurrentRow.Cells("GS_MOTREC").Value.ToString.Trim
                ' Informaci�n relacionada a la Empresa de Transporte
                .pstrEmpresaTransporte_CTRSPT = dgGuiasSalidas.CurrentRow.Cells("GS_CTRSPT").Value.ToString.Trim
                .pstrPlacaUnidad_NPLCUN = dgGuiasSalidas.CurrentRow.Cells("GS_NPLCUN").Value.ToString.Trim
                .pstrPlacaAcoplado_NPLCAC = dgGuiasSalidas.CurrentRow.Cells("GS_NPLCAC").Value.ToString.Trim
                .pstrBrevete_CBRCNT = dgGuiasSalidas.CurrentRow.Cells("GS_CBRCNT").Value.ToString.Trim
                .nTipoGuia = nTipoGuia
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    booStatus = False
                    '-- Actualizamos la informaci�n de la Gu�a de Remisi�n
                    Call pListarGuiasRemision()
                    booStatus = True
                End If
                objCopiarPegar = .pCopiarPegar
            End With
        End If
    End Sub

    Private Sub pProceso_RestaurarGuiaSalida()
        If dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
        ' Si elige NO entonces salimos del proceso
        If dgGuiasSalidas.RowCount <= 0 Then Exit Sub
        If Me.dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim obrGuiasRemision As New brGuiasRemision
        Dim obeGuiaRemision As New beGuiaRemision
        With obeGuiaRemision
            .PNCCLNT = txtClient.pCodigo
            .PNCCLNGR = CType(Me.dgGuiasSalidas.CurrentRow.DataBoundItem, beGuiaRemision).PNCCLNGR
            .PNNRGUSA = Me.dgGuiasRemision.CurrentRow.Cells("PNNRGUSA").Value.ToString.Trim
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSCUSCRT = objSeguridadBN.pUsuario
        End With
        'Dim strError As String = ""
        'strError = obrGuiasRemision.fstrValidarGuaiRemision(obeGuiaRemision)
        'If strError.Trim.Length > 0 Then
        '    HelpClass.MsgBox(strError)
        'Else
        'If Not mfblnPreguntas(enumPregVarios.GREMISION_AnularGuiaRemision) Then Exit Sub

        Dim CodEnvioEmision As String = ""
        Dim CodEnvioAnulacion As String = ""
        Dim msg_ As String = ""
        For Each item As DataGridViewRow In dgGuiasRemision.Rows
            CodEnvioEmision = ("" & item.Cells("STRNEG").Value).ToString.Trim
            CodEnvioAnulacion = ("" & item.Cells("STRNAG").Value).ToString.Trim
            If CodEnvioEmision = "S" Then
                If CodEnvioAnulacion <> "S" Then
                    MessageBox.Show("Para la eliminación/anulación las Guías deben tener aceptación de anulación electrónica.")
                    Exit Sub
                End If
            End If
        Next


        If MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de la Guía de Remisión ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        'If fblnValidaInformacion(eTipoValidacion.RESTAURAR) Then
        'If obrGuiasRemision.mfblnProceso_RestaurarGuiaSalida(obeGuiaRemision) Then
        '    booStatus = False
        '    '-- Actualizamos la informaci�n de la Gu�a de Remisi�n
        '    Call pListarGuiasRemision()
        '    booStatus = True
        'End If

        If dgGuiasSalidas.RowCount <= 0 Then
            MessageBox.Show("No existe Guías de Salida para realizar el Proceso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'strMensajeError &= "No existe Gu�as de Salida para realizar el Proceso. " & vbNewLine
        If dgGuiasSalidas.CurrentRow.Cells("GS_SESTRG").Value = "*" Then
            MessageBox.Show("Guía de Salida se encuentra anulada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim msg_error As String = ""
        msg_error = obrGuiasRemision.mfblnProceso_RestaurarGuiaSalida(obeGuiaRemision)
        If msg_error.Length > 0 Then
            MessageBox.Show(msg_error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Call pListarGuiasRemision()
        'End If
        'End If
    End Sub

    Private Sub pProceso_EliminarGuiaSalida()
        If dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
        ' Si elige NO entonces salimos del proceso
        If dgGuiasSalidas.RowCount <= 0 Then Exit Sub
        If Me.dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub


        Dim CodEnvioEmision As String = ""
        Dim CodEnvioAnulacion As String = ""
        Dim msg_ As String = ""
        For Each item As DataGridViewRow In dgGuiasRemision.Rows
            CodEnvioEmision = ("" & item.Cells("STRNEG").Value).ToString.Trim
            CodEnvioAnulacion = ("" & item.Cells("STRNAG").Value).ToString.Trim
            If CodEnvioEmision = "S" Then
                If CodEnvioAnulacion <> "S" Then
                    MessageBox.Show("Para la eliminación/anulación las Guías deben tener aceptación de anulación electronica.")
                    Exit Sub
                End If
            End If
        Next




        Dim obrGuiasRemision As New brGuiasRemision
        Dim obeGuiaRemision As New beGuiaRemision
        With obeGuiaRemision
            .PNCCLNT = txtClient.pCodigo
            .PNCCLNGR = CType(Me.dgGuiasSalidas.CurrentRow.DataBoundItem, beGuiaRemision).PNCCLNGR
            .PNNRGUSA = Me.dgGuiasRemision.CurrentRow.Cells("PNNRGUSA").Value.ToString.Trim
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSCUSCRT = objSeguridadBN.pUsuario
        End With
        Dim msg_error As String = ""

        'strError = obrGuiasRemision.fstrValidarGuaiRemision(obeGuiaRemision)
        'If strError.Trim.Length > 0 Then
        '    HelpClass.MsgBox(strError)
        'Else
        'If Not mfblnPreguntas(enumPregVarios.GREMISION_EliminarGuiaRemision) Then Exit Sub

        If MessageBox.Show("¿ Desea realizar el Proceso de Eliminar Guía de Remisión ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        msg_error = obrGuiasRemision.mfblnProceso_AnularGuiaRemision(obeGuiaRemision)
        If msg_error.Length > 0 Then
            MessageBox.Show(msg_error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Call pListarGuiasRemision()

        'If obrGuiasRemision.mfblnProceso_AnularGuiaRemision(obeGuiaRemision) Then
        '    booStatus = False
        '    '-- Actualizamos la informaci�n de la Gu�a de Remisi�n
        '    Call pListarGuiasRemision()
        '    booStatus = True
        'End If
        'End If

    End Sub

    Private Sub pListarGuiasSalida()

        Dim obrGuiasRemision As New brGuiasRemision
        Dim obeGuiaRemision As New beGuiaRemision
        Dim dteFechaTemp As Date

        With obeGuiaRemision
            .PNCCLNT = txtClient.pCodigo
            .PNNRGUSA = Val(txtNroGuiaSalida.Text)
            '.PSNGUIRM = Val(Me.txtGuiaRemision.Text)
            .PSNGUIRM = Me.txtGuiaRemision.Text.Trim.ToUpper
            If Date.TryParse(Me.txtFechaInicioGS.Text, dteFechaTemp) Then .PNFSLDAL_INICIAL = HelpClass.CDate_a_Numero8Digitos(dteFechaTemp)
            If Date.TryParse(Me.txtFechaFinalGS.Text, dteFechaTemp) Then .PNFSLDAL_FINAL = HelpClass.CDate_a_Numero8Digitos(dteFechaTemp)
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSSTGUSA = IIf(Me.chbPendiente.Checked, "1", "")
        End With
        dgGuiasSalidas.DataSource = obrGuiasRemision.fnListGuiasRemision_SalidaSAT(obeGuiaRemision)

    End Sub

    Private Sub pListarGuiasRemision()
        Dim obrGuiasRemision As New brGuiasRemision
        Dim obeGuiaRemision As New beGuiaRemision
        dgGuiasRemision.DataSource = Nothing
        If dgGuiasSalidas.RowCount = 0 Or dgGuiasSalidas.CurrentRow Is Nothing Then
            dgGuiasRemision.DataSource = New DataTable
            Exit Sub
        End If
        With obeGuiaRemision
            .PNCCLNT = txtClient.pCodigo
            .GUIASALIDA = CType(dgGuiasSalidas.CurrentRow.DataBoundItem, beGuiaRemision).PNNRGUSA '.Cells("GS_NRGUSA").Value.ToString
            .PNCCLNGR = CType(dgGuiasSalidas.CurrentRow.DataBoundItem, beGuiaRemision).PNCCLNGR
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
        End With
        dgGuiasRemision.DataSource = obrGuiasRemision.fnListGuiasRemisionSAT(obeGuiaRemision)
        Dim cod_envio_emision_gre As String = ""
        Dim cod_envio_anulacion_gre As String = ""
        For i As Integer = 0 To dgGuiasRemision.Rows.Count - 1
            dgGuiasRemision.Rows(i).Cells("PNNRGUSA").Value = dgGuiasSalidas.CurrentRow.Cells("GS_NRGUSA").Value

            cod_envio_emision_gre = dgGuiasRemision.Rows(i).Cells("STRNEG").Value
            cod_envio_anulacion_gre = dgGuiasRemision.Rows(i).Cells("STRNAG").Value
            Select Case cod_envio_emision_gre
                Case "S"
                    dgGuiasRemision.Rows(i).Cells("STRNEG_IMG").Value = My.Resources.verde
                Case "E"
                    dgGuiasRemision.Rows(i).Cells("STRNEG_IMG").Value = My.Resources.Rojo
                Case ""
                    dgGuiasRemision.Rows(i).Cells("STRNEG_IMG").Value = My.Resources.EnBlanco
            End Select
            Select Case cod_envio_anulacion_gre
                Case "S"
                    dgGuiasRemision.Rows(i).Cells("STRNAG_IMG").Value = My.Resources.verde
                Case "E"
                    dgGuiasRemision.Rows(i).Cells("STRNAG_IMG").Value = My.Resources.Rojo
                Case ""
                    dgGuiasRemision.Rows(i).Cells("STRNAG_IMG").Value = My.Resources.EnBlanco
            End Select

        Next

    End Sub


    Private Sub pVisualizarGuiaSalida()
        If dgGuiasSalidas.RowCount = 0 Then Exit Sub
        Dim objReporte As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim objParametroGuiaSalida As clsParametrosGuiaSalida = New clsParametrosGuiaSalida

        With objParametroGuiaSalida
            .pintCodigoCliente_CCLNT = txtClient.pCodigo
            .pstrDescripcionCliente_CCLNT = txtClient.pRazonSocial
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            Int64.TryParse(dgGuiasSalidas.CurrentRow.Cells("GS_NRGUSA").Value, .pintNroGuiaSalida_NRGUSA)

        End With
        rptTemp = objReporte.frptGenerarGuiaSalida(objParametroGuiaSalida)
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rptTemp
            .ShowDialog()
        End With

    End Sub

    Private Sub pVisualizarGuiaRemision()
        If dgGuiasRemision.RowCount = 0 Then Exit Sub
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim obeGuiaRemision = New RANSA.TYPEDEF.beGuiaRemision
        With obeGuiaRemision
            .PNCCLNT = txtClient.pCodigo
            .PNCCLNGR = CType(Me.dgGuiasSalidas.CurrentRow.DataBoundItem, beGuiaRemision).PNCCLNGR
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PNNRGUSA = CType(Me.dgGuiasSalidas.CurrentRow.DataBoundItem, beGuiaRemision).PNNRGUSA
            .PSNGUIRM = CType(Me.dgGuiasRemision.CurrentRow.DataBoundItem, beGuiaRemision).PSNGUIRM
            .strAplicacion = Application.StartupPath
        End With
        rptTemp = objReportes.frptImprimirGuiaRemision(obeGuiaRemision)

        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rptTemp
            .ShowDialog()
        End With
    End Sub

    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtClient.pCodigo = 0 Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        Else
            If dgGuiasSalidas.RowCount > 0 Then
                Dim obeGuiaRemision As New beGuiaRemision
                With obeGuiaRemision
                    .PNCCLNT = txtClient.pCodigo
                    .PNNRGUSA = dgGuiasSalidas.CurrentRow.Cells("GS_NRGUSA").Value
                    .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = UcDivision_Cmb011.Division
                    .PNCPLNDV = UcPLanta_Cmb011.Planta
                End With

                If dgGuiasSalidas.RowCount <= 0 Then strMensajeError &= "No existe Gu�as de Salida para realizar el Proceso. " & vbNewLine

                With dgGuiasSalidas
                    Dim obrGuiasRemision As New brGuiasRemision
                    Select Case eValidacion
                        Case eTipoValidacion.ANULAR
                            If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Gu�a de Salida ya se encuentra anulada. " & vbNewLine
                            If obrGuiasRemision.mfblnExiste_GuiaSalidaConGuiaRemision(obeGuiaRemision) Then _
                                strMensajeError &= "La presente Gu�a de Salida tiene Gu�a(s) de Remisi�n. " & vbNewLine
                        Case eTipoValidacion.GENERAR
                            If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Gu�a de Salida esta anulada. " & vbNewLine
                            If obrGuiasRemision.mfblnExiste_GuiaSalidaConGuiaRemision(obeGuiaRemision) Then _
                                strMensajeError &= "Ya se han generado las Gu�as de Remisi�n. " & vbNewLine
                        Case eTipoValidacion.RESTAURAR
                            If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Gu�a de Salida se encuentra anulada. " & vbNewLine
                            If Not obrGuiasRemision.mfblnExiste_GuiaSalidaConGuiaRemision(obeGuiaRemision) Then _
                                strMensajeError &= "La presente Gu�a de Salida no tiene Gu�a(s) de Remisi�n. " & vbNewLine
                    End Select
                End With
            End If
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function


#End Region
#Region " M�todos "

 

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

 

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Call pActualizarInformacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub dgGuiasSalidas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGuiasSalidas.CurrentCellChanged
    '    Try
    '        If booStatus Then
    '            booStatus = False
    '            If dgGuiasSalidas.Rows.Count > 0 Then
    '                Call pListarGuiasRemision()
    '            End If
    '            booStatus = True
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub frmDespacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.dgGuiasSalidas.AutoGenerateColumns = False
            Me.dgGuiasRemision.AutoGenerateColumns = False
            '-- Crear status por control con F4
            Dim objAppConfig As cAppConfig = New cAppConfig
            txtFechaInicioGS.Text = Now.ToString("dd/MM/yyyy")
            txtFechaFinalGS.Text = Now.ToString("dd/MM/yyyy")
            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("DespachoClienteCodigo", GetType(System.String)), intTemp)

            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtClient.pCargar(ClientePK)

            objAppConfig = Nothing

            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            Validar_Usuario_Autoridado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub
#End Region


    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New brUsuario
        Dim objEntidad As New beUsuario

        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objSeguridadBN.pUsuario)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)

        If objEntidad.STSOP1 = "" Then
            tsbGenerarGuiaRegu.Visible = False
            tsb003.Visible = False
        Else
            tsbGenerarGuiaRegu.Visible = True
            tsb003.Visible = True
        End If

        'If objEntidad.STSOP2 = "" Then
        '    tsbCambiarNroGuia.Visible = False
        '    'tss007.Visible = False
        'Else
        '    tsbCambiarNroGuia.Visible = True
        '    'tss007.Visible = True
        'End If

  

        'VisualizarenviarGuia()
    End Sub

    Private Sub VisualizarenviarGuia()
        If Me.txtClient.pCodigo = 16168 Or Me.txtClient.pCodigo = 20337 Or Me.txtClient.pCodigo = 21625 Or Me.txtClient.pCodigo = 37498 Or Me.txtClient.pCodigo = 38554 Then
            tsbEnviarGuias.Visible = True
            'tss006.Visible = True
        End If
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

 
 

#Region "B�squeda de Gu�a"

    Private NrGuia As Decimal = 0
    Private MatchCGuiaOrigen As New Predicate(Of beGuiaRemision)(AddressOf BuscarGuiaOrigen)
    Public Function BuscarGuiaOrigen(ByVal pbeGuiaRemision As beGuiaRemision) As Boolean
        If (pbeGuiaRemision.PNNGUIRO = NrGuia) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

    Private Sub dgGuiasRemision_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgGuiasRemision.DataBindingComplete

        Try
            If Me.dgGuiasRemision.Rows.Count = 0 Then Exit Sub
            For Each oDr As DataGridViewRow In Me.dgGuiasRemision.Rows
                If ("" & oDr.DataBoundItem.PSSTRNSM & "").ToString.Equals("E") Then
                    oDr.Cells("TRANSMISION").Value = My.Resources.icono_verdetalle1

                ElseIf ("" & oDr.DataBoundItem.PSSTRNSM & "").ToString.Equals("T") Then
                    oDr.Cells("TRANSMISION").Value = My.Resources.Enviado
                Else
                    oDr.Cells("TRANSMISION").Value = My.Resources.EnBlanco
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     
    End Sub

    Private Sub tsbImpresionMasiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImpresionMasiva.Click

        Try
            If dgGuiasSalidas.RowCount > 0 Then
                Dim NRGUSAs As String = String.Empty
                For Each row As DataGridViewRow In dgGuiasSalidas.Rows
                    NRGUSAs += "'" + row.Cells("GS_NRGUSA").Value.ToString + "', "
                Next
                NRGUSAs = NRGUSAs.Substring(0, NRGUSAs.Length - 2)
                Dim fImpresionMasiva As frmImpresionMasiva = New frmImpresionMasiva
                Dim obeGuiaRemision As New beGuiaRemision
                With obeGuiaRemision
                    .PNCCLNT = txtClient.pCodigo
                    .PNCCLNGR = txtClient.pCodigo
                    .GUIASALIDA = NRGUSAs
                    .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = UcDivision_Cmb011.Division
                    .PNCPLNDV = UcPLanta_Cmb011.Planta

                End With

                With fImpresionMasiva
                    .obeGuiaRemision = obeGuiaRemision
                    .ShowDialog()
                End With

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub stbGenerarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stbGenerarGuia.Click
        Try
            nTipoGuia = 1
            Call pProceso_GenerarGuiaRemision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub tsbGenerarGuiaRegu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarGuiaRegu.Click
        Try
            nTipoGuia = 2
            pProceso_GenerarGuiaRemision()

            pActualizarInformacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
     
    End Sub

    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        Try
            Call pProceso_AnularGuiaSalida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbVistaPrevia.Click
        Try
            If dgGuiasSalidas.RowCount <= 0 Then Exit Sub
            eTipoGuia = eTipoGuiaVisualizar.SALIDA
            pVisualizarGuiaSalida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub tsbAnularGuias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnularGuias.Click
        Try
            pProceso_RestaurarGuiaSalida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            pProceso_EliminarGuiaSalida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub tsbVistaPreviaGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbVistaPreviaGuia.Click
        Try
            If dgGuiasSalidas.RowCount <= 0 Then Exit Sub
            eTipoGuia = eTipoGuiaVisualizar.REMISION
            pVisualizarGuiaRemision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
      
    End Sub

    'Private Sub tsbEnviarGuias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarGuias.Click
    '    'Solo para Pacasmayo
    '    If Me.txtClient.pCodigo = 16168 Or Me.txtClient.pCodigo = 20337 Or Me.txtClient.pCodigo = 21625 Or Me.txtClient.pCodigo = 37498 Or Me.txtClient.pCodigo = 38554 Then
    '        Dim obrGuia As New brGuiasRemision
    '        Dim lstrGuia As New List(Of String)
    '        Dim wsIntegracios As New NetPacasmayoService.IntegracionPacasmayo
    '        wsIntegracios.CCLNT = Me.txtClient.pCodigo
    '        wsIntegracios.LocalDirectory = Application.StartupPath
    '        For Each obeGui As beGuiaRemision In CType(dgGuiasRemision.DataSource, List(Of beGuiaRemision))
    '            NrGuia = obeGui.PSNGUIRM
    '            obeGui.PNCCLNT = Me.txtClient.pCodigo
    '            If CType(dgGuiasRemision.DataSource, List(Of beGuiaRemision)).FindAll(MatchCGuiaOrigen).Count = 0 Then
    '                If Not ("" & obeGui.PSSTRNSM & "").Trim.ToString.Equals("T") Then
    '                    If ("" & obeGui.PSSTRNSM & "").Trim.ToString.Equals("E") Then
    '                        If MessageBox.Show("La gu�a de remisi�n: " & obeGui.PSNGUIRM & " ya ha sido enviado, desea volver a enviar", "Precauci�n", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
    '                            lstrGuia.Add(obeGui.PSNGUIRM)
    '                            'obrGuia.fintActualizarEnvioGuias(obeGui)
    '                        End If
    '                    Else
    '                        lstrGuia.Add(obeGui.PSNGUIRM)
    '                        'obrGuia.fintActualizarEnvioGuias(obeGui)
    '                    End If
    '                End If
    '            End If
    '        Next
    '        If lstrGuia.Count > 0 Then
    '            wsIntegracios.ListaGuias = lstrGuia
    '            wsIntegracios.EnviarGuia()
    '        End If
    '        Try
    '            dgGuiasSalidas_CurrentCellChanged(Nothing, Nothing)
    '        Catch ex As Exception
    '        End Try

    '    End If
    'End Sub

    Private Sub tsbCambiarNroGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCambiarNroGuia.Click
        Try
            Dim tipoGuia As String = ""
            Dim ofrmCambiarNrGuia As New frmCambiarNrGuia
            tipoGuia = ("" & dgGuiasRemision.CurrentRow.Cells("CTDGRM").Value).ToString.Trim
            ofrmCambiarNrGuia.PNCCLNT = txtClient.pCodigo
            ofrmCambiarNrGuia.PNNGUIRM = dgGuiasRemision.CurrentRow.Cells("GR_NGUIRM").Value
            ofrmCambiarNrGuia.pCTDGRM = tipoGuia

            If tipoGuia = "E" Then
                MessageBox.Show("Opción habilitada solo para documentos físicos", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            If ofrmCambiarNrGuia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Call pActualizarInformacion()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
      
    End Sub

    Private Sub tsm_anular_gr_Click(sender As Object, e As EventArgs) Handles tsm_anular_gr.Click
        Try
            pProceso_RestaurarGuiaSalida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub tstm_eliminar_gr_Click(sender As Object, e As EventArgs) Handles tstm_eliminar_gr.Click
        Try
            pProceso_EliminarGuiaSalida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub tstm_anular_gr_electronico_Click(sender As Object, e As EventArgs) Handles tstm_anular_gr_electronico.Click
        Try

            Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
            Dim obrRestGuiaRemision As New br_Rest_Remision_Pacasmayo

            If dgGuiasRemision.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim TipoGuia As String = dgGuiasRemision.Rows(0).Cells("CTDGRM").Value
            If TipoGuia = "F" Then
                MessageBox.Show("La acción es aplicada para Guías Electrónicas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim dt_envio_gr As New DataTable
            Dim obeGuiaRemision As New beGuiaRemision
            'Dim pCCLnt As Decimal = CType(dgGuiasSalidas.CurrentRow.DataBoundItem, beGuiaRemision).PNCCLNGR ' dgGuiasRemision.CurrentRow.Cells("CCLNT").Value
            Dim pCCLnt As Decimal = dgGuiasRemision.CurrentRow.Cells("CCLNT").Value

            obeGuiaRemision.PNCCLNT = pCCLnt
            dt_envio_gr = obrGuiaRemision.fnValidarCLienteEnvioGuia(obeGuiaRemision)

            Dim msg_validacion As String = ""
            Dim grupo_envio As String = ""
            Dim estado_valido As String = ""

            For Each item As DataRow In dt_envio_gr.Rows
                If item("STATUS") = "E" Then
                    msg_validacion = msg_validacion & item("OBSRESULT") & Chr(10)
                End If
            Next
            If dt_envio_gr.Rows.Count > 0 Then
                estado_valido = dt_envio_gr.Rows(0)("STATUS")
                grupo_envio = dt_envio_gr.Rows(0)("GRUPO_ENVIO")
            End If

            If msg_validacion.Length > 0 Then
                MessageBox.Show(msg_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If estado_valido = "S" Then

                Dim CodEnvioAnulacion As String = ""
                Dim CodEnvioEmision As String = ""
                Dim nGuirm As Decimal = 0
                Dim nGuirs As String = ""
                Dim msg_envio As String = ""
                Dim Trama As String = ""
                Dim cod_respuesta_anulacion As String = ""

                Dim list_guias As String = ""
                For Each item As DataGridViewRow In dgGuiasRemision.Rows
                    CodEnvioAnulacion = ("" & item.Cells("STRNAG").Value).ToString.Trim
                    CodEnvioEmision = ("" & item.Cells("STRNEG").Value).ToString.Trim
                    If CodEnvioEmision = "S" And (CodEnvioAnulacion = "E" Or CodEnvioAnulacion = "") Then
                        list_guias = list_guias & ("" & item.Cells("PSNGUIRS").Value).ToString.Trim
                    End If
                Next
                If list_guias.Length > 0 Then
                    If MessageBox.Show("Las siguientes guías serán anuladas:" & list_guias & Chr(13) & " Desea continuar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If

                For Each item As DataGridViewRow In dgGuiasRemision.Rows
                    CodEnvioAnulacion = ("" & item.Cells("STRNAG").Value).ToString.Trim
                    CodEnvioEmision = ("" & item.Cells("STRNEG").Value).ToString.Trim
                    If CodEnvioEmision = "S" And (CodEnvioAnulacion = "E" Or CodEnvioAnulacion = "") Then
                        nGuirm = item.Cells("GR_NGUIRM").Value
                        nGuirs = ("" & item.Cells("PSNGUIRS").Value).ToString.Trim
                        msg_envio = msg_envio & obrRestGuiaRemision.Anular_Guia_Remision_Electronica_Pacasmayo_Rest(pCCLnt, nGuirm, nGuirs, grupo_envio, False, Trama, cod_respuesta_anulacion)
                        If cod_respuesta_anulacion <> "" Then
                            item.Cells("STRNAG").Value = cod_respuesta_anulacion
                            Select Case cod_respuesta_anulacion
                                Case "S"
                                    item.Cells("STRNAG_IMG").Value = My.Resources.verde
                                Case "E"
                                    item.Cells("STRNAG_IMG").Value = My.Resources.Rojo
                                Case ""
                                    item.Cells("STRNAG_IMG").Value = My.Resources.EnBlanco
                            End Select
                        End If                     
                    End If
                Next

                If msg_envio.Length > 0 Then
                    MessageBox.Show("Inconvenientes de anulación Guía : " & msg_envio, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Las Guías fueron anuladas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
 
            End If
            If msg_validacion.Length > 0 Then
                MessageBox.Show(msg_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub dgGuiasSalidas_SelectionChanged(sender As Object, e As EventArgs) Handles dgGuiasSalidas.SelectionChanged

        Try
            Call pListarGuiasRemision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub
End Class




Public Class clsCopiar_Pegar
#Region " Atributos "
    'GuiaRemision
    Private dtpFechaEmision As DateTime = Now
    Private txtMotivoTrasladoTag As String = ""
    Private txtMotivoTrasladoText As String = ""
    Private txtObsOtrosMotivos As String = ""
    'OrigenDestino
    Private txtClienteOrigenTag As String = ""
    Private txtPlantaOrigenTag As String = ""
    Private txtPlantaOrigenText As String = ""
    'OrigenDestino'Planta
    Private rbtPlantaCliente As Boolean = False
    Private txtClienteDestinoTag As String = ""
    Private txtPlantaClienteTag As String = ""
    Private txtPlantaClienteText As String = ""
    Private txtClienteTerceroTag As String = ""
    'OrigenDestino'Cliente
    Private rbtClienteTercero As Boolean = False
    Private txtProveedor As String = ""
    Private txtProveedorCliente As String = ""
    Private txtClienteTerceroText As String = ""
    Private txtTipoRelacionText As String = ""
    Private txtPlantaClienteTerceroTag As String = ""
    Private txtPlantaClienteTerceroText As String = ""
    Private txtRucProveedorText As String = ""
    'Informacion Transporte
    Private txtEmpresaTransporteTag As String = ""
    Private txtEmpresaTransporteText As String = ""
    Private txtPlacaUnidadTag As String = ""
    Private txtPlacaUnidadText As String = ""
    Private txtNroBreveteTag As String = ""
    Private txtNroBreveteText As String = ""
    Private txtPlacaAcopladoTag As String = ""
    Private txtPlacaAcopladoText As String = ""
    Private txtObservaciones As String = ""
    Private chkDosTramos As Boolean = False
    Private txtEmpresaTransporte2doTramoTag As String = ""
    Private txtEmpresaTransporte2doTramoText As String = ""
    Private txtSiglatext As String = ""
    Private txtNumeroContenedortext As String = ""
    Private txtMedioSugeridoTag As String = ""
    Private txtMedioSugeridoText As String = ""

    Private txtClasificacionCarga As String = ""
    Private txtProgramador As String = ""
    Private txtCorreoAprobacion As String = ""
    Private txtSolicitante As String = ""
    Private txtAprobacion As String = ""
    Private txtGerencia As String = ""
    Private txtArea As String = ""


#End Region
#Region " Propiedades "
    'GuiaRemision
    Public Property pdtpFechaEmision() As DateTime
        Get
            Return dtpFechaEmision
        End Get
        Set(ByVal value As DateTime)
            dtpFechaEmision = value
        End Set
    End Property
    Public Property ptxtMotivoTrasladoTag() As String
        Get
            Return txtMotivoTrasladoTag
        End Get
        Set(ByVal value As String)
            txtMotivoTrasladoTag = value
        End Set
    End Property
    Public Property ptxtMotivoTrasladoText() As String
        Get
            Return txtMotivoTrasladoText
        End Get
        Set(ByVal value As String)
            txtMotivoTrasladoText = value
        End Set
    End Property
    Public Property ptxtObsOtrosMotivos() As String
        Get
            Return txtObsOtrosMotivos
        End Get
        Set(ByVal value As String)
            txtObsOtrosMotivos = value
        End Set
    End Property
    'OrigenDestino
    Public Property ptxtProveedorCliente() As String
        Get
            Return txtProveedorCliente
        End Get
        Set(ByVal value As String)
            txtProveedorCliente = value
        End Set
    End Property
    Public Property ptxtClienteOrigenTag() As String
        Get
            Return txtClienteOrigenTag
        End Get
        Set(ByVal value As String)
            txtClienteOrigenTag = value
        End Set
    End Property

    Public Property ptxtPlantaOrigenTag() As String
        Get
            Return txtPlantaOrigenTag
        End Get
        Set(ByVal value As String)
            txtPlantaOrigenTag = value
        End Set
    End Property
    Public Property ptxtPlantaOrigenText() As String
        Get
            Return txtPlantaOrigenText
        End Get
        Set(ByVal value As String)
            txtPlantaOrigenText = value
        End Set
    End Property
    'OrigenDestino'Planta
    Public Property prbtPlantaCliente() As Boolean
        Get
            Return rbtPlantaCliente
        End Get
        Set(ByVal value As Boolean)
            rbtPlantaCliente = value
        End Set
    End Property
    'ptxtClienteDestinoTag
    Public Property ptxtClienteDestinoTag() As String
        Get
            Return txtClienteDestinoTag
        End Get
        Set(ByVal value As String)
            txtClienteDestinoTag = value
        End Set
    End Property

    Public Property ptxtClienteTerceroTag() As String
        Get
            Return txtClienteTerceroTag
        End Get
        Set(ByVal value As String)
            txtClienteTerceroTag = value
        End Set
    End Property

    Public Property ptxtPlantaClienteTag() As String
        Get
            Return txtPlantaClienteTag
        End Get
        Set(ByVal value As String)
            txtPlantaClienteTag = value
        End Set
    End Property
    Public Property ptxtPlantaClienteText() As String
        Get
            Return txtPlantaClienteText
        End Get
        Set(ByVal value As String)
            txtPlantaClienteText = value
        End Set
    End Property
    'OrigenDestino'Cliente
    Public Property prbtClienteTercero() As Boolean
        Get
            Return rbtClienteTercero
        End Get
        Set(ByVal value As Boolean)
            rbtClienteTercero = value
        End Set
    End Property
    Public Property ptxtClienteTerceroText() As String
        Get
            Return txtClienteTerceroText
        End Get
        Set(ByVal value As String)
            txtClienteTerceroText = value
        End Set
    End Property

    Public Property ptxtProveedor() As String
        Get
            Return txtProveedor
        End Get
        Set(ByVal value As String)
            txtProveedor = value
        End Set
    End Property
    Public Property ptxtTipoRelacionText() As String
        Get
            Return txtTipoRelacionText
        End Get
        Set(ByVal value As String)
            txtTipoRelacionText = value
        End Set
    End Property
    Public Property ptxtRucProveedorText() As String
        Get
            Return txtRucProveedorText
        End Get
        Set(ByVal value As String)
            txtRucProveedorText = value
        End Set
    End Property
    Public Property ptxtPlantaClienteTerceroTag() As String
        Get
            Return txtPlantaClienteTerceroTag
        End Get
        Set(ByVal value As String)
            txtPlantaClienteTerceroTag = value
        End Set
    End Property
    Public Property ptxtPlantaClienteTerceroText() As String
        Get
            Return txtPlantaClienteTerceroText
        End Get
        Set(ByVal value As String)
            txtPlantaClienteTerceroText = value
        End Set
    End Property
    'Informacion Transporte
    Public Property ptxtEmpresaTransporteTag() As String
        Get
            Return txtEmpresaTransporteTag
        End Get
        Set(ByVal value As String)
            txtEmpresaTransporteTag = value
        End Set
    End Property
    Public Property ptxtEmpresaTransporteText() As String
        Get
            Return txtEmpresaTransporteText
        End Get
        Set(ByVal value As String)
            txtEmpresaTransporteText = value
        End Set
    End Property
    Public Property ptxtPlacaUnidadTag() As String
        Get
            Return txtPlacaUnidadTag
        End Get
        Set(ByVal value As String)
            txtPlacaUnidadTag = value
        End Set
    End Property
    Public Property ptxtPlacaUnidadText() As String
        Get
            Return txtPlacaUnidadText
        End Get
        Set(ByVal value As String)
            txtPlacaUnidadText = value
        End Set
    End Property
    Public Property ptxtNroBreveteTag() As String
        Get
            Return txtNroBreveteTag
        End Get
        Set(ByVal value As String)
            txtNroBreveteTag = value
        End Set
    End Property
    Public Property ptxtNroBreveteText() As String
        Get
            Return txtNroBreveteText
        End Get
        Set(ByVal value As String)
            txtNroBreveteText = value
        End Set
    End Property
    Public Property ptxtPlacaAcopladoTag() As String
        Get
            Return txtPlacaAcopladoTag
        End Get
        Set(ByVal value As String)
            txtPlacaAcopladoTag = value
        End Set
    End Property
    Public Property ptxtPlacaAcopladoText() As String
        Get
            Return txtPlacaAcopladoText
        End Get
        Set(ByVal value As String)
            txtPlacaAcopladoText = value
        End Set
    End Property
    Public Property ptxtObservaciones() As String
        Get
            Return txtObservaciones
        End Get
        Set(ByVal value As String)
            txtObservaciones = value
        End Set
    End Property
    Public Property pchkDosTramos() As Boolean
        Get
            Return chkDosTramos
        End Get
        Set(ByVal value As Boolean)
            chkDosTramos = value
        End Set
    End Property
    Public Property ptxtEmpresaTransporte2doTramoTag() As String
        Get
            Return txtEmpresaTransporte2doTramoTag
        End Get
        Set(ByVal value As String)
            txtEmpresaTransporte2doTramoTag = value
        End Set
    End Property
    Public Property ptxtEmpresaTransporte2doTramoText() As String
        Get
            Return txtEmpresaTransporte2doTramoText
        End Get
        Set(ByVal value As String)
            txtEmpresaTransporte2doTramoText = value
        End Set
    End Property
    Public Property ptxtSiglatext() As String
        Get
            Return txtSiglatext
        End Get
        Set(ByVal value As String)
            txtSiglatext = value
        End Set
    End Property
    Public Property ptxtNumeroContenedortext() As String
        Get
            Return txtNumeroContenedortext
        End Get
        Set(ByVal value As String)
            txtNumeroContenedortext = value
        End Set
    End Property

    Public Property ptxtMedioSugeridoTag() As String
        Get
            Return txtMedioSugeridoTag
        End Get
        Set(ByVal value As String)
            txtMedioSugeridoTag = value
        End Set
    End Property

    Public Property ptxtMedioSugeridoText() As String
        Get
            Return txtMedioSugeridoText
        End Get
        Set(ByVal value As String)
            txtMedioSugeridoText = value
        End Set
    End Property

    Public Property ptxtClasificacionCarga() As String
        Get
            Return txtClasificacionCarga
        End Get
        Set(ByVal value As String)
            txtClasificacionCarga = value
        End Set
    End Property
    Public Property ptxtProgramador() As String
        Get
            Return txtProgramador
        End Get
        Set(ByVal value As String)
            txtProgramador = value
        End Set
    End Property
    Public Property ptxtCorreoAprobacion() As String
        Get
            Return txtCorreoAprobacion
        End Get
        Set(ByVal value As String)
            txtCorreoAprobacion = value
        End Set
    End Property
    Public Property ptxtSolicitante() As String
        Get
            Return txtSolicitante
        End Get
        Set(ByVal value As String)
            txtSolicitante = value
        End Set
    End Property
    Public Property ptxtAprobacion() As String
        Get
            Return txtAprobacion
        End Get
        Set(ByVal value As String)
            txtAprobacion = value
        End Set
    End Property
    Public Property ptxtGerencia() As String
        Get
            Return txtGerencia
        End Get
        Set(ByVal value As String)
            txtGerencia = value
        End Set
    End Property
    Public Property ptxtArea() As String
        Get
            Return txtArea
        End Get
        Set(ByVal value As String)
            txtArea = value
        End Set
    End Property

#End Region
End Class


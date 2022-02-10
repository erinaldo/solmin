Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS.Reportes.Generador
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario
Imports Ransa.NEGO

Module mReporteDespachoSDS
    '-------------------------------------------
    '-- Imprimir Reporte de Guia de Despacho --
    '-------------------------------------------
    Public Sub mpObtenerGuiaDespacho(ByVal objFiltro As clsFiltros_ReporteGuiaDespacho)
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = objReportes.frptObtenerGuiaDespacho(objFiltro, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With
    End Sub

    Public Function mfrptObtenerGuiaDespacho(ByVal objFiltro As clsFiltros_ReporteGuiaDespacho) As ReportDocument
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim     strMensajeError As String = ""
        Dim rptTemp As ReportDocument = Nothing
        rptTemp = objReportes.frptObtenerGuiaDespacho(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return rptTemp
    End Function

    '------------------------------------------
    '-- Imprimir Reporte de Guia de Remisión --
    '------------------------------------------
    Public Sub mpGenerarGuiaRemisionDS(ByVal objParam As clsPARAM_GuiaRemisionDS)
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Try

            With frmVisorRPT
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill
                .pReportDocument = objReportes.frptGenerarGuiaRemision(objParam, strMensajeError, Application.StartupPath)
                If strMensajeError <> "" Then
                    MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    .ShowDialog()

                    If objParam.pintCodigoCliente_CCLNT = 11232 Then

                        Dim obrDespacho As New Ransa.NEGO.brDespacho
                        Dim obeDespacho As New Ransa.TypeDef.beDespacho
                        Dim olbeDespacho As New List(Of Ransa.TypeDef.beDespacho)
                        obeDespacho.PNCCLNT = objParam.pintCodigoCliente_CCLNT
                        obeDespacho.PNNGUIRN = objParam.pintNroGuiaRansa_NGUIRN
                        olbeDespacho = obrDespacho.ListaParaExportarABB(obeDespacho)
                        If olbeDespacho.Count > 0 Then
                            Dim blRecepcion As New Ransa.NEGO.brIntegracion
                            Dim objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter
                            objParametros = New Db2Manager.RansaData.iSeries.DataObjects.Parameter
                            With objParametros
                                '==========Cabecera Despacho
                                .Add("vc_RansaOutGuide", objParam.pintNroGuiaRansa_NGUIRN)
                                .Add("dt_ReferralGuideDate", objParam.pdteFechaEmision_FGUIRM)
                                .Add("vc_TransferReason", objParam.TransferReason)
                                .Add("vc_HomeName", olbeDespacho.Item(0).PSTCMPCL)
                                .Add("vc_HomeAddress", olbeDespacho.Item(0).PSTDRCOR)
                                .Add("vc_CustomerCodeDeliver", olbeDespacho.Item(0).PSTIPCLI)
                                .Add("vc_CustomerFiscalCodeDeliver", olbeDespacho.Item(0).PSNRUCPR)
                                .Add("vc_CustomerAddressDeliverLine1", olbeDespacho.Item(0).PSTDRPCP)
                                .Add("vc_CustomerAddressDeliverLine2", olbeDespacho.Item(0).PSTDRDST)
                                .Add("vc_CustomerAddressLine3", "")
                                .Add("vc_CustomerFiscalName", olbeDespacho.Item(0).PSTPRVCL)
                                .Add("vc_VehiclePlate", objParam.pstrPlacaUnidad_NPLCCM)
                                .Add("vc_TransportCarrierName", objParam.DescripcionEmpresaDeTransporte)
                                .Add("vc_TransportCarrierFiscalCode", " " & objParam.TransportCarrierFiscalCode & "")
                                .Add("vc_TransportCarrierAddress", " " & objParam.TransportCarrierAddress & " ")
                                .Add("vc_Driver", " " & objParam.Driver & " ")
                                .Add("vc_DriversLicense", objParam.pstrNroBrevete_NBRVCH)
                                .Add("vc_ReferralGuideComments", objParam.pstrObservacionesOtroMotivoTraslado_TOBORM)
                                .Add("vc_Usuario", objSeguridadBN.pUsuario)
                                .Add("vc_OrderNumber", olbeDespacho.Item(0).PSNRFRPD)
                                .Add("vc_OrderType", olbeDespacho.Item(0).PSNRFTPD)

                            End With
                            Dim intEstado_C As Int32 = blRecepcion.Integracion_Insertar_Despacho_Cabecera(objParam.pintCodigoCliente_CCLNT, objParametros)
                            If intEstado_C = -1 Then Exit Sub

                            For Each obeDespacho In olbeDespacho
                                objParametros = New Db2Manager.RansaData.iSeries.DataObjects.Parameter
                                With objParametros

                                    ' ========Detalle Despacho

                                    .Add("in_ReferralGuideNumber", intEstado_C)
                                    .Add("vc_OrderNumber", obeDespacho.PSNRFRPD)
                                    .Add("vc_OrderType", obeDespacho.PSNRFTPD)
                                    .Add("in_OrderLine", obeDespacho.PSNLTECL)
                                    .Add("vc_StockCode", obeDespacho.PSCMRCLR)
                                    If obeDespacho.PSDEMERCA.Trim.Length > 50 Then
                                        .Add("vc_LineDescriptionLine1", obeDespacho.PSDEMERCA.Trim.Substring(0, 50))
                                        .Add("vc_LineDescriptionLine2", obeDespacho.PSDEMERCA)
                                    Else
                                        .Add("vc_LineDescriptionLine1", obeDespacho.PSDEMERCA.Trim)
                                        .Add("vc_LineDescriptionLine2", "")
                                    End If
                                    .Add("vc_UnitMeasure", obeDespacho.PSCUNCN6) 'UNIDA DE MEDIDA
                                    .Add("fl_Quantity", obeDespacho.PNQTRMC)
                                    .Add("vc_Usuario", objSeguridadBN.pUsuario)
                                    .Add("vc_ReferenceGuide", obeDespacho.PSGUIA)

                                End With
                                Dim intEstado_D As Int32 = blRecepcion.Integracion_Insertar_Despacho_Detalle(objParam.pintCodigoCliente_CCLNT, objParametros)
                                If intEstado_D <> -1 Then
                                    Dim olBeSerie As New List(Of Ransa.TYPEDEF.beDespacho)
                                    olBeSerie = obrDespacho.ListaSerieExportarABB(obeDespacho)
                                    Dim oloData As New List(Of Hashtable)

                                    Dim objData = New System.Collections.Hashtable
                                    Dim intCorrelativo As Integer = 0
                                    For Each obeSeri As RANSA.TYPEDEF.beDespacho In olBeSerie
                                        intCorrelativo = intCorrelativo + 1
                                        objData = New System.Collections.Hashtable
                                        With objData
                                            '==========Cabecera Despacho
                                            .Add("n_IdSerie", intCorrelativo.ToString)
                                            .Add("in_ReferralGuideLine", intEstado_D.ToString)
                                            .Add("in_ReferralGuideNumber", intEstado_C.ToString)
                                            .Add("vc_StockCode", obeSeri.PSCMRCLR)
                                            .Add("vc_NumeroSerie", obeSeri.PSCSRECL)
                                        End With
                                        oloData.Add(objData)
                                    Next
                                    intEstado_D = blRecepcion.Integracion_Insertar_Serie_Despacho(objParam.pintCodigoCliente_CCLNT, oloData)
                                    'If intEstado_D = -1 Then
                                    '    HelpClass.ErrorMsgBox()
                                    'End If
                                End If
                            Next

                        End If

                    End If

                    Dim obrGeneral As New Ransa.NEGO.brGeneral
                    ' Validamos que el clientes sea Outotec
                    If obrGeneral.bolElClienteEsOutotec(objParam.pintCodigoCliente_CCLNT) Then
                        EnviarGuiaRemisionOutotec(objParam.pintCodigoCliente_CCLNT, objParam.pintNroGuiaRansa_NGUIRN)
                    End If
                End If

            End With
        Catch : End Try
    End Sub



    Private Sub EnviarGuiaRemisionOutotec(ByVal decCclnt As Decimal, ByVal decNguirn As Decimal)
        Dim obrDespacho As New Ransa.NEGO.brDespacho
        Dim obeDespacho As New Ransa.TYPEDEF.beDespacho
        Dim olbeDespacho As New List(Of Ransa.TYPEDEF.beDespacho)
        obeDespacho.PNCCLNT = decCclnt
        obeDespacho.PNNGUIRN = decNguirn
        olbeDespacho = obrDespacho.ListaParaExportarABB(obeDespacho)
        If olbeDespacho.Count > 0 AndAlso olbeDespacho.Item(0).PNNGUIRM <> 0 Then

            ''Proyecto Outotec
            Dim obrInterfaz As New Ransa.NEGO.brInterfazOutoTec
            '================registro de cabecera========================
            Dim obeCabGuiaInfzOutotec As New Ransa.TYPEDEF.beCabGuiaInfzOutotec
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
                Dim olbeDetGuiaInfzOutotec As New List(Of Ransa.TYPEDEF.beDetGuiaInfzOutotec)
                Dim intNRow As Integer = 1
                Dim olBeSerie As List(Of Ransa.TYPEDEF.beDespacho)
                Dim obeDetInterfazOutotec As Ransa.TYPEDEF.beDetGuiaInfzOutotec

                For Each obeDesp As Ransa.TYPEDEF.beDespacho In olbeDespacho
                    olBeSerie = New List(Of Ransa.TYPEDEF.beDespacho)
                    olBeSerie = obrDespacho.ListaSerieExportarABB(obeDesp)

                    If olBeSerie.Count > 0 Then
                        If olBeSerie.Count = obeDesp.PNQTRMC Then
                            For Each obeSerie As Ransa.TYPEDEF.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New Ransa.TYPEDEF.beDetGuiaInfzOutotec
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
                            obeDetInterfazOutotec = New Ransa.TYPEDEF.beDetGuiaInfzOutotec
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

                            For Each obeSerie As Ransa.TYPEDEF.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New Ransa.TYPEDEF.beDetGuiaInfzOutotec
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
                        obeDetInterfazOutotec = New Ransa.TYPEDEF.beDetGuiaInfzOutotec
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
                If obrInterfaz.fintInsertarDetalleGuia(olbeDetGuiaInfzOutotec) = -1 Then
                    MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim obrGuia As New DespachoSAT.brGuiasRemision
            Dim objGui As New Ransa.TYPEDEF.beGuiaRemision
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


    ''comentado por mientras fecha 18-06-2012
    Public Sub mReporteIngSalRansa(ByVal objFiltro As RANSA.TypeDef.beDespacho)
        'Dim objFiltro As New beDespacho
        Dim objDespacho As New brDespacho
        Dim dtResultado As DataTable = Nothing
        dtResultado = objDespacho.fdtReporteGuiaRansa(objFiltro)
        dtResultado.TableName = "dtInformacionGuiaDespacho"
        If dtResultado.Rows.Count > 0 Then
            Dim obrGeneral As New brGeneral
            Dim rdocGuiaRemision As Object = Nothing
            If objFiltro.PSCTPOAT = "I" Then
                rdocGuiaRemision = New rptGuiaInterfazRecepcion
            Else
                rdocGuiaRemision = New rptGuiaDespacho2
            End If
            'Dim rdocGuiaRemision As New rptGuiaDespacho
            rdocGuiaRemision.SetDataSource(dtResultado)
            rdocGuiaRemision.Refresh()
            rdocGuiaRemision.SetParameterValue("pCliente", objFiltro.PNCCLNT)
            rdocGuiaRemision.SetParameterValue("pRazonSocialCliente", objFiltro.pRazonSocial)
            rdocGuiaRemision.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rdocGuiaRemision.SetParameterValue("pNroGuiaRansa", objFiltro.PNNGUIRN)
            rdocGuiaRemision.SetParameterValue("pEmpresa", GLOBAL_EMRESA)
            rdocGuiaRemision.SetParameterValue("pProceso", objFiltro.PSCTPOAT)
            With frmVisorRPT
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill

                .pReportDocument = rdocGuiaRemision
                .ShowDialog()
            End With
        End If
    End Sub
 
End Module

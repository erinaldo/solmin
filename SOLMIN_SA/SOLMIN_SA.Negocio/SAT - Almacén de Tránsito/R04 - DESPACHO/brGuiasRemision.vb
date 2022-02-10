Imports RANSA.TypeDef
Imports RANSA.DATA.DespachoSAT
Imports System.Data

Namespace DespachoSAT
    Public Class brGuiasRemision
        Public Function fnListGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision, ByRef PageCount As Decimal) As List(Of beGuiaRemision)
            Return New DATA.DespachoSAT.daGuiasRemision().fnListGuiasRemision(obeFiltroGuia, PageCount)
        End Function
        'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-INICIO
        Public Function fnListValidadGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision)
            Return New daGuiasRemision().fnListValidarGuiasRemision(obeFiltroGuia)
        End Function
        'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-FIN


        Private Function OrdenGuia(ByVal dsTemp As DataSet) As DataSet
            Dim DsResult As New DataSet
            Dim blIsAlmacenTransito As Boolean = True
            For Each dtTemp As DataTable In dsTemp.Tables
                dtTemp.Columns.Add("FECHA_MIN", Type.GetType("System.String"))
                Dim dt As New DataTable
                Dim drSelect As DataRow()
                Dim DtResult As New DataTable
                dt = dtTemp.Clone
                Dim j As Integer = 0
                Dim strMinimo As String = ""

                For i As Integer = 0 To dtTemp.Rows.Count - 1
                    j = 0
                    If i = 0 Then
                        If dtTemp.Rows(i).Item("TIPO") > 0 Then
                            blIsAlmacenTransito = True
                        Else
                            blIsAlmacenTransito = False
                        End If
                    End If

                    If blIsAlmacenTransito Then
                        drSelect = dtTemp.Select("CCLNT = '" + dtTemp.Rows(i)("CCLNT").ToString.Trim + "' AND " & _
                                                                "PLANTA = '" + dtTemp.Rows(i)("PLANTA").ToString.Trim + "' ", "FGUIRM_INT ASC")
                    Else
                        drSelect = dtTemp.Select("CCLNT = '" + dtTemp.Rows(i)("CCLNT").ToString.Trim + "' ", "FGUIRM_INT ASC")
                    End If

                    strMinimo = ""
                    For Each dr As DataRow In drSelect
                        dt.ImportRow(dr)
                        If j = 0 Then
                            strMinimo = dr.Item("FGUIRM_INT").ToString
                        End If
                        dt.Rows(i + j)("FECHA_MIN") = strMinimo
                        dr.AcceptChanges()
                        j = j + 1
                    Next
                    i = i + drSelect.Length - 1
                Next i
                'Ordena la El dt Temporal
                drSelect = dt.Select("", "FECHA_MIN ASC")
                DtResult = dt.Clone
                For Each dr As DataRow In drSelect
                    DtResult.ImportRow(dr)
                Next
                DsResult.Tables.Add(DtResult.Copy)
            Next
            Return DsResult
        End Function

        Public Function fdsListGuiasRemision_Detalle(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim ODsFormat As DataSet = Me.OrdenGuia(New DATA.DespachoSAT.daGuiasRemision().fdsListGuiasRemision_Detalle(obeFiltroGuia).Copy)
            Dim blIsCliente As Boolean = False
            Dim blIsPlanta As Boolean = False
            Dim blIsGuia As Boolean = False
            Dim blIsAlmacenTransito As Boolean = False
            Dim ObjGuiaRemision As beGuiaRemision

            'Elimina las Tablas que no tengan Registros
            For i As Integer = ODsFormat.Tables.Count - 1 To 0 Step -1
                If Not ODsFormat.Tables(i).Rows.Count > 0 Then
                    ODsFormat.Tables.Remove(ODsFormat.Tables(i).TableName)
                End If
            Next

            Dim OdsResult As New DataSet
            'dt.TableName = "CONSULTA GUIA REMISION"
            'OdsResult.Tables.Add(dt.Copy)

            For Each Odt As DataTable In ODsFormat.Tables
                ObjGuiaRemision = New beGuiaRemision
                For i As Integer = 0 To Odt.Rows.Count - 1
                    blIsCliente = False
                    blIsPlanta = False
                    blIsGuia = False
                    If i = 0 Then
                        If Odt.Rows(i).Item("TIPO") > 0 Then
                            Odt.TableName = "ALMACEN DE TRANSITO"
                            blIsAlmacenTransito = True
                        Else
                            Odt.TableName = "DEPOSITO SIMPLE"
                            blIsAlmacenTransito = False
                        End If

                        ObjGuiaRemision.PNCCLNT = Odt.Rows(i).Item("CCLNT")
                        ObjGuiaRemision.PSTCMPCL = Odt.Rows(i).Item("CLIENTE")
                        If blIsAlmacenTransito Then
                            ObjGuiaRemision.PSPLANTA = Odt.Rows(i).Item("PLANTA")
                        End If
                        ObjGuiaRemision.PSNPLCCM = Odt.Rows(i).Item("PLACA_TRACTO")
                        ObjGuiaRemision.PSNPLACP = Odt.Rows(i).Item("ACOPLADO")
                        ObjGuiaRemision.PSTCMPTR = Odt.Rows(i).Item("TRANSPORTISTA")
                        ObjGuiaRemision.PSTNMBCH = Odt.Rows(i).Item("CONDUCTOR")
                        ObjGuiaRemision.PSNGUIRM = Odt.Rows(i).Item("GUIA_REMISION")
                        ObjGuiaRemision.PSFGUIRM_S = Odt.Rows(i).Item("FECHA_GUIA")
                    End If

                    If ObjGuiaRemision.PNCCLNT = Odt.Rows(i).Item("CCLNT") Then
                        blIsCliente = True
                        If blIsAlmacenTransito Then
                            If ObjGuiaRemision.PSPLANTA = Odt.Rows(i).Item("PLANTA") Then
                                blIsPlanta = True
                                If ObjGuiaRemision.PSNGUIRM = Odt.Rows(i).Item("GUIA_REMISION") Then
                                    blIsGuia = True
                                End If
                            End If

                        Else
                            If ObjGuiaRemision.PSNGUIRM = Odt.Rows(i).Item("GUIA_REMISION") Then
                                blIsGuia = True
                            End If
                        End If
                    End If

                    ObjGuiaRemision.PNCCLNT = Odt.Rows(i).Item("CCLNT")
                    ObjGuiaRemision.PSTCMPCL = Odt.Rows(i).Item("CLIENTE")
                    If blIsAlmacenTransito Then
                        ObjGuiaRemision.PSPLANTA = Odt.Rows(i).Item("PLANTA")
                    End If
                    ObjGuiaRemision.PSNPLCCM = Odt.Rows(i).Item("PLACA_TRACTO")
                    ObjGuiaRemision.PSNPLACP = Odt.Rows(i).Item("ACOPLADO")
                    ObjGuiaRemision.PSTCMPTR = Odt.Rows(i).Item("TRANSPORTISTA")
                    ObjGuiaRemision.PSTNMBCH = Odt.Rows(i).Item("CONDUCTOR")
                    ObjGuiaRemision.PSNGUIRM = Odt.Rows(i).Item("GUIA_REMISION")
                    ObjGuiaRemision.PSFGUIRM_S = Odt.Rows(i).Item("FECHA_GUIA")

                    If blIsCliente And i > 0 Then
                        Odt.Rows(i).Item("CLIENTE") = ""
                        If blIsAlmacenTransito Then
                            If blIsPlanta Then
                                Odt.Rows(i).Item("PLANTA") = ""
                                If blIsGuia Then
                                    Odt.Rows(i).Item("PLACA_TRACTO") = ""
                                    Odt.Rows(i).Item("ACOPLADO") = ""
                                    Odt.Rows(i).Item("TRANSPORTISTA") = ""
                                    Odt.Rows(i).Item("CONDUCTOR") = ""
                                    Odt.Rows(i).Item("GUIA_REMISION") = ""
                                    Odt.Rows(i).Item("FECHA_GUIA") = ""
                                End If
                            End If
                        Else
                            If blIsGuia Then
                                Odt.Rows(i).Item("PLACA_TRACTO") = ""
                                Odt.Rows(i).Item("ACOPLADO") = ""
                                Odt.Rows(i).Item("TRANSPORTISTA") = ""
                                Odt.Rows(i).Item("CONDUCTOR") = ""
                                Odt.Rows(i).Item("GUIA_REMISION") = ""
                                Odt.Rows(i).Item("FECHA_GUIA") = ""
                            End If
                        End If
                    End If
                Next
                Odt.Columns.Remove("TIPO")
                Odt.Columns.Remove("NGUIRM")
                Odt.Columns.Remove("CCLNT")
                Odt.Columns.Remove("FGUIRM_INT")
                Odt.Columns.Remove("FECHA_MIN")
                Odt.Columns.Remove("CLIENTE")
                OdsResult.Tables.Add(Odt.Copy)
            Next
            Return OdsResult
        End Function

        'Public Function fdsListGuiasRemision_Detalle(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
        '    Return New DATA.DespachoSAT.daGuiasRemision().fdsListGuiasRemision_Detalle(obeFiltroGuia)
        'End Function

        Public Function ListarLotes(ByVal intCliente As Integer) As DataTable
            Dim oDt As DataTable = New DATA.DespachoSAT.daGuiasRemision().ListarLotes(intCliente)
            Dim dtSer As New DataTable
            dtSer = oDt.Clone
            Dim drw As DataRow
            drw = dtSer.NewRow
            drw(0) = "0"
            drw(1) = "------TODOS------"
            dtSer.Rows.Add(drw)
            For Each dr As DataRow In oDt.Rows
                drw = dtSer.NewRow
                drw(0) = dr(0)
                drw(1) = dr(1)
                dtSer.Rows.Add(drw)
            Next
            Return dtSer
        End Function

        Public Function fnSelDetalleGuiaAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            If obeFiltroGuia.PNNGUIRO <> 0 Then
                obeFiltroGuia.PSNGUIRM = obeFiltroGuia.PNNGUIRO
            End If
            Return New daGuiasRemision().fnSelDetalleGuiaAT(obeFiltroGuia)
        End Function



        Public Function fnListGuiasRemisionSAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Return New daGuiasRemision().fnListGuiasRemisionSAT(obeFiltroGuia)
        End Function


        Public Function fnListGuiasRemision_SalidaSAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Return New daGuiasRemision().fnListGuiasRemision_SalidaSAT(obeFiltroGuia)
        End Function


        Public Function mfblnExiste_GuiaSalidaConGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
            Return New daGuiasRemision().fblnExisteInformacion(obeFiltroGuia)
        End Function


        Public Function fintActualizarEnvioGuias(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
            Return New daGuiasRemision().fintActualizarEnvioGuias(obeFiltroGuia)
        End Function

        'Public Function mfblnProceso_RestaurarGuiaSalida(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
        '    Return New daGuiasRemision().fblnRestaurarGuiaSalidaSAT(obeFiltroGuia)
        'End Function
        Public Function mfblnProceso_RestaurarGuiaSalida(ByVal obeFiltroGuia As beGuiaRemision) As String
            Dim GuiaRemision_DAL As New RANSA.DATA.DespachoSAT.daGuiasRemision
            Return GuiaRemision_DAL.fblnRestaurarGuiaSalidaSAT(obeFiltroGuia)
        End Function

        Public Function mfblnProceso_AnularGuiaSalida(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
            Return New daGuiasRemision().fblnAnularGuiaSalidaSAT(obeFiltroGuia)
        End Function

        'Public Function mfblnProceso_AnularGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
        '    Return New daGuiasRemision().fblnAnularGuiaRemisionSAT(obeFiltroGuia)
        'End Function
        Public Function mfblnProceso_AnularGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision)
            Dim GuiaRemision_DAL As New RANSA.DATA.DespachoSAT.daGuiasRemision
            Return GuiaRemision_DAL.fblnAnularGuiaRemisionSAT(obeFiltroGuia)
        End Function


        ''' <summary>
        ''' Anula Guia de Remision de  Almacen de transito
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AnularGuiaDeRemisionAT(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Return New daGuiasRemision().AnularGuiaDeRemisionAT(obeFiltroGuia)
        End Function

        ''' <summary>
        ''' Elimina fisicamente  la Guia de Remision Almacen de transito
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function EliminarGuiaDeRemisionAT(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Return New daGuiasRemision().EliminarGuiaDeRemisionAT(obeFiltroGuia)
        End Function
        ''' <summary>
        ''' Copia de Planta X a Planta Y
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CopyGuiaSalida(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Return New daGuiasRemision().CopyGuiaSalida(obeFiltroGuia)
        End Function

        Public Function GenerarGuiaRemision(ByRef obeFiltroGuia As beGuiaRemision, ByVal obeListaObservacion As List(Of beGuiaRemision), Optional ByVal EsRecojo As Boolean = False) As DataSet
            If EsRecojo Then
                Dim obrBulto As New brBulto
                Dim obeBulto As New beBulto
                obeBulto.PSCCMPN = obeFiltroGuia.PSCCMPN
                obeBulto.PSCDVSN = obeFiltroGuia.PSCDVSN
                obeBulto.PNCPLNDV = obeFiltroGuia.PNCPLNDV
                obeBulto.PNCCLNT = obeFiltroGuia.PNCCLNT
                obeBulto.PSCREFFW = obeFiltroGuia.PSCREFFW
                obeBulto.PSSMTRCP = obeFiltroGuia.PSSMTRCP
                obeBulto.PSTOBSGS = obeFiltroGuia.PSTOBSGS
                obeBulto.PSTOBDGS = "RECOJO" 'obeFiltroGuia.PSTOBDGS Observaciones Detalle Guia Salida 
                obeBulto.PNCTRSPT = obeFiltroGuia.PNCTRSPT
                obeBulto.PSNPLCUN = obeFiltroGuia.PSNPLCCM
                obeBulto.PSNPLCAC = obeFiltroGuia.PSNPLACP
                obeBulto.PSCBRCNT = obeFiltroGuia.PSNBRVCH
                obeBulto.PSSTPOCM = "" 'obeFiltroGuia.PSSTPOCM
                obeBulto.PNNTCKPS = 0 'obeFiltroGuia.PNNTCKPS
                obeBulto.PSSTPDSP = obeFiltroGuia.PSSTPDSP
                obeBulto.PSUSUARIO = obeFiltroGuia.PSUSUARIO
                obeFiltroGuia.PNNRGUSA = obrBulto.ProcesarRecojo(obeBulto)
                If obeBulto.PSERROR.ToString.Length > 0 Or obeFiltroGuia.PNNRGUSA = -1 Then
                    obeFiltroGuia.PSERROR = "Error "
                    Return New DataSet
                End If

            End If
            objParamatrosGuiaRemisionAT(obeFiltroGuia)
            Dim dtGRResumen As New DataTable
            Dim dsGRDSetalle As New DataSet
            dsGRDSetalle = New daGuiasRemision().GenerarGuiaRemision(obeFiltroGuia, dtGRResumen)

            For Each item As beGuiaRemision In obeListaObservacion
                item.PSNGUIRM = dtGRResumen.Rows(0)("NGUIRM")
                item.PSNGUIRS = dtGRResumen.Rows(0)("NGUIRS")
            Next

            If obeFiltroGuia.PSERROR.ToString.Length = 0 Then
                If obeListaObservacion.Count > 0 Then
                    If New daGuiasRemision().fintInsertarObsebacionGuiaRemision(obeListaObservacion) = -1 Then
                        obeFiltroGuia.PSERROR = "Error al guardar Observacion"
                        Return New DataSet
                    End If
                End If
                'Return New daGuiasRemision().GenerarGuiaRemision(obeFiltroGuia)
                Return dsGRDSetalle
            Else
                obeFiltroGuia.PSERROR = "Error "
                Return New DataSet
            End If

        End Function

        Public Function fdsGenerarGuiaRemision(ByRef obeFiltroGuia As beGuiaRemision, ByVal obeListaObservacion As List(Of beGuiaRemision), ByVal pstrTipoSistema As String) As DataSet
            Select Case pstrTipoSistema
                Case "01"
                    objParamatrosGuiaRemisionAT(obeFiltroGuia)
                Case "03", "04"
                    objParamatrosGuiaRemisionDS(obeFiltroGuia)
            End Select
            Dim oDs As New DataSet
            If New daGuiasRemision().fdstGenerarGuiaRemision(obeFiltroGuia) = 1 Then
                If obeListaObservacion.Count > 0 Then
                    If New daGuiasRemision().fintInsertarObsebacionGuiaRemision(obeListaObservacion) = -1 Then
                        obeFiltroGuia.PSERROR = "Error al guardar Observacion"
                    End If
                End If
                Return New daGuiasRemision().fdsImprimirGuiaRemisionDS(obeFiltroGuia)
            Else
                obeFiltroGuia.PSERROR = "Error al guardar la guía"
                Return New DataSet
            End If
        End Function



        ''' <summary>
        ''' Generar Guia remision Manual
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <param name="EsRecojo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fdsGenerarGuiaRemisionManual(ByRef obeFiltroGuia As beGuiaRemision, ByVal obeListObervacion As List(Of beGuiaRemision), ByVal obeDetalleGuia As List(Of beGuiaRemision), ByVal pstrTipoSistema As String, Optional ByVal EsRecojo As Boolean = False) As DataSet
            Select Case pstrTipoSistema
                Case "01"
                    objParamatrosGuiaRemisionAT(obeFiltroGuia)
                Case "03", "04"
                    objParamatrosGuiaRemisionDS(obeFiltroGuia)
            End Select
            If ("" & obeFiltroGuia.PSERROR & "").ToString.Length = 0 Then
                'Guardamos la cabecera de la guia 
                If New daGuiasRemision().fdsGenerarGuiaRemisionManual(obeFiltroGuia) = 1 Then
                    'Guardamos la observación
                    If obeListObervacion.Count > 0 Then
                        If New daGuiasRemision().fintInsertarObsebacionGuiaRemision(obeListObervacion) = -1 Then
                            obeFiltroGuia.PSERROR = "Error al guardar Observación"
                        End If
                    End If
                    'Guardamos el detalle de la guia 
                    For Each obeDetGuia As beGuiaRemision In obeDetalleGuia
                        If New daGuiasRemision().fdsGenerarGuiaRemisionManualDetalle(obeDetGuia) = -1 Then
                            obeFiltroGuia.PSERROR = "Error al guardar detalle de la guía "
                        End If
                    Next
                Else
                    obeFiltroGuia.PSERROR = "Error al guardar la cabecera de la Guía"
                End If
            Else
                obeFiltroGuia.PSERROR = "Error "
            End If

            'Verificamos que no hubor error
            If obeFiltroGuia.PSERROR.Length > 0 Then
                If New daGuiasRemision().fintRollbackGuiaRemisionManual(obeFiltroGuia) = -1 Then
                    obeFiltroGuia.PSERROR = "Error comuníquese con el departamento de sistemas "
                End If
                Return New DataSet
            Else
                Dim obrGeneral As New RANSA.NEGO.brGeneral
                If obrGeneral.bolElClienteEsOutotec(obeFiltroGuia.PNCCLNT) Then
                    If fbolEnviarGuiaOutotec(obeFiltroGuia, obeDetalleGuia) = -1 Then
                        obeFiltroGuia.PSERROR = "Error al enviar a Outotec"
                    End If
                End If
                Return New daGuiasRemision().fdstDataGuiaRemisionManual(obeFiltroGuia)
            End If
        End Function

        Public Function fbolEnviarGuiaOutotec(ByRef obeFiltroGuia As beGuiaRemision, ByRef obeDetalleGuia As List(Of beGuiaRemision)) As Integer
            Dim obrInterfaz As New RANSA.NEGO.brInterfazOutoTec
            '================registro de cabecera========================
            Dim obeCabGuiaInfzOutotec As New RANSA.TYPEDEF.beCabGuiaInfzOutotec
            With obeCabGuiaInfzOutotec
                .nguias = obeFiltroGuia.PSNGUIRM
                .codcli = obeFiltroGuia.PNCCLNT
                .ctpdoc = "PS"
                .nserof = obeFiltroGuia.PSSERIE
                .ndocof = obeFiltroGuia.PSNROFIC
                .npensa = 0
                .ctpgui = obeFiltroGuia.pstrTipoMovIntfz

                If Not obeFiltroGuia.FechaEmisionGuia Is Nothing Then
                    .femisi = obeFiltroGuia.FechaEmisionGuia
                Else
                    .femisi = Nothing
                End If
                If Not obeFiltroGuia.FechaInicioTraslado Is Nothing Then
                    .finitr = obeFiltroGuia.FechaInicioTraslado
                Else
                    .finitr = Nothing
                End If
                .dtpgui = obeFiltroGuia.PSTOBORM

                'Nuevos==========
                .nordcl = obeFiltroGuia.PSNORCML
                .ctpope = obeFiltroGuia.PSNRFTPD
                .nordpr = obeFiltroGuia.PSNRFRPD
                'Nuevos==========

                .ddiori = obeFiltroGuia.PSORIGEN 'Direccion de origen
                .ctpode = obeFiltroGuia.PSTIPORG 'Direccion de destino
                .coride = obeFiltroGuia.PSCORIDE 'COD CLIENTE TERCERO
                .ddirec01 = obeFiltroGuia.PSDESTINO 'DIR DESTINO
                .nconst = obeFiltroGuia.PSNRGMT1 'MTC
                .nplaca01 = obeFiltroGuia.PSNPLCCM 'PLACA
                .dobser = obeFiltroGuia.PSTOBSRM & obeFiltroGuia.PSTOBCLI 'OBSERVACION

                Select Case obeFiltroGuia.PNTDCFCC
                    Case 1
                        .ctpfac = "FA" 'POR MIENTRAS
                    Case 7
                        .ctpfac = "BO" 'POR MIENTRAS
                End Select
                If obeFiltroGuia.FechaContrato.Trim <> "" Then
                    .fecdoc = obeFiltroGuia.FechaContrato
                    .nfactu01 = obeFiltroGuia.PNNDCFCC
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
                .drztra = obeFiltroGuia.PSTCMPTR.Trim 'Descripcion de empresa de transporte 
                .cructr = obeFiltroGuia.PNNRUCT 'Nro. de Ruc
                .dchofe = obeFiltroGuia.PSTNMBCH.Trim 'Chofer
                .nbreve = obeFiltroGuia.PSNBRVCH.Trim 'Nro. Brevete
                .qtotpe = 0
                If obeFiltroGuia.PSUSUARIO.Length > 6 Then
                    .cusuar = obeFiltroGuia.PSUSUARIO.Trim.Substring(1, 6)
                Else
                    .cusuar = obeFiltroGuia.PSUSUARIO
                End If
            End With

            If obrInterfaz.fintInsertarCabeceraGuia(obeCabGuiaInfzOutotec) <> -1 Then
                '================registro de detalle=========================
                Dim olbeDetGuiaInfzOutotec As New List(Of RANSA.TYPEDEF.beDetGuiaInfzOutotec)
                Dim intNRow As Integer = 1

                For Each obeDetGuia As beGuiaRemision In obeDetalleGuia
                    Dim obeDetInterfazOutotec As New RANSA.TYPEDEF.beDetGuiaInfzOutotec
                    With obeDetInterfazOutotec
                        .nguias = obeFiltroGuia.PSNGUIRM
                        .codcli = obeFiltroGuia.PNCCLNT
                        .norden = intNRow
                        .citems = obeDetGuia.PSCMRCLR
                        If obeDetGuia.PSTDITEM.Trim.Length > 60 Then
                            .ditems = obeDetGuia.PSTDITEM.Substring(0, 60)
                        Else
                            .ditems = obeDetGuia.PSTDITEM
                        End If
                        .cunmed = obeDetGuia.PSCUNCN
                        .qitems = obeDetGuia.PNQCNGU
                        .qunida = 0
                        .qsaldo = 0
                        .nserie = obeDetGuia.PSCSRECL
                    End With
                    olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                    intNRow = intNRow + 1
                Next
                If obrInterfaz.fintInsertarDetalleGuia(olbeDetGuiaInfzOutotec) = -1 Then
                    obeFiltroGuia.PSERROR = "Error en el envio a Outotec"
                    Return -1
                End If
            Else
                obeFiltroGuia.PSERROR = "Error en el envio a Outotec"
                Return -1
            End If
            If fintActualizarEnvioGuias(obeFiltroGuia) = 0 Then
                obeFiltroGuia.PSERROR = "Error en el envio a Outotec"
                Return -1
            Else
                Return 1
            End If
        End Function

        Public Function fdsImprimirGuiaRemision(ByRef obeFiltroGuia As beGuiaRemision, ByVal pstrTipoSistema As String, Optional ByVal pstrManual As String = "") As DataSet
            If pstrManual = "M" Then
                Select Case pstrTipoSistema
                    Case "01"
                        objParamatrosGuiaRemisionAT(obeFiltroGuia)
                    Case "03", "04"
                        objParamatrosGuiaRemisionDS(obeFiltroGuia)
                End Select
                Return New daGuiasRemision().fdstDataGuiaRemisionManual(obeFiltroGuia)
            Else
                Select Case pstrTipoSistema
                    Case "01"
                        objParamatrosGuiaRemisionAT(obeFiltroGuia)
                        Return New DataSet
                        'falta implementar
                    Case "03", "04"
                        objParamatrosGuiaRemisionDS(obeFiltroGuia)
                        Return New daGuiasRemision().fdsImprimirGuiaRemisionDS(obeFiltroGuia)
                End Select
            End If
        End Function



        ' Función para obtener los Parametros de Impresión de la Guia de Remision
        Private Sub objParamatrosGuiaRemisionAT(ByRef obeParamGuia As beGuiaRemision)
            'Dim dstParametrosGenerales As DataSet
            Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision
            'Dim rwListaBaseDatos As DataRow()
            Dim odaGuiasRemision As New daGuiasRemision
            Dim dtParametro As New DataTable

            Try
                dtParametro = odaGuiasRemision.fdstListaParametroGuiaRemision(obeParamGuia.PSCCMPN, obeParamGuia.PNCCLNT, "")
                If dtParametro.Rows.Count > 0 Then
                    obeParamGuia.PNNLINGR = dtParametro.Rows(0)("NLINGR")
                    obeParamGuia.PSMODELO = dtParametro.Rows(0)("MODLGR")
                    obeParamGuia.PSDECONC = dtParametro.Rows(0)("FLDTCN")
                    obeParamGuia.PSMGUIFA = dtParametro.Rows(0)("FMGFIT")
                    obeParamGuia.PSMGFFIN = dtParametro.Rows(0)("FMGFBT")
                    obeParamGuia.PSMOBSER = dtParametro.Rows(0)("FMSOBS")
                    obeParamGuia.PSTOXBUL = dtParametro.Rows(0)("FMBLTO")
                End If
            Catch ex As Exception
                obeParamGuia.PSERROR = ex.Message
            End Try

            'Try
            '    dstParametrosGenerales = New DataSet()
            '    dstParametrosGenerales.ReadXml(obeParamGuia.strAplicacion & "\Servidores.xml")
            '    rwListaBaseDatos = dstParametrosGenerales.Tables("ParamGuiaRemisionAT").Select("Cliente='" & obeParamGuia.PNCCLNT.ToString & "'")
            '    If rwListaBaseDatos.Length = 0 Then
            '        rwListaBaseDatos = dstParametrosGenerales.Tables("ParamGuiaRemisionAT").Select("Cliente='999999'")
            '    End If
            '    With obeParamGuia
            '        .PNNLINGR = rwListaBaseDatos(0).Item("NroLineaPorGuia")
            '        .PSMODELO = rwListaBaseDatos(0).Item("ModReporte")
            '        .PSDECONC = rwListaBaseDatos(0).Item("ConsDescripcion")
            '        .PSMGUIFA = rwListaBaseDatos(0).Item("MostrarGF")
            '        .PSMGFFIN = rwListaBaseDatos(0).Item("MostrarGFFinal")
            '        .PSMOBSER = rwListaBaseDatos(0).Item("IncluirOBS")
            '        .PSTOXBUL = rwListaBaseDatos(0).Item("MostrarTBulto")
            '    End With
            'Catch ex As Exception
            '    obeParamGuia.PSERROR = ex.Message
            'End Try

        End Sub

        ' Función para obtener los Parametros de Impresión de la Guia de Remision
        Private Sub objParamatrosGuiaRemisionDS(ByRef obeParamGuia As beGuiaRemision)
            Dim dstParametrosGenerales As DataSet
            Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision
            Dim rwListaBaseDatos As DataRow()
            Try
                dstParametrosGenerales = New DataSet()
                dstParametrosGenerales.ReadXml(obeParamGuia.strAplicacion & "\Servidores.xml")
                rwListaBaseDatos = dstParametrosGenerales.Tables("ParamGuiaRemisionDS").Select("Cliente='" & obeParamGuia.PNCCLNT.ToString & "'")
                If rwListaBaseDatos.Length = 0 Then
                    rwListaBaseDatos = dstParametrosGenerales.Tables("ParamGuiaRemisionDS").Select("Cliente='999999'")
                End If
                With obeParamGuia
                    .PNNLINGR = rwListaBaseDatos(0).Item("NroLineaPorGuia")
                    .PSMODELO = rwListaBaseDatos(0).Item("ModReporte")
                End With
            Catch ex As Exception
                obeParamGuia.PSERROR = ex.Message
            End Try

        End Sub


        Public Function fdstDataGuiaRemision(ByRef obeFiltroGuia As beGuiaRemision) As DataSet
            objParamatrosGuiaRemisionAT(obeFiltroGuia)
            Return New daGuiasRemision().fdstDataGuiaRemision(obeFiltroGuia)
        End Function

        Public Function fnListGuiasRemisionSAT_PredesPacho(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim odaGuiaRemision As New daGuiasRemision
            Dim oListGuiaRemision As New List(Of beGuiaRemision)
            oListGuiaRemision = odaGuiaRemision.fnListGuiasRemisionSAT_PredesPacho(obeFiltroGuia)
            Return oListGuiaRemision
        End Function

        Public Function fblnAnularGuiaRemisionSAT_PreDespacho(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.fblnAnularGuiaRemisionSAT_PreDespacho(obeFiltroGuia)
        End Function


        Public Function fstrValidarGuaiRemision(ByVal obeFiltroGuia As beGuiaRemision) As String
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.fstrValidarGuaiRemision(obeFiltroGuia)
        End Function

        ''' <summary>
        ''' Devuelve los estado de la guia de remision
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function finListaEstadoGuiaRemision() As DataTable
            Dim odaGuiaRemision As New daGuiasRemision
            Dim oDt As New DataTable
            oDt = odaGuiaRemision.finListaEstadoGuiaRemision()
            Return oDt
        End Function


        Public Function fintActualizarEstadoGuias(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.fintActualizarEstadoGuias(obeFiltroGuia)
        End Function

        Public Function fdsListGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim odaGuiaRemision As New daGuiasRemision
            Dim ds As DataSet = odaGuiaRemision.fdsListGuiasRemision(obeFiltroGuia)
            For Each dt As DataTable In ds.Tables
                If Not dt.Columns("FGUIRM") Is Nothing Then
                    dt.Columns.Remove("FGUIRM")
                End If
            Next

            Return ds
        End Function

        Public Function fstrUltimoGuiaRemision(ByVal intCCLNT As Integer) As String
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.fstrUltimoGuiaRemision(intCCLNT)
        End Function

        'Public Function cambiarNumeroGuia(ByVal obeFiltroGuia As beGuiaRemision) As String
        '    Dim odaGuiaRemision As New daGuiasRemision
        '    Return odaGuiaRemision.cambiarNumeroGuia(obeFiltroGuia)
        'End Function
        Public Function cambiarNumeroGuia_s(ByVal obeFiltroGuia As beGuiaRemision) As String
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.cambiarNumeroGuia_s(obeFiltroGuia)
        End Function


        Public Function fdtGuiaRemisionParaExportarTxt(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.fdtGuiaRemisionParaExportarTxt(obeFiltroGuia)
        End Function

        Public Function fdstListaSerieGR_x_Cliente(ByVal CCMPN As String, CDVSN As String, ByVal CCLNT As Decimal) As DataTable
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.fdstListaSerieGR_x_Cliente(CCMPN, CDVSN, CCLNT)
        End Function

        Public Function Validar_Registro_GR_Cliente_Electronico(ByVal CCMPN As String, CDVSN As String, ByVal CCLNT As Decimal) As String
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.Validar_Registro_GR_Cliente_Electronico(CCMPN, CDVSN, CCLNT)
        End Function
        Public Function Listar_Ubigeo() As DataTable
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.Listar_Ubigeo
        End Function

        'ByVal obrGuiaRemision As brGuiasRemision, ByVal obeGuiaRemision As beGuiaRemision, ByVal oTdtGR As DataTable
        'Public Function Enviar_Guia_Remision_Electronica_Pacasmayo(pCCLNT As Decimal, pNGUIRM As Decimal, pNGUIRS As String, pGrupo_Envio As String, get_SoloTrama As Boolean) As String
        '    Dim odaGuiaRemision As New daGuiasRemision
        '    Dim dt_envio_gr As New DataTable
        '    Dim obeGuiaRemision As New beGuiaRemision
        '    obeGuiaRemision.PNCCLNT = pCCLNT
        '    Dim msg_validacion As String = ""
        '    Dim url_servicio As String = ""
        '    Dim usu_servicio As String = ""
        '    Dim psw_servicio As String = ""
        '    Dim ejecutar_envio As Boolean = True

        '    Try

        '        Dim dt_url As New DataTable
        '        dt_url = odaGuiaRemision.Listar_Url_Envio_Guia(obeGuiaRemision.PNCCLNT, pGrupo_Envio, "EMIS_GR")

        '        If dt_url.Rows.Count = 0 Then
        '            msg_validacion = "Url no configurada." & Chr(13)
        '        Else
        '            url_servicio = ("" & dt_url.Rows(0)("URL")).ToString.Trim
        '            usu_servicio = ("" & dt_url.Rows(0)("USUARIO")).ToString.Trim
        '            psw_servicio = ("" & dt_url.Rows(0)("USUARIO_PWS")).ToString.Trim

        '        End If
        '        If url_servicio = "" Or usu_servicio = "" Or psw_servicio = "" Then
        '            msg_validacion = msg_validacion & " Datos url/usurio/pws incompleto" & Chr(13)
        '        End If

        '        Dim ds_Datos_GR As New DataSet
        '        Dim dt_cab As New DataTable
        '        Dim dt_det As New DataTable
        '        Dim cont As Integer


        '        Dim detalle As RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZmmstRansaDetalle
        '        ds_Datos_GR = odaGuiaRemision.Listar_Datos_GuiaTransito_Pacasmayo(pCCLNT, pNGUIRM, pNGUIRS)
        '        dt_cab = ds_Datos_GR.Tables(0).Copy
        '        dt_det = ds_Datos_GR.Tables(1).Copy

        '        If dt_cab.Rows.Count = 0 Then
        '            msg_validacion = msg_validacion & " Datos de cabecera no encontrado." & Chr(13)
        '        End If
        '        If dt_det.Rows.Count = 0 Then
        '            msg_validacion = msg_validacion & " Datos de detalle no encontrado." & Chr(13)
        '        End If

        '        If msg_validacion.Length > 0 Then
        '            msg_validacion = "GUIA: " & pNGUIRS & Chr(10) & msg_validacion
        '        End If

        '        If msg_validacion = "" Then

        '            Dim cabecera As New RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZmmstRansaCabecera

        '            cabecera.IndSerie = dt_cab.Rows(0).Item("TIPO")
        '            cabecera.Xblnr = dt_cab.Rows(0).Item("NGUIRS")
        '            cabecera.Budat = dt_cab.Rows(0).Item("FECHA_GR")
        '            cabecera.Direccion = dt_cab.Rows(0).Item("DIRECC_CLIENTE")
        '            cabecera.FecIniTras = dt_cab.Rows(0).Item("FECHA_TRASL")
        '            cabecera.UbigeoPartida = dt_cab.Rows(0).Item("UBIGEO_O")
        '            cabecera.PuntoOrigen = dt_cab.Rows(0).Item("DIREC_O")
        '            cabecera.UbigeoLlegada = dt_cab.Rows(0).Item("UBIGEO_D")
        '            cabecera.PuntoLlegada = dt_cab.Rows(0).Item("DIREC_D")
        '            cabecera.RucTrans = dt_cab.Rows(0).Item("RUC_TRANSP")
        '            cabecera.RucCliente = dt_cab.Rows(0).Item("RUC_CLIENTE")
        '            cabecera.RazonTrans = dt_cab.Rows(0).Item("RSOCIAL_TRANSP")
        '            cabecera.ChofBrevete = dt_cab.Rows(0).Item("COND_BREVETE")
        '            cabecera.NomChofer = dt_cab.Rows(0).Item("COND_NOMBRE")
        '            cabecera.PlacaVehi = dt_cab.Rows(0).Item("VEH_PLACA")
        '            cabecera.PlacaAcop = dt_cab.Rows(0).Item("ACOP_PLACA")
        '            cabecera.PlacaMtc = dt_cab.Rows(0).Item("VEH_MTC")
        '            cabecera.MarcaVehi = dt_cab.Rows(0).Item("VEH_MARCA")
        '            cabecera.PesoTotal = dt_cab.Rows(0).Item("PESO_GR")
        '            cabecera.ObsGre = dt_cab.Rows(0).Item("OBS_GR")
        '            cabecera.MotTras = dt_cab.Rows(0).Item("MOT_TRAS")
        '            cabecera.DescMot = dt_cab.Rows(0).Item("MOT_DESC")
        '            cabecera.ModTrans = dt_cab.Rows(0).Item("MOD_TRANSP")
        '            cabecera.Correo = dt_cab.Rows(0).Item("CORREO_EMISOR")

        '            Dim ListItems(dt_det.Rows.Count) As RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZmmstRansaDetalle

        '            cont = 0
        '            For Each item As DataRow In dt_det.Rows

        '                detalle = New RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZmmstRansaDetalle

        '                detalle.Ebeln = item("NRO_OC")
        '                detalle.Ebelp = item("NRO_ITEM")
        '                detalle.DesEbelp = item("DESC_OC")
        '                detalle.Name1 = item("DESC_PROV")
        '                detalle.NrBulto = item("NRO_BULTO")
        '                detalle.DesBulto = item("DESC_BULTO")
        '                detalle.Meins = item("UM_ITEM")
        '                detalle.Menge = item("CANT_ENTREGA")
        '                detalle.GrLifnr = item("NRO_GPROV")
        '                detalle.Matnr = item("COD_MATERIAL")
        '                detalle.Maktx = item("DESC_ITEM")
        '                detalle.CodIqbf = item("COND_IQBF")
        '                detalle.ClaMatnr = item("CLASE_MATERIAL")
        '                detalle.CodEan = item("COD_SUNAT_UN")
        '                detalle.PesoBulto = item("PESO_BULTO")
        '                detalle.PesoItem = item("PESO_ITEM")

        '                ListItems(cont) = detalle
        '                cont += 1

        '            Next

        '            Dim emisionransa As New RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZWS_EMISION_RANZA
        '            Dim emision_gr As New RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZmmrfcGreRansaEmision
        '            emision_gr.TEntrada = New ProxyPacasmayo_GR_Emision.ZmmstEmisionRansa

        '            Dim cad As String = ""
        '            emision_gr.TEntrada.Zcabecera = cabecera
        '            emision_gr.TEntrada.Zdetalle = ListItems

        '            emisionransa.Url = url_servicio
        '            emisionransa.Credentials = New System.Net.NetworkCredential(usu_servicio, psw_servicio)
        '            Dim emisionrespuesta As New RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZmmrfcGreRansaEmisionResponse

        '            If get_SoloTrama = True Then
        '                Dim x As New Xml.Serialization.XmlSerializer(emision_gr.GetType)
        '                Dim sw As New IO.StringWriter()
        '                x.Serialize(sw, emision_gr)
        '                msg_validacion = sw.ToString()
        '                Return msg_validacion
        '                Exit Function
        '            End If
        '            emisionrespuesta = emisionransa.ZmmrfcGreRansaEmision(emision_gr)
        '            If emisionrespuesta.TRetunr(0).Type <> "S" Then
        '                msg_validacion = emisionrespuesta.TRetunr(0).Message
        '            End If
        '            odaGuiaRemision.fintActualizarEstadoEnvioGuias(obeGuiaRemision, emisionrespuesta.TRetunr(0).Type, emisionrespuesta.TRetunr(0).Message, "")

        '        End If


        '    Catch ex As Exception
        '        msg_validacion = msg_validacion & Chr(10) & ex.Message
        '    End Try

        '    Return msg_validacion.Trim

        'End Function



        'Public Function Anular_Guia_Remision_Electronica_Pacasmayo(pCCLNT As Decimal, pNGUIRM As Decimal, pNGUIRS As String, pGrupo_Envio As String) As String
        '    Dim odaGuiaRemision As New daGuiasRemision
        '    Dim dt_envio_gr As New DataTable
        '    Dim obeGuiaRemision As New beGuiaRemision
        '    obeGuiaRemision.PNCCLNT = pCCLNT
        '    Dim msg_validacion As String = ""
        '    Dim url_servicio As String = ""
        '    Dim usu_servicio As String = ""
        '    Dim psw_servicio As String = ""
        '    Dim ejecutar_envio As Boolean = True

        '    Try

        '        Dim dt_url As New DataTable
        '        dt_url = odaGuiaRemision.Listar_Url_Envio_Guia(obeGuiaRemision.PNCCLNT, pGrupo_Envio, "ANUL_GR")

        '        If dt_url.Rows.Count = 0 Then
        '            msg_validacion = "Url no configurada." & Chr(13)
        '        Else
        '            url_servicio = ("" & dt_url.Rows(0)("URL")).ToString.Trim
        '            usu_servicio = ("" & dt_url.Rows(0)("USUARIO")).ToString.Trim
        '            psw_servicio = ("" & dt_url.Rows(0)("USUARIO_PWS")).ToString.Trim

        '        End If
        '        If url_servicio = "" Or usu_servicio = "" Or psw_servicio = "" Then
        '            msg_validacion = msg_validacion & " Datos url/usurio/pws incompleto" & Chr(13)
        '        End If

        '        If msg_validacion = "" Then
        '            Dim emision_gr As New RANSA.NEGO.ProxyPacasmayo_GR_Emision.ZmmrfcGreRansaEmision
        '            emision_gr.TEntrada = New ProxyPacasmayo_GR_Emision.ZmmstEmisionRansa

        '        End If


        '    Catch ex As Exception
        '        msg_validacion = msg_validacion & Chr(10) & ex.Message
        '    End Try

        '    Return msg_validacion.Trim

        'End Function


        'Public Function fintActualizarEstadoEnvioGuias(ByVal obeFiltroGuia As beGuiaRemision, estado As String, mensaje As String, usuario As String) As String
        '    Dim odaGuiaRemision As New daGuiasRemision
        '    Return odaGuiaRemision.fintActualizarEstadoEnvioGuias(obeFiltroGuia, estado, mensaje, usuario)
        'End Function
        'Public Function Listar_Datos_GuiaTransito(ByVal CCLNT As Integer, ByVal GUIRM As Integer, ByVal GUIRS As String) As DataSet
        '    Dim odaGuiaRemision As New daGuiasRemision
        '    Return odaGuiaRemision.Listar_Datos_GuiaTransito(CCLNT, GUIRM, GUIRS)
        'End Function
        'Public Function Listar_Url_Envio_Guia(ByVal CCLNT As Integer) As DataTable
        '    Dim odaGuiaRemision As New daGuiasRemision
        '    Return odaGuiaRemision.Listar_Url_Envio_Guia(CCLNT)
        'End Function
        Public Function fnValidarCLienteEnvioGuia(ByVal obeFiltroGuia As beGuiaRemision) As DataTable
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.fnValidarCLienteEnvioGuia(obeFiltroGuia)
        End Function

        Public Function Listar_Datos_GuiaTransito_Pacasmayo(ByVal intCliente As Decimal, ByVal NGUIRM As Decimal, ByVal NGUIRS As String) As DataSet
            Dim odaGuiaRemision As New daGuiasRemision
            Return odaGuiaRemision.Listar_Datos_GuiaTransito_Pacasmayo(intCliente, NGUIRM, NGUIRS)
        End Function

        Public Sub fintRegularizarEstadoEnvioGuias(ByVal obeFiltroGuia As beGuiaRemision, usuario As String)
            Dim odaGuiaRemision As New daGuiasRemision
            odaGuiaRemision.fintRegularizarEstadoEnvioGuias(obeFiltroGuia, usuario)
        End Sub


    End Class

End Namespace


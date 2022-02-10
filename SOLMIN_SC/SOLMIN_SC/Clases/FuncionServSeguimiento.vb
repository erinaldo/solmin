Imports System.Text
Imports ComponentFactory.Krypton.Toolkit.KryptonForm
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class FuncionServSeguimiento
    Enum ENUM_IDIOMA
        ING
        ESP
    End Enum

#Region "Creacion Configuracion Columnas"
    Private Function IsVisible(ByVal Visible As String)
        Dim EsVisible As Boolean = False
        EsVisible = Visible.Equals("S")
        Return EsVisible
    End Function


    Public Sub CrearConfigurarColumnas(ByVal FiltroEmbarque As beSeguimientoCargaFiltro, ByVal IDIOMA As ENUM_IDIOMA, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
        dgv.Rows.Clear()
        dgv.Columns.Clear()
        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim oDcTx As DataGridViewColumn
        Dim oDcFc As CalendarColumn

        Dim oTableroDatos As New clsTableroDatos
        Dim PSCCMPN As String = FiltroEmbarque.PSCCMPN
        Dim PNCCLNT As Decimal = FiltroEmbarque.PNCCLNT
        oDt = oTableroDatos.Llenar_Tabla_X_Opcion(PSCCMPN, PNCCLNT, "A", 1, "")

        Dim dr() As DataRow
        dr = oDt.Select("TNMBCM='NORSCI'")
        If (dr.Length = 0) Then
            oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
            oDcTx.Name = "NORSCI"
            oDcTx.HeaderText = "Embarque"
            oDcTx.Resizable = DataGridViewTriState.False
            oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
            oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            oDcTx.ReadOnly = True
            oDcTx.Frozen = True
            dgv.Columns.Add(oDcTx)
        End If

        Dim NAME_COLUMNA As String = ""
        Dim DES_COLUMNA As String = ""
        Dim EsVisible As Boolean = False
        Dim COLUMNA_IDIOMA As String = ""
        Select Case IDIOMA
            Case ENUM_IDIOMA.ESP
                COLUMNA_IDIOMA = "TCOLUM"
            Case ENUM_IDIOMA.ING
                COLUMNA_IDIOMA = "TDITIN"
        End Select
        For intCont = 0 To oDt.Rows.Count - 1
            NAME_COLUMNA = oDt.Rows(intCont).Item("TNMBCM").ToString.Trim
            DES_COLUMNA = oDt.Rows(intCont).Item(COLUMNA_IDIOMA).ToString.Trim
            EsVisible = IsVisible(oDt.Rows(intCont).Item("STPCRE").ToString.Trim)
            Select Case NAME_COLUMNA
                Case "NORSCI"

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.Visible = EsVisible
                    oDcTx.Frozen = True
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    oDcTx.ReadOnly = True
                    dgv.Columns.Add(oDcTx)

                Case "REGIMEN", "DESPACHO", "STATUS", "STATUSFIN", "REGIMENOS"

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = EsVisible
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    dgv.Columns.Add(oDcTx)

                Case "FECDCP", "FECNUM", "FECPGD", "FECLEV", "FECALM", _
                     "FECPRO", "FECPGP"

                    oDcFc = New CalendarColumn
                    oDcFc.Name = NAME_COLUMNA
                    oDcFc.HeaderText = DES_COLUMNA
                    oDcFc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcFc.Visible = EsVisible
                    oDcFc.ReadOnly = False
                    oDcFc.Tag = NPOI_SC.keyDatoFecha
                    dgv.Columns.Add(oDcFc)

                Case "RECPOP", "FAPRAR", "FAPREV", "CKCLPV", "CKRECO", _
                     "CKIGAT", "CKAECL", "CHKEPR", _
                    "CHKETD", "CHKETA", "FECFAC", "FCDCOR", "CKCROK", "CKCRDS", "FECFACIMP", "FECFACCON"

                  


                    oDcFc = New CalendarColumn
                    oDcFc.Name = NAME_COLUMNA
                    oDcFc.HeaderText = DES_COLUMNA
                    oDcFc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcFc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcFc.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcFc.Visible = EsVisible
                    oDcFc.ReadOnly = True
                    oDcFc.Tag = NPOI_SC.keyDatoFecha
                    dgv.Columns.Add(oDcFc)


                  
                Case "GFOB", "FLETE", "SEGURO", "CIF", "ADVALOREM", "IGV", "IPM", "TOTALDER", "FOB", "EXW", _
          "ITTCAG", "TASDES", "SUMIPM", "ITTCEM", "ITTGOA", "DERESP", "SOBTAS", "ANTDUM", "IMSECO", "INTCOM", "MORA"
                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = EsVisible
                    oDcTx.Tag = NPOI_SC.keyDatoNumero
                    dgv.Columns.Add(oDcTx)

                Case "QVOLMR", "QPSOAR", "NDIALB", "NDIASE"

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    oDcTx.DefaultCellStyle.Padding = New Padding(2)
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = EsVisible
                    oDcTx.Tag = NPOI_SC.keyDatoNumero
                    dgv.Columns.Add(oDcTx)


                Case "CODTPN", "PARARN", "PRARAN", "NUMFAC", _
                      "FORCML", "MONEDA", _
                         "FACORG", "FACCOP", "DEMORG", "DEMCOP", "TRACOP", "TRAORG", "VOLORG", "VOLCOP", "SEGCOP", "SEGORG", _
                    "CORORG", "CORCOP", "OTRORG", "NUMSEG"

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = EsVisible
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    dgv.Columns.Add(oDcTx)

                Case "TOBERV", "TOBERVDIF", "TOBERVEMB"
                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    oDcTx.ReadOnly = True
                    oDcTx.Width = 600
                    oDcTx.Visible = False
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    dgv.Columns.Add(oDcTx)

                Case "DOCPEN"
                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcTx.ReadOnly = False
                    oDcTx.Width = 200
                    oDcTx.Visible = EsVisible
                    oDcTx.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    dgv.Columns.Add(oDcTx)

                Case "CTRMAL", "CAGNCR", "TPRVCL", "CTRSPT", "ALMDES", "NORCML", _
                       "TNOMCOM", "TDITES", "CMEDTR", _
                       "DOCEMB", "CVPRCN", "CTRMAL", "CPRTOE", "TCARGA", "NBLTAR", "PNNMOS", _
                       "NREFCLEMB", "TTINTC", "NREFCL", "TIPENT", "TPAGME", "TCITCLOC", _
                        "QCNTITOC", "QRLCSCEMB", "NRITOCS", "CONDPAGO"

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = EsVisible
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    dgv.Columns.Add(oDcTx)


                Case "DIFDCN", "DIFPDA", "DXF8F4", "DXF4F3", "DXF6F5", _
                    "DIFERM", "DIFEME", "DIFEEP", "MNTITM", "MNTDLR", _
                    "DIFEMEPROV", "DIFNUMLLEG", "DIFCONIMPO", "DIFRECEMAT", _
                    "DIFRCCK", "PORGIM", "PCIFFOB", "PTOTDERCIF"

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = EsVisible
                    oDcTx.Tag = NPOI_SC.keyDatoNumero
                    dgv.Columns.Add(oDcTx)



                Case "IMGENVIO"
                    oDcTx = New DataGridViewImageColumn
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = True
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    dgv.Columns.Add(oDcTx)

                Case "TEXTENVIO"

                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.ReadOnly = True
                    oDcTx.Visible = True
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    dgv.Columns.Add(oDcTx)

 


                Case Else
                    oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                    oDcTx.Name = NAME_COLUMNA
                    oDcTx.HeaderText = DES_COLUMNA
                    oDcTx.Resizable = DataGridViewTriState.False
                    oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                    oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    oDcTx.Visible = EsVisible
                    oDcTx.Tag = NPOI_SC.keyDatoTexto
                    oDcTx.ReadOnly = True
                    dgv.Columns.Add(oDcTx)
            End Select
        Next intCont

        If (dgv.Columns("SESTRG") Is Nothing) Then
            oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
            oDcTx.Name = "SESTRG"
            oDcTx.HeaderText = "SESTRG"
            oDcTx.Resizable = DataGridViewTriState.False
            oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
            oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            oDcTx.Visible = False
            oDcTx.ReadOnly = True
            oDcTx.Tag = NPOI_SC.keyDatoTexto
            dgv.Columns.Add(oDcTx)
        End If
        If (dgv.Columns("SESTRG_ESTADO") Is Nothing) Then
            oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
            oDcTx.Name = "SESTRG_ESTADO"
            oDcTx.HeaderText = "Estado"
            oDcTx.Resizable = DataGridViewTriState.False
            oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
            oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            oDcTx.ReadOnly = True
            oDcTx.Tag = NPOI_SC.keyDatoTexto
            dgv.Columns.Add(oDcTx)
        End If

      

    End Sub
#End Region

#Region "Llenar Informacion"

    Public Sub Llenar_Seguimiento_Aduanero(ByVal obeSeguimientoCargaFiltro As beSeguimientoCargaFiltro, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal oListGenTipoCarga As List(Of beTipoDato), ByVal oListGenTipoDespacho As List(Of beTipoDato), ByVal oListGenAlmacenDestinoLocal As List(Of beTipoDato), ByVal odtMaestroPartidasArancelarias As DataTable, ByVal dtFeriados As DataTable)

        Dim oEmbarque As New clsEmbarque
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim EvaluaValor As Boolean = False
        Dim oDt As DataTable
        Dim oDtFac As DataTable
        Dim oDtDato As DataTable
        Dim oDtStatus As DataTable
        Dim oDtObs As DataTable
        Dim oDtObsCI As DataTable
        Dim oDtStatusCI As DataTable
        Dim oDtCostos As DataTable

        Dim oDr() As DataRow
        Dim SESTRG_EMBARQUE As String = ""

        Dim oListTipoCarga As New List(Of beTipoDato)
        Dim oCloneList As New CloneObject(Of beTipoDato)
        Dim oCloneListRegimen As New CloneObject(Of beRegimen)

        oListTipoCarga = oCloneList.CloneListObject(oListGenTipoCarga)

        Dim oListDespacho As New List(Of beTipoDato)
        oListDespacho = oCloneList.CloneListObject(oListGenTipoDespacho)

        Dim oListAlmacenDestinoLocal As New List(Of beTipoDato)
        oListAlmacenDestinoLocal = oCloneList.CloneListObject(oListGenAlmacenDestinoLocal)

        Dim PNNORSCI As Decimal = 0

        Dim odtItemEmbarcados As New DataTable
        Dim obrTransporte As New clsTransporte
        Dim odtTransporteForol As New DataTable
        obrTransporte.Transporte_Forol()
        odtTransporteForol = obrTransporte.Tabla

        Dim PSCCMPN As String = obeSeguimientoCargaFiltro.PSCCMPN
        Dim PNCCLNT As Decimal = obeSeguimientoCargaFiltro.PNCCLNT
        Dim IGV As Decimal = 0
        Dim IPM As Decimal = 0


        Dim dtResumenOCEmbarque As New DataTable
        Dim dsDatosEmbarque As New DataSet
        dsDatosEmbarque = oEmbarque.Lista_Datos_Seguimiento_Extendido(obeSeguimientoCargaFiltro)
        oDt = dsDatosEmbarque.Tables("DATOS_EMBARQUE")
        oDtFac = dsDatosEmbarque.Tables("DOCUMENTO_EMBARQUE")
        oDtDato = dsDatosEmbarque.Tables("DETALLE_EMBARQUE")
        oDtStatus = dsDatosEmbarque.Tables("CHECKPOINT_EMBARQUE")
        oDtObs = dsDatosEmbarque.Tables("OBSERVACION_EMBARQUE")
        odtItemEmbarcados = dsDatosEmbarque.Tables("ITEM_EMBARQUE")
        oDtCostos = dsDatosEmbarque.Tables("COSTOS_EMBARQUE")
        oDtObsCI = dsDatosEmbarque.Tables("OBSSERVACION_CI")
        oDtStatusCI = dsDatosEmbarque.Tables("CHECKPOINT_CI")
        dtResumenOCEmbarque = dsDatosEmbarque.Tables("RESUMEN_OC_EMBARQUE")

        Dim oDrVw As DataGridViewRow
        Dim Fila As Int32 = 0
        Dim intCont As Int32 = 0

        Dim odtResumEmb As New DataTable
        odtResumEmb = oFnAduanas.FormarDatosResumenInicialEmbarque(oDt, obeSeguimientoCargaFiltro.PNCCLNT, dtResumenOCEmbarque)

        If dgv.Columns.Count <= 0 Then
            Exit Sub
        End If
        Dim OtrosGastos As Decimal = 0

        For intCont = 0 To odtResumEmb.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dgv)
            dgv.Rows.Add(oDrVw)
            Fila = dgv.Rows.Count - 1
            dgv.Rows(Fila).Cells("NORSCI").Value = odtResumEmb.Rows(intCont)("NORSCI")
            PNNORSCI = dgv.Rows(Fila).Cells("NORSCI").Value
            oDr = oDt.Select("NORSCI=" & PNNORSCI)


            If oDr.Length > 0 Then

              

                Dim intCol As Int32 = 0
                For intCol = 0 To dgv.Columns.Count - 1
                    Select Case dgv.Columns(intCol).Name
                        Case "NORCML"
                            dgv.Rows(Fila).Cells(intCol).Value = dtResumenOC(odtResumEmb, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Órdenes de Compra"
                        Case "TNOMCOM"
                            dgv.Rows(Fila).Cells(intCol).Value = dtNOMCOM(odtResumEmb, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Comprador"
                        Case "CODTPN"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_TPN(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "TPN"
                        Case "PARARN"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Partidas_Arancelarias(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Partida Arancelaria"
                        Case "TPAGME"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Forma_Pago(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Forma de Pago"
                        Case "TIPENT"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Tipo_Entrega(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Forma de Entrega"
                        Case "TDITES"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TOBERV"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Descripción Mercaderia"
                        Case "NREFCL"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Referencia_Cliente_SegunOC(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Referencia Cliente según OC"
                        Case "FORCML"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_FECHA_OC(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Orden Compra"
                        Case "TTINTC"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_ICOTERM(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Incoterm"
                        Case "TPRVCL"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TPRVCL"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Proveedor"
                        Case "PNNMOS"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.FormatOrdenServicio(oDr(0)("PNNMOS"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Orden Servicio"
                        Case "QVOLMR"
                            If oDr(0).Item("QVOLMR").ToString.Trim <> vbNullString Then
                                dgv.Rows(Fila).Cells(intCol).Value = oDr(0)("QVOLMR")
                            End If
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Volumen"
                        Case "TCARGA"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.TipoCargaDesc_X_Embarque(oListTipoCarga, oDtDato, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Tipo Carga"
                        Case "NBLTAR"
                            If oDr(0).Item("NBLTAR").ToString.Trim <> vbNullString Then
                                dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.TipoCargaCantidad_X_Embarque(oDtDato, PNNORSCI)
                            End If
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Bultos/Cnt"
                        Case "QPSOAR"
                            If oDr(0).Item("QPSOAR").ToString.Trim <> vbNullString Then
                                dgv.Rows(Fila).Cells(intCol).Value = oDr(0).Item("QPSOAR")
                            End If
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Kg.Brutos"
                        Case "NDIALB"
                            If oDr(0).Item("NDIALB").ToString.Trim <> vbNullString Then
                                dgv.Rows(Fila).Cells(intCol).Value = oDr(0)("NDIALB")
                            End If
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Días Libres"
                        Case "NDIASE"
                            If oDr(0).Item("NDIASE").ToString.Trim <> vbNullString Then
                                dgv.Rows(Fila).Cells(intCol).Value = oDr(0)("NDIASE")
                            End If
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "SobreEstadía"

                            '********COSTOS EMBARQUE****************************************
                        Case "EXW"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTEXW", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "EXW"
                        Case "GFOB"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GFOB", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "GFOB"
                        Case "FOB"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "FOB", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FOB"
                        Case "FLETE"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "FLETE", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FLETE"
                        Case "SEGURO"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "SEGURO", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "SEGURO"
                        Case "CIF"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "CIF", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "CIF"
                        Case "ADVALOREM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ADVALO", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "ADVALOREM"
                        Case "IGV"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IGV", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "IGV"
                        Case "IPM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IPM", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "IPM"
                        Case "TOTALDER"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "TOLDER", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "TOTAL DERECHOS"
                        Case "ITTGOA"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTGOA", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "GASTOS OPERATIVOS"

                        Case "ITTCAG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTCAG", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "COMISIÓN AGENCIAMIENTO"

                        Case "COSVAR"
                            dgv.Rows(Fila).Cells(intCol).Value = CalculaTotalOtrosCostos(oDtCostos, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "OTROS COSTOS/" & Chr(13) & "Tasa Despacho+SobreTasa+Derecho Especifico+Antidumping+" & Chr(13) & "ISC+Interes Compensantorio+Mora"

                            'Case "OTSGAS"
                            '    dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "OTSGAS", oDtCostos)
                            '    dgv.Rows(Fila).Cells(intCol).ToolTipText = "TASA DESPACHO"

                        Case "TASDES"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "TASDES", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "TASA DESPACHO"

                        Case "SUMIPM"
                            IGV = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IGV", oDtCostos)
                            IPM = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IPM", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).Value = IGV + IPM
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "IGV+IPM"

                        Case "ITTCEM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ITTCEM", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "CARGO EMBARCADOR"

                        Case "DERESP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "DERESP", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "DERECHO ESPECIFICO"

                        Case "SOBTAS"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "SOBTAS", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "SOBRETASA"

                        Case "ANTIDUM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ANTIDUM", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "ANTIDUMPING"

                        Case "IMSECO"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IMSECO", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "ISC"

                        Case "INTCOM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "INTCOM", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "INTERES COMPENSATORIO"

                        Case "MORA"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "MORA", oDtCostos)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "MORA"

                            '****************************************************'
                        Case "CAGNCR"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNMAGC"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Agente de Carga"
                        Case "CTRMAL"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TTRMAL"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Terminal de Almacenamiento"
                        Case "REGIMEN"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("REGIMEN"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "REGIMEN"
                        Case "DESPACHO"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.DespachoDesc_X_Embarque(oListDespacho, oDtDato, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Despacho"
                        Case "CMEDTR"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNMMDT"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Medio Transporte"
                        Case "NUMDUA"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNRODU"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Número Dua"
                        Case "CANAL"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TCANAL"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Canal"
                        Case "TNIMCIN"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TNIMCIN"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Línea Naviera"
                        Case "CVPRCN"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TCMPVP"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Nave/Cia. Transporte"
                        Case "CPRTOE"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.FormatearPuerto(HelpClass.ToStringCvr(oDr(0)("PAI_ORIGEN")), HelpClass.ToStringCvr(oDr(0)("PUE_ORIGEN")))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Origen"
                        Case "CPRTOA"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.FormatearPuerto(HelpClass.ToStringCvr(oDr(0)("PAI_DESTINO")), HelpClass.ToStringCvr(oDr(0)("PUE_DESTINO")))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Destino"

                            '******************DOCUMENTOS EMBARQUE*****************************
                        Case "FACCOP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Factura_Copia(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA FACTURA COPIA"
                        Case "FACORG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Factura_Original(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA FACTURA ORIGINAL"
                        Case "DEMCOP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_DocEmbarque_Copia(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA DOC EMBARQUE COPIA"
                        Case "DEMORG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_DocEmbarque_Original(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA DOC EMBARQUE ORIGINAL"
                        Case "TRACOP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Traduccion_Copia(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA TRADUCCION COPIA"
                        Case "TRAORG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Traduccion_Original(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA TRADUCCION ORIGINAL"
                        Case "VOLCOP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Volante_Copia(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA VOLANTE COPIA"
                        Case "VOLORG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Volante_Original(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA VOLANTE ORIGINAL"
                        Case "SEGCOP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Seguro_Copia(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA SEGURO COPIA"
                        Case "SEGORG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Seguro_Original(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA SEGURO ORIGINAL"
                        Case "CORCOP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Certificado_Origen_Copia(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA CERTIFICADO ORIGEN COPIA"
                        Case "CORORG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Certificado_Origen_Original(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA CERTIFICADO ORIGEN ORIGINAL"
                        Case "OTRORG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Otro_Documento_Original(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA OTROS DOCUMENTOS ORIGINAL"
                        Case "NUMFAC"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Llenar_Factura(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Facturas"
                        Case "DOCEMB"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Doc_Emb(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "DOCUMENTO EMBARQUE"
                        Case "NUMSEG"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Seguro(oDtFac, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Numero de Seguro"

                            '***************************************************************************
                            '*****CHECKPOINT ADUANA**************************************************
                        Case "FECDCP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Doc_Completos(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "F. Documentos Completos"
                        Case "FECNUM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Numeracion(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Numeración"
                        Case "FECPGD"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Pago_Derechos(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Pago Derechos"
                        Case "FECLEV"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Levante(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Levante"
                        Case "FECALM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Entrega_Alm_Cliente(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Entrega Almacén"
                        Case "FECPRO"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Proforma(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Proforma"
                        Case "FECPGP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Pago_Proforma(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Pago Proforma"
                        Case "FCDCOR"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Volante(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Volante"
                        Case "FECFAC"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Entrega_Factura(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Entrega Factura"
                        Case "FECFACIMP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_EntregaFacImportaciones(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Entrega Factura a Importación"
                        Case "FECFACCON"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_EntregaFacContabilidad(oDtStatus, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Entrega Factura a Contabilidad"
                            '**************CHECKPOINT CARGA INTERNACIONAL***************
                        Case "PROFOR"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Proforma(oDtDato, PNNORSCI)
                        Case "DOCPEN"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Doc_Pendiente(oDtDato, PNNORSCI)
                        Case "CKCLPV"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_EntregaProv(oDtStatusCI, PNNORSCI)
                        Case "CKRECO"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_RecojoMaterial(oDtStatusCI, PNNORSCI)
                        Case "CKIGAT"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Llegada_Material_Al_Emb(oDtStatusCI, PNNORSCI)
                        Case "CKAECL"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_AprobacionDocs(oDtStatusCI, PNNORSCI)
                        Case "CHKEPR"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_EntregaOrigen(oDtStatusCI, PNNORSCI)
                        Case "RECPOP"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.BuscarFechaEntregaOC(oDtStatusCI, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Entrega de la OC"
                        Case "CHKETA"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.FechaNum_a_Fecha(oDr(0).Item("FAPRAR"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "ETA"
                        Case "CHKETD"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.FechaNum_a_Fecha(oDr(0).Item("FAPREV"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "ETD"
                        Case "FAPRAR"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.BuscarFechaLlegada(oDtStatusCI, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha de Llegada"
                        Case "FAPREV"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.BuscarFechaEmbarque(oDtStatusCI, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha de Embarque"
                        Case "CKCROK"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_CargaOK(oDtStatusCI, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Carga OK"
                        Case "CKCRDS"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Fecha_Carga_Discrepancia(oDtStatusCI, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Fecha Carga en Discrepancia"

                            '******************************************

                            '************************* OBSERVACIONES*******************

                        Case "TOBERV" 'observaciones carga intern. y embarque no diferenciado
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Observaciones_NoDiferenciado(oDtObsCI, oDtObs, PNNORSCI)
                        Case "TOBERVDIF"  'observaciones carga intern. y embarque  diferenciado
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Observaciones_Diferenciado(oDtObsCI, oDtObs, PNNORSCI)
                        Case "TOBERVEMB"  'observaciones solo embarque
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Observaciones_Embarque(oDtObs, PNNORSCI)

                            '********************************************************                      
                        Case "CTRSPT"
                            dgv.Rows(Fila).Cells(intCol).Value = oDr(0)("TCMTRT")
                        Case "ALMDES"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.AlmacenDestinoLocalDesc_X_Embarque(oListAlmacenDestinoLocal, oDtDato, PNNORSCI, PNCCLNT)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Almacén Destino Local"
                        Case "SESTRG"
                            dgv.Rows(Fila).Cells(intCol).Value = oDr(0)("SESTRG")
                        Case "SESTRG_ESTADO"
                            dgv.Rows(Fila).Cells(intCol).Value = oDr(0)("SESTRG_ESTADO")
                        Case "NREFCLEMB"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("NREFCL"))
                        Case "MNTDLR"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Total_Orden_Embarcada_X_Embarque_Equiv_Dolares(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Monto OC en Moneda Origen Eq Dolares"
                        Case "MNTITM"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Total_Orden_Embarcada_X_Embarque_Origen(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Monto OC en Moneda Origen"
                        Case "PRARAN"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Porcentajes_Arancel_X_Embarque(odtMaestroPartidasArancelarias, odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "% Arancel"
                        Case "REFDO1"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0).Item("REFDO1"))
                        Case "CMEDTRAGEN"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.BuscarMedioTransporteAgencia(odtTransporteForol, oDr(0).Item("TRANSPORTE_AGENCIA"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Tipo Transporte Agencia"
                        Case "TCITCLOC"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_OC_CODITEM)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Código Item"
                        Case "QCNTITOC"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_QITEM_SEGUNOC)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Cantidad según OC"
                        Case "QRLCSCEMB"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_QITEM_EMBARCADO)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Cantidad Embarcada"
                        Case "NRITOCS"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_VariosCodigos_ItemOC(odtItemEmbarcados, PNNORSCI, clsEmbarqueAduanas.TipoCodItemOC.LIST_OC_NUMITEM)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Número Item"
                        Case "MONEDA"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Moneda_OC(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Moneda"
                        Case "NOREMB"
                            dgv.Rows(Fila).Cells(intCol).Value = oDr(0).Item("NOREMB")
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Nro Embarcador"
                        Case "TAGENCIAAD"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.EsTransporteAgAduana(oDr(0)("TRANSPORTE_AGENCIA"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Tiene Transporte AG. Aduana"
                        Case "CAGNAD"
                            dgv.Rows(Fila).Cells(intCol).Value = HelpClass.ToStringCvr(oDr(0)("TCMAA"))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Agente Aduanas"
                        Case "CONDPAGO"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Condicion_Pago(odtItemEmbarcados, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Condición de Pago"
                        Case "REGIMENOS"
                            dgv.Rows(Fila).Cells(intCol).Value = String.Format("{0} - {1}", HelpClass.ToStringCvr(oDr(0)("REGIMEN")), oFnAduanas.FormatOrdenServicio(oDr(0)("PNNMOS")))
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "REGIMEN + OS"
                        Case "OCORACLE"
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = ""
                        Case "NCA"
                            dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_UltimaFechaActualizacion(oDr(0)("FCHCRT"), oDr(0)("FULTAC"), oDtObs, oDtStatus, oDtCostos, PNNORSCI)
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "FECHA ULTIMA ACTUALIZACION"


                        Case "IMGENVIO"
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Envío Interfaz"
                            Dim bmpImage As Bitmap = Nothing
                            Dim estadoImg As String = oDr(0)("FSTENV")
                            Select Case estadoImg
                                Case "S"
                                    bmpImage = My.Resources.Resources.verde
                                    dgv.Rows(Fila).Cells(intCol).Value = bmpImage
                                Case "E"
                                    bmpImage = My.Resources.Resources.Rojo
                                    dgv.Rows(Fila).Cells(intCol).Value = bmpImage
                                Case ""
                                    bmpImage = My.Resources.Resources.CuadradoBlanco
                                    dgv.Rows(Fila).Cells(intCol).Value = bmpImage
                                Case Else
                                    bmpImage = My.Resources.Resources.CuadradoBlanco
                                    dgv.Rows(Fila).Cells(intCol).Value = bmpImage
                            End Select

                        Case "TEXTENVIO"
                            dgv.Rows(Fila).Cells(intCol).ToolTipText = "Estado Envío"
                            dgv.Rows(Fila).Cells(intCol).Value = oDr(0)("STATUS_ENVIO")




                    End Select
                Next



                ActualizarCalculosColumnas(dtFeriados, dgv, Fila)

            End If
        Next intCont




        HelpUtil.ClearMemory()
    End Sub

    Private Function dtResumenOC(ByVal odtResumEmb As DataTable, ByVal NORSCI As Decimal) As String
        Dim strValor As String = ""
        For index As Integer = 0 To odtResumEmb.Rows.Count - 1
            If odtResumEmb.Rows(index)("NORSCI") = NORSCI Then
                strValor = odtResumEmb.Rows(index)("NORCML").ToString.Trim
                Exit For
            End If
        Next
        Return strValor
    End Function

    Public Function CalculaTotalOtrosCostos(ByVal oDtCostos As DataTable, ByVal PNNORSCI As Decimal) As Decimal
        Dim oFnAduanas As New clsEmbarqueAduanas
        Dim OtrosGastos As Decimal = 0
        Dim Costo As Decimal = 0
        'Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "OTSGAS", oDtCostos), Costo)
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "TASDES", oDtCostos), Costo)
        OtrosGastos = Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "DERESP", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "SOBTAS", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "ANTDUM", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "IMSECO", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "MORA", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Decimal.TryParse(oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "INTCOM", oDtCostos), Costo)
        OtrosGastos = OtrosGastos + Costo
        Return OtrosGastos
    End Function

    Private Function dtNOMCOM(ByVal odtResumEmb As DataTable, ByVal NORSCI As Decimal) As String
        Dim strValor As String = ""
        For index As Integer = 0 To odtResumEmb.Rows.Count - 1
            If odtResumEmb.Rows(index)("NORSCI") = NORSCI Then
                strValor = odtResumEmb.Rows(index)("TNOMCOM").ToString.Trim
                Exit For
            End If
        Next
        Return strValor
    End Function

    Public Sub ActualizarPor100_TotalDerechos_VS_MontoEquivDolares(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim TOTAL_DERECHO As Decimal = 0
        Dim MONTO_OC_EQUIV_DOLAR As Decimal = 0
        Dim POR_GASTOS_NACIONALIZACION As String = ""
        If dgv.Columns("PORGIM") IsNot Nothing Then
            dgv.Rows(FILA).Cells("PORGIM").ToolTipText = "(%)TOTAL DERECHOS/TOTAL OC DOLARES"
        End If
        If ExistsAllCol(dgv, "PORGIM|TOTALDER|MNTDLR") Then
            TOTAL_DERECHO = HelpClass.ToDecimalCvr(dgv.Rows(FILA).Cells("TOTALDER").Value)
            MONTO_OC_EQUIV_DOLAR = HelpClass.ToDecimalCvr(dgv.Rows(FILA).Cells("MNTDLR").Value)
            If (MONTO_OC_EQUIV_DOLAR = 0) Then
                POR_GASTOS_NACIONALIZACION = ""
            Else
                POR_GASTOS_NACIONALIZACION = Math.Round((TOTAL_DERECHO / MONTO_OC_EQUIV_DOLAR) * 100, 2).ToString
            End If
            dgv.Rows(FILA).Cells("PORGIM").Value = POR_GASTOS_NACIONALIZACION

        End If
    End Sub

    Public Sub ActualizaPorCientoCIF_FOB(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim TOTAL_FOB As Decimal = 0
        Dim TOTAL_CIF As Decimal = 0
        Dim POR_FOB_CIF As String = ""
        If dgv.Columns("PCIFFOB") IsNot Nothing Then
            dgv.Rows(FILA).Cells("PCIFFOB").ToolTipText = "(%)TOTAL CIF/TOTAL FOB"
        End If
        If ExistsAllCol(dgv, "PCIFFOB|FOB|CIF") Then
            TOTAL_FOB = HelpClass.ToDecimalCvr(dgv.Rows(FILA).Cells("FOB").Value)
            TOTAL_CIF = HelpClass.ToDecimalCvr(dgv.Rows(FILA).Cells("CIF").Value)
            If (TOTAL_FOB = 0) Then
                POR_FOB_CIF = ""
            Else
                POR_FOB_CIF = Math.Round((TOTAL_CIF / TOTAL_FOB) * 100, 2).ToString
            End If
            dgv.Rows(FILA).Cells("PCIFFOB").Value = POR_FOB_CIF
        End If
    End Sub

    'Private Sub ActualizarOtrosGastos(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
    '    'Case "GASVAR"
    '    'GastosVarios = 0
    '    'GastosVarios = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GASVAR", oDtCostos)
    '    'GastosVarios = GastosVarios + oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GASVAR", oDtCostos)
    '    'GastosVarios = GastosVarios + oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GASVAR", oDtCostos)
    '    'GastosVarios = GastosVarios + oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GASVAR", oDtCostos)
    '    'GastosVarios = GastosVarios + oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GASVAR", oDtCostos)
    '    'dgv.Rows(Fila).Cells(intCol).Value = oFnAduanas.Buscar_Costo_Total_X_Embarque(PNNORSCI, "GASVAR", oDtCostos)
    '    'dgv.Rows(Fila).Cells(intCol).ToolTipText = "OTROS GASTOS"
    '    Dim GastosVarios As Decimal = 0
    '    If dgv.Columns("GASVAR") IsNot Nothing Then
    '        dgv.Rows(FILA).Cells("GASVAR").ToolTipText = "Gastos Varios"

    '    End If

    'End Sub

    Public Sub ActualizaPorCientoTOTALDERECHO_CIF(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim TOTAL_TOTALDER As Decimal = 0
        Dim TOTAL_CIF As Decimal = 0
        Dim POR_TOTALDER_CIF As String = ""
        If dgv.Columns("PTOTDERCIF") IsNot Nothing Then
            dgv.Rows(FILA).Cells("PTOTDERCIF").ToolTipText = "(%)TOTAL DERECHO/TOTAL CIF"
        End If
        If ExistsAllCol(dgv, "PTOTDERCIF|TOTALDER|CIF") Then
            TOTAL_TOTALDER = HelpClass.ToDecimalCvr(dgv.Rows(FILA).Cells("TOTALDER").Value)
            TOTAL_CIF = HelpClass.ToDecimalCvr(dgv.Rows(FILA).Cells("CIF").Value)
            If (TOTAL_CIF = 0) Then
                POR_TOTALDER_CIF = ""
            Else
                POR_TOTALDER_CIF = Math.Round((TOTAL_TOTALDER / TOTAL_CIF) * 100, 2).ToString
            End If
            dgv.Rows(FILA).Cells("PTOTDERCIF").Value = POR_TOTALDER_CIF

        End If
    End Sub



    Public Sub ActualizarFechaActualizacionReg(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Int32)
        If dgv.Columns("NCA") IsNot Nothing Then
            dgv.Rows(Fila).Cells("NCA").ToolTipText = "Fecha Actualizacion"
        End If
        If ExistsAllCol(dgv, "NCA") Then
            dgv.Rows(Fila).Cells("NCA").Value = Now.Date.ToString("dd/MM/yyyy")
        End If
    End Sub

    Public Sub ActualizarCalculosColumnas(ByVal dtFeriados As DataTable, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Int32)
        Calcular_Numeracion_Vs_DocCompleto(dtFeriados, dgv, Fila)
        Calcular_FecAt_Vs_PagoDer(dtFeriados, dgv, Fila)
        'ADICIONADOS PARA GYM
        '*****************************************************************************************************
        ActualizarDiferencia_Embarque_VS_Llegada(dgv, Fila)
        ActualizarDiferencia_LLegada_VS_Levante(dgv, Fila)
        ActualizarDiferencia_Levante_VS_Almacen(dgv, Fila)
        ActualizarDiferencia_EntregaOC_VS_EntregaPorProveedor(dgv, Fila)
        ActualizarPor100_TotalDerechos_VS_MontoEquivDolares(dgv, Fila)
        '*****************************************************************************************************
        '*************************************************************************************************
        ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(dtFeriados, dgv, Fila)
        ActualizarDiferencia_DocumentosCompletos_VS_ETA(dtFeriados, dgv, Fila)
        ActualizarDiferencia_Numeracion_VS_PagoDerecho(dtFeriados, dgv, Fila)

        'ADICION
        ActualizaPorCientoCIF_FOB(dgv, Fila)
        ActualizaPorCientoTOTALDERECHO_CIF(dgv, Fila)
        ActualizarDiferencia_Embarque_VS_EntregaProveedor(dgv, Fila)
        ActualizarDiferencia_Numeracion_VS_Llegada(dgv, Fila)
        ActualizarDiferencia_FacRecepcion_VS_EntregaMercaderiaAlm(dgv, Fila)
        ActualizarDiferencia_FacContabilidad_VS_FacImportacion(dgv, Fila)

        ActualizaStatusFinal(dgv, Fila)
        ActualizaStatusEmbarque(dgv, Fila)

        EsCostoCompleto(dgv, Fila)
    End Sub



    Private Function ExistsAllCol(ByVal gv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal NameColumna As String) As Boolean
        Dim columnas() As String
        columnas = NameColumna.Split("|")
        Dim existenTodos As Boolean = False
        For Each Item As String In columnas
            If gv.Columns(Item) IsNot Nothing Then
                existenTodos = True
            Else
                existenTodos = False
                Exit For
            End If
        Next
        Return existenTodos
    End Function


    Public Sub EsCostoCompleto(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Int32)
        If dgv.Columns("COSTCOMPL") IsNot Nothing Then
            dgv.Rows(Fila).Cells("COSTCOMPL").ToolTipText = "Costos Completos"
        End If

        Dim ListaCostosVerificar As String = "FOB|FLETE|SEGURO|CIF|ADVALOREM"
        Dim EsCompleto As Boolean = False
        Dim Valor As Decimal = 0
        Dim strCompleto As String = ""
        If ExistsAllCol(dgv, "COSTCOMPL|" & ListaCostosVerificar) Then
            Dim ListaCosto() As String = ListaCostosVerificar.Split("|")
            Dim Costo As String = ""
            For Each Item As String In ListaCosto
                Costo = ("" & dgv.Rows(Fila).Cells(Item).Value).ToString.Trim
                If Decimal.TryParse(Costo, Valor) = True Then
                    EsCompleto = True
                Else
                    EsCompleto = False
                    Exit For
                End If
            Next
            If EsCompleto = True Then
                strCompleto = "SI"
            ElseIf EsCompleto = False Then
                strCompleto = "NO"
            End If
            dgv.Rows(Fila).Cells("COSTCOMPL").Value = strCompleto
        End If


    End Sub



    Public Sub Calcular_Numeracion_Vs_DocCompleto(ByVal dtFeriados As DataTable, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Int32)
        If dgv.Columns("DIFDCN") IsNot Nothing Then
            dgv.Rows(Fila).Cells("DIFDCN").ToolTipText = "NUMERACION VS DOC COMPLETOS"
        End If
        If ExistsAllCol(dgv, "DIFDCN|FECNUM|FECDCP") Then
            Dim lobjDrList As DataRow()
            Dim lintDias As Integer
            Dim pstrFecIni As String = ("" & dgv.Rows(Fila).Cells("FECDCP").Value).ToString.Trim
            Dim pstrFecFin As String = ("" & dgv.Rows(Fila).Cells("FECNUM").Value).ToString.Trim
            If pstrFecIni <> vbNullString AndAlso pstrFecFin <> vbNullString Then
                lobjDrList = dtFeriados.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
                lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
                dgv.Rows(Fila).Cells("DIFDCN").Value = lintDias
            Else
                dgv.Rows(Fila).Cells("DIFDCN").Value = DBNull.Value
            End If
        End If
    End Sub

    Public Sub Calcular_FecAt_Vs_PagoDer(ByVal dtFeriados As DataTable, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Integer)

        If dgv.Columns("DIFPDA") IsNot Nothing Then
            dgv.Rows(Fila).Cells("DIFPDA").ToolTipText = "ENTREGA EN ALMACEN VS PAGO DERECHOS"
        End If
        If ExistsAllCol(dgv, "DIFPDA|FECALM|FECPGD") Then
            Dim lobjDrList As DataRow()
            Dim lintDias As Integer
            Dim pstrFecIni As String = ("" & dgv.Rows(Fila).Cells("FECPGD").Value).ToString.Trim
            Dim pstrFecFin As String = ("" & dgv.Rows(Fila).Cells("FECALM").Value).ToString.Trim
            If pstrFecIni <> vbNullString AndAlso pstrFecFin <> vbNullString Then
                lobjDrList = dtFeriados.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
                lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
                dgv.Rows(Fila).Cells("DIFPDA").Value = lintDias
            Else
                dgv.Rows(Fila).Cells("DIFPDA").Value = DBNull.Value
            End If
        End If
    End Sub

    Public Sub ActualizarDiferencia_EntregaOC_VS_EntregaPorProveedor(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim CHK_ENTREGAOC_NESTDO_100 As String = ""
        If dgv.Columns("DIFRCCK") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFRCCK").ToolTipText = "ENTREGA PROVEEDOR VS ENTREGA OC"
        End If

        Dim CHK_ENTREGA_X_PROVEEDOR_NESTDO_102 As String = ""
        If ExistsAllCol(dgv, "DIFRCCK|RECPOP|CKCLPV") Then
            CHK_ENTREGAOC_NESTDO_100 = ("" & dgv.Rows(FILA).Cells("RECPOP").Value).ToString.Trim
            CHK_ENTREGA_X_PROVEEDOR_NESTDO_102 = ("" & dgv.Rows(FILA).Cells("CKCLPV").Value).ToString.Trim
            dgv.Rows(FILA).Cells("DIFRCCK").Value = DiferenciaFechas(CHK_ENTREGAOC_NESTDO_100, CHK_ENTREGA_X_PROVEEDOR_NESTDO_102)
            dgv.Rows(FILA).Cells("DIFRCCK").ToolTipText = "ENTREGA OC VS ENTREGA POR EL PROVEEDOR"

        End If
    End Sub




    Public Sub ActualizarDiferencia_Embarque_VS_Llegada(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim CHK_EMBARQUE_NESTDO_107 As String = ""
        Dim CHK_LLEGADA_108 As String = ""
        If dgv.Columns("DIFERM") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFERM").ToolTipText = "EMBARQUE VS LLEGADA"
        End If
        If ExistsAllCol(dgv, "DIFERM|FAPRAR|FAPREV") Then

            CHK_EMBARQUE_NESTDO_107 = ("" & dgv.Rows(FILA).Cells("FAPREV").Value).ToString.Trim
            CHK_LLEGADA_108 = ("" & dgv.Rows(FILA).Cells("FAPRAR").Value).ToString.Trim


            dgv.Rows(FILA).Cells("DIFERM").Value = DiferenciaFechas(CHK_EMBARQUE_NESTDO_107, CHK_LLEGADA_108)

        End If
    End Sub

    Public Sub ActualizarDiferencia_LLegada_VS_Levante(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim CHK_LLEGADA_108 As String = ""
        Dim CHK_LEVANTE_123 As String = ""
        If dgv.Columns("DIFEME") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFEME").ToolTipText = "LLEGADA VS LEVANTE"
        End If

        If ExistsAllCol(dgv, "DIFEME|FAPRAR|FECLEV") Then

            CHK_LLEGADA_108 = ("" & dgv.Rows(FILA).Cells("FAPRAR").Value).ToString.Trim
            CHK_LEVANTE_123 = ("" & dgv.Rows(FILA).Cells("FECLEV").Value).ToString.Trim
            dgv.Rows(FILA).Cells("DIFEME").Value = DiferenciaFechas(CHK_LLEGADA_108, CHK_LEVANTE_123)

        End If
    End Sub


    Public Sub ActualizarDiferencia_Levante_VS_Almacen(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim CHK_ALMACEN_124 As String = ""
        Dim CHK_LEVANTE_123 As String = ""
        If dgv.Columns("DIFEEP") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFEEP").ToolTipText = "LEVANTE VS ALMACEN"
        End If
        If ExistsAllCol(dgv, "DIFEEP|FECLEV|FECALM") Then
            CHK_ALMACEN_124 = ("" & dgv.Rows(FILA).Cells("FECALM").Value).ToString.Trim
            CHK_LEVANTE_123 = ("" & dgv.Rows(FILA).Cells("FECLEV").Value).ToString.Trim
            dgv.Rows(FILA).Cells("DIFEEP").Value = DiferenciaFechas(CHK_LEVANTE_123, CHK_ALMACEN_124)

        End If
    End Sub

    Public Sub ActualizarDiferencia_Numeracion_VS_PagoDerecho(ByVal dtFeriados As DataTable, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Int32)

        If dgv.Columns("DXF6F5") IsNot Nothing Then
            dgv.Rows(Fila).Cells("DXF6F5").ToolTipText = "PAGO DERECHOS VS NUMERACION"
        End If

        If ExistsAllCol(dgv, "DXF6F5|FECPGD|FECNUM") Then
            Dim lobjDrList As DataRow()
            Dim lintDias As Integer
            Dim pstrFecIni As String = ("" & dgv.Rows(Fila).Cells("FECNUM").Value).ToString.Trim
            Dim pstrFecFin As String = ("" & dgv.Rows(Fila).Cells("FECPGD").Value).ToString.Trim
            If pstrFecIni <> vbNullString AndAlso pstrFecFin <> vbNullString Then
                OrdenFechas(pstrFecIni, pstrFecFin)
                lobjDrList = dtFeriados.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
                lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
                dgv.Rows(Fila).Cells("DXF6F5").Value = lintDias
            Else
                dgv.Rows(Fila).Cells("DXF6F5").Value = DBNull.Value
            End If
        End If
    End Sub

    Public Sub ActualizarDiferencia_DocumentosCompletos_VS_ETA(ByVal dtFeriados As DataTable, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Int32)

        If dgv.Columns("DXF4F3") IsNot Nothing Then
            dgv.Rows(Fila).Cells("DXF4F3").ToolTipText = "DOCUMENTOS COMPLETOS VS ETA"
        End If

        If ExistsAllCol(dgv, "DXF4F3|FECDCP|CHKETA") Then
            Dim lobjDrList As DataRow()
            Dim lintDias As Integer
            Dim pstrFecIni As String = ("" & dgv.Rows(Fila).Cells("CHKETA").Value).ToString.Trim
            Dim pstrFecFin As String = ("" & dgv.Rows(Fila).Cells("FECDCP").Value).ToString.Trim
            If pstrFecIni <> vbNullString AndAlso pstrFecFin <> vbNullString Then
                OrdenFechas(pstrFecIni, pstrFecFin)
                lobjDrList = dtFeriados.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
                lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
                dgv.Rows(Fila).Cells("DXF4F3").Value = lintDias
            Else
                dgv.Rows(Fila).Cells("DXF4F3").Value = DBNull.Value
            End If
        End If

    End Sub

    Public Sub ActualizarDiferencia_FechaAlmacen_VS_DocumentosCompletos(ByVal dtFeriados As DataTable, ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal Fila As Int32)

        If dgv.Columns("DXF8F4") IsNot Nothing Then
            dgv.Rows(Fila).Cells("DXF8F4").ToolTipText = "ENTREGA ALMACEN VS DOCUMENTOS COMPLETOS"
        End If
        If ExistsAllCol(dgv, "DXF8F4|FECALM|FECDCP") Then
            Dim lobjDrList As DataRow()
            Dim lintDias As Integer
            Dim pstrFecIni As String = ("" & dgv.Rows(Fila).Cells("FECDCP").Value).ToString.Trim
            Dim pstrFecFin As String = ("" & dgv.Rows(Fila).Cells("FECALM").Value).ToString.Trim
            If pstrFecIni <> vbNullString AndAlso pstrFecFin <> vbNullString Then
                OrdenFechas(pstrFecIni, pstrFecFin)
                lobjDrList = dtFeriados.Select("FFRDO >= " & Format(CType(pstrFecIni, Date), "yyyyMMdd") & " AND FFRDO <= " & Format(CType(pstrFecFin, Date), "yyyyMMdd"))
                lintDias = fintDiferencia_Dia(pstrFecFin, pstrFecIni, lobjDrList.Length)
                dgv.Rows(Fila).Cells("DXF8F4").Value = lintDias
            Else
                dgv.Rows(Fila).Cells("DXF8F4").Value = DBNull.Value
            End If
        End If
    End Sub


    Public Sub ActualizarDiferencia_Embarque_VS_EntregaProveedor(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)

        If dgv.Columns("DIFEMEPROV") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFEMEPROV").ToolTipText = "EMBARQUE VS ENTREGA PROVEEDOR"
        End If

        Dim CHK_ENTREGAPROVEEDOR_102 As String = ""
        Dim CHK_EMBARQUE_107 As String = ""
        If ExistsAllCol(dgv, "DIFEMEPROV|FAPREV|CKCLPV") Then
            CHK_ENTREGAPROVEEDOR_102 = ("" & dgv.Rows(FILA).Cells("CKCLPV").Value).ToString.Trim
            CHK_EMBARQUE_107 = ("" & dgv.Rows(FILA).Cells("FAPREV").Value).ToString.Trim
            dgv.Rows(FILA).Cells("DIFEMEPROV").Value = DiferenciaFechas(CHK_ENTREGAPROVEEDOR_102, CHK_EMBARQUE_107)

        End If
    End Sub

    Public Sub ActualizarDiferencia_Numeracion_VS_Llegada(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)

        If dgv.Columns("DIFNUMLLEG") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFNUMLLEG").ToolTipText = "LLEGADA VS NUMERACION"
        End If

        Dim CHK_NUMERACION_121 As String = ""
        Dim CHK_LLEGADA_108 As String = ""
        If ExistsAllCol(dgv, "DIFNUMLLEG|FAPRAR|FECNUM") Then
            CHK_LLEGADA_108 = ("" & dgv.Rows(FILA).Cells("FAPRAR").Value).ToString.Trim
            CHK_NUMERACION_121 = ("" & dgv.Rows(FILA).Cells("FECNUM").Value).ToString.Trim
            dgv.Rows(FILA).Cells("DIFNUMLLEG").Value = DiferenciaFechas(CHK_LLEGADA_108, CHK_NUMERACION_121)

        End If
    End Sub

    Public Sub ActualizarDiferencia_FacContabilidad_VS_FacImportacion(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)

        If dgv.Columns("DIFCONIMPO") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFCONIMPO").ToolTipText = "FAC IMPORTACION VS FAC CONTABILIDAD"
        End If

        Dim CHK_FACIMPORTACION_153 As String = ""
        Dim CHK_FACCONTABILIDAD_154 As String = ""
        If ExistsAllCol(dgv, "DIFCONIMPO|FECFACIMP|FECFACCON") Then
            CHK_FACIMPORTACION_153 = ("" & dgv.Rows(FILA).Cells("FECFACIMP").Value).ToString.Trim
            CHK_FACCONTABILIDAD_154 = ("" & dgv.Rows(FILA).Cells("FECFACCON").Value).ToString.Trim
            dgv.Rows(FILA).Cells("DIFCONIMPO").Value = DiferenciaFechas(CHK_FACIMPORTACION_153, CHK_FACCONTABILIDAD_154)

        End If
    End Sub

    Public Sub ActualizarDiferencia_FacRecepcion_VS_EntregaMercaderiaAlm(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        If dgv.Columns("DIFRECEMAT") IsNot Nothing Then
            dgv.Rows(FILA).Cells("DIFRECEMAT").ToolTipText = "FAC FAC. RECEPCION VS ENTREGA ALMACEN"
        End If

        Dim CHK_FACRECEPCION_149 As String = ""
        Dim CHK_ENTREGA_ALMACEN_124 As String = ""
        If ExistsAllCol(dgv, "DIFRECEMAT|FECFAC|FECALM") Then
            CHK_ENTREGA_ALMACEN_124 = ("" & dgv.Rows(FILA).Cells("FECALM").Value).ToString.Trim
            CHK_FACRECEPCION_149 = ("" & dgv.Rows(FILA).Cells("FECFAC").Value).ToString.Trim
            dgv.Rows(FILA).Cells("DIFRECEMAT").Value = DiferenciaFechas(CHK_ENTREGA_ALMACEN_124, CHK_FACRECEPCION_149)

        End If
    End Sub



    Private Function CodStatusEmbarque(ByVal F_ENTREGA_EMBARCADOR As Decimal, ByVal F_EMBARQUE As Decimal, ByVal F_LLEGADA As Decimal, ByVal F_ENTREGA_ALM As Decimal) As String

        Dim COD_STATUS As Decimal = 0
        Dim FECHA_ACTUAL As Decimal = Now.Date.ToString("yyyyMMdd")
        If FECHA_ACTUAL < F_ENTREGA_EMBARCADOR OrElse F_ENTREGA_EMBARCADOR = 0 Then
            COD_STATUS = 1  '"EN FABRICACION"
        End If
        If (F_ENTREGA_EMBARCADOR <> 0 AndAlso FECHA_ACTUAL >= F_ENTREGA_EMBARCADOR) AndAlso _
            (F_ENTREGA_EMBARCADOR < F_EMBARQUE OrElse F_EMBARQUE = 0) Then
            COD_STATUS = 2  '"EN EMBARCADOR"
        End If
        If (F_EMBARQUE <> 0 AndAlso FECHA_ACTUAL >= F_EMBARQUE) AndAlso _
            (F_EMBARQUE < F_LLEGADA OrElse F_LLEGADA = 0) Then
            COD_STATUS = 3  '"EN TRANSITO"
        End If
        If (F_LLEGADA <> 0 AndAlso FECHA_ACTUAL >= F_LLEGADA) AndAlso _
            (F_LLEGADA < F_ENTREGA_ALM OrElse F_ENTREGA_ALM = 0) Then
            COD_STATUS = 4 '"EN DESPACHO DE ADUANA"
        End If

        If F_ENTREGA_ALM <> 0 AndAlso FECHA_ACTUAL >= F_ENTREGA_ALM Then
            COD_STATUS = 5 '"ENTREGADO"
        End If
        Return COD_STATUS
    End Function



    Public Sub ActualizaStatusEmbarque(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim status As String = ""
        If dgv.Columns("STATUS") IsNot Nothing Then
            dgv.Rows(FILA).Cells("STATUS").ToolTipText = "EN FABRICACION,EN EMBARCADOR,EN TRANSITO,EN ADUANA,ENTREGADO"
        End If
        If ExistsAllCol(dgv, "STATUS|CKIGAT|FAPREV|FAPRAR|FECALM") Then
            Dim F_ENTREGA_EMBARCADOR As Decimal = FechaANumero(dgv.Rows(FILA).Cells("CKIGAT").Value)
            Dim F_EMBARQUE As Decimal = FechaANumero(dgv.Rows(FILA).Cells("FAPREV").Value)
            Dim F_LLEGADA As Decimal = FechaANumero(dgv.Rows(FILA).Cells("FAPRAR").Value)
            Dim F_ENTREGA_ALM As Decimal = FechaANumero(dgv.Rows(FILA).Cells("FECALM").Value)
            Dim oclsEstado As New clsEstado
            Dim COD_STATUS As Decimal = 0
            Dim strStatus As String = ""
            Dim dtStatusEmbarque As New DataTable
            dtStatusEmbarque = oclsEstado.Listar_Status_Embarque
            COD_STATUS = CodStatusEmbarque(F_ENTREGA_EMBARCADOR, F_EMBARQUE, F_LLEGADA, F_ENTREGA_ALM)
            For Each Item As DataRow In dtStatusEmbarque.Rows
                If Item("COD") = COD_STATUS Then
                    COD_STATUS = Item("COD")
                    strStatus = Item("TEX")
                    Exit For
                End If
            Next
            If COD_STATUS > 0 Then
                status = String.Format("{0} - {1}", COD_STATUS, strStatus)
            End If
            dgv.Rows(FILA).Cells("STATUS").Value = status
            If ExistsAllCol(dgv, "CODSTATUS") Then
                dgv.Rows(FILA).Cells("CODSTATUS").Value = COD_STATUS
            End If
        End If
    End Sub

    Private Function FechaANumero(ByVal Fecha As Object) As Decimal
        Dim strFecha As String = ("" & Fecha).ToString.Trim
        Dim FechaNum As Decimal = 0
        Dim dfECHA As Date
        If strFecha.Length > 0 Then
            If Date.TryParse(strFecha, dfECHA) = True Then
                FechaNum = dfECHA.ToString("yyyyMMdd")
            End If
        End If
        Return FechaNum
    End Function

    Public Sub ActualizaStatusFinal(ByVal dgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal FILA As Int32)
        Dim strStatusFinal As String = ""
        If dgv.Columns("STATUSFIN") IsNot Nothing Then
            dgv.Rows(FILA).Cells("STATUSFIN").ToolTipText = "PENDIENTE,OK"
        End If

        If ExistsAllCol(dgv, "STATUSFIN|CKIGAT|FAPREV|FAPRAR|FECALM") Then
            Dim F_ENTREGA_EMBARCADOR As Decimal = FechaANumero(dgv.Rows(FILA).Cells("CKIGAT").Value)
            Dim F_EMBARQUE As Decimal = FechaANumero(dgv.Rows(FILA).Cells("FAPREV").Value)
            Dim F_LLEGADA As Decimal = FechaANumero(dgv.Rows(FILA).Cells("FAPRAR").Value)
            Dim F_ENTREGA_ALM As Decimal = FechaANumero(dgv.Rows(FILA).Cells("FECALM").Value)
            Dim COD_STATUS As Decimal = 0
            COD_STATUS = CodStatusEmbarque(F_ENTREGA_EMBARCADOR, F_EMBARQUE, F_LLEGADA, F_ENTREGA_ALM)
            Select Case COD_STATUS
                Case 1, 2, 3, 4
                    strStatusFinal = "PENDIENTE"
                Case 5
                    strStatusFinal = "OK"
            End Select
            dgv.Rows(FILA).Cells("STATUSFIN").Value = strStatusFinal
        End If
    End Sub



    Private Sub OrdenFechas(ByRef pstrFecIni As String, ByRef pstrFecFin As String)
        Dim Fecha1 As Decimal = 0
        Dim Fecha2 As Decimal = 0
        Dim FecIni As String = pstrFecIni
        Dim FecFin As String = pstrFecFin
        Fecha1 = Format(CType(pstrFecIni, Date), "yyyyMMdd")
        Fecha2 = Format(CType(pstrFecFin, Date), "yyyyMMdd")
        If (Fecha1 > Fecha2) Then
            pstrFecIni = FecFin
            pstrFecFin = FecIni
        End If
    End Sub

    Private Function DiferenciaFechas(ByVal FechaMenor As String, ByVal FechaMayor As String) As String
        Dim DifReferencia As String = ""
        Dim FechaMin As Date
        Dim FechaMax As Date
        If (Date.TryParse(FechaMenor, FechaMin) AndAlso Date.TryParse(FechaMayor, FechaMax)) Then
            DifReferencia = DateDiff(DateInterval.Day, FechaMin, FechaMax)
        End If
        Return DifReferencia
    End Function

    Private Function fintDiferencia_Dia(ByVal pstrDiaFinal As String, ByVal pstrDiaInicio As String, ByVal pintDia As Integer) As Integer
        Dim lintDif As Integer
        If IsDBNull(pstrDiaFinal) Or pstrDiaFinal = vbNullString Or IsDBNull(pstrDiaInicio) Or pstrDiaInicio = vbNullString Then
            Return 0
        End If
        lintDif = DateDiff(DateInterval.Day, CType(pstrDiaInicio, Date), CType(pstrDiaFinal, Date))
        If lintDif >= 0 Then
            lintDif = lintDif - pintDia
        Else
            lintDif = lintDif + pintDia
        End If
        Return lintDif
    End Function

    Public Function FormatearCabecera(ByVal HeaderText) As String
        Dim texto1 As String = ""
        Dim texto2 As String = ""
        Dim strText As String = ""
        Dim textos() As String
        Dim lenMedio As Int32 = 0
        Dim lenTotal As Int32 = 0
        textos = HeaderText.Split(" ")
        If textos.Length > 0 Then
            lenMedio = Math.Floor(HeaderText.Replace(" ", "").Length / 2)
            For Each item As String In textos
                If item.Length > 0 Then
                    If texto1.Length <= lenMedio Then
                        texto1 = texto1 & item.Trim & " "
                    Else
                        texto2 = texto2 & item.Trim & " "
                    End If
                End If
            Next
        End If
        If texto2.Length > 2 Then
            strText = texto1.Trim & Chr(10) & texto2.Trim
        Else
            strText = texto1.Trim & " " & texto2.Trim
        End If
        Return strText
    End Function


    Public Function ObtenerRutaDua(ByVal NumDua As String) As String
        NumDua = NumDua.Trim
        Dim strArr() As String
        Dim strRuta As String = ""
        strArr = NumDua.Split("-")
        If strArr.Length = 1 Then
            strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & Mid(NumDua, 8, 2)
            strRuta = strRuta & "&codaduana=" & Mid(NumDua, 1, 3)
            strRuta = strRuta & "&anoprese=" & Mid(NumDua, 4, 4)
            strRuta = strRuta & "&numecorre=" & Mid(NumDua, 10, 6)
        Else
            strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & strArr(2)
            strRuta = strRuta & "&codaduana=" & strArr(0)
            strRuta = strRuta & "&anoprese=" & strArr(1)
            strRuta = strRuta & "&numecorre=" & strArr(3)
        End If
        Return strRuta
    End Function

#End Region


End Class

Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.TypeDef.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports Ransa.NEGO
Imports Ransa.NEGO.slnSOLMIN_SAT.Almacen
Imports Ransa.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports Ransa.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Public Class frmLecturaPreDesp
    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""
    Public Lista As List(Of beCliente)
    Public objCliente As beCliente
    Private a As Boolean
    Private b As Boolean
    Private c As Boolean
    Private d As Boolean

    Private Sub frmLecturaPreDesp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            '-- Crear status por control con F4 
            Dim objAppConfig As cAppConfig = New cAppConfig
            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtClient.pCargar(ClientePK)

 

            'CargarCliente()
            dteFechaInicial.Value = Now
            dteFechaInicial.Checked = False
            dteFechaFinal.Value = Now
            dteFechaFinal.Checked = False

            objAppConfig = Nothing
            VisualizarGrilla("PRE")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
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
    Private Sub rbtPredespacho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPredespacho.CheckedChanged
        Try
            If rbtPredespacho.Checked = True Then
                VisualizarGrilla("PRE")
                'pListarReporteGrilla()
                HabilitarBotones(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub rbtBulto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtBulto.CheckedChanged
        Try
            If rbtBulto.Checked = True Then
                VisualizarGrilla("BUL")
                'pListarReporteGrilla()
                HabilitarBotones(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub
    Private Sub VisualizarGrilla(ByVal Vista As String)
        If Vista = "PRE" Then
            dgPreDespacho.Visible = True
            dgBulto.Visible = False
        ElseIf Vista = "BUL" Then
            dgPreDespacho.Visible = False
            dgBulto.Visible = True
        End If
    End Sub
    Private Sub HabilitarBotones(ByVal Habilitar As Boolean)
        tsbBuscar.Enabled = Habilitar
        tsbExportarExcel.Enabled = Habilitar
    End Sub

    'Private Sub CargarCliente()
    '    Dim obrcliente As New Ransa.Controls.Cliente.cCliente
    '    Dim obeCliente As New Ransa.Controls.Cliente.TD_Qry_Cliente_L01

    '    Dim oDtCliente As New DataTable

    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    With obeCliente
    '        .pNROPAG_NroPagina = 1
    '        .pREGPAG_NroRegPorPagina = 1000
    '        .pUsuario = objSeguridadBN.pUsuario
    '        .pCCMPN_CodigoCompania = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
    '    End With
    '    oDtCliente = obrcliente.Listar(obeCliente, "S", 1000, 0)

    '    Lista = New List(Of beCliente)

    '    For Each dr As DataRow In oDtCliente.Rows
    '        objCliente = New beCliente
    '        objCliente.Codigo = dr("CCLNT")
    '        If dr("TMTVBJ").ToString.Trim = "" Then
    '            objCliente.Descripcion = String.Format("{0}", dr("TCMPCL").ToString.Trim)
    '        Else
    '            objCliente.Descripcion = String.Format("{0}-{1}", dr("TCMPCL").ToString.Trim, dr("TMTVBJ").ToString.Trim)
    '        End If

    '        objCliente.RUC = dr("NRUC")
    '        objCliente.Estado = 0
    '        Lista.Add(objCliente)
    '    Next

    '    Dim oListColum As New Hashtable

    '    Dim oColumnas1 As New DataGridViewCheckBoxColumn
    '    oColumnas1.Name = "CHK"
    '    oColumnas1.DataPropertyName = "CHK"
    '    oColumnas1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    oColumnas1.HeaderText = "Check"
    '    oColumnas1.ReadOnly = False
    '    oColumnas1.Visible = True
    '    oListColum.Add(1, oColumnas1)

    '    Dim oColumnas As New DataGridViewTextBoxColumn
    '    oColumnas.Name = "Codigo"
    '    oColumnas.DataPropertyName = "Codigo"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    oColumnas.HeaderText = "Código"
    '    oColumnas.ReadOnly = True
    '    oColumnas.Visible = True
    '    oListColum.Add(2, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "Descripcion"
    '    oColumnas.DataPropertyName = "Descripcion"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    oColumnas.HeaderText = "Descripción"
    '    oColumnas.ReadOnly = True
    '    oColumnas.Visible = True
    '    oListColum.Add(3, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "RUC"
    '    oColumnas.DataPropertyName = "RUC"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    oColumnas.HeaderText = "RUC"
    '    oColumnas.ReadOnly = True
    '    oColumnas.Visible = True
    '    oListColum.Add(4, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "Estado"
    '    oColumnas.DataPropertyName = "Estado"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
    '    oColumnas.HeaderText = "Estado"
    '    oColumnas.Visible = False
    '    oColumnas.ReadOnly = True
    '    oListColum.Add(5, oColumnas)

    '    'Me.txtCliente2.DataSource = Lista
    '    'Me.txtCliente2.ListColumnas = oListColum
    '    'Me.txtCliente2.Cargas()
    '    'Me.txtCliente2.DispleyMember = "Descripcion"
    '    'Me.txtCliente2.ValueMember = "Codigo"
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Sub
    Private Sub pListarReporteGrilla()

        If txtClient.pCodigo <> 0 Then

            'End If
            'If txtCliente2.Resultado IsNot Nothing Then
            Dim obeFiltro As New bePreDespacho
            Dim obrConsultarAT As New brPreDespachoBulto
            Dim dstTemp As DataSet = Nothing
            'Dim dstTemp As New DataTable
            Dim oDtExcel As New DataTable
            'Dim Est As String = txtCliente2.Resultado.GetType.ToString

            With obeFiltro
                .PNCCLNT = txtClient.pCodigo
                'If Est = "Ransa.Utilitario.beCliente" Then
                '    .PNCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
                'Else

                '    .PNCCLNT = ListaCodigoClientes()
                'End If
                'If txtCodigoRecepcion.Text <> "" Then
                '    .PSCREFFW = txtCodigoRecepcion.Text.Replace(" ", "").Replace(",", "','")
                'End If
                .PNPREDESPACHO = Val(txtNroPreDespacho.Text.Trim)

                .PNFECHAINI = dteFechaInicial.Value.ToString("yyyyMMdd")
                .PNFECHAFIN = dteFechaFinal.Value.ToString("yyyyMMdd")

                If rbtBulto.Checked = True Then
                    .PSTIPOVISTA = "BLT"
                Else
                    .PSTIPOVISTA = "PRED"
                End If

                .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = Me.UcDivision_Cmb011.Division
                .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            End With
            Dim objTemp2 As New TipoDato_ResultaReporte


            dstTemp = obrConsultarAT.fdstPredespachoLectura(obeFiltro)


            If rbtPredespacho.Checked Then
                objTemp2.add_Tables(dstTemp)
                objTemp = objTemp2
                ExportarExcelPreDespacho(dstTemp.Tables(0), "G", Nothing)
                VisualizarGrilla("PRE")
            Else
                objTemp2.add_Tables(dstTemp)
                objTemp = objTemp2
                ExportarExcelBulto(dstTemp.Tables(0), "G", Nothing)
                VisualizarGrilla("BUL")
            End If
        End If
    End Sub
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtClient.pCodigo = 0 Then
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        End If

        'If txtCliente2.Resultado IsNot Nothing Then
        '    Dim Estado As String = txtCliente2.Resultado.GetType().ToString
        '    If Estado = "Ransa.Utilitario.beCliente" Then
        '        Dim ListaS As String
        '        ListaS = CType(txtCliente2.Resultado, beCliente).Codigo
        '        If ListaS Is Nothing Then
        '            tsbExportarExcel.Enabled = False
        '            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        '        End If
        '    Else
        '        Dim ListaS As New List(Of String)
        '        ListaS = CType(txtCliente2.Resultado, List(Of String))

        '        If ListaS Is Nothing Then
        '            tsbExportarExcel.Enabled = False
        '            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        '        Else
        '            If ListaS.Count = 0 Then
        '                tsbExportarExcel.Enabled = False
        '                strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        '            End If
        '        End If

        '    End If
        'Else
        '    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        'End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function
    'Private Function ListaCodigoClientes() As String
    '    Dim strCadDocumentos As String = ""
    '    Dim ListaS As New List(Of String)
    '    Dim Est As String = txtCliente2.Resultado.GetType.ToString
    '    ListaS = CType(txtCliente2.Resultado, List(Of String))
    '    For Each i As String In ListaS
    '        strCadDocumentos += i & ","
    '    Next
    '    If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
    '    Return strCadDocumentos
    'End Function
    'Private Function ListaClientes() As String
    '    Dim strCadDocumentos As String = ""
    '    Dim Cadena As String = ""
    '    Dim Est As String = txtCliente2.Resultado.GetType.ToString

    '    If Est = "Ransa.Utilitario.beCliente" Then
    '        Cadena = CType(txtCliente2.Resultado, beCliente).Descripcion
    '    Else
    '        Cadena = txtCliente2.ActiveControl.Text.ToString.Trim
    '    End If
    '    Return Cadena
    'End Function

    Private Sub ExportarExcelBulto(ByVal oDtExcel As DataTable, ByVal resultado As String, Optional ByVal oDtRe As DataTable = Nothing)
        Dim oDt As New DataTable
        Dim oDtIng As New DataTable
        Dim oDtResumen As New DataTable
        Dim NPOI As New HelpClass_NPOI_SA
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet

        If resultado = "E" Then 
            Dim oDtv2 As DataView = New DataView(oDtExcel)
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow
             
            oDt2 = oDtv2.ToTable(True)

            oDtResumen.Columns.Add("NRO_PRESDPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("FPREDESPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("NRPLTS", Type.GetType("System.String")).Caption = NPOI.FormatDato("Paletizado", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("Bulto", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("TIPO", Type.GetType("System.String")).Caption = NPOI.FormatDato("Tipo", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("USU_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Usuario Lectura", HelpClass_NPOI_SA.keyDatoTexto)

            oDtResumen.Columns.Add("F_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha Ini. Lect", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("H_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Hora Ini Lect", HelpClass_NPOI_SA.keyDatoTexto)
            'oDtResumen.Columns.Add("FLAG_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Lectura", HelpClass_NPOI_SA.keyDatoTexto)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDr = oDtResumen.NewRow()
                oDr("NRO_PRESDPACHO") = oDt2.Rows(i).Item("NRO_PRESDPACHO")
                oDr("FPREDESPACHO") = oDt2.Rows(i).Item("FPREDESPACHO")
                oDr("NRPLTS") = oDt2.Rows(i).Item("NRPLTS")
                oDr("CREFFW") = oDt2.Rows(i).Item("CREFFW")
                oDr("TIPO") = oDt2.Rows(i).Item("TIPO")
                
                oDr("USU_LECT") = oDt2.Rows(i).Item("USU_LECT")
                oDr("F_LECT") = oDt2.Rows(i).Item("F_LECT")
                oDr("H_LECT") = oDt2.Rows(i).Item("H_LECT")
                'oDr("FLAG_LECT") = oDt2.Rows(i).Item("FLAG_LECT") 
                oDtResumen.Rows.Add(oDr)
            Next

            oDtResumen.TableName = "Resumen"
            oDs.Tables.Add(oDtResumen)

            Dim strlTitulo2 As New List(Of String)
            Dim oListDtReport As New List(Of DataTable)

            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("INFORME DE PREDESPACHO - BULTO")

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList 
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta) 
            LisFiltros.Add(itemSortedList)

            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, Nothing)
        ElseIf resultado = "G" Then
            dgBulto.AutoGenerateColumns = False
            dgBulto.DataSource = oDt
        End If
    End Sub
    Private Sub ExportarExcelPreDespacho(ByVal oDtExcel As DataTable, ByVal resultado As String, Optional ByVal oDtRe As DataTable = Nothing)
        Dim oDt As New DataTable
        Dim oDtIng As New DataTable
        Dim oDtResumen As New DataTable
        Dim NPOI As New HelpClass_NPOI_SA
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet

        If resultado = "E" Then
            Dim oDtv2 As DataView = New DataView(oDtExcel)
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow

            oDt2 = oDtv2.ToTable(True)
            oDtResumen.Columns.Add("NRO_PRESDPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("FPREDESPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("USU_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Usuario Lectura", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("FINI_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha Ini. Lect.", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("HINI_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Hora Ini Lect.", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("FFIN_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha Fin Lect.", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("HFIN_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Hora Fin Lect.", HelpClass_NPOI_SA.keyDatoTexto)
            'oDtResumen.Columns.Add("PEND_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Pendiente Lectura", HelpClass_NPOI_SA.keyDatoTexto)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDr = oDtResumen.NewRow()
                oDr("NRO_PRESDPACHO") = oDt2.Rows(i).Item("NRO_PRESDPACHO")
                oDr("FPREDESPACHO") = oDt2.Rows(i).Item("FPREDESPACHO")
                oDr("USU_LECT") = oDt2.Rows(i).Item("USU_LECT")
                oDr("FINI_LECT") = oDt2.Rows(i).Item("FINI_LECT")
                oDr("HINI_LECT") = oDt2.Rows(i).Item("HINI_LECT")
                oDr("FFIN_LECT") = oDt2.Rows(i).Item("FFIN_LECT")
                oDr("HFIN_LECT") = oDt2.Rows(i).Item("HFIN_LECT")
                'oDr("PEND_LECT") = oDt2.Rows(i).Item("PEND_LECT")
                oDtResumen.Rows.Add(oDr)
            Next

            oDtResumen.TableName = "Resumen"
            oDs.Tables.Add(oDtResumen)

            Dim strlTitulo2 As New List(Of String)
            Dim oListDtReport As New List(Of DataTable) 
            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("INFORME DE PREDESPACHO")

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            LisFiltros.Add(itemSortedList)

            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, Nothing)
        ElseIf resultado = "G" Then
            dgPreDespacho.AutoGenerateColumns = False
            dgPreDespacho.DataSource = oDt
        End If
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            If fblnValidaInformacion() Then
               
                a = dteFechaInicial.Checked
                b = dteFechaFinal.Checked

                pListarReporteGrilla()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    
    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            Dim oDtExcel As New DataTable
            If rbtPredespacho.Checked Then 
                ExportarExcelPreDespacho(objTemp.Tables(0), "E", Nothing)
            Else 
                ExportarExcelBulto(objTemp.Tables(0), "E", Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

 
    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try

            If dgPreDespacho.Visible = True Then

                If dgPreDespacho.CurrentRow Is Nothing Then
                    Exit Sub
                End If


                Dim pCCMPN As String = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                Dim pIdPreDespacho As Decimal = dgPreDespacho.CurrentRow.Cells("P_NRO_PRESDPACHO").Value

                Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
                ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
                ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania

               

                ofrmCargaAdjuntos.pNroImagen = dgPreDespacho.CurrentRow.Cells("NMRGIM").Value
                ofrmCargaAdjuntos.pNroImagenGetUltimo = True
                ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL67

                ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL67(pCCMPN, pIdPreDespacho)
                ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
                ofrmCargaAdjuntos.ShowDialog()

                If ofrmCargaAdjuntos.pDialog = True Then
                    dgPreDespacho.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                    If ofrmCargaAdjuntos.pNroImagen > 0 Then
                        dgPreDespacho.CurrentRow.Cells("NMRGIM_IMG_S").Value = "X"
                    Else
                        dgPreDespacho.CurrentRow.Cells("NMRGIM_IMG_S").Value = ""
                    End If

                End If


            End If
            If dgBulto.Visible = True Then
                If dgBulto.CurrentRow Is Nothing Then
                    Exit Sub
                End If

                Dim pCCLNT As Decimal = dgBulto.CurrentRow.Cells("CCLNT").Value
                Dim pCCMPN As String = ("" & dgBulto.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                Dim pCDVSN As String = ("" & dgBulto.CurrentRow.Cells("CDVSN").Value).ToString.Trim
                Dim pCREFFW As String = ("" & dgBulto.CurrentRow.Cells("CREFFW").Value).ToString.Trim


                Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
                ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
                ofrmCargaAdjuntos.pCodCompania = pCCMPN
                ofrmCargaAdjuntos.pNroImagen = dgBulto.CurrentRow.Cells("P_NMRGIM").Value
                ofrmCargaAdjuntos.pNroImagenGetUltimo = True
                ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65I

                ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65I(pCCMPN, pCDVSN, pCCLNT, pCREFFW)
                'ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
                ofrmCargaAdjuntos.ShowDialog()

             
                If ofrmCargaAdjuntos.pDialog = True Then
                    dgBulto.CurrentRow.Cells("P_NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                    If ofrmCargaAdjuntos.pNroImagen > 0 Then
                        dgBulto.CurrentRow.Cells("P_NMRGIM_IMG_S").Value = "X"
                    Else
                        dgBulto.CurrentRow.Cells("P_NMRGIM_IMG_S").Value = ""
                    End If

                End If

            End If

           
           


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
    Private Sub dgPreDespacho_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPreDespacho.CellContentDoubleClick
        Try
            If e.ColumnIndex < 0 Then Exit Sub

            Dim ColName As String = dgPreDespacho.Columns(e.ColumnIndex).Name

            If ColName = "NMRGIM_IMG_S" Then
                If dgPreDespacho.CurrentRow Is Nothing Then
                    Exit Sub
                End If


                Dim pCCMPN As String = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                Dim pIdPreDespacho As Decimal = dgPreDespacho.CurrentRow.Cells("P_NRO_PRESDPACHO").Value

                Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
                ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
                ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania



                ofrmCargaAdjuntos.pNroImagen = dgPreDespacho.CurrentRow.Cells("NMRGIM").Value
                ofrmCargaAdjuntos.pNroImagenGetUltimo = True
                ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL67

                ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL67(pCCMPN, pIdPreDespacho)
                ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
                ofrmCargaAdjuntos.ShowDialog()

                If ofrmCargaAdjuntos.pDialog = True Then
                    dgPreDespacho.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                    If ofrmCargaAdjuntos.pNroImagen > 0 Then
                        dgPreDespacho.CurrentRow.Cells("NMRGIM_IMG_S").Value = "X"
                    Else
                        dgPreDespacho.CurrentRow.Cells("NMRGIM_IMG_S").Value = "..."
                    End If

                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgBulto_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBulto.CellContentDoubleClick
        Try
            If e.ColumnIndex < 0 Then Exit Sub
            Dim ColName As String = dgBulto.Columns(e.ColumnIndex).Name


            Select Case ColName
                Case "NMRGIM_IMG_SBL"
                    Dim pCCLNT As Decimal = dgBulto.CurrentRow.Cells("CCLNT").Value
                    Dim pCCMPN As String = ("" & dgBulto.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                    Dim pCDVSN As String = ("" & dgBulto.CurrentRow.Cells("CDVSN").Value).ToString.Trim
                    Dim pCREFFW As String = ("" & dgBulto.CurrentRow.Cells("CREFFW").Value).ToString.Trim


                    Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
                    ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
                    ofrmCargaAdjuntos.pCodCompania = pCCMPN
                    ofrmCargaAdjuntos.pNroImagen = dgBulto.CurrentRow.Cells("NMRGIM_BL").Value
                    ofrmCargaAdjuntos.pNroImagenGetUltimo = True
                    ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65I

                    ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65I(pCCMPN, pCDVSN, pCCLNT, pCREFFW)
                    ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
                    ofrmCargaAdjuntos.ShowDialog()


                    If ofrmCargaAdjuntos.pDialog = True Then
                        dgBulto.CurrentRow.Cells("NMRGIM_BL").Value = ofrmCargaAdjuntos.pNroImagen
                        If ofrmCargaAdjuntos.pNroImagen > 0 Then
                            dgBulto.CurrentRow.Cells("NMRGIM_IMG_SBL").Value = "X"
                        Else
                            dgBulto.CurrentRow.Cells("NMRGIM_IMG_SBL").Value = "..."
                        End If

                    End If


                Case "NMRGIM_IMG_SPAL"

                    Dim pCCLNT As String = dgBulto.CurrentRow.Cells("CCLNT").Value
                    Dim pNROPLT As Decimal = dgBulto.CurrentRow.Cells("NROPLT").Value

                    Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
                    ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
                    ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                    ofrmCargaAdjuntos.pNroImagen = dgBulto.CurrentRow.Cells("NMRGIM_PAL").Value
                    ofrmCargaAdjuntos.pNroImagenGetUltimo = True
                    ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
                    ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65P

                    ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65P(pCCLNT, pNROPLT)
                    ofrmCargaAdjuntos.ShowDialog()

                    If ofrmCargaAdjuntos.pDialog = True Then
                        dgBulto.CurrentRow.Cells("NMRGIM_PAL").Value = ofrmCargaAdjuntos.pNroImagen
                        If ofrmCargaAdjuntos.pNroImagen > 0 Then
                            dgBulto.CurrentRow.Cells("NMRGIM_IMG_SPAL").Value = "X"
                        Else
                            dgBulto.CurrentRow.Cells("NMRGIM_IMG_SPAL").Value = "..."
                        End If

                    End If

                Case "NMRGIM_IMG_SPD"



                    Dim pCCLNT As Decimal = dgBulto.CurrentRow.Cells("CCLNT").Value
                    Dim pCCMPN As String = ("" & dgBulto.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                    Dim pNRCTRL As Decimal = ("" & dgBulto.CurrentRow.Cells("NRO_PRESDPACHO").Value).ToString.Trim


                    Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
                    ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
                    ofrmCargaAdjuntos.pCodCompania = pCCMPN
                    ofrmCargaAdjuntos.pNroImagen = dgBulto.CurrentRow.Cells("NMRGIM_PD").Value
                    ofrmCargaAdjuntos.pNroImagenGetUltimo = True
                    ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL67

                    ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL67(pCCMPN, pNRCTRL)
                    ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
                    ofrmCargaAdjuntos.ShowDialog()


                    If ofrmCargaAdjuntos.pDialog = True Then
                        dgBulto.CurrentRow.Cells("NMRGIM_PD").Value = ofrmCargaAdjuntos.pNroImagen
                        If ofrmCargaAdjuntos.pNroImagen > 0 Then
                            dgBulto.CurrentRow.Cells("NMRGIM_IMG_SPD").Value = "X"
                        Else
                            dgBulto.CurrentRow.Cells("NMRGIM_IMG_SPD").Value = "..."
                        End If

                    End If




            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
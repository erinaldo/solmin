Imports SOLMIN_SC.Negocio
Imports System.Web
Imports System.Text
Imports Ransa.Utilitario
Public Class frmCosteoItems
    Private Sub frmCosteoItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            CargarFiltroDatos()
            dtgCostoItem.AutoGenerateColumns = False
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            Me.dtpFecFin.Value = Now
            Me.dtpFecIni.Value = Now.AddMonths(-1)
            rbFecha.Checked = True
            rbFecha_CheckedChanged(rbFecha, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub CargarFiltroDatos()

        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("VALUE")
        dtEstado.Columns.Add("DISPLAY")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("VALUE") = "T"
        dr("DISPLAY") = "::TODOS::"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "A"
        dr("DISPLAY") = "EN ATENCION"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "C"
        dr("DISPLAY") = "CERRADOS"
        dtEstado.Rows.Add(dr)

        cboEstado.DataSource = dtEstado
        cboEstado.ValueMember = "VALUE"
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.SelectedValue = "T"
        cboEstado.Enabled = False


        Dim oclsEstado As New clsEstado
        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim drTipo As DataRow
        drTipo = dtTipoOperacion.NewRow
        drTipo("COD") = "T"
        drTipo("TEX") = "TODOS"
        dtTipoOperacion.Rows.InsertAt(drTipo, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        cboTipoOperacion.SelectedValue = "IM"
        cboTipoOperacion.Enabled = False

    End Sub

    Private Sub rbOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOS.CheckedChanged
        Dim check As Boolean = rbOS.Checked
        txtFilOS.Enabled = check
        txtFilOC.Enabled = Not check
        dtpFecIni.Enabled = Not check
        dtpFecFin.Enabled = Not check
        tsExportarSIL.Visible = True
        tsExportarAgenciaOS.Visible = True
        tsExportarAgenciaOC.Visible = False
        tsExportarCierreOC.Visible = False
        tsExportarCierreOCEmb.Visible = False
        tsCierreGeneral.Visible = False
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub


    Private Sub rbOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOC.CheckedChanged
        Dim check As Boolean = rbOC.Checked
        txtFilOC.Enabled = check
        txtFilOS.Enabled = Not check
        dtpFecIni.Enabled = Not check
        dtpFecFin.Enabled = Not check
        tsExportarSIL.Visible = True
        tsExportarAgenciaOS.Visible = False
        tsExportarAgenciaOC.Visible = True
        tsExportarCierreOC.Visible = True
        tsExportarCierreOCEmb.Visible = True
        tsCierreGeneral.Visible = False
    End Sub


    Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFecha.CheckedChanged
        Dim check As Boolean = rbFecha.Checked
        dtpFecIni.Enabled = check
        dtpFecFin.Enabled = check
        txtFilOS.Enabled = Not check
        txtFilOC.Enabled = Not check
        tsExportarSIL.Visible = True
        tsExportarAgenciaOS.Visible = False
        tsExportarAgenciaOC.Visible = False
        tsExportarCierreOC.Visible = False
        tsExportarCierreOCEmb.Visible = False
        tsCierreGeneral.Visible = True
    End Sub

    Private Function Verificar_Ingreso_Filtros() As String
        Dim sbmensaje As String = ""
        txtFilOC.Text = txtFilOC.Text.Trim
        txtFilOS.Text = txtFilOS.Text.Trim
        If Me.cmbCliente.pCodigo = 0 Then
            sbmensaje = "Ingrese:" & Chr(13)
            sbmensaje = sbmensaje + "* Cliente" & Chr(3)
        End If
        If rbOS.Checked Then
            If txtFilOS.Text.Length = 0 Then
                sbmensaje = sbmensaje & "Ingrese la Órden de Servicio"
            End If
        End If
        If rbOC.Checked Then
            If txtFilOC.Text.Length = 0 Then
                sbmensaje = sbmensaje & "Ingrese la Órden de Compra"
            End If
        End If
        Return sbmensaje
    End Function

    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    Try
    '        Dim sbmensaje As String = ""
    '        sbmensaje = Verificar_Ingreso_Filtros()
    '        If (sbmensaje.Length > 0) Then
    '            MessageBox.Show(sbmensaje, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        Buscar_Costo_X_Item()
    '        ' Buscar_Costo_Cierre_OrdenCompra()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    

    Private Sub Buscar_Costo_X_Item()
        dtgCostoItem.DataSource = Nothing
        Dim oDt As New DataTable
        Dim oCostoItem As New clsCostoItem
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        Dim NORCML As String = ""
        Dim PNPNNMOS As Decimal = 0
        Dim FECHA_INI As Decimal = 0
        Dim FECHA_FIN As Decimal = 0
        If rbOS.Checked Then
            PNPNNMOS = Convert.ToDouble(txtFilOS.Text.Trim())
        Else
            PNPNNMOS = 0
        End If
        If rbOC.Checked Then
            NORCML = txtFilOC.Text.Trim.ToUpper
        Else
            NORCML = ""
        End If
        If rbFecha.Checked Then
            FECHA_INI = Format(Me.dtpFecIni.Value, "yyyyMMdd")
            FECHA_FIN = Format(Me.dtpFecFin.Value, "yyyyMMdd")
        Else
            FECHA_INI = 0
            FECHA_FIN = 99999999
        End If
        Dim CCMPN As String = GetCompania()
        Dim PSTPSRVA As String = cboTipoOperacion.SelectedValue
        Dim PSSESTRG As String = cboEstado.SelectedValue
        oDt = oCostoItem.Lista_Costo_Item_Resumido(CCMPN, Me.cmbCliente.pCodigo, NORCML, PNPNNMOS, FECHA_INI, FECHA_FIN, PSTPSRVA, PSSESTRG)
        dtgCostoItem.DataSource = oDt
    End Sub


    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function
    Private Sub tsExportarSIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExportarSIL.Click
        Try
            If Me.cmbCliente.pCodigo = 0 Then
                Exit Sub
            End If
            If (dtgCostoItem.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim odtCostosExportar As New DataTable
            Dim MdataColumna As String = ""
            Dim NameColumna As String = ""
            '********INDICAMOS QUE COLUMNAS VAN A SER TIPO TEXTO
            Dim oListTexto As New List(Of String)
            oListTexto.Add("NORSCI")
            oListTexto.Add("PNNMOS")
            oListTexto.Add("CCLNT")
            oListTexto.Add("NORCML")
            oListTexto.Add("NRITEM")
            oListTexto.Add("SBITOC")
            oListTexto.Add("TDITES")
            oListTexto.Add("CPTDAR")
            oListTexto.Add("TNRODU")
            oListTexto.Add("NSERIE")
            oListTexto.Add("NFCTCM")
            oListTexto.Add("TTINTC")
            oListTexto.Add("NDOCEM")

            oListTexto.Add("TCMPVP")
            oListTexto.Add("FAPRAR")
            oListTexto.Add("TPRVCL")
            '*******************************************************************
            'SE PASAN LOS VALORES COLUMNA DE LA GRILLA
            Dim dr As DataRow
            For Each Item As DataGridViewColumn In dtgCostoItem.Columns
                NameColumna = Item.Name
                If (Item.Visible = True) Then
                    If (oListTexto.Contains(NameColumna)) Then
                        odtCostosExportar.Columns.Add(NameColumna)
                        MdataColumna = NPOI_SC.FormatDato(Item.HeaderText, NPOI_SC.keyDatoTexto)
                        odtCostosExportar.Columns(Item.DataPropertyName).Caption = MdataColumna
                    Else
                        odtCostosExportar.Columns.Add(NameColumna)
                        MdataColumna = NPOI_SC.FormatDato(Item.HeaderText, NPOI_SC.keyDatoNumero)
                        odtCostosExportar.Columns(Item.DataPropertyName).Caption = MdataColumna
                    End If
                End If
            Next
            '**************************************************
            'SE PASAN LOS VALORES FILA DE LA GRILLA
            For Each drDatos As DataGridViewRow In dtgCostoItem.Rows
                dr = odtCostosExportar.NewRow
                For Each dcColumna As DataColumn In odtCostosExportar.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = ("" & drDatos.Cells(NameColumna).Value).ToString.Trim
                Next
                odtCostosExportar.Rows.Add(dr)
            Next
            '***********************************************************
            'Dim oLisParametros As New SortedList
            'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(2) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(3) = "Hora:|" & Now.ToString("hh:mm:ss")
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtCostosExportar, "COSTOS POR ITEM", Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtCostosExportar.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("COSTOS POR ITEM")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ReducirComisionAgencias_ReporteAgenciaOS(ByVal odtDatosgencia As DataTable) As DataTable
        '****************************************************************
        'LA COMISION DE AGENCIAS(90) ES IGUAL A LA SUMA DE TODOS AQUELLOS QUE TIENEN
        'EL MISMO NUMERO DE FACTURA DE COMISION (90).
        '****************************************************************
        Dim CODVAR As String = ""
        Dim CSRVRL As Decimal = 0
        Dim drCostoComision() As DataRow
        Dim drCostoComisionJoin() As DataRow
        Dim MontoComisionFinal As Decimal = 0
        Dim MontoComisionDolar As Decimal = 0
        Dim NDCCT1 As Decimal = 0
        drCostoComision = odtDatosgencia.Select("CODVAR='ITTCAG' AND CSRVRL=90")
        If drCostoComision.Length > 0 Then
            NDCCT1 = drCostoComision(0)("NDCCT1")
            drCostoComisionJoin = odtDatosgencia.Select("CODVAR='ITTCAG' AND NDCCT1=" & NDCCT1)
            For Each drItem As DataRow In drCostoComisionJoin
                MontoComisionFinal = MontoComisionFinal + drItem("IMPVTD")
                MontoComisionDolar = MontoComisionDolar + drItem("IVLDOL")
            Next
            If drCostoComisionJoin.Length > 0 Then
                Dim numFilas As Int32 = 0
                numFilas = odtDatosgencia.Rows.Count - 1
                For Fila As Integer = 0 To numFilas
                    If Fila <= numFilas Then
                        CODVAR = odtDatosgencia.Rows(Fila)("CODVAR").ToString.Trim
                        CSRVRL = odtDatosgencia.Rows(Fila)("CSRVRL")
                        If CODVAR = "ITTCAG" Then
                            If CSRVRL = 90 Then
                                odtDatosgencia.Rows(Fila)("IMPVTD") = MontoComisionFinal
                                odtDatosgencia.Rows(Fila)("IVLDOL") = MontoComisionDolar
                                'MontoComisionDolar
                            Else
                                odtDatosgencia.Rows.RemoveAt(Fila)
                                numFilas = numFilas - 1
                                Fila = Fila - 1
                            End If
                        End If
                    End If
                Next
            End If
        End If
        Return odtDatosgencia.Copy
    End Function

    'Private Function TitularColumnasIniciales_ReporteAgenciaOS(ByVal odtDatosExportar As DataTable) As DataTable
    '    Dim oListTexto As New List(Of String)
    '    Dim MdataColumna As String = ""
    '    Dim NPOI As New HelpClass_NPOI_SC
    '    Dim NameColumna As String = ""
    '    Dim TipoDato As String = ""
    '    Dim ColTitle As String = ""

    '    oListTexto.Add("PNNMOS")
    '    oListTexto.Add("NORCML")
    '    oListTexto.Add("NRITEM")
    '    oListTexto.Add("SBITOC")
    '    oListTexto.Add("TDITES")
    '    oListTexto.Add("CPTDAR")

    '    oListTexto.Add("TCMPVP")
    '    oListTexto.Add("FAPRAR")
    '    oListTexto.Add("NDOCEM")
    '    oListTexto.Add("TSGNMN")
    '    oListTexto.Add("TNRODU")

    '    For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
    '        NameColumna = odtDatosExportar.Columns(Columna).ColumnName

    '        If NameColumna = "TOTFOB" OrElse NameColumna = "TOTFLT" OrElse NameColumna = "TOTSEG" OrElse NameColumna = "TOTCIF" Then

    '            ColTitle = "Valor aduana|" & dtgCostoItem.Columns(NameColumna).HeaderText
    '            If oListTexto.Contains(NameColumna) Then
    '                TipoDato = HelpClass_NPOI_SC.keyDatoTexto
    '            Else
    '                TipoDato = HelpClass_NPOI_SC.keyDatoNumero
    '            End If
    '            MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
    '            odtDatosExportar.Columns(NameColumna).Caption = MdataColumna

    '        ElseIf NameColumna = "TOTADV" OrElse NameColumna = "TOTIGV" OrElse NameColumna = "TOTIPM" OrElse NameColumna = "TASDES" OrElse NameColumna = "TOTIMP" Then
    '            ColTitle = "DERECHOS|" & dtgCostoItem.Columns(NameColumna).HeaderText
    '            If oListTexto.Contains(NameColumna) Then
    '                TipoDato = HelpClass_NPOI_SC.keyDatoTexto
    '            Else
    '                TipoDato = HelpClass_NPOI_SC.keyDatoNumero
    '            End If
    '            MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
    '            odtDatosExportar.Columns(NameColumna).Caption = MdataColumna


    '        Else
    '            If dtgCostoItem.Columns(NameColumna) IsNot Nothing Then
    '                ColTitle = dtgCostoItem.Columns(NameColumna).HeaderText
    '                If oListTexto.Contains(NameColumna) Then
    '                    TipoDato = HelpClass_NPOI_SC.keyDatoTexto
    '                Else
    '                    TipoDato = HelpClass_NPOI_SC.keyDatoNumero
    '                End If
    '                MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
    '                odtDatosExportar.Columns(NameColumna).Caption = MdataColumna
    '            End If
    '        End If

    '    Next
    '    Return odtDatosExportar.Copy

    'End Function
    Private Function TitularColumnasAgencia_ReporteAgenciaOS(ByVal odtDatosgencia As DataTable, ByVal odtDatosExportar As DataTable) As DataTable
        Dim dcColumn As DataColumn
        Dim NameColumna As String = ""
        Dim TipoDato As String = ""
        Dim ColTitle As String = ""
        Dim MdataColumna As String = ""
        Dim NumDoc As String = ""
        Dim FormatDoc As String = ""
        Dim Serie As String = ""
        Dim Numeral As String = ""
        Dim TC As String = ""
        Dim oListColumns As New List(Of DataColumn)
        Dim NPOI_SC As New HelpClass_NPOI_SC
        For Fila As Integer = 0 To odtDatosgencia.Rows.Count - 1
            If odtDatosgencia.Rows(Fila)("CSRVRL") = 90 Then
                '************************************************
                'PARA LO RELACIONADO CON LA COMISION DE AGENCIAS
                '************************************************
                NameColumna = odtDatosgencia.Rows(Fila)("NORSCI") & "_" & odtDatosgencia.Rows(Fila)("CODVAR") & "_" & odtDatosgencia.Rows(Fila)("CSRVRL") & "_" & odtDatosgencia.Rows(Fila)("NCRRSR") & "_AGENCIA"
                dcColumn = New DataColumn
                'oListCostoSumatorios.Add(NameColumna, 0) 'indica si su costo se va a totalizar
                dcColumn.ColumnName = NameColumna
                NumDoc = odtDatosgencia.Rows(Fila)("NDCCT1").ToString.Trim.PadLeft(10, "0")
                Serie = NumDoc.Substring(0, 3)
                Numeral = NumDoc.Substring(Serie.Length, NumDoc.Length - Serie.Length)
                FormatDoc = Serie & "-" & Numeral
                TC = odtDatosgencia.Rows(Fila)("IMTPOC")
                ColTitle = odtDatosgencia.Rows(Fila)("TCMTPD").ToString.Trim & Chr(10) & odtDatosgencia.Rows(Fila)("TCMTRF").ToString.Trim & Chr(10) & " N°" & FormatDoc & " T.C. s/." & TC
                TipoDato = NPOI_SC.keyDatoNumero
                MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                dcColumn.Caption = MdataColumna
                oListColumns.Add(dcColumn)

            Else
                '***********************************************
                'LOS QUE NO SON COMISION DE AGENCIAS
                'ESTO ES SOLO PARA EL ORDEN EN QUE VAN APARECER LAS COLUMNAS
                '************************************************
                NameColumna = odtDatosgencia.Rows(Fila)("NORSCI") & "_" & odtDatosgencia.Rows(Fila)("CODVAR") & "_" & odtDatosgencia.Rows(Fila)("CSRVRL") & "_" & odtDatosgencia.Rows(Fila)("NCRRSR") & "_AGENCIA"
                'oListCostoSumatorios.Add(NameColumna, 0) 'indica si su costo se va a totalizar
                odtDatosExportar.Columns.Add(NameColumna)
                NumDoc = odtDatosgencia.Rows(Fila)("NDCCT1").ToString.Trim.PadLeft(10, "0")
                Serie = NumDoc.Substring(0, 3)
                Numeral = NumDoc.Substring(Serie.Length, NumDoc.Length - Serie.Length)
                FormatDoc = Serie & "-" & Numeral
                TC = odtDatosgencia.Rows(Fila)("IMTPOC")
                ColTitle = "AVISO DEBITO|" & odtDatosgencia.Rows(Fila)("TCMTPD") & Chr(10) & " N°" & FormatDoc & " T.C. s/." & TC
                TipoDato = NPOI_SC.keyDatoNumero
                MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                odtDatosExportar.Columns(NameColumna).Caption = MdataColumna
            End If
        Next
        If oListColumns.Count > 0 Then
            For Each ItemColumn As DataColumn In oListColumns
                odtDatosExportar.Columns.Add(ItemColumn)
            Next
        End If
        Return odtDatosExportar.Copy
    End Function

    Private Function PorratearCostosAgencia_ReporteAgenciaOS(ByVal odtDatosgencia As DataTable, ByVal odtDatosExportar As DataTable, ByVal oListCostoSumatorios As Hashtable, ByVal CIF_TOTAL As Decimal) As DataTable
        Dim NameColumna As String = ""
        Dim NameTMP As String = ""
        Dim NORSCI As Decimal = 0
        Dim NCRRSR As Decimal = 0
        Dim VarCostoAgencia() As String
        Dim CIF_PARCIAL As Decimal = 0
        Dim MONTO_DOLAR As Decimal = 0
        Dim VALOR_PORRATEO As Decimal = 0
        Dim drMonto() As DataRow
        Dim CODVAR As String = ""
        Dim CSRVRL As Decimal = 0
        Dim dr As DataRow
        For FILA As Integer = 0 To odtDatosExportar.Rows.Count - 1
            CIF_PARCIAL = odtDatosExportar.Rows(FILA)("TOTCIF")
            For COLUMNA As Integer = 0 To odtDatosExportar.Columns.Count - 1
                NameColumna = odtDatosExportar.Columns(COLUMNA).ColumnName
                If NameColumna.EndsWith("_AGENCIA") Then
                    NameTMP = NameColumna.Replace("_AGENCIA", "").Trim
                    VarCostoAgencia = NameTMP.Split("_")
                    NORSCI = VarCostoAgencia(0)
                    CODVAR = VarCostoAgencia(1)
                    CSRVRL = VarCostoAgencia(2)
                    NCRRSR = VarCostoAgencia(3)
                    drMonto = odtDatosgencia.Select("NORSCI=" & NORSCI & " AND CODVAR='" & CODVAR & "' AND CSRVRL=" & CSRVRL & " AND NCRRSR=" & NCRRSR)
                    If drMonto.Length > 0 Then
                        'MONTO_DOLAR = drMonto(0)("IMPVTD") 'MONTO SIN IGV
                        MONTO_DOLAR = drMonto(0)("IVLDOL") 'MONTO CON IGV
                        If CIF_TOTAL <> 0 Then
                            VALOR_PORRATEO = (CIF_PARCIAL / CIF_TOTAL) * MONTO_DOLAR
                        Else
                            VALOR_PORRATEO = 0
                        End If
                        odtDatosExportar.Rows(FILA)(NameColumna) = Math.Round(VALOR_PORRATEO, 5)
                    End If
                End If
                If oListCostoSumatorios.ContainsKey(NameColumna) Then
                    oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(FILA)(NameColumna)
                End If
            Next
        Next
        dr = odtDatosExportar.NewRow
        For Each item As DictionaryEntry In oListCostoSumatorios
            dr(item.Key) = item.Value
        Next
        odtDatosExportar.Rows.Add(dr)

        For Fila As Integer = odtDatosExportar.Rows.Count - 1 To odtDatosExportar.Rows.Count - 1
            For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                If Not oListCostoSumatorios.ContainsKey(NameColumna) Then
                    odtDatosExportar.Rows(Fila)(NameColumna) = DBNull.Value
                End If
            Next
        Next
        Return odtDatosExportar.Copy
    End Function

    Private Function IsValidoIniciar_ReporteAgenciaOS() As Boolean
        Dim PNNMOS_VALIDAR As Decimal = dtgCostoItem.Rows(0).Cells("PNNMOS").Value
        Dim IsValidoOS As Boolean = True
        For Each Item As DataGridViewRow In dtgCostoItem.Rows
            If PNNMOS_VALIDAR <> Item.Cells("PNNMOS").Value Then
                IsValidoOS = False
                Exit For
            End If
        Next
        Return IsValidoOS
    End Function

    Private Function PorratearMontoFactura(ByVal odtDatosExportar As DataTable, ByVal dtFactura As DataTable, ByVal CIF_TOTAL As Decimal) As DataTable
        Dim CIF_ACTUAL As Decimal = 0
        Dim Factor As Decimal = 0
        Dim TitDocFac As String = ""
        Dim NPOI_SC As New HelpClass_NPOI_SC
        If odtDatosExportar.Columns("FACTURA") IsNot Nothing Then
            odtDatosExportar.Columns.Remove("FACTURA")
        End If
        odtDatosExportar.Columns.Add("FACTURA", Type.GetType("System.Decimal"))
        TitDocFac = "Factura Management Fee"
        If dtFactura.Rows.Count > 0 Then
            TitDocFac = TitDocFac & "(" & dtFactura.Rows(0)("TABTPD") & ")" & Chr(10) & " N° " & dtFactura.Rows(0)("NDCCTC") & " T.C. s/." & dtFactura.Rows(0)("ITCCTC")
        End If
        odtDatosExportar.Columns("FACTURA").Caption = NPOI_SC.FormatDato(TitDocFac, NPOI_SC.keyDatoNumero)
        Dim Tot_Factura As Decimal = Val("" & dtFactura.Compute("SUM(IVLAFD)", ""))

        If CIF_TOTAL = 0 Then
            Factor = 0
        Else
            Factor = Math.Round(Tot_Factura / CIF_TOTAL, 5)
        End If
        Dim MayorCif As Decimal = 0
        Dim FilaCif As Decimal = 0
        Dim FacPorrateo As Decimal = 0
        For Fila As Integer = 0 To odtDatosExportar.Rows.Count - 1
            CIF_ACTUAL = odtDatosExportar.Rows(Fila)("TOTCIF")
            If CIF_ACTUAL > MayorCif Then
                MayorCif = CIF_ACTUAL
                FilaCif = Fila
            End If
            odtDatosExportar.Rows(Fila)("FACTURA") = Math.Round(CIF_ACTUAL * FACTOR, 4)
        Next
        FacPorrateo = 0
        FacPorrateo = odtDatosExportar.Compute("SUM(FACTURA)", "")
        If odtDatosExportar.Rows.Count > 0 Then
            odtDatosExportar.Rows(FilaCif)("FACTURA") = odtDatosExportar.Rows(FilaCif)("FACTURA") + (TOT_FACTURA - FacPorrateo)
        End If
        Return odtDatosExportar.Copy
    End Function
    Private Sub ActualizarDocFacturaComercial(ByRef odtDatosExportar As DataTable, ByVal dtDocFactura As DataTable)
        Dim DocFac As String = ""
        Dim drFac() As DataRow
        Dim Fac As String = ""
        Dim ListFac As New Hashtable
        drFac = dtDocFactura.Select("NDOCIN=2")
        For Each Item As DataRow In drFac
            Fac = ("" & Item("NDOCLI")).ToString.Trim
            If Fac.Length > 0 AndAlso Not ListFac.Contains(Fac) Then
                ListFac.Add(Fac, Fac)
                DocFac = DocFac & Fac & ","
            End If
        Next
        If DocFac.Length > 0 Then
            DocFac = DocFac.Substring(0, DocFac.Length - 1)
        End If

        For FILA As Integer = 0 To odtDatosExportar.Rows.Count - 1
            odtDatosExportar.Rows(FILA)("NDOC_FACT") = DocFac
        Next

    End Sub
    Private Sub tsExportarAgenciaOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExportarAgenciaOS.Click
        Try
            Dim CIF_TOTAL As Decimal = 0
            If dtgCostoItem.Rows.Count = 0 Then
                MessageBox.Show("No hay datos.Consulte por Orden de Servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim IsValidoOS As Boolean = True
            IsValidoOS = IsValidoIniciar_ReporteAgenciaOS()
            If IsValidoOS = False Then
                MessageBox.Show("Las Órdenes de Servicio no son iguales.Busque por OS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim oListCostoSumatorios As New Hashtable

            oListCostoSumatorios.Add("IVUNIT", 0)
            oListCostoSumatorios.Add("IVTOIT", 0)
            oListCostoSumatorios.Add("TOTFOB", 0)
            oListCostoSumatorios.Add("TOTFLT", 0)
            oListCostoSumatorios.Add("TOTSEG", 0)
            oListCostoSumatorios.Add("TOTCIF", 0)
            oListCostoSumatorios.Add("TOTADV", 0)
            oListCostoSumatorios.Add("TOTIGV", 0)
            oListCostoSumatorios.Add("TOTIPM", 0)
            oListCostoSumatorios.Add("TASDES", 0)
            oListCostoSumatorios.Add("TOTIMP", 0)
            oListCostoSumatorios.Add("FACTURA", 0)
            oListCostoSumatorios.Add("GFOB", 0)
            'oListCostoSumatorios.Add("TOTOGS", 0)

            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim NameColumna As String = ""
            Dim oCostoItem As New clsCostoItem
            Dim odtDatosgencia As New DataTable
            Dim odtDatosExportar As New DataTable

            odtDatosExportar.Columns.Add("PNNMOS").Caption = NPOI_SC.FormatDato("Orden Servicio", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("NORCML").Caption = NPOI_SC.FormatDato("Orden de Compra", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TCMPVP").Caption = NPOI_SC.FormatDato("Nave", NPOI_SC.keyDatoTexto)  'NAVE
            odtDatosExportar.Columns.Add("FAPRAR").Caption = NPOI_SC.FormatDato("ETA", NPOI_SC.keyDatoFecha)  'ETA
            odtDatosExportar.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato("Nro Doc." & Chr(10) & "Transporte", NPOI_SC.keyDatoTexto)  'NRO DOC
            odtDatosExportar.Columns.Add("NRITEM").Caption = NPOI_SC.FormatDato("Item", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("SBITOC").Caption = NPOI_SC.FormatDato("Sub Item", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TDITES").Caption = NPOI_SC.FormatDato("Descripción", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("QRLCSC").Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)  'CANTIDAD
            odtDatosExportar.Columns.Add("CPTDAR").Caption = NPOI_SC.FormatDato("Partida", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("IVUNIT").Caption = NPOI_SC.FormatDato("Valor Unitario", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("IVTOIT").Caption = NPOI_SC.FormatDato("Valor Total", NPOI_SC.keyDatoNumero)  'VALOR TOTAL
            odtDatosExportar.Columns.Add("TSGNMN").Caption = NPOI_SC.FormatDato("Moneda OC", NPOI_SC.keyDatoTexto)  'MONEDA
            odtDatosExportar.Columns.Add("NDOC_FACT").Caption = NPOI_SC.FormatDato("Nro Factura" & Chr(10) & "Comercial", NPOI_SC.keyDatoTexto)  'NRO FACTURA COMERCIAL

            odtDatosExportar.Columns.Add("GFOB").Caption = NPOI_SC.FormatDato("Gastos al FOB", NPOI_SC.keyDatoNumero)  'NRO FACTURA COMERCIAL

            odtDatosExportar.Columns.Add("TOTFOB").Caption = NPOI_SC.FormatDato("VALOR ADUANA|FOB", NPOI_SC.keyDatoNumero)  'FOB
            odtDatosExportar.Columns.Add("TOTFLT").Caption = NPOI_SC.FormatDato("VALOR ADUANA|Flete", NPOI_SC.keyDatoNumero)  'FLETE
            odtDatosExportar.Columns.Add("TOTSEG").Caption = NPOI_SC.FormatDato("VALOR ADUANA|Seguro", NPOI_SC.keyDatoNumero)  'SEGURO   ==>  VALOR ADUANA
            odtDatosExportar.Columns.Add("TOTCIF", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("VALOR ADUANA|CIF", NPOI_SC.keyDatoNumero)  'CIF

            odtDatosExportar.Columns.Add("TOTADV").Caption = NPOI_SC.FormatDato("DERECHOS|Ad Valorem", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTIGV").Caption = NPOI_SC.FormatDato("DERECHOS|I.G.V.", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTIPM").Caption = NPOI_SC.FormatDato("DERECHOS|I.P.M", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TASDES").Caption = NPOI_SC.FormatDato("DERECHOS|Tasa Despacho", NPOI_SC.keyDatoNumero)    'TASA
            odtDatosExportar.Columns.Add("TOTIMP").Caption = NPOI_SC.FormatDato("DERECHOS|Total Derechos", NPOI_SC.keyDatoNumero)    'Total impuestos 
            'odtDatosExportar.Columns.Add("TOTOGS")    'total otros gastos
            odtDatosExportar.Columns.Add("TNRODU").Caption = NPOI_SC.FormatDato("Nro DUA", NPOI_SC.keyDatoTexto)    'DUA

            Dim dr As DataRow
            Dim TotDerecho As Decimal = 0
           
            For Fila As Integer = 0 To dtgCostoItem.Rows.Count - 1
                dr = odtDatosExportar.NewRow
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If (dtgCostoItem.Columns(NameColumna) IsNot Nothing AndAlso dtgCostoItem.Rows(Fila).Cells(NameColumna).Value IsNot Nothing) Then
                        dr(NameColumna) = dtgCostoItem.Rows(Fila).Cells(NameColumna).FormattedValue
                    End If
                Next
                'HALLANDO TOTAL CIF*********************************
                If dtgCostoItem.Columns("TOTCIF") IsNot Nothing Then
                    CIF_TOTAL = CIF_TOTAL + dtgCostoItem.Rows(Fila).Cells("TOTCIF").Value
                End If
                ' ***************************************************
                TotDerecho = Val(dr("TOTADV")) + Val(dr("TOTIGV")) + Val(dr("TOTIPM")) + Val(dr("TASDES"))
                dr("TOTIMP") = TotDerecho
                odtDatosExportar.Rows.Add(dr)
            Next

            Dim CCLNT As Decimal = dtgCostoItem.Rows(0).Cells("CCLNT").Value
            Dim PNNMOS As Decimal = dtgCostoItem.Rows(0).Cells("PNNMOS").Value

            Dim PSCCMPN As String = GetCompania()
            Dim dsCosAgencia As New DataSet
            Dim dtFacturaOp As New DataTable
            Dim docFactura As New DataTable
            dsCosAgencia = oCostoItem.Lista_Costos_Agencias_X_OS(PSCCMPN, CCLNT, PNNMOS)
            odtDatosgencia = dsCosAgencia.Tables(0).Copy
            dtFacturaOp = dsCosAgencia.Tables(1).Copy
            docFactura = dsCosAgencia.Tables(2).Copy
            odtDatosgencia = ReducirComisionAgencias_ReporteAgenciaOS(odtDatosgencia)
            odtDatosExportar = TitularColumnasAgencia_ReporteAgenciaOS(odtDatosgencia, odtDatosExportar)
            For Columna As Int32 = 0 To odtDatosExportar.Columns.Count - 1
                NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                If NameColumna.EndsWith("_AGENCIA") Then
                    If Not oListCostoSumatorios.Contains(NameColumna) Then
                        oListCostoSumatorios.Add(NameColumna, 0) 'indica si su costo se va a totalizar
                    End If
                End If
            Next
            ActualizarDocFacturaComercial(odtDatosExportar, docFactura)
            odtDatosExportar = PorratearMontoFactura(odtDatosExportar, dtFacturaOp, CIF_TOTAL)
            odtDatosExportar = PorratearCostosAgencia_ReporteAgenciaOS(odtDatosgencia, odtDatosExportar, oListCostoSumatorios, CIF_TOTAL)

            'Dim oLisParametros As New SortedList
            'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(2) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(3) = "Hora:|" & Now.ToString("hh:mm:ss")
            'NPOI.ExportExcelGeneralReleaseV01(odtDatosExportar, "COSTEO DE ITEMS X ORDEN DE SERVICIO", oLisParametros)
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtDatosExportar, "COSTEO DE ITEMS X ORDEN DE SERVICIO", Nothing, oLisParametros)

            Dim oLisDatos As New List(Of DataTable)
            oLisDatos.Add(odtDatosExportar)
            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("COSTEO DE ITEMS X ORDEN DE SERVICIO")

            Dim ListFiltro As New List(Of SortedList)
            Dim ItemFiltro As SortedList
            ItemFiltro = New SortedList
            ItemFiltro.Add(ItemFiltro.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            ItemFiltro.Add(ItemFiltro.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            ItemFiltro.Add(ItemFiltro.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            ListFiltro.Add(ItemFiltro)
            NPOI_SC.ExportExcelGeneralReleaseMultiple(oLisDatos, ListTitulo, Nothing, ListFiltro, Nothing)

            'HelpClass_NPOI_SC.ExportExcel_OSAgencia(odtDatosExportar, "COSTEO DE ITEMS X ORDEN DE SERVICIO", Nothing, Lista)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsExportarAgenciaOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExportarAgenciaOC.Click

        Try
            If dtgCostoItem.Rows.Count = 0 Then
                MessageBox.Show("No hay datos.Consulte por Orden Compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim PNNMOS_VALIDAR As String = dtgCostoItem.Rows(0).Cells("NORCML").Value.ToString.Trim
            Dim IsValidoOC As Boolean = True
            For Each Item As DataGridViewRow In dtgCostoItem.Rows
                If PNNMOS_VALIDAR <> Item.Cells("NORCML").Value.ToString.Trim Then
                    IsValidoOC = False
                    Exit For
                End If
            Next
            If IsValidoOC = False Then
                MessageBox.Show("Las Órdenes de Compra no son iguales.Busque por OC.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Dim oListCostoSumatorios As New Hashtable

            'Dim oListTexto As New List(Of String)

            'oListTexto.Add("NRITEM")
            'oListTexto.Add("SBITOC")
            'oListTexto.Add("PNNMOS")
            'oListTexto.Add("TNRODU") 'dua
            'oListTexto.Add("NSERIE") 'serie
            'oListTexto.Add("NDOCEM") 'BL/AWB
            'oListTexto.Add("TDITES")
            'oListTexto.Add("NFCTCM")  'Factura
            'oListTexto.Add("TTINTC") 'Incotern

            'oListCostoSumatorios.Add("GFOB", 0)
            'oListCostoSumatorios.Add("TOTFOB", 0)
            'oListCostoSumatorios.Add("TOTFLT", 0)
            'oListCostoSumatorios.Add("TOTSEG", 0)
            'oListCostoSumatorios.Add("TOTADV", 0)
            'oListCostoSumatorios.Add("TOTIGV", 0)
            'oListCostoSumatorios.Add("TOTIPM", 0)
            'oListCostoSumatorios.Add("VALMRC", 0)


            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim NameColumna As String = ""
            Dim TipoDato As String = ""
            Dim ColTitle As String = ""
            Dim MdataColumna As String = ""
            Dim oCostoItem As New clsCostoItem
            Dim odtDatosgencia As New DataTable
            Dim odtDatosExportar As New DataTable
            Dim odtDatosCostosSIl As New DataTable


         
            odtDatosExportar.Columns.Add("NRITEM").Caption = NPOI_SC.FormatDato("Item", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("SBITOC").Caption = NPOI_SC.FormatDato("SubItem", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("PNNMOS").Caption = NPOI_SC.FormatDato("Orden de Servicio", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TNRODU").Caption = NPOI_SC.FormatDato("N° DUA", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("NSERIE").Caption = NPOI_SC.FormatDato("N° Serie", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TDITES").Caption = NPOI_SC.FormatDato("Descripción", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("NFCTCM").Caption = NPOI_SC.FormatDato("N° Factura", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TTINTC").Caption = NPOI_SC.FormatDato("Incoterm", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("VALMRC").Caption = NPOI_SC.FormatDato("Valor Factura", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("GFOB").Caption = NPOI_SC.FormatDato("Gastos al FOB", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTFOB").Caption = NPOI_SC.FormatDato("VALOR ADUANA|FOB", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTFLT").Caption = NPOI_SC.FormatDato("VALOR ADUANA|Flete", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTSEG").Caption = NPOI_SC.FormatDato("VALOR ADUANA|Seguro", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTADV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA|Advaloren", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTIGV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA|IGV", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTIPM").Caption = NPOI_SC.FormatDato("DERECHO ADUANA|IPM", NPOI_SC.keyDatoNumero)


            'For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
            '    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
            '    If dtgCostoItem.Columns(NameColumna) IsNot Nothing Then
            '        Select Case NameColumna
            '            Case "TOTFOB", "TOTFLT", "TOTSEG"
            '                ColTitle = "VALOR ADUANA |" & dtgCostoItem.Columns(NameColumna).HeaderText
            '            Case "TOTADV", "TOTIGV", "TOTIPM"
            '                ColTitle = "DERECHO ADUANA |" & dtgCostoItem.Columns(NameColumna).HeaderText
            '            Case Else
            '                ColTitle = dtgCostoItem.Columns(NameColumna).HeaderText
            '        End Select
            'Select Case NameColumna
            '    Case "", "", "", "", "", ""
            '        TipoDato = ""
            '    Case Else
            '        TipoDato = ""
            'End Select
            'If oListTexto.Contains(NameColumna) Then
            '    TipoDato = HelpClass_NPOI_SC.keyDatoTexto
            'Else
            '    TipoDato = HelpClass_NPOI_SC.keyDatoNumero
            'End If
            'MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
            'odtDatosExportar.Columns(NameColumna).Caption = MdataColumna
            '    End If
            'Next
            Dim dr As DataRow
            For Fila As Integer = 0 To dtgCostoItem.Rows.Count - 1
                dr = odtDatosExportar.NewRow
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If (dtgCostoItem.Rows(Fila).Cells(NameColumna).Value IsNot Nothing) Then
                        dr(NameColumna) = dtgCostoItem.Rows(Fila).Cells(NameColumna).FormattedValue
                    End If
                Next
                odtDatosExportar.Rows.Add(dr)
            Next


            'oListCostoSumatorios.Add("GFOB", 0)
            'oListCostoSumatorios.Add("TOTFOB", 0)
            'oListCostoSumatorios.Add("TOTFLT", 0)
            'oListCostoSumatorios.Add("TOTSEG", 0)
            'oListCostoSumatorios.Add("TOTADV", 0)
            'oListCostoSumatorios.Add("TOTIGV", 0)
            'oListCostoSumatorios.Add("TOTIPM", 0)
            'oListCostoSumatorios.Add("VALMRC", 0)

            Dim oListCostoSumatorios As New Hashtable

            For Fila As Integer = 0 To dtgCostoItem.Rows.Count - 1
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    Select Case NameColumna
                        Case "GFOB", "TOTFOB", "TOTFLT", "TOTSEG", "TOTADV", "TOTIGV", "TOTIPM", "VALMRC"
                            If Not oListCostoSumatorios.Contains(NameColumna) Then
                                oListCostoSumatorios.Add(NameColumna, 0)
                            End If
                            If oListCostoSumatorios.ContainsKey(NameColumna) Then
                                oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(Fila)(NameColumna)
                            End If
                    End Select
                 
                Next
            Next

            dr = odtDatosExportar.NewRow
            For Each item As DictionaryEntry In oListCostoSumatorios
                dr(item.Key) = item.Value
            Next
            odtDatosExportar.Rows.Add(dr)

            For Fila As Integer = odtDatosExportar.Rows.Count - 1 To odtDatosExportar.Rows.Count - 1
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If Not oListCostoSumatorios.ContainsKey(NameColumna) Then
                        odtDatosExportar.Rows(Fila)(NameColumna) = DBNull.Value
                    End If
                Next
            Next

            Dim NORMCL As String = ("" & dtgCostoItem.Rows(0).Cells("NORCML").Value).ToString.Trim
            'Dim oLisParametros As New SortedList
            'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(2) = "Orden de Compra:|" & NORMCL
            ''oLisParametros(3) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            ''oLisParametros(4) = "Hora:|" & Now.ToString("hh:mm:ss")
            ''ExportExcelGeneralReleaseV02
            '' NPOI.ExportExcelGeneralReleaseV01(odtDatosExportar, "CIERRE ORDEN DE COMPRA", oLisParametros)
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtDatosExportar, "CIERRE ORDEN DE COMPRA", Nothing, oLisParametros)


            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtDatosExportar.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Orden de Compra:|" & NORMCL)

            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("CIERRE ORDEN DE COMPRA")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub txtFilOS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFilOS.KeyPress
        If HelpUtil.SoloNumerosSinComa(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
            dtgCostoItem.DataSource = Nothing
        End If
    End Sub


    Private Function Buscar_Costo_Cierre_OrdenCompra() As DataTable
        Dim oCostoItem As New clsCostoItem
        Dim NORCML As String = ""
        If rbOC.Checked Then
            NORCML = txtFilOC.Text.Trim
        Else
            NORCML = ""
        End If
        Dim CCMPN As String = GetCompania()
        Dim oDt As New DataTable
        oDt = oCostoItem.Lista_Item_Cierre_Orden_Compra(CCMPN, Me.cmbCliente.pCodigo, NORCML)
        Return oDt
    End Function

    Private Sub tsExportarCierreOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExportarCierreOC.Click
        Try
            If dtgCostoItem.Rows.Count = 0 Then
                MessageBox.Show("No hay datos.Consulte por OC", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim PNNMOS_VALIDAR As String = dtgCostoItem.Rows(0).Cells("NORCML").Value.ToString.Trim
            Dim IsValidoOC As Boolean = True
            For Each Item As DataGridViewRow In dtgCostoItem.Rows
                If PNNMOS_VALIDAR <> Item.Cells("NORCML").Value.ToString.Trim Then
                    IsValidoOC = False
                    Exit For
                End If
            Next
            If IsValidoOC = False Then
                MessageBox.Show("Las Órdenes de Compra no son iguales.Busque por OC.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Dim oListCostoSumatorios As New Hashtable

            'Dim oListTexto As New List(Of String)

            'oListTexto.Add("NRITEM")
            'oListTexto.Add("PNNMOS")
            'oListTexto.Add("TNRODU") 'dua
            'oListTexto.Add("NDOCEM") 'BL/AWB
            'oListTexto.Add("TDITES")
            'oListTexto.Add("TTINTC") 'Incotern

            'oListCostoSumatorios.Add("GFOB", 0)
            'oListCostoSumatorios.Add("TOTFOB", 0)
            'oListCostoSumatorios.Add("TOTFLT", 0)
            'oListCostoSumatorios.Add("TOTSEG", 0)
            'oListCostoSumatorios.Add("TOTADV", 0)
            'oListCostoSumatorios.Add("TOTIGV", 0)
            'oListCostoSumatorios.Add("TOTIPM", 0)

            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim NameColumna As String = ""
            Dim TipoDato As String = ""
            Dim ColTitle As String = ""
            Dim MdataColumna As String = ""
            Dim oCostoItem As New clsCostoItem
            Dim odtDatosgencia As New DataTable
            Dim odtDatosExportar As New DataTable
            Dim odtDatosCostosSIl As New DataTable

            odtDatosExportar.Columns.Add("NRITEM").Caption = NPOI_SC.FormatDato("Nro Item", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("NRITEM").Caption = "Nro Item"

            odtDatosExportar.Columns.Add("TDITES").Caption = NPOI_SC.FormatDato("Descripción", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("TDITES").Caption = "Descripción"

            odtDatosExportar.Columns.Add("QCNTIT").Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("QCNTIT").Caption = "Cantidad "

            odtDatosExportar.Columns.Add("IVUNIT").Caption = NPOI_SC.FormatDato("Valor Unitario", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("IVUNIT").Caption = "Valor Unitario"

            odtDatosExportar.Columns.Add("TTINTC").Caption = NPOI_SC.FormatDato("INCOTERM", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("TTINTC").Caption = "INCOTERM"

            odtDatosExportar.Columns.Add("PNNMOS").Caption = NPOI_SC.FormatDato("Orden Servicio", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("PNNMOS").Caption = "Orden Servicio"

            odtDatosExportar.Columns.Add("TNRODU").Caption = NPOI_SC.FormatDato("Nro DUA", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("TNRODU").Caption = "Nro DUA"

            odtDatosExportar.Columns.Add("GFOB").Caption = NPOI_SC.FormatDato("Gastos FOB", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("GFOB").Caption = "Gastos FOB"

            odtDatosExportar.Columns.Add("TOTFOB").Caption = NPOI_SC.FormatDato("VALOR ADUANA |FOB", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTFOB").Caption = "FOB"

            odtDatosExportar.Columns.Add("TOTFLT").Caption = NPOI_SC.FormatDato("VALOR ADUANA |FLETE", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTFLT").Caption = "FLETE"

            odtDatosExportar.Columns.Add("TOTSEG").Caption = NPOI_SC.FormatDato("VALOR ADUANA |SEGURO", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTSEG").Caption = "SEGURO"

            odtDatosExportar.Columns.Add("TOTADV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA ADVALOREM", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTADV").Caption = "ADVALOREM"

            odtDatosExportar.Columns.Add("TOTIGV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA IGV", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTIGV").Caption = "IGV"

            odtDatosExportar.Columns.Add("TOTIPM").Caption = NPOI_SC.FormatDato("DERECHO ADUANA IPM", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTIPM").Caption = "IPM"

            Dim odtCierreOC As New DataTable
            odtCierreOC = Buscar_Costo_Cierre_OrdenCompra()

            'For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
            '    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
            '    If odtDatosExportar.Columns(NameColumna) IsNot Nothing Then
            '        Select Case NameColumna
            '            Case "TOTFOB", "TOTFLT", "TOTSEG"
            '                ColTitle = "VALOR ADUANA |" & odtDatosExportar.Columns(NameColumna).Caption
            '            Case "TOTADV", "TOTIGV", "TOTIPM"
            '                ColTitle = "DERECHO ADUANA |" & odtDatosExportar.Columns(NameColumna).Caption
            '            Case Else
            '                ColTitle = odtDatosExportar.Columns(NameColumna).Caption
            '        End Select
            '        If oListTexto.Contains(NameColumna) Then
            '            TipoDato = HelpClass_NPOI_SC.keyDatoTexto
            '        Else
            '            TipoDato = HelpClass_NPOI_SC.keyDatoNumero
            '        End If
            '        MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
            '        odtDatosExportar.Columns(NameColumna).Caption = MdataColumna
            '    End If
            'Next
            Dim dr As DataRow
            For Fila As Integer = 0 To odtCierreOC.Rows.Count - 1
                dr = odtDatosExportar.NewRow
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If (odtCierreOC.Rows(Fila).Item(NameColumna) IsNot Nothing) Then
                        dr(NameColumna) = odtCierreOC.Rows(Fila).Item(NameColumna)
                    End If
                Next
                odtDatosExportar.Rows.Add(dr)
            Next

            Dim oListCostoSumatorios As New Hashtable

            'oListCostoSumatorios.Add("GFOB", 0)
            'oListCostoSumatorios.Add("TOTFOB", 0)
            'oListCostoSumatorios.Add("TOTFLT", 0)
            'oListCostoSumatorios.Add("TOTSEG", 0)
            'oListCostoSumatorios.Add("TOTADV", 0)
            'oListCostoSumatorios.Add("TOTIGV", 0)
            'oListCostoSumatorios.Add("TOTIPM", 0)


            For Fila As Integer = 0 To odtCierreOC.Rows.Count - 1
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    Select Case NameColumna
                        Case "GFOB", "TOTFOB", "TOTFLT", "TOTSEG", "TOTADV", "TOTIGV", "TOTIPM"
                            If Not oListCostoSumatorios.Contains(NameColumna) Then
                                oListCostoSumatorios.Add(NameColumna, 0)
                            End If
                    End Select
                    If oListCostoSumatorios.ContainsKey(NameColumna) Then
                        oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(Fila)(NameColumna)
                    End If
                Next
            Next

            dr = odtDatosExportar.NewRow
            For Each item As DictionaryEntry In oListCostoSumatorios
                dr(item.Key) = item.Value
            Next
            odtDatosExportar.Rows.Add(dr)

            For Fila As Integer = odtDatosExportar.Rows.Count - 1 To odtDatosExportar.Rows.Count - 1
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If Not oListCostoSumatorios.ContainsKey(NameColumna) Then
                        'odtDatosExportar.Rows(Fila)(NameColumna) = HelpClass_NPOI_SC.keyNoPintValor
                        odtDatosExportar.Rows(Fila)(NameColumna) = DBNull.Value
                    End If
                Next
            Next
            Dim NORMCL As String = ("" & dtgCostoItem.Rows(0).Cells("NORCML").Value).ToString.Trim
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(1) = "Orden de Compra:|" & NORMCL
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtDatosExportar, "CIERRE ORDEN DE COMPRA", Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtDatosExportar.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Orden de Compra:|" & NORMCL)
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("CIERRE ORDEN DE COMPRA")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Function Buscar_Costo_Cierre_OrdenCompra_Embarcado() As DataTable
        Dim oCostoItem As New clsCostoItem
        Dim NORCML As String = ""
        If rbOC.Checked Then
            NORCML = txtFilOC.Text.Trim
        Else
            NORCML = ""
        End If
        Dim CCMPN As String = GetCompania()
        Dim oDt As New DataTable
        oDt = oCostoItem.Lista_Item_Cierre_Orden_Compra_Embarcado(CCMPN, Me.cmbCliente.pCodigo, NORCML)
        Return oDt
    End Function

    'Private Sub tsExportarCierreOCEmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExportarCierreOCEmb.Click
    '    Try
    '        If dtgCostoItem.Rows.Count = 0 Then
    '            MessageBox.Show("No hay datos.Consulte por OC", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Sub
    '        End If
    '        Dim PNNMOS_VALIDAR As String = dtgCostoItem.Rows(0).Cells("NORCML").Value.ToString.Trim
    '        Dim IsValidoOC As Boolean = True
    '        For Each Item As DataGridViewRow In dtgCostoItem.Rows
    '            If PNNMOS_VALIDAR <> Item.Cells("NORCML").Value.ToString.Trim Then
    '                IsValidoOC = False
    '                Exit For
    '            End If
    '        Next
    '        If IsValidoOC = False Then
    '            MessageBox.Show("Las Órdenes de Compra no son iguales.Busque por OC.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If

    '        Dim oListCostoSumatorios As New Hashtable

    '        Dim oListTexto As New List(Of String)

    '        oListTexto.Add("NRITEM")
    '        oListTexto.Add("PNNMOS")
    '        oListTexto.Add("TNRODU") 'dua
    '        oListTexto.Add("NDOCEM") 'BL/AWB
    '        oListTexto.Add("TDITES")
    '        oListTexto.Add("TTINTC") 'Incotern
    '        oListTexto.Add("DESC_MERCAD_EMBARQUE")
    '        oListTexto.Add("NDOCEM")
    '        oListTexto.Add("NRO_DOC_FACTURA")


    '        Dim oListCostoSumatorio As New List(Of String)

    '        oListCostoSumatorios.Add("GFOB", 0)
    '        oListCostoSumatorio.Add("GFOB")
    '        oListCostoSumatorios.Add("TOTFOB", 0)
    '        oListCostoSumatorio.Add("TOTFOB")
    '        oListCostoSumatorios.Add("TOTFLT", 0)
    '        oListCostoSumatorio.Add("TOTFLT")
    '        oListCostoSumatorios.Add("TOTSEG", 0)
    '        oListCostoSumatorio.Add("TOTSEG")
    '        'oListCostoSumatorios.Add("TOTOGS", 0)
    '        oListCostoSumatorios.Add("TASDES", 0)
    '        oListCostoSumatorio.Add("TOTOGS")
    '        oListCostoSumatorios.Add("TOTADV", 0)
    '        oListCostoSumatorio.Add("TOTADV")
    '        oListCostoSumatorios.Add("TOTIGV", 0)
    '        oListCostoSumatorio.Add("TOTIGV")
    '        oListCostoSumatorios.Add("TOTIPM", 0)
    '        oListCostoSumatorio.Add("TOTIPM")
    '        oListCostoSumatorios.Add("VAL_MERCAD_FACTURA", 0)
    '        oListCostoSumatorio.Add("VAL_MERCAD_FACTURA")
    '        oListCostoSumatorios.Add("IVTOIT", 0)
    '        oListCostoSumatorio.Add("IVTOIT")

    '        Dim NPOI As New HelpClass_NPOI_SC
    '        Dim NameColumna As String = ""
    '        Dim TipoDato As String = ""
    '        Dim ColTitle As String = ""
    '        Dim MdataColumna As String = ""
    '        Dim oCostoItem As New clsCostoItem
    '        Dim odtDatosgencia As New DataTable
    '        Dim odtDatosExportar As New DataTable
    '        Dim odtDatosCostosSIl As New DataTable

    '        odtDatosExportar.Columns.Add("NRITEM")
    '        odtDatosExportar.Columns("NRITEM").Caption = "Nro Item"

    '        odtDatosExportar.Columns.Add("TDITES")
    '        odtDatosExportar.Columns("TDITES").Caption = "Descripción"

    '        odtDatosExportar.Columns.Add("QCNTIT")
    '        odtDatosExportar.Columns("QCNTIT").Caption = "Cantidad"

    '        odtDatosExportar.Columns.Add("IVUNIT")
    '        odtDatosExportar.Columns("IVUNIT").Caption = "Valor Unitario"


    '        odtDatosExportar.Columns.Add("IVTOIT")
    '        odtDatosExportar.Columns("IVTOIT").Caption = "Valor Total"

    '        odtDatosExportar.Columns.Add("TTINTC")
    '        odtDatosExportar.Columns("TTINTC").Caption = "INCOTERM"

    '        odtDatosExportar.Columns.Add("PNNMOS")
    '        odtDatosExportar.Columns("PNNMOS").Caption = "Orden Servicio"

    '        odtDatosExportar.Columns.Add("TNRODU")
    '        odtDatosExportar.Columns("TNRODU").Caption = "Nro DUA"

    '        odtDatosExportar.Columns.Add("NDOCEM")
    '        odtDatosExportar.Columns("NDOCEM").Caption = "BL/AWB"

    '        odtDatosExportar.Columns.Add("DESC_MERCAD_EMBARQUE")
    '        odtDatosExportar.Columns("DESC_MERCAD_EMBARQUE").Caption = "Descripción Embarque Aduana"

    '        odtDatosExportar.Columns.Add("NRO_DOC_FACTURA")
    '        odtDatosExportar.Columns("NRO_DOC_FACTURA").Caption = "Factura"


    '        odtDatosExportar.Columns.Add("VAL_MERCAD_FACTURA")
    '        odtDatosExportar.Columns("VAL_MERCAD_FACTURA").Caption = "Valor Factura"


    '        odtDatosExportar.Columns.Add("GFOB")
    '        odtDatosExportar.Columns("GFOB").Caption = "Gastos FOB"

    '        odtDatosExportar.Columns.Add("TOTFOB")
    '        odtDatosExportar.Columns("TOTFOB").Caption = "FOB"

    '        odtDatosExportar.Columns.Add("TOTFLT")
    '        odtDatosExportar.Columns("TOTFLT").Caption = "FLETE"

    '        odtDatosExportar.Columns.Add("TOTSEG")
    '        odtDatosExportar.Columns("TOTSEG").Caption = "SEGURO"


    '        'odtDatosExportar.Columns.Add("TOTOGS")
    '        'odtDatosExportar.Columns("TOTOGS").Caption = "TASA DESPACHO"
    '        odtDatosExportar.Columns.Add("TASDES")
    '        odtDatosExportar.Columns("TASDES").Caption = "TASA DESPACHO"

    '        odtDatosExportar.Columns.Add("TOTADV")
    '        odtDatosExportar.Columns("TOTADV").Caption = "ADVALOREM"

    '        odtDatosExportar.Columns.Add("TOTIGV")
    '        odtDatosExportar.Columns("TOTIGV").Caption = "IGV"

    '        odtDatosExportar.Columns.Add("TOTIPM")
    '        odtDatosExportar.Columns("TOTIPM").Caption = "IPM"

    '        Dim odtCierreOC As New DataTable
    '        odtCierreOC = Buscar_Costo_Cierre_OrdenCompra_Embarcado()

    '        Dim TITULO As String = ""
    '        TITULO = "CIERRE DE ORDEN DE COMPRA(" & cmbCliente.pCodigo & ") - " & cmbCliente.pRazonSocial
    '        If odtCierreOC.Rows.Count > 0 Then
    '            TITULO = "CIERRE DE ORDEN DE COMPRA(" & odtCierreOC.Rows(0)("CCLNT") & ") - " & odtCierreOC.Rows(0)("TCMPCL").ToString.Trim & " - " & odtCierreOC.Rows(0)("TMTVBJ").ToString.Trim
    '        End If

    '        For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
    '            NameColumna = odtDatosExportar.Columns(Columna).ColumnName
    '            If odtDatosExportar.Columns(NameColumna) IsNot Nothing Then
    '                Select Case NameColumna
    '                    Case "TOTFOB", "TOTFLT", "TOTSEG"
    '                        ColTitle = "VALOR ADUANA |" & odtDatosExportar.Columns(NameColumna).Caption
    '                    Case "TOTOGS", "TOTADV", "TOTIGV", "TOTIPM"
    '                        ColTitle = "DERECHO ADUANA |" & odtDatosExportar.Columns(NameColumna).Caption
    '                    Case Else
    '                        ColTitle = odtDatosExportar.Columns(NameColumna).Caption
    '                End Select
    '                If oListTexto.Contains(NameColumna) Then
    '                    TipoDato = HelpClass_NPOI_SC.keyDatoTexto
    '                Else
    '                    TipoDato = HelpClass_NPOI_SC.keyDatoNumero
    '                End If
    '                MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
    '                odtDatosExportar.Columns(NameColumna).Caption = MdataColumna
    '            End If
    '        Next
    '        Dim dr As DataRow
    '        For Fila As Integer = 0 To odtCierreOC.Rows.Count - 1
    '            dr = odtDatosExportar.NewRow
    '            For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
    '                NameColumna = odtDatosExportar.Columns(Columna).ColumnName
    '                If (odtCierreOC.Rows(Fila).Item(NameColumna) IsNot Nothing) Then
    '                    Select Case NameColumna
    '                        'Case "TOTOGS", "TOTADV", "TOTIGV", "TOTIPM"
    '                        Case "TASDES", "TOTADV", "TOTIGV", "TOTIPM"
    '                            'PARA VALORES DE DERECHO ADUANA ES NECESARIO 
    '                            'REDONDEARLOS
    '                            dr(NameColumna) = Math.Round(odtCierreOC.Rows(Fila).Item(NameColumna), 0)
    '                        Case "QCNTIT", "IVUNIT", "IVTOIT", "VAL_MERCAD_FACTURA", "TOTFOB", _
    '                             "TOTFLT", "TOTSEG", "TOTCIF", "GFOB", "ITTEXW"
    '                            dr(NameColumna) = Math.Round(odtCierreOC.Rows(Fila).Item(NameColumna), 2)
    '                        Case Else
    '                            dr(NameColumna) = odtCierreOC.Rows(Fila).Item(NameColumna)
    '                    End Select


    '                End If
    '            Next
    '            odtDatosExportar.Rows.Add(dr)
    '        Next



    '        Dim ListNroItemSumado As New List(Of Decimal)
    '        For Fila As Integer = 0 To odtCierreOC.Rows.Count - 1
    '            For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
    '                NameColumna = odtDatosExportar.Columns(Columna).ColumnName
    '                If oListCostoSumatorios.ContainsKey(NameColumna) Then
    '                    Select Case NameColumna
    '                        Case "IVTOIT"
    '                            If Not ListNroItemSumado.Contains(odtDatosExportar.Rows(Fila)("NRITEM")) Then
    '                                ListNroItemSumado.Add(odtDatosExportar.Rows(Fila)("NRITEM"))
    '                                oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(Fila)(NameColumna)
    '                            Else
    '                                odtDatosExportar.Rows(Fila)("IVTOIT") = 0
    '                            End If
    '                        Case Else
    '                            oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(Fila)(NameColumna)
    '                    End Select
    '                End If
    '            Next
    '        Next
    '        dr = odtDatosExportar.NewRow
    '        For Each item As DictionaryEntry In oListCostoSumatorios
    '            dr(item.Key) = item.Value
    '        Next
    '        odtDatosExportar.Rows.Add(dr)

    '        For Fila As Integer = odtDatosExportar.Rows.Count - 1 To odtDatosExportar.Rows.Count - 1
    '            For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
    '                NameColumna = odtDatosExportar.Columns(Columna).ColumnName
    '                If Not oListCostoSumatorios.ContainsKey(NameColumna) Then
    '                    odtDatosExportar.Rows(Fila)(NameColumna) = DBNull.Value
    '                End If
    '            Next
    '        Next
    '        Dim NORMCL As String = ("" & dtgCostoItem.Rows(0).Cells("NORCML").Value).ToString.Trim
    '        Dim oLisParametros As New SortedList
    '        oLisParametros(0) = "ORDEN DE COMPRA :|" & NORMCL
    '        Dim oListFormatComaMiles As New List(Of String)

    '        oListFormatComaMiles.Add("VAL_MERCAD_FACTURA")
    '        oListFormatComaMiles.Add("TOTFOB")
    '        oListFormatComaMiles.Add("TOTFLT")
    '        oListFormatComaMiles.Add("TOTSEG")
    '        oListFormatComaMiles.Add("TOTCIF")
    '        oListFormatComaMiles.Add("TOTADV")
    '        oListFormatComaMiles.Add("TOTIGV")
    '        oListFormatComaMiles.Add("TOTIPM")
    '        'oListFormatComaMiles.Add("TOTOGS")
    '        oListFormatComaMiles.Add("TASDES")
    '        oListFormatComaMiles.Add("GFOB")
    '        oListFormatComaMiles.Add("QCNTIT")
    '        oListFormatComaMiles.Add("IVUNIT")
    '        oListFormatComaMiles.Add("IVTOIT")
    '        oListFormatComaMiles.Add("IVTOIT")
    '        NPOI.ExportExcelCierreOrdenCompra(odtDatosExportar, TITULO, oListFormatComaMiles, oListCostoSumatorio, oLisParametros)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub tsExportarCierreOCEmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExportarCierreOCEmb.Click
        Try
            If dtgCostoItem.Rows.Count = 0 Then
                MessageBox.Show("No hay datos.Consulte por OC", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim PNNMOS_VALIDAR As String = dtgCostoItem.Rows(0).Cells("NORCML").Value.ToString.Trim
            Dim IsValidoOC As Boolean = True
            For Each Item As DataGridViewRow In dtgCostoItem.Rows
                If PNNMOS_VALIDAR <> Item.Cells("NORCML").Value.ToString.Trim Then
                    IsValidoOC = False
                    Exit For
                End If
            Next
            If IsValidoOC = False Then
                MessageBox.Show("Las Órdenes de Compra no son iguales.Busque por OC.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Dim oListCostoSumatorios As New Hashtable

            'Dim oListTexto As New List(Of String)

            'oListTexto.Add("NRITEM")
            'oListTexto.Add("PNNMOS")
            'oListTexto.Add("TNRODU") 'dua
            'oListTexto.Add("NDOCEM") 'BL/AWB
            'oListTexto.Add("TDITES")
            'oListTexto.Add("TTINTC") 'Incotern
            'oListTexto.Add("DESC_MERCAD_EMBARQUE")
            'oListTexto.Add("NDOCEM")
            'oListTexto.Add("NRO_DOC_FACTURA")


            'Dim oListCostoSumatorio As New List(Of String)

            'oListCostoSumatorios.Add("GFOB", 0)
            'oListCostoSumatorio.Add("GFOB")
            'oListCostoSumatorios.Add("TOTFOB", 0)
            'oListCostoSumatorio.Add("TOTFOB")
            'oListCostoSumatorios.Add("TOTFLT", 0)
            'oListCostoSumatorio.Add("TOTFLT")
            'oListCostoSumatorios.Add("TOTSEG", 0)
            'oListCostoSumatorio.Add("TOTSEG")
            'oListCostoSumatorios.Add("TOTOGS", 0)
            'oListCostoSumatorios.Add("TASDES", 0)
            'oListCostoSumatorio.Add("TOTOGS")
            'oListCostoSumatorios.Add("TOTADV", 0)
            'oListCostoSumatorio.Add("TOTADV")
            'oListCostoSumatorios.Add("TOTIGV", 0)
            'oListCostoSumatorio.Add("TOTIGV")
            'oListCostoSumatorios.Add("TOTIPM", 0)
            'oListCostoSumatorio.Add("TOTIPM")
            'oListCostoSumatorios.Add("VAL_MERCAD_FACTURA", 0)
            'oListCostoSumatorio.Add("VAL_MERCAD_FACTURA")
            'oListCostoSumatorios.Add("IVTOIT", 0)
            'oListCostoSumatorio.Add("IVTOIT")

            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim NameColumna As String = ""
            'Dim TipoDato As String = ""
            'Dim ColTitle As String = ""
            'Dim MdataColumna As String = ""
            Dim oCostoItem As New clsCostoItem
            Dim odtDatosgencia As New DataTable
            Dim odtDatosExportar As New DataTable
            Dim odtDatosCostosSIl As New DataTable

            odtDatosExportar.Columns.Add("NRITEM").Caption = NPOI_SC.FormatDato("Nro Item", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("NRITEM").Caption = "Nro Item"

            odtDatosExportar.Columns.Add("TDITES").Caption = NPOI_SC.FormatDato("Descripción", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("TDITES").Caption = "Descripción"

            odtDatosExportar.Columns.Add("QCNTIT").Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("QCNTIT").Caption = "Cantidad"

            odtDatosExportar.Columns.Add("IVUNIT").Caption = NPOI_SC.FormatDato("Valor Unitario", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("IVUNIT").Caption = "Valor Unitario"


            odtDatosExportar.Columns.Add("IVTOIT").Caption = NPOI_SC.FormatDato("Valor Total", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("IVTOIT").Caption = "Valor Total"

            odtDatosExportar.Columns.Add("TTINTC").Caption = NPOI_SC.FormatDato("INCOTERM", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("TTINTC").Caption = "INCOTERM"

            odtDatosExportar.Columns.Add("PNNMOS").Caption = NPOI_SC.FormatDato("Orden Servicio", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("PNNMOS").Caption = "Orden Servicio"

            odtDatosExportar.Columns.Add("TNRODU").Caption = NPOI_SC.FormatDato("Nro DUA", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("TNRODU").Caption = "Nro DUA"

            odtDatosExportar.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato("BL/AWB", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("NDOCEM").Caption = "BL/AWB"

            odtDatosExportar.Columns.Add("DESC_MERCAD_EMBARQUE").Caption = NPOI_SC.FormatDato("Descripción(Aduana)", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("DESC_MERCAD_EMBARQUE").Caption = "Descripción Embarque Aduana"

            odtDatosExportar.Columns.Add("NRO_DOC_FACTURA").Caption = NPOI_SC.FormatDato("Factura", NPOI_SC.keyDatoTexto)
            'odtDatosExportar.Columns("NRO_DOC_FACTURA").Caption = "Factura"


            odtDatosExportar.Columns.Add("VAL_MERCAD_FACTURA").Caption = NPOI_SC.FormatDato("Valor Factura", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("VAL_MERCAD_FACTURA").Caption = "Valor Factura"


            odtDatosExportar.Columns.Add("GFOB").Caption = NPOI_SC.FormatDato("Gastos FOB", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("GFOB").Caption = "Gastos FOB"

            odtDatosExportar.Columns.Add("TOTFOB").Caption = NPOI_SC.FormatDato("VALOR ADUANA |FOB", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTFOB").Caption = "FOB"

            odtDatosExportar.Columns.Add("TOTFLT").Caption = NPOI_SC.FormatDato("VALOR ADUANA |FLETE", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTFLT").Caption = "FLETE"

            odtDatosExportar.Columns.Add("TOTSEG").Caption = NPOI_SC.FormatDato("VALOR ADUANA |SEGURO", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTSEG").Caption = "SEGURO"


            'odtDatosExportar.Columns.Add("TOTOGS")
            'odtDatosExportar.Columns("TOTOGS").Caption = "TASA DESPACHO"

            odtDatosExportar.Columns.Add("TASDES").Caption = NPOI_SC.FormatDato("DERECHO ADUANA |TASA DESPACHO", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TASDES").Caption = "TASA DESPACHO"

            odtDatosExportar.Columns.Add("TOTADV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA |ADVALOREM", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTADV").Caption = "ADVALOREM"

            odtDatosExportar.Columns.Add("TOTIGV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA |IGV", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTIGV").Caption = "IGV"

            odtDatosExportar.Columns.Add("TOTIPM").Caption = NPOI_SC.FormatDato("DERECHO ADUANA |IPM", NPOI_SC.keyDatoNumero)
            'odtDatosExportar.Columns("TOTIPM").Caption = "IPM"

            Dim odtCierreOC As New DataTable
            odtCierreOC = Buscar_Costo_Cierre_OrdenCompra_Embarcado()

            Dim TITULO As String = ""
            TITULO = "CIERRE DE ORDEN DE COMPRA(" & cmbCliente.pCodigo & ") - " & cmbCliente.pRazonSocial
            If odtCierreOC.Rows.Count > 0 Then
                TITULO = "CIERRE DE ORDEN DE COMPRA(" & odtCierreOC.Rows(0)("CCLNT") & ") - " & odtCierreOC.Rows(0)("TCMPCL").ToString.Trim & " - " & odtCierreOC.Rows(0)("TMTVBJ").ToString.Trim
            End If

            'For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
            '    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
            '    If odtDatosExportar.Columns(NameColumna) IsNot Nothing Then
            '        Select Case NameColumna
            '            Case "TOTFOB", "TOTFLT", "TOTSEG"
            '                ColTitle = "VALOR ADUANA |" & odtDatosExportar.Columns(NameColumna).Caption
            '            Case "TOTOGS", "TOTADV", "TOTIGV", "TOTIPM"
            '                ColTitle = "DERECHO ADUANA |" & odtDatosExportar.Columns(NameColumna).Caption
            '            Case Else
            '                ColTitle = odtDatosExportar.Columns(NameColumna).Caption
            '        End Select
            '        If oListTexto.Contains(NameColumna) Then
            '            TipoDato = HelpClass_NPOI_SC.keyDatoTexto
            '        Else
            '            TipoDato = HelpClass_NPOI_SC.keyDatoNumero
            '        End If
            '        MdataColumna = NPOI.FormatDato(ColTitle, TipoDato)
            '        odtDatosExportar.Columns(NameColumna).Caption = MdataColumna
            '    End If
            'Next


            'oListCostoSumatorios.Add("GFOB", 0)
            'oListCostoSumatorio.Add("GFOB")
            'oListCostoSumatorios.Add("TOTFOB", 0)
            'oListCostoSumatorio.Add("TOTFOB")
            'oListCostoSumatorios.Add("TOTFLT", 0)
            'oListCostoSumatorio.Add("TOTFLT")
            'oListCostoSumatorios.Add("TOTSEG", 0)
            'oListCostoSumatorio.Add("TOTSEG")
            'oListCostoSumatorios.Add("TASDES", 0)
            'oListCostoSumatorio.Add("TOTOGS")
            'oListCostoSumatorios.Add("TOTADV", 0)
            'oListCostoSumatorio.Add("TOTADV")
            'oListCostoSumatorios.Add("TOTIGV", 0)
            'oListCostoSumatorio.Add("TOTIGV")
            'oListCostoSumatorios.Add("TOTIPM", 0)
            'oListCostoSumatorio.Add("TOTIPM")
            'oListCostoSumatorios.Add("VAL_MERCAD_FACTURA", 0)
            'oListCostoSumatorio.Add("VAL_MERCAD_FACTURA")
            'oListCostoSumatorios.Add("IVTOIT", 0)
            'oListCostoSumatorio.Add("IVTOIT")



            Dim dr As DataRow
            Dim ListVisitados As New Hashtable
            Dim NRITEM As String = ""
            For Fila As Integer = 0 To odtCierreOC.Rows.Count - 1
                dr = odtDatosExportar.NewRow
                NRITEM = odtCierreOC.Rows(Fila)("NRITEM")
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If (odtCierreOC.Rows(Fila).Item(NameColumna) IsNot Nothing) Then
                        Select Case NameColumna
                            'Case "TOTOGS", "TOTADV", "TOTIGV", "TOTIPM"
                            Case "TASDES", "TOTADV", "TOTIGV", "TOTIPM"
                                'PARA VALORES DE DERECHO ADUANA ES NECESARIO 
                                'REDONDEARLOS
                                dr(NameColumna) = Math.Round(odtCierreOC.Rows(Fila).Item(NameColumna), 0)
                            Case "QCNTIT", "IVUNIT", "IVTOIT", "VAL_MERCAD_FACTURA", "TOTFOB", _
                                 "TOTFLT", "TOTSEG", "TOTCIF", "GFOB", "ITTEXW"
                                dr(NameColumna) = Math.Round(odtCierreOC.Rows(Fila).Item(NameColumna), 2)
                            Case Else
                                dr(NameColumna) = odtCierreOC.Rows(Fila).Item(NameColumna)
                        End Select


                    End If
                Next
                'CUANDO SE COMBINAN COLUMNAS TIPO MONTOS
                'ES NECESARIO QUE A PARTIR DE LA SEGUNDA FILA QUE SE REPITA SU VALOR SEA CERO 
                'PARA NO DUPLICAR SUMAS TOTALES POR COLUMNA EN EL EXCEL
                '****************************
                If Not ListVisitados.Contains(NRITEM) Then
                    ListVisitados.Add(NRITEM, NRITEM)
                Else
                    dr("QCNTIT") = 0
                    dr("IVUNIT") = 0
                    dr("IVTOIT") = 0
                End If
                '***************************
                odtDatosExportar.Rows.Add(dr)
            Next


            Dim oListCostoSumatorios As New Hashtable
            Dim ListNroItemSumado As New List(Of Decimal)
            For Fila As Integer = 0 To odtCierreOC.Rows.Count - 1
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    'If oListCostoSumatorios.ContainsKey(NameColumna) Then
                    'Select Case NameColumna
                    '    Case "IVTOIT"
                    '        If Not ListNroItemSumado.Contains(odtDatosExportar.Rows(Fila)("NRITEM")) Then
                    '            ListNroItemSumado.Add(odtDatosExportar.Rows(Fila)("NRITEM"))
                    '            oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(Fila)(NameColumna)
                    '        Else
                    '            odtDatosExportar.Rows(Fila)("IVTOIT") = 0
                    '        End If
                    '    Case "GFOB", "TOTFOB", "TOTFLT", "TOTSEG", "TASDES", "TOTADV", "TOTIGV", "TOTIPM", "VAL_MERCAD_FACTURA", "IVTOIT"
                    '        oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(Fila)(NameColumna)
                    'End Select
                    'End If
                    Select Case NameColumna
                        Case "GFOB", "TOTFOB", "TOTFLT", "TOTSEG", "TASDES", "TOTADV", "TOTIGV", "TOTIPM", "VAL_MERCAD_FACTURA", "IVTOIT"
                            If Not oListCostoSumatorios.Contains(NameColumna) Then
                                oListCostoSumatorios.Add(NameColumna, 0)
                            End If
                            oListCostoSumatorios(NameColumna) = Convert.ToDecimal(oListCostoSumatorios(NameColumna)) + odtDatosExportar.Rows(Fila)(NameColumna)
                    End Select
                Next
            Next
            dr = odtDatosExportar.NewRow
            For Each item As DictionaryEntry In oListCostoSumatorios
                dr(item.Key) = item.Value
            Next
            odtDatosExportar.Rows.Add(dr)

            For Fila As Integer = odtDatosExportar.Rows.Count - 1 To odtDatosExportar.Rows.Count - 1
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If Not oListCostoSumatorios.ContainsKey(NameColumna) Then
                        odtDatosExportar.Rows(Fila)(NameColumna) = DBNull.Value
                    End If
                Next
            Next
            Dim NORMCL As String = ("" & dtgCostoItem.Rows(0).Cells("NORCML").Value).ToString.Trim
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "ORDEN DE COMPRA :|" & NORMCL

            'Dim oListFormatComaMiles As New List(Of String)

            'oListFormatComaMiles.Add("VAL_MERCAD_FACTURA")
            'oListFormatComaMiles.Add("TOTFOB")
            'oListFormatComaMiles.Add("TOTFLT")
            'oListFormatComaMiles.Add("TOTSEG")
            'oListFormatComaMiles.Add("TOTCIF")
            'oListFormatComaMiles.Add("TOTADV")
            'oListFormatComaMiles.Add("TOTIGV")
            'oListFormatComaMiles.Add("TOTIPM")
            ''oListFormatComaMiles.Add("TOTOGS")
            'oListFormatComaMiles.Add("TASDES")
            'oListFormatComaMiles.Add("GFOB")
            'oListFormatComaMiles.Add("QCNTIT")
            'oListFormatComaMiles.Add("IVUNIT")
            'oListFormatComaMiles.Add("IVTOIT")
            'oListFormatComaMiles.Add("IVTOIT")
            'NPOI.ExportExcelCierreOrdenCompra(odtDatosExportar, TITULO, oListFormatComaMiles, oListCostoSumatorio, oLisParametros)


            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtDatosExportar)
            'ListaDatatable.Add(odtExp.Copy)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add(TITULO)


            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "ORDEN DE COMPRA :|" & NORMCL)
            LisFiltros.Add(itemSortedList)


            'odtDatosExportar.Columns.Add("NRITEM").Caption = NPOI.FormatDato("Nro Item", HelpClass_NPOI_SC.keyDatoTexto)
            ''odtDatosExportar.Columns("NRITEM").Caption = "Nro Item"

            'odtDatosExportar.Columns.Add("TDITES").Caption = NPOI.FormatDato("Descripción", HelpClass_NPOI_SC.keyDatoTexto)
            ''odtDatosExportar.Columns("TDITES").Caption = "Descripción"

            'odtDatosExportar.Columns.Add("QCNTIT").Caption = NPOI.FormatDato("Cantidad", HelpClass_NPOI_SC.keyDatoNumero)
            ''odtDatosExportar.Columns("QCNTIT").Caption = "Cantidad"

            'odtDatosExportar.Columns.Add("IVUNIT").Caption = NPOI.FormatDato("Valor Unitario", HelpClass_NPOI_SC.keyDatoNumero)
            ''odtDatosExportar.Columns("IVUNIT").Caption = "Valor Unitario"


            'odtDatosExportar.Columns.Add("IVTOIT").Caption = NPOI.FormatDato("Valor Total", HelpClass_NPOI_SC.keyDatoNumero)
            ''odtDatosExportar.Columns("IVTOIT").Caption = "Valor Total"

            'odtDatosExportar.Columns.Add("TTINTC").Caption = NPOI.FormatDato("INCOTERM", HelpClass_NPOI_SC.keyDatoTexto)


            Dim ListNameCombDuplicado As New List(Of String)
            Dim CombCol As String
            ''INFORMACIÓN GENERAL
            CombCol = "NRITEM:NRITEM/1|TDITES:NRITEM,TDITES/1|QCNTIT:NRITEM,QCNTIT/0|IVUNIT:NRITEM,IVUNIT/0|IVTOIT:NRITEM,IVTOIT/0|TTINTC:NRITEM,TTINTC/1"
            ListNameCombDuplicado.Add(CombCol)


            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 1, ListNameCombDuplicado)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim sbmensaje As String = ""
            sbmensaje = Verificar_Ingreso_Filtros()
            If (sbmensaje.Length > 0) Then
                MessageBox.Show(sbmensaje, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Buscar_Costo_X_Item()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

  
    Private Sub tsCierreGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCierreGeneral.Click
        Try
           
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim NameColumna As String = ""
            Dim TipoDato As String = ""
            Dim ColTitle As String = ""
            Dim MdataColumna As String = ""
            Dim oCostoItem As New clsCostoItem
            Dim odtDatosExportar As New DataTable
         
            odtDatosExportar.Columns.Add("NORSCI").Caption = NPOI_SC.FormatDato("Embarque", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("PNNMOS").Caption = NPOI_SC.FormatDato("Orden de Servicio", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TNRODU").Caption = NPOI_SC.FormatDato("N° DUA", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("NORCML").Caption = NPOI_SC.FormatDato("Orden Compra", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("NRITEM").Caption = NPOI_SC.FormatDato("Item", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("SBITOC").Caption = NPOI_SC.FormatDato("SubItem", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("NFCTCM").Caption = NPOI_SC.FormatDato("N° Factura", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("NMITFC").Caption = NPOI_SC.FormatDato("Item-Fact", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TDITES").Caption = NPOI_SC.FormatDato("Descripción item", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TPRVCL").Caption = NPOI_SC.FormatDato("Proveedor", NPOI_SC.keyDatoTexto)
            odtDatosExportar.Columns.Add("TOTFOB").Caption = NPOI_SC.FormatDato("VALOR ADUANA|FOB", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTFLT").Caption = NPOI_SC.FormatDato("VALOR ADUANA|FLETE", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTSEG").Caption = NPOI_SC.FormatDato("VALOR ADUANA|SEGURO", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTCIF").Caption = NPOI_SC.FormatDato("VALOR ADUANA|CIF", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTADV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA|ADV", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTIGV").Caption = NPOI_SC.FormatDato("DERECHO ADUANA|IGV", NPOI_SC.keyDatoNumero)
            odtDatosExportar.Columns.Add("TOTIPM").Caption = NPOI_SC.FormatDato("DERECHO ADUANA|IPM", NPOI_SC.keyDatoNumero)
            Dim dr As DataRow
            For Fila As Integer = 0 To dtgCostoItem.Rows.Count - 1
                dr = odtDatosExportar.NewRow
                For Columna As Integer = 0 To odtDatosExportar.Columns.Count - 1
                    NameColumna = odtDatosExportar.Columns(Columna).ColumnName
                    If (dtgCostoItem.Rows(Fila).Cells(NameColumna).Value IsNot Nothing) Then
                        dr(NameColumna) = dtgCostoItem.Rows(Fila).Cells(NameColumna).FormattedValue
                    End If
                Next
                odtDatosExportar.Rows.Add(dr)
            Next

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtDatosExportar.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Desde:|" & dtpFecIni.Value.ToString("dd/MM/yyyy") & " Al " & dtpFecFin.Value.ToString("dd/MM/yyyyy"))

            LisFiltros.Add(itemSortedList)
            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("CIERRE ORDEN DE COMPRA (" & cmbCliente.pCodigo & ") - " & cmbCliente.pRazonSocial)
            Dim ListNameCombDuplicado As New List(Of String)
            Dim ListColumnaSuma As New List(Of String)
            'ListColumnaSuma.Add("TOTFOB|TOTFLT|TOTSEG|TOTCIF|TOTADV|TOTIGV|TOTIPM")
            Dim CombCol As String = "NORSCI:NORSCI/1|PNNMOS:NORSCI,PNNMOS/1|TNRODU:NORSCI,TNRODU/1|NFCTCM:NORSCI,NFCTCM/1"
            ListNameCombDuplicado.Add(CombCol)
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, ListNameCombDuplicado, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
